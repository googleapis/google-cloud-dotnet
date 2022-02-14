// Copyright 2022 Google LLC
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

namespace Google.Cloud.Gaming.V1.Snippets
{
    using Google.Api.Gax;
    using Google.Api.Gax.ResourceNames;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedRealmsServiceClientSnippets
    {
        /// <summary>Snippet for ListRealms</summary>
        public void ListRealmsRequestObject()
        {
            // Snippet: ListRealms(ListRealmsRequest, CallSettings)
            // Create client
            RealmsServiceClient realmsServiceClient = RealmsServiceClient.Create();
            // Initialize request argument(s)
            ListRealmsRequest request = new ListRealmsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListRealmsResponse, Realm> response = realmsServiceClient.ListRealms(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Realm item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRealmsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Realm item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Realm> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Realm item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRealmsAsync</summary>
        public async Task ListRealmsRequestObjectAsync()
        {
            // Snippet: ListRealmsAsync(ListRealmsRequest, CallSettings)
            // Create client
            RealmsServiceClient realmsServiceClient = await RealmsServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListRealmsRequest request = new ListRealmsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListRealmsResponse, Realm> response = realmsServiceClient.ListRealmsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Realm item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListRealmsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Realm item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Realm> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Realm item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRealms</summary>
        public void ListRealms()
        {
            // Snippet: ListRealms(string, string, int?, CallSettings)
            // Create client
            RealmsServiceClient realmsServiceClient = RealmsServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListRealmsResponse, Realm> response = realmsServiceClient.ListRealms(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Realm item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRealmsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Realm item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Realm> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Realm item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRealmsAsync</summary>
        public async Task ListRealmsAsync()
        {
            // Snippet: ListRealmsAsync(string, string, int?, CallSettings)
            // Create client
            RealmsServiceClient realmsServiceClient = await RealmsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListRealmsResponse, Realm> response = realmsServiceClient.ListRealmsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Realm item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListRealmsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Realm item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Realm> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Realm item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRealms</summary>
        public void ListRealmsResourceNames()
        {
            // Snippet: ListRealms(LocationName, string, int?, CallSettings)
            // Create client
            RealmsServiceClient realmsServiceClient = RealmsServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListRealmsResponse, Realm> response = realmsServiceClient.ListRealms(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Realm item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRealmsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Realm item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Realm> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Realm item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRealmsAsync</summary>
        public async Task ListRealmsResourceNamesAsync()
        {
            // Snippet: ListRealmsAsync(LocationName, string, int?, CallSettings)
            // Create client
            RealmsServiceClient realmsServiceClient = await RealmsServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListRealmsResponse, Realm> response = realmsServiceClient.ListRealmsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Realm item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListRealmsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Realm item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Realm> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Realm item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetRealm</summary>
        public void GetRealmRequestObject()
        {
            // Snippet: GetRealm(GetRealmRequest, CallSettings)
            // Create client
            RealmsServiceClient realmsServiceClient = RealmsServiceClient.Create();
            // Initialize request argument(s)
            GetRealmRequest request = new GetRealmRequest
            {
                RealmName = RealmName.FromProjectLocationRealm("[PROJECT]", "[LOCATION]", "[REALM]"),
            };
            // Make the request
            Realm response = realmsServiceClient.GetRealm(request);
            // End snippet
        }

        /// <summary>Snippet for GetRealmAsync</summary>
        public async Task GetRealmRequestObjectAsync()
        {
            // Snippet: GetRealmAsync(GetRealmRequest, CallSettings)
            // Additional: GetRealmAsync(GetRealmRequest, CancellationToken)
            // Create client
            RealmsServiceClient realmsServiceClient = await RealmsServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetRealmRequest request = new GetRealmRequest
            {
                RealmName = RealmName.FromProjectLocationRealm("[PROJECT]", "[LOCATION]", "[REALM]"),
            };
            // Make the request
            Realm response = await realmsServiceClient.GetRealmAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetRealm</summary>
        public void GetRealm()
        {
            // Snippet: GetRealm(string, CallSettings)
            // Create client
            RealmsServiceClient realmsServiceClient = RealmsServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/realms/[REALM]";
            // Make the request
            Realm response = realmsServiceClient.GetRealm(name);
            // End snippet
        }

        /// <summary>Snippet for GetRealmAsync</summary>
        public async Task GetRealmAsync()
        {
            // Snippet: GetRealmAsync(string, CallSettings)
            // Additional: GetRealmAsync(string, CancellationToken)
            // Create client
            RealmsServiceClient realmsServiceClient = await RealmsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/realms/[REALM]";
            // Make the request
            Realm response = await realmsServiceClient.GetRealmAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetRealm</summary>
        public void GetRealmResourceNames()
        {
            // Snippet: GetRealm(RealmName, CallSettings)
            // Create client
            RealmsServiceClient realmsServiceClient = RealmsServiceClient.Create();
            // Initialize request argument(s)
            RealmName name = RealmName.FromProjectLocationRealm("[PROJECT]", "[LOCATION]", "[REALM]");
            // Make the request
            Realm response = realmsServiceClient.GetRealm(name);
            // End snippet
        }

        /// <summary>Snippet for GetRealmAsync</summary>
        public async Task GetRealmResourceNamesAsync()
        {
            // Snippet: GetRealmAsync(RealmName, CallSettings)
            // Additional: GetRealmAsync(RealmName, CancellationToken)
            // Create client
            RealmsServiceClient realmsServiceClient = await RealmsServiceClient.CreateAsync();
            // Initialize request argument(s)
            RealmName name = RealmName.FromProjectLocationRealm("[PROJECT]", "[LOCATION]", "[REALM]");
            // Make the request
            Realm response = await realmsServiceClient.GetRealmAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateRealm</summary>
        public void CreateRealmRequestObject()
        {
            // Snippet: CreateRealm(CreateRealmRequest, CallSettings)
            // Create client
            RealmsServiceClient realmsServiceClient = RealmsServiceClient.Create();
            // Initialize request argument(s)
            CreateRealmRequest request = new CreateRealmRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                RealmId = "",
                Realm = new Realm(),
            };
            // Make the request
            Operation<Realm, OperationMetadata> response = realmsServiceClient.CreateRealm(request);

            // Poll until the returned long-running operation is complete
            Operation<Realm, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Realm result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Realm, OperationMetadata> retrievedResponse = realmsServiceClient.PollOnceCreateRealm(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Realm retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateRealmAsync</summary>
        public async Task CreateRealmRequestObjectAsync()
        {
            // Snippet: CreateRealmAsync(CreateRealmRequest, CallSettings)
            // Additional: CreateRealmAsync(CreateRealmRequest, CancellationToken)
            // Create client
            RealmsServiceClient realmsServiceClient = await RealmsServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateRealmRequest request = new CreateRealmRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                RealmId = "",
                Realm = new Realm(),
            };
            // Make the request
            Operation<Realm, OperationMetadata> response = await realmsServiceClient.CreateRealmAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Realm, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Realm result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Realm, OperationMetadata> retrievedResponse = await realmsServiceClient.PollOnceCreateRealmAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Realm retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateRealm</summary>
        public void CreateRealm()
        {
            // Snippet: CreateRealm(string, Realm, string, CallSettings)
            // Create client
            RealmsServiceClient realmsServiceClient = RealmsServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Realm realm = new Realm();
            string realmId = "";
            // Make the request
            Operation<Realm, OperationMetadata> response = realmsServiceClient.CreateRealm(parent, realm, realmId);

            // Poll until the returned long-running operation is complete
            Operation<Realm, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Realm result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Realm, OperationMetadata> retrievedResponse = realmsServiceClient.PollOnceCreateRealm(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Realm retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateRealmAsync</summary>
        public async Task CreateRealmAsync()
        {
            // Snippet: CreateRealmAsync(string, Realm, string, CallSettings)
            // Additional: CreateRealmAsync(string, Realm, string, CancellationToken)
            // Create client
            RealmsServiceClient realmsServiceClient = await RealmsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Realm realm = new Realm();
            string realmId = "";
            // Make the request
            Operation<Realm, OperationMetadata> response = await realmsServiceClient.CreateRealmAsync(parent, realm, realmId);

            // Poll until the returned long-running operation is complete
            Operation<Realm, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Realm result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Realm, OperationMetadata> retrievedResponse = await realmsServiceClient.PollOnceCreateRealmAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Realm retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateRealm</summary>
        public void CreateRealmResourceNames()
        {
            // Snippet: CreateRealm(LocationName, Realm, string, CallSettings)
            // Create client
            RealmsServiceClient realmsServiceClient = RealmsServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Realm realm = new Realm();
            string realmId = "";
            // Make the request
            Operation<Realm, OperationMetadata> response = realmsServiceClient.CreateRealm(parent, realm, realmId);

            // Poll until the returned long-running operation is complete
            Operation<Realm, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Realm result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Realm, OperationMetadata> retrievedResponse = realmsServiceClient.PollOnceCreateRealm(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Realm retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateRealmAsync</summary>
        public async Task CreateRealmResourceNamesAsync()
        {
            // Snippet: CreateRealmAsync(LocationName, Realm, string, CallSettings)
            // Additional: CreateRealmAsync(LocationName, Realm, string, CancellationToken)
            // Create client
            RealmsServiceClient realmsServiceClient = await RealmsServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Realm realm = new Realm();
            string realmId = "";
            // Make the request
            Operation<Realm, OperationMetadata> response = await realmsServiceClient.CreateRealmAsync(parent, realm, realmId);

            // Poll until the returned long-running operation is complete
            Operation<Realm, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Realm result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Realm, OperationMetadata> retrievedResponse = await realmsServiceClient.PollOnceCreateRealmAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Realm retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteRealm</summary>
        public void DeleteRealmRequestObject()
        {
            // Snippet: DeleteRealm(DeleteRealmRequest, CallSettings)
            // Create client
            RealmsServiceClient realmsServiceClient = RealmsServiceClient.Create();
            // Initialize request argument(s)
            DeleteRealmRequest request = new DeleteRealmRequest
            {
                RealmName = RealmName.FromProjectLocationRealm("[PROJECT]", "[LOCATION]", "[REALM]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = realmsServiceClient.DeleteRealm(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = realmsServiceClient.PollOnceDeleteRealm(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteRealmAsync</summary>
        public async Task DeleteRealmRequestObjectAsync()
        {
            // Snippet: DeleteRealmAsync(DeleteRealmRequest, CallSettings)
            // Additional: DeleteRealmAsync(DeleteRealmRequest, CancellationToken)
            // Create client
            RealmsServiceClient realmsServiceClient = await RealmsServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteRealmRequest request = new DeleteRealmRequest
            {
                RealmName = RealmName.FromProjectLocationRealm("[PROJECT]", "[LOCATION]", "[REALM]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await realmsServiceClient.DeleteRealmAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await realmsServiceClient.PollOnceDeleteRealmAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteRealm</summary>
        public void DeleteRealm()
        {
            // Snippet: DeleteRealm(string, CallSettings)
            // Create client
            RealmsServiceClient realmsServiceClient = RealmsServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/realms/[REALM]";
            // Make the request
            Operation<Empty, OperationMetadata> response = realmsServiceClient.DeleteRealm(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = realmsServiceClient.PollOnceDeleteRealm(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteRealmAsync</summary>
        public async Task DeleteRealmAsync()
        {
            // Snippet: DeleteRealmAsync(string, CallSettings)
            // Additional: DeleteRealmAsync(string, CancellationToken)
            // Create client
            RealmsServiceClient realmsServiceClient = await RealmsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/realms/[REALM]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await realmsServiceClient.DeleteRealmAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await realmsServiceClient.PollOnceDeleteRealmAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteRealm</summary>
        public void DeleteRealmResourceNames()
        {
            // Snippet: DeleteRealm(RealmName, CallSettings)
            // Create client
            RealmsServiceClient realmsServiceClient = RealmsServiceClient.Create();
            // Initialize request argument(s)
            RealmName name = RealmName.FromProjectLocationRealm("[PROJECT]", "[LOCATION]", "[REALM]");
            // Make the request
            Operation<Empty, OperationMetadata> response = realmsServiceClient.DeleteRealm(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = realmsServiceClient.PollOnceDeleteRealm(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteRealmAsync</summary>
        public async Task DeleteRealmResourceNamesAsync()
        {
            // Snippet: DeleteRealmAsync(RealmName, CallSettings)
            // Additional: DeleteRealmAsync(RealmName, CancellationToken)
            // Create client
            RealmsServiceClient realmsServiceClient = await RealmsServiceClient.CreateAsync();
            // Initialize request argument(s)
            RealmName name = RealmName.FromProjectLocationRealm("[PROJECT]", "[LOCATION]", "[REALM]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await realmsServiceClient.DeleteRealmAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await realmsServiceClient.PollOnceDeleteRealmAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateRealm</summary>
        public void UpdateRealmRequestObject()
        {
            // Snippet: UpdateRealm(UpdateRealmRequest, CallSettings)
            // Create client
            RealmsServiceClient realmsServiceClient = RealmsServiceClient.Create();
            // Initialize request argument(s)
            UpdateRealmRequest request = new UpdateRealmRequest
            {
                Realm = new Realm(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<Realm, OperationMetadata> response = realmsServiceClient.UpdateRealm(request);

            // Poll until the returned long-running operation is complete
            Operation<Realm, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Realm result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Realm, OperationMetadata> retrievedResponse = realmsServiceClient.PollOnceUpdateRealm(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Realm retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateRealmAsync</summary>
        public async Task UpdateRealmRequestObjectAsync()
        {
            // Snippet: UpdateRealmAsync(UpdateRealmRequest, CallSettings)
            // Additional: UpdateRealmAsync(UpdateRealmRequest, CancellationToken)
            // Create client
            RealmsServiceClient realmsServiceClient = await RealmsServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateRealmRequest request = new UpdateRealmRequest
            {
                Realm = new Realm(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<Realm, OperationMetadata> response = await realmsServiceClient.UpdateRealmAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Realm, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Realm result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Realm, OperationMetadata> retrievedResponse = await realmsServiceClient.PollOnceUpdateRealmAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Realm retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateRealm</summary>
        public void UpdateRealm()
        {
            // Snippet: UpdateRealm(Realm, FieldMask, CallSettings)
            // Create client
            RealmsServiceClient realmsServiceClient = RealmsServiceClient.Create();
            // Initialize request argument(s)
            Realm realm = new Realm();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Realm, OperationMetadata> response = realmsServiceClient.UpdateRealm(realm, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Realm, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Realm result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Realm, OperationMetadata> retrievedResponse = realmsServiceClient.PollOnceUpdateRealm(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Realm retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateRealmAsync</summary>
        public async Task UpdateRealmAsync()
        {
            // Snippet: UpdateRealmAsync(Realm, FieldMask, CallSettings)
            // Additional: UpdateRealmAsync(Realm, FieldMask, CancellationToken)
            // Create client
            RealmsServiceClient realmsServiceClient = await RealmsServiceClient.CreateAsync();
            // Initialize request argument(s)
            Realm realm = new Realm();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Realm, OperationMetadata> response = await realmsServiceClient.UpdateRealmAsync(realm, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Realm, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Realm result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Realm, OperationMetadata> retrievedResponse = await realmsServiceClient.PollOnceUpdateRealmAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Realm retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PreviewRealmUpdate</summary>
        public void PreviewRealmUpdateRequestObject()
        {
            // Snippet: PreviewRealmUpdate(PreviewRealmUpdateRequest, CallSettings)
            // Create client
            RealmsServiceClient realmsServiceClient = RealmsServiceClient.Create();
            // Initialize request argument(s)
            PreviewRealmUpdateRequest request = new PreviewRealmUpdateRequest
            {
                Realm = new Realm(),
                UpdateMask = new FieldMask(),
                PreviewTime = new Timestamp(),
            };
            // Make the request
            PreviewRealmUpdateResponse response = realmsServiceClient.PreviewRealmUpdate(request);
            // End snippet
        }

        /// <summary>Snippet for PreviewRealmUpdateAsync</summary>
        public async Task PreviewRealmUpdateRequestObjectAsync()
        {
            // Snippet: PreviewRealmUpdateAsync(PreviewRealmUpdateRequest, CallSettings)
            // Additional: PreviewRealmUpdateAsync(PreviewRealmUpdateRequest, CancellationToken)
            // Create client
            RealmsServiceClient realmsServiceClient = await RealmsServiceClient.CreateAsync();
            // Initialize request argument(s)
            PreviewRealmUpdateRequest request = new PreviewRealmUpdateRequest
            {
                Realm = new Realm(),
                UpdateMask = new FieldMask(),
                PreviewTime = new Timestamp(),
            };
            // Make the request
            PreviewRealmUpdateResponse response = await realmsServiceClient.PreviewRealmUpdateAsync(request);
            // End snippet
        }
    }
}
