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
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Memcache.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedCloudMemcacheClientTest
    {
        [xunit::FactAttribute]
        public void GetInstanceRequestObject()
        {
            moq::Mock<CloudMemcache.CloudMemcacheClient> mockGrpcClient = new moq::Mock<CloudMemcache.CloudMemcacheClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetInstanceRequest request = new GetInstanceRequest
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
            };
            Instance expectedResponse = new Instance
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                DisplayName = "display_name137f65c2",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                AuthorizedNetwork = "authorized_network63563381",
                Zones = { "zones3641f926", },
                NodeCount = -1659500730,
                NodeConfig = new Instance.Types.NodeConfig(),
                MemcacheVersion = MemcacheVersion.Memcache15,
                Parameters = new MemcacheParameters(),
                MemcacheNodes =
                {
                    new Instance.Types.Node(),
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                State = Instance.Types.State.Deleting,
                MemcacheFullVersion = "memcache_full_version4b648a5f",
                InstanceMessages =
                {
                    new Instance.Types.InstanceMessage(),
                },
                DiscoveryEndpoint = "discovery_endpointe07f14c7",
            };
            mockGrpcClient.Setup(x => x.GetInstance(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudMemcacheClient client = new CloudMemcacheClientImpl(mockGrpcClient.Object, null);
            Instance response = client.GetInstance(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetInstanceRequestObjectAsync()
        {
            moq::Mock<CloudMemcache.CloudMemcacheClient> mockGrpcClient = new moq::Mock<CloudMemcache.CloudMemcacheClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetInstanceRequest request = new GetInstanceRequest
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
            };
            Instance expectedResponse = new Instance
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                DisplayName = "display_name137f65c2",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                AuthorizedNetwork = "authorized_network63563381",
                Zones = { "zones3641f926", },
                NodeCount = -1659500730,
                NodeConfig = new Instance.Types.NodeConfig(),
                MemcacheVersion = MemcacheVersion.Memcache15,
                Parameters = new MemcacheParameters(),
                MemcacheNodes =
                {
                    new Instance.Types.Node(),
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                State = Instance.Types.State.Deleting,
                MemcacheFullVersion = "memcache_full_version4b648a5f",
                InstanceMessages =
                {
                    new Instance.Types.InstanceMessage(),
                },
                DiscoveryEndpoint = "discovery_endpointe07f14c7",
            };
            mockGrpcClient.Setup(x => x.GetInstanceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Instance>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudMemcacheClient client = new CloudMemcacheClientImpl(mockGrpcClient.Object, null);
            Instance responseCallSettings = await client.GetInstanceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Instance responseCancellationToken = await client.GetInstanceAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetInstance()
        {
            moq::Mock<CloudMemcache.CloudMemcacheClient> mockGrpcClient = new moq::Mock<CloudMemcache.CloudMemcacheClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetInstanceRequest request = new GetInstanceRequest
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
            };
            Instance expectedResponse = new Instance
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                DisplayName = "display_name137f65c2",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                AuthorizedNetwork = "authorized_network63563381",
                Zones = { "zones3641f926", },
                NodeCount = -1659500730,
                NodeConfig = new Instance.Types.NodeConfig(),
                MemcacheVersion = MemcacheVersion.Memcache15,
                Parameters = new MemcacheParameters(),
                MemcacheNodes =
                {
                    new Instance.Types.Node(),
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                State = Instance.Types.State.Deleting,
                MemcacheFullVersion = "memcache_full_version4b648a5f",
                InstanceMessages =
                {
                    new Instance.Types.InstanceMessage(),
                },
                DiscoveryEndpoint = "discovery_endpointe07f14c7",
            };
            mockGrpcClient.Setup(x => x.GetInstance(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudMemcacheClient client = new CloudMemcacheClientImpl(mockGrpcClient.Object, null);
            Instance response = client.GetInstance(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetInstanceAsync()
        {
            moq::Mock<CloudMemcache.CloudMemcacheClient> mockGrpcClient = new moq::Mock<CloudMemcache.CloudMemcacheClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetInstanceRequest request = new GetInstanceRequest
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
            };
            Instance expectedResponse = new Instance
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                DisplayName = "display_name137f65c2",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                AuthorizedNetwork = "authorized_network63563381",
                Zones = { "zones3641f926", },
                NodeCount = -1659500730,
                NodeConfig = new Instance.Types.NodeConfig(),
                MemcacheVersion = MemcacheVersion.Memcache15,
                Parameters = new MemcacheParameters(),
                MemcacheNodes =
                {
                    new Instance.Types.Node(),
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                State = Instance.Types.State.Deleting,
                MemcacheFullVersion = "memcache_full_version4b648a5f",
                InstanceMessages =
                {
                    new Instance.Types.InstanceMessage(),
                },
                DiscoveryEndpoint = "discovery_endpointe07f14c7",
            };
            mockGrpcClient.Setup(x => x.GetInstanceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Instance>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudMemcacheClient client = new CloudMemcacheClientImpl(mockGrpcClient.Object, null);
            Instance responseCallSettings = await client.GetInstanceAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Instance responseCancellationToken = await client.GetInstanceAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetInstanceResourceNames()
        {
            moq::Mock<CloudMemcache.CloudMemcacheClient> mockGrpcClient = new moq::Mock<CloudMemcache.CloudMemcacheClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetInstanceRequest request = new GetInstanceRequest
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
            };
            Instance expectedResponse = new Instance
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                DisplayName = "display_name137f65c2",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                AuthorizedNetwork = "authorized_network63563381",
                Zones = { "zones3641f926", },
                NodeCount = -1659500730,
                NodeConfig = new Instance.Types.NodeConfig(),
                MemcacheVersion = MemcacheVersion.Memcache15,
                Parameters = new MemcacheParameters(),
                MemcacheNodes =
                {
                    new Instance.Types.Node(),
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                State = Instance.Types.State.Deleting,
                MemcacheFullVersion = "memcache_full_version4b648a5f",
                InstanceMessages =
                {
                    new Instance.Types.InstanceMessage(),
                },
                DiscoveryEndpoint = "discovery_endpointe07f14c7",
            };
            mockGrpcClient.Setup(x => x.GetInstance(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudMemcacheClient client = new CloudMemcacheClientImpl(mockGrpcClient.Object, null);
            Instance response = client.GetInstance(request.InstanceName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetInstanceResourceNamesAsync()
        {
            moq::Mock<CloudMemcache.CloudMemcacheClient> mockGrpcClient = new moq::Mock<CloudMemcache.CloudMemcacheClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetInstanceRequest request = new GetInstanceRequest
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
            };
            Instance expectedResponse = new Instance
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                DisplayName = "display_name137f65c2",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                AuthorizedNetwork = "authorized_network63563381",
                Zones = { "zones3641f926", },
                NodeCount = -1659500730,
                NodeConfig = new Instance.Types.NodeConfig(),
                MemcacheVersion = MemcacheVersion.Memcache15,
                Parameters = new MemcacheParameters(),
                MemcacheNodes =
                {
                    new Instance.Types.Node(),
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                State = Instance.Types.State.Deleting,
                MemcacheFullVersion = "memcache_full_version4b648a5f",
                InstanceMessages =
                {
                    new Instance.Types.InstanceMessage(),
                },
                DiscoveryEndpoint = "discovery_endpointe07f14c7",
            };
            mockGrpcClient.Setup(x => x.GetInstanceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Instance>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudMemcacheClient client = new CloudMemcacheClientImpl(mockGrpcClient.Object, null);
            Instance responseCallSettings = await client.GetInstanceAsync(request.InstanceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Instance responseCancellationToken = await client.GetInstanceAsync(request.InstanceName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
