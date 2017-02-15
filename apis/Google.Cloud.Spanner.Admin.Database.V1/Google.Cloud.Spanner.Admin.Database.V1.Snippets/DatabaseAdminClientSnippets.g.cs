// Copyright 2017, Google Inc. All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

using Google.Api.Gax;
using Google.Api.Gax.Grpc;
using Google.Cloud.Iam.V1;
using Google.Cloud.Spanner.Admin.Database.V1;
using Google.LongRunning;
using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Spanner.Admin.Database.V1.Snippets
{
    public class GeneratedDatabaseAdminClientSnippets
    {
        public async Task ListDatabasesAsync()
        {
            // Snippet: ListDatabasesAsync(string,string,int?,CallSettings)
            // Create client
            DatabaseAdminClient databaseAdminClient = await DatabaseAdminClient.CreateAsync();
            // Initialize request argument(s)
            string formattedParent = new InstanceName("[PROJECT]", "[INSTANCE]").ToString();
            // Make the request
            PagedAsyncEnumerable<ListDatabasesResponse,Database> response =
                databaseAdminClient.ListDatabasesAsync(formattedParent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Database item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDatabasesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Database item in page)
                {
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Database> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Database item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        public void ListDatabases()
        {
            // Snippet: ListDatabases(string,string,int?,CallSettings)
            // Create client
            DatabaseAdminClient databaseAdminClient = DatabaseAdminClient.Create();
            // Initialize request argument(s)
            string formattedParent = new InstanceName("[PROJECT]", "[INSTANCE]").ToString();
            // Make the request
            PagedEnumerable<ListDatabasesResponse,Database> response =
                databaseAdminClient.ListDatabases(formattedParent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Database item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDatabasesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Database item in page)
                {
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Database> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Database item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        public async Task ListDatabasesAsync_RequestObject()
        {
            // Snippet: ListDatabasesAsync(ListDatabasesRequest,CallSettings)
            // Create client
            DatabaseAdminClient databaseAdminClient = await DatabaseAdminClient.CreateAsync();
            // Initialize request argument(s)
            ListDatabasesRequest request = new ListDatabasesRequest
            {
                Parent = new InstanceName("[PROJECT]", "[INSTANCE]").ToString(),
            };
            // Make the request
            PagedAsyncEnumerable<ListDatabasesResponse,Database> response =
                databaseAdminClient.ListDatabasesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Database item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDatabasesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Database item in page)
                {
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Database> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Database item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        public void ListDatabases_RequestObject()
        {
            // Snippet: ListDatabases(ListDatabasesRequest,CallSettings)
            // Create client
            DatabaseAdminClient databaseAdminClient = DatabaseAdminClient.Create();
            // Initialize request argument(s)
            ListDatabasesRequest request = new ListDatabasesRequest
            {
                Parent = new InstanceName("[PROJECT]", "[INSTANCE]").ToString(),
            };
            // Make the request
            PagedEnumerable<ListDatabasesResponse,Database> response =
                databaseAdminClient.ListDatabases(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Database item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDatabasesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Database item in page)
                {
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Database> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Database item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        public async Task CreateDatabaseAsync()
        {
            // Snippet: CreateDatabaseAsync(string,string,CallSettings)
            // Additional: CreateDatabaseAsync(string,string,CancellationToken)
            // Create client
            DatabaseAdminClient databaseAdminClient = await DatabaseAdminClient.CreateAsync();
            // Initialize request argument(s)
            string formattedParent = new InstanceName("[PROJECT]", "[INSTANCE]").ToString();
            string createStatement = "";
            // Make the request
            Operation<Database> response =
                await databaseAdminClient.CreateDatabaseAsync(formattedParent, createStatement);

            // Poll until the returned long-running operation is complete
            Operation<Database> completedResponse =
                await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Database result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Database> retrievedResponse =
                await databaseAdminClient.PollOnceCreateDatabaseAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Database retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        public void CreateDatabase()
        {
            // Snippet: CreateDatabase(string,string,CallSettings)
            // Create client
            DatabaseAdminClient databaseAdminClient = DatabaseAdminClient.Create();
            // Initialize request argument(s)
            string formattedParent = new InstanceName("[PROJECT]", "[INSTANCE]").ToString();
            string createStatement = "";
            // Make the request
            Operation<Database> response =
                databaseAdminClient.CreateDatabase(formattedParent, createStatement);

            // Poll until the returned long-running operation is complete
            Operation<Database> completedResponse =
                response.PollUntilCompleted();
            // Retrieve the operation result
            Database result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Database> retrievedResponse =
                databaseAdminClient.PollOnceCreateDatabase(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Database retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        public async Task CreateDatabaseAsync_RequestObject()
        {
            // Snippet: CreateDatabaseAsync(CreateDatabaseRequest,CallSettings)
            // Create client
            DatabaseAdminClient databaseAdminClient = await DatabaseAdminClient.CreateAsync();
            // Initialize request argument(s)
            CreateDatabaseRequest request = new CreateDatabaseRequest
            {
                Parent = new InstanceName("[PROJECT]", "[INSTANCE]").ToString(),
                CreateStatement = "",
            };
            // Make the request
            Operation<Database> response =
                await databaseAdminClient.CreateDatabaseAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Database> completedResponse =
                await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Database result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Database> retrievedResponse =
                await databaseAdminClient.PollOnceCreateDatabaseAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Database retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        public void CreateDatabase_RequestObject()
        {
            // Snippet: CreateDatabase(CreateDatabaseRequest,CallSettings)
            // Create client
            DatabaseAdminClient databaseAdminClient = DatabaseAdminClient.Create();
            // Initialize request argument(s)
            CreateDatabaseRequest request = new CreateDatabaseRequest
            {
                Parent = new InstanceName("[PROJECT]", "[INSTANCE]").ToString(),
                CreateStatement = "",
            };
            // Make the request
            Operation<Database> response =
                databaseAdminClient.CreateDatabase(request);

            // Poll until the returned long-running operation is complete
            Operation<Database> completedResponse =
                response.PollUntilCompleted();
            // Retrieve the operation result
            Database result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Database> retrievedResponse =
                databaseAdminClient.PollOnceCreateDatabase(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Database retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        public async Task GetDatabaseAsync()
        {
            // Snippet: GetDatabaseAsync(string,CallSettings)
            // Additional: GetDatabaseAsync(string,CancellationToken)
            // Create client
            DatabaseAdminClient databaseAdminClient = await DatabaseAdminClient.CreateAsync();
            // Initialize request argument(s)
            string formattedName = new DatabaseName("[PROJECT]", "[INSTANCE]", "[DATABASE]").ToString();
            // Make the request
            Database response = await databaseAdminClient.GetDatabaseAsync(formattedName);
            // End snippet
        }

        public void GetDatabase()
        {
            // Snippet: GetDatabase(string,CallSettings)
            // Create client
            DatabaseAdminClient databaseAdminClient = DatabaseAdminClient.Create();
            // Initialize request argument(s)
            string formattedName = new DatabaseName("[PROJECT]", "[INSTANCE]", "[DATABASE]").ToString();
            // Make the request
            Database response = databaseAdminClient.GetDatabase(formattedName);
            // End snippet
        }

        public async Task GetDatabaseAsync_RequestObject()
        {
            // Snippet: GetDatabaseAsync(GetDatabaseRequest,CallSettings)
            // Create client
            DatabaseAdminClient databaseAdminClient = await DatabaseAdminClient.CreateAsync();
            // Initialize request argument(s)
            GetDatabaseRequest request = new GetDatabaseRequest
            {
                Name = new DatabaseName("[PROJECT]", "[INSTANCE]", "[DATABASE]").ToString(),
            };
            // Make the request
            Database response = await databaseAdminClient.GetDatabaseAsync(request);
            // End snippet
        }

        public void GetDatabase_RequestObject()
        {
            // Snippet: GetDatabase(GetDatabaseRequest,CallSettings)
            // Create client
            DatabaseAdminClient databaseAdminClient = DatabaseAdminClient.Create();
            // Initialize request argument(s)
            GetDatabaseRequest request = new GetDatabaseRequest
            {
                Name = new DatabaseName("[PROJECT]", "[INSTANCE]", "[DATABASE]").ToString(),
            };
            // Make the request
            Database response = databaseAdminClient.GetDatabase(request);
            // End snippet
        }

        public async Task UpdateDatabaseDdlAsync()
        {
            // Snippet: UpdateDatabaseDdlAsync(string,IEnumerable<string>,CallSettings)
            // Additional: UpdateDatabaseDdlAsync(string,IEnumerable<string>,CancellationToken)
            // Create client
            DatabaseAdminClient databaseAdminClient = await DatabaseAdminClient.CreateAsync();
            // Initialize request argument(s)
            string formattedDatabase = new DatabaseName("[PROJECT]", "[INSTANCE]", "[DATABASE]").ToString();
            IEnumerable<string> statements = new List<string>();
            // Make the request
            Operation<Empty> response =
                await databaseAdminClient.UpdateDatabaseDdlAsync(formattedDatabase, statements);

            // Poll until the returned long-running operation is complete
            Operation<Empty> completedResponse =
                await response.PollUntilCompletedAsync();
            // The long-running operation is now complete.

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty> retrievedResponse =
                await databaseAdminClient.PollOnceUpdateDatabaseDdlAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // The long-running operation is now complete.
            }
            // End snippet
        }

        public void UpdateDatabaseDdl()
        {
            // Snippet: UpdateDatabaseDdl(string,IEnumerable<string>,CallSettings)
            // Create client
            DatabaseAdminClient databaseAdminClient = DatabaseAdminClient.Create();
            // Initialize request argument(s)
            string formattedDatabase = new DatabaseName("[PROJECT]", "[INSTANCE]", "[DATABASE]").ToString();
            IEnumerable<string> statements = new List<string>();
            // Make the request
            Operation<Empty> response =
                databaseAdminClient.UpdateDatabaseDdl(formattedDatabase, statements);

            // Poll until the returned long-running operation is complete
            Operation<Empty> completedResponse =
                response.PollUntilCompleted();
            // The long-running operation is now complete.

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty> retrievedResponse =
                databaseAdminClient.PollOnceUpdateDatabaseDdl(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // The long-running operation is now complete.
            }
            // End snippet
        }

        public async Task UpdateDatabaseDdlAsync_RequestObject()
        {
            // Snippet: UpdateDatabaseDdlAsync(UpdateDatabaseDdlRequest,CallSettings)
            // Create client
            DatabaseAdminClient databaseAdminClient = await DatabaseAdminClient.CreateAsync();
            // Initialize request argument(s)
            UpdateDatabaseDdlRequest request = new UpdateDatabaseDdlRequest
            {
                Database = new DatabaseName("[PROJECT]", "[INSTANCE]", "[DATABASE]").ToString(),
                Statements = { },
            };
            // Make the request
            Operation<Empty> response =
                await databaseAdminClient.UpdateDatabaseDdlAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty> completedResponse =
                await response.PollUntilCompletedAsync();
            // The long-running operation is now complete.

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty> retrievedResponse =
                await databaseAdminClient.PollOnceUpdateDatabaseDdlAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // The long-running operation is now complete.
            }
            // End snippet
        }

        public void UpdateDatabaseDdl_RequestObject()
        {
            // Snippet: UpdateDatabaseDdl(UpdateDatabaseDdlRequest,CallSettings)
            // Create client
            DatabaseAdminClient databaseAdminClient = DatabaseAdminClient.Create();
            // Initialize request argument(s)
            UpdateDatabaseDdlRequest request = new UpdateDatabaseDdlRequest
            {
                Database = new DatabaseName("[PROJECT]", "[INSTANCE]", "[DATABASE]").ToString(),
                Statements = { },
            };
            // Make the request
            Operation<Empty> response =
                databaseAdminClient.UpdateDatabaseDdl(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty> completedResponse =
                response.PollUntilCompleted();
            // The long-running operation is now complete.

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty> retrievedResponse =
                databaseAdminClient.PollOnceUpdateDatabaseDdl(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // The long-running operation is now complete.
            }
            // End snippet
        }

        public async Task DropDatabaseAsync()
        {
            // Snippet: DropDatabaseAsync(string,CallSettings)
            // Additional: DropDatabaseAsync(string,CancellationToken)
            // Create client
            DatabaseAdminClient databaseAdminClient = await DatabaseAdminClient.CreateAsync();
            // Initialize request argument(s)
            string formattedDatabase = new DatabaseName("[PROJECT]", "[INSTANCE]", "[DATABASE]").ToString();
            // Make the request
            await databaseAdminClient.DropDatabaseAsync(formattedDatabase);
            // End snippet
        }

        public void DropDatabase()
        {
            // Snippet: DropDatabase(string,CallSettings)
            // Create client
            DatabaseAdminClient databaseAdminClient = DatabaseAdminClient.Create();
            // Initialize request argument(s)
            string formattedDatabase = new DatabaseName("[PROJECT]", "[INSTANCE]", "[DATABASE]").ToString();
            // Make the request
            databaseAdminClient.DropDatabase(formattedDatabase);
            // End snippet
        }

        public async Task DropDatabaseAsync_RequestObject()
        {
            // Snippet: DropDatabaseAsync(DropDatabaseRequest,CallSettings)
            // Create client
            DatabaseAdminClient databaseAdminClient = await DatabaseAdminClient.CreateAsync();
            // Initialize request argument(s)
            DropDatabaseRequest request = new DropDatabaseRequest
            {
                Database = new DatabaseName("[PROJECT]", "[INSTANCE]", "[DATABASE]").ToString(),
            };
            // Make the request
            await databaseAdminClient.DropDatabaseAsync(request);
            // End snippet
        }

        public void DropDatabase_RequestObject()
        {
            // Snippet: DropDatabase(DropDatabaseRequest,CallSettings)
            // Create client
            DatabaseAdminClient databaseAdminClient = DatabaseAdminClient.Create();
            // Initialize request argument(s)
            DropDatabaseRequest request = new DropDatabaseRequest
            {
                Database = new DatabaseName("[PROJECT]", "[INSTANCE]", "[DATABASE]").ToString(),
            };
            // Make the request
            databaseAdminClient.DropDatabase(request);
            // End snippet
        }

        public async Task GetDatabaseDdlAsync()
        {
            // Snippet: GetDatabaseDdlAsync(string,CallSettings)
            // Additional: GetDatabaseDdlAsync(string,CancellationToken)
            // Create client
            DatabaseAdminClient databaseAdminClient = await DatabaseAdminClient.CreateAsync();
            // Initialize request argument(s)
            string formattedDatabase = new DatabaseName("[PROJECT]", "[INSTANCE]", "[DATABASE]").ToString();
            // Make the request
            GetDatabaseDdlResponse response = await databaseAdminClient.GetDatabaseDdlAsync(formattedDatabase);
            // End snippet
        }

        public void GetDatabaseDdl()
        {
            // Snippet: GetDatabaseDdl(string,CallSettings)
            // Create client
            DatabaseAdminClient databaseAdminClient = DatabaseAdminClient.Create();
            // Initialize request argument(s)
            string formattedDatabase = new DatabaseName("[PROJECT]", "[INSTANCE]", "[DATABASE]").ToString();
            // Make the request
            GetDatabaseDdlResponse response = databaseAdminClient.GetDatabaseDdl(formattedDatabase);
            // End snippet
        }

        public async Task GetDatabaseDdlAsync_RequestObject()
        {
            // Snippet: GetDatabaseDdlAsync(GetDatabaseDdlRequest,CallSettings)
            // Create client
            DatabaseAdminClient databaseAdminClient = await DatabaseAdminClient.CreateAsync();
            // Initialize request argument(s)
            GetDatabaseDdlRequest request = new GetDatabaseDdlRequest
            {
                Database = new DatabaseName("[PROJECT]", "[INSTANCE]", "[DATABASE]").ToString(),
            };
            // Make the request
            GetDatabaseDdlResponse response = await databaseAdminClient.GetDatabaseDdlAsync(request);
            // End snippet
        }

        public void GetDatabaseDdl_RequestObject()
        {
            // Snippet: GetDatabaseDdl(GetDatabaseDdlRequest,CallSettings)
            // Create client
            DatabaseAdminClient databaseAdminClient = DatabaseAdminClient.Create();
            // Initialize request argument(s)
            GetDatabaseDdlRequest request = new GetDatabaseDdlRequest
            {
                Database = new DatabaseName("[PROJECT]", "[INSTANCE]", "[DATABASE]").ToString(),
            };
            // Make the request
            GetDatabaseDdlResponse response = databaseAdminClient.GetDatabaseDdl(request);
            // End snippet
        }

        public async Task SetIamPolicyAsync()
        {
            // Snippet: SetIamPolicyAsync(string,Policy,CallSettings)
            // Additional: SetIamPolicyAsync(string,Policy,CancellationToken)
            // Create client
            DatabaseAdminClient databaseAdminClient = await DatabaseAdminClient.CreateAsync();
            // Initialize request argument(s)
            string formattedResource = new DatabaseName("[PROJECT]", "[INSTANCE]", "[DATABASE]").ToString();
            Policy policy = new Policy();
            // Make the request
            Policy response = await databaseAdminClient.SetIamPolicyAsync(formattedResource, policy);
            // End snippet
        }

        public void SetIamPolicy()
        {
            // Snippet: SetIamPolicy(string,Policy,CallSettings)
            // Create client
            DatabaseAdminClient databaseAdminClient = DatabaseAdminClient.Create();
            // Initialize request argument(s)
            string formattedResource = new DatabaseName("[PROJECT]", "[INSTANCE]", "[DATABASE]").ToString();
            Policy policy = new Policy();
            // Make the request
            Policy response = databaseAdminClient.SetIamPolicy(formattedResource, policy);
            // End snippet
        }

        public async Task SetIamPolicyAsync_RequestObject()
        {
            // Snippet: SetIamPolicyAsync(SetIamPolicyRequest,CallSettings)
            // Create client
            DatabaseAdminClient databaseAdminClient = await DatabaseAdminClient.CreateAsync();
            // Initialize request argument(s)
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                Resource = new DatabaseName("[PROJECT]", "[INSTANCE]", "[DATABASE]").ToString(),
                Policy = new Policy(),
            };
            // Make the request
            Policy response = await databaseAdminClient.SetIamPolicyAsync(request);
            // End snippet
        }

        public void SetIamPolicy_RequestObject()
        {
            // Snippet: SetIamPolicy(SetIamPolicyRequest,CallSettings)
            // Create client
            DatabaseAdminClient databaseAdminClient = DatabaseAdminClient.Create();
            // Initialize request argument(s)
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                Resource = new DatabaseName("[PROJECT]", "[INSTANCE]", "[DATABASE]").ToString(),
                Policy = new Policy(),
            };
            // Make the request
            Policy response = databaseAdminClient.SetIamPolicy(request);
            // End snippet
        }

        public async Task GetIamPolicyAsync()
        {
            // Snippet: GetIamPolicyAsync(string,CallSettings)
            // Additional: GetIamPolicyAsync(string,CancellationToken)
            // Create client
            DatabaseAdminClient databaseAdminClient = await DatabaseAdminClient.CreateAsync();
            // Initialize request argument(s)
            string formattedResource = new DatabaseName("[PROJECT]", "[INSTANCE]", "[DATABASE]").ToString();
            // Make the request
            Policy response = await databaseAdminClient.GetIamPolicyAsync(formattedResource);
            // End snippet
        }

        public void GetIamPolicy()
        {
            // Snippet: GetIamPolicy(string,CallSettings)
            // Create client
            DatabaseAdminClient databaseAdminClient = DatabaseAdminClient.Create();
            // Initialize request argument(s)
            string formattedResource = new DatabaseName("[PROJECT]", "[INSTANCE]", "[DATABASE]").ToString();
            // Make the request
            Policy response = databaseAdminClient.GetIamPolicy(formattedResource);
            // End snippet
        }

        public async Task GetIamPolicyAsync_RequestObject()
        {
            // Snippet: GetIamPolicyAsync(GetIamPolicyRequest,CallSettings)
            // Create client
            DatabaseAdminClient databaseAdminClient = await DatabaseAdminClient.CreateAsync();
            // Initialize request argument(s)
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                Resource = new DatabaseName("[PROJECT]", "[INSTANCE]", "[DATABASE]").ToString(),
            };
            // Make the request
            Policy response = await databaseAdminClient.GetIamPolicyAsync(request);
            // End snippet
        }

        public void GetIamPolicy_RequestObject()
        {
            // Snippet: GetIamPolicy(GetIamPolicyRequest,CallSettings)
            // Create client
            DatabaseAdminClient databaseAdminClient = DatabaseAdminClient.Create();
            // Initialize request argument(s)
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                Resource = new DatabaseName("[PROJECT]", "[INSTANCE]", "[DATABASE]").ToString(),
            };
            // Make the request
            Policy response = databaseAdminClient.GetIamPolicy(request);
            // End snippet
        }

        public async Task TestIamPermissionsAsync()
        {
            // Snippet: TestIamPermissionsAsync(string,IEnumerable<string>,CallSettings)
            // Additional: TestIamPermissionsAsync(string,IEnumerable<string>,CancellationToken)
            // Create client
            DatabaseAdminClient databaseAdminClient = await DatabaseAdminClient.CreateAsync();
            // Initialize request argument(s)
            string formattedResource = new DatabaseName("[PROJECT]", "[INSTANCE]", "[DATABASE]").ToString();
            IEnumerable<string> permissions = new List<string>();
            // Make the request
            TestIamPermissionsResponse response = await databaseAdminClient.TestIamPermissionsAsync(formattedResource, permissions);
            // End snippet
        }

        public void TestIamPermissions()
        {
            // Snippet: TestIamPermissions(string,IEnumerable<string>,CallSettings)
            // Create client
            DatabaseAdminClient databaseAdminClient = DatabaseAdminClient.Create();
            // Initialize request argument(s)
            string formattedResource = new DatabaseName("[PROJECT]", "[INSTANCE]", "[DATABASE]").ToString();
            IEnumerable<string> permissions = new List<string>();
            // Make the request
            TestIamPermissionsResponse response = databaseAdminClient.TestIamPermissions(formattedResource, permissions);
            // End snippet
        }

        public async Task TestIamPermissionsAsync_RequestObject()
        {
            // Snippet: TestIamPermissionsAsync(TestIamPermissionsRequest,CallSettings)
            // Create client
            DatabaseAdminClient databaseAdminClient = await DatabaseAdminClient.CreateAsync();
            // Initialize request argument(s)
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                Resource = new DatabaseName("[PROJECT]", "[INSTANCE]", "[DATABASE]").ToString(),
                Permissions = { },
            };
            // Make the request
            TestIamPermissionsResponse response = await databaseAdminClient.TestIamPermissionsAsync(request);
            // End snippet
        }

        public void TestIamPermissions_RequestObject()
        {
            // Snippet: TestIamPermissions(TestIamPermissionsRequest,CallSettings)
            // Create client
            DatabaseAdminClient databaseAdminClient = DatabaseAdminClient.Create();
            // Initialize request argument(s)
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                Resource = new DatabaseName("[PROJECT]", "[INSTANCE]", "[DATABASE]").ToString(),
                Permissions = { },
            };
            // Make the request
            TestIamPermissionsResponse response = databaseAdminClient.TestIamPermissions(request);
            // End snippet
        }

    }
}
