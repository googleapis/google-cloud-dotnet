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
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Analytics.Data.V1Beta.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedBetaAnalyticsDataClientTest
    {
        [xunit::FactAttribute]
        public void RunReportRequestObject()
        {
            moq::Mock<BetaAnalyticsData.BetaAnalyticsDataClient> mockGrpcClient = new moq::Mock<BetaAnalyticsData.BetaAnalyticsDataClient>(moq::MockBehavior.Strict);
            RunReportRequest request = new RunReportRequest
            {
                Property = "propertyc9b48d1a",
                Dimensions = { new Dimension(), },
                Metrics = { new Metric(), },
                DateRanges = { new DateRange(), },
                DimensionFilter = new FilterExpression(),
                MetricFilter = new FilterExpression(),
                Offset = -4389998161825790342L,
                Limit = 7494001492025909162L,
                MetricAggregations =
                {
                    MetricAggregation.Minimum,
                },
                OrderBys = { new OrderBy(), },
                CurrencyCode = "currency_code7f81e352",
                CohortSpec = new CohortSpec(),
                KeepEmptyRows = true,
                ReturnPropertyQuota = true,
            };
            RunReportResponse expectedResponse = new RunReportResponse
            {
                DimensionHeaders =
                {
                    new DimensionHeader(),
                },
                MetricHeaders = { new MetricHeader(), },
                Rows = { new Row(), },
                Totals = { new Row(), },
                Maximums = { new Row(), },
                Minimums = { new Row(), },
                RowCount = 743251772,
                Metadata = new ResponseMetaData(),
                PropertyQuota = new PropertyQuota(),
                Kind = "kindf7aa39d9",
            };
            mockGrpcClient.Setup(x => x.RunReport(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BetaAnalyticsDataClient client = new BetaAnalyticsDataClientImpl(mockGrpcClient.Object, null);
            RunReportResponse response = client.RunReport(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task RunReportRequestObjectAsync()
        {
            moq::Mock<BetaAnalyticsData.BetaAnalyticsDataClient> mockGrpcClient = new moq::Mock<BetaAnalyticsData.BetaAnalyticsDataClient>(moq::MockBehavior.Strict);
            RunReportRequest request = new RunReportRequest
            {
                Property = "propertyc9b48d1a",
                Dimensions = { new Dimension(), },
                Metrics = { new Metric(), },
                DateRanges = { new DateRange(), },
                DimensionFilter = new FilterExpression(),
                MetricFilter = new FilterExpression(),
                Offset = -4389998161825790342L,
                Limit = 7494001492025909162L,
                MetricAggregations =
                {
                    MetricAggregation.Minimum,
                },
                OrderBys = { new OrderBy(), },
                CurrencyCode = "currency_code7f81e352",
                CohortSpec = new CohortSpec(),
                KeepEmptyRows = true,
                ReturnPropertyQuota = true,
            };
            RunReportResponse expectedResponse = new RunReportResponse
            {
                DimensionHeaders =
                {
                    new DimensionHeader(),
                },
                MetricHeaders = { new MetricHeader(), },
                Rows = { new Row(), },
                Totals = { new Row(), },
                Maximums = { new Row(), },
                Minimums = { new Row(), },
                RowCount = 743251772,
                Metadata = new ResponseMetaData(),
                PropertyQuota = new PropertyQuota(),
                Kind = "kindf7aa39d9",
            };
            mockGrpcClient.Setup(x => x.RunReportAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<RunReportResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BetaAnalyticsDataClient client = new BetaAnalyticsDataClientImpl(mockGrpcClient.Object, null);
            RunReportResponse responseCallSettings = await client.RunReportAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            RunReportResponse responseCancellationToken = await client.RunReportAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void RunPivotReportRequestObject()
        {
            moq::Mock<BetaAnalyticsData.BetaAnalyticsDataClient> mockGrpcClient = new moq::Mock<BetaAnalyticsData.BetaAnalyticsDataClient>(moq::MockBehavior.Strict);
            RunPivotReportRequest request = new RunPivotReportRequest
            {
                Property = "propertyc9b48d1a",
                Dimensions = { new Dimension(), },
                Metrics = { new Metric(), },
                DateRanges = { new DateRange(), },
                Pivots = { new Pivot(), },
                DimensionFilter = new FilterExpression(),
                MetricFilter = new FilterExpression(),
                CurrencyCode = "currency_code7f81e352",
                CohortSpec = new CohortSpec(),
                KeepEmptyRows = true,
                ReturnPropertyQuota = true,
            };
            RunPivotReportResponse expectedResponse = new RunPivotReportResponse
            {
                PivotHeaders = { new PivotHeader(), },
                DimensionHeaders =
                {
                    new DimensionHeader(),
                },
                MetricHeaders = { new MetricHeader(), },
                Rows = { new Row(), },
                Aggregates = { new Row(), },
                Metadata = new ResponseMetaData(),
                PropertyQuota = new PropertyQuota(),
                Kind = "kindf7aa39d9",
            };
            mockGrpcClient.Setup(x => x.RunPivotReport(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BetaAnalyticsDataClient client = new BetaAnalyticsDataClientImpl(mockGrpcClient.Object, null);
            RunPivotReportResponse response = client.RunPivotReport(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task RunPivotReportRequestObjectAsync()
        {
            moq::Mock<BetaAnalyticsData.BetaAnalyticsDataClient> mockGrpcClient = new moq::Mock<BetaAnalyticsData.BetaAnalyticsDataClient>(moq::MockBehavior.Strict);
            RunPivotReportRequest request = new RunPivotReportRequest
            {
                Property = "propertyc9b48d1a",
                Dimensions = { new Dimension(), },
                Metrics = { new Metric(), },
                DateRanges = { new DateRange(), },
                Pivots = { new Pivot(), },
                DimensionFilter = new FilterExpression(),
                MetricFilter = new FilterExpression(),
                CurrencyCode = "currency_code7f81e352",
                CohortSpec = new CohortSpec(),
                KeepEmptyRows = true,
                ReturnPropertyQuota = true,
            };
            RunPivotReportResponse expectedResponse = new RunPivotReportResponse
            {
                PivotHeaders = { new PivotHeader(), },
                DimensionHeaders =
                {
                    new DimensionHeader(),
                },
                MetricHeaders = { new MetricHeader(), },
                Rows = { new Row(), },
                Aggregates = { new Row(), },
                Metadata = new ResponseMetaData(),
                PropertyQuota = new PropertyQuota(),
                Kind = "kindf7aa39d9",
            };
            mockGrpcClient.Setup(x => x.RunPivotReportAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<RunPivotReportResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BetaAnalyticsDataClient client = new BetaAnalyticsDataClientImpl(mockGrpcClient.Object, null);
            RunPivotReportResponse responseCallSettings = await client.RunPivotReportAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            RunPivotReportResponse responseCancellationToken = await client.RunPivotReportAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void BatchRunReportsRequestObject()
        {
            moq::Mock<BetaAnalyticsData.BetaAnalyticsDataClient> mockGrpcClient = new moq::Mock<BetaAnalyticsData.BetaAnalyticsDataClient>(moq::MockBehavior.Strict);
            BatchRunReportsRequest request = new BatchRunReportsRequest
            {
                Property = "propertyc9b48d1a",
                Requests =
                {
                    new RunReportRequest(),
                },
            };
            BatchRunReportsResponse expectedResponse = new BatchRunReportsResponse
            {
                Reports =
                {
                    new RunReportResponse(),
                },
                Kind = "kindf7aa39d9",
            };
            mockGrpcClient.Setup(x => x.BatchRunReports(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BetaAnalyticsDataClient client = new BetaAnalyticsDataClientImpl(mockGrpcClient.Object, null);
            BatchRunReportsResponse response = client.BatchRunReports(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task BatchRunReportsRequestObjectAsync()
        {
            moq::Mock<BetaAnalyticsData.BetaAnalyticsDataClient> mockGrpcClient = new moq::Mock<BetaAnalyticsData.BetaAnalyticsDataClient>(moq::MockBehavior.Strict);
            BatchRunReportsRequest request = new BatchRunReportsRequest
            {
                Property = "propertyc9b48d1a",
                Requests =
                {
                    new RunReportRequest(),
                },
            };
            BatchRunReportsResponse expectedResponse = new BatchRunReportsResponse
            {
                Reports =
                {
                    new RunReportResponse(),
                },
                Kind = "kindf7aa39d9",
            };
            mockGrpcClient.Setup(x => x.BatchRunReportsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<BatchRunReportsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BetaAnalyticsDataClient client = new BetaAnalyticsDataClientImpl(mockGrpcClient.Object, null);
            BatchRunReportsResponse responseCallSettings = await client.BatchRunReportsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            BatchRunReportsResponse responseCancellationToken = await client.BatchRunReportsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void BatchRunPivotReportsRequestObject()
        {
            moq::Mock<BetaAnalyticsData.BetaAnalyticsDataClient> mockGrpcClient = new moq::Mock<BetaAnalyticsData.BetaAnalyticsDataClient>(moq::MockBehavior.Strict);
            BatchRunPivotReportsRequest request = new BatchRunPivotReportsRequest
            {
                Property = "propertyc9b48d1a",
                Requests =
                {
                    new RunPivotReportRequest(),
                },
            };
            BatchRunPivotReportsResponse expectedResponse = new BatchRunPivotReportsResponse
            {
                PivotReports =
                {
                    new RunPivotReportResponse(),
                },
                Kind = "kindf7aa39d9",
            };
            mockGrpcClient.Setup(x => x.BatchRunPivotReports(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BetaAnalyticsDataClient client = new BetaAnalyticsDataClientImpl(mockGrpcClient.Object, null);
            BatchRunPivotReportsResponse response = client.BatchRunPivotReports(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task BatchRunPivotReportsRequestObjectAsync()
        {
            moq::Mock<BetaAnalyticsData.BetaAnalyticsDataClient> mockGrpcClient = new moq::Mock<BetaAnalyticsData.BetaAnalyticsDataClient>(moq::MockBehavior.Strict);
            BatchRunPivotReportsRequest request = new BatchRunPivotReportsRequest
            {
                Property = "propertyc9b48d1a",
                Requests =
                {
                    new RunPivotReportRequest(),
                },
            };
            BatchRunPivotReportsResponse expectedResponse = new BatchRunPivotReportsResponse
            {
                PivotReports =
                {
                    new RunPivotReportResponse(),
                },
                Kind = "kindf7aa39d9",
            };
            mockGrpcClient.Setup(x => x.BatchRunPivotReportsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<BatchRunPivotReportsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BetaAnalyticsDataClient client = new BetaAnalyticsDataClientImpl(mockGrpcClient.Object, null);
            BatchRunPivotReportsResponse responseCallSettings = await client.BatchRunPivotReportsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            BatchRunPivotReportsResponse responseCancellationToken = await client.BatchRunPivotReportsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetMetadataRequestObject()
        {
            moq::Mock<BetaAnalyticsData.BetaAnalyticsDataClient> mockGrpcClient = new moq::Mock<BetaAnalyticsData.BetaAnalyticsDataClient>(moq::MockBehavior.Strict);
            GetMetadataRequest request = new GetMetadataRequest
            {
                MetadataName = MetadataName.FromProperty("[PROPERTY]"),
            };
            Metadata expectedResponse = new Metadata
            {
                Dimensions =
                {
                    new DimensionMetadata(),
                },
                Metrics =
                {
                    new MetricMetadata(),
                },
                MetadataName = MetadataName.FromProperty("[PROPERTY]"),
            };
            mockGrpcClient.Setup(x => x.GetMetadata(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BetaAnalyticsDataClient client = new BetaAnalyticsDataClientImpl(mockGrpcClient.Object, null);
            Metadata response = client.GetMetadata(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetMetadataRequestObjectAsync()
        {
            moq::Mock<BetaAnalyticsData.BetaAnalyticsDataClient> mockGrpcClient = new moq::Mock<BetaAnalyticsData.BetaAnalyticsDataClient>(moq::MockBehavior.Strict);
            GetMetadataRequest request = new GetMetadataRequest
            {
                MetadataName = MetadataName.FromProperty("[PROPERTY]"),
            };
            Metadata expectedResponse = new Metadata
            {
                Dimensions =
                {
                    new DimensionMetadata(),
                },
                Metrics =
                {
                    new MetricMetadata(),
                },
                MetadataName = MetadataName.FromProperty("[PROPERTY]"),
            };
            mockGrpcClient.Setup(x => x.GetMetadataAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Metadata>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BetaAnalyticsDataClient client = new BetaAnalyticsDataClientImpl(mockGrpcClient.Object, null);
            Metadata responseCallSettings = await client.GetMetadataAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Metadata responseCancellationToken = await client.GetMetadataAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetMetadata()
        {
            moq::Mock<BetaAnalyticsData.BetaAnalyticsDataClient> mockGrpcClient = new moq::Mock<BetaAnalyticsData.BetaAnalyticsDataClient>(moq::MockBehavior.Strict);
            GetMetadataRequest request = new GetMetadataRequest
            {
                MetadataName = MetadataName.FromProperty("[PROPERTY]"),
            };
            Metadata expectedResponse = new Metadata
            {
                Dimensions =
                {
                    new DimensionMetadata(),
                },
                Metrics =
                {
                    new MetricMetadata(),
                },
                MetadataName = MetadataName.FromProperty("[PROPERTY]"),
            };
            mockGrpcClient.Setup(x => x.GetMetadata(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BetaAnalyticsDataClient client = new BetaAnalyticsDataClientImpl(mockGrpcClient.Object, null);
            Metadata response = client.GetMetadata(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetMetadataAsync()
        {
            moq::Mock<BetaAnalyticsData.BetaAnalyticsDataClient> mockGrpcClient = new moq::Mock<BetaAnalyticsData.BetaAnalyticsDataClient>(moq::MockBehavior.Strict);
            GetMetadataRequest request = new GetMetadataRequest
            {
                MetadataName = MetadataName.FromProperty("[PROPERTY]"),
            };
            Metadata expectedResponse = new Metadata
            {
                Dimensions =
                {
                    new DimensionMetadata(),
                },
                Metrics =
                {
                    new MetricMetadata(),
                },
                MetadataName = MetadataName.FromProperty("[PROPERTY]"),
            };
            mockGrpcClient.Setup(x => x.GetMetadataAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Metadata>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BetaAnalyticsDataClient client = new BetaAnalyticsDataClientImpl(mockGrpcClient.Object, null);
            Metadata responseCallSettings = await client.GetMetadataAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Metadata responseCancellationToken = await client.GetMetadataAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetMetadataResourceNames()
        {
            moq::Mock<BetaAnalyticsData.BetaAnalyticsDataClient> mockGrpcClient = new moq::Mock<BetaAnalyticsData.BetaAnalyticsDataClient>(moq::MockBehavior.Strict);
            GetMetadataRequest request = new GetMetadataRequest
            {
                MetadataName = MetadataName.FromProperty("[PROPERTY]"),
            };
            Metadata expectedResponse = new Metadata
            {
                Dimensions =
                {
                    new DimensionMetadata(),
                },
                Metrics =
                {
                    new MetricMetadata(),
                },
                MetadataName = MetadataName.FromProperty("[PROPERTY]"),
            };
            mockGrpcClient.Setup(x => x.GetMetadata(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BetaAnalyticsDataClient client = new BetaAnalyticsDataClientImpl(mockGrpcClient.Object, null);
            Metadata response = client.GetMetadata(request.MetadataName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetMetadataResourceNamesAsync()
        {
            moq::Mock<BetaAnalyticsData.BetaAnalyticsDataClient> mockGrpcClient = new moq::Mock<BetaAnalyticsData.BetaAnalyticsDataClient>(moq::MockBehavior.Strict);
            GetMetadataRequest request = new GetMetadataRequest
            {
                MetadataName = MetadataName.FromProperty("[PROPERTY]"),
            };
            Metadata expectedResponse = new Metadata
            {
                Dimensions =
                {
                    new DimensionMetadata(),
                },
                Metrics =
                {
                    new MetricMetadata(),
                },
                MetadataName = MetadataName.FromProperty("[PROPERTY]"),
            };
            mockGrpcClient.Setup(x => x.GetMetadataAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Metadata>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BetaAnalyticsDataClient client = new BetaAnalyticsDataClientImpl(mockGrpcClient.Object, null);
            Metadata responseCallSettings = await client.GetMetadataAsync(request.MetadataName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Metadata responseCancellationToken = await client.GetMetadataAsync(request.MetadataName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void RunRealtimeReportRequestObject()
        {
            moq::Mock<BetaAnalyticsData.BetaAnalyticsDataClient> mockGrpcClient = new moq::Mock<BetaAnalyticsData.BetaAnalyticsDataClient>(moq::MockBehavior.Strict);
            RunRealtimeReportRequest request = new RunRealtimeReportRequest
            {
                Property = "propertyc9b48d1a",
                Dimensions = { new Dimension(), },
                Metrics = { new Metric(), },
                DimensionFilter = new FilterExpression(),
                MetricFilter = new FilterExpression(),
                Limit = 7494001492025909162L,
                MetricAggregations =
                {
                    MetricAggregation.Minimum,
                },
                OrderBys = { new OrderBy(), },
                ReturnPropertyQuota = true,
                MinuteRanges = { new MinuteRange(), },
            };
            RunRealtimeReportResponse expectedResponse = new RunRealtimeReportResponse
            {
                DimensionHeaders =
                {
                    new DimensionHeader(),
                },
                MetricHeaders = { new MetricHeader(), },
                Rows = { new Row(), },
                Totals = { new Row(), },
                Maximums = { new Row(), },
                Minimums = { new Row(), },
                RowCount = 743251772,
                PropertyQuota = new PropertyQuota(),
                Kind = "kindf7aa39d9",
            };
            mockGrpcClient.Setup(x => x.RunRealtimeReport(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BetaAnalyticsDataClient client = new BetaAnalyticsDataClientImpl(mockGrpcClient.Object, null);
            RunRealtimeReportResponse response = client.RunRealtimeReport(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task RunRealtimeReportRequestObjectAsync()
        {
            moq::Mock<BetaAnalyticsData.BetaAnalyticsDataClient> mockGrpcClient = new moq::Mock<BetaAnalyticsData.BetaAnalyticsDataClient>(moq::MockBehavior.Strict);
            RunRealtimeReportRequest request = new RunRealtimeReportRequest
            {
                Property = "propertyc9b48d1a",
                Dimensions = { new Dimension(), },
                Metrics = { new Metric(), },
                DimensionFilter = new FilterExpression(),
                MetricFilter = new FilterExpression(),
                Limit = 7494001492025909162L,
                MetricAggregations =
                {
                    MetricAggregation.Minimum,
                },
                OrderBys = { new OrderBy(), },
                ReturnPropertyQuota = true,
                MinuteRanges = { new MinuteRange(), },
            };
            RunRealtimeReportResponse expectedResponse = new RunRealtimeReportResponse
            {
                DimensionHeaders =
                {
                    new DimensionHeader(),
                },
                MetricHeaders = { new MetricHeader(), },
                Rows = { new Row(), },
                Totals = { new Row(), },
                Maximums = { new Row(), },
                Minimums = { new Row(), },
                RowCount = 743251772,
                PropertyQuota = new PropertyQuota(),
                Kind = "kindf7aa39d9",
            };
            mockGrpcClient.Setup(x => x.RunRealtimeReportAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<RunRealtimeReportResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BetaAnalyticsDataClient client = new BetaAnalyticsDataClientImpl(mockGrpcClient.Object, null);
            RunRealtimeReportResponse responseCallSettings = await client.RunRealtimeReportAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            RunRealtimeReportResponse responseCancellationToken = await client.RunRealtimeReportAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CheckCompatibilityRequestObject()
        {
            moq::Mock<BetaAnalyticsData.BetaAnalyticsDataClient> mockGrpcClient = new moq::Mock<BetaAnalyticsData.BetaAnalyticsDataClient>(moq::MockBehavior.Strict);
            CheckCompatibilityRequest request = new CheckCompatibilityRequest
            {
                Property = "propertyc9b48d1a",
                Dimensions = { new Dimension(), },
                Metrics = { new Metric(), },
                DimensionFilter = new FilterExpression(),
                MetricFilter = new FilterExpression(),
                CompatibilityFilter = Compatibility.Incompatible,
            };
            CheckCompatibilityResponse expectedResponse = new CheckCompatibilityResponse
            {
                DimensionCompatibilities =
                {
                    new DimensionCompatibility(),
                },
                MetricCompatibilities =
                {
                    new MetricCompatibility(),
                },
            };
            mockGrpcClient.Setup(x => x.CheckCompatibility(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BetaAnalyticsDataClient client = new BetaAnalyticsDataClientImpl(mockGrpcClient.Object, null);
            CheckCompatibilityResponse response = client.CheckCompatibility(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CheckCompatibilityRequestObjectAsync()
        {
            moq::Mock<BetaAnalyticsData.BetaAnalyticsDataClient> mockGrpcClient = new moq::Mock<BetaAnalyticsData.BetaAnalyticsDataClient>(moq::MockBehavior.Strict);
            CheckCompatibilityRequest request = new CheckCompatibilityRequest
            {
                Property = "propertyc9b48d1a",
                Dimensions = { new Dimension(), },
                Metrics = { new Metric(), },
                DimensionFilter = new FilterExpression(),
                MetricFilter = new FilterExpression(),
                CompatibilityFilter = Compatibility.Incompatible,
            };
            CheckCompatibilityResponse expectedResponse = new CheckCompatibilityResponse
            {
                DimensionCompatibilities =
                {
                    new DimensionCompatibility(),
                },
                MetricCompatibilities =
                {
                    new MetricCompatibility(),
                },
            };
            mockGrpcClient.Setup(x => x.CheckCompatibilityAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CheckCompatibilityResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BetaAnalyticsDataClient client = new BetaAnalyticsDataClientImpl(mockGrpcClient.Object, null);
            CheckCompatibilityResponse responseCallSettings = await client.CheckCompatibilityAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CheckCompatibilityResponse responseCancellationToken = await client.CheckCompatibilityAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
