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
using Google.Cloud.Spanner.Admin.Instance.V1;
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

namespace Google.Cloud.Spanner.Admin.Instance.V1.Snippets
{
    public class GeneratedInstanceAdminClientSnippets
    {
        public async Task ListInstanceConfigsAsync()
        {
            // Snippet: ListInstanceConfigsAsync(ProjectName,string,int?,CallSettings)
            // Create client
            InstanceAdminClient instanceAdminClient = await InstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = new ProjectName("[PROJECT]");
            // Make the request
            PagedAsyncEnumerable<ListInstanceConfigsResponse,InstanceConfig> response =
                instanceAdminClient.ListInstanceConfigsAsync(parent);

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
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        public void ListInstanceConfigs()
        {
            // Snippet: ListInstanceConfigs(ProjectName,string,int?,CallSettings)
            // Create client
            InstanceAdminClient instanceAdminClient = InstanceAdminClient.Create();
            // Initialize request argument(s)
            ProjectName parent = new ProjectName("[PROJECT]");
            // Make the request
            PagedEnumerable<ListInstanceConfigsResponse,InstanceConfig> response =
                instanceAdminClient.ListInstanceConfigs(parent);

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
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        public async Task ListInstanceConfigsAsync_RequestObject()
        {
            // Snippet: ListInstanceConfigsAsync(ListInstanceConfigsRequest,CallSettings)
            // Create client
            InstanceAdminClient instanceAdminClient = await InstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            ListInstanceConfigsRequest request = new ListInstanceConfigsRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListInstanceConfigsResponse,InstanceConfig> response =
                instanceAdminClient.ListInstanceConfigsAsync(request);

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
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        public void ListInstanceConfigs_RequestObject()
        {
            // Snippet: ListInstanceConfigs(ListInstanceConfigsRequest,CallSettings)
            // Create client
            InstanceAdminClient instanceAdminClient = InstanceAdminClient.Create();
            // Initialize request argument(s)
            ListInstanceConfigsRequest request = new ListInstanceConfigsRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
            };
            // Make the request
            PagedEnumerable<ListInstanceConfigsResponse,InstanceConfig> response =
                instanceAdminClient.ListInstanceConfigs(request);

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
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        public async Task GetInstanceConfigAsync()
        {
            // Snippet: GetInstanceConfigAsync(InstanceConfigName,CallSettings)
            // Additional: GetInstanceConfigAsync(InstanceConfigName,CancellationToken)
            // Create client
            InstanceAdminClient instanceAdminClient = await InstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            InstanceConfigName name = new InstanceConfigName("[PROJECT]", "[INSTANCE_CONFIG]");
            // Make the request
            InstanceConfig response = await instanceAdminClient.GetInstanceConfigAsync(name);
            // End snippet
        }

        public void GetInstanceConfig()
        {
            // Snippet: GetInstanceConfig(InstanceConfigName,CallSettings)
            // Create client
            InstanceAdminClient instanceAdminClient = InstanceAdminClient.Create();
            // Initialize request argument(s)
            InstanceConfigName name = new InstanceConfigName("[PROJECT]", "[INSTANCE_CONFIG]");
            // Make the request
            InstanceConfig response = instanceAdminClient.GetInstanceConfig(name);
            // End snippet
        }

        public async Task GetInstanceConfigAsync_RequestObject()
        {
            // Snippet: GetInstanceConfigAsync(GetInstanceConfigRequest,CallSettings)
            // Create client
            InstanceAdminClient instanceAdminClient = await InstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            GetInstanceConfigRequest request = new GetInstanceConfigRequest
            {
                InstanceConfigName = new InstanceConfigName("[PROJECT]", "[INSTANCE_CONFIG]"),
            };
            // Make the request
            InstanceConfig response = await instanceAdminClient.GetInstanceConfigAsync(request);
            // End snippet
        }

        public void GetInstanceConfig_RequestObject()
        {
            // Snippet: GetInstanceConfig(GetInstanceConfigRequest,CallSettings)
            // Create client
            InstanceAdminClient instanceAdminClient = InstanceAdminClient.Create();
            // Initialize request argument(s)
            GetInstanceConfigRequest request = new GetInstanceConfigRequest
            {
                InstanceConfigName = new InstanceConfigName("[PROJECT]", "[INSTANCE_CONFIG]"),
            };
            // Make the request
            InstanceConfig response = instanceAdminClient.GetInstanceConfig(request);
            // End snippet
        }

        public async Task ListInstancesAsync()
        {
            // Snippet: ListInstancesAsync(ProjectName,string,int?,CallSettings)
            // Create client
            InstanceAdminClient instanceAdminClient = await InstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = new ProjectName("[PROJECT]");
            // Make the request
            PagedAsyncEnumerable<ListInstancesResponse,Instance> response =
                instanceAdminClient.ListInstancesAsync(parent);

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
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        public void ListInstances()
        {
            // Snippet: ListInstances(ProjectName,string,int?,CallSettings)
            // Create client
            InstanceAdminClient instanceAdminClient = InstanceAdminClient.Create();
            // Initialize request argument(s)
            ProjectName parent = new ProjectName("[PROJECT]");
            // Make the request
            PagedEnumerable<ListInstancesResponse,Instance> response =
                instanceAdminClient.ListInstances(parent);

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
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        public async Task ListInstancesAsync_RequestObject()
        {
            // Snippet: ListInstancesAsync(ListInstancesRequest,CallSettings)
            // Create client
            InstanceAdminClient instanceAdminClient = await InstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            ListInstancesRequest request = new ListInstancesRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListInstancesResponse,Instance> response =
                instanceAdminClient.ListInstancesAsync(request);

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
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        public void ListInstances_RequestObject()
        {
            // Snippet: ListInstances(ListInstancesRequest,CallSettings)
            // Create client
            InstanceAdminClient instanceAdminClient = InstanceAdminClient.Create();
            // Initialize request argument(s)
            ListInstancesRequest request = new ListInstancesRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
            };
            // Make the request
            PagedEnumerable<ListInstancesResponse,Instance> response =
                instanceAdminClient.ListInstances(request);

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
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        public async Task GetInstanceAsync()
        {
            // Snippet: GetInstanceAsync(InstanceName,CallSettings)
            // Additional: GetInstanceAsync(InstanceName,CancellationToken)
            // Create client
            InstanceAdminClient instanceAdminClient = await InstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName name = new InstanceName("[PROJECT]", "[INSTANCE]");
            // Make the request
            Instance response = await instanceAdminClient.GetInstanceAsync(name);
            // End snippet
        }

        public void GetInstance()
        {
            // Snippet: GetInstance(InstanceName,CallSettings)
            // Create client
            InstanceAdminClient instanceAdminClient = InstanceAdminClient.Create();
            // Initialize request argument(s)
            InstanceName name = new InstanceName("[PROJECT]", "[INSTANCE]");
            // Make the request
            Instance response = instanceAdminClient.GetInstance(name);
            // End snippet
        }

        public async Task GetInstanceAsync_RequestObject()
        {
            // Snippet: GetInstanceAsync(GetInstanceRequest,CallSettings)
            // Create client
            InstanceAdminClient instanceAdminClient = await InstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            GetInstanceRequest request = new GetInstanceRequest
            {
                InstanceName = new InstanceName("[PROJECT]", "[INSTANCE]"),
            };
            // Make the request
            Instance response = await instanceAdminClient.GetInstanceAsync(request);
            // End snippet
        }

        public void GetInstance_RequestObject()
        {
            // Snippet: GetInstance(GetInstanceRequest,CallSettings)
            // Create client
            InstanceAdminClient instanceAdminClient = InstanceAdminClient.Create();
            // Initialize request argument(s)
            GetInstanceRequest request = new GetInstanceRequest
            {
                InstanceName = new InstanceName("[PROJECT]", "[INSTANCE]"),
            };
            // Make the request
            Instance response = instanceAdminClient.GetInstance(request);
            // End snippet
        }

        public async Task CreateInstanceAsync()
        {
            // Snippet: CreateInstanceAsync(ProjectName,InstanceName,Instance,CallSettings)
            // Additional: CreateInstanceAsync(ProjectName,InstanceName,Instance,CancellationToken)
            // Create client
            InstanceAdminClient instanceAdminClient = await InstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = new ProjectName("[PROJECT]");
            InstanceName instanceId = new InstanceName("[PROJECT]", "[INSTANCE]");
            Instance instance = new Instance();
            // Make the request
            Operation<Instance, CreateInstanceMetadata> response =
                await instanceAdminClient.CreateInstanceAsync(parent, instanceId, instance);

            // Poll until the returned long-running operation is complete
            Operation<Instance, CreateInstanceMetadata> completedResponse =
                await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, CreateInstanceMetadata> retrievedResponse =
                await instanceAdminClient.PollOnceCreateInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        public void CreateInstance()
        {
            // Snippet: CreateInstance(ProjectName,InstanceName,Instance,CallSettings)
            // Create client
            InstanceAdminClient instanceAdminClient = InstanceAdminClient.Create();
            // Initialize request argument(s)
            ProjectName parent = new ProjectName("[PROJECT]");
            InstanceName instanceId = new InstanceName("[PROJECT]", "[INSTANCE]");
            Instance instance = new Instance();
            // Make the request
            Operation<Instance, CreateInstanceMetadata> response =
                instanceAdminClient.CreateInstance(parent, instanceId, instance);

            // Poll until the returned long-running operation is complete
            Operation<Instance, CreateInstanceMetadata> completedResponse =
                response.PollUntilCompleted();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, CreateInstanceMetadata> retrievedResponse =
                instanceAdminClient.PollOnceCreateInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        public async Task CreateInstanceAsync_RequestObject()
        {
            // Snippet: CreateInstanceAsync(CreateInstanceRequest,CallSettings)
            // Create client
            InstanceAdminClient instanceAdminClient = await InstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            CreateInstanceRequest request = new CreateInstanceRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
                InstanceIdAsInstanceName = new InstanceName("[PROJECT]", "[INSTANCE]"),
                Instance = new Instance(),
            };
            // Make the request
            Operation<Instance, CreateInstanceMetadata> response =
                await instanceAdminClient.CreateInstanceAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Instance, CreateInstanceMetadata> completedResponse =
                await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, CreateInstanceMetadata> retrievedResponse =
                await instanceAdminClient.PollOnceCreateInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        public void CreateInstance_RequestObject()
        {
            // Snippet: CreateInstance(CreateInstanceRequest,CallSettings)
            // Create client
            InstanceAdminClient instanceAdminClient = InstanceAdminClient.Create();
            // Initialize request argument(s)
            CreateInstanceRequest request = new CreateInstanceRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
                InstanceIdAsInstanceName = new InstanceName("[PROJECT]", "[INSTANCE]"),
                Instance = new Instance(),
            };
            // Make the request
            Operation<Instance, CreateInstanceMetadata> response =
                instanceAdminClient.CreateInstance(request);

            // Poll until the returned long-running operation is complete
            Operation<Instance, CreateInstanceMetadata> completedResponse =
                response.PollUntilCompleted();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, CreateInstanceMetadata> retrievedResponse =
                instanceAdminClient.PollOnceCreateInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        public async Task UpdateInstanceAsync()
        {
            // Snippet: UpdateInstanceAsync(Instance,FieldMask,CallSettings)
            // Additional: UpdateInstanceAsync(Instance,FieldMask,CancellationToken)
            // Create client
            InstanceAdminClient instanceAdminClient = await InstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            Instance instance = new Instance();
            FieldMask fieldMask = new FieldMask();
            // Make the request
            Operation<Instance, CreateInstanceMetadata> response =
                await instanceAdminClient.UpdateInstanceAsync(instance, fieldMask);

            // Poll until the returned long-running operation is complete
            Operation<Instance, CreateInstanceMetadata> completedResponse =
                await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, CreateInstanceMetadata> retrievedResponse =
                await instanceAdminClient.PollOnceUpdateInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        public void UpdateInstance()
        {
            // Snippet: UpdateInstance(Instance,FieldMask,CallSettings)
            // Create client
            InstanceAdminClient instanceAdminClient = InstanceAdminClient.Create();
            // Initialize request argument(s)
            Instance instance = new Instance();
            FieldMask fieldMask = new FieldMask();
            // Make the request
            Operation<Instance, CreateInstanceMetadata> response =
                instanceAdminClient.UpdateInstance(instance, fieldMask);

            // Poll until the returned long-running operation is complete
            Operation<Instance, CreateInstanceMetadata> completedResponse =
                response.PollUntilCompleted();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, CreateInstanceMetadata> retrievedResponse =
                instanceAdminClient.PollOnceUpdateInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        public async Task UpdateInstanceAsync_RequestObject()
        {
            // Snippet: UpdateInstanceAsync(UpdateInstanceRequest,CallSettings)
            // Create client
            InstanceAdminClient instanceAdminClient = await InstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            UpdateInstanceRequest request = new UpdateInstanceRequest
            {
                Instance = new Instance(),
                FieldMask = new FieldMask(),
            };
            // Make the request
            Operation<Instance, CreateInstanceMetadata> response =
                await instanceAdminClient.UpdateInstanceAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Instance, CreateInstanceMetadata> completedResponse =
                await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, CreateInstanceMetadata> retrievedResponse =
                await instanceAdminClient.PollOnceUpdateInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        public void UpdateInstance_RequestObject()
        {
            // Snippet: UpdateInstance(UpdateInstanceRequest,CallSettings)
            // Create client
            InstanceAdminClient instanceAdminClient = InstanceAdminClient.Create();
            // Initialize request argument(s)
            UpdateInstanceRequest request = new UpdateInstanceRequest
            {
                Instance = new Instance(),
                FieldMask = new FieldMask(),
            };
            // Make the request
            Operation<Instance, CreateInstanceMetadata> response =
                instanceAdminClient.UpdateInstance(request);

            // Poll until the returned long-running operation is complete
            Operation<Instance, CreateInstanceMetadata> completedResponse =
                response.PollUntilCompleted();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, CreateInstanceMetadata> retrievedResponse =
                instanceAdminClient.PollOnceUpdateInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        public async Task DeleteInstanceAsync()
        {
            // Snippet: DeleteInstanceAsync(InstanceName,CallSettings)
            // Additional: DeleteInstanceAsync(InstanceName,CancellationToken)
            // Create client
            InstanceAdminClient instanceAdminClient = await InstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName name = new InstanceName("[PROJECT]", "[INSTANCE]");
            // Make the request
            await instanceAdminClient.DeleteInstanceAsync(name);
            // End snippet
        }

        public void DeleteInstance()
        {
            // Snippet: DeleteInstance(InstanceName,CallSettings)
            // Create client
            InstanceAdminClient instanceAdminClient = InstanceAdminClient.Create();
            // Initialize request argument(s)
            InstanceName name = new InstanceName("[PROJECT]", "[INSTANCE]");
            // Make the request
            instanceAdminClient.DeleteInstance(name);
            // End snippet
        }

        public async Task DeleteInstanceAsync_RequestObject()
        {
            // Snippet: DeleteInstanceAsync(DeleteInstanceRequest,CallSettings)
            // Create client
            InstanceAdminClient instanceAdminClient = await InstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            DeleteInstanceRequest request = new DeleteInstanceRequest
            {
                InstanceName = new InstanceName("[PROJECT]", "[INSTANCE]"),
            };
            // Make the request
            await instanceAdminClient.DeleteInstanceAsync(request);
            // End snippet
        }

        public void DeleteInstance_RequestObject()
        {
            // Snippet: DeleteInstance(DeleteInstanceRequest,CallSettings)
            // Create client
            InstanceAdminClient instanceAdminClient = InstanceAdminClient.Create();
            // Initialize request argument(s)
            DeleteInstanceRequest request = new DeleteInstanceRequest
            {
                InstanceName = new InstanceName("[PROJECT]", "[INSTANCE]"),
            };
            // Make the request
            instanceAdminClient.DeleteInstance(request);
            // End snippet
        }

        public async Task SetIamPolicyAsync()
        {
            // Snippet: SetIamPolicyAsync(string,Policy,CallSettings)
            // Additional: SetIamPolicyAsync(string,Policy,CancellationToken)
            // Create client
            InstanceAdminClient instanceAdminClient = await InstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            string formattedResource = new InstanceName("[PROJECT]", "[INSTANCE]").ToString();
            Policy policy = new Policy();
            // Make the request
            Policy response = await instanceAdminClient.SetIamPolicyAsync(formattedResource, policy);
            // End snippet
        }

        public void SetIamPolicy()
        {
            // Snippet: SetIamPolicy(string,Policy,CallSettings)
            // Create client
            InstanceAdminClient instanceAdminClient = InstanceAdminClient.Create();
            // Initialize request argument(s)
            string formattedResource = new InstanceName("[PROJECT]", "[INSTANCE]").ToString();
            Policy policy = new Policy();
            // Make the request
            Policy response = instanceAdminClient.SetIamPolicy(formattedResource, policy);
            // End snippet
        }

        public async Task SetIamPolicyAsync_RequestObject()
        {
            // Snippet: SetIamPolicyAsync(SetIamPolicyRequest,CallSettings)
            // Create client
            InstanceAdminClient instanceAdminClient = await InstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                Resource = new InstanceName("[PROJECT]", "[INSTANCE]").ToString(),
                Policy = new Policy(),
            };
            // Make the request
            Policy response = await instanceAdminClient.SetIamPolicyAsync(request);
            // End snippet
        }

        public void SetIamPolicy_RequestObject()
        {
            // Snippet: SetIamPolicy(SetIamPolicyRequest,CallSettings)
            // Create client
            InstanceAdminClient instanceAdminClient = InstanceAdminClient.Create();
            // Initialize request argument(s)
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                Resource = new InstanceName("[PROJECT]", "[INSTANCE]").ToString(),
                Policy = new Policy(),
            };
            // Make the request
            Policy response = instanceAdminClient.SetIamPolicy(request);
            // End snippet
        }

        public async Task GetIamPolicyAsync()
        {
            // Snippet: GetIamPolicyAsync(string,CallSettings)
            // Additional: GetIamPolicyAsync(string,CancellationToken)
            // Create client
            InstanceAdminClient instanceAdminClient = await InstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            string formattedResource = new InstanceName("[PROJECT]", "[INSTANCE]").ToString();
            // Make the request
            Policy response = await instanceAdminClient.GetIamPolicyAsync(formattedResource);
            // End snippet
        }

        public void GetIamPolicy()
        {
            // Snippet: GetIamPolicy(string,CallSettings)
            // Create client
            InstanceAdminClient instanceAdminClient = InstanceAdminClient.Create();
            // Initialize request argument(s)
            string formattedResource = new InstanceName("[PROJECT]", "[INSTANCE]").ToString();
            // Make the request
            Policy response = instanceAdminClient.GetIamPolicy(formattedResource);
            // End snippet
        }

        public async Task GetIamPolicyAsync_RequestObject()
        {
            // Snippet: GetIamPolicyAsync(GetIamPolicyRequest,CallSettings)
            // Create client
            InstanceAdminClient instanceAdminClient = await InstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                Resource = new InstanceName("[PROJECT]", "[INSTANCE]").ToString(),
            };
            // Make the request
            Policy response = await instanceAdminClient.GetIamPolicyAsync(request);
            // End snippet
        }

        public void GetIamPolicy_RequestObject()
        {
            // Snippet: GetIamPolicy(GetIamPolicyRequest,CallSettings)
            // Create client
            InstanceAdminClient instanceAdminClient = InstanceAdminClient.Create();
            // Initialize request argument(s)
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                Resource = new InstanceName("[PROJECT]", "[INSTANCE]").ToString(),
            };
            // Make the request
            Policy response = instanceAdminClient.GetIamPolicy(request);
            // End snippet
        }

        public async Task TestIamPermissionsAsync()
        {
            // Snippet: TestIamPermissionsAsync(string,IEnumerable<string>,CallSettings)
            // Additional: TestIamPermissionsAsync(string,IEnumerable<string>,CancellationToken)
            // Create client
            InstanceAdminClient instanceAdminClient = await InstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            string formattedResource = new InstanceName("[PROJECT]", "[INSTANCE]").ToString();
            IEnumerable<string> permissions = new List<string>();
            // Make the request
            TestIamPermissionsResponse response = await instanceAdminClient.TestIamPermissionsAsync(formattedResource, permissions);
            // End snippet
        }

        public void TestIamPermissions()
        {
            // Snippet: TestIamPermissions(string,IEnumerable<string>,CallSettings)
            // Create client
            InstanceAdminClient instanceAdminClient = InstanceAdminClient.Create();
            // Initialize request argument(s)
            string formattedResource = new InstanceName("[PROJECT]", "[INSTANCE]").ToString();
            IEnumerable<string> permissions = new List<string>();
            // Make the request
            TestIamPermissionsResponse response = instanceAdminClient.TestIamPermissions(formattedResource, permissions);
            // End snippet
        }

        public async Task TestIamPermissionsAsync_RequestObject()
        {
            // Snippet: TestIamPermissionsAsync(TestIamPermissionsRequest,CallSettings)
            // Create client
            InstanceAdminClient instanceAdminClient = await InstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                Resource = new InstanceName("[PROJECT]", "[INSTANCE]").ToString(),
                Permissions = { },
            };
            // Make the request
            TestIamPermissionsResponse response = await instanceAdminClient.TestIamPermissionsAsync(request);
            // End snippet
        }

        public void TestIamPermissions_RequestObject()
        {
            // Snippet: TestIamPermissions(TestIamPermissionsRequest,CallSettings)
            // Create client
            InstanceAdminClient instanceAdminClient = InstanceAdminClient.Create();
            // Initialize request argument(s)
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                Resource = new InstanceName("[PROJECT]", "[INSTANCE]").ToString(),
                Permissions = { },
            };
            // Make the request
            TestIamPermissionsResponse response = instanceAdminClient.TestIamPermissions(request);
            // End snippet
        }

    }
}
