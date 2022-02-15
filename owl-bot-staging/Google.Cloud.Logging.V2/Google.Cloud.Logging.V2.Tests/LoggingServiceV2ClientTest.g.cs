// Copyright 2022 Google LLC
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

using ga = Google.Api;
using gaxgrpc = Google.Api.Gax.Grpc;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Logging.V2.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedLoggingServiceV2ClientTest
    {
        [xunit::FactAttribute]
        public void DeleteLogRequestObject()
        {
            moq::Mock<LoggingServiceV2.LoggingServiceV2Client> mockGrpcClient = new moq::Mock<LoggingServiceV2.LoggingServiceV2Client>(moq::MockBehavior.Strict);
            DeleteLogRequest request = new DeleteLogRequest
            {
                LogNameAsLogName = LogName.FromProjectLog("[PROJECT]", "[LOG]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteLog(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            LoggingServiceV2Client client = new LoggingServiceV2ClientImpl(mockGrpcClient.Object, null);
            client.DeleteLog(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteLogRequestObjectAsync()
        {
            moq::Mock<LoggingServiceV2.LoggingServiceV2Client> mockGrpcClient = new moq::Mock<LoggingServiceV2.LoggingServiceV2Client>(moq::MockBehavior.Strict);
            DeleteLogRequest request = new DeleteLogRequest
            {
                LogNameAsLogName = LogName.FromProjectLog("[PROJECT]", "[LOG]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteLogAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            LoggingServiceV2Client client = new LoggingServiceV2ClientImpl(mockGrpcClient.Object, null);
            await client.DeleteLogAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteLogAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteLog()
        {
            moq::Mock<LoggingServiceV2.LoggingServiceV2Client> mockGrpcClient = new moq::Mock<LoggingServiceV2.LoggingServiceV2Client>(moq::MockBehavior.Strict);
            DeleteLogRequest request = new DeleteLogRequest
            {
                LogNameAsLogName = LogName.FromProjectLog("[PROJECT]", "[LOG]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteLog(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            LoggingServiceV2Client client = new LoggingServiceV2ClientImpl(mockGrpcClient.Object, null);
            client.DeleteLog(request.LogName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteLogAsync()
        {
            moq::Mock<LoggingServiceV2.LoggingServiceV2Client> mockGrpcClient = new moq::Mock<LoggingServiceV2.LoggingServiceV2Client>(moq::MockBehavior.Strict);
            DeleteLogRequest request = new DeleteLogRequest
            {
                LogNameAsLogName = LogName.FromProjectLog("[PROJECT]", "[LOG]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteLogAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            LoggingServiceV2Client client = new LoggingServiceV2ClientImpl(mockGrpcClient.Object, null);
            await client.DeleteLogAsync(request.LogName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteLogAsync(request.LogName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteLogResourceNames()
        {
            moq::Mock<LoggingServiceV2.LoggingServiceV2Client> mockGrpcClient = new moq::Mock<LoggingServiceV2.LoggingServiceV2Client>(moq::MockBehavior.Strict);
            DeleteLogRequest request = new DeleteLogRequest
            {
                LogNameAsLogName = LogName.FromProjectLog("[PROJECT]", "[LOG]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteLog(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            LoggingServiceV2Client client = new LoggingServiceV2ClientImpl(mockGrpcClient.Object, null);
            client.DeleteLog(request.LogNameAsLogName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteLogResourceNamesAsync()
        {
            moq::Mock<LoggingServiceV2.LoggingServiceV2Client> mockGrpcClient = new moq::Mock<LoggingServiceV2.LoggingServiceV2Client>(moq::MockBehavior.Strict);
            DeleteLogRequest request = new DeleteLogRequest
            {
                LogNameAsLogName = LogName.FromProjectLog("[PROJECT]", "[LOG]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteLogAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            LoggingServiceV2Client client = new LoggingServiceV2ClientImpl(mockGrpcClient.Object, null);
            await client.DeleteLogAsync(request.LogNameAsLogName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteLogAsync(request.LogNameAsLogName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void WriteLogEntriesRequestObject()
        {
            moq::Mock<LoggingServiceV2.LoggingServiceV2Client> mockGrpcClient = new moq::Mock<LoggingServiceV2.LoggingServiceV2Client>(moq::MockBehavior.Strict);
            WriteLogEntriesRequest request = new WriteLogEntriesRequest
            {
                LogNameAsLogName = LogName.FromProjectLog("[PROJECT]", "[LOG]"),
                Resource = new ga::MonitoredResource(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Entries = { new LogEntry(), },
                PartialSuccess = false,
                DryRun = true,
            };
            WriteLogEntriesResponse expectedResponse = new WriteLogEntriesResponse { };
            mockGrpcClient.Setup(x => x.WriteLogEntries(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            LoggingServiceV2Client client = new LoggingServiceV2ClientImpl(mockGrpcClient.Object, null);
            WriteLogEntriesResponse response = client.WriteLogEntries(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task WriteLogEntriesRequestObjectAsync()
        {
            moq::Mock<LoggingServiceV2.LoggingServiceV2Client> mockGrpcClient = new moq::Mock<LoggingServiceV2.LoggingServiceV2Client>(moq::MockBehavior.Strict);
            WriteLogEntriesRequest request = new WriteLogEntriesRequest
            {
                LogNameAsLogName = LogName.FromProjectLog("[PROJECT]", "[LOG]"),
                Resource = new ga::MonitoredResource(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Entries = { new LogEntry(), },
                PartialSuccess = false,
                DryRun = true,
            };
            WriteLogEntriesResponse expectedResponse = new WriteLogEntriesResponse { };
            mockGrpcClient.Setup(x => x.WriteLogEntriesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<WriteLogEntriesResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            LoggingServiceV2Client client = new LoggingServiceV2ClientImpl(mockGrpcClient.Object, null);
            WriteLogEntriesResponse responseCallSettings = await client.WriteLogEntriesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            WriteLogEntriesResponse responseCancellationToken = await client.WriteLogEntriesAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void WriteLogEntries()
        {
            moq::Mock<LoggingServiceV2.LoggingServiceV2Client> mockGrpcClient = new moq::Mock<LoggingServiceV2.LoggingServiceV2Client>(moq::MockBehavior.Strict);
            WriteLogEntriesRequest request = new WriteLogEntriesRequest
            {
                LogNameAsLogName = LogName.FromProjectLog("[PROJECT]", "[LOG]"),
                Resource = new ga::MonitoredResource(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Entries = { new LogEntry(), },
            };
            WriteLogEntriesResponse expectedResponse = new WriteLogEntriesResponse { };
            mockGrpcClient.Setup(x => x.WriteLogEntries(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            LoggingServiceV2Client client = new LoggingServiceV2ClientImpl(mockGrpcClient.Object, null);
            WriteLogEntriesResponse response = client.WriteLogEntries(request.LogName, request.Resource, request.Labels, request.Entries);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task WriteLogEntriesAsync()
        {
            moq::Mock<LoggingServiceV2.LoggingServiceV2Client> mockGrpcClient = new moq::Mock<LoggingServiceV2.LoggingServiceV2Client>(moq::MockBehavior.Strict);
            WriteLogEntriesRequest request = new WriteLogEntriesRequest
            {
                LogNameAsLogName = LogName.FromProjectLog("[PROJECT]", "[LOG]"),
                Resource = new ga::MonitoredResource(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Entries = { new LogEntry(), },
            };
            WriteLogEntriesResponse expectedResponse = new WriteLogEntriesResponse { };
            mockGrpcClient.Setup(x => x.WriteLogEntriesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<WriteLogEntriesResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            LoggingServiceV2Client client = new LoggingServiceV2ClientImpl(mockGrpcClient.Object, null);
            WriteLogEntriesResponse responseCallSettings = await client.WriteLogEntriesAsync(request.LogName, request.Resource, request.Labels, request.Entries, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            WriteLogEntriesResponse responseCancellationToken = await client.WriteLogEntriesAsync(request.LogName, request.Resource, request.Labels, request.Entries, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void WriteLogEntriesResourceNames()
        {
            moq::Mock<LoggingServiceV2.LoggingServiceV2Client> mockGrpcClient = new moq::Mock<LoggingServiceV2.LoggingServiceV2Client>(moq::MockBehavior.Strict);
            WriteLogEntriesRequest request = new WriteLogEntriesRequest
            {
                LogNameAsLogName = LogName.FromProjectLog("[PROJECT]", "[LOG]"),
                Resource = new ga::MonitoredResource(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Entries = { new LogEntry(), },
            };
            WriteLogEntriesResponse expectedResponse = new WriteLogEntriesResponse { };
            mockGrpcClient.Setup(x => x.WriteLogEntries(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            LoggingServiceV2Client client = new LoggingServiceV2ClientImpl(mockGrpcClient.Object, null);
            WriteLogEntriesResponse response = client.WriteLogEntries(request.LogNameAsLogName, request.Resource, request.Labels, request.Entries);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task WriteLogEntriesResourceNamesAsync()
        {
            moq::Mock<LoggingServiceV2.LoggingServiceV2Client> mockGrpcClient = new moq::Mock<LoggingServiceV2.LoggingServiceV2Client>(moq::MockBehavior.Strict);
            WriteLogEntriesRequest request = new WriteLogEntriesRequest
            {
                LogNameAsLogName = LogName.FromProjectLog("[PROJECT]", "[LOG]"),
                Resource = new ga::MonitoredResource(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Entries = { new LogEntry(), },
            };
            WriteLogEntriesResponse expectedResponse = new WriteLogEntriesResponse { };
            mockGrpcClient.Setup(x => x.WriteLogEntriesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<WriteLogEntriesResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            LoggingServiceV2Client client = new LoggingServiceV2ClientImpl(mockGrpcClient.Object, null);
            WriteLogEntriesResponse responseCallSettings = await client.WriteLogEntriesAsync(request.LogNameAsLogName, request.Resource, request.Labels, request.Entries, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            WriteLogEntriesResponse responseCancellationToken = await client.WriteLogEntriesAsync(request.LogNameAsLogName, request.Resource, request.Labels, request.Entries, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
