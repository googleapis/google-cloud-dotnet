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

namespace Google.LongRunning.UnitTests
{
    /// <summary>Generated unit tests</summary>
    public class GeneratedOperationsClientTest
    {
        [Fact]
        public void GetOperationTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<Operations.OperationsClient> mockGrpcClient = new Mock<Operations.OperationsClient> { DefaultValue = DefaultValue.Mock };
            Operation expectedResponse = new Operation
            {
                Name = "name2-1052831874",
                Done = true,
            };
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.GetOperation(It.IsAny<GetOperationRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            OperationsClient client = new OperationsClientImpl(mockGrpcClient.Object, null);
            string name = "name3373707";
            Operation response = client.GetOperation(name);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CancelOperationTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<Operations.OperationsClient> mockGrpcClient = new Mock<Operations.OperationsClient> { DefaultValue = DefaultValue.Mock };
            Empty expectedResponse = new Empty();
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.CancelOperation(It.IsAny<CancelOperationRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            OperationsClient client = new OperationsClientImpl(mockGrpcClient.Object, null);
            string name = "name3373707";
            client.CancelOperation(name);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteOperationTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<Operations.OperationsClient> mockGrpcClient = new Mock<Operations.OperationsClient> { DefaultValue = DefaultValue.Mock };
            Empty expectedResponse = new Empty();
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.DeleteOperation(It.IsAny<DeleteOperationRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            OperationsClient client = new OperationsClientImpl(mockGrpcClient.Object, null);
            string name = "name3373707";
            client.DeleteOperation(name);
            mockGrpcClient.VerifyAll();
        }

    }
}
