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
    using Google.Cloud.NetworkConnectivity.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedPolicyBasedRoutingServiceClientSnippets
    {
        /// <summary>Snippet for ListPolicyBasedRoutes</summary>
        public void ListPolicyBasedRoutesRequestObject()
        {
            // Snippet: ListPolicyBasedRoutes(ListPolicyBasedRoutesRequest, CallSettings)
            // Create client
            PolicyBasedRoutingServiceClient policyBasedRoutingServiceClient = PolicyBasedRoutingServiceClient.Create();
            // Initialize request argument(s)
            ListPolicyBasedRoutesRequest request = new ListPolicyBasedRoutesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListPolicyBasedRoutesResponse, PolicyBasedRoute> response = policyBasedRoutingServiceClient.ListPolicyBasedRoutes(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PolicyBasedRoute item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPolicyBasedRoutesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PolicyBasedRoute item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PolicyBasedRoute> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PolicyBasedRoute item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPolicyBasedRoutesAsync</summary>
        public async Task ListPolicyBasedRoutesRequestObjectAsync()
        {
            // Snippet: ListPolicyBasedRoutesAsync(ListPolicyBasedRoutesRequest, CallSettings)
            // Create client
            PolicyBasedRoutingServiceClient policyBasedRoutingServiceClient = await PolicyBasedRoutingServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListPolicyBasedRoutesRequest request = new ListPolicyBasedRoutesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListPolicyBasedRoutesResponse, PolicyBasedRoute> response = policyBasedRoutingServiceClient.ListPolicyBasedRoutesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PolicyBasedRoute item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPolicyBasedRoutesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PolicyBasedRoute item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PolicyBasedRoute> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PolicyBasedRoute item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPolicyBasedRoutes</summary>
        public void ListPolicyBasedRoutes()
        {
            // Snippet: ListPolicyBasedRoutes(string, string, int?, CallSettings)
            // Create client
            PolicyBasedRoutingServiceClient policyBasedRoutingServiceClient = PolicyBasedRoutingServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListPolicyBasedRoutesResponse, PolicyBasedRoute> response = policyBasedRoutingServiceClient.ListPolicyBasedRoutes(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PolicyBasedRoute item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPolicyBasedRoutesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PolicyBasedRoute item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PolicyBasedRoute> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PolicyBasedRoute item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPolicyBasedRoutesAsync</summary>
        public async Task ListPolicyBasedRoutesAsync()
        {
            // Snippet: ListPolicyBasedRoutesAsync(string, string, int?, CallSettings)
            // Create client
            PolicyBasedRoutingServiceClient policyBasedRoutingServiceClient = await PolicyBasedRoutingServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListPolicyBasedRoutesResponse, PolicyBasedRoute> response = policyBasedRoutingServiceClient.ListPolicyBasedRoutesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PolicyBasedRoute item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPolicyBasedRoutesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PolicyBasedRoute item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PolicyBasedRoute> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PolicyBasedRoute item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPolicyBasedRoutes</summary>
        public void ListPolicyBasedRoutesResourceNames()
        {
            // Snippet: ListPolicyBasedRoutes(LocationName, string, int?, CallSettings)
            // Create client
            PolicyBasedRoutingServiceClient policyBasedRoutingServiceClient = PolicyBasedRoutingServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListPolicyBasedRoutesResponse, PolicyBasedRoute> response = policyBasedRoutingServiceClient.ListPolicyBasedRoutes(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PolicyBasedRoute item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPolicyBasedRoutesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PolicyBasedRoute item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PolicyBasedRoute> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PolicyBasedRoute item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPolicyBasedRoutesAsync</summary>
        public async Task ListPolicyBasedRoutesResourceNamesAsync()
        {
            // Snippet: ListPolicyBasedRoutesAsync(LocationName, string, int?, CallSettings)
            // Create client
            PolicyBasedRoutingServiceClient policyBasedRoutingServiceClient = await PolicyBasedRoutingServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListPolicyBasedRoutesResponse, PolicyBasedRoute> response = policyBasedRoutingServiceClient.ListPolicyBasedRoutesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PolicyBasedRoute item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPolicyBasedRoutesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PolicyBasedRoute item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PolicyBasedRoute> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PolicyBasedRoute item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetPolicyBasedRoute</summary>
        public void GetPolicyBasedRouteRequestObject()
        {
            // Snippet: GetPolicyBasedRoute(GetPolicyBasedRouteRequest, CallSettings)
            // Create client
            PolicyBasedRoutingServiceClient policyBasedRoutingServiceClient = PolicyBasedRoutingServiceClient.Create();
            // Initialize request argument(s)
            GetPolicyBasedRouteRequest request = new GetPolicyBasedRouteRequest
            {
                PolicyBasedRouteName = PolicyBasedRouteName.FromProjectPolicyBasedRoute("[PROJECT]", "[POLICY_BASED_ROUTE]"),
            };
            // Make the request
            PolicyBasedRoute response = policyBasedRoutingServiceClient.GetPolicyBasedRoute(request);
            // End snippet
        }

        /// <summary>Snippet for GetPolicyBasedRouteAsync</summary>
        public async Task GetPolicyBasedRouteRequestObjectAsync()
        {
            // Snippet: GetPolicyBasedRouteAsync(GetPolicyBasedRouteRequest, CallSettings)
            // Additional: GetPolicyBasedRouteAsync(GetPolicyBasedRouteRequest, CancellationToken)
            // Create client
            PolicyBasedRoutingServiceClient policyBasedRoutingServiceClient = await PolicyBasedRoutingServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetPolicyBasedRouteRequest request = new GetPolicyBasedRouteRequest
            {
                PolicyBasedRouteName = PolicyBasedRouteName.FromProjectPolicyBasedRoute("[PROJECT]", "[POLICY_BASED_ROUTE]"),
            };
            // Make the request
            PolicyBasedRoute response = await policyBasedRoutingServiceClient.GetPolicyBasedRouteAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetPolicyBasedRoute</summary>
        public void GetPolicyBasedRoute()
        {
            // Snippet: GetPolicyBasedRoute(string, CallSettings)
            // Create client
            PolicyBasedRoutingServiceClient policyBasedRoutingServiceClient = PolicyBasedRoutingServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/global/PolicyBasedRoutes/[POLICY_BASED_ROUTE]";
            // Make the request
            PolicyBasedRoute response = policyBasedRoutingServiceClient.GetPolicyBasedRoute(name);
            // End snippet
        }

        /// <summary>Snippet for GetPolicyBasedRouteAsync</summary>
        public async Task GetPolicyBasedRouteAsync()
        {
            // Snippet: GetPolicyBasedRouteAsync(string, CallSettings)
            // Additional: GetPolicyBasedRouteAsync(string, CancellationToken)
            // Create client
            PolicyBasedRoutingServiceClient policyBasedRoutingServiceClient = await PolicyBasedRoutingServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/global/PolicyBasedRoutes/[POLICY_BASED_ROUTE]";
            // Make the request
            PolicyBasedRoute response = await policyBasedRoutingServiceClient.GetPolicyBasedRouteAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetPolicyBasedRoute</summary>
        public void GetPolicyBasedRouteResourceNames()
        {
            // Snippet: GetPolicyBasedRoute(PolicyBasedRouteName, CallSettings)
            // Create client
            PolicyBasedRoutingServiceClient policyBasedRoutingServiceClient = PolicyBasedRoutingServiceClient.Create();
            // Initialize request argument(s)
            PolicyBasedRouteName name = PolicyBasedRouteName.FromProjectPolicyBasedRoute("[PROJECT]", "[POLICY_BASED_ROUTE]");
            // Make the request
            PolicyBasedRoute response = policyBasedRoutingServiceClient.GetPolicyBasedRoute(name);
            // End snippet
        }

        /// <summary>Snippet for GetPolicyBasedRouteAsync</summary>
        public async Task GetPolicyBasedRouteResourceNamesAsync()
        {
            // Snippet: GetPolicyBasedRouteAsync(PolicyBasedRouteName, CallSettings)
            // Additional: GetPolicyBasedRouteAsync(PolicyBasedRouteName, CancellationToken)
            // Create client
            PolicyBasedRoutingServiceClient policyBasedRoutingServiceClient = await PolicyBasedRoutingServiceClient.CreateAsync();
            // Initialize request argument(s)
            PolicyBasedRouteName name = PolicyBasedRouteName.FromProjectPolicyBasedRoute("[PROJECT]", "[POLICY_BASED_ROUTE]");
            // Make the request
            PolicyBasedRoute response = await policyBasedRoutingServiceClient.GetPolicyBasedRouteAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreatePolicyBasedRoute</summary>
        public void CreatePolicyBasedRouteRequestObject()
        {
            // Snippet: CreatePolicyBasedRoute(CreatePolicyBasedRouteRequest, CallSettings)
            // Create client
            PolicyBasedRoutingServiceClient policyBasedRoutingServiceClient = PolicyBasedRoutingServiceClient.Create();
            // Initialize request argument(s)
            CreatePolicyBasedRouteRequest request = new CreatePolicyBasedRouteRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                PolicyBasedRouteId = "",
                PolicyBasedRoute = new PolicyBasedRoute(),
                RequestId = "",
            };
            // Make the request
            Operation<PolicyBasedRoute, OperationMetadata> response = policyBasedRoutingServiceClient.CreatePolicyBasedRoute(request);

            // Poll until the returned long-running operation is complete
            Operation<PolicyBasedRoute, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            PolicyBasedRoute result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PolicyBasedRoute, OperationMetadata> retrievedResponse = policyBasedRoutingServiceClient.PollOnceCreatePolicyBasedRoute(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PolicyBasedRoute retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreatePolicyBasedRouteAsync</summary>
        public async Task CreatePolicyBasedRouteRequestObjectAsync()
        {
            // Snippet: CreatePolicyBasedRouteAsync(CreatePolicyBasedRouteRequest, CallSettings)
            // Additional: CreatePolicyBasedRouteAsync(CreatePolicyBasedRouteRequest, CancellationToken)
            // Create client
            PolicyBasedRoutingServiceClient policyBasedRoutingServiceClient = await PolicyBasedRoutingServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreatePolicyBasedRouteRequest request = new CreatePolicyBasedRouteRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                PolicyBasedRouteId = "",
                PolicyBasedRoute = new PolicyBasedRoute(),
                RequestId = "",
            };
            // Make the request
            Operation<PolicyBasedRoute, OperationMetadata> response = await policyBasedRoutingServiceClient.CreatePolicyBasedRouteAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<PolicyBasedRoute, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            PolicyBasedRoute result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PolicyBasedRoute, OperationMetadata> retrievedResponse = await policyBasedRoutingServiceClient.PollOnceCreatePolicyBasedRouteAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PolicyBasedRoute retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreatePolicyBasedRoute</summary>
        public void CreatePolicyBasedRoute()
        {
            // Snippet: CreatePolicyBasedRoute(string, PolicyBasedRoute, string, CallSettings)
            // Create client
            PolicyBasedRoutingServiceClient policyBasedRoutingServiceClient = PolicyBasedRoutingServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            PolicyBasedRoute policyBasedRoute = new PolicyBasedRoute();
            string policyBasedRouteId = "";
            // Make the request
            Operation<PolicyBasedRoute, OperationMetadata> response = policyBasedRoutingServiceClient.CreatePolicyBasedRoute(parent, policyBasedRoute, policyBasedRouteId);

            // Poll until the returned long-running operation is complete
            Operation<PolicyBasedRoute, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            PolicyBasedRoute result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PolicyBasedRoute, OperationMetadata> retrievedResponse = policyBasedRoutingServiceClient.PollOnceCreatePolicyBasedRoute(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PolicyBasedRoute retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreatePolicyBasedRouteAsync</summary>
        public async Task CreatePolicyBasedRouteAsync()
        {
            // Snippet: CreatePolicyBasedRouteAsync(string, PolicyBasedRoute, string, CallSettings)
            // Additional: CreatePolicyBasedRouteAsync(string, PolicyBasedRoute, string, CancellationToken)
            // Create client
            PolicyBasedRoutingServiceClient policyBasedRoutingServiceClient = await PolicyBasedRoutingServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            PolicyBasedRoute policyBasedRoute = new PolicyBasedRoute();
            string policyBasedRouteId = "";
            // Make the request
            Operation<PolicyBasedRoute, OperationMetadata> response = await policyBasedRoutingServiceClient.CreatePolicyBasedRouteAsync(parent, policyBasedRoute, policyBasedRouteId);

            // Poll until the returned long-running operation is complete
            Operation<PolicyBasedRoute, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            PolicyBasedRoute result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PolicyBasedRoute, OperationMetadata> retrievedResponse = await policyBasedRoutingServiceClient.PollOnceCreatePolicyBasedRouteAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PolicyBasedRoute retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreatePolicyBasedRoute</summary>
        public void CreatePolicyBasedRouteResourceNames()
        {
            // Snippet: CreatePolicyBasedRoute(LocationName, PolicyBasedRoute, string, CallSettings)
            // Create client
            PolicyBasedRoutingServiceClient policyBasedRoutingServiceClient = PolicyBasedRoutingServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            PolicyBasedRoute policyBasedRoute = new PolicyBasedRoute();
            string policyBasedRouteId = "";
            // Make the request
            Operation<PolicyBasedRoute, OperationMetadata> response = policyBasedRoutingServiceClient.CreatePolicyBasedRoute(parent, policyBasedRoute, policyBasedRouteId);

            // Poll until the returned long-running operation is complete
            Operation<PolicyBasedRoute, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            PolicyBasedRoute result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PolicyBasedRoute, OperationMetadata> retrievedResponse = policyBasedRoutingServiceClient.PollOnceCreatePolicyBasedRoute(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PolicyBasedRoute retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreatePolicyBasedRouteAsync</summary>
        public async Task CreatePolicyBasedRouteResourceNamesAsync()
        {
            // Snippet: CreatePolicyBasedRouteAsync(LocationName, PolicyBasedRoute, string, CallSettings)
            // Additional: CreatePolicyBasedRouteAsync(LocationName, PolicyBasedRoute, string, CancellationToken)
            // Create client
            PolicyBasedRoutingServiceClient policyBasedRoutingServiceClient = await PolicyBasedRoutingServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            PolicyBasedRoute policyBasedRoute = new PolicyBasedRoute();
            string policyBasedRouteId = "";
            // Make the request
            Operation<PolicyBasedRoute, OperationMetadata> response = await policyBasedRoutingServiceClient.CreatePolicyBasedRouteAsync(parent, policyBasedRoute, policyBasedRouteId);

            // Poll until the returned long-running operation is complete
            Operation<PolicyBasedRoute, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            PolicyBasedRoute result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PolicyBasedRoute, OperationMetadata> retrievedResponse = await policyBasedRoutingServiceClient.PollOnceCreatePolicyBasedRouteAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PolicyBasedRoute retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeletePolicyBasedRoute</summary>
        public void DeletePolicyBasedRouteRequestObject()
        {
            // Snippet: DeletePolicyBasedRoute(DeletePolicyBasedRouteRequest, CallSettings)
            // Create client
            PolicyBasedRoutingServiceClient policyBasedRoutingServiceClient = PolicyBasedRoutingServiceClient.Create();
            // Initialize request argument(s)
            DeletePolicyBasedRouteRequest request = new DeletePolicyBasedRouteRequest
            {
                PolicyBasedRouteName = PolicyBasedRouteName.FromProjectPolicyBasedRoute("[PROJECT]", "[POLICY_BASED_ROUTE]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = policyBasedRoutingServiceClient.DeletePolicyBasedRoute(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = policyBasedRoutingServiceClient.PollOnceDeletePolicyBasedRoute(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeletePolicyBasedRouteAsync</summary>
        public async Task DeletePolicyBasedRouteRequestObjectAsync()
        {
            // Snippet: DeletePolicyBasedRouteAsync(DeletePolicyBasedRouteRequest, CallSettings)
            // Additional: DeletePolicyBasedRouteAsync(DeletePolicyBasedRouteRequest, CancellationToken)
            // Create client
            PolicyBasedRoutingServiceClient policyBasedRoutingServiceClient = await PolicyBasedRoutingServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeletePolicyBasedRouteRequest request = new DeletePolicyBasedRouteRequest
            {
                PolicyBasedRouteName = PolicyBasedRouteName.FromProjectPolicyBasedRoute("[PROJECT]", "[POLICY_BASED_ROUTE]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await policyBasedRoutingServiceClient.DeletePolicyBasedRouteAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await policyBasedRoutingServiceClient.PollOnceDeletePolicyBasedRouteAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeletePolicyBasedRoute</summary>
        public void DeletePolicyBasedRoute()
        {
            // Snippet: DeletePolicyBasedRoute(string, CallSettings)
            // Create client
            PolicyBasedRoutingServiceClient policyBasedRoutingServiceClient = PolicyBasedRoutingServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/global/PolicyBasedRoutes/[POLICY_BASED_ROUTE]";
            // Make the request
            Operation<Empty, OperationMetadata> response = policyBasedRoutingServiceClient.DeletePolicyBasedRoute(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = policyBasedRoutingServiceClient.PollOnceDeletePolicyBasedRoute(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeletePolicyBasedRouteAsync</summary>
        public async Task DeletePolicyBasedRouteAsync()
        {
            // Snippet: DeletePolicyBasedRouteAsync(string, CallSettings)
            // Additional: DeletePolicyBasedRouteAsync(string, CancellationToken)
            // Create client
            PolicyBasedRoutingServiceClient policyBasedRoutingServiceClient = await PolicyBasedRoutingServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/global/PolicyBasedRoutes/[POLICY_BASED_ROUTE]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await policyBasedRoutingServiceClient.DeletePolicyBasedRouteAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await policyBasedRoutingServiceClient.PollOnceDeletePolicyBasedRouteAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeletePolicyBasedRoute</summary>
        public void DeletePolicyBasedRouteResourceNames()
        {
            // Snippet: DeletePolicyBasedRoute(PolicyBasedRouteName, CallSettings)
            // Create client
            PolicyBasedRoutingServiceClient policyBasedRoutingServiceClient = PolicyBasedRoutingServiceClient.Create();
            // Initialize request argument(s)
            PolicyBasedRouteName name = PolicyBasedRouteName.FromProjectPolicyBasedRoute("[PROJECT]", "[POLICY_BASED_ROUTE]");
            // Make the request
            Operation<Empty, OperationMetadata> response = policyBasedRoutingServiceClient.DeletePolicyBasedRoute(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = policyBasedRoutingServiceClient.PollOnceDeletePolicyBasedRoute(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeletePolicyBasedRouteAsync</summary>
        public async Task DeletePolicyBasedRouteResourceNamesAsync()
        {
            // Snippet: DeletePolicyBasedRouteAsync(PolicyBasedRouteName, CallSettings)
            // Additional: DeletePolicyBasedRouteAsync(PolicyBasedRouteName, CancellationToken)
            // Create client
            PolicyBasedRoutingServiceClient policyBasedRoutingServiceClient = await PolicyBasedRoutingServiceClient.CreateAsync();
            // Initialize request argument(s)
            PolicyBasedRouteName name = PolicyBasedRouteName.FromProjectPolicyBasedRoute("[PROJECT]", "[POLICY_BASED_ROUTE]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await policyBasedRoutingServiceClient.DeletePolicyBasedRouteAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await policyBasedRoutingServiceClient.PollOnceDeletePolicyBasedRouteAsync(operationName);
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
