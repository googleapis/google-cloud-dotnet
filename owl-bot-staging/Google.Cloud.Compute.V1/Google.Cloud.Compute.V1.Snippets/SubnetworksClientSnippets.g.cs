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
    public sealed class AllGeneratedSubnetworksClientSnippets
    {
        /// <summary>Snippet for AggregatedList</summary>
        public void AggregatedListRequestObject()
        {
            // Snippet: AggregatedList(AggregatedListSubnetworksRequest, CallSettings)
            // Create client
            SubnetworksClient subnetworksClient = SubnetworksClient.Create();
            // Initialize request argument(s)
            AggregatedListSubnetworksRequest request = new AggregatedListSubnetworksRequest
            {
                OrderBy = "",
                Project = "",
                ServiceProjectNumber = 0L,
                Filter = "",
                IncludeAllScopes = false,
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<SubnetworkAggregatedList, KeyValuePair<string, SubnetworksScopedList>> response = subnetworksClient.AggregatedList(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (KeyValuePair<string, SubnetworksScopedList> item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SubnetworkAggregatedList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, SubnetworksScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, SubnetworksScopedList>> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, SubnetworksScopedList> item in singlePage)
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
            // Snippet: AggregatedListAsync(AggregatedListSubnetworksRequest, CallSettings)
            // Create client
            SubnetworksClient subnetworksClient = await SubnetworksClient.CreateAsync();
            // Initialize request argument(s)
            AggregatedListSubnetworksRequest request = new AggregatedListSubnetworksRequest
            {
                OrderBy = "",
                Project = "",
                ServiceProjectNumber = 0L,
                Filter = "",
                IncludeAllScopes = false,
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<SubnetworkAggregatedList, KeyValuePair<string, SubnetworksScopedList>> response = subnetworksClient.AggregatedListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((KeyValuePair<string, SubnetworksScopedList> item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SubnetworkAggregatedList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, SubnetworksScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, SubnetworksScopedList>> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, SubnetworksScopedList> item in singlePage)
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
            SubnetworksClient subnetworksClient = SubnetworksClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedEnumerable<SubnetworkAggregatedList, KeyValuePair<string, SubnetworksScopedList>> response = subnetworksClient.AggregatedList(project);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (KeyValuePair<string, SubnetworksScopedList> item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SubnetworkAggregatedList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, SubnetworksScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, SubnetworksScopedList>> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, SubnetworksScopedList> item in singlePage)
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
            SubnetworksClient subnetworksClient = await SubnetworksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedAsyncEnumerable<SubnetworkAggregatedList, KeyValuePair<string, SubnetworksScopedList>> response = subnetworksClient.AggregatedListAsync(project);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((KeyValuePair<string, SubnetworksScopedList> item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SubnetworkAggregatedList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, SubnetworksScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, SubnetworksScopedList>> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, SubnetworksScopedList> item in singlePage)
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
            // Snippet: Delete(DeleteSubnetworkRequest, CallSettings)
            // Create client
            SubnetworksClient subnetworksClient = SubnetworksClient.Create();
            // Initialize request argument(s)
            DeleteSubnetworkRequest request = new DeleteSubnetworkRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                Subnetwork = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = subnetworksClient.Delete(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = subnetworksClient.PollOnceDelete(operationName);
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
            // Snippet: DeleteAsync(DeleteSubnetworkRequest, CallSettings)
            // Additional: DeleteAsync(DeleteSubnetworkRequest, CancellationToken)
            // Create client
            SubnetworksClient subnetworksClient = await SubnetworksClient.CreateAsync();
            // Initialize request argument(s)
            DeleteSubnetworkRequest request = new DeleteSubnetworkRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                Subnetwork = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await subnetworksClient.DeleteAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await subnetworksClient.PollOnceDeleteAsync(operationName);
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
            SubnetworksClient subnetworksClient = SubnetworksClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string subnetwork = "";
            // Make the request
            lro::Operation<Operation, Operation> response = subnetworksClient.Delete(project, region, subnetwork);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = subnetworksClient.PollOnceDelete(operationName);
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
            SubnetworksClient subnetworksClient = await SubnetworksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string subnetwork = "";
            // Make the request
            lro::Operation<Operation, Operation> response = await subnetworksClient.DeleteAsync(project, region, subnetwork);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await subnetworksClient.PollOnceDeleteAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExpandIpCidrRange</summary>
        public void ExpandIpCidrRangeRequestObject()
        {
            // Snippet: ExpandIpCidrRange(ExpandIpCidrRangeSubnetworkRequest, CallSettings)
            // Create client
            SubnetworksClient subnetworksClient = SubnetworksClient.Create();
            // Initialize request argument(s)
            ExpandIpCidrRangeSubnetworkRequest request = new ExpandIpCidrRangeSubnetworkRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                Subnetwork = "",
                SubnetworksExpandIpCidrRangeRequestResource = new SubnetworksExpandIpCidrRangeRequest(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = subnetworksClient.ExpandIpCidrRange(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = subnetworksClient.PollOnceExpandIpCidrRange(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExpandIpCidrRangeAsync</summary>
        public async Task ExpandIpCidrRangeRequestObjectAsync()
        {
            // Snippet: ExpandIpCidrRangeAsync(ExpandIpCidrRangeSubnetworkRequest, CallSettings)
            // Additional: ExpandIpCidrRangeAsync(ExpandIpCidrRangeSubnetworkRequest, CancellationToken)
            // Create client
            SubnetworksClient subnetworksClient = await SubnetworksClient.CreateAsync();
            // Initialize request argument(s)
            ExpandIpCidrRangeSubnetworkRequest request = new ExpandIpCidrRangeSubnetworkRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                Subnetwork = "",
                SubnetworksExpandIpCidrRangeRequestResource = new SubnetworksExpandIpCidrRangeRequest(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await subnetworksClient.ExpandIpCidrRangeAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await subnetworksClient.PollOnceExpandIpCidrRangeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExpandIpCidrRange</summary>
        public void ExpandIpCidrRange()
        {
            // Snippet: ExpandIpCidrRange(string, string, string, SubnetworksExpandIpCidrRangeRequest, CallSettings)
            // Create client
            SubnetworksClient subnetworksClient = SubnetworksClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string subnetwork = "";
            SubnetworksExpandIpCidrRangeRequest subnetworksExpandIpCidrRangeRequestResource = new SubnetworksExpandIpCidrRangeRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = subnetworksClient.ExpandIpCidrRange(project, region, subnetwork, subnetworksExpandIpCidrRangeRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = subnetworksClient.PollOnceExpandIpCidrRange(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExpandIpCidrRangeAsync</summary>
        public async Task ExpandIpCidrRangeAsync()
        {
            // Snippet: ExpandIpCidrRangeAsync(string, string, string, SubnetworksExpandIpCidrRangeRequest, CallSettings)
            // Additional: ExpandIpCidrRangeAsync(string, string, string, SubnetworksExpandIpCidrRangeRequest, CancellationToken)
            // Create client
            SubnetworksClient subnetworksClient = await SubnetworksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string subnetwork = "";
            SubnetworksExpandIpCidrRangeRequest subnetworksExpandIpCidrRangeRequestResource = new SubnetworksExpandIpCidrRangeRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = await subnetworksClient.ExpandIpCidrRangeAsync(project, region, subnetwork, subnetworksExpandIpCidrRangeRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await subnetworksClient.PollOnceExpandIpCidrRangeAsync(operationName);
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
            // Snippet: Get(GetSubnetworkRequest, CallSettings)
            // Create client
            SubnetworksClient subnetworksClient = SubnetworksClient.Create();
            // Initialize request argument(s)
            GetSubnetworkRequest request = new GetSubnetworkRequest
            {
                Region = "",
                Project = "",
                Subnetwork = "",
            };
            // Make the request
            Subnetwork response = subnetworksClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetSubnetworkRequest, CallSettings)
            // Additional: GetAsync(GetSubnetworkRequest, CancellationToken)
            // Create client
            SubnetworksClient subnetworksClient = await SubnetworksClient.CreateAsync();
            // Initialize request argument(s)
            GetSubnetworkRequest request = new GetSubnetworkRequest
            {
                Region = "",
                Project = "",
                Subnetwork = "",
            };
            // Make the request
            Subnetwork response = await subnetworksClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, string, CallSettings)
            // Create client
            SubnetworksClient subnetworksClient = SubnetworksClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string subnetwork = "";
            // Make the request
            Subnetwork response = subnetworksClient.Get(project, region, subnetwork);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, string, CallSettings)
            // Additional: GetAsync(string, string, string, CancellationToken)
            // Create client
            SubnetworksClient subnetworksClient = await SubnetworksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string subnetwork = "";
            // Make the request
            Subnetwork response = await subnetworksClient.GetAsync(project, region, subnetwork);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicyRequestObject()
        {
            // Snippet: GetIamPolicy(GetIamPolicySubnetworkRequest, CallSettings)
            // Create client
            SubnetworksClient subnetworksClient = SubnetworksClient.Create();
            // Initialize request argument(s)
            GetIamPolicySubnetworkRequest request = new GetIamPolicySubnetworkRequest
            {
                Region = "",
                Resource = "",
                Project = "",
                OptionsRequestedPolicyVersion = 0,
            };
            // Make the request
            Policy response = subnetworksClient.GetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyRequestObjectAsync()
        {
            // Snippet: GetIamPolicyAsync(GetIamPolicySubnetworkRequest, CallSettings)
            // Additional: GetIamPolicyAsync(GetIamPolicySubnetworkRequest, CancellationToken)
            // Create client
            SubnetworksClient subnetworksClient = await SubnetworksClient.CreateAsync();
            // Initialize request argument(s)
            GetIamPolicySubnetworkRequest request = new GetIamPolicySubnetworkRequest
            {
                Region = "",
                Resource = "",
                Project = "",
                OptionsRequestedPolicyVersion = 0,
            };
            // Make the request
            Policy response = await subnetworksClient.GetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicy()
        {
            // Snippet: GetIamPolicy(string, string, string, CallSettings)
            // Create client
            SubnetworksClient subnetworksClient = SubnetworksClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string resource = "";
            // Make the request
            Policy response = subnetworksClient.GetIamPolicy(project, region, resource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyAsync()
        {
            // Snippet: GetIamPolicyAsync(string, string, string, CallSettings)
            // Additional: GetIamPolicyAsync(string, string, string, CancellationToken)
            // Create client
            SubnetworksClient subnetworksClient = await SubnetworksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string resource = "";
            // Make the request
            Policy response = await subnetworksClient.GetIamPolicyAsync(project, region, resource);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void InsertRequestObject()
        {
            // Snippet: Insert(InsertSubnetworkRequest, CallSettings)
            // Create client
            SubnetworksClient subnetworksClient = SubnetworksClient.Create();
            // Initialize request argument(s)
            InsertSubnetworkRequest request = new InsertSubnetworkRequest
            {
                RequestId = "",
                SubnetworkResource = new Subnetwork(),
                Region = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = subnetworksClient.Insert(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = subnetworksClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(InsertSubnetworkRequest, CallSettings)
            // Additional: InsertAsync(InsertSubnetworkRequest, CancellationToken)
            // Create client
            SubnetworksClient subnetworksClient = await SubnetworksClient.CreateAsync();
            // Initialize request argument(s)
            InsertSubnetworkRequest request = new InsertSubnetworkRequest
            {
                RequestId = "",
                SubnetworkResource = new Subnetwork(),
                Region = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await subnetworksClient.InsertAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await subnetworksClient.PollOnceInsertAsync(operationName);
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
            // Snippet: Insert(string, string, Subnetwork, CallSettings)
            // Create client
            SubnetworksClient subnetworksClient = SubnetworksClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            Subnetwork subnetworkResource = new Subnetwork();
            // Make the request
            lro::Operation<Operation, Operation> response = subnetworksClient.Insert(project, region, subnetworkResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = subnetworksClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(string, string, Subnetwork, CallSettings)
            // Additional: InsertAsync(string, string, Subnetwork, CancellationToken)
            // Create client
            SubnetworksClient subnetworksClient = await SubnetworksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            Subnetwork subnetworkResource = new Subnetwork();
            // Make the request
            lro::Operation<Operation, Operation> response = await subnetworksClient.InsertAsync(project, region, subnetworkResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await subnetworksClient.PollOnceInsertAsync(operationName);
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
            // Snippet: List(ListSubnetworksRequest, CallSettings)
            // Create client
            SubnetworksClient subnetworksClient = SubnetworksClient.Create();
            // Initialize request argument(s)
            ListSubnetworksRequest request = new ListSubnetworksRequest
            {
                Region = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<SubnetworkList, Subnetwork> response = subnetworksClient.List(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Subnetwork item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SubnetworkList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Subnetwork item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Subnetwork> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Subnetwork item in singlePage)
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
            // Snippet: ListAsync(ListSubnetworksRequest, CallSettings)
            // Create client
            SubnetworksClient subnetworksClient = await SubnetworksClient.CreateAsync();
            // Initialize request argument(s)
            ListSubnetworksRequest request = new ListSubnetworksRequest
            {
                Region = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<SubnetworkList, Subnetwork> response = subnetworksClient.ListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Subnetwork item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SubnetworkList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Subnetwork item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Subnetwork> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Subnetwork item in singlePage)
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
            SubnetworksClient subnetworksClient = SubnetworksClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            PagedEnumerable<SubnetworkList, Subnetwork> response = subnetworksClient.List(project, region);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Subnetwork item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SubnetworkList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Subnetwork item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Subnetwork> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Subnetwork item in singlePage)
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
            SubnetworksClient subnetworksClient = await SubnetworksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            PagedAsyncEnumerable<SubnetworkList, Subnetwork> response = subnetworksClient.ListAsync(project, region);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Subnetwork item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SubnetworkList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Subnetwork item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Subnetwork> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Subnetwork item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUsable</summary>
        public void ListUsableRequestObject()
        {
            // Snippet: ListUsable(ListUsableSubnetworksRequest, CallSettings)
            // Create client
            SubnetworksClient subnetworksClient = SubnetworksClient.Create();
            // Initialize request argument(s)
            ListUsableSubnetworksRequest request = new ListUsableSubnetworksRequest
            {
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<UsableSubnetworksAggregatedList, UsableSubnetwork> response = subnetworksClient.ListUsable(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (UsableSubnetwork item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (UsableSubnetworksAggregatedList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (UsableSubnetwork item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<UsableSubnetwork> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (UsableSubnetwork item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUsableAsync</summary>
        public async Task ListUsableRequestObjectAsync()
        {
            // Snippet: ListUsableAsync(ListUsableSubnetworksRequest, CallSettings)
            // Create client
            SubnetworksClient subnetworksClient = await SubnetworksClient.CreateAsync();
            // Initialize request argument(s)
            ListUsableSubnetworksRequest request = new ListUsableSubnetworksRequest
            {
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<UsableSubnetworksAggregatedList, UsableSubnetwork> response = subnetworksClient.ListUsableAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((UsableSubnetwork item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((UsableSubnetworksAggregatedList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (UsableSubnetwork item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<UsableSubnetwork> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (UsableSubnetwork item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUsable</summary>
        public void ListUsable()
        {
            // Snippet: ListUsable(string, string, int?, CallSettings)
            // Create client
            SubnetworksClient subnetworksClient = SubnetworksClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedEnumerable<UsableSubnetworksAggregatedList, UsableSubnetwork> response = subnetworksClient.ListUsable(project);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (UsableSubnetwork item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (UsableSubnetworksAggregatedList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (UsableSubnetwork item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<UsableSubnetwork> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (UsableSubnetwork item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUsableAsync</summary>
        public async Task ListUsableAsync()
        {
            // Snippet: ListUsableAsync(string, string, int?, CallSettings)
            // Create client
            SubnetworksClient subnetworksClient = await SubnetworksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedAsyncEnumerable<UsableSubnetworksAggregatedList, UsableSubnetwork> response = subnetworksClient.ListUsableAsync(project);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((UsableSubnetwork item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((UsableSubnetworksAggregatedList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (UsableSubnetwork item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<UsableSubnetwork> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (UsableSubnetwork item in singlePage)
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
            // Snippet: Patch(PatchSubnetworkRequest, CallSettings)
            // Create client
            SubnetworksClient subnetworksClient = SubnetworksClient.Create();
            // Initialize request argument(s)
            PatchSubnetworkRequest request = new PatchSubnetworkRequest
            {
                RequestId = "",
                SubnetworkResource = new Subnetwork(),
                Region = "",
                Project = "",
                Subnetwork = "",
                DrainTimeoutSeconds = 0,
            };
            // Make the request
            lro::Operation<Operation, Operation> response = subnetworksClient.Patch(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = subnetworksClient.PollOncePatch(operationName);
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
            // Snippet: PatchAsync(PatchSubnetworkRequest, CallSettings)
            // Additional: PatchAsync(PatchSubnetworkRequest, CancellationToken)
            // Create client
            SubnetworksClient subnetworksClient = await SubnetworksClient.CreateAsync();
            // Initialize request argument(s)
            PatchSubnetworkRequest request = new PatchSubnetworkRequest
            {
                RequestId = "",
                SubnetworkResource = new Subnetwork(),
                Region = "",
                Project = "",
                Subnetwork = "",
                DrainTimeoutSeconds = 0,
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await subnetworksClient.PatchAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await subnetworksClient.PollOncePatchAsync(operationName);
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
            // Snippet: Patch(string, string, string, Subnetwork, CallSettings)
            // Create client
            SubnetworksClient subnetworksClient = SubnetworksClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string subnetwork = "";
            Subnetwork subnetworkResource = new Subnetwork();
            // Make the request
            lro::Operation<Operation, Operation> response = subnetworksClient.Patch(project, region, subnetwork, subnetworkResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = subnetworksClient.PollOncePatch(operationName);
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
            // Snippet: PatchAsync(string, string, string, Subnetwork, CallSettings)
            // Additional: PatchAsync(string, string, string, Subnetwork, CancellationToken)
            // Create client
            SubnetworksClient subnetworksClient = await SubnetworksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string subnetwork = "";
            Subnetwork subnetworkResource = new Subnetwork();
            // Make the request
            lro::Operation<Operation, Operation> response = await subnetworksClient.PatchAsync(project, region, subnetwork, subnetworkResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await subnetworksClient.PollOncePatchAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicyRequestObject()
        {
            // Snippet: SetIamPolicy(SetIamPolicySubnetworkRequest, CallSettings)
            // Create client
            SubnetworksClient subnetworksClient = SubnetworksClient.Create();
            // Initialize request argument(s)
            SetIamPolicySubnetworkRequest request = new SetIamPolicySubnetworkRequest
            {
                Region = "",
                Resource = "",
                Project = "",
                RegionSetPolicyRequestResource = new RegionSetPolicyRequest(),
            };
            // Make the request
            Policy response = subnetworksClient.SetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyRequestObjectAsync()
        {
            // Snippet: SetIamPolicyAsync(SetIamPolicySubnetworkRequest, CallSettings)
            // Additional: SetIamPolicyAsync(SetIamPolicySubnetworkRequest, CancellationToken)
            // Create client
            SubnetworksClient subnetworksClient = await SubnetworksClient.CreateAsync();
            // Initialize request argument(s)
            SetIamPolicySubnetworkRequest request = new SetIamPolicySubnetworkRequest
            {
                Region = "",
                Resource = "",
                Project = "",
                RegionSetPolicyRequestResource = new RegionSetPolicyRequest(),
            };
            // Make the request
            Policy response = await subnetworksClient.SetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicy()
        {
            // Snippet: SetIamPolicy(string, string, string, RegionSetPolicyRequest, CallSettings)
            // Create client
            SubnetworksClient subnetworksClient = SubnetworksClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string resource = "";
            RegionSetPolicyRequest regionSetPolicyRequestResource = new RegionSetPolicyRequest();
            // Make the request
            Policy response = subnetworksClient.SetIamPolicy(project, region, resource, regionSetPolicyRequestResource);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyAsync()
        {
            // Snippet: SetIamPolicyAsync(string, string, string, RegionSetPolicyRequest, CallSettings)
            // Additional: SetIamPolicyAsync(string, string, string, RegionSetPolicyRequest, CancellationToken)
            // Create client
            SubnetworksClient subnetworksClient = await SubnetworksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string resource = "";
            RegionSetPolicyRequest regionSetPolicyRequestResource = new RegionSetPolicyRequest();
            // Make the request
            Policy response = await subnetworksClient.SetIamPolicyAsync(project, region, resource, regionSetPolicyRequestResource);
            // End snippet
        }

        /// <summary>Snippet for SetPrivateIpGoogleAccess</summary>
        public void SetPrivateIpGoogleAccessRequestObject()
        {
            // Snippet: SetPrivateIpGoogleAccess(SetPrivateIpGoogleAccessSubnetworkRequest, CallSettings)
            // Create client
            SubnetworksClient subnetworksClient = SubnetworksClient.Create();
            // Initialize request argument(s)
            SetPrivateIpGoogleAccessSubnetworkRequest request = new SetPrivateIpGoogleAccessSubnetworkRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                SubnetworksSetPrivateIpGoogleAccessRequestResource = new SubnetworksSetPrivateIpGoogleAccessRequest(),
                Subnetwork = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = subnetworksClient.SetPrivateIpGoogleAccess(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = subnetworksClient.PollOnceSetPrivateIpGoogleAccess(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetPrivateIpGoogleAccessAsync</summary>
        public async Task SetPrivateIpGoogleAccessRequestObjectAsync()
        {
            // Snippet: SetPrivateIpGoogleAccessAsync(SetPrivateIpGoogleAccessSubnetworkRequest, CallSettings)
            // Additional: SetPrivateIpGoogleAccessAsync(SetPrivateIpGoogleAccessSubnetworkRequest, CancellationToken)
            // Create client
            SubnetworksClient subnetworksClient = await SubnetworksClient.CreateAsync();
            // Initialize request argument(s)
            SetPrivateIpGoogleAccessSubnetworkRequest request = new SetPrivateIpGoogleAccessSubnetworkRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                SubnetworksSetPrivateIpGoogleAccessRequestResource = new SubnetworksSetPrivateIpGoogleAccessRequest(),
                Subnetwork = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await subnetworksClient.SetPrivateIpGoogleAccessAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await subnetworksClient.PollOnceSetPrivateIpGoogleAccessAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetPrivateIpGoogleAccess</summary>
        public void SetPrivateIpGoogleAccess()
        {
            // Snippet: SetPrivateIpGoogleAccess(string, string, string, SubnetworksSetPrivateIpGoogleAccessRequest, CallSettings)
            // Create client
            SubnetworksClient subnetworksClient = SubnetworksClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string subnetwork = "";
            SubnetworksSetPrivateIpGoogleAccessRequest subnetworksSetPrivateIpGoogleAccessRequestResource = new SubnetworksSetPrivateIpGoogleAccessRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = subnetworksClient.SetPrivateIpGoogleAccess(project, region, subnetwork, subnetworksSetPrivateIpGoogleAccessRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = subnetworksClient.PollOnceSetPrivateIpGoogleAccess(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetPrivateIpGoogleAccessAsync</summary>
        public async Task SetPrivateIpGoogleAccessAsync()
        {
            // Snippet: SetPrivateIpGoogleAccessAsync(string, string, string, SubnetworksSetPrivateIpGoogleAccessRequest, CallSettings)
            // Additional: SetPrivateIpGoogleAccessAsync(string, string, string, SubnetworksSetPrivateIpGoogleAccessRequest, CancellationToken)
            // Create client
            SubnetworksClient subnetworksClient = await SubnetworksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string subnetwork = "";
            SubnetworksSetPrivateIpGoogleAccessRequest subnetworksSetPrivateIpGoogleAccessRequestResource = new SubnetworksSetPrivateIpGoogleAccessRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = await subnetworksClient.SetPrivateIpGoogleAccessAsync(project, region, subnetwork, subnetworksSetPrivateIpGoogleAccessRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await subnetworksClient.PollOnceSetPrivateIpGoogleAccessAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissionsRequestObject()
        {
            // Snippet: TestIamPermissions(TestIamPermissionsSubnetworkRequest, CallSettings)
            // Create client
            SubnetworksClient subnetworksClient = SubnetworksClient.Create();
            // Initialize request argument(s)
            TestIamPermissionsSubnetworkRequest request = new TestIamPermissionsSubnetworkRequest
            {
                Region = "",
                Resource = "",
                Project = "",
                TestPermissionsRequestResource = new TestPermissionsRequest(),
            };
            // Make the request
            TestPermissionsResponse response = subnetworksClient.TestIamPermissions(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsRequestObjectAsync()
        {
            // Snippet: TestIamPermissionsAsync(TestIamPermissionsSubnetworkRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(TestIamPermissionsSubnetworkRequest, CancellationToken)
            // Create client
            SubnetworksClient subnetworksClient = await SubnetworksClient.CreateAsync();
            // Initialize request argument(s)
            TestIamPermissionsSubnetworkRequest request = new TestIamPermissionsSubnetworkRequest
            {
                Region = "",
                Resource = "",
                Project = "",
                TestPermissionsRequestResource = new TestPermissionsRequest(),
            };
            // Make the request
            TestPermissionsResponse response = await subnetworksClient.TestIamPermissionsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissions()
        {
            // Snippet: TestIamPermissions(string, string, string, TestPermissionsRequest, CallSettings)
            // Create client
            SubnetworksClient subnetworksClient = SubnetworksClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string resource = "";
            TestPermissionsRequest testPermissionsRequestResource = new TestPermissionsRequest();
            // Make the request
            TestPermissionsResponse response = subnetworksClient.TestIamPermissions(project, region, resource, testPermissionsRequestResource);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsAsync()
        {
            // Snippet: TestIamPermissionsAsync(string, string, string, TestPermissionsRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(string, string, string, TestPermissionsRequest, CancellationToken)
            // Create client
            SubnetworksClient subnetworksClient = await SubnetworksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string resource = "";
            TestPermissionsRequest testPermissionsRequestResource = new TestPermissionsRequest();
            // Make the request
            TestPermissionsResponse response = await subnetworksClient.TestIamPermissionsAsync(project, region, resource, testPermissionsRequestResource);
            // End snippet
        }
    }
}
