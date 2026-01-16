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

#pragma warning disable CS8981

namespace GoogleCSharpSnippets
{
    using Google.Api.Gax;
    using Google.Api.Gax.ResourceNames;
    using Google.LongRunning;
    using System;
    using System.Threading.Tasks;
    using gcrv = Google.Cloud.Run.V2;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedInstancesClientSnippets
    {
        /// <summary>Snippet for CreateInstance</summary>
        public void CreateInstanceRequestObject()
        {
            // Snippet: CreateInstance(CreateInstanceRequest, CallSettings)
            // Create client
            gcrv::InstancesClient instancesClient = gcrv::InstancesClient.Create();
            // Initialize request argument(s)
            gcrv::CreateInstanceRequest request = new gcrv::CreateInstanceRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Instance = new gcrv::Instance(),
                InstanceId = "",
                ValidateOnly = false,
            };
            // Make the request
            Operation<gcrv::Instance, gcrv::Instance> response = instancesClient.CreateInstance(request);

            // Poll until the returned long-running operation is complete
            Operation<gcrv::Instance, gcrv::Instance> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcrv::Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcrv::Instance, gcrv::Instance> retrievedResponse = instancesClient.PollOnceCreateInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcrv::Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateInstanceAsync</summary>
        public async Task CreateInstanceRequestObjectAsync()
        {
            // Snippet: CreateInstanceAsync(CreateInstanceRequest, CallSettings)
            // Additional: CreateInstanceAsync(CreateInstanceRequest, CancellationToken)
            // Create client
            gcrv::InstancesClient instancesClient = await gcrv::InstancesClient.CreateAsync();
            // Initialize request argument(s)
            gcrv::CreateInstanceRequest request = new gcrv::CreateInstanceRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Instance = new gcrv::Instance(),
                InstanceId = "",
                ValidateOnly = false,
            };
            // Make the request
            Operation<gcrv::Instance, gcrv::Instance> response = await instancesClient.CreateInstanceAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gcrv::Instance, gcrv::Instance> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcrv::Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcrv::Instance, gcrv::Instance> retrievedResponse = await instancesClient.PollOnceCreateInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcrv::Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateInstance</summary>
        public void CreateInstance()
        {
            // Snippet: CreateInstance(string, Instance, CallSettings)
            // Create client
            gcrv::InstancesClient instancesClient = gcrv::InstancesClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            gcrv::Instance instance = new gcrv::Instance();
            // Make the request
            Operation<gcrv::Instance, gcrv::Instance> response = instancesClient.CreateInstance(parent, instance);

            // Poll until the returned long-running operation is complete
            Operation<gcrv::Instance, gcrv::Instance> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcrv::Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcrv::Instance, gcrv::Instance> retrievedResponse = instancesClient.PollOnceCreateInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcrv::Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateInstanceAsync</summary>
        public async Task CreateInstanceAsync()
        {
            // Snippet: CreateInstanceAsync(string, Instance, CallSettings)
            // Additional: CreateInstanceAsync(string, Instance, CancellationToken)
            // Create client
            gcrv::InstancesClient instancesClient = await gcrv::InstancesClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            gcrv::Instance instance = new gcrv::Instance();
            // Make the request
            Operation<gcrv::Instance, gcrv::Instance> response = await instancesClient.CreateInstanceAsync(parent, instance);

            // Poll until the returned long-running operation is complete
            Operation<gcrv::Instance, gcrv::Instance> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcrv::Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcrv::Instance, gcrv::Instance> retrievedResponse = await instancesClient.PollOnceCreateInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcrv::Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateInstance</summary>
        public void CreateInstanceResourceNames()
        {
            // Snippet: CreateInstance(LocationName, Instance, CallSettings)
            // Create client
            gcrv::InstancesClient instancesClient = gcrv::InstancesClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            gcrv::Instance instance = new gcrv::Instance();
            // Make the request
            Operation<gcrv::Instance, gcrv::Instance> response = instancesClient.CreateInstance(parent, instance);

            // Poll until the returned long-running operation is complete
            Operation<gcrv::Instance, gcrv::Instance> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcrv::Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcrv::Instance, gcrv::Instance> retrievedResponse = instancesClient.PollOnceCreateInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcrv::Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateInstanceAsync</summary>
        public async Task CreateInstanceResourceNamesAsync()
        {
            // Snippet: CreateInstanceAsync(LocationName, Instance, CallSettings)
            // Additional: CreateInstanceAsync(LocationName, Instance, CancellationToken)
            // Create client
            gcrv::InstancesClient instancesClient = await gcrv::InstancesClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            gcrv::Instance instance = new gcrv::Instance();
            // Make the request
            Operation<gcrv::Instance, gcrv::Instance> response = await instancesClient.CreateInstanceAsync(parent, instance);

            // Poll until the returned long-running operation is complete
            Operation<gcrv::Instance, gcrv::Instance> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcrv::Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcrv::Instance, gcrv::Instance> retrievedResponse = await instancesClient.PollOnceCreateInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcrv::Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteInstance</summary>
        public void DeleteInstanceRequestObject()
        {
            // Snippet: DeleteInstance(DeleteInstanceRequest, CallSettings)
            // Create client
            gcrv::InstancesClient instancesClient = gcrv::InstancesClient.Create();
            // Initialize request argument(s)
            gcrv::DeleteInstanceRequest request = new gcrv::DeleteInstanceRequest
            {
                InstanceName = gcrv::InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                ValidateOnly = false,
                Etag = "",
            };
            // Make the request
            Operation<gcrv::Instance, gcrv::Instance> response = instancesClient.DeleteInstance(request);

            // Poll until the returned long-running operation is complete
            Operation<gcrv::Instance, gcrv::Instance> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcrv::Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcrv::Instance, gcrv::Instance> retrievedResponse = instancesClient.PollOnceDeleteInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcrv::Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteInstanceAsync</summary>
        public async Task DeleteInstanceRequestObjectAsync()
        {
            // Snippet: DeleteInstanceAsync(DeleteInstanceRequest, CallSettings)
            // Additional: DeleteInstanceAsync(DeleteInstanceRequest, CancellationToken)
            // Create client
            gcrv::InstancesClient instancesClient = await gcrv::InstancesClient.CreateAsync();
            // Initialize request argument(s)
            gcrv::DeleteInstanceRequest request = new gcrv::DeleteInstanceRequest
            {
                InstanceName = gcrv::InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                ValidateOnly = false,
                Etag = "",
            };
            // Make the request
            Operation<gcrv::Instance, gcrv::Instance> response = await instancesClient.DeleteInstanceAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gcrv::Instance, gcrv::Instance> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcrv::Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcrv::Instance, gcrv::Instance> retrievedResponse = await instancesClient.PollOnceDeleteInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcrv::Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteInstance</summary>
        public void DeleteInstance()
        {
            // Snippet: DeleteInstance(string, CallSettings)
            // Create client
            gcrv::InstancesClient instancesClient = gcrv::InstancesClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            // Make the request
            Operation<gcrv::Instance, gcrv::Instance> response = instancesClient.DeleteInstance(name);

            // Poll until the returned long-running operation is complete
            Operation<gcrv::Instance, gcrv::Instance> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcrv::Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcrv::Instance, gcrv::Instance> retrievedResponse = instancesClient.PollOnceDeleteInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcrv::Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteInstanceAsync</summary>
        public async Task DeleteInstanceAsync()
        {
            // Snippet: DeleteInstanceAsync(string, CallSettings)
            // Additional: DeleteInstanceAsync(string, CancellationToken)
            // Create client
            gcrv::InstancesClient instancesClient = await gcrv::InstancesClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            // Make the request
            Operation<gcrv::Instance, gcrv::Instance> response = await instancesClient.DeleteInstanceAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<gcrv::Instance, gcrv::Instance> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcrv::Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcrv::Instance, gcrv::Instance> retrievedResponse = await instancesClient.PollOnceDeleteInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcrv::Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteInstance</summary>
        public void DeleteInstanceResourceNames()
        {
            // Snippet: DeleteInstance(InstanceName, CallSettings)
            // Create client
            gcrv::InstancesClient instancesClient = gcrv::InstancesClient.Create();
            // Initialize request argument(s)
            gcrv::InstanceName name = gcrv::InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            // Make the request
            Operation<gcrv::Instance, gcrv::Instance> response = instancesClient.DeleteInstance(name);

            // Poll until the returned long-running operation is complete
            Operation<gcrv::Instance, gcrv::Instance> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcrv::Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcrv::Instance, gcrv::Instance> retrievedResponse = instancesClient.PollOnceDeleteInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcrv::Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteInstanceAsync</summary>
        public async Task DeleteInstanceResourceNamesAsync()
        {
            // Snippet: DeleteInstanceAsync(InstanceName, CallSettings)
            // Additional: DeleteInstanceAsync(InstanceName, CancellationToken)
            // Create client
            gcrv::InstancesClient instancesClient = await gcrv::InstancesClient.CreateAsync();
            // Initialize request argument(s)
            gcrv::InstanceName name = gcrv::InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            // Make the request
            Operation<gcrv::Instance, gcrv::Instance> response = await instancesClient.DeleteInstanceAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<gcrv::Instance, gcrv::Instance> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcrv::Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcrv::Instance, gcrv::Instance> retrievedResponse = await instancesClient.PollOnceDeleteInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcrv::Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetInstance</summary>
        public void GetInstanceRequestObject()
        {
            // Snippet: GetInstance(GetInstanceRequest, CallSettings)
            // Create client
            gcrv::InstancesClient instancesClient = gcrv::InstancesClient.Create();
            // Initialize request argument(s)
            gcrv::GetInstanceRequest request = new gcrv::GetInstanceRequest
            {
                InstanceName = gcrv::InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
            };
            // Make the request
            gcrv::Instance response = instancesClient.GetInstance(request);
            // End snippet
        }

        /// <summary>Snippet for GetInstanceAsync</summary>
        public async Task GetInstanceRequestObjectAsync()
        {
            // Snippet: GetInstanceAsync(GetInstanceRequest, CallSettings)
            // Additional: GetInstanceAsync(GetInstanceRequest, CancellationToken)
            // Create client
            gcrv::InstancesClient instancesClient = await gcrv::InstancesClient.CreateAsync();
            // Initialize request argument(s)
            gcrv::GetInstanceRequest request = new gcrv::GetInstanceRequest
            {
                InstanceName = gcrv::InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
            };
            // Make the request
            gcrv::Instance response = await instancesClient.GetInstanceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetInstance</summary>
        public void GetInstance()
        {
            // Snippet: GetInstance(string, CallSettings)
            // Create client
            gcrv::InstancesClient instancesClient = gcrv::InstancesClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            // Make the request
            gcrv::Instance response = instancesClient.GetInstance(name);
            // End snippet
        }

        /// <summary>Snippet for GetInstanceAsync</summary>
        public async Task GetInstanceAsync()
        {
            // Snippet: GetInstanceAsync(string, CallSettings)
            // Additional: GetInstanceAsync(string, CancellationToken)
            // Create client
            gcrv::InstancesClient instancesClient = await gcrv::InstancesClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            // Make the request
            gcrv::Instance response = await instancesClient.GetInstanceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetInstance</summary>
        public void GetInstanceResourceNames()
        {
            // Snippet: GetInstance(InstanceName, CallSettings)
            // Create client
            gcrv::InstancesClient instancesClient = gcrv::InstancesClient.Create();
            // Initialize request argument(s)
            gcrv::InstanceName name = gcrv::InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            // Make the request
            gcrv::Instance response = instancesClient.GetInstance(name);
            // End snippet
        }

        /// <summary>Snippet for GetInstanceAsync</summary>
        public async Task GetInstanceResourceNamesAsync()
        {
            // Snippet: GetInstanceAsync(InstanceName, CallSettings)
            // Additional: GetInstanceAsync(InstanceName, CancellationToken)
            // Create client
            gcrv::InstancesClient instancesClient = await gcrv::InstancesClient.CreateAsync();
            // Initialize request argument(s)
            gcrv::InstanceName name = gcrv::InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            // Make the request
            gcrv::Instance response = await instancesClient.GetInstanceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListInstances</summary>
        public void ListInstancesRequestObject()
        {
            // Snippet: ListInstances(ListInstancesRequest, CallSettings)
            // Create client
            gcrv::InstancesClient instancesClient = gcrv::InstancesClient.Create();
            // Initialize request argument(s)
            gcrv::ListInstancesRequest request = new gcrv::ListInstancesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ShowDeleted = false,
            };
            // Make the request
            PagedEnumerable<gcrv::ListInstancesResponse, gcrv::Instance> response = instancesClient.ListInstances(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcrv::Instance item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcrv::ListInstancesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcrv::Instance item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcrv::Instance> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcrv::Instance item in singlePage)
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
            gcrv::InstancesClient instancesClient = await gcrv::InstancesClient.CreateAsync();
            // Initialize request argument(s)
            gcrv::ListInstancesRequest request = new gcrv::ListInstancesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ShowDeleted = false,
            };
            // Make the request
            PagedAsyncEnumerable<gcrv::ListInstancesResponse, gcrv::Instance> response = instancesClient.ListInstancesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (gcrv::Instance item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (gcrv::ListInstancesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcrv::Instance item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcrv::Instance> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcrv::Instance item in singlePage)
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
            gcrv::InstancesClient instancesClient = gcrv::InstancesClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<gcrv::ListInstancesResponse, gcrv::Instance> response = instancesClient.ListInstances(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcrv::Instance item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcrv::ListInstancesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcrv::Instance item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcrv::Instance> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcrv::Instance item in singlePage)
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
            gcrv::InstancesClient instancesClient = await gcrv::InstancesClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<gcrv::ListInstancesResponse, gcrv::Instance> response = instancesClient.ListInstancesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (gcrv::Instance item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (gcrv::ListInstancesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcrv::Instance item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcrv::Instance> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcrv::Instance item in singlePage)
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
            // Snippet: ListInstances(LocationName, string, int?, CallSettings)
            // Create client
            gcrv::InstancesClient instancesClient = gcrv::InstancesClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<gcrv::ListInstancesResponse, gcrv::Instance> response = instancesClient.ListInstances(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcrv::Instance item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcrv::ListInstancesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcrv::Instance item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcrv::Instance> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcrv::Instance item in singlePage)
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
            // Snippet: ListInstancesAsync(LocationName, string, int?, CallSettings)
            // Create client
            gcrv::InstancesClient instancesClient = await gcrv::InstancesClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<gcrv::ListInstancesResponse, gcrv::Instance> response = instancesClient.ListInstancesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (gcrv::Instance item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (gcrv::ListInstancesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcrv::Instance item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcrv::Instance> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcrv::Instance item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for StopInstance</summary>
        public void StopInstanceRequestObject()
        {
            // Snippet: StopInstance(StopInstanceRequest, CallSettings)
            // Create client
            gcrv::InstancesClient instancesClient = gcrv::InstancesClient.Create();
            // Initialize request argument(s)
            gcrv::StopInstanceRequest request = new gcrv::StopInstanceRequest
            {
                InstanceName = gcrv::InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                ValidateOnly = false,
                Etag = "",
            };
            // Make the request
            Operation<gcrv::Instance, gcrv::Instance> response = instancesClient.StopInstance(request);

            // Poll until the returned long-running operation is complete
            Operation<gcrv::Instance, gcrv::Instance> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcrv::Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcrv::Instance, gcrv::Instance> retrievedResponse = instancesClient.PollOnceStopInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcrv::Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StopInstanceAsync</summary>
        public async Task StopInstanceRequestObjectAsync()
        {
            // Snippet: StopInstanceAsync(StopInstanceRequest, CallSettings)
            // Additional: StopInstanceAsync(StopInstanceRequest, CancellationToken)
            // Create client
            gcrv::InstancesClient instancesClient = await gcrv::InstancesClient.CreateAsync();
            // Initialize request argument(s)
            gcrv::StopInstanceRequest request = new gcrv::StopInstanceRequest
            {
                InstanceName = gcrv::InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                ValidateOnly = false,
                Etag = "",
            };
            // Make the request
            Operation<gcrv::Instance, gcrv::Instance> response = await instancesClient.StopInstanceAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gcrv::Instance, gcrv::Instance> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcrv::Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcrv::Instance, gcrv::Instance> retrievedResponse = await instancesClient.PollOnceStopInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcrv::Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StopInstance</summary>
        public void StopInstance()
        {
            // Snippet: StopInstance(string, CallSettings)
            // Create client
            gcrv::InstancesClient instancesClient = gcrv::InstancesClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            // Make the request
            Operation<gcrv::Instance, gcrv::Instance> response = instancesClient.StopInstance(name);

            // Poll until the returned long-running operation is complete
            Operation<gcrv::Instance, gcrv::Instance> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcrv::Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcrv::Instance, gcrv::Instance> retrievedResponse = instancesClient.PollOnceStopInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcrv::Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StopInstanceAsync</summary>
        public async Task StopInstanceAsync()
        {
            // Snippet: StopInstanceAsync(string, CallSettings)
            // Additional: StopInstanceAsync(string, CancellationToken)
            // Create client
            gcrv::InstancesClient instancesClient = await gcrv::InstancesClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            // Make the request
            Operation<gcrv::Instance, gcrv::Instance> response = await instancesClient.StopInstanceAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<gcrv::Instance, gcrv::Instance> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcrv::Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcrv::Instance, gcrv::Instance> retrievedResponse = await instancesClient.PollOnceStopInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcrv::Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StopInstance</summary>
        public void StopInstanceResourceNames()
        {
            // Snippet: StopInstance(InstanceName, CallSettings)
            // Create client
            gcrv::InstancesClient instancesClient = gcrv::InstancesClient.Create();
            // Initialize request argument(s)
            gcrv::InstanceName name = gcrv::InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            // Make the request
            Operation<gcrv::Instance, gcrv::Instance> response = instancesClient.StopInstance(name);

            // Poll until the returned long-running operation is complete
            Operation<gcrv::Instance, gcrv::Instance> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcrv::Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcrv::Instance, gcrv::Instance> retrievedResponse = instancesClient.PollOnceStopInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcrv::Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StopInstanceAsync</summary>
        public async Task StopInstanceResourceNamesAsync()
        {
            // Snippet: StopInstanceAsync(InstanceName, CallSettings)
            // Additional: StopInstanceAsync(InstanceName, CancellationToken)
            // Create client
            gcrv::InstancesClient instancesClient = await gcrv::InstancesClient.CreateAsync();
            // Initialize request argument(s)
            gcrv::InstanceName name = gcrv::InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            // Make the request
            Operation<gcrv::Instance, gcrv::Instance> response = await instancesClient.StopInstanceAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<gcrv::Instance, gcrv::Instance> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcrv::Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcrv::Instance, gcrv::Instance> retrievedResponse = await instancesClient.PollOnceStopInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcrv::Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StartInstance</summary>
        public void StartInstanceRequestObject()
        {
            // Snippet: StartInstance(StartInstanceRequest, CallSettings)
            // Create client
            gcrv::InstancesClient instancesClient = gcrv::InstancesClient.Create();
            // Initialize request argument(s)
            gcrv::StartInstanceRequest request = new gcrv::StartInstanceRequest
            {
                InstanceName = gcrv::InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                ValidateOnly = false,
                Etag = "",
            };
            // Make the request
            Operation<gcrv::Instance, gcrv::Instance> response = instancesClient.StartInstance(request);

            // Poll until the returned long-running operation is complete
            Operation<gcrv::Instance, gcrv::Instance> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcrv::Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcrv::Instance, gcrv::Instance> retrievedResponse = instancesClient.PollOnceStartInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcrv::Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StartInstanceAsync</summary>
        public async Task StartInstanceRequestObjectAsync()
        {
            // Snippet: StartInstanceAsync(StartInstanceRequest, CallSettings)
            // Additional: StartInstanceAsync(StartInstanceRequest, CancellationToken)
            // Create client
            gcrv::InstancesClient instancesClient = await gcrv::InstancesClient.CreateAsync();
            // Initialize request argument(s)
            gcrv::StartInstanceRequest request = new gcrv::StartInstanceRequest
            {
                InstanceName = gcrv::InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                ValidateOnly = false,
                Etag = "",
            };
            // Make the request
            Operation<gcrv::Instance, gcrv::Instance> response = await instancesClient.StartInstanceAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gcrv::Instance, gcrv::Instance> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcrv::Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcrv::Instance, gcrv::Instance> retrievedResponse = await instancesClient.PollOnceStartInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcrv::Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StartInstance</summary>
        public void StartInstance()
        {
            // Snippet: StartInstance(string, CallSettings)
            // Create client
            gcrv::InstancesClient instancesClient = gcrv::InstancesClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            // Make the request
            Operation<gcrv::Instance, gcrv::Instance> response = instancesClient.StartInstance(name);

            // Poll until the returned long-running operation is complete
            Operation<gcrv::Instance, gcrv::Instance> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcrv::Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcrv::Instance, gcrv::Instance> retrievedResponse = instancesClient.PollOnceStartInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcrv::Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StartInstanceAsync</summary>
        public async Task StartInstanceAsync()
        {
            // Snippet: StartInstanceAsync(string, CallSettings)
            // Additional: StartInstanceAsync(string, CancellationToken)
            // Create client
            gcrv::InstancesClient instancesClient = await gcrv::InstancesClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            // Make the request
            Operation<gcrv::Instance, gcrv::Instance> response = await instancesClient.StartInstanceAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<gcrv::Instance, gcrv::Instance> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcrv::Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcrv::Instance, gcrv::Instance> retrievedResponse = await instancesClient.PollOnceStartInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcrv::Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StartInstance</summary>
        public void StartInstanceResourceNames()
        {
            // Snippet: StartInstance(InstanceName, CallSettings)
            // Create client
            gcrv::InstancesClient instancesClient = gcrv::InstancesClient.Create();
            // Initialize request argument(s)
            gcrv::InstanceName name = gcrv::InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            // Make the request
            Operation<gcrv::Instance, gcrv::Instance> response = instancesClient.StartInstance(name);

            // Poll until the returned long-running operation is complete
            Operation<gcrv::Instance, gcrv::Instance> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcrv::Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcrv::Instance, gcrv::Instance> retrievedResponse = instancesClient.PollOnceStartInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcrv::Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StartInstanceAsync</summary>
        public async Task StartInstanceResourceNamesAsync()
        {
            // Snippet: StartInstanceAsync(InstanceName, CallSettings)
            // Additional: StartInstanceAsync(InstanceName, CancellationToken)
            // Create client
            gcrv::InstancesClient instancesClient = await gcrv::InstancesClient.CreateAsync();
            // Initialize request argument(s)
            gcrv::InstanceName name = gcrv::InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            // Make the request
            Operation<gcrv::Instance, gcrv::Instance> response = await instancesClient.StartInstanceAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<gcrv::Instance, gcrv::Instance> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcrv::Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcrv::Instance, gcrv::Instance> retrievedResponse = await instancesClient.PollOnceStartInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcrv::Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
