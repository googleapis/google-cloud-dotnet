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
using gr = Google.Rpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.CloudDms.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedDataMigrationServiceClientTest
    {
        [xunit::FactAttribute]
        public void GetMigrationJobRequestObject()
        {
            moq::Mock<DataMigrationService.DataMigrationServiceClient> mockGrpcClient = new moq::Mock<DataMigrationService.DataMigrationServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetMigrationJobRequest request = new GetMigrationJobRequest
            {
                MigrationJobName = MigrationJobName.FromProjectLocationMigrationJob("[PROJECT]", "[LOCATION]", "[MIGRATION_JOB]"),
            };
            MigrationJob expectedResponse = new MigrationJob
            {
                MigrationJobName = MigrationJobName.FromProjectLocationMigrationJob("[PROJECT]", "[LOCATION]", "[MIGRATION_JOB]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                DisplayName = "display_name137f65c2",
                State = MigrationJob.Types.State.Restarting,
                Phase = MigrationJob.Types.Phase.WaitingForSourceWritesToStop,
                Type = MigrationJob.Types.Type.Unspecified,
                DumpPath = "dump_path9da43556",
                Source = "sourcef438cd36",
                Destination = "destination43a59069",
                Duration = new wkt::Duration(),
                Error = new gr::Status(),
                SourceDatabase = new DatabaseType(),
                DestinationDatabase = new DatabaseType(),
                EndTime = new wkt::Timestamp(),
                ReverseSshConnectivity = new ReverseSshConnectivity(),
                VpcPeeringConnectivity = new VpcPeeringConnectivity(),
                StaticIpConnectivity = new StaticIpConnectivity(),
            };
            mockGrpcClient.Setup(x => x.GetMigrationJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataMigrationServiceClient client = new DataMigrationServiceClientImpl(mockGrpcClient.Object, null);
            MigrationJob response = client.GetMigrationJob(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetMigrationJobRequestObjectAsync()
        {
            moq::Mock<DataMigrationService.DataMigrationServiceClient> mockGrpcClient = new moq::Mock<DataMigrationService.DataMigrationServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetMigrationJobRequest request = new GetMigrationJobRequest
            {
                MigrationJobName = MigrationJobName.FromProjectLocationMigrationJob("[PROJECT]", "[LOCATION]", "[MIGRATION_JOB]"),
            };
            MigrationJob expectedResponse = new MigrationJob
            {
                MigrationJobName = MigrationJobName.FromProjectLocationMigrationJob("[PROJECT]", "[LOCATION]", "[MIGRATION_JOB]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                DisplayName = "display_name137f65c2",
                State = MigrationJob.Types.State.Restarting,
                Phase = MigrationJob.Types.Phase.WaitingForSourceWritesToStop,
                Type = MigrationJob.Types.Type.Unspecified,
                DumpPath = "dump_path9da43556",
                Source = "sourcef438cd36",
                Destination = "destination43a59069",
                Duration = new wkt::Duration(),
                Error = new gr::Status(),
                SourceDatabase = new DatabaseType(),
                DestinationDatabase = new DatabaseType(),
                EndTime = new wkt::Timestamp(),
                ReverseSshConnectivity = new ReverseSshConnectivity(),
                VpcPeeringConnectivity = new VpcPeeringConnectivity(),
                StaticIpConnectivity = new StaticIpConnectivity(),
            };
            mockGrpcClient.Setup(x => x.GetMigrationJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MigrationJob>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataMigrationServiceClient client = new DataMigrationServiceClientImpl(mockGrpcClient.Object, null);
            MigrationJob responseCallSettings = await client.GetMigrationJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            MigrationJob responseCancellationToken = await client.GetMigrationJobAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetMigrationJob()
        {
            moq::Mock<DataMigrationService.DataMigrationServiceClient> mockGrpcClient = new moq::Mock<DataMigrationService.DataMigrationServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetMigrationJobRequest request = new GetMigrationJobRequest
            {
                MigrationJobName = MigrationJobName.FromProjectLocationMigrationJob("[PROJECT]", "[LOCATION]", "[MIGRATION_JOB]"),
            };
            MigrationJob expectedResponse = new MigrationJob
            {
                MigrationJobName = MigrationJobName.FromProjectLocationMigrationJob("[PROJECT]", "[LOCATION]", "[MIGRATION_JOB]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                DisplayName = "display_name137f65c2",
                State = MigrationJob.Types.State.Restarting,
                Phase = MigrationJob.Types.Phase.WaitingForSourceWritesToStop,
                Type = MigrationJob.Types.Type.Unspecified,
                DumpPath = "dump_path9da43556",
                Source = "sourcef438cd36",
                Destination = "destination43a59069",
                Duration = new wkt::Duration(),
                Error = new gr::Status(),
                SourceDatabase = new DatabaseType(),
                DestinationDatabase = new DatabaseType(),
                EndTime = new wkt::Timestamp(),
                ReverseSshConnectivity = new ReverseSshConnectivity(),
                VpcPeeringConnectivity = new VpcPeeringConnectivity(),
                StaticIpConnectivity = new StaticIpConnectivity(),
            };
            mockGrpcClient.Setup(x => x.GetMigrationJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataMigrationServiceClient client = new DataMigrationServiceClientImpl(mockGrpcClient.Object, null);
            MigrationJob response = client.GetMigrationJob(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetMigrationJobAsync()
        {
            moq::Mock<DataMigrationService.DataMigrationServiceClient> mockGrpcClient = new moq::Mock<DataMigrationService.DataMigrationServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetMigrationJobRequest request = new GetMigrationJobRequest
            {
                MigrationJobName = MigrationJobName.FromProjectLocationMigrationJob("[PROJECT]", "[LOCATION]", "[MIGRATION_JOB]"),
            };
            MigrationJob expectedResponse = new MigrationJob
            {
                MigrationJobName = MigrationJobName.FromProjectLocationMigrationJob("[PROJECT]", "[LOCATION]", "[MIGRATION_JOB]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                DisplayName = "display_name137f65c2",
                State = MigrationJob.Types.State.Restarting,
                Phase = MigrationJob.Types.Phase.WaitingForSourceWritesToStop,
                Type = MigrationJob.Types.Type.Unspecified,
                DumpPath = "dump_path9da43556",
                Source = "sourcef438cd36",
                Destination = "destination43a59069",
                Duration = new wkt::Duration(),
                Error = new gr::Status(),
                SourceDatabase = new DatabaseType(),
                DestinationDatabase = new DatabaseType(),
                EndTime = new wkt::Timestamp(),
                ReverseSshConnectivity = new ReverseSshConnectivity(),
                VpcPeeringConnectivity = new VpcPeeringConnectivity(),
                StaticIpConnectivity = new StaticIpConnectivity(),
            };
            mockGrpcClient.Setup(x => x.GetMigrationJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MigrationJob>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataMigrationServiceClient client = new DataMigrationServiceClientImpl(mockGrpcClient.Object, null);
            MigrationJob responseCallSettings = await client.GetMigrationJobAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            MigrationJob responseCancellationToken = await client.GetMigrationJobAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetMigrationJobResourceNames()
        {
            moq::Mock<DataMigrationService.DataMigrationServiceClient> mockGrpcClient = new moq::Mock<DataMigrationService.DataMigrationServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetMigrationJobRequest request = new GetMigrationJobRequest
            {
                MigrationJobName = MigrationJobName.FromProjectLocationMigrationJob("[PROJECT]", "[LOCATION]", "[MIGRATION_JOB]"),
            };
            MigrationJob expectedResponse = new MigrationJob
            {
                MigrationJobName = MigrationJobName.FromProjectLocationMigrationJob("[PROJECT]", "[LOCATION]", "[MIGRATION_JOB]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                DisplayName = "display_name137f65c2",
                State = MigrationJob.Types.State.Restarting,
                Phase = MigrationJob.Types.Phase.WaitingForSourceWritesToStop,
                Type = MigrationJob.Types.Type.Unspecified,
                DumpPath = "dump_path9da43556",
                Source = "sourcef438cd36",
                Destination = "destination43a59069",
                Duration = new wkt::Duration(),
                Error = new gr::Status(),
                SourceDatabase = new DatabaseType(),
                DestinationDatabase = new DatabaseType(),
                EndTime = new wkt::Timestamp(),
                ReverseSshConnectivity = new ReverseSshConnectivity(),
                VpcPeeringConnectivity = new VpcPeeringConnectivity(),
                StaticIpConnectivity = new StaticIpConnectivity(),
            };
            mockGrpcClient.Setup(x => x.GetMigrationJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataMigrationServiceClient client = new DataMigrationServiceClientImpl(mockGrpcClient.Object, null);
            MigrationJob response = client.GetMigrationJob(request.MigrationJobName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetMigrationJobResourceNamesAsync()
        {
            moq::Mock<DataMigrationService.DataMigrationServiceClient> mockGrpcClient = new moq::Mock<DataMigrationService.DataMigrationServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetMigrationJobRequest request = new GetMigrationJobRequest
            {
                MigrationJobName = MigrationJobName.FromProjectLocationMigrationJob("[PROJECT]", "[LOCATION]", "[MIGRATION_JOB]"),
            };
            MigrationJob expectedResponse = new MigrationJob
            {
                MigrationJobName = MigrationJobName.FromProjectLocationMigrationJob("[PROJECT]", "[LOCATION]", "[MIGRATION_JOB]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                DisplayName = "display_name137f65c2",
                State = MigrationJob.Types.State.Restarting,
                Phase = MigrationJob.Types.Phase.WaitingForSourceWritesToStop,
                Type = MigrationJob.Types.Type.Unspecified,
                DumpPath = "dump_path9da43556",
                Source = "sourcef438cd36",
                Destination = "destination43a59069",
                Duration = new wkt::Duration(),
                Error = new gr::Status(),
                SourceDatabase = new DatabaseType(),
                DestinationDatabase = new DatabaseType(),
                EndTime = new wkt::Timestamp(),
                ReverseSshConnectivity = new ReverseSshConnectivity(),
                VpcPeeringConnectivity = new VpcPeeringConnectivity(),
                StaticIpConnectivity = new StaticIpConnectivity(),
            };
            mockGrpcClient.Setup(x => x.GetMigrationJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MigrationJob>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataMigrationServiceClient client = new DataMigrationServiceClientImpl(mockGrpcClient.Object, null);
            MigrationJob responseCallSettings = await client.GetMigrationJobAsync(request.MigrationJobName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            MigrationJob responseCancellationToken = await client.GetMigrationJobAsync(request.MigrationJobName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GenerateSshScriptRequestObject()
        {
            moq::Mock<DataMigrationService.DataMigrationServiceClient> mockGrpcClient = new moq::Mock<DataMigrationService.DataMigrationServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GenerateSshScriptRequest request = new GenerateSshScriptRequest
            {
                MigrationJobAsMigrationJobName = MigrationJobName.FromProjectLocationMigrationJob("[PROJECT]", "[LOCATION]", "[MIGRATION_JOB]"),
                Vm = "vm1a826c68",
                VmPort = 1861054020,
                VmCreationConfig = new VmCreationConfig(),
                VmSelectionConfig = new VmSelectionConfig(),
            };
            SshScript expectedResponse = new SshScript
            {
                Script = "scriptdec00532",
            };
            mockGrpcClient.Setup(x => x.GenerateSshScript(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataMigrationServiceClient client = new DataMigrationServiceClientImpl(mockGrpcClient.Object, null);
            SshScript response = client.GenerateSshScript(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GenerateSshScriptRequestObjectAsync()
        {
            moq::Mock<DataMigrationService.DataMigrationServiceClient> mockGrpcClient = new moq::Mock<DataMigrationService.DataMigrationServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GenerateSshScriptRequest request = new GenerateSshScriptRequest
            {
                MigrationJobAsMigrationJobName = MigrationJobName.FromProjectLocationMigrationJob("[PROJECT]", "[LOCATION]", "[MIGRATION_JOB]"),
                Vm = "vm1a826c68",
                VmPort = 1861054020,
                VmCreationConfig = new VmCreationConfig(),
                VmSelectionConfig = new VmSelectionConfig(),
            };
            SshScript expectedResponse = new SshScript
            {
                Script = "scriptdec00532",
            };
            mockGrpcClient.Setup(x => x.GenerateSshScriptAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SshScript>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataMigrationServiceClient client = new DataMigrationServiceClientImpl(mockGrpcClient.Object, null);
            SshScript responseCallSettings = await client.GenerateSshScriptAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SshScript responseCancellationToken = await client.GenerateSshScriptAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetConnectionProfileRequestObject()
        {
            moq::Mock<DataMigrationService.DataMigrationServiceClient> mockGrpcClient = new moq::Mock<DataMigrationService.DataMigrationServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetConnectionProfileRequest request = new GetConnectionProfileRequest
            {
                ConnectionProfileName = ConnectionProfileName.FromProjectLocationConnectionProfile("[PROJECT]", "[LOCATION]", "[CONNECTION_PROFILE]"),
            };
            ConnectionProfile expectedResponse = new ConnectionProfile
            {
                ConnectionProfileName = ConnectionProfileName.FromProjectLocationConnectionProfile("[PROJECT]", "[LOCATION]", "[CONNECTION_PROFILE]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                State = ConnectionProfile.Types.State.Deleted,
                DisplayName = "display_name137f65c2",
                Error = new gr::Status(),
                Provider = DatabaseProvider.Cloudsql,
                Mysql = new MySqlConnectionProfile(),
                Postgresql = new PostgreSqlConnectionProfile(),
                Cloudsql = new CloudSqlConnectionProfile(),
            };
            mockGrpcClient.Setup(x => x.GetConnectionProfile(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataMigrationServiceClient client = new DataMigrationServiceClientImpl(mockGrpcClient.Object, null);
            ConnectionProfile response = client.GetConnectionProfile(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetConnectionProfileRequestObjectAsync()
        {
            moq::Mock<DataMigrationService.DataMigrationServiceClient> mockGrpcClient = new moq::Mock<DataMigrationService.DataMigrationServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetConnectionProfileRequest request = new GetConnectionProfileRequest
            {
                ConnectionProfileName = ConnectionProfileName.FromProjectLocationConnectionProfile("[PROJECT]", "[LOCATION]", "[CONNECTION_PROFILE]"),
            };
            ConnectionProfile expectedResponse = new ConnectionProfile
            {
                ConnectionProfileName = ConnectionProfileName.FromProjectLocationConnectionProfile("[PROJECT]", "[LOCATION]", "[CONNECTION_PROFILE]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                State = ConnectionProfile.Types.State.Deleted,
                DisplayName = "display_name137f65c2",
                Error = new gr::Status(),
                Provider = DatabaseProvider.Cloudsql,
                Mysql = new MySqlConnectionProfile(),
                Postgresql = new PostgreSqlConnectionProfile(),
                Cloudsql = new CloudSqlConnectionProfile(),
            };
            mockGrpcClient.Setup(x => x.GetConnectionProfileAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ConnectionProfile>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataMigrationServiceClient client = new DataMigrationServiceClientImpl(mockGrpcClient.Object, null);
            ConnectionProfile responseCallSettings = await client.GetConnectionProfileAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ConnectionProfile responseCancellationToken = await client.GetConnectionProfileAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetConnectionProfile()
        {
            moq::Mock<DataMigrationService.DataMigrationServiceClient> mockGrpcClient = new moq::Mock<DataMigrationService.DataMigrationServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetConnectionProfileRequest request = new GetConnectionProfileRequest
            {
                ConnectionProfileName = ConnectionProfileName.FromProjectLocationConnectionProfile("[PROJECT]", "[LOCATION]", "[CONNECTION_PROFILE]"),
            };
            ConnectionProfile expectedResponse = new ConnectionProfile
            {
                ConnectionProfileName = ConnectionProfileName.FromProjectLocationConnectionProfile("[PROJECT]", "[LOCATION]", "[CONNECTION_PROFILE]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                State = ConnectionProfile.Types.State.Deleted,
                DisplayName = "display_name137f65c2",
                Error = new gr::Status(),
                Provider = DatabaseProvider.Cloudsql,
                Mysql = new MySqlConnectionProfile(),
                Postgresql = new PostgreSqlConnectionProfile(),
                Cloudsql = new CloudSqlConnectionProfile(),
            };
            mockGrpcClient.Setup(x => x.GetConnectionProfile(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataMigrationServiceClient client = new DataMigrationServiceClientImpl(mockGrpcClient.Object, null);
            ConnectionProfile response = client.GetConnectionProfile(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetConnectionProfileAsync()
        {
            moq::Mock<DataMigrationService.DataMigrationServiceClient> mockGrpcClient = new moq::Mock<DataMigrationService.DataMigrationServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetConnectionProfileRequest request = new GetConnectionProfileRequest
            {
                ConnectionProfileName = ConnectionProfileName.FromProjectLocationConnectionProfile("[PROJECT]", "[LOCATION]", "[CONNECTION_PROFILE]"),
            };
            ConnectionProfile expectedResponse = new ConnectionProfile
            {
                ConnectionProfileName = ConnectionProfileName.FromProjectLocationConnectionProfile("[PROJECT]", "[LOCATION]", "[CONNECTION_PROFILE]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                State = ConnectionProfile.Types.State.Deleted,
                DisplayName = "display_name137f65c2",
                Error = new gr::Status(),
                Provider = DatabaseProvider.Cloudsql,
                Mysql = new MySqlConnectionProfile(),
                Postgresql = new PostgreSqlConnectionProfile(),
                Cloudsql = new CloudSqlConnectionProfile(),
            };
            mockGrpcClient.Setup(x => x.GetConnectionProfileAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ConnectionProfile>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataMigrationServiceClient client = new DataMigrationServiceClientImpl(mockGrpcClient.Object, null);
            ConnectionProfile responseCallSettings = await client.GetConnectionProfileAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ConnectionProfile responseCancellationToken = await client.GetConnectionProfileAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetConnectionProfileResourceNames()
        {
            moq::Mock<DataMigrationService.DataMigrationServiceClient> mockGrpcClient = new moq::Mock<DataMigrationService.DataMigrationServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetConnectionProfileRequest request = new GetConnectionProfileRequest
            {
                ConnectionProfileName = ConnectionProfileName.FromProjectLocationConnectionProfile("[PROJECT]", "[LOCATION]", "[CONNECTION_PROFILE]"),
            };
            ConnectionProfile expectedResponse = new ConnectionProfile
            {
                ConnectionProfileName = ConnectionProfileName.FromProjectLocationConnectionProfile("[PROJECT]", "[LOCATION]", "[CONNECTION_PROFILE]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                State = ConnectionProfile.Types.State.Deleted,
                DisplayName = "display_name137f65c2",
                Error = new gr::Status(),
                Provider = DatabaseProvider.Cloudsql,
                Mysql = new MySqlConnectionProfile(),
                Postgresql = new PostgreSqlConnectionProfile(),
                Cloudsql = new CloudSqlConnectionProfile(),
            };
            mockGrpcClient.Setup(x => x.GetConnectionProfile(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataMigrationServiceClient client = new DataMigrationServiceClientImpl(mockGrpcClient.Object, null);
            ConnectionProfile response = client.GetConnectionProfile(request.ConnectionProfileName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetConnectionProfileResourceNamesAsync()
        {
            moq::Mock<DataMigrationService.DataMigrationServiceClient> mockGrpcClient = new moq::Mock<DataMigrationService.DataMigrationServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetConnectionProfileRequest request = new GetConnectionProfileRequest
            {
                ConnectionProfileName = ConnectionProfileName.FromProjectLocationConnectionProfile("[PROJECT]", "[LOCATION]", "[CONNECTION_PROFILE]"),
            };
            ConnectionProfile expectedResponse = new ConnectionProfile
            {
                ConnectionProfileName = ConnectionProfileName.FromProjectLocationConnectionProfile("[PROJECT]", "[LOCATION]", "[CONNECTION_PROFILE]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                State = ConnectionProfile.Types.State.Deleted,
                DisplayName = "display_name137f65c2",
                Error = new gr::Status(),
                Provider = DatabaseProvider.Cloudsql,
                Mysql = new MySqlConnectionProfile(),
                Postgresql = new PostgreSqlConnectionProfile(),
                Cloudsql = new CloudSqlConnectionProfile(),
            };
            mockGrpcClient.Setup(x => x.GetConnectionProfileAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ConnectionProfile>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataMigrationServiceClient client = new DataMigrationServiceClientImpl(mockGrpcClient.Object, null);
            ConnectionProfile responseCallSettings = await client.GetConnectionProfileAsync(request.ConnectionProfileName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ConnectionProfile responseCancellationToken = await client.GetConnectionProfileAsync(request.ConnectionProfileName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
