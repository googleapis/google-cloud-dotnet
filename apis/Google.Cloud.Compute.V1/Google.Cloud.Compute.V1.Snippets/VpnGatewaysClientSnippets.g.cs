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
    public sealed class GeneratedVpnGatewaysClientSnippets
    {
        /// <summary>Snippet for AggregatedList</summary>
        public void AggregatedListRequestObject()
        {
            // Snippet: AggregatedList(AggregatedListVpnGatewaysRequest, CallSettings)
            // Create client
            VpnGatewaysClient vpnGatewaysClient = VpnGatewaysClient.Create();
            // Initialize request argument(s)
            AggregatedListVpnGatewaysRequest request = new AggregatedListVpnGatewaysRequest
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
            VpnGatewayAggregatedList response = vpnGatewaysClient.AggregatedList(request);
            // End snippet
        }

        /// <summary>Snippet for AggregatedListAsync</summary>
        public async Task AggregatedListRequestObjectAsync()
        {
            // Snippet: AggregatedListAsync(AggregatedListVpnGatewaysRequest, CallSettings)
            // Additional: AggregatedListAsync(AggregatedListVpnGatewaysRequest, CancellationToken)
            // Create client
            VpnGatewaysClient vpnGatewaysClient = await VpnGatewaysClient.CreateAsync();
            // Initialize request argument(s)
            AggregatedListVpnGatewaysRequest request = new AggregatedListVpnGatewaysRequest
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
            VpnGatewayAggregatedList response = await vpnGatewaysClient.AggregatedListAsync(request);
            // End snippet
        }

        /// <summary>Snippet for AggregatedList</summary>
        public void AggregatedList()
        {
            // Snippet: AggregatedList(string, CallSettings)
            // Create client
            VpnGatewaysClient vpnGatewaysClient = VpnGatewaysClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            VpnGatewayAggregatedList response = vpnGatewaysClient.AggregatedList(project);
            // End snippet
        }

        /// <summary>Snippet for AggregatedListAsync</summary>
        public async Task AggregatedListAsync()
        {
            // Snippet: AggregatedListAsync(string, CallSettings)
            // Additional: AggregatedListAsync(string, CancellationToken)
            // Create client
            VpnGatewaysClient vpnGatewaysClient = await VpnGatewaysClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            VpnGatewayAggregatedList response = await vpnGatewaysClient.AggregatedListAsync(project);
            // End snippet
        }

        /// <summary>Snippet for Delete</summary>
        public void DeleteRequestObject()
        {
            // Snippet: Delete(DeleteVpnGatewayRequest, CallSettings)
            // Create client
            VpnGatewaysClient vpnGatewaysClient = VpnGatewaysClient.Create();
            // Initialize request argument(s)
            DeleteVpnGatewayRequest request = new DeleteVpnGatewayRequest
            {
                RequestId = "",
                VpnGateway = "",
                Region = "",
                Project = "",
            };
            // Make the request
            Operation response = vpnGatewaysClient.Delete(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAsync</summary>
        public async Task DeleteRequestObjectAsync()
        {
            // Snippet: DeleteAsync(DeleteVpnGatewayRequest, CallSettings)
            // Additional: DeleteAsync(DeleteVpnGatewayRequest, CancellationToken)
            // Create client
            VpnGatewaysClient vpnGatewaysClient = await VpnGatewaysClient.CreateAsync();
            // Initialize request argument(s)
            DeleteVpnGatewayRequest request = new DeleteVpnGatewayRequest
            {
                RequestId = "",
                VpnGateway = "",
                Region = "",
                Project = "",
            };
            // Make the request
            Operation response = await vpnGatewaysClient.DeleteAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Delete</summary>
        public void Delete()
        {
            // Snippet: Delete(string, string, string, CallSettings)
            // Create client
            VpnGatewaysClient vpnGatewaysClient = VpnGatewaysClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string vpnGateway = "";
            // Make the request
            Operation response = vpnGatewaysClient.Delete(project, region, vpnGateway);
            // End snippet
        }

        /// <summary>Snippet for DeleteAsync</summary>
        public async Task DeleteAsync()
        {
            // Snippet: DeleteAsync(string, string, string, CallSettings)
            // Additional: DeleteAsync(string, string, string, CancellationToken)
            // Create client
            VpnGatewaysClient vpnGatewaysClient = await VpnGatewaysClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string vpnGateway = "";
            // Make the request
            Operation response = await vpnGatewaysClient.DeleteAsync(project, region, vpnGateway);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void GetRequestObject()
        {
            // Snippet: Get(GetVpnGatewayRequest, CallSettings)
            // Create client
            VpnGatewaysClient vpnGatewaysClient = VpnGatewaysClient.Create();
            // Initialize request argument(s)
            GetVpnGatewayRequest request = new GetVpnGatewayRequest
            {
                VpnGateway = "",
                Region = "",
                Project = "",
            };
            // Make the request
            VpnGateway response = vpnGatewaysClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetVpnGatewayRequest, CallSettings)
            // Additional: GetAsync(GetVpnGatewayRequest, CancellationToken)
            // Create client
            VpnGatewaysClient vpnGatewaysClient = await VpnGatewaysClient.CreateAsync();
            // Initialize request argument(s)
            GetVpnGatewayRequest request = new GetVpnGatewayRequest
            {
                VpnGateway = "",
                Region = "",
                Project = "",
            };
            // Make the request
            VpnGateway response = await vpnGatewaysClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, string, CallSettings)
            // Create client
            VpnGatewaysClient vpnGatewaysClient = VpnGatewaysClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string vpnGateway = "";
            // Make the request
            VpnGateway response = vpnGatewaysClient.Get(project, region, vpnGateway);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, string, CallSettings)
            // Additional: GetAsync(string, string, string, CancellationToken)
            // Create client
            VpnGatewaysClient vpnGatewaysClient = await VpnGatewaysClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string vpnGateway = "";
            // Make the request
            VpnGateway response = await vpnGatewaysClient.GetAsync(project, region, vpnGateway);
            // End snippet
        }

        /// <summary>Snippet for GetStatus</summary>
        public void GetStatusRequestObject()
        {
            // Snippet: GetStatus(GetStatusVpnGatewayRequest, CallSettings)
            // Create client
            VpnGatewaysClient vpnGatewaysClient = VpnGatewaysClient.Create();
            // Initialize request argument(s)
            GetStatusVpnGatewayRequest request = new GetStatusVpnGatewayRequest
            {
                VpnGateway = "",
                Region = "",
                Project = "",
            };
            // Make the request
            VpnGatewaysGetStatusResponse response = vpnGatewaysClient.GetStatus(request);
            // End snippet
        }

        /// <summary>Snippet for GetStatusAsync</summary>
        public async Task GetStatusRequestObjectAsync()
        {
            // Snippet: GetStatusAsync(GetStatusVpnGatewayRequest, CallSettings)
            // Additional: GetStatusAsync(GetStatusVpnGatewayRequest, CancellationToken)
            // Create client
            VpnGatewaysClient vpnGatewaysClient = await VpnGatewaysClient.CreateAsync();
            // Initialize request argument(s)
            GetStatusVpnGatewayRequest request = new GetStatusVpnGatewayRequest
            {
                VpnGateway = "",
                Region = "",
                Project = "",
            };
            // Make the request
            VpnGatewaysGetStatusResponse response = await vpnGatewaysClient.GetStatusAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetStatus</summary>
        public void GetStatus()
        {
            // Snippet: GetStatus(string, string, string, CallSettings)
            // Create client
            VpnGatewaysClient vpnGatewaysClient = VpnGatewaysClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string vpnGateway = "";
            // Make the request
            VpnGatewaysGetStatusResponse response = vpnGatewaysClient.GetStatus(project, region, vpnGateway);
            // End snippet
        }

        /// <summary>Snippet for GetStatusAsync</summary>
        public async Task GetStatusAsync()
        {
            // Snippet: GetStatusAsync(string, string, string, CallSettings)
            // Additional: GetStatusAsync(string, string, string, CancellationToken)
            // Create client
            VpnGatewaysClient vpnGatewaysClient = await VpnGatewaysClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string vpnGateway = "";
            // Make the request
            VpnGatewaysGetStatusResponse response = await vpnGatewaysClient.GetStatusAsync(project, region, vpnGateway);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void InsertRequestObject()
        {
            // Snippet: Insert(InsertVpnGatewayRequest, CallSettings)
            // Create client
            VpnGatewaysClient vpnGatewaysClient = VpnGatewaysClient.Create();
            // Initialize request argument(s)
            InsertVpnGatewayRequest request = new InsertVpnGatewayRequest
            {
                RequestId = "",
                Region = "",
                VpnGatewayResource = new VpnGateway(),
                Project = "",
            };
            // Make the request
            Operation response = vpnGatewaysClient.Insert(request);
            // End snippet
        }

        /// <summary>Snippet for InsertAsync</summary>
        public async Task InsertRequestObjectAsync()
        {
            // Snippet: InsertAsync(InsertVpnGatewayRequest, CallSettings)
            // Additional: InsertAsync(InsertVpnGatewayRequest, CancellationToken)
            // Create client
            VpnGatewaysClient vpnGatewaysClient = await VpnGatewaysClient.CreateAsync();
            // Initialize request argument(s)
            InsertVpnGatewayRequest request = new InsertVpnGatewayRequest
            {
                RequestId = "",
                Region = "",
                VpnGatewayResource = new VpnGateway(),
                Project = "",
            };
            // Make the request
            Operation response = await vpnGatewaysClient.InsertAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void Insert()
        {
            // Snippet: Insert(string, string, VpnGateway, CallSettings)
            // Create client
            VpnGatewaysClient vpnGatewaysClient = VpnGatewaysClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            VpnGateway vpnGatewayResource = new VpnGateway();
            // Make the request
            Operation response = vpnGatewaysClient.Insert(project, region, vpnGatewayResource);
            // End snippet
        }

        /// <summary>Snippet for InsertAsync</summary>
        public async Task InsertAsync()
        {
            // Snippet: InsertAsync(string, string, VpnGateway, CallSettings)
            // Additional: InsertAsync(string, string, VpnGateway, CancellationToken)
            // Create client
            VpnGatewaysClient vpnGatewaysClient = await VpnGatewaysClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            VpnGateway vpnGatewayResource = new VpnGateway();
            // Make the request
            Operation response = await vpnGatewaysClient.InsertAsync(project, region, vpnGatewayResource);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void ListRequestObject()
        {
            // Snippet: List(ListVpnGatewaysRequest, CallSettings)
            // Create client
            VpnGatewaysClient vpnGatewaysClient = VpnGatewaysClient.Create();
            // Initialize request argument(s)
            ListVpnGatewaysRequest request = new ListVpnGatewaysRequest
            {
                PageToken = "",
                MaxResults = 0U,
                Filter = "",
                Region = "",
                OrderBy = "",
                Project = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            VpnGatewayList response = vpnGatewaysClient.List(request);
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListRequestObjectAsync()
        {
            // Snippet: ListAsync(ListVpnGatewaysRequest, CallSettings)
            // Additional: ListAsync(ListVpnGatewaysRequest, CancellationToken)
            // Create client
            VpnGatewaysClient vpnGatewaysClient = await VpnGatewaysClient.CreateAsync();
            // Initialize request argument(s)
            ListVpnGatewaysRequest request = new ListVpnGatewaysRequest
            {
                PageToken = "",
                MaxResults = 0U,
                Filter = "",
                Region = "",
                OrderBy = "",
                Project = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            VpnGatewayList response = await vpnGatewaysClient.ListAsync(request);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void List()
        {
            // Snippet: List(string, string, CallSettings)
            // Create client
            VpnGatewaysClient vpnGatewaysClient = VpnGatewaysClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            VpnGatewayList response = vpnGatewaysClient.List(project, region);
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListAsync()
        {
            // Snippet: ListAsync(string, string, CallSettings)
            // Additional: ListAsync(string, string, CancellationToken)
            // Create client
            VpnGatewaysClient vpnGatewaysClient = await VpnGatewaysClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            VpnGatewayList response = await vpnGatewaysClient.ListAsync(project, region);
            // End snippet
        }

        /// <summary>Snippet for SetLabels</summary>
        public void SetLabelsRequestObject()
        {
            // Snippet: SetLabels(SetLabelsVpnGatewayRequest, CallSettings)
            // Create client
            VpnGatewaysClient vpnGatewaysClient = VpnGatewaysClient.Create();
            // Initialize request argument(s)
            SetLabelsVpnGatewayRequest request = new SetLabelsVpnGatewayRequest
            {
                RequestId = "",
                Region = "",
                Resource = "",
                Project = "",
                RegionSetLabelsRequestResource = new RegionSetLabelsRequest(),
            };
            // Make the request
            Operation response = vpnGatewaysClient.SetLabels(request);
            // End snippet
        }

        /// <summary>Snippet for SetLabelsAsync</summary>
        public async Task SetLabelsRequestObjectAsync()
        {
            // Snippet: SetLabelsAsync(SetLabelsVpnGatewayRequest, CallSettings)
            // Additional: SetLabelsAsync(SetLabelsVpnGatewayRequest, CancellationToken)
            // Create client
            VpnGatewaysClient vpnGatewaysClient = await VpnGatewaysClient.CreateAsync();
            // Initialize request argument(s)
            SetLabelsVpnGatewayRequest request = new SetLabelsVpnGatewayRequest
            {
                RequestId = "",
                Region = "",
                Resource = "",
                Project = "",
                RegionSetLabelsRequestResource = new RegionSetLabelsRequest(),
            };
            // Make the request
            Operation response = await vpnGatewaysClient.SetLabelsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetLabels</summary>
        public void SetLabels()
        {
            // Snippet: SetLabels(string, string, string, RegionSetLabelsRequest, CallSettings)
            // Create client
            VpnGatewaysClient vpnGatewaysClient = VpnGatewaysClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string resource = "";
            RegionSetLabelsRequest regionSetLabelsRequestResource = new RegionSetLabelsRequest();
            // Make the request
            Operation response = vpnGatewaysClient.SetLabels(project, region, resource, regionSetLabelsRequestResource);
            // End snippet
        }

        /// <summary>Snippet for SetLabelsAsync</summary>
        public async Task SetLabelsAsync()
        {
            // Snippet: SetLabelsAsync(string, string, string, RegionSetLabelsRequest, CallSettings)
            // Additional: SetLabelsAsync(string, string, string, RegionSetLabelsRequest, CancellationToken)
            // Create client
            VpnGatewaysClient vpnGatewaysClient = await VpnGatewaysClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string resource = "";
            RegionSetLabelsRequest regionSetLabelsRequestResource = new RegionSetLabelsRequest();
            // Make the request
            Operation response = await vpnGatewaysClient.SetLabelsAsync(project, region, resource, regionSetLabelsRequestResource);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissionsRequestObject()
        {
            // Snippet: TestIamPermissions(TestIamPermissionsVpnGatewayRequest, CallSettings)
            // Create client
            VpnGatewaysClient vpnGatewaysClient = VpnGatewaysClient.Create();
            // Initialize request argument(s)
            TestIamPermissionsVpnGatewayRequest request = new TestIamPermissionsVpnGatewayRequest
            {
                Region = "",
                TestPermissionsRequestResource = new TestPermissionsRequest(),
                Resource = "",
                Project = "",
            };
            // Make the request
            TestPermissionsResponse response = vpnGatewaysClient.TestIamPermissions(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsRequestObjectAsync()
        {
            // Snippet: TestIamPermissionsAsync(TestIamPermissionsVpnGatewayRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(TestIamPermissionsVpnGatewayRequest, CancellationToken)
            // Create client
            VpnGatewaysClient vpnGatewaysClient = await VpnGatewaysClient.CreateAsync();
            // Initialize request argument(s)
            TestIamPermissionsVpnGatewayRequest request = new TestIamPermissionsVpnGatewayRequest
            {
                Region = "",
                TestPermissionsRequestResource = new TestPermissionsRequest(),
                Resource = "",
                Project = "",
            };
            // Make the request
            TestPermissionsResponse response = await vpnGatewaysClient.TestIamPermissionsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissions()
        {
            // Snippet: TestIamPermissions(string, string, string, TestPermissionsRequest, CallSettings)
            // Create client
            VpnGatewaysClient vpnGatewaysClient = VpnGatewaysClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string resource = "";
            TestPermissionsRequest testPermissionsRequestResource = new TestPermissionsRequest();
            // Make the request
            TestPermissionsResponse response = vpnGatewaysClient.TestIamPermissions(project, region, resource, testPermissionsRequestResource);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsAsync()
        {
            // Snippet: TestIamPermissionsAsync(string, string, string, TestPermissionsRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(string, string, string, TestPermissionsRequest, CancellationToken)
            // Create client
            VpnGatewaysClient vpnGatewaysClient = await VpnGatewaysClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string resource = "";
            TestPermissionsRequest testPermissionsRequestResource = new TestPermissionsRequest();
            // Make the request
            TestPermissionsResponse response = await vpnGatewaysClient.TestIamPermissionsAsync(project, region, resource, testPermissionsRequestResource);
            // End snippet
        }
    }
}
