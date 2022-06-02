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

using gaxgrpc = Google.Api.Gax.Grpc;
using gcscv = Google.Cloud.Spanner.Common.V1;
using proto = Google.Protobuf;
using wkt = Google.Protobuf.WellKnownTypes;
using gr = Google.Rpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Spanner.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedSpannerClientTest
    {
        [xunit::FactAttribute]
        public void CreateSessionRequestObject()
        {
            moq::Mock<Spanner.SpannerClient> mockGrpcClient = new moq::Mock<Spanner.SpannerClient>(moq::MockBehavior.Strict);
            CreateSessionRequest request = new CreateSessionRequest
            {
                DatabaseAsDatabaseName = gcscv::DatabaseName.FromProjectInstanceDatabase("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
                Session = new Session(),
            };
            Session expectedResponse = new Session
            {
                SessionName = SessionName.FromProjectInstanceDatabaseSession("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                ApproximateLastUseTime = new wkt::Timestamp(),
                CreatorRole = "creator_role793740e8",
            };
            mockGrpcClient.Setup(x => x.CreateSession(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SpannerClient client = new SpannerClientImpl(mockGrpcClient.Object, null);
            Session response = client.CreateSession(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateSessionRequestObjectAsync()
        {
            moq::Mock<Spanner.SpannerClient> mockGrpcClient = new moq::Mock<Spanner.SpannerClient>(moq::MockBehavior.Strict);
            CreateSessionRequest request = new CreateSessionRequest
            {
                DatabaseAsDatabaseName = gcscv::DatabaseName.FromProjectInstanceDatabase("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
                Session = new Session(),
            };
            Session expectedResponse = new Session
            {
                SessionName = SessionName.FromProjectInstanceDatabaseSession("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                ApproximateLastUseTime = new wkt::Timestamp(),
                CreatorRole = "creator_role793740e8",
            };
            mockGrpcClient.Setup(x => x.CreateSessionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Session>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SpannerClient client = new SpannerClientImpl(mockGrpcClient.Object, null);
            Session responseCallSettings = await client.CreateSessionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Session responseCancellationToken = await client.CreateSessionAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateSession()
        {
            moq::Mock<Spanner.SpannerClient> mockGrpcClient = new moq::Mock<Spanner.SpannerClient>(moq::MockBehavior.Strict);
            CreateSessionRequest request = new CreateSessionRequest
            {
                DatabaseAsDatabaseName = gcscv::DatabaseName.FromProjectInstanceDatabase("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
            };
            Session expectedResponse = new Session
            {
                SessionName = SessionName.FromProjectInstanceDatabaseSession("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                ApproximateLastUseTime = new wkt::Timestamp(),
                CreatorRole = "creator_role793740e8",
            };
            mockGrpcClient.Setup(x => x.CreateSession(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SpannerClient client = new SpannerClientImpl(mockGrpcClient.Object, null);
            Session response = client.CreateSession(request.Database);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateSessionAsync()
        {
            moq::Mock<Spanner.SpannerClient> mockGrpcClient = new moq::Mock<Spanner.SpannerClient>(moq::MockBehavior.Strict);
            CreateSessionRequest request = new CreateSessionRequest
            {
                DatabaseAsDatabaseName = gcscv::DatabaseName.FromProjectInstanceDatabase("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
            };
            Session expectedResponse = new Session
            {
                SessionName = SessionName.FromProjectInstanceDatabaseSession("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                ApproximateLastUseTime = new wkt::Timestamp(),
                CreatorRole = "creator_role793740e8",
            };
            mockGrpcClient.Setup(x => x.CreateSessionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Session>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SpannerClient client = new SpannerClientImpl(mockGrpcClient.Object, null);
            Session responseCallSettings = await client.CreateSessionAsync(request.Database, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Session responseCancellationToken = await client.CreateSessionAsync(request.Database, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateSessionResourceNames()
        {
            moq::Mock<Spanner.SpannerClient> mockGrpcClient = new moq::Mock<Spanner.SpannerClient>(moq::MockBehavior.Strict);
            CreateSessionRequest request = new CreateSessionRequest
            {
                DatabaseAsDatabaseName = gcscv::DatabaseName.FromProjectInstanceDatabase("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
            };
            Session expectedResponse = new Session
            {
                SessionName = SessionName.FromProjectInstanceDatabaseSession("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                ApproximateLastUseTime = new wkt::Timestamp(),
                CreatorRole = "creator_role793740e8",
            };
            mockGrpcClient.Setup(x => x.CreateSession(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SpannerClient client = new SpannerClientImpl(mockGrpcClient.Object, null);
            Session response = client.CreateSession(request.DatabaseAsDatabaseName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateSessionResourceNamesAsync()
        {
            moq::Mock<Spanner.SpannerClient> mockGrpcClient = new moq::Mock<Spanner.SpannerClient>(moq::MockBehavior.Strict);
            CreateSessionRequest request = new CreateSessionRequest
            {
                DatabaseAsDatabaseName = gcscv::DatabaseName.FromProjectInstanceDatabase("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
            };
            Session expectedResponse = new Session
            {
                SessionName = SessionName.FromProjectInstanceDatabaseSession("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                ApproximateLastUseTime = new wkt::Timestamp(),
                CreatorRole = "creator_role793740e8",
            };
            mockGrpcClient.Setup(x => x.CreateSessionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Session>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SpannerClient client = new SpannerClientImpl(mockGrpcClient.Object, null);
            Session responseCallSettings = await client.CreateSessionAsync(request.DatabaseAsDatabaseName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Session responseCancellationToken = await client.CreateSessionAsync(request.DatabaseAsDatabaseName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void BatchCreateSessionsRequestObject()
        {
            moq::Mock<Spanner.SpannerClient> mockGrpcClient = new moq::Mock<Spanner.SpannerClient>(moq::MockBehavior.Strict);
            BatchCreateSessionsRequest request = new BatchCreateSessionsRequest
            {
                DatabaseAsDatabaseName = gcscv::DatabaseName.FromProjectInstanceDatabase("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
                SessionTemplate = new Session(),
                SessionCount = 418101156,
            };
            BatchCreateSessionsResponse expectedResponse = new BatchCreateSessionsResponse
            {
                Session = { new Session(), },
            };
            mockGrpcClient.Setup(x => x.BatchCreateSessions(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SpannerClient client = new SpannerClientImpl(mockGrpcClient.Object, null);
            BatchCreateSessionsResponse response = client.BatchCreateSessions(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task BatchCreateSessionsRequestObjectAsync()
        {
            moq::Mock<Spanner.SpannerClient> mockGrpcClient = new moq::Mock<Spanner.SpannerClient>(moq::MockBehavior.Strict);
            BatchCreateSessionsRequest request = new BatchCreateSessionsRequest
            {
                DatabaseAsDatabaseName = gcscv::DatabaseName.FromProjectInstanceDatabase("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
                SessionTemplate = new Session(),
                SessionCount = 418101156,
            };
            BatchCreateSessionsResponse expectedResponse = new BatchCreateSessionsResponse
            {
                Session = { new Session(), },
            };
            mockGrpcClient.Setup(x => x.BatchCreateSessionsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<BatchCreateSessionsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SpannerClient client = new SpannerClientImpl(mockGrpcClient.Object, null);
            BatchCreateSessionsResponse responseCallSettings = await client.BatchCreateSessionsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            BatchCreateSessionsResponse responseCancellationToken = await client.BatchCreateSessionsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void BatchCreateSessions()
        {
            moq::Mock<Spanner.SpannerClient> mockGrpcClient = new moq::Mock<Spanner.SpannerClient>(moq::MockBehavior.Strict);
            BatchCreateSessionsRequest request = new BatchCreateSessionsRequest
            {
                DatabaseAsDatabaseName = gcscv::DatabaseName.FromProjectInstanceDatabase("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
                SessionCount = 418101156,
            };
            BatchCreateSessionsResponse expectedResponse = new BatchCreateSessionsResponse
            {
                Session = { new Session(), },
            };
            mockGrpcClient.Setup(x => x.BatchCreateSessions(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SpannerClient client = new SpannerClientImpl(mockGrpcClient.Object, null);
            BatchCreateSessionsResponse response = client.BatchCreateSessions(request.Database, request.SessionCount);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task BatchCreateSessionsAsync()
        {
            moq::Mock<Spanner.SpannerClient> mockGrpcClient = new moq::Mock<Spanner.SpannerClient>(moq::MockBehavior.Strict);
            BatchCreateSessionsRequest request = new BatchCreateSessionsRequest
            {
                DatabaseAsDatabaseName = gcscv::DatabaseName.FromProjectInstanceDatabase("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
                SessionCount = 418101156,
            };
            BatchCreateSessionsResponse expectedResponse = new BatchCreateSessionsResponse
            {
                Session = { new Session(), },
            };
            mockGrpcClient.Setup(x => x.BatchCreateSessionsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<BatchCreateSessionsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SpannerClient client = new SpannerClientImpl(mockGrpcClient.Object, null);
            BatchCreateSessionsResponse responseCallSettings = await client.BatchCreateSessionsAsync(request.Database, request.SessionCount, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            BatchCreateSessionsResponse responseCancellationToken = await client.BatchCreateSessionsAsync(request.Database, request.SessionCount, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void BatchCreateSessionsResourceNames()
        {
            moq::Mock<Spanner.SpannerClient> mockGrpcClient = new moq::Mock<Spanner.SpannerClient>(moq::MockBehavior.Strict);
            BatchCreateSessionsRequest request = new BatchCreateSessionsRequest
            {
                DatabaseAsDatabaseName = gcscv::DatabaseName.FromProjectInstanceDatabase("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
                SessionCount = 418101156,
            };
            BatchCreateSessionsResponse expectedResponse = new BatchCreateSessionsResponse
            {
                Session = { new Session(), },
            };
            mockGrpcClient.Setup(x => x.BatchCreateSessions(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SpannerClient client = new SpannerClientImpl(mockGrpcClient.Object, null);
            BatchCreateSessionsResponse response = client.BatchCreateSessions(request.DatabaseAsDatabaseName, request.SessionCount);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task BatchCreateSessionsResourceNamesAsync()
        {
            moq::Mock<Spanner.SpannerClient> mockGrpcClient = new moq::Mock<Spanner.SpannerClient>(moq::MockBehavior.Strict);
            BatchCreateSessionsRequest request = new BatchCreateSessionsRequest
            {
                DatabaseAsDatabaseName = gcscv::DatabaseName.FromProjectInstanceDatabase("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
                SessionCount = 418101156,
            };
            BatchCreateSessionsResponse expectedResponse = new BatchCreateSessionsResponse
            {
                Session = { new Session(), },
            };
            mockGrpcClient.Setup(x => x.BatchCreateSessionsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<BatchCreateSessionsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SpannerClient client = new SpannerClientImpl(mockGrpcClient.Object, null);
            BatchCreateSessionsResponse responseCallSettings = await client.BatchCreateSessionsAsync(request.DatabaseAsDatabaseName, request.SessionCount, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            BatchCreateSessionsResponse responseCancellationToken = await client.BatchCreateSessionsAsync(request.DatabaseAsDatabaseName, request.SessionCount, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetSessionRequestObject()
        {
            moq::Mock<Spanner.SpannerClient> mockGrpcClient = new moq::Mock<Spanner.SpannerClient>(moq::MockBehavior.Strict);
            GetSessionRequest request = new GetSessionRequest
            {
                SessionName = SessionName.FromProjectInstanceDatabaseSession("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
            };
            Session expectedResponse = new Session
            {
                SessionName = SessionName.FromProjectInstanceDatabaseSession("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                ApproximateLastUseTime = new wkt::Timestamp(),
                CreatorRole = "creator_role793740e8",
            };
            mockGrpcClient.Setup(x => x.GetSession(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SpannerClient client = new SpannerClientImpl(mockGrpcClient.Object, null);
            Session response = client.GetSession(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetSessionRequestObjectAsync()
        {
            moq::Mock<Spanner.SpannerClient> mockGrpcClient = new moq::Mock<Spanner.SpannerClient>(moq::MockBehavior.Strict);
            GetSessionRequest request = new GetSessionRequest
            {
                SessionName = SessionName.FromProjectInstanceDatabaseSession("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
            };
            Session expectedResponse = new Session
            {
                SessionName = SessionName.FromProjectInstanceDatabaseSession("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                ApproximateLastUseTime = new wkt::Timestamp(),
                CreatorRole = "creator_role793740e8",
            };
            mockGrpcClient.Setup(x => x.GetSessionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Session>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SpannerClient client = new SpannerClientImpl(mockGrpcClient.Object, null);
            Session responseCallSettings = await client.GetSessionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Session responseCancellationToken = await client.GetSessionAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetSession()
        {
            moq::Mock<Spanner.SpannerClient> mockGrpcClient = new moq::Mock<Spanner.SpannerClient>(moq::MockBehavior.Strict);
            GetSessionRequest request = new GetSessionRequest
            {
                SessionName = SessionName.FromProjectInstanceDatabaseSession("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
            };
            Session expectedResponse = new Session
            {
                SessionName = SessionName.FromProjectInstanceDatabaseSession("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                ApproximateLastUseTime = new wkt::Timestamp(),
                CreatorRole = "creator_role793740e8",
            };
            mockGrpcClient.Setup(x => x.GetSession(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SpannerClient client = new SpannerClientImpl(mockGrpcClient.Object, null);
            Session response = client.GetSession(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetSessionAsync()
        {
            moq::Mock<Spanner.SpannerClient> mockGrpcClient = new moq::Mock<Spanner.SpannerClient>(moq::MockBehavior.Strict);
            GetSessionRequest request = new GetSessionRequest
            {
                SessionName = SessionName.FromProjectInstanceDatabaseSession("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
            };
            Session expectedResponse = new Session
            {
                SessionName = SessionName.FromProjectInstanceDatabaseSession("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                ApproximateLastUseTime = new wkt::Timestamp(),
                CreatorRole = "creator_role793740e8",
            };
            mockGrpcClient.Setup(x => x.GetSessionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Session>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SpannerClient client = new SpannerClientImpl(mockGrpcClient.Object, null);
            Session responseCallSettings = await client.GetSessionAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Session responseCancellationToken = await client.GetSessionAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetSessionResourceNames()
        {
            moq::Mock<Spanner.SpannerClient> mockGrpcClient = new moq::Mock<Spanner.SpannerClient>(moq::MockBehavior.Strict);
            GetSessionRequest request = new GetSessionRequest
            {
                SessionName = SessionName.FromProjectInstanceDatabaseSession("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
            };
            Session expectedResponse = new Session
            {
                SessionName = SessionName.FromProjectInstanceDatabaseSession("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                ApproximateLastUseTime = new wkt::Timestamp(),
                CreatorRole = "creator_role793740e8",
            };
            mockGrpcClient.Setup(x => x.GetSession(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SpannerClient client = new SpannerClientImpl(mockGrpcClient.Object, null);
            Session response = client.GetSession(request.SessionName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetSessionResourceNamesAsync()
        {
            moq::Mock<Spanner.SpannerClient> mockGrpcClient = new moq::Mock<Spanner.SpannerClient>(moq::MockBehavior.Strict);
            GetSessionRequest request = new GetSessionRequest
            {
                SessionName = SessionName.FromProjectInstanceDatabaseSession("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
            };
            Session expectedResponse = new Session
            {
                SessionName = SessionName.FromProjectInstanceDatabaseSession("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                ApproximateLastUseTime = new wkt::Timestamp(),
                CreatorRole = "creator_role793740e8",
            };
            mockGrpcClient.Setup(x => x.GetSessionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Session>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SpannerClient client = new SpannerClientImpl(mockGrpcClient.Object, null);
            Session responseCallSettings = await client.GetSessionAsync(request.SessionName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Session responseCancellationToken = await client.GetSessionAsync(request.SessionName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteSessionRequestObject()
        {
            moq::Mock<Spanner.SpannerClient> mockGrpcClient = new moq::Mock<Spanner.SpannerClient>(moq::MockBehavior.Strict);
            DeleteSessionRequest request = new DeleteSessionRequest
            {
                SessionName = SessionName.FromProjectInstanceDatabaseSession("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteSession(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SpannerClient client = new SpannerClientImpl(mockGrpcClient.Object, null);
            client.DeleteSession(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteSessionRequestObjectAsync()
        {
            moq::Mock<Spanner.SpannerClient> mockGrpcClient = new moq::Mock<Spanner.SpannerClient>(moq::MockBehavior.Strict);
            DeleteSessionRequest request = new DeleteSessionRequest
            {
                SessionName = SessionName.FromProjectInstanceDatabaseSession("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteSessionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SpannerClient client = new SpannerClientImpl(mockGrpcClient.Object, null);
            await client.DeleteSessionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteSessionAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteSession()
        {
            moq::Mock<Spanner.SpannerClient> mockGrpcClient = new moq::Mock<Spanner.SpannerClient>(moq::MockBehavior.Strict);
            DeleteSessionRequest request = new DeleteSessionRequest
            {
                SessionName = SessionName.FromProjectInstanceDatabaseSession("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteSession(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SpannerClient client = new SpannerClientImpl(mockGrpcClient.Object, null);
            client.DeleteSession(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteSessionAsync()
        {
            moq::Mock<Spanner.SpannerClient> mockGrpcClient = new moq::Mock<Spanner.SpannerClient>(moq::MockBehavior.Strict);
            DeleteSessionRequest request = new DeleteSessionRequest
            {
                SessionName = SessionName.FromProjectInstanceDatabaseSession("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteSessionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SpannerClient client = new SpannerClientImpl(mockGrpcClient.Object, null);
            await client.DeleteSessionAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteSessionAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteSessionResourceNames()
        {
            moq::Mock<Spanner.SpannerClient> mockGrpcClient = new moq::Mock<Spanner.SpannerClient>(moq::MockBehavior.Strict);
            DeleteSessionRequest request = new DeleteSessionRequest
            {
                SessionName = SessionName.FromProjectInstanceDatabaseSession("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteSession(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SpannerClient client = new SpannerClientImpl(mockGrpcClient.Object, null);
            client.DeleteSession(request.SessionName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteSessionResourceNamesAsync()
        {
            moq::Mock<Spanner.SpannerClient> mockGrpcClient = new moq::Mock<Spanner.SpannerClient>(moq::MockBehavior.Strict);
            DeleteSessionRequest request = new DeleteSessionRequest
            {
                SessionName = SessionName.FromProjectInstanceDatabaseSession("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteSessionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SpannerClient client = new SpannerClientImpl(mockGrpcClient.Object, null);
            await client.DeleteSessionAsync(request.SessionName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteSessionAsync(request.SessionName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ExecuteSqlRequestObject()
        {
            moq::Mock<Spanner.SpannerClient> mockGrpcClient = new moq::Mock<Spanner.SpannerClient>(moq::MockBehavior.Strict);
            ExecuteSqlRequest request = new ExecuteSqlRequest
            {
                SessionAsSessionName = SessionName.FromProjectInstanceDatabaseSession("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
                Transaction = new TransactionSelector(),
                Sql = "sqlb6745cac",
                Params = new wkt::Struct(),
                ParamTypes =
                {
                    {
                        "key8a0b6e3c",
                        new Type()
                    },
                },
                ResumeToken = proto::ByteString.CopyFromUtf8("resume_tokena048d43b"),
                QueryMode = ExecuteSqlRequest.Types.QueryMode.Normal,
                PartitionToken = proto::ByteString.CopyFromUtf8("partition_token1309778b"),
                Seqno = 4367695630312265944L,
                QueryOptions = new ExecuteSqlRequest.Types.QueryOptions(),
                RequestOptions = new RequestOptions(),
            };
            ResultSet expectedResponse = new ResultSet
            {
                Metadata = new ResultSetMetadata(),
                Rows =
                {
                    new wkt::ListValue(),
                },
                Stats = new ResultSetStats(),
            };
            mockGrpcClient.Setup(x => x.ExecuteSql(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SpannerClient client = new SpannerClientImpl(mockGrpcClient.Object, null);
            ResultSet response = client.ExecuteSql(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ExecuteSqlRequestObjectAsync()
        {
            moq::Mock<Spanner.SpannerClient> mockGrpcClient = new moq::Mock<Spanner.SpannerClient>(moq::MockBehavior.Strict);
            ExecuteSqlRequest request = new ExecuteSqlRequest
            {
                SessionAsSessionName = SessionName.FromProjectInstanceDatabaseSession("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
                Transaction = new TransactionSelector(),
                Sql = "sqlb6745cac",
                Params = new wkt::Struct(),
                ParamTypes =
                {
                    {
                        "key8a0b6e3c",
                        new Type()
                    },
                },
                ResumeToken = proto::ByteString.CopyFromUtf8("resume_tokena048d43b"),
                QueryMode = ExecuteSqlRequest.Types.QueryMode.Normal,
                PartitionToken = proto::ByteString.CopyFromUtf8("partition_token1309778b"),
                Seqno = 4367695630312265944L,
                QueryOptions = new ExecuteSqlRequest.Types.QueryOptions(),
                RequestOptions = new RequestOptions(),
            };
            ResultSet expectedResponse = new ResultSet
            {
                Metadata = new ResultSetMetadata(),
                Rows =
                {
                    new wkt::ListValue(),
                },
                Stats = new ResultSetStats(),
            };
            mockGrpcClient.Setup(x => x.ExecuteSqlAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ResultSet>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SpannerClient client = new SpannerClientImpl(mockGrpcClient.Object, null);
            ResultSet responseCallSettings = await client.ExecuteSqlAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ResultSet responseCancellationToken = await client.ExecuteSqlAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ExecuteBatchDmlRequestObject()
        {
            moq::Mock<Spanner.SpannerClient> mockGrpcClient = new moq::Mock<Spanner.SpannerClient>(moq::MockBehavior.Strict);
            ExecuteBatchDmlRequest request = new ExecuteBatchDmlRequest
            {
                SessionAsSessionName = SessionName.FromProjectInstanceDatabaseSession("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
                Transaction = new TransactionSelector(),
                Statements =
                {
                    new ExecuteBatchDmlRequest.Types.Statement(),
                },
                Seqno = 4367695630312265944L,
                RequestOptions = new RequestOptions(),
            };
            ExecuteBatchDmlResponse expectedResponse = new ExecuteBatchDmlResponse
            {
                ResultSets = { new ResultSet(), },
                Status = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.ExecuteBatchDml(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SpannerClient client = new SpannerClientImpl(mockGrpcClient.Object, null);
            ExecuteBatchDmlResponse response = client.ExecuteBatchDml(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ExecuteBatchDmlRequestObjectAsync()
        {
            moq::Mock<Spanner.SpannerClient> mockGrpcClient = new moq::Mock<Spanner.SpannerClient>(moq::MockBehavior.Strict);
            ExecuteBatchDmlRequest request = new ExecuteBatchDmlRequest
            {
                SessionAsSessionName = SessionName.FromProjectInstanceDatabaseSession("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
                Transaction = new TransactionSelector(),
                Statements =
                {
                    new ExecuteBatchDmlRequest.Types.Statement(),
                },
                Seqno = 4367695630312265944L,
                RequestOptions = new RequestOptions(),
            };
            ExecuteBatchDmlResponse expectedResponse = new ExecuteBatchDmlResponse
            {
                ResultSets = { new ResultSet(), },
                Status = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.ExecuteBatchDmlAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ExecuteBatchDmlResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SpannerClient client = new SpannerClientImpl(mockGrpcClient.Object, null);
            ExecuteBatchDmlResponse responseCallSettings = await client.ExecuteBatchDmlAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ExecuteBatchDmlResponse responseCancellationToken = await client.ExecuteBatchDmlAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ReadRequestObject()
        {
            moq::Mock<Spanner.SpannerClient> mockGrpcClient = new moq::Mock<Spanner.SpannerClient>(moq::MockBehavior.Strict);
            ReadRequest request = new ReadRequest
            {
                SessionAsSessionName = SessionName.FromProjectInstanceDatabaseSession("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
                Transaction = new TransactionSelector(),
                Table = "tabledee1b9aa",
                Index = "index552d996a",
                Columns = { "columnsa784ca54", },
                KeySet = new KeySet(),
                Limit = 7494001492025909162L,
                ResumeToken = proto::ByteString.CopyFromUtf8("resume_tokena048d43b"),
                PartitionToken = proto::ByteString.CopyFromUtf8("partition_token1309778b"),
                RequestOptions = new RequestOptions(),
            };
            ResultSet expectedResponse = new ResultSet
            {
                Metadata = new ResultSetMetadata(),
                Rows =
                {
                    new wkt::ListValue(),
                },
                Stats = new ResultSetStats(),
            };
            mockGrpcClient.Setup(x => x.Read(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SpannerClient client = new SpannerClientImpl(mockGrpcClient.Object, null);
            ResultSet response = client.Read(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ReadRequestObjectAsync()
        {
            moq::Mock<Spanner.SpannerClient> mockGrpcClient = new moq::Mock<Spanner.SpannerClient>(moq::MockBehavior.Strict);
            ReadRequest request = new ReadRequest
            {
                SessionAsSessionName = SessionName.FromProjectInstanceDatabaseSession("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
                Transaction = new TransactionSelector(),
                Table = "tabledee1b9aa",
                Index = "index552d996a",
                Columns = { "columnsa784ca54", },
                KeySet = new KeySet(),
                Limit = 7494001492025909162L,
                ResumeToken = proto::ByteString.CopyFromUtf8("resume_tokena048d43b"),
                PartitionToken = proto::ByteString.CopyFromUtf8("partition_token1309778b"),
                RequestOptions = new RequestOptions(),
            };
            ResultSet expectedResponse = new ResultSet
            {
                Metadata = new ResultSetMetadata(),
                Rows =
                {
                    new wkt::ListValue(),
                },
                Stats = new ResultSetStats(),
            };
            mockGrpcClient.Setup(x => x.ReadAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ResultSet>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SpannerClient client = new SpannerClientImpl(mockGrpcClient.Object, null);
            ResultSet responseCallSettings = await client.ReadAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ResultSet responseCancellationToken = await client.ReadAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void BeginTransactionRequestObject()
        {
            moq::Mock<Spanner.SpannerClient> mockGrpcClient = new moq::Mock<Spanner.SpannerClient>(moq::MockBehavior.Strict);
            BeginTransactionRequest request = new BeginTransactionRequest
            {
                SessionAsSessionName = SessionName.FromProjectInstanceDatabaseSession("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
                Options = new TransactionOptions(),
                RequestOptions = new RequestOptions(),
            };
            Transaction expectedResponse = new Transaction
            {
                Id = proto::ByteString.CopyFromUtf8("id74b70bb8"),
                ReadTimestamp = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.BeginTransaction(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SpannerClient client = new SpannerClientImpl(mockGrpcClient.Object, null);
            Transaction response = client.BeginTransaction(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task BeginTransactionRequestObjectAsync()
        {
            moq::Mock<Spanner.SpannerClient> mockGrpcClient = new moq::Mock<Spanner.SpannerClient>(moq::MockBehavior.Strict);
            BeginTransactionRequest request = new BeginTransactionRequest
            {
                SessionAsSessionName = SessionName.FromProjectInstanceDatabaseSession("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
                Options = new TransactionOptions(),
                RequestOptions = new RequestOptions(),
            };
            Transaction expectedResponse = new Transaction
            {
                Id = proto::ByteString.CopyFromUtf8("id74b70bb8"),
                ReadTimestamp = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.BeginTransactionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Transaction>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SpannerClient client = new SpannerClientImpl(mockGrpcClient.Object, null);
            Transaction responseCallSettings = await client.BeginTransactionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Transaction responseCancellationToken = await client.BeginTransactionAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void BeginTransaction()
        {
            moq::Mock<Spanner.SpannerClient> mockGrpcClient = new moq::Mock<Spanner.SpannerClient>(moq::MockBehavior.Strict);
            BeginTransactionRequest request = new BeginTransactionRequest
            {
                SessionAsSessionName = SessionName.FromProjectInstanceDatabaseSession("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
                Options = new TransactionOptions(),
            };
            Transaction expectedResponse = new Transaction
            {
                Id = proto::ByteString.CopyFromUtf8("id74b70bb8"),
                ReadTimestamp = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.BeginTransaction(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SpannerClient client = new SpannerClientImpl(mockGrpcClient.Object, null);
            Transaction response = client.BeginTransaction(request.Session, request.Options);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task BeginTransactionAsync()
        {
            moq::Mock<Spanner.SpannerClient> mockGrpcClient = new moq::Mock<Spanner.SpannerClient>(moq::MockBehavior.Strict);
            BeginTransactionRequest request = new BeginTransactionRequest
            {
                SessionAsSessionName = SessionName.FromProjectInstanceDatabaseSession("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
                Options = new TransactionOptions(),
            };
            Transaction expectedResponse = new Transaction
            {
                Id = proto::ByteString.CopyFromUtf8("id74b70bb8"),
                ReadTimestamp = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.BeginTransactionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Transaction>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SpannerClient client = new SpannerClientImpl(mockGrpcClient.Object, null);
            Transaction responseCallSettings = await client.BeginTransactionAsync(request.Session, request.Options, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Transaction responseCancellationToken = await client.BeginTransactionAsync(request.Session, request.Options, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void BeginTransactionResourceNames()
        {
            moq::Mock<Spanner.SpannerClient> mockGrpcClient = new moq::Mock<Spanner.SpannerClient>(moq::MockBehavior.Strict);
            BeginTransactionRequest request = new BeginTransactionRequest
            {
                SessionAsSessionName = SessionName.FromProjectInstanceDatabaseSession("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
                Options = new TransactionOptions(),
            };
            Transaction expectedResponse = new Transaction
            {
                Id = proto::ByteString.CopyFromUtf8("id74b70bb8"),
                ReadTimestamp = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.BeginTransaction(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SpannerClient client = new SpannerClientImpl(mockGrpcClient.Object, null);
            Transaction response = client.BeginTransaction(request.SessionAsSessionName, request.Options);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task BeginTransactionResourceNamesAsync()
        {
            moq::Mock<Spanner.SpannerClient> mockGrpcClient = new moq::Mock<Spanner.SpannerClient>(moq::MockBehavior.Strict);
            BeginTransactionRequest request = new BeginTransactionRequest
            {
                SessionAsSessionName = SessionName.FromProjectInstanceDatabaseSession("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
                Options = new TransactionOptions(),
            };
            Transaction expectedResponse = new Transaction
            {
                Id = proto::ByteString.CopyFromUtf8("id74b70bb8"),
                ReadTimestamp = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.BeginTransactionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Transaction>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SpannerClient client = new SpannerClientImpl(mockGrpcClient.Object, null);
            Transaction responseCallSettings = await client.BeginTransactionAsync(request.SessionAsSessionName, request.Options, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Transaction responseCancellationToken = await client.BeginTransactionAsync(request.SessionAsSessionName, request.Options, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CommitRequestObject()
        {
            moq::Mock<Spanner.SpannerClient> mockGrpcClient = new moq::Mock<Spanner.SpannerClient>(moq::MockBehavior.Strict);
            CommitRequest request = new CommitRequest
            {
                SessionAsSessionName = SessionName.FromProjectInstanceDatabaseSession("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
                TransactionId = proto::ByteString.CopyFromUtf8("transaction_id52de47f8"),
                SingleUseTransaction = new TransactionOptions(),
                Mutations = { new Mutation(), },
                ReturnCommitStats = false,
                RequestOptions = new RequestOptions(),
            };
            CommitResponse expectedResponse = new CommitResponse
            {
                CommitTimestamp = new wkt::Timestamp(),
                CommitStats = new CommitResponse.Types.CommitStats(),
            };
            mockGrpcClient.Setup(x => x.Commit(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SpannerClient client = new SpannerClientImpl(mockGrpcClient.Object, null);
            CommitResponse response = client.Commit(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CommitRequestObjectAsync()
        {
            moq::Mock<Spanner.SpannerClient> mockGrpcClient = new moq::Mock<Spanner.SpannerClient>(moq::MockBehavior.Strict);
            CommitRequest request = new CommitRequest
            {
                SessionAsSessionName = SessionName.FromProjectInstanceDatabaseSession("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
                TransactionId = proto::ByteString.CopyFromUtf8("transaction_id52de47f8"),
                SingleUseTransaction = new TransactionOptions(),
                Mutations = { new Mutation(), },
                ReturnCommitStats = false,
                RequestOptions = new RequestOptions(),
            };
            CommitResponse expectedResponse = new CommitResponse
            {
                CommitTimestamp = new wkt::Timestamp(),
                CommitStats = new CommitResponse.Types.CommitStats(),
            };
            mockGrpcClient.Setup(x => x.CommitAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CommitResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SpannerClient client = new SpannerClientImpl(mockGrpcClient.Object, null);
            CommitResponse responseCallSettings = await client.CommitAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CommitResponse responseCancellationToken = await client.CommitAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Commit1()
        {
            moq::Mock<Spanner.SpannerClient> mockGrpcClient = new moq::Mock<Spanner.SpannerClient>(moq::MockBehavior.Strict);
            CommitRequest request = new CommitRequest
            {
                SessionAsSessionName = SessionName.FromProjectInstanceDatabaseSession("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
                TransactionId = proto::ByteString.CopyFromUtf8("transaction_id52de47f8"),
                Mutations = { new Mutation(), },
            };
            CommitResponse expectedResponse = new CommitResponse
            {
                CommitTimestamp = new wkt::Timestamp(),
                CommitStats = new CommitResponse.Types.CommitStats(),
            };
            mockGrpcClient.Setup(x => x.Commit(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SpannerClient client = new SpannerClientImpl(mockGrpcClient.Object, null);
            CommitResponse response = client.Commit(request.Session, request.TransactionId, request.Mutations);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task Commit1Async()
        {
            moq::Mock<Spanner.SpannerClient> mockGrpcClient = new moq::Mock<Spanner.SpannerClient>(moq::MockBehavior.Strict);
            CommitRequest request = new CommitRequest
            {
                SessionAsSessionName = SessionName.FromProjectInstanceDatabaseSession("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
                TransactionId = proto::ByteString.CopyFromUtf8("transaction_id52de47f8"),
                Mutations = { new Mutation(), },
            };
            CommitResponse expectedResponse = new CommitResponse
            {
                CommitTimestamp = new wkt::Timestamp(),
                CommitStats = new CommitResponse.Types.CommitStats(),
            };
            mockGrpcClient.Setup(x => x.CommitAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CommitResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SpannerClient client = new SpannerClientImpl(mockGrpcClient.Object, null);
            CommitResponse responseCallSettings = await client.CommitAsync(request.Session, request.TransactionId, request.Mutations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CommitResponse responseCancellationToken = await client.CommitAsync(request.Session, request.TransactionId, request.Mutations, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Commit1ResourceNames()
        {
            moq::Mock<Spanner.SpannerClient> mockGrpcClient = new moq::Mock<Spanner.SpannerClient>(moq::MockBehavior.Strict);
            CommitRequest request = new CommitRequest
            {
                SessionAsSessionName = SessionName.FromProjectInstanceDatabaseSession("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
                TransactionId = proto::ByteString.CopyFromUtf8("transaction_id52de47f8"),
                Mutations = { new Mutation(), },
            };
            CommitResponse expectedResponse = new CommitResponse
            {
                CommitTimestamp = new wkt::Timestamp(),
                CommitStats = new CommitResponse.Types.CommitStats(),
            };
            mockGrpcClient.Setup(x => x.Commit(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SpannerClient client = new SpannerClientImpl(mockGrpcClient.Object, null);
            CommitResponse response = client.Commit(request.SessionAsSessionName, request.TransactionId, request.Mutations);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task Commit1ResourceNamesAsync()
        {
            moq::Mock<Spanner.SpannerClient> mockGrpcClient = new moq::Mock<Spanner.SpannerClient>(moq::MockBehavior.Strict);
            CommitRequest request = new CommitRequest
            {
                SessionAsSessionName = SessionName.FromProjectInstanceDatabaseSession("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
                TransactionId = proto::ByteString.CopyFromUtf8("transaction_id52de47f8"),
                Mutations = { new Mutation(), },
            };
            CommitResponse expectedResponse = new CommitResponse
            {
                CommitTimestamp = new wkt::Timestamp(),
                CommitStats = new CommitResponse.Types.CommitStats(),
            };
            mockGrpcClient.Setup(x => x.CommitAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CommitResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SpannerClient client = new SpannerClientImpl(mockGrpcClient.Object, null);
            CommitResponse responseCallSettings = await client.CommitAsync(request.SessionAsSessionName, request.TransactionId, request.Mutations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CommitResponse responseCancellationToken = await client.CommitAsync(request.SessionAsSessionName, request.TransactionId, request.Mutations, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Commit2()
        {
            moq::Mock<Spanner.SpannerClient> mockGrpcClient = new moq::Mock<Spanner.SpannerClient>(moq::MockBehavior.Strict);
            CommitRequest request = new CommitRequest
            {
                SessionAsSessionName = SessionName.FromProjectInstanceDatabaseSession("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
                SingleUseTransaction = new TransactionOptions(),
                Mutations = { new Mutation(), },
            };
            CommitResponse expectedResponse = new CommitResponse
            {
                CommitTimestamp = new wkt::Timestamp(),
                CommitStats = new CommitResponse.Types.CommitStats(),
            };
            mockGrpcClient.Setup(x => x.Commit(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SpannerClient client = new SpannerClientImpl(mockGrpcClient.Object, null);
            CommitResponse response = client.Commit(request.Session, request.SingleUseTransaction, request.Mutations);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task Commit2Async()
        {
            moq::Mock<Spanner.SpannerClient> mockGrpcClient = new moq::Mock<Spanner.SpannerClient>(moq::MockBehavior.Strict);
            CommitRequest request = new CommitRequest
            {
                SessionAsSessionName = SessionName.FromProjectInstanceDatabaseSession("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
                SingleUseTransaction = new TransactionOptions(),
                Mutations = { new Mutation(), },
            };
            CommitResponse expectedResponse = new CommitResponse
            {
                CommitTimestamp = new wkt::Timestamp(),
                CommitStats = new CommitResponse.Types.CommitStats(),
            };
            mockGrpcClient.Setup(x => x.CommitAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CommitResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SpannerClient client = new SpannerClientImpl(mockGrpcClient.Object, null);
            CommitResponse responseCallSettings = await client.CommitAsync(request.Session, request.SingleUseTransaction, request.Mutations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CommitResponse responseCancellationToken = await client.CommitAsync(request.Session, request.SingleUseTransaction, request.Mutations, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Commit2ResourceNames()
        {
            moq::Mock<Spanner.SpannerClient> mockGrpcClient = new moq::Mock<Spanner.SpannerClient>(moq::MockBehavior.Strict);
            CommitRequest request = new CommitRequest
            {
                SessionAsSessionName = SessionName.FromProjectInstanceDatabaseSession("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
                SingleUseTransaction = new TransactionOptions(),
                Mutations = { new Mutation(), },
            };
            CommitResponse expectedResponse = new CommitResponse
            {
                CommitTimestamp = new wkt::Timestamp(),
                CommitStats = new CommitResponse.Types.CommitStats(),
            };
            mockGrpcClient.Setup(x => x.Commit(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SpannerClient client = new SpannerClientImpl(mockGrpcClient.Object, null);
            CommitResponse response = client.Commit(request.SessionAsSessionName, request.SingleUseTransaction, request.Mutations);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task Commit2ResourceNamesAsync()
        {
            moq::Mock<Spanner.SpannerClient> mockGrpcClient = new moq::Mock<Spanner.SpannerClient>(moq::MockBehavior.Strict);
            CommitRequest request = new CommitRequest
            {
                SessionAsSessionName = SessionName.FromProjectInstanceDatabaseSession("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
                SingleUseTransaction = new TransactionOptions(),
                Mutations = { new Mutation(), },
            };
            CommitResponse expectedResponse = new CommitResponse
            {
                CommitTimestamp = new wkt::Timestamp(),
                CommitStats = new CommitResponse.Types.CommitStats(),
            };
            mockGrpcClient.Setup(x => x.CommitAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CommitResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SpannerClient client = new SpannerClientImpl(mockGrpcClient.Object, null);
            CommitResponse responseCallSettings = await client.CommitAsync(request.SessionAsSessionName, request.SingleUseTransaction, request.Mutations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CommitResponse responseCancellationToken = await client.CommitAsync(request.SessionAsSessionName, request.SingleUseTransaction, request.Mutations, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void RollbackRequestObject()
        {
            moq::Mock<Spanner.SpannerClient> mockGrpcClient = new moq::Mock<Spanner.SpannerClient>(moq::MockBehavior.Strict);
            RollbackRequest request = new RollbackRequest
            {
                SessionAsSessionName = SessionName.FromProjectInstanceDatabaseSession("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
                TransactionId = proto::ByteString.CopyFromUtf8("transaction_id52de47f8"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.Rollback(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SpannerClient client = new SpannerClientImpl(mockGrpcClient.Object, null);
            client.Rollback(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task RollbackRequestObjectAsync()
        {
            moq::Mock<Spanner.SpannerClient> mockGrpcClient = new moq::Mock<Spanner.SpannerClient>(moq::MockBehavior.Strict);
            RollbackRequest request = new RollbackRequest
            {
                SessionAsSessionName = SessionName.FromProjectInstanceDatabaseSession("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
                TransactionId = proto::ByteString.CopyFromUtf8("transaction_id52de47f8"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.RollbackAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SpannerClient client = new SpannerClientImpl(mockGrpcClient.Object, null);
            await client.RollbackAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.RollbackAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Rollback()
        {
            moq::Mock<Spanner.SpannerClient> mockGrpcClient = new moq::Mock<Spanner.SpannerClient>(moq::MockBehavior.Strict);
            RollbackRequest request = new RollbackRequest
            {
                SessionAsSessionName = SessionName.FromProjectInstanceDatabaseSession("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
                TransactionId = proto::ByteString.CopyFromUtf8("transaction_id52de47f8"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.Rollback(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SpannerClient client = new SpannerClientImpl(mockGrpcClient.Object, null);
            client.Rollback(request.Session, request.TransactionId);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task RollbackAsync()
        {
            moq::Mock<Spanner.SpannerClient> mockGrpcClient = new moq::Mock<Spanner.SpannerClient>(moq::MockBehavior.Strict);
            RollbackRequest request = new RollbackRequest
            {
                SessionAsSessionName = SessionName.FromProjectInstanceDatabaseSession("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
                TransactionId = proto::ByteString.CopyFromUtf8("transaction_id52de47f8"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.RollbackAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SpannerClient client = new SpannerClientImpl(mockGrpcClient.Object, null);
            await client.RollbackAsync(request.Session, request.TransactionId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.RollbackAsync(request.Session, request.TransactionId, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void RollbackResourceNames()
        {
            moq::Mock<Spanner.SpannerClient> mockGrpcClient = new moq::Mock<Spanner.SpannerClient>(moq::MockBehavior.Strict);
            RollbackRequest request = new RollbackRequest
            {
                SessionAsSessionName = SessionName.FromProjectInstanceDatabaseSession("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
                TransactionId = proto::ByteString.CopyFromUtf8("transaction_id52de47f8"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.Rollback(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SpannerClient client = new SpannerClientImpl(mockGrpcClient.Object, null);
            client.Rollback(request.SessionAsSessionName, request.TransactionId);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task RollbackResourceNamesAsync()
        {
            moq::Mock<Spanner.SpannerClient> mockGrpcClient = new moq::Mock<Spanner.SpannerClient>(moq::MockBehavior.Strict);
            RollbackRequest request = new RollbackRequest
            {
                SessionAsSessionName = SessionName.FromProjectInstanceDatabaseSession("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
                TransactionId = proto::ByteString.CopyFromUtf8("transaction_id52de47f8"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.RollbackAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SpannerClient client = new SpannerClientImpl(mockGrpcClient.Object, null);
            await client.RollbackAsync(request.SessionAsSessionName, request.TransactionId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.RollbackAsync(request.SessionAsSessionName, request.TransactionId, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void PartitionQueryRequestObject()
        {
            moq::Mock<Spanner.SpannerClient> mockGrpcClient = new moq::Mock<Spanner.SpannerClient>(moq::MockBehavior.Strict);
            PartitionQueryRequest request = new PartitionQueryRequest
            {
                SessionAsSessionName = SessionName.FromProjectInstanceDatabaseSession("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
                Transaction = new TransactionSelector(),
                Sql = "sqlb6745cac",
                Params = new wkt::Struct(),
                ParamTypes =
                {
                    {
                        "key8a0b6e3c",
                        new Type()
                    },
                },
                PartitionOptions = new PartitionOptions(),
            };
            PartitionResponse expectedResponse = new PartitionResponse
            {
                Partitions = { new Partition(), },
                Transaction = new Transaction(),
            };
            mockGrpcClient.Setup(x => x.PartitionQuery(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SpannerClient client = new SpannerClientImpl(mockGrpcClient.Object, null);
            PartitionResponse response = client.PartitionQuery(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task PartitionQueryRequestObjectAsync()
        {
            moq::Mock<Spanner.SpannerClient> mockGrpcClient = new moq::Mock<Spanner.SpannerClient>(moq::MockBehavior.Strict);
            PartitionQueryRequest request = new PartitionQueryRequest
            {
                SessionAsSessionName = SessionName.FromProjectInstanceDatabaseSession("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
                Transaction = new TransactionSelector(),
                Sql = "sqlb6745cac",
                Params = new wkt::Struct(),
                ParamTypes =
                {
                    {
                        "key8a0b6e3c",
                        new Type()
                    },
                },
                PartitionOptions = new PartitionOptions(),
            };
            PartitionResponse expectedResponse = new PartitionResponse
            {
                Partitions = { new Partition(), },
                Transaction = new Transaction(),
            };
            mockGrpcClient.Setup(x => x.PartitionQueryAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PartitionResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SpannerClient client = new SpannerClientImpl(mockGrpcClient.Object, null);
            PartitionResponse responseCallSettings = await client.PartitionQueryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PartitionResponse responseCancellationToken = await client.PartitionQueryAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void PartitionReadRequestObject()
        {
            moq::Mock<Spanner.SpannerClient> mockGrpcClient = new moq::Mock<Spanner.SpannerClient>(moq::MockBehavior.Strict);
            PartitionReadRequest request = new PartitionReadRequest
            {
                SessionAsSessionName = SessionName.FromProjectInstanceDatabaseSession("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
                Transaction = new TransactionSelector(),
                Table = "tabledee1b9aa",
                Index = "index552d996a",
                Columns = { "columnsa784ca54", },
                KeySet = new KeySet(),
                PartitionOptions = new PartitionOptions(),
            };
            PartitionResponse expectedResponse = new PartitionResponse
            {
                Partitions = { new Partition(), },
                Transaction = new Transaction(),
            };
            mockGrpcClient.Setup(x => x.PartitionRead(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SpannerClient client = new SpannerClientImpl(mockGrpcClient.Object, null);
            PartitionResponse response = client.PartitionRead(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task PartitionReadRequestObjectAsync()
        {
            moq::Mock<Spanner.SpannerClient> mockGrpcClient = new moq::Mock<Spanner.SpannerClient>(moq::MockBehavior.Strict);
            PartitionReadRequest request = new PartitionReadRequest
            {
                SessionAsSessionName = SessionName.FromProjectInstanceDatabaseSession("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
                Transaction = new TransactionSelector(),
                Table = "tabledee1b9aa",
                Index = "index552d996a",
                Columns = { "columnsa784ca54", },
                KeySet = new KeySet(),
                PartitionOptions = new PartitionOptions(),
            };
            PartitionResponse expectedResponse = new PartitionResponse
            {
                Partitions = { new Partition(), },
                Transaction = new Transaction(),
            };
            mockGrpcClient.Setup(x => x.PartitionReadAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PartitionResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SpannerClient client = new SpannerClientImpl(mockGrpcClient.Object, null);
            PartitionResponse responseCallSettings = await client.PartitionReadAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PartitionResponse responseCancellationToken = await client.PartitionReadAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
