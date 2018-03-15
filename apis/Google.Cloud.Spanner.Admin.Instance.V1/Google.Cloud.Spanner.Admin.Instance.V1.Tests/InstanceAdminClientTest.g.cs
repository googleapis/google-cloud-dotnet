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

namespace Google.Cloud.Spanner.Admin.Instance.V1.UnitTests
{
    /// <summary>Generated unit tests</summary>
    public class GeneratedInstanceAdminClientTest
    {
        [Fact]
        public void GetInstanceConfigTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<InstanceAdmin.InstanceAdminClient> mockGrpcClient = new Mock<InstanceAdmin.InstanceAdminClient> { DefaultValue = DefaultValue.Mock };
            InstanceConfig expectedResponse = new InstanceConfig
            {
                InstanceConfigName = new InstanceConfigName("[PROJECT]", "[INSTANCE_CONFIG]"),
                DisplayName = "displayName1615086568",
            };
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.GetInstanceConfig(It.IsAny<GetInstanceConfigRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            InstanceAdminClient client = new InstanceAdminClientImpl(mockGrpcClient.Object, null);
            InstanceConfigName name = new InstanceConfigName("[PROJECT]", "[INSTANCE_CONFIG]");
            InstanceConfig response = client.GetInstanceConfig(name);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetInstanceTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<InstanceAdmin.InstanceAdminClient> mockGrpcClient = new Mock<InstanceAdmin.InstanceAdminClient> { DefaultValue = DefaultValue.Mock };
            Instance expectedResponse = new Instance
            {
                InstanceName = new InstanceName("[PROJECT]", "[INSTANCE]"),
                ConfigAsInstanceConfigName = new InstanceConfigName("[PROJECT]", "[INSTANCE_CONFIG]"),
                DisplayName = "displayName1615086568",
                NodeCount = 1539922066,
            };
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.GetInstance(It.IsAny<GetInstanceRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            InstanceAdminClient client = new InstanceAdminClientImpl(mockGrpcClient.Object, null);
            InstanceName name = new InstanceName("[PROJECT]", "[INSTANCE]");
            Instance response = client.GetInstance(name);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteInstanceTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<InstanceAdmin.InstanceAdminClient> mockGrpcClient = new Mock<InstanceAdmin.InstanceAdminClient> { DefaultValue = DefaultValue.Mock };
            Empty expectedResponse = new Empty();
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.DeleteInstance(It.IsAny<DeleteInstanceRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            InstanceAdminClient client = new InstanceAdminClientImpl(mockGrpcClient.Object, null);
            InstanceName name = new InstanceName("[PROJECT]", "[INSTANCE]");
            client.DeleteInstance(name);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void SetIamPolicyTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<InstanceAdmin.InstanceAdminClient> mockGrpcClient = new Mock<InstanceAdmin.InstanceAdminClient> { DefaultValue = DefaultValue.Mock };
            Policy expectedResponse = new Policy
            {
                Version = 351608024,
                Etag = ByteString.CopyFromUtf8("21"),
            };
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.SetIamPolicy(It.IsAny<SetIamPolicyRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            InstanceAdminClient client = new InstanceAdminClientImpl(mockGrpcClient.Object, null);
            string formattedResource = new InstanceName("[PROJECT]", "[INSTANCE]").ToString();
            Policy policy = new Policy();
            Policy response = client.SetIamPolicy(formattedResource, policy);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetIamPolicyTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<InstanceAdmin.InstanceAdminClient> mockGrpcClient = new Mock<InstanceAdmin.InstanceAdminClient> { DefaultValue = DefaultValue.Mock };
            Policy expectedResponse = new Policy
            {
                Version = 351608024,
                Etag = ByteString.CopyFromUtf8("21"),
            };
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.GetIamPolicy(It.IsAny<GetIamPolicyRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            InstanceAdminClient client = new InstanceAdminClientImpl(mockGrpcClient.Object, null);
            string formattedResource = new InstanceName("[PROJECT]", "[INSTANCE]").ToString();
            Policy response = client.GetIamPolicy(formattedResource);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void TestIamPermissionsTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<InstanceAdmin.InstanceAdminClient> mockGrpcClient = new Mock<InstanceAdmin.InstanceAdminClient> { DefaultValue = DefaultValue.Mock };
            TestIamPermissionsResponse expectedResponse = new TestIamPermissionsResponse();
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.TestIamPermissions(It.IsAny<TestIamPermissionsRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            InstanceAdminClient client = new InstanceAdminClientImpl(mockGrpcClient.Object, null);
            string formattedResource = new InstanceName("[PROJECT]", "[INSTANCE]").ToString();
            IEnumerable<string> permissions = new List<string>();
            TestIamPermissionsResponse response = client.TestIamPermissions(formattedResource, permissions);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}
