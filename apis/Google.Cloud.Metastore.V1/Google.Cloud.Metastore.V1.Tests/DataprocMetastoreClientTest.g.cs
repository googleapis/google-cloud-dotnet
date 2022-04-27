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

namespace Google.Cloud.Metastore.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedDataprocMetastoreClientTest
    {
        [xunit::FactAttribute]
        public void GetServiceRequestObject()
        {
            moq::Mock<DataprocMetastore.DataprocMetastoreClient> mockGrpcClient = new moq::Mock<DataprocMetastore.DataprocMetastoreClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetServiceRequest request = new GetServiceRequest
            {
                ServiceName = ServiceName.FromProjectLocationService("[PROJECT]", "[LOCATION]", "[SERVICE]"),
            };
            Service expectedResponse = new Service
            {
                ServiceName = ServiceName.FromProjectLocationService("[PROJECT]", "[LOCATION]", "[SERVICE]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                HiveMetastoreConfig = new HiveMetastoreConfig(),
                NetworkAsNetworkName = NetworkName.FromProjectNetwork("[PROJECT]", "[NETWORK]"),
                EndpointUri = "endpoint_uri59c03c94",
                Port = -78310000,
                State = Service.Types.State.Deleting,
                StateMessage = "state_message46cf28c0",
                ArtifactGcsUri = "artifact_gcs_uri4d2b3985",
                Tier = Service.Types.Tier.Developer,
                MaintenanceWindow = new MaintenanceWindow(),
                Uid = "uida2d37198",
                MetadataManagementActivity = new MetadataManagementActivity(),
                ReleaseChannel = Service.Types.ReleaseChannel.Stable,
            };
            mockGrpcClient.Setup(x => x.GetService(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataprocMetastoreClient client = new DataprocMetastoreClientImpl(mockGrpcClient.Object, null, null);
            Service response = client.GetService(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetServiceRequestObjectAsync()
        {
            moq::Mock<DataprocMetastore.DataprocMetastoreClient> mockGrpcClient = new moq::Mock<DataprocMetastore.DataprocMetastoreClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetServiceRequest request = new GetServiceRequest
            {
                ServiceName = ServiceName.FromProjectLocationService("[PROJECT]", "[LOCATION]", "[SERVICE]"),
            };
            Service expectedResponse = new Service
            {
                ServiceName = ServiceName.FromProjectLocationService("[PROJECT]", "[LOCATION]", "[SERVICE]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                HiveMetastoreConfig = new HiveMetastoreConfig(),
                NetworkAsNetworkName = NetworkName.FromProjectNetwork("[PROJECT]", "[NETWORK]"),
                EndpointUri = "endpoint_uri59c03c94",
                Port = -78310000,
                State = Service.Types.State.Deleting,
                StateMessage = "state_message46cf28c0",
                ArtifactGcsUri = "artifact_gcs_uri4d2b3985",
                Tier = Service.Types.Tier.Developer,
                MaintenanceWindow = new MaintenanceWindow(),
                Uid = "uida2d37198",
                MetadataManagementActivity = new MetadataManagementActivity(),
                ReleaseChannel = Service.Types.ReleaseChannel.Stable,
            };
            mockGrpcClient.Setup(x => x.GetServiceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Service>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataprocMetastoreClient client = new DataprocMetastoreClientImpl(mockGrpcClient.Object, null, null);
            Service responseCallSettings = await client.GetServiceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Service responseCancellationToken = await client.GetServiceAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetService()
        {
            moq::Mock<DataprocMetastore.DataprocMetastoreClient> mockGrpcClient = new moq::Mock<DataprocMetastore.DataprocMetastoreClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetServiceRequest request = new GetServiceRequest
            {
                ServiceName = ServiceName.FromProjectLocationService("[PROJECT]", "[LOCATION]", "[SERVICE]"),
            };
            Service expectedResponse = new Service
            {
                ServiceName = ServiceName.FromProjectLocationService("[PROJECT]", "[LOCATION]", "[SERVICE]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                HiveMetastoreConfig = new HiveMetastoreConfig(),
                NetworkAsNetworkName = NetworkName.FromProjectNetwork("[PROJECT]", "[NETWORK]"),
                EndpointUri = "endpoint_uri59c03c94",
                Port = -78310000,
                State = Service.Types.State.Deleting,
                StateMessage = "state_message46cf28c0",
                ArtifactGcsUri = "artifact_gcs_uri4d2b3985",
                Tier = Service.Types.Tier.Developer,
                MaintenanceWindow = new MaintenanceWindow(),
                Uid = "uida2d37198",
                MetadataManagementActivity = new MetadataManagementActivity(),
                ReleaseChannel = Service.Types.ReleaseChannel.Stable,
            };
            mockGrpcClient.Setup(x => x.GetService(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataprocMetastoreClient client = new DataprocMetastoreClientImpl(mockGrpcClient.Object, null, null);
            Service response = client.GetService(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetServiceAsync()
        {
            moq::Mock<DataprocMetastore.DataprocMetastoreClient> mockGrpcClient = new moq::Mock<DataprocMetastore.DataprocMetastoreClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetServiceRequest request = new GetServiceRequest
            {
                ServiceName = ServiceName.FromProjectLocationService("[PROJECT]", "[LOCATION]", "[SERVICE]"),
            };
            Service expectedResponse = new Service
            {
                ServiceName = ServiceName.FromProjectLocationService("[PROJECT]", "[LOCATION]", "[SERVICE]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                HiveMetastoreConfig = new HiveMetastoreConfig(),
                NetworkAsNetworkName = NetworkName.FromProjectNetwork("[PROJECT]", "[NETWORK]"),
                EndpointUri = "endpoint_uri59c03c94",
                Port = -78310000,
                State = Service.Types.State.Deleting,
                StateMessage = "state_message46cf28c0",
                ArtifactGcsUri = "artifact_gcs_uri4d2b3985",
                Tier = Service.Types.Tier.Developer,
                MaintenanceWindow = new MaintenanceWindow(),
                Uid = "uida2d37198",
                MetadataManagementActivity = new MetadataManagementActivity(),
                ReleaseChannel = Service.Types.ReleaseChannel.Stable,
            };
            mockGrpcClient.Setup(x => x.GetServiceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Service>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataprocMetastoreClient client = new DataprocMetastoreClientImpl(mockGrpcClient.Object, null, null);
            Service responseCallSettings = await client.GetServiceAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Service responseCancellationToken = await client.GetServiceAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetServiceResourceNames()
        {
            moq::Mock<DataprocMetastore.DataprocMetastoreClient> mockGrpcClient = new moq::Mock<DataprocMetastore.DataprocMetastoreClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetServiceRequest request = new GetServiceRequest
            {
                ServiceName = ServiceName.FromProjectLocationService("[PROJECT]", "[LOCATION]", "[SERVICE]"),
            };
            Service expectedResponse = new Service
            {
                ServiceName = ServiceName.FromProjectLocationService("[PROJECT]", "[LOCATION]", "[SERVICE]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                HiveMetastoreConfig = new HiveMetastoreConfig(),
                NetworkAsNetworkName = NetworkName.FromProjectNetwork("[PROJECT]", "[NETWORK]"),
                EndpointUri = "endpoint_uri59c03c94",
                Port = -78310000,
                State = Service.Types.State.Deleting,
                StateMessage = "state_message46cf28c0",
                ArtifactGcsUri = "artifact_gcs_uri4d2b3985",
                Tier = Service.Types.Tier.Developer,
                MaintenanceWindow = new MaintenanceWindow(),
                Uid = "uida2d37198",
                MetadataManagementActivity = new MetadataManagementActivity(),
                ReleaseChannel = Service.Types.ReleaseChannel.Stable,
            };
            mockGrpcClient.Setup(x => x.GetService(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataprocMetastoreClient client = new DataprocMetastoreClientImpl(mockGrpcClient.Object, null, null);
            Service response = client.GetService(request.ServiceName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetServiceResourceNamesAsync()
        {
            moq::Mock<DataprocMetastore.DataprocMetastoreClient> mockGrpcClient = new moq::Mock<DataprocMetastore.DataprocMetastoreClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetServiceRequest request = new GetServiceRequest
            {
                ServiceName = ServiceName.FromProjectLocationService("[PROJECT]", "[LOCATION]", "[SERVICE]"),
            };
            Service expectedResponse = new Service
            {
                ServiceName = ServiceName.FromProjectLocationService("[PROJECT]", "[LOCATION]", "[SERVICE]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                HiveMetastoreConfig = new HiveMetastoreConfig(),
                NetworkAsNetworkName = NetworkName.FromProjectNetwork("[PROJECT]", "[NETWORK]"),
                EndpointUri = "endpoint_uri59c03c94",
                Port = -78310000,
                State = Service.Types.State.Deleting,
                StateMessage = "state_message46cf28c0",
                ArtifactGcsUri = "artifact_gcs_uri4d2b3985",
                Tier = Service.Types.Tier.Developer,
                MaintenanceWindow = new MaintenanceWindow(),
                Uid = "uida2d37198",
                MetadataManagementActivity = new MetadataManagementActivity(),
                ReleaseChannel = Service.Types.ReleaseChannel.Stable,
            };
            mockGrpcClient.Setup(x => x.GetServiceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Service>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataprocMetastoreClient client = new DataprocMetastoreClientImpl(mockGrpcClient.Object, null, null);
            Service responseCallSettings = await client.GetServiceAsync(request.ServiceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Service responseCancellationToken = await client.GetServiceAsync(request.ServiceName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetMetadataImportRequestObject()
        {
            moq::Mock<DataprocMetastore.DataprocMetastoreClient> mockGrpcClient = new moq::Mock<DataprocMetastore.DataprocMetastoreClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetMetadataImportRequest request = new GetMetadataImportRequest
            {
                MetadataImportName = MetadataImportName.FromProjectLocationServiceMetadataImport("[PROJECT]", "[LOCATION]", "[SERVICE]", "[METADATA_IMPORT]"),
            };
            MetadataImport expectedResponse = new MetadataImport
            {
                MetadataImportName = MetadataImportName.FromProjectLocationServiceMetadataImport("[PROJECT]", "[LOCATION]", "[SERVICE]", "[METADATA_IMPORT]"),
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                State = MetadataImport.Types.State.Updating,
                DatabaseDump = new MetadataImport.Types.DatabaseDump(),
                EndTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetMetadataImport(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataprocMetastoreClient client = new DataprocMetastoreClientImpl(mockGrpcClient.Object, null, null);
            MetadataImport response = client.GetMetadataImport(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetMetadataImportRequestObjectAsync()
        {
            moq::Mock<DataprocMetastore.DataprocMetastoreClient> mockGrpcClient = new moq::Mock<DataprocMetastore.DataprocMetastoreClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetMetadataImportRequest request = new GetMetadataImportRequest
            {
                MetadataImportName = MetadataImportName.FromProjectLocationServiceMetadataImport("[PROJECT]", "[LOCATION]", "[SERVICE]", "[METADATA_IMPORT]"),
            };
            MetadataImport expectedResponse = new MetadataImport
            {
                MetadataImportName = MetadataImportName.FromProjectLocationServiceMetadataImport("[PROJECT]", "[LOCATION]", "[SERVICE]", "[METADATA_IMPORT]"),
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                State = MetadataImport.Types.State.Updating,
                DatabaseDump = new MetadataImport.Types.DatabaseDump(),
                EndTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetMetadataImportAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MetadataImport>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataprocMetastoreClient client = new DataprocMetastoreClientImpl(mockGrpcClient.Object, null, null);
            MetadataImport responseCallSettings = await client.GetMetadataImportAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            MetadataImport responseCancellationToken = await client.GetMetadataImportAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetMetadataImport()
        {
            moq::Mock<DataprocMetastore.DataprocMetastoreClient> mockGrpcClient = new moq::Mock<DataprocMetastore.DataprocMetastoreClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetMetadataImportRequest request = new GetMetadataImportRequest
            {
                MetadataImportName = MetadataImportName.FromProjectLocationServiceMetadataImport("[PROJECT]", "[LOCATION]", "[SERVICE]", "[METADATA_IMPORT]"),
            };
            MetadataImport expectedResponse = new MetadataImport
            {
                MetadataImportName = MetadataImportName.FromProjectLocationServiceMetadataImport("[PROJECT]", "[LOCATION]", "[SERVICE]", "[METADATA_IMPORT]"),
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                State = MetadataImport.Types.State.Updating,
                DatabaseDump = new MetadataImport.Types.DatabaseDump(),
                EndTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetMetadataImport(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataprocMetastoreClient client = new DataprocMetastoreClientImpl(mockGrpcClient.Object, null, null);
            MetadataImport response = client.GetMetadataImport(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetMetadataImportAsync()
        {
            moq::Mock<DataprocMetastore.DataprocMetastoreClient> mockGrpcClient = new moq::Mock<DataprocMetastore.DataprocMetastoreClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetMetadataImportRequest request = new GetMetadataImportRequest
            {
                MetadataImportName = MetadataImportName.FromProjectLocationServiceMetadataImport("[PROJECT]", "[LOCATION]", "[SERVICE]", "[METADATA_IMPORT]"),
            };
            MetadataImport expectedResponse = new MetadataImport
            {
                MetadataImportName = MetadataImportName.FromProjectLocationServiceMetadataImport("[PROJECT]", "[LOCATION]", "[SERVICE]", "[METADATA_IMPORT]"),
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                State = MetadataImport.Types.State.Updating,
                DatabaseDump = new MetadataImport.Types.DatabaseDump(),
                EndTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetMetadataImportAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MetadataImport>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataprocMetastoreClient client = new DataprocMetastoreClientImpl(mockGrpcClient.Object, null, null);
            MetadataImport responseCallSettings = await client.GetMetadataImportAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            MetadataImport responseCancellationToken = await client.GetMetadataImportAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetMetadataImportResourceNames()
        {
            moq::Mock<DataprocMetastore.DataprocMetastoreClient> mockGrpcClient = new moq::Mock<DataprocMetastore.DataprocMetastoreClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetMetadataImportRequest request = new GetMetadataImportRequest
            {
                MetadataImportName = MetadataImportName.FromProjectLocationServiceMetadataImport("[PROJECT]", "[LOCATION]", "[SERVICE]", "[METADATA_IMPORT]"),
            };
            MetadataImport expectedResponse = new MetadataImport
            {
                MetadataImportName = MetadataImportName.FromProjectLocationServiceMetadataImport("[PROJECT]", "[LOCATION]", "[SERVICE]", "[METADATA_IMPORT]"),
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                State = MetadataImport.Types.State.Updating,
                DatabaseDump = new MetadataImport.Types.DatabaseDump(),
                EndTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetMetadataImport(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataprocMetastoreClient client = new DataprocMetastoreClientImpl(mockGrpcClient.Object, null, null);
            MetadataImport response = client.GetMetadataImport(request.MetadataImportName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetMetadataImportResourceNamesAsync()
        {
            moq::Mock<DataprocMetastore.DataprocMetastoreClient> mockGrpcClient = new moq::Mock<DataprocMetastore.DataprocMetastoreClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetMetadataImportRequest request = new GetMetadataImportRequest
            {
                MetadataImportName = MetadataImportName.FromProjectLocationServiceMetadataImport("[PROJECT]", "[LOCATION]", "[SERVICE]", "[METADATA_IMPORT]"),
            };
            MetadataImport expectedResponse = new MetadataImport
            {
                MetadataImportName = MetadataImportName.FromProjectLocationServiceMetadataImport("[PROJECT]", "[LOCATION]", "[SERVICE]", "[METADATA_IMPORT]"),
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                State = MetadataImport.Types.State.Updating,
                DatabaseDump = new MetadataImport.Types.DatabaseDump(),
                EndTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetMetadataImportAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MetadataImport>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataprocMetastoreClient client = new DataprocMetastoreClientImpl(mockGrpcClient.Object, null, null);
            MetadataImport responseCallSettings = await client.GetMetadataImportAsync(request.MetadataImportName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            MetadataImport responseCancellationToken = await client.GetMetadataImportAsync(request.MetadataImportName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetBackupRequestObject()
        {
            moq::Mock<DataprocMetastore.DataprocMetastoreClient> mockGrpcClient = new moq::Mock<DataprocMetastore.DataprocMetastoreClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetBackupRequest request = new GetBackupRequest
            {
                BackupName = BackupName.FromProjectLocationServiceBackup("[PROJECT]", "[LOCATION]", "[SERVICE]", "[BACKUP]"),
            };
            Backup expectedResponse = new Backup
            {
                BackupName = BackupName.FromProjectLocationServiceBackup("[PROJECT]", "[LOCATION]", "[SERVICE]", "[BACKUP]"),
                CreateTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                State = Backup.Types.State.Unspecified,
                ServiceRevision = new Service(),
                Description = "description2cf9da67",
                RestoringServices =
                {
                    "restoring_servicese2c88107",
                },
            };
            mockGrpcClient.Setup(x => x.GetBackup(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataprocMetastoreClient client = new DataprocMetastoreClientImpl(mockGrpcClient.Object, null, null);
            Backup response = client.GetBackup(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetBackupRequestObjectAsync()
        {
            moq::Mock<DataprocMetastore.DataprocMetastoreClient> mockGrpcClient = new moq::Mock<DataprocMetastore.DataprocMetastoreClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetBackupRequest request = new GetBackupRequest
            {
                BackupName = BackupName.FromProjectLocationServiceBackup("[PROJECT]", "[LOCATION]", "[SERVICE]", "[BACKUP]"),
            };
            Backup expectedResponse = new Backup
            {
                BackupName = BackupName.FromProjectLocationServiceBackup("[PROJECT]", "[LOCATION]", "[SERVICE]", "[BACKUP]"),
                CreateTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                State = Backup.Types.State.Unspecified,
                ServiceRevision = new Service(),
                Description = "description2cf9da67",
                RestoringServices =
                {
                    "restoring_servicese2c88107",
                },
            };
            mockGrpcClient.Setup(x => x.GetBackupAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Backup>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataprocMetastoreClient client = new DataprocMetastoreClientImpl(mockGrpcClient.Object, null, null);
            Backup responseCallSettings = await client.GetBackupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Backup responseCancellationToken = await client.GetBackupAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetBackup()
        {
            moq::Mock<DataprocMetastore.DataprocMetastoreClient> mockGrpcClient = new moq::Mock<DataprocMetastore.DataprocMetastoreClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetBackupRequest request = new GetBackupRequest
            {
                BackupName = BackupName.FromProjectLocationServiceBackup("[PROJECT]", "[LOCATION]", "[SERVICE]", "[BACKUP]"),
            };
            Backup expectedResponse = new Backup
            {
                BackupName = BackupName.FromProjectLocationServiceBackup("[PROJECT]", "[LOCATION]", "[SERVICE]", "[BACKUP]"),
                CreateTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                State = Backup.Types.State.Unspecified,
                ServiceRevision = new Service(),
                Description = "description2cf9da67",
                RestoringServices =
                {
                    "restoring_servicese2c88107",
                },
            };
            mockGrpcClient.Setup(x => x.GetBackup(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataprocMetastoreClient client = new DataprocMetastoreClientImpl(mockGrpcClient.Object, null, null);
            Backup response = client.GetBackup(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetBackupAsync()
        {
            moq::Mock<DataprocMetastore.DataprocMetastoreClient> mockGrpcClient = new moq::Mock<DataprocMetastore.DataprocMetastoreClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetBackupRequest request = new GetBackupRequest
            {
                BackupName = BackupName.FromProjectLocationServiceBackup("[PROJECT]", "[LOCATION]", "[SERVICE]", "[BACKUP]"),
            };
            Backup expectedResponse = new Backup
            {
                BackupName = BackupName.FromProjectLocationServiceBackup("[PROJECT]", "[LOCATION]", "[SERVICE]", "[BACKUP]"),
                CreateTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                State = Backup.Types.State.Unspecified,
                ServiceRevision = new Service(),
                Description = "description2cf9da67",
                RestoringServices =
                {
                    "restoring_servicese2c88107",
                },
            };
            mockGrpcClient.Setup(x => x.GetBackupAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Backup>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataprocMetastoreClient client = new DataprocMetastoreClientImpl(mockGrpcClient.Object, null, null);
            Backup responseCallSettings = await client.GetBackupAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Backup responseCancellationToken = await client.GetBackupAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetBackupResourceNames()
        {
            moq::Mock<DataprocMetastore.DataprocMetastoreClient> mockGrpcClient = new moq::Mock<DataprocMetastore.DataprocMetastoreClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetBackupRequest request = new GetBackupRequest
            {
                BackupName = BackupName.FromProjectLocationServiceBackup("[PROJECT]", "[LOCATION]", "[SERVICE]", "[BACKUP]"),
            };
            Backup expectedResponse = new Backup
            {
                BackupName = BackupName.FromProjectLocationServiceBackup("[PROJECT]", "[LOCATION]", "[SERVICE]", "[BACKUP]"),
                CreateTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                State = Backup.Types.State.Unspecified,
                ServiceRevision = new Service(),
                Description = "description2cf9da67",
                RestoringServices =
                {
                    "restoring_servicese2c88107",
                },
            };
            mockGrpcClient.Setup(x => x.GetBackup(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataprocMetastoreClient client = new DataprocMetastoreClientImpl(mockGrpcClient.Object, null, null);
            Backup response = client.GetBackup(request.BackupName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetBackupResourceNamesAsync()
        {
            moq::Mock<DataprocMetastore.DataprocMetastoreClient> mockGrpcClient = new moq::Mock<DataprocMetastore.DataprocMetastoreClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetBackupRequest request = new GetBackupRequest
            {
                BackupName = BackupName.FromProjectLocationServiceBackup("[PROJECT]", "[LOCATION]", "[SERVICE]", "[BACKUP]"),
            };
            Backup expectedResponse = new Backup
            {
                BackupName = BackupName.FromProjectLocationServiceBackup("[PROJECT]", "[LOCATION]", "[SERVICE]", "[BACKUP]"),
                CreateTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                State = Backup.Types.State.Unspecified,
                ServiceRevision = new Service(),
                Description = "description2cf9da67",
                RestoringServices =
                {
                    "restoring_servicese2c88107",
                },
            };
            mockGrpcClient.Setup(x => x.GetBackupAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Backup>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataprocMetastoreClient client = new DataprocMetastoreClientImpl(mockGrpcClient.Object, null, null);
            Backup responseCallSettings = await client.GetBackupAsync(request.BackupName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Backup responseCancellationToken = await client.GetBackupAsync(request.BackupName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
