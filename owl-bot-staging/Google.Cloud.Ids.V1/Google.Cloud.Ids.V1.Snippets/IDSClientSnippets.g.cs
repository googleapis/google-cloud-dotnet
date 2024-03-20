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
    using Google.Cloud.Ids.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedIDSClientSnippets
    {
        /// <summary>Snippet for ListEndpoints</summary>
        public void ListEndpointsRequestObject()
        {
            // Snippet: ListEndpoints(ListEndpointsRequest, CallSettings)
            // Create client
            IDSClient iDSClient = IDSClient.Create();
            // Initialize request argument(s)
            ListEndpointsRequest request = new ListEndpointsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListEndpointsResponse, Endpoint> response = iDSClient.ListEndpoints(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Endpoint item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEndpointsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Endpoint item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Endpoint> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Endpoint item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEndpointsAsync</summary>
        public async Task ListEndpointsRequestObjectAsync()
        {
            // Snippet: ListEndpointsAsync(ListEndpointsRequest, CallSettings)
            // Create client
            IDSClient iDSClient = await IDSClient.CreateAsync();
            // Initialize request argument(s)
            ListEndpointsRequest request = new ListEndpointsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListEndpointsResponse, Endpoint> response = iDSClient.ListEndpointsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Endpoint item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListEndpointsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Endpoint item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Endpoint> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Endpoint item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEndpoints</summary>
        public void ListEndpoints()
        {
            // Snippet: ListEndpoints(string, string, int?, CallSettings)
            // Create client
            IDSClient iDSClient = IDSClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListEndpointsResponse, Endpoint> response = iDSClient.ListEndpoints(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Endpoint item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEndpointsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Endpoint item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Endpoint> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Endpoint item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEndpointsAsync</summary>
        public async Task ListEndpointsAsync()
        {
            // Snippet: ListEndpointsAsync(string, string, int?, CallSettings)
            // Create client
            IDSClient iDSClient = await IDSClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListEndpointsResponse, Endpoint> response = iDSClient.ListEndpointsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Endpoint item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListEndpointsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Endpoint item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Endpoint> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Endpoint item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEndpoints</summary>
        public void ListEndpointsResourceNames()
        {
            // Snippet: ListEndpoints(LocationName, string, int?, CallSettings)
            // Create client
            IDSClient iDSClient = IDSClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListEndpointsResponse, Endpoint> response = iDSClient.ListEndpoints(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Endpoint item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEndpointsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Endpoint item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Endpoint> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Endpoint item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEndpointsAsync</summary>
        public async Task ListEndpointsResourceNamesAsync()
        {
            // Snippet: ListEndpointsAsync(LocationName, string, int?, CallSettings)
            // Create client
            IDSClient iDSClient = await IDSClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListEndpointsResponse, Endpoint> response = iDSClient.ListEndpointsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Endpoint item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListEndpointsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Endpoint item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Endpoint> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Endpoint item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetEndpoint</summary>
        public void GetEndpointRequestObject()
        {
            // Snippet: GetEndpoint(GetEndpointRequest, CallSettings)
            // Create client
            IDSClient iDSClient = IDSClient.Create();
            // Initialize request argument(s)
            GetEndpointRequest request = new GetEndpointRequest
            {
                EndpointName = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]"),
            };
            // Make the request
            Endpoint response = iDSClient.GetEndpoint(request);
            // End snippet
        }

        /// <summary>Snippet for GetEndpointAsync</summary>
        public async Task GetEndpointRequestObjectAsync()
        {
            // Snippet: GetEndpointAsync(GetEndpointRequest, CallSettings)
            // Additional: GetEndpointAsync(GetEndpointRequest, CancellationToken)
            // Create client
            IDSClient iDSClient = await IDSClient.CreateAsync();
            // Initialize request argument(s)
            GetEndpointRequest request = new GetEndpointRequest
            {
                EndpointName = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]"),
            };
            // Make the request
            Endpoint response = await iDSClient.GetEndpointAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetEndpoint</summary>
        public void GetEndpoint()
        {
            // Snippet: GetEndpoint(string, CallSettings)
            // Create client
            IDSClient iDSClient = IDSClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/endpoints/[ENDPOINT]";
            // Make the request
            Endpoint response = iDSClient.GetEndpoint(name);
            // End snippet
        }

        /// <summary>Snippet for GetEndpointAsync</summary>
        public async Task GetEndpointAsync()
        {
            // Snippet: GetEndpointAsync(string, CallSettings)
            // Additional: GetEndpointAsync(string, CancellationToken)
            // Create client
            IDSClient iDSClient = await IDSClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/endpoints/[ENDPOINT]";
            // Make the request
            Endpoint response = await iDSClient.GetEndpointAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetEndpoint</summary>
        public void GetEndpointResourceNames()
        {
            // Snippet: GetEndpoint(EndpointName, CallSettings)
            // Create client
            IDSClient iDSClient = IDSClient.Create();
            // Initialize request argument(s)
            EndpointName name = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]");
            // Make the request
            Endpoint response = iDSClient.GetEndpoint(name);
            // End snippet
        }

        /// <summary>Snippet for GetEndpointAsync</summary>
        public async Task GetEndpointResourceNamesAsync()
        {
            // Snippet: GetEndpointAsync(EndpointName, CallSettings)
            // Additional: GetEndpointAsync(EndpointName, CancellationToken)
            // Create client
            IDSClient iDSClient = await IDSClient.CreateAsync();
            // Initialize request argument(s)
            EndpointName name = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]");
            // Make the request
            Endpoint response = await iDSClient.GetEndpointAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateEndpoint</summary>
        public void CreateEndpointRequestObject()
        {
            // Snippet: CreateEndpoint(CreateEndpointRequest, CallSettings)
            // Create client
            IDSClient iDSClient = IDSClient.Create();
            // Initialize request argument(s)
            CreateEndpointRequest request = new CreateEndpointRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                EndpointId = "",
                Endpoint = new Endpoint(),
                RequestId = "",
            };
            // Make the request
            Operation<Endpoint, OperationMetadata> response = iDSClient.CreateEndpoint(request);

            // Poll until the returned long-running operation is complete
            Operation<Endpoint, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Endpoint result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Endpoint, OperationMetadata> retrievedResponse = iDSClient.PollOnceCreateEndpoint(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Endpoint retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateEndpointAsync</summary>
        public async Task CreateEndpointRequestObjectAsync()
        {
            // Snippet: CreateEndpointAsync(CreateEndpointRequest, CallSettings)
            // Additional: CreateEndpointAsync(CreateEndpointRequest, CancellationToken)
            // Create client
            IDSClient iDSClient = await IDSClient.CreateAsync();
            // Initialize request argument(s)
            CreateEndpointRequest request = new CreateEndpointRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                EndpointId = "",
                Endpoint = new Endpoint(),
                RequestId = "",
            };
            // Make the request
            Operation<Endpoint, OperationMetadata> response = await iDSClient.CreateEndpointAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Endpoint, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Endpoint result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Endpoint, OperationMetadata> retrievedResponse = await iDSClient.PollOnceCreateEndpointAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Endpoint retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateEndpoint</summary>
        public void CreateEndpoint()
        {
            // Snippet: CreateEndpoint(string, Endpoint, string, CallSettings)
            // Create client
            IDSClient iDSClient = IDSClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Endpoint endpoint = new Endpoint();
            string endpointId = "";
            // Make the request
            Operation<Endpoint, OperationMetadata> response = iDSClient.CreateEndpoint(parent, endpoint, endpointId);

            // Poll until the returned long-running operation is complete
            Operation<Endpoint, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Endpoint result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Endpoint, OperationMetadata> retrievedResponse = iDSClient.PollOnceCreateEndpoint(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Endpoint retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateEndpointAsync</summary>
        public async Task CreateEndpointAsync()
        {
            // Snippet: CreateEndpointAsync(string, Endpoint, string, CallSettings)
            // Additional: CreateEndpointAsync(string, Endpoint, string, CancellationToken)
            // Create client
            IDSClient iDSClient = await IDSClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Endpoint endpoint = new Endpoint();
            string endpointId = "";
            // Make the request
            Operation<Endpoint, OperationMetadata> response = await iDSClient.CreateEndpointAsync(parent, endpoint, endpointId);

            // Poll until the returned long-running operation is complete
            Operation<Endpoint, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Endpoint result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Endpoint, OperationMetadata> retrievedResponse = await iDSClient.PollOnceCreateEndpointAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Endpoint retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateEndpoint</summary>
        public void CreateEndpointResourceNames()
        {
            // Snippet: CreateEndpoint(LocationName, Endpoint, string, CallSettings)
            // Create client
            IDSClient iDSClient = IDSClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Endpoint endpoint = new Endpoint();
            string endpointId = "";
            // Make the request
            Operation<Endpoint, OperationMetadata> response = iDSClient.CreateEndpoint(parent, endpoint, endpointId);

            // Poll until the returned long-running operation is complete
            Operation<Endpoint, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Endpoint result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Endpoint, OperationMetadata> retrievedResponse = iDSClient.PollOnceCreateEndpoint(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Endpoint retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateEndpointAsync</summary>
        public async Task CreateEndpointResourceNamesAsync()
        {
            // Snippet: CreateEndpointAsync(LocationName, Endpoint, string, CallSettings)
            // Additional: CreateEndpointAsync(LocationName, Endpoint, string, CancellationToken)
            // Create client
            IDSClient iDSClient = await IDSClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Endpoint endpoint = new Endpoint();
            string endpointId = "";
            // Make the request
            Operation<Endpoint, OperationMetadata> response = await iDSClient.CreateEndpointAsync(parent, endpoint, endpointId);

            // Poll until the returned long-running operation is complete
            Operation<Endpoint, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Endpoint result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Endpoint, OperationMetadata> retrievedResponse = await iDSClient.PollOnceCreateEndpointAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Endpoint retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteEndpoint</summary>
        public void DeleteEndpointRequestObject()
        {
            // Snippet: DeleteEndpoint(DeleteEndpointRequest, CallSettings)
            // Create client
            IDSClient iDSClient = IDSClient.Create();
            // Initialize request argument(s)
            DeleteEndpointRequest request = new DeleteEndpointRequest
            {
                EndpointName = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = iDSClient.DeleteEndpoint(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = iDSClient.PollOnceDeleteEndpoint(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteEndpointAsync</summary>
        public async Task DeleteEndpointRequestObjectAsync()
        {
            // Snippet: DeleteEndpointAsync(DeleteEndpointRequest, CallSettings)
            // Additional: DeleteEndpointAsync(DeleteEndpointRequest, CancellationToken)
            // Create client
            IDSClient iDSClient = await IDSClient.CreateAsync();
            // Initialize request argument(s)
            DeleteEndpointRequest request = new DeleteEndpointRequest
            {
                EndpointName = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await iDSClient.DeleteEndpointAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await iDSClient.PollOnceDeleteEndpointAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteEndpoint</summary>
        public void DeleteEndpoint()
        {
            // Snippet: DeleteEndpoint(string, CallSettings)
            // Create client
            IDSClient iDSClient = IDSClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/endpoints/[ENDPOINT]";
            // Make the request
            Operation<Empty, OperationMetadata> response = iDSClient.DeleteEndpoint(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = iDSClient.PollOnceDeleteEndpoint(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteEndpointAsync</summary>
        public async Task DeleteEndpointAsync()
        {
            // Snippet: DeleteEndpointAsync(string, CallSettings)
            // Additional: DeleteEndpointAsync(string, CancellationToken)
            // Create client
            IDSClient iDSClient = await IDSClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/endpoints/[ENDPOINT]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await iDSClient.DeleteEndpointAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await iDSClient.PollOnceDeleteEndpointAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteEndpoint</summary>
        public void DeleteEndpointResourceNames()
        {
            // Snippet: DeleteEndpoint(EndpointName, CallSettings)
            // Create client
            IDSClient iDSClient = IDSClient.Create();
            // Initialize request argument(s)
            EndpointName name = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]");
            // Make the request
            Operation<Empty, OperationMetadata> response = iDSClient.DeleteEndpoint(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = iDSClient.PollOnceDeleteEndpoint(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteEndpointAsync</summary>
        public async Task DeleteEndpointResourceNamesAsync()
        {
            // Snippet: DeleteEndpointAsync(EndpointName, CallSettings)
            // Additional: DeleteEndpointAsync(EndpointName, CancellationToken)
            // Create client
            IDSClient iDSClient = await IDSClient.CreateAsync();
            // Initialize request argument(s)
            EndpointName name = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await iDSClient.DeleteEndpointAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await iDSClient.PollOnceDeleteEndpointAsync(operationName);
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
