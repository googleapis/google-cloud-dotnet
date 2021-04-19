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
    public sealed class GeneratedNetworkEndpointGroupsClientSnippets
    {
        /// <summary>Snippet for AggregatedList</summary>
        public void AggregatedListRequestObject()
        {
            // Snippet: AggregatedList(AggregatedListNetworkEndpointGroupsRequest, CallSettings)
            // Create client
            NetworkEndpointGroupsClient networkEndpointGroupsClient = NetworkEndpointGroupsClient.Create();
            // Initialize request argument(s)
            AggregatedListNetworkEndpointGroupsRequest request = new AggregatedListNetworkEndpointGroupsRequest
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
            NetworkEndpointGroupAggregatedList response = networkEndpointGroupsClient.AggregatedList(request);
            // End snippet
        }

        /// <summary>Snippet for AggregatedListAsync</summary>
        public async Task AggregatedListRequestObjectAsync()
        {
            // Snippet: AggregatedListAsync(AggregatedListNetworkEndpointGroupsRequest, CallSettings)
            // Additional: AggregatedListAsync(AggregatedListNetworkEndpointGroupsRequest, CancellationToken)
            // Create client
            NetworkEndpointGroupsClient networkEndpointGroupsClient = await NetworkEndpointGroupsClient.CreateAsync();
            // Initialize request argument(s)
            AggregatedListNetworkEndpointGroupsRequest request = new AggregatedListNetworkEndpointGroupsRequest
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
            NetworkEndpointGroupAggregatedList response = await networkEndpointGroupsClient.AggregatedListAsync(request);
            // End snippet
        }

        /// <summary>Snippet for AggregatedList</summary>
        public void AggregatedList()
        {
            // Snippet: AggregatedList(string, CallSettings)
            // Create client
            NetworkEndpointGroupsClient networkEndpointGroupsClient = NetworkEndpointGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            NetworkEndpointGroupAggregatedList response = networkEndpointGroupsClient.AggregatedList(project);
            // End snippet
        }

        /// <summary>Snippet for AggregatedListAsync</summary>
        public async Task AggregatedListAsync()
        {
            // Snippet: AggregatedListAsync(string, CallSettings)
            // Additional: AggregatedListAsync(string, CancellationToken)
            // Create client
            NetworkEndpointGroupsClient networkEndpointGroupsClient = await NetworkEndpointGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            NetworkEndpointGroupAggregatedList response = await networkEndpointGroupsClient.AggregatedListAsync(project);
            // End snippet
        }

        /// <summary>Snippet for AttachNetworkEndpoints</summary>
        public void AttachNetworkEndpointsRequestObject()
        {
            // Snippet: AttachNetworkEndpoints(AttachNetworkEndpointsNetworkEndpointGroupRequest, CallSettings)
            // Create client
            NetworkEndpointGroupsClient networkEndpointGroupsClient = NetworkEndpointGroupsClient.Create();
            // Initialize request argument(s)
            AttachNetworkEndpointsNetworkEndpointGroupRequest request = new AttachNetworkEndpointsNetworkEndpointGroupRequest
            {
                NetworkEndpointGroupsAttachEndpointsRequestResource = new NetworkEndpointGroupsAttachEndpointsRequest(),
                Zone = "",
                RequestId = "",
                NetworkEndpointGroup = "",
                Project = "",
            };
            // Make the request
            Operation response = networkEndpointGroupsClient.AttachNetworkEndpoints(request);
            // End snippet
        }

        /// <summary>Snippet for AttachNetworkEndpointsAsync</summary>
        public async Task AttachNetworkEndpointsRequestObjectAsync()
        {
            // Snippet: AttachNetworkEndpointsAsync(AttachNetworkEndpointsNetworkEndpointGroupRequest, CallSettings)
            // Additional: AttachNetworkEndpointsAsync(AttachNetworkEndpointsNetworkEndpointGroupRequest, CancellationToken)
            // Create client
            NetworkEndpointGroupsClient networkEndpointGroupsClient = await NetworkEndpointGroupsClient.CreateAsync();
            // Initialize request argument(s)
            AttachNetworkEndpointsNetworkEndpointGroupRequest request = new AttachNetworkEndpointsNetworkEndpointGroupRequest
            {
                NetworkEndpointGroupsAttachEndpointsRequestResource = new NetworkEndpointGroupsAttachEndpointsRequest(),
                Zone = "",
                RequestId = "",
                NetworkEndpointGroup = "",
                Project = "",
            };
            // Make the request
            Operation response = await networkEndpointGroupsClient.AttachNetworkEndpointsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for AttachNetworkEndpoints</summary>
        public void AttachNetworkEndpoints()
        {
            // Snippet: AttachNetworkEndpoints(string, string, string, NetworkEndpointGroupsAttachEndpointsRequest, CallSettings)
            // Create client
            NetworkEndpointGroupsClient networkEndpointGroupsClient = NetworkEndpointGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string networkEndpointGroup = "";
            NetworkEndpointGroupsAttachEndpointsRequest networkEndpointGroupsAttachEndpointsRequestResource = new NetworkEndpointGroupsAttachEndpointsRequest();
            // Make the request
            Operation response = networkEndpointGroupsClient.AttachNetworkEndpoints(project, zone, networkEndpointGroup, networkEndpointGroupsAttachEndpointsRequestResource);
            // End snippet
        }

        /// <summary>Snippet for AttachNetworkEndpointsAsync</summary>
        public async Task AttachNetworkEndpointsAsync()
        {
            // Snippet: AttachNetworkEndpointsAsync(string, string, string, NetworkEndpointGroupsAttachEndpointsRequest, CallSettings)
            // Additional: AttachNetworkEndpointsAsync(string, string, string, NetworkEndpointGroupsAttachEndpointsRequest, CancellationToken)
            // Create client
            NetworkEndpointGroupsClient networkEndpointGroupsClient = await NetworkEndpointGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string networkEndpointGroup = "";
            NetworkEndpointGroupsAttachEndpointsRequest networkEndpointGroupsAttachEndpointsRequestResource = new NetworkEndpointGroupsAttachEndpointsRequest();
            // Make the request
            Operation response = await networkEndpointGroupsClient.AttachNetworkEndpointsAsync(project, zone, networkEndpointGroup, networkEndpointGroupsAttachEndpointsRequestResource);
            // End snippet
        }

        /// <summary>Snippet for Delete</summary>
        public void DeleteRequestObject()
        {
            // Snippet: Delete(DeleteNetworkEndpointGroupRequest, CallSettings)
            // Create client
            NetworkEndpointGroupsClient networkEndpointGroupsClient = NetworkEndpointGroupsClient.Create();
            // Initialize request argument(s)
            DeleteNetworkEndpointGroupRequest request = new DeleteNetworkEndpointGroupRequest
            {
                Zone = "",
                RequestId = "",
                NetworkEndpointGroup = "",
                Project = "",
            };
            // Make the request
            Operation response = networkEndpointGroupsClient.Delete(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAsync</summary>
        public async Task DeleteRequestObjectAsync()
        {
            // Snippet: DeleteAsync(DeleteNetworkEndpointGroupRequest, CallSettings)
            // Additional: DeleteAsync(DeleteNetworkEndpointGroupRequest, CancellationToken)
            // Create client
            NetworkEndpointGroupsClient networkEndpointGroupsClient = await NetworkEndpointGroupsClient.CreateAsync();
            // Initialize request argument(s)
            DeleteNetworkEndpointGroupRequest request = new DeleteNetworkEndpointGroupRequest
            {
                Zone = "",
                RequestId = "",
                NetworkEndpointGroup = "",
                Project = "",
            };
            // Make the request
            Operation response = await networkEndpointGroupsClient.DeleteAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Delete</summary>
        public void Delete()
        {
            // Snippet: Delete(string, string, string, CallSettings)
            // Create client
            NetworkEndpointGroupsClient networkEndpointGroupsClient = NetworkEndpointGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string networkEndpointGroup = "";
            // Make the request
            Operation response = networkEndpointGroupsClient.Delete(project, zone, networkEndpointGroup);
            // End snippet
        }

        /// <summary>Snippet for DeleteAsync</summary>
        public async Task DeleteAsync()
        {
            // Snippet: DeleteAsync(string, string, string, CallSettings)
            // Additional: DeleteAsync(string, string, string, CancellationToken)
            // Create client
            NetworkEndpointGroupsClient networkEndpointGroupsClient = await NetworkEndpointGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string networkEndpointGroup = "";
            // Make the request
            Operation response = await networkEndpointGroupsClient.DeleteAsync(project, zone, networkEndpointGroup);
            // End snippet
        }

        /// <summary>Snippet for DetachNetworkEndpoints</summary>
        public void DetachNetworkEndpointsRequestObject()
        {
            // Snippet: DetachNetworkEndpoints(DetachNetworkEndpointsNetworkEndpointGroupRequest, CallSettings)
            // Create client
            NetworkEndpointGroupsClient networkEndpointGroupsClient = NetworkEndpointGroupsClient.Create();
            // Initialize request argument(s)
            DetachNetworkEndpointsNetworkEndpointGroupRequest request = new DetachNetworkEndpointsNetworkEndpointGroupRequest
            {
                Zone = "",
                RequestId = "",
                NetworkEndpointGroup = "",
                Project = "",
                NetworkEndpointGroupsDetachEndpointsRequestResource = new NetworkEndpointGroupsDetachEndpointsRequest(),
            };
            // Make the request
            Operation response = networkEndpointGroupsClient.DetachNetworkEndpoints(request);
            // End snippet
        }

        /// <summary>Snippet for DetachNetworkEndpointsAsync</summary>
        public async Task DetachNetworkEndpointsRequestObjectAsync()
        {
            // Snippet: DetachNetworkEndpointsAsync(DetachNetworkEndpointsNetworkEndpointGroupRequest, CallSettings)
            // Additional: DetachNetworkEndpointsAsync(DetachNetworkEndpointsNetworkEndpointGroupRequest, CancellationToken)
            // Create client
            NetworkEndpointGroupsClient networkEndpointGroupsClient = await NetworkEndpointGroupsClient.CreateAsync();
            // Initialize request argument(s)
            DetachNetworkEndpointsNetworkEndpointGroupRequest request = new DetachNetworkEndpointsNetworkEndpointGroupRequest
            {
                Zone = "",
                RequestId = "",
                NetworkEndpointGroup = "",
                Project = "",
                NetworkEndpointGroupsDetachEndpointsRequestResource = new NetworkEndpointGroupsDetachEndpointsRequest(),
            };
            // Make the request
            Operation response = await networkEndpointGroupsClient.DetachNetworkEndpointsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DetachNetworkEndpoints</summary>
        public void DetachNetworkEndpoints()
        {
            // Snippet: DetachNetworkEndpoints(string, string, string, NetworkEndpointGroupsDetachEndpointsRequest, CallSettings)
            // Create client
            NetworkEndpointGroupsClient networkEndpointGroupsClient = NetworkEndpointGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string networkEndpointGroup = "";
            NetworkEndpointGroupsDetachEndpointsRequest networkEndpointGroupsDetachEndpointsRequestResource = new NetworkEndpointGroupsDetachEndpointsRequest();
            // Make the request
            Operation response = networkEndpointGroupsClient.DetachNetworkEndpoints(project, zone, networkEndpointGroup, networkEndpointGroupsDetachEndpointsRequestResource);
            // End snippet
        }

        /// <summary>Snippet for DetachNetworkEndpointsAsync</summary>
        public async Task DetachNetworkEndpointsAsync()
        {
            // Snippet: DetachNetworkEndpointsAsync(string, string, string, NetworkEndpointGroupsDetachEndpointsRequest, CallSettings)
            // Additional: DetachNetworkEndpointsAsync(string, string, string, NetworkEndpointGroupsDetachEndpointsRequest, CancellationToken)
            // Create client
            NetworkEndpointGroupsClient networkEndpointGroupsClient = await NetworkEndpointGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string networkEndpointGroup = "";
            NetworkEndpointGroupsDetachEndpointsRequest networkEndpointGroupsDetachEndpointsRequestResource = new NetworkEndpointGroupsDetachEndpointsRequest();
            // Make the request
            Operation response = await networkEndpointGroupsClient.DetachNetworkEndpointsAsync(project, zone, networkEndpointGroup, networkEndpointGroupsDetachEndpointsRequestResource);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void GetRequestObject()
        {
            // Snippet: Get(GetNetworkEndpointGroupRequest, CallSettings)
            // Create client
            NetworkEndpointGroupsClient networkEndpointGroupsClient = NetworkEndpointGroupsClient.Create();
            // Initialize request argument(s)
            GetNetworkEndpointGroupRequest request = new GetNetworkEndpointGroupRequest
            {
                Zone = "",
                NetworkEndpointGroup = "",
                Project = "",
            };
            // Make the request
            NetworkEndpointGroup response = networkEndpointGroupsClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetNetworkEndpointGroupRequest, CallSettings)
            // Additional: GetAsync(GetNetworkEndpointGroupRequest, CancellationToken)
            // Create client
            NetworkEndpointGroupsClient networkEndpointGroupsClient = await NetworkEndpointGroupsClient.CreateAsync();
            // Initialize request argument(s)
            GetNetworkEndpointGroupRequest request = new GetNetworkEndpointGroupRequest
            {
                Zone = "",
                NetworkEndpointGroup = "",
                Project = "",
            };
            // Make the request
            NetworkEndpointGroup response = await networkEndpointGroupsClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, string, CallSettings)
            // Create client
            NetworkEndpointGroupsClient networkEndpointGroupsClient = NetworkEndpointGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string networkEndpointGroup = "";
            // Make the request
            NetworkEndpointGroup response = networkEndpointGroupsClient.Get(project, zone, networkEndpointGroup);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, string, CallSettings)
            // Additional: GetAsync(string, string, string, CancellationToken)
            // Create client
            NetworkEndpointGroupsClient networkEndpointGroupsClient = await NetworkEndpointGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string networkEndpointGroup = "";
            // Make the request
            NetworkEndpointGroup response = await networkEndpointGroupsClient.GetAsync(project, zone, networkEndpointGroup);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void InsertRequestObject()
        {
            // Snippet: Insert(InsertNetworkEndpointGroupRequest, CallSettings)
            // Create client
            NetworkEndpointGroupsClient networkEndpointGroupsClient = NetworkEndpointGroupsClient.Create();
            // Initialize request argument(s)
            InsertNetworkEndpointGroupRequest request = new InsertNetworkEndpointGroupRequest
            {
                Zone = "",
                RequestId = "",
                Project = "",
                NetworkEndpointGroupResource = new NetworkEndpointGroup(),
            };
            // Make the request
            Operation response = networkEndpointGroupsClient.Insert(request);
            // End snippet
        }

        /// <summary>Snippet for InsertAsync</summary>
        public async Task InsertRequestObjectAsync()
        {
            // Snippet: InsertAsync(InsertNetworkEndpointGroupRequest, CallSettings)
            // Additional: InsertAsync(InsertNetworkEndpointGroupRequest, CancellationToken)
            // Create client
            NetworkEndpointGroupsClient networkEndpointGroupsClient = await NetworkEndpointGroupsClient.CreateAsync();
            // Initialize request argument(s)
            InsertNetworkEndpointGroupRequest request = new InsertNetworkEndpointGroupRequest
            {
                Zone = "",
                RequestId = "",
                Project = "",
                NetworkEndpointGroupResource = new NetworkEndpointGroup(),
            };
            // Make the request
            Operation response = await networkEndpointGroupsClient.InsertAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void Insert()
        {
            // Snippet: Insert(string, string, NetworkEndpointGroup, CallSettings)
            // Create client
            NetworkEndpointGroupsClient networkEndpointGroupsClient = NetworkEndpointGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            NetworkEndpointGroup networkEndpointGroupResource = new NetworkEndpointGroup();
            // Make the request
            Operation response = networkEndpointGroupsClient.Insert(project, zone, networkEndpointGroupResource);
            // End snippet
        }

        /// <summary>Snippet for InsertAsync</summary>
        public async Task InsertAsync()
        {
            // Snippet: InsertAsync(string, string, NetworkEndpointGroup, CallSettings)
            // Additional: InsertAsync(string, string, NetworkEndpointGroup, CancellationToken)
            // Create client
            NetworkEndpointGroupsClient networkEndpointGroupsClient = await NetworkEndpointGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            NetworkEndpointGroup networkEndpointGroupResource = new NetworkEndpointGroup();
            // Make the request
            Operation response = await networkEndpointGroupsClient.InsertAsync(project, zone, networkEndpointGroupResource);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void ListRequestObject()
        {
            // Snippet: List(ListNetworkEndpointGroupsRequest, CallSettings)
            // Create client
            NetworkEndpointGroupsClient networkEndpointGroupsClient = NetworkEndpointGroupsClient.Create();
            // Initialize request argument(s)
            ListNetworkEndpointGroupsRequest request = new ListNetworkEndpointGroupsRequest
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
            NetworkEndpointGroupList response = networkEndpointGroupsClient.List(request);
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListRequestObjectAsync()
        {
            // Snippet: ListAsync(ListNetworkEndpointGroupsRequest, CallSettings)
            // Additional: ListAsync(ListNetworkEndpointGroupsRequest, CancellationToken)
            // Create client
            NetworkEndpointGroupsClient networkEndpointGroupsClient = await NetworkEndpointGroupsClient.CreateAsync();
            // Initialize request argument(s)
            ListNetworkEndpointGroupsRequest request = new ListNetworkEndpointGroupsRequest
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
            NetworkEndpointGroupList response = await networkEndpointGroupsClient.ListAsync(request);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void List()
        {
            // Snippet: List(string, string, CallSettings)
            // Create client
            NetworkEndpointGroupsClient networkEndpointGroupsClient = NetworkEndpointGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            // Make the request
            NetworkEndpointGroupList response = networkEndpointGroupsClient.List(project, zone);
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListAsync()
        {
            // Snippet: ListAsync(string, string, CallSettings)
            // Additional: ListAsync(string, string, CancellationToken)
            // Create client
            NetworkEndpointGroupsClient networkEndpointGroupsClient = await NetworkEndpointGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            // Make the request
            NetworkEndpointGroupList response = await networkEndpointGroupsClient.ListAsync(project, zone);
            // End snippet
        }

        /// <summary>Snippet for ListNetworkEndpoints</summary>
        public void ListNetworkEndpointsRequestObject()
        {
            // Snippet: ListNetworkEndpoints(ListNetworkEndpointsNetworkEndpointGroupsRequest, CallSettings)
            // Create client
            NetworkEndpointGroupsClient networkEndpointGroupsClient = NetworkEndpointGroupsClient.Create();
            // Initialize request argument(s)
            ListNetworkEndpointsNetworkEndpointGroupsRequest request = new ListNetworkEndpointsNetworkEndpointGroupsRequest
            {
                Zone = "",
                PageToken = "",
                MaxResults = 0U,
                NetworkEndpointGroupsListEndpointsRequestResource = new NetworkEndpointGroupsListEndpointsRequest(),
                Filter = "",
                OrderBy = "",
                NetworkEndpointGroup = "",
                Project = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            NetworkEndpointGroupsListNetworkEndpoints response = networkEndpointGroupsClient.ListNetworkEndpoints(request);
            // End snippet
        }

        /// <summary>Snippet for ListNetworkEndpointsAsync</summary>
        public async Task ListNetworkEndpointsRequestObjectAsync()
        {
            // Snippet: ListNetworkEndpointsAsync(ListNetworkEndpointsNetworkEndpointGroupsRequest, CallSettings)
            // Additional: ListNetworkEndpointsAsync(ListNetworkEndpointsNetworkEndpointGroupsRequest, CancellationToken)
            // Create client
            NetworkEndpointGroupsClient networkEndpointGroupsClient = await NetworkEndpointGroupsClient.CreateAsync();
            // Initialize request argument(s)
            ListNetworkEndpointsNetworkEndpointGroupsRequest request = new ListNetworkEndpointsNetworkEndpointGroupsRequest
            {
                Zone = "",
                PageToken = "",
                MaxResults = 0U,
                NetworkEndpointGroupsListEndpointsRequestResource = new NetworkEndpointGroupsListEndpointsRequest(),
                Filter = "",
                OrderBy = "",
                NetworkEndpointGroup = "",
                Project = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            NetworkEndpointGroupsListNetworkEndpoints response = await networkEndpointGroupsClient.ListNetworkEndpointsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ListNetworkEndpoints</summary>
        public void ListNetworkEndpoints()
        {
            // Snippet: ListNetworkEndpoints(string, string, string, NetworkEndpointGroupsListEndpointsRequest, CallSettings)
            // Create client
            NetworkEndpointGroupsClient networkEndpointGroupsClient = NetworkEndpointGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string networkEndpointGroup = "";
            NetworkEndpointGroupsListEndpointsRequest networkEndpointGroupsListEndpointsRequestResource = new NetworkEndpointGroupsListEndpointsRequest();
            // Make the request
            NetworkEndpointGroupsListNetworkEndpoints response = networkEndpointGroupsClient.ListNetworkEndpoints(project, zone, networkEndpointGroup, networkEndpointGroupsListEndpointsRequestResource);
            // End snippet
        }

        /// <summary>Snippet for ListNetworkEndpointsAsync</summary>
        public async Task ListNetworkEndpointsAsync()
        {
            // Snippet: ListNetworkEndpointsAsync(string, string, string, NetworkEndpointGroupsListEndpointsRequest, CallSettings)
            // Additional: ListNetworkEndpointsAsync(string, string, string, NetworkEndpointGroupsListEndpointsRequest, CancellationToken)
            // Create client
            NetworkEndpointGroupsClient networkEndpointGroupsClient = await NetworkEndpointGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string networkEndpointGroup = "";
            NetworkEndpointGroupsListEndpointsRequest networkEndpointGroupsListEndpointsRequestResource = new NetworkEndpointGroupsListEndpointsRequest();
            // Make the request
            NetworkEndpointGroupsListNetworkEndpoints response = await networkEndpointGroupsClient.ListNetworkEndpointsAsync(project, zone, networkEndpointGroup, networkEndpointGroupsListEndpointsRequestResource);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissionsRequestObject()
        {
            // Snippet: TestIamPermissions(TestIamPermissionsNetworkEndpointGroupRequest, CallSettings)
            // Create client
            NetworkEndpointGroupsClient networkEndpointGroupsClient = NetworkEndpointGroupsClient.Create();
            // Initialize request argument(s)
            TestIamPermissionsNetworkEndpointGroupRequest request = new TestIamPermissionsNetworkEndpointGroupRequest
            {
                Zone = "",
                TestPermissionsRequestResource = new TestPermissionsRequest(),
                Resource = "",
                Project = "",
            };
            // Make the request
            TestPermissionsResponse response = networkEndpointGroupsClient.TestIamPermissions(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsRequestObjectAsync()
        {
            // Snippet: TestIamPermissionsAsync(TestIamPermissionsNetworkEndpointGroupRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(TestIamPermissionsNetworkEndpointGroupRequest, CancellationToken)
            // Create client
            NetworkEndpointGroupsClient networkEndpointGroupsClient = await NetworkEndpointGroupsClient.CreateAsync();
            // Initialize request argument(s)
            TestIamPermissionsNetworkEndpointGroupRequest request = new TestIamPermissionsNetworkEndpointGroupRequest
            {
                Zone = "",
                TestPermissionsRequestResource = new TestPermissionsRequest(),
                Resource = "",
                Project = "",
            };
            // Make the request
            TestPermissionsResponse response = await networkEndpointGroupsClient.TestIamPermissionsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissions()
        {
            // Snippet: TestIamPermissions(string, string, string, TestPermissionsRequest, CallSettings)
            // Create client
            NetworkEndpointGroupsClient networkEndpointGroupsClient = NetworkEndpointGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string resource = "";
            TestPermissionsRequest testPermissionsRequestResource = new TestPermissionsRequest();
            // Make the request
            TestPermissionsResponse response = networkEndpointGroupsClient.TestIamPermissions(project, zone, resource, testPermissionsRequestResource);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsAsync()
        {
            // Snippet: TestIamPermissionsAsync(string, string, string, TestPermissionsRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(string, string, string, TestPermissionsRequest, CancellationToken)
            // Create client
            NetworkEndpointGroupsClient networkEndpointGroupsClient = await NetworkEndpointGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string resource = "";
            TestPermissionsRequest testPermissionsRequestResource = new TestPermissionsRequest();
            // Make the request
            TestPermissionsResponse response = await networkEndpointGroupsClient.TestIamPermissionsAsync(project, zone, resource, testPermissionsRequestResource);
            // End snippet
        }
    }
}
