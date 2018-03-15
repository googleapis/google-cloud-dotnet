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

namespace Google.Cloud.Logging.V2.UnitTests
{
    /// <summary>Generated unit tests</summary>
    public class GeneratedMetricsServiceV2ClientTest
    {
        [Fact]
        public void GetLogMetricTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<MetricsServiceV2.MetricsServiceV2Client> mockGrpcClient = new Mock<MetricsServiceV2.MetricsServiceV2Client> { DefaultValue = DefaultValue.Mock };
            LogMetric expectedResponse = new LogMetric
            {
                Name = "name3373707",
                Description = "description-1724546052",
                Filter = "filter-1274492040",
                ValueExtractor = "valueExtractor2047672534",
            };
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.GetLogMetric(It.IsAny<GetLogMetricRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            MetricsServiceV2Client client = new MetricsServiceV2ClientImpl(mockGrpcClient.Object, null);
            MetricNameOneof metricName = MetricNameOneof.From(new MetricName("[PROJECT]", "[METRIC]"));
            LogMetric response = client.GetLogMetric(metricName);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateLogMetricTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<MetricsServiceV2.MetricsServiceV2Client> mockGrpcClient = new Mock<MetricsServiceV2.MetricsServiceV2Client> { DefaultValue = DefaultValue.Mock };
            LogMetric expectedResponse = new LogMetric
            {
                Name = "name3373707",
                Description = "description-1724546052",
                Filter = "filter-1274492040",
                ValueExtractor = "valueExtractor2047672534",
            };
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.CreateLogMetric(It.IsAny<CreateLogMetricRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            MetricsServiceV2Client client = new MetricsServiceV2ClientImpl(mockGrpcClient.Object, null);
            ParentNameOneof parent = ParentNameOneof.From(new ProjectName("[PROJECT]"));
            LogMetric metric = new LogMetric();
            LogMetric response = client.CreateLogMetric(parent, metric);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateLogMetricTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<MetricsServiceV2.MetricsServiceV2Client> mockGrpcClient = new Mock<MetricsServiceV2.MetricsServiceV2Client> { DefaultValue = DefaultValue.Mock };
            LogMetric expectedResponse = new LogMetric
            {
                Name = "name3373707",
                Description = "description-1724546052",
                Filter = "filter-1274492040",
                ValueExtractor = "valueExtractor2047672534",
            };
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.UpdateLogMetric(It.IsAny<UpdateLogMetricRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            MetricsServiceV2Client client = new MetricsServiceV2ClientImpl(mockGrpcClient.Object, null);
            MetricNameOneof metricName = MetricNameOneof.From(new MetricName("[PROJECT]", "[METRIC]"));
            LogMetric metric = new LogMetric();
            LogMetric response = client.UpdateLogMetric(metricName, metric);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteLogMetricTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<MetricsServiceV2.MetricsServiceV2Client> mockGrpcClient = new Mock<MetricsServiceV2.MetricsServiceV2Client> { DefaultValue = DefaultValue.Mock };
            Empty expectedResponse = new Empty();
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.DeleteLogMetric(It.IsAny<DeleteLogMetricRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            MetricsServiceV2Client client = new MetricsServiceV2ClientImpl(mockGrpcClient.Object, null);
            MetricNameOneof metricName = MetricNameOneof.From(new MetricName("[PROJECT]", "[METRIC]"));
            client.DeleteLogMetric(metricName);
            mockGrpcClient.VerifyAll();
        }

    }
}
