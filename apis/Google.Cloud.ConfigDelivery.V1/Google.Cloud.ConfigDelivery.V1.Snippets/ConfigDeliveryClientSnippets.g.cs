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
    using Google.Cloud.ConfigDelivery.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedConfigDeliveryClientSnippets
    {
        /// <summary>Snippet for ListResourceBundles</summary>
        public void ListResourceBundlesRequestObject()
        {
            // Snippet: ListResourceBundles(ListResourceBundlesRequest, CallSettings)
            // Create client
            ConfigDeliveryClient configDeliveryClient = ConfigDeliveryClient.Create();
            // Initialize request argument(s)
            ListResourceBundlesRequest request = new ListResourceBundlesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListResourceBundlesResponse, ResourceBundle> response = configDeliveryClient.ListResourceBundles(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ResourceBundle item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListResourceBundlesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ResourceBundle item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ResourceBundle> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ResourceBundle item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListResourceBundlesAsync</summary>
        public async Task ListResourceBundlesRequestObjectAsync()
        {
            // Snippet: ListResourceBundlesAsync(ListResourceBundlesRequest, CallSettings)
            // Create client
            ConfigDeliveryClient configDeliveryClient = await ConfigDeliveryClient.CreateAsync();
            // Initialize request argument(s)
            ListResourceBundlesRequest request = new ListResourceBundlesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListResourceBundlesResponse, ResourceBundle> response = configDeliveryClient.ListResourceBundlesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ResourceBundle item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListResourceBundlesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ResourceBundle item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ResourceBundle> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ResourceBundle item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListResourceBundles</summary>
        public void ListResourceBundles()
        {
            // Snippet: ListResourceBundles(string, string, int?, CallSettings)
            // Create client
            ConfigDeliveryClient configDeliveryClient = ConfigDeliveryClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListResourceBundlesResponse, ResourceBundle> response = configDeliveryClient.ListResourceBundles(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ResourceBundle item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListResourceBundlesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ResourceBundle item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ResourceBundle> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ResourceBundle item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListResourceBundlesAsync</summary>
        public async Task ListResourceBundlesAsync()
        {
            // Snippet: ListResourceBundlesAsync(string, string, int?, CallSettings)
            // Create client
            ConfigDeliveryClient configDeliveryClient = await ConfigDeliveryClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListResourceBundlesResponse, ResourceBundle> response = configDeliveryClient.ListResourceBundlesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ResourceBundle item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListResourceBundlesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ResourceBundle item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ResourceBundle> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ResourceBundle item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListResourceBundles</summary>
        public void ListResourceBundlesResourceNames()
        {
            // Snippet: ListResourceBundles(LocationName, string, int?, CallSettings)
            // Create client
            ConfigDeliveryClient configDeliveryClient = ConfigDeliveryClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListResourceBundlesResponse, ResourceBundle> response = configDeliveryClient.ListResourceBundles(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ResourceBundle item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListResourceBundlesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ResourceBundle item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ResourceBundle> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ResourceBundle item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListResourceBundlesAsync</summary>
        public async Task ListResourceBundlesResourceNamesAsync()
        {
            // Snippet: ListResourceBundlesAsync(LocationName, string, int?, CallSettings)
            // Create client
            ConfigDeliveryClient configDeliveryClient = await ConfigDeliveryClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListResourceBundlesResponse, ResourceBundle> response = configDeliveryClient.ListResourceBundlesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ResourceBundle item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListResourceBundlesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ResourceBundle item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ResourceBundle> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ResourceBundle item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetResourceBundle</summary>
        public void GetResourceBundleRequestObject()
        {
            // Snippet: GetResourceBundle(GetResourceBundleRequest, CallSettings)
            // Create client
            ConfigDeliveryClient configDeliveryClient = ConfigDeliveryClient.Create();
            // Initialize request argument(s)
            GetResourceBundleRequest request = new GetResourceBundleRequest
            {
                ResourceBundleName = ResourceBundleName.FromProjectLocationResourceBundle("[PROJECT]", "[LOCATION]", "[RESOURCE_BUNDLE]"),
            };
            // Make the request
            ResourceBundle response = configDeliveryClient.GetResourceBundle(request);
            // End snippet
        }

        /// <summary>Snippet for GetResourceBundleAsync</summary>
        public async Task GetResourceBundleRequestObjectAsync()
        {
            // Snippet: GetResourceBundleAsync(GetResourceBundleRequest, CallSettings)
            // Additional: GetResourceBundleAsync(GetResourceBundleRequest, CancellationToken)
            // Create client
            ConfigDeliveryClient configDeliveryClient = await ConfigDeliveryClient.CreateAsync();
            // Initialize request argument(s)
            GetResourceBundleRequest request = new GetResourceBundleRequest
            {
                ResourceBundleName = ResourceBundleName.FromProjectLocationResourceBundle("[PROJECT]", "[LOCATION]", "[RESOURCE_BUNDLE]"),
            };
            // Make the request
            ResourceBundle response = await configDeliveryClient.GetResourceBundleAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetResourceBundle</summary>
        public void GetResourceBundle()
        {
            // Snippet: GetResourceBundle(string, CallSettings)
            // Create client
            ConfigDeliveryClient configDeliveryClient = ConfigDeliveryClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/resourceBundles/[RESOURCE_BUNDLE]";
            // Make the request
            ResourceBundle response = configDeliveryClient.GetResourceBundle(name);
            // End snippet
        }

        /// <summary>Snippet for GetResourceBundleAsync</summary>
        public async Task GetResourceBundleAsync()
        {
            // Snippet: GetResourceBundleAsync(string, CallSettings)
            // Additional: GetResourceBundleAsync(string, CancellationToken)
            // Create client
            ConfigDeliveryClient configDeliveryClient = await ConfigDeliveryClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/resourceBundles/[RESOURCE_BUNDLE]";
            // Make the request
            ResourceBundle response = await configDeliveryClient.GetResourceBundleAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetResourceBundle</summary>
        public void GetResourceBundleResourceNames()
        {
            // Snippet: GetResourceBundle(ResourceBundleName, CallSettings)
            // Create client
            ConfigDeliveryClient configDeliveryClient = ConfigDeliveryClient.Create();
            // Initialize request argument(s)
            ResourceBundleName name = ResourceBundleName.FromProjectLocationResourceBundle("[PROJECT]", "[LOCATION]", "[RESOURCE_BUNDLE]");
            // Make the request
            ResourceBundle response = configDeliveryClient.GetResourceBundle(name);
            // End snippet
        }

        /// <summary>Snippet for GetResourceBundleAsync</summary>
        public async Task GetResourceBundleResourceNamesAsync()
        {
            // Snippet: GetResourceBundleAsync(ResourceBundleName, CallSettings)
            // Additional: GetResourceBundleAsync(ResourceBundleName, CancellationToken)
            // Create client
            ConfigDeliveryClient configDeliveryClient = await ConfigDeliveryClient.CreateAsync();
            // Initialize request argument(s)
            ResourceBundleName name = ResourceBundleName.FromProjectLocationResourceBundle("[PROJECT]", "[LOCATION]", "[RESOURCE_BUNDLE]");
            // Make the request
            ResourceBundle response = await configDeliveryClient.GetResourceBundleAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateResourceBundle</summary>
        public void CreateResourceBundleRequestObject()
        {
            // Snippet: CreateResourceBundle(CreateResourceBundleRequest, CallSettings)
            // Create client
            ConfigDeliveryClient configDeliveryClient = ConfigDeliveryClient.Create();
            // Initialize request argument(s)
            CreateResourceBundleRequest request = new CreateResourceBundleRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ResourceBundleId = "",
                ResourceBundle = new ResourceBundle(),
                RequestId = "",
            };
            // Make the request
            Operation<ResourceBundle, OperationMetadata> response = configDeliveryClient.CreateResourceBundle(request);

            // Poll until the returned long-running operation is complete
            Operation<ResourceBundle, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ResourceBundle result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ResourceBundle, OperationMetadata> retrievedResponse = configDeliveryClient.PollOnceCreateResourceBundle(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ResourceBundle retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateResourceBundleAsync</summary>
        public async Task CreateResourceBundleRequestObjectAsync()
        {
            // Snippet: CreateResourceBundleAsync(CreateResourceBundleRequest, CallSettings)
            // Additional: CreateResourceBundleAsync(CreateResourceBundleRequest, CancellationToken)
            // Create client
            ConfigDeliveryClient configDeliveryClient = await ConfigDeliveryClient.CreateAsync();
            // Initialize request argument(s)
            CreateResourceBundleRequest request = new CreateResourceBundleRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ResourceBundleId = "",
                ResourceBundle = new ResourceBundle(),
                RequestId = "",
            };
            // Make the request
            Operation<ResourceBundle, OperationMetadata> response = await configDeliveryClient.CreateResourceBundleAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ResourceBundle, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ResourceBundle result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ResourceBundle, OperationMetadata> retrievedResponse = await configDeliveryClient.PollOnceCreateResourceBundleAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ResourceBundle retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateResourceBundle</summary>
        public void CreateResourceBundle()
        {
            // Snippet: CreateResourceBundle(string, ResourceBundle, string, CallSettings)
            // Create client
            ConfigDeliveryClient configDeliveryClient = ConfigDeliveryClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            ResourceBundle resourceBundle = new ResourceBundle();
            string resourceBundleId = "";
            // Make the request
            Operation<ResourceBundle, OperationMetadata> response = configDeliveryClient.CreateResourceBundle(parent, resourceBundle, resourceBundleId);

            // Poll until the returned long-running operation is complete
            Operation<ResourceBundle, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ResourceBundle result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ResourceBundle, OperationMetadata> retrievedResponse = configDeliveryClient.PollOnceCreateResourceBundle(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ResourceBundle retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateResourceBundleAsync</summary>
        public async Task CreateResourceBundleAsync()
        {
            // Snippet: CreateResourceBundleAsync(string, ResourceBundle, string, CallSettings)
            // Additional: CreateResourceBundleAsync(string, ResourceBundle, string, CancellationToken)
            // Create client
            ConfigDeliveryClient configDeliveryClient = await ConfigDeliveryClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            ResourceBundle resourceBundle = new ResourceBundle();
            string resourceBundleId = "";
            // Make the request
            Operation<ResourceBundle, OperationMetadata> response = await configDeliveryClient.CreateResourceBundleAsync(parent, resourceBundle, resourceBundleId);

            // Poll until the returned long-running operation is complete
            Operation<ResourceBundle, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ResourceBundle result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ResourceBundle, OperationMetadata> retrievedResponse = await configDeliveryClient.PollOnceCreateResourceBundleAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ResourceBundle retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateResourceBundle</summary>
        public void CreateResourceBundleResourceNames()
        {
            // Snippet: CreateResourceBundle(LocationName, ResourceBundle, string, CallSettings)
            // Create client
            ConfigDeliveryClient configDeliveryClient = ConfigDeliveryClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            ResourceBundle resourceBundle = new ResourceBundle();
            string resourceBundleId = "";
            // Make the request
            Operation<ResourceBundle, OperationMetadata> response = configDeliveryClient.CreateResourceBundle(parent, resourceBundle, resourceBundleId);

            // Poll until the returned long-running operation is complete
            Operation<ResourceBundle, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ResourceBundle result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ResourceBundle, OperationMetadata> retrievedResponse = configDeliveryClient.PollOnceCreateResourceBundle(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ResourceBundle retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateResourceBundleAsync</summary>
        public async Task CreateResourceBundleResourceNamesAsync()
        {
            // Snippet: CreateResourceBundleAsync(LocationName, ResourceBundle, string, CallSettings)
            // Additional: CreateResourceBundleAsync(LocationName, ResourceBundle, string, CancellationToken)
            // Create client
            ConfigDeliveryClient configDeliveryClient = await ConfigDeliveryClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            ResourceBundle resourceBundle = new ResourceBundle();
            string resourceBundleId = "";
            // Make the request
            Operation<ResourceBundle, OperationMetadata> response = await configDeliveryClient.CreateResourceBundleAsync(parent, resourceBundle, resourceBundleId);

            // Poll until the returned long-running operation is complete
            Operation<ResourceBundle, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ResourceBundle result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ResourceBundle, OperationMetadata> retrievedResponse = await configDeliveryClient.PollOnceCreateResourceBundleAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ResourceBundle retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateResourceBundle</summary>
        public void UpdateResourceBundleRequestObject()
        {
            // Snippet: UpdateResourceBundle(UpdateResourceBundleRequest, CallSettings)
            // Create client
            ConfigDeliveryClient configDeliveryClient = ConfigDeliveryClient.Create();
            // Initialize request argument(s)
            UpdateResourceBundleRequest request = new UpdateResourceBundleRequest
            {
                UpdateMask = new FieldMask(),
                ResourceBundle = new ResourceBundle(),
                RequestId = "",
            };
            // Make the request
            Operation<ResourceBundle, OperationMetadata> response = configDeliveryClient.UpdateResourceBundle(request);

            // Poll until the returned long-running operation is complete
            Operation<ResourceBundle, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ResourceBundle result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ResourceBundle, OperationMetadata> retrievedResponse = configDeliveryClient.PollOnceUpdateResourceBundle(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ResourceBundle retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateResourceBundleAsync</summary>
        public async Task UpdateResourceBundleRequestObjectAsync()
        {
            // Snippet: UpdateResourceBundleAsync(UpdateResourceBundleRequest, CallSettings)
            // Additional: UpdateResourceBundleAsync(UpdateResourceBundleRequest, CancellationToken)
            // Create client
            ConfigDeliveryClient configDeliveryClient = await ConfigDeliveryClient.CreateAsync();
            // Initialize request argument(s)
            UpdateResourceBundleRequest request = new UpdateResourceBundleRequest
            {
                UpdateMask = new FieldMask(),
                ResourceBundle = new ResourceBundle(),
                RequestId = "",
            };
            // Make the request
            Operation<ResourceBundle, OperationMetadata> response = await configDeliveryClient.UpdateResourceBundleAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ResourceBundle, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ResourceBundle result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ResourceBundle, OperationMetadata> retrievedResponse = await configDeliveryClient.PollOnceUpdateResourceBundleAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ResourceBundle retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateResourceBundle</summary>
        public void UpdateResourceBundle()
        {
            // Snippet: UpdateResourceBundle(ResourceBundle, FieldMask, CallSettings)
            // Create client
            ConfigDeliveryClient configDeliveryClient = ConfigDeliveryClient.Create();
            // Initialize request argument(s)
            ResourceBundle resourceBundle = new ResourceBundle();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<ResourceBundle, OperationMetadata> response = configDeliveryClient.UpdateResourceBundle(resourceBundle, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<ResourceBundle, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ResourceBundle result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ResourceBundle, OperationMetadata> retrievedResponse = configDeliveryClient.PollOnceUpdateResourceBundle(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ResourceBundle retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateResourceBundleAsync</summary>
        public async Task UpdateResourceBundleAsync()
        {
            // Snippet: UpdateResourceBundleAsync(ResourceBundle, FieldMask, CallSettings)
            // Additional: UpdateResourceBundleAsync(ResourceBundle, FieldMask, CancellationToken)
            // Create client
            ConfigDeliveryClient configDeliveryClient = await ConfigDeliveryClient.CreateAsync();
            // Initialize request argument(s)
            ResourceBundle resourceBundle = new ResourceBundle();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<ResourceBundle, OperationMetadata> response = await configDeliveryClient.UpdateResourceBundleAsync(resourceBundle, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<ResourceBundle, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ResourceBundle result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ResourceBundle, OperationMetadata> retrievedResponse = await configDeliveryClient.PollOnceUpdateResourceBundleAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ResourceBundle retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteResourceBundle</summary>
        public void DeleteResourceBundleRequestObject()
        {
            // Snippet: DeleteResourceBundle(DeleteResourceBundleRequest, CallSettings)
            // Create client
            ConfigDeliveryClient configDeliveryClient = ConfigDeliveryClient.Create();
            // Initialize request argument(s)
            DeleteResourceBundleRequest request = new DeleteResourceBundleRequest
            {
                ResourceBundleName = ResourceBundleName.FromProjectLocationResourceBundle("[PROJECT]", "[LOCATION]", "[RESOURCE_BUNDLE]"),
                RequestId = "",
                Force = false,
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = configDeliveryClient.DeleteResourceBundle(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = configDeliveryClient.PollOnceDeleteResourceBundle(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteResourceBundleAsync</summary>
        public async Task DeleteResourceBundleRequestObjectAsync()
        {
            // Snippet: DeleteResourceBundleAsync(DeleteResourceBundleRequest, CallSettings)
            // Additional: DeleteResourceBundleAsync(DeleteResourceBundleRequest, CancellationToken)
            // Create client
            ConfigDeliveryClient configDeliveryClient = await ConfigDeliveryClient.CreateAsync();
            // Initialize request argument(s)
            DeleteResourceBundleRequest request = new DeleteResourceBundleRequest
            {
                ResourceBundleName = ResourceBundleName.FromProjectLocationResourceBundle("[PROJECT]", "[LOCATION]", "[RESOURCE_BUNDLE]"),
                RequestId = "",
                Force = false,
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await configDeliveryClient.DeleteResourceBundleAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await configDeliveryClient.PollOnceDeleteResourceBundleAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteResourceBundle</summary>
        public void DeleteResourceBundle()
        {
            // Snippet: DeleteResourceBundle(string, CallSettings)
            // Create client
            ConfigDeliveryClient configDeliveryClient = ConfigDeliveryClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/resourceBundles/[RESOURCE_BUNDLE]";
            // Make the request
            Operation<Empty, OperationMetadata> response = configDeliveryClient.DeleteResourceBundle(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = configDeliveryClient.PollOnceDeleteResourceBundle(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteResourceBundleAsync</summary>
        public async Task DeleteResourceBundleAsync()
        {
            // Snippet: DeleteResourceBundleAsync(string, CallSettings)
            // Additional: DeleteResourceBundleAsync(string, CancellationToken)
            // Create client
            ConfigDeliveryClient configDeliveryClient = await ConfigDeliveryClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/resourceBundles/[RESOURCE_BUNDLE]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await configDeliveryClient.DeleteResourceBundleAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await configDeliveryClient.PollOnceDeleteResourceBundleAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteResourceBundle</summary>
        public void DeleteResourceBundleResourceNames()
        {
            // Snippet: DeleteResourceBundle(ResourceBundleName, CallSettings)
            // Create client
            ConfigDeliveryClient configDeliveryClient = ConfigDeliveryClient.Create();
            // Initialize request argument(s)
            ResourceBundleName name = ResourceBundleName.FromProjectLocationResourceBundle("[PROJECT]", "[LOCATION]", "[RESOURCE_BUNDLE]");
            // Make the request
            Operation<Empty, OperationMetadata> response = configDeliveryClient.DeleteResourceBundle(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = configDeliveryClient.PollOnceDeleteResourceBundle(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteResourceBundleAsync</summary>
        public async Task DeleteResourceBundleResourceNamesAsync()
        {
            // Snippet: DeleteResourceBundleAsync(ResourceBundleName, CallSettings)
            // Additional: DeleteResourceBundleAsync(ResourceBundleName, CancellationToken)
            // Create client
            ConfigDeliveryClient configDeliveryClient = await ConfigDeliveryClient.CreateAsync();
            // Initialize request argument(s)
            ResourceBundleName name = ResourceBundleName.FromProjectLocationResourceBundle("[PROJECT]", "[LOCATION]", "[RESOURCE_BUNDLE]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await configDeliveryClient.DeleteResourceBundleAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await configDeliveryClient.PollOnceDeleteResourceBundleAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListFleetPackages</summary>
        public void ListFleetPackagesRequestObject()
        {
            // Snippet: ListFleetPackages(ListFleetPackagesRequest, CallSettings)
            // Create client
            ConfigDeliveryClient configDeliveryClient = ConfigDeliveryClient.Create();
            // Initialize request argument(s)
            ListFleetPackagesRequest request = new ListFleetPackagesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListFleetPackagesResponse, FleetPackage> response = configDeliveryClient.ListFleetPackages(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (FleetPackage item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFleetPackagesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FleetPackage item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FleetPackage> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FleetPackage item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFleetPackagesAsync</summary>
        public async Task ListFleetPackagesRequestObjectAsync()
        {
            // Snippet: ListFleetPackagesAsync(ListFleetPackagesRequest, CallSettings)
            // Create client
            ConfigDeliveryClient configDeliveryClient = await ConfigDeliveryClient.CreateAsync();
            // Initialize request argument(s)
            ListFleetPackagesRequest request = new ListFleetPackagesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListFleetPackagesResponse, FleetPackage> response = configDeliveryClient.ListFleetPackagesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((FleetPackage item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListFleetPackagesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FleetPackage item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FleetPackage> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FleetPackage item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFleetPackages</summary>
        public void ListFleetPackages()
        {
            // Snippet: ListFleetPackages(string, string, int?, CallSettings)
            // Create client
            ConfigDeliveryClient configDeliveryClient = ConfigDeliveryClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListFleetPackagesResponse, FleetPackage> response = configDeliveryClient.ListFleetPackages(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (FleetPackage item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFleetPackagesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FleetPackage item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FleetPackage> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FleetPackage item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFleetPackagesAsync</summary>
        public async Task ListFleetPackagesAsync()
        {
            // Snippet: ListFleetPackagesAsync(string, string, int?, CallSettings)
            // Create client
            ConfigDeliveryClient configDeliveryClient = await ConfigDeliveryClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListFleetPackagesResponse, FleetPackage> response = configDeliveryClient.ListFleetPackagesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((FleetPackage item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListFleetPackagesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FleetPackage item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FleetPackage> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FleetPackage item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFleetPackages</summary>
        public void ListFleetPackagesResourceNames()
        {
            // Snippet: ListFleetPackages(LocationName, string, int?, CallSettings)
            // Create client
            ConfigDeliveryClient configDeliveryClient = ConfigDeliveryClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListFleetPackagesResponse, FleetPackage> response = configDeliveryClient.ListFleetPackages(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (FleetPackage item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFleetPackagesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FleetPackage item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FleetPackage> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FleetPackage item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFleetPackagesAsync</summary>
        public async Task ListFleetPackagesResourceNamesAsync()
        {
            // Snippet: ListFleetPackagesAsync(LocationName, string, int?, CallSettings)
            // Create client
            ConfigDeliveryClient configDeliveryClient = await ConfigDeliveryClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListFleetPackagesResponse, FleetPackage> response = configDeliveryClient.ListFleetPackagesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((FleetPackage item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListFleetPackagesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FleetPackage item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FleetPackage> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FleetPackage item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetFleetPackage</summary>
        public void GetFleetPackageRequestObject()
        {
            // Snippet: GetFleetPackage(GetFleetPackageRequest, CallSettings)
            // Create client
            ConfigDeliveryClient configDeliveryClient = ConfigDeliveryClient.Create();
            // Initialize request argument(s)
            GetFleetPackageRequest request = new GetFleetPackageRequest
            {
                FleetPackageName = FleetPackageName.FromProjectLocationFleetPackage("[PROJECT]", "[LOCATION]", "[FLEET_PACKAGE]"),
            };
            // Make the request
            FleetPackage response = configDeliveryClient.GetFleetPackage(request);
            // End snippet
        }

        /// <summary>Snippet for GetFleetPackageAsync</summary>
        public async Task GetFleetPackageRequestObjectAsync()
        {
            // Snippet: GetFleetPackageAsync(GetFleetPackageRequest, CallSettings)
            // Additional: GetFleetPackageAsync(GetFleetPackageRequest, CancellationToken)
            // Create client
            ConfigDeliveryClient configDeliveryClient = await ConfigDeliveryClient.CreateAsync();
            // Initialize request argument(s)
            GetFleetPackageRequest request = new GetFleetPackageRequest
            {
                FleetPackageName = FleetPackageName.FromProjectLocationFleetPackage("[PROJECT]", "[LOCATION]", "[FLEET_PACKAGE]"),
            };
            // Make the request
            FleetPackage response = await configDeliveryClient.GetFleetPackageAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetFleetPackage</summary>
        public void GetFleetPackage()
        {
            // Snippet: GetFleetPackage(string, CallSettings)
            // Create client
            ConfigDeliveryClient configDeliveryClient = ConfigDeliveryClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/fleetPackages/[FLEET_PACKAGE]";
            // Make the request
            FleetPackage response = configDeliveryClient.GetFleetPackage(name);
            // End snippet
        }

        /// <summary>Snippet for GetFleetPackageAsync</summary>
        public async Task GetFleetPackageAsync()
        {
            // Snippet: GetFleetPackageAsync(string, CallSettings)
            // Additional: GetFleetPackageAsync(string, CancellationToken)
            // Create client
            ConfigDeliveryClient configDeliveryClient = await ConfigDeliveryClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/fleetPackages/[FLEET_PACKAGE]";
            // Make the request
            FleetPackage response = await configDeliveryClient.GetFleetPackageAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetFleetPackage</summary>
        public void GetFleetPackageResourceNames()
        {
            // Snippet: GetFleetPackage(FleetPackageName, CallSettings)
            // Create client
            ConfigDeliveryClient configDeliveryClient = ConfigDeliveryClient.Create();
            // Initialize request argument(s)
            FleetPackageName name = FleetPackageName.FromProjectLocationFleetPackage("[PROJECT]", "[LOCATION]", "[FLEET_PACKAGE]");
            // Make the request
            FleetPackage response = configDeliveryClient.GetFleetPackage(name);
            // End snippet
        }

        /// <summary>Snippet for GetFleetPackageAsync</summary>
        public async Task GetFleetPackageResourceNamesAsync()
        {
            // Snippet: GetFleetPackageAsync(FleetPackageName, CallSettings)
            // Additional: GetFleetPackageAsync(FleetPackageName, CancellationToken)
            // Create client
            ConfigDeliveryClient configDeliveryClient = await ConfigDeliveryClient.CreateAsync();
            // Initialize request argument(s)
            FleetPackageName name = FleetPackageName.FromProjectLocationFleetPackage("[PROJECT]", "[LOCATION]", "[FLEET_PACKAGE]");
            // Make the request
            FleetPackage response = await configDeliveryClient.GetFleetPackageAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateFleetPackage</summary>
        public void CreateFleetPackageRequestObject()
        {
            // Snippet: CreateFleetPackage(CreateFleetPackageRequest, CallSettings)
            // Create client
            ConfigDeliveryClient configDeliveryClient = ConfigDeliveryClient.Create();
            // Initialize request argument(s)
            CreateFleetPackageRequest request = new CreateFleetPackageRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                FleetPackageId = "",
                FleetPackage = new FleetPackage(),
                RequestId = "",
            };
            // Make the request
            Operation<FleetPackage, OperationMetadata> response = configDeliveryClient.CreateFleetPackage(request);

            // Poll until the returned long-running operation is complete
            Operation<FleetPackage, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            FleetPackage result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<FleetPackage, OperationMetadata> retrievedResponse = configDeliveryClient.PollOnceCreateFleetPackage(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                FleetPackage retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateFleetPackageAsync</summary>
        public async Task CreateFleetPackageRequestObjectAsync()
        {
            // Snippet: CreateFleetPackageAsync(CreateFleetPackageRequest, CallSettings)
            // Additional: CreateFleetPackageAsync(CreateFleetPackageRequest, CancellationToken)
            // Create client
            ConfigDeliveryClient configDeliveryClient = await ConfigDeliveryClient.CreateAsync();
            // Initialize request argument(s)
            CreateFleetPackageRequest request = new CreateFleetPackageRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                FleetPackageId = "",
                FleetPackage = new FleetPackage(),
                RequestId = "",
            };
            // Make the request
            Operation<FleetPackage, OperationMetadata> response = await configDeliveryClient.CreateFleetPackageAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<FleetPackage, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            FleetPackage result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<FleetPackage, OperationMetadata> retrievedResponse = await configDeliveryClient.PollOnceCreateFleetPackageAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                FleetPackage retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateFleetPackage</summary>
        public void CreateFleetPackage()
        {
            // Snippet: CreateFleetPackage(string, FleetPackage, string, CallSettings)
            // Create client
            ConfigDeliveryClient configDeliveryClient = ConfigDeliveryClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            FleetPackage fleetPackage = new FleetPackage();
            string fleetPackageId = "";
            // Make the request
            Operation<FleetPackage, OperationMetadata> response = configDeliveryClient.CreateFleetPackage(parent, fleetPackage, fleetPackageId);

            // Poll until the returned long-running operation is complete
            Operation<FleetPackage, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            FleetPackage result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<FleetPackage, OperationMetadata> retrievedResponse = configDeliveryClient.PollOnceCreateFleetPackage(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                FleetPackage retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateFleetPackageAsync</summary>
        public async Task CreateFleetPackageAsync()
        {
            // Snippet: CreateFleetPackageAsync(string, FleetPackage, string, CallSettings)
            // Additional: CreateFleetPackageAsync(string, FleetPackage, string, CancellationToken)
            // Create client
            ConfigDeliveryClient configDeliveryClient = await ConfigDeliveryClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            FleetPackage fleetPackage = new FleetPackage();
            string fleetPackageId = "";
            // Make the request
            Operation<FleetPackage, OperationMetadata> response = await configDeliveryClient.CreateFleetPackageAsync(parent, fleetPackage, fleetPackageId);

            // Poll until the returned long-running operation is complete
            Operation<FleetPackage, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            FleetPackage result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<FleetPackage, OperationMetadata> retrievedResponse = await configDeliveryClient.PollOnceCreateFleetPackageAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                FleetPackage retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateFleetPackage</summary>
        public void CreateFleetPackageResourceNames()
        {
            // Snippet: CreateFleetPackage(LocationName, FleetPackage, string, CallSettings)
            // Create client
            ConfigDeliveryClient configDeliveryClient = ConfigDeliveryClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            FleetPackage fleetPackage = new FleetPackage();
            string fleetPackageId = "";
            // Make the request
            Operation<FleetPackage, OperationMetadata> response = configDeliveryClient.CreateFleetPackage(parent, fleetPackage, fleetPackageId);

            // Poll until the returned long-running operation is complete
            Operation<FleetPackage, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            FleetPackage result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<FleetPackage, OperationMetadata> retrievedResponse = configDeliveryClient.PollOnceCreateFleetPackage(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                FleetPackage retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateFleetPackageAsync</summary>
        public async Task CreateFleetPackageResourceNamesAsync()
        {
            // Snippet: CreateFleetPackageAsync(LocationName, FleetPackage, string, CallSettings)
            // Additional: CreateFleetPackageAsync(LocationName, FleetPackage, string, CancellationToken)
            // Create client
            ConfigDeliveryClient configDeliveryClient = await ConfigDeliveryClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            FleetPackage fleetPackage = new FleetPackage();
            string fleetPackageId = "";
            // Make the request
            Operation<FleetPackage, OperationMetadata> response = await configDeliveryClient.CreateFleetPackageAsync(parent, fleetPackage, fleetPackageId);

            // Poll until the returned long-running operation is complete
            Operation<FleetPackage, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            FleetPackage result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<FleetPackage, OperationMetadata> retrievedResponse = await configDeliveryClient.PollOnceCreateFleetPackageAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                FleetPackage retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateFleetPackage</summary>
        public void UpdateFleetPackageRequestObject()
        {
            // Snippet: UpdateFleetPackage(UpdateFleetPackageRequest, CallSettings)
            // Create client
            ConfigDeliveryClient configDeliveryClient = ConfigDeliveryClient.Create();
            // Initialize request argument(s)
            UpdateFleetPackageRequest request = new UpdateFleetPackageRequest
            {
                UpdateMask = new FieldMask(),
                FleetPackage = new FleetPackage(),
                RequestId = "",
            };
            // Make the request
            Operation<FleetPackage, OperationMetadata> response = configDeliveryClient.UpdateFleetPackage(request);

            // Poll until the returned long-running operation is complete
            Operation<FleetPackage, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            FleetPackage result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<FleetPackage, OperationMetadata> retrievedResponse = configDeliveryClient.PollOnceUpdateFleetPackage(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                FleetPackage retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateFleetPackageAsync</summary>
        public async Task UpdateFleetPackageRequestObjectAsync()
        {
            // Snippet: UpdateFleetPackageAsync(UpdateFleetPackageRequest, CallSettings)
            // Additional: UpdateFleetPackageAsync(UpdateFleetPackageRequest, CancellationToken)
            // Create client
            ConfigDeliveryClient configDeliveryClient = await ConfigDeliveryClient.CreateAsync();
            // Initialize request argument(s)
            UpdateFleetPackageRequest request = new UpdateFleetPackageRequest
            {
                UpdateMask = new FieldMask(),
                FleetPackage = new FleetPackage(),
                RequestId = "",
            };
            // Make the request
            Operation<FleetPackage, OperationMetadata> response = await configDeliveryClient.UpdateFleetPackageAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<FleetPackage, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            FleetPackage result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<FleetPackage, OperationMetadata> retrievedResponse = await configDeliveryClient.PollOnceUpdateFleetPackageAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                FleetPackage retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateFleetPackage</summary>
        public void UpdateFleetPackage()
        {
            // Snippet: UpdateFleetPackage(FleetPackage, FieldMask, CallSettings)
            // Create client
            ConfigDeliveryClient configDeliveryClient = ConfigDeliveryClient.Create();
            // Initialize request argument(s)
            FleetPackage fleetPackage = new FleetPackage();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<FleetPackage, OperationMetadata> response = configDeliveryClient.UpdateFleetPackage(fleetPackage, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<FleetPackage, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            FleetPackage result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<FleetPackage, OperationMetadata> retrievedResponse = configDeliveryClient.PollOnceUpdateFleetPackage(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                FleetPackage retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateFleetPackageAsync</summary>
        public async Task UpdateFleetPackageAsync()
        {
            // Snippet: UpdateFleetPackageAsync(FleetPackage, FieldMask, CallSettings)
            // Additional: UpdateFleetPackageAsync(FleetPackage, FieldMask, CancellationToken)
            // Create client
            ConfigDeliveryClient configDeliveryClient = await ConfigDeliveryClient.CreateAsync();
            // Initialize request argument(s)
            FleetPackage fleetPackage = new FleetPackage();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<FleetPackage, OperationMetadata> response = await configDeliveryClient.UpdateFleetPackageAsync(fleetPackage, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<FleetPackage, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            FleetPackage result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<FleetPackage, OperationMetadata> retrievedResponse = await configDeliveryClient.PollOnceUpdateFleetPackageAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                FleetPackage retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteFleetPackage</summary>
        public void DeleteFleetPackageRequestObject()
        {
            // Snippet: DeleteFleetPackage(DeleteFleetPackageRequest, CallSettings)
            // Create client
            ConfigDeliveryClient configDeliveryClient = ConfigDeliveryClient.Create();
            // Initialize request argument(s)
            DeleteFleetPackageRequest request = new DeleteFleetPackageRequest
            {
                FleetPackageName = FleetPackageName.FromProjectLocationFleetPackage("[PROJECT]", "[LOCATION]", "[FLEET_PACKAGE]"),
                RequestId = "",
                Force = false,
                AllowMissing = false,
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = configDeliveryClient.DeleteFleetPackage(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = configDeliveryClient.PollOnceDeleteFleetPackage(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteFleetPackageAsync</summary>
        public async Task DeleteFleetPackageRequestObjectAsync()
        {
            // Snippet: DeleteFleetPackageAsync(DeleteFleetPackageRequest, CallSettings)
            // Additional: DeleteFleetPackageAsync(DeleteFleetPackageRequest, CancellationToken)
            // Create client
            ConfigDeliveryClient configDeliveryClient = await ConfigDeliveryClient.CreateAsync();
            // Initialize request argument(s)
            DeleteFleetPackageRequest request = new DeleteFleetPackageRequest
            {
                FleetPackageName = FleetPackageName.FromProjectLocationFleetPackage("[PROJECT]", "[LOCATION]", "[FLEET_PACKAGE]"),
                RequestId = "",
                Force = false,
                AllowMissing = false,
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await configDeliveryClient.DeleteFleetPackageAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await configDeliveryClient.PollOnceDeleteFleetPackageAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteFleetPackage</summary>
        public void DeleteFleetPackage()
        {
            // Snippet: DeleteFleetPackage(string, CallSettings)
            // Create client
            ConfigDeliveryClient configDeliveryClient = ConfigDeliveryClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/fleetPackages/[FLEET_PACKAGE]";
            // Make the request
            Operation<Empty, OperationMetadata> response = configDeliveryClient.DeleteFleetPackage(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = configDeliveryClient.PollOnceDeleteFleetPackage(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteFleetPackageAsync</summary>
        public async Task DeleteFleetPackageAsync()
        {
            // Snippet: DeleteFleetPackageAsync(string, CallSettings)
            // Additional: DeleteFleetPackageAsync(string, CancellationToken)
            // Create client
            ConfigDeliveryClient configDeliveryClient = await ConfigDeliveryClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/fleetPackages/[FLEET_PACKAGE]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await configDeliveryClient.DeleteFleetPackageAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await configDeliveryClient.PollOnceDeleteFleetPackageAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteFleetPackage</summary>
        public void DeleteFleetPackageResourceNames()
        {
            // Snippet: DeleteFleetPackage(FleetPackageName, CallSettings)
            // Create client
            ConfigDeliveryClient configDeliveryClient = ConfigDeliveryClient.Create();
            // Initialize request argument(s)
            FleetPackageName name = FleetPackageName.FromProjectLocationFleetPackage("[PROJECT]", "[LOCATION]", "[FLEET_PACKAGE]");
            // Make the request
            Operation<Empty, OperationMetadata> response = configDeliveryClient.DeleteFleetPackage(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = configDeliveryClient.PollOnceDeleteFleetPackage(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteFleetPackageAsync</summary>
        public async Task DeleteFleetPackageResourceNamesAsync()
        {
            // Snippet: DeleteFleetPackageAsync(FleetPackageName, CallSettings)
            // Additional: DeleteFleetPackageAsync(FleetPackageName, CancellationToken)
            // Create client
            ConfigDeliveryClient configDeliveryClient = await ConfigDeliveryClient.CreateAsync();
            // Initialize request argument(s)
            FleetPackageName name = FleetPackageName.FromProjectLocationFleetPackage("[PROJECT]", "[LOCATION]", "[FLEET_PACKAGE]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await configDeliveryClient.DeleteFleetPackageAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await configDeliveryClient.PollOnceDeleteFleetPackageAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListReleases</summary>
        public void ListReleasesRequestObject()
        {
            // Snippet: ListReleases(ListReleasesRequest, CallSettings)
            // Create client
            ConfigDeliveryClient configDeliveryClient = ConfigDeliveryClient.Create();
            // Initialize request argument(s)
            ListReleasesRequest request = new ListReleasesRequest
            {
                ParentAsResourceBundleName = ResourceBundleName.FromProjectLocationResourceBundle("[PROJECT]", "[LOCATION]", "[RESOURCE_BUNDLE]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListReleasesResponse, Release> response = configDeliveryClient.ListReleases(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Release item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListReleasesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Release item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Release> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Release item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListReleasesAsync</summary>
        public async Task ListReleasesRequestObjectAsync()
        {
            // Snippet: ListReleasesAsync(ListReleasesRequest, CallSettings)
            // Create client
            ConfigDeliveryClient configDeliveryClient = await ConfigDeliveryClient.CreateAsync();
            // Initialize request argument(s)
            ListReleasesRequest request = new ListReleasesRequest
            {
                ParentAsResourceBundleName = ResourceBundleName.FromProjectLocationResourceBundle("[PROJECT]", "[LOCATION]", "[RESOURCE_BUNDLE]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListReleasesResponse, Release> response = configDeliveryClient.ListReleasesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Release item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListReleasesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Release item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Release> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Release item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListReleases</summary>
        public void ListReleases()
        {
            // Snippet: ListReleases(string, string, int?, CallSettings)
            // Create client
            ConfigDeliveryClient configDeliveryClient = ConfigDeliveryClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/resourceBundles/[RESOURCE_BUNDLE]";
            // Make the request
            PagedEnumerable<ListReleasesResponse, Release> response = configDeliveryClient.ListReleases(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Release item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListReleasesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Release item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Release> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Release item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListReleasesAsync</summary>
        public async Task ListReleasesAsync()
        {
            // Snippet: ListReleasesAsync(string, string, int?, CallSettings)
            // Create client
            ConfigDeliveryClient configDeliveryClient = await ConfigDeliveryClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/resourceBundles/[RESOURCE_BUNDLE]";
            // Make the request
            PagedAsyncEnumerable<ListReleasesResponse, Release> response = configDeliveryClient.ListReleasesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Release item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListReleasesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Release item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Release> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Release item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListReleases</summary>
        public void ListReleasesResourceNames()
        {
            // Snippet: ListReleases(ResourceBundleName, string, int?, CallSettings)
            // Create client
            ConfigDeliveryClient configDeliveryClient = ConfigDeliveryClient.Create();
            // Initialize request argument(s)
            ResourceBundleName parent = ResourceBundleName.FromProjectLocationResourceBundle("[PROJECT]", "[LOCATION]", "[RESOURCE_BUNDLE]");
            // Make the request
            PagedEnumerable<ListReleasesResponse, Release> response = configDeliveryClient.ListReleases(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Release item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListReleasesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Release item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Release> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Release item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListReleasesAsync</summary>
        public async Task ListReleasesResourceNamesAsync()
        {
            // Snippet: ListReleasesAsync(ResourceBundleName, string, int?, CallSettings)
            // Create client
            ConfigDeliveryClient configDeliveryClient = await ConfigDeliveryClient.CreateAsync();
            // Initialize request argument(s)
            ResourceBundleName parent = ResourceBundleName.FromProjectLocationResourceBundle("[PROJECT]", "[LOCATION]", "[RESOURCE_BUNDLE]");
            // Make the request
            PagedAsyncEnumerable<ListReleasesResponse, Release> response = configDeliveryClient.ListReleasesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Release item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListReleasesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Release item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Release> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Release item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetRelease</summary>
        public void GetReleaseRequestObject()
        {
            // Snippet: GetRelease(GetReleaseRequest, CallSettings)
            // Create client
            ConfigDeliveryClient configDeliveryClient = ConfigDeliveryClient.Create();
            // Initialize request argument(s)
            GetReleaseRequest request = new GetReleaseRequest
            {
                ReleaseName = ReleaseName.FromProjectLocationResourceBundleRelease("[PROJECT]", "[LOCATION]", "[RESOURCE_BUNDLE]", "[RELEASE]"),
            };
            // Make the request
            Release response = configDeliveryClient.GetRelease(request);
            // End snippet
        }

        /// <summary>Snippet for GetReleaseAsync</summary>
        public async Task GetReleaseRequestObjectAsync()
        {
            // Snippet: GetReleaseAsync(GetReleaseRequest, CallSettings)
            // Additional: GetReleaseAsync(GetReleaseRequest, CancellationToken)
            // Create client
            ConfigDeliveryClient configDeliveryClient = await ConfigDeliveryClient.CreateAsync();
            // Initialize request argument(s)
            GetReleaseRequest request = new GetReleaseRequest
            {
                ReleaseName = ReleaseName.FromProjectLocationResourceBundleRelease("[PROJECT]", "[LOCATION]", "[RESOURCE_BUNDLE]", "[RELEASE]"),
            };
            // Make the request
            Release response = await configDeliveryClient.GetReleaseAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetRelease</summary>
        public void GetRelease()
        {
            // Snippet: GetRelease(string, CallSettings)
            // Create client
            ConfigDeliveryClient configDeliveryClient = ConfigDeliveryClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/resourceBundles/[RESOURCE_BUNDLE]/releases/[RELEASE]";
            // Make the request
            Release response = configDeliveryClient.GetRelease(name);
            // End snippet
        }

        /// <summary>Snippet for GetReleaseAsync</summary>
        public async Task GetReleaseAsync()
        {
            // Snippet: GetReleaseAsync(string, CallSettings)
            // Additional: GetReleaseAsync(string, CancellationToken)
            // Create client
            ConfigDeliveryClient configDeliveryClient = await ConfigDeliveryClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/resourceBundles/[RESOURCE_BUNDLE]/releases/[RELEASE]";
            // Make the request
            Release response = await configDeliveryClient.GetReleaseAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetRelease</summary>
        public void GetReleaseResourceNames()
        {
            // Snippet: GetRelease(ReleaseName, CallSettings)
            // Create client
            ConfigDeliveryClient configDeliveryClient = ConfigDeliveryClient.Create();
            // Initialize request argument(s)
            ReleaseName name = ReleaseName.FromProjectLocationResourceBundleRelease("[PROJECT]", "[LOCATION]", "[RESOURCE_BUNDLE]", "[RELEASE]");
            // Make the request
            Release response = configDeliveryClient.GetRelease(name);
            // End snippet
        }

        /// <summary>Snippet for GetReleaseAsync</summary>
        public async Task GetReleaseResourceNamesAsync()
        {
            // Snippet: GetReleaseAsync(ReleaseName, CallSettings)
            // Additional: GetReleaseAsync(ReleaseName, CancellationToken)
            // Create client
            ConfigDeliveryClient configDeliveryClient = await ConfigDeliveryClient.CreateAsync();
            // Initialize request argument(s)
            ReleaseName name = ReleaseName.FromProjectLocationResourceBundleRelease("[PROJECT]", "[LOCATION]", "[RESOURCE_BUNDLE]", "[RELEASE]");
            // Make the request
            Release response = await configDeliveryClient.GetReleaseAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateRelease</summary>
        public void CreateReleaseRequestObject()
        {
            // Snippet: CreateRelease(CreateReleaseRequest, CallSettings)
            // Create client
            ConfigDeliveryClient configDeliveryClient = ConfigDeliveryClient.Create();
            // Initialize request argument(s)
            CreateReleaseRequest request = new CreateReleaseRequest
            {
                ParentAsResourceBundleName = ResourceBundleName.FromProjectLocationResourceBundle("[PROJECT]", "[LOCATION]", "[RESOURCE_BUNDLE]"),
                ReleaseId = "",
                Release = new Release(),
                RequestId = "",
            };
            // Make the request
            Operation<Release, OperationMetadata> response = configDeliveryClient.CreateRelease(request);

            // Poll until the returned long-running operation is complete
            Operation<Release, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Release result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Release, OperationMetadata> retrievedResponse = configDeliveryClient.PollOnceCreateRelease(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Release retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateReleaseAsync</summary>
        public async Task CreateReleaseRequestObjectAsync()
        {
            // Snippet: CreateReleaseAsync(CreateReleaseRequest, CallSettings)
            // Additional: CreateReleaseAsync(CreateReleaseRequest, CancellationToken)
            // Create client
            ConfigDeliveryClient configDeliveryClient = await ConfigDeliveryClient.CreateAsync();
            // Initialize request argument(s)
            CreateReleaseRequest request = new CreateReleaseRequest
            {
                ParentAsResourceBundleName = ResourceBundleName.FromProjectLocationResourceBundle("[PROJECT]", "[LOCATION]", "[RESOURCE_BUNDLE]"),
                ReleaseId = "",
                Release = new Release(),
                RequestId = "",
            };
            // Make the request
            Operation<Release, OperationMetadata> response = await configDeliveryClient.CreateReleaseAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Release, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Release result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Release, OperationMetadata> retrievedResponse = await configDeliveryClient.PollOnceCreateReleaseAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Release retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateRelease</summary>
        public void CreateRelease()
        {
            // Snippet: CreateRelease(string, Release, string, CallSettings)
            // Create client
            ConfigDeliveryClient configDeliveryClient = ConfigDeliveryClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/resourceBundles/[RESOURCE_BUNDLE]";
            Release release = new Release();
            string releaseId = "";
            // Make the request
            Operation<Release, OperationMetadata> response = configDeliveryClient.CreateRelease(parent, release, releaseId);

            // Poll until the returned long-running operation is complete
            Operation<Release, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Release result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Release, OperationMetadata> retrievedResponse = configDeliveryClient.PollOnceCreateRelease(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Release retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateReleaseAsync</summary>
        public async Task CreateReleaseAsync()
        {
            // Snippet: CreateReleaseAsync(string, Release, string, CallSettings)
            // Additional: CreateReleaseAsync(string, Release, string, CancellationToken)
            // Create client
            ConfigDeliveryClient configDeliveryClient = await ConfigDeliveryClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/resourceBundles/[RESOURCE_BUNDLE]";
            Release release = new Release();
            string releaseId = "";
            // Make the request
            Operation<Release, OperationMetadata> response = await configDeliveryClient.CreateReleaseAsync(parent, release, releaseId);

            // Poll until the returned long-running operation is complete
            Operation<Release, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Release result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Release, OperationMetadata> retrievedResponse = await configDeliveryClient.PollOnceCreateReleaseAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Release retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateRelease</summary>
        public void CreateReleaseResourceNames()
        {
            // Snippet: CreateRelease(ResourceBundleName, Release, string, CallSettings)
            // Create client
            ConfigDeliveryClient configDeliveryClient = ConfigDeliveryClient.Create();
            // Initialize request argument(s)
            ResourceBundleName parent = ResourceBundleName.FromProjectLocationResourceBundle("[PROJECT]", "[LOCATION]", "[RESOURCE_BUNDLE]");
            Release release = new Release();
            string releaseId = "";
            // Make the request
            Operation<Release, OperationMetadata> response = configDeliveryClient.CreateRelease(parent, release, releaseId);

            // Poll until the returned long-running operation is complete
            Operation<Release, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Release result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Release, OperationMetadata> retrievedResponse = configDeliveryClient.PollOnceCreateRelease(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Release retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateReleaseAsync</summary>
        public async Task CreateReleaseResourceNamesAsync()
        {
            // Snippet: CreateReleaseAsync(ResourceBundleName, Release, string, CallSettings)
            // Additional: CreateReleaseAsync(ResourceBundleName, Release, string, CancellationToken)
            // Create client
            ConfigDeliveryClient configDeliveryClient = await ConfigDeliveryClient.CreateAsync();
            // Initialize request argument(s)
            ResourceBundleName parent = ResourceBundleName.FromProjectLocationResourceBundle("[PROJECT]", "[LOCATION]", "[RESOURCE_BUNDLE]");
            Release release = new Release();
            string releaseId = "";
            // Make the request
            Operation<Release, OperationMetadata> response = await configDeliveryClient.CreateReleaseAsync(parent, release, releaseId);

            // Poll until the returned long-running operation is complete
            Operation<Release, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Release result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Release, OperationMetadata> retrievedResponse = await configDeliveryClient.PollOnceCreateReleaseAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Release retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateRelease</summary>
        public void UpdateReleaseRequestObject()
        {
            // Snippet: UpdateRelease(UpdateReleaseRequest, CallSettings)
            // Create client
            ConfigDeliveryClient configDeliveryClient = ConfigDeliveryClient.Create();
            // Initialize request argument(s)
            UpdateReleaseRequest request = new UpdateReleaseRequest
            {
                UpdateMask = new FieldMask(),
                Release = new Release(),
                RequestId = "",
            };
            // Make the request
            Operation<Release, OperationMetadata> response = configDeliveryClient.UpdateRelease(request);

            // Poll until the returned long-running operation is complete
            Operation<Release, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Release result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Release, OperationMetadata> retrievedResponse = configDeliveryClient.PollOnceUpdateRelease(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Release retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateReleaseAsync</summary>
        public async Task UpdateReleaseRequestObjectAsync()
        {
            // Snippet: UpdateReleaseAsync(UpdateReleaseRequest, CallSettings)
            // Additional: UpdateReleaseAsync(UpdateReleaseRequest, CancellationToken)
            // Create client
            ConfigDeliveryClient configDeliveryClient = await ConfigDeliveryClient.CreateAsync();
            // Initialize request argument(s)
            UpdateReleaseRequest request = new UpdateReleaseRequest
            {
                UpdateMask = new FieldMask(),
                Release = new Release(),
                RequestId = "",
            };
            // Make the request
            Operation<Release, OperationMetadata> response = await configDeliveryClient.UpdateReleaseAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Release, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Release result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Release, OperationMetadata> retrievedResponse = await configDeliveryClient.PollOnceUpdateReleaseAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Release retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateRelease</summary>
        public void UpdateRelease()
        {
            // Snippet: UpdateRelease(Release, FieldMask, CallSettings)
            // Create client
            ConfigDeliveryClient configDeliveryClient = ConfigDeliveryClient.Create();
            // Initialize request argument(s)
            Release release = new Release();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Release, OperationMetadata> response = configDeliveryClient.UpdateRelease(release, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Release, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Release result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Release, OperationMetadata> retrievedResponse = configDeliveryClient.PollOnceUpdateRelease(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Release retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateReleaseAsync</summary>
        public async Task UpdateReleaseAsync()
        {
            // Snippet: UpdateReleaseAsync(Release, FieldMask, CallSettings)
            // Additional: UpdateReleaseAsync(Release, FieldMask, CancellationToken)
            // Create client
            ConfigDeliveryClient configDeliveryClient = await ConfigDeliveryClient.CreateAsync();
            // Initialize request argument(s)
            Release release = new Release();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Release, OperationMetadata> response = await configDeliveryClient.UpdateReleaseAsync(release, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Release, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Release result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Release, OperationMetadata> retrievedResponse = await configDeliveryClient.PollOnceUpdateReleaseAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Release retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteRelease</summary>
        public void DeleteReleaseRequestObject()
        {
            // Snippet: DeleteRelease(DeleteReleaseRequest, CallSettings)
            // Create client
            ConfigDeliveryClient configDeliveryClient = ConfigDeliveryClient.Create();
            // Initialize request argument(s)
            DeleteReleaseRequest request = new DeleteReleaseRequest
            {
                ReleaseName = ReleaseName.FromProjectLocationResourceBundleRelease("[PROJECT]", "[LOCATION]", "[RESOURCE_BUNDLE]", "[RELEASE]"),
                RequestId = "",
                Force = false,
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = configDeliveryClient.DeleteRelease(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = configDeliveryClient.PollOnceDeleteRelease(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteReleaseAsync</summary>
        public async Task DeleteReleaseRequestObjectAsync()
        {
            // Snippet: DeleteReleaseAsync(DeleteReleaseRequest, CallSettings)
            // Additional: DeleteReleaseAsync(DeleteReleaseRequest, CancellationToken)
            // Create client
            ConfigDeliveryClient configDeliveryClient = await ConfigDeliveryClient.CreateAsync();
            // Initialize request argument(s)
            DeleteReleaseRequest request = new DeleteReleaseRequest
            {
                ReleaseName = ReleaseName.FromProjectLocationResourceBundleRelease("[PROJECT]", "[LOCATION]", "[RESOURCE_BUNDLE]", "[RELEASE]"),
                RequestId = "",
                Force = false,
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await configDeliveryClient.DeleteReleaseAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await configDeliveryClient.PollOnceDeleteReleaseAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteRelease</summary>
        public void DeleteRelease()
        {
            // Snippet: DeleteRelease(string, CallSettings)
            // Create client
            ConfigDeliveryClient configDeliveryClient = ConfigDeliveryClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/resourceBundles/[RESOURCE_BUNDLE]/releases/[RELEASE]";
            // Make the request
            Operation<Empty, OperationMetadata> response = configDeliveryClient.DeleteRelease(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = configDeliveryClient.PollOnceDeleteRelease(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteReleaseAsync</summary>
        public async Task DeleteReleaseAsync()
        {
            // Snippet: DeleteReleaseAsync(string, CallSettings)
            // Additional: DeleteReleaseAsync(string, CancellationToken)
            // Create client
            ConfigDeliveryClient configDeliveryClient = await ConfigDeliveryClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/resourceBundles/[RESOURCE_BUNDLE]/releases/[RELEASE]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await configDeliveryClient.DeleteReleaseAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await configDeliveryClient.PollOnceDeleteReleaseAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteRelease</summary>
        public void DeleteReleaseResourceNames()
        {
            // Snippet: DeleteRelease(ReleaseName, CallSettings)
            // Create client
            ConfigDeliveryClient configDeliveryClient = ConfigDeliveryClient.Create();
            // Initialize request argument(s)
            ReleaseName name = ReleaseName.FromProjectLocationResourceBundleRelease("[PROJECT]", "[LOCATION]", "[RESOURCE_BUNDLE]", "[RELEASE]");
            // Make the request
            Operation<Empty, OperationMetadata> response = configDeliveryClient.DeleteRelease(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = configDeliveryClient.PollOnceDeleteRelease(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteReleaseAsync</summary>
        public async Task DeleteReleaseResourceNamesAsync()
        {
            // Snippet: DeleteReleaseAsync(ReleaseName, CallSettings)
            // Additional: DeleteReleaseAsync(ReleaseName, CancellationToken)
            // Create client
            ConfigDeliveryClient configDeliveryClient = await ConfigDeliveryClient.CreateAsync();
            // Initialize request argument(s)
            ReleaseName name = ReleaseName.FromProjectLocationResourceBundleRelease("[PROJECT]", "[LOCATION]", "[RESOURCE_BUNDLE]", "[RELEASE]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await configDeliveryClient.DeleteReleaseAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await configDeliveryClient.PollOnceDeleteReleaseAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListVariants</summary>
        public void ListVariantsRequestObject()
        {
            // Snippet: ListVariants(ListVariantsRequest, CallSettings)
            // Create client
            ConfigDeliveryClient configDeliveryClient = ConfigDeliveryClient.Create();
            // Initialize request argument(s)
            ListVariantsRequest request = new ListVariantsRequest
            {
                ParentAsReleaseName = ReleaseName.FromProjectLocationResourceBundleRelease("[PROJECT]", "[LOCATION]", "[RESOURCE_BUNDLE]", "[RELEASE]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListVariantsResponse, Variant> response = configDeliveryClient.ListVariants(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Variant item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListVariantsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Variant item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Variant> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Variant item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListVariantsAsync</summary>
        public async Task ListVariantsRequestObjectAsync()
        {
            // Snippet: ListVariantsAsync(ListVariantsRequest, CallSettings)
            // Create client
            ConfigDeliveryClient configDeliveryClient = await ConfigDeliveryClient.CreateAsync();
            // Initialize request argument(s)
            ListVariantsRequest request = new ListVariantsRequest
            {
                ParentAsReleaseName = ReleaseName.FromProjectLocationResourceBundleRelease("[PROJECT]", "[LOCATION]", "[RESOURCE_BUNDLE]", "[RELEASE]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListVariantsResponse, Variant> response = configDeliveryClient.ListVariantsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Variant item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListVariantsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Variant item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Variant> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Variant item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListVariants</summary>
        public void ListVariants()
        {
            // Snippet: ListVariants(string, string, int?, CallSettings)
            // Create client
            ConfigDeliveryClient configDeliveryClient = ConfigDeliveryClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/resourceBundles/[RESOURCE_BUNDLE]/releases/[RELEASE]";
            // Make the request
            PagedEnumerable<ListVariantsResponse, Variant> response = configDeliveryClient.ListVariants(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Variant item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListVariantsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Variant item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Variant> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Variant item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListVariantsAsync</summary>
        public async Task ListVariantsAsync()
        {
            // Snippet: ListVariantsAsync(string, string, int?, CallSettings)
            // Create client
            ConfigDeliveryClient configDeliveryClient = await ConfigDeliveryClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/resourceBundles/[RESOURCE_BUNDLE]/releases/[RELEASE]";
            // Make the request
            PagedAsyncEnumerable<ListVariantsResponse, Variant> response = configDeliveryClient.ListVariantsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Variant item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListVariantsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Variant item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Variant> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Variant item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListVariants</summary>
        public void ListVariantsResourceNames()
        {
            // Snippet: ListVariants(ReleaseName, string, int?, CallSettings)
            // Create client
            ConfigDeliveryClient configDeliveryClient = ConfigDeliveryClient.Create();
            // Initialize request argument(s)
            ReleaseName parent = ReleaseName.FromProjectLocationResourceBundleRelease("[PROJECT]", "[LOCATION]", "[RESOURCE_BUNDLE]", "[RELEASE]");
            // Make the request
            PagedEnumerable<ListVariantsResponse, Variant> response = configDeliveryClient.ListVariants(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Variant item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListVariantsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Variant item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Variant> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Variant item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListVariantsAsync</summary>
        public async Task ListVariantsResourceNamesAsync()
        {
            // Snippet: ListVariantsAsync(ReleaseName, string, int?, CallSettings)
            // Create client
            ConfigDeliveryClient configDeliveryClient = await ConfigDeliveryClient.CreateAsync();
            // Initialize request argument(s)
            ReleaseName parent = ReleaseName.FromProjectLocationResourceBundleRelease("[PROJECT]", "[LOCATION]", "[RESOURCE_BUNDLE]", "[RELEASE]");
            // Make the request
            PagedAsyncEnumerable<ListVariantsResponse, Variant> response = configDeliveryClient.ListVariantsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Variant item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListVariantsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Variant item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Variant> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Variant item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetVariant</summary>
        public void GetVariantRequestObject()
        {
            // Snippet: GetVariant(GetVariantRequest, CallSettings)
            // Create client
            ConfigDeliveryClient configDeliveryClient = ConfigDeliveryClient.Create();
            // Initialize request argument(s)
            GetVariantRequest request = new GetVariantRequest
            {
                VariantName = VariantName.FromProjectLocationResourceBundleReleaseVariant("[PROJECT]", "[LOCATION]", "[RESOURCE_BUNDLE]", "[RELEASE]", "[VARIANT]"),
            };
            // Make the request
            Variant response = configDeliveryClient.GetVariant(request);
            // End snippet
        }

        /// <summary>Snippet for GetVariantAsync</summary>
        public async Task GetVariantRequestObjectAsync()
        {
            // Snippet: GetVariantAsync(GetVariantRequest, CallSettings)
            // Additional: GetVariantAsync(GetVariantRequest, CancellationToken)
            // Create client
            ConfigDeliveryClient configDeliveryClient = await ConfigDeliveryClient.CreateAsync();
            // Initialize request argument(s)
            GetVariantRequest request = new GetVariantRequest
            {
                VariantName = VariantName.FromProjectLocationResourceBundleReleaseVariant("[PROJECT]", "[LOCATION]", "[RESOURCE_BUNDLE]", "[RELEASE]", "[VARIANT]"),
            };
            // Make the request
            Variant response = await configDeliveryClient.GetVariantAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetVariant</summary>
        public void GetVariant()
        {
            // Snippet: GetVariant(string, CallSettings)
            // Create client
            ConfigDeliveryClient configDeliveryClient = ConfigDeliveryClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/resourceBundles/[RESOURCE_BUNDLE]/releases/[RELEASE]/variants/[VARIANT]";
            // Make the request
            Variant response = configDeliveryClient.GetVariant(name);
            // End snippet
        }

        /// <summary>Snippet for GetVariantAsync</summary>
        public async Task GetVariantAsync()
        {
            // Snippet: GetVariantAsync(string, CallSettings)
            // Additional: GetVariantAsync(string, CancellationToken)
            // Create client
            ConfigDeliveryClient configDeliveryClient = await ConfigDeliveryClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/resourceBundles/[RESOURCE_BUNDLE]/releases/[RELEASE]/variants/[VARIANT]";
            // Make the request
            Variant response = await configDeliveryClient.GetVariantAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetVariant</summary>
        public void GetVariantResourceNames()
        {
            // Snippet: GetVariant(VariantName, CallSettings)
            // Create client
            ConfigDeliveryClient configDeliveryClient = ConfigDeliveryClient.Create();
            // Initialize request argument(s)
            VariantName name = VariantName.FromProjectLocationResourceBundleReleaseVariant("[PROJECT]", "[LOCATION]", "[RESOURCE_BUNDLE]", "[RELEASE]", "[VARIANT]");
            // Make the request
            Variant response = configDeliveryClient.GetVariant(name);
            // End snippet
        }

        /// <summary>Snippet for GetVariantAsync</summary>
        public async Task GetVariantResourceNamesAsync()
        {
            // Snippet: GetVariantAsync(VariantName, CallSettings)
            // Additional: GetVariantAsync(VariantName, CancellationToken)
            // Create client
            ConfigDeliveryClient configDeliveryClient = await ConfigDeliveryClient.CreateAsync();
            // Initialize request argument(s)
            VariantName name = VariantName.FromProjectLocationResourceBundleReleaseVariant("[PROJECT]", "[LOCATION]", "[RESOURCE_BUNDLE]", "[RELEASE]", "[VARIANT]");
            // Make the request
            Variant response = await configDeliveryClient.GetVariantAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateVariant</summary>
        public void CreateVariantRequestObject()
        {
            // Snippet: CreateVariant(CreateVariantRequest, CallSettings)
            // Create client
            ConfigDeliveryClient configDeliveryClient = ConfigDeliveryClient.Create();
            // Initialize request argument(s)
            CreateVariantRequest request = new CreateVariantRequest
            {
                ParentAsReleaseName = ReleaseName.FromProjectLocationResourceBundleRelease("[PROJECT]", "[LOCATION]", "[RESOURCE_BUNDLE]", "[RELEASE]"),
                VariantId = "",
                Variant = new Variant(),
                RequestId = "",
            };
            // Make the request
            Operation<Variant, OperationMetadata> response = configDeliveryClient.CreateVariant(request);

            // Poll until the returned long-running operation is complete
            Operation<Variant, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Variant result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Variant, OperationMetadata> retrievedResponse = configDeliveryClient.PollOnceCreateVariant(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Variant retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateVariantAsync</summary>
        public async Task CreateVariantRequestObjectAsync()
        {
            // Snippet: CreateVariantAsync(CreateVariantRequest, CallSettings)
            // Additional: CreateVariantAsync(CreateVariantRequest, CancellationToken)
            // Create client
            ConfigDeliveryClient configDeliveryClient = await ConfigDeliveryClient.CreateAsync();
            // Initialize request argument(s)
            CreateVariantRequest request = new CreateVariantRequest
            {
                ParentAsReleaseName = ReleaseName.FromProjectLocationResourceBundleRelease("[PROJECT]", "[LOCATION]", "[RESOURCE_BUNDLE]", "[RELEASE]"),
                VariantId = "",
                Variant = new Variant(),
                RequestId = "",
            };
            // Make the request
            Operation<Variant, OperationMetadata> response = await configDeliveryClient.CreateVariantAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Variant, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Variant result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Variant, OperationMetadata> retrievedResponse = await configDeliveryClient.PollOnceCreateVariantAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Variant retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateVariant</summary>
        public void CreateVariant()
        {
            // Snippet: CreateVariant(string, Variant, string, CallSettings)
            // Create client
            ConfigDeliveryClient configDeliveryClient = ConfigDeliveryClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/resourceBundles/[RESOURCE_BUNDLE]/releases/[RELEASE]";
            Variant variant = new Variant();
            string variantId = "";
            // Make the request
            Operation<Variant, OperationMetadata> response = configDeliveryClient.CreateVariant(parent, variant, variantId);

            // Poll until the returned long-running operation is complete
            Operation<Variant, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Variant result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Variant, OperationMetadata> retrievedResponse = configDeliveryClient.PollOnceCreateVariant(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Variant retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateVariantAsync</summary>
        public async Task CreateVariantAsync()
        {
            // Snippet: CreateVariantAsync(string, Variant, string, CallSettings)
            // Additional: CreateVariantAsync(string, Variant, string, CancellationToken)
            // Create client
            ConfigDeliveryClient configDeliveryClient = await ConfigDeliveryClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/resourceBundles/[RESOURCE_BUNDLE]/releases/[RELEASE]";
            Variant variant = new Variant();
            string variantId = "";
            // Make the request
            Operation<Variant, OperationMetadata> response = await configDeliveryClient.CreateVariantAsync(parent, variant, variantId);

            // Poll until the returned long-running operation is complete
            Operation<Variant, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Variant result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Variant, OperationMetadata> retrievedResponse = await configDeliveryClient.PollOnceCreateVariantAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Variant retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateVariant</summary>
        public void CreateVariantResourceNames()
        {
            // Snippet: CreateVariant(ReleaseName, Variant, string, CallSettings)
            // Create client
            ConfigDeliveryClient configDeliveryClient = ConfigDeliveryClient.Create();
            // Initialize request argument(s)
            ReleaseName parent = ReleaseName.FromProjectLocationResourceBundleRelease("[PROJECT]", "[LOCATION]", "[RESOURCE_BUNDLE]", "[RELEASE]");
            Variant variant = new Variant();
            string variantId = "";
            // Make the request
            Operation<Variant, OperationMetadata> response = configDeliveryClient.CreateVariant(parent, variant, variantId);

            // Poll until the returned long-running operation is complete
            Operation<Variant, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Variant result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Variant, OperationMetadata> retrievedResponse = configDeliveryClient.PollOnceCreateVariant(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Variant retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateVariantAsync</summary>
        public async Task CreateVariantResourceNamesAsync()
        {
            // Snippet: CreateVariantAsync(ReleaseName, Variant, string, CallSettings)
            // Additional: CreateVariantAsync(ReleaseName, Variant, string, CancellationToken)
            // Create client
            ConfigDeliveryClient configDeliveryClient = await ConfigDeliveryClient.CreateAsync();
            // Initialize request argument(s)
            ReleaseName parent = ReleaseName.FromProjectLocationResourceBundleRelease("[PROJECT]", "[LOCATION]", "[RESOURCE_BUNDLE]", "[RELEASE]");
            Variant variant = new Variant();
            string variantId = "";
            // Make the request
            Operation<Variant, OperationMetadata> response = await configDeliveryClient.CreateVariantAsync(parent, variant, variantId);

            // Poll until the returned long-running operation is complete
            Operation<Variant, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Variant result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Variant, OperationMetadata> retrievedResponse = await configDeliveryClient.PollOnceCreateVariantAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Variant retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateVariant</summary>
        public void UpdateVariantRequestObject()
        {
            // Snippet: UpdateVariant(UpdateVariantRequest, CallSettings)
            // Create client
            ConfigDeliveryClient configDeliveryClient = ConfigDeliveryClient.Create();
            // Initialize request argument(s)
            UpdateVariantRequest request = new UpdateVariantRequest
            {
                UpdateMask = new FieldMask(),
                Variant = new Variant(),
                RequestId = "",
            };
            // Make the request
            Operation<Variant, OperationMetadata> response = configDeliveryClient.UpdateVariant(request);

            // Poll until the returned long-running operation is complete
            Operation<Variant, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Variant result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Variant, OperationMetadata> retrievedResponse = configDeliveryClient.PollOnceUpdateVariant(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Variant retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateVariantAsync</summary>
        public async Task UpdateVariantRequestObjectAsync()
        {
            // Snippet: UpdateVariantAsync(UpdateVariantRequest, CallSettings)
            // Additional: UpdateVariantAsync(UpdateVariantRequest, CancellationToken)
            // Create client
            ConfigDeliveryClient configDeliveryClient = await ConfigDeliveryClient.CreateAsync();
            // Initialize request argument(s)
            UpdateVariantRequest request = new UpdateVariantRequest
            {
                UpdateMask = new FieldMask(),
                Variant = new Variant(),
                RequestId = "",
            };
            // Make the request
            Operation<Variant, OperationMetadata> response = await configDeliveryClient.UpdateVariantAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Variant, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Variant result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Variant, OperationMetadata> retrievedResponse = await configDeliveryClient.PollOnceUpdateVariantAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Variant retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateVariant</summary>
        public void UpdateVariant()
        {
            // Snippet: UpdateVariant(Variant, FieldMask, CallSettings)
            // Create client
            ConfigDeliveryClient configDeliveryClient = ConfigDeliveryClient.Create();
            // Initialize request argument(s)
            Variant variant = new Variant();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Variant, OperationMetadata> response = configDeliveryClient.UpdateVariant(variant, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Variant, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Variant result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Variant, OperationMetadata> retrievedResponse = configDeliveryClient.PollOnceUpdateVariant(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Variant retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateVariantAsync</summary>
        public async Task UpdateVariantAsync()
        {
            // Snippet: UpdateVariantAsync(Variant, FieldMask, CallSettings)
            // Additional: UpdateVariantAsync(Variant, FieldMask, CancellationToken)
            // Create client
            ConfigDeliveryClient configDeliveryClient = await ConfigDeliveryClient.CreateAsync();
            // Initialize request argument(s)
            Variant variant = new Variant();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Variant, OperationMetadata> response = await configDeliveryClient.UpdateVariantAsync(variant, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Variant, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Variant result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Variant, OperationMetadata> retrievedResponse = await configDeliveryClient.PollOnceUpdateVariantAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Variant retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteVariant</summary>
        public void DeleteVariantRequestObject()
        {
            // Snippet: DeleteVariant(DeleteVariantRequest, CallSettings)
            // Create client
            ConfigDeliveryClient configDeliveryClient = ConfigDeliveryClient.Create();
            // Initialize request argument(s)
            DeleteVariantRequest request = new DeleteVariantRequest
            {
                VariantName = VariantName.FromProjectLocationResourceBundleReleaseVariant("[PROJECT]", "[LOCATION]", "[RESOURCE_BUNDLE]", "[RELEASE]", "[VARIANT]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = configDeliveryClient.DeleteVariant(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = configDeliveryClient.PollOnceDeleteVariant(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteVariantAsync</summary>
        public async Task DeleteVariantRequestObjectAsync()
        {
            // Snippet: DeleteVariantAsync(DeleteVariantRequest, CallSettings)
            // Additional: DeleteVariantAsync(DeleteVariantRequest, CancellationToken)
            // Create client
            ConfigDeliveryClient configDeliveryClient = await ConfigDeliveryClient.CreateAsync();
            // Initialize request argument(s)
            DeleteVariantRequest request = new DeleteVariantRequest
            {
                VariantName = VariantName.FromProjectLocationResourceBundleReleaseVariant("[PROJECT]", "[LOCATION]", "[RESOURCE_BUNDLE]", "[RELEASE]", "[VARIANT]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await configDeliveryClient.DeleteVariantAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await configDeliveryClient.PollOnceDeleteVariantAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteVariant</summary>
        public void DeleteVariant()
        {
            // Snippet: DeleteVariant(string, CallSettings)
            // Create client
            ConfigDeliveryClient configDeliveryClient = ConfigDeliveryClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/resourceBundles/[RESOURCE_BUNDLE]/releases/[RELEASE]/variants/[VARIANT]";
            // Make the request
            Operation<Empty, OperationMetadata> response = configDeliveryClient.DeleteVariant(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = configDeliveryClient.PollOnceDeleteVariant(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteVariantAsync</summary>
        public async Task DeleteVariantAsync()
        {
            // Snippet: DeleteVariantAsync(string, CallSettings)
            // Additional: DeleteVariantAsync(string, CancellationToken)
            // Create client
            ConfigDeliveryClient configDeliveryClient = await ConfigDeliveryClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/resourceBundles/[RESOURCE_BUNDLE]/releases/[RELEASE]/variants/[VARIANT]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await configDeliveryClient.DeleteVariantAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await configDeliveryClient.PollOnceDeleteVariantAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteVariant</summary>
        public void DeleteVariantResourceNames()
        {
            // Snippet: DeleteVariant(VariantName, CallSettings)
            // Create client
            ConfigDeliveryClient configDeliveryClient = ConfigDeliveryClient.Create();
            // Initialize request argument(s)
            VariantName name = VariantName.FromProjectLocationResourceBundleReleaseVariant("[PROJECT]", "[LOCATION]", "[RESOURCE_BUNDLE]", "[RELEASE]", "[VARIANT]");
            // Make the request
            Operation<Empty, OperationMetadata> response = configDeliveryClient.DeleteVariant(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = configDeliveryClient.PollOnceDeleteVariant(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteVariantAsync</summary>
        public async Task DeleteVariantResourceNamesAsync()
        {
            // Snippet: DeleteVariantAsync(VariantName, CallSettings)
            // Additional: DeleteVariantAsync(VariantName, CancellationToken)
            // Create client
            ConfigDeliveryClient configDeliveryClient = await ConfigDeliveryClient.CreateAsync();
            // Initialize request argument(s)
            VariantName name = VariantName.FromProjectLocationResourceBundleReleaseVariant("[PROJECT]", "[LOCATION]", "[RESOURCE_BUNDLE]", "[RELEASE]", "[VARIANT]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await configDeliveryClient.DeleteVariantAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await configDeliveryClient.PollOnceDeleteVariantAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListRollouts</summary>
        public void ListRolloutsRequestObject()
        {
            // Snippet: ListRollouts(ListRolloutsRequest, CallSettings)
            // Create client
            ConfigDeliveryClient configDeliveryClient = ConfigDeliveryClient.Create();
            // Initialize request argument(s)
            ListRolloutsRequest request = new ListRolloutsRequest
            {
                ParentAsFleetPackageName = FleetPackageName.FromProjectLocationFleetPackage("[PROJECT]", "[LOCATION]", "[FLEET_PACKAGE]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListRolloutsResponse, Rollout> response = configDeliveryClient.ListRollouts(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Rollout item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRolloutsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Rollout item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Rollout> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Rollout item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRolloutsAsync</summary>
        public async Task ListRolloutsRequestObjectAsync()
        {
            // Snippet: ListRolloutsAsync(ListRolloutsRequest, CallSettings)
            // Create client
            ConfigDeliveryClient configDeliveryClient = await ConfigDeliveryClient.CreateAsync();
            // Initialize request argument(s)
            ListRolloutsRequest request = new ListRolloutsRequest
            {
                ParentAsFleetPackageName = FleetPackageName.FromProjectLocationFleetPackage("[PROJECT]", "[LOCATION]", "[FLEET_PACKAGE]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListRolloutsResponse, Rollout> response = configDeliveryClient.ListRolloutsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Rollout item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListRolloutsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Rollout item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Rollout> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Rollout item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRollouts</summary>
        public void ListRollouts()
        {
            // Snippet: ListRollouts(string, string, int?, CallSettings)
            // Create client
            ConfigDeliveryClient configDeliveryClient = ConfigDeliveryClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/fleetPackages/[FLEET_PACKAGE]";
            // Make the request
            PagedEnumerable<ListRolloutsResponse, Rollout> response = configDeliveryClient.ListRollouts(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Rollout item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRolloutsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Rollout item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Rollout> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Rollout item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRolloutsAsync</summary>
        public async Task ListRolloutsAsync()
        {
            // Snippet: ListRolloutsAsync(string, string, int?, CallSettings)
            // Create client
            ConfigDeliveryClient configDeliveryClient = await ConfigDeliveryClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/fleetPackages/[FLEET_PACKAGE]";
            // Make the request
            PagedAsyncEnumerable<ListRolloutsResponse, Rollout> response = configDeliveryClient.ListRolloutsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Rollout item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListRolloutsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Rollout item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Rollout> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Rollout item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRollouts</summary>
        public void ListRolloutsResourceNames()
        {
            // Snippet: ListRollouts(FleetPackageName, string, int?, CallSettings)
            // Create client
            ConfigDeliveryClient configDeliveryClient = ConfigDeliveryClient.Create();
            // Initialize request argument(s)
            FleetPackageName parent = FleetPackageName.FromProjectLocationFleetPackage("[PROJECT]", "[LOCATION]", "[FLEET_PACKAGE]");
            // Make the request
            PagedEnumerable<ListRolloutsResponse, Rollout> response = configDeliveryClient.ListRollouts(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Rollout item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRolloutsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Rollout item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Rollout> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Rollout item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRolloutsAsync</summary>
        public async Task ListRolloutsResourceNamesAsync()
        {
            // Snippet: ListRolloutsAsync(FleetPackageName, string, int?, CallSettings)
            // Create client
            ConfigDeliveryClient configDeliveryClient = await ConfigDeliveryClient.CreateAsync();
            // Initialize request argument(s)
            FleetPackageName parent = FleetPackageName.FromProjectLocationFleetPackage("[PROJECT]", "[LOCATION]", "[FLEET_PACKAGE]");
            // Make the request
            PagedAsyncEnumerable<ListRolloutsResponse, Rollout> response = configDeliveryClient.ListRolloutsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Rollout item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListRolloutsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Rollout item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Rollout> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Rollout item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetRollout</summary>
        public void GetRolloutRequestObject()
        {
            // Snippet: GetRollout(GetRolloutRequest, CallSettings)
            // Create client
            ConfigDeliveryClient configDeliveryClient = ConfigDeliveryClient.Create();
            // Initialize request argument(s)
            GetRolloutRequest request = new GetRolloutRequest
            {
                RolloutName = RolloutName.FromProjectLocationFleetPackageRollout("[PROJECT]", "[LOCATION]", "[FLEET_PACKAGE]", "[ROLLOUT]"),
            };
            // Make the request
            Rollout response = configDeliveryClient.GetRollout(request);
            // End snippet
        }

        /// <summary>Snippet for GetRolloutAsync</summary>
        public async Task GetRolloutRequestObjectAsync()
        {
            // Snippet: GetRolloutAsync(GetRolloutRequest, CallSettings)
            // Additional: GetRolloutAsync(GetRolloutRequest, CancellationToken)
            // Create client
            ConfigDeliveryClient configDeliveryClient = await ConfigDeliveryClient.CreateAsync();
            // Initialize request argument(s)
            GetRolloutRequest request = new GetRolloutRequest
            {
                RolloutName = RolloutName.FromProjectLocationFleetPackageRollout("[PROJECT]", "[LOCATION]", "[FLEET_PACKAGE]", "[ROLLOUT]"),
            };
            // Make the request
            Rollout response = await configDeliveryClient.GetRolloutAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetRollout</summary>
        public void GetRollout()
        {
            // Snippet: GetRollout(string, CallSettings)
            // Create client
            ConfigDeliveryClient configDeliveryClient = ConfigDeliveryClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/fleetPackages/[FLEET_PACKAGE]/rollouts/[ROLLOUT]";
            // Make the request
            Rollout response = configDeliveryClient.GetRollout(name);
            // End snippet
        }

        /// <summary>Snippet for GetRolloutAsync</summary>
        public async Task GetRolloutAsync()
        {
            // Snippet: GetRolloutAsync(string, CallSettings)
            // Additional: GetRolloutAsync(string, CancellationToken)
            // Create client
            ConfigDeliveryClient configDeliveryClient = await ConfigDeliveryClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/fleetPackages/[FLEET_PACKAGE]/rollouts/[ROLLOUT]";
            // Make the request
            Rollout response = await configDeliveryClient.GetRolloutAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetRollout</summary>
        public void GetRolloutResourceNames()
        {
            // Snippet: GetRollout(RolloutName, CallSettings)
            // Create client
            ConfigDeliveryClient configDeliveryClient = ConfigDeliveryClient.Create();
            // Initialize request argument(s)
            RolloutName name = RolloutName.FromProjectLocationFleetPackageRollout("[PROJECT]", "[LOCATION]", "[FLEET_PACKAGE]", "[ROLLOUT]");
            // Make the request
            Rollout response = configDeliveryClient.GetRollout(name);
            // End snippet
        }

        /// <summary>Snippet for GetRolloutAsync</summary>
        public async Task GetRolloutResourceNamesAsync()
        {
            // Snippet: GetRolloutAsync(RolloutName, CallSettings)
            // Additional: GetRolloutAsync(RolloutName, CancellationToken)
            // Create client
            ConfigDeliveryClient configDeliveryClient = await ConfigDeliveryClient.CreateAsync();
            // Initialize request argument(s)
            RolloutName name = RolloutName.FromProjectLocationFleetPackageRollout("[PROJECT]", "[LOCATION]", "[FLEET_PACKAGE]", "[ROLLOUT]");
            // Make the request
            Rollout response = await configDeliveryClient.GetRolloutAsync(name);
            // End snippet
        }

        /// <summary>Snippet for SuspendRollout</summary>
        public void SuspendRolloutRequestObject()
        {
            // Snippet: SuspendRollout(SuspendRolloutRequest, CallSettings)
            // Create client
            ConfigDeliveryClient configDeliveryClient = ConfigDeliveryClient.Create();
            // Initialize request argument(s)
            SuspendRolloutRequest request = new SuspendRolloutRequest
            {
                RolloutName = RolloutName.FromProjectLocationFleetPackageRollout("[PROJECT]", "[LOCATION]", "[FLEET_PACKAGE]", "[ROLLOUT]"),
                Reason = "",
            };
            // Make the request
            Operation<Rollout, OperationMetadata> response = configDeliveryClient.SuspendRollout(request);

            // Poll until the returned long-running operation is complete
            Operation<Rollout, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Rollout result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Rollout, OperationMetadata> retrievedResponse = configDeliveryClient.PollOnceSuspendRollout(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Rollout retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SuspendRolloutAsync</summary>
        public async Task SuspendRolloutRequestObjectAsync()
        {
            // Snippet: SuspendRolloutAsync(SuspendRolloutRequest, CallSettings)
            // Additional: SuspendRolloutAsync(SuspendRolloutRequest, CancellationToken)
            // Create client
            ConfigDeliveryClient configDeliveryClient = await ConfigDeliveryClient.CreateAsync();
            // Initialize request argument(s)
            SuspendRolloutRequest request = new SuspendRolloutRequest
            {
                RolloutName = RolloutName.FromProjectLocationFleetPackageRollout("[PROJECT]", "[LOCATION]", "[FLEET_PACKAGE]", "[ROLLOUT]"),
                Reason = "",
            };
            // Make the request
            Operation<Rollout, OperationMetadata> response = await configDeliveryClient.SuspendRolloutAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Rollout, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Rollout result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Rollout, OperationMetadata> retrievedResponse = await configDeliveryClient.PollOnceSuspendRolloutAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Rollout retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SuspendRollout</summary>
        public void SuspendRollout()
        {
            // Snippet: SuspendRollout(string, CallSettings)
            // Create client
            ConfigDeliveryClient configDeliveryClient = ConfigDeliveryClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/fleetPackages/[FLEET_PACKAGE]/rollouts/[ROLLOUT]";
            // Make the request
            Operation<Rollout, OperationMetadata> response = configDeliveryClient.SuspendRollout(name);

            // Poll until the returned long-running operation is complete
            Operation<Rollout, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Rollout result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Rollout, OperationMetadata> retrievedResponse = configDeliveryClient.PollOnceSuspendRollout(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Rollout retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SuspendRolloutAsync</summary>
        public async Task SuspendRolloutAsync()
        {
            // Snippet: SuspendRolloutAsync(string, CallSettings)
            // Additional: SuspendRolloutAsync(string, CancellationToken)
            // Create client
            ConfigDeliveryClient configDeliveryClient = await ConfigDeliveryClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/fleetPackages/[FLEET_PACKAGE]/rollouts/[ROLLOUT]";
            // Make the request
            Operation<Rollout, OperationMetadata> response = await configDeliveryClient.SuspendRolloutAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Rollout, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Rollout result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Rollout, OperationMetadata> retrievedResponse = await configDeliveryClient.PollOnceSuspendRolloutAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Rollout retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SuspendRollout</summary>
        public void SuspendRolloutResourceNames()
        {
            // Snippet: SuspendRollout(RolloutName, CallSettings)
            // Create client
            ConfigDeliveryClient configDeliveryClient = ConfigDeliveryClient.Create();
            // Initialize request argument(s)
            RolloutName name = RolloutName.FromProjectLocationFleetPackageRollout("[PROJECT]", "[LOCATION]", "[FLEET_PACKAGE]", "[ROLLOUT]");
            // Make the request
            Operation<Rollout, OperationMetadata> response = configDeliveryClient.SuspendRollout(name);

            // Poll until the returned long-running operation is complete
            Operation<Rollout, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Rollout result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Rollout, OperationMetadata> retrievedResponse = configDeliveryClient.PollOnceSuspendRollout(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Rollout retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SuspendRolloutAsync</summary>
        public async Task SuspendRolloutResourceNamesAsync()
        {
            // Snippet: SuspendRolloutAsync(RolloutName, CallSettings)
            // Additional: SuspendRolloutAsync(RolloutName, CancellationToken)
            // Create client
            ConfigDeliveryClient configDeliveryClient = await ConfigDeliveryClient.CreateAsync();
            // Initialize request argument(s)
            RolloutName name = RolloutName.FromProjectLocationFleetPackageRollout("[PROJECT]", "[LOCATION]", "[FLEET_PACKAGE]", "[ROLLOUT]");
            // Make the request
            Operation<Rollout, OperationMetadata> response = await configDeliveryClient.SuspendRolloutAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Rollout, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Rollout result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Rollout, OperationMetadata> retrievedResponse = await configDeliveryClient.PollOnceSuspendRolloutAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Rollout retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ResumeRollout</summary>
        public void ResumeRolloutRequestObject()
        {
            // Snippet: ResumeRollout(ResumeRolloutRequest, CallSettings)
            // Create client
            ConfigDeliveryClient configDeliveryClient = ConfigDeliveryClient.Create();
            // Initialize request argument(s)
            ResumeRolloutRequest request = new ResumeRolloutRequest
            {
                RolloutName = RolloutName.FromProjectLocationFleetPackageRollout("[PROJECT]", "[LOCATION]", "[FLEET_PACKAGE]", "[ROLLOUT]"),
                Reason = "",
            };
            // Make the request
            Operation<Rollout, OperationMetadata> response = configDeliveryClient.ResumeRollout(request);

            // Poll until the returned long-running operation is complete
            Operation<Rollout, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Rollout result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Rollout, OperationMetadata> retrievedResponse = configDeliveryClient.PollOnceResumeRollout(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Rollout retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ResumeRolloutAsync</summary>
        public async Task ResumeRolloutRequestObjectAsync()
        {
            // Snippet: ResumeRolloutAsync(ResumeRolloutRequest, CallSettings)
            // Additional: ResumeRolloutAsync(ResumeRolloutRequest, CancellationToken)
            // Create client
            ConfigDeliveryClient configDeliveryClient = await ConfigDeliveryClient.CreateAsync();
            // Initialize request argument(s)
            ResumeRolloutRequest request = new ResumeRolloutRequest
            {
                RolloutName = RolloutName.FromProjectLocationFleetPackageRollout("[PROJECT]", "[LOCATION]", "[FLEET_PACKAGE]", "[ROLLOUT]"),
                Reason = "",
            };
            // Make the request
            Operation<Rollout, OperationMetadata> response = await configDeliveryClient.ResumeRolloutAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Rollout, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Rollout result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Rollout, OperationMetadata> retrievedResponse = await configDeliveryClient.PollOnceResumeRolloutAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Rollout retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ResumeRollout</summary>
        public void ResumeRollout()
        {
            // Snippet: ResumeRollout(string, CallSettings)
            // Create client
            ConfigDeliveryClient configDeliveryClient = ConfigDeliveryClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/fleetPackages/[FLEET_PACKAGE]/rollouts/[ROLLOUT]";
            // Make the request
            Operation<Rollout, OperationMetadata> response = configDeliveryClient.ResumeRollout(name);

            // Poll until the returned long-running operation is complete
            Operation<Rollout, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Rollout result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Rollout, OperationMetadata> retrievedResponse = configDeliveryClient.PollOnceResumeRollout(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Rollout retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ResumeRolloutAsync</summary>
        public async Task ResumeRolloutAsync()
        {
            // Snippet: ResumeRolloutAsync(string, CallSettings)
            // Additional: ResumeRolloutAsync(string, CancellationToken)
            // Create client
            ConfigDeliveryClient configDeliveryClient = await ConfigDeliveryClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/fleetPackages/[FLEET_PACKAGE]/rollouts/[ROLLOUT]";
            // Make the request
            Operation<Rollout, OperationMetadata> response = await configDeliveryClient.ResumeRolloutAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Rollout, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Rollout result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Rollout, OperationMetadata> retrievedResponse = await configDeliveryClient.PollOnceResumeRolloutAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Rollout retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ResumeRollout</summary>
        public void ResumeRolloutResourceNames()
        {
            // Snippet: ResumeRollout(RolloutName, CallSettings)
            // Create client
            ConfigDeliveryClient configDeliveryClient = ConfigDeliveryClient.Create();
            // Initialize request argument(s)
            RolloutName name = RolloutName.FromProjectLocationFleetPackageRollout("[PROJECT]", "[LOCATION]", "[FLEET_PACKAGE]", "[ROLLOUT]");
            // Make the request
            Operation<Rollout, OperationMetadata> response = configDeliveryClient.ResumeRollout(name);

            // Poll until the returned long-running operation is complete
            Operation<Rollout, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Rollout result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Rollout, OperationMetadata> retrievedResponse = configDeliveryClient.PollOnceResumeRollout(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Rollout retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ResumeRolloutAsync</summary>
        public async Task ResumeRolloutResourceNamesAsync()
        {
            // Snippet: ResumeRolloutAsync(RolloutName, CallSettings)
            // Additional: ResumeRolloutAsync(RolloutName, CancellationToken)
            // Create client
            ConfigDeliveryClient configDeliveryClient = await ConfigDeliveryClient.CreateAsync();
            // Initialize request argument(s)
            RolloutName name = RolloutName.FromProjectLocationFleetPackageRollout("[PROJECT]", "[LOCATION]", "[FLEET_PACKAGE]", "[ROLLOUT]");
            // Make the request
            Operation<Rollout, OperationMetadata> response = await configDeliveryClient.ResumeRolloutAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Rollout, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Rollout result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Rollout, OperationMetadata> retrievedResponse = await configDeliveryClient.PollOnceResumeRolloutAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Rollout retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AbortRollout</summary>
        public void AbortRolloutRequestObject()
        {
            // Snippet: AbortRollout(AbortRolloutRequest, CallSettings)
            // Create client
            ConfigDeliveryClient configDeliveryClient = ConfigDeliveryClient.Create();
            // Initialize request argument(s)
            AbortRolloutRequest request = new AbortRolloutRequest
            {
                RolloutName = RolloutName.FromProjectLocationFleetPackageRollout("[PROJECT]", "[LOCATION]", "[FLEET_PACKAGE]", "[ROLLOUT]"),
                Reason = "",
            };
            // Make the request
            Operation<Rollout, OperationMetadata> response = configDeliveryClient.AbortRollout(request);

            // Poll until the returned long-running operation is complete
            Operation<Rollout, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Rollout result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Rollout, OperationMetadata> retrievedResponse = configDeliveryClient.PollOnceAbortRollout(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Rollout retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AbortRolloutAsync</summary>
        public async Task AbortRolloutRequestObjectAsync()
        {
            // Snippet: AbortRolloutAsync(AbortRolloutRequest, CallSettings)
            // Additional: AbortRolloutAsync(AbortRolloutRequest, CancellationToken)
            // Create client
            ConfigDeliveryClient configDeliveryClient = await ConfigDeliveryClient.CreateAsync();
            // Initialize request argument(s)
            AbortRolloutRequest request = new AbortRolloutRequest
            {
                RolloutName = RolloutName.FromProjectLocationFleetPackageRollout("[PROJECT]", "[LOCATION]", "[FLEET_PACKAGE]", "[ROLLOUT]"),
                Reason = "",
            };
            // Make the request
            Operation<Rollout, OperationMetadata> response = await configDeliveryClient.AbortRolloutAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Rollout, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Rollout result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Rollout, OperationMetadata> retrievedResponse = await configDeliveryClient.PollOnceAbortRolloutAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Rollout retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AbortRollout</summary>
        public void AbortRollout()
        {
            // Snippet: AbortRollout(string, CallSettings)
            // Create client
            ConfigDeliveryClient configDeliveryClient = ConfigDeliveryClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/fleetPackages/[FLEET_PACKAGE]/rollouts/[ROLLOUT]";
            // Make the request
            Operation<Rollout, OperationMetadata> response = configDeliveryClient.AbortRollout(name);

            // Poll until the returned long-running operation is complete
            Operation<Rollout, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Rollout result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Rollout, OperationMetadata> retrievedResponse = configDeliveryClient.PollOnceAbortRollout(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Rollout retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AbortRolloutAsync</summary>
        public async Task AbortRolloutAsync()
        {
            // Snippet: AbortRolloutAsync(string, CallSettings)
            // Additional: AbortRolloutAsync(string, CancellationToken)
            // Create client
            ConfigDeliveryClient configDeliveryClient = await ConfigDeliveryClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/fleetPackages/[FLEET_PACKAGE]/rollouts/[ROLLOUT]";
            // Make the request
            Operation<Rollout, OperationMetadata> response = await configDeliveryClient.AbortRolloutAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Rollout, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Rollout result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Rollout, OperationMetadata> retrievedResponse = await configDeliveryClient.PollOnceAbortRolloutAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Rollout retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AbortRollout</summary>
        public void AbortRolloutResourceNames()
        {
            // Snippet: AbortRollout(RolloutName, CallSettings)
            // Create client
            ConfigDeliveryClient configDeliveryClient = ConfigDeliveryClient.Create();
            // Initialize request argument(s)
            RolloutName name = RolloutName.FromProjectLocationFleetPackageRollout("[PROJECT]", "[LOCATION]", "[FLEET_PACKAGE]", "[ROLLOUT]");
            // Make the request
            Operation<Rollout, OperationMetadata> response = configDeliveryClient.AbortRollout(name);

            // Poll until the returned long-running operation is complete
            Operation<Rollout, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Rollout result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Rollout, OperationMetadata> retrievedResponse = configDeliveryClient.PollOnceAbortRollout(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Rollout retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AbortRolloutAsync</summary>
        public async Task AbortRolloutResourceNamesAsync()
        {
            // Snippet: AbortRolloutAsync(RolloutName, CallSettings)
            // Additional: AbortRolloutAsync(RolloutName, CancellationToken)
            // Create client
            ConfigDeliveryClient configDeliveryClient = await ConfigDeliveryClient.CreateAsync();
            // Initialize request argument(s)
            RolloutName name = RolloutName.FromProjectLocationFleetPackageRollout("[PROJECT]", "[LOCATION]", "[FLEET_PACKAGE]", "[ROLLOUT]");
            // Make the request
            Operation<Rollout, OperationMetadata> response = await configDeliveryClient.AbortRolloutAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Rollout, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Rollout result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Rollout, OperationMetadata> retrievedResponse = await configDeliveryClient.PollOnceAbortRolloutAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Rollout retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
