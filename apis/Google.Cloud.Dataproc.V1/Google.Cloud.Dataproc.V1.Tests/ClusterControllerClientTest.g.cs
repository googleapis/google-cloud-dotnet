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

namespace Google.Cloud.Dataproc.V1.UnitTests
{
    /// <summary>Generated unit tests</summary>
    public class GeneratedClusterControllerClientTest
    {
        [Fact]
        public void GetClusterTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<ClusterController.ClusterControllerClient> mockGrpcClient = new Mock<ClusterController.ClusterControllerClient> { DefaultValue = DefaultValue.Mock };
            Cluster expectedResponse = new Cluster
            {
                ProjectId = "projectId2939242356",
                ClusterName = "clusterName2875867491",
                ClusterUuid = "clusterUuid-1017854240",
            };
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.GetCluster(It.IsAny<GetClusterRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            ClusterControllerClient client = new ClusterControllerClientImpl(mockGrpcClient.Object, null);
            string projectId = "projectId-1969970175";
            string region = "region-934795532";
            string clusterName = "clusterName-1018081872";
            Cluster response = client.GetCluster(projectId, region, clusterName);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}
