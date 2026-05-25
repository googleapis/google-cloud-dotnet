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
    using Google.Cloud.NetworkSecurity.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedSSERealmServiceClientSnippets
    {
        /// <summary>Snippet for ListSACRealms</summary>
        public void ListSACRealmsRequestObject()
        {
            // Snippet: ListSACRealms(ListSACRealmsRequest, CallSettings)
            // Create client
            SSERealmServiceClient sSERealmServiceClient = SSERealmServiceClient.Create();
            // Initialize request argument(s)
            ListSACRealmsRequest request = new ListSACRealmsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListSACRealmsResponse, SACRealm> response = sSERealmServiceClient.ListSACRealms(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SACRealm item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSACRealmsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SACRealm item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SACRealm> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SACRealm item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSACRealmsAsync</summary>
        public async Task ListSACRealmsRequestObjectAsync()
        {
            // Snippet: ListSACRealmsAsync(ListSACRealmsRequest, CallSettings)
            // Create client
            SSERealmServiceClient sSERealmServiceClient = await SSERealmServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListSACRealmsRequest request = new ListSACRealmsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListSACRealmsResponse, SACRealm> response = sSERealmServiceClient.ListSACRealmsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (SACRealm item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListSACRealmsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SACRealm item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SACRealm> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SACRealm item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSACRealms</summary>
        public void ListSACRealms()
        {
            // Snippet: ListSACRealms(string, string, int?, CallSettings)
            // Create client
            SSERealmServiceClient sSERealmServiceClient = SSERealmServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListSACRealmsResponse, SACRealm> response = sSERealmServiceClient.ListSACRealms(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SACRealm item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSACRealmsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SACRealm item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SACRealm> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SACRealm item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSACRealmsAsync</summary>
        public async Task ListSACRealmsAsync()
        {
            // Snippet: ListSACRealmsAsync(string, string, int?, CallSettings)
            // Create client
            SSERealmServiceClient sSERealmServiceClient = await SSERealmServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListSACRealmsResponse, SACRealm> response = sSERealmServiceClient.ListSACRealmsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (SACRealm item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListSACRealmsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SACRealm item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SACRealm> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SACRealm item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSACRealms</summary>
        public void ListSACRealmsResourceNames()
        {
            // Snippet: ListSACRealms(LocationName, string, int?, CallSettings)
            // Create client
            SSERealmServiceClient sSERealmServiceClient = SSERealmServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListSACRealmsResponse, SACRealm> response = sSERealmServiceClient.ListSACRealms(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SACRealm item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSACRealmsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SACRealm item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SACRealm> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SACRealm item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSACRealmsAsync</summary>
        public async Task ListSACRealmsResourceNamesAsync()
        {
            // Snippet: ListSACRealmsAsync(LocationName, string, int?, CallSettings)
            // Create client
            SSERealmServiceClient sSERealmServiceClient = await SSERealmServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListSACRealmsResponse, SACRealm> response = sSERealmServiceClient.ListSACRealmsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (SACRealm item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListSACRealmsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SACRealm item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SACRealm> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SACRealm item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetSACRealm</summary>
        public void GetSACRealmRequestObject()
        {
            // Snippet: GetSACRealm(GetSACRealmRequest, CallSettings)
            // Create client
            SSERealmServiceClient sSERealmServiceClient = SSERealmServiceClient.Create();
            // Initialize request argument(s)
            GetSACRealmRequest request = new GetSACRealmRequest
            {
                SACRealmName = SACRealmName.FromProjectLocationSacRealm("[PROJECT]", "[LOCATION]", "[SAC_REALM]"),
            };
            // Make the request
            SACRealm response = sSERealmServiceClient.GetSACRealm(request);
            // End snippet
        }

        /// <summary>Snippet for GetSACRealmAsync</summary>
        public async Task GetSACRealmRequestObjectAsync()
        {
            // Snippet: GetSACRealmAsync(GetSACRealmRequest, CallSettings)
            // Additional: GetSACRealmAsync(GetSACRealmRequest, CancellationToken)
            // Create client
            SSERealmServiceClient sSERealmServiceClient = await SSERealmServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetSACRealmRequest request = new GetSACRealmRequest
            {
                SACRealmName = SACRealmName.FromProjectLocationSacRealm("[PROJECT]", "[LOCATION]", "[SAC_REALM]"),
            };
            // Make the request
            SACRealm response = await sSERealmServiceClient.GetSACRealmAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetSACRealm</summary>
        public void GetSACRealm()
        {
            // Snippet: GetSACRealm(string, CallSettings)
            // Create client
            SSERealmServiceClient sSERealmServiceClient = SSERealmServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/sacRealms/[SAC_REALM]";
            // Make the request
            SACRealm response = sSERealmServiceClient.GetSACRealm(name);
            // End snippet
        }

        /// <summary>Snippet for GetSACRealmAsync</summary>
        public async Task GetSACRealmAsync()
        {
            // Snippet: GetSACRealmAsync(string, CallSettings)
            // Additional: GetSACRealmAsync(string, CancellationToken)
            // Create client
            SSERealmServiceClient sSERealmServiceClient = await SSERealmServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/sacRealms/[SAC_REALM]";
            // Make the request
            SACRealm response = await sSERealmServiceClient.GetSACRealmAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetSACRealm</summary>
        public void GetSACRealmResourceNames()
        {
            // Snippet: GetSACRealm(SACRealmName, CallSettings)
            // Create client
            SSERealmServiceClient sSERealmServiceClient = SSERealmServiceClient.Create();
            // Initialize request argument(s)
            SACRealmName name = SACRealmName.FromProjectLocationSacRealm("[PROJECT]", "[LOCATION]", "[SAC_REALM]");
            // Make the request
            SACRealm response = sSERealmServiceClient.GetSACRealm(name);
            // End snippet
        }

        /// <summary>Snippet for GetSACRealmAsync</summary>
        public async Task GetSACRealmResourceNamesAsync()
        {
            // Snippet: GetSACRealmAsync(SACRealmName, CallSettings)
            // Additional: GetSACRealmAsync(SACRealmName, CancellationToken)
            // Create client
            SSERealmServiceClient sSERealmServiceClient = await SSERealmServiceClient.CreateAsync();
            // Initialize request argument(s)
            SACRealmName name = SACRealmName.FromProjectLocationSacRealm("[PROJECT]", "[LOCATION]", "[SAC_REALM]");
            // Make the request
            SACRealm response = await sSERealmServiceClient.GetSACRealmAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateSACRealm</summary>
        public void CreateSACRealmRequestObject()
        {
            // Snippet: CreateSACRealm(CreateSACRealmRequest, CallSettings)
            // Create client
            SSERealmServiceClient sSERealmServiceClient = SSERealmServiceClient.Create();
            // Initialize request argument(s)
            CreateSACRealmRequest request = new CreateSACRealmRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                SacRealmId = "",
                SacRealm = new SACRealm(),
                RequestId = "",
            };
            // Make the request
            Operation<SACRealm, OperationMetadata> response = sSERealmServiceClient.CreateSACRealm(request);

            // Poll until the returned long-running operation is complete
            Operation<SACRealm, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            SACRealm result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<SACRealm, OperationMetadata> retrievedResponse = sSERealmServiceClient.PollOnceCreateSACRealm(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                SACRealm retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSACRealmAsync</summary>
        public async Task CreateSACRealmRequestObjectAsync()
        {
            // Snippet: CreateSACRealmAsync(CreateSACRealmRequest, CallSettings)
            // Additional: CreateSACRealmAsync(CreateSACRealmRequest, CancellationToken)
            // Create client
            SSERealmServiceClient sSERealmServiceClient = await SSERealmServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateSACRealmRequest request = new CreateSACRealmRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                SacRealmId = "",
                SacRealm = new SACRealm(),
                RequestId = "",
            };
            // Make the request
            Operation<SACRealm, OperationMetadata> response = await sSERealmServiceClient.CreateSACRealmAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<SACRealm, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            SACRealm result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<SACRealm, OperationMetadata> retrievedResponse = await sSERealmServiceClient.PollOnceCreateSACRealmAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                SACRealm retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSACRealm</summary>
        public void CreateSACRealm()
        {
            // Snippet: CreateSACRealm(string, SACRealm, string, CallSettings)
            // Create client
            SSERealmServiceClient sSERealmServiceClient = SSERealmServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            SACRealm sacRealm = new SACRealm();
            string sacRealmId = "";
            // Make the request
            Operation<SACRealm, OperationMetadata> response = sSERealmServiceClient.CreateSACRealm(parent, sacRealm, sacRealmId);

            // Poll until the returned long-running operation is complete
            Operation<SACRealm, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            SACRealm result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<SACRealm, OperationMetadata> retrievedResponse = sSERealmServiceClient.PollOnceCreateSACRealm(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                SACRealm retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSACRealmAsync</summary>
        public async Task CreateSACRealmAsync()
        {
            // Snippet: CreateSACRealmAsync(string, SACRealm, string, CallSettings)
            // Additional: CreateSACRealmAsync(string, SACRealm, string, CancellationToken)
            // Create client
            SSERealmServiceClient sSERealmServiceClient = await SSERealmServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            SACRealm sacRealm = new SACRealm();
            string sacRealmId = "";
            // Make the request
            Operation<SACRealm, OperationMetadata> response = await sSERealmServiceClient.CreateSACRealmAsync(parent, sacRealm, sacRealmId);

            // Poll until the returned long-running operation is complete
            Operation<SACRealm, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            SACRealm result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<SACRealm, OperationMetadata> retrievedResponse = await sSERealmServiceClient.PollOnceCreateSACRealmAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                SACRealm retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSACRealm</summary>
        public void CreateSACRealmResourceNames()
        {
            // Snippet: CreateSACRealm(LocationName, SACRealm, string, CallSettings)
            // Create client
            SSERealmServiceClient sSERealmServiceClient = SSERealmServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            SACRealm sacRealm = new SACRealm();
            string sacRealmId = "";
            // Make the request
            Operation<SACRealm, OperationMetadata> response = sSERealmServiceClient.CreateSACRealm(parent, sacRealm, sacRealmId);

            // Poll until the returned long-running operation is complete
            Operation<SACRealm, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            SACRealm result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<SACRealm, OperationMetadata> retrievedResponse = sSERealmServiceClient.PollOnceCreateSACRealm(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                SACRealm retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSACRealmAsync</summary>
        public async Task CreateSACRealmResourceNamesAsync()
        {
            // Snippet: CreateSACRealmAsync(LocationName, SACRealm, string, CallSettings)
            // Additional: CreateSACRealmAsync(LocationName, SACRealm, string, CancellationToken)
            // Create client
            SSERealmServiceClient sSERealmServiceClient = await SSERealmServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            SACRealm sacRealm = new SACRealm();
            string sacRealmId = "";
            // Make the request
            Operation<SACRealm, OperationMetadata> response = await sSERealmServiceClient.CreateSACRealmAsync(parent, sacRealm, sacRealmId);

            // Poll until the returned long-running operation is complete
            Operation<SACRealm, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            SACRealm result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<SACRealm, OperationMetadata> retrievedResponse = await sSERealmServiceClient.PollOnceCreateSACRealmAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                SACRealm retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSACRealm</summary>
        public void DeleteSACRealmRequestObject()
        {
            // Snippet: DeleteSACRealm(DeleteSACRealmRequest, CallSettings)
            // Create client
            SSERealmServiceClient sSERealmServiceClient = SSERealmServiceClient.Create();
            // Initialize request argument(s)
            DeleteSACRealmRequest request = new DeleteSACRealmRequest
            {
                SACRealmName = SACRealmName.FromProjectLocationSacRealm("[PROJECT]", "[LOCATION]", "[SAC_REALM]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = sSERealmServiceClient.DeleteSACRealm(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = sSERealmServiceClient.PollOnceDeleteSACRealm(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSACRealmAsync</summary>
        public async Task DeleteSACRealmRequestObjectAsync()
        {
            // Snippet: DeleteSACRealmAsync(DeleteSACRealmRequest, CallSettings)
            // Additional: DeleteSACRealmAsync(DeleteSACRealmRequest, CancellationToken)
            // Create client
            SSERealmServiceClient sSERealmServiceClient = await SSERealmServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteSACRealmRequest request = new DeleteSACRealmRequest
            {
                SACRealmName = SACRealmName.FromProjectLocationSacRealm("[PROJECT]", "[LOCATION]", "[SAC_REALM]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await sSERealmServiceClient.DeleteSACRealmAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await sSERealmServiceClient.PollOnceDeleteSACRealmAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSACRealm</summary>
        public void DeleteSACRealm()
        {
            // Snippet: DeleteSACRealm(string, CallSettings)
            // Create client
            SSERealmServiceClient sSERealmServiceClient = SSERealmServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/sacRealms/[SAC_REALM]";
            // Make the request
            Operation<Empty, OperationMetadata> response = sSERealmServiceClient.DeleteSACRealm(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = sSERealmServiceClient.PollOnceDeleteSACRealm(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSACRealmAsync</summary>
        public async Task DeleteSACRealmAsync()
        {
            // Snippet: DeleteSACRealmAsync(string, CallSettings)
            // Additional: DeleteSACRealmAsync(string, CancellationToken)
            // Create client
            SSERealmServiceClient sSERealmServiceClient = await SSERealmServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/sacRealms/[SAC_REALM]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await sSERealmServiceClient.DeleteSACRealmAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await sSERealmServiceClient.PollOnceDeleteSACRealmAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSACRealm</summary>
        public void DeleteSACRealmResourceNames()
        {
            // Snippet: DeleteSACRealm(SACRealmName, CallSettings)
            // Create client
            SSERealmServiceClient sSERealmServiceClient = SSERealmServiceClient.Create();
            // Initialize request argument(s)
            SACRealmName name = SACRealmName.FromProjectLocationSacRealm("[PROJECT]", "[LOCATION]", "[SAC_REALM]");
            // Make the request
            Operation<Empty, OperationMetadata> response = sSERealmServiceClient.DeleteSACRealm(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = sSERealmServiceClient.PollOnceDeleteSACRealm(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSACRealmAsync</summary>
        public async Task DeleteSACRealmResourceNamesAsync()
        {
            // Snippet: DeleteSACRealmAsync(SACRealmName, CallSettings)
            // Additional: DeleteSACRealmAsync(SACRealmName, CancellationToken)
            // Create client
            SSERealmServiceClient sSERealmServiceClient = await SSERealmServiceClient.CreateAsync();
            // Initialize request argument(s)
            SACRealmName name = SACRealmName.FromProjectLocationSacRealm("[PROJECT]", "[LOCATION]", "[SAC_REALM]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await sSERealmServiceClient.DeleteSACRealmAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await sSERealmServiceClient.PollOnceDeleteSACRealmAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListSACAttachments</summary>
        public void ListSACAttachmentsRequestObject()
        {
            // Snippet: ListSACAttachments(ListSACAttachmentsRequest, CallSettings)
            // Create client
            SSERealmServiceClient sSERealmServiceClient = SSERealmServiceClient.Create();
            // Initialize request argument(s)
            ListSACAttachmentsRequest request = new ListSACAttachmentsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListSACAttachmentsResponse, SACAttachment> response = sSERealmServiceClient.ListSACAttachments(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SACAttachment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSACAttachmentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SACAttachment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SACAttachment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SACAttachment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSACAttachmentsAsync</summary>
        public async Task ListSACAttachmentsRequestObjectAsync()
        {
            // Snippet: ListSACAttachmentsAsync(ListSACAttachmentsRequest, CallSettings)
            // Create client
            SSERealmServiceClient sSERealmServiceClient = await SSERealmServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListSACAttachmentsRequest request = new ListSACAttachmentsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListSACAttachmentsResponse, SACAttachment> response = sSERealmServiceClient.ListSACAttachmentsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (SACAttachment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListSACAttachmentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SACAttachment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SACAttachment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SACAttachment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSACAttachments</summary>
        public void ListSACAttachments()
        {
            // Snippet: ListSACAttachments(string, string, int?, CallSettings)
            // Create client
            SSERealmServiceClient sSERealmServiceClient = SSERealmServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListSACAttachmentsResponse, SACAttachment> response = sSERealmServiceClient.ListSACAttachments(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SACAttachment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSACAttachmentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SACAttachment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SACAttachment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SACAttachment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSACAttachmentsAsync</summary>
        public async Task ListSACAttachmentsAsync()
        {
            // Snippet: ListSACAttachmentsAsync(string, string, int?, CallSettings)
            // Create client
            SSERealmServiceClient sSERealmServiceClient = await SSERealmServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListSACAttachmentsResponse, SACAttachment> response = sSERealmServiceClient.ListSACAttachmentsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (SACAttachment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListSACAttachmentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SACAttachment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SACAttachment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SACAttachment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSACAttachments</summary>
        public void ListSACAttachmentsResourceNames()
        {
            // Snippet: ListSACAttachments(LocationName, string, int?, CallSettings)
            // Create client
            SSERealmServiceClient sSERealmServiceClient = SSERealmServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListSACAttachmentsResponse, SACAttachment> response = sSERealmServiceClient.ListSACAttachments(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SACAttachment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSACAttachmentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SACAttachment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SACAttachment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SACAttachment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSACAttachmentsAsync</summary>
        public async Task ListSACAttachmentsResourceNamesAsync()
        {
            // Snippet: ListSACAttachmentsAsync(LocationName, string, int?, CallSettings)
            // Create client
            SSERealmServiceClient sSERealmServiceClient = await SSERealmServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListSACAttachmentsResponse, SACAttachment> response = sSERealmServiceClient.ListSACAttachmentsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (SACAttachment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListSACAttachmentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SACAttachment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SACAttachment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SACAttachment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetSACAttachment</summary>
        public void GetSACAttachmentRequestObject()
        {
            // Snippet: GetSACAttachment(GetSACAttachmentRequest, CallSettings)
            // Create client
            SSERealmServiceClient sSERealmServiceClient = SSERealmServiceClient.Create();
            // Initialize request argument(s)
            GetSACAttachmentRequest request = new GetSACAttachmentRequest
            {
                SACAttachmentName = SACAttachmentName.FromProjectLocationSacAttachment("[PROJECT]", "[LOCATION]", "[SAC_ATTACHMENT]"),
            };
            // Make the request
            SACAttachment response = sSERealmServiceClient.GetSACAttachment(request);
            // End snippet
        }

        /// <summary>Snippet for GetSACAttachmentAsync</summary>
        public async Task GetSACAttachmentRequestObjectAsync()
        {
            // Snippet: GetSACAttachmentAsync(GetSACAttachmentRequest, CallSettings)
            // Additional: GetSACAttachmentAsync(GetSACAttachmentRequest, CancellationToken)
            // Create client
            SSERealmServiceClient sSERealmServiceClient = await SSERealmServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetSACAttachmentRequest request = new GetSACAttachmentRequest
            {
                SACAttachmentName = SACAttachmentName.FromProjectLocationSacAttachment("[PROJECT]", "[LOCATION]", "[SAC_ATTACHMENT]"),
            };
            // Make the request
            SACAttachment response = await sSERealmServiceClient.GetSACAttachmentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetSACAttachment</summary>
        public void GetSACAttachment()
        {
            // Snippet: GetSACAttachment(string, CallSettings)
            // Create client
            SSERealmServiceClient sSERealmServiceClient = SSERealmServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/sacAttachments/[SAC_ATTACHMENT]";
            // Make the request
            SACAttachment response = sSERealmServiceClient.GetSACAttachment(name);
            // End snippet
        }

        /// <summary>Snippet for GetSACAttachmentAsync</summary>
        public async Task GetSACAttachmentAsync()
        {
            // Snippet: GetSACAttachmentAsync(string, CallSettings)
            // Additional: GetSACAttachmentAsync(string, CancellationToken)
            // Create client
            SSERealmServiceClient sSERealmServiceClient = await SSERealmServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/sacAttachments/[SAC_ATTACHMENT]";
            // Make the request
            SACAttachment response = await sSERealmServiceClient.GetSACAttachmentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetSACAttachment</summary>
        public void GetSACAttachmentResourceNames()
        {
            // Snippet: GetSACAttachment(SACAttachmentName, CallSettings)
            // Create client
            SSERealmServiceClient sSERealmServiceClient = SSERealmServiceClient.Create();
            // Initialize request argument(s)
            SACAttachmentName name = SACAttachmentName.FromProjectLocationSacAttachment("[PROJECT]", "[LOCATION]", "[SAC_ATTACHMENT]");
            // Make the request
            SACAttachment response = sSERealmServiceClient.GetSACAttachment(name);
            // End snippet
        }

        /// <summary>Snippet for GetSACAttachmentAsync</summary>
        public async Task GetSACAttachmentResourceNamesAsync()
        {
            // Snippet: GetSACAttachmentAsync(SACAttachmentName, CallSettings)
            // Additional: GetSACAttachmentAsync(SACAttachmentName, CancellationToken)
            // Create client
            SSERealmServiceClient sSERealmServiceClient = await SSERealmServiceClient.CreateAsync();
            // Initialize request argument(s)
            SACAttachmentName name = SACAttachmentName.FromProjectLocationSacAttachment("[PROJECT]", "[LOCATION]", "[SAC_ATTACHMENT]");
            // Make the request
            SACAttachment response = await sSERealmServiceClient.GetSACAttachmentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateSACAttachment</summary>
        public void CreateSACAttachmentRequestObject()
        {
            // Snippet: CreateSACAttachment(CreateSACAttachmentRequest, CallSettings)
            // Create client
            SSERealmServiceClient sSERealmServiceClient = SSERealmServiceClient.Create();
            // Initialize request argument(s)
            CreateSACAttachmentRequest request = new CreateSACAttachmentRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                SacAttachmentId = "",
                SacAttachment = new SACAttachment(),
                RequestId = "",
            };
            // Make the request
            Operation<SACAttachment, OperationMetadata> response = sSERealmServiceClient.CreateSACAttachment(request);

            // Poll until the returned long-running operation is complete
            Operation<SACAttachment, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            SACAttachment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<SACAttachment, OperationMetadata> retrievedResponse = sSERealmServiceClient.PollOnceCreateSACAttachment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                SACAttachment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSACAttachmentAsync</summary>
        public async Task CreateSACAttachmentRequestObjectAsync()
        {
            // Snippet: CreateSACAttachmentAsync(CreateSACAttachmentRequest, CallSettings)
            // Additional: CreateSACAttachmentAsync(CreateSACAttachmentRequest, CancellationToken)
            // Create client
            SSERealmServiceClient sSERealmServiceClient = await SSERealmServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateSACAttachmentRequest request = new CreateSACAttachmentRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                SacAttachmentId = "",
                SacAttachment = new SACAttachment(),
                RequestId = "",
            };
            // Make the request
            Operation<SACAttachment, OperationMetadata> response = await sSERealmServiceClient.CreateSACAttachmentAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<SACAttachment, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            SACAttachment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<SACAttachment, OperationMetadata> retrievedResponse = await sSERealmServiceClient.PollOnceCreateSACAttachmentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                SACAttachment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSACAttachment</summary>
        public void CreateSACAttachment()
        {
            // Snippet: CreateSACAttachment(string, SACAttachment, string, CallSettings)
            // Create client
            SSERealmServiceClient sSERealmServiceClient = SSERealmServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            SACAttachment sacAttachment = new SACAttachment();
            string sacAttachmentId = "";
            // Make the request
            Operation<SACAttachment, OperationMetadata> response = sSERealmServiceClient.CreateSACAttachment(parent, sacAttachment, sacAttachmentId);

            // Poll until the returned long-running operation is complete
            Operation<SACAttachment, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            SACAttachment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<SACAttachment, OperationMetadata> retrievedResponse = sSERealmServiceClient.PollOnceCreateSACAttachment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                SACAttachment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSACAttachmentAsync</summary>
        public async Task CreateSACAttachmentAsync()
        {
            // Snippet: CreateSACAttachmentAsync(string, SACAttachment, string, CallSettings)
            // Additional: CreateSACAttachmentAsync(string, SACAttachment, string, CancellationToken)
            // Create client
            SSERealmServiceClient sSERealmServiceClient = await SSERealmServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            SACAttachment sacAttachment = new SACAttachment();
            string sacAttachmentId = "";
            // Make the request
            Operation<SACAttachment, OperationMetadata> response = await sSERealmServiceClient.CreateSACAttachmentAsync(parent, sacAttachment, sacAttachmentId);

            // Poll until the returned long-running operation is complete
            Operation<SACAttachment, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            SACAttachment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<SACAttachment, OperationMetadata> retrievedResponse = await sSERealmServiceClient.PollOnceCreateSACAttachmentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                SACAttachment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSACAttachment</summary>
        public void CreateSACAttachmentResourceNames()
        {
            // Snippet: CreateSACAttachment(LocationName, SACAttachment, string, CallSettings)
            // Create client
            SSERealmServiceClient sSERealmServiceClient = SSERealmServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            SACAttachment sacAttachment = new SACAttachment();
            string sacAttachmentId = "";
            // Make the request
            Operation<SACAttachment, OperationMetadata> response = sSERealmServiceClient.CreateSACAttachment(parent, sacAttachment, sacAttachmentId);

            // Poll until the returned long-running operation is complete
            Operation<SACAttachment, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            SACAttachment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<SACAttachment, OperationMetadata> retrievedResponse = sSERealmServiceClient.PollOnceCreateSACAttachment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                SACAttachment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSACAttachmentAsync</summary>
        public async Task CreateSACAttachmentResourceNamesAsync()
        {
            // Snippet: CreateSACAttachmentAsync(LocationName, SACAttachment, string, CallSettings)
            // Additional: CreateSACAttachmentAsync(LocationName, SACAttachment, string, CancellationToken)
            // Create client
            SSERealmServiceClient sSERealmServiceClient = await SSERealmServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            SACAttachment sacAttachment = new SACAttachment();
            string sacAttachmentId = "";
            // Make the request
            Operation<SACAttachment, OperationMetadata> response = await sSERealmServiceClient.CreateSACAttachmentAsync(parent, sacAttachment, sacAttachmentId);

            // Poll until the returned long-running operation is complete
            Operation<SACAttachment, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            SACAttachment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<SACAttachment, OperationMetadata> retrievedResponse = await sSERealmServiceClient.PollOnceCreateSACAttachmentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                SACAttachment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSACAttachment</summary>
        public void DeleteSACAttachmentRequestObject()
        {
            // Snippet: DeleteSACAttachment(DeleteSACAttachmentRequest, CallSettings)
            // Create client
            SSERealmServiceClient sSERealmServiceClient = SSERealmServiceClient.Create();
            // Initialize request argument(s)
            DeleteSACAttachmentRequest request = new DeleteSACAttachmentRequest
            {
                SACAttachmentName = SACAttachmentName.FromProjectLocationSacAttachment("[PROJECT]", "[LOCATION]", "[SAC_ATTACHMENT]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = sSERealmServiceClient.DeleteSACAttachment(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = sSERealmServiceClient.PollOnceDeleteSACAttachment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSACAttachmentAsync</summary>
        public async Task DeleteSACAttachmentRequestObjectAsync()
        {
            // Snippet: DeleteSACAttachmentAsync(DeleteSACAttachmentRequest, CallSettings)
            // Additional: DeleteSACAttachmentAsync(DeleteSACAttachmentRequest, CancellationToken)
            // Create client
            SSERealmServiceClient sSERealmServiceClient = await SSERealmServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteSACAttachmentRequest request = new DeleteSACAttachmentRequest
            {
                SACAttachmentName = SACAttachmentName.FromProjectLocationSacAttachment("[PROJECT]", "[LOCATION]", "[SAC_ATTACHMENT]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await sSERealmServiceClient.DeleteSACAttachmentAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await sSERealmServiceClient.PollOnceDeleteSACAttachmentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSACAttachment</summary>
        public void DeleteSACAttachment()
        {
            // Snippet: DeleteSACAttachment(string, CallSettings)
            // Create client
            SSERealmServiceClient sSERealmServiceClient = SSERealmServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/sacAttachments/[SAC_ATTACHMENT]";
            // Make the request
            Operation<Empty, OperationMetadata> response = sSERealmServiceClient.DeleteSACAttachment(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = sSERealmServiceClient.PollOnceDeleteSACAttachment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSACAttachmentAsync</summary>
        public async Task DeleteSACAttachmentAsync()
        {
            // Snippet: DeleteSACAttachmentAsync(string, CallSettings)
            // Additional: DeleteSACAttachmentAsync(string, CancellationToken)
            // Create client
            SSERealmServiceClient sSERealmServiceClient = await SSERealmServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/sacAttachments/[SAC_ATTACHMENT]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await sSERealmServiceClient.DeleteSACAttachmentAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await sSERealmServiceClient.PollOnceDeleteSACAttachmentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSACAttachment</summary>
        public void DeleteSACAttachmentResourceNames()
        {
            // Snippet: DeleteSACAttachment(SACAttachmentName, CallSettings)
            // Create client
            SSERealmServiceClient sSERealmServiceClient = SSERealmServiceClient.Create();
            // Initialize request argument(s)
            SACAttachmentName name = SACAttachmentName.FromProjectLocationSacAttachment("[PROJECT]", "[LOCATION]", "[SAC_ATTACHMENT]");
            // Make the request
            Operation<Empty, OperationMetadata> response = sSERealmServiceClient.DeleteSACAttachment(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = sSERealmServiceClient.PollOnceDeleteSACAttachment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSACAttachmentAsync</summary>
        public async Task DeleteSACAttachmentResourceNamesAsync()
        {
            // Snippet: DeleteSACAttachmentAsync(SACAttachmentName, CallSettings)
            // Additional: DeleteSACAttachmentAsync(SACAttachmentName, CancellationToken)
            // Create client
            SSERealmServiceClient sSERealmServiceClient = await SSERealmServiceClient.CreateAsync();
            // Initialize request argument(s)
            SACAttachmentName name = SACAttachmentName.FromProjectLocationSacAttachment("[PROJECT]", "[LOCATION]", "[SAC_ATTACHMENT]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await sSERealmServiceClient.DeleteSACAttachmentAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await sSERealmServiceClient.PollOnceDeleteSACAttachmentAsync(operationName);
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
