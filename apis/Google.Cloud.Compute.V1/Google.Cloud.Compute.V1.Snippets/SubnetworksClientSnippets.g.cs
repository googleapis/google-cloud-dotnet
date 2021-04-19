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
    public sealed class GeneratedSubnetworksClientSnippets
    {
        /// <summary>Snippet for AggregatedList</summary>
        public void AggregatedListRequestObject()
        {
            // Snippet: AggregatedList(AggregatedListSubnetworksRequest, CallSettings)
            // Create client
            SubnetworksClient subnetworksClient = SubnetworksClient.Create();
            // Initialize request argument(s)
            AggregatedListSubnetworksRequest request = new AggregatedListSubnetworksRequest
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
            SubnetworkAggregatedList response = subnetworksClient.AggregatedList(request);
            // End snippet
        }

        /// <summary>Snippet for AggregatedListAsync</summary>
        public async Task AggregatedListRequestObjectAsync()
        {
            // Snippet: AggregatedListAsync(AggregatedListSubnetworksRequest, CallSettings)
            // Additional: AggregatedListAsync(AggregatedListSubnetworksRequest, CancellationToken)
            // Create client
            SubnetworksClient subnetworksClient = await SubnetworksClient.CreateAsync();
            // Initialize request argument(s)
            AggregatedListSubnetworksRequest request = new AggregatedListSubnetworksRequest
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
            SubnetworkAggregatedList response = await subnetworksClient.AggregatedListAsync(request);
            // End snippet
        }

        /// <summary>Snippet for AggregatedList</summary>
        public void AggregatedList()
        {
            // Snippet: AggregatedList(string, CallSettings)
            // Create client
            SubnetworksClient subnetworksClient = SubnetworksClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            SubnetworkAggregatedList response = subnetworksClient.AggregatedList(project);
            // End snippet
        }

        /// <summary>Snippet for AggregatedListAsync</summary>
        public async Task AggregatedListAsync()
        {
            // Snippet: AggregatedListAsync(string, CallSettings)
            // Additional: AggregatedListAsync(string, CancellationToken)
            // Create client
            SubnetworksClient subnetworksClient = await SubnetworksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            SubnetworkAggregatedList response = await subnetworksClient.AggregatedListAsync(project);
            // End snippet
        }

        /// <summary>Snippet for Delete</summary>
        public void DeleteRequestObject()
        {
            // Snippet: Delete(DeleteSubnetworkRequest, CallSettings)
            // Create client
            SubnetworksClient subnetworksClient = SubnetworksClient.Create();
            // Initialize request argument(s)
            DeleteSubnetworkRequest request = new DeleteSubnetworkRequest
            {
                RequestId = "",
                Subnetwork = "",
                Region = "",
                Project = "",
            };
            // Make the request
            Operation response = subnetworksClient.Delete(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAsync</summary>
        public async Task DeleteRequestObjectAsync()
        {
            // Snippet: DeleteAsync(DeleteSubnetworkRequest, CallSettings)
            // Additional: DeleteAsync(DeleteSubnetworkRequest, CancellationToken)
            // Create client
            SubnetworksClient subnetworksClient = await SubnetworksClient.CreateAsync();
            // Initialize request argument(s)
            DeleteSubnetworkRequest request = new DeleteSubnetworkRequest
            {
                RequestId = "",
                Subnetwork = "",
                Region = "",
                Project = "",
            };
            // Make the request
            Operation response = await subnetworksClient.DeleteAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Delete</summary>
        public void Delete()
        {
            // Snippet: Delete(string, string, string, CallSettings)
            // Create client
            SubnetworksClient subnetworksClient = SubnetworksClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string subnetwork = "";
            // Make the request
            Operation response = subnetworksClient.Delete(project, region, subnetwork);
            // End snippet
        }

        /// <summary>Snippet for DeleteAsync</summary>
        public async Task DeleteAsync()
        {
            // Snippet: DeleteAsync(string, string, string, CallSettings)
            // Additional: DeleteAsync(string, string, string, CancellationToken)
            // Create client
            SubnetworksClient subnetworksClient = await SubnetworksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string subnetwork = "";
            // Make the request
            Operation response = await subnetworksClient.DeleteAsync(project, region, subnetwork);
            // End snippet
        }

        /// <summary>Snippet for ExpandIpCidrRange</summary>
        public void ExpandIpCidrRangeRequestObject()
        {
            // Snippet: ExpandIpCidrRange(ExpandIpCidrRangeSubnetworkRequest, CallSettings)
            // Create client
            SubnetworksClient subnetworksClient = SubnetworksClient.Create();
            // Initialize request argument(s)
            ExpandIpCidrRangeSubnetworkRequest request = new ExpandIpCidrRangeSubnetworkRequest
            {
                RequestId = "",
                Subnetwork = "",
                Region = "",
                SubnetworksExpandIpCidrRangeRequestResource = new SubnetworksExpandIpCidrRangeRequest(),
                Project = "",
            };
            // Make the request
            Operation response = subnetworksClient.ExpandIpCidrRange(request);
            // End snippet
        }

        /// <summary>Snippet for ExpandIpCidrRangeAsync</summary>
        public async Task ExpandIpCidrRangeRequestObjectAsync()
        {
            // Snippet: ExpandIpCidrRangeAsync(ExpandIpCidrRangeSubnetworkRequest, CallSettings)
            // Additional: ExpandIpCidrRangeAsync(ExpandIpCidrRangeSubnetworkRequest, CancellationToken)
            // Create client
            SubnetworksClient subnetworksClient = await SubnetworksClient.CreateAsync();
            // Initialize request argument(s)
            ExpandIpCidrRangeSubnetworkRequest request = new ExpandIpCidrRangeSubnetworkRequest
            {
                RequestId = "",
                Subnetwork = "",
                Region = "",
                SubnetworksExpandIpCidrRangeRequestResource = new SubnetworksExpandIpCidrRangeRequest(),
                Project = "",
            };
            // Make the request
            Operation response = await subnetworksClient.ExpandIpCidrRangeAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ExpandIpCidrRange</summary>
        public void ExpandIpCidrRange()
        {
            // Snippet: ExpandIpCidrRange(string, string, string, SubnetworksExpandIpCidrRangeRequest, CallSettings)
            // Create client
            SubnetworksClient subnetworksClient = SubnetworksClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string subnetwork = "";
            SubnetworksExpandIpCidrRangeRequest subnetworksExpandIpCidrRangeRequestResource = new SubnetworksExpandIpCidrRangeRequest();
            // Make the request
            Operation response = subnetworksClient.ExpandIpCidrRange(project, region, subnetwork, subnetworksExpandIpCidrRangeRequestResource);
            // End snippet
        }

        /// <summary>Snippet for ExpandIpCidrRangeAsync</summary>
        public async Task ExpandIpCidrRangeAsync()
        {
            // Snippet: ExpandIpCidrRangeAsync(string, string, string, SubnetworksExpandIpCidrRangeRequest, CallSettings)
            // Additional: ExpandIpCidrRangeAsync(string, string, string, SubnetworksExpandIpCidrRangeRequest, CancellationToken)
            // Create client
            SubnetworksClient subnetworksClient = await SubnetworksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string subnetwork = "";
            SubnetworksExpandIpCidrRangeRequest subnetworksExpandIpCidrRangeRequestResource = new SubnetworksExpandIpCidrRangeRequest();
            // Make the request
            Operation response = await subnetworksClient.ExpandIpCidrRangeAsync(project, region, subnetwork, subnetworksExpandIpCidrRangeRequestResource);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void GetRequestObject()
        {
            // Snippet: Get(GetSubnetworkRequest, CallSettings)
            // Create client
            SubnetworksClient subnetworksClient = SubnetworksClient.Create();
            // Initialize request argument(s)
            GetSubnetworkRequest request = new GetSubnetworkRequest
            {
                Subnetwork = "",
                Region = "",
                Project = "",
            };
            // Make the request
            Subnetwork response = subnetworksClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetSubnetworkRequest, CallSettings)
            // Additional: GetAsync(GetSubnetworkRequest, CancellationToken)
            // Create client
            SubnetworksClient subnetworksClient = await SubnetworksClient.CreateAsync();
            // Initialize request argument(s)
            GetSubnetworkRequest request = new GetSubnetworkRequest
            {
                Subnetwork = "",
                Region = "",
                Project = "",
            };
            // Make the request
            Subnetwork response = await subnetworksClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, string, CallSettings)
            // Create client
            SubnetworksClient subnetworksClient = SubnetworksClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string subnetwork = "";
            // Make the request
            Subnetwork response = subnetworksClient.Get(project, region, subnetwork);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, string, CallSettings)
            // Additional: GetAsync(string, string, string, CancellationToken)
            // Create client
            SubnetworksClient subnetworksClient = await SubnetworksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string subnetwork = "";
            // Make the request
            Subnetwork response = await subnetworksClient.GetAsync(project, region, subnetwork);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicyRequestObject()
        {
            // Snippet: GetIamPolicy(GetIamPolicySubnetworkRequest, CallSettings)
            // Create client
            SubnetworksClient subnetworksClient = SubnetworksClient.Create();
            // Initialize request argument(s)
            GetIamPolicySubnetworkRequest request = new GetIamPolicySubnetworkRequest
            {
                Region = "",
                Resource = "",
                Project = "",
                OptionsRequestedPolicyVersion = 0,
            };
            // Make the request
            Policy response = subnetworksClient.GetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyRequestObjectAsync()
        {
            // Snippet: GetIamPolicyAsync(GetIamPolicySubnetworkRequest, CallSettings)
            // Additional: GetIamPolicyAsync(GetIamPolicySubnetworkRequest, CancellationToken)
            // Create client
            SubnetworksClient subnetworksClient = await SubnetworksClient.CreateAsync();
            // Initialize request argument(s)
            GetIamPolicySubnetworkRequest request = new GetIamPolicySubnetworkRequest
            {
                Region = "",
                Resource = "",
                Project = "",
                OptionsRequestedPolicyVersion = 0,
            };
            // Make the request
            Policy response = await subnetworksClient.GetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicy()
        {
            // Snippet: GetIamPolicy(string, string, string, CallSettings)
            // Create client
            SubnetworksClient subnetworksClient = SubnetworksClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string resource = "";
            // Make the request
            Policy response = subnetworksClient.GetIamPolicy(project, region, resource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyAsync()
        {
            // Snippet: GetIamPolicyAsync(string, string, string, CallSettings)
            // Additional: GetIamPolicyAsync(string, string, string, CancellationToken)
            // Create client
            SubnetworksClient subnetworksClient = await SubnetworksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string resource = "";
            // Make the request
            Policy response = await subnetworksClient.GetIamPolicyAsync(project, region, resource);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void InsertRequestObject()
        {
            // Snippet: Insert(InsertSubnetworkRequest, CallSettings)
            // Create client
            SubnetworksClient subnetworksClient = SubnetworksClient.Create();
            // Initialize request argument(s)
            InsertSubnetworkRequest request = new InsertSubnetworkRequest
            {
                RequestId = "",
                SubnetworkResource = new Subnetwork(),
                Region = "",
                Project = "",
            };
            // Make the request
            Operation response = subnetworksClient.Insert(request);
            // End snippet
        }

        /// <summary>Snippet for InsertAsync</summary>
        public async Task InsertRequestObjectAsync()
        {
            // Snippet: InsertAsync(InsertSubnetworkRequest, CallSettings)
            // Additional: InsertAsync(InsertSubnetworkRequest, CancellationToken)
            // Create client
            SubnetworksClient subnetworksClient = await SubnetworksClient.CreateAsync();
            // Initialize request argument(s)
            InsertSubnetworkRequest request = new InsertSubnetworkRequest
            {
                RequestId = "",
                SubnetworkResource = new Subnetwork(),
                Region = "",
                Project = "",
            };
            // Make the request
            Operation response = await subnetworksClient.InsertAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void Insert()
        {
            // Snippet: Insert(string, string, Subnetwork, CallSettings)
            // Create client
            SubnetworksClient subnetworksClient = SubnetworksClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            Subnetwork subnetworkResource = new Subnetwork();
            // Make the request
            Operation response = subnetworksClient.Insert(project, region, subnetworkResource);
            // End snippet
        }

        /// <summary>Snippet for InsertAsync</summary>
        public async Task InsertAsync()
        {
            // Snippet: InsertAsync(string, string, Subnetwork, CallSettings)
            // Additional: InsertAsync(string, string, Subnetwork, CancellationToken)
            // Create client
            SubnetworksClient subnetworksClient = await SubnetworksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            Subnetwork subnetworkResource = new Subnetwork();
            // Make the request
            Operation response = await subnetworksClient.InsertAsync(project, region, subnetworkResource);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void ListRequestObject()
        {
            // Snippet: List(ListSubnetworksRequest, CallSettings)
            // Create client
            SubnetworksClient subnetworksClient = SubnetworksClient.Create();
            // Initialize request argument(s)
            ListSubnetworksRequest request = new ListSubnetworksRequest
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
            SubnetworkList response = subnetworksClient.List(request);
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListRequestObjectAsync()
        {
            // Snippet: ListAsync(ListSubnetworksRequest, CallSettings)
            // Additional: ListAsync(ListSubnetworksRequest, CancellationToken)
            // Create client
            SubnetworksClient subnetworksClient = await SubnetworksClient.CreateAsync();
            // Initialize request argument(s)
            ListSubnetworksRequest request = new ListSubnetworksRequest
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
            SubnetworkList response = await subnetworksClient.ListAsync(request);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void List()
        {
            // Snippet: List(string, string, CallSettings)
            // Create client
            SubnetworksClient subnetworksClient = SubnetworksClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            SubnetworkList response = subnetworksClient.List(project, region);
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListAsync()
        {
            // Snippet: ListAsync(string, string, CallSettings)
            // Additional: ListAsync(string, string, CancellationToken)
            // Create client
            SubnetworksClient subnetworksClient = await SubnetworksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            SubnetworkList response = await subnetworksClient.ListAsync(project, region);
            // End snippet
        }

        /// <summary>Snippet for ListUsable</summary>
        public void ListUsableRequestObject()
        {
            // Snippet: ListUsable(ListUsableSubnetworksRequest, CallSettings)
            // Create client
            SubnetworksClient subnetworksClient = SubnetworksClient.Create();
            // Initialize request argument(s)
            ListUsableSubnetworksRequest request = new ListUsableSubnetworksRequest
            {
                PageToken = "",
                MaxResults = 0U,
                Filter = "",
                OrderBy = "",
                Project = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            UsableSubnetworksAggregatedList response = subnetworksClient.ListUsable(request);
            // End snippet
        }

        /// <summary>Snippet for ListUsableAsync</summary>
        public async Task ListUsableRequestObjectAsync()
        {
            // Snippet: ListUsableAsync(ListUsableSubnetworksRequest, CallSettings)
            // Additional: ListUsableAsync(ListUsableSubnetworksRequest, CancellationToken)
            // Create client
            SubnetworksClient subnetworksClient = await SubnetworksClient.CreateAsync();
            // Initialize request argument(s)
            ListUsableSubnetworksRequest request = new ListUsableSubnetworksRequest
            {
                PageToken = "",
                MaxResults = 0U,
                Filter = "",
                OrderBy = "",
                Project = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            UsableSubnetworksAggregatedList response = await subnetworksClient.ListUsableAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ListUsable</summary>
        public void ListUsable()
        {
            // Snippet: ListUsable(string, CallSettings)
            // Create client
            SubnetworksClient subnetworksClient = SubnetworksClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            UsableSubnetworksAggregatedList response = subnetworksClient.ListUsable(project);
            // End snippet
        }

        /// <summary>Snippet for ListUsableAsync</summary>
        public async Task ListUsableAsync()
        {
            // Snippet: ListUsableAsync(string, CallSettings)
            // Additional: ListUsableAsync(string, CancellationToken)
            // Create client
            SubnetworksClient subnetworksClient = await SubnetworksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            UsableSubnetworksAggregatedList response = await subnetworksClient.ListUsableAsync(project);
            // End snippet
        }

        /// <summary>Snippet for Patch</summary>
        public void PatchRequestObject()
        {
            // Snippet: Patch(PatchSubnetworkRequest, CallSettings)
            // Create client
            SubnetworksClient subnetworksClient = SubnetworksClient.Create();
            // Initialize request argument(s)
            PatchSubnetworkRequest request = new PatchSubnetworkRequest
            {
                RequestId = "",
                Subnetwork = "",
                SubnetworkResource = new Subnetwork(),
                DrainTimeoutSeconds = 0,
                Region = "",
                Project = "",
            };
            // Make the request
            Operation response = subnetworksClient.Patch(request);
            // End snippet
        }

        /// <summary>Snippet for PatchAsync</summary>
        public async Task PatchRequestObjectAsync()
        {
            // Snippet: PatchAsync(PatchSubnetworkRequest, CallSettings)
            // Additional: PatchAsync(PatchSubnetworkRequest, CancellationToken)
            // Create client
            SubnetworksClient subnetworksClient = await SubnetworksClient.CreateAsync();
            // Initialize request argument(s)
            PatchSubnetworkRequest request = new PatchSubnetworkRequest
            {
                RequestId = "",
                Subnetwork = "",
                SubnetworkResource = new Subnetwork(),
                DrainTimeoutSeconds = 0,
                Region = "",
                Project = "",
            };
            // Make the request
            Operation response = await subnetworksClient.PatchAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Patch</summary>
        public void Patch()
        {
            // Snippet: Patch(string, string, string, Subnetwork, CallSettings)
            // Create client
            SubnetworksClient subnetworksClient = SubnetworksClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string subnetwork = "";
            Subnetwork subnetworkResource = new Subnetwork();
            // Make the request
            Operation response = subnetworksClient.Patch(project, region, subnetwork, subnetworkResource);
            // End snippet
        }

        /// <summary>Snippet for PatchAsync</summary>
        public async Task PatchAsync()
        {
            // Snippet: PatchAsync(string, string, string, Subnetwork, CallSettings)
            // Additional: PatchAsync(string, string, string, Subnetwork, CancellationToken)
            // Create client
            SubnetworksClient subnetworksClient = await SubnetworksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string subnetwork = "";
            Subnetwork subnetworkResource = new Subnetwork();
            // Make the request
            Operation response = await subnetworksClient.PatchAsync(project, region, subnetwork, subnetworkResource);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicyRequestObject()
        {
            // Snippet: SetIamPolicy(SetIamPolicySubnetworkRequest, CallSettings)
            // Create client
            SubnetworksClient subnetworksClient = SubnetworksClient.Create();
            // Initialize request argument(s)
            SetIamPolicySubnetworkRequest request = new SetIamPolicySubnetworkRequest
            {
                RegionSetPolicyRequestResource = new RegionSetPolicyRequest(),
                Region = "",
                Resource = "",
                Project = "",
            };
            // Make the request
            Policy response = subnetworksClient.SetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyRequestObjectAsync()
        {
            // Snippet: SetIamPolicyAsync(SetIamPolicySubnetworkRequest, CallSettings)
            // Additional: SetIamPolicyAsync(SetIamPolicySubnetworkRequest, CancellationToken)
            // Create client
            SubnetworksClient subnetworksClient = await SubnetworksClient.CreateAsync();
            // Initialize request argument(s)
            SetIamPolicySubnetworkRequest request = new SetIamPolicySubnetworkRequest
            {
                RegionSetPolicyRequestResource = new RegionSetPolicyRequest(),
                Region = "",
                Resource = "",
                Project = "",
            };
            // Make the request
            Policy response = await subnetworksClient.SetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicy()
        {
            // Snippet: SetIamPolicy(string, string, string, RegionSetPolicyRequest, CallSettings)
            // Create client
            SubnetworksClient subnetworksClient = SubnetworksClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string resource = "";
            RegionSetPolicyRequest regionSetPolicyRequestResource = new RegionSetPolicyRequest();
            // Make the request
            Policy response = subnetworksClient.SetIamPolicy(project, region, resource, regionSetPolicyRequestResource);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyAsync()
        {
            // Snippet: SetIamPolicyAsync(string, string, string, RegionSetPolicyRequest, CallSettings)
            // Additional: SetIamPolicyAsync(string, string, string, RegionSetPolicyRequest, CancellationToken)
            // Create client
            SubnetworksClient subnetworksClient = await SubnetworksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string resource = "";
            RegionSetPolicyRequest regionSetPolicyRequestResource = new RegionSetPolicyRequest();
            // Make the request
            Policy response = await subnetworksClient.SetIamPolicyAsync(project, region, resource, regionSetPolicyRequestResource);
            // End snippet
        }

        /// <summary>Snippet for SetPrivateIpGoogleAccess</summary>
        public void SetPrivateIpGoogleAccessRequestObject()
        {
            // Snippet: SetPrivateIpGoogleAccess(SetPrivateIpGoogleAccessSubnetworkRequest, CallSettings)
            // Create client
            SubnetworksClient subnetworksClient = SubnetworksClient.Create();
            // Initialize request argument(s)
            SetPrivateIpGoogleAccessSubnetworkRequest request = new SetPrivateIpGoogleAccessSubnetworkRequest
            {
                SubnetworksSetPrivateIpGoogleAccessRequestResource = new SubnetworksSetPrivateIpGoogleAccessRequest(),
                RequestId = "",
                Subnetwork = "",
                Region = "",
                Project = "",
            };
            // Make the request
            Operation response = subnetworksClient.SetPrivateIpGoogleAccess(request);
            // End snippet
        }

        /// <summary>Snippet for SetPrivateIpGoogleAccessAsync</summary>
        public async Task SetPrivateIpGoogleAccessRequestObjectAsync()
        {
            // Snippet: SetPrivateIpGoogleAccessAsync(SetPrivateIpGoogleAccessSubnetworkRequest, CallSettings)
            // Additional: SetPrivateIpGoogleAccessAsync(SetPrivateIpGoogleAccessSubnetworkRequest, CancellationToken)
            // Create client
            SubnetworksClient subnetworksClient = await SubnetworksClient.CreateAsync();
            // Initialize request argument(s)
            SetPrivateIpGoogleAccessSubnetworkRequest request = new SetPrivateIpGoogleAccessSubnetworkRequest
            {
                SubnetworksSetPrivateIpGoogleAccessRequestResource = new SubnetworksSetPrivateIpGoogleAccessRequest(),
                RequestId = "",
                Subnetwork = "",
                Region = "",
                Project = "",
            };
            // Make the request
            Operation response = await subnetworksClient.SetPrivateIpGoogleAccessAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetPrivateIpGoogleAccess</summary>
        public void SetPrivateIpGoogleAccess()
        {
            // Snippet: SetPrivateIpGoogleAccess(string, string, string, SubnetworksSetPrivateIpGoogleAccessRequest, CallSettings)
            // Create client
            SubnetworksClient subnetworksClient = SubnetworksClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string subnetwork = "";
            SubnetworksSetPrivateIpGoogleAccessRequest subnetworksSetPrivateIpGoogleAccessRequestResource = new SubnetworksSetPrivateIpGoogleAccessRequest();
            // Make the request
            Operation response = subnetworksClient.SetPrivateIpGoogleAccess(project, region, subnetwork, subnetworksSetPrivateIpGoogleAccessRequestResource);
            // End snippet
        }

        /// <summary>Snippet for SetPrivateIpGoogleAccessAsync</summary>
        public async Task SetPrivateIpGoogleAccessAsync()
        {
            // Snippet: SetPrivateIpGoogleAccessAsync(string, string, string, SubnetworksSetPrivateIpGoogleAccessRequest, CallSettings)
            // Additional: SetPrivateIpGoogleAccessAsync(string, string, string, SubnetworksSetPrivateIpGoogleAccessRequest, CancellationToken)
            // Create client
            SubnetworksClient subnetworksClient = await SubnetworksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string subnetwork = "";
            SubnetworksSetPrivateIpGoogleAccessRequest subnetworksSetPrivateIpGoogleAccessRequestResource = new SubnetworksSetPrivateIpGoogleAccessRequest();
            // Make the request
            Operation response = await subnetworksClient.SetPrivateIpGoogleAccessAsync(project, region, subnetwork, subnetworksSetPrivateIpGoogleAccessRequestResource);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissionsRequestObject()
        {
            // Snippet: TestIamPermissions(TestIamPermissionsSubnetworkRequest, CallSettings)
            // Create client
            SubnetworksClient subnetworksClient = SubnetworksClient.Create();
            // Initialize request argument(s)
            TestIamPermissionsSubnetworkRequest request = new TestIamPermissionsSubnetworkRequest
            {
                Region = "",
                TestPermissionsRequestResource = new TestPermissionsRequest(),
                Resource = "",
                Project = "",
            };
            // Make the request
            TestPermissionsResponse response = subnetworksClient.TestIamPermissions(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsRequestObjectAsync()
        {
            // Snippet: TestIamPermissionsAsync(TestIamPermissionsSubnetworkRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(TestIamPermissionsSubnetworkRequest, CancellationToken)
            // Create client
            SubnetworksClient subnetworksClient = await SubnetworksClient.CreateAsync();
            // Initialize request argument(s)
            TestIamPermissionsSubnetworkRequest request = new TestIamPermissionsSubnetworkRequest
            {
                Region = "",
                TestPermissionsRequestResource = new TestPermissionsRequest(),
                Resource = "",
                Project = "",
            };
            // Make the request
            TestPermissionsResponse response = await subnetworksClient.TestIamPermissionsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissions()
        {
            // Snippet: TestIamPermissions(string, string, string, TestPermissionsRequest, CallSettings)
            // Create client
            SubnetworksClient subnetworksClient = SubnetworksClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string resource = "";
            TestPermissionsRequest testPermissionsRequestResource = new TestPermissionsRequest();
            // Make the request
            TestPermissionsResponse response = subnetworksClient.TestIamPermissions(project, region, resource, testPermissionsRequestResource);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsAsync()
        {
            // Snippet: TestIamPermissionsAsync(string, string, string, TestPermissionsRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(string, string, string, TestPermissionsRequest, CancellationToken)
            // Create client
            SubnetworksClient subnetworksClient = await SubnetworksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string resource = "";
            TestPermissionsRequest testPermissionsRequestResource = new TestPermissionsRequest();
            // Make the request
            TestPermissionsResponse response = await subnetworksClient.TestIamPermissionsAsync(project, region, resource, testPermissionsRequestResource);
            // End snippet
        }
    }
}
