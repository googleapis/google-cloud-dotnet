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
using lro = Google.LongRunning;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.GkeBackup.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedBackupForGKEClientTest
    {
        [xunit::FactAttribute]
        public void GetBackupPlanRequestObject()
        {
            moq::Mock<BackupForGKE.BackupForGKEClient> mockGrpcClient = new moq::Mock<BackupForGKE.BackupForGKEClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetBackupPlanRequest request = new GetBackupPlanRequest
            {
                BackupPlanName = BackupPlanName.FromProjectLocationBackupPlan("[PROJECT]", "[LOCATION]", "[BACKUP_PLAN]"),
            };
            BackupPlan expectedResponse = new BackupPlan
            {
                BackupPlanName = BackupPlanName.FromProjectLocationBackupPlan("[PROJECT]", "[LOCATION]", "[BACKUP_PLAN]"),
                Uid = "uida2d37198",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Description = "description2cf9da67",
                ClusterAsClusterName = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]"),
                RetentionPolicy = new BackupPlan.Types.RetentionPolicy(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                BackupSchedule = new BackupPlan.Types.Schedule(),
                Etag = "etage8ad7218",
                Deactivated = true,
                BackupConfig = new BackupPlan.Types.BackupConfig(),
                ProtectedPodCount = -665447518,
            };
            mockGrpcClient.Setup(x => x.GetBackupPlan(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BackupForGKEClient client = new BackupForGKEClientImpl(mockGrpcClient.Object, null);
            BackupPlan response = client.GetBackupPlan(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetBackupPlanRequestObjectAsync()
        {
            moq::Mock<BackupForGKE.BackupForGKEClient> mockGrpcClient = new moq::Mock<BackupForGKE.BackupForGKEClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetBackupPlanRequest request = new GetBackupPlanRequest
            {
                BackupPlanName = BackupPlanName.FromProjectLocationBackupPlan("[PROJECT]", "[LOCATION]", "[BACKUP_PLAN]"),
            };
            BackupPlan expectedResponse = new BackupPlan
            {
                BackupPlanName = BackupPlanName.FromProjectLocationBackupPlan("[PROJECT]", "[LOCATION]", "[BACKUP_PLAN]"),
                Uid = "uida2d37198",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Description = "description2cf9da67",
                ClusterAsClusterName = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]"),
                RetentionPolicy = new BackupPlan.Types.RetentionPolicy(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                BackupSchedule = new BackupPlan.Types.Schedule(),
                Etag = "etage8ad7218",
                Deactivated = true,
                BackupConfig = new BackupPlan.Types.BackupConfig(),
                ProtectedPodCount = -665447518,
            };
            mockGrpcClient.Setup(x => x.GetBackupPlanAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<BackupPlan>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BackupForGKEClient client = new BackupForGKEClientImpl(mockGrpcClient.Object, null);
            BackupPlan responseCallSettings = await client.GetBackupPlanAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            BackupPlan responseCancellationToken = await client.GetBackupPlanAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetBackupPlan()
        {
            moq::Mock<BackupForGKE.BackupForGKEClient> mockGrpcClient = new moq::Mock<BackupForGKE.BackupForGKEClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetBackupPlanRequest request = new GetBackupPlanRequest
            {
                BackupPlanName = BackupPlanName.FromProjectLocationBackupPlan("[PROJECT]", "[LOCATION]", "[BACKUP_PLAN]"),
            };
            BackupPlan expectedResponse = new BackupPlan
            {
                BackupPlanName = BackupPlanName.FromProjectLocationBackupPlan("[PROJECT]", "[LOCATION]", "[BACKUP_PLAN]"),
                Uid = "uida2d37198",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Description = "description2cf9da67",
                ClusterAsClusterName = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]"),
                RetentionPolicy = new BackupPlan.Types.RetentionPolicy(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                BackupSchedule = new BackupPlan.Types.Schedule(),
                Etag = "etage8ad7218",
                Deactivated = true,
                BackupConfig = new BackupPlan.Types.BackupConfig(),
                ProtectedPodCount = -665447518,
            };
            mockGrpcClient.Setup(x => x.GetBackupPlan(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BackupForGKEClient client = new BackupForGKEClientImpl(mockGrpcClient.Object, null);
            BackupPlan response = client.GetBackupPlan(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetBackupPlanAsync()
        {
            moq::Mock<BackupForGKE.BackupForGKEClient> mockGrpcClient = new moq::Mock<BackupForGKE.BackupForGKEClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetBackupPlanRequest request = new GetBackupPlanRequest
            {
                BackupPlanName = BackupPlanName.FromProjectLocationBackupPlan("[PROJECT]", "[LOCATION]", "[BACKUP_PLAN]"),
            };
            BackupPlan expectedResponse = new BackupPlan
            {
                BackupPlanName = BackupPlanName.FromProjectLocationBackupPlan("[PROJECT]", "[LOCATION]", "[BACKUP_PLAN]"),
                Uid = "uida2d37198",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Description = "description2cf9da67",
                ClusterAsClusterName = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]"),
                RetentionPolicy = new BackupPlan.Types.RetentionPolicy(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                BackupSchedule = new BackupPlan.Types.Schedule(),
                Etag = "etage8ad7218",
                Deactivated = true,
                BackupConfig = new BackupPlan.Types.BackupConfig(),
                ProtectedPodCount = -665447518,
            };
            mockGrpcClient.Setup(x => x.GetBackupPlanAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<BackupPlan>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BackupForGKEClient client = new BackupForGKEClientImpl(mockGrpcClient.Object, null);
            BackupPlan responseCallSettings = await client.GetBackupPlanAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            BackupPlan responseCancellationToken = await client.GetBackupPlanAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetBackupPlanResourceNames()
        {
            moq::Mock<BackupForGKE.BackupForGKEClient> mockGrpcClient = new moq::Mock<BackupForGKE.BackupForGKEClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetBackupPlanRequest request = new GetBackupPlanRequest
            {
                BackupPlanName = BackupPlanName.FromProjectLocationBackupPlan("[PROJECT]", "[LOCATION]", "[BACKUP_PLAN]"),
            };
            BackupPlan expectedResponse = new BackupPlan
            {
                BackupPlanName = BackupPlanName.FromProjectLocationBackupPlan("[PROJECT]", "[LOCATION]", "[BACKUP_PLAN]"),
                Uid = "uida2d37198",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Description = "description2cf9da67",
                ClusterAsClusterName = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]"),
                RetentionPolicy = new BackupPlan.Types.RetentionPolicy(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                BackupSchedule = new BackupPlan.Types.Schedule(),
                Etag = "etage8ad7218",
                Deactivated = true,
                BackupConfig = new BackupPlan.Types.BackupConfig(),
                ProtectedPodCount = -665447518,
            };
            mockGrpcClient.Setup(x => x.GetBackupPlan(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BackupForGKEClient client = new BackupForGKEClientImpl(mockGrpcClient.Object, null);
            BackupPlan response = client.GetBackupPlan(request.BackupPlanName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetBackupPlanResourceNamesAsync()
        {
            moq::Mock<BackupForGKE.BackupForGKEClient> mockGrpcClient = new moq::Mock<BackupForGKE.BackupForGKEClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetBackupPlanRequest request = new GetBackupPlanRequest
            {
                BackupPlanName = BackupPlanName.FromProjectLocationBackupPlan("[PROJECT]", "[LOCATION]", "[BACKUP_PLAN]"),
            };
            BackupPlan expectedResponse = new BackupPlan
            {
                BackupPlanName = BackupPlanName.FromProjectLocationBackupPlan("[PROJECT]", "[LOCATION]", "[BACKUP_PLAN]"),
                Uid = "uida2d37198",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Description = "description2cf9da67",
                ClusterAsClusterName = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]"),
                RetentionPolicy = new BackupPlan.Types.RetentionPolicy(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                BackupSchedule = new BackupPlan.Types.Schedule(),
                Etag = "etage8ad7218",
                Deactivated = true,
                BackupConfig = new BackupPlan.Types.BackupConfig(),
                ProtectedPodCount = -665447518,
            };
            mockGrpcClient.Setup(x => x.GetBackupPlanAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<BackupPlan>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BackupForGKEClient client = new BackupForGKEClientImpl(mockGrpcClient.Object, null);
            BackupPlan responseCallSettings = await client.GetBackupPlanAsync(request.BackupPlanName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            BackupPlan responseCancellationToken = await client.GetBackupPlanAsync(request.BackupPlanName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetBackupRequestObject()
        {
            moq::Mock<BackupForGKE.BackupForGKEClient> mockGrpcClient = new moq::Mock<BackupForGKE.BackupForGKEClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetBackupRequest request = new GetBackupRequest
            {
                BackupName = BackupName.FromProjectLocationBackupPlanBackup("[PROJECT]", "[LOCATION]", "[BACKUP_PLAN]", "[BACKUP]"),
            };
            Backup expectedResponse = new Backup
            {
                BackupName = BackupName.FromProjectLocationBackupPlanBackup("[PROJECT]", "[LOCATION]", "[BACKUP_PLAN]", "[BACKUP]"),
                Uid = "uida2d37198",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Manual = true,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                DeleteLockDays = -375208966,
                DeleteLockExpireTime = new wkt::Timestamp(),
                RetainDays = -1359863673,
                RetainExpireTime = new wkt::Timestamp(),
                EncryptionKey = new EncryptionKey(),
                AllNamespaces = true,
                SelectedNamespaces = new Namespaces(),
                SelectedApplications = new NamespacedNames(),
                ContainsVolumeData = false,
                ContainsSecrets = true,
                ClusterMetadata = new Backup.Types.ClusterMetadata(),
                State = Backup.Types.State.Unspecified,
                StateReason = "state_reason088c2d9e",
                CompleteTime = new wkt::Timestamp(),
                ResourceCount = 1107734283,
                VolumeCount = 255261769,
                SizeBytes = 4628423819757039038L,
                Etag = "etage8ad7218",
                Description = "description2cf9da67",
                PodCount = 982644455,
                ConfigBackupSizeBytes = 4446168126582654344L,
            };
            mockGrpcClient.Setup(x => x.GetBackup(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BackupForGKEClient client = new BackupForGKEClientImpl(mockGrpcClient.Object, null);
            Backup response = client.GetBackup(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetBackupRequestObjectAsync()
        {
            moq::Mock<BackupForGKE.BackupForGKEClient> mockGrpcClient = new moq::Mock<BackupForGKE.BackupForGKEClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetBackupRequest request = new GetBackupRequest
            {
                BackupName = BackupName.FromProjectLocationBackupPlanBackup("[PROJECT]", "[LOCATION]", "[BACKUP_PLAN]", "[BACKUP]"),
            };
            Backup expectedResponse = new Backup
            {
                BackupName = BackupName.FromProjectLocationBackupPlanBackup("[PROJECT]", "[LOCATION]", "[BACKUP_PLAN]", "[BACKUP]"),
                Uid = "uida2d37198",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Manual = true,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                DeleteLockDays = -375208966,
                DeleteLockExpireTime = new wkt::Timestamp(),
                RetainDays = -1359863673,
                RetainExpireTime = new wkt::Timestamp(),
                EncryptionKey = new EncryptionKey(),
                AllNamespaces = true,
                SelectedNamespaces = new Namespaces(),
                SelectedApplications = new NamespacedNames(),
                ContainsVolumeData = false,
                ContainsSecrets = true,
                ClusterMetadata = new Backup.Types.ClusterMetadata(),
                State = Backup.Types.State.Unspecified,
                StateReason = "state_reason088c2d9e",
                CompleteTime = new wkt::Timestamp(),
                ResourceCount = 1107734283,
                VolumeCount = 255261769,
                SizeBytes = 4628423819757039038L,
                Etag = "etage8ad7218",
                Description = "description2cf9da67",
                PodCount = 982644455,
                ConfigBackupSizeBytes = 4446168126582654344L,
            };
            mockGrpcClient.Setup(x => x.GetBackupAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Backup>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BackupForGKEClient client = new BackupForGKEClientImpl(mockGrpcClient.Object, null);
            Backup responseCallSettings = await client.GetBackupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Backup responseCancellationToken = await client.GetBackupAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetBackup()
        {
            moq::Mock<BackupForGKE.BackupForGKEClient> mockGrpcClient = new moq::Mock<BackupForGKE.BackupForGKEClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetBackupRequest request = new GetBackupRequest
            {
                BackupName = BackupName.FromProjectLocationBackupPlanBackup("[PROJECT]", "[LOCATION]", "[BACKUP_PLAN]", "[BACKUP]"),
            };
            Backup expectedResponse = new Backup
            {
                BackupName = BackupName.FromProjectLocationBackupPlanBackup("[PROJECT]", "[LOCATION]", "[BACKUP_PLAN]", "[BACKUP]"),
                Uid = "uida2d37198",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Manual = true,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                DeleteLockDays = -375208966,
                DeleteLockExpireTime = new wkt::Timestamp(),
                RetainDays = -1359863673,
                RetainExpireTime = new wkt::Timestamp(),
                EncryptionKey = new EncryptionKey(),
                AllNamespaces = true,
                SelectedNamespaces = new Namespaces(),
                SelectedApplications = new NamespacedNames(),
                ContainsVolumeData = false,
                ContainsSecrets = true,
                ClusterMetadata = new Backup.Types.ClusterMetadata(),
                State = Backup.Types.State.Unspecified,
                StateReason = "state_reason088c2d9e",
                CompleteTime = new wkt::Timestamp(),
                ResourceCount = 1107734283,
                VolumeCount = 255261769,
                SizeBytes = 4628423819757039038L,
                Etag = "etage8ad7218",
                Description = "description2cf9da67",
                PodCount = 982644455,
                ConfigBackupSizeBytes = 4446168126582654344L,
            };
            mockGrpcClient.Setup(x => x.GetBackup(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BackupForGKEClient client = new BackupForGKEClientImpl(mockGrpcClient.Object, null);
            Backup response = client.GetBackup(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetBackupAsync()
        {
            moq::Mock<BackupForGKE.BackupForGKEClient> mockGrpcClient = new moq::Mock<BackupForGKE.BackupForGKEClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetBackupRequest request = new GetBackupRequest
            {
                BackupName = BackupName.FromProjectLocationBackupPlanBackup("[PROJECT]", "[LOCATION]", "[BACKUP_PLAN]", "[BACKUP]"),
            };
            Backup expectedResponse = new Backup
            {
                BackupName = BackupName.FromProjectLocationBackupPlanBackup("[PROJECT]", "[LOCATION]", "[BACKUP_PLAN]", "[BACKUP]"),
                Uid = "uida2d37198",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Manual = true,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                DeleteLockDays = -375208966,
                DeleteLockExpireTime = new wkt::Timestamp(),
                RetainDays = -1359863673,
                RetainExpireTime = new wkt::Timestamp(),
                EncryptionKey = new EncryptionKey(),
                AllNamespaces = true,
                SelectedNamespaces = new Namespaces(),
                SelectedApplications = new NamespacedNames(),
                ContainsVolumeData = false,
                ContainsSecrets = true,
                ClusterMetadata = new Backup.Types.ClusterMetadata(),
                State = Backup.Types.State.Unspecified,
                StateReason = "state_reason088c2d9e",
                CompleteTime = new wkt::Timestamp(),
                ResourceCount = 1107734283,
                VolumeCount = 255261769,
                SizeBytes = 4628423819757039038L,
                Etag = "etage8ad7218",
                Description = "description2cf9da67",
                PodCount = 982644455,
                ConfigBackupSizeBytes = 4446168126582654344L,
            };
            mockGrpcClient.Setup(x => x.GetBackupAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Backup>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BackupForGKEClient client = new BackupForGKEClientImpl(mockGrpcClient.Object, null);
            Backup responseCallSettings = await client.GetBackupAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Backup responseCancellationToken = await client.GetBackupAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetBackupResourceNames()
        {
            moq::Mock<BackupForGKE.BackupForGKEClient> mockGrpcClient = new moq::Mock<BackupForGKE.BackupForGKEClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetBackupRequest request = new GetBackupRequest
            {
                BackupName = BackupName.FromProjectLocationBackupPlanBackup("[PROJECT]", "[LOCATION]", "[BACKUP_PLAN]", "[BACKUP]"),
            };
            Backup expectedResponse = new Backup
            {
                BackupName = BackupName.FromProjectLocationBackupPlanBackup("[PROJECT]", "[LOCATION]", "[BACKUP_PLAN]", "[BACKUP]"),
                Uid = "uida2d37198",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Manual = true,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                DeleteLockDays = -375208966,
                DeleteLockExpireTime = new wkt::Timestamp(),
                RetainDays = -1359863673,
                RetainExpireTime = new wkt::Timestamp(),
                EncryptionKey = new EncryptionKey(),
                AllNamespaces = true,
                SelectedNamespaces = new Namespaces(),
                SelectedApplications = new NamespacedNames(),
                ContainsVolumeData = false,
                ContainsSecrets = true,
                ClusterMetadata = new Backup.Types.ClusterMetadata(),
                State = Backup.Types.State.Unspecified,
                StateReason = "state_reason088c2d9e",
                CompleteTime = new wkt::Timestamp(),
                ResourceCount = 1107734283,
                VolumeCount = 255261769,
                SizeBytes = 4628423819757039038L,
                Etag = "etage8ad7218",
                Description = "description2cf9da67",
                PodCount = 982644455,
                ConfigBackupSizeBytes = 4446168126582654344L,
            };
            mockGrpcClient.Setup(x => x.GetBackup(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BackupForGKEClient client = new BackupForGKEClientImpl(mockGrpcClient.Object, null);
            Backup response = client.GetBackup(request.BackupName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetBackupResourceNamesAsync()
        {
            moq::Mock<BackupForGKE.BackupForGKEClient> mockGrpcClient = new moq::Mock<BackupForGKE.BackupForGKEClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetBackupRequest request = new GetBackupRequest
            {
                BackupName = BackupName.FromProjectLocationBackupPlanBackup("[PROJECT]", "[LOCATION]", "[BACKUP_PLAN]", "[BACKUP]"),
            };
            Backup expectedResponse = new Backup
            {
                BackupName = BackupName.FromProjectLocationBackupPlanBackup("[PROJECT]", "[LOCATION]", "[BACKUP_PLAN]", "[BACKUP]"),
                Uid = "uida2d37198",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Manual = true,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                DeleteLockDays = -375208966,
                DeleteLockExpireTime = new wkt::Timestamp(),
                RetainDays = -1359863673,
                RetainExpireTime = new wkt::Timestamp(),
                EncryptionKey = new EncryptionKey(),
                AllNamespaces = true,
                SelectedNamespaces = new Namespaces(),
                SelectedApplications = new NamespacedNames(),
                ContainsVolumeData = false,
                ContainsSecrets = true,
                ClusterMetadata = new Backup.Types.ClusterMetadata(),
                State = Backup.Types.State.Unspecified,
                StateReason = "state_reason088c2d9e",
                CompleteTime = new wkt::Timestamp(),
                ResourceCount = 1107734283,
                VolumeCount = 255261769,
                SizeBytes = 4628423819757039038L,
                Etag = "etage8ad7218",
                Description = "description2cf9da67",
                PodCount = 982644455,
                ConfigBackupSizeBytes = 4446168126582654344L,
            };
            mockGrpcClient.Setup(x => x.GetBackupAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Backup>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BackupForGKEClient client = new BackupForGKEClientImpl(mockGrpcClient.Object, null);
            Backup responseCallSettings = await client.GetBackupAsync(request.BackupName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Backup responseCancellationToken = await client.GetBackupAsync(request.BackupName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetVolumeBackupRequestObject()
        {
            moq::Mock<BackupForGKE.BackupForGKEClient> mockGrpcClient = new moq::Mock<BackupForGKE.BackupForGKEClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetVolumeBackupRequest request = new GetVolumeBackupRequest
            {
                VolumeBackupName = VolumeBackupName.FromProjectLocationBackupPlanBackupVolumeBackup("[PROJECT]", "[LOCATION]", "[BACKUP_PLAN]", "[BACKUP]", "[VOLUME_BACKUP]"),
            };
            VolumeBackup expectedResponse = new VolumeBackup
            {
                VolumeBackupName = VolumeBackupName.FromProjectLocationBackupPlanBackupVolumeBackup("[PROJECT]", "[LOCATION]", "[BACKUP_PLAN]", "[BACKUP]", "[VOLUME_BACKUP]"),
                Uid = "uida2d37198",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                SourcePvc = new NamespacedName(),
                VolumeBackupHandle = "volume_backup_handlecfad4f11",
                Format = VolumeBackup.Types.VolumeBackupFormat.GcePersistentDisk,
                StorageBytes = 8453704516828373557L,
                DiskSizeBytes = -5516951742914183668L,
                CompleteTime = new wkt::Timestamp(),
                State = VolumeBackup.Types.State.Deleting,
                StateMessage = "state_message46cf28c0",
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.GetVolumeBackup(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BackupForGKEClient client = new BackupForGKEClientImpl(mockGrpcClient.Object, null);
            VolumeBackup response = client.GetVolumeBackup(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetVolumeBackupRequestObjectAsync()
        {
            moq::Mock<BackupForGKE.BackupForGKEClient> mockGrpcClient = new moq::Mock<BackupForGKE.BackupForGKEClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetVolumeBackupRequest request = new GetVolumeBackupRequest
            {
                VolumeBackupName = VolumeBackupName.FromProjectLocationBackupPlanBackupVolumeBackup("[PROJECT]", "[LOCATION]", "[BACKUP_PLAN]", "[BACKUP]", "[VOLUME_BACKUP]"),
            };
            VolumeBackup expectedResponse = new VolumeBackup
            {
                VolumeBackupName = VolumeBackupName.FromProjectLocationBackupPlanBackupVolumeBackup("[PROJECT]", "[LOCATION]", "[BACKUP_PLAN]", "[BACKUP]", "[VOLUME_BACKUP]"),
                Uid = "uida2d37198",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                SourcePvc = new NamespacedName(),
                VolumeBackupHandle = "volume_backup_handlecfad4f11",
                Format = VolumeBackup.Types.VolumeBackupFormat.GcePersistentDisk,
                StorageBytes = 8453704516828373557L,
                DiskSizeBytes = -5516951742914183668L,
                CompleteTime = new wkt::Timestamp(),
                State = VolumeBackup.Types.State.Deleting,
                StateMessage = "state_message46cf28c0",
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.GetVolumeBackupAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<VolumeBackup>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BackupForGKEClient client = new BackupForGKEClientImpl(mockGrpcClient.Object, null);
            VolumeBackup responseCallSettings = await client.GetVolumeBackupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            VolumeBackup responseCancellationToken = await client.GetVolumeBackupAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetVolumeBackup()
        {
            moq::Mock<BackupForGKE.BackupForGKEClient> mockGrpcClient = new moq::Mock<BackupForGKE.BackupForGKEClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetVolumeBackupRequest request = new GetVolumeBackupRequest
            {
                VolumeBackupName = VolumeBackupName.FromProjectLocationBackupPlanBackupVolumeBackup("[PROJECT]", "[LOCATION]", "[BACKUP_PLAN]", "[BACKUP]", "[VOLUME_BACKUP]"),
            };
            VolumeBackup expectedResponse = new VolumeBackup
            {
                VolumeBackupName = VolumeBackupName.FromProjectLocationBackupPlanBackupVolumeBackup("[PROJECT]", "[LOCATION]", "[BACKUP_PLAN]", "[BACKUP]", "[VOLUME_BACKUP]"),
                Uid = "uida2d37198",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                SourcePvc = new NamespacedName(),
                VolumeBackupHandle = "volume_backup_handlecfad4f11",
                Format = VolumeBackup.Types.VolumeBackupFormat.GcePersistentDisk,
                StorageBytes = 8453704516828373557L,
                DiskSizeBytes = -5516951742914183668L,
                CompleteTime = new wkt::Timestamp(),
                State = VolumeBackup.Types.State.Deleting,
                StateMessage = "state_message46cf28c0",
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.GetVolumeBackup(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BackupForGKEClient client = new BackupForGKEClientImpl(mockGrpcClient.Object, null);
            VolumeBackup response = client.GetVolumeBackup(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetVolumeBackupAsync()
        {
            moq::Mock<BackupForGKE.BackupForGKEClient> mockGrpcClient = new moq::Mock<BackupForGKE.BackupForGKEClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetVolumeBackupRequest request = new GetVolumeBackupRequest
            {
                VolumeBackupName = VolumeBackupName.FromProjectLocationBackupPlanBackupVolumeBackup("[PROJECT]", "[LOCATION]", "[BACKUP_PLAN]", "[BACKUP]", "[VOLUME_BACKUP]"),
            };
            VolumeBackup expectedResponse = new VolumeBackup
            {
                VolumeBackupName = VolumeBackupName.FromProjectLocationBackupPlanBackupVolumeBackup("[PROJECT]", "[LOCATION]", "[BACKUP_PLAN]", "[BACKUP]", "[VOLUME_BACKUP]"),
                Uid = "uida2d37198",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                SourcePvc = new NamespacedName(),
                VolumeBackupHandle = "volume_backup_handlecfad4f11",
                Format = VolumeBackup.Types.VolumeBackupFormat.GcePersistentDisk,
                StorageBytes = 8453704516828373557L,
                DiskSizeBytes = -5516951742914183668L,
                CompleteTime = new wkt::Timestamp(),
                State = VolumeBackup.Types.State.Deleting,
                StateMessage = "state_message46cf28c0",
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.GetVolumeBackupAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<VolumeBackup>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BackupForGKEClient client = new BackupForGKEClientImpl(mockGrpcClient.Object, null);
            VolumeBackup responseCallSettings = await client.GetVolumeBackupAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            VolumeBackup responseCancellationToken = await client.GetVolumeBackupAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetVolumeBackupResourceNames()
        {
            moq::Mock<BackupForGKE.BackupForGKEClient> mockGrpcClient = new moq::Mock<BackupForGKE.BackupForGKEClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetVolumeBackupRequest request = new GetVolumeBackupRequest
            {
                VolumeBackupName = VolumeBackupName.FromProjectLocationBackupPlanBackupVolumeBackup("[PROJECT]", "[LOCATION]", "[BACKUP_PLAN]", "[BACKUP]", "[VOLUME_BACKUP]"),
            };
            VolumeBackup expectedResponse = new VolumeBackup
            {
                VolumeBackupName = VolumeBackupName.FromProjectLocationBackupPlanBackupVolumeBackup("[PROJECT]", "[LOCATION]", "[BACKUP_PLAN]", "[BACKUP]", "[VOLUME_BACKUP]"),
                Uid = "uida2d37198",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                SourcePvc = new NamespacedName(),
                VolumeBackupHandle = "volume_backup_handlecfad4f11",
                Format = VolumeBackup.Types.VolumeBackupFormat.GcePersistentDisk,
                StorageBytes = 8453704516828373557L,
                DiskSizeBytes = -5516951742914183668L,
                CompleteTime = new wkt::Timestamp(),
                State = VolumeBackup.Types.State.Deleting,
                StateMessage = "state_message46cf28c0",
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.GetVolumeBackup(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BackupForGKEClient client = new BackupForGKEClientImpl(mockGrpcClient.Object, null);
            VolumeBackup response = client.GetVolumeBackup(request.VolumeBackupName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetVolumeBackupResourceNamesAsync()
        {
            moq::Mock<BackupForGKE.BackupForGKEClient> mockGrpcClient = new moq::Mock<BackupForGKE.BackupForGKEClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetVolumeBackupRequest request = new GetVolumeBackupRequest
            {
                VolumeBackupName = VolumeBackupName.FromProjectLocationBackupPlanBackupVolumeBackup("[PROJECT]", "[LOCATION]", "[BACKUP_PLAN]", "[BACKUP]", "[VOLUME_BACKUP]"),
            };
            VolumeBackup expectedResponse = new VolumeBackup
            {
                VolumeBackupName = VolumeBackupName.FromProjectLocationBackupPlanBackupVolumeBackup("[PROJECT]", "[LOCATION]", "[BACKUP_PLAN]", "[BACKUP]", "[VOLUME_BACKUP]"),
                Uid = "uida2d37198",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                SourcePvc = new NamespacedName(),
                VolumeBackupHandle = "volume_backup_handlecfad4f11",
                Format = VolumeBackup.Types.VolumeBackupFormat.GcePersistentDisk,
                StorageBytes = 8453704516828373557L,
                DiskSizeBytes = -5516951742914183668L,
                CompleteTime = new wkt::Timestamp(),
                State = VolumeBackup.Types.State.Deleting,
                StateMessage = "state_message46cf28c0",
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.GetVolumeBackupAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<VolumeBackup>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BackupForGKEClient client = new BackupForGKEClientImpl(mockGrpcClient.Object, null);
            VolumeBackup responseCallSettings = await client.GetVolumeBackupAsync(request.VolumeBackupName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            VolumeBackup responseCancellationToken = await client.GetVolumeBackupAsync(request.VolumeBackupName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetRestorePlanRequestObject()
        {
            moq::Mock<BackupForGKE.BackupForGKEClient> mockGrpcClient = new moq::Mock<BackupForGKE.BackupForGKEClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetRestorePlanRequest request = new GetRestorePlanRequest
            {
                RestorePlanName = RestorePlanName.FromProjectLocationRestorePlan("[PROJECT]", "[LOCATION]", "[RESTORE_PLAN]"),
            };
            RestorePlan expectedResponse = new RestorePlan
            {
                RestorePlanName = RestorePlanName.FromProjectLocationRestorePlan("[PROJECT]", "[LOCATION]", "[RESTORE_PLAN]"),
                Uid = "uida2d37198",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Description = "description2cf9da67",
                BackupPlanAsBackupPlanName = BackupPlanName.FromProjectLocationBackupPlan("[PROJECT]", "[LOCATION]", "[BACKUP_PLAN]"),
                ClusterAsClusterName = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]"),
                RestoreConfig = new RestoreConfig(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.GetRestorePlan(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BackupForGKEClient client = new BackupForGKEClientImpl(mockGrpcClient.Object, null);
            RestorePlan response = client.GetRestorePlan(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRestorePlanRequestObjectAsync()
        {
            moq::Mock<BackupForGKE.BackupForGKEClient> mockGrpcClient = new moq::Mock<BackupForGKE.BackupForGKEClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetRestorePlanRequest request = new GetRestorePlanRequest
            {
                RestorePlanName = RestorePlanName.FromProjectLocationRestorePlan("[PROJECT]", "[LOCATION]", "[RESTORE_PLAN]"),
            };
            RestorePlan expectedResponse = new RestorePlan
            {
                RestorePlanName = RestorePlanName.FromProjectLocationRestorePlan("[PROJECT]", "[LOCATION]", "[RESTORE_PLAN]"),
                Uid = "uida2d37198",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Description = "description2cf9da67",
                BackupPlanAsBackupPlanName = BackupPlanName.FromProjectLocationBackupPlan("[PROJECT]", "[LOCATION]", "[BACKUP_PLAN]"),
                ClusterAsClusterName = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]"),
                RestoreConfig = new RestoreConfig(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.GetRestorePlanAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<RestorePlan>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BackupForGKEClient client = new BackupForGKEClientImpl(mockGrpcClient.Object, null);
            RestorePlan responseCallSettings = await client.GetRestorePlanAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            RestorePlan responseCancellationToken = await client.GetRestorePlanAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetRestorePlan()
        {
            moq::Mock<BackupForGKE.BackupForGKEClient> mockGrpcClient = new moq::Mock<BackupForGKE.BackupForGKEClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetRestorePlanRequest request = new GetRestorePlanRequest
            {
                RestorePlanName = RestorePlanName.FromProjectLocationRestorePlan("[PROJECT]", "[LOCATION]", "[RESTORE_PLAN]"),
            };
            RestorePlan expectedResponse = new RestorePlan
            {
                RestorePlanName = RestorePlanName.FromProjectLocationRestorePlan("[PROJECT]", "[LOCATION]", "[RESTORE_PLAN]"),
                Uid = "uida2d37198",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Description = "description2cf9da67",
                BackupPlanAsBackupPlanName = BackupPlanName.FromProjectLocationBackupPlan("[PROJECT]", "[LOCATION]", "[BACKUP_PLAN]"),
                ClusterAsClusterName = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]"),
                RestoreConfig = new RestoreConfig(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.GetRestorePlan(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BackupForGKEClient client = new BackupForGKEClientImpl(mockGrpcClient.Object, null);
            RestorePlan response = client.GetRestorePlan(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRestorePlanAsync()
        {
            moq::Mock<BackupForGKE.BackupForGKEClient> mockGrpcClient = new moq::Mock<BackupForGKE.BackupForGKEClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetRestorePlanRequest request = new GetRestorePlanRequest
            {
                RestorePlanName = RestorePlanName.FromProjectLocationRestorePlan("[PROJECT]", "[LOCATION]", "[RESTORE_PLAN]"),
            };
            RestorePlan expectedResponse = new RestorePlan
            {
                RestorePlanName = RestorePlanName.FromProjectLocationRestorePlan("[PROJECT]", "[LOCATION]", "[RESTORE_PLAN]"),
                Uid = "uida2d37198",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Description = "description2cf9da67",
                BackupPlanAsBackupPlanName = BackupPlanName.FromProjectLocationBackupPlan("[PROJECT]", "[LOCATION]", "[BACKUP_PLAN]"),
                ClusterAsClusterName = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]"),
                RestoreConfig = new RestoreConfig(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.GetRestorePlanAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<RestorePlan>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BackupForGKEClient client = new BackupForGKEClientImpl(mockGrpcClient.Object, null);
            RestorePlan responseCallSettings = await client.GetRestorePlanAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            RestorePlan responseCancellationToken = await client.GetRestorePlanAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetRestorePlanResourceNames()
        {
            moq::Mock<BackupForGKE.BackupForGKEClient> mockGrpcClient = new moq::Mock<BackupForGKE.BackupForGKEClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetRestorePlanRequest request = new GetRestorePlanRequest
            {
                RestorePlanName = RestorePlanName.FromProjectLocationRestorePlan("[PROJECT]", "[LOCATION]", "[RESTORE_PLAN]"),
            };
            RestorePlan expectedResponse = new RestorePlan
            {
                RestorePlanName = RestorePlanName.FromProjectLocationRestorePlan("[PROJECT]", "[LOCATION]", "[RESTORE_PLAN]"),
                Uid = "uida2d37198",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Description = "description2cf9da67",
                BackupPlanAsBackupPlanName = BackupPlanName.FromProjectLocationBackupPlan("[PROJECT]", "[LOCATION]", "[BACKUP_PLAN]"),
                ClusterAsClusterName = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]"),
                RestoreConfig = new RestoreConfig(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.GetRestorePlan(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BackupForGKEClient client = new BackupForGKEClientImpl(mockGrpcClient.Object, null);
            RestorePlan response = client.GetRestorePlan(request.RestorePlanName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRestorePlanResourceNamesAsync()
        {
            moq::Mock<BackupForGKE.BackupForGKEClient> mockGrpcClient = new moq::Mock<BackupForGKE.BackupForGKEClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetRestorePlanRequest request = new GetRestorePlanRequest
            {
                RestorePlanName = RestorePlanName.FromProjectLocationRestorePlan("[PROJECT]", "[LOCATION]", "[RESTORE_PLAN]"),
            };
            RestorePlan expectedResponse = new RestorePlan
            {
                RestorePlanName = RestorePlanName.FromProjectLocationRestorePlan("[PROJECT]", "[LOCATION]", "[RESTORE_PLAN]"),
                Uid = "uida2d37198",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Description = "description2cf9da67",
                BackupPlanAsBackupPlanName = BackupPlanName.FromProjectLocationBackupPlan("[PROJECT]", "[LOCATION]", "[BACKUP_PLAN]"),
                ClusterAsClusterName = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]"),
                RestoreConfig = new RestoreConfig(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.GetRestorePlanAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<RestorePlan>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BackupForGKEClient client = new BackupForGKEClientImpl(mockGrpcClient.Object, null);
            RestorePlan responseCallSettings = await client.GetRestorePlanAsync(request.RestorePlanName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            RestorePlan responseCancellationToken = await client.GetRestorePlanAsync(request.RestorePlanName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetRestoreRequestObject()
        {
            moq::Mock<BackupForGKE.BackupForGKEClient> mockGrpcClient = new moq::Mock<BackupForGKE.BackupForGKEClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetRestoreRequest request = new GetRestoreRequest
            {
                RestoreName = RestoreName.FromProjectLocationRestorePlanRestore("[PROJECT]", "[LOCATION]", "[RESTORE_PLAN]", "[RESTORE]"),
            };
            Restore expectedResponse = new Restore
            {
                RestoreName = RestoreName.FromProjectLocationRestorePlanRestore("[PROJECT]", "[LOCATION]", "[RESTORE_PLAN]", "[RESTORE]"),
                Uid = "uida2d37198",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Description = "description2cf9da67",
                BackupAsBackupName = BackupName.FromProjectLocationBackupPlanBackup("[PROJECT]", "[LOCATION]", "[BACKUP_PLAN]", "[BACKUP]"),
                ClusterAsClusterName = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]"),
                RestoreConfig = new RestoreConfig(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                State = Restore.Types.State.Unspecified,
                StateReason = "state_reason088c2d9e",
                CompleteTime = new wkt::Timestamp(),
                ResourcesRestoredCount = 861901729,
                ResourcesExcludedCount = -1568494345,
                ResourcesFailedCount = -1370333331,
                VolumesRestoredCount = 142390270,
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.GetRestore(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BackupForGKEClient client = new BackupForGKEClientImpl(mockGrpcClient.Object, null);
            Restore response = client.GetRestore(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRestoreRequestObjectAsync()
        {
            moq::Mock<BackupForGKE.BackupForGKEClient> mockGrpcClient = new moq::Mock<BackupForGKE.BackupForGKEClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetRestoreRequest request = new GetRestoreRequest
            {
                RestoreName = RestoreName.FromProjectLocationRestorePlanRestore("[PROJECT]", "[LOCATION]", "[RESTORE_PLAN]", "[RESTORE]"),
            };
            Restore expectedResponse = new Restore
            {
                RestoreName = RestoreName.FromProjectLocationRestorePlanRestore("[PROJECT]", "[LOCATION]", "[RESTORE_PLAN]", "[RESTORE]"),
                Uid = "uida2d37198",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Description = "description2cf9da67",
                BackupAsBackupName = BackupName.FromProjectLocationBackupPlanBackup("[PROJECT]", "[LOCATION]", "[BACKUP_PLAN]", "[BACKUP]"),
                ClusterAsClusterName = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]"),
                RestoreConfig = new RestoreConfig(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                State = Restore.Types.State.Unspecified,
                StateReason = "state_reason088c2d9e",
                CompleteTime = new wkt::Timestamp(),
                ResourcesRestoredCount = 861901729,
                ResourcesExcludedCount = -1568494345,
                ResourcesFailedCount = -1370333331,
                VolumesRestoredCount = 142390270,
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.GetRestoreAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Restore>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BackupForGKEClient client = new BackupForGKEClientImpl(mockGrpcClient.Object, null);
            Restore responseCallSettings = await client.GetRestoreAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Restore responseCancellationToken = await client.GetRestoreAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetRestore()
        {
            moq::Mock<BackupForGKE.BackupForGKEClient> mockGrpcClient = new moq::Mock<BackupForGKE.BackupForGKEClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetRestoreRequest request = new GetRestoreRequest
            {
                RestoreName = RestoreName.FromProjectLocationRestorePlanRestore("[PROJECT]", "[LOCATION]", "[RESTORE_PLAN]", "[RESTORE]"),
            };
            Restore expectedResponse = new Restore
            {
                RestoreName = RestoreName.FromProjectLocationRestorePlanRestore("[PROJECT]", "[LOCATION]", "[RESTORE_PLAN]", "[RESTORE]"),
                Uid = "uida2d37198",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Description = "description2cf9da67",
                BackupAsBackupName = BackupName.FromProjectLocationBackupPlanBackup("[PROJECT]", "[LOCATION]", "[BACKUP_PLAN]", "[BACKUP]"),
                ClusterAsClusterName = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]"),
                RestoreConfig = new RestoreConfig(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                State = Restore.Types.State.Unspecified,
                StateReason = "state_reason088c2d9e",
                CompleteTime = new wkt::Timestamp(),
                ResourcesRestoredCount = 861901729,
                ResourcesExcludedCount = -1568494345,
                ResourcesFailedCount = -1370333331,
                VolumesRestoredCount = 142390270,
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.GetRestore(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BackupForGKEClient client = new BackupForGKEClientImpl(mockGrpcClient.Object, null);
            Restore response = client.GetRestore(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRestoreAsync()
        {
            moq::Mock<BackupForGKE.BackupForGKEClient> mockGrpcClient = new moq::Mock<BackupForGKE.BackupForGKEClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetRestoreRequest request = new GetRestoreRequest
            {
                RestoreName = RestoreName.FromProjectLocationRestorePlanRestore("[PROJECT]", "[LOCATION]", "[RESTORE_PLAN]", "[RESTORE]"),
            };
            Restore expectedResponse = new Restore
            {
                RestoreName = RestoreName.FromProjectLocationRestorePlanRestore("[PROJECT]", "[LOCATION]", "[RESTORE_PLAN]", "[RESTORE]"),
                Uid = "uida2d37198",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Description = "description2cf9da67",
                BackupAsBackupName = BackupName.FromProjectLocationBackupPlanBackup("[PROJECT]", "[LOCATION]", "[BACKUP_PLAN]", "[BACKUP]"),
                ClusterAsClusterName = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]"),
                RestoreConfig = new RestoreConfig(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                State = Restore.Types.State.Unspecified,
                StateReason = "state_reason088c2d9e",
                CompleteTime = new wkt::Timestamp(),
                ResourcesRestoredCount = 861901729,
                ResourcesExcludedCount = -1568494345,
                ResourcesFailedCount = -1370333331,
                VolumesRestoredCount = 142390270,
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.GetRestoreAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Restore>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BackupForGKEClient client = new BackupForGKEClientImpl(mockGrpcClient.Object, null);
            Restore responseCallSettings = await client.GetRestoreAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Restore responseCancellationToken = await client.GetRestoreAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetRestoreResourceNames()
        {
            moq::Mock<BackupForGKE.BackupForGKEClient> mockGrpcClient = new moq::Mock<BackupForGKE.BackupForGKEClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetRestoreRequest request = new GetRestoreRequest
            {
                RestoreName = RestoreName.FromProjectLocationRestorePlanRestore("[PROJECT]", "[LOCATION]", "[RESTORE_PLAN]", "[RESTORE]"),
            };
            Restore expectedResponse = new Restore
            {
                RestoreName = RestoreName.FromProjectLocationRestorePlanRestore("[PROJECT]", "[LOCATION]", "[RESTORE_PLAN]", "[RESTORE]"),
                Uid = "uida2d37198",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Description = "description2cf9da67",
                BackupAsBackupName = BackupName.FromProjectLocationBackupPlanBackup("[PROJECT]", "[LOCATION]", "[BACKUP_PLAN]", "[BACKUP]"),
                ClusterAsClusterName = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]"),
                RestoreConfig = new RestoreConfig(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                State = Restore.Types.State.Unspecified,
                StateReason = "state_reason088c2d9e",
                CompleteTime = new wkt::Timestamp(),
                ResourcesRestoredCount = 861901729,
                ResourcesExcludedCount = -1568494345,
                ResourcesFailedCount = -1370333331,
                VolumesRestoredCount = 142390270,
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.GetRestore(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BackupForGKEClient client = new BackupForGKEClientImpl(mockGrpcClient.Object, null);
            Restore response = client.GetRestore(request.RestoreName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRestoreResourceNamesAsync()
        {
            moq::Mock<BackupForGKE.BackupForGKEClient> mockGrpcClient = new moq::Mock<BackupForGKE.BackupForGKEClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetRestoreRequest request = new GetRestoreRequest
            {
                RestoreName = RestoreName.FromProjectLocationRestorePlanRestore("[PROJECT]", "[LOCATION]", "[RESTORE_PLAN]", "[RESTORE]"),
            };
            Restore expectedResponse = new Restore
            {
                RestoreName = RestoreName.FromProjectLocationRestorePlanRestore("[PROJECT]", "[LOCATION]", "[RESTORE_PLAN]", "[RESTORE]"),
                Uid = "uida2d37198",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Description = "description2cf9da67",
                BackupAsBackupName = BackupName.FromProjectLocationBackupPlanBackup("[PROJECT]", "[LOCATION]", "[BACKUP_PLAN]", "[BACKUP]"),
                ClusterAsClusterName = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]"),
                RestoreConfig = new RestoreConfig(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                State = Restore.Types.State.Unspecified,
                StateReason = "state_reason088c2d9e",
                CompleteTime = new wkt::Timestamp(),
                ResourcesRestoredCount = 861901729,
                ResourcesExcludedCount = -1568494345,
                ResourcesFailedCount = -1370333331,
                VolumesRestoredCount = 142390270,
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.GetRestoreAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Restore>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BackupForGKEClient client = new BackupForGKEClientImpl(mockGrpcClient.Object, null);
            Restore responseCallSettings = await client.GetRestoreAsync(request.RestoreName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Restore responseCancellationToken = await client.GetRestoreAsync(request.RestoreName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetVolumeRestoreRequestObject()
        {
            moq::Mock<BackupForGKE.BackupForGKEClient> mockGrpcClient = new moq::Mock<BackupForGKE.BackupForGKEClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetVolumeRestoreRequest request = new GetVolumeRestoreRequest
            {
                VolumeRestoreName = VolumeRestoreName.FromProjectLocationRestorePlanRestoreVolumeRestore("[PROJECT]", "[LOCATION]", "[RESTORE_PLAN]", "[RESTORE]", "[VOLUME_RESTORE]"),
            };
            VolumeRestore expectedResponse = new VolumeRestore
            {
                VolumeRestoreName = VolumeRestoreName.FromProjectLocationRestorePlanRestoreVolumeRestore("[PROJECT]", "[LOCATION]", "[RESTORE_PLAN]", "[RESTORE]", "[VOLUME_RESTORE]"),
                Uid = "uida2d37198",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                VolumeBackup = "volume_backup20e76de7",
                TargetPvc = new NamespacedName(),
                VolumeHandle = "volume_handleaeff3155",
                VolumeType = VolumeRestore.Types.VolumeType.GcePersistentDisk,
                CompleteTime = new wkt::Timestamp(),
                State = VolumeRestore.Types.State.Unspecified,
                StateMessage = "state_message46cf28c0",
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.GetVolumeRestore(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BackupForGKEClient client = new BackupForGKEClientImpl(mockGrpcClient.Object, null);
            VolumeRestore response = client.GetVolumeRestore(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetVolumeRestoreRequestObjectAsync()
        {
            moq::Mock<BackupForGKE.BackupForGKEClient> mockGrpcClient = new moq::Mock<BackupForGKE.BackupForGKEClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetVolumeRestoreRequest request = new GetVolumeRestoreRequest
            {
                VolumeRestoreName = VolumeRestoreName.FromProjectLocationRestorePlanRestoreVolumeRestore("[PROJECT]", "[LOCATION]", "[RESTORE_PLAN]", "[RESTORE]", "[VOLUME_RESTORE]"),
            };
            VolumeRestore expectedResponse = new VolumeRestore
            {
                VolumeRestoreName = VolumeRestoreName.FromProjectLocationRestorePlanRestoreVolumeRestore("[PROJECT]", "[LOCATION]", "[RESTORE_PLAN]", "[RESTORE]", "[VOLUME_RESTORE]"),
                Uid = "uida2d37198",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                VolumeBackup = "volume_backup20e76de7",
                TargetPvc = new NamespacedName(),
                VolumeHandle = "volume_handleaeff3155",
                VolumeType = VolumeRestore.Types.VolumeType.GcePersistentDisk,
                CompleteTime = new wkt::Timestamp(),
                State = VolumeRestore.Types.State.Unspecified,
                StateMessage = "state_message46cf28c0",
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.GetVolumeRestoreAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<VolumeRestore>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BackupForGKEClient client = new BackupForGKEClientImpl(mockGrpcClient.Object, null);
            VolumeRestore responseCallSettings = await client.GetVolumeRestoreAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            VolumeRestore responseCancellationToken = await client.GetVolumeRestoreAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetVolumeRestore()
        {
            moq::Mock<BackupForGKE.BackupForGKEClient> mockGrpcClient = new moq::Mock<BackupForGKE.BackupForGKEClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetVolumeRestoreRequest request = new GetVolumeRestoreRequest
            {
                VolumeRestoreName = VolumeRestoreName.FromProjectLocationRestorePlanRestoreVolumeRestore("[PROJECT]", "[LOCATION]", "[RESTORE_PLAN]", "[RESTORE]", "[VOLUME_RESTORE]"),
            };
            VolumeRestore expectedResponse = new VolumeRestore
            {
                VolumeRestoreName = VolumeRestoreName.FromProjectLocationRestorePlanRestoreVolumeRestore("[PROJECT]", "[LOCATION]", "[RESTORE_PLAN]", "[RESTORE]", "[VOLUME_RESTORE]"),
                Uid = "uida2d37198",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                VolumeBackup = "volume_backup20e76de7",
                TargetPvc = new NamespacedName(),
                VolumeHandle = "volume_handleaeff3155",
                VolumeType = VolumeRestore.Types.VolumeType.GcePersistentDisk,
                CompleteTime = new wkt::Timestamp(),
                State = VolumeRestore.Types.State.Unspecified,
                StateMessage = "state_message46cf28c0",
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.GetVolumeRestore(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BackupForGKEClient client = new BackupForGKEClientImpl(mockGrpcClient.Object, null);
            VolumeRestore response = client.GetVolumeRestore(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetVolumeRestoreAsync()
        {
            moq::Mock<BackupForGKE.BackupForGKEClient> mockGrpcClient = new moq::Mock<BackupForGKE.BackupForGKEClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetVolumeRestoreRequest request = new GetVolumeRestoreRequest
            {
                VolumeRestoreName = VolumeRestoreName.FromProjectLocationRestorePlanRestoreVolumeRestore("[PROJECT]", "[LOCATION]", "[RESTORE_PLAN]", "[RESTORE]", "[VOLUME_RESTORE]"),
            };
            VolumeRestore expectedResponse = new VolumeRestore
            {
                VolumeRestoreName = VolumeRestoreName.FromProjectLocationRestorePlanRestoreVolumeRestore("[PROJECT]", "[LOCATION]", "[RESTORE_PLAN]", "[RESTORE]", "[VOLUME_RESTORE]"),
                Uid = "uida2d37198",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                VolumeBackup = "volume_backup20e76de7",
                TargetPvc = new NamespacedName(),
                VolumeHandle = "volume_handleaeff3155",
                VolumeType = VolumeRestore.Types.VolumeType.GcePersistentDisk,
                CompleteTime = new wkt::Timestamp(),
                State = VolumeRestore.Types.State.Unspecified,
                StateMessage = "state_message46cf28c0",
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.GetVolumeRestoreAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<VolumeRestore>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BackupForGKEClient client = new BackupForGKEClientImpl(mockGrpcClient.Object, null);
            VolumeRestore responseCallSettings = await client.GetVolumeRestoreAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            VolumeRestore responseCancellationToken = await client.GetVolumeRestoreAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetVolumeRestoreResourceNames()
        {
            moq::Mock<BackupForGKE.BackupForGKEClient> mockGrpcClient = new moq::Mock<BackupForGKE.BackupForGKEClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetVolumeRestoreRequest request = new GetVolumeRestoreRequest
            {
                VolumeRestoreName = VolumeRestoreName.FromProjectLocationRestorePlanRestoreVolumeRestore("[PROJECT]", "[LOCATION]", "[RESTORE_PLAN]", "[RESTORE]", "[VOLUME_RESTORE]"),
            };
            VolumeRestore expectedResponse = new VolumeRestore
            {
                VolumeRestoreName = VolumeRestoreName.FromProjectLocationRestorePlanRestoreVolumeRestore("[PROJECT]", "[LOCATION]", "[RESTORE_PLAN]", "[RESTORE]", "[VOLUME_RESTORE]"),
                Uid = "uida2d37198",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                VolumeBackup = "volume_backup20e76de7",
                TargetPvc = new NamespacedName(),
                VolumeHandle = "volume_handleaeff3155",
                VolumeType = VolumeRestore.Types.VolumeType.GcePersistentDisk,
                CompleteTime = new wkt::Timestamp(),
                State = VolumeRestore.Types.State.Unspecified,
                StateMessage = "state_message46cf28c0",
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.GetVolumeRestore(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BackupForGKEClient client = new BackupForGKEClientImpl(mockGrpcClient.Object, null);
            VolumeRestore response = client.GetVolumeRestore(request.VolumeRestoreName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetVolumeRestoreResourceNamesAsync()
        {
            moq::Mock<BackupForGKE.BackupForGKEClient> mockGrpcClient = new moq::Mock<BackupForGKE.BackupForGKEClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetVolumeRestoreRequest request = new GetVolumeRestoreRequest
            {
                VolumeRestoreName = VolumeRestoreName.FromProjectLocationRestorePlanRestoreVolumeRestore("[PROJECT]", "[LOCATION]", "[RESTORE_PLAN]", "[RESTORE]", "[VOLUME_RESTORE]"),
            };
            VolumeRestore expectedResponse = new VolumeRestore
            {
                VolumeRestoreName = VolumeRestoreName.FromProjectLocationRestorePlanRestoreVolumeRestore("[PROJECT]", "[LOCATION]", "[RESTORE_PLAN]", "[RESTORE]", "[VOLUME_RESTORE]"),
                Uid = "uida2d37198",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                VolumeBackup = "volume_backup20e76de7",
                TargetPvc = new NamespacedName(),
                VolumeHandle = "volume_handleaeff3155",
                VolumeType = VolumeRestore.Types.VolumeType.GcePersistentDisk,
                CompleteTime = new wkt::Timestamp(),
                State = VolumeRestore.Types.State.Unspecified,
                StateMessage = "state_message46cf28c0",
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.GetVolumeRestoreAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<VolumeRestore>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BackupForGKEClient client = new BackupForGKEClientImpl(mockGrpcClient.Object, null);
            VolumeRestore responseCallSettings = await client.GetVolumeRestoreAsync(request.VolumeRestoreName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            VolumeRestore responseCancellationToken = await client.GetVolumeRestoreAsync(request.VolumeRestoreName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
