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
    public sealed class GeneratedNetworksClientSnippets
    {
        /// <summary>Snippet for AddPeering</summary>
        public void AddPeeringRequestObject()
        {
            // Snippet: AddPeering(AddPeeringNetworkRequest, CallSettings)
            // Create client
            NetworksClient networksClient = NetworksClient.Create();
            // Initialize request argument(s)
            AddPeeringNetworkRequest request = new AddPeeringNetworkRequest
            {
                RequestId = "",
                Project = "",
                Network = "",
                NetworksAddPeeringRequestResource = new NetworksAddPeeringRequest(),
            };
            // Make the request
            Operation response = networksClient.AddPeering(request);
            // End snippet
        }

        /// <summary>Snippet for AddPeeringAsync</summary>
        public async Task AddPeeringRequestObjectAsync()
        {
            // Snippet: AddPeeringAsync(AddPeeringNetworkRequest, CallSettings)
            // Additional: AddPeeringAsync(AddPeeringNetworkRequest, CancellationToken)
            // Create client
            NetworksClient networksClient = await NetworksClient.CreateAsync();
            // Initialize request argument(s)
            AddPeeringNetworkRequest request = new AddPeeringNetworkRequest
            {
                RequestId = "",
                Project = "",
                Network = "",
                NetworksAddPeeringRequestResource = new NetworksAddPeeringRequest(),
            };
            // Make the request
            Operation response = await networksClient.AddPeeringAsync(request);
            // End snippet
        }

        /// <summary>Snippet for AddPeering</summary>
        public void AddPeering()
        {
            // Snippet: AddPeering(string, string, NetworksAddPeeringRequest, CallSettings)
            // Create client
            NetworksClient networksClient = NetworksClient.Create();
            // Initialize request argument(s)
            string project = "";
            string network = "";
            NetworksAddPeeringRequest networksAddPeeringRequestResource = new NetworksAddPeeringRequest();
            // Make the request
            Operation response = networksClient.AddPeering(project, network, networksAddPeeringRequestResource);
            // End snippet
        }

        /// <summary>Snippet for AddPeeringAsync</summary>
        public async Task AddPeeringAsync()
        {
            // Snippet: AddPeeringAsync(string, string, NetworksAddPeeringRequest, CallSettings)
            // Additional: AddPeeringAsync(string, string, NetworksAddPeeringRequest, CancellationToken)
            // Create client
            NetworksClient networksClient = await NetworksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string network = "";
            NetworksAddPeeringRequest networksAddPeeringRequestResource = new NetworksAddPeeringRequest();
            // Make the request
            Operation response = await networksClient.AddPeeringAsync(project, network, networksAddPeeringRequestResource);
            // End snippet
        }

        /// <summary>Snippet for Delete</summary>
        public void DeleteRequestObject()
        {
            // Snippet: Delete(DeleteNetworkRequest, CallSettings)
            // Create client
            NetworksClient networksClient = NetworksClient.Create();
            // Initialize request argument(s)
            DeleteNetworkRequest request = new DeleteNetworkRequest
            {
                RequestId = "",
                Project = "",
                Network = "",
            };
            // Make the request
            Operation response = networksClient.Delete(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAsync</summary>
        public async Task DeleteRequestObjectAsync()
        {
            // Snippet: DeleteAsync(DeleteNetworkRequest, CallSettings)
            // Additional: DeleteAsync(DeleteNetworkRequest, CancellationToken)
            // Create client
            NetworksClient networksClient = await NetworksClient.CreateAsync();
            // Initialize request argument(s)
            DeleteNetworkRequest request = new DeleteNetworkRequest
            {
                RequestId = "",
                Project = "",
                Network = "",
            };
            // Make the request
            Operation response = await networksClient.DeleteAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Delete</summary>
        public void Delete()
        {
            // Snippet: Delete(string, string, CallSettings)
            // Create client
            NetworksClient networksClient = NetworksClient.Create();
            // Initialize request argument(s)
            string project = "";
            string network = "";
            // Make the request
            Operation response = networksClient.Delete(project, network);
            // End snippet
        }

        /// <summary>Snippet for DeleteAsync</summary>
        public async Task DeleteAsync()
        {
            // Snippet: DeleteAsync(string, string, CallSettings)
            // Additional: DeleteAsync(string, string, CancellationToken)
            // Create client
            NetworksClient networksClient = await NetworksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string network = "";
            // Make the request
            Operation response = await networksClient.DeleteAsync(project, network);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void GetRequestObject()
        {
            // Snippet: Get(GetNetworkRequest, CallSettings)
            // Create client
            NetworksClient networksClient = NetworksClient.Create();
            // Initialize request argument(s)
            GetNetworkRequest request = new GetNetworkRequest
            {
                Project = "",
                Network = "",
            };
            // Make the request
            Network response = networksClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetNetworkRequest, CallSettings)
            // Additional: GetAsync(GetNetworkRequest, CancellationToken)
            // Create client
            NetworksClient networksClient = await NetworksClient.CreateAsync();
            // Initialize request argument(s)
            GetNetworkRequest request = new GetNetworkRequest
            {
                Project = "",
                Network = "",
            };
            // Make the request
            Network response = await networksClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, CallSettings)
            // Create client
            NetworksClient networksClient = NetworksClient.Create();
            // Initialize request argument(s)
            string project = "";
            string network = "";
            // Make the request
            Network response = networksClient.Get(project, network);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, CallSettings)
            // Additional: GetAsync(string, string, CancellationToken)
            // Create client
            NetworksClient networksClient = await NetworksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string network = "";
            // Make the request
            Network response = await networksClient.GetAsync(project, network);
            // End snippet
        }

        /// <summary>Snippet for GetEffectiveFirewalls</summary>
        public void GetEffectiveFirewallsRequestObject()
        {
            // Snippet: GetEffectiveFirewalls(GetEffectiveFirewallsNetworkRequest, CallSettings)
            // Create client
            NetworksClient networksClient = NetworksClient.Create();
            // Initialize request argument(s)
            GetEffectiveFirewallsNetworkRequest request = new GetEffectiveFirewallsNetworkRequest
            {
                Project = "",
                Network = "",
            };
            // Make the request
            NetworksGetEffectiveFirewallsResponse response = networksClient.GetEffectiveFirewalls(request);
            // End snippet
        }

        /// <summary>Snippet for GetEffectiveFirewallsAsync</summary>
        public async Task GetEffectiveFirewallsRequestObjectAsync()
        {
            // Snippet: GetEffectiveFirewallsAsync(GetEffectiveFirewallsNetworkRequest, CallSettings)
            // Additional: GetEffectiveFirewallsAsync(GetEffectiveFirewallsNetworkRequest, CancellationToken)
            // Create client
            NetworksClient networksClient = await NetworksClient.CreateAsync();
            // Initialize request argument(s)
            GetEffectiveFirewallsNetworkRequest request = new GetEffectiveFirewallsNetworkRequest
            {
                Project = "",
                Network = "",
            };
            // Make the request
            NetworksGetEffectiveFirewallsResponse response = await networksClient.GetEffectiveFirewallsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetEffectiveFirewalls</summary>
        public void GetEffectiveFirewalls()
        {
            // Snippet: GetEffectiveFirewalls(string, string, CallSettings)
            // Create client
            NetworksClient networksClient = NetworksClient.Create();
            // Initialize request argument(s)
            string project = "";
            string network = "";
            // Make the request
            NetworksGetEffectiveFirewallsResponse response = networksClient.GetEffectiveFirewalls(project, network);
            // End snippet
        }

        /// <summary>Snippet for GetEffectiveFirewallsAsync</summary>
        public async Task GetEffectiveFirewallsAsync()
        {
            // Snippet: GetEffectiveFirewallsAsync(string, string, CallSettings)
            // Additional: GetEffectiveFirewallsAsync(string, string, CancellationToken)
            // Create client
            NetworksClient networksClient = await NetworksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string network = "";
            // Make the request
            NetworksGetEffectiveFirewallsResponse response = await networksClient.GetEffectiveFirewallsAsync(project, network);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void InsertRequestObject()
        {
            // Snippet: Insert(InsertNetworkRequest, CallSettings)
            // Create client
            NetworksClient networksClient = NetworksClient.Create();
            // Initialize request argument(s)
            InsertNetworkRequest request = new InsertNetworkRequest
            {
                RequestId = "",
                NetworkResource = new Network(),
                Project = "",
            };
            // Make the request
            Operation response = networksClient.Insert(request);
            // End snippet
        }

        /// <summary>Snippet for InsertAsync</summary>
        public async Task InsertRequestObjectAsync()
        {
            // Snippet: InsertAsync(InsertNetworkRequest, CallSettings)
            // Additional: InsertAsync(InsertNetworkRequest, CancellationToken)
            // Create client
            NetworksClient networksClient = await NetworksClient.CreateAsync();
            // Initialize request argument(s)
            InsertNetworkRequest request = new InsertNetworkRequest
            {
                RequestId = "",
                NetworkResource = new Network(),
                Project = "",
            };
            // Make the request
            Operation response = await networksClient.InsertAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void Insert()
        {
            // Snippet: Insert(string, Network, CallSettings)
            // Create client
            NetworksClient networksClient = NetworksClient.Create();
            // Initialize request argument(s)
            string project = "";
            Network networkResource = new Network();
            // Make the request
            Operation response = networksClient.Insert(project, networkResource);
            // End snippet
        }

        /// <summary>Snippet for InsertAsync</summary>
        public async Task InsertAsync()
        {
            // Snippet: InsertAsync(string, Network, CallSettings)
            // Additional: InsertAsync(string, Network, CancellationToken)
            // Create client
            NetworksClient networksClient = await NetworksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            Network networkResource = new Network();
            // Make the request
            Operation response = await networksClient.InsertAsync(project, networkResource);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void ListRequestObject()
        {
            // Snippet: List(ListNetworksRequest, CallSettings)
            // Create client
            NetworksClient networksClient = NetworksClient.Create();
            // Initialize request argument(s)
            ListNetworksRequest request = new ListNetworksRequest
            {
                PageToken = "",
                MaxResults = 0U,
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            NetworkList response = networksClient.List(request);
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListRequestObjectAsync()
        {
            // Snippet: ListAsync(ListNetworksRequest, CallSettings)
            // Additional: ListAsync(ListNetworksRequest, CancellationToken)
            // Create client
            NetworksClient networksClient = await NetworksClient.CreateAsync();
            // Initialize request argument(s)
            ListNetworksRequest request = new ListNetworksRequest
            {
                PageToken = "",
                MaxResults = 0U,
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            NetworkList response = await networksClient.ListAsync(request);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void List()
        {
            // Snippet: List(string, CallSettings)
            // Create client
            NetworksClient networksClient = NetworksClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            NetworkList response = networksClient.List(project);
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListAsync()
        {
            // Snippet: ListAsync(string, CallSettings)
            // Additional: ListAsync(string, CancellationToken)
            // Create client
            NetworksClient networksClient = await NetworksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            NetworkList response = await networksClient.ListAsync(project);
            // End snippet
        }

        /// <summary>Snippet for ListPeeringRoutes</summary>
        public void ListPeeringRoutesRequestObject()
        {
            // Snippet: ListPeeringRoutes(ListPeeringRoutesNetworksRequest, CallSettings)
            // Create client
            NetworksClient networksClient = NetworksClient.Create();
            // Initialize request argument(s)
            ListPeeringRoutesNetworksRequest request = new ListPeeringRoutesNetworksRequest
            {
                PageToken = "",
                MaxResults = 0U,
                Direction = ListPeeringRoutesNetworksRequest.Types.Direction.UndefinedDirection,
                Region = "",
                OrderBy = "",
                Project = "",
                Network = "",
                PeeringName = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            ExchangedPeeringRoutesList response = networksClient.ListPeeringRoutes(request);
            // End snippet
        }

        /// <summary>Snippet for ListPeeringRoutesAsync</summary>
        public async Task ListPeeringRoutesRequestObjectAsync()
        {
            // Snippet: ListPeeringRoutesAsync(ListPeeringRoutesNetworksRequest, CallSettings)
            // Additional: ListPeeringRoutesAsync(ListPeeringRoutesNetworksRequest, CancellationToken)
            // Create client
            NetworksClient networksClient = await NetworksClient.CreateAsync();
            // Initialize request argument(s)
            ListPeeringRoutesNetworksRequest request = new ListPeeringRoutesNetworksRequest
            {
                PageToken = "",
                MaxResults = 0U,
                Direction = ListPeeringRoutesNetworksRequest.Types.Direction.UndefinedDirection,
                Region = "",
                OrderBy = "",
                Project = "",
                Network = "",
                PeeringName = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            ExchangedPeeringRoutesList response = await networksClient.ListPeeringRoutesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ListPeeringRoutes</summary>
        public void ListPeeringRoutes()
        {
            // Snippet: ListPeeringRoutes(string, string, CallSettings)
            // Create client
            NetworksClient networksClient = NetworksClient.Create();
            // Initialize request argument(s)
            string project = "";
            string network = "";
            // Make the request
            ExchangedPeeringRoutesList response = networksClient.ListPeeringRoutes(project, network);
            // End snippet
        }

        /// <summary>Snippet for ListPeeringRoutesAsync</summary>
        public async Task ListPeeringRoutesAsync()
        {
            // Snippet: ListPeeringRoutesAsync(string, string, CallSettings)
            // Additional: ListPeeringRoutesAsync(string, string, CancellationToken)
            // Create client
            NetworksClient networksClient = await NetworksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string network = "";
            // Make the request
            ExchangedPeeringRoutesList response = await networksClient.ListPeeringRoutesAsync(project, network);
            // End snippet
        }

        /// <summary>Snippet for Patch</summary>
        public void PatchRequestObject()
        {
            // Snippet: Patch(PatchNetworkRequest, CallSettings)
            // Create client
            NetworksClient networksClient = NetworksClient.Create();
            // Initialize request argument(s)
            PatchNetworkRequest request = new PatchNetworkRequest
            {
                RequestId = "",
                NetworkResource = new Network(),
                Project = "",
                Network = "",
            };
            // Make the request
            Operation response = networksClient.Patch(request);
            // End snippet
        }

        /// <summary>Snippet for PatchAsync</summary>
        public async Task PatchRequestObjectAsync()
        {
            // Snippet: PatchAsync(PatchNetworkRequest, CallSettings)
            // Additional: PatchAsync(PatchNetworkRequest, CancellationToken)
            // Create client
            NetworksClient networksClient = await NetworksClient.CreateAsync();
            // Initialize request argument(s)
            PatchNetworkRequest request = new PatchNetworkRequest
            {
                RequestId = "",
                NetworkResource = new Network(),
                Project = "",
                Network = "",
            };
            // Make the request
            Operation response = await networksClient.PatchAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Patch</summary>
        public void Patch()
        {
            // Snippet: Patch(string, string, Network, CallSettings)
            // Create client
            NetworksClient networksClient = NetworksClient.Create();
            // Initialize request argument(s)
            string project = "";
            string network = "";
            Network networkResource = new Network();
            // Make the request
            Operation response = networksClient.Patch(project, network, networkResource);
            // End snippet
        }

        /// <summary>Snippet for PatchAsync</summary>
        public async Task PatchAsync()
        {
            // Snippet: PatchAsync(string, string, Network, CallSettings)
            // Additional: PatchAsync(string, string, Network, CancellationToken)
            // Create client
            NetworksClient networksClient = await NetworksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string network = "";
            Network networkResource = new Network();
            // Make the request
            Operation response = await networksClient.PatchAsync(project, network, networkResource);
            // End snippet
        }

        /// <summary>Snippet for RemovePeering</summary>
        public void RemovePeeringRequestObject()
        {
            // Snippet: RemovePeering(RemovePeeringNetworkRequest, CallSettings)
            // Create client
            NetworksClient networksClient = NetworksClient.Create();
            // Initialize request argument(s)
            RemovePeeringNetworkRequest request = new RemovePeeringNetworkRequest
            {
                RequestId = "",
                Project = "",
                Network = "",
                NetworksRemovePeeringRequestResource = new NetworksRemovePeeringRequest(),
            };
            // Make the request
            Operation response = networksClient.RemovePeering(request);
            // End snippet
        }

        /// <summary>Snippet for RemovePeeringAsync</summary>
        public async Task RemovePeeringRequestObjectAsync()
        {
            // Snippet: RemovePeeringAsync(RemovePeeringNetworkRequest, CallSettings)
            // Additional: RemovePeeringAsync(RemovePeeringNetworkRequest, CancellationToken)
            // Create client
            NetworksClient networksClient = await NetworksClient.CreateAsync();
            // Initialize request argument(s)
            RemovePeeringNetworkRequest request = new RemovePeeringNetworkRequest
            {
                RequestId = "",
                Project = "",
                Network = "",
                NetworksRemovePeeringRequestResource = new NetworksRemovePeeringRequest(),
            };
            // Make the request
            Operation response = await networksClient.RemovePeeringAsync(request);
            // End snippet
        }

        /// <summary>Snippet for RemovePeering</summary>
        public void RemovePeering()
        {
            // Snippet: RemovePeering(string, string, NetworksRemovePeeringRequest, CallSettings)
            // Create client
            NetworksClient networksClient = NetworksClient.Create();
            // Initialize request argument(s)
            string project = "";
            string network = "";
            NetworksRemovePeeringRequest networksRemovePeeringRequestResource = new NetworksRemovePeeringRequest();
            // Make the request
            Operation response = networksClient.RemovePeering(project, network, networksRemovePeeringRequestResource);
            // End snippet
        }

        /// <summary>Snippet for RemovePeeringAsync</summary>
        public async Task RemovePeeringAsync()
        {
            // Snippet: RemovePeeringAsync(string, string, NetworksRemovePeeringRequest, CallSettings)
            // Additional: RemovePeeringAsync(string, string, NetworksRemovePeeringRequest, CancellationToken)
            // Create client
            NetworksClient networksClient = await NetworksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string network = "";
            NetworksRemovePeeringRequest networksRemovePeeringRequestResource = new NetworksRemovePeeringRequest();
            // Make the request
            Operation response = await networksClient.RemovePeeringAsync(project, network, networksRemovePeeringRequestResource);
            // End snippet
        }

        /// <summary>Snippet for SwitchToCustomMode</summary>
        public void SwitchToCustomModeRequestObject()
        {
            // Snippet: SwitchToCustomMode(SwitchToCustomModeNetworkRequest, CallSettings)
            // Create client
            NetworksClient networksClient = NetworksClient.Create();
            // Initialize request argument(s)
            SwitchToCustomModeNetworkRequest request = new SwitchToCustomModeNetworkRequest
            {
                RequestId = "",
                Project = "",
                Network = "",
            };
            // Make the request
            Operation response = networksClient.SwitchToCustomMode(request);
            // End snippet
        }

        /// <summary>Snippet for SwitchToCustomModeAsync</summary>
        public async Task SwitchToCustomModeRequestObjectAsync()
        {
            // Snippet: SwitchToCustomModeAsync(SwitchToCustomModeNetworkRequest, CallSettings)
            // Additional: SwitchToCustomModeAsync(SwitchToCustomModeNetworkRequest, CancellationToken)
            // Create client
            NetworksClient networksClient = await NetworksClient.CreateAsync();
            // Initialize request argument(s)
            SwitchToCustomModeNetworkRequest request = new SwitchToCustomModeNetworkRequest
            {
                RequestId = "",
                Project = "",
                Network = "",
            };
            // Make the request
            Operation response = await networksClient.SwitchToCustomModeAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SwitchToCustomMode</summary>
        public void SwitchToCustomMode()
        {
            // Snippet: SwitchToCustomMode(string, string, CallSettings)
            // Create client
            NetworksClient networksClient = NetworksClient.Create();
            // Initialize request argument(s)
            string project = "";
            string network = "";
            // Make the request
            Operation response = networksClient.SwitchToCustomMode(project, network);
            // End snippet
        }

        /// <summary>Snippet for SwitchToCustomModeAsync</summary>
        public async Task SwitchToCustomModeAsync()
        {
            // Snippet: SwitchToCustomModeAsync(string, string, CallSettings)
            // Additional: SwitchToCustomModeAsync(string, string, CancellationToken)
            // Create client
            NetworksClient networksClient = await NetworksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string network = "";
            // Make the request
            Operation response = await networksClient.SwitchToCustomModeAsync(project, network);
            // End snippet
        }

        /// <summary>Snippet for UpdatePeering</summary>
        public void UpdatePeeringRequestObject()
        {
            // Snippet: UpdatePeering(UpdatePeeringNetworkRequest, CallSettings)
            // Create client
            NetworksClient networksClient = NetworksClient.Create();
            // Initialize request argument(s)
            UpdatePeeringNetworkRequest request = new UpdatePeeringNetworkRequest
            {
                RequestId = "",
                NetworksUpdatePeeringRequestResource = new NetworksUpdatePeeringRequest(),
                Project = "",
                Network = "",
            };
            // Make the request
            Operation response = networksClient.UpdatePeering(request);
            // End snippet
        }

        /// <summary>Snippet for UpdatePeeringAsync</summary>
        public async Task UpdatePeeringRequestObjectAsync()
        {
            // Snippet: UpdatePeeringAsync(UpdatePeeringNetworkRequest, CallSettings)
            // Additional: UpdatePeeringAsync(UpdatePeeringNetworkRequest, CancellationToken)
            // Create client
            NetworksClient networksClient = await NetworksClient.CreateAsync();
            // Initialize request argument(s)
            UpdatePeeringNetworkRequest request = new UpdatePeeringNetworkRequest
            {
                RequestId = "",
                NetworksUpdatePeeringRequestResource = new NetworksUpdatePeeringRequest(),
                Project = "",
                Network = "",
            };
            // Make the request
            Operation response = await networksClient.UpdatePeeringAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdatePeering</summary>
        public void UpdatePeering()
        {
            // Snippet: UpdatePeering(string, string, NetworksUpdatePeeringRequest, CallSettings)
            // Create client
            NetworksClient networksClient = NetworksClient.Create();
            // Initialize request argument(s)
            string project = "";
            string network = "";
            NetworksUpdatePeeringRequest networksUpdatePeeringRequestResource = new NetworksUpdatePeeringRequest();
            // Make the request
            Operation response = networksClient.UpdatePeering(project, network, networksUpdatePeeringRequestResource);
            // End snippet
        }

        /// <summary>Snippet for UpdatePeeringAsync</summary>
        public async Task UpdatePeeringAsync()
        {
            // Snippet: UpdatePeeringAsync(string, string, NetworksUpdatePeeringRequest, CallSettings)
            // Additional: UpdatePeeringAsync(string, string, NetworksUpdatePeeringRequest, CancellationToken)
            // Create client
            NetworksClient networksClient = await NetworksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string network = "";
            NetworksUpdatePeeringRequest networksUpdatePeeringRequestResource = new NetworksUpdatePeeringRequest();
            // Make the request
            Operation response = await networksClient.UpdatePeeringAsync(project, network, networksUpdatePeeringRequestResource);
            // End snippet
        }
    }
}
