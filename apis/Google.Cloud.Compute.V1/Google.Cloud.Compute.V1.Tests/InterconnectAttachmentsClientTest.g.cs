// Copyright 2022 Google LLC
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

using gaxgrpc = Google.Api.Gax.Grpc;
using lro = Google.LongRunning;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Compute.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedInterconnectAttachmentsClientTest
    {
        [xunit::FactAttribute]
        public void GetRequestObject()
        {
            moq::Mock<InterconnectAttachments.InterconnectAttachmentsClient> mockGrpcClient = new moq::Mock<InterconnectAttachments.InterconnectAttachmentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetInterconnectAttachmentRequest request = new GetInterconnectAttachmentRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                InterconnectAttachment = "interconnect_attachmentc83a7a7c",
            };
            InterconnectAttachment expectedResponse = new InterconnectAttachment
            {
                Id = 11672635353343658936UL,
                Mtu = 1280318054,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Type = "typee2cc9d59",
                CreationTimestamp = "creation_timestamp235e59a1",
                DataplaneVersion = -763719012,
                PartnerMetadata = new InterconnectAttachmentPartnerMetadata(),
                CandidateIpv6Subnets =
                {
                    "candidate_ipv6_subnets2c08bf5e",
                },
                EdgeAvailabilityDomain = "edge_availability_domainf7acc827",
                Encryption = "encryption9174df5b",
                State = "state2e9ed39e",
                VlanTag8021Q = 1290733749,
                Region = "regionedb20d96",
                Router = "routerd55c39f3",
                Bandwidth = "bandwidth2b6c6736",
                OperationalStatus = "operational_status14a476d9",
                Interconnect = "interconnect253e8bf5",
                PrivateInterconnectInfo = new InterconnectAttachmentPrivateInfo(),
                CandidateSubnets =
                {
                    "candidate_subnets3377adaa",
                },
                CloudRouterIpAddress = "cloud_router_ip_address62b476a9",
                CustomerRouterIpv6Address = "customer_router_ipv6_address4c2b6c88",
                CustomerRouterIpAddress = "customer_router_ip_address819aa186",
                CustomerRouterIpv6InterfaceId = "customer_router_ipv6_interface_idb4ee260e",
                IpsecInternalAddresses =
                {
                    "ipsec_internal_addresses8b47c5bb",
                },
                Description = "description2cf9da67",
                StackType = "stack_type3a495e39",
                PartnerAsn = 6862354938501622805L,
                PairingKey = "pairing_keyfe878c44",
                AdminEnabled = true,
                CloudRouterIpv6Address = "cloud_router_ipv6_addressf4d97622",
                SelfLink = "self_link7e87f12d",
                SatisfiesPzs = false,
                CloudRouterIpv6InterfaceId = "cloud_router_ipv6_interface_idc5436f7e",
                GoogleReferenceId = "google_reference_id815b6ab4",
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InterconnectAttachmentsClient client = new InterconnectAttachmentsClientImpl(mockGrpcClient.Object, null, null);
            InterconnectAttachment response = client.Get(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRequestObjectAsync()
        {
            moq::Mock<InterconnectAttachments.InterconnectAttachmentsClient> mockGrpcClient = new moq::Mock<InterconnectAttachments.InterconnectAttachmentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetInterconnectAttachmentRequest request = new GetInterconnectAttachmentRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                InterconnectAttachment = "interconnect_attachmentc83a7a7c",
            };
            InterconnectAttachment expectedResponse = new InterconnectAttachment
            {
                Id = 11672635353343658936UL,
                Mtu = 1280318054,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Type = "typee2cc9d59",
                CreationTimestamp = "creation_timestamp235e59a1",
                DataplaneVersion = -763719012,
                PartnerMetadata = new InterconnectAttachmentPartnerMetadata(),
                CandidateIpv6Subnets =
                {
                    "candidate_ipv6_subnets2c08bf5e",
                },
                EdgeAvailabilityDomain = "edge_availability_domainf7acc827",
                Encryption = "encryption9174df5b",
                State = "state2e9ed39e",
                VlanTag8021Q = 1290733749,
                Region = "regionedb20d96",
                Router = "routerd55c39f3",
                Bandwidth = "bandwidth2b6c6736",
                OperationalStatus = "operational_status14a476d9",
                Interconnect = "interconnect253e8bf5",
                PrivateInterconnectInfo = new InterconnectAttachmentPrivateInfo(),
                CandidateSubnets =
                {
                    "candidate_subnets3377adaa",
                },
                CloudRouterIpAddress = "cloud_router_ip_address62b476a9",
                CustomerRouterIpv6Address = "customer_router_ipv6_address4c2b6c88",
                CustomerRouterIpAddress = "customer_router_ip_address819aa186",
                CustomerRouterIpv6InterfaceId = "customer_router_ipv6_interface_idb4ee260e",
                IpsecInternalAddresses =
                {
                    "ipsec_internal_addresses8b47c5bb",
                },
                Description = "description2cf9da67",
                StackType = "stack_type3a495e39",
                PartnerAsn = 6862354938501622805L,
                PairingKey = "pairing_keyfe878c44",
                AdminEnabled = true,
                CloudRouterIpv6Address = "cloud_router_ipv6_addressf4d97622",
                SelfLink = "self_link7e87f12d",
                SatisfiesPzs = false,
                CloudRouterIpv6InterfaceId = "cloud_router_ipv6_interface_idc5436f7e",
                GoogleReferenceId = "google_reference_id815b6ab4",
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<InterconnectAttachment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InterconnectAttachmentsClient client = new InterconnectAttachmentsClientImpl(mockGrpcClient.Object, null, null);
            InterconnectAttachment responseCallSettings = await client.GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            InterconnectAttachment responseCancellationToken = await client.GetAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Get()
        {
            moq::Mock<InterconnectAttachments.InterconnectAttachmentsClient> mockGrpcClient = new moq::Mock<InterconnectAttachments.InterconnectAttachmentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetInterconnectAttachmentRequest request = new GetInterconnectAttachmentRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                InterconnectAttachment = "interconnect_attachmentc83a7a7c",
            };
            InterconnectAttachment expectedResponse = new InterconnectAttachment
            {
                Id = 11672635353343658936UL,
                Mtu = 1280318054,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Type = "typee2cc9d59",
                CreationTimestamp = "creation_timestamp235e59a1",
                DataplaneVersion = -763719012,
                PartnerMetadata = new InterconnectAttachmentPartnerMetadata(),
                CandidateIpv6Subnets =
                {
                    "candidate_ipv6_subnets2c08bf5e",
                },
                EdgeAvailabilityDomain = "edge_availability_domainf7acc827",
                Encryption = "encryption9174df5b",
                State = "state2e9ed39e",
                VlanTag8021Q = 1290733749,
                Region = "regionedb20d96",
                Router = "routerd55c39f3",
                Bandwidth = "bandwidth2b6c6736",
                OperationalStatus = "operational_status14a476d9",
                Interconnect = "interconnect253e8bf5",
                PrivateInterconnectInfo = new InterconnectAttachmentPrivateInfo(),
                CandidateSubnets =
                {
                    "candidate_subnets3377adaa",
                },
                CloudRouterIpAddress = "cloud_router_ip_address62b476a9",
                CustomerRouterIpv6Address = "customer_router_ipv6_address4c2b6c88",
                CustomerRouterIpAddress = "customer_router_ip_address819aa186",
                CustomerRouterIpv6InterfaceId = "customer_router_ipv6_interface_idb4ee260e",
                IpsecInternalAddresses =
                {
                    "ipsec_internal_addresses8b47c5bb",
                },
                Description = "description2cf9da67",
                StackType = "stack_type3a495e39",
                PartnerAsn = 6862354938501622805L,
                PairingKey = "pairing_keyfe878c44",
                AdminEnabled = true,
                CloudRouterIpv6Address = "cloud_router_ipv6_addressf4d97622",
                SelfLink = "self_link7e87f12d",
                SatisfiesPzs = false,
                CloudRouterIpv6InterfaceId = "cloud_router_ipv6_interface_idc5436f7e",
                GoogleReferenceId = "google_reference_id815b6ab4",
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InterconnectAttachmentsClient client = new InterconnectAttachmentsClientImpl(mockGrpcClient.Object, null, null);
            InterconnectAttachment response = client.Get(request.Project, request.Region, request.InterconnectAttachment);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAsync()
        {
            moq::Mock<InterconnectAttachments.InterconnectAttachmentsClient> mockGrpcClient = new moq::Mock<InterconnectAttachments.InterconnectAttachmentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetInterconnectAttachmentRequest request = new GetInterconnectAttachmentRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                InterconnectAttachment = "interconnect_attachmentc83a7a7c",
            };
            InterconnectAttachment expectedResponse = new InterconnectAttachment
            {
                Id = 11672635353343658936UL,
                Mtu = 1280318054,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Type = "typee2cc9d59",
                CreationTimestamp = "creation_timestamp235e59a1",
                DataplaneVersion = -763719012,
                PartnerMetadata = new InterconnectAttachmentPartnerMetadata(),
                CandidateIpv6Subnets =
                {
                    "candidate_ipv6_subnets2c08bf5e",
                },
                EdgeAvailabilityDomain = "edge_availability_domainf7acc827",
                Encryption = "encryption9174df5b",
                State = "state2e9ed39e",
                VlanTag8021Q = 1290733749,
                Region = "regionedb20d96",
                Router = "routerd55c39f3",
                Bandwidth = "bandwidth2b6c6736",
                OperationalStatus = "operational_status14a476d9",
                Interconnect = "interconnect253e8bf5",
                PrivateInterconnectInfo = new InterconnectAttachmentPrivateInfo(),
                CandidateSubnets =
                {
                    "candidate_subnets3377adaa",
                },
                CloudRouterIpAddress = "cloud_router_ip_address62b476a9",
                CustomerRouterIpv6Address = "customer_router_ipv6_address4c2b6c88",
                CustomerRouterIpAddress = "customer_router_ip_address819aa186",
                CustomerRouterIpv6InterfaceId = "customer_router_ipv6_interface_idb4ee260e",
                IpsecInternalAddresses =
                {
                    "ipsec_internal_addresses8b47c5bb",
                },
                Description = "description2cf9da67",
                StackType = "stack_type3a495e39",
                PartnerAsn = 6862354938501622805L,
                PairingKey = "pairing_keyfe878c44",
                AdminEnabled = true,
                CloudRouterIpv6Address = "cloud_router_ipv6_addressf4d97622",
                SelfLink = "self_link7e87f12d",
                SatisfiesPzs = false,
                CloudRouterIpv6InterfaceId = "cloud_router_ipv6_interface_idc5436f7e",
                GoogleReferenceId = "google_reference_id815b6ab4",
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<InterconnectAttachment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InterconnectAttachmentsClient client = new InterconnectAttachmentsClientImpl(mockGrpcClient.Object, null, null);
            InterconnectAttachment responseCallSettings = await client.GetAsync(request.Project, request.Region, request.InterconnectAttachment, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            InterconnectAttachment responseCancellationToken = await client.GetAsync(request.Project, request.Region, request.InterconnectAttachment, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
