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

using Google.Api;
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

namespace Google.Cloud.Monitoring.V3.UnitTests
{
    /// <summary>Generated unit tests</summary>
    public class GeneratedMetricServiceClientTest
    {
        [Fact]
        public void GetMonitoredResourceDescriptorTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<MetricService.MetricServiceClient> mockGrpcClient = new Mock<MetricService.MetricServiceClient> { DefaultValue = DefaultValue.Mock };
            MonitoredResourceDescriptor expectedResponse = new MonitoredResourceDescriptor
            {
                Name = "name2-1052831874",
                Type = "type3575610",
                DisplayName = "displayName1615086568",
                Description = "description-1724546052",
            };
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.GetMonitoredResourceDescriptor(It.IsAny<GetMonitoredResourceDescriptorRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            MetricServiceClient client = new MetricServiceClientImpl(mockGrpcClient.Object, null);
            MonitoredResourceDescriptorName name = new MonitoredResourceDescriptorName("[PROJECT]", "[MONITORED_RESOURCE_DESCRIPTOR]");
            MonitoredResourceDescriptor response = client.GetMonitoredResourceDescriptor(name);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetMetricDescriptorTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<MetricService.MetricServiceClient> mockGrpcClient = new Mock<MetricService.MetricServiceClient> { DefaultValue = DefaultValue.Mock };
            MetricDescriptor expectedResponse = new MetricDescriptor
            {
                Name = "name2-1052831874",
                Type = "type3575610",
                Unit = "unit3594628",
                Description = "description-1724546052",
                DisplayName = "displayName1615086568",
            };
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.GetMetricDescriptor(It.IsAny<GetMetricDescriptorRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            MetricServiceClient client = new MetricServiceClientImpl(mockGrpcClient.Object, null);
            MetricDescriptorName name = new MetricDescriptorName("[PROJECT]", "[METRIC_DESCRIPTOR]");
            MetricDescriptor response = client.GetMetricDescriptor(name);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateMetricDescriptorTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<MetricService.MetricServiceClient> mockGrpcClient = new Mock<MetricService.MetricServiceClient> { DefaultValue = DefaultValue.Mock };
            MetricDescriptor expectedResponse = new MetricDescriptor
            {
                Name = "name2-1052831874",
                Type = "type3575610",
                Unit = "unit3594628",
                Description = "description-1724546052",
                DisplayName = "displayName1615086568",
            };
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.CreateMetricDescriptor(It.IsAny<CreateMetricDescriptorRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            MetricServiceClient client = new MetricServiceClientImpl(mockGrpcClient.Object, null);
            ProjectName name = new ProjectName("[PROJECT]");
            MetricDescriptor metricDescriptor = new MetricDescriptor();
            MetricDescriptor response = client.CreateMetricDescriptor(name, metricDescriptor);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteMetricDescriptorTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<MetricService.MetricServiceClient> mockGrpcClient = new Mock<MetricService.MetricServiceClient> { DefaultValue = DefaultValue.Mock };
            Empty expectedResponse = new Empty();
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.DeleteMetricDescriptor(It.IsAny<DeleteMetricDescriptorRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            MetricServiceClient client = new MetricServiceClientImpl(mockGrpcClient.Object, null);
            MetricDescriptorName name = new MetricDescriptorName("[PROJECT]", "[METRIC_DESCRIPTOR]");
            client.DeleteMetricDescriptor(name);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateTimeSeriesTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<MetricService.MetricServiceClient> mockGrpcClient = new Mock<MetricService.MetricServiceClient> { DefaultValue = DefaultValue.Mock };
            Empty expectedResponse = new Empty();
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.CreateTimeSeries(It.IsAny<CreateTimeSeriesRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            MetricServiceClient client = new MetricServiceClientImpl(mockGrpcClient.Object, null);
            ProjectName name = new ProjectName("[PROJECT]");
            IEnumerable<TimeSeries> timeSeries = new List<TimeSeries>();
            client.CreateTimeSeries(name, timeSeries);
            mockGrpcClient.VerifyAll();
        }

    }
}
