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
    using Google.Cloud.Iam.V1;
    using Google.Cloud.Spanner.Admin.Instance.V1;
    using Google.Cloud.Spanner.Common.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedInstanceAdminClientSnippets
    {
        /// <summary>Snippet for ListInstanceConfigs</summary>
        public void ListInstanceConfigsRequestObject()
        {
            // Snippet: ListInstanceConfigs(ListInstanceConfigsRequest, CallSettings)
            // Create client
            InstanceAdminClient instanceAdminClient = InstanceAdminClient.Create();
            // Initialize request argument(s)
            ListInstanceConfigsRequest request = new ListInstanceConfigsRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
            };
            // Make the request
            PagedEnumerable<ListInstanceConfigsResponse, InstanceConfig> response = instanceAdminClient.ListInstanceConfigs(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (InstanceConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListInstanceConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InstanceConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InstanceConfig> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InstanceConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInstanceConfigsAsync</summary>
        public async Task ListInstanceConfigsRequestObjectAsync()
        {
            // Snippet: ListInstanceConfigsAsync(ListInstanceConfigsRequest, CallSettings)
            // Create client
            InstanceAdminClient instanceAdminClient = await InstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            ListInstanceConfigsRequest request = new ListInstanceConfigsRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListInstanceConfigsResponse, InstanceConfig> response = instanceAdminClient.ListInstanceConfigsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((InstanceConfig item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListInstanceConfigsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InstanceConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InstanceConfig> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InstanceConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInstanceConfigs</summary>
        public void ListInstanceConfigs()
        {
            // Snippet: ListInstanceConfigs(string, string, int?, CallSettings)
            // Create client
            InstanceAdminClient instanceAdminClient = InstanceAdminClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            // Make the request
            PagedEnumerable<ListInstanceConfigsResponse, InstanceConfig> response = instanceAdminClient.ListInstanceConfigs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (InstanceConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListInstanceConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InstanceConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InstanceConfig> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InstanceConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInstanceConfigsAsync</summary>
        public async Task ListInstanceConfigsAsync()
        {
            // Snippet: ListInstanceConfigsAsync(string, string, int?, CallSettings)
            // Create client
            InstanceAdminClient instanceAdminClient = await InstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            // Make the request
            PagedAsyncEnumerable<ListInstanceConfigsResponse, InstanceConfig> response = instanceAdminClient.ListInstanceConfigsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((InstanceConfig item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListInstanceConfigsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InstanceConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InstanceConfig> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InstanceConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInstanceConfigs</summary>
        public void ListInstanceConfigsResourceNames()
        {
            // Snippet: ListInstanceConfigs(ProjectName, string, int?, CallSettings)
            // Create client
            InstanceAdminClient instanceAdminClient = InstanceAdminClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedEnumerable<ListInstanceConfigsResponse, InstanceConfig> response = instanceAdminClient.ListInstanceConfigs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (InstanceConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListInstanceConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InstanceConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InstanceConfig> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InstanceConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInstanceConfigsAsync</summary>
        public async Task ListInstanceConfigsResourceNamesAsync()
        {
            // Snippet: ListInstanceConfigsAsync(ProjectName, string, int?, CallSettings)
            // Create client
            InstanceAdminClient instanceAdminClient = await InstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedAsyncEnumerable<ListInstanceConfigsResponse, InstanceConfig> response = instanceAdminClient.ListInstanceConfigsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((InstanceConfig item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListInstanceConfigsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InstanceConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InstanceConfig> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InstanceConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetInstanceConfig</summary>
        public void GetInstanceConfigRequestObject()
        {
            // Snippet: GetInstanceConfig(GetInstanceConfigRequest, CallSettings)
            // Create client
            InstanceAdminClient instanceAdminClient = InstanceAdminClient.Create();
            // Initialize request argument(s)
            GetInstanceConfigRequest request = new GetInstanceConfigRequest
            {
                InstanceConfigName = InstanceConfigName.FromProjectInstanceConfig("[PROJECT]", "[INSTANCE_CONFIG]"),
            };
            // Make the request
            InstanceConfig response = instanceAdminClient.GetInstanceConfig(request);
            // End snippet
        }

        /// <summary>Snippet for GetInstanceConfigAsync</summary>
        public async Task GetInstanceConfigRequestObjectAsync()
        {
            // Snippet: GetInstanceConfigAsync(GetInstanceConfigRequest, CallSettings)
            // Additional: GetInstanceConfigAsync(GetInstanceConfigRequest, CancellationToken)
            // Create client
            InstanceAdminClient instanceAdminClient = await InstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            GetInstanceConfigRequest request = new GetInstanceConfigRequest
            {
                InstanceConfigName = InstanceConfigName.FromProjectInstanceConfig("[PROJECT]", "[INSTANCE_CONFIG]"),
            };
            // Make the request
            InstanceConfig response = await instanceAdminClient.GetInstanceConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetInstanceConfig</summary>
        public void GetInstanceConfig()
        {
            // Snippet: GetInstanceConfig(string, CallSettings)
            // Create client
            InstanceAdminClient instanceAdminClient = InstanceAdminClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/instanceConfigs/[INSTANCE_CONFIG]";
            // Make the request
            InstanceConfig response = instanceAdminClient.GetInstanceConfig(name);
            // End snippet
        }

        /// <summary>Snippet for GetInstanceConfigAsync</summary>
        public async Task GetInstanceConfigAsync()
        {
            // Snippet: GetInstanceConfigAsync(string, CallSettings)
            // Additional: GetInstanceConfigAsync(string, CancellationToken)
            // Create client
            InstanceAdminClient instanceAdminClient = await InstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/instanceConfigs/[INSTANCE_CONFIG]";
            // Make the request
            InstanceConfig response = await instanceAdminClient.GetInstanceConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetInstanceConfig</summary>
        public void GetInstanceConfigResourceNames()
        {
            // Snippet: GetInstanceConfig(InstanceConfigName, CallSettings)
            // Create client
            InstanceAdminClient instanceAdminClient = InstanceAdminClient.Create();
            // Initialize request argument(s)
            InstanceConfigName name = InstanceConfigName.FromProjectInstanceConfig("[PROJECT]", "[INSTANCE_CONFIG]");
            // Make the request
            InstanceConfig response = instanceAdminClient.GetInstanceConfig(name);
            // End snippet
        }

        /// <summary>Snippet for GetInstanceConfigAsync</summary>
        public async Task GetInstanceConfigResourceNamesAsync()
        {
            // Snippet: GetInstanceConfigAsync(InstanceConfigName, CallSettings)
            // Additional: GetInstanceConfigAsync(InstanceConfigName, CancellationToken)
            // Create client
            InstanceAdminClient instanceAdminClient = await InstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            InstanceConfigName name = InstanceConfigName.FromProjectInstanceConfig("[PROJECT]", "[INSTANCE_CONFIG]");
            // Make the request
            InstanceConfig response = await instanceAdminClient.GetInstanceConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateInstanceConfig</summary>
        public void CreateInstanceConfigRequestObject()
        {
            // Snippet: CreateInstanceConfig(CreateInstanceConfigRequest, CallSettings)
            // Create client
            InstanceAdminClient instanceAdminClient = InstanceAdminClient.Create();
            // Initialize request argument(s)
            CreateInstanceConfigRequest request = new CreateInstanceConfigRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                InstanceConfigId = "",
                InstanceConfig = new InstanceConfig(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<InstanceConfig, CreateInstanceConfigMetadata> response = instanceAdminClient.CreateInstanceConfig(request);

            // Poll until the returned long-running operation is complete
            Operation<InstanceConfig, CreateInstanceConfigMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            InstanceConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<InstanceConfig, CreateInstanceConfigMetadata> retrievedResponse = instanceAdminClient.PollOnceCreateInstanceConfig(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                InstanceConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateInstanceConfigAsync</summary>
        public async Task CreateInstanceConfigRequestObjectAsync()
        {
            // Snippet: CreateInstanceConfigAsync(CreateInstanceConfigRequest, CallSettings)
            // Additional: CreateInstanceConfigAsync(CreateInstanceConfigRequest, CancellationToken)
            // Create client
            InstanceAdminClient instanceAdminClient = await InstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            CreateInstanceConfigRequest request = new CreateInstanceConfigRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                InstanceConfigId = "",
                InstanceConfig = new InstanceConfig(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<InstanceConfig, CreateInstanceConfigMetadata> response = await instanceAdminClient.CreateInstanceConfigAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<InstanceConfig, CreateInstanceConfigMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            InstanceConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<InstanceConfig, CreateInstanceConfigMetadata> retrievedResponse = await instanceAdminClient.PollOnceCreateInstanceConfigAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                InstanceConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateInstanceConfig</summary>
        public void CreateInstanceConfig()
        {
            // Snippet: CreateInstanceConfig(string, InstanceConfig, string, CallSettings)
            // Create client
            InstanceAdminClient instanceAdminClient = InstanceAdminClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            InstanceConfig instanceConfig = new InstanceConfig();
            string instanceConfigId = "";
            // Make the request
            Operation<InstanceConfig, CreateInstanceConfigMetadata> response = instanceAdminClient.CreateInstanceConfig(parent, instanceConfig, instanceConfigId);

            // Poll until the returned long-running operation is complete
            Operation<InstanceConfig, CreateInstanceConfigMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            InstanceConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<InstanceConfig, CreateInstanceConfigMetadata> retrievedResponse = instanceAdminClient.PollOnceCreateInstanceConfig(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                InstanceConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateInstanceConfigAsync</summary>
        public async Task CreateInstanceConfigAsync()
        {
            // Snippet: CreateInstanceConfigAsync(string, InstanceConfig, string, CallSettings)
            // Additional: CreateInstanceConfigAsync(string, InstanceConfig, string, CancellationToken)
            // Create client
            InstanceAdminClient instanceAdminClient = await InstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            InstanceConfig instanceConfig = new InstanceConfig();
            string instanceConfigId = "";
            // Make the request
            Operation<InstanceConfig, CreateInstanceConfigMetadata> response = await instanceAdminClient.CreateInstanceConfigAsync(parent, instanceConfig, instanceConfigId);

            // Poll until the returned long-running operation is complete
            Operation<InstanceConfig, CreateInstanceConfigMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            InstanceConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<InstanceConfig, CreateInstanceConfigMetadata> retrievedResponse = await instanceAdminClient.PollOnceCreateInstanceConfigAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                InstanceConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateInstanceConfig</summary>
        public void CreateInstanceConfigResourceNames()
        {
            // Snippet: CreateInstanceConfig(ProjectName, InstanceConfig, string, CallSettings)
            // Create client
            InstanceAdminClient instanceAdminClient = InstanceAdminClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            InstanceConfig instanceConfig = new InstanceConfig();
            string instanceConfigId = "";
            // Make the request
            Operation<InstanceConfig, CreateInstanceConfigMetadata> response = instanceAdminClient.CreateInstanceConfig(parent, instanceConfig, instanceConfigId);

            // Poll until the returned long-running operation is complete
            Operation<InstanceConfig, CreateInstanceConfigMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            InstanceConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<InstanceConfig, CreateInstanceConfigMetadata> retrievedResponse = instanceAdminClient.PollOnceCreateInstanceConfig(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                InstanceConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateInstanceConfigAsync</summary>
        public async Task CreateInstanceConfigResourceNamesAsync()
        {
            // Snippet: CreateInstanceConfigAsync(ProjectName, InstanceConfig, string, CallSettings)
            // Additional: CreateInstanceConfigAsync(ProjectName, InstanceConfig, string, CancellationToken)
            // Create client
            InstanceAdminClient instanceAdminClient = await InstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            InstanceConfig instanceConfig = new InstanceConfig();
            string instanceConfigId = "";
            // Make the request
            Operation<InstanceConfig, CreateInstanceConfigMetadata> response = await instanceAdminClient.CreateInstanceConfigAsync(parent, instanceConfig, instanceConfigId);

            // Poll until the returned long-running operation is complete
            Operation<InstanceConfig, CreateInstanceConfigMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            InstanceConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<InstanceConfig, CreateInstanceConfigMetadata> retrievedResponse = await instanceAdminClient.PollOnceCreateInstanceConfigAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                InstanceConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateInstanceConfig</summary>
        public void UpdateInstanceConfigRequestObject()
        {
            // Snippet: UpdateInstanceConfig(UpdateInstanceConfigRequest, CallSettings)
            // Create client
            InstanceAdminClient instanceAdminClient = InstanceAdminClient.Create();
            // Initialize request argument(s)
            UpdateInstanceConfigRequest request = new UpdateInstanceConfigRequest
            {
                InstanceConfig = new InstanceConfig(),
                UpdateMask = new FieldMask(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<InstanceConfig, UpdateInstanceConfigMetadata> response = instanceAdminClient.UpdateInstanceConfig(request);

            // Poll until the returned long-running operation is complete
            Operation<InstanceConfig, UpdateInstanceConfigMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            InstanceConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<InstanceConfig, UpdateInstanceConfigMetadata> retrievedResponse = instanceAdminClient.PollOnceUpdateInstanceConfig(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                InstanceConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateInstanceConfigAsync</summary>
        public async Task UpdateInstanceConfigRequestObjectAsync()
        {
            // Snippet: UpdateInstanceConfigAsync(UpdateInstanceConfigRequest, CallSettings)
            // Additional: UpdateInstanceConfigAsync(UpdateInstanceConfigRequest, CancellationToken)
            // Create client
            InstanceAdminClient instanceAdminClient = await InstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            UpdateInstanceConfigRequest request = new UpdateInstanceConfigRequest
            {
                InstanceConfig = new InstanceConfig(),
                UpdateMask = new FieldMask(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<InstanceConfig, UpdateInstanceConfigMetadata> response = await instanceAdminClient.UpdateInstanceConfigAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<InstanceConfig, UpdateInstanceConfigMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            InstanceConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<InstanceConfig, UpdateInstanceConfigMetadata> retrievedResponse = await instanceAdminClient.PollOnceUpdateInstanceConfigAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                InstanceConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateInstanceConfig</summary>
        public void UpdateInstanceConfig()
        {
            // Snippet: UpdateInstanceConfig(InstanceConfig, FieldMask, CallSettings)
            // Create client
            InstanceAdminClient instanceAdminClient = InstanceAdminClient.Create();
            // Initialize request argument(s)
            InstanceConfig instanceConfig = new InstanceConfig();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<InstanceConfig, UpdateInstanceConfigMetadata> response = instanceAdminClient.UpdateInstanceConfig(instanceConfig, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<InstanceConfig, UpdateInstanceConfigMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            InstanceConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<InstanceConfig, UpdateInstanceConfigMetadata> retrievedResponse = instanceAdminClient.PollOnceUpdateInstanceConfig(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                InstanceConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateInstanceConfigAsync</summary>
        public async Task UpdateInstanceConfigAsync()
        {
            // Snippet: UpdateInstanceConfigAsync(InstanceConfig, FieldMask, CallSettings)
            // Additional: UpdateInstanceConfigAsync(InstanceConfig, FieldMask, CancellationToken)
            // Create client
            InstanceAdminClient instanceAdminClient = await InstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            InstanceConfig instanceConfig = new InstanceConfig();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<InstanceConfig, UpdateInstanceConfigMetadata> response = await instanceAdminClient.UpdateInstanceConfigAsync(instanceConfig, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<InstanceConfig, UpdateInstanceConfigMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            InstanceConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<InstanceConfig, UpdateInstanceConfigMetadata> retrievedResponse = await instanceAdminClient.PollOnceUpdateInstanceConfigAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                InstanceConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteInstanceConfig</summary>
        public void DeleteInstanceConfigRequestObject()
        {
            // Snippet: DeleteInstanceConfig(DeleteInstanceConfigRequest, CallSettings)
            // Create client
            InstanceAdminClient instanceAdminClient = InstanceAdminClient.Create();
            // Initialize request argument(s)
            DeleteInstanceConfigRequest request = new DeleteInstanceConfigRequest
            {
                InstanceConfigName = InstanceConfigName.FromProjectInstanceConfig("[PROJECT]", "[INSTANCE_CONFIG]"),
                Etag = "",
                ValidateOnly = false,
            };
            // Make the request
            instanceAdminClient.DeleteInstanceConfig(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteInstanceConfigAsync</summary>
        public async Task DeleteInstanceConfigRequestObjectAsync()
        {
            // Snippet: DeleteInstanceConfigAsync(DeleteInstanceConfigRequest, CallSettings)
            // Additional: DeleteInstanceConfigAsync(DeleteInstanceConfigRequest, CancellationToken)
            // Create client
            InstanceAdminClient instanceAdminClient = await InstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            DeleteInstanceConfigRequest request = new DeleteInstanceConfigRequest
            {
                InstanceConfigName = InstanceConfigName.FromProjectInstanceConfig("[PROJECT]", "[INSTANCE_CONFIG]"),
                Etag = "",
                ValidateOnly = false,
            };
            // Make the request
            await instanceAdminClient.DeleteInstanceConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteInstanceConfig</summary>
        public void DeleteInstanceConfig()
        {
            // Snippet: DeleteInstanceConfig(string, CallSettings)
            // Create client
            InstanceAdminClient instanceAdminClient = InstanceAdminClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/instanceConfigs/[INSTANCE_CONFIG]";
            // Make the request
            instanceAdminClient.DeleteInstanceConfig(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteInstanceConfigAsync</summary>
        public async Task DeleteInstanceConfigAsync()
        {
            // Snippet: DeleteInstanceConfigAsync(string, CallSettings)
            // Additional: DeleteInstanceConfigAsync(string, CancellationToken)
            // Create client
            InstanceAdminClient instanceAdminClient = await InstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/instanceConfigs/[INSTANCE_CONFIG]";
            // Make the request
            await instanceAdminClient.DeleteInstanceConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteInstanceConfig</summary>
        public void DeleteInstanceConfigResourceNames()
        {
            // Snippet: DeleteInstanceConfig(InstanceConfigName, CallSettings)
            // Create client
            InstanceAdminClient instanceAdminClient = InstanceAdminClient.Create();
            // Initialize request argument(s)
            InstanceConfigName name = InstanceConfigName.FromProjectInstanceConfig("[PROJECT]", "[INSTANCE_CONFIG]");
            // Make the request
            instanceAdminClient.DeleteInstanceConfig(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteInstanceConfigAsync</summary>
        public async Task DeleteInstanceConfigResourceNamesAsync()
        {
            // Snippet: DeleteInstanceConfigAsync(InstanceConfigName, CallSettings)
            // Additional: DeleteInstanceConfigAsync(InstanceConfigName, CancellationToken)
            // Create client
            InstanceAdminClient instanceAdminClient = await InstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            InstanceConfigName name = InstanceConfigName.FromProjectInstanceConfig("[PROJECT]", "[INSTANCE_CONFIG]");
            // Make the request
            await instanceAdminClient.DeleteInstanceConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListInstanceConfigOperations</summary>
        public void ListInstanceConfigOperationsRequestObject()
        {
            // Snippet: ListInstanceConfigOperations(ListInstanceConfigOperationsRequest, CallSettings)
            // Create client
            InstanceAdminClient instanceAdminClient = InstanceAdminClient.Create();
            // Initialize request argument(s)
            ListInstanceConfigOperationsRequest request = new ListInstanceConfigOperationsRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListInstanceConfigOperationsResponse, Operation> response = instanceAdminClient.ListInstanceConfigOperations(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Operation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListInstanceConfigOperationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Operation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Operation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Operation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInstanceConfigOperationsAsync</summary>
        public async Task ListInstanceConfigOperationsRequestObjectAsync()
        {
            // Snippet: ListInstanceConfigOperationsAsync(ListInstanceConfigOperationsRequest, CallSettings)
            // Create client
            InstanceAdminClient instanceAdminClient = await InstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            ListInstanceConfigOperationsRequest request = new ListInstanceConfigOperationsRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListInstanceConfigOperationsResponse, Operation> response = instanceAdminClient.ListInstanceConfigOperationsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Operation item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListInstanceConfigOperationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Operation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Operation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Operation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInstanceConfigOperations</summary>
        public void ListInstanceConfigOperations()
        {
            // Snippet: ListInstanceConfigOperations(string, string, int?, CallSettings)
            // Create client
            InstanceAdminClient instanceAdminClient = InstanceAdminClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            // Make the request
            PagedEnumerable<ListInstanceConfigOperationsResponse, Operation> response = instanceAdminClient.ListInstanceConfigOperations(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Operation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListInstanceConfigOperationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Operation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Operation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Operation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInstanceConfigOperationsAsync</summary>
        public async Task ListInstanceConfigOperationsAsync()
        {
            // Snippet: ListInstanceConfigOperationsAsync(string, string, int?, CallSettings)
            // Create client
            InstanceAdminClient instanceAdminClient = await InstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            // Make the request
            PagedAsyncEnumerable<ListInstanceConfigOperationsResponse, Operation> response = instanceAdminClient.ListInstanceConfigOperationsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Operation item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListInstanceConfigOperationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Operation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Operation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Operation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInstanceConfigOperations</summary>
        public void ListInstanceConfigOperationsResourceNames()
        {
            // Snippet: ListInstanceConfigOperations(ProjectName, string, int?, CallSettings)
            // Create client
            InstanceAdminClient instanceAdminClient = InstanceAdminClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedEnumerable<ListInstanceConfigOperationsResponse, Operation> response = instanceAdminClient.ListInstanceConfigOperations(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Operation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListInstanceConfigOperationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Operation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Operation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Operation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInstanceConfigOperationsAsync</summary>
        public async Task ListInstanceConfigOperationsResourceNamesAsync()
        {
            // Snippet: ListInstanceConfigOperationsAsync(ProjectName, string, int?, CallSettings)
            // Create client
            InstanceAdminClient instanceAdminClient = await InstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedAsyncEnumerable<ListInstanceConfigOperationsResponse, Operation> response = instanceAdminClient.ListInstanceConfigOperationsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Operation item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListInstanceConfigOperationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Operation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Operation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Operation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInstances</summary>
        public void ListInstancesRequestObject()
        {
            // Snippet: ListInstances(ListInstancesRequest, CallSettings)
            // Create client
            InstanceAdminClient instanceAdminClient = InstanceAdminClient.Create();
            // Initialize request argument(s)
            ListInstancesRequest request = new ListInstancesRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Filter = "",
                InstanceDeadline = new Timestamp(),
            };
            // Make the request
            PagedEnumerable<ListInstancesResponse, Instance> response = instanceAdminClient.ListInstances(request);

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
            InstanceAdminClient instanceAdminClient = await InstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            ListInstancesRequest request = new ListInstancesRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Filter = "",
                InstanceDeadline = new Timestamp(),
            };
            // Make the request
            PagedAsyncEnumerable<ListInstancesResponse, Instance> response = instanceAdminClient.ListInstancesAsync(request);

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
            InstanceAdminClient instanceAdminClient = InstanceAdminClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            // Make the request
            PagedEnumerable<ListInstancesResponse, Instance> response = instanceAdminClient.ListInstances(parent);

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
            InstanceAdminClient instanceAdminClient = await InstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            // Make the request
            PagedAsyncEnumerable<ListInstancesResponse, Instance> response = instanceAdminClient.ListInstancesAsync(parent);

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
            // Snippet: ListInstances(ProjectName, string, int?, CallSettings)
            // Create client
            InstanceAdminClient instanceAdminClient = InstanceAdminClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedEnumerable<ListInstancesResponse, Instance> response = instanceAdminClient.ListInstances(parent);

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
            // Snippet: ListInstancesAsync(ProjectName, string, int?, CallSettings)
            // Create client
            InstanceAdminClient instanceAdminClient = await InstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedAsyncEnumerable<ListInstancesResponse, Instance> response = instanceAdminClient.ListInstancesAsync(parent);

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

        /// <summary>Snippet for ListInstancePartitions</summary>
        public void ListInstancePartitionsRequestObject()
        {
            // Snippet: ListInstancePartitions(ListInstancePartitionsRequest, CallSettings)
            // Create client
            InstanceAdminClient instanceAdminClient = InstanceAdminClient.Create();
            // Initialize request argument(s)
            ListInstancePartitionsRequest request = new ListInstancePartitionsRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
                InstancePartitionDeadline = new Timestamp(),
            };
            // Make the request
            PagedEnumerable<ListInstancePartitionsResponse, InstancePartition> response = instanceAdminClient.ListInstancePartitions(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (InstancePartition item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListInstancePartitionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InstancePartition item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InstancePartition> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InstancePartition item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInstancePartitionsAsync</summary>
        public async Task ListInstancePartitionsRequestObjectAsync()
        {
            // Snippet: ListInstancePartitionsAsync(ListInstancePartitionsRequest, CallSettings)
            // Create client
            InstanceAdminClient instanceAdminClient = await InstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            ListInstancePartitionsRequest request = new ListInstancePartitionsRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
                InstancePartitionDeadline = new Timestamp(),
            };
            // Make the request
            PagedAsyncEnumerable<ListInstancePartitionsResponse, InstancePartition> response = instanceAdminClient.ListInstancePartitionsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((InstancePartition item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListInstancePartitionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InstancePartition item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InstancePartition> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InstancePartition item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInstancePartitions</summary>
        public void ListInstancePartitions()
        {
            // Snippet: ListInstancePartitions(string, string, int?, CallSettings)
            // Create client
            InstanceAdminClient instanceAdminClient = InstanceAdminClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/instances/[INSTANCE]";
            // Make the request
            PagedEnumerable<ListInstancePartitionsResponse, InstancePartition> response = instanceAdminClient.ListInstancePartitions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (InstancePartition item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListInstancePartitionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InstancePartition item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InstancePartition> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InstancePartition item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInstancePartitionsAsync</summary>
        public async Task ListInstancePartitionsAsync()
        {
            // Snippet: ListInstancePartitionsAsync(string, string, int?, CallSettings)
            // Create client
            InstanceAdminClient instanceAdminClient = await InstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/instances/[INSTANCE]";
            // Make the request
            PagedAsyncEnumerable<ListInstancePartitionsResponse, InstancePartition> response = instanceAdminClient.ListInstancePartitionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((InstancePartition item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListInstancePartitionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InstancePartition item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InstancePartition> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InstancePartition item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInstancePartitions</summary>
        public void ListInstancePartitionsResourceNames()
        {
            // Snippet: ListInstancePartitions(InstanceName, string, int?, CallSettings)
            // Create client
            InstanceAdminClient instanceAdminClient = InstanceAdminClient.Create();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]");
            // Make the request
            PagedEnumerable<ListInstancePartitionsResponse, InstancePartition> response = instanceAdminClient.ListInstancePartitions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (InstancePartition item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListInstancePartitionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InstancePartition item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InstancePartition> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InstancePartition item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInstancePartitionsAsync</summary>
        public async Task ListInstancePartitionsResourceNamesAsync()
        {
            // Snippet: ListInstancePartitionsAsync(InstanceName, string, int?, CallSettings)
            // Create client
            InstanceAdminClient instanceAdminClient = await InstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]");
            // Make the request
            PagedAsyncEnumerable<ListInstancePartitionsResponse, InstancePartition> response = instanceAdminClient.ListInstancePartitionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((InstancePartition item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListInstancePartitionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InstancePartition item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InstancePartition> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InstancePartition item in singlePage)
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
            InstanceAdminClient instanceAdminClient = InstanceAdminClient.Create();
            // Initialize request argument(s)
            GetInstanceRequest request = new GetInstanceRequest
            {
                InstanceName = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
                FieldMask = new FieldMask(),
            };
            // Make the request
            Instance response = instanceAdminClient.GetInstance(request);
            // End snippet
        }

        /// <summary>Snippet for GetInstanceAsync</summary>
        public async Task GetInstanceRequestObjectAsync()
        {
            // Snippet: GetInstanceAsync(GetInstanceRequest, CallSettings)
            // Additional: GetInstanceAsync(GetInstanceRequest, CancellationToken)
            // Create client
            InstanceAdminClient instanceAdminClient = await InstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            GetInstanceRequest request = new GetInstanceRequest
            {
                InstanceName = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
                FieldMask = new FieldMask(),
            };
            // Make the request
            Instance response = await instanceAdminClient.GetInstanceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetInstance</summary>
        public void GetInstance()
        {
            // Snippet: GetInstance(string, CallSettings)
            // Create client
            InstanceAdminClient instanceAdminClient = InstanceAdminClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/instances/[INSTANCE]";
            // Make the request
            Instance response = instanceAdminClient.GetInstance(name);
            // End snippet
        }

        /// <summary>Snippet for GetInstanceAsync</summary>
        public async Task GetInstanceAsync()
        {
            // Snippet: GetInstanceAsync(string, CallSettings)
            // Additional: GetInstanceAsync(string, CancellationToken)
            // Create client
            InstanceAdminClient instanceAdminClient = await InstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/instances/[INSTANCE]";
            // Make the request
            Instance response = await instanceAdminClient.GetInstanceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetInstance</summary>
        public void GetInstanceResourceNames()
        {
            // Snippet: GetInstance(InstanceName, CallSettings)
            // Create client
            InstanceAdminClient instanceAdminClient = InstanceAdminClient.Create();
            // Initialize request argument(s)
            InstanceName name = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]");
            // Make the request
            Instance response = instanceAdminClient.GetInstance(name);
            // End snippet
        }

        /// <summary>Snippet for GetInstanceAsync</summary>
        public async Task GetInstanceResourceNamesAsync()
        {
            // Snippet: GetInstanceAsync(InstanceName, CallSettings)
            // Additional: GetInstanceAsync(InstanceName, CancellationToken)
            // Create client
            InstanceAdminClient instanceAdminClient = await InstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName name = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]");
            // Make the request
            Instance response = await instanceAdminClient.GetInstanceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateInstance</summary>
        public void CreateInstanceRequestObject()
        {
            // Snippet: CreateInstance(CreateInstanceRequest, CallSettings)
            // Create client
            InstanceAdminClient instanceAdminClient = InstanceAdminClient.Create();
            // Initialize request argument(s)
            CreateInstanceRequest request = new CreateInstanceRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                InstanceId = "",
                Instance = new Instance(),
            };
            // Make the request
            Operation<Instance, CreateInstanceMetadata> response = instanceAdminClient.CreateInstance(request);

            // Poll until the returned long-running operation is complete
            Operation<Instance, CreateInstanceMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, CreateInstanceMetadata> retrievedResponse = instanceAdminClient.PollOnceCreateInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateInstanceAsync</summary>
        public async Task CreateInstanceRequestObjectAsync()
        {
            // Snippet: CreateInstanceAsync(CreateInstanceRequest, CallSettings)
            // Additional: CreateInstanceAsync(CreateInstanceRequest, CancellationToken)
            // Create client
            InstanceAdminClient instanceAdminClient = await InstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            CreateInstanceRequest request = new CreateInstanceRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                InstanceId = "",
                Instance = new Instance(),
            };
            // Make the request
            Operation<Instance, CreateInstanceMetadata> response = await instanceAdminClient.CreateInstanceAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Instance, CreateInstanceMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, CreateInstanceMetadata> retrievedResponse = await instanceAdminClient.PollOnceCreateInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateInstance</summary>
        public void CreateInstance()
        {
            // Snippet: CreateInstance(string, string, Instance, CallSettings)
            // Create client
            InstanceAdminClient instanceAdminClient = InstanceAdminClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            string instanceId = "";
            Instance instance = new Instance();
            // Make the request
            Operation<Instance, CreateInstanceMetadata> response = instanceAdminClient.CreateInstance(parent, instanceId, instance);

            // Poll until the returned long-running operation is complete
            Operation<Instance, CreateInstanceMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, CreateInstanceMetadata> retrievedResponse = instanceAdminClient.PollOnceCreateInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateInstanceAsync</summary>
        public async Task CreateInstanceAsync()
        {
            // Snippet: CreateInstanceAsync(string, string, Instance, CallSettings)
            // Additional: CreateInstanceAsync(string, string, Instance, CancellationToken)
            // Create client
            InstanceAdminClient instanceAdminClient = await InstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            string instanceId = "";
            Instance instance = new Instance();
            // Make the request
            Operation<Instance, CreateInstanceMetadata> response = await instanceAdminClient.CreateInstanceAsync(parent, instanceId, instance);

            // Poll until the returned long-running operation is complete
            Operation<Instance, CreateInstanceMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, CreateInstanceMetadata> retrievedResponse = await instanceAdminClient.PollOnceCreateInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateInstance</summary>
        public void CreateInstanceResourceNames()
        {
            // Snippet: CreateInstance(ProjectName, string, Instance, CallSettings)
            // Create client
            InstanceAdminClient instanceAdminClient = InstanceAdminClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            string instanceId = "";
            Instance instance = new Instance();
            // Make the request
            Operation<Instance, CreateInstanceMetadata> response = instanceAdminClient.CreateInstance(parent, instanceId, instance);

            // Poll until the returned long-running operation is complete
            Operation<Instance, CreateInstanceMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, CreateInstanceMetadata> retrievedResponse = instanceAdminClient.PollOnceCreateInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateInstanceAsync</summary>
        public async Task CreateInstanceResourceNamesAsync()
        {
            // Snippet: CreateInstanceAsync(ProjectName, string, Instance, CallSettings)
            // Additional: CreateInstanceAsync(ProjectName, string, Instance, CancellationToken)
            // Create client
            InstanceAdminClient instanceAdminClient = await InstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            string instanceId = "";
            Instance instance = new Instance();
            // Make the request
            Operation<Instance, CreateInstanceMetadata> response = await instanceAdminClient.CreateInstanceAsync(parent, instanceId, instance);

            // Poll until the returned long-running operation is complete
            Operation<Instance, CreateInstanceMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, CreateInstanceMetadata> retrievedResponse = await instanceAdminClient.PollOnceCreateInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateInstance</summary>
        public void UpdateInstanceRequestObject()
        {
            // Snippet: UpdateInstance(UpdateInstanceRequest, CallSettings)
            // Create client
            InstanceAdminClient instanceAdminClient = InstanceAdminClient.Create();
            // Initialize request argument(s)
            UpdateInstanceRequest request = new UpdateInstanceRequest
            {
                Instance = new Instance(),
                FieldMask = new FieldMask(),
            };
            // Make the request
            Operation<Instance, UpdateInstanceMetadata> response = instanceAdminClient.UpdateInstance(request);

            // Poll until the returned long-running operation is complete
            Operation<Instance, UpdateInstanceMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, UpdateInstanceMetadata> retrievedResponse = instanceAdminClient.PollOnceUpdateInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateInstanceAsync</summary>
        public async Task UpdateInstanceRequestObjectAsync()
        {
            // Snippet: UpdateInstanceAsync(UpdateInstanceRequest, CallSettings)
            // Additional: UpdateInstanceAsync(UpdateInstanceRequest, CancellationToken)
            // Create client
            InstanceAdminClient instanceAdminClient = await InstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            UpdateInstanceRequest request = new UpdateInstanceRequest
            {
                Instance = new Instance(),
                FieldMask = new FieldMask(),
            };
            // Make the request
            Operation<Instance, UpdateInstanceMetadata> response = await instanceAdminClient.UpdateInstanceAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Instance, UpdateInstanceMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, UpdateInstanceMetadata> retrievedResponse = await instanceAdminClient.PollOnceUpdateInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateInstance</summary>
        public void UpdateInstance()
        {
            // Snippet: UpdateInstance(Instance, FieldMask, CallSettings)
            // Create client
            InstanceAdminClient instanceAdminClient = InstanceAdminClient.Create();
            // Initialize request argument(s)
            Instance instance = new Instance();
            FieldMask fieldMask = new FieldMask();
            // Make the request
            Operation<Instance, UpdateInstanceMetadata> response = instanceAdminClient.UpdateInstance(instance, fieldMask);

            // Poll until the returned long-running operation is complete
            Operation<Instance, UpdateInstanceMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, UpdateInstanceMetadata> retrievedResponse = instanceAdminClient.PollOnceUpdateInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateInstanceAsync</summary>
        public async Task UpdateInstanceAsync()
        {
            // Snippet: UpdateInstanceAsync(Instance, FieldMask, CallSettings)
            // Additional: UpdateInstanceAsync(Instance, FieldMask, CancellationToken)
            // Create client
            InstanceAdminClient instanceAdminClient = await InstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            Instance instance = new Instance();
            FieldMask fieldMask = new FieldMask();
            // Make the request
            Operation<Instance, UpdateInstanceMetadata> response = await instanceAdminClient.UpdateInstanceAsync(instance, fieldMask);

            // Poll until the returned long-running operation is complete
            Operation<Instance, UpdateInstanceMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, UpdateInstanceMetadata> retrievedResponse = await instanceAdminClient.PollOnceUpdateInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteInstance</summary>
        public void DeleteInstanceRequestObject()
        {
            // Snippet: DeleteInstance(DeleteInstanceRequest, CallSettings)
            // Create client
            InstanceAdminClient instanceAdminClient = InstanceAdminClient.Create();
            // Initialize request argument(s)
            DeleteInstanceRequest request = new DeleteInstanceRequest
            {
                InstanceName = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
            };
            // Make the request
            instanceAdminClient.DeleteInstance(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteInstanceAsync</summary>
        public async Task DeleteInstanceRequestObjectAsync()
        {
            // Snippet: DeleteInstanceAsync(DeleteInstanceRequest, CallSettings)
            // Additional: DeleteInstanceAsync(DeleteInstanceRequest, CancellationToken)
            // Create client
            InstanceAdminClient instanceAdminClient = await InstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            DeleteInstanceRequest request = new DeleteInstanceRequest
            {
                InstanceName = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
            };
            // Make the request
            await instanceAdminClient.DeleteInstanceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteInstance</summary>
        public void DeleteInstance()
        {
            // Snippet: DeleteInstance(string, CallSettings)
            // Create client
            InstanceAdminClient instanceAdminClient = InstanceAdminClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/instances/[INSTANCE]";
            // Make the request
            instanceAdminClient.DeleteInstance(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteInstanceAsync</summary>
        public async Task DeleteInstanceAsync()
        {
            // Snippet: DeleteInstanceAsync(string, CallSettings)
            // Additional: DeleteInstanceAsync(string, CancellationToken)
            // Create client
            InstanceAdminClient instanceAdminClient = await InstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/instances/[INSTANCE]";
            // Make the request
            await instanceAdminClient.DeleteInstanceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteInstance</summary>
        public void DeleteInstanceResourceNames()
        {
            // Snippet: DeleteInstance(InstanceName, CallSettings)
            // Create client
            InstanceAdminClient instanceAdminClient = InstanceAdminClient.Create();
            // Initialize request argument(s)
            InstanceName name = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]");
            // Make the request
            instanceAdminClient.DeleteInstance(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteInstanceAsync</summary>
        public async Task DeleteInstanceResourceNamesAsync()
        {
            // Snippet: DeleteInstanceAsync(InstanceName, CallSettings)
            // Additional: DeleteInstanceAsync(InstanceName, CancellationToken)
            // Create client
            InstanceAdminClient instanceAdminClient = await InstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName name = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]");
            // Make the request
            await instanceAdminClient.DeleteInstanceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicyRequestObject()
        {
            // Snippet: SetIamPolicy(SetIamPolicyRequest, CallSettings)
            // Create client
            InstanceAdminClient instanceAdminClient = InstanceAdminClient.Create();
            // Initialize request argument(s)
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Policy = new Policy(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Policy response = instanceAdminClient.SetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyRequestObjectAsync()
        {
            // Snippet: SetIamPolicyAsync(SetIamPolicyRequest, CallSettings)
            // Additional: SetIamPolicyAsync(SetIamPolicyRequest, CancellationToken)
            // Create client
            InstanceAdminClient instanceAdminClient = await InstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Policy = new Policy(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Policy response = await instanceAdminClient.SetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicy()
        {
            // Snippet: SetIamPolicy(string, Policy, CallSettings)
            // Create client
            InstanceAdminClient instanceAdminClient = InstanceAdminClient.Create();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            Policy policy = new Policy();
            // Make the request
            Policy response = instanceAdminClient.SetIamPolicy(resource, policy);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyAsync()
        {
            // Snippet: SetIamPolicyAsync(string, Policy, CallSettings)
            // Additional: SetIamPolicyAsync(string, Policy, CancellationToken)
            // Create client
            InstanceAdminClient instanceAdminClient = await InstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            Policy policy = new Policy();
            // Make the request
            Policy response = await instanceAdminClient.SetIamPolicyAsync(resource, policy);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicyResourceNames()
        {
            // Snippet: SetIamPolicy(IResourceName, Policy, CallSettings)
            // Create client
            InstanceAdminClient instanceAdminClient = InstanceAdminClient.Create();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            Policy policy = new Policy();
            // Make the request
            Policy response = instanceAdminClient.SetIamPolicy(resource, policy);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyResourceNamesAsync()
        {
            // Snippet: SetIamPolicyAsync(IResourceName, Policy, CallSettings)
            // Additional: SetIamPolicyAsync(IResourceName, Policy, CancellationToken)
            // Create client
            InstanceAdminClient instanceAdminClient = await InstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            Policy policy = new Policy();
            // Make the request
            Policy response = await instanceAdminClient.SetIamPolicyAsync(resource, policy);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicyRequestObject()
        {
            // Snippet: GetIamPolicy(GetIamPolicyRequest, CallSettings)
            // Create client
            InstanceAdminClient instanceAdminClient = InstanceAdminClient.Create();
            // Initialize request argument(s)
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Options = new GetPolicyOptions(),
            };
            // Make the request
            Policy response = instanceAdminClient.GetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyRequestObjectAsync()
        {
            // Snippet: GetIamPolicyAsync(GetIamPolicyRequest, CallSettings)
            // Additional: GetIamPolicyAsync(GetIamPolicyRequest, CancellationToken)
            // Create client
            InstanceAdminClient instanceAdminClient = await InstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Options = new GetPolicyOptions(),
            };
            // Make the request
            Policy response = await instanceAdminClient.GetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicy()
        {
            // Snippet: GetIamPolicy(string, CallSettings)
            // Create client
            InstanceAdminClient instanceAdminClient = InstanceAdminClient.Create();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            // Make the request
            Policy response = instanceAdminClient.GetIamPolicy(resource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyAsync()
        {
            // Snippet: GetIamPolicyAsync(string, CallSettings)
            // Additional: GetIamPolicyAsync(string, CancellationToken)
            // Create client
            InstanceAdminClient instanceAdminClient = await InstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            // Make the request
            Policy response = await instanceAdminClient.GetIamPolicyAsync(resource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicyResourceNames()
        {
            // Snippet: GetIamPolicy(IResourceName, CallSettings)
            // Create client
            InstanceAdminClient instanceAdminClient = InstanceAdminClient.Create();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            Policy response = instanceAdminClient.GetIamPolicy(resource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyResourceNamesAsync()
        {
            // Snippet: GetIamPolicyAsync(IResourceName, CallSettings)
            // Additional: GetIamPolicyAsync(IResourceName, CancellationToken)
            // Create client
            InstanceAdminClient instanceAdminClient = await InstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            Policy response = await instanceAdminClient.GetIamPolicyAsync(resource);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissionsRequestObject()
        {
            // Snippet: TestIamPermissions(TestIamPermissionsRequest, CallSettings)
            // Create client
            InstanceAdminClient instanceAdminClient = InstanceAdminClient.Create();
            // Initialize request argument(s)
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Permissions = { "", },
            };
            // Make the request
            TestIamPermissionsResponse response = instanceAdminClient.TestIamPermissions(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsRequestObjectAsync()
        {
            // Snippet: TestIamPermissionsAsync(TestIamPermissionsRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(TestIamPermissionsRequest, CancellationToken)
            // Create client
            InstanceAdminClient instanceAdminClient = await InstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Permissions = { "", },
            };
            // Make the request
            TestIamPermissionsResponse response = await instanceAdminClient.TestIamPermissionsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissions()
        {
            // Snippet: TestIamPermissions(string, IEnumerable<string>, CallSettings)
            // Create client
            InstanceAdminClient instanceAdminClient = InstanceAdminClient.Create();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            IEnumerable<string> permissions = new string[] { "", };
            // Make the request
            TestIamPermissionsResponse response = instanceAdminClient.TestIamPermissions(resource, permissions);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsAsync()
        {
            // Snippet: TestIamPermissionsAsync(string, IEnumerable<string>, CallSettings)
            // Additional: TestIamPermissionsAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            InstanceAdminClient instanceAdminClient = await InstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            IEnumerable<string> permissions = new string[] { "", };
            // Make the request
            TestIamPermissionsResponse response = await instanceAdminClient.TestIamPermissionsAsync(resource, permissions);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissionsResourceNames()
        {
            // Snippet: TestIamPermissions(IResourceName, IEnumerable<string>, CallSettings)
            // Create client
            InstanceAdminClient instanceAdminClient = InstanceAdminClient.Create();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            IEnumerable<string> permissions = new string[] { "", };
            // Make the request
            TestIamPermissionsResponse response = instanceAdminClient.TestIamPermissions(resource, permissions);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsResourceNamesAsync()
        {
            // Snippet: TestIamPermissionsAsync(IResourceName, IEnumerable<string>, CallSettings)
            // Additional: TestIamPermissionsAsync(IResourceName, IEnumerable<string>, CancellationToken)
            // Create client
            InstanceAdminClient instanceAdminClient = await InstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            IEnumerable<string> permissions = new string[] { "", };
            // Make the request
            TestIamPermissionsResponse response = await instanceAdminClient.TestIamPermissionsAsync(resource, permissions);
            // End snippet
        }

        /// <summary>Snippet for GetInstancePartition</summary>
        public void GetInstancePartitionRequestObject()
        {
            // Snippet: GetInstancePartition(GetInstancePartitionRequest, CallSettings)
            // Create client
            InstanceAdminClient instanceAdminClient = InstanceAdminClient.Create();
            // Initialize request argument(s)
            GetInstancePartitionRequest request = new GetInstancePartitionRequest
            {
                InstancePartitionName = InstancePartitionName.FromProjectInstanceInstancePartition("[PROJECT]", "[INSTANCE]", "[INSTANCE_PARTITION]"),
            };
            // Make the request
            InstancePartition response = instanceAdminClient.GetInstancePartition(request);
            // End snippet
        }

        /// <summary>Snippet for GetInstancePartitionAsync</summary>
        public async Task GetInstancePartitionRequestObjectAsync()
        {
            // Snippet: GetInstancePartitionAsync(GetInstancePartitionRequest, CallSettings)
            // Additional: GetInstancePartitionAsync(GetInstancePartitionRequest, CancellationToken)
            // Create client
            InstanceAdminClient instanceAdminClient = await InstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            GetInstancePartitionRequest request = new GetInstancePartitionRequest
            {
                InstancePartitionName = InstancePartitionName.FromProjectInstanceInstancePartition("[PROJECT]", "[INSTANCE]", "[INSTANCE_PARTITION]"),
            };
            // Make the request
            InstancePartition response = await instanceAdminClient.GetInstancePartitionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetInstancePartition</summary>
        public void GetInstancePartition()
        {
            // Snippet: GetInstancePartition(string, CallSettings)
            // Create client
            InstanceAdminClient instanceAdminClient = InstanceAdminClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/instances/[INSTANCE]/instancePartitions/[INSTANCE_PARTITION]";
            // Make the request
            InstancePartition response = instanceAdminClient.GetInstancePartition(name);
            // End snippet
        }

        /// <summary>Snippet for GetInstancePartitionAsync</summary>
        public async Task GetInstancePartitionAsync()
        {
            // Snippet: GetInstancePartitionAsync(string, CallSettings)
            // Additional: GetInstancePartitionAsync(string, CancellationToken)
            // Create client
            InstanceAdminClient instanceAdminClient = await InstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/instances/[INSTANCE]/instancePartitions/[INSTANCE_PARTITION]";
            // Make the request
            InstancePartition response = await instanceAdminClient.GetInstancePartitionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetInstancePartition</summary>
        public void GetInstancePartitionResourceNames()
        {
            // Snippet: GetInstancePartition(InstancePartitionName, CallSettings)
            // Create client
            InstanceAdminClient instanceAdminClient = InstanceAdminClient.Create();
            // Initialize request argument(s)
            InstancePartitionName name = InstancePartitionName.FromProjectInstanceInstancePartition("[PROJECT]", "[INSTANCE]", "[INSTANCE_PARTITION]");
            // Make the request
            InstancePartition response = instanceAdminClient.GetInstancePartition(name);
            // End snippet
        }

        /// <summary>Snippet for GetInstancePartitionAsync</summary>
        public async Task GetInstancePartitionResourceNamesAsync()
        {
            // Snippet: GetInstancePartitionAsync(InstancePartitionName, CallSettings)
            // Additional: GetInstancePartitionAsync(InstancePartitionName, CancellationToken)
            // Create client
            InstanceAdminClient instanceAdminClient = await InstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            InstancePartitionName name = InstancePartitionName.FromProjectInstanceInstancePartition("[PROJECT]", "[INSTANCE]", "[INSTANCE_PARTITION]");
            // Make the request
            InstancePartition response = await instanceAdminClient.GetInstancePartitionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateInstancePartition</summary>
        public void CreateInstancePartitionRequestObject()
        {
            // Snippet: CreateInstancePartition(CreateInstancePartitionRequest, CallSettings)
            // Create client
            InstanceAdminClient instanceAdminClient = InstanceAdminClient.Create();
            // Initialize request argument(s)
            CreateInstancePartitionRequest request = new CreateInstancePartitionRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
                InstancePartitionId = "",
                InstancePartition = new InstancePartition(),
            };
            // Make the request
            Operation<InstancePartition, CreateInstancePartitionMetadata> response = instanceAdminClient.CreateInstancePartition(request);

            // Poll until the returned long-running operation is complete
            Operation<InstancePartition, CreateInstancePartitionMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            InstancePartition result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<InstancePartition, CreateInstancePartitionMetadata> retrievedResponse = instanceAdminClient.PollOnceCreateInstancePartition(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                InstancePartition retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateInstancePartitionAsync</summary>
        public async Task CreateInstancePartitionRequestObjectAsync()
        {
            // Snippet: CreateInstancePartitionAsync(CreateInstancePartitionRequest, CallSettings)
            // Additional: CreateInstancePartitionAsync(CreateInstancePartitionRequest, CancellationToken)
            // Create client
            InstanceAdminClient instanceAdminClient = await InstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            CreateInstancePartitionRequest request = new CreateInstancePartitionRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
                InstancePartitionId = "",
                InstancePartition = new InstancePartition(),
            };
            // Make the request
            Operation<InstancePartition, CreateInstancePartitionMetadata> response = await instanceAdminClient.CreateInstancePartitionAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<InstancePartition, CreateInstancePartitionMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            InstancePartition result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<InstancePartition, CreateInstancePartitionMetadata> retrievedResponse = await instanceAdminClient.PollOnceCreateInstancePartitionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                InstancePartition retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateInstancePartition</summary>
        public void CreateInstancePartition()
        {
            // Snippet: CreateInstancePartition(string, InstancePartition, string, CallSettings)
            // Create client
            InstanceAdminClient instanceAdminClient = InstanceAdminClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/instances/[INSTANCE]";
            InstancePartition instancePartition = new InstancePartition();
            string instancePartitionId = "";
            // Make the request
            Operation<InstancePartition, CreateInstancePartitionMetadata> response = instanceAdminClient.CreateInstancePartition(parent, instancePartition, instancePartitionId);

            // Poll until the returned long-running operation is complete
            Operation<InstancePartition, CreateInstancePartitionMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            InstancePartition result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<InstancePartition, CreateInstancePartitionMetadata> retrievedResponse = instanceAdminClient.PollOnceCreateInstancePartition(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                InstancePartition retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateInstancePartitionAsync</summary>
        public async Task CreateInstancePartitionAsync()
        {
            // Snippet: CreateInstancePartitionAsync(string, InstancePartition, string, CallSettings)
            // Additional: CreateInstancePartitionAsync(string, InstancePartition, string, CancellationToken)
            // Create client
            InstanceAdminClient instanceAdminClient = await InstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/instances/[INSTANCE]";
            InstancePartition instancePartition = new InstancePartition();
            string instancePartitionId = "";
            // Make the request
            Operation<InstancePartition, CreateInstancePartitionMetadata> response = await instanceAdminClient.CreateInstancePartitionAsync(parent, instancePartition, instancePartitionId);

            // Poll until the returned long-running operation is complete
            Operation<InstancePartition, CreateInstancePartitionMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            InstancePartition result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<InstancePartition, CreateInstancePartitionMetadata> retrievedResponse = await instanceAdminClient.PollOnceCreateInstancePartitionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                InstancePartition retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateInstancePartition</summary>
        public void CreateInstancePartitionResourceNames()
        {
            // Snippet: CreateInstancePartition(InstanceName, InstancePartition, string, CallSettings)
            // Create client
            InstanceAdminClient instanceAdminClient = InstanceAdminClient.Create();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]");
            InstancePartition instancePartition = new InstancePartition();
            string instancePartitionId = "";
            // Make the request
            Operation<InstancePartition, CreateInstancePartitionMetadata> response = instanceAdminClient.CreateInstancePartition(parent, instancePartition, instancePartitionId);

            // Poll until the returned long-running operation is complete
            Operation<InstancePartition, CreateInstancePartitionMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            InstancePartition result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<InstancePartition, CreateInstancePartitionMetadata> retrievedResponse = instanceAdminClient.PollOnceCreateInstancePartition(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                InstancePartition retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateInstancePartitionAsync</summary>
        public async Task CreateInstancePartitionResourceNamesAsync()
        {
            // Snippet: CreateInstancePartitionAsync(InstanceName, InstancePartition, string, CallSettings)
            // Additional: CreateInstancePartitionAsync(InstanceName, InstancePartition, string, CancellationToken)
            // Create client
            InstanceAdminClient instanceAdminClient = await InstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]");
            InstancePartition instancePartition = new InstancePartition();
            string instancePartitionId = "";
            // Make the request
            Operation<InstancePartition, CreateInstancePartitionMetadata> response = await instanceAdminClient.CreateInstancePartitionAsync(parent, instancePartition, instancePartitionId);

            // Poll until the returned long-running operation is complete
            Operation<InstancePartition, CreateInstancePartitionMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            InstancePartition result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<InstancePartition, CreateInstancePartitionMetadata> retrievedResponse = await instanceAdminClient.PollOnceCreateInstancePartitionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                InstancePartition retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteInstancePartition</summary>
        public void DeleteInstancePartitionRequestObject()
        {
            // Snippet: DeleteInstancePartition(DeleteInstancePartitionRequest, CallSettings)
            // Create client
            InstanceAdminClient instanceAdminClient = InstanceAdminClient.Create();
            // Initialize request argument(s)
            DeleteInstancePartitionRequest request = new DeleteInstancePartitionRequest
            {
                InstancePartitionName = InstancePartitionName.FromProjectInstanceInstancePartition("[PROJECT]", "[INSTANCE]", "[INSTANCE_PARTITION]"),
                Etag = "",
            };
            // Make the request
            instanceAdminClient.DeleteInstancePartition(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteInstancePartitionAsync</summary>
        public async Task DeleteInstancePartitionRequestObjectAsync()
        {
            // Snippet: DeleteInstancePartitionAsync(DeleteInstancePartitionRequest, CallSettings)
            // Additional: DeleteInstancePartitionAsync(DeleteInstancePartitionRequest, CancellationToken)
            // Create client
            InstanceAdminClient instanceAdminClient = await InstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            DeleteInstancePartitionRequest request = new DeleteInstancePartitionRequest
            {
                InstancePartitionName = InstancePartitionName.FromProjectInstanceInstancePartition("[PROJECT]", "[INSTANCE]", "[INSTANCE_PARTITION]"),
                Etag = "",
            };
            // Make the request
            await instanceAdminClient.DeleteInstancePartitionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteInstancePartition</summary>
        public void DeleteInstancePartition()
        {
            // Snippet: DeleteInstancePartition(string, CallSettings)
            // Create client
            InstanceAdminClient instanceAdminClient = InstanceAdminClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/instances/[INSTANCE]/instancePartitions/[INSTANCE_PARTITION]";
            // Make the request
            instanceAdminClient.DeleteInstancePartition(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteInstancePartitionAsync</summary>
        public async Task DeleteInstancePartitionAsync()
        {
            // Snippet: DeleteInstancePartitionAsync(string, CallSettings)
            // Additional: DeleteInstancePartitionAsync(string, CancellationToken)
            // Create client
            InstanceAdminClient instanceAdminClient = await InstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/instances/[INSTANCE]/instancePartitions/[INSTANCE_PARTITION]";
            // Make the request
            await instanceAdminClient.DeleteInstancePartitionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteInstancePartition</summary>
        public void DeleteInstancePartitionResourceNames()
        {
            // Snippet: DeleteInstancePartition(InstancePartitionName, CallSettings)
            // Create client
            InstanceAdminClient instanceAdminClient = InstanceAdminClient.Create();
            // Initialize request argument(s)
            InstancePartitionName name = InstancePartitionName.FromProjectInstanceInstancePartition("[PROJECT]", "[INSTANCE]", "[INSTANCE_PARTITION]");
            // Make the request
            instanceAdminClient.DeleteInstancePartition(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteInstancePartitionAsync</summary>
        public async Task DeleteInstancePartitionResourceNamesAsync()
        {
            // Snippet: DeleteInstancePartitionAsync(InstancePartitionName, CallSettings)
            // Additional: DeleteInstancePartitionAsync(InstancePartitionName, CancellationToken)
            // Create client
            InstanceAdminClient instanceAdminClient = await InstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            InstancePartitionName name = InstancePartitionName.FromProjectInstanceInstancePartition("[PROJECT]", "[INSTANCE]", "[INSTANCE_PARTITION]");
            // Make the request
            await instanceAdminClient.DeleteInstancePartitionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateInstancePartition</summary>
        public void UpdateInstancePartitionRequestObject()
        {
            // Snippet: UpdateInstancePartition(UpdateInstancePartitionRequest, CallSettings)
            // Create client
            InstanceAdminClient instanceAdminClient = InstanceAdminClient.Create();
            // Initialize request argument(s)
            UpdateInstancePartitionRequest request = new UpdateInstancePartitionRequest
            {
                InstancePartition = new InstancePartition(),
                FieldMask = new FieldMask(),
            };
            // Make the request
            Operation<InstancePartition, UpdateInstancePartitionMetadata> response = instanceAdminClient.UpdateInstancePartition(request);

            // Poll until the returned long-running operation is complete
            Operation<InstancePartition, UpdateInstancePartitionMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            InstancePartition result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<InstancePartition, UpdateInstancePartitionMetadata> retrievedResponse = instanceAdminClient.PollOnceUpdateInstancePartition(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                InstancePartition retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateInstancePartitionAsync</summary>
        public async Task UpdateInstancePartitionRequestObjectAsync()
        {
            // Snippet: UpdateInstancePartitionAsync(UpdateInstancePartitionRequest, CallSettings)
            // Additional: UpdateInstancePartitionAsync(UpdateInstancePartitionRequest, CancellationToken)
            // Create client
            InstanceAdminClient instanceAdminClient = await InstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            UpdateInstancePartitionRequest request = new UpdateInstancePartitionRequest
            {
                InstancePartition = new InstancePartition(),
                FieldMask = new FieldMask(),
            };
            // Make the request
            Operation<InstancePartition, UpdateInstancePartitionMetadata> response = await instanceAdminClient.UpdateInstancePartitionAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<InstancePartition, UpdateInstancePartitionMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            InstancePartition result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<InstancePartition, UpdateInstancePartitionMetadata> retrievedResponse = await instanceAdminClient.PollOnceUpdateInstancePartitionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                InstancePartition retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateInstancePartition</summary>
        public void UpdateInstancePartition()
        {
            // Snippet: UpdateInstancePartition(InstancePartition, FieldMask, CallSettings)
            // Create client
            InstanceAdminClient instanceAdminClient = InstanceAdminClient.Create();
            // Initialize request argument(s)
            InstancePartition instancePartition = new InstancePartition();
            FieldMask fieldMask = new FieldMask();
            // Make the request
            Operation<InstancePartition, UpdateInstancePartitionMetadata> response = instanceAdminClient.UpdateInstancePartition(instancePartition, fieldMask);

            // Poll until the returned long-running operation is complete
            Operation<InstancePartition, UpdateInstancePartitionMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            InstancePartition result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<InstancePartition, UpdateInstancePartitionMetadata> retrievedResponse = instanceAdminClient.PollOnceUpdateInstancePartition(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                InstancePartition retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateInstancePartitionAsync</summary>
        public async Task UpdateInstancePartitionAsync()
        {
            // Snippet: UpdateInstancePartitionAsync(InstancePartition, FieldMask, CallSettings)
            // Additional: UpdateInstancePartitionAsync(InstancePartition, FieldMask, CancellationToken)
            // Create client
            InstanceAdminClient instanceAdminClient = await InstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            InstancePartition instancePartition = new InstancePartition();
            FieldMask fieldMask = new FieldMask();
            // Make the request
            Operation<InstancePartition, UpdateInstancePartitionMetadata> response = await instanceAdminClient.UpdateInstancePartitionAsync(instancePartition, fieldMask);

            // Poll until the returned long-running operation is complete
            Operation<InstancePartition, UpdateInstancePartitionMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            InstancePartition result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<InstancePartition, UpdateInstancePartitionMetadata> retrievedResponse = await instanceAdminClient.PollOnceUpdateInstancePartitionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                InstancePartition retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListInstancePartitionOperations</summary>
        public void ListInstancePartitionOperationsRequestObject()
        {
            // Snippet: ListInstancePartitionOperations(ListInstancePartitionOperationsRequest, CallSettings)
            // Create client
            InstanceAdminClient instanceAdminClient = InstanceAdminClient.Create();
            // Initialize request argument(s)
            ListInstancePartitionOperationsRequest request = new ListInstancePartitionOperationsRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
                Filter = "",
                InstancePartitionDeadline = new Timestamp(),
            };
            // Make the request
            PagedEnumerable<ListInstancePartitionOperationsResponse, Operation> response = instanceAdminClient.ListInstancePartitionOperations(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Operation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListInstancePartitionOperationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Operation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Operation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Operation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInstancePartitionOperationsAsync</summary>
        public async Task ListInstancePartitionOperationsRequestObjectAsync()
        {
            // Snippet: ListInstancePartitionOperationsAsync(ListInstancePartitionOperationsRequest, CallSettings)
            // Create client
            InstanceAdminClient instanceAdminClient = await InstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            ListInstancePartitionOperationsRequest request = new ListInstancePartitionOperationsRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
                Filter = "",
                InstancePartitionDeadline = new Timestamp(),
            };
            // Make the request
            PagedAsyncEnumerable<ListInstancePartitionOperationsResponse, Operation> response = instanceAdminClient.ListInstancePartitionOperationsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Operation item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListInstancePartitionOperationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Operation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Operation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Operation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInstancePartitionOperations</summary>
        public void ListInstancePartitionOperations()
        {
            // Snippet: ListInstancePartitionOperations(string, string, int?, CallSettings)
            // Create client
            InstanceAdminClient instanceAdminClient = InstanceAdminClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/instances/[INSTANCE]";
            // Make the request
            PagedEnumerable<ListInstancePartitionOperationsResponse, Operation> response = instanceAdminClient.ListInstancePartitionOperations(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Operation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListInstancePartitionOperationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Operation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Operation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Operation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInstancePartitionOperationsAsync</summary>
        public async Task ListInstancePartitionOperationsAsync()
        {
            // Snippet: ListInstancePartitionOperationsAsync(string, string, int?, CallSettings)
            // Create client
            InstanceAdminClient instanceAdminClient = await InstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/instances/[INSTANCE]";
            // Make the request
            PagedAsyncEnumerable<ListInstancePartitionOperationsResponse, Operation> response = instanceAdminClient.ListInstancePartitionOperationsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Operation item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListInstancePartitionOperationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Operation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Operation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Operation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInstancePartitionOperations</summary>
        public void ListInstancePartitionOperationsResourceNames()
        {
            // Snippet: ListInstancePartitionOperations(InstanceName, string, int?, CallSettings)
            // Create client
            InstanceAdminClient instanceAdminClient = InstanceAdminClient.Create();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]");
            // Make the request
            PagedEnumerable<ListInstancePartitionOperationsResponse, Operation> response = instanceAdminClient.ListInstancePartitionOperations(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Operation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListInstancePartitionOperationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Operation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Operation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Operation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInstancePartitionOperationsAsync</summary>
        public async Task ListInstancePartitionOperationsResourceNamesAsync()
        {
            // Snippet: ListInstancePartitionOperationsAsync(InstanceName, string, int?, CallSettings)
            // Create client
            InstanceAdminClient instanceAdminClient = await InstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]");
            // Make the request
            PagedAsyncEnumerable<ListInstancePartitionOperationsResponse, Operation> response = instanceAdminClient.ListInstancePartitionOperationsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Operation item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListInstancePartitionOperationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Operation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Operation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Operation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for MoveInstance</summary>
        public void MoveInstanceRequestObject()
        {
            // Snippet: MoveInstance(MoveInstanceRequest, CallSettings)
            // Create client
            InstanceAdminClient instanceAdminClient = InstanceAdminClient.Create();
            // Initialize request argument(s)
            MoveInstanceRequest request = new MoveInstanceRequest
            {
                InstanceName = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
                TargetConfigAsInstanceConfigName = InstanceConfigName.FromProjectInstanceConfig("[PROJECT]", "[INSTANCE_CONFIG]"),
            };
            // Make the request
            Operation<MoveInstanceResponse, MoveInstanceMetadata> response = instanceAdminClient.MoveInstance(request);

            // Poll until the returned long-running operation is complete
            Operation<MoveInstanceResponse, MoveInstanceMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            MoveInstanceResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MoveInstanceResponse, MoveInstanceMetadata> retrievedResponse = instanceAdminClient.PollOnceMoveInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MoveInstanceResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for MoveInstanceAsync</summary>
        public async Task MoveInstanceRequestObjectAsync()
        {
            // Snippet: MoveInstanceAsync(MoveInstanceRequest, CallSettings)
            // Additional: MoveInstanceAsync(MoveInstanceRequest, CancellationToken)
            // Create client
            InstanceAdminClient instanceAdminClient = await InstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            MoveInstanceRequest request = new MoveInstanceRequest
            {
                InstanceName = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
                TargetConfigAsInstanceConfigName = InstanceConfigName.FromProjectInstanceConfig("[PROJECT]", "[INSTANCE_CONFIG]"),
            };
            // Make the request
            Operation<MoveInstanceResponse, MoveInstanceMetadata> response = await instanceAdminClient.MoveInstanceAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<MoveInstanceResponse, MoveInstanceMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            MoveInstanceResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MoveInstanceResponse, MoveInstanceMetadata> retrievedResponse = await instanceAdminClient.PollOnceMoveInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MoveInstanceResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
