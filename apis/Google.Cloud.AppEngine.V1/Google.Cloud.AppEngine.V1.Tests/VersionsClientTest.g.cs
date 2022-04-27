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
                AutomaticScaling = new AutomaticScaling(),
                BasicScaling = new BasicScaling(),
                ManualScaling = new ManualScaling(),
                InboundServices =
                {
                    InboundServiceType.InboundServiceXmppPresence,
                },
                InstanceClass = "instance_classa6d8797a",
                Network = new Network(),
                Resources = new Resources(),
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
                CreateTime = new wkt::Timestamp(),
                DiskUsageBytes = 5116400935481479133L,
                RuntimeApiVersion = "runtime_api_version143ef8d8",
                RuntimeMainExecutablePath = "runtime_main_executable_path2a08cfa6",
                Handlers = { new UrlMap(), },
                ErrorHandlers = { new ErrorHandler(), },
                Libraries = { new Library(), },
                ApiConfig = new ApiConfigHandler(),
                EnvVariables =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                DefaultExpiration = new wkt::Duration(),
                HealthCheck = new HealthCheck(),
                NobuildFilesRegex = "nobuild_files_regex78af70e8",
                Deployment = new Deployment(),
                VersionUrl = "version_url9e0b67c2",
                EndpointsApiService = new EndpointsApiService(),
                ReadinessCheck = new ReadinessCheck(),
                LivenessCheck = new LivenessCheck(),
                RuntimeChannel = "runtime_channel010a83ee",
                Zones = { "zones3641f926", },
                VpcAccessConnector = new VpcAccessConnector(),
                Entrypoint = new Entrypoint(),
                BuildEnvVariables =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                ServiceAccount = "service_accounta3c1b923",
                AppEngineApis = false,
            };
            mockGrpcClient.Setup(x => x.GetVersion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VersionsClient client = new VersionsClientImpl(mockGrpcClient.Object, null, null);
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
                AutomaticScaling = new AutomaticScaling(),
                BasicScaling = new BasicScaling(),
                ManualScaling = new ManualScaling(),
                InboundServices =
                {
                    InboundServiceType.InboundServiceXmppPresence,
                },
                InstanceClass = "instance_classa6d8797a",
                Network = new Network(),
                Resources = new Resources(),
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
                CreateTime = new wkt::Timestamp(),
                DiskUsageBytes = 5116400935481479133L,
                RuntimeApiVersion = "runtime_api_version143ef8d8",
                RuntimeMainExecutablePath = "runtime_main_executable_path2a08cfa6",
                Handlers = { new UrlMap(), },
                ErrorHandlers = { new ErrorHandler(), },
                Libraries = { new Library(), },
                ApiConfig = new ApiConfigHandler(),
                EnvVariables =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                DefaultExpiration = new wkt::Duration(),
                HealthCheck = new HealthCheck(),
                NobuildFilesRegex = "nobuild_files_regex78af70e8",
                Deployment = new Deployment(),
                VersionUrl = "version_url9e0b67c2",
                EndpointsApiService = new EndpointsApiService(),
                ReadinessCheck = new ReadinessCheck(),
                LivenessCheck = new LivenessCheck(),
                RuntimeChannel = "runtime_channel010a83ee",
                Zones = { "zones3641f926", },
                VpcAccessConnector = new VpcAccessConnector(),
                Entrypoint = new Entrypoint(),
                BuildEnvVariables =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                ServiceAccount = "service_accounta3c1b923",
                AppEngineApis = false,
            };
            mockGrpcClient.Setup(x => x.GetVersionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Version>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VersionsClient client = new VersionsClientImpl(mockGrpcClient.Object, null, null);
            Version responseCallSettings = await client.GetVersionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Version responseCancellationToken = await client.GetVersionAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
