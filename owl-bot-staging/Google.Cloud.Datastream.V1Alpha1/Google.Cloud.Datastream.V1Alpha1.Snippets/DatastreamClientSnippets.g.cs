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
    using Google.Cloud.Datastream.V1Alpha1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedDatastreamClientSnippets
    {
        /// <summary>Snippet for ListConnectionProfiles</summary>
        public void ListConnectionProfilesRequestObject()
        {
            // Snippet: ListConnectionProfiles(ListConnectionProfilesRequest, CallSettings)
            // Create client
            DatastreamClient datastreamClient = DatastreamClient.Create();
            // Initialize request argument(s)
            ListConnectionProfilesRequest request = new ListConnectionProfilesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListConnectionProfilesResponse, ConnectionProfile> response = datastreamClient.ListConnectionProfiles(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ConnectionProfile item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListConnectionProfilesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ConnectionProfile item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ConnectionProfile> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ConnectionProfile item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListConnectionProfilesAsync</summary>
        public async Task ListConnectionProfilesRequestObjectAsync()
        {
            // Snippet: ListConnectionProfilesAsync(ListConnectionProfilesRequest, CallSettings)
            // Create client
            DatastreamClient datastreamClient = await DatastreamClient.CreateAsync();
            // Initialize request argument(s)
            ListConnectionProfilesRequest request = new ListConnectionProfilesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListConnectionProfilesResponse, ConnectionProfile> response = datastreamClient.ListConnectionProfilesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ConnectionProfile item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListConnectionProfilesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ConnectionProfile item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ConnectionProfile> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ConnectionProfile item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListConnectionProfiles</summary>
        public void ListConnectionProfiles()
        {
            // Snippet: ListConnectionProfiles(string, string, int?, CallSettings)
            // Create client
            DatastreamClient datastreamClient = DatastreamClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListConnectionProfilesResponse, ConnectionProfile> response = datastreamClient.ListConnectionProfiles(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ConnectionProfile item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListConnectionProfilesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ConnectionProfile item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ConnectionProfile> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ConnectionProfile item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListConnectionProfilesAsync</summary>
        public async Task ListConnectionProfilesAsync()
        {
            // Snippet: ListConnectionProfilesAsync(string, string, int?, CallSettings)
            // Create client
            DatastreamClient datastreamClient = await DatastreamClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListConnectionProfilesResponse, ConnectionProfile> response = datastreamClient.ListConnectionProfilesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ConnectionProfile item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListConnectionProfilesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ConnectionProfile item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ConnectionProfile> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ConnectionProfile item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListConnectionProfiles</summary>
        public void ListConnectionProfilesResourceNames()
        {
            // Snippet: ListConnectionProfiles(LocationName, string, int?, CallSettings)
            // Create client
            DatastreamClient datastreamClient = DatastreamClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListConnectionProfilesResponse, ConnectionProfile> response = datastreamClient.ListConnectionProfiles(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ConnectionProfile item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListConnectionProfilesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ConnectionProfile item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ConnectionProfile> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ConnectionProfile item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListConnectionProfilesAsync</summary>
        public async Task ListConnectionProfilesResourceNamesAsync()
        {
            // Snippet: ListConnectionProfilesAsync(LocationName, string, int?, CallSettings)
            // Create client
            DatastreamClient datastreamClient = await DatastreamClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListConnectionProfilesResponse, ConnectionProfile> response = datastreamClient.ListConnectionProfilesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ConnectionProfile item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListConnectionProfilesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ConnectionProfile item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ConnectionProfile> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ConnectionProfile item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetConnectionProfile</summary>
        public void GetConnectionProfileRequestObject()
        {
            // Snippet: GetConnectionProfile(GetConnectionProfileRequest, CallSettings)
            // Create client
            DatastreamClient datastreamClient = DatastreamClient.Create();
            // Initialize request argument(s)
            GetConnectionProfileRequest request = new GetConnectionProfileRequest
            {
                ConnectionProfileName = ConnectionProfileName.FromProjectLocationConnectionProfile("[PROJECT]", "[LOCATION]", "[CONNECTION_PROFILE]"),
            };
            // Make the request
            ConnectionProfile response = datastreamClient.GetConnectionProfile(request);
            // End snippet
        }

        /// <summary>Snippet for GetConnectionProfileAsync</summary>
        public async Task GetConnectionProfileRequestObjectAsync()
        {
            // Snippet: GetConnectionProfileAsync(GetConnectionProfileRequest, CallSettings)
            // Additional: GetConnectionProfileAsync(GetConnectionProfileRequest, CancellationToken)
            // Create client
            DatastreamClient datastreamClient = await DatastreamClient.CreateAsync();
            // Initialize request argument(s)
            GetConnectionProfileRequest request = new GetConnectionProfileRequest
            {
                ConnectionProfileName = ConnectionProfileName.FromProjectLocationConnectionProfile("[PROJECT]", "[LOCATION]", "[CONNECTION_PROFILE]"),
            };
            // Make the request
            ConnectionProfile response = await datastreamClient.GetConnectionProfileAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetConnectionProfile</summary>
        public void GetConnectionProfile()
        {
            // Snippet: GetConnectionProfile(string, CallSettings)
            // Create client
            DatastreamClient datastreamClient = DatastreamClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/connectionProfiles/[CONNECTION_PROFILE]";
            // Make the request
            ConnectionProfile response = datastreamClient.GetConnectionProfile(name);
            // End snippet
        }

        /// <summary>Snippet for GetConnectionProfileAsync</summary>
        public async Task GetConnectionProfileAsync()
        {
            // Snippet: GetConnectionProfileAsync(string, CallSettings)
            // Additional: GetConnectionProfileAsync(string, CancellationToken)
            // Create client
            DatastreamClient datastreamClient = await DatastreamClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/connectionProfiles/[CONNECTION_PROFILE]";
            // Make the request
            ConnectionProfile response = await datastreamClient.GetConnectionProfileAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetConnectionProfile</summary>
        public void GetConnectionProfileResourceNames()
        {
            // Snippet: GetConnectionProfile(ConnectionProfileName, CallSettings)
            // Create client
            DatastreamClient datastreamClient = DatastreamClient.Create();
            // Initialize request argument(s)
            ConnectionProfileName name = ConnectionProfileName.FromProjectLocationConnectionProfile("[PROJECT]", "[LOCATION]", "[CONNECTION_PROFILE]");
            // Make the request
            ConnectionProfile response = datastreamClient.GetConnectionProfile(name);
            // End snippet
        }

        /// <summary>Snippet for GetConnectionProfileAsync</summary>
        public async Task GetConnectionProfileResourceNamesAsync()
        {
            // Snippet: GetConnectionProfileAsync(ConnectionProfileName, CallSettings)
            // Additional: GetConnectionProfileAsync(ConnectionProfileName, CancellationToken)
            // Create client
            DatastreamClient datastreamClient = await DatastreamClient.CreateAsync();
            // Initialize request argument(s)
            ConnectionProfileName name = ConnectionProfileName.FromProjectLocationConnectionProfile("[PROJECT]", "[LOCATION]", "[CONNECTION_PROFILE]");
            // Make the request
            ConnectionProfile response = await datastreamClient.GetConnectionProfileAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateConnectionProfile</summary>
        public void CreateConnectionProfileRequestObject()
        {
            // Snippet: CreateConnectionProfile(CreateConnectionProfileRequest, CallSettings)
            // Create client
            DatastreamClient datastreamClient = DatastreamClient.Create();
            // Initialize request argument(s)
            CreateConnectionProfileRequest request = new CreateConnectionProfileRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ConnectionProfileId = "",
                ConnectionProfile = new ConnectionProfile(),
                RequestId = "",
            };
            // Make the request
            Operation<ConnectionProfile, OperationMetadata> response = datastreamClient.CreateConnectionProfile(request);

            // Poll until the returned long-running operation is complete
            Operation<ConnectionProfile, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ConnectionProfile result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ConnectionProfile, OperationMetadata> retrievedResponse = datastreamClient.PollOnceCreateConnectionProfile(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ConnectionProfile retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateConnectionProfileAsync</summary>
        public async Task CreateConnectionProfileRequestObjectAsync()
        {
            // Snippet: CreateConnectionProfileAsync(CreateConnectionProfileRequest, CallSettings)
            // Additional: CreateConnectionProfileAsync(CreateConnectionProfileRequest, CancellationToken)
            // Create client
            DatastreamClient datastreamClient = await DatastreamClient.CreateAsync();
            // Initialize request argument(s)
            CreateConnectionProfileRequest request = new CreateConnectionProfileRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ConnectionProfileId = "",
                ConnectionProfile = new ConnectionProfile(),
                RequestId = "",
            };
            // Make the request
            Operation<ConnectionProfile, OperationMetadata> response = await datastreamClient.CreateConnectionProfileAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ConnectionProfile, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ConnectionProfile result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ConnectionProfile, OperationMetadata> retrievedResponse = await datastreamClient.PollOnceCreateConnectionProfileAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ConnectionProfile retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateConnectionProfile</summary>
        public void CreateConnectionProfile()
        {
            // Snippet: CreateConnectionProfile(string, ConnectionProfile, string, CallSettings)
            // Create client
            DatastreamClient datastreamClient = DatastreamClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            ConnectionProfile connectionProfile = new ConnectionProfile();
            string connectionProfileId = "";
            // Make the request
            Operation<ConnectionProfile, OperationMetadata> response = datastreamClient.CreateConnectionProfile(parent, connectionProfile, connectionProfileId);

            // Poll until the returned long-running operation is complete
            Operation<ConnectionProfile, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ConnectionProfile result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ConnectionProfile, OperationMetadata> retrievedResponse = datastreamClient.PollOnceCreateConnectionProfile(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ConnectionProfile retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateConnectionProfileAsync</summary>
        public async Task CreateConnectionProfileAsync()
        {
            // Snippet: CreateConnectionProfileAsync(string, ConnectionProfile, string, CallSettings)
            // Additional: CreateConnectionProfileAsync(string, ConnectionProfile, string, CancellationToken)
            // Create client
            DatastreamClient datastreamClient = await DatastreamClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            ConnectionProfile connectionProfile = new ConnectionProfile();
            string connectionProfileId = "";
            // Make the request
            Operation<ConnectionProfile, OperationMetadata> response = await datastreamClient.CreateConnectionProfileAsync(parent, connectionProfile, connectionProfileId);

            // Poll until the returned long-running operation is complete
            Operation<ConnectionProfile, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ConnectionProfile result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ConnectionProfile, OperationMetadata> retrievedResponse = await datastreamClient.PollOnceCreateConnectionProfileAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ConnectionProfile retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateConnectionProfile</summary>
        public void CreateConnectionProfileResourceNames()
        {
            // Snippet: CreateConnectionProfile(LocationName, ConnectionProfile, string, CallSettings)
            // Create client
            DatastreamClient datastreamClient = DatastreamClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            ConnectionProfile connectionProfile = new ConnectionProfile();
            string connectionProfileId = "";
            // Make the request
            Operation<ConnectionProfile, OperationMetadata> response = datastreamClient.CreateConnectionProfile(parent, connectionProfile, connectionProfileId);

            // Poll until the returned long-running operation is complete
            Operation<ConnectionProfile, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ConnectionProfile result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ConnectionProfile, OperationMetadata> retrievedResponse = datastreamClient.PollOnceCreateConnectionProfile(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ConnectionProfile retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateConnectionProfileAsync</summary>
        public async Task CreateConnectionProfileResourceNamesAsync()
        {
            // Snippet: CreateConnectionProfileAsync(LocationName, ConnectionProfile, string, CallSettings)
            // Additional: CreateConnectionProfileAsync(LocationName, ConnectionProfile, string, CancellationToken)
            // Create client
            DatastreamClient datastreamClient = await DatastreamClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            ConnectionProfile connectionProfile = new ConnectionProfile();
            string connectionProfileId = "";
            // Make the request
            Operation<ConnectionProfile, OperationMetadata> response = await datastreamClient.CreateConnectionProfileAsync(parent, connectionProfile, connectionProfileId);

            // Poll until the returned long-running operation is complete
            Operation<ConnectionProfile, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ConnectionProfile result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ConnectionProfile, OperationMetadata> retrievedResponse = await datastreamClient.PollOnceCreateConnectionProfileAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ConnectionProfile retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateConnectionProfile</summary>
        public void UpdateConnectionProfileRequestObject()
        {
            // Snippet: UpdateConnectionProfile(UpdateConnectionProfileRequest, CallSettings)
            // Create client
            DatastreamClient datastreamClient = DatastreamClient.Create();
            // Initialize request argument(s)
            UpdateConnectionProfileRequest request = new UpdateConnectionProfileRequest
            {
                UpdateMask = new FieldMask(),
                ConnectionProfile = new ConnectionProfile(),
                RequestId = "",
            };
            // Make the request
            Operation<ConnectionProfile, OperationMetadata> response = datastreamClient.UpdateConnectionProfile(request);

            // Poll until the returned long-running operation is complete
            Operation<ConnectionProfile, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ConnectionProfile result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ConnectionProfile, OperationMetadata> retrievedResponse = datastreamClient.PollOnceUpdateConnectionProfile(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ConnectionProfile retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateConnectionProfileAsync</summary>
        public async Task UpdateConnectionProfileRequestObjectAsync()
        {
            // Snippet: UpdateConnectionProfileAsync(UpdateConnectionProfileRequest, CallSettings)
            // Additional: UpdateConnectionProfileAsync(UpdateConnectionProfileRequest, CancellationToken)
            // Create client
            DatastreamClient datastreamClient = await DatastreamClient.CreateAsync();
            // Initialize request argument(s)
            UpdateConnectionProfileRequest request = new UpdateConnectionProfileRequest
            {
                UpdateMask = new FieldMask(),
                ConnectionProfile = new ConnectionProfile(),
                RequestId = "",
            };
            // Make the request
            Operation<ConnectionProfile, OperationMetadata> response = await datastreamClient.UpdateConnectionProfileAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ConnectionProfile, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ConnectionProfile result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ConnectionProfile, OperationMetadata> retrievedResponse = await datastreamClient.PollOnceUpdateConnectionProfileAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ConnectionProfile retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateConnectionProfile</summary>
        public void UpdateConnectionProfile()
        {
            // Snippet: UpdateConnectionProfile(ConnectionProfile, FieldMask, CallSettings)
            // Create client
            DatastreamClient datastreamClient = DatastreamClient.Create();
            // Initialize request argument(s)
            ConnectionProfile connectionProfile = new ConnectionProfile();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<ConnectionProfile, OperationMetadata> response = datastreamClient.UpdateConnectionProfile(connectionProfile, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<ConnectionProfile, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ConnectionProfile result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ConnectionProfile, OperationMetadata> retrievedResponse = datastreamClient.PollOnceUpdateConnectionProfile(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ConnectionProfile retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateConnectionProfileAsync</summary>
        public async Task UpdateConnectionProfileAsync()
        {
            // Snippet: UpdateConnectionProfileAsync(ConnectionProfile, FieldMask, CallSettings)
            // Additional: UpdateConnectionProfileAsync(ConnectionProfile, FieldMask, CancellationToken)
            // Create client
            DatastreamClient datastreamClient = await DatastreamClient.CreateAsync();
            // Initialize request argument(s)
            ConnectionProfile connectionProfile = new ConnectionProfile();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<ConnectionProfile, OperationMetadata> response = await datastreamClient.UpdateConnectionProfileAsync(connectionProfile, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<ConnectionProfile, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ConnectionProfile result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ConnectionProfile, OperationMetadata> retrievedResponse = await datastreamClient.PollOnceUpdateConnectionProfileAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ConnectionProfile retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteConnectionProfile</summary>
        public void DeleteConnectionProfileRequestObject()
        {
            // Snippet: DeleteConnectionProfile(DeleteConnectionProfileRequest, CallSettings)
            // Create client
            DatastreamClient datastreamClient = DatastreamClient.Create();
            // Initialize request argument(s)
            DeleteConnectionProfileRequest request = new DeleteConnectionProfileRequest
            {
                ConnectionProfileName = ConnectionProfileName.FromProjectLocationConnectionProfile("[PROJECT]", "[LOCATION]", "[CONNECTION_PROFILE]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = datastreamClient.DeleteConnectionProfile(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = datastreamClient.PollOnceDeleteConnectionProfile(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteConnectionProfileAsync</summary>
        public async Task DeleteConnectionProfileRequestObjectAsync()
        {
            // Snippet: DeleteConnectionProfileAsync(DeleteConnectionProfileRequest, CallSettings)
            // Additional: DeleteConnectionProfileAsync(DeleteConnectionProfileRequest, CancellationToken)
            // Create client
            DatastreamClient datastreamClient = await DatastreamClient.CreateAsync();
            // Initialize request argument(s)
            DeleteConnectionProfileRequest request = new DeleteConnectionProfileRequest
            {
                ConnectionProfileName = ConnectionProfileName.FromProjectLocationConnectionProfile("[PROJECT]", "[LOCATION]", "[CONNECTION_PROFILE]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await datastreamClient.DeleteConnectionProfileAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await datastreamClient.PollOnceDeleteConnectionProfileAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteConnectionProfile</summary>
        public void DeleteConnectionProfile()
        {
            // Snippet: DeleteConnectionProfile(string, CallSettings)
            // Create client
            DatastreamClient datastreamClient = DatastreamClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/connectionProfiles/[CONNECTION_PROFILE]";
            // Make the request
            Operation<Empty, OperationMetadata> response = datastreamClient.DeleteConnectionProfile(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = datastreamClient.PollOnceDeleteConnectionProfile(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteConnectionProfileAsync</summary>
        public async Task DeleteConnectionProfileAsync()
        {
            // Snippet: DeleteConnectionProfileAsync(string, CallSettings)
            // Additional: DeleteConnectionProfileAsync(string, CancellationToken)
            // Create client
            DatastreamClient datastreamClient = await DatastreamClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/connectionProfiles/[CONNECTION_PROFILE]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await datastreamClient.DeleteConnectionProfileAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await datastreamClient.PollOnceDeleteConnectionProfileAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteConnectionProfile</summary>
        public void DeleteConnectionProfileResourceNames()
        {
            // Snippet: DeleteConnectionProfile(ConnectionProfileName, CallSettings)
            // Create client
            DatastreamClient datastreamClient = DatastreamClient.Create();
            // Initialize request argument(s)
            ConnectionProfileName name = ConnectionProfileName.FromProjectLocationConnectionProfile("[PROJECT]", "[LOCATION]", "[CONNECTION_PROFILE]");
            // Make the request
            Operation<Empty, OperationMetadata> response = datastreamClient.DeleteConnectionProfile(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = datastreamClient.PollOnceDeleteConnectionProfile(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteConnectionProfileAsync</summary>
        public async Task DeleteConnectionProfileResourceNamesAsync()
        {
            // Snippet: DeleteConnectionProfileAsync(ConnectionProfileName, CallSettings)
            // Additional: DeleteConnectionProfileAsync(ConnectionProfileName, CancellationToken)
            // Create client
            DatastreamClient datastreamClient = await DatastreamClient.CreateAsync();
            // Initialize request argument(s)
            ConnectionProfileName name = ConnectionProfileName.FromProjectLocationConnectionProfile("[PROJECT]", "[LOCATION]", "[CONNECTION_PROFILE]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await datastreamClient.DeleteConnectionProfileAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await datastreamClient.PollOnceDeleteConnectionProfileAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DiscoverConnectionProfile</summary>
        public void DiscoverConnectionProfileRequestObject()
        {
            // Snippet: DiscoverConnectionProfile(DiscoverConnectionProfileRequest, CallSettings)
            // Create client
            DatastreamClient datastreamClient = DatastreamClient.Create();
            // Initialize request argument(s)
            DiscoverConnectionProfileRequest request = new DiscoverConnectionProfileRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Recursive = false,
                OracleRdbms = new OracleRdbms(),
                ConnectionProfile = new ConnectionProfile(),
            };
            // Make the request
            DiscoverConnectionProfileResponse response = datastreamClient.DiscoverConnectionProfile(request);
            // End snippet
        }

        /// <summary>Snippet for DiscoverConnectionProfileAsync</summary>
        public async Task DiscoverConnectionProfileRequestObjectAsync()
        {
            // Snippet: DiscoverConnectionProfileAsync(DiscoverConnectionProfileRequest, CallSettings)
            // Additional: DiscoverConnectionProfileAsync(DiscoverConnectionProfileRequest, CancellationToken)
            // Create client
            DatastreamClient datastreamClient = await DatastreamClient.CreateAsync();
            // Initialize request argument(s)
            DiscoverConnectionProfileRequest request = new DiscoverConnectionProfileRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Recursive = false,
                OracleRdbms = new OracleRdbms(),
                ConnectionProfile = new ConnectionProfile(),
            };
            // Make the request
            DiscoverConnectionProfileResponse response = await datastreamClient.DiscoverConnectionProfileAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ListStreams</summary>
        public void ListStreamsRequestObject()
        {
            // Snippet: ListStreams(ListStreamsRequest, CallSettings)
            // Create client
            DatastreamClient datastreamClient = DatastreamClient.Create();
            // Initialize request argument(s)
            ListStreamsRequest request = new ListStreamsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListStreamsResponse, Stream> response = datastreamClient.ListStreams(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Stream item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListStreamsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Stream item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Stream> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Stream item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListStreamsAsync</summary>
        public async Task ListStreamsRequestObjectAsync()
        {
            // Snippet: ListStreamsAsync(ListStreamsRequest, CallSettings)
            // Create client
            DatastreamClient datastreamClient = await DatastreamClient.CreateAsync();
            // Initialize request argument(s)
            ListStreamsRequest request = new ListStreamsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListStreamsResponse, Stream> response = datastreamClient.ListStreamsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Stream item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListStreamsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Stream item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Stream> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Stream item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListStreams</summary>
        public void ListStreams()
        {
            // Snippet: ListStreams(string, string, int?, CallSettings)
            // Create client
            DatastreamClient datastreamClient = DatastreamClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListStreamsResponse, Stream> response = datastreamClient.ListStreams(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Stream item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListStreamsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Stream item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Stream> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Stream item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListStreamsAsync</summary>
        public async Task ListStreamsAsync()
        {
            // Snippet: ListStreamsAsync(string, string, int?, CallSettings)
            // Create client
            DatastreamClient datastreamClient = await DatastreamClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListStreamsResponse, Stream> response = datastreamClient.ListStreamsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Stream item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListStreamsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Stream item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Stream> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Stream item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListStreams</summary>
        public void ListStreamsResourceNames()
        {
            // Snippet: ListStreams(LocationName, string, int?, CallSettings)
            // Create client
            DatastreamClient datastreamClient = DatastreamClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListStreamsResponse, Stream> response = datastreamClient.ListStreams(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Stream item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListStreamsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Stream item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Stream> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Stream item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListStreamsAsync</summary>
        public async Task ListStreamsResourceNamesAsync()
        {
            // Snippet: ListStreamsAsync(LocationName, string, int?, CallSettings)
            // Create client
            DatastreamClient datastreamClient = await DatastreamClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListStreamsResponse, Stream> response = datastreamClient.ListStreamsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Stream item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListStreamsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Stream item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Stream> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Stream item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetStream</summary>
        public void GetStreamRequestObject()
        {
            // Snippet: GetStream(GetStreamRequest, CallSettings)
            // Create client
            DatastreamClient datastreamClient = DatastreamClient.Create();
            // Initialize request argument(s)
            GetStreamRequest request = new GetStreamRequest
            {
                StreamName = StreamName.FromProjectLocationStream("[PROJECT]", "[LOCATION]", "[STREAM]"),
            };
            // Make the request
            Stream response = datastreamClient.GetStream(request);
            // End snippet
        }

        /// <summary>Snippet for GetStreamAsync</summary>
        public async Task GetStreamRequestObjectAsync()
        {
            // Snippet: GetStreamAsync(GetStreamRequest, CallSettings)
            // Additional: GetStreamAsync(GetStreamRequest, CancellationToken)
            // Create client
            DatastreamClient datastreamClient = await DatastreamClient.CreateAsync();
            // Initialize request argument(s)
            GetStreamRequest request = new GetStreamRequest
            {
                StreamName = StreamName.FromProjectLocationStream("[PROJECT]", "[LOCATION]", "[STREAM]"),
            };
            // Make the request
            Stream response = await datastreamClient.GetStreamAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetStream</summary>
        public void GetStream()
        {
            // Snippet: GetStream(string, CallSettings)
            // Create client
            DatastreamClient datastreamClient = DatastreamClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/streams/[STREAM]";
            // Make the request
            Stream response = datastreamClient.GetStream(name);
            // End snippet
        }

        /// <summary>Snippet for GetStreamAsync</summary>
        public async Task GetStreamAsync()
        {
            // Snippet: GetStreamAsync(string, CallSettings)
            // Additional: GetStreamAsync(string, CancellationToken)
            // Create client
            DatastreamClient datastreamClient = await DatastreamClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/streams/[STREAM]";
            // Make the request
            Stream response = await datastreamClient.GetStreamAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetStream</summary>
        public void GetStreamResourceNames()
        {
            // Snippet: GetStream(StreamName, CallSettings)
            // Create client
            DatastreamClient datastreamClient = DatastreamClient.Create();
            // Initialize request argument(s)
            StreamName name = StreamName.FromProjectLocationStream("[PROJECT]", "[LOCATION]", "[STREAM]");
            // Make the request
            Stream response = datastreamClient.GetStream(name);
            // End snippet
        }

        /// <summary>Snippet for GetStreamAsync</summary>
        public async Task GetStreamResourceNamesAsync()
        {
            // Snippet: GetStreamAsync(StreamName, CallSettings)
            // Additional: GetStreamAsync(StreamName, CancellationToken)
            // Create client
            DatastreamClient datastreamClient = await DatastreamClient.CreateAsync();
            // Initialize request argument(s)
            StreamName name = StreamName.FromProjectLocationStream("[PROJECT]", "[LOCATION]", "[STREAM]");
            // Make the request
            Stream response = await datastreamClient.GetStreamAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateStream</summary>
        public void CreateStreamRequestObject()
        {
            // Snippet: CreateStream(CreateStreamRequest, CallSettings)
            // Create client
            DatastreamClient datastreamClient = DatastreamClient.Create();
            // Initialize request argument(s)
            CreateStreamRequest request = new CreateStreamRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                StreamId = "",
                Stream = new Stream(),
                RequestId = "",
                ValidateOnly = false,
                Force = false,
            };
            // Make the request
            Operation<Stream, OperationMetadata> response = datastreamClient.CreateStream(request);

            // Poll until the returned long-running operation is complete
            Operation<Stream, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Stream result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Stream, OperationMetadata> retrievedResponse = datastreamClient.PollOnceCreateStream(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Stream retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateStreamAsync</summary>
        public async Task CreateStreamRequestObjectAsync()
        {
            // Snippet: CreateStreamAsync(CreateStreamRequest, CallSettings)
            // Additional: CreateStreamAsync(CreateStreamRequest, CancellationToken)
            // Create client
            DatastreamClient datastreamClient = await DatastreamClient.CreateAsync();
            // Initialize request argument(s)
            CreateStreamRequest request = new CreateStreamRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                StreamId = "",
                Stream = new Stream(),
                RequestId = "",
                ValidateOnly = false,
                Force = false,
            };
            // Make the request
            Operation<Stream, OperationMetadata> response = await datastreamClient.CreateStreamAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Stream, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Stream result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Stream, OperationMetadata> retrievedResponse = await datastreamClient.PollOnceCreateStreamAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Stream retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateStream</summary>
        public void CreateStream()
        {
            // Snippet: CreateStream(string, Stream, string, CallSettings)
            // Create client
            DatastreamClient datastreamClient = DatastreamClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Stream stream = new Stream();
            string streamId = "";
            // Make the request
            Operation<Stream, OperationMetadata> response = datastreamClient.CreateStream(parent, stream, streamId);

            // Poll until the returned long-running operation is complete
            Operation<Stream, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Stream result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Stream, OperationMetadata> retrievedResponse = datastreamClient.PollOnceCreateStream(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Stream retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateStreamAsync</summary>
        public async Task CreateStreamAsync()
        {
            // Snippet: CreateStreamAsync(string, Stream, string, CallSettings)
            // Additional: CreateStreamAsync(string, Stream, string, CancellationToken)
            // Create client
            DatastreamClient datastreamClient = await DatastreamClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Stream stream = new Stream();
            string streamId = "";
            // Make the request
            Operation<Stream, OperationMetadata> response = await datastreamClient.CreateStreamAsync(parent, stream, streamId);

            // Poll until the returned long-running operation is complete
            Operation<Stream, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Stream result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Stream, OperationMetadata> retrievedResponse = await datastreamClient.PollOnceCreateStreamAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Stream retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateStream</summary>
        public void CreateStreamResourceNames()
        {
            // Snippet: CreateStream(LocationName, Stream, string, CallSettings)
            // Create client
            DatastreamClient datastreamClient = DatastreamClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Stream stream = new Stream();
            string streamId = "";
            // Make the request
            Operation<Stream, OperationMetadata> response = datastreamClient.CreateStream(parent, stream, streamId);

            // Poll until the returned long-running operation is complete
            Operation<Stream, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Stream result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Stream, OperationMetadata> retrievedResponse = datastreamClient.PollOnceCreateStream(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Stream retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateStreamAsync</summary>
        public async Task CreateStreamResourceNamesAsync()
        {
            // Snippet: CreateStreamAsync(LocationName, Stream, string, CallSettings)
            // Additional: CreateStreamAsync(LocationName, Stream, string, CancellationToken)
            // Create client
            DatastreamClient datastreamClient = await DatastreamClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Stream stream = new Stream();
            string streamId = "";
            // Make the request
            Operation<Stream, OperationMetadata> response = await datastreamClient.CreateStreamAsync(parent, stream, streamId);

            // Poll until the returned long-running operation is complete
            Operation<Stream, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Stream result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Stream, OperationMetadata> retrievedResponse = await datastreamClient.PollOnceCreateStreamAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Stream retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateStream</summary>
        public void UpdateStreamRequestObject()
        {
            // Snippet: UpdateStream(UpdateStreamRequest, CallSettings)
            // Create client
            DatastreamClient datastreamClient = DatastreamClient.Create();
            // Initialize request argument(s)
            UpdateStreamRequest request = new UpdateStreamRequest
            {
                UpdateMask = new FieldMask(),
                Stream = new Stream(),
                RequestId = "",
                ValidateOnly = false,
                Force = false,
            };
            // Make the request
            Operation<Stream, OperationMetadata> response = datastreamClient.UpdateStream(request);

            // Poll until the returned long-running operation is complete
            Operation<Stream, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Stream result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Stream, OperationMetadata> retrievedResponse = datastreamClient.PollOnceUpdateStream(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Stream retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateStreamAsync</summary>
        public async Task UpdateStreamRequestObjectAsync()
        {
            // Snippet: UpdateStreamAsync(UpdateStreamRequest, CallSettings)
            // Additional: UpdateStreamAsync(UpdateStreamRequest, CancellationToken)
            // Create client
            DatastreamClient datastreamClient = await DatastreamClient.CreateAsync();
            // Initialize request argument(s)
            UpdateStreamRequest request = new UpdateStreamRequest
            {
                UpdateMask = new FieldMask(),
                Stream = new Stream(),
                RequestId = "",
                ValidateOnly = false,
                Force = false,
            };
            // Make the request
            Operation<Stream, OperationMetadata> response = await datastreamClient.UpdateStreamAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Stream, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Stream result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Stream, OperationMetadata> retrievedResponse = await datastreamClient.PollOnceUpdateStreamAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Stream retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateStream</summary>
        public void UpdateStream()
        {
            // Snippet: UpdateStream(Stream, FieldMask, CallSettings)
            // Create client
            DatastreamClient datastreamClient = DatastreamClient.Create();
            // Initialize request argument(s)
            Stream stream = new Stream();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Stream, OperationMetadata> response = datastreamClient.UpdateStream(stream, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Stream, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Stream result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Stream, OperationMetadata> retrievedResponse = datastreamClient.PollOnceUpdateStream(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Stream retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateStreamAsync</summary>
        public async Task UpdateStreamAsync()
        {
            // Snippet: UpdateStreamAsync(Stream, FieldMask, CallSettings)
            // Additional: UpdateStreamAsync(Stream, FieldMask, CancellationToken)
            // Create client
            DatastreamClient datastreamClient = await DatastreamClient.CreateAsync();
            // Initialize request argument(s)
            Stream stream = new Stream();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Stream, OperationMetadata> response = await datastreamClient.UpdateStreamAsync(stream, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Stream, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Stream result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Stream, OperationMetadata> retrievedResponse = await datastreamClient.PollOnceUpdateStreamAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Stream retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteStream</summary>
        public void DeleteStreamRequestObject()
        {
            // Snippet: DeleteStream(DeleteStreamRequest, CallSettings)
            // Create client
            DatastreamClient datastreamClient = DatastreamClient.Create();
            // Initialize request argument(s)
            DeleteStreamRequest request = new DeleteStreamRequest
            {
                StreamName = StreamName.FromProjectLocationStream("[PROJECT]", "[LOCATION]", "[STREAM]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = datastreamClient.DeleteStream(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = datastreamClient.PollOnceDeleteStream(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteStreamAsync</summary>
        public async Task DeleteStreamRequestObjectAsync()
        {
            // Snippet: DeleteStreamAsync(DeleteStreamRequest, CallSettings)
            // Additional: DeleteStreamAsync(DeleteStreamRequest, CancellationToken)
            // Create client
            DatastreamClient datastreamClient = await DatastreamClient.CreateAsync();
            // Initialize request argument(s)
            DeleteStreamRequest request = new DeleteStreamRequest
            {
                StreamName = StreamName.FromProjectLocationStream("[PROJECT]", "[LOCATION]", "[STREAM]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await datastreamClient.DeleteStreamAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await datastreamClient.PollOnceDeleteStreamAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteStream</summary>
        public void DeleteStream()
        {
            // Snippet: DeleteStream(string, CallSettings)
            // Create client
            DatastreamClient datastreamClient = DatastreamClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/streams/[STREAM]";
            // Make the request
            Operation<Empty, OperationMetadata> response = datastreamClient.DeleteStream(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = datastreamClient.PollOnceDeleteStream(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteStreamAsync</summary>
        public async Task DeleteStreamAsync()
        {
            // Snippet: DeleteStreamAsync(string, CallSettings)
            // Additional: DeleteStreamAsync(string, CancellationToken)
            // Create client
            DatastreamClient datastreamClient = await DatastreamClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/streams/[STREAM]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await datastreamClient.DeleteStreamAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await datastreamClient.PollOnceDeleteStreamAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteStream</summary>
        public void DeleteStreamResourceNames()
        {
            // Snippet: DeleteStream(StreamName, CallSettings)
            // Create client
            DatastreamClient datastreamClient = DatastreamClient.Create();
            // Initialize request argument(s)
            StreamName name = StreamName.FromProjectLocationStream("[PROJECT]", "[LOCATION]", "[STREAM]");
            // Make the request
            Operation<Empty, OperationMetadata> response = datastreamClient.DeleteStream(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = datastreamClient.PollOnceDeleteStream(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteStreamAsync</summary>
        public async Task DeleteStreamResourceNamesAsync()
        {
            // Snippet: DeleteStreamAsync(StreamName, CallSettings)
            // Additional: DeleteStreamAsync(StreamName, CancellationToken)
            // Create client
            DatastreamClient datastreamClient = await DatastreamClient.CreateAsync();
            // Initialize request argument(s)
            StreamName name = StreamName.FromProjectLocationStream("[PROJECT]", "[LOCATION]", "[STREAM]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await datastreamClient.DeleteStreamAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await datastreamClient.PollOnceDeleteStreamAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for FetchErrors</summary>
        public void FetchErrorsRequestObject()
        {
            // Snippet: FetchErrors(FetchErrorsRequest, CallSettings)
            // Create client
            DatastreamClient datastreamClient = DatastreamClient.Create();
            // Initialize request argument(s)
            FetchErrorsRequest request = new FetchErrorsRequest
            {
                StreamAsStreamName = StreamName.FromProjectLocationStream("[PROJECT]", "[LOCATION]", "[STREAM]"),
            };
            // Make the request
            Operation<FetchErrorsResponse, OperationMetadata> response = datastreamClient.FetchErrors(request);

            // Poll until the returned long-running operation is complete
            Operation<FetchErrorsResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            FetchErrorsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<FetchErrorsResponse, OperationMetadata> retrievedResponse = datastreamClient.PollOnceFetchErrors(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                FetchErrorsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for FetchErrorsAsync</summary>
        public async Task FetchErrorsRequestObjectAsync()
        {
            // Snippet: FetchErrorsAsync(FetchErrorsRequest, CallSettings)
            // Additional: FetchErrorsAsync(FetchErrorsRequest, CancellationToken)
            // Create client
            DatastreamClient datastreamClient = await DatastreamClient.CreateAsync();
            // Initialize request argument(s)
            FetchErrorsRequest request = new FetchErrorsRequest
            {
                StreamAsStreamName = StreamName.FromProjectLocationStream("[PROJECT]", "[LOCATION]", "[STREAM]"),
            };
            // Make the request
            Operation<FetchErrorsResponse, OperationMetadata> response = await datastreamClient.FetchErrorsAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<FetchErrorsResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            FetchErrorsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<FetchErrorsResponse, OperationMetadata> retrievedResponse = await datastreamClient.PollOnceFetchErrorsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                FetchErrorsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for FetchStaticIps</summary>
        public void FetchStaticIpsRequestObject()
        {
            // Snippet: FetchStaticIps(FetchStaticIpsRequest, CallSettings)
            // Create client
            DatastreamClient datastreamClient = DatastreamClient.Create();
            // Initialize request argument(s)
            FetchStaticIpsRequest request = new FetchStaticIpsRequest
            {
                LocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedEnumerable<FetchStaticIpsResponse, string> response = datastreamClient.FetchStaticIps(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (string item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (FetchStaticIpsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (string item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<string> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (string item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for FetchStaticIpsAsync</summary>
        public async Task FetchStaticIpsRequestObjectAsync()
        {
            // Snippet: FetchStaticIpsAsync(FetchStaticIpsRequest, CallSettings)
            // Create client
            DatastreamClient datastreamClient = await DatastreamClient.CreateAsync();
            // Initialize request argument(s)
            FetchStaticIpsRequest request = new FetchStaticIpsRequest
            {
                LocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<FetchStaticIpsResponse, string> response = datastreamClient.FetchStaticIpsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((string item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((FetchStaticIpsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (string item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<string> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (string item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for FetchStaticIps</summary>
        public void FetchStaticIps()
        {
            // Snippet: FetchStaticIps(string, string, int?, CallSettings)
            // Create client
            DatastreamClient datastreamClient = DatastreamClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<FetchStaticIpsResponse, string> response = datastreamClient.FetchStaticIps(name);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (string item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (FetchStaticIpsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (string item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<string> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (string item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for FetchStaticIpsAsync</summary>
        public async Task FetchStaticIpsAsync()
        {
            // Snippet: FetchStaticIpsAsync(string, string, int?, CallSettings)
            // Create client
            DatastreamClient datastreamClient = await DatastreamClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<FetchStaticIpsResponse, string> response = datastreamClient.FetchStaticIpsAsync(name);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((string item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((FetchStaticIpsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (string item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<string> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (string item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for FetchStaticIps</summary>
        public void FetchStaticIpsResourceNames()
        {
            // Snippet: FetchStaticIps(LocationName, string, int?, CallSettings)
            // Create client
            DatastreamClient datastreamClient = DatastreamClient.Create();
            // Initialize request argument(s)
            LocationName name = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<FetchStaticIpsResponse, string> response = datastreamClient.FetchStaticIps(name);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (string item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (FetchStaticIpsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (string item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<string> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (string item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for FetchStaticIpsAsync</summary>
        public async Task FetchStaticIpsResourceNamesAsync()
        {
            // Snippet: FetchStaticIpsAsync(LocationName, string, int?, CallSettings)
            // Create client
            DatastreamClient datastreamClient = await DatastreamClient.CreateAsync();
            // Initialize request argument(s)
            LocationName name = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<FetchStaticIpsResponse, string> response = datastreamClient.FetchStaticIpsAsync(name);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((string item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((FetchStaticIpsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (string item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<string> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (string item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreatePrivateConnection</summary>
        public void CreatePrivateConnectionRequestObject()
        {
            // Snippet: CreatePrivateConnection(CreatePrivateConnectionRequest, CallSettings)
            // Create client
            DatastreamClient datastreamClient = DatastreamClient.Create();
            // Initialize request argument(s)
            CreatePrivateConnectionRequest request = new CreatePrivateConnectionRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                PrivateConnectionId = "",
                PrivateConnection = new PrivateConnection(),
                RequestId = "",
            };
            // Make the request
            Operation<PrivateConnection, OperationMetadata> response = datastreamClient.CreatePrivateConnection(request);

            // Poll until the returned long-running operation is complete
            Operation<PrivateConnection, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            PrivateConnection result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PrivateConnection, OperationMetadata> retrievedResponse = datastreamClient.PollOnceCreatePrivateConnection(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PrivateConnection retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreatePrivateConnectionAsync</summary>
        public async Task CreatePrivateConnectionRequestObjectAsync()
        {
            // Snippet: CreatePrivateConnectionAsync(CreatePrivateConnectionRequest, CallSettings)
            // Additional: CreatePrivateConnectionAsync(CreatePrivateConnectionRequest, CancellationToken)
            // Create client
            DatastreamClient datastreamClient = await DatastreamClient.CreateAsync();
            // Initialize request argument(s)
            CreatePrivateConnectionRequest request = new CreatePrivateConnectionRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                PrivateConnectionId = "",
                PrivateConnection = new PrivateConnection(),
                RequestId = "",
            };
            // Make the request
            Operation<PrivateConnection, OperationMetadata> response = await datastreamClient.CreatePrivateConnectionAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<PrivateConnection, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            PrivateConnection result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PrivateConnection, OperationMetadata> retrievedResponse = await datastreamClient.PollOnceCreatePrivateConnectionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PrivateConnection retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreatePrivateConnection</summary>
        public void CreatePrivateConnection()
        {
            // Snippet: CreatePrivateConnection(string, PrivateConnection, string, CallSettings)
            // Create client
            DatastreamClient datastreamClient = DatastreamClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            PrivateConnection privateConnection = new PrivateConnection();
            string privateConnectionId = "";
            // Make the request
            Operation<PrivateConnection, OperationMetadata> response = datastreamClient.CreatePrivateConnection(parent, privateConnection, privateConnectionId);

            // Poll until the returned long-running operation is complete
            Operation<PrivateConnection, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            PrivateConnection result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PrivateConnection, OperationMetadata> retrievedResponse = datastreamClient.PollOnceCreatePrivateConnection(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PrivateConnection retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreatePrivateConnectionAsync</summary>
        public async Task CreatePrivateConnectionAsync()
        {
            // Snippet: CreatePrivateConnectionAsync(string, PrivateConnection, string, CallSettings)
            // Additional: CreatePrivateConnectionAsync(string, PrivateConnection, string, CancellationToken)
            // Create client
            DatastreamClient datastreamClient = await DatastreamClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            PrivateConnection privateConnection = new PrivateConnection();
            string privateConnectionId = "";
            // Make the request
            Operation<PrivateConnection, OperationMetadata> response = await datastreamClient.CreatePrivateConnectionAsync(parent, privateConnection, privateConnectionId);

            // Poll until the returned long-running operation is complete
            Operation<PrivateConnection, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            PrivateConnection result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PrivateConnection, OperationMetadata> retrievedResponse = await datastreamClient.PollOnceCreatePrivateConnectionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PrivateConnection retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreatePrivateConnection</summary>
        public void CreatePrivateConnectionResourceNames()
        {
            // Snippet: CreatePrivateConnection(LocationName, PrivateConnection, string, CallSettings)
            // Create client
            DatastreamClient datastreamClient = DatastreamClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            PrivateConnection privateConnection = new PrivateConnection();
            string privateConnectionId = "";
            // Make the request
            Operation<PrivateConnection, OperationMetadata> response = datastreamClient.CreatePrivateConnection(parent, privateConnection, privateConnectionId);

            // Poll until the returned long-running operation is complete
            Operation<PrivateConnection, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            PrivateConnection result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PrivateConnection, OperationMetadata> retrievedResponse = datastreamClient.PollOnceCreatePrivateConnection(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PrivateConnection retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreatePrivateConnectionAsync</summary>
        public async Task CreatePrivateConnectionResourceNamesAsync()
        {
            // Snippet: CreatePrivateConnectionAsync(LocationName, PrivateConnection, string, CallSettings)
            // Additional: CreatePrivateConnectionAsync(LocationName, PrivateConnection, string, CancellationToken)
            // Create client
            DatastreamClient datastreamClient = await DatastreamClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            PrivateConnection privateConnection = new PrivateConnection();
            string privateConnectionId = "";
            // Make the request
            Operation<PrivateConnection, OperationMetadata> response = await datastreamClient.CreatePrivateConnectionAsync(parent, privateConnection, privateConnectionId);

            // Poll until the returned long-running operation is complete
            Operation<PrivateConnection, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            PrivateConnection result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PrivateConnection, OperationMetadata> retrievedResponse = await datastreamClient.PollOnceCreatePrivateConnectionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PrivateConnection retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetPrivateConnection</summary>
        public void GetPrivateConnectionRequestObject()
        {
            // Snippet: GetPrivateConnection(GetPrivateConnectionRequest, CallSettings)
            // Create client
            DatastreamClient datastreamClient = DatastreamClient.Create();
            // Initialize request argument(s)
            GetPrivateConnectionRequest request = new GetPrivateConnectionRequest
            {
                PrivateConnectionName = PrivateConnectionName.FromProjectLocationPrivateConnection("[PROJECT]", "[LOCATION]", "[PRIVATE_CONNECTION]"),
            };
            // Make the request
            PrivateConnection response = datastreamClient.GetPrivateConnection(request);
            // End snippet
        }

        /// <summary>Snippet for GetPrivateConnectionAsync</summary>
        public async Task GetPrivateConnectionRequestObjectAsync()
        {
            // Snippet: GetPrivateConnectionAsync(GetPrivateConnectionRequest, CallSettings)
            // Additional: GetPrivateConnectionAsync(GetPrivateConnectionRequest, CancellationToken)
            // Create client
            DatastreamClient datastreamClient = await DatastreamClient.CreateAsync();
            // Initialize request argument(s)
            GetPrivateConnectionRequest request = new GetPrivateConnectionRequest
            {
                PrivateConnectionName = PrivateConnectionName.FromProjectLocationPrivateConnection("[PROJECT]", "[LOCATION]", "[PRIVATE_CONNECTION]"),
            };
            // Make the request
            PrivateConnection response = await datastreamClient.GetPrivateConnectionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetPrivateConnection</summary>
        public void GetPrivateConnection()
        {
            // Snippet: GetPrivateConnection(string, CallSettings)
            // Create client
            DatastreamClient datastreamClient = DatastreamClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/privateConnections/[PRIVATE_CONNECTION]";
            // Make the request
            PrivateConnection response = datastreamClient.GetPrivateConnection(name);
            // End snippet
        }

        /// <summary>Snippet for GetPrivateConnectionAsync</summary>
        public async Task GetPrivateConnectionAsync()
        {
            // Snippet: GetPrivateConnectionAsync(string, CallSettings)
            // Additional: GetPrivateConnectionAsync(string, CancellationToken)
            // Create client
            DatastreamClient datastreamClient = await DatastreamClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/privateConnections/[PRIVATE_CONNECTION]";
            // Make the request
            PrivateConnection response = await datastreamClient.GetPrivateConnectionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetPrivateConnection</summary>
        public void GetPrivateConnectionResourceNames()
        {
            // Snippet: GetPrivateConnection(PrivateConnectionName, CallSettings)
            // Create client
            DatastreamClient datastreamClient = DatastreamClient.Create();
            // Initialize request argument(s)
            PrivateConnectionName name = PrivateConnectionName.FromProjectLocationPrivateConnection("[PROJECT]", "[LOCATION]", "[PRIVATE_CONNECTION]");
            // Make the request
            PrivateConnection response = datastreamClient.GetPrivateConnection(name);
            // End snippet
        }

        /// <summary>Snippet for GetPrivateConnectionAsync</summary>
        public async Task GetPrivateConnectionResourceNamesAsync()
        {
            // Snippet: GetPrivateConnectionAsync(PrivateConnectionName, CallSettings)
            // Additional: GetPrivateConnectionAsync(PrivateConnectionName, CancellationToken)
            // Create client
            DatastreamClient datastreamClient = await DatastreamClient.CreateAsync();
            // Initialize request argument(s)
            PrivateConnectionName name = PrivateConnectionName.FromProjectLocationPrivateConnection("[PROJECT]", "[LOCATION]", "[PRIVATE_CONNECTION]");
            // Make the request
            PrivateConnection response = await datastreamClient.GetPrivateConnectionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListPrivateConnections</summary>
        public void ListPrivateConnectionsRequestObject()
        {
            // Snippet: ListPrivateConnections(ListPrivateConnectionsRequest, CallSettings)
            // Create client
            DatastreamClient datastreamClient = DatastreamClient.Create();
            // Initialize request argument(s)
            ListPrivateConnectionsRequest request = new ListPrivateConnectionsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListPrivateConnectionsResponse, PrivateConnection> response = datastreamClient.ListPrivateConnections(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PrivateConnection item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPrivateConnectionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PrivateConnection item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PrivateConnection> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PrivateConnection item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPrivateConnectionsAsync</summary>
        public async Task ListPrivateConnectionsRequestObjectAsync()
        {
            // Snippet: ListPrivateConnectionsAsync(ListPrivateConnectionsRequest, CallSettings)
            // Create client
            DatastreamClient datastreamClient = await DatastreamClient.CreateAsync();
            // Initialize request argument(s)
            ListPrivateConnectionsRequest request = new ListPrivateConnectionsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListPrivateConnectionsResponse, PrivateConnection> response = datastreamClient.ListPrivateConnectionsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PrivateConnection item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPrivateConnectionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PrivateConnection item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PrivateConnection> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PrivateConnection item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPrivateConnections</summary>
        public void ListPrivateConnections()
        {
            // Snippet: ListPrivateConnections(string, string, int?, CallSettings)
            // Create client
            DatastreamClient datastreamClient = DatastreamClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListPrivateConnectionsResponse, PrivateConnection> response = datastreamClient.ListPrivateConnections(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PrivateConnection item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPrivateConnectionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PrivateConnection item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PrivateConnection> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PrivateConnection item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPrivateConnectionsAsync</summary>
        public async Task ListPrivateConnectionsAsync()
        {
            // Snippet: ListPrivateConnectionsAsync(string, string, int?, CallSettings)
            // Create client
            DatastreamClient datastreamClient = await DatastreamClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListPrivateConnectionsResponse, PrivateConnection> response = datastreamClient.ListPrivateConnectionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PrivateConnection item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPrivateConnectionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PrivateConnection item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PrivateConnection> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PrivateConnection item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPrivateConnections</summary>
        public void ListPrivateConnectionsResourceNames()
        {
            // Snippet: ListPrivateConnections(LocationName, string, int?, CallSettings)
            // Create client
            DatastreamClient datastreamClient = DatastreamClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListPrivateConnectionsResponse, PrivateConnection> response = datastreamClient.ListPrivateConnections(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PrivateConnection item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPrivateConnectionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PrivateConnection item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PrivateConnection> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PrivateConnection item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPrivateConnectionsAsync</summary>
        public async Task ListPrivateConnectionsResourceNamesAsync()
        {
            // Snippet: ListPrivateConnectionsAsync(LocationName, string, int?, CallSettings)
            // Create client
            DatastreamClient datastreamClient = await DatastreamClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListPrivateConnectionsResponse, PrivateConnection> response = datastreamClient.ListPrivateConnectionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PrivateConnection item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPrivateConnectionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PrivateConnection item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PrivateConnection> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PrivateConnection item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DeletePrivateConnection</summary>
        public void DeletePrivateConnectionRequestObject()
        {
            // Snippet: DeletePrivateConnection(DeletePrivateConnectionRequest, CallSettings)
            // Create client
            DatastreamClient datastreamClient = DatastreamClient.Create();
            // Initialize request argument(s)
            DeletePrivateConnectionRequest request = new DeletePrivateConnectionRequest
            {
                PrivateConnectionName = PrivateConnectionName.FromProjectLocationPrivateConnection("[PROJECT]", "[LOCATION]", "[PRIVATE_CONNECTION]"),
                RequestId = "",
                Force = false,
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = datastreamClient.DeletePrivateConnection(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = datastreamClient.PollOnceDeletePrivateConnection(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeletePrivateConnectionAsync</summary>
        public async Task DeletePrivateConnectionRequestObjectAsync()
        {
            // Snippet: DeletePrivateConnectionAsync(DeletePrivateConnectionRequest, CallSettings)
            // Additional: DeletePrivateConnectionAsync(DeletePrivateConnectionRequest, CancellationToken)
            // Create client
            DatastreamClient datastreamClient = await DatastreamClient.CreateAsync();
            // Initialize request argument(s)
            DeletePrivateConnectionRequest request = new DeletePrivateConnectionRequest
            {
                PrivateConnectionName = PrivateConnectionName.FromProjectLocationPrivateConnection("[PROJECT]", "[LOCATION]", "[PRIVATE_CONNECTION]"),
                RequestId = "",
                Force = false,
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await datastreamClient.DeletePrivateConnectionAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await datastreamClient.PollOnceDeletePrivateConnectionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeletePrivateConnection</summary>
        public void DeletePrivateConnection()
        {
            // Snippet: DeletePrivateConnection(string, CallSettings)
            // Create client
            DatastreamClient datastreamClient = DatastreamClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/privateConnections/[PRIVATE_CONNECTION]";
            // Make the request
            Operation<Empty, OperationMetadata> response = datastreamClient.DeletePrivateConnection(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = datastreamClient.PollOnceDeletePrivateConnection(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeletePrivateConnectionAsync</summary>
        public async Task DeletePrivateConnectionAsync()
        {
            // Snippet: DeletePrivateConnectionAsync(string, CallSettings)
            // Additional: DeletePrivateConnectionAsync(string, CancellationToken)
            // Create client
            DatastreamClient datastreamClient = await DatastreamClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/privateConnections/[PRIVATE_CONNECTION]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await datastreamClient.DeletePrivateConnectionAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await datastreamClient.PollOnceDeletePrivateConnectionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeletePrivateConnection</summary>
        public void DeletePrivateConnectionResourceNames()
        {
            // Snippet: DeletePrivateConnection(PrivateConnectionName, CallSettings)
            // Create client
            DatastreamClient datastreamClient = DatastreamClient.Create();
            // Initialize request argument(s)
            PrivateConnectionName name = PrivateConnectionName.FromProjectLocationPrivateConnection("[PROJECT]", "[LOCATION]", "[PRIVATE_CONNECTION]");
            // Make the request
            Operation<Empty, OperationMetadata> response = datastreamClient.DeletePrivateConnection(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = datastreamClient.PollOnceDeletePrivateConnection(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeletePrivateConnectionAsync</summary>
        public async Task DeletePrivateConnectionResourceNamesAsync()
        {
            // Snippet: DeletePrivateConnectionAsync(PrivateConnectionName, CallSettings)
            // Additional: DeletePrivateConnectionAsync(PrivateConnectionName, CancellationToken)
            // Create client
            DatastreamClient datastreamClient = await DatastreamClient.CreateAsync();
            // Initialize request argument(s)
            PrivateConnectionName name = PrivateConnectionName.FromProjectLocationPrivateConnection("[PROJECT]", "[LOCATION]", "[PRIVATE_CONNECTION]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await datastreamClient.DeletePrivateConnectionAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await datastreamClient.PollOnceDeletePrivateConnectionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateRoute</summary>
        public void CreateRouteRequestObject()
        {
            // Snippet: CreateRoute(CreateRouteRequest, CallSettings)
            // Create client
            DatastreamClient datastreamClient = DatastreamClient.Create();
            // Initialize request argument(s)
            CreateRouteRequest request = new CreateRouteRequest
            {
                ParentAsPrivateConnectionName = PrivateConnectionName.FromProjectLocationPrivateConnection("[PROJECT]", "[LOCATION]", "[PRIVATE_CONNECTION]"),
                RouteId = "",
                Route = new Route(),
                RequestId = "",
            };
            // Make the request
            Operation<Route, OperationMetadata> response = datastreamClient.CreateRoute(request);

            // Poll until the returned long-running operation is complete
            Operation<Route, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Route result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Route, OperationMetadata> retrievedResponse = datastreamClient.PollOnceCreateRoute(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Route retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateRouteAsync</summary>
        public async Task CreateRouteRequestObjectAsync()
        {
            // Snippet: CreateRouteAsync(CreateRouteRequest, CallSettings)
            // Additional: CreateRouteAsync(CreateRouteRequest, CancellationToken)
            // Create client
            DatastreamClient datastreamClient = await DatastreamClient.CreateAsync();
            // Initialize request argument(s)
            CreateRouteRequest request = new CreateRouteRequest
            {
                ParentAsPrivateConnectionName = PrivateConnectionName.FromProjectLocationPrivateConnection("[PROJECT]", "[LOCATION]", "[PRIVATE_CONNECTION]"),
                RouteId = "",
                Route = new Route(),
                RequestId = "",
            };
            // Make the request
            Operation<Route, OperationMetadata> response = await datastreamClient.CreateRouteAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Route, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Route result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Route, OperationMetadata> retrievedResponse = await datastreamClient.PollOnceCreateRouteAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Route retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateRoute</summary>
        public void CreateRoute()
        {
            // Snippet: CreateRoute(string, Route, string, CallSettings)
            // Create client
            DatastreamClient datastreamClient = DatastreamClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/privateConnections/[PRIVATE_CONNECTION]";
            Route route = new Route();
            string routeId = "";
            // Make the request
            Operation<Route, OperationMetadata> response = datastreamClient.CreateRoute(parent, route, routeId);

            // Poll until the returned long-running operation is complete
            Operation<Route, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Route result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Route, OperationMetadata> retrievedResponse = datastreamClient.PollOnceCreateRoute(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Route retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateRouteAsync</summary>
        public async Task CreateRouteAsync()
        {
            // Snippet: CreateRouteAsync(string, Route, string, CallSettings)
            // Additional: CreateRouteAsync(string, Route, string, CancellationToken)
            // Create client
            DatastreamClient datastreamClient = await DatastreamClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/privateConnections/[PRIVATE_CONNECTION]";
            Route route = new Route();
            string routeId = "";
            // Make the request
            Operation<Route, OperationMetadata> response = await datastreamClient.CreateRouteAsync(parent, route, routeId);

            // Poll until the returned long-running operation is complete
            Operation<Route, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Route result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Route, OperationMetadata> retrievedResponse = await datastreamClient.PollOnceCreateRouteAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Route retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateRoute</summary>
        public void CreateRouteResourceNames()
        {
            // Snippet: CreateRoute(PrivateConnectionName, Route, string, CallSettings)
            // Create client
            DatastreamClient datastreamClient = DatastreamClient.Create();
            // Initialize request argument(s)
            PrivateConnectionName parent = PrivateConnectionName.FromProjectLocationPrivateConnection("[PROJECT]", "[LOCATION]", "[PRIVATE_CONNECTION]");
            Route route = new Route();
            string routeId = "";
            // Make the request
            Operation<Route, OperationMetadata> response = datastreamClient.CreateRoute(parent, route, routeId);

            // Poll until the returned long-running operation is complete
            Operation<Route, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Route result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Route, OperationMetadata> retrievedResponse = datastreamClient.PollOnceCreateRoute(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Route retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateRouteAsync</summary>
        public async Task CreateRouteResourceNamesAsync()
        {
            // Snippet: CreateRouteAsync(PrivateConnectionName, Route, string, CallSettings)
            // Additional: CreateRouteAsync(PrivateConnectionName, Route, string, CancellationToken)
            // Create client
            DatastreamClient datastreamClient = await DatastreamClient.CreateAsync();
            // Initialize request argument(s)
            PrivateConnectionName parent = PrivateConnectionName.FromProjectLocationPrivateConnection("[PROJECT]", "[LOCATION]", "[PRIVATE_CONNECTION]");
            Route route = new Route();
            string routeId = "";
            // Make the request
            Operation<Route, OperationMetadata> response = await datastreamClient.CreateRouteAsync(parent, route, routeId);

            // Poll until the returned long-running operation is complete
            Operation<Route, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Route result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Route, OperationMetadata> retrievedResponse = await datastreamClient.PollOnceCreateRouteAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Route retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetRoute</summary>
        public void GetRouteRequestObject()
        {
            // Snippet: GetRoute(GetRouteRequest, CallSettings)
            // Create client
            DatastreamClient datastreamClient = DatastreamClient.Create();
            // Initialize request argument(s)
            GetRouteRequest request = new GetRouteRequest
            {
                RouteName = RouteName.FromProjectLocationPrivateConnectionRoute("[PROJECT]", "[LOCATION]", "[PRIVATE_CONNECTION]", "[ROUTE]"),
            };
            // Make the request
            Route response = datastreamClient.GetRoute(request);
            // End snippet
        }

        /// <summary>Snippet for GetRouteAsync</summary>
        public async Task GetRouteRequestObjectAsync()
        {
            // Snippet: GetRouteAsync(GetRouteRequest, CallSettings)
            // Additional: GetRouteAsync(GetRouteRequest, CancellationToken)
            // Create client
            DatastreamClient datastreamClient = await DatastreamClient.CreateAsync();
            // Initialize request argument(s)
            GetRouteRequest request = new GetRouteRequest
            {
                RouteName = RouteName.FromProjectLocationPrivateConnectionRoute("[PROJECT]", "[LOCATION]", "[PRIVATE_CONNECTION]", "[ROUTE]"),
            };
            // Make the request
            Route response = await datastreamClient.GetRouteAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetRoute</summary>
        public void GetRoute()
        {
            // Snippet: GetRoute(string, CallSettings)
            // Create client
            DatastreamClient datastreamClient = DatastreamClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/privateConnections/[PRIVATE_CONNECTION]/routes/[ROUTE]";
            // Make the request
            Route response = datastreamClient.GetRoute(name);
            // End snippet
        }

        /// <summary>Snippet for GetRouteAsync</summary>
        public async Task GetRouteAsync()
        {
            // Snippet: GetRouteAsync(string, CallSettings)
            // Additional: GetRouteAsync(string, CancellationToken)
            // Create client
            DatastreamClient datastreamClient = await DatastreamClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/privateConnections/[PRIVATE_CONNECTION]/routes/[ROUTE]";
            // Make the request
            Route response = await datastreamClient.GetRouteAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetRoute</summary>
        public void GetRouteResourceNames()
        {
            // Snippet: GetRoute(RouteName, CallSettings)
            // Create client
            DatastreamClient datastreamClient = DatastreamClient.Create();
            // Initialize request argument(s)
            RouteName name = RouteName.FromProjectLocationPrivateConnectionRoute("[PROJECT]", "[LOCATION]", "[PRIVATE_CONNECTION]", "[ROUTE]");
            // Make the request
            Route response = datastreamClient.GetRoute(name);
            // End snippet
        }

        /// <summary>Snippet for GetRouteAsync</summary>
        public async Task GetRouteResourceNamesAsync()
        {
            // Snippet: GetRouteAsync(RouteName, CallSettings)
            // Additional: GetRouteAsync(RouteName, CancellationToken)
            // Create client
            DatastreamClient datastreamClient = await DatastreamClient.CreateAsync();
            // Initialize request argument(s)
            RouteName name = RouteName.FromProjectLocationPrivateConnectionRoute("[PROJECT]", "[LOCATION]", "[PRIVATE_CONNECTION]", "[ROUTE]");
            // Make the request
            Route response = await datastreamClient.GetRouteAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListRoutes</summary>
        public void ListRoutesRequestObject()
        {
            // Snippet: ListRoutes(ListRoutesRequest, CallSettings)
            // Create client
            DatastreamClient datastreamClient = DatastreamClient.Create();
            // Initialize request argument(s)
            ListRoutesRequest request = new ListRoutesRequest
            {
                ParentAsPrivateConnectionName = PrivateConnectionName.FromProjectLocationPrivateConnection("[PROJECT]", "[LOCATION]", "[PRIVATE_CONNECTION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListRoutesResponse, Route> response = datastreamClient.ListRoutes(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Route item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRoutesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Route item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Route> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Route item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRoutesAsync</summary>
        public async Task ListRoutesRequestObjectAsync()
        {
            // Snippet: ListRoutesAsync(ListRoutesRequest, CallSettings)
            // Create client
            DatastreamClient datastreamClient = await DatastreamClient.CreateAsync();
            // Initialize request argument(s)
            ListRoutesRequest request = new ListRoutesRequest
            {
                ParentAsPrivateConnectionName = PrivateConnectionName.FromProjectLocationPrivateConnection("[PROJECT]", "[LOCATION]", "[PRIVATE_CONNECTION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListRoutesResponse, Route> response = datastreamClient.ListRoutesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Route item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListRoutesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Route item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Route> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Route item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRoutes</summary>
        public void ListRoutes()
        {
            // Snippet: ListRoutes(string, string, int?, CallSettings)
            // Create client
            DatastreamClient datastreamClient = DatastreamClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/privateConnections/[PRIVATE_CONNECTION]";
            // Make the request
            PagedEnumerable<ListRoutesResponse, Route> response = datastreamClient.ListRoutes(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Route item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRoutesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Route item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Route> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Route item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRoutesAsync</summary>
        public async Task ListRoutesAsync()
        {
            // Snippet: ListRoutesAsync(string, string, int?, CallSettings)
            // Create client
            DatastreamClient datastreamClient = await DatastreamClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/privateConnections/[PRIVATE_CONNECTION]";
            // Make the request
            PagedAsyncEnumerable<ListRoutesResponse, Route> response = datastreamClient.ListRoutesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Route item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListRoutesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Route item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Route> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Route item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRoutes</summary>
        public void ListRoutesResourceNames()
        {
            // Snippet: ListRoutes(PrivateConnectionName, string, int?, CallSettings)
            // Create client
            DatastreamClient datastreamClient = DatastreamClient.Create();
            // Initialize request argument(s)
            PrivateConnectionName parent = PrivateConnectionName.FromProjectLocationPrivateConnection("[PROJECT]", "[LOCATION]", "[PRIVATE_CONNECTION]");
            // Make the request
            PagedEnumerable<ListRoutesResponse, Route> response = datastreamClient.ListRoutes(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Route item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRoutesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Route item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Route> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Route item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRoutesAsync</summary>
        public async Task ListRoutesResourceNamesAsync()
        {
            // Snippet: ListRoutesAsync(PrivateConnectionName, string, int?, CallSettings)
            // Create client
            DatastreamClient datastreamClient = await DatastreamClient.CreateAsync();
            // Initialize request argument(s)
            PrivateConnectionName parent = PrivateConnectionName.FromProjectLocationPrivateConnection("[PROJECT]", "[LOCATION]", "[PRIVATE_CONNECTION]");
            // Make the request
            PagedAsyncEnumerable<ListRoutesResponse, Route> response = datastreamClient.ListRoutesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Route item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListRoutesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Route item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Route> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Route item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DeleteRoute</summary>
        public void DeleteRouteRequestObject()
        {
            // Snippet: DeleteRoute(DeleteRouteRequest, CallSettings)
            // Create client
            DatastreamClient datastreamClient = DatastreamClient.Create();
            // Initialize request argument(s)
            DeleteRouteRequest request = new DeleteRouteRequest
            {
                RouteName = RouteName.FromProjectLocationPrivateConnectionRoute("[PROJECT]", "[LOCATION]", "[PRIVATE_CONNECTION]", "[ROUTE]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = datastreamClient.DeleteRoute(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = datastreamClient.PollOnceDeleteRoute(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteRouteAsync</summary>
        public async Task DeleteRouteRequestObjectAsync()
        {
            // Snippet: DeleteRouteAsync(DeleteRouteRequest, CallSettings)
            // Additional: DeleteRouteAsync(DeleteRouteRequest, CancellationToken)
            // Create client
            DatastreamClient datastreamClient = await DatastreamClient.CreateAsync();
            // Initialize request argument(s)
            DeleteRouteRequest request = new DeleteRouteRequest
            {
                RouteName = RouteName.FromProjectLocationPrivateConnectionRoute("[PROJECT]", "[LOCATION]", "[PRIVATE_CONNECTION]", "[ROUTE]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await datastreamClient.DeleteRouteAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await datastreamClient.PollOnceDeleteRouteAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteRoute</summary>
        public void DeleteRoute()
        {
            // Snippet: DeleteRoute(string, CallSettings)
            // Create client
            DatastreamClient datastreamClient = DatastreamClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/privateConnections/[PRIVATE_CONNECTION]/routes/[ROUTE]";
            // Make the request
            Operation<Empty, OperationMetadata> response = datastreamClient.DeleteRoute(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = datastreamClient.PollOnceDeleteRoute(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteRouteAsync</summary>
        public async Task DeleteRouteAsync()
        {
            // Snippet: DeleteRouteAsync(string, CallSettings)
            // Additional: DeleteRouteAsync(string, CancellationToken)
            // Create client
            DatastreamClient datastreamClient = await DatastreamClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/privateConnections/[PRIVATE_CONNECTION]/routes/[ROUTE]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await datastreamClient.DeleteRouteAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await datastreamClient.PollOnceDeleteRouteAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteRoute</summary>
        public void DeleteRouteResourceNames()
        {
            // Snippet: DeleteRoute(RouteName, CallSettings)
            // Create client
            DatastreamClient datastreamClient = DatastreamClient.Create();
            // Initialize request argument(s)
            RouteName name = RouteName.FromProjectLocationPrivateConnectionRoute("[PROJECT]", "[LOCATION]", "[PRIVATE_CONNECTION]", "[ROUTE]");
            // Make the request
            Operation<Empty, OperationMetadata> response = datastreamClient.DeleteRoute(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = datastreamClient.PollOnceDeleteRoute(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteRouteAsync</summary>
        public async Task DeleteRouteResourceNamesAsync()
        {
            // Snippet: DeleteRouteAsync(RouteName, CallSettings)
            // Additional: DeleteRouteAsync(RouteName, CancellationToken)
            // Create client
            DatastreamClient datastreamClient = await DatastreamClient.CreateAsync();
            // Initialize request argument(s)
            RouteName name = RouteName.FromProjectLocationPrivateConnectionRoute("[PROJECT]", "[LOCATION]", "[PRIVATE_CONNECTION]", "[ROUTE]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await datastreamClient.DeleteRouteAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await datastreamClient.PollOnceDeleteRouteAsync(operationName);
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
