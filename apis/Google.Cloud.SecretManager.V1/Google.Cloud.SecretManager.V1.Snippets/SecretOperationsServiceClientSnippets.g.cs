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
    using Google.Cloud.SecretManager.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedSecretOperationsServiceClientSnippets
    {
        /// <summary>Snippet for ListBackups</summary>
        public void ListBackupsRequestObject()
        {
            // Snippet: ListBackups(ListBackupsRequest, CallSettings)
            // Create client
            SecretOperationsServiceClient secretOperationsServiceClient = SecretOperationsServiceClient.Create();
            // Initialize request argument(s)
            ListBackupsRequest request = new ListBackupsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListBackupsResponse, Backup> response = secretOperationsServiceClient.ListBackups(request);

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
            SecretOperationsServiceClient secretOperationsServiceClient = await SecretOperationsServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListBackupsRequest request = new ListBackupsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListBackupsResponse, Backup> response = secretOperationsServiceClient.ListBackupsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Backup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListBackupsResponse page in response.AsRawResponses())
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
            SecretOperationsServiceClient secretOperationsServiceClient = SecretOperationsServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListBackupsResponse, Backup> response = secretOperationsServiceClient.ListBackups(parent);

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
            SecretOperationsServiceClient secretOperationsServiceClient = await SecretOperationsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListBackupsResponse, Backup> response = secretOperationsServiceClient.ListBackupsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Backup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListBackupsResponse page in response.AsRawResponses())
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
            // Snippet: ListBackups(LocationName, string, int?, CallSettings)
            // Create client
            SecretOperationsServiceClient secretOperationsServiceClient = SecretOperationsServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListBackupsResponse, Backup> response = secretOperationsServiceClient.ListBackups(parent);

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
            // Snippet: ListBackupsAsync(LocationName, string, int?, CallSettings)
            // Create client
            SecretOperationsServiceClient secretOperationsServiceClient = await SecretOperationsServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListBackupsResponse, Backup> response = secretOperationsServiceClient.ListBackupsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Backup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListBackupsResponse page in response.AsRawResponses())
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
            SecretOperationsServiceClient secretOperationsServiceClient = SecretOperationsServiceClient.Create();
            // Initialize request argument(s)
            GetBackupRequest request = new GetBackupRequest
            {
                BackupName = BackupName.FromProjectLocationBackup("[PROJECT]", "[LOCATION]", "[BACKUP]"),
            };
            // Make the request
            Backup response = secretOperationsServiceClient.GetBackup(request);
            // End snippet
        }

        /// <summary>Snippet for GetBackupAsync</summary>
        public async Task GetBackupRequestObjectAsync()
        {
            // Snippet: GetBackupAsync(GetBackupRequest, CallSettings)
            // Additional: GetBackupAsync(GetBackupRequest, CancellationToken)
            // Create client
            SecretOperationsServiceClient secretOperationsServiceClient = await SecretOperationsServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetBackupRequest request = new GetBackupRequest
            {
                BackupName = BackupName.FromProjectLocationBackup("[PROJECT]", "[LOCATION]", "[BACKUP]"),
            };
            // Make the request
            Backup response = await secretOperationsServiceClient.GetBackupAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetBackup</summary>
        public void GetBackup()
        {
            // Snippet: GetBackup(string, CallSettings)
            // Create client
            SecretOperationsServiceClient secretOperationsServiceClient = SecretOperationsServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/backups/[BACKUP]";
            // Make the request
            Backup response = secretOperationsServiceClient.GetBackup(name);
            // End snippet
        }

        /// <summary>Snippet for GetBackupAsync</summary>
        public async Task GetBackupAsync()
        {
            // Snippet: GetBackupAsync(string, CallSettings)
            // Additional: GetBackupAsync(string, CancellationToken)
            // Create client
            SecretOperationsServiceClient secretOperationsServiceClient = await SecretOperationsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/backups/[BACKUP]";
            // Make the request
            Backup response = await secretOperationsServiceClient.GetBackupAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetBackup</summary>
        public void GetBackupResourceNames()
        {
            // Snippet: GetBackup(BackupName, CallSettings)
            // Create client
            SecretOperationsServiceClient secretOperationsServiceClient = SecretOperationsServiceClient.Create();
            // Initialize request argument(s)
            BackupName name = BackupName.FromProjectLocationBackup("[PROJECT]", "[LOCATION]", "[BACKUP]");
            // Make the request
            Backup response = secretOperationsServiceClient.GetBackup(name);
            // End snippet
        }

        /// <summary>Snippet for GetBackupAsync</summary>
        public async Task GetBackupResourceNamesAsync()
        {
            // Snippet: GetBackupAsync(BackupName, CallSettings)
            // Additional: GetBackupAsync(BackupName, CancellationToken)
            // Create client
            SecretOperationsServiceClient secretOperationsServiceClient = await SecretOperationsServiceClient.CreateAsync();
            // Initialize request argument(s)
            BackupName name = BackupName.FromProjectLocationBackup("[PROJECT]", "[LOCATION]", "[BACKUP]");
            // Make the request
            Backup response = await secretOperationsServiceClient.GetBackupAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateBackup</summary>
        public void CreateBackupRequestObject()
        {
            // Snippet: CreateBackup(CreateBackupRequest, CallSettings)
            // Create client
            SecretOperationsServiceClient secretOperationsServiceClient = SecretOperationsServiceClient.Create();
            // Initialize request argument(s)
            CreateBackupRequest request = new CreateBackupRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                BackupId = "",
                Backup = new Backup(),
            };
            // Make the request
            Operation<Backup, OperationMetadata> response = secretOperationsServiceClient.CreateBackup(request);

            // Poll until the returned long-running operation is complete
            Operation<Backup, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Backup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Backup, OperationMetadata> retrievedResponse = secretOperationsServiceClient.PollOnceCreateBackup(operationName);
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
            SecretOperationsServiceClient secretOperationsServiceClient = await SecretOperationsServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateBackupRequest request = new CreateBackupRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                BackupId = "",
                Backup = new Backup(),
            };
            // Make the request
            Operation<Backup, OperationMetadata> response = await secretOperationsServiceClient.CreateBackupAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Backup, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Backup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Backup, OperationMetadata> retrievedResponse = await secretOperationsServiceClient.PollOnceCreateBackupAsync(operationName);
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
            SecretOperationsServiceClient secretOperationsServiceClient = SecretOperationsServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Backup backup = new Backup();
            string backupId = "";
            // Make the request
            Operation<Backup, OperationMetadata> response = secretOperationsServiceClient.CreateBackup(parent, backup, backupId);

            // Poll until the returned long-running operation is complete
            Operation<Backup, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Backup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Backup, OperationMetadata> retrievedResponse = secretOperationsServiceClient.PollOnceCreateBackup(operationName);
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
            SecretOperationsServiceClient secretOperationsServiceClient = await SecretOperationsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Backup backup = new Backup();
            string backupId = "";
            // Make the request
            Operation<Backup, OperationMetadata> response = await secretOperationsServiceClient.CreateBackupAsync(parent, backup, backupId);

            // Poll until the returned long-running operation is complete
            Operation<Backup, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Backup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Backup, OperationMetadata> retrievedResponse = await secretOperationsServiceClient.PollOnceCreateBackupAsync(operationName);
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
            // Snippet: CreateBackup(LocationName, Backup, string, CallSettings)
            // Create client
            SecretOperationsServiceClient secretOperationsServiceClient = SecretOperationsServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Backup backup = new Backup();
            string backupId = "";
            // Make the request
            Operation<Backup, OperationMetadata> response = secretOperationsServiceClient.CreateBackup(parent, backup, backupId);

            // Poll until the returned long-running operation is complete
            Operation<Backup, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Backup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Backup, OperationMetadata> retrievedResponse = secretOperationsServiceClient.PollOnceCreateBackup(operationName);
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
            // Snippet: CreateBackupAsync(LocationName, Backup, string, CallSettings)
            // Additional: CreateBackupAsync(LocationName, Backup, string, CancellationToken)
            // Create client
            SecretOperationsServiceClient secretOperationsServiceClient = await SecretOperationsServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Backup backup = new Backup();
            string backupId = "";
            // Make the request
            Operation<Backup, OperationMetadata> response = await secretOperationsServiceClient.CreateBackupAsync(parent, backup, backupId);

            // Poll until the returned long-running operation is complete
            Operation<Backup, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Backup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Backup, OperationMetadata> retrievedResponse = await secretOperationsServiceClient.PollOnceCreateBackupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Backup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateBackup</summary>
        public void UpdateBackupRequestObject()
        {
            // Snippet: UpdateBackup(UpdateBackupRequest, CallSettings)
            // Create client
            SecretOperationsServiceClient secretOperationsServiceClient = SecretOperationsServiceClient.Create();
            // Initialize request argument(s)
            UpdateBackupRequest request = new UpdateBackupRequest
            {
                UpdateMask = new FieldMask(),
                Backup = new Backup(),
            };
            // Make the request
            Operation<Backup, OperationMetadata> response = secretOperationsServiceClient.UpdateBackup(request);

            // Poll until the returned long-running operation is complete
            Operation<Backup, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Backup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Backup, OperationMetadata> retrievedResponse = secretOperationsServiceClient.PollOnceUpdateBackup(operationName);
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
            SecretOperationsServiceClient secretOperationsServiceClient = await SecretOperationsServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateBackupRequest request = new UpdateBackupRequest
            {
                UpdateMask = new FieldMask(),
                Backup = new Backup(),
            };
            // Make the request
            Operation<Backup, OperationMetadata> response = await secretOperationsServiceClient.UpdateBackupAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Backup, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Backup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Backup, OperationMetadata> retrievedResponse = await secretOperationsServiceClient.PollOnceUpdateBackupAsync(operationName);
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
            SecretOperationsServiceClient secretOperationsServiceClient = SecretOperationsServiceClient.Create();
            // Initialize request argument(s)
            Backup backup = new Backup();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Backup, OperationMetadata> response = secretOperationsServiceClient.UpdateBackup(backup, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Backup, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Backup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Backup, OperationMetadata> retrievedResponse = secretOperationsServiceClient.PollOnceUpdateBackup(operationName);
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
            SecretOperationsServiceClient secretOperationsServiceClient = await SecretOperationsServiceClient.CreateAsync();
            // Initialize request argument(s)
            Backup backup = new Backup();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Backup, OperationMetadata> response = await secretOperationsServiceClient.UpdateBackupAsync(backup, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Backup, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Backup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Backup, OperationMetadata> retrievedResponse = await secretOperationsServiceClient.PollOnceUpdateBackupAsync(operationName);
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
            SecretOperationsServiceClient secretOperationsServiceClient = SecretOperationsServiceClient.Create();
            // Initialize request argument(s)
            DeleteBackupRequest request = new DeleteBackupRequest
            {
                BackupName = BackupName.FromProjectLocationBackup("[PROJECT]", "[LOCATION]", "[BACKUP]"),
                Etag = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = secretOperationsServiceClient.DeleteBackup(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = secretOperationsServiceClient.PollOnceDeleteBackup(operationName);
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
            SecretOperationsServiceClient secretOperationsServiceClient = await SecretOperationsServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteBackupRequest request = new DeleteBackupRequest
            {
                BackupName = BackupName.FromProjectLocationBackup("[PROJECT]", "[LOCATION]", "[BACKUP]"),
                Etag = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await secretOperationsServiceClient.DeleteBackupAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await secretOperationsServiceClient.PollOnceDeleteBackupAsync(operationName);
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
            SecretOperationsServiceClient secretOperationsServiceClient = SecretOperationsServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/backups/[BACKUP]";
            // Make the request
            Operation<Empty, OperationMetadata> response = secretOperationsServiceClient.DeleteBackup(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = secretOperationsServiceClient.PollOnceDeleteBackup(operationName);
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
            SecretOperationsServiceClient secretOperationsServiceClient = await SecretOperationsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/backups/[BACKUP]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await secretOperationsServiceClient.DeleteBackupAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await secretOperationsServiceClient.PollOnceDeleteBackupAsync(operationName);
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
            SecretOperationsServiceClient secretOperationsServiceClient = SecretOperationsServiceClient.Create();
            // Initialize request argument(s)
            BackupName name = BackupName.FromProjectLocationBackup("[PROJECT]", "[LOCATION]", "[BACKUP]");
            // Make the request
            Operation<Empty, OperationMetadata> response = secretOperationsServiceClient.DeleteBackup(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = secretOperationsServiceClient.PollOnceDeleteBackup(operationName);
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
            SecretOperationsServiceClient secretOperationsServiceClient = await SecretOperationsServiceClient.CreateAsync();
            // Initialize request argument(s)
            BackupName name = BackupName.FromProjectLocationBackup("[PROJECT]", "[LOCATION]", "[BACKUP]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await secretOperationsServiceClient.DeleteBackupAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await secretOperationsServiceClient.PollOnceDeleteBackupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RestoreBackup</summary>
        public void RestoreBackupRequestObject()
        {
            // Snippet: RestoreBackup(RestoreBackupRequest, CallSettings)
            // Create client
            SecretOperationsServiceClient secretOperationsServiceClient = SecretOperationsServiceClient.Create();
            // Initialize request argument(s)
            RestoreBackupRequest request = new RestoreBackupRequest
            {
                BackupName = BackupName.FromProjectLocationBackup("[PROJECT]", "[LOCATION]", "[BACKUP]"),
                DestinationSecretParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                DestinationSecretId = "",
                KmsKeyNameAsCryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
            };
            // Make the request
            Operation<Secret, OperationMetadata> response = secretOperationsServiceClient.RestoreBackup(request);

            // Poll until the returned long-running operation is complete
            Operation<Secret, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Secret result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Secret, OperationMetadata> retrievedResponse = secretOperationsServiceClient.PollOnceRestoreBackup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Secret retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RestoreBackupAsync</summary>
        public async Task RestoreBackupRequestObjectAsync()
        {
            // Snippet: RestoreBackupAsync(RestoreBackupRequest, CallSettings)
            // Additional: RestoreBackupAsync(RestoreBackupRequest, CancellationToken)
            // Create client
            SecretOperationsServiceClient secretOperationsServiceClient = await SecretOperationsServiceClient.CreateAsync();
            // Initialize request argument(s)
            RestoreBackupRequest request = new RestoreBackupRequest
            {
                BackupName = BackupName.FromProjectLocationBackup("[PROJECT]", "[LOCATION]", "[BACKUP]"),
                DestinationSecretParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                DestinationSecretId = "",
                KmsKeyNameAsCryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
            };
            // Make the request
            Operation<Secret, OperationMetadata> response = await secretOperationsServiceClient.RestoreBackupAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Secret, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Secret result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Secret, OperationMetadata> retrievedResponse = await secretOperationsServiceClient.PollOnceRestoreBackupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Secret retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RestoreBackup</summary>
        public void RestoreBackup()
        {
            // Snippet: RestoreBackup(string, string, string, CallSettings)
            // Create client
            SecretOperationsServiceClient secretOperationsServiceClient = SecretOperationsServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/backups/[BACKUP]";
            string destinationSecretParent = "projects/[PROJECT]";
            string destinationSecretId = "";
            // Make the request
            Operation<Secret, OperationMetadata> response = secretOperationsServiceClient.RestoreBackup(name, destinationSecretParent, destinationSecretId);

            // Poll until the returned long-running operation is complete
            Operation<Secret, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Secret result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Secret, OperationMetadata> retrievedResponse = secretOperationsServiceClient.PollOnceRestoreBackup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Secret retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RestoreBackupAsync</summary>
        public async Task RestoreBackupAsync()
        {
            // Snippet: RestoreBackupAsync(string, string, string, CallSettings)
            // Additional: RestoreBackupAsync(string, string, string, CancellationToken)
            // Create client
            SecretOperationsServiceClient secretOperationsServiceClient = await SecretOperationsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/backups/[BACKUP]";
            string destinationSecretParent = "projects/[PROJECT]";
            string destinationSecretId = "";
            // Make the request
            Operation<Secret, OperationMetadata> response = await secretOperationsServiceClient.RestoreBackupAsync(name, destinationSecretParent, destinationSecretId);

            // Poll until the returned long-running operation is complete
            Operation<Secret, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Secret result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Secret, OperationMetadata> retrievedResponse = await secretOperationsServiceClient.PollOnceRestoreBackupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Secret retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RestoreBackup</summary>
        public void RestoreBackupResourceNames1()
        {
            // Snippet: RestoreBackup(BackupName, ProjectName, string, CallSettings)
            // Create client
            SecretOperationsServiceClient secretOperationsServiceClient = SecretOperationsServiceClient.Create();
            // Initialize request argument(s)
            BackupName name = BackupName.FromProjectLocationBackup("[PROJECT]", "[LOCATION]", "[BACKUP]");
            ProjectName destinationSecretParent = ProjectName.FromProject("[PROJECT]");
            string destinationSecretId = "";
            // Make the request
            Operation<Secret, OperationMetadata> response = secretOperationsServiceClient.RestoreBackup(name, destinationSecretParent, destinationSecretId);

            // Poll until the returned long-running operation is complete
            Operation<Secret, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Secret result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Secret, OperationMetadata> retrievedResponse = secretOperationsServiceClient.PollOnceRestoreBackup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Secret retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RestoreBackupAsync</summary>
        public async Task RestoreBackupResourceNames1Async()
        {
            // Snippet: RestoreBackupAsync(BackupName, ProjectName, string, CallSettings)
            // Additional: RestoreBackupAsync(BackupName, ProjectName, string, CancellationToken)
            // Create client
            SecretOperationsServiceClient secretOperationsServiceClient = await SecretOperationsServiceClient.CreateAsync();
            // Initialize request argument(s)
            BackupName name = BackupName.FromProjectLocationBackup("[PROJECT]", "[LOCATION]", "[BACKUP]");
            ProjectName destinationSecretParent = ProjectName.FromProject("[PROJECT]");
            string destinationSecretId = "";
            // Make the request
            Operation<Secret, OperationMetadata> response = await secretOperationsServiceClient.RestoreBackupAsync(name, destinationSecretParent, destinationSecretId);

            // Poll until the returned long-running operation is complete
            Operation<Secret, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Secret result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Secret, OperationMetadata> retrievedResponse = await secretOperationsServiceClient.PollOnceRestoreBackupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Secret retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RestoreBackup</summary>
        public void RestoreBackupResourceNames2()
        {
            // Snippet: RestoreBackup(BackupName, LocationName, string, CallSettings)
            // Create client
            SecretOperationsServiceClient secretOperationsServiceClient = SecretOperationsServiceClient.Create();
            // Initialize request argument(s)
            BackupName name = BackupName.FromProjectLocationBackup("[PROJECT]", "[LOCATION]", "[BACKUP]");
            LocationName destinationSecretParent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            string destinationSecretId = "";
            // Make the request
            Operation<Secret, OperationMetadata> response = secretOperationsServiceClient.RestoreBackup(name, destinationSecretParent, destinationSecretId);

            // Poll until the returned long-running operation is complete
            Operation<Secret, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Secret result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Secret, OperationMetadata> retrievedResponse = secretOperationsServiceClient.PollOnceRestoreBackup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Secret retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RestoreBackupAsync</summary>
        public async Task RestoreBackupResourceNames2Async()
        {
            // Snippet: RestoreBackupAsync(BackupName, LocationName, string, CallSettings)
            // Additional: RestoreBackupAsync(BackupName, LocationName, string, CancellationToken)
            // Create client
            SecretOperationsServiceClient secretOperationsServiceClient = await SecretOperationsServiceClient.CreateAsync();
            // Initialize request argument(s)
            BackupName name = BackupName.FromProjectLocationBackup("[PROJECT]", "[LOCATION]", "[BACKUP]");
            LocationName destinationSecretParent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            string destinationSecretId = "";
            // Make the request
            Operation<Secret, OperationMetadata> response = await secretOperationsServiceClient.RestoreBackupAsync(name, destinationSecretParent, destinationSecretId);

            // Poll until the returned long-running operation is complete
            Operation<Secret, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Secret result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Secret, OperationMetadata> retrievedResponse = await secretOperationsServiceClient.PollOnceRestoreBackupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Secret retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
