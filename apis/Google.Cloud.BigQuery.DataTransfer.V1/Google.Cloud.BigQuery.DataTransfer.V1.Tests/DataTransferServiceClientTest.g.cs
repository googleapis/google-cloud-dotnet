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
using gagr = Google.Api.Gax.ResourceNames;
using wkt = Google.Protobuf.WellKnownTypes;
using gr = Google.Rpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.BigQuery.DataTransfer.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedDataTransferServiceClientTest
    {
        [xunit::FactAttribute]
        public void GetDataSourceRequestObject()
        {
            moq::Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new moq::Mock<DataTransferService.DataTransferServiceClient>(moq::MockBehavior.Strict);
            GetDataSourceRequest request = new GetDataSourceRequest
            {
                DataSourceName = DataSourceName.FromProjectDataSource("[PROJECT]", "[DATA_SOURCE]"),
            };
            DataSource expectedResponse = new DataSource
            {
                DataSourceName = DataSourceName.FromProjectDataSource("[PROJECT]", "[DATA_SOURCE]"),
                DataSourceId = "data_source_id4a2ea315",
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                ClientId = "client_id729dfe2b",
                Scopes = { "scopes35c99a1e", },
#pragma warning disable CS0612
                TransferType = TransferType.Batch,
                SupportsMultipleTransfers = true,
#pragma warning restore CS0612
                UpdateDeadlineSeconds = -1468953716,
                DefaultSchedule = "default_schedule3d57f6d3",
                SupportsCustomSchedule = true,
                Parameters =
                {
                    new DataSourceParameter(),
                },
                HelpUrl = "help_url09eadab7",
                AuthorizationType = DataSource.Types.AuthorizationType.FirstPartyOauth,
                DataRefreshType = DataSource.Types.DataRefreshType.Unspecified,
                DefaultDataRefreshWindowDays = 589997002,
                ManualRunsDisabled = true,
                MinimumScheduleInterval = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.GetDataSource(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            DataSource response = client.GetDataSource(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetDataSourceRequestObjectAsync()
        {
            moq::Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new moq::Mock<DataTransferService.DataTransferServiceClient>(moq::MockBehavior.Strict);
            GetDataSourceRequest request = new GetDataSourceRequest
            {
                DataSourceName = DataSourceName.FromProjectDataSource("[PROJECT]", "[DATA_SOURCE]"),
            };
            DataSource expectedResponse = new DataSource
            {
                DataSourceName = DataSourceName.FromProjectDataSource("[PROJECT]", "[DATA_SOURCE]"),
                DataSourceId = "data_source_id4a2ea315",
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                ClientId = "client_id729dfe2b",
                Scopes = { "scopes35c99a1e", },
#pragma warning disable CS0612
                TransferType = TransferType.Batch,
                SupportsMultipleTransfers = true,
#pragma warning restore CS0612
                UpdateDeadlineSeconds = -1468953716,
                DefaultSchedule = "default_schedule3d57f6d3",
                SupportsCustomSchedule = true,
                Parameters =
                {
                    new DataSourceParameter(),
                },
                HelpUrl = "help_url09eadab7",
                AuthorizationType = DataSource.Types.AuthorizationType.FirstPartyOauth,
                DataRefreshType = DataSource.Types.DataRefreshType.Unspecified,
                DefaultDataRefreshWindowDays = 589997002,
                ManualRunsDisabled = true,
                MinimumScheduleInterval = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.GetDataSourceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DataSource>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            DataSource responseCallSettings = await client.GetDataSourceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DataSource responseCancellationToken = await client.GetDataSourceAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetDataSource()
        {
            moq::Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new moq::Mock<DataTransferService.DataTransferServiceClient>(moq::MockBehavior.Strict);
            GetDataSourceRequest request = new GetDataSourceRequest
            {
                DataSourceName = DataSourceName.FromProjectDataSource("[PROJECT]", "[DATA_SOURCE]"),
            };
            DataSource expectedResponse = new DataSource
            {
                DataSourceName = DataSourceName.FromProjectDataSource("[PROJECT]", "[DATA_SOURCE]"),
                DataSourceId = "data_source_id4a2ea315",
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                ClientId = "client_id729dfe2b",
                Scopes = { "scopes35c99a1e", },
#pragma warning disable CS0612
                TransferType = TransferType.Batch,
                SupportsMultipleTransfers = true,
#pragma warning restore CS0612
                UpdateDeadlineSeconds = -1468953716,
                DefaultSchedule = "default_schedule3d57f6d3",
                SupportsCustomSchedule = true,
                Parameters =
                {
                    new DataSourceParameter(),
                },
                HelpUrl = "help_url09eadab7",
                AuthorizationType = DataSource.Types.AuthorizationType.FirstPartyOauth,
                DataRefreshType = DataSource.Types.DataRefreshType.Unspecified,
                DefaultDataRefreshWindowDays = 589997002,
                ManualRunsDisabled = true,
                MinimumScheduleInterval = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.GetDataSource(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            DataSource response = client.GetDataSource(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetDataSourceAsync()
        {
            moq::Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new moq::Mock<DataTransferService.DataTransferServiceClient>(moq::MockBehavior.Strict);
            GetDataSourceRequest request = new GetDataSourceRequest
            {
                DataSourceName = DataSourceName.FromProjectDataSource("[PROJECT]", "[DATA_SOURCE]"),
            };
            DataSource expectedResponse = new DataSource
            {
                DataSourceName = DataSourceName.FromProjectDataSource("[PROJECT]", "[DATA_SOURCE]"),
                DataSourceId = "data_source_id4a2ea315",
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                ClientId = "client_id729dfe2b",
                Scopes = { "scopes35c99a1e", },
#pragma warning disable CS0612
                TransferType = TransferType.Batch,
                SupportsMultipleTransfers = true,
#pragma warning restore CS0612
                UpdateDeadlineSeconds = -1468953716,
                DefaultSchedule = "default_schedule3d57f6d3",
                SupportsCustomSchedule = true,
                Parameters =
                {
                    new DataSourceParameter(),
                },
                HelpUrl = "help_url09eadab7",
                AuthorizationType = DataSource.Types.AuthorizationType.FirstPartyOauth,
                DataRefreshType = DataSource.Types.DataRefreshType.Unspecified,
                DefaultDataRefreshWindowDays = 589997002,
                ManualRunsDisabled = true,
                MinimumScheduleInterval = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.GetDataSourceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DataSource>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            DataSource responseCallSettings = await client.GetDataSourceAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DataSource responseCancellationToken = await client.GetDataSourceAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetDataSourceResourceNames()
        {
            moq::Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new moq::Mock<DataTransferService.DataTransferServiceClient>(moq::MockBehavior.Strict);
            GetDataSourceRequest request = new GetDataSourceRequest
            {
                DataSourceName = DataSourceName.FromProjectDataSource("[PROJECT]", "[DATA_SOURCE]"),
            };
            DataSource expectedResponse = new DataSource
            {
                DataSourceName = DataSourceName.FromProjectDataSource("[PROJECT]", "[DATA_SOURCE]"),
                DataSourceId = "data_source_id4a2ea315",
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                ClientId = "client_id729dfe2b",
                Scopes = { "scopes35c99a1e", },
#pragma warning disable CS0612
                TransferType = TransferType.Batch,
                SupportsMultipleTransfers = true,
#pragma warning restore CS0612
                UpdateDeadlineSeconds = -1468953716,
                DefaultSchedule = "default_schedule3d57f6d3",
                SupportsCustomSchedule = true,
                Parameters =
                {
                    new DataSourceParameter(),
                },
                HelpUrl = "help_url09eadab7",
                AuthorizationType = DataSource.Types.AuthorizationType.FirstPartyOauth,
                DataRefreshType = DataSource.Types.DataRefreshType.Unspecified,
                DefaultDataRefreshWindowDays = 589997002,
                ManualRunsDisabled = true,
                MinimumScheduleInterval = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.GetDataSource(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            DataSource response = client.GetDataSource(request.DataSourceName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetDataSourceResourceNamesAsync()
        {
            moq::Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new moq::Mock<DataTransferService.DataTransferServiceClient>(moq::MockBehavior.Strict);
            GetDataSourceRequest request = new GetDataSourceRequest
            {
                DataSourceName = DataSourceName.FromProjectDataSource("[PROJECT]", "[DATA_SOURCE]"),
            };
            DataSource expectedResponse = new DataSource
            {
                DataSourceName = DataSourceName.FromProjectDataSource("[PROJECT]", "[DATA_SOURCE]"),
                DataSourceId = "data_source_id4a2ea315",
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                ClientId = "client_id729dfe2b",
                Scopes = { "scopes35c99a1e", },
#pragma warning disable CS0612
                TransferType = TransferType.Batch,
                SupportsMultipleTransfers = true,
#pragma warning restore CS0612
                UpdateDeadlineSeconds = -1468953716,
                DefaultSchedule = "default_schedule3d57f6d3",
                SupportsCustomSchedule = true,
                Parameters =
                {
                    new DataSourceParameter(),
                },
                HelpUrl = "help_url09eadab7",
                AuthorizationType = DataSource.Types.AuthorizationType.FirstPartyOauth,
                DataRefreshType = DataSource.Types.DataRefreshType.Unspecified,
                DefaultDataRefreshWindowDays = 589997002,
                ManualRunsDisabled = true,
                MinimumScheduleInterval = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.GetDataSourceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DataSource>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            DataSource responseCallSettings = await client.GetDataSourceAsync(request.DataSourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DataSource responseCancellationToken = await client.GetDataSourceAsync(request.DataSourceName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateTransferConfigRequestObject()
        {
            moq::Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new moq::Mock<DataTransferService.DataTransferServiceClient>(moq::MockBehavior.Strict);
            CreateTransferConfigRequest request = new CreateTransferConfigRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                TransferConfig = new TransferConfig(),
                AuthorizationCode = "authorization_codef52cfb2e",
                VersionInfo = "version_info0ffd741f",
                ServiceAccountName = "service_account_name701fbf73",
            };
            TransferConfig expectedResponse = new TransferConfig
            {
                TransferConfigName = TransferConfigName.FromProjectTransferConfig("[PROJECT]", "[TRANSFER_CONFIG]"),
                DestinationDatasetId = "destination_dataset_idb2e283b4",
                DisplayName = "display_name137f65c2",
                UpdateTime = new wkt::Timestamp(),
                DataSourceId = "data_source_id4a2ea315",
                Schedule = "schedule59559879",
                NextRunTime = new wkt::Timestamp(),
                Params = new wkt::Struct(),
                State = TransferState.Unspecified,
                UserId = -7972883667886640920L,
                DataRefreshWindowDays = -902059417,
                Disabled = false,
                DatasetRegion = "dataset_region57ab9184",
                NotificationPubsubTopic = "notification_pubsub_topic857fa8e4",
                EmailPreferences = new EmailPreferences(),
                ScheduleOptions = new ScheduleOptions(),
            };
            mockGrpcClient.Setup(x => x.CreateTransferConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            TransferConfig response = client.CreateTransferConfig(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateTransferConfigRequestObjectAsync()
        {
            moq::Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new moq::Mock<DataTransferService.DataTransferServiceClient>(moq::MockBehavior.Strict);
            CreateTransferConfigRequest request = new CreateTransferConfigRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                TransferConfig = new TransferConfig(),
                AuthorizationCode = "authorization_codef52cfb2e",
                VersionInfo = "version_info0ffd741f",
                ServiceAccountName = "service_account_name701fbf73",
            };
            TransferConfig expectedResponse = new TransferConfig
            {
                TransferConfigName = TransferConfigName.FromProjectTransferConfig("[PROJECT]", "[TRANSFER_CONFIG]"),
                DestinationDatasetId = "destination_dataset_idb2e283b4",
                DisplayName = "display_name137f65c2",
                UpdateTime = new wkt::Timestamp(),
                DataSourceId = "data_source_id4a2ea315",
                Schedule = "schedule59559879",
                NextRunTime = new wkt::Timestamp(),
                Params = new wkt::Struct(),
                State = TransferState.Unspecified,
                UserId = -7972883667886640920L,
                DataRefreshWindowDays = -902059417,
                Disabled = false,
                DatasetRegion = "dataset_region57ab9184",
                NotificationPubsubTopic = "notification_pubsub_topic857fa8e4",
                EmailPreferences = new EmailPreferences(),
                ScheduleOptions = new ScheduleOptions(),
            };
            mockGrpcClient.Setup(x => x.CreateTransferConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TransferConfig>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            TransferConfig responseCallSettings = await client.CreateTransferConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TransferConfig responseCancellationToken = await client.CreateTransferConfigAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateTransferConfig()
        {
            moq::Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new moq::Mock<DataTransferService.DataTransferServiceClient>(moq::MockBehavior.Strict);
            CreateTransferConfigRequest request = new CreateTransferConfigRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                TransferConfig = new TransferConfig(),
            };
            TransferConfig expectedResponse = new TransferConfig
            {
                TransferConfigName = TransferConfigName.FromProjectTransferConfig("[PROJECT]", "[TRANSFER_CONFIG]"),
                DestinationDatasetId = "destination_dataset_idb2e283b4",
                DisplayName = "display_name137f65c2",
                UpdateTime = new wkt::Timestamp(),
                DataSourceId = "data_source_id4a2ea315",
                Schedule = "schedule59559879",
                NextRunTime = new wkt::Timestamp(),
                Params = new wkt::Struct(),
                State = TransferState.Unspecified,
                UserId = -7972883667886640920L,
                DataRefreshWindowDays = -902059417,
                Disabled = false,
                DatasetRegion = "dataset_region57ab9184",
                NotificationPubsubTopic = "notification_pubsub_topic857fa8e4",
                EmailPreferences = new EmailPreferences(),
                ScheduleOptions = new ScheduleOptions(),
            };
            mockGrpcClient.Setup(x => x.CreateTransferConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            TransferConfig response = client.CreateTransferConfig(request.Parent, request.TransferConfig);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateTransferConfigAsync()
        {
            moq::Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new moq::Mock<DataTransferService.DataTransferServiceClient>(moq::MockBehavior.Strict);
            CreateTransferConfigRequest request = new CreateTransferConfigRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                TransferConfig = new TransferConfig(),
            };
            TransferConfig expectedResponse = new TransferConfig
            {
                TransferConfigName = TransferConfigName.FromProjectTransferConfig("[PROJECT]", "[TRANSFER_CONFIG]"),
                DestinationDatasetId = "destination_dataset_idb2e283b4",
                DisplayName = "display_name137f65c2",
                UpdateTime = new wkt::Timestamp(),
                DataSourceId = "data_source_id4a2ea315",
                Schedule = "schedule59559879",
                NextRunTime = new wkt::Timestamp(),
                Params = new wkt::Struct(),
                State = TransferState.Unspecified,
                UserId = -7972883667886640920L,
                DataRefreshWindowDays = -902059417,
                Disabled = false,
                DatasetRegion = "dataset_region57ab9184",
                NotificationPubsubTopic = "notification_pubsub_topic857fa8e4",
                EmailPreferences = new EmailPreferences(),
                ScheduleOptions = new ScheduleOptions(),
            };
            mockGrpcClient.Setup(x => x.CreateTransferConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TransferConfig>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            TransferConfig responseCallSettings = await client.CreateTransferConfigAsync(request.Parent, request.TransferConfig, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TransferConfig responseCancellationToken = await client.CreateTransferConfigAsync(request.Parent, request.TransferConfig, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateTransferConfigResourceNames1()
        {
            moq::Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new moq::Mock<DataTransferService.DataTransferServiceClient>(moq::MockBehavior.Strict);
            CreateTransferConfigRequest request = new CreateTransferConfigRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                TransferConfig = new TransferConfig(),
            };
            TransferConfig expectedResponse = new TransferConfig
            {
                TransferConfigName = TransferConfigName.FromProjectTransferConfig("[PROJECT]", "[TRANSFER_CONFIG]"),
                DestinationDatasetId = "destination_dataset_idb2e283b4",
                DisplayName = "display_name137f65c2",
                UpdateTime = new wkt::Timestamp(),
                DataSourceId = "data_source_id4a2ea315",
                Schedule = "schedule59559879",
                NextRunTime = new wkt::Timestamp(),
                Params = new wkt::Struct(),
                State = TransferState.Unspecified,
                UserId = -7972883667886640920L,
                DataRefreshWindowDays = -902059417,
                Disabled = false,
                DatasetRegion = "dataset_region57ab9184",
                NotificationPubsubTopic = "notification_pubsub_topic857fa8e4",
                EmailPreferences = new EmailPreferences(),
                ScheduleOptions = new ScheduleOptions(),
            };
            mockGrpcClient.Setup(x => x.CreateTransferConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            TransferConfig response = client.CreateTransferConfig(request.ParentAsProjectName, request.TransferConfig);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateTransferConfigResourceNames1Async()
        {
            moq::Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new moq::Mock<DataTransferService.DataTransferServiceClient>(moq::MockBehavior.Strict);
            CreateTransferConfigRequest request = new CreateTransferConfigRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                TransferConfig = new TransferConfig(),
            };
            TransferConfig expectedResponse = new TransferConfig
            {
                TransferConfigName = TransferConfigName.FromProjectTransferConfig("[PROJECT]", "[TRANSFER_CONFIG]"),
                DestinationDatasetId = "destination_dataset_idb2e283b4",
                DisplayName = "display_name137f65c2",
                UpdateTime = new wkt::Timestamp(),
                DataSourceId = "data_source_id4a2ea315",
                Schedule = "schedule59559879",
                NextRunTime = new wkt::Timestamp(),
                Params = new wkt::Struct(),
                State = TransferState.Unspecified,
                UserId = -7972883667886640920L,
                DataRefreshWindowDays = -902059417,
                Disabled = false,
                DatasetRegion = "dataset_region57ab9184",
                NotificationPubsubTopic = "notification_pubsub_topic857fa8e4",
                EmailPreferences = new EmailPreferences(),
                ScheduleOptions = new ScheduleOptions(),
            };
            mockGrpcClient.Setup(x => x.CreateTransferConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TransferConfig>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            TransferConfig responseCallSettings = await client.CreateTransferConfigAsync(request.ParentAsProjectName, request.TransferConfig, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TransferConfig responseCancellationToken = await client.CreateTransferConfigAsync(request.ParentAsProjectName, request.TransferConfig, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateTransferConfigResourceNames2()
        {
            moq::Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new moq::Mock<DataTransferService.DataTransferServiceClient>(moq::MockBehavior.Strict);
            CreateTransferConfigRequest request = new CreateTransferConfigRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                TransferConfig = new TransferConfig(),
            };
            TransferConfig expectedResponse = new TransferConfig
            {
                TransferConfigName = TransferConfigName.FromProjectTransferConfig("[PROJECT]", "[TRANSFER_CONFIG]"),
                DestinationDatasetId = "destination_dataset_idb2e283b4",
                DisplayName = "display_name137f65c2",
                UpdateTime = new wkt::Timestamp(),
                DataSourceId = "data_source_id4a2ea315",
                Schedule = "schedule59559879",
                NextRunTime = new wkt::Timestamp(),
                Params = new wkt::Struct(),
                State = TransferState.Unspecified,
                UserId = -7972883667886640920L,
                DataRefreshWindowDays = -902059417,
                Disabled = false,
                DatasetRegion = "dataset_region57ab9184",
                NotificationPubsubTopic = "notification_pubsub_topic857fa8e4",
                EmailPreferences = new EmailPreferences(),
                ScheduleOptions = new ScheduleOptions(),
            };
            mockGrpcClient.Setup(x => x.CreateTransferConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            TransferConfig response = client.CreateTransferConfig(request.ParentAsLocationName, request.TransferConfig);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateTransferConfigResourceNames2Async()
        {
            moq::Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new moq::Mock<DataTransferService.DataTransferServiceClient>(moq::MockBehavior.Strict);
            CreateTransferConfigRequest request = new CreateTransferConfigRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                TransferConfig = new TransferConfig(),
            };
            TransferConfig expectedResponse = new TransferConfig
            {
                TransferConfigName = TransferConfigName.FromProjectTransferConfig("[PROJECT]", "[TRANSFER_CONFIG]"),
                DestinationDatasetId = "destination_dataset_idb2e283b4",
                DisplayName = "display_name137f65c2",
                UpdateTime = new wkt::Timestamp(),
                DataSourceId = "data_source_id4a2ea315",
                Schedule = "schedule59559879",
                NextRunTime = new wkt::Timestamp(),
                Params = new wkt::Struct(),
                State = TransferState.Unspecified,
                UserId = -7972883667886640920L,
                DataRefreshWindowDays = -902059417,
                Disabled = false,
                DatasetRegion = "dataset_region57ab9184",
                NotificationPubsubTopic = "notification_pubsub_topic857fa8e4",
                EmailPreferences = new EmailPreferences(),
                ScheduleOptions = new ScheduleOptions(),
            };
            mockGrpcClient.Setup(x => x.CreateTransferConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TransferConfig>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            TransferConfig responseCallSettings = await client.CreateTransferConfigAsync(request.ParentAsLocationName, request.TransferConfig, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TransferConfig responseCancellationToken = await client.CreateTransferConfigAsync(request.ParentAsLocationName, request.TransferConfig, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateTransferConfigRequestObject()
        {
            moq::Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new moq::Mock<DataTransferService.DataTransferServiceClient>(moq::MockBehavior.Strict);
            UpdateTransferConfigRequest request = new UpdateTransferConfigRequest
            {
                TransferConfig = new TransferConfig(),
                AuthorizationCode = "authorization_codef52cfb2e",
                UpdateMask = new wkt::FieldMask(),
                VersionInfo = "version_info0ffd741f",
                ServiceAccountName = "service_account_name701fbf73",
            };
            TransferConfig expectedResponse = new TransferConfig
            {
                TransferConfigName = TransferConfigName.FromProjectTransferConfig("[PROJECT]", "[TRANSFER_CONFIG]"),
                DestinationDatasetId = "destination_dataset_idb2e283b4",
                DisplayName = "display_name137f65c2",
                UpdateTime = new wkt::Timestamp(),
                DataSourceId = "data_source_id4a2ea315",
                Schedule = "schedule59559879",
                NextRunTime = new wkt::Timestamp(),
                Params = new wkt::Struct(),
                State = TransferState.Unspecified,
                UserId = -7972883667886640920L,
                DataRefreshWindowDays = -902059417,
                Disabled = false,
                DatasetRegion = "dataset_region57ab9184",
                NotificationPubsubTopic = "notification_pubsub_topic857fa8e4",
                EmailPreferences = new EmailPreferences(),
                ScheduleOptions = new ScheduleOptions(),
            };
            mockGrpcClient.Setup(x => x.UpdateTransferConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            TransferConfig response = client.UpdateTransferConfig(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateTransferConfigRequestObjectAsync()
        {
            moq::Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new moq::Mock<DataTransferService.DataTransferServiceClient>(moq::MockBehavior.Strict);
            UpdateTransferConfigRequest request = new UpdateTransferConfigRequest
            {
                TransferConfig = new TransferConfig(),
                AuthorizationCode = "authorization_codef52cfb2e",
                UpdateMask = new wkt::FieldMask(),
                VersionInfo = "version_info0ffd741f",
                ServiceAccountName = "service_account_name701fbf73",
            };
            TransferConfig expectedResponse = new TransferConfig
            {
                TransferConfigName = TransferConfigName.FromProjectTransferConfig("[PROJECT]", "[TRANSFER_CONFIG]"),
                DestinationDatasetId = "destination_dataset_idb2e283b4",
                DisplayName = "display_name137f65c2",
                UpdateTime = new wkt::Timestamp(),
                DataSourceId = "data_source_id4a2ea315",
                Schedule = "schedule59559879",
                NextRunTime = new wkt::Timestamp(),
                Params = new wkt::Struct(),
                State = TransferState.Unspecified,
                UserId = -7972883667886640920L,
                DataRefreshWindowDays = -902059417,
                Disabled = false,
                DatasetRegion = "dataset_region57ab9184",
                NotificationPubsubTopic = "notification_pubsub_topic857fa8e4",
                EmailPreferences = new EmailPreferences(),
                ScheduleOptions = new ScheduleOptions(),
            };
            mockGrpcClient.Setup(x => x.UpdateTransferConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TransferConfig>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            TransferConfig responseCallSettings = await client.UpdateTransferConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TransferConfig responseCancellationToken = await client.UpdateTransferConfigAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateTransferConfig()
        {
            moq::Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new moq::Mock<DataTransferService.DataTransferServiceClient>(moq::MockBehavior.Strict);
            UpdateTransferConfigRequest request = new UpdateTransferConfigRequest
            {
                TransferConfig = new TransferConfig(),
                UpdateMask = new wkt::FieldMask(),
            };
            TransferConfig expectedResponse = new TransferConfig
            {
                TransferConfigName = TransferConfigName.FromProjectTransferConfig("[PROJECT]", "[TRANSFER_CONFIG]"),
                DestinationDatasetId = "destination_dataset_idb2e283b4",
                DisplayName = "display_name137f65c2",
                UpdateTime = new wkt::Timestamp(),
                DataSourceId = "data_source_id4a2ea315",
                Schedule = "schedule59559879",
                NextRunTime = new wkt::Timestamp(),
                Params = new wkt::Struct(),
                State = TransferState.Unspecified,
                UserId = -7972883667886640920L,
                DataRefreshWindowDays = -902059417,
                Disabled = false,
                DatasetRegion = "dataset_region57ab9184",
                NotificationPubsubTopic = "notification_pubsub_topic857fa8e4",
                EmailPreferences = new EmailPreferences(),
                ScheduleOptions = new ScheduleOptions(),
            };
            mockGrpcClient.Setup(x => x.UpdateTransferConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            TransferConfig response = client.UpdateTransferConfig(request.TransferConfig, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateTransferConfigAsync()
        {
            moq::Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new moq::Mock<DataTransferService.DataTransferServiceClient>(moq::MockBehavior.Strict);
            UpdateTransferConfigRequest request = new UpdateTransferConfigRequest
            {
                TransferConfig = new TransferConfig(),
                UpdateMask = new wkt::FieldMask(),
            };
            TransferConfig expectedResponse = new TransferConfig
            {
                TransferConfigName = TransferConfigName.FromProjectTransferConfig("[PROJECT]", "[TRANSFER_CONFIG]"),
                DestinationDatasetId = "destination_dataset_idb2e283b4",
                DisplayName = "display_name137f65c2",
                UpdateTime = new wkt::Timestamp(),
                DataSourceId = "data_source_id4a2ea315",
                Schedule = "schedule59559879",
                NextRunTime = new wkt::Timestamp(),
                Params = new wkt::Struct(),
                State = TransferState.Unspecified,
                UserId = -7972883667886640920L,
                DataRefreshWindowDays = -902059417,
                Disabled = false,
                DatasetRegion = "dataset_region57ab9184",
                NotificationPubsubTopic = "notification_pubsub_topic857fa8e4",
                EmailPreferences = new EmailPreferences(),
                ScheduleOptions = new ScheduleOptions(),
            };
            mockGrpcClient.Setup(x => x.UpdateTransferConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TransferConfig>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            TransferConfig responseCallSettings = await client.UpdateTransferConfigAsync(request.TransferConfig, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TransferConfig responseCancellationToken = await client.UpdateTransferConfigAsync(request.TransferConfig, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteTransferConfigRequestObject()
        {
            moq::Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new moq::Mock<DataTransferService.DataTransferServiceClient>(moq::MockBehavior.Strict);
            DeleteTransferConfigRequest request = new DeleteTransferConfigRequest
            {
                TransferConfigName = TransferConfigName.FromProjectTransferConfig("[PROJECT]", "[TRANSFER_CONFIG]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteTransferConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteTransferConfig(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteTransferConfigRequestObjectAsync()
        {
            moq::Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new moq::Mock<DataTransferService.DataTransferServiceClient>(moq::MockBehavior.Strict);
            DeleteTransferConfigRequest request = new DeleteTransferConfigRequest
            {
                TransferConfigName = TransferConfigName.FromProjectTransferConfig("[PROJECT]", "[TRANSFER_CONFIG]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteTransferConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteTransferConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteTransferConfigAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteTransferConfig()
        {
            moq::Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new moq::Mock<DataTransferService.DataTransferServiceClient>(moq::MockBehavior.Strict);
            DeleteTransferConfigRequest request = new DeleteTransferConfigRequest
            {
                TransferConfigName = TransferConfigName.FromProjectTransferConfig("[PROJECT]", "[TRANSFER_CONFIG]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteTransferConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteTransferConfig(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteTransferConfigAsync()
        {
            moq::Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new moq::Mock<DataTransferService.DataTransferServiceClient>(moq::MockBehavior.Strict);
            DeleteTransferConfigRequest request = new DeleteTransferConfigRequest
            {
                TransferConfigName = TransferConfigName.FromProjectTransferConfig("[PROJECT]", "[TRANSFER_CONFIG]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteTransferConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteTransferConfigAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteTransferConfigAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteTransferConfigResourceNames()
        {
            moq::Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new moq::Mock<DataTransferService.DataTransferServiceClient>(moq::MockBehavior.Strict);
            DeleteTransferConfigRequest request = new DeleteTransferConfigRequest
            {
                TransferConfigName = TransferConfigName.FromProjectTransferConfig("[PROJECT]", "[TRANSFER_CONFIG]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteTransferConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteTransferConfig(request.TransferConfigName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteTransferConfigResourceNamesAsync()
        {
            moq::Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new moq::Mock<DataTransferService.DataTransferServiceClient>(moq::MockBehavior.Strict);
            DeleteTransferConfigRequest request = new DeleteTransferConfigRequest
            {
                TransferConfigName = TransferConfigName.FromProjectTransferConfig("[PROJECT]", "[TRANSFER_CONFIG]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteTransferConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteTransferConfigAsync(request.TransferConfigName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteTransferConfigAsync(request.TransferConfigName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetTransferConfigRequestObject()
        {
            moq::Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new moq::Mock<DataTransferService.DataTransferServiceClient>(moq::MockBehavior.Strict);
            GetTransferConfigRequest request = new GetTransferConfigRequest
            {
                TransferConfigName = TransferConfigName.FromProjectTransferConfig("[PROJECT]", "[TRANSFER_CONFIG]"),
            };
            TransferConfig expectedResponse = new TransferConfig
            {
                TransferConfigName = TransferConfigName.FromProjectTransferConfig("[PROJECT]", "[TRANSFER_CONFIG]"),
                DestinationDatasetId = "destination_dataset_idb2e283b4",
                DisplayName = "display_name137f65c2",
                UpdateTime = new wkt::Timestamp(),
                DataSourceId = "data_source_id4a2ea315",
                Schedule = "schedule59559879",
                NextRunTime = new wkt::Timestamp(),
                Params = new wkt::Struct(),
                State = TransferState.Unspecified,
                UserId = -7972883667886640920L,
                DataRefreshWindowDays = -902059417,
                Disabled = false,
                DatasetRegion = "dataset_region57ab9184",
                NotificationPubsubTopic = "notification_pubsub_topic857fa8e4",
                EmailPreferences = new EmailPreferences(),
                ScheduleOptions = new ScheduleOptions(),
            };
            mockGrpcClient.Setup(x => x.GetTransferConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            TransferConfig response = client.GetTransferConfig(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetTransferConfigRequestObjectAsync()
        {
            moq::Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new moq::Mock<DataTransferService.DataTransferServiceClient>(moq::MockBehavior.Strict);
            GetTransferConfigRequest request = new GetTransferConfigRequest
            {
                TransferConfigName = TransferConfigName.FromProjectTransferConfig("[PROJECT]", "[TRANSFER_CONFIG]"),
            };
            TransferConfig expectedResponse = new TransferConfig
            {
                TransferConfigName = TransferConfigName.FromProjectTransferConfig("[PROJECT]", "[TRANSFER_CONFIG]"),
                DestinationDatasetId = "destination_dataset_idb2e283b4",
                DisplayName = "display_name137f65c2",
                UpdateTime = new wkt::Timestamp(),
                DataSourceId = "data_source_id4a2ea315",
                Schedule = "schedule59559879",
                NextRunTime = new wkt::Timestamp(),
                Params = new wkt::Struct(),
                State = TransferState.Unspecified,
                UserId = -7972883667886640920L,
                DataRefreshWindowDays = -902059417,
                Disabled = false,
                DatasetRegion = "dataset_region57ab9184",
                NotificationPubsubTopic = "notification_pubsub_topic857fa8e4",
                EmailPreferences = new EmailPreferences(),
                ScheduleOptions = new ScheduleOptions(),
            };
            mockGrpcClient.Setup(x => x.GetTransferConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TransferConfig>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            TransferConfig responseCallSettings = await client.GetTransferConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TransferConfig responseCancellationToken = await client.GetTransferConfigAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetTransferConfig()
        {
            moq::Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new moq::Mock<DataTransferService.DataTransferServiceClient>(moq::MockBehavior.Strict);
            GetTransferConfigRequest request = new GetTransferConfigRequest
            {
                TransferConfigName = TransferConfigName.FromProjectTransferConfig("[PROJECT]", "[TRANSFER_CONFIG]"),
            };
            TransferConfig expectedResponse = new TransferConfig
            {
                TransferConfigName = TransferConfigName.FromProjectTransferConfig("[PROJECT]", "[TRANSFER_CONFIG]"),
                DestinationDatasetId = "destination_dataset_idb2e283b4",
                DisplayName = "display_name137f65c2",
                UpdateTime = new wkt::Timestamp(),
                DataSourceId = "data_source_id4a2ea315",
                Schedule = "schedule59559879",
                NextRunTime = new wkt::Timestamp(),
                Params = new wkt::Struct(),
                State = TransferState.Unspecified,
                UserId = -7972883667886640920L,
                DataRefreshWindowDays = -902059417,
                Disabled = false,
                DatasetRegion = "dataset_region57ab9184",
                NotificationPubsubTopic = "notification_pubsub_topic857fa8e4",
                EmailPreferences = new EmailPreferences(),
                ScheduleOptions = new ScheduleOptions(),
            };
            mockGrpcClient.Setup(x => x.GetTransferConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            TransferConfig response = client.GetTransferConfig(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetTransferConfigAsync()
        {
            moq::Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new moq::Mock<DataTransferService.DataTransferServiceClient>(moq::MockBehavior.Strict);
            GetTransferConfigRequest request = new GetTransferConfigRequest
            {
                TransferConfigName = TransferConfigName.FromProjectTransferConfig("[PROJECT]", "[TRANSFER_CONFIG]"),
            };
            TransferConfig expectedResponse = new TransferConfig
            {
                TransferConfigName = TransferConfigName.FromProjectTransferConfig("[PROJECT]", "[TRANSFER_CONFIG]"),
                DestinationDatasetId = "destination_dataset_idb2e283b4",
                DisplayName = "display_name137f65c2",
                UpdateTime = new wkt::Timestamp(),
                DataSourceId = "data_source_id4a2ea315",
                Schedule = "schedule59559879",
                NextRunTime = new wkt::Timestamp(),
                Params = new wkt::Struct(),
                State = TransferState.Unspecified,
                UserId = -7972883667886640920L,
                DataRefreshWindowDays = -902059417,
                Disabled = false,
                DatasetRegion = "dataset_region57ab9184",
                NotificationPubsubTopic = "notification_pubsub_topic857fa8e4",
                EmailPreferences = new EmailPreferences(),
                ScheduleOptions = new ScheduleOptions(),
            };
            mockGrpcClient.Setup(x => x.GetTransferConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TransferConfig>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            TransferConfig responseCallSettings = await client.GetTransferConfigAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TransferConfig responseCancellationToken = await client.GetTransferConfigAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetTransferConfigResourceNames()
        {
            moq::Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new moq::Mock<DataTransferService.DataTransferServiceClient>(moq::MockBehavior.Strict);
            GetTransferConfigRequest request = new GetTransferConfigRequest
            {
                TransferConfigName = TransferConfigName.FromProjectTransferConfig("[PROJECT]", "[TRANSFER_CONFIG]"),
            };
            TransferConfig expectedResponse = new TransferConfig
            {
                TransferConfigName = TransferConfigName.FromProjectTransferConfig("[PROJECT]", "[TRANSFER_CONFIG]"),
                DestinationDatasetId = "destination_dataset_idb2e283b4",
                DisplayName = "display_name137f65c2",
                UpdateTime = new wkt::Timestamp(),
                DataSourceId = "data_source_id4a2ea315",
                Schedule = "schedule59559879",
                NextRunTime = new wkt::Timestamp(),
                Params = new wkt::Struct(),
                State = TransferState.Unspecified,
                UserId = -7972883667886640920L,
                DataRefreshWindowDays = -902059417,
                Disabled = false,
                DatasetRegion = "dataset_region57ab9184",
                NotificationPubsubTopic = "notification_pubsub_topic857fa8e4",
                EmailPreferences = new EmailPreferences(),
                ScheduleOptions = new ScheduleOptions(),
            };
            mockGrpcClient.Setup(x => x.GetTransferConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            TransferConfig response = client.GetTransferConfig(request.TransferConfigName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetTransferConfigResourceNamesAsync()
        {
            moq::Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new moq::Mock<DataTransferService.DataTransferServiceClient>(moq::MockBehavior.Strict);
            GetTransferConfigRequest request = new GetTransferConfigRequest
            {
                TransferConfigName = TransferConfigName.FromProjectTransferConfig("[PROJECT]", "[TRANSFER_CONFIG]"),
            };
            TransferConfig expectedResponse = new TransferConfig
            {
                TransferConfigName = TransferConfigName.FromProjectTransferConfig("[PROJECT]", "[TRANSFER_CONFIG]"),
                DestinationDatasetId = "destination_dataset_idb2e283b4",
                DisplayName = "display_name137f65c2",
                UpdateTime = new wkt::Timestamp(),
                DataSourceId = "data_source_id4a2ea315",
                Schedule = "schedule59559879",
                NextRunTime = new wkt::Timestamp(),
                Params = new wkt::Struct(),
                State = TransferState.Unspecified,
                UserId = -7972883667886640920L,
                DataRefreshWindowDays = -902059417,
                Disabled = false,
                DatasetRegion = "dataset_region57ab9184",
                NotificationPubsubTopic = "notification_pubsub_topic857fa8e4",
                EmailPreferences = new EmailPreferences(),
                ScheduleOptions = new ScheduleOptions(),
            };
            mockGrpcClient.Setup(x => x.GetTransferConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TransferConfig>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            TransferConfig responseCallSettings = await client.GetTransferConfigAsync(request.TransferConfigName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TransferConfig responseCancellationToken = await client.GetTransferConfigAsync(request.TransferConfigName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ScheduleTransferRunsRequestObject()
        {
            moq::Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new moq::Mock<DataTransferService.DataTransferServiceClient>(moq::MockBehavior.Strict);
            ScheduleTransferRunsRequest request = new ScheduleTransferRunsRequest
            {
                ParentAsTransferConfigName = TransferConfigName.FromProjectTransferConfig("[PROJECT]", "[TRANSFER_CONFIG]"),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
            };
            ScheduleTransferRunsResponse expectedResponse = new ScheduleTransferRunsResponse
            {
                Runs = { new TransferRun(), },
            };
            mockGrpcClient.Setup(x => x.ScheduleTransferRuns(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
#pragma warning disable CS0612
            ScheduleTransferRunsResponse response = client.ScheduleTransferRuns(request);
#pragma warning restore CS0612
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ScheduleTransferRunsRequestObjectAsync()
        {
            moq::Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new moq::Mock<DataTransferService.DataTransferServiceClient>(moq::MockBehavior.Strict);
            ScheduleTransferRunsRequest request = new ScheduleTransferRunsRequest
            {
                ParentAsTransferConfigName = TransferConfigName.FromProjectTransferConfig("[PROJECT]", "[TRANSFER_CONFIG]"),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
            };
            ScheduleTransferRunsResponse expectedResponse = new ScheduleTransferRunsResponse
            {
                Runs = { new TransferRun(), },
            };
            mockGrpcClient.Setup(x => x.ScheduleTransferRunsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ScheduleTransferRunsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
#pragma warning disable CS0612
            ScheduleTransferRunsResponse responseCallSettings = await client.ScheduleTransferRunsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
#pragma warning restore CS0612
            xunit::Assert.Same(expectedResponse, responseCallSettings);
#pragma warning disable CS0612
            ScheduleTransferRunsResponse responseCancellationToken = await client.ScheduleTransferRunsAsync(request, st::CancellationToken.None);
#pragma warning restore CS0612
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ScheduleTransferRuns()
        {
            moq::Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new moq::Mock<DataTransferService.DataTransferServiceClient>(moq::MockBehavior.Strict);
            ScheduleTransferRunsRequest request = new ScheduleTransferRunsRequest
            {
                ParentAsTransferConfigName = TransferConfigName.FromProjectTransferConfig("[PROJECT]", "[TRANSFER_CONFIG]"),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
            };
            ScheduleTransferRunsResponse expectedResponse = new ScheduleTransferRunsResponse
            {
                Runs = { new TransferRun(), },
            };
            mockGrpcClient.Setup(x => x.ScheduleTransferRuns(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
#pragma warning disable CS0612
            ScheduleTransferRunsResponse response = client.ScheduleTransferRuns(request.Parent, request.StartTime, request.EndTime);
#pragma warning restore CS0612
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ScheduleTransferRunsAsync()
        {
            moq::Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new moq::Mock<DataTransferService.DataTransferServiceClient>(moq::MockBehavior.Strict);
            ScheduleTransferRunsRequest request = new ScheduleTransferRunsRequest
            {
                ParentAsTransferConfigName = TransferConfigName.FromProjectTransferConfig("[PROJECT]", "[TRANSFER_CONFIG]"),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
            };
            ScheduleTransferRunsResponse expectedResponse = new ScheduleTransferRunsResponse
            {
                Runs = { new TransferRun(), },
            };
            mockGrpcClient.Setup(x => x.ScheduleTransferRunsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ScheduleTransferRunsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
#pragma warning disable CS0612
            ScheduleTransferRunsResponse responseCallSettings = await client.ScheduleTransferRunsAsync(request.Parent, request.StartTime, request.EndTime, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
#pragma warning restore CS0612
            xunit::Assert.Same(expectedResponse, responseCallSettings);
#pragma warning disable CS0612
            ScheduleTransferRunsResponse responseCancellationToken = await client.ScheduleTransferRunsAsync(request.Parent, request.StartTime, request.EndTime, st::CancellationToken.None);
#pragma warning restore CS0612
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ScheduleTransferRunsResourceNames()
        {
            moq::Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new moq::Mock<DataTransferService.DataTransferServiceClient>(moq::MockBehavior.Strict);
            ScheduleTransferRunsRequest request = new ScheduleTransferRunsRequest
            {
                ParentAsTransferConfigName = TransferConfigName.FromProjectTransferConfig("[PROJECT]", "[TRANSFER_CONFIG]"),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
            };
            ScheduleTransferRunsResponse expectedResponse = new ScheduleTransferRunsResponse
            {
                Runs = { new TransferRun(), },
            };
            mockGrpcClient.Setup(x => x.ScheduleTransferRuns(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
#pragma warning disable CS0612
            ScheduleTransferRunsResponse response = client.ScheduleTransferRuns(request.ParentAsTransferConfigName, request.StartTime, request.EndTime);
#pragma warning restore CS0612
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ScheduleTransferRunsResourceNamesAsync()
        {
            moq::Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new moq::Mock<DataTransferService.DataTransferServiceClient>(moq::MockBehavior.Strict);
            ScheduleTransferRunsRequest request = new ScheduleTransferRunsRequest
            {
                ParentAsTransferConfigName = TransferConfigName.FromProjectTransferConfig("[PROJECT]", "[TRANSFER_CONFIG]"),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
            };
            ScheduleTransferRunsResponse expectedResponse = new ScheduleTransferRunsResponse
            {
                Runs = { new TransferRun(), },
            };
            mockGrpcClient.Setup(x => x.ScheduleTransferRunsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ScheduleTransferRunsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
#pragma warning disable CS0612
            ScheduleTransferRunsResponse responseCallSettings = await client.ScheduleTransferRunsAsync(request.ParentAsTransferConfigName, request.StartTime, request.EndTime, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
#pragma warning restore CS0612
            xunit::Assert.Same(expectedResponse, responseCallSettings);
#pragma warning disable CS0612
            ScheduleTransferRunsResponse responseCancellationToken = await client.ScheduleTransferRunsAsync(request.ParentAsTransferConfigName, request.StartTime, request.EndTime, st::CancellationToken.None);
#pragma warning restore CS0612
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void StartManualTransferRunsRequestObject()
        {
            moq::Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new moq::Mock<DataTransferService.DataTransferServiceClient>(moq::MockBehavior.Strict);
            StartManualTransferRunsRequest request = new StartManualTransferRunsRequest
            {
                ParentAsTransferConfigName = TransferConfigName.FromProjectTransferConfig("[PROJECT]", "[TRANSFER_CONFIG]"),
                RequestedTimeRange = new StartManualTransferRunsRequest.Types.TimeRange(),
                RequestedRunTime = new wkt::Timestamp(),
            };
            StartManualTransferRunsResponse expectedResponse = new StartManualTransferRunsResponse
            {
                Runs = { new TransferRun(), },
            };
            mockGrpcClient.Setup(x => x.StartManualTransferRuns(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            StartManualTransferRunsResponse response = client.StartManualTransferRuns(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task StartManualTransferRunsRequestObjectAsync()
        {
            moq::Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new moq::Mock<DataTransferService.DataTransferServiceClient>(moq::MockBehavior.Strict);
            StartManualTransferRunsRequest request = new StartManualTransferRunsRequest
            {
                ParentAsTransferConfigName = TransferConfigName.FromProjectTransferConfig("[PROJECT]", "[TRANSFER_CONFIG]"),
                RequestedTimeRange = new StartManualTransferRunsRequest.Types.TimeRange(),
                RequestedRunTime = new wkt::Timestamp(),
            };
            StartManualTransferRunsResponse expectedResponse = new StartManualTransferRunsResponse
            {
                Runs = { new TransferRun(), },
            };
            mockGrpcClient.Setup(x => x.StartManualTransferRunsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<StartManualTransferRunsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            StartManualTransferRunsResponse responseCallSettings = await client.StartManualTransferRunsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            StartManualTransferRunsResponse responseCancellationToken = await client.StartManualTransferRunsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetTransferRunRequestObject()
        {
            moq::Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new moq::Mock<DataTransferService.DataTransferServiceClient>(moq::MockBehavior.Strict);
            GetTransferRunRequest request = new GetTransferRunRequest
            {
                RunName = RunName.FromProjectTransferConfigRun("[PROJECT]", "[TRANSFER_CONFIG]", "[RUN]"),
            };
            TransferRun expectedResponse = new TransferRun
            {
                RunName = RunName.FromProjectTransferConfigRun("[PROJECT]", "[TRANSFER_CONFIG]", "[RUN]"),
                DestinationDatasetId = "destination_dataset_idb2e283b4",
                ScheduleTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DataSourceId = "data_source_id4a2ea315",
                State = TransferState.Unspecified,
                Params = new wkt::Struct(),
                RunTime = new wkt::Timestamp(),
                UserId = -7972883667886640920L,
                Schedule = "schedule59559879",
                ErrorStatus = new gr::Status(),
                NotificationPubsubTopic = "notification_pubsub_topic857fa8e4",
                EmailPreferences = new EmailPreferences(),
            };
            mockGrpcClient.Setup(x => x.GetTransferRun(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            TransferRun response = client.GetTransferRun(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetTransferRunRequestObjectAsync()
        {
            moq::Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new moq::Mock<DataTransferService.DataTransferServiceClient>(moq::MockBehavior.Strict);
            GetTransferRunRequest request = new GetTransferRunRequest
            {
                RunName = RunName.FromProjectTransferConfigRun("[PROJECT]", "[TRANSFER_CONFIG]", "[RUN]"),
            };
            TransferRun expectedResponse = new TransferRun
            {
                RunName = RunName.FromProjectTransferConfigRun("[PROJECT]", "[TRANSFER_CONFIG]", "[RUN]"),
                DestinationDatasetId = "destination_dataset_idb2e283b4",
                ScheduleTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DataSourceId = "data_source_id4a2ea315",
                State = TransferState.Unspecified,
                Params = new wkt::Struct(),
                RunTime = new wkt::Timestamp(),
                UserId = -7972883667886640920L,
                Schedule = "schedule59559879",
                ErrorStatus = new gr::Status(),
                NotificationPubsubTopic = "notification_pubsub_topic857fa8e4",
                EmailPreferences = new EmailPreferences(),
            };
            mockGrpcClient.Setup(x => x.GetTransferRunAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TransferRun>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            TransferRun responseCallSettings = await client.GetTransferRunAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TransferRun responseCancellationToken = await client.GetTransferRunAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetTransferRun()
        {
            moq::Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new moq::Mock<DataTransferService.DataTransferServiceClient>(moq::MockBehavior.Strict);
            GetTransferRunRequest request = new GetTransferRunRequest
            {
                RunName = RunName.FromProjectTransferConfigRun("[PROJECT]", "[TRANSFER_CONFIG]", "[RUN]"),
            };
            TransferRun expectedResponse = new TransferRun
            {
                RunName = RunName.FromProjectTransferConfigRun("[PROJECT]", "[TRANSFER_CONFIG]", "[RUN]"),
                DestinationDatasetId = "destination_dataset_idb2e283b4",
                ScheduleTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DataSourceId = "data_source_id4a2ea315",
                State = TransferState.Unspecified,
                Params = new wkt::Struct(),
                RunTime = new wkt::Timestamp(),
                UserId = -7972883667886640920L,
                Schedule = "schedule59559879",
                ErrorStatus = new gr::Status(),
                NotificationPubsubTopic = "notification_pubsub_topic857fa8e4",
                EmailPreferences = new EmailPreferences(),
            };
            mockGrpcClient.Setup(x => x.GetTransferRun(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            TransferRun response = client.GetTransferRun(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetTransferRunAsync()
        {
            moq::Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new moq::Mock<DataTransferService.DataTransferServiceClient>(moq::MockBehavior.Strict);
            GetTransferRunRequest request = new GetTransferRunRequest
            {
                RunName = RunName.FromProjectTransferConfigRun("[PROJECT]", "[TRANSFER_CONFIG]", "[RUN]"),
            };
            TransferRun expectedResponse = new TransferRun
            {
                RunName = RunName.FromProjectTransferConfigRun("[PROJECT]", "[TRANSFER_CONFIG]", "[RUN]"),
                DestinationDatasetId = "destination_dataset_idb2e283b4",
                ScheduleTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DataSourceId = "data_source_id4a2ea315",
                State = TransferState.Unspecified,
                Params = new wkt::Struct(),
                RunTime = new wkt::Timestamp(),
                UserId = -7972883667886640920L,
                Schedule = "schedule59559879",
                ErrorStatus = new gr::Status(),
                NotificationPubsubTopic = "notification_pubsub_topic857fa8e4",
                EmailPreferences = new EmailPreferences(),
            };
            mockGrpcClient.Setup(x => x.GetTransferRunAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TransferRun>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            TransferRun responseCallSettings = await client.GetTransferRunAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TransferRun responseCancellationToken = await client.GetTransferRunAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetTransferRunResourceNames()
        {
            moq::Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new moq::Mock<DataTransferService.DataTransferServiceClient>(moq::MockBehavior.Strict);
            GetTransferRunRequest request = new GetTransferRunRequest
            {
                RunName = RunName.FromProjectTransferConfigRun("[PROJECT]", "[TRANSFER_CONFIG]", "[RUN]"),
            };
            TransferRun expectedResponse = new TransferRun
            {
                RunName = RunName.FromProjectTransferConfigRun("[PROJECT]", "[TRANSFER_CONFIG]", "[RUN]"),
                DestinationDatasetId = "destination_dataset_idb2e283b4",
                ScheduleTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DataSourceId = "data_source_id4a2ea315",
                State = TransferState.Unspecified,
                Params = new wkt::Struct(),
                RunTime = new wkt::Timestamp(),
                UserId = -7972883667886640920L,
                Schedule = "schedule59559879",
                ErrorStatus = new gr::Status(),
                NotificationPubsubTopic = "notification_pubsub_topic857fa8e4",
                EmailPreferences = new EmailPreferences(),
            };
            mockGrpcClient.Setup(x => x.GetTransferRun(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            TransferRun response = client.GetTransferRun(request.RunName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetTransferRunResourceNamesAsync()
        {
            moq::Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new moq::Mock<DataTransferService.DataTransferServiceClient>(moq::MockBehavior.Strict);
            GetTransferRunRequest request = new GetTransferRunRequest
            {
                RunName = RunName.FromProjectTransferConfigRun("[PROJECT]", "[TRANSFER_CONFIG]", "[RUN]"),
            };
            TransferRun expectedResponse = new TransferRun
            {
                RunName = RunName.FromProjectTransferConfigRun("[PROJECT]", "[TRANSFER_CONFIG]", "[RUN]"),
                DestinationDatasetId = "destination_dataset_idb2e283b4",
                ScheduleTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DataSourceId = "data_source_id4a2ea315",
                State = TransferState.Unspecified,
                Params = new wkt::Struct(),
                RunTime = new wkt::Timestamp(),
                UserId = -7972883667886640920L,
                Schedule = "schedule59559879",
                ErrorStatus = new gr::Status(),
                NotificationPubsubTopic = "notification_pubsub_topic857fa8e4",
                EmailPreferences = new EmailPreferences(),
            };
            mockGrpcClient.Setup(x => x.GetTransferRunAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TransferRun>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            TransferRun responseCallSettings = await client.GetTransferRunAsync(request.RunName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TransferRun responseCancellationToken = await client.GetTransferRunAsync(request.RunName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteTransferRunRequestObject()
        {
            moq::Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new moq::Mock<DataTransferService.DataTransferServiceClient>(moq::MockBehavior.Strict);
            DeleteTransferRunRequest request = new DeleteTransferRunRequest
            {
                RunName = RunName.FromProjectTransferConfigRun("[PROJECT]", "[TRANSFER_CONFIG]", "[RUN]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteTransferRun(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteTransferRun(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteTransferRunRequestObjectAsync()
        {
            moq::Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new moq::Mock<DataTransferService.DataTransferServiceClient>(moq::MockBehavior.Strict);
            DeleteTransferRunRequest request = new DeleteTransferRunRequest
            {
                RunName = RunName.FromProjectTransferConfigRun("[PROJECT]", "[TRANSFER_CONFIG]", "[RUN]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteTransferRunAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteTransferRunAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteTransferRunAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteTransferRun()
        {
            moq::Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new moq::Mock<DataTransferService.DataTransferServiceClient>(moq::MockBehavior.Strict);
            DeleteTransferRunRequest request = new DeleteTransferRunRequest
            {
                RunName = RunName.FromProjectTransferConfigRun("[PROJECT]", "[TRANSFER_CONFIG]", "[RUN]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteTransferRun(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteTransferRun(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteTransferRunAsync()
        {
            moq::Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new moq::Mock<DataTransferService.DataTransferServiceClient>(moq::MockBehavior.Strict);
            DeleteTransferRunRequest request = new DeleteTransferRunRequest
            {
                RunName = RunName.FromProjectTransferConfigRun("[PROJECT]", "[TRANSFER_CONFIG]", "[RUN]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteTransferRunAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteTransferRunAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteTransferRunAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteTransferRunResourceNames()
        {
            moq::Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new moq::Mock<DataTransferService.DataTransferServiceClient>(moq::MockBehavior.Strict);
            DeleteTransferRunRequest request = new DeleteTransferRunRequest
            {
                RunName = RunName.FromProjectTransferConfigRun("[PROJECT]", "[TRANSFER_CONFIG]", "[RUN]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteTransferRun(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteTransferRun(request.RunName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteTransferRunResourceNamesAsync()
        {
            moq::Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new moq::Mock<DataTransferService.DataTransferServiceClient>(moq::MockBehavior.Strict);
            DeleteTransferRunRequest request = new DeleteTransferRunRequest
            {
                RunName = RunName.FromProjectTransferConfigRun("[PROJECT]", "[TRANSFER_CONFIG]", "[RUN]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteTransferRunAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteTransferRunAsync(request.RunName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteTransferRunAsync(request.RunName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CheckValidCredsRequestObject()
        {
            moq::Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new moq::Mock<DataTransferService.DataTransferServiceClient>(moq::MockBehavior.Strict);
            CheckValidCredsRequest request = new CheckValidCredsRequest
            {
                DataSourceName = DataSourceName.FromProjectDataSource("[PROJECT]", "[DATA_SOURCE]"),
            };
            CheckValidCredsResponse expectedResponse = new CheckValidCredsResponse
            {
                HasValidCreds = true,
            };
            mockGrpcClient.Setup(x => x.CheckValidCreds(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            CheckValidCredsResponse response = client.CheckValidCreds(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CheckValidCredsRequestObjectAsync()
        {
            moq::Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new moq::Mock<DataTransferService.DataTransferServiceClient>(moq::MockBehavior.Strict);
            CheckValidCredsRequest request = new CheckValidCredsRequest
            {
                DataSourceName = DataSourceName.FromProjectDataSource("[PROJECT]", "[DATA_SOURCE]"),
            };
            CheckValidCredsResponse expectedResponse = new CheckValidCredsResponse
            {
                HasValidCreds = true,
            };
            mockGrpcClient.Setup(x => x.CheckValidCredsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CheckValidCredsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            CheckValidCredsResponse responseCallSettings = await client.CheckValidCredsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CheckValidCredsResponse responseCancellationToken = await client.CheckValidCredsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CheckValidCreds()
        {
            moq::Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new moq::Mock<DataTransferService.DataTransferServiceClient>(moq::MockBehavior.Strict);
            CheckValidCredsRequest request = new CheckValidCredsRequest
            {
                DataSourceName = DataSourceName.FromProjectDataSource("[PROJECT]", "[DATA_SOURCE]"),
            };
            CheckValidCredsResponse expectedResponse = new CheckValidCredsResponse
            {
                HasValidCreds = true,
            };
            mockGrpcClient.Setup(x => x.CheckValidCreds(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            CheckValidCredsResponse response = client.CheckValidCreds(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CheckValidCredsAsync()
        {
            moq::Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new moq::Mock<DataTransferService.DataTransferServiceClient>(moq::MockBehavior.Strict);
            CheckValidCredsRequest request = new CheckValidCredsRequest
            {
                DataSourceName = DataSourceName.FromProjectDataSource("[PROJECT]", "[DATA_SOURCE]"),
            };
            CheckValidCredsResponse expectedResponse = new CheckValidCredsResponse
            {
                HasValidCreds = true,
            };
            mockGrpcClient.Setup(x => x.CheckValidCredsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CheckValidCredsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            CheckValidCredsResponse responseCallSettings = await client.CheckValidCredsAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CheckValidCredsResponse responseCancellationToken = await client.CheckValidCredsAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CheckValidCredsResourceNames()
        {
            moq::Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new moq::Mock<DataTransferService.DataTransferServiceClient>(moq::MockBehavior.Strict);
            CheckValidCredsRequest request = new CheckValidCredsRequest
            {
                DataSourceName = DataSourceName.FromProjectDataSource("[PROJECT]", "[DATA_SOURCE]"),
            };
            CheckValidCredsResponse expectedResponse = new CheckValidCredsResponse
            {
                HasValidCreds = true,
            };
            mockGrpcClient.Setup(x => x.CheckValidCreds(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            CheckValidCredsResponse response = client.CheckValidCreds(request.DataSourceName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CheckValidCredsResourceNamesAsync()
        {
            moq::Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new moq::Mock<DataTransferService.DataTransferServiceClient>(moq::MockBehavior.Strict);
            CheckValidCredsRequest request = new CheckValidCredsRequest
            {
                DataSourceName = DataSourceName.FromProjectDataSource("[PROJECT]", "[DATA_SOURCE]"),
            };
            CheckValidCredsResponse expectedResponse = new CheckValidCredsResponse
            {
                HasValidCreds = true,
            };
            mockGrpcClient.Setup(x => x.CheckValidCredsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CheckValidCredsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            CheckValidCredsResponse responseCallSettings = await client.CheckValidCredsAsync(request.DataSourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CheckValidCredsResponse responseCancellationToken = await client.CheckValidCredsAsync(request.DataSourceName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
