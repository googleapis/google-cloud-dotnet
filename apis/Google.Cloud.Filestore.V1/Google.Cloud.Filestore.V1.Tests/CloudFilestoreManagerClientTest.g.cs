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
using lro = Google.LongRunning;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Filestore.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedCloudFilestoreManagerClientTest
    {
        [xunit::FactAttribute]
        public void GetInstanceRequestObject()
        {
            moq::Mock<CloudFilestoreManager.CloudFilestoreManagerClient> mockGrpcClient = new moq::Mock<CloudFilestoreManager.CloudFilestoreManagerClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetInstanceRequest request = new GetInstanceRequest
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
            };
            Instance expectedResponse = new Instance
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                Description = "description2cf9da67",
                State = Instance.Types.State.Restoring,
                StatusMessage = "status_message2c618f86",
                CreateTime = new wkt::Timestamp(),
                Tier = Instance.Types.Tier.Standard,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                FileShares =
                {
                    new FileShareConfig(),
                },
                Networks =
                {
                    new NetworkConfig(),
                },
                Etag = "etage8ad7218",
                SatisfiesPzs = false,
            };
            mockGrpcClient.Setup(x => x.GetInstance(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudFilestoreManagerClient client = new CloudFilestoreManagerClientImpl(mockGrpcClient.Object, null);
            Instance response = client.GetInstance(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetInstanceRequestObjectAsync()
        {
            moq::Mock<CloudFilestoreManager.CloudFilestoreManagerClient> mockGrpcClient = new moq::Mock<CloudFilestoreManager.CloudFilestoreManagerClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetInstanceRequest request = new GetInstanceRequest
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
            };
            Instance expectedResponse = new Instance
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                Description = "description2cf9da67",
                State = Instance.Types.State.Restoring,
                StatusMessage = "status_message2c618f86",
                CreateTime = new wkt::Timestamp(),
                Tier = Instance.Types.Tier.Standard,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                FileShares =
                {
                    new FileShareConfig(),
                },
                Networks =
                {
                    new NetworkConfig(),
                },
                Etag = "etage8ad7218",
                SatisfiesPzs = false,
            };
            mockGrpcClient.Setup(x => x.GetInstanceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Instance>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudFilestoreManagerClient client = new CloudFilestoreManagerClientImpl(mockGrpcClient.Object, null);
            Instance responseCallSettings = await client.GetInstanceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Instance responseCancellationToken = await client.GetInstanceAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetInstance()
        {
            moq::Mock<CloudFilestoreManager.CloudFilestoreManagerClient> mockGrpcClient = new moq::Mock<CloudFilestoreManager.CloudFilestoreManagerClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetInstanceRequest request = new GetInstanceRequest
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
            };
            Instance expectedResponse = new Instance
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                Description = "description2cf9da67",
                State = Instance.Types.State.Restoring,
                StatusMessage = "status_message2c618f86",
                CreateTime = new wkt::Timestamp(),
                Tier = Instance.Types.Tier.Standard,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                FileShares =
                {
                    new FileShareConfig(),
                },
                Networks =
                {
                    new NetworkConfig(),
                },
                Etag = "etage8ad7218",
                SatisfiesPzs = false,
            };
            mockGrpcClient.Setup(x => x.GetInstance(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudFilestoreManagerClient client = new CloudFilestoreManagerClientImpl(mockGrpcClient.Object, null);
            Instance response = client.GetInstance(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetInstanceAsync()
        {
            moq::Mock<CloudFilestoreManager.CloudFilestoreManagerClient> mockGrpcClient = new moq::Mock<CloudFilestoreManager.CloudFilestoreManagerClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetInstanceRequest request = new GetInstanceRequest
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
            };
            Instance expectedResponse = new Instance
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                Description = "description2cf9da67",
                State = Instance.Types.State.Restoring,
                StatusMessage = "status_message2c618f86",
                CreateTime = new wkt::Timestamp(),
                Tier = Instance.Types.Tier.Standard,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                FileShares =
                {
                    new FileShareConfig(),
                },
                Networks =
                {
                    new NetworkConfig(),
                },
                Etag = "etage8ad7218",
                SatisfiesPzs = false,
            };
            mockGrpcClient.Setup(x => x.GetInstanceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Instance>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudFilestoreManagerClient client = new CloudFilestoreManagerClientImpl(mockGrpcClient.Object, null);
            Instance responseCallSettings = await client.GetInstanceAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Instance responseCancellationToken = await client.GetInstanceAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetInstanceResourceNames()
        {
            moq::Mock<CloudFilestoreManager.CloudFilestoreManagerClient> mockGrpcClient = new moq::Mock<CloudFilestoreManager.CloudFilestoreManagerClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetInstanceRequest request = new GetInstanceRequest
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
            };
            Instance expectedResponse = new Instance
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                Description = "description2cf9da67",
                State = Instance.Types.State.Restoring,
                StatusMessage = "status_message2c618f86",
                CreateTime = new wkt::Timestamp(),
                Tier = Instance.Types.Tier.Standard,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                FileShares =
                {
                    new FileShareConfig(),
                },
                Networks =
                {
                    new NetworkConfig(),
                },
                Etag = "etage8ad7218",
                SatisfiesPzs = false,
            };
            mockGrpcClient.Setup(x => x.GetInstance(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudFilestoreManagerClient client = new CloudFilestoreManagerClientImpl(mockGrpcClient.Object, null);
            Instance response = client.GetInstance(request.InstanceName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetInstanceResourceNamesAsync()
        {
            moq::Mock<CloudFilestoreManager.CloudFilestoreManagerClient> mockGrpcClient = new moq::Mock<CloudFilestoreManager.CloudFilestoreManagerClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetInstanceRequest request = new GetInstanceRequest
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
            };
            Instance expectedResponse = new Instance
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                Description = "description2cf9da67",
                State = Instance.Types.State.Restoring,
                StatusMessage = "status_message2c618f86",
                CreateTime = new wkt::Timestamp(),
                Tier = Instance.Types.Tier.Standard,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                FileShares =
                {
                    new FileShareConfig(),
                },
                Networks =
                {
                    new NetworkConfig(),
                },
                Etag = "etage8ad7218",
                SatisfiesPzs = false,
            };
            mockGrpcClient.Setup(x => x.GetInstanceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Instance>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudFilestoreManagerClient client = new CloudFilestoreManagerClientImpl(mockGrpcClient.Object, null);
            Instance responseCallSettings = await client.GetInstanceAsync(request.InstanceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Instance responseCancellationToken = await client.GetInstanceAsync(request.InstanceName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetBackupRequestObject()
        {
            moq::Mock<CloudFilestoreManager.CloudFilestoreManagerClient> mockGrpcClient = new moq::Mock<CloudFilestoreManager.CloudFilestoreManagerClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetBackupRequest request = new GetBackupRequest
            {
                BackupName = BackupName.FromProjectLocationBackup("[PROJECT]", "[LOCATION]", "[BACKUP]"),
            };
            Backup expectedResponse = new Backup
            {
                BackupName = BackupName.FromProjectLocationBackup("[PROJECT]", "[LOCATION]", "[BACKUP]"),
                Description = "description2cf9da67",
                State = Backup.Types.State.Ready,
                CreateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CapacityGb = -8715396619027832166L,
                StorageBytes = 8453704516828373557L,
                SourceInstanceAsInstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                SourceFileShare = "source_file_shareeecce468",
                SourceInstanceTier = Instance.Types.Tier.Premium,
                DownloadBytes = -6512123273633363558L,
                SatisfiesPzs = false,
            };
            mockGrpcClient.Setup(x => x.GetBackup(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudFilestoreManagerClient client = new CloudFilestoreManagerClientImpl(mockGrpcClient.Object, null);
            Backup response = client.GetBackup(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetBackupRequestObjectAsync()
        {
            moq::Mock<CloudFilestoreManager.CloudFilestoreManagerClient> mockGrpcClient = new moq::Mock<CloudFilestoreManager.CloudFilestoreManagerClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetBackupRequest request = new GetBackupRequest
            {
                BackupName = BackupName.FromProjectLocationBackup("[PROJECT]", "[LOCATION]", "[BACKUP]"),
            };
            Backup expectedResponse = new Backup
            {
                BackupName = BackupName.FromProjectLocationBackup("[PROJECT]", "[LOCATION]", "[BACKUP]"),
                Description = "description2cf9da67",
                State = Backup.Types.State.Ready,
                CreateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CapacityGb = -8715396619027832166L,
                StorageBytes = 8453704516828373557L,
                SourceInstanceAsInstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                SourceFileShare = "source_file_shareeecce468",
                SourceInstanceTier = Instance.Types.Tier.Premium,
                DownloadBytes = -6512123273633363558L,
                SatisfiesPzs = false,
            };
            mockGrpcClient.Setup(x => x.GetBackupAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Backup>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudFilestoreManagerClient client = new CloudFilestoreManagerClientImpl(mockGrpcClient.Object, null);
            Backup responseCallSettings = await client.GetBackupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Backup responseCancellationToken = await client.GetBackupAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetBackup()
        {
            moq::Mock<CloudFilestoreManager.CloudFilestoreManagerClient> mockGrpcClient = new moq::Mock<CloudFilestoreManager.CloudFilestoreManagerClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetBackupRequest request = new GetBackupRequest
            {
                BackupName = BackupName.FromProjectLocationBackup("[PROJECT]", "[LOCATION]", "[BACKUP]"),
            };
            Backup expectedResponse = new Backup
            {
                BackupName = BackupName.FromProjectLocationBackup("[PROJECT]", "[LOCATION]", "[BACKUP]"),
                Description = "description2cf9da67",
                State = Backup.Types.State.Ready,
                CreateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CapacityGb = -8715396619027832166L,
                StorageBytes = 8453704516828373557L,
                SourceInstanceAsInstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                SourceFileShare = "source_file_shareeecce468",
                SourceInstanceTier = Instance.Types.Tier.Premium,
                DownloadBytes = -6512123273633363558L,
                SatisfiesPzs = false,
            };
            mockGrpcClient.Setup(x => x.GetBackup(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudFilestoreManagerClient client = new CloudFilestoreManagerClientImpl(mockGrpcClient.Object, null);
            Backup response = client.GetBackup(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetBackupAsync()
        {
            moq::Mock<CloudFilestoreManager.CloudFilestoreManagerClient> mockGrpcClient = new moq::Mock<CloudFilestoreManager.CloudFilestoreManagerClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetBackupRequest request = new GetBackupRequest
            {
                BackupName = BackupName.FromProjectLocationBackup("[PROJECT]", "[LOCATION]", "[BACKUP]"),
            };
            Backup expectedResponse = new Backup
            {
                BackupName = BackupName.FromProjectLocationBackup("[PROJECT]", "[LOCATION]", "[BACKUP]"),
                Description = "description2cf9da67",
                State = Backup.Types.State.Ready,
                CreateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CapacityGb = -8715396619027832166L,
                StorageBytes = 8453704516828373557L,
                SourceInstanceAsInstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                SourceFileShare = "source_file_shareeecce468",
                SourceInstanceTier = Instance.Types.Tier.Premium,
                DownloadBytes = -6512123273633363558L,
                SatisfiesPzs = false,
            };
            mockGrpcClient.Setup(x => x.GetBackupAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Backup>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudFilestoreManagerClient client = new CloudFilestoreManagerClientImpl(mockGrpcClient.Object, null);
            Backup responseCallSettings = await client.GetBackupAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Backup responseCancellationToken = await client.GetBackupAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetBackupResourceNames()
        {
            moq::Mock<CloudFilestoreManager.CloudFilestoreManagerClient> mockGrpcClient = new moq::Mock<CloudFilestoreManager.CloudFilestoreManagerClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetBackupRequest request = new GetBackupRequest
            {
                BackupName = BackupName.FromProjectLocationBackup("[PROJECT]", "[LOCATION]", "[BACKUP]"),
            };
            Backup expectedResponse = new Backup
            {
                BackupName = BackupName.FromProjectLocationBackup("[PROJECT]", "[LOCATION]", "[BACKUP]"),
                Description = "description2cf9da67",
                State = Backup.Types.State.Ready,
                CreateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CapacityGb = -8715396619027832166L,
                StorageBytes = 8453704516828373557L,
                SourceInstanceAsInstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                SourceFileShare = "source_file_shareeecce468",
                SourceInstanceTier = Instance.Types.Tier.Premium,
                DownloadBytes = -6512123273633363558L,
                SatisfiesPzs = false,
            };
            mockGrpcClient.Setup(x => x.GetBackup(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudFilestoreManagerClient client = new CloudFilestoreManagerClientImpl(mockGrpcClient.Object, null);
            Backup response = client.GetBackup(request.BackupName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetBackupResourceNamesAsync()
        {
            moq::Mock<CloudFilestoreManager.CloudFilestoreManagerClient> mockGrpcClient = new moq::Mock<CloudFilestoreManager.CloudFilestoreManagerClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetBackupRequest request = new GetBackupRequest
            {
                BackupName = BackupName.FromProjectLocationBackup("[PROJECT]", "[LOCATION]", "[BACKUP]"),
            };
            Backup expectedResponse = new Backup
            {
                BackupName = BackupName.FromProjectLocationBackup("[PROJECT]", "[LOCATION]", "[BACKUP]"),
                Description = "description2cf9da67",
                State = Backup.Types.State.Ready,
                CreateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CapacityGb = -8715396619027832166L,
                StorageBytes = 8453704516828373557L,
                SourceInstanceAsInstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                SourceFileShare = "source_file_shareeecce468",
                SourceInstanceTier = Instance.Types.Tier.Premium,
                DownloadBytes = -6512123273633363558L,
                SatisfiesPzs = false,
            };
            mockGrpcClient.Setup(x => x.GetBackupAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Backup>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudFilestoreManagerClient client = new CloudFilestoreManagerClientImpl(mockGrpcClient.Object, null);
            Backup responseCallSettings = await client.GetBackupAsync(request.BackupName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Backup responseCancellationToken = await client.GetBackupAsync(request.BackupName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
