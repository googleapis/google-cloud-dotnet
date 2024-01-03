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
    using Google.Cloud.Iam.V2;
    using Google.LongRunning;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedPoliciesClientSnippets
    {
        /// <summary>Snippet for ListPolicies</summary>
        public void ListPoliciesRequestObject()
        {
            // Snippet: ListPolicies(ListPoliciesRequest, CallSettings)
            // Create client
            PoliciesClient policiesClient = PoliciesClient.Create();
            // Initialize request argument(s)
            ListPoliciesRequest request = new ListPoliciesRequest { Parent = "", };
            // Make the request
            PagedEnumerable<ListPoliciesResponse, Policy> response = policiesClient.ListPolicies(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Policy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPoliciesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Policy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Policy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Policy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPoliciesAsync</summary>
        public async Task ListPoliciesRequestObjectAsync()
        {
            // Snippet: ListPoliciesAsync(ListPoliciesRequest, CallSettings)
            // Create client
            PoliciesClient policiesClient = await PoliciesClient.CreateAsync();
            // Initialize request argument(s)
            ListPoliciesRequest request = new ListPoliciesRequest { Parent = "", };
            // Make the request
            PagedAsyncEnumerable<ListPoliciesResponse, Policy> response = policiesClient.ListPoliciesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Policy item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPoliciesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Policy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Policy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Policy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPolicies</summary>
        public void ListPolicies()
        {
            // Snippet: ListPolicies(string, string, int?, CallSettings)
            // Create client
            PoliciesClient policiesClient = PoliciesClient.Create();
            // Initialize request argument(s)
            string parent = "";
            // Make the request
            PagedEnumerable<ListPoliciesResponse, Policy> response = policiesClient.ListPolicies(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Policy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPoliciesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Policy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Policy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Policy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPoliciesAsync</summary>
        public async Task ListPoliciesAsync()
        {
            // Snippet: ListPoliciesAsync(string, string, int?, CallSettings)
            // Create client
            PoliciesClient policiesClient = await PoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "";
            // Make the request
            PagedAsyncEnumerable<ListPoliciesResponse, Policy> response = policiesClient.ListPoliciesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Policy item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPoliciesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Policy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Policy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Policy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetPolicy</summary>
        public void GetPolicyRequestObject()
        {
            // Snippet: GetPolicy(GetPolicyRequest, CallSettings)
            // Create client
            PoliciesClient policiesClient = PoliciesClient.Create();
            // Initialize request argument(s)
            GetPolicyRequest request = new GetPolicyRequest { Name = "", };
            // Make the request
            Policy response = policiesClient.GetPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for GetPolicyAsync</summary>
        public async Task GetPolicyRequestObjectAsync()
        {
            // Snippet: GetPolicyAsync(GetPolicyRequest, CallSettings)
            // Additional: GetPolicyAsync(GetPolicyRequest, CancellationToken)
            // Create client
            PoliciesClient policiesClient = await PoliciesClient.CreateAsync();
            // Initialize request argument(s)
            GetPolicyRequest request = new GetPolicyRequest { Name = "", };
            // Make the request
            Policy response = await policiesClient.GetPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetPolicy</summary>
        public void GetPolicy()
        {
            // Snippet: GetPolicy(string, CallSettings)
            // Create client
            PoliciesClient policiesClient = PoliciesClient.Create();
            // Initialize request argument(s)
            string name = "";
            // Make the request
            Policy response = policiesClient.GetPolicy(name);
            // End snippet
        }

        /// <summary>Snippet for GetPolicyAsync</summary>
        public async Task GetPolicyAsync()
        {
            // Snippet: GetPolicyAsync(string, CallSettings)
            // Additional: GetPolicyAsync(string, CancellationToken)
            // Create client
            PoliciesClient policiesClient = await PoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string name = "";
            // Make the request
            Policy response = await policiesClient.GetPolicyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreatePolicy</summary>
        public void CreatePolicyRequestObject()
        {
            // Snippet: CreatePolicy(CreatePolicyRequest, CallSettings)
            // Create client
            PoliciesClient policiesClient = PoliciesClient.Create();
            // Initialize request argument(s)
            CreatePolicyRequest request = new CreatePolicyRequest
            {
                Parent = "",
                Policy = new Policy(),
                PolicyId = "",
            };
            // Make the request
            Operation<Policy, PolicyOperationMetadata> response = policiesClient.CreatePolicy(request);

            // Poll until the returned long-running operation is complete
            Operation<Policy, PolicyOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Policy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Policy, PolicyOperationMetadata> retrievedResponse = policiesClient.PollOnceCreatePolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Policy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreatePolicyAsync</summary>
        public async Task CreatePolicyRequestObjectAsync()
        {
            // Snippet: CreatePolicyAsync(CreatePolicyRequest, CallSettings)
            // Additional: CreatePolicyAsync(CreatePolicyRequest, CancellationToken)
            // Create client
            PoliciesClient policiesClient = await PoliciesClient.CreateAsync();
            // Initialize request argument(s)
            CreatePolicyRequest request = new CreatePolicyRequest
            {
                Parent = "",
                Policy = new Policy(),
                PolicyId = "",
            };
            // Make the request
            Operation<Policy, PolicyOperationMetadata> response = await policiesClient.CreatePolicyAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Policy, PolicyOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Policy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Policy, PolicyOperationMetadata> retrievedResponse = await policiesClient.PollOnceCreatePolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Policy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreatePolicy</summary>
        public void CreatePolicy()
        {
            // Snippet: CreatePolicy(string, Policy, string, CallSettings)
            // Create client
            PoliciesClient policiesClient = PoliciesClient.Create();
            // Initialize request argument(s)
            string parent = "";
            Policy policy = new Policy();
            string policyId = "";
            // Make the request
            Operation<Policy, PolicyOperationMetadata> response = policiesClient.CreatePolicy(parent, policy, policyId);

            // Poll until the returned long-running operation is complete
            Operation<Policy, PolicyOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Policy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Policy, PolicyOperationMetadata> retrievedResponse = policiesClient.PollOnceCreatePolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Policy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreatePolicyAsync</summary>
        public async Task CreatePolicyAsync()
        {
            // Snippet: CreatePolicyAsync(string, Policy, string, CallSettings)
            // Additional: CreatePolicyAsync(string, Policy, string, CancellationToken)
            // Create client
            PoliciesClient policiesClient = await PoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "";
            Policy policy = new Policy();
            string policyId = "";
            // Make the request
            Operation<Policy, PolicyOperationMetadata> response = await policiesClient.CreatePolicyAsync(parent, policy, policyId);

            // Poll until the returned long-running operation is complete
            Operation<Policy, PolicyOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Policy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Policy, PolicyOperationMetadata> retrievedResponse = await policiesClient.PollOnceCreatePolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Policy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdatePolicy</summary>
        public void UpdatePolicyRequestObject()
        {
            // Snippet: UpdatePolicy(UpdatePolicyRequest, CallSettings)
            // Create client
            PoliciesClient policiesClient = PoliciesClient.Create();
            // Initialize request argument(s)
            UpdatePolicyRequest request = new UpdatePolicyRequest
            {
                Policy = new Policy(),
            };
            // Make the request
            Operation<Policy, PolicyOperationMetadata> response = policiesClient.UpdatePolicy(request);

            // Poll until the returned long-running operation is complete
            Operation<Policy, PolicyOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Policy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Policy, PolicyOperationMetadata> retrievedResponse = policiesClient.PollOnceUpdatePolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Policy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdatePolicyAsync</summary>
        public async Task UpdatePolicyRequestObjectAsync()
        {
            // Snippet: UpdatePolicyAsync(UpdatePolicyRequest, CallSettings)
            // Additional: UpdatePolicyAsync(UpdatePolicyRequest, CancellationToken)
            // Create client
            PoliciesClient policiesClient = await PoliciesClient.CreateAsync();
            // Initialize request argument(s)
            UpdatePolicyRequest request = new UpdatePolicyRequest
            {
                Policy = new Policy(),
            };
            // Make the request
            Operation<Policy, PolicyOperationMetadata> response = await policiesClient.UpdatePolicyAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Policy, PolicyOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Policy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Policy, PolicyOperationMetadata> retrievedResponse = await policiesClient.PollOnceUpdatePolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Policy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeletePolicy</summary>
        public void DeletePolicyRequestObject()
        {
            // Snippet: DeletePolicy(DeletePolicyRequest, CallSettings)
            // Create client
            PoliciesClient policiesClient = PoliciesClient.Create();
            // Initialize request argument(s)
            DeletePolicyRequest request = new DeletePolicyRequest { Name = "", Etag = "", };
            // Make the request
            Operation<Policy, PolicyOperationMetadata> response = policiesClient.DeletePolicy(request);

            // Poll until the returned long-running operation is complete
            Operation<Policy, PolicyOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Policy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Policy, PolicyOperationMetadata> retrievedResponse = policiesClient.PollOnceDeletePolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Policy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeletePolicyAsync</summary>
        public async Task DeletePolicyRequestObjectAsync()
        {
            // Snippet: DeletePolicyAsync(DeletePolicyRequest, CallSettings)
            // Additional: DeletePolicyAsync(DeletePolicyRequest, CancellationToken)
            // Create client
            PoliciesClient policiesClient = await PoliciesClient.CreateAsync();
            // Initialize request argument(s)
            DeletePolicyRequest request = new DeletePolicyRequest { Name = "", Etag = "", };
            // Make the request
            Operation<Policy, PolicyOperationMetadata> response = await policiesClient.DeletePolicyAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Policy, PolicyOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Policy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Policy, PolicyOperationMetadata> retrievedResponse = await policiesClient.PollOnceDeletePolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Policy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeletePolicy</summary>
        public void DeletePolicy()
        {
            // Snippet: DeletePolicy(string, CallSettings)
            // Create client
            PoliciesClient policiesClient = PoliciesClient.Create();
            // Initialize request argument(s)
            string name = "";
            // Make the request
            Operation<Policy, PolicyOperationMetadata> response = policiesClient.DeletePolicy(name);

            // Poll until the returned long-running operation is complete
            Operation<Policy, PolicyOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Policy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Policy, PolicyOperationMetadata> retrievedResponse = policiesClient.PollOnceDeletePolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Policy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeletePolicyAsync</summary>
        public async Task DeletePolicyAsync()
        {
            // Snippet: DeletePolicyAsync(string, CallSettings)
            // Additional: DeletePolicyAsync(string, CancellationToken)
            // Create client
            PoliciesClient policiesClient = await PoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string name = "";
            // Make the request
            Operation<Policy, PolicyOperationMetadata> response = await policiesClient.DeletePolicyAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Policy, PolicyOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Policy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Policy, PolicyOperationMetadata> retrievedResponse = await policiesClient.PollOnceDeletePolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Policy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
