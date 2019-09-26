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

namespace Google.Cloud.BigQuery.DataTransfer.V1.Tests
{
    using Google.Api.Gax;
    using Google.Api.Gax.Grpc;
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
    public class GeneratedDataSourceServiceClientTest
    {
        [Fact]
        public void UpdateTransferRun()
        {
            Mock<DataSourceService.DataSourceServiceClient> mockGrpcClient = new Mock<DataSourceService.DataSourceServiceClient>(MockBehavior.Strict);
            UpdateTransferRunRequest request = new UpdateTransferRunRequest();
            TransferRun expectedResponse = new TransferRun
            {
                TransferRunName = new TransferRunName("[PROJECT]", "[LOCATION]", "[TRANSFER_CONFIG]", "[RUN]"),
                DestinationDatasetId = "destinationDatasetId1541564179",
                DataSourceId = "dataSourceId-1015796374",
                UserId = 147132913L,
                Schedule = "schedule-697920873",
            };
            mockGrpcClient.Setup(x => x.UpdateTransferRun(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            DataSourceServiceClient client = new DataSourceServiceClientImpl(mockGrpcClient.Object, null);
            TransferRun response = client.UpdateTransferRun(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task UpdateTransferRunAsync()
        {
            Mock<DataSourceService.DataSourceServiceClient> mockGrpcClient = new Mock<DataSourceService.DataSourceServiceClient>(MockBehavior.Strict);
            UpdateTransferRunRequest request = new UpdateTransferRunRequest();
            TransferRun expectedResponse = new TransferRun
            {
                TransferRunName = new TransferRunName("[PROJECT]", "[LOCATION]", "[TRANSFER_CONFIG]", "[RUN]"),
                DestinationDatasetId = "destinationDatasetId1541564179",
                DataSourceId = "dataSourceId-1015796374",
                UserId = 147132913L,
                Schedule = "schedule-697920873",
            };
            mockGrpcClient.Setup(x => x.UpdateTransferRunAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<TransferRun>(Task.FromResult(expectedResponse), null, null, null, null));
            DataSourceServiceClient client = new DataSourceServiceClientImpl(mockGrpcClient.Object, null);
            TransferRun response = await client.UpdateTransferRunAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void LogTransferRunMessages()
        {
            Mock<DataSourceService.DataSourceServiceClient> mockGrpcClient = new Mock<DataSourceService.DataSourceServiceClient>(MockBehavior.Strict);
            LogTransferRunMessagesRequest request = new LogTransferRunMessagesRequest();
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.LogTransferRunMessages(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            DataSourceServiceClient client = new DataSourceServiceClientImpl(mockGrpcClient.Object, null);
            client.LogTransferRunMessages(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task LogTransferRunMessagesAsync()
        {
            Mock<DataSourceService.DataSourceServiceClient> mockGrpcClient = new Mock<DataSourceService.DataSourceServiceClient>(MockBehavior.Strict);
            LogTransferRunMessagesRequest request = new LogTransferRunMessagesRequest();
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.LogTransferRunMessagesAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            DataSourceServiceClient client = new DataSourceServiceClientImpl(mockGrpcClient.Object, null);
            await client.LogTransferRunMessagesAsync(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void StartBigQueryJobs()
        {
            Mock<DataSourceService.DataSourceServiceClient> mockGrpcClient = new Mock<DataSourceService.DataSourceServiceClient>(MockBehavior.Strict);
            StartBigQueryJobsRequest request = new StartBigQueryJobsRequest();
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.StartBigQueryJobs(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            DataSourceServiceClient client = new DataSourceServiceClientImpl(mockGrpcClient.Object, null);
            client.StartBigQueryJobs(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task StartBigQueryJobsAsync()
        {
            Mock<DataSourceService.DataSourceServiceClient> mockGrpcClient = new Mock<DataSourceService.DataSourceServiceClient>(MockBehavior.Strict);
            StartBigQueryJobsRequest request = new StartBigQueryJobsRequest();
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.StartBigQueryJobsAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            DataSourceServiceClient client = new DataSourceServiceClientImpl(mockGrpcClient.Object, null);
            await client.StartBigQueryJobsAsync(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void FinishRun()
        {
            Mock<DataSourceService.DataSourceServiceClient> mockGrpcClient = new Mock<DataSourceService.DataSourceServiceClient>(MockBehavior.Strict);
            FinishRunRequest request = new FinishRunRequest();
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.FinishRun(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            DataSourceServiceClient client = new DataSourceServiceClientImpl(mockGrpcClient.Object, null);
            client.FinishRun(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task FinishRunAsync()
        {
            Mock<DataSourceService.DataSourceServiceClient> mockGrpcClient = new Mock<DataSourceService.DataSourceServiceClient>(MockBehavior.Strict);
            FinishRunRequest request = new FinishRunRequest();
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.FinishRunAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            DataSourceServiceClient client = new DataSourceServiceClientImpl(mockGrpcClient.Object, null);
            await client.FinishRunAsync(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateDataSourceDefinition()
        {
            Mock<DataSourceService.DataSourceServiceClient> mockGrpcClient = new Mock<DataSourceService.DataSourceServiceClient>(MockBehavior.Strict);
            CreateDataSourceDefinitionRequest request = new CreateDataSourceDefinitionRequest();
            DataSourceDefinition expectedResponse = new DataSourceDefinition
            {
                Name = "name3373707",
                TransferRunPubsubTopic = "transferRunPubsubTopic-1740562661",
                SupportEmail = "supportEmail-648030420",
                ServiceAccount = "serviceAccount-1948028253",
                Disabled = true,
                TransferConfigPubsubTopic = "transferConfigPubsubTopic71465884",
            };
            mockGrpcClient.Setup(x => x.CreateDataSourceDefinition(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            DataSourceServiceClient client = new DataSourceServiceClientImpl(mockGrpcClient.Object, null);
            DataSourceDefinition response = client.CreateDataSourceDefinition(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateDataSourceDefinitionAsync()
        {
            Mock<DataSourceService.DataSourceServiceClient> mockGrpcClient = new Mock<DataSourceService.DataSourceServiceClient>(MockBehavior.Strict);
            CreateDataSourceDefinitionRequest request = new CreateDataSourceDefinitionRequest();
            DataSourceDefinition expectedResponse = new DataSourceDefinition
            {
                Name = "name3373707",
                TransferRunPubsubTopic = "transferRunPubsubTopic-1740562661",
                SupportEmail = "supportEmail-648030420",
                ServiceAccount = "serviceAccount-1948028253",
                Disabled = true,
                TransferConfigPubsubTopic = "transferConfigPubsubTopic71465884",
            };
            mockGrpcClient.Setup(x => x.CreateDataSourceDefinitionAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<DataSourceDefinition>(Task.FromResult(expectedResponse), null, null, null, null));
            DataSourceServiceClient client = new DataSourceServiceClientImpl(mockGrpcClient.Object, null);
            DataSourceDefinition response = await client.CreateDataSourceDefinitionAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateDataSourceDefinition()
        {
            Mock<DataSourceService.DataSourceServiceClient> mockGrpcClient = new Mock<DataSourceService.DataSourceServiceClient>(MockBehavior.Strict);
            UpdateDataSourceDefinitionRequest request = new UpdateDataSourceDefinitionRequest();
            DataSourceDefinition expectedResponse = new DataSourceDefinition
            {
                Name = "name3373707",
                TransferRunPubsubTopic = "transferRunPubsubTopic-1740562661",
                SupportEmail = "supportEmail-648030420",
                ServiceAccount = "serviceAccount-1948028253",
                Disabled = true,
                TransferConfigPubsubTopic = "transferConfigPubsubTopic71465884",
            };
            mockGrpcClient.Setup(x => x.UpdateDataSourceDefinition(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            DataSourceServiceClient client = new DataSourceServiceClientImpl(mockGrpcClient.Object, null);
            DataSourceDefinition response = client.UpdateDataSourceDefinition(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task UpdateDataSourceDefinitionAsync()
        {
            Mock<DataSourceService.DataSourceServiceClient> mockGrpcClient = new Mock<DataSourceService.DataSourceServiceClient>(MockBehavior.Strict);
            UpdateDataSourceDefinitionRequest request = new UpdateDataSourceDefinitionRequest();
            DataSourceDefinition expectedResponse = new DataSourceDefinition
            {
                Name = "name3373707",
                TransferRunPubsubTopic = "transferRunPubsubTopic-1740562661",
                SupportEmail = "supportEmail-648030420",
                ServiceAccount = "serviceAccount-1948028253",
                Disabled = true,
                TransferConfigPubsubTopic = "transferConfigPubsubTopic71465884",
            };
            mockGrpcClient.Setup(x => x.UpdateDataSourceDefinitionAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<DataSourceDefinition>(Task.FromResult(expectedResponse), null, null, null, null));
            DataSourceServiceClient client = new DataSourceServiceClientImpl(mockGrpcClient.Object, null);
            DataSourceDefinition response = await client.UpdateDataSourceDefinitionAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteDataSourceDefinition()
        {
            Mock<DataSourceService.DataSourceServiceClient> mockGrpcClient = new Mock<DataSourceService.DataSourceServiceClient>(MockBehavior.Strict);
            DeleteDataSourceDefinitionRequest request = new DeleteDataSourceDefinitionRequest();
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteDataSourceDefinition(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            DataSourceServiceClient client = new DataSourceServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteDataSourceDefinition(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteDataSourceDefinitionAsync()
        {
            Mock<DataSourceService.DataSourceServiceClient> mockGrpcClient = new Mock<DataSourceService.DataSourceServiceClient>(MockBehavior.Strict);
            DeleteDataSourceDefinitionRequest request = new DeleteDataSourceDefinitionRequest();
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteDataSourceDefinitionAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            DataSourceServiceClient client = new DataSourceServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteDataSourceDefinitionAsync(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetDataSourceDefinition()
        {
            Mock<DataSourceService.DataSourceServiceClient> mockGrpcClient = new Mock<DataSourceService.DataSourceServiceClient>(MockBehavior.Strict);
            GetDataSourceDefinitionRequest request = new GetDataSourceDefinitionRequest();
            DataSourceDefinition expectedResponse = new DataSourceDefinition
            {
                Name = "name3373707",
                TransferRunPubsubTopic = "transferRunPubsubTopic-1740562661",
                SupportEmail = "supportEmail-648030420",
                ServiceAccount = "serviceAccount-1948028253",
                Disabled = true,
                TransferConfigPubsubTopic = "transferConfigPubsubTopic71465884",
            };
            mockGrpcClient.Setup(x => x.GetDataSourceDefinition(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            DataSourceServiceClient client = new DataSourceServiceClientImpl(mockGrpcClient.Object, null);
            DataSourceDefinition response = client.GetDataSourceDefinition(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetDataSourceDefinitionAsync()
        {
            Mock<DataSourceService.DataSourceServiceClient> mockGrpcClient = new Mock<DataSourceService.DataSourceServiceClient>(MockBehavior.Strict);
            GetDataSourceDefinitionRequest request = new GetDataSourceDefinitionRequest();
            DataSourceDefinition expectedResponse = new DataSourceDefinition
            {
                Name = "name3373707",
                TransferRunPubsubTopic = "transferRunPubsubTopic-1740562661",
                SupportEmail = "supportEmail-648030420",
                ServiceAccount = "serviceAccount-1948028253",
                Disabled = true,
                TransferConfigPubsubTopic = "transferConfigPubsubTopic71465884",
            };
            mockGrpcClient.Setup(x => x.GetDataSourceDefinitionAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<DataSourceDefinition>(Task.FromResult(expectedResponse), null, null, null, null));
            DataSourceServiceClient client = new DataSourceServiceClientImpl(mockGrpcClient.Object, null);
            DataSourceDefinition response = await client.GetDataSourceDefinitionAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}
