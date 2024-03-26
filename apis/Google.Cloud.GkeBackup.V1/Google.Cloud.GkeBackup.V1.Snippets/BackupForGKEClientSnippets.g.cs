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
    using Google.Cloud.GkeBackup.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedBackupForGKEClientSnippets
    {
        /// <summary>Snippet for CreateBackupPlan</summary>
        public void CreateBackupPlanRequestObject()
        {
            // Snippet: CreateBackupPlan(CreateBackupPlanRequest, CallSettings)
            // Create client
            BackupForGKEClient backupForGKEClient = BackupForGKEClient.Create();
            // Initialize request argument(s)
            CreateBackupPlanRequest request = new CreateBackupPlanRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                BackupPlan = new BackupPlan(),
                BackupPlanId = "",
            };
            // Make the request
            Operation<BackupPlan, OperationMetadata> response = backupForGKEClient.CreateBackupPlan(request);

            // Poll until the returned long-running operation is complete
            Operation<BackupPlan, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BackupPlan result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BackupPlan, OperationMetadata> retrievedResponse = backupForGKEClient.PollOnceCreateBackupPlan(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BackupPlan retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateBackupPlanAsync</summary>
        public async Task CreateBackupPlanRequestObjectAsync()
        {
            // Snippet: CreateBackupPlanAsync(CreateBackupPlanRequest, CallSettings)
            // Additional: CreateBackupPlanAsync(CreateBackupPlanRequest, CancellationToken)
            // Create client
            BackupForGKEClient backupForGKEClient = await BackupForGKEClient.CreateAsync();
            // Initialize request argument(s)
            CreateBackupPlanRequest request = new CreateBackupPlanRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                BackupPlan = new BackupPlan(),
                BackupPlanId = "",
            };
            // Make the request
            Operation<BackupPlan, OperationMetadata> response = await backupForGKEClient.CreateBackupPlanAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<BackupPlan, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BackupPlan result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BackupPlan, OperationMetadata> retrievedResponse = await backupForGKEClient.PollOnceCreateBackupPlanAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BackupPlan retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateBackupPlan</summary>
        public void CreateBackupPlan()
        {
            // Snippet: CreateBackupPlan(string, BackupPlan, string, CallSettings)
            // Create client
            BackupForGKEClient backupForGKEClient = BackupForGKEClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            BackupPlan backupPlan = new BackupPlan();
            string backupPlanId = "";
            // Make the request
            Operation<BackupPlan, OperationMetadata> response = backupForGKEClient.CreateBackupPlan(parent, backupPlan, backupPlanId);

            // Poll until the returned long-running operation is complete
            Operation<BackupPlan, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BackupPlan result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BackupPlan, OperationMetadata> retrievedResponse = backupForGKEClient.PollOnceCreateBackupPlan(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BackupPlan retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateBackupPlanAsync</summary>
        public async Task CreateBackupPlanAsync()
        {
            // Snippet: CreateBackupPlanAsync(string, BackupPlan, string, CallSettings)
            // Additional: CreateBackupPlanAsync(string, BackupPlan, string, CancellationToken)
            // Create client
            BackupForGKEClient backupForGKEClient = await BackupForGKEClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            BackupPlan backupPlan = new BackupPlan();
            string backupPlanId = "";
            // Make the request
            Operation<BackupPlan, OperationMetadata> response = await backupForGKEClient.CreateBackupPlanAsync(parent, backupPlan, backupPlanId);

            // Poll until the returned long-running operation is complete
            Operation<BackupPlan, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BackupPlan result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BackupPlan, OperationMetadata> retrievedResponse = await backupForGKEClient.PollOnceCreateBackupPlanAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BackupPlan retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateBackupPlan</summary>
        public void CreateBackupPlanResourceNames()
        {
            // Snippet: CreateBackupPlan(LocationName, BackupPlan, string, CallSettings)
            // Create client
            BackupForGKEClient backupForGKEClient = BackupForGKEClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            BackupPlan backupPlan = new BackupPlan();
            string backupPlanId = "";
            // Make the request
            Operation<BackupPlan, OperationMetadata> response = backupForGKEClient.CreateBackupPlan(parent, backupPlan, backupPlanId);

            // Poll until the returned long-running operation is complete
            Operation<BackupPlan, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BackupPlan result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BackupPlan, OperationMetadata> retrievedResponse = backupForGKEClient.PollOnceCreateBackupPlan(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BackupPlan retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateBackupPlanAsync</summary>
        public async Task CreateBackupPlanResourceNamesAsync()
        {
            // Snippet: CreateBackupPlanAsync(LocationName, BackupPlan, string, CallSettings)
            // Additional: CreateBackupPlanAsync(LocationName, BackupPlan, string, CancellationToken)
            // Create client
            BackupForGKEClient backupForGKEClient = await BackupForGKEClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            BackupPlan backupPlan = new BackupPlan();
            string backupPlanId = "";
            // Make the request
            Operation<BackupPlan, OperationMetadata> response = await backupForGKEClient.CreateBackupPlanAsync(parent, backupPlan, backupPlanId);

            // Poll until the returned long-running operation is complete
            Operation<BackupPlan, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BackupPlan result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BackupPlan, OperationMetadata> retrievedResponse = await backupForGKEClient.PollOnceCreateBackupPlanAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BackupPlan retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListBackupPlans</summary>
        public void ListBackupPlansRequestObject()
        {
            // Snippet: ListBackupPlans(ListBackupPlansRequest, CallSettings)
            // Create client
            BackupForGKEClient backupForGKEClient = BackupForGKEClient.Create();
            // Initialize request argument(s)
            ListBackupPlansRequest request = new ListBackupPlansRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListBackupPlansResponse, BackupPlan> response = backupForGKEClient.ListBackupPlans(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (BackupPlan item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListBackupPlansResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BackupPlan item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BackupPlan> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BackupPlan item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBackupPlansAsync</summary>
        public async Task ListBackupPlansRequestObjectAsync()
        {
            // Snippet: ListBackupPlansAsync(ListBackupPlansRequest, CallSettings)
            // Create client
            BackupForGKEClient backupForGKEClient = await BackupForGKEClient.CreateAsync();
            // Initialize request argument(s)
            ListBackupPlansRequest request = new ListBackupPlansRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListBackupPlansResponse, BackupPlan> response = backupForGKEClient.ListBackupPlansAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((BackupPlan item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListBackupPlansResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BackupPlan item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BackupPlan> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BackupPlan item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBackupPlans</summary>
        public void ListBackupPlans()
        {
            // Snippet: ListBackupPlans(string, string, int?, CallSettings)
            // Create client
            BackupForGKEClient backupForGKEClient = BackupForGKEClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListBackupPlansResponse, BackupPlan> response = backupForGKEClient.ListBackupPlans(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (BackupPlan item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListBackupPlansResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BackupPlan item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BackupPlan> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BackupPlan item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBackupPlansAsync</summary>
        public async Task ListBackupPlansAsync()
        {
            // Snippet: ListBackupPlansAsync(string, string, int?, CallSettings)
            // Create client
            BackupForGKEClient backupForGKEClient = await BackupForGKEClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListBackupPlansResponse, BackupPlan> response = backupForGKEClient.ListBackupPlansAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((BackupPlan item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListBackupPlansResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BackupPlan item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BackupPlan> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BackupPlan item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBackupPlans</summary>
        public void ListBackupPlansResourceNames()
        {
            // Snippet: ListBackupPlans(LocationName, string, int?, CallSettings)
            // Create client
            BackupForGKEClient backupForGKEClient = BackupForGKEClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListBackupPlansResponse, BackupPlan> response = backupForGKEClient.ListBackupPlans(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (BackupPlan item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListBackupPlansResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BackupPlan item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BackupPlan> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BackupPlan item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBackupPlansAsync</summary>
        public async Task ListBackupPlansResourceNamesAsync()
        {
            // Snippet: ListBackupPlansAsync(LocationName, string, int?, CallSettings)
            // Create client
            BackupForGKEClient backupForGKEClient = await BackupForGKEClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListBackupPlansResponse, BackupPlan> response = backupForGKEClient.ListBackupPlansAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((BackupPlan item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListBackupPlansResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BackupPlan item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BackupPlan> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BackupPlan item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetBackupPlan</summary>
        public void GetBackupPlanRequestObject()
        {
            // Snippet: GetBackupPlan(GetBackupPlanRequest, CallSettings)
            // Create client
            BackupForGKEClient backupForGKEClient = BackupForGKEClient.Create();
            // Initialize request argument(s)
            GetBackupPlanRequest request = new GetBackupPlanRequest
            {
                BackupPlanName = BackupPlanName.FromProjectLocationBackupPlan("[PROJECT]", "[LOCATION]", "[BACKUP_PLAN]"),
            };
            // Make the request
            BackupPlan response = backupForGKEClient.GetBackupPlan(request);
            // End snippet
        }

        /// <summary>Snippet for GetBackupPlanAsync</summary>
        public async Task GetBackupPlanRequestObjectAsync()
        {
            // Snippet: GetBackupPlanAsync(GetBackupPlanRequest, CallSettings)
            // Additional: GetBackupPlanAsync(GetBackupPlanRequest, CancellationToken)
            // Create client
            BackupForGKEClient backupForGKEClient = await BackupForGKEClient.CreateAsync();
            // Initialize request argument(s)
            GetBackupPlanRequest request = new GetBackupPlanRequest
            {
                BackupPlanName = BackupPlanName.FromProjectLocationBackupPlan("[PROJECT]", "[LOCATION]", "[BACKUP_PLAN]"),
            };
            // Make the request
            BackupPlan response = await backupForGKEClient.GetBackupPlanAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetBackupPlan</summary>
        public void GetBackupPlan()
        {
            // Snippet: GetBackupPlan(string, CallSettings)
            // Create client
            BackupForGKEClient backupForGKEClient = BackupForGKEClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/backupPlans/[BACKUP_PLAN]";
            // Make the request
            BackupPlan response = backupForGKEClient.GetBackupPlan(name);
            // End snippet
        }

        /// <summary>Snippet for GetBackupPlanAsync</summary>
        public async Task GetBackupPlanAsync()
        {
            // Snippet: GetBackupPlanAsync(string, CallSettings)
            // Additional: GetBackupPlanAsync(string, CancellationToken)
            // Create client
            BackupForGKEClient backupForGKEClient = await BackupForGKEClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/backupPlans/[BACKUP_PLAN]";
            // Make the request
            BackupPlan response = await backupForGKEClient.GetBackupPlanAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetBackupPlan</summary>
        public void GetBackupPlanResourceNames()
        {
            // Snippet: GetBackupPlan(BackupPlanName, CallSettings)
            // Create client
            BackupForGKEClient backupForGKEClient = BackupForGKEClient.Create();
            // Initialize request argument(s)
            BackupPlanName name = BackupPlanName.FromProjectLocationBackupPlan("[PROJECT]", "[LOCATION]", "[BACKUP_PLAN]");
            // Make the request
            BackupPlan response = backupForGKEClient.GetBackupPlan(name);
            // End snippet
        }

        /// <summary>Snippet for GetBackupPlanAsync</summary>
        public async Task GetBackupPlanResourceNamesAsync()
        {
            // Snippet: GetBackupPlanAsync(BackupPlanName, CallSettings)
            // Additional: GetBackupPlanAsync(BackupPlanName, CancellationToken)
            // Create client
            BackupForGKEClient backupForGKEClient = await BackupForGKEClient.CreateAsync();
            // Initialize request argument(s)
            BackupPlanName name = BackupPlanName.FromProjectLocationBackupPlan("[PROJECT]", "[LOCATION]", "[BACKUP_PLAN]");
            // Make the request
            BackupPlan response = await backupForGKEClient.GetBackupPlanAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateBackupPlan</summary>
        public void UpdateBackupPlanRequestObject()
        {
            // Snippet: UpdateBackupPlan(UpdateBackupPlanRequest, CallSettings)
            // Create client
            BackupForGKEClient backupForGKEClient = BackupForGKEClient.Create();
            // Initialize request argument(s)
            UpdateBackupPlanRequest request = new UpdateBackupPlanRequest
            {
                BackupPlan = new BackupPlan(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<BackupPlan, OperationMetadata> response = backupForGKEClient.UpdateBackupPlan(request);

            // Poll until the returned long-running operation is complete
            Operation<BackupPlan, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BackupPlan result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BackupPlan, OperationMetadata> retrievedResponse = backupForGKEClient.PollOnceUpdateBackupPlan(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BackupPlan retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateBackupPlanAsync</summary>
        public async Task UpdateBackupPlanRequestObjectAsync()
        {
            // Snippet: UpdateBackupPlanAsync(UpdateBackupPlanRequest, CallSettings)
            // Additional: UpdateBackupPlanAsync(UpdateBackupPlanRequest, CancellationToken)
            // Create client
            BackupForGKEClient backupForGKEClient = await BackupForGKEClient.CreateAsync();
            // Initialize request argument(s)
            UpdateBackupPlanRequest request = new UpdateBackupPlanRequest
            {
                BackupPlan = new BackupPlan(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<BackupPlan, OperationMetadata> response = await backupForGKEClient.UpdateBackupPlanAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<BackupPlan, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BackupPlan result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BackupPlan, OperationMetadata> retrievedResponse = await backupForGKEClient.PollOnceUpdateBackupPlanAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BackupPlan retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateBackupPlan</summary>
        public void UpdateBackupPlan()
        {
            // Snippet: UpdateBackupPlan(BackupPlan, FieldMask, CallSettings)
            // Create client
            BackupForGKEClient backupForGKEClient = BackupForGKEClient.Create();
            // Initialize request argument(s)
            BackupPlan backupPlan = new BackupPlan();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<BackupPlan, OperationMetadata> response = backupForGKEClient.UpdateBackupPlan(backupPlan, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<BackupPlan, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BackupPlan result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BackupPlan, OperationMetadata> retrievedResponse = backupForGKEClient.PollOnceUpdateBackupPlan(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BackupPlan retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateBackupPlanAsync</summary>
        public async Task UpdateBackupPlanAsync()
        {
            // Snippet: UpdateBackupPlanAsync(BackupPlan, FieldMask, CallSettings)
            // Additional: UpdateBackupPlanAsync(BackupPlan, FieldMask, CancellationToken)
            // Create client
            BackupForGKEClient backupForGKEClient = await BackupForGKEClient.CreateAsync();
            // Initialize request argument(s)
            BackupPlan backupPlan = new BackupPlan();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<BackupPlan, OperationMetadata> response = await backupForGKEClient.UpdateBackupPlanAsync(backupPlan, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<BackupPlan, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BackupPlan result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BackupPlan, OperationMetadata> retrievedResponse = await backupForGKEClient.PollOnceUpdateBackupPlanAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BackupPlan retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteBackupPlan</summary>
        public void DeleteBackupPlanRequestObject()
        {
            // Snippet: DeleteBackupPlan(DeleteBackupPlanRequest, CallSettings)
            // Create client
            BackupForGKEClient backupForGKEClient = BackupForGKEClient.Create();
            // Initialize request argument(s)
            DeleteBackupPlanRequest request = new DeleteBackupPlanRequest
            {
                BackupPlanName = BackupPlanName.FromProjectLocationBackupPlan("[PROJECT]", "[LOCATION]", "[BACKUP_PLAN]"),
                Etag = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = backupForGKEClient.DeleteBackupPlan(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = backupForGKEClient.PollOnceDeleteBackupPlan(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteBackupPlanAsync</summary>
        public async Task DeleteBackupPlanRequestObjectAsync()
        {
            // Snippet: DeleteBackupPlanAsync(DeleteBackupPlanRequest, CallSettings)
            // Additional: DeleteBackupPlanAsync(DeleteBackupPlanRequest, CancellationToken)
            // Create client
            BackupForGKEClient backupForGKEClient = await BackupForGKEClient.CreateAsync();
            // Initialize request argument(s)
            DeleteBackupPlanRequest request = new DeleteBackupPlanRequest
            {
                BackupPlanName = BackupPlanName.FromProjectLocationBackupPlan("[PROJECT]", "[LOCATION]", "[BACKUP_PLAN]"),
                Etag = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await backupForGKEClient.DeleteBackupPlanAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await backupForGKEClient.PollOnceDeleteBackupPlanAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteBackupPlan</summary>
        public void DeleteBackupPlan()
        {
            // Snippet: DeleteBackupPlan(string, CallSettings)
            // Create client
            BackupForGKEClient backupForGKEClient = BackupForGKEClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/backupPlans/[BACKUP_PLAN]";
            // Make the request
            Operation<Empty, OperationMetadata> response = backupForGKEClient.DeleteBackupPlan(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = backupForGKEClient.PollOnceDeleteBackupPlan(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteBackupPlanAsync</summary>
        public async Task DeleteBackupPlanAsync()
        {
            // Snippet: DeleteBackupPlanAsync(string, CallSettings)
            // Additional: DeleteBackupPlanAsync(string, CancellationToken)
            // Create client
            BackupForGKEClient backupForGKEClient = await BackupForGKEClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/backupPlans/[BACKUP_PLAN]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await backupForGKEClient.DeleteBackupPlanAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await backupForGKEClient.PollOnceDeleteBackupPlanAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteBackupPlan</summary>
        public void DeleteBackupPlanResourceNames()
        {
            // Snippet: DeleteBackupPlan(BackupPlanName, CallSettings)
            // Create client
            BackupForGKEClient backupForGKEClient = BackupForGKEClient.Create();
            // Initialize request argument(s)
            BackupPlanName name = BackupPlanName.FromProjectLocationBackupPlan("[PROJECT]", "[LOCATION]", "[BACKUP_PLAN]");
            // Make the request
            Operation<Empty, OperationMetadata> response = backupForGKEClient.DeleteBackupPlan(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = backupForGKEClient.PollOnceDeleteBackupPlan(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteBackupPlanAsync</summary>
        public async Task DeleteBackupPlanResourceNamesAsync()
        {
            // Snippet: DeleteBackupPlanAsync(BackupPlanName, CallSettings)
            // Additional: DeleteBackupPlanAsync(BackupPlanName, CancellationToken)
            // Create client
            BackupForGKEClient backupForGKEClient = await BackupForGKEClient.CreateAsync();
            // Initialize request argument(s)
            BackupPlanName name = BackupPlanName.FromProjectLocationBackupPlan("[PROJECT]", "[LOCATION]", "[BACKUP_PLAN]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await backupForGKEClient.DeleteBackupPlanAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await backupForGKEClient.PollOnceDeleteBackupPlanAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateBackup</summary>
        public void CreateBackupRequestObject()
        {
            // Snippet: CreateBackup(CreateBackupRequest, CallSettings)
            // Create client
            BackupForGKEClient backupForGKEClient = BackupForGKEClient.Create();
            // Initialize request argument(s)
            CreateBackupRequest request = new CreateBackupRequest
            {
                ParentAsBackupPlanName = BackupPlanName.FromProjectLocationBackupPlan("[PROJECT]", "[LOCATION]", "[BACKUP_PLAN]"),
                Backup = new Backup(),
                BackupId = "",
            };
            // Make the request
            Operation<Backup, OperationMetadata> response = backupForGKEClient.CreateBackup(request);

            // Poll until the returned long-running operation is complete
            Operation<Backup, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Backup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Backup, OperationMetadata> retrievedResponse = backupForGKEClient.PollOnceCreateBackup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Backup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateBackupAsync</summary>
        public async Task CreateBackupRequestObjectAsync()
        {
            // Snippet: CreateBackupAsync(CreateBackupRequest, CallSettings)
            // Additional: CreateBackupAsync(CreateBackupRequest, CancellationToken)
            // Create client
            BackupForGKEClient backupForGKEClient = await BackupForGKEClient.CreateAsync();
            // Initialize request argument(s)
            CreateBackupRequest request = new CreateBackupRequest
            {
                ParentAsBackupPlanName = BackupPlanName.FromProjectLocationBackupPlan("[PROJECT]", "[LOCATION]", "[BACKUP_PLAN]"),
                Backup = new Backup(),
                BackupId = "",
            };
            // Make the request
            Operation<Backup, OperationMetadata> response = await backupForGKEClient.CreateBackupAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Backup, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Backup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Backup, OperationMetadata> retrievedResponse = await backupForGKEClient.PollOnceCreateBackupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Backup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateBackup</summary>
        public void CreateBackup()
        {
            // Snippet: CreateBackup(string, Backup, string, CallSettings)
            // Create client
            BackupForGKEClient backupForGKEClient = BackupForGKEClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/backupPlans/[BACKUP_PLAN]";
            Backup backup = new Backup();
            string backupId = "";
            // Make the request
            Operation<Backup, OperationMetadata> response = backupForGKEClient.CreateBackup(parent, backup, backupId);

            // Poll until the returned long-running operation is complete
            Operation<Backup, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Backup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Backup, OperationMetadata> retrievedResponse = backupForGKEClient.PollOnceCreateBackup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Backup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateBackupAsync</summary>
        public async Task CreateBackupAsync()
        {
            // Snippet: CreateBackupAsync(string, Backup, string, CallSettings)
            // Additional: CreateBackupAsync(string, Backup, string, CancellationToken)
            // Create client
            BackupForGKEClient backupForGKEClient = await BackupForGKEClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/backupPlans/[BACKUP_PLAN]";
            Backup backup = new Backup();
            string backupId = "";
            // Make the request
            Operation<Backup, OperationMetadata> response = await backupForGKEClient.CreateBackupAsync(parent, backup, backupId);

            // Poll until the returned long-running operation is complete
            Operation<Backup, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Backup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Backup, OperationMetadata> retrievedResponse = await backupForGKEClient.PollOnceCreateBackupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Backup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateBackup</summary>
        public void CreateBackupResourceNames()
        {
            // Snippet: CreateBackup(BackupPlanName, Backup, string, CallSettings)
            // Create client
            BackupForGKEClient backupForGKEClient = BackupForGKEClient.Create();
            // Initialize request argument(s)
            BackupPlanName parent = BackupPlanName.FromProjectLocationBackupPlan("[PROJECT]", "[LOCATION]", "[BACKUP_PLAN]");
            Backup backup = new Backup();
            string backupId = "";
            // Make the request
            Operation<Backup, OperationMetadata> response = backupForGKEClient.CreateBackup(parent, backup, backupId);

            // Poll until the returned long-running operation is complete
            Operation<Backup, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Backup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Backup, OperationMetadata> retrievedResponse = backupForGKEClient.PollOnceCreateBackup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Backup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateBackupAsync</summary>
        public async Task CreateBackupResourceNamesAsync()
        {
            // Snippet: CreateBackupAsync(BackupPlanName, Backup, string, CallSettings)
            // Additional: CreateBackupAsync(BackupPlanName, Backup, string, CancellationToken)
            // Create client
            BackupForGKEClient backupForGKEClient = await BackupForGKEClient.CreateAsync();
            // Initialize request argument(s)
            BackupPlanName parent = BackupPlanName.FromProjectLocationBackupPlan("[PROJECT]", "[LOCATION]", "[BACKUP_PLAN]");
            Backup backup = new Backup();
            string backupId = "";
            // Make the request
            Operation<Backup, OperationMetadata> response = await backupForGKEClient.CreateBackupAsync(parent, backup, backupId);

            // Poll until the returned long-running operation is complete
            Operation<Backup, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Backup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Backup, OperationMetadata> retrievedResponse = await backupForGKEClient.PollOnceCreateBackupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Backup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListBackups</summary>
        public void ListBackupsRequestObject()
        {
            // Snippet: ListBackups(ListBackupsRequest, CallSettings)
            // Create client
            BackupForGKEClient backupForGKEClient = BackupForGKEClient.Create();
            // Initialize request argument(s)
            ListBackupsRequest request = new ListBackupsRequest
            {
                ParentAsBackupPlanName = BackupPlanName.FromProjectLocationBackupPlan("[PROJECT]", "[LOCATION]", "[BACKUP_PLAN]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListBackupsResponse, Backup> response = backupForGKEClient.ListBackups(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Backup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListBackupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Backup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Backup> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Backup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBackupsAsync</summary>
        public async Task ListBackupsRequestObjectAsync()
        {
            // Snippet: ListBackupsAsync(ListBackupsRequest, CallSettings)
            // Create client
            BackupForGKEClient backupForGKEClient = await BackupForGKEClient.CreateAsync();
            // Initialize request argument(s)
            ListBackupsRequest request = new ListBackupsRequest
            {
                ParentAsBackupPlanName = BackupPlanName.FromProjectLocationBackupPlan("[PROJECT]", "[LOCATION]", "[BACKUP_PLAN]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListBackupsResponse, Backup> response = backupForGKEClient.ListBackupsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Backup item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListBackupsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Backup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Backup> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Backup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBackups</summary>
        public void ListBackups()
        {
            // Snippet: ListBackups(string, string, int?, CallSettings)
            // Create client
            BackupForGKEClient backupForGKEClient = BackupForGKEClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/backupPlans/[BACKUP_PLAN]";
            // Make the request
            PagedEnumerable<ListBackupsResponse, Backup> response = backupForGKEClient.ListBackups(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Backup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListBackupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Backup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Backup> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Backup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBackupsAsync</summary>
        public async Task ListBackupsAsync()
        {
            // Snippet: ListBackupsAsync(string, string, int?, CallSettings)
            // Create client
            BackupForGKEClient backupForGKEClient = await BackupForGKEClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/backupPlans/[BACKUP_PLAN]";
            // Make the request
            PagedAsyncEnumerable<ListBackupsResponse, Backup> response = backupForGKEClient.ListBackupsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Backup item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListBackupsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Backup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Backup> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Backup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBackups</summary>
        public void ListBackupsResourceNames()
        {
            // Snippet: ListBackups(BackupPlanName, string, int?, CallSettings)
            // Create client
            BackupForGKEClient backupForGKEClient = BackupForGKEClient.Create();
            // Initialize request argument(s)
            BackupPlanName parent = BackupPlanName.FromProjectLocationBackupPlan("[PROJECT]", "[LOCATION]", "[BACKUP_PLAN]");
            // Make the request
            PagedEnumerable<ListBackupsResponse, Backup> response = backupForGKEClient.ListBackups(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Backup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListBackupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Backup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Backup> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Backup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBackupsAsync</summary>
        public async Task ListBackupsResourceNamesAsync()
        {
            // Snippet: ListBackupsAsync(BackupPlanName, string, int?, CallSettings)
            // Create client
            BackupForGKEClient backupForGKEClient = await BackupForGKEClient.CreateAsync();
            // Initialize request argument(s)
            BackupPlanName parent = BackupPlanName.FromProjectLocationBackupPlan("[PROJECT]", "[LOCATION]", "[BACKUP_PLAN]");
            // Make the request
            PagedAsyncEnumerable<ListBackupsResponse, Backup> response = backupForGKEClient.ListBackupsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Backup item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListBackupsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Backup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Backup> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Backup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetBackup</summary>
        public void GetBackupRequestObject()
        {
            // Snippet: GetBackup(GetBackupRequest, CallSettings)
            // Create client
            BackupForGKEClient backupForGKEClient = BackupForGKEClient.Create();
            // Initialize request argument(s)
            GetBackupRequest request = new GetBackupRequest
            {
                BackupName = BackupName.FromProjectLocationBackupPlanBackup("[PROJECT]", "[LOCATION]", "[BACKUP_PLAN]", "[BACKUP]"),
            };
            // Make the request
            Backup response = backupForGKEClient.GetBackup(request);
            // End snippet
        }

        /// <summary>Snippet for GetBackupAsync</summary>
        public async Task GetBackupRequestObjectAsync()
        {
            // Snippet: GetBackupAsync(GetBackupRequest, CallSettings)
            // Additional: GetBackupAsync(GetBackupRequest, CancellationToken)
            // Create client
            BackupForGKEClient backupForGKEClient = await BackupForGKEClient.CreateAsync();
            // Initialize request argument(s)
            GetBackupRequest request = new GetBackupRequest
            {
                BackupName = BackupName.FromProjectLocationBackupPlanBackup("[PROJECT]", "[LOCATION]", "[BACKUP_PLAN]", "[BACKUP]"),
            };
            // Make the request
            Backup response = await backupForGKEClient.GetBackupAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetBackup</summary>
        public void GetBackup()
        {
            // Snippet: GetBackup(string, CallSettings)
            // Create client
            BackupForGKEClient backupForGKEClient = BackupForGKEClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/backupPlans/[BACKUP_PLAN]/backups/[BACKUP]";
            // Make the request
            Backup response = backupForGKEClient.GetBackup(name);
            // End snippet
        }

        /// <summary>Snippet for GetBackupAsync</summary>
        public async Task GetBackupAsync()
        {
            // Snippet: GetBackupAsync(string, CallSettings)
            // Additional: GetBackupAsync(string, CancellationToken)
            // Create client
            BackupForGKEClient backupForGKEClient = await BackupForGKEClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/backupPlans/[BACKUP_PLAN]/backups/[BACKUP]";
            // Make the request
            Backup response = await backupForGKEClient.GetBackupAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetBackup</summary>
        public void GetBackupResourceNames()
        {
            // Snippet: GetBackup(BackupName, CallSettings)
            // Create client
            BackupForGKEClient backupForGKEClient = BackupForGKEClient.Create();
            // Initialize request argument(s)
            BackupName name = BackupName.FromProjectLocationBackupPlanBackup("[PROJECT]", "[LOCATION]", "[BACKUP_PLAN]", "[BACKUP]");
            // Make the request
            Backup response = backupForGKEClient.GetBackup(name);
            // End snippet
        }

        /// <summary>Snippet for GetBackupAsync</summary>
        public async Task GetBackupResourceNamesAsync()
        {
            // Snippet: GetBackupAsync(BackupName, CallSettings)
            // Additional: GetBackupAsync(BackupName, CancellationToken)
            // Create client
            BackupForGKEClient backupForGKEClient = await BackupForGKEClient.CreateAsync();
            // Initialize request argument(s)
            BackupName name = BackupName.FromProjectLocationBackupPlanBackup("[PROJECT]", "[LOCATION]", "[BACKUP_PLAN]", "[BACKUP]");
            // Make the request
            Backup response = await backupForGKEClient.GetBackupAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateBackup</summary>
        public void UpdateBackupRequestObject()
        {
            // Snippet: UpdateBackup(UpdateBackupRequest, CallSettings)
            // Create client
            BackupForGKEClient backupForGKEClient = BackupForGKEClient.Create();
            // Initialize request argument(s)
            UpdateBackupRequest request = new UpdateBackupRequest
            {
                Backup = new Backup(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<Backup, OperationMetadata> response = backupForGKEClient.UpdateBackup(request);

            // Poll until the returned long-running operation is complete
            Operation<Backup, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Backup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Backup, OperationMetadata> retrievedResponse = backupForGKEClient.PollOnceUpdateBackup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Backup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateBackupAsync</summary>
        public async Task UpdateBackupRequestObjectAsync()
        {
            // Snippet: UpdateBackupAsync(UpdateBackupRequest, CallSettings)
            // Additional: UpdateBackupAsync(UpdateBackupRequest, CancellationToken)
            // Create client
            BackupForGKEClient backupForGKEClient = await BackupForGKEClient.CreateAsync();
            // Initialize request argument(s)
            UpdateBackupRequest request = new UpdateBackupRequest
            {
                Backup = new Backup(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<Backup, OperationMetadata> response = await backupForGKEClient.UpdateBackupAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Backup, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Backup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Backup, OperationMetadata> retrievedResponse = await backupForGKEClient.PollOnceUpdateBackupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Backup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateBackup</summary>
        public void UpdateBackup()
        {
            // Snippet: UpdateBackup(Backup, FieldMask, CallSettings)
            // Create client
            BackupForGKEClient backupForGKEClient = BackupForGKEClient.Create();
            // Initialize request argument(s)
            Backup backup = new Backup();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Backup, OperationMetadata> response = backupForGKEClient.UpdateBackup(backup, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Backup, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Backup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Backup, OperationMetadata> retrievedResponse = backupForGKEClient.PollOnceUpdateBackup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Backup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateBackupAsync</summary>
        public async Task UpdateBackupAsync()
        {
            // Snippet: UpdateBackupAsync(Backup, FieldMask, CallSettings)
            // Additional: UpdateBackupAsync(Backup, FieldMask, CancellationToken)
            // Create client
            BackupForGKEClient backupForGKEClient = await BackupForGKEClient.CreateAsync();
            // Initialize request argument(s)
            Backup backup = new Backup();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Backup, OperationMetadata> response = await backupForGKEClient.UpdateBackupAsync(backup, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Backup, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Backup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Backup, OperationMetadata> retrievedResponse = await backupForGKEClient.PollOnceUpdateBackupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Backup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteBackup</summary>
        public void DeleteBackupRequestObject()
        {
            // Snippet: DeleteBackup(DeleteBackupRequest, CallSettings)
            // Create client
            BackupForGKEClient backupForGKEClient = BackupForGKEClient.Create();
            // Initialize request argument(s)
            DeleteBackupRequest request = new DeleteBackupRequest
            {
                BackupName = BackupName.FromProjectLocationBackupPlanBackup("[PROJECT]", "[LOCATION]", "[BACKUP_PLAN]", "[BACKUP]"),
                Etag = "",
                Force = false,
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = backupForGKEClient.DeleteBackup(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = backupForGKEClient.PollOnceDeleteBackup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteBackupAsync</summary>
        public async Task DeleteBackupRequestObjectAsync()
        {
            // Snippet: DeleteBackupAsync(DeleteBackupRequest, CallSettings)
            // Additional: DeleteBackupAsync(DeleteBackupRequest, CancellationToken)
            // Create client
            BackupForGKEClient backupForGKEClient = await BackupForGKEClient.CreateAsync();
            // Initialize request argument(s)
            DeleteBackupRequest request = new DeleteBackupRequest
            {
                BackupName = BackupName.FromProjectLocationBackupPlanBackup("[PROJECT]", "[LOCATION]", "[BACKUP_PLAN]", "[BACKUP]"),
                Etag = "",
                Force = false,
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await backupForGKEClient.DeleteBackupAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await backupForGKEClient.PollOnceDeleteBackupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteBackup</summary>
        public void DeleteBackup()
        {
            // Snippet: DeleteBackup(string, CallSettings)
            // Create client
            BackupForGKEClient backupForGKEClient = BackupForGKEClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/backupPlans/[BACKUP_PLAN]/backups/[BACKUP]";
            // Make the request
            Operation<Empty, OperationMetadata> response = backupForGKEClient.DeleteBackup(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = backupForGKEClient.PollOnceDeleteBackup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteBackupAsync</summary>
        public async Task DeleteBackupAsync()
        {
            // Snippet: DeleteBackupAsync(string, CallSettings)
            // Additional: DeleteBackupAsync(string, CancellationToken)
            // Create client
            BackupForGKEClient backupForGKEClient = await BackupForGKEClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/backupPlans/[BACKUP_PLAN]/backups/[BACKUP]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await backupForGKEClient.DeleteBackupAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await backupForGKEClient.PollOnceDeleteBackupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteBackup</summary>
        public void DeleteBackupResourceNames()
        {
            // Snippet: DeleteBackup(BackupName, CallSettings)
            // Create client
            BackupForGKEClient backupForGKEClient = BackupForGKEClient.Create();
            // Initialize request argument(s)
            BackupName name = BackupName.FromProjectLocationBackupPlanBackup("[PROJECT]", "[LOCATION]", "[BACKUP_PLAN]", "[BACKUP]");
            // Make the request
            Operation<Empty, OperationMetadata> response = backupForGKEClient.DeleteBackup(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = backupForGKEClient.PollOnceDeleteBackup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteBackupAsync</summary>
        public async Task DeleteBackupResourceNamesAsync()
        {
            // Snippet: DeleteBackupAsync(BackupName, CallSettings)
            // Additional: DeleteBackupAsync(BackupName, CancellationToken)
            // Create client
            BackupForGKEClient backupForGKEClient = await BackupForGKEClient.CreateAsync();
            // Initialize request argument(s)
            BackupName name = BackupName.FromProjectLocationBackupPlanBackup("[PROJECT]", "[LOCATION]", "[BACKUP_PLAN]", "[BACKUP]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await backupForGKEClient.DeleteBackupAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await backupForGKEClient.PollOnceDeleteBackupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListVolumeBackups</summary>
        public void ListVolumeBackupsRequestObject()
        {
            // Snippet: ListVolumeBackups(ListVolumeBackupsRequest, CallSettings)
            // Create client
            BackupForGKEClient backupForGKEClient = BackupForGKEClient.Create();
            // Initialize request argument(s)
            ListVolumeBackupsRequest request = new ListVolumeBackupsRequest
            {
                ParentAsBackupName = BackupName.FromProjectLocationBackupPlanBackup("[PROJECT]", "[LOCATION]", "[BACKUP_PLAN]", "[BACKUP]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListVolumeBackupsResponse, VolumeBackup> response = backupForGKEClient.ListVolumeBackups(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (VolumeBackup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListVolumeBackupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (VolumeBackup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<VolumeBackup> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (VolumeBackup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListVolumeBackupsAsync</summary>
        public async Task ListVolumeBackupsRequestObjectAsync()
        {
            // Snippet: ListVolumeBackupsAsync(ListVolumeBackupsRequest, CallSettings)
            // Create client
            BackupForGKEClient backupForGKEClient = await BackupForGKEClient.CreateAsync();
            // Initialize request argument(s)
            ListVolumeBackupsRequest request = new ListVolumeBackupsRequest
            {
                ParentAsBackupName = BackupName.FromProjectLocationBackupPlanBackup("[PROJECT]", "[LOCATION]", "[BACKUP_PLAN]", "[BACKUP]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListVolumeBackupsResponse, VolumeBackup> response = backupForGKEClient.ListVolumeBackupsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((VolumeBackup item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListVolumeBackupsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (VolumeBackup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<VolumeBackup> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (VolumeBackup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListVolumeBackups</summary>
        public void ListVolumeBackups()
        {
            // Snippet: ListVolumeBackups(string, string, int?, CallSettings)
            // Create client
            BackupForGKEClient backupForGKEClient = BackupForGKEClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/backupPlans/[BACKUP_PLAN]/backups/[BACKUP]";
            // Make the request
            PagedEnumerable<ListVolumeBackupsResponse, VolumeBackup> response = backupForGKEClient.ListVolumeBackups(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (VolumeBackup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListVolumeBackupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (VolumeBackup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<VolumeBackup> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (VolumeBackup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListVolumeBackupsAsync</summary>
        public async Task ListVolumeBackupsAsync()
        {
            // Snippet: ListVolumeBackupsAsync(string, string, int?, CallSettings)
            // Create client
            BackupForGKEClient backupForGKEClient = await BackupForGKEClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/backupPlans/[BACKUP_PLAN]/backups/[BACKUP]";
            // Make the request
            PagedAsyncEnumerable<ListVolumeBackupsResponse, VolumeBackup> response = backupForGKEClient.ListVolumeBackupsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((VolumeBackup item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListVolumeBackupsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (VolumeBackup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<VolumeBackup> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (VolumeBackup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListVolumeBackups</summary>
        public void ListVolumeBackupsResourceNames()
        {
            // Snippet: ListVolumeBackups(BackupName, string, int?, CallSettings)
            // Create client
            BackupForGKEClient backupForGKEClient = BackupForGKEClient.Create();
            // Initialize request argument(s)
            BackupName parent = BackupName.FromProjectLocationBackupPlanBackup("[PROJECT]", "[LOCATION]", "[BACKUP_PLAN]", "[BACKUP]");
            // Make the request
            PagedEnumerable<ListVolumeBackupsResponse, VolumeBackup> response = backupForGKEClient.ListVolumeBackups(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (VolumeBackup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListVolumeBackupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (VolumeBackup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<VolumeBackup> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (VolumeBackup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListVolumeBackupsAsync</summary>
        public async Task ListVolumeBackupsResourceNamesAsync()
        {
            // Snippet: ListVolumeBackupsAsync(BackupName, string, int?, CallSettings)
            // Create client
            BackupForGKEClient backupForGKEClient = await BackupForGKEClient.CreateAsync();
            // Initialize request argument(s)
            BackupName parent = BackupName.FromProjectLocationBackupPlanBackup("[PROJECT]", "[LOCATION]", "[BACKUP_PLAN]", "[BACKUP]");
            // Make the request
            PagedAsyncEnumerable<ListVolumeBackupsResponse, VolumeBackup> response = backupForGKEClient.ListVolumeBackupsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((VolumeBackup item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListVolumeBackupsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (VolumeBackup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<VolumeBackup> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (VolumeBackup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetVolumeBackup</summary>
        public void GetVolumeBackupRequestObject()
        {
            // Snippet: GetVolumeBackup(GetVolumeBackupRequest, CallSettings)
            // Create client
            BackupForGKEClient backupForGKEClient = BackupForGKEClient.Create();
            // Initialize request argument(s)
            GetVolumeBackupRequest request = new GetVolumeBackupRequest
            {
                VolumeBackupName = VolumeBackupName.FromProjectLocationBackupPlanBackupVolumeBackup("[PROJECT]", "[LOCATION]", "[BACKUP_PLAN]", "[BACKUP]", "[VOLUME_BACKUP]"),
            };
            // Make the request
            VolumeBackup response = backupForGKEClient.GetVolumeBackup(request);
            // End snippet
        }

        /// <summary>Snippet for GetVolumeBackupAsync</summary>
        public async Task GetVolumeBackupRequestObjectAsync()
        {
            // Snippet: GetVolumeBackupAsync(GetVolumeBackupRequest, CallSettings)
            // Additional: GetVolumeBackupAsync(GetVolumeBackupRequest, CancellationToken)
            // Create client
            BackupForGKEClient backupForGKEClient = await BackupForGKEClient.CreateAsync();
            // Initialize request argument(s)
            GetVolumeBackupRequest request = new GetVolumeBackupRequest
            {
                VolumeBackupName = VolumeBackupName.FromProjectLocationBackupPlanBackupVolumeBackup("[PROJECT]", "[LOCATION]", "[BACKUP_PLAN]", "[BACKUP]", "[VOLUME_BACKUP]"),
            };
            // Make the request
            VolumeBackup response = await backupForGKEClient.GetVolumeBackupAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetVolumeBackup</summary>
        public void GetVolumeBackup()
        {
            // Snippet: GetVolumeBackup(string, CallSettings)
            // Create client
            BackupForGKEClient backupForGKEClient = BackupForGKEClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/backupPlans/[BACKUP_PLAN]/backups/[BACKUP]/volumeBackups/[VOLUME_BACKUP]";
            // Make the request
            VolumeBackup response = backupForGKEClient.GetVolumeBackup(name);
            // End snippet
        }

        /// <summary>Snippet for GetVolumeBackupAsync</summary>
        public async Task GetVolumeBackupAsync()
        {
            // Snippet: GetVolumeBackupAsync(string, CallSettings)
            // Additional: GetVolumeBackupAsync(string, CancellationToken)
            // Create client
            BackupForGKEClient backupForGKEClient = await BackupForGKEClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/backupPlans/[BACKUP_PLAN]/backups/[BACKUP]/volumeBackups/[VOLUME_BACKUP]";
            // Make the request
            VolumeBackup response = await backupForGKEClient.GetVolumeBackupAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetVolumeBackup</summary>
        public void GetVolumeBackupResourceNames()
        {
            // Snippet: GetVolumeBackup(VolumeBackupName, CallSettings)
            // Create client
            BackupForGKEClient backupForGKEClient = BackupForGKEClient.Create();
            // Initialize request argument(s)
            VolumeBackupName name = VolumeBackupName.FromProjectLocationBackupPlanBackupVolumeBackup("[PROJECT]", "[LOCATION]", "[BACKUP_PLAN]", "[BACKUP]", "[VOLUME_BACKUP]");
            // Make the request
            VolumeBackup response = backupForGKEClient.GetVolumeBackup(name);
            // End snippet
        }

        /// <summary>Snippet for GetVolumeBackupAsync</summary>
        public async Task GetVolumeBackupResourceNamesAsync()
        {
            // Snippet: GetVolumeBackupAsync(VolumeBackupName, CallSettings)
            // Additional: GetVolumeBackupAsync(VolumeBackupName, CancellationToken)
            // Create client
            BackupForGKEClient backupForGKEClient = await BackupForGKEClient.CreateAsync();
            // Initialize request argument(s)
            VolumeBackupName name = VolumeBackupName.FromProjectLocationBackupPlanBackupVolumeBackup("[PROJECT]", "[LOCATION]", "[BACKUP_PLAN]", "[BACKUP]", "[VOLUME_BACKUP]");
            // Make the request
            VolumeBackup response = await backupForGKEClient.GetVolumeBackupAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateRestorePlan</summary>
        public void CreateRestorePlanRequestObject()
        {
            // Snippet: CreateRestorePlan(CreateRestorePlanRequest, CallSettings)
            // Create client
            BackupForGKEClient backupForGKEClient = BackupForGKEClient.Create();
            // Initialize request argument(s)
            CreateRestorePlanRequest request = new CreateRestorePlanRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                RestorePlan = new RestorePlan(),
                RestorePlanId = "",
            };
            // Make the request
            Operation<RestorePlan, OperationMetadata> response = backupForGKEClient.CreateRestorePlan(request);

            // Poll until the returned long-running operation is complete
            Operation<RestorePlan, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            RestorePlan result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RestorePlan, OperationMetadata> retrievedResponse = backupForGKEClient.PollOnceCreateRestorePlan(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RestorePlan retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateRestorePlanAsync</summary>
        public async Task CreateRestorePlanRequestObjectAsync()
        {
            // Snippet: CreateRestorePlanAsync(CreateRestorePlanRequest, CallSettings)
            // Additional: CreateRestorePlanAsync(CreateRestorePlanRequest, CancellationToken)
            // Create client
            BackupForGKEClient backupForGKEClient = await BackupForGKEClient.CreateAsync();
            // Initialize request argument(s)
            CreateRestorePlanRequest request = new CreateRestorePlanRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                RestorePlan = new RestorePlan(),
                RestorePlanId = "",
            };
            // Make the request
            Operation<RestorePlan, OperationMetadata> response = await backupForGKEClient.CreateRestorePlanAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<RestorePlan, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            RestorePlan result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RestorePlan, OperationMetadata> retrievedResponse = await backupForGKEClient.PollOnceCreateRestorePlanAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RestorePlan retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateRestorePlan</summary>
        public void CreateRestorePlan()
        {
            // Snippet: CreateRestorePlan(string, RestorePlan, string, CallSettings)
            // Create client
            BackupForGKEClient backupForGKEClient = BackupForGKEClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            RestorePlan restorePlan = new RestorePlan();
            string restorePlanId = "";
            // Make the request
            Operation<RestorePlan, OperationMetadata> response = backupForGKEClient.CreateRestorePlan(parent, restorePlan, restorePlanId);

            // Poll until the returned long-running operation is complete
            Operation<RestorePlan, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            RestorePlan result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RestorePlan, OperationMetadata> retrievedResponse = backupForGKEClient.PollOnceCreateRestorePlan(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RestorePlan retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateRestorePlanAsync</summary>
        public async Task CreateRestorePlanAsync()
        {
            // Snippet: CreateRestorePlanAsync(string, RestorePlan, string, CallSettings)
            // Additional: CreateRestorePlanAsync(string, RestorePlan, string, CancellationToken)
            // Create client
            BackupForGKEClient backupForGKEClient = await BackupForGKEClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            RestorePlan restorePlan = new RestorePlan();
            string restorePlanId = "";
            // Make the request
            Operation<RestorePlan, OperationMetadata> response = await backupForGKEClient.CreateRestorePlanAsync(parent, restorePlan, restorePlanId);

            // Poll until the returned long-running operation is complete
            Operation<RestorePlan, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            RestorePlan result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RestorePlan, OperationMetadata> retrievedResponse = await backupForGKEClient.PollOnceCreateRestorePlanAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RestorePlan retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateRestorePlan</summary>
        public void CreateRestorePlanResourceNames()
        {
            // Snippet: CreateRestorePlan(LocationName, RestorePlan, string, CallSettings)
            // Create client
            BackupForGKEClient backupForGKEClient = BackupForGKEClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            RestorePlan restorePlan = new RestorePlan();
            string restorePlanId = "";
            // Make the request
            Operation<RestorePlan, OperationMetadata> response = backupForGKEClient.CreateRestorePlan(parent, restorePlan, restorePlanId);

            // Poll until the returned long-running operation is complete
            Operation<RestorePlan, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            RestorePlan result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RestorePlan, OperationMetadata> retrievedResponse = backupForGKEClient.PollOnceCreateRestorePlan(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RestorePlan retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateRestorePlanAsync</summary>
        public async Task CreateRestorePlanResourceNamesAsync()
        {
            // Snippet: CreateRestorePlanAsync(LocationName, RestorePlan, string, CallSettings)
            // Additional: CreateRestorePlanAsync(LocationName, RestorePlan, string, CancellationToken)
            // Create client
            BackupForGKEClient backupForGKEClient = await BackupForGKEClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            RestorePlan restorePlan = new RestorePlan();
            string restorePlanId = "";
            // Make the request
            Operation<RestorePlan, OperationMetadata> response = await backupForGKEClient.CreateRestorePlanAsync(parent, restorePlan, restorePlanId);

            // Poll until the returned long-running operation is complete
            Operation<RestorePlan, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            RestorePlan result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RestorePlan, OperationMetadata> retrievedResponse = await backupForGKEClient.PollOnceCreateRestorePlanAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RestorePlan retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListRestorePlans</summary>
        public void ListRestorePlansRequestObject()
        {
            // Snippet: ListRestorePlans(ListRestorePlansRequest, CallSettings)
            // Create client
            BackupForGKEClient backupForGKEClient = BackupForGKEClient.Create();
            // Initialize request argument(s)
            ListRestorePlansRequest request = new ListRestorePlansRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListRestorePlansResponse, RestorePlan> response = backupForGKEClient.ListRestorePlans(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (RestorePlan item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRestorePlansResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RestorePlan item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RestorePlan> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RestorePlan item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRestorePlansAsync</summary>
        public async Task ListRestorePlansRequestObjectAsync()
        {
            // Snippet: ListRestorePlansAsync(ListRestorePlansRequest, CallSettings)
            // Create client
            BackupForGKEClient backupForGKEClient = await BackupForGKEClient.CreateAsync();
            // Initialize request argument(s)
            ListRestorePlansRequest request = new ListRestorePlansRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListRestorePlansResponse, RestorePlan> response = backupForGKEClient.ListRestorePlansAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((RestorePlan item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListRestorePlansResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RestorePlan item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RestorePlan> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RestorePlan item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRestorePlans</summary>
        public void ListRestorePlans()
        {
            // Snippet: ListRestorePlans(string, string, int?, CallSettings)
            // Create client
            BackupForGKEClient backupForGKEClient = BackupForGKEClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListRestorePlansResponse, RestorePlan> response = backupForGKEClient.ListRestorePlans(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (RestorePlan item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRestorePlansResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RestorePlan item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RestorePlan> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RestorePlan item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRestorePlansAsync</summary>
        public async Task ListRestorePlansAsync()
        {
            // Snippet: ListRestorePlansAsync(string, string, int?, CallSettings)
            // Create client
            BackupForGKEClient backupForGKEClient = await BackupForGKEClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListRestorePlansResponse, RestorePlan> response = backupForGKEClient.ListRestorePlansAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((RestorePlan item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListRestorePlansResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RestorePlan item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RestorePlan> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RestorePlan item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRestorePlans</summary>
        public void ListRestorePlansResourceNames()
        {
            // Snippet: ListRestorePlans(LocationName, string, int?, CallSettings)
            // Create client
            BackupForGKEClient backupForGKEClient = BackupForGKEClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListRestorePlansResponse, RestorePlan> response = backupForGKEClient.ListRestorePlans(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (RestorePlan item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRestorePlansResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RestorePlan item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RestorePlan> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RestorePlan item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRestorePlansAsync</summary>
        public async Task ListRestorePlansResourceNamesAsync()
        {
            // Snippet: ListRestorePlansAsync(LocationName, string, int?, CallSettings)
            // Create client
            BackupForGKEClient backupForGKEClient = await BackupForGKEClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListRestorePlansResponse, RestorePlan> response = backupForGKEClient.ListRestorePlansAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((RestorePlan item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListRestorePlansResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RestorePlan item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RestorePlan> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RestorePlan item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetRestorePlan</summary>
        public void GetRestorePlanRequestObject()
        {
            // Snippet: GetRestorePlan(GetRestorePlanRequest, CallSettings)
            // Create client
            BackupForGKEClient backupForGKEClient = BackupForGKEClient.Create();
            // Initialize request argument(s)
            GetRestorePlanRequest request = new GetRestorePlanRequest
            {
                RestorePlanName = RestorePlanName.FromProjectLocationRestorePlan("[PROJECT]", "[LOCATION]", "[RESTORE_PLAN]"),
            };
            // Make the request
            RestorePlan response = backupForGKEClient.GetRestorePlan(request);
            // End snippet
        }

        /// <summary>Snippet for GetRestorePlanAsync</summary>
        public async Task GetRestorePlanRequestObjectAsync()
        {
            // Snippet: GetRestorePlanAsync(GetRestorePlanRequest, CallSettings)
            // Additional: GetRestorePlanAsync(GetRestorePlanRequest, CancellationToken)
            // Create client
            BackupForGKEClient backupForGKEClient = await BackupForGKEClient.CreateAsync();
            // Initialize request argument(s)
            GetRestorePlanRequest request = new GetRestorePlanRequest
            {
                RestorePlanName = RestorePlanName.FromProjectLocationRestorePlan("[PROJECT]", "[LOCATION]", "[RESTORE_PLAN]"),
            };
            // Make the request
            RestorePlan response = await backupForGKEClient.GetRestorePlanAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetRestorePlan</summary>
        public void GetRestorePlan()
        {
            // Snippet: GetRestorePlan(string, CallSettings)
            // Create client
            BackupForGKEClient backupForGKEClient = BackupForGKEClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/restorePlans/[RESTORE_PLAN]";
            // Make the request
            RestorePlan response = backupForGKEClient.GetRestorePlan(name);
            // End snippet
        }

        /// <summary>Snippet for GetRestorePlanAsync</summary>
        public async Task GetRestorePlanAsync()
        {
            // Snippet: GetRestorePlanAsync(string, CallSettings)
            // Additional: GetRestorePlanAsync(string, CancellationToken)
            // Create client
            BackupForGKEClient backupForGKEClient = await BackupForGKEClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/restorePlans/[RESTORE_PLAN]";
            // Make the request
            RestorePlan response = await backupForGKEClient.GetRestorePlanAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetRestorePlan</summary>
        public void GetRestorePlanResourceNames()
        {
            // Snippet: GetRestorePlan(RestorePlanName, CallSettings)
            // Create client
            BackupForGKEClient backupForGKEClient = BackupForGKEClient.Create();
            // Initialize request argument(s)
            RestorePlanName name = RestorePlanName.FromProjectLocationRestorePlan("[PROJECT]", "[LOCATION]", "[RESTORE_PLAN]");
            // Make the request
            RestorePlan response = backupForGKEClient.GetRestorePlan(name);
            // End snippet
        }

        /// <summary>Snippet for GetRestorePlanAsync</summary>
        public async Task GetRestorePlanResourceNamesAsync()
        {
            // Snippet: GetRestorePlanAsync(RestorePlanName, CallSettings)
            // Additional: GetRestorePlanAsync(RestorePlanName, CancellationToken)
            // Create client
            BackupForGKEClient backupForGKEClient = await BackupForGKEClient.CreateAsync();
            // Initialize request argument(s)
            RestorePlanName name = RestorePlanName.FromProjectLocationRestorePlan("[PROJECT]", "[LOCATION]", "[RESTORE_PLAN]");
            // Make the request
            RestorePlan response = await backupForGKEClient.GetRestorePlanAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateRestorePlan</summary>
        public void UpdateRestorePlanRequestObject()
        {
            // Snippet: UpdateRestorePlan(UpdateRestorePlanRequest, CallSettings)
            // Create client
            BackupForGKEClient backupForGKEClient = BackupForGKEClient.Create();
            // Initialize request argument(s)
            UpdateRestorePlanRequest request = new UpdateRestorePlanRequest
            {
                RestorePlan = new RestorePlan(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<RestorePlan, OperationMetadata> response = backupForGKEClient.UpdateRestorePlan(request);

            // Poll until the returned long-running operation is complete
            Operation<RestorePlan, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            RestorePlan result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RestorePlan, OperationMetadata> retrievedResponse = backupForGKEClient.PollOnceUpdateRestorePlan(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RestorePlan retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateRestorePlanAsync</summary>
        public async Task UpdateRestorePlanRequestObjectAsync()
        {
            // Snippet: UpdateRestorePlanAsync(UpdateRestorePlanRequest, CallSettings)
            // Additional: UpdateRestorePlanAsync(UpdateRestorePlanRequest, CancellationToken)
            // Create client
            BackupForGKEClient backupForGKEClient = await BackupForGKEClient.CreateAsync();
            // Initialize request argument(s)
            UpdateRestorePlanRequest request = new UpdateRestorePlanRequest
            {
                RestorePlan = new RestorePlan(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<RestorePlan, OperationMetadata> response = await backupForGKEClient.UpdateRestorePlanAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<RestorePlan, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            RestorePlan result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RestorePlan, OperationMetadata> retrievedResponse = await backupForGKEClient.PollOnceUpdateRestorePlanAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RestorePlan retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateRestorePlan</summary>
        public void UpdateRestorePlan()
        {
            // Snippet: UpdateRestorePlan(RestorePlan, FieldMask, CallSettings)
            // Create client
            BackupForGKEClient backupForGKEClient = BackupForGKEClient.Create();
            // Initialize request argument(s)
            RestorePlan restorePlan = new RestorePlan();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<RestorePlan, OperationMetadata> response = backupForGKEClient.UpdateRestorePlan(restorePlan, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<RestorePlan, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            RestorePlan result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RestorePlan, OperationMetadata> retrievedResponse = backupForGKEClient.PollOnceUpdateRestorePlan(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RestorePlan retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateRestorePlanAsync</summary>
        public async Task UpdateRestorePlanAsync()
        {
            // Snippet: UpdateRestorePlanAsync(RestorePlan, FieldMask, CallSettings)
            // Additional: UpdateRestorePlanAsync(RestorePlan, FieldMask, CancellationToken)
            // Create client
            BackupForGKEClient backupForGKEClient = await BackupForGKEClient.CreateAsync();
            // Initialize request argument(s)
            RestorePlan restorePlan = new RestorePlan();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<RestorePlan, OperationMetadata> response = await backupForGKEClient.UpdateRestorePlanAsync(restorePlan, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<RestorePlan, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            RestorePlan result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RestorePlan, OperationMetadata> retrievedResponse = await backupForGKEClient.PollOnceUpdateRestorePlanAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RestorePlan retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteRestorePlan</summary>
        public void DeleteRestorePlanRequestObject()
        {
            // Snippet: DeleteRestorePlan(DeleteRestorePlanRequest, CallSettings)
            // Create client
            BackupForGKEClient backupForGKEClient = BackupForGKEClient.Create();
            // Initialize request argument(s)
            DeleteRestorePlanRequest request = new DeleteRestorePlanRequest
            {
                RestorePlanName = RestorePlanName.FromProjectLocationRestorePlan("[PROJECT]", "[LOCATION]", "[RESTORE_PLAN]"),
                Etag = "",
                Force = false,
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = backupForGKEClient.DeleteRestorePlan(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = backupForGKEClient.PollOnceDeleteRestorePlan(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteRestorePlanAsync</summary>
        public async Task DeleteRestorePlanRequestObjectAsync()
        {
            // Snippet: DeleteRestorePlanAsync(DeleteRestorePlanRequest, CallSettings)
            // Additional: DeleteRestorePlanAsync(DeleteRestorePlanRequest, CancellationToken)
            // Create client
            BackupForGKEClient backupForGKEClient = await BackupForGKEClient.CreateAsync();
            // Initialize request argument(s)
            DeleteRestorePlanRequest request = new DeleteRestorePlanRequest
            {
                RestorePlanName = RestorePlanName.FromProjectLocationRestorePlan("[PROJECT]", "[LOCATION]", "[RESTORE_PLAN]"),
                Etag = "",
                Force = false,
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await backupForGKEClient.DeleteRestorePlanAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await backupForGKEClient.PollOnceDeleteRestorePlanAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteRestorePlan</summary>
        public void DeleteRestorePlan()
        {
            // Snippet: DeleteRestorePlan(string, CallSettings)
            // Create client
            BackupForGKEClient backupForGKEClient = BackupForGKEClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/restorePlans/[RESTORE_PLAN]";
            // Make the request
            Operation<Empty, OperationMetadata> response = backupForGKEClient.DeleteRestorePlan(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = backupForGKEClient.PollOnceDeleteRestorePlan(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteRestorePlanAsync</summary>
        public async Task DeleteRestorePlanAsync()
        {
            // Snippet: DeleteRestorePlanAsync(string, CallSettings)
            // Additional: DeleteRestorePlanAsync(string, CancellationToken)
            // Create client
            BackupForGKEClient backupForGKEClient = await BackupForGKEClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/restorePlans/[RESTORE_PLAN]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await backupForGKEClient.DeleteRestorePlanAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await backupForGKEClient.PollOnceDeleteRestorePlanAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteRestorePlan</summary>
        public void DeleteRestorePlanResourceNames()
        {
            // Snippet: DeleteRestorePlan(RestorePlanName, CallSettings)
            // Create client
            BackupForGKEClient backupForGKEClient = BackupForGKEClient.Create();
            // Initialize request argument(s)
            RestorePlanName name = RestorePlanName.FromProjectLocationRestorePlan("[PROJECT]", "[LOCATION]", "[RESTORE_PLAN]");
            // Make the request
            Operation<Empty, OperationMetadata> response = backupForGKEClient.DeleteRestorePlan(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = backupForGKEClient.PollOnceDeleteRestorePlan(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteRestorePlanAsync</summary>
        public async Task DeleteRestorePlanResourceNamesAsync()
        {
            // Snippet: DeleteRestorePlanAsync(RestorePlanName, CallSettings)
            // Additional: DeleteRestorePlanAsync(RestorePlanName, CancellationToken)
            // Create client
            BackupForGKEClient backupForGKEClient = await BackupForGKEClient.CreateAsync();
            // Initialize request argument(s)
            RestorePlanName name = RestorePlanName.FromProjectLocationRestorePlan("[PROJECT]", "[LOCATION]", "[RESTORE_PLAN]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await backupForGKEClient.DeleteRestorePlanAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await backupForGKEClient.PollOnceDeleteRestorePlanAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateRestore</summary>
        public void CreateRestoreRequestObject()
        {
            // Snippet: CreateRestore(CreateRestoreRequest, CallSettings)
            // Create client
            BackupForGKEClient backupForGKEClient = BackupForGKEClient.Create();
            // Initialize request argument(s)
            CreateRestoreRequest request = new CreateRestoreRequest
            {
                ParentAsRestorePlanName = RestorePlanName.FromProjectLocationRestorePlan("[PROJECT]", "[LOCATION]", "[RESTORE_PLAN]"),
                Restore = new Restore(),
                RestoreId = "",
            };
            // Make the request
            Operation<Restore, OperationMetadata> response = backupForGKEClient.CreateRestore(request);

            // Poll until the returned long-running operation is complete
            Operation<Restore, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Restore result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Restore, OperationMetadata> retrievedResponse = backupForGKEClient.PollOnceCreateRestore(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Restore retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateRestoreAsync</summary>
        public async Task CreateRestoreRequestObjectAsync()
        {
            // Snippet: CreateRestoreAsync(CreateRestoreRequest, CallSettings)
            // Additional: CreateRestoreAsync(CreateRestoreRequest, CancellationToken)
            // Create client
            BackupForGKEClient backupForGKEClient = await BackupForGKEClient.CreateAsync();
            // Initialize request argument(s)
            CreateRestoreRequest request = new CreateRestoreRequest
            {
                ParentAsRestorePlanName = RestorePlanName.FromProjectLocationRestorePlan("[PROJECT]", "[LOCATION]", "[RESTORE_PLAN]"),
                Restore = new Restore(),
                RestoreId = "",
            };
            // Make the request
            Operation<Restore, OperationMetadata> response = await backupForGKEClient.CreateRestoreAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Restore, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Restore result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Restore, OperationMetadata> retrievedResponse = await backupForGKEClient.PollOnceCreateRestoreAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Restore retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateRestore</summary>
        public void CreateRestore()
        {
            // Snippet: CreateRestore(string, Restore, string, CallSettings)
            // Create client
            BackupForGKEClient backupForGKEClient = BackupForGKEClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/restorePlans/[RESTORE_PLAN]";
            Restore restore = new Restore();
            string restoreId = "";
            // Make the request
            Operation<Restore, OperationMetadata> response = backupForGKEClient.CreateRestore(parent, restore, restoreId);

            // Poll until the returned long-running operation is complete
            Operation<Restore, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Restore result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Restore, OperationMetadata> retrievedResponse = backupForGKEClient.PollOnceCreateRestore(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Restore retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateRestoreAsync</summary>
        public async Task CreateRestoreAsync()
        {
            // Snippet: CreateRestoreAsync(string, Restore, string, CallSettings)
            // Additional: CreateRestoreAsync(string, Restore, string, CancellationToken)
            // Create client
            BackupForGKEClient backupForGKEClient = await BackupForGKEClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/restorePlans/[RESTORE_PLAN]";
            Restore restore = new Restore();
            string restoreId = "";
            // Make the request
            Operation<Restore, OperationMetadata> response = await backupForGKEClient.CreateRestoreAsync(parent, restore, restoreId);

            // Poll until the returned long-running operation is complete
            Operation<Restore, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Restore result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Restore, OperationMetadata> retrievedResponse = await backupForGKEClient.PollOnceCreateRestoreAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Restore retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateRestore</summary>
        public void CreateRestoreResourceNames()
        {
            // Snippet: CreateRestore(RestorePlanName, Restore, string, CallSettings)
            // Create client
            BackupForGKEClient backupForGKEClient = BackupForGKEClient.Create();
            // Initialize request argument(s)
            RestorePlanName parent = RestorePlanName.FromProjectLocationRestorePlan("[PROJECT]", "[LOCATION]", "[RESTORE_PLAN]");
            Restore restore = new Restore();
            string restoreId = "";
            // Make the request
            Operation<Restore, OperationMetadata> response = backupForGKEClient.CreateRestore(parent, restore, restoreId);

            // Poll until the returned long-running operation is complete
            Operation<Restore, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Restore result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Restore, OperationMetadata> retrievedResponse = backupForGKEClient.PollOnceCreateRestore(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Restore retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateRestoreAsync</summary>
        public async Task CreateRestoreResourceNamesAsync()
        {
            // Snippet: CreateRestoreAsync(RestorePlanName, Restore, string, CallSettings)
            // Additional: CreateRestoreAsync(RestorePlanName, Restore, string, CancellationToken)
            // Create client
            BackupForGKEClient backupForGKEClient = await BackupForGKEClient.CreateAsync();
            // Initialize request argument(s)
            RestorePlanName parent = RestorePlanName.FromProjectLocationRestorePlan("[PROJECT]", "[LOCATION]", "[RESTORE_PLAN]");
            Restore restore = new Restore();
            string restoreId = "";
            // Make the request
            Operation<Restore, OperationMetadata> response = await backupForGKEClient.CreateRestoreAsync(parent, restore, restoreId);

            // Poll until the returned long-running operation is complete
            Operation<Restore, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Restore result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Restore, OperationMetadata> retrievedResponse = await backupForGKEClient.PollOnceCreateRestoreAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Restore retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListRestores</summary>
        public void ListRestoresRequestObject()
        {
            // Snippet: ListRestores(ListRestoresRequest, CallSettings)
            // Create client
            BackupForGKEClient backupForGKEClient = BackupForGKEClient.Create();
            // Initialize request argument(s)
            ListRestoresRequest request = new ListRestoresRequest
            {
                ParentAsRestorePlanName = RestorePlanName.FromProjectLocationRestorePlan("[PROJECT]", "[LOCATION]", "[RESTORE_PLAN]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListRestoresResponse, Restore> response = backupForGKEClient.ListRestores(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Restore item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRestoresResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Restore item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Restore> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Restore item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRestoresAsync</summary>
        public async Task ListRestoresRequestObjectAsync()
        {
            // Snippet: ListRestoresAsync(ListRestoresRequest, CallSettings)
            // Create client
            BackupForGKEClient backupForGKEClient = await BackupForGKEClient.CreateAsync();
            // Initialize request argument(s)
            ListRestoresRequest request = new ListRestoresRequest
            {
                ParentAsRestorePlanName = RestorePlanName.FromProjectLocationRestorePlan("[PROJECT]", "[LOCATION]", "[RESTORE_PLAN]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListRestoresResponse, Restore> response = backupForGKEClient.ListRestoresAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Restore item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListRestoresResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Restore item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Restore> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Restore item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRestores</summary>
        public void ListRestores()
        {
            // Snippet: ListRestores(string, string, int?, CallSettings)
            // Create client
            BackupForGKEClient backupForGKEClient = BackupForGKEClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/restorePlans/[RESTORE_PLAN]";
            // Make the request
            PagedEnumerable<ListRestoresResponse, Restore> response = backupForGKEClient.ListRestores(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Restore item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRestoresResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Restore item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Restore> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Restore item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRestoresAsync</summary>
        public async Task ListRestoresAsync()
        {
            // Snippet: ListRestoresAsync(string, string, int?, CallSettings)
            // Create client
            BackupForGKEClient backupForGKEClient = await BackupForGKEClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/restorePlans/[RESTORE_PLAN]";
            // Make the request
            PagedAsyncEnumerable<ListRestoresResponse, Restore> response = backupForGKEClient.ListRestoresAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Restore item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListRestoresResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Restore item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Restore> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Restore item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRestores</summary>
        public void ListRestoresResourceNames()
        {
            // Snippet: ListRestores(RestorePlanName, string, int?, CallSettings)
            // Create client
            BackupForGKEClient backupForGKEClient = BackupForGKEClient.Create();
            // Initialize request argument(s)
            RestorePlanName parent = RestorePlanName.FromProjectLocationRestorePlan("[PROJECT]", "[LOCATION]", "[RESTORE_PLAN]");
            // Make the request
            PagedEnumerable<ListRestoresResponse, Restore> response = backupForGKEClient.ListRestores(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Restore item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRestoresResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Restore item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Restore> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Restore item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRestoresAsync</summary>
        public async Task ListRestoresResourceNamesAsync()
        {
            // Snippet: ListRestoresAsync(RestorePlanName, string, int?, CallSettings)
            // Create client
            BackupForGKEClient backupForGKEClient = await BackupForGKEClient.CreateAsync();
            // Initialize request argument(s)
            RestorePlanName parent = RestorePlanName.FromProjectLocationRestorePlan("[PROJECT]", "[LOCATION]", "[RESTORE_PLAN]");
            // Make the request
            PagedAsyncEnumerable<ListRestoresResponse, Restore> response = backupForGKEClient.ListRestoresAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Restore item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListRestoresResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Restore item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Restore> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Restore item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetRestore</summary>
        public void GetRestoreRequestObject()
        {
            // Snippet: GetRestore(GetRestoreRequest, CallSettings)
            // Create client
            BackupForGKEClient backupForGKEClient = BackupForGKEClient.Create();
            // Initialize request argument(s)
            GetRestoreRequest request = new GetRestoreRequest
            {
                RestoreName = RestoreName.FromProjectLocationRestorePlanRestore("[PROJECT]", "[LOCATION]", "[RESTORE_PLAN]", "[RESTORE]"),
            };
            // Make the request
            Restore response = backupForGKEClient.GetRestore(request);
            // End snippet
        }

        /// <summary>Snippet for GetRestoreAsync</summary>
        public async Task GetRestoreRequestObjectAsync()
        {
            // Snippet: GetRestoreAsync(GetRestoreRequest, CallSettings)
            // Additional: GetRestoreAsync(GetRestoreRequest, CancellationToken)
            // Create client
            BackupForGKEClient backupForGKEClient = await BackupForGKEClient.CreateAsync();
            // Initialize request argument(s)
            GetRestoreRequest request = new GetRestoreRequest
            {
                RestoreName = RestoreName.FromProjectLocationRestorePlanRestore("[PROJECT]", "[LOCATION]", "[RESTORE_PLAN]", "[RESTORE]"),
            };
            // Make the request
            Restore response = await backupForGKEClient.GetRestoreAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetRestore</summary>
        public void GetRestore()
        {
            // Snippet: GetRestore(string, CallSettings)
            // Create client
            BackupForGKEClient backupForGKEClient = BackupForGKEClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/restorePlans/[RESTORE_PLAN]/restores/[RESTORE]";
            // Make the request
            Restore response = backupForGKEClient.GetRestore(name);
            // End snippet
        }

        /// <summary>Snippet for GetRestoreAsync</summary>
        public async Task GetRestoreAsync()
        {
            // Snippet: GetRestoreAsync(string, CallSettings)
            // Additional: GetRestoreAsync(string, CancellationToken)
            // Create client
            BackupForGKEClient backupForGKEClient = await BackupForGKEClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/restorePlans/[RESTORE_PLAN]/restores/[RESTORE]";
            // Make the request
            Restore response = await backupForGKEClient.GetRestoreAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetRestore</summary>
        public void GetRestoreResourceNames()
        {
            // Snippet: GetRestore(RestoreName, CallSettings)
            // Create client
            BackupForGKEClient backupForGKEClient = BackupForGKEClient.Create();
            // Initialize request argument(s)
            RestoreName name = RestoreName.FromProjectLocationRestorePlanRestore("[PROJECT]", "[LOCATION]", "[RESTORE_PLAN]", "[RESTORE]");
            // Make the request
            Restore response = backupForGKEClient.GetRestore(name);
            // End snippet
        }

        /// <summary>Snippet for GetRestoreAsync</summary>
        public async Task GetRestoreResourceNamesAsync()
        {
            // Snippet: GetRestoreAsync(RestoreName, CallSettings)
            // Additional: GetRestoreAsync(RestoreName, CancellationToken)
            // Create client
            BackupForGKEClient backupForGKEClient = await BackupForGKEClient.CreateAsync();
            // Initialize request argument(s)
            RestoreName name = RestoreName.FromProjectLocationRestorePlanRestore("[PROJECT]", "[LOCATION]", "[RESTORE_PLAN]", "[RESTORE]");
            // Make the request
            Restore response = await backupForGKEClient.GetRestoreAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateRestore</summary>
        public void UpdateRestoreRequestObject()
        {
            // Snippet: UpdateRestore(UpdateRestoreRequest, CallSettings)
            // Create client
            BackupForGKEClient backupForGKEClient = BackupForGKEClient.Create();
            // Initialize request argument(s)
            UpdateRestoreRequest request = new UpdateRestoreRequest
            {
                Restore = new Restore(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<Restore, OperationMetadata> response = backupForGKEClient.UpdateRestore(request);

            // Poll until the returned long-running operation is complete
            Operation<Restore, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Restore result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Restore, OperationMetadata> retrievedResponse = backupForGKEClient.PollOnceUpdateRestore(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Restore retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateRestoreAsync</summary>
        public async Task UpdateRestoreRequestObjectAsync()
        {
            // Snippet: UpdateRestoreAsync(UpdateRestoreRequest, CallSettings)
            // Additional: UpdateRestoreAsync(UpdateRestoreRequest, CancellationToken)
            // Create client
            BackupForGKEClient backupForGKEClient = await BackupForGKEClient.CreateAsync();
            // Initialize request argument(s)
            UpdateRestoreRequest request = new UpdateRestoreRequest
            {
                Restore = new Restore(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<Restore, OperationMetadata> response = await backupForGKEClient.UpdateRestoreAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Restore, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Restore result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Restore, OperationMetadata> retrievedResponse = await backupForGKEClient.PollOnceUpdateRestoreAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Restore retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateRestore</summary>
        public void UpdateRestore()
        {
            // Snippet: UpdateRestore(Restore, FieldMask, CallSettings)
            // Create client
            BackupForGKEClient backupForGKEClient = BackupForGKEClient.Create();
            // Initialize request argument(s)
            Restore restore = new Restore();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Restore, OperationMetadata> response = backupForGKEClient.UpdateRestore(restore, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Restore, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Restore result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Restore, OperationMetadata> retrievedResponse = backupForGKEClient.PollOnceUpdateRestore(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Restore retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateRestoreAsync</summary>
        public async Task UpdateRestoreAsync()
        {
            // Snippet: UpdateRestoreAsync(Restore, FieldMask, CallSettings)
            // Additional: UpdateRestoreAsync(Restore, FieldMask, CancellationToken)
            // Create client
            BackupForGKEClient backupForGKEClient = await BackupForGKEClient.CreateAsync();
            // Initialize request argument(s)
            Restore restore = new Restore();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Restore, OperationMetadata> response = await backupForGKEClient.UpdateRestoreAsync(restore, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Restore, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Restore result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Restore, OperationMetadata> retrievedResponse = await backupForGKEClient.PollOnceUpdateRestoreAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Restore retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteRestore</summary>
        public void DeleteRestoreRequestObject()
        {
            // Snippet: DeleteRestore(DeleteRestoreRequest, CallSettings)
            // Create client
            BackupForGKEClient backupForGKEClient = BackupForGKEClient.Create();
            // Initialize request argument(s)
            DeleteRestoreRequest request = new DeleteRestoreRequest
            {
                RestoreName = RestoreName.FromProjectLocationRestorePlanRestore("[PROJECT]", "[LOCATION]", "[RESTORE_PLAN]", "[RESTORE]"),
                Etag = "",
                Force = false,
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = backupForGKEClient.DeleteRestore(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = backupForGKEClient.PollOnceDeleteRestore(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteRestoreAsync</summary>
        public async Task DeleteRestoreRequestObjectAsync()
        {
            // Snippet: DeleteRestoreAsync(DeleteRestoreRequest, CallSettings)
            // Additional: DeleteRestoreAsync(DeleteRestoreRequest, CancellationToken)
            // Create client
            BackupForGKEClient backupForGKEClient = await BackupForGKEClient.CreateAsync();
            // Initialize request argument(s)
            DeleteRestoreRequest request = new DeleteRestoreRequest
            {
                RestoreName = RestoreName.FromProjectLocationRestorePlanRestore("[PROJECT]", "[LOCATION]", "[RESTORE_PLAN]", "[RESTORE]"),
                Etag = "",
                Force = false,
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await backupForGKEClient.DeleteRestoreAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await backupForGKEClient.PollOnceDeleteRestoreAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteRestore</summary>
        public void DeleteRestore()
        {
            // Snippet: DeleteRestore(string, CallSettings)
            // Create client
            BackupForGKEClient backupForGKEClient = BackupForGKEClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/restorePlans/[RESTORE_PLAN]/restores/[RESTORE]";
            // Make the request
            Operation<Empty, OperationMetadata> response = backupForGKEClient.DeleteRestore(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = backupForGKEClient.PollOnceDeleteRestore(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteRestoreAsync</summary>
        public async Task DeleteRestoreAsync()
        {
            // Snippet: DeleteRestoreAsync(string, CallSettings)
            // Additional: DeleteRestoreAsync(string, CancellationToken)
            // Create client
            BackupForGKEClient backupForGKEClient = await BackupForGKEClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/restorePlans/[RESTORE_PLAN]/restores/[RESTORE]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await backupForGKEClient.DeleteRestoreAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await backupForGKEClient.PollOnceDeleteRestoreAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteRestore</summary>
        public void DeleteRestoreResourceNames()
        {
            // Snippet: DeleteRestore(RestoreName, CallSettings)
            // Create client
            BackupForGKEClient backupForGKEClient = BackupForGKEClient.Create();
            // Initialize request argument(s)
            RestoreName name = RestoreName.FromProjectLocationRestorePlanRestore("[PROJECT]", "[LOCATION]", "[RESTORE_PLAN]", "[RESTORE]");
            // Make the request
            Operation<Empty, OperationMetadata> response = backupForGKEClient.DeleteRestore(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = backupForGKEClient.PollOnceDeleteRestore(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteRestoreAsync</summary>
        public async Task DeleteRestoreResourceNamesAsync()
        {
            // Snippet: DeleteRestoreAsync(RestoreName, CallSettings)
            // Additional: DeleteRestoreAsync(RestoreName, CancellationToken)
            // Create client
            BackupForGKEClient backupForGKEClient = await BackupForGKEClient.CreateAsync();
            // Initialize request argument(s)
            RestoreName name = RestoreName.FromProjectLocationRestorePlanRestore("[PROJECT]", "[LOCATION]", "[RESTORE_PLAN]", "[RESTORE]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await backupForGKEClient.DeleteRestoreAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await backupForGKEClient.PollOnceDeleteRestoreAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListVolumeRestores</summary>
        public void ListVolumeRestoresRequestObject()
        {
            // Snippet: ListVolumeRestores(ListVolumeRestoresRequest, CallSettings)
            // Create client
            BackupForGKEClient backupForGKEClient = BackupForGKEClient.Create();
            // Initialize request argument(s)
            ListVolumeRestoresRequest request = new ListVolumeRestoresRequest
            {
                ParentAsRestoreName = RestoreName.FromProjectLocationRestorePlanRestore("[PROJECT]", "[LOCATION]", "[RESTORE_PLAN]", "[RESTORE]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListVolumeRestoresResponse, VolumeRestore> response = backupForGKEClient.ListVolumeRestores(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (VolumeRestore item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListVolumeRestoresResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (VolumeRestore item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<VolumeRestore> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (VolumeRestore item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListVolumeRestoresAsync</summary>
        public async Task ListVolumeRestoresRequestObjectAsync()
        {
            // Snippet: ListVolumeRestoresAsync(ListVolumeRestoresRequest, CallSettings)
            // Create client
            BackupForGKEClient backupForGKEClient = await BackupForGKEClient.CreateAsync();
            // Initialize request argument(s)
            ListVolumeRestoresRequest request = new ListVolumeRestoresRequest
            {
                ParentAsRestoreName = RestoreName.FromProjectLocationRestorePlanRestore("[PROJECT]", "[LOCATION]", "[RESTORE_PLAN]", "[RESTORE]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListVolumeRestoresResponse, VolumeRestore> response = backupForGKEClient.ListVolumeRestoresAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((VolumeRestore item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListVolumeRestoresResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (VolumeRestore item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<VolumeRestore> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (VolumeRestore item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListVolumeRestores</summary>
        public void ListVolumeRestores()
        {
            // Snippet: ListVolumeRestores(string, string, int?, CallSettings)
            // Create client
            BackupForGKEClient backupForGKEClient = BackupForGKEClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/restorePlans/[RESTORE_PLAN]/restores/[RESTORE]";
            // Make the request
            PagedEnumerable<ListVolumeRestoresResponse, VolumeRestore> response = backupForGKEClient.ListVolumeRestores(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (VolumeRestore item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListVolumeRestoresResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (VolumeRestore item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<VolumeRestore> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (VolumeRestore item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListVolumeRestoresAsync</summary>
        public async Task ListVolumeRestoresAsync()
        {
            // Snippet: ListVolumeRestoresAsync(string, string, int?, CallSettings)
            // Create client
            BackupForGKEClient backupForGKEClient = await BackupForGKEClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/restorePlans/[RESTORE_PLAN]/restores/[RESTORE]";
            // Make the request
            PagedAsyncEnumerable<ListVolumeRestoresResponse, VolumeRestore> response = backupForGKEClient.ListVolumeRestoresAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((VolumeRestore item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListVolumeRestoresResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (VolumeRestore item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<VolumeRestore> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (VolumeRestore item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListVolumeRestores</summary>
        public void ListVolumeRestoresResourceNames()
        {
            // Snippet: ListVolumeRestores(RestoreName, string, int?, CallSettings)
            // Create client
            BackupForGKEClient backupForGKEClient = BackupForGKEClient.Create();
            // Initialize request argument(s)
            RestoreName parent = RestoreName.FromProjectLocationRestorePlanRestore("[PROJECT]", "[LOCATION]", "[RESTORE_PLAN]", "[RESTORE]");
            // Make the request
            PagedEnumerable<ListVolumeRestoresResponse, VolumeRestore> response = backupForGKEClient.ListVolumeRestores(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (VolumeRestore item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListVolumeRestoresResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (VolumeRestore item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<VolumeRestore> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (VolumeRestore item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListVolumeRestoresAsync</summary>
        public async Task ListVolumeRestoresResourceNamesAsync()
        {
            // Snippet: ListVolumeRestoresAsync(RestoreName, string, int?, CallSettings)
            // Create client
            BackupForGKEClient backupForGKEClient = await BackupForGKEClient.CreateAsync();
            // Initialize request argument(s)
            RestoreName parent = RestoreName.FromProjectLocationRestorePlanRestore("[PROJECT]", "[LOCATION]", "[RESTORE_PLAN]", "[RESTORE]");
            // Make the request
            PagedAsyncEnumerable<ListVolumeRestoresResponse, VolumeRestore> response = backupForGKEClient.ListVolumeRestoresAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((VolumeRestore item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListVolumeRestoresResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (VolumeRestore item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<VolumeRestore> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (VolumeRestore item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetVolumeRestore</summary>
        public void GetVolumeRestoreRequestObject()
        {
            // Snippet: GetVolumeRestore(GetVolumeRestoreRequest, CallSettings)
            // Create client
            BackupForGKEClient backupForGKEClient = BackupForGKEClient.Create();
            // Initialize request argument(s)
            GetVolumeRestoreRequest request = new GetVolumeRestoreRequest
            {
                VolumeRestoreName = VolumeRestoreName.FromProjectLocationRestorePlanRestoreVolumeRestore("[PROJECT]", "[LOCATION]", "[RESTORE_PLAN]", "[RESTORE]", "[VOLUME_RESTORE]"),
            };
            // Make the request
            VolumeRestore response = backupForGKEClient.GetVolumeRestore(request);
            // End snippet
        }

        /// <summary>Snippet for GetVolumeRestoreAsync</summary>
        public async Task GetVolumeRestoreRequestObjectAsync()
        {
            // Snippet: GetVolumeRestoreAsync(GetVolumeRestoreRequest, CallSettings)
            // Additional: GetVolumeRestoreAsync(GetVolumeRestoreRequest, CancellationToken)
            // Create client
            BackupForGKEClient backupForGKEClient = await BackupForGKEClient.CreateAsync();
            // Initialize request argument(s)
            GetVolumeRestoreRequest request = new GetVolumeRestoreRequest
            {
                VolumeRestoreName = VolumeRestoreName.FromProjectLocationRestorePlanRestoreVolumeRestore("[PROJECT]", "[LOCATION]", "[RESTORE_PLAN]", "[RESTORE]", "[VOLUME_RESTORE]"),
            };
            // Make the request
            VolumeRestore response = await backupForGKEClient.GetVolumeRestoreAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetVolumeRestore</summary>
        public void GetVolumeRestore()
        {
            // Snippet: GetVolumeRestore(string, CallSettings)
            // Create client
            BackupForGKEClient backupForGKEClient = BackupForGKEClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/restorePlans/[RESTORE_PLAN]/restores/[RESTORE]/volumeRestores/[VOLUME_RESTORE]";
            // Make the request
            VolumeRestore response = backupForGKEClient.GetVolumeRestore(name);
            // End snippet
        }

        /// <summary>Snippet for GetVolumeRestoreAsync</summary>
        public async Task GetVolumeRestoreAsync()
        {
            // Snippet: GetVolumeRestoreAsync(string, CallSettings)
            // Additional: GetVolumeRestoreAsync(string, CancellationToken)
            // Create client
            BackupForGKEClient backupForGKEClient = await BackupForGKEClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/restorePlans/[RESTORE_PLAN]/restores/[RESTORE]/volumeRestores/[VOLUME_RESTORE]";
            // Make the request
            VolumeRestore response = await backupForGKEClient.GetVolumeRestoreAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetVolumeRestore</summary>
        public void GetVolumeRestoreResourceNames()
        {
            // Snippet: GetVolumeRestore(VolumeRestoreName, CallSettings)
            // Create client
            BackupForGKEClient backupForGKEClient = BackupForGKEClient.Create();
            // Initialize request argument(s)
            VolumeRestoreName name = VolumeRestoreName.FromProjectLocationRestorePlanRestoreVolumeRestore("[PROJECT]", "[LOCATION]", "[RESTORE_PLAN]", "[RESTORE]", "[VOLUME_RESTORE]");
            // Make the request
            VolumeRestore response = backupForGKEClient.GetVolumeRestore(name);
            // End snippet
        }

        /// <summary>Snippet for GetVolumeRestoreAsync</summary>
        public async Task GetVolumeRestoreResourceNamesAsync()
        {
            // Snippet: GetVolumeRestoreAsync(VolumeRestoreName, CallSettings)
            // Additional: GetVolumeRestoreAsync(VolumeRestoreName, CancellationToken)
            // Create client
            BackupForGKEClient backupForGKEClient = await BackupForGKEClient.CreateAsync();
            // Initialize request argument(s)
            VolumeRestoreName name = VolumeRestoreName.FromProjectLocationRestorePlanRestoreVolumeRestore("[PROJECT]", "[LOCATION]", "[RESTORE_PLAN]", "[RESTORE]", "[VOLUME_RESTORE]");
            // Make the request
            VolumeRestore response = await backupForGKEClient.GetVolumeRestoreAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetBackupIndexDownloadUrl</summary>
        public void GetBackupIndexDownloadUrlRequestObject()
        {
            // Snippet: GetBackupIndexDownloadUrl(GetBackupIndexDownloadUrlRequest, CallSettings)
            // Create client
            BackupForGKEClient backupForGKEClient = BackupForGKEClient.Create();
            // Initialize request argument(s)
            GetBackupIndexDownloadUrlRequest request = new GetBackupIndexDownloadUrlRequest
            {
                BackupAsBackupName = BackupName.FromProjectLocationBackupPlanBackup("[PROJECT]", "[LOCATION]", "[BACKUP_PLAN]", "[BACKUP]"),
            };
            // Make the request
            GetBackupIndexDownloadUrlResponse response = backupForGKEClient.GetBackupIndexDownloadUrl(request);
            // End snippet
        }

        /// <summary>Snippet for GetBackupIndexDownloadUrlAsync</summary>
        public async Task GetBackupIndexDownloadUrlRequestObjectAsync()
        {
            // Snippet: GetBackupIndexDownloadUrlAsync(GetBackupIndexDownloadUrlRequest, CallSettings)
            // Additional: GetBackupIndexDownloadUrlAsync(GetBackupIndexDownloadUrlRequest, CancellationToken)
            // Create client
            BackupForGKEClient backupForGKEClient = await BackupForGKEClient.CreateAsync();
            // Initialize request argument(s)
            GetBackupIndexDownloadUrlRequest request = new GetBackupIndexDownloadUrlRequest
            {
                BackupAsBackupName = BackupName.FromProjectLocationBackupPlanBackup("[PROJECT]", "[LOCATION]", "[BACKUP_PLAN]", "[BACKUP]"),
            };
            // Make the request
            GetBackupIndexDownloadUrlResponse response = await backupForGKEClient.GetBackupIndexDownloadUrlAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetBackupIndexDownloadUrl</summary>
        public void GetBackupIndexDownloadUrl()
        {
            // Snippet: GetBackupIndexDownloadUrl(string, CallSettings)
            // Create client
            BackupForGKEClient backupForGKEClient = BackupForGKEClient.Create();
            // Initialize request argument(s)
            string backup = "projects/[PROJECT]/locations/[LOCATION]/backupPlans/[BACKUP_PLAN]/backups/[BACKUP]";
            // Make the request
            GetBackupIndexDownloadUrlResponse response = backupForGKEClient.GetBackupIndexDownloadUrl(backup);
            // End snippet
        }

        /// <summary>Snippet for GetBackupIndexDownloadUrlAsync</summary>
        public async Task GetBackupIndexDownloadUrlAsync()
        {
            // Snippet: GetBackupIndexDownloadUrlAsync(string, CallSettings)
            // Additional: GetBackupIndexDownloadUrlAsync(string, CancellationToken)
            // Create client
            BackupForGKEClient backupForGKEClient = await BackupForGKEClient.CreateAsync();
            // Initialize request argument(s)
            string backup = "projects/[PROJECT]/locations/[LOCATION]/backupPlans/[BACKUP_PLAN]/backups/[BACKUP]";
            // Make the request
            GetBackupIndexDownloadUrlResponse response = await backupForGKEClient.GetBackupIndexDownloadUrlAsync(backup);
            // End snippet
        }

        /// <summary>Snippet for GetBackupIndexDownloadUrl</summary>
        public void GetBackupIndexDownloadUrlResourceNames()
        {
            // Snippet: GetBackupIndexDownloadUrl(BackupName, CallSettings)
            // Create client
            BackupForGKEClient backupForGKEClient = BackupForGKEClient.Create();
            // Initialize request argument(s)
            BackupName backup = BackupName.FromProjectLocationBackupPlanBackup("[PROJECT]", "[LOCATION]", "[BACKUP_PLAN]", "[BACKUP]");
            // Make the request
            GetBackupIndexDownloadUrlResponse response = backupForGKEClient.GetBackupIndexDownloadUrl(backup);
            // End snippet
        }

        /// <summary>Snippet for GetBackupIndexDownloadUrlAsync</summary>
        public async Task GetBackupIndexDownloadUrlResourceNamesAsync()
        {
            // Snippet: GetBackupIndexDownloadUrlAsync(BackupName, CallSettings)
            // Additional: GetBackupIndexDownloadUrlAsync(BackupName, CancellationToken)
            // Create client
            BackupForGKEClient backupForGKEClient = await BackupForGKEClient.CreateAsync();
            // Initialize request argument(s)
            BackupName backup = BackupName.FromProjectLocationBackupPlanBackup("[PROJECT]", "[LOCATION]", "[BACKUP_PLAN]", "[BACKUP]");
            // Make the request
            GetBackupIndexDownloadUrlResponse response = await backupForGKEClient.GetBackupIndexDownloadUrlAsync(backup);
            // End snippet
        }
    }
}
