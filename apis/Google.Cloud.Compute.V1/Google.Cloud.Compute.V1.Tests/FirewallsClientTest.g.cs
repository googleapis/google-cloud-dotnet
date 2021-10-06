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
    public sealed class GeneratedFirewallsClientTest
    {
        [xunit::FactAttribute]
        public void GetRequestObject()
        {
            moq::Mock<Firewalls.FirewallsClient> mockGrpcClient = new moq::Mock<Firewalls.FirewallsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetFirewallRequest request = new GetFirewallRequest
            {
                Project = "projectaa6ff846",
                Firewall = "firewall1a37e536",
            };
            Firewall expectedResponse = new Firewall
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CreationTimestamp = "creation_timestamp235e59a1",
                TargetTags =
                {
                    "target_tags29e39aea",
                },
                SourceServiceAccounts =
                {
                    "source_service_accounts462c1c37",
                },
                Direction = Firewall.Types.Direction.Ingress,
                Allowed = { new Allowed(), },
                SourceRanges =
                {
                    "source_ranges5dbeae62",
                },
                Network = "networkd22ce091",
                Disabled = false,
                Denied = { new Denied(), },
                DestinationRanges =
                {
                    "destination_rangesf67f2379",
                },
                LogConfig = new FirewallLogConfig(),
                Description = "description2cf9da67",
                Priority = 1546225849,
                SourceTags =
                {
                    "source_tags7a2648e1",
                },
                SelfLink = "self_link7e87f12d",
                TargetServiceAccounts =
                {
                    "target_service_accounts61bf1663",
                },
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FirewallsClient client = new FirewallsClientImpl(mockGrpcClient.Object, null);
            Firewall response = client.Get(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRequestObjectAsync()
        {
            moq::Mock<Firewalls.FirewallsClient> mockGrpcClient = new moq::Mock<Firewalls.FirewallsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetFirewallRequest request = new GetFirewallRequest
            {
                Project = "projectaa6ff846",
                Firewall = "firewall1a37e536",
            };
            Firewall expectedResponse = new Firewall
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CreationTimestamp = "creation_timestamp235e59a1",
                TargetTags =
                {
                    "target_tags29e39aea",
                },
                SourceServiceAccounts =
                {
                    "source_service_accounts462c1c37",
                },
                Direction = Firewall.Types.Direction.Ingress,
                Allowed = { new Allowed(), },
                SourceRanges =
                {
                    "source_ranges5dbeae62",
                },
                Network = "networkd22ce091",
                Disabled = false,
                Denied = { new Denied(), },
                DestinationRanges =
                {
                    "destination_rangesf67f2379",
                },
                LogConfig = new FirewallLogConfig(),
                Description = "description2cf9da67",
                Priority = 1546225849,
                SourceTags =
                {
                    "source_tags7a2648e1",
                },
                SelfLink = "self_link7e87f12d",
                TargetServiceAccounts =
                {
                    "target_service_accounts61bf1663",
                },
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Firewall>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FirewallsClient client = new FirewallsClientImpl(mockGrpcClient.Object, null);
            Firewall responseCallSettings = await client.GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Firewall responseCancellationToken = await client.GetAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Get()
        {
            moq::Mock<Firewalls.FirewallsClient> mockGrpcClient = new moq::Mock<Firewalls.FirewallsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetFirewallRequest request = new GetFirewallRequest
            {
                Project = "projectaa6ff846",
                Firewall = "firewall1a37e536",
            };
            Firewall expectedResponse = new Firewall
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CreationTimestamp = "creation_timestamp235e59a1",
                TargetTags =
                {
                    "target_tags29e39aea",
                },
                SourceServiceAccounts =
                {
                    "source_service_accounts462c1c37",
                },
                Direction = Firewall.Types.Direction.Ingress,
                Allowed = { new Allowed(), },
                SourceRanges =
                {
                    "source_ranges5dbeae62",
                },
                Network = "networkd22ce091",
                Disabled = false,
                Denied = { new Denied(), },
                DestinationRanges =
                {
                    "destination_rangesf67f2379",
                },
                LogConfig = new FirewallLogConfig(),
                Description = "description2cf9da67",
                Priority = 1546225849,
                SourceTags =
                {
                    "source_tags7a2648e1",
                },
                SelfLink = "self_link7e87f12d",
                TargetServiceAccounts =
                {
                    "target_service_accounts61bf1663",
                },
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FirewallsClient client = new FirewallsClientImpl(mockGrpcClient.Object, null);
            Firewall response = client.Get(request.Project, request.Firewall);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAsync()
        {
            moq::Mock<Firewalls.FirewallsClient> mockGrpcClient = new moq::Mock<Firewalls.FirewallsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetFirewallRequest request = new GetFirewallRequest
            {
                Project = "projectaa6ff846",
                Firewall = "firewall1a37e536",
            };
            Firewall expectedResponse = new Firewall
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CreationTimestamp = "creation_timestamp235e59a1",
                TargetTags =
                {
                    "target_tags29e39aea",
                },
                SourceServiceAccounts =
                {
                    "source_service_accounts462c1c37",
                },
                Direction = Firewall.Types.Direction.Ingress,
                Allowed = { new Allowed(), },
                SourceRanges =
                {
                    "source_ranges5dbeae62",
                },
                Network = "networkd22ce091",
                Disabled = false,
                Denied = { new Denied(), },
                DestinationRanges =
                {
                    "destination_rangesf67f2379",
                },
                LogConfig = new FirewallLogConfig(),
                Description = "description2cf9da67",
                Priority = 1546225849,
                SourceTags =
                {
                    "source_tags7a2648e1",
                },
                SelfLink = "self_link7e87f12d",
                TargetServiceAccounts =
                {
                    "target_service_accounts61bf1663",
                },
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Firewall>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FirewallsClient client = new FirewallsClientImpl(mockGrpcClient.Object, null);
            Firewall responseCallSettings = await client.GetAsync(request.Project, request.Firewall, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Firewall responseCancellationToken = await client.GetAsync(request.Project, request.Firewall, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
