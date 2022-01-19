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
using gagr = Google.Api.Gax.ResourceNames;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.BigQuery.Storage.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedBigQueryReadClientTest
    {
        [xunit::FactAttribute]
        public void CreateReadSessionRequestObject()
        {
            moq::Mock<BigQueryRead.BigQueryReadClient> mockGrpcClient = new moq::Mock<BigQueryRead.BigQueryReadClient>(moq::MockBehavior.Strict);
            CreateReadSessionRequest request = new CreateReadSessionRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                ReadSession = new ReadSession(),
                MaxStreamCount = 1813871107,
            };
            ReadSession expectedResponse = new ReadSession
            {
                ReadSessionName = ReadSessionName.FromProjectLocationSession("[PROJECT]", "[LOCATION]", "[SESSION]"),
                ExpireTime = new wkt::Timestamp(),
                DataFormat = DataFormat.Arrow,
                AvroSchema = new AvroSchema(),
                ArrowSchema = new ArrowSchema(),
                TableAsTableName = TableName.FromProjectDatasetTable("[PROJECT]", "[DATASET]", "[TABLE]"),
                TableModifiers = new ReadSession.Types.TableModifiers(),
                ReadOptions = new ReadSession.Types.TableReadOptions(),
                Streams = { new ReadStream(), },
                EstimatedTotalBytesScanned = 3051848153574264650L,
            };
            mockGrpcClient.Setup(x => x.CreateReadSession(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BigQueryReadClient client = new BigQueryReadClientImpl(mockGrpcClient.Object, null);
            ReadSession response = client.CreateReadSession(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateReadSessionRequestObjectAsync()
        {
            moq::Mock<BigQueryRead.BigQueryReadClient> mockGrpcClient = new moq::Mock<BigQueryRead.BigQueryReadClient>(moq::MockBehavior.Strict);
            CreateReadSessionRequest request = new CreateReadSessionRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                ReadSession = new ReadSession(),
                MaxStreamCount = 1813871107,
            };
            ReadSession expectedResponse = new ReadSession
            {
                ReadSessionName = ReadSessionName.FromProjectLocationSession("[PROJECT]", "[LOCATION]", "[SESSION]"),
                ExpireTime = new wkt::Timestamp(),
                DataFormat = DataFormat.Arrow,
                AvroSchema = new AvroSchema(),
                ArrowSchema = new ArrowSchema(),
                TableAsTableName = TableName.FromProjectDatasetTable("[PROJECT]", "[DATASET]", "[TABLE]"),
                TableModifiers = new ReadSession.Types.TableModifiers(),
                ReadOptions = new ReadSession.Types.TableReadOptions(),
                Streams = { new ReadStream(), },
                EstimatedTotalBytesScanned = 3051848153574264650L,
            };
            mockGrpcClient.Setup(x => x.CreateReadSessionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ReadSession>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BigQueryReadClient client = new BigQueryReadClientImpl(mockGrpcClient.Object, null);
            ReadSession responseCallSettings = await client.CreateReadSessionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ReadSession responseCancellationToken = await client.CreateReadSessionAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateReadSession()
        {
            moq::Mock<BigQueryRead.BigQueryReadClient> mockGrpcClient = new moq::Mock<BigQueryRead.BigQueryReadClient>(moq::MockBehavior.Strict);
            CreateReadSessionRequest request = new CreateReadSessionRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                ReadSession = new ReadSession(),
                MaxStreamCount = 1813871107,
            };
            ReadSession expectedResponse = new ReadSession
            {
                ReadSessionName = ReadSessionName.FromProjectLocationSession("[PROJECT]", "[LOCATION]", "[SESSION]"),
                ExpireTime = new wkt::Timestamp(),
                DataFormat = DataFormat.Arrow,
                AvroSchema = new AvroSchema(),
                ArrowSchema = new ArrowSchema(),
                TableAsTableName = TableName.FromProjectDatasetTable("[PROJECT]", "[DATASET]", "[TABLE]"),
                TableModifiers = new ReadSession.Types.TableModifiers(),
                ReadOptions = new ReadSession.Types.TableReadOptions(),
                Streams = { new ReadStream(), },
                EstimatedTotalBytesScanned = 3051848153574264650L,
            };
            mockGrpcClient.Setup(x => x.CreateReadSession(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BigQueryReadClient client = new BigQueryReadClientImpl(mockGrpcClient.Object, null);
            ReadSession response = client.CreateReadSession(request.Parent, request.ReadSession, request.MaxStreamCount);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateReadSessionAsync()
        {
            moq::Mock<BigQueryRead.BigQueryReadClient> mockGrpcClient = new moq::Mock<BigQueryRead.BigQueryReadClient>(moq::MockBehavior.Strict);
            CreateReadSessionRequest request = new CreateReadSessionRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                ReadSession = new ReadSession(),
                MaxStreamCount = 1813871107,
            };
            ReadSession expectedResponse = new ReadSession
            {
                ReadSessionName = ReadSessionName.FromProjectLocationSession("[PROJECT]", "[LOCATION]", "[SESSION]"),
                ExpireTime = new wkt::Timestamp(),
                DataFormat = DataFormat.Arrow,
                AvroSchema = new AvroSchema(),
                ArrowSchema = new ArrowSchema(),
                TableAsTableName = TableName.FromProjectDatasetTable("[PROJECT]", "[DATASET]", "[TABLE]"),
                TableModifiers = new ReadSession.Types.TableModifiers(),
                ReadOptions = new ReadSession.Types.TableReadOptions(),
                Streams = { new ReadStream(), },
                EstimatedTotalBytesScanned = 3051848153574264650L,
            };
            mockGrpcClient.Setup(x => x.CreateReadSessionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ReadSession>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BigQueryReadClient client = new BigQueryReadClientImpl(mockGrpcClient.Object, null);
            ReadSession responseCallSettings = await client.CreateReadSessionAsync(request.Parent, request.ReadSession, request.MaxStreamCount, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ReadSession responseCancellationToken = await client.CreateReadSessionAsync(request.Parent, request.ReadSession, request.MaxStreamCount, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateReadSessionResourceNames()
        {
            moq::Mock<BigQueryRead.BigQueryReadClient> mockGrpcClient = new moq::Mock<BigQueryRead.BigQueryReadClient>(moq::MockBehavior.Strict);
            CreateReadSessionRequest request = new CreateReadSessionRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                ReadSession = new ReadSession(),
                MaxStreamCount = 1813871107,
            };
            ReadSession expectedResponse = new ReadSession
            {
                ReadSessionName = ReadSessionName.FromProjectLocationSession("[PROJECT]", "[LOCATION]", "[SESSION]"),
                ExpireTime = new wkt::Timestamp(),
                DataFormat = DataFormat.Arrow,
                AvroSchema = new AvroSchema(),
                ArrowSchema = new ArrowSchema(),
                TableAsTableName = TableName.FromProjectDatasetTable("[PROJECT]", "[DATASET]", "[TABLE]"),
                TableModifiers = new ReadSession.Types.TableModifiers(),
                ReadOptions = new ReadSession.Types.TableReadOptions(),
                Streams = { new ReadStream(), },
                EstimatedTotalBytesScanned = 3051848153574264650L,
            };
            mockGrpcClient.Setup(x => x.CreateReadSession(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BigQueryReadClient client = new BigQueryReadClientImpl(mockGrpcClient.Object, null);
            ReadSession response = client.CreateReadSession(request.ParentAsProjectName, request.ReadSession, request.MaxStreamCount);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateReadSessionResourceNamesAsync()
        {
            moq::Mock<BigQueryRead.BigQueryReadClient> mockGrpcClient = new moq::Mock<BigQueryRead.BigQueryReadClient>(moq::MockBehavior.Strict);
            CreateReadSessionRequest request = new CreateReadSessionRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                ReadSession = new ReadSession(),
                MaxStreamCount = 1813871107,
            };
            ReadSession expectedResponse = new ReadSession
            {
                ReadSessionName = ReadSessionName.FromProjectLocationSession("[PROJECT]", "[LOCATION]", "[SESSION]"),
                ExpireTime = new wkt::Timestamp(),
                DataFormat = DataFormat.Arrow,
                AvroSchema = new AvroSchema(),
                ArrowSchema = new ArrowSchema(),
                TableAsTableName = TableName.FromProjectDatasetTable("[PROJECT]", "[DATASET]", "[TABLE]"),
                TableModifiers = new ReadSession.Types.TableModifiers(),
                ReadOptions = new ReadSession.Types.TableReadOptions(),
                Streams = { new ReadStream(), },
                EstimatedTotalBytesScanned = 3051848153574264650L,
            };
            mockGrpcClient.Setup(x => x.CreateReadSessionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ReadSession>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BigQueryReadClient client = new BigQueryReadClientImpl(mockGrpcClient.Object, null);
            ReadSession responseCallSettings = await client.CreateReadSessionAsync(request.ParentAsProjectName, request.ReadSession, request.MaxStreamCount, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ReadSession responseCancellationToken = await client.CreateReadSessionAsync(request.ParentAsProjectName, request.ReadSession, request.MaxStreamCount, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SplitReadStreamRequestObject()
        {
            moq::Mock<BigQueryRead.BigQueryReadClient> mockGrpcClient = new moq::Mock<BigQueryRead.BigQueryReadClient>(moq::MockBehavior.Strict);
            SplitReadStreamRequest request = new SplitReadStreamRequest
            {
                ReadStreamName = ReadStreamName.FromProjectLocationSessionStream("[PROJECT]", "[LOCATION]", "[SESSION]", "[STREAM]"),
                Fraction = 6.953526182705065E+17,
            };
            SplitReadStreamResponse expectedResponse = new SplitReadStreamResponse
            {
                PrimaryStream = new ReadStream(),
                RemainderStream = new ReadStream(),
            };
            mockGrpcClient.Setup(x => x.SplitReadStream(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BigQueryReadClient client = new BigQueryReadClientImpl(mockGrpcClient.Object, null);
            SplitReadStreamResponse response = client.SplitReadStream(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SplitReadStreamRequestObjectAsync()
        {
            moq::Mock<BigQueryRead.BigQueryReadClient> mockGrpcClient = new moq::Mock<BigQueryRead.BigQueryReadClient>(moq::MockBehavior.Strict);
            SplitReadStreamRequest request = new SplitReadStreamRequest
            {
                ReadStreamName = ReadStreamName.FromProjectLocationSessionStream("[PROJECT]", "[LOCATION]", "[SESSION]", "[STREAM]"),
                Fraction = 6.953526182705065E+17,
            };
            SplitReadStreamResponse expectedResponse = new SplitReadStreamResponse
            {
                PrimaryStream = new ReadStream(),
                RemainderStream = new ReadStream(),
            };
            mockGrpcClient.Setup(x => x.SplitReadStreamAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SplitReadStreamResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BigQueryReadClient client = new BigQueryReadClientImpl(mockGrpcClient.Object, null);
            SplitReadStreamResponse responseCallSettings = await client.SplitReadStreamAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SplitReadStreamResponse responseCancellationToken = await client.SplitReadStreamAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
