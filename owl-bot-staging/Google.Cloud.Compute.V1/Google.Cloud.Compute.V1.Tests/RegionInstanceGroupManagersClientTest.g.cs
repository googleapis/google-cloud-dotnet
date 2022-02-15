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
    public sealed class GeneratedRegionInstanceGroupManagersClientTest
    {
        [xunit::FactAttribute]
        public void GetRequestObject()
        {
            moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient> mockGrpcClient = new moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetRegionInstanceGroupManagerRequest request = new GetRegionInstanceGroupManagerRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
            };
            InstanceGroupManager expectedResponse = new InstanceGroupManager
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Zone = "zone255f4ea8",
                CreationTimestamp = "creation_timestamp235e59a1",
                StatefulPolicy = new StatefulPolicy(),
                TargetSize = -93132225,
                InstanceGroup = "instance_group6bf5a5ef",
                Region = "regionedb20d96",
                Versions =
                {
                    new InstanceGroupManagerVersion(),
                },
                CurrentActions = new InstanceGroupManagerActionsSummary(),
                UpdatePolicy = new InstanceGroupManagerUpdatePolicy(),
                Status = new InstanceGroupManagerStatus(),
                Fingerprint = "fingerprint009e6052",
                InstanceTemplate = "instance_template6cae3083",
                TargetPools =
                {
                    "target_pools6fc69e1f",
                },
                BaseInstanceName = "base_instance_name7c1f304c",
                Description = "description2cf9da67",
                NamedPorts = { new NamedPort(), },
                SelfLink = "self_link7e87f12d",
                AutoHealingPolicies =
                {
                    new InstanceGroupManagerAutoHealingPolicy(),
                },
                DistributionPolicy = new DistributionPolicy(),
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegionInstanceGroupManagersClient client = new RegionInstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            InstanceGroupManager response = client.Get(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRequestObjectAsync()
        {
            moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient> mockGrpcClient = new moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetRegionInstanceGroupManagerRequest request = new GetRegionInstanceGroupManagerRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
            };
            InstanceGroupManager expectedResponse = new InstanceGroupManager
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Zone = "zone255f4ea8",
                CreationTimestamp = "creation_timestamp235e59a1",
                StatefulPolicy = new StatefulPolicy(),
                TargetSize = -93132225,
                InstanceGroup = "instance_group6bf5a5ef",
                Region = "regionedb20d96",
                Versions =
                {
                    new InstanceGroupManagerVersion(),
                },
                CurrentActions = new InstanceGroupManagerActionsSummary(),
                UpdatePolicy = new InstanceGroupManagerUpdatePolicy(),
                Status = new InstanceGroupManagerStatus(),
                Fingerprint = "fingerprint009e6052",
                InstanceTemplate = "instance_template6cae3083",
                TargetPools =
                {
                    "target_pools6fc69e1f",
                },
                BaseInstanceName = "base_instance_name7c1f304c",
                Description = "description2cf9da67",
                NamedPorts = { new NamedPort(), },
                SelfLink = "self_link7e87f12d",
                AutoHealingPolicies =
                {
                    new InstanceGroupManagerAutoHealingPolicy(),
                },
                DistributionPolicy = new DistributionPolicy(),
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<InstanceGroupManager>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegionInstanceGroupManagersClient client = new RegionInstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            InstanceGroupManager responseCallSettings = await client.GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            InstanceGroupManager responseCancellationToken = await client.GetAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Get()
        {
            moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient> mockGrpcClient = new moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetRegionInstanceGroupManagerRequest request = new GetRegionInstanceGroupManagerRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
            };
            InstanceGroupManager expectedResponse = new InstanceGroupManager
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Zone = "zone255f4ea8",
                CreationTimestamp = "creation_timestamp235e59a1",
                StatefulPolicy = new StatefulPolicy(),
                TargetSize = -93132225,
                InstanceGroup = "instance_group6bf5a5ef",
                Region = "regionedb20d96",
                Versions =
                {
                    new InstanceGroupManagerVersion(),
                },
                CurrentActions = new InstanceGroupManagerActionsSummary(),
                UpdatePolicy = new InstanceGroupManagerUpdatePolicy(),
                Status = new InstanceGroupManagerStatus(),
                Fingerprint = "fingerprint009e6052",
                InstanceTemplate = "instance_template6cae3083",
                TargetPools =
                {
                    "target_pools6fc69e1f",
                },
                BaseInstanceName = "base_instance_name7c1f304c",
                Description = "description2cf9da67",
                NamedPorts = { new NamedPort(), },
                SelfLink = "self_link7e87f12d",
                AutoHealingPolicies =
                {
                    new InstanceGroupManagerAutoHealingPolicy(),
                },
                DistributionPolicy = new DistributionPolicy(),
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegionInstanceGroupManagersClient client = new RegionInstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            InstanceGroupManager response = client.Get(request.Project, request.Region, request.InstanceGroupManager);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAsync()
        {
            moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient> mockGrpcClient = new moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetRegionInstanceGroupManagerRequest request = new GetRegionInstanceGroupManagerRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
            };
            InstanceGroupManager expectedResponse = new InstanceGroupManager
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Zone = "zone255f4ea8",
                CreationTimestamp = "creation_timestamp235e59a1",
                StatefulPolicy = new StatefulPolicy(),
                TargetSize = -93132225,
                InstanceGroup = "instance_group6bf5a5ef",
                Region = "regionedb20d96",
                Versions =
                {
                    new InstanceGroupManagerVersion(),
                },
                CurrentActions = new InstanceGroupManagerActionsSummary(),
                UpdatePolicy = new InstanceGroupManagerUpdatePolicy(),
                Status = new InstanceGroupManagerStatus(),
                Fingerprint = "fingerprint009e6052",
                InstanceTemplate = "instance_template6cae3083",
                TargetPools =
                {
                    "target_pools6fc69e1f",
                },
                BaseInstanceName = "base_instance_name7c1f304c",
                Description = "description2cf9da67",
                NamedPorts = { new NamedPort(), },
                SelfLink = "self_link7e87f12d",
                AutoHealingPolicies =
                {
                    new InstanceGroupManagerAutoHealingPolicy(),
                },
                DistributionPolicy = new DistributionPolicy(),
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<InstanceGroupManager>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegionInstanceGroupManagersClient client = new RegionInstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            InstanceGroupManager responseCallSettings = await client.GetAsync(request.Project, request.Region, request.InstanceGroupManager, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            InstanceGroupManager responseCancellationToken = await client.GetAsync(request.Project, request.Region, request.InstanceGroupManager, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
