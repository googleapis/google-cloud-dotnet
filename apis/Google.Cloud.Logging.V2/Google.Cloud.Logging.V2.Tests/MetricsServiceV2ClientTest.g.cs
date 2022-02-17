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

namespace Google.Cloud.Logging.V2.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedMetricsServiceV2ClientTest
    {
        [xunit::FactAttribute]
        public void GetLogMetricRequestObject()
        {
            moq::Mock<MetricsServiceV2.MetricsServiceV2Client> mockGrpcClient = new moq::Mock<MetricsServiceV2.MetricsServiceV2Client>(moq::MockBehavior.Strict);
            GetLogMetricRequest request = new GetLogMetricRequest
            {
                MetricNameAsLogMetricName = LogMetricName.FromProjectMetric("[PROJECT]", "[METRIC]"),
            };
            LogMetric expectedResponse = new LogMetric
            {
                LogMetricName = LogMetricName.FromProjectMetric("[PROJECT]", "[METRIC]"),
                Description = "description2cf9da67",
                Filter = "filtere47ac9b2",
#pragma warning disable CS0612
                Version = LogMetric.Types.ApiVersion.V2,
#pragma warning restore CS0612
                MetricDescriptor = new ga::MetricDescriptor(),
                ValueExtractor = "value_extractor09b994a6",
                LabelExtractors =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                BucketOptions = new ga::Distribution.Types.BucketOptions(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Disabled = false,
            };
            mockGrpcClient.Setup(x => x.GetLogMetric(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MetricsServiceV2Client client = new MetricsServiceV2ClientImpl(mockGrpcClient.Object, null);
            LogMetric response = client.GetLogMetric(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetLogMetricRequestObjectAsync()
        {
            moq::Mock<MetricsServiceV2.MetricsServiceV2Client> mockGrpcClient = new moq::Mock<MetricsServiceV2.MetricsServiceV2Client>(moq::MockBehavior.Strict);
            GetLogMetricRequest request = new GetLogMetricRequest
            {
                MetricNameAsLogMetricName = LogMetricName.FromProjectMetric("[PROJECT]", "[METRIC]"),
            };
            LogMetric expectedResponse = new LogMetric
            {
                LogMetricName = LogMetricName.FromProjectMetric("[PROJECT]", "[METRIC]"),
                Description = "description2cf9da67",
                Filter = "filtere47ac9b2",
#pragma warning disable CS0612
                Version = LogMetric.Types.ApiVersion.V2,
#pragma warning restore CS0612
                MetricDescriptor = new ga::MetricDescriptor(),
                ValueExtractor = "value_extractor09b994a6",
                LabelExtractors =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                BucketOptions = new ga::Distribution.Types.BucketOptions(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Disabled = false,
            };
            mockGrpcClient.Setup(x => x.GetLogMetricAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<LogMetric>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MetricsServiceV2Client client = new MetricsServiceV2ClientImpl(mockGrpcClient.Object, null);
            LogMetric responseCallSettings = await client.GetLogMetricAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            LogMetric responseCancellationToken = await client.GetLogMetricAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetLogMetric()
        {
            moq::Mock<MetricsServiceV2.MetricsServiceV2Client> mockGrpcClient = new moq::Mock<MetricsServiceV2.MetricsServiceV2Client>(moq::MockBehavior.Strict);
            GetLogMetricRequest request = new GetLogMetricRequest
            {
                MetricNameAsLogMetricName = LogMetricName.FromProjectMetric("[PROJECT]", "[METRIC]"),
            };
            LogMetric expectedResponse = new LogMetric
            {
                LogMetricName = LogMetricName.FromProjectMetric("[PROJECT]", "[METRIC]"),
                Description = "description2cf9da67",
                Filter = "filtere47ac9b2",
#pragma warning disable CS0612
                Version = LogMetric.Types.ApiVersion.V2,
#pragma warning restore CS0612
                MetricDescriptor = new ga::MetricDescriptor(),
                ValueExtractor = "value_extractor09b994a6",
                LabelExtractors =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                BucketOptions = new ga::Distribution.Types.BucketOptions(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Disabled = false,
            };
            mockGrpcClient.Setup(x => x.GetLogMetric(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MetricsServiceV2Client client = new MetricsServiceV2ClientImpl(mockGrpcClient.Object, null);
            LogMetric response = client.GetLogMetric(request.MetricName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetLogMetricAsync()
        {
            moq::Mock<MetricsServiceV2.MetricsServiceV2Client> mockGrpcClient = new moq::Mock<MetricsServiceV2.MetricsServiceV2Client>(moq::MockBehavior.Strict);
            GetLogMetricRequest request = new GetLogMetricRequest
            {
                MetricNameAsLogMetricName = LogMetricName.FromProjectMetric("[PROJECT]", "[METRIC]"),
            };
            LogMetric expectedResponse = new LogMetric
            {
                LogMetricName = LogMetricName.FromProjectMetric("[PROJECT]", "[METRIC]"),
                Description = "description2cf9da67",
                Filter = "filtere47ac9b2",
#pragma warning disable CS0612
                Version = LogMetric.Types.ApiVersion.V2,
#pragma warning restore CS0612
                MetricDescriptor = new ga::MetricDescriptor(),
                ValueExtractor = "value_extractor09b994a6",
                LabelExtractors =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                BucketOptions = new ga::Distribution.Types.BucketOptions(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Disabled = false,
            };
            mockGrpcClient.Setup(x => x.GetLogMetricAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<LogMetric>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MetricsServiceV2Client client = new MetricsServiceV2ClientImpl(mockGrpcClient.Object, null);
            LogMetric responseCallSettings = await client.GetLogMetricAsync(request.MetricName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            LogMetric responseCancellationToken = await client.GetLogMetricAsync(request.MetricName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetLogMetricResourceNames()
        {
            moq::Mock<MetricsServiceV2.MetricsServiceV2Client> mockGrpcClient = new moq::Mock<MetricsServiceV2.MetricsServiceV2Client>(moq::MockBehavior.Strict);
            GetLogMetricRequest request = new GetLogMetricRequest
            {
                MetricNameAsLogMetricName = LogMetricName.FromProjectMetric("[PROJECT]", "[METRIC]"),
            };
            LogMetric expectedResponse = new LogMetric
            {
                LogMetricName = LogMetricName.FromProjectMetric("[PROJECT]", "[METRIC]"),
                Description = "description2cf9da67",
                Filter = "filtere47ac9b2",
#pragma warning disable CS0612
                Version = LogMetric.Types.ApiVersion.V2,
#pragma warning restore CS0612
                MetricDescriptor = new ga::MetricDescriptor(),
                ValueExtractor = "value_extractor09b994a6",
                LabelExtractors =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                BucketOptions = new ga::Distribution.Types.BucketOptions(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Disabled = false,
            };
            mockGrpcClient.Setup(x => x.GetLogMetric(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MetricsServiceV2Client client = new MetricsServiceV2ClientImpl(mockGrpcClient.Object, null);
            LogMetric response = client.GetLogMetric(request.MetricNameAsLogMetricName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetLogMetricResourceNamesAsync()
        {
            moq::Mock<MetricsServiceV2.MetricsServiceV2Client> mockGrpcClient = new moq::Mock<MetricsServiceV2.MetricsServiceV2Client>(moq::MockBehavior.Strict);
            GetLogMetricRequest request = new GetLogMetricRequest
            {
                MetricNameAsLogMetricName = LogMetricName.FromProjectMetric("[PROJECT]", "[METRIC]"),
            };
            LogMetric expectedResponse = new LogMetric
            {
                LogMetricName = LogMetricName.FromProjectMetric("[PROJECT]", "[METRIC]"),
                Description = "description2cf9da67",
                Filter = "filtere47ac9b2",
#pragma warning disable CS0612
                Version = LogMetric.Types.ApiVersion.V2,
#pragma warning restore CS0612
                MetricDescriptor = new ga::MetricDescriptor(),
                ValueExtractor = "value_extractor09b994a6",
                LabelExtractors =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                BucketOptions = new ga::Distribution.Types.BucketOptions(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Disabled = false,
            };
            mockGrpcClient.Setup(x => x.GetLogMetricAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<LogMetric>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MetricsServiceV2Client client = new MetricsServiceV2ClientImpl(mockGrpcClient.Object, null);
            LogMetric responseCallSettings = await client.GetLogMetricAsync(request.MetricNameAsLogMetricName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            LogMetric responseCancellationToken = await client.GetLogMetricAsync(request.MetricNameAsLogMetricName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateLogMetricRequestObject()
        {
            moq::Mock<MetricsServiceV2.MetricsServiceV2Client> mockGrpcClient = new moq::Mock<MetricsServiceV2.MetricsServiceV2Client>(moq::MockBehavior.Strict);
            CreateLogMetricRequest request = new CreateLogMetricRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Metric = new LogMetric(),
            };
            LogMetric expectedResponse = new LogMetric
            {
                LogMetricName = LogMetricName.FromProjectMetric("[PROJECT]", "[METRIC]"),
                Description = "description2cf9da67",
                Filter = "filtere47ac9b2",
#pragma warning disable CS0612
                Version = LogMetric.Types.ApiVersion.V2,
#pragma warning restore CS0612
                MetricDescriptor = new ga::MetricDescriptor(),
                ValueExtractor = "value_extractor09b994a6",
                LabelExtractors =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                BucketOptions = new ga::Distribution.Types.BucketOptions(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Disabled = false,
            };
            mockGrpcClient.Setup(x => x.CreateLogMetric(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MetricsServiceV2Client client = new MetricsServiceV2ClientImpl(mockGrpcClient.Object, null);
            LogMetric response = client.CreateLogMetric(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateLogMetricRequestObjectAsync()
        {
            moq::Mock<MetricsServiceV2.MetricsServiceV2Client> mockGrpcClient = new moq::Mock<MetricsServiceV2.MetricsServiceV2Client>(moq::MockBehavior.Strict);
            CreateLogMetricRequest request = new CreateLogMetricRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Metric = new LogMetric(),
            };
            LogMetric expectedResponse = new LogMetric
            {
                LogMetricName = LogMetricName.FromProjectMetric("[PROJECT]", "[METRIC]"),
                Description = "description2cf9da67",
                Filter = "filtere47ac9b2",
#pragma warning disable CS0612
                Version = LogMetric.Types.ApiVersion.V2,
#pragma warning restore CS0612
                MetricDescriptor = new ga::MetricDescriptor(),
                ValueExtractor = "value_extractor09b994a6",
                LabelExtractors =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                BucketOptions = new ga::Distribution.Types.BucketOptions(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Disabled = false,
            };
            mockGrpcClient.Setup(x => x.CreateLogMetricAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<LogMetric>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MetricsServiceV2Client client = new MetricsServiceV2ClientImpl(mockGrpcClient.Object, null);
            LogMetric responseCallSettings = await client.CreateLogMetricAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            LogMetric responseCancellationToken = await client.CreateLogMetricAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateLogMetric()
        {
            moq::Mock<MetricsServiceV2.MetricsServiceV2Client> mockGrpcClient = new moq::Mock<MetricsServiceV2.MetricsServiceV2Client>(moq::MockBehavior.Strict);
            CreateLogMetricRequest request = new CreateLogMetricRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Metric = new LogMetric(),
            };
            LogMetric expectedResponse = new LogMetric
            {
                LogMetricName = LogMetricName.FromProjectMetric("[PROJECT]", "[METRIC]"),
                Description = "description2cf9da67",
                Filter = "filtere47ac9b2",
#pragma warning disable CS0612
                Version = LogMetric.Types.ApiVersion.V2,
#pragma warning restore CS0612
                MetricDescriptor = new ga::MetricDescriptor(),
                ValueExtractor = "value_extractor09b994a6",
                LabelExtractors =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                BucketOptions = new ga::Distribution.Types.BucketOptions(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Disabled = false,
            };
            mockGrpcClient.Setup(x => x.CreateLogMetric(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MetricsServiceV2Client client = new MetricsServiceV2ClientImpl(mockGrpcClient.Object, null);
            LogMetric response = client.CreateLogMetric(request.Parent, request.Metric);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateLogMetricAsync()
        {
            moq::Mock<MetricsServiceV2.MetricsServiceV2Client> mockGrpcClient = new moq::Mock<MetricsServiceV2.MetricsServiceV2Client>(moq::MockBehavior.Strict);
            CreateLogMetricRequest request = new CreateLogMetricRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Metric = new LogMetric(),
            };
            LogMetric expectedResponse = new LogMetric
            {
                LogMetricName = LogMetricName.FromProjectMetric("[PROJECT]", "[METRIC]"),
                Description = "description2cf9da67",
                Filter = "filtere47ac9b2",
#pragma warning disable CS0612
                Version = LogMetric.Types.ApiVersion.V2,
#pragma warning restore CS0612
                MetricDescriptor = new ga::MetricDescriptor(),
                ValueExtractor = "value_extractor09b994a6",
                LabelExtractors =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                BucketOptions = new ga::Distribution.Types.BucketOptions(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Disabled = false,
            };
            mockGrpcClient.Setup(x => x.CreateLogMetricAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<LogMetric>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MetricsServiceV2Client client = new MetricsServiceV2ClientImpl(mockGrpcClient.Object, null);
            LogMetric responseCallSettings = await client.CreateLogMetricAsync(request.Parent, request.Metric, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            LogMetric responseCancellationToken = await client.CreateLogMetricAsync(request.Parent, request.Metric, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateLogMetricResourceNames()
        {
            moq::Mock<MetricsServiceV2.MetricsServiceV2Client> mockGrpcClient = new moq::Mock<MetricsServiceV2.MetricsServiceV2Client>(moq::MockBehavior.Strict);
            CreateLogMetricRequest request = new CreateLogMetricRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Metric = new LogMetric(),
            };
            LogMetric expectedResponse = new LogMetric
            {
                LogMetricName = LogMetricName.FromProjectMetric("[PROJECT]", "[METRIC]"),
                Description = "description2cf9da67",
                Filter = "filtere47ac9b2",
#pragma warning disable CS0612
                Version = LogMetric.Types.ApiVersion.V2,
#pragma warning restore CS0612
                MetricDescriptor = new ga::MetricDescriptor(),
                ValueExtractor = "value_extractor09b994a6",
                LabelExtractors =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                BucketOptions = new ga::Distribution.Types.BucketOptions(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Disabled = false,
            };
            mockGrpcClient.Setup(x => x.CreateLogMetric(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MetricsServiceV2Client client = new MetricsServiceV2ClientImpl(mockGrpcClient.Object, null);
            LogMetric response = client.CreateLogMetric(request.ParentAsProjectName, request.Metric);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateLogMetricResourceNamesAsync()
        {
            moq::Mock<MetricsServiceV2.MetricsServiceV2Client> mockGrpcClient = new moq::Mock<MetricsServiceV2.MetricsServiceV2Client>(moq::MockBehavior.Strict);
            CreateLogMetricRequest request = new CreateLogMetricRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Metric = new LogMetric(),
            };
            LogMetric expectedResponse = new LogMetric
            {
                LogMetricName = LogMetricName.FromProjectMetric("[PROJECT]", "[METRIC]"),
                Description = "description2cf9da67",
                Filter = "filtere47ac9b2",
#pragma warning disable CS0612
                Version = LogMetric.Types.ApiVersion.V2,
#pragma warning restore CS0612
                MetricDescriptor = new ga::MetricDescriptor(),
                ValueExtractor = "value_extractor09b994a6",
                LabelExtractors =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                BucketOptions = new ga::Distribution.Types.BucketOptions(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Disabled = false,
            };
            mockGrpcClient.Setup(x => x.CreateLogMetricAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<LogMetric>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MetricsServiceV2Client client = new MetricsServiceV2ClientImpl(mockGrpcClient.Object, null);
            LogMetric responseCallSettings = await client.CreateLogMetricAsync(request.ParentAsProjectName, request.Metric, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            LogMetric responseCancellationToken = await client.CreateLogMetricAsync(request.ParentAsProjectName, request.Metric, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateLogMetricRequestObject()
        {
            moq::Mock<MetricsServiceV2.MetricsServiceV2Client> mockGrpcClient = new moq::Mock<MetricsServiceV2.MetricsServiceV2Client>(moq::MockBehavior.Strict);
            UpdateLogMetricRequest request = new UpdateLogMetricRequest
            {
                MetricNameAsLogMetricName = LogMetricName.FromProjectMetric("[PROJECT]", "[METRIC]"),
                Metric = new LogMetric(),
            };
            LogMetric expectedResponse = new LogMetric
            {
                LogMetricName = LogMetricName.FromProjectMetric("[PROJECT]", "[METRIC]"),
                Description = "description2cf9da67",
                Filter = "filtere47ac9b2",
#pragma warning disable CS0612
                Version = LogMetric.Types.ApiVersion.V2,
#pragma warning restore CS0612
                MetricDescriptor = new ga::MetricDescriptor(),
                ValueExtractor = "value_extractor09b994a6",
                LabelExtractors =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                BucketOptions = new ga::Distribution.Types.BucketOptions(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Disabled = false,
            };
            mockGrpcClient.Setup(x => x.UpdateLogMetric(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MetricsServiceV2Client client = new MetricsServiceV2ClientImpl(mockGrpcClient.Object, null);
            LogMetric response = client.UpdateLogMetric(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateLogMetricRequestObjectAsync()
        {
            moq::Mock<MetricsServiceV2.MetricsServiceV2Client> mockGrpcClient = new moq::Mock<MetricsServiceV2.MetricsServiceV2Client>(moq::MockBehavior.Strict);
            UpdateLogMetricRequest request = new UpdateLogMetricRequest
            {
                MetricNameAsLogMetricName = LogMetricName.FromProjectMetric("[PROJECT]", "[METRIC]"),
                Metric = new LogMetric(),
            };
            LogMetric expectedResponse = new LogMetric
            {
                LogMetricName = LogMetricName.FromProjectMetric("[PROJECT]", "[METRIC]"),
                Description = "description2cf9da67",
                Filter = "filtere47ac9b2",
#pragma warning disable CS0612
                Version = LogMetric.Types.ApiVersion.V2,
#pragma warning restore CS0612
                MetricDescriptor = new ga::MetricDescriptor(),
                ValueExtractor = "value_extractor09b994a6",
                LabelExtractors =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                BucketOptions = new ga::Distribution.Types.BucketOptions(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Disabled = false,
            };
            mockGrpcClient.Setup(x => x.UpdateLogMetricAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<LogMetric>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MetricsServiceV2Client client = new MetricsServiceV2ClientImpl(mockGrpcClient.Object, null);
            LogMetric responseCallSettings = await client.UpdateLogMetricAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            LogMetric responseCancellationToken = await client.UpdateLogMetricAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateLogMetric()
        {
            moq::Mock<MetricsServiceV2.MetricsServiceV2Client> mockGrpcClient = new moq::Mock<MetricsServiceV2.MetricsServiceV2Client>(moq::MockBehavior.Strict);
            UpdateLogMetricRequest request = new UpdateLogMetricRequest
            {
                MetricNameAsLogMetricName = LogMetricName.FromProjectMetric("[PROJECT]", "[METRIC]"),
                Metric = new LogMetric(),
            };
            LogMetric expectedResponse = new LogMetric
            {
                LogMetricName = LogMetricName.FromProjectMetric("[PROJECT]", "[METRIC]"),
                Description = "description2cf9da67",
                Filter = "filtere47ac9b2",
#pragma warning disable CS0612
                Version = LogMetric.Types.ApiVersion.V2,
#pragma warning restore CS0612
                MetricDescriptor = new ga::MetricDescriptor(),
                ValueExtractor = "value_extractor09b994a6",
                LabelExtractors =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                BucketOptions = new ga::Distribution.Types.BucketOptions(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Disabled = false,
            };
            mockGrpcClient.Setup(x => x.UpdateLogMetric(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MetricsServiceV2Client client = new MetricsServiceV2ClientImpl(mockGrpcClient.Object, null);
            LogMetric response = client.UpdateLogMetric(request.MetricName, request.Metric);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateLogMetricAsync()
        {
            moq::Mock<MetricsServiceV2.MetricsServiceV2Client> mockGrpcClient = new moq::Mock<MetricsServiceV2.MetricsServiceV2Client>(moq::MockBehavior.Strict);
            UpdateLogMetricRequest request = new UpdateLogMetricRequest
            {
                MetricNameAsLogMetricName = LogMetricName.FromProjectMetric("[PROJECT]", "[METRIC]"),
                Metric = new LogMetric(),
            };
            LogMetric expectedResponse = new LogMetric
            {
                LogMetricName = LogMetricName.FromProjectMetric("[PROJECT]", "[METRIC]"),
                Description = "description2cf9da67",
                Filter = "filtere47ac9b2",
#pragma warning disable CS0612
                Version = LogMetric.Types.ApiVersion.V2,
#pragma warning restore CS0612
                MetricDescriptor = new ga::MetricDescriptor(),
                ValueExtractor = "value_extractor09b994a6",
                LabelExtractors =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                BucketOptions = new ga::Distribution.Types.BucketOptions(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Disabled = false,
            };
            mockGrpcClient.Setup(x => x.UpdateLogMetricAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<LogMetric>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MetricsServiceV2Client client = new MetricsServiceV2ClientImpl(mockGrpcClient.Object, null);
            LogMetric responseCallSettings = await client.UpdateLogMetricAsync(request.MetricName, request.Metric, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            LogMetric responseCancellationToken = await client.UpdateLogMetricAsync(request.MetricName, request.Metric, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateLogMetricResourceNames()
        {
            moq::Mock<MetricsServiceV2.MetricsServiceV2Client> mockGrpcClient = new moq::Mock<MetricsServiceV2.MetricsServiceV2Client>(moq::MockBehavior.Strict);
            UpdateLogMetricRequest request = new UpdateLogMetricRequest
            {
                MetricNameAsLogMetricName = LogMetricName.FromProjectMetric("[PROJECT]", "[METRIC]"),
                Metric = new LogMetric(),
            };
            LogMetric expectedResponse = new LogMetric
            {
                LogMetricName = LogMetricName.FromProjectMetric("[PROJECT]", "[METRIC]"),
                Description = "description2cf9da67",
                Filter = "filtere47ac9b2",
#pragma warning disable CS0612
                Version = LogMetric.Types.ApiVersion.V2,
#pragma warning restore CS0612
                MetricDescriptor = new ga::MetricDescriptor(),
                ValueExtractor = "value_extractor09b994a6",
                LabelExtractors =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                BucketOptions = new ga::Distribution.Types.BucketOptions(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Disabled = false,
            };
            mockGrpcClient.Setup(x => x.UpdateLogMetric(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MetricsServiceV2Client client = new MetricsServiceV2ClientImpl(mockGrpcClient.Object, null);
            LogMetric response = client.UpdateLogMetric(request.MetricNameAsLogMetricName, request.Metric);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateLogMetricResourceNamesAsync()
        {
            moq::Mock<MetricsServiceV2.MetricsServiceV2Client> mockGrpcClient = new moq::Mock<MetricsServiceV2.MetricsServiceV2Client>(moq::MockBehavior.Strict);
            UpdateLogMetricRequest request = new UpdateLogMetricRequest
            {
                MetricNameAsLogMetricName = LogMetricName.FromProjectMetric("[PROJECT]", "[METRIC]"),
                Metric = new LogMetric(),
            };
            LogMetric expectedResponse = new LogMetric
            {
                LogMetricName = LogMetricName.FromProjectMetric("[PROJECT]", "[METRIC]"),
                Description = "description2cf9da67",
                Filter = "filtere47ac9b2",
#pragma warning disable CS0612
                Version = LogMetric.Types.ApiVersion.V2,
#pragma warning restore CS0612
                MetricDescriptor = new ga::MetricDescriptor(),
                ValueExtractor = "value_extractor09b994a6",
                LabelExtractors =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                BucketOptions = new ga::Distribution.Types.BucketOptions(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Disabled = false,
            };
            mockGrpcClient.Setup(x => x.UpdateLogMetricAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<LogMetric>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MetricsServiceV2Client client = new MetricsServiceV2ClientImpl(mockGrpcClient.Object, null);
            LogMetric responseCallSettings = await client.UpdateLogMetricAsync(request.MetricNameAsLogMetricName, request.Metric, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            LogMetric responseCancellationToken = await client.UpdateLogMetricAsync(request.MetricNameAsLogMetricName, request.Metric, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteLogMetricRequestObject()
        {
            moq::Mock<MetricsServiceV2.MetricsServiceV2Client> mockGrpcClient = new moq::Mock<MetricsServiceV2.MetricsServiceV2Client>(moq::MockBehavior.Strict);
            DeleteLogMetricRequest request = new DeleteLogMetricRequest
            {
                MetricNameAsLogMetricName = LogMetricName.FromProjectMetric("[PROJECT]", "[METRIC]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteLogMetric(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MetricsServiceV2Client client = new MetricsServiceV2ClientImpl(mockGrpcClient.Object, null);
            client.DeleteLogMetric(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteLogMetricRequestObjectAsync()
        {
            moq::Mock<MetricsServiceV2.MetricsServiceV2Client> mockGrpcClient = new moq::Mock<MetricsServiceV2.MetricsServiceV2Client>(moq::MockBehavior.Strict);
            DeleteLogMetricRequest request = new DeleteLogMetricRequest
            {
                MetricNameAsLogMetricName = LogMetricName.FromProjectMetric("[PROJECT]", "[METRIC]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteLogMetricAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MetricsServiceV2Client client = new MetricsServiceV2ClientImpl(mockGrpcClient.Object, null);
            await client.DeleteLogMetricAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteLogMetricAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteLogMetric()
        {
            moq::Mock<MetricsServiceV2.MetricsServiceV2Client> mockGrpcClient = new moq::Mock<MetricsServiceV2.MetricsServiceV2Client>(moq::MockBehavior.Strict);
            DeleteLogMetricRequest request = new DeleteLogMetricRequest
            {
                MetricNameAsLogMetricName = LogMetricName.FromProjectMetric("[PROJECT]", "[METRIC]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteLogMetric(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MetricsServiceV2Client client = new MetricsServiceV2ClientImpl(mockGrpcClient.Object, null);
            client.DeleteLogMetric(request.MetricName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteLogMetricAsync()
        {
            moq::Mock<MetricsServiceV2.MetricsServiceV2Client> mockGrpcClient = new moq::Mock<MetricsServiceV2.MetricsServiceV2Client>(moq::MockBehavior.Strict);
            DeleteLogMetricRequest request = new DeleteLogMetricRequest
            {
                MetricNameAsLogMetricName = LogMetricName.FromProjectMetric("[PROJECT]", "[METRIC]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteLogMetricAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MetricsServiceV2Client client = new MetricsServiceV2ClientImpl(mockGrpcClient.Object, null);
            await client.DeleteLogMetricAsync(request.MetricName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteLogMetricAsync(request.MetricName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteLogMetricResourceNames()
        {
            moq::Mock<MetricsServiceV2.MetricsServiceV2Client> mockGrpcClient = new moq::Mock<MetricsServiceV2.MetricsServiceV2Client>(moq::MockBehavior.Strict);
            DeleteLogMetricRequest request = new DeleteLogMetricRequest
            {
                MetricNameAsLogMetricName = LogMetricName.FromProjectMetric("[PROJECT]", "[METRIC]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteLogMetric(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MetricsServiceV2Client client = new MetricsServiceV2ClientImpl(mockGrpcClient.Object, null);
            client.DeleteLogMetric(request.MetricNameAsLogMetricName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteLogMetricResourceNamesAsync()
        {
            moq::Mock<MetricsServiceV2.MetricsServiceV2Client> mockGrpcClient = new moq::Mock<MetricsServiceV2.MetricsServiceV2Client>(moq::MockBehavior.Strict);
            DeleteLogMetricRequest request = new DeleteLogMetricRequest
            {
                MetricNameAsLogMetricName = LogMetricName.FromProjectMetric("[PROJECT]", "[METRIC]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteLogMetricAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MetricsServiceV2Client client = new MetricsServiceV2ClientImpl(mockGrpcClient.Object, null);
            await client.DeleteLogMetricAsync(request.MetricNameAsLogMetricName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteLogMetricAsync(request.MetricNameAsLogMetricName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }
    }
}
