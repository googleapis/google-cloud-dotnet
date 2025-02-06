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
    using Google.Cloud.NetworkSecurity.V1Beta1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedNetworkSecurityClientSnippets
    {
        /// <summary>Snippet for ListAuthorizationPolicies</summary>
        public void ListAuthorizationPoliciesRequestObject()
        {
            // Snippet: ListAuthorizationPolicies(ListAuthorizationPoliciesRequest, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            ListAuthorizationPoliciesRequest request = new ListAuthorizationPoliciesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedEnumerable<ListAuthorizationPoliciesResponse, AuthorizationPolicy> response = networkSecurityClient.ListAuthorizationPolicies(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AuthorizationPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAuthorizationPoliciesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AuthorizationPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AuthorizationPolicy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AuthorizationPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAuthorizationPoliciesAsync</summary>
        public async Task ListAuthorizationPoliciesRequestObjectAsync()
        {
            // Snippet: ListAuthorizationPoliciesAsync(ListAuthorizationPoliciesRequest, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            ListAuthorizationPoliciesRequest request = new ListAuthorizationPoliciesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListAuthorizationPoliciesResponse, AuthorizationPolicy> response = networkSecurityClient.ListAuthorizationPoliciesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AuthorizationPolicy item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAuthorizationPoliciesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AuthorizationPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AuthorizationPolicy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AuthorizationPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAuthorizationPolicies</summary>
        public void ListAuthorizationPolicies()
        {
            // Snippet: ListAuthorizationPolicies(string, string, int?, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListAuthorizationPoliciesResponse, AuthorizationPolicy> response = networkSecurityClient.ListAuthorizationPolicies(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AuthorizationPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAuthorizationPoliciesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AuthorizationPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AuthorizationPolicy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AuthorizationPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAuthorizationPoliciesAsync</summary>
        public async Task ListAuthorizationPoliciesAsync()
        {
            // Snippet: ListAuthorizationPoliciesAsync(string, string, int?, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListAuthorizationPoliciesResponse, AuthorizationPolicy> response = networkSecurityClient.ListAuthorizationPoliciesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AuthorizationPolicy item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAuthorizationPoliciesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AuthorizationPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AuthorizationPolicy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AuthorizationPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAuthorizationPolicies</summary>
        public void ListAuthorizationPoliciesResourceNames()
        {
            // Snippet: ListAuthorizationPolicies(LocationName, string, int?, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListAuthorizationPoliciesResponse, AuthorizationPolicy> response = networkSecurityClient.ListAuthorizationPolicies(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AuthorizationPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAuthorizationPoliciesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AuthorizationPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AuthorizationPolicy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AuthorizationPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAuthorizationPoliciesAsync</summary>
        public async Task ListAuthorizationPoliciesResourceNamesAsync()
        {
            // Snippet: ListAuthorizationPoliciesAsync(LocationName, string, int?, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListAuthorizationPoliciesResponse, AuthorizationPolicy> response = networkSecurityClient.ListAuthorizationPoliciesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AuthorizationPolicy item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAuthorizationPoliciesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AuthorizationPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AuthorizationPolicy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AuthorizationPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetAuthorizationPolicy</summary>
        public void GetAuthorizationPolicyRequestObject()
        {
            // Snippet: GetAuthorizationPolicy(GetAuthorizationPolicyRequest, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            GetAuthorizationPolicyRequest request = new GetAuthorizationPolicyRequest
            {
                AuthorizationPolicyName = AuthorizationPolicyName.FromProjectLocationAuthorizationPolicy("[PROJECT]", "[LOCATION]", "[AUTHORIZATION_POLICY]"),
            };
            // Make the request
            AuthorizationPolicy response = networkSecurityClient.GetAuthorizationPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for GetAuthorizationPolicyAsync</summary>
        public async Task GetAuthorizationPolicyRequestObjectAsync()
        {
            // Snippet: GetAuthorizationPolicyAsync(GetAuthorizationPolicyRequest, CallSettings)
            // Additional: GetAuthorizationPolicyAsync(GetAuthorizationPolicyRequest, CancellationToken)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            GetAuthorizationPolicyRequest request = new GetAuthorizationPolicyRequest
            {
                AuthorizationPolicyName = AuthorizationPolicyName.FromProjectLocationAuthorizationPolicy("[PROJECT]", "[LOCATION]", "[AUTHORIZATION_POLICY]"),
            };
            // Make the request
            AuthorizationPolicy response = await networkSecurityClient.GetAuthorizationPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAuthorizationPolicy</summary>
        public void GetAuthorizationPolicy()
        {
            // Snippet: GetAuthorizationPolicy(string, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/authorizationPolicies/[AUTHORIZATION_POLICY]";
            // Make the request
            AuthorizationPolicy response = networkSecurityClient.GetAuthorizationPolicy(name);
            // End snippet
        }

        /// <summary>Snippet for GetAuthorizationPolicyAsync</summary>
        public async Task GetAuthorizationPolicyAsync()
        {
            // Snippet: GetAuthorizationPolicyAsync(string, CallSettings)
            // Additional: GetAuthorizationPolicyAsync(string, CancellationToken)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/authorizationPolicies/[AUTHORIZATION_POLICY]";
            // Make the request
            AuthorizationPolicy response = await networkSecurityClient.GetAuthorizationPolicyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetAuthorizationPolicy</summary>
        public void GetAuthorizationPolicyResourceNames()
        {
            // Snippet: GetAuthorizationPolicy(AuthorizationPolicyName, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            AuthorizationPolicyName name = AuthorizationPolicyName.FromProjectLocationAuthorizationPolicy("[PROJECT]", "[LOCATION]", "[AUTHORIZATION_POLICY]");
            // Make the request
            AuthorizationPolicy response = networkSecurityClient.GetAuthorizationPolicy(name);
            // End snippet
        }

        /// <summary>Snippet for GetAuthorizationPolicyAsync</summary>
        public async Task GetAuthorizationPolicyResourceNamesAsync()
        {
            // Snippet: GetAuthorizationPolicyAsync(AuthorizationPolicyName, CallSettings)
            // Additional: GetAuthorizationPolicyAsync(AuthorizationPolicyName, CancellationToken)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            AuthorizationPolicyName name = AuthorizationPolicyName.FromProjectLocationAuthorizationPolicy("[PROJECT]", "[LOCATION]", "[AUTHORIZATION_POLICY]");
            // Make the request
            AuthorizationPolicy response = await networkSecurityClient.GetAuthorizationPolicyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateAuthorizationPolicy</summary>
        public void CreateAuthorizationPolicyRequestObject()
        {
            // Snippet: CreateAuthorizationPolicy(CreateAuthorizationPolicyRequest, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            CreateAuthorizationPolicyRequest request = new CreateAuthorizationPolicyRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                AuthorizationPolicyId = "",
                AuthorizationPolicy = new AuthorizationPolicy(),
            };
            // Make the request
            Operation<AuthorizationPolicy, OperationMetadata> response = networkSecurityClient.CreateAuthorizationPolicy(request);

            // Poll until the returned long-running operation is complete
            Operation<AuthorizationPolicy, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AuthorizationPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AuthorizationPolicy, OperationMetadata> retrievedResponse = networkSecurityClient.PollOnceCreateAuthorizationPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AuthorizationPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAuthorizationPolicyAsync</summary>
        public async Task CreateAuthorizationPolicyRequestObjectAsync()
        {
            // Snippet: CreateAuthorizationPolicyAsync(CreateAuthorizationPolicyRequest, CallSettings)
            // Additional: CreateAuthorizationPolicyAsync(CreateAuthorizationPolicyRequest, CancellationToken)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            CreateAuthorizationPolicyRequest request = new CreateAuthorizationPolicyRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                AuthorizationPolicyId = "",
                AuthorizationPolicy = new AuthorizationPolicy(),
            };
            // Make the request
            Operation<AuthorizationPolicy, OperationMetadata> response = await networkSecurityClient.CreateAuthorizationPolicyAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<AuthorizationPolicy, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AuthorizationPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AuthorizationPolicy, OperationMetadata> retrievedResponse = await networkSecurityClient.PollOnceCreateAuthorizationPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AuthorizationPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAuthorizationPolicy</summary>
        public void CreateAuthorizationPolicy()
        {
            // Snippet: CreateAuthorizationPolicy(string, AuthorizationPolicy, string, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            AuthorizationPolicy authorizationPolicy = new AuthorizationPolicy();
            string authorizationPolicyId = "";
            // Make the request
            Operation<AuthorizationPolicy, OperationMetadata> response = networkSecurityClient.CreateAuthorizationPolicy(parent, authorizationPolicy, authorizationPolicyId);

            // Poll until the returned long-running operation is complete
            Operation<AuthorizationPolicy, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AuthorizationPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AuthorizationPolicy, OperationMetadata> retrievedResponse = networkSecurityClient.PollOnceCreateAuthorizationPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AuthorizationPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAuthorizationPolicyAsync</summary>
        public async Task CreateAuthorizationPolicyAsync()
        {
            // Snippet: CreateAuthorizationPolicyAsync(string, AuthorizationPolicy, string, CallSettings)
            // Additional: CreateAuthorizationPolicyAsync(string, AuthorizationPolicy, string, CancellationToken)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            AuthorizationPolicy authorizationPolicy = new AuthorizationPolicy();
            string authorizationPolicyId = "";
            // Make the request
            Operation<AuthorizationPolicy, OperationMetadata> response = await networkSecurityClient.CreateAuthorizationPolicyAsync(parent, authorizationPolicy, authorizationPolicyId);

            // Poll until the returned long-running operation is complete
            Operation<AuthorizationPolicy, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AuthorizationPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AuthorizationPolicy, OperationMetadata> retrievedResponse = await networkSecurityClient.PollOnceCreateAuthorizationPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AuthorizationPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAuthorizationPolicy</summary>
        public void CreateAuthorizationPolicyResourceNames()
        {
            // Snippet: CreateAuthorizationPolicy(LocationName, AuthorizationPolicy, string, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            AuthorizationPolicy authorizationPolicy = new AuthorizationPolicy();
            string authorizationPolicyId = "";
            // Make the request
            Operation<AuthorizationPolicy, OperationMetadata> response = networkSecurityClient.CreateAuthorizationPolicy(parent, authorizationPolicy, authorizationPolicyId);

            // Poll until the returned long-running operation is complete
            Operation<AuthorizationPolicy, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AuthorizationPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AuthorizationPolicy, OperationMetadata> retrievedResponse = networkSecurityClient.PollOnceCreateAuthorizationPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AuthorizationPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAuthorizationPolicyAsync</summary>
        public async Task CreateAuthorizationPolicyResourceNamesAsync()
        {
            // Snippet: CreateAuthorizationPolicyAsync(LocationName, AuthorizationPolicy, string, CallSettings)
            // Additional: CreateAuthorizationPolicyAsync(LocationName, AuthorizationPolicy, string, CancellationToken)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            AuthorizationPolicy authorizationPolicy = new AuthorizationPolicy();
            string authorizationPolicyId = "";
            // Make the request
            Operation<AuthorizationPolicy, OperationMetadata> response = await networkSecurityClient.CreateAuthorizationPolicyAsync(parent, authorizationPolicy, authorizationPolicyId);

            // Poll until the returned long-running operation is complete
            Operation<AuthorizationPolicy, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AuthorizationPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AuthorizationPolicy, OperationMetadata> retrievedResponse = await networkSecurityClient.PollOnceCreateAuthorizationPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AuthorizationPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateAuthorizationPolicy</summary>
        public void UpdateAuthorizationPolicyRequestObject()
        {
            // Snippet: UpdateAuthorizationPolicy(UpdateAuthorizationPolicyRequest, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            UpdateAuthorizationPolicyRequest request = new UpdateAuthorizationPolicyRequest
            {
                UpdateMask = new FieldMask(),
                AuthorizationPolicy = new AuthorizationPolicy(),
            };
            // Make the request
            Operation<AuthorizationPolicy, OperationMetadata> response = networkSecurityClient.UpdateAuthorizationPolicy(request);

            // Poll until the returned long-running operation is complete
            Operation<AuthorizationPolicy, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AuthorizationPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AuthorizationPolicy, OperationMetadata> retrievedResponse = networkSecurityClient.PollOnceUpdateAuthorizationPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AuthorizationPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateAuthorizationPolicyAsync</summary>
        public async Task UpdateAuthorizationPolicyRequestObjectAsync()
        {
            // Snippet: UpdateAuthorizationPolicyAsync(UpdateAuthorizationPolicyRequest, CallSettings)
            // Additional: UpdateAuthorizationPolicyAsync(UpdateAuthorizationPolicyRequest, CancellationToken)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            UpdateAuthorizationPolicyRequest request = new UpdateAuthorizationPolicyRequest
            {
                UpdateMask = new FieldMask(),
                AuthorizationPolicy = new AuthorizationPolicy(),
            };
            // Make the request
            Operation<AuthorizationPolicy, OperationMetadata> response = await networkSecurityClient.UpdateAuthorizationPolicyAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<AuthorizationPolicy, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AuthorizationPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AuthorizationPolicy, OperationMetadata> retrievedResponse = await networkSecurityClient.PollOnceUpdateAuthorizationPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AuthorizationPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateAuthorizationPolicy</summary>
        public void UpdateAuthorizationPolicy()
        {
            // Snippet: UpdateAuthorizationPolicy(AuthorizationPolicy, FieldMask, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            AuthorizationPolicy authorizationPolicy = new AuthorizationPolicy();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<AuthorizationPolicy, OperationMetadata> response = networkSecurityClient.UpdateAuthorizationPolicy(authorizationPolicy, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<AuthorizationPolicy, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AuthorizationPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AuthorizationPolicy, OperationMetadata> retrievedResponse = networkSecurityClient.PollOnceUpdateAuthorizationPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AuthorizationPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateAuthorizationPolicyAsync</summary>
        public async Task UpdateAuthorizationPolicyAsync()
        {
            // Snippet: UpdateAuthorizationPolicyAsync(AuthorizationPolicy, FieldMask, CallSettings)
            // Additional: UpdateAuthorizationPolicyAsync(AuthorizationPolicy, FieldMask, CancellationToken)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            AuthorizationPolicy authorizationPolicy = new AuthorizationPolicy();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<AuthorizationPolicy, OperationMetadata> response = await networkSecurityClient.UpdateAuthorizationPolicyAsync(authorizationPolicy, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<AuthorizationPolicy, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AuthorizationPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AuthorizationPolicy, OperationMetadata> retrievedResponse = await networkSecurityClient.PollOnceUpdateAuthorizationPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AuthorizationPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAuthorizationPolicy</summary>
        public void DeleteAuthorizationPolicyRequestObject()
        {
            // Snippet: DeleteAuthorizationPolicy(DeleteAuthorizationPolicyRequest, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            DeleteAuthorizationPolicyRequest request = new DeleteAuthorizationPolicyRequest
            {
                AuthorizationPolicyName = AuthorizationPolicyName.FromProjectLocationAuthorizationPolicy("[PROJECT]", "[LOCATION]", "[AUTHORIZATION_POLICY]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = networkSecurityClient.DeleteAuthorizationPolicy(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = networkSecurityClient.PollOnceDeleteAuthorizationPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAuthorizationPolicyAsync</summary>
        public async Task DeleteAuthorizationPolicyRequestObjectAsync()
        {
            // Snippet: DeleteAuthorizationPolicyAsync(DeleteAuthorizationPolicyRequest, CallSettings)
            // Additional: DeleteAuthorizationPolicyAsync(DeleteAuthorizationPolicyRequest, CancellationToken)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            DeleteAuthorizationPolicyRequest request = new DeleteAuthorizationPolicyRequest
            {
                AuthorizationPolicyName = AuthorizationPolicyName.FromProjectLocationAuthorizationPolicy("[PROJECT]", "[LOCATION]", "[AUTHORIZATION_POLICY]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await networkSecurityClient.DeleteAuthorizationPolicyAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await networkSecurityClient.PollOnceDeleteAuthorizationPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAuthorizationPolicy</summary>
        public void DeleteAuthorizationPolicy()
        {
            // Snippet: DeleteAuthorizationPolicy(string, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/authorizationPolicies/[AUTHORIZATION_POLICY]";
            // Make the request
            Operation<Empty, OperationMetadata> response = networkSecurityClient.DeleteAuthorizationPolicy(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = networkSecurityClient.PollOnceDeleteAuthorizationPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAuthorizationPolicyAsync</summary>
        public async Task DeleteAuthorizationPolicyAsync()
        {
            // Snippet: DeleteAuthorizationPolicyAsync(string, CallSettings)
            // Additional: DeleteAuthorizationPolicyAsync(string, CancellationToken)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/authorizationPolicies/[AUTHORIZATION_POLICY]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await networkSecurityClient.DeleteAuthorizationPolicyAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await networkSecurityClient.PollOnceDeleteAuthorizationPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAuthorizationPolicy</summary>
        public void DeleteAuthorizationPolicyResourceNames()
        {
            // Snippet: DeleteAuthorizationPolicy(AuthorizationPolicyName, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            AuthorizationPolicyName name = AuthorizationPolicyName.FromProjectLocationAuthorizationPolicy("[PROJECT]", "[LOCATION]", "[AUTHORIZATION_POLICY]");
            // Make the request
            Operation<Empty, OperationMetadata> response = networkSecurityClient.DeleteAuthorizationPolicy(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = networkSecurityClient.PollOnceDeleteAuthorizationPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAuthorizationPolicyAsync</summary>
        public async Task DeleteAuthorizationPolicyResourceNamesAsync()
        {
            // Snippet: DeleteAuthorizationPolicyAsync(AuthorizationPolicyName, CallSettings)
            // Additional: DeleteAuthorizationPolicyAsync(AuthorizationPolicyName, CancellationToken)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            AuthorizationPolicyName name = AuthorizationPolicyName.FromProjectLocationAuthorizationPolicy("[PROJECT]", "[LOCATION]", "[AUTHORIZATION_POLICY]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await networkSecurityClient.DeleteAuthorizationPolicyAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await networkSecurityClient.PollOnceDeleteAuthorizationPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListServerTlsPolicies</summary>
        public void ListServerTlsPoliciesRequestObject()
        {
            // Snippet: ListServerTlsPolicies(ListServerTlsPoliciesRequest, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            ListServerTlsPoliciesRequest request = new ListServerTlsPoliciesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedEnumerable<ListServerTlsPoliciesResponse, ServerTlsPolicy> response = networkSecurityClient.ListServerTlsPolicies(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ServerTlsPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListServerTlsPoliciesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ServerTlsPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ServerTlsPolicy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ServerTlsPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListServerTlsPoliciesAsync</summary>
        public async Task ListServerTlsPoliciesRequestObjectAsync()
        {
            // Snippet: ListServerTlsPoliciesAsync(ListServerTlsPoliciesRequest, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            ListServerTlsPoliciesRequest request = new ListServerTlsPoliciesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListServerTlsPoliciesResponse, ServerTlsPolicy> response = networkSecurityClient.ListServerTlsPoliciesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ServerTlsPolicy item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListServerTlsPoliciesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ServerTlsPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ServerTlsPolicy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ServerTlsPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListServerTlsPolicies</summary>
        public void ListServerTlsPolicies()
        {
            // Snippet: ListServerTlsPolicies(string, string, int?, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListServerTlsPoliciesResponse, ServerTlsPolicy> response = networkSecurityClient.ListServerTlsPolicies(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ServerTlsPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListServerTlsPoliciesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ServerTlsPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ServerTlsPolicy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ServerTlsPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListServerTlsPoliciesAsync</summary>
        public async Task ListServerTlsPoliciesAsync()
        {
            // Snippet: ListServerTlsPoliciesAsync(string, string, int?, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListServerTlsPoliciesResponse, ServerTlsPolicy> response = networkSecurityClient.ListServerTlsPoliciesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ServerTlsPolicy item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListServerTlsPoliciesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ServerTlsPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ServerTlsPolicy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ServerTlsPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListServerTlsPolicies</summary>
        public void ListServerTlsPoliciesResourceNames()
        {
            // Snippet: ListServerTlsPolicies(LocationName, string, int?, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListServerTlsPoliciesResponse, ServerTlsPolicy> response = networkSecurityClient.ListServerTlsPolicies(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ServerTlsPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListServerTlsPoliciesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ServerTlsPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ServerTlsPolicy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ServerTlsPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListServerTlsPoliciesAsync</summary>
        public async Task ListServerTlsPoliciesResourceNamesAsync()
        {
            // Snippet: ListServerTlsPoliciesAsync(LocationName, string, int?, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListServerTlsPoliciesResponse, ServerTlsPolicy> response = networkSecurityClient.ListServerTlsPoliciesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ServerTlsPolicy item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListServerTlsPoliciesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ServerTlsPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ServerTlsPolicy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ServerTlsPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetServerTlsPolicy</summary>
        public void GetServerTlsPolicyRequestObject()
        {
            // Snippet: GetServerTlsPolicy(GetServerTlsPolicyRequest, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            GetServerTlsPolicyRequest request = new GetServerTlsPolicyRequest
            {
                ServerTlsPolicyName = ServerTlsPolicyName.FromProjectLocationServerTlsPolicy("[PROJECT]", "[LOCATION]", "[SERVER_TLS_POLICY]"),
            };
            // Make the request
            ServerTlsPolicy response = networkSecurityClient.GetServerTlsPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for GetServerTlsPolicyAsync</summary>
        public async Task GetServerTlsPolicyRequestObjectAsync()
        {
            // Snippet: GetServerTlsPolicyAsync(GetServerTlsPolicyRequest, CallSettings)
            // Additional: GetServerTlsPolicyAsync(GetServerTlsPolicyRequest, CancellationToken)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            GetServerTlsPolicyRequest request = new GetServerTlsPolicyRequest
            {
                ServerTlsPolicyName = ServerTlsPolicyName.FromProjectLocationServerTlsPolicy("[PROJECT]", "[LOCATION]", "[SERVER_TLS_POLICY]"),
            };
            // Make the request
            ServerTlsPolicy response = await networkSecurityClient.GetServerTlsPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetServerTlsPolicy</summary>
        public void GetServerTlsPolicy()
        {
            // Snippet: GetServerTlsPolicy(string, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/serverTlsPolicies/[SERVER_TLS_POLICY]";
            // Make the request
            ServerTlsPolicy response = networkSecurityClient.GetServerTlsPolicy(name);
            // End snippet
        }

        /// <summary>Snippet for GetServerTlsPolicyAsync</summary>
        public async Task GetServerTlsPolicyAsync()
        {
            // Snippet: GetServerTlsPolicyAsync(string, CallSettings)
            // Additional: GetServerTlsPolicyAsync(string, CancellationToken)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/serverTlsPolicies/[SERVER_TLS_POLICY]";
            // Make the request
            ServerTlsPolicy response = await networkSecurityClient.GetServerTlsPolicyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetServerTlsPolicy</summary>
        public void GetServerTlsPolicyResourceNames()
        {
            // Snippet: GetServerTlsPolicy(ServerTlsPolicyName, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            ServerTlsPolicyName name = ServerTlsPolicyName.FromProjectLocationServerTlsPolicy("[PROJECT]", "[LOCATION]", "[SERVER_TLS_POLICY]");
            // Make the request
            ServerTlsPolicy response = networkSecurityClient.GetServerTlsPolicy(name);
            // End snippet
        }

        /// <summary>Snippet for GetServerTlsPolicyAsync</summary>
        public async Task GetServerTlsPolicyResourceNamesAsync()
        {
            // Snippet: GetServerTlsPolicyAsync(ServerTlsPolicyName, CallSettings)
            // Additional: GetServerTlsPolicyAsync(ServerTlsPolicyName, CancellationToken)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            ServerTlsPolicyName name = ServerTlsPolicyName.FromProjectLocationServerTlsPolicy("[PROJECT]", "[LOCATION]", "[SERVER_TLS_POLICY]");
            // Make the request
            ServerTlsPolicy response = await networkSecurityClient.GetServerTlsPolicyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateServerTlsPolicy</summary>
        public void CreateServerTlsPolicyRequestObject()
        {
            // Snippet: CreateServerTlsPolicy(CreateServerTlsPolicyRequest, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            CreateServerTlsPolicyRequest request = new CreateServerTlsPolicyRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ServerTlsPolicyId = "",
                ServerTlsPolicy = new ServerTlsPolicy(),
            };
            // Make the request
            Operation<ServerTlsPolicy, OperationMetadata> response = networkSecurityClient.CreateServerTlsPolicy(request);

            // Poll until the returned long-running operation is complete
            Operation<ServerTlsPolicy, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ServerTlsPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ServerTlsPolicy, OperationMetadata> retrievedResponse = networkSecurityClient.PollOnceCreateServerTlsPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ServerTlsPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateServerTlsPolicyAsync</summary>
        public async Task CreateServerTlsPolicyRequestObjectAsync()
        {
            // Snippet: CreateServerTlsPolicyAsync(CreateServerTlsPolicyRequest, CallSettings)
            // Additional: CreateServerTlsPolicyAsync(CreateServerTlsPolicyRequest, CancellationToken)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            CreateServerTlsPolicyRequest request = new CreateServerTlsPolicyRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ServerTlsPolicyId = "",
                ServerTlsPolicy = new ServerTlsPolicy(),
            };
            // Make the request
            Operation<ServerTlsPolicy, OperationMetadata> response = await networkSecurityClient.CreateServerTlsPolicyAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ServerTlsPolicy, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ServerTlsPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ServerTlsPolicy, OperationMetadata> retrievedResponse = await networkSecurityClient.PollOnceCreateServerTlsPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ServerTlsPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateServerTlsPolicy</summary>
        public void CreateServerTlsPolicy()
        {
            // Snippet: CreateServerTlsPolicy(string, ServerTlsPolicy, string, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            ServerTlsPolicy serverTlsPolicy = new ServerTlsPolicy();
            string serverTlsPolicyId = "";
            // Make the request
            Operation<ServerTlsPolicy, OperationMetadata> response = networkSecurityClient.CreateServerTlsPolicy(parent, serverTlsPolicy, serverTlsPolicyId);

            // Poll until the returned long-running operation is complete
            Operation<ServerTlsPolicy, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ServerTlsPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ServerTlsPolicy, OperationMetadata> retrievedResponse = networkSecurityClient.PollOnceCreateServerTlsPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ServerTlsPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateServerTlsPolicyAsync</summary>
        public async Task CreateServerTlsPolicyAsync()
        {
            // Snippet: CreateServerTlsPolicyAsync(string, ServerTlsPolicy, string, CallSettings)
            // Additional: CreateServerTlsPolicyAsync(string, ServerTlsPolicy, string, CancellationToken)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            ServerTlsPolicy serverTlsPolicy = new ServerTlsPolicy();
            string serverTlsPolicyId = "";
            // Make the request
            Operation<ServerTlsPolicy, OperationMetadata> response = await networkSecurityClient.CreateServerTlsPolicyAsync(parent, serverTlsPolicy, serverTlsPolicyId);

            // Poll until the returned long-running operation is complete
            Operation<ServerTlsPolicy, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ServerTlsPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ServerTlsPolicy, OperationMetadata> retrievedResponse = await networkSecurityClient.PollOnceCreateServerTlsPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ServerTlsPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateServerTlsPolicy</summary>
        public void CreateServerTlsPolicyResourceNames()
        {
            // Snippet: CreateServerTlsPolicy(LocationName, ServerTlsPolicy, string, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            ServerTlsPolicy serverTlsPolicy = new ServerTlsPolicy();
            string serverTlsPolicyId = "";
            // Make the request
            Operation<ServerTlsPolicy, OperationMetadata> response = networkSecurityClient.CreateServerTlsPolicy(parent, serverTlsPolicy, serverTlsPolicyId);

            // Poll until the returned long-running operation is complete
            Operation<ServerTlsPolicy, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ServerTlsPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ServerTlsPolicy, OperationMetadata> retrievedResponse = networkSecurityClient.PollOnceCreateServerTlsPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ServerTlsPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateServerTlsPolicyAsync</summary>
        public async Task CreateServerTlsPolicyResourceNamesAsync()
        {
            // Snippet: CreateServerTlsPolicyAsync(LocationName, ServerTlsPolicy, string, CallSettings)
            // Additional: CreateServerTlsPolicyAsync(LocationName, ServerTlsPolicy, string, CancellationToken)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            ServerTlsPolicy serverTlsPolicy = new ServerTlsPolicy();
            string serverTlsPolicyId = "";
            // Make the request
            Operation<ServerTlsPolicy, OperationMetadata> response = await networkSecurityClient.CreateServerTlsPolicyAsync(parent, serverTlsPolicy, serverTlsPolicyId);

            // Poll until the returned long-running operation is complete
            Operation<ServerTlsPolicy, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ServerTlsPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ServerTlsPolicy, OperationMetadata> retrievedResponse = await networkSecurityClient.PollOnceCreateServerTlsPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ServerTlsPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateServerTlsPolicy</summary>
        public void UpdateServerTlsPolicyRequestObject()
        {
            // Snippet: UpdateServerTlsPolicy(UpdateServerTlsPolicyRequest, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            UpdateServerTlsPolicyRequest request = new UpdateServerTlsPolicyRequest
            {
                UpdateMask = new FieldMask(),
                ServerTlsPolicy = new ServerTlsPolicy(),
            };
            // Make the request
            Operation<ServerTlsPolicy, OperationMetadata> response = networkSecurityClient.UpdateServerTlsPolicy(request);

            // Poll until the returned long-running operation is complete
            Operation<ServerTlsPolicy, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ServerTlsPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ServerTlsPolicy, OperationMetadata> retrievedResponse = networkSecurityClient.PollOnceUpdateServerTlsPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ServerTlsPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateServerTlsPolicyAsync</summary>
        public async Task UpdateServerTlsPolicyRequestObjectAsync()
        {
            // Snippet: UpdateServerTlsPolicyAsync(UpdateServerTlsPolicyRequest, CallSettings)
            // Additional: UpdateServerTlsPolicyAsync(UpdateServerTlsPolicyRequest, CancellationToken)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            UpdateServerTlsPolicyRequest request = new UpdateServerTlsPolicyRequest
            {
                UpdateMask = new FieldMask(),
                ServerTlsPolicy = new ServerTlsPolicy(),
            };
            // Make the request
            Operation<ServerTlsPolicy, OperationMetadata> response = await networkSecurityClient.UpdateServerTlsPolicyAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ServerTlsPolicy, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ServerTlsPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ServerTlsPolicy, OperationMetadata> retrievedResponse = await networkSecurityClient.PollOnceUpdateServerTlsPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ServerTlsPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateServerTlsPolicy</summary>
        public void UpdateServerTlsPolicy()
        {
            // Snippet: UpdateServerTlsPolicy(ServerTlsPolicy, FieldMask, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            ServerTlsPolicy serverTlsPolicy = new ServerTlsPolicy();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<ServerTlsPolicy, OperationMetadata> response = networkSecurityClient.UpdateServerTlsPolicy(serverTlsPolicy, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<ServerTlsPolicy, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ServerTlsPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ServerTlsPolicy, OperationMetadata> retrievedResponse = networkSecurityClient.PollOnceUpdateServerTlsPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ServerTlsPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateServerTlsPolicyAsync</summary>
        public async Task UpdateServerTlsPolicyAsync()
        {
            // Snippet: UpdateServerTlsPolicyAsync(ServerTlsPolicy, FieldMask, CallSettings)
            // Additional: UpdateServerTlsPolicyAsync(ServerTlsPolicy, FieldMask, CancellationToken)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            ServerTlsPolicy serverTlsPolicy = new ServerTlsPolicy();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<ServerTlsPolicy, OperationMetadata> response = await networkSecurityClient.UpdateServerTlsPolicyAsync(serverTlsPolicy, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<ServerTlsPolicy, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ServerTlsPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ServerTlsPolicy, OperationMetadata> retrievedResponse = await networkSecurityClient.PollOnceUpdateServerTlsPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ServerTlsPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteServerTlsPolicy</summary>
        public void DeleteServerTlsPolicyRequestObject()
        {
            // Snippet: DeleteServerTlsPolicy(DeleteServerTlsPolicyRequest, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            DeleteServerTlsPolicyRequest request = new DeleteServerTlsPolicyRequest
            {
                ServerTlsPolicyName = ServerTlsPolicyName.FromProjectLocationServerTlsPolicy("[PROJECT]", "[LOCATION]", "[SERVER_TLS_POLICY]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = networkSecurityClient.DeleteServerTlsPolicy(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = networkSecurityClient.PollOnceDeleteServerTlsPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteServerTlsPolicyAsync</summary>
        public async Task DeleteServerTlsPolicyRequestObjectAsync()
        {
            // Snippet: DeleteServerTlsPolicyAsync(DeleteServerTlsPolicyRequest, CallSettings)
            // Additional: DeleteServerTlsPolicyAsync(DeleteServerTlsPolicyRequest, CancellationToken)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            DeleteServerTlsPolicyRequest request = new DeleteServerTlsPolicyRequest
            {
                ServerTlsPolicyName = ServerTlsPolicyName.FromProjectLocationServerTlsPolicy("[PROJECT]", "[LOCATION]", "[SERVER_TLS_POLICY]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await networkSecurityClient.DeleteServerTlsPolicyAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await networkSecurityClient.PollOnceDeleteServerTlsPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteServerTlsPolicy</summary>
        public void DeleteServerTlsPolicy()
        {
            // Snippet: DeleteServerTlsPolicy(string, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/serverTlsPolicies/[SERVER_TLS_POLICY]";
            // Make the request
            Operation<Empty, OperationMetadata> response = networkSecurityClient.DeleteServerTlsPolicy(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = networkSecurityClient.PollOnceDeleteServerTlsPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteServerTlsPolicyAsync</summary>
        public async Task DeleteServerTlsPolicyAsync()
        {
            // Snippet: DeleteServerTlsPolicyAsync(string, CallSettings)
            // Additional: DeleteServerTlsPolicyAsync(string, CancellationToken)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/serverTlsPolicies/[SERVER_TLS_POLICY]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await networkSecurityClient.DeleteServerTlsPolicyAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await networkSecurityClient.PollOnceDeleteServerTlsPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteServerTlsPolicy</summary>
        public void DeleteServerTlsPolicyResourceNames()
        {
            // Snippet: DeleteServerTlsPolicy(ServerTlsPolicyName, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            ServerTlsPolicyName name = ServerTlsPolicyName.FromProjectLocationServerTlsPolicy("[PROJECT]", "[LOCATION]", "[SERVER_TLS_POLICY]");
            // Make the request
            Operation<Empty, OperationMetadata> response = networkSecurityClient.DeleteServerTlsPolicy(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = networkSecurityClient.PollOnceDeleteServerTlsPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteServerTlsPolicyAsync</summary>
        public async Task DeleteServerTlsPolicyResourceNamesAsync()
        {
            // Snippet: DeleteServerTlsPolicyAsync(ServerTlsPolicyName, CallSettings)
            // Additional: DeleteServerTlsPolicyAsync(ServerTlsPolicyName, CancellationToken)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            ServerTlsPolicyName name = ServerTlsPolicyName.FromProjectLocationServerTlsPolicy("[PROJECT]", "[LOCATION]", "[SERVER_TLS_POLICY]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await networkSecurityClient.DeleteServerTlsPolicyAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await networkSecurityClient.PollOnceDeleteServerTlsPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListClientTlsPolicies</summary>
        public void ListClientTlsPoliciesRequestObject()
        {
            // Snippet: ListClientTlsPolicies(ListClientTlsPoliciesRequest, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            ListClientTlsPoliciesRequest request = new ListClientTlsPoliciesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedEnumerable<ListClientTlsPoliciesResponse, ClientTlsPolicy> response = networkSecurityClient.ListClientTlsPolicies(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ClientTlsPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListClientTlsPoliciesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ClientTlsPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ClientTlsPolicy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ClientTlsPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListClientTlsPoliciesAsync</summary>
        public async Task ListClientTlsPoliciesRequestObjectAsync()
        {
            // Snippet: ListClientTlsPoliciesAsync(ListClientTlsPoliciesRequest, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            ListClientTlsPoliciesRequest request = new ListClientTlsPoliciesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListClientTlsPoliciesResponse, ClientTlsPolicy> response = networkSecurityClient.ListClientTlsPoliciesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ClientTlsPolicy item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListClientTlsPoliciesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ClientTlsPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ClientTlsPolicy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ClientTlsPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListClientTlsPolicies</summary>
        public void ListClientTlsPolicies()
        {
            // Snippet: ListClientTlsPolicies(string, string, int?, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListClientTlsPoliciesResponse, ClientTlsPolicy> response = networkSecurityClient.ListClientTlsPolicies(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ClientTlsPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListClientTlsPoliciesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ClientTlsPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ClientTlsPolicy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ClientTlsPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListClientTlsPoliciesAsync</summary>
        public async Task ListClientTlsPoliciesAsync()
        {
            // Snippet: ListClientTlsPoliciesAsync(string, string, int?, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListClientTlsPoliciesResponse, ClientTlsPolicy> response = networkSecurityClient.ListClientTlsPoliciesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ClientTlsPolicy item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListClientTlsPoliciesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ClientTlsPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ClientTlsPolicy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ClientTlsPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListClientTlsPolicies</summary>
        public void ListClientTlsPoliciesResourceNames()
        {
            // Snippet: ListClientTlsPolicies(LocationName, string, int?, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListClientTlsPoliciesResponse, ClientTlsPolicy> response = networkSecurityClient.ListClientTlsPolicies(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ClientTlsPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListClientTlsPoliciesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ClientTlsPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ClientTlsPolicy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ClientTlsPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListClientTlsPoliciesAsync</summary>
        public async Task ListClientTlsPoliciesResourceNamesAsync()
        {
            // Snippet: ListClientTlsPoliciesAsync(LocationName, string, int?, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListClientTlsPoliciesResponse, ClientTlsPolicy> response = networkSecurityClient.ListClientTlsPoliciesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ClientTlsPolicy item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListClientTlsPoliciesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ClientTlsPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ClientTlsPolicy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ClientTlsPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetClientTlsPolicy</summary>
        public void GetClientTlsPolicyRequestObject()
        {
            // Snippet: GetClientTlsPolicy(GetClientTlsPolicyRequest, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            GetClientTlsPolicyRequest request = new GetClientTlsPolicyRequest
            {
                ClientTlsPolicyName = ClientTlsPolicyName.FromProjectLocationClientTlsPolicy("[PROJECT]", "[LOCATION]", "[CLIENT_TLS_POLICY]"),
            };
            // Make the request
            ClientTlsPolicy response = networkSecurityClient.GetClientTlsPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for GetClientTlsPolicyAsync</summary>
        public async Task GetClientTlsPolicyRequestObjectAsync()
        {
            // Snippet: GetClientTlsPolicyAsync(GetClientTlsPolicyRequest, CallSettings)
            // Additional: GetClientTlsPolicyAsync(GetClientTlsPolicyRequest, CancellationToken)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            GetClientTlsPolicyRequest request = new GetClientTlsPolicyRequest
            {
                ClientTlsPolicyName = ClientTlsPolicyName.FromProjectLocationClientTlsPolicy("[PROJECT]", "[LOCATION]", "[CLIENT_TLS_POLICY]"),
            };
            // Make the request
            ClientTlsPolicy response = await networkSecurityClient.GetClientTlsPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetClientTlsPolicy</summary>
        public void GetClientTlsPolicy()
        {
            // Snippet: GetClientTlsPolicy(string, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/clientTlsPolicies/[CLIENT_TLS_POLICY]";
            // Make the request
            ClientTlsPolicy response = networkSecurityClient.GetClientTlsPolicy(name);
            // End snippet
        }

        /// <summary>Snippet for GetClientTlsPolicyAsync</summary>
        public async Task GetClientTlsPolicyAsync()
        {
            // Snippet: GetClientTlsPolicyAsync(string, CallSettings)
            // Additional: GetClientTlsPolicyAsync(string, CancellationToken)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/clientTlsPolicies/[CLIENT_TLS_POLICY]";
            // Make the request
            ClientTlsPolicy response = await networkSecurityClient.GetClientTlsPolicyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetClientTlsPolicy</summary>
        public void GetClientTlsPolicyResourceNames()
        {
            // Snippet: GetClientTlsPolicy(ClientTlsPolicyName, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            ClientTlsPolicyName name = ClientTlsPolicyName.FromProjectLocationClientTlsPolicy("[PROJECT]", "[LOCATION]", "[CLIENT_TLS_POLICY]");
            // Make the request
            ClientTlsPolicy response = networkSecurityClient.GetClientTlsPolicy(name);
            // End snippet
        }

        /// <summary>Snippet for GetClientTlsPolicyAsync</summary>
        public async Task GetClientTlsPolicyResourceNamesAsync()
        {
            // Snippet: GetClientTlsPolicyAsync(ClientTlsPolicyName, CallSettings)
            // Additional: GetClientTlsPolicyAsync(ClientTlsPolicyName, CancellationToken)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            ClientTlsPolicyName name = ClientTlsPolicyName.FromProjectLocationClientTlsPolicy("[PROJECT]", "[LOCATION]", "[CLIENT_TLS_POLICY]");
            // Make the request
            ClientTlsPolicy response = await networkSecurityClient.GetClientTlsPolicyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateClientTlsPolicy</summary>
        public void CreateClientTlsPolicyRequestObject()
        {
            // Snippet: CreateClientTlsPolicy(CreateClientTlsPolicyRequest, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            CreateClientTlsPolicyRequest request = new CreateClientTlsPolicyRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ClientTlsPolicyId = "",
                ClientTlsPolicy = new ClientTlsPolicy(),
            };
            // Make the request
            Operation<ClientTlsPolicy, OperationMetadata> response = networkSecurityClient.CreateClientTlsPolicy(request);

            // Poll until the returned long-running operation is complete
            Operation<ClientTlsPolicy, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ClientTlsPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ClientTlsPolicy, OperationMetadata> retrievedResponse = networkSecurityClient.PollOnceCreateClientTlsPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ClientTlsPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateClientTlsPolicyAsync</summary>
        public async Task CreateClientTlsPolicyRequestObjectAsync()
        {
            // Snippet: CreateClientTlsPolicyAsync(CreateClientTlsPolicyRequest, CallSettings)
            // Additional: CreateClientTlsPolicyAsync(CreateClientTlsPolicyRequest, CancellationToken)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            CreateClientTlsPolicyRequest request = new CreateClientTlsPolicyRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ClientTlsPolicyId = "",
                ClientTlsPolicy = new ClientTlsPolicy(),
            };
            // Make the request
            Operation<ClientTlsPolicy, OperationMetadata> response = await networkSecurityClient.CreateClientTlsPolicyAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ClientTlsPolicy, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ClientTlsPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ClientTlsPolicy, OperationMetadata> retrievedResponse = await networkSecurityClient.PollOnceCreateClientTlsPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ClientTlsPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateClientTlsPolicy</summary>
        public void CreateClientTlsPolicy()
        {
            // Snippet: CreateClientTlsPolicy(string, ClientTlsPolicy, string, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            ClientTlsPolicy clientTlsPolicy = new ClientTlsPolicy();
            string clientTlsPolicyId = "";
            // Make the request
            Operation<ClientTlsPolicy, OperationMetadata> response = networkSecurityClient.CreateClientTlsPolicy(parent, clientTlsPolicy, clientTlsPolicyId);

            // Poll until the returned long-running operation is complete
            Operation<ClientTlsPolicy, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ClientTlsPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ClientTlsPolicy, OperationMetadata> retrievedResponse = networkSecurityClient.PollOnceCreateClientTlsPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ClientTlsPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateClientTlsPolicyAsync</summary>
        public async Task CreateClientTlsPolicyAsync()
        {
            // Snippet: CreateClientTlsPolicyAsync(string, ClientTlsPolicy, string, CallSettings)
            // Additional: CreateClientTlsPolicyAsync(string, ClientTlsPolicy, string, CancellationToken)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            ClientTlsPolicy clientTlsPolicy = new ClientTlsPolicy();
            string clientTlsPolicyId = "";
            // Make the request
            Operation<ClientTlsPolicy, OperationMetadata> response = await networkSecurityClient.CreateClientTlsPolicyAsync(parent, clientTlsPolicy, clientTlsPolicyId);

            // Poll until the returned long-running operation is complete
            Operation<ClientTlsPolicy, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ClientTlsPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ClientTlsPolicy, OperationMetadata> retrievedResponse = await networkSecurityClient.PollOnceCreateClientTlsPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ClientTlsPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateClientTlsPolicy</summary>
        public void CreateClientTlsPolicyResourceNames()
        {
            // Snippet: CreateClientTlsPolicy(LocationName, ClientTlsPolicy, string, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            ClientTlsPolicy clientTlsPolicy = new ClientTlsPolicy();
            string clientTlsPolicyId = "";
            // Make the request
            Operation<ClientTlsPolicy, OperationMetadata> response = networkSecurityClient.CreateClientTlsPolicy(parent, clientTlsPolicy, clientTlsPolicyId);

            // Poll until the returned long-running operation is complete
            Operation<ClientTlsPolicy, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ClientTlsPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ClientTlsPolicy, OperationMetadata> retrievedResponse = networkSecurityClient.PollOnceCreateClientTlsPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ClientTlsPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateClientTlsPolicyAsync</summary>
        public async Task CreateClientTlsPolicyResourceNamesAsync()
        {
            // Snippet: CreateClientTlsPolicyAsync(LocationName, ClientTlsPolicy, string, CallSettings)
            // Additional: CreateClientTlsPolicyAsync(LocationName, ClientTlsPolicy, string, CancellationToken)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            ClientTlsPolicy clientTlsPolicy = new ClientTlsPolicy();
            string clientTlsPolicyId = "";
            // Make the request
            Operation<ClientTlsPolicy, OperationMetadata> response = await networkSecurityClient.CreateClientTlsPolicyAsync(parent, clientTlsPolicy, clientTlsPolicyId);

            // Poll until the returned long-running operation is complete
            Operation<ClientTlsPolicy, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ClientTlsPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ClientTlsPolicy, OperationMetadata> retrievedResponse = await networkSecurityClient.PollOnceCreateClientTlsPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ClientTlsPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateClientTlsPolicy</summary>
        public void UpdateClientTlsPolicyRequestObject()
        {
            // Snippet: UpdateClientTlsPolicy(UpdateClientTlsPolicyRequest, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            UpdateClientTlsPolicyRequest request = new UpdateClientTlsPolicyRequest
            {
                UpdateMask = new FieldMask(),
                ClientTlsPolicy = new ClientTlsPolicy(),
            };
            // Make the request
            Operation<ClientTlsPolicy, OperationMetadata> response = networkSecurityClient.UpdateClientTlsPolicy(request);

            // Poll until the returned long-running operation is complete
            Operation<ClientTlsPolicy, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ClientTlsPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ClientTlsPolicy, OperationMetadata> retrievedResponse = networkSecurityClient.PollOnceUpdateClientTlsPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ClientTlsPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateClientTlsPolicyAsync</summary>
        public async Task UpdateClientTlsPolicyRequestObjectAsync()
        {
            // Snippet: UpdateClientTlsPolicyAsync(UpdateClientTlsPolicyRequest, CallSettings)
            // Additional: UpdateClientTlsPolicyAsync(UpdateClientTlsPolicyRequest, CancellationToken)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            UpdateClientTlsPolicyRequest request = new UpdateClientTlsPolicyRequest
            {
                UpdateMask = new FieldMask(),
                ClientTlsPolicy = new ClientTlsPolicy(),
            };
            // Make the request
            Operation<ClientTlsPolicy, OperationMetadata> response = await networkSecurityClient.UpdateClientTlsPolicyAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ClientTlsPolicy, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ClientTlsPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ClientTlsPolicy, OperationMetadata> retrievedResponse = await networkSecurityClient.PollOnceUpdateClientTlsPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ClientTlsPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateClientTlsPolicy</summary>
        public void UpdateClientTlsPolicy()
        {
            // Snippet: UpdateClientTlsPolicy(ClientTlsPolicy, FieldMask, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            ClientTlsPolicy clientTlsPolicy = new ClientTlsPolicy();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<ClientTlsPolicy, OperationMetadata> response = networkSecurityClient.UpdateClientTlsPolicy(clientTlsPolicy, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<ClientTlsPolicy, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ClientTlsPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ClientTlsPolicy, OperationMetadata> retrievedResponse = networkSecurityClient.PollOnceUpdateClientTlsPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ClientTlsPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateClientTlsPolicyAsync</summary>
        public async Task UpdateClientTlsPolicyAsync()
        {
            // Snippet: UpdateClientTlsPolicyAsync(ClientTlsPolicy, FieldMask, CallSettings)
            // Additional: UpdateClientTlsPolicyAsync(ClientTlsPolicy, FieldMask, CancellationToken)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            ClientTlsPolicy clientTlsPolicy = new ClientTlsPolicy();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<ClientTlsPolicy, OperationMetadata> response = await networkSecurityClient.UpdateClientTlsPolicyAsync(clientTlsPolicy, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<ClientTlsPolicy, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ClientTlsPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ClientTlsPolicy, OperationMetadata> retrievedResponse = await networkSecurityClient.PollOnceUpdateClientTlsPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ClientTlsPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteClientTlsPolicy</summary>
        public void DeleteClientTlsPolicyRequestObject()
        {
            // Snippet: DeleteClientTlsPolicy(DeleteClientTlsPolicyRequest, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            DeleteClientTlsPolicyRequest request = new DeleteClientTlsPolicyRequest
            {
                ClientTlsPolicyName = ClientTlsPolicyName.FromProjectLocationClientTlsPolicy("[PROJECT]", "[LOCATION]", "[CLIENT_TLS_POLICY]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = networkSecurityClient.DeleteClientTlsPolicy(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = networkSecurityClient.PollOnceDeleteClientTlsPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteClientTlsPolicyAsync</summary>
        public async Task DeleteClientTlsPolicyRequestObjectAsync()
        {
            // Snippet: DeleteClientTlsPolicyAsync(DeleteClientTlsPolicyRequest, CallSettings)
            // Additional: DeleteClientTlsPolicyAsync(DeleteClientTlsPolicyRequest, CancellationToken)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            DeleteClientTlsPolicyRequest request = new DeleteClientTlsPolicyRequest
            {
                ClientTlsPolicyName = ClientTlsPolicyName.FromProjectLocationClientTlsPolicy("[PROJECT]", "[LOCATION]", "[CLIENT_TLS_POLICY]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await networkSecurityClient.DeleteClientTlsPolicyAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await networkSecurityClient.PollOnceDeleteClientTlsPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteClientTlsPolicy</summary>
        public void DeleteClientTlsPolicy()
        {
            // Snippet: DeleteClientTlsPolicy(string, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/clientTlsPolicies/[CLIENT_TLS_POLICY]";
            // Make the request
            Operation<Empty, OperationMetadata> response = networkSecurityClient.DeleteClientTlsPolicy(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = networkSecurityClient.PollOnceDeleteClientTlsPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteClientTlsPolicyAsync</summary>
        public async Task DeleteClientTlsPolicyAsync()
        {
            // Snippet: DeleteClientTlsPolicyAsync(string, CallSettings)
            // Additional: DeleteClientTlsPolicyAsync(string, CancellationToken)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/clientTlsPolicies/[CLIENT_TLS_POLICY]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await networkSecurityClient.DeleteClientTlsPolicyAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await networkSecurityClient.PollOnceDeleteClientTlsPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteClientTlsPolicy</summary>
        public void DeleteClientTlsPolicyResourceNames()
        {
            // Snippet: DeleteClientTlsPolicy(ClientTlsPolicyName, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            ClientTlsPolicyName name = ClientTlsPolicyName.FromProjectLocationClientTlsPolicy("[PROJECT]", "[LOCATION]", "[CLIENT_TLS_POLICY]");
            // Make the request
            Operation<Empty, OperationMetadata> response = networkSecurityClient.DeleteClientTlsPolicy(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = networkSecurityClient.PollOnceDeleteClientTlsPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteClientTlsPolicyAsync</summary>
        public async Task DeleteClientTlsPolicyResourceNamesAsync()
        {
            // Snippet: DeleteClientTlsPolicyAsync(ClientTlsPolicyName, CallSettings)
            // Additional: DeleteClientTlsPolicyAsync(ClientTlsPolicyName, CancellationToken)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            ClientTlsPolicyName name = ClientTlsPolicyName.FromProjectLocationClientTlsPolicy("[PROJECT]", "[LOCATION]", "[CLIENT_TLS_POLICY]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await networkSecurityClient.DeleteClientTlsPolicyAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await networkSecurityClient.PollOnceDeleteClientTlsPolicyAsync(operationName);
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
