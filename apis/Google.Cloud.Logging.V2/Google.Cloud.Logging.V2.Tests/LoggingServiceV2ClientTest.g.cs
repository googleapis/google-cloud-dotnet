// Copyright 2020 Google LLC
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

namespace Google.Cloud.Logging.V2.Tests
{
    using Google.Api;
    using Google.Api.Gax;
    using Google.Api.Gax.Grpc;
    using apis = Google.Cloud.Logging.V2;
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
    public class GeneratedLoggingServiceV2ClientTest
    {
        [Fact]
        public void DeleteLog()
        {
            Mock<LoggingServiceV2.LoggingServiceV2Client> mockGrpcClient = new Mock<LoggingServiceV2.LoggingServiceV2Client>(MockBehavior.Strict);
            DeleteLogRequest expectedRequest = new DeleteLogRequest
            {
                LogNameAsLogNameOneof = LogNameOneof.From(new LogName("[PROJECT]", "[LOG]")),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteLog(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            LoggingServiceV2Client client = new LoggingServiceV2ClientImpl(mockGrpcClient.Object, null);
            LogNameOneof logName = LogNameOneof.From(new LogName("[PROJECT]", "[LOG]"));
            client.DeleteLog(logName);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteLogAsync()
        {
            Mock<LoggingServiceV2.LoggingServiceV2Client> mockGrpcClient = new Mock<LoggingServiceV2.LoggingServiceV2Client>(MockBehavior.Strict);
            DeleteLogRequest expectedRequest = new DeleteLogRequest
            {
                LogNameAsLogNameOneof = LogNameOneof.From(new LogName("[PROJECT]", "[LOG]")),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteLogAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            LoggingServiceV2Client client = new LoggingServiceV2ClientImpl(mockGrpcClient.Object, null);
            LogNameOneof logName = LogNameOneof.From(new LogName("[PROJECT]", "[LOG]"));
            await client.DeleteLogAsync(logName);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteLog2()
        {
            Mock<LoggingServiceV2.LoggingServiceV2Client> mockGrpcClient = new Mock<LoggingServiceV2.LoggingServiceV2Client>(MockBehavior.Strict);
            DeleteLogRequest request = new DeleteLogRequest
            {
                LogNameAsLogNameOneof = LogNameOneof.From(new LogName("[PROJECT]", "[LOG]")),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteLog(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            LoggingServiceV2Client client = new LoggingServiceV2ClientImpl(mockGrpcClient.Object, null);
            client.DeleteLog(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteLogAsync2()
        {
            Mock<LoggingServiceV2.LoggingServiceV2Client> mockGrpcClient = new Mock<LoggingServiceV2.LoggingServiceV2Client>(MockBehavior.Strict);
            DeleteLogRequest request = new DeleteLogRequest
            {
                LogNameAsLogNameOneof = LogNameOneof.From(new LogName("[PROJECT]", "[LOG]")),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteLogAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            LoggingServiceV2Client client = new LoggingServiceV2ClientImpl(mockGrpcClient.Object, null);
            await client.DeleteLogAsync(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void WriteLogEntries()
        {
            Mock<LoggingServiceV2.LoggingServiceV2Client> mockGrpcClient = new Mock<LoggingServiceV2.LoggingServiceV2Client>(MockBehavior.Strict);
            WriteLogEntriesRequest expectedRequest = new WriteLogEntriesRequest
            {
                LogNameAsLogNameOneof = LogNameOneof.From(new LogName("[PROJECT]", "[LOG]")),
                Resource = new MonitoredResource(),
                Labels = { },
                Entries = { },
            };
            WriteLogEntriesResponse expectedResponse = new WriteLogEntriesResponse();
            mockGrpcClient.Setup(x => x.WriteLogEntries(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            LoggingServiceV2Client client = new LoggingServiceV2ClientImpl(mockGrpcClient.Object, null);
            LogNameOneof logName = LogNameOneof.From(new LogName("[PROJECT]", "[LOG]"));
            MonitoredResource resource = new MonitoredResource();
            IDictionary<string, string> labels = new Dictionary<string, string>();
            IEnumerable<LogEntry> entries = new List<LogEntry>();
            WriteLogEntriesResponse response = client.WriteLogEntries(logName, resource, labels, entries);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task WriteLogEntriesAsync()
        {
            Mock<LoggingServiceV2.LoggingServiceV2Client> mockGrpcClient = new Mock<LoggingServiceV2.LoggingServiceV2Client>(MockBehavior.Strict);
            WriteLogEntriesRequest expectedRequest = new WriteLogEntriesRequest
            {
                LogNameAsLogNameOneof = LogNameOneof.From(new LogName("[PROJECT]", "[LOG]")),
                Resource = new MonitoredResource(),
                Labels = { },
                Entries = { },
            };
            WriteLogEntriesResponse expectedResponse = new WriteLogEntriesResponse();
            mockGrpcClient.Setup(x => x.WriteLogEntriesAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<WriteLogEntriesResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            LoggingServiceV2Client client = new LoggingServiceV2ClientImpl(mockGrpcClient.Object, null);
            LogNameOneof logName = LogNameOneof.From(new LogName("[PROJECT]", "[LOG]"));
            MonitoredResource resource = new MonitoredResource();
            IDictionary<string, string> labels = new Dictionary<string, string>();
            IEnumerable<LogEntry> entries = new List<LogEntry>();
            WriteLogEntriesResponse response = await client.WriteLogEntriesAsync(logName, resource, labels, entries);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void WriteLogEntries2()
        {
            Mock<LoggingServiceV2.LoggingServiceV2Client> mockGrpcClient = new Mock<LoggingServiceV2.LoggingServiceV2Client>(MockBehavior.Strict);
            WriteLogEntriesRequest request = new WriteLogEntriesRequest
            {
                Entries = { },
            };
            WriteLogEntriesResponse expectedResponse = new WriteLogEntriesResponse();
            mockGrpcClient.Setup(x => x.WriteLogEntries(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            LoggingServiceV2Client client = new LoggingServiceV2ClientImpl(mockGrpcClient.Object, null);
            WriteLogEntriesResponse response = client.WriteLogEntries(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task WriteLogEntriesAsync2()
        {
            Mock<LoggingServiceV2.LoggingServiceV2Client> mockGrpcClient = new Mock<LoggingServiceV2.LoggingServiceV2Client>(MockBehavior.Strict);
            WriteLogEntriesRequest request = new WriteLogEntriesRequest
            {
                Entries = { },
            };
            WriteLogEntriesResponse expectedResponse = new WriteLogEntriesResponse();
            mockGrpcClient.Setup(x => x.WriteLogEntriesAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<WriteLogEntriesResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            LoggingServiceV2Client client = new LoggingServiceV2ClientImpl(mockGrpcClient.Object, null);
            WriteLogEntriesResponse response = await client.WriteLogEntriesAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}
