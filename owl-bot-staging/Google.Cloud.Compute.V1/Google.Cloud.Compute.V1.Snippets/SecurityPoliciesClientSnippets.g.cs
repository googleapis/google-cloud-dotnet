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
    public sealed class AllGeneratedSecurityPoliciesClientSnippets
    {
        /// <summary>Snippet for AddRule</summary>
        public void AddRuleRequestObject()
        {
            // Snippet: AddRule(AddRuleSecurityPolicyRequest, CallSettings)
            // Create client
            SecurityPoliciesClient securityPoliciesClient = SecurityPoliciesClient.Create();
            // Initialize request argument(s)
            AddRuleSecurityPolicyRequest request = new AddRuleSecurityPolicyRequest
            {
                SecurityPolicy = "",
                Project = "",
                ValidateOnly = false,
                SecurityPolicyRuleResource = new SecurityPolicyRule(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = securityPoliciesClient.AddRule(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = securityPoliciesClient.PollOnceAddRule(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AddRuleAsync</summary>
        public async Task AddRuleRequestObjectAsync()
        {
            // Snippet: AddRuleAsync(AddRuleSecurityPolicyRequest, CallSettings)
            // Additional: AddRuleAsync(AddRuleSecurityPolicyRequest, CancellationToken)
            // Create client
            SecurityPoliciesClient securityPoliciesClient = await SecurityPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            AddRuleSecurityPolicyRequest request = new AddRuleSecurityPolicyRequest
            {
                SecurityPolicy = "",
                Project = "",
                ValidateOnly = false,
                SecurityPolicyRuleResource = new SecurityPolicyRule(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await securityPoliciesClient.AddRuleAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await securityPoliciesClient.PollOnceAddRuleAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AddRule</summary>
        public void AddRule()
        {
            // Snippet: AddRule(string, string, SecurityPolicyRule, CallSettings)
            // Create client
            SecurityPoliciesClient securityPoliciesClient = SecurityPoliciesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string securityPolicy = "";
            SecurityPolicyRule securityPolicyRuleResource = new SecurityPolicyRule();
            // Make the request
            lro::Operation<Operation, Operation> response = securityPoliciesClient.AddRule(project, securityPolicy, securityPolicyRuleResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = securityPoliciesClient.PollOnceAddRule(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AddRuleAsync</summary>
        public async Task AddRuleAsync()
        {
            // Snippet: AddRuleAsync(string, string, SecurityPolicyRule, CallSettings)
            // Additional: AddRuleAsync(string, string, SecurityPolicyRule, CancellationToken)
            // Create client
            SecurityPoliciesClient securityPoliciesClient = await SecurityPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string securityPolicy = "";
            SecurityPolicyRule securityPolicyRuleResource = new SecurityPolicyRule();
            // Make the request
            lro::Operation<Operation, Operation> response = await securityPoliciesClient.AddRuleAsync(project, securityPolicy, securityPolicyRuleResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await securityPoliciesClient.PollOnceAddRuleAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AggregatedList</summary>
        public void AggregatedListRequestObject()
        {
            // Snippet: AggregatedList(AggregatedListSecurityPoliciesRequest, CallSettings)
            // Create client
            SecurityPoliciesClient securityPoliciesClient = SecurityPoliciesClient.Create();
            // Initialize request argument(s)
            AggregatedListSecurityPoliciesRequest request = new AggregatedListSecurityPoliciesRequest
            {
                OrderBy = "",
                Project = "",
                ServiceProjectNumber = 0L,
                Filter = "",
                IncludeAllScopes = false,
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<SecurityPoliciesAggregatedList, KeyValuePair<string, SecurityPoliciesScopedList>> response = securityPoliciesClient.AggregatedList(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (KeyValuePair<string, SecurityPoliciesScopedList> item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SecurityPoliciesAggregatedList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, SecurityPoliciesScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, SecurityPoliciesScopedList>> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, SecurityPoliciesScopedList> item in singlePage)
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
            // Snippet: AggregatedListAsync(AggregatedListSecurityPoliciesRequest, CallSettings)
            // Create client
            SecurityPoliciesClient securityPoliciesClient = await SecurityPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            AggregatedListSecurityPoliciesRequest request = new AggregatedListSecurityPoliciesRequest
            {
                OrderBy = "",
                Project = "",
                ServiceProjectNumber = 0L,
                Filter = "",
                IncludeAllScopes = false,
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<SecurityPoliciesAggregatedList, KeyValuePair<string, SecurityPoliciesScopedList>> response = securityPoliciesClient.AggregatedListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((KeyValuePair<string, SecurityPoliciesScopedList> item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SecurityPoliciesAggregatedList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, SecurityPoliciesScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, SecurityPoliciesScopedList>> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, SecurityPoliciesScopedList> item in singlePage)
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
            SecurityPoliciesClient securityPoliciesClient = SecurityPoliciesClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedEnumerable<SecurityPoliciesAggregatedList, KeyValuePair<string, SecurityPoliciesScopedList>> response = securityPoliciesClient.AggregatedList(project);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (KeyValuePair<string, SecurityPoliciesScopedList> item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SecurityPoliciesAggregatedList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, SecurityPoliciesScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, SecurityPoliciesScopedList>> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, SecurityPoliciesScopedList> item in singlePage)
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
            SecurityPoliciesClient securityPoliciesClient = await SecurityPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedAsyncEnumerable<SecurityPoliciesAggregatedList, KeyValuePair<string, SecurityPoliciesScopedList>> response = securityPoliciesClient.AggregatedListAsync(project);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((KeyValuePair<string, SecurityPoliciesScopedList> item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SecurityPoliciesAggregatedList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, SecurityPoliciesScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, SecurityPoliciesScopedList>> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, SecurityPoliciesScopedList> item in singlePage)
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
            // Snippet: Delete(DeleteSecurityPolicyRequest, CallSettings)
            // Create client
            SecurityPoliciesClient securityPoliciesClient = SecurityPoliciesClient.Create();
            // Initialize request argument(s)
            DeleteSecurityPolicyRequest request = new DeleteSecurityPolicyRequest
            {
                RequestId = "",
                SecurityPolicy = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = securityPoliciesClient.Delete(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = securityPoliciesClient.PollOnceDelete(operationName);
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
            // Snippet: DeleteAsync(DeleteSecurityPolicyRequest, CallSettings)
            // Additional: DeleteAsync(DeleteSecurityPolicyRequest, CancellationToken)
            // Create client
            SecurityPoliciesClient securityPoliciesClient = await SecurityPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            DeleteSecurityPolicyRequest request = new DeleteSecurityPolicyRequest
            {
                RequestId = "",
                SecurityPolicy = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await securityPoliciesClient.DeleteAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await securityPoliciesClient.PollOnceDeleteAsync(operationName);
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
            // Snippet: Delete(string, string, CallSettings)
            // Create client
            SecurityPoliciesClient securityPoliciesClient = SecurityPoliciesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string securityPolicy = "";
            // Make the request
            lro::Operation<Operation, Operation> response = securityPoliciesClient.Delete(project, securityPolicy);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = securityPoliciesClient.PollOnceDelete(operationName);
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
            // Snippet: DeleteAsync(string, string, CallSettings)
            // Additional: DeleteAsync(string, string, CancellationToken)
            // Create client
            SecurityPoliciesClient securityPoliciesClient = await SecurityPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string securityPolicy = "";
            // Make the request
            lro::Operation<Operation, Operation> response = await securityPoliciesClient.DeleteAsync(project, securityPolicy);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await securityPoliciesClient.PollOnceDeleteAsync(operationName);
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
            // Snippet: Get(GetSecurityPolicyRequest, CallSettings)
            // Create client
            SecurityPoliciesClient securityPoliciesClient = SecurityPoliciesClient.Create();
            // Initialize request argument(s)
            GetSecurityPolicyRequest request = new GetSecurityPolicyRequest
            {
                SecurityPolicy = "",
                Project = "",
            };
            // Make the request
            SecurityPolicy response = securityPoliciesClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetSecurityPolicyRequest, CallSettings)
            // Additional: GetAsync(GetSecurityPolicyRequest, CancellationToken)
            // Create client
            SecurityPoliciesClient securityPoliciesClient = await SecurityPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            GetSecurityPolicyRequest request = new GetSecurityPolicyRequest
            {
                SecurityPolicy = "",
                Project = "",
            };
            // Make the request
            SecurityPolicy response = await securityPoliciesClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, CallSettings)
            // Create client
            SecurityPoliciesClient securityPoliciesClient = SecurityPoliciesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string securityPolicy = "";
            // Make the request
            SecurityPolicy response = securityPoliciesClient.Get(project, securityPolicy);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, CallSettings)
            // Additional: GetAsync(string, string, CancellationToken)
            // Create client
            SecurityPoliciesClient securityPoliciesClient = await SecurityPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string securityPolicy = "";
            // Make the request
            SecurityPolicy response = await securityPoliciesClient.GetAsync(project, securityPolicy);
            // End snippet
        }

        /// <summary>Snippet for GetRule</summary>
        public void GetRuleRequestObject()
        {
            // Snippet: GetRule(GetRuleSecurityPolicyRequest, CallSettings)
            // Create client
            SecurityPoliciesClient securityPoliciesClient = SecurityPoliciesClient.Create();
            // Initialize request argument(s)
            GetRuleSecurityPolicyRequest request = new GetRuleSecurityPolicyRequest
            {
                SecurityPolicy = "",
                Project = "",
                Priority = 0,
            };
            // Make the request
            SecurityPolicyRule response = securityPoliciesClient.GetRule(request);
            // End snippet
        }

        /// <summary>Snippet for GetRuleAsync</summary>
        public async Task GetRuleRequestObjectAsync()
        {
            // Snippet: GetRuleAsync(GetRuleSecurityPolicyRequest, CallSettings)
            // Additional: GetRuleAsync(GetRuleSecurityPolicyRequest, CancellationToken)
            // Create client
            SecurityPoliciesClient securityPoliciesClient = await SecurityPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            GetRuleSecurityPolicyRequest request = new GetRuleSecurityPolicyRequest
            {
                SecurityPolicy = "",
                Project = "",
                Priority = 0,
            };
            // Make the request
            SecurityPolicyRule response = await securityPoliciesClient.GetRuleAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetRule</summary>
        public void GetRule()
        {
            // Snippet: GetRule(string, string, CallSettings)
            // Create client
            SecurityPoliciesClient securityPoliciesClient = SecurityPoliciesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string securityPolicy = "";
            // Make the request
            SecurityPolicyRule response = securityPoliciesClient.GetRule(project, securityPolicy);
            // End snippet
        }

        /// <summary>Snippet for GetRuleAsync</summary>
        public async Task GetRuleAsync()
        {
            // Snippet: GetRuleAsync(string, string, CallSettings)
            // Additional: GetRuleAsync(string, string, CancellationToken)
            // Create client
            SecurityPoliciesClient securityPoliciesClient = await SecurityPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string securityPolicy = "";
            // Make the request
            SecurityPolicyRule response = await securityPoliciesClient.GetRuleAsync(project, securityPolicy);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void InsertRequestObject()
        {
            // Snippet: Insert(InsertSecurityPolicyRequest, CallSettings)
            // Create client
            SecurityPoliciesClient securityPoliciesClient = SecurityPoliciesClient.Create();
            // Initialize request argument(s)
            InsertSecurityPolicyRequest request = new InsertSecurityPolicyRequest
            {
                RequestId = "",
                SecurityPolicyResource = new SecurityPolicy(),
                Project = "",
                ValidateOnly = false,
            };
            // Make the request
            lro::Operation<Operation, Operation> response = securityPoliciesClient.Insert(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = securityPoliciesClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(InsertSecurityPolicyRequest, CallSettings)
            // Additional: InsertAsync(InsertSecurityPolicyRequest, CancellationToken)
            // Create client
            SecurityPoliciesClient securityPoliciesClient = await SecurityPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            InsertSecurityPolicyRequest request = new InsertSecurityPolicyRequest
            {
                RequestId = "",
                SecurityPolicyResource = new SecurityPolicy(),
                Project = "",
                ValidateOnly = false,
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await securityPoliciesClient.InsertAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await securityPoliciesClient.PollOnceInsertAsync(operationName);
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
            // Snippet: Insert(string, SecurityPolicy, CallSettings)
            // Create client
            SecurityPoliciesClient securityPoliciesClient = SecurityPoliciesClient.Create();
            // Initialize request argument(s)
            string project = "";
            SecurityPolicy securityPolicyResource = new SecurityPolicy();
            // Make the request
            lro::Operation<Operation, Operation> response = securityPoliciesClient.Insert(project, securityPolicyResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = securityPoliciesClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(string, SecurityPolicy, CallSettings)
            // Additional: InsertAsync(string, SecurityPolicy, CancellationToken)
            // Create client
            SecurityPoliciesClient securityPoliciesClient = await SecurityPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            SecurityPolicy securityPolicyResource = new SecurityPolicy();
            // Make the request
            lro::Operation<Operation, Operation> response = await securityPoliciesClient.InsertAsync(project, securityPolicyResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await securityPoliciesClient.PollOnceInsertAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void ListRequestObject()
        {
            // Snippet: List(ListSecurityPoliciesRequest, CallSettings)
            // Create client
            SecurityPoliciesClient securityPoliciesClient = SecurityPoliciesClient.Create();
            // Initialize request argument(s)
            ListSecurityPoliciesRequest request = new ListSecurityPoliciesRequest
            {
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<SecurityPolicyList, SecurityPolicy> response = securityPoliciesClient.List(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SecurityPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SecurityPolicyList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SecurityPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SecurityPolicy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SecurityPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListRequestObjectAsync()
        {
            // Snippet: ListAsync(ListSecurityPoliciesRequest, CallSettings)
            // Create client
            SecurityPoliciesClient securityPoliciesClient = await SecurityPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            ListSecurityPoliciesRequest request = new ListSecurityPoliciesRequest
            {
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<SecurityPolicyList, SecurityPolicy> response = securityPoliciesClient.ListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((SecurityPolicy item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SecurityPolicyList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SecurityPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SecurityPolicy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SecurityPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void List()
        {
            // Snippet: List(string, string, int?, CallSettings)
            // Create client
            SecurityPoliciesClient securityPoliciesClient = SecurityPoliciesClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedEnumerable<SecurityPolicyList, SecurityPolicy> response = securityPoliciesClient.List(project);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SecurityPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SecurityPolicyList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SecurityPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SecurityPolicy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SecurityPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListAsync()
        {
            // Snippet: ListAsync(string, string, int?, CallSettings)
            // Create client
            SecurityPoliciesClient securityPoliciesClient = await SecurityPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedAsyncEnumerable<SecurityPolicyList, SecurityPolicy> response = securityPoliciesClient.ListAsync(project);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((SecurityPolicy item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SecurityPolicyList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SecurityPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SecurityPolicy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SecurityPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPreconfiguredExpressionSets</summary>
        public void ListPreconfiguredExpressionSetsRequestObject()
        {
            // Snippet: ListPreconfiguredExpressionSets(ListPreconfiguredExpressionSetsSecurityPoliciesRequest, CallSettings)
            // Create client
            SecurityPoliciesClient securityPoliciesClient = SecurityPoliciesClient.Create();
            // Initialize request argument(s)
            ListPreconfiguredExpressionSetsSecurityPoliciesRequest request = new ListPreconfiguredExpressionSetsSecurityPoliciesRequest
            {
                PageToken = "",
                MaxResults = 0U,
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            SecurityPoliciesListPreconfiguredExpressionSetsResponse response = securityPoliciesClient.ListPreconfiguredExpressionSets(request);
            // End snippet
        }

        /// <summary>Snippet for ListPreconfiguredExpressionSetsAsync</summary>
        public async Task ListPreconfiguredExpressionSetsRequestObjectAsync()
        {
            // Snippet: ListPreconfiguredExpressionSetsAsync(ListPreconfiguredExpressionSetsSecurityPoliciesRequest, CallSettings)
            // Additional: ListPreconfiguredExpressionSetsAsync(ListPreconfiguredExpressionSetsSecurityPoliciesRequest, CancellationToken)
            // Create client
            SecurityPoliciesClient securityPoliciesClient = await SecurityPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            ListPreconfiguredExpressionSetsSecurityPoliciesRequest request = new ListPreconfiguredExpressionSetsSecurityPoliciesRequest
            {
                PageToken = "",
                MaxResults = 0U,
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            SecurityPoliciesListPreconfiguredExpressionSetsResponse response = await securityPoliciesClient.ListPreconfiguredExpressionSetsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ListPreconfiguredExpressionSets</summary>
        public void ListPreconfiguredExpressionSets()
        {
            // Snippet: ListPreconfiguredExpressionSets(string, CallSettings)
            // Create client
            SecurityPoliciesClient securityPoliciesClient = SecurityPoliciesClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            SecurityPoliciesListPreconfiguredExpressionSetsResponse response = securityPoliciesClient.ListPreconfiguredExpressionSets(project);
            // End snippet
        }

        /// <summary>Snippet for ListPreconfiguredExpressionSetsAsync</summary>
        public async Task ListPreconfiguredExpressionSetsAsync()
        {
            // Snippet: ListPreconfiguredExpressionSetsAsync(string, CallSettings)
            // Additional: ListPreconfiguredExpressionSetsAsync(string, CancellationToken)
            // Create client
            SecurityPoliciesClient securityPoliciesClient = await SecurityPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            SecurityPoliciesListPreconfiguredExpressionSetsResponse response = await securityPoliciesClient.ListPreconfiguredExpressionSetsAsync(project);
            // End snippet
        }

        /// <summary>Snippet for Patch</summary>
        public void PatchRequestObject()
        {
            // Snippet: Patch(PatchSecurityPolicyRequest, CallSettings)
            // Create client
            SecurityPoliciesClient securityPoliciesClient = SecurityPoliciesClient.Create();
            // Initialize request argument(s)
            PatchSecurityPolicyRequest request = new PatchSecurityPolicyRequest
            {
                RequestId = "",
                SecurityPolicy = "",
                SecurityPolicyResource = new SecurityPolicy(),
                Project = "",
                UpdateMask = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = securityPoliciesClient.Patch(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = securityPoliciesClient.PollOncePatch(operationName);
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
            // Snippet: PatchAsync(PatchSecurityPolicyRequest, CallSettings)
            // Additional: PatchAsync(PatchSecurityPolicyRequest, CancellationToken)
            // Create client
            SecurityPoliciesClient securityPoliciesClient = await SecurityPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            PatchSecurityPolicyRequest request = new PatchSecurityPolicyRequest
            {
                RequestId = "",
                SecurityPolicy = "",
                SecurityPolicyResource = new SecurityPolicy(),
                Project = "",
                UpdateMask = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await securityPoliciesClient.PatchAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await securityPoliciesClient.PollOncePatchAsync(operationName);
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
            // Snippet: Patch(string, string, SecurityPolicy, CallSettings)
            // Create client
            SecurityPoliciesClient securityPoliciesClient = SecurityPoliciesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string securityPolicy = "";
            SecurityPolicy securityPolicyResource = new SecurityPolicy();
            // Make the request
            lro::Operation<Operation, Operation> response = securityPoliciesClient.Patch(project, securityPolicy, securityPolicyResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = securityPoliciesClient.PollOncePatch(operationName);
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
            // Snippet: PatchAsync(string, string, SecurityPolicy, CallSettings)
            // Additional: PatchAsync(string, string, SecurityPolicy, CancellationToken)
            // Create client
            SecurityPoliciesClient securityPoliciesClient = await SecurityPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string securityPolicy = "";
            SecurityPolicy securityPolicyResource = new SecurityPolicy();
            // Make the request
            lro::Operation<Operation, Operation> response = await securityPoliciesClient.PatchAsync(project, securityPolicy, securityPolicyResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await securityPoliciesClient.PollOncePatchAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PatchRule</summary>
        public void PatchRuleRequestObject()
        {
            // Snippet: PatchRule(PatchRuleSecurityPolicyRequest, CallSettings)
            // Create client
            SecurityPoliciesClient securityPoliciesClient = SecurityPoliciesClient.Create();
            // Initialize request argument(s)
            PatchRuleSecurityPolicyRequest request = new PatchRuleSecurityPolicyRequest
            {
                SecurityPolicy = "",
                Project = "",
                ValidateOnly = false,
                SecurityPolicyRuleResource = new SecurityPolicyRule(),
                Priority = 0,
                UpdateMask = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = securityPoliciesClient.PatchRule(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = securityPoliciesClient.PollOncePatchRule(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PatchRuleAsync</summary>
        public async Task PatchRuleRequestObjectAsync()
        {
            // Snippet: PatchRuleAsync(PatchRuleSecurityPolicyRequest, CallSettings)
            // Additional: PatchRuleAsync(PatchRuleSecurityPolicyRequest, CancellationToken)
            // Create client
            SecurityPoliciesClient securityPoliciesClient = await SecurityPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            PatchRuleSecurityPolicyRequest request = new PatchRuleSecurityPolicyRequest
            {
                SecurityPolicy = "",
                Project = "",
                ValidateOnly = false,
                SecurityPolicyRuleResource = new SecurityPolicyRule(),
                Priority = 0,
                UpdateMask = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await securityPoliciesClient.PatchRuleAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await securityPoliciesClient.PollOncePatchRuleAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PatchRule</summary>
        public void PatchRule()
        {
            // Snippet: PatchRule(string, string, SecurityPolicyRule, CallSettings)
            // Create client
            SecurityPoliciesClient securityPoliciesClient = SecurityPoliciesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string securityPolicy = "";
            SecurityPolicyRule securityPolicyRuleResource = new SecurityPolicyRule();
            // Make the request
            lro::Operation<Operation, Operation> response = securityPoliciesClient.PatchRule(project, securityPolicy, securityPolicyRuleResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = securityPoliciesClient.PollOncePatchRule(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PatchRuleAsync</summary>
        public async Task PatchRuleAsync()
        {
            // Snippet: PatchRuleAsync(string, string, SecurityPolicyRule, CallSettings)
            // Additional: PatchRuleAsync(string, string, SecurityPolicyRule, CancellationToken)
            // Create client
            SecurityPoliciesClient securityPoliciesClient = await SecurityPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string securityPolicy = "";
            SecurityPolicyRule securityPolicyRuleResource = new SecurityPolicyRule();
            // Make the request
            lro::Operation<Operation, Operation> response = await securityPoliciesClient.PatchRuleAsync(project, securityPolicy, securityPolicyRuleResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await securityPoliciesClient.PollOncePatchRuleAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RemoveRule</summary>
        public void RemoveRuleRequestObject()
        {
            // Snippet: RemoveRule(RemoveRuleSecurityPolicyRequest, CallSettings)
            // Create client
            SecurityPoliciesClient securityPoliciesClient = SecurityPoliciesClient.Create();
            // Initialize request argument(s)
            RemoveRuleSecurityPolicyRequest request = new RemoveRuleSecurityPolicyRequest
            {
                SecurityPolicy = "",
                Project = "",
                Priority = 0,
            };
            // Make the request
            lro::Operation<Operation, Operation> response = securityPoliciesClient.RemoveRule(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = securityPoliciesClient.PollOnceRemoveRule(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RemoveRuleAsync</summary>
        public async Task RemoveRuleRequestObjectAsync()
        {
            // Snippet: RemoveRuleAsync(RemoveRuleSecurityPolicyRequest, CallSettings)
            // Additional: RemoveRuleAsync(RemoveRuleSecurityPolicyRequest, CancellationToken)
            // Create client
            SecurityPoliciesClient securityPoliciesClient = await SecurityPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            RemoveRuleSecurityPolicyRequest request = new RemoveRuleSecurityPolicyRequest
            {
                SecurityPolicy = "",
                Project = "",
                Priority = 0,
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await securityPoliciesClient.RemoveRuleAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await securityPoliciesClient.PollOnceRemoveRuleAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RemoveRule</summary>
        public void RemoveRule()
        {
            // Snippet: RemoveRule(string, string, CallSettings)
            // Create client
            SecurityPoliciesClient securityPoliciesClient = SecurityPoliciesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string securityPolicy = "";
            // Make the request
            lro::Operation<Operation, Operation> response = securityPoliciesClient.RemoveRule(project, securityPolicy);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = securityPoliciesClient.PollOnceRemoveRule(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RemoveRuleAsync</summary>
        public async Task RemoveRuleAsync()
        {
            // Snippet: RemoveRuleAsync(string, string, CallSettings)
            // Additional: RemoveRuleAsync(string, string, CancellationToken)
            // Create client
            SecurityPoliciesClient securityPoliciesClient = await SecurityPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string securityPolicy = "";
            // Make the request
            lro::Operation<Operation, Operation> response = await securityPoliciesClient.RemoveRuleAsync(project, securityPolicy);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await securityPoliciesClient.PollOnceRemoveRuleAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetLabels</summary>
        public void SetLabelsRequestObject()
        {
            // Snippet: SetLabels(SetLabelsSecurityPolicyRequest, CallSettings)
            // Create client
            SecurityPoliciesClient securityPoliciesClient = SecurityPoliciesClient.Create();
            // Initialize request argument(s)
            SetLabelsSecurityPolicyRequest request = new SetLabelsSecurityPolicyRequest
            {
                Resource = "",
                Project = "",
                GlobalSetLabelsRequestResource = new GlobalSetLabelsRequest(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = securityPoliciesClient.SetLabels(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = securityPoliciesClient.PollOnceSetLabels(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetLabelsAsync</summary>
        public async Task SetLabelsRequestObjectAsync()
        {
            // Snippet: SetLabelsAsync(SetLabelsSecurityPolicyRequest, CallSettings)
            // Additional: SetLabelsAsync(SetLabelsSecurityPolicyRequest, CancellationToken)
            // Create client
            SecurityPoliciesClient securityPoliciesClient = await SecurityPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            SetLabelsSecurityPolicyRequest request = new SetLabelsSecurityPolicyRequest
            {
                Resource = "",
                Project = "",
                GlobalSetLabelsRequestResource = new GlobalSetLabelsRequest(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await securityPoliciesClient.SetLabelsAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await securityPoliciesClient.PollOnceSetLabelsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetLabels</summary>
        public void SetLabels()
        {
            // Snippet: SetLabels(string, string, GlobalSetLabelsRequest, CallSettings)
            // Create client
            SecurityPoliciesClient securityPoliciesClient = SecurityPoliciesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string resource = "";
            GlobalSetLabelsRequest globalSetLabelsRequestResource = new GlobalSetLabelsRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = securityPoliciesClient.SetLabels(project, resource, globalSetLabelsRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = securityPoliciesClient.PollOnceSetLabels(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetLabelsAsync</summary>
        public async Task SetLabelsAsync()
        {
            // Snippet: SetLabelsAsync(string, string, GlobalSetLabelsRequest, CallSettings)
            // Additional: SetLabelsAsync(string, string, GlobalSetLabelsRequest, CancellationToken)
            // Create client
            SecurityPoliciesClient securityPoliciesClient = await SecurityPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string resource = "";
            GlobalSetLabelsRequest globalSetLabelsRequestResource = new GlobalSetLabelsRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = await securityPoliciesClient.SetLabelsAsync(project, resource, globalSetLabelsRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await securityPoliciesClient.PollOnceSetLabelsAsync(operationName);
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
