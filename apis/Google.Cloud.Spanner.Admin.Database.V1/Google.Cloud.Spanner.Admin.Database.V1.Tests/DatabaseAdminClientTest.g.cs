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

namespace Google.Cloud.Spanner.Admin.Database.V1.UnitTests
{
    /// <summary>Generated unit tests</summary>
    public class GeneratedDatabaseAdminClientTest
    {
        [Fact]
        public void GetDatabaseTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<DatabaseAdmin.DatabaseAdminClient> mockGrpcClient = new Mock<DatabaseAdmin.DatabaseAdminClient> { DefaultValue = DefaultValue.Mock };
            Database expectedResponse = new Database
            {
                Name = "name2-1052831874",
            };
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.GetDatabase(It.IsAny<GetDatabaseRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            DatabaseAdminClient client = new DatabaseAdminClientImpl(mockGrpcClient.Object, null);
            DatabaseName name = new DatabaseName("[PROJECT]", "[INSTANCE]", "[DATABASE]");
            Database response = client.GetDatabase(name);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DropDatabaseTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<DatabaseAdmin.DatabaseAdminClient> mockGrpcClient = new Mock<DatabaseAdmin.DatabaseAdminClient> { DefaultValue = DefaultValue.Mock };
            Empty expectedResponse = new Empty();
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.DropDatabase(It.IsAny<DropDatabaseRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            DatabaseAdminClient client = new DatabaseAdminClientImpl(mockGrpcClient.Object, null);
            DatabaseName database = new DatabaseName("[PROJECT]", "[INSTANCE]", "[DATABASE]");
            client.DropDatabase(database);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetDatabaseDdlTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<DatabaseAdmin.DatabaseAdminClient> mockGrpcClient = new Mock<DatabaseAdmin.DatabaseAdminClient> { DefaultValue = DefaultValue.Mock };
            GetDatabaseDdlResponse expectedResponse = new GetDatabaseDdlResponse();
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.GetDatabaseDdl(It.IsAny<GetDatabaseDdlRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            DatabaseAdminClient client = new DatabaseAdminClientImpl(mockGrpcClient.Object, null);
            DatabaseName database = new DatabaseName("[PROJECT]", "[INSTANCE]", "[DATABASE]");
            GetDatabaseDdlResponse response = client.GetDatabaseDdl(database);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void SetIamPolicyTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<DatabaseAdmin.DatabaseAdminClient> mockGrpcClient = new Mock<DatabaseAdmin.DatabaseAdminClient> { DefaultValue = DefaultValue.Mock };
            Policy expectedResponse = new Policy
            {
                Version = 351608024,
                Etag = ByteString.CopyFromUtf8("21"),
            };
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.SetIamPolicy(It.IsAny<SetIamPolicyRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            DatabaseAdminClient client = new DatabaseAdminClientImpl(mockGrpcClient.Object, null);
            string formattedResource = new DatabaseName("[PROJECT]", "[INSTANCE]", "[DATABASE]").ToString();
            Policy policy = new Policy();
            Policy response = client.SetIamPolicy(formattedResource, policy);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetIamPolicyTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<DatabaseAdmin.DatabaseAdminClient> mockGrpcClient = new Mock<DatabaseAdmin.DatabaseAdminClient> { DefaultValue = DefaultValue.Mock };
            Policy expectedResponse = new Policy
            {
                Version = 351608024,
                Etag = ByteString.CopyFromUtf8("21"),
            };
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.GetIamPolicy(It.IsAny<GetIamPolicyRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            DatabaseAdminClient client = new DatabaseAdminClientImpl(mockGrpcClient.Object, null);
            string formattedResource = new DatabaseName("[PROJECT]", "[INSTANCE]", "[DATABASE]").ToString();
            Policy response = client.GetIamPolicy(formattedResource);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void TestIamPermissionsTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<DatabaseAdmin.DatabaseAdminClient> mockGrpcClient = new Mock<DatabaseAdmin.DatabaseAdminClient> { DefaultValue = DefaultValue.Mock };
            TestIamPermissionsResponse expectedResponse = new TestIamPermissionsResponse();
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.TestIamPermissions(It.IsAny<TestIamPermissionsRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            DatabaseAdminClient client = new DatabaseAdminClientImpl(mockGrpcClient.Object, null);
            string formattedResource = new DatabaseName("[PROJECT]", "[INSTANCE]", "[DATABASE]").ToString();
            IEnumerable<string> permissions = new List<string>();
            TestIamPermissionsResponse response = client.TestIamPermissions(formattedResource, permissions);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}
