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
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Compute.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedSnapshotsClientTest
    {
        [xunit::FactAttribute]
        public void DeleteRequestObject()
        {
            moq::Mock<Snapshots.SnapshotsClient> mockGrpcClient = new moq::Mock<Snapshots.SnapshotsClient>(moq::MockBehavior.Strict);
            DeleteSnapshotRequest request = new DeleteSnapshotRequest
            {
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
                Snapshot = "snapshotded322c3",
            };
            Operation expectedResponse = new Operation
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                User = "userb1cb11ee",
                Zone = "zone255f4ea8",
                CreationTimestamp = "creation_timestamp235e59a1",
                StartTime = "start_timebd8dd9c4",
                OperationGroupId = "operation_group_idd2040cf0",
                TargetLink = "target_link9b435dc0",
                Progress = 278622268,
                Error = new Error(),
                EndTime = "end_time89285d30",
                Region = "regionedb20d96",
                OperationType = "operation_typeece9e153",
                Status = Operation.Types.Status.Pending,
                HttpErrorMessage = "http_error_messageb5ef3c7f",
                TargetId = "target_id16dfe255",
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.Delete(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SnapshotsClient client = new SnapshotsClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Delete(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteRequestObjectAsync()
        {
            moq::Mock<Snapshots.SnapshotsClient> mockGrpcClient = new moq::Mock<Snapshots.SnapshotsClient>(moq::MockBehavior.Strict);
            DeleteSnapshotRequest request = new DeleteSnapshotRequest
            {
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
                Snapshot = "snapshotded322c3",
            };
            Operation expectedResponse = new Operation
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                User = "userb1cb11ee",
                Zone = "zone255f4ea8",
                CreationTimestamp = "creation_timestamp235e59a1",
                StartTime = "start_timebd8dd9c4",
                OperationGroupId = "operation_group_idd2040cf0",
                TargetLink = "target_link9b435dc0",
                Progress = 278622268,
                Error = new Error(),
                EndTime = "end_time89285d30",
                Region = "regionedb20d96",
                OperationType = "operation_typeece9e153",
                Status = Operation.Types.Status.Pending,
                HttpErrorMessage = "http_error_messageb5ef3c7f",
                TargetId = "target_id16dfe255",
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.DeleteAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SnapshotsClient client = new SnapshotsClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.DeleteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.DeleteAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Delete()
        {
            moq::Mock<Snapshots.SnapshotsClient> mockGrpcClient = new moq::Mock<Snapshots.SnapshotsClient>(moq::MockBehavior.Strict);
            DeleteSnapshotRequest request = new DeleteSnapshotRequest
            {
                Project = "projectaa6ff846",
                Snapshot = "snapshotded322c3",
            };
            Operation expectedResponse = new Operation
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                User = "userb1cb11ee",
                Zone = "zone255f4ea8",
                CreationTimestamp = "creation_timestamp235e59a1",
                StartTime = "start_timebd8dd9c4",
                OperationGroupId = "operation_group_idd2040cf0",
                TargetLink = "target_link9b435dc0",
                Progress = 278622268,
                Error = new Error(),
                EndTime = "end_time89285d30",
                Region = "regionedb20d96",
                OperationType = "operation_typeece9e153",
                Status = Operation.Types.Status.Pending,
                HttpErrorMessage = "http_error_messageb5ef3c7f",
                TargetId = "target_id16dfe255",
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.Delete(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SnapshotsClient client = new SnapshotsClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Delete(request.Project, request.Snapshot);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteAsync()
        {
            moq::Mock<Snapshots.SnapshotsClient> mockGrpcClient = new moq::Mock<Snapshots.SnapshotsClient>(moq::MockBehavior.Strict);
            DeleteSnapshotRequest request = new DeleteSnapshotRequest
            {
                Project = "projectaa6ff846",
                Snapshot = "snapshotded322c3",
            };
            Operation expectedResponse = new Operation
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                User = "userb1cb11ee",
                Zone = "zone255f4ea8",
                CreationTimestamp = "creation_timestamp235e59a1",
                StartTime = "start_timebd8dd9c4",
                OperationGroupId = "operation_group_idd2040cf0",
                TargetLink = "target_link9b435dc0",
                Progress = 278622268,
                Error = new Error(),
                EndTime = "end_time89285d30",
                Region = "regionedb20d96",
                OperationType = "operation_typeece9e153",
                Status = Operation.Types.Status.Pending,
                HttpErrorMessage = "http_error_messageb5ef3c7f",
                TargetId = "target_id16dfe255",
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.DeleteAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SnapshotsClient client = new SnapshotsClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.DeleteAsync(request.Project, request.Snapshot, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.DeleteAsync(request.Project, request.Snapshot, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetRequestObject()
        {
            moq::Mock<Snapshots.SnapshotsClient> mockGrpcClient = new moq::Mock<Snapshots.SnapshotsClient>(moq::MockBehavior.Strict);
            GetSnapshotRequest request = new GetSnapshotRequest
            {
                Project = "projectaa6ff846",
                Snapshot = "snapshotded322c3",
            };
            Snapshot expectedResponse = new Snapshot
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CreationTimestamp = "creation_timestamp235e59a1",
                SnapshotEncryptionKey = new CustomerEncryptionKey(),
                LicenseCodes =
                {
                    "license_codesdd63b74e",
                },
                ChainName = "chain_name66f3d828",
                LabelFingerprint = "label_fingerprint06ccff3a",
                Status = Snapshot.Types.Status.Deleting,
                DiskSizeGb = "disk_size_gbf071de02",
                StorageLocations =
                {
                    "storage_locationse772402d",
                },
                Licenses =
                {
                    "licensesd1cc2f9d",
                },
                LocationHint = "location_hint666f366c",
                Description = "description2cf9da67",
                StorageBytes = "storage_bytese9aba235",
                DownloadBytes = "download_bytesa587899a",
                SourceDisk = "source_disk0eec086f",
                SourceDiskId = "source_disk_id020f9fb8",
                SelfLink = "self_link7e87f12d",
                AutoCreated = true,
                SatisfiesPzs = false,
                StorageBytesStatus = Snapshot.Types.StorageBytesStatus.UndefinedStorageBytesStatus,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                SourceDiskEncryptionKey = new CustomerEncryptionKey(),
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SnapshotsClient client = new SnapshotsClientImpl(mockGrpcClient.Object, null);
            Snapshot response = client.Get(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRequestObjectAsync()
        {
            moq::Mock<Snapshots.SnapshotsClient> mockGrpcClient = new moq::Mock<Snapshots.SnapshotsClient>(moq::MockBehavior.Strict);
            GetSnapshotRequest request = new GetSnapshotRequest
            {
                Project = "projectaa6ff846",
                Snapshot = "snapshotded322c3",
            };
            Snapshot expectedResponse = new Snapshot
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CreationTimestamp = "creation_timestamp235e59a1",
                SnapshotEncryptionKey = new CustomerEncryptionKey(),
                LicenseCodes =
                {
                    "license_codesdd63b74e",
                },
                ChainName = "chain_name66f3d828",
                LabelFingerprint = "label_fingerprint06ccff3a",
                Status = Snapshot.Types.Status.Deleting,
                DiskSizeGb = "disk_size_gbf071de02",
                StorageLocations =
                {
                    "storage_locationse772402d",
                },
                Licenses =
                {
                    "licensesd1cc2f9d",
                },
                LocationHint = "location_hint666f366c",
                Description = "description2cf9da67",
                StorageBytes = "storage_bytese9aba235",
                DownloadBytes = "download_bytesa587899a",
                SourceDisk = "source_disk0eec086f",
                SourceDiskId = "source_disk_id020f9fb8",
                SelfLink = "self_link7e87f12d",
                AutoCreated = true,
                SatisfiesPzs = false,
                StorageBytesStatus = Snapshot.Types.StorageBytesStatus.UndefinedStorageBytesStatus,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                SourceDiskEncryptionKey = new CustomerEncryptionKey(),
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Snapshot>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SnapshotsClient client = new SnapshotsClientImpl(mockGrpcClient.Object, null);
            Snapshot responseCallSettings = await client.GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Snapshot responseCancellationToken = await client.GetAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Get()
        {
            moq::Mock<Snapshots.SnapshotsClient> mockGrpcClient = new moq::Mock<Snapshots.SnapshotsClient>(moq::MockBehavior.Strict);
            GetSnapshotRequest request = new GetSnapshotRequest
            {
                Project = "projectaa6ff846",
                Snapshot = "snapshotded322c3",
            };
            Snapshot expectedResponse = new Snapshot
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CreationTimestamp = "creation_timestamp235e59a1",
                SnapshotEncryptionKey = new CustomerEncryptionKey(),
                LicenseCodes =
                {
                    "license_codesdd63b74e",
                },
                ChainName = "chain_name66f3d828",
                LabelFingerprint = "label_fingerprint06ccff3a",
                Status = Snapshot.Types.Status.Deleting,
                DiskSizeGb = "disk_size_gbf071de02",
                StorageLocations =
                {
                    "storage_locationse772402d",
                },
                Licenses =
                {
                    "licensesd1cc2f9d",
                },
                LocationHint = "location_hint666f366c",
                Description = "description2cf9da67",
                StorageBytes = "storage_bytese9aba235",
                DownloadBytes = "download_bytesa587899a",
                SourceDisk = "source_disk0eec086f",
                SourceDiskId = "source_disk_id020f9fb8",
                SelfLink = "self_link7e87f12d",
                AutoCreated = true,
                SatisfiesPzs = false,
                StorageBytesStatus = Snapshot.Types.StorageBytesStatus.UndefinedStorageBytesStatus,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                SourceDiskEncryptionKey = new CustomerEncryptionKey(),
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SnapshotsClient client = new SnapshotsClientImpl(mockGrpcClient.Object, null);
            Snapshot response = client.Get(request.Project, request.Snapshot);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAsync()
        {
            moq::Mock<Snapshots.SnapshotsClient> mockGrpcClient = new moq::Mock<Snapshots.SnapshotsClient>(moq::MockBehavior.Strict);
            GetSnapshotRequest request = new GetSnapshotRequest
            {
                Project = "projectaa6ff846",
                Snapshot = "snapshotded322c3",
            };
            Snapshot expectedResponse = new Snapshot
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CreationTimestamp = "creation_timestamp235e59a1",
                SnapshotEncryptionKey = new CustomerEncryptionKey(),
                LicenseCodes =
                {
                    "license_codesdd63b74e",
                },
                ChainName = "chain_name66f3d828",
                LabelFingerprint = "label_fingerprint06ccff3a",
                Status = Snapshot.Types.Status.Deleting,
                DiskSizeGb = "disk_size_gbf071de02",
                StorageLocations =
                {
                    "storage_locationse772402d",
                },
                Licenses =
                {
                    "licensesd1cc2f9d",
                },
                LocationHint = "location_hint666f366c",
                Description = "description2cf9da67",
                StorageBytes = "storage_bytese9aba235",
                DownloadBytes = "download_bytesa587899a",
                SourceDisk = "source_disk0eec086f",
                SourceDiskId = "source_disk_id020f9fb8",
                SelfLink = "self_link7e87f12d",
                AutoCreated = true,
                SatisfiesPzs = false,
                StorageBytesStatus = Snapshot.Types.StorageBytesStatus.UndefinedStorageBytesStatus,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                SourceDiskEncryptionKey = new CustomerEncryptionKey(),
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Snapshot>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SnapshotsClient client = new SnapshotsClientImpl(mockGrpcClient.Object, null);
            Snapshot responseCallSettings = await client.GetAsync(request.Project, request.Snapshot, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Snapshot responseCancellationToken = await client.GetAsync(request.Project, request.Snapshot, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetIamPolicyRequestObject()
        {
            moq::Mock<Snapshots.SnapshotsClient> mockGrpcClient = new moq::Mock<Snapshots.SnapshotsClient>(moq::MockBehavior.Strict);
            GetIamPolicySnapshotRequest request = new GetIamPolicySnapshotRequest
            {
                Resource = "resource164eab96",
                Project = "projectaa6ff846",
                OptionsRequestedPolicyVersion = -1471234741,
            };
            Policy expectedResponse = new Policy
            {
                Etag = "etage8ad7218",
                Rules = { new Rule(), },
                AuditConfigs = { new AuditConfig(), },
                Version = 271578922,
                Bindings = { new Binding(), },
                IamOwned = false,
            };
            mockGrpcClient.Setup(x => x.GetIamPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SnapshotsClient client = new SnapshotsClientImpl(mockGrpcClient.Object, null);
            Policy response = client.GetIamPolicy(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetIamPolicyRequestObjectAsync()
        {
            moq::Mock<Snapshots.SnapshotsClient> mockGrpcClient = new moq::Mock<Snapshots.SnapshotsClient>(moq::MockBehavior.Strict);
            GetIamPolicySnapshotRequest request = new GetIamPolicySnapshotRequest
            {
                Resource = "resource164eab96",
                Project = "projectaa6ff846",
                OptionsRequestedPolicyVersion = -1471234741,
            };
            Policy expectedResponse = new Policy
            {
                Etag = "etage8ad7218",
                Rules = { new Rule(), },
                AuditConfigs = { new AuditConfig(), },
                Version = 271578922,
                Bindings = { new Binding(), },
                IamOwned = false,
            };
            mockGrpcClient.Setup(x => x.GetIamPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SnapshotsClient client = new SnapshotsClientImpl(mockGrpcClient.Object, null);
            Policy responseCallSettings = await client.GetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Policy responseCancellationToken = await client.GetIamPolicyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetIamPolicy()
        {
            moq::Mock<Snapshots.SnapshotsClient> mockGrpcClient = new moq::Mock<Snapshots.SnapshotsClient>(moq::MockBehavior.Strict);
            GetIamPolicySnapshotRequest request = new GetIamPolicySnapshotRequest
            {
                Resource = "resource164eab96",
                Project = "projectaa6ff846",
            };
            Policy expectedResponse = new Policy
            {
                Etag = "etage8ad7218",
                Rules = { new Rule(), },
                AuditConfigs = { new AuditConfig(), },
                Version = 271578922,
                Bindings = { new Binding(), },
                IamOwned = false,
            };
            mockGrpcClient.Setup(x => x.GetIamPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SnapshotsClient client = new SnapshotsClientImpl(mockGrpcClient.Object, null);
            Policy response = client.GetIamPolicy(request.Project, request.Resource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetIamPolicyAsync()
        {
            moq::Mock<Snapshots.SnapshotsClient> mockGrpcClient = new moq::Mock<Snapshots.SnapshotsClient>(moq::MockBehavior.Strict);
            GetIamPolicySnapshotRequest request = new GetIamPolicySnapshotRequest
            {
                Resource = "resource164eab96",
                Project = "projectaa6ff846",
            };
            Policy expectedResponse = new Policy
            {
                Etag = "etage8ad7218",
                Rules = { new Rule(), },
                AuditConfigs = { new AuditConfig(), },
                Version = 271578922,
                Bindings = { new Binding(), },
                IamOwned = false,
            };
            mockGrpcClient.Setup(x => x.GetIamPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SnapshotsClient client = new SnapshotsClientImpl(mockGrpcClient.Object, null);
            Policy responseCallSettings = await client.GetIamPolicyAsync(request.Project, request.Resource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Policy responseCancellationToken = await client.GetIamPolicyAsync(request.Project, request.Resource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ListRequestObject()
        {
            moq::Mock<Snapshots.SnapshotsClient> mockGrpcClient = new moq::Mock<Snapshots.SnapshotsClient>(moq::MockBehavior.Strict);
            ListSnapshotsRequest request = new ListSnapshotsRequest
            {
                PageToken = "page_tokenf09e5538",
                MaxResults = 2806814450U,
                OrderBy = "order_byb4d33ada",
                Project = "projectaa6ff846",
                Filter = "filtere47ac9b2",
                ReturnPartialSuccess = false,
            };
            SnapshotList expectedResponse = new SnapshotList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items = { new Snapshot(), },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.List(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SnapshotsClient client = new SnapshotsClientImpl(mockGrpcClient.Object, null);
            SnapshotList response = client.List(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListRequestObjectAsync()
        {
            moq::Mock<Snapshots.SnapshotsClient> mockGrpcClient = new moq::Mock<Snapshots.SnapshotsClient>(moq::MockBehavior.Strict);
            ListSnapshotsRequest request = new ListSnapshotsRequest
            {
                PageToken = "page_tokenf09e5538",
                MaxResults = 2806814450U,
                OrderBy = "order_byb4d33ada",
                Project = "projectaa6ff846",
                Filter = "filtere47ac9b2",
                ReturnPartialSuccess = false,
            };
            SnapshotList expectedResponse = new SnapshotList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items = { new Snapshot(), },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.ListAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SnapshotList>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SnapshotsClient client = new SnapshotsClientImpl(mockGrpcClient.Object, null);
            SnapshotList responseCallSettings = await client.ListAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SnapshotList responseCancellationToken = await client.ListAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void List()
        {
            moq::Mock<Snapshots.SnapshotsClient> mockGrpcClient = new moq::Mock<Snapshots.SnapshotsClient>(moq::MockBehavior.Strict);
            ListSnapshotsRequest request = new ListSnapshotsRequest
            {
                Project = "projectaa6ff846",
            };
            SnapshotList expectedResponse = new SnapshotList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items = { new Snapshot(), },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.List(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SnapshotsClient client = new SnapshotsClientImpl(mockGrpcClient.Object, null);
            SnapshotList response = client.List(request.Project);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListAsync()
        {
            moq::Mock<Snapshots.SnapshotsClient> mockGrpcClient = new moq::Mock<Snapshots.SnapshotsClient>(moq::MockBehavior.Strict);
            ListSnapshotsRequest request = new ListSnapshotsRequest
            {
                Project = "projectaa6ff846",
            };
            SnapshotList expectedResponse = new SnapshotList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items = { new Snapshot(), },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.ListAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SnapshotList>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SnapshotsClient client = new SnapshotsClientImpl(mockGrpcClient.Object, null);
            SnapshotList responseCallSettings = await client.ListAsync(request.Project, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SnapshotList responseCancellationToken = await client.ListAsync(request.Project, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetIamPolicyRequestObject()
        {
            moq::Mock<Snapshots.SnapshotsClient> mockGrpcClient = new moq::Mock<Snapshots.SnapshotsClient>(moq::MockBehavior.Strict);
            SetIamPolicySnapshotRequest request = new SetIamPolicySnapshotRequest
            {
                Resource = "resource164eab96",
                Project = "projectaa6ff846",
                GlobalSetPolicyRequestResource = new GlobalSetPolicyRequest(),
            };
            Policy expectedResponse = new Policy
            {
                Etag = "etage8ad7218",
                Rules = { new Rule(), },
                AuditConfigs = { new AuditConfig(), },
                Version = 271578922,
                Bindings = { new Binding(), },
                IamOwned = false,
            };
            mockGrpcClient.Setup(x => x.SetIamPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SnapshotsClient client = new SnapshotsClientImpl(mockGrpcClient.Object, null);
            Policy response = client.SetIamPolicy(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetIamPolicyRequestObjectAsync()
        {
            moq::Mock<Snapshots.SnapshotsClient> mockGrpcClient = new moq::Mock<Snapshots.SnapshotsClient>(moq::MockBehavior.Strict);
            SetIamPolicySnapshotRequest request = new SetIamPolicySnapshotRequest
            {
                Resource = "resource164eab96",
                Project = "projectaa6ff846",
                GlobalSetPolicyRequestResource = new GlobalSetPolicyRequest(),
            };
            Policy expectedResponse = new Policy
            {
                Etag = "etage8ad7218",
                Rules = { new Rule(), },
                AuditConfigs = { new AuditConfig(), },
                Version = 271578922,
                Bindings = { new Binding(), },
                IamOwned = false,
            };
            mockGrpcClient.Setup(x => x.SetIamPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SnapshotsClient client = new SnapshotsClientImpl(mockGrpcClient.Object, null);
            Policy responseCallSettings = await client.SetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Policy responseCancellationToken = await client.SetIamPolicyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetIamPolicy()
        {
            moq::Mock<Snapshots.SnapshotsClient> mockGrpcClient = new moq::Mock<Snapshots.SnapshotsClient>(moq::MockBehavior.Strict);
            SetIamPolicySnapshotRequest request = new SetIamPolicySnapshotRequest
            {
                Resource = "resource164eab96",
                Project = "projectaa6ff846",
                GlobalSetPolicyRequestResource = new GlobalSetPolicyRequest(),
            };
            Policy expectedResponse = new Policy
            {
                Etag = "etage8ad7218",
                Rules = { new Rule(), },
                AuditConfigs = { new AuditConfig(), },
                Version = 271578922,
                Bindings = { new Binding(), },
                IamOwned = false,
            };
            mockGrpcClient.Setup(x => x.SetIamPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SnapshotsClient client = new SnapshotsClientImpl(mockGrpcClient.Object, null);
            Policy response = client.SetIamPolicy(request.Project, request.Resource, request.GlobalSetPolicyRequestResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetIamPolicyAsync()
        {
            moq::Mock<Snapshots.SnapshotsClient> mockGrpcClient = new moq::Mock<Snapshots.SnapshotsClient>(moq::MockBehavior.Strict);
            SetIamPolicySnapshotRequest request = new SetIamPolicySnapshotRequest
            {
                Resource = "resource164eab96",
                Project = "projectaa6ff846",
                GlobalSetPolicyRequestResource = new GlobalSetPolicyRequest(),
            };
            Policy expectedResponse = new Policy
            {
                Etag = "etage8ad7218",
                Rules = { new Rule(), },
                AuditConfigs = { new AuditConfig(), },
                Version = 271578922,
                Bindings = { new Binding(), },
                IamOwned = false,
            };
            mockGrpcClient.Setup(x => x.SetIamPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SnapshotsClient client = new SnapshotsClientImpl(mockGrpcClient.Object, null);
            Policy responseCallSettings = await client.SetIamPolicyAsync(request.Project, request.Resource, request.GlobalSetPolicyRequestResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Policy responseCancellationToken = await client.SetIamPolicyAsync(request.Project, request.Resource, request.GlobalSetPolicyRequestResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetLabelsRequestObject()
        {
            moq::Mock<Snapshots.SnapshotsClient> mockGrpcClient = new moq::Mock<Snapshots.SnapshotsClient>(moq::MockBehavior.Strict);
            SetLabelsSnapshotRequest request = new SetLabelsSnapshotRequest
            {
                Resource = "resource164eab96",
                Project = "projectaa6ff846",
                GlobalSetLabelsRequestResource = new GlobalSetLabelsRequest(),
            };
            Operation expectedResponse = new Operation
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                User = "userb1cb11ee",
                Zone = "zone255f4ea8",
                CreationTimestamp = "creation_timestamp235e59a1",
                StartTime = "start_timebd8dd9c4",
                OperationGroupId = "operation_group_idd2040cf0",
                TargetLink = "target_link9b435dc0",
                Progress = 278622268,
                Error = new Error(),
                EndTime = "end_time89285d30",
                Region = "regionedb20d96",
                OperationType = "operation_typeece9e153",
                Status = Operation.Types.Status.Pending,
                HttpErrorMessage = "http_error_messageb5ef3c7f",
                TargetId = "target_id16dfe255",
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.SetLabels(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SnapshotsClient client = new SnapshotsClientImpl(mockGrpcClient.Object, null);
            Operation response = client.SetLabels(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetLabelsRequestObjectAsync()
        {
            moq::Mock<Snapshots.SnapshotsClient> mockGrpcClient = new moq::Mock<Snapshots.SnapshotsClient>(moq::MockBehavior.Strict);
            SetLabelsSnapshotRequest request = new SetLabelsSnapshotRequest
            {
                Resource = "resource164eab96",
                Project = "projectaa6ff846",
                GlobalSetLabelsRequestResource = new GlobalSetLabelsRequest(),
            };
            Operation expectedResponse = new Operation
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                User = "userb1cb11ee",
                Zone = "zone255f4ea8",
                CreationTimestamp = "creation_timestamp235e59a1",
                StartTime = "start_timebd8dd9c4",
                OperationGroupId = "operation_group_idd2040cf0",
                TargetLink = "target_link9b435dc0",
                Progress = 278622268,
                Error = new Error(),
                EndTime = "end_time89285d30",
                Region = "regionedb20d96",
                OperationType = "operation_typeece9e153",
                Status = Operation.Types.Status.Pending,
                HttpErrorMessage = "http_error_messageb5ef3c7f",
                TargetId = "target_id16dfe255",
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.SetLabelsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SnapshotsClient client = new SnapshotsClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.SetLabelsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.SetLabelsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetLabels()
        {
            moq::Mock<Snapshots.SnapshotsClient> mockGrpcClient = new moq::Mock<Snapshots.SnapshotsClient>(moq::MockBehavior.Strict);
            SetLabelsSnapshotRequest request = new SetLabelsSnapshotRequest
            {
                Resource = "resource164eab96",
                Project = "projectaa6ff846",
                GlobalSetLabelsRequestResource = new GlobalSetLabelsRequest(),
            };
            Operation expectedResponse = new Operation
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                User = "userb1cb11ee",
                Zone = "zone255f4ea8",
                CreationTimestamp = "creation_timestamp235e59a1",
                StartTime = "start_timebd8dd9c4",
                OperationGroupId = "operation_group_idd2040cf0",
                TargetLink = "target_link9b435dc0",
                Progress = 278622268,
                Error = new Error(),
                EndTime = "end_time89285d30",
                Region = "regionedb20d96",
                OperationType = "operation_typeece9e153",
                Status = Operation.Types.Status.Pending,
                HttpErrorMessage = "http_error_messageb5ef3c7f",
                TargetId = "target_id16dfe255",
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.SetLabels(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SnapshotsClient client = new SnapshotsClientImpl(mockGrpcClient.Object, null);
            Operation response = client.SetLabels(request.Project, request.Resource, request.GlobalSetLabelsRequestResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetLabelsAsync()
        {
            moq::Mock<Snapshots.SnapshotsClient> mockGrpcClient = new moq::Mock<Snapshots.SnapshotsClient>(moq::MockBehavior.Strict);
            SetLabelsSnapshotRequest request = new SetLabelsSnapshotRequest
            {
                Resource = "resource164eab96",
                Project = "projectaa6ff846",
                GlobalSetLabelsRequestResource = new GlobalSetLabelsRequest(),
            };
            Operation expectedResponse = new Operation
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                User = "userb1cb11ee",
                Zone = "zone255f4ea8",
                CreationTimestamp = "creation_timestamp235e59a1",
                StartTime = "start_timebd8dd9c4",
                OperationGroupId = "operation_group_idd2040cf0",
                TargetLink = "target_link9b435dc0",
                Progress = 278622268,
                Error = new Error(),
                EndTime = "end_time89285d30",
                Region = "regionedb20d96",
                OperationType = "operation_typeece9e153",
                Status = Operation.Types.Status.Pending,
                HttpErrorMessage = "http_error_messageb5ef3c7f",
                TargetId = "target_id16dfe255",
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.SetLabelsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SnapshotsClient client = new SnapshotsClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.SetLabelsAsync(request.Project, request.Resource, request.GlobalSetLabelsRequestResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.SetLabelsAsync(request.Project, request.Resource, request.GlobalSetLabelsRequestResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void TestIamPermissionsRequestObject()
        {
            moq::Mock<Snapshots.SnapshotsClient> mockGrpcClient = new moq::Mock<Snapshots.SnapshotsClient>(moq::MockBehavior.Strict);
            TestIamPermissionsSnapshotRequest request = new TestIamPermissionsSnapshotRequest
            {
                Resource = "resource164eab96",
                Project = "projectaa6ff846",
                TestPermissionsRequestResource = new TestPermissionsRequest(),
            };
            TestPermissionsResponse expectedResponse = new TestPermissionsResponse
            {
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            mockGrpcClient.Setup(x => x.TestIamPermissions(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SnapshotsClient client = new SnapshotsClientImpl(mockGrpcClient.Object, null);
            TestPermissionsResponse response = client.TestIamPermissions(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task TestIamPermissionsRequestObjectAsync()
        {
            moq::Mock<Snapshots.SnapshotsClient> mockGrpcClient = new moq::Mock<Snapshots.SnapshotsClient>(moq::MockBehavior.Strict);
            TestIamPermissionsSnapshotRequest request = new TestIamPermissionsSnapshotRequest
            {
                Resource = "resource164eab96",
                Project = "projectaa6ff846",
                TestPermissionsRequestResource = new TestPermissionsRequest(),
            };
            TestPermissionsResponse expectedResponse = new TestPermissionsResponse
            {
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            mockGrpcClient.Setup(x => x.TestIamPermissionsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TestPermissionsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SnapshotsClient client = new SnapshotsClientImpl(mockGrpcClient.Object, null);
            TestPermissionsResponse responseCallSettings = await client.TestIamPermissionsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TestPermissionsResponse responseCancellationToken = await client.TestIamPermissionsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void TestIamPermissions()
        {
            moq::Mock<Snapshots.SnapshotsClient> mockGrpcClient = new moq::Mock<Snapshots.SnapshotsClient>(moq::MockBehavior.Strict);
            TestIamPermissionsSnapshotRequest request = new TestIamPermissionsSnapshotRequest
            {
                Resource = "resource164eab96",
                Project = "projectaa6ff846",
                TestPermissionsRequestResource = new TestPermissionsRequest(),
            };
            TestPermissionsResponse expectedResponse = new TestPermissionsResponse
            {
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            mockGrpcClient.Setup(x => x.TestIamPermissions(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SnapshotsClient client = new SnapshotsClientImpl(mockGrpcClient.Object, null);
            TestPermissionsResponse response = client.TestIamPermissions(request.Project, request.Resource, request.TestPermissionsRequestResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task TestIamPermissionsAsync()
        {
            moq::Mock<Snapshots.SnapshotsClient> mockGrpcClient = new moq::Mock<Snapshots.SnapshotsClient>(moq::MockBehavior.Strict);
            TestIamPermissionsSnapshotRequest request = new TestIamPermissionsSnapshotRequest
            {
                Resource = "resource164eab96",
                Project = "projectaa6ff846",
                TestPermissionsRequestResource = new TestPermissionsRequest(),
            };
            TestPermissionsResponse expectedResponse = new TestPermissionsResponse
            {
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            mockGrpcClient.Setup(x => x.TestIamPermissionsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TestPermissionsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SnapshotsClient client = new SnapshotsClientImpl(mockGrpcClient.Object, null);
            TestPermissionsResponse responseCallSettings = await client.TestIamPermissionsAsync(request.Project, request.Resource, request.TestPermissionsRequestResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TestPermissionsResponse responseCancellationToken = await client.TestIamPermissionsAsync(request.Project, request.Resource, request.TestPermissionsRequestResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
