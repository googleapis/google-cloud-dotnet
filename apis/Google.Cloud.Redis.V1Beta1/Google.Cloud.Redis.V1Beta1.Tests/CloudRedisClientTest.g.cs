// Copyright 2019 Google LLC
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

namespace Google.Cloud.Redis.V1Beta1.Tests
{
    using Google.Api.Gax;
    using Google.Api.Gax.Grpc;
    using apis = Google.Cloud.Redis.V1Beta1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using Grpc.Core;
    using Moq;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Threading;
    using System.Threading.Tasks;
    using Xunit;

    /// <summary>Generated unit tests</summary>
    public class GeneratedCloudRedisClientTest
    {
        [Fact]
        public void GetInstance()
        {
            Mock<CloudRedis.CloudRedisClient> mockGrpcClient = new Mock<CloudRedis.CloudRedisClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetInstanceRequest expectedRequest = new GetInstanceRequest
            {
                InstanceName = new InstanceName("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
            };
            Instance expectedResponse = new Instance
            {
                Name = "name2-1052831874",
                DisplayName = "displayName1615086568",
                LocationId = "locationId552319461",
                AlternativeLocationId = "alternativeLocationId-718920621",
                RedisVersion = "redisVersion-685310444",
                ReservedIpRange = "reservedIpRange-1082940580",
                Host = "host3208616",
                Port = 3446913,
                CurrentLocationId = "currentLocationId1312712735",
                StatusMessage = "statusMessage-239442758",
                MemorySizeGb = 34199707,
                AuthorizedNetwork = "authorizedNetwork-1733809270",
                PersistenceIamIdentity = "persistenceIamIdentity1061944584",
            };
            mockGrpcClient.Setup(x => x.GetInstance(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CloudRedisClient client = new CloudRedisClientImpl(mockGrpcClient.Object, null);
            InstanceName name = new InstanceName("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            Instance response = client.GetInstance(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetInstanceAsync()
        {
            Mock<CloudRedis.CloudRedisClient> mockGrpcClient = new Mock<CloudRedis.CloudRedisClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetInstanceRequest expectedRequest = new GetInstanceRequest
            {
                InstanceName = new InstanceName("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
            };
            Instance expectedResponse = new Instance
            {
                Name = "name2-1052831874",
                DisplayName = "displayName1615086568",
                LocationId = "locationId552319461",
                AlternativeLocationId = "alternativeLocationId-718920621",
                RedisVersion = "redisVersion-685310444",
                ReservedIpRange = "reservedIpRange-1082940580",
                Host = "host3208616",
                Port = 3446913,
                CurrentLocationId = "currentLocationId1312712735",
                StatusMessage = "statusMessage-239442758",
                MemorySizeGb = 34199707,
                AuthorizedNetwork = "authorizedNetwork-1733809270",
                PersistenceIamIdentity = "persistenceIamIdentity1061944584",
            };
            mockGrpcClient.Setup(x => x.GetInstanceAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Instance>(Task.FromResult(expectedResponse), null, null, null, null));
            CloudRedisClient client = new CloudRedisClientImpl(mockGrpcClient.Object, null);
            InstanceName name = new InstanceName("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            Instance response = await client.GetInstanceAsync(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetInstance2()
        {
            Mock<CloudRedis.CloudRedisClient> mockGrpcClient = new Mock<CloudRedis.CloudRedisClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetInstanceRequest request = new GetInstanceRequest
            {
                InstanceName = new InstanceName("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
            };
            Instance expectedResponse = new Instance
            {
                Name = "name2-1052831874",
                DisplayName = "displayName1615086568",
                LocationId = "locationId552319461",
                AlternativeLocationId = "alternativeLocationId-718920621",
                RedisVersion = "redisVersion-685310444",
                ReservedIpRange = "reservedIpRange-1082940580",
                Host = "host3208616",
                Port = 3446913,
                CurrentLocationId = "currentLocationId1312712735",
                StatusMessage = "statusMessage-239442758",
                MemorySizeGb = 34199707,
                AuthorizedNetwork = "authorizedNetwork-1733809270",
                PersistenceIamIdentity = "persistenceIamIdentity1061944584",
            };
            mockGrpcClient.Setup(x => x.GetInstance(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CloudRedisClient client = new CloudRedisClientImpl(mockGrpcClient.Object, null);
            Instance response = client.GetInstance(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetInstanceAsync2()
        {
            Mock<CloudRedis.CloudRedisClient> mockGrpcClient = new Mock<CloudRedis.CloudRedisClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetInstanceRequest request = new GetInstanceRequest
            {
                InstanceName = new InstanceName("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
            };
            Instance expectedResponse = new Instance
            {
                Name = "name2-1052831874",
                DisplayName = "displayName1615086568",
                LocationId = "locationId552319461",
                AlternativeLocationId = "alternativeLocationId-718920621",
                RedisVersion = "redisVersion-685310444",
                ReservedIpRange = "reservedIpRange-1082940580",
                Host = "host3208616",
                Port = 3446913,
                CurrentLocationId = "currentLocationId1312712735",
                StatusMessage = "statusMessage-239442758",
                MemorySizeGb = 34199707,
                AuthorizedNetwork = "authorizedNetwork-1733809270",
                PersistenceIamIdentity = "persistenceIamIdentity1061944584",
            };
            mockGrpcClient.Setup(x => x.GetInstanceAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Instance>(Task.FromResult(expectedResponse), null, null, null, null));
            CloudRedisClient client = new CloudRedisClientImpl(mockGrpcClient.Object, null);
            Instance response = await client.GetInstanceAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}
