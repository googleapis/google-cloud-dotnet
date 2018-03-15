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

namespace Google.Cloud.Bigtable.Admin.V2.UnitTests
{
    /// <summary>Generated unit tests</summary>
    public class GeneratedBigtableTableAdminClientTest
    {
        [Fact]
        public void CreateTableTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new Mock<BigtableTableAdmin.BigtableTableAdminClient> { DefaultValue = DefaultValue.Mock };
            Table expectedResponse = new Table
            {
                TableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]"),
            };
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.CreateTable(It.IsAny<CreateTableRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            InstanceName parent = new InstanceName("[PROJECT]", "[INSTANCE]");
            string tableId = "tableId-895419604";
            Table table = new Table();
            Table response = client.CreateTable(parent, tableId, table);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetTableTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new Mock<BigtableTableAdmin.BigtableTableAdminClient> { DefaultValue = DefaultValue.Mock };
            Table expectedResponse = new Table
            {
                TableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]"),
            };
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.GetTable(It.IsAny<GetTableRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            TableName name = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]");
            Table response = client.GetTable(name);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteTableTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new Mock<BigtableTableAdmin.BigtableTableAdminClient> { DefaultValue = DefaultValue.Mock };
            Empty expectedResponse = new Empty();
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.DeleteTable(It.IsAny<DeleteTableRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            TableName name = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]");
            client.DeleteTable(name);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void ModifyColumnFamiliesTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new Mock<BigtableTableAdmin.BigtableTableAdminClient> { DefaultValue = DefaultValue.Mock };
            Table expectedResponse = new Table
            {
                TableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]"),
            };
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.ModifyColumnFamilies(It.IsAny<ModifyColumnFamiliesRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            TableName name = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]");
            IEnumerable<ModifyColumnFamiliesRequest.Types.Modification> modifications = new List<ModifyColumnFamiliesRequest.Types.Modification>();
            Table response = client.ModifyColumnFamilies(name, modifications);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GenerateConsistencyTokenTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new Mock<BigtableTableAdmin.BigtableTableAdminClient> { DefaultValue = DefaultValue.Mock };
            GenerateConsistencyTokenResponse expectedResponse = new GenerateConsistencyTokenResponse
            {
                ConsistencyToken = "consistencyToken-1090516718",
            };
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.GenerateConsistencyToken(It.IsAny<GenerateConsistencyTokenRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            TableName name = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]");
            GenerateConsistencyTokenResponse response = client.GenerateConsistencyToken(name);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CheckConsistencyTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new Mock<BigtableTableAdmin.BigtableTableAdminClient> { DefaultValue = DefaultValue.Mock };
            CheckConsistencyResponse expectedResponse = new CheckConsistencyResponse
            {
                Consistent = true,
            };
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.CheckConsistency(It.IsAny<CheckConsistencyRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            TableName name = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]");
            string consistencyToken = "consistencyToken-1090516718";
            CheckConsistencyResponse response = client.CheckConsistency(name, consistencyToken);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetSnapshotTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new Mock<BigtableTableAdmin.BigtableTableAdminClient> { DefaultValue = DefaultValue.Mock };
            Snapshot expectedResponse = new Snapshot
            {
                Name = "name2-1052831874",
                DataSizeBytes = 2110122398L,
                Description = "description-1724546052",
            };
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.GetSnapshot(It.IsAny<GetSnapshotRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            SnapshotName name = new SnapshotName("[PROJECT]", "[INSTANCE]", "[CLUSTER]", "[SNAPSHOT]");
            Snapshot response = client.GetSnapshot(name);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteSnapshotTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new Mock<BigtableTableAdmin.BigtableTableAdminClient> { DefaultValue = DefaultValue.Mock };
            Empty expectedResponse = new Empty();
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.DeleteSnapshot(It.IsAny<DeleteSnapshotRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            SnapshotName name = new SnapshotName("[PROJECT]", "[INSTANCE]", "[CLUSTER]", "[SNAPSHOT]");
            client.DeleteSnapshot(name);
            mockGrpcClient.VerifyAll();
        }

    }
}
