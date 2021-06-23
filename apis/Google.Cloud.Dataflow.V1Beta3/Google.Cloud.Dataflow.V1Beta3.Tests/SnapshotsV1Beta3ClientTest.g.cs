// Copyright 2021 Google LLC
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
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Dataflow.V1Beta3.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedSnapshotsV1Beta3ClientTest
    {
        [xunit::FactAttribute]
        public void GetSnapshotRequestObject()
        {
            moq::Mock<SnapshotsV1Beta3.SnapshotsV1Beta3Client> mockGrpcClient = new moq::Mock<SnapshotsV1Beta3.SnapshotsV1Beta3Client>(moq::MockBehavior.Strict);
            GetSnapshotRequest request = new GetSnapshotRequest
            {
                ProjectId = "project_id43ad98b0",
                SnapshotId = "snapshot_id3456a275",
                Location = "locatione09d18d5",
            };
            Snapshot expectedResponse = new Snapshot
            {
                Id = "id74b70bb8",
                ProjectId = "project_id43ad98b0",
                SourceJobId = "source_job_id1406915d",
                CreationTime = new wkt::Timestamp(),
                Ttl = new wkt::Duration(),
                State = SnapshotState.UnknownSnapshotState,
                PubsubMetadata =
                {
                    new PubsubSnapshotMetadata(),
                },
                Description = "description2cf9da67",
                DiskSizeBytes = -5516951742914183668L,
                Region = "regionedb20d96",
            };
            mockGrpcClient.Setup(x => x.GetSnapshot(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SnapshotsV1Beta3Client client = new SnapshotsV1Beta3ClientImpl(mockGrpcClient.Object, null);
            Snapshot response = client.GetSnapshot(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetSnapshotRequestObjectAsync()
        {
            moq::Mock<SnapshotsV1Beta3.SnapshotsV1Beta3Client> mockGrpcClient = new moq::Mock<SnapshotsV1Beta3.SnapshotsV1Beta3Client>(moq::MockBehavior.Strict);
            GetSnapshotRequest request = new GetSnapshotRequest
            {
                ProjectId = "project_id43ad98b0",
                SnapshotId = "snapshot_id3456a275",
                Location = "locatione09d18d5",
            };
            Snapshot expectedResponse = new Snapshot
            {
                Id = "id74b70bb8",
                ProjectId = "project_id43ad98b0",
                SourceJobId = "source_job_id1406915d",
                CreationTime = new wkt::Timestamp(),
                Ttl = new wkt::Duration(),
                State = SnapshotState.UnknownSnapshotState,
                PubsubMetadata =
                {
                    new PubsubSnapshotMetadata(),
                },
                Description = "description2cf9da67",
                DiskSizeBytes = -5516951742914183668L,
                Region = "regionedb20d96",
            };
            mockGrpcClient.Setup(x => x.GetSnapshotAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Snapshot>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SnapshotsV1Beta3Client client = new SnapshotsV1Beta3ClientImpl(mockGrpcClient.Object, null);
            Snapshot responseCallSettings = await client.GetSnapshotAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Snapshot responseCancellationToken = await client.GetSnapshotAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteSnapshotRequestObject()
        {
            moq::Mock<SnapshotsV1Beta3.SnapshotsV1Beta3Client> mockGrpcClient = new moq::Mock<SnapshotsV1Beta3.SnapshotsV1Beta3Client>(moq::MockBehavior.Strict);
            DeleteSnapshotRequest request = new DeleteSnapshotRequest
            {
                ProjectId = "project_id43ad98b0",
                SnapshotId = "snapshot_id3456a275",
                Location = "locatione09d18d5",
            };
            DeleteSnapshotResponse expectedResponse = new DeleteSnapshotResponse { };
            mockGrpcClient.Setup(x => x.DeleteSnapshot(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SnapshotsV1Beta3Client client = new SnapshotsV1Beta3ClientImpl(mockGrpcClient.Object, null);
            DeleteSnapshotResponse response = client.DeleteSnapshot(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteSnapshotRequestObjectAsync()
        {
            moq::Mock<SnapshotsV1Beta3.SnapshotsV1Beta3Client> mockGrpcClient = new moq::Mock<SnapshotsV1Beta3.SnapshotsV1Beta3Client>(moq::MockBehavior.Strict);
            DeleteSnapshotRequest request = new DeleteSnapshotRequest
            {
                ProjectId = "project_id43ad98b0",
                SnapshotId = "snapshot_id3456a275",
                Location = "locatione09d18d5",
            };
            DeleteSnapshotResponse expectedResponse = new DeleteSnapshotResponse { };
            mockGrpcClient.Setup(x => x.DeleteSnapshotAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DeleteSnapshotResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SnapshotsV1Beta3Client client = new SnapshotsV1Beta3ClientImpl(mockGrpcClient.Object, null);
            DeleteSnapshotResponse responseCallSettings = await client.DeleteSnapshotAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DeleteSnapshotResponse responseCancellationToken = await client.DeleteSnapshotAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ListSnapshotsRequestObject()
        {
            moq::Mock<SnapshotsV1Beta3.SnapshotsV1Beta3Client> mockGrpcClient = new moq::Mock<SnapshotsV1Beta3.SnapshotsV1Beta3Client>(moq::MockBehavior.Strict);
            ListSnapshotsRequest request = new ListSnapshotsRequest
            {
                ProjectId = "project_id43ad98b0",
                Location = "locatione09d18d5",
                JobId = "job_id38ea97d6",
            };
            ListSnapshotsResponse expectedResponse = new ListSnapshotsResponse
            {
                Snapshots = { new Snapshot(), },
            };
            mockGrpcClient.Setup(x => x.ListSnapshots(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SnapshotsV1Beta3Client client = new SnapshotsV1Beta3ClientImpl(mockGrpcClient.Object, null);
            ListSnapshotsResponse response = client.ListSnapshots(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListSnapshotsRequestObjectAsync()
        {
            moq::Mock<SnapshotsV1Beta3.SnapshotsV1Beta3Client> mockGrpcClient = new moq::Mock<SnapshotsV1Beta3.SnapshotsV1Beta3Client>(moq::MockBehavior.Strict);
            ListSnapshotsRequest request = new ListSnapshotsRequest
            {
                ProjectId = "project_id43ad98b0",
                Location = "locatione09d18d5",
                JobId = "job_id38ea97d6",
            };
            ListSnapshotsResponse expectedResponse = new ListSnapshotsResponse
            {
                Snapshots = { new Snapshot(), },
            };
            mockGrpcClient.Setup(x => x.ListSnapshotsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ListSnapshotsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SnapshotsV1Beta3Client client = new SnapshotsV1Beta3ClientImpl(mockGrpcClient.Object, null);
            ListSnapshotsResponse responseCallSettings = await client.ListSnapshotsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ListSnapshotsResponse responseCancellationToken = await client.ListSnapshotsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
