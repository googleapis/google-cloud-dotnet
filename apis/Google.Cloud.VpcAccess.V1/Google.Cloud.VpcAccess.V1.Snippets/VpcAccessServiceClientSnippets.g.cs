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
    using Google.Cloud.VpcAccess.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedVpcAccessServiceClientSnippets
    {
        /// <summary>Snippet for CreateConnector</summary>
        public void CreateConnectorRequestObject()
        {
            // Snippet: CreateConnector(CreateConnectorRequest, CallSettings)
            // Create client
            VpcAccessServiceClient vpcAccessServiceClient = VpcAccessServiceClient.Create();
            // Initialize request argument(s)
            CreateConnectorRequest request = new CreateConnectorRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ConnectorId = "",
                Connector = new Connector(),
            };
            // Make the request
            Operation<Connector, OperationMetadata> response = vpcAccessServiceClient.CreateConnector(request);

            // Poll until the returned long-running operation is complete
            Operation<Connector, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Connector result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Connector, OperationMetadata> retrievedResponse = vpcAccessServiceClient.PollOnceCreateConnector(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Connector retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateConnectorAsync</summary>
        public async Task CreateConnectorRequestObjectAsync()
        {
            // Snippet: CreateConnectorAsync(CreateConnectorRequest, CallSettings)
            // Additional: CreateConnectorAsync(CreateConnectorRequest, CancellationToken)
            // Create client
            VpcAccessServiceClient vpcAccessServiceClient = await VpcAccessServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateConnectorRequest request = new CreateConnectorRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ConnectorId = "",
                Connector = new Connector(),
            };
            // Make the request
            Operation<Connector, OperationMetadata> response = await vpcAccessServiceClient.CreateConnectorAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Connector, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Connector result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Connector, OperationMetadata> retrievedResponse = await vpcAccessServiceClient.PollOnceCreateConnectorAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Connector retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateConnector</summary>
        public void CreateConnector()
        {
            // Snippet: CreateConnector(string, string, Connector, CallSettings)
            // Create client
            VpcAccessServiceClient vpcAccessServiceClient = VpcAccessServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            string connectorId = "";
            Connector connector = new Connector();
            // Make the request
            Operation<Connector, OperationMetadata> response = vpcAccessServiceClient.CreateConnector(parent, connectorId, connector);

            // Poll until the returned long-running operation is complete
            Operation<Connector, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Connector result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Connector, OperationMetadata> retrievedResponse = vpcAccessServiceClient.PollOnceCreateConnector(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Connector retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateConnectorAsync</summary>
        public async Task CreateConnectorAsync()
        {
            // Snippet: CreateConnectorAsync(string, string, Connector, CallSettings)
            // Additional: CreateConnectorAsync(string, string, Connector, CancellationToken)
            // Create client
            VpcAccessServiceClient vpcAccessServiceClient = await VpcAccessServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            string connectorId = "";
            Connector connector = new Connector();
            // Make the request
            Operation<Connector, OperationMetadata> response = await vpcAccessServiceClient.CreateConnectorAsync(parent, connectorId, connector);

            // Poll until the returned long-running operation is complete
            Operation<Connector, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Connector result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Connector, OperationMetadata> retrievedResponse = await vpcAccessServiceClient.PollOnceCreateConnectorAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Connector retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateConnector</summary>
        public void CreateConnectorResourceNames()
        {
            // Snippet: CreateConnector(LocationName, string, Connector, CallSettings)
            // Create client
            VpcAccessServiceClient vpcAccessServiceClient = VpcAccessServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            string connectorId = "";
            Connector connector = new Connector();
            // Make the request
            Operation<Connector, OperationMetadata> response = vpcAccessServiceClient.CreateConnector(parent, connectorId, connector);

            // Poll until the returned long-running operation is complete
            Operation<Connector, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Connector result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Connector, OperationMetadata> retrievedResponse = vpcAccessServiceClient.PollOnceCreateConnector(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Connector retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateConnectorAsync</summary>
        public async Task CreateConnectorResourceNamesAsync()
        {
            // Snippet: CreateConnectorAsync(LocationName, string, Connector, CallSettings)
            // Additional: CreateConnectorAsync(LocationName, string, Connector, CancellationToken)
            // Create client
            VpcAccessServiceClient vpcAccessServiceClient = await VpcAccessServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            string connectorId = "";
            Connector connector = new Connector();
            // Make the request
            Operation<Connector, OperationMetadata> response = await vpcAccessServiceClient.CreateConnectorAsync(parent, connectorId, connector);

            // Poll until the returned long-running operation is complete
            Operation<Connector, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Connector result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Connector, OperationMetadata> retrievedResponse = await vpcAccessServiceClient.PollOnceCreateConnectorAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Connector retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetConnector</summary>
        public void GetConnectorRequestObject()
        {
            // Snippet: GetConnector(GetConnectorRequest, CallSettings)
            // Create client
            VpcAccessServiceClient vpcAccessServiceClient = VpcAccessServiceClient.Create();
            // Initialize request argument(s)
            GetConnectorRequest request = new GetConnectorRequest
            {
                ConnectorName = ConnectorName.FromProjectLocationConnector("[PROJECT]", "[LOCATION]", "[CONNECTOR]"),
            };
            // Make the request
            Connector response = vpcAccessServiceClient.GetConnector(request);
            // End snippet
        }

        /// <summary>Snippet for GetConnectorAsync</summary>
        public async Task GetConnectorRequestObjectAsync()
        {
            // Snippet: GetConnectorAsync(GetConnectorRequest, CallSettings)
            // Additional: GetConnectorAsync(GetConnectorRequest, CancellationToken)
            // Create client
            VpcAccessServiceClient vpcAccessServiceClient = await VpcAccessServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetConnectorRequest request = new GetConnectorRequest
            {
                ConnectorName = ConnectorName.FromProjectLocationConnector("[PROJECT]", "[LOCATION]", "[CONNECTOR]"),
            };
            // Make the request
            Connector response = await vpcAccessServiceClient.GetConnectorAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetConnector</summary>
        public void GetConnector()
        {
            // Snippet: GetConnector(string, CallSettings)
            // Create client
            VpcAccessServiceClient vpcAccessServiceClient = VpcAccessServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/connectors/[CONNECTOR]";
            // Make the request
            Connector response = vpcAccessServiceClient.GetConnector(name);
            // End snippet
        }

        /// <summary>Snippet for GetConnectorAsync</summary>
        public async Task GetConnectorAsync()
        {
            // Snippet: GetConnectorAsync(string, CallSettings)
            // Additional: GetConnectorAsync(string, CancellationToken)
            // Create client
            VpcAccessServiceClient vpcAccessServiceClient = await VpcAccessServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/connectors/[CONNECTOR]";
            // Make the request
            Connector response = await vpcAccessServiceClient.GetConnectorAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetConnector</summary>
        public void GetConnectorResourceNames()
        {
            // Snippet: GetConnector(ConnectorName, CallSettings)
            // Create client
            VpcAccessServiceClient vpcAccessServiceClient = VpcAccessServiceClient.Create();
            // Initialize request argument(s)
            ConnectorName name = ConnectorName.FromProjectLocationConnector("[PROJECT]", "[LOCATION]", "[CONNECTOR]");
            // Make the request
            Connector response = vpcAccessServiceClient.GetConnector(name);
            // End snippet
        }

        /// <summary>Snippet for GetConnectorAsync</summary>
        public async Task GetConnectorResourceNamesAsync()
        {
            // Snippet: GetConnectorAsync(ConnectorName, CallSettings)
            // Additional: GetConnectorAsync(ConnectorName, CancellationToken)
            // Create client
            VpcAccessServiceClient vpcAccessServiceClient = await VpcAccessServiceClient.CreateAsync();
            // Initialize request argument(s)
            ConnectorName name = ConnectorName.FromProjectLocationConnector("[PROJECT]", "[LOCATION]", "[CONNECTOR]");
            // Make the request
            Connector response = await vpcAccessServiceClient.GetConnectorAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListConnectors</summary>
        public void ListConnectorsRequestObject()
        {
            // Snippet: ListConnectors(ListConnectorsRequest, CallSettings)
            // Create client
            VpcAccessServiceClient vpcAccessServiceClient = VpcAccessServiceClient.Create();
            // Initialize request argument(s)
            ListConnectorsRequest request = new ListConnectorsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedEnumerable<ListConnectorsResponse, Connector> response = vpcAccessServiceClient.ListConnectors(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Connector item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListConnectorsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Connector item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Connector> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Connector item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListConnectorsAsync</summary>
        public async Task ListConnectorsRequestObjectAsync()
        {
            // Snippet: ListConnectorsAsync(ListConnectorsRequest, CallSettings)
            // Create client
            VpcAccessServiceClient vpcAccessServiceClient = await VpcAccessServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListConnectorsRequest request = new ListConnectorsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListConnectorsResponse, Connector> response = vpcAccessServiceClient.ListConnectorsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Connector item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListConnectorsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Connector item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Connector> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Connector item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListConnectors</summary>
        public void ListConnectors()
        {
            // Snippet: ListConnectors(string, string, int?, CallSettings)
            // Create client
            VpcAccessServiceClient vpcAccessServiceClient = VpcAccessServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListConnectorsResponse, Connector> response = vpcAccessServiceClient.ListConnectors(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Connector item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListConnectorsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Connector item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Connector> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Connector item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListConnectorsAsync</summary>
        public async Task ListConnectorsAsync()
        {
            // Snippet: ListConnectorsAsync(string, string, int?, CallSettings)
            // Create client
            VpcAccessServiceClient vpcAccessServiceClient = await VpcAccessServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListConnectorsResponse, Connector> response = vpcAccessServiceClient.ListConnectorsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Connector item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListConnectorsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Connector item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Connector> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Connector item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListConnectors</summary>
        public void ListConnectorsResourceNames()
        {
            // Snippet: ListConnectors(LocationName, string, int?, CallSettings)
            // Create client
            VpcAccessServiceClient vpcAccessServiceClient = VpcAccessServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListConnectorsResponse, Connector> response = vpcAccessServiceClient.ListConnectors(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Connector item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListConnectorsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Connector item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Connector> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Connector item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListConnectorsAsync</summary>
        public async Task ListConnectorsResourceNamesAsync()
        {
            // Snippet: ListConnectorsAsync(LocationName, string, int?, CallSettings)
            // Create client
            VpcAccessServiceClient vpcAccessServiceClient = await VpcAccessServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListConnectorsResponse, Connector> response = vpcAccessServiceClient.ListConnectorsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Connector item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListConnectorsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Connector item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Connector> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Connector item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DeleteConnector</summary>
        public void DeleteConnectorRequestObject()
        {
            // Snippet: DeleteConnector(DeleteConnectorRequest, CallSettings)
            // Create client
            VpcAccessServiceClient vpcAccessServiceClient = VpcAccessServiceClient.Create();
            // Initialize request argument(s)
            DeleteConnectorRequest request = new DeleteConnectorRequest
            {
                ConnectorName = ConnectorName.FromProjectLocationConnector("[PROJECT]", "[LOCATION]", "[CONNECTOR]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = vpcAccessServiceClient.DeleteConnector(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = vpcAccessServiceClient.PollOnceDeleteConnector(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteConnectorAsync</summary>
        public async Task DeleteConnectorRequestObjectAsync()
        {
            // Snippet: DeleteConnectorAsync(DeleteConnectorRequest, CallSettings)
            // Additional: DeleteConnectorAsync(DeleteConnectorRequest, CancellationToken)
            // Create client
            VpcAccessServiceClient vpcAccessServiceClient = await VpcAccessServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteConnectorRequest request = new DeleteConnectorRequest
            {
                ConnectorName = ConnectorName.FromProjectLocationConnector("[PROJECT]", "[LOCATION]", "[CONNECTOR]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await vpcAccessServiceClient.DeleteConnectorAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await vpcAccessServiceClient.PollOnceDeleteConnectorAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteConnector</summary>
        public void DeleteConnector()
        {
            // Snippet: DeleteConnector(string, CallSettings)
            // Create client
            VpcAccessServiceClient vpcAccessServiceClient = VpcAccessServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/connectors/[CONNECTOR]";
            // Make the request
            Operation<Empty, OperationMetadata> response = vpcAccessServiceClient.DeleteConnector(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = vpcAccessServiceClient.PollOnceDeleteConnector(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteConnectorAsync</summary>
        public async Task DeleteConnectorAsync()
        {
            // Snippet: DeleteConnectorAsync(string, CallSettings)
            // Additional: DeleteConnectorAsync(string, CancellationToken)
            // Create client
            VpcAccessServiceClient vpcAccessServiceClient = await VpcAccessServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/connectors/[CONNECTOR]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await vpcAccessServiceClient.DeleteConnectorAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await vpcAccessServiceClient.PollOnceDeleteConnectorAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteConnector</summary>
        public void DeleteConnectorResourceNames()
        {
            // Snippet: DeleteConnector(ConnectorName, CallSettings)
            // Create client
            VpcAccessServiceClient vpcAccessServiceClient = VpcAccessServiceClient.Create();
            // Initialize request argument(s)
            ConnectorName name = ConnectorName.FromProjectLocationConnector("[PROJECT]", "[LOCATION]", "[CONNECTOR]");
            // Make the request
            Operation<Empty, OperationMetadata> response = vpcAccessServiceClient.DeleteConnector(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = vpcAccessServiceClient.PollOnceDeleteConnector(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteConnectorAsync</summary>
        public async Task DeleteConnectorResourceNamesAsync()
        {
            // Snippet: DeleteConnectorAsync(ConnectorName, CallSettings)
            // Additional: DeleteConnectorAsync(ConnectorName, CancellationToken)
            // Create client
            VpcAccessServiceClient vpcAccessServiceClient = await VpcAccessServiceClient.CreateAsync();
            // Initialize request argument(s)
            ConnectorName name = ConnectorName.FromProjectLocationConnector("[PROJECT]", "[LOCATION]", "[CONNECTOR]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await vpcAccessServiceClient.DeleteConnectorAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await vpcAccessServiceClient.PollOnceDeleteConnectorAsync(operationName);
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
