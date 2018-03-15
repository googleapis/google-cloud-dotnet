// Copyright 2018 Google LLC
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

using Google.Api.Gax;
using Google.Api.Gax.Grpc;
using Google.Cloud.Iam.V1;
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

namespace Google.Cloud.Bigtable.Admin.V2.UnitTests
{
    /// <summary>Generated unit tests</summary>
    public class GeneratedBigtableInstanceAdminClientTest
    {
        [Fact]
        public void GetInstanceTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> { DefaultValue = DefaultValue.Mock };
            Instance expectedResponse = new Instance
            {
                InstanceName = new InstanceName("[PROJECT]", "[INSTANCE]"),
                DisplayName = "displayName1615086568",
            };
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.GetInstance(It.IsAny<GetInstanceRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            InstanceName name = new InstanceName("[PROJECT]", "[INSTANCE]");
            Instance response = client.GetInstance(name);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void ListInstancesTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> { DefaultValue = DefaultValue.Mock };
            ListInstancesResponse expectedResponse = new ListInstancesResponse
            {
                NextPageToken = "nextPageToken-1530815211",
            };
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.ListInstances(It.IsAny<ListInstancesRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            ProjectName parent = new ProjectName("[PROJECT]");
            ListInstancesResponse response = client.ListInstances(parent);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteInstanceTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> { DefaultValue = DefaultValue.Mock };
            Empty expectedResponse = new Empty();
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.DeleteInstance(It.IsAny<DeleteInstanceRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            InstanceName name = new InstanceName("[PROJECT]", "[INSTANCE]");
            client.DeleteInstance(name);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetClusterTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> { DefaultValue = DefaultValue.Mock };
            Cluster expectedResponse = new Cluster
            {
                ClusterName = new ClusterName("[PROJECT]", "[INSTANCE]", "[CLUSTER]"),
                LocationAsLocationName = new LocationName("[PROJECT]", "[LOCATION]"),
                ServeNodes = 1288838783,
            };
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.GetCluster(It.IsAny<GetClusterRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            ClusterName name = new ClusterName("[PROJECT]", "[INSTANCE]", "[CLUSTER]");
            Cluster response = client.GetCluster(name);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void ListClustersTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> { DefaultValue = DefaultValue.Mock };
            ListClustersResponse expectedResponse = new ListClustersResponse
            {
                NextPageToken = "nextPageToken-1530815211",
            };
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.ListClusters(It.IsAny<ListClustersRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            InstanceName parent = new InstanceName("[PROJECT]", "[INSTANCE]");
            ListClustersResponse response = client.ListClusters(parent);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteClusterTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> { DefaultValue = DefaultValue.Mock };
            Empty expectedResponse = new Empty();
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.DeleteCluster(It.IsAny<DeleteClusterRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            ClusterName name = new ClusterName("[PROJECT]", "[INSTANCE]", "[CLUSTER]");
            client.DeleteCluster(name);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateAppProfileTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> { DefaultValue = DefaultValue.Mock };
            AppProfile expectedResponse = new AppProfile
            {
                Name = "name3373707",
                Etag = "etag3123477",
                Description = "description-1724546052",
            };
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.CreateAppProfile(It.IsAny<CreateAppProfileRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            InstanceName parent = new InstanceName("[PROJECT]", "[INSTANCE]");
            string appProfileId = "appProfileId1262094415";
            AppProfile appProfile = new AppProfile();
            AppProfile response = client.CreateAppProfile(parent, appProfileId, appProfile);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetAppProfileTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> { DefaultValue = DefaultValue.Mock };
            AppProfile expectedResponse = new AppProfile
            {
                Name = "name2-1052831874",
                Etag = "etag3123477",
                Description = "description-1724546052",
            };
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.GetAppProfile(It.IsAny<GetAppProfileRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            AppProfileName name = new AppProfileName("[PROJECT]", "[INSTANCE]", "[APP_PROFILE]");
            AppProfile response = client.GetAppProfile(name);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteAppProfileTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> { DefaultValue = DefaultValue.Mock };
            Empty expectedResponse = new Empty();
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.DeleteAppProfile(It.IsAny<DeleteAppProfileRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            AppProfileName name = new AppProfileName("[PROJECT]", "[INSTANCE]", "[APP_PROFILE]");
            client.DeleteAppProfile(name);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetIamPolicyTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> { DefaultValue = DefaultValue.Mock };
            Policy expectedResponse = new Policy
            {
                Version = 351608024,
                Etag = ByteString.CopyFromUtf8("etag3123477"),
            };
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.GetIamPolicy(It.IsAny<GetIamPolicyRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            string formattedResource = new InstanceName("[PROJECT]", "[INSTANCE]").ToString();
            Policy response = client.GetIamPolicy(formattedResource);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void SetIamPolicyTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> { DefaultValue = DefaultValue.Mock };
            Policy expectedResponse = new Policy
            {
                Version = 351608024,
                Etag = ByteString.CopyFromUtf8("etag3123477"),
            };
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.SetIamPolicy(It.IsAny<SetIamPolicyRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            string formattedResource = new InstanceName("[PROJECT]", "[INSTANCE]").ToString();
            Policy policy = new Policy();
            Policy response = client.SetIamPolicy(formattedResource, policy);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void TestIamPermissionsTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> { DefaultValue = DefaultValue.Mock };
            TestIamPermissionsResponse expectedResponse = new TestIamPermissionsResponse();
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.TestIamPermissions(It.IsAny<TestIamPermissionsRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            string formattedResource = new InstanceName("[PROJECT]", "[INSTANCE]").ToString();
            IEnumerable<string> permissions = new List<string>();
            TestIamPermissionsResponse response = client.TestIamPermissions(formattedResource, permissions);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}
