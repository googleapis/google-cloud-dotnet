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

namespace Google.Cloud.Bigtable.V2.UnitTests
{
    /// <summary>Generated unit tests</summary>
    public class GeneratedBigtableServiceApiClientTest
    {
        [Fact]
        public void MutateRowTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<Bigtable.BigtableClient> mockGrpcClient = new Mock<Bigtable.BigtableClient> { DefaultValue = DefaultValue.Mock };
            MutateRowResponse expectedResponse = new MutateRowResponse();
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.MutateRow(It.IsAny<MutateRowRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            BigtableServiceApiClient client = new BigtableServiceApiClientImpl(mockGrpcClient.Object, null);
            TableName tableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]");
            ByteString rowKey = ByteString.CopyFromUtf8("122");
            IEnumerable<Mutation> mutations = new List<Mutation>();
            MutateRowResponse response = client.MutateRow(tableName, rowKey, mutations);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CheckAndMutateRowTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<Bigtable.BigtableClient> mockGrpcClient = new Mock<Bigtable.BigtableClient> { DefaultValue = DefaultValue.Mock };
            CheckAndMutateRowResponse expectedResponse = new CheckAndMutateRowResponse
            {
                PredicateMatched = true,
            };
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.CheckAndMutateRow(It.IsAny<CheckAndMutateRowRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            BigtableServiceApiClient client = new BigtableServiceApiClientImpl(mockGrpcClient.Object, null);
            TableName tableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]");
            ByteString rowKey = ByteString.CopyFromUtf8("122");
            RowFilter predicateFilter = new RowFilter();
            IEnumerable<Mutation> trueMutations = new List<Mutation>();
            IEnumerable<Mutation> falseMutations = new List<Mutation>();
            CheckAndMutateRowResponse response = client.CheckAndMutateRow(tableName, rowKey, predicateFilter, trueMutations, falseMutations);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void ReadModifyWriteRowTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<Bigtable.BigtableClient> mockGrpcClient = new Mock<Bigtable.BigtableClient> { DefaultValue = DefaultValue.Mock };
            ReadModifyWriteRowResponse expectedResponse = new ReadModifyWriteRowResponse();
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.ReadModifyWriteRow(It.IsAny<ReadModifyWriteRowRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            BigtableServiceApiClient client = new BigtableServiceApiClientImpl(mockGrpcClient.Object, null);
            TableName tableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]");
            ByteString rowKey = ByteString.CopyFromUtf8("122");
            IEnumerable<ReadModifyWriteRule> rules = new List<ReadModifyWriteRule>();
            ReadModifyWriteRowResponse response = client.ReadModifyWriteRow(tableName, rowKey, rules);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}
