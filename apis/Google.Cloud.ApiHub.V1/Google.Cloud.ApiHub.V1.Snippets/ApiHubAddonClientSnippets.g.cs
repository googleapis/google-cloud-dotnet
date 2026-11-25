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
    using Google.Cloud.ApiHub.V1;
    using Google.LongRunning;
    using System;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedApiHubAddonClientSnippets
    {
        /// <summary>Snippet for GetAddon</summary>
        public void GetAddonRequestObject()
        {
            // Snippet: GetAddon(GetAddonRequest, CallSettings)
            // Create client
            ApiHubAddonClient apiHubAddonClient = ApiHubAddonClient.Create();
            // Initialize request argument(s)
            GetAddonRequest request = new GetAddonRequest
            {
                AddonName = AddonName.FromProjectLocationAddon("[PROJECT]", "[LOCATION]", "[ADDON]"),
            };
            // Make the request
            Addon response = apiHubAddonClient.GetAddon(request);
            // End snippet
        }

        /// <summary>Snippet for GetAddonAsync</summary>
        public async Task GetAddonRequestObjectAsync()
        {
            // Snippet: GetAddonAsync(GetAddonRequest, CallSettings)
            // Additional: GetAddonAsync(GetAddonRequest, CancellationToken)
            // Create client
            ApiHubAddonClient apiHubAddonClient = await ApiHubAddonClient.CreateAsync();
            // Initialize request argument(s)
            GetAddonRequest request = new GetAddonRequest
            {
                AddonName = AddonName.FromProjectLocationAddon("[PROJECT]", "[LOCATION]", "[ADDON]"),
            };
            // Make the request
            Addon response = await apiHubAddonClient.GetAddonAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAddon</summary>
        public void GetAddon()
        {
            // Snippet: GetAddon(string, CallSettings)
            // Create client
            ApiHubAddonClient apiHubAddonClient = ApiHubAddonClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/addons/[ADDON]";
            // Make the request
            Addon response = apiHubAddonClient.GetAddon(name);
            // End snippet
        }

        /// <summary>Snippet for GetAddonAsync</summary>
        public async Task GetAddonAsync()
        {
            // Snippet: GetAddonAsync(string, CallSettings)
            // Additional: GetAddonAsync(string, CancellationToken)
            // Create client
            ApiHubAddonClient apiHubAddonClient = await ApiHubAddonClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/addons/[ADDON]";
            // Make the request
            Addon response = await apiHubAddonClient.GetAddonAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetAddon</summary>
        public void GetAddonResourceNames()
        {
            // Snippet: GetAddon(AddonName, CallSettings)
            // Create client
            ApiHubAddonClient apiHubAddonClient = ApiHubAddonClient.Create();
            // Initialize request argument(s)
            AddonName name = AddonName.FromProjectLocationAddon("[PROJECT]", "[LOCATION]", "[ADDON]");
            // Make the request
            Addon response = apiHubAddonClient.GetAddon(name);
            // End snippet
        }

        /// <summary>Snippet for GetAddonAsync</summary>
        public async Task GetAddonResourceNamesAsync()
        {
            // Snippet: GetAddonAsync(AddonName, CallSettings)
            // Additional: GetAddonAsync(AddonName, CancellationToken)
            // Create client
            ApiHubAddonClient apiHubAddonClient = await ApiHubAddonClient.CreateAsync();
            // Initialize request argument(s)
            AddonName name = AddonName.FromProjectLocationAddon("[PROJECT]", "[LOCATION]", "[ADDON]");
            // Make the request
            Addon response = await apiHubAddonClient.GetAddonAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ManageAddonConfig</summary>
        public void ManageAddonConfigRequestObject()
        {
            // Snippet: ManageAddonConfig(ManageAddonConfigRequest, CallSettings)
            // Create client
            ApiHubAddonClient apiHubAddonClient = ApiHubAddonClient.Create();
            // Initialize request argument(s)
            ManageAddonConfigRequest request = new ManageAddonConfigRequest
            {
                AddonName = AddonName.FromProjectLocationAddon("[PROJECT]", "[LOCATION]", "[ADDON]"),
                Config = new AddonConfig(),
            };
            // Make the request
            Operation<Addon, OperationMetadata> response = apiHubAddonClient.ManageAddonConfig(request);

            // Poll until the returned long-running operation is complete
            Operation<Addon, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Addon result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Addon, OperationMetadata> retrievedResponse = apiHubAddonClient.PollOnceManageAddonConfig(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Addon retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ManageAddonConfigAsync</summary>
        public async Task ManageAddonConfigRequestObjectAsync()
        {
            // Snippet: ManageAddonConfigAsync(ManageAddonConfigRequest, CallSettings)
            // Additional: ManageAddonConfigAsync(ManageAddonConfigRequest, CancellationToken)
            // Create client
            ApiHubAddonClient apiHubAddonClient = await ApiHubAddonClient.CreateAsync();
            // Initialize request argument(s)
            ManageAddonConfigRequest request = new ManageAddonConfigRequest
            {
                AddonName = AddonName.FromProjectLocationAddon("[PROJECT]", "[LOCATION]", "[ADDON]"),
                Config = new AddonConfig(),
            };
            // Make the request
            Operation<Addon, OperationMetadata> response = await apiHubAddonClient.ManageAddonConfigAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Addon, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Addon result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Addon, OperationMetadata> retrievedResponse = await apiHubAddonClient.PollOnceManageAddonConfigAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Addon retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ManageAddonConfig</summary>
        public void ManageAddonConfig()
        {
            // Snippet: ManageAddonConfig(string, AddonConfig, CallSettings)
            // Create client
            ApiHubAddonClient apiHubAddonClient = ApiHubAddonClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/addons/[ADDON]";
            AddonConfig config = new AddonConfig();
            // Make the request
            Operation<Addon, OperationMetadata> response = apiHubAddonClient.ManageAddonConfig(name, config);

            // Poll until the returned long-running operation is complete
            Operation<Addon, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Addon result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Addon, OperationMetadata> retrievedResponse = apiHubAddonClient.PollOnceManageAddonConfig(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Addon retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ManageAddonConfigAsync</summary>
        public async Task ManageAddonConfigAsync()
        {
            // Snippet: ManageAddonConfigAsync(string, AddonConfig, CallSettings)
            // Additional: ManageAddonConfigAsync(string, AddonConfig, CancellationToken)
            // Create client
            ApiHubAddonClient apiHubAddonClient = await ApiHubAddonClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/addons/[ADDON]";
            AddonConfig config = new AddonConfig();
            // Make the request
            Operation<Addon, OperationMetadata> response = await apiHubAddonClient.ManageAddonConfigAsync(name, config);

            // Poll until the returned long-running operation is complete
            Operation<Addon, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Addon result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Addon, OperationMetadata> retrievedResponse = await apiHubAddonClient.PollOnceManageAddonConfigAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Addon retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ManageAddonConfig</summary>
        public void ManageAddonConfigResourceNames()
        {
            // Snippet: ManageAddonConfig(AddonName, AddonConfig, CallSettings)
            // Create client
            ApiHubAddonClient apiHubAddonClient = ApiHubAddonClient.Create();
            // Initialize request argument(s)
            AddonName name = AddonName.FromProjectLocationAddon("[PROJECT]", "[LOCATION]", "[ADDON]");
            AddonConfig config = new AddonConfig();
            // Make the request
            Operation<Addon, OperationMetadata> response = apiHubAddonClient.ManageAddonConfig(name, config);

            // Poll until the returned long-running operation is complete
            Operation<Addon, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Addon result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Addon, OperationMetadata> retrievedResponse = apiHubAddonClient.PollOnceManageAddonConfig(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Addon retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ManageAddonConfigAsync</summary>
        public async Task ManageAddonConfigResourceNamesAsync()
        {
            // Snippet: ManageAddonConfigAsync(AddonName, AddonConfig, CallSettings)
            // Additional: ManageAddonConfigAsync(AddonName, AddonConfig, CancellationToken)
            // Create client
            ApiHubAddonClient apiHubAddonClient = await ApiHubAddonClient.CreateAsync();
            // Initialize request argument(s)
            AddonName name = AddonName.FromProjectLocationAddon("[PROJECT]", "[LOCATION]", "[ADDON]");
            AddonConfig config = new AddonConfig();
            // Make the request
            Operation<Addon, OperationMetadata> response = await apiHubAddonClient.ManageAddonConfigAsync(name, config);

            // Poll until the returned long-running operation is complete
            Operation<Addon, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Addon result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Addon, OperationMetadata> retrievedResponse = await apiHubAddonClient.PollOnceManageAddonConfigAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Addon retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListAddons</summary>
        public void ListAddonsRequestObject()
        {
            // Snippet: ListAddons(ListAddonsRequest, CallSettings)
            // Create client
            ApiHubAddonClient apiHubAddonClient = ApiHubAddonClient.Create();
            // Initialize request argument(s)
            ListAddonsRequest request = new ListAddonsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListAddonsResponse, Addon> response = apiHubAddonClient.ListAddons(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Addon item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAddonsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Addon item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Addon> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Addon item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAddonsAsync</summary>
        public async Task ListAddonsRequestObjectAsync()
        {
            // Snippet: ListAddonsAsync(ListAddonsRequest, CallSettings)
            // Create client
            ApiHubAddonClient apiHubAddonClient = await ApiHubAddonClient.CreateAsync();
            // Initialize request argument(s)
            ListAddonsRequest request = new ListAddonsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListAddonsResponse, Addon> response = apiHubAddonClient.ListAddonsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Addon item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListAddonsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Addon item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Addon> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Addon item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAddons</summary>
        public void ListAddons()
        {
            // Snippet: ListAddons(string, string, int?, CallSettings)
            // Create client
            ApiHubAddonClient apiHubAddonClient = ApiHubAddonClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListAddonsResponse, Addon> response = apiHubAddonClient.ListAddons(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Addon item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAddonsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Addon item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Addon> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Addon item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAddonsAsync</summary>
        public async Task ListAddonsAsync()
        {
            // Snippet: ListAddonsAsync(string, string, int?, CallSettings)
            // Create client
            ApiHubAddonClient apiHubAddonClient = await ApiHubAddonClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListAddonsResponse, Addon> response = apiHubAddonClient.ListAddonsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Addon item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListAddonsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Addon item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Addon> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Addon item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAddons</summary>
        public void ListAddonsResourceNames()
        {
            // Snippet: ListAddons(LocationName, string, int?, CallSettings)
            // Create client
            ApiHubAddonClient apiHubAddonClient = ApiHubAddonClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListAddonsResponse, Addon> response = apiHubAddonClient.ListAddons(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Addon item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAddonsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Addon item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Addon> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Addon item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAddonsAsync</summary>
        public async Task ListAddonsResourceNamesAsync()
        {
            // Snippet: ListAddonsAsync(LocationName, string, int?, CallSettings)
            // Create client
            ApiHubAddonClient apiHubAddonClient = await ApiHubAddonClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListAddonsResponse, Addon> response = apiHubAddonClient.ListAddonsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Addon item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListAddonsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Addon item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Addon> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Addon item in singlePage)
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
