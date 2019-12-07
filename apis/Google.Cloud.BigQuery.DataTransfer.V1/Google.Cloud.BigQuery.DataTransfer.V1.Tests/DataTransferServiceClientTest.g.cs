// Copyright 2019 Google LLC
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

// This is currently a hand-written addition to the generated file, until the
// generator includes it automatically (or doesn't use the deprecated members in tests).
#pragma warning disable CS0612 // Type or member is obsolete

namespace Google.Cloud.BigQuery.DataTransfer.V1.Tests
{
    using Google.Api.Gax;
    using Google.Api.Gax.Grpc;
    using Google.Api.Gax.ResourceNames;
    using apis = Google.Cloud.BigQuery.DataTransfer.V1;
    using Google.Protobuf.WellKnownTypes;
    using Grpc.Core;
    using Moq;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Threading;
    using System.Threading.Tasks;
    using Xunit;

    /// <summary>Generated unit tests</summary>
    public class GeneratedDataTransferServiceClientTest
    {
        [Fact]
        public void GetDataSource()
        {
            Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new Mock<DataTransferService.DataTransferServiceClient>(MockBehavior.Strict);
            GetDataSourceRequest expectedRequest = new GetDataSourceRequest
            {
                DataSourceNameOneof = DataSourceNameOneof.From(new ProjectDataSourceName("[PROJECT]", "[DATA_SOURCE]")),
            };
            DataSource expectedResponse = new DataSource
            {
                DataSourceNameOneof = DataSourceNameOneof.From(new ProjectDataSourceName("[PROJECT]", "[DATA_SOURCE]")),
                DataSourceId = "dataSourceId-1015796374",
                DisplayName = "displayName1615086568",
                Description = "description-1724546052",
                ClientId = "clientId-1904089585",
                SupportsMultipleTransfers = true,
                UpdateDeadlineSeconds = 991471694,
                DefaultSchedule = "defaultSchedule-800168235",
                SupportsCustomSchedule = true,
                HelpUrl = "helpUrl-789431439",
                DefaultDataRefreshWindowDays = 1804935157,
                ManualRunsDisabled = true,
            };
            mockGrpcClient.Setup(x => x.GetDataSource(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            DataSourceNameOneof name = DataSourceNameOneof.From(new ProjectDataSourceName("[PROJECT]", "[DATA_SOURCE]"));
            DataSource response = client.GetDataSource(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetDataSourceAsync()
        {
            Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new Mock<DataTransferService.DataTransferServiceClient>(MockBehavior.Strict);
            GetDataSourceRequest expectedRequest = new GetDataSourceRequest
            {
                DataSourceNameOneof = DataSourceNameOneof.From(new ProjectDataSourceName("[PROJECT]", "[DATA_SOURCE]")),
            };
            DataSource expectedResponse = new DataSource
            {
                DataSourceNameOneof = DataSourceNameOneof.From(new ProjectDataSourceName("[PROJECT]", "[DATA_SOURCE]")),
                DataSourceId = "dataSourceId-1015796374",
                DisplayName = "displayName1615086568",
                Description = "description-1724546052",
                ClientId = "clientId-1904089585",
                SupportsMultipleTransfers = true,
                UpdateDeadlineSeconds = 991471694,
                DefaultSchedule = "defaultSchedule-800168235",
                SupportsCustomSchedule = true,
                HelpUrl = "helpUrl-789431439",
                DefaultDataRefreshWindowDays = 1804935157,
                ManualRunsDisabled = true,
            };
            mockGrpcClient.Setup(x => x.GetDataSourceAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<DataSource>(Task.FromResult(expectedResponse), null, null, null, null));
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            DataSourceNameOneof name = DataSourceNameOneof.From(new ProjectDataSourceName("[PROJECT]", "[DATA_SOURCE]"));
            DataSource response = await client.GetDataSourceAsync(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetDataSource2()
        {
            Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new Mock<DataTransferService.DataTransferServiceClient>(MockBehavior.Strict);
            GetDataSourceRequest request = new GetDataSourceRequest
            {
                DataSourceNameOneof = DataSourceNameOneof.From(new ProjectDataSourceName("[PROJECT]", "[DATA_SOURCE]")),
            };
            DataSource expectedResponse = new DataSource
            {
                DataSourceNameOneof = DataSourceNameOneof.From(new ProjectDataSourceName("[PROJECT]", "[DATA_SOURCE]")),
                DataSourceId = "dataSourceId-1015796374",
                DisplayName = "displayName1615086568",
                Description = "description-1724546052",
                ClientId = "clientId-1904089585",
                SupportsMultipleTransfers = true,
                UpdateDeadlineSeconds = 991471694,
                DefaultSchedule = "defaultSchedule-800168235",
                SupportsCustomSchedule = true,
                HelpUrl = "helpUrl-789431439",
                DefaultDataRefreshWindowDays = 1804935157,
                ManualRunsDisabled = true,
            };
            mockGrpcClient.Setup(x => x.GetDataSource(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            DataSource response = client.GetDataSource(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetDataSourceAsync2()
        {
            Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new Mock<DataTransferService.DataTransferServiceClient>(MockBehavior.Strict);
            GetDataSourceRequest request = new GetDataSourceRequest
            {
                DataSourceNameOneof = DataSourceNameOneof.From(new ProjectDataSourceName("[PROJECT]", "[DATA_SOURCE]")),
            };
            DataSource expectedResponse = new DataSource
            {
                DataSourceNameOneof = DataSourceNameOneof.From(new ProjectDataSourceName("[PROJECT]", "[DATA_SOURCE]")),
                DataSourceId = "dataSourceId-1015796374",
                DisplayName = "displayName1615086568",
                Description = "description-1724546052",
                ClientId = "clientId-1904089585",
                SupportsMultipleTransfers = true,
                UpdateDeadlineSeconds = 991471694,
                DefaultSchedule = "defaultSchedule-800168235",
                SupportsCustomSchedule = true,
                HelpUrl = "helpUrl-789431439",
                DefaultDataRefreshWindowDays = 1804935157,
                ManualRunsDisabled = true,
            };
            mockGrpcClient.Setup(x => x.GetDataSourceAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<DataSource>(Task.FromResult(expectedResponse), null, null, null, null));
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            DataSource response = await client.GetDataSourceAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateTransferConfig()
        {
            Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new Mock<DataTransferService.DataTransferServiceClient>(MockBehavior.Strict);
            CreateTransferConfigRequest expectedRequest = new CreateTransferConfigRequest
            {
                ParentAsParentNameOneof = ParentNameOneof.From(new ProjectName("[PROJECT]")),
                TransferConfig = new TransferConfig(),
            };
            TransferConfig expectedResponse = new TransferConfig
            {
                TransferConfigNameOneof = TransferConfigNameOneof.From(new ProjectTransferConfigName("[PROJECT]", "[TRANSFER_CONFIG]")),
                DestinationDatasetId = "destinationDatasetId1541564179",
                DisplayName = "displayName1615086568",
                DataSourceId = "dataSourceId-1015796374",
                Schedule = "schedule-697920873",
                DataRefreshWindowDays = 327632845,
                Disabled = true,
                UserId = 147132913L,
                DatasetRegion = "datasetRegion959248539",
                NotificationPubsubTopic = "notificationPubsubTopic1794281191",
            };
            mockGrpcClient.Setup(x => x.CreateTransferConfig(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            ParentNameOneof parent = ParentNameOneof.From(new ProjectName("[PROJECT]"));
            TransferConfig transferConfig = new TransferConfig();
            TransferConfig response = client.CreateTransferConfig(parent, transferConfig);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateTransferConfigAsync()
        {
            Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new Mock<DataTransferService.DataTransferServiceClient>(MockBehavior.Strict);
            CreateTransferConfigRequest expectedRequest = new CreateTransferConfigRequest
            {
                ParentAsParentNameOneof = ParentNameOneof.From(new ProjectName("[PROJECT]")),
                TransferConfig = new TransferConfig(),
            };
            TransferConfig expectedResponse = new TransferConfig
            {
                TransferConfigNameOneof = TransferConfigNameOneof.From(new ProjectTransferConfigName("[PROJECT]", "[TRANSFER_CONFIG]")),
                DestinationDatasetId = "destinationDatasetId1541564179",
                DisplayName = "displayName1615086568",
                DataSourceId = "dataSourceId-1015796374",
                Schedule = "schedule-697920873",
                DataRefreshWindowDays = 327632845,
                Disabled = true,
                UserId = 147132913L,
                DatasetRegion = "datasetRegion959248539",
                NotificationPubsubTopic = "notificationPubsubTopic1794281191",
            };
            mockGrpcClient.Setup(x => x.CreateTransferConfigAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<TransferConfig>(Task.FromResult(expectedResponse), null, null, null, null));
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            ParentNameOneof parent = ParentNameOneof.From(new ProjectName("[PROJECT]"));
            TransferConfig transferConfig = new TransferConfig();
            TransferConfig response = await client.CreateTransferConfigAsync(parent, transferConfig);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateTransferConfig2()
        {
            Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new Mock<DataTransferService.DataTransferServiceClient>(MockBehavior.Strict);
            CreateTransferConfigRequest request = new CreateTransferConfigRequest
            {
                ParentAsParentNameOneof = ParentNameOneof.From(new ProjectName("[PROJECT]")),
                TransferConfig = new TransferConfig(),
            };
            TransferConfig expectedResponse = new TransferConfig
            {
                TransferConfigNameOneof = TransferConfigNameOneof.From(new ProjectTransferConfigName("[PROJECT]", "[TRANSFER_CONFIG]")),
                DestinationDatasetId = "destinationDatasetId1541564179",
                DisplayName = "displayName1615086568",
                DataSourceId = "dataSourceId-1015796374",
                Schedule = "schedule-697920873",
                DataRefreshWindowDays = 327632845,
                Disabled = true,
                UserId = 147132913L,
                DatasetRegion = "datasetRegion959248539",
                NotificationPubsubTopic = "notificationPubsubTopic1794281191",
            };
            mockGrpcClient.Setup(x => x.CreateTransferConfig(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            TransferConfig response = client.CreateTransferConfig(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateTransferConfigAsync2()
        {
            Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new Mock<DataTransferService.DataTransferServiceClient>(MockBehavior.Strict);
            CreateTransferConfigRequest request = new CreateTransferConfigRequest
            {
                ParentAsParentNameOneof = ParentNameOneof.From(new ProjectName("[PROJECT]")),
                TransferConfig = new TransferConfig(),
            };
            TransferConfig expectedResponse = new TransferConfig
            {
                TransferConfigNameOneof = TransferConfigNameOneof.From(new ProjectTransferConfigName("[PROJECT]", "[TRANSFER_CONFIG]")),
                DestinationDatasetId = "destinationDatasetId1541564179",
                DisplayName = "displayName1615086568",
                DataSourceId = "dataSourceId-1015796374",
                Schedule = "schedule-697920873",
                DataRefreshWindowDays = 327632845,
                Disabled = true,
                UserId = 147132913L,
                DatasetRegion = "datasetRegion959248539",
                NotificationPubsubTopic = "notificationPubsubTopic1794281191",
            };
            mockGrpcClient.Setup(x => x.CreateTransferConfigAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<TransferConfig>(Task.FromResult(expectedResponse), null, null, null, null));
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            TransferConfig response = await client.CreateTransferConfigAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateTransferConfig()
        {
            Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new Mock<DataTransferService.DataTransferServiceClient>(MockBehavior.Strict);
            UpdateTransferConfigRequest expectedRequest = new UpdateTransferConfigRequest
            {
                TransferConfig = new TransferConfig(),
                UpdateMask = new FieldMask(),
            };
            TransferConfig expectedResponse = new TransferConfig
            {
                TransferConfigNameOneof = TransferConfigNameOneof.From(new ProjectTransferConfigName("[PROJECT]", "[TRANSFER_CONFIG]")),
                DestinationDatasetId = "destinationDatasetId1541564179",
                DisplayName = "displayName1615086568",
                DataSourceId = "dataSourceId-1015796374",
                Schedule = "schedule-697920873",
                DataRefreshWindowDays = 327632845,
                Disabled = true,
                UserId = 147132913L,
                DatasetRegion = "datasetRegion959248539",
                NotificationPubsubTopic = "notificationPubsubTopic1794281191",
            };
            mockGrpcClient.Setup(x => x.UpdateTransferConfig(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            TransferConfig transferConfig = new TransferConfig();
            FieldMask updateMask = new FieldMask();
            TransferConfig response = client.UpdateTransferConfig(transferConfig, updateMask);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task UpdateTransferConfigAsync()
        {
            Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new Mock<DataTransferService.DataTransferServiceClient>(MockBehavior.Strict);
            UpdateTransferConfigRequest expectedRequest = new UpdateTransferConfigRequest
            {
                TransferConfig = new TransferConfig(),
                UpdateMask = new FieldMask(),
            };
            TransferConfig expectedResponse = new TransferConfig
            {
                TransferConfigNameOneof = TransferConfigNameOneof.From(new ProjectTransferConfigName("[PROJECT]", "[TRANSFER_CONFIG]")),
                DestinationDatasetId = "destinationDatasetId1541564179",
                DisplayName = "displayName1615086568",
                DataSourceId = "dataSourceId-1015796374",
                Schedule = "schedule-697920873",
                DataRefreshWindowDays = 327632845,
                Disabled = true,
                UserId = 147132913L,
                DatasetRegion = "datasetRegion959248539",
                NotificationPubsubTopic = "notificationPubsubTopic1794281191",
            };
            mockGrpcClient.Setup(x => x.UpdateTransferConfigAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<TransferConfig>(Task.FromResult(expectedResponse), null, null, null, null));
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            TransferConfig transferConfig = new TransferConfig();
            FieldMask updateMask = new FieldMask();
            TransferConfig response = await client.UpdateTransferConfigAsync(transferConfig, updateMask);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateTransferConfig2()
        {
            Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new Mock<DataTransferService.DataTransferServiceClient>(MockBehavior.Strict);
            UpdateTransferConfigRequest request = new UpdateTransferConfigRequest
            {
                TransferConfig = new TransferConfig(),
                UpdateMask = new FieldMask(),
            };
            TransferConfig expectedResponse = new TransferConfig
            {
                TransferConfigNameOneof = TransferConfigNameOneof.From(new ProjectTransferConfigName("[PROJECT]", "[TRANSFER_CONFIG]")),
                DestinationDatasetId = "destinationDatasetId1541564179",
                DisplayName = "displayName1615086568",
                DataSourceId = "dataSourceId-1015796374",
                Schedule = "schedule-697920873",
                DataRefreshWindowDays = 327632845,
                Disabled = true,
                UserId = 147132913L,
                DatasetRegion = "datasetRegion959248539",
                NotificationPubsubTopic = "notificationPubsubTopic1794281191",
            };
            mockGrpcClient.Setup(x => x.UpdateTransferConfig(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            TransferConfig response = client.UpdateTransferConfig(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task UpdateTransferConfigAsync2()
        {
            Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new Mock<DataTransferService.DataTransferServiceClient>(MockBehavior.Strict);
            UpdateTransferConfigRequest request = new UpdateTransferConfigRequest
            {
                TransferConfig = new TransferConfig(),
                UpdateMask = new FieldMask(),
            };
            TransferConfig expectedResponse = new TransferConfig
            {
                TransferConfigNameOneof = TransferConfigNameOneof.From(new ProjectTransferConfigName("[PROJECT]", "[TRANSFER_CONFIG]")),
                DestinationDatasetId = "destinationDatasetId1541564179",
                DisplayName = "displayName1615086568",
                DataSourceId = "dataSourceId-1015796374",
                Schedule = "schedule-697920873",
                DataRefreshWindowDays = 327632845,
                Disabled = true,
                UserId = 147132913L,
                DatasetRegion = "datasetRegion959248539",
                NotificationPubsubTopic = "notificationPubsubTopic1794281191",
            };
            mockGrpcClient.Setup(x => x.UpdateTransferConfigAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<TransferConfig>(Task.FromResult(expectedResponse), null, null, null, null));
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            TransferConfig response = await client.UpdateTransferConfigAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteTransferConfig()
        {
            Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new Mock<DataTransferService.DataTransferServiceClient>(MockBehavior.Strict);
            DeleteTransferConfigRequest expectedRequest = new DeleteTransferConfigRequest
            {
                TransferConfigNameOneof = TransferConfigNameOneof.From(new ProjectTransferConfigName("[PROJECT]", "[TRANSFER_CONFIG]")),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteTransferConfig(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            TransferConfigNameOneof name = TransferConfigNameOneof.From(new ProjectTransferConfigName("[PROJECT]", "[TRANSFER_CONFIG]"));
            client.DeleteTransferConfig(name);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteTransferConfigAsync()
        {
            Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new Mock<DataTransferService.DataTransferServiceClient>(MockBehavior.Strict);
            DeleteTransferConfigRequest expectedRequest = new DeleteTransferConfigRequest
            {
                TransferConfigNameOneof = TransferConfigNameOneof.From(new ProjectTransferConfigName("[PROJECT]", "[TRANSFER_CONFIG]")),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteTransferConfigAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            TransferConfigNameOneof name = TransferConfigNameOneof.From(new ProjectTransferConfigName("[PROJECT]", "[TRANSFER_CONFIG]"));
            await client.DeleteTransferConfigAsync(name);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteTransferConfig2()
        {
            Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new Mock<DataTransferService.DataTransferServiceClient>(MockBehavior.Strict);
            DeleteTransferConfigRequest request = new DeleteTransferConfigRequest
            {
                TransferConfigNameOneof = TransferConfigNameOneof.From(new ProjectTransferConfigName("[PROJECT]", "[TRANSFER_CONFIG]")),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteTransferConfig(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteTransferConfig(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteTransferConfigAsync2()
        {
            Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new Mock<DataTransferService.DataTransferServiceClient>(MockBehavior.Strict);
            DeleteTransferConfigRequest request = new DeleteTransferConfigRequest
            {
                TransferConfigNameOneof = TransferConfigNameOneof.From(new ProjectTransferConfigName("[PROJECT]", "[TRANSFER_CONFIG]")),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteTransferConfigAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteTransferConfigAsync(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetTransferConfig()
        {
            Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new Mock<DataTransferService.DataTransferServiceClient>(MockBehavior.Strict);
            GetTransferConfigRequest expectedRequest = new GetTransferConfigRequest
            {
                TransferConfigNameOneof = TransferConfigNameOneof.From(new ProjectTransferConfigName("[PROJECT]", "[TRANSFER_CONFIG]")),
            };
            TransferConfig expectedResponse = new TransferConfig
            {
                TransferConfigNameOneof = TransferConfigNameOneof.From(new ProjectTransferConfigName("[PROJECT]", "[TRANSFER_CONFIG]")),
                DestinationDatasetId = "destinationDatasetId1541564179",
                DisplayName = "displayName1615086568",
                DataSourceId = "dataSourceId-1015796374",
                Schedule = "schedule-697920873",
                DataRefreshWindowDays = 327632845,
                Disabled = true,
                UserId = 147132913L,
                DatasetRegion = "datasetRegion959248539",
                NotificationPubsubTopic = "notificationPubsubTopic1794281191",
            };
            mockGrpcClient.Setup(x => x.GetTransferConfig(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            TransferConfigNameOneof name = TransferConfigNameOneof.From(new ProjectTransferConfigName("[PROJECT]", "[TRANSFER_CONFIG]"));
            TransferConfig response = client.GetTransferConfig(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetTransferConfigAsync()
        {
            Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new Mock<DataTransferService.DataTransferServiceClient>(MockBehavior.Strict);
            GetTransferConfigRequest expectedRequest = new GetTransferConfigRequest
            {
                TransferConfigNameOneof = TransferConfigNameOneof.From(new ProjectTransferConfigName("[PROJECT]", "[TRANSFER_CONFIG]")),
            };
            TransferConfig expectedResponse = new TransferConfig
            {
                TransferConfigNameOneof = TransferConfigNameOneof.From(new ProjectTransferConfigName("[PROJECT]", "[TRANSFER_CONFIG]")),
                DestinationDatasetId = "destinationDatasetId1541564179",
                DisplayName = "displayName1615086568",
                DataSourceId = "dataSourceId-1015796374",
                Schedule = "schedule-697920873",
                DataRefreshWindowDays = 327632845,
                Disabled = true,
                UserId = 147132913L,
                DatasetRegion = "datasetRegion959248539",
                NotificationPubsubTopic = "notificationPubsubTopic1794281191",
            };
            mockGrpcClient.Setup(x => x.GetTransferConfigAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<TransferConfig>(Task.FromResult(expectedResponse), null, null, null, null));
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            TransferConfigNameOneof name = TransferConfigNameOneof.From(new ProjectTransferConfigName("[PROJECT]", "[TRANSFER_CONFIG]"));
            TransferConfig response = await client.GetTransferConfigAsync(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetTransferConfig2()
        {
            Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new Mock<DataTransferService.DataTransferServiceClient>(MockBehavior.Strict);
            GetTransferConfigRequest request = new GetTransferConfigRequest
            {
                TransferConfigNameOneof = TransferConfigNameOneof.From(new ProjectTransferConfigName("[PROJECT]", "[TRANSFER_CONFIG]")),
            };
            TransferConfig expectedResponse = new TransferConfig
            {
                TransferConfigNameOneof = TransferConfigNameOneof.From(new ProjectTransferConfigName("[PROJECT]", "[TRANSFER_CONFIG]")),
                DestinationDatasetId = "destinationDatasetId1541564179",
                DisplayName = "displayName1615086568",
                DataSourceId = "dataSourceId-1015796374",
                Schedule = "schedule-697920873",
                DataRefreshWindowDays = 327632845,
                Disabled = true,
                UserId = 147132913L,
                DatasetRegion = "datasetRegion959248539",
                NotificationPubsubTopic = "notificationPubsubTopic1794281191",
            };
            mockGrpcClient.Setup(x => x.GetTransferConfig(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            TransferConfig response = client.GetTransferConfig(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetTransferConfigAsync2()
        {
            Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new Mock<DataTransferService.DataTransferServiceClient>(MockBehavior.Strict);
            GetTransferConfigRequest request = new GetTransferConfigRequest
            {
                TransferConfigNameOneof = TransferConfigNameOneof.From(new ProjectTransferConfigName("[PROJECT]", "[TRANSFER_CONFIG]")),
            };
            TransferConfig expectedResponse = new TransferConfig
            {
                TransferConfigNameOneof = TransferConfigNameOneof.From(new ProjectTransferConfigName("[PROJECT]", "[TRANSFER_CONFIG]")),
                DestinationDatasetId = "destinationDatasetId1541564179",
                DisplayName = "displayName1615086568",
                DataSourceId = "dataSourceId-1015796374",
                Schedule = "schedule-697920873",
                DataRefreshWindowDays = 327632845,
                Disabled = true,
                UserId = 147132913L,
                DatasetRegion = "datasetRegion959248539",
                NotificationPubsubTopic = "notificationPubsubTopic1794281191",
            };
            mockGrpcClient.Setup(x => x.GetTransferConfigAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<TransferConfig>(Task.FromResult(expectedResponse), null, null, null, null));
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            TransferConfig response = await client.GetTransferConfigAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void ScheduleTransferRuns()
        {
            Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new Mock<DataTransferService.DataTransferServiceClient>(MockBehavior.Strict);
            ScheduleTransferRunsRequest expectedRequest = new ScheduleTransferRunsRequest
            {
                ParentAsTransferConfigNameOneof = TransferConfigNameOneof.From(new ProjectTransferConfigName("[PROJECT]", "[TRANSFER_CONFIG]")),
                StartTime = new Timestamp(),
                EndTime = new Timestamp(),
            };
            ScheduleTransferRunsResponse expectedResponse = new ScheduleTransferRunsResponse();
            mockGrpcClient.Setup(x => x.ScheduleTransferRuns(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            TransferConfigNameOneof parent = TransferConfigNameOneof.From(new ProjectTransferConfigName("[PROJECT]", "[TRANSFER_CONFIG]"));
            Timestamp startTime = new Timestamp();
            Timestamp endTime = new Timestamp();
            ScheduleTransferRunsResponse response = client.ScheduleTransferRuns(parent, startTime, endTime);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task ScheduleTransferRunsAsync()
        {
            Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new Mock<DataTransferService.DataTransferServiceClient>(MockBehavior.Strict);
            ScheduleTransferRunsRequest expectedRequest = new ScheduleTransferRunsRequest
            {
                ParentAsTransferConfigNameOneof = TransferConfigNameOneof.From(new ProjectTransferConfigName("[PROJECT]", "[TRANSFER_CONFIG]")),
                StartTime = new Timestamp(),
                EndTime = new Timestamp(),
            };
            ScheduleTransferRunsResponse expectedResponse = new ScheduleTransferRunsResponse();
            mockGrpcClient.Setup(x => x.ScheduleTransferRunsAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ScheduleTransferRunsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            TransferConfigNameOneof parent = TransferConfigNameOneof.From(new ProjectTransferConfigName("[PROJECT]", "[TRANSFER_CONFIG]"));
            Timestamp startTime = new Timestamp();
            Timestamp endTime = new Timestamp();
            ScheduleTransferRunsResponse response = await client.ScheduleTransferRunsAsync(parent, startTime, endTime);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void ScheduleTransferRuns2()
        {
            Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new Mock<DataTransferService.DataTransferServiceClient>(MockBehavior.Strict);
            ScheduleTransferRunsRequest request = new ScheduleTransferRunsRequest
            {
                ParentAsTransferConfigNameOneof = TransferConfigNameOneof.From(new ProjectTransferConfigName("[PROJECT]", "[TRANSFER_CONFIG]")),
                StartTime = new Timestamp(),
                EndTime = new Timestamp(),
            };
            ScheduleTransferRunsResponse expectedResponse = new ScheduleTransferRunsResponse();
            mockGrpcClient.Setup(x => x.ScheduleTransferRuns(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            ScheduleTransferRunsResponse response = client.ScheduleTransferRuns(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task ScheduleTransferRunsAsync2()
        {
            Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new Mock<DataTransferService.DataTransferServiceClient>(MockBehavior.Strict);
            ScheduleTransferRunsRequest request = new ScheduleTransferRunsRequest
            {
                ParentAsTransferConfigNameOneof = TransferConfigNameOneof.From(new ProjectTransferConfigName("[PROJECT]", "[TRANSFER_CONFIG]")),
                StartTime = new Timestamp(),
                EndTime = new Timestamp(),
            };
            ScheduleTransferRunsResponse expectedResponse = new ScheduleTransferRunsResponse();
            mockGrpcClient.Setup(x => x.ScheduleTransferRunsAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ScheduleTransferRunsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            ScheduleTransferRunsResponse response = await client.ScheduleTransferRunsAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetTransferRun()
        {
            Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new Mock<DataTransferService.DataTransferServiceClient>(MockBehavior.Strict);
            GetTransferRunRequest expectedRequest = new GetTransferRunRequest
            {
                RunNameOneof = RunNameOneof.From(new ProjectRunName("[PROJECT]", "[TRANSFER_CONFIG]", "[RUN]")),
            };
            TransferRun expectedResponse = new TransferRun
            {
                RunNameOneof = RunNameOneof.From(new ProjectRunName("[PROJECT]", "[TRANSFER_CONFIG]", "[RUN]")),
                DestinationDatasetId = "destinationDatasetId1541564179",
                DataSourceId = "dataSourceId-1015796374",
                UserId = 147132913L,
                Schedule = "schedule-697920873",
                NotificationPubsubTopic = "notificationPubsubTopic1794281191",
            };
            mockGrpcClient.Setup(x => x.GetTransferRun(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            RunNameOneof name = RunNameOneof.From(new ProjectRunName("[PROJECT]", "[TRANSFER_CONFIG]", "[RUN]"));
            TransferRun response = client.GetTransferRun(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetTransferRunAsync()
        {
            Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new Mock<DataTransferService.DataTransferServiceClient>(MockBehavior.Strict);
            GetTransferRunRequest expectedRequest = new GetTransferRunRequest
            {
                RunNameOneof = RunNameOneof.From(new ProjectRunName("[PROJECT]", "[TRANSFER_CONFIG]", "[RUN]")),
            };
            TransferRun expectedResponse = new TransferRun
            {
                RunNameOneof = RunNameOneof.From(new ProjectRunName("[PROJECT]", "[TRANSFER_CONFIG]", "[RUN]")),
                DestinationDatasetId = "destinationDatasetId1541564179",
                DataSourceId = "dataSourceId-1015796374",
                UserId = 147132913L,
                Schedule = "schedule-697920873",
                NotificationPubsubTopic = "notificationPubsubTopic1794281191",
            };
            mockGrpcClient.Setup(x => x.GetTransferRunAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<TransferRun>(Task.FromResult(expectedResponse), null, null, null, null));
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            RunNameOneof name = RunNameOneof.From(new ProjectRunName("[PROJECT]", "[TRANSFER_CONFIG]", "[RUN]"));
            TransferRun response = await client.GetTransferRunAsync(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetTransferRun2()
        {
            Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new Mock<DataTransferService.DataTransferServiceClient>(MockBehavior.Strict);
            GetTransferRunRequest request = new GetTransferRunRequest
            {
                RunNameOneof = RunNameOneof.From(new ProjectRunName("[PROJECT]", "[TRANSFER_CONFIG]", "[RUN]")),
            };
            TransferRun expectedResponse = new TransferRun
            {
                RunNameOneof = RunNameOneof.From(new ProjectRunName("[PROJECT]", "[TRANSFER_CONFIG]", "[RUN]")),
                DestinationDatasetId = "destinationDatasetId1541564179",
                DataSourceId = "dataSourceId-1015796374",
                UserId = 147132913L,
                Schedule = "schedule-697920873",
                NotificationPubsubTopic = "notificationPubsubTopic1794281191",
            };
            mockGrpcClient.Setup(x => x.GetTransferRun(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            TransferRun response = client.GetTransferRun(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetTransferRunAsync2()
        {
            Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new Mock<DataTransferService.DataTransferServiceClient>(MockBehavior.Strict);
            GetTransferRunRequest request = new GetTransferRunRequest
            {
                RunNameOneof = RunNameOneof.From(new ProjectRunName("[PROJECT]", "[TRANSFER_CONFIG]", "[RUN]")),
            };
            TransferRun expectedResponse = new TransferRun
            {
                RunNameOneof = RunNameOneof.From(new ProjectRunName("[PROJECT]", "[TRANSFER_CONFIG]", "[RUN]")),
                DestinationDatasetId = "destinationDatasetId1541564179",
                DataSourceId = "dataSourceId-1015796374",
                UserId = 147132913L,
                Schedule = "schedule-697920873",
                NotificationPubsubTopic = "notificationPubsubTopic1794281191",
            };
            mockGrpcClient.Setup(x => x.GetTransferRunAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<TransferRun>(Task.FromResult(expectedResponse), null, null, null, null));
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            TransferRun response = await client.GetTransferRunAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteTransferRun()
        {
            Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new Mock<DataTransferService.DataTransferServiceClient>(MockBehavior.Strict);
            DeleteTransferRunRequest expectedRequest = new DeleteTransferRunRequest
            {
                RunNameOneof = RunNameOneof.From(new ProjectRunName("[PROJECT]", "[TRANSFER_CONFIG]", "[RUN]")),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteTransferRun(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            RunNameOneof name = RunNameOneof.From(new ProjectRunName("[PROJECT]", "[TRANSFER_CONFIG]", "[RUN]"));
            client.DeleteTransferRun(name);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteTransferRunAsync()
        {
            Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new Mock<DataTransferService.DataTransferServiceClient>(MockBehavior.Strict);
            DeleteTransferRunRequest expectedRequest = new DeleteTransferRunRequest
            {
                RunNameOneof = RunNameOneof.From(new ProjectRunName("[PROJECT]", "[TRANSFER_CONFIG]", "[RUN]")),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteTransferRunAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            RunNameOneof name = RunNameOneof.From(new ProjectRunName("[PROJECT]", "[TRANSFER_CONFIG]", "[RUN]"));
            await client.DeleteTransferRunAsync(name);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteTransferRun2()
        {
            Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new Mock<DataTransferService.DataTransferServiceClient>(MockBehavior.Strict);
            DeleteTransferRunRequest request = new DeleteTransferRunRequest
            {
                RunNameOneof = RunNameOneof.From(new ProjectRunName("[PROJECT]", "[TRANSFER_CONFIG]", "[RUN]")),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteTransferRun(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteTransferRun(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteTransferRunAsync2()
        {
            Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new Mock<DataTransferService.DataTransferServiceClient>(MockBehavior.Strict);
            DeleteTransferRunRequest request = new DeleteTransferRunRequest
            {
                RunNameOneof = RunNameOneof.From(new ProjectRunName("[PROJECT]", "[TRANSFER_CONFIG]", "[RUN]")),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteTransferRunAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteTransferRunAsync(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CheckValidCreds()
        {
            Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new Mock<DataTransferService.DataTransferServiceClient>(MockBehavior.Strict);
            CheckValidCredsRequest expectedRequest = new CheckValidCredsRequest
            {
                DataSourceNameOneof = DataSourceNameOneof.From(new ProjectDataSourceName("[PROJECT]", "[DATA_SOURCE]")),
            };
            CheckValidCredsResponse expectedResponse = new CheckValidCredsResponse
            {
                HasValidCreds = false,
            };
            mockGrpcClient.Setup(x => x.CheckValidCreds(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            DataSourceNameOneof name = DataSourceNameOneof.From(new ProjectDataSourceName("[PROJECT]", "[DATA_SOURCE]"));
            CheckValidCredsResponse response = client.CheckValidCreds(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CheckValidCredsAsync()
        {
            Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new Mock<DataTransferService.DataTransferServiceClient>(MockBehavior.Strict);
            CheckValidCredsRequest expectedRequest = new CheckValidCredsRequest
            {
                DataSourceNameOneof = DataSourceNameOneof.From(new ProjectDataSourceName("[PROJECT]", "[DATA_SOURCE]")),
            };
            CheckValidCredsResponse expectedResponse = new CheckValidCredsResponse
            {
                HasValidCreds = false,
            };
            mockGrpcClient.Setup(x => x.CheckValidCredsAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<CheckValidCredsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            DataSourceNameOneof name = DataSourceNameOneof.From(new ProjectDataSourceName("[PROJECT]", "[DATA_SOURCE]"));
            CheckValidCredsResponse response = await client.CheckValidCredsAsync(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CheckValidCreds2()
        {
            Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new Mock<DataTransferService.DataTransferServiceClient>(MockBehavior.Strict);
            CheckValidCredsRequest request = new CheckValidCredsRequest
            {
                DataSourceNameOneof = DataSourceNameOneof.From(new ProjectDataSourceName("[PROJECT]", "[DATA_SOURCE]")),
            };
            CheckValidCredsResponse expectedResponse = new CheckValidCredsResponse
            {
                HasValidCreds = false,
            };
            mockGrpcClient.Setup(x => x.CheckValidCreds(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            CheckValidCredsResponse response = client.CheckValidCreds(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CheckValidCredsAsync2()
        {
            Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new Mock<DataTransferService.DataTransferServiceClient>(MockBehavior.Strict);
            CheckValidCredsRequest request = new CheckValidCredsRequest
            {
                DataSourceNameOneof = DataSourceNameOneof.From(new ProjectDataSourceName("[PROJECT]", "[DATA_SOURCE]")),
            };
            CheckValidCredsResponse expectedResponse = new CheckValidCredsResponse
            {
                HasValidCreds = false,
            };
            mockGrpcClient.Setup(x => x.CheckValidCredsAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<CheckValidCredsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            CheckValidCredsResponse response = await client.CheckValidCredsAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void StartManualTransferRuns()
        {
            Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new Mock<DataTransferService.DataTransferServiceClient>(MockBehavior.Strict);
            StartManualTransferRunsRequest request = new StartManualTransferRunsRequest();
            StartManualTransferRunsResponse expectedResponse = new StartManualTransferRunsResponse();
            mockGrpcClient.Setup(x => x.StartManualTransferRuns(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            StartManualTransferRunsResponse response = client.StartManualTransferRuns(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task StartManualTransferRunsAsync()
        {
            Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new Mock<DataTransferService.DataTransferServiceClient>(MockBehavior.Strict);
            StartManualTransferRunsRequest request = new StartManualTransferRunsRequest();
            StartManualTransferRunsResponse expectedResponse = new StartManualTransferRunsResponse();
            mockGrpcClient.Setup(x => x.StartManualTransferRunsAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<StartManualTransferRunsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            StartManualTransferRunsResponse response = await client.StartManualTransferRunsAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}
