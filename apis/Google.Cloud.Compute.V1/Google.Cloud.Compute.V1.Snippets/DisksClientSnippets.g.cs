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
    public sealed class GeneratedDisksClientSnippets
    {
        /// <summary>Snippet for AddResourcePolicies</summary>
        public void AddResourcePoliciesRequestObject()
        {
            // Snippet: AddResourcePolicies(AddResourcePoliciesDiskRequest, CallSettings)
            // Create client
            DisksClient disksClient = DisksClient.Create();
            // Initialize request argument(s)
            AddResourcePoliciesDiskRequest request = new AddResourcePoliciesDiskRequest
            {
                Disk = "",
                Zone = "",
                RequestId = "",
                Project = "",
                DisksAddResourcePoliciesRequestResource = new DisksAddResourcePoliciesRequest(),
            };
            // Make the request
            Operation response = disksClient.AddResourcePolicies(request);
            // End snippet
        }

        /// <summary>Snippet for AddResourcePoliciesAsync</summary>
        public async Task AddResourcePoliciesRequestObjectAsync()
        {
            // Snippet: AddResourcePoliciesAsync(AddResourcePoliciesDiskRequest, CallSettings)
            // Additional: AddResourcePoliciesAsync(AddResourcePoliciesDiskRequest, CancellationToken)
            // Create client
            DisksClient disksClient = await DisksClient.CreateAsync();
            // Initialize request argument(s)
            AddResourcePoliciesDiskRequest request = new AddResourcePoliciesDiskRequest
            {
                Disk = "",
                Zone = "",
                RequestId = "",
                Project = "",
                DisksAddResourcePoliciesRequestResource = new DisksAddResourcePoliciesRequest(),
            };
            // Make the request
            Operation response = await disksClient.AddResourcePoliciesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for AddResourcePolicies</summary>
        public void AddResourcePolicies()
        {
            // Snippet: AddResourcePolicies(string, string, string, DisksAddResourcePoliciesRequest, CallSettings)
            // Create client
            DisksClient disksClient = DisksClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string disk = "";
            DisksAddResourcePoliciesRequest disksAddResourcePoliciesRequestResource = new DisksAddResourcePoliciesRequest();
            // Make the request
            Operation response = disksClient.AddResourcePolicies(project, zone, disk, disksAddResourcePoliciesRequestResource);
            // End snippet
        }

        /// <summary>Snippet for AddResourcePoliciesAsync</summary>
        public async Task AddResourcePoliciesAsync()
        {
            // Snippet: AddResourcePoliciesAsync(string, string, string, DisksAddResourcePoliciesRequest, CallSettings)
            // Additional: AddResourcePoliciesAsync(string, string, string, DisksAddResourcePoliciesRequest, CancellationToken)
            // Create client
            DisksClient disksClient = await DisksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string disk = "";
            DisksAddResourcePoliciesRequest disksAddResourcePoliciesRequestResource = new DisksAddResourcePoliciesRequest();
            // Make the request
            Operation response = await disksClient.AddResourcePoliciesAsync(project, zone, disk, disksAddResourcePoliciesRequestResource);
            // End snippet
        }

        /// <summary>Snippet for AggregatedList</summary>
        public void AggregatedListRequestObject()
        {
            // Snippet: AggregatedList(AggregatedListDisksRequest, CallSettings)
            // Create client
            DisksClient disksClient = DisksClient.Create();
            // Initialize request argument(s)
            AggregatedListDisksRequest request = new AggregatedListDisksRequest
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
            DiskAggregatedList response = disksClient.AggregatedList(request);
            // End snippet
        }

        /// <summary>Snippet for AggregatedListAsync</summary>
        public async Task AggregatedListRequestObjectAsync()
        {
            // Snippet: AggregatedListAsync(AggregatedListDisksRequest, CallSettings)
            // Additional: AggregatedListAsync(AggregatedListDisksRequest, CancellationToken)
            // Create client
            DisksClient disksClient = await DisksClient.CreateAsync();
            // Initialize request argument(s)
            AggregatedListDisksRequest request = new AggregatedListDisksRequest
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
            DiskAggregatedList response = await disksClient.AggregatedListAsync(request);
            // End snippet
        }

        /// <summary>Snippet for AggregatedList</summary>
        public void AggregatedList()
        {
            // Snippet: AggregatedList(string, CallSettings)
            // Create client
            DisksClient disksClient = DisksClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            DiskAggregatedList response = disksClient.AggregatedList(project);
            // End snippet
        }

        /// <summary>Snippet for AggregatedListAsync</summary>
        public async Task AggregatedListAsync()
        {
            // Snippet: AggregatedListAsync(string, CallSettings)
            // Additional: AggregatedListAsync(string, CancellationToken)
            // Create client
            DisksClient disksClient = await DisksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            DiskAggregatedList response = await disksClient.AggregatedListAsync(project);
            // End snippet
        }

        /// <summary>Snippet for CreateSnapshot</summary>
        public void CreateSnapshotRequestObject()
        {
            // Snippet: CreateSnapshot(CreateSnapshotDiskRequest, CallSettings)
            // Create client
            DisksClient disksClient = DisksClient.Create();
            // Initialize request argument(s)
            CreateSnapshotDiskRequest request = new CreateSnapshotDiskRequest
            {
                Disk = "",
                Zone = "",
                RequestId = "",
                GuestFlush = false,
                SnapshotResource = new Snapshot(),
                Project = "",
            };
            // Make the request
            Operation response = disksClient.CreateSnapshot(request);
            // End snippet
        }

        /// <summary>Snippet for CreateSnapshotAsync</summary>
        public async Task CreateSnapshotRequestObjectAsync()
        {
            // Snippet: CreateSnapshotAsync(CreateSnapshotDiskRequest, CallSettings)
            // Additional: CreateSnapshotAsync(CreateSnapshotDiskRequest, CancellationToken)
            // Create client
            DisksClient disksClient = await DisksClient.CreateAsync();
            // Initialize request argument(s)
            CreateSnapshotDiskRequest request = new CreateSnapshotDiskRequest
            {
                Disk = "",
                Zone = "",
                RequestId = "",
                GuestFlush = false,
                SnapshotResource = new Snapshot(),
                Project = "",
            };
            // Make the request
            Operation response = await disksClient.CreateSnapshotAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateSnapshot</summary>
        public void CreateSnapshot()
        {
            // Snippet: CreateSnapshot(string, string, string, Snapshot, CallSettings)
            // Create client
            DisksClient disksClient = DisksClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string disk = "";
            Snapshot snapshotResource = new Snapshot();
            // Make the request
            Operation response = disksClient.CreateSnapshot(project, zone, disk, snapshotResource);
            // End snippet
        }

        /// <summary>Snippet for CreateSnapshotAsync</summary>
        public async Task CreateSnapshotAsync()
        {
            // Snippet: CreateSnapshotAsync(string, string, string, Snapshot, CallSettings)
            // Additional: CreateSnapshotAsync(string, string, string, Snapshot, CancellationToken)
            // Create client
            DisksClient disksClient = await DisksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string disk = "";
            Snapshot snapshotResource = new Snapshot();
            // Make the request
            Operation response = await disksClient.CreateSnapshotAsync(project, zone, disk, snapshotResource);
            // End snippet
        }

        /// <summary>Snippet for Delete</summary>
        public void DeleteRequestObject()
        {
            // Snippet: Delete(DeleteDiskRequest, CallSettings)
            // Create client
            DisksClient disksClient = DisksClient.Create();
            // Initialize request argument(s)
            DeleteDiskRequest request = new DeleteDiskRequest
            {
                Disk = "",
                Zone = "",
                RequestId = "",
                Project = "",
            };
            // Make the request
            Operation response = disksClient.Delete(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAsync</summary>
        public async Task DeleteRequestObjectAsync()
        {
            // Snippet: DeleteAsync(DeleteDiskRequest, CallSettings)
            // Additional: DeleteAsync(DeleteDiskRequest, CancellationToken)
            // Create client
            DisksClient disksClient = await DisksClient.CreateAsync();
            // Initialize request argument(s)
            DeleteDiskRequest request = new DeleteDiskRequest
            {
                Disk = "",
                Zone = "",
                RequestId = "",
                Project = "",
            };
            // Make the request
            Operation response = await disksClient.DeleteAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Delete</summary>
        public void Delete()
        {
            // Snippet: Delete(string, string, string, CallSettings)
            // Create client
            DisksClient disksClient = DisksClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string disk = "";
            // Make the request
            Operation response = disksClient.Delete(project, zone, disk);
            // End snippet
        }

        /// <summary>Snippet for DeleteAsync</summary>
        public async Task DeleteAsync()
        {
            // Snippet: DeleteAsync(string, string, string, CallSettings)
            // Additional: DeleteAsync(string, string, string, CancellationToken)
            // Create client
            DisksClient disksClient = await DisksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string disk = "";
            // Make the request
            Operation response = await disksClient.DeleteAsync(project, zone, disk);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void GetRequestObject()
        {
            // Snippet: Get(GetDiskRequest, CallSettings)
            // Create client
            DisksClient disksClient = DisksClient.Create();
            // Initialize request argument(s)
            GetDiskRequest request = new GetDiskRequest
            {
                Disk = "",
                Zone = "",
                Project = "",
            };
            // Make the request
            Disk response = disksClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetDiskRequest, CallSettings)
            // Additional: GetAsync(GetDiskRequest, CancellationToken)
            // Create client
            DisksClient disksClient = await DisksClient.CreateAsync();
            // Initialize request argument(s)
            GetDiskRequest request = new GetDiskRequest
            {
                Disk = "",
                Zone = "",
                Project = "",
            };
            // Make the request
            Disk response = await disksClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, string, CallSettings)
            // Create client
            DisksClient disksClient = DisksClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string disk = "";
            // Make the request
            Disk response = disksClient.Get(project, zone, disk);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, string, CallSettings)
            // Additional: GetAsync(string, string, string, CancellationToken)
            // Create client
            DisksClient disksClient = await DisksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string disk = "";
            // Make the request
            Disk response = await disksClient.GetAsync(project, zone, disk);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicyRequestObject()
        {
            // Snippet: GetIamPolicy(GetIamPolicyDiskRequest, CallSettings)
            // Create client
            DisksClient disksClient = DisksClient.Create();
            // Initialize request argument(s)
            GetIamPolicyDiskRequest request = new GetIamPolicyDiskRequest
            {
                Zone = "",
                Resource = "",
                Project = "",
                OptionsRequestedPolicyVersion = 0,
            };
            // Make the request
            Policy response = disksClient.GetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyRequestObjectAsync()
        {
            // Snippet: GetIamPolicyAsync(GetIamPolicyDiskRequest, CallSettings)
            // Additional: GetIamPolicyAsync(GetIamPolicyDiskRequest, CancellationToken)
            // Create client
            DisksClient disksClient = await DisksClient.CreateAsync();
            // Initialize request argument(s)
            GetIamPolicyDiskRequest request = new GetIamPolicyDiskRequest
            {
                Zone = "",
                Resource = "",
                Project = "",
                OptionsRequestedPolicyVersion = 0,
            };
            // Make the request
            Policy response = await disksClient.GetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicy()
        {
            // Snippet: GetIamPolicy(string, string, string, CallSettings)
            // Create client
            DisksClient disksClient = DisksClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string resource = "";
            // Make the request
            Policy response = disksClient.GetIamPolicy(project, zone, resource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyAsync()
        {
            // Snippet: GetIamPolicyAsync(string, string, string, CallSettings)
            // Additional: GetIamPolicyAsync(string, string, string, CancellationToken)
            // Create client
            DisksClient disksClient = await DisksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string resource = "";
            // Make the request
            Policy response = await disksClient.GetIamPolicyAsync(project, zone, resource);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void InsertRequestObject()
        {
            // Snippet: Insert(InsertDiskRequest, CallSettings)
            // Create client
            DisksClient disksClient = DisksClient.Create();
            // Initialize request argument(s)
            InsertDiskRequest request = new InsertDiskRequest
            {
                Zone = "",
                DiskResource = new Disk(),
                RequestId = "",
                SourceImage = "",
                Project = "",
            };
            // Make the request
            Operation response = disksClient.Insert(request);
            // End snippet
        }

        /// <summary>Snippet for InsertAsync</summary>
        public async Task InsertRequestObjectAsync()
        {
            // Snippet: InsertAsync(InsertDiskRequest, CallSettings)
            // Additional: InsertAsync(InsertDiskRequest, CancellationToken)
            // Create client
            DisksClient disksClient = await DisksClient.CreateAsync();
            // Initialize request argument(s)
            InsertDiskRequest request = new InsertDiskRequest
            {
                Zone = "",
                DiskResource = new Disk(),
                RequestId = "",
                SourceImage = "",
                Project = "",
            };
            // Make the request
            Operation response = await disksClient.InsertAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void Insert()
        {
            // Snippet: Insert(string, string, Disk, CallSettings)
            // Create client
            DisksClient disksClient = DisksClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            Disk diskResource = new Disk();
            // Make the request
            Operation response = disksClient.Insert(project, zone, diskResource);
            // End snippet
        }

        /// <summary>Snippet for InsertAsync</summary>
        public async Task InsertAsync()
        {
            // Snippet: InsertAsync(string, string, Disk, CallSettings)
            // Additional: InsertAsync(string, string, Disk, CancellationToken)
            // Create client
            DisksClient disksClient = await DisksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            Disk diskResource = new Disk();
            // Make the request
            Operation response = await disksClient.InsertAsync(project, zone, diskResource);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void ListRequestObject()
        {
            // Snippet: List(ListDisksRequest, CallSettings)
            // Create client
            DisksClient disksClient = DisksClient.Create();
            // Initialize request argument(s)
            ListDisksRequest request = new ListDisksRequest
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
            DiskList response = disksClient.List(request);
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListRequestObjectAsync()
        {
            // Snippet: ListAsync(ListDisksRequest, CallSettings)
            // Additional: ListAsync(ListDisksRequest, CancellationToken)
            // Create client
            DisksClient disksClient = await DisksClient.CreateAsync();
            // Initialize request argument(s)
            ListDisksRequest request = new ListDisksRequest
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
            DiskList response = await disksClient.ListAsync(request);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void List()
        {
            // Snippet: List(string, string, CallSettings)
            // Create client
            DisksClient disksClient = DisksClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            // Make the request
            DiskList response = disksClient.List(project, zone);
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListAsync()
        {
            // Snippet: ListAsync(string, string, CallSettings)
            // Additional: ListAsync(string, string, CancellationToken)
            // Create client
            DisksClient disksClient = await DisksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            // Make the request
            DiskList response = await disksClient.ListAsync(project, zone);
            // End snippet
        }

        /// <summary>Snippet for RemoveResourcePolicies</summary>
        public void RemoveResourcePoliciesRequestObject()
        {
            // Snippet: RemoveResourcePolicies(RemoveResourcePoliciesDiskRequest, CallSettings)
            // Create client
            DisksClient disksClient = DisksClient.Create();
            // Initialize request argument(s)
            RemoveResourcePoliciesDiskRequest request = new RemoveResourcePoliciesDiskRequest
            {
                Disk = "",
                Zone = "",
                RequestId = "",
                DisksRemoveResourcePoliciesRequestResource = new DisksRemoveResourcePoliciesRequest(),
                Project = "",
            };
            // Make the request
            Operation response = disksClient.RemoveResourcePolicies(request);
            // End snippet
        }

        /// <summary>Snippet for RemoveResourcePoliciesAsync</summary>
        public async Task RemoveResourcePoliciesRequestObjectAsync()
        {
            // Snippet: RemoveResourcePoliciesAsync(RemoveResourcePoliciesDiskRequest, CallSettings)
            // Additional: RemoveResourcePoliciesAsync(RemoveResourcePoliciesDiskRequest, CancellationToken)
            // Create client
            DisksClient disksClient = await DisksClient.CreateAsync();
            // Initialize request argument(s)
            RemoveResourcePoliciesDiskRequest request = new RemoveResourcePoliciesDiskRequest
            {
                Disk = "",
                Zone = "",
                RequestId = "",
                DisksRemoveResourcePoliciesRequestResource = new DisksRemoveResourcePoliciesRequest(),
                Project = "",
            };
            // Make the request
            Operation response = await disksClient.RemoveResourcePoliciesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for RemoveResourcePolicies</summary>
        public void RemoveResourcePolicies()
        {
            // Snippet: RemoveResourcePolicies(string, string, string, DisksRemoveResourcePoliciesRequest, CallSettings)
            // Create client
            DisksClient disksClient = DisksClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string disk = "";
            DisksRemoveResourcePoliciesRequest disksRemoveResourcePoliciesRequestResource = new DisksRemoveResourcePoliciesRequest();
            // Make the request
            Operation response = disksClient.RemoveResourcePolicies(project, zone, disk, disksRemoveResourcePoliciesRequestResource);
            // End snippet
        }

        /// <summary>Snippet for RemoveResourcePoliciesAsync</summary>
        public async Task RemoveResourcePoliciesAsync()
        {
            // Snippet: RemoveResourcePoliciesAsync(string, string, string, DisksRemoveResourcePoliciesRequest, CallSettings)
            // Additional: RemoveResourcePoliciesAsync(string, string, string, DisksRemoveResourcePoliciesRequest, CancellationToken)
            // Create client
            DisksClient disksClient = await DisksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string disk = "";
            DisksRemoveResourcePoliciesRequest disksRemoveResourcePoliciesRequestResource = new DisksRemoveResourcePoliciesRequest();
            // Make the request
            Operation response = await disksClient.RemoveResourcePoliciesAsync(project, zone, disk, disksRemoveResourcePoliciesRequestResource);
            // End snippet
        }

        /// <summary>Snippet for Resize</summary>
        public void ResizeRequestObject()
        {
            // Snippet: Resize(ResizeDiskRequest, CallSettings)
            // Create client
            DisksClient disksClient = DisksClient.Create();
            // Initialize request argument(s)
            ResizeDiskRequest request = new ResizeDiskRequest
            {
                Disk = "",
                Zone = "",
                RequestId = "",
                DisksResizeRequestResource = new DisksResizeRequest(),
                Project = "",
            };
            // Make the request
            Operation response = disksClient.Resize(request);
            // End snippet
        }

        /// <summary>Snippet for ResizeAsync</summary>
        public async Task ResizeRequestObjectAsync()
        {
            // Snippet: ResizeAsync(ResizeDiskRequest, CallSettings)
            // Additional: ResizeAsync(ResizeDiskRequest, CancellationToken)
            // Create client
            DisksClient disksClient = await DisksClient.CreateAsync();
            // Initialize request argument(s)
            ResizeDiskRequest request = new ResizeDiskRequest
            {
                Disk = "",
                Zone = "",
                RequestId = "",
                DisksResizeRequestResource = new DisksResizeRequest(),
                Project = "",
            };
            // Make the request
            Operation response = await disksClient.ResizeAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Resize</summary>
        public void Resize()
        {
            // Snippet: Resize(string, string, string, DisksResizeRequest, CallSettings)
            // Create client
            DisksClient disksClient = DisksClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string disk = "";
            DisksResizeRequest disksResizeRequestResource = new DisksResizeRequest();
            // Make the request
            Operation response = disksClient.Resize(project, zone, disk, disksResizeRequestResource);
            // End snippet
        }

        /// <summary>Snippet for ResizeAsync</summary>
        public async Task ResizeAsync()
        {
            // Snippet: ResizeAsync(string, string, string, DisksResizeRequest, CallSettings)
            // Additional: ResizeAsync(string, string, string, DisksResizeRequest, CancellationToken)
            // Create client
            DisksClient disksClient = await DisksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string disk = "";
            DisksResizeRequest disksResizeRequestResource = new DisksResizeRequest();
            // Make the request
            Operation response = await disksClient.ResizeAsync(project, zone, disk, disksResizeRequestResource);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicyRequestObject()
        {
            // Snippet: SetIamPolicy(SetIamPolicyDiskRequest, CallSettings)
            // Create client
            DisksClient disksClient = DisksClient.Create();
            // Initialize request argument(s)
            SetIamPolicyDiskRequest request = new SetIamPolicyDiskRequest
            {
                Zone = "",
                ZoneSetPolicyRequestResource = new ZoneSetPolicyRequest(),
                Resource = "",
                Project = "",
            };
            // Make the request
            Policy response = disksClient.SetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyRequestObjectAsync()
        {
            // Snippet: SetIamPolicyAsync(SetIamPolicyDiskRequest, CallSettings)
            // Additional: SetIamPolicyAsync(SetIamPolicyDiskRequest, CancellationToken)
            // Create client
            DisksClient disksClient = await DisksClient.CreateAsync();
            // Initialize request argument(s)
            SetIamPolicyDiskRequest request = new SetIamPolicyDiskRequest
            {
                Zone = "",
                ZoneSetPolicyRequestResource = new ZoneSetPolicyRequest(),
                Resource = "",
                Project = "",
            };
            // Make the request
            Policy response = await disksClient.SetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicy()
        {
            // Snippet: SetIamPolicy(string, string, string, ZoneSetPolicyRequest, CallSettings)
            // Create client
            DisksClient disksClient = DisksClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string resource = "";
            ZoneSetPolicyRequest zoneSetPolicyRequestResource = new ZoneSetPolicyRequest();
            // Make the request
            Policy response = disksClient.SetIamPolicy(project, zone, resource, zoneSetPolicyRequestResource);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyAsync()
        {
            // Snippet: SetIamPolicyAsync(string, string, string, ZoneSetPolicyRequest, CallSettings)
            // Additional: SetIamPolicyAsync(string, string, string, ZoneSetPolicyRequest, CancellationToken)
            // Create client
            DisksClient disksClient = await DisksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string resource = "";
            ZoneSetPolicyRequest zoneSetPolicyRequestResource = new ZoneSetPolicyRequest();
            // Make the request
            Policy response = await disksClient.SetIamPolicyAsync(project, zone, resource, zoneSetPolicyRequestResource);
            // End snippet
        }

        /// <summary>Snippet for SetLabels</summary>
        public void SetLabelsRequestObject()
        {
            // Snippet: SetLabels(SetLabelsDiskRequest, CallSettings)
            // Create client
            DisksClient disksClient = DisksClient.Create();
            // Initialize request argument(s)
            SetLabelsDiskRequest request = new SetLabelsDiskRequest
            {
                Zone = "",
                RequestId = "",
                ZoneSetLabelsRequestResource = new ZoneSetLabelsRequest(),
                Resource = "",
                Project = "",
            };
            // Make the request
            Operation response = disksClient.SetLabels(request);
            // End snippet
        }

        /// <summary>Snippet for SetLabelsAsync</summary>
        public async Task SetLabelsRequestObjectAsync()
        {
            // Snippet: SetLabelsAsync(SetLabelsDiskRequest, CallSettings)
            // Additional: SetLabelsAsync(SetLabelsDiskRequest, CancellationToken)
            // Create client
            DisksClient disksClient = await DisksClient.CreateAsync();
            // Initialize request argument(s)
            SetLabelsDiskRequest request = new SetLabelsDiskRequest
            {
                Zone = "",
                RequestId = "",
                ZoneSetLabelsRequestResource = new ZoneSetLabelsRequest(),
                Resource = "",
                Project = "",
            };
            // Make the request
            Operation response = await disksClient.SetLabelsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetLabels</summary>
        public void SetLabels()
        {
            // Snippet: SetLabels(string, string, string, ZoneSetLabelsRequest, CallSettings)
            // Create client
            DisksClient disksClient = DisksClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string resource = "";
            ZoneSetLabelsRequest zoneSetLabelsRequestResource = new ZoneSetLabelsRequest();
            // Make the request
            Operation response = disksClient.SetLabels(project, zone, resource, zoneSetLabelsRequestResource);
            // End snippet
        }

        /// <summary>Snippet for SetLabelsAsync</summary>
        public async Task SetLabelsAsync()
        {
            // Snippet: SetLabelsAsync(string, string, string, ZoneSetLabelsRequest, CallSettings)
            // Additional: SetLabelsAsync(string, string, string, ZoneSetLabelsRequest, CancellationToken)
            // Create client
            DisksClient disksClient = await DisksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string resource = "";
            ZoneSetLabelsRequest zoneSetLabelsRequestResource = new ZoneSetLabelsRequest();
            // Make the request
            Operation response = await disksClient.SetLabelsAsync(project, zone, resource, zoneSetLabelsRequestResource);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissionsRequestObject()
        {
            // Snippet: TestIamPermissions(TestIamPermissionsDiskRequest, CallSettings)
            // Create client
            DisksClient disksClient = DisksClient.Create();
            // Initialize request argument(s)
            TestIamPermissionsDiskRequest request = new TestIamPermissionsDiskRequest
            {
                Zone = "",
                TestPermissionsRequestResource = new TestPermissionsRequest(),
                Resource = "",
                Project = "",
            };
            // Make the request
            TestPermissionsResponse response = disksClient.TestIamPermissions(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsRequestObjectAsync()
        {
            // Snippet: TestIamPermissionsAsync(TestIamPermissionsDiskRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(TestIamPermissionsDiskRequest, CancellationToken)
            // Create client
            DisksClient disksClient = await DisksClient.CreateAsync();
            // Initialize request argument(s)
            TestIamPermissionsDiskRequest request = new TestIamPermissionsDiskRequest
            {
                Zone = "",
                TestPermissionsRequestResource = new TestPermissionsRequest(),
                Resource = "",
                Project = "",
            };
            // Make the request
            TestPermissionsResponse response = await disksClient.TestIamPermissionsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissions()
        {
            // Snippet: TestIamPermissions(string, string, string, TestPermissionsRequest, CallSettings)
            // Create client
            DisksClient disksClient = DisksClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string resource = "";
            TestPermissionsRequest testPermissionsRequestResource = new TestPermissionsRequest();
            // Make the request
            TestPermissionsResponse response = disksClient.TestIamPermissions(project, zone, resource, testPermissionsRequestResource);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsAsync()
        {
            // Snippet: TestIamPermissionsAsync(string, string, string, TestPermissionsRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(string, string, string, TestPermissionsRequest, CancellationToken)
            // Create client
            DisksClient disksClient = await DisksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string resource = "";
            TestPermissionsRequest testPermissionsRequestResource = new TestPermissionsRequest();
            // Make the request
            TestPermissionsResponse response = await disksClient.TestIamPermissionsAsync(project, zone, resource, testPermissionsRequestResource);
            // End snippet
        }
    }
}
