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
using gagr = Google.Api.Gax.ResourceNames;
using gciv = Google.Cloud.Iam.V1;
using gcl = Google.Cloud.Location;
using lro = Google.LongRunning;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.BareMetalSolution.V2.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedBareMetalSolutionClientTest
    {
        [xunit::FactAttribute]
        public void GetInstanceRequestObject()
        {
            moq::Mock<BareMetalSolution.BareMetalSolutionClient> mockGrpcClient = new moq::Mock<BareMetalSolution.BareMetalSolutionClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetInstanceRequest request = new GetInstanceRequest
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
            };
            Instance expectedResponse = new Instance
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                MachineType = "machine_type68ce40fa",
                State = Instance.Types.State.Running,
                HyperthreadingEnabled = true,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Luns = { new Lun(), },
                Networks = { new Network(), },
                InteractiveSerialConsoleEnabled = false,
                Id = "id74b70bb8",
                OsImage = "os_image3232c1ca",
                Pod = "poda9cac0dc",
                NetworkTemplateAsServerNetworkTemplateName = ServerNetworkTemplateName.FromProjectLocationServerNetworkTemplate("[PROJECT]", "[LOCATION]", "[SERVER_NETWORK_TEMPLATE]"),
                LogicalInterfaces =
                {
                    new LogicalInterface(),
                },
            };
            mockGrpcClient.Setup(x => x.GetInstance(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BareMetalSolutionClient client = new BareMetalSolutionClientImpl(mockGrpcClient.Object, null, null);
            Instance response = client.GetInstance(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetInstanceRequestObjectAsync()
        {
            moq::Mock<BareMetalSolution.BareMetalSolutionClient> mockGrpcClient = new moq::Mock<BareMetalSolution.BareMetalSolutionClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetInstanceRequest request = new GetInstanceRequest
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
            };
            Instance expectedResponse = new Instance
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                MachineType = "machine_type68ce40fa",
                State = Instance.Types.State.Running,
                HyperthreadingEnabled = true,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Luns = { new Lun(), },
                Networks = { new Network(), },
                InteractiveSerialConsoleEnabled = false,
                Id = "id74b70bb8",
                OsImage = "os_image3232c1ca",
                Pod = "poda9cac0dc",
                NetworkTemplateAsServerNetworkTemplateName = ServerNetworkTemplateName.FromProjectLocationServerNetworkTemplate("[PROJECT]", "[LOCATION]", "[SERVER_NETWORK_TEMPLATE]"),
                LogicalInterfaces =
                {
                    new LogicalInterface(),
                },
            };
            mockGrpcClient.Setup(x => x.GetInstanceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Instance>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BareMetalSolutionClient client = new BareMetalSolutionClientImpl(mockGrpcClient.Object, null, null);
            Instance responseCallSettings = await client.GetInstanceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Instance responseCancellationToken = await client.GetInstanceAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetInstance()
        {
            moq::Mock<BareMetalSolution.BareMetalSolutionClient> mockGrpcClient = new moq::Mock<BareMetalSolution.BareMetalSolutionClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetInstanceRequest request = new GetInstanceRequest
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
            };
            Instance expectedResponse = new Instance
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                MachineType = "machine_type68ce40fa",
                State = Instance.Types.State.Running,
                HyperthreadingEnabled = true,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Luns = { new Lun(), },
                Networks = { new Network(), },
                InteractiveSerialConsoleEnabled = false,
                Id = "id74b70bb8",
                OsImage = "os_image3232c1ca",
                Pod = "poda9cac0dc",
                NetworkTemplateAsServerNetworkTemplateName = ServerNetworkTemplateName.FromProjectLocationServerNetworkTemplate("[PROJECT]", "[LOCATION]", "[SERVER_NETWORK_TEMPLATE]"),
                LogicalInterfaces =
                {
                    new LogicalInterface(),
                },
            };
            mockGrpcClient.Setup(x => x.GetInstance(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BareMetalSolutionClient client = new BareMetalSolutionClientImpl(mockGrpcClient.Object, null, null);
            Instance response = client.GetInstance(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetInstanceAsync()
        {
            moq::Mock<BareMetalSolution.BareMetalSolutionClient> mockGrpcClient = new moq::Mock<BareMetalSolution.BareMetalSolutionClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetInstanceRequest request = new GetInstanceRequest
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
            };
            Instance expectedResponse = new Instance
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                MachineType = "machine_type68ce40fa",
                State = Instance.Types.State.Running,
                HyperthreadingEnabled = true,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Luns = { new Lun(), },
                Networks = { new Network(), },
                InteractiveSerialConsoleEnabled = false,
                Id = "id74b70bb8",
                OsImage = "os_image3232c1ca",
                Pod = "poda9cac0dc",
                NetworkTemplateAsServerNetworkTemplateName = ServerNetworkTemplateName.FromProjectLocationServerNetworkTemplate("[PROJECT]", "[LOCATION]", "[SERVER_NETWORK_TEMPLATE]"),
                LogicalInterfaces =
                {
                    new LogicalInterface(),
                },
            };
            mockGrpcClient.Setup(x => x.GetInstanceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Instance>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BareMetalSolutionClient client = new BareMetalSolutionClientImpl(mockGrpcClient.Object, null, null);
            Instance responseCallSettings = await client.GetInstanceAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Instance responseCancellationToken = await client.GetInstanceAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetInstanceResourceNames()
        {
            moq::Mock<BareMetalSolution.BareMetalSolutionClient> mockGrpcClient = new moq::Mock<BareMetalSolution.BareMetalSolutionClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetInstanceRequest request = new GetInstanceRequest
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
            };
            Instance expectedResponse = new Instance
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                MachineType = "machine_type68ce40fa",
                State = Instance.Types.State.Running,
                HyperthreadingEnabled = true,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Luns = { new Lun(), },
                Networks = { new Network(), },
                InteractiveSerialConsoleEnabled = false,
                Id = "id74b70bb8",
                OsImage = "os_image3232c1ca",
                Pod = "poda9cac0dc",
                NetworkTemplateAsServerNetworkTemplateName = ServerNetworkTemplateName.FromProjectLocationServerNetworkTemplate("[PROJECT]", "[LOCATION]", "[SERVER_NETWORK_TEMPLATE]"),
                LogicalInterfaces =
                {
                    new LogicalInterface(),
                },
            };
            mockGrpcClient.Setup(x => x.GetInstance(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BareMetalSolutionClient client = new BareMetalSolutionClientImpl(mockGrpcClient.Object, null, null);
            Instance response = client.GetInstance(request.InstanceName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetInstanceResourceNamesAsync()
        {
            moq::Mock<BareMetalSolution.BareMetalSolutionClient> mockGrpcClient = new moq::Mock<BareMetalSolution.BareMetalSolutionClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetInstanceRequest request = new GetInstanceRequest
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
            };
            Instance expectedResponse = new Instance
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                MachineType = "machine_type68ce40fa",
                State = Instance.Types.State.Running,
                HyperthreadingEnabled = true,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Luns = { new Lun(), },
                Networks = { new Network(), },
                InteractiveSerialConsoleEnabled = false,
                Id = "id74b70bb8",
                OsImage = "os_image3232c1ca",
                Pod = "poda9cac0dc",
                NetworkTemplateAsServerNetworkTemplateName = ServerNetworkTemplateName.FromProjectLocationServerNetworkTemplate("[PROJECT]", "[LOCATION]", "[SERVER_NETWORK_TEMPLATE]"),
                LogicalInterfaces =
                {
                    new LogicalInterface(),
                },
            };
            mockGrpcClient.Setup(x => x.GetInstanceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Instance>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BareMetalSolutionClient client = new BareMetalSolutionClientImpl(mockGrpcClient.Object, null, null);
            Instance responseCallSettings = await client.GetInstanceAsync(request.InstanceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Instance responseCancellationToken = await client.GetInstanceAsync(request.InstanceName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetVolumeRequestObject()
        {
            moq::Mock<BareMetalSolution.BareMetalSolutionClient> mockGrpcClient = new moq::Mock<BareMetalSolution.BareMetalSolutionClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetVolumeRequest request = new GetVolumeRequest
            {
                VolumeName = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]"),
            };
            Volume expectedResponse = new Volume
            {
                VolumeName = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]"),
                StorageType = Volume.Types.StorageType.Unspecified,
                State = Volume.Types.State.Ready,
                RequestedSizeGib = -7722532394069079118L,
                CurrentSizeGib = -2168691086882792865L,
                AutoGrownSizeGib = -3298504694872476932L,
                RemainingSpaceGib = -8269450760440973859L,
                SnapshotReservationDetail = new Volume.Types.SnapshotReservationDetail(),
                SnapshotAutoDeleteBehavior = Volume.Types.SnapshotAutoDeleteBehavior.OldestFirst,
                Id = "id74b70bb8",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                SnapshotEnabled = false,
                EmergencySizeGib = 1427318062093940038L,
                Pod = "poda9cac0dc",
            };
            mockGrpcClient.Setup(x => x.GetVolume(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BareMetalSolutionClient client = new BareMetalSolutionClientImpl(mockGrpcClient.Object, null, null);
            Volume response = client.GetVolume(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetVolumeRequestObjectAsync()
        {
            moq::Mock<BareMetalSolution.BareMetalSolutionClient> mockGrpcClient = new moq::Mock<BareMetalSolution.BareMetalSolutionClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetVolumeRequest request = new GetVolumeRequest
            {
                VolumeName = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]"),
            };
            Volume expectedResponse = new Volume
            {
                VolumeName = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]"),
                StorageType = Volume.Types.StorageType.Unspecified,
                State = Volume.Types.State.Ready,
                RequestedSizeGib = -7722532394069079118L,
                CurrentSizeGib = -2168691086882792865L,
                AutoGrownSizeGib = -3298504694872476932L,
                RemainingSpaceGib = -8269450760440973859L,
                SnapshotReservationDetail = new Volume.Types.SnapshotReservationDetail(),
                SnapshotAutoDeleteBehavior = Volume.Types.SnapshotAutoDeleteBehavior.OldestFirst,
                Id = "id74b70bb8",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                SnapshotEnabled = false,
                EmergencySizeGib = 1427318062093940038L,
                Pod = "poda9cac0dc",
            };
            mockGrpcClient.Setup(x => x.GetVolumeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Volume>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BareMetalSolutionClient client = new BareMetalSolutionClientImpl(mockGrpcClient.Object, null, null);
            Volume responseCallSettings = await client.GetVolumeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Volume responseCancellationToken = await client.GetVolumeAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetVolume()
        {
            moq::Mock<BareMetalSolution.BareMetalSolutionClient> mockGrpcClient = new moq::Mock<BareMetalSolution.BareMetalSolutionClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetVolumeRequest request = new GetVolumeRequest
            {
                VolumeName = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]"),
            };
            Volume expectedResponse = new Volume
            {
                VolumeName = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]"),
                StorageType = Volume.Types.StorageType.Unspecified,
                State = Volume.Types.State.Ready,
                RequestedSizeGib = -7722532394069079118L,
                CurrentSizeGib = -2168691086882792865L,
                AutoGrownSizeGib = -3298504694872476932L,
                RemainingSpaceGib = -8269450760440973859L,
                SnapshotReservationDetail = new Volume.Types.SnapshotReservationDetail(),
                SnapshotAutoDeleteBehavior = Volume.Types.SnapshotAutoDeleteBehavior.OldestFirst,
                Id = "id74b70bb8",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                SnapshotEnabled = false,
                EmergencySizeGib = 1427318062093940038L,
                Pod = "poda9cac0dc",
            };
            mockGrpcClient.Setup(x => x.GetVolume(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BareMetalSolutionClient client = new BareMetalSolutionClientImpl(mockGrpcClient.Object, null, null);
            Volume response = client.GetVolume(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetVolumeAsync()
        {
            moq::Mock<BareMetalSolution.BareMetalSolutionClient> mockGrpcClient = new moq::Mock<BareMetalSolution.BareMetalSolutionClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetVolumeRequest request = new GetVolumeRequest
            {
                VolumeName = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]"),
            };
            Volume expectedResponse = new Volume
            {
                VolumeName = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]"),
                StorageType = Volume.Types.StorageType.Unspecified,
                State = Volume.Types.State.Ready,
                RequestedSizeGib = -7722532394069079118L,
                CurrentSizeGib = -2168691086882792865L,
                AutoGrownSizeGib = -3298504694872476932L,
                RemainingSpaceGib = -8269450760440973859L,
                SnapshotReservationDetail = new Volume.Types.SnapshotReservationDetail(),
                SnapshotAutoDeleteBehavior = Volume.Types.SnapshotAutoDeleteBehavior.OldestFirst,
                Id = "id74b70bb8",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                SnapshotEnabled = false,
                EmergencySizeGib = 1427318062093940038L,
                Pod = "poda9cac0dc",
            };
            mockGrpcClient.Setup(x => x.GetVolumeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Volume>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BareMetalSolutionClient client = new BareMetalSolutionClientImpl(mockGrpcClient.Object, null, null);
            Volume responseCallSettings = await client.GetVolumeAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Volume responseCancellationToken = await client.GetVolumeAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetVolumeResourceNames()
        {
            moq::Mock<BareMetalSolution.BareMetalSolutionClient> mockGrpcClient = new moq::Mock<BareMetalSolution.BareMetalSolutionClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetVolumeRequest request = new GetVolumeRequest
            {
                VolumeName = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]"),
            };
            Volume expectedResponse = new Volume
            {
                VolumeName = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]"),
                StorageType = Volume.Types.StorageType.Unspecified,
                State = Volume.Types.State.Ready,
                RequestedSizeGib = -7722532394069079118L,
                CurrentSizeGib = -2168691086882792865L,
                AutoGrownSizeGib = -3298504694872476932L,
                RemainingSpaceGib = -8269450760440973859L,
                SnapshotReservationDetail = new Volume.Types.SnapshotReservationDetail(),
                SnapshotAutoDeleteBehavior = Volume.Types.SnapshotAutoDeleteBehavior.OldestFirst,
                Id = "id74b70bb8",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                SnapshotEnabled = false,
                EmergencySizeGib = 1427318062093940038L,
                Pod = "poda9cac0dc",
            };
            mockGrpcClient.Setup(x => x.GetVolume(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BareMetalSolutionClient client = new BareMetalSolutionClientImpl(mockGrpcClient.Object, null, null);
            Volume response = client.GetVolume(request.VolumeName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetVolumeResourceNamesAsync()
        {
            moq::Mock<BareMetalSolution.BareMetalSolutionClient> mockGrpcClient = new moq::Mock<BareMetalSolution.BareMetalSolutionClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetVolumeRequest request = new GetVolumeRequest
            {
                VolumeName = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]"),
            };
            Volume expectedResponse = new Volume
            {
                VolumeName = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]"),
                StorageType = Volume.Types.StorageType.Unspecified,
                State = Volume.Types.State.Ready,
                RequestedSizeGib = -7722532394069079118L,
                CurrentSizeGib = -2168691086882792865L,
                AutoGrownSizeGib = -3298504694872476932L,
                RemainingSpaceGib = -8269450760440973859L,
                SnapshotReservationDetail = new Volume.Types.SnapshotReservationDetail(),
                SnapshotAutoDeleteBehavior = Volume.Types.SnapshotAutoDeleteBehavior.OldestFirst,
                Id = "id74b70bb8",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                SnapshotEnabled = false,
                EmergencySizeGib = 1427318062093940038L,
                Pod = "poda9cac0dc",
            };
            mockGrpcClient.Setup(x => x.GetVolumeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Volume>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BareMetalSolutionClient client = new BareMetalSolutionClientImpl(mockGrpcClient.Object, null, null);
            Volume responseCallSettings = await client.GetVolumeAsync(request.VolumeName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Volume responseCancellationToken = await client.GetVolumeAsync(request.VolumeName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ListNetworkUsageRequestObject()
        {
            moq::Mock<BareMetalSolution.BareMetalSolutionClient> mockGrpcClient = new moq::Mock<BareMetalSolution.BareMetalSolutionClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            ListNetworkUsageRequest request = new ListNetworkUsageRequest
            {
                LocationAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            ListNetworkUsageResponse expectedResponse = new ListNetworkUsageResponse
            {
                Networks = { new NetworkUsage(), },
            };
            mockGrpcClient.Setup(x => x.ListNetworkUsage(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BareMetalSolutionClient client = new BareMetalSolutionClientImpl(mockGrpcClient.Object, null, null);
            ListNetworkUsageResponse response = client.ListNetworkUsage(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListNetworkUsageRequestObjectAsync()
        {
            moq::Mock<BareMetalSolution.BareMetalSolutionClient> mockGrpcClient = new moq::Mock<BareMetalSolution.BareMetalSolutionClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            ListNetworkUsageRequest request = new ListNetworkUsageRequest
            {
                LocationAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            ListNetworkUsageResponse expectedResponse = new ListNetworkUsageResponse
            {
                Networks = { new NetworkUsage(), },
            };
            mockGrpcClient.Setup(x => x.ListNetworkUsageAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ListNetworkUsageResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BareMetalSolutionClient client = new BareMetalSolutionClientImpl(mockGrpcClient.Object, null, null);
            ListNetworkUsageResponse responseCallSettings = await client.ListNetworkUsageAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ListNetworkUsageResponse responseCancellationToken = await client.ListNetworkUsageAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ListNetworkUsage()
        {
            moq::Mock<BareMetalSolution.BareMetalSolutionClient> mockGrpcClient = new moq::Mock<BareMetalSolution.BareMetalSolutionClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            ListNetworkUsageRequest request = new ListNetworkUsageRequest
            {
                LocationAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            ListNetworkUsageResponse expectedResponse = new ListNetworkUsageResponse
            {
                Networks = { new NetworkUsage(), },
            };
            mockGrpcClient.Setup(x => x.ListNetworkUsage(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BareMetalSolutionClient client = new BareMetalSolutionClientImpl(mockGrpcClient.Object, null, null);
            ListNetworkUsageResponse response = client.ListNetworkUsage(request.Location);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListNetworkUsageAsync()
        {
            moq::Mock<BareMetalSolution.BareMetalSolutionClient> mockGrpcClient = new moq::Mock<BareMetalSolution.BareMetalSolutionClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            ListNetworkUsageRequest request = new ListNetworkUsageRequest
            {
                LocationAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            ListNetworkUsageResponse expectedResponse = new ListNetworkUsageResponse
            {
                Networks = { new NetworkUsage(), },
            };
            mockGrpcClient.Setup(x => x.ListNetworkUsageAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ListNetworkUsageResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BareMetalSolutionClient client = new BareMetalSolutionClientImpl(mockGrpcClient.Object, null, null);
            ListNetworkUsageResponse responseCallSettings = await client.ListNetworkUsageAsync(request.Location, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ListNetworkUsageResponse responseCancellationToken = await client.ListNetworkUsageAsync(request.Location, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ListNetworkUsageResourceNames()
        {
            moq::Mock<BareMetalSolution.BareMetalSolutionClient> mockGrpcClient = new moq::Mock<BareMetalSolution.BareMetalSolutionClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            ListNetworkUsageRequest request = new ListNetworkUsageRequest
            {
                LocationAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            ListNetworkUsageResponse expectedResponse = new ListNetworkUsageResponse
            {
                Networks = { new NetworkUsage(), },
            };
            mockGrpcClient.Setup(x => x.ListNetworkUsage(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BareMetalSolutionClient client = new BareMetalSolutionClientImpl(mockGrpcClient.Object, null, null);
            ListNetworkUsageResponse response = client.ListNetworkUsage(request.LocationAsLocationName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListNetworkUsageResourceNamesAsync()
        {
            moq::Mock<BareMetalSolution.BareMetalSolutionClient> mockGrpcClient = new moq::Mock<BareMetalSolution.BareMetalSolutionClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            ListNetworkUsageRequest request = new ListNetworkUsageRequest
            {
                LocationAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            ListNetworkUsageResponse expectedResponse = new ListNetworkUsageResponse
            {
                Networks = { new NetworkUsage(), },
            };
            mockGrpcClient.Setup(x => x.ListNetworkUsageAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ListNetworkUsageResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BareMetalSolutionClient client = new BareMetalSolutionClientImpl(mockGrpcClient.Object, null, null);
            ListNetworkUsageResponse responseCallSettings = await client.ListNetworkUsageAsync(request.LocationAsLocationName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ListNetworkUsageResponse responseCancellationToken = await client.ListNetworkUsageAsync(request.LocationAsLocationName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetNetworkRequestObject()
        {
            moq::Mock<BareMetalSolution.BareMetalSolutionClient> mockGrpcClient = new moq::Mock<BareMetalSolution.BareMetalSolutionClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetNetworkRequest request = new GetNetworkRequest
            {
                NetworkName = NetworkName.FromProjectLocationNetwork("[PROJECT]", "[LOCATION]", "[NETWORK]"),
            };
            Network expectedResponse = new Network
            {
                Type = Network.Types.Type.Unspecified,
                IpAddress = "ip_address46a72553",
                MacAddress =
                {
                    "mac_address4f86fc0d",
                },
                NetworkName = NetworkName.FromProjectLocationNetwork("[PROJECT]", "[LOCATION]", "[NETWORK]"),
                State = Network.Types.State.Unspecified,
                VlanId = "vlan_idb7c81dcd",
                Cidr = "cidr61372954",
                Vrf = new VRF(),
                Id = "id74b70bb8",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                ServicesCidr = "services_cidr03410c1e",
                Reservations =
                {
                    new NetworkAddressReservation(),
                },
            };
            mockGrpcClient.Setup(x => x.GetNetwork(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BareMetalSolutionClient client = new BareMetalSolutionClientImpl(mockGrpcClient.Object, null, null);
            Network response = client.GetNetwork(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetNetworkRequestObjectAsync()
        {
            moq::Mock<BareMetalSolution.BareMetalSolutionClient> mockGrpcClient = new moq::Mock<BareMetalSolution.BareMetalSolutionClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetNetworkRequest request = new GetNetworkRequest
            {
                NetworkName = NetworkName.FromProjectLocationNetwork("[PROJECT]", "[LOCATION]", "[NETWORK]"),
            };
            Network expectedResponse = new Network
            {
                Type = Network.Types.Type.Unspecified,
                IpAddress = "ip_address46a72553",
                MacAddress =
                {
                    "mac_address4f86fc0d",
                },
                NetworkName = NetworkName.FromProjectLocationNetwork("[PROJECT]", "[LOCATION]", "[NETWORK]"),
                State = Network.Types.State.Unspecified,
                VlanId = "vlan_idb7c81dcd",
                Cidr = "cidr61372954",
                Vrf = new VRF(),
                Id = "id74b70bb8",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                ServicesCidr = "services_cidr03410c1e",
                Reservations =
                {
                    new NetworkAddressReservation(),
                },
            };
            mockGrpcClient.Setup(x => x.GetNetworkAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Network>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BareMetalSolutionClient client = new BareMetalSolutionClientImpl(mockGrpcClient.Object, null, null);
            Network responseCallSettings = await client.GetNetworkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Network responseCancellationToken = await client.GetNetworkAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetNetwork()
        {
            moq::Mock<BareMetalSolution.BareMetalSolutionClient> mockGrpcClient = new moq::Mock<BareMetalSolution.BareMetalSolutionClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetNetworkRequest request = new GetNetworkRequest
            {
                NetworkName = NetworkName.FromProjectLocationNetwork("[PROJECT]", "[LOCATION]", "[NETWORK]"),
            };
            Network expectedResponse = new Network
            {
                Type = Network.Types.Type.Unspecified,
                IpAddress = "ip_address46a72553",
                MacAddress =
                {
                    "mac_address4f86fc0d",
                },
                NetworkName = NetworkName.FromProjectLocationNetwork("[PROJECT]", "[LOCATION]", "[NETWORK]"),
                State = Network.Types.State.Unspecified,
                VlanId = "vlan_idb7c81dcd",
                Cidr = "cidr61372954",
                Vrf = new VRF(),
                Id = "id74b70bb8",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                ServicesCidr = "services_cidr03410c1e",
                Reservations =
                {
                    new NetworkAddressReservation(),
                },
            };
            mockGrpcClient.Setup(x => x.GetNetwork(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BareMetalSolutionClient client = new BareMetalSolutionClientImpl(mockGrpcClient.Object, null, null);
            Network response = client.GetNetwork(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetNetworkAsync()
        {
            moq::Mock<BareMetalSolution.BareMetalSolutionClient> mockGrpcClient = new moq::Mock<BareMetalSolution.BareMetalSolutionClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetNetworkRequest request = new GetNetworkRequest
            {
                NetworkName = NetworkName.FromProjectLocationNetwork("[PROJECT]", "[LOCATION]", "[NETWORK]"),
            };
            Network expectedResponse = new Network
            {
                Type = Network.Types.Type.Unspecified,
                IpAddress = "ip_address46a72553",
                MacAddress =
                {
                    "mac_address4f86fc0d",
                },
                NetworkName = NetworkName.FromProjectLocationNetwork("[PROJECT]", "[LOCATION]", "[NETWORK]"),
                State = Network.Types.State.Unspecified,
                VlanId = "vlan_idb7c81dcd",
                Cidr = "cidr61372954",
                Vrf = new VRF(),
                Id = "id74b70bb8",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                ServicesCidr = "services_cidr03410c1e",
                Reservations =
                {
                    new NetworkAddressReservation(),
                },
            };
            mockGrpcClient.Setup(x => x.GetNetworkAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Network>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BareMetalSolutionClient client = new BareMetalSolutionClientImpl(mockGrpcClient.Object, null, null);
            Network responseCallSettings = await client.GetNetworkAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Network responseCancellationToken = await client.GetNetworkAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetNetworkResourceNames()
        {
            moq::Mock<BareMetalSolution.BareMetalSolutionClient> mockGrpcClient = new moq::Mock<BareMetalSolution.BareMetalSolutionClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetNetworkRequest request = new GetNetworkRequest
            {
                NetworkName = NetworkName.FromProjectLocationNetwork("[PROJECT]", "[LOCATION]", "[NETWORK]"),
            };
            Network expectedResponse = new Network
            {
                Type = Network.Types.Type.Unspecified,
                IpAddress = "ip_address46a72553",
                MacAddress =
                {
                    "mac_address4f86fc0d",
                },
                NetworkName = NetworkName.FromProjectLocationNetwork("[PROJECT]", "[LOCATION]", "[NETWORK]"),
                State = Network.Types.State.Unspecified,
                VlanId = "vlan_idb7c81dcd",
                Cidr = "cidr61372954",
                Vrf = new VRF(),
                Id = "id74b70bb8",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                ServicesCidr = "services_cidr03410c1e",
                Reservations =
                {
                    new NetworkAddressReservation(),
                },
            };
            mockGrpcClient.Setup(x => x.GetNetwork(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BareMetalSolutionClient client = new BareMetalSolutionClientImpl(mockGrpcClient.Object, null, null);
            Network response = client.GetNetwork(request.NetworkName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetNetworkResourceNamesAsync()
        {
            moq::Mock<BareMetalSolution.BareMetalSolutionClient> mockGrpcClient = new moq::Mock<BareMetalSolution.BareMetalSolutionClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetNetworkRequest request = new GetNetworkRequest
            {
                NetworkName = NetworkName.FromProjectLocationNetwork("[PROJECT]", "[LOCATION]", "[NETWORK]"),
            };
            Network expectedResponse = new Network
            {
                Type = Network.Types.Type.Unspecified,
                IpAddress = "ip_address46a72553",
                MacAddress =
                {
                    "mac_address4f86fc0d",
                },
                NetworkName = NetworkName.FromProjectLocationNetwork("[PROJECT]", "[LOCATION]", "[NETWORK]"),
                State = Network.Types.State.Unspecified,
                VlanId = "vlan_idb7c81dcd",
                Cidr = "cidr61372954",
                Vrf = new VRF(),
                Id = "id74b70bb8",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                ServicesCidr = "services_cidr03410c1e",
                Reservations =
                {
                    new NetworkAddressReservation(),
                },
            };
            mockGrpcClient.Setup(x => x.GetNetworkAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Network>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BareMetalSolutionClient client = new BareMetalSolutionClientImpl(mockGrpcClient.Object, null, null);
            Network responseCallSettings = await client.GetNetworkAsync(request.NetworkName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Network responseCancellationToken = await client.GetNetworkAsync(request.NetworkName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetLunRequestObject()
        {
            moq::Mock<BareMetalSolution.BareMetalSolutionClient> mockGrpcClient = new moq::Mock<BareMetalSolution.BareMetalSolutionClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetLunRequest request = new GetLunRequest
            {
                LunName = LunName.FromProjectLocationVolumeLun("[PROJECT]", "[LOCATION]", "[VOLUME]", "[LUN]"),
            };
            Lun expectedResponse = new Lun
            {
                LunName = LunName.FromProjectLocationVolumeLun("[PROJECT]", "[LOCATION]", "[VOLUME]", "[LUN]"),
                State = Lun.Types.State.Ready,
                SizeGb = -3653169847519542788L,
                MultiprotocolType = Lun.Types.MultiprotocolType.Linux,
                StorageVolumeAsVolumeName = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]"),
                Shareable = false,
                BootLun = true,
                StorageType = Lun.Types.StorageType.Unspecified,
                Wwid = "wwidccabccf4",
                Id = "id74b70bb8",
            };
            mockGrpcClient.Setup(x => x.GetLun(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BareMetalSolutionClient client = new BareMetalSolutionClientImpl(mockGrpcClient.Object, null, null);
            Lun response = client.GetLun(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetLunRequestObjectAsync()
        {
            moq::Mock<BareMetalSolution.BareMetalSolutionClient> mockGrpcClient = new moq::Mock<BareMetalSolution.BareMetalSolutionClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetLunRequest request = new GetLunRequest
            {
                LunName = LunName.FromProjectLocationVolumeLun("[PROJECT]", "[LOCATION]", "[VOLUME]", "[LUN]"),
            };
            Lun expectedResponse = new Lun
            {
                LunName = LunName.FromProjectLocationVolumeLun("[PROJECT]", "[LOCATION]", "[VOLUME]", "[LUN]"),
                State = Lun.Types.State.Ready,
                SizeGb = -3653169847519542788L,
                MultiprotocolType = Lun.Types.MultiprotocolType.Linux,
                StorageVolumeAsVolumeName = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]"),
                Shareable = false,
                BootLun = true,
                StorageType = Lun.Types.StorageType.Unspecified,
                Wwid = "wwidccabccf4",
                Id = "id74b70bb8",
            };
            mockGrpcClient.Setup(x => x.GetLunAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Lun>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BareMetalSolutionClient client = new BareMetalSolutionClientImpl(mockGrpcClient.Object, null, null);
            Lun responseCallSettings = await client.GetLunAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Lun responseCancellationToken = await client.GetLunAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetLun()
        {
            moq::Mock<BareMetalSolution.BareMetalSolutionClient> mockGrpcClient = new moq::Mock<BareMetalSolution.BareMetalSolutionClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetLunRequest request = new GetLunRequest
            {
                LunName = LunName.FromProjectLocationVolumeLun("[PROJECT]", "[LOCATION]", "[VOLUME]", "[LUN]"),
            };
            Lun expectedResponse = new Lun
            {
                LunName = LunName.FromProjectLocationVolumeLun("[PROJECT]", "[LOCATION]", "[VOLUME]", "[LUN]"),
                State = Lun.Types.State.Ready,
                SizeGb = -3653169847519542788L,
                MultiprotocolType = Lun.Types.MultiprotocolType.Linux,
                StorageVolumeAsVolumeName = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]"),
                Shareable = false,
                BootLun = true,
                StorageType = Lun.Types.StorageType.Unspecified,
                Wwid = "wwidccabccf4",
                Id = "id74b70bb8",
            };
            mockGrpcClient.Setup(x => x.GetLun(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BareMetalSolutionClient client = new BareMetalSolutionClientImpl(mockGrpcClient.Object, null, null);
            Lun response = client.GetLun(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetLunAsync()
        {
            moq::Mock<BareMetalSolution.BareMetalSolutionClient> mockGrpcClient = new moq::Mock<BareMetalSolution.BareMetalSolutionClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetLunRequest request = new GetLunRequest
            {
                LunName = LunName.FromProjectLocationVolumeLun("[PROJECT]", "[LOCATION]", "[VOLUME]", "[LUN]"),
            };
            Lun expectedResponse = new Lun
            {
                LunName = LunName.FromProjectLocationVolumeLun("[PROJECT]", "[LOCATION]", "[VOLUME]", "[LUN]"),
                State = Lun.Types.State.Ready,
                SizeGb = -3653169847519542788L,
                MultiprotocolType = Lun.Types.MultiprotocolType.Linux,
                StorageVolumeAsVolumeName = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]"),
                Shareable = false,
                BootLun = true,
                StorageType = Lun.Types.StorageType.Unspecified,
                Wwid = "wwidccabccf4",
                Id = "id74b70bb8",
            };
            mockGrpcClient.Setup(x => x.GetLunAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Lun>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BareMetalSolutionClient client = new BareMetalSolutionClientImpl(mockGrpcClient.Object, null, null);
            Lun responseCallSettings = await client.GetLunAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Lun responseCancellationToken = await client.GetLunAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetLunResourceNames()
        {
            moq::Mock<BareMetalSolution.BareMetalSolutionClient> mockGrpcClient = new moq::Mock<BareMetalSolution.BareMetalSolutionClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetLunRequest request = new GetLunRequest
            {
                LunName = LunName.FromProjectLocationVolumeLun("[PROJECT]", "[LOCATION]", "[VOLUME]", "[LUN]"),
            };
            Lun expectedResponse = new Lun
            {
                LunName = LunName.FromProjectLocationVolumeLun("[PROJECT]", "[LOCATION]", "[VOLUME]", "[LUN]"),
                State = Lun.Types.State.Ready,
                SizeGb = -3653169847519542788L,
                MultiprotocolType = Lun.Types.MultiprotocolType.Linux,
                StorageVolumeAsVolumeName = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]"),
                Shareable = false,
                BootLun = true,
                StorageType = Lun.Types.StorageType.Unspecified,
                Wwid = "wwidccabccf4",
                Id = "id74b70bb8",
            };
            mockGrpcClient.Setup(x => x.GetLun(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BareMetalSolutionClient client = new BareMetalSolutionClientImpl(mockGrpcClient.Object, null, null);
            Lun response = client.GetLun(request.LunName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetLunResourceNamesAsync()
        {
            moq::Mock<BareMetalSolution.BareMetalSolutionClient> mockGrpcClient = new moq::Mock<BareMetalSolution.BareMetalSolutionClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetLunRequest request = new GetLunRequest
            {
                LunName = LunName.FromProjectLocationVolumeLun("[PROJECT]", "[LOCATION]", "[VOLUME]", "[LUN]"),
            };
            Lun expectedResponse = new Lun
            {
                LunName = LunName.FromProjectLocationVolumeLun("[PROJECT]", "[LOCATION]", "[VOLUME]", "[LUN]"),
                State = Lun.Types.State.Ready,
                SizeGb = -3653169847519542788L,
                MultiprotocolType = Lun.Types.MultiprotocolType.Linux,
                StorageVolumeAsVolumeName = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]"),
                Shareable = false,
                BootLun = true,
                StorageType = Lun.Types.StorageType.Unspecified,
                Wwid = "wwidccabccf4",
                Id = "id74b70bb8",
            };
            mockGrpcClient.Setup(x => x.GetLunAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Lun>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BareMetalSolutionClient client = new BareMetalSolutionClientImpl(mockGrpcClient.Object, null, null);
            Lun responseCallSettings = await client.GetLunAsync(request.LunName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Lun responseCancellationToken = await client.GetLunAsync(request.LunName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetNfsShareRequestObject()
        {
            moq::Mock<BareMetalSolution.BareMetalSolutionClient> mockGrpcClient = new moq::Mock<BareMetalSolution.BareMetalSolutionClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetNfsShareRequest request = new GetNfsShareRequest
            {
                NFSShareName = NFSShareName.FromProjectLocationNfsShare("[PROJECT]", "[LOCATION]", "[NFS_SHARE]"),
            };
            NfsShare expectedResponse = new NfsShare
            {
                NFSShareName = NFSShareName.FromProjectLocationNfsShare("[PROJECT]", "[LOCATION]", "[NFS_SHARE]"),
                NfsShareId = "nfs_share_id674d8775",
                State = NfsShare.Types.State.Unspecified,
                VolumeAsVolumeName = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]"),
                AllowedClients =
                {
                    new NfsShare.Types.AllowedClient(),
                },
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetNfsShare(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BareMetalSolutionClient client = new BareMetalSolutionClientImpl(mockGrpcClient.Object, null, null);
            NfsShare response = client.GetNfsShare(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetNfsShareRequestObjectAsync()
        {
            moq::Mock<BareMetalSolution.BareMetalSolutionClient> mockGrpcClient = new moq::Mock<BareMetalSolution.BareMetalSolutionClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetNfsShareRequest request = new GetNfsShareRequest
            {
                NFSShareName = NFSShareName.FromProjectLocationNfsShare("[PROJECT]", "[LOCATION]", "[NFS_SHARE]"),
            };
            NfsShare expectedResponse = new NfsShare
            {
                NFSShareName = NFSShareName.FromProjectLocationNfsShare("[PROJECT]", "[LOCATION]", "[NFS_SHARE]"),
                NfsShareId = "nfs_share_id674d8775",
                State = NfsShare.Types.State.Unspecified,
                VolumeAsVolumeName = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]"),
                AllowedClients =
                {
                    new NfsShare.Types.AllowedClient(),
                },
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetNfsShareAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<NfsShare>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BareMetalSolutionClient client = new BareMetalSolutionClientImpl(mockGrpcClient.Object, null, null);
            NfsShare responseCallSettings = await client.GetNfsShareAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            NfsShare responseCancellationToken = await client.GetNfsShareAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetNfsShare()
        {
            moq::Mock<BareMetalSolution.BareMetalSolutionClient> mockGrpcClient = new moq::Mock<BareMetalSolution.BareMetalSolutionClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetNfsShareRequest request = new GetNfsShareRequest
            {
                NFSShareName = NFSShareName.FromProjectLocationNfsShare("[PROJECT]", "[LOCATION]", "[NFS_SHARE]"),
            };
            NfsShare expectedResponse = new NfsShare
            {
                NFSShareName = NFSShareName.FromProjectLocationNfsShare("[PROJECT]", "[LOCATION]", "[NFS_SHARE]"),
                NfsShareId = "nfs_share_id674d8775",
                State = NfsShare.Types.State.Unspecified,
                VolumeAsVolumeName = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]"),
                AllowedClients =
                {
                    new NfsShare.Types.AllowedClient(),
                },
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetNfsShare(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BareMetalSolutionClient client = new BareMetalSolutionClientImpl(mockGrpcClient.Object, null, null);
            NfsShare response = client.GetNfsShare(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetNfsShareAsync()
        {
            moq::Mock<BareMetalSolution.BareMetalSolutionClient> mockGrpcClient = new moq::Mock<BareMetalSolution.BareMetalSolutionClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetNfsShareRequest request = new GetNfsShareRequest
            {
                NFSShareName = NFSShareName.FromProjectLocationNfsShare("[PROJECT]", "[LOCATION]", "[NFS_SHARE]"),
            };
            NfsShare expectedResponse = new NfsShare
            {
                NFSShareName = NFSShareName.FromProjectLocationNfsShare("[PROJECT]", "[LOCATION]", "[NFS_SHARE]"),
                NfsShareId = "nfs_share_id674d8775",
                State = NfsShare.Types.State.Unspecified,
                VolumeAsVolumeName = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]"),
                AllowedClients =
                {
                    new NfsShare.Types.AllowedClient(),
                },
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetNfsShareAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<NfsShare>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BareMetalSolutionClient client = new BareMetalSolutionClientImpl(mockGrpcClient.Object, null, null);
            NfsShare responseCallSettings = await client.GetNfsShareAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            NfsShare responseCancellationToken = await client.GetNfsShareAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetNfsShareResourceNames()
        {
            moq::Mock<BareMetalSolution.BareMetalSolutionClient> mockGrpcClient = new moq::Mock<BareMetalSolution.BareMetalSolutionClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetNfsShareRequest request = new GetNfsShareRequest
            {
                NFSShareName = NFSShareName.FromProjectLocationNfsShare("[PROJECT]", "[LOCATION]", "[NFS_SHARE]"),
            };
            NfsShare expectedResponse = new NfsShare
            {
                NFSShareName = NFSShareName.FromProjectLocationNfsShare("[PROJECT]", "[LOCATION]", "[NFS_SHARE]"),
                NfsShareId = "nfs_share_id674d8775",
                State = NfsShare.Types.State.Unspecified,
                VolumeAsVolumeName = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]"),
                AllowedClients =
                {
                    new NfsShare.Types.AllowedClient(),
                },
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetNfsShare(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BareMetalSolutionClient client = new BareMetalSolutionClientImpl(mockGrpcClient.Object, null, null);
            NfsShare response = client.GetNfsShare(request.NFSShareName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetNfsShareResourceNamesAsync()
        {
            moq::Mock<BareMetalSolution.BareMetalSolutionClient> mockGrpcClient = new moq::Mock<BareMetalSolution.BareMetalSolutionClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetNfsShareRequest request = new GetNfsShareRequest
            {
                NFSShareName = NFSShareName.FromProjectLocationNfsShare("[PROJECT]", "[LOCATION]", "[NFS_SHARE]"),
            };
            NfsShare expectedResponse = new NfsShare
            {
                NFSShareName = NFSShareName.FromProjectLocationNfsShare("[PROJECT]", "[LOCATION]", "[NFS_SHARE]"),
                NfsShareId = "nfs_share_id674d8775",
                State = NfsShare.Types.State.Unspecified,
                VolumeAsVolumeName = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]"),
                AllowedClients =
                {
                    new NfsShare.Types.AllowedClient(),
                },
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetNfsShareAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<NfsShare>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BareMetalSolutionClient client = new BareMetalSolutionClientImpl(mockGrpcClient.Object, null, null);
            NfsShare responseCallSettings = await client.GetNfsShareAsync(request.NFSShareName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            NfsShare responseCancellationToken = await client.GetNfsShareAsync(request.NFSShareName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
