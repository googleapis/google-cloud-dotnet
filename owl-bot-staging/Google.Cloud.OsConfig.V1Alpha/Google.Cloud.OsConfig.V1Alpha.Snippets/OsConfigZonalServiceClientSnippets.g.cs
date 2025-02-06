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

namespace GoogleCSharpSnippets
{
    using Google.Api.Gax;
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.OsConfig.V1Alpha;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedOsConfigZonalServiceClientSnippets
    {
        /// <summary>Snippet for CreateOSPolicyAssignment</summary>
        public void CreateOSPolicyAssignmentRequestObject()
        {
            // Snippet: CreateOSPolicyAssignment(CreateOSPolicyAssignmentRequest, CallSettings)
            // Create client
            OsConfigZonalServiceClient osConfigZonalServiceClient = OsConfigZonalServiceClient.Create();
            // Initialize request argument(s)
            CreateOSPolicyAssignmentRequest request = new CreateOSPolicyAssignmentRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                OsPolicyAssignment = new OSPolicyAssignment(),
                OsPolicyAssignmentId = "",
            };
            // Make the request
            Operation<OSPolicyAssignment, OSPolicyAssignmentOperationMetadata> response = osConfigZonalServiceClient.CreateOSPolicyAssignment(request);

            // Poll until the returned long-running operation is complete
            Operation<OSPolicyAssignment, OSPolicyAssignmentOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            OSPolicyAssignment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<OSPolicyAssignment, OSPolicyAssignmentOperationMetadata> retrievedResponse = osConfigZonalServiceClient.PollOnceCreateOSPolicyAssignment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                OSPolicyAssignment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateOSPolicyAssignmentAsync</summary>
        public async Task CreateOSPolicyAssignmentRequestObjectAsync()
        {
            // Snippet: CreateOSPolicyAssignmentAsync(CreateOSPolicyAssignmentRequest, CallSettings)
            // Additional: CreateOSPolicyAssignmentAsync(CreateOSPolicyAssignmentRequest, CancellationToken)
            // Create client
            OsConfigZonalServiceClient osConfigZonalServiceClient = await OsConfigZonalServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateOSPolicyAssignmentRequest request = new CreateOSPolicyAssignmentRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                OsPolicyAssignment = new OSPolicyAssignment(),
                OsPolicyAssignmentId = "",
            };
            // Make the request
            Operation<OSPolicyAssignment, OSPolicyAssignmentOperationMetadata> response = await osConfigZonalServiceClient.CreateOSPolicyAssignmentAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<OSPolicyAssignment, OSPolicyAssignmentOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            OSPolicyAssignment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<OSPolicyAssignment, OSPolicyAssignmentOperationMetadata> retrievedResponse = await osConfigZonalServiceClient.PollOnceCreateOSPolicyAssignmentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                OSPolicyAssignment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateOSPolicyAssignment</summary>
        public void CreateOSPolicyAssignment()
        {
            // Snippet: CreateOSPolicyAssignment(string, OSPolicyAssignment, string, CallSettings)
            // Create client
            OsConfigZonalServiceClient osConfigZonalServiceClient = OsConfigZonalServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            OSPolicyAssignment osPolicyAssignment = new OSPolicyAssignment();
            string osPolicyAssignmentId = "";
            // Make the request
            Operation<OSPolicyAssignment, OSPolicyAssignmentOperationMetadata> response = osConfigZonalServiceClient.CreateOSPolicyAssignment(parent, osPolicyAssignment, osPolicyAssignmentId);

            // Poll until the returned long-running operation is complete
            Operation<OSPolicyAssignment, OSPolicyAssignmentOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            OSPolicyAssignment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<OSPolicyAssignment, OSPolicyAssignmentOperationMetadata> retrievedResponse = osConfigZonalServiceClient.PollOnceCreateOSPolicyAssignment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                OSPolicyAssignment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateOSPolicyAssignmentAsync</summary>
        public async Task CreateOSPolicyAssignmentAsync()
        {
            // Snippet: CreateOSPolicyAssignmentAsync(string, OSPolicyAssignment, string, CallSettings)
            // Additional: CreateOSPolicyAssignmentAsync(string, OSPolicyAssignment, string, CancellationToken)
            // Create client
            OsConfigZonalServiceClient osConfigZonalServiceClient = await OsConfigZonalServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            OSPolicyAssignment osPolicyAssignment = new OSPolicyAssignment();
            string osPolicyAssignmentId = "";
            // Make the request
            Operation<OSPolicyAssignment, OSPolicyAssignmentOperationMetadata> response = await osConfigZonalServiceClient.CreateOSPolicyAssignmentAsync(parent, osPolicyAssignment, osPolicyAssignmentId);

            // Poll until the returned long-running operation is complete
            Operation<OSPolicyAssignment, OSPolicyAssignmentOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            OSPolicyAssignment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<OSPolicyAssignment, OSPolicyAssignmentOperationMetadata> retrievedResponse = await osConfigZonalServiceClient.PollOnceCreateOSPolicyAssignmentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                OSPolicyAssignment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateOSPolicyAssignment</summary>
        public void CreateOSPolicyAssignmentResourceNames()
        {
            // Snippet: CreateOSPolicyAssignment(LocationName, OSPolicyAssignment, string, CallSettings)
            // Create client
            OsConfigZonalServiceClient osConfigZonalServiceClient = OsConfigZonalServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            OSPolicyAssignment osPolicyAssignment = new OSPolicyAssignment();
            string osPolicyAssignmentId = "";
            // Make the request
            Operation<OSPolicyAssignment, OSPolicyAssignmentOperationMetadata> response = osConfigZonalServiceClient.CreateOSPolicyAssignment(parent, osPolicyAssignment, osPolicyAssignmentId);

            // Poll until the returned long-running operation is complete
            Operation<OSPolicyAssignment, OSPolicyAssignmentOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            OSPolicyAssignment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<OSPolicyAssignment, OSPolicyAssignmentOperationMetadata> retrievedResponse = osConfigZonalServiceClient.PollOnceCreateOSPolicyAssignment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                OSPolicyAssignment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateOSPolicyAssignmentAsync</summary>
        public async Task CreateOSPolicyAssignmentResourceNamesAsync()
        {
            // Snippet: CreateOSPolicyAssignmentAsync(LocationName, OSPolicyAssignment, string, CallSettings)
            // Additional: CreateOSPolicyAssignmentAsync(LocationName, OSPolicyAssignment, string, CancellationToken)
            // Create client
            OsConfigZonalServiceClient osConfigZonalServiceClient = await OsConfigZonalServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            OSPolicyAssignment osPolicyAssignment = new OSPolicyAssignment();
            string osPolicyAssignmentId = "";
            // Make the request
            Operation<OSPolicyAssignment, OSPolicyAssignmentOperationMetadata> response = await osConfigZonalServiceClient.CreateOSPolicyAssignmentAsync(parent, osPolicyAssignment, osPolicyAssignmentId);

            // Poll until the returned long-running operation is complete
            Operation<OSPolicyAssignment, OSPolicyAssignmentOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            OSPolicyAssignment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<OSPolicyAssignment, OSPolicyAssignmentOperationMetadata> retrievedResponse = await osConfigZonalServiceClient.PollOnceCreateOSPolicyAssignmentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                OSPolicyAssignment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateOSPolicyAssignment</summary>
        public void UpdateOSPolicyAssignmentRequestObject()
        {
            // Snippet: UpdateOSPolicyAssignment(UpdateOSPolicyAssignmentRequest, CallSettings)
            // Create client
            OsConfigZonalServiceClient osConfigZonalServiceClient = OsConfigZonalServiceClient.Create();
            // Initialize request argument(s)
            UpdateOSPolicyAssignmentRequest request = new UpdateOSPolicyAssignmentRequest
            {
                OsPolicyAssignment = new OSPolicyAssignment(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<OSPolicyAssignment, OSPolicyAssignmentOperationMetadata> response = osConfigZonalServiceClient.UpdateOSPolicyAssignment(request);

            // Poll until the returned long-running operation is complete
            Operation<OSPolicyAssignment, OSPolicyAssignmentOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            OSPolicyAssignment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<OSPolicyAssignment, OSPolicyAssignmentOperationMetadata> retrievedResponse = osConfigZonalServiceClient.PollOnceUpdateOSPolicyAssignment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                OSPolicyAssignment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateOSPolicyAssignmentAsync</summary>
        public async Task UpdateOSPolicyAssignmentRequestObjectAsync()
        {
            // Snippet: UpdateOSPolicyAssignmentAsync(UpdateOSPolicyAssignmentRequest, CallSettings)
            // Additional: UpdateOSPolicyAssignmentAsync(UpdateOSPolicyAssignmentRequest, CancellationToken)
            // Create client
            OsConfigZonalServiceClient osConfigZonalServiceClient = await OsConfigZonalServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateOSPolicyAssignmentRequest request = new UpdateOSPolicyAssignmentRequest
            {
                OsPolicyAssignment = new OSPolicyAssignment(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<OSPolicyAssignment, OSPolicyAssignmentOperationMetadata> response = await osConfigZonalServiceClient.UpdateOSPolicyAssignmentAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<OSPolicyAssignment, OSPolicyAssignmentOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            OSPolicyAssignment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<OSPolicyAssignment, OSPolicyAssignmentOperationMetadata> retrievedResponse = await osConfigZonalServiceClient.PollOnceUpdateOSPolicyAssignmentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                OSPolicyAssignment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateOSPolicyAssignment</summary>
        public void UpdateOSPolicyAssignment()
        {
            // Snippet: UpdateOSPolicyAssignment(OSPolicyAssignment, FieldMask, CallSettings)
            // Create client
            OsConfigZonalServiceClient osConfigZonalServiceClient = OsConfigZonalServiceClient.Create();
            // Initialize request argument(s)
            OSPolicyAssignment osPolicyAssignment = new OSPolicyAssignment();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<OSPolicyAssignment, OSPolicyAssignmentOperationMetadata> response = osConfigZonalServiceClient.UpdateOSPolicyAssignment(osPolicyAssignment, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<OSPolicyAssignment, OSPolicyAssignmentOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            OSPolicyAssignment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<OSPolicyAssignment, OSPolicyAssignmentOperationMetadata> retrievedResponse = osConfigZonalServiceClient.PollOnceUpdateOSPolicyAssignment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                OSPolicyAssignment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateOSPolicyAssignmentAsync</summary>
        public async Task UpdateOSPolicyAssignmentAsync()
        {
            // Snippet: UpdateOSPolicyAssignmentAsync(OSPolicyAssignment, FieldMask, CallSettings)
            // Additional: UpdateOSPolicyAssignmentAsync(OSPolicyAssignment, FieldMask, CancellationToken)
            // Create client
            OsConfigZonalServiceClient osConfigZonalServiceClient = await OsConfigZonalServiceClient.CreateAsync();
            // Initialize request argument(s)
            OSPolicyAssignment osPolicyAssignment = new OSPolicyAssignment();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<OSPolicyAssignment, OSPolicyAssignmentOperationMetadata> response = await osConfigZonalServiceClient.UpdateOSPolicyAssignmentAsync(osPolicyAssignment, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<OSPolicyAssignment, OSPolicyAssignmentOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            OSPolicyAssignment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<OSPolicyAssignment, OSPolicyAssignmentOperationMetadata> retrievedResponse = await osConfigZonalServiceClient.PollOnceUpdateOSPolicyAssignmentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                OSPolicyAssignment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetOSPolicyAssignment</summary>
        public void GetOSPolicyAssignmentRequestObject()
        {
            // Snippet: GetOSPolicyAssignment(GetOSPolicyAssignmentRequest, CallSettings)
            // Create client
            OsConfigZonalServiceClient osConfigZonalServiceClient = OsConfigZonalServiceClient.Create();
            // Initialize request argument(s)
            GetOSPolicyAssignmentRequest request = new GetOSPolicyAssignmentRequest
            {
                OSPolicyAssignmentName = OSPolicyAssignmentName.FromProjectLocationOsPolicyAssignment("[PROJECT]", "[LOCATION]", "[OS_POLICY_ASSIGNMENT]"),
            };
            // Make the request
            OSPolicyAssignment response = osConfigZonalServiceClient.GetOSPolicyAssignment(request);
            // End snippet
        }

        /// <summary>Snippet for GetOSPolicyAssignmentAsync</summary>
        public async Task GetOSPolicyAssignmentRequestObjectAsync()
        {
            // Snippet: GetOSPolicyAssignmentAsync(GetOSPolicyAssignmentRequest, CallSettings)
            // Additional: GetOSPolicyAssignmentAsync(GetOSPolicyAssignmentRequest, CancellationToken)
            // Create client
            OsConfigZonalServiceClient osConfigZonalServiceClient = await OsConfigZonalServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetOSPolicyAssignmentRequest request = new GetOSPolicyAssignmentRequest
            {
                OSPolicyAssignmentName = OSPolicyAssignmentName.FromProjectLocationOsPolicyAssignment("[PROJECT]", "[LOCATION]", "[OS_POLICY_ASSIGNMENT]"),
            };
            // Make the request
            OSPolicyAssignment response = await osConfigZonalServiceClient.GetOSPolicyAssignmentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetOSPolicyAssignment</summary>
        public void GetOSPolicyAssignment()
        {
            // Snippet: GetOSPolicyAssignment(string, CallSettings)
            // Create client
            OsConfigZonalServiceClient osConfigZonalServiceClient = OsConfigZonalServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/osPolicyAssignments/[OS_POLICY_ASSIGNMENT]";
            // Make the request
            OSPolicyAssignment response = osConfigZonalServiceClient.GetOSPolicyAssignment(name);
            // End snippet
        }

        /// <summary>Snippet for GetOSPolicyAssignmentAsync</summary>
        public async Task GetOSPolicyAssignmentAsync()
        {
            // Snippet: GetOSPolicyAssignmentAsync(string, CallSettings)
            // Additional: GetOSPolicyAssignmentAsync(string, CancellationToken)
            // Create client
            OsConfigZonalServiceClient osConfigZonalServiceClient = await OsConfigZonalServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/osPolicyAssignments/[OS_POLICY_ASSIGNMENT]";
            // Make the request
            OSPolicyAssignment response = await osConfigZonalServiceClient.GetOSPolicyAssignmentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetOSPolicyAssignment</summary>
        public void GetOSPolicyAssignmentResourceNames()
        {
            // Snippet: GetOSPolicyAssignment(OSPolicyAssignmentName, CallSettings)
            // Create client
            OsConfigZonalServiceClient osConfigZonalServiceClient = OsConfigZonalServiceClient.Create();
            // Initialize request argument(s)
            OSPolicyAssignmentName name = OSPolicyAssignmentName.FromProjectLocationOsPolicyAssignment("[PROJECT]", "[LOCATION]", "[OS_POLICY_ASSIGNMENT]");
            // Make the request
            OSPolicyAssignment response = osConfigZonalServiceClient.GetOSPolicyAssignment(name);
            // End snippet
        }

        /// <summary>Snippet for GetOSPolicyAssignmentAsync</summary>
        public async Task GetOSPolicyAssignmentResourceNamesAsync()
        {
            // Snippet: GetOSPolicyAssignmentAsync(OSPolicyAssignmentName, CallSettings)
            // Additional: GetOSPolicyAssignmentAsync(OSPolicyAssignmentName, CancellationToken)
            // Create client
            OsConfigZonalServiceClient osConfigZonalServiceClient = await OsConfigZonalServiceClient.CreateAsync();
            // Initialize request argument(s)
            OSPolicyAssignmentName name = OSPolicyAssignmentName.FromProjectLocationOsPolicyAssignment("[PROJECT]", "[LOCATION]", "[OS_POLICY_ASSIGNMENT]");
            // Make the request
            OSPolicyAssignment response = await osConfigZonalServiceClient.GetOSPolicyAssignmentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListOSPolicyAssignments</summary>
        public void ListOSPolicyAssignmentsRequestObject()
        {
            // Snippet: ListOSPolicyAssignments(ListOSPolicyAssignmentsRequest, CallSettings)
            // Create client
            OsConfigZonalServiceClient osConfigZonalServiceClient = OsConfigZonalServiceClient.Create();
            // Initialize request argument(s)
            ListOSPolicyAssignmentsRequest request = new ListOSPolicyAssignmentsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedEnumerable<ListOSPolicyAssignmentsResponse, OSPolicyAssignment> response = osConfigZonalServiceClient.ListOSPolicyAssignments(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (OSPolicyAssignment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListOSPolicyAssignmentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (OSPolicyAssignment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<OSPolicyAssignment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (OSPolicyAssignment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListOSPolicyAssignmentsAsync</summary>
        public async Task ListOSPolicyAssignmentsRequestObjectAsync()
        {
            // Snippet: ListOSPolicyAssignmentsAsync(ListOSPolicyAssignmentsRequest, CallSettings)
            // Create client
            OsConfigZonalServiceClient osConfigZonalServiceClient = await OsConfigZonalServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListOSPolicyAssignmentsRequest request = new ListOSPolicyAssignmentsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListOSPolicyAssignmentsResponse, OSPolicyAssignment> response = osConfigZonalServiceClient.ListOSPolicyAssignmentsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((OSPolicyAssignment item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListOSPolicyAssignmentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (OSPolicyAssignment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<OSPolicyAssignment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (OSPolicyAssignment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListOSPolicyAssignments</summary>
        public void ListOSPolicyAssignments()
        {
            // Snippet: ListOSPolicyAssignments(string, string, int?, CallSettings)
            // Create client
            OsConfigZonalServiceClient osConfigZonalServiceClient = OsConfigZonalServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListOSPolicyAssignmentsResponse, OSPolicyAssignment> response = osConfigZonalServiceClient.ListOSPolicyAssignments(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (OSPolicyAssignment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListOSPolicyAssignmentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (OSPolicyAssignment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<OSPolicyAssignment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (OSPolicyAssignment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListOSPolicyAssignmentsAsync</summary>
        public async Task ListOSPolicyAssignmentsAsync()
        {
            // Snippet: ListOSPolicyAssignmentsAsync(string, string, int?, CallSettings)
            // Create client
            OsConfigZonalServiceClient osConfigZonalServiceClient = await OsConfigZonalServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListOSPolicyAssignmentsResponse, OSPolicyAssignment> response = osConfigZonalServiceClient.ListOSPolicyAssignmentsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((OSPolicyAssignment item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListOSPolicyAssignmentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (OSPolicyAssignment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<OSPolicyAssignment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (OSPolicyAssignment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListOSPolicyAssignments</summary>
        public void ListOSPolicyAssignmentsResourceNames()
        {
            // Snippet: ListOSPolicyAssignments(LocationName, string, int?, CallSettings)
            // Create client
            OsConfigZonalServiceClient osConfigZonalServiceClient = OsConfigZonalServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListOSPolicyAssignmentsResponse, OSPolicyAssignment> response = osConfigZonalServiceClient.ListOSPolicyAssignments(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (OSPolicyAssignment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListOSPolicyAssignmentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (OSPolicyAssignment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<OSPolicyAssignment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (OSPolicyAssignment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListOSPolicyAssignmentsAsync</summary>
        public async Task ListOSPolicyAssignmentsResourceNamesAsync()
        {
            // Snippet: ListOSPolicyAssignmentsAsync(LocationName, string, int?, CallSettings)
            // Create client
            OsConfigZonalServiceClient osConfigZonalServiceClient = await OsConfigZonalServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListOSPolicyAssignmentsResponse, OSPolicyAssignment> response = osConfigZonalServiceClient.ListOSPolicyAssignmentsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((OSPolicyAssignment item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListOSPolicyAssignmentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (OSPolicyAssignment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<OSPolicyAssignment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (OSPolicyAssignment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListOSPolicyAssignmentRevisions</summary>
        public void ListOSPolicyAssignmentRevisionsRequestObject()
        {
            // Snippet: ListOSPolicyAssignmentRevisions(ListOSPolicyAssignmentRevisionsRequest, CallSettings)
            // Create client
            OsConfigZonalServiceClient osConfigZonalServiceClient = OsConfigZonalServiceClient.Create();
            // Initialize request argument(s)
            ListOSPolicyAssignmentRevisionsRequest request = new ListOSPolicyAssignmentRevisionsRequest
            {
                OSPolicyAssignmentName = OSPolicyAssignmentName.FromProjectLocationOsPolicyAssignment("[PROJECT]", "[LOCATION]", "[OS_POLICY_ASSIGNMENT]"),
            };
            // Make the request
            PagedEnumerable<ListOSPolicyAssignmentRevisionsResponse, OSPolicyAssignment> response = osConfigZonalServiceClient.ListOSPolicyAssignmentRevisions(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (OSPolicyAssignment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListOSPolicyAssignmentRevisionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (OSPolicyAssignment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<OSPolicyAssignment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (OSPolicyAssignment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListOSPolicyAssignmentRevisionsAsync</summary>
        public async Task ListOSPolicyAssignmentRevisionsRequestObjectAsync()
        {
            // Snippet: ListOSPolicyAssignmentRevisionsAsync(ListOSPolicyAssignmentRevisionsRequest, CallSettings)
            // Create client
            OsConfigZonalServiceClient osConfigZonalServiceClient = await OsConfigZonalServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListOSPolicyAssignmentRevisionsRequest request = new ListOSPolicyAssignmentRevisionsRequest
            {
                OSPolicyAssignmentName = OSPolicyAssignmentName.FromProjectLocationOsPolicyAssignment("[PROJECT]", "[LOCATION]", "[OS_POLICY_ASSIGNMENT]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListOSPolicyAssignmentRevisionsResponse, OSPolicyAssignment> response = osConfigZonalServiceClient.ListOSPolicyAssignmentRevisionsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((OSPolicyAssignment item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListOSPolicyAssignmentRevisionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (OSPolicyAssignment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<OSPolicyAssignment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (OSPolicyAssignment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListOSPolicyAssignmentRevisions</summary>
        public void ListOSPolicyAssignmentRevisions()
        {
            // Snippet: ListOSPolicyAssignmentRevisions(string, string, int?, CallSettings)
            // Create client
            OsConfigZonalServiceClient osConfigZonalServiceClient = OsConfigZonalServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/osPolicyAssignments/[OS_POLICY_ASSIGNMENT]";
            // Make the request
            PagedEnumerable<ListOSPolicyAssignmentRevisionsResponse, OSPolicyAssignment> response = osConfigZonalServiceClient.ListOSPolicyAssignmentRevisions(name);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (OSPolicyAssignment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListOSPolicyAssignmentRevisionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (OSPolicyAssignment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<OSPolicyAssignment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (OSPolicyAssignment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListOSPolicyAssignmentRevisionsAsync</summary>
        public async Task ListOSPolicyAssignmentRevisionsAsync()
        {
            // Snippet: ListOSPolicyAssignmentRevisionsAsync(string, string, int?, CallSettings)
            // Create client
            OsConfigZonalServiceClient osConfigZonalServiceClient = await OsConfigZonalServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/osPolicyAssignments/[OS_POLICY_ASSIGNMENT]";
            // Make the request
            PagedAsyncEnumerable<ListOSPolicyAssignmentRevisionsResponse, OSPolicyAssignment> response = osConfigZonalServiceClient.ListOSPolicyAssignmentRevisionsAsync(name);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((OSPolicyAssignment item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListOSPolicyAssignmentRevisionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (OSPolicyAssignment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<OSPolicyAssignment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (OSPolicyAssignment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListOSPolicyAssignmentRevisions</summary>
        public void ListOSPolicyAssignmentRevisionsResourceNames()
        {
            // Snippet: ListOSPolicyAssignmentRevisions(OSPolicyAssignmentName, string, int?, CallSettings)
            // Create client
            OsConfigZonalServiceClient osConfigZonalServiceClient = OsConfigZonalServiceClient.Create();
            // Initialize request argument(s)
            OSPolicyAssignmentName name = OSPolicyAssignmentName.FromProjectLocationOsPolicyAssignment("[PROJECT]", "[LOCATION]", "[OS_POLICY_ASSIGNMENT]");
            // Make the request
            PagedEnumerable<ListOSPolicyAssignmentRevisionsResponse, OSPolicyAssignment> response = osConfigZonalServiceClient.ListOSPolicyAssignmentRevisions(name);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (OSPolicyAssignment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListOSPolicyAssignmentRevisionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (OSPolicyAssignment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<OSPolicyAssignment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (OSPolicyAssignment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListOSPolicyAssignmentRevisionsAsync</summary>
        public async Task ListOSPolicyAssignmentRevisionsResourceNamesAsync()
        {
            // Snippet: ListOSPolicyAssignmentRevisionsAsync(OSPolicyAssignmentName, string, int?, CallSettings)
            // Create client
            OsConfigZonalServiceClient osConfigZonalServiceClient = await OsConfigZonalServiceClient.CreateAsync();
            // Initialize request argument(s)
            OSPolicyAssignmentName name = OSPolicyAssignmentName.FromProjectLocationOsPolicyAssignment("[PROJECT]", "[LOCATION]", "[OS_POLICY_ASSIGNMENT]");
            // Make the request
            PagedAsyncEnumerable<ListOSPolicyAssignmentRevisionsResponse, OSPolicyAssignment> response = osConfigZonalServiceClient.ListOSPolicyAssignmentRevisionsAsync(name);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((OSPolicyAssignment item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListOSPolicyAssignmentRevisionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (OSPolicyAssignment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<OSPolicyAssignment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (OSPolicyAssignment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DeleteOSPolicyAssignment</summary>
        public void DeleteOSPolicyAssignmentRequestObject()
        {
            // Snippet: DeleteOSPolicyAssignment(DeleteOSPolicyAssignmentRequest, CallSettings)
            // Create client
            OsConfigZonalServiceClient osConfigZonalServiceClient = OsConfigZonalServiceClient.Create();
            // Initialize request argument(s)
            DeleteOSPolicyAssignmentRequest request = new DeleteOSPolicyAssignmentRequest
            {
                OSPolicyAssignmentName = OSPolicyAssignmentName.FromProjectLocationOsPolicyAssignment("[PROJECT]", "[LOCATION]", "[OS_POLICY_ASSIGNMENT]"),
            };
            // Make the request
            Operation<Empty, OSPolicyAssignmentOperationMetadata> response = osConfigZonalServiceClient.DeleteOSPolicyAssignment(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OSPolicyAssignmentOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OSPolicyAssignmentOperationMetadata> retrievedResponse = osConfigZonalServiceClient.PollOnceDeleteOSPolicyAssignment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteOSPolicyAssignmentAsync</summary>
        public async Task DeleteOSPolicyAssignmentRequestObjectAsync()
        {
            // Snippet: DeleteOSPolicyAssignmentAsync(DeleteOSPolicyAssignmentRequest, CallSettings)
            // Additional: DeleteOSPolicyAssignmentAsync(DeleteOSPolicyAssignmentRequest, CancellationToken)
            // Create client
            OsConfigZonalServiceClient osConfigZonalServiceClient = await OsConfigZonalServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteOSPolicyAssignmentRequest request = new DeleteOSPolicyAssignmentRequest
            {
                OSPolicyAssignmentName = OSPolicyAssignmentName.FromProjectLocationOsPolicyAssignment("[PROJECT]", "[LOCATION]", "[OS_POLICY_ASSIGNMENT]"),
            };
            // Make the request
            Operation<Empty, OSPolicyAssignmentOperationMetadata> response = await osConfigZonalServiceClient.DeleteOSPolicyAssignmentAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OSPolicyAssignmentOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OSPolicyAssignmentOperationMetadata> retrievedResponse = await osConfigZonalServiceClient.PollOnceDeleteOSPolicyAssignmentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteOSPolicyAssignment</summary>
        public void DeleteOSPolicyAssignment()
        {
            // Snippet: DeleteOSPolicyAssignment(string, CallSettings)
            // Create client
            OsConfigZonalServiceClient osConfigZonalServiceClient = OsConfigZonalServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/osPolicyAssignments/[OS_POLICY_ASSIGNMENT]";
            // Make the request
            Operation<Empty, OSPolicyAssignmentOperationMetadata> response = osConfigZonalServiceClient.DeleteOSPolicyAssignment(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OSPolicyAssignmentOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OSPolicyAssignmentOperationMetadata> retrievedResponse = osConfigZonalServiceClient.PollOnceDeleteOSPolicyAssignment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteOSPolicyAssignmentAsync</summary>
        public async Task DeleteOSPolicyAssignmentAsync()
        {
            // Snippet: DeleteOSPolicyAssignmentAsync(string, CallSettings)
            // Additional: DeleteOSPolicyAssignmentAsync(string, CancellationToken)
            // Create client
            OsConfigZonalServiceClient osConfigZonalServiceClient = await OsConfigZonalServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/osPolicyAssignments/[OS_POLICY_ASSIGNMENT]";
            // Make the request
            Operation<Empty, OSPolicyAssignmentOperationMetadata> response = await osConfigZonalServiceClient.DeleteOSPolicyAssignmentAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OSPolicyAssignmentOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OSPolicyAssignmentOperationMetadata> retrievedResponse = await osConfigZonalServiceClient.PollOnceDeleteOSPolicyAssignmentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteOSPolicyAssignment</summary>
        public void DeleteOSPolicyAssignmentResourceNames()
        {
            // Snippet: DeleteOSPolicyAssignment(OSPolicyAssignmentName, CallSettings)
            // Create client
            OsConfigZonalServiceClient osConfigZonalServiceClient = OsConfigZonalServiceClient.Create();
            // Initialize request argument(s)
            OSPolicyAssignmentName name = OSPolicyAssignmentName.FromProjectLocationOsPolicyAssignment("[PROJECT]", "[LOCATION]", "[OS_POLICY_ASSIGNMENT]");
            // Make the request
            Operation<Empty, OSPolicyAssignmentOperationMetadata> response = osConfigZonalServiceClient.DeleteOSPolicyAssignment(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OSPolicyAssignmentOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OSPolicyAssignmentOperationMetadata> retrievedResponse = osConfigZonalServiceClient.PollOnceDeleteOSPolicyAssignment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteOSPolicyAssignmentAsync</summary>
        public async Task DeleteOSPolicyAssignmentResourceNamesAsync()
        {
            // Snippet: DeleteOSPolicyAssignmentAsync(OSPolicyAssignmentName, CallSettings)
            // Additional: DeleteOSPolicyAssignmentAsync(OSPolicyAssignmentName, CancellationToken)
            // Create client
            OsConfigZonalServiceClient osConfigZonalServiceClient = await OsConfigZonalServiceClient.CreateAsync();
            // Initialize request argument(s)
            OSPolicyAssignmentName name = OSPolicyAssignmentName.FromProjectLocationOsPolicyAssignment("[PROJECT]", "[LOCATION]", "[OS_POLICY_ASSIGNMENT]");
            // Make the request
            Operation<Empty, OSPolicyAssignmentOperationMetadata> response = await osConfigZonalServiceClient.DeleteOSPolicyAssignmentAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OSPolicyAssignmentOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OSPolicyAssignmentOperationMetadata> retrievedResponse = await osConfigZonalServiceClient.PollOnceDeleteOSPolicyAssignmentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetInstanceOSPoliciesCompliance</summary>
        public void GetInstanceOSPoliciesComplianceRequestObject()
        {
            // Snippet: GetInstanceOSPoliciesCompliance(GetInstanceOSPoliciesComplianceRequest, CallSettings)
            // Create client
            OsConfigZonalServiceClient osConfigZonalServiceClient = OsConfigZonalServiceClient.Create();
            // Initialize request argument(s)
#pragma warning disable CS0612
            GetInstanceOSPoliciesComplianceRequest request = new GetInstanceOSPoliciesComplianceRequest { };
#pragma warning restore CS0612
            // Make the request
#pragma warning disable CS0612
            InstanceOSPoliciesCompliance response = osConfigZonalServiceClient.GetInstanceOSPoliciesCompliance(request);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for GetInstanceOSPoliciesComplianceAsync</summary>
        public async Task GetInstanceOSPoliciesComplianceRequestObjectAsync()
        {
            // Snippet: GetInstanceOSPoliciesComplianceAsync(GetInstanceOSPoliciesComplianceRequest, CallSettings)
            // Additional: GetInstanceOSPoliciesComplianceAsync(GetInstanceOSPoliciesComplianceRequest, CancellationToken)
            // Create client
            OsConfigZonalServiceClient osConfigZonalServiceClient = await OsConfigZonalServiceClient.CreateAsync();
            // Initialize request argument(s)
#pragma warning disable CS0612
            GetInstanceOSPoliciesComplianceRequest request = new GetInstanceOSPoliciesComplianceRequest { };
#pragma warning restore CS0612
            // Make the request
#pragma warning disable CS0612
            InstanceOSPoliciesCompliance response = await osConfigZonalServiceClient.GetInstanceOSPoliciesComplianceAsync(request);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for GetInstanceOSPoliciesCompliance</summary>
        public void GetInstanceOSPoliciesCompliance()
        {
            // Snippet: GetInstanceOSPoliciesCompliance(string, CallSettings)
            // Create client
            OsConfigZonalServiceClient osConfigZonalServiceClient = OsConfigZonalServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instanceOSPoliciesCompliances/[INSTANCE]";
            // Make the request
#pragma warning disable CS0612
            InstanceOSPoliciesCompliance response = osConfigZonalServiceClient.GetInstanceOSPoliciesCompliance(name);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for GetInstanceOSPoliciesComplianceAsync</summary>
        public async Task GetInstanceOSPoliciesComplianceAsync()
        {
            // Snippet: GetInstanceOSPoliciesComplianceAsync(string, CallSettings)
            // Additional: GetInstanceOSPoliciesComplianceAsync(string, CancellationToken)
            // Create client
            OsConfigZonalServiceClient osConfigZonalServiceClient = await OsConfigZonalServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instanceOSPoliciesCompliances/[INSTANCE]";
            // Make the request
#pragma warning disable CS0612
            InstanceOSPoliciesCompliance response = await osConfigZonalServiceClient.GetInstanceOSPoliciesComplianceAsync(name);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for GetInstanceOSPoliciesCompliance</summary>
        public void GetInstanceOSPoliciesComplianceResourceNames()
        {
            // Snippet: GetInstanceOSPoliciesCompliance(InstanceOSPoliciesComplianceName, CallSettings)
            // Create client
            OsConfigZonalServiceClient osConfigZonalServiceClient = OsConfigZonalServiceClient.Create();
            // Initialize request argument(s)
            InstanceOSPoliciesComplianceName name = InstanceOSPoliciesComplianceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            // Make the request
#pragma warning disable CS0612
            InstanceOSPoliciesCompliance response = osConfigZonalServiceClient.GetInstanceOSPoliciesCompliance(name);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for GetInstanceOSPoliciesComplianceAsync</summary>
        public async Task GetInstanceOSPoliciesComplianceResourceNamesAsync()
        {
            // Snippet: GetInstanceOSPoliciesComplianceAsync(InstanceOSPoliciesComplianceName, CallSettings)
            // Additional: GetInstanceOSPoliciesComplianceAsync(InstanceOSPoliciesComplianceName, CancellationToken)
            // Create client
            OsConfigZonalServiceClient osConfigZonalServiceClient = await OsConfigZonalServiceClient.CreateAsync();
            // Initialize request argument(s)
            InstanceOSPoliciesComplianceName name = InstanceOSPoliciesComplianceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            // Make the request
#pragma warning disable CS0612
            InstanceOSPoliciesCompliance response = await osConfigZonalServiceClient.GetInstanceOSPoliciesComplianceAsync(name);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for ListInstanceOSPoliciesCompliances</summary>
        public void ListInstanceOSPoliciesCompliancesRequestObject()
        {
            // Snippet: ListInstanceOSPoliciesCompliances(ListInstanceOSPoliciesCompliancesRequest, CallSettings)
            // Create client
            OsConfigZonalServiceClient osConfigZonalServiceClient = OsConfigZonalServiceClient.Create();
            // Initialize request argument(s)
#pragma warning disable CS0612
            ListInstanceOSPoliciesCompliancesRequest request = new ListInstanceOSPoliciesCompliancesRequest { };
#pragma warning restore CS0612
            // Make the request
#pragma warning disable CS0612
            PagedEnumerable<ListInstanceOSPoliciesCompliancesResponse, InstanceOSPoliciesCompliance> response = osConfigZonalServiceClient.ListInstanceOSPoliciesCompliances(request);
#pragma warning restore CS0612

            // Iterate over all response items, lazily performing RPCs as required
#pragma warning disable CS0612
            foreach (InstanceOSPoliciesCompliance item in response)
#pragma warning restore CS0612
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
#pragma warning disable CS0612
            foreach (ListInstanceOSPoliciesCompliancesResponse page in response.AsRawResponses())
#pragma warning restore CS0612
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
#pragma warning disable CS0612
                foreach (InstanceOSPoliciesCompliance item in page)
#pragma warning restore CS0612
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
#pragma warning disable CS0612
            Page<InstanceOSPoliciesCompliance> singlePage = response.ReadPage(pageSize);
#pragma warning restore CS0612
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
#pragma warning disable CS0612
            foreach (InstanceOSPoliciesCompliance item in singlePage)
#pragma warning restore CS0612
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInstanceOSPoliciesCompliancesAsync</summary>
        public async Task ListInstanceOSPoliciesCompliancesRequestObjectAsync()
        {
            // Snippet: ListInstanceOSPoliciesCompliancesAsync(ListInstanceOSPoliciesCompliancesRequest, CallSettings)
            // Create client
            OsConfigZonalServiceClient osConfigZonalServiceClient = await OsConfigZonalServiceClient.CreateAsync();
            // Initialize request argument(s)
#pragma warning disable CS0612
            ListInstanceOSPoliciesCompliancesRequest request = new ListInstanceOSPoliciesCompliancesRequest { };
#pragma warning restore CS0612
            // Make the request
#pragma warning disable CS0612
            PagedAsyncEnumerable<ListInstanceOSPoliciesCompliancesResponse, InstanceOSPoliciesCompliance> response = osConfigZonalServiceClient.ListInstanceOSPoliciesCompliancesAsync(request);
#pragma warning restore CS0612

            // Iterate over all response items, lazily performing RPCs as required
#pragma warning disable CS0612
            await response.ForEachAsync((InstanceOSPoliciesCompliance item) =>
#pragma warning restore CS0612
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
#pragma warning disable CS0612
            await response.AsRawResponses().ForEachAsync((ListInstanceOSPoliciesCompliancesResponse page) =>
#pragma warning restore CS0612
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
#pragma warning disable CS0612
                foreach (InstanceOSPoliciesCompliance item in page)
#pragma warning restore CS0612
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
#pragma warning disable CS0612
            Page<InstanceOSPoliciesCompliance> singlePage = await response.ReadPageAsync(pageSize);
#pragma warning restore CS0612
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
#pragma warning disable CS0612
            foreach (InstanceOSPoliciesCompliance item in singlePage)
#pragma warning restore CS0612
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInstanceOSPoliciesCompliances</summary>
        public void ListInstanceOSPoliciesCompliances()
        {
            // Snippet: ListInstanceOSPoliciesCompliances(string, string, int?, CallSettings)
            // Create client
            OsConfigZonalServiceClient osConfigZonalServiceClient = OsConfigZonalServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
#pragma warning disable CS0612
            PagedEnumerable<ListInstanceOSPoliciesCompliancesResponse, InstanceOSPoliciesCompliance> response = osConfigZonalServiceClient.ListInstanceOSPoliciesCompliances(parent);
#pragma warning restore CS0612

            // Iterate over all response items, lazily performing RPCs as required
#pragma warning disable CS0612
            foreach (InstanceOSPoliciesCompliance item in response)
#pragma warning restore CS0612
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
#pragma warning disable CS0612
            foreach (ListInstanceOSPoliciesCompliancesResponse page in response.AsRawResponses())
#pragma warning restore CS0612
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
#pragma warning disable CS0612
                foreach (InstanceOSPoliciesCompliance item in page)
#pragma warning restore CS0612
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
#pragma warning disable CS0612
            Page<InstanceOSPoliciesCompliance> singlePage = response.ReadPage(pageSize);
#pragma warning restore CS0612
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
#pragma warning disable CS0612
            foreach (InstanceOSPoliciesCompliance item in singlePage)
#pragma warning restore CS0612
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInstanceOSPoliciesCompliancesAsync</summary>
        public async Task ListInstanceOSPoliciesCompliancesAsync()
        {
            // Snippet: ListInstanceOSPoliciesCompliancesAsync(string, string, int?, CallSettings)
            // Create client
            OsConfigZonalServiceClient osConfigZonalServiceClient = await OsConfigZonalServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
#pragma warning disable CS0612
            PagedAsyncEnumerable<ListInstanceOSPoliciesCompliancesResponse, InstanceOSPoliciesCompliance> response = osConfigZonalServiceClient.ListInstanceOSPoliciesCompliancesAsync(parent);
#pragma warning restore CS0612

            // Iterate over all response items, lazily performing RPCs as required
#pragma warning disable CS0612
            await response.ForEachAsync((InstanceOSPoliciesCompliance item) =>
#pragma warning restore CS0612
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
#pragma warning disable CS0612
            await response.AsRawResponses().ForEachAsync((ListInstanceOSPoliciesCompliancesResponse page) =>
#pragma warning restore CS0612
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
#pragma warning disable CS0612
                foreach (InstanceOSPoliciesCompliance item in page)
#pragma warning restore CS0612
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
#pragma warning disable CS0612
            Page<InstanceOSPoliciesCompliance> singlePage = await response.ReadPageAsync(pageSize);
#pragma warning restore CS0612
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
#pragma warning disable CS0612
            foreach (InstanceOSPoliciesCompliance item in singlePage)
#pragma warning restore CS0612
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInstanceOSPoliciesCompliances</summary>
        public void ListInstanceOSPoliciesCompliancesResourceNames()
        {
            // Snippet: ListInstanceOSPoliciesCompliances(LocationName, string, int?, CallSettings)
            // Create client
            OsConfigZonalServiceClient osConfigZonalServiceClient = OsConfigZonalServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
#pragma warning disable CS0612
            PagedEnumerable<ListInstanceOSPoliciesCompliancesResponse, InstanceOSPoliciesCompliance> response = osConfigZonalServiceClient.ListInstanceOSPoliciesCompliances(parent);
#pragma warning restore CS0612

            // Iterate over all response items, lazily performing RPCs as required
#pragma warning disable CS0612
            foreach (InstanceOSPoliciesCompliance item in response)
#pragma warning restore CS0612
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
#pragma warning disable CS0612
            foreach (ListInstanceOSPoliciesCompliancesResponse page in response.AsRawResponses())
#pragma warning restore CS0612
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
#pragma warning disable CS0612
                foreach (InstanceOSPoliciesCompliance item in page)
#pragma warning restore CS0612
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
#pragma warning disable CS0612
            Page<InstanceOSPoliciesCompliance> singlePage = response.ReadPage(pageSize);
#pragma warning restore CS0612
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
#pragma warning disable CS0612
            foreach (InstanceOSPoliciesCompliance item in singlePage)
#pragma warning restore CS0612
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInstanceOSPoliciesCompliancesAsync</summary>
        public async Task ListInstanceOSPoliciesCompliancesResourceNamesAsync()
        {
            // Snippet: ListInstanceOSPoliciesCompliancesAsync(LocationName, string, int?, CallSettings)
            // Create client
            OsConfigZonalServiceClient osConfigZonalServiceClient = await OsConfigZonalServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
#pragma warning disable CS0612
            PagedAsyncEnumerable<ListInstanceOSPoliciesCompliancesResponse, InstanceOSPoliciesCompliance> response = osConfigZonalServiceClient.ListInstanceOSPoliciesCompliancesAsync(parent);
#pragma warning restore CS0612

            // Iterate over all response items, lazily performing RPCs as required
#pragma warning disable CS0612
            await response.ForEachAsync((InstanceOSPoliciesCompliance item) =>
#pragma warning restore CS0612
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
#pragma warning disable CS0612
            await response.AsRawResponses().ForEachAsync((ListInstanceOSPoliciesCompliancesResponse page) =>
#pragma warning restore CS0612
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
#pragma warning disable CS0612
                foreach (InstanceOSPoliciesCompliance item in page)
#pragma warning restore CS0612
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
#pragma warning disable CS0612
            Page<InstanceOSPoliciesCompliance> singlePage = await response.ReadPageAsync(pageSize);
#pragma warning restore CS0612
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
#pragma warning disable CS0612
            foreach (InstanceOSPoliciesCompliance item in singlePage)
#pragma warning restore CS0612
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetOSPolicyAssignmentReport</summary>
        public void GetOSPolicyAssignmentReportRequestObject()
        {
            // Snippet: GetOSPolicyAssignmentReport(GetOSPolicyAssignmentReportRequest, CallSettings)
            // Create client
            OsConfigZonalServiceClient osConfigZonalServiceClient = OsConfigZonalServiceClient.Create();
            // Initialize request argument(s)
            GetOSPolicyAssignmentReportRequest request = new GetOSPolicyAssignmentReportRequest
            {
                OSPolicyAssignmentReportName = OSPolicyAssignmentReportName.FromProjectLocationInstanceAssignment("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[ASSIGNMENT]"),
            };
            // Make the request
            OSPolicyAssignmentReport response = osConfigZonalServiceClient.GetOSPolicyAssignmentReport(request);
            // End snippet
        }

        /// <summary>Snippet for GetOSPolicyAssignmentReportAsync</summary>
        public async Task GetOSPolicyAssignmentReportRequestObjectAsync()
        {
            // Snippet: GetOSPolicyAssignmentReportAsync(GetOSPolicyAssignmentReportRequest, CallSettings)
            // Additional: GetOSPolicyAssignmentReportAsync(GetOSPolicyAssignmentReportRequest, CancellationToken)
            // Create client
            OsConfigZonalServiceClient osConfigZonalServiceClient = await OsConfigZonalServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetOSPolicyAssignmentReportRequest request = new GetOSPolicyAssignmentReportRequest
            {
                OSPolicyAssignmentReportName = OSPolicyAssignmentReportName.FromProjectLocationInstanceAssignment("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[ASSIGNMENT]"),
            };
            // Make the request
            OSPolicyAssignmentReport response = await osConfigZonalServiceClient.GetOSPolicyAssignmentReportAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetOSPolicyAssignmentReport</summary>
        public void GetOSPolicyAssignmentReport()
        {
            // Snippet: GetOSPolicyAssignmentReport(string, CallSettings)
            // Create client
            OsConfigZonalServiceClient osConfigZonalServiceClient = OsConfigZonalServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]/osPolicyAssignments/[ASSIGNMENT]/report";
            // Make the request
            OSPolicyAssignmentReport response = osConfigZonalServiceClient.GetOSPolicyAssignmentReport(name);
            // End snippet
        }

        /// <summary>Snippet for GetOSPolicyAssignmentReportAsync</summary>
        public async Task GetOSPolicyAssignmentReportAsync()
        {
            // Snippet: GetOSPolicyAssignmentReportAsync(string, CallSettings)
            // Additional: GetOSPolicyAssignmentReportAsync(string, CancellationToken)
            // Create client
            OsConfigZonalServiceClient osConfigZonalServiceClient = await OsConfigZonalServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]/osPolicyAssignments/[ASSIGNMENT]/report";
            // Make the request
            OSPolicyAssignmentReport response = await osConfigZonalServiceClient.GetOSPolicyAssignmentReportAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetOSPolicyAssignmentReport</summary>
        public void GetOSPolicyAssignmentReportResourceNames()
        {
            // Snippet: GetOSPolicyAssignmentReport(OSPolicyAssignmentReportName, CallSettings)
            // Create client
            OsConfigZonalServiceClient osConfigZonalServiceClient = OsConfigZonalServiceClient.Create();
            // Initialize request argument(s)
            OSPolicyAssignmentReportName name = OSPolicyAssignmentReportName.FromProjectLocationInstanceAssignment("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[ASSIGNMENT]");
            // Make the request
            OSPolicyAssignmentReport response = osConfigZonalServiceClient.GetOSPolicyAssignmentReport(name);
            // End snippet
        }

        /// <summary>Snippet for GetOSPolicyAssignmentReportAsync</summary>
        public async Task GetOSPolicyAssignmentReportResourceNamesAsync()
        {
            // Snippet: GetOSPolicyAssignmentReportAsync(OSPolicyAssignmentReportName, CallSettings)
            // Additional: GetOSPolicyAssignmentReportAsync(OSPolicyAssignmentReportName, CancellationToken)
            // Create client
            OsConfigZonalServiceClient osConfigZonalServiceClient = await OsConfigZonalServiceClient.CreateAsync();
            // Initialize request argument(s)
            OSPolicyAssignmentReportName name = OSPolicyAssignmentReportName.FromProjectLocationInstanceAssignment("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[ASSIGNMENT]");
            // Make the request
            OSPolicyAssignmentReport response = await osConfigZonalServiceClient.GetOSPolicyAssignmentReportAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListOSPolicyAssignmentReports</summary>
        public void ListOSPolicyAssignmentReportsRequestObject()
        {
            // Snippet: ListOSPolicyAssignmentReports(ListOSPolicyAssignmentReportsRequest, CallSettings)
            // Create client
            OsConfigZonalServiceClient osConfigZonalServiceClient = OsConfigZonalServiceClient.Create();
            // Initialize request argument(s)
            ListOSPolicyAssignmentReportsRequest request = new ListOSPolicyAssignmentReportsRequest
            {
                ParentAsInstanceOSPolicyAssignmentName = InstanceOSPolicyAssignmentName.FromProjectLocationInstanceAssignment("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[ASSIGNMENT]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListOSPolicyAssignmentReportsResponse, OSPolicyAssignmentReport> response = osConfigZonalServiceClient.ListOSPolicyAssignmentReports(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (OSPolicyAssignmentReport item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListOSPolicyAssignmentReportsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (OSPolicyAssignmentReport item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<OSPolicyAssignmentReport> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (OSPolicyAssignmentReport item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListOSPolicyAssignmentReportsAsync</summary>
        public async Task ListOSPolicyAssignmentReportsRequestObjectAsync()
        {
            // Snippet: ListOSPolicyAssignmentReportsAsync(ListOSPolicyAssignmentReportsRequest, CallSettings)
            // Create client
            OsConfigZonalServiceClient osConfigZonalServiceClient = await OsConfigZonalServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListOSPolicyAssignmentReportsRequest request = new ListOSPolicyAssignmentReportsRequest
            {
                ParentAsInstanceOSPolicyAssignmentName = InstanceOSPolicyAssignmentName.FromProjectLocationInstanceAssignment("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[ASSIGNMENT]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListOSPolicyAssignmentReportsResponse, OSPolicyAssignmentReport> response = osConfigZonalServiceClient.ListOSPolicyAssignmentReportsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((OSPolicyAssignmentReport item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListOSPolicyAssignmentReportsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (OSPolicyAssignmentReport item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<OSPolicyAssignmentReport> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (OSPolicyAssignmentReport item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListOSPolicyAssignmentReports</summary>
        public void ListOSPolicyAssignmentReports()
        {
            // Snippet: ListOSPolicyAssignmentReports(string, string, int?, CallSettings)
            // Create client
            OsConfigZonalServiceClient osConfigZonalServiceClient = OsConfigZonalServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]/osPolicyAssignments/[ASSIGNMENT]";
            // Make the request
            PagedEnumerable<ListOSPolicyAssignmentReportsResponse, OSPolicyAssignmentReport> response = osConfigZonalServiceClient.ListOSPolicyAssignmentReports(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (OSPolicyAssignmentReport item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListOSPolicyAssignmentReportsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (OSPolicyAssignmentReport item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<OSPolicyAssignmentReport> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (OSPolicyAssignmentReport item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListOSPolicyAssignmentReportsAsync</summary>
        public async Task ListOSPolicyAssignmentReportsAsync()
        {
            // Snippet: ListOSPolicyAssignmentReportsAsync(string, string, int?, CallSettings)
            // Create client
            OsConfigZonalServiceClient osConfigZonalServiceClient = await OsConfigZonalServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]/osPolicyAssignments/[ASSIGNMENT]";
            // Make the request
            PagedAsyncEnumerable<ListOSPolicyAssignmentReportsResponse, OSPolicyAssignmentReport> response = osConfigZonalServiceClient.ListOSPolicyAssignmentReportsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((OSPolicyAssignmentReport item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListOSPolicyAssignmentReportsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (OSPolicyAssignmentReport item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<OSPolicyAssignmentReport> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (OSPolicyAssignmentReport item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListOSPolicyAssignmentReports</summary>
        public void ListOSPolicyAssignmentReportsResourceNames()
        {
            // Snippet: ListOSPolicyAssignmentReports(InstanceOSPolicyAssignmentName, string, int?, CallSettings)
            // Create client
            OsConfigZonalServiceClient osConfigZonalServiceClient = OsConfigZonalServiceClient.Create();
            // Initialize request argument(s)
            InstanceOSPolicyAssignmentName parent = InstanceOSPolicyAssignmentName.FromProjectLocationInstanceAssignment("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[ASSIGNMENT]");
            // Make the request
            PagedEnumerable<ListOSPolicyAssignmentReportsResponse, OSPolicyAssignmentReport> response = osConfigZonalServiceClient.ListOSPolicyAssignmentReports(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (OSPolicyAssignmentReport item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListOSPolicyAssignmentReportsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (OSPolicyAssignmentReport item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<OSPolicyAssignmentReport> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (OSPolicyAssignmentReport item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListOSPolicyAssignmentReportsAsync</summary>
        public async Task ListOSPolicyAssignmentReportsResourceNamesAsync()
        {
            // Snippet: ListOSPolicyAssignmentReportsAsync(InstanceOSPolicyAssignmentName, string, int?, CallSettings)
            // Create client
            OsConfigZonalServiceClient osConfigZonalServiceClient = await OsConfigZonalServiceClient.CreateAsync();
            // Initialize request argument(s)
            InstanceOSPolicyAssignmentName parent = InstanceOSPolicyAssignmentName.FromProjectLocationInstanceAssignment("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[ASSIGNMENT]");
            // Make the request
            PagedAsyncEnumerable<ListOSPolicyAssignmentReportsResponse, OSPolicyAssignmentReport> response = osConfigZonalServiceClient.ListOSPolicyAssignmentReportsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((OSPolicyAssignmentReport item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListOSPolicyAssignmentReportsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (OSPolicyAssignmentReport item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<OSPolicyAssignmentReport> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (OSPolicyAssignmentReport item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetInventory</summary>
        public void GetInventoryRequestObject()
        {
            // Snippet: GetInventory(GetInventoryRequest, CallSettings)
            // Create client
            OsConfigZonalServiceClient osConfigZonalServiceClient = OsConfigZonalServiceClient.Create();
            // Initialize request argument(s)
            GetInventoryRequest request = new GetInventoryRequest
            {
                InventoryName = InventoryName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                View = InventoryView.Unspecified,
            };
            // Make the request
            Inventory response = osConfigZonalServiceClient.GetInventory(request);
            // End snippet
        }

        /// <summary>Snippet for GetInventoryAsync</summary>
        public async Task GetInventoryRequestObjectAsync()
        {
            // Snippet: GetInventoryAsync(GetInventoryRequest, CallSettings)
            // Additional: GetInventoryAsync(GetInventoryRequest, CancellationToken)
            // Create client
            OsConfigZonalServiceClient osConfigZonalServiceClient = await OsConfigZonalServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetInventoryRequest request = new GetInventoryRequest
            {
                InventoryName = InventoryName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                View = InventoryView.Unspecified,
            };
            // Make the request
            Inventory response = await osConfigZonalServiceClient.GetInventoryAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetInventory</summary>
        public void GetInventory()
        {
            // Snippet: GetInventory(string, CallSettings)
            // Create client
            OsConfigZonalServiceClient osConfigZonalServiceClient = OsConfigZonalServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]/inventory";
            // Make the request
            Inventory response = osConfigZonalServiceClient.GetInventory(name);
            // End snippet
        }

        /// <summary>Snippet for GetInventoryAsync</summary>
        public async Task GetInventoryAsync()
        {
            // Snippet: GetInventoryAsync(string, CallSettings)
            // Additional: GetInventoryAsync(string, CancellationToken)
            // Create client
            OsConfigZonalServiceClient osConfigZonalServiceClient = await OsConfigZonalServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]/inventory";
            // Make the request
            Inventory response = await osConfigZonalServiceClient.GetInventoryAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetInventory</summary>
        public void GetInventoryResourceNames()
        {
            // Snippet: GetInventory(InventoryName, CallSettings)
            // Create client
            OsConfigZonalServiceClient osConfigZonalServiceClient = OsConfigZonalServiceClient.Create();
            // Initialize request argument(s)
            InventoryName name = InventoryName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            // Make the request
            Inventory response = osConfigZonalServiceClient.GetInventory(name);
            // End snippet
        }

        /// <summary>Snippet for GetInventoryAsync</summary>
        public async Task GetInventoryResourceNamesAsync()
        {
            // Snippet: GetInventoryAsync(InventoryName, CallSettings)
            // Additional: GetInventoryAsync(InventoryName, CancellationToken)
            // Create client
            OsConfigZonalServiceClient osConfigZonalServiceClient = await OsConfigZonalServiceClient.CreateAsync();
            // Initialize request argument(s)
            InventoryName name = InventoryName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            // Make the request
            Inventory response = await osConfigZonalServiceClient.GetInventoryAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListInventories</summary>
        public void ListInventoriesRequestObject()
        {
            // Snippet: ListInventories(ListInventoriesRequest, CallSettings)
            // Create client
            OsConfigZonalServiceClient osConfigZonalServiceClient = OsConfigZonalServiceClient.Create();
            // Initialize request argument(s)
            ListInventoriesRequest request = new ListInventoriesRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                View = InventoryView.Unspecified,
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListInventoriesResponse, Inventory> response = osConfigZonalServiceClient.ListInventories(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Inventory item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListInventoriesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Inventory item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Inventory> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Inventory item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInventoriesAsync</summary>
        public async Task ListInventoriesRequestObjectAsync()
        {
            // Snippet: ListInventoriesAsync(ListInventoriesRequest, CallSettings)
            // Create client
            OsConfigZonalServiceClient osConfigZonalServiceClient = await OsConfigZonalServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListInventoriesRequest request = new ListInventoriesRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                View = InventoryView.Unspecified,
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListInventoriesResponse, Inventory> response = osConfigZonalServiceClient.ListInventoriesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Inventory item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListInventoriesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Inventory item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Inventory> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Inventory item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInventories</summary>
        public void ListInventories()
        {
            // Snippet: ListInventories(string, string, int?, CallSettings)
            // Create client
            OsConfigZonalServiceClient osConfigZonalServiceClient = OsConfigZonalServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            // Make the request
            PagedEnumerable<ListInventoriesResponse, Inventory> response = osConfigZonalServiceClient.ListInventories(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Inventory item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListInventoriesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Inventory item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Inventory> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Inventory item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInventoriesAsync</summary>
        public async Task ListInventoriesAsync()
        {
            // Snippet: ListInventoriesAsync(string, string, int?, CallSettings)
            // Create client
            OsConfigZonalServiceClient osConfigZonalServiceClient = await OsConfigZonalServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            // Make the request
            PagedAsyncEnumerable<ListInventoriesResponse, Inventory> response = osConfigZonalServiceClient.ListInventoriesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Inventory item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListInventoriesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Inventory item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Inventory> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Inventory item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInventories</summary>
        public void ListInventoriesResourceNames()
        {
            // Snippet: ListInventories(InstanceName, string, int?, CallSettings)
            // Create client
            OsConfigZonalServiceClient osConfigZonalServiceClient = OsConfigZonalServiceClient.Create();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            // Make the request
            PagedEnumerable<ListInventoriesResponse, Inventory> response = osConfigZonalServiceClient.ListInventories(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Inventory item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListInventoriesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Inventory item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Inventory> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Inventory item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInventoriesAsync</summary>
        public async Task ListInventoriesResourceNamesAsync()
        {
            // Snippet: ListInventoriesAsync(InstanceName, string, int?, CallSettings)
            // Create client
            OsConfigZonalServiceClient osConfigZonalServiceClient = await OsConfigZonalServiceClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            // Make the request
            PagedAsyncEnumerable<ListInventoriesResponse, Inventory> response = osConfigZonalServiceClient.ListInventoriesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Inventory item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListInventoriesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Inventory item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Inventory> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Inventory item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetVulnerabilityReport</summary>
        public void GetVulnerabilityReportRequestObject()
        {
            // Snippet: GetVulnerabilityReport(GetVulnerabilityReportRequest, CallSettings)
            // Create client
            OsConfigZonalServiceClient osConfigZonalServiceClient = OsConfigZonalServiceClient.Create();
            // Initialize request argument(s)
            GetVulnerabilityReportRequest request = new GetVulnerabilityReportRequest
            {
                VulnerabilityReportName = VulnerabilityReportName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
            };
            // Make the request
            VulnerabilityReport response = osConfigZonalServiceClient.GetVulnerabilityReport(request);
            // End snippet
        }

        /// <summary>Snippet for GetVulnerabilityReportAsync</summary>
        public async Task GetVulnerabilityReportRequestObjectAsync()
        {
            // Snippet: GetVulnerabilityReportAsync(GetVulnerabilityReportRequest, CallSettings)
            // Additional: GetVulnerabilityReportAsync(GetVulnerabilityReportRequest, CancellationToken)
            // Create client
            OsConfigZonalServiceClient osConfigZonalServiceClient = await OsConfigZonalServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetVulnerabilityReportRequest request = new GetVulnerabilityReportRequest
            {
                VulnerabilityReportName = VulnerabilityReportName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
            };
            // Make the request
            VulnerabilityReport response = await osConfigZonalServiceClient.GetVulnerabilityReportAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetVulnerabilityReport</summary>
        public void GetVulnerabilityReport()
        {
            // Snippet: GetVulnerabilityReport(string, CallSettings)
            // Create client
            OsConfigZonalServiceClient osConfigZonalServiceClient = OsConfigZonalServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]/vulnerabilityReport";
            // Make the request
            VulnerabilityReport response = osConfigZonalServiceClient.GetVulnerabilityReport(name);
            // End snippet
        }

        /// <summary>Snippet for GetVulnerabilityReportAsync</summary>
        public async Task GetVulnerabilityReportAsync()
        {
            // Snippet: GetVulnerabilityReportAsync(string, CallSettings)
            // Additional: GetVulnerabilityReportAsync(string, CancellationToken)
            // Create client
            OsConfigZonalServiceClient osConfigZonalServiceClient = await OsConfigZonalServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]/vulnerabilityReport";
            // Make the request
            VulnerabilityReport response = await osConfigZonalServiceClient.GetVulnerabilityReportAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetVulnerabilityReport</summary>
        public void GetVulnerabilityReportResourceNames()
        {
            // Snippet: GetVulnerabilityReport(VulnerabilityReportName, CallSettings)
            // Create client
            OsConfigZonalServiceClient osConfigZonalServiceClient = OsConfigZonalServiceClient.Create();
            // Initialize request argument(s)
            VulnerabilityReportName name = VulnerabilityReportName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            // Make the request
            VulnerabilityReport response = osConfigZonalServiceClient.GetVulnerabilityReport(name);
            // End snippet
        }

        /// <summary>Snippet for GetVulnerabilityReportAsync</summary>
        public async Task GetVulnerabilityReportResourceNamesAsync()
        {
            // Snippet: GetVulnerabilityReportAsync(VulnerabilityReportName, CallSettings)
            // Additional: GetVulnerabilityReportAsync(VulnerabilityReportName, CancellationToken)
            // Create client
            OsConfigZonalServiceClient osConfigZonalServiceClient = await OsConfigZonalServiceClient.CreateAsync();
            // Initialize request argument(s)
            VulnerabilityReportName name = VulnerabilityReportName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            // Make the request
            VulnerabilityReport response = await osConfigZonalServiceClient.GetVulnerabilityReportAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListVulnerabilityReports</summary>
        public void ListVulnerabilityReportsRequestObject()
        {
            // Snippet: ListVulnerabilityReports(ListVulnerabilityReportsRequest, CallSettings)
            // Create client
            OsConfigZonalServiceClient osConfigZonalServiceClient = OsConfigZonalServiceClient.Create();
            // Initialize request argument(s)
            ListVulnerabilityReportsRequest request = new ListVulnerabilityReportsRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListVulnerabilityReportsResponse, VulnerabilityReport> response = osConfigZonalServiceClient.ListVulnerabilityReports(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (VulnerabilityReport item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListVulnerabilityReportsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (VulnerabilityReport item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<VulnerabilityReport> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (VulnerabilityReport item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListVulnerabilityReportsAsync</summary>
        public async Task ListVulnerabilityReportsRequestObjectAsync()
        {
            // Snippet: ListVulnerabilityReportsAsync(ListVulnerabilityReportsRequest, CallSettings)
            // Create client
            OsConfigZonalServiceClient osConfigZonalServiceClient = await OsConfigZonalServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListVulnerabilityReportsRequest request = new ListVulnerabilityReportsRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListVulnerabilityReportsResponse, VulnerabilityReport> response = osConfigZonalServiceClient.ListVulnerabilityReportsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((VulnerabilityReport item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListVulnerabilityReportsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (VulnerabilityReport item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<VulnerabilityReport> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (VulnerabilityReport item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListVulnerabilityReports</summary>
        public void ListVulnerabilityReports()
        {
            // Snippet: ListVulnerabilityReports(string, string, int?, CallSettings)
            // Create client
            OsConfigZonalServiceClient osConfigZonalServiceClient = OsConfigZonalServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            // Make the request
            PagedEnumerable<ListVulnerabilityReportsResponse, VulnerabilityReport> response = osConfigZonalServiceClient.ListVulnerabilityReports(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (VulnerabilityReport item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListVulnerabilityReportsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (VulnerabilityReport item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<VulnerabilityReport> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (VulnerabilityReport item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListVulnerabilityReportsAsync</summary>
        public async Task ListVulnerabilityReportsAsync()
        {
            // Snippet: ListVulnerabilityReportsAsync(string, string, int?, CallSettings)
            // Create client
            OsConfigZonalServiceClient osConfigZonalServiceClient = await OsConfigZonalServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            // Make the request
            PagedAsyncEnumerable<ListVulnerabilityReportsResponse, VulnerabilityReport> response = osConfigZonalServiceClient.ListVulnerabilityReportsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((VulnerabilityReport item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListVulnerabilityReportsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (VulnerabilityReport item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<VulnerabilityReport> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (VulnerabilityReport item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListVulnerabilityReports</summary>
        public void ListVulnerabilityReportsResourceNames()
        {
            // Snippet: ListVulnerabilityReports(InstanceName, string, int?, CallSettings)
            // Create client
            OsConfigZonalServiceClient osConfigZonalServiceClient = OsConfigZonalServiceClient.Create();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            // Make the request
            PagedEnumerable<ListVulnerabilityReportsResponse, VulnerabilityReport> response = osConfigZonalServiceClient.ListVulnerabilityReports(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (VulnerabilityReport item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListVulnerabilityReportsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (VulnerabilityReport item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<VulnerabilityReport> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (VulnerabilityReport item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListVulnerabilityReportsAsync</summary>
        public async Task ListVulnerabilityReportsResourceNamesAsync()
        {
            // Snippet: ListVulnerabilityReportsAsync(InstanceName, string, int?, CallSettings)
            // Create client
            OsConfigZonalServiceClient osConfigZonalServiceClient = await OsConfigZonalServiceClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            // Make the request
            PagedAsyncEnumerable<ListVulnerabilityReportsResponse, VulnerabilityReport> response = osConfigZonalServiceClient.ListVulnerabilityReportsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((VulnerabilityReport item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListVulnerabilityReportsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (VulnerabilityReport item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<VulnerabilityReport> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (VulnerabilityReport item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }
    }
}
