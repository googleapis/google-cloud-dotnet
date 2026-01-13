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

#pragma warning disable CS8981

namespace GoogleCSharpSnippets
{
    using Google.Api.Gax;
    using Google.Cloud.Compute.V1;
    using System;
    using System.Threading.Tasks;
    using lro = Google.LongRunning;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedReservationBlocksClientSnippets
    {
        /// <summary>Snippet for Get</summary>
        public void GetRequestObject()
        {
            // Snippet: Get(GetReservationBlockRequest, CallSettings)
            // Create client
            ReservationBlocksClient reservationBlocksClient = ReservationBlocksClient.Create();
            // Initialize request argument(s)
            GetReservationBlockRequest request = new GetReservationBlockRequest
            {
                View = "",
                Zone = "",
                Reservation = "",
                Project = "",
                ReservationBlock = "",
            };
            // Make the request
            ReservationBlocksGetResponse response = reservationBlocksClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetReservationBlockRequest, CallSettings)
            // Additional: GetAsync(GetReservationBlockRequest, CancellationToken)
            // Create client
            ReservationBlocksClient reservationBlocksClient = await ReservationBlocksClient.CreateAsync();
            // Initialize request argument(s)
            GetReservationBlockRequest request = new GetReservationBlockRequest
            {
                View = "",
                Zone = "",
                Reservation = "",
                Project = "",
                ReservationBlock = "",
            };
            // Make the request
            ReservationBlocksGetResponse response = await reservationBlocksClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, string, string, CallSettings)
            // Create client
            ReservationBlocksClient reservationBlocksClient = ReservationBlocksClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string reservation = "";
            string reservationBlock = "";
            // Make the request
            ReservationBlocksGetResponse response = reservationBlocksClient.Get(project, zone, reservation, reservationBlock);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, string, string, CallSettings)
            // Additional: GetAsync(string, string, string, string, CancellationToken)
            // Create client
            ReservationBlocksClient reservationBlocksClient = await ReservationBlocksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string reservation = "";
            string reservationBlock = "";
            // Make the request
            ReservationBlocksGetResponse response = await reservationBlocksClient.GetAsync(project, zone, reservation, reservationBlock);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicyRequestObject()
        {
            // Snippet: GetIamPolicy(GetIamPolicyReservationBlockRequest, CallSettings)
            // Create client
            ReservationBlocksClient reservationBlocksClient = ReservationBlocksClient.Create();
            // Initialize request argument(s)
            GetIamPolicyReservationBlockRequest request = new GetIamPolicyReservationBlockRequest
            {
                Zone = "",
                ParentResource = "",
                Resource = "",
                Project = "",
                OptionsRequestedPolicyVersion = 0,
            };
            // Make the request
            Policy response = reservationBlocksClient.GetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyRequestObjectAsync()
        {
            // Snippet: GetIamPolicyAsync(GetIamPolicyReservationBlockRequest, CallSettings)
            // Additional: GetIamPolicyAsync(GetIamPolicyReservationBlockRequest, CancellationToken)
            // Create client
            ReservationBlocksClient reservationBlocksClient = await ReservationBlocksClient.CreateAsync();
            // Initialize request argument(s)
            GetIamPolicyReservationBlockRequest request = new GetIamPolicyReservationBlockRequest
            {
                Zone = "",
                ParentResource = "",
                Resource = "",
                Project = "",
                OptionsRequestedPolicyVersion = 0,
            };
            // Make the request
            Policy response = await reservationBlocksClient.GetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicy()
        {
            // Snippet: GetIamPolicy(string, string, string, string, CallSettings)
            // Create client
            ReservationBlocksClient reservationBlocksClient = ReservationBlocksClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string parentResource = "";
            string resource = "";
            // Make the request
            Policy response = reservationBlocksClient.GetIamPolicy(project, zone, parentResource, resource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyAsync()
        {
            // Snippet: GetIamPolicyAsync(string, string, string, string, CallSettings)
            // Additional: GetIamPolicyAsync(string, string, string, string, CancellationToken)
            // Create client
            ReservationBlocksClient reservationBlocksClient = await ReservationBlocksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string parentResource = "";
            string resource = "";
            // Make the request
            Policy response = await reservationBlocksClient.GetIamPolicyAsync(project, zone, parentResource, resource);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void ListRequestObject()
        {
            // Snippet: List(ListReservationBlocksRequest, CallSettings)
            // Create client
            ReservationBlocksClient reservationBlocksClient = ReservationBlocksClient.Create();
            // Initialize request argument(s)
            ListReservationBlocksRequest request = new ListReservationBlocksRequest
            {
                Zone = "",
                Reservation = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<ReservationBlocksListResponse, ReservationBlock> response = reservationBlocksClient.List(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ReservationBlock item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ReservationBlocksListResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ReservationBlock item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ReservationBlock> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ReservationBlock item in singlePage)
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
            // Snippet: ListAsync(ListReservationBlocksRequest, CallSettings)
            // Create client
            ReservationBlocksClient reservationBlocksClient = await ReservationBlocksClient.CreateAsync();
            // Initialize request argument(s)
            ListReservationBlocksRequest request = new ListReservationBlocksRequest
            {
                Zone = "",
                Reservation = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<ReservationBlocksListResponse, ReservationBlock> response = reservationBlocksClient.ListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (ReservationBlock item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ReservationBlocksListResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ReservationBlock item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ReservationBlock> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ReservationBlock item in singlePage)
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
            // Snippet: List(string, string, string, string, int?, CallSettings)
            // Create client
            ReservationBlocksClient reservationBlocksClient = ReservationBlocksClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string reservation = "";
            // Make the request
            PagedEnumerable<ReservationBlocksListResponse, ReservationBlock> response = reservationBlocksClient.List(project, zone, reservation);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ReservationBlock item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ReservationBlocksListResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ReservationBlock item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ReservationBlock> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ReservationBlock item in singlePage)
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
            // Snippet: ListAsync(string, string, string, string, int?, CallSettings)
            // Create client
            ReservationBlocksClient reservationBlocksClient = await ReservationBlocksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string reservation = "";
            // Make the request
            PagedAsyncEnumerable<ReservationBlocksListResponse, ReservationBlock> response = reservationBlocksClient.ListAsync(project, zone, reservation);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (ReservationBlock item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ReservationBlocksListResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ReservationBlock item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ReservationBlock> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ReservationBlock item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for PerformMaintenance</summary>
        public void PerformMaintenanceRequestObject()
        {
            // Snippet: PerformMaintenance(PerformMaintenanceReservationBlockRequest, CallSettings)
            // Create client
            ReservationBlocksClient reservationBlocksClient = ReservationBlocksClient.Create();
            // Initialize request argument(s)
            PerformMaintenanceReservationBlockRequest request = new PerformMaintenanceReservationBlockRequest
            {
                Zone = "",
                RequestId = "",
                Reservation = "",
                Project = "",
                ReservationsBlocksPerformMaintenanceRequestResource = new ReservationsBlocksPerformMaintenanceRequest(),
                ReservationBlock = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = reservationBlocksClient.PerformMaintenance(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = reservationBlocksClient.PollOncePerformMaintenance(operationName);
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
            // Snippet: PerformMaintenanceAsync(PerformMaintenanceReservationBlockRequest, CallSettings)
            // Additional: PerformMaintenanceAsync(PerformMaintenanceReservationBlockRequest, CancellationToken)
            // Create client
            ReservationBlocksClient reservationBlocksClient = await ReservationBlocksClient.CreateAsync();
            // Initialize request argument(s)
            PerformMaintenanceReservationBlockRequest request = new PerformMaintenanceReservationBlockRequest
            {
                Zone = "",
                RequestId = "",
                Reservation = "",
                Project = "",
                ReservationsBlocksPerformMaintenanceRequestResource = new ReservationsBlocksPerformMaintenanceRequest(),
                ReservationBlock = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await reservationBlocksClient.PerformMaintenanceAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await reservationBlocksClient.PollOncePerformMaintenanceAsync(operationName);
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
            // Snippet: PerformMaintenance(string, string, string, string, ReservationsBlocksPerformMaintenanceRequest, CallSettings)
            // Create client
            ReservationBlocksClient reservationBlocksClient = ReservationBlocksClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string reservation = "";
            string reservationBlock = "";
            ReservationsBlocksPerformMaintenanceRequest reservationsBlocksPerformMaintenanceRequestResource = new ReservationsBlocksPerformMaintenanceRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = reservationBlocksClient.PerformMaintenance(project, zone, reservation, reservationBlock, reservationsBlocksPerformMaintenanceRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = reservationBlocksClient.PollOncePerformMaintenance(operationName);
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
            // Snippet: PerformMaintenanceAsync(string, string, string, string, ReservationsBlocksPerformMaintenanceRequest, CallSettings)
            // Additional: PerformMaintenanceAsync(string, string, string, string, ReservationsBlocksPerformMaintenanceRequest, CancellationToken)
            // Create client
            ReservationBlocksClient reservationBlocksClient = await ReservationBlocksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string reservation = "";
            string reservationBlock = "";
            ReservationsBlocksPerformMaintenanceRequest reservationsBlocksPerformMaintenanceRequestResource = new ReservationsBlocksPerformMaintenanceRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = await reservationBlocksClient.PerformMaintenanceAsync(project, zone, reservation, reservationBlock, reservationsBlocksPerformMaintenanceRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await reservationBlocksClient.PollOncePerformMaintenanceAsync(operationName);
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
            // Snippet: SetIamPolicy(SetIamPolicyReservationBlockRequest, CallSettings)
            // Create client
            ReservationBlocksClient reservationBlocksClient = ReservationBlocksClient.Create();
            // Initialize request argument(s)
            SetIamPolicyReservationBlockRequest request = new SetIamPolicyReservationBlockRequest
            {
                Zone = "",
                ParentResource = "",
                Resource = "",
                Project = "",
                ZoneSetNestedPolicyRequestResource = new ZoneSetNestedPolicyRequest(),
            };
            // Make the request
            Policy response = reservationBlocksClient.SetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyRequestObjectAsync()
        {
            // Snippet: SetIamPolicyAsync(SetIamPolicyReservationBlockRequest, CallSettings)
            // Additional: SetIamPolicyAsync(SetIamPolicyReservationBlockRequest, CancellationToken)
            // Create client
            ReservationBlocksClient reservationBlocksClient = await ReservationBlocksClient.CreateAsync();
            // Initialize request argument(s)
            SetIamPolicyReservationBlockRequest request = new SetIamPolicyReservationBlockRequest
            {
                Zone = "",
                ParentResource = "",
                Resource = "",
                Project = "",
                ZoneSetNestedPolicyRequestResource = new ZoneSetNestedPolicyRequest(),
            };
            // Make the request
            Policy response = await reservationBlocksClient.SetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicy()
        {
            // Snippet: SetIamPolicy(string, string, string, string, ZoneSetNestedPolicyRequest, CallSettings)
            // Create client
            ReservationBlocksClient reservationBlocksClient = ReservationBlocksClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string parentResource = "";
            string resource = "";
            ZoneSetNestedPolicyRequest zoneSetNestedPolicyRequestResource = new ZoneSetNestedPolicyRequest();
            // Make the request
            Policy response = reservationBlocksClient.SetIamPolicy(project, zone, parentResource, resource, zoneSetNestedPolicyRequestResource);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyAsync()
        {
            // Snippet: SetIamPolicyAsync(string, string, string, string, ZoneSetNestedPolicyRequest, CallSettings)
            // Additional: SetIamPolicyAsync(string, string, string, string, ZoneSetNestedPolicyRequest, CancellationToken)
            // Create client
            ReservationBlocksClient reservationBlocksClient = await ReservationBlocksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string parentResource = "";
            string resource = "";
            ZoneSetNestedPolicyRequest zoneSetNestedPolicyRequestResource = new ZoneSetNestedPolicyRequest();
            // Make the request
            Policy response = await reservationBlocksClient.SetIamPolicyAsync(project, zone, parentResource, resource, zoneSetNestedPolicyRequestResource);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissionsRequestObject()
        {
            // Snippet: TestIamPermissions(TestIamPermissionsReservationBlockRequest, CallSettings)
            // Create client
            ReservationBlocksClient reservationBlocksClient = ReservationBlocksClient.Create();
            // Initialize request argument(s)
            TestIamPermissionsReservationBlockRequest request = new TestIamPermissionsReservationBlockRequest
            {
                Zone = "",
                ParentResource = "",
                Resource = "",
                Project = "",
                TestPermissionsRequestResource = new TestPermissionsRequest(),
            };
            // Make the request
            TestPermissionsResponse response = reservationBlocksClient.TestIamPermissions(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsRequestObjectAsync()
        {
            // Snippet: TestIamPermissionsAsync(TestIamPermissionsReservationBlockRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(TestIamPermissionsReservationBlockRequest, CancellationToken)
            // Create client
            ReservationBlocksClient reservationBlocksClient = await ReservationBlocksClient.CreateAsync();
            // Initialize request argument(s)
            TestIamPermissionsReservationBlockRequest request = new TestIamPermissionsReservationBlockRequest
            {
                Zone = "",
                ParentResource = "",
                Resource = "",
                Project = "",
                TestPermissionsRequestResource = new TestPermissionsRequest(),
            };
            // Make the request
            TestPermissionsResponse response = await reservationBlocksClient.TestIamPermissionsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissions()
        {
            // Snippet: TestIamPermissions(string, string, string, string, TestPermissionsRequest, CallSettings)
            // Create client
            ReservationBlocksClient reservationBlocksClient = ReservationBlocksClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string parentResource = "";
            string resource = "";
            TestPermissionsRequest testPermissionsRequestResource = new TestPermissionsRequest();
            // Make the request
            TestPermissionsResponse response = reservationBlocksClient.TestIamPermissions(project, zone, parentResource, resource, testPermissionsRequestResource);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsAsync()
        {
            // Snippet: TestIamPermissionsAsync(string, string, string, string, TestPermissionsRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(string, string, string, string, TestPermissionsRequest, CancellationToken)
            // Create client
            ReservationBlocksClient reservationBlocksClient = await ReservationBlocksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string parentResource = "";
            string resource = "";
            TestPermissionsRequest testPermissionsRequestResource = new TestPermissionsRequest();
            // Make the request
            TestPermissionsResponse response = await reservationBlocksClient.TestIamPermissionsAsync(project, zone, parentResource, resource, testPermissionsRequestResource);
            // End snippet
        }
    }
}
