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

namespace Google.Cloud.Redis.V1Beta1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedCloudRedisClientTest
    {
        [xunit::FactAttribute]
        public void GetInstanceRequestObject()
        {
            moq::Mock<CloudRedis.CloudRedisClient> mockGrpcClient = new moq::Mock<CloudRedis.CloudRedisClient>(moq::MockBehavior.Strict);
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
                LocationId = "location_iddaa574e2",
                AlternativeLocationId = "alternative_location_id9b86fe18",
                RedisVersion = "redis_version52f1f9d8",
                ReservedIpRange = "reserved_ip_range779ab299",
                Host = "hosta8dbb367",
                Port = -78310000,
                CurrentLocationId = "current_location_id65ef644c",
                CreateTime = new wkt::Timestamp(),
                State = Instance.Types.State.Updating,
                StatusMessage = "status_message2c618f86",
                RedisConfigs =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Tier = Instance.Types.Tier.Basic,
                MemorySizeGb = 863378110,
                AuthorizedNetwork = "authorized_network63563381",
                PersistenceIamIdentity = "persistence_iam_identitye8d96e46",
                ConnectMode = Instance.Types.ConnectMode.Unspecified,
                AuthEnabled = false,
                ServerCaCerts =
                {
                    new TlsCertificate(),
                },
                TransitEncryptionMode = Instance.Types.TransitEncryptionMode.Disabled,
                MaintenancePolicy = new MaintenancePolicy(),
                MaintenanceSchedule = new MaintenanceSchedule(),
                ReplicaCount = -2132170114,
                Nodes = { new NodeInfo(), },
                ReadEndpoint = "read_endpointb6c6d0a1",
                ReadEndpointPort = 906869138,
                ReadReplicasMode = Instance.Types.ReadReplicasMode.ReadReplicasEnabled,
            };
            mockGrpcClient.Setup(x => x.GetInstance(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudRedisClient client = new CloudRedisClientImpl(mockGrpcClient.Object, null);
            Instance response = client.GetInstance(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetInstanceRequestObjectAsync()
        {
            moq::Mock<CloudRedis.CloudRedisClient> mockGrpcClient = new moq::Mock<CloudRedis.CloudRedisClient>(moq::MockBehavior.Strict);
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
                LocationId = "location_iddaa574e2",
                AlternativeLocationId = "alternative_location_id9b86fe18",
                RedisVersion = "redis_version52f1f9d8",
                ReservedIpRange = "reserved_ip_range779ab299",
                Host = "hosta8dbb367",
                Port = -78310000,
                CurrentLocationId = "current_location_id65ef644c",
                CreateTime = new wkt::Timestamp(),
                State = Instance.Types.State.Updating,
                StatusMessage = "status_message2c618f86",
                RedisConfigs =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Tier = Instance.Types.Tier.Basic,
                MemorySizeGb = 863378110,
                AuthorizedNetwork = "authorized_network63563381",
                PersistenceIamIdentity = "persistence_iam_identitye8d96e46",
                ConnectMode = Instance.Types.ConnectMode.Unspecified,
                AuthEnabled = false,
                ServerCaCerts =
                {
                    new TlsCertificate(),
                },
                TransitEncryptionMode = Instance.Types.TransitEncryptionMode.Disabled,
                MaintenancePolicy = new MaintenancePolicy(),
                MaintenanceSchedule = new MaintenanceSchedule(),
                ReplicaCount = -2132170114,
                Nodes = { new NodeInfo(), },
                ReadEndpoint = "read_endpointb6c6d0a1",
                ReadEndpointPort = 906869138,
                ReadReplicasMode = Instance.Types.ReadReplicasMode.ReadReplicasEnabled,
            };
            mockGrpcClient.Setup(x => x.GetInstanceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Instance>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudRedisClient client = new CloudRedisClientImpl(mockGrpcClient.Object, null);
            Instance responseCallSettings = await client.GetInstanceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Instance responseCancellationToken = await client.GetInstanceAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetInstance()
        {
            moq::Mock<CloudRedis.CloudRedisClient> mockGrpcClient = new moq::Mock<CloudRedis.CloudRedisClient>(moq::MockBehavior.Strict);
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
                LocationId = "location_iddaa574e2",
                AlternativeLocationId = "alternative_location_id9b86fe18",
                RedisVersion = "redis_version52f1f9d8",
                ReservedIpRange = "reserved_ip_range779ab299",
                Host = "hosta8dbb367",
                Port = -78310000,
                CurrentLocationId = "current_location_id65ef644c",
                CreateTime = new wkt::Timestamp(),
                State = Instance.Types.State.Updating,
                StatusMessage = "status_message2c618f86",
                RedisConfigs =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Tier = Instance.Types.Tier.Basic,
                MemorySizeGb = 863378110,
                AuthorizedNetwork = "authorized_network63563381",
                PersistenceIamIdentity = "persistence_iam_identitye8d96e46",
                ConnectMode = Instance.Types.ConnectMode.Unspecified,
                AuthEnabled = false,
                ServerCaCerts =
                {
                    new TlsCertificate(),
                },
                TransitEncryptionMode = Instance.Types.TransitEncryptionMode.Disabled,
                MaintenancePolicy = new MaintenancePolicy(),
                MaintenanceSchedule = new MaintenanceSchedule(),
                ReplicaCount = -2132170114,
                Nodes = { new NodeInfo(), },
                ReadEndpoint = "read_endpointb6c6d0a1",
                ReadEndpointPort = 906869138,
                ReadReplicasMode = Instance.Types.ReadReplicasMode.ReadReplicasEnabled,
            };
            mockGrpcClient.Setup(x => x.GetInstance(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudRedisClient client = new CloudRedisClientImpl(mockGrpcClient.Object, null);
            Instance response = client.GetInstance(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetInstanceAsync()
        {
            moq::Mock<CloudRedis.CloudRedisClient> mockGrpcClient = new moq::Mock<CloudRedis.CloudRedisClient>(moq::MockBehavior.Strict);
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
                LocationId = "location_iddaa574e2",
                AlternativeLocationId = "alternative_location_id9b86fe18",
                RedisVersion = "redis_version52f1f9d8",
                ReservedIpRange = "reserved_ip_range779ab299",
                Host = "hosta8dbb367",
                Port = -78310000,
                CurrentLocationId = "current_location_id65ef644c",
                CreateTime = new wkt::Timestamp(),
                State = Instance.Types.State.Updating,
                StatusMessage = "status_message2c618f86",
                RedisConfigs =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Tier = Instance.Types.Tier.Basic,
                MemorySizeGb = 863378110,
                AuthorizedNetwork = "authorized_network63563381",
                PersistenceIamIdentity = "persistence_iam_identitye8d96e46",
                ConnectMode = Instance.Types.ConnectMode.Unspecified,
                AuthEnabled = false,
                ServerCaCerts =
                {
                    new TlsCertificate(),
                },
                TransitEncryptionMode = Instance.Types.TransitEncryptionMode.Disabled,
                MaintenancePolicy = new MaintenancePolicy(),
                MaintenanceSchedule = new MaintenanceSchedule(),
                ReplicaCount = -2132170114,
                Nodes = { new NodeInfo(), },
                ReadEndpoint = "read_endpointb6c6d0a1",
                ReadEndpointPort = 906869138,
                ReadReplicasMode = Instance.Types.ReadReplicasMode.ReadReplicasEnabled,
            };
            mockGrpcClient.Setup(x => x.GetInstanceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Instance>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudRedisClient client = new CloudRedisClientImpl(mockGrpcClient.Object, null);
            Instance responseCallSettings = await client.GetInstanceAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Instance responseCancellationToken = await client.GetInstanceAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetInstanceResourceNames()
        {
            moq::Mock<CloudRedis.CloudRedisClient> mockGrpcClient = new moq::Mock<CloudRedis.CloudRedisClient>(moq::MockBehavior.Strict);
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
                LocationId = "location_iddaa574e2",
                AlternativeLocationId = "alternative_location_id9b86fe18",
                RedisVersion = "redis_version52f1f9d8",
                ReservedIpRange = "reserved_ip_range779ab299",
                Host = "hosta8dbb367",
                Port = -78310000,
                CurrentLocationId = "current_location_id65ef644c",
                CreateTime = new wkt::Timestamp(),
                State = Instance.Types.State.Updating,
                StatusMessage = "status_message2c618f86",
                RedisConfigs =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Tier = Instance.Types.Tier.Basic,
                MemorySizeGb = 863378110,
                AuthorizedNetwork = "authorized_network63563381",
                PersistenceIamIdentity = "persistence_iam_identitye8d96e46",
                ConnectMode = Instance.Types.ConnectMode.Unspecified,
                AuthEnabled = false,
                ServerCaCerts =
                {
                    new TlsCertificate(),
                },
                TransitEncryptionMode = Instance.Types.TransitEncryptionMode.Disabled,
                MaintenancePolicy = new MaintenancePolicy(),
                MaintenanceSchedule = new MaintenanceSchedule(),
                ReplicaCount = -2132170114,
                Nodes = { new NodeInfo(), },
                ReadEndpoint = "read_endpointb6c6d0a1",
                ReadEndpointPort = 906869138,
                ReadReplicasMode = Instance.Types.ReadReplicasMode.ReadReplicasEnabled,
            };
            mockGrpcClient.Setup(x => x.GetInstance(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudRedisClient client = new CloudRedisClientImpl(mockGrpcClient.Object, null);
            Instance response = client.GetInstance(request.InstanceName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetInstanceResourceNamesAsync()
        {
            moq::Mock<CloudRedis.CloudRedisClient> mockGrpcClient = new moq::Mock<CloudRedis.CloudRedisClient>(moq::MockBehavior.Strict);
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
                LocationId = "location_iddaa574e2",
                AlternativeLocationId = "alternative_location_id9b86fe18",
                RedisVersion = "redis_version52f1f9d8",
                ReservedIpRange = "reserved_ip_range779ab299",
                Host = "hosta8dbb367",
                Port = -78310000,
                CurrentLocationId = "current_location_id65ef644c",
                CreateTime = new wkt::Timestamp(),
                State = Instance.Types.State.Updating,
                StatusMessage = "status_message2c618f86",
                RedisConfigs =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Tier = Instance.Types.Tier.Basic,
                MemorySizeGb = 863378110,
                AuthorizedNetwork = "authorized_network63563381",
                PersistenceIamIdentity = "persistence_iam_identitye8d96e46",
                ConnectMode = Instance.Types.ConnectMode.Unspecified,
                AuthEnabled = false,
                ServerCaCerts =
                {
                    new TlsCertificate(),
                },
                TransitEncryptionMode = Instance.Types.TransitEncryptionMode.Disabled,
                MaintenancePolicy = new MaintenancePolicy(),
                MaintenanceSchedule = new MaintenanceSchedule(),
                ReplicaCount = -2132170114,
                Nodes = { new NodeInfo(), },
                ReadEndpoint = "read_endpointb6c6d0a1",
                ReadEndpointPort = 906869138,
                ReadReplicasMode = Instance.Types.ReadReplicasMode.ReadReplicasEnabled,
            };
            mockGrpcClient.Setup(x => x.GetInstanceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Instance>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudRedisClient client = new CloudRedisClientImpl(mockGrpcClient.Object, null);
            Instance responseCallSettings = await client.GetInstanceAsync(request.InstanceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Instance responseCancellationToken = await client.GetInstanceAsync(request.InstanceName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetInstanceAuthStringRequestObject()
        {
            moq::Mock<CloudRedis.CloudRedisClient> mockGrpcClient = new moq::Mock<CloudRedis.CloudRedisClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetInstanceAuthStringRequest request = new GetInstanceAuthStringRequest
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
            };
            InstanceAuthString expectedResponse = new InstanceAuthString
            {
                AuthString = "auth_string7b7a4b11",
            };
            mockGrpcClient.Setup(x => x.GetInstanceAuthString(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudRedisClient client = new CloudRedisClientImpl(mockGrpcClient.Object, null);
            InstanceAuthString response = client.GetInstanceAuthString(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetInstanceAuthStringRequestObjectAsync()
        {
            moq::Mock<CloudRedis.CloudRedisClient> mockGrpcClient = new moq::Mock<CloudRedis.CloudRedisClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetInstanceAuthStringRequest request = new GetInstanceAuthStringRequest
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
            };
            InstanceAuthString expectedResponse = new InstanceAuthString
            {
                AuthString = "auth_string7b7a4b11",
            };
            mockGrpcClient.Setup(x => x.GetInstanceAuthStringAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<InstanceAuthString>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudRedisClient client = new CloudRedisClientImpl(mockGrpcClient.Object, null);
            InstanceAuthString responseCallSettings = await client.GetInstanceAuthStringAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            InstanceAuthString responseCancellationToken = await client.GetInstanceAuthStringAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetInstanceAuthString()
        {
            moq::Mock<CloudRedis.CloudRedisClient> mockGrpcClient = new moq::Mock<CloudRedis.CloudRedisClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetInstanceAuthStringRequest request = new GetInstanceAuthStringRequest
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
            };
            InstanceAuthString expectedResponse = new InstanceAuthString
            {
                AuthString = "auth_string7b7a4b11",
            };
            mockGrpcClient.Setup(x => x.GetInstanceAuthString(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudRedisClient client = new CloudRedisClientImpl(mockGrpcClient.Object, null);
            InstanceAuthString response = client.GetInstanceAuthString(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetInstanceAuthStringAsync()
        {
            moq::Mock<CloudRedis.CloudRedisClient> mockGrpcClient = new moq::Mock<CloudRedis.CloudRedisClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetInstanceAuthStringRequest request = new GetInstanceAuthStringRequest
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
            };
            InstanceAuthString expectedResponse = new InstanceAuthString
            {
                AuthString = "auth_string7b7a4b11",
            };
            mockGrpcClient.Setup(x => x.GetInstanceAuthStringAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<InstanceAuthString>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudRedisClient client = new CloudRedisClientImpl(mockGrpcClient.Object, null);
            InstanceAuthString responseCallSettings = await client.GetInstanceAuthStringAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            InstanceAuthString responseCancellationToken = await client.GetInstanceAuthStringAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetInstanceAuthStringResourceNames()
        {
            moq::Mock<CloudRedis.CloudRedisClient> mockGrpcClient = new moq::Mock<CloudRedis.CloudRedisClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetInstanceAuthStringRequest request = new GetInstanceAuthStringRequest
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
            };
            InstanceAuthString expectedResponse = new InstanceAuthString
            {
                AuthString = "auth_string7b7a4b11",
            };
            mockGrpcClient.Setup(x => x.GetInstanceAuthString(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudRedisClient client = new CloudRedisClientImpl(mockGrpcClient.Object, null);
            InstanceAuthString response = client.GetInstanceAuthString(request.InstanceName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetInstanceAuthStringResourceNamesAsync()
        {
            moq::Mock<CloudRedis.CloudRedisClient> mockGrpcClient = new moq::Mock<CloudRedis.CloudRedisClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetInstanceAuthStringRequest request = new GetInstanceAuthStringRequest
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
            };
            InstanceAuthString expectedResponse = new InstanceAuthString
            {
                AuthString = "auth_string7b7a4b11",
            };
            mockGrpcClient.Setup(x => x.GetInstanceAuthStringAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<InstanceAuthString>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudRedisClient client = new CloudRedisClientImpl(mockGrpcClient.Object, null);
            InstanceAuthString responseCallSettings = await client.GetInstanceAuthStringAsync(request.InstanceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            InstanceAuthString responseCancellationToken = await client.GetInstanceAuthStringAsync(request.InstanceName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
