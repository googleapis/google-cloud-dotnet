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
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Compute.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedInstancesClientTest
    {
        [xunit::FactAttribute]
        public void GetRequestObject()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForZoneOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetInstanceRequest request = new GetInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                Project = "projectaa6ff846",
            };
            Instance expectedResponse = new Instance
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Tags = new Tags(),
                Zone = "zone255f4ea8",
                ShieldedInstanceConfig = new ShieldedInstanceConfig(),
                SourceMachineImage = "source_machine_image60cc174c",
                ResourcePolicies =
                {
                    "resource_policiesdff15734",
                },
                CreationTimestamp = "creation_timestamp235e59a1",
                PrivateIpv6GoogleAccess = "private_ipv6_google_access0dc5c953",
                NetworkInterfaces =
                {
                    new NetworkInterface(),
                },
                Metadata = new Metadata(),
                Disks = { new AttachedDisk(), },
                StartRestricted = true,
                ReservationAffinity = new ReservationAffinity(),
                ShieldedInstanceIntegrityPolicy = new ShieldedInstanceIntegrityPolicy(),
                LabelFingerprint = "label_fingerprint06ccff3a",
                Status = "status5444cb9a",
                SourceMachineImageEncryptionKey = new CustomerEncryptionKey(),
                MachineType = "machine_type68ce40fa",
                Fingerprint = "fingerprint009e6052",
                Hostname = "hostnamef4ac9708",
                MinCpuPlatform = "min_cpu_platformf71ffa67",
                DisplayDevice = new DisplayDevice(),
                ServiceAccounts =
                {
                    new ServiceAccount(),
                },
                StatusMessage = "status_message2c618f86",
                LastSuspendedTimestamp = "last_suspended_timestamp1e59392b",
                Scheduling = new Scheduling(),
                NetworkPerformanceConfig = new NetworkPerformanceConfig(),
                AdvancedMachineFeatures = new AdvancedMachineFeatures(),
                CpuPlatform = "cpu_platformd5794042",
                LastStopTimestamp = "last_stop_timestampd336a8f1",
                Description = "description2cf9da67",
                LastStartTimestamp = "last_start_timestampe26bd347",
                SelfLink = "self_link7e87f12d",
                DeletionProtection = false,
                GuestAccelerators =
                {
                    new AcceleratorConfig(),
                },
                CanIpForward = true,
                SatisfiesPzs = false,
                ConfidentialInstanceConfig = new ConfidentialInstanceConfig(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Instance response = client.Get(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRequestObjectAsync()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForZoneOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetInstanceRequest request = new GetInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                Project = "projectaa6ff846",
            };
            Instance expectedResponse = new Instance
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Tags = new Tags(),
                Zone = "zone255f4ea8",
                ShieldedInstanceConfig = new ShieldedInstanceConfig(),
                SourceMachineImage = "source_machine_image60cc174c",
                ResourcePolicies =
                {
                    "resource_policiesdff15734",
                },
                CreationTimestamp = "creation_timestamp235e59a1",
                PrivateIpv6GoogleAccess = "private_ipv6_google_access0dc5c953",
                NetworkInterfaces =
                {
                    new NetworkInterface(),
                },
                Metadata = new Metadata(),
                Disks = { new AttachedDisk(), },
                StartRestricted = true,
                ReservationAffinity = new ReservationAffinity(),
                ShieldedInstanceIntegrityPolicy = new ShieldedInstanceIntegrityPolicy(),
                LabelFingerprint = "label_fingerprint06ccff3a",
                Status = "status5444cb9a",
                SourceMachineImageEncryptionKey = new CustomerEncryptionKey(),
                MachineType = "machine_type68ce40fa",
                Fingerprint = "fingerprint009e6052",
                Hostname = "hostnamef4ac9708",
                MinCpuPlatform = "min_cpu_platformf71ffa67",
                DisplayDevice = new DisplayDevice(),
                ServiceAccounts =
                {
                    new ServiceAccount(),
                },
                StatusMessage = "status_message2c618f86",
                LastSuspendedTimestamp = "last_suspended_timestamp1e59392b",
                Scheduling = new Scheduling(),
                NetworkPerformanceConfig = new NetworkPerformanceConfig(),
                AdvancedMachineFeatures = new AdvancedMachineFeatures(),
                CpuPlatform = "cpu_platformd5794042",
                LastStopTimestamp = "last_stop_timestampd336a8f1",
                Description = "description2cf9da67",
                LastStartTimestamp = "last_start_timestampe26bd347",
                SelfLink = "self_link7e87f12d",
                DeletionProtection = false,
                GuestAccelerators =
                {
                    new AcceleratorConfig(),
                },
                CanIpForward = true,
                SatisfiesPzs = false,
                ConfidentialInstanceConfig = new ConfidentialInstanceConfig(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Instance>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Instance responseCallSettings = await client.GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Instance responseCancellationToken = await client.GetAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Get()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForZoneOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetInstanceRequest request = new GetInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                Project = "projectaa6ff846",
            };
            Instance expectedResponse = new Instance
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Tags = new Tags(),
                Zone = "zone255f4ea8",
                ShieldedInstanceConfig = new ShieldedInstanceConfig(),
                SourceMachineImage = "source_machine_image60cc174c",
                ResourcePolicies =
                {
                    "resource_policiesdff15734",
                },
                CreationTimestamp = "creation_timestamp235e59a1",
                PrivateIpv6GoogleAccess = "private_ipv6_google_access0dc5c953",
                NetworkInterfaces =
                {
                    new NetworkInterface(),
                },
                Metadata = new Metadata(),
                Disks = { new AttachedDisk(), },
                StartRestricted = true,
                ReservationAffinity = new ReservationAffinity(),
                ShieldedInstanceIntegrityPolicy = new ShieldedInstanceIntegrityPolicy(),
                LabelFingerprint = "label_fingerprint06ccff3a",
                Status = "status5444cb9a",
                SourceMachineImageEncryptionKey = new CustomerEncryptionKey(),
                MachineType = "machine_type68ce40fa",
                Fingerprint = "fingerprint009e6052",
                Hostname = "hostnamef4ac9708",
                MinCpuPlatform = "min_cpu_platformf71ffa67",
                DisplayDevice = new DisplayDevice(),
                ServiceAccounts =
                {
                    new ServiceAccount(),
                },
                StatusMessage = "status_message2c618f86",
                LastSuspendedTimestamp = "last_suspended_timestamp1e59392b",
                Scheduling = new Scheduling(),
                NetworkPerformanceConfig = new NetworkPerformanceConfig(),
                AdvancedMachineFeatures = new AdvancedMachineFeatures(),
                CpuPlatform = "cpu_platformd5794042",
                LastStopTimestamp = "last_stop_timestampd336a8f1",
                Description = "description2cf9da67",
                LastStartTimestamp = "last_start_timestampe26bd347",
                SelfLink = "self_link7e87f12d",
                DeletionProtection = false,
                GuestAccelerators =
                {
                    new AcceleratorConfig(),
                },
                CanIpForward = true,
                SatisfiesPzs = false,
                ConfidentialInstanceConfig = new ConfidentialInstanceConfig(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Instance response = client.Get(request.Project, request.Zone, request.Instance);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAsync()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForZoneOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetInstanceRequest request = new GetInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                Project = "projectaa6ff846",
            };
            Instance expectedResponse = new Instance
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Tags = new Tags(),
                Zone = "zone255f4ea8",
                ShieldedInstanceConfig = new ShieldedInstanceConfig(),
                SourceMachineImage = "source_machine_image60cc174c",
                ResourcePolicies =
                {
                    "resource_policiesdff15734",
                },
                CreationTimestamp = "creation_timestamp235e59a1",
                PrivateIpv6GoogleAccess = "private_ipv6_google_access0dc5c953",
                NetworkInterfaces =
                {
                    new NetworkInterface(),
                },
                Metadata = new Metadata(),
                Disks = { new AttachedDisk(), },
                StartRestricted = true,
                ReservationAffinity = new ReservationAffinity(),
                ShieldedInstanceIntegrityPolicy = new ShieldedInstanceIntegrityPolicy(),
                LabelFingerprint = "label_fingerprint06ccff3a",
                Status = "status5444cb9a",
                SourceMachineImageEncryptionKey = new CustomerEncryptionKey(),
                MachineType = "machine_type68ce40fa",
                Fingerprint = "fingerprint009e6052",
                Hostname = "hostnamef4ac9708",
                MinCpuPlatform = "min_cpu_platformf71ffa67",
                DisplayDevice = new DisplayDevice(),
                ServiceAccounts =
                {
                    new ServiceAccount(),
                },
                StatusMessage = "status_message2c618f86",
                LastSuspendedTimestamp = "last_suspended_timestamp1e59392b",
                Scheduling = new Scheduling(),
                NetworkPerformanceConfig = new NetworkPerformanceConfig(),
                AdvancedMachineFeatures = new AdvancedMachineFeatures(),
                CpuPlatform = "cpu_platformd5794042",
                LastStopTimestamp = "last_stop_timestampd336a8f1",
                Description = "description2cf9da67",
                LastStartTimestamp = "last_start_timestampe26bd347",
                SelfLink = "self_link7e87f12d",
                DeletionProtection = false,
                GuestAccelerators =
                {
                    new AcceleratorConfig(),
                },
                CanIpForward = true,
                SatisfiesPzs = false,
                ConfidentialInstanceConfig = new ConfidentialInstanceConfig(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Instance>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Instance responseCallSettings = await client.GetAsync(request.Project, request.Zone, request.Instance, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Instance responseCancellationToken = await client.GetAsync(request.Project, request.Zone, request.Instance, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetEffectiveFirewallsRequestObject()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForZoneOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetEffectiveFirewallsInstanceRequest request = new GetEffectiveFirewallsInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                Project = "projectaa6ff846",
                NetworkInterface = "network_interfaceb50da44f",
            };
            InstancesGetEffectiveFirewallsResponse expectedResponse = new InstancesGetEffectiveFirewallsResponse
            {
                Firewalls = { new Firewall(), },
                FirewallPolicys =
                {
                    new InstancesGetEffectiveFirewallsResponseEffectiveFirewallPolicy(),
                },
            };
            mockGrpcClient.Setup(x => x.GetEffectiveFirewalls(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            InstancesGetEffectiveFirewallsResponse response = client.GetEffectiveFirewalls(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetEffectiveFirewallsRequestObjectAsync()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForZoneOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetEffectiveFirewallsInstanceRequest request = new GetEffectiveFirewallsInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                Project = "projectaa6ff846",
                NetworkInterface = "network_interfaceb50da44f",
            };
            InstancesGetEffectiveFirewallsResponse expectedResponse = new InstancesGetEffectiveFirewallsResponse
            {
                Firewalls = { new Firewall(), },
                FirewallPolicys =
                {
                    new InstancesGetEffectiveFirewallsResponseEffectiveFirewallPolicy(),
                },
            };
            mockGrpcClient.Setup(x => x.GetEffectiveFirewallsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<InstancesGetEffectiveFirewallsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            InstancesGetEffectiveFirewallsResponse responseCallSettings = await client.GetEffectiveFirewallsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            InstancesGetEffectiveFirewallsResponse responseCancellationToken = await client.GetEffectiveFirewallsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetEffectiveFirewalls()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForZoneOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetEffectiveFirewallsInstanceRequest request = new GetEffectiveFirewallsInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                Project = "projectaa6ff846",
                NetworkInterface = "network_interfaceb50da44f",
            };
            InstancesGetEffectiveFirewallsResponse expectedResponse = new InstancesGetEffectiveFirewallsResponse
            {
                Firewalls = { new Firewall(), },
                FirewallPolicys =
                {
                    new InstancesGetEffectiveFirewallsResponseEffectiveFirewallPolicy(),
                },
            };
            mockGrpcClient.Setup(x => x.GetEffectiveFirewalls(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            InstancesGetEffectiveFirewallsResponse response = client.GetEffectiveFirewalls(request.Project, request.Zone, request.Instance, request.NetworkInterface);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetEffectiveFirewallsAsync()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForZoneOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetEffectiveFirewallsInstanceRequest request = new GetEffectiveFirewallsInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                Project = "projectaa6ff846",
                NetworkInterface = "network_interfaceb50da44f",
            };
            InstancesGetEffectiveFirewallsResponse expectedResponse = new InstancesGetEffectiveFirewallsResponse
            {
                Firewalls = { new Firewall(), },
                FirewallPolicys =
                {
                    new InstancesGetEffectiveFirewallsResponseEffectiveFirewallPolicy(),
                },
            };
            mockGrpcClient.Setup(x => x.GetEffectiveFirewallsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<InstancesGetEffectiveFirewallsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            InstancesGetEffectiveFirewallsResponse responseCallSettings = await client.GetEffectiveFirewallsAsync(request.Project, request.Zone, request.Instance, request.NetworkInterface, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            InstancesGetEffectiveFirewallsResponse responseCancellationToken = await client.GetEffectiveFirewallsAsync(request.Project, request.Zone, request.Instance, request.NetworkInterface, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetGuestAttributesRequestObject()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForZoneOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetGuestAttributesInstanceRequest request = new GetGuestAttributesInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                VariableKey = "variable_key1c249a45",
                Project = "projectaa6ff846",
                QueryPath = "query_pathf44da93a",
            };
            GuestAttributes expectedResponse = new GuestAttributes
            {
                Kind = "kindf7aa39d9",
                VariableValue = "variable_value61cc0fab",
                QueryValue = new GuestAttributesValue(),
                VariableKey = "variable_key1c249a45",
                QueryPath = "query_pathf44da93a",
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.GetGuestAttributes(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            GuestAttributes response = client.GetGuestAttributes(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetGuestAttributesRequestObjectAsync()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForZoneOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetGuestAttributesInstanceRequest request = new GetGuestAttributesInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                VariableKey = "variable_key1c249a45",
                Project = "projectaa6ff846",
                QueryPath = "query_pathf44da93a",
            };
            GuestAttributes expectedResponse = new GuestAttributes
            {
                Kind = "kindf7aa39d9",
                VariableValue = "variable_value61cc0fab",
                QueryValue = new GuestAttributesValue(),
                VariableKey = "variable_key1c249a45",
                QueryPath = "query_pathf44da93a",
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.GetGuestAttributesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<GuestAttributes>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            GuestAttributes responseCallSettings = await client.GetGuestAttributesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            GuestAttributes responseCancellationToken = await client.GetGuestAttributesAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetGuestAttributes()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForZoneOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetGuestAttributesInstanceRequest request = new GetGuestAttributesInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                Project = "projectaa6ff846",
            };
            GuestAttributes expectedResponse = new GuestAttributes
            {
                Kind = "kindf7aa39d9",
                VariableValue = "variable_value61cc0fab",
                QueryValue = new GuestAttributesValue(),
                VariableKey = "variable_key1c249a45",
                QueryPath = "query_pathf44da93a",
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.GetGuestAttributes(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            GuestAttributes response = client.GetGuestAttributes(request.Project, request.Zone, request.Instance);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetGuestAttributesAsync()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForZoneOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetGuestAttributesInstanceRequest request = new GetGuestAttributesInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                Project = "projectaa6ff846",
            };
            GuestAttributes expectedResponse = new GuestAttributes
            {
                Kind = "kindf7aa39d9",
                VariableValue = "variable_value61cc0fab",
                QueryValue = new GuestAttributesValue(),
                VariableKey = "variable_key1c249a45",
                QueryPath = "query_pathf44da93a",
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.GetGuestAttributesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<GuestAttributes>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            GuestAttributes responseCallSettings = await client.GetGuestAttributesAsync(request.Project, request.Zone, request.Instance, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            GuestAttributes responseCancellationToken = await client.GetGuestAttributesAsync(request.Project, request.Zone, request.Instance, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetIamPolicyRequestObject()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForZoneOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetIamPolicyInstanceRequest request = new GetIamPolicyInstanceRequest
            {
                Zone = "zone255f4ea8",
                Resource = "resource164eab96",
                Project = "projectaa6ff846",
                OptionsRequestedPolicyVersion = -1471234741,
            };
            Policy expectedResponse = new Policy
            {
                Etag = "etage8ad7218",
                Rules = { new Rule(), },
                AuditConfigs = { new AuditConfig(), },
                Version = 271578922,
                Bindings = { new Binding(), },
            };
            mockGrpcClient.Setup(x => x.GetIamPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Policy response = client.GetIamPolicy(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetIamPolicyRequestObjectAsync()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForZoneOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetIamPolicyInstanceRequest request = new GetIamPolicyInstanceRequest
            {
                Zone = "zone255f4ea8",
                Resource = "resource164eab96",
                Project = "projectaa6ff846",
                OptionsRequestedPolicyVersion = -1471234741,
            };
            Policy expectedResponse = new Policy
            {
                Etag = "etage8ad7218",
                Rules = { new Rule(), },
                AuditConfigs = { new AuditConfig(), },
                Version = 271578922,
                Bindings = { new Binding(), },
            };
            mockGrpcClient.Setup(x => x.GetIamPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Policy responseCallSettings = await client.GetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Policy responseCancellationToken = await client.GetIamPolicyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetIamPolicy()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForZoneOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetIamPolicyInstanceRequest request = new GetIamPolicyInstanceRequest
            {
                Zone = "zone255f4ea8",
                Resource = "resource164eab96",
                Project = "projectaa6ff846",
            };
            Policy expectedResponse = new Policy
            {
                Etag = "etage8ad7218",
                Rules = { new Rule(), },
                AuditConfigs = { new AuditConfig(), },
                Version = 271578922,
                Bindings = { new Binding(), },
            };
            mockGrpcClient.Setup(x => x.GetIamPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Policy response = client.GetIamPolicy(request.Project, request.Zone, request.Resource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetIamPolicyAsync()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForZoneOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetIamPolicyInstanceRequest request = new GetIamPolicyInstanceRequest
            {
                Zone = "zone255f4ea8",
                Resource = "resource164eab96",
                Project = "projectaa6ff846",
            };
            Policy expectedResponse = new Policy
            {
                Etag = "etage8ad7218",
                Rules = { new Rule(), },
                AuditConfigs = { new AuditConfig(), },
                Version = 271578922,
                Bindings = { new Binding(), },
            };
            mockGrpcClient.Setup(x => x.GetIamPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Policy responseCallSettings = await client.GetIamPolicyAsync(request.Project, request.Zone, request.Resource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Policy responseCancellationToken = await client.GetIamPolicyAsync(request.Project, request.Zone, request.Resource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetScreenshotRequestObject()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForZoneOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetScreenshotInstanceRequest request = new GetScreenshotInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                Project = "projectaa6ff846",
            };
            Screenshot expectedResponse = new Screenshot
            {
                Kind = "kindf7aa39d9",
                Contents = "contents8c7dbf98",
            };
            mockGrpcClient.Setup(x => x.GetScreenshot(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Screenshot response = client.GetScreenshot(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetScreenshotRequestObjectAsync()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForZoneOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetScreenshotInstanceRequest request = new GetScreenshotInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                Project = "projectaa6ff846",
            };
            Screenshot expectedResponse = new Screenshot
            {
                Kind = "kindf7aa39d9",
                Contents = "contents8c7dbf98",
            };
            mockGrpcClient.Setup(x => x.GetScreenshotAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Screenshot>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Screenshot responseCallSettings = await client.GetScreenshotAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Screenshot responseCancellationToken = await client.GetScreenshotAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetScreenshot()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForZoneOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetScreenshotInstanceRequest request = new GetScreenshotInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                Project = "projectaa6ff846",
            };
            Screenshot expectedResponse = new Screenshot
            {
                Kind = "kindf7aa39d9",
                Contents = "contents8c7dbf98",
            };
            mockGrpcClient.Setup(x => x.GetScreenshot(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Screenshot response = client.GetScreenshot(request.Project, request.Zone, request.Instance);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetScreenshotAsync()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForZoneOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetScreenshotInstanceRequest request = new GetScreenshotInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                Project = "projectaa6ff846",
            };
            Screenshot expectedResponse = new Screenshot
            {
                Kind = "kindf7aa39d9",
                Contents = "contents8c7dbf98",
            };
            mockGrpcClient.Setup(x => x.GetScreenshotAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Screenshot>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Screenshot responseCallSettings = await client.GetScreenshotAsync(request.Project, request.Zone, request.Instance, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Screenshot responseCancellationToken = await client.GetScreenshotAsync(request.Project, request.Zone, request.Instance, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetSerialPortOutputRequestObject()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForZoneOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetSerialPortOutputInstanceRequest request = new GetSerialPortOutputInstanceRequest
            {
                Port = -78310000,
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                Start = -5616678393427383318L,
                Project = "projectaa6ff846",
            };
            SerialPortOutput expectedResponse = new SerialPortOutput
            {
                Kind = "kindf7aa39d9",
                Next = 9139246809011047120L,
                Start = -5616678393427383318L,
                SelfLink = "self_link7e87f12d",
                Contents = "contents8c7dbf98",
            };
            mockGrpcClient.Setup(x => x.GetSerialPortOutput(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            SerialPortOutput response = client.GetSerialPortOutput(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetSerialPortOutputRequestObjectAsync()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForZoneOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetSerialPortOutputInstanceRequest request = new GetSerialPortOutputInstanceRequest
            {
                Port = -78310000,
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                Start = -5616678393427383318L,
                Project = "projectaa6ff846",
            };
            SerialPortOutput expectedResponse = new SerialPortOutput
            {
                Kind = "kindf7aa39d9",
                Next = 9139246809011047120L,
                Start = -5616678393427383318L,
                SelfLink = "self_link7e87f12d",
                Contents = "contents8c7dbf98",
            };
            mockGrpcClient.Setup(x => x.GetSerialPortOutputAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SerialPortOutput>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            SerialPortOutput responseCallSettings = await client.GetSerialPortOutputAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SerialPortOutput responseCancellationToken = await client.GetSerialPortOutputAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetSerialPortOutput()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForZoneOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetSerialPortOutputInstanceRequest request = new GetSerialPortOutputInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                Project = "projectaa6ff846",
            };
            SerialPortOutput expectedResponse = new SerialPortOutput
            {
                Kind = "kindf7aa39d9",
                Next = 9139246809011047120L,
                Start = -5616678393427383318L,
                SelfLink = "self_link7e87f12d",
                Contents = "contents8c7dbf98",
            };
            mockGrpcClient.Setup(x => x.GetSerialPortOutput(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            SerialPortOutput response = client.GetSerialPortOutput(request.Project, request.Zone, request.Instance);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetSerialPortOutputAsync()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForZoneOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetSerialPortOutputInstanceRequest request = new GetSerialPortOutputInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                Project = "projectaa6ff846",
            };
            SerialPortOutput expectedResponse = new SerialPortOutput
            {
                Kind = "kindf7aa39d9",
                Next = 9139246809011047120L,
                Start = -5616678393427383318L,
                SelfLink = "self_link7e87f12d",
                Contents = "contents8c7dbf98",
            };
            mockGrpcClient.Setup(x => x.GetSerialPortOutputAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SerialPortOutput>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            SerialPortOutput responseCallSettings = await client.GetSerialPortOutputAsync(request.Project, request.Zone, request.Instance, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SerialPortOutput responseCancellationToken = await client.GetSerialPortOutputAsync(request.Project, request.Zone, request.Instance, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetShieldedInstanceIdentityRequestObject()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForZoneOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetShieldedInstanceIdentityInstanceRequest request = new GetShieldedInstanceIdentityInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                Project = "projectaa6ff846",
            };
            ShieldedInstanceIdentity expectedResponse = new ShieldedInstanceIdentity
            {
                Kind = "kindf7aa39d9",
                SigningKey = new ShieldedInstanceIdentityEntry(),
                EncryptionKey = new ShieldedInstanceIdentityEntry(),
            };
            mockGrpcClient.Setup(x => x.GetShieldedInstanceIdentity(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            ShieldedInstanceIdentity response = client.GetShieldedInstanceIdentity(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetShieldedInstanceIdentityRequestObjectAsync()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForZoneOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetShieldedInstanceIdentityInstanceRequest request = new GetShieldedInstanceIdentityInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                Project = "projectaa6ff846",
            };
            ShieldedInstanceIdentity expectedResponse = new ShieldedInstanceIdentity
            {
                Kind = "kindf7aa39d9",
                SigningKey = new ShieldedInstanceIdentityEntry(),
                EncryptionKey = new ShieldedInstanceIdentityEntry(),
            };
            mockGrpcClient.Setup(x => x.GetShieldedInstanceIdentityAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ShieldedInstanceIdentity>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            ShieldedInstanceIdentity responseCallSettings = await client.GetShieldedInstanceIdentityAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ShieldedInstanceIdentity responseCancellationToken = await client.GetShieldedInstanceIdentityAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetShieldedInstanceIdentity()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForZoneOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetShieldedInstanceIdentityInstanceRequest request = new GetShieldedInstanceIdentityInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                Project = "projectaa6ff846",
            };
            ShieldedInstanceIdentity expectedResponse = new ShieldedInstanceIdentity
            {
                Kind = "kindf7aa39d9",
                SigningKey = new ShieldedInstanceIdentityEntry(),
                EncryptionKey = new ShieldedInstanceIdentityEntry(),
            };
            mockGrpcClient.Setup(x => x.GetShieldedInstanceIdentity(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            ShieldedInstanceIdentity response = client.GetShieldedInstanceIdentity(request.Project, request.Zone, request.Instance);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetShieldedInstanceIdentityAsync()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForZoneOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetShieldedInstanceIdentityInstanceRequest request = new GetShieldedInstanceIdentityInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                Project = "projectaa6ff846",
            };
            ShieldedInstanceIdentity expectedResponse = new ShieldedInstanceIdentity
            {
                Kind = "kindf7aa39d9",
                SigningKey = new ShieldedInstanceIdentityEntry(),
                EncryptionKey = new ShieldedInstanceIdentityEntry(),
            };
            mockGrpcClient.Setup(x => x.GetShieldedInstanceIdentityAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ShieldedInstanceIdentity>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            ShieldedInstanceIdentity responseCallSettings = await client.GetShieldedInstanceIdentityAsync(request.Project, request.Zone, request.Instance, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ShieldedInstanceIdentity responseCancellationToken = await client.GetShieldedInstanceIdentityAsync(request.Project, request.Zone, request.Instance, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SendDiagnosticInterruptRequestObject()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForZoneOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            SendDiagnosticInterruptInstanceRequest request = new SendDiagnosticInterruptInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                Project = "projectaa6ff846",
            };
            SendDiagnosticInterruptInstanceResponse expectedResponse = new SendDiagnosticInterruptInstanceResponse { };
            mockGrpcClient.Setup(x => x.SendDiagnosticInterrupt(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            SendDiagnosticInterruptInstanceResponse response = client.SendDiagnosticInterrupt(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SendDiagnosticInterruptRequestObjectAsync()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForZoneOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            SendDiagnosticInterruptInstanceRequest request = new SendDiagnosticInterruptInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                Project = "projectaa6ff846",
            };
            SendDiagnosticInterruptInstanceResponse expectedResponse = new SendDiagnosticInterruptInstanceResponse { };
            mockGrpcClient.Setup(x => x.SendDiagnosticInterruptAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SendDiagnosticInterruptInstanceResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            SendDiagnosticInterruptInstanceResponse responseCallSettings = await client.SendDiagnosticInterruptAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SendDiagnosticInterruptInstanceResponse responseCancellationToken = await client.SendDiagnosticInterruptAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SendDiagnosticInterrupt()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForZoneOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            SendDiagnosticInterruptInstanceRequest request = new SendDiagnosticInterruptInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                Project = "projectaa6ff846",
            };
            SendDiagnosticInterruptInstanceResponse expectedResponse = new SendDiagnosticInterruptInstanceResponse { };
            mockGrpcClient.Setup(x => x.SendDiagnosticInterrupt(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            SendDiagnosticInterruptInstanceResponse response = client.SendDiagnosticInterrupt(request.Project, request.Zone, request.Instance);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SendDiagnosticInterruptAsync()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForZoneOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            SendDiagnosticInterruptInstanceRequest request = new SendDiagnosticInterruptInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                Project = "projectaa6ff846",
            };
            SendDiagnosticInterruptInstanceResponse expectedResponse = new SendDiagnosticInterruptInstanceResponse { };
            mockGrpcClient.Setup(x => x.SendDiagnosticInterruptAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SendDiagnosticInterruptInstanceResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            SendDiagnosticInterruptInstanceResponse responseCallSettings = await client.SendDiagnosticInterruptAsync(request.Project, request.Zone, request.Instance, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SendDiagnosticInterruptInstanceResponse responseCancellationToken = await client.SendDiagnosticInterruptAsync(request.Project, request.Zone, request.Instance, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetIamPolicyRequestObject()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForZoneOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            SetIamPolicyInstanceRequest request = new SetIamPolicyInstanceRequest
            {
                Zone = "zone255f4ea8",
                Resource = "resource164eab96",
                Project = "projectaa6ff846",
                ZoneSetPolicyRequestResource = new ZoneSetPolicyRequest(),
            };
            Policy expectedResponse = new Policy
            {
                Etag = "etage8ad7218",
                Rules = { new Rule(), },
                AuditConfigs = { new AuditConfig(), },
                Version = 271578922,
                Bindings = { new Binding(), },
            };
            mockGrpcClient.Setup(x => x.SetIamPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Policy response = client.SetIamPolicy(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetIamPolicyRequestObjectAsync()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForZoneOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            SetIamPolicyInstanceRequest request = new SetIamPolicyInstanceRequest
            {
                Zone = "zone255f4ea8",
                Resource = "resource164eab96",
                Project = "projectaa6ff846",
                ZoneSetPolicyRequestResource = new ZoneSetPolicyRequest(),
            };
            Policy expectedResponse = new Policy
            {
                Etag = "etage8ad7218",
                Rules = { new Rule(), },
                AuditConfigs = { new AuditConfig(), },
                Version = 271578922,
                Bindings = { new Binding(), },
            };
            mockGrpcClient.Setup(x => x.SetIamPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Policy responseCallSettings = await client.SetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Policy responseCancellationToken = await client.SetIamPolicyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetIamPolicy()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForZoneOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            SetIamPolicyInstanceRequest request = new SetIamPolicyInstanceRequest
            {
                Zone = "zone255f4ea8",
                Resource = "resource164eab96",
                Project = "projectaa6ff846",
                ZoneSetPolicyRequestResource = new ZoneSetPolicyRequest(),
            };
            Policy expectedResponse = new Policy
            {
                Etag = "etage8ad7218",
                Rules = { new Rule(), },
                AuditConfigs = { new AuditConfig(), },
                Version = 271578922,
                Bindings = { new Binding(), },
            };
            mockGrpcClient.Setup(x => x.SetIamPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Policy response = client.SetIamPolicy(request.Project, request.Zone, request.Resource, request.ZoneSetPolicyRequestResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetIamPolicyAsync()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForZoneOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            SetIamPolicyInstanceRequest request = new SetIamPolicyInstanceRequest
            {
                Zone = "zone255f4ea8",
                Resource = "resource164eab96",
                Project = "projectaa6ff846",
                ZoneSetPolicyRequestResource = new ZoneSetPolicyRequest(),
            };
            Policy expectedResponse = new Policy
            {
                Etag = "etage8ad7218",
                Rules = { new Rule(), },
                AuditConfigs = { new AuditConfig(), },
                Version = 271578922,
                Bindings = { new Binding(), },
            };
            mockGrpcClient.Setup(x => x.SetIamPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Policy responseCallSettings = await client.SetIamPolicyAsync(request.Project, request.Zone, request.Resource, request.ZoneSetPolicyRequestResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Policy responseCancellationToken = await client.SetIamPolicyAsync(request.Project, request.Zone, request.Resource, request.ZoneSetPolicyRequestResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void TestIamPermissionsRequestObject()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForZoneOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            TestIamPermissionsInstanceRequest request = new TestIamPermissionsInstanceRequest
            {
                Zone = "zone255f4ea8",
                Resource = "resource164eab96",
                Project = "projectaa6ff846",
                TestPermissionsRequestResource = new TestPermissionsRequest(),
            };
            TestPermissionsResponse expectedResponse = new TestPermissionsResponse
            {
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            mockGrpcClient.Setup(x => x.TestIamPermissions(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            TestPermissionsResponse response = client.TestIamPermissions(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task TestIamPermissionsRequestObjectAsync()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForZoneOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            TestIamPermissionsInstanceRequest request = new TestIamPermissionsInstanceRequest
            {
                Zone = "zone255f4ea8",
                Resource = "resource164eab96",
                Project = "projectaa6ff846",
                TestPermissionsRequestResource = new TestPermissionsRequest(),
            };
            TestPermissionsResponse expectedResponse = new TestPermissionsResponse
            {
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            mockGrpcClient.Setup(x => x.TestIamPermissionsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TestPermissionsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            TestPermissionsResponse responseCallSettings = await client.TestIamPermissionsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TestPermissionsResponse responseCancellationToken = await client.TestIamPermissionsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void TestIamPermissions()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForZoneOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            TestIamPermissionsInstanceRequest request = new TestIamPermissionsInstanceRequest
            {
                Zone = "zone255f4ea8",
                Resource = "resource164eab96",
                Project = "projectaa6ff846",
                TestPermissionsRequestResource = new TestPermissionsRequest(),
            };
            TestPermissionsResponse expectedResponse = new TestPermissionsResponse
            {
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            mockGrpcClient.Setup(x => x.TestIamPermissions(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            TestPermissionsResponse response = client.TestIamPermissions(request.Project, request.Zone, request.Resource, request.TestPermissionsRequestResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task TestIamPermissionsAsync()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForZoneOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            TestIamPermissionsInstanceRequest request = new TestIamPermissionsInstanceRequest
            {
                Zone = "zone255f4ea8",
                Resource = "resource164eab96",
                Project = "projectaa6ff846",
                TestPermissionsRequestResource = new TestPermissionsRequest(),
            };
            TestPermissionsResponse expectedResponse = new TestPermissionsResponse
            {
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            mockGrpcClient.Setup(x => x.TestIamPermissionsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TestPermissionsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            TestPermissionsResponse responseCallSettings = await client.TestIamPermissionsAsync(request.Project, request.Zone, request.Resource, request.TestPermissionsRequestResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TestPermissionsResponse responseCancellationToken = await client.TestIamPermissionsAsync(request.Project, request.Zone, request.Resource, request.TestPermissionsRequestResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
