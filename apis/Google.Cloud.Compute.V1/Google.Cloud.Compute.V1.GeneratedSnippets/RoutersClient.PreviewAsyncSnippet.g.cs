// Copyright 2024 Google LLC
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
    // [START compute_v1_generated_Routers_Preview_async_flattened]
    using Google.Cloud.Compute.V1;
    using System.Threading.Tasks;

    public sealed partial class GeneratedRoutersClientSnippets
    {
        /// <summary>Snippet for PreviewAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public async Task PreviewAsync()
        {
            // Create client
            RoutersClient routersClient = await RoutersClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string router = "";
            Router routerResource = new Router
            {
                Id = 0UL,
                Bgp = new RouterBgp
                {
                    Asn = 0U,
                    AdvertisedGroups = { "", },
                    AdvertisedIpRanges =
                    {
                        new RouterAdvertisedIpRange
                        {
                            Range = "",
                            Description = "",
                        },
                    },
                    KeepaliveInterval = 0U,
                    AdvertiseMode = "",
                    IdentifierRange = "",
                },
                Kind = "",
                Name = "",
                Nats =
                {
                    new RouterNat
                    {
                        Name = "",
                        Type = "",
                        IcmpIdleTimeoutSec = 0,
                        UdpIdleTimeoutSec = 0,
                        Rules =
                        {
                            new RouterNatRule
                            {
                                Match = "",
                                Action = new RouterNatRuleAction
                                {
                                    SourceNatDrainRanges = { "", },
                                    SourceNatActiveRanges = { "", },
                                    SourceNatActiveIps = { "", },
                                    SourceNatDrainIps = { "", },
                                },
                                Description = "",
                                RuleNumber = 0U,
                            },
                        },
                        NatIps = { "", },
                        MinPortsPerVm = 0,
                        TcpTransitoryIdleTimeoutSec = 0,
                        TcpEstablishedIdleTimeoutSec = 0,
                        MaxPortsPerVm = 0,
                        SourceSubnetworkIpRangesToNat = "",
                        EnableEndpointIndependentMapping = false,
                        AutoNetworkTier = "",
                        LogConfig = new RouterNatLogConfig
                        {
                            Enable = false,
                            Filter = "",
                        },
                        Subnetworks =
                        {
                            new RouterNatSubnetworkToNat
                            {
                                Name = "",
                                SecondaryIpRangeNames = { "", },
                                SourceIpRangesToNat = { "", },
                            },
                        },
                        NatIpAllocateOption = "",
                        EndpointTypes = { "", },
                        DrainNatIps = { "", },
                        TcpTimeWaitTimeoutSec = 0,
                        EnableDynamicPortAllocation = false,
                    },
                },
                Interfaces =
                {
                    new RouterInterface
                    {
                        Name = "",
                        PrivateIpAddress = "",
                        IpRange = "",
                        ManagementType = "",
                        IpVersion = "",
                        Subnetwork = "",
                        LinkedVpnTunnel = "",
                        LinkedInterconnectAttachment = "",
                        RedundantInterface = "",
                    },
                },
                CreationTimestamp = "",
                Md5AuthenticationKeys =
                {
                    new RouterMd5AuthenticationKey { Key = "", Name = "", },
                },
                Region = "",
                Network = "",
                EncryptedInterconnectRouter = false,
                Description = "",
                BgpPeers =
                {
                    new RouterBgpPeer
                    {
                        Bfd = new RouterBgpPeerBfd
                        {
                            SessionInitializationMode = "",
                            MinReceiveInterval = 0U,
                            Multiplier = 0U,
                            MinTransmitInterval = 0U,
                        },
                        Name = "",
                        Ipv4NexthopAddress = "",
                        AdvertisedGroups = { "", },
                        Ipv6NexthopAddress = "",
                        AdvertisedIpRanges =
                        {
                            new RouterAdvertisedIpRange
                            {
                                Range = "",
                                Description = "",
                            },
                        },
                        PeerAsn = 0U,
                        ExportPolicies = { "", },
                        ManagementType = "",
                        EnableIpv4 = false,
                        EnableIpv6 = false,
                        AdvertisedRoutePriority = 0U,
                        PeerIpAddress = "",
                        Md5AuthenticationKeyName = "",
                        Enable = "",
                        AdvertiseMode = "",
                        CustomLearnedRoutePriority = 0,
                        IpAddress = "",
                        InterfaceName = "",
                        ImportPolicies = { "", },
                        RouterApplianceInstance = "",
                        PeerIpv4NexthopAddress = "",
                        CustomLearnedIpRanges =
                        {
                            new RouterBgpPeerCustomLearnedIpRange { Range = "", },
                        },
                        PeerIpv6NexthopAddress = "",
                    },
                },
                SelfLink = "",
            };
            // Make the request
            RoutersPreviewResponse response = await routersClient.PreviewAsync(project, region, router, routerResource);
        }
    }
    // [END compute_v1_generated_Routers_Preview_async_flattened]
}
