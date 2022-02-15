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

namespace Google.Cloud.DataFusion.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedDataFusionClientTest
    {
        [xunit::FactAttribute]
        public void GetInstanceRequestObject()
        {
            moq::Mock<DataFusion.DataFusionClient> mockGrpcClient = new moq::Mock<DataFusion.DataFusionClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetInstanceRequest request = new GetInstanceRequest
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
            };
            Instance expectedResponse = new Instance
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                Description = "description2cf9da67",
                Type = Instance.Types.Type.Developer,
                EnableStackdriverLogging = false,
                EnableStackdriverMonitoring = true,
                PrivateInstance = false,
                NetworkConfig = new NetworkConfig(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Options =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                State = Instance.Types.State.Creating,
                StateMessage = "state_message46cf28c0",
                ServiceEndpoint = "service_endpoint15ef9910",
                Zone = "zone255f4ea8",
                Version = "version102ff72a",
#pragma warning disable CS0612
                ServiceAccount = "service_accounta3c1b923",
#pragma warning restore CS0612
                DisplayName = "display_name137f65c2",
                AvailableVersion = { new Version(), },
                ApiEndpoint = "api_endpoint8841b40d",
                GcsBucket = "gcs_bucket69bbfa63",
                Accelerators = { new Accelerator(), },
                P4ServiceAccount = "p4_service_account45918d1c",
                TenantProjectId = "tenant_project_id70b9cf27",
                DataprocServiceAccount = "dataproc_service_account07295e86",
                EnableRbac = true,
                CryptoKeyConfig = new CryptoKeyConfig(),
                DisabledReason =
                {
                    Instance.Types.DisabledReason.KmsKeyIssue,
                },
            };
            mockGrpcClient.Setup(x => x.GetInstance(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataFusionClient client = new DataFusionClientImpl(mockGrpcClient.Object, null);
            Instance response = client.GetInstance(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetInstanceRequestObjectAsync()
        {
            moq::Mock<DataFusion.DataFusionClient> mockGrpcClient = new moq::Mock<DataFusion.DataFusionClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetInstanceRequest request = new GetInstanceRequest
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
            };
            Instance expectedResponse = new Instance
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                Description = "description2cf9da67",
                Type = Instance.Types.Type.Developer,
                EnableStackdriverLogging = false,
                EnableStackdriverMonitoring = true,
                PrivateInstance = false,
                NetworkConfig = new NetworkConfig(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Options =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                State = Instance.Types.State.Creating,
                StateMessage = "state_message46cf28c0",
                ServiceEndpoint = "service_endpoint15ef9910",
                Zone = "zone255f4ea8",
                Version = "version102ff72a",
#pragma warning disable CS0612
                ServiceAccount = "service_accounta3c1b923",
#pragma warning restore CS0612
                DisplayName = "display_name137f65c2",
                AvailableVersion = { new Version(), },
                ApiEndpoint = "api_endpoint8841b40d",
                GcsBucket = "gcs_bucket69bbfa63",
                Accelerators = { new Accelerator(), },
                P4ServiceAccount = "p4_service_account45918d1c",
                TenantProjectId = "tenant_project_id70b9cf27",
                DataprocServiceAccount = "dataproc_service_account07295e86",
                EnableRbac = true,
                CryptoKeyConfig = new CryptoKeyConfig(),
                DisabledReason =
                {
                    Instance.Types.DisabledReason.KmsKeyIssue,
                },
            };
            mockGrpcClient.Setup(x => x.GetInstanceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Instance>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataFusionClient client = new DataFusionClientImpl(mockGrpcClient.Object, null);
            Instance responseCallSettings = await client.GetInstanceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Instance responseCancellationToken = await client.GetInstanceAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
