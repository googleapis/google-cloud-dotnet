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

#pragma warning disable CS8981
using gaxgrpc = Google.Api.Gax.Grpc;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.WebSecurityScanner.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedWebSecurityScannerClientTest
    {
        [xunit::FactAttribute]
        public void CreateScanConfigRequestObject()
        {
            moq::Mock<WebSecurityScanner.WebSecurityScannerClient> mockGrpcClient = new moq::Mock<WebSecurityScanner.WebSecurityScannerClient>(moq::MockBehavior.Strict);
            CreateScanConfigRequest request = new CreateScanConfigRequest
            {
                Parent = "parent7858e4d0",
                ScanConfig = new ScanConfig(),
            };
            ScanConfig expectedResponse = new ScanConfig
            {
                Name = "name1c9368b0",
                DisplayName = "display_name137f65c2",
                MaxQps = -1198236314,
                StartingUrls =
                {
                    "starting_urls75fa5e9e",
                },
                Authentication = new ScanConfig.Types.Authentication(),
                UserAgent = ScanConfig.Types.UserAgent.SafariIphone,
                BlacklistPatterns =
                {
                    "blacklist_patterns7a899f15",
                },
                Schedule = new ScanConfig.Types.Schedule(),
                ExportToSecurityCommandCenter = ScanConfig.Types.ExportToSecurityCommandCenter.Unspecified,
                RiskLevel = ScanConfig.Types.RiskLevel.Unspecified,
                ManagedScan = true,
                StaticIpScan = false,
            };
            mockGrpcClient.Setup(x => x.CreateScanConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            WebSecurityScannerClient client = new WebSecurityScannerClientImpl(mockGrpcClient.Object, null, null);
            ScanConfig response = client.CreateScanConfig(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateScanConfigRequestObjectAsync()
        {
            moq::Mock<WebSecurityScanner.WebSecurityScannerClient> mockGrpcClient = new moq::Mock<WebSecurityScanner.WebSecurityScannerClient>(moq::MockBehavior.Strict);
            CreateScanConfigRequest request = new CreateScanConfigRequest
            {
                Parent = "parent7858e4d0",
                ScanConfig = new ScanConfig(),
            };
            ScanConfig expectedResponse = new ScanConfig
            {
                Name = "name1c9368b0",
                DisplayName = "display_name137f65c2",
                MaxQps = -1198236314,
                StartingUrls =
                {
                    "starting_urls75fa5e9e",
                },
                Authentication = new ScanConfig.Types.Authentication(),
                UserAgent = ScanConfig.Types.UserAgent.SafariIphone,
                BlacklistPatterns =
                {
                    "blacklist_patterns7a899f15",
                },
                Schedule = new ScanConfig.Types.Schedule(),
                ExportToSecurityCommandCenter = ScanConfig.Types.ExportToSecurityCommandCenter.Unspecified,
                RiskLevel = ScanConfig.Types.RiskLevel.Unspecified,
                ManagedScan = true,
                StaticIpScan = false,
            };
            mockGrpcClient.Setup(x => x.CreateScanConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ScanConfig>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            WebSecurityScannerClient client = new WebSecurityScannerClientImpl(mockGrpcClient.Object, null, null);
            ScanConfig responseCallSettings = await client.CreateScanConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ScanConfig responseCancellationToken = await client.CreateScanConfigAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteScanConfigRequestObject()
        {
            moq::Mock<WebSecurityScanner.WebSecurityScannerClient> mockGrpcClient = new moq::Mock<WebSecurityScanner.WebSecurityScannerClient>(moq::MockBehavior.Strict);
            DeleteScanConfigRequest request = new DeleteScanConfigRequest
            {
                Name = "name1c9368b0",
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteScanConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            WebSecurityScannerClient client = new WebSecurityScannerClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteScanConfig(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteScanConfigRequestObjectAsync()
        {
            moq::Mock<WebSecurityScanner.WebSecurityScannerClient> mockGrpcClient = new moq::Mock<WebSecurityScanner.WebSecurityScannerClient>(moq::MockBehavior.Strict);
            DeleteScanConfigRequest request = new DeleteScanConfigRequest
            {
                Name = "name1c9368b0",
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteScanConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            WebSecurityScannerClient client = new WebSecurityScannerClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteScanConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteScanConfigAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetScanConfigRequestObject()
        {
            moq::Mock<WebSecurityScanner.WebSecurityScannerClient> mockGrpcClient = new moq::Mock<WebSecurityScanner.WebSecurityScannerClient>(moq::MockBehavior.Strict);
            GetScanConfigRequest request = new GetScanConfigRequest
            {
                Name = "name1c9368b0",
            };
            ScanConfig expectedResponse = new ScanConfig
            {
                Name = "name1c9368b0",
                DisplayName = "display_name137f65c2",
                MaxQps = -1198236314,
                StartingUrls =
                {
                    "starting_urls75fa5e9e",
                },
                Authentication = new ScanConfig.Types.Authentication(),
                UserAgent = ScanConfig.Types.UserAgent.SafariIphone,
                BlacklistPatterns =
                {
                    "blacklist_patterns7a899f15",
                },
                Schedule = new ScanConfig.Types.Schedule(),
                ExportToSecurityCommandCenter = ScanConfig.Types.ExportToSecurityCommandCenter.Unspecified,
                RiskLevel = ScanConfig.Types.RiskLevel.Unspecified,
                ManagedScan = true,
                StaticIpScan = false,
            };
            mockGrpcClient.Setup(x => x.GetScanConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            WebSecurityScannerClient client = new WebSecurityScannerClientImpl(mockGrpcClient.Object, null, null);
            ScanConfig response = client.GetScanConfig(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetScanConfigRequestObjectAsync()
        {
            moq::Mock<WebSecurityScanner.WebSecurityScannerClient> mockGrpcClient = new moq::Mock<WebSecurityScanner.WebSecurityScannerClient>(moq::MockBehavior.Strict);
            GetScanConfigRequest request = new GetScanConfigRequest
            {
                Name = "name1c9368b0",
            };
            ScanConfig expectedResponse = new ScanConfig
            {
                Name = "name1c9368b0",
                DisplayName = "display_name137f65c2",
                MaxQps = -1198236314,
                StartingUrls =
                {
                    "starting_urls75fa5e9e",
                },
                Authentication = new ScanConfig.Types.Authentication(),
                UserAgent = ScanConfig.Types.UserAgent.SafariIphone,
                BlacklistPatterns =
                {
                    "blacklist_patterns7a899f15",
                },
                Schedule = new ScanConfig.Types.Schedule(),
                ExportToSecurityCommandCenter = ScanConfig.Types.ExportToSecurityCommandCenter.Unspecified,
                RiskLevel = ScanConfig.Types.RiskLevel.Unspecified,
                ManagedScan = true,
                StaticIpScan = false,
            };
            mockGrpcClient.Setup(x => x.GetScanConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ScanConfig>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            WebSecurityScannerClient client = new WebSecurityScannerClientImpl(mockGrpcClient.Object, null, null);
            ScanConfig responseCallSettings = await client.GetScanConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ScanConfig responseCancellationToken = await client.GetScanConfigAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateScanConfigRequestObject()
        {
            moq::Mock<WebSecurityScanner.WebSecurityScannerClient> mockGrpcClient = new moq::Mock<WebSecurityScanner.WebSecurityScannerClient>(moq::MockBehavior.Strict);
            UpdateScanConfigRequest request = new UpdateScanConfigRequest
            {
                ScanConfig = new ScanConfig(),
                UpdateMask = new wkt::FieldMask(),
            };
            ScanConfig expectedResponse = new ScanConfig
            {
                Name = "name1c9368b0",
                DisplayName = "display_name137f65c2",
                MaxQps = -1198236314,
                StartingUrls =
                {
                    "starting_urls75fa5e9e",
                },
                Authentication = new ScanConfig.Types.Authentication(),
                UserAgent = ScanConfig.Types.UserAgent.SafariIphone,
                BlacklistPatterns =
                {
                    "blacklist_patterns7a899f15",
                },
                Schedule = new ScanConfig.Types.Schedule(),
                ExportToSecurityCommandCenter = ScanConfig.Types.ExportToSecurityCommandCenter.Unspecified,
                RiskLevel = ScanConfig.Types.RiskLevel.Unspecified,
                ManagedScan = true,
                StaticIpScan = false,
            };
            mockGrpcClient.Setup(x => x.UpdateScanConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            WebSecurityScannerClient client = new WebSecurityScannerClientImpl(mockGrpcClient.Object, null, null);
            ScanConfig response = client.UpdateScanConfig(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateScanConfigRequestObjectAsync()
        {
            moq::Mock<WebSecurityScanner.WebSecurityScannerClient> mockGrpcClient = new moq::Mock<WebSecurityScanner.WebSecurityScannerClient>(moq::MockBehavior.Strict);
            UpdateScanConfigRequest request = new UpdateScanConfigRequest
            {
                ScanConfig = new ScanConfig(),
                UpdateMask = new wkt::FieldMask(),
            };
            ScanConfig expectedResponse = new ScanConfig
            {
                Name = "name1c9368b0",
                DisplayName = "display_name137f65c2",
                MaxQps = -1198236314,
                StartingUrls =
                {
                    "starting_urls75fa5e9e",
                },
                Authentication = new ScanConfig.Types.Authentication(),
                UserAgent = ScanConfig.Types.UserAgent.SafariIphone,
                BlacklistPatterns =
                {
                    "blacklist_patterns7a899f15",
                },
                Schedule = new ScanConfig.Types.Schedule(),
                ExportToSecurityCommandCenter = ScanConfig.Types.ExportToSecurityCommandCenter.Unspecified,
                RiskLevel = ScanConfig.Types.RiskLevel.Unspecified,
                ManagedScan = true,
                StaticIpScan = false,
            };
            mockGrpcClient.Setup(x => x.UpdateScanConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ScanConfig>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            WebSecurityScannerClient client = new WebSecurityScannerClientImpl(mockGrpcClient.Object, null, null);
            ScanConfig responseCallSettings = await client.UpdateScanConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ScanConfig responseCancellationToken = await client.UpdateScanConfigAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void StartScanRunRequestObject()
        {
            moq::Mock<WebSecurityScanner.WebSecurityScannerClient> mockGrpcClient = new moq::Mock<WebSecurityScanner.WebSecurityScannerClient>(moq::MockBehavior.Strict);
            StartScanRunRequest request = new StartScanRunRequest
            {
                Name = "name1c9368b0",
            };
            ScanRun expectedResponse = new ScanRun
            {
                Name = "name1c9368b0",
                ExecutionState = ScanRun.Types.ExecutionState.Unspecified,
                ResultState = ScanRun.Types.ResultState.Killed,
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                UrlsCrawledCount = 2307837720024124869L,
                UrlsTestedCount = -373604950692105735L,
                HasVulnerabilities = true,
                ProgressPercent = -412774427,
                ErrorTrace = new ScanRunErrorTrace(),
                WarningTraces =
                {
                    new ScanRunWarningTrace(),
                },
            };
            mockGrpcClient.Setup(x => x.StartScanRun(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            WebSecurityScannerClient client = new WebSecurityScannerClientImpl(mockGrpcClient.Object, null, null);
            ScanRun response = client.StartScanRun(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task StartScanRunRequestObjectAsync()
        {
            moq::Mock<WebSecurityScanner.WebSecurityScannerClient> mockGrpcClient = new moq::Mock<WebSecurityScanner.WebSecurityScannerClient>(moq::MockBehavior.Strict);
            StartScanRunRequest request = new StartScanRunRequest
            {
                Name = "name1c9368b0",
            };
            ScanRun expectedResponse = new ScanRun
            {
                Name = "name1c9368b0",
                ExecutionState = ScanRun.Types.ExecutionState.Unspecified,
                ResultState = ScanRun.Types.ResultState.Killed,
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                UrlsCrawledCount = 2307837720024124869L,
                UrlsTestedCount = -373604950692105735L,
                HasVulnerabilities = true,
                ProgressPercent = -412774427,
                ErrorTrace = new ScanRunErrorTrace(),
                WarningTraces =
                {
                    new ScanRunWarningTrace(),
                },
            };
            mockGrpcClient.Setup(x => x.StartScanRunAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ScanRun>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            WebSecurityScannerClient client = new WebSecurityScannerClientImpl(mockGrpcClient.Object, null, null);
            ScanRun responseCallSettings = await client.StartScanRunAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ScanRun responseCancellationToken = await client.StartScanRunAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetScanRunRequestObject()
        {
            moq::Mock<WebSecurityScanner.WebSecurityScannerClient> mockGrpcClient = new moq::Mock<WebSecurityScanner.WebSecurityScannerClient>(moq::MockBehavior.Strict);
            GetScanRunRequest request = new GetScanRunRequest
            {
                Name = "name1c9368b0",
            };
            ScanRun expectedResponse = new ScanRun
            {
                Name = "name1c9368b0",
                ExecutionState = ScanRun.Types.ExecutionState.Unspecified,
                ResultState = ScanRun.Types.ResultState.Killed,
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                UrlsCrawledCount = 2307837720024124869L,
                UrlsTestedCount = -373604950692105735L,
                HasVulnerabilities = true,
                ProgressPercent = -412774427,
                ErrorTrace = new ScanRunErrorTrace(),
                WarningTraces =
                {
                    new ScanRunWarningTrace(),
                },
            };
            mockGrpcClient.Setup(x => x.GetScanRun(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            WebSecurityScannerClient client = new WebSecurityScannerClientImpl(mockGrpcClient.Object, null, null);
            ScanRun response = client.GetScanRun(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetScanRunRequestObjectAsync()
        {
            moq::Mock<WebSecurityScanner.WebSecurityScannerClient> mockGrpcClient = new moq::Mock<WebSecurityScanner.WebSecurityScannerClient>(moq::MockBehavior.Strict);
            GetScanRunRequest request = new GetScanRunRequest
            {
                Name = "name1c9368b0",
            };
            ScanRun expectedResponse = new ScanRun
            {
                Name = "name1c9368b0",
                ExecutionState = ScanRun.Types.ExecutionState.Unspecified,
                ResultState = ScanRun.Types.ResultState.Killed,
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                UrlsCrawledCount = 2307837720024124869L,
                UrlsTestedCount = -373604950692105735L,
                HasVulnerabilities = true,
                ProgressPercent = -412774427,
                ErrorTrace = new ScanRunErrorTrace(),
                WarningTraces =
                {
                    new ScanRunWarningTrace(),
                },
            };
            mockGrpcClient.Setup(x => x.GetScanRunAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ScanRun>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            WebSecurityScannerClient client = new WebSecurityScannerClientImpl(mockGrpcClient.Object, null, null);
            ScanRun responseCallSettings = await client.GetScanRunAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ScanRun responseCancellationToken = await client.GetScanRunAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void StopScanRunRequestObject()
        {
            moq::Mock<WebSecurityScanner.WebSecurityScannerClient> mockGrpcClient = new moq::Mock<WebSecurityScanner.WebSecurityScannerClient>(moq::MockBehavior.Strict);
            StopScanRunRequest request = new StopScanRunRequest
            {
                Name = "name1c9368b0",
            };
            ScanRun expectedResponse = new ScanRun
            {
                Name = "name1c9368b0",
                ExecutionState = ScanRun.Types.ExecutionState.Unspecified,
                ResultState = ScanRun.Types.ResultState.Killed,
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                UrlsCrawledCount = 2307837720024124869L,
                UrlsTestedCount = -373604950692105735L,
                HasVulnerabilities = true,
                ProgressPercent = -412774427,
                ErrorTrace = new ScanRunErrorTrace(),
                WarningTraces =
                {
                    new ScanRunWarningTrace(),
                },
            };
            mockGrpcClient.Setup(x => x.StopScanRun(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            WebSecurityScannerClient client = new WebSecurityScannerClientImpl(mockGrpcClient.Object, null, null);
            ScanRun response = client.StopScanRun(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task StopScanRunRequestObjectAsync()
        {
            moq::Mock<WebSecurityScanner.WebSecurityScannerClient> mockGrpcClient = new moq::Mock<WebSecurityScanner.WebSecurityScannerClient>(moq::MockBehavior.Strict);
            StopScanRunRequest request = new StopScanRunRequest
            {
                Name = "name1c9368b0",
            };
            ScanRun expectedResponse = new ScanRun
            {
                Name = "name1c9368b0",
                ExecutionState = ScanRun.Types.ExecutionState.Unspecified,
                ResultState = ScanRun.Types.ResultState.Killed,
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                UrlsCrawledCount = 2307837720024124869L,
                UrlsTestedCount = -373604950692105735L,
                HasVulnerabilities = true,
                ProgressPercent = -412774427,
                ErrorTrace = new ScanRunErrorTrace(),
                WarningTraces =
                {
                    new ScanRunWarningTrace(),
                },
            };
            mockGrpcClient.Setup(x => x.StopScanRunAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ScanRun>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            WebSecurityScannerClient client = new WebSecurityScannerClientImpl(mockGrpcClient.Object, null, null);
            ScanRun responseCallSettings = await client.StopScanRunAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ScanRun responseCancellationToken = await client.StopScanRunAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetFindingRequestObject()
        {
            moq::Mock<WebSecurityScanner.WebSecurityScannerClient> mockGrpcClient = new moq::Mock<WebSecurityScanner.WebSecurityScannerClient>(moq::MockBehavior.Strict);
            GetFindingRequest request = new GetFindingRequest
            {
                Name = "name1c9368b0",
            };
            Finding expectedResponse = new Finding
            {
                FindingName = FindingName.FromProjectScanConfigScanRunFinding("[PROJECT]", "[SCAN_CONFIG]", "[SCAN_RUN]", "[FINDING]"),
                FindingType = "finding_type0aa10781",
                HttpMethod = "http_method901a5d34",
                FuzzedUrl = "fuzzed_urlf49dd7ba",
                Body = "body682d1a84",
                Description = "description2cf9da67",
                ReproductionUrl = "reproduction_url0e37b71f",
                FrameUrl = "frame_urlbbc6a753",
                FinalUrl = "final_url01c3df1e",
                TrackingId = "tracking_idc631de68",
                OutdatedLibrary = new OutdatedLibrary(),
                ViolatingResource = new ViolatingResource(),
                VulnerableParameters = new VulnerableParameters(),
                Xss = new Xss(),
                VulnerableHeaders = new VulnerableHeaders(),
                Form = new Form(),
                Severity = Finding.Types.Severity.Medium,
            };
            mockGrpcClient.Setup(x => x.GetFinding(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            WebSecurityScannerClient client = new WebSecurityScannerClientImpl(mockGrpcClient.Object, null, null);
            Finding response = client.GetFinding(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetFindingRequestObjectAsync()
        {
            moq::Mock<WebSecurityScanner.WebSecurityScannerClient> mockGrpcClient = new moq::Mock<WebSecurityScanner.WebSecurityScannerClient>(moq::MockBehavior.Strict);
            GetFindingRequest request = new GetFindingRequest
            {
                Name = "name1c9368b0",
            };
            Finding expectedResponse = new Finding
            {
                FindingName = FindingName.FromProjectScanConfigScanRunFinding("[PROJECT]", "[SCAN_CONFIG]", "[SCAN_RUN]", "[FINDING]"),
                FindingType = "finding_type0aa10781",
                HttpMethod = "http_method901a5d34",
                FuzzedUrl = "fuzzed_urlf49dd7ba",
                Body = "body682d1a84",
                Description = "description2cf9da67",
                ReproductionUrl = "reproduction_url0e37b71f",
                FrameUrl = "frame_urlbbc6a753",
                FinalUrl = "final_url01c3df1e",
                TrackingId = "tracking_idc631de68",
                OutdatedLibrary = new OutdatedLibrary(),
                ViolatingResource = new ViolatingResource(),
                VulnerableParameters = new VulnerableParameters(),
                Xss = new Xss(),
                VulnerableHeaders = new VulnerableHeaders(),
                Form = new Form(),
                Severity = Finding.Types.Severity.Medium,
            };
            mockGrpcClient.Setup(x => x.GetFindingAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Finding>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            WebSecurityScannerClient client = new WebSecurityScannerClientImpl(mockGrpcClient.Object, null, null);
            Finding responseCallSettings = await client.GetFindingAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Finding responseCancellationToken = await client.GetFindingAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ListFindingTypeStatsRequestObject()
        {
            moq::Mock<WebSecurityScanner.WebSecurityScannerClient> mockGrpcClient = new moq::Mock<WebSecurityScanner.WebSecurityScannerClient>(moq::MockBehavior.Strict);
            ListFindingTypeStatsRequest request = new ListFindingTypeStatsRequest
            {
                Parent = "parent7858e4d0",
            };
            ListFindingTypeStatsResponse expectedResponse = new ListFindingTypeStatsResponse
            {
                FindingTypeStats =
                {
                    new FindingTypeStats(),
                },
            };
            mockGrpcClient.Setup(x => x.ListFindingTypeStats(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            WebSecurityScannerClient client = new WebSecurityScannerClientImpl(mockGrpcClient.Object, null, null);
            ListFindingTypeStatsResponse response = client.ListFindingTypeStats(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListFindingTypeStatsRequestObjectAsync()
        {
            moq::Mock<WebSecurityScanner.WebSecurityScannerClient> mockGrpcClient = new moq::Mock<WebSecurityScanner.WebSecurityScannerClient>(moq::MockBehavior.Strict);
            ListFindingTypeStatsRequest request = new ListFindingTypeStatsRequest
            {
                Parent = "parent7858e4d0",
            };
            ListFindingTypeStatsResponse expectedResponse = new ListFindingTypeStatsResponse
            {
                FindingTypeStats =
                {
                    new FindingTypeStats(),
                },
            };
            mockGrpcClient.Setup(x => x.ListFindingTypeStatsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ListFindingTypeStatsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            WebSecurityScannerClient client = new WebSecurityScannerClientImpl(mockGrpcClient.Object, null, null);
            ListFindingTypeStatsResponse responseCallSettings = await client.ListFindingTypeStatsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ListFindingTypeStatsResponse responseCancellationToken = await client.ListFindingTypeStatsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
