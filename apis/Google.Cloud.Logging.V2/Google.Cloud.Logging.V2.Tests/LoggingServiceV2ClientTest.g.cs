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

using Google.Api;
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

namespace Google.Cloud.Logging.V2.UnitTests
{
    /// <summary>Generated unit tests</summary>
    public class GeneratedLoggingServiceV2ClientTest
    {
        [Fact]
        public void DeleteLogTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<LoggingServiceV2.LoggingServiceV2Client> mockGrpcClient = new Mock<LoggingServiceV2.LoggingServiceV2Client> { DefaultValue = DefaultValue.Mock };
            Empty expectedResponse = new Empty();
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.DeleteLog(It.IsAny<DeleteLogRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            LoggingServiceV2Client client = new LoggingServiceV2ClientImpl(mockGrpcClient.Object, null);
            LogNameOneof logName = LogNameOneof.From(new LogName("[PROJECT]", "[LOG]"));
            client.DeleteLog(logName);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void WriteLogEntriesTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<LoggingServiceV2.LoggingServiceV2Client> mockGrpcClient = new Mock<LoggingServiceV2.LoggingServiceV2Client> { DefaultValue = DefaultValue.Mock };
            WriteLogEntriesResponse expectedResponse = new WriteLogEntriesResponse();
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.WriteLogEntries(It.IsAny<WriteLogEntriesRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            LoggingServiceV2Client client = new LoggingServiceV2ClientImpl(mockGrpcClient.Object, null);
            LogNameOneof logName = LogNameOneof.From(new LogName("[PROJECT]", "[LOG]"));
            MonitoredResource resource = new MonitoredResource();
            IDictionary<string, string> labels = new Dictionary<string, string>();
            IEnumerable<LogEntry> entries = new List<LogEntry>();
            WriteLogEntriesResponse response = client.WriteLogEntries(logName, resource, labels, entries);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}
