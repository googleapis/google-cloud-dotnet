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

using ga = Google.Api;
using gaxgrpc = Google.Api.Gax.Grpc;
using gagr = Google.Api.Gax.ResourceNames;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Monitoring.V3.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedMetricServiceClientTest
    {
        [xunit::FactAttribute]
        public void GetMonitoredResourceDescriptorRequestObject()
        {
            moq::Mock<MetricService.MetricServiceClient> mockGrpcClient = new moq::Mock<MetricService.MetricServiceClient>(moq::MockBehavior.Strict);
            GetMonitoredResourceDescriptorRequest request = new GetMonitoredResourceDescriptorRequest
            {
                MonitoredResourceDescriptorName = MonitoredResourceDescriptorName.FromProjectMonitoredResourceDescriptor("[PROJECT]", "[MONITORED_RESOURCE_DESCRIPTOR]"),
            };
            ga::MonitoredResourceDescriptor expectedResponse = new ga::MonitoredResourceDescriptor
            {
                Type = "typee2cc9d59",
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                Labels =
                {
                    new ga::LabelDescriptor(),
                },
                Name = "name1c9368b0",
                LaunchStage = ga::LaunchStage.Unspecified,
            };
            mockGrpcClient.Setup(x => x.GetMonitoredResourceDescriptor(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MetricServiceClient client = new MetricServiceClientImpl(mockGrpcClient.Object, null);
            ga::MonitoredResourceDescriptor response = client.GetMonitoredResourceDescriptor(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetMonitoredResourceDescriptorRequestObjectAsync()
        {
            moq::Mock<MetricService.MetricServiceClient> mockGrpcClient = new moq::Mock<MetricService.MetricServiceClient>(moq::MockBehavior.Strict);
            GetMonitoredResourceDescriptorRequest request = new GetMonitoredResourceDescriptorRequest
            {
                MonitoredResourceDescriptorName = MonitoredResourceDescriptorName.FromProjectMonitoredResourceDescriptor("[PROJECT]", "[MONITORED_RESOURCE_DESCRIPTOR]"),
            };
            ga::MonitoredResourceDescriptor expectedResponse = new ga::MonitoredResourceDescriptor
            {
                Type = "typee2cc9d59",
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                Labels =
                {
                    new ga::LabelDescriptor(),
                },
                Name = "name1c9368b0",
                LaunchStage = ga::LaunchStage.Unspecified,
            };
            mockGrpcClient.Setup(x => x.GetMonitoredResourceDescriptorAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ga::MonitoredResourceDescriptor>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MetricServiceClient client = new MetricServiceClientImpl(mockGrpcClient.Object, null);
            ga::MonitoredResourceDescriptor responseCallSettings = await client.GetMonitoredResourceDescriptorAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ga::MonitoredResourceDescriptor responseCancellationToken = await client.GetMonitoredResourceDescriptorAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetMonitoredResourceDescriptor()
        {
            moq::Mock<MetricService.MetricServiceClient> mockGrpcClient = new moq::Mock<MetricService.MetricServiceClient>(moq::MockBehavior.Strict);
            GetMonitoredResourceDescriptorRequest request = new GetMonitoredResourceDescriptorRequest
            {
                MonitoredResourceDescriptorName = MonitoredResourceDescriptorName.FromProjectMonitoredResourceDescriptor("[PROJECT]", "[MONITORED_RESOURCE_DESCRIPTOR]"),
            };
            ga::MonitoredResourceDescriptor expectedResponse = new ga::MonitoredResourceDescriptor
            {
                Type = "typee2cc9d59",
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                Labels =
                {
                    new ga::LabelDescriptor(),
                },
                Name = "name1c9368b0",
                LaunchStage = ga::LaunchStage.Unspecified,
            };
            mockGrpcClient.Setup(x => x.GetMonitoredResourceDescriptor(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MetricServiceClient client = new MetricServiceClientImpl(mockGrpcClient.Object, null);
            ga::MonitoredResourceDescriptor response = client.GetMonitoredResourceDescriptor(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetMonitoredResourceDescriptorAsync()
        {
            moq::Mock<MetricService.MetricServiceClient> mockGrpcClient = new moq::Mock<MetricService.MetricServiceClient>(moq::MockBehavior.Strict);
            GetMonitoredResourceDescriptorRequest request = new GetMonitoredResourceDescriptorRequest
            {
                MonitoredResourceDescriptorName = MonitoredResourceDescriptorName.FromProjectMonitoredResourceDescriptor("[PROJECT]", "[MONITORED_RESOURCE_DESCRIPTOR]"),
            };
            ga::MonitoredResourceDescriptor expectedResponse = new ga::MonitoredResourceDescriptor
            {
                Type = "typee2cc9d59",
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                Labels =
                {
                    new ga::LabelDescriptor(),
                },
                Name = "name1c9368b0",
                LaunchStage = ga::LaunchStage.Unspecified,
            };
            mockGrpcClient.Setup(x => x.GetMonitoredResourceDescriptorAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ga::MonitoredResourceDescriptor>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MetricServiceClient client = new MetricServiceClientImpl(mockGrpcClient.Object, null);
            ga::MonitoredResourceDescriptor responseCallSettings = await client.GetMonitoredResourceDescriptorAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ga::MonitoredResourceDescriptor responseCancellationToken = await client.GetMonitoredResourceDescriptorAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetMonitoredResourceDescriptorResourceNames1()
        {
            moq::Mock<MetricService.MetricServiceClient> mockGrpcClient = new moq::Mock<MetricService.MetricServiceClient>(moq::MockBehavior.Strict);
            GetMonitoredResourceDescriptorRequest request = new GetMonitoredResourceDescriptorRequest
            {
                MonitoredResourceDescriptorName = MonitoredResourceDescriptorName.FromProjectMonitoredResourceDescriptor("[PROJECT]", "[MONITORED_RESOURCE_DESCRIPTOR]"),
            };
            ga::MonitoredResourceDescriptor expectedResponse = new ga::MonitoredResourceDescriptor
            {
                Type = "typee2cc9d59",
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                Labels =
                {
                    new ga::LabelDescriptor(),
                },
                Name = "name1c9368b0",
                LaunchStage = ga::LaunchStage.Unspecified,
            };
            mockGrpcClient.Setup(x => x.GetMonitoredResourceDescriptor(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MetricServiceClient client = new MetricServiceClientImpl(mockGrpcClient.Object, null);
            ga::MonitoredResourceDescriptor response = client.GetMonitoredResourceDescriptor(request.MonitoredResourceDescriptorName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetMonitoredResourceDescriptorResourceNames1Async()
        {
            moq::Mock<MetricService.MetricServiceClient> mockGrpcClient = new moq::Mock<MetricService.MetricServiceClient>(moq::MockBehavior.Strict);
            GetMonitoredResourceDescriptorRequest request = new GetMonitoredResourceDescriptorRequest
            {
                MonitoredResourceDescriptorName = MonitoredResourceDescriptorName.FromProjectMonitoredResourceDescriptor("[PROJECT]", "[MONITORED_RESOURCE_DESCRIPTOR]"),
            };
            ga::MonitoredResourceDescriptor expectedResponse = new ga::MonitoredResourceDescriptor
            {
                Type = "typee2cc9d59",
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                Labels =
                {
                    new ga::LabelDescriptor(),
                },
                Name = "name1c9368b0",
                LaunchStage = ga::LaunchStage.Unspecified,
            };
            mockGrpcClient.Setup(x => x.GetMonitoredResourceDescriptorAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ga::MonitoredResourceDescriptor>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MetricServiceClient client = new MetricServiceClientImpl(mockGrpcClient.Object, null);
            ga::MonitoredResourceDescriptor responseCallSettings = await client.GetMonitoredResourceDescriptorAsync(request.MonitoredResourceDescriptorName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ga::MonitoredResourceDescriptor responseCancellationToken = await client.GetMonitoredResourceDescriptorAsync(request.MonitoredResourceDescriptorName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetMonitoredResourceDescriptorResourceNames2()
        {
            moq::Mock<MetricService.MetricServiceClient> mockGrpcClient = new moq::Mock<MetricService.MetricServiceClient>(moq::MockBehavior.Strict);
            GetMonitoredResourceDescriptorRequest request = new GetMonitoredResourceDescriptorRequest
            {
                MonitoredResourceDescriptorName = MonitoredResourceDescriptorName.FromProjectMonitoredResourceDescriptor("[PROJECT]", "[MONITORED_RESOURCE_DESCRIPTOR]"),
            };
            ga::MonitoredResourceDescriptor expectedResponse = new ga::MonitoredResourceDescriptor
            {
                Type = "typee2cc9d59",
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                Labels =
                {
                    new ga::LabelDescriptor(),
                },
                Name = "name1c9368b0",
                LaunchStage = ga::LaunchStage.Unspecified,
            };
            mockGrpcClient.Setup(x => x.GetMonitoredResourceDescriptor(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MetricServiceClient client = new MetricServiceClientImpl(mockGrpcClient.Object, null);
            ga::MonitoredResourceDescriptor response = client.GetMonitoredResourceDescriptor(request.ResourceName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetMonitoredResourceDescriptorResourceNames2Async()
        {
            moq::Mock<MetricService.MetricServiceClient> mockGrpcClient = new moq::Mock<MetricService.MetricServiceClient>(moq::MockBehavior.Strict);
            GetMonitoredResourceDescriptorRequest request = new GetMonitoredResourceDescriptorRequest
            {
                MonitoredResourceDescriptorName = MonitoredResourceDescriptorName.FromProjectMonitoredResourceDescriptor("[PROJECT]", "[MONITORED_RESOURCE_DESCRIPTOR]"),
            };
            ga::MonitoredResourceDescriptor expectedResponse = new ga::MonitoredResourceDescriptor
            {
                Type = "typee2cc9d59",
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                Labels =
                {
                    new ga::LabelDescriptor(),
                },
                Name = "name1c9368b0",
                LaunchStage = ga::LaunchStage.Unspecified,
            };
            mockGrpcClient.Setup(x => x.GetMonitoredResourceDescriptorAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ga::MonitoredResourceDescriptor>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MetricServiceClient client = new MetricServiceClientImpl(mockGrpcClient.Object, null);
            ga::MonitoredResourceDescriptor responseCallSettings = await client.GetMonitoredResourceDescriptorAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ga::MonitoredResourceDescriptor responseCancellationToken = await client.GetMonitoredResourceDescriptorAsync(request.ResourceName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetMetricDescriptorRequestObject()
        {
            moq::Mock<MetricService.MetricServiceClient> mockGrpcClient = new moq::Mock<MetricService.MetricServiceClient>(moq::MockBehavior.Strict);
            GetMetricDescriptorRequest request = new GetMetricDescriptorRequest
            {
                MetricDescriptorName = MetricDescriptorName.FromProjectMetricDescriptor("[PROJECT]", "[METRIC_DESCRIPTOR]"),
            };
            ga::MetricDescriptor expectedResponse = new ga::MetricDescriptor
            {
                Name = "name1c9368b0",
                Labels =
                {
                    new ga::LabelDescriptor(),
                },
                MetricKind = ga::MetricDescriptor.Types.MetricKind.Gauge,
                ValueType = ga::MetricDescriptor.Types.ValueType.Money,
                Unit = "unitebbd343e",
                Description = "description2cf9da67",
                DisplayName = "display_name137f65c2",
                Type = "typee2cc9d59",
                Metadata = new ga::MetricDescriptor.Types.MetricDescriptorMetadata(),
                LaunchStage = ga::LaunchStage.Unspecified,
                MonitoredResourceTypes =
                {
                    "monitored_resource_typesc49bdc0a",
                },
            };
            mockGrpcClient.Setup(x => x.GetMetricDescriptor(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MetricServiceClient client = new MetricServiceClientImpl(mockGrpcClient.Object, null);
            ga::MetricDescriptor response = client.GetMetricDescriptor(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetMetricDescriptorRequestObjectAsync()
        {
            moq::Mock<MetricService.MetricServiceClient> mockGrpcClient = new moq::Mock<MetricService.MetricServiceClient>(moq::MockBehavior.Strict);
            GetMetricDescriptorRequest request = new GetMetricDescriptorRequest
            {
                MetricDescriptorName = MetricDescriptorName.FromProjectMetricDescriptor("[PROJECT]", "[METRIC_DESCRIPTOR]"),
            };
            ga::MetricDescriptor expectedResponse = new ga::MetricDescriptor
            {
                Name = "name1c9368b0",
                Labels =
                {
                    new ga::LabelDescriptor(),
                },
                MetricKind = ga::MetricDescriptor.Types.MetricKind.Gauge,
                ValueType = ga::MetricDescriptor.Types.ValueType.Money,
                Unit = "unitebbd343e",
                Description = "description2cf9da67",
                DisplayName = "display_name137f65c2",
                Type = "typee2cc9d59",
                Metadata = new ga::MetricDescriptor.Types.MetricDescriptorMetadata(),
                LaunchStage = ga::LaunchStage.Unspecified,
                MonitoredResourceTypes =
                {
                    "monitored_resource_typesc49bdc0a",
                },
            };
            mockGrpcClient.Setup(x => x.GetMetricDescriptorAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ga::MetricDescriptor>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MetricServiceClient client = new MetricServiceClientImpl(mockGrpcClient.Object, null);
            ga::MetricDescriptor responseCallSettings = await client.GetMetricDescriptorAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ga::MetricDescriptor responseCancellationToken = await client.GetMetricDescriptorAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetMetricDescriptor()
        {
            moq::Mock<MetricService.MetricServiceClient> mockGrpcClient = new moq::Mock<MetricService.MetricServiceClient>(moq::MockBehavior.Strict);
            GetMetricDescriptorRequest request = new GetMetricDescriptorRequest
            {
                MetricDescriptorName = MetricDescriptorName.FromProjectMetricDescriptor("[PROJECT]", "[METRIC_DESCRIPTOR]"),
            };
            ga::MetricDescriptor expectedResponse = new ga::MetricDescriptor
            {
                Name = "name1c9368b0",
                Labels =
                {
                    new ga::LabelDescriptor(),
                },
                MetricKind = ga::MetricDescriptor.Types.MetricKind.Gauge,
                ValueType = ga::MetricDescriptor.Types.ValueType.Money,
                Unit = "unitebbd343e",
                Description = "description2cf9da67",
                DisplayName = "display_name137f65c2",
                Type = "typee2cc9d59",
                Metadata = new ga::MetricDescriptor.Types.MetricDescriptorMetadata(),
                LaunchStage = ga::LaunchStage.Unspecified,
                MonitoredResourceTypes =
                {
                    "monitored_resource_typesc49bdc0a",
                },
            };
            mockGrpcClient.Setup(x => x.GetMetricDescriptor(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MetricServiceClient client = new MetricServiceClientImpl(mockGrpcClient.Object, null);
            ga::MetricDescriptor response = client.GetMetricDescriptor(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetMetricDescriptorAsync()
        {
            moq::Mock<MetricService.MetricServiceClient> mockGrpcClient = new moq::Mock<MetricService.MetricServiceClient>(moq::MockBehavior.Strict);
            GetMetricDescriptorRequest request = new GetMetricDescriptorRequest
            {
                MetricDescriptorName = MetricDescriptorName.FromProjectMetricDescriptor("[PROJECT]", "[METRIC_DESCRIPTOR]"),
            };
            ga::MetricDescriptor expectedResponse = new ga::MetricDescriptor
            {
                Name = "name1c9368b0",
                Labels =
                {
                    new ga::LabelDescriptor(),
                },
                MetricKind = ga::MetricDescriptor.Types.MetricKind.Gauge,
                ValueType = ga::MetricDescriptor.Types.ValueType.Money,
                Unit = "unitebbd343e",
                Description = "description2cf9da67",
                DisplayName = "display_name137f65c2",
                Type = "typee2cc9d59",
                Metadata = new ga::MetricDescriptor.Types.MetricDescriptorMetadata(),
                LaunchStage = ga::LaunchStage.Unspecified,
                MonitoredResourceTypes =
                {
                    "monitored_resource_typesc49bdc0a",
                },
            };
            mockGrpcClient.Setup(x => x.GetMetricDescriptorAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ga::MetricDescriptor>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MetricServiceClient client = new MetricServiceClientImpl(mockGrpcClient.Object, null);
            ga::MetricDescriptor responseCallSettings = await client.GetMetricDescriptorAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ga::MetricDescriptor responseCancellationToken = await client.GetMetricDescriptorAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetMetricDescriptorResourceNames1()
        {
            moq::Mock<MetricService.MetricServiceClient> mockGrpcClient = new moq::Mock<MetricService.MetricServiceClient>(moq::MockBehavior.Strict);
            GetMetricDescriptorRequest request = new GetMetricDescriptorRequest
            {
                MetricDescriptorName = MetricDescriptorName.FromProjectMetricDescriptor("[PROJECT]", "[METRIC_DESCRIPTOR]"),
            };
            ga::MetricDescriptor expectedResponse = new ga::MetricDescriptor
            {
                Name = "name1c9368b0",
                Labels =
                {
                    new ga::LabelDescriptor(),
                },
                MetricKind = ga::MetricDescriptor.Types.MetricKind.Gauge,
                ValueType = ga::MetricDescriptor.Types.ValueType.Money,
                Unit = "unitebbd343e",
                Description = "description2cf9da67",
                DisplayName = "display_name137f65c2",
                Type = "typee2cc9d59",
                Metadata = new ga::MetricDescriptor.Types.MetricDescriptorMetadata(),
                LaunchStage = ga::LaunchStage.Unspecified,
                MonitoredResourceTypes =
                {
                    "monitored_resource_typesc49bdc0a",
                },
            };
            mockGrpcClient.Setup(x => x.GetMetricDescriptor(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MetricServiceClient client = new MetricServiceClientImpl(mockGrpcClient.Object, null);
            ga::MetricDescriptor response = client.GetMetricDescriptor(request.MetricDescriptorName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetMetricDescriptorResourceNames1Async()
        {
            moq::Mock<MetricService.MetricServiceClient> mockGrpcClient = new moq::Mock<MetricService.MetricServiceClient>(moq::MockBehavior.Strict);
            GetMetricDescriptorRequest request = new GetMetricDescriptorRequest
            {
                MetricDescriptorName = MetricDescriptorName.FromProjectMetricDescriptor("[PROJECT]", "[METRIC_DESCRIPTOR]"),
            };
            ga::MetricDescriptor expectedResponse = new ga::MetricDescriptor
            {
                Name = "name1c9368b0",
                Labels =
                {
                    new ga::LabelDescriptor(),
                },
                MetricKind = ga::MetricDescriptor.Types.MetricKind.Gauge,
                ValueType = ga::MetricDescriptor.Types.ValueType.Money,
                Unit = "unitebbd343e",
                Description = "description2cf9da67",
                DisplayName = "display_name137f65c2",
                Type = "typee2cc9d59",
                Metadata = new ga::MetricDescriptor.Types.MetricDescriptorMetadata(),
                LaunchStage = ga::LaunchStage.Unspecified,
                MonitoredResourceTypes =
                {
                    "monitored_resource_typesc49bdc0a",
                },
            };
            mockGrpcClient.Setup(x => x.GetMetricDescriptorAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ga::MetricDescriptor>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MetricServiceClient client = new MetricServiceClientImpl(mockGrpcClient.Object, null);
            ga::MetricDescriptor responseCallSettings = await client.GetMetricDescriptorAsync(request.MetricDescriptorName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ga::MetricDescriptor responseCancellationToken = await client.GetMetricDescriptorAsync(request.MetricDescriptorName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetMetricDescriptorResourceNames2()
        {
            moq::Mock<MetricService.MetricServiceClient> mockGrpcClient = new moq::Mock<MetricService.MetricServiceClient>(moq::MockBehavior.Strict);
            GetMetricDescriptorRequest request = new GetMetricDescriptorRequest
            {
                MetricDescriptorName = MetricDescriptorName.FromProjectMetricDescriptor("[PROJECT]", "[METRIC_DESCRIPTOR]"),
            };
            ga::MetricDescriptor expectedResponse = new ga::MetricDescriptor
            {
                Name = "name1c9368b0",
                Labels =
                {
                    new ga::LabelDescriptor(),
                },
                MetricKind = ga::MetricDescriptor.Types.MetricKind.Gauge,
                ValueType = ga::MetricDescriptor.Types.ValueType.Money,
                Unit = "unitebbd343e",
                Description = "description2cf9da67",
                DisplayName = "display_name137f65c2",
                Type = "typee2cc9d59",
                Metadata = new ga::MetricDescriptor.Types.MetricDescriptorMetadata(),
                LaunchStage = ga::LaunchStage.Unspecified,
                MonitoredResourceTypes =
                {
                    "monitored_resource_typesc49bdc0a",
                },
            };
            mockGrpcClient.Setup(x => x.GetMetricDescriptor(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MetricServiceClient client = new MetricServiceClientImpl(mockGrpcClient.Object, null);
            ga::MetricDescriptor response = client.GetMetricDescriptor(request.ResourceName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetMetricDescriptorResourceNames2Async()
        {
            moq::Mock<MetricService.MetricServiceClient> mockGrpcClient = new moq::Mock<MetricService.MetricServiceClient>(moq::MockBehavior.Strict);
            GetMetricDescriptorRequest request = new GetMetricDescriptorRequest
            {
                MetricDescriptorName = MetricDescriptorName.FromProjectMetricDescriptor("[PROJECT]", "[METRIC_DESCRIPTOR]"),
            };
            ga::MetricDescriptor expectedResponse = new ga::MetricDescriptor
            {
                Name = "name1c9368b0",
                Labels =
                {
                    new ga::LabelDescriptor(),
                },
                MetricKind = ga::MetricDescriptor.Types.MetricKind.Gauge,
                ValueType = ga::MetricDescriptor.Types.ValueType.Money,
                Unit = "unitebbd343e",
                Description = "description2cf9da67",
                DisplayName = "display_name137f65c2",
                Type = "typee2cc9d59",
                Metadata = new ga::MetricDescriptor.Types.MetricDescriptorMetadata(),
                LaunchStage = ga::LaunchStage.Unspecified,
                MonitoredResourceTypes =
                {
                    "monitored_resource_typesc49bdc0a",
                },
            };
            mockGrpcClient.Setup(x => x.GetMetricDescriptorAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ga::MetricDescriptor>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MetricServiceClient client = new MetricServiceClientImpl(mockGrpcClient.Object, null);
            ga::MetricDescriptor responseCallSettings = await client.GetMetricDescriptorAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ga::MetricDescriptor responseCancellationToken = await client.GetMetricDescriptorAsync(request.ResourceName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateMetricDescriptorRequestObject()
        {
            moq::Mock<MetricService.MetricServiceClient> mockGrpcClient = new moq::Mock<MetricService.MetricServiceClient>(moq::MockBehavior.Strict);
            CreateMetricDescriptorRequest request = new CreateMetricDescriptorRequest
            {
                MetricDescriptor = new ga::MetricDescriptor(),
                ProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
            };
            ga::MetricDescriptor expectedResponse = new ga::MetricDescriptor
            {
                Name = "name1c9368b0",
                Labels =
                {
                    new ga::LabelDescriptor(),
                },
                MetricKind = ga::MetricDescriptor.Types.MetricKind.Gauge,
                ValueType = ga::MetricDescriptor.Types.ValueType.Money,
                Unit = "unitebbd343e",
                Description = "description2cf9da67",
                DisplayName = "display_name137f65c2",
                Type = "typee2cc9d59",
                Metadata = new ga::MetricDescriptor.Types.MetricDescriptorMetadata(),
                LaunchStage = ga::LaunchStage.Unspecified,
                MonitoredResourceTypes =
                {
                    "monitored_resource_typesc49bdc0a",
                },
            };
            mockGrpcClient.Setup(x => x.CreateMetricDescriptor(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MetricServiceClient client = new MetricServiceClientImpl(mockGrpcClient.Object, null);
            ga::MetricDescriptor response = client.CreateMetricDescriptor(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateMetricDescriptorRequestObjectAsync()
        {
            moq::Mock<MetricService.MetricServiceClient> mockGrpcClient = new moq::Mock<MetricService.MetricServiceClient>(moq::MockBehavior.Strict);
            CreateMetricDescriptorRequest request = new CreateMetricDescriptorRequest
            {
                MetricDescriptor = new ga::MetricDescriptor(),
                ProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
            };
            ga::MetricDescriptor expectedResponse = new ga::MetricDescriptor
            {
                Name = "name1c9368b0",
                Labels =
                {
                    new ga::LabelDescriptor(),
                },
                MetricKind = ga::MetricDescriptor.Types.MetricKind.Gauge,
                ValueType = ga::MetricDescriptor.Types.ValueType.Money,
                Unit = "unitebbd343e",
                Description = "description2cf9da67",
                DisplayName = "display_name137f65c2",
                Type = "typee2cc9d59",
                Metadata = new ga::MetricDescriptor.Types.MetricDescriptorMetadata(),
                LaunchStage = ga::LaunchStage.Unspecified,
                MonitoredResourceTypes =
                {
                    "monitored_resource_typesc49bdc0a",
                },
            };
            mockGrpcClient.Setup(x => x.CreateMetricDescriptorAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ga::MetricDescriptor>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MetricServiceClient client = new MetricServiceClientImpl(mockGrpcClient.Object, null);
            ga::MetricDescriptor responseCallSettings = await client.CreateMetricDescriptorAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ga::MetricDescriptor responseCancellationToken = await client.CreateMetricDescriptorAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateMetricDescriptor()
        {
            moq::Mock<MetricService.MetricServiceClient> mockGrpcClient = new moq::Mock<MetricService.MetricServiceClient>(moq::MockBehavior.Strict);
            CreateMetricDescriptorRequest request = new CreateMetricDescriptorRequest
            {
                MetricDescriptor = new ga::MetricDescriptor(),
                ProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
            };
            ga::MetricDescriptor expectedResponse = new ga::MetricDescriptor
            {
                Name = "name1c9368b0",
                Labels =
                {
                    new ga::LabelDescriptor(),
                },
                MetricKind = ga::MetricDescriptor.Types.MetricKind.Gauge,
                ValueType = ga::MetricDescriptor.Types.ValueType.Money,
                Unit = "unitebbd343e",
                Description = "description2cf9da67",
                DisplayName = "display_name137f65c2",
                Type = "typee2cc9d59",
                Metadata = new ga::MetricDescriptor.Types.MetricDescriptorMetadata(),
                LaunchStage = ga::LaunchStage.Unspecified,
                MonitoredResourceTypes =
                {
                    "monitored_resource_typesc49bdc0a",
                },
            };
            mockGrpcClient.Setup(x => x.CreateMetricDescriptor(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MetricServiceClient client = new MetricServiceClientImpl(mockGrpcClient.Object, null);
            ga::MetricDescriptor response = client.CreateMetricDescriptor(request.Name, request.MetricDescriptor);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateMetricDescriptorAsync()
        {
            moq::Mock<MetricService.MetricServiceClient> mockGrpcClient = new moq::Mock<MetricService.MetricServiceClient>(moq::MockBehavior.Strict);
            CreateMetricDescriptorRequest request = new CreateMetricDescriptorRequest
            {
                MetricDescriptor = new ga::MetricDescriptor(),
                ProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
            };
            ga::MetricDescriptor expectedResponse = new ga::MetricDescriptor
            {
                Name = "name1c9368b0",
                Labels =
                {
                    new ga::LabelDescriptor(),
                },
                MetricKind = ga::MetricDescriptor.Types.MetricKind.Gauge,
                ValueType = ga::MetricDescriptor.Types.ValueType.Money,
                Unit = "unitebbd343e",
                Description = "description2cf9da67",
                DisplayName = "display_name137f65c2",
                Type = "typee2cc9d59",
                Metadata = new ga::MetricDescriptor.Types.MetricDescriptorMetadata(),
                LaunchStage = ga::LaunchStage.Unspecified,
                MonitoredResourceTypes =
                {
                    "monitored_resource_typesc49bdc0a",
                },
            };
            mockGrpcClient.Setup(x => x.CreateMetricDescriptorAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ga::MetricDescriptor>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MetricServiceClient client = new MetricServiceClientImpl(mockGrpcClient.Object, null);
            ga::MetricDescriptor responseCallSettings = await client.CreateMetricDescriptorAsync(request.Name, request.MetricDescriptor, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ga::MetricDescriptor responseCancellationToken = await client.CreateMetricDescriptorAsync(request.Name, request.MetricDescriptor, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateMetricDescriptorResourceNames1()
        {
            moq::Mock<MetricService.MetricServiceClient> mockGrpcClient = new moq::Mock<MetricService.MetricServiceClient>(moq::MockBehavior.Strict);
            CreateMetricDescriptorRequest request = new CreateMetricDescriptorRequest
            {
                MetricDescriptor = new ga::MetricDescriptor(),
                ProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
            };
            ga::MetricDescriptor expectedResponse = new ga::MetricDescriptor
            {
                Name = "name1c9368b0",
                Labels =
                {
                    new ga::LabelDescriptor(),
                },
                MetricKind = ga::MetricDescriptor.Types.MetricKind.Gauge,
                ValueType = ga::MetricDescriptor.Types.ValueType.Money,
                Unit = "unitebbd343e",
                Description = "description2cf9da67",
                DisplayName = "display_name137f65c2",
                Type = "typee2cc9d59",
                Metadata = new ga::MetricDescriptor.Types.MetricDescriptorMetadata(),
                LaunchStage = ga::LaunchStage.Unspecified,
                MonitoredResourceTypes =
                {
                    "monitored_resource_typesc49bdc0a",
                },
            };
            mockGrpcClient.Setup(x => x.CreateMetricDescriptor(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MetricServiceClient client = new MetricServiceClientImpl(mockGrpcClient.Object, null);
            ga::MetricDescriptor response = client.CreateMetricDescriptor(request.ProjectName, request.MetricDescriptor);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateMetricDescriptorResourceNames1Async()
        {
            moq::Mock<MetricService.MetricServiceClient> mockGrpcClient = new moq::Mock<MetricService.MetricServiceClient>(moq::MockBehavior.Strict);
            CreateMetricDescriptorRequest request = new CreateMetricDescriptorRequest
            {
                MetricDescriptor = new ga::MetricDescriptor(),
                ProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
            };
            ga::MetricDescriptor expectedResponse = new ga::MetricDescriptor
            {
                Name = "name1c9368b0",
                Labels =
                {
                    new ga::LabelDescriptor(),
                },
                MetricKind = ga::MetricDescriptor.Types.MetricKind.Gauge,
                ValueType = ga::MetricDescriptor.Types.ValueType.Money,
                Unit = "unitebbd343e",
                Description = "description2cf9da67",
                DisplayName = "display_name137f65c2",
                Type = "typee2cc9d59",
                Metadata = new ga::MetricDescriptor.Types.MetricDescriptorMetadata(),
                LaunchStage = ga::LaunchStage.Unspecified,
                MonitoredResourceTypes =
                {
                    "monitored_resource_typesc49bdc0a",
                },
            };
            mockGrpcClient.Setup(x => x.CreateMetricDescriptorAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ga::MetricDescriptor>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MetricServiceClient client = new MetricServiceClientImpl(mockGrpcClient.Object, null);
            ga::MetricDescriptor responseCallSettings = await client.CreateMetricDescriptorAsync(request.ProjectName, request.MetricDescriptor, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ga::MetricDescriptor responseCancellationToken = await client.CreateMetricDescriptorAsync(request.ProjectName, request.MetricDescriptor, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateMetricDescriptorResourceNames2()
        {
            moq::Mock<MetricService.MetricServiceClient> mockGrpcClient = new moq::Mock<MetricService.MetricServiceClient>(moq::MockBehavior.Strict);
            CreateMetricDescriptorRequest request = new CreateMetricDescriptorRequest
            {
                MetricDescriptor = new ga::MetricDescriptor(),
                ProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
            };
            ga::MetricDescriptor expectedResponse = new ga::MetricDescriptor
            {
                Name = "name1c9368b0",
                Labels =
                {
                    new ga::LabelDescriptor(),
                },
                MetricKind = ga::MetricDescriptor.Types.MetricKind.Gauge,
                ValueType = ga::MetricDescriptor.Types.ValueType.Money,
                Unit = "unitebbd343e",
                Description = "description2cf9da67",
                DisplayName = "display_name137f65c2",
                Type = "typee2cc9d59",
                Metadata = new ga::MetricDescriptor.Types.MetricDescriptorMetadata(),
                LaunchStage = ga::LaunchStage.Unspecified,
                MonitoredResourceTypes =
                {
                    "monitored_resource_typesc49bdc0a",
                },
            };
            mockGrpcClient.Setup(x => x.CreateMetricDescriptor(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MetricServiceClient client = new MetricServiceClientImpl(mockGrpcClient.Object, null);
            ga::MetricDescriptor response = client.CreateMetricDescriptor(request.OrganizationName, request.MetricDescriptor);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateMetricDescriptorResourceNames2Async()
        {
            moq::Mock<MetricService.MetricServiceClient> mockGrpcClient = new moq::Mock<MetricService.MetricServiceClient>(moq::MockBehavior.Strict);
            CreateMetricDescriptorRequest request = new CreateMetricDescriptorRequest
            {
                MetricDescriptor = new ga::MetricDescriptor(),
                ProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
            };
            ga::MetricDescriptor expectedResponse = new ga::MetricDescriptor
            {
                Name = "name1c9368b0",
                Labels =
                {
                    new ga::LabelDescriptor(),
                },
                MetricKind = ga::MetricDescriptor.Types.MetricKind.Gauge,
                ValueType = ga::MetricDescriptor.Types.ValueType.Money,
                Unit = "unitebbd343e",
                Description = "description2cf9da67",
                DisplayName = "display_name137f65c2",
                Type = "typee2cc9d59",
                Metadata = new ga::MetricDescriptor.Types.MetricDescriptorMetadata(),
                LaunchStage = ga::LaunchStage.Unspecified,
                MonitoredResourceTypes =
                {
                    "monitored_resource_typesc49bdc0a",
                },
            };
            mockGrpcClient.Setup(x => x.CreateMetricDescriptorAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ga::MetricDescriptor>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MetricServiceClient client = new MetricServiceClientImpl(mockGrpcClient.Object, null);
            ga::MetricDescriptor responseCallSettings = await client.CreateMetricDescriptorAsync(request.OrganizationName, request.MetricDescriptor, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ga::MetricDescriptor responseCancellationToken = await client.CreateMetricDescriptorAsync(request.OrganizationName, request.MetricDescriptor, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateMetricDescriptorResourceNames3()
        {
            moq::Mock<MetricService.MetricServiceClient> mockGrpcClient = new moq::Mock<MetricService.MetricServiceClient>(moq::MockBehavior.Strict);
            CreateMetricDescriptorRequest request = new CreateMetricDescriptorRequest
            {
                MetricDescriptor = new ga::MetricDescriptor(),
                ProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
            };
            ga::MetricDescriptor expectedResponse = new ga::MetricDescriptor
            {
                Name = "name1c9368b0",
                Labels =
                {
                    new ga::LabelDescriptor(),
                },
                MetricKind = ga::MetricDescriptor.Types.MetricKind.Gauge,
                ValueType = ga::MetricDescriptor.Types.ValueType.Money,
                Unit = "unitebbd343e",
                Description = "description2cf9da67",
                DisplayName = "display_name137f65c2",
                Type = "typee2cc9d59",
                Metadata = new ga::MetricDescriptor.Types.MetricDescriptorMetadata(),
                LaunchStage = ga::LaunchStage.Unspecified,
                MonitoredResourceTypes =
                {
                    "monitored_resource_typesc49bdc0a",
                },
            };
            mockGrpcClient.Setup(x => x.CreateMetricDescriptor(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MetricServiceClient client = new MetricServiceClientImpl(mockGrpcClient.Object, null);
            ga::MetricDescriptor response = client.CreateMetricDescriptor(request.FolderName, request.MetricDescriptor);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateMetricDescriptorResourceNames3Async()
        {
            moq::Mock<MetricService.MetricServiceClient> mockGrpcClient = new moq::Mock<MetricService.MetricServiceClient>(moq::MockBehavior.Strict);
            CreateMetricDescriptorRequest request = new CreateMetricDescriptorRequest
            {
                MetricDescriptor = new ga::MetricDescriptor(),
                ProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
            };
            ga::MetricDescriptor expectedResponse = new ga::MetricDescriptor
            {
                Name = "name1c9368b0",
                Labels =
                {
                    new ga::LabelDescriptor(),
                },
                MetricKind = ga::MetricDescriptor.Types.MetricKind.Gauge,
                ValueType = ga::MetricDescriptor.Types.ValueType.Money,
                Unit = "unitebbd343e",
                Description = "description2cf9da67",
                DisplayName = "display_name137f65c2",
                Type = "typee2cc9d59",
                Metadata = new ga::MetricDescriptor.Types.MetricDescriptorMetadata(),
                LaunchStage = ga::LaunchStage.Unspecified,
                MonitoredResourceTypes =
                {
                    "monitored_resource_typesc49bdc0a",
                },
            };
            mockGrpcClient.Setup(x => x.CreateMetricDescriptorAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ga::MetricDescriptor>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MetricServiceClient client = new MetricServiceClientImpl(mockGrpcClient.Object, null);
            ga::MetricDescriptor responseCallSettings = await client.CreateMetricDescriptorAsync(request.FolderName, request.MetricDescriptor, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ga::MetricDescriptor responseCancellationToken = await client.CreateMetricDescriptorAsync(request.FolderName, request.MetricDescriptor, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateMetricDescriptorResourceNames4()
        {
            moq::Mock<MetricService.MetricServiceClient> mockGrpcClient = new moq::Mock<MetricService.MetricServiceClient>(moq::MockBehavior.Strict);
            CreateMetricDescriptorRequest request = new CreateMetricDescriptorRequest
            {
                MetricDescriptor = new ga::MetricDescriptor(),
                ProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
            };
            ga::MetricDescriptor expectedResponse = new ga::MetricDescriptor
            {
                Name = "name1c9368b0",
                Labels =
                {
                    new ga::LabelDescriptor(),
                },
                MetricKind = ga::MetricDescriptor.Types.MetricKind.Gauge,
                ValueType = ga::MetricDescriptor.Types.ValueType.Money,
                Unit = "unitebbd343e",
                Description = "description2cf9da67",
                DisplayName = "display_name137f65c2",
                Type = "typee2cc9d59",
                Metadata = new ga::MetricDescriptor.Types.MetricDescriptorMetadata(),
                LaunchStage = ga::LaunchStage.Unspecified,
                MonitoredResourceTypes =
                {
                    "monitored_resource_typesc49bdc0a",
                },
            };
            mockGrpcClient.Setup(x => x.CreateMetricDescriptor(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MetricServiceClient client = new MetricServiceClientImpl(mockGrpcClient.Object, null);
            ga::MetricDescriptor response = client.CreateMetricDescriptor(request.ResourceName, request.MetricDescriptor);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateMetricDescriptorResourceNames4Async()
        {
            moq::Mock<MetricService.MetricServiceClient> mockGrpcClient = new moq::Mock<MetricService.MetricServiceClient>(moq::MockBehavior.Strict);
            CreateMetricDescriptorRequest request = new CreateMetricDescriptorRequest
            {
                MetricDescriptor = new ga::MetricDescriptor(),
                ProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
            };
            ga::MetricDescriptor expectedResponse = new ga::MetricDescriptor
            {
                Name = "name1c9368b0",
                Labels =
                {
                    new ga::LabelDescriptor(),
                },
                MetricKind = ga::MetricDescriptor.Types.MetricKind.Gauge,
                ValueType = ga::MetricDescriptor.Types.ValueType.Money,
                Unit = "unitebbd343e",
                Description = "description2cf9da67",
                DisplayName = "display_name137f65c2",
                Type = "typee2cc9d59",
                Metadata = new ga::MetricDescriptor.Types.MetricDescriptorMetadata(),
                LaunchStage = ga::LaunchStage.Unspecified,
                MonitoredResourceTypes =
                {
                    "monitored_resource_typesc49bdc0a",
                },
            };
            mockGrpcClient.Setup(x => x.CreateMetricDescriptorAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ga::MetricDescriptor>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MetricServiceClient client = new MetricServiceClientImpl(mockGrpcClient.Object, null);
            ga::MetricDescriptor responseCallSettings = await client.CreateMetricDescriptorAsync(request.ResourceName, request.MetricDescriptor, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ga::MetricDescriptor responseCancellationToken = await client.CreateMetricDescriptorAsync(request.ResourceName, request.MetricDescriptor, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteMetricDescriptorRequestObject()
        {
            moq::Mock<MetricService.MetricServiceClient> mockGrpcClient = new moq::Mock<MetricService.MetricServiceClient>(moq::MockBehavior.Strict);
            DeleteMetricDescriptorRequest request = new DeleteMetricDescriptorRequest
            {
                MetricDescriptorName = MetricDescriptorName.FromProjectMetricDescriptor("[PROJECT]", "[METRIC_DESCRIPTOR]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteMetricDescriptor(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MetricServiceClient client = new MetricServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteMetricDescriptor(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteMetricDescriptorRequestObjectAsync()
        {
            moq::Mock<MetricService.MetricServiceClient> mockGrpcClient = new moq::Mock<MetricService.MetricServiceClient>(moq::MockBehavior.Strict);
            DeleteMetricDescriptorRequest request = new DeleteMetricDescriptorRequest
            {
                MetricDescriptorName = MetricDescriptorName.FromProjectMetricDescriptor("[PROJECT]", "[METRIC_DESCRIPTOR]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteMetricDescriptorAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MetricServiceClient client = new MetricServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteMetricDescriptorAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteMetricDescriptorAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteMetricDescriptor()
        {
            moq::Mock<MetricService.MetricServiceClient> mockGrpcClient = new moq::Mock<MetricService.MetricServiceClient>(moq::MockBehavior.Strict);
            DeleteMetricDescriptorRequest request = new DeleteMetricDescriptorRequest
            {
                MetricDescriptorName = MetricDescriptorName.FromProjectMetricDescriptor("[PROJECT]", "[METRIC_DESCRIPTOR]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteMetricDescriptor(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MetricServiceClient client = new MetricServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteMetricDescriptor(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteMetricDescriptorAsync()
        {
            moq::Mock<MetricService.MetricServiceClient> mockGrpcClient = new moq::Mock<MetricService.MetricServiceClient>(moq::MockBehavior.Strict);
            DeleteMetricDescriptorRequest request = new DeleteMetricDescriptorRequest
            {
                MetricDescriptorName = MetricDescriptorName.FromProjectMetricDescriptor("[PROJECT]", "[METRIC_DESCRIPTOR]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteMetricDescriptorAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MetricServiceClient client = new MetricServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteMetricDescriptorAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteMetricDescriptorAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteMetricDescriptorResourceNames1()
        {
            moq::Mock<MetricService.MetricServiceClient> mockGrpcClient = new moq::Mock<MetricService.MetricServiceClient>(moq::MockBehavior.Strict);
            DeleteMetricDescriptorRequest request = new DeleteMetricDescriptorRequest
            {
                MetricDescriptorName = MetricDescriptorName.FromProjectMetricDescriptor("[PROJECT]", "[METRIC_DESCRIPTOR]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteMetricDescriptor(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MetricServiceClient client = new MetricServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteMetricDescriptor(request.MetricDescriptorName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteMetricDescriptorResourceNames1Async()
        {
            moq::Mock<MetricService.MetricServiceClient> mockGrpcClient = new moq::Mock<MetricService.MetricServiceClient>(moq::MockBehavior.Strict);
            DeleteMetricDescriptorRequest request = new DeleteMetricDescriptorRequest
            {
                MetricDescriptorName = MetricDescriptorName.FromProjectMetricDescriptor("[PROJECT]", "[METRIC_DESCRIPTOR]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteMetricDescriptorAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MetricServiceClient client = new MetricServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteMetricDescriptorAsync(request.MetricDescriptorName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteMetricDescriptorAsync(request.MetricDescriptorName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteMetricDescriptorResourceNames2()
        {
            moq::Mock<MetricService.MetricServiceClient> mockGrpcClient = new moq::Mock<MetricService.MetricServiceClient>(moq::MockBehavior.Strict);
            DeleteMetricDescriptorRequest request = new DeleteMetricDescriptorRequest
            {
                MetricDescriptorName = MetricDescriptorName.FromProjectMetricDescriptor("[PROJECT]", "[METRIC_DESCRIPTOR]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteMetricDescriptor(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MetricServiceClient client = new MetricServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteMetricDescriptor(request.ResourceName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteMetricDescriptorResourceNames2Async()
        {
            moq::Mock<MetricService.MetricServiceClient> mockGrpcClient = new moq::Mock<MetricService.MetricServiceClient>(moq::MockBehavior.Strict);
            DeleteMetricDescriptorRequest request = new DeleteMetricDescriptorRequest
            {
                MetricDescriptorName = MetricDescriptorName.FromProjectMetricDescriptor("[PROJECT]", "[METRIC_DESCRIPTOR]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteMetricDescriptorAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MetricServiceClient client = new MetricServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteMetricDescriptorAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteMetricDescriptorAsync(request.ResourceName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateTimeSeriesRequestObject()
        {
            moq::Mock<MetricService.MetricServiceClient> mockGrpcClient = new moq::Mock<MetricService.MetricServiceClient>(moq::MockBehavior.Strict);
            CreateTimeSeriesRequest request = new CreateTimeSeriesRequest
            {
                TimeSeries = { new TimeSeries(), },
                ProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.CreateTimeSeries(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MetricServiceClient client = new MetricServiceClientImpl(mockGrpcClient.Object, null);
            client.CreateTimeSeries(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateTimeSeriesRequestObjectAsync()
        {
            moq::Mock<MetricService.MetricServiceClient> mockGrpcClient = new moq::Mock<MetricService.MetricServiceClient>(moq::MockBehavior.Strict);
            CreateTimeSeriesRequest request = new CreateTimeSeriesRequest
            {
                TimeSeries = { new TimeSeries(), },
                ProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.CreateTimeSeriesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MetricServiceClient client = new MetricServiceClientImpl(mockGrpcClient.Object, null);
            await client.CreateTimeSeriesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.CreateTimeSeriesAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateTimeSeries()
        {
            moq::Mock<MetricService.MetricServiceClient> mockGrpcClient = new moq::Mock<MetricService.MetricServiceClient>(moq::MockBehavior.Strict);
            CreateTimeSeriesRequest request = new CreateTimeSeriesRequest
            {
                TimeSeries = { new TimeSeries(), },
                ProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.CreateTimeSeries(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MetricServiceClient client = new MetricServiceClientImpl(mockGrpcClient.Object, null);
            client.CreateTimeSeries(request.Name, request.TimeSeries);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateTimeSeriesAsync()
        {
            moq::Mock<MetricService.MetricServiceClient> mockGrpcClient = new moq::Mock<MetricService.MetricServiceClient>(moq::MockBehavior.Strict);
            CreateTimeSeriesRequest request = new CreateTimeSeriesRequest
            {
                TimeSeries = { new TimeSeries(), },
                ProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.CreateTimeSeriesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MetricServiceClient client = new MetricServiceClientImpl(mockGrpcClient.Object, null);
            await client.CreateTimeSeriesAsync(request.Name, request.TimeSeries, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.CreateTimeSeriesAsync(request.Name, request.TimeSeries, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateTimeSeriesResourceNames()
        {
            moq::Mock<MetricService.MetricServiceClient> mockGrpcClient = new moq::Mock<MetricService.MetricServiceClient>(moq::MockBehavior.Strict);
            CreateTimeSeriesRequest request = new CreateTimeSeriesRequest
            {
                TimeSeries = { new TimeSeries(), },
                ProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.CreateTimeSeries(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MetricServiceClient client = new MetricServiceClientImpl(mockGrpcClient.Object, null);
            client.CreateTimeSeries(request.ProjectName, request.TimeSeries);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateTimeSeriesResourceNamesAsync()
        {
            moq::Mock<MetricService.MetricServiceClient> mockGrpcClient = new moq::Mock<MetricService.MetricServiceClient>(moq::MockBehavior.Strict);
            CreateTimeSeriesRequest request = new CreateTimeSeriesRequest
            {
                TimeSeries = { new TimeSeries(), },
                ProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.CreateTimeSeriesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MetricServiceClient client = new MetricServiceClientImpl(mockGrpcClient.Object, null);
            await client.CreateTimeSeriesAsync(request.ProjectName, request.TimeSeries, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.CreateTimeSeriesAsync(request.ProjectName, request.TimeSeries, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateServiceTimeSeriesRequestObject()
        {
            moq::Mock<MetricService.MetricServiceClient> mockGrpcClient = new moq::Mock<MetricService.MetricServiceClient>(moq::MockBehavior.Strict);
            CreateTimeSeriesRequest request = new CreateTimeSeriesRequest
            {
                TimeSeries = { new TimeSeries(), },
                ProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.CreateServiceTimeSeries(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MetricServiceClient client = new MetricServiceClientImpl(mockGrpcClient.Object, null);
            client.CreateServiceTimeSeries(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateServiceTimeSeriesRequestObjectAsync()
        {
            moq::Mock<MetricService.MetricServiceClient> mockGrpcClient = new moq::Mock<MetricService.MetricServiceClient>(moq::MockBehavior.Strict);
            CreateTimeSeriesRequest request = new CreateTimeSeriesRequest
            {
                TimeSeries = { new TimeSeries(), },
                ProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.CreateServiceTimeSeriesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MetricServiceClient client = new MetricServiceClientImpl(mockGrpcClient.Object, null);
            await client.CreateServiceTimeSeriesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.CreateServiceTimeSeriesAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateServiceTimeSeries()
        {
            moq::Mock<MetricService.MetricServiceClient> mockGrpcClient = new moq::Mock<MetricService.MetricServiceClient>(moq::MockBehavior.Strict);
            CreateTimeSeriesRequest request = new CreateTimeSeriesRequest
            {
                TimeSeries = { new TimeSeries(), },
                ProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.CreateServiceTimeSeries(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MetricServiceClient client = new MetricServiceClientImpl(mockGrpcClient.Object, null);
            client.CreateServiceTimeSeries(request.Name, request.TimeSeries);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateServiceTimeSeriesAsync()
        {
            moq::Mock<MetricService.MetricServiceClient> mockGrpcClient = new moq::Mock<MetricService.MetricServiceClient>(moq::MockBehavior.Strict);
            CreateTimeSeriesRequest request = new CreateTimeSeriesRequest
            {
                TimeSeries = { new TimeSeries(), },
                ProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.CreateServiceTimeSeriesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MetricServiceClient client = new MetricServiceClientImpl(mockGrpcClient.Object, null);
            await client.CreateServiceTimeSeriesAsync(request.Name, request.TimeSeries, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.CreateServiceTimeSeriesAsync(request.Name, request.TimeSeries, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateServiceTimeSeriesResourceNames()
        {
            moq::Mock<MetricService.MetricServiceClient> mockGrpcClient = new moq::Mock<MetricService.MetricServiceClient>(moq::MockBehavior.Strict);
            CreateTimeSeriesRequest request = new CreateTimeSeriesRequest
            {
                TimeSeries = { new TimeSeries(), },
                ProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.CreateServiceTimeSeries(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MetricServiceClient client = new MetricServiceClientImpl(mockGrpcClient.Object, null);
            client.CreateServiceTimeSeries(request.ProjectName, request.TimeSeries);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateServiceTimeSeriesResourceNamesAsync()
        {
            moq::Mock<MetricService.MetricServiceClient> mockGrpcClient = new moq::Mock<MetricService.MetricServiceClient>(moq::MockBehavior.Strict);
            CreateTimeSeriesRequest request = new CreateTimeSeriesRequest
            {
                TimeSeries = { new TimeSeries(), },
                ProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.CreateServiceTimeSeriesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MetricServiceClient client = new MetricServiceClientImpl(mockGrpcClient.Object, null);
            await client.CreateServiceTimeSeriesAsync(request.ProjectName, request.TimeSeries, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.CreateServiceTimeSeriesAsync(request.ProjectName, request.TimeSeries, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }
    }
}
