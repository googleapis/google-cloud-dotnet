// Copyright 2026 Google LLC
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
    using Google.Cloud.NetworkServices.V1Beta1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedNetworkServicesClientSnippets
    {
        /// <summary>Snippet for ListEndpointPolicies</summary>
        public void ListEndpointPoliciesRequestObject()
        {
            // Snippet: ListEndpointPolicies(ListEndpointPoliciesRequest, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            ListEndpointPoliciesRequest request = new ListEndpointPoliciesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedEnumerable<ListEndpointPoliciesResponse, EndpointPolicy> response = networkServicesClient.ListEndpointPolicies(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (EndpointPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEndpointPoliciesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EndpointPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EndpointPolicy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EndpointPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEndpointPoliciesAsync</summary>
        public async Task ListEndpointPoliciesRequestObjectAsync()
        {
            // Snippet: ListEndpointPoliciesAsync(ListEndpointPoliciesRequest, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            ListEndpointPoliciesRequest request = new ListEndpointPoliciesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListEndpointPoliciesResponse, EndpointPolicy> response = networkServicesClient.ListEndpointPoliciesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (EndpointPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListEndpointPoliciesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EndpointPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EndpointPolicy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EndpointPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEndpointPolicies</summary>
        public void ListEndpointPolicies()
        {
            // Snippet: ListEndpointPolicies(string, string, int?, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListEndpointPoliciesResponse, EndpointPolicy> response = networkServicesClient.ListEndpointPolicies(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (EndpointPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEndpointPoliciesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EndpointPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EndpointPolicy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EndpointPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEndpointPoliciesAsync</summary>
        public async Task ListEndpointPoliciesAsync()
        {
            // Snippet: ListEndpointPoliciesAsync(string, string, int?, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListEndpointPoliciesResponse, EndpointPolicy> response = networkServicesClient.ListEndpointPoliciesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (EndpointPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListEndpointPoliciesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EndpointPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EndpointPolicy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EndpointPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEndpointPolicies</summary>
        public void ListEndpointPoliciesResourceNames()
        {
            // Snippet: ListEndpointPolicies(LocationName, string, int?, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListEndpointPoliciesResponse, EndpointPolicy> response = networkServicesClient.ListEndpointPolicies(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (EndpointPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEndpointPoliciesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EndpointPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EndpointPolicy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EndpointPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEndpointPoliciesAsync</summary>
        public async Task ListEndpointPoliciesResourceNamesAsync()
        {
            // Snippet: ListEndpointPoliciesAsync(LocationName, string, int?, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListEndpointPoliciesResponse, EndpointPolicy> response = networkServicesClient.ListEndpointPoliciesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (EndpointPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListEndpointPoliciesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EndpointPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EndpointPolicy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EndpointPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetEndpointPolicy</summary>
        public void GetEndpointPolicyRequestObject()
        {
            // Snippet: GetEndpointPolicy(GetEndpointPolicyRequest, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            GetEndpointPolicyRequest request = new GetEndpointPolicyRequest
            {
                EndpointPolicyName = EndpointPolicyName.FromProjectLocationEndpointPolicy("[PROJECT]", "[LOCATION]", "[ENDPOINT_POLICY]"),
            };
            // Make the request
            EndpointPolicy response = networkServicesClient.GetEndpointPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for GetEndpointPolicyAsync</summary>
        public async Task GetEndpointPolicyRequestObjectAsync()
        {
            // Snippet: GetEndpointPolicyAsync(GetEndpointPolicyRequest, CallSettings)
            // Additional: GetEndpointPolicyAsync(GetEndpointPolicyRequest, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            GetEndpointPolicyRequest request = new GetEndpointPolicyRequest
            {
                EndpointPolicyName = EndpointPolicyName.FromProjectLocationEndpointPolicy("[PROJECT]", "[LOCATION]", "[ENDPOINT_POLICY]"),
            };
            // Make the request
            EndpointPolicy response = await networkServicesClient.GetEndpointPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetEndpointPolicy</summary>
        public void GetEndpointPolicy()
        {
            // Snippet: GetEndpointPolicy(string, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/endpointPolicies/[ENDPOINT_POLICY]";
            // Make the request
            EndpointPolicy response = networkServicesClient.GetEndpointPolicy(name);
            // End snippet
        }

        /// <summary>Snippet for GetEndpointPolicyAsync</summary>
        public async Task GetEndpointPolicyAsync()
        {
            // Snippet: GetEndpointPolicyAsync(string, CallSettings)
            // Additional: GetEndpointPolicyAsync(string, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/endpointPolicies/[ENDPOINT_POLICY]";
            // Make the request
            EndpointPolicy response = await networkServicesClient.GetEndpointPolicyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetEndpointPolicy</summary>
        public void GetEndpointPolicyResourceNames()
        {
            // Snippet: GetEndpointPolicy(EndpointPolicyName, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            EndpointPolicyName name = EndpointPolicyName.FromProjectLocationEndpointPolicy("[PROJECT]", "[LOCATION]", "[ENDPOINT_POLICY]");
            // Make the request
            EndpointPolicy response = networkServicesClient.GetEndpointPolicy(name);
            // End snippet
        }

        /// <summary>Snippet for GetEndpointPolicyAsync</summary>
        public async Task GetEndpointPolicyResourceNamesAsync()
        {
            // Snippet: GetEndpointPolicyAsync(EndpointPolicyName, CallSettings)
            // Additional: GetEndpointPolicyAsync(EndpointPolicyName, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            EndpointPolicyName name = EndpointPolicyName.FromProjectLocationEndpointPolicy("[PROJECT]", "[LOCATION]", "[ENDPOINT_POLICY]");
            // Make the request
            EndpointPolicy response = await networkServicesClient.GetEndpointPolicyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateEndpointPolicy</summary>
        public void CreateEndpointPolicyRequestObject()
        {
            // Snippet: CreateEndpointPolicy(CreateEndpointPolicyRequest, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            CreateEndpointPolicyRequest request = new CreateEndpointPolicyRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                EndpointPolicyId = "",
                EndpointPolicy = new EndpointPolicy(),
            };
            // Make the request
            Operation<EndpointPolicy, OperationMetadata> response = networkServicesClient.CreateEndpointPolicy(request);

            // Poll until the returned long-running operation is complete
            Operation<EndpointPolicy, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            EndpointPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<EndpointPolicy, OperationMetadata> retrievedResponse = networkServicesClient.PollOnceCreateEndpointPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                EndpointPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateEndpointPolicyAsync</summary>
        public async Task CreateEndpointPolicyRequestObjectAsync()
        {
            // Snippet: CreateEndpointPolicyAsync(CreateEndpointPolicyRequest, CallSettings)
            // Additional: CreateEndpointPolicyAsync(CreateEndpointPolicyRequest, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            CreateEndpointPolicyRequest request = new CreateEndpointPolicyRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                EndpointPolicyId = "",
                EndpointPolicy = new EndpointPolicy(),
            };
            // Make the request
            Operation<EndpointPolicy, OperationMetadata> response = await networkServicesClient.CreateEndpointPolicyAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<EndpointPolicy, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            EndpointPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<EndpointPolicy, OperationMetadata> retrievedResponse = await networkServicesClient.PollOnceCreateEndpointPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                EndpointPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateEndpointPolicy</summary>
        public void CreateEndpointPolicy()
        {
            // Snippet: CreateEndpointPolicy(string, EndpointPolicy, string, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            EndpointPolicy endpointPolicy = new EndpointPolicy();
            string endpointPolicyId = "";
            // Make the request
            Operation<EndpointPolicy, OperationMetadata> response = networkServicesClient.CreateEndpointPolicy(parent, endpointPolicy, endpointPolicyId);

            // Poll until the returned long-running operation is complete
            Operation<EndpointPolicy, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            EndpointPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<EndpointPolicy, OperationMetadata> retrievedResponse = networkServicesClient.PollOnceCreateEndpointPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                EndpointPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateEndpointPolicyAsync</summary>
        public async Task CreateEndpointPolicyAsync()
        {
            // Snippet: CreateEndpointPolicyAsync(string, EndpointPolicy, string, CallSettings)
            // Additional: CreateEndpointPolicyAsync(string, EndpointPolicy, string, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            EndpointPolicy endpointPolicy = new EndpointPolicy();
            string endpointPolicyId = "";
            // Make the request
            Operation<EndpointPolicy, OperationMetadata> response = await networkServicesClient.CreateEndpointPolicyAsync(parent, endpointPolicy, endpointPolicyId);

            // Poll until the returned long-running operation is complete
            Operation<EndpointPolicy, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            EndpointPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<EndpointPolicy, OperationMetadata> retrievedResponse = await networkServicesClient.PollOnceCreateEndpointPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                EndpointPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateEndpointPolicy</summary>
        public void CreateEndpointPolicyResourceNames()
        {
            // Snippet: CreateEndpointPolicy(LocationName, EndpointPolicy, string, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            EndpointPolicy endpointPolicy = new EndpointPolicy();
            string endpointPolicyId = "";
            // Make the request
            Operation<EndpointPolicy, OperationMetadata> response = networkServicesClient.CreateEndpointPolicy(parent, endpointPolicy, endpointPolicyId);

            // Poll until the returned long-running operation is complete
            Operation<EndpointPolicy, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            EndpointPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<EndpointPolicy, OperationMetadata> retrievedResponse = networkServicesClient.PollOnceCreateEndpointPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                EndpointPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateEndpointPolicyAsync</summary>
        public async Task CreateEndpointPolicyResourceNamesAsync()
        {
            // Snippet: CreateEndpointPolicyAsync(LocationName, EndpointPolicy, string, CallSettings)
            // Additional: CreateEndpointPolicyAsync(LocationName, EndpointPolicy, string, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            EndpointPolicy endpointPolicy = new EndpointPolicy();
            string endpointPolicyId = "";
            // Make the request
            Operation<EndpointPolicy, OperationMetadata> response = await networkServicesClient.CreateEndpointPolicyAsync(parent, endpointPolicy, endpointPolicyId);

            // Poll until the returned long-running operation is complete
            Operation<EndpointPolicy, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            EndpointPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<EndpointPolicy, OperationMetadata> retrievedResponse = await networkServicesClient.PollOnceCreateEndpointPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                EndpointPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateEndpointPolicy</summary>
        public void UpdateEndpointPolicyRequestObject()
        {
            // Snippet: UpdateEndpointPolicy(UpdateEndpointPolicyRequest, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            UpdateEndpointPolicyRequest request = new UpdateEndpointPolicyRequest
            {
                UpdateMask = new FieldMask(),
                EndpointPolicy = new EndpointPolicy(),
            };
            // Make the request
            Operation<EndpointPolicy, OperationMetadata> response = networkServicesClient.UpdateEndpointPolicy(request);

            // Poll until the returned long-running operation is complete
            Operation<EndpointPolicy, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            EndpointPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<EndpointPolicy, OperationMetadata> retrievedResponse = networkServicesClient.PollOnceUpdateEndpointPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                EndpointPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateEndpointPolicyAsync</summary>
        public async Task UpdateEndpointPolicyRequestObjectAsync()
        {
            // Snippet: UpdateEndpointPolicyAsync(UpdateEndpointPolicyRequest, CallSettings)
            // Additional: UpdateEndpointPolicyAsync(UpdateEndpointPolicyRequest, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            UpdateEndpointPolicyRequest request = new UpdateEndpointPolicyRequest
            {
                UpdateMask = new FieldMask(),
                EndpointPolicy = new EndpointPolicy(),
            };
            // Make the request
            Operation<EndpointPolicy, OperationMetadata> response = await networkServicesClient.UpdateEndpointPolicyAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<EndpointPolicy, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            EndpointPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<EndpointPolicy, OperationMetadata> retrievedResponse = await networkServicesClient.PollOnceUpdateEndpointPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                EndpointPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateEndpointPolicy</summary>
        public void UpdateEndpointPolicy()
        {
            // Snippet: UpdateEndpointPolicy(EndpointPolicy, FieldMask, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            EndpointPolicy endpointPolicy = new EndpointPolicy();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<EndpointPolicy, OperationMetadata> response = networkServicesClient.UpdateEndpointPolicy(endpointPolicy, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<EndpointPolicy, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            EndpointPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<EndpointPolicy, OperationMetadata> retrievedResponse = networkServicesClient.PollOnceUpdateEndpointPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                EndpointPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateEndpointPolicyAsync</summary>
        public async Task UpdateEndpointPolicyAsync()
        {
            // Snippet: UpdateEndpointPolicyAsync(EndpointPolicy, FieldMask, CallSettings)
            // Additional: UpdateEndpointPolicyAsync(EndpointPolicy, FieldMask, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            EndpointPolicy endpointPolicy = new EndpointPolicy();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<EndpointPolicy, OperationMetadata> response = await networkServicesClient.UpdateEndpointPolicyAsync(endpointPolicy, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<EndpointPolicy, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            EndpointPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<EndpointPolicy, OperationMetadata> retrievedResponse = await networkServicesClient.PollOnceUpdateEndpointPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                EndpointPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteEndpointPolicy</summary>
        public void DeleteEndpointPolicyRequestObject()
        {
            // Snippet: DeleteEndpointPolicy(DeleteEndpointPolicyRequest, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            DeleteEndpointPolicyRequest request = new DeleteEndpointPolicyRequest
            {
                EndpointPolicyName = EndpointPolicyName.FromProjectLocationEndpointPolicy("[PROJECT]", "[LOCATION]", "[ENDPOINT_POLICY]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = networkServicesClient.DeleteEndpointPolicy(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = networkServicesClient.PollOnceDeleteEndpointPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteEndpointPolicyAsync</summary>
        public async Task DeleteEndpointPolicyRequestObjectAsync()
        {
            // Snippet: DeleteEndpointPolicyAsync(DeleteEndpointPolicyRequest, CallSettings)
            // Additional: DeleteEndpointPolicyAsync(DeleteEndpointPolicyRequest, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            DeleteEndpointPolicyRequest request = new DeleteEndpointPolicyRequest
            {
                EndpointPolicyName = EndpointPolicyName.FromProjectLocationEndpointPolicy("[PROJECT]", "[LOCATION]", "[ENDPOINT_POLICY]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await networkServicesClient.DeleteEndpointPolicyAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await networkServicesClient.PollOnceDeleteEndpointPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteEndpointPolicy</summary>
        public void DeleteEndpointPolicy()
        {
            // Snippet: DeleteEndpointPolicy(string, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/endpointPolicies/[ENDPOINT_POLICY]";
            // Make the request
            Operation<Empty, OperationMetadata> response = networkServicesClient.DeleteEndpointPolicy(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = networkServicesClient.PollOnceDeleteEndpointPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteEndpointPolicyAsync</summary>
        public async Task DeleteEndpointPolicyAsync()
        {
            // Snippet: DeleteEndpointPolicyAsync(string, CallSettings)
            // Additional: DeleteEndpointPolicyAsync(string, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/endpointPolicies/[ENDPOINT_POLICY]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await networkServicesClient.DeleteEndpointPolicyAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await networkServicesClient.PollOnceDeleteEndpointPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteEndpointPolicy</summary>
        public void DeleteEndpointPolicyResourceNames()
        {
            // Snippet: DeleteEndpointPolicy(EndpointPolicyName, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            EndpointPolicyName name = EndpointPolicyName.FromProjectLocationEndpointPolicy("[PROJECT]", "[LOCATION]", "[ENDPOINT_POLICY]");
            // Make the request
            Operation<Empty, OperationMetadata> response = networkServicesClient.DeleteEndpointPolicy(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = networkServicesClient.PollOnceDeleteEndpointPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteEndpointPolicyAsync</summary>
        public async Task DeleteEndpointPolicyResourceNamesAsync()
        {
            // Snippet: DeleteEndpointPolicyAsync(EndpointPolicyName, CallSettings)
            // Additional: DeleteEndpointPolicyAsync(EndpointPolicyName, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            EndpointPolicyName name = EndpointPolicyName.FromProjectLocationEndpointPolicy("[PROJECT]", "[LOCATION]", "[ENDPOINT_POLICY]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await networkServicesClient.DeleteEndpointPolicyAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await networkServicesClient.PollOnceDeleteEndpointPolicyAsync(operationName);
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
