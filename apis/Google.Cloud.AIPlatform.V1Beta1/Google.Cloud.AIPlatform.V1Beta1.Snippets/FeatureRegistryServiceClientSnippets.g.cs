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
    using Google.Cloud.AIPlatform.V1Beta1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedFeatureRegistryServiceClientSnippets
    {
        /// <summary>Snippet for CreateFeatureGroup</summary>
        public void CreateFeatureGroupRequestObject()
        {
            // Snippet: CreateFeatureGroup(CreateFeatureGroupRequest, CallSettings)
            // Create client
            FeatureRegistryServiceClient featureRegistryServiceClient = FeatureRegistryServiceClient.Create();
            // Initialize request argument(s)
            CreateFeatureGroupRequest request = new CreateFeatureGroupRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                FeatureGroup = new FeatureGroup(),
                FeatureGroupId = "",
            };
            // Make the request
            Operation<FeatureGroup, CreateFeatureGroupOperationMetadata> response = featureRegistryServiceClient.CreateFeatureGroup(request);

            // Poll until the returned long-running operation is complete
            Operation<FeatureGroup, CreateFeatureGroupOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            FeatureGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<FeatureGroup, CreateFeatureGroupOperationMetadata> retrievedResponse = featureRegistryServiceClient.PollOnceCreateFeatureGroup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                FeatureGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateFeatureGroupAsync</summary>
        public async Task CreateFeatureGroupRequestObjectAsync()
        {
            // Snippet: CreateFeatureGroupAsync(CreateFeatureGroupRequest, CallSettings)
            // Additional: CreateFeatureGroupAsync(CreateFeatureGroupRequest, CancellationToken)
            // Create client
            FeatureRegistryServiceClient featureRegistryServiceClient = await FeatureRegistryServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateFeatureGroupRequest request = new CreateFeatureGroupRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                FeatureGroup = new FeatureGroup(),
                FeatureGroupId = "",
            };
            // Make the request
            Operation<FeatureGroup, CreateFeatureGroupOperationMetadata> response = await featureRegistryServiceClient.CreateFeatureGroupAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<FeatureGroup, CreateFeatureGroupOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            FeatureGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<FeatureGroup, CreateFeatureGroupOperationMetadata> retrievedResponse = await featureRegistryServiceClient.PollOnceCreateFeatureGroupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                FeatureGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateFeatureGroup</summary>
        public void CreateFeatureGroup()
        {
            // Snippet: CreateFeatureGroup(string, FeatureGroup, string, CallSettings)
            // Create client
            FeatureRegistryServiceClient featureRegistryServiceClient = FeatureRegistryServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            FeatureGroup featureGroup = new FeatureGroup();
            string featureGroupId = "";
            // Make the request
            Operation<FeatureGroup, CreateFeatureGroupOperationMetadata> response = featureRegistryServiceClient.CreateFeatureGroup(parent, featureGroup, featureGroupId);

            // Poll until the returned long-running operation is complete
            Operation<FeatureGroup, CreateFeatureGroupOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            FeatureGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<FeatureGroup, CreateFeatureGroupOperationMetadata> retrievedResponse = featureRegistryServiceClient.PollOnceCreateFeatureGroup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                FeatureGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateFeatureGroupAsync</summary>
        public async Task CreateFeatureGroupAsync()
        {
            // Snippet: CreateFeatureGroupAsync(string, FeatureGroup, string, CallSettings)
            // Additional: CreateFeatureGroupAsync(string, FeatureGroup, string, CancellationToken)
            // Create client
            FeatureRegistryServiceClient featureRegistryServiceClient = await FeatureRegistryServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            FeatureGroup featureGroup = new FeatureGroup();
            string featureGroupId = "";
            // Make the request
            Operation<FeatureGroup, CreateFeatureGroupOperationMetadata> response = await featureRegistryServiceClient.CreateFeatureGroupAsync(parent, featureGroup, featureGroupId);

            // Poll until the returned long-running operation is complete
            Operation<FeatureGroup, CreateFeatureGroupOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            FeatureGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<FeatureGroup, CreateFeatureGroupOperationMetadata> retrievedResponse = await featureRegistryServiceClient.PollOnceCreateFeatureGroupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                FeatureGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateFeatureGroup</summary>
        public void CreateFeatureGroupResourceNames()
        {
            // Snippet: CreateFeatureGroup(LocationName, FeatureGroup, string, CallSettings)
            // Create client
            FeatureRegistryServiceClient featureRegistryServiceClient = FeatureRegistryServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            FeatureGroup featureGroup = new FeatureGroup();
            string featureGroupId = "";
            // Make the request
            Operation<FeatureGroup, CreateFeatureGroupOperationMetadata> response = featureRegistryServiceClient.CreateFeatureGroup(parent, featureGroup, featureGroupId);

            // Poll until the returned long-running operation is complete
            Operation<FeatureGroup, CreateFeatureGroupOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            FeatureGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<FeatureGroup, CreateFeatureGroupOperationMetadata> retrievedResponse = featureRegistryServiceClient.PollOnceCreateFeatureGroup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                FeatureGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateFeatureGroupAsync</summary>
        public async Task CreateFeatureGroupResourceNamesAsync()
        {
            // Snippet: CreateFeatureGroupAsync(LocationName, FeatureGroup, string, CallSettings)
            // Additional: CreateFeatureGroupAsync(LocationName, FeatureGroup, string, CancellationToken)
            // Create client
            FeatureRegistryServiceClient featureRegistryServiceClient = await FeatureRegistryServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            FeatureGroup featureGroup = new FeatureGroup();
            string featureGroupId = "";
            // Make the request
            Operation<FeatureGroup, CreateFeatureGroupOperationMetadata> response = await featureRegistryServiceClient.CreateFeatureGroupAsync(parent, featureGroup, featureGroupId);

            // Poll until the returned long-running operation is complete
            Operation<FeatureGroup, CreateFeatureGroupOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            FeatureGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<FeatureGroup, CreateFeatureGroupOperationMetadata> retrievedResponse = await featureRegistryServiceClient.PollOnceCreateFeatureGroupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                FeatureGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetFeatureGroup</summary>
        public void GetFeatureGroupRequestObject()
        {
            // Snippet: GetFeatureGroup(GetFeatureGroupRequest, CallSettings)
            // Create client
            FeatureRegistryServiceClient featureRegistryServiceClient = FeatureRegistryServiceClient.Create();
            // Initialize request argument(s)
            GetFeatureGroupRequest request = new GetFeatureGroupRequest
            {
                FeatureGroupName = FeatureGroupName.FromProjectLocationFeatureGroup("[PROJECT]", "[LOCATION]", "[FEATURE_GROUP]"),
            };
            // Make the request
            FeatureGroup response = featureRegistryServiceClient.GetFeatureGroup(request);
            // End snippet
        }

        /// <summary>Snippet for GetFeatureGroupAsync</summary>
        public async Task GetFeatureGroupRequestObjectAsync()
        {
            // Snippet: GetFeatureGroupAsync(GetFeatureGroupRequest, CallSettings)
            // Additional: GetFeatureGroupAsync(GetFeatureGroupRequest, CancellationToken)
            // Create client
            FeatureRegistryServiceClient featureRegistryServiceClient = await FeatureRegistryServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetFeatureGroupRequest request = new GetFeatureGroupRequest
            {
                FeatureGroupName = FeatureGroupName.FromProjectLocationFeatureGroup("[PROJECT]", "[LOCATION]", "[FEATURE_GROUP]"),
            };
            // Make the request
            FeatureGroup response = await featureRegistryServiceClient.GetFeatureGroupAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetFeatureGroup</summary>
        public void GetFeatureGroup()
        {
            // Snippet: GetFeatureGroup(string, CallSettings)
            // Create client
            FeatureRegistryServiceClient featureRegistryServiceClient = FeatureRegistryServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/featureGroups/[FEATURE_GROUP]";
            // Make the request
            FeatureGroup response = featureRegistryServiceClient.GetFeatureGroup(name);
            // End snippet
        }

        /// <summary>Snippet for GetFeatureGroupAsync</summary>
        public async Task GetFeatureGroupAsync()
        {
            // Snippet: GetFeatureGroupAsync(string, CallSettings)
            // Additional: GetFeatureGroupAsync(string, CancellationToken)
            // Create client
            FeatureRegistryServiceClient featureRegistryServiceClient = await FeatureRegistryServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/featureGroups/[FEATURE_GROUP]";
            // Make the request
            FeatureGroup response = await featureRegistryServiceClient.GetFeatureGroupAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetFeatureGroup</summary>
        public void GetFeatureGroupResourceNames()
        {
            // Snippet: GetFeatureGroup(FeatureGroupName, CallSettings)
            // Create client
            FeatureRegistryServiceClient featureRegistryServiceClient = FeatureRegistryServiceClient.Create();
            // Initialize request argument(s)
            FeatureGroupName name = FeatureGroupName.FromProjectLocationFeatureGroup("[PROJECT]", "[LOCATION]", "[FEATURE_GROUP]");
            // Make the request
            FeatureGroup response = featureRegistryServiceClient.GetFeatureGroup(name);
            // End snippet
        }

        /// <summary>Snippet for GetFeatureGroupAsync</summary>
        public async Task GetFeatureGroupResourceNamesAsync()
        {
            // Snippet: GetFeatureGroupAsync(FeatureGroupName, CallSettings)
            // Additional: GetFeatureGroupAsync(FeatureGroupName, CancellationToken)
            // Create client
            FeatureRegistryServiceClient featureRegistryServiceClient = await FeatureRegistryServiceClient.CreateAsync();
            // Initialize request argument(s)
            FeatureGroupName name = FeatureGroupName.FromProjectLocationFeatureGroup("[PROJECT]", "[LOCATION]", "[FEATURE_GROUP]");
            // Make the request
            FeatureGroup response = await featureRegistryServiceClient.GetFeatureGroupAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListFeatureGroups</summary>
        public void ListFeatureGroupsRequestObject()
        {
            // Snippet: ListFeatureGroups(ListFeatureGroupsRequest, CallSettings)
            // Create client
            FeatureRegistryServiceClient featureRegistryServiceClient = FeatureRegistryServiceClient.Create();
            // Initialize request argument(s)
            ListFeatureGroupsRequest request = new ListFeatureGroupsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListFeatureGroupsResponse, FeatureGroup> response = featureRegistryServiceClient.ListFeatureGroups(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (FeatureGroup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFeatureGroupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FeatureGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FeatureGroup> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FeatureGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFeatureGroupsAsync</summary>
        public async Task ListFeatureGroupsRequestObjectAsync()
        {
            // Snippet: ListFeatureGroupsAsync(ListFeatureGroupsRequest, CallSettings)
            // Create client
            FeatureRegistryServiceClient featureRegistryServiceClient = await FeatureRegistryServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListFeatureGroupsRequest request = new ListFeatureGroupsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListFeatureGroupsResponse, FeatureGroup> response = featureRegistryServiceClient.ListFeatureGroupsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((FeatureGroup item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListFeatureGroupsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FeatureGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FeatureGroup> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FeatureGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFeatureGroups</summary>
        public void ListFeatureGroups()
        {
            // Snippet: ListFeatureGroups(string, string, int?, CallSettings)
            // Create client
            FeatureRegistryServiceClient featureRegistryServiceClient = FeatureRegistryServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListFeatureGroupsResponse, FeatureGroup> response = featureRegistryServiceClient.ListFeatureGroups(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (FeatureGroup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFeatureGroupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FeatureGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FeatureGroup> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FeatureGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFeatureGroupsAsync</summary>
        public async Task ListFeatureGroupsAsync()
        {
            // Snippet: ListFeatureGroupsAsync(string, string, int?, CallSettings)
            // Create client
            FeatureRegistryServiceClient featureRegistryServiceClient = await FeatureRegistryServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListFeatureGroupsResponse, FeatureGroup> response = featureRegistryServiceClient.ListFeatureGroupsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((FeatureGroup item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListFeatureGroupsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FeatureGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FeatureGroup> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FeatureGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFeatureGroups</summary>
        public void ListFeatureGroupsResourceNames()
        {
            // Snippet: ListFeatureGroups(LocationName, string, int?, CallSettings)
            // Create client
            FeatureRegistryServiceClient featureRegistryServiceClient = FeatureRegistryServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListFeatureGroupsResponse, FeatureGroup> response = featureRegistryServiceClient.ListFeatureGroups(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (FeatureGroup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFeatureGroupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FeatureGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FeatureGroup> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FeatureGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFeatureGroupsAsync</summary>
        public async Task ListFeatureGroupsResourceNamesAsync()
        {
            // Snippet: ListFeatureGroupsAsync(LocationName, string, int?, CallSettings)
            // Create client
            FeatureRegistryServiceClient featureRegistryServiceClient = await FeatureRegistryServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListFeatureGroupsResponse, FeatureGroup> response = featureRegistryServiceClient.ListFeatureGroupsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((FeatureGroup item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListFeatureGroupsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FeatureGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FeatureGroup> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FeatureGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for UpdateFeatureGroup</summary>
        public void UpdateFeatureGroupRequestObject()
        {
            // Snippet: UpdateFeatureGroup(UpdateFeatureGroupRequest, CallSettings)
            // Create client
            FeatureRegistryServiceClient featureRegistryServiceClient = FeatureRegistryServiceClient.Create();
            // Initialize request argument(s)
            UpdateFeatureGroupRequest request = new UpdateFeatureGroupRequest
            {
                FeatureGroup = new FeatureGroup(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<FeatureGroup, UpdateFeatureGroupOperationMetadata> response = featureRegistryServiceClient.UpdateFeatureGroup(request);

            // Poll until the returned long-running operation is complete
            Operation<FeatureGroup, UpdateFeatureGroupOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            FeatureGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<FeatureGroup, UpdateFeatureGroupOperationMetadata> retrievedResponse = featureRegistryServiceClient.PollOnceUpdateFeatureGroup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                FeatureGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateFeatureGroupAsync</summary>
        public async Task UpdateFeatureGroupRequestObjectAsync()
        {
            // Snippet: UpdateFeatureGroupAsync(UpdateFeatureGroupRequest, CallSettings)
            // Additional: UpdateFeatureGroupAsync(UpdateFeatureGroupRequest, CancellationToken)
            // Create client
            FeatureRegistryServiceClient featureRegistryServiceClient = await FeatureRegistryServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateFeatureGroupRequest request = new UpdateFeatureGroupRequest
            {
                FeatureGroup = new FeatureGroup(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<FeatureGroup, UpdateFeatureGroupOperationMetadata> response = await featureRegistryServiceClient.UpdateFeatureGroupAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<FeatureGroup, UpdateFeatureGroupOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            FeatureGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<FeatureGroup, UpdateFeatureGroupOperationMetadata> retrievedResponse = await featureRegistryServiceClient.PollOnceUpdateFeatureGroupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                FeatureGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateFeatureGroup</summary>
        public void UpdateFeatureGroup()
        {
            // Snippet: UpdateFeatureGroup(FeatureGroup, FieldMask, CallSettings)
            // Create client
            FeatureRegistryServiceClient featureRegistryServiceClient = FeatureRegistryServiceClient.Create();
            // Initialize request argument(s)
            FeatureGroup featureGroup = new FeatureGroup();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<FeatureGroup, UpdateFeatureGroupOperationMetadata> response = featureRegistryServiceClient.UpdateFeatureGroup(featureGroup, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<FeatureGroup, UpdateFeatureGroupOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            FeatureGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<FeatureGroup, UpdateFeatureGroupOperationMetadata> retrievedResponse = featureRegistryServiceClient.PollOnceUpdateFeatureGroup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                FeatureGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateFeatureGroupAsync</summary>
        public async Task UpdateFeatureGroupAsync()
        {
            // Snippet: UpdateFeatureGroupAsync(FeatureGroup, FieldMask, CallSettings)
            // Additional: UpdateFeatureGroupAsync(FeatureGroup, FieldMask, CancellationToken)
            // Create client
            FeatureRegistryServiceClient featureRegistryServiceClient = await FeatureRegistryServiceClient.CreateAsync();
            // Initialize request argument(s)
            FeatureGroup featureGroup = new FeatureGroup();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<FeatureGroup, UpdateFeatureGroupOperationMetadata> response = await featureRegistryServiceClient.UpdateFeatureGroupAsync(featureGroup, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<FeatureGroup, UpdateFeatureGroupOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            FeatureGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<FeatureGroup, UpdateFeatureGroupOperationMetadata> retrievedResponse = await featureRegistryServiceClient.PollOnceUpdateFeatureGroupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                FeatureGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteFeatureGroup</summary>
        public void DeleteFeatureGroupRequestObject()
        {
            // Snippet: DeleteFeatureGroup(DeleteFeatureGroupRequest, CallSettings)
            // Create client
            FeatureRegistryServiceClient featureRegistryServiceClient = FeatureRegistryServiceClient.Create();
            // Initialize request argument(s)
            DeleteFeatureGroupRequest request = new DeleteFeatureGroupRequest
            {
                FeatureGroupName = FeatureGroupName.FromProjectLocationFeatureGroup("[PROJECT]", "[LOCATION]", "[FEATURE_GROUP]"),
                Force = false,
            };
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = featureRegistryServiceClient.DeleteFeatureGroup(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = featureRegistryServiceClient.PollOnceDeleteFeatureGroup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteFeatureGroupAsync</summary>
        public async Task DeleteFeatureGroupRequestObjectAsync()
        {
            // Snippet: DeleteFeatureGroupAsync(DeleteFeatureGroupRequest, CallSettings)
            // Additional: DeleteFeatureGroupAsync(DeleteFeatureGroupRequest, CancellationToken)
            // Create client
            FeatureRegistryServiceClient featureRegistryServiceClient = await FeatureRegistryServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteFeatureGroupRequest request = new DeleteFeatureGroupRequest
            {
                FeatureGroupName = FeatureGroupName.FromProjectLocationFeatureGroup("[PROJECT]", "[LOCATION]", "[FEATURE_GROUP]"),
                Force = false,
            };
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await featureRegistryServiceClient.DeleteFeatureGroupAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await featureRegistryServiceClient.PollOnceDeleteFeatureGroupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteFeatureGroup</summary>
        public void DeleteFeatureGroup()
        {
            // Snippet: DeleteFeatureGroup(string, bool, CallSettings)
            // Create client
            FeatureRegistryServiceClient featureRegistryServiceClient = FeatureRegistryServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/featureGroups/[FEATURE_GROUP]";
            bool force = false;
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = featureRegistryServiceClient.DeleteFeatureGroup(name, force);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = featureRegistryServiceClient.PollOnceDeleteFeatureGroup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteFeatureGroupAsync</summary>
        public async Task DeleteFeatureGroupAsync()
        {
            // Snippet: DeleteFeatureGroupAsync(string, bool, CallSettings)
            // Additional: DeleteFeatureGroupAsync(string, bool, CancellationToken)
            // Create client
            FeatureRegistryServiceClient featureRegistryServiceClient = await FeatureRegistryServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/featureGroups/[FEATURE_GROUP]";
            bool force = false;
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await featureRegistryServiceClient.DeleteFeatureGroupAsync(name, force);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await featureRegistryServiceClient.PollOnceDeleteFeatureGroupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteFeatureGroup</summary>
        public void DeleteFeatureGroupResourceNames()
        {
            // Snippet: DeleteFeatureGroup(FeatureGroupName, bool, CallSettings)
            // Create client
            FeatureRegistryServiceClient featureRegistryServiceClient = FeatureRegistryServiceClient.Create();
            // Initialize request argument(s)
            FeatureGroupName name = FeatureGroupName.FromProjectLocationFeatureGroup("[PROJECT]", "[LOCATION]", "[FEATURE_GROUP]");
            bool force = false;
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = featureRegistryServiceClient.DeleteFeatureGroup(name, force);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = featureRegistryServiceClient.PollOnceDeleteFeatureGroup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteFeatureGroupAsync</summary>
        public async Task DeleteFeatureGroupResourceNamesAsync()
        {
            // Snippet: DeleteFeatureGroupAsync(FeatureGroupName, bool, CallSettings)
            // Additional: DeleteFeatureGroupAsync(FeatureGroupName, bool, CancellationToken)
            // Create client
            FeatureRegistryServiceClient featureRegistryServiceClient = await FeatureRegistryServiceClient.CreateAsync();
            // Initialize request argument(s)
            FeatureGroupName name = FeatureGroupName.FromProjectLocationFeatureGroup("[PROJECT]", "[LOCATION]", "[FEATURE_GROUP]");
            bool force = false;
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await featureRegistryServiceClient.DeleteFeatureGroupAsync(name, force);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await featureRegistryServiceClient.PollOnceDeleteFeatureGroupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateFeature</summary>
        public void CreateFeatureRequestObject()
        {
            // Snippet: CreateFeature(CreateFeatureRequest, CallSettings)
            // Create client
            FeatureRegistryServiceClient featureRegistryServiceClient = FeatureRegistryServiceClient.Create();
            // Initialize request argument(s)
            CreateFeatureRequest request = new CreateFeatureRequest
            {
                ParentAsEntityTypeName = EntityTypeName.FromProjectLocationFeaturestoreEntityType("[PROJECT]", "[LOCATION]", "[FEATURESTORE]", "[ENTITY_TYPE]"),
                Feature = new Feature(),
                FeatureId = "",
            };
            // Make the request
            Operation<Feature, CreateFeatureOperationMetadata> response = featureRegistryServiceClient.CreateFeature(request);

            // Poll until the returned long-running operation is complete
            Operation<Feature, CreateFeatureOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Feature result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Feature, CreateFeatureOperationMetadata> retrievedResponse = featureRegistryServiceClient.PollOnceCreateFeature(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Feature retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateFeatureAsync</summary>
        public async Task CreateFeatureRequestObjectAsync()
        {
            // Snippet: CreateFeatureAsync(CreateFeatureRequest, CallSettings)
            // Additional: CreateFeatureAsync(CreateFeatureRequest, CancellationToken)
            // Create client
            FeatureRegistryServiceClient featureRegistryServiceClient = await FeatureRegistryServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateFeatureRequest request = new CreateFeatureRequest
            {
                ParentAsEntityTypeName = EntityTypeName.FromProjectLocationFeaturestoreEntityType("[PROJECT]", "[LOCATION]", "[FEATURESTORE]", "[ENTITY_TYPE]"),
                Feature = new Feature(),
                FeatureId = "",
            };
            // Make the request
            Operation<Feature, CreateFeatureOperationMetadata> response = await featureRegistryServiceClient.CreateFeatureAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Feature, CreateFeatureOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Feature result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Feature, CreateFeatureOperationMetadata> retrievedResponse = await featureRegistryServiceClient.PollOnceCreateFeatureAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Feature retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateFeature</summary>
        public void CreateFeature()
        {
            // Snippet: CreateFeature(string, Feature, string, CallSettings)
            // Create client
            FeatureRegistryServiceClient featureRegistryServiceClient = FeatureRegistryServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/featurestores/[FEATURESTORE]/entityTypes/[ENTITY_TYPE]";
            Feature feature = new Feature();
            string featureId = "";
            // Make the request
            Operation<Feature, CreateFeatureOperationMetadata> response = featureRegistryServiceClient.CreateFeature(parent, feature, featureId);

            // Poll until the returned long-running operation is complete
            Operation<Feature, CreateFeatureOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Feature result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Feature, CreateFeatureOperationMetadata> retrievedResponse = featureRegistryServiceClient.PollOnceCreateFeature(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Feature retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateFeatureAsync</summary>
        public async Task CreateFeatureAsync()
        {
            // Snippet: CreateFeatureAsync(string, Feature, string, CallSettings)
            // Additional: CreateFeatureAsync(string, Feature, string, CancellationToken)
            // Create client
            FeatureRegistryServiceClient featureRegistryServiceClient = await FeatureRegistryServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/featurestores/[FEATURESTORE]/entityTypes/[ENTITY_TYPE]";
            Feature feature = new Feature();
            string featureId = "";
            // Make the request
            Operation<Feature, CreateFeatureOperationMetadata> response = await featureRegistryServiceClient.CreateFeatureAsync(parent, feature, featureId);

            // Poll until the returned long-running operation is complete
            Operation<Feature, CreateFeatureOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Feature result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Feature, CreateFeatureOperationMetadata> retrievedResponse = await featureRegistryServiceClient.PollOnceCreateFeatureAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Feature retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateFeature</summary>
        public void CreateFeatureResourceNames1()
        {
            // Snippet: CreateFeature(EntityTypeName, Feature, string, CallSettings)
            // Create client
            FeatureRegistryServiceClient featureRegistryServiceClient = FeatureRegistryServiceClient.Create();
            // Initialize request argument(s)
            EntityTypeName parent = EntityTypeName.FromProjectLocationFeaturestoreEntityType("[PROJECT]", "[LOCATION]", "[FEATURESTORE]", "[ENTITY_TYPE]");
            Feature feature = new Feature();
            string featureId = "";
            // Make the request
            Operation<Feature, CreateFeatureOperationMetadata> response = featureRegistryServiceClient.CreateFeature(parent, feature, featureId);

            // Poll until the returned long-running operation is complete
            Operation<Feature, CreateFeatureOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Feature result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Feature, CreateFeatureOperationMetadata> retrievedResponse = featureRegistryServiceClient.PollOnceCreateFeature(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Feature retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateFeatureAsync</summary>
        public async Task CreateFeatureResourceNames1Async()
        {
            // Snippet: CreateFeatureAsync(EntityTypeName, Feature, string, CallSettings)
            // Additional: CreateFeatureAsync(EntityTypeName, Feature, string, CancellationToken)
            // Create client
            FeatureRegistryServiceClient featureRegistryServiceClient = await FeatureRegistryServiceClient.CreateAsync();
            // Initialize request argument(s)
            EntityTypeName parent = EntityTypeName.FromProjectLocationFeaturestoreEntityType("[PROJECT]", "[LOCATION]", "[FEATURESTORE]", "[ENTITY_TYPE]");
            Feature feature = new Feature();
            string featureId = "";
            // Make the request
            Operation<Feature, CreateFeatureOperationMetadata> response = await featureRegistryServiceClient.CreateFeatureAsync(parent, feature, featureId);

            // Poll until the returned long-running operation is complete
            Operation<Feature, CreateFeatureOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Feature result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Feature, CreateFeatureOperationMetadata> retrievedResponse = await featureRegistryServiceClient.PollOnceCreateFeatureAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Feature retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateFeature</summary>
        public void CreateFeatureResourceNames2()
        {
            // Snippet: CreateFeature(FeatureGroupName, Feature, string, CallSettings)
            // Create client
            FeatureRegistryServiceClient featureRegistryServiceClient = FeatureRegistryServiceClient.Create();
            // Initialize request argument(s)
            FeatureGroupName parent = FeatureGroupName.FromProjectLocationFeatureGroup("[PROJECT]", "[LOCATION]", "[FEATURE_GROUP]");
            Feature feature = new Feature();
            string featureId = "";
            // Make the request
            Operation<Feature, CreateFeatureOperationMetadata> response = featureRegistryServiceClient.CreateFeature(parent, feature, featureId);

            // Poll until the returned long-running operation is complete
            Operation<Feature, CreateFeatureOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Feature result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Feature, CreateFeatureOperationMetadata> retrievedResponse = featureRegistryServiceClient.PollOnceCreateFeature(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Feature retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateFeatureAsync</summary>
        public async Task CreateFeatureResourceNames2Async()
        {
            // Snippet: CreateFeatureAsync(FeatureGroupName, Feature, string, CallSettings)
            // Additional: CreateFeatureAsync(FeatureGroupName, Feature, string, CancellationToken)
            // Create client
            FeatureRegistryServiceClient featureRegistryServiceClient = await FeatureRegistryServiceClient.CreateAsync();
            // Initialize request argument(s)
            FeatureGroupName parent = FeatureGroupName.FromProjectLocationFeatureGroup("[PROJECT]", "[LOCATION]", "[FEATURE_GROUP]");
            Feature feature = new Feature();
            string featureId = "";
            // Make the request
            Operation<Feature, CreateFeatureOperationMetadata> response = await featureRegistryServiceClient.CreateFeatureAsync(parent, feature, featureId);

            // Poll until the returned long-running operation is complete
            Operation<Feature, CreateFeatureOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Feature result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Feature, CreateFeatureOperationMetadata> retrievedResponse = await featureRegistryServiceClient.PollOnceCreateFeatureAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Feature retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchCreateFeatures</summary>
        public void BatchCreateFeaturesRequestObject()
        {
            // Snippet: BatchCreateFeatures(BatchCreateFeaturesRequest, CallSettings)
            // Create client
            FeatureRegistryServiceClient featureRegistryServiceClient = FeatureRegistryServiceClient.Create();
            // Initialize request argument(s)
            BatchCreateFeaturesRequest request = new BatchCreateFeaturesRequest
            {
                ParentAsEntityTypeName = EntityTypeName.FromProjectLocationFeaturestoreEntityType("[PROJECT]", "[LOCATION]", "[FEATURESTORE]", "[ENTITY_TYPE]"),
                Requests =
                {
                    new CreateFeatureRequest(),
                },
            };
            // Make the request
            Operation<BatchCreateFeaturesResponse, BatchCreateFeaturesOperationMetadata> response = featureRegistryServiceClient.BatchCreateFeatures(request);

            // Poll until the returned long-running operation is complete
            Operation<BatchCreateFeaturesResponse, BatchCreateFeaturesOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BatchCreateFeaturesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchCreateFeaturesResponse, BatchCreateFeaturesOperationMetadata> retrievedResponse = featureRegistryServiceClient.PollOnceBatchCreateFeatures(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchCreateFeaturesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchCreateFeaturesAsync</summary>
        public async Task BatchCreateFeaturesRequestObjectAsync()
        {
            // Snippet: BatchCreateFeaturesAsync(BatchCreateFeaturesRequest, CallSettings)
            // Additional: BatchCreateFeaturesAsync(BatchCreateFeaturesRequest, CancellationToken)
            // Create client
            FeatureRegistryServiceClient featureRegistryServiceClient = await FeatureRegistryServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchCreateFeaturesRequest request = new BatchCreateFeaturesRequest
            {
                ParentAsEntityTypeName = EntityTypeName.FromProjectLocationFeaturestoreEntityType("[PROJECT]", "[LOCATION]", "[FEATURESTORE]", "[ENTITY_TYPE]"),
                Requests =
                {
                    new CreateFeatureRequest(),
                },
            };
            // Make the request
            Operation<BatchCreateFeaturesResponse, BatchCreateFeaturesOperationMetadata> response = await featureRegistryServiceClient.BatchCreateFeaturesAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<BatchCreateFeaturesResponse, BatchCreateFeaturesOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BatchCreateFeaturesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchCreateFeaturesResponse, BatchCreateFeaturesOperationMetadata> retrievedResponse = await featureRegistryServiceClient.PollOnceBatchCreateFeaturesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchCreateFeaturesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchCreateFeatures</summary>
        public void BatchCreateFeatures()
        {
            // Snippet: BatchCreateFeatures(string, IEnumerable<CreateFeatureRequest>, CallSettings)
            // Create client
            FeatureRegistryServiceClient featureRegistryServiceClient = FeatureRegistryServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/featurestores/[FEATURESTORE]/entityTypes/[ENTITY_TYPE]";
            IEnumerable<CreateFeatureRequest> requests = new CreateFeatureRequest[]
            {
                new CreateFeatureRequest(),
            };
            // Make the request
            Operation<BatchCreateFeaturesResponse, BatchCreateFeaturesOperationMetadata> response = featureRegistryServiceClient.BatchCreateFeatures(parent, requests);

            // Poll until the returned long-running operation is complete
            Operation<BatchCreateFeaturesResponse, BatchCreateFeaturesOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BatchCreateFeaturesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchCreateFeaturesResponse, BatchCreateFeaturesOperationMetadata> retrievedResponse = featureRegistryServiceClient.PollOnceBatchCreateFeatures(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchCreateFeaturesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchCreateFeaturesAsync</summary>
        public async Task BatchCreateFeaturesAsync()
        {
            // Snippet: BatchCreateFeaturesAsync(string, IEnumerable<CreateFeatureRequest>, CallSettings)
            // Additional: BatchCreateFeaturesAsync(string, IEnumerable<CreateFeatureRequest>, CancellationToken)
            // Create client
            FeatureRegistryServiceClient featureRegistryServiceClient = await FeatureRegistryServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/featurestores/[FEATURESTORE]/entityTypes/[ENTITY_TYPE]";
            IEnumerable<CreateFeatureRequest> requests = new CreateFeatureRequest[]
            {
                new CreateFeatureRequest(),
            };
            // Make the request
            Operation<BatchCreateFeaturesResponse, BatchCreateFeaturesOperationMetadata> response = await featureRegistryServiceClient.BatchCreateFeaturesAsync(parent, requests);

            // Poll until the returned long-running operation is complete
            Operation<BatchCreateFeaturesResponse, BatchCreateFeaturesOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BatchCreateFeaturesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchCreateFeaturesResponse, BatchCreateFeaturesOperationMetadata> retrievedResponse = await featureRegistryServiceClient.PollOnceBatchCreateFeaturesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchCreateFeaturesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchCreateFeatures</summary>
        public void BatchCreateFeaturesResourceNames1()
        {
            // Snippet: BatchCreateFeatures(EntityTypeName, IEnumerable<CreateFeatureRequest>, CallSettings)
            // Create client
            FeatureRegistryServiceClient featureRegistryServiceClient = FeatureRegistryServiceClient.Create();
            // Initialize request argument(s)
            EntityTypeName parent = EntityTypeName.FromProjectLocationFeaturestoreEntityType("[PROJECT]", "[LOCATION]", "[FEATURESTORE]", "[ENTITY_TYPE]");
            IEnumerable<CreateFeatureRequest> requests = new CreateFeatureRequest[]
            {
                new CreateFeatureRequest(),
            };
            // Make the request
            Operation<BatchCreateFeaturesResponse, BatchCreateFeaturesOperationMetadata> response = featureRegistryServiceClient.BatchCreateFeatures(parent, requests);

            // Poll until the returned long-running operation is complete
            Operation<BatchCreateFeaturesResponse, BatchCreateFeaturesOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BatchCreateFeaturesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchCreateFeaturesResponse, BatchCreateFeaturesOperationMetadata> retrievedResponse = featureRegistryServiceClient.PollOnceBatchCreateFeatures(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchCreateFeaturesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchCreateFeaturesAsync</summary>
        public async Task BatchCreateFeaturesResourceNames1Async()
        {
            // Snippet: BatchCreateFeaturesAsync(EntityTypeName, IEnumerable<CreateFeatureRequest>, CallSettings)
            // Additional: BatchCreateFeaturesAsync(EntityTypeName, IEnumerable<CreateFeatureRequest>, CancellationToken)
            // Create client
            FeatureRegistryServiceClient featureRegistryServiceClient = await FeatureRegistryServiceClient.CreateAsync();
            // Initialize request argument(s)
            EntityTypeName parent = EntityTypeName.FromProjectLocationFeaturestoreEntityType("[PROJECT]", "[LOCATION]", "[FEATURESTORE]", "[ENTITY_TYPE]");
            IEnumerable<CreateFeatureRequest> requests = new CreateFeatureRequest[]
            {
                new CreateFeatureRequest(),
            };
            // Make the request
            Operation<BatchCreateFeaturesResponse, BatchCreateFeaturesOperationMetadata> response = await featureRegistryServiceClient.BatchCreateFeaturesAsync(parent, requests);

            // Poll until the returned long-running operation is complete
            Operation<BatchCreateFeaturesResponse, BatchCreateFeaturesOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BatchCreateFeaturesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchCreateFeaturesResponse, BatchCreateFeaturesOperationMetadata> retrievedResponse = await featureRegistryServiceClient.PollOnceBatchCreateFeaturesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchCreateFeaturesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchCreateFeatures</summary>
        public void BatchCreateFeaturesResourceNames2()
        {
            // Snippet: BatchCreateFeatures(FeatureGroupName, IEnumerable<CreateFeatureRequest>, CallSettings)
            // Create client
            FeatureRegistryServiceClient featureRegistryServiceClient = FeatureRegistryServiceClient.Create();
            // Initialize request argument(s)
            FeatureGroupName parent = FeatureGroupName.FromProjectLocationFeatureGroup("[PROJECT]", "[LOCATION]", "[FEATURE_GROUP]");
            IEnumerable<CreateFeatureRequest> requests = new CreateFeatureRequest[]
            {
                new CreateFeatureRequest(),
            };
            // Make the request
            Operation<BatchCreateFeaturesResponse, BatchCreateFeaturesOperationMetadata> response = featureRegistryServiceClient.BatchCreateFeatures(parent, requests);

            // Poll until the returned long-running operation is complete
            Operation<BatchCreateFeaturesResponse, BatchCreateFeaturesOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BatchCreateFeaturesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchCreateFeaturesResponse, BatchCreateFeaturesOperationMetadata> retrievedResponse = featureRegistryServiceClient.PollOnceBatchCreateFeatures(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchCreateFeaturesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchCreateFeaturesAsync</summary>
        public async Task BatchCreateFeaturesResourceNames2Async()
        {
            // Snippet: BatchCreateFeaturesAsync(FeatureGroupName, IEnumerable<CreateFeatureRequest>, CallSettings)
            // Additional: BatchCreateFeaturesAsync(FeatureGroupName, IEnumerable<CreateFeatureRequest>, CancellationToken)
            // Create client
            FeatureRegistryServiceClient featureRegistryServiceClient = await FeatureRegistryServiceClient.CreateAsync();
            // Initialize request argument(s)
            FeatureGroupName parent = FeatureGroupName.FromProjectLocationFeatureGroup("[PROJECT]", "[LOCATION]", "[FEATURE_GROUP]");
            IEnumerable<CreateFeatureRequest> requests = new CreateFeatureRequest[]
            {
                new CreateFeatureRequest(),
            };
            // Make the request
            Operation<BatchCreateFeaturesResponse, BatchCreateFeaturesOperationMetadata> response = await featureRegistryServiceClient.BatchCreateFeaturesAsync(parent, requests);

            // Poll until the returned long-running operation is complete
            Operation<BatchCreateFeaturesResponse, BatchCreateFeaturesOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BatchCreateFeaturesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchCreateFeaturesResponse, BatchCreateFeaturesOperationMetadata> retrievedResponse = await featureRegistryServiceClient.PollOnceBatchCreateFeaturesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchCreateFeaturesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetFeature</summary>
        public void GetFeatureRequestObject()
        {
            // Snippet: GetFeature(GetFeatureRequest, CallSettings)
            // Create client
            FeatureRegistryServiceClient featureRegistryServiceClient = FeatureRegistryServiceClient.Create();
            // Initialize request argument(s)
            GetFeatureRequest request = new GetFeatureRequest
            {
                FeatureName = FeatureName.FromProjectLocationFeaturestoreEntityTypeFeature("[PROJECT]", "[LOCATION]", "[FEATURESTORE]", "[ENTITY_TYPE]", "[FEATURE]"),
                FeatureStatsAndAnomalySpec = new FeatureStatsAndAnomalySpec(),
            };
            // Make the request
            Feature response = featureRegistryServiceClient.GetFeature(request);
            // End snippet
        }

        /// <summary>Snippet for GetFeatureAsync</summary>
        public async Task GetFeatureRequestObjectAsync()
        {
            // Snippet: GetFeatureAsync(GetFeatureRequest, CallSettings)
            // Additional: GetFeatureAsync(GetFeatureRequest, CancellationToken)
            // Create client
            FeatureRegistryServiceClient featureRegistryServiceClient = await FeatureRegistryServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetFeatureRequest request = new GetFeatureRequest
            {
                FeatureName = FeatureName.FromProjectLocationFeaturestoreEntityTypeFeature("[PROJECT]", "[LOCATION]", "[FEATURESTORE]", "[ENTITY_TYPE]", "[FEATURE]"),
                FeatureStatsAndAnomalySpec = new FeatureStatsAndAnomalySpec(),
            };
            // Make the request
            Feature response = await featureRegistryServiceClient.GetFeatureAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetFeature</summary>
        public void GetFeature()
        {
            // Snippet: GetFeature(string, CallSettings)
            // Create client
            FeatureRegistryServiceClient featureRegistryServiceClient = FeatureRegistryServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/featurestores/[FEATURESTORE]/entityTypes/[ENTITY_TYPE]/features/[FEATURE]";
            // Make the request
            Feature response = featureRegistryServiceClient.GetFeature(name);
            // End snippet
        }

        /// <summary>Snippet for GetFeatureAsync</summary>
        public async Task GetFeatureAsync()
        {
            // Snippet: GetFeatureAsync(string, CallSettings)
            // Additional: GetFeatureAsync(string, CancellationToken)
            // Create client
            FeatureRegistryServiceClient featureRegistryServiceClient = await FeatureRegistryServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/featurestores/[FEATURESTORE]/entityTypes/[ENTITY_TYPE]/features/[FEATURE]";
            // Make the request
            Feature response = await featureRegistryServiceClient.GetFeatureAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetFeature</summary>
        public void GetFeatureResourceNames()
        {
            // Snippet: GetFeature(FeatureName, CallSettings)
            // Create client
            FeatureRegistryServiceClient featureRegistryServiceClient = FeatureRegistryServiceClient.Create();
            // Initialize request argument(s)
            FeatureName name = FeatureName.FromProjectLocationFeaturestoreEntityTypeFeature("[PROJECT]", "[LOCATION]", "[FEATURESTORE]", "[ENTITY_TYPE]", "[FEATURE]");
            // Make the request
            Feature response = featureRegistryServiceClient.GetFeature(name);
            // End snippet
        }

        /// <summary>Snippet for GetFeatureAsync</summary>
        public async Task GetFeatureResourceNamesAsync()
        {
            // Snippet: GetFeatureAsync(FeatureName, CallSettings)
            // Additional: GetFeatureAsync(FeatureName, CancellationToken)
            // Create client
            FeatureRegistryServiceClient featureRegistryServiceClient = await FeatureRegistryServiceClient.CreateAsync();
            // Initialize request argument(s)
            FeatureName name = FeatureName.FromProjectLocationFeaturestoreEntityTypeFeature("[PROJECT]", "[LOCATION]", "[FEATURESTORE]", "[ENTITY_TYPE]", "[FEATURE]");
            // Make the request
            Feature response = await featureRegistryServiceClient.GetFeatureAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListFeatures</summary>
        public void ListFeaturesRequestObject()
        {
            // Snippet: ListFeatures(ListFeaturesRequest, CallSettings)
            // Create client
            FeatureRegistryServiceClient featureRegistryServiceClient = FeatureRegistryServiceClient.Create();
            // Initialize request argument(s)
            ListFeaturesRequest request = new ListFeaturesRequest
            {
                ParentAsEntityTypeName = EntityTypeName.FromProjectLocationFeaturestoreEntityType("[PROJECT]", "[LOCATION]", "[FEATURESTORE]", "[ENTITY_TYPE]"),
                Filter = "",
                OrderBy = "",
                ReadMask = new FieldMask(),
                LatestStatsCount = 0,
            };
            // Make the request
            PagedEnumerable<ListFeaturesResponse, Feature> response = featureRegistryServiceClient.ListFeatures(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Feature item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFeaturesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Feature item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Feature> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Feature item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFeaturesAsync</summary>
        public async Task ListFeaturesRequestObjectAsync()
        {
            // Snippet: ListFeaturesAsync(ListFeaturesRequest, CallSettings)
            // Create client
            FeatureRegistryServiceClient featureRegistryServiceClient = await FeatureRegistryServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListFeaturesRequest request = new ListFeaturesRequest
            {
                ParentAsEntityTypeName = EntityTypeName.FromProjectLocationFeaturestoreEntityType("[PROJECT]", "[LOCATION]", "[FEATURESTORE]", "[ENTITY_TYPE]"),
                Filter = "",
                OrderBy = "",
                ReadMask = new FieldMask(),
                LatestStatsCount = 0,
            };
            // Make the request
            PagedAsyncEnumerable<ListFeaturesResponse, Feature> response = featureRegistryServiceClient.ListFeaturesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Feature item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListFeaturesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Feature item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Feature> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Feature item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFeatures</summary>
        public void ListFeatures()
        {
            // Snippet: ListFeatures(string, string, int?, CallSettings)
            // Create client
            FeatureRegistryServiceClient featureRegistryServiceClient = FeatureRegistryServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/featurestores/[FEATURESTORE]/entityTypes/[ENTITY_TYPE]";
            // Make the request
            PagedEnumerable<ListFeaturesResponse, Feature> response = featureRegistryServiceClient.ListFeatures(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Feature item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFeaturesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Feature item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Feature> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Feature item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFeaturesAsync</summary>
        public async Task ListFeaturesAsync()
        {
            // Snippet: ListFeaturesAsync(string, string, int?, CallSettings)
            // Create client
            FeatureRegistryServiceClient featureRegistryServiceClient = await FeatureRegistryServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/featurestores/[FEATURESTORE]/entityTypes/[ENTITY_TYPE]";
            // Make the request
            PagedAsyncEnumerable<ListFeaturesResponse, Feature> response = featureRegistryServiceClient.ListFeaturesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Feature item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListFeaturesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Feature item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Feature> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Feature item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFeatures</summary>
        public void ListFeaturesResourceNames1()
        {
            // Snippet: ListFeatures(EntityTypeName, string, int?, CallSettings)
            // Create client
            FeatureRegistryServiceClient featureRegistryServiceClient = FeatureRegistryServiceClient.Create();
            // Initialize request argument(s)
            EntityTypeName parent = EntityTypeName.FromProjectLocationFeaturestoreEntityType("[PROJECT]", "[LOCATION]", "[FEATURESTORE]", "[ENTITY_TYPE]");
            // Make the request
            PagedEnumerable<ListFeaturesResponse, Feature> response = featureRegistryServiceClient.ListFeatures(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Feature item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFeaturesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Feature item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Feature> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Feature item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFeaturesAsync</summary>
        public async Task ListFeaturesResourceNames1Async()
        {
            // Snippet: ListFeaturesAsync(EntityTypeName, string, int?, CallSettings)
            // Create client
            FeatureRegistryServiceClient featureRegistryServiceClient = await FeatureRegistryServiceClient.CreateAsync();
            // Initialize request argument(s)
            EntityTypeName parent = EntityTypeName.FromProjectLocationFeaturestoreEntityType("[PROJECT]", "[LOCATION]", "[FEATURESTORE]", "[ENTITY_TYPE]");
            // Make the request
            PagedAsyncEnumerable<ListFeaturesResponse, Feature> response = featureRegistryServiceClient.ListFeaturesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Feature item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListFeaturesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Feature item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Feature> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Feature item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFeatures</summary>
        public void ListFeaturesResourceNames2()
        {
            // Snippet: ListFeatures(FeatureGroupName, string, int?, CallSettings)
            // Create client
            FeatureRegistryServiceClient featureRegistryServiceClient = FeatureRegistryServiceClient.Create();
            // Initialize request argument(s)
            FeatureGroupName parent = FeatureGroupName.FromProjectLocationFeatureGroup("[PROJECT]", "[LOCATION]", "[FEATURE_GROUP]");
            // Make the request
            PagedEnumerable<ListFeaturesResponse, Feature> response = featureRegistryServiceClient.ListFeatures(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Feature item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFeaturesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Feature item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Feature> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Feature item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFeaturesAsync</summary>
        public async Task ListFeaturesResourceNames2Async()
        {
            // Snippet: ListFeaturesAsync(FeatureGroupName, string, int?, CallSettings)
            // Create client
            FeatureRegistryServiceClient featureRegistryServiceClient = await FeatureRegistryServiceClient.CreateAsync();
            // Initialize request argument(s)
            FeatureGroupName parent = FeatureGroupName.FromProjectLocationFeatureGroup("[PROJECT]", "[LOCATION]", "[FEATURE_GROUP]");
            // Make the request
            PagedAsyncEnumerable<ListFeaturesResponse, Feature> response = featureRegistryServiceClient.ListFeaturesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Feature item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListFeaturesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Feature item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Feature> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Feature item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for UpdateFeature</summary>
        public void UpdateFeatureRequestObject()
        {
            // Snippet: UpdateFeature(UpdateFeatureRequest, CallSettings)
            // Create client
            FeatureRegistryServiceClient featureRegistryServiceClient = FeatureRegistryServiceClient.Create();
            // Initialize request argument(s)
            UpdateFeatureRequest request = new UpdateFeatureRequest
            {
                Feature = new Feature(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<Feature, UpdateFeatureOperationMetadata> response = featureRegistryServiceClient.UpdateFeature(request);

            // Poll until the returned long-running operation is complete
            Operation<Feature, UpdateFeatureOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Feature result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Feature, UpdateFeatureOperationMetadata> retrievedResponse = featureRegistryServiceClient.PollOnceUpdateFeature(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Feature retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateFeatureAsync</summary>
        public async Task UpdateFeatureRequestObjectAsync()
        {
            // Snippet: UpdateFeatureAsync(UpdateFeatureRequest, CallSettings)
            // Additional: UpdateFeatureAsync(UpdateFeatureRequest, CancellationToken)
            // Create client
            FeatureRegistryServiceClient featureRegistryServiceClient = await FeatureRegistryServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateFeatureRequest request = new UpdateFeatureRequest
            {
                Feature = new Feature(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<Feature, UpdateFeatureOperationMetadata> response = await featureRegistryServiceClient.UpdateFeatureAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Feature, UpdateFeatureOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Feature result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Feature, UpdateFeatureOperationMetadata> retrievedResponse = await featureRegistryServiceClient.PollOnceUpdateFeatureAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Feature retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateFeature</summary>
        public void UpdateFeature()
        {
            // Snippet: UpdateFeature(Feature, FieldMask, CallSettings)
            // Create client
            FeatureRegistryServiceClient featureRegistryServiceClient = FeatureRegistryServiceClient.Create();
            // Initialize request argument(s)
            Feature feature = new Feature();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Feature, UpdateFeatureOperationMetadata> response = featureRegistryServiceClient.UpdateFeature(feature, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Feature, UpdateFeatureOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Feature result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Feature, UpdateFeatureOperationMetadata> retrievedResponse = featureRegistryServiceClient.PollOnceUpdateFeature(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Feature retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateFeatureAsync</summary>
        public async Task UpdateFeatureAsync()
        {
            // Snippet: UpdateFeatureAsync(Feature, FieldMask, CallSettings)
            // Additional: UpdateFeatureAsync(Feature, FieldMask, CancellationToken)
            // Create client
            FeatureRegistryServiceClient featureRegistryServiceClient = await FeatureRegistryServiceClient.CreateAsync();
            // Initialize request argument(s)
            Feature feature = new Feature();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Feature, UpdateFeatureOperationMetadata> response = await featureRegistryServiceClient.UpdateFeatureAsync(feature, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Feature, UpdateFeatureOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Feature result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Feature, UpdateFeatureOperationMetadata> retrievedResponse = await featureRegistryServiceClient.PollOnceUpdateFeatureAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Feature retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteFeature</summary>
        public void DeleteFeatureRequestObject()
        {
            // Snippet: DeleteFeature(DeleteFeatureRequest, CallSettings)
            // Create client
            FeatureRegistryServiceClient featureRegistryServiceClient = FeatureRegistryServiceClient.Create();
            // Initialize request argument(s)
            DeleteFeatureRequest request = new DeleteFeatureRequest
            {
                FeatureName = FeatureName.FromProjectLocationFeaturestoreEntityTypeFeature("[PROJECT]", "[LOCATION]", "[FEATURESTORE]", "[ENTITY_TYPE]", "[FEATURE]"),
            };
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = featureRegistryServiceClient.DeleteFeature(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = featureRegistryServiceClient.PollOnceDeleteFeature(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteFeatureAsync</summary>
        public async Task DeleteFeatureRequestObjectAsync()
        {
            // Snippet: DeleteFeatureAsync(DeleteFeatureRequest, CallSettings)
            // Additional: DeleteFeatureAsync(DeleteFeatureRequest, CancellationToken)
            // Create client
            FeatureRegistryServiceClient featureRegistryServiceClient = await FeatureRegistryServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteFeatureRequest request = new DeleteFeatureRequest
            {
                FeatureName = FeatureName.FromProjectLocationFeaturestoreEntityTypeFeature("[PROJECT]", "[LOCATION]", "[FEATURESTORE]", "[ENTITY_TYPE]", "[FEATURE]"),
            };
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await featureRegistryServiceClient.DeleteFeatureAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await featureRegistryServiceClient.PollOnceDeleteFeatureAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteFeature</summary>
        public void DeleteFeature()
        {
            // Snippet: DeleteFeature(string, CallSettings)
            // Create client
            FeatureRegistryServiceClient featureRegistryServiceClient = FeatureRegistryServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/featurestores/[FEATURESTORE]/entityTypes/[ENTITY_TYPE]/features/[FEATURE]";
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = featureRegistryServiceClient.DeleteFeature(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = featureRegistryServiceClient.PollOnceDeleteFeature(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteFeatureAsync</summary>
        public async Task DeleteFeatureAsync()
        {
            // Snippet: DeleteFeatureAsync(string, CallSettings)
            // Additional: DeleteFeatureAsync(string, CancellationToken)
            // Create client
            FeatureRegistryServiceClient featureRegistryServiceClient = await FeatureRegistryServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/featurestores/[FEATURESTORE]/entityTypes/[ENTITY_TYPE]/features/[FEATURE]";
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await featureRegistryServiceClient.DeleteFeatureAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await featureRegistryServiceClient.PollOnceDeleteFeatureAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteFeature</summary>
        public void DeleteFeatureResourceNames()
        {
            // Snippet: DeleteFeature(FeatureName, CallSettings)
            // Create client
            FeatureRegistryServiceClient featureRegistryServiceClient = FeatureRegistryServiceClient.Create();
            // Initialize request argument(s)
            FeatureName name = FeatureName.FromProjectLocationFeaturestoreEntityTypeFeature("[PROJECT]", "[LOCATION]", "[FEATURESTORE]", "[ENTITY_TYPE]", "[FEATURE]");
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = featureRegistryServiceClient.DeleteFeature(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = featureRegistryServiceClient.PollOnceDeleteFeature(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteFeatureAsync</summary>
        public async Task DeleteFeatureResourceNamesAsync()
        {
            // Snippet: DeleteFeatureAsync(FeatureName, CallSettings)
            // Additional: DeleteFeatureAsync(FeatureName, CancellationToken)
            // Create client
            FeatureRegistryServiceClient featureRegistryServiceClient = await FeatureRegistryServiceClient.CreateAsync();
            // Initialize request argument(s)
            FeatureName name = FeatureName.FromProjectLocationFeaturestoreEntityTypeFeature("[PROJECT]", "[LOCATION]", "[FEATURESTORE]", "[ENTITY_TYPE]", "[FEATURE]");
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await featureRegistryServiceClient.DeleteFeatureAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await featureRegistryServiceClient.PollOnceDeleteFeatureAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateFeatureMonitor</summary>
        public void CreateFeatureMonitorRequestObject()
        {
            // Snippet: CreateFeatureMonitor(CreateFeatureMonitorRequest, CallSettings)
            // Create client
            FeatureRegistryServiceClient featureRegistryServiceClient = FeatureRegistryServiceClient.Create();
            // Initialize request argument(s)
            CreateFeatureMonitorRequest request = new CreateFeatureMonitorRequest
            {
                ParentAsFeatureGroupName = FeatureGroupName.FromProjectLocationFeatureGroup("[PROJECT]", "[LOCATION]", "[FEATURE_GROUP]"),
                FeatureMonitor = new FeatureMonitor(),
                FeatureMonitorId = "",
            };
            // Make the request
            Operation<FeatureMonitor, CreateFeatureMonitorOperationMetadata> response = featureRegistryServiceClient.CreateFeatureMonitor(request);

            // Poll until the returned long-running operation is complete
            Operation<FeatureMonitor, CreateFeatureMonitorOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            FeatureMonitor result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<FeatureMonitor, CreateFeatureMonitorOperationMetadata> retrievedResponse = featureRegistryServiceClient.PollOnceCreateFeatureMonitor(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                FeatureMonitor retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateFeatureMonitorAsync</summary>
        public async Task CreateFeatureMonitorRequestObjectAsync()
        {
            // Snippet: CreateFeatureMonitorAsync(CreateFeatureMonitorRequest, CallSettings)
            // Additional: CreateFeatureMonitorAsync(CreateFeatureMonitorRequest, CancellationToken)
            // Create client
            FeatureRegistryServiceClient featureRegistryServiceClient = await FeatureRegistryServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateFeatureMonitorRequest request = new CreateFeatureMonitorRequest
            {
                ParentAsFeatureGroupName = FeatureGroupName.FromProjectLocationFeatureGroup("[PROJECT]", "[LOCATION]", "[FEATURE_GROUP]"),
                FeatureMonitor = new FeatureMonitor(),
                FeatureMonitorId = "",
            };
            // Make the request
            Operation<FeatureMonitor, CreateFeatureMonitorOperationMetadata> response = await featureRegistryServiceClient.CreateFeatureMonitorAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<FeatureMonitor, CreateFeatureMonitorOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            FeatureMonitor result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<FeatureMonitor, CreateFeatureMonitorOperationMetadata> retrievedResponse = await featureRegistryServiceClient.PollOnceCreateFeatureMonitorAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                FeatureMonitor retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateFeatureMonitor</summary>
        public void CreateFeatureMonitor()
        {
            // Snippet: CreateFeatureMonitor(string, FeatureMonitor, string, CallSettings)
            // Create client
            FeatureRegistryServiceClient featureRegistryServiceClient = FeatureRegistryServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/featureGroups/[FEATURE_GROUP]";
            FeatureMonitor featureMonitor = new FeatureMonitor();
            string featureMonitorId = "";
            // Make the request
            Operation<FeatureMonitor, CreateFeatureMonitorOperationMetadata> response = featureRegistryServiceClient.CreateFeatureMonitor(parent, featureMonitor, featureMonitorId);

            // Poll until the returned long-running operation is complete
            Operation<FeatureMonitor, CreateFeatureMonitorOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            FeatureMonitor result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<FeatureMonitor, CreateFeatureMonitorOperationMetadata> retrievedResponse = featureRegistryServiceClient.PollOnceCreateFeatureMonitor(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                FeatureMonitor retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateFeatureMonitorAsync</summary>
        public async Task CreateFeatureMonitorAsync()
        {
            // Snippet: CreateFeatureMonitorAsync(string, FeatureMonitor, string, CallSettings)
            // Additional: CreateFeatureMonitorAsync(string, FeatureMonitor, string, CancellationToken)
            // Create client
            FeatureRegistryServiceClient featureRegistryServiceClient = await FeatureRegistryServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/featureGroups/[FEATURE_GROUP]";
            FeatureMonitor featureMonitor = new FeatureMonitor();
            string featureMonitorId = "";
            // Make the request
            Operation<FeatureMonitor, CreateFeatureMonitorOperationMetadata> response = await featureRegistryServiceClient.CreateFeatureMonitorAsync(parent, featureMonitor, featureMonitorId);

            // Poll until the returned long-running operation is complete
            Operation<FeatureMonitor, CreateFeatureMonitorOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            FeatureMonitor result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<FeatureMonitor, CreateFeatureMonitorOperationMetadata> retrievedResponse = await featureRegistryServiceClient.PollOnceCreateFeatureMonitorAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                FeatureMonitor retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateFeatureMonitor</summary>
        public void CreateFeatureMonitorResourceNames()
        {
            // Snippet: CreateFeatureMonitor(FeatureGroupName, FeatureMonitor, string, CallSettings)
            // Create client
            FeatureRegistryServiceClient featureRegistryServiceClient = FeatureRegistryServiceClient.Create();
            // Initialize request argument(s)
            FeatureGroupName parent = FeatureGroupName.FromProjectLocationFeatureGroup("[PROJECT]", "[LOCATION]", "[FEATURE_GROUP]");
            FeatureMonitor featureMonitor = new FeatureMonitor();
            string featureMonitorId = "";
            // Make the request
            Operation<FeatureMonitor, CreateFeatureMonitorOperationMetadata> response = featureRegistryServiceClient.CreateFeatureMonitor(parent, featureMonitor, featureMonitorId);

            // Poll until the returned long-running operation is complete
            Operation<FeatureMonitor, CreateFeatureMonitorOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            FeatureMonitor result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<FeatureMonitor, CreateFeatureMonitorOperationMetadata> retrievedResponse = featureRegistryServiceClient.PollOnceCreateFeatureMonitor(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                FeatureMonitor retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateFeatureMonitorAsync</summary>
        public async Task CreateFeatureMonitorResourceNamesAsync()
        {
            // Snippet: CreateFeatureMonitorAsync(FeatureGroupName, FeatureMonitor, string, CallSettings)
            // Additional: CreateFeatureMonitorAsync(FeatureGroupName, FeatureMonitor, string, CancellationToken)
            // Create client
            FeatureRegistryServiceClient featureRegistryServiceClient = await FeatureRegistryServiceClient.CreateAsync();
            // Initialize request argument(s)
            FeatureGroupName parent = FeatureGroupName.FromProjectLocationFeatureGroup("[PROJECT]", "[LOCATION]", "[FEATURE_GROUP]");
            FeatureMonitor featureMonitor = new FeatureMonitor();
            string featureMonitorId = "";
            // Make the request
            Operation<FeatureMonitor, CreateFeatureMonitorOperationMetadata> response = await featureRegistryServiceClient.CreateFeatureMonitorAsync(parent, featureMonitor, featureMonitorId);

            // Poll until the returned long-running operation is complete
            Operation<FeatureMonitor, CreateFeatureMonitorOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            FeatureMonitor result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<FeatureMonitor, CreateFeatureMonitorOperationMetadata> retrievedResponse = await featureRegistryServiceClient.PollOnceCreateFeatureMonitorAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                FeatureMonitor retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetFeatureMonitor</summary>
        public void GetFeatureMonitorRequestObject()
        {
            // Snippet: GetFeatureMonitor(GetFeatureMonitorRequest, CallSettings)
            // Create client
            FeatureRegistryServiceClient featureRegistryServiceClient = FeatureRegistryServiceClient.Create();
            // Initialize request argument(s)
            GetFeatureMonitorRequest request = new GetFeatureMonitorRequest
            {
                FeatureMonitorName = FeatureMonitorName.FromProjectLocationFeatureGroupFeatureMonitor("[PROJECT]", "[LOCATION]", "[FEATURE_GROUP]", "[FEATURE_MONITOR]"),
            };
            // Make the request
            FeatureMonitor response = featureRegistryServiceClient.GetFeatureMonitor(request);
            // End snippet
        }

        /// <summary>Snippet for GetFeatureMonitorAsync</summary>
        public async Task GetFeatureMonitorRequestObjectAsync()
        {
            // Snippet: GetFeatureMonitorAsync(GetFeatureMonitorRequest, CallSettings)
            // Additional: GetFeatureMonitorAsync(GetFeatureMonitorRequest, CancellationToken)
            // Create client
            FeatureRegistryServiceClient featureRegistryServiceClient = await FeatureRegistryServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetFeatureMonitorRequest request = new GetFeatureMonitorRequest
            {
                FeatureMonitorName = FeatureMonitorName.FromProjectLocationFeatureGroupFeatureMonitor("[PROJECT]", "[LOCATION]", "[FEATURE_GROUP]", "[FEATURE_MONITOR]"),
            };
            // Make the request
            FeatureMonitor response = await featureRegistryServiceClient.GetFeatureMonitorAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetFeatureMonitor</summary>
        public void GetFeatureMonitor()
        {
            // Snippet: GetFeatureMonitor(string, CallSettings)
            // Create client
            FeatureRegistryServiceClient featureRegistryServiceClient = FeatureRegistryServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/featureGroups/[FEATURE_GROUP]/featureMonitors/[FEATURE_MONITOR]";
            // Make the request
            FeatureMonitor response = featureRegistryServiceClient.GetFeatureMonitor(name);
            // End snippet
        }

        /// <summary>Snippet for GetFeatureMonitorAsync</summary>
        public async Task GetFeatureMonitorAsync()
        {
            // Snippet: GetFeatureMonitorAsync(string, CallSettings)
            // Additional: GetFeatureMonitorAsync(string, CancellationToken)
            // Create client
            FeatureRegistryServiceClient featureRegistryServiceClient = await FeatureRegistryServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/featureGroups/[FEATURE_GROUP]/featureMonitors/[FEATURE_MONITOR]";
            // Make the request
            FeatureMonitor response = await featureRegistryServiceClient.GetFeatureMonitorAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetFeatureMonitor</summary>
        public void GetFeatureMonitorResourceNames()
        {
            // Snippet: GetFeatureMonitor(FeatureMonitorName, CallSettings)
            // Create client
            FeatureRegistryServiceClient featureRegistryServiceClient = FeatureRegistryServiceClient.Create();
            // Initialize request argument(s)
            FeatureMonitorName name = FeatureMonitorName.FromProjectLocationFeatureGroupFeatureMonitor("[PROJECT]", "[LOCATION]", "[FEATURE_GROUP]", "[FEATURE_MONITOR]");
            // Make the request
            FeatureMonitor response = featureRegistryServiceClient.GetFeatureMonitor(name);
            // End snippet
        }

        /// <summary>Snippet for GetFeatureMonitorAsync</summary>
        public async Task GetFeatureMonitorResourceNamesAsync()
        {
            // Snippet: GetFeatureMonitorAsync(FeatureMonitorName, CallSettings)
            // Additional: GetFeatureMonitorAsync(FeatureMonitorName, CancellationToken)
            // Create client
            FeatureRegistryServiceClient featureRegistryServiceClient = await FeatureRegistryServiceClient.CreateAsync();
            // Initialize request argument(s)
            FeatureMonitorName name = FeatureMonitorName.FromProjectLocationFeatureGroupFeatureMonitor("[PROJECT]", "[LOCATION]", "[FEATURE_GROUP]", "[FEATURE_MONITOR]");
            // Make the request
            FeatureMonitor response = await featureRegistryServiceClient.GetFeatureMonitorAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListFeatureMonitors</summary>
        public void ListFeatureMonitorsRequestObject()
        {
            // Snippet: ListFeatureMonitors(ListFeatureMonitorsRequest, CallSettings)
            // Create client
            FeatureRegistryServiceClient featureRegistryServiceClient = FeatureRegistryServiceClient.Create();
            // Initialize request argument(s)
            ListFeatureMonitorsRequest request = new ListFeatureMonitorsRequest
            {
                ParentAsFeatureGroupName = FeatureGroupName.FromProjectLocationFeatureGroup("[PROJECT]", "[LOCATION]", "[FEATURE_GROUP]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListFeatureMonitorsResponse, FeatureMonitor> response = featureRegistryServiceClient.ListFeatureMonitors(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (FeatureMonitor item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFeatureMonitorsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FeatureMonitor item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FeatureMonitor> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FeatureMonitor item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFeatureMonitorsAsync</summary>
        public async Task ListFeatureMonitorsRequestObjectAsync()
        {
            // Snippet: ListFeatureMonitorsAsync(ListFeatureMonitorsRequest, CallSettings)
            // Create client
            FeatureRegistryServiceClient featureRegistryServiceClient = await FeatureRegistryServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListFeatureMonitorsRequest request = new ListFeatureMonitorsRequest
            {
                ParentAsFeatureGroupName = FeatureGroupName.FromProjectLocationFeatureGroup("[PROJECT]", "[LOCATION]", "[FEATURE_GROUP]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListFeatureMonitorsResponse, FeatureMonitor> response = featureRegistryServiceClient.ListFeatureMonitorsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((FeatureMonitor item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListFeatureMonitorsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FeatureMonitor item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FeatureMonitor> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FeatureMonitor item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFeatureMonitors</summary>
        public void ListFeatureMonitors()
        {
            // Snippet: ListFeatureMonitors(string, string, int?, CallSettings)
            // Create client
            FeatureRegistryServiceClient featureRegistryServiceClient = FeatureRegistryServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/featureGroups/[FEATURE_GROUP]";
            // Make the request
            PagedEnumerable<ListFeatureMonitorsResponse, FeatureMonitor> response = featureRegistryServiceClient.ListFeatureMonitors(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (FeatureMonitor item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFeatureMonitorsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FeatureMonitor item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FeatureMonitor> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FeatureMonitor item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFeatureMonitorsAsync</summary>
        public async Task ListFeatureMonitorsAsync()
        {
            // Snippet: ListFeatureMonitorsAsync(string, string, int?, CallSettings)
            // Create client
            FeatureRegistryServiceClient featureRegistryServiceClient = await FeatureRegistryServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/featureGroups/[FEATURE_GROUP]";
            // Make the request
            PagedAsyncEnumerable<ListFeatureMonitorsResponse, FeatureMonitor> response = featureRegistryServiceClient.ListFeatureMonitorsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((FeatureMonitor item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListFeatureMonitorsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FeatureMonitor item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FeatureMonitor> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FeatureMonitor item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFeatureMonitors</summary>
        public void ListFeatureMonitorsResourceNames()
        {
            // Snippet: ListFeatureMonitors(FeatureGroupName, string, int?, CallSettings)
            // Create client
            FeatureRegistryServiceClient featureRegistryServiceClient = FeatureRegistryServiceClient.Create();
            // Initialize request argument(s)
            FeatureGroupName parent = FeatureGroupName.FromProjectLocationFeatureGroup("[PROJECT]", "[LOCATION]", "[FEATURE_GROUP]");
            // Make the request
            PagedEnumerable<ListFeatureMonitorsResponse, FeatureMonitor> response = featureRegistryServiceClient.ListFeatureMonitors(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (FeatureMonitor item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFeatureMonitorsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FeatureMonitor item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FeatureMonitor> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FeatureMonitor item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFeatureMonitorsAsync</summary>
        public async Task ListFeatureMonitorsResourceNamesAsync()
        {
            // Snippet: ListFeatureMonitorsAsync(FeatureGroupName, string, int?, CallSettings)
            // Create client
            FeatureRegistryServiceClient featureRegistryServiceClient = await FeatureRegistryServiceClient.CreateAsync();
            // Initialize request argument(s)
            FeatureGroupName parent = FeatureGroupName.FromProjectLocationFeatureGroup("[PROJECT]", "[LOCATION]", "[FEATURE_GROUP]");
            // Make the request
            PagedAsyncEnumerable<ListFeatureMonitorsResponse, FeatureMonitor> response = featureRegistryServiceClient.ListFeatureMonitorsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((FeatureMonitor item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListFeatureMonitorsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FeatureMonitor item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FeatureMonitor> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FeatureMonitor item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DeleteFeatureMonitor</summary>
        public void DeleteFeatureMonitorRequestObject()
        {
            // Snippet: DeleteFeatureMonitor(DeleteFeatureMonitorRequest, CallSettings)
            // Create client
            FeatureRegistryServiceClient featureRegistryServiceClient = FeatureRegistryServiceClient.Create();
            // Initialize request argument(s)
            DeleteFeatureMonitorRequest request = new DeleteFeatureMonitorRequest
            {
                FeatureMonitorName = FeatureMonitorName.FromProjectLocationFeatureGroupFeatureMonitor("[PROJECT]", "[LOCATION]", "[FEATURE_GROUP]", "[FEATURE_MONITOR]"),
            };
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = featureRegistryServiceClient.DeleteFeatureMonitor(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = featureRegistryServiceClient.PollOnceDeleteFeatureMonitor(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteFeatureMonitorAsync</summary>
        public async Task DeleteFeatureMonitorRequestObjectAsync()
        {
            // Snippet: DeleteFeatureMonitorAsync(DeleteFeatureMonitorRequest, CallSettings)
            // Additional: DeleteFeatureMonitorAsync(DeleteFeatureMonitorRequest, CancellationToken)
            // Create client
            FeatureRegistryServiceClient featureRegistryServiceClient = await FeatureRegistryServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteFeatureMonitorRequest request = new DeleteFeatureMonitorRequest
            {
                FeatureMonitorName = FeatureMonitorName.FromProjectLocationFeatureGroupFeatureMonitor("[PROJECT]", "[LOCATION]", "[FEATURE_GROUP]", "[FEATURE_MONITOR]"),
            };
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await featureRegistryServiceClient.DeleteFeatureMonitorAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await featureRegistryServiceClient.PollOnceDeleteFeatureMonitorAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteFeatureMonitor</summary>
        public void DeleteFeatureMonitor()
        {
            // Snippet: DeleteFeatureMonitor(string, CallSettings)
            // Create client
            FeatureRegistryServiceClient featureRegistryServiceClient = FeatureRegistryServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/featureGroups/[FEATURE_GROUP]/featureMonitors/[FEATURE_MONITOR]";
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = featureRegistryServiceClient.DeleteFeatureMonitor(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = featureRegistryServiceClient.PollOnceDeleteFeatureMonitor(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteFeatureMonitorAsync</summary>
        public async Task DeleteFeatureMonitorAsync()
        {
            // Snippet: DeleteFeatureMonitorAsync(string, CallSettings)
            // Additional: DeleteFeatureMonitorAsync(string, CancellationToken)
            // Create client
            FeatureRegistryServiceClient featureRegistryServiceClient = await FeatureRegistryServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/featureGroups/[FEATURE_GROUP]/featureMonitors/[FEATURE_MONITOR]";
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await featureRegistryServiceClient.DeleteFeatureMonitorAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await featureRegistryServiceClient.PollOnceDeleteFeatureMonitorAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteFeatureMonitor</summary>
        public void DeleteFeatureMonitorResourceNames()
        {
            // Snippet: DeleteFeatureMonitor(FeatureMonitorName, CallSettings)
            // Create client
            FeatureRegistryServiceClient featureRegistryServiceClient = FeatureRegistryServiceClient.Create();
            // Initialize request argument(s)
            FeatureMonitorName name = FeatureMonitorName.FromProjectLocationFeatureGroupFeatureMonitor("[PROJECT]", "[LOCATION]", "[FEATURE_GROUP]", "[FEATURE_MONITOR]");
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = featureRegistryServiceClient.DeleteFeatureMonitor(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = featureRegistryServiceClient.PollOnceDeleteFeatureMonitor(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteFeatureMonitorAsync</summary>
        public async Task DeleteFeatureMonitorResourceNamesAsync()
        {
            // Snippet: DeleteFeatureMonitorAsync(FeatureMonitorName, CallSettings)
            // Additional: DeleteFeatureMonitorAsync(FeatureMonitorName, CancellationToken)
            // Create client
            FeatureRegistryServiceClient featureRegistryServiceClient = await FeatureRegistryServiceClient.CreateAsync();
            // Initialize request argument(s)
            FeatureMonitorName name = FeatureMonitorName.FromProjectLocationFeatureGroupFeatureMonitor("[PROJECT]", "[LOCATION]", "[FEATURE_GROUP]", "[FEATURE_MONITOR]");
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await featureRegistryServiceClient.DeleteFeatureMonitorAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await featureRegistryServiceClient.PollOnceDeleteFeatureMonitorAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateFeatureMonitorJob</summary>
        public void CreateFeatureMonitorJobRequestObject()
        {
            // Snippet: CreateFeatureMonitorJob(CreateFeatureMonitorJobRequest, CallSettings)
            // Create client
            FeatureRegistryServiceClient featureRegistryServiceClient = FeatureRegistryServiceClient.Create();
            // Initialize request argument(s)
            CreateFeatureMonitorJobRequest request = new CreateFeatureMonitorJobRequest
            {
                ParentAsFeatureMonitorName = FeatureMonitorName.FromProjectLocationFeatureGroupFeatureMonitor("[PROJECT]", "[LOCATION]", "[FEATURE_GROUP]", "[FEATURE_MONITOR]"),
                FeatureMonitorJob = new FeatureMonitorJob(),
                FeatureMonitorJobId = 0L,
            };
            // Make the request
            FeatureMonitorJob response = featureRegistryServiceClient.CreateFeatureMonitorJob(request);
            // End snippet
        }

        /// <summary>Snippet for CreateFeatureMonitorJobAsync</summary>
        public async Task CreateFeatureMonitorJobRequestObjectAsync()
        {
            // Snippet: CreateFeatureMonitorJobAsync(CreateFeatureMonitorJobRequest, CallSettings)
            // Additional: CreateFeatureMonitorJobAsync(CreateFeatureMonitorJobRequest, CancellationToken)
            // Create client
            FeatureRegistryServiceClient featureRegistryServiceClient = await FeatureRegistryServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateFeatureMonitorJobRequest request = new CreateFeatureMonitorJobRequest
            {
                ParentAsFeatureMonitorName = FeatureMonitorName.FromProjectLocationFeatureGroupFeatureMonitor("[PROJECT]", "[LOCATION]", "[FEATURE_GROUP]", "[FEATURE_MONITOR]"),
                FeatureMonitorJob = new FeatureMonitorJob(),
                FeatureMonitorJobId = 0L,
            };
            // Make the request
            FeatureMonitorJob response = await featureRegistryServiceClient.CreateFeatureMonitorJobAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateFeatureMonitorJob</summary>
        public void CreateFeatureMonitorJob()
        {
            // Snippet: CreateFeatureMonitorJob(string, FeatureMonitorJob, long, CallSettings)
            // Create client
            FeatureRegistryServiceClient featureRegistryServiceClient = FeatureRegistryServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/featureGroups/[FEATURE_GROUP]/featureMonitors/[FEATURE_MONITOR]";
            FeatureMonitorJob featureMonitorJob = new FeatureMonitorJob();
            long featureMonitorJobId = 0L;
            // Make the request
            FeatureMonitorJob response = featureRegistryServiceClient.CreateFeatureMonitorJob(parent, featureMonitorJob, featureMonitorJobId);
            // End snippet
        }

        /// <summary>Snippet for CreateFeatureMonitorJobAsync</summary>
        public async Task CreateFeatureMonitorJobAsync()
        {
            // Snippet: CreateFeatureMonitorJobAsync(string, FeatureMonitorJob, long, CallSettings)
            // Additional: CreateFeatureMonitorJobAsync(string, FeatureMonitorJob, long, CancellationToken)
            // Create client
            FeatureRegistryServiceClient featureRegistryServiceClient = await FeatureRegistryServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/featureGroups/[FEATURE_GROUP]/featureMonitors/[FEATURE_MONITOR]";
            FeatureMonitorJob featureMonitorJob = new FeatureMonitorJob();
            long featureMonitorJobId = 0L;
            // Make the request
            FeatureMonitorJob response = await featureRegistryServiceClient.CreateFeatureMonitorJobAsync(parent, featureMonitorJob, featureMonitorJobId);
            // End snippet
        }

        /// <summary>Snippet for CreateFeatureMonitorJob</summary>
        public void CreateFeatureMonitorJobResourceNames()
        {
            // Snippet: CreateFeatureMonitorJob(FeatureMonitorName, FeatureMonitorJob, long, CallSettings)
            // Create client
            FeatureRegistryServiceClient featureRegistryServiceClient = FeatureRegistryServiceClient.Create();
            // Initialize request argument(s)
            FeatureMonitorName parent = FeatureMonitorName.FromProjectLocationFeatureGroupFeatureMonitor("[PROJECT]", "[LOCATION]", "[FEATURE_GROUP]", "[FEATURE_MONITOR]");
            FeatureMonitorJob featureMonitorJob = new FeatureMonitorJob();
            long featureMonitorJobId = 0L;
            // Make the request
            FeatureMonitorJob response = featureRegistryServiceClient.CreateFeatureMonitorJob(parent, featureMonitorJob, featureMonitorJobId);
            // End snippet
        }

        /// <summary>Snippet for CreateFeatureMonitorJobAsync</summary>
        public async Task CreateFeatureMonitorJobResourceNamesAsync()
        {
            // Snippet: CreateFeatureMonitorJobAsync(FeatureMonitorName, FeatureMonitorJob, long, CallSettings)
            // Additional: CreateFeatureMonitorJobAsync(FeatureMonitorName, FeatureMonitorJob, long, CancellationToken)
            // Create client
            FeatureRegistryServiceClient featureRegistryServiceClient = await FeatureRegistryServiceClient.CreateAsync();
            // Initialize request argument(s)
            FeatureMonitorName parent = FeatureMonitorName.FromProjectLocationFeatureGroupFeatureMonitor("[PROJECT]", "[LOCATION]", "[FEATURE_GROUP]", "[FEATURE_MONITOR]");
            FeatureMonitorJob featureMonitorJob = new FeatureMonitorJob();
            long featureMonitorJobId = 0L;
            // Make the request
            FeatureMonitorJob response = await featureRegistryServiceClient.CreateFeatureMonitorJobAsync(parent, featureMonitorJob, featureMonitorJobId);
            // End snippet
        }

        /// <summary>Snippet for GetFeatureMonitorJob</summary>
        public void GetFeatureMonitorJobRequestObject()
        {
            // Snippet: GetFeatureMonitorJob(GetFeatureMonitorJobRequest, CallSettings)
            // Create client
            FeatureRegistryServiceClient featureRegistryServiceClient = FeatureRegistryServiceClient.Create();
            // Initialize request argument(s)
            GetFeatureMonitorJobRequest request = new GetFeatureMonitorJobRequest
            {
                FeatureMonitorJobName = FeatureMonitorJobName.FromProjectLocationFeatureGroupFeatureMonitorFeatureMonitorJob("[PROJECT]", "[LOCATION]", "[FEATURE_GROUP]", "[FEATURE_MONITOR]", "[FEATURE_MONITOR_JOB]"),
            };
            // Make the request
            FeatureMonitorJob response = featureRegistryServiceClient.GetFeatureMonitorJob(request);
            // End snippet
        }

        /// <summary>Snippet for GetFeatureMonitorJobAsync</summary>
        public async Task GetFeatureMonitorJobRequestObjectAsync()
        {
            // Snippet: GetFeatureMonitorJobAsync(GetFeatureMonitorJobRequest, CallSettings)
            // Additional: GetFeatureMonitorJobAsync(GetFeatureMonitorJobRequest, CancellationToken)
            // Create client
            FeatureRegistryServiceClient featureRegistryServiceClient = await FeatureRegistryServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetFeatureMonitorJobRequest request = new GetFeatureMonitorJobRequest
            {
                FeatureMonitorJobName = FeatureMonitorJobName.FromProjectLocationFeatureGroupFeatureMonitorFeatureMonitorJob("[PROJECT]", "[LOCATION]", "[FEATURE_GROUP]", "[FEATURE_MONITOR]", "[FEATURE_MONITOR_JOB]"),
            };
            // Make the request
            FeatureMonitorJob response = await featureRegistryServiceClient.GetFeatureMonitorJobAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetFeatureMonitorJob</summary>
        public void GetFeatureMonitorJob()
        {
            // Snippet: GetFeatureMonitorJob(string, CallSettings)
            // Create client
            FeatureRegistryServiceClient featureRegistryServiceClient = FeatureRegistryServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/featureGroups/[FEATURE_GROUP]/featureMonitors/[FEATURE_MONITOR]/featureMonitorJobs/[FEATURE_MONITOR_JOB]";
            // Make the request
            FeatureMonitorJob response = featureRegistryServiceClient.GetFeatureMonitorJob(name);
            // End snippet
        }

        /// <summary>Snippet for GetFeatureMonitorJobAsync</summary>
        public async Task GetFeatureMonitorJobAsync()
        {
            // Snippet: GetFeatureMonitorJobAsync(string, CallSettings)
            // Additional: GetFeatureMonitorJobAsync(string, CancellationToken)
            // Create client
            FeatureRegistryServiceClient featureRegistryServiceClient = await FeatureRegistryServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/featureGroups/[FEATURE_GROUP]/featureMonitors/[FEATURE_MONITOR]/featureMonitorJobs/[FEATURE_MONITOR_JOB]";
            // Make the request
            FeatureMonitorJob response = await featureRegistryServiceClient.GetFeatureMonitorJobAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetFeatureMonitorJob</summary>
        public void GetFeatureMonitorJobResourceNames()
        {
            // Snippet: GetFeatureMonitorJob(FeatureMonitorJobName, CallSettings)
            // Create client
            FeatureRegistryServiceClient featureRegistryServiceClient = FeatureRegistryServiceClient.Create();
            // Initialize request argument(s)
            FeatureMonitorJobName name = FeatureMonitorJobName.FromProjectLocationFeatureGroupFeatureMonitorFeatureMonitorJob("[PROJECT]", "[LOCATION]", "[FEATURE_GROUP]", "[FEATURE_MONITOR]", "[FEATURE_MONITOR_JOB]");
            // Make the request
            FeatureMonitorJob response = featureRegistryServiceClient.GetFeatureMonitorJob(name);
            // End snippet
        }

        /// <summary>Snippet for GetFeatureMonitorJobAsync</summary>
        public async Task GetFeatureMonitorJobResourceNamesAsync()
        {
            // Snippet: GetFeatureMonitorJobAsync(FeatureMonitorJobName, CallSettings)
            // Additional: GetFeatureMonitorJobAsync(FeatureMonitorJobName, CancellationToken)
            // Create client
            FeatureRegistryServiceClient featureRegistryServiceClient = await FeatureRegistryServiceClient.CreateAsync();
            // Initialize request argument(s)
            FeatureMonitorJobName name = FeatureMonitorJobName.FromProjectLocationFeatureGroupFeatureMonitorFeatureMonitorJob("[PROJECT]", "[LOCATION]", "[FEATURE_GROUP]", "[FEATURE_MONITOR]", "[FEATURE_MONITOR_JOB]");
            // Make the request
            FeatureMonitorJob response = await featureRegistryServiceClient.GetFeatureMonitorJobAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListFeatureMonitorJobs</summary>
        public void ListFeatureMonitorJobsRequestObject()
        {
            // Snippet: ListFeatureMonitorJobs(ListFeatureMonitorJobsRequest, CallSettings)
            // Create client
            FeatureRegistryServiceClient featureRegistryServiceClient = FeatureRegistryServiceClient.Create();
            // Initialize request argument(s)
            ListFeatureMonitorJobsRequest request = new ListFeatureMonitorJobsRequest
            {
                ParentAsFeatureMonitorName = FeatureMonitorName.FromProjectLocationFeatureGroupFeatureMonitor("[PROJECT]", "[LOCATION]", "[FEATURE_GROUP]", "[FEATURE_MONITOR]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListFeatureMonitorJobsResponse, FeatureMonitorJob> response = featureRegistryServiceClient.ListFeatureMonitorJobs(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (FeatureMonitorJob item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFeatureMonitorJobsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FeatureMonitorJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FeatureMonitorJob> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FeatureMonitorJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFeatureMonitorJobsAsync</summary>
        public async Task ListFeatureMonitorJobsRequestObjectAsync()
        {
            // Snippet: ListFeatureMonitorJobsAsync(ListFeatureMonitorJobsRequest, CallSettings)
            // Create client
            FeatureRegistryServiceClient featureRegistryServiceClient = await FeatureRegistryServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListFeatureMonitorJobsRequest request = new ListFeatureMonitorJobsRequest
            {
                ParentAsFeatureMonitorName = FeatureMonitorName.FromProjectLocationFeatureGroupFeatureMonitor("[PROJECT]", "[LOCATION]", "[FEATURE_GROUP]", "[FEATURE_MONITOR]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListFeatureMonitorJobsResponse, FeatureMonitorJob> response = featureRegistryServiceClient.ListFeatureMonitorJobsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((FeatureMonitorJob item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListFeatureMonitorJobsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FeatureMonitorJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FeatureMonitorJob> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FeatureMonitorJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFeatureMonitorJobs</summary>
        public void ListFeatureMonitorJobs()
        {
            // Snippet: ListFeatureMonitorJobs(string, string, int?, CallSettings)
            // Create client
            FeatureRegistryServiceClient featureRegistryServiceClient = FeatureRegistryServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/featureGroups/[FEATURE_GROUP]/featureMonitors/[FEATURE_MONITOR]";
            // Make the request
            PagedEnumerable<ListFeatureMonitorJobsResponse, FeatureMonitorJob> response = featureRegistryServiceClient.ListFeatureMonitorJobs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (FeatureMonitorJob item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFeatureMonitorJobsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FeatureMonitorJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FeatureMonitorJob> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FeatureMonitorJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFeatureMonitorJobsAsync</summary>
        public async Task ListFeatureMonitorJobsAsync()
        {
            // Snippet: ListFeatureMonitorJobsAsync(string, string, int?, CallSettings)
            // Create client
            FeatureRegistryServiceClient featureRegistryServiceClient = await FeatureRegistryServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/featureGroups/[FEATURE_GROUP]/featureMonitors/[FEATURE_MONITOR]";
            // Make the request
            PagedAsyncEnumerable<ListFeatureMonitorJobsResponse, FeatureMonitorJob> response = featureRegistryServiceClient.ListFeatureMonitorJobsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((FeatureMonitorJob item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListFeatureMonitorJobsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FeatureMonitorJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FeatureMonitorJob> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FeatureMonitorJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFeatureMonitorJobs</summary>
        public void ListFeatureMonitorJobsResourceNames()
        {
            // Snippet: ListFeatureMonitorJobs(FeatureMonitorName, string, int?, CallSettings)
            // Create client
            FeatureRegistryServiceClient featureRegistryServiceClient = FeatureRegistryServiceClient.Create();
            // Initialize request argument(s)
            FeatureMonitorName parent = FeatureMonitorName.FromProjectLocationFeatureGroupFeatureMonitor("[PROJECT]", "[LOCATION]", "[FEATURE_GROUP]", "[FEATURE_MONITOR]");
            // Make the request
            PagedEnumerable<ListFeatureMonitorJobsResponse, FeatureMonitorJob> response = featureRegistryServiceClient.ListFeatureMonitorJobs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (FeatureMonitorJob item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFeatureMonitorJobsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FeatureMonitorJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FeatureMonitorJob> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FeatureMonitorJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFeatureMonitorJobsAsync</summary>
        public async Task ListFeatureMonitorJobsResourceNamesAsync()
        {
            // Snippet: ListFeatureMonitorJobsAsync(FeatureMonitorName, string, int?, CallSettings)
            // Create client
            FeatureRegistryServiceClient featureRegistryServiceClient = await FeatureRegistryServiceClient.CreateAsync();
            // Initialize request argument(s)
            FeatureMonitorName parent = FeatureMonitorName.FromProjectLocationFeatureGroupFeatureMonitor("[PROJECT]", "[LOCATION]", "[FEATURE_GROUP]", "[FEATURE_MONITOR]");
            // Make the request
            PagedAsyncEnumerable<ListFeatureMonitorJobsResponse, FeatureMonitorJob> response = featureRegistryServiceClient.ListFeatureMonitorJobsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((FeatureMonitorJob item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListFeatureMonitorJobsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FeatureMonitorJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FeatureMonitorJob> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FeatureMonitorJob item in singlePage)
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
