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
    using Google.Identity.AccessContextManager.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedAccessContextManagerClientSnippets
    {
        /// <summary>Snippet for ListAccessPolicies</summary>
        public void ListAccessPoliciesRequestObject()
        {
            // Snippet: ListAccessPolicies(ListAccessPoliciesRequest, CallSettings)
            // Create client
            AccessContextManagerClient accessContextManagerClient = AccessContextManagerClient.Create();
            // Initialize request argument(s)
            ListAccessPoliciesRequest request = new ListAccessPoliciesRequest
            {
                ParentAsOrganizationName = OrganizationName.FromOrganization("[ORGANIZATION]"),
            };
            // Make the request
            PagedEnumerable<ListAccessPoliciesResponse, AccessPolicy> response = accessContextManagerClient.ListAccessPolicies(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AccessPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAccessPoliciesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AccessPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AccessPolicy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AccessPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAccessPoliciesAsync</summary>
        public async Task ListAccessPoliciesRequestObjectAsync()
        {
            // Snippet: ListAccessPoliciesAsync(ListAccessPoliciesRequest, CallSettings)
            // Create client
            AccessContextManagerClient accessContextManagerClient = await AccessContextManagerClient.CreateAsync();
            // Initialize request argument(s)
            ListAccessPoliciesRequest request = new ListAccessPoliciesRequest
            {
                ParentAsOrganizationName = OrganizationName.FromOrganization("[ORGANIZATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListAccessPoliciesResponse, AccessPolicy> response = accessContextManagerClient.ListAccessPoliciesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AccessPolicy item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAccessPoliciesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AccessPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AccessPolicy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AccessPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetAccessPolicy</summary>
        public void GetAccessPolicyRequestObject()
        {
            // Snippet: GetAccessPolicy(GetAccessPolicyRequest, CallSettings)
            // Create client
            AccessContextManagerClient accessContextManagerClient = AccessContextManagerClient.Create();
            // Initialize request argument(s)
            GetAccessPolicyRequest request = new GetAccessPolicyRequest
            {
                AccessPolicyName = AccessPolicyName.FromAccessPolicy("[ACCESS_POLICY]"),
            };
            // Make the request
            AccessPolicy response = accessContextManagerClient.GetAccessPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for GetAccessPolicyAsync</summary>
        public async Task GetAccessPolicyRequestObjectAsync()
        {
            // Snippet: GetAccessPolicyAsync(GetAccessPolicyRequest, CallSettings)
            // Additional: GetAccessPolicyAsync(GetAccessPolicyRequest, CancellationToken)
            // Create client
            AccessContextManagerClient accessContextManagerClient = await AccessContextManagerClient.CreateAsync();
            // Initialize request argument(s)
            GetAccessPolicyRequest request = new GetAccessPolicyRequest
            {
                AccessPolicyName = AccessPolicyName.FromAccessPolicy("[ACCESS_POLICY]"),
            };
            // Make the request
            AccessPolicy response = await accessContextManagerClient.GetAccessPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAccessPolicy</summary>
        public void GetAccessPolicy()
        {
            // Snippet: GetAccessPolicy(string, CallSettings)
            // Create client
            AccessContextManagerClient accessContextManagerClient = AccessContextManagerClient.Create();
            // Initialize request argument(s)
            string name = "accessPolicies/[ACCESS_POLICY]";
            // Make the request
            AccessPolicy response = accessContextManagerClient.GetAccessPolicy(name);
            // End snippet
        }

        /// <summary>Snippet for GetAccessPolicyAsync</summary>
        public async Task GetAccessPolicyAsync()
        {
            // Snippet: GetAccessPolicyAsync(string, CallSettings)
            // Additional: GetAccessPolicyAsync(string, CancellationToken)
            // Create client
            AccessContextManagerClient accessContextManagerClient = await AccessContextManagerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "accessPolicies/[ACCESS_POLICY]";
            // Make the request
            AccessPolicy response = await accessContextManagerClient.GetAccessPolicyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetAccessPolicy</summary>
        public void GetAccessPolicyResourceNames()
        {
            // Snippet: GetAccessPolicy(AccessPolicyName, CallSettings)
            // Create client
            AccessContextManagerClient accessContextManagerClient = AccessContextManagerClient.Create();
            // Initialize request argument(s)
            AccessPolicyName name = AccessPolicyName.FromAccessPolicy("[ACCESS_POLICY]");
            // Make the request
            AccessPolicy response = accessContextManagerClient.GetAccessPolicy(name);
            // End snippet
        }

        /// <summary>Snippet for GetAccessPolicyAsync</summary>
        public async Task GetAccessPolicyResourceNamesAsync()
        {
            // Snippet: GetAccessPolicyAsync(AccessPolicyName, CallSettings)
            // Additional: GetAccessPolicyAsync(AccessPolicyName, CancellationToken)
            // Create client
            AccessContextManagerClient accessContextManagerClient = await AccessContextManagerClient.CreateAsync();
            // Initialize request argument(s)
            AccessPolicyName name = AccessPolicyName.FromAccessPolicy("[ACCESS_POLICY]");
            // Make the request
            AccessPolicy response = await accessContextManagerClient.GetAccessPolicyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateAccessPolicy</summary>
        public void CreateAccessPolicyRequestObject()
        {
            // Snippet: CreateAccessPolicy(AccessPolicy, CallSettings)
            // Create client
            AccessContextManagerClient accessContextManagerClient = AccessContextManagerClient.Create();
            // Initialize request argument(s)
            AccessPolicy request = new AccessPolicy
            {
                AccessPolicyName = AccessPolicyName.FromAccessPolicy("[ACCESS_POLICY]"),
                Parent = "",
                Title = "",
                CreateTime = new Timestamp(),
                UpdateTime = new Timestamp(),
                Etag = "",
                Scopes = { "", },
            };
            // Make the request
            Operation<AccessPolicy, AccessContextManagerOperationMetadata> response = accessContextManagerClient.CreateAccessPolicy(request);

            // Poll until the returned long-running operation is complete
            Operation<AccessPolicy, AccessContextManagerOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AccessPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AccessPolicy, AccessContextManagerOperationMetadata> retrievedResponse = accessContextManagerClient.PollOnceCreateAccessPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AccessPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAccessPolicyAsync</summary>
        public async Task CreateAccessPolicyRequestObjectAsync()
        {
            // Snippet: CreateAccessPolicyAsync(AccessPolicy, CallSettings)
            // Additional: CreateAccessPolicyAsync(AccessPolicy, CancellationToken)
            // Create client
            AccessContextManagerClient accessContextManagerClient = await AccessContextManagerClient.CreateAsync();
            // Initialize request argument(s)
            AccessPolicy request = new AccessPolicy
            {
                AccessPolicyName = AccessPolicyName.FromAccessPolicy("[ACCESS_POLICY]"),
                Parent = "",
                Title = "",
                CreateTime = new Timestamp(),
                UpdateTime = new Timestamp(),
                Etag = "",
                Scopes = { "", },
            };
            // Make the request
            Operation<AccessPolicy, AccessContextManagerOperationMetadata> response = await accessContextManagerClient.CreateAccessPolicyAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<AccessPolicy, AccessContextManagerOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AccessPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AccessPolicy, AccessContextManagerOperationMetadata> retrievedResponse = await accessContextManagerClient.PollOnceCreateAccessPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AccessPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateAccessPolicy</summary>
        public void UpdateAccessPolicyRequestObject()
        {
            // Snippet: UpdateAccessPolicy(UpdateAccessPolicyRequest, CallSettings)
            // Create client
            AccessContextManagerClient accessContextManagerClient = AccessContextManagerClient.Create();
            // Initialize request argument(s)
            UpdateAccessPolicyRequest request = new UpdateAccessPolicyRequest
            {
                Policy = new AccessPolicy(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<AccessPolicy, AccessContextManagerOperationMetadata> response = accessContextManagerClient.UpdateAccessPolicy(request);

            // Poll until the returned long-running operation is complete
            Operation<AccessPolicy, AccessContextManagerOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AccessPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AccessPolicy, AccessContextManagerOperationMetadata> retrievedResponse = accessContextManagerClient.PollOnceUpdateAccessPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AccessPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateAccessPolicyAsync</summary>
        public async Task UpdateAccessPolicyRequestObjectAsync()
        {
            // Snippet: UpdateAccessPolicyAsync(UpdateAccessPolicyRequest, CallSettings)
            // Additional: UpdateAccessPolicyAsync(UpdateAccessPolicyRequest, CancellationToken)
            // Create client
            AccessContextManagerClient accessContextManagerClient = await AccessContextManagerClient.CreateAsync();
            // Initialize request argument(s)
            UpdateAccessPolicyRequest request = new UpdateAccessPolicyRequest
            {
                Policy = new AccessPolicy(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<AccessPolicy, AccessContextManagerOperationMetadata> response = await accessContextManagerClient.UpdateAccessPolicyAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<AccessPolicy, AccessContextManagerOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AccessPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AccessPolicy, AccessContextManagerOperationMetadata> retrievedResponse = await accessContextManagerClient.PollOnceUpdateAccessPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AccessPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateAccessPolicy</summary>
        public void UpdateAccessPolicy()
        {
            // Snippet: UpdateAccessPolicy(AccessPolicy, FieldMask, CallSettings)
            // Create client
            AccessContextManagerClient accessContextManagerClient = AccessContextManagerClient.Create();
            // Initialize request argument(s)
            AccessPolicy policy = new AccessPolicy();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<AccessPolicy, AccessContextManagerOperationMetadata> response = accessContextManagerClient.UpdateAccessPolicy(policy, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<AccessPolicy, AccessContextManagerOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AccessPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AccessPolicy, AccessContextManagerOperationMetadata> retrievedResponse = accessContextManagerClient.PollOnceUpdateAccessPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AccessPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateAccessPolicyAsync</summary>
        public async Task UpdateAccessPolicyAsync()
        {
            // Snippet: UpdateAccessPolicyAsync(AccessPolicy, FieldMask, CallSettings)
            // Additional: UpdateAccessPolicyAsync(AccessPolicy, FieldMask, CancellationToken)
            // Create client
            AccessContextManagerClient accessContextManagerClient = await AccessContextManagerClient.CreateAsync();
            // Initialize request argument(s)
            AccessPolicy policy = new AccessPolicy();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<AccessPolicy, AccessContextManagerOperationMetadata> response = await accessContextManagerClient.UpdateAccessPolicyAsync(policy, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<AccessPolicy, AccessContextManagerOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AccessPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AccessPolicy, AccessContextManagerOperationMetadata> retrievedResponse = await accessContextManagerClient.PollOnceUpdateAccessPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AccessPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAccessPolicy</summary>
        public void DeleteAccessPolicyRequestObject()
        {
            // Snippet: DeleteAccessPolicy(DeleteAccessPolicyRequest, CallSettings)
            // Create client
            AccessContextManagerClient accessContextManagerClient = AccessContextManagerClient.Create();
            // Initialize request argument(s)
            DeleteAccessPolicyRequest request = new DeleteAccessPolicyRequest
            {
                AccessPolicyName = AccessPolicyName.FromAccessPolicy("[ACCESS_POLICY]"),
            };
            // Make the request
            Operation<Empty, AccessContextManagerOperationMetadata> response = accessContextManagerClient.DeleteAccessPolicy(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, AccessContextManagerOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, AccessContextManagerOperationMetadata> retrievedResponse = accessContextManagerClient.PollOnceDeleteAccessPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAccessPolicyAsync</summary>
        public async Task DeleteAccessPolicyRequestObjectAsync()
        {
            // Snippet: DeleteAccessPolicyAsync(DeleteAccessPolicyRequest, CallSettings)
            // Additional: DeleteAccessPolicyAsync(DeleteAccessPolicyRequest, CancellationToken)
            // Create client
            AccessContextManagerClient accessContextManagerClient = await AccessContextManagerClient.CreateAsync();
            // Initialize request argument(s)
            DeleteAccessPolicyRequest request = new DeleteAccessPolicyRequest
            {
                AccessPolicyName = AccessPolicyName.FromAccessPolicy("[ACCESS_POLICY]"),
            };
            // Make the request
            Operation<Empty, AccessContextManagerOperationMetadata> response = await accessContextManagerClient.DeleteAccessPolicyAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, AccessContextManagerOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, AccessContextManagerOperationMetadata> retrievedResponse = await accessContextManagerClient.PollOnceDeleteAccessPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAccessPolicy</summary>
        public void DeleteAccessPolicy()
        {
            // Snippet: DeleteAccessPolicy(string, CallSettings)
            // Create client
            AccessContextManagerClient accessContextManagerClient = AccessContextManagerClient.Create();
            // Initialize request argument(s)
            string name = "accessPolicies/[ACCESS_POLICY]";
            // Make the request
            Operation<Empty, AccessContextManagerOperationMetadata> response = accessContextManagerClient.DeleteAccessPolicy(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, AccessContextManagerOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, AccessContextManagerOperationMetadata> retrievedResponse = accessContextManagerClient.PollOnceDeleteAccessPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAccessPolicyAsync</summary>
        public async Task DeleteAccessPolicyAsync()
        {
            // Snippet: DeleteAccessPolicyAsync(string, CallSettings)
            // Additional: DeleteAccessPolicyAsync(string, CancellationToken)
            // Create client
            AccessContextManagerClient accessContextManagerClient = await AccessContextManagerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "accessPolicies/[ACCESS_POLICY]";
            // Make the request
            Operation<Empty, AccessContextManagerOperationMetadata> response = await accessContextManagerClient.DeleteAccessPolicyAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, AccessContextManagerOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, AccessContextManagerOperationMetadata> retrievedResponse = await accessContextManagerClient.PollOnceDeleteAccessPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAccessPolicy</summary>
        public void DeleteAccessPolicyResourceNames()
        {
            // Snippet: DeleteAccessPolicy(AccessPolicyName, CallSettings)
            // Create client
            AccessContextManagerClient accessContextManagerClient = AccessContextManagerClient.Create();
            // Initialize request argument(s)
            AccessPolicyName name = AccessPolicyName.FromAccessPolicy("[ACCESS_POLICY]");
            // Make the request
            Operation<Empty, AccessContextManagerOperationMetadata> response = accessContextManagerClient.DeleteAccessPolicy(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, AccessContextManagerOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, AccessContextManagerOperationMetadata> retrievedResponse = accessContextManagerClient.PollOnceDeleteAccessPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAccessPolicyAsync</summary>
        public async Task DeleteAccessPolicyResourceNamesAsync()
        {
            // Snippet: DeleteAccessPolicyAsync(AccessPolicyName, CallSettings)
            // Additional: DeleteAccessPolicyAsync(AccessPolicyName, CancellationToken)
            // Create client
            AccessContextManagerClient accessContextManagerClient = await AccessContextManagerClient.CreateAsync();
            // Initialize request argument(s)
            AccessPolicyName name = AccessPolicyName.FromAccessPolicy("[ACCESS_POLICY]");
            // Make the request
            Operation<Empty, AccessContextManagerOperationMetadata> response = await accessContextManagerClient.DeleteAccessPolicyAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, AccessContextManagerOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, AccessContextManagerOperationMetadata> retrievedResponse = await accessContextManagerClient.PollOnceDeleteAccessPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListAccessLevels</summary>
        public void ListAccessLevelsRequestObject()
        {
            // Snippet: ListAccessLevels(ListAccessLevelsRequest, CallSettings)
            // Create client
            AccessContextManagerClient accessContextManagerClient = AccessContextManagerClient.Create();
            // Initialize request argument(s)
            ListAccessLevelsRequest request = new ListAccessLevelsRequest
            {
                ParentAsAccessPolicyName = AccessPolicyName.FromAccessPolicy("[ACCESS_POLICY]"),
                AccessLevelFormat = LevelFormat.Unspecified,
            };
            // Make the request
            PagedEnumerable<ListAccessLevelsResponse, AccessLevel> response = accessContextManagerClient.ListAccessLevels(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AccessLevel item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAccessLevelsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AccessLevel item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AccessLevel> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AccessLevel item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAccessLevelsAsync</summary>
        public async Task ListAccessLevelsRequestObjectAsync()
        {
            // Snippet: ListAccessLevelsAsync(ListAccessLevelsRequest, CallSettings)
            // Create client
            AccessContextManagerClient accessContextManagerClient = await AccessContextManagerClient.CreateAsync();
            // Initialize request argument(s)
            ListAccessLevelsRequest request = new ListAccessLevelsRequest
            {
                ParentAsAccessPolicyName = AccessPolicyName.FromAccessPolicy("[ACCESS_POLICY]"),
                AccessLevelFormat = LevelFormat.Unspecified,
            };
            // Make the request
            PagedAsyncEnumerable<ListAccessLevelsResponse, AccessLevel> response = accessContextManagerClient.ListAccessLevelsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AccessLevel item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAccessLevelsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AccessLevel item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AccessLevel> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AccessLevel item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAccessLevels</summary>
        public void ListAccessLevels()
        {
            // Snippet: ListAccessLevels(string, string, int?, CallSettings)
            // Create client
            AccessContextManagerClient accessContextManagerClient = AccessContextManagerClient.Create();
            // Initialize request argument(s)
            string parent = "accessPolicies/[ACCESS_POLICY]";
            // Make the request
            PagedEnumerable<ListAccessLevelsResponse, AccessLevel> response = accessContextManagerClient.ListAccessLevels(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AccessLevel item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAccessLevelsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AccessLevel item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AccessLevel> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AccessLevel item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAccessLevelsAsync</summary>
        public async Task ListAccessLevelsAsync()
        {
            // Snippet: ListAccessLevelsAsync(string, string, int?, CallSettings)
            // Create client
            AccessContextManagerClient accessContextManagerClient = await AccessContextManagerClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "accessPolicies/[ACCESS_POLICY]";
            // Make the request
            PagedAsyncEnumerable<ListAccessLevelsResponse, AccessLevel> response = accessContextManagerClient.ListAccessLevelsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AccessLevel item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAccessLevelsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AccessLevel item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AccessLevel> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AccessLevel item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAccessLevels</summary>
        public void ListAccessLevelsResourceNames()
        {
            // Snippet: ListAccessLevels(AccessPolicyName, string, int?, CallSettings)
            // Create client
            AccessContextManagerClient accessContextManagerClient = AccessContextManagerClient.Create();
            // Initialize request argument(s)
            AccessPolicyName parent = AccessPolicyName.FromAccessPolicy("[ACCESS_POLICY]");
            // Make the request
            PagedEnumerable<ListAccessLevelsResponse, AccessLevel> response = accessContextManagerClient.ListAccessLevels(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AccessLevel item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAccessLevelsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AccessLevel item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AccessLevel> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AccessLevel item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAccessLevelsAsync</summary>
        public async Task ListAccessLevelsResourceNamesAsync()
        {
            // Snippet: ListAccessLevelsAsync(AccessPolicyName, string, int?, CallSettings)
            // Create client
            AccessContextManagerClient accessContextManagerClient = await AccessContextManagerClient.CreateAsync();
            // Initialize request argument(s)
            AccessPolicyName parent = AccessPolicyName.FromAccessPolicy("[ACCESS_POLICY]");
            // Make the request
            PagedAsyncEnumerable<ListAccessLevelsResponse, AccessLevel> response = accessContextManagerClient.ListAccessLevelsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AccessLevel item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAccessLevelsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AccessLevel item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AccessLevel> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AccessLevel item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetAccessLevel</summary>
        public void GetAccessLevelRequestObject()
        {
            // Snippet: GetAccessLevel(GetAccessLevelRequest, CallSettings)
            // Create client
            AccessContextManagerClient accessContextManagerClient = AccessContextManagerClient.Create();
            // Initialize request argument(s)
            GetAccessLevelRequest request = new GetAccessLevelRequest
            {
                AccessLevelName = AccessLevelName.FromAccessPolicyAccessLevel("[ACCESS_POLICY]", "[ACCESS_LEVEL]"),
                AccessLevelFormat = LevelFormat.Unspecified,
            };
            // Make the request
            AccessLevel response = accessContextManagerClient.GetAccessLevel(request);
            // End snippet
        }

        /// <summary>Snippet for GetAccessLevelAsync</summary>
        public async Task GetAccessLevelRequestObjectAsync()
        {
            // Snippet: GetAccessLevelAsync(GetAccessLevelRequest, CallSettings)
            // Additional: GetAccessLevelAsync(GetAccessLevelRequest, CancellationToken)
            // Create client
            AccessContextManagerClient accessContextManagerClient = await AccessContextManagerClient.CreateAsync();
            // Initialize request argument(s)
            GetAccessLevelRequest request = new GetAccessLevelRequest
            {
                AccessLevelName = AccessLevelName.FromAccessPolicyAccessLevel("[ACCESS_POLICY]", "[ACCESS_LEVEL]"),
                AccessLevelFormat = LevelFormat.Unspecified,
            };
            // Make the request
            AccessLevel response = await accessContextManagerClient.GetAccessLevelAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAccessLevel</summary>
        public void GetAccessLevel()
        {
            // Snippet: GetAccessLevel(string, CallSettings)
            // Create client
            AccessContextManagerClient accessContextManagerClient = AccessContextManagerClient.Create();
            // Initialize request argument(s)
            string name = "accessPolicies/[ACCESS_POLICY]/accessLevels/[ACCESS_LEVEL]";
            // Make the request
            AccessLevel response = accessContextManagerClient.GetAccessLevel(name);
            // End snippet
        }

        /// <summary>Snippet for GetAccessLevelAsync</summary>
        public async Task GetAccessLevelAsync()
        {
            // Snippet: GetAccessLevelAsync(string, CallSettings)
            // Additional: GetAccessLevelAsync(string, CancellationToken)
            // Create client
            AccessContextManagerClient accessContextManagerClient = await AccessContextManagerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "accessPolicies/[ACCESS_POLICY]/accessLevels/[ACCESS_LEVEL]";
            // Make the request
            AccessLevel response = await accessContextManagerClient.GetAccessLevelAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetAccessLevel</summary>
        public void GetAccessLevelResourceNames()
        {
            // Snippet: GetAccessLevel(AccessLevelName, CallSettings)
            // Create client
            AccessContextManagerClient accessContextManagerClient = AccessContextManagerClient.Create();
            // Initialize request argument(s)
            AccessLevelName name = AccessLevelName.FromAccessPolicyAccessLevel("[ACCESS_POLICY]", "[ACCESS_LEVEL]");
            // Make the request
            AccessLevel response = accessContextManagerClient.GetAccessLevel(name);
            // End snippet
        }

        /// <summary>Snippet for GetAccessLevelAsync</summary>
        public async Task GetAccessLevelResourceNamesAsync()
        {
            // Snippet: GetAccessLevelAsync(AccessLevelName, CallSettings)
            // Additional: GetAccessLevelAsync(AccessLevelName, CancellationToken)
            // Create client
            AccessContextManagerClient accessContextManagerClient = await AccessContextManagerClient.CreateAsync();
            // Initialize request argument(s)
            AccessLevelName name = AccessLevelName.FromAccessPolicyAccessLevel("[ACCESS_POLICY]", "[ACCESS_LEVEL]");
            // Make the request
            AccessLevel response = await accessContextManagerClient.GetAccessLevelAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateAccessLevel</summary>
        public void CreateAccessLevelRequestObject()
        {
            // Snippet: CreateAccessLevel(CreateAccessLevelRequest, CallSettings)
            // Create client
            AccessContextManagerClient accessContextManagerClient = AccessContextManagerClient.Create();
            // Initialize request argument(s)
            CreateAccessLevelRequest request = new CreateAccessLevelRequest
            {
                ParentAsAccessPolicyName = AccessPolicyName.FromAccessPolicy("[ACCESS_POLICY]"),
                AccessLevel = new AccessLevel(),
            };
            // Make the request
            Operation<AccessLevel, AccessContextManagerOperationMetadata> response = accessContextManagerClient.CreateAccessLevel(request);

            // Poll until the returned long-running operation is complete
            Operation<AccessLevel, AccessContextManagerOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AccessLevel result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AccessLevel, AccessContextManagerOperationMetadata> retrievedResponse = accessContextManagerClient.PollOnceCreateAccessLevel(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AccessLevel retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAccessLevelAsync</summary>
        public async Task CreateAccessLevelRequestObjectAsync()
        {
            // Snippet: CreateAccessLevelAsync(CreateAccessLevelRequest, CallSettings)
            // Additional: CreateAccessLevelAsync(CreateAccessLevelRequest, CancellationToken)
            // Create client
            AccessContextManagerClient accessContextManagerClient = await AccessContextManagerClient.CreateAsync();
            // Initialize request argument(s)
            CreateAccessLevelRequest request = new CreateAccessLevelRequest
            {
                ParentAsAccessPolicyName = AccessPolicyName.FromAccessPolicy("[ACCESS_POLICY]"),
                AccessLevel = new AccessLevel(),
            };
            // Make the request
            Operation<AccessLevel, AccessContextManagerOperationMetadata> response = await accessContextManagerClient.CreateAccessLevelAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<AccessLevel, AccessContextManagerOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AccessLevel result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AccessLevel, AccessContextManagerOperationMetadata> retrievedResponse = await accessContextManagerClient.PollOnceCreateAccessLevelAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AccessLevel retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAccessLevel</summary>
        public void CreateAccessLevel()
        {
            // Snippet: CreateAccessLevel(string, AccessLevel, CallSettings)
            // Create client
            AccessContextManagerClient accessContextManagerClient = AccessContextManagerClient.Create();
            // Initialize request argument(s)
            string parent = "accessPolicies/[ACCESS_POLICY]";
            AccessLevel accessLevel = new AccessLevel();
            // Make the request
            Operation<AccessLevel, AccessContextManagerOperationMetadata> response = accessContextManagerClient.CreateAccessLevel(parent, accessLevel);

            // Poll until the returned long-running operation is complete
            Operation<AccessLevel, AccessContextManagerOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AccessLevel result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AccessLevel, AccessContextManagerOperationMetadata> retrievedResponse = accessContextManagerClient.PollOnceCreateAccessLevel(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AccessLevel retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAccessLevelAsync</summary>
        public async Task CreateAccessLevelAsync()
        {
            // Snippet: CreateAccessLevelAsync(string, AccessLevel, CallSettings)
            // Additional: CreateAccessLevelAsync(string, AccessLevel, CancellationToken)
            // Create client
            AccessContextManagerClient accessContextManagerClient = await AccessContextManagerClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "accessPolicies/[ACCESS_POLICY]";
            AccessLevel accessLevel = new AccessLevel();
            // Make the request
            Operation<AccessLevel, AccessContextManagerOperationMetadata> response = await accessContextManagerClient.CreateAccessLevelAsync(parent, accessLevel);

            // Poll until the returned long-running operation is complete
            Operation<AccessLevel, AccessContextManagerOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AccessLevel result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AccessLevel, AccessContextManagerOperationMetadata> retrievedResponse = await accessContextManagerClient.PollOnceCreateAccessLevelAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AccessLevel retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAccessLevel</summary>
        public void CreateAccessLevelResourceNames()
        {
            // Snippet: CreateAccessLevel(AccessPolicyName, AccessLevel, CallSettings)
            // Create client
            AccessContextManagerClient accessContextManagerClient = AccessContextManagerClient.Create();
            // Initialize request argument(s)
            AccessPolicyName parent = AccessPolicyName.FromAccessPolicy("[ACCESS_POLICY]");
            AccessLevel accessLevel = new AccessLevel();
            // Make the request
            Operation<AccessLevel, AccessContextManagerOperationMetadata> response = accessContextManagerClient.CreateAccessLevel(parent, accessLevel);

            // Poll until the returned long-running operation is complete
            Operation<AccessLevel, AccessContextManagerOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AccessLevel result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AccessLevel, AccessContextManagerOperationMetadata> retrievedResponse = accessContextManagerClient.PollOnceCreateAccessLevel(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AccessLevel retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAccessLevelAsync</summary>
        public async Task CreateAccessLevelResourceNamesAsync()
        {
            // Snippet: CreateAccessLevelAsync(AccessPolicyName, AccessLevel, CallSettings)
            // Additional: CreateAccessLevelAsync(AccessPolicyName, AccessLevel, CancellationToken)
            // Create client
            AccessContextManagerClient accessContextManagerClient = await AccessContextManagerClient.CreateAsync();
            // Initialize request argument(s)
            AccessPolicyName parent = AccessPolicyName.FromAccessPolicy("[ACCESS_POLICY]");
            AccessLevel accessLevel = new AccessLevel();
            // Make the request
            Operation<AccessLevel, AccessContextManagerOperationMetadata> response = await accessContextManagerClient.CreateAccessLevelAsync(parent, accessLevel);

            // Poll until the returned long-running operation is complete
            Operation<AccessLevel, AccessContextManagerOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AccessLevel result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AccessLevel, AccessContextManagerOperationMetadata> retrievedResponse = await accessContextManagerClient.PollOnceCreateAccessLevelAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AccessLevel retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateAccessLevel</summary>
        public void UpdateAccessLevelRequestObject()
        {
            // Snippet: UpdateAccessLevel(UpdateAccessLevelRequest, CallSettings)
            // Create client
            AccessContextManagerClient accessContextManagerClient = AccessContextManagerClient.Create();
            // Initialize request argument(s)
            UpdateAccessLevelRequest request = new UpdateAccessLevelRequest
            {
                AccessLevel = new AccessLevel(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<AccessLevel, AccessContextManagerOperationMetadata> response = accessContextManagerClient.UpdateAccessLevel(request);

            // Poll until the returned long-running operation is complete
            Operation<AccessLevel, AccessContextManagerOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AccessLevel result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AccessLevel, AccessContextManagerOperationMetadata> retrievedResponse = accessContextManagerClient.PollOnceUpdateAccessLevel(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AccessLevel retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateAccessLevelAsync</summary>
        public async Task UpdateAccessLevelRequestObjectAsync()
        {
            // Snippet: UpdateAccessLevelAsync(UpdateAccessLevelRequest, CallSettings)
            // Additional: UpdateAccessLevelAsync(UpdateAccessLevelRequest, CancellationToken)
            // Create client
            AccessContextManagerClient accessContextManagerClient = await AccessContextManagerClient.CreateAsync();
            // Initialize request argument(s)
            UpdateAccessLevelRequest request = new UpdateAccessLevelRequest
            {
                AccessLevel = new AccessLevel(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<AccessLevel, AccessContextManagerOperationMetadata> response = await accessContextManagerClient.UpdateAccessLevelAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<AccessLevel, AccessContextManagerOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AccessLevel result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AccessLevel, AccessContextManagerOperationMetadata> retrievedResponse = await accessContextManagerClient.PollOnceUpdateAccessLevelAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AccessLevel retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateAccessLevel</summary>
        public void UpdateAccessLevel()
        {
            // Snippet: UpdateAccessLevel(AccessLevel, FieldMask, CallSettings)
            // Create client
            AccessContextManagerClient accessContextManagerClient = AccessContextManagerClient.Create();
            // Initialize request argument(s)
            AccessLevel accessLevel = new AccessLevel();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<AccessLevel, AccessContextManagerOperationMetadata> response = accessContextManagerClient.UpdateAccessLevel(accessLevel, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<AccessLevel, AccessContextManagerOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AccessLevel result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AccessLevel, AccessContextManagerOperationMetadata> retrievedResponse = accessContextManagerClient.PollOnceUpdateAccessLevel(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AccessLevel retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateAccessLevelAsync</summary>
        public async Task UpdateAccessLevelAsync()
        {
            // Snippet: UpdateAccessLevelAsync(AccessLevel, FieldMask, CallSettings)
            // Additional: UpdateAccessLevelAsync(AccessLevel, FieldMask, CancellationToken)
            // Create client
            AccessContextManagerClient accessContextManagerClient = await AccessContextManagerClient.CreateAsync();
            // Initialize request argument(s)
            AccessLevel accessLevel = new AccessLevel();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<AccessLevel, AccessContextManagerOperationMetadata> response = await accessContextManagerClient.UpdateAccessLevelAsync(accessLevel, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<AccessLevel, AccessContextManagerOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AccessLevel result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AccessLevel, AccessContextManagerOperationMetadata> retrievedResponse = await accessContextManagerClient.PollOnceUpdateAccessLevelAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AccessLevel retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAccessLevel</summary>
        public void DeleteAccessLevelRequestObject()
        {
            // Snippet: DeleteAccessLevel(DeleteAccessLevelRequest, CallSettings)
            // Create client
            AccessContextManagerClient accessContextManagerClient = AccessContextManagerClient.Create();
            // Initialize request argument(s)
            DeleteAccessLevelRequest request = new DeleteAccessLevelRequest
            {
                AccessLevelName = AccessLevelName.FromAccessPolicyAccessLevel("[ACCESS_POLICY]", "[ACCESS_LEVEL]"),
            };
            // Make the request
            Operation<Empty, AccessContextManagerOperationMetadata> response = accessContextManagerClient.DeleteAccessLevel(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, AccessContextManagerOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, AccessContextManagerOperationMetadata> retrievedResponse = accessContextManagerClient.PollOnceDeleteAccessLevel(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAccessLevelAsync</summary>
        public async Task DeleteAccessLevelRequestObjectAsync()
        {
            // Snippet: DeleteAccessLevelAsync(DeleteAccessLevelRequest, CallSettings)
            // Additional: DeleteAccessLevelAsync(DeleteAccessLevelRequest, CancellationToken)
            // Create client
            AccessContextManagerClient accessContextManagerClient = await AccessContextManagerClient.CreateAsync();
            // Initialize request argument(s)
            DeleteAccessLevelRequest request = new DeleteAccessLevelRequest
            {
                AccessLevelName = AccessLevelName.FromAccessPolicyAccessLevel("[ACCESS_POLICY]", "[ACCESS_LEVEL]"),
            };
            // Make the request
            Operation<Empty, AccessContextManagerOperationMetadata> response = await accessContextManagerClient.DeleteAccessLevelAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, AccessContextManagerOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, AccessContextManagerOperationMetadata> retrievedResponse = await accessContextManagerClient.PollOnceDeleteAccessLevelAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAccessLevel</summary>
        public void DeleteAccessLevel()
        {
            // Snippet: DeleteAccessLevel(string, CallSettings)
            // Create client
            AccessContextManagerClient accessContextManagerClient = AccessContextManagerClient.Create();
            // Initialize request argument(s)
            string name = "accessPolicies/[ACCESS_POLICY]/accessLevels/[ACCESS_LEVEL]";
            // Make the request
            Operation<Empty, AccessContextManagerOperationMetadata> response = accessContextManagerClient.DeleteAccessLevel(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, AccessContextManagerOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, AccessContextManagerOperationMetadata> retrievedResponse = accessContextManagerClient.PollOnceDeleteAccessLevel(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAccessLevelAsync</summary>
        public async Task DeleteAccessLevelAsync()
        {
            // Snippet: DeleteAccessLevelAsync(string, CallSettings)
            // Additional: DeleteAccessLevelAsync(string, CancellationToken)
            // Create client
            AccessContextManagerClient accessContextManagerClient = await AccessContextManagerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "accessPolicies/[ACCESS_POLICY]/accessLevels/[ACCESS_LEVEL]";
            // Make the request
            Operation<Empty, AccessContextManagerOperationMetadata> response = await accessContextManagerClient.DeleteAccessLevelAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, AccessContextManagerOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, AccessContextManagerOperationMetadata> retrievedResponse = await accessContextManagerClient.PollOnceDeleteAccessLevelAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAccessLevel</summary>
        public void DeleteAccessLevelResourceNames()
        {
            // Snippet: DeleteAccessLevel(AccessLevelName, CallSettings)
            // Create client
            AccessContextManagerClient accessContextManagerClient = AccessContextManagerClient.Create();
            // Initialize request argument(s)
            AccessLevelName name = AccessLevelName.FromAccessPolicyAccessLevel("[ACCESS_POLICY]", "[ACCESS_LEVEL]");
            // Make the request
            Operation<Empty, AccessContextManagerOperationMetadata> response = accessContextManagerClient.DeleteAccessLevel(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, AccessContextManagerOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, AccessContextManagerOperationMetadata> retrievedResponse = accessContextManagerClient.PollOnceDeleteAccessLevel(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAccessLevelAsync</summary>
        public async Task DeleteAccessLevelResourceNamesAsync()
        {
            // Snippet: DeleteAccessLevelAsync(AccessLevelName, CallSettings)
            // Additional: DeleteAccessLevelAsync(AccessLevelName, CancellationToken)
            // Create client
            AccessContextManagerClient accessContextManagerClient = await AccessContextManagerClient.CreateAsync();
            // Initialize request argument(s)
            AccessLevelName name = AccessLevelName.FromAccessPolicyAccessLevel("[ACCESS_POLICY]", "[ACCESS_LEVEL]");
            // Make the request
            Operation<Empty, AccessContextManagerOperationMetadata> response = await accessContextManagerClient.DeleteAccessLevelAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, AccessContextManagerOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, AccessContextManagerOperationMetadata> retrievedResponse = await accessContextManagerClient.PollOnceDeleteAccessLevelAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ReplaceAccessLevels</summary>
        public void ReplaceAccessLevelsRequestObject()
        {
            // Snippet: ReplaceAccessLevels(ReplaceAccessLevelsRequest, CallSettings)
            // Create client
            AccessContextManagerClient accessContextManagerClient = AccessContextManagerClient.Create();
            // Initialize request argument(s)
            ReplaceAccessLevelsRequest request = new ReplaceAccessLevelsRequest
            {
                ParentAsAccessPolicyName = AccessPolicyName.FromAccessPolicy("[ACCESS_POLICY]"),
                AccessLevels = { new AccessLevel(), },
                Etag = "",
            };
            // Make the request
            Operation<ReplaceAccessLevelsResponse, AccessContextManagerOperationMetadata> response = accessContextManagerClient.ReplaceAccessLevels(request);

            // Poll until the returned long-running operation is complete
            Operation<ReplaceAccessLevelsResponse, AccessContextManagerOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ReplaceAccessLevelsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ReplaceAccessLevelsResponse, AccessContextManagerOperationMetadata> retrievedResponse = accessContextManagerClient.PollOnceReplaceAccessLevels(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ReplaceAccessLevelsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ReplaceAccessLevelsAsync</summary>
        public async Task ReplaceAccessLevelsRequestObjectAsync()
        {
            // Snippet: ReplaceAccessLevelsAsync(ReplaceAccessLevelsRequest, CallSettings)
            // Additional: ReplaceAccessLevelsAsync(ReplaceAccessLevelsRequest, CancellationToken)
            // Create client
            AccessContextManagerClient accessContextManagerClient = await AccessContextManagerClient.CreateAsync();
            // Initialize request argument(s)
            ReplaceAccessLevelsRequest request = new ReplaceAccessLevelsRequest
            {
                ParentAsAccessPolicyName = AccessPolicyName.FromAccessPolicy("[ACCESS_POLICY]"),
                AccessLevels = { new AccessLevel(), },
                Etag = "",
            };
            // Make the request
            Operation<ReplaceAccessLevelsResponse, AccessContextManagerOperationMetadata> response = await accessContextManagerClient.ReplaceAccessLevelsAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ReplaceAccessLevelsResponse, AccessContextManagerOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ReplaceAccessLevelsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ReplaceAccessLevelsResponse, AccessContextManagerOperationMetadata> retrievedResponse = await accessContextManagerClient.PollOnceReplaceAccessLevelsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ReplaceAccessLevelsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListServicePerimeters</summary>
        public void ListServicePerimetersRequestObject()
        {
            // Snippet: ListServicePerimeters(ListServicePerimetersRequest, CallSettings)
            // Create client
            AccessContextManagerClient accessContextManagerClient = AccessContextManagerClient.Create();
            // Initialize request argument(s)
            ListServicePerimetersRequest request = new ListServicePerimetersRequest
            {
                ParentAsAccessPolicyName = AccessPolicyName.FromAccessPolicy("[ACCESS_POLICY]"),
            };
            // Make the request
            PagedEnumerable<ListServicePerimetersResponse, ServicePerimeter> response = accessContextManagerClient.ListServicePerimeters(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ServicePerimeter item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListServicePerimetersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ServicePerimeter item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ServicePerimeter> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ServicePerimeter item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListServicePerimetersAsync</summary>
        public async Task ListServicePerimetersRequestObjectAsync()
        {
            // Snippet: ListServicePerimetersAsync(ListServicePerimetersRequest, CallSettings)
            // Create client
            AccessContextManagerClient accessContextManagerClient = await AccessContextManagerClient.CreateAsync();
            // Initialize request argument(s)
            ListServicePerimetersRequest request = new ListServicePerimetersRequest
            {
                ParentAsAccessPolicyName = AccessPolicyName.FromAccessPolicy("[ACCESS_POLICY]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListServicePerimetersResponse, ServicePerimeter> response = accessContextManagerClient.ListServicePerimetersAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ServicePerimeter item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListServicePerimetersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ServicePerimeter item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ServicePerimeter> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ServicePerimeter item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListServicePerimeters</summary>
        public void ListServicePerimeters()
        {
            // Snippet: ListServicePerimeters(string, string, int?, CallSettings)
            // Create client
            AccessContextManagerClient accessContextManagerClient = AccessContextManagerClient.Create();
            // Initialize request argument(s)
            string parent = "accessPolicies/[ACCESS_POLICY]";
            // Make the request
            PagedEnumerable<ListServicePerimetersResponse, ServicePerimeter> response = accessContextManagerClient.ListServicePerimeters(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ServicePerimeter item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListServicePerimetersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ServicePerimeter item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ServicePerimeter> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ServicePerimeter item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListServicePerimetersAsync</summary>
        public async Task ListServicePerimetersAsync()
        {
            // Snippet: ListServicePerimetersAsync(string, string, int?, CallSettings)
            // Create client
            AccessContextManagerClient accessContextManagerClient = await AccessContextManagerClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "accessPolicies/[ACCESS_POLICY]";
            // Make the request
            PagedAsyncEnumerable<ListServicePerimetersResponse, ServicePerimeter> response = accessContextManagerClient.ListServicePerimetersAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ServicePerimeter item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListServicePerimetersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ServicePerimeter item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ServicePerimeter> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ServicePerimeter item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListServicePerimeters</summary>
        public void ListServicePerimetersResourceNames()
        {
            // Snippet: ListServicePerimeters(AccessPolicyName, string, int?, CallSettings)
            // Create client
            AccessContextManagerClient accessContextManagerClient = AccessContextManagerClient.Create();
            // Initialize request argument(s)
            AccessPolicyName parent = AccessPolicyName.FromAccessPolicy("[ACCESS_POLICY]");
            // Make the request
            PagedEnumerable<ListServicePerimetersResponse, ServicePerimeter> response = accessContextManagerClient.ListServicePerimeters(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ServicePerimeter item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListServicePerimetersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ServicePerimeter item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ServicePerimeter> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ServicePerimeter item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListServicePerimetersAsync</summary>
        public async Task ListServicePerimetersResourceNamesAsync()
        {
            // Snippet: ListServicePerimetersAsync(AccessPolicyName, string, int?, CallSettings)
            // Create client
            AccessContextManagerClient accessContextManagerClient = await AccessContextManagerClient.CreateAsync();
            // Initialize request argument(s)
            AccessPolicyName parent = AccessPolicyName.FromAccessPolicy("[ACCESS_POLICY]");
            // Make the request
            PagedAsyncEnumerable<ListServicePerimetersResponse, ServicePerimeter> response = accessContextManagerClient.ListServicePerimetersAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ServicePerimeter item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListServicePerimetersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ServicePerimeter item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ServicePerimeter> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ServicePerimeter item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetServicePerimeter</summary>
        public void GetServicePerimeterRequestObject()
        {
            // Snippet: GetServicePerimeter(GetServicePerimeterRequest, CallSettings)
            // Create client
            AccessContextManagerClient accessContextManagerClient = AccessContextManagerClient.Create();
            // Initialize request argument(s)
            GetServicePerimeterRequest request = new GetServicePerimeterRequest
            {
                ServicePerimeterName = ServicePerimeterName.FromAccessPolicyServicePerimeter("[ACCESS_POLICY]", "[SERVICE_PERIMETER]"),
            };
            // Make the request
            ServicePerimeter response = accessContextManagerClient.GetServicePerimeter(request);
            // End snippet
        }

        /// <summary>Snippet for GetServicePerimeterAsync</summary>
        public async Task GetServicePerimeterRequestObjectAsync()
        {
            // Snippet: GetServicePerimeterAsync(GetServicePerimeterRequest, CallSettings)
            // Additional: GetServicePerimeterAsync(GetServicePerimeterRequest, CancellationToken)
            // Create client
            AccessContextManagerClient accessContextManagerClient = await AccessContextManagerClient.CreateAsync();
            // Initialize request argument(s)
            GetServicePerimeterRequest request = new GetServicePerimeterRequest
            {
                ServicePerimeterName = ServicePerimeterName.FromAccessPolicyServicePerimeter("[ACCESS_POLICY]", "[SERVICE_PERIMETER]"),
            };
            // Make the request
            ServicePerimeter response = await accessContextManagerClient.GetServicePerimeterAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetServicePerimeter</summary>
        public void GetServicePerimeter()
        {
            // Snippet: GetServicePerimeter(string, CallSettings)
            // Create client
            AccessContextManagerClient accessContextManagerClient = AccessContextManagerClient.Create();
            // Initialize request argument(s)
            string name = "accessPolicies/[ACCESS_POLICY]/servicePerimeters/[SERVICE_PERIMETER]";
            // Make the request
            ServicePerimeter response = accessContextManagerClient.GetServicePerimeter(name);
            // End snippet
        }

        /// <summary>Snippet for GetServicePerimeterAsync</summary>
        public async Task GetServicePerimeterAsync()
        {
            // Snippet: GetServicePerimeterAsync(string, CallSettings)
            // Additional: GetServicePerimeterAsync(string, CancellationToken)
            // Create client
            AccessContextManagerClient accessContextManagerClient = await AccessContextManagerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "accessPolicies/[ACCESS_POLICY]/servicePerimeters/[SERVICE_PERIMETER]";
            // Make the request
            ServicePerimeter response = await accessContextManagerClient.GetServicePerimeterAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetServicePerimeter</summary>
        public void GetServicePerimeterResourceNames()
        {
            // Snippet: GetServicePerimeter(ServicePerimeterName, CallSettings)
            // Create client
            AccessContextManagerClient accessContextManagerClient = AccessContextManagerClient.Create();
            // Initialize request argument(s)
            ServicePerimeterName name = ServicePerimeterName.FromAccessPolicyServicePerimeter("[ACCESS_POLICY]", "[SERVICE_PERIMETER]");
            // Make the request
            ServicePerimeter response = accessContextManagerClient.GetServicePerimeter(name);
            // End snippet
        }

        /// <summary>Snippet for GetServicePerimeterAsync</summary>
        public async Task GetServicePerimeterResourceNamesAsync()
        {
            // Snippet: GetServicePerimeterAsync(ServicePerimeterName, CallSettings)
            // Additional: GetServicePerimeterAsync(ServicePerimeterName, CancellationToken)
            // Create client
            AccessContextManagerClient accessContextManagerClient = await AccessContextManagerClient.CreateAsync();
            // Initialize request argument(s)
            ServicePerimeterName name = ServicePerimeterName.FromAccessPolicyServicePerimeter("[ACCESS_POLICY]", "[SERVICE_PERIMETER]");
            // Make the request
            ServicePerimeter response = await accessContextManagerClient.GetServicePerimeterAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateServicePerimeter</summary>
        public void CreateServicePerimeterRequestObject()
        {
            // Snippet: CreateServicePerimeter(CreateServicePerimeterRequest, CallSettings)
            // Create client
            AccessContextManagerClient accessContextManagerClient = AccessContextManagerClient.Create();
            // Initialize request argument(s)
            CreateServicePerimeterRequest request = new CreateServicePerimeterRequest
            {
                ParentAsAccessPolicyName = AccessPolicyName.FromAccessPolicy("[ACCESS_POLICY]"),
                ServicePerimeter = new ServicePerimeter(),
            };
            // Make the request
            Operation<ServicePerimeter, AccessContextManagerOperationMetadata> response = accessContextManagerClient.CreateServicePerimeter(request);

            // Poll until the returned long-running operation is complete
            Operation<ServicePerimeter, AccessContextManagerOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ServicePerimeter result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ServicePerimeter, AccessContextManagerOperationMetadata> retrievedResponse = accessContextManagerClient.PollOnceCreateServicePerimeter(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ServicePerimeter retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateServicePerimeterAsync</summary>
        public async Task CreateServicePerimeterRequestObjectAsync()
        {
            // Snippet: CreateServicePerimeterAsync(CreateServicePerimeterRequest, CallSettings)
            // Additional: CreateServicePerimeterAsync(CreateServicePerimeterRequest, CancellationToken)
            // Create client
            AccessContextManagerClient accessContextManagerClient = await AccessContextManagerClient.CreateAsync();
            // Initialize request argument(s)
            CreateServicePerimeterRequest request = new CreateServicePerimeterRequest
            {
                ParentAsAccessPolicyName = AccessPolicyName.FromAccessPolicy("[ACCESS_POLICY]"),
                ServicePerimeter = new ServicePerimeter(),
            };
            // Make the request
            Operation<ServicePerimeter, AccessContextManagerOperationMetadata> response = await accessContextManagerClient.CreateServicePerimeterAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ServicePerimeter, AccessContextManagerOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ServicePerimeter result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ServicePerimeter, AccessContextManagerOperationMetadata> retrievedResponse = await accessContextManagerClient.PollOnceCreateServicePerimeterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ServicePerimeter retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateServicePerimeter</summary>
        public void CreateServicePerimeter()
        {
            // Snippet: CreateServicePerimeter(string, ServicePerimeter, CallSettings)
            // Create client
            AccessContextManagerClient accessContextManagerClient = AccessContextManagerClient.Create();
            // Initialize request argument(s)
            string parent = "accessPolicies/[ACCESS_POLICY]";
            ServicePerimeter servicePerimeter = new ServicePerimeter();
            // Make the request
            Operation<ServicePerimeter, AccessContextManagerOperationMetadata> response = accessContextManagerClient.CreateServicePerimeter(parent, servicePerimeter);

            // Poll until the returned long-running operation is complete
            Operation<ServicePerimeter, AccessContextManagerOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ServicePerimeter result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ServicePerimeter, AccessContextManagerOperationMetadata> retrievedResponse = accessContextManagerClient.PollOnceCreateServicePerimeter(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ServicePerimeter retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateServicePerimeterAsync</summary>
        public async Task CreateServicePerimeterAsync()
        {
            // Snippet: CreateServicePerimeterAsync(string, ServicePerimeter, CallSettings)
            // Additional: CreateServicePerimeterAsync(string, ServicePerimeter, CancellationToken)
            // Create client
            AccessContextManagerClient accessContextManagerClient = await AccessContextManagerClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "accessPolicies/[ACCESS_POLICY]";
            ServicePerimeter servicePerimeter = new ServicePerimeter();
            // Make the request
            Operation<ServicePerimeter, AccessContextManagerOperationMetadata> response = await accessContextManagerClient.CreateServicePerimeterAsync(parent, servicePerimeter);

            // Poll until the returned long-running operation is complete
            Operation<ServicePerimeter, AccessContextManagerOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ServicePerimeter result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ServicePerimeter, AccessContextManagerOperationMetadata> retrievedResponse = await accessContextManagerClient.PollOnceCreateServicePerimeterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ServicePerimeter retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateServicePerimeter</summary>
        public void CreateServicePerimeterResourceNames()
        {
            // Snippet: CreateServicePerimeter(AccessPolicyName, ServicePerimeter, CallSettings)
            // Create client
            AccessContextManagerClient accessContextManagerClient = AccessContextManagerClient.Create();
            // Initialize request argument(s)
            AccessPolicyName parent = AccessPolicyName.FromAccessPolicy("[ACCESS_POLICY]");
            ServicePerimeter servicePerimeter = new ServicePerimeter();
            // Make the request
            Operation<ServicePerimeter, AccessContextManagerOperationMetadata> response = accessContextManagerClient.CreateServicePerimeter(parent, servicePerimeter);

            // Poll until the returned long-running operation is complete
            Operation<ServicePerimeter, AccessContextManagerOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ServicePerimeter result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ServicePerimeter, AccessContextManagerOperationMetadata> retrievedResponse = accessContextManagerClient.PollOnceCreateServicePerimeter(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ServicePerimeter retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateServicePerimeterAsync</summary>
        public async Task CreateServicePerimeterResourceNamesAsync()
        {
            // Snippet: CreateServicePerimeterAsync(AccessPolicyName, ServicePerimeter, CallSettings)
            // Additional: CreateServicePerimeterAsync(AccessPolicyName, ServicePerimeter, CancellationToken)
            // Create client
            AccessContextManagerClient accessContextManagerClient = await AccessContextManagerClient.CreateAsync();
            // Initialize request argument(s)
            AccessPolicyName parent = AccessPolicyName.FromAccessPolicy("[ACCESS_POLICY]");
            ServicePerimeter servicePerimeter = new ServicePerimeter();
            // Make the request
            Operation<ServicePerimeter, AccessContextManagerOperationMetadata> response = await accessContextManagerClient.CreateServicePerimeterAsync(parent, servicePerimeter);

            // Poll until the returned long-running operation is complete
            Operation<ServicePerimeter, AccessContextManagerOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ServicePerimeter result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ServicePerimeter, AccessContextManagerOperationMetadata> retrievedResponse = await accessContextManagerClient.PollOnceCreateServicePerimeterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ServicePerimeter retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateServicePerimeter</summary>
        public void UpdateServicePerimeterRequestObject()
        {
            // Snippet: UpdateServicePerimeter(UpdateServicePerimeterRequest, CallSettings)
            // Create client
            AccessContextManagerClient accessContextManagerClient = AccessContextManagerClient.Create();
            // Initialize request argument(s)
            UpdateServicePerimeterRequest request = new UpdateServicePerimeterRequest
            {
                ServicePerimeter = new ServicePerimeter(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<ServicePerimeter, AccessContextManagerOperationMetadata> response = accessContextManagerClient.UpdateServicePerimeter(request);

            // Poll until the returned long-running operation is complete
            Operation<ServicePerimeter, AccessContextManagerOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ServicePerimeter result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ServicePerimeter, AccessContextManagerOperationMetadata> retrievedResponse = accessContextManagerClient.PollOnceUpdateServicePerimeter(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ServicePerimeter retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateServicePerimeterAsync</summary>
        public async Task UpdateServicePerimeterRequestObjectAsync()
        {
            // Snippet: UpdateServicePerimeterAsync(UpdateServicePerimeterRequest, CallSettings)
            // Additional: UpdateServicePerimeterAsync(UpdateServicePerimeterRequest, CancellationToken)
            // Create client
            AccessContextManagerClient accessContextManagerClient = await AccessContextManagerClient.CreateAsync();
            // Initialize request argument(s)
            UpdateServicePerimeterRequest request = new UpdateServicePerimeterRequest
            {
                ServicePerimeter = new ServicePerimeter(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<ServicePerimeter, AccessContextManagerOperationMetadata> response = await accessContextManagerClient.UpdateServicePerimeterAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ServicePerimeter, AccessContextManagerOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ServicePerimeter result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ServicePerimeter, AccessContextManagerOperationMetadata> retrievedResponse = await accessContextManagerClient.PollOnceUpdateServicePerimeterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ServicePerimeter retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateServicePerimeter</summary>
        public void UpdateServicePerimeter()
        {
            // Snippet: UpdateServicePerimeter(ServicePerimeter, FieldMask, CallSettings)
            // Create client
            AccessContextManagerClient accessContextManagerClient = AccessContextManagerClient.Create();
            // Initialize request argument(s)
            ServicePerimeter servicePerimeter = new ServicePerimeter();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<ServicePerimeter, AccessContextManagerOperationMetadata> response = accessContextManagerClient.UpdateServicePerimeter(servicePerimeter, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<ServicePerimeter, AccessContextManagerOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ServicePerimeter result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ServicePerimeter, AccessContextManagerOperationMetadata> retrievedResponse = accessContextManagerClient.PollOnceUpdateServicePerimeter(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ServicePerimeter retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateServicePerimeterAsync</summary>
        public async Task UpdateServicePerimeterAsync()
        {
            // Snippet: UpdateServicePerimeterAsync(ServicePerimeter, FieldMask, CallSettings)
            // Additional: UpdateServicePerimeterAsync(ServicePerimeter, FieldMask, CancellationToken)
            // Create client
            AccessContextManagerClient accessContextManagerClient = await AccessContextManagerClient.CreateAsync();
            // Initialize request argument(s)
            ServicePerimeter servicePerimeter = new ServicePerimeter();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<ServicePerimeter, AccessContextManagerOperationMetadata> response = await accessContextManagerClient.UpdateServicePerimeterAsync(servicePerimeter, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<ServicePerimeter, AccessContextManagerOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ServicePerimeter result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ServicePerimeter, AccessContextManagerOperationMetadata> retrievedResponse = await accessContextManagerClient.PollOnceUpdateServicePerimeterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ServicePerimeter retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteServicePerimeter</summary>
        public void DeleteServicePerimeterRequestObject()
        {
            // Snippet: DeleteServicePerimeter(DeleteServicePerimeterRequest, CallSettings)
            // Create client
            AccessContextManagerClient accessContextManagerClient = AccessContextManagerClient.Create();
            // Initialize request argument(s)
            DeleteServicePerimeterRequest request = new DeleteServicePerimeterRequest
            {
                ServicePerimeterName = ServicePerimeterName.FromAccessPolicyServicePerimeter("[ACCESS_POLICY]", "[SERVICE_PERIMETER]"),
            };
            // Make the request
            Operation<Empty, AccessContextManagerOperationMetadata> response = accessContextManagerClient.DeleteServicePerimeter(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, AccessContextManagerOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, AccessContextManagerOperationMetadata> retrievedResponse = accessContextManagerClient.PollOnceDeleteServicePerimeter(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteServicePerimeterAsync</summary>
        public async Task DeleteServicePerimeterRequestObjectAsync()
        {
            // Snippet: DeleteServicePerimeterAsync(DeleteServicePerimeterRequest, CallSettings)
            // Additional: DeleteServicePerimeterAsync(DeleteServicePerimeterRequest, CancellationToken)
            // Create client
            AccessContextManagerClient accessContextManagerClient = await AccessContextManagerClient.CreateAsync();
            // Initialize request argument(s)
            DeleteServicePerimeterRequest request = new DeleteServicePerimeterRequest
            {
                ServicePerimeterName = ServicePerimeterName.FromAccessPolicyServicePerimeter("[ACCESS_POLICY]", "[SERVICE_PERIMETER]"),
            };
            // Make the request
            Operation<Empty, AccessContextManagerOperationMetadata> response = await accessContextManagerClient.DeleteServicePerimeterAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, AccessContextManagerOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, AccessContextManagerOperationMetadata> retrievedResponse = await accessContextManagerClient.PollOnceDeleteServicePerimeterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteServicePerimeter</summary>
        public void DeleteServicePerimeter()
        {
            // Snippet: DeleteServicePerimeter(string, CallSettings)
            // Create client
            AccessContextManagerClient accessContextManagerClient = AccessContextManagerClient.Create();
            // Initialize request argument(s)
            string name = "accessPolicies/[ACCESS_POLICY]/servicePerimeters/[SERVICE_PERIMETER]";
            // Make the request
            Operation<Empty, AccessContextManagerOperationMetadata> response = accessContextManagerClient.DeleteServicePerimeter(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, AccessContextManagerOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, AccessContextManagerOperationMetadata> retrievedResponse = accessContextManagerClient.PollOnceDeleteServicePerimeter(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteServicePerimeterAsync</summary>
        public async Task DeleteServicePerimeterAsync()
        {
            // Snippet: DeleteServicePerimeterAsync(string, CallSettings)
            // Additional: DeleteServicePerimeterAsync(string, CancellationToken)
            // Create client
            AccessContextManagerClient accessContextManagerClient = await AccessContextManagerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "accessPolicies/[ACCESS_POLICY]/servicePerimeters/[SERVICE_PERIMETER]";
            // Make the request
            Operation<Empty, AccessContextManagerOperationMetadata> response = await accessContextManagerClient.DeleteServicePerimeterAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, AccessContextManagerOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, AccessContextManagerOperationMetadata> retrievedResponse = await accessContextManagerClient.PollOnceDeleteServicePerimeterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteServicePerimeter</summary>
        public void DeleteServicePerimeterResourceNames()
        {
            // Snippet: DeleteServicePerimeter(ServicePerimeterName, CallSettings)
            // Create client
            AccessContextManagerClient accessContextManagerClient = AccessContextManagerClient.Create();
            // Initialize request argument(s)
            ServicePerimeterName name = ServicePerimeterName.FromAccessPolicyServicePerimeter("[ACCESS_POLICY]", "[SERVICE_PERIMETER]");
            // Make the request
            Operation<Empty, AccessContextManagerOperationMetadata> response = accessContextManagerClient.DeleteServicePerimeter(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, AccessContextManagerOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, AccessContextManagerOperationMetadata> retrievedResponse = accessContextManagerClient.PollOnceDeleteServicePerimeter(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteServicePerimeterAsync</summary>
        public async Task DeleteServicePerimeterResourceNamesAsync()
        {
            // Snippet: DeleteServicePerimeterAsync(ServicePerimeterName, CallSettings)
            // Additional: DeleteServicePerimeterAsync(ServicePerimeterName, CancellationToken)
            // Create client
            AccessContextManagerClient accessContextManagerClient = await AccessContextManagerClient.CreateAsync();
            // Initialize request argument(s)
            ServicePerimeterName name = ServicePerimeterName.FromAccessPolicyServicePerimeter("[ACCESS_POLICY]", "[SERVICE_PERIMETER]");
            // Make the request
            Operation<Empty, AccessContextManagerOperationMetadata> response = await accessContextManagerClient.DeleteServicePerimeterAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, AccessContextManagerOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, AccessContextManagerOperationMetadata> retrievedResponse = await accessContextManagerClient.PollOnceDeleteServicePerimeterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ReplaceServicePerimeters</summary>
        public void ReplaceServicePerimetersRequestObject()
        {
            // Snippet: ReplaceServicePerimeters(ReplaceServicePerimetersRequest, CallSettings)
            // Create client
            AccessContextManagerClient accessContextManagerClient = AccessContextManagerClient.Create();
            // Initialize request argument(s)
            ReplaceServicePerimetersRequest request = new ReplaceServicePerimetersRequest
            {
                ParentAsAccessPolicyName = AccessPolicyName.FromAccessPolicy("[ACCESS_POLICY]"),
                ServicePerimeters =
                {
                    new ServicePerimeter(),
                },
                Etag = "",
            };
            // Make the request
            Operation<ReplaceServicePerimetersResponse, AccessContextManagerOperationMetadata> response = accessContextManagerClient.ReplaceServicePerimeters(request);

            // Poll until the returned long-running operation is complete
            Operation<ReplaceServicePerimetersResponse, AccessContextManagerOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ReplaceServicePerimetersResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ReplaceServicePerimetersResponse, AccessContextManagerOperationMetadata> retrievedResponse = accessContextManagerClient.PollOnceReplaceServicePerimeters(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ReplaceServicePerimetersResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ReplaceServicePerimetersAsync</summary>
        public async Task ReplaceServicePerimetersRequestObjectAsync()
        {
            // Snippet: ReplaceServicePerimetersAsync(ReplaceServicePerimetersRequest, CallSettings)
            // Additional: ReplaceServicePerimetersAsync(ReplaceServicePerimetersRequest, CancellationToken)
            // Create client
            AccessContextManagerClient accessContextManagerClient = await AccessContextManagerClient.CreateAsync();
            // Initialize request argument(s)
            ReplaceServicePerimetersRequest request = new ReplaceServicePerimetersRequest
            {
                ParentAsAccessPolicyName = AccessPolicyName.FromAccessPolicy("[ACCESS_POLICY]"),
                ServicePerimeters =
                {
                    new ServicePerimeter(),
                },
                Etag = "",
            };
            // Make the request
            Operation<ReplaceServicePerimetersResponse, AccessContextManagerOperationMetadata> response = await accessContextManagerClient.ReplaceServicePerimetersAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ReplaceServicePerimetersResponse, AccessContextManagerOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ReplaceServicePerimetersResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ReplaceServicePerimetersResponse, AccessContextManagerOperationMetadata> retrievedResponse = await accessContextManagerClient.PollOnceReplaceServicePerimetersAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ReplaceServicePerimetersResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CommitServicePerimeters</summary>
        public void CommitServicePerimetersRequestObject()
        {
            // Snippet: CommitServicePerimeters(CommitServicePerimetersRequest, CallSettings)
            // Create client
            AccessContextManagerClient accessContextManagerClient = AccessContextManagerClient.Create();
            // Initialize request argument(s)
            CommitServicePerimetersRequest request = new CommitServicePerimetersRequest
            {
                ParentAsAccessPolicyName = AccessPolicyName.FromAccessPolicy("[ACCESS_POLICY]"),
                Etag = "",
            };
            // Make the request
            Operation<CommitServicePerimetersResponse, AccessContextManagerOperationMetadata> response = accessContextManagerClient.CommitServicePerimeters(request);

            // Poll until the returned long-running operation is complete
            Operation<CommitServicePerimetersResponse, AccessContextManagerOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            CommitServicePerimetersResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CommitServicePerimetersResponse, AccessContextManagerOperationMetadata> retrievedResponse = accessContextManagerClient.PollOnceCommitServicePerimeters(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CommitServicePerimetersResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CommitServicePerimetersAsync</summary>
        public async Task CommitServicePerimetersRequestObjectAsync()
        {
            // Snippet: CommitServicePerimetersAsync(CommitServicePerimetersRequest, CallSettings)
            // Additional: CommitServicePerimetersAsync(CommitServicePerimetersRequest, CancellationToken)
            // Create client
            AccessContextManagerClient accessContextManagerClient = await AccessContextManagerClient.CreateAsync();
            // Initialize request argument(s)
            CommitServicePerimetersRequest request = new CommitServicePerimetersRequest
            {
                ParentAsAccessPolicyName = AccessPolicyName.FromAccessPolicy("[ACCESS_POLICY]"),
                Etag = "",
            };
            // Make the request
            Operation<CommitServicePerimetersResponse, AccessContextManagerOperationMetadata> response = await accessContextManagerClient.CommitServicePerimetersAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<CommitServicePerimetersResponse, AccessContextManagerOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            CommitServicePerimetersResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CommitServicePerimetersResponse, AccessContextManagerOperationMetadata> retrievedResponse = await accessContextManagerClient.PollOnceCommitServicePerimetersAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CommitServicePerimetersResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListGcpUserAccessBindings</summary>
        public void ListGcpUserAccessBindingsRequestObject()
        {
            // Snippet: ListGcpUserAccessBindings(ListGcpUserAccessBindingsRequest, CallSettings)
            // Create client
            AccessContextManagerClient accessContextManagerClient = AccessContextManagerClient.Create();
            // Initialize request argument(s)
            ListGcpUserAccessBindingsRequest request = new ListGcpUserAccessBindingsRequest
            {
                ParentAsOrganizationName = OrganizationName.FromOrganization("[ORGANIZATION]"),
            };
            // Make the request
            PagedEnumerable<ListGcpUserAccessBindingsResponse, GcpUserAccessBinding> response = accessContextManagerClient.ListGcpUserAccessBindings(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (GcpUserAccessBinding item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListGcpUserAccessBindingsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (GcpUserAccessBinding item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<GcpUserAccessBinding> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (GcpUserAccessBinding item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGcpUserAccessBindingsAsync</summary>
        public async Task ListGcpUserAccessBindingsRequestObjectAsync()
        {
            // Snippet: ListGcpUserAccessBindingsAsync(ListGcpUserAccessBindingsRequest, CallSettings)
            // Create client
            AccessContextManagerClient accessContextManagerClient = await AccessContextManagerClient.CreateAsync();
            // Initialize request argument(s)
            ListGcpUserAccessBindingsRequest request = new ListGcpUserAccessBindingsRequest
            {
                ParentAsOrganizationName = OrganizationName.FromOrganization("[ORGANIZATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListGcpUserAccessBindingsResponse, GcpUserAccessBinding> response = accessContextManagerClient.ListGcpUserAccessBindingsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((GcpUserAccessBinding item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListGcpUserAccessBindingsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (GcpUserAccessBinding item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<GcpUserAccessBinding> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (GcpUserAccessBinding item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGcpUserAccessBindings</summary>
        public void ListGcpUserAccessBindings()
        {
            // Snippet: ListGcpUserAccessBindings(string, string, int?, CallSettings)
            // Create client
            AccessContextManagerClient accessContextManagerClient = AccessContextManagerClient.Create();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]";
            // Make the request
            PagedEnumerable<ListGcpUserAccessBindingsResponse, GcpUserAccessBinding> response = accessContextManagerClient.ListGcpUserAccessBindings(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (GcpUserAccessBinding item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListGcpUserAccessBindingsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (GcpUserAccessBinding item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<GcpUserAccessBinding> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (GcpUserAccessBinding item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGcpUserAccessBindingsAsync</summary>
        public async Task ListGcpUserAccessBindingsAsync()
        {
            // Snippet: ListGcpUserAccessBindingsAsync(string, string, int?, CallSettings)
            // Create client
            AccessContextManagerClient accessContextManagerClient = await AccessContextManagerClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]";
            // Make the request
            PagedAsyncEnumerable<ListGcpUserAccessBindingsResponse, GcpUserAccessBinding> response = accessContextManagerClient.ListGcpUserAccessBindingsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((GcpUserAccessBinding item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListGcpUserAccessBindingsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (GcpUserAccessBinding item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<GcpUserAccessBinding> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (GcpUserAccessBinding item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGcpUserAccessBindings</summary>
        public void ListGcpUserAccessBindingsResourceNames()
        {
            // Snippet: ListGcpUserAccessBindings(OrganizationName, string, int?, CallSettings)
            // Create client
            AccessContextManagerClient accessContextManagerClient = AccessContextManagerClient.Create();
            // Initialize request argument(s)
            OrganizationName parent = OrganizationName.FromOrganization("[ORGANIZATION]");
            // Make the request
            PagedEnumerable<ListGcpUserAccessBindingsResponse, GcpUserAccessBinding> response = accessContextManagerClient.ListGcpUserAccessBindings(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (GcpUserAccessBinding item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListGcpUserAccessBindingsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (GcpUserAccessBinding item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<GcpUserAccessBinding> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (GcpUserAccessBinding item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGcpUserAccessBindingsAsync</summary>
        public async Task ListGcpUserAccessBindingsResourceNamesAsync()
        {
            // Snippet: ListGcpUserAccessBindingsAsync(OrganizationName, string, int?, CallSettings)
            // Create client
            AccessContextManagerClient accessContextManagerClient = await AccessContextManagerClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationName parent = OrganizationName.FromOrganization("[ORGANIZATION]");
            // Make the request
            PagedAsyncEnumerable<ListGcpUserAccessBindingsResponse, GcpUserAccessBinding> response = accessContextManagerClient.ListGcpUserAccessBindingsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((GcpUserAccessBinding item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListGcpUserAccessBindingsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (GcpUserAccessBinding item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<GcpUserAccessBinding> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (GcpUserAccessBinding item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetGcpUserAccessBinding</summary>
        public void GetGcpUserAccessBindingRequestObject()
        {
            // Snippet: GetGcpUserAccessBinding(GetGcpUserAccessBindingRequest, CallSettings)
            // Create client
            AccessContextManagerClient accessContextManagerClient = AccessContextManagerClient.Create();
            // Initialize request argument(s)
            GetGcpUserAccessBindingRequest request = new GetGcpUserAccessBindingRequest
            {
                GcpUserAccessBindingName = GcpUserAccessBindingName.FromOrganizationGcpUserAccessBinding("[ORGANIZATION]", "[GCP_USER_ACCESS_BINDING]"),
            };
            // Make the request
            GcpUserAccessBinding response = accessContextManagerClient.GetGcpUserAccessBinding(request);
            // End snippet
        }

        /// <summary>Snippet for GetGcpUserAccessBindingAsync</summary>
        public async Task GetGcpUserAccessBindingRequestObjectAsync()
        {
            // Snippet: GetGcpUserAccessBindingAsync(GetGcpUserAccessBindingRequest, CallSettings)
            // Additional: GetGcpUserAccessBindingAsync(GetGcpUserAccessBindingRequest, CancellationToken)
            // Create client
            AccessContextManagerClient accessContextManagerClient = await AccessContextManagerClient.CreateAsync();
            // Initialize request argument(s)
            GetGcpUserAccessBindingRequest request = new GetGcpUserAccessBindingRequest
            {
                GcpUserAccessBindingName = GcpUserAccessBindingName.FromOrganizationGcpUserAccessBinding("[ORGANIZATION]", "[GCP_USER_ACCESS_BINDING]"),
            };
            // Make the request
            GcpUserAccessBinding response = await accessContextManagerClient.GetGcpUserAccessBindingAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetGcpUserAccessBinding</summary>
        public void GetGcpUserAccessBinding()
        {
            // Snippet: GetGcpUserAccessBinding(string, CallSettings)
            // Create client
            AccessContextManagerClient accessContextManagerClient = AccessContextManagerClient.Create();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/gcpUserAccessBindings/[GCP_USER_ACCESS_BINDING]";
            // Make the request
            GcpUserAccessBinding response = accessContextManagerClient.GetGcpUserAccessBinding(name);
            // End snippet
        }

        /// <summary>Snippet for GetGcpUserAccessBindingAsync</summary>
        public async Task GetGcpUserAccessBindingAsync()
        {
            // Snippet: GetGcpUserAccessBindingAsync(string, CallSettings)
            // Additional: GetGcpUserAccessBindingAsync(string, CancellationToken)
            // Create client
            AccessContextManagerClient accessContextManagerClient = await AccessContextManagerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/gcpUserAccessBindings/[GCP_USER_ACCESS_BINDING]";
            // Make the request
            GcpUserAccessBinding response = await accessContextManagerClient.GetGcpUserAccessBindingAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetGcpUserAccessBinding</summary>
        public void GetGcpUserAccessBindingResourceNames()
        {
            // Snippet: GetGcpUserAccessBinding(GcpUserAccessBindingName, CallSettings)
            // Create client
            AccessContextManagerClient accessContextManagerClient = AccessContextManagerClient.Create();
            // Initialize request argument(s)
            GcpUserAccessBindingName name = GcpUserAccessBindingName.FromOrganizationGcpUserAccessBinding("[ORGANIZATION]", "[GCP_USER_ACCESS_BINDING]");
            // Make the request
            GcpUserAccessBinding response = accessContextManagerClient.GetGcpUserAccessBinding(name);
            // End snippet
        }

        /// <summary>Snippet for GetGcpUserAccessBindingAsync</summary>
        public async Task GetGcpUserAccessBindingResourceNamesAsync()
        {
            // Snippet: GetGcpUserAccessBindingAsync(GcpUserAccessBindingName, CallSettings)
            // Additional: GetGcpUserAccessBindingAsync(GcpUserAccessBindingName, CancellationToken)
            // Create client
            AccessContextManagerClient accessContextManagerClient = await AccessContextManagerClient.CreateAsync();
            // Initialize request argument(s)
            GcpUserAccessBindingName name = GcpUserAccessBindingName.FromOrganizationGcpUserAccessBinding("[ORGANIZATION]", "[GCP_USER_ACCESS_BINDING]");
            // Make the request
            GcpUserAccessBinding response = await accessContextManagerClient.GetGcpUserAccessBindingAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateGcpUserAccessBinding</summary>
        public void CreateGcpUserAccessBindingRequestObject()
        {
            // Snippet: CreateGcpUserAccessBinding(CreateGcpUserAccessBindingRequest, CallSettings)
            // Create client
            AccessContextManagerClient accessContextManagerClient = AccessContextManagerClient.Create();
            // Initialize request argument(s)
            CreateGcpUserAccessBindingRequest request = new CreateGcpUserAccessBindingRequest
            {
                ParentAsOrganizationName = OrganizationName.FromOrganization("[ORGANIZATION]"),
                GcpUserAccessBinding = new GcpUserAccessBinding(),
            };
            // Make the request
            Operation<GcpUserAccessBinding, GcpUserAccessBindingOperationMetadata> response = accessContextManagerClient.CreateGcpUserAccessBinding(request);

            // Poll until the returned long-running operation is complete
            Operation<GcpUserAccessBinding, GcpUserAccessBindingOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            GcpUserAccessBinding result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GcpUserAccessBinding, GcpUserAccessBindingOperationMetadata> retrievedResponse = accessContextManagerClient.PollOnceCreateGcpUserAccessBinding(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GcpUserAccessBinding retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateGcpUserAccessBindingAsync</summary>
        public async Task CreateGcpUserAccessBindingRequestObjectAsync()
        {
            // Snippet: CreateGcpUserAccessBindingAsync(CreateGcpUserAccessBindingRequest, CallSettings)
            // Additional: CreateGcpUserAccessBindingAsync(CreateGcpUserAccessBindingRequest, CancellationToken)
            // Create client
            AccessContextManagerClient accessContextManagerClient = await AccessContextManagerClient.CreateAsync();
            // Initialize request argument(s)
            CreateGcpUserAccessBindingRequest request = new CreateGcpUserAccessBindingRequest
            {
                ParentAsOrganizationName = OrganizationName.FromOrganization("[ORGANIZATION]"),
                GcpUserAccessBinding = new GcpUserAccessBinding(),
            };
            // Make the request
            Operation<GcpUserAccessBinding, GcpUserAccessBindingOperationMetadata> response = await accessContextManagerClient.CreateGcpUserAccessBindingAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<GcpUserAccessBinding, GcpUserAccessBindingOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            GcpUserAccessBinding result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GcpUserAccessBinding, GcpUserAccessBindingOperationMetadata> retrievedResponse = await accessContextManagerClient.PollOnceCreateGcpUserAccessBindingAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GcpUserAccessBinding retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateGcpUserAccessBinding</summary>
        public void CreateGcpUserAccessBinding()
        {
            // Snippet: CreateGcpUserAccessBinding(string, GcpUserAccessBinding, CallSettings)
            // Create client
            AccessContextManagerClient accessContextManagerClient = AccessContextManagerClient.Create();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]";
            GcpUserAccessBinding gcpUserAccessBinding = new GcpUserAccessBinding();
            // Make the request
            Operation<GcpUserAccessBinding, GcpUserAccessBindingOperationMetadata> response = accessContextManagerClient.CreateGcpUserAccessBinding(parent, gcpUserAccessBinding);

            // Poll until the returned long-running operation is complete
            Operation<GcpUserAccessBinding, GcpUserAccessBindingOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            GcpUserAccessBinding result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GcpUserAccessBinding, GcpUserAccessBindingOperationMetadata> retrievedResponse = accessContextManagerClient.PollOnceCreateGcpUserAccessBinding(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GcpUserAccessBinding retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateGcpUserAccessBindingAsync</summary>
        public async Task CreateGcpUserAccessBindingAsync()
        {
            // Snippet: CreateGcpUserAccessBindingAsync(string, GcpUserAccessBinding, CallSettings)
            // Additional: CreateGcpUserAccessBindingAsync(string, GcpUserAccessBinding, CancellationToken)
            // Create client
            AccessContextManagerClient accessContextManagerClient = await AccessContextManagerClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]";
            GcpUserAccessBinding gcpUserAccessBinding = new GcpUserAccessBinding();
            // Make the request
            Operation<GcpUserAccessBinding, GcpUserAccessBindingOperationMetadata> response = await accessContextManagerClient.CreateGcpUserAccessBindingAsync(parent, gcpUserAccessBinding);

            // Poll until the returned long-running operation is complete
            Operation<GcpUserAccessBinding, GcpUserAccessBindingOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            GcpUserAccessBinding result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GcpUserAccessBinding, GcpUserAccessBindingOperationMetadata> retrievedResponse = await accessContextManagerClient.PollOnceCreateGcpUserAccessBindingAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GcpUserAccessBinding retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateGcpUserAccessBinding</summary>
        public void CreateGcpUserAccessBindingResourceNames()
        {
            // Snippet: CreateGcpUserAccessBinding(OrganizationName, GcpUserAccessBinding, CallSettings)
            // Create client
            AccessContextManagerClient accessContextManagerClient = AccessContextManagerClient.Create();
            // Initialize request argument(s)
            OrganizationName parent = OrganizationName.FromOrganization("[ORGANIZATION]");
            GcpUserAccessBinding gcpUserAccessBinding = new GcpUserAccessBinding();
            // Make the request
            Operation<GcpUserAccessBinding, GcpUserAccessBindingOperationMetadata> response = accessContextManagerClient.CreateGcpUserAccessBinding(parent, gcpUserAccessBinding);

            // Poll until the returned long-running operation is complete
            Operation<GcpUserAccessBinding, GcpUserAccessBindingOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            GcpUserAccessBinding result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GcpUserAccessBinding, GcpUserAccessBindingOperationMetadata> retrievedResponse = accessContextManagerClient.PollOnceCreateGcpUserAccessBinding(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GcpUserAccessBinding retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateGcpUserAccessBindingAsync</summary>
        public async Task CreateGcpUserAccessBindingResourceNamesAsync()
        {
            // Snippet: CreateGcpUserAccessBindingAsync(OrganizationName, GcpUserAccessBinding, CallSettings)
            // Additional: CreateGcpUserAccessBindingAsync(OrganizationName, GcpUserAccessBinding, CancellationToken)
            // Create client
            AccessContextManagerClient accessContextManagerClient = await AccessContextManagerClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationName parent = OrganizationName.FromOrganization("[ORGANIZATION]");
            GcpUserAccessBinding gcpUserAccessBinding = new GcpUserAccessBinding();
            // Make the request
            Operation<GcpUserAccessBinding, GcpUserAccessBindingOperationMetadata> response = await accessContextManagerClient.CreateGcpUserAccessBindingAsync(parent, gcpUserAccessBinding);

            // Poll until the returned long-running operation is complete
            Operation<GcpUserAccessBinding, GcpUserAccessBindingOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            GcpUserAccessBinding result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GcpUserAccessBinding, GcpUserAccessBindingOperationMetadata> retrievedResponse = await accessContextManagerClient.PollOnceCreateGcpUserAccessBindingAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GcpUserAccessBinding retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateGcpUserAccessBinding</summary>
        public void UpdateGcpUserAccessBindingRequestObject()
        {
            // Snippet: UpdateGcpUserAccessBinding(UpdateGcpUserAccessBindingRequest, CallSettings)
            // Create client
            AccessContextManagerClient accessContextManagerClient = AccessContextManagerClient.Create();
            // Initialize request argument(s)
            UpdateGcpUserAccessBindingRequest request = new UpdateGcpUserAccessBindingRequest
            {
                GcpUserAccessBinding = new GcpUserAccessBinding(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<GcpUserAccessBinding, GcpUserAccessBindingOperationMetadata> response = accessContextManagerClient.UpdateGcpUserAccessBinding(request);

            // Poll until the returned long-running operation is complete
            Operation<GcpUserAccessBinding, GcpUserAccessBindingOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            GcpUserAccessBinding result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GcpUserAccessBinding, GcpUserAccessBindingOperationMetadata> retrievedResponse = accessContextManagerClient.PollOnceUpdateGcpUserAccessBinding(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GcpUserAccessBinding retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateGcpUserAccessBindingAsync</summary>
        public async Task UpdateGcpUserAccessBindingRequestObjectAsync()
        {
            // Snippet: UpdateGcpUserAccessBindingAsync(UpdateGcpUserAccessBindingRequest, CallSettings)
            // Additional: UpdateGcpUserAccessBindingAsync(UpdateGcpUserAccessBindingRequest, CancellationToken)
            // Create client
            AccessContextManagerClient accessContextManagerClient = await AccessContextManagerClient.CreateAsync();
            // Initialize request argument(s)
            UpdateGcpUserAccessBindingRequest request = new UpdateGcpUserAccessBindingRequest
            {
                GcpUserAccessBinding = new GcpUserAccessBinding(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<GcpUserAccessBinding, GcpUserAccessBindingOperationMetadata> response = await accessContextManagerClient.UpdateGcpUserAccessBindingAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<GcpUserAccessBinding, GcpUserAccessBindingOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            GcpUserAccessBinding result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GcpUserAccessBinding, GcpUserAccessBindingOperationMetadata> retrievedResponse = await accessContextManagerClient.PollOnceUpdateGcpUserAccessBindingAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GcpUserAccessBinding retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateGcpUserAccessBinding</summary>
        public void UpdateGcpUserAccessBinding()
        {
            // Snippet: UpdateGcpUserAccessBinding(GcpUserAccessBinding, FieldMask, CallSettings)
            // Create client
            AccessContextManagerClient accessContextManagerClient = AccessContextManagerClient.Create();
            // Initialize request argument(s)
            GcpUserAccessBinding gcpUserAccessBinding = new GcpUserAccessBinding();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<GcpUserAccessBinding, GcpUserAccessBindingOperationMetadata> response = accessContextManagerClient.UpdateGcpUserAccessBinding(gcpUserAccessBinding, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<GcpUserAccessBinding, GcpUserAccessBindingOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            GcpUserAccessBinding result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GcpUserAccessBinding, GcpUserAccessBindingOperationMetadata> retrievedResponse = accessContextManagerClient.PollOnceUpdateGcpUserAccessBinding(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GcpUserAccessBinding retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateGcpUserAccessBindingAsync</summary>
        public async Task UpdateGcpUserAccessBindingAsync()
        {
            // Snippet: UpdateGcpUserAccessBindingAsync(GcpUserAccessBinding, FieldMask, CallSettings)
            // Additional: UpdateGcpUserAccessBindingAsync(GcpUserAccessBinding, FieldMask, CancellationToken)
            // Create client
            AccessContextManagerClient accessContextManagerClient = await AccessContextManagerClient.CreateAsync();
            // Initialize request argument(s)
            GcpUserAccessBinding gcpUserAccessBinding = new GcpUserAccessBinding();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<GcpUserAccessBinding, GcpUserAccessBindingOperationMetadata> response = await accessContextManagerClient.UpdateGcpUserAccessBindingAsync(gcpUserAccessBinding, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<GcpUserAccessBinding, GcpUserAccessBindingOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            GcpUserAccessBinding result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GcpUserAccessBinding, GcpUserAccessBindingOperationMetadata> retrievedResponse = await accessContextManagerClient.PollOnceUpdateGcpUserAccessBindingAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GcpUserAccessBinding retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteGcpUserAccessBinding</summary>
        public void DeleteGcpUserAccessBindingRequestObject()
        {
            // Snippet: DeleteGcpUserAccessBinding(DeleteGcpUserAccessBindingRequest, CallSettings)
            // Create client
            AccessContextManagerClient accessContextManagerClient = AccessContextManagerClient.Create();
            // Initialize request argument(s)
            DeleteGcpUserAccessBindingRequest request = new DeleteGcpUserAccessBindingRequest
            {
                GcpUserAccessBindingName = GcpUserAccessBindingName.FromOrganizationGcpUserAccessBinding("[ORGANIZATION]", "[GCP_USER_ACCESS_BINDING]"),
            };
            // Make the request
            Operation<Empty, GcpUserAccessBindingOperationMetadata> response = accessContextManagerClient.DeleteGcpUserAccessBinding(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, GcpUserAccessBindingOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, GcpUserAccessBindingOperationMetadata> retrievedResponse = accessContextManagerClient.PollOnceDeleteGcpUserAccessBinding(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteGcpUserAccessBindingAsync</summary>
        public async Task DeleteGcpUserAccessBindingRequestObjectAsync()
        {
            // Snippet: DeleteGcpUserAccessBindingAsync(DeleteGcpUserAccessBindingRequest, CallSettings)
            // Additional: DeleteGcpUserAccessBindingAsync(DeleteGcpUserAccessBindingRequest, CancellationToken)
            // Create client
            AccessContextManagerClient accessContextManagerClient = await AccessContextManagerClient.CreateAsync();
            // Initialize request argument(s)
            DeleteGcpUserAccessBindingRequest request = new DeleteGcpUserAccessBindingRequest
            {
                GcpUserAccessBindingName = GcpUserAccessBindingName.FromOrganizationGcpUserAccessBinding("[ORGANIZATION]", "[GCP_USER_ACCESS_BINDING]"),
            };
            // Make the request
            Operation<Empty, GcpUserAccessBindingOperationMetadata> response = await accessContextManagerClient.DeleteGcpUserAccessBindingAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, GcpUserAccessBindingOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, GcpUserAccessBindingOperationMetadata> retrievedResponse = await accessContextManagerClient.PollOnceDeleteGcpUserAccessBindingAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteGcpUserAccessBinding</summary>
        public void DeleteGcpUserAccessBinding()
        {
            // Snippet: DeleteGcpUserAccessBinding(string, CallSettings)
            // Create client
            AccessContextManagerClient accessContextManagerClient = AccessContextManagerClient.Create();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/gcpUserAccessBindings/[GCP_USER_ACCESS_BINDING]";
            // Make the request
            Operation<Empty, GcpUserAccessBindingOperationMetadata> response = accessContextManagerClient.DeleteGcpUserAccessBinding(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, GcpUserAccessBindingOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, GcpUserAccessBindingOperationMetadata> retrievedResponse = accessContextManagerClient.PollOnceDeleteGcpUserAccessBinding(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteGcpUserAccessBindingAsync</summary>
        public async Task DeleteGcpUserAccessBindingAsync()
        {
            // Snippet: DeleteGcpUserAccessBindingAsync(string, CallSettings)
            // Additional: DeleteGcpUserAccessBindingAsync(string, CancellationToken)
            // Create client
            AccessContextManagerClient accessContextManagerClient = await AccessContextManagerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/gcpUserAccessBindings/[GCP_USER_ACCESS_BINDING]";
            // Make the request
            Operation<Empty, GcpUserAccessBindingOperationMetadata> response = await accessContextManagerClient.DeleteGcpUserAccessBindingAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, GcpUserAccessBindingOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, GcpUserAccessBindingOperationMetadata> retrievedResponse = await accessContextManagerClient.PollOnceDeleteGcpUserAccessBindingAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteGcpUserAccessBinding</summary>
        public void DeleteGcpUserAccessBindingResourceNames()
        {
            // Snippet: DeleteGcpUserAccessBinding(GcpUserAccessBindingName, CallSettings)
            // Create client
            AccessContextManagerClient accessContextManagerClient = AccessContextManagerClient.Create();
            // Initialize request argument(s)
            GcpUserAccessBindingName name = GcpUserAccessBindingName.FromOrganizationGcpUserAccessBinding("[ORGANIZATION]", "[GCP_USER_ACCESS_BINDING]");
            // Make the request
            Operation<Empty, GcpUserAccessBindingOperationMetadata> response = accessContextManagerClient.DeleteGcpUserAccessBinding(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, GcpUserAccessBindingOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, GcpUserAccessBindingOperationMetadata> retrievedResponse = accessContextManagerClient.PollOnceDeleteGcpUserAccessBinding(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteGcpUserAccessBindingAsync</summary>
        public async Task DeleteGcpUserAccessBindingResourceNamesAsync()
        {
            // Snippet: DeleteGcpUserAccessBindingAsync(GcpUserAccessBindingName, CallSettings)
            // Additional: DeleteGcpUserAccessBindingAsync(GcpUserAccessBindingName, CancellationToken)
            // Create client
            AccessContextManagerClient accessContextManagerClient = await AccessContextManagerClient.CreateAsync();
            // Initialize request argument(s)
            GcpUserAccessBindingName name = GcpUserAccessBindingName.FromOrganizationGcpUserAccessBinding("[ORGANIZATION]", "[GCP_USER_ACCESS_BINDING]");
            // Make the request
            Operation<Empty, GcpUserAccessBindingOperationMetadata> response = await accessContextManagerClient.DeleteGcpUserAccessBindingAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, GcpUserAccessBindingOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, GcpUserAccessBindingOperationMetadata> retrievedResponse = await accessContextManagerClient.PollOnceDeleteGcpUserAccessBindingAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicyRequestObject()
        {
            // Snippet: SetIamPolicy(SetIamPolicyRequest, CallSettings)
            // Create client
            AccessContextManagerClient accessContextManagerClient = AccessContextManagerClient.Create();
            // Initialize request argument(s)
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Policy = new Policy(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Policy response = accessContextManagerClient.SetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyRequestObjectAsync()
        {
            // Snippet: SetIamPolicyAsync(SetIamPolicyRequest, CallSettings)
            // Additional: SetIamPolicyAsync(SetIamPolicyRequest, CancellationToken)
            // Create client
            AccessContextManagerClient accessContextManagerClient = await AccessContextManagerClient.CreateAsync();
            // Initialize request argument(s)
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Policy = new Policy(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Policy response = await accessContextManagerClient.SetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicyRequestObject()
        {
            // Snippet: GetIamPolicy(GetIamPolicyRequest, CallSettings)
            // Create client
            AccessContextManagerClient accessContextManagerClient = AccessContextManagerClient.Create();
            // Initialize request argument(s)
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Options = new GetPolicyOptions(),
            };
            // Make the request
            Policy response = accessContextManagerClient.GetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyRequestObjectAsync()
        {
            // Snippet: GetIamPolicyAsync(GetIamPolicyRequest, CallSettings)
            // Additional: GetIamPolicyAsync(GetIamPolicyRequest, CancellationToken)
            // Create client
            AccessContextManagerClient accessContextManagerClient = await AccessContextManagerClient.CreateAsync();
            // Initialize request argument(s)
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Options = new GetPolicyOptions(),
            };
            // Make the request
            Policy response = await accessContextManagerClient.GetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissionsRequestObject()
        {
            // Snippet: TestIamPermissions(TestIamPermissionsRequest, CallSettings)
            // Create client
            AccessContextManagerClient accessContextManagerClient = AccessContextManagerClient.Create();
            // Initialize request argument(s)
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Permissions = { "", },
            };
            // Make the request
            TestIamPermissionsResponse response = accessContextManagerClient.TestIamPermissions(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsRequestObjectAsync()
        {
            // Snippet: TestIamPermissionsAsync(TestIamPermissionsRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(TestIamPermissionsRequest, CancellationToken)
            // Create client
            AccessContextManagerClient accessContextManagerClient = await AccessContextManagerClient.CreateAsync();
            // Initialize request argument(s)
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Permissions = { "", },
            };
            // Make the request
            TestIamPermissionsResponse response = await accessContextManagerClient.TestIamPermissionsAsync(request);
            // End snippet
        }
    }
}
