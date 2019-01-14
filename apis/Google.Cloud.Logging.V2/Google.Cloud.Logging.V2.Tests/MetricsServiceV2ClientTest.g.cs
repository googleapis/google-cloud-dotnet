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

namespace Google.Cloud.Logging.V2.Tests
{
    using Google.Api.Gax;
    using Google.Api.Gax.Grpc;
    using apis = Google.Cloud.Logging.V2;
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
    public class GeneratedMetricsServiceV2ClientTest
    {
        [Fact]
        public void GetLogMetric()
        {
            Mock<MetricsServiceV2.MetricsServiceV2Client> mockGrpcClient = new Mock<MetricsServiceV2.MetricsServiceV2Client>(MockBehavior.Strict);
            GetLogMetricRequest expectedRequest = new GetLogMetricRequest
            {
                MetricNameAsMetricNameOneof = MetricNameOneof.From(new MetricName("[PROJECT]", "[METRIC]")),
            };
            LogMetric expectedResponse = new LogMetric
            {
                MetricNameOneof = MetricNameOneof.From(new MetricName("[PROJECT]", "[METRIC]")),
                Description = "description-1724546052",
                Filter = "filter-1274492040",
                ValueExtractor = "valueExtractor2047672534",
            };
            mockGrpcClient.Setup(x => x.GetLogMetric(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            MetricsServiceV2Client client = new MetricsServiceV2ClientImpl(mockGrpcClient.Object, null);
            MetricNameOneof metricName = MetricNameOneof.From(new MetricName("[PROJECT]", "[METRIC]"));
            LogMetric response = client.GetLogMetric(metricName);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetLogMetricAsync()
        {
            Mock<MetricsServiceV2.MetricsServiceV2Client> mockGrpcClient = new Mock<MetricsServiceV2.MetricsServiceV2Client>(MockBehavior.Strict);
            GetLogMetricRequest expectedRequest = new GetLogMetricRequest
            {
                MetricNameAsMetricNameOneof = MetricNameOneof.From(new MetricName("[PROJECT]", "[METRIC]")),
            };
            LogMetric expectedResponse = new LogMetric
            {
                MetricNameOneof = MetricNameOneof.From(new MetricName("[PROJECT]", "[METRIC]")),
                Description = "description-1724546052",
                Filter = "filter-1274492040",
                ValueExtractor = "valueExtractor2047672534",
            };
            mockGrpcClient.Setup(x => x.GetLogMetricAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<LogMetric>(Task.FromResult(expectedResponse), null, null, null, null));
            MetricsServiceV2Client client = new MetricsServiceV2ClientImpl(mockGrpcClient.Object, null);
            MetricNameOneof metricName = MetricNameOneof.From(new MetricName("[PROJECT]", "[METRIC]"));
            LogMetric response = await client.GetLogMetricAsync(metricName);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetLogMetric2()
        {
            Mock<MetricsServiceV2.MetricsServiceV2Client> mockGrpcClient = new Mock<MetricsServiceV2.MetricsServiceV2Client>(MockBehavior.Strict);
            GetLogMetricRequest request = new GetLogMetricRequest
            {
                MetricNameAsMetricNameOneof = MetricNameOneof.From(new MetricName("[PROJECT]", "[METRIC]")),
            };
            LogMetric expectedResponse = new LogMetric
            {
                MetricNameOneof = MetricNameOneof.From(new MetricName("[PROJECT]", "[METRIC]")),
                Description = "description-1724546052",
                Filter = "filter-1274492040",
                ValueExtractor = "valueExtractor2047672534",
            };
            mockGrpcClient.Setup(x => x.GetLogMetric(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            MetricsServiceV2Client client = new MetricsServiceV2ClientImpl(mockGrpcClient.Object, null);
            LogMetric response = client.GetLogMetric(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetLogMetricAsync2()
        {
            Mock<MetricsServiceV2.MetricsServiceV2Client> mockGrpcClient = new Mock<MetricsServiceV2.MetricsServiceV2Client>(MockBehavior.Strict);
            GetLogMetricRequest request = new GetLogMetricRequest
            {
                MetricNameAsMetricNameOneof = MetricNameOneof.From(new MetricName("[PROJECT]", "[METRIC]")),
            };
            LogMetric expectedResponse = new LogMetric
            {
                MetricNameOneof = MetricNameOneof.From(new MetricName("[PROJECT]", "[METRIC]")),
                Description = "description-1724546052",
                Filter = "filter-1274492040",
                ValueExtractor = "valueExtractor2047672534",
            };
            mockGrpcClient.Setup(x => x.GetLogMetricAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<LogMetric>(Task.FromResult(expectedResponse), null, null, null, null));
            MetricsServiceV2Client client = new MetricsServiceV2ClientImpl(mockGrpcClient.Object, null);
            LogMetric response = await client.GetLogMetricAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateLogMetric()
        {
            Mock<MetricsServiceV2.MetricsServiceV2Client> mockGrpcClient = new Mock<MetricsServiceV2.MetricsServiceV2Client>(MockBehavior.Strict);
            CreateLogMetricRequest expectedRequest = new CreateLogMetricRequest
            {
                ParentAsParentNameOneof = ParentNameOneof.From(new ProjectName("[PROJECT]")),
                Metric = new LogMetric(),
            };
            LogMetric expectedResponse = new LogMetric
            {
                MetricNameOneof = MetricNameOneof.From(new MetricName("[PROJECT]", "[METRIC]")),
                Description = "description-1724546052",
                Filter = "filter-1274492040",
                ValueExtractor = "valueExtractor2047672534",
            };
            mockGrpcClient.Setup(x => x.CreateLogMetric(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            MetricsServiceV2Client client = new MetricsServiceV2ClientImpl(mockGrpcClient.Object, null);
            ParentNameOneof parent = ParentNameOneof.From(new ProjectName("[PROJECT]"));
            LogMetric metric = new LogMetric();
            LogMetric response = client.CreateLogMetric(parent, metric);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateLogMetricAsync()
        {
            Mock<MetricsServiceV2.MetricsServiceV2Client> mockGrpcClient = new Mock<MetricsServiceV2.MetricsServiceV2Client>(MockBehavior.Strict);
            CreateLogMetricRequest expectedRequest = new CreateLogMetricRequest
            {
                ParentAsParentNameOneof = ParentNameOneof.From(new ProjectName("[PROJECT]")),
                Metric = new LogMetric(),
            };
            LogMetric expectedResponse = new LogMetric
            {
                MetricNameOneof = MetricNameOneof.From(new MetricName("[PROJECT]", "[METRIC]")),
                Description = "description-1724546052",
                Filter = "filter-1274492040",
                ValueExtractor = "valueExtractor2047672534",
            };
            mockGrpcClient.Setup(x => x.CreateLogMetricAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<LogMetric>(Task.FromResult(expectedResponse), null, null, null, null));
            MetricsServiceV2Client client = new MetricsServiceV2ClientImpl(mockGrpcClient.Object, null);
            ParentNameOneof parent = ParentNameOneof.From(new ProjectName("[PROJECT]"));
            LogMetric metric = new LogMetric();
            LogMetric response = await client.CreateLogMetricAsync(parent, metric);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateLogMetric2()
        {
            Mock<MetricsServiceV2.MetricsServiceV2Client> mockGrpcClient = new Mock<MetricsServiceV2.MetricsServiceV2Client>(MockBehavior.Strict);
            CreateLogMetricRequest request = new CreateLogMetricRequest
            {
                ParentAsParentNameOneof = ParentNameOneof.From(new ProjectName("[PROJECT]")),
                Metric = new LogMetric(),
            };
            LogMetric expectedResponse = new LogMetric
            {
                MetricNameOneof = MetricNameOneof.From(new MetricName("[PROJECT]", "[METRIC]")),
                Description = "description-1724546052",
                Filter = "filter-1274492040",
                ValueExtractor = "valueExtractor2047672534",
            };
            mockGrpcClient.Setup(x => x.CreateLogMetric(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            MetricsServiceV2Client client = new MetricsServiceV2ClientImpl(mockGrpcClient.Object, null);
            LogMetric response = client.CreateLogMetric(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateLogMetricAsync2()
        {
            Mock<MetricsServiceV2.MetricsServiceV2Client> mockGrpcClient = new Mock<MetricsServiceV2.MetricsServiceV2Client>(MockBehavior.Strict);
            CreateLogMetricRequest request = new CreateLogMetricRequest
            {
                ParentAsParentNameOneof = ParentNameOneof.From(new ProjectName("[PROJECT]")),
                Metric = new LogMetric(),
            };
            LogMetric expectedResponse = new LogMetric
            {
                MetricNameOneof = MetricNameOneof.From(new MetricName("[PROJECT]", "[METRIC]")),
                Description = "description-1724546052",
                Filter = "filter-1274492040",
                ValueExtractor = "valueExtractor2047672534",
            };
            mockGrpcClient.Setup(x => x.CreateLogMetricAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<LogMetric>(Task.FromResult(expectedResponse), null, null, null, null));
            MetricsServiceV2Client client = new MetricsServiceV2ClientImpl(mockGrpcClient.Object, null);
            LogMetric response = await client.CreateLogMetricAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateLogMetric()
        {
            Mock<MetricsServiceV2.MetricsServiceV2Client> mockGrpcClient = new Mock<MetricsServiceV2.MetricsServiceV2Client>(MockBehavior.Strict);
            UpdateLogMetricRequest expectedRequest = new UpdateLogMetricRequest
            {
                MetricNameAsMetricNameOneof = MetricNameOneof.From(new MetricName("[PROJECT]", "[METRIC]")),
                Metric = new LogMetric(),
            };
            LogMetric expectedResponse = new LogMetric
            {
                MetricNameOneof = MetricNameOneof.From(new MetricName("[PROJECT]", "[METRIC]")),
                Description = "description-1724546052",
                Filter = "filter-1274492040",
                ValueExtractor = "valueExtractor2047672534",
            };
            mockGrpcClient.Setup(x => x.UpdateLogMetric(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            MetricsServiceV2Client client = new MetricsServiceV2ClientImpl(mockGrpcClient.Object, null);
            MetricNameOneof metricName = MetricNameOneof.From(new MetricName("[PROJECT]", "[METRIC]"));
            LogMetric metric = new LogMetric();
            LogMetric response = client.UpdateLogMetric(metricName, metric);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task UpdateLogMetricAsync()
        {
            Mock<MetricsServiceV2.MetricsServiceV2Client> mockGrpcClient = new Mock<MetricsServiceV2.MetricsServiceV2Client>(MockBehavior.Strict);
            UpdateLogMetricRequest expectedRequest = new UpdateLogMetricRequest
            {
                MetricNameAsMetricNameOneof = MetricNameOneof.From(new MetricName("[PROJECT]", "[METRIC]")),
                Metric = new LogMetric(),
            };
            LogMetric expectedResponse = new LogMetric
            {
                MetricNameOneof = MetricNameOneof.From(new MetricName("[PROJECT]", "[METRIC]")),
                Description = "description-1724546052",
                Filter = "filter-1274492040",
                ValueExtractor = "valueExtractor2047672534",
            };
            mockGrpcClient.Setup(x => x.UpdateLogMetricAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<LogMetric>(Task.FromResult(expectedResponse), null, null, null, null));
            MetricsServiceV2Client client = new MetricsServiceV2ClientImpl(mockGrpcClient.Object, null);
            MetricNameOneof metricName = MetricNameOneof.From(new MetricName("[PROJECT]", "[METRIC]"));
            LogMetric metric = new LogMetric();
            LogMetric response = await client.UpdateLogMetricAsync(metricName, metric);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateLogMetric2()
        {
            Mock<MetricsServiceV2.MetricsServiceV2Client> mockGrpcClient = new Mock<MetricsServiceV2.MetricsServiceV2Client>(MockBehavior.Strict);
            UpdateLogMetricRequest request = new UpdateLogMetricRequest
            {
                MetricNameAsMetricNameOneof = MetricNameOneof.From(new MetricName("[PROJECT]", "[METRIC]")),
                Metric = new LogMetric(),
            };
            LogMetric expectedResponse = new LogMetric
            {
                MetricNameOneof = MetricNameOneof.From(new MetricName("[PROJECT]", "[METRIC]")),
                Description = "description-1724546052",
                Filter = "filter-1274492040",
                ValueExtractor = "valueExtractor2047672534",
            };
            mockGrpcClient.Setup(x => x.UpdateLogMetric(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            MetricsServiceV2Client client = new MetricsServiceV2ClientImpl(mockGrpcClient.Object, null);
            LogMetric response = client.UpdateLogMetric(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task UpdateLogMetricAsync2()
        {
            Mock<MetricsServiceV2.MetricsServiceV2Client> mockGrpcClient = new Mock<MetricsServiceV2.MetricsServiceV2Client>(MockBehavior.Strict);
            UpdateLogMetricRequest request = new UpdateLogMetricRequest
            {
                MetricNameAsMetricNameOneof = MetricNameOneof.From(new MetricName("[PROJECT]", "[METRIC]")),
                Metric = new LogMetric(),
            };
            LogMetric expectedResponse = new LogMetric
            {
                MetricNameOneof = MetricNameOneof.From(new MetricName("[PROJECT]", "[METRIC]")),
                Description = "description-1724546052",
                Filter = "filter-1274492040",
                ValueExtractor = "valueExtractor2047672534",
            };
            mockGrpcClient.Setup(x => x.UpdateLogMetricAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<LogMetric>(Task.FromResult(expectedResponse), null, null, null, null));
            MetricsServiceV2Client client = new MetricsServiceV2ClientImpl(mockGrpcClient.Object, null);
            LogMetric response = await client.UpdateLogMetricAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteLogMetric()
        {
            Mock<MetricsServiceV2.MetricsServiceV2Client> mockGrpcClient = new Mock<MetricsServiceV2.MetricsServiceV2Client>(MockBehavior.Strict);
            DeleteLogMetricRequest expectedRequest = new DeleteLogMetricRequest
            {
                MetricNameAsMetricNameOneof = MetricNameOneof.From(new MetricName("[PROJECT]", "[METRIC]")),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteLogMetric(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            MetricsServiceV2Client client = new MetricsServiceV2ClientImpl(mockGrpcClient.Object, null);
            MetricNameOneof metricName = MetricNameOneof.From(new MetricName("[PROJECT]", "[METRIC]"));
            client.DeleteLogMetric(metricName);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteLogMetricAsync()
        {
            Mock<MetricsServiceV2.MetricsServiceV2Client> mockGrpcClient = new Mock<MetricsServiceV2.MetricsServiceV2Client>(MockBehavior.Strict);
            DeleteLogMetricRequest expectedRequest = new DeleteLogMetricRequest
            {
                MetricNameAsMetricNameOneof = MetricNameOneof.From(new MetricName("[PROJECT]", "[METRIC]")),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteLogMetricAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            MetricsServiceV2Client client = new MetricsServiceV2ClientImpl(mockGrpcClient.Object, null);
            MetricNameOneof metricName = MetricNameOneof.From(new MetricName("[PROJECT]", "[METRIC]"));
            await client.DeleteLogMetricAsync(metricName);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteLogMetric2()
        {
            Mock<MetricsServiceV2.MetricsServiceV2Client> mockGrpcClient = new Mock<MetricsServiceV2.MetricsServiceV2Client>(MockBehavior.Strict);
            DeleteLogMetricRequest request = new DeleteLogMetricRequest
            {
                MetricNameAsMetricNameOneof = MetricNameOneof.From(new MetricName("[PROJECT]", "[METRIC]")),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteLogMetric(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            MetricsServiceV2Client client = new MetricsServiceV2ClientImpl(mockGrpcClient.Object, null);
            client.DeleteLogMetric(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteLogMetricAsync2()
        {
            Mock<MetricsServiceV2.MetricsServiceV2Client> mockGrpcClient = new Mock<MetricsServiceV2.MetricsServiceV2Client>(MockBehavior.Strict);
            DeleteLogMetricRequest request = new DeleteLogMetricRequest
            {
                MetricNameAsMetricNameOneof = MetricNameOneof.From(new MetricName("[PROJECT]", "[METRIC]")),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteLogMetricAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            MetricsServiceV2Client client = new MetricsServiceV2ClientImpl(mockGrpcClient.Object, null);
            await client.DeleteLogMetricAsync(request);
            mockGrpcClient.VerifyAll();
        }

    }
}
