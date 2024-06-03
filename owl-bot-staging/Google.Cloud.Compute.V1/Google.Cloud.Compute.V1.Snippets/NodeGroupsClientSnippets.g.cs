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
    public sealed class AllGeneratedNodeGroupsClientSnippets
    {
        /// <summary>Snippet for AddNodes</summary>
        public void AddNodesRequestObject()
        {
            // Snippet: AddNodes(AddNodesNodeGroupRequest, CallSettings)
            // Create client
            NodeGroupsClient nodeGroupsClient = NodeGroupsClient.Create();
            // Initialize request argument(s)
            AddNodesNodeGroupRequest request = new AddNodesNodeGroupRequest
            {
                Zone = "",
                RequestId = "",
                NodeGroupsAddNodesRequestResource = new NodeGroupsAddNodesRequest(),
                Project = "",
                NodeGroup = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = nodeGroupsClient.AddNodes(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = nodeGroupsClient.PollOnceAddNodes(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AddNodesAsync</summary>
        public async Task AddNodesRequestObjectAsync()
        {
            // Snippet: AddNodesAsync(AddNodesNodeGroupRequest, CallSettings)
            // Additional: AddNodesAsync(AddNodesNodeGroupRequest, CancellationToken)
            // Create client
            NodeGroupsClient nodeGroupsClient = await NodeGroupsClient.CreateAsync();
            // Initialize request argument(s)
            AddNodesNodeGroupRequest request = new AddNodesNodeGroupRequest
            {
                Zone = "",
                RequestId = "",
                NodeGroupsAddNodesRequestResource = new NodeGroupsAddNodesRequest(),
                Project = "",
                NodeGroup = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await nodeGroupsClient.AddNodesAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await nodeGroupsClient.PollOnceAddNodesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AddNodes</summary>
        public void AddNodes()
        {
            // Snippet: AddNodes(string, string, string, NodeGroupsAddNodesRequest, CallSettings)
            // Create client
            NodeGroupsClient nodeGroupsClient = NodeGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string nodeGroup = "";
            NodeGroupsAddNodesRequest nodeGroupsAddNodesRequestResource = new NodeGroupsAddNodesRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = nodeGroupsClient.AddNodes(project, zone, nodeGroup, nodeGroupsAddNodesRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = nodeGroupsClient.PollOnceAddNodes(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AddNodesAsync</summary>
        public async Task AddNodesAsync()
        {
            // Snippet: AddNodesAsync(string, string, string, NodeGroupsAddNodesRequest, CallSettings)
            // Additional: AddNodesAsync(string, string, string, NodeGroupsAddNodesRequest, CancellationToken)
            // Create client
            NodeGroupsClient nodeGroupsClient = await NodeGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string nodeGroup = "";
            NodeGroupsAddNodesRequest nodeGroupsAddNodesRequestResource = new NodeGroupsAddNodesRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = await nodeGroupsClient.AddNodesAsync(project, zone, nodeGroup, nodeGroupsAddNodesRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await nodeGroupsClient.PollOnceAddNodesAsync(operationName);
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
            // Snippet: AggregatedList(AggregatedListNodeGroupsRequest, CallSettings)
            // Create client
            NodeGroupsClient nodeGroupsClient = NodeGroupsClient.Create();
            // Initialize request argument(s)
            AggregatedListNodeGroupsRequest request = new AggregatedListNodeGroupsRequest
            {
                OrderBy = "",
                Project = "",
                ServiceProjectNumber = 0L,
                Filter = "",
                IncludeAllScopes = false,
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<NodeGroupAggregatedList, KeyValuePair<string, NodeGroupsScopedList>> response = nodeGroupsClient.AggregatedList(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (KeyValuePair<string, NodeGroupsScopedList> item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (NodeGroupAggregatedList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, NodeGroupsScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, NodeGroupsScopedList>> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, NodeGroupsScopedList> item in singlePage)
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
            // Snippet: AggregatedListAsync(AggregatedListNodeGroupsRequest, CallSettings)
            // Create client
            NodeGroupsClient nodeGroupsClient = await NodeGroupsClient.CreateAsync();
            // Initialize request argument(s)
            AggregatedListNodeGroupsRequest request = new AggregatedListNodeGroupsRequest
            {
                OrderBy = "",
                Project = "",
                ServiceProjectNumber = 0L,
                Filter = "",
                IncludeAllScopes = false,
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<NodeGroupAggregatedList, KeyValuePair<string, NodeGroupsScopedList>> response = nodeGroupsClient.AggregatedListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((KeyValuePair<string, NodeGroupsScopedList> item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((NodeGroupAggregatedList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, NodeGroupsScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, NodeGroupsScopedList>> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, NodeGroupsScopedList> item in singlePage)
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
            NodeGroupsClient nodeGroupsClient = NodeGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedEnumerable<NodeGroupAggregatedList, KeyValuePair<string, NodeGroupsScopedList>> response = nodeGroupsClient.AggregatedList(project);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (KeyValuePair<string, NodeGroupsScopedList> item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (NodeGroupAggregatedList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, NodeGroupsScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, NodeGroupsScopedList>> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, NodeGroupsScopedList> item in singlePage)
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
            NodeGroupsClient nodeGroupsClient = await NodeGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedAsyncEnumerable<NodeGroupAggregatedList, KeyValuePair<string, NodeGroupsScopedList>> response = nodeGroupsClient.AggregatedListAsync(project);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((KeyValuePair<string, NodeGroupsScopedList> item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((NodeGroupAggregatedList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, NodeGroupsScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, NodeGroupsScopedList>> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, NodeGroupsScopedList> item in singlePage)
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
            // Snippet: Delete(DeleteNodeGroupRequest, CallSettings)
            // Create client
            NodeGroupsClient nodeGroupsClient = NodeGroupsClient.Create();
            // Initialize request argument(s)
            DeleteNodeGroupRequest request = new DeleteNodeGroupRequest
            {
                Zone = "",
                RequestId = "",
                Project = "",
                NodeGroup = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = nodeGroupsClient.Delete(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = nodeGroupsClient.PollOnceDelete(operationName);
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
            // Snippet: DeleteAsync(DeleteNodeGroupRequest, CallSettings)
            // Additional: DeleteAsync(DeleteNodeGroupRequest, CancellationToken)
            // Create client
            NodeGroupsClient nodeGroupsClient = await NodeGroupsClient.CreateAsync();
            // Initialize request argument(s)
            DeleteNodeGroupRequest request = new DeleteNodeGroupRequest
            {
                Zone = "",
                RequestId = "",
                Project = "",
                NodeGroup = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await nodeGroupsClient.DeleteAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await nodeGroupsClient.PollOnceDeleteAsync(operationName);
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
            NodeGroupsClient nodeGroupsClient = NodeGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string nodeGroup = "";
            // Make the request
            lro::Operation<Operation, Operation> response = nodeGroupsClient.Delete(project, zone, nodeGroup);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = nodeGroupsClient.PollOnceDelete(operationName);
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
            NodeGroupsClient nodeGroupsClient = await NodeGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string nodeGroup = "";
            // Make the request
            lro::Operation<Operation, Operation> response = await nodeGroupsClient.DeleteAsync(project, zone, nodeGroup);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await nodeGroupsClient.PollOnceDeleteAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteNodes</summary>
        public void DeleteNodesRequestObject()
        {
            // Snippet: DeleteNodes(DeleteNodesNodeGroupRequest, CallSettings)
            // Create client
            NodeGroupsClient nodeGroupsClient = NodeGroupsClient.Create();
            // Initialize request argument(s)
            DeleteNodesNodeGroupRequest request = new DeleteNodesNodeGroupRequest
            {
                Zone = "",
                RequestId = "",
                NodeGroupsDeleteNodesRequestResource = new NodeGroupsDeleteNodesRequest(),
                Project = "",
                NodeGroup = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = nodeGroupsClient.DeleteNodes(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = nodeGroupsClient.PollOnceDeleteNodes(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteNodesAsync</summary>
        public async Task DeleteNodesRequestObjectAsync()
        {
            // Snippet: DeleteNodesAsync(DeleteNodesNodeGroupRequest, CallSettings)
            // Additional: DeleteNodesAsync(DeleteNodesNodeGroupRequest, CancellationToken)
            // Create client
            NodeGroupsClient nodeGroupsClient = await NodeGroupsClient.CreateAsync();
            // Initialize request argument(s)
            DeleteNodesNodeGroupRequest request = new DeleteNodesNodeGroupRequest
            {
                Zone = "",
                RequestId = "",
                NodeGroupsDeleteNodesRequestResource = new NodeGroupsDeleteNodesRequest(),
                Project = "",
                NodeGroup = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await nodeGroupsClient.DeleteNodesAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await nodeGroupsClient.PollOnceDeleteNodesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteNodes</summary>
        public void DeleteNodes()
        {
            // Snippet: DeleteNodes(string, string, string, NodeGroupsDeleteNodesRequest, CallSettings)
            // Create client
            NodeGroupsClient nodeGroupsClient = NodeGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string nodeGroup = "";
            NodeGroupsDeleteNodesRequest nodeGroupsDeleteNodesRequestResource = new NodeGroupsDeleteNodesRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = nodeGroupsClient.DeleteNodes(project, zone, nodeGroup, nodeGroupsDeleteNodesRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = nodeGroupsClient.PollOnceDeleteNodes(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteNodesAsync</summary>
        public async Task DeleteNodesAsync()
        {
            // Snippet: DeleteNodesAsync(string, string, string, NodeGroupsDeleteNodesRequest, CallSettings)
            // Additional: DeleteNodesAsync(string, string, string, NodeGroupsDeleteNodesRequest, CancellationToken)
            // Create client
            NodeGroupsClient nodeGroupsClient = await NodeGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string nodeGroup = "";
            NodeGroupsDeleteNodesRequest nodeGroupsDeleteNodesRequestResource = new NodeGroupsDeleteNodesRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = await nodeGroupsClient.DeleteNodesAsync(project, zone, nodeGroup, nodeGroupsDeleteNodesRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await nodeGroupsClient.PollOnceDeleteNodesAsync(operationName);
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
            // Snippet: Get(GetNodeGroupRequest, CallSettings)
            // Create client
            NodeGroupsClient nodeGroupsClient = NodeGroupsClient.Create();
            // Initialize request argument(s)
            GetNodeGroupRequest request = new GetNodeGroupRequest
            {
                Zone = "",
                Project = "",
                NodeGroup = "",
            };
            // Make the request
            NodeGroup response = nodeGroupsClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetNodeGroupRequest, CallSettings)
            // Additional: GetAsync(GetNodeGroupRequest, CancellationToken)
            // Create client
            NodeGroupsClient nodeGroupsClient = await NodeGroupsClient.CreateAsync();
            // Initialize request argument(s)
            GetNodeGroupRequest request = new GetNodeGroupRequest
            {
                Zone = "",
                Project = "",
                NodeGroup = "",
            };
            // Make the request
            NodeGroup response = await nodeGroupsClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, string, CallSettings)
            // Create client
            NodeGroupsClient nodeGroupsClient = NodeGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string nodeGroup = "";
            // Make the request
            NodeGroup response = nodeGroupsClient.Get(project, zone, nodeGroup);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, string, CallSettings)
            // Additional: GetAsync(string, string, string, CancellationToken)
            // Create client
            NodeGroupsClient nodeGroupsClient = await NodeGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string nodeGroup = "";
            // Make the request
            NodeGroup response = await nodeGroupsClient.GetAsync(project, zone, nodeGroup);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicyRequestObject()
        {
            // Snippet: GetIamPolicy(GetIamPolicyNodeGroupRequest, CallSettings)
            // Create client
            NodeGroupsClient nodeGroupsClient = NodeGroupsClient.Create();
            // Initialize request argument(s)
            GetIamPolicyNodeGroupRequest request = new GetIamPolicyNodeGroupRequest
            {
                Zone = "",
                Resource = "",
                Project = "",
                OptionsRequestedPolicyVersion = 0,
            };
            // Make the request
            Policy response = nodeGroupsClient.GetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyRequestObjectAsync()
        {
            // Snippet: GetIamPolicyAsync(GetIamPolicyNodeGroupRequest, CallSettings)
            // Additional: GetIamPolicyAsync(GetIamPolicyNodeGroupRequest, CancellationToken)
            // Create client
            NodeGroupsClient nodeGroupsClient = await NodeGroupsClient.CreateAsync();
            // Initialize request argument(s)
            GetIamPolicyNodeGroupRequest request = new GetIamPolicyNodeGroupRequest
            {
                Zone = "",
                Resource = "",
                Project = "",
                OptionsRequestedPolicyVersion = 0,
            };
            // Make the request
            Policy response = await nodeGroupsClient.GetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicy()
        {
            // Snippet: GetIamPolicy(string, string, string, CallSettings)
            // Create client
            NodeGroupsClient nodeGroupsClient = NodeGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string resource = "";
            // Make the request
            Policy response = nodeGroupsClient.GetIamPolicy(project, zone, resource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyAsync()
        {
            // Snippet: GetIamPolicyAsync(string, string, string, CallSettings)
            // Additional: GetIamPolicyAsync(string, string, string, CancellationToken)
            // Create client
            NodeGroupsClient nodeGroupsClient = await NodeGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string resource = "";
            // Make the request
            Policy response = await nodeGroupsClient.GetIamPolicyAsync(project, zone, resource);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void InsertRequestObject()
        {
            // Snippet: Insert(InsertNodeGroupRequest, CallSettings)
            // Create client
            NodeGroupsClient nodeGroupsClient = NodeGroupsClient.Create();
            // Initialize request argument(s)
            InsertNodeGroupRequest request = new InsertNodeGroupRequest
            {
                Zone = "",
                RequestId = "",
                InitialNodeCount = 0,
                Project = "",
                NodeGroupResource = new NodeGroup(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = nodeGroupsClient.Insert(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = nodeGroupsClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(InsertNodeGroupRequest, CallSettings)
            // Additional: InsertAsync(InsertNodeGroupRequest, CancellationToken)
            // Create client
            NodeGroupsClient nodeGroupsClient = await NodeGroupsClient.CreateAsync();
            // Initialize request argument(s)
            InsertNodeGroupRequest request = new InsertNodeGroupRequest
            {
                Zone = "",
                RequestId = "",
                InitialNodeCount = 0,
                Project = "",
                NodeGroupResource = new NodeGroup(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await nodeGroupsClient.InsertAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await nodeGroupsClient.PollOnceInsertAsync(operationName);
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
            // Snippet: Insert(string, string, int, NodeGroup, CallSettings)
            // Create client
            NodeGroupsClient nodeGroupsClient = NodeGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            int initialNodeCount = 0;
            NodeGroup nodeGroupResource = new NodeGroup();
            // Make the request
            lro::Operation<Operation, Operation> response = nodeGroupsClient.Insert(project, zone, initialNodeCount, nodeGroupResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = nodeGroupsClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(string, string, int, NodeGroup, CallSettings)
            // Additional: InsertAsync(string, string, int, NodeGroup, CancellationToken)
            // Create client
            NodeGroupsClient nodeGroupsClient = await NodeGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            int initialNodeCount = 0;
            NodeGroup nodeGroupResource = new NodeGroup();
            // Make the request
            lro::Operation<Operation, Operation> response = await nodeGroupsClient.InsertAsync(project, zone, initialNodeCount, nodeGroupResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await nodeGroupsClient.PollOnceInsertAsync(operationName);
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
            // Snippet: List(ListNodeGroupsRequest, CallSettings)
            // Create client
            NodeGroupsClient nodeGroupsClient = NodeGroupsClient.Create();
            // Initialize request argument(s)
            ListNodeGroupsRequest request = new ListNodeGroupsRequest
            {
                Zone = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<NodeGroupList, NodeGroup> response = nodeGroupsClient.List(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (NodeGroup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (NodeGroupList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NodeGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NodeGroup> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NodeGroup item in singlePage)
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
            // Snippet: ListAsync(ListNodeGroupsRequest, CallSettings)
            // Create client
            NodeGroupsClient nodeGroupsClient = await NodeGroupsClient.CreateAsync();
            // Initialize request argument(s)
            ListNodeGroupsRequest request = new ListNodeGroupsRequest
            {
                Zone = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<NodeGroupList, NodeGroup> response = nodeGroupsClient.ListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((NodeGroup item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((NodeGroupList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NodeGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NodeGroup> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NodeGroup item in singlePage)
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
            NodeGroupsClient nodeGroupsClient = NodeGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            // Make the request
            PagedEnumerable<NodeGroupList, NodeGroup> response = nodeGroupsClient.List(project, zone);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (NodeGroup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (NodeGroupList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NodeGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NodeGroup> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NodeGroup item in singlePage)
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
            NodeGroupsClient nodeGroupsClient = await NodeGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            // Make the request
            PagedAsyncEnumerable<NodeGroupList, NodeGroup> response = nodeGroupsClient.ListAsync(project, zone);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((NodeGroup item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((NodeGroupList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NodeGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NodeGroup> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NodeGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNodes</summary>
        public void ListNodesRequestObject()
        {
            // Snippet: ListNodes(ListNodesNodeGroupsRequest, CallSettings)
            // Create client
            NodeGroupsClient nodeGroupsClient = NodeGroupsClient.Create();
            // Initialize request argument(s)
            ListNodesNodeGroupsRequest request = new ListNodesNodeGroupsRequest
            {
                Zone = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                NodeGroup = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<NodeGroupsListNodes, NodeGroupNode> response = nodeGroupsClient.ListNodes(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (NodeGroupNode item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (NodeGroupsListNodes page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NodeGroupNode item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NodeGroupNode> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NodeGroupNode item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNodesAsync</summary>
        public async Task ListNodesRequestObjectAsync()
        {
            // Snippet: ListNodesAsync(ListNodesNodeGroupsRequest, CallSettings)
            // Create client
            NodeGroupsClient nodeGroupsClient = await NodeGroupsClient.CreateAsync();
            // Initialize request argument(s)
            ListNodesNodeGroupsRequest request = new ListNodesNodeGroupsRequest
            {
                Zone = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                NodeGroup = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<NodeGroupsListNodes, NodeGroupNode> response = nodeGroupsClient.ListNodesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((NodeGroupNode item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((NodeGroupsListNodes page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NodeGroupNode item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NodeGroupNode> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NodeGroupNode item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNodes</summary>
        public void ListNodes()
        {
            // Snippet: ListNodes(string, string, string, string, int?, CallSettings)
            // Create client
            NodeGroupsClient nodeGroupsClient = NodeGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string nodeGroup = "";
            // Make the request
            PagedEnumerable<NodeGroupsListNodes, NodeGroupNode> response = nodeGroupsClient.ListNodes(project, zone, nodeGroup);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (NodeGroupNode item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (NodeGroupsListNodes page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NodeGroupNode item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NodeGroupNode> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NodeGroupNode item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNodesAsync</summary>
        public async Task ListNodesAsync()
        {
            // Snippet: ListNodesAsync(string, string, string, string, int?, CallSettings)
            // Create client
            NodeGroupsClient nodeGroupsClient = await NodeGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string nodeGroup = "";
            // Make the request
            PagedAsyncEnumerable<NodeGroupsListNodes, NodeGroupNode> response = nodeGroupsClient.ListNodesAsync(project, zone, nodeGroup);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((NodeGroupNode item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((NodeGroupsListNodes page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NodeGroupNode item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NodeGroupNode> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NodeGroupNode item in singlePage)
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
            // Snippet: Patch(PatchNodeGroupRequest, CallSettings)
            // Create client
            NodeGroupsClient nodeGroupsClient = NodeGroupsClient.Create();
            // Initialize request argument(s)
            PatchNodeGroupRequest request = new PatchNodeGroupRequest
            {
                Zone = "",
                RequestId = "",
                Project = "",
                NodeGroup = "",
                NodeGroupResource = new NodeGroup(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = nodeGroupsClient.Patch(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = nodeGroupsClient.PollOncePatch(operationName);
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
            // Snippet: PatchAsync(PatchNodeGroupRequest, CallSettings)
            // Additional: PatchAsync(PatchNodeGroupRequest, CancellationToken)
            // Create client
            NodeGroupsClient nodeGroupsClient = await NodeGroupsClient.CreateAsync();
            // Initialize request argument(s)
            PatchNodeGroupRequest request = new PatchNodeGroupRequest
            {
                Zone = "",
                RequestId = "",
                Project = "",
                NodeGroup = "",
                NodeGroupResource = new NodeGroup(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await nodeGroupsClient.PatchAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await nodeGroupsClient.PollOncePatchAsync(operationName);
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
            // Snippet: Patch(string, string, string, NodeGroup, CallSettings)
            // Create client
            NodeGroupsClient nodeGroupsClient = NodeGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string nodeGroup = "";
            NodeGroup nodeGroupResource = new NodeGroup();
            // Make the request
            lro::Operation<Operation, Operation> response = nodeGroupsClient.Patch(project, zone, nodeGroup, nodeGroupResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = nodeGroupsClient.PollOncePatch(operationName);
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
            // Snippet: PatchAsync(string, string, string, NodeGroup, CallSettings)
            // Additional: PatchAsync(string, string, string, NodeGroup, CancellationToken)
            // Create client
            NodeGroupsClient nodeGroupsClient = await NodeGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string nodeGroup = "";
            NodeGroup nodeGroupResource = new NodeGroup();
            // Make the request
            lro::Operation<Operation, Operation> response = await nodeGroupsClient.PatchAsync(project, zone, nodeGroup, nodeGroupResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await nodeGroupsClient.PollOncePatchAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PerformMaintenance</summary>
        public void PerformMaintenanceRequestObject()
        {
            // Snippet: PerformMaintenance(PerformMaintenanceNodeGroupRequest, CallSettings)
            // Create client
            NodeGroupsClient nodeGroupsClient = NodeGroupsClient.Create();
            // Initialize request argument(s)
            PerformMaintenanceNodeGroupRequest request = new PerformMaintenanceNodeGroupRequest
            {
                Zone = "",
                RequestId = "",
                NodeGroupsPerformMaintenanceRequestResource = new NodeGroupsPerformMaintenanceRequest(),
                Project = "",
                NodeGroup = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = nodeGroupsClient.PerformMaintenance(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = nodeGroupsClient.PollOncePerformMaintenance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PerformMaintenanceAsync</summary>
        public async Task PerformMaintenanceRequestObjectAsync()
        {
            // Snippet: PerformMaintenanceAsync(PerformMaintenanceNodeGroupRequest, CallSettings)
            // Additional: PerformMaintenanceAsync(PerformMaintenanceNodeGroupRequest, CancellationToken)
            // Create client
            NodeGroupsClient nodeGroupsClient = await NodeGroupsClient.CreateAsync();
            // Initialize request argument(s)
            PerformMaintenanceNodeGroupRequest request = new PerformMaintenanceNodeGroupRequest
            {
                Zone = "",
                RequestId = "",
                NodeGroupsPerformMaintenanceRequestResource = new NodeGroupsPerformMaintenanceRequest(),
                Project = "",
                NodeGroup = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await nodeGroupsClient.PerformMaintenanceAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await nodeGroupsClient.PollOncePerformMaintenanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PerformMaintenance</summary>
        public void PerformMaintenance()
        {
            // Snippet: PerformMaintenance(string, string, string, NodeGroupsPerformMaintenanceRequest, CallSettings)
            // Create client
            NodeGroupsClient nodeGroupsClient = NodeGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string nodeGroup = "";
            NodeGroupsPerformMaintenanceRequest nodeGroupsPerformMaintenanceRequestResource = new NodeGroupsPerformMaintenanceRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = nodeGroupsClient.PerformMaintenance(project, zone, nodeGroup, nodeGroupsPerformMaintenanceRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = nodeGroupsClient.PollOncePerformMaintenance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PerformMaintenanceAsync</summary>
        public async Task PerformMaintenanceAsync()
        {
            // Snippet: PerformMaintenanceAsync(string, string, string, NodeGroupsPerformMaintenanceRequest, CallSettings)
            // Additional: PerformMaintenanceAsync(string, string, string, NodeGroupsPerformMaintenanceRequest, CancellationToken)
            // Create client
            NodeGroupsClient nodeGroupsClient = await NodeGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string nodeGroup = "";
            NodeGroupsPerformMaintenanceRequest nodeGroupsPerformMaintenanceRequestResource = new NodeGroupsPerformMaintenanceRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = await nodeGroupsClient.PerformMaintenanceAsync(project, zone, nodeGroup, nodeGroupsPerformMaintenanceRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await nodeGroupsClient.PollOncePerformMaintenanceAsync(operationName);
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
            // Snippet: SetIamPolicy(SetIamPolicyNodeGroupRequest, CallSettings)
            // Create client
            NodeGroupsClient nodeGroupsClient = NodeGroupsClient.Create();
            // Initialize request argument(s)
            SetIamPolicyNodeGroupRequest request = new SetIamPolicyNodeGroupRequest
            {
                Zone = "",
                Resource = "",
                Project = "",
                ZoneSetPolicyRequestResource = new ZoneSetPolicyRequest(),
            };
            // Make the request
            Policy response = nodeGroupsClient.SetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyRequestObjectAsync()
        {
            // Snippet: SetIamPolicyAsync(SetIamPolicyNodeGroupRequest, CallSettings)
            // Additional: SetIamPolicyAsync(SetIamPolicyNodeGroupRequest, CancellationToken)
            // Create client
            NodeGroupsClient nodeGroupsClient = await NodeGroupsClient.CreateAsync();
            // Initialize request argument(s)
            SetIamPolicyNodeGroupRequest request = new SetIamPolicyNodeGroupRequest
            {
                Zone = "",
                Resource = "",
                Project = "",
                ZoneSetPolicyRequestResource = new ZoneSetPolicyRequest(),
            };
            // Make the request
            Policy response = await nodeGroupsClient.SetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicy()
        {
            // Snippet: SetIamPolicy(string, string, string, ZoneSetPolicyRequest, CallSettings)
            // Create client
            NodeGroupsClient nodeGroupsClient = NodeGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string resource = "";
            ZoneSetPolicyRequest zoneSetPolicyRequestResource = new ZoneSetPolicyRequest();
            // Make the request
            Policy response = nodeGroupsClient.SetIamPolicy(project, zone, resource, zoneSetPolicyRequestResource);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyAsync()
        {
            // Snippet: SetIamPolicyAsync(string, string, string, ZoneSetPolicyRequest, CallSettings)
            // Additional: SetIamPolicyAsync(string, string, string, ZoneSetPolicyRequest, CancellationToken)
            // Create client
            NodeGroupsClient nodeGroupsClient = await NodeGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string resource = "";
            ZoneSetPolicyRequest zoneSetPolicyRequestResource = new ZoneSetPolicyRequest();
            // Make the request
            Policy response = await nodeGroupsClient.SetIamPolicyAsync(project, zone, resource, zoneSetPolicyRequestResource);
            // End snippet
        }

        /// <summary>Snippet for SetNodeTemplate</summary>
        public void SetNodeTemplateRequestObject()
        {
            // Snippet: SetNodeTemplate(SetNodeTemplateNodeGroupRequest, CallSettings)
            // Create client
            NodeGroupsClient nodeGroupsClient = NodeGroupsClient.Create();
            // Initialize request argument(s)
            SetNodeTemplateNodeGroupRequest request = new SetNodeTemplateNodeGroupRequest
            {
                Zone = "",
                RequestId = "",
                NodeGroupsSetNodeTemplateRequestResource = new NodeGroupsSetNodeTemplateRequest(),
                Project = "",
                NodeGroup = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = nodeGroupsClient.SetNodeTemplate(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = nodeGroupsClient.PollOnceSetNodeTemplate(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetNodeTemplateAsync</summary>
        public async Task SetNodeTemplateRequestObjectAsync()
        {
            // Snippet: SetNodeTemplateAsync(SetNodeTemplateNodeGroupRequest, CallSettings)
            // Additional: SetNodeTemplateAsync(SetNodeTemplateNodeGroupRequest, CancellationToken)
            // Create client
            NodeGroupsClient nodeGroupsClient = await NodeGroupsClient.CreateAsync();
            // Initialize request argument(s)
            SetNodeTemplateNodeGroupRequest request = new SetNodeTemplateNodeGroupRequest
            {
                Zone = "",
                RequestId = "",
                NodeGroupsSetNodeTemplateRequestResource = new NodeGroupsSetNodeTemplateRequest(),
                Project = "",
                NodeGroup = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await nodeGroupsClient.SetNodeTemplateAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await nodeGroupsClient.PollOnceSetNodeTemplateAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetNodeTemplate</summary>
        public void SetNodeTemplate()
        {
            // Snippet: SetNodeTemplate(string, string, string, NodeGroupsSetNodeTemplateRequest, CallSettings)
            // Create client
            NodeGroupsClient nodeGroupsClient = NodeGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string nodeGroup = "";
            NodeGroupsSetNodeTemplateRequest nodeGroupsSetNodeTemplateRequestResource = new NodeGroupsSetNodeTemplateRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = nodeGroupsClient.SetNodeTemplate(project, zone, nodeGroup, nodeGroupsSetNodeTemplateRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = nodeGroupsClient.PollOnceSetNodeTemplate(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetNodeTemplateAsync</summary>
        public async Task SetNodeTemplateAsync()
        {
            // Snippet: SetNodeTemplateAsync(string, string, string, NodeGroupsSetNodeTemplateRequest, CallSettings)
            // Additional: SetNodeTemplateAsync(string, string, string, NodeGroupsSetNodeTemplateRequest, CancellationToken)
            // Create client
            NodeGroupsClient nodeGroupsClient = await NodeGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string nodeGroup = "";
            NodeGroupsSetNodeTemplateRequest nodeGroupsSetNodeTemplateRequestResource = new NodeGroupsSetNodeTemplateRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = await nodeGroupsClient.SetNodeTemplateAsync(project, zone, nodeGroup, nodeGroupsSetNodeTemplateRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await nodeGroupsClient.PollOnceSetNodeTemplateAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SimulateMaintenanceEvent</summary>
        public void SimulateMaintenanceEventRequestObject()
        {
            // Snippet: SimulateMaintenanceEvent(SimulateMaintenanceEventNodeGroupRequest, CallSettings)
            // Create client
            NodeGroupsClient nodeGroupsClient = NodeGroupsClient.Create();
            // Initialize request argument(s)
            SimulateMaintenanceEventNodeGroupRequest request = new SimulateMaintenanceEventNodeGroupRequest
            {
                Zone = "",
                RequestId = "",
                Project = "",
                NodeGroupsSimulateMaintenanceEventRequestResource = new NodeGroupsSimulateMaintenanceEventRequest(),
                NodeGroup = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = nodeGroupsClient.SimulateMaintenanceEvent(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = nodeGroupsClient.PollOnceSimulateMaintenanceEvent(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SimulateMaintenanceEventAsync</summary>
        public async Task SimulateMaintenanceEventRequestObjectAsync()
        {
            // Snippet: SimulateMaintenanceEventAsync(SimulateMaintenanceEventNodeGroupRequest, CallSettings)
            // Additional: SimulateMaintenanceEventAsync(SimulateMaintenanceEventNodeGroupRequest, CancellationToken)
            // Create client
            NodeGroupsClient nodeGroupsClient = await NodeGroupsClient.CreateAsync();
            // Initialize request argument(s)
            SimulateMaintenanceEventNodeGroupRequest request = new SimulateMaintenanceEventNodeGroupRequest
            {
                Zone = "",
                RequestId = "",
                Project = "",
                NodeGroupsSimulateMaintenanceEventRequestResource = new NodeGroupsSimulateMaintenanceEventRequest(),
                NodeGroup = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await nodeGroupsClient.SimulateMaintenanceEventAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await nodeGroupsClient.PollOnceSimulateMaintenanceEventAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SimulateMaintenanceEvent</summary>
        public void SimulateMaintenanceEvent()
        {
            // Snippet: SimulateMaintenanceEvent(string, string, string, NodeGroupsSimulateMaintenanceEventRequest, CallSettings)
            // Create client
            NodeGroupsClient nodeGroupsClient = NodeGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string nodeGroup = "";
            NodeGroupsSimulateMaintenanceEventRequest nodeGroupsSimulateMaintenanceEventRequestResource = new NodeGroupsSimulateMaintenanceEventRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = nodeGroupsClient.SimulateMaintenanceEvent(project, zone, nodeGroup, nodeGroupsSimulateMaintenanceEventRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = nodeGroupsClient.PollOnceSimulateMaintenanceEvent(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SimulateMaintenanceEventAsync</summary>
        public async Task SimulateMaintenanceEventAsync()
        {
            // Snippet: SimulateMaintenanceEventAsync(string, string, string, NodeGroupsSimulateMaintenanceEventRequest, CallSettings)
            // Additional: SimulateMaintenanceEventAsync(string, string, string, NodeGroupsSimulateMaintenanceEventRequest, CancellationToken)
            // Create client
            NodeGroupsClient nodeGroupsClient = await NodeGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string nodeGroup = "";
            NodeGroupsSimulateMaintenanceEventRequest nodeGroupsSimulateMaintenanceEventRequestResource = new NodeGroupsSimulateMaintenanceEventRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = await nodeGroupsClient.SimulateMaintenanceEventAsync(project, zone, nodeGroup, nodeGroupsSimulateMaintenanceEventRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await nodeGroupsClient.PollOnceSimulateMaintenanceEventAsync(operationName);
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
            // Snippet: TestIamPermissions(TestIamPermissionsNodeGroupRequest, CallSettings)
            // Create client
            NodeGroupsClient nodeGroupsClient = NodeGroupsClient.Create();
            // Initialize request argument(s)
            TestIamPermissionsNodeGroupRequest request = new TestIamPermissionsNodeGroupRequest
            {
                Zone = "",
                Resource = "",
                Project = "",
                TestPermissionsRequestResource = new TestPermissionsRequest(),
            };
            // Make the request
            TestPermissionsResponse response = nodeGroupsClient.TestIamPermissions(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsRequestObjectAsync()
        {
            // Snippet: TestIamPermissionsAsync(TestIamPermissionsNodeGroupRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(TestIamPermissionsNodeGroupRequest, CancellationToken)
            // Create client
            NodeGroupsClient nodeGroupsClient = await NodeGroupsClient.CreateAsync();
            // Initialize request argument(s)
            TestIamPermissionsNodeGroupRequest request = new TestIamPermissionsNodeGroupRequest
            {
                Zone = "",
                Resource = "",
                Project = "",
                TestPermissionsRequestResource = new TestPermissionsRequest(),
            };
            // Make the request
            TestPermissionsResponse response = await nodeGroupsClient.TestIamPermissionsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissions()
        {
            // Snippet: TestIamPermissions(string, string, string, TestPermissionsRequest, CallSettings)
            // Create client
            NodeGroupsClient nodeGroupsClient = NodeGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string resource = "";
            TestPermissionsRequest testPermissionsRequestResource = new TestPermissionsRequest();
            // Make the request
            TestPermissionsResponse response = nodeGroupsClient.TestIamPermissions(project, zone, resource, testPermissionsRequestResource);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsAsync()
        {
            // Snippet: TestIamPermissionsAsync(string, string, string, TestPermissionsRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(string, string, string, TestPermissionsRequest, CancellationToken)
            // Create client
            NodeGroupsClient nodeGroupsClient = await NodeGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string resource = "";
            TestPermissionsRequest testPermissionsRequestResource = new TestPermissionsRequest();
            // Make the request
            TestPermissionsResponse response = await nodeGroupsClient.TestIamPermissionsAsync(project, zone, resource, testPermissionsRequestResource);
            // End snippet
        }
    }
}
