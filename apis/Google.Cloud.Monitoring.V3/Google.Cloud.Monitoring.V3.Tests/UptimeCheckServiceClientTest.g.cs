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
    public sealed class GeneratedUptimeCheckServiceClientTest
    {
        [xunit::FactAttribute]
        public void GetUptimeCheckConfigRequestObject()
        {
            moq::Mock<UptimeCheckService.UptimeCheckServiceClient> mockGrpcClient = new moq::Mock<UptimeCheckService.UptimeCheckServiceClient>(moq::MockBehavior.Strict);
            GetUptimeCheckConfigRequest request = new GetUptimeCheckConfigRequest
            {
                UptimeCheckConfigName = UptimeCheckConfigName.FromProjectUptimeCheckConfig("[PROJECT]", "[UPTIME_CHECK_CONFIG]"),
            };
            UptimeCheckConfig expectedResponse = new UptimeCheckConfig
            {
                UptimeCheckConfigName = UptimeCheckConfigName.FromProjectUptimeCheckConfig("[PROJECT]", "[UPTIME_CHECK_CONFIG]"),
                DisplayName = "display_name137f65c2",
                MonitoredResource = new ga::MonitoredResource(),
                ResourceGroup = new UptimeCheckConfig.Types.ResourceGroup(),
                HttpCheck = new UptimeCheckConfig.Types.HttpCheck(),
                TcpCheck = new UptimeCheckConfig.Types.TcpCheck(),
                Period = new wkt::Duration(),
                Timeout = new wkt::Duration(),
                ContentMatchers =
                {
                    new UptimeCheckConfig.Types.ContentMatcher(),
                },
                SelectedRegions =
                {
                    UptimeCheckRegion.RegionUnspecified,
                },
#pragma warning disable CS0612
                InternalCheckers =
#pragma warning restore CS0612
                {
#pragma warning disable CS0612
                    new InternalChecker(),
#pragma warning restore CS0612
                },
#pragma warning disable CS0612
                IsInternal = true,
#pragma warning restore CS0612
            };
            mockGrpcClient.Setup(x => x.GetUptimeCheckConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            UptimeCheckServiceClient client = new UptimeCheckServiceClientImpl(mockGrpcClient.Object, null);
            UptimeCheckConfig response = client.GetUptimeCheckConfig(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetUptimeCheckConfigRequestObjectAsync()
        {
            moq::Mock<UptimeCheckService.UptimeCheckServiceClient> mockGrpcClient = new moq::Mock<UptimeCheckService.UptimeCheckServiceClient>(moq::MockBehavior.Strict);
            GetUptimeCheckConfigRequest request = new GetUptimeCheckConfigRequest
            {
                UptimeCheckConfigName = UptimeCheckConfigName.FromProjectUptimeCheckConfig("[PROJECT]", "[UPTIME_CHECK_CONFIG]"),
            };
            UptimeCheckConfig expectedResponse = new UptimeCheckConfig
            {
                UptimeCheckConfigName = UptimeCheckConfigName.FromProjectUptimeCheckConfig("[PROJECT]", "[UPTIME_CHECK_CONFIG]"),
                DisplayName = "display_name137f65c2",
                MonitoredResource = new ga::MonitoredResource(),
                ResourceGroup = new UptimeCheckConfig.Types.ResourceGroup(),
                HttpCheck = new UptimeCheckConfig.Types.HttpCheck(),
                TcpCheck = new UptimeCheckConfig.Types.TcpCheck(),
                Period = new wkt::Duration(),
                Timeout = new wkt::Duration(),
                ContentMatchers =
                {
                    new UptimeCheckConfig.Types.ContentMatcher(),
                },
                SelectedRegions =
                {
                    UptimeCheckRegion.RegionUnspecified,
                },
#pragma warning disable CS0612
                InternalCheckers =
#pragma warning restore CS0612
                {
#pragma warning disable CS0612
                    new InternalChecker(),
#pragma warning restore CS0612
                },
#pragma warning disable CS0612
                IsInternal = true,
#pragma warning restore CS0612
            };
            mockGrpcClient.Setup(x => x.GetUptimeCheckConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<UptimeCheckConfig>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            UptimeCheckServiceClient client = new UptimeCheckServiceClientImpl(mockGrpcClient.Object, null);
            UptimeCheckConfig responseCallSettings = await client.GetUptimeCheckConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            UptimeCheckConfig responseCancellationToken = await client.GetUptimeCheckConfigAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetUptimeCheckConfig()
        {
            moq::Mock<UptimeCheckService.UptimeCheckServiceClient> mockGrpcClient = new moq::Mock<UptimeCheckService.UptimeCheckServiceClient>(moq::MockBehavior.Strict);
            GetUptimeCheckConfigRequest request = new GetUptimeCheckConfigRequest
            {
                UptimeCheckConfigName = UptimeCheckConfigName.FromProjectUptimeCheckConfig("[PROJECT]", "[UPTIME_CHECK_CONFIG]"),
            };
            UptimeCheckConfig expectedResponse = new UptimeCheckConfig
            {
                UptimeCheckConfigName = UptimeCheckConfigName.FromProjectUptimeCheckConfig("[PROJECT]", "[UPTIME_CHECK_CONFIG]"),
                DisplayName = "display_name137f65c2",
                MonitoredResource = new ga::MonitoredResource(),
                ResourceGroup = new UptimeCheckConfig.Types.ResourceGroup(),
                HttpCheck = new UptimeCheckConfig.Types.HttpCheck(),
                TcpCheck = new UptimeCheckConfig.Types.TcpCheck(),
                Period = new wkt::Duration(),
                Timeout = new wkt::Duration(),
                ContentMatchers =
                {
                    new UptimeCheckConfig.Types.ContentMatcher(),
                },
                SelectedRegions =
                {
                    UptimeCheckRegion.RegionUnspecified,
                },
#pragma warning disable CS0612
                InternalCheckers =
#pragma warning restore CS0612
                {
#pragma warning disable CS0612
                    new InternalChecker(),
#pragma warning restore CS0612
                },
#pragma warning disable CS0612
                IsInternal = true,
#pragma warning restore CS0612
            };
            mockGrpcClient.Setup(x => x.GetUptimeCheckConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            UptimeCheckServiceClient client = new UptimeCheckServiceClientImpl(mockGrpcClient.Object, null);
            UptimeCheckConfig response = client.GetUptimeCheckConfig(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetUptimeCheckConfigAsync()
        {
            moq::Mock<UptimeCheckService.UptimeCheckServiceClient> mockGrpcClient = new moq::Mock<UptimeCheckService.UptimeCheckServiceClient>(moq::MockBehavior.Strict);
            GetUptimeCheckConfigRequest request = new GetUptimeCheckConfigRequest
            {
                UptimeCheckConfigName = UptimeCheckConfigName.FromProjectUptimeCheckConfig("[PROJECT]", "[UPTIME_CHECK_CONFIG]"),
            };
            UptimeCheckConfig expectedResponse = new UptimeCheckConfig
            {
                UptimeCheckConfigName = UptimeCheckConfigName.FromProjectUptimeCheckConfig("[PROJECT]", "[UPTIME_CHECK_CONFIG]"),
                DisplayName = "display_name137f65c2",
                MonitoredResource = new ga::MonitoredResource(),
                ResourceGroup = new UptimeCheckConfig.Types.ResourceGroup(),
                HttpCheck = new UptimeCheckConfig.Types.HttpCheck(),
                TcpCheck = new UptimeCheckConfig.Types.TcpCheck(),
                Period = new wkt::Duration(),
                Timeout = new wkt::Duration(),
                ContentMatchers =
                {
                    new UptimeCheckConfig.Types.ContentMatcher(),
                },
                SelectedRegions =
                {
                    UptimeCheckRegion.RegionUnspecified,
                },
#pragma warning disable CS0612
                InternalCheckers =
#pragma warning restore CS0612
                {
#pragma warning disable CS0612
                    new InternalChecker(),
#pragma warning restore CS0612
                },
#pragma warning disable CS0612
                IsInternal = true,
#pragma warning restore CS0612
            };
            mockGrpcClient.Setup(x => x.GetUptimeCheckConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<UptimeCheckConfig>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            UptimeCheckServiceClient client = new UptimeCheckServiceClientImpl(mockGrpcClient.Object, null);
            UptimeCheckConfig responseCallSettings = await client.GetUptimeCheckConfigAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            UptimeCheckConfig responseCancellationToken = await client.GetUptimeCheckConfigAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetUptimeCheckConfigResourceNames1()
        {
            moq::Mock<UptimeCheckService.UptimeCheckServiceClient> mockGrpcClient = new moq::Mock<UptimeCheckService.UptimeCheckServiceClient>(moq::MockBehavior.Strict);
            GetUptimeCheckConfigRequest request = new GetUptimeCheckConfigRequest
            {
                UptimeCheckConfigName = UptimeCheckConfigName.FromProjectUptimeCheckConfig("[PROJECT]", "[UPTIME_CHECK_CONFIG]"),
            };
            UptimeCheckConfig expectedResponse = new UptimeCheckConfig
            {
                UptimeCheckConfigName = UptimeCheckConfigName.FromProjectUptimeCheckConfig("[PROJECT]", "[UPTIME_CHECK_CONFIG]"),
                DisplayName = "display_name137f65c2",
                MonitoredResource = new ga::MonitoredResource(),
                ResourceGroup = new UptimeCheckConfig.Types.ResourceGroup(),
                HttpCheck = new UptimeCheckConfig.Types.HttpCheck(),
                TcpCheck = new UptimeCheckConfig.Types.TcpCheck(),
                Period = new wkt::Duration(),
                Timeout = new wkt::Duration(),
                ContentMatchers =
                {
                    new UptimeCheckConfig.Types.ContentMatcher(),
                },
                SelectedRegions =
                {
                    UptimeCheckRegion.RegionUnspecified,
                },
#pragma warning disable CS0612
                InternalCheckers =
#pragma warning restore CS0612
                {
#pragma warning disable CS0612
                    new InternalChecker(),
#pragma warning restore CS0612
                },
#pragma warning disable CS0612
                IsInternal = true,
#pragma warning restore CS0612
            };
            mockGrpcClient.Setup(x => x.GetUptimeCheckConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            UptimeCheckServiceClient client = new UptimeCheckServiceClientImpl(mockGrpcClient.Object, null);
            UptimeCheckConfig response = client.GetUptimeCheckConfig(request.UptimeCheckConfigName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetUptimeCheckConfigResourceNames1Async()
        {
            moq::Mock<UptimeCheckService.UptimeCheckServiceClient> mockGrpcClient = new moq::Mock<UptimeCheckService.UptimeCheckServiceClient>(moq::MockBehavior.Strict);
            GetUptimeCheckConfigRequest request = new GetUptimeCheckConfigRequest
            {
                UptimeCheckConfigName = UptimeCheckConfigName.FromProjectUptimeCheckConfig("[PROJECT]", "[UPTIME_CHECK_CONFIG]"),
            };
            UptimeCheckConfig expectedResponse = new UptimeCheckConfig
            {
                UptimeCheckConfigName = UptimeCheckConfigName.FromProjectUptimeCheckConfig("[PROJECT]", "[UPTIME_CHECK_CONFIG]"),
                DisplayName = "display_name137f65c2",
                MonitoredResource = new ga::MonitoredResource(),
                ResourceGroup = new UptimeCheckConfig.Types.ResourceGroup(),
                HttpCheck = new UptimeCheckConfig.Types.HttpCheck(),
                TcpCheck = new UptimeCheckConfig.Types.TcpCheck(),
                Period = new wkt::Duration(),
                Timeout = new wkt::Duration(),
                ContentMatchers =
                {
                    new UptimeCheckConfig.Types.ContentMatcher(),
                },
                SelectedRegions =
                {
                    UptimeCheckRegion.RegionUnspecified,
                },
#pragma warning disable CS0612
                InternalCheckers =
#pragma warning restore CS0612
                {
#pragma warning disable CS0612
                    new InternalChecker(),
#pragma warning restore CS0612
                },
#pragma warning disable CS0612
                IsInternal = true,
#pragma warning restore CS0612
            };
            mockGrpcClient.Setup(x => x.GetUptimeCheckConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<UptimeCheckConfig>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            UptimeCheckServiceClient client = new UptimeCheckServiceClientImpl(mockGrpcClient.Object, null);
            UptimeCheckConfig responseCallSettings = await client.GetUptimeCheckConfigAsync(request.UptimeCheckConfigName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            UptimeCheckConfig responseCancellationToken = await client.GetUptimeCheckConfigAsync(request.UptimeCheckConfigName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetUptimeCheckConfigResourceNames2()
        {
            moq::Mock<UptimeCheckService.UptimeCheckServiceClient> mockGrpcClient = new moq::Mock<UptimeCheckService.UptimeCheckServiceClient>(moq::MockBehavior.Strict);
            GetUptimeCheckConfigRequest request = new GetUptimeCheckConfigRequest
            {
                UptimeCheckConfigName = UptimeCheckConfigName.FromProjectUptimeCheckConfig("[PROJECT]", "[UPTIME_CHECK_CONFIG]"),
            };
            UptimeCheckConfig expectedResponse = new UptimeCheckConfig
            {
                UptimeCheckConfigName = UptimeCheckConfigName.FromProjectUptimeCheckConfig("[PROJECT]", "[UPTIME_CHECK_CONFIG]"),
                DisplayName = "display_name137f65c2",
                MonitoredResource = new ga::MonitoredResource(),
                ResourceGroup = new UptimeCheckConfig.Types.ResourceGroup(),
                HttpCheck = new UptimeCheckConfig.Types.HttpCheck(),
                TcpCheck = new UptimeCheckConfig.Types.TcpCheck(),
                Period = new wkt::Duration(),
                Timeout = new wkt::Duration(),
                ContentMatchers =
                {
                    new UptimeCheckConfig.Types.ContentMatcher(),
                },
                SelectedRegions =
                {
                    UptimeCheckRegion.RegionUnspecified,
                },
#pragma warning disable CS0612
                InternalCheckers =
#pragma warning restore CS0612
                {
#pragma warning disable CS0612
                    new InternalChecker(),
#pragma warning restore CS0612
                },
#pragma warning disable CS0612
                IsInternal = true,
#pragma warning restore CS0612
            };
            mockGrpcClient.Setup(x => x.GetUptimeCheckConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            UptimeCheckServiceClient client = new UptimeCheckServiceClientImpl(mockGrpcClient.Object, null);
            UptimeCheckConfig response = client.GetUptimeCheckConfig(request.ResourceName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetUptimeCheckConfigResourceNames2Async()
        {
            moq::Mock<UptimeCheckService.UptimeCheckServiceClient> mockGrpcClient = new moq::Mock<UptimeCheckService.UptimeCheckServiceClient>(moq::MockBehavior.Strict);
            GetUptimeCheckConfigRequest request = new GetUptimeCheckConfigRequest
            {
                UptimeCheckConfigName = UptimeCheckConfigName.FromProjectUptimeCheckConfig("[PROJECT]", "[UPTIME_CHECK_CONFIG]"),
            };
            UptimeCheckConfig expectedResponse = new UptimeCheckConfig
            {
                UptimeCheckConfigName = UptimeCheckConfigName.FromProjectUptimeCheckConfig("[PROJECT]", "[UPTIME_CHECK_CONFIG]"),
                DisplayName = "display_name137f65c2",
                MonitoredResource = new ga::MonitoredResource(),
                ResourceGroup = new UptimeCheckConfig.Types.ResourceGroup(),
                HttpCheck = new UptimeCheckConfig.Types.HttpCheck(),
                TcpCheck = new UptimeCheckConfig.Types.TcpCheck(),
                Period = new wkt::Duration(),
                Timeout = new wkt::Duration(),
                ContentMatchers =
                {
                    new UptimeCheckConfig.Types.ContentMatcher(),
                },
                SelectedRegions =
                {
                    UptimeCheckRegion.RegionUnspecified,
                },
#pragma warning disable CS0612
                InternalCheckers =
#pragma warning restore CS0612
                {
#pragma warning disable CS0612
                    new InternalChecker(),
#pragma warning restore CS0612
                },
#pragma warning disable CS0612
                IsInternal = true,
#pragma warning restore CS0612
            };
            mockGrpcClient.Setup(x => x.GetUptimeCheckConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<UptimeCheckConfig>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            UptimeCheckServiceClient client = new UptimeCheckServiceClientImpl(mockGrpcClient.Object, null);
            UptimeCheckConfig responseCallSettings = await client.GetUptimeCheckConfigAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            UptimeCheckConfig responseCancellationToken = await client.GetUptimeCheckConfigAsync(request.ResourceName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateUptimeCheckConfigRequestObject()
        {
            moq::Mock<UptimeCheckService.UptimeCheckServiceClient> mockGrpcClient = new moq::Mock<UptimeCheckService.UptimeCheckServiceClient>(moq::MockBehavior.Strict);
            CreateUptimeCheckConfigRequest request = new CreateUptimeCheckConfigRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                UptimeCheckConfig = new UptimeCheckConfig(),
            };
            UptimeCheckConfig expectedResponse = new UptimeCheckConfig
            {
                UptimeCheckConfigName = UptimeCheckConfigName.FromProjectUptimeCheckConfig("[PROJECT]", "[UPTIME_CHECK_CONFIG]"),
                DisplayName = "display_name137f65c2",
                MonitoredResource = new ga::MonitoredResource(),
                ResourceGroup = new UptimeCheckConfig.Types.ResourceGroup(),
                HttpCheck = new UptimeCheckConfig.Types.HttpCheck(),
                TcpCheck = new UptimeCheckConfig.Types.TcpCheck(),
                Period = new wkt::Duration(),
                Timeout = new wkt::Duration(),
                ContentMatchers =
                {
                    new UptimeCheckConfig.Types.ContentMatcher(),
                },
                SelectedRegions =
                {
                    UptimeCheckRegion.RegionUnspecified,
                },
#pragma warning disable CS0612
                InternalCheckers =
#pragma warning restore CS0612
                {
#pragma warning disable CS0612
                    new InternalChecker(),
#pragma warning restore CS0612
                },
#pragma warning disable CS0612
                IsInternal = true,
#pragma warning restore CS0612
            };
            mockGrpcClient.Setup(x => x.CreateUptimeCheckConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            UptimeCheckServiceClient client = new UptimeCheckServiceClientImpl(mockGrpcClient.Object, null);
            UptimeCheckConfig response = client.CreateUptimeCheckConfig(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateUptimeCheckConfigRequestObjectAsync()
        {
            moq::Mock<UptimeCheckService.UptimeCheckServiceClient> mockGrpcClient = new moq::Mock<UptimeCheckService.UptimeCheckServiceClient>(moq::MockBehavior.Strict);
            CreateUptimeCheckConfigRequest request = new CreateUptimeCheckConfigRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                UptimeCheckConfig = new UptimeCheckConfig(),
            };
            UptimeCheckConfig expectedResponse = new UptimeCheckConfig
            {
                UptimeCheckConfigName = UptimeCheckConfigName.FromProjectUptimeCheckConfig("[PROJECT]", "[UPTIME_CHECK_CONFIG]"),
                DisplayName = "display_name137f65c2",
                MonitoredResource = new ga::MonitoredResource(),
                ResourceGroup = new UptimeCheckConfig.Types.ResourceGroup(),
                HttpCheck = new UptimeCheckConfig.Types.HttpCheck(),
                TcpCheck = new UptimeCheckConfig.Types.TcpCheck(),
                Period = new wkt::Duration(),
                Timeout = new wkt::Duration(),
                ContentMatchers =
                {
                    new UptimeCheckConfig.Types.ContentMatcher(),
                },
                SelectedRegions =
                {
                    UptimeCheckRegion.RegionUnspecified,
                },
#pragma warning disable CS0612
                InternalCheckers =
#pragma warning restore CS0612
                {
#pragma warning disable CS0612
                    new InternalChecker(),
#pragma warning restore CS0612
                },
#pragma warning disable CS0612
                IsInternal = true,
#pragma warning restore CS0612
            };
            mockGrpcClient.Setup(x => x.CreateUptimeCheckConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<UptimeCheckConfig>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            UptimeCheckServiceClient client = new UptimeCheckServiceClientImpl(mockGrpcClient.Object, null);
            UptimeCheckConfig responseCallSettings = await client.CreateUptimeCheckConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            UptimeCheckConfig responseCancellationToken = await client.CreateUptimeCheckConfigAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateUptimeCheckConfig()
        {
            moq::Mock<UptimeCheckService.UptimeCheckServiceClient> mockGrpcClient = new moq::Mock<UptimeCheckService.UptimeCheckServiceClient>(moq::MockBehavior.Strict);
            CreateUptimeCheckConfigRequest request = new CreateUptimeCheckConfigRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                UptimeCheckConfig = new UptimeCheckConfig(),
            };
            UptimeCheckConfig expectedResponse = new UptimeCheckConfig
            {
                UptimeCheckConfigName = UptimeCheckConfigName.FromProjectUptimeCheckConfig("[PROJECT]", "[UPTIME_CHECK_CONFIG]"),
                DisplayName = "display_name137f65c2",
                MonitoredResource = new ga::MonitoredResource(),
                ResourceGroup = new UptimeCheckConfig.Types.ResourceGroup(),
                HttpCheck = new UptimeCheckConfig.Types.HttpCheck(),
                TcpCheck = new UptimeCheckConfig.Types.TcpCheck(),
                Period = new wkt::Duration(),
                Timeout = new wkt::Duration(),
                ContentMatchers =
                {
                    new UptimeCheckConfig.Types.ContentMatcher(),
                },
                SelectedRegions =
                {
                    UptimeCheckRegion.RegionUnspecified,
                },
#pragma warning disable CS0612
                InternalCheckers =
#pragma warning restore CS0612
                {
#pragma warning disable CS0612
                    new InternalChecker(),
#pragma warning restore CS0612
                },
#pragma warning disable CS0612
                IsInternal = true,
#pragma warning restore CS0612
            };
            mockGrpcClient.Setup(x => x.CreateUptimeCheckConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            UptimeCheckServiceClient client = new UptimeCheckServiceClientImpl(mockGrpcClient.Object, null);
            UptimeCheckConfig response = client.CreateUptimeCheckConfig(request.Parent, request.UptimeCheckConfig);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateUptimeCheckConfigAsync()
        {
            moq::Mock<UptimeCheckService.UptimeCheckServiceClient> mockGrpcClient = new moq::Mock<UptimeCheckService.UptimeCheckServiceClient>(moq::MockBehavior.Strict);
            CreateUptimeCheckConfigRequest request = new CreateUptimeCheckConfigRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                UptimeCheckConfig = new UptimeCheckConfig(),
            };
            UptimeCheckConfig expectedResponse = new UptimeCheckConfig
            {
                UptimeCheckConfigName = UptimeCheckConfigName.FromProjectUptimeCheckConfig("[PROJECT]", "[UPTIME_CHECK_CONFIG]"),
                DisplayName = "display_name137f65c2",
                MonitoredResource = new ga::MonitoredResource(),
                ResourceGroup = new UptimeCheckConfig.Types.ResourceGroup(),
                HttpCheck = new UptimeCheckConfig.Types.HttpCheck(),
                TcpCheck = new UptimeCheckConfig.Types.TcpCheck(),
                Period = new wkt::Duration(),
                Timeout = new wkt::Duration(),
                ContentMatchers =
                {
                    new UptimeCheckConfig.Types.ContentMatcher(),
                },
                SelectedRegions =
                {
                    UptimeCheckRegion.RegionUnspecified,
                },
#pragma warning disable CS0612
                InternalCheckers =
#pragma warning restore CS0612
                {
#pragma warning disable CS0612
                    new InternalChecker(),
#pragma warning restore CS0612
                },
#pragma warning disable CS0612
                IsInternal = true,
#pragma warning restore CS0612
            };
            mockGrpcClient.Setup(x => x.CreateUptimeCheckConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<UptimeCheckConfig>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            UptimeCheckServiceClient client = new UptimeCheckServiceClientImpl(mockGrpcClient.Object, null);
            UptimeCheckConfig responseCallSettings = await client.CreateUptimeCheckConfigAsync(request.Parent, request.UptimeCheckConfig, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            UptimeCheckConfig responseCancellationToken = await client.CreateUptimeCheckConfigAsync(request.Parent, request.UptimeCheckConfig, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateUptimeCheckConfigResourceNames1()
        {
            moq::Mock<UptimeCheckService.UptimeCheckServiceClient> mockGrpcClient = new moq::Mock<UptimeCheckService.UptimeCheckServiceClient>(moq::MockBehavior.Strict);
            CreateUptimeCheckConfigRequest request = new CreateUptimeCheckConfigRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                UptimeCheckConfig = new UptimeCheckConfig(),
            };
            UptimeCheckConfig expectedResponse = new UptimeCheckConfig
            {
                UptimeCheckConfigName = UptimeCheckConfigName.FromProjectUptimeCheckConfig("[PROJECT]", "[UPTIME_CHECK_CONFIG]"),
                DisplayName = "display_name137f65c2",
                MonitoredResource = new ga::MonitoredResource(),
                ResourceGroup = new UptimeCheckConfig.Types.ResourceGroup(),
                HttpCheck = new UptimeCheckConfig.Types.HttpCheck(),
                TcpCheck = new UptimeCheckConfig.Types.TcpCheck(),
                Period = new wkt::Duration(),
                Timeout = new wkt::Duration(),
                ContentMatchers =
                {
                    new UptimeCheckConfig.Types.ContentMatcher(),
                },
                SelectedRegions =
                {
                    UptimeCheckRegion.RegionUnspecified,
                },
#pragma warning disable CS0612
                InternalCheckers =
#pragma warning restore CS0612
                {
#pragma warning disable CS0612
                    new InternalChecker(),
#pragma warning restore CS0612
                },
#pragma warning disable CS0612
                IsInternal = true,
#pragma warning restore CS0612
            };
            mockGrpcClient.Setup(x => x.CreateUptimeCheckConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            UptimeCheckServiceClient client = new UptimeCheckServiceClientImpl(mockGrpcClient.Object, null);
            UptimeCheckConfig response = client.CreateUptimeCheckConfig(request.ParentAsProjectName, request.UptimeCheckConfig);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateUptimeCheckConfigResourceNames1Async()
        {
            moq::Mock<UptimeCheckService.UptimeCheckServiceClient> mockGrpcClient = new moq::Mock<UptimeCheckService.UptimeCheckServiceClient>(moq::MockBehavior.Strict);
            CreateUptimeCheckConfigRequest request = new CreateUptimeCheckConfigRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                UptimeCheckConfig = new UptimeCheckConfig(),
            };
            UptimeCheckConfig expectedResponse = new UptimeCheckConfig
            {
                UptimeCheckConfigName = UptimeCheckConfigName.FromProjectUptimeCheckConfig("[PROJECT]", "[UPTIME_CHECK_CONFIG]"),
                DisplayName = "display_name137f65c2",
                MonitoredResource = new ga::MonitoredResource(),
                ResourceGroup = new UptimeCheckConfig.Types.ResourceGroup(),
                HttpCheck = new UptimeCheckConfig.Types.HttpCheck(),
                TcpCheck = new UptimeCheckConfig.Types.TcpCheck(),
                Period = new wkt::Duration(),
                Timeout = new wkt::Duration(),
                ContentMatchers =
                {
                    new UptimeCheckConfig.Types.ContentMatcher(),
                },
                SelectedRegions =
                {
                    UptimeCheckRegion.RegionUnspecified,
                },
#pragma warning disable CS0612
                InternalCheckers =
#pragma warning restore CS0612
                {
#pragma warning disable CS0612
                    new InternalChecker(),
#pragma warning restore CS0612
                },
#pragma warning disable CS0612
                IsInternal = true,
#pragma warning restore CS0612
            };
            mockGrpcClient.Setup(x => x.CreateUptimeCheckConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<UptimeCheckConfig>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            UptimeCheckServiceClient client = new UptimeCheckServiceClientImpl(mockGrpcClient.Object, null);
            UptimeCheckConfig responseCallSettings = await client.CreateUptimeCheckConfigAsync(request.ParentAsProjectName, request.UptimeCheckConfig, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            UptimeCheckConfig responseCancellationToken = await client.CreateUptimeCheckConfigAsync(request.ParentAsProjectName, request.UptimeCheckConfig, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateUptimeCheckConfigResourceNames2()
        {
            moq::Mock<UptimeCheckService.UptimeCheckServiceClient> mockGrpcClient = new moq::Mock<UptimeCheckService.UptimeCheckServiceClient>(moq::MockBehavior.Strict);
            CreateUptimeCheckConfigRequest request = new CreateUptimeCheckConfigRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                UptimeCheckConfig = new UptimeCheckConfig(),
            };
            UptimeCheckConfig expectedResponse = new UptimeCheckConfig
            {
                UptimeCheckConfigName = UptimeCheckConfigName.FromProjectUptimeCheckConfig("[PROJECT]", "[UPTIME_CHECK_CONFIG]"),
                DisplayName = "display_name137f65c2",
                MonitoredResource = new ga::MonitoredResource(),
                ResourceGroup = new UptimeCheckConfig.Types.ResourceGroup(),
                HttpCheck = new UptimeCheckConfig.Types.HttpCheck(),
                TcpCheck = new UptimeCheckConfig.Types.TcpCheck(),
                Period = new wkt::Duration(),
                Timeout = new wkt::Duration(),
                ContentMatchers =
                {
                    new UptimeCheckConfig.Types.ContentMatcher(),
                },
                SelectedRegions =
                {
                    UptimeCheckRegion.RegionUnspecified,
                },
#pragma warning disable CS0612
                InternalCheckers =
#pragma warning restore CS0612
                {
#pragma warning disable CS0612
                    new InternalChecker(),
#pragma warning restore CS0612
                },
#pragma warning disable CS0612
                IsInternal = true,
#pragma warning restore CS0612
            };
            mockGrpcClient.Setup(x => x.CreateUptimeCheckConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            UptimeCheckServiceClient client = new UptimeCheckServiceClientImpl(mockGrpcClient.Object, null);
            UptimeCheckConfig response = client.CreateUptimeCheckConfig(request.ParentAsOrganizationName, request.UptimeCheckConfig);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateUptimeCheckConfigResourceNames2Async()
        {
            moq::Mock<UptimeCheckService.UptimeCheckServiceClient> mockGrpcClient = new moq::Mock<UptimeCheckService.UptimeCheckServiceClient>(moq::MockBehavior.Strict);
            CreateUptimeCheckConfigRequest request = new CreateUptimeCheckConfigRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                UptimeCheckConfig = new UptimeCheckConfig(),
            };
            UptimeCheckConfig expectedResponse = new UptimeCheckConfig
            {
                UptimeCheckConfigName = UptimeCheckConfigName.FromProjectUptimeCheckConfig("[PROJECT]", "[UPTIME_CHECK_CONFIG]"),
                DisplayName = "display_name137f65c2",
                MonitoredResource = new ga::MonitoredResource(),
                ResourceGroup = new UptimeCheckConfig.Types.ResourceGroup(),
                HttpCheck = new UptimeCheckConfig.Types.HttpCheck(),
                TcpCheck = new UptimeCheckConfig.Types.TcpCheck(),
                Period = new wkt::Duration(),
                Timeout = new wkt::Duration(),
                ContentMatchers =
                {
                    new UptimeCheckConfig.Types.ContentMatcher(),
                },
                SelectedRegions =
                {
                    UptimeCheckRegion.RegionUnspecified,
                },
#pragma warning disable CS0612
                InternalCheckers =
#pragma warning restore CS0612
                {
#pragma warning disable CS0612
                    new InternalChecker(),
#pragma warning restore CS0612
                },
#pragma warning disable CS0612
                IsInternal = true,
#pragma warning restore CS0612
            };
            mockGrpcClient.Setup(x => x.CreateUptimeCheckConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<UptimeCheckConfig>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            UptimeCheckServiceClient client = new UptimeCheckServiceClientImpl(mockGrpcClient.Object, null);
            UptimeCheckConfig responseCallSettings = await client.CreateUptimeCheckConfigAsync(request.ParentAsOrganizationName, request.UptimeCheckConfig, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            UptimeCheckConfig responseCancellationToken = await client.CreateUptimeCheckConfigAsync(request.ParentAsOrganizationName, request.UptimeCheckConfig, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateUptimeCheckConfigResourceNames3()
        {
            moq::Mock<UptimeCheckService.UptimeCheckServiceClient> mockGrpcClient = new moq::Mock<UptimeCheckService.UptimeCheckServiceClient>(moq::MockBehavior.Strict);
            CreateUptimeCheckConfigRequest request = new CreateUptimeCheckConfigRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                UptimeCheckConfig = new UptimeCheckConfig(),
            };
            UptimeCheckConfig expectedResponse = new UptimeCheckConfig
            {
                UptimeCheckConfigName = UptimeCheckConfigName.FromProjectUptimeCheckConfig("[PROJECT]", "[UPTIME_CHECK_CONFIG]"),
                DisplayName = "display_name137f65c2",
                MonitoredResource = new ga::MonitoredResource(),
                ResourceGroup = new UptimeCheckConfig.Types.ResourceGroup(),
                HttpCheck = new UptimeCheckConfig.Types.HttpCheck(),
                TcpCheck = new UptimeCheckConfig.Types.TcpCheck(),
                Period = new wkt::Duration(),
                Timeout = new wkt::Duration(),
                ContentMatchers =
                {
                    new UptimeCheckConfig.Types.ContentMatcher(),
                },
                SelectedRegions =
                {
                    UptimeCheckRegion.RegionUnspecified,
                },
#pragma warning disable CS0612
                InternalCheckers =
#pragma warning restore CS0612
                {
#pragma warning disable CS0612
                    new InternalChecker(),
#pragma warning restore CS0612
                },
#pragma warning disable CS0612
                IsInternal = true,
#pragma warning restore CS0612
            };
            mockGrpcClient.Setup(x => x.CreateUptimeCheckConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            UptimeCheckServiceClient client = new UptimeCheckServiceClientImpl(mockGrpcClient.Object, null);
            UptimeCheckConfig response = client.CreateUptimeCheckConfig(request.ParentAsFolderName, request.UptimeCheckConfig);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateUptimeCheckConfigResourceNames3Async()
        {
            moq::Mock<UptimeCheckService.UptimeCheckServiceClient> mockGrpcClient = new moq::Mock<UptimeCheckService.UptimeCheckServiceClient>(moq::MockBehavior.Strict);
            CreateUptimeCheckConfigRequest request = new CreateUptimeCheckConfigRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                UptimeCheckConfig = new UptimeCheckConfig(),
            };
            UptimeCheckConfig expectedResponse = new UptimeCheckConfig
            {
                UptimeCheckConfigName = UptimeCheckConfigName.FromProjectUptimeCheckConfig("[PROJECT]", "[UPTIME_CHECK_CONFIG]"),
                DisplayName = "display_name137f65c2",
                MonitoredResource = new ga::MonitoredResource(),
                ResourceGroup = new UptimeCheckConfig.Types.ResourceGroup(),
                HttpCheck = new UptimeCheckConfig.Types.HttpCheck(),
                TcpCheck = new UptimeCheckConfig.Types.TcpCheck(),
                Period = new wkt::Duration(),
                Timeout = new wkt::Duration(),
                ContentMatchers =
                {
                    new UptimeCheckConfig.Types.ContentMatcher(),
                },
                SelectedRegions =
                {
                    UptimeCheckRegion.RegionUnspecified,
                },
#pragma warning disable CS0612
                InternalCheckers =
#pragma warning restore CS0612
                {
#pragma warning disable CS0612
                    new InternalChecker(),
#pragma warning restore CS0612
                },
#pragma warning disable CS0612
                IsInternal = true,
#pragma warning restore CS0612
            };
            mockGrpcClient.Setup(x => x.CreateUptimeCheckConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<UptimeCheckConfig>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            UptimeCheckServiceClient client = new UptimeCheckServiceClientImpl(mockGrpcClient.Object, null);
            UptimeCheckConfig responseCallSettings = await client.CreateUptimeCheckConfigAsync(request.ParentAsFolderName, request.UptimeCheckConfig, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            UptimeCheckConfig responseCancellationToken = await client.CreateUptimeCheckConfigAsync(request.ParentAsFolderName, request.UptimeCheckConfig, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateUptimeCheckConfigResourceNames4()
        {
            moq::Mock<UptimeCheckService.UptimeCheckServiceClient> mockGrpcClient = new moq::Mock<UptimeCheckService.UptimeCheckServiceClient>(moq::MockBehavior.Strict);
            CreateUptimeCheckConfigRequest request = new CreateUptimeCheckConfigRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                UptimeCheckConfig = new UptimeCheckConfig(),
            };
            UptimeCheckConfig expectedResponse = new UptimeCheckConfig
            {
                UptimeCheckConfigName = UptimeCheckConfigName.FromProjectUptimeCheckConfig("[PROJECT]", "[UPTIME_CHECK_CONFIG]"),
                DisplayName = "display_name137f65c2",
                MonitoredResource = new ga::MonitoredResource(),
                ResourceGroup = new UptimeCheckConfig.Types.ResourceGroup(),
                HttpCheck = new UptimeCheckConfig.Types.HttpCheck(),
                TcpCheck = new UptimeCheckConfig.Types.TcpCheck(),
                Period = new wkt::Duration(),
                Timeout = new wkt::Duration(),
                ContentMatchers =
                {
                    new UptimeCheckConfig.Types.ContentMatcher(),
                },
                SelectedRegions =
                {
                    UptimeCheckRegion.RegionUnspecified,
                },
#pragma warning disable CS0612
                InternalCheckers =
#pragma warning restore CS0612
                {
#pragma warning disable CS0612
                    new InternalChecker(),
#pragma warning restore CS0612
                },
#pragma warning disable CS0612
                IsInternal = true,
#pragma warning restore CS0612
            };
            mockGrpcClient.Setup(x => x.CreateUptimeCheckConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            UptimeCheckServiceClient client = new UptimeCheckServiceClientImpl(mockGrpcClient.Object, null);
            UptimeCheckConfig response = client.CreateUptimeCheckConfig(request.ParentAsResourceName, request.UptimeCheckConfig);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateUptimeCheckConfigResourceNames4Async()
        {
            moq::Mock<UptimeCheckService.UptimeCheckServiceClient> mockGrpcClient = new moq::Mock<UptimeCheckService.UptimeCheckServiceClient>(moq::MockBehavior.Strict);
            CreateUptimeCheckConfigRequest request = new CreateUptimeCheckConfigRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                UptimeCheckConfig = new UptimeCheckConfig(),
            };
            UptimeCheckConfig expectedResponse = new UptimeCheckConfig
            {
                UptimeCheckConfigName = UptimeCheckConfigName.FromProjectUptimeCheckConfig("[PROJECT]", "[UPTIME_CHECK_CONFIG]"),
                DisplayName = "display_name137f65c2",
                MonitoredResource = new ga::MonitoredResource(),
                ResourceGroup = new UptimeCheckConfig.Types.ResourceGroup(),
                HttpCheck = new UptimeCheckConfig.Types.HttpCheck(),
                TcpCheck = new UptimeCheckConfig.Types.TcpCheck(),
                Period = new wkt::Duration(),
                Timeout = new wkt::Duration(),
                ContentMatchers =
                {
                    new UptimeCheckConfig.Types.ContentMatcher(),
                },
                SelectedRegions =
                {
                    UptimeCheckRegion.RegionUnspecified,
                },
#pragma warning disable CS0612
                InternalCheckers =
#pragma warning restore CS0612
                {
#pragma warning disable CS0612
                    new InternalChecker(),
#pragma warning restore CS0612
                },
#pragma warning disable CS0612
                IsInternal = true,
#pragma warning restore CS0612
            };
            mockGrpcClient.Setup(x => x.CreateUptimeCheckConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<UptimeCheckConfig>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            UptimeCheckServiceClient client = new UptimeCheckServiceClientImpl(mockGrpcClient.Object, null);
            UptimeCheckConfig responseCallSettings = await client.CreateUptimeCheckConfigAsync(request.ParentAsResourceName, request.UptimeCheckConfig, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            UptimeCheckConfig responseCancellationToken = await client.CreateUptimeCheckConfigAsync(request.ParentAsResourceName, request.UptimeCheckConfig, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateUptimeCheckConfigRequestObject()
        {
            moq::Mock<UptimeCheckService.UptimeCheckServiceClient> mockGrpcClient = new moq::Mock<UptimeCheckService.UptimeCheckServiceClient>(moq::MockBehavior.Strict);
            UpdateUptimeCheckConfigRequest request = new UpdateUptimeCheckConfigRequest
            {
                UpdateMask = new wkt::FieldMask(),
                UptimeCheckConfig = new UptimeCheckConfig(),
            };
            UptimeCheckConfig expectedResponse = new UptimeCheckConfig
            {
                UptimeCheckConfigName = UptimeCheckConfigName.FromProjectUptimeCheckConfig("[PROJECT]", "[UPTIME_CHECK_CONFIG]"),
                DisplayName = "display_name137f65c2",
                MonitoredResource = new ga::MonitoredResource(),
                ResourceGroup = new UptimeCheckConfig.Types.ResourceGroup(),
                HttpCheck = new UptimeCheckConfig.Types.HttpCheck(),
                TcpCheck = new UptimeCheckConfig.Types.TcpCheck(),
                Period = new wkt::Duration(),
                Timeout = new wkt::Duration(),
                ContentMatchers =
                {
                    new UptimeCheckConfig.Types.ContentMatcher(),
                },
                SelectedRegions =
                {
                    UptimeCheckRegion.RegionUnspecified,
                },
#pragma warning disable CS0612
                InternalCheckers =
#pragma warning restore CS0612
                {
#pragma warning disable CS0612
                    new InternalChecker(),
#pragma warning restore CS0612
                },
#pragma warning disable CS0612
                IsInternal = true,
#pragma warning restore CS0612
            };
            mockGrpcClient.Setup(x => x.UpdateUptimeCheckConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            UptimeCheckServiceClient client = new UptimeCheckServiceClientImpl(mockGrpcClient.Object, null);
            UptimeCheckConfig response = client.UpdateUptimeCheckConfig(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateUptimeCheckConfigRequestObjectAsync()
        {
            moq::Mock<UptimeCheckService.UptimeCheckServiceClient> mockGrpcClient = new moq::Mock<UptimeCheckService.UptimeCheckServiceClient>(moq::MockBehavior.Strict);
            UpdateUptimeCheckConfigRequest request = new UpdateUptimeCheckConfigRequest
            {
                UpdateMask = new wkt::FieldMask(),
                UptimeCheckConfig = new UptimeCheckConfig(),
            };
            UptimeCheckConfig expectedResponse = new UptimeCheckConfig
            {
                UptimeCheckConfigName = UptimeCheckConfigName.FromProjectUptimeCheckConfig("[PROJECT]", "[UPTIME_CHECK_CONFIG]"),
                DisplayName = "display_name137f65c2",
                MonitoredResource = new ga::MonitoredResource(),
                ResourceGroup = new UptimeCheckConfig.Types.ResourceGroup(),
                HttpCheck = new UptimeCheckConfig.Types.HttpCheck(),
                TcpCheck = new UptimeCheckConfig.Types.TcpCheck(),
                Period = new wkt::Duration(),
                Timeout = new wkt::Duration(),
                ContentMatchers =
                {
                    new UptimeCheckConfig.Types.ContentMatcher(),
                },
                SelectedRegions =
                {
                    UptimeCheckRegion.RegionUnspecified,
                },
#pragma warning disable CS0612
                InternalCheckers =
#pragma warning restore CS0612
                {
#pragma warning disable CS0612
                    new InternalChecker(),
#pragma warning restore CS0612
                },
#pragma warning disable CS0612
                IsInternal = true,
#pragma warning restore CS0612
            };
            mockGrpcClient.Setup(x => x.UpdateUptimeCheckConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<UptimeCheckConfig>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            UptimeCheckServiceClient client = new UptimeCheckServiceClientImpl(mockGrpcClient.Object, null);
            UptimeCheckConfig responseCallSettings = await client.UpdateUptimeCheckConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            UptimeCheckConfig responseCancellationToken = await client.UpdateUptimeCheckConfigAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateUptimeCheckConfig()
        {
            moq::Mock<UptimeCheckService.UptimeCheckServiceClient> mockGrpcClient = new moq::Mock<UptimeCheckService.UptimeCheckServiceClient>(moq::MockBehavior.Strict);
            UpdateUptimeCheckConfigRequest request = new UpdateUptimeCheckConfigRequest
            {
                UptimeCheckConfig = new UptimeCheckConfig(),
            };
            UptimeCheckConfig expectedResponse = new UptimeCheckConfig
            {
                UptimeCheckConfigName = UptimeCheckConfigName.FromProjectUptimeCheckConfig("[PROJECT]", "[UPTIME_CHECK_CONFIG]"),
                DisplayName = "display_name137f65c2",
                MonitoredResource = new ga::MonitoredResource(),
                ResourceGroup = new UptimeCheckConfig.Types.ResourceGroup(),
                HttpCheck = new UptimeCheckConfig.Types.HttpCheck(),
                TcpCheck = new UptimeCheckConfig.Types.TcpCheck(),
                Period = new wkt::Duration(),
                Timeout = new wkt::Duration(),
                ContentMatchers =
                {
                    new UptimeCheckConfig.Types.ContentMatcher(),
                },
                SelectedRegions =
                {
                    UptimeCheckRegion.RegionUnspecified,
                },
#pragma warning disable CS0612
                InternalCheckers =
#pragma warning restore CS0612
                {
#pragma warning disable CS0612
                    new InternalChecker(),
#pragma warning restore CS0612
                },
#pragma warning disable CS0612
                IsInternal = true,
#pragma warning restore CS0612
            };
            mockGrpcClient.Setup(x => x.UpdateUptimeCheckConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            UptimeCheckServiceClient client = new UptimeCheckServiceClientImpl(mockGrpcClient.Object, null);
            UptimeCheckConfig response = client.UpdateUptimeCheckConfig(request.UptimeCheckConfig);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateUptimeCheckConfigAsync()
        {
            moq::Mock<UptimeCheckService.UptimeCheckServiceClient> mockGrpcClient = new moq::Mock<UptimeCheckService.UptimeCheckServiceClient>(moq::MockBehavior.Strict);
            UpdateUptimeCheckConfigRequest request = new UpdateUptimeCheckConfigRequest
            {
                UptimeCheckConfig = new UptimeCheckConfig(),
            };
            UptimeCheckConfig expectedResponse = new UptimeCheckConfig
            {
                UptimeCheckConfigName = UptimeCheckConfigName.FromProjectUptimeCheckConfig("[PROJECT]", "[UPTIME_CHECK_CONFIG]"),
                DisplayName = "display_name137f65c2",
                MonitoredResource = new ga::MonitoredResource(),
                ResourceGroup = new UptimeCheckConfig.Types.ResourceGroup(),
                HttpCheck = new UptimeCheckConfig.Types.HttpCheck(),
                TcpCheck = new UptimeCheckConfig.Types.TcpCheck(),
                Period = new wkt::Duration(),
                Timeout = new wkt::Duration(),
                ContentMatchers =
                {
                    new UptimeCheckConfig.Types.ContentMatcher(),
                },
                SelectedRegions =
                {
                    UptimeCheckRegion.RegionUnspecified,
                },
#pragma warning disable CS0612
                InternalCheckers =
#pragma warning restore CS0612
                {
#pragma warning disable CS0612
                    new InternalChecker(),
#pragma warning restore CS0612
                },
#pragma warning disable CS0612
                IsInternal = true,
#pragma warning restore CS0612
            };
            mockGrpcClient.Setup(x => x.UpdateUptimeCheckConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<UptimeCheckConfig>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            UptimeCheckServiceClient client = new UptimeCheckServiceClientImpl(mockGrpcClient.Object, null);
            UptimeCheckConfig responseCallSettings = await client.UpdateUptimeCheckConfigAsync(request.UptimeCheckConfig, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            UptimeCheckConfig responseCancellationToken = await client.UpdateUptimeCheckConfigAsync(request.UptimeCheckConfig, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteUptimeCheckConfigRequestObject()
        {
            moq::Mock<UptimeCheckService.UptimeCheckServiceClient> mockGrpcClient = new moq::Mock<UptimeCheckService.UptimeCheckServiceClient>(moq::MockBehavior.Strict);
            DeleteUptimeCheckConfigRequest request = new DeleteUptimeCheckConfigRequest
            {
                UptimeCheckConfigName = UptimeCheckConfigName.FromProjectUptimeCheckConfig("[PROJECT]", "[UPTIME_CHECK_CONFIG]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteUptimeCheckConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            UptimeCheckServiceClient client = new UptimeCheckServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteUptimeCheckConfig(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteUptimeCheckConfigRequestObjectAsync()
        {
            moq::Mock<UptimeCheckService.UptimeCheckServiceClient> mockGrpcClient = new moq::Mock<UptimeCheckService.UptimeCheckServiceClient>(moq::MockBehavior.Strict);
            DeleteUptimeCheckConfigRequest request = new DeleteUptimeCheckConfigRequest
            {
                UptimeCheckConfigName = UptimeCheckConfigName.FromProjectUptimeCheckConfig("[PROJECT]", "[UPTIME_CHECK_CONFIG]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteUptimeCheckConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            UptimeCheckServiceClient client = new UptimeCheckServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteUptimeCheckConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteUptimeCheckConfigAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteUptimeCheckConfig()
        {
            moq::Mock<UptimeCheckService.UptimeCheckServiceClient> mockGrpcClient = new moq::Mock<UptimeCheckService.UptimeCheckServiceClient>(moq::MockBehavior.Strict);
            DeleteUptimeCheckConfigRequest request = new DeleteUptimeCheckConfigRequest
            {
                UptimeCheckConfigName = UptimeCheckConfigName.FromProjectUptimeCheckConfig("[PROJECT]", "[UPTIME_CHECK_CONFIG]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteUptimeCheckConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            UptimeCheckServiceClient client = new UptimeCheckServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteUptimeCheckConfig(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteUptimeCheckConfigAsync()
        {
            moq::Mock<UptimeCheckService.UptimeCheckServiceClient> mockGrpcClient = new moq::Mock<UptimeCheckService.UptimeCheckServiceClient>(moq::MockBehavior.Strict);
            DeleteUptimeCheckConfigRequest request = new DeleteUptimeCheckConfigRequest
            {
                UptimeCheckConfigName = UptimeCheckConfigName.FromProjectUptimeCheckConfig("[PROJECT]", "[UPTIME_CHECK_CONFIG]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteUptimeCheckConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            UptimeCheckServiceClient client = new UptimeCheckServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteUptimeCheckConfigAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteUptimeCheckConfigAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteUptimeCheckConfigResourceNames1()
        {
            moq::Mock<UptimeCheckService.UptimeCheckServiceClient> mockGrpcClient = new moq::Mock<UptimeCheckService.UptimeCheckServiceClient>(moq::MockBehavior.Strict);
            DeleteUptimeCheckConfigRequest request = new DeleteUptimeCheckConfigRequest
            {
                UptimeCheckConfigName = UptimeCheckConfigName.FromProjectUptimeCheckConfig("[PROJECT]", "[UPTIME_CHECK_CONFIG]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteUptimeCheckConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            UptimeCheckServiceClient client = new UptimeCheckServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteUptimeCheckConfig(request.UptimeCheckConfigName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteUptimeCheckConfigResourceNames1Async()
        {
            moq::Mock<UptimeCheckService.UptimeCheckServiceClient> mockGrpcClient = new moq::Mock<UptimeCheckService.UptimeCheckServiceClient>(moq::MockBehavior.Strict);
            DeleteUptimeCheckConfigRequest request = new DeleteUptimeCheckConfigRequest
            {
                UptimeCheckConfigName = UptimeCheckConfigName.FromProjectUptimeCheckConfig("[PROJECT]", "[UPTIME_CHECK_CONFIG]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteUptimeCheckConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            UptimeCheckServiceClient client = new UptimeCheckServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteUptimeCheckConfigAsync(request.UptimeCheckConfigName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteUptimeCheckConfigAsync(request.UptimeCheckConfigName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteUptimeCheckConfigResourceNames2()
        {
            moq::Mock<UptimeCheckService.UptimeCheckServiceClient> mockGrpcClient = new moq::Mock<UptimeCheckService.UptimeCheckServiceClient>(moq::MockBehavior.Strict);
            DeleteUptimeCheckConfigRequest request = new DeleteUptimeCheckConfigRequest
            {
                UptimeCheckConfigName = UptimeCheckConfigName.FromProjectUptimeCheckConfig("[PROJECT]", "[UPTIME_CHECK_CONFIG]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteUptimeCheckConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            UptimeCheckServiceClient client = new UptimeCheckServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteUptimeCheckConfig(request.ResourceName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteUptimeCheckConfigResourceNames2Async()
        {
            moq::Mock<UptimeCheckService.UptimeCheckServiceClient> mockGrpcClient = new moq::Mock<UptimeCheckService.UptimeCheckServiceClient>(moq::MockBehavior.Strict);
            DeleteUptimeCheckConfigRequest request = new DeleteUptimeCheckConfigRequest
            {
                UptimeCheckConfigName = UptimeCheckConfigName.FromProjectUptimeCheckConfig("[PROJECT]", "[UPTIME_CHECK_CONFIG]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteUptimeCheckConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            UptimeCheckServiceClient client = new UptimeCheckServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteUptimeCheckConfigAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteUptimeCheckConfigAsync(request.ResourceName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }
    }
}
