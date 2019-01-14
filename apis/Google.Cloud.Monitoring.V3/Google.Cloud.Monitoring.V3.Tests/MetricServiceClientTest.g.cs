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

namespace Google.Cloud.Monitoring.V3.Tests
{
    using Google.Api;
    using Google.Api.Gax;
    using Google.Api.Gax.Grpc;
    using apis = Google.Cloud.Monitoring.V3;
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
    public class GeneratedMetricServiceClientTest
    {
        [Fact]
        public void GetMonitoredResourceDescriptor()
        {
            Mock<MetricService.MetricServiceClient> mockGrpcClient = new Mock<MetricService.MetricServiceClient>(MockBehavior.Strict);
            GetMonitoredResourceDescriptorRequest expectedRequest = new GetMonitoredResourceDescriptorRequest
            {
                MonitoredResourceDescriptorName = new MonitoredResourceDescriptorName("[PROJECT]", "[MONITORED_RESOURCE_DESCRIPTOR]"),
            };
            MonitoredResourceDescriptor expectedResponse = new MonitoredResourceDescriptor
            {
                Name = "name2-1052831874",
                Type = "type3575610",
                DisplayName = "displayName1615086568",
                Description = "description-1724546052",
            };
            mockGrpcClient.Setup(x => x.GetMonitoredResourceDescriptor(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            MetricServiceClient client = new MetricServiceClientImpl(mockGrpcClient.Object, null);
            MonitoredResourceDescriptorName name = new MonitoredResourceDescriptorName("[PROJECT]", "[MONITORED_RESOURCE_DESCRIPTOR]");
            MonitoredResourceDescriptor response = client.GetMonitoredResourceDescriptor(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetMonitoredResourceDescriptorAsync()
        {
            Mock<MetricService.MetricServiceClient> mockGrpcClient = new Mock<MetricService.MetricServiceClient>(MockBehavior.Strict);
            GetMonitoredResourceDescriptorRequest expectedRequest = new GetMonitoredResourceDescriptorRequest
            {
                MonitoredResourceDescriptorName = new MonitoredResourceDescriptorName("[PROJECT]", "[MONITORED_RESOURCE_DESCRIPTOR]"),
            };
            MonitoredResourceDescriptor expectedResponse = new MonitoredResourceDescriptor
            {
                Name = "name2-1052831874",
                Type = "type3575610",
                DisplayName = "displayName1615086568",
                Description = "description-1724546052",
            };
            mockGrpcClient.Setup(x => x.GetMonitoredResourceDescriptorAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MonitoredResourceDescriptor>(Task.FromResult(expectedResponse), null, null, null, null));
            MetricServiceClient client = new MetricServiceClientImpl(mockGrpcClient.Object, null);
            MonitoredResourceDescriptorName name = new MonitoredResourceDescriptorName("[PROJECT]", "[MONITORED_RESOURCE_DESCRIPTOR]");
            MonitoredResourceDescriptor response = await client.GetMonitoredResourceDescriptorAsync(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetMonitoredResourceDescriptor2()
        {
            Mock<MetricService.MetricServiceClient> mockGrpcClient = new Mock<MetricService.MetricServiceClient>(MockBehavior.Strict);
            GetMonitoredResourceDescriptorRequest request = new GetMonitoredResourceDescriptorRequest
            {
                MonitoredResourceDescriptorName = new MonitoredResourceDescriptorName("[PROJECT]", "[MONITORED_RESOURCE_DESCRIPTOR]"),
            };
            MonitoredResourceDescriptor expectedResponse = new MonitoredResourceDescriptor
            {
                Name = "name2-1052831874",
                Type = "type3575610",
                DisplayName = "displayName1615086568",
                Description = "description-1724546052",
            };
            mockGrpcClient.Setup(x => x.GetMonitoredResourceDescriptor(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            MetricServiceClient client = new MetricServiceClientImpl(mockGrpcClient.Object, null);
            MonitoredResourceDescriptor response = client.GetMonitoredResourceDescriptor(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetMonitoredResourceDescriptorAsync2()
        {
            Mock<MetricService.MetricServiceClient> mockGrpcClient = new Mock<MetricService.MetricServiceClient>(MockBehavior.Strict);
            GetMonitoredResourceDescriptorRequest request = new GetMonitoredResourceDescriptorRequest
            {
                MonitoredResourceDescriptorName = new MonitoredResourceDescriptorName("[PROJECT]", "[MONITORED_RESOURCE_DESCRIPTOR]"),
            };
            MonitoredResourceDescriptor expectedResponse = new MonitoredResourceDescriptor
            {
                Name = "name2-1052831874",
                Type = "type3575610",
                DisplayName = "displayName1615086568",
                Description = "description-1724546052",
            };
            mockGrpcClient.Setup(x => x.GetMonitoredResourceDescriptorAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MonitoredResourceDescriptor>(Task.FromResult(expectedResponse), null, null, null, null));
            MetricServiceClient client = new MetricServiceClientImpl(mockGrpcClient.Object, null);
            MonitoredResourceDescriptor response = await client.GetMonitoredResourceDescriptorAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetMetricDescriptor()
        {
            Mock<MetricService.MetricServiceClient> mockGrpcClient = new Mock<MetricService.MetricServiceClient>(MockBehavior.Strict);
            GetMetricDescriptorRequest expectedRequest = new GetMetricDescriptorRequest
            {
                MetricDescriptorName = new MetricDescriptorName("[PROJECT]", "[METRIC_DESCRIPTOR]"),
            };
            MetricDescriptor expectedResponse = new MetricDescriptor
            {
                Name = "name2-1052831874",
                Type = "type3575610",
                Unit = "unit3594628",
                Description = "description-1724546052",
                DisplayName = "displayName1615086568",
            };
            mockGrpcClient.Setup(x => x.GetMetricDescriptor(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            MetricServiceClient client = new MetricServiceClientImpl(mockGrpcClient.Object, null);
            MetricDescriptorName name = new MetricDescriptorName("[PROJECT]", "[METRIC_DESCRIPTOR]");
            MetricDescriptor response = client.GetMetricDescriptor(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetMetricDescriptorAsync()
        {
            Mock<MetricService.MetricServiceClient> mockGrpcClient = new Mock<MetricService.MetricServiceClient>(MockBehavior.Strict);
            GetMetricDescriptorRequest expectedRequest = new GetMetricDescriptorRequest
            {
                MetricDescriptorName = new MetricDescriptorName("[PROJECT]", "[METRIC_DESCRIPTOR]"),
            };
            MetricDescriptor expectedResponse = new MetricDescriptor
            {
                Name = "name2-1052831874",
                Type = "type3575610",
                Unit = "unit3594628",
                Description = "description-1724546052",
                DisplayName = "displayName1615086568",
            };
            mockGrpcClient.Setup(x => x.GetMetricDescriptorAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MetricDescriptor>(Task.FromResult(expectedResponse), null, null, null, null));
            MetricServiceClient client = new MetricServiceClientImpl(mockGrpcClient.Object, null);
            MetricDescriptorName name = new MetricDescriptorName("[PROJECT]", "[METRIC_DESCRIPTOR]");
            MetricDescriptor response = await client.GetMetricDescriptorAsync(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetMetricDescriptor2()
        {
            Mock<MetricService.MetricServiceClient> mockGrpcClient = new Mock<MetricService.MetricServiceClient>(MockBehavior.Strict);
            GetMetricDescriptorRequest request = new GetMetricDescriptorRequest
            {
                MetricDescriptorName = new MetricDescriptorName("[PROJECT]", "[METRIC_DESCRIPTOR]"),
            };
            MetricDescriptor expectedResponse = new MetricDescriptor
            {
                Name = "name2-1052831874",
                Type = "type3575610",
                Unit = "unit3594628",
                Description = "description-1724546052",
                DisplayName = "displayName1615086568",
            };
            mockGrpcClient.Setup(x => x.GetMetricDescriptor(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            MetricServiceClient client = new MetricServiceClientImpl(mockGrpcClient.Object, null);
            MetricDescriptor response = client.GetMetricDescriptor(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetMetricDescriptorAsync2()
        {
            Mock<MetricService.MetricServiceClient> mockGrpcClient = new Mock<MetricService.MetricServiceClient>(MockBehavior.Strict);
            GetMetricDescriptorRequest request = new GetMetricDescriptorRequest
            {
                MetricDescriptorName = new MetricDescriptorName("[PROJECT]", "[METRIC_DESCRIPTOR]"),
            };
            MetricDescriptor expectedResponse = new MetricDescriptor
            {
                Name = "name2-1052831874",
                Type = "type3575610",
                Unit = "unit3594628",
                Description = "description-1724546052",
                DisplayName = "displayName1615086568",
            };
            mockGrpcClient.Setup(x => x.GetMetricDescriptorAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MetricDescriptor>(Task.FromResult(expectedResponse), null, null, null, null));
            MetricServiceClient client = new MetricServiceClientImpl(mockGrpcClient.Object, null);
            MetricDescriptor response = await client.GetMetricDescriptorAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateMetricDescriptor()
        {
            Mock<MetricService.MetricServiceClient> mockGrpcClient = new Mock<MetricService.MetricServiceClient>(MockBehavior.Strict);
            CreateMetricDescriptorRequest expectedRequest = new CreateMetricDescriptorRequest
            {
                ProjectName = new ProjectName("[PROJECT]"),
                MetricDescriptor = new MetricDescriptor(),
            };
            MetricDescriptor expectedResponse = new MetricDescriptor
            {
                Name = "name2-1052831874",
                Type = "type3575610",
                Unit = "unit3594628",
                Description = "description-1724546052",
                DisplayName = "displayName1615086568",
            };
            mockGrpcClient.Setup(x => x.CreateMetricDescriptor(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            MetricServiceClient client = new MetricServiceClientImpl(mockGrpcClient.Object, null);
            ProjectName name = new ProjectName("[PROJECT]");
            MetricDescriptor metricDescriptor = new MetricDescriptor();
            MetricDescriptor response = client.CreateMetricDescriptor(name, metricDescriptor);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateMetricDescriptorAsync()
        {
            Mock<MetricService.MetricServiceClient> mockGrpcClient = new Mock<MetricService.MetricServiceClient>(MockBehavior.Strict);
            CreateMetricDescriptorRequest expectedRequest = new CreateMetricDescriptorRequest
            {
                ProjectName = new ProjectName("[PROJECT]"),
                MetricDescriptor = new MetricDescriptor(),
            };
            MetricDescriptor expectedResponse = new MetricDescriptor
            {
                Name = "name2-1052831874",
                Type = "type3575610",
                Unit = "unit3594628",
                Description = "description-1724546052",
                DisplayName = "displayName1615086568",
            };
            mockGrpcClient.Setup(x => x.CreateMetricDescriptorAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MetricDescriptor>(Task.FromResult(expectedResponse), null, null, null, null));
            MetricServiceClient client = new MetricServiceClientImpl(mockGrpcClient.Object, null);
            ProjectName name = new ProjectName("[PROJECT]");
            MetricDescriptor metricDescriptor = new MetricDescriptor();
            MetricDescriptor response = await client.CreateMetricDescriptorAsync(name, metricDescriptor);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateMetricDescriptor2()
        {
            Mock<MetricService.MetricServiceClient> mockGrpcClient = new Mock<MetricService.MetricServiceClient>(MockBehavior.Strict);
            CreateMetricDescriptorRequest request = new CreateMetricDescriptorRequest
            {
                ProjectName = new ProjectName("[PROJECT]"),
                MetricDescriptor = new MetricDescriptor(),
            };
            MetricDescriptor expectedResponse = new MetricDescriptor
            {
                Name = "name2-1052831874",
                Type = "type3575610",
                Unit = "unit3594628",
                Description = "description-1724546052",
                DisplayName = "displayName1615086568",
            };
            mockGrpcClient.Setup(x => x.CreateMetricDescriptor(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            MetricServiceClient client = new MetricServiceClientImpl(mockGrpcClient.Object, null);
            MetricDescriptor response = client.CreateMetricDescriptor(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateMetricDescriptorAsync2()
        {
            Mock<MetricService.MetricServiceClient> mockGrpcClient = new Mock<MetricService.MetricServiceClient>(MockBehavior.Strict);
            CreateMetricDescriptorRequest request = new CreateMetricDescriptorRequest
            {
                ProjectName = new ProjectName("[PROJECT]"),
                MetricDescriptor = new MetricDescriptor(),
            };
            MetricDescriptor expectedResponse = new MetricDescriptor
            {
                Name = "name2-1052831874",
                Type = "type3575610",
                Unit = "unit3594628",
                Description = "description-1724546052",
                DisplayName = "displayName1615086568",
            };
            mockGrpcClient.Setup(x => x.CreateMetricDescriptorAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MetricDescriptor>(Task.FromResult(expectedResponse), null, null, null, null));
            MetricServiceClient client = new MetricServiceClientImpl(mockGrpcClient.Object, null);
            MetricDescriptor response = await client.CreateMetricDescriptorAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteMetricDescriptor()
        {
            Mock<MetricService.MetricServiceClient> mockGrpcClient = new Mock<MetricService.MetricServiceClient>(MockBehavior.Strict);
            DeleteMetricDescriptorRequest expectedRequest = new DeleteMetricDescriptorRequest
            {
                MetricDescriptorName = new MetricDescriptorName("[PROJECT]", "[METRIC_DESCRIPTOR]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteMetricDescriptor(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            MetricServiceClient client = new MetricServiceClientImpl(mockGrpcClient.Object, null);
            MetricDescriptorName name = new MetricDescriptorName("[PROJECT]", "[METRIC_DESCRIPTOR]");
            client.DeleteMetricDescriptor(name);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteMetricDescriptorAsync()
        {
            Mock<MetricService.MetricServiceClient> mockGrpcClient = new Mock<MetricService.MetricServiceClient>(MockBehavior.Strict);
            DeleteMetricDescriptorRequest expectedRequest = new DeleteMetricDescriptorRequest
            {
                MetricDescriptorName = new MetricDescriptorName("[PROJECT]", "[METRIC_DESCRIPTOR]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteMetricDescriptorAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            MetricServiceClient client = new MetricServiceClientImpl(mockGrpcClient.Object, null);
            MetricDescriptorName name = new MetricDescriptorName("[PROJECT]", "[METRIC_DESCRIPTOR]");
            await client.DeleteMetricDescriptorAsync(name);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteMetricDescriptor2()
        {
            Mock<MetricService.MetricServiceClient> mockGrpcClient = new Mock<MetricService.MetricServiceClient>(MockBehavior.Strict);
            DeleteMetricDescriptorRequest request = new DeleteMetricDescriptorRequest
            {
                MetricDescriptorName = new MetricDescriptorName("[PROJECT]", "[METRIC_DESCRIPTOR]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteMetricDescriptor(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            MetricServiceClient client = new MetricServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteMetricDescriptor(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteMetricDescriptorAsync2()
        {
            Mock<MetricService.MetricServiceClient> mockGrpcClient = new Mock<MetricService.MetricServiceClient>(MockBehavior.Strict);
            DeleteMetricDescriptorRequest request = new DeleteMetricDescriptorRequest
            {
                MetricDescriptorName = new MetricDescriptorName("[PROJECT]", "[METRIC_DESCRIPTOR]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteMetricDescriptorAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            MetricServiceClient client = new MetricServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteMetricDescriptorAsync(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateTimeSeries()
        {
            Mock<MetricService.MetricServiceClient> mockGrpcClient = new Mock<MetricService.MetricServiceClient>(MockBehavior.Strict);
            CreateTimeSeriesRequest expectedRequest = new CreateTimeSeriesRequest
            {
                ProjectName = new ProjectName("[PROJECT]"),
                TimeSeries = { },
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.CreateTimeSeries(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            MetricServiceClient client = new MetricServiceClientImpl(mockGrpcClient.Object, null);
            ProjectName name = new ProjectName("[PROJECT]");
            IEnumerable<TimeSeries> timeSeries = new List<TimeSeries>();
            client.CreateTimeSeries(name, timeSeries);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateTimeSeriesAsync()
        {
            Mock<MetricService.MetricServiceClient> mockGrpcClient = new Mock<MetricService.MetricServiceClient>(MockBehavior.Strict);
            CreateTimeSeriesRequest expectedRequest = new CreateTimeSeriesRequest
            {
                ProjectName = new ProjectName("[PROJECT]"),
                TimeSeries = { },
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.CreateTimeSeriesAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            MetricServiceClient client = new MetricServiceClientImpl(mockGrpcClient.Object, null);
            ProjectName name = new ProjectName("[PROJECT]");
            IEnumerable<TimeSeries> timeSeries = new List<TimeSeries>();
            await client.CreateTimeSeriesAsync(name, timeSeries);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateTimeSeries2()
        {
            Mock<MetricService.MetricServiceClient> mockGrpcClient = new Mock<MetricService.MetricServiceClient>(MockBehavior.Strict);
            CreateTimeSeriesRequest request = new CreateTimeSeriesRequest
            {
                ProjectName = new ProjectName("[PROJECT]"),
                TimeSeries = { },
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.CreateTimeSeries(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            MetricServiceClient client = new MetricServiceClientImpl(mockGrpcClient.Object, null);
            client.CreateTimeSeries(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateTimeSeriesAsync2()
        {
            Mock<MetricService.MetricServiceClient> mockGrpcClient = new Mock<MetricService.MetricServiceClient>(MockBehavior.Strict);
            CreateTimeSeriesRequest request = new CreateTimeSeriesRequest
            {
                ProjectName = new ProjectName("[PROJECT]"),
                TimeSeries = { },
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.CreateTimeSeriesAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            MetricServiceClient client = new MetricServiceClientImpl(mockGrpcClient.Object, null);
            await client.CreateTimeSeriesAsync(request);
            mockGrpcClient.VerifyAll();
        }

    }
}
