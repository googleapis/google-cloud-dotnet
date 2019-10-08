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

namespace Google.Cloud.Bigtable.Admin.V2.Tests
{
    using Google.Api.Gax;
    using Google.Api.Gax.Grpc;
    using Google.Api.Gax.ResourceNames;
    using apis = Google.Cloud.Bigtable.Admin.V2;
    using Google.Cloud.Iam.V1;
    using Google.LongRunning;
    using Google.Protobuf;
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
    public class GeneratedBigtableInstanceAdminClientTest
    {
        [Fact]
        public void GetInstance()
        {
            Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetInstanceRequest expectedRequest = new GetInstanceRequest
            {
                InstanceName = new InstanceName("[PROJECT]", "[INSTANCE]"),
            };
            Instance expectedResponse = new Instance
            {
                InstanceName = new InstanceName("[PROJECT]", "[INSTANCE]"),
                DisplayName = "displayName1615086568",
            };
            mockGrpcClient.Setup(x => x.GetInstance(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            InstanceName name = new InstanceName("[PROJECT]", "[INSTANCE]");
            Instance response = client.GetInstance(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetInstanceAsync()
        {
            Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetInstanceRequest expectedRequest = new GetInstanceRequest
            {
                InstanceName = new InstanceName("[PROJECT]", "[INSTANCE]"),
            };
            Instance expectedResponse = new Instance
            {
                InstanceName = new InstanceName("[PROJECT]", "[INSTANCE]"),
                DisplayName = "displayName1615086568",
            };
            mockGrpcClient.Setup(x => x.GetInstanceAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Instance>(Task.FromResult(expectedResponse), null, null, null, null));
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            InstanceName name = new InstanceName("[PROJECT]", "[INSTANCE]");
            Instance response = await client.GetInstanceAsync(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetInstance2()
        {
            Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetInstanceRequest request = new GetInstanceRequest
            {
                InstanceName = new InstanceName("[PROJECT]", "[INSTANCE]"),
            };
            Instance expectedResponse = new Instance
            {
                InstanceName = new InstanceName("[PROJECT]", "[INSTANCE]"),
                DisplayName = "displayName1615086568",
            };
            mockGrpcClient.Setup(x => x.GetInstance(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            Instance response = client.GetInstance(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetInstanceAsync2()
        {
            Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetInstanceRequest request = new GetInstanceRequest
            {
                InstanceName = new InstanceName("[PROJECT]", "[INSTANCE]"),
            };
            Instance expectedResponse = new Instance
            {
                InstanceName = new InstanceName("[PROJECT]", "[INSTANCE]"),
                DisplayName = "displayName1615086568",
            };
            mockGrpcClient.Setup(x => x.GetInstanceAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Instance>(Task.FromResult(expectedResponse), null, null, null, null));
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            Instance response = await client.GetInstanceAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void ListInstances()
        {
            Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            ListInstancesRequest expectedRequest = new ListInstancesRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
            };
            ListInstancesResponse expectedResponse = new ListInstancesResponse
            {
                NextPageToken = "nextPageToken-1530815211",
            };
            mockGrpcClient.Setup(x => x.ListInstances(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            ProjectName parent = new ProjectName("[PROJECT]");
            ListInstancesResponse response = client.ListInstances(parent);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task ListInstancesAsync()
        {
            Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            ListInstancesRequest expectedRequest = new ListInstancesRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
            };
            ListInstancesResponse expectedResponse = new ListInstancesResponse
            {
                NextPageToken = "nextPageToken-1530815211",
            };
            mockGrpcClient.Setup(x => x.ListInstancesAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ListInstancesResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            ProjectName parent = new ProjectName("[PROJECT]");
            ListInstancesResponse response = await client.ListInstancesAsync(parent);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void ListInstances2()
        {
            Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            ListInstancesRequest request = new ListInstancesRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
            };
            ListInstancesResponse expectedResponse = new ListInstancesResponse
            {
                NextPageToken = "nextPageToken-1530815211",
            };
            mockGrpcClient.Setup(x => x.ListInstances(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            ListInstancesResponse response = client.ListInstances(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task ListInstancesAsync2()
        {
            Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            ListInstancesRequest request = new ListInstancesRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
            };
            ListInstancesResponse expectedResponse = new ListInstancesResponse
            {
                NextPageToken = "nextPageToken-1530815211",
            };
            mockGrpcClient.Setup(x => x.ListInstancesAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ListInstancesResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            ListInstancesResponse response = await client.ListInstancesAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteInstance()
        {
            Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            DeleteInstanceRequest expectedRequest = new DeleteInstanceRequest
            {
                InstanceName = new InstanceName("[PROJECT]", "[INSTANCE]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteInstance(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            InstanceName name = new InstanceName("[PROJECT]", "[INSTANCE]");
            client.DeleteInstance(name);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteInstanceAsync()
        {
            Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            DeleteInstanceRequest expectedRequest = new DeleteInstanceRequest
            {
                InstanceName = new InstanceName("[PROJECT]", "[INSTANCE]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteInstanceAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            InstanceName name = new InstanceName("[PROJECT]", "[INSTANCE]");
            await client.DeleteInstanceAsync(name);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteInstance2()
        {
            Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            DeleteInstanceRequest request = new DeleteInstanceRequest
            {
                InstanceName = new InstanceName("[PROJECT]", "[INSTANCE]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteInstance(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            client.DeleteInstance(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteInstanceAsync2()
        {
            Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            DeleteInstanceRequest request = new DeleteInstanceRequest
            {
                InstanceName = new InstanceName("[PROJECT]", "[INSTANCE]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteInstanceAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            await client.DeleteInstanceAsync(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetCluster()
        {
            Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetClusterRequest expectedRequest = new GetClusterRequest
            {
                ClusterName = new ClusterName("[PROJECT]", "[INSTANCE]", "[CLUSTER]"),
            };
            Cluster expectedResponse = new Cluster
            {
                ClusterName = new ClusterName("[PROJECT]", "[INSTANCE]", "[CLUSTER]"),
                LocationAsLocationName = new V2.LocationName("[PROJECT]", "[LOCATION]"),
                ServeNodes = 1288838783,
            };
            mockGrpcClient.Setup(x => x.GetCluster(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            ClusterName name = new ClusterName("[PROJECT]", "[INSTANCE]", "[CLUSTER]");
            Cluster response = client.GetCluster(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetClusterAsync()
        {
            Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetClusterRequest expectedRequest = new GetClusterRequest
            {
                ClusterName = new ClusterName("[PROJECT]", "[INSTANCE]", "[CLUSTER]"),
            };
            Cluster expectedResponse = new Cluster
            {
                ClusterName = new ClusterName("[PROJECT]", "[INSTANCE]", "[CLUSTER]"),
                LocationAsLocationName = new V2.LocationName("[PROJECT]", "[LOCATION]"),
                ServeNodes = 1288838783,
            };
            mockGrpcClient.Setup(x => x.GetClusterAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Cluster>(Task.FromResult(expectedResponse), null, null, null, null));
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            ClusterName name = new ClusterName("[PROJECT]", "[INSTANCE]", "[CLUSTER]");
            Cluster response = await client.GetClusterAsync(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetCluster2()
        {
            Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetClusterRequest request = new GetClusterRequest
            {
                ClusterName = new ClusterName("[PROJECT]", "[INSTANCE]", "[CLUSTER]"),
            };
            Cluster expectedResponse = new Cluster
            {
                ClusterName = new ClusterName("[PROJECT]", "[INSTANCE]", "[CLUSTER]"),
                LocationAsLocationName = new V2.LocationName("[PROJECT]", "[LOCATION]"),
                ServeNodes = 1288838783,
            };
            mockGrpcClient.Setup(x => x.GetCluster(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            Cluster response = client.GetCluster(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetClusterAsync2()
        {
            Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetClusterRequest request = new GetClusterRequest
            {
                ClusterName = new ClusterName("[PROJECT]", "[INSTANCE]", "[CLUSTER]"),
            };
            Cluster expectedResponse = new Cluster
            {
                ClusterName = new ClusterName("[PROJECT]", "[INSTANCE]", "[CLUSTER]"),
                LocationAsLocationName = new V2.LocationName("[PROJECT]", "[LOCATION]"),
                ServeNodes = 1288838783,
            };
            mockGrpcClient.Setup(x => x.GetClusterAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Cluster>(Task.FromResult(expectedResponse), null, null, null, null));
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            Cluster response = await client.GetClusterAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void ListClusters()
        {
            Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            ListClustersRequest expectedRequest = new ListClustersRequest
            {
                ParentAsInstanceName = new InstanceName("[PROJECT]", "[INSTANCE]"),
            };
            ListClustersResponse expectedResponse = new ListClustersResponse
            {
                NextPageToken = "nextPageToken-1530815211",
            };
            mockGrpcClient.Setup(x => x.ListClusters(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            InstanceName parent = new InstanceName("[PROJECT]", "[INSTANCE]");
            ListClustersResponse response = client.ListClusters(parent);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task ListClustersAsync()
        {
            Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            ListClustersRequest expectedRequest = new ListClustersRequest
            {
                ParentAsInstanceName = new InstanceName("[PROJECT]", "[INSTANCE]"),
            };
            ListClustersResponse expectedResponse = new ListClustersResponse
            {
                NextPageToken = "nextPageToken-1530815211",
            };
            mockGrpcClient.Setup(x => x.ListClustersAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ListClustersResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            InstanceName parent = new InstanceName("[PROJECT]", "[INSTANCE]");
            ListClustersResponse response = await client.ListClustersAsync(parent);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void ListClusters2()
        {
            Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            ListClustersRequest request = new ListClustersRequest
            {
                ParentAsInstanceName = new InstanceName("[PROJECT]", "[INSTANCE]"),
            };
            ListClustersResponse expectedResponse = new ListClustersResponse
            {
                NextPageToken = "nextPageToken-1530815211",
            };
            mockGrpcClient.Setup(x => x.ListClusters(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            ListClustersResponse response = client.ListClusters(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task ListClustersAsync2()
        {
            Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            ListClustersRequest request = new ListClustersRequest
            {
                ParentAsInstanceName = new InstanceName("[PROJECT]", "[INSTANCE]"),
            };
            ListClustersResponse expectedResponse = new ListClustersResponse
            {
                NextPageToken = "nextPageToken-1530815211",
            };
            mockGrpcClient.Setup(x => x.ListClustersAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ListClustersResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            ListClustersResponse response = await client.ListClustersAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteCluster()
        {
            Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            DeleteClusterRequest expectedRequest = new DeleteClusterRequest
            {
                ClusterName = new ClusterName("[PROJECT]", "[INSTANCE]", "[CLUSTER]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteCluster(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            ClusterName name = new ClusterName("[PROJECT]", "[INSTANCE]", "[CLUSTER]");
            client.DeleteCluster(name);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteClusterAsync()
        {
            Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            DeleteClusterRequest expectedRequest = new DeleteClusterRequest
            {
                ClusterName = new ClusterName("[PROJECT]", "[INSTANCE]", "[CLUSTER]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteClusterAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            ClusterName name = new ClusterName("[PROJECT]", "[INSTANCE]", "[CLUSTER]");
            await client.DeleteClusterAsync(name);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteCluster2()
        {
            Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            DeleteClusterRequest request = new DeleteClusterRequest
            {
                ClusterName = new ClusterName("[PROJECT]", "[INSTANCE]", "[CLUSTER]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteCluster(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            client.DeleteCluster(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteClusterAsync2()
        {
            Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            DeleteClusterRequest request = new DeleteClusterRequest
            {
                ClusterName = new ClusterName("[PROJECT]", "[INSTANCE]", "[CLUSTER]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteClusterAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            await client.DeleteClusterAsync(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateAppProfile()
        {
            Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            CreateAppProfileRequest expectedRequest = new CreateAppProfileRequest
            {
                ParentAsInstanceName = new InstanceName("[PROJECT]", "[INSTANCE]"),
                AppProfileId = "appProfileId1262094415",
                AppProfile = new AppProfile(),
            };
            AppProfile expectedResponse = new AppProfile
            {
                Name = "name3373707",
                Etag = "etag3123477",
                Description = "description-1724546052",
            };
            mockGrpcClient.Setup(x => x.CreateAppProfile(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            InstanceName parent = new InstanceName("[PROJECT]", "[INSTANCE]");
            string appProfileId = "appProfileId1262094415";
            AppProfile appProfile = new AppProfile();
            AppProfile response = client.CreateAppProfile(parent, appProfileId, appProfile);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateAppProfileAsync()
        {
            Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            CreateAppProfileRequest expectedRequest = new CreateAppProfileRequest
            {
                ParentAsInstanceName = new InstanceName("[PROJECT]", "[INSTANCE]"),
                AppProfileId = "appProfileId1262094415",
                AppProfile = new AppProfile(),
            };
            AppProfile expectedResponse = new AppProfile
            {
                Name = "name3373707",
                Etag = "etag3123477",
                Description = "description-1724546052",
            };
            mockGrpcClient.Setup(x => x.CreateAppProfileAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<AppProfile>(Task.FromResult(expectedResponse), null, null, null, null));
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            InstanceName parent = new InstanceName("[PROJECT]", "[INSTANCE]");
            string appProfileId = "appProfileId1262094415";
            AppProfile appProfile = new AppProfile();
            AppProfile response = await client.CreateAppProfileAsync(parent, appProfileId, appProfile);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateAppProfile2()
        {
            Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            CreateAppProfileRequest request = new CreateAppProfileRequest
            {
                ParentAsInstanceName = new InstanceName("[PROJECT]", "[INSTANCE]"),
                AppProfileId = "appProfileId1262094415",
                AppProfile = new AppProfile(),
            };
            AppProfile expectedResponse = new AppProfile
            {
                Name = "name3373707",
                Etag = "etag3123477",
                Description = "description-1724546052",
            };
            mockGrpcClient.Setup(x => x.CreateAppProfile(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            AppProfile response = client.CreateAppProfile(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateAppProfileAsync2()
        {
            Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            CreateAppProfileRequest request = new CreateAppProfileRequest
            {
                ParentAsInstanceName = new InstanceName("[PROJECT]", "[INSTANCE]"),
                AppProfileId = "appProfileId1262094415",
                AppProfile = new AppProfile(),
            };
            AppProfile expectedResponse = new AppProfile
            {
                Name = "name3373707",
                Etag = "etag3123477",
                Description = "description-1724546052",
            };
            mockGrpcClient.Setup(x => x.CreateAppProfileAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<AppProfile>(Task.FromResult(expectedResponse), null, null, null, null));
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            AppProfile response = await client.CreateAppProfileAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetAppProfile()
        {
            Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetAppProfileRequest expectedRequest = new GetAppProfileRequest
            {
                AppProfileName = new AppProfileName("[PROJECT]", "[INSTANCE]", "[APP_PROFILE]"),
            };
            AppProfile expectedResponse = new AppProfile
            {
                Name = "name2-1052831874",
                Etag = "etag3123477",
                Description = "description-1724546052",
            };
            mockGrpcClient.Setup(x => x.GetAppProfile(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            AppProfileName name = new AppProfileName("[PROJECT]", "[INSTANCE]", "[APP_PROFILE]");
            AppProfile response = client.GetAppProfile(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetAppProfileAsync()
        {
            Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetAppProfileRequest expectedRequest = new GetAppProfileRequest
            {
                AppProfileName = new AppProfileName("[PROJECT]", "[INSTANCE]", "[APP_PROFILE]"),
            };
            AppProfile expectedResponse = new AppProfile
            {
                Name = "name2-1052831874",
                Etag = "etag3123477",
                Description = "description-1724546052",
            };
            mockGrpcClient.Setup(x => x.GetAppProfileAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<AppProfile>(Task.FromResult(expectedResponse), null, null, null, null));
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            AppProfileName name = new AppProfileName("[PROJECT]", "[INSTANCE]", "[APP_PROFILE]");
            AppProfile response = await client.GetAppProfileAsync(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetAppProfile2()
        {
            Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetAppProfileRequest request = new GetAppProfileRequest
            {
                AppProfileName = new AppProfileName("[PROJECT]", "[INSTANCE]", "[APP_PROFILE]"),
            };
            AppProfile expectedResponse = new AppProfile
            {
                Name = "name2-1052831874",
                Etag = "etag3123477",
                Description = "description-1724546052",
            };
            mockGrpcClient.Setup(x => x.GetAppProfile(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            AppProfile response = client.GetAppProfile(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetAppProfileAsync2()
        {
            Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetAppProfileRequest request = new GetAppProfileRequest
            {
                AppProfileName = new AppProfileName("[PROJECT]", "[INSTANCE]", "[APP_PROFILE]"),
            };
            AppProfile expectedResponse = new AppProfile
            {
                Name = "name2-1052831874",
                Etag = "etag3123477",
                Description = "description-1724546052",
            };
            mockGrpcClient.Setup(x => x.GetAppProfileAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<AppProfile>(Task.FromResult(expectedResponse), null, null, null, null));
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            AppProfile response = await client.GetAppProfileAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteAppProfile()
        {
            Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            DeleteAppProfileRequest expectedRequest = new DeleteAppProfileRequest
            {
                AppProfileName = new AppProfileName("[PROJECT]", "[INSTANCE]", "[APP_PROFILE]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteAppProfile(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            AppProfileName name = new AppProfileName("[PROJECT]", "[INSTANCE]", "[APP_PROFILE]");
            client.DeleteAppProfile(name);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteAppProfileAsync()
        {
            Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            DeleteAppProfileRequest expectedRequest = new DeleteAppProfileRequest
            {
                AppProfileName = new AppProfileName("[PROJECT]", "[INSTANCE]", "[APP_PROFILE]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteAppProfileAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            AppProfileName name = new AppProfileName("[PROJECT]", "[INSTANCE]", "[APP_PROFILE]");
            await client.DeleteAppProfileAsync(name);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteAppProfile2()
        {
            Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            DeleteAppProfileRequest request = new DeleteAppProfileRequest
            {
                AppProfileName = new AppProfileName("[PROJECT]", "[INSTANCE]", "[APP_PROFILE]"),
                IgnoreWarnings = true,
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteAppProfile(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            client.DeleteAppProfile(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteAppProfileAsync2()
        {
            Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            DeleteAppProfileRequest request = new DeleteAppProfileRequest
            {
                AppProfileName = new AppProfileName("[PROJECT]", "[INSTANCE]", "[APP_PROFILE]"),
                IgnoreWarnings = true,
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteAppProfileAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            await client.DeleteAppProfileAsync(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetIamPolicy()
        {
            Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetIamPolicyRequest expectedRequest = new GetIamPolicyRequest
            {
                Resource = new InstanceName("[PROJECT]", "[INSTANCE]").ToString(),
            };
            Policy expectedResponse = new Policy
            {
                Version = 351608024,
                Etag = ByteString.CopyFromUtf8("etag3123477"),
            };
            mockGrpcClient.Setup(x => x.GetIamPolicy(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            string formattedResource = new InstanceName("[PROJECT]", "[INSTANCE]").ToString();
            Policy response = client.GetIamPolicy(formattedResource);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetIamPolicyAsync()
        {
            Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetIamPolicyRequest expectedRequest = new GetIamPolicyRequest
            {
                Resource = new InstanceName("[PROJECT]", "[INSTANCE]").ToString(),
            };
            Policy expectedResponse = new Policy
            {
                Version = 351608024,
                Etag = ByteString.CopyFromUtf8("etag3123477"),
            };
            mockGrpcClient.Setup(x => x.GetIamPolicyAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Policy>(Task.FromResult(expectedResponse), null, null, null, null));
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            string formattedResource = new InstanceName("[PROJECT]", "[INSTANCE]").ToString();
            Policy response = await client.GetIamPolicyAsync(formattedResource);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetIamPolicy2()
        {
            Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                Resource = new InstanceName("[PROJECT]", "[INSTANCE]").ToString(),
            };
            Policy expectedResponse = new Policy
            {
                Version = 351608024,
                Etag = ByteString.CopyFromUtf8("etag3123477"),
            };
            mockGrpcClient.Setup(x => x.GetIamPolicy(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            Policy response = client.GetIamPolicy(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetIamPolicyAsync2()
        {
            Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                Resource = new InstanceName("[PROJECT]", "[INSTANCE]").ToString(),
            };
            Policy expectedResponse = new Policy
            {
                Version = 351608024,
                Etag = ByteString.CopyFromUtf8("etag3123477"),
            };
            mockGrpcClient.Setup(x => x.GetIamPolicyAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Policy>(Task.FromResult(expectedResponse), null, null, null, null));
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            Policy response = await client.GetIamPolicyAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void SetIamPolicy()
        {
            Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            SetIamPolicyRequest expectedRequest = new SetIamPolicyRequest
            {
                Resource = new InstanceName("[PROJECT]", "[INSTANCE]").ToString(),
                Policy = new Policy(),
            };
            Policy expectedResponse = new Policy
            {
                Version = 351608024,
                Etag = ByteString.CopyFromUtf8("etag3123477"),
            };
            mockGrpcClient.Setup(x => x.SetIamPolicy(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            string formattedResource = new InstanceName("[PROJECT]", "[INSTANCE]").ToString();
            Policy policy = new Policy();
            Policy response = client.SetIamPolicy(formattedResource, policy);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task SetIamPolicyAsync()
        {
            Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            SetIamPolicyRequest expectedRequest = new SetIamPolicyRequest
            {
                Resource = new InstanceName("[PROJECT]", "[INSTANCE]").ToString(),
                Policy = new Policy(),
            };
            Policy expectedResponse = new Policy
            {
                Version = 351608024,
                Etag = ByteString.CopyFromUtf8("etag3123477"),
            };
            mockGrpcClient.Setup(x => x.SetIamPolicyAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Policy>(Task.FromResult(expectedResponse), null, null, null, null));
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            string formattedResource = new InstanceName("[PROJECT]", "[INSTANCE]").ToString();
            Policy policy = new Policy();
            Policy response = await client.SetIamPolicyAsync(formattedResource, policy);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void SetIamPolicy2()
        {
            Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                Resource = new InstanceName("[PROJECT]", "[INSTANCE]").ToString(),
                Policy = new Policy(),
            };
            Policy expectedResponse = new Policy
            {
                Version = 351608024,
                Etag = ByteString.CopyFromUtf8("etag3123477"),
            };
            mockGrpcClient.Setup(x => x.SetIamPolicy(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            Policy response = client.SetIamPolicy(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task SetIamPolicyAsync2()
        {
            Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                Resource = new InstanceName("[PROJECT]", "[INSTANCE]").ToString(),
                Policy = new Policy(),
            };
            Policy expectedResponse = new Policy
            {
                Version = 351608024,
                Etag = ByteString.CopyFromUtf8("etag3123477"),
            };
            mockGrpcClient.Setup(x => x.SetIamPolicyAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Policy>(Task.FromResult(expectedResponse), null, null, null, null));
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            Policy response = await client.SetIamPolicyAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void TestIamPermissions()
        {
            Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            TestIamPermissionsRequest expectedRequest = new TestIamPermissionsRequest
            {
                Resource = new InstanceName("[PROJECT]", "[INSTANCE]").ToString(),
                Permissions = { },
            };
            TestIamPermissionsResponse expectedResponse = new TestIamPermissionsResponse();
            mockGrpcClient.Setup(x => x.TestIamPermissions(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            string formattedResource = new InstanceName("[PROJECT]", "[INSTANCE]").ToString();
            IEnumerable<string> permissions = new List<string>();
            TestIamPermissionsResponse response = client.TestIamPermissions(formattedResource, permissions);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task TestIamPermissionsAsync()
        {
            Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            TestIamPermissionsRequest expectedRequest = new TestIamPermissionsRequest
            {
                Resource = new InstanceName("[PROJECT]", "[INSTANCE]").ToString(),
                Permissions = { },
            };
            TestIamPermissionsResponse expectedResponse = new TestIamPermissionsResponse();
            mockGrpcClient.Setup(x => x.TestIamPermissionsAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<TestIamPermissionsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            string formattedResource = new InstanceName("[PROJECT]", "[INSTANCE]").ToString();
            IEnumerable<string> permissions = new List<string>();
            TestIamPermissionsResponse response = await client.TestIamPermissionsAsync(formattedResource, permissions);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void TestIamPermissions2()
        {
            Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                Resource = new InstanceName("[PROJECT]", "[INSTANCE]").ToString(),
                Permissions = { },
            };
            TestIamPermissionsResponse expectedResponse = new TestIamPermissionsResponse();
            mockGrpcClient.Setup(x => x.TestIamPermissions(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            TestIamPermissionsResponse response = client.TestIamPermissions(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task TestIamPermissionsAsync2()
        {
            Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                Resource = new InstanceName("[PROJECT]", "[INSTANCE]").ToString(),
                Permissions = { },
            };
            TestIamPermissionsResponse expectedResponse = new TestIamPermissionsResponse();
            mockGrpcClient.Setup(x => x.TestIamPermissionsAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<TestIamPermissionsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            TestIamPermissionsResponse response = await client.TestIamPermissionsAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}
