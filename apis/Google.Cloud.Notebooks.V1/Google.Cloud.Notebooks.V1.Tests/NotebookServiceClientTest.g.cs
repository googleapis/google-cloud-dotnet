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

namespace Google.Cloud.Notebooks.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedNotebookServiceClientTest
    {
        [xunit::FactAttribute]
        public void GetInstanceRequestObject()
        {
            moq::Mock<NotebookService.NotebookServiceClient> mockGrpcClient = new moq::Mock<NotebookService.NotebookServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetInstanceRequest request = new GetInstanceRequest
            {
                Name = "name1c9368b0",
            };
            Instance expectedResponse = new Instance
            {
                InstanceName = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
                VmImage = new VmImage(),
                ContainerImage = new ContainerImage(),
                PostStartupScript = "post_startup_script0d185c71",
                ProxyUri = "proxy_uri73c5439d",
                InstanceOwners =
                {
                    "instance_owners34378c03",
                },
                ServiceAccount = "service_accounta3c1b923",
                MachineType = "machine_type68ce40fa",
                AcceleratorConfig = new Instance.Types.AcceleratorConfig(),
                State = Instance.Types.State.Initializing,
                InstallGpuDriver = true,
                CustomGpuDriverPath = "custom_gpu_driver_path24577c2a",
                BootDiskType = Instance.Types.DiskType.PdSsd,
                BootDiskSizeGb = -3633932070397520346L,
                DiskEncryption = Instance.Types.DiskEncryption.Cmek,
                KmsKey = "kms_key0b21601b",
                NoPublicIp = true,
                NoProxyAccess = false,
                Network = "networkd22ce091",
                Subnet = "subnet0666554f",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Metadata =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DataDiskType = Instance.Types.DiskType.Unspecified,
                DataDiskSizeGb = 8597103336273737467L,
                NoRemoveDataDisk = true,
                Disks =
                {
                    new Instance.Types.Disk(),
                },
                UpgradeHistory =
                {
                    new Instance.Types.UpgradeHistoryEntry(),
                },
                ShieldedInstanceConfig = new Instance.Types.ShieldedInstanceConfig(),
                ServiceAccountScopes =
                {
                    "service_account_scopesd4b7f658",
                },
                Tags = { "tags52c47ad5", },
                NicType = Instance.Types.NicType.Gvnic,
                ReservationAffinity = new ReservationAffinity(),
            };
            mockGrpcClient.Setup(x => x.GetInstance(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            NotebookServiceClient client = new NotebookServiceClientImpl(mockGrpcClient.Object, null);
            Instance response = client.GetInstance(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetInstanceRequestObjectAsync()
        {
            moq::Mock<NotebookService.NotebookServiceClient> mockGrpcClient = new moq::Mock<NotebookService.NotebookServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetInstanceRequest request = new GetInstanceRequest
            {
                Name = "name1c9368b0",
            };
            Instance expectedResponse = new Instance
            {
                InstanceName = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
                VmImage = new VmImage(),
                ContainerImage = new ContainerImage(),
                PostStartupScript = "post_startup_script0d185c71",
                ProxyUri = "proxy_uri73c5439d",
                InstanceOwners =
                {
                    "instance_owners34378c03",
                },
                ServiceAccount = "service_accounta3c1b923",
                MachineType = "machine_type68ce40fa",
                AcceleratorConfig = new Instance.Types.AcceleratorConfig(),
                State = Instance.Types.State.Initializing,
                InstallGpuDriver = true,
                CustomGpuDriverPath = "custom_gpu_driver_path24577c2a",
                BootDiskType = Instance.Types.DiskType.PdSsd,
                BootDiskSizeGb = -3633932070397520346L,
                DiskEncryption = Instance.Types.DiskEncryption.Cmek,
                KmsKey = "kms_key0b21601b",
                NoPublicIp = true,
                NoProxyAccess = false,
                Network = "networkd22ce091",
                Subnet = "subnet0666554f",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Metadata =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DataDiskType = Instance.Types.DiskType.Unspecified,
                DataDiskSizeGb = 8597103336273737467L,
                NoRemoveDataDisk = true,
                Disks =
                {
                    new Instance.Types.Disk(),
                },
                UpgradeHistory =
                {
                    new Instance.Types.UpgradeHistoryEntry(),
                },
                ShieldedInstanceConfig = new Instance.Types.ShieldedInstanceConfig(),
                ServiceAccountScopes =
                {
                    "service_account_scopesd4b7f658",
                },
                Tags = { "tags52c47ad5", },
                NicType = Instance.Types.NicType.Gvnic,
                ReservationAffinity = new ReservationAffinity(),
            };
            mockGrpcClient.Setup(x => x.GetInstanceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Instance>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            NotebookServiceClient client = new NotebookServiceClientImpl(mockGrpcClient.Object, null);
            Instance responseCallSettings = await client.GetInstanceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Instance responseCancellationToken = await client.GetInstanceAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetInstance()
        {
            moq::Mock<NotebookService.NotebookServiceClient> mockGrpcClient = new moq::Mock<NotebookService.NotebookServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetInstanceRequest request = new GetInstanceRequest
            {
                Name = "name1c9368b0",
            };
            Instance expectedResponse = new Instance
            {
                InstanceName = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
                VmImage = new VmImage(),
                ContainerImage = new ContainerImage(),
                PostStartupScript = "post_startup_script0d185c71",
                ProxyUri = "proxy_uri73c5439d",
                InstanceOwners =
                {
                    "instance_owners34378c03",
                },
                ServiceAccount = "service_accounta3c1b923",
                MachineType = "machine_type68ce40fa",
                AcceleratorConfig = new Instance.Types.AcceleratorConfig(),
                State = Instance.Types.State.Initializing,
                InstallGpuDriver = true,
                CustomGpuDriverPath = "custom_gpu_driver_path24577c2a",
                BootDiskType = Instance.Types.DiskType.PdSsd,
                BootDiskSizeGb = -3633932070397520346L,
                DiskEncryption = Instance.Types.DiskEncryption.Cmek,
                KmsKey = "kms_key0b21601b",
                NoPublicIp = true,
                NoProxyAccess = false,
                Network = "networkd22ce091",
                Subnet = "subnet0666554f",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Metadata =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DataDiskType = Instance.Types.DiskType.Unspecified,
                DataDiskSizeGb = 8597103336273737467L,
                NoRemoveDataDisk = true,
                Disks =
                {
                    new Instance.Types.Disk(),
                },
                UpgradeHistory =
                {
                    new Instance.Types.UpgradeHistoryEntry(),
                },
                ShieldedInstanceConfig = new Instance.Types.ShieldedInstanceConfig(),
                ServiceAccountScopes =
                {
                    "service_account_scopesd4b7f658",
                },
                Tags = { "tags52c47ad5", },
                NicType = Instance.Types.NicType.Gvnic,
                ReservationAffinity = new ReservationAffinity(),
            };
            mockGrpcClient.Setup(x => x.GetInstance(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            NotebookServiceClient client = new NotebookServiceClientImpl(mockGrpcClient.Object, null);
            Instance response = client.GetInstance(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetInstanceAsync()
        {
            moq::Mock<NotebookService.NotebookServiceClient> mockGrpcClient = new moq::Mock<NotebookService.NotebookServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetInstanceRequest request = new GetInstanceRequest
            {
                Name = "name1c9368b0",
            };
            Instance expectedResponse = new Instance
            {
                InstanceName = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
                VmImage = new VmImage(),
                ContainerImage = new ContainerImage(),
                PostStartupScript = "post_startup_script0d185c71",
                ProxyUri = "proxy_uri73c5439d",
                InstanceOwners =
                {
                    "instance_owners34378c03",
                },
                ServiceAccount = "service_accounta3c1b923",
                MachineType = "machine_type68ce40fa",
                AcceleratorConfig = new Instance.Types.AcceleratorConfig(),
                State = Instance.Types.State.Initializing,
                InstallGpuDriver = true,
                CustomGpuDriverPath = "custom_gpu_driver_path24577c2a",
                BootDiskType = Instance.Types.DiskType.PdSsd,
                BootDiskSizeGb = -3633932070397520346L,
                DiskEncryption = Instance.Types.DiskEncryption.Cmek,
                KmsKey = "kms_key0b21601b",
                NoPublicIp = true,
                NoProxyAccess = false,
                Network = "networkd22ce091",
                Subnet = "subnet0666554f",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Metadata =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DataDiskType = Instance.Types.DiskType.Unspecified,
                DataDiskSizeGb = 8597103336273737467L,
                NoRemoveDataDisk = true,
                Disks =
                {
                    new Instance.Types.Disk(),
                },
                UpgradeHistory =
                {
                    new Instance.Types.UpgradeHistoryEntry(),
                },
                ShieldedInstanceConfig = new Instance.Types.ShieldedInstanceConfig(),
                ServiceAccountScopes =
                {
                    "service_account_scopesd4b7f658",
                },
                Tags = { "tags52c47ad5", },
                NicType = Instance.Types.NicType.Gvnic,
                ReservationAffinity = new ReservationAffinity(),
            };
            mockGrpcClient.Setup(x => x.GetInstanceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Instance>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            NotebookServiceClient client = new NotebookServiceClientImpl(mockGrpcClient.Object, null);
            Instance responseCallSettings = await client.GetInstanceAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Instance responseCancellationToken = await client.GetInstanceAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void IsInstanceUpgradeableRequestObject()
        {
            moq::Mock<NotebookService.NotebookServiceClient> mockGrpcClient = new moq::Mock<NotebookService.NotebookServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            IsInstanceUpgradeableRequest request = new IsInstanceUpgradeableRequest
            {
                NotebookInstance = "notebook_instance62ef1454",
            };
            IsInstanceUpgradeableResponse expectedResponse = new IsInstanceUpgradeableResponse
            {
                Upgradeable = false,
                UpgradeVersion = "upgrade_version716e0863",
                UpgradeInfo = "upgrade_info29eca0a2",
                UpgradeImage = "upgrade_image84c2e9b0",
            };
            mockGrpcClient.Setup(x => x.IsInstanceUpgradeable(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            NotebookServiceClient client = new NotebookServiceClientImpl(mockGrpcClient.Object, null);
            IsInstanceUpgradeableResponse response = client.IsInstanceUpgradeable(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task IsInstanceUpgradeableRequestObjectAsync()
        {
            moq::Mock<NotebookService.NotebookServiceClient> mockGrpcClient = new moq::Mock<NotebookService.NotebookServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            IsInstanceUpgradeableRequest request = new IsInstanceUpgradeableRequest
            {
                NotebookInstance = "notebook_instance62ef1454",
            };
            IsInstanceUpgradeableResponse expectedResponse = new IsInstanceUpgradeableResponse
            {
                Upgradeable = false,
                UpgradeVersion = "upgrade_version716e0863",
                UpgradeInfo = "upgrade_info29eca0a2",
                UpgradeImage = "upgrade_image84c2e9b0",
            };
            mockGrpcClient.Setup(x => x.IsInstanceUpgradeableAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<IsInstanceUpgradeableResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            NotebookServiceClient client = new NotebookServiceClientImpl(mockGrpcClient.Object, null);
            IsInstanceUpgradeableResponse responseCallSettings = await client.IsInstanceUpgradeableAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            IsInstanceUpgradeableResponse responseCancellationToken = await client.IsInstanceUpgradeableAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetInstanceHealthRequestObject()
        {
            moq::Mock<NotebookService.NotebookServiceClient> mockGrpcClient = new moq::Mock<NotebookService.NotebookServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetInstanceHealthRequest request = new GetInstanceHealthRequest
            {
                InstanceName = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
            };
            GetInstanceHealthResponse expectedResponse = new GetInstanceHealthResponse
            {
                HealthState = GetInstanceHealthResponse.Types.HealthState.Unhealthy,
                HealthInfo =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetInstanceHealth(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            NotebookServiceClient client = new NotebookServiceClientImpl(mockGrpcClient.Object, null);
            GetInstanceHealthResponse response = client.GetInstanceHealth(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetInstanceHealthRequestObjectAsync()
        {
            moq::Mock<NotebookService.NotebookServiceClient> mockGrpcClient = new moq::Mock<NotebookService.NotebookServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetInstanceHealthRequest request = new GetInstanceHealthRequest
            {
                InstanceName = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
            };
            GetInstanceHealthResponse expectedResponse = new GetInstanceHealthResponse
            {
                HealthState = GetInstanceHealthResponse.Types.HealthState.Unhealthy,
                HealthInfo =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetInstanceHealthAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<GetInstanceHealthResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            NotebookServiceClient client = new NotebookServiceClientImpl(mockGrpcClient.Object, null);
            GetInstanceHealthResponse responseCallSettings = await client.GetInstanceHealthAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            GetInstanceHealthResponse responseCancellationToken = await client.GetInstanceHealthAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetInstanceHealth()
        {
            moq::Mock<NotebookService.NotebookServiceClient> mockGrpcClient = new moq::Mock<NotebookService.NotebookServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetInstanceHealthRequest request = new GetInstanceHealthRequest
            {
                InstanceName = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
            };
            GetInstanceHealthResponse expectedResponse = new GetInstanceHealthResponse
            {
                HealthState = GetInstanceHealthResponse.Types.HealthState.Unhealthy,
                HealthInfo =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetInstanceHealth(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            NotebookServiceClient client = new NotebookServiceClientImpl(mockGrpcClient.Object, null);
            GetInstanceHealthResponse response = client.GetInstanceHealth(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetInstanceHealthAsync()
        {
            moq::Mock<NotebookService.NotebookServiceClient> mockGrpcClient = new moq::Mock<NotebookService.NotebookServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetInstanceHealthRequest request = new GetInstanceHealthRequest
            {
                InstanceName = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
            };
            GetInstanceHealthResponse expectedResponse = new GetInstanceHealthResponse
            {
                HealthState = GetInstanceHealthResponse.Types.HealthState.Unhealthy,
                HealthInfo =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetInstanceHealthAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<GetInstanceHealthResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            NotebookServiceClient client = new NotebookServiceClientImpl(mockGrpcClient.Object, null);
            GetInstanceHealthResponse responseCallSettings = await client.GetInstanceHealthAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            GetInstanceHealthResponse responseCancellationToken = await client.GetInstanceHealthAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetInstanceHealthResourceNames()
        {
            moq::Mock<NotebookService.NotebookServiceClient> mockGrpcClient = new moq::Mock<NotebookService.NotebookServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetInstanceHealthRequest request = new GetInstanceHealthRequest
            {
                InstanceName = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
            };
            GetInstanceHealthResponse expectedResponse = new GetInstanceHealthResponse
            {
                HealthState = GetInstanceHealthResponse.Types.HealthState.Unhealthy,
                HealthInfo =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetInstanceHealth(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            NotebookServiceClient client = new NotebookServiceClientImpl(mockGrpcClient.Object, null);
            GetInstanceHealthResponse response = client.GetInstanceHealth(request.InstanceName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetInstanceHealthResourceNamesAsync()
        {
            moq::Mock<NotebookService.NotebookServiceClient> mockGrpcClient = new moq::Mock<NotebookService.NotebookServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetInstanceHealthRequest request = new GetInstanceHealthRequest
            {
                InstanceName = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
            };
            GetInstanceHealthResponse expectedResponse = new GetInstanceHealthResponse
            {
                HealthState = GetInstanceHealthResponse.Types.HealthState.Unhealthy,
                HealthInfo =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetInstanceHealthAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<GetInstanceHealthResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            NotebookServiceClient client = new NotebookServiceClientImpl(mockGrpcClient.Object, null);
            GetInstanceHealthResponse responseCallSettings = await client.GetInstanceHealthAsync(request.InstanceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            GetInstanceHealthResponse responseCancellationToken = await client.GetInstanceHealthAsync(request.InstanceName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetEnvironmentRequestObject()
        {
            moq::Mock<NotebookService.NotebookServiceClient> mockGrpcClient = new moq::Mock<NotebookService.NotebookServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetEnvironmentRequest request = new GetEnvironmentRequest
            {
                Name = "name1c9368b0",
            };
            Environment expectedResponse = new Environment
            {
                EnvironmentName = EnvironmentName.FromProjectEnvironment("[PROJECT]", "[ENVIRONMENT]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                VmImage = new VmImage(),
                ContainerImage = new ContainerImage(),
                PostStartupScript = "post_startup_script0d185c71",
                CreateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetEnvironment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            NotebookServiceClient client = new NotebookServiceClientImpl(mockGrpcClient.Object, null);
            Environment response = client.GetEnvironment(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetEnvironmentRequestObjectAsync()
        {
            moq::Mock<NotebookService.NotebookServiceClient> mockGrpcClient = new moq::Mock<NotebookService.NotebookServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetEnvironmentRequest request = new GetEnvironmentRequest
            {
                Name = "name1c9368b0",
            };
            Environment expectedResponse = new Environment
            {
                EnvironmentName = EnvironmentName.FromProjectEnvironment("[PROJECT]", "[ENVIRONMENT]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                VmImage = new VmImage(),
                ContainerImage = new ContainerImage(),
                PostStartupScript = "post_startup_script0d185c71",
                CreateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetEnvironmentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Environment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            NotebookServiceClient client = new NotebookServiceClientImpl(mockGrpcClient.Object, null);
            Environment responseCallSettings = await client.GetEnvironmentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Environment responseCancellationToken = await client.GetEnvironmentAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetEnvironment()
        {
            moq::Mock<NotebookService.NotebookServiceClient> mockGrpcClient = new moq::Mock<NotebookService.NotebookServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetEnvironmentRequest request = new GetEnvironmentRequest
            {
                Name = "name1c9368b0",
            };
            Environment expectedResponse = new Environment
            {
                EnvironmentName = EnvironmentName.FromProjectEnvironment("[PROJECT]", "[ENVIRONMENT]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                VmImage = new VmImage(),
                ContainerImage = new ContainerImage(),
                PostStartupScript = "post_startup_script0d185c71",
                CreateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetEnvironment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            NotebookServiceClient client = new NotebookServiceClientImpl(mockGrpcClient.Object, null);
            Environment response = client.GetEnvironment(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetEnvironmentAsync()
        {
            moq::Mock<NotebookService.NotebookServiceClient> mockGrpcClient = new moq::Mock<NotebookService.NotebookServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetEnvironmentRequest request = new GetEnvironmentRequest
            {
                Name = "name1c9368b0",
            };
            Environment expectedResponse = new Environment
            {
                EnvironmentName = EnvironmentName.FromProjectEnvironment("[PROJECT]", "[ENVIRONMENT]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                VmImage = new VmImage(),
                ContainerImage = new ContainerImage(),
                PostStartupScript = "post_startup_script0d185c71",
                CreateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetEnvironmentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Environment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            NotebookServiceClient client = new NotebookServiceClientImpl(mockGrpcClient.Object, null);
            Environment responseCallSettings = await client.GetEnvironmentAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Environment responseCancellationToken = await client.GetEnvironmentAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetScheduleRequestObject()
        {
            moq::Mock<NotebookService.NotebookServiceClient> mockGrpcClient = new moq::Mock<NotebookService.NotebookServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetScheduleRequest request = new GetScheduleRequest
            {
                ScheduleName = ScheduleName.FromProjectLocationSchedule("[PROJECT]", "[LOCATION]", "[SCHEDULE]"),
            };
            Schedule expectedResponse = new Schedule
            {
                ScheduleName = ScheduleName.FromProjectLocationSchedule("[PROJECT]", "[LOCATION]", "[SCHEDULE]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                State = Schedule.Types.State.Deleting,
                CronSchedule = "cron_schedulee564a4b3",
                TimeZone = "time_zone73f23b20",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                ExecutionTemplate = new ExecutionTemplate(),
                RecentExecutions = { new Execution(), },
            };
            mockGrpcClient.Setup(x => x.GetSchedule(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            NotebookServiceClient client = new NotebookServiceClientImpl(mockGrpcClient.Object, null);
            Schedule response = client.GetSchedule(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetScheduleRequestObjectAsync()
        {
            moq::Mock<NotebookService.NotebookServiceClient> mockGrpcClient = new moq::Mock<NotebookService.NotebookServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetScheduleRequest request = new GetScheduleRequest
            {
                ScheduleName = ScheduleName.FromProjectLocationSchedule("[PROJECT]", "[LOCATION]", "[SCHEDULE]"),
            };
            Schedule expectedResponse = new Schedule
            {
                ScheduleName = ScheduleName.FromProjectLocationSchedule("[PROJECT]", "[LOCATION]", "[SCHEDULE]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                State = Schedule.Types.State.Deleting,
                CronSchedule = "cron_schedulee564a4b3",
                TimeZone = "time_zone73f23b20",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                ExecutionTemplate = new ExecutionTemplate(),
                RecentExecutions = { new Execution(), },
            };
            mockGrpcClient.Setup(x => x.GetScheduleAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Schedule>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            NotebookServiceClient client = new NotebookServiceClientImpl(mockGrpcClient.Object, null);
            Schedule responseCallSettings = await client.GetScheduleAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Schedule responseCancellationToken = await client.GetScheduleAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetSchedule()
        {
            moq::Mock<NotebookService.NotebookServiceClient> mockGrpcClient = new moq::Mock<NotebookService.NotebookServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetScheduleRequest request = new GetScheduleRequest
            {
                ScheduleName = ScheduleName.FromProjectLocationSchedule("[PROJECT]", "[LOCATION]", "[SCHEDULE]"),
            };
            Schedule expectedResponse = new Schedule
            {
                ScheduleName = ScheduleName.FromProjectLocationSchedule("[PROJECT]", "[LOCATION]", "[SCHEDULE]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                State = Schedule.Types.State.Deleting,
                CronSchedule = "cron_schedulee564a4b3",
                TimeZone = "time_zone73f23b20",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                ExecutionTemplate = new ExecutionTemplate(),
                RecentExecutions = { new Execution(), },
            };
            mockGrpcClient.Setup(x => x.GetSchedule(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            NotebookServiceClient client = new NotebookServiceClientImpl(mockGrpcClient.Object, null);
            Schedule response = client.GetSchedule(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetScheduleAsync()
        {
            moq::Mock<NotebookService.NotebookServiceClient> mockGrpcClient = new moq::Mock<NotebookService.NotebookServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetScheduleRequest request = new GetScheduleRequest
            {
                ScheduleName = ScheduleName.FromProjectLocationSchedule("[PROJECT]", "[LOCATION]", "[SCHEDULE]"),
            };
            Schedule expectedResponse = new Schedule
            {
                ScheduleName = ScheduleName.FromProjectLocationSchedule("[PROJECT]", "[LOCATION]", "[SCHEDULE]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                State = Schedule.Types.State.Deleting,
                CronSchedule = "cron_schedulee564a4b3",
                TimeZone = "time_zone73f23b20",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                ExecutionTemplate = new ExecutionTemplate(),
                RecentExecutions = { new Execution(), },
            };
            mockGrpcClient.Setup(x => x.GetScheduleAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Schedule>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            NotebookServiceClient client = new NotebookServiceClientImpl(mockGrpcClient.Object, null);
            Schedule responseCallSettings = await client.GetScheduleAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Schedule responseCancellationToken = await client.GetScheduleAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetScheduleResourceNames()
        {
            moq::Mock<NotebookService.NotebookServiceClient> mockGrpcClient = new moq::Mock<NotebookService.NotebookServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetScheduleRequest request = new GetScheduleRequest
            {
                ScheduleName = ScheduleName.FromProjectLocationSchedule("[PROJECT]", "[LOCATION]", "[SCHEDULE]"),
            };
            Schedule expectedResponse = new Schedule
            {
                ScheduleName = ScheduleName.FromProjectLocationSchedule("[PROJECT]", "[LOCATION]", "[SCHEDULE]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                State = Schedule.Types.State.Deleting,
                CronSchedule = "cron_schedulee564a4b3",
                TimeZone = "time_zone73f23b20",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                ExecutionTemplate = new ExecutionTemplate(),
                RecentExecutions = { new Execution(), },
            };
            mockGrpcClient.Setup(x => x.GetSchedule(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            NotebookServiceClient client = new NotebookServiceClientImpl(mockGrpcClient.Object, null);
            Schedule response = client.GetSchedule(request.ScheduleName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetScheduleResourceNamesAsync()
        {
            moq::Mock<NotebookService.NotebookServiceClient> mockGrpcClient = new moq::Mock<NotebookService.NotebookServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetScheduleRequest request = new GetScheduleRequest
            {
                ScheduleName = ScheduleName.FromProjectLocationSchedule("[PROJECT]", "[LOCATION]", "[SCHEDULE]"),
            };
            Schedule expectedResponse = new Schedule
            {
                ScheduleName = ScheduleName.FromProjectLocationSchedule("[PROJECT]", "[LOCATION]", "[SCHEDULE]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                State = Schedule.Types.State.Deleting,
                CronSchedule = "cron_schedulee564a4b3",
                TimeZone = "time_zone73f23b20",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                ExecutionTemplate = new ExecutionTemplate(),
                RecentExecutions = { new Execution(), },
            };
            mockGrpcClient.Setup(x => x.GetScheduleAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Schedule>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            NotebookServiceClient client = new NotebookServiceClientImpl(mockGrpcClient.Object, null);
            Schedule responseCallSettings = await client.GetScheduleAsync(request.ScheduleName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Schedule responseCancellationToken = await client.GetScheduleAsync(request.ScheduleName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetExecutionRequestObject()
        {
            moq::Mock<NotebookService.NotebookServiceClient> mockGrpcClient = new moq::Mock<NotebookService.NotebookServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetExecutionRequest request = new GetExecutionRequest
            {
                ExecutionName = ExecutionName.FromProjectLocationExecution("[PROJECT]", "[LOCATION]", "[EXECUTION]"),
            };
            Execution expectedResponse = new Execution
            {
                ExecutionTemplate = new ExecutionTemplate(),
                ExecutionName = ExecutionName.FromProjectLocationExecution("[PROJECT]", "[LOCATION]", "[EXECUTION]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                State = Execution.Types.State.Expired,
                OutputNotebookFile = "output_notebook_file4938a367",
                JobUri = "job_uria032473c",
            };
            mockGrpcClient.Setup(x => x.GetExecution(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            NotebookServiceClient client = new NotebookServiceClientImpl(mockGrpcClient.Object, null);
            Execution response = client.GetExecution(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetExecutionRequestObjectAsync()
        {
            moq::Mock<NotebookService.NotebookServiceClient> mockGrpcClient = new moq::Mock<NotebookService.NotebookServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetExecutionRequest request = new GetExecutionRequest
            {
                ExecutionName = ExecutionName.FromProjectLocationExecution("[PROJECT]", "[LOCATION]", "[EXECUTION]"),
            };
            Execution expectedResponse = new Execution
            {
                ExecutionTemplate = new ExecutionTemplate(),
                ExecutionName = ExecutionName.FromProjectLocationExecution("[PROJECT]", "[LOCATION]", "[EXECUTION]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                State = Execution.Types.State.Expired,
                OutputNotebookFile = "output_notebook_file4938a367",
                JobUri = "job_uria032473c",
            };
            mockGrpcClient.Setup(x => x.GetExecutionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Execution>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            NotebookServiceClient client = new NotebookServiceClientImpl(mockGrpcClient.Object, null);
            Execution responseCallSettings = await client.GetExecutionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Execution responseCancellationToken = await client.GetExecutionAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetExecution()
        {
            moq::Mock<NotebookService.NotebookServiceClient> mockGrpcClient = new moq::Mock<NotebookService.NotebookServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetExecutionRequest request = new GetExecutionRequest
            {
                ExecutionName = ExecutionName.FromProjectLocationExecution("[PROJECT]", "[LOCATION]", "[EXECUTION]"),
            };
            Execution expectedResponse = new Execution
            {
                ExecutionTemplate = new ExecutionTemplate(),
                ExecutionName = ExecutionName.FromProjectLocationExecution("[PROJECT]", "[LOCATION]", "[EXECUTION]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                State = Execution.Types.State.Expired,
                OutputNotebookFile = "output_notebook_file4938a367",
                JobUri = "job_uria032473c",
            };
            mockGrpcClient.Setup(x => x.GetExecution(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            NotebookServiceClient client = new NotebookServiceClientImpl(mockGrpcClient.Object, null);
            Execution response = client.GetExecution(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetExecutionAsync()
        {
            moq::Mock<NotebookService.NotebookServiceClient> mockGrpcClient = new moq::Mock<NotebookService.NotebookServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetExecutionRequest request = new GetExecutionRequest
            {
                ExecutionName = ExecutionName.FromProjectLocationExecution("[PROJECT]", "[LOCATION]", "[EXECUTION]"),
            };
            Execution expectedResponse = new Execution
            {
                ExecutionTemplate = new ExecutionTemplate(),
                ExecutionName = ExecutionName.FromProjectLocationExecution("[PROJECT]", "[LOCATION]", "[EXECUTION]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                State = Execution.Types.State.Expired,
                OutputNotebookFile = "output_notebook_file4938a367",
                JobUri = "job_uria032473c",
            };
            mockGrpcClient.Setup(x => x.GetExecutionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Execution>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            NotebookServiceClient client = new NotebookServiceClientImpl(mockGrpcClient.Object, null);
            Execution responseCallSettings = await client.GetExecutionAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Execution responseCancellationToken = await client.GetExecutionAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetExecutionResourceNames()
        {
            moq::Mock<NotebookService.NotebookServiceClient> mockGrpcClient = new moq::Mock<NotebookService.NotebookServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetExecutionRequest request = new GetExecutionRequest
            {
                ExecutionName = ExecutionName.FromProjectLocationExecution("[PROJECT]", "[LOCATION]", "[EXECUTION]"),
            };
            Execution expectedResponse = new Execution
            {
                ExecutionTemplate = new ExecutionTemplate(),
                ExecutionName = ExecutionName.FromProjectLocationExecution("[PROJECT]", "[LOCATION]", "[EXECUTION]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                State = Execution.Types.State.Expired,
                OutputNotebookFile = "output_notebook_file4938a367",
                JobUri = "job_uria032473c",
            };
            mockGrpcClient.Setup(x => x.GetExecution(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            NotebookServiceClient client = new NotebookServiceClientImpl(mockGrpcClient.Object, null);
            Execution response = client.GetExecution(request.ExecutionName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetExecutionResourceNamesAsync()
        {
            moq::Mock<NotebookService.NotebookServiceClient> mockGrpcClient = new moq::Mock<NotebookService.NotebookServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetExecutionRequest request = new GetExecutionRequest
            {
                ExecutionName = ExecutionName.FromProjectLocationExecution("[PROJECT]", "[LOCATION]", "[EXECUTION]"),
            };
            Execution expectedResponse = new Execution
            {
                ExecutionTemplate = new ExecutionTemplate(),
                ExecutionName = ExecutionName.FromProjectLocationExecution("[PROJECT]", "[LOCATION]", "[EXECUTION]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                State = Execution.Types.State.Expired,
                OutputNotebookFile = "output_notebook_file4938a367",
                JobUri = "job_uria032473c",
            };
            mockGrpcClient.Setup(x => x.GetExecutionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Execution>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            NotebookServiceClient client = new NotebookServiceClientImpl(mockGrpcClient.Object, null);
            Execution responseCallSettings = await client.GetExecutionAsync(request.ExecutionName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Execution responseCancellationToken = await client.GetExecutionAsync(request.ExecutionName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
