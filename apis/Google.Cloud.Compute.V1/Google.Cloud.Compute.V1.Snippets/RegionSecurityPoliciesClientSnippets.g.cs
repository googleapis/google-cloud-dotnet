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
    using System.Linq;
    using System.Threading.Tasks;
    using lro = Google.LongRunning;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedRegionSecurityPoliciesClientSnippets
    {
        /// <summary>Snippet for AddRule</summary>
        public void AddRuleRequestObject()
        {
            // Snippet: AddRule(AddRuleRegionSecurityPolicyRequest, CallSettings)
            // Create client
            RegionSecurityPoliciesClient regionSecurityPoliciesClient = RegionSecurityPoliciesClient.Create();
            // Initialize request argument(s)
            AddRuleRegionSecurityPolicyRequest request = new AddRuleRegionSecurityPolicyRequest
            {
                Region = "",
                SecurityPolicy = "",
                Project = "",
                ValidateOnly = false,
                SecurityPolicyRuleResource = new SecurityPolicyRule(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = regionSecurityPoliciesClient.AddRule(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionSecurityPoliciesClient.PollOnceAddRule(operationName);
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
            // Snippet: AddRuleAsync(AddRuleRegionSecurityPolicyRequest, CallSettings)
            // Additional: AddRuleAsync(AddRuleRegionSecurityPolicyRequest, CancellationToken)
            // Create client
            RegionSecurityPoliciesClient regionSecurityPoliciesClient = await RegionSecurityPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            AddRuleRegionSecurityPolicyRequest request = new AddRuleRegionSecurityPolicyRequest
            {
                Region = "",
                SecurityPolicy = "",
                Project = "",
                ValidateOnly = false,
                SecurityPolicyRuleResource = new SecurityPolicyRule(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await regionSecurityPoliciesClient.AddRuleAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionSecurityPoliciesClient.PollOnceAddRuleAsync(operationName);
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
            // Snippet: AddRule(string, string, string, SecurityPolicyRule, CallSettings)
            // Create client
            RegionSecurityPoliciesClient regionSecurityPoliciesClient = RegionSecurityPoliciesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string securityPolicy = "";
            SecurityPolicyRule securityPolicyRuleResource = new SecurityPolicyRule();
            // Make the request
            lro::Operation<Operation, Operation> response = regionSecurityPoliciesClient.AddRule(project, region, securityPolicy, securityPolicyRuleResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionSecurityPoliciesClient.PollOnceAddRule(operationName);
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
            // Snippet: AddRuleAsync(string, string, string, SecurityPolicyRule, CallSettings)
            // Additional: AddRuleAsync(string, string, string, SecurityPolicyRule, CancellationToken)
            // Create client
            RegionSecurityPoliciesClient regionSecurityPoliciesClient = await RegionSecurityPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string securityPolicy = "";
            SecurityPolicyRule securityPolicyRuleResource = new SecurityPolicyRule();
            // Make the request
            lro::Operation<Operation, Operation> response = await regionSecurityPoliciesClient.AddRuleAsync(project, region, securityPolicy, securityPolicyRuleResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionSecurityPoliciesClient.PollOnceAddRuleAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for Delete</summary>
        public void DeleteRequestObject()
        {
            // Snippet: Delete(DeleteRegionSecurityPolicyRequest, CallSettings)
            // Create client
            RegionSecurityPoliciesClient regionSecurityPoliciesClient = RegionSecurityPoliciesClient.Create();
            // Initialize request argument(s)
            DeleteRegionSecurityPolicyRequest request = new DeleteRegionSecurityPolicyRequest
            {
                RequestId = "",
                Region = "",
                SecurityPolicy = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = regionSecurityPoliciesClient.Delete(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionSecurityPoliciesClient.PollOnceDelete(operationName);
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
            // Snippet: DeleteAsync(DeleteRegionSecurityPolicyRequest, CallSettings)
            // Additional: DeleteAsync(DeleteRegionSecurityPolicyRequest, CancellationToken)
            // Create client
            RegionSecurityPoliciesClient regionSecurityPoliciesClient = await RegionSecurityPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            DeleteRegionSecurityPolicyRequest request = new DeleteRegionSecurityPolicyRequest
            {
                RequestId = "",
                Region = "",
                SecurityPolicy = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await regionSecurityPoliciesClient.DeleteAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionSecurityPoliciesClient.PollOnceDeleteAsync(operationName);
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
            RegionSecurityPoliciesClient regionSecurityPoliciesClient = RegionSecurityPoliciesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string securityPolicy = "";
            // Make the request
            lro::Operation<Operation, Operation> response = regionSecurityPoliciesClient.Delete(project, region, securityPolicy);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionSecurityPoliciesClient.PollOnceDelete(operationName);
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
            RegionSecurityPoliciesClient regionSecurityPoliciesClient = await RegionSecurityPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string securityPolicy = "";
            // Make the request
            lro::Operation<Operation, Operation> response = await regionSecurityPoliciesClient.DeleteAsync(project, region, securityPolicy);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionSecurityPoliciesClient.PollOnceDeleteAsync(operationName);
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
            // Snippet: Get(GetRegionSecurityPolicyRequest, CallSettings)
            // Create client
            RegionSecurityPoliciesClient regionSecurityPoliciesClient = RegionSecurityPoliciesClient.Create();
            // Initialize request argument(s)
            GetRegionSecurityPolicyRequest request = new GetRegionSecurityPolicyRequest
            {
                Region = "",
                SecurityPolicy = "",
                Project = "",
            };
            // Make the request
            SecurityPolicy response = regionSecurityPoliciesClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetRegionSecurityPolicyRequest, CallSettings)
            // Additional: GetAsync(GetRegionSecurityPolicyRequest, CancellationToken)
            // Create client
            RegionSecurityPoliciesClient regionSecurityPoliciesClient = await RegionSecurityPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            GetRegionSecurityPolicyRequest request = new GetRegionSecurityPolicyRequest
            {
                Region = "",
                SecurityPolicy = "",
                Project = "",
            };
            // Make the request
            SecurityPolicy response = await regionSecurityPoliciesClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, string, CallSettings)
            // Create client
            RegionSecurityPoliciesClient regionSecurityPoliciesClient = RegionSecurityPoliciesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string securityPolicy = "";
            // Make the request
            SecurityPolicy response = regionSecurityPoliciesClient.Get(project, region, securityPolicy);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, string, CallSettings)
            // Additional: GetAsync(string, string, string, CancellationToken)
            // Create client
            RegionSecurityPoliciesClient regionSecurityPoliciesClient = await RegionSecurityPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string securityPolicy = "";
            // Make the request
            SecurityPolicy response = await regionSecurityPoliciesClient.GetAsync(project, region, securityPolicy);
            // End snippet
        }

        /// <summary>Snippet for GetRule</summary>
        public void GetRuleRequestObject()
        {
            // Snippet: GetRule(GetRuleRegionSecurityPolicyRequest, CallSettings)
            // Create client
            RegionSecurityPoliciesClient regionSecurityPoliciesClient = RegionSecurityPoliciesClient.Create();
            // Initialize request argument(s)
            GetRuleRegionSecurityPolicyRequest request = new GetRuleRegionSecurityPolicyRequest
            {
                Region = "",
                SecurityPolicy = "",
                Project = "",
                Priority = 0,
            };
            // Make the request
            SecurityPolicyRule response = regionSecurityPoliciesClient.GetRule(request);
            // End snippet
        }

        /// <summary>Snippet for GetRuleAsync</summary>
        public async Task GetRuleRequestObjectAsync()
        {
            // Snippet: GetRuleAsync(GetRuleRegionSecurityPolicyRequest, CallSettings)
            // Additional: GetRuleAsync(GetRuleRegionSecurityPolicyRequest, CancellationToken)
            // Create client
            RegionSecurityPoliciesClient regionSecurityPoliciesClient = await RegionSecurityPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            GetRuleRegionSecurityPolicyRequest request = new GetRuleRegionSecurityPolicyRequest
            {
                Region = "",
                SecurityPolicy = "",
                Project = "",
                Priority = 0,
            };
            // Make the request
            SecurityPolicyRule response = await regionSecurityPoliciesClient.GetRuleAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetRule</summary>
        public void GetRule()
        {
            // Snippet: GetRule(string, string, string, CallSettings)
            // Create client
            RegionSecurityPoliciesClient regionSecurityPoliciesClient = RegionSecurityPoliciesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string securityPolicy = "";
            // Make the request
            SecurityPolicyRule response = regionSecurityPoliciesClient.GetRule(project, region, securityPolicy);
            // End snippet
        }

        /// <summary>Snippet for GetRuleAsync</summary>
        public async Task GetRuleAsync()
        {
            // Snippet: GetRuleAsync(string, string, string, CallSettings)
            // Additional: GetRuleAsync(string, string, string, CancellationToken)
            // Create client
            RegionSecurityPoliciesClient regionSecurityPoliciesClient = await RegionSecurityPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string securityPolicy = "";
            // Make the request
            SecurityPolicyRule response = await regionSecurityPoliciesClient.GetRuleAsync(project, region, securityPolicy);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void InsertRequestObject()
        {
            // Snippet: Insert(InsertRegionSecurityPolicyRequest, CallSettings)
            // Create client
            RegionSecurityPoliciesClient regionSecurityPoliciesClient = RegionSecurityPoliciesClient.Create();
            // Initialize request argument(s)
            InsertRegionSecurityPolicyRequest request = new InsertRegionSecurityPolicyRequest
            {
                RequestId = "",
                Region = "",
                SecurityPolicyResource = new SecurityPolicy(),
                Project = "",
                ValidateOnly = false,
            };
            // Make the request
            lro::Operation<Operation, Operation> response = regionSecurityPoliciesClient.Insert(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionSecurityPoliciesClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(InsertRegionSecurityPolicyRequest, CallSettings)
            // Additional: InsertAsync(InsertRegionSecurityPolicyRequest, CancellationToken)
            // Create client
            RegionSecurityPoliciesClient regionSecurityPoliciesClient = await RegionSecurityPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            InsertRegionSecurityPolicyRequest request = new InsertRegionSecurityPolicyRequest
            {
                RequestId = "",
                Region = "",
                SecurityPolicyResource = new SecurityPolicy(),
                Project = "",
                ValidateOnly = false,
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await regionSecurityPoliciesClient.InsertAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionSecurityPoliciesClient.PollOnceInsertAsync(operationName);
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
            // Snippet: Insert(string, string, SecurityPolicy, CallSettings)
            // Create client
            RegionSecurityPoliciesClient regionSecurityPoliciesClient = RegionSecurityPoliciesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            SecurityPolicy securityPolicyResource = new SecurityPolicy();
            // Make the request
            lro::Operation<Operation, Operation> response = regionSecurityPoliciesClient.Insert(project, region, securityPolicyResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionSecurityPoliciesClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(string, string, SecurityPolicy, CallSettings)
            // Additional: InsertAsync(string, string, SecurityPolicy, CancellationToken)
            // Create client
            RegionSecurityPoliciesClient regionSecurityPoliciesClient = await RegionSecurityPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            SecurityPolicy securityPolicyResource = new SecurityPolicy();
            // Make the request
            lro::Operation<Operation, Operation> response = await regionSecurityPoliciesClient.InsertAsync(project, region, securityPolicyResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionSecurityPoliciesClient.PollOnceInsertAsync(operationName);
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
            // Snippet: List(ListRegionSecurityPoliciesRequest, CallSettings)
            // Create client
            RegionSecurityPoliciesClient regionSecurityPoliciesClient = RegionSecurityPoliciesClient.Create();
            // Initialize request argument(s)
            ListRegionSecurityPoliciesRequest request = new ListRegionSecurityPoliciesRequest
            {
                Region = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<SecurityPolicyList, SecurityPolicy> response = regionSecurityPoliciesClient.List(request);

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
            // Snippet: ListAsync(ListRegionSecurityPoliciesRequest, CallSettings)
            // Create client
            RegionSecurityPoliciesClient regionSecurityPoliciesClient = await RegionSecurityPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            ListRegionSecurityPoliciesRequest request = new ListRegionSecurityPoliciesRequest
            {
                Region = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<SecurityPolicyList, SecurityPolicy> response = regionSecurityPoliciesClient.ListAsync(request);

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
            // Snippet: List(string, string, string, int?, CallSettings)
            // Create client
            RegionSecurityPoliciesClient regionSecurityPoliciesClient = RegionSecurityPoliciesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            PagedEnumerable<SecurityPolicyList, SecurityPolicy> response = regionSecurityPoliciesClient.List(project, region);

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
            // Snippet: ListAsync(string, string, string, int?, CallSettings)
            // Create client
            RegionSecurityPoliciesClient regionSecurityPoliciesClient = await RegionSecurityPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            PagedAsyncEnumerable<SecurityPolicyList, SecurityPolicy> response = regionSecurityPoliciesClient.ListAsync(project, region);

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

        /// <summary>Snippet for Patch</summary>
        public void PatchRequestObject()
        {
            // Snippet: Patch(PatchRegionSecurityPolicyRequest, CallSettings)
            // Create client
            RegionSecurityPoliciesClient regionSecurityPoliciesClient = RegionSecurityPoliciesClient.Create();
            // Initialize request argument(s)
            PatchRegionSecurityPolicyRequest request = new PatchRegionSecurityPolicyRequest
            {
                RequestId = "",
                Region = "",
                SecurityPolicy = "",
                SecurityPolicyResource = new SecurityPolicy(),
                Project = "",
                UpdateMask = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = regionSecurityPoliciesClient.Patch(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionSecurityPoliciesClient.PollOncePatch(operationName);
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
            // Snippet: PatchAsync(PatchRegionSecurityPolicyRequest, CallSettings)
            // Additional: PatchAsync(PatchRegionSecurityPolicyRequest, CancellationToken)
            // Create client
            RegionSecurityPoliciesClient regionSecurityPoliciesClient = await RegionSecurityPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            PatchRegionSecurityPolicyRequest request = new PatchRegionSecurityPolicyRequest
            {
                RequestId = "",
                Region = "",
                SecurityPolicy = "",
                SecurityPolicyResource = new SecurityPolicy(),
                Project = "",
                UpdateMask = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await regionSecurityPoliciesClient.PatchAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionSecurityPoliciesClient.PollOncePatchAsync(operationName);
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
            // Snippet: Patch(string, string, string, SecurityPolicy, CallSettings)
            // Create client
            RegionSecurityPoliciesClient regionSecurityPoliciesClient = RegionSecurityPoliciesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string securityPolicy = "";
            SecurityPolicy securityPolicyResource = new SecurityPolicy();
            // Make the request
            lro::Operation<Operation, Operation> response = regionSecurityPoliciesClient.Patch(project, region, securityPolicy, securityPolicyResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionSecurityPoliciesClient.PollOncePatch(operationName);
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
            // Snippet: PatchAsync(string, string, string, SecurityPolicy, CallSettings)
            // Additional: PatchAsync(string, string, string, SecurityPolicy, CancellationToken)
            // Create client
            RegionSecurityPoliciesClient regionSecurityPoliciesClient = await RegionSecurityPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string securityPolicy = "";
            SecurityPolicy securityPolicyResource = new SecurityPolicy();
            // Make the request
            lro::Operation<Operation, Operation> response = await regionSecurityPoliciesClient.PatchAsync(project, region, securityPolicy, securityPolicyResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionSecurityPoliciesClient.PollOncePatchAsync(operationName);
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
            // Snippet: PatchRule(PatchRuleRegionSecurityPolicyRequest, CallSettings)
            // Create client
            RegionSecurityPoliciesClient regionSecurityPoliciesClient = RegionSecurityPoliciesClient.Create();
            // Initialize request argument(s)
            PatchRuleRegionSecurityPolicyRequest request = new PatchRuleRegionSecurityPolicyRequest
            {
                Region = "",
                SecurityPolicy = "",
                Project = "",
                ValidateOnly = false,
                SecurityPolicyRuleResource = new SecurityPolicyRule(),
                Priority = 0,
                UpdateMask = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = regionSecurityPoliciesClient.PatchRule(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionSecurityPoliciesClient.PollOncePatchRule(operationName);
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
            // Snippet: PatchRuleAsync(PatchRuleRegionSecurityPolicyRequest, CallSettings)
            // Additional: PatchRuleAsync(PatchRuleRegionSecurityPolicyRequest, CancellationToken)
            // Create client
            RegionSecurityPoliciesClient regionSecurityPoliciesClient = await RegionSecurityPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            PatchRuleRegionSecurityPolicyRequest request = new PatchRuleRegionSecurityPolicyRequest
            {
                Region = "",
                SecurityPolicy = "",
                Project = "",
                ValidateOnly = false,
                SecurityPolicyRuleResource = new SecurityPolicyRule(),
                Priority = 0,
                UpdateMask = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await regionSecurityPoliciesClient.PatchRuleAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionSecurityPoliciesClient.PollOncePatchRuleAsync(operationName);
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
            // Snippet: PatchRule(string, string, string, SecurityPolicyRule, CallSettings)
            // Create client
            RegionSecurityPoliciesClient regionSecurityPoliciesClient = RegionSecurityPoliciesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string securityPolicy = "";
            SecurityPolicyRule securityPolicyRuleResource = new SecurityPolicyRule();
            // Make the request
            lro::Operation<Operation, Operation> response = regionSecurityPoliciesClient.PatchRule(project, region, securityPolicy, securityPolicyRuleResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionSecurityPoliciesClient.PollOncePatchRule(operationName);
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
            // Snippet: PatchRuleAsync(string, string, string, SecurityPolicyRule, CallSettings)
            // Additional: PatchRuleAsync(string, string, string, SecurityPolicyRule, CancellationToken)
            // Create client
            RegionSecurityPoliciesClient regionSecurityPoliciesClient = await RegionSecurityPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string securityPolicy = "";
            SecurityPolicyRule securityPolicyRuleResource = new SecurityPolicyRule();
            // Make the request
            lro::Operation<Operation, Operation> response = await regionSecurityPoliciesClient.PatchRuleAsync(project, region, securityPolicy, securityPolicyRuleResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionSecurityPoliciesClient.PollOncePatchRuleAsync(operationName);
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
            // Snippet: RemoveRule(RemoveRuleRegionSecurityPolicyRequest, CallSettings)
            // Create client
            RegionSecurityPoliciesClient regionSecurityPoliciesClient = RegionSecurityPoliciesClient.Create();
            // Initialize request argument(s)
            RemoveRuleRegionSecurityPolicyRequest request = new RemoveRuleRegionSecurityPolicyRequest
            {
                Region = "",
                SecurityPolicy = "",
                Project = "",
                Priority = 0,
            };
            // Make the request
            lro::Operation<Operation, Operation> response = regionSecurityPoliciesClient.RemoveRule(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionSecurityPoliciesClient.PollOnceRemoveRule(operationName);
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
            // Snippet: RemoveRuleAsync(RemoveRuleRegionSecurityPolicyRequest, CallSettings)
            // Additional: RemoveRuleAsync(RemoveRuleRegionSecurityPolicyRequest, CancellationToken)
            // Create client
            RegionSecurityPoliciesClient regionSecurityPoliciesClient = await RegionSecurityPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            RemoveRuleRegionSecurityPolicyRequest request = new RemoveRuleRegionSecurityPolicyRequest
            {
                Region = "",
                SecurityPolicy = "",
                Project = "",
                Priority = 0,
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await regionSecurityPoliciesClient.RemoveRuleAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionSecurityPoliciesClient.PollOnceRemoveRuleAsync(operationName);
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
            // Snippet: RemoveRule(string, string, string, CallSettings)
            // Create client
            RegionSecurityPoliciesClient regionSecurityPoliciesClient = RegionSecurityPoliciesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string securityPolicy = "";
            // Make the request
            lro::Operation<Operation, Operation> response = regionSecurityPoliciesClient.RemoveRule(project, region, securityPolicy);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionSecurityPoliciesClient.PollOnceRemoveRule(operationName);
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
            // Snippet: RemoveRuleAsync(string, string, string, CallSettings)
            // Additional: RemoveRuleAsync(string, string, string, CancellationToken)
            // Create client
            RegionSecurityPoliciesClient regionSecurityPoliciesClient = await RegionSecurityPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string securityPolicy = "";
            // Make the request
            lro::Operation<Operation, Operation> response = await regionSecurityPoliciesClient.RemoveRuleAsync(project, region, securityPolicy);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionSecurityPoliciesClient.PollOnceRemoveRuleAsync(operationName);
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
            // Snippet: SetLabels(SetLabelsRegionSecurityPolicyRequest, CallSettings)
            // Create client
            RegionSecurityPoliciesClient regionSecurityPoliciesClient = RegionSecurityPoliciesClient.Create();
            // Initialize request argument(s)
            SetLabelsRegionSecurityPolicyRequest request = new SetLabelsRegionSecurityPolicyRequest
            {
                RequestId = "",
                Region = "",
                Resource = "",
                Project = "",
                RegionSetLabelsRequestResource = new RegionSetLabelsRequest(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = regionSecurityPoliciesClient.SetLabels(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionSecurityPoliciesClient.PollOnceSetLabels(operationName);
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
            // Snippet: SetLabelsAsync(SetLabelsRegionSecurityPolicyRequest, CallSettings)
            // Additional: SetLabelsAsync(SetLabelsRegionSecurityPolicyRequest, CancellationToken)
            // Create client
            RegionSecurityPoliciesClient regionSecurityPoliciesClient = await RegionSecurityPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            SetLabelsRegionSecurityPolicyRequest request = new SetLabelsRegionSecurityPolicyRequest
            {
                RequestId = "",
                Region = "",
                Resource = "",
                Project = "",
                RegionSetLabelsRequestResource = new RegionSetLabelsRequest(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await regionSecurityPoliciesClient.SetLabelsAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionSecurityPoliciesClient.PollOnceSetLabelsAsync(operationName);
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
            // Snippet: SetLabels(string, string, string, RegionSetLabelsRequest, CallSettings)
            // Create client
            RegionSecurityPoliciesClient regionSecurityPoliciesClient = RegionSecurityPoliciesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string resource = "";
            RegionSetLabelsRequest regionSetLabelsRequestResource = new RegionSetLabelsRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = regionSecurityPoliciesClient.SetLabels(project, region, resource, regionSetLabelsRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionSecurityPoliciesClient.PollOnceSetLabels(operationName);
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
            // Snippet: SetLabelsAsync(string, string, string, RegionSetLabelsRequest, CallSettings)
            // Additional: SetLabelsAsync(string, string, string, RegionSetLabelsRequest, CancellationToken)
            // Create client
            RegionSecurityPoliciesClient regionSecurityPoliciesClient = await RegionSecurityPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string resource = "";
            RegionSetLabelsRequest regionSetLabelsRequestResource = new RegionSetLabelsRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = await regionSecurityPoliciesClient.SetLabelsAsync(project, region, resource, regionSetLabelsRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionSecurityPoliciesClient.PollOnceSetLabelsAsync(operationName);
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
