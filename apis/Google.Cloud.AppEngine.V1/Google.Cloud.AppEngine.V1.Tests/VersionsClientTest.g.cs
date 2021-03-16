// Copyright 2021 Google LLC
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
using lro = Google.LongRunning;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.AppEngine.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedVersionsClientTest
    {
        [xunit::FactAttribute]
        public void GetVersionRequestObject()
        {
            moq::Mock<Versions.VersionsClient> mockGrpcClient = new moq::Mock<Versions.VersionsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetVersionRequest request = new GetVersionRequest
            {
                Name = "name1c9368b0",
                View = VersionView.Full,
            };
            Version expectedResponse = new Version
            {
                Name = "name1c9368b0",
                Id = "id74b70bb8",
                AutomaticScaling = new AutomaticScaling
                {
                    CoolDownPeriod = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    CpuUtilization = new CpuUtilization
                    {
                        AggregationWindowLength = new wkt::Duration
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        TargetUtilization = 1.1389030504197802E+18,
                    },
                    MaxConcurrentRequests = 1855475029,
                    MaxIdleInstances = 1383342257,
                    MaxTotalInstances = 1053748311,
                    MaxPendingLatency = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    MinIdleInstances = -2113016214,
                    MinTotalInstances = -979764809,
                    MinPendingLatency = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    RequestUtilization = new RequestUtilization
                    {
                        TargetRequestCountPerSecond = -1521637440,
                        TargetConcurrentRequests = 1953123473,
                    },
                    DiskUtilization = new DiskUtilization
                    {
                        TargetWriteBytesPerSecond = -572911237,
                        TargetWriteOpsPerSecond = -1958871842,
                        TargetReadBytesPerSecond = 1290761326,
                        TargetReadOpsPerSecond = 104475020,
                    },
                    NetworkUtilization = new NetworkUtilization
                    {
                        TargetSentBytesPerSecond = -1349743714,
                        TargetSentPacketsPerSecond = 766274877,
                        TargetReceivedBytesPerSecond = 1342299801,
                        TargetReceivedPacketsPerSecond = 884657741,
                    },
                    StandardSchedulerSettings = new StandardSchedulerSettings
                    {
                        TargetCpuUtilization = -3.8764054300077914E+17,
                        TargetThroughputUtilization = -1.1214011568610469E+18,
                        MinInstances = 445814344,
                        MaxInstances = -1449803711,
                    },
                },
                BasicScaling = new BasicScaling
                {
                    IdleTimeout = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    MaxInstances = -1449803711,
                },
                ManualScaling = new ManualScaling
                {
                    Instances = 1412606319,
                },
                InboundServices =
                {
                    InboundServiceType.InboundServiceXmppPresence,
                },
                InstanceClass = "instance_classa6d8797a",
                Network = new Network
                {
                    ForwardedPorts =
                    {
                        "forwarded_portsb90c1ed6",
                    },
                    InstanceTag = "instance_tagff8f72e1",
                    Name = "name1c9368b0",
                    SubnetworkName = "subnetwork_name0004b4ef",
                    SessionAffinity = false,
                },
                Resources = new Resources
                {
                    Cpu = -6.328521421855256E+17,
                    DiskGb = 1.1510379243902044E+18,
                    MemoryGb = 1.499659926980353E+17,
                    Volumes =
                    {
                        new Volume
                        {
                            Name = "name1c9368b0",
                            VolumeType = "volume_typee479cc8d",
                            SizeGb = -4.5664623093994285E+17,
                        },
                    },
                    KmsKeyReference = "kms_key_referencea562c812",
                },
                Runtime = "runtime2519a6b4",
                Threadsafe = false,
                Vm = true,
                BetaSettings =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Env = "env1d5a03ff",
                ServingStatus = ServingStatus.Serving,
                CreatedBy = "created_by206bd4da",
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                DiskUsageBytes = 5116400935481479133L,
                RuntimeApiVersion = "runtime_api_version143ef8d8",
                RuntimeMainExecutablePath = "runtime_main_executable_path2a08cfa6",
                Handlers =
                {
                    new UrlMap
                    {
                        UrlRegex = "url_regex18265d4a",
                        StaticFiles = new StaticFilesHandler
                        {
                            Path = "path0b1dfed6",
                            UploadPathRegex = "upload_path_regex9bd674fe",
                            HttpHeaders =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            MimeType = "mime_type606a0ffc",
                            Expiration = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            RequireMatchingFile = true,
                            ApplicationReadable = false,
                        },
                        Script = new ScriptHandler
                        {
                            ScriptPath = "script_path889dee04",
                        },
                        ApiEndpoint = new ApiEndpointHandler
                        {
                            ScriptPath = "script_path889dee04",
                        },
                        SecurityLevel = SecurityLevel.SecureAlways,
                        Login = LoginRequirement.LoginRequired,
                        AuthFailAction = AuthFailAction.Unauthorized,
                        RedirectHttpResponseCode = UrlMap.Types.RedirectHttpResponseCode._307,
                    },
                },
                ErrorHandlers =
                {
                    new ErrorHandler
                    {
                        ErrorCode = ErrorHandler.Types.ErrorCode.Default,
                        StaticFile = "static_filefe91088e",
                        MimeType = "mime_type606a0ffc",
                    },
                },
                Libraries =
                {
                    new Library
                    {
                        Name = "name1c9368b0",
                        Version = "version102ff72a",
                    },
                },
                ApiConfig = new ApiConfigHandler
                {
                    AuthFailAction = AuthFailAction.Unauthorized,
                    Login = LoginRequirement.LoginRequired,
                    Script = "scriptdec00532",
                    SecurityLevel = SecurityLevel.SecureAlways,
                    Url = "url424e2d57",
                },
                EnvVariables =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                DefaultExpiration = new wkt::Duration
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                HealthCheck = new HealthCheck
                {
                    DisableHealthCheck = true,
                    Host = "hosta8dbb367",
                    HealthyThreshold = 3028685007U,
                    UnhealthyThreshold = 3504553770U,
                    RestartThreshold = 2771255278U,
                    CheckInterval = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    Timeout = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                },
                NobuildFilesRegex = "nobuild_files_regex78af70e8",
                Deployment = new Deployment
                {
                    Files =
                    {
                        {
                            "key8a0b6e3c",
                            new FileInfo
                            {
                                SourceUrl = "source_url5da5c845",
                                Sha1Sum = "sha1_sum21b6d076",
                                MimeType = "mime_type606a0ffc",
                            }
                        },
                    },
                    Container = new ContainerInfo
                    {
                        Image = "image225a8078",
                    },
                    Zip = new ZipInfo
                    {
                        SourceUrl = "source_url5da5c845",
                        FilesCount = 134617536,
                    },
                    CloudBuildOptions = new CloudBuildOptions
                    {
                        AppYamlPath = "app_yaml_path5a5370c0",
                        CloudBuildTimeout = new wkt::Duration
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                    },
                },
                VersionUrl = "version_url9e0b67c2",
                EndpointsApiService = new EndpointsApiService
                {
                    Name = "name1c9368b0",
                    ConfigId = "config_id908a73d1",
                    RolloutStrategy = EndpointsApiService.Types.RolloutStrategy.UnspecifiedRolloutStrategy,
                    DisableTraceSampling = true,
                },
                ReadinessCheck = new ReadinessCheck
                {
                    Path = "path0b1dfed6",
                    Host = "hosta8dbb367",
                    FailureThreshold = 3383962666U,
                    SuccessThreshold = 4059302783U,
                    CheckInterval = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    Timeout = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    AppStartTimeout = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                },
                LivenessCheck = new LivenessCheck
                {
                    Path = "path0b1dfed6",
                    Host = "hosta8dbb367",
                    FailureThreshold = 3383962666U,
                    SuccessThreshold = 4059302783U,
                    CheckInterval = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    Timeout = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    InitialDelay = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                },
                RuntimeChannel = "runtime_channel010a83ee",
                Zones = { "zones3641f926", },
                VpcAccessConnector = new VpcAccessConnector
                {
                    Name = "name1c9368b0",
                },
                Entrypoint = new Entrypoint
                {
                    Shell = "shell8bc99125",
                },
                BuildEnvVariables =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                ServiceAccount = "service_accounta3c1b923",
            };
            mockGrpcClient.Setup(x => x.GetVersion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VersionsClient client = new VersionsClientImpl(mockGrpcClient.Object, null);
            Version response = client.GetVersion(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetVersionRequestObjectAsync()
        {
            moq::Mock<Versions.VersionsClient> mockGrpcClient = new moq::Mock<Versions.VersionsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetVersionRequest request = new GetVersionRequest
            {
                Name = "name1c9368b0",
                View = VersionView.Full,
            };
            Version expectedResponse = new Version
            {
                Name = "name1c9368b0",
                Id = "id74b70bb8",
                AutomaticScaling = new AutomaticScaling
                {
                    CoolDownPeriod = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    CpuUtilization = new CpuUtilization
                    {
                        AggregationWindowLength = new wkt::Duration
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        TargetUtilization = 1.1389030504197802E+18,
                    },
                    MaxConcurrentRequests = 1855475029,
                    MaxIdleInstances = 1383342257,
                    MaxTotalInstances = 1053748311,
                    MaxPendingLatency = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    MinIdleInstances = -2113016214,
                    MinTotalInstances = -979764809,
                    MinPendingLatency = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    RequestUtilization = new RequestUtilization
                    {
                        TargetRequestCountPerSecond = -1521637440,
                        TargetConcurrentRequests = 1953123473,
                    },
                    DiskUtilization = new DiskUtilization
                    {
                        TargetWriteBytesPerSecond = -572911237,
                        TargetWriteOpsPerSecond = -1958871842,
                        TargetReadBytesPerSecond = 1290761326,
                        TargetReadOpsPerSecond = 104475020,
                    },
                    NetworkUtilization = new NetworkUtilization
                    {
                        TargetSentBytesPerSecond = -1349743714,
                        TargetSentPacketsPerSecond = 766274877,
                        TargetReceivedBytesPerSecond = 1342299801,
                        TargetReceivedPacketsPerSecond = 884657741,
                    },
                    StandardSchedulerSettings = new StandardSchedulerSettings
                    {
                        TargetCpuUtilization = -3.8764054300077914E+17,
                        TargetThroughputUtilization = -1.1214011568610469E+18,
                        MinInstances = 445814344,
                        MaxInstances = -1449803711,
                    },
                },
                BasicScaling = new BasicScaling
                {
                    IdleTimeout = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    MaxInstances = -1449803711,
                },
                ManualScaling = new ManualScaling
                {
                    Instances = 1412606319,
                },
                InboundServices =
                {
                    InboundServiceType.InboundServiceXmppPresence,
                },
                InstanceClass = "instance_classa6d8797a",
                Network = new Network
                {
                    ForwardedPorts =
                    {
                        "forwarded_portsb90c1ed6",
                    },
                    InstanceTag = "instance_tagff8f72e1",
                    Name = "name1c9368b0",
                    SubnetworkName = "subnetwork_name0004b4ef",
                    SessionAffinity = false,
                },
                Resources = new Resources
                {
                    Cpu = -6.328521421855256E+17,
                    DiskGb = 1.1510379243902044E+18,
                    MemoryGb = 1.499659926980353E+17,
                    Volumes =
                    {
                        new Volume
                        {
                            Name = "name1c9368b0",
                            VolumeType = "volume_typee479cc8d",
                            SizeGb = -4.5664623093994285E+17,
                        },
                    },
                    KmsKeyReference = "kms_key_referencea562c812",
                },
                Runtime = "runtime2519a6b4",
                Threadsafe = false,
                Vm = true,
                BetaSettings =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Env = "env1d5a03ff",
                ServingStatus = ServingStatus.Serving,
                CreatedBy = "created_by206bd4da",
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                DiskUsageBytes = 5116400935481479133L,
                RuntimeApiVersion = "runtime_api_version143ef8d8",
                RuntimeMainExecutablePath = "runtime_main_executable_path2a08cfa6",
                Handlers =
                {
                    new UrlMap
                    {
                        UrlRegex = "url_regex18265d4a",
                        StaticFiles = new StaticFilesHandler
                        {
                            Path = "path0b1dfed6",
                            UploadPathRegex = "upload_path_regex9bd674fe",
                            HttpHeaders =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            MimeType = "mime_type606a0ffc",
                            Expiration = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            RequireMatchingFile = true,
                            ApplicationReadable = false,
                        },
                        Script = new ScriptHandler
                        {
                            ScriptPath = "script_path889dee04",
                        },
                        ApiEndpoint = new ApiEndpointHandler
                        {
                            ScriptPath = "script_path889dee04",
                        },
                        SecurityLevel = SecurityLevel.SecureAlways,
                        Login = LoginRequirement.LoginRequired,
                        AuthFailAction = AuthFailAction.Unauthorized,
                        RedirectHttpResponseCode = UrlMap.Types.RedirectHttpResponseCode._307,
                    },
                },
                ErrorHandlers =
                {
                    new ErrorHandler
                    {
                        ErrorCode = ErrorHandler.Types.ErrorCode.Default,
                        StaticFile = "static_filefe91088e",
                        MimeType = "mime_type606a0ffc",
                    },
                },
                Libraries =
                {
                    new Library
                    {
                        Name = "name1c9368b0",
                        Version = "version102ff72a",
                    },
                },
                ApiConfig = new ApiConfigHandler
                {
                    AuthFailAction = AuthFailAction.Unauthorized,
                    Login = LoginRequirement.LoginRequired,
                    Script = "scriptdec00532",
                    SecurityLevel = SecurityLevel.SecureAlways,
                    Url = "url424e2d57",
                },
                EnvVariables =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                DefaultExpiration = new wkt::Duration
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                HealthCheck = new HealthCheck
                {
                    DisableHealthCheck = true,
                    Host = "hosta8dbb367",
                    HealthyThreshold = 3028685007U,
                    UnhealthyThreshold = 3504553770U,
                    RestartThreshold = 2771255278U,
                    CheckInterval = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    Timeout = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                },
                NobuildFilesRegex = "nobuild_files_regex78af70e8",
                Deployment = new Deployment
                {
                    Files =
                    {
                        {
                            "key8a0b6e3c",
                            new FileInfo
                            {
                                SourceUrl = "source_url5da5c845",
                                Sha1Sum = "sha1_sum21b6d076",
                                MimeType = "mime_type606a0ffc",
                            }
                        },
                    },
                    Container = new ContainerInfo
                    {
                        Image = "image225a8078",
                    },
                    Zip = new ZipInfo
                    {
                        SourceUrl = "source_url5da5c845",
                        FilesCount = 134617536,
                    },
                    CloudBuildOptions = new CloudBuildOptions
                    {
                        AppYamlPath = "app_yaml_path5a5370c0",
                        CloudBuildTimeout = new wkt::Duration
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                    },
                },
                VersionUrl = "version_url9e0b67c2",
                EndpointsApiService = new EndpointsApiService
                {
                    Name = "name1c9368b0",
                    ConfigId = "config_id908a73d1",
                    RolloutStrategy = EndpointsApiService.Types.RolloutStrategy.UnspecifiedRolloutStrategy,
                    DisableTraceSampling = true,
                },
                ReadinessCheck = new ReadinessCheck
                {
                    Path = "path0b1dfed6",
                    Host = "hosta8dbb367",
                    FailureThreshold = 3383962666U,
                    SuccessThreshold = 4059302783U,
                    CheckInterval = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    Timeout = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    AppStartTimeout = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                },
                LivenessCheck = new LivenessCheck
                {
                    Path = "path0b1dfed6",
                    Host = "hosta8dbb367",
                    FailureThreshold = 3383962666U,
                    SuccessThreshold = 4059302783U,
                    CheckInterval = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    Timeout = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    InitialDelay = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                },
                RuntimeChannel = "runtime_channel010a83ee",
                Zones = { "zones3641f926", },
                VpcAccessConnector = new VpcAccessConnector
                {
                    Name = "name1c9368b0",
                },
                Entrypoint = new Entrypoint
                {
                    Shell = "shell8bc99125",
                },
                BuildEnvVariables =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                ServiceAccount = "service_accounta3c1b923",
            };
            mockGrpcClient.Setup(x => x.GetVersionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Version>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VersionsClient client = new VersionsClientImpl(mockGrpcClient.Object, null);
            Version responseCallSettings = await client.GetVersionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Version responseCancellationToken = await client.GetVersionAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
