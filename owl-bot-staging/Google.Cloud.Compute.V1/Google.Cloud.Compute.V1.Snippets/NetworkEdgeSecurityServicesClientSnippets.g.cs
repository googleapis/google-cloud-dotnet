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

#pragma warning disable CS8981

namespace GoogleCSharpSnippets
{
    using Google.Api.Gax;
    using Google.Cloud.Compute.V1;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using lro = Google.LongRunning;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedNetworkEdgeSecurityServicesClientSnippets
    {
        /// <summary>Snippet for AggregatedList</summary>
        public void AggregatedListRequestObject()
        {
            // Snippet: AggregatedList(AggregatedListNetworkEdgeSecurityServicesRequest, CallSettings)
            // Create client
            NetworkEdgeSecurityServicesClient networkEdgeSecurityServicesClient = NetworkEdgeSecurityServicesClient.Create();
            // Initialize request argument(s)
            AggregatedListNetworkEdgeSecurityServicesRequest request = new AggregatedListNetworkEdgeSecurityServicesRequest
            {
                OrderBy = "",
                Project = "",
                ServiceProjectNumber = 0L,
                Filter = "",
                IncludeAllScopes = false,
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<NetworkEdgeSecurityServiceAggregatedList, KeyValuePair<string, NetworkEdgeSecurityServicesScopedList>> response = networkEdgeSecurityServicesClient.AggregatedList(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (KeyValuePair<string, NetworkEdgeSecurityServicesScopedList> item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (NetworkEdgeSecurityServiceAggregatedList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, NetworkEdgeSecurityServicesScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, NetworkEdgeSecurityServicesScopedList>> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, NetworkEdgeSecurityServicesScopedList> item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for AggregatedListAsync</summary>
        public async Task AggregatedListRequestObjectAsync()
        {
            // Snippet: AggregatedListAsync(AggregatedListNetworkEdgeSecurityServicesRequest, CallSettings)
            // Create client
            NetworkEdgeSecurityServicesClient networkEdgeSecurityServicesClient = await NetworkEdgeSecurityServicesClient.CreateAsync();
            // Initialize request argument(s)
            AggregatedListNetworkEdgeSecurityServicesRequest request = new AggregatedListNetworkEdgeSecurityServicesRequest
            {
                OrderBy = "",
                Project = "",
                ServiceProjectNumber = 0L,
                Filter = "",
                IncludeAllScopes = false,
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<NetworkEdgeSecurityServiceAggregatedList, KeyValuePair<string, NetworkEdgeSecurityServicesScopedList>> response = networkEdgeSecurityServicesClient.AggregatedListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((KeyValuePair<string, NetworkEdgeSecurityServicesScopedList> item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((NetworkEdgeSecurityServiceAggregatedList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, NetworkEdgeSecurityServicesScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, NetworkEdgeSecurityServicesScopedList>> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, NetworkEdgeSecurityServicesScopedList> item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for AggregatedList</summary>
        public void AggregatedList()
        {
            // Snippet: AggregatedList(string, string, int?, CallSettings)
            // Create client
            NetworkEdgeSecurityServicesClient networkEdgeSecurityServicesClient = NetworkEdgeSecurityServicesClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedEnumerable<NetworkEdgeSecurityServiceAggregatedList, KeyValuePair<string, NetworkEdgeSecurityServicesScopedList>> response = networkEdgeSecurityServicesClient.AggregatedList(project);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (KeyValuePair<string, NetworkEdgeSecurityServicesScopedList> item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (NetworkEdgeSecurityServiceAggregatedList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, NetworkEdgeSecurityServicesScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, NetworkEdgeSecurityServicesScopedList>> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, NetworkEdgeSecurityServicesScopedList> item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for AggregatedListAsync</summary>
        public async Task AggregatedListAsync()
        {
            // Snippet: AggregatedListAsync(string, string, int?, CallSettings)
            // Create client
            NetworkEdgeSecurityServicesClient networkEdgeSecurityServicesClient = await NetworkEdgeSecurityServicesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedAsyncEnumerable<NetworkEdgeSecurityServiceAggregatedList, KeyValuePair<string, NetworkEdgeSecurityServicesScopedList>> response = networkEdgeSecurityServicesClient.AggregatedListAsync(project);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((KeyValuePair<string, NetworkEdgeSecurityServicesScopedList> item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((NetworkEdgeSecurityServiceAggregatedList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, NetworkEdgeSecurityServicesScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, NetworkEdgeSecurityServicesScopedList>> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, NetworkEdgeSecurityServicesScopedList> item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for Delete</summary>
        public void DeleteRequestObject()
        {
            // Snippet: Delete(DeleteNetworkEdgeSecurityServiceRequest, CallSettings)
            // Create client
            NetworkEdgeSecurityServicesClient networkEdgeSecurityServicesClient = NetworkEdgeSecurityServicesClient.Create();
            // Initialize request argument(s)
            DeleteNetworkEdgeSecurityServiceRequest request = new DeleteNetworkEdgeSecurityServiceRequest
            {
                RequestId = "",
                Region = "",
                NetworkEdgeSecurityService = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = networkEdgeSecurityServicesClient.Delete(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = networkEdgeSecurityServicesClient.PollOnceDelete(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAsync</summary>
        public async Task DeleteRequestObjectAsync()
        {
            // Snippet: DeleteAsync(DeleteNetworkEdgeSecurityServiceRequest, CallSettings)
            // Additional: DeleteAsync(DeleteNetworkEdgeSecurityServiceRequest, CancellationToken)
            // Create client
            NetworkEdgeSecurityServicesClient networkEdgeSecurityServicesClient = await NetworkEdgeSecurityServicesClient.CreateAsync();
            // Initialize request argument(s)
            DeleteNetworkEdgeSecurityServiceRequest request = new DeleteNetworkEdgeSecurityServiceRequest
            {
                RequestId = "",
                Region = "",
                NetworkEdgeSecurityService = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await networkEdgeSecurityServicesClient.DeleteAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await networkEdgeSecurityServicesClient.PollOnceDeleteAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for Delete</summary>
        public void Delete()
        {
            // Snippet: Delete(string, string, string, CallSettings)
            // Create client
            NetworkEdgeSecurityServicesClient networkEdgeSecurityServicesClient = NetworkEdgeSecurityServicesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string networkEdgeSecurityService = "";
            // Make the request
            lro::Operation<Operation, Operation> response = networkEdgeSecurityServicesClient.Delete(project, region, networkEdgeSecurityService);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = networkEdgeSecurityServicesClient.PollOnceDelete(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAsync</summary>
        public async Task DeleteAsync()
        {
            // Snippet: DeleteAsync(string, string, string, CallSettings)
            // Additional: DeleteAsync(string, string, string, CancellationToken)
            // Create client
            NetworkEdgeSecurityServicesClient networkEdgeSecurityServicesClient = await NetworkEdgeSecurityServicesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string networkEdgeSecurityService = "";
            // Make the request
            lro::Operation<Operation, Operation> response = await networkEdgeSecurityServicesClient.DeleteAsync(project, region, networkEdgeSecurityService);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await networkEdgeSecurityServicesClient.PollOnceDeleteAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void GetRequestObject()
        {
            // Snippet: Get(GetNetworkEdgeSecurityServiceRequest, CallSettings)
            // Create client
            NetworkEdgeSecurityServicesClient networkEdgeSecurityServicesClient = NetworkEdgeSecurityServicesClient.Create();
            // Initialize request argument(s)
            GetNetworkEdgeSecurityServiceRequest request = new GetNetworkEdgeSecurityServiceRequest
            {
                Region = "",
                NetworkEdgeSecurityService = "",
                Project = "",
            };
            // Make the request
            NetworkEdgeSecurityService response = networkEdgeSecurityServicesClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetNetworkEdgeSecurityServiceRequest, CallSettings)
            // Additional: GetAsync(GetNetworkEdgeSecurityServiceRequest, CancellationToken)
            // Create client
            NetworkEdgeSecurityServicesClient networkEdgeSecurityServicesClient = await NetworkEdgeSecurityServicesClient.CreateAsync();
            // Initialize request argument(s)
            GetNetworkEdgeSecurityServiceRequest request = new GetNetworkEdgeSecurityServiceRequest
            {
                Region = "",
                NetworkEdgeSecurityService = "",
                Project = "",
            };
            // Make the request
            NetworkEdgeSecurityService response = await networkEdgeSecurityServicesClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, string, CallSettings)
            // Create client
            NetworkEdgeSecurityServicesClient networkEdgeSecurityServicesClient = NetworkEdgeSecurityServicesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string networkEdgeSecurityService = "";
            // Make the request
            NetworkEdgeSecurityService response = networkEdgeSecurityServicesClient.Get(project, region, networkEdgeSecurityService);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, string, CallSettings)
            // Additional: GetAsync(string, string, string, CancellationToken)
            // Create client
            NetworkEdgeSecurityServicesClient networkEdgeSecurityServicesClient = await NetworkEdgeSecurityServicesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string networkEdgeSecurityService = "";
            // Make the request
            NetworkEdgeSecurityService response = await networkEdgeSecurityServicesClient.GetAsync(project, region, networkEdgeSecurityService);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void InsertRequestObject()
        {
            // Snippet: Insert(InsertNetworkEdgeSecurityServiceRequest, CallSettings)
            // Create client
            NetworkEdgeSecurityServicesClient networkEdgeSecurityServicesClient = NetworkEdgeSecurityServicesClient.Create();
            // Initialize request argument(s)
            InsertNetworkEdgeSecurityServiceRequest request = new InsertNetworkEdgeSecurityServiceRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                ValidateOnly = false,
                NetworkEdgeSecurityServiceResource = new NetworkEdgeSecurityService(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = networkEdgeSecurityServicesClient.Insert(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = networkEdgeSecurityServicesClient.PollOnceInsert(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for InsertAsync</summary>
        public async Task InsertRequestObjectAsync()
        {
            // Snippet: InsertAsync(InsertNetworkEdgeSecurityServiceRequest, CallSettings)
            // Additional: InsertAsync(InsertNetworkEdgeSecurityServiceRequest, CancellationToken)
            // Create client
            NetworkEdgeSecurityServicesClient networkEdgeSecurityServicesClient = await NetworkEdgeSecurityServicesClient.CreateAsync();
            // Initialize request argument(s)
            InsertNetworkEdgeSecurityServiceRequest request = new InsertNetworkEdgeSecurityServiceRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                ValidateOnly = false,
                NetworkEdgeSecurityServiceResource = new NetworkEdgeSecurityService(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await networkEdgeSecurityServicesClient.InsertAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await networkEdgeSecurityServicesClient.PollOnceInsertAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void Insert()
        {
            // Snippet: Insert(string, string, NetworkEdgeSecurityService, CallSettings)
            // Create client
            NetworkEdgeSecurityServicesClient networkEdgeSecurityServicesClient = NetworkEdgeSecurityServicesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            NetworkEdgeSecurityService networkEdgeSecurityServiceResource = new NetworkEdgeSecurityService();
            // Make the request
            lro::Operation<Operation, Operation> response = networkEdgeSecurityServicesClient.Insert(project, region, networkEdgeSecurityServiceResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = networkEdgeSecurityServicesClient.PollOnceInsert(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for InsertAsync</summary>
        public async Task InsertAsync()
        {
            // Snippet: InsertAsync(string, string, NetworkEdgeSecurityService, CallSettings)
            // Additional: InsertAsync(string, string, NetworkEdgeSecurityService, CancellationToken)
            // Create client
            NetworkEdgeSecurityServicesClient networkEdgeSecurityServicesClient = await NetworkEdgeSecurityServicesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            NetworkEdgeSecurityService networkEdgeSecurityServiceResource = new NetworkEdgeSecurityService();
            // Make the request
            lro::Operation<Operation, Operation> response = await networkEdgeSecurityServicesClient.InsertAsync(project, region, networkEdgeSecurityServiceResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await networkEdgeSecurityServicesClient.PollOnceInsertAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for Patch</summary>
        public void PatchRequestObject()
        {
            // Snippet: Patch(PatchNetworkEdgeSecurityServiceRequest, CallSettings)
            // Create client
            NetworkEdgeSecurityServicesClient networkEdgeSecurityServicesClient = NetworkEdgeSecurityServicesClient.Create();
            // Initialize request argument(s)
            PatchNetworkEdgeSecurityServiceRequest request = new PatchNetworkEdgeSecurityServiceRequest
            {
                RequestId = "",
                Paths = "",
                Region = "",
                NetworkEdgeSecurityService = "",
                Project = "",
                NetworkEdgeSecurityServiceResource = new NetworkEdgeSecurityService(),
                UpdateMask = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = networkEdgeSecurityServicesClient.Patch(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = networkEdgeSecurityServicesClient.PollOncePatch(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PatchAsync</summary>
        public async Task PatchRequestObjectAsync()
        {
            // Snippet: PatchAsync(PatchNetworkEdgeSecurityServiceRequest, CallSettings)
            // Additional: PatchAsync(PatchNetworkEdgeSecurityServiceRequest, CancellationToken)
            // Create client
            NetworkEdgeSecurityServicesClient networkEdgeSecurityServicesClient = await NetworkEdgeSecurityServicesClient.CreateAsync();
            // Initialize request argument(s)
            PatchNetworkEdgeSecurityServiceRequest request = new PatchNetworkEdgeSecurityServiceRequest
            {
                RequestId = "",
                Paths = "",
                Region = "",
                NetworkEdgeSecurityService = "",
                Project = "",
                NetworkEdgeSecurityServiceResource = new NetworkEdgeSecurityService(),
                UpdateMask = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await networkEdgeSecurityServicesClient.PatchAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await networkEdgeSecurityServicesClient.PollOncePatchAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for Patch</summary>
        public void Patch()
        {
            // Snippet: Patch(string, string, string, NetworkEdgeSecurityService, CallSettings)
            // Create client
            NetworkEdgeSecurityServicesClient networkEdgeSecurityServicesClient = NetworkEdgeSecurityServicesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string networkEdgeSecurityService = "";
            NetworkEdgeSecurityService networkEdgeSecurityServiceResource = new NetworkEdgeSecurityService();
            // Make the request
            lro::Operation<Operation, Operation> response = networkEdgeSecurityServicesClient.Patch(project, region, networkEdgeSecurityService, networkEdgeSecurityServiceResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = networkEdgeSecurityServicesClient.PollOncePatch(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PatchAsync</summary>
        public async Task PatchAsync()
        {
            // Snippet: PatchAsync(string, string, string, NetworkEdgeSecurityService, CallSettings)
            // Additional: PatchAsync(string, string, string, NetworkEdgeSecurityService, CancellationToken)
            // Create client
            NetworkEdgeSecurityServicesClient networkEdgeSecurityServicesClient = await NetworkEdgeSecurityServicesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string networkEdgeSecurityService = "";
            NetworkEdgeSecurityService networkEdgeSecurityServiceResource = new NetworkEdgeSecurityService();
            // Make the request
            lro::Operation<Operation, Operation> response = await networkEdgeSecurityServicesClient.PatchAsync(project, region, networkEdgeSecurityService, networkEdgeSecurityServiceResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await networkEdgeSecurityServicesClient.PollOncePatchAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
