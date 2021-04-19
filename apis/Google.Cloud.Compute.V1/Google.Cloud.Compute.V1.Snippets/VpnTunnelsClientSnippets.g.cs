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
    public sealed class GeneratedVpnTunnelsClientSnippets
    {
        /// <summary>Snippet for AggregatedList</summary>
        public void AggregatedListRequestObject()
        {
            // Snippet: AggregatedList(AggregatedListVpnTunnelsRequest, CallSettings)
            // Create client
            VpnTunnelsClient vpnTunnelsClient = VpnTunnelsClient.Create();
            // Initialize request argument(s)
            AggregatedListVpnTunnelsRequest request = new AggregatedListVpnTunnelsRequest
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
            VpnTunnelAggregatedList response = vpnTunnelsClient.AggregatedList(request);
            // End snippet
        }

        /// <summary>Snippet for AggregatedListAsync</summary>
        public async Task AggregatedListRequestObjectAsync()
        {
            // Snippet: AggregatedListAsync(AggregatedListVpnTunnelsRequest, CallSettings)
            // Additional: AggregatedListAsync(AggregatedListVpnTunnelsRequest, CancellationToken)
            // Create client
            VpnTunnelsClient vpnTunnelsClient = await VpnTunnelsClient.CreateAsync();
            // Initialize request argument(s)
            AggregatedListVpnTunnelsRequest request = new AggregatedListVpnTunnelsRequest
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
            VpnTunnelAggregatedList response = await vpnTunnelsClient.AggregatedListAsync(request);
            // End snippet
        }

        /// <summary>Snippet for AggregatedList</summary>
        public void AggregatedList()
        {
            // Snippet: AggregatedList(string, CallSettings)
            // Create client
            VpnTunnelsClient vpnTunnelsClient = VpnTunnelsClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            VpnTunnelAggregatedList response = vpnTunnelsClient.AggregatedList(project);
            // End snippet
        }

        /// <summary>Snippet for AggregatedListAsync</summary>
        public async Task AggregatedListAsync()
        {
            // Snippet: AggregatedListAsync(string, CallSettings)
            // Additional: AggregatedListAsync(string, CancellationToken)
            // Create client
            VpnTunnelsClient vpnTunnelsClient = await VpnTunnelsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            VpnTunnelAggregatedList response = await vpnTunnelsClient.AggregatedListAsync(project);
            // End snippet
        }

        /// <summary>Snippet for Delete</summary>
        public void DeleteRequestObject()
        {
            // Snippet: Delete(DeleteVpnTunnelRequest, CallSettings)
            // Create client
            VpnTunnelsClient vpnTunnelsClient = VpnTunnelsClient.Create();
            // Initialize request argument(s)
            DeleteVpnTunnelRequest request = new DeleteVpnTunnelRequest
            {
                RequestId = "",
                Region = "",
                VpnTunnel = "",
                Project = "",
            };
            // Make the request
            Operation response = vpnTunnelsClient.Delete(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAsync</summary>
        public async Task DeleteRequestObjectAsync()
        {
            // Snippet: DeleteAsync(DeleteVpnTunnelRequest, CallSettings)
            // Additional: DeleteAsync(DeleteVpnTunnelRequest, CancellationToken)
            // Create client
            VpnTunnelsClient vpnTunnelsClient = await VpnTunnelsClient.CreateAsync();
            // Initialize request argument(s)
            DeleteVpnTunnelRequest request = new DeleteVpnTunnelRequest
            {
                RequestId = "",
                Region = "",
                VpnTunnel = "",
                Project = "",
            };
            // Make the request
            Operation response = await vpnTunnelsClient.DeleteAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Delete</summary>
        public void Delete()
        {
            // Snippet: Delete(string, string, string, CallSettings)
            // Create client
            VpnTunnelsClient vpnTunnelsClient = VpnTunnelsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string vpnTunnel = "";
            // Make the request
            Operation response = vpnTunnelsClient.Delete(project, region, vpnTunnel);
            // End snippet
        }

        /// <summary>Snippet for DeleteAsync</summary>
        public async Task DeleteAsync()
        {
            // Snippet: DeleteAsync(string, string, string, CallSettings)
            // Additional: DeleteAsync(string, string, string, CancellationToken)
            // Create client
            VpnTunnelsClient vpnTunnelsClient = await VpnTunnelsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string vpnTunnel = "";
            // Make the request
            Operation response = await vpnTunnelsClient.DeleteAsync(project, region, vpnTunnel);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void GetRequestObject()
        {
            // Snippet: Get(GetVpnTunnelRequest, CallSettings)
            // Create client
            VpnTunnelsClient vpnTunnelsClient = VpnTunnelsClient.Create();
            // Initialize request argument(s)
            GetVpnTunnelRequest request = new GetVpnTunnelRequest
            {
                Region = "",
                VpnTunnel = "",
                Project = "",
            };
            // Make the request
            VpnTunnel response = vpnTunnelsClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetVpnTunnelRequest, CallSettings)
            // Additional: GetAsync(GetVpnTunnelRequest, CancellationToken)
            // Create client
            VpnTunnelsClient vpnTunnelsClient = await VpnTunnelsClient.CreateAsync();
            // Initialize request argument(s)
            GetVpnTunnelRequest request = new GetVpnTunnelRequest
            {
                Region = "",
                VpnTunnel = "",
                Project = "",
            };
            // Make the request
            VpnTunnel response = await vpnTunnelsClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, string, CallSettings)
            // Create client
            VpnTunnelsClient vpnTunnelsClient = VpnTunnelsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string vpnTunnel = "";
            // Make the request
            VpnTunnel response = vpnTunnelsClient.Get(project, region, vpnTunnel);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, string, CallSettings)
            // Additional: GetAsync(string, string, string, CancellationToken)
            // Create client
            VpnTunnelsClient vpnTunnelsClient = await VpnTunnelsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string vpnTunnel = "";
            // Make the request
            VpnTunnel response = await vpnTunnelsClient.GetAsync(project, region, vpnTunnel);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void InsertRequestObject()
        {
            // Snippet: Insert(InsertVpnTunnelRequest, CallSettings)
            // Create client
            VpnTunnelsClient vpnTunnelsClient = VpnTunnelsClient.Create();
            // Initialize request argument(s)
            InsertVpnTunnelRequest request = new InsertVpnTunnelRequest
            {
                RequestId = "",
                VpnTunnelResource = new VpnTunnel(),
                Region = "",
                Project = "",
            };
            // Make the request
            Operation response = vpnTunnelsClient.Insert(request);
            // End snippet
        }

        /// <summary>Snippet for InsertAsync</summary>
        public async Task InsertRequestObjectAsync()
        {
            // Snippet: InsertAsync(InsertVpnTunnelRequest, CallSettings)
            // Additional: InsertAsync(InsertVpnTunnelRequest, CancellationToken)
            // Create client
            VpnTunnelsClient vpnTunnelsClient = await VpnTunnelsClient.CreateAsync();
            // Initialize request argument(s)
            InsertVpnTunnelRequest request = new InsertVpnTunnelRequest
            {
                RequestId = "",
                VpnTunnelResource = new VpnTunnel(),
                Region = "",
                Project = "",
            };
            // Make the request
            Operation response = await vpnTunnelsClient.InsertAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void Insert()
        {
            // Snippet: Insert(string, string, VpnTunnel, CallSettings)
            // Create client
            VpnTunnelsClient vpnTunnelsClient = VpnTunnelsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            VpnTunnel vpnTunnelResource = new VpnTunnel();
            // Make the request
            Operation response = vpnTunnelsClient.Insert(project, region, vpnTunnelResource);
            // End snippet
        }

        /// <summary>Snippet for InsertAsync</summary>
        public async Task InsertAsync()
        {
            // Snippet: InsertAsync(string, string, VpnTunnel, CallSettings)
            // Additional: InsertAsync(string, string, VpnTunnel, CancellationToken)
            // Create client
            VpnTunnelsClient vpnTunnelsClient = await VpnTunnelsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            VpnTunnel vpnTunnelResource = new VpnTunnel();
            // Make the request
            Operation response = await vpnTunnelsClient.InsertAsync(project, region, vpnTunnelResource);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void ListRequestObject()
        {
            // Snippet: List(ListVpnTunnelsRequest, CallSettings)
            // Create client
            VpnTunnelsClient vpnTunnelsClient = VpnTunnelsClient.Create();
            // Initialize request argument(s)
            ListVpnTunnelsRequest request = new ListVpnTunnelsRequest
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
            VpnTunnelList response = vpnTunnelsClient.List(request);
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListRequestObjectAsync()
        {
            // Snippet: ListAsync(ListVpnTunnelsRequest, CallSettings)
            // Additional: ListAsync(ListVpnTunnelsRequest, CancellationToken)
            // Create client
            VpnTunnelsClient vpnTunnelsClient = await VpnTunnelsClient.CreateAsync();
            // Initialize request argument(s)
            ListVpnTunnelsRequest request = new ListVpnTunnelsRequest
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
            VpnTunnelList response = await vpnTunnelsClient.ListAsync(request);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void List()
        {
            // Snippet: List(string, string, CallSettings)
            // Create client
            VpnTunnelsClient vpnTunnelsClient = VpnTunnelsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            VpnTunnelList response = vpnTunnelsClient.List(project, region);
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListAsync()
        {
            // Snippet: ListAsync(string, string, CallSettings)
            // Additional: ListAsync(string, string, CancellationToken)
            // Create client
            VpnTunnelsClient vpnTunnelsClient = await VpnTunnelsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            VpnTunnelList response = await vpnTunnelsClient.ListAsync(project, region);
            // End snippet
        }
    }
}
