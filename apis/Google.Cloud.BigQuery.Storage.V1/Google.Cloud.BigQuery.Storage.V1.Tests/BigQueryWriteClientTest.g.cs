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

#pragma warning disable CS8981
using gaxgrpc = Google.Api.Gax.Grpc;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.BigQuery.Storage.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedBigQueryWriteClientTest
    {
        [xunit::FactAttribute]
        public void CreateWriteStreamRequestObject()
        {
            moq::Mock<BigQueryWrite.BigQueryWriteClient> mockGrpcClient = new moq::Mock<BigQueryWrite.BigQueryWriteClient>(moq::MockBehavior.Strict);
            CreateWriteStreamRequest request = new CreateWriteStreamRequest
            {
                ParentAsTableName = TableName.FromProjectDatasetTable("[PROJECT]", "[DATASET]", "[TABLE]"),
                WriteStream = new WriteStream(),
            };
            WriteStream expectedResponse = new WriteStream
            {
                WriteStreamName = WriteStreamName.FromProjectDatasetTableStream("[PROJECT]", "[DATASET]", "[TABLE]", "[STREAM]"),
                Type = WriteStream.Types.Type.Buffered,
                CreateTime = new wkt::Timestamp(),
                CommitTime = new wkt::Timestamp(),
                TableSchema = new TableSchema(),
                WriteMode = WriteStream.Types.WriteMode.Unspecified,
            };
            mockGrpcClient.Setup(x => x.CreateWriteStream(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BigQueryWriteClient client = new BigQueryWriteClientImpl(mockGrpcClient.Object, null, null);
            WriteStream response = client.CreateWriteStream(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateWriteStreamRequestObjectAsync()
        {
            moq::Mock<BigQueryWrite.BigQueryWriteClient> mockGrpcClient = new moq::Mock<BigQueryWrite.BigQueryWriteClient>(moq::MockBehavior.Strict);
            CreateWriteStreamRequest request = new CreateWriteStreamRequest
            {
                ParentAsTableName = TableName.FromProjectDatasetTable("[PROJECT]", "[DATASET]", "[TABLE]"),
                WriteStream = new WriteStream(),
            };
            WriteStream expectedResponse = new WriteStream
            {
                WriteStreamName = WriteStreamName.FromProjectDatasetTableStream("[PROJECT]", "[DATASET]", "[TABLE]", "[STREAM]"),
                Type = WriteStream.Types.Type.Buffered,
                CreateTime = new wkt::Timestamp(),
                CommitTime = new wkt::Timestamp(),
                TableSchema = new TableSchema(),
                WriteMode = WriteStream.Types.WriteMode.Unspecified,
            };
            mockGrpcClient.Setup(x => x.CreateWriteStreamAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<WriteStream>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BigQueryWriteClient client = new BigQueryWriteClientImpl(mockGrpcClient.Object, null, null);
            WriteStream responseCallSettings = await client.CreateWriteStreamAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            WriteStream responseCancellationToken = await client.CreateWriteStreamAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateWriteStream()
        {
            moq::Mock<BigQueryWrite.BigQueryWriteClient> mockGrpcClient = new moq::Mock<BigQueryWrite.BigQueryWriteClient>(moq::MockBehavior.Strict);
            CreateWriteStreamRequest request = new CreateWriteStreamRequest
            {
                ParentAsTableName = TableName.FromProjectDatasetTable("[PROJECT]", "[DATASET]", "[TABLE]"),
                WriteStream = new WriteStream(),
            };
            WriteStream expectedResponse = new WriteStream
            {
                WriteStreamName = WriteStreamName.FromProjectDatasetTableStream("[PROJECT]", "[DATASET]", "[TABLE]", "[STREAM]"),
                Type = WriteStream.Types.Type.Buffered,
                CreateTime = new wkt::Timestamp(),
                CommitTime = new wkt::Timestamp(),
                TableSchema = new TableSchema(),
                WriteMode = WriteStream.Types.WriteMode.Unspecified,
            };
            mockGrpcClient.Setup(x => x.CreateWriteStream(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BigQueryWriteClient client = new BigQueryWriteClientImpl(mockGrpcClient.Object, null, null);
            WriteStream response = client.CreateWriteStream(request.Parent, request.WriteStream);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateWriteStreamAsync()
        {
            moq::Mock<BigQueryWrite.BigQueryWriteClient> mockGrpcClient = new moq::Mock<BigQueryWrite.BigQueryWriteClient>(moq::MockBehavior.Strict);
            CreateWriteStreamRequest request = new CreateWriteStreamRequest
            {
                ParentAsTableName = TableName.FromProjectDatasetTable("[PROJECT]", "[DATASET]", "[TABLE]"),
                WriteStream = new WriteStream(),
            };
            WriteStream expectedResponse = new WriteStream
            {
                WriteStreamName = WriteStreamName.FromProjectDatasetTableStream("[PROJECT]", "[DATASET]", "[TABLE]", "[STREAM]"),
                Type = WriteStream.Types.Type.Buffered,
                CreateTime = new wkt::Timestamp(),
                CommitTime = new wkt::Timestamp(),
                TableSchema = new TableSchema(),
                WriteMode = WriteStream.Types.WriteMode.Unspecified,
            };
            mockGrpcClient.Setup(x => x.CreateWriteStreamAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<WriteStream>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BigQueryWriteClient client = new BigQueryWriteClientImpl(mockGrpcClient.Object, null, null);
            WriteStream responseCallSettings = await client.CreateWriteStreamAsync(request.Parent, request.WriteStream, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            WriteStream responseCancellationToken = await client.CreateWriteStreamAsync(request.Parent, request.WriteStream, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateWriteStreamResourceNames()
        {
            moq::Mock<BigQueryWrite.BigQueryWriteClient> mockGrpcClient = new moq::Mock<BigQueryWrite.BigQueryWriteClient>(moq::MockBehavior.Strict);
            CreateWriteStreamRequest request = new CreateWriteStreamRequest
            {
                ParentAsTableName = TableName.FromProjectDatasetTable("[PROJECT]", "[DATASET]", "[TABLE]"),
                WriteStream = new WriteStream(),
            };
            WriteStream expectedResponse = new WriteStream
            {
                WriteStreamName = WriteStreamName.FromProjectDatasetTableStream("[PROJECT]", "[DATASET]", "[TABLE]", "[STREAM]"),
                Type = WriteStream.Types.Type.Buffered,
                CreateTime = new wkt::Timestamp(),
                CommitTime = new wkt::Timestamp(),
                TableSchema = new TableSchema(),
                WriteMode = WriteStream.Types.WriteMode.Unspecified,
            };
            mockGrpcClient.Setup(x => x.CreateWriteStream(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BigQueryWriteClient client = new BigQueryWriteClientImpl(mockGrpcClient.Object, null, null);
            WriteStream response = client.CreateWriteStream(request.ParentAsTableName, request.WriteStream);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateWriteStreamResourceNamesAsync()
        {
            moq::Mock<BigQueryWrite.BigQueryWriteClient> mockGrpcClient = new moq::Mock<BigQueryWrite.BigQueryWriteClient>(moq::MockBehavior.Strict);
            CreateWriteStreamRequest request = new CreateWriteStreamRequest
            {
                ParentAsTableName = TableName.FromProjectDatasetTable("[PROJECT]", "[DATASET]", "[TABLE]"),
                WriteStream = new WriteStream(),
            };
            WriteStream expectedResponse = new WriteStream
            {
                WriteStreamName = WriteStreamName.FromProjectDatasetTableStream("[PROJECT]", "[DATASET]", "[TABLE]", "[STREAM]"),
                Type = WriteStream.Types.Type.Buffered,
                CreateTime = new wkt::Timestamp(),
                CommitTime = new wkt::Timestamp(),
                TableSchema = new TableSchema(),
                WriteMode = WriteStream.Types.WriteMode.Unspecified,
            };
            mockGrpcClient.Setup(x => x.CreateWriteStreamAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<WriteStream>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BigQueryWriteClient client = new BigQueryWriteClientImpl(mockGrpcClient.Object, null, null);
            WriteStream responseCallSettings = await client.CreateWriteStreamAsync(request.ParentAsTableName, request.WriteStream, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            WriteStream responseCancellationToken = await client.CreateWriteStreamAsync(request.ParentAsTableName, request.WriteStream, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetWriteStreamRequestObject()
        {
            moq::Mock<BigQueryWrite.BigQueryWriteClient> mockGrpcClient = new moq::Mock<BigQueryWrite.BigQueryWriteClient>(moq::MockBehavior.Strict);
            GetWriteStreamRequest request = new GetWriteStreamRequest
            {
                WriteStreamName = WriteStreamName.FromProjectDatasetTableStream("[PROJECT]", "[DATASET]", "[TABLE]", "[STREAM]"),
            };
            WriteStream expectedResponse = new WriteStream
            {
                WriteStreamName = WriteStreamName.FromProjectDatasetTableStream("[PROJECT]", "[DATASET]", "[TABLE]", "[STREAM]"),
                Type = WriteStream.Types.Type.Buffered,
                CreateTime = new wkt::Timestamp(),
                CommitTime = new wkt::Timestamp(),
                TableSchema = new TableSchema(),
                WriteMode = WriteStream.Types.WriteMode.Unspecified,
            };
            mockGrpcClient.Setup(x => x.GetWriteStream(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BigQueryWriteClient client = new BigQueryWriteClientImpl(mockGrpcClient.Object, null, null);
            WriteStream response = client.GetWriteStream(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetWriteStreamRequestObjectAsync()
        {
            moq::Mock<BigQueryWrite.BigQueryWriteClient> mockGrpcClient = new moq::Mock<BigQueryWrite.BigQueryWriteClient>(moq::MockBehavior.Strict);
            GetWriteStreamRequest request = new GetWriteStreamRequest
            {
                WriteStreamName = WriteStreamName.FromProjectDatasetTableStream("[PROJECT]", "[DATASET]", "[TABLE]", "[STREAM]"),
            };
            WriteStream expectedResponse = new WriteStream
            {
                WriteStreamName = WriteStreamName.FromProjectDatasetTableStream("[PROJECT]", "[DATASET]", "[TABLE]", "[STREAM]"),
                Type = WriteStream.Types.Type.Buffered,
                CreateTime = new wkt::Timestamp(),
                CommitTime = new wkt::Timestamp(),
                TableSchema = new TableSchema(),
                WriteMode = WriteStream.Types.WriteMode.Unspecified,
            };
            mockGrpcClient.Setup(x => x.GetWriteStreamAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<WriteStream>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BigQueryWriteClient client = new BigQueryWriteClientImpl(mockGrpcClient.Object, null, null);
            WriteStream responseCallSettings = await client.GetWriteStreamAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            WriteStream responseCancellationToken = await client.GetWriteStreamAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetWriteStream()
        {
            moq::Mock<BigQueryWrite.BigQueryWriteClient> mockGrpcClient = new moq::Mock<BigQueryWrite.BigQueryWriteClient>(moq::MockBehavior.Strict);
            GetWriteStreamRequest request = new GetWriteStreamRequest
            {
                WriteStreamName = WriteStreamName.FromProjectDatasetTableStream("[PROJECT]", "[DATASET]", "[TABLE]", "[STREAM]"),
            };
            WriteStream expectedResponse = new WriteStream
            {
                WriteStreamName = WriteStreamName.FromProjectDatasetTableStream("[PROJECT]", "[DATASET]", "[TABLE]", "[STREAM]"),
                Type = WriteStream.Types.Type.Buffered,
                CreateTime = new wkt::Timestamp(),
                CommitTime = new wkt::Timestamp(),
                TableSchema = new TableSchema(),
                WriteMode = WriteStream.Types.WriteMode.Unspecified,
            };
            mockGrpcClient.Setup(x => x.GetWriteStream(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BigQueryWriteClient client = new BigQueryWriteClientImpl(mockGrpcClient.Object, null, null);
            WriteStream response = client.GetWriteStream(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetWriteStreamAsync()
        {
            moq::Mock<BigQueryWrite.BigQueryWriteClient> mockGrpcClient = new moq::Mock<BigQueryWrite.BigQueryWriteClient>(moq::MockBehavior.Strict);
            GetWriteStreamRequest request = new GetWriteStreamRequest
            {
                WriteStreamName = WriteStreamName.FromProjectDatasetTableStream("[PROJECT]", "[DATASET]", "[TABLE]", "[STREAM]"),
            };
            WriteStream expectedResponse = new WriteStream
            {
                WriteStreamName = WriteStreamName.FromProjectDatasetTableStream("[PROJECT]", "[DATASET]", "[TABLE]", "[STREAM]"),
                Type = WriteStream.Types.Type.Buffered,
                CreateTime = new wkt::Timestamp(),
                CommitTime = new wkt::Timestamp(),
                TableSchema = new TableSchema(),
                WriteMode = WriteStream.Types.WriteMode.Unspecified,
            };
            mockGrpcClient.Setup(x => x.GetWriteStreamAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<WriteStream>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BigQueryWriteClient client = new BigQueryWriteClientImpl(mockGrpcClient.Object, null, null);
            WriteStream responseCallSettings = await client.GetWriteStreamAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            WriteStream responseCancellationToken = await client.GetWriteStreamAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetWriteStreamResourceNames()
        {
            moq::Mock<BigQueryWrite.BigQueryWriteClient> mockGrpcClient = new moq::Mock<BigQueryWrite.BigQueryWriteClient>(moq::MockBehavior.Strict);
            GetWriteStreamRequest request = new GetWriteStreamRequest
            {
                WriteStreamName = WriteStreamName.FromProjectDatasetTableStream("[PROJECT]", "[DATASET]", "[TABLE]", "[STREAM]"),
            };
            WriteStream expectedResponse = new WriteStream
            {
                WriteStreamName = WriteStreamName.FromProjectDatasetTableStream("[PROJECT]", "[DATASET]", "[TABLE]", "[STREAM]"),
                Type = WriteStream.Types.Type.Buffered,
                CreateTime = new wkt::Timestamp(),
                CommitTime = new wkt::Timestamp(),
                TableSchema = new TableSchema(),
                WriteMode = WriteStream.Types.WriteMode.Unspecified,
            };
            mockGrpcClient.Setup(x => x.GetWriteStream(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BigQueryWriteClient client = new BigQueryWriteClientImpl(mockGrpcClient.Object, null, null);
            WriteStream response = client.GetWriteStream(request.WriteStreamName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetWriteStreamResourceNamesAsync()
        {
            moq::Mock<BigQueryWrite.BigQueryWriteClient> mockGrpcClient = new moq::Mock<BigQueryWrite.BigQueryWriteClient>(moq::MockBehavior.Strict);
            GetWriteStreamRequest request = new GetWriteStreamRequest
            {
                WriteStreamName = WriteStreamName.FromProjectDatasetTableStream("[PROJECT]", "[DATASET]", "[TABLE]", "[STREAM]"),
            };
            WriteStream expectedResponse = new WriteStream
            {
                WriteStreamName = WriteStreamName.FromProjectDatasetTableStream("[PROJECT]", "[DATASET]", "[TABLE]", "[STREAM]"),
                Type = WriteStream.Types.Type.Buffered,
                CreateTime = new wkt::Timestamp(),
                CommitTime = new wkt::Timestamp(),
                TableSchema = new TableSchema(),
                WriteMode = WriteStream.Types.WriteMode.Unspecified,
            };
            mockGrpcClient.Setup(x => x.GetWriteStreamAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<WriteStream>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BigQueryWriteClient client = new BigQueryWriteClientImpl(mockGrpcClient.Object, null, null);
            WriteStream responseCallSettings = await client.GetWriteStreamAsync(request.WriteStreamName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            WriteStream responseCancellationToken = await client.GetWriteStreamAsync(request.WriteStreamName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void FinalizeWriteStreamRequestObject()
        {
            moq::Mock<BigQueryWrite.BigQueryWriteClient> mockGrpcClient = new moq::Mock<BigQueryWrite.BigQueryWriteClient>(moq::MockBehavior.Strict);
            FinalizeWriteStreamRequest request = new FinalizeWriteStreamRequest
            {
                WriteStreamName = WriteStreamName.FromProjectDatasetTableStream("[PROJECT]", "[DATASET]", "[TABLE]", "[STREAM]"),
            };
            FinalizeWriteStreamResponse expectedResponse = new FinalizeWriteStreamResponse
            {
                RowCount = 9192966168813313852L,
            };
            mockGrpcClient.Setup(x => x.FinalizeWriteStream(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BigQueryWriteClient client = new BigQueryWriteClientImpl(mockGrpcClient.Object, null, null);
            FinalizeWriteStreamResponse response = client.FinalizeWriteStream(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task FinalizeWriteStreamRequestObjectAsync()
        {
            moq::Mock<BigQueryWrite.BigQueryWriteClient> mockGrpcClient = new moq::Mock<BigQueryWrite.BigQueryWriteClient>(moq::MockBehavior.Strict);
            FinalizeWriteStreamRequest request = new FinalizeWriteStreamRequest
            {
                WriteStreamName = WriteStreamName.FromProjectDatasetTableStream("[PROJECT]", "[DATASET]", "[TABLE]", "[STREAM]"),
            };
            FinalizeWriteStreamResponse expectedResponse = new FinalizeWriteStreamResponse
            {
                RowCount = 9192966168813313852L,
            };
            mockGrpcClient.Setup(x => x.FinalizeWriteStreamAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<FinalizeWriteStreamResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BigQueryWriteClient client = new BigQueryWriteClientImpl(mockGrpcClient.Object, null, null);
            FinalizeWriteStreamResponse responseCallSettings = await client.FinalizeWriteStreamAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            FinalizeWriteStreamResponse responseCancellationToken = await client.FinalizeWriteStreamAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void FinalizeWriteStream()
        {
            moq::Mock<BigQueryWrite.BigQueryWriteClient> mockGrpcClient = new moq::Mock<BigQueryWrite.BigQueryWriteClient>(moq::MockBehavior.Strict);
            FinalizeWriteStreamRequest request = new FinalizeWriteStreamRequest
            {
                WriteStreamName = WriteStreamName.FromProjectDatasetTableStream("[PROJECT]", "[DATASET]", "[TABLE]", "[STREAM]"),
            };
            FinalizeWriteStreamResponse expectedResponse = new FinalizeWriteStreamResponse
            {
                RowCount = 9192966168813313852L,
            };
            mockGrpcClient.Setup(x => x.FinalizeWriteStream(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BigQueryWriteClient client = new BigQueryWriteClientImpl(mockGrpcClient.Object, null, null);
            FinalizeWriteStreamResponse response = client.FinalizeWriteStream(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task FinalizeWriteStreamAsync()
        {
            moq::Mock<BigQueryWrite.BigQueryWriteClient> mockGrpcClient = new moq::Mock<BigQueryWrite.BigQueryWriteClient>(moq::MockBehavior.Strict);
            FinalizeWriteStreamRequest request = new FinalizeWriteStreamRequest
            {
                WriteStreamName = WriteStreamName.FromProjectDatasetTableStream("[PROJECT]", "[DATASET]", "[TABLE]", "[STREAM]"),
            };
            FinalizeWriteStreamResponse expectedResponse = new FinalizeWriteStreamResponse
            {
                RowCount = 9192966168813313852L,
            };
            mockGrpcClient.Setup(x => x.FinalizeWriteStreamAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<FinalizeWriteStreamResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BigQueryWriteClient client = new BigQueryWriteClientImpl(mockGrpcClient.Object, null, null);
            FinalizeWriteStreamResponse responseCallSettings = await client.FinalizeWriteStreamAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            FinalizeWriteStreamResponse responseCancellationToken = await client.FinalizeWriteStreamAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void FinalizeWriteStreamResourceNames()
        {
            moq::Mock<BigQueryWrite.BigQueryWriteClient> mockGrpcClient = new moq::Mock<BigQueryWrite.BigQueryWriteClient>(moq::MockBehavior.Strict);
            FinalizeWriteStreamRequest request = new FinalizeWriteStreamRequest
            {
                WriteStreamName = WriteStreamName.FromProjectDatasetTableStream("[PROJECT]", "[DATASET]", "[TABLE]", "[STREAM]"),
            };
            FinalizeWriteStreamResponse expectedResponse = new FinalizeWriteStreamResponse
            {
                RowCount = 9192966168813313852L,
            };
            mockGrpcClient.Setup(x => x.FinalizeWriteStream(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BigQueryWriteClient client = new BigQueryWriteClientImpl(mockGrpcClient.Object, null, null);
            FinalizeWriteStreamResponse response = client.FinalizeWriteStream(request.WriteStreamName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task FinalizeWriteStreamResourceNamesAsync()
        {
            moq::Mock<BigQueryWrite.BigQueryWriteClient> mockGrpcClient = new moq::Mock<BigQueryWrite.BigQueryWriteClient>(moq::MockBehavior.Strict);
            FinalizeWriteStreamRequest request = new FinalizeWriteStreamRequest
            {
                WriteStreamName = WriteStreamName.FromProjectDatasetTableStream("[PROJECT]", "[DATASET]", "[TABLE]", "[STREAM]"),
            };
            FinalizeWriteStreamResponse expectedResponse = new FinalizeWriteStreamResponse
            {
                RowCount = 9192966168813313852L,
            };
            mockGrpcClient.Setup(x => x.FinalizeWriteStreamAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<FinalizeWriteStreamResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BigQueryWriteClient client = new BigQueryWriteClientImpl(mockGrpcClient.Object, null, null);
            FinalizeWriteStreamResponse responseCallSettings = await client.FinalizeWriteStreamAsync(request.WriteStreamName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            FinalizeWriteStreamResponse responseCancellationToken = await client.FinalizeWriteStreamAsync(request.WriteStreamName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void BatchCommitWriteStreamsRequestObject()
        {
            moq::Mock<BigQueryWrite.BigQueryWriteClient> mockGrpcClient = new moq::Mock<BigQueryWrite.BigQueryWriteClient>(moq::MockBehavior.Strict);
            BatchCommitWriteStreamsRequest request = new BatchCommitWriteStreamsRequest
            {
                ParentAsTableName = TableName.FromProjectDatasetTable("[PROJECT]", "[DATASET]", "[TABLE]"),
                WriteStreams =
                {
                    "write_streams405973b2",
                },
            };
            BatchCommitWriteStreamsResponse expectedResponse = new BatchCommitWriteStreamsResponse
            {
                CommitTime = new wkt::Timestamp(),
                StreamErrors = { new StorageError(), },
            };
            mockGrpcClient.Setup(x => x.BatchCommitWriteStreams(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BigQueryWriteClient client = new BigQueryWriteClientImpl(mockGrpcClient.Object, null, null);
            BatchCommitWriteStreamsResponse response = client.BatchCommitWriteStreams(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task BatchCommitWriteStreamsRequestObjectAsync()
        {
            moq::Mock<BigQueryWrite.BigQueryWriteClient> mockGrpcClient = new moq::Mock<BigQueryWrite.BigQueryWriteClient>(moq::MockBehavior.Strict);
            BatchCommitWriteStreamsRequest request = new BatchCommitWriteStreamsRequest
            {
                ParentAsTableName = TableName.FromProjectDatasetTable("[PROJECT]", "[DATASET]", "[TABLE]"),
                WriteStreams =
                {
                    "write_streams405973b2",
                },
            };
            BatchCommitWriteStreamsResponse expectedResponse = new BatchCommitWriteStreamsResponse
            {
                CommitTime = new wkt::Timestamp(),
                StreamErrors = { new StorageError(), },
            };
            mockGrpcClient.Setup(x => x.BatchCommitWriteStreamsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<BatchCommitWriteStreamsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BigQueryWriteClient client = new BigQueryWriteClientImpl(mockGrpcClient.Object, null, null);
            BatchCommitWriteStreamsResponse responseCallSettings = await client.BatchCommitWriteStreamsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            BatchCommitWriteStreamsResponse responseCancellationToken = await client.BatchCommitWriteStreamsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void BatchCommitWriteStreams()
        {
            moq::Mock<BigQueryWrite.BigQueryWriteClient> mockGrpcClient = new moq::Mock<BigQueryWrite.BigQueryWriteClient>(moq::MockBehavior.Strict);
            BatchCommitWriteStreamsRequest request = new BatchCommitWriteStreamsRequest
            {
                ParentAsTableName = TableName.FromProjectDatasetTable("[PROJECT]", "[DATASET]", "[TABLE]"),
            };
            BatchCommitWriteStreamsResponse expectedResponse = new BatchCommitWriteStreamsResponse
            {
                CommitTime = new wkt::Timestamp(),
                StreamErrors = { new StorageError(), },
            };
            mockGrpcClient.Setup(x => x.BatchCommitWriteStreams(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BigQueryWriteClient client = new BigQueryWriteClientImpl(mockGrpcClient.Object, null, null);
            BatchCommitWriteStreamsResponse response = client.BatchCommitWriteStreams(request.Parent);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task BatchCommitWriteStreamsAsync()
        {
            moq::Mock<BigQueryWrite.BigQueryWriteClient> mockGrpcClient = new moq::Mock<BigQueryWrite.BigQueryWriteClient>(moq::MockBehavior.Strict);
            BatchCommitWriteStreamsRequest request = new BatchCommitWriteStreamsRequest
            {
                ParentAsTableName = TableName.FromProjectDatasetTable("[PROJECT]", "[DATASET]", "[TABLE]"),
            };
            BatchCommitWriteStreamsResponse expectedResponse = new BatchCommitWriteStreamsResponse
            {
                CommitTime = new wkt::Timestamp(),
                StreamErrors = { new StorageError(), },
            };
            mockGrpcClient.Setup(x => x.BatchCommitWriteStreamsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<BatchCommitWriteStreamsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BigQueryWriteClient client = new BigQueryWriteClientImpl(mockGrpcClient.Object, null, null);
            BatchCommitWriteStreamsResponse responseCallSettings = await client.BatchCommitWriteStreamsAsync(request.Parent, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            BatchCommitWriteStreamsResponse responseCancellationToken = await client.BatchCommitWriteStreamsAsync(request.Parent, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void BatchCommitWriteStreamsResourceNames()
        {
            moq::Mock<BigQueryWrite.BigQueryWriteClient> mockGrpcClient = new moq::Mock<BigQueryWrite.BigQueryWriteClient>(moq::MockBehavior.Strict);
            BatchCommitWriteStreamsRequest request = new BatchCommitWriteStreamsRequest
            {
                ParentAsTableName = TableName.FromProjectDatasetTable("[PROJECT]", "[DATASET]", "[TABLE]"),
            };
            BatchCommitWriteStreamsResponse expectedResponse = new BatchCommitWriteStreamsResponse
            {
                CommitTime = new wkt::Timestamp(),
                StreamErrors = { new StorageError(), },
            };
            mockGrpcClient.Setup(x => x.BatchCommitWriteStreams(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BigQueryWriteClient client = new BigQueryWriteClientImpl(mockGrpcClient.Object, null, null);
            BatchCommitWriteStreamsResponse response = client.BatchCommitWriteStreams(request.ParentAsTableName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task BatchCommitWriteStreamsResourceNamesAsync()
        {
            moq::Mock<BigQueryWrite.BigQueryWriteClient> mockGrpcClient = new moq::Mock<BigQueryWrite.BigQueryWriteClient>(moq::MockBehavior.Strict);
            BatchCommitWriteStreamsRequest request = new BatchCommitWriteStreamsRequest
            {
                ParentAsTableName = TableName.FromProjectDatasetTable("[PROJECT]", "[DATASET]", "[TABLE]"),
            };
            BatchCommitWriteStreamsResponse expectedResponse = new BatchCommitWriteStreamsResponse
            {
                CommitTime = new wkt::Timestamp(),
                StreamErrors = { new StorageError(), },
            };
            mockGrpcClient.Setup(x => x.BatchCommitWriteStreamsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<BatchCommitWriteStreamsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BigQueryWriteClient client = new BigQueryWriteClientImpl(mockGrpcClient.Object, null, null);
            BatchCommitWriteStreamsResponse responseCallSettings = await client.BatchCommitWriteStreamsAsync(request.ParentAsTableName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            BatchCommitWriteStreamsResponse responseCancellationToken = await client.BatchCommitWriteStreamsAsync(request.ParentAsTableName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void FlushRowsRequestObject()
        {
            moq::Mock<BigQueryWrite.BigQueryWriteClient> mockGrpcClient = new moq::Mock<BigQueryWrite.BigQueryWriteClient>(moq::MockBehavior.Strict);
            FlushRowsRequest request = new FlushRowsRequest
            {
                WriteStreamAsWriteStreamName = WriteStreamName.FromProjectDatasetTableStream("[PROJECT]", "[DATASET]", "[TABLE]", "[STREAM]"),
                Offset = -4389998161825790342L,
            };
            FlushRowsResponse expectedResponse = new FlushRowsResponse
            {
                Offset = -4389998161825790342L,
            };
            mockGrpcClient.Setup(x => x.FlushRows(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BigQueryWriteClient client = new BigQueryWriteClientImpl(mockGrpcClient.Object, null, null);
            FlushRowsResponse response = client.FlushRows(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task FlushRowsRequestObjectAsync()
        {
            moq::Mock<BigQueryWrite.BigQueryWriteClient> mockGrpcClient = new moq::Mock<BigQueryWrite.BigQueryWriteClient>(moq::MockBehavior.Strict);
            FlushRowsRequest request = new FlushRowsRequest
            {
                WriteStreamAsWriteStreamName = WriteStreamName.FromProjectDatasetTableStream("[PROJECT]", "[DATASET]", "[TABLE]", "[STREAM]"),
                Offset = -4389998161825790342L,
            };
            FlushRowsResponse expectedResponse = new FlushRowsResponse
            {
                Offset = -4389998161825790342L,
            };
            mockGrpcClient.Setup(x => x.FlushRowsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<FlushRowsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BigQueryWriteClient client = new BigQueryWriteClientImpl(mockGrpcClient.Object, null, null);
            FlushRowsResponse responseCallSettings = await client.FlushRowsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            FlushRowsResponse responseCancellationToken = await client.FlushRowsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void FlushRows()
        {
            moq::Mock<BigQueryWrite.BigQueryWriteClient> mockGrpcClient = new moq::Mock<BigQueryWrite.BigQueryWriteClient>(moq::MockBehavior.Strict);
            FlushRowsRequest request = new FlushRowsRequest
            {
                WriteStreamAsWriteStreamName = WriteStreamName.FromProjectDatasetTableStream("[PROJECT]", "[DATASET]", "[TABLE]", "[STREAM]"),
            };
            FlushRowsResponse expectedResponse = new FlushRowsResponse
            {
                Offset = -4389998161825790342L,
            };
            mockGrpcClient.Setup(x => x.FlushRows(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BigQueryWriteClient client = new BigQueryWriteClientImpl(mockGrpcClient.Object, null, null);
            FlushRowsResponse response = client.FlushRows(request.WriteStream);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task FlushRowsAsync()
        {
            moq::Mock<BigQueryWrite.BigQueryWriteClient> mockGrpcClient = new moq::Mock<BigQueryWrite.BigQueryWriteClient>(moq::MockBehavior.Strict);
            FlushRowsRequest request = new FlushRowsRequest
            {
                WriteStreamAsWriteStreamName = WriteStreamName.FromProjectDatasetTableStream("[PROJECT]", "[DATASET]", "[TABLE]", "[STREAM]"),
            };
            FlushRowsResponse expectedResponse = new FlushRowsResponse
            {
                Offset = -4389998161825790342L,
            };
            mockGrpcClient.Setup(x => x.FlushRowsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<FlushRowsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BigQueryWriteClient client = new BigQueryWriteClientImpl(mockGrpcClient.Object, null, null);
            FlushRowsResponse responseCallSettings = await client.FlushRowsAsync(request.WriteStream, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            FlushRowsResponse responseCancellationToken = await client.FlushRowsAsync(request.WriteStream, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void FlushRowsResourceNames()
        {
            moq::Mock<BigQueryWrite.BigQueryWriteClient> mockGrpcClient = new moq::Mock<BigQueryWrite.BigQueryWriteClient>(moq::MockBehavior.Strict);
            FlushRowsRequest request = new FlushRowsRequest
            {
                WriteStreamAsWriteStreamName = WriteStreamName.FromProjectDatasetTableStream("[PROJECT]", "[DATASET]", "[TABLE]", "[STREAM]"),
            };
            FlushRowsResponse expectedResponse = new FlushRowsResponse
            {
                Offset = -4389998161825790342L,
            };
            mockGrpcClient.Setup(x => x.FlushRows(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BigQueryWriteClient client = new BigQueryWriteClientImpl(mockGrpcClient.Object, null, null);
            FlushRowsResponse response = client.FlushRows(request.WriteStreamAsWriteStreamName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task FlushRowsResourceNamesAsync()
        {
            moq::Mock<BigQueryWrite.BigQueryWriteClient> mockGrpcClient = new moq::Mock<BigQueryWrite.BigQueryWriteClient>(moq::MockBehavior.Strict);
            FlushRowsRequest request = new FlushRowsRequest
            {
                WriteStreamAsWriteStreamName = WriteStreamName.FromProjectDatasetTableStream("[PROJECT]", "[DATASET]", "[TABLE]", "[STREAM]"),
            };
            FlushRowsResponse expectedResponse = new FlushRowsResponse
            {
                Offset = -4389998161825790342L,
            };
            mockGrpcClient.Setup(x => x.FlushRowsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<FlushRowsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BigQueryWriteClient client = new BigQueryWriteClientImpl(mockGrpcClient.Object, null, null);
            FlushRowsResponse responseCallSettings = await client.FlushRowsAsync(request.WriteStreamAsWriteStreamName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            FlushRowsResponse responseCancellationToken = await client.FlushRowsAsync(request.WriteStreamAsWriteStreamName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
