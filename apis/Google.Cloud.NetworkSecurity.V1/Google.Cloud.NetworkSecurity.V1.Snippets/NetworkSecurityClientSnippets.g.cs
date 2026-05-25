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
    using Google.Cloud.NetworkSecurity.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
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
            await foreach (AuthorizationPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListAuthorizationPoliciesResponse page in response.AsRawResponses())
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
            await foreach (AuthorizationPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListAuthorizationPoliciesResponse page in response.AsRawResponses())
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
            await foreach (AuthorizationPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListAuthorizationPoliciesResponse page in response.AsRawResponses())
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

        /// <summary>Snippet for ListBackendAuthenticationConfigs</summary>
        public void ListBackendAuthenticationConfigsRequestObject()
        {
            // Snippet: ListBackendAuthenticationConfigs(ListBackendAuthenticationConfigsRequest, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            ListBackendAuthenticationConfigsRequest request = new ListBackendAuthenticationConfigsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedEnumerable<ListBackendAuthenticationConfigsResponse, BackendAuthenticationConfig> response = networkSecurityClient.ListBackendAuthenticationConfigs(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (BackendAuthenticationConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListBackendAuthenticationConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BackendAuthenticationConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BackendAuthenticationConfig> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BackendAuthenticationConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBackendAuthenticationConfigsAsync</summary>
        public async Task ListBackendAuthenticationConfigsRequestObjectAsync()
        {
            // Snippet: ListBackendAuthenticationConfigsAsync(ListBackendAuthenticationConfigsRequest, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            ListBackendAuthenticationConfigsRequest request = new ListBackendAuthenticationConfigsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListBackendAuthenticationConfigsResponse, BackendAuthenticationConfig> response = networkSecurityClient.ListBackendAuthenticationConfigsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (BackendAuthenticationConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListBackendAuthenticationConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BackendAuthenticationConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BackendAuthenticationConfig> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BackendAuthenticationConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBackendAuthenticationConfigs</summary>
        public void ListBackendAuthenticationConfigs()
        {
            // Snippet: ListBackendAuthenticationConfigs(string, string, int?, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListBackendAuthenticationConfigsResponse, BackendAuthenticationConfig> response = networkSecurityClient.ListBackendAuthenticationConfigs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (BackendAuthenticationConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListBackendAuthenticationConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BackendAuthenticationConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BackendAuthenticationConfig> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BackendAuthenticationConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBackendAuthenticationConfigsAsync</summary>
        public async Task ListBackendAuthenticationConfigsAsync()
        {
            // Snippet: ListBackendAuthenticationConfigsAsync(string, string, int?, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListBackendAuthenticationConfigsResponse, BackendAuthenticationConfig> response = networkSecurityClient.ListBackendAuthenticationConfigsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (BackendAuthenticationConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListBackendAuthenticationConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BackendAuthenticationConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BackendAuthenticationConfig> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BackendAuthenticationConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBackendAuthenticationConfigs</summary>
        public void ListBackendAuthenticationConfigsResourceNames()
        {
            // Snippet: ListBackendAuthenticationConfigs(LocationName, string, int?, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListBackendAuthenticationConfigsResponse, BackendAuthenticationConfig> response = networkSecurityClient.ListBackendAuthenticationConfigs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (BackendAuthenticationConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListBackendAuthenticationConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BackendAuthenticationConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BackendAuthenticationConfig> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BackendAuthenticationConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBackendAuthenticationConfigsAsync</summary>
        public async Task ListBackendAuthenticationConfigsResourceNamesAsync()
        {
            // Snippet: ListBackendAuthenticationConfigsAsync(LocationName, string, int?, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListBackendAuthenticationConfigsResponse, BackendAuthenticationConfig> response = networkSecurityClient.ListBackendAuthenticationConfigsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (BackendAuthenticationConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListBackendAuthenticationConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BackendAuthenticationConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BackendAuthenticationConfig> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BackendAuthenticationConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetBackendAuthenticationConfig</summary>
        public void GetBackendAuthenticationConfigRequestObject()
        {
            // Snippet: GetBackendAuthenticationConfig(GetBackendAuthenticationConfigRequest, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            GetBackendAuthenticationConfigRequest request = new GetBackendAuthenticationConfigRequest
            {
                BackendAuthenticationConfigName = BackendAuthenticationConfigName.FromProjectLocationBackendAuthenticationConfig("[PROJECT]", "[LOCATION]", "[BACKEND_AUTHENTICATION_CONFIG]"),
            };
            // Make the request
            BackendAuthenticationConfig response = networkSecurityClient.GetBackendAuthenticationConfig(request);
            // End snippet
        }

        /// <summary>Snippet for GetBackendAuthenticationConfigAsync</summary>
        public async Task GetBackendAuthenticationConfigRequestObjectAsync()
        {
            // Snippet: GetBackendAuthenticationConfigAsync(GetBackendAuthenticationConfigRequest, CallSettings)
            // Additional: GetBackendAuthenticationConfigAsync(GetBackendAuthenticationConfigRequest, CancellationToken)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            GetBackendAuthenticationConfigRequest request = new GetBackendAuthenticationConfigRequest
            {
                BackendAuthenticationConfigName = BackendAuthenticationConfigName.FromProjectLocationBackendAuthenticationConfig("[PROJECT]", "[LOCATION]", "[BACKEND_AUTHENTICATION_CONFIG]"),
            };
            // Make the request
            BackendAuthenticationConfig response = await networkSecurityClient.GetBackendAuthenticationConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetBackendAuthenticationConfig</summary>
        public void GetBackendAuthenticationConfig()
        {
            // Snippet: GetBackendAuthenticationConfig(string, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/backendAuthenticationConfigs/[BACKEND_AUTHENTICATION_CONFIG]";
            // Make the request
            BackendAuthenticationConfig response = networkSecurityClient.GetBackendAuthenticationConfig(name);
            // End snippet
        }

        /// <summary>Snippet for GetBackendAuthenticationConfigAsync</summary>
        public async Task GetBackendAuthenticationConfigAsync()
        {
            // Snippet: GetBackendAuthenticationConfigAsync(string, CallSettings)
            // Additional: GetBackendAuthenticationConfigAsync(string, CancellationToken)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/backendAuthenticationConfigs/[BACKEND_AUTHENTICATION_CONFIG]";
            // Make the request
            BackendAuthenticationConfig response = await networkSecurityClient.GetBackendAuthenticationConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetBackendAuthenticationConfig</summary>
        public void GetBackendAuthenticationConfigResourceNames()
        {
            // Snippet: GetBackendAuthenticationConfig(BackendAuthenticationConfigName, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            BackendAuthenticationConfigName name = BackendAuthenticationConfigName.FromProjectLocationBackendAuthenticationConfig("[PROJECT]", "[LOCATION]", "[BACKEND_AUTHENTICATION_CONFIG]");
            // Make the request
            BackendAuthenticationConfig response = networkSecurityClient.GetBackendAuthenticationConfig(name);
            // End snippet
        }

        /// <summary>Snippet for GetBackendAuthenticationConfigAsync</summary>
        public async Task GetBackendAuthenticationConfigResourceNamesAsync()
        {
            // Snippet: GetBackendAuthenticationConfigAsync(BackendAuthenticationConfigName, CallSettings)
            // Additional: GetBackendAuthenticationConfigAsync(BackendAuthenticationConfigName, CancellationToken)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            BackendAuthenticationConfigName name = BackendAuthenticationConfigName.FromProjectLocationBackendAuthenticationConfig("[PROJECT]", "[LOCATION]", "[BACKEND_AUTHENTICATION_CONFIG]");
            // Make the request
            BackendAuthenticationConfig response = await networkSecurityClient.GetBackendAuthenticationConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateBackendAuthenticationConfig</summary>
        public void CreateBackendAuthenticationConfigRequestObject()
        {
            // Snippet: CreateBackendAuthenticationConfig(CreateBackendAuthenticationConfigRequest, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            CreateBackendAuthenticationConfigRequest request = new CreateBackendAuthenticationConfigRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                BackendAuthenticationConfigId = "",
                BackendAuthenticationConfig = new BackendAuthenticationConfig(),
            };
            // Make the request
            Operation<BackendAuthenticationConfig, OperationMetadata> response = networkSecurityClient.CreateBackendAuthenticationConfig(request);

            // Poll until the returned long-running operation is complete
            Operation<BackendAuthenticationConfig, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BackendAuthenticationConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BackendAuthenticationConfig, OperationMetadata> retrievedResponse = networkSecurityClient.PollOnceCreateBackendAuthenticationConfig(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BackendAuthenticationConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateBackendAuthenticationConfigAsync</summary>
        public async Task CreateBackendAuthenticationConfigRequestObjectAsync()
        {
            // Snippet: CreateBackendAuthenticationConfigAsync(CreateBackendAuthenticationConfigRequest, CallSettings)
            // Additional: CreateBackendAuthenticationConfigAsync(CreateBackendAuthenticationConfigRequest, CancellationToken)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            CreateBackendAuthenticationConfigRequest request = new CreateBackendAuthenticationConfigRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                BackendAuthenticationConfigId = "",
                BackendAuthenticationConfig = new BackendAuthenticationConfig(),
            };
            // Make the request
            Operation<BackendAuthenticationConfig, OperationMetadata> response = await networkSecurityClient.CreateBackendAuthenticationConfigAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<BackendAuthenticationConfig, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BackendAuthenticationConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BackendAuthenticationConfig, OperationMetadata> retrievedResponse = await networkSecurityClient.PollOnceCreateBackendAuthenticationConfigAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BackendAuthenticationConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateBackendAuthenticationConfig</summary>
        public void CreateBackendAuthenticationConfig()
        {
            // Snippet: CreateBackendAuthenticationConfig(string, BackendAuthenticationConfig, string, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            BackendAuthenticationConfig backendAuthenticationConfig = new BackendAuthenticationConfig();
            string backendAuthenticationConfigId = "";
            // Make the request
            Operation<BackendAuthenticationConfig, OperationMetadata> response = networkSecurityClient.CreateBackendAuthenticationConfig(parent, backendAuthenticationConfig, backendAuthenticationConfigId);

            // Poll until the returned long-running operation is complete
            Operation<BackendAuthenticationConfig, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BackendAuthenticationConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BackendAuthenticationConfig, OperationMetadata> retrievedResponse = networkSecurityClient.PollOnceCreateBackendAuthenticationConfig(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BackendAuthenticationConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateBackendAuthenticationConfigAsync</summary>
        public async Task CreateBackendAuthenticationConfigAsync()
        {
            // Snippet: CreateBackendAuthenticationConfigAsync(string, BackendAuthenticationConfig, string, CallSettings)
            // Additional: CreateBackendAuthenticationConfigAsync(string, BackendAuthenticationConfig, string, CancellationToken)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            BackendAuthenticationConfig backendAuthenticationConfig = new BackendAuthenticationConfig();
            string backendAuthenticationConfigId = "";
            // Make the request
            Operation<BackendAuthenticationConfig, OperationMetadata> response = await networkSecurityClient.CreateBackendAuthenticationConfigAsync(parent, backendAuthenticationConfig, backendAuthenticationConfigId);

            // Poll until the returned long-running operation is complete
            Operation<BackendAuthenticationConfig, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BackendAuthenticationConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BackendAuthenticationConfig, OperationMetadata> retrievedResponse = await networkSecurityClient.PollOnceCreateBackendAuthenticationConfigAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BackendAuthenticationConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateBackendAuthenticationConfig</summary>
        public void CreateBackendAuthenticationConfigResourceNames()
        {
            // Snippet: CreateBackendAuthenticationConfig(LocationName, BackendAuthenticationConfig, string, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            BackendAuthenticationConfig backendAuthenticationConfig = new BackendAuthenticationConfig();
            string backendAuthenticationConfigId = "";
            // Make the request
            Operation<BackendAuthenticationConfig, OperationMetadata> response = networkSecurityClient.CreateBackendAuthenticationConfig(parent, backendAuthenticationConfig, backendAuthenticationConfigId);

            // Poll until the returned long-running operation is complete
            Operation<BackendAuthenticationConfig, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BackendAuthenticationConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BackendAuthenticationConfig, OperationMetadata> retrievedResponse = networkSecurityClient.PollOnceCreateBackendAuthenticationConfig(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BackendAuthenticationConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateBackendAuthenticationConfigAsync</summary>
        public async Task CreateBackendAuthenticationConfigResourceNamesAsync()
        {
            // Snippet: CreateBackendAuthenticationConfigAsync(LocationName, BackendAuthenticationConfig, string, CallSettings)
            // Additional: CreateBackendAuthenticationConfigAsync(LocationName, BackendAuthenticationConfig, string, CancellationToken)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            BackendAuthenticationConfig backendAuthenticationConfig = new BackendAuthenticationConfig();
            string backendAuthenticationConfigId = "";
            // Make the request
            Operation<BackendAuthenticationConfig, OperationMetadata> response = await networkSecurityClient.CreateBackendAuthenticationConfigAsync(parent, backendAuthenticationConfig, backendAuthenticationConfigId);

            // Poll until the returned long-running operation is complete
            Operation<BackendAuthenticationConfig, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BackendAuthenticationConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BackendAuthenticationConfig, OperationMetadata> retrievedResponse = await networkSecurityClient.PollOnceCreateBackendAuthenticationConfigAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BackendAuthenticationConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateBackendAuthenticationConfig</summary>
        public void UpdateBackendAuthenticationConfigRequestObject()
        {
            // Snippet: UpdateBackendAuthenticationConfig(UpdateBackendAuthenticationConfigRequest, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            UpdateBackendAuthenticationConfigRequest request = new UpdateBackendAuthenticationConfigRequest
            {
                UpdateMask = new FieldMask(),
                BackendAuthenticationConfig = new BackendAuthenticationConfig(),
            };
            // Make the request
            Operation<BackendAuthenticationConfig, OperationMetadata> response = networkSecurityClient.UpdateBackendAuthenticationConfig(request);

            // Poll until the returned long-running operation is complete
            Operation<BackendAuthenticationConfig, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BackendAuthenticationConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BackendAuthenticationConfig, OperationMetadata> retrievedResponse = networkSecurityClient.PollOnceUpdateBackendAuthenticationConfig(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BackendAuthenticationConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateBackendAuthenticationConfigAsync</summary>
        public async Task UpdateBackendAuthenticationConfigRequestObjectAsync()
        {
            // Snippet: UpdateBackendAuthenticationConfigAsync(UpdateBackendAuthenticationConfigRequest, CallSettings)
            // Additional: UpdateBackendAuthenticationConfigAsync(UpdateBackendAuthenticationConfigRequest, CancellationToken)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            UpdateBackendAuthenticationConfigRequest request = new UpdateBackendAuthenticationConfigRequest
            {
                UpdateMask = new FieldMask(),
                BackendAuthenticationConfig = new BackendAuthenticationConfig(),
            };
            // Make the request
            Operation<BackendAuthenticationConfig, OperationMetadata> response = await networkSecurityClient.UpdateBackendAuthenticationConfigAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<BackendAuthenticationConfig, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BackendAuthenticationConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BackendAuthenticationConfig, OperationMetadata> retrievedResponse = await networkSecurityClient.PollOnceUpdateBackendAuthenticationConfigAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BackendAuthenticationConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateBackendAuthenticationConfig</summary>
        public void UpdateBackendAuthenticationConfig()
        {
            // Snippet: UpdateBackendAuthenticationConfig(BackendAuthenticationConfig, FieldMask, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            BackendAuthenticationConfig backendAuthenticationConfig = new BackendAuthenticationConfig();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<BackendAuthenticationConfig, OperationMetadata> response = networkSecurityClient.UpdateBackendAuthenticationConfig(backendAuthenticationConfig, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<BackendAuthenticationConfig, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BackendAuthenticationConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BackendAuthenticationConfig, OperationMetadata> retrievedResponse = networkSecurityClient.PollOnceUpdateBackendAuthenticationConfig(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BackendAuthenticationConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateBackendAuthenticationConfigAsync</summary>
        public async Task UpdateBackendAuthenticationConfigAsync()
        {
            // Snippet: UpdateBackendAuthenticationConfigAsync(BackendAuthenticationConfig, FieldMask, CallSettings)
            // Additional: UpdateBackendAuthenticationConfigAsync(BackendAuthenticationConfig, FieldMask, CancellationToken)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            BackendAuthenticationConfig backendAuthenticationConfig = new BackendAuthenticationConfig();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<BackendAuthenticationConfig, OperationMetadata> response = await networkSecurityClient.UpdateBackendAuthenticationConfigAsync(backendAuthenticationConfig, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<BackendAuthenticationConfig, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BackendAuthenticationConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BackendAuthenticationConfig, OperationMetadata> retrievedResponse = await networkSecurityClient.PollOnceUpdateBackendAuthenticationConfigAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BackendAuthenticationConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteBackendAuthenticationConfig</summary>
        public void DeleteBackendAuthenticationConfigRequestObject()
        {
            // Snippet: DeleteBackendAuthenticationConfig(DeleteBackendAuthenticationConfigRequest, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            DeleteBackendAuthenticationConfigRequest request = new DeleteBackendAuthenticationConfigRequest
            {
                BackendAuthenticationConfigName = BackendAuthenticationConfigName.FromProjectLocationBackendAuthenticationConfig("[PROJECT]", "[LOCATION]", "[BACKEND_AUTHENTICATION_CONFIG]"),
                Etag = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = networkSecurityClient.DeleteBackendAuthenticationConfig(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = networkSecurityClient.PollOnceDeleteBackendAuthenticationConfig(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteBackendAuthenticationConfigAsync</summary>
        public async Task DeleteBackendAuthenticationConfigRequestObjectAsync()
        {
            // Snippet: DeleteBackendAuthenticationConfigAsync(DeleteBackendAuthenticationConfigRequest, CallSettings)
            // Additional: DeleteBackendAuthenticationConfigAsync(DeleteBackendAuthenticationConfigRequest, CancellationToken)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            DeleteBackendAuthenticationConfigRequest request = new DeleteBackendAuthenticationConfigRequest
            {
                BackendAuthenticationConfigName = BackendAuthenticationConfigName.FromProjectLocationBackendAuthenticationConfig("[PROJECT]", "[LOCATION]", "[BACKEND_AUTHENTICATION_CONFIG]"),
                Etag = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await networkSecurityClient.DeleteBackendAuthenticationConfigAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await networkSecurityClient.PollOnceDeleteBackendAuthenticationConfigAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteBackendAuthenticationConfig</summary>
        public void DeleteBackendAuthenticationConfig()
        {
            // Snippet: DeleteBackendAuthenticationConfig(string, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/backendAuthenticationConfigs/[BACKEND_AUTHENTICATION_CONFIG]";
            // Make the request
            Operation<Empty, OperationMetadata> response = networkSecurityClient.DeleteBackendAuthenticationConfig(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = networkSecurityClient.PollOnceDeleteBackendAuthenticationConfig(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteBackendAuthenticationConfigAsync</summary>
        public async Task DeleteBackendAuthenticationConfigAsync()
        {
            // Snippet: DeleteBackendAuthenticationConfigAsync(string, CallSettings)
            // Additional: DeleteBackendAuthenticationConfigAsync(string, CancellationToken)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/backendAuthenticationConfigs/[BACKEND_AUTHENTICATION_CONFIG]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await networkSecurityClient.DeleteBackendAuthenticationConfigAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await networkSecurityClient.PollOnceDeleteBackendAuthenticationConfigAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteBackendAuthenticationConfig</summary>
        public void DeleteBackendAuthenticationConfigResourceNames()
        {
            // Snippet: DeleteBackendAuthenticationConfig(BackendAuthenticationConfigName, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            BackendAuthenticationConfigName name = BackendAuthenticationConfigName.FromProjectLocationBackendAuthenticationConfig("[PROJECT]", "[LOCATION]", "[BACKEND_AUTHENTICATION_CONFIG]");
            // Make the request
            Operation<Empty, OperationMetadata> response = networkSecurityClient.DeleteBackendAuthenticationConfig(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = networkSecurityClient.PollOnceDeleteBackendAuthenticationConfig(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteBackendAuthenticationConfigAsync</summary>
        public async Task DeleteBackendAuthenticationConfigResourceNamesAsync()
        {
            // Snippet: DeleteBackendAuthenticationConfigAsync(BackendAuthenticationConfigName, CallSettings)
            // Additional: DeleteBackendAuthenticationConfigAsync(BackendAuthenticationConfigName, CancellationToken)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            BackendAuthenticationConfigName name = BackendAuthenticationConfigName.FromProjectLocationBackendAuthenticationConfig("[PROJECT]", "[LOCATION]", "[BACKEND_AUTHENTICATION_CONFIG]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await networkSecurityClient.DeleteBackendAuthenticationConfigAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await networkSecurityClient.PollOnceDeleteBackendAuthenticationConfigAsync(operationName);
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
                ReturnPartialSuccess = false,
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
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<ListServerTlsPoliciesResponse, ServerTlsPolicy> response = networkSecurityClient.ListServerTlsPoliciesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (ServerTlsPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListServerTlsPoliciesResponse page in response.AsRawResponses())
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
            await foreach (ServerTlsPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListServerTlsPoliciesResponse page in response.AsRawResponses())
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
            await foreach (ServerTlsPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListServerTlsPoliciesResponse page in response.AsRawResponses())
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
            await foreach (ClientTlsPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListClientTlsPoliciesResponse page in response.AsRawResponses())
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
            await foreach (ClientTlsPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListClientTlsPoliciesResponse page in response.AsRawResponses())
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
            await foreach (ClientTlsPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListClientTlsPoliciesResponse page in response.AsRawResponses())
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

        /// <summary>Snippet for ListGatewaySecurityPolicies</summary>
        public void ListGatewaySecurityPoliciesRequestObject()
        {
            // Snippet: ListGatewaySecurityPolicies(ListGatewaySecurityPoliciesRequest, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            ListGatewaySecurityPoliciesRequest request = new ListGatewaySecurityPoliciesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedEnumerable<ListGatewaySecurityPoliciesResponse, GatewaySecurityPolicy> response = networkSecurityClient.ListGatewaySecurityPolicies(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (GatewaySecurityPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListGatewaySecurityPoliciesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (GatewaySecurityPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<GatewaySecurityPolicy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (GatewaySecurityPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGatewaySecurityPoliciesAsync</summary>
        public async Task ListGatewaySecurityPoliciesRequestObjectAsync()
        {
            // Snippet: ListGatewaySecurityPoliciesAsync(ListGatewaySecurityPoliciesRequest, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            ListGatewaySecurityPoliciesRequest request = new ListGatewaySecurityPoliciesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListGatewaySecurityPoliciesResponse, GatewaySecurityPolicy> response = networkSecurityClient.ListGatewaySecurityPoliciesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (GatewaySecurityPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListGatewaySecurityPoliciesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (GatewaySecurityPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<GatewaySecurityPolicy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (GatewaySecurityPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGatewaySecurityPolicies</summary>
        public void ListGatewaySecurityPolicies()
        {
            // Snippet: ListGatewaySecurityPolicies(string, string, int?, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListGatewaySecurityPoliciesResponse, GatewaySecurityPolicy> response = networkSecurityClient.ListGatewaySecurityPolicies(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (GatewaySecurityPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListGatewaySecurityPoliciesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (GatewaySecurityPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<GatewaySecurityPolicy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (GatewaySecurityPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGatewaySecurityPoliciesAsync</summary>
        public async Task ListGatewaySecurityPoliciesAsync()
        {
            // Snippet: ListGatewaySecurityPoliciesAsync(string, string, int?, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListGatewaySecurityPoliciesResponse, GatewaySecurityPolicy> response = networkSecurityClient.ListGatewaySecurityPoliciesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (GatewaySecurityPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListGatewaySecurityPoliciesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (GatewaySecurityPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<GatewaySecurityPolicy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (GatewaySecurityPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGatewaySecurityPolicies</summary>
        public void ListGatewaySecurityPoliciesResourceNames()
        {
            // Snippet: ListGatewaySecurityPolicies(LocationName, string, int?, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListGatewaySecurityPoliciesResponse, GatewaySecurityPolicy> response = networkSecurityClient.ListGatewaySecurityPolicies(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (GatewaySecurityPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListGatewaySecurityPoliciesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (GatewaySecurityPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<GatewaySecurityPolicy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (GatewaySecurityPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGatewaySecurityPoliciesAsync</summary>
        public async Task ListGatewaySecurityPoliciesResourceNamesAsync()
        {
            // Snippet: ListGatewaySecurityPoliciesAsync(LocationName, string, int?, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListGatewaySecurityPoliciesResponse, GatewaySecurityPolicy> response = networkSecurityClient.ListGatewaySecurityPoliciesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (GatewaySecurityPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListGatewaySecurityPoliciesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (GatewaySecurityPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<GatewaySecurityPolicy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (GatewaySecurityPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetGatewaySecurityPolicy</summary>
        public void GetGatewaySecurityPolicyRequestObject()
        {
            // Snippet: GetGatewaySecurityPolicy(GetGatewaySecurityPolicyRequest, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            GetGatewaySecurityPolicyRequest request = new GetGatewaySecurityPolicyRequest
            {
                GatewaySecurityPolicyName = GatewaySecurityPolicyName.FromProjectLocationGatewaySecurityPolicy("[PROJECT]", "[LOCATION]", "[GATEWAY_SECURITY_POLICY]"),
            };
            // Make the request
            GatewaySecurityPolicy response = networkSecurityClient.GetGatewaySecurityPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for GetGatewaySecurityPolicyAsync</summary>
        public async Task GetGatewaySecurityPolicyRequestObjectAsync()
        {
            // Snippet: GetGatewaySecurityPolicyAsync(GetGatewaySecurityPolicyRequest, CallSettings)
            // Additional: GetGatewaySecurityPolicyAsync(GetGatewaySecurityPolicyRequest, CancellationToken)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            GetGatewaySecurityPolicyRequest request = new GetGatewaySecurityPolicyRequest
            {
                GatewaySecurityPolicyName = GatewaySecurityPolicyName.FromProjectLocationGatewaySecurityPolicy("[PROJECT]", "[LOCATION]", "[GATEWAY_SECURITY_POLICY]"),
            };
            // Make the request
            GatewaySecurityPolicy response = await networkSecurityClient.GetGatewaySecurityPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetGatewaySecurityPolicy</summary>
        public void GetGatewaySecurityPolicy()
        {
            // Snippet: GetGatewaySecurityPolicy(string, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/gatewaySecurityPolicies/[GATEWAY_SECURITY_POLICY]";
            // Make the request
            GatewaySecurityPolicy response = networkSecurityClient.GetGatewaySecurityPolicy(name);
            // End snippet
        }

        /// <summary>Snippet for GetGatewaySecurityPolicyAsync</summary>
        public async Task GetGatewaySecurityPolicyAsync()
        {
            // Snippet: GetGatewaySecurityPolicyAsync(string, CallSettings)
            // Additional: GetGatewaySecurityPolicyAsync(string, CancellationToken)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/gatewaySecurityPolicies/[GATEWAY_SECURITY_POLICY]";
            // Make the request
            GatewaySecurityPolicy response = await networkSecurityClient.GetGatewaySecurityPolicyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetGatewaySecurityPolicy</summary>
        public void GetGatewaySecurityPolicyResourceNames()
        {
            // Snippet: GetGatewaySecurityPolicy(GatewaySecurityPolicyName, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            GatewaySecurityPolicyName name = GatewaySecurityPolicyName.FromProjectLocationGatewaySecurityPolicy("[PROJECT]", "[LOCATION]", "[GATEWAY_SECURITY_POLICY]");
            // Make the request
            GatewaySecurityPolicy response = networkSecurityClient.GetGatewaySecurityPolicy(name);
            // End snippet
        }

        /// <summary>Snippet for GetGatewaySecurityPolicyAsync</summary>
        public async Task GetGatewaySecurityPolicyResourceNamesAsync()
        {
            // Snippet: GetGatewaySecurityPolicyAsync(GatewaySecurityPolicyName, CallSettings)
            // Additional: GetGatewaySecurityPolicyAsync(GatewaySecurityPolicyName, CancellationToken)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            GatewaySecurityPolicyName name = GatewaySecurityPolicyName.FromProjectLocationGatewaySecurityPolicy("[PROJECT]", "[LOCATION]", "[GATEWAY_SECURITY_POLICY]");
            // Make the request
            GatewaySecurityPolicy response = await networkSecurityClient.GetGatewaySecurityPolicyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateGatewaySecurityPolicy</summary>
        public void CreateGatewaySecurityPolicyRequestObject()
        {
            // Snippet: CreateGatewaySecurityPolicy(CreateGatewaySecurityPolicyRequest, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            CreateGatewaySecurityPolicyRequest request = new CreateGatewaySecurityPolicyRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                GatewaySecurityPolicyId = "",
                GatewaySecurityPolicy = new GatewaySecurityPolicy(),
            };
            // Make the request
            Operation<GatewaySecurityPolicy, OperationMetadata> response = networkSecurityClient.CreateGatewaySecurityPolicy(request);

            // Poll until the returned long-running operation is complete
            Operation<GatewaySecurityPolicy, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            GatewaySecurityPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GatewaySecurityPolicy, OperationMetadata> retrievedResponse = networkSecurityClient.PollOnceCreateGatewaySecurityPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GatewaySecurityPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateGatewaySecurityPolicyAsync</summary>
        public async Task CreateGatewaySecurityPolicyRequestObjectAsync()
        {
            // Snippet: CreateGatewaySecurityPolicyAsync(CreateGatewaySecurityPolicyRequest, CallSettings)
            // Additional: CreateGatewaySecurityPolicyAsync(CreateGatewaySecurityPolicyRequest, CancellationToken)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            CreateGatewaySecurityPolicyRequest request = new CreateGatewaySecurityPolicyRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                GatewaySecurityPolicyId = "",
                GatewaySecurityPolicy = new GatewaySecurityPolicy(),
            };
            // Make the request
            Operation<GatewaySecurityPolicy, OperationMetadata> response = await networkSecurityClient.CreateGatewaySecurityPolicyAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<GatewaySecurityPolicy, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            GatewaySecurityPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GatewaySecurityPolicy, OperationMetadata> retrievedResponse = await networkSecurityClient.PollOnceCreateGatewaySecurityPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GatewaySecurityPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateGatewaySecurityPolicy</summary>
        public void CreateGatewaySecurityPolicy()
        {
            // Snippet: CreateGatewaySecurityPolicy(string, GatewaySecurityPolicy, string, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            GatewaySecurityPolicy gatewaySecurityPolicy = new GatewaySecurityPolicy();
            string gatewaySecurityPolicyId = "";
            // Make the request
            Operation<GatewaySecurityPolicy, OperationMetadata> response = networkSecurityClient.CreateGatewaySecurityPolicy(parent, gatewaySecurityPolicy, gatewaySecurityPolicyId);

            // Poll until the returned long-running operation is complete
            Operation<GatewaySecurityPolicy, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            GatewaySecurityPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GatewaySecurityPolicy, OperationMetadata> retrievedResponse = networkSecurityClient.PollOnceCreateGatewaySecurityPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GatewaySecurityPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateGatewaySecurityPolicyAsync</summary>
        public async Task CreateGatewaySecurityPolicyAsync()
        {
            // Snippet: CreateGatewaySecurityPolicyAsync(string, GatewaySecurityPolicy, string, CallSettings)
            // Additional: CreateGatewaySecurityPolicyAsync(string, GatewaySecurityPolicy, string, CancellationToken)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            GatewaySecurityPolicy gatewaySecurityPolicy = new GatewaySecurityPolicy();
            string gatewaySecurityPolicyId = "";
            // Make the request
            Operation<GatewaySecurityPolicy, OperationMetadata> response = await networkSecurityClient.CreateGatewaySecurityPolicyAsync(parent, gatewaySecurityPolicy, gatewaySecurityPolicyId);

            // Poll until the returned long-running operation is complete
            Operation<GatewaySecurityPolicy, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            GatewaySecurityPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GatewaySecurityPolicy, OperationMetadata> retrievedResponse = await networkSecurityClient.PollOnceCreateGatewaySecurityPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GatewaySecurityPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateGatewaySecurityPolicy</summary>
        public void CreateGatewaySecurityPolicyResourceNames()
        {
            // Snippet: CreateGatewaySecurityPolicy(LocationName, GatewaySecurityPolicy, string, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            GatewaySecurityPolicy gatewaySecurityPolicy = new GatewaySecurityPolicy();
            string gatewaySecurityPolicyId = "";
            // Make the request
            Operation<GatewaySecurityPolicy, OperationMetadata> response = networkSecurityClient.CreateGatewaySecurityPolicy(parent, gatewaySecurityPolicy, gatewaySecurityPolicyId);

            // Poll until the returned long-running operation is complete
            Operation<GatewaySecurityPolicy, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            GatewaySecurityPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GatewaySecurityPolicy, OperationMetadata> retrievedResponse = networkSecurityClient.PollOnceCreateGatewaySecurityPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GatewaySecurityPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateGatewaySecurityPolicyAsync</summary>
        public async Task CreateGatewaySecurityPolicyResourceNamesAsync()
        {
            // Snippet: CreateGatewaySecurityPolicyAsync(LocationName, GatewaySecurityPolicy, string, CallSettings)
            // Additional: CreateGatewaySecurityPolicyAsync(LocationName, GatewaySecurityPolicy, string, CancellationToken)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            GatewaySecurityPolicy gatewaySecurityPolicy = new GatewaySecurityPolicy();
            string gatewaySecurityPolicyId = "";
            // Make the request
            Operation<GatewaySecurityPolicy, OperationMetadata> response = await networkSecurityClient.CreateGatewaySecurityPolicyAsync(parent, gatewaySecurityPolicy, gatewaySecurityPolicyId);

            // Poll until the returned long-running operation is complete
            Operation<GatewaySecurityPolicy, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            GatewaySecurityPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GatewaySecurityPolicy, OperationMetadata> retrievedResponse = await networkSecurityClient.PollOnceCreateGatewaySecurityPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GatewaySecurityPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateGatewaySecurityPolicy</summary>
        public void UpdateGatewaySecurityPolicyRequestObject()
        {
            // Snippet: UpdateGatewaySecurityPolicy(UpdateGatewaySecurityPolicyRequest, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            UpdateGatewaySecurityPolicyRequest request = new UpdateGatewaySecurityPolicyRequest
            {
                UpdateMask = new FieldMask(),
                GatewaySecurityPolicy = new GatewaySecurityPolicy(),
            };
            // Make the request
            Operation<GatewaySecurityPolicy, OperationMetadata> response = networkSecurityClient.UpdateGatewaySecurityPolicy(request);

            // Poll until the returned long-running operation is complete
            Operation<GatewaySecurityPolicy, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            GatewaySecurityPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GatewaySecurityPolicy, OperationMetadata> retrievedResponse = networkSecurityClient.PollOnceUpdateGatewaySecurityPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GatewaySecurityPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateGatewaySecurityPolicyAsync</summary>
        public async Task UpdateGatewaySecurityPolicyRequestObjectAsync()
        {
            // Snippet: UpdateGatewaySecurityPolicyAsync(UpdateGatewaySecurityPolicyRequest, CallSettings)
            // Additional: UpdateGatewaySecurityPolicyAsync(UpdateGatewaySecurityPolicyRequest, CancellationToken)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            UpdateGatewaySecurityPolicyRequest request = new UpdateGatewaySecurityPolicyRequest
            {
                UpdateMask = new FieldMask(),
                GatewaySecurityPolicy = new GatewaySecurityPolicy(),
            };
            // Make the request
            Operation<GatewaySecurityPolicy, OperationMetadata> response = await networkSecurityClient.UpdateGatewaySecurityPolicyAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<GatewaySecurityPolicy, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            GatewaySecurityPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GatewaySecurityPolicy, OperationMetadata> retrievedResponse = await networkSecurityClient.PollOnceUpdateGatewaySecurityPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GatewaySecurityPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateGatewaySecurityPolicy</summary>
        public void UpdateGatewaySecurityPolicy()
        {
            // Snippet: UpdateGatewaySecurityPolicy(GatewaySecurityPolicy, FieldMask, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            GatewaySecurityPolicy gatewaySecurityPolicy = new GatewaySecurityPolicy();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<GatewaySecurityPolicy, OperationMetadata> response = networkSecurityClient.UpdateGatewaySecurityPolicy(gatewaySecurityPolicy, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<GatewaySecurityPolicy, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            GatewaySecurityPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GatewaySecurityPolicy, OperationMetadata> retrievedResponse = networkSecurityClient.PollOnceUpdateGatewaySecurityPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GatewaySecurityPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateGatewaySecurityPolicyAsync</summary>
        public async Task UpdateGatewaySecurityPolicyAsync()
        {
            // Snippet: UpdateGatewaySecurityPolicyAsync(GatewaySecurityPolicy, FieldMask, CallSettings)
            // Additional: UpdateGatewaySecurityPolicyAsync(GatewaySecurityPolicy, FieldMask, CancellationToken)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            GatewaySecurityPolicy gatewaySecurityPolicy = new GatewaySecurityPolicy();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<GatewaySecurityPolicy, OperationMetadata> response = await networkSecurityClient.UpdateGatewaySecurityPolicyAsync(gatewaySecurityPolicy, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<GatewaySecurityPolicy, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            GatewaySecurityPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GatewaySecurityPolicy, OperationMetadata> retrievedResponse = await networkSecurityClient.PollOnceUpdateGatewaySecurityPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GatewaySecurityPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteGatewaySecurityPolicy</summary>
        public void DeleteGatewaySecurityPolicyRequestObject()
        {
            // Snippet: DeleteGatewaySecurityPolicy(DeleteGatewaySecurityPolicyRequest, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            DeleteGatewaySecurityPolicyRequest request = new DeleteGatewaySecurityPolicyRequest
            {
                GatewaySecurityPolicyName = GatewaySecurityPolicyName.FromProjectLocationGatewaySecurityPolicy("[PROJECT]", "[LOCATION]", "[GATEWAY_SECURITY_POLICY]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = networkSecurityClient.DeleteGatewaySecurityPolicy(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = networkSecurityClient.PollOnceDeleteGatewaySecurityPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteGatewaySecurityPolicyAsync</summary>
        public async Task DeleteGatewaySecurityPolicyRequestObjectAsync()
        {
            // Snippet: DeleteGatewaySecurityPolicyAsync(DeleteGatewaySecurityPolicyRequest, CallSettings)
            // Additional: DeleteGatewaySecurityPolicyAsync(DeleteGatewaySecurityPolicyRequest, CancellationToken)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            DeleteGatewaySecurityPolicyRequest request = new DeleteGatewaySecurityPolicyRequest
            {
                GatewaySecurityPolicyName = GatewaySecurityPolicyName.FromProjectLocationGatewaySecurityPolicy("[PROJECT]", "[LOCATION]", "[GATEWAY_SECURITY_POLICY]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await networkSecurityClient.DeleteGatewaySecurityPolicyAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await networkSecurityClient.PollOnceDeleteGatewaySecurityPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteGatewaySecurityPolicy</summary>
        public void DeleteGatewaySecurityPolicy()
        {
            // Snippet: DeleteGatewaySecurityPolicy(string, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/gatewaySecurityPolicies/[GATEWAY_SECURITY_POLICY]";
            // Make the request
            Operation<Empty, OperationMetadata> response = networkSecurityClient.DeleteGatewaySecurityPolicy(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = networkSecurityClient.PollOnceDeleteGatewaySecurityPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteGatewaySecurityPolicyAsync</summary>
        public async Task DeleteGatewaySecurityPolicyAsync()
        {
            // Snippet: DeleteGatewaySecurityPolicyAsync(string, CallSettings)
            // Additional: DeleteGatewaySecurityPolicyAsync(string, CancellationToken)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/gatewaySecurityPolicies/[GATEWAY_SECURITY_POLICY]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await networkSecurityClient.DeleteGatewaySecurityPolicyAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await networkSecurityClient.PollOnceDeleteGatewaySecurityPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteGatewaySecurityPolicy</summary>
        public void DeleteGatewaySecurityPolicyResourceNames()
        {
            // Snippet: DeleteGatewaySecurityPolicy(GatewaySecurityPolicyName, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            GatewaySecurityPolicyName name = GatewaySecurityPolicyName.FromProjectLocationGatewaySecurityPolicy("[PROJECT]", "[LOCATION]", "[GATEWAY_SECURITY_POLICY]");
            // Make the request
            Operation<Empty, OperationMetadata> response = networkSecurityClient.DeleteGatewaySecurityPolicy(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = networkSecurityClient.PollOnceDeleteGatewaySecurityPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteGatewaySecurityPolicyAsync</summary>
        public async Task DeleteGatewaySecurityPolicyResourceNamesAsync()
        {
            // Snippet: DeleteGatewaySecurityPolicyAsync(GatewaySecurityPolicyName, CallSettings)
            // Additional: DeleteGatewaySecurityPolicyAsync(GatewaySecurityPolicyName, CancellationToken)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            GatewaySecurityPolicyName name = GatewaySecurityPolicyName.FromProjectLocationGatewaySecurityPolicy("[PROJECT]", "[LOCATION]", "[GATEWAY_SECURITY_POLICY]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await networkSecurityClient.DeleteGatewaySecurityPolicyAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await networkSecurityClient.PollOnceDeleteGatewaySecurityPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListGatewaySecurityPolicyRules</summary>
        public void ListGatewaySecurityPolicyRulesRequestObject()
        {
            // Snippet: ListGatewaySecurityPolicyRules(ListGatewaySecurityPolicyRulesRequest, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            ListGatewaySecurityPolicyRulesRequest request = new ListGatewaySecurityPolicyRulesRequest
            {
                ParentAsGatewaySecurityPolicyName = GatewaySecurityPolicyName.FromProjectLocationGatewaySecurityPolicy("[PROJECT]", "[LOCATION]", "[GATEWAY_SECURITY_POLICY]"),
            };
            // Make the request
            PagedEnumerable<ListGatewaySecurityPolicyRulesResponse, GatewaySecurityPolicyRule> response = networkSecurityClient.ListGatewaySecurityPolicyRules(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (GatewaySecurityPolicyRule item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListGatewaySecurityPolicyRulesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (GatewaySecurityPolicyRule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<GatewaySecurityPolicyRule> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (GatewaySecurityPolicyRule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGatewaySecurityPolicyRulesAsync</summary>
        public async Task ListGatewaySecurityPolicyRulesRequestObjectAsync()
        {
            // Snippet: ListGatewaySecurityPolicyRulesAsync(ListGatewaySecurityPolicyRulesRequest, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            ListGatewaySecurityPolicyRulesRequest request = new ListGatewaySecurityPolicyRulesRequest
            {
                ParentAsGatewaySecurityPolicyName = GatewaySecurityPolicyName.FromProjectLocationGatewaySecurityPolicy("[PROJECT]", "[LOCATION]", "[GATEWAY_SECURITY_POLICY]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListGatewaySecurityPolicyRulesResponse, GatewaySecurityPolicyRule> response = networkSecurityClient.ListGatewaySecurityPolicyRulesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (GatewaySecurityPolicyRule item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListGatewaySecurityPolicyRulesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (GatewaySecurityPolicyRule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<GatewaySecurityPolicyRule> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (GatewaySecurityPolicyRule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGatewaySecurityPolicyRules</summary>
        public void ListGatewaySecurityPolicyRules()
        {
            // Snippet: ListGatewaySecurityPolicyRules(string, string, int?, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/gatewaySecurityPolicies/[GATEWAY_SECURITY_POLICY]";
            // Make the request
            PagedEnumerable<ListGatewaySecurityPolicyRulesResponse, GatewaySecurityPolicyRule> response = networkSecurityClient.ListGatewaySecurityPolicyRules(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (GatewaySecurityPolicyRule item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListGatewaySecurityPolicyRulesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (GatewaySecurityPolicyRule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<GatewaySecurityPolicyRule> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (GatewaySecurityPolicyRule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGatewaySecurityPolicyRulesAsync</summary>
        public async Task ListGatewaySecurityPolicyRulesAsync()
        {
            // Snippet: ListGatewaySecurityPolicyRulesAsync(string, string, int?, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/gatewaySecurityPolicies/[GATEWAY_SECURITY_POLICY]";
            // Make the request
            PagedAsyncEnumerable<ListGatewaySecurityPolicyRulesResponse, GatewaySecurityPolicyRule> response = networkSecurityClient.ListGatewaySecurityPolicyRulesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (GatewaySecurityPolicyRule item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListGatewaySecurityPolicyRulesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (GatewaySecurityPolicyRule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<GatewaySecurityPolicyRule> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (GatewaySecurityPolicyRule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGatewaySecurityPolicyRules</summary>
        public void ListGatewaySecurityPolicyRulesResourceNames()
        {
            // Snippet: ListGatewaySecurityPolicyRules(GatewaySecurityPolicyName, string, int?, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            GatewaySecurityPolicyName parent = GatewaySecurityPolicyName.FromProjectLocationGatewaySecurityPolicy("[PROJECT]", "[LOCATION]", "[GATEWAY_SECURITY_POLICY]");
            // Make the request
            PagedEnumerable<ListGatewaySecurityPolicyRulesResponse, GatewaySecurityPolicyRule> response = networkSecurityClient.ListGatewaySecurityPolicyRules(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (GatewaySecurityPolicyRule item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListGatewaySecurityPolicyRulesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (GatewaySecurityPolicyRule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<GatewaySecurityPolicyRule> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (GatewaySecurityPolicyRule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGatewaySecurityPolicyRulesAsync</summary>
        public async Task ListGatewaySecurityPolicyRulesResourceNamesAsync()
        {
            // Snippet: ListGatewaySecurityPolicyRulesAsync(GatewaySecurityPolicyName, string, int?, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            GatewaySecurityPolicyName parent = GatewaySecurityPolicyName.FromProjectLocationGatewaySecurityPolicy("[PROJECT]", "[LOCATION]", "[GATEWAY_SECURITY_POLICY]");
            // Make the request
            PagedAsyncEnumerable<ListGatewaySecurityPolicyRulesResponse, GatewaySecurityPolicyRule> response = networkSecurityClient.ListGatewaySecurityPolicyRulesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (GatewaySecurityPolicyRule item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListGatewaySecurityPolicyRulesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (GatewaySecurityPolicyRule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<GatewaySecurityPolicyRule> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (GatewaySecurityPolicyRule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetGatewaySecurityPolicyRule</summary>
        public void GetGatewaySecurityPolicyRuleRequestObject()
        {
            // Snippet: GetGatewaySecurityPolicyRule(GetGatewaySecurityPolicyRuleRequest, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            GetGatewaySecurityPolicyRuleRequest request = new GetGatewaySecurityPolicyRuleRequest
            {
                GatewaySecurityPolicyRuleName = GatewaySecurityPolicyRuleName.FromProjectLocationGatewaySecurityPolicyRule("[PROJECT]", "[LOCATION]", "[GATEWAY_SECURITY_POLICY]", "[RULE]"),
            };
            // Make the request
            GatewaySecurityPolicyRule response = networkSecurityClient.GetGatewaySecurityPolicyRule(request);
            // End snippet
        }

        /// <summary>Snippet for GetGatewaySecurityPolicyRuleAsync</summary>
        public async Task GetGatewaySecurityPolicyRuleRequestObjectAsync()
        {
            // Snippet: GetGatewaySecurityPolicyRuleAsync(GetGatewaySecurityPolicyRuleRequest, CallSettings)
            // Additional: GetGatewaySecurityPolicyRuleAsync(GetGatewaySecurityPolicyRuleRequest, CancellationToken)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            GetGatewaySecurityPolicyRuleRequest request = new GetGatewaySecurityPolicyRuleRequest
            {
                GatewaySecurityPolicyRuleName = GatewaySecurityPolicyRuleName.FromProjectLocationGatewaySecurityPolicyRule("[PROJECT]", "[LOCATION]", "[GATEWAY_SECURITY_POLICY]", "[RULE]"),
            };
            // Make the request
            GatewaySecurityPolicyRule response = await networkSecurityClient.GetGatewaySecurityPolicyRuleAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetGatewaySecurityPolicyRule</summary>
        public void GetGatewaySecurityPolicyRule()
        {
            // Snippet: GetGatewaySecurityPolicyRule(string, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/gatewaySecurityPolicies/[GATEWAY_SECURITY_POLICY]/rules/[RULE]";
            // Make the request
            GatewaySecurityPolicyRule response = networkSecurityClient.GetGatewaySecurityPolicyRule(name);
            // End snippet
        }

        /// <summary>Snippet for GetGatewaySecurityPolicyRuleAsync</summary>
        public async Task GetGatewaySecurityPolicyRuleAsync()
        {
            // Snippet: GetGatewaySecurityPolicyRuleAsync(string, CallSettings)
            // Additional: GetGatewaySecurityPolicyRuleAsync(string, CancellationToken)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/gatewaySecurityPolicies/[GATEWAY_SECURITY_POLICY]/rules/[RULE]";
            // Make the request
            GatewaySecurityPolicyRule response = await networkSecurityClient.GetGatewaySecurityPolicyRuleAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetGatewaySecurityPolicyRule</summary>
        public void GetGatewaySecurityPolicyRuleResourceNames()
        {
            // Snippet: GetGatewaySecurityPolicyRule(GatewaySecurityPolicyRuleName, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            GatewaySecurityPolicyRuleName name = GatewaySecurityPolicyRuleName.FromProjectLocationGatewaySecurityPolicyRule("[PROJECT]", "[LOCATION]", "[GATEWAY_SECURITY_POLICY]", "[RULE]");
            // Make the request
            GatewaySecurityPolicyRule response = networkSecurityClient.GetGatewaySecurityPolicyRule(name);
            // End snippet
        }

        /// <summary>Snippet for GetGatewaySecurityPolicyRuleAsync</summary>
        public async Task GetGatewaySecurityPolicyRuleResourceNamesAsync()
        {
            // Snippet: GetGatewaySecurityPolicyRuleAsync(GatewaySecurityPolicyRuleName, CallSettings)
            // Additional: GetGatewaySecurityPolicyRuleAsync(GatewaySecurityPolicyRuleName, CancellationToken)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            GatewaySecurityPolicyRuleName name = GatewaySecurityPolicyRuleName.FromProjectLocationGatewaySecurityPolicyRule("[PROJECT]", "[LOCATION]", "[GATEWAY_SECURITY_POLICY]", "[RULE]");
            // Make the request
            GatewaySecurityPolicyRule response = await networkSecurityClient.GetGatewaySecurityPolicyRuleAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateGatewaySecurityPolicyRule</summary>
        public void CreateGatewaySecurityPolicyRuleRequestObject()
        {
            // Snippet: CreateGatewaySecurityPolicyRule(CreateGatewaySecurityPolicyRuleRequest, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            CreateGatewaySecurityPolicyRuleRequest request = new CreateGatewaySecurityPolicyRuleRequest
            {
                ParentAsGatewaySecurityPolicyName = GatewaySecurityPolicyName.FromProjectLocationGatewaySecurityPolicy("[PROJECT]", "[LOCATION]", "[GATEWAY_SECURITY_POLICY]"),
                GatewaySecurityPolicyRule = new GatewaySecurityPolicyRule(),
                GatewaySecurityPolicyRuleId = "",
            };
            // Make the request
            Operation<GatewaySecurityPolicyRule, OperationMetadata> response = networkSecurityClient.CreateGatewaySecurityPolicyRule(request);

            // Poll until the returned long-running operation is complete
            Operation<GatewaySecurityPolicyRule, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            GatewaySecurityPolicyRule result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GatewaySecurityPolicyRule, OperationMetadata> retrievedResponse = networkSecurityClient.PollOnceCreateGatewaySecurityPolicyRule(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GatewaySecurityPolicyRule retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateGatewaySecurityPolicyRuleAsync</summary>
        public async Task CreateGatewaySecurityPolicyRuleRequestObjectAsync()
        {
            // Snippet: CreateGatewaySecurityPolicyRuleAsync(CreateGatewaySecurityPolicyRuleRequest, CallSettings)
            // Additional: CreateGatewaySecurityPolicyRuleAsync(CreateGatewaySecurityPolicyRuleRequest, CancellationToken)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            CreateGatewaySecurityPolicyRuleRequest request = new CreateGatewaySecurityPolicyRuleRequest
            {
                ParentAsGatewaySecurityPolicyName = GatewaySecurityPolicyName.FromProjectLocationGatewaySecurityPolicy("[PROJECT]", "[LOCATION]", "[GATEWAY_SECURITY_POLICY]"),
                GatewaySecurityPolicyRule = new GatewaySecurityPolicyRule(),
                GatewaySecurityPolicyRuleId = "",
            };
            // Make the request
            Operation<GatewaySecurityPolicyRule, OperationMetadata> response = await networkSecurityClient.CreateGatewaySecurityPolicyRuleAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<GatewaySecurityPolicyRule, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            GatewaySecurityPolicyRule result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GatewaySecurityPolicyRule, OperationMetadata> retrievedResponse = await networkSecurityClient.PollOnceCreateGatewaySecurityPolicyRuleAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GatewaySecurityPolicyRule retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateGatewaySecurityPolicyRule</summary>
        public void CreateGatewaySecurityPolicyRule()
        {
            // Snippet: CreateGatewaySecurityPolicyRule(string, GatewaySecurityPolicyRule, string, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/gatewaySecurityPolicies/[GATEWAY_SECURITY_POLICY]";
            GatewaySecurityPolicyRule gatewaySecurityPolicyRule = new GatewaySecurityPolicyRule();
            string gatewaySecurityPolicyRuleId = "";
            // Make the request
            Operation<GatewaySecurityPolicyRule, OperationMetadata> response = networkSecurityClient.CreateGatewaySecurityPolicyRule(parent, gatewaySecurityPolicyRule, gatewaySecurityPolicyRuleId);

            // Poll until the returned long-running operation is complete
            Operation<GatewaySecurityPolicyRule, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            GatewaySecurityPolicyRule result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GatewaySecurityPolicyRule, OperationMetadata> retrievedResponse = networkSecurityClient.PollOnceCreateGatewaySecurityPolicyRule(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GatewaySecurityPolicyRule retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateGatewaySecurityPolicyRuleAsync</summary>
        public async Task CreateGatewaySecurityPolicyRuleAsync()
        {
            // Snippet: CreateGatewaySecurityPolicyRuleAsync(string, GatewaySecurityPolicyRule, string, CallSettings)
            // Additional: CreateGatewaySecurityPolicyRuleAsync(string, GatewaySecurityPolicyRule, string, CancellationToken)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/gatewaySecurityPolicies/[GATEWAY_SECURITY_POLICY]";
            GatewaySecurityPolicyRule gatewaySecurityPolicyRule = new GatewaySecurityPolicyRule();
            string gatewaySecurityPolicyRuleId = "";
            // Make the request
            Operation<GatewaySecurityPolicyRule, OperationMetadata> response = await networkSecurityClient.CreateGatewaySecurityPolicyRuleAsync(parent, gatewaySecurityPolicyRule, gatewaySecurityPolicyRuleId);

            // Poll until the returned long-running operation is complete
            Operation<GatewaySecurityPolicyRule, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            GatewaySecurityPolicyRule result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GatewaySecurityPolicyRule, OperationMetadata> retrievedResponse = await networkSecurityClient.PollOnceCreateGatewaySecurityPolicyRuleAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GatewaySecurityPolicyRule retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateGatewaySecurityPolicyRule</summary>
        public void CreateGatewaySecurityPolicyRuleResourceNames()
        {
            // Snippet: CreateGatewaySecurityPolicyRule(GatewaySecurityPolicyName, GatewaySecurityPolicyRule, string, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            GatewaySecurityPolicyName parent = GatewaySecurityPolicyName.FromProjectLocationGatewaySecurityPolicy("[PROJECT]", "[LOCATION]", "[GATEWAY_SECURITY_POLICY]");
            GatewaySecurityPolicyRule gatewaySecurityPolicyRule = new GatewaySecurityPolicyRule();
            string gatewaySecurityPolicyRuleId = "";
            // Make the request
            Operation<GatewaySecurityPolicyRule, OperationMetadata> response = networkSecurityClient.CreateGatewaySecurityPolicyRule(parent, gatewaySecurityPolicyRule, gatewaySecurityPolicyRuleId);

            // Poll until the returned long-running operation is complete
            Operation<GatewaySecurityPolicyRule, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            GatewaySecurityPolicyRule result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GatewaySecurityPolicyRule, OperationMetadata> retrievedResponse = networkSecurityClient.PollOnceCreateGatewaySecurityPolicyRule(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GatewaySecurityPolicyRule retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateGatewaySecurityPolicyRuleAsync</summary>
        public async Task CreateGatewaySecurityPolicyRuleResourceNamesAsync()
        {
            // Snippet: CreateGatewaySecurityPolicyRuleAsync(GatewaySecurityPolicyName, GatewaySecurityPolicyRule, string, CallSettings)
            // Additional: CreateGatewaySecurityPolicyRuleAsync(GatewaySecurityPolicyName, GatewaySecurityPolicyRule, string, CancellationToken)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            GatewaySecurityPolicyName parent = GatewaySecurityPolicyName.FromProjectLocationGatewaySecurityPolicy("[PROJECT]", "[LOCATION]", "[GATEWAY_SECURITY_POLICY]");
            GatewaySecurityPolicyRule gatewaySecurityPolicyRule = new GatewaySecurityPolicyRule();
            string gatewaySecurityPolicyRuleId = "";
            // Make the request
            Operation<GatewaySecurityPolicyRule, OperationMetadata> response = await networkSecurityClient.CreateGatewaySecurityPolicyRuleAsync(parent, gatewaySecurityPolicyRule, gatewaySecurityPolicyRuleId);

            // Poll until the returned long-running operation is complete
            Operation<GatewaySecurityPolicyRule, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            GatewaySecurityPolicyRule result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GatewaySecurityPolicyRule, OperationMetadata> retrievedResponse = await networkSecurityClient.PollOnceCreateGatewaySecurityPolicyRuleAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GatewaySecurityPolicyRule retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateGatewaySecurityPolicyRule</summary>
        public void UpdateGatewaySecurityPolicyRuleRequestObject()
        {
            // Snippet: UpdateGatewaySecurityPolicyRule(UpdateGatewaySecurityPolicyRuleRequest, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            UpdateGatewaySecurityPolicyRuleRequest request = new UpdateGatewaySecurityPolicyRuleRequest
            {
                UpdateMask = new FieldMask(),
                GatewaySecurityPolicyRule = new GatewaySecurityPolicyRule(),
            };
            // Make the request
            Operation<GatewaySecurityPolicyRule, OperationMetadata> response = networkSecurityClient.UpdateGatewaySecurityPolicyRule(request);

            // Poll until the returned long-running operation is complete
            Operation<GatewaySecurityPolicyRule, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            GatewaySecurityPolicyRule result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GatewaySecurityPolicyRule, OperationMetadata> retrievedResponse = networkSecurityClient.PollOnceUpdateGatewaySecurityPolicyRule(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GatewaySecurityPolicyRule retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateGatewaySecurityPolicyRuleAsync</summary>
        public async Task UpdateGatewaySecurityPolicyRuleRequestObjectAsync()
        {
            // Snippet: UpdateGatewaySecurityPolicyRuleAsync(UpdateGatewaySecurityPolicyRuleRequest, CallSettings)
            // Additional: UpdateGatewaySecurityPolicyRuleAsync(UpdateGatewaySecurityPolicyRuleRequest, CancellationToken)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            UpdateGatewaySecurityPolicyRuleRequest request = new UpdateGatewaySecurityPolicyRuleRequest
            {
                UpdateMask = new FieldMask(),
                GatewaySecurityPolicyRule = new GatewaySecurityPolicyRule(),
            };
            // Make the request
            Operation<GatewaySecurityPolicyRule, OperationMetadata> response = await networkSecurityClient.UpdateGatewaySecurityPolicyRuleAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<GatewaySecurityPolicyRule, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            GatewaySecurityPolicyRule result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GatewaySecurityPolicyRule, OperationMetadata> retrievedResponse = await networkSecurityClient.PollOnceUpdateGatewaySecurityPolicyRuleAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GatewaySecurityPolicyRule retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateGatewaySecurityPolicyRule</summary>
        public void UpdateGatewaySecurityPolicyRule()
        {
            // Snippet: UpdateGatewaySecurityPolicyRule(GatewaySecurityPolicyRule, FieldMask, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            GatewaySecurityPolicyRule gatewaySecurityPolicyRule = new GatewaySecurityPolicyRule();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<GatewaySecurityPolicyRule, OperationMetadata> response = networkSecurityClient.UpdateGatewaySecurityPolicyRule(gatewaySecurityPolicyRule, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<GatewaySecurityPolicyRule, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            GatewaySecurityPolicyRule result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GatewaySecurityPolicyRule, OperationMetadata> retrievedResponse = networkSecurityClient.PollOnceUpdateGatewaySecurityPolicyRule(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GatewaySecurityPolicyRule retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateGatewaySecurityPolicyRuleAsync</summary>
        public async Task UpdateGatewaySecurityPolicyRuleAsync()
        {
            // Snippet: UpdateGatewaySecurityPolicyRuleAsync(GatewaySecurityPolicyRule, FieldMask, CallSettings)
            // Additional: UpdateGatewaySecurityPolicyRuleAsync(GatewaySecurityPolicyRule, FieldMask, CancellationToken)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            GatewaySecurityPolicyRule gatewaySecurityPolicyRule = new GatewaySecurityPolicyRule();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<GatewaySecurityPolicyRule, OperationMetadata> response = await networkSecurityClient.UpdateGatewaySecurityPolicyRuleAsync(gatewaySecurityPolicyRule, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<GatewaySecurityPolicyRule, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            GatewaySecurityPolicyRule result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GatewaySecurityPolicyRule, OperationMetadata> retrievedResponse = await networkSecurityClient.PollOnceUpdateGatewaySecurityPolicyRuleAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GatewaySecurityPolicyRule retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteGatewaySecurityPolicyRule</summary>
        public void DeleteGatewaySecurityPolicyRuleRequestObject()
        {
            // Snippet: DeleteGatewaySecurityPolicyRule(DeleteGatewaySecurityPolicyRuleRequest, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            DeleteGatewaySecurityPolicyRuleRequest request = new DeleteGatewaySecurityPolicyRuleRequest
            {
                GatewaySecurityPolicyRuleName = GatewaySecurityPolicyRuleName.FromProjectLocationGatewaySecurityPolicyRule("[PROJECT]", "[LOCATION]", "[GATEWAY_SECURITY_POLICY]", "[RULE]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = networkSecurityClient.DeleteGatewaySecurityPolicyRule(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = networkSecurityClient.PollOnceDeleteGatewaySecurityPolicyRule(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteGatewaySecurityPolicyRuleAsync</summary>
        public async Task DeleteGatewaySecurityPolicyRuleRequestObjectAsync()
        {
            // Snippet: DeleteGatewaySecurityPolicyRuleAsync(DeleteGatewaySecurityPolicyRuleRequest, CallSettings)
            // Additional: DeleteGatewaySecurityPolicyRuleAsync(DeleteGatewaySecurityPolicyRuleRequest, CancellationToken)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            DeleteGatewaySecurityPolicyRuleRequest request = new DeleteGatewaySecurityPolicyRuleRequest
            {
                GatewaySecurityPolicyRuleName = GatewaySecurityPolicyRuleName.FromProjectLocationGatewaySecurityPolicyRule("[PROJECT]", "[LOCATION]", "[GATEWAY_SECURITY_POLICY]", "[RULE]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await networkSecurityClient.DeleteGatewaySecurityPolicyRuleAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await networkSecurityClient.PollOnceDeleteGatewaySecurityPolicyRuleAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteGatewaySecurityPolicyRule</summary>
        public void DeleteGatewaySecurityPolicyRule()
        {
            // Snippet: DeleteGatewaySecurityPolicyRule(string, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/gatewaySecurityPolicies/[GATEWAY_SECURITY_POLICY]/rules/[RULE]";
            // Make the request
            Operation<Empty, OperationMetadata> response = networkSecurityClient.DeleteGatewaySecurityPolicyRule(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = networkSecurityClient.PollOnceDeleteGatewaySecurityPolicyRule(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteGatewaySecurityPolicyRuleAsync</summary>
        public async Task DeleteGatewaySecurityPolicyRuleAsync()
        {
            // Snippet: DeleteGatewaySecurityPolicyRuleAsync(string, CallSettings)
            // Additional: DeleteGatewaySecurityPolicyRuleAsync(string, CancellationToken)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/gatewaySecurityPolicies/[GATEWAY_SECURITY_POLICY]/rules/[RULE]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await networkSecurityClient.DeleteGatewaySecurityPolicyRuleAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await networkSecurityClient.PollOnceDeleteGatewaySecurityPolicyRuleAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteGatewaySecurityPolicyRule</summary>
        public void DeleteGatewaySecurityPolicyRuleResourceNames()
        {
            // Snippet: DeleteGatewaySecurityPolicyRule(GatewaySecurityPolicyRuleName, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            GatewaySecurityPolicyRuleName name = GatewaySecurityPolicyRuleName.FromProjectLocationGatewaySecurityPolicyRule("[PROJECT]", "[LOCATION]", "[GATEWAY_SECURITY_POLICY]", "[RULE]");
            // Make the request
            Operation<Empty, OperationMetadata> response = networkSecurityClient.DeleteGatewaySecurityPolicyRule(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = networkSecurityClient.PollOnceDeleteGatewaySecurityPolicyRule(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteGatewaySecurityPolicyRuleAsync</summary>
        public async Task DeleteGatewaySecurityPolicyRuleResourceNamesAsync()
        {
            // Snippet: DeleteGatewaySecurityPolicyRuleAsync(GatewaySecurityPolicyRuleName, CallSettings)
            // Additional: DeleteGatewaySecurityPolicyRuleAsync(GatewaySecurityPolicyRuleName, CancellationToken)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            GatewaySecurityPolicyRuleName name = GatewaySecurityPolicyRuleName.FromProjectLocationGatewaySecurityPolicyRule("[PROJECT]", "[LOCATION]", "[GATEWAY_SECURITY_POLICY]", "[RULE]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await networkSecurityClient.DeleteGatewaySecurityPolicyRuleAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await networkSecurityClient.PollOnceDeleteGatewaySecurityPolicyRuleAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListUrlLists</summary>
        public void ListUrlListsRequestObject()
        {
            // Snippet: ListUrlLists(ListUrlListsRequest, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            ListUrlListsRequest request = new ListUrlListsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedEnumerable<ListUrlListsResponse, UrlList> response = networkSecurityClient.ListUrlLists(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (UrlList item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListUrlListsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (UrlList item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<UrlList> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (UrlList item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUrlListsAsync</summary>
        public async Task ListUrlListsRequestObjectAsync()
        {
            // Snippet: ListUrlListsAsync(ListUrlListsRequest, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            ListUrlListsRequest request = new ListUrlListsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListUrlListsResponse, UrlList> response = networkSecurityClient.ListUrlListsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (UrlList item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListUrlListsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (UrlList item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<UrlList> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (UrlList item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUrlLists</summary>
        public void ListUrlLists()
        {
            // Snippet: ListUrlLists(string, string, int?, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListUrlListsResponse, UrlList> response = networkSecurityClient.ListUrlLists(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (UrlList item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListUrlListsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (UrlList item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<UrlList> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (UrlList item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUrlListsAsync</summary>
        public async Task ListUrlListsAsync()
        {
            // Snippet: ListUrlListsAsync(string, string, int?, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListUrlListsResponse, UrlList> response = networkSecurityClient.ListUrlListsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (UrlList item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListUrlListsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (UrlList item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<UrlList> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (UrlList item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUrlLists</summary>
        public void ListUrlListsResourceNames()
        {
            // Snippet: ListUrlLists(LocationName, string, int?, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListUrlListsResponse, UrlList> response = networkSecurityClient.ListUrlLists(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (UrlList item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListUrlListsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (UrlList item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<UrlList> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (UrlList item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUrlListsAsync</summary>
        public async Task ListUrlListsResourceNamesAsync()
        {
            // Snippet: ListUrlListsAsync(LocationName, string, int?, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListUrlListsResponse, UrlList> response = networkSecurityClient.ListUrlListsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (UrlList item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListUrlListsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (UrlList item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<UrlList> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (UrlList item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetUrlList</summary>
        public void GetUrlListRequestObject()
        {
            // Snippet: GetUrlList(GetUrlListRequest, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            GetUrlListRequest request = new GetUrlListRequest
            {
                UrlListName = UrlListName.FromProjectLocationUrlList("[PROJECT]", "[LOCATION]", "[URL_LIST]"),
            };
            // Make the request
            UrlList response = networkSecurityClient.GetUrlList(request);
            // End snippet
        }

        /// <summary>Snippet for GetUrlListAsync</summary>
        public async Task GetUrlListRequestObjectAsync()
        {
            // Snippet: GetUrlListAsync(GetUrlListRequest, CallSettings)
            // Additional: GetUrlListAsync(GetUrlListRequest, CancellationToken)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            GetUrlListRequest request = new GetUrlListRequest
            {
                UrlListName = UrlListName.FromProjectLocationUrlList("[PROJECT]", "[LOCATION]", "[URL_LIST]"),
            };
            // Make the request
            UrlList response = await networkSecurityClient.GetUrlListAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetUrlList</summary>
        public void GetUrlList()
        {
            // Snippet: GetUrlList(string, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/urlLists/[URL_LIST]";
            // Make the request
            UrlList response = networkSecurityClient.GetUrlList(name);
            // End snippet
        }

        /// <summary>Snippet for GetUrlListAsync</summary>
        public async Task GetUrlListAsync()
        {
            // Snippet: GetUrlListAsync(string, CallSettings)
            // Additional: GetUrlListAsync(string, CancellationToken)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/urlLists/[URL_LIST]";
            // Make the request
            UrlList response = await networkSecurityClient.GetUrlListAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetUrlList</summary>
        public void GetUrlListResourceNames()
        {
            // Snippet: GetUrlList(UrlListName, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            UrlListName name = UrlListName.FromProjectLocationUrlList("[PROJECT]", "[LOCATION]", "[URL_LIST]");
            // Make the request
            UrlList response = networkSecurityClient.GetUrlList(name);
            // End snippet
        }

        /// <summary>Snippet for GetUrlListAsync</summary>
        public async Task GetUrlListResourceNamesAsync()
        {
            // Snippet: GetUrlListAsync(UrlListName, CallSettings)
            // Additional: GetUrlListAsync(UrlListName, CancellationToken)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            UrlListName name = UrlListName.FromProjectLocationUrlList("[PROJECT]", "[LOCATION]", "[URL_LIST]");
            // Make the request
            UrlList response = await networkSecurityClient.GetUrlListAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateUrlList</summary>
        public void CreateUrlListRequestObject()
        {
            // Snippet: CreateUrlList(CreateUrlListRequest, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            CreateUrlListRequest request = new CreateUrlListRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                UrlListId = "",
                UrlList = new UrlList(),
            };
            // Make the request
            Operation<UrlList, OperationMetadata> response = networkSecurityClient.CreateUrlList(request);

            // Poll until the returned long-running operation is complete
            Operation<UrlList, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            UrlList result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<UrlList, OperationMetadata> retrievedResponse = networkSecurityClient.PollOnceCreateUrlList(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                UrlList retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateUrlListAsync</summary>
        public async Task CreateUrlListRequestObjectAsync()
        {
            // Snippet: CreateUrlListAsync(CreateUrlListRequest, CallSettings)
            // Additional: CreateUrlListAsync(CreateUrlListRequest, CancellationToken)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            CreateUrlListRequest request = new CreateUrlListRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                UrlListId = "",
                UrlList = new UrlList(),
            };
            // Make the request
            Operation<UrlList, OperationMetadata> response = await networkSecurityClient.CreateUrlListAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<UrlList, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            UrlList result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<UrlList, OperationMetadata> retrievedResponse = await networkSecurityClient.PollOnceCreateUrlListAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                UrlList retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateUrlList</summary>
        public void CreateUrlList()
        {
            // Snippet: CreateUrlList(string, UrlList, string, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            UrlList urlList = new UrlList();
            string urlListId = "";
            // Make the request
            Operation<UrlList, OperationMetadata> response = networkSecurityClient.CreateUrlList(parent, urlList, urlListId);

            // Poll until the returned long-running operation is complete
            Operation<UrlList, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            UrlList result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<UrlList, OperationMetadata> retrievedResponse = networkSecurityClient.PollOnceCreateUrlList(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                UrlList retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateUrlListAsync</summary>
        public async Task CreateUrlListAsync()
        {
            // Snippet: CreateUrlListAsync(string, UrlList, string, CallSettings)
            // Additional: CreateUrlListAsync(string, UrlList, string, CancellationToken)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            UrlList urlList = new UrlList();
            string urlListId = "";
            // Make the request
            Operation<UrlList, OperationMetadata> response = await networkSecurityClient.CreateUrlListAsync(parent, urlList, urlListId);

            // Poll until the returned long-running operation is complete
            Operation<UrlList, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            UrlList result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<UrlList, OperationMetadata> retrievedResponse = await networkSecurityClient.PollOnceCreateUrlListAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                UrlList retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateUrlList</summary>
        public void CreateUrlListResourceNames()
        {
            // Snippet: CreateUrlList(LocationName, UrlList, string, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            UrlList urlList = new UrlList();
            string urlListId = "";
            // Make the request
            Operation<UrlList, OperationMetadata> response = networkSecurityClient.CreateUrlList(parent, urlList, urlListId);

            // Poll until the returned long-running operation is complete
            Operation<UrlList, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            UrlList result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<UrlList, OperationMetadata> retrievedResponse = networkSecurityClient.PollOnceCreateUrlList(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                UrlList retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateUrlListAsync</summary>
        public async Task CreateUrlListResourceNamesAsync()
        {
            // Snippet: CreateUrlListAsync(LocationName, UrlList, string, CallSettings)
            // Additional: CreateUrlListAsync(LocationName, UrlList, string, CancellationToken)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            UrlList urlList = new UrlList();
            string urlListId = "";
            // Make the request
            Operation<UrlList, OperationMetadata> response = await networkSecurityClient.CreateUrlListAsync(parent, urlList, urlListId);

            // Poll until the returned long-running operation is complete
            Operation<UrlList, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            UrlList result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<UrlList, OperationMetadata> retrievedResponse = await networkSecurityClient.PollOnceCreateUrlListAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                UrlList retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateUrlList</summary>
        public void UpdateUrlListRequestObject()
        {
            // Snippet: UpdateUrlList(UpdateUrlListRequest, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            UpdateUrlListRequest request = new UpdateUrlListRequest
            {
                UpdateMask = new FieldMask(),
                UrlList = new UrlList(),
            };
            // Make the request
            Operation<UrlList, OperationMetadata> response = networkSecurityClient.UpdateUrlList(request);

            // Poll until the returned long-running operation is complete
            Operation<UrlList, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            UrlList result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<UrlList, OperationMetadata> retrievedResponse = networkSecurityClient.PollOnceUpdateUrlList(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                UrlList retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateUrlListAsync</summary>
        public async Task UpdateUrlListRequestObjectAsync()
        {
            // Snippet: UpdateUrlListAsync(UpdateUrlListRequest, CallSettings)
            // Additional: UpdateUrlListAsync(UpdateUrlListRequest, CancellationToken)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            UpdateUrlListRequest request = new UpdateUrlListRequest
            {
                UpdateMask = new FieldMask(),
                UrlList = new UrlList(),
            };
            // Make the request
            Operation<UrlList, OperationMetadata> response = await networkSecurityClient.UpdateUrlListAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<UrlList, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            UrlList result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<UrlList, OperationMetadata> retrievedResponse = await networkSecurityClient.PollOnceUpdateUrlListAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                UrlList retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateUrlList</summary>
        public void UpdateUrlList()
        {
            // Snippet: UpdateUrlList(UrlList, FieldMask, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            UrlList urlList = new UrlList();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<UrlList, OperationMetadata> response = networkSecurityClient.UpdateUrlList(urlList, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<UrlList, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            UrlList result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<UrlList, OperationMetadata> retrievedResponse = networkSecurityClient.PollOnceUpdateUrlList(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                UrlList retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateUrlListAsync</summary>
        public async Task UpdateUrlListAsync()
        {
            // Snippet: UpdateUrlListAsync(UrlList, FieldMask, CallSettings)
            // Additional: UpdateUrlListAsync(UrlList, FieldMask, CancellationToken)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            UrlList urlList = new UrlList();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<UrlList, OperationMetadata> response = await networkSecurityClient.UpdateUrlListAsync(urlList, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<UrlList, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            UrlList result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<UrlList, OperationMetadata> retrievedResponse = await networkSecurityClient.PollOnceUpdateUrlListAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                UrlList retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteUrlList</summary>
        public void DeleteUrlListRequestObject()
        {
            // Snippet: DeleteUrlList(DeleteUrlListRequest, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            DeleteUrlListRequest request = new DeleteUrlListRequest
            {
                UrlListName = UrlListName.FromProjectLocationUrlList("[PROJECT]", "[LOCATION]", "[URL_LIST]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = networkSecurityClient.DeleteUrlList(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = networkSecurityClient.PollOnceDeleteUrlList(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteUrlListAsync</summary>
        public async Task DeleteUrlListRequestObjectAsync()
        {
            // Snippet: DeleteUrlListAsync(DeleteUrlListRequest, CallSettings)
            // Additional: DeleteUrlListAsync(DeleteUrlListRequest, CancellationToken)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            DeleteUrlListRequest request = new DeleteUrlListRequest
            {
                UrlListName = UrlListName.FromProjectLocationUrlList("[PROJECT]", "[LOCATION]", "[URL_LIST]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await networkSecurityClient.DeleteUrlListAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await networkSecurityClient.PollOnceDeleteUrlListAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteUrlList</summary>
        public void DeleteUrlList()
        {
            // Snippet: DeleteUrlList(string, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/urlLists/[URL_LIST]";
            // Make the request
            Operation<Empty, OperationMetadata> response = networkSecurityClient.DeleteUrlList(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = networkSecurityClient.PollOnceDeleteUrlList(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteUrlListAsync</summary>
        public async Task DeleteUrlListAsync()
        {
            // Snippet: DeleteUrlListAsync(string, CallSettings)
            // Additional: DeleteUrlListAsync(string, CancellationToken)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/urlLists/[URL_LIST]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await networkSecurityClient.DeleteUrlListAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await networkSecurityClient.PollOnceDeleteUrlListAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteUrlList</summary>
        public void DeleteUrlListResourceNames()
        {
            // Snippet: DeleteUrlList(UrlListName, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            UrlListName name = UrlListName.FromProjectLocationUrlList("[PROJECT]", "[LOCATION]", "[URL_LIST]");
            // Make the request
            Operation<Empty, OperationMetadata> response = networkSecurityClient.DeleteUrlList(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = networkSecurityClient.PollOnceDeleteUrlList(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteUrlListAsync</summary>
        public async Task DeleteUrlListResourceNamesAsync()
        {
            // Snippet: DeleteUrlListAsync(UrlListName, CallSettings)
            // Additional: DeleteUrlListAsync(UrlListName, CancellationToken)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            UrlListName name = UrlListName.FromProjectLocationUrlList("[PROJECT]", "[LOCATION]", "[URL_LIST]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await networkSecurityClient.DeleteUrlListAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await networkSecurityClient.PollOnceDeleteUrlListAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListTlsInspectionPolicies</summary>
        public void ListTlsInspectionPoliciesRequestObject()
        {
            // Snippet: ListTlsInspectionPolicies(ListTlsInspectionPoliciesRequest, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            ListTlsInspectionPoliciesRequest request = new ListTlsInspectionPoliciesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedEnumerable<ListTlsInspectionPoliciesResponse, TlsInspectionPolicy> response = networkSecurityClient.ListTlsInspectionPolicies(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (TlsInspectionPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTlsInspectionPoliciesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TlsInspectionPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TlsInspectionPolicy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TlsInspectionPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTlsInspectionPoliciesAsync</summary>
        public async Task ListTlsInspectionPoliciesRequestObjectAsync()
        {
            // Snippet: ListTlsInspectionPoliciesAsync(ListTlsInspectionPoliciesRequest, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            ListTlsInspectionPoliciesRequest request = new ListTlsInspectionPoliciesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListTlsInspectionPoliciesResponse, TlsInspectionPolicy> response = networkSecurityClient.ListTlsInspectionPoliciesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (TlsInspectionPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListTlsInspectionPoliciesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TlsInspectionPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TlsInspectionPolicy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TlsInspectionPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTlsInspectionPolicies</summary>
        public void ListTlsInspectionPolicies()
        {
            // Snippet: ListTlsInspectionPolicies(string, string, int?, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListTlsInspectionPoliciesResponse, TlsInspectionPolicy> response = networkSecurityClient.ListTlsInspectionPolicies(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (TlsInspectionPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTlsInspectionPoliciesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TlsInspectionPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TlsInspectionPolicy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TlsInspectionPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTlsInspectionPoliciesAsync</summary>
        public async Task ListTlsInspectionPoliciesAsync()
        {
            // Snippet: ListTlsInspectionPoliciesAsync(string, string, int?, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListTlsInspectionPoliciesResponse, TlsInspectionPolicy> response = networkSecurityClient.ListTlsInspectionPoliciesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (TlsInspectionPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListTlsInspectionPoliciesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TlsInspectionPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TlsInspectionPolicy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TlsInspectionPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTlsInspectionPolicies</summary>
        public void ListTlsInspectionPoliciesResourceNames()
        {
            // Snippet: ListTlsInspectionPolicies(LocationName, string, int?, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListTlsInspectionPoliciesResponse, TlsInspectionPolicy> response = networkSecurityClient.ListTlsInspectionPolicies(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (TlsInspectionPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTlsInspectionPoliciesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TlsInspectionPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TlsInspectionPolicy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TlsInspectionPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTlsInspectionPoliciesAsync</summary>
        public async Task ListTlsInspectionPoliciesResourceNamesAsync()
        {
            // Snippet: ListTlsInspectionPoliciesAsync(LocationName, string, int?, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListTlsInspectionPoliciesResponse, TlsInspectionPolicy> response = networkSecurityClient.ListTlsInspectionPoliciesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (TlsInspectionPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListTlsInspectionPoliciesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TlsInspectionPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TlsInspectionPolicy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TlsInspectionPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetTlsInspectionPolicy</summary>
        public void GetTlsInspectionPolicyRequestObject()
        {
            // Snippet: GetTlsInspectionPolicy(GetTlsInspectionPolicyRequest, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            GetTlsInspectionPolicyRequest request = new GetTlsInspectionPolicyRequest
            {
                TlsInspectionPolicyName = TlsInspectionPolicyName.FromProjectLocationTlsInspectionPolicy("[PROJECT]", "[LOCATION]", "[TLS_INSPECTION_POLICY]"),
            };
            // Make the request
            TlsInspectionPolicy response = networkSecurityClient.GetTlsInspectionPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for GetTlsInspectionPolicyAsync</summary>
        public async Task GetTlsInspectionPolicyRequestObjectAsync()
        {
            // Snippet: GetTlsInspectionPolicyAsync(GetTlsInspectionPolicyRequest, CallSettings)
            // Additional: GetTlsInspectionPolicyAsync(GetTlsInspectionPolicyRequest, CancellationToken)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            GetTlsInspectionPolicyRequest request = new GetTlsInspectionPolicyRequest
            {
                TlsInspectionPolicyName = TlsInspectionPolicyName.FromProjectLocationTlsInspectionPolicy("[PROJECT]", "[LOCATION]", "[TLS_INSPECTION_POLICY]"),
            };
            // Make the request
            TlsInspectionPolicy response = await networkSecurityClient.GetTlsInspectionPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetTlsInspectionPolicy</summary>
        public void GetTlsInspectionPolicy()
        {
            // Snippet: GetTlsInspectionPolicy(string, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/tlsInspectionPolicies/[TLS_INSPECTION_POLICY]";
            // Make the request
            TlsInspectionPolicy response = networkSecurityClient.GetTlsInspectionPolicy(name);
            // End snippet
        }

        /// <summary>Snippet for GetTlsInspectionPolicyAsync</summary>
        public async Task GetTlsInspectionPolicyAsync()
        {
            // Snippet: GetTlsInspectionPolicyAsync(string, CallSettings)
            // Additional: GetTlsInspectionPolicyAsync(string, CancellationToken)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/tlsInspectionPolicies/[TLS_INSPECTION_POLICY]";
            // Make the request
            TlsInspectionPolicy response = await networkSecurityClient.GetTlsInspectionPolicyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetTlsInspectionPolicy</summary>
        public void GetTlsInspectionPolicyResourceNames()
        {
            // Snippet: GetTlsInspectionPolicy(TlsInspectionPolicyName, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            TlsInspectionPolicyName name = TlsInspectionPolicyName.FromProjectLocationTlsInspectionPolicy("[PROJECT]", "[LOCATION]", "[TLS_INSPECTION_POLICY]");
            // Make the request
            TlsInspectionPolicy response = networkSecurityClient.GetTlsInspectionPolicy(name);
            // End snippet
        }

        /// <summary>Snippet for GetTlsInspectionPolicyAsync</summary>
        public async Task GetTlsInspectionPolicyResourceNamesAsync()
        {
            // Snippet: GetTlsInspectionPolicyAsync(TlsInspectionPolicyName, CallSettings)
            // Additional: GetTlsInspectionPolicyAsync(TlsInspectionPolicyName, CancellationToken)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            TlsInspectionPolicyName name = TlsInspectionPolicyName.FromProjectLocationTlsInspectionPolicy("[PROJECT]", "[LOCATION]", "[TLS_INSPECTION_POLICY]");
            // Make the request
            TlsInspectionPolicy response = await networkSecurityClient.GetTlsInspectionPolicyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateTlsInspectionPolicy</summary>
        public void CreateTlsInspectionPolicyRequestObject()
        {
            // Snippet: CreateTlsInspectionPolicy(CreateTlsInspectionPolicyRequest, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            CreateTlsInspectionPolicyRequest request = new CreateTlsInspectionPolicyRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                TlsInspectionPolicyId = "",
                TlsInspectionPolicy = new TlsInspectionPolicy(),
            };
            // Make the request
            Operation<TlsInspectionPolicy, OperationMetadata> response = networkSecurityClient.CreateTlsInspectionPolicy(request);

            // Poll until the returned long-running operation is complete
            Operation<TlsInspectionPolicy, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            TlsInspectionPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<TlsInspectionPolicy, OperationMetadata> retrievedResponse = networkSecurityClient.PollOnceCreateTlsInspectionPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                TlsInspectionPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateTlsInspectionPolicyAsync</summary>
        public async Task CreateTlsInspectionPolicyRequestObjectAsync()
        {
            // Snippet: CreateTlsInspectionPolicyAsync(CreateTlsInspectionPolicyRequest, CallSettings)
            // Additional: CreateTlsInspectionPolicyAsync(CreateTlsInspectionPolicyRequest, CancellationToken)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            CreateTlsInspectionPolicyRequest request = new CreateTlsInspectionPolicyRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                TlsInspectionPolicyId = "",
                TlsInspectionPolicy = new TlsInspectionPolicy(),
            };
            // Make the request
            Operation<TlsInspectionPolicy, OperationMetadata> response = await networkSecurityClient.CreateTlsInspectionPolicyAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<TlsInspectionPolicy, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            TlsInspectionPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<TlsInspectionPolicy, OperationMetadata> retrievedResponse = await networkSecurityClient.PollOnceCreateTlsInspectionPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                TlsInspectionPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateTlsInspectionPolicy</summary>
        public void CreateTlsInspectionPolicy()
        {
            // Snippet: CreateTlsInspectionPolicy(string, TlsInspectionPolicy, string, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            TlsInspectionPolicy tlsInspectionPolicy = new TlsInspectionPolicy();
            string tlsInspectionPolicyId = "";
            // Make the request
            Operation<TlsInspectionPolicy, OperationMetadata> response = networkSecurityClient.CreateTlsInspectionPolicy(parent, tlsInspectionPolicy, tlsInspectionPolicyId);

            // Poll until the returned long-running operation is complete
            Operation<TlsInspectionPolicy, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            TlsInspectionPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<TlsInspectionPolicy, OperationMetadata> retrievedResponse = networkSecurityClient.PollOnceCreateTlsInspectionPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                TlsInspectionPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateTlsInspectionPolicyAsync</summary>
        public async Task CreateTlsInspectionPolicyAsync()
        {
            // Snippet: CreateTlsInspectionPolicyAsync(string, TlsInspectionPolicy, string, CallSettings)
            // Additional: CreateTlsInspectionPolicyAsync(string, TlsInspectionPolicy, string, CancellationToken)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            TlsInspectionPolicy tlsInspectionPolicy = new TlsInspectionPolicy();
            string tlsInspectionPolicyId = "";
            // Make the request
            Operation<TlsInspectionPolicy, OperationMetadata> response = await networkSecurityClient.CreateTlsInspectionPolicyAsync(parent, tlsInspectionPolicy, tlsInspectionPolicyId);

            // Poll until the returned long-running operation is complete
            Operation<TlsInspectionPolicy, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            TlsInspectionPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<TlsInspectionPolicy, OperationMetadata> retrievedResponse = await networkSecurityClient.PollOnceCreateTlsInspectionPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                TlsInspectionPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateTlsInspectionPolicy</summary>
        public void CreateTlsInspectionPolicyResourceNames()
        {
            // Snippet: CreateTlsInspectionPolicy(LocationName, TlsInspectionPolicy, string, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            TlsInspectionPolicy tlsInspectionPolicy = new TlsInspectionPolicy();
            string tlsInspectionPolicyId = "";
            // Make the request
            Operation<TlsInspectionPolicy, OperationMetadata> response = networkSecurityClient.CreateTlsInspectionPolicy(parent, tlsInspectionPolicy, tlsInspectionPolicyId);

            // Poll until the returned long-running operation is complete
            Operation<TlsInspectionPolicy, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            TlsInspectionPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<TlsInspectionPolicy, OperationMetadata> retrievedResponse = networkSecurityClient.PollOnceCreateTlsInspectionPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                TlsInspectionPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateTlsInspectionPolicyAsync</summary>
        public async Task CreateTlsInspectionPolicyResourceNamesAsync()
        {
            // Snippet: CreateTlsInspectionPolicyAsync(LocationName, TlsInspectionPolicy, string, CallSettings)
            // Additional: CreateTlsInspectionPolicyAsync(LocationName, TlsInspectionPolicy, string, CancellationToken)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            TlsInspectionPolicy tlsInspectionPolicy = new TlsInspectionPolicy();
            string tlsInspectionPolicyId = "";
            // Make the request
            Operation<TlsInspectionPolicy, OperationMetadata> response = await networkSecurityClient.CreateTlsInspectionPolicyAsync(parent, tlsInspectionPolicy, tlsInspectionPolicyId);

            // Poll until the returned long-running operation is complete
            Operation<TlsInspectionPolicy, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            TlsInspectionPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<TlsInspectionPolicy, OperationMetadata> retrievedResponse = await networkSecurityClient.PollOnceCreateTlsInspectionPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                TlsInspectionPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateTlsInspectionPolicy</summary>
        public void UpdateTlsInspectionPolicyRequestObject()
        {
            // Snippet: UpdateTlsInspectionPolicy(UpdateTlsInspectionPolicyRequest, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            UpdateTlsInspectionPolicyRequest request = new UpdateTlsInspectionPolicyRequest
            {
                UpdateMask = new FieldMask(),
                TlsInspectionPolicy = new TlsInspectionPolicy(),
            };
            // Make the request
            Operation<TlsInspectionPolicy, OperationMetadata> response = networkSecurityClient.UpdateTlsInspectionPolicy(request);

            // Poll until the returned long-running operation is complete
            Operation<TlsInspectionPolicy, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            TlsInspectionPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<TlsInspectionPolicy, OperationMetadata> retrievedResponse = networkSecurityClient.PollOnceUpdateTlsInspectionPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                TlsInspectionPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateTlsInspectionPolicyAsync</summary>
        public async Task UpdateTlsInspectionPolicyRequestObjectAsync()
        {
            // Snippet: UpdateTlsInspectionPolicyAsync(UpdateTlsInspectionPolicyRequest, CallSettings)
            // Additional: UpdateTlsInspectionPolicyAsync(UpdateTlsInspectionPolicyRequest, CancellationToken)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            UpdateTlsInspectionPolicyRequest request = new UpdateTlsInspectionPolicyRequest
            {
                UpdateMask = new FieldMask(),
                TlsInspectionPolicy = new TlsInspectionPolicy(),
            };
            // Make the request
            Operation<TlsInspectionPolicy, OperationMetadata> response = await networkSecurityClient.UpdateTlsInspectionPolicyAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<TlsInspectionPolicy, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            TlsInspectionPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<TlsInspectionPolicy, OperationMetadata> retrievedResponse = await networkSecurityClient.PollOnceUpdateTlsInspectionPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                TlsInspectionPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateTlsInspectionPolicy</summary>
        public void UpdateTlsInspectionPolicy()
        {
            // Snippet: UpdateTlsInspectionPolicy(TlsInspectionPolicy, FieldMask, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            TlsInspectionPolicy tlsInspectionPolicy = new TlsInspectionPolicy();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<TlsInspectionPolicy, OperationMetadata> response = networkSecurityClient.UpdateTlsInspectionPolicy(tlsInspectionPolicy, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<TlsInspectionPolicy, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            TlsInspectionPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<TlsInspectionPolicy, OperationMetadata> retrievedResponse = networkSecurityClient.PollOnceUpdateTlsInspectionPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                TlsInspectionPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateTlsInspectionPolicyAsync</summary>
        public async Task UpdateTlsInspectionPolicyAsync()
        {
            // Snippet: UpdateTlsInspectionPolicyAsync(TlsInspectionPolicy, FieldMask, CallSettings)
            // Additional: UpdateTlsInspectionPolicyAsync(TlsInspectionPolicy, FieldMask, CancellationToken)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            TlsInspectionPolicy tlsInspectionPolicy = new TlsInspectionPolicy();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<TlsInspectionPolicy, OperationMetadata> response = await networkSecurityClient.UpdateTlsInspectionPolicyAsync(tlsInspectionPolicy, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<TlsInspectionPolicy, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            TlsInspectionPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<TlsInspectionPolicy, OperationMetadata> retrievedResponse = await networkSecurityClient.PollOnceUpdateTlsInspectionPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                TlsInspectionPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteTlsInspectionPolicy</summary>
        public void DeleteTlsInspectionPolicyRequestObject()
        {
            // Snippet: DeleteTlsInspectionPolicy(DeleteTlsInspectionPolicyRequest, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            DeleteTlsInspectionPolicyRequest request = new DeleteTlsInspectionPolicyRequest
            {
                TlsInspectionPolicyName = TlsInspectionPolicyName.FromProjectLocationTlsInspectionPolicy("[PROJECT]", "[LOCATION]", "[TLS_INSPECTION_POLICY]"),
                Force = false,
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = networkSecurityClient.DeleteTlsInspectionPolicy(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = networkSecurityClient.PollOnceDeleteTlsInspectionPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteTlsInspectionPolicyAsync</summary>
        public async Task DeleteTlsInspectionPolicyRequestObjectAsync()
        {
            // Snippet: DeleteTlsInspectionPolicyAsync(DeleteTlsInspectionPolicyRequest, CallSettings)
            // Additional: DeleteTlsInspectionPolicyAsync(DeleteTlsInspectionPolicyRequest, CancellationToken)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            DeleteTlsInspectionPolicyRequest request = new DeleteTlsInspectionPolicyRequest
            {
                TlsInspectionPolicyName = TlsInspectionPolicyName.FromProjectLocationTlsInspectionPolicy("[PROJECT]", "[LOCATION]", "[TLS_INSPECTION_POLICY]"),
                Force = false,
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await networkSecurityClient.DeleteTlsInspectionPolicyAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await networkSecurityClient.PollOnceDeleteTlsInspectionPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteTlsInspectionPolicy</summary>
        public void DeleteTlsInspectionPolicy()
        {
            // Snippet: DeleteTlsInspectionPolicy(string, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/tlsInspectionPolicies/[TLS_INSPECTION_POLICY]";
            // Make the request
            Operation<Empty, OperationMetadata> response = networkSecurityClient.DeleteTlsInspectionPolicy(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = networkSecurityClient.PollOnceDeleteTlsInspectionPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteTlsInspectionPolicyAsync</summary>
        public async Task DeleteTlsInspectionPolicyAsync()
        {
            // Snippet: DeleteTlsInspectionPolicyAsync(string, CallSettings)
            // Additional: DeleteTlsInspectionPolicyAsync(string, CancellationToken)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/tlsInspectionPolicies/[TLS_INSPECTION_POLICY]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await networkSecurityClient.DeleteTlsInspectionPolicyAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await networkSecurityClient.PollOnceDeleteTlsInspectionPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteTlsInspectionPolicy</summary>
        public void DeleteTlsInspectionPolicyResourceNames()
        {
            // Snippet: DeleteTlsInspectionPolicy(TlsInspectionPolicyName, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            TlsInspectionPolicyName name = TlsInspectionPolicyName.FromProjectLocationTlsInspectionPolicy("[PROJECT]", "[LOCATION]", "[TLS_INSPECTION_POLICY]");
            // Make the request
            Operation<Empty, OperationMetadata> response = networkSecurityClient.DeleteTlsInspectionPolicy(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = networkSecurityClient.PollOnceDeleteTlsInspectionPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteTlsInspectionPolicyAsync</summary>
        public async Task DeleteTlsInspectionPolicyResourceNamesAsync()
        {
            // Snippet: DeleteTlsInspectionPolicyAsync(TlsInspectionPolicyName, CallSettings)
            // Additional: DeleteTlsInspectionPolicyAsync(TlsInspectionPolicyName, CancellationToken)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            TlsInspectionPolicyName name = TlsInspectionPolicyName.FromProjectLocationTlsInspectionPolicy("[PROJECT]", "[LOCATION]", "[TLS_INSPECTION_POLICY]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await networkSecurityClient.DeleteTlsInspectionPolicyAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await networkSecurityClient.PollOnceDeleteTlsInspectionPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListAuthzPolicies</summary>
        public void ListAuthzPoliciesRequestObject()
        {
            // Snippet: ListAuthzPolicies(ListAuthzPoliciesRequest, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            ListAuthzPoliciesRequest request = new ListAuthzPoliciesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListAuthzPoliciesResponse, AuthzPolicy> response = networkSecurityClient.ListAuthzPolicies(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AuthzPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAuthzPoliciesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AuthzPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AuthzPolicy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AuthzPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAuthzPoliciesAsync</summary>
        public async Task ListAuthzPoliciesRequestObjectAsync()
        {
            // Snippet: ListAuthzPoliciesAsync(ListAuthzPoliciesRequest, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            ListAuthzPoliciesRequest request = new ListAuthzPoliciesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListAuthzPoliciesResponse, AuthzPolicy> response = networkSecurityClient.ListAuthzPoliciesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (AuthzPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListAuthzPoliciesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AuthzPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AuthzPolicy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AuthzPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAuthzPolicies</summary>
        public void ListAuthzPolicies()
        {
            // Snippet: ListAuthzPolicies(string, string, int?, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListAuthzPoliciesResponse, AuthzPolicy> response = networkSecurityClient.ListAuthzPolicies(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AuthzPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAuthzPoliciesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AuthzPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AuthzPolicy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AuthzPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAuthzPoliciesAsync</summary>
        public async Task ListAuthzPoliciesAsync()
        {
            // Snippet: ListAuthzPoliciesAsync(string, string, int?, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListAuthzPoliciesResponse, AuthzPolicy> response = networkSecurityClient.ListAuthzPoliciesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (AuthzPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListAuthzPoliciesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AuthzPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AuthzPolicy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AuthzPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAuthzPolicies</summary>
        public void ListAuthzPoliciesResourceNames()
        {
            // Snippet: ListAuthzPolicies(LocationName, string, int?, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListAuthzPoliciesResponse, AuthzPolicy> response = networkSecurityClient.ListAuthzPolicies(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AuthzPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAuthzPoliciesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AuthzPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AuthzPolicy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AuthzPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAuthzPoliciesAsync</summary>
        public async Task ListAuthzPoliciesResourceNamesAsync()
        {
            // Snippet: ListAuthzPoliciesAsync(LocationName, string, int?, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListAuthzPoliciesResponse, AuthzPolicy> response = networkSecurityClient.ListAuthzPoliciesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (AuthzPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListAuthzPoliciesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AuthzPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AuthzPolicy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AuthzPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetAuthzPolicy</summary>
        public void GetAuthzPolicyRequestObject()
        {
            // Snippet: GetAuthzPolicy(GetAuthzPolicyRequest, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            GetAuthzPolicyRequest request = new GetAuthzPolicyRequest
            {
                AuthzPolicyName = AuthzPolicyName.FromProjectLocationAuthzPolicy("[PROJECT]", "[LOCATION]", "[AUTHZ_POLICY]"),
            };
            // Make the request
            AuthzPolicy response = networkSecurityClient.GetAuthzPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for GetAuthzPolicyAsync</summary>
        public async Task GetAuthzPolicyRequestObjectAsync()
        {
            // Snippet: GetAuthzPolicyAsync(GetAuthzPolicyRequest, CallSettings)
            // Additional: GetAuthzPolicyAsync(GetAuthzPolicyRequest, CancellationToken)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            GetAuthzPolicyRequest request = new GetAuthzPolicyRequest
            {
                AuthzPolicyName = AuthzPolicyName.FromProjectLocationAuthzPolicy("[PROJECT]", "[LOCATION]", "[AUTHZ_POLICY]"),
            };
            // Make the request
            AuthzPolicy response = await networkSecurityClient.GetAuthzPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAuthzPolicy</summary>
        public void GetAuthzPolicy()
        {
            // Snippet: GetAuthzPolicy(string, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/authzPolicies/[AUTHZ_POLICY]";
            // Make the request
            AuthzPolicy response = networkSecurityClient.GetAuthzPolicy(name);
            // End snippet
        }

        /// <summary>Snippet for GetAuthzPolicyAsync</summary>
        public async Task GetAuthzPolicyAsync()
        {
            // Snippet: GetAuthzPolicyAsync(string, CallSettings)
            // Additional: GetAuthzPolicyAsync(string, CancellationToken)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/authzPolicies/[AUTHZ_POLICY]";
            // Make the request
            AuthzPolicy response = await networkSecurityClient.GetAuthzPolicyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetAuthzPolicy</summary>
        public void GetAuthzPolicyResourceNames()
        {
            // Snippet: GetAuthzPolicy(AuthzPolicyName, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            AuthzPolicyName name = AuthzPolicyName.FromProjectLocationAuthzPolicy("[PROJECT]", "[LOCATION]", "[AUTHZ_POLICY]");
            // Make the request
            AuthzPolicy response = networkSecurityClient.GetAuthzPolicy(name);
            // End snippet
        }

        /// <summary>Snippet for GetAuthzPolicyAsync</summary>
        public async Task GetAuthzPolicyResourceNamesAsync()
        {
            // Snippet: GetAuthzPolicyAsync(AuthzPolicyName, CallSettings)
            // Additional: GetAuthzPolicyAsync(AuthzPolicyName, CancellationToken)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            AuthzPolicyName name = AuthzPolicyName.FromProjectLocationAuthzPolicy("[PROJECT]", "[LOCATION]", "[AUTHZ_POLICY]");
            // Make the request
            AuthzPolicy response = await networkSecurityClient.GetAuthzPolicyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateAuthzPolicy</summary>
        public void CreateAuthzPolicyRequestObject()
        {
            // Snippet: CreateAuthzPolicy(CreateAuthzPolicyRequest, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            CreateAuthzPolicyRequest request = new CreateAuthzPolicyRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                AuthzPolicyId = "",
                AuthzPolicy = new AuthzPolicy(),
                RequestId = "",
            };
            // Make the request
            Operation<AuthzPolicy, OperationMetadata> response = networkSecurityClient.CreateAuthzPolicy(request);

            // Poll until the returned long-running operation is complete
            Operation<AuthzPolicy, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AuthzPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AuthzPolicy, OperationMetadata> retrievedResponse = networkSecurityClient.PollOnceCreateAuthzPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AuthzPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAuthzPolicyAsync</summary>
        public async Task CreateAuthzPolicyRequestObjectAsync()
        {
            // Snippet: CreateAuthzPolicyAsync(CreateAuthzPolicyRequest, CallSettings)
            // Additional: CreateAuthzPolicyAsync(CreateAuthzPolicyRequest, CancellationToken)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            CreateAuthzPolicyRequest request = new CreateAuthzPolicyRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                AuthzPolicyId = "",
                AuthzPolicy = new AuthzPolicy(),
                RequestId = "",
            };
            // Make the request
            Operation<AuthzPolicy, OperationMetadata> response = await networkSecurityClient.CreateAuthzPolicyAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<AuthzPolicy, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AuthzPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AuthzPolicy, OperationMetadata> retrievedResponse = await networkSecurityClient.PollOnceCreateAuthzPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AuthzPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAuthzPolicy</summary>
        public void CreateAuthzPolicy()
        {
            // Snippet: CreateAuthzPolicy(string, AuthzPolicy, string, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            AuthzPolicy authzPolicy = new AuthzPolicy();
            string authzPolicyId = "";
            // Make the request
            Operation<AuthzPolicy, OperationMetadata> response = networkSecurityClient.CreateAuthzPolicy(parent, authzPolicy, authzPolicyId);

            // Poll until the returned long-running operation is complete
            Operation<AuthzPolicy, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AuthzPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AuthzPolicy, OperationMetadata> retrievedResponse = networkSecurityClient.PollOnceCreateAuthzPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AuthzPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAuthzPolicyAsync</summary>
        public async Task CreateAuthzPolicyAsync()
        {
            // Snippet: CreateAuthzPolicyAsync(string, AuthzPolicy, string, CallSettings)
            // Additional: CreateAuthzPolicyAsync(string, AuthzPolicy, string, CancellationToken)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            AuthzPolicy authzPolicy = new AuthzPolicy();
            string authzPolicyId = "";
            // Make the request
            Operation<AuthzPolicy, OperationMetadata> response = await networkSecurityClient.CreateAuthzPolicyAsync(parent, authzPolicy, authzPolicyId);

            // Poll until the returned long-running operation is complete
            Operation<AuthzPolicy, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AuthzPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AuthzPolicy, OperationMetadata> retrievedResponse = await networkSecurityClient.PollOnceCreateAuthzPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AuthzPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAuthzPolicy</summary>
        public void CreateAuthzPolicyResourceNames()
        {
            // Snippet: CreateAuthzPolicy(LocationName, AuthzPolicy, string, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            AuthzPolicy authzPolicy = new AuthzPolicy();
            string authzPolicyId = "";
            // Make the request
            Operation<AuthzPolicy, OperationMetadata> response = networkSecurityClient.CreateAuthzPolicy(parent, authzPolicy, authzPolicyId);

            // Poll until the returned long-running operation is complete
            Operation<AuthzPolicy, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AuthzPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AuthzPolicy, OperationMetadata> retrievedResponse = networkSecurityClient.PollOnceCreateAuthzPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AuthzPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAuthzPolicyAsync</summary>
        public async Task CreateAuthzPolicyResourceNamesAsync()
        {
            // Snippet: CreateAuthzPolicyAsync(LocationName, AuthzPolicy, string, CallSettings)
            // Additional: CreateAuthzPolicyAsync(LocationName, AuthzPolicy, string, CancellationToken)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            AuthzPolicy authzPolicy = new AuthzPolicy();
            string authzPolicyId = "";
            // Make the request
            Operation<AuthzPolicy, OperationMetadata> response = await networkSecurityClient.CreateAuthzPolicyAsync(parent, authzPolicy, authzPolicyId);

            // Poll until the returned long-running operation is complete
            Operation<AuthzPolicy, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AuthzPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AuthzPolicy, OperationMetadata> retrievedResponse = await networkSecurityClient.PollOnceCreateAuthzPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AuthzPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateAuthzPolicy</summary>
        public void UpdateAuthzPolicyRequestObject()
        {
            // Snippet: UpdateAuthzPolicy(UpdateAuthzPolicyRequest, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            UpdateAuthzPolicyRequest request = new UpdateAuthzPolicyRequest
            {
                UpdateMask = new FieldMask(),
                AuthzPolicy = new AuthzPolicy(),
                RequestId = "",
            };
            // Make the request
            Operation<AuthzPolicy, OperationMetadata> response = networkSecurityClient.UpdateAuthzPolicy(request);

            // Poll until the returned long-running operation is complete
            Operation<AuthzPolicy, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AuthzPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AuthzPolicy, OperationMetadata> retrievedResponse = networkSecurityClient.PollOnceUpdateAuthzPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AuthzPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateAuthzPolicyAsync</summary>
        public async Task UpdateAuthzPolicyRequestObjectAsync()
        {
            // Snippet: UpdateAuthzPolicyAsync(UpdateAuthzPolicyRequest, CallSettings)
            // Additional: UpdateAuthzPolicyAsync(UpdateAuthzPolicyRequest, CancellationToken)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            UpdateAuthzPolicyRequest request = new UpdateAuthzPolicyRequest
            {
                UpdateMask = new FieldMask(),
                AuthzPolicy = new AuthzPolicy(),
                RequestId = "",
            };
            // Make the request
            Operation<AuthzPolicy, OperationMetadata> response = await networkSecurityClient.UpdateAuthzPolicyAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<AuthzPolicy, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AuthzPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AuthzPolicy, OperationMetadata> retrievedResponse = await networkSecurityClient.PollOnceUpdateAuthzPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AuthzPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateAuthzPolicy</summary>
        public void UpdateAuthzPolicy()
        {
            // Snippet: UpdateAuthzPolicy(AuthzPolicy, FieldMask, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            AuthzPolicy authzPolicy = new AuthzPolicy();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<AuthzPolicy, OperationMetadata> response = networkSecurityClient.UpdateAuthzPolicy(authzPolicy, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<AuthzPolicy, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AuthzPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AuthzPolicy, OperationMetadata> retrievedResponse = networkSecurityClient.PollOnceUpdateAuthzPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AuthzPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateAuthzPolicyAsync</summary>
        public async Task UpdateAuthzPolicyAsync()
        {
            // Snippet: UpdateAuthzPolicyAsync(AuthzPolicy, FieldMask, CallSettings)
            // Additional: UpdateAuthzPolicyAsync(AuthzPolicy, FieldMask, CancellationToken)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            AuthzPolicy authzPolicy = new AuthzPolicy();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<AuthzPolicy, OperationMetadata> response = await networkSecurityClient.UpdateAuthzPolicyAsync(authzPolicy, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<AuthzPolicy, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AuthzPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AuthzPolicy, OperationMetadata> retrievedResponse = await networkSecurityClient.PollOnceUpdateAuthzPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AuthzPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAuthzPolicy</summary>
        public void DeleteAuthzPolicyRequestObject()
        {
            // Snippet: DeleteAuthzPolicy(DeleteAuthzPolicyRequest, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            DeleteAuthzPolicyRequest request = new DeleteAuthzPolicyRequest
            {
                AuthzPolicyName = AuthzPolicyName.FromProjectLocationAuthzPolicy("[PROJECT]", "[LOCATION]", "[AUTHZ_POLICY]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = networkSecurityClient.DeleteAuthzPolicy(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = networkSecurityClient.PollOnceDeleteAuthzPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAuthzPolicyAsync</summary>
        public async Task DeleteAuthzPolicyRequestObjectAsync()
        {
            // Snippet: DeleteAuthzPolicyAsync(DeleteAuthzPolicyRequest, CallSettings)
            // Additional: DeleteAuthzPolicyAsync(DeleteAuthzPolicyRequest, CancellationToken)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            DeleteAuthzPolicyRequest request = new DeleteAuthzPolicyRequest
            {
                AuthzPolicyName = AuthzPolicyName.FromProjectLocationAuthzPolicy("[PROJECT]", "[LOCATION]", "[AUTHZ_POLICY]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await networkSecurityClient.DeleteAuthzPolicyAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await networkSecurityClient.PollOnceDeleteAuthzPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAuthzPolicy</summary>
        public void DeleteAuthzPolicy()
        {
            // Snippet: DeleteAuthzPolicy(string, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/authzPolicies/[AUTHZ_POLICY]";
            // Make the request
            Operation<Empty, OperationMetadata> response = networkSecurityClient.DeleteAuthzPolicy(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = networkSecurityClient.PollOnceDeleteAuthzPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAuthzPolicyAsync</summary>
        public async Task DeleteAuthzPolicyAsync()
        {
            // Snippet: DeleteAuthzPolicyAsync(string, CallSettings)
            // Additional: DeleteAuthzPolicyAsync(string, CancellationToken)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/authzPolicies/[AUTHZ_POLICY]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await networkSecurityClient.DeleteAuthzPolicyAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await networkSecurityClient.PollOnceDeleteAuthzPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAuthzPolicy</summary>
        public void DeleteAuthzPolicyResourceNames()
        {
            // Snippet: DeleteAuthzPolicy(AuthzPolicyName, CallSettings)
            // Create client
            NetworkSecurityClient networkSecurityClient = NetworkSecurityClient.Create();
            // Initialize request argument(s)
            AuthzPolicyName name = AuthzPolicyName.FromProjectLocationAuthzPolicy("[PROJECT]", "[LOCATION]", "[AUTHZ_POLICY]");
            // Make the request
            Operation<Empty, OperationMetadata> response = networkSecurityClient.DeleteAuthzPolicy(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = networkSecurityClient.PollOnceDeleteAuthzPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAuthzPolicyAsync</summary>
        public async Task DeleteAuthzPolicyResourceNamesAsync()
        {
            // Snippet: DeleteAuthzPolicyAsync(AuthzPolicyName, CallSettings)
            // Additional: DeleteAuthzPolicyAsync(AuthzPolicyName, CancellationToken)
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            AuthzPolicyName name = AuthzPolicyName.FromProjectLocationAuthzPolicy("[PROJECT]", "[LOCATION]", "[AUTHZ_POLICY]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await networkSecurityClient.DeleteAuthzPolicyAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await networkSecurityClient.PollOnceDeleteAuthzPolicyAsync(operationName);
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
