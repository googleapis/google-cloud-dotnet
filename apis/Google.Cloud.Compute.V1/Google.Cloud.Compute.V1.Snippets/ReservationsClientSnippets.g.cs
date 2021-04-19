// Copyright 2021 Google LLC
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

namespace Google.Cloud.Compute.V1.Snippets
{
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedReservationsClientSnippets
    {
        /// <summary>Snippet for AggregatedList</summary>
        public void AggregatedListRequestObject()
        {
            // Snippet: AggregatedList(AggregatedListReservationsRequest, CallSettings)
            // Create client
            ReservationsClient reservationsClient = ReservationsClient.Create();
            // Initialize request argument(s)
            AggregatedListReservationsRequest request = new AggregatedListReservationsRequest
            {
                PageToken = "",
                MaxResults = 0U,
                Filter = "",
                IncludeAllScopes = false,
                OrderBy = "",
                Project = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            ReservationAggregatedList response = reservationsClient.AggregatedList(request);
            // End snippet
        }

        /// <summary>Snippet for AggregatedListAsync</summary>
        public async Task AggregatedListRequestObjectAsync()
        {
            // Snippet: AggregatedListAsync(AggregatedListReservationsRequest, CallSettings)
            // Additional: AggregatedListAsync(AggregatedListReservationsRequest, CancellationToken)
            // Create client
            ReservationsClient reservationsClient = await ReservationsClient.CreateAsync();
            // Initialize request argument(s)
            AggregatedListReservationsRequest request = new AggregatedListReservationsRequest
            {
                PageToken = "",
                MaxResults = 0U,
                Filter = "",
                IncludeAllScopes = false,
                OrderBy = "",
                Project = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            ReservationAggregatedList response = await reservationsClient.AggregatedListAsync(request);
            // End snippet
        }

        /// <summary>Snippet for AggregatedList</summary>
        public void AggregatedList()
        {
            // Snippet: AggregatedList(string, CallSettings)
            // Create client
            ReservationsClient reservationsClient = ReservationsClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            ReservationAggregatedList response = reservationsClient.AggregatedList(project);
            // End snippet
        }

        /// <summary>Snippet for AggregatedListAsync</summary>
        public async Task AggregatedListAsync()
        {
            // Snippet: AggregatedListAsync(string, CallSettings)
            // Additional: AggregatedListAsync(string, CancellationToken)
            // Create client
            ReservationsClient reservationsClient = await ReservationsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            ReservationAggregatedList response = await reservationsClient.AggregatedListAsync(project);
            // End snippet
        }

        /// <summary>Snippet for Delete</summary>
        public void DeleteRequestObject()
        {
            // Snippet: Delete(DeleteReservationRequest, CallSettings)
            // Create client
            ReservationsClient reservationsClient = ReservationsClient.Create();
            // Initialize request argument(s)
            DeleteReservationRequest request = new DeleteReservationRequest
            {
                Zone = "",
                RequestId = "",
                Reservation = "",
                Project = "",
            };
            // Make the request
            Operation response = reservationsClient.Delete(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAsync</summary>
        public async Task DeleteRequestObjectAsync()
        {
            // Snippet: DeleteAsync(DeleteReservationRequest, CallSettings)
            // Additional: DeleteAsync(DeleteReservationRequest, CancellationToken)
            // Create client
            ReservationsClient reservationsClient = await ReservationsClient.CreateAsync();
            // Initialize request argument(s)
            DeleteReservationRequest request = new DeleteReservationRequest
            {
                Zone = "",
                RequestId = "",
                Reservation = "",
                Project = "",
            };
            // Make the request
            Operation response = await reservationsClient.DeleteAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Delete</summary>
        public void Delete()
        {
            // Snippet: Delete(string, string, string, CallSettings)
            // Create client
            ReservationsClient reservationsClient = ReservationsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string reservation = "";
            // Make the request
            Operation response = reservationsClient.Delete(project, zone, reservation);
            // End snippet
        }

        /// <summary>Snippet for DeleteAsync</summary>
        public async Task DeleteAsync()
        {
            // Snippet: DeleteAsync(string, string, string, CallSettings)
            // Additional: DeleteAsync(string, string, string, CancellationToken)
            // Create client
            ReservationsClient reservationsClient = await ReservationsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string reservation = "";
            // Make the request
            Operation response = await reservationsClient.DeleteAsync(project, zone, reservation);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void GetRequestObject()
        {
            // Snippet: Get(GetReservationRequest, CallSettings)
            // Create client
            ReservationsClient reservationsClient = ReservationsClient.Create();
            // Initialize request argument(s)
            GetReservationRequest request = new GetReservationRequest
            {
                Zone = "",
                Reservation = "",
                Project = "",
            };
            // Make the request
            Reservation response = reservationsClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetReservationRequest, CallSettings)
            // Additional: GetAsync(GetReservationRequest, CancellationToken)
            // Create client
            ReservationsClient reservationsClient = await ReservationsClient.CreateAsync();
            // Initialize request argument(s)
            GetReservationRequest request = new GetReservationRequest
            {
                Zone = "",
                Reservation = "",
                Project = "",
            };
            // Make the request
            Reservation response = await reservationsClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, string, CallSettings)
            // Create client
            ReservationsClient reservationsClient = ReservationsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string reservation = "";
            // Make the request
            Reservation response = reservationsClient.Get(project, zone, reservation);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, string, CallSettings)
            // Additional: GetAsync(string, string, string, CancellationToken)
            // Create client
            ReservationsClient reservationsClient = await ReservationsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string reservation = "";
            // Make the request
            Reservation response = await reservationsClient.GetAsync(project, zone, reservation);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicyRequestObject()
        {
            // Snippet: GetIamPolicy(GetIamPolicyReservationRequest, CallSettings)
            // Create client
            ReservationsClient reservationsClient = ReservationsClient.Create();
            // Initialize request argument(s)
            GetIamPolicyReservationRequest request = new GetIamPolicyReservationRequest
            {
                Zone = "",
                Resource = "",
                Project = "",
                OptionsRequestedPolicyVersion = 0,
            };
            // Make the request
            Policy response = reservationsClient.GetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyRequestObjectAsync()
        {
            // Snippet: GetIamPolicyAsync(GetIamPolicyReservationRequest, CallSettings)
            // Additional: GetIamPolicyAsync(GetIamPolicyReservationRequest, CancellationToken)
            // Create client
            ReservationsClient reservationsClient = await ReservationsClient.CreateAsync();
            // Initialize request argument(s)
            GetIamPolicyReservationRequest request = new GetIamPolicyReservationRequest
            {
                Zone = "",
                Resource = "",
                Project = "",
                OptionsRequestedPolicyVersion = 0,
            };
            // Make the request
            Policy response = await reservationsClient.GetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicy()
        {
            // Snippet: GetIamPolicy(string, string, string, CallSettings)
            // Create client
            ReservationsClient reservationsClient = ReservationsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string resource = "";
            // Make the request
            Policy response = reservationsClient.GetIamPolicy(project, zone, resource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyAsync()
        {
            // Snippet: GetIamPolicyAsync(string, string, string, CallSettings)
            // Additional: GetIamPolicyAsync(string, string, string, CancellationToken)
            // Create client
            ReservationsClient reservationsClient = await ReservationsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string resource = "";
            // Make the request
            Policy response = await reservationsClient.GetIamPolicyAsync(project, zone, resource);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void InsertRequestObject()
        {
            // Snippet: Insert(InsertReservationRequest, CallSettings)
            // Create client
            ReservationsClient reservationsClient = ReservationsClient.Create();
            // Initialize request argument(s)
            InsertReservationRequest request = new InsertReservationRequest
            {
                Zone = "",
                ReservationResource = new Reservation(),
                RequestId = "",
                Project = "",
            };
            // Make the request
            Operation response = reservationsClient.Insert(request);
            // End snippet
        }

        /// <summary>Snippet for InsertAsync</summary>
        public async Task InsertRequestObjectAsync()
        {
            // Snippet: InsertAsync(InsertReservationRequest, CallSettings)
            // Additional: InsertAsync(InsertReservationRequest, CancellationToken)
            // Create client
            ReservationsClient reservationsClient = await ReservationsClient.CreateAsync();
            // Initialize request argument(s)
            InsertReservationRequest request = new InsertReservationRequest
            {
                Zone = "",
                ReservationResource = new Reservation(),
                RequestId = "",
                Project = "",
            };
            // Make the request
            Operation response = await reservationsClient.InsertAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void Insert()
        {
            // Snippet: Insert(string, string, Reservation, CallSettings)
            // Create client
            ReservationsClient reservationsClient = ReservationsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            Reservation reservationResource = new Reservation();
            // Make the request
            Operation response = reservationsClient.Insert(project, zone, reservationResource);
            // End snippet
        }

        /// <summary>Snippet for InsertAsync</summary>
        public async Task InsertAsync()
        {
            // Snippet: InsertAsync(string, string, Reservation, CallSettings)
            // Additional: InsertAsync(string, string, Reservation, CancellationToken)
            // Create client
            ReservationsClient reservationsClient = await ReservationsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            Reservation reservationResource = new Reservation();
            // Make the request
            Operation response = await reservationsClient.InsertAsync(project, zone, reservationResource);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void ListRequestObject()
        {
            // Snippet: List(ListReservationsRequest, CallSettings)
            // Create client
            ReservationsClient reservationsClient = ReservationsClient.Create();
            // Initialize request argument(s)
            ListReservationsRequest request = new ListReservationsRequest
            {
                Zone = "",
                PageToken = "",
                MaxResults = 0U,
                Filter = "",
                OrderBy = "",
                Project = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            ReservationList response = reservationsClient.List(request);
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListRequestObjectAsync()
        {
            // Snippet: ListAsync(ListReservationsRequest, CallSettings)
            // Additional: ListAsync(ListReservationsRequest, CancellationToken)
            // Create client
            ReservationsClient reservationsClient = await ReservationsClient.CreateAsync();
            // Initialize request argument(s)
            ListReservationsRequest request = new ListReservationsRequest
            {
                Zone = "",
                PageToken = "",
                MaxResults = 0U,
                Filter = "",
                OrderBy = "",
                Project = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            ReservationList response = await reservationsClient.ListAsync(request);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void List()
        {
            // Snippet: List(string, string, CallSettings)
            // Create client
            ReservationsClient reservationsClient = ReservationsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            // Make the request
            ReservationList response = reservationsClient.List(project, zone);
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListAsync()
        {
            // Snippet: ListAsync(string, string, CallSettings)
            // Additional: ListAsync(string, string, CancellationToken)
            // Create client
            ReservationsClient reservationsClient = await ReservationsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            // Make the request
            ReservationList response = await reservationsClient.ListAsync(project, zone);
            // End snippet
        }

        /// <summary>Snippet for Resize</summary>
        public void ResizeRequestObject()
        {
            // Snippet: Resize(ResizeReservationRequest, CallSettings)
            // Create client
            ReservationsClient reservationsClient = ReservationsClient.Create();
            // Initialize request argument(s)
            ResizeReservationRequest request = new ResizeReservationRequest
            {
                Zone = "",
                RequestId = "",
                Reservation = "",
                ReservationsResizeRequestResource = new ReservationsResizeRequest(),
                Project = "",
            };
            // Make the request
            Operation response = reservationsClient.Resize(request);
            // End snippet
        }

        /// <summary>Snippet for ResizeAsync</summary>
        public async Task ResizeRequestObjectAsync()
        {
            // Snippet: ResizeAsync(ResizeReservationRequest, CallSettings)
            // Additional: ResizeAsync(ResizeReservationRequest, CancellationToken)
            // Create client
            ReservationsClient reservationsClient = await ReservationsClient.CreateAsync();
            // Initialize request argument(s)
            ResizeReservationRequest request = new ResizeReservationRequest
            {
                Zone = "",
                RequestId = "",
                Reservation = "",
                ReservationsResizeRequestResource = new ReservationsResizeRequest(),
                Project = "",
            };
            // Make the request
            Operation response = await reservationsClient.ResizeAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Resize</summary>
        public void Resize()
        {
            // Snippet: Resize(string, string, string, ReservationsResizeRequest, CallSettings)
            // Create client
            ReservationsClient reservationsClient = ReservationsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string reservation = "";
            ReservationsResizeRequest reservationsResizeRequestResource = new ReservationsResizeRequest();
            // Make the request
            Operation response = reservationsClient.Resize(project, zone, reservation, reservationsResizeRequestResource);
            // End snippet
        }

        /// <summary>Snippet for ResizeAsync</summary>
        public async Task ResizeAsync()
        {
            // Snippet: ResizeAsync(string, string, string, ReservationsResizeRequest, CallSettings)
            // Additional: ResizeAsync(string, string, string, ReservationsResizeRequest, CancellationToken)
            // Create client
            ReservationsClient reservationsClient = await ReservationsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string reservation = "";
            ReservationsResizeRequest reservationsResizeRequestResource = new ReservationsResizeRequest();
            // Make the request
            Operation response = await reservationsClient.ResizeAsync(project, zone, reservation, reservationsResizeRequestResource);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicyRequestObject()
        {
            // Snippet: SetIamPolicy(SetIamPolicyReservationRequest, CallSettings)
            // Create client
            ReservationsClient reservationsClient = ReservationsClient.Create();
            // Initialize request argument(s)
            SetIamPolicyReservationRequest request = new SetIamPolicyReservationRequest
            {
                Zone = "",
                ZoneSetPolicyRequestResource = new ZoneSetPolicyRequest(),
                Resource = "",
                Project = "",
            };
            // Make the request
            Policy response = reservationsClient.SetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyRequestObjectAsync()
        {
            // Snippet: SetIamPolicyAsync(SetIamPolicyReservationRequest, CallSettings)
            // Additional: SetIamPolicyAsync(SetIamPolicyReservationRequest, CancellationToken)
            // Create client
            ReservationsClient reservationsClient = await ReservationsClient.CreateAsync();
            // Initialize request argument(s)
            SetIamPolicyReservationRequest request = new SetIamPolicyReservationRequest
            {
                Zone = "",
                ZoneSetPolicyRequestResource = new ZoneSetPolicyRequest(),
                Resource = "",
                Project = "",
            };
            // Make the request
            Policy response = await reservationsClient.SetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicy()
        {
            // Snippet: SetIamPolicy(string, string, string, ZoneSetPolicyRequest, CallSettings)
            // Create client
            ReservationsClient reservationsClient = ReservationsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string resource = "";
            ZoneSetPolicyRequest zoneSetPolicyRequestResource = new ZoneSetPolicyRequest();
            // Make the request
            Policy response = reservationsClient.SetIamPolicy(project, zone, resource, zoneSetPolicyRequestResource);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyAsync()
        {
            // Snippet: SetIamPolicyAsync(string, string, string, ZoneSetPolicyRequest, CallSettings)
            // Additional: SetIamPolicyAsync(string, string, string, ZoneSetPolicyRequest, CancellationToken)
            // Create client
            ReservationsClient reservationsClient = await ReservationsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string resource = "";
            ZoneSetPolicyRequest zoneSetPolicyRequestResource = new ZoneSetPolicyRequest();
            // Make the request
            Policy response = await reservationsClient.SetIamPolicyAsync(project, zone, resource, zoneSetPolicyRequestResource);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissionsRequestObject()
        {
            // Snippet: TestIamPermissions(TestIamPermissionsReservationRequest, CallSettings)
            // Create client
            ReservationsClient reservationsClient = ReservationsClient.Create();
            // Initialize request argument(s)
            TestIamPermissionsReservationRequest request = new TestIamPermissionsReservationRequest
            {
                Zone = "",
                TestPermissionsRequestResource = new TestPermissionsRequest(),
                Resource = "",
                Project = "",
            };
            // Make the request
            TestPermissionsResponse response = reservationsClient.TestIamPermissions(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsRequestObjectAsync()
        {
            // Snippet: TestIamPermissionsAsync(TestIamPermissionsReservationRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(TestIamPermissionsReservationRequest, CancellationToken)
            // Create client
            ReservationsClient reservationsClient = await ReservationsClient.CreateAsync();
            // Initialize request argument(s)
            TestIamPermissionsReservationRequest request = new TestIamPermissionsReservationRequest
            {
                Zone = "",
                TestPermissionsRequestResource = new TestPermissionsRequest(),
                Resource = "",
                Project = "",
            };
            // Make the request
            TestPermissionsResponse response = await reservationsClient.TestIamPermissionsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissions()
        {
            // Snippet: TestIamPermissions(string, string, string, TestPermissionsRequest, CallSettings)
            // Create client
            ReservationsClient reservationsClient = ReservationsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string resource = "";
            TestPermissionsRequest testPermissionsRequestResource = new TestPermissionsRequest();
            // Make the request
            TestPermissionsResponse response = reservationsClient.TestIamPermissions(project, zone, resource, testPermissionsRequestResource);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsAsync()
        {
            // Snippet: TestIamPermissionsAsync(string, string, string, TestPermissionsRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(string, string, string, TestPermissionsRequest, CancellationToken)
            // Create client
            ReservationsClient reservationsClient = await ReservationsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string resource = "";
            TestPermissionsRequest testPermissionsRequestResource = new TestPermissionsRequest();
            // Make the request
            TestPermissionsResponse response = await reservationsClient.TestIamPermissionsAsync(project, zone, resource, testPermissionsRequestResource);
            // End snippet
        }
    }
}
