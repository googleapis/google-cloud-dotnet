// Copyright 2018 Google LLC
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

using Google.Api.Gax;
using Google.Api.Gax.Grpc;
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

namespace Google.Cloud.BigQuery.DataTransfer.V1.UnitTests
{
    /// <summary>Generated unit tests</summary>
    public class GeneratedDataTransferServiceClientTest
    {
        [Fact]
        public void GetDataSourceTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new Mock<DataTransferService.DataTransferServiceClient> { DefaultValue = DefaultValue.Mock };
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
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.GetDataSource(It.IsAny<GetDataSourceRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            DataSourceNameOneof name = DataSourceNameOneof.From(new ProjectDataSourceName("[PROJECT]", "[DATA_SOURCE]"));
            DataSource response = client.GetDataSource(name);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateTransferConfigTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new Mock<DataTransferService.DataTransferServiceClient> { DefaultValue = DefaultValue.Mock };
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
            };
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.CreateTransferConfig(It.IsAny<CreateTransferConfigRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            ParentNameOneof parent = ParentNameOneof.From(new ProjectName("[PROJECT]"));
            TransferConfig transferConfig = new TransferConfig();
            TransferConfig response = client.CreateTransferConfig(parent, transferConfig);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateTransferConfigTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new Mock<DataTransferService.DataTransferServiceClient> { DefaultValue = DefaultValue.Mock };
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
            };
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.UpdateTransferConfig(It.IsAny<UpdateTransferConfigRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            TransferConfig transferConfig = new TransferConfig();
            FieldMask updateMask = new FieldMask();
            TransferConfig response = client.UpdateTransferConfig(transferConfig, updateMask);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteTransferConfigTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new Mock<DataTransferService.DataTransferServiceClient> { DefaultValue = DefaultValue.Mock };
            Empty expectedResponse = new Empty();
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.DeleteTransferConfig(It.IsAny<DeleteTransferConfigRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            TransferConfigNameOneof name = TransferConfigNameOneof.From(new ProjectTransferConfigName("[PROJECT]", "[TRANSFER_CONFIG]"));
            client.DeleteTransferConfig(name);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetTransferConfigTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new Mock<DataTransferService.DataTransferServiceClient> { DefaultValue = DefaultValue.Mock };
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
            };
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.GetTransferConfig(It.IsAny<GetTransferConfigRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            TransferConfigNameOneof name = TransferConfigNameOneof.From(new ProjectTransferConfigName("[PROJECT]", "[TRANSFER_CONFIG]"));
            TransferConfig response = client.GetTransferConfig(name);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void ScheduleTransferRunsTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new Mock<DataTransferService.DataTransferServiceClient> { DefaultValue = DefaultValue.Mock };
            ScheduleTransferRunsResponse expectedResponse = new ScheduleTransferRunsResponse();
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.ScheduleTransferRuns(It.IsAny<ScheduleTransferRunsRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            TransferConfigNameOneof parent = TransferConfigNameOneof.From(new ProjectTransferConfigName("[PROJECT]", "[TRANSFER_CONFIG]"));
            Timestamp startTime = new Timestamp();
            Timestamp endTime = new Timestamp();
            ScheduleTransferRunsResponse response = client.ScheduleTransferRuns(parent, startTime, endTime);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetTransferRunTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new Mock<DataTransferService.DataTransferServiceClient> { DefaultValue = DefaultValue.Mock };
            TransferRun expectedResponse = new TransferRun
            {
                RunNameOneof = RunNameOneof.From(new ProjectRunName("[PROJECT]", "[TRANSFER_CONFIG]", "[RUN]")),
                DestinationDatasetId = "destinationDatasetId1541564179",
                DataSourceId = "dataSourceId-1015796374",
                UserId = 147132913L,
                Schedule = "schedule-697920873",
            };
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.GetTransferRun(It.IsAny<GetTransferRunRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            RunNameOneof name = RunNameOneof.From(new ProjectRunName("[PROJECT]", "[TRANSFER_CONFIG]", "[RUN]"));
            TransferRun response = client.GetTransferRun(name);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteTransferRunTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new Mock<DataTransferService.DataTransferServiceClient> { DefaultValue = DefaultValue.Mock };
            Empty expectedResponse = new Empty();
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.DeleteTransferRun(It.IsAny<DeleteTransferRunRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            RunNameOneof name = RunNameOneof.From(new ProjectRunName("[PROJECT]", "[TRANSFER_CONFIG]", "[RUN]"));
            client.DeleteTransferRun(name);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CheckValidCredsTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new Mock<DataTransferService.DataTransferServiceClient> { DefaultValue = DefaultValue.Mock };
            CheckValidCredsResponse expectedResponse = new CheckValidCredsResponse
            {
                HasValidCreds = false,
            };
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.CheckValidCreds(It.IsAny<CheckValidCredsRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            DataSourceNameOneof name = DataSourceNameOneof.From(new ProjectDataSourceName("[PROJECT]", "[DATA_SOURCE]"));
            CheckValidCredsResponse response = client.CheckValidCreds(name);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}
