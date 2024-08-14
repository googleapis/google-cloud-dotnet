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
    using Google.Cloud.AIPlatform.V1Beta1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedEndpointServiceClientSnippets
    {
        /// <summary>Snippet for CreateEndpoint</summary>
        public void CreateEndpointRequestObject()
        {
            // Snippet: CreateEndpoint(CreateEndpointRequest, CallSettings)
            // Create client
            EndpointServiceClient endpointServiceClient = EndpointServiceClient.Create();
            // Initialize request argument(s)
            CreateEndpointRequest request = new CreateEndpointRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Endpoint = new Endpoint(),
                EndpointId = "",
            };
            // Make the request
            Operation<Endpoint, CreateEndpointOperationMetadata> response = endpointServiceClient.CreateEndpoint(request);

            // Poll until the returned long-running operation is complete
            Operation<Endpoint, CreateEndpointOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Endpoint result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Endpoint, CreateEndpointOperationMetadata> retrievedResponse = endpointServiceClient.PollOnceCreateEndpoint(operationName);
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
            EndpointServiceClient endpointServiceClient = await EndpointServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateEndpointRequest request = new CreateEndpointRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Endpoint = new Endpoint(),
                EndpointId = "",
            };
            // Make the request
            Operation<Endpoint, CreateEndpointOperationMetadata> response = await endpointServiceClient.CreateEndpointAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Endpoint, CreateEndpointOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Endpoint result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Endpoint, CreateEndpointOperationMetadata> retrievedResponse = await endpointServiceClient.PollOnceCreateEndpointAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Endpoint retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateEndpoint</summary>
        public void CreateEndpoint1()
        {
            // Snippet: CreateEndpoint(string, Endpoint, CallSettings)
            // Create client
            EndpointServiceClient endpointServiceClient = EndpointServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Endpoint endpoint = new Endpoint();
            // Make the request
            Operation<Endpoint, CreateEndpointOperationMetadata> response = endpointServiceClient.CreateEndpoint(parent, endpoint);

            // Poll until the returned long-running operation is complete
            Operation<Endpoint, CreateEndpointOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Endpoint result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Endpoint, CreateEndpointOperationMetadata> retrievedResponse = endpointServiceClient.PollOnceCreateEndpoint(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Endpoint retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateEndpointAsync</summary>
        public async Task CreateEndpoint1Async()
        {
            // Snippet: CreateEndpointAsync(string, Endpoint, CallSettings)
            // Additional: CreateEndpointAsync(string, Endpoint, CancellationToken)
            // Create client
            EndpointServiceClient endpointServiceClient = await EndpointServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Endpoint endpoint = new Endpoint();
            // Make the request
            Operation<Endpoint, CreateEndpointOperationMetadata> response = await endpointServiceClient.CreateEndpointAsync(parent, endpoint);

            // Poll until the returned long-running operation is complete
            Operation<Endpoint, CreateEndpointOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Endpoint result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Endpoint, CreateEndpointOperationMetadata> retrievedResponse = await endpointServiceClient.PollOnceCreateEndpointAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Endpoint retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateEndpoint</summary>
        public void CreateEndpoint1ResourceNames()
        {
            // Snippet: CreateEndpoint(LocationName, Endpoint, CallSettings)
            // Create client
            EndpointServiceClient endpointServiceClient = EndpointServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Endpoint endpoint = new Endpoint();
            // Make the request
            Operation<Endpoint, CreateEndpointOperationMetadata> response = endpointServiceClient.CreateEndpoint(parent, endpoint);

            // Poll until the returned long-running operation is complete
            Operation<Endpoint, CreateEndpointOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Endpoint result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Endpoint, CreateEndpointOperationMetadata> retrievedResponse = endpointServiceClient.PollOnceCreateEndpoint(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Endpoint retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateEndpointAsync</summary>
        public async Task CreateEndpoint1ResourceNamesAsync()
        {
            // Snippet: CreateEndpointAsync(LocationName, Endpoint, CallSettings)
            // Additional: CreateEndpointAsync(LocationName, Endpoint, CancellationToken)
            // Create client
            EndpointServiceClient endpointServiceClient = await EndpointServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Endpoint endpoint = new Endpoint();
            // Make the request
            Operation<Endpoint, CreateEndpointOperationMetadata> response = await endpointServiceClient.CreateEndpointAsync(parent, endpoint);

            // Poll until the returned long-running operation is complete
            Operation<Endpoint, CreateEndpointOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Endpoint result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Endpoint, CreateEndpointOperationMetadata> retrievedResponse = await endpointServiceClient.PollOnceCreateEndpointAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Endpoint retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateEndpoint</summary>
        public void CreateEndpoint2()
        {
            // Snippet: CreateEndpoint(string, Endpoint, string, CallSettings)
            // Create client
            EndpointServiceClient endpointServiceClient = EndpointServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Endpoint endpoint = new Endpoint();
            string endpointId = "";
            // Make the request
            Operation<Endpoint, CreateEndpointOperationMetadata> response = endpointServiceClient.CreateEndpoint(parent, endpoint, endpointId);

            // Poll until the returned long-running operation is complete
            Operation<Endpoint, CreateEndpointOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Endpoint result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Endpoint, CreateEndpointOperationMetadata> retrievedResponse = endpointServiceClient.PollOnceCreateEndpoint(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Endpoint retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateEndpointAsync</summary>
        public async Task CreateEndpoint2Async()
        {
            // Snippet: CreateEndpointAsync(string, Endpoint, string, CallSettings)
            // Additional: CreateEndpointAsync(string, Endpoint, string, CancellationToken)
            // Create client
            EndpointServiceClient endpointServiceClient = await EndpointServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Endpoint endpoint = new Endpoint();
            string endpointId = "";
            // Make the request
            Operation<Endpoint, CreateEndpointOperationMetadata> response = await endpointServiceClient.CreateEndpointAsync(parent, endpoint, endpointId);

            // Poll until the returned long-running operation is complete
            Operation<Endpoint, CreateEndpointOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Endpoint result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Endpoint, CreateEndpointOperationMetadata> retrievedResponse = await endpointServiceClient.PollOnceCreateEndpointAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Endpoint retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateEndpoint</summary>
        public void CreateEndpoint2ResourceNames()
        {
            // Snippet: CreateEndpoint(LocationName, Endpoint, string, CallSettings)
            // Create client
            EndpointServiceClient endpointServiceClient = EndpointServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Endpoint endpoint = new Endpoint();
            string endpointId = "";
            // Make the request
            Operation<Endpoint, CreateEndpointOperationMetadata> response = endpointServiceClient.CreateEndpoint(parent, endpoint, endpointId);

            // Poll until the returned long-running operation is complete
            Operation<Endpoint, CreateEndpointOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Endpoint result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Endpoint, CreateEndpointOperationMetadata> retrievedResponse = endpointServiceClient.PollOnceCreateEndpoint(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Endpoint retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateEndpointAsync</summary>
        public async Task CreateEndpoint2ResourceNamesAsync()
        {
            // Snippet: CreateEndpointAsync(LocationName, Endpoint, string, CallSettings)
            // Additional: CreateEndpointAsync(LocationName, Endpoint, string, CancellationToken)
            // Create client
            EndpointServiceClient endpointServiceClient = await EndpointServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Endpoint endpoint = new Endpoint();
            string endpointId = "";
            // Make the request
            Operation<Endpoint, CreateEndpointOperationMetadata> response = await endpointServiceClient.CreateEndpointAsync(parent, endpoint, endpointId);

            // Poll until the returned long-running operation is complete
            Operation<Endpoint, CreateEndpointOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Endpoint result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Endpoint, CreateEndpointOperationMetadata> retrievedResponse = await endpointServiceClient.PollOnceCreateEndpointAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Endpoint retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetEndpoint</summary>
        public void GetEndpointRequestObject()
        {
            // Snippet: GetEndpoint(GetEndpointRequest, CallSettings)
            // Create client
            EndpointServiceClient endpointServiceClient = EndpointServiceClient.Create();
            // Initialize request argument(s)
            GetEndpointRequest request = new GetEndpointRequest
            {
                EndpointName = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]"),
            };
            // Make the request
            Endpoint response = endpointServiceClient.GetEndpoint(request);
            // End snippet
        }

        /// <summary>Snippet for GetEndpointAsync</summary>
        public async Task GetEndpointRequestObjectAsync()
        {
            // Snippet: GetEndpointAsync(GetEndpointRequest, CallSettings)
            // Additional: GetEndpointAsync(GetEndpointRequest, CancellationToken)
            // Create client
            EndpointServiceClient endpointServiceClient = await EndpointServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetEndpointRequest request = new GetEndpointRequest
            {
                EndpointName = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]"),
            };
            // Make the request
            Endpoint response = await endpointServiceClient.GetEndpointAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetEndpoint</summary>
        public void GetEndpoint()
        {
            // Snippet: GetEndpoint(string, CallSettings)
            // Create client
            EndpointServiceClient endpointServiceClient = EndpointServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/endpoints/[ENDPOINT]";
            // Make the request
            Endpoint response = endpointServiceClient.GetEndpoint(name);
            // End snippet
        }

        /// <summary>Snippet for GetEndpointAsync</summary>
        public async Task GetEndpointAsync()
        {
            // Snippet: GetEndpointAsync(string, CallSettings)
            // Additional: GetEndpointAsync(string, CancellationToken)
            // Create client
            EndpointServiceClient endpointServiceClient = await EndpointServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/endpoints/[ENDPOINT]";
            // Make the request
            Endpoint response = await endpointServiceClient.GetEndpointAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetEndpoint</summary>
        public void GetEndpointResourceNames()
        {
            // Snippet: GetEndpoint(EndpointName, CallSettings)
            // Create client
            EndpointServiceClient endpointServiceClient = EndpointServiceClient.Create();
            // Initialize request argument(s)
            EndpointName name = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]");
            // Make the request
            Endpoint response = endpointServiceClient.GetEndpoint(name);
            // End snippet
        }

        /// <summary>Snippet for GetEndpointAsync</summary>
        public async Task GetEndpointResourceNamesAsync()
        {
            // Snippet: GetEndpointAsync(EndpointName, CallSettings)
            // Additional: GetEndpointAsync(EndpointName, CancellationToken)
            // Create client
            EndpointServiceClient endpointServiceClient = await EndpointServiceClient.CreateAsync();
            // Initialize request argument(s)
            EndpointName name = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]");
            // Make the request
            Endpoint response = await endpointServiceClient.GetEndpointAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListEndpoints</summary>
        public void ListEndpointsRequestObject()
        {
            // Snippet: ListEndpoints(ListEndpointsRequest, CallSettings)
            // Create client
            EndpointServiceClient endpointServiceClient = EndpointServiceClient.Create();
            // Initialize request argument(s)
            ListEndpointsRequest request = new ListEndpointsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                ReadMask = new FieldMask(),
            };
            // Make the request
            PagedEnumerable<ListEndpointsResponse, Endpoint> response = endpointServiceClient.ListEndpoints(request);

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
            EndpointServiceClient endpointServiceClient = await EndpointServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListEndpointsRequest request = new ListEndpointsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                ReadMask = new FieldMask(),
            };
            // Make the request
            PagedAsyncEnumerable<ListEndpointsResponse, Endpoint> response = endpointServiceClient.ListEndpointsAsync(request);

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
            EndpointServiceClient endpointServiceClient = EndpointServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListEndpointsResponse, Endpoint> response = endpointServiceClient.ListEndpoints(parent);

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
            EndpointServiceClient endpointServiceClient = await EndpointServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListEndpointsResponse, Endpoint> response = endpointServiceClient.ListEndpointsAsync(parent);

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
            EndpointServiceClient endpointServiceClient = EndpointServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListEndpointsResponse, Endpoint> response = endpointServiceClient.ListEndpoints(parent);

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
            EndpointServiceClient endpointServiceClient = await EndpointServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListEndpointsResponse, Endpoint> response = endpointServiceClient.ListEndpointsAsync(parent);

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

        /// <summary>Snippet for UpdateEndpoint</summary>
        public void UpdateEndpointRequestObject()
        {
            // Snippet: UpdateEndpoint(UpdateEndpointRequest, CallSettings)
            // Create client
            EndpointServiceClient endpointServiceClient = EndpointServiceClient.Create();
            // Initialize request argument(s)
            UpdateEndpointRequest request = new UpdateEndpointRequest
            {
                Endpoint = new Endpoint(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Endpoint response = endpointServiceClient.UpdateEndpoint(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateEndpointAsync</summary>
        public async Task UpdateEndpointRequestObjectAsync()
        {
            // Snippet: UpdateEndpointAsync(UpdateEndpointRequest, CallSettings)
            // Additional: UpdateEndpointAsync(UpdateEndpointRequest, CancellationToken)
            // Create client
            EndpointServiceClient endpointServiceClient = await EndpointServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateEndpointRequest request = new UpdateEndpointRequest
            {
                Endpoint = new Endpoint(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Endpoint response = await endpointServiceClient.UpdateEndpointAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateEndpoint</summary>
        public void UpdateEndpoint()
        {
            // Snippet: UpdateEndpoint(Endpoint, FieldMask, CallSettings)
            // Create client
            EndpointServiceClient endpointServiceClient = EndpointServiceClient.Create();
            // Initialize request argument(s)
            Endpoint endpoint = new Endpoint();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Endpoint response = endpointServiceClient.UpdateEndpoint(endpoint, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateEndpointAsync</summary>
        public async Task UpdateEndpointAsync()
        {
            // Snippet: UpdateEndpointAsync(Endpoint, FieldMask, CallSettings)
            // Additional: UpdateEndpointAsync(Endpoint, FieldMask, CancellationToken)
            // Create client
            EndpointServiceClient endpointServiceClient = await EndpointServiceClient.CreateAsync();
            // Initialize request argument(s)
            Endpoint endpoint = new Endpoint();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Endpoint response = await endpointServiceClient.UpdateEndpointAsync(endpoint, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteEndpoint</summary>
        public void DeleteEndpointRequestObject()
        {
            // Snippet: DeleteEndpoint(DeleteEndpointRequest, CallSettings)
            // Create client
            EndpointServiceClient endpointServiceClient = EndpointServiceClient.Create();
            // Initialize request argument(s)
            DeleteEndpointRequest request = new DeleteEndpointRequest
            {
                EndpointName = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]"),
            };
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = endpointServiceClient.DeleteEndpoint(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = endpointServiceClient.PollOnceDeleteEndpoint(operationName);
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
            EndpointServiceClient endpointServiceClient = await EndpointServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteEndpointRequest request = new DeleteEndpointRequest
            {
                EndpointName = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]"),
            };
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await endpointServiceClient.DeleteEndpointAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await endpointServiceClient.PollOnceDeleteEndpointAsync(operationName);
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
            EndpointServiceClient endpointServiceClient = EndpointServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/endpoints/[ENDPOINT]";
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = endpointServiceClient.DeleteEndpoint(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = endpointServiceClient.PollOnceDeleteEndpoint(operationName);
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
            EndpointServiceClient endpointServiceClient = await EndpointServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/endpoints/[ENDPOINT]";
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await endpointServiceClient.DeleteEndpointAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await endpointServiceClient.PollOnceDeleteEndpointAsync(operationName);
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
            EndpointServiceClient endpointServiceClient = EndpointServiceClient.Create();
            // Initialize request argument(s)
            EndpointName name = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]");
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = endpointServiceClient.DeleteEndpoint(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = endpointServiceClient.PollOnceDeleteEndpoint(operationName);
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
            EndpointServiceClient endpointServiceClient = await EndpointServiceClient.CreateAsync();
            // Initialize request argument(s)
            EndpointName name = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]");
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await endpointServiceClient.DeleteEndpointAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await endpointServiceClient.PollOnceDeleteEndpointAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeployModel</summary>
        public void DeployModelRequestObject()
        {
            // Snippet: DeployModel(DeployModelRequest, CallSettings)
            // Create client
            EndpointServiceClient endpointServiceClient = EndpointServiceClient.Create();
            // Initialize request argument(s)
            DeployModelRequest request = new DeployModelRequest
            {
                EndpointAsEndpointName = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]"),
                DeployedModel = new DeployedModel(),
                TrafficSplit = { { "", 0 }, },
            };
            // Make the request
            Operation<DeployModelResponse, DeployModelOperationMetadata> response = endpointServiceClient.DeployModel(request);

            // Poll until the returned long-running operation is complete
            Operation<DeployModelResponse, DeployModelOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            DeployModelResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DeployModelResponse, DeployModelOperationMetadata> retrievedResponse = endpointServiceClient.PollOnceDeployModel(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DeployModelResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeployModelAsync</summary>
        public async Task DeployModelRequestObjectAsync()
        {
            // Snippet: DeployModelAsync(DeployModelRequest, CallSettings)
            // Additional: DeployModelAsync(DeployModelRequest, CancellationToken)
            // Create client
            EndpointServiceClient endpointServiceClient = await EndpointServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeployModelRequest request = new DeployModelRequest
            {
                EndpointAsEndpointName = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]"),
                DeployedModel = new DeployedModel(),
                TrafficSplit = { { "", 0 }, },
            };
            // Make the request
            Operation<DeployModelResponse, DeployModelOperationMetadata> response = await endpointServiceClient.DeployModelAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<DeployModelResponse, DeployModelOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DeployModelResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DeployModelResponse, DeployModelOperationMetadata> retrievedResponse = await endpointServiceClient.PollOnceDeployModelAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DeployModelResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeployModel</summary>
        public void DeployModel()
        {
            // Snippet: DeployModel(string, DeployedModel, IDictionary<string,int>, CallSettings)
            // Create client
            EndpointServiceClient endpointServiceClient = EndpointServiceClient.Create();
            // Initialize request argument(s)
            string endpoint = "projects/[PROJECT]/locations/[LOCATION]/endpoints/[ENDPOINT]";
            DeployedModel deployedModel = new DeployedModel();
            IDictionary<string, int> trafficSplit = new Dictionary<string, int> { { "", 0 }, };
            // Make the request
            Operation<DeployModelResponse, DeployModelOperationMetadata> response = endpointServiceClient.DeployModel(endpoint, deployedModel, trafficSplit);

            // Poll until the returned long-running operation is complete
            Operation<DeployModelResponse, DeployModelOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            DeployModelResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DeployModelResponse, DeployModelOperationMetadata> retrievedResponse = endpointServiceClient.PollOnceDeployModel(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DeployModelResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeployModelAsync</summary>
        public async Task DeployModelAsync()
        {
            // Snippet: DeployModelAsync(string, DeployedModel, IDictionary<string,int>, CallSettings)
            // Additional: DeployModelAsync(string, DeployedModel, IDictionary<string,int>, CancellationToken)
            // Create client
            EndpointServiceClient endpointServiceClient = await EndpointServiceClient.CreateAsync();
            // Initialize request argument(s)
            string endpoint = "projects/[PROJECT]/locations/[LOCATION]/endpoints/[ENDPOINT]";
            DeployedModel deployedModel = new DeployedModel();
            IDictionary<string, int> trafficSplit = new Dictionary<string, int> { { "", 0 }, };
            // Make the request
            Operation<DeployModelResponse, DeployModelOperationMetadata> response = await endpointServiceClient.DeployModelAsync(endpoint, deployedModel, trafficSplit);

            // Poll until the returned long-running operation is complete
            Operation<DeployModelResponse, DeployModelOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DeployModelResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DeployModelResponse, DeployModelOperationMetadata> retrievedResponse = await endpointServiceClient.PollOnceDeployModelAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DeployModelResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeployModel</summary>
        public void DeployModelResourceNames()
        {
            // Snippet: DeployModel(EndpointName, DeployedModel, IDictionary<string,int>, CallSettings)
            // Create client
            EndpointServiceClient endpointServiceClient = EndpointServiceClient.Create();
            // Initialize request argument(s)
            EndpointName endpoint = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]");
            DeployedModel deployedModel = new DeployedModel();
            IDictionary<string, int> trafficSplit = new Dictionary<string, int> { { "", 0 }, };
            // Make the request
            Operation<DeployModelResponse, DeployModelOperationMetadata> response = endpointServiceClient.DeployModel(endpoint, deployedModel, trafficSplit);

            // Poll until the returned long-running operation is complete
            Operation<DeployModelResponse, DeployModelOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            DeployModelResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DeployModelResponse, DeployModelOperationMetadata> retrievedResponse = endpointServiceClient.PollOnceDeployModel(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DeployModelResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeployModelAsync</summary>
        public async Task DeployModelResourceNamesAsync()
        {
            // Snippet: DeployModelAsync(EndpointName, DeployedModel, IDictionary<string,int>, CallSettings)
            // Additional: DeployModelAsync(EndpointName, DeployedModel, IDictionary<string,int>, CancellationToken)
            // Create client
            EndpointServiceClient endpointServiceClient = await EndpointServiceClient.CreateAsync();
            // Initialize request argument(s)
            EndpointName endpoint = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]");
            DeployedModel deployedModel = new DeployedModel();
            IDictionary<string, int> trafficSplit = new Dictionary<string, int> { { "", 0 }, };
            // Make the request
            Operation<DeployModelResponse, DeployModelOperationMetadata> response = await endpointServiceClient.DeployModelAsync(endpoint, deployedModel, trafficSplit);

            // Poll until the returned long-running operation is complete
            Operation<DeployModelResponse, DeployModelOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DeployModelResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DeployModelResponse, DeployModelOperationMetadata> retrievedResponse = await endpointServiceClient.PollOnceDeployModelAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DeployModelResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UndeployModel</summary>
        public void UndeployModelRequestObject()
        {
            // Snippet: UndeployModel(UndeployModelRequest, CallSettings)
            // Create client
            EndpointServiceClient endpointServiceClient = EndpointServiceClient.Create();
            // Initialize request argument(s)
            UndeployModelRequest request = new UndeployModelRequest
            {
                EndpointAsEndpointName = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]"),
                DeployedModelId = "",
                TrafficSplit = { { "", 0 }, },
            };
            // Make the request
            Operation<UndeployModelResponse, UndeployModelOperationMetadata> response = endpointServiceClient.UndeployModel(request);

            // Poll until the returned long-running operation is complete
            Operation<UndeployModelResponse, UndeployModelOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            UndeployModelResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<UndeployModelResponse, UndeployModelOperationMetadata> retrievedResponse = endpointServiceClient.PollOnceUndeployModel(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                UndeployModelResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UndeployModelAsync</summary>
        public async Task UndeployModelRequestObjectAsync()
        {
            // Snippet: UndeployModelAsync(UndeployModelRequest, CallSettings)
            // Additional: UndeployModelAsync(UndeployModelRequest, CancellationToken)
            // Create client
            EndpointServiceClient endpointServiceClient = await EndpointServiceClient.CreateAsync();
            // Initialize request argument(s)
            UndeployModelRequest request = new UndeployModelRequest
            {
                EndpointAsEndpointName = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]"),
                DeployedModelId = "",
                TrafficSplit = { { "", 0 }, },
            };
            // Make the request
            Operation<UndeployModelResponse, UndeployModelOperationMetadata> response = await endpointServiceClient.UndeployModelAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<UndeployModelResponse, UndeployModelOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            UndeployModelResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<UndeployModelResponse, UndeployModelOperationMetadata> retrievedResponse = await endpointServiceClient.PollOnceUndeployModelAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                UndeployModelResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UndeployModel</summary>
        public void UndeployModel()
        {
            // Snippet: UndeployModel(string, string, IDictionary<string,int>, CallSettings)
            // Create client
            EndpointServiceClient endpointServiceClient = EndpointServiceClient.Create();
            // Initialize request argument(s)
            string endpoint = "projects/[PROJECT]/locations/[LOCATION]/endpoints/[ENDPOINT]";
            string deployedModelId = "";
            IDictionary<string, int> trafficSplit = new Dictionary<string, int> { { "", 0 }, };
            // Make the request
            Operation<UndeployModelResponse, UndeployModelOperationMetadata> response = endpointServiceClient.UndeployModel(endpoint, deployedModelId, trafficSplit);

            // Poll until the returned long-running operation is complete
            Operation<UndeployModelResponse, UndeployModelOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            UndeployModelResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<UndeployModelResponse, UndeployModelOperationMetadata> retrievedResponse = endpointServiceClient.PollOnceUndeployModel(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                UndeployModelResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UndeployModelAsync</summary>
        public async Task UndeployModelAsync()
        {
            // Snippet: UndeployModelAsync(string, string, IDictionary<string,int>, CallSettings)
            // Additional: UndeployModelAsync(string, string, IDictionary<string,int>, CancellationToken)
            // Create client
            EndpointServiceClient endpointServiceClient = await EndpointServiceClient.CreateAsync();
            // Initialize request argument(s)
            string endpoint = "projects/[PROJECT]/locations/[LOCATION]/endpoints/[ENDPOINT]";
            string deployedModelId = "";
            IDictionary<string, int> trafficSplit = new Dictionary<string, int> { { "", 0 }, };
            // Make the request
            Operation<UndeployModelResponse, UndeployModelOperationMetadata> response = await endpointServiceClient.UndeployModelAsync(endpoint, deployedModelId, trafficSplit);

            // Poll until the returned long-running operation is complete
            Operation<UndeployModelResponse, UndeployModelOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            UndeployModelResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<UndeployModelResponse, UndeployModelOperationMetadata> retrievedResponse = await endpointServiceClient.PollOnceUndeployModelAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                UndeployModelResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UndeployModel</summary>
        public void UndeployModelResourceNames()
        {
            // Snippet: UndeployModel(EndpointName, string, IDictionary<string,int>, CallSettings)
            // Create client
            EndpointServiceClient endpointServiceClient = EndpointServiceClient.Create();
            // Initialize request argument(s)
            EndpointName endpoint = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]");
            string deployedModelId = "";
            IDictionary<string, int> trafficSplit = new Dictionary<string, int> { { "", 0 }, };
            // Make the request
            Operation<UndeployModelResponse, UndeployModelOperationMetadata> response = endpointServiceClient.UndeployModel(endpoint, deployedModelId, trafficSplit);

            // Poll until the returned long-running operation is complete
            Operation<UndeployModelResponse, UndeployModelOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            UndeployModelResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<UndeployModelResponse, UndeployModelOperationMetadata> retrievedResponse = endpointServiceClient.PollOnceUndeployModel(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                UndeployModelResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UndeployModelAsync</summary>
        public async Task UndeployModelResourceNamesAsync()
        {
            // Snippet: UndeployModelAsync(EndpointName, string, IDictionary<string,int>, CallSettings)
            // Additional: UndeployModelAsync(EndpointName, string, IDictionary<string,int>, CancellationToken)
            // Create client
            EndpointServiceClient endpointServiceClient = await EndpointServiceClient.CreateAsync();
            // Initialize request argument(s)
            EndpointName endpoint = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]");
            string deployedModelId = "";
            IDictionary<string, int> trafficSplit = new Dictionary<string, int> { { "", 0 }, };
            // Make the request
            Operation<UndeployModelResponse, UndeployModelOperationMetadata> response = await endpointServiceClient.UndeployModelAsync(endpoint, deployedModelId, trafficSplit);

            // Poll until the returned long-running operation is complete
            Operation<UndeployModelResponse, UndeployModelOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            UndeployModelResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<UndeployModelResponse, UndeployModelOperationMetadata> retrievedResponse = await endpointServiceClient.PollOnceUndeployModelAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                UndeployModelResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for MutateDeployedModel</summary>
        public void MutateDeployedModelRequestObject()
        {
            // Snippet: MutateDeployedModel(MutateDeployedModelRequest, CallSettings)
            // Create client
            EndpointServiceClient endpointServiceClient = EndpointServiceClient.Create();
            // Initialize request argument(s)
            MutateDeployedModelRequest request = new MutateDeployedModelRequest
            {
                EndpointAsEndpointName = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]"),
                DeployedModel = new DeployedModel(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<MutateDeployedModelResponse, MutateDeployedModelOperationMetadata> response = endpointServiceClient.MutateDeployedModel(request);

            // Poll until the returned long-running operation is complete
            Operation<MutateDeployedModelResponse, MutateDeployedModelOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            MutateDeployedModelResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MutateDeployedModelResponse, MutateDeployedModelOperationMetadata> retrievedResponse = endpointServiceClient.PollOnceMutateDeployedModel(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MutateDeployedModelResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for MutateDeployedModelAsync</summary>
        public async Task MutateDeployedModelRequestObjectAsync()
        {
            // Snippet: MutateDeployedModelAsync(MutateDeployedModelRequest, CallSettings)
            // Additional: MutateDeployedModelAsync(MutateDeployedModelRequest, CancellationToken)
            // Create client
            EndpointServiceClient endpointServiceClient = await EndpointServiceClient.CreateAsync();
            // Initialize request argument(s)
            MutateDeployedModelRequest request = new MutateDeployedModelRequest
            {
                EndpointAsEndpointName = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]"),
                DeployedModel = new DeployedModel(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<MutateDeployedModelResponse, MutateDeployedModelOperationMetadata> response = await endpointServiceClient.MutateDeployedModelAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<MutateDeployedModelResponse, MutateDeployedModelOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            MutateDeployedModelResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MutateDeployedModelResponse, MutateDeployedModelOperationMetadata> retrievedResponse = await endpointServiceClient.PollOnceMutateDeployedModelAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MutateDeployedModelResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for MutateDeployedModel</summary>
        public void MutateDeployedModel()
        {
            // Snippet: MutateDeployedModel(string, DeployedModel, FieldMask, CallSettings)
            // Create client
            EndpointServiceClient endpointServiceClient = EndpointServiceClient.Create();
            // Initialize request argument(s)
            string endpoint = "projects/[PROJECT]/locations/[LOCATION]/endpoints/[ENDPOINT]";
            DeployedModel deployedModel = new DeployedModel();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<MutateDeployedModelResponse, MutateDeployedModelOperationMetadata> response = endpointServiceClient.MutateDeployedModel(endpoint, deployedModel, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<MutateDeployedModelResponse, MutateDeployedModelOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            MutateDeployedModelResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MutateDeployedModelResponse, MutateDeployedModelOperationMetadata> retrievedResponse = endpointServiceClient.PollOnceMutateDeployedModel(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MutateDeployedModelResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for MutateDeployedModelAsync</summary>
        public async Task MutateDeployedModelAsync()
        {
            // Snippet: MutateDeployedModelAsync(string, DeployedModel, FieldMask, CallSettings)
            // Additional: MutateDeployedModelAsync(string, DeployedModel, FieldMask, CancellationToken)
            // Create client
            EndpointServiceClient endpointServiceClient = await EndpointServiceClient.CreateAsync();
            // Initialize request argument(s)
            string endpoint = "projects/[PROJECT]/locations/[LOCATION]/endpoints/[ENDPOINT]";
            DeployedModel deployedModel = new DeployedModel();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<MutateDeployedModelResponse, MutateDeployedModelOperationMetadata> response = await endpointServiceClient.MutateDeployedModelAsync(endpoint, deployedModel, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<MutateDeployedModelResponse, MutateDeployedModelOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            MutateDeployedModelResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MutateDeployedModelResponse, MutateDeployedModelOperationMetadata> retrievedResponse = await endpointServiceClient.PollOnceMutateDeployedModelAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MutateDeployedModelResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for MutateDeployedModel</summary>
        public void MutateDeployedModelResourceNames()
        {
            // Snippet: MutateDeployedModel(EndpointName, DeployedModel, FieldMask, CallSettings)
            // Create client
            EndpointServiceClient endpointServiceClient = EndpointServiceClient.Create();
            // Initialize request argument(s)
            EndpointName endpoint = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]");
            DeployedModel deployedModel = new DeployedModel();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<MutateDeployedModelResponse, MutateDeployedModelOperationMetadata> response = endpointServiceClient.MutateDeployedModel(endpoint, deployedModel, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<MutateDeployedModelResponse, MutateDeployedModelOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            MutateDeployedModelResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MutateDeployedModelResponse, MutateDeployedModelOperationMetadata> retrievedResponse = endpointServiceClient.PollOnceMutateDeployedModel(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MutateDeployedModelResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for MutateDeployedModelAsync</summary>
        public async Task MutateDeployedModelResourceNamesAsync()
        {
            // Snippet: MutateDeployedModelAsync(EndpointName, DeployedModel, FieldMask, CallSettings)
            // Additional: MutateDeployedModelAsync(EndpointName, DeployedModel, FieldMask, CancellationToken)
            // Create client
            EndpointServiceClient endpointServiceClient = await EndpointServiceClient.CreateAsync();
            // Initialize request argument(s)
            EndpointName endpoint = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]");
            DeployedModel deployedModel = new DeployedModel();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<MutateDeployedModelResponse, MutateDeployedModelOperationMetadata> response = await endpointServiceClient.MutateDeployedModelAsync(endpoint, deployedModel, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<MutateDeployedModelResponse, MutateDeployedModelOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            MutateDeployedModelResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MutateDeployedModelResponse, MutateDeployedModelOperationMetadata> retrievedResponse = await endpointServiceClient.PollOnceMutateDeployedModelAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MutateDeployedModelResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
