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

namespace Google.Cloud.Dataproc.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedClusterControllerClientTest
    {
        [xunit::FactAttribute]
        public void GetClusterRequestObject()
        {
            moq::Mock<ClusterController.ClusterControllerClient> mockGrpcClient = new moq::Mock<ClusterController.ClusterControllerClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetClusterRequest request = new GetClusterRequest
            {
                ProjectId = "project_id43ad98b0",
                ClusterName = "cluster_name88432a5e",
                Region = "regionedb20d96",
            };
            Cluster expectedResponse = new Cluster
            {
                ProjectId = "project_id43ad98b0",
                ClusterName = "cluster_name88432a5e",
                Config = new ClusterConfig
                {
                    ConfigBucket = "config_bucketd15911b6",
                    TempBucket = "temp_bucketd48b432d",
                    GceClusterConfig = new GceClusterConfig
                    {
                        ZoneUri = "zone_uri4fe803bb",
                        NetworkUri = "network_uri199d3d75",
                        ServiceAccountScopes =
                        {
                            "service_account_scopesd4b7f658",
                        },
                        Tags = { "tags52c47ad5", },
                        Metadata =
                        {
                            {
                                "key8a0b6e3c",
                                "value60c16320"
                            },
                        },
                        SubnetworkUri = "subnetwork_uri7e1926ac",
                        InternalIpOnly = false,
                        ServiceAccount = "service_accounta3c1b923",
                        ReservationAffinity = new ReservationAffinity
                        {
                            ConsumeReservationType = ReservationAffinity.Types.Type.NoReservation,
                            Key = "key8a0b6e3c",
                            Values = { "valueseec79cf0", },
                        },
                    },
                    MasterConfig = new InstanceGroupConfig
                    {
                        NumInstances = 2024006720,
                        InstanceNames =
                        {
                            "instance_nameseaa0d94a",
                        },
                        ImageUri = "image_urieba3b1bc",
                        MachineTypeUri = "machine_type_uric6f28ef8",
                        DiskConfig = new DiskConfig
                        {
                            BootDiskSizeGb = 235820582,
                            NumLocalSsds = -1540065901,
                            BootDiskType = "boot_disk_typea1cf67c6",
                        },
                        IsPreemptible = false,
                        ManagedGroupConfig = new ManagedGroupConfig
                        {
                            InstanceTemplateName = "instance_template_name6cb940d2",
                            InstanceGroupManagerName = "instance_group_manager_name2b7c5b49",
                        },
                        Accelerators =
                        {
                            new AcceleratorConfig
                            {
                                AcceleratorTypeUri = "accelerator_type_uri5054fee7",
                                AcceleratorCount = -1461378825,
                            },
                        },
                        MinCpuPlatform = "min_cpu_platformf71ffa67",
                        Preemptibility = InstanceGroupConfig.Types.Preemptibility.NonPreemptible,
                    },
                    WorkerConfig = new InstanceGroupConfig
                    {
                        NumInstances = 2024006720,
                        InstanceNames =
                        {
                            "instance_nameseaa0d94a",
                        },
                        ImageUri = "image_urieba3b1bc",
                        MachineTypeUri = "machine_type_uric6f28ef8",
                        DiskConfig = new DiskConfig
                        {
                            BootDiskSizeGb = 235820582,
                            NumLocalSsds = -1540065901,
                            BootDiskType = "boot_disk_typea1cf67c6",
                        },
                        IsPreemptible = false,
                        ManagedGroupConfig = new ManagedGroupConfig
                        {
                            InstanceTemplateName = "instance_template_name6cb940d2",
                            InstanceGroupManagerName = "instance_group_manager_name2b7c5b49",
                        },
                        Accelerators =
                        {
                            new AcceleratorConfig
                            {
                                AcceleratorTypeUri = "accelerator_type_uri5054fee7",
                                AcceleratorCount = -1461378825,
                            },
                        },
                        MinCpuPlatform = "min_cpu_platformf71ffa67",
                        Preemptibility = InstanceGroupConfig.Types.Preemptibility.NonPreemptible,
                    },
                    InitializationActions =
                    {
                        new NodeInitializationAction
                        {
                            ExecutableFile = "executable_file8c147260",
                            ExecutionTimeout = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                        },
                    },
                    SecondaryWorkerConfig = new InstanceGroupConfig
                    {
                        NumInstances = 2024006720,
                        InstanceNames =
                        {
                            "instance_nameseaa0d94a",
                        },
                        ImageUri = "image_urieba3b1bc",
                        MachineTypeUri = "machine_type_uric6f28ef8",
                        DiskConfig = new DiskConfig
                        {
                            BootDiskSizeGb = 235820582,
                            NumLocalSsds = -1540065901,
                            BootDiskType = "boot_disk_typea1cf67c6",
                        },
                        IsPreemptible = false,
                        ManagedGroupConfig = new ManagedGroupConfig
                        {
                            InstanceTemplateName = "instance_template_name6cb940d2",
                            InstanceGroupManagerName = "instance_group_manager_name2b7c5b49",
                        },
                        Accelerators =
                        {
                            new AcceleratorConfig
                            {
                                AcceleratorTypeUri = "accelerator_type_uri5054fee7",
                                AcceleratorCount = -1461378825,
                            },
                        },
                        MinCpuPlatform = "min_cpu_platformf71ffa67",
                        Preemptibility = InstanceGroupConfig.Types.Preemptibility.NonPreemptible,
                    },
                    SoftwareConfig = new SoftwareConfig
                    {
                        ImageVersion = "image_version9e803c4e",
                        Properties =
                        {
                            {
                                "key8a0b6e3c",
                                "value60c16320"
                            },
                        },
                        OptionalComponents =
                        {
                            Component.Zeppelin,
                        },
                    },
                    EncryptionConfig = new EncryptionConfig
                    {
                        GcePdKmsKeyName = "gce_pd_kms_key_name720e24f6",
                    },
                    SecurityConfig = new SecurityConfig
                    {
                        KerberosConfig = new KerberosConfig
                        {
                            EnableKerberos = false,
                            RootPrincipalPasswordUri = "root_principal_password_uri2224718d",
                            KmsKeyUri = "kms_key_uri04b314da",
                            KeystoreUri = "keystore_uri6b0c93a3",
                            TruststoreUri = "truststore_uri533872fa",
                            KeystorePasswordUri = "keystore_password_uri8afdd2b5",
                            KeyPasswordUri = "key_password_uri64f57781",
                            TruststorePasswordUri = "truststore_password_uri9ee6f48f",
                            CrossRealmTrustRealm = "cross_realm_trust_realm9e0da70d",
                            CrossRealmTrustKdc = "cross_realm_trust_kdc82e36dae",
                            CrossRealmTrustAdminServer = "cross_realm_trust_admin_server512adf34",
                            CrossRealmTrustSharedPasswordUri = "cross_realm_trust_shared_password_uri3119f9f5",
                            KdcDbKeyUri = "kdc_db_key_uric7260229",
                            TgtLifetimeHours = -614775592,
                            Realm = "realmf77e4bb9",
                        },
                    },
                    LifecycleConfig = new LifecycleConfig
                    {
                        IdleDeleteTtl = new wkt::Duration
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        AutoDeleteTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        AutoDeleteTtl = new wkt::Duration
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        IdleStartTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                    },
                    AutoscalingConfig = new AutoscalingConfig
                    {
                        PolicyUri = "policy_uri58342d6e",
                    },
                    EndpointConfig = new EndpointConfig
                    {
                        HttpPorts =
                        {
                            {
                                "key8a0b6e3c",
                                "value60c16320"
                            },
                        },
                        EnableHttpPortAccess = false,
                    },
                },
                Status = new ClusterStatus
                {
                    State = ClusterStatus.Types.State.Unknown,
                    Detail = "detailb7a61d95",
                    StateStartTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    Substate = ClusterStatus.Types.Substate.Unspecified,
                },
                ClusterUuid = "cluster_uuid256bc378",
                StatusHistory =
                {
                    new ClusterStatus
                    {
                        State = ClusterStatus.Types.State.Unknown,
                        Detail = "detailb7a61d95",
                        StateStartTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        Substate = ClusterStatus.Types.Substate.Unspecified,
                    },
                },
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Metrics = new ClusterMetrics
                {
                    HdfsMetrics =
                    {
                        {
                            "key8a0b6e3c",
                            -5833447338835614944L
                        },
                    },
                    YarnMetrics =
                    {
                        {
                            "key8a0b6e3c",
                            -5833447338835614944L
                        },
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetCluster(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ClusterControllerClient client = new ClusterControllerClientImpl(mockGrpcClient.Object, null);
            Cluster response = client.GetCluster(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetClusterRequestObjectAsync()
        {
            moq::Mock<ClusterController.ClusterControllerClient> mockGrpcClient = new moq::Mock<ClusterController.ClusterControllerClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetClusterRequest request = new GetClusterRequest
            {
                ProjectId = "project_id43ad98b0",
                ClusterName = "cluster_name88432a5e",
                Region = "regionedb20d96",
            };
            Cluster expectedResponse = new Cluster
            {
                ProjectId = "project_id43ad98b0",
                ClusterName = "cluster_name88432a5e",
                Config = new ClusterConfig
                {
                    ConfigBucket = "config_bucketd15911b6",
                    TempBucket = "temp_bucketd48b432d",
                    GceClusterConfig = new GceClusterConfig
                    {
                        ZoneUri = "zone_uri4fe803bb",
                        NetworkUri = "network_uri199d3d75",
                        ServiceAccountScopes =
                        {
                            "service_account_scopesd4b7f658",
                        },
                        Tags = { "tags52c47ad5", },
                        Metadata =
                        {
                            {
                                "key8a0b6e3c",
                                "value60c16320"
                            },
                        },
                        SubnetworkUri = "subnetwork_uri7e1926ac",
                        InternalIpOnly = false,
                        ServiceAccount = "service_accounta3c1b923",
                        ReservationAffinity = new ReservationAffinity
                        {
                            ConsumeReservationType = ReservationAffinity.Types.Type.NoReservation,
                            Key = "key8a0b6e3c",
                            Values = { "valueseec79cf0", },
                        },
                    },
                    MasterConfig = new InstanceGroupConfig
                    {
                        NumInstances = 2024006720,
                        InstanceNames =
                        {
                            "instance_nameseaa0d94a",
                        },
                        ImageUri = "image_urieba3b1bc",
                        MachineTypeUri = "machine_type_uric6f28ef8",
                        DiskConfig = new DiskConfig
                        {
                            BootDiskSizeGb = 235820582,
                            NumLocalSsds = -1540065901,
                            BootDiskType = "boot_disk_typea1cf67c6",
                        },
                        IsPreemptible = false,
                        ManagedGroupConfig = new ManagedGroupConfig
                        {
                            InstanceTemplateName = "instance_template_name6cb940d2",
                            InstanceGroupManagerName = "instance_group_manager_name2b7c5b49",
                        },
                        Accelerators =
                        {
                            new AcceleratorConfig
                            {
                                AcceleratorTypeUri = "accelerator_type_uri5054fee7",
                                AcceleratorCount = -1461378825,
                            },
                        },
                        MinCpuPlatform = "min_cpu_platformf71ffa67",
                        Preemptibility = InstanceGroupConfig.Types.Preemptibility.NonPreemptible,
                    },
                    WorkerConfig = new InstanceGroupConfig
                    {
                        NumInstances = 2024006720,
                        InstanceNames =
                        {
                            "instance_nameseaa0d94a",
                        },
                        ImageUri = "image_urieba3b1bc",
                        MachineTypeUri = "machine_type_uric6f28ef8",
                        DiskConfig = new DiskConfig
                        {
                            BootDiskSizeGb = 235820582,
                            NumLocalSsds = -1540065901,
                            BootDiskType = "boot_disk_typea1cf67c6",
                        },
                        IsPreemptible = false,
                        ManagedGroupConfig = new ManagedGroupConfig
                        {
                            InstanceTemplateName = "instance_template_name6cb940d2",
                            InstanceGroupManagerName = "instance_group_manager_name2b7c5b49",
                        },
                        Accelerators =
                        {
                            new AcceleratorConfig
                            {
                                AcceleratorTypeUri = "accelerator_type_uri5054fee7",
                                AcceleratorCount = -1461378825,
                            },
                        },
                        MinCpuPlatform = "min_cpu_platformf71ffa67",
                        Preemptibility = InstanceGroupConfig.Types.Preemptibility.NonPreemptible,
                    },
                    InitializationActions =
                    {
                        new NodeInitializationAction
                        {
                            ExecutableFile = "executable_file8c147260",
                            ExecutionTimeout = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                        },
                    },
                    SecondaryWorkerConfig = new InstanceGroupConfig
                    {
                        NumInstances = 2024006720,
                        InstanceNames =
                        {
                            "instance_nameseaa0d94a",
                        },
                        ImageUri = "image_urieba3b1bc",
                        MachineTypeUri = "machine_type_uric6f28ef8",
                        DiskConfig = new DiskConfig
                        {
                            BootDiskSizeGb = 235820582,
                            NumLocalSsds = -1540065901,
                            BootDiskType = "boot_disk_typea1cf67c6",
                        },
                        IsPreemptible = false,
                        ManagedGroupConfig = new ManagedGroupConfig
                        {
                            InstanceTemplateName = "instance_template_name6cb940d2",
                            InstanceGroupManagerName = "instance_group_manager_name2b7c5b49",
                        },
                        Accelerators =
                        {
                            new AcceleratorConfig
                            {
                                AcceleratorTypeUri = "accelerator_type_uri5054fee7",
                                AcceleratorCount = -1461378825,
                            },
                        },
                        MinCpuPlatform = "min_cpu_platformf71ffa67",
                        Preemptibility = InstanceGroupConfig.Types.Preemptibility.NonPreemptible,
                    },
                    SoftwareConfig = new SoftwareConfig
                    {
                        ImageVersion = "image_version9e803c4e",
                        Properties =
                        {
                            {
                                "key8a0b6e3c",
                                "value60c16320"
                            },
                        },
                        OptionalComponents =
                        {
                            Component.Zeppelin,
                        },
                    },
                    EncryptionConfig = new EncryptionConfig
                    {
                        GcePdKmsKeyName = "gce_pd_kms_key_name720e24f6",
                    },
                    SecurityConfig = new SecurityConfig
                    {
                        KerberosConfig = new KerberosConfig
                        {
                            EnableKerberos = false,
                            RootPrincipalPasswordUri = "root_principal_password_uri2224718d",
                            KmsKeyUri = "kms_key_uri04b314da",
                            KeystoreUri = "keystore_uri6b0c93a3",
                            TruststoreUri = "truststore_uri533872fa",
                            KeystorePasswordUri = "keystore_password_uri8afdd2b5",
                            KeyPasswordUri = "key_password_uri64f57781",
                            TruststorePasswordUri = "truststore_password_uri9ee6f48f",
                            CrossRealmTrustRealm = "cross_realm_trust_realm9e0da70d",
                            CrossRealmTrustKdc = "cross_realm_trust_kdc82e36dae",
                            CrossRealmTrustAdminServer = "cross_realm_trust_admin_server512adf34",
                            CrossRealmTrustSharedPasswordUri = "cross_realm_trust_shared_password_uri3119f9f5",
                            KdcDbKeyUri = "kdc_db_key_uric7260229",
                            TgtLifetimeHours = -614775592,
                            Realm = "realmf77e4bb9",
                        },
                    },
                    LifecycleConfig = new LifecycleConfig
                    {
                        IdleDeleteTtl = new wkt::Duration
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        AutoDeleteTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        AutoDeleteTtl = new wkt::Duration
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        IdleStartTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                    },
                    AutoscalingConfig = new AutoscalingConfig
                    {
                        PolicyUri = "policy_uri58342d6e",
                    },
                    EndpointConfig = new EndpointConfig
                    {
                        HttpPorts =
                        {
                            {
                                "key8a0b6e3c",
                                "value60c16320"
                            },
                        },
                        EnableHttpPortAccess = false,
                    },
                },
                Status = new ClusterStatus
                {
                    State = ClusterStatus.Types.State.Unknown,
                    Detail = "detailb7a61d95",
                    StateStartTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    Substate = ClusterStatus.Types.Substate.Unspecified,
                },
                ClusterUuid = "cluster_uuid256bc378",
                StatusHistory =
                {
                    new ClusterStatus
                    {
                        State = ClusterStatus.Types.State.Unknown,
                        Detail = "detailb7a61d95",
                        StateStartTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        Substate = ClusterStatus.Types.Substate.Unspecified,
                    },
                },
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Metrics = new ClusterMetrics
                {
                    HdfsMetrics =
                    {
                        {
                            "key8a0b6e3c",
                            -5833447338835614944L
                        },
                    },
                    YarnMetrics =
                    {
                        {
                            "key8a0b6e3c",
                            -5833447338835614944L
                        },
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetClusterAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Cluster>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ClusterControllerClient client = new ClusterControllerClientImpl(mockGrpcClient.Object, null);
            Cluster responseCallSettings = await client.GetClusterAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Cluster responseCancellationToken = await client.GetClusterAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetCluster()
        {
            moq::Mock<ClusterController.ClusterControllerClient> mockGrpcClient = new moq::Mock<ClusterController.ClusterControllerClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetClusterRequest request = new GetClusterRequest
            {
                ProjectId = "project_id43ad98b0",
                ClusterName = "cluster_name88432a5e",
                Region = "regionedb20d96",
            };
            Cluster expectedResponse = new Cluster
            {
                ProjectId = "project_id43ad98b0",
                ClusterName = "cluster_name88432a5e",
                Config = new ClusterConfig
                {
                    ConfigBucket = "config_bucketd15911b6",
                    TempBucket = "temp_bucketd48b432d",
                    GceClusterConfig = new GceClusterConfig
                    {
                        ZoneUri = "zone_uri4fe803bb",
                        NetworkUri = "network_uri199d3d75",
                        ServiceAccountScopes =
                        {
                            "service_account_scopesd4b7f658",
                        },
                        Tags = { "tags52c47ad5", },
                        Metadata =
                        {
                            {
                                "key8a0b6e3c",
                                "value60c16320"
                            },
                        },
                        SubnetworkUri = "subnetwork_uri7e1926ac",
                        InternalIpOnly = false,
                        ServiceAccount = "service_accounta3c1b923",
                        ReservationAffinity = new ReservationAffinity
                        {
                            ConsumeReservationType = ReservationAffinity.Types.Type.NoReservation,
                            Key = "key8a0b6e3c",
                            Values = { "valueseec79cf0", },
                        },
                    },
                    MasterConfig = new InstanceGroupConfig
                    {
                        NumInstances = 2024006720,
                        InstanceNames =
                        {
                            "instance_nameseaa0d94a",
                        },
                        ImageUri = "image_urieba3b1bc",
                        MachineTypeUri = "machine_type_uric6f28ef8",
                        DiskConfig = new DiskConfig
                        {
                            BootDiskSizeGb = 235820582,
                            NumLocalSsds = -1540065901,
                            BootDiskType = "boot_disk_typea1cf67c6",
                        },
                        IsPreemptible = false,
                        ManagedGroupConfig = new ManagedGroupConfig
                        {
                            InstanceTemplateName = "instance_template_name6cb940d2",
                            InstanceGroupManagerName = "instance_group_manager_name2b7c5b49",
                        },
                        Accelerators =
                        {
                            new AcceleratorConfig
                            {
                                AcceleratorTypeUri = "accelerator_type_uri5054fee7",
                                AcceleratorCount = -1461378825,
                            },
                        },
                        MinCpuPlatform = "min_cpu_platformf71ffa67",
                        Preemptibility = InstanceGroupConfig.Types.Preemptibility.NonPreemptible,
                    },
                    WorkerConfig = new InstanceGroupConfig
                    {
                        NumInstances = 2024006720,
                        InstanceNames =
                        {
                            "instance_nameseaa0d94a",
                        },
                        ImageUri = "image_urieba3b1bc",
                        MachineTypeUri = "machine_type_uric6f28ef8",
                        DiskConfig = new DiskConfig
                        {
                            BootDiskSizeGb = 235820582,
                            NumLocalSsds = -1540065901,
                            BootDiskType = "boot_disk_typea1cf67c6",
                        },
                        IsPreemptible = false,
                        ManagedGroupConfig = new ManagedGroupConfig
                        {
                            InstanceTemplateName = "instance_template_name6cb940d2",
                            InstanceGroupManagerName = "instance_group_manager_name2b7c5b49",
                        },
                        Accelerators =
                        {
                            new AcceleratorConfig
                            {
                                AcceleratorTypeUri = "accelerator_type_uri5054fee7",
                                AcceleratorCount = -1461378825,
                            },
                        },
                        MinCpuPlatform = "min_cpu_platformf71ffa67",
                        Preemptibility = InstanceGroupConfig.Types.Preemptibility.NonPreemptible,
                    },
                    InitializationActions =
                    {
                        new NodeInitializationAction
                        {
                            ExecutableFile = "executable_file8c147260",
                            ExecutionTimeout = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                        },
                    },
                    SecondaryWorkerConfig = new InstanceGroupConfig
                    {
                        NumInstances = 2024006720,
                        InstanceNames =
                        {
                            "instance_nameseaa0d94a",
                        },
                        ImageUri = "image_urieba3b1bc",
                        MachineTypeUri = "machine_type_uric6f28ef8",
                        DiskConfig = new DiskConfig
                        {
                            BootDiskSizeGb = 235820582,
                            NumLocalSsds = -1540065901,
                            BootDiskType = "boot_disk_typea1cf67c6",
                        },
                        IsPreemptible = false,
                        ManagedGroupConfig = new ManagedGroupConfig
                        {
                            InstanceTemplateName = "instance_template_name6cb940d2",
                            InstanceGroupManagerName = "instance_group_manager_name2b7c5b49",
                        },
                        Accelerators =
                        {
                            new AcceleratorConfig
                            {
                                AcceleratorTypeUri = "accelerator_type_uri5054fee7",
                                AcceleratorCount = -1461378825,
                            },
                        },
                        MinCpuPlatform = "min_cpu_platformf71ffa67",
                        Preemptibility = InstanceGroupConfig.Types.Preemptibility.NonPreemptible,
                    },
                    SoftwareConfig = new SoftwareConfig
                    {
                        ImageVersion = "image_version9e803c4e",
                        Properties =
                        {
                            {
                                "key8a0b6e3c",
                                "value60c16320"
                            },
                        },
                        OptionalComponents =
                        {
                            Component.Zeppelin,
                        },
                    },
                    EncryptionConfig = new EncryptionConfig
                    {
                        GcePdKmsKeyName = "gce_pd_kms_key_name720e24f6",
                    },
                    SecurityConfig = new SecurityConfig
                    {
                        KerberosConfig = new KerberosConfig
                        {
                            EnableKerberos = false,
                            RootPrincipalPasswordUri = "root_principal_password_uri2224718d",
                            KmsKeyUri = "kms_key_uri04b314da",
                            KeystoreUri = "keystore_uri6b0c93a3",
                            TruststoreUri = "truststore_uri533872fa",
                            KeystorePasswordUri = "keystore_password_uri8afdd2b5",
                            KeyPasswordUri = "key_password_uri64f57781",
                            TruststorePasswordUri = "truststore_password_uri9ee6f48f",
                            CrossRealmTrustRealm = "cross_realm_trust_realm9e0da70d",
                            CrossRealmTrustKdc = "cross_realm_trust_kdc82e36dae",
                            CrossRealmTrustAdminServer = "cross_realm_trust_admin_server512adf34",
                            CrossRealmTrustSharedPasswordUri = "cross_realm_trust_shared_password_uri3119f9f5",
                            KdcDbKeyUri = "kdc_db_key_uric7260229",
                            TgtLifetimeHours = -614775592,
                            Realm = "realmf77e4bb9",
                        },
                    },
                    LifecycleConfig = new LifecycleConfig
                    {
                        IdleDeleteTtl = new wkt::Duration
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        AutoDeleteTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        AutoDeleteTtl = new wkt::Duration
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        IdleStartTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                    },
                    AutoscalingConfig = new AutoscalingConfig
                    {
                        PolicyUri = "policy_uri58342d6e",
                    },
                    EndpointConfig = new EndpointConfig
                    {
                        HttpPorts =
                        {
                            {
                                "key8a0b6e3c",
                                "value60c16320"
                            },
                        },
                        EnableHttpPortAccess = false,
                    },
                },
                Status = new ClusterStatus
                {
                    State = ClusterStatus.Types.State.Unknown,
                    Detail = "detailb7a61d95",
                    StateStartTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    Substate = ClusterStatus.Types.Substate.Unspecified,
                },
                ClusterUuid = "cluster_uuid256bc378",
                StatusHistory =
                {
                    new ClusterStatus
                    {
                        State = ClusterStatus.Types.State.Unknown,
                        Detail = "detailb7a61d95",
                        StateStartTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        Substate = ClusterStatus.Types.Substate.Unspecified,
                    },
                },
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Metrics = new ClusterMetrics
                {
                    HdfsMetrics =
                    {
                        {
                            "key8a0b6e3c",
                            -5833447338835614944L
                        },
                    },
                    YarnMetrics =
                    {
                        {
                            "key8a0b6e3c",
                            -5833447338835614944L
                        },
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetCluster(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ClusterControllerClient client = new ClusterControllerClientImpl(mockGrpcClient.Object, null);
            Cluster response = client.GetCluster(request.ProjectId, request.Region, request.ClusterName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetClusterAsync()
        {
            moq::Mock<ClusterController.ClusterControllerClient> mockGrpcClient = new moq::Mock<ClusterController.ClusterControllerClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetClusterRequest request = new GetClusterRequest
            {
                ProjectId = "project_id43ad98b0",
                ClusterName = "cluster_name88432a5e",
                Region = "regionedb20d96",
            };
            Cluster expectedResponse = new Cluster
            {
                ProjectId = "project_id43ad98b0",
                ClusterName = "cluster_name88432a5e",
                Config = new ClusterConfig
                {
                    ConfigBucket = "config_bucketd15911b6",
                    TempBucket = "temp_bucketd48b432d",
                    GceClusterConfig = new GceClusterConfig
                    {
                        ZoneUri = "zone_uri4fe803bb",
                        NetworkUri = "network_uri199d3d75",
                        ServiceAccountScopes =
                        {
                            "service_account_scopesd4b7f658",
                        },
                        Tags = { "tags52c47ad5", },
                        Metadata =
                        {
                            {
                                "key8a0b6e3c",
                                "value60c16320"
                            },
                        },
                        SubnetworkUri = "subnetwork_uri7e1926ac",
                        InternalIpOnly = false,
                        ServiceAccount = "service_accounta3c1b923",
                        ReservationAffinity = new ReservationAffinity
                        {
                            ConsumeReservationType = ReservationAffinity.Types.Type.NoReservation,
                            Key = "key8a0b6e3c",
                            Values = { "valueseec79cf0", },
                        },
                    },
                    MasterConfig = new InstanceGroupConfig
                    {
                        NumInstances = 2024006720,
                        InstanceNames =
                        {
                            "instance_nameseaa0d94a",
                        },
                        ImageUri = "image_urieba3b1bc",
                        MachineTypeUri = "machine_type_uric6f28ef8",
                        DiskConfig = new DiskConfig
                        {
                            BootDiskSizeGb = 235820582,
                            NumLocalSsds = -1540065901,
                            BootDiskType = "boot_disk_typea1cf67c6",
                        },
                        IsPreemptible = false,
                        ManagedGroupConfig = new ManagedGroupConfig
                        {
                            InstanceTemplateName = "instance_template_name6cb940d2",
                            InstanceGroupManagerName = "instance_group_manager_name2b7c5b49",
                        },
                        Accelerators =
                        {
                            new AcceleratorConfig
                            {
                                AcceleratorTypeUri = "accelerator_type_uri5054fee7",
                                AcceleratorCount = -1461378825,
                            },
                        },
                        MinCpuPlatform = "min_cpu_platformf71ffa67",
                        Preemptibility = InstanceGroupConfig.Types.Preemptibility.NonPreemptible,
                    },
                    WorkerConfig = new InstanceGroupConfig
                    {
                        NumInstances = 2024006720,
                        InstanceNames =
                        {
                            "instance_nameseaa0d94a",
                        },
                        ImageUri = "image_urieba3b1bc",
                        MachineTypeUri = "machine_type_uric6f28ef8",
                        DiskConfig = new DiskConfig
                        {
                            BootDiskSizeGb = 235820582,
                            NumLocalSsds = -1540065901,
                            BootDiskType = "boot_disk_typea1cf67c6",
                        },
                        IsPreemptible = false,
                        ManagedGroupConfig = new ManagedGroupConfig
                        {
                            InstanceTemplateName = "instance_template_name6cb940d2",
                            InstanceGroupManagerName = "instance_group_manager_name2b7c5b49",
                        },
                        Accelerators =
                        {
                            new AcceleratorConfig
                            {
                                AcceleratorTypeUri = "accelerator_type_uri5054fee7",
                                AcceleratorCount = -1461378825,
                            },
                        },
                        MinCpuPlatform = "min_cpu_platformf71ffa67",
                        Preemptibility = InstanceGroupConfig.Types.Preemptibility.NonPreemptible,
                    },
                    InitializationActions =
                    {
                        new NodeInitializationAction
                        {
                            ExecutableFile = "executable_file8c147260",
                            ExecutionTimeout = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                        },
                    },
                    SecondaryWorkerConfig = new InstanceGroupConfig
                    {
                        NumInstances = 2024006720,
                        InstanceNames =
                        {
                            "instance_nameseaa0d94a",
                        },
                        ImageUri = "image_urieba3b1bc",
                        MachineTypeUri = "machine_type_uric6f28ef8",
                        DiskConfig = new DiskConfig
                        {
                            BootDiskSizeGb = 235820582,
                            NumLocalSsds = -1540065901,
                            BootDiskType = "boot_disk_typea1cf67c6",
                        },
                        IsPreemptible = false,
                        ManagedGroupConfig = new ManagedGroupConfig
                        {
                            InstanceTemplateName = "instance_template_name6cb940d2",
                            InstanceGroupManagerName = "instance_group_manager_name2b7c5b49",
                        },
                        Accelerators =
                        {
                            new AcceleratorConfig
                            {
                                AcceleratorTypeUri = "accelerator_type_uri5054fee7",
                                AcceleratorCount = -1461378825,
                            },
                        },
                        MinCpuPlatform = "min_cpu_platformf71ffa67",
                        Preemptibility = InstanceGroupConfig.Types.Preemptibility.NonPreemptible,
                    },
                    SoftwareConfig = new SoftwareConfig
                    {
                        ImageVersion = "image_version9e803c4e",
                        Properties =
                        {
                            {
                                "key8a0b6e3c",
                                "value60c16320"
                            },
                        },
                        OptionalComponents =
                        {
                            Component.Zeppelin,
                        },
                    },
                    EncryptionConfig = new EncryptionConfig
                    {
                        GcePdKmsKeyName = "gce_pd_kms_key_name720e24f6",
                    },
                    SecurityConfig = new SecurityConfig
                    {
                        KerberosConfig = new KerberosConfig
                        {
                            EnableKerberos = false,
                            RootPrincipalPasswordUri = "root_principal_password_uri2224718d",
                            KmsKeyUri = "kms_key_uri04b314da",
                            KeystoreUri = "keystore_uri6b0c93a3",
                            TruststoreUri = "truststore_uri533872fa",
                            KeystorePasswordUri = "keystore_password_uri8afdd2b5",
                            KeyPasswordUri = "key_password_uri64f57781",
                            TruststorePasswordUri = "truststore_password_uri9ee6f48f",
                            CrossRealmTrustRealm = "cross_realm_trust_realm9e0da70d",
                            CrossRealmTrustKdc = "cross_realm_trust_kdc82e36dae",
                            CrossRealmTrustAdminServer = "cross_realm_trust_admin_server512adf34",
                            CrossRealmTrustSharedPasswordUri = "cross_realm_trust_shared_password_uri3119f9f5",
                            KdcDbKeyUri = "kdc_db_key_uric7260229",
                            TgtLifetimeHours = -614775592,
                            Realm = "realmf77e4bb9",
                        },
                    },
                    LifecycleConfig = new LifecycleConfig
                    {
                        IdleDeleteTtl = new wkt::Duration
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        AutoDeleteTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        AutoDeleteTtl = new wkt::Duration
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        IdleStartTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                    },
                    AutoscalingConfig = new AutoscalingConfig
                    {
                        PolicyUri = "policy_uri58342d6e",
                    },
                    EndpointConfig = new EndpointConfig
                    {
                        HttpPorts =
                        {
                            {
                                "key8a0b6e3c",
                                "value60c16320"
                            },
                        },
                        EnableHttpPortAccess = false,
                    },
                },
                Status = new ClusterStatus
                {
                    State = ClusterStatus.Types.State.Unknown,
                    Detail = "detailb7a61d95",
                    StateStartTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    Substate = ClusterStatus.Types.Substate.Unspecified,
                },
                ClusterUuid = "cluster_uuid256bc378",
                StatusHistory =
                {
                    new ClusterStatus
                    {
                        State = ClusterStatus.Types.State.Unknown,
                        Detail = "detailb7a61d95",
                        StateStartTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        Substate = ClusterStatus.Types.Substate.Unspecified,
                    },
                },
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Metrics = new ClusterMetrics
                {
                    HdfsMetrics =
                    {
                        {
                            "key8a0b6e3c",
                            -5833447338835614944L
                        },
                    },
                    YarnMetrics =
                    {
                        {
                            "key8a0b6e3c",
                            -5833447338835614944L
                        },
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetClusterAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Cluster>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ClusterControllerClient client = new ClusterControllerClientImpl(mockGrpcClient.Object, null);
            Cluster responseCallSettings = await client.GetClusterAsync(request.ProjectId, request.Region, request.ClusterName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Cluster responseCancellationToken = await client.GetClusterAsync(request.ProjectId, request.Region, request.ClusterName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
