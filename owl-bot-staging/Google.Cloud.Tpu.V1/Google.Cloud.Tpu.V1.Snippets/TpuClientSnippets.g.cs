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
    using Google.Cloud.Tpu.V1;
    using Google.LongRunning;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedTpuClientSnippets
    {
        /// <summary>Snippet for ListNodes</summary>
        public void ListNodesRequestObject()
        {
            // Snippet: ListNodes(ListNodesRequest, CallSettings)
            // Create client
            TpuClient tpuClient = TpuClient.Create();
            // Initialize request argument(s)
            ListNodesRequest request = new ListNodesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedEnumerable<ListNodesResponse, Node> response = tpuClient.ListNodes(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Node item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListNodesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Node item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Node> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Node item in singlePage)
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
            // Snippet: ListNodesAsync(ListNodesRequest, CallSettings)
            // Create client
            TpuClient tpuClient = await TpuClient.CreateAsync();
            // Initialize request argument(s)
            ListNodesRequest request = new ListNodesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListNodesResponse, Node> response = tpuClient.ListNodesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Node item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListNodesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Node item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Node> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Node item in singlePage)
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
            // Snippet: ListNodes(string, string, int?, CallSettings)
            // Create client
            TpuClient tpuClient = TpuClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListNodesResponse, Node> response = tpuClient.ListNodes(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Node item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListNodesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Node item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Node> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Node item in singlePage)
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
            // Snippet: ListNodesAsync(string, string, int?, CallSettings)
            // Create client
            TpuClient tpuClient = await TpuClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListNodesResponse, Node> response = tpuClient.ListNodesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Node item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListNodesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Node item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Node> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Node item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNodes</summary>
        public void ListNodesResourceNames()
        {
            // Snippet: ListNodes(LocationName, string, int?, CallSettings)
            // Create client
            TpuClient tpuClient = TpuClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListNodesResponse, Node> response = tpuClient.ListNodes(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Node item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListNodesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Node item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Node> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Node item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNodesAsync</summary>
        public async Task ListNodesResourceNamesAsync()
        {
            // Snippet: ListNodesAsync(LocationName, string, int?, CallSettings)
            // Create client
            TpuClient tpuClient = await TpuClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListNodesResponse, Node> response = tpuClient.ListNodesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Node item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListNodesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Node item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Node> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Node item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetNode</summary>
        public void GetNodeRequestObject()
        {
            // Snippet: GetNode(GetNodeRequest, CallSettings)
            // Create client
            TpuClient tpuClient = TpuClient.Create();
            // Initialize request argument(s)
            GetNodeRequest request = new GetNodeRequest
            {
                NodeName = NodeName.FromProjectLocationNode("[PROJECT]", "[LOCATION]", "[NODE]"),
            };
            // Make the request
            Node response = tpuClient.GetNode(request);
            // End snippet
        }

        /// <summary>Snippet for GetNodeAsync</summary>
        public async Task GetNodeRequestObjectAsync()
        {
            // Snippet: GetNodeAsync(GetNodeRequest, CallSettings)
            // Additional: GetNodeAsync(GetNodeRequest, CancellationToken)
            // Create client
            TpuClient tpuClient = await TpuClient.CreateAsync();
            // Initialize request argument(s)
            GetNodeRequest request = new GetNodeRequest
            {
                NodeName = NodeName.FromProjectLocationNode("[PROJECT]", "[LOCATION]", "[NODE]"),
            };
            // Make the request
            Node response = await tpuClient.GetNodeAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetNode</summary>
        public void GetNode()
        {
            // Snippet: GetNode(string, CallSettings)
            // Create client
            TpuClient tpuClient = TpuClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/nodes/[NODE]";
            // Make the request
            Node response = tpuClient.GetNode(name);
            // End snippet
        }

        /// <summary>Snippet for GetNodeAsync</summary>
        public async Task GetNodeAsync()
        {
            // Snippet: GetNodeAsync(string, CallSettings)
            // Additional: GetNodeAsync(string, CancellationToken)
            // Create client
            TpuClient tpuClient = await TpuClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/nodes/[NODE]";
            // Make the request
            Node response = await tpuClient.GetNodeAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetNode</summary>
        public void GetNodeResourceNames()
        {
            // Snippet: GetNode(NodeName, CallSettings)
            // Create client
            TpuClient tpuClient = TpuClient.Create();
            // Initialize request argument(s)
            NodeName name = NodeName.FromProjectLocationNode("[PROJECT]", "[LOCATION]", "[NODE]");
            // Make the request
            Node response = tpuClient.GetNode(name);
            // End snippet
        }

        /// <summary>Snippet for GetNodeAsync</summary>
        public async Task GetNodeResourceNamesAsync()
        {
            // Snippet: GetNodeAsync(NodeName, CallSettings)
            // Additional: GetNodeAsync(NodeName, CancellationToken)
            // Create client
            TpuClient tpuClient = await TpuClient.CreateAsync();
            // Initialize request argument(s)
            NodeName name = NodeName.FromProjectLocationNode("[PROJECT]", "[LOCATION]", "[NODE]");
            // Make the request
            Node response = await tpuClient.GetNodeAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateNode</summary>
        public void CreateNodeRequestObject()
        {
            // Snippet: CreateNode(CreateNodeRequest, CallSettings)
            // Create client
            TpuClient tpuClient = TpuClient.Create();
            // Initialize request argument(s)
            CreateNodeRequest request = new CreateNodeRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                NodeId = "",
                Node = new Node(),
            };
            // Make the request
            Operation<Node, OperationMetadata> response = tpuClient.CreateNode(request);

            // Poll until the returned long-running operation is complete
            Operation<Node, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Node result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Node, OperationMetadata> retrievedResponse = tpuClient.PollOnceCreateNode(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Node retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateNodeAsync</summary>
        public async Task CreateNodeRequestObjectAsync()
        {
            // Snippet: CreateNodeAsync(CreateNodeRequest, CallSettings)
            // Additional: CreateNodeAsync(CreateNodeRequest, CancellationToken)
            // Create client
            TpuClient tpuClient = await TpuClient.CreateAsync();
            // Initialize request argument(s)
            CreateNodeRequest request = new CreateNodeRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                NodeId = "",
                Node = new Node(),
            };
            // Make the request
            Operation<Node, OperationMetadata> response = await tpuClient.CreateNodeAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Node, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Node result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Node, OperationMetadata> retrievedResponse = await tpuClient.PollOnceCreateNodeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Node retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateNode</summary>
        public void CreateNode()
        {
            // Snippet: CreateNode(string, Node, string, CallSettings)
            // Create client
            TpuClient tpuClient = TpuClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Node node = new Node();
            string nodeId = "";
            // Make the request
            Operation<Node, OperationMetadata> response = tpuClient.CreateNode(parent, node, nodeId);

            // Poll until the returned long-running operation is complete
            Operation<Node, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Node result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Node, OperationMetadata> retrievedResponse = tpuClient.PollOnceCreateNode(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Node retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateNodeAsync</summary>
        public async Task CreateNodeAsync()
        {
            // Snippet: CreateNodeAsync(string, Node, string, CallSettings)
            // Additional: CreateNodeAsync(string, Node, string, CancellationToken)
            // Create client
            TpuClient tpuClient = await TpuClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Node node = new Node();
            string nodeId = "";
            // Make the request
            Operation<Node, OperationMetadata> response = await tpuClient.CreateNodeAsync(parent, node, nodeId);

            // Poll until the returned long-running operation is complete
            Operation<Node, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Node result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Node, OperationMetadata> retrievedResponse = await tpuClient.PollOnceCreateNodeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Node retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateNode</summary>
        public void CreateNodeResourceNames()
        {
            // Snippet: CreateNode(LocationName, Node, string, CallSettings)
            // Create client
            TpuClient tpuClient = TpuClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Node node = new Node();
            string nodeId = "";
            // Make the request
            Operation<Node, OperationMetadata> response = tpuClient.CreateNode(parent, node, nodeId);

            // Poll until the returned long-running operation is complete
            Operation<Node, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Node result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Node, OperationMetadata> retrievedResponse = tpuClient.PollOnceCreateNode(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Node retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateNodeAsync</summary>
        public async Task CreateNodeResourceNamesAsync()
        {
            // Snippet: CreateNodeAsync(LocationName, Node, string, CallSettings)
            // Additional: CreateNodeAsync(LocationName, Node, string, CancellationToken)
            // Create client
            TpuClient tpuClient = await TpuClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Node node = new Node();
            string nodeId = "";
            // Make the request
            Operation<Node, OperationMetadata> response = await tpuClient.CreateNodeAsync(parent, node, nodeId);

            // Poll until the returned long-running operation is complete
            Operation<Node, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Node result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Node, OperationMetadata> retrievedResponse = await tpuClient.PollOnceCreateNodeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Node retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteNode</summary>
        public void DeleteNodeRequestObject()
        {
            // Snippet: DeleteNode(DeleteNodeRequest, CallSettings)
            // Create client
            TpuClient tpuClient = TpuClient.Create();
            // Initialize request argument(s)
            DeleteNodeRequest request = new DeleteNodeRequest
            {
                NodeName = NodeName.FromProjectLocationNode("[PROJECT]", "[LOCATION]", "[NODE]"),
            };
            // Make the request
            Operation<Node, OperationMetadata> response = tpuClient.DeleteNode(request);

            // Poll until the returned long-running operation is complete
            Operation<Node, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Node result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Node, OperationMetadata> retrievedResponse = tpuClient.PollOnceDeleteNode(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Node retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteNodeAsync</summary>
        public async Task DeleteNodeRequestObjectAsync()
        {
            // Snippet: DeleteNodeAsync(DeleteNodeRequest, CallSettings)
            // Additional: DeleteNodeAsync(DeleteNodeRequest, CancellationToken)
            // Create client
            TpuClient tpuClient = await TpuClient.CreateAsync();
            // Initialize request argument(s)
            DeleteNodeRequest request = new DeleteNodeRequest
            {
                NodeName = NodeName.FromProjectLocationNode("[PROJECT]", "[LOCATION]", "[NODE]"),
            };
            // Make the request
            Operation<Node, OperationMetadata> response = await tpuClient.DeleteNodeAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Node, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Node result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Node, OperationMetadata> retrievedResponse = await tpuClient.PollOnceDeleteNodeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Node retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteNode</summary>
        public void DeleteNode()
        {
            // Snippet: DeleteNode(string, CallSettings)
            // Create client
            TpuClient tpuClient = TpuClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/nodes/[NODE]";
            // Make the request
            Operation<Node, OperationMetadata> response = tpuClient.DeleteNode(name);

            // Poll until the returned long-running operation is complete
            Operation<Node, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Node result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Node, OperationMetadata> retrievedResponse = tpuClient.PollOnceDeleteNode(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Node retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteNodeAsync</summary>
        public async Task DeleteNodeAsync()
        {
            // Snippet: DeleteNodeAsync(string, CallSettings)
            // Additional: DeleteNodeAsync(string, CancellationToken)
            // Create client
            TpuClient tpuClient = await TpuClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/nodes/[NODE]";
            // Make the request
            Operation<Node, OperationMetadata> response = await tpuClient.DeleteNodeAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Node, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Node result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Node, OperationMetadata> retrievedResponse = await tpuClient.PollOnceDeleteNodeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Node retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteNode</summary>
        public void DeleteNodeResourceNames()
        {
            // Snippet: DeleteNode(NodeName, CallSettings)
            // Create client
            TpuClient tpuClient = TpuClient.Create();
            // Initialize request argument(s)
            NodeName name = NodeName.FromProjectLocationNode("[PROJECT]", "[LOCATION]", "[NODE]");
            // Make the request
            Operation<Node, OperationMetadata> response = tpuClient.DeleteNode(name);

            // Poll until the returned long-running operation is complete
            Operation<Node, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Node result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Node, OperationMetadata> retrievedResponse = tpuClient.PollOnceDeleteNode(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Node retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteNodeAsync</summary>
        public async Task DeleteNodeResourceNamesAsync()
        {
            // Snippet: DeleteNodeAsync(NodeName, CallSettings)
            // Additional: DeleteNodeAsync(NodeName, CancellationToken)
            // Create client
            TpuClient tpuClient = await TpuClient.CreateAsync();
            // Initialize request argument(s)
            NodeName name = NodeName.FromProjectLocationNode("[PROJECT]", "[LOCATION]", "[NODE]");
            // Make the request
            Operation<Node, OperationMetadata> response = await tpuClient.DeleteNodeAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Node, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Node result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Node, OperationMetadata> retrievedResponse = await tpuClient.PollOnceDeleteNodeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Node retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ReimageNode</summary>
        public void ReimageNodeRequestObject()
        {
            // Snippet: ReimageNode(ReimageNodeRequest, CallSettings)
            // Create client
            TpuClient tpuClient = TpuClient.Create();
            // Initialize request argument(s)
            ReimageNodeRequest request = new ReimageNodeRequest
            {
                Name = "",
                TensorflowVersion = "",
            };
            // Make the request
            Operation<Node, OperationMetadata> response = tpuClient.ReimageNode(request);

            // Poll until the returned long-running operation is complete
            Operation<Node, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Node result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Node, OperationMetadata> retrievedResponse = tpuClient.PollOnceReimageNode(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Node retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ReimageNodeAsync</summary>
        public async Task ReimageNodeRequestObjectAsync()
        {
            // Snippet: ReimageNodeAsync(ReimageNodeRequest, CallSettings)
            // Additional: ReimageNodeAsync(ReimageNodeRequest, CancellationToken)
            // Create client
            TpuClient tpuClient = await TpuClient.CreateAsync();
            // Initialize request argument(s)
            ReimageNodeRequest request = new ReimageNodeRequest
            {
                Name = "",
                TensorflowVersion = "",
            };
            // Make the request
            Operation<Node, OperationMetadata> response = await tpuClient.ReimageNodeAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Node, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Node result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Node, OperationMetadata> retrievedResponse = await tpuClient.PollOnceReimageNodeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Node retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StopNode</summary>
        public void StopNodeRequestObject()
        {
            // Snippet: StopNode(StopNodeRequest, CallSettings)
            // Create client
            TpuClient tpuClient = TpuClient.Create();
            // Initialize request argument(s)
            StopNodeRequest request = new StopNodeRequest { Name = "", };
            // Make the request
            Operation<Node, OperationMetadata> response = tpuClient.StopNode(request);

            // Poll until the returned long-running operation is complete
            Operation<Node, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Node result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Node, OperationMetadata> retrievedResponse = tpuClient.PollOnceStopNode(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Node retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StopNodeAsync</summary>
        public async Task StopNodeRequestObjectAsync()
        {
            // Snippet: StopNodeAsync(StopNodeRequest, CallSettings)
            // Additional: StopNodeAsync(StopNodeRequest, CancellationToken)
            // Create client
            TpuClient tpuClient = await TpuClient.CreateAsync();
            // Initialize request argument(s)
            StopNodeRequest request = new StopNodeRequest { Name = "", };
            // Make the request
            Operation<Node, OperationMetadata> response = await tpuClient.StopNodeAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Node, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Node result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Node, OperationMetadata> retrievedResponse = await tpuClient.PollOnceStopNodeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Node retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StartNode</summary>
        public void StartNodeRequestObject()
        {
            // Snippet: StartNode(StartNodeRequest, CallSettings)
            // Create client
            TpuClient tpuClient = TpuClient.Create();
            // Initialize request argument(s)
            StartNodeRequest request = new StartNodeRequest { Name = "", };
            // Make the request
            Operation<Node, OperationMetadata> response = tpuClient.StartNode(request);

            // Poll until the returned long-running operation is complete
            Operation<Node, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Node result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Node, OperationMetadata> retrievedResponse = tpuClient.PollOnceStartNode(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Node retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StartNodeAsync</summary>
        public async Task StartNodeRequestObjectAsync()
        {
            // Snippet: StartNodeAsync(StartNodeRequest, CallSettings)
            // Additional: StartNodeAsync(StartNodeRequest, CancellationToken)
            // Create client
            TpuClient tpuClient = await TpuClient.CreateAsync();
            // Initialize request argument(s)
            StartNodeRequest request = new StartNodeRequest { Name = "", };
            // Make the request
            Operation<Node, OperationMetadata> response = await tpuClient.StartNodeAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Node, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Node result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Node, OperationMetadata> retrievedResponse = await tpuClient.PollOnceStartNodeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Node retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListTensorFlowVersions</summary>
        public void ListTensorFlowVersionsRequestObject()
        {
            // Snippet: ListTensorFlowVersions(ListTensorFlowVersionsRequest, CallSettings)
            // Create client
            TpuClient tpuClient = TpuClient.Create();
            // Initialize request argument(s)
            ListTensorFlowVersionsRequest request = new ListTensorFlowVersionsRequest
            {
                ParentAsTensorFlowVersionName = TensorFlowVersionName.FromProjectLocationTensorFlowVersion("[PROJECT]", "[LOCATION]", "[TENSOR_FLOW_VERSION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListTensorFlowVersionsResponse, TensorFlowVersion> response = tpuClient.ListTensorFlowVersions(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (TensorFlowVersion item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTensorFlowVersionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TensorFlowVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TensorFlowVersion> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TensorFlowVersion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTensorFlowVersionsAsync</summary>
        public async Task ListTensorFlowVersionsRequestObjectAsync()
        {
            // Snippet: ListTensorFlowVersionsAsync(ListTensorFlowVersionsRequest, CallSettings)
            // Create client
            TpuClient tpuClient = await TpuClient.CreateAsync();
            // Initialize request argument(s)
            ListTensorFlowVersionsRequest request = new ListTensorFlowVersionsRequest
            {
                ParentAsTensorFlowVersionName = TensorFlowVersionName.FromProjectLocationTensorFlowVersion("[PROJECT]", "[LOCATION]", "[TENSOR_FLOW_VERSION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListTensorFlowVersionsResponse, TensorFlowVersion> response = tpuClient.ListTensorFlowVersionsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((TensorFlowVersion item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTensorFlowVersionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TensorFlowVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TensorFlowVersion> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TensorFlowVersion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTensorFlowVersions</summary>
        public void ListTensorFlowVersions()
        {
            // Snippet: ListTensorFlowVersions(string, string, int?, CallSettings)
            // Create client
            TpuClient tpuClient = TpuClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/tensorFlowVersions/[TENSOR_FLOW_VERSION]";
            // Make the request
            PagedEnumerable<ListTensorFlowVersionsResponse, TensorFlowVersion> response = tpuClient.ListTensorFlowVersions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (TensorFlowVersion item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTensorFlowVersionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TensorFlowVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TensorFlowVersion> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TensorFlowVersion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTensorFlowVersionsAsync</summary>
        public async Task ListTensorFlowVersionsAsync()
        {
            // Snippet: ListTensorFlowVersionsAsync(string, string, int?, CallSettings)
            // Create client
            TpuClient tpuClient = await TpuClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/tensorFlowVersions/[TENSOR_FLOW_VERSION]";
            // Make the request
            PagedAsyncEnumerable<ListTensorFlowVersionsResponse, TensorFlowVersion> response = tpuClient.ListTensorFlowVersionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((TensorFlowVersion item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTensorFlowVersionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TensorFlowVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TensorFlowVersion> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TensorFlowVersion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTensorFlowVersions</summary>
        public void ListTensorFlowVersionsResourceNames()
        {
            // Snippet: ListTensorFlowVersions(TensorFlowVersionName, string, int?, CallSettings)
            // Create client
            TpuClient tpuClient = TpuClient.Create();
            // Initialize request argument(s)
            TensorFlowVersionName parent = TensorFlowVersionName.FromProjectLocationTensorFlowVersion("[PROJECT]", "[LOCATION]", "[TENSOR_FLOW_VERSION]");
            // Make the request
            PagedEnumerable<ListTensorFlowVersionsResponse, TensorFlowVersion> response = tpuClient.ListTensorFlowVersions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (TensorFlowVersion item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTensorFlowVersionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TensorFlowVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TensorFlowVersion> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TensorFlowVersion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTensorFlowVersionsAsync</summary>
        public async Task ListTensorFlowVersionsResourceNamesAsync()
        {
            // Snippet: ListTensorFlowVersionsAsync(TensorFlowVersionName, string, int?, CallSettings)
            // Create client
            TpuClient tpuClient = await TpuClient.CreateAsync();
            // Initialize request argument(s)
            TensorFlowVersionName parent = TensorFlowVersionName.FromProjectLocationTensorFlowVersion("[PROJECT]", "[LOCATION]", "[TENSOR_FLOW_VERSION]");
            // Make the request
            PagedAsyncEnumerable<ListTensorFlowVersionsResponse, TensorFlowVersion> response = tpuClient.ListTensorFlowVersionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((TensorFlowVersion item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTensorFlowVersionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TensorFlowVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TensorFlowVersion> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TensorFlowVersion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetTensorFlowVersion</summary>
        public void GetTensorFlowVersionRequestObject()
        {
            // Snippet: GetTensorFlowVersion(GetTensorFlowVersionRequest, CallSettings)
            // Create client
            TpuClient tpuClient = TpuClient.Create();
            // Initialize request argument(s)
            GetTensorFlowVersionRequest request = new GetTensorFlowVersionRequest
            {
                TensorFlowVersionName = TensorFlowVersionName.FromProjectLocationTensorFlowVersion("[PROJECT]", "[LOCATION]", "[TENSOR_FLOW_VERSION]"),
            };
            // Make the request
            TensorFlowVersion response = tpuClient.GetTensorFlowVersion(request);
            // End snippet
        }

        /// <summary>Snippet for GetTensorFlowVersionAsync</summary>
        public async Task GetTensorFlowVersionRequestObjectAsync()
        {
            // Snippet: GetTensorFlowVersionAsync(GetTensorFlowVersionRequest, CallSettings)
            // Additional: GetTensorFlowVersionAsync(GetTensorFlowVersionRequest, CancellationToken)
            // Create client
            TpuClient tpuClient = await TpuClient.CreateAsync();
            // Initialize request argument(s)
            GetTensorFlowVersionRequest request = new GetTensorFlowVersionRequest
            {
                TensorFlowVersionName = TensorFlowVersionName.FromProjectLocationTensorFlowVersion("[PROJECT]", "[LOCATION]", "[TENSOR_FLOW_VERSION]"),
            };
            // Make the request
            TensorFlowVersion response = await tpuClient.GetTensorFlowVersionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetTensorFlowVersion</summary>
        public void GetTensorFlowVersion()
        {
            // Snippet: GetTensorFlowVersion(string, CallSettings)
            // Create client
            TpuClient tpuClient = TpuClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/tensorFlowVersions/[TENSOR_FLOW_VERSION]";
            // Make the request
            TensorFlowVersion response = tpuClient.GetTensorFlowVersion(name);
            // End snippet
        }

        /// <summary>Snippet for GetTensorFlowVersionAsync</summary>
        public async Task GetTensorFlowVersionAsync()
        {
            // Snippet: GetTensorFlowVersionAsync(string, CallSettings)
            // Additional: GetTensorFlowVersionAsync(string, CancellationToken)
            // Create client
            TpuClient tpuClient = await TpuClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/tensorFlowVersions/[TENSOR_FLOW_VERSION]";
            // Make the request
            TensorFlowVersion response = await tpuClient.GetTensorFlowVersionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetTensorFlowVersion</summary>
        public void GetTensorFlowVersionResourceNames()
        {
            // Snippet: GetTensorFlowVersion(TensorFlowVersionName, CallSettings)
            // Create client
            TpuClient tpuClient = TpuClient.Create();
            // Initialize request argument(s)
            TensorFlowVersionName name = TensorFlowVersionName.FromProjectLocationTensorFlowVersion("[PROJECT]", "[LOCATION]", "[TENSOR_FLOW_VERSION]");
            // Make the request
            TensorFlowVersion response = tpuClient.GetTensorFlowVersion(name);
            // End snippet
        }

        /// <summary>Snippet for GetTensorFlowVersionAsync</summary>
        public async Task GetTensorFlowVersionResourceNamesAsync()
        {
            // Snippet: GetTensorFlowVersionAsync(TensorFlowVersionName, CallSettings)
            // Additional: GetTensorFlowVersionAsync(TensorFlowVersionName, CancellationToken)
            // Create client
            TpuClient tpuClient = await TpuClient.CreateAsync();
            // Initialize request argument(s)
            TensorFlowVersionName name = TensorFlowVersionName.FromProjectLocationTensorFlowVersion("[PROJECT]", "[LOCATION]", "[TENSOR_FLOW_VERSION]");
            // Make the request
            TensorFlowVersion response = await tpuClient.GetTensorFlowVersionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListAcceleratorTypes</summary>
        public void ListAcceleratorTypesRequestObject()
        {
            // Snippet: ListAcceleratorTypes(ListAcceleratorTypesRequest, CallSettings)
            // Create client
            TpuClient tpuClient = TpuClient.Create();
            // Initialize request argument(s)
            ListAcceleratorTypesRequest request = new ListAcceleratorTypesRequest
            {
                ParentAsAcceleratorTypeName = AcceleratorTypeName.FromProjectLocationAcceleratorType("[PROJECT]", "[LOCATION]", "[ACCELERATOR_TYPE]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListAcceleratorTypesResponse, AcceleratorType> response = tpuClient.ListAcceleratorTypes(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AcceleratorType item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAcceleratorTypesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AcceleratorType item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AcceleratorType> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AcceleratorType item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAcceleratorTypesAsync</summary>
        public async Task ListAcceleratorTypesRequestObjectAsync()
        {
            // Snippet: ListAcceleratorTypesAsync(ListAcceleratorTypesRequest, CallSettings)
            // Create client
            TpuClient tpuClient = await TpuClient.CreateAsync();
            // Initialize request argument(s)
            ListAcceleratorTypesRequest request = new ListAcceleratorTypesRequest
            {
                ParentAsAcceleratorTypeName = AcceleratorTypeName.FromProjectLocationAcceleratorType("[PROJECT]", "[LOCATION]", "[ACCELERATOR_TYPE]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListAcceleratorTypesResponse, AcceleratorType> response = tpuClient.ListAcceleratorTypesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AcceleratorType item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAcceleratorTypesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AcceleratorType item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AcceleratorType> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AcceleratorType item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAcceleratorTypes</summary>
        public void ListAcceleratorTypes()
        {
            // Snippet: ListAcceleratorTypes(string, string, int?, CallSettings)
            // Create client
            TpuClient tpuClient = TpuClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/acceleratorTypes/[ACCELERATOR_TYPE]";
            // Make the request
            PagedEnumerable<ListAcceleratorTypesResponse, AcceleratorType> response = tpuClient.ListAcceleratorTypes(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AcceleratorType item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAcceleratorTypesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AcceleratorType item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AcceleratorType> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AcceleratorType item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAcceleratorTypesAsync</summary>
        public async Task ListAcceleratorTypesAsync()
        {
            // Snippet: ListAcceleratorTypesAsync(string, string, int?, CallSettings)
            // Create client
            TpuClient tpuClient = await TpuClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/acceleratorTypes/[ACCELERATOR_TYPE]";
            // Make the request
            PagedAsyncEnumerable<ListAcceleratorTypesResponse, AcceleratorType> response = tpuClient.ListAcceleratorTypesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AcceleratorType item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAcceleratorTypesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AcceleratorType item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AcceleratorType> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AcceleratorType item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAcceleratorTypes</summary>
        public void ListAcceleratorTypesResourceNames()
        {
            // Snippet: ListAcceleratorTypes(AcceleratorTypeName, string, int?, CallSettings)
            // Create client
            TpuClient tpuClient = TpuClient.Create();
            // Initialize request argument(s)
            AcceleratorTypeName parent = AcceleratorTypeName.FromProjectLocationAcceleratorType("[PROJECT]", "[LOCATION]", "[ACCELERATOR_TYPE]");
            // Make the request
            PagedEnumerable<ListAcceleratorTypesResponse, AcceleratorType> response = tpuClient.ListAcceleratorTypes(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AcceleratorType item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAcceleratorTypesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AcceleratorType item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AcceleratorType> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AcceleratorType item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAcceleratorTypesAsync</summary>
        public async Task ListAcceleratorTypesResourceNamesAsync()
        {
            // Snippet: ListAcceleratorTypesAsync(AcceleratorTypeName, string, int?, CallSettings)
            // Create client
            TpuClient tpuClient = await TpuClient.CreateAsync();
            // Initialize request argument(s)
            AcceleratorTypeName parent = AcceleratorTypeName.FromProjectLocationAcceleratorType("[PROJECT]", "[LOCATION]", "[ACCELERATOR_TYPE]");
            // Make the request
            PagedAsyncEnumerable<ListAcceleratorTypesResponse, AcceleratorType> response = tpuClient.ListAcceleratorTypesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AcceleratorType item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAcceleratorTypesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AcceleratorType item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AcceleratorType> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AcceleratorType item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetAcceleratorType</summary>
        public void GetAcceleratorTypeRequestObject()
        {
            // Snippet: GetAcceleratorType(GetAcceleratorTypeRequest, CallSettings)
            // Create client
            TpuClient tpuClient = TpuClient.Create();
            // Initialize request argument(s)
            GetAcceleratorTypeRequest request = new GetAcceleratorTypeRequest
            {
                AcceleratorTypeName = AcceleratorTypeName.FromProjectLocationAcceleratorType("[PROJECT]", "[LOCATION]", "[ACCELERATOR_TYPE]"),
            };
            // Make the request
            AcceleratorType response = tpuClient.GetAcceleratorType(request);
            // End snippet
        }

        /// <summary>Snippet for GetAcceleratorTypeAsync</summary>
        public async Task GetAcceleratorTypeRequestObjectAsync()
        {
            // Snippet: GetAcceleratorTypeAsync(GetAcceleratorTypeRequest, CallSettings)
            // Additional: GetAcceleratorTypeAsync(GetAcceleratorTypeRequest, CancellationToken)
            // Create client
            TpuClient tpuClient = await TpuClient.CreateAsync();
            // Initialize request argument(s)
            GetAcceleratorTypeRequest request = new GetAcceleratorTypeRequest
            {
                AcceleratorTypeName = AcceleratorTypeName.FromProjectLocationAcceleratorType("[PROJECT]", "[LOCATION]", "[ACCELERATOR_TYPE]"),
            };
            // Make the request
            AcceleratorType response = await tpuClient.GetAcceleratorTypeAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAcceleratorType</summary>
        public void GetAcceleratorType()
        {
            // Snippet: GetAcceleratorType(string, CallSettings)
            // Create client
            TpuClient tpuClient = TpuClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/acceleratorTypes/[ACCELERATOR_TYPE]";
            // Make the request
            AcceleratorType response = tpuClient.GetAcceleratorType(name);
            // End snippet
        }

        /// <summary>Snippet for GetAcceleratorTypeAsync</summary>
        public async Task GetAcceleratorTypeAsync()
        {
            // Snippet: GetAcceleratorTypeAsync(string, CallSettings)
            // Additional: GetAcceleratorTypeAsync(string, CancellationToken)
            // Create client
            TpuClient tpuClient = await TpuClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/acceleratorTypes/[ACCELERATOR_TYPE]";
            // Make the request
            AcceleratorType response = await tpuClient.GetAcceleratorTypeAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetAcceleratorType</summary>
        public void GetAcceleratorTypeResourceNames()
        {
            // Snippet: GetAcceleratorType(AcceleratorTypeName, CallSettings)
            // Create client
            TpuClient tpuClient = TpuClient.Create();
            // Initialize request argument(s)
            AcceleratorTypeName name = AcceleratorTypeName.FromProjectLocationAcceleratorType("[PROJECT]", "[LOCATION]", "[ACCELERATOR_TYPE]");
            // Make the request
            AcceleratorType response = tpuClient.GetAcceleratorType(name);
            // End snippet
        }

        /// <summary>Snippet for GetAcceleratorTypeAsync</summary>
        public async Task GetAcceleratorTypeResourceNamesAsync()
        {
            // Snippet: GetAcceleratorTypeAsync(AcceleratorTypeName, CallSettings)
            // Additional: GetAcceleratorTypeAsync(AcceleratorTypeName, CancellationToken)
            // Create client
            TpuClient tpuClient = await TpuClient.CreateAsync();
            // Initialize request argument(s)
            AcceleratorTypeName name = AcceleratorTypeName.FromProjectLocationAcceleratorType("[PROJECT]", "[LOCATION]", "[ACCELERATOR_TYPE]");
            // Make the request
            AcceleratorType response = await tpuClient.GetAcceleratorTypeAsync(name);
            // End snippet
        }
    }
}
