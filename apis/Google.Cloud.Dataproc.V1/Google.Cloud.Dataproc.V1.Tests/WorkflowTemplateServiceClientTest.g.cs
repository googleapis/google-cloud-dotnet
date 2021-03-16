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
    public sealed class GeneratedWorkflowTemplateServiceClientTest
    {
        [xunit::FactAttribute]
        public void CreateWorkflowTemplateRequestObject()
        {
            moq::Mock<WorkflowTemplateService.WorkflowTemplateServiceClient> mockGrpcClient = new moq::Mock<WorkflowTemplateService.WorkflowTemplateServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateWorkflowTemplateRequest request = new CreateWorkflowTemplateRequest
            {
                ParentAsRegionName = RegionName.FromProjectRegion("[PROJECT]", "[REGION]"),
                Template = new WorkflowTemplate
                {
                    WorkflowTemplateName = WorkflowTemplateName.FromProjectRegionWorkflowTemplate("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]"),
                    Id = "id74b70bb8",
                    Version = 271578922,
                    CreateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    UpdateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    Labels =
                    {
                        {
                            "key8a0b6e3c",
                            "value60c16320"
                        },
                    },
                    Placement = new WorkflowTemplatePlacement
                    {
                        ManagedCluster = new ManagedCluster
                        {
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
                            Labels =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                        },
                        ClusterSelector = new ClusterSelector
                        {
                            Zone = "zone255f4ea8",
                            ClusterLabels =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                        },
                    },
                    Jobs =
                    {
                        new OrderedJob
                        {
                            StepId = "step_idd291f4be",
                            HadoopJob = new HadoopJob
                            {
                                MainJarFileUri = "main_jar_file_uri46ea7aa7",
                                MainClass = "main_classb0f4e864",
                                Args = { "args09af56a9", },
                                JarFileUris =
                                {
                                    "jar_file_urisfcd646b7",
                                },
                                FileUris =
                                {
                                    "file_urisbcc83e18",
                                },
                                ArchiveUris =
                                {
                                    "archive_uris5a747dda",
                                },
                                Properties =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                LoggingConfig = new LoggingConfig
                                {
                                    DriverLogLevels =
                                    {
                                        {
                                            "key8a0b6e3c",
                                            LoggingConfig.Types.Level.Debug
                                        },
                                    },
                                },
                            },
                            SparkJob = new SparkJob
                            {
                                MainJarFileUri = "main_jar_file_uri46ea7aa7",
                                MainClass = "main_classb0f4e864",
                                Args = { "args09af56a9", },
                                JarFileUris =
                                {
                                    "jar_file_urisfcd646b7",
                                },
                                FileUris =
                                {
                                    "file_urisbcc83e18",
                                },
                                ArchiveUris =
                                {
                                    "archive_uris5a747dda",
                                },
                                Properties =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                LoggingConfig = new LoggingConfig
                                {
                                    DriverLogLevels =
                                    {
                                        {
                                            "key8a0b6e3c",
                                            LoggingConfig.Types.Level.Debug
                                        },
                                    },
                                },
                            },
                            PysparkJob = new PySparkJob
                            {
                                MainPythonFileUri = "main_python_file_uri14aabff5",
                                Args = { "args09af56a9", },
                                PythonFileUris =
                                {
                                    "python_file_uris30483b38",
                                },
                                JarFileUris =
                                {
                                    "jar_file_urisfcd646b7",
                                },
                                FileUris =
                                {
                                    "file_urisbcc83e18",
                                },
                                ArchiveUris =
                                {
                                    "archive_uris5a747dda",
                                },
                                Properties =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                LoggingConfig = new LoggingConfig
                                {
                                    DriverLogLevels =
                                    {
                                        {
                                            "key8a0b6e3c",
                                            LoggingConfig.Types.Level.Debug
                                        },
                                    },
                                },
                            },
                            HiveJob = new HiveJob
                            {
                                QueryFileUri = "query_file_urid4d84faf",
                                QueryList = new QueryList
                                {
                                    Queries = { "queries42eba75d", },
                                },
                                ContinueOnFailure = false,
                                ScriptVariables =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                Properties =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                JarFileUris =
                                {
                                    "jar_file_urisfcd646b7",
                                },
                            },
                            PigJob = new PigJob
                            {
                                QueryFileUri = "query_file_urid4d84faf",
                                QueryList = new QueryList
                                {
                                    Queries = { "queries42eba75d", },
                                },
                                ContinueOnFailure = false,
                                ScriptVariables =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                Properties =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                JarFileUris =
                                {
                                    "jar_file_urisfcd646b7",
                                },
                                LoggingConfig = new LoggingConfig
                                {
                                    DriverLogLevels =
                                    {
                                        {
                                            "key8a0b6e3c",
                                            LoggingConfig.Types.Level.Debug
                                        },
                                    },
                                },
                            },
                            SparkSqlJob = new SparkSqlJob
                            {
                                QueryFileUri = "query_file_urid4d84faf",
                                QueryList = new QueryList
                                {
                                    Queries = { "queries42eba75d", },
                                },
                                ScriptVariables =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                Properties =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                LoggingConfig = new LoggingConfig
                                {
                                    DriverLogLevels =
                                    {
                                        {
                                            "key8a0b6e3c",
                                            LoggingConfig.Types.Level.Debug
                                        },
                                    },
                                },
                                JarFileUris =
                                {
                                    "jar_file_urisfcd646b7",
                                },
                            },
                            Labels =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            Scheduling = new JobScheduling
                            {
                                MaxFailuresPerHour = 238137428,
                            },
                            PrerequisiteStepIds =
                            {
                                "prerequisite_step_ids4753a371",
                            },
                            SparkRJob = new SparkRJob
                            {
                                MainRFileUri = "main_r_file_uri3c1a03d8",
                                Args = { "args09af56a9", },
                                FileUris =
                                {
                                    "file_urisbcc83e18",
                                },
                                ArchiveUris =
                                {
                                    "archive_uris5a747dda",
                                },
                                Properties =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                LoggingConfig = new LoggingConfig
                                {
                                    DriverLogLevels =
                                    {
                                        {
                                            "key8a0b6e3c",
                                            LoggingConfig.Types.Level.Debug
                                        },
                                    },
                                },
                            },
                            PrestoJob = new PrestoJob
                            {
                                QueryFileUri = "query_file_urid4d84faf",
                                QueryList = new QueryList
                                {
                                    Queries = { "queries42eba75d", },
                                },
                                ContinueOnFailure = false,
                                OutputFormat = "output_format020eca50",
                                ClientTags =
                                {
                                    "client_tags74c9d57e",
                                },
                                Properties =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                LoggingConfig = new LoggingConfig
                                {
                                    DriverLogLevels =
                                    {
                                        {
                                            "key8a0b6e3c",
                                            LoggingConfig.Types.Level.Debug
                                        },
                                    },
                                },
                            },
                        },
                    },
                    Parameters =
                    {
                        new TemplateParameter
                        {
                            Name = "name1c9368b0",
                            Fields = { "fieldsd76e5bd0", },
                            Description = "description2cf9da67",
                            Validation = new ParameterValidation
                            {
                                Regex = new RegexValidation
                                {
                                    Regexes = { "regexes5cb111ce", },
                                },
                                Values = new ValueValidation
                                {
                                    Values = { "valueseec79cf0", },
                                },
                            },
                        },
                    },
                },
            };
            WorkflowTemplate expectedResponse = new WorkflowTemplate
            {
                WorkflowTemplateName = WorkflowTemplateName.FromProjectRegionWorkflowTemplate("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]"),
                Id = "id74b70bb8",
                Version = 271578922,
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                UpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Placement = new WorkflowTemplatePlacement
                {
                    ManagedCluster = new ManagedCluster
                    {
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
                        Labels =
                        {
                            {
                                "key8a0b6e3c",
                                "value60c16320"
                            },
                        },
                    },
                    ClusterSelector = new ClusterSelector
                    {
                        Zone = "zone255f4ea8",
                        ClusterLabels =
                        {
                            {
                                "key8a0b6e3c",
                                "value60c16320"
                            },
                        },
                    },
                },
                Jobs =
                {
                    new OrderedJob
                    {
                        StepId = "step_idd291f4be",
                        HadoopJob = new HadoopJob
                        {
                            MainJarFileUri = "main_jar_file_uri46ea7aa7",
                            MainClass = "main_classb0f4e864",
                            Args = { "args09af56a9", },
                            JarFileUris =
                            {
                                "jar_file_urisfcd646b7",
                            },
                            FileUris =
                            {
                                "file_urisbcc83e18",
                            },
                            ArchiveUris =
                            {
                                "archive_uris5a747dda",
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                        },
                        SparkJob = new SparkJob
                        {
                            MainJarFileUri = "main_jar_file_uri46ea7aa7",
                            MainClass = "main_classb0f4e864",
                            Args = { "args09af56a9", },
                            JarFileUris =
                            {
                                "jar_file_urisfcd646b7",
                            },
                            FileUris =
                            {
                                "file_urisbcc83e18",
                            },
                            ArchiveUris =
                            {
                                "archive_uris5a747dda",
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                        },
                        PysparkJob = new PySparkJob
                        {
                            MainPythonFileUri = "main_python_file_uri14aabff5",
                            Args = { "args09af56a9", },
                            PythonFileUris =
                            {
                                "python_file_uris30483b38",
                            },
                            JarFileUris =
                            {
                                "jar_file_urisfcd646b7",
                            },
                            FileUris =
                            {
                                "file_urisbcc83e18",
                            },
                            ArchiveUris =
                            {
                                "archive_uris5a747dda",
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                        },
                        HiveJob = new HiveJob
                        {
                            QueryFileUri = "query_file_urid4d84faf",
                            QueryList = new QueryList
                            {
                                Queries = { "queries42eba75d", },
                            },
                            ContinueOnFailure = false,
                            ScriptVariables =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            JarFileUris =
                            {
                                "jar_file_urisfcd646b7",
                            },
                        },
                        PigJob = new PigJob
                        {
                            QueryFileUri = "query_file_urid4d84faf",
                            QueryList = new QueryList
                            {
                                Queries = { "queries42eba75d", },
                            },
                            ContinueOnFailure = false,
                            ScriptVariables =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            JarFileUris =
                            {
                                "jar_file_urisfcd646b7",
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                        },
                        SparkSqlJob = new SparkSqlJob
                        {
                            QueryFileUri = "query_file_urid4d84faf",
                            QueryList = new QueryList
                            {
                                Queries = { "queries42eba75d", },
                            },
                            ScriptVariables =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                            JarFileUris =
                            {
                                "jar_file_urisfcd646b7",
                            },
                        },
                        Labels =
                        {
                            {
                                "key8a0b6e3c",
                                "value60c16320"
                            },
                        },
                        Scheduling = new JobScheduling
                        {
                            MaxFailuresPerHour = 238137428,
                        },
                        PrerequisiteStepIds =
                        {
                            "prerequisite_step_ids4753a371",
                        },
                        SparkRJob = new SparkRJob
                        {
                            MainRFileUri = "main_r_file_uri3c1a03d8",
                            Args = { "args09af56a9", },
                            FileUris =
                            {
                                "file_urisbcc83e18",
                            },
                            ArchiveUris =
                            {
                                "archive_uris5a747dda",
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                        },
                        PrestoJob = new PrestoJob
                        {
                            QueryFileUri = "query_file_urid4d84faf",
                            QueryList = new QueryList
                            {
                                Queries = { "queries42eba75d", },
                            },
                            ContinueOnFailure = false,
                            OutputFormat = "output_format020eca50",
                            ClientTags =
                            {
                                "client_tags74c9d57e",
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                        },
                    },
                },
                Parameters =
                {
                    new TemplateParameter
                    {
                        Name = "name1c9368b0",
                        Fields = { "fieldsd76e5bd0", },
                        Description = "description2cf9da67",
                        Validation = new ParameterValidation
                        {
                            Regex = new RegexValidation
                            {
                                Regexes = { "regexes5cb111ce", },
                            },
                            Values = new ValueValidation
                            {
                                Values = { "valueseec79cf0", },
                            },
                        },
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CreateWorkflowTemplate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            WorkflowTemplateServiceClient client = new WorkflowTemplateServiceClientImpl(mockGrpcClient.Object, null);
            WorkflowTemplate response = client.CreateWorkflowTemplate(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateWorkflowTemplateRequestObjectAsync()
        {
            moq::Mock<WorkflowTemplateService.WorkflowTemplateServiceClient> mockGrpcClient = new moq::Mock<WorkflowTemplateService.WorkflowTemplateServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateWorkflowTemplateRequest request = new CreateWorkflowTemplateRequest
            {
                ParentAsRegionName = RegionName.FromProjectRegion("[PROJECT]", "[REGION]"),
                Template = new WorkflowTemplate
                {
                    WorkflowTemplateName = WorkflowTemplateName.FromProjectRegionWorkflowTemplate("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]"),
                    Id = "id74b70bb8",
                    Version = 271578922,
                    CreateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    UpdateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    Labels =
                    {
                        {
                            "key8a0b6e3c",
                            "value60c16320"
                        },
                    },
                    Placement = new WorkflowTemplatePlacement
                    {
                        ManagedCluster = new ManagedCluster
                        {
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
                            Labels =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                        },
                        ClusterSelector = new ClusterSelector
                        {
                            Zone = "zone255f4ea8",
                            ClusterLabels =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                        },
                    },
                    Jobs =
                    {
                        new OrderedJob
                        {
                            StepId = "step_idd291f4be",
                            HadoopJob = new HadoopJob
                            {
                                MainJarFileUri = "main_jar_file_uri46ea7aa7",
                                MainClass = "main_classb0f4e864",
                                Args = { "args09af56a9", },
                                JarFileUris =
                                {
                                    "jar_file_urisfcd646b7",
                                },
                                FileUris =
                                {
                                    "file_urisbcc83e18",
                                },
                                ArchiveUris =
                                {
                                    "archive_uris5a747dda",
                                },
                                Properties =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                LoggingConfig = new LoggingConfig
                                {
                                    DriverLogLevels =
                                    {
                                        {
                                            "key8a0b6e3c",
                                            LoggingConfig.Types.Level.Debug
                                        },
                                    },
                                },
                            },
                            SparkJob = new SparkJob
                            {
                                MainJarFileUri = "main_jar_file_uri46ea7aa7",
                                MainClass = "main_classb0f4e864",
                                Args = { "args09af56a9", },
                                JarFileUris =
                                {
                                    "jar_file_urisfcd646b7",
                                },
                                FileUris =
                                {
                                    "file_urisbcc83e18",
                                },
                                ArchiveUris =
                                {
                                    "archive_uris5a747dda",
                                },
                                Properties =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                LoggingConfig = new LoggingConfig
                                {
                                    DriverLogLevels =
                                    {
                                        {
                                            "key8a0b6e3c",
                                            LoggingConfig.Types.Level.Debug
                                        },
                                    },
                                },
                            },
                            PysparkJob = new PySparkJob
                            {
                                MainPythonFileUri = "main_python_file_uri14aabff5",
                                Args = { "args09af56a9", },
                                PythonFileUris =
                                {
                                    "python_file_uris30483b38",
                                },
                                JarFileUris =
                                {
                                    "jar_file_urisfcd646b7",
                                },
                                FileUris =
                                {
                                    "file_urisbcc83e18",
                                },
                                ArchiveUris =
                                {
                                    "archive_uris5a747dda",
                                },
                                Properties =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                LoggingConfig = new LoggingConfig
                                {
                                    DriverLogLevels =
                                    {
                                        {
                                            "key8a0b6e3c",
                                            LoggingConfig.Types.Level.Debug
                                        },
                                    },
                                },
                            },
                            HiveJob = new HiveJob
                            {
                                QueryFileUri = "query_file_urid4d84faf",
                                QueryList = new QueryList
                                {
                                    Queries = { "queries42eba75d", },
                                },
                                ContinueOnFailure = false,
                                ScriptVariables =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                Properties =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                JarFileUris =
                                {
                                    "jar_file_urisfcd646b7",
                                },
                            },
                            PigJob = new PigJob
                            {
                                QueryFileUri = "query_file_urid4d84faf",
                                QueryList = new QueryList
                                {
                                    Queries = { "queries42eba75d", },
                                },
                                ContinueOnFailure = false,
                                ScriptVariables =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                Properties =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                JarFileUris =
                                {
                                    "jar_file_urisfcd646b7",
                                },
                                LoggingConfig = new LoggingConfig
                                {
                                    DriverLogLevels =
                                    {
                                        {
                                            "key8a0b6e3c",
                                            LoggingConfig.Types.Level.Debug
                                        },
                                    },
                                },
                            },
                            SparkSqlJob = new SparkSqlJob
                            {
                                QueryFileUri = "query_file_urid4d84faf",
                                QueryList = new QueryList
                                {
                                    Queries = { "queries42eba75d", },
                                },
                                ScriptVariables =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                Properties =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                LoggingConfig = new LoggingConfig
                                {
                                    DriverLogLevels =
                                    {
                                        {
                                            "key8a0b6e3c",
                                            LoggingConfig.Types.Level.Debug
                                        },
                                    },
                                },
                                JarFileUris =
                                {
                                    "jar_file_urisfcd646b7",
                                },
                            },
                            Labels =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            Scheduling = new JobScheduling
                            {
                                MaxFailuresPerHour = 238137428,
                            },
                            PrerequisiteStepIds =
                            {
                                "prerequisite_step_ids4753a371",
                            },
                            SparkRJob = new SparkRJob
                            {
                                MainRFileUri = "main_r_file_uri3c1a03d8",
                                Args = { "args09af56a9", },
                                FileUris =
                                {
                                    "file_urisbcc83e18",
                                },
                                ArchiveUris =
                                {
                                    "archive_uris5a747dda",
                                },
                                Properties =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                LoggingConfig = new LoggingConfig
                                {
                                    DriverLogLevels =
                                    {
                                        {
                                            "key8a0b6e3c",
                                            LoggingConfig.Types.Level.Debug
                                        },
                                    },
                                },
                            },
                            PrestoJob = new PrestoJob
                            {
                                QueryFileUri = "query_file_urid4d84faf",
                                QueryList = new QueryList
                                {
                                    Queries = { "queries42eba75d", },
                                },
                                ContinueOnFailure = false,
                                OutputFormat = "output_format020eca50",
                                ClientTags =
                                {
                                    "client_tags74c9d57e",
                                },
                                Properties =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                LoggingConfig = new LoggingConfig
                                {
                                    DriverLogLevels =
                                    {
                                        {
                                            "key8a0b6e3c",
                                            LoggingConfig.Types.Level.Debug
                                        },
                                    },
                                },
                            },
                        },
                    },
                    Parameters =
                    {
                        new TemplateParameter
                        {
                            Name = "name1c9368b0",
                            Fields = { "fieldsd76e5bd0", },
                            Description = "description2cf9da67",
                            Validation = new ParameterValidation
                            {
                                Regex = new RegexValidation
                                {
                                    Regexes = { "regexes5cb111ce", },
                                },
                                Values = new ValueValidation
                                {
                                    Values = { "valueseec79cf0", },
                                },
                            },
                        },
                    },
                },
            };
            WorkflowTemplate expectedResponse = new WorkflowTemplate
            {
                WorkflowTemplateName = WorkflowTemplateName.FromProjectRegionWorkflowTemplate("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]"),
                Id = "id74b70bb8",
                Version = 271578922,
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                UpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Placement = new WorkflowTemplatePlacement
                {
                    ManagedCluster = new ManagedCluster
                    {
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
                        Labels =
                        {
                            {
                                "key8a0b6e3c",
                                "value60c16320"
                            },
                        },
                    },
                    ClusterSelector = new ClusterSelector
                    {
                        Zone = "zone255f4ea8",
                        ClusterLabels =
                        {
                            {
                                "key8a0b6e3c",
                                "value60c16320"
                            },
                        },
                    },
                },
                Jobs =
                {
                    new OrderedJob
                    {
                        StepId = "step_idd291f4be",
                        HadoopJob = new HadoopJob
                        {
                            MainJarFileUri = "main_jar_file_uri46ea7aa7",
                            MainClass = "main_classb0f4e864",
                            Args = { "args09af56a9", },
                            JarFileUris =
                            {
                                "jar_file_urisfcd646b7",
                            },
                            FileUris =
                            {
                                "file_urisbcc83e18",
                            },
                            ArchiveUris =
                            {
                                "archive_uris5a747dda",
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                        },
                        SparkJob = new SparkJob
                        {
                            MainJarFileUri = "main_jar_file_uri46ea7aa7",
                            MainClass = "main_classb0f4e864",
                            Args = { "args09af56a9", },
                            JarFileUris =
                            {
                                "jar_file_urisfcd646b7",
                            },
                            FileUris =
                            {
                                "file_urisbcc83e18",
                            },
                            ArchiveUris =
                            {
                                "archive_uris5a747dda",
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                        },
                        PysparkJob = new PySparkJob
                        {
                            MainPythonFileUri = "main_python_file_uri14aabff5",
                            Args = { "args09af56a9", },
                            PythonFileUris =
                            {
                                "python_file_uris30483b38",
                            },
                            JarFileUris =
                            {
                                "jar_file_urisfcd646b7",
                            },
                            FileUris =
                            {
                                "file_urisbcc83e18",
                            },
                            ArchiveUris =
                            {
                                "archive_uris5a747dda",
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                        },
                        HiveJob = new HiveJob
                        {
                            QueryFileUri = "query_file_urid4d84faf",
                            QueryList = new QueryList
                            {
                                Queries = { "queries42eba75d", },
                            },
                            ContinueOnFailure = false,
                            ScriptVariables =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            JarFileUris =
                            {
                                "jar_file_urisfcd646b7",
                            },
                        },
                        PigJob = new PigJob
                        {
                            QueryFileUri = "query_file_urid4d84faf",
                            QueryList = new QueryList
                            {
                                Queries = { "queries42eba75d", },
                            },
                            ContinueOnFailure = false,
                            ScriptVariables =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            JarFileUris =
                            {
                                "jar_file_urisfcd646b7",
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                        },
                        SparkSqlJob = new SparkSqlJob
                        {
                            QueryFileUri = "query_file_urid4d84faf",
                            QueryList = new QueryList
                            {
                                Queries = { "queries42eba75d", },
                            },
                            ScriptVariables =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                            JarFileUris =
                            {
                                "jar_file_urisfcd646b7",
                            },
                        },
                        Labels =
                        {
                            {
                                "key8a0b6e3c",
                                "value60c16320"
                            },
                        },
                        Scheduling = new JobScheduling
                        {
                            MaxFailuresPerHour = 238137428,
                        },
                        PrerequisiteStepIds =
                        {
                            "prerequisite_step_ids4753a371",
                        },
                        SparkRJob = new SparkRJob
                        {
                            MainRFileUri = "main_r_file_uri3c1a03d8",
                            Args = { "args09af56a9", },
                            FileUris =
                            {
                                "file_urisbcc83e18",
                            },
                            ArchiveUris =
                            {
                                "archive_uris5a747dda",
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                        },
                        PrestoJob = new PrestoJob
                        {
                            QueryFileUri = "query_file_urid4d84faf",
                            QueryList = new QueryList
                            {
                                Queries = { "queries42eba75d", },
                            },
                            ContinueOnFailure = false,
                            OutputFormat = "output_format020eca50",
                            ClientTags =
                            {
                                "client_tags74c9d57e",
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                        },
                    },
                },
                Parameters =
                {
                    new TemplateParameter
                    {
                        Name = "name1c9368b0",
                        Fields = { "fieldsd76e5bd0", },
                        Description = "description2cf9da67",
                        Validation = new ParameterValidation
                        {
                            Regex = new RegexValidation
                            {
                                Regexes = { "regexes5cb111ce", },
                            },
                            Values = new ValueValidation
                            {
                                Values = { "valueseec79cf0", },
                            },
                        },
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CreateWorkflowTemplateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<WorkflowTemplate>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            WorkflowTemplateServiceClient client = new WorkflowTemplateServiceClientImpl(mockGrpcClient.Object, null);
            WorkflowTemplate responseCallSettings = await client.CreateWorkflowTemplateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            WorkflowTemplate responseCancellationToken = await client.CreateWorkflowTemplateAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateWorkflowTemplate()
        {
            moq::Mock<WorkflowTemplateService.WorkflowTemplateServiceClient> mockGrpcClient = new moq::Mock<WorkflowTemplateService.WorkflowTemplateServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateWorkflowTemplateRequest request = new CreateWorkflowTemplateRequest
            {
                ParentAsRegionName = RegionName.FromProjectRegion("[PROJECT]", "[REGION]"),
                Template = new WorkflowTemplate
                {
                    WorkflowTemplateName = WorkflowTemplateName.FromProjectRegionWorkflowTemplate("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]"),
                    Id = "id74b70bb8",
                    Version = 271578922,
                    CreateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    UpdateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    Labels =
                    {
                        {
                            "key8a0b6e3c",
                            "value60c16320"
                        },
                    },
                    Placement = new WorkflowTemplatePlacement
                    {
                        ManagedCluster = new ManagedCluster
                        {
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
                            Labels =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                        },
                        ClusterSelector = new ClusterSelector
                        {
                            Zone = "zone255f4ea8",
                            ClusterLabels =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                        },
                    },
                    Jobs =
                    {
                        new OrderedJob
                        {
                            StepId = "step_idd291f4be",
                            HadoopJob = new HadoopJob
                            {
                                MainJarFileUri = "main_jar_file_uri46ea7aa7",
                                MainClass = "main_classb0f4e864",
                                Args = { "args09af56a9", },
                                JarFileUris =
                                {
                                    "jar_file_urisfcd646b7",
                                },
                                FileUris =
                                {
                                    "file_urisbcc83e18",
                                },
                                ArchiveUris =
                                {
                                    "archive_uris5a747dda",
                                },
                                Properties =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                LoggingConfig = new LoggingConfig
                                {
                                    DriverLogLevels =
                                    {
                                        {
                                            "key8a0b6e3c",
                                            LoggingConfig.Types.Level.Debug
                                        },
                                    },
                                },
                            },
                            SparkJob = new SparkJob
                            {
                                MainJarFileUri = "main_jar_file_uri46ea7aa7",
                                MainClass = "main_classb0f4e864",
                                Args = { "args09af56a9", },
                                JarFileUris =
                                {
                                    "jar_file_urisfcd646b7",
                                },
                                FileUris =
                                {
                                    "file_urisbcc83e18",
                                },
                                ArchiveUris =
                                {
                                    "archive_uris5a747dda",
                                },
                                Properties =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                LoggingConfig = new LoggingConfig
                                {
                                    DriverLogLevels =
                                    {
                                        {
                                            "key8a0b6e3c",
                                            LoggingConfig.Types.Level.Debug
                                        },
                                    },
                                },
                            },
                            PysparkJob = new PySparkJob
                            {
                                MainPythonFileUri = "main_python_file_uri14aabff5",
                                Args = { "args09af56a9", },
                                PythonFileUris =
                                {
                                    "python_file_uris30483b38",
                                },
                                JarFileUris =
                                {
                                    "jar_file_urisfcd646b7",
                                },
                                FileUris =
                                {
                                    "file_urisbcc83e18",
                                },
                                ArchiveUris =
                                {
                                    "archive_uris5a747dda",
                                },
                                Properties =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                LoggingConfig = new LoggingConfig
                                {
                                    DriverLogLevels =
                                    {
                                        {
                                            "key8a0b6e3c",
                                            LoggingConfig.Types.Level.Debug
                                        },
                                    },
                                },
                            },
                            HiveJob = new HiveJob
                            {
                                QueryFileUri = "query_file_urid4d84faf",
                                QueryList = new QueryList
                                {
                                    Queries = { "queries42eba75d", },
                                },
                                ContinueOnFailure = false,
                                ScriptVariables =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                Properties =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                JarFileUris =
                                {
                                    "jar_file_urisfcd646b7",
                                },
                            },
                            PigJob = new PigJob
                            {
                                QueryFileUri = "query_file_urid4d84faf",
                                QueryList = new QueryList
                                {
                                    Queries = { "queries42eba75d", },
                                },
                                ContinueOnFailure = false,
                                ScriptVariables =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                Properties =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                JarFileUris =
                                {
                                    "jar_file_urisfcd646b7",
                                },
                                LoggingConfig = new LoggingConfig
                                {
                                    DriverLogLevels =
                                    {
                                        {
                                            "key8a0b6e3c",
                                            LoggingConfig.Types.Level.Debug
                                        },
                                    },
                                },
                            },
                            SparkSqlJob = new SparkSqlJob
                            {
                                QueryFileUri = "query_file_urid4d84faf",
                                QueryList = new QueryList
                                {
                                    Queries = { "queries42eba75d", },
                                },
                                ScriptVariables =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                Properties =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                LoggingConfig = new LoggingConfig
                                {
                                    DriverLogLevels =
                                    {
                                        {
                                            "key8a0b6e3c",
                                            LoggingConfig.Types.Level.Debug
                                        },
                                    },
                                },
                                JarFileUris =
                                {
                                    "jar_file_urisfcd646b7",
                                },
                            },
                            Labels =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            Scheduling = new JobScheduling
                            {
                                MaxFailuresPerHour = 238137428,
                            },
                            PrerequisiteStepIds =
                            {
                                "prerequisite_step_ids4753a371",
                            },
                            SparkRJob = new SparkRJob
                            {
                                MainRFileUri = "main_r_file_uri3c1a03d8",
                                Args = { "args09af56a9", },
                                FileUris =
                                {
                                    "file_urisbcc83e18",
                                },
                                ArchiveUris =
                                {
                                    "archive_uris5a747dda",
                                },
                                Properties =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                LoggingConfig = new LoggingConfig
                                {
                                    DriverLogLevels =
                                    {
                                        {
                                            "key8a0b6e3c",
                                            LoggingConfig.Types.Level.Debug
                                        },
                                    },
                                },
                            },
                            PrestoJob = new PrestoJob
                            {
                                QueryFileUri = "query_file_urid4d84faf",
                                QueryList = new QueryList
                                {
                                    Queries = { "queries42eba75d", },
                                },
                                ContinueOnFailure = false,
                                OutputFormat = "output_format020eca50",
                                ClientTags =
                                {
                                    "client_tags74c9d57e",
                                },
                                Properties =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                LoggingConfig = new LoggingConfig
                                {
                                    DriverLogLevels =
                                    {
                                        {
                                            "key8a0b6e3c",
                                            LoggingConfig.Types.Level.Debug
                                        },
                                    },
                                },
                            },
                        },
                    },
                    Parameters =
                    {
                        new TemplateParameter
                        {
                            Name = "name1c9368b0",
                            Fields = { "fieldsd76e5bd0", },
                            Description = "description2cf9da67",
                            Validation = new ParameterValidation
                            {
                                Regex = new RegexValidation
                                {
                                    Regexes = { "regexes5cb111ce", },
                                },
                                Values = new ValueValidation
                                {
                                    Values = { "valueseec79cf0", },
                                },
                            },
                        },
                    },
                },
            };
            WorkflowTemplate expectedResponse = new WorkflowTemplate
            {
                WorkflowTemplateName = WorkflowTemplateName.FromProjectRegionWorkflowTemplate("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]"),
                Id = "id74b70bb8",
                Version = 271578922,
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                UpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Placement = new WorkflowTemplatePlacement
                {
                    ManagedCluster = new ManagedCluster
                    {
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
                        Labels =
                        {
                            {
                                "key8a0b6e3c",
                                "value60c16320"
                            },
                        },
                    },
                    ClusterSelector = new ClusterSelector
                    {
                        Zone = "zone255f4ea8",
                        ClusterLabels =
                        {
                            {
                                "key8a0b6e3c",
                                "value60c16320"
                            },
                        },
                    },
                },
                Jobs =
                {
                    new OrderedJob
                    {
                        StepId = "step_idd291f4be",
                        HadoopJob = new HadoopJob
                        {
                            MainJarFileUri = "main_jar_file_uri46ea7aa7",
                            MainClass = "main_classb0f4e864",
                            Args = { "args09af56a9", },
                            JarFileUris =
                            {
                                "jar_file_urisfcd646b7",
                            },
                            FileUris =
                            {
                                "file_urisbcc83e18",
                            },
                            ArchiveUris =
                            {
                                "archive_uris5a747dda",
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                        },
                        SparkJob = new SparkJob
                        {
                            MainJarFileUri = "main_jar_file_uri46ea7aa7",
                            MainClass = "main_classb0f4e864",
                            Args = { "args09af56a9", },
                            JarFileUris =
                            {
                                "jar_file_urisfcd646b7",
                            },
                            FileUris =
                            {
                                "file_urisbcc83e18",
                            },
                            ArchiveUris =
                            {
                                "archive_uris5a747dda",
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                        },
                        PysparkJob = new PySparkJob
                        {
                            MainPythonFileUri = "main_python_file_uri14aabff5",
                            Args = { "args09af56a9", },
                            PythonFileUris =
                            {
                                "python_file_uris30483b38",
                            },
                            JarFileUris =
                            {
                                "jar_file_urisfcd646b7",
                            },
                            FileUris =
                            {
                                "file_urisbcc83e18",
                            },
                            ArchiveUris =
                            {
                                "archive_uris5a747dda",
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                        },
                        HiveJob = new HiveJob
                        {
                            QueryFileUri = "query_file_urid4d84faf",
                            QueryList = new QueryList
                            {
                                Queries = { "queries42eba75d", },
                            },
                            ContinueOnFailure = false,
                            ScriptVariables =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            JarFileUris =
                            {
                                "jar_file_urisfcd646b7",
                            },
                        },
                        PigJob = new PigJob
                        {
                            QueryFileUri = "query_file_urid4d84faf",
                            QueryList = new QueryList
                            {
                                Queries = { "queries42eba75d", },
                            },
                            ContinueOnFailure = false,
                            ScriptVariables =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            JarFileUris =
                            {
                                "jar_file_urisfcd646b7",
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                        },
                        SparkSqlJob = new SparkSqlJob
                        {
                            QueryFileUri = "query_file_urid4d84faf",
                            QueryList = new QueryList
                            {
                                Queries = { "queries42eba75d", },
                            },
                            ScriptVariables =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                            JarFileUris =
                            {
                                "jar_file_urisfcd646b7",
                            },
                        },
                        Labels =
                        {
                            {
                                "key8a0b6e3c",
                                "value60c16320"
                            },
                        },
                        Scheduling = new JobScheduling
                        {
                            MaxFailuresPerHour = 238137428,
                        },
                        PrerequisiteStepIds =
                        {
                            "prerequisite_step_ids4753a371",
                        },
                        SparkRJob = new SparkRJob
                        {
                            MainRFileUri = "main_r_file_uri3c1a03d8",
                            Args = { "args09af56a9", },
                            FileUris =
                            {
                                "file_urisbcc83e18",
                            },
                            ArchiveUris =
                            {
                                "archive_uris5a747dda",
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                        },
                        PrestoJob = new PrestoJob
                        {
                            QueryFileUri = "query_file_urid4d84faf",
                            QueryList = new QueryList
                            {
                                Queries = { "queries42eba75d", },
                            },
                            ContinueOnFailure = false,
                            OutputFormat = "output_format020eca50",
                            ClientTags =
                            {
                                "client_tags74c9d57e",
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                        },
                    },
                },
                Parameters =
                {
                    new TemplateParameter
                    {
                        Name = "name1c9368b0",
                        Fields = { "fieldsd76e5bd0", },
                        Description = "description2cf9da67",
                        Validation = new ParameterValidation
                        {
                            Regex = new RegexValidation
                            {
                                Regexes = { "regexes5cb111ce", },
                            },
                            Values = new ValueValidation
                            {
                                Values = { "valueseec79cf0", },
                            },
                        },
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CreateWorkflowTemplate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            WorkflowTemplateServiceClient client = new WorkflowTemplateServiceClientImpl(mockGrpcClient.Object, null);
            WorkflowTemplate response = client.CreateWorkflowTemplate(request.Parent, request.Template);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateWorkflowTemplateAsync()
        {
            moq::Mock<WorkflowTemplateService.WorkflowTemplateServiceClient> mockGrpcClient = new moq::Mock<WorkflowTemplateService.WorkflowTemplateServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateWorkflowTemplateRequest request = new CreateWorkflowTemplateRequest
            {
                ParentAsRegionName = RegionName.FromProjectRegion("[PROJECT]", "[REGION]"),
                Template = new WorkflowTemplate
                {
                    WorkflowTemplateName = WorkflowTemplateName.FromProjectRegionWorkflowTemplate("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]"),
                    Id = "id74b70bb8",
                    Version = 271578922,
                    CreateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    UpdateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    Labels =
                    {
                        {
                            "key8a0b6e3c",
                            "value60c16320"
                        },
                    },
                    Placement = new WorkflowTemplatePlacement
                    {
                        ManagedCluster = new ManagedCluster
                        {
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
                            Labels =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                        },
                        ClusterSelector = new ClusterSelector
                        {
                            Zone = "zone255f4ea8",
                            ClusterLabels =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                        },
                    },
                    Jobs =
                    {
                        new OrderedJob
                        {
                            StepId = "step_idd291f4be",
                            HadoopJob = new HadoopJob
                            {
                                MainJarFileUri = "main_jar_file_uri46ea7aa7",
                                MainClass = "main_classb0f4e864",
                                Args = { "args09af56a9", },
                                JarFileUris =
                                {
                                    "jar_file_urisfcd646b7",
                                },
                                FileUris =
                                {
                                    "file_urisbcc83e18",
                                },
                                ArchiveUris =
                                {
                                    "archive_uris5a747dda",
                                },
                                Properties =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                LoggingConfig = new LoggingConfig
                                {
                                    DriverLogLevels =
                                    {
                                        {
                                            "key8a0b6e3c",
                                            LoggingConfig.Types.Level.Debug
                                        },
                                    },
                                },
                            },
                            SparkJob = new SparkJob
                            {
                                MainJarFileUri = "main_jar_file_uri46ea7aa7",
                                MainClass = "main_classb0f4e864",
                                Args = { "args09af56a9", },
                                JarFileUris =
                                {
                                    "jar_file_urisfcd646b7",
                                },
                                FileUris =
                                {
                                    "file_urisbcc83e18",
                                },
                                ArchiveUris =
                                {
                                    "archive_uris5a747dda",
                                },
                                Properties =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                LoggingConfig = new LoggingConfig
                                {
                                    DriverLogLevels =
                                    {
                                        {
                                            "key8a0b6e3c",
                                            LoggingConfig.Types.Level.Debug
                                        },
                                    },
                                },
                            },
                            PysparkJob = new PySparkJob
                            {
                                MainPythonFileUri = "main_python_file_uri14aabff5",
                                Args = { "args09af56a9", },
                                PythonFileUris =
                                {
                                    "python_file_uris30483b38",
                                },
                                JarFileUris =
                                {
                                    "jar_file_urisfcd646b7",
                                },
                                FileUris =
                                {
                                    "file_urisbcc83e18",
                                },
                                ArchiveUris =
                                {
                                    "archive_uris5a747dda",
                                },
                                Properties =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                LoggingConfig = new LoggingConfig
                                {
                                    DriverLogLevels =
                                    {
                                        {
                                            "key8a0b6e3c",
                                            LoggingConfig.Types.Level.Debug
                                        },
                                    },
                                },
                            },
                            HiveJob = new HiveJob
                            {
                                QueryFileUri = "query_file_urid4d84faf",
                                QueryList = new QueryList
                                {
                                    Queries = { "queries42eba75d", },
                                },
                                ContinueOnFailure = false,
                                ScriptVariables =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                Properties =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                JarFileUris =
                                {
                                    "jar_file_urisfcd646b7",
                                },
                            },
                            PigJob = new PigJob
                            {
                                QueryFileUri = "query_file_urid4d84faf",
                                QueryList = new QueryList
                                {
                                    Queries = { "queries42eba75d", },
                                },
                                ContinueOnFailure = false,
                                ScriptVariables =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                Properties =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                JarFileUris =
                                {
                                    "jar_file_urisfcd646b7",
                                },
                                LoggingConfig = new LoggingConfig
                                {
                                    DriverLogLevels =
                                    {
                                        {
                                            "key8a0b6e3c",
                                            LoggingConfig.Types.Level.Debug
                                        },
                                    },
                                },
                            },
                            SparkSqlJob = new SparkSqlJob
                            {
                                QueryFileUri = "query_file_urid4d84faf",
                                QueryList = new QueryList
                                {
                                    Queries = { "queries42eba75d", },
                                },
                                ScriptVariables =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                Properties =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                LoggingConfig = new LoggingConfig
                                {
                                    DriverLogLevels =
                                    {
                                        {
                                            "key8a0b6e3c",
                                            LoggingConfig.Types.Level.Debug
                                        },
                                    },
                                },
                                JarFileUris =
                                {
                                    "jar_file_urisfcd646b7",
                                },
                            },
                            Labels =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            Scheduling = new JobScheduling
                            {
                                MaxFailuresPerHour = 238137428,
                            },
                            PrerequisiteStepIds =
                            {
                                "prerequisite_step_ids4753a371",
                            },
                            SparkRJob = new SparkRJob
                            {
                                MainRFileUri = "main_r_file_uri3c1a03d8",
                                Args = { "args09af56a9", },
                                FileUris =
                                {
                                    "file_urisbcc83e18",
                                },
                                ArchiveUris =
                                {
                                    "archive_uris5a747dda",
                                },
                                Properties =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                LoggingConfig = new LoggingConfig
                                {
                                    DriverLogLevels =
                                    {
                                        {
                                            "key8a0b6e3c",
                                            LoggingConfig.Types.Level.Debug
                                        },
                                    },
                                },
                            },
                            PrestoJob = new PrestoJob
                            {
                                QueryFileUri = "query_file_urid4d84faf",
                                QueryList = new QueryList
                                {
                                    Queries = { "queries42eba75d", },
                                },
                                ContinueOnFailure = false,
                                OutputFormat = "output_format020eca50",
                                ClientTags =
                                {
                                    "client_tags74c9d57e",
                                },
                                Properties =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                LoggingConfig = new LoggingConfig
                                {
                                    DriverLogLevels =
                                    {
                                        {
                                            "key8a0b6e3c",
                                            LoggingConfig.Types.Level.Debug
                                        },
                                    },
                                },
                            },
                        },
                    },
                    Parameters =
                    {
                        new TemplateParameter
                        {
                            Name = "name1c9368b0",
                            Fields = { "fieldsd76e5bd0", },
                            Description = "description2cf9da67",
                            Validation = new ParameterValidation
                            {
                                Regex = new RegexValidation
                                {
                                    Regexes = { "regexes5cb111ce", },
                                },
                                Values = new ValueValidation
                                {
                                    Values = { "valueseec79cf0", },
                                },
                            },
                        },
                    },
                },
            };
            WorkflowTemplate expectedResponse = new WorkflowTemplate
            {
                WorkflowTemplateName = WorkflowTemplateName.FromProjectRegionWorkflowTemplate("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]"),
                Id = "id74b70bb8",
                Version = 271578922,
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                UpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Placement = new WorkflowTemplatePlacement
                {
                    ManagedCluster = new ManagedCluster
                    {
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
                        Labels =
                        {
                            {
                                "key8a0b6e3c",
                                "value60c16320"
                            },
                        },
                    },
                    ClusterSelector = new ClusterSelector
                    {
                        Zone = "zone255f4ea8",
                        ClusterLabels =
                        {
                            {
                                "key8a0b6e3c",
                                "value60c16320"
                            },
                        },
                    },
                },
                Jobs =
                {
                    new OrderedJob
                    {
                        StepId = "step_idd291f4be",
                        HadoopJob = new HadoopJob
                        {
                            MainJarFileUri = "main_jar_file_uri46ea7aa7",
                            MainClass = "main_classb0f4e864",
                            Args = { "args09af56a9", },
                            JarFileUris =
                            {
                                "jar_file_urisfcd646b7",
                            },
                            FileUris =
                            {
                                "file_urisbcc83e18",
                            },
                            ArchiveUris =
                            {
                                "archive_uris5a747dda",
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                        },
                        SparkJob = new SparkJob
                        {
                            MainJarFileUri = "main_jar_file_uri46ea7aa7",
                            MainClass = "main_classb0f4e864",
                            Args = { "args09af56a9", },
                            JarFileUris =
                            {
                                "jar_file_urisfcd646b7",
                            },
                            FileUris =
                            {
                                "file_urisbcc83e18",
                            },
                            ArchiveUris =
                            {
                                "archive_uris5a747dda",
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                        },
                        PysparkJob = new PySparkJob
                        {
                            MainPythonFileUri = "main_python_file_uri14aabff5",
                            Args = { "args09af56a9", },
                            PythonFileUris =
                            {
                                "python_file_uris30483b38",
                            },
                            JarFileUris =
                            {
                                "jar_file_urisfcd646b7",
                            },
                            FileUris =
                            {
                                "file_urisbcc83e18",
                            },
                            ArchiveUris =
                            {
                                "archive_uris5a747dda",
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                        },
                        HiveJob = new HiveJob
                        {
                            QueryFileUri = "query_file_urid4d84faf",
                            QueryList = new QueryList
                            {
                                Queries = { "queries42eba75d", },
                            },
                            ContinueOnFailure = false,
                            ScriptVariables =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            JarFileUris =
                            {
                                "jar_file_urisfcd646b7",
                            },
                        },
                        PigJob = new PigJob
                        {
                            QueryFileUri = "query_file_urid4d84faf",
                            QueryList = new QueryList
                            {
                                Queries = { "queries42eba75d", },
                            },
                            ContinueOnFailure = false,
                            ScriptVariables =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            JarFileUris =
                            {
                                "jar_file_urisfcd646b7",
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                        },
                        SparkSqlJob = new SparkSqlJob
                        {
                            QueryFileUri = "query_file_urid4d84faf",
                            QueryList = new QueryList
                            {
                                Queries = { "queries42eba75d", },
                            },
                            ScriptVariables =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                            JarFileUris =
                            {
                                "jar_file_urisfcd646b7",
                            },
                        },
                        Labels =
                        {
                            {
                                "key8a0b6e3c",
                                "value60c16320"
                            },
                        },
                        Scheduling = new JobScheduling
                        {
                            MaxFailuresPerHour = 238137428,
                        },
                        PrerequisiteStepIds =
                        {
                            "prerequisite_step_ids4753a371",
                        },
                        SparkRJob = new SparkRJob
                        {
                            MainRFileUri = "main_r_file_uri3c1a03d8",
                            Args = { "args09af56a9", },
                            FileUris =
                            {
                                "file_urisbcc83e18",
                            },
                            ArchiveUris =
                            {
                                "archive_uris5a747dda",
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                        },
                        PrestoJob = new PrestoJob
                        {
                            QueryFileUri = "query_file_urid4d84faf",
                            QueryList = new QueryList
                            {
                                Queries = { "queries42eba75d", },
                            },
                            ContinueOnFailure = false,
                            OutputFormat = "output_format020eca50",
                            ClientTags =
                            {
                                "client_tags74c9d57e",
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                        },
                    },
                },
                Parameters =
                {
                    new TemplateParameter
                    {
                        Name = "name1c9368b0",
                        Fields = { "fieldsd76e5bd0", },
                        Description = "description2cf9da67",
                        Validation = new ParameterValidation
                        {
                            Regex = new RegexValidation
                            {
                                Regexes = { "regexes5cb111ce", },
                            },
                            Values = new ValueValidation
                            {
                                Values = { "valueseec79cf0", },
                            },
                        },
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CreateWorkflowTemplateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<WorkflowTemplate>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            WorkflowTemplateServiceClient client = new WorkflowTemplateServiceClientImpl(mockGrpcClient.Object, null);
            WorkflowTemplate responseCallSettings = await client.CreateWorkflowTemplateAsync(request.Parent, request.Template, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            WorkflowTemplate responseCancellationToken = await client.CreateWorkflowTemplateAsync(request.Parent, request.Template, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateWorkflowTemplateResourceNames1()
        {
            moq::Mock<WorkflowTemplateService.WorkflowTemplateServiceClient> mockGrpcClient = new moq::Mock<WorkflowTemplateService.WorkflowTemplateServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateWorkflowTemplateRequest request = new CreateWorkflowTemplateRequest
            {
                ParentAsRegionName = RegionName.FromProjectRegion("[PROJECT]", "[REGION]"),
                Template = new WorkflowTemplate
                {
                    WorkflowTemplateName = WorkflowTemplateName.FromProjectRegionWorkflowTemplate("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]"),
                    Id = "id74b70bb8",
                    Version = 271578922,
                    CreateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    UpdateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    Labels =
                    {
                        {
                            "key8a0b6e3c",
                            "value60c16320"
                        },
                    },
                    Placement = new WorkflowTemplatePlacement
                    {
                        ManagedCluster = new ManagedCluster
                        {
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
                            Labels =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                        },
                        ClusterSelector = new ClusterSelector
                        {
                            Zone = "zone255f4ea8",
                            ClusterLabels =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                        },
                    },
                    Jobs =
                    {
                        new OrderedJob
                        {
                            StepId = "step_idd291f4be",
                            HadoopJob = new HadoopJob
                            {
                                MainJarFileUri = "main_jar_file_uri46ea7aa7",
                                MainClass = "main_classb0f4e864",
                                Args = { "args09af56a9", },
                                JarFileUris =
                                {
                                    "jar_file_urisfcd646b7",
                                },
                                FileUris =
                                {
                                    "file_urisbcc83e18",
                                },
                                ArchiveUris =
                                {
                                    "archive_uris5a747dda",
                                },
                                Properties =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                LoggingConfig = new LoggingConfig
                                {
                                    DriverLogLevels =
                                    {
                                        {
                                            "key8a0b6e3c",
                                            LoggingConfig.Types.Level.Debug
                                        },
                                    },
                                },
                            },
                            SparkJob = new SparkJob
                            {
                                MainJarFileUri = "main_jar_file_uri46ea7aa7",
                                MainClass = "main_classb0f4e864",
                                Args = { "args09af56a9", },
                                JarFileUris =
                                {
                                    "jar_file_urisfcd646b7",
                                },
                                FileUris =
                                {
                                    "file_urisbcc83e18",
                                },
                                ArchiveUris =
                                {
                                    "archive_uris5a747dda",
                                },
                                Properties =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                LoggingConfig = new LoggingConfig
                                {
                                    DriverLogLevels =
                                    {
                                        {
                                            "key8a0b6e3c",
                                            LoggingConfig.Types.Level.Debug
                                        },
                                    },
                                },
                            },
                            PysparkJob = new PySparkJob
                            {
                                MainPythonFileUri = "main_python_file_uri14aabff5",
                                Args = { "args09af56a9", },
                                PythonFileUris =
                                {
                                    "python_file_uris30483b38",
                                },
                                JarFileUris =
                                {
                                    "jar_file_urisfcd646b7",
                                },
                                FileUris =
                                {
                                    "file_urisbcc83e18",
                                },
                                ArchiveUris =
                                {
                                    "archive_uris5a747dda",
                                },
                                Properties =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                LoggingConfig = new LoggingConfig
                                {
                                    DriverLogLevels =
                                    {
                                        {
                                            "key8a0b6e3c",
                                            LoggingConfig.Types.Level.Debug
                                        },
                                    },
                                },
                            },
                            HiveJob = new HiveJob
                            {
                                QueryFileUri = "query_file_urid4d84faf",
                                QueryList = new QueryList
                                {
                                    Queries = { "queries42eba75d", },
                                },
                                ContinueOnFailure = false,
                                ScriptVariables =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                Properties =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                JarFileUris =
                                {
                                    "jar_file_urisfcd646b7",
                                },
                            },
                            PigJob = new PigJob
                            {
                                QueryFileUri = "query_file_urid4d84faf",
                                QueryList = new QueryList
                                {
                                    Queries = { "queries42eba75d", },
                                },
                                ContinueOnFailure = false,
                                ScriptVariables =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                Properties =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                JarFileUris =
                                {
                                    "jar_file_urisfcd646b7",
                                },
                                LoggingConfig = new LoggingConfig
                                {
                                    DriverLogLevels =
                                    {
                                        {
                                            "key8a0b6e3c",
                                            LoggingConfig.Types.Level.Debug
                                        },
                                    },
                                },
                            },
                            SparkSqlJob = new SparkSqlJob
                            {
                                QueryFileUri = "query_file_urid4d84faf",
                                QueryList = new QueryList
                                {
                                    Queries = { "queries42eba75d", },
                                },
                                ScriptVariables =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                Properties =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                LoggingConfig = new LoggingConfig
                                {
                                    DriverLogLevels =
                                    {
                                        {
                                            "key8a0b6e3c",
                                            LoggingConfig.Types.Level.Debug
                                        },
                                    },
                                },
                                JarFileUris =
                                {
                                    "jar_file_urisfcd646b7",
                                },
                            },
                            Labels =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            Scheduling = new JobScheduling
                            {
                                MaxFailuresPerHour = 238137428,
                            },
                            PrerequisiteStepIds =
                            {
                                "prerequisite_step_ids4753a371",
                            },
                            SparkRJob = new SparkRJob
                            {
                                MainRFileUri = "main_r_file_uri3c1a03d8",
                                Args = { "args09af56a9", },
                                FileUris =
                                {
                                    "file_urisbcc83e18",
                                },
                                ArchiveUris =
                                {
                                    "archive_uris5a747dda",
                                },
                                Properties =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                LoggingConfig = new LoggingConfig
                                {
                                    DriverLogLevels =
                                    {
                                        {
                                            "key8a0b6e3c",
                                            LoggingConfig.Types.Level.Debug
                                        },
                                    },
                                },
                            },
                            PrestoJob = new PrestoJob
                            {
                                QueryFileUri = "query_file_urid4d84faf",
                                QueryList = new QueryList
                                {
                                    Queries = { "queries42eba75d", },
                                },
                                ContinueOnFailure = false,
                                OutputFormat = "output_format020eca50",
                                ClientTags =
                                {
                                    "client_tags74c9d57e",
                                },
                                Properties =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                LoggingConfig = new LoggingConfig
                                {
                                    DriverLogLevels =
                                    {
                                        {
                                            "key8a0b6e3c",
                                            LoggingConfig.Types.Level.Debug
                                        },
                                    },
                                },
                            },
                        },
                    },
                    Parameters =
                    {
                        new TemplateParameter
                        {
                            Name = "name1c9368b0",
                            Fields = { "fieldsd76e5bd0", },
                            Description = "description2cf9da67",
                            Validation = new ParameterValidation
                            {
                                Regex = new RegexValidation
                                {
                                    Regexes = { "regexes5cb111ce", },
                                },
                                Values = new ValueValidation
                                {
                                    Values = { "valueseec79cf0", },
                                },
                            },
                        },
                    },
                },
            };
            WorkflowTemplate expectedResponse = new WorkflowTemplate
            {
                WorkflowTemplateName = WorkflowTemplateName.FromProjectRegionWorkflowTemplate("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]"),
                Id = "id74b70bb8",
                Version = 271578922,
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                UpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Placement = new WorkflowTemplatePlacement
                {
                    ManagedCluster = new ManagedCluster
                    {
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
                        Labels =
                        {
                            {
                                "key8a0b6e3c",
                                "value60c16320"
                            },
                        },
                    },
                    ClusterSelector = new ClusterSelector
                    {
                        Zone = "zone255f4ea8",
                        ClusterLabels =
                        {
                            {
                                "key8a0b6e3c",
                                "value60c16320"
                            },
                        },
                    },
                },
                Jobs =
                {
                    new OrderedJob
                    {
                        StepId = "step_idd291f4be",
                        HadoopJob = new HadoopJob
                        {
                            MainJarFileUri = "main_jar_file_uri46ea7aa7",
                            MainClass = "main_classb0f4e864",
                            Args = { "args09af56a9", },
                            JarFileUris =
                            {
                                "jar_file_urisfcd646b7",
                            },
                            FileUris =
                            {
                                "file_urisbcc83e18",
                            },
                            ArchiveUris =
                            {
                                "archive_uris5a747dda",
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                        },
                        SparkJob = new SparkJob
                        {
                            MainJarFileUri = "main_jar_file_uri46ea7aa7",
                            MainClass = "main_classb0f4e864",
                            Args = { "args09af56a9", },
                            JarFileUris =
                            {
                                "jar_file_urisfcd646b7",
                            },
                            FileUris =
                            {
                                "file_urisbcc83e18",
                            },
                            ArchiveUris =
                            {
                                "archive_uris5a747dda",
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                        },
                        PysparkJob = new PySparkJob
                        {
                            MainPythonFileUri = "main_python_file_uri14aabff5",
                            Args = { "args09af56a9", },
                            PythonFileUris =
                            {
                                "python_file_uris30483b38",
                            },
                            JarFileUris =
                            {
                                "jar_file_urisfcd646b7",
                            },
                            FileUris =
                            {
                                "file_urisbcc83e18",
                            },
                            ArchiveUris =
                            {
                                "archive_uris5a747dda",
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                        },
                        HiveJob = new HiveJob
                        {
                            QueryFileUri = "query_file_urid4d84faf",
                            QueryList = new QueryList
                            {
                                Queries = { "queries42eba75d", },
                            },
                            ContinueOnFailure = false,
                            ScriptVariables =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            JarFileUris =
                            {
                                "jar_file_urisfcd646b7",
                            },
                        },
                        PigJob = new PigJob
                        {
                            QueryFileUri = "query_file_urid4d84faf",
                            QueryList = new QueryList
                            {
                                Queries = { "queries42eba75d", },
                            },
                            ContinueOnFailure = false,
                            ScriptVariables =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            JarFileUris =
                            {
                                "jar_file_urisfcd646b7",
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                        },
                        SparkSqlJob = new SparkSqlJob
                        {
                            QueryFileUri = "query_file_urid4d84faf",
                            QueryList = new QueryList
                            {
                                Queries = { "queries42eba75d", },
                            },
                            ScriptVariables =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                            JarFileUris =
                            {
                                "jar_file_urisfcd646b7",
                            },
                        },
                        Labels =
                        {
                            {
                                "key8a0b6e3c",
                                "value60c16320"
                            },
                        },
                        Scheduling = new JobScheduling
                        {
                            MaxFailuresPerHour = 238137428,
                        },
                        PrerequisiteStepIds =
                        {
                            "prerequisite_step_ids4753a371",
                        },
                        SparkRJob = new SparkRJob
                        {
                            MainRFileUri = "main_r_file_uri3c1a03d8",
                            Args = { "args09af56a9", },
                            FileUris =
                            {
                                "file_urisbcc83e18",
                            },
                            ArchiveUris =
                            {
                                "archive_uris5a747dda",
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                        },
                        PrestoJob = new PrestoJob
                        {
                            QueryFileUri = "query_file_urid4d84faf",
                            QueryList = new QueryList
                            {
                                Queries = { "queries42eba75d", },
                            },
                            ContinueOnFailure = false,
                            OutputFormat = "output_format020eca50",
                            ClientTags =
                            {
                                "client_tags74c9d57e",
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                        },
                    },
                },
                Parameters =
                {
                    new TemplateParameter
                    {
                        Name = "name1c9368b0",
                        Fields = { "fieldsd76e5bd0", },
                        Description = "description2cf9da67",
                        Validation = new ParameterValidation
                        {
                            Regex = new RegexValidation
                            {
                                Regexes = { "regexes5cb111ce", },
                            },
                            Values = new ValueValidation
                            {
                                Values = { "valueseec79cf0", },
                            },
                        },
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CreateWorkflowTemplate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            WorkflowTemplateServiceClient client = new WorkflowTemplateServiceClientImpl(mockGrpcClient.Object, null);
            WorkflowTemplate response = client.CreateWorkflowTemplate(request.ParentAsRegionName, request.Template);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateWorkflowTemplateResourceNames1Async()
        {
            moq::Mock<WorkflowTemplateService.WorkflowTemplateServiceClient> mockGrpcClient = new moq::Mock<WorkflowTemplateService.WorkflowTemplateServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateWorkflowTemplateRequest request = new CreateWorkflowTemplateRequest
            {
                ParentAsRegionName = RegionName.FromProjectRegion("[PROJECT]", "[REGION]"),
                Template = new WorkflowTemplate
                {
                    WorkflowTemplateName = WorkflowTemplateName.FromProjectRegionWorkflowTemplate("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]"),
                    Id = "id74b70bb8",
                    Version = 271578922,
                    CreateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    UpdateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    Labels =
                    {
                        {
                            "key8a0b6e3c",
                            "value60c16320"
                        },
                    },
                    Placement = new WorkflowTemplatePlacement
                    {
                        ManagedCluster = new ManagedCluster
                        {
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
                            Labels =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                        },
                        ClusterSelector = new ClusterSelector
                        {
                            Zone = "zone255f4ea8",
                            ClusterLabels =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                        },
                    },
                    Jobs =
                    {
                        new OrderedJob
                        {
                            StepId = "step_idd291f4be",
                            HadoopJob = new HadoopJob
                            {
                                MainJarFileUri = "main_jar_file_uri46ea7aa7",
                                MainClass = "main_classb0f4e864",
                                Args = { "args09af56a9", },
                                JarFileUris =
                                {
                                    "jar_file_urisfcd646b7",
                                },
                                FileUris =
                                {
                                    "file_urisbcc83e18",
                                },
                                ArchiveUris =
                                {
                                    "archive_uris5a747dda",
                                },
                                Properties =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                LoggingConfig = new LoggingConfig
                                {
                                    DriverLogLevels =
                                    {
                                        {
                                            "key8a0b6e3c",
                                            LoggingConfig.Types.Level.Debug
                                        },
                                    },
                                },
                            },
                            SparkJob = new SparkJob
                            {
                                MainJarFileUri = "main_jar_file_uri46ea7aa7",
                                MainClass = "main_classb0f4e864",
                                Args = { "args09af56a9", },
                                JarFileUris =
                                {
                                    "jar_file_urisfcd646b7",
                                },
                                FileUris =
                                {
                                    "file_urisbcc83e18",
                                },
                                ArchiveUris =
                                {
                                    "archive_uris5a747dda",
                                },
                                Properties =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                LoggingConfig = new LoggingConfig
                                {
                                    DriverLogLevels =
                                    {
                                        {
                                            "key8a0b6e3c",
                                            LoggingConfig.Types.Level.Debug
                                        },
                                    },
                                },
                            },
                            PysparkJob = new PySparkJob
                            {
                                MainPythonFileUri = "main_python_file_uri14aabff5",
                                Args = { "args09af56a9", },
                                PythonFileUris =
                                {
                                    "python_file_uris30483b38",
                                },
                                JarFileUris =
                                {
                                    "jar_file_urisfcd646b7",
                                },
                                FileUris =
                                {
                                    "file_urisbcc83e18",
                                },
                                ArchiveUris =
                                {
                                    "archive_uris5a747dda",
                                },
                                Properties =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                LoggingConfig = new LoggingConfig
                                {
                                    DriverLogLevels =
                                    {
                                        {
                                            "key8a0b6e3c",
                                            LoggingConfig.Types.Level.Debug
                                        },
                                    },
                                },
                            },
                            HiveJob = new HiveJob
                            {
                                QueryFileUri = "query_file_urid4d84faf",
                                QueryList = new QueryList
                                {
                                    Queries = { "queries42eba75d", },
                                },
                                ContinueOnFailure = false,
                                ScriptVariables =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                Properties =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                JarFileUris =
                                {
                                    "jar_file_urisfcd646b7",
                                },
                            },
                            PigJob = new PigJob
                            {
                                QueryFileUri = "query_file_urid4d84faf",
                                QueryList = new QueryList
                                {
                                    Queries = { "queries42eba75d", },
                                },
                                ContinueOnFailure = false,
                                ScriptVariables =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                Properties =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                JarFileUris =
                                {
                                    "jar_file_urisfcd646b7",
                                },
                                LoggingConfig = new LoggingConfig
                                {
                                    DriverLogLevels =
                                    {
                                        {
                                            "key8a0b6e3c",
                                            LoggingConfig.Types.Level.Debug
                                        },
                                    },
                                },
                            },
                            SparkSqlJob = new SparkSqlJob
                            {
                                QueryFileUri = "query_file_urid4d84faf",
                                QueryList = new QueryList
                                {
                                    Queries = { "queries42eba75d", },
                                },
                                ScriptVariables =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                Properties =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                LoggingConfig = new LoggingConfig
                                {
                                    DriverLogLevels =
                                    {
                                        {
                                            "key8a0b6e3c",
                                            LoggingConfig.Types.Level.Debug
                                        },
                                    },
                                },
                                JarFileUris =
                                {
                                    "jar_file_urisfcd646b7",
                                },
                            },
                            Labels =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            Scheduling = new JobScheduling
                            {
                                MaxFailuresPerHour = 238137428,
                            },
                            PrerequisiteStepIds =
                            {
                                "prerequisite_step_ids4753a371",
                            },
                            SparkRJob = new SparkRJob
                            {
                                MainRFileUri = "main_r_file_uri3c1a03d8",
                                Args = { "args09af56a9", },
                                FileUris =
                                {
                                    "file_urisbcc83e18",
                                },
                                ArchiveUris =
                                {
                                    "archive_uris5a747dda",
                                },
                                Properties =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                LoggingConfig = new LoggingConfig
                                {
                                    DriverLogLevels =
                                    {
                                        {
                                            "key8a0b6e3c",
                                            LoggingConfig.Types.Level.Debug
                                        },
                                    },
                                },
                            },
                            PrestoJob = new PrestoJob
                            {
                                QueryFileUri = "query_file_urid4d84faf",
                                QueryList = new QueryList
                                {
                                    Queries = { "queries42eba75d", },
                                },
                                ContinueOnFailure = false,
                                OutputFormat = "output_format020eca50",
                                ClientTags =
                                {
                                    "client_tags74c9d57e",
                                },
                                Properties =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                LoggingConfig = new LoggingConfig
                                {
                                    DriverLogLevels =
                                    {
                                        {
                                            "key8a0b6e3c",
                                            LoggingConfig.Types.Level.Debug
                                        },
                                    },
                                },
                            },
                        },
                    },
                    Parameters =
                    {
                        new TemplateParameter
                        {
                            Name = "name1c9368b0",
                            Fields = { "fieldsd76e5bd0", },
                            Description = "description2cf9da67",
                            Validation = new ParameterValidation
                            {
                                Regex = new RegexValidation
                                {
                                    Regexes = { "regexes5cb111ce", },
                                },
                                Values = new ValueValidation
                                {
                                    Values = { "valueseec79cf0", },
                                },
                            },
                        },
                    },
                },
            };
            WorkflowTemplate expectedResponse = new WorkflowTemplate
            {
                WorkflowTemplateName = WorkflowTemplateName.FromProjectRegionWorkflowTemplate("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]"),
                Id = "id74b70bb8",
                Version = 271578922,
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                UpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Placement = new WorkflowTemplatePlacement
                {
                    ManagedCluster = new ManagedCluster
                    {
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
                        Labels =
                        {
                            {
                                "key8a0b6e3c",
                                "value60c16320"
                            },
                        },
                    },
                    ClusterSelector = new ClusterSelector
                    {
                        Zone = "zone255f4ea8",
                        ClusterLabels =
                        {
                            {
                                "key8a0b6e3c",
                                "value60c16320"
                            },
                        },
                    },
                },
                Jobs =
                {
                    new OrderedJob
                    {
                        StepId = "step_idd291f4be",
                        HadoopJob = new HadoopJob
                        {
                            MainJarFileUri = "main_jar_file_uri46ea7aa7",
                            MainClass = "main_classb0f4e864",
                            Args = { "args09af56a9", },
                            JarFileUris =
                            {
                                "jar_file_urisfcd646b7",
                            },
                            FileUris =
                            {
                                "file_urisbcc83e18",
                            },
                            ArchiveUris =
                            {
                                "archive_uris5a747dda",
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                        },
                        SparkJob = new SparkJob
                        {
                            MainJarFileUri = "main_jar_file_uri46ea7aa7",
                            MainClass = "main_classb0f4e864",
                            Args = { "args09af56a9", },
                            JarFileUris =
                            {
                                "jar_file_urisfcd646b7",
                            },
                            FileUris =
                            {
                                "file_urisbcc83e18",
                            },
                            ArchiveUris =
                            {
                                "archive_uris5a747dda",
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                        },
                        PysparkJob = new PySparkJob
                        {
                            MainPythonFileUri = "main_python_file_uri14aabff5",
                            Args = { "args09af56a9", },
                            PythonFileUris =
                            {
                                "python_file_uris30483b38",
                            },
                            JarFileUris =
                            {
                                "jar_file_urisfcd646b7",
                            },
                            FileUris =
                            {
                                "file_urisbcc83e18",
                            },
                            ArchiveUris =
                            {
                                "archive_uris5a747dda",
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                        },
                        HiveJob = new HiveJob
                        {
                            QueryFileUri = "query_file_urid4d84faf",
                            QueryList = new QueryList
                            {
                                Queries = { "queries42eba75d", },
                            },
                            ContinueOnFailure = false,
                            ScriptVariables =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            JarFileUris =
                            {
                                "jar_file_urisfcd646b7",
                            },
                        },
                        PigJob = new PigJob
                        {
                            QueryFileUri = "query_file_urid4d84faf",
                            QueryList = new QueryList
                            {
                                Queries = { "queries42eba75d", },
                            },
                            ContinueOnFailure = false,
                            ScriptVariables =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            JarFileUris =
                            {
                                "jar_file_urisfcd646b7",
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                        },
                        SparkSqlJob = new SparkSqlJob
                        {
                            QueryFileUri = "query_file_urid4d84faf",
                            QueryList = new QueryList
                            {
                                Queries = { "queries42eba75d", },
                            },
                            ScriptVariables =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                            JarFileUris =
                            {
                                "jar_file_urisfcd646b7",
                            },
                        },
                        Labels =
                        {
                            {
                                "key8a0b6e3c",
                                "value60c16320"
                            },
                        },
                        Scheduling = new JobScheduling
                        {
                            MaxFailuresPerHour = 238137428,
                        },
                        PrerequisiteStepIds =
                        {
                            "prerequisite_step_ids4753a371",
                        },
                        SparkRJob = new SparkRJob
                        {
                            MainRFileUri = "main_r_file_uri3c1a03d8",
                            Args = { "args09af56a9", },
                            FileUris =
                            {
                                "file_urisbcc83e18",
                            },
                            ArchiveUris =
                            {
                                "archive_uris5a747dda",
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                        },
                        PrestoJob = new PrestoJob
                        {
                            QueryFileUri = "query_file_urid4d84faf",
                            QueryList = new QueryList
                            {
                                Queries = { "queries42eba75d", },
                            },
                            ContinueOnFailure = false,
                            OutputFormat = "output_format020eca50",
                            ClientTags =
                            {
                                "client_tags74c9d57e",
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                        },
                    },
                },
                Parameters =
                {
                    new TemplateParameter
                    {
                        Name = "name1c9368b0",
                        Fields = { "fieldsd76e5bd0", },
                        Description = "description2cf9da67",
                        Validation = new ParameterValidation
                        {
                            Regex = new RegexValidation
                            {
                                Regexes = { "regexes5cb111ce", },
                            },
                            Values = new ValueValidation
                            {
                                Values = { "valueseec79cf0", },
                            },
                        },
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CreateWorkflowTemplateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<WorkflowTemplate>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            WorkflowTemplateServiceClient client = new WorkflowTemplateServiceClientImpl(mockGrpcClient.Object, null);
            WorkflowTemplate responseCallSettings = await client.CreateWorkflowTemplateAsync(request.ParentAsRegionName, request.Template, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            WorkflowTemplate responseCancellationToken = await client.CreateWorkflowTemplateAsync(request.ParentAsRegionName, request.Template, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateWorkflowTemplateResourceNames2()
        {
            moq::Mock<WorkflowTemplateService.WorkflowTemplateServiceClient> mockGrpcClient = new moq::Mock<WorkflowTemplateService.WorkflowTemplateServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateWorkflowTemplateRequest request = new CreateWorkflowTemplateRequest
            {
                ParentAsRegionName = RegionName.FromProjectRegion("[PROJECT]", "[REGION]"),
                Template = new WorkflowTemplate
                {
                    WorkflowTemplateName = WorkflowTemplateName.FromProjectRegionWorkflowTemplate("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]"),
                    Id = "id74b70bb8",
                    Version = 271578922,
                    CreateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    UpdateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    Labels =
                    {
                        {
                            "key8a0b6e3c",
                            "value60c16320"
                        },
                    },
                    Placement = new WorkflowTemplatePlacement
                    {
                        ManagedCluster = new ManagedCluster
                        {
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
                            Labels =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                        },
                        ClusterSelector = new ClusterSelector
                        {
                            Zone = "zone255f4ea8",
                            ClusterLabels =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                        },
                    },
                    Jobs =
                    {
                        new OrderedJob
                        {
                            StepId = "step_idd291f4be",
                            HadoopJob = new HadoopJob
                            {
                                MainJarFileUri = "main_jar_file_uri46ea7aa7",
                                MainClass = "main_classb0f4e864",
                                Args = { "args09af56a9", },
                                JarFileUris =
                                {
                                    "jar_file_urisfcd646b7",
                                },
                                FileUris =
                                {
                                    "file_urisbcc83e18",
                                },
                                ArchiveUris =
                                {
                                    "archive_uris5a747dda",
                                },
                                Properties =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                LoggingConfig = new LoggingConfig
                                {
                                    DriverLogLevels =
                                    {
                                        {
                                            "key8a0b6e3c",
                                            LoggingConfig.Types.Level.Debug
                                        },
                                    },
                                },
                            },
                            SparkJob = new SparkJob
                            {
                                MainJarFileUri = "main_jar_file_uri46ea7aa7",
                                MainClass = "main_classb0f4e864",
                                Args = { "args09af56a9", },
                                JarFileUris =
                                {
                                    "jar_file_urisfcd646b7",
                                },
                                FileUris =
                                {
                                    "file_urisbcc83e18",
                                },
                                ArchiveUris =
                                {
                                    "archive_uris5a747dda",
                                },
                                Properties =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                LoggingConfig = new LoggingConfig
                                {
                                    DriverLogLevels =
                                    {
                                        {
                                            "key8a0b6e3c",
                                            LoggingConfig.Types.Level.Debug
                                        },
                                    },
                                },
                            },
                            PysparkJob = new PySparkJob
                            {
                                MainPythonFileUri = "main_python_file_uri14aabff5",
                                Args = { "args09af56a9", },
                                PythonFileUris =
                                {
                                    "python_file_uris30483b38",
                                },
                                JarFileUris =
                                {
                                    "jar_file_urisfcd646b7",
                                },
                                FileUris =
                                {
                                    "file_urisbcc83e18",
                                },
                                ArchiveUris =
                                {
                                    "archive_uris5a747dda",
                                },
                                Properties =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                LoggingConfig = new LoggingConfig
                                {
                                    DriverLogLevels =
                                    {
                                        {
                                            "key8a0b6e3c",
                                            LoggingConfig.Types.Level.Debug
                                        },
                                    },
                                },
                            },
                            HiveJob = new HiveJob
                            {
                                QueryFileUri = "query_file_urid4d84faf",
                                QueryList = new QueryList
                                {
                                    Queries = { "queries42eba75d", },
                                },
                                ContinueOnFailure = false,
                                ScriptVariables =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                Properties =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                JarFileUris =
                                {
                                    "jar_file_urisfcd646b7",
                                },
                            },
                            PigJob = new PigJob
                            {
                                QueryFileUri = "query_file_urid4d84faf",
                                QueryList = new QueryList
                                {
                                    Queries = { "queries42eba75d", },
                                },
                                ContinueOnFailure = false,
                                ScriptVariables =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                Properties =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                JarFileUris =
                                {
                                    "jar_file_urisfcd646b7",
                                },
                                LoggingConfig = new LoggingConfig
                                {
                                    DriverLogLevels =
                                    {
                                        {
                                            "key8a0b6e3c",
                                            LoggingConfig.Types.Level.Debug
                                        },
                                    },
                                },
                            },
                            SparkSqlJob = new SparkSqlJob
                            {
                                QueryFileUri = "query_file_urid4d84faf",
                                QueryList = new QueryList
                                {
                                    Queries = { "queries42eba75d", },
                                },
                                ScriptVariables =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                Properties =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                LoggingConfig = new LoggingConfig
                                {
                                    DriverLogLevels =
                                    {
                                        {
                                            "key8a0b6e3c",
                                            LoggingConfig.Types.Level.Debug
                                        },
                                    },
                                },
                                JarFileUris =
                                {
                                    "jar_file_urisfcd646b7",
                                },
                            },
                            Labels =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            Scheduling = new JobScheduling
                            {
                                MaxFailuresPerHour = 238137428,
                            },
                            PrerequisiteStepIds =
                            {
                                "prerequisite_step_ids4753a371",
                            },
                            SparkRJob = new SparkRJob
                            {
                                MainRFileUri = "main_r_file_uri3c1a03d8",
                                Args = { "args09af56a9", },
                                FileUris =
                                {
                                    "file_urisbcc83e18",
                                },
                                ArchiveUris =
                                {
                                    "archive_uris5a747dda",
                                },
                                Properties =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                LoggingConfig = new LoggingConfig
                                {
                                    DriverLogLevels =
                                    {
                                        {
                                            "key8a0b6e3c",
                                            LoggingConfig.Types.Level.Debug
                                        },
                                    },
                                },
                            },
                            PrestoJob = new PrestoJob
                            {
                                QueryFileUri = "query_file_urid4d84faf",
                                QueryList = new QueryList
                                {
                                    Queries = { "queries42eba75d", },
                                },
                                ContinueOnFailure = false,
                                OutputFormat = "output_format020eca50",
                                ClientTags =
                                {
                                    "client_tags74c9d57e",
                                },
                                Properties =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                LoggingConfig = new LoggingConfig
                                {
                                    DriverLogLevels =
                                    {
                                        {
                                            "key8a0b6e3c",
                                            LoggingConfig.Types.Level.Debug
                                        },
                                    },
                                },
                            },
                        },
                    },
                    Parameters =
                    {
                        new TemplateParameter
                        {
                            Name = "name1c9368b0",
                            Fields = { "fieldsd76e5bd0", },
                            Description = "description2cf9da67",
                            Validation = new ParameterValidation
                            {
                                Regex = new RegexValidation
                                {
                                    Regexes = { "regexes5cb111ce", },
                                },
                                Values = new ValueValidation
                                {
                                    Values = { "valueseec79cf0", },
                                },
                            },
                        },
                    },
                },
            };
            WorkflowTemplate expectedResponse = new WorkflowTemplate
            {
                WorkflowTemplateName = WorkflowTemplateName.FromProjectRegionWorkflowTemplate("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]"),
                Id = "id74b70bb8",
                Version = 271578922,
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                UpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Placement = new WorkflowTemplatePlacement
                {
                    ManagedCluster = new ManagedCluster
                    {
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
                        Labels =
                        {
                            {
                                "key8a0b6e3c",
                                "value60c16320"
                            },
                        },
                    },
                    ClusterSelector = new ClusterSelector
                    {
                        Zone = "zone255f4ea8",
                        ClusterLabels =
                        {
                            {
                                "key8a0b6e3c",
                                "value60c16320"
                            },
                        },
                    },
                },
                Jobs =
                {
                    new OrderedJob
                    {
                        StepId = "step_idd291f4be",
                        HadoopJob = new HadoopJob
                        {
                            MainJarFileUri = "main_jar_file_uri46ea7aa7",
                            MainClass = "main_classb0f4e864",
                            Args = { "args09af56a9", },
                            JarFileUris =
                            {
                                "jar_file_urisfcd646b7",
                            },
                            FileUris =
                            {
                                "file_urisbcc83e18",
                            },
                            ArchiveUris =
                            {
                                "archive_uris5a747dda",
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                        },
                        SparkJob = new SparkJob
                        {
                            MainJarFileUri = "main_jar_file_uri46ea7aa7",
                            MainClass = "main_classb0f4e864",
                            Args = { "args09af56a9", },
                            JarFileUris =
                            {
                                "jar_file_urisfcd646b7",
                            },
                            FileUris =
                            {
                                "file_urisbcc83e18",
                            },
                            ArchiveUris =
                            {
                                "archive_uris5a747dda",
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                        },
                        PysparkJob = new PySparkJob
                        {
                            MainPythonFileUri = "main_python_file_uri14aabff5",
                            Args = { "args09af56a9", },
                            PythonFileUris =
                            {
                                "python_file_uris30483b38",
                            },
                            JarFileUris =
                            {
                                "jar_file_urisfcd646b7",
                            },
                            FileUris =
                            {
                                "file_urisbcc83e18",
                            },
                            ArchiveUris =
                            {
                                "archive_uris5a747dda",
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                        },
                        HiveJob = new HiveJob
                        {
                            QueryFileUri = "query_file_urid4d84faf",
                            QueryList = new QueryList
                            {
                                Queries = { "queries42eba75d", },
                            },
                            ContinueOnFailure = false,
                            ScriptVariables =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            JarFileUris =
                            {
                                "jar_file_urisfcd646b7",
                            },
                        },
                        PigJob = new PigJob
                        {
                            QueryFileUri = "query_file_urid4d84faf",
                            QueryList = new QueryList
                            {
                                Queries = { "queries42eba75d", },
                            },
                            ContinueOnFailure = false,
                            ScriptVariables =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            JarFileUris =
                            {
                                "jar_file_urisfcd646b7",
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                        },
                        SparkSqlJob = new SparkSqlJob
                        {
                            QueryFileUri = "query_file_urid4d84faf",
                            QueryList = new QueryList
                            {
                                Queries = { "queries42eba75d", },
                            },
                            ScriptVariables =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                            JarFileUris =
                            {
                                "jar_file_urisfcd646b7",
                            },
                        },
                        Labels =
                        {
                            {
                                "key8a0b6e3c",
                                "value60c16320"
                            },
                        },
                        Scheduling = new JobScheduling
                        {
                            MaxFailuresPerHour = 238137428,
                        },
                        PrerequisiteStepIds =
                        {
                            "prerequisite_step_ids4753a371",
                        },
                        SparkRJob = new SparkRJob
                        {
                            MainRFileUri = "main_r_file_uri3c1a03d8",
                            Args = { "args09af56a9", },
                            FileUris =
                            {
                                "file_urisbcc83e18",
                            },
                            ArchiveUris =
                            {
                                "archive_uris5a747dda",
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                        },
                        PrestoJob = new PrestoJob
                        {
                            QueryFileUri = "query_file_urid4d84faf",
                            QueryList = new QueryList
                            {
                                Queries = { "queries42eba75d", },
                            },
                            ContinueOnFailure = false,
                            OutputFormat = "output_format020eca50",
                            ClientTags =
                            {
                                "client_tags74c9d57e",
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                        },
                    },
                },
                Parameters =
                {
                    new TemplateParameter
                    {
                        Name = "name1c9368b0",
                        Fields = { "fieldsd76e5bd0", },
                        Description = "description2cf9da67",
                        Validation = new ParameterValidation
                        {
                            Regex = new RegexValidation
                            {
                                Regexes = { "regexes5cb111ce", },
                            },
                            Values = new ValueValidation
                            {
                                Values = { "valueseec79cf0", },
                            },
                        },
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CreateWorkflowTemplate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            WorkflowTemplateServiceClient client = new WorkflowTemplateServiceClientImpl(mockGrpcClient.Object, null);
            WorkflowTemplate response = client.CreateWorkflowTemplate(request.ParentAsLocationName, request.Template);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateWorkflowTemplateResourceNames2Async()
        {
            moq::Mock<WorkflowTemplateService.WorkflowTemplateServiceClient> mockGrpcClient = new moq::Mock<WorkflowTemplateService.WorkflowTemplateServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateWorkflowTemplateRequest request = new CreateWorkflowTemplateRequest
            {
                ParentAsRegionName = RegionName.FromProjectRegion("[PROJECT]", "[REGION]"),
                Template = new WorkflowTemplate
                {
                    WorkflowTemplateName = WorkflowTemplateName.FromProjectRegionWorkflowTemplate("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]"),
                    Id = "id74b70bb8",
                    Version = 271578922,
                    CreateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    UpdateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    Labels =
                    {
                        {
                            "key8a0b6e3c",
                            "value60c16320"
                        },
                    },
                    Placement = new WorkflowTemplatePlacement
                    {
                        ManagedCluster = new ManagedCluster
                        {
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
                            Labels =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                        },
                        ClusterSelector = new ClusterSelector
                        {
                            Zone = "zone255f4ea8",
                            ClusterLabels =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                        },
                    },
                    Jobs =
                    {
                        new OrderedJob
                        {
                            StepId = "step_idd291f4be",
                            HadoopJob = new HadoopJob
                            {
                                MainJarFileUri = "main_jar_file_uri46ea7aa7",
                                MainClass = "main_classb0f4e864",
                                Args = { "args09af56a9", },
                                JarFileUris =
                                {
                                    "jar_file_urisfcd646b7",
                                },
                                FileUris =
                                {
                                    "file_urisbcc83e18",
                                },
                                ArchiveUris =
                                {
                                    "archive_uris5a747dda",
                                },
                                Properties =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                LoggingConfig = new LoggingConfig
                                {
                                    DriverLogLevels =
                                    {
                                        {
                                            "key8a0b6e3c",
                                            LoggingConfig.Types.Level.Debug
                                        },
                                    },
                                },
                            },
                            SparkJob = new SparkJob
                            {
                                MainJarFileUri = "main_jar_file_uri46ea7aa7",
                                MainClass = "main_classb0f4e864",
                                Args = { "args09af56a9", },
                                JarFileUris =
                                {
                                    "jar_file_urisfcd646b7",
                                },
                                FileUris =
                                {
                                    "file_urisbcc83e18",
                                },
                                ArchiveUris =
                                {
                                    "archive_uris5a747dda",
                                },
                                Properties =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                LoggingConfig = new LoggingConfig
                                {
                                    DriverLogLevels =
                                    {
                                        {
                                            "key8a0b6e3c",
                                            LoggingConfig.Types.Level.Debug
                                        },
                                    },
                                },
                            },
                            PysparkJob = new PySparkJob
                            {
                                MainPythonFileUri = "main_python_file_uri14aabff5",
                                Args = { "args09af56a9", },
                                PythonFileUris =
                                {
                                    "python_file_uris30483b38",
                                },
                                JarFileUris =
                                {
                                    "jar_file_urisfcd646b7",
                                },
                                FileUris =
                                {
                                    "file_urisbcc83e18",
                                },
                                ArchiveUris =
                                {
                                    "archive_uris5a747dda",
                                },
                                Properties =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                LoggingConfig = new LoggingConfig
                                {
                                    DriverLogLevels =
                                    {
                                        {
                                            "key8a0b6e3c",
                                            LoggingConfig.Types.Level.Debug
                                        },
                                    },
                                },
                            },
                            HiveJob = new HiveJob
                            {
                                QueryFileUri = "query_file_urid4d84faf",
                                QueryList = new QueryList
                                {
                                    Queries = { "queries42eba75d", },
                                },
                                ContinueOnFailure = false,
                                ScriptVariables =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                Properties =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                JarFileUris =
                                {
                                    "jar_file_urisfcd646b7",
                                },
                            },
                            PigJob = new PigJob
                            {
                                QueryFileUri = "query_file_urid4d84faf",
                                QueryList = new QueryList
                                {
                                    Queries = { "queries42eba75d", },
                                },
                                ContinueOnFailure = false,
                                ScriptVariables =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                Properties =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                JarFileUris =
                                {
                                    "jar_file_urisfcd646b7",
                                },
                                LoggingConfig = new LoggingConfig
                                {
                                    DriverLogLevels =
                                    {
                                        {
                                            "key8a0b6e3c",
                                            LoggingConfig.Types.Level.Debug
                                        },
                                    },
                                },
                            },
                            SparkSqlJob = new SparkSqlJob
                            {
                                QueryFileUri = "query_file_urid4d84faf",
                                QueryList = new QueryList
                                {
                                    Queries = { "queries42eba75d", },
                                },
                                ScriptVariables =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                Properties =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                LoggingConfig = new LoggingConfig
                                {
                                    DriverLogLevels =
                                    {
                                        {
                                            "key8a0b6e3c",
                                            LoggingConfig.Types.Level.Debug
                                        },
                                    },
                                },
                                JarFileUris =
                                {
                                    "jar_file_urisfcd646b7",
                                },
                            },
                            Labels =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            Scheduling = new JobScheduling
                            {
                                MaxFailuresPerHour = 238137428,
                            },
                            PrerequisiteStepIds =
                            {
                                "prerequisite_step_ids4753a371",
                            },
                            SparkRJob = new SparkRJob
                            {
                                MainRFileUri = "main_r_file_uri3c1a03d8",
                                Args = { "args09af56a9", },
                                FileUris =
                                {
                                    "file_urisbcc83e18",
                                },
                                ArchiveUris =
                                {
                                    "archive_uris5a747dda",
                                },
                                Properties =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                LoggingConfig = new LoggingConfig
                                {
                                    DriverLogLevels =
                                    {
                                        {
                                            "key8a0b6e3c",
                                            LoggingConfig.Types.Level.Debug
                                        },
                                    },
                                },
                            },
                            PrestoJob = new PrestoJob
                            {
                                QueryFileUri = "query_file_urid4d84faf",
                                QueryList = new QueryList
                                {
                                    Queries = { "queries42eba75d", },
                                },
                                ContinueOnFailure = false,
                                OutputFormat = "output_format020eca50",
                                ClientTags =
                                {
                                    "client_tags74c9d57e",
                                },
                                Properties =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                LoggingConfig = new LoggingConfig
                                {
                                    DriverLogLevels =
                                    {
                                        {
                                            "key8a0b6e3c",
                                            LoggingConfig.Types.Level.Debug
                                        },
                                    },
                                },
                            },
                        },
                    },
                    Parameters =
                    {
                        new TemplateParameter
                        {
                            Name = "name1c9368b0",
                            Fields = { "fieldsd76e5bd0", },
                            Description = "description2cf9da67",
                            Validation = new ParameterValidation
                            {
                                Regex = new RegexValidation
                                {
                                    Regexes = { "regexes5cb111ce", },
                                },
                                Values = new ValueValidation
                                {
                                    Values = { "valueseec79cf0", },
                                },
                            },
                        },
                    },
                },
            };
            WorkflowTemplate expectedResponse = new WorkflowTemplate
            {
                WorkflowTemplateName = WorkflowTemplateName.FromProjectRegionWorkflowTemplate("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]"),
                Id = "id74b70bb8",
                Version = 271578922,
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                UpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Placement = new WorkflowTemplatePlacement
                {
                    ManagedCluster = new ManagedCluster
                    {
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
                        Labels =
                        {
                            {
                                "key8a0b6e3c",
                                "value60c16320"
                            },
                        },
                    },
                    ClusterSelector = new ClusterSelector
                    {
                        Zone = "zone255f4ea8",
                        ClusterLabels =
                        {
                            {
                                "key8a0b6e3c",
                                "value60c16320"
                            },
                        },
                    },
                },
                Jobs =
                {
                    new OrderedJob
                    {
                        StepId = "step_idd291f4be",
                        HadoopJob = new HadoopJob
                        {
                            MainJarFileUri = "main_jar_file_uri46ea7aa7",
                            MainClass = "main_classb0f4e864",
                            Args = { "args09af56a9", },
                            JarFileUris =
                            {
                                "jar_file_urisfcd646b7",
                            },
                            FileUris =
                            {
                                "file_urisbcc83e18",
                            },
                            ArchiveUris =
                            {
                                "archive_uris5a747dda",
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                        },
                        SparkJob = new SparkJob
                        {
                            MainJarFileUri = "main_jar_file_uri46ea7aa7",
                            MainClass = "main_classb0f4e864",
                            Args = { "args09af56a9", },
                            JarFileUris =
                            {
                                "jar_file_urisfcd646b7",
                            },
                            FileUris =
                            {
                                "file_urisbcc83e18",
                            },
                            ArchiveUris =
                            {
                                "archive_uris5a747dda",
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                        },
                        PysparkJob = new PySparkJob
                        {
                            MainPythonFileUri = "main_python_file_uri14aabff5",
                            Args = { "args09af56a9", },
                            PythonFileUris =
                            {
                                "python_file_uris30483b38",
                            },
                            JarFileUris =
                            {
                                "jar_file_urisfcd646b7",
                            },
                            FileUris =
                            {
                                "file_urisbcc83e18",
                            },
                            ArchiveUris =
                            {
                                "archive_uris5a747dda",
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                        },
                        HiveJob = new HiveJob
                        {
                            QueryFileUri = "query_file_urid4d84faf",
                            QueryList = new QueryList
                            {
                                Queries = { "queries42eba75d", },
                            },
                            ContinueOnFailure = false,
                            ScriptVariables =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            JarFileUris =
                            {
                                "jar_file_urisfcd646b7",
                            },
                        },
                        PigJob = new PigJob
                        {
                            QueryFileUri = "query_file_urid4d84faf",
                            QueryList = new QueryList
                            {
                                Queries = { "queries42eba75d", },
                            },
                            ContinueOnFailure = false,
                            ScriptVariables =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            JarFileUris =
                            {
                                "jar_file_urisfcd646b7",
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                        },
                        SparkSqlJob = new SparkSqlJob
                        {
                            QueryFileUri = "query_file_urid4d84faf",
                            QueryList = new QueryList
                            {
                                Queries = { "queries42eba75d", },
                            },
                            ScriptVariables =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                            JarFileUris =
                            {
                                "jar_file_urisfcd646b7",
                            },
                        },
                        Labels =
                        {
                            {
                                "key8a0b6e3c",
                                "value60c16320"
                            },
                        },
                        Scheduling = new JobScheduling
                        {
                            MaxFailuresPerHour = 238137428,
                        },
                        PrerequisiteStepIds =
                        {
                            "prerequisite_step_ids4753a371",
                        },
                        SparkRJob = new SparkRJob
                        {
                            MainRFileUri = "main_r_file_uri3c1a03d8",
                            Args = { "args09af56a9", },
                            FileUris =
                            {
                                "file_urisbcc83e18",
                            },
                            ArchiveUris =
                            {
                                "archive_uris5a747dda",
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                        },
                        PrestoJob = new PrestoJob
                        {
                            QueryFileUri = "query_file_urid4d84faf",
                            QueryList = new QueryList
                            {
                                Queries = { "queries42eba75d", },
                            },
                            ContinueOnFailure = false,
                            OutputFormat = "output_format020eca50",
                            ClientTags =
                            {
                                "client_tags74c9d57e",
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                        },
                    },
                },
                Parameters =
                {
                    new TemplateParameter
                    {
                        Name = "name1c9368b0",
                        Fields = { "fieldsd76e5bd0", },
                        Description = "description2cf9da67",
                        Validation = new ParameterValidation
                        {
                            Regex = new RegexValidation
                            {
                                Regexes = { "regexes5cb111ce", },
                            },
                            Values = new ValueValidation
                            {
                                Values = { "valueseec79cf0", },
                            },
                        },
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CreateWorkflowTemplateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<WorkflowTemplate>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            WorkflowTemplateServiceClient client = new WorkflowTemplateServiceClientImpl(mockGrpcClient.Object, null);
            WorkflowTemplate responseCallSettings = await client.CreateWorkflowTemplateAsync(request.ParentAsLocationName, request.Template, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            WorkflowTemplate responseCancellationToken = await client.CreateWorkflowTemplateAsync(request.ParentAsLocationName, request.Template, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetWorkflowTemplateRequestObject()
        {
            moq::Mock<WorkflowTemplateService.WorkflowTemplateServiceClient> mockGrpcClient = new moq::Mock<WorkflowTemplateService.WorkflowTemplateServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetWorkflowTemplateRequest request = new GetWorkflowTemplateRequest
            {
                WorkflowTemplateName = WorkflowTemplateName.FromProjectRegionWorkflowTemplate("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]"),
                Version = 271578922,
            };
            WorkflowTemplate expectedResponse = new WorkflowTemplate
            {
                WorkflowTemplateName = WorkflowTemplateName.FromProjectRegionWorkflowTemplate("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]"),
                Id = "id74b70bb8",
                Version = 271578922,
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                UpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Placement = new WorkflowTemplatePlacement
                {
                    ManagedCluster = new ManagedCluster
                    {
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
                        Labels =
                        {
                            {
                                "key8a0b6e3c",
                                "value60c16320"
                            },
                        },
                    },
                    ClusterSelector = new ClusterSelector
                    {
                        Zone = "zone255f4ea8",
                        ClusterLabels =
                        {
                            {
                                "key8a0b6e3c",
                                "value60c16320"
                            },
                        },
                    },
                },
                Jobs =
                {
                    new OrderedJob
                    {
                        StepId = "step_idd291f4be",
                        HadoopJob = new HadoopJob
                        {
                            MainJarFileUri = "main_jar_file_uri46ea7aa7",
                            MainClass = "main_classb0f4e864",
                            Args = { "args09af56a9", },
                            JarFileUris =
                            {
                                "jar_file_urisfcd646b7",
                            },
                            FileUris =
                            {
                                "file_urisbcc83e18",
                            },
                            ArchiveUris =
                            {
                                "archive_uris5a747dda",
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                        },
                        SparkJob = new SparkJob
                        {
                            MainJarFileUri = "main_jar_file_uri46ea7aa7",
                            MainClass = "main_classb0f4e864",
                            Args = { "args09af56a9", },
                            JarFileUris =
                            {
                                "jar_file_urisfcd646b7",
                            },
                            FileUris =
                            {
                                "file_urisbcc83e18",
                            },
                            ArchiveUris =
                            {
                                "archive_uris5a747dda",
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                        },
                        PysparkJob = new PySparkJob
                        {
                            MainPythonFileUri = "main_python_file_uri14aabff5",
                            Args = { "args09af56a9", },
                            PythonFileUris =
                            {
                                "python_file_uris30483b38",
                            },
                            JarFileUris =
                            {
                                "jar_file_urisfcd646b7",
                            },
                            FileUris =
                            {
                                "file_urisbcc83e18",
                            },
                            ArchiveUris =
                            {
                                "archive_uris5a747dda",
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                        },
                        HiveJob = new HiveJob
                        {
                            QueryFileUri = "query_file_urid4d84faf",
                            QueryList = new QueryList
                            {
                                Queries = { "queries42eba75d", },
                            },
                            ContinueOnFailure = false,
                            ScriptVariables =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            JarFileUris =
                            {
                                "jar_file_urisfcd646b7",
                            },
                        },
                        PigJob = new PigJob
                        {
                            QueryFileUri = "query_file_urid4d84faf",
                            QueryList = new QueryList
                            {
                                Queries = { "queries42eba75d", },
                            },
                            ContinueOnFailure = false,
                            ScriptVariables =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            JarFileUris =
                            {
                                "jar_file_urisfcd646b7",
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                        },
                        SparkSqlJob = new SparkSqlJob
                        {
                            QueryFileUri = "query_file_urid4d84faf",
                            QueryList = new QueryList
                            {
                                Queries = { "queries42eba75d", },
                            },
                            ScriptVariables =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                            JarFileUris =
                            {
                                "jar_file_urisfcd646b7",
                            },
                        },
                        Labels =
                        {
                            {
                                "key8a0b6e3c",
                                "value60c16320"
                            },
                        },
                        Scheduling = new JobScheduling
                        {
                            MaxFailuresPerHour = 238137428,
                        },
                        PrerequisiteStepIds =
                        {
                            "prerequisite_step_ids4753a371",
                        },
                        SparkRJob = new SparkRJob
                        {
                            MainRFileUri = "main_r_file_uri3c1a03d8",
                            Args = { "args09af56a9", },
                            FileUris =
                            {
                                "file_urisbcc83e18",
                            },
                            ArchiveUris =
                            {
                                "archive_uris5a747dda",
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                        },
                        PrestoJob = new PrestoJob
                        {
                            QueryFileUri = "query_file_urid4d84faf",
                            QueryList = new QueryList
                            {
                                Queries = { "queries42eba75d", },
                            },
                            ContinueOnFailure = false,
                            OutputFormat = "output_format020eca50",
                            ClientTags =
                            {
                                "client_tags74c9d57e",
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                        },
                    },
                },
                Parameters =
                {
                    new TemplateParameter
                    {
                        Name = "name1c9368b0",
                        Fields = { "fieldsd76e5bd0", },
                        Description = "description2cf9da67",
                        Validation = new ParameterValidation
                        {
                            Regex = new RegexValidation
                            {
                                Regexes = { "regexes5cb111ce", },
                            },
                            Values = new ValueValidation
                            {
                                Values = { "valueseec79cf0", },
                            },
                        },
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetWorkflowTemplate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            WorkflowTemplateServiceClient client = new WorkflowTemplateServiceClientImpl(mockGrpcClient.Object, null);
            WorkflowTemplate response = client.GetWorkflowTemplate(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetWorkflowTemplateRequestObjectAsync()
        {
            moq::Mock<WorkflowTemplateService.WorkflowTemplateServiceClient> mockGrpcClient = new moq::Mock<WorkflowTemplateService.WorkflowTemplateServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetWorkflowTemplateRequest request = new GetWorkflowTemplateRequest
            {
                WorkflowTemplateName = WorkflowTemplateName.FromProjectRegionWorkflowTemplate("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]"),
                Version = 271578922,
            };
            WorkflowTemplate expectedResponse = new WorkflowTemplate
            {
                WorkflowTemplateName = WorkflowTemplateName.FromProjectRegionWorkflowTemplate("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]"),
                Id = "id74b70bb8",
                Version = 271578922,
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                UpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Placement = new WorkflowTemplatePlacement
                {
                    ManagedCluster = new ManagedCluster
                    {
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
                        Labels =
                        {
                            {
                                "key8a0b6e3c",
                                "value60c16320"
                            },
                        },
                    },
                    ClusterSelector = new ClusterSelector
                    {
                        Zone = "zone255f4ea8",
                        ClusterLabels =
                        {
                            {
                                "key8a0b6e3c",
                                "value60c16320"
                            },
                        },
                    },
                },
                Jobs =
                {
                    new OrderedJob
                    {
                        StepId = "step_idd291f4be",
                        HadoopJob = new HadoopJob
                        {
                            MainJarFileUri = "main_jar_file_uri46ea7aa7",
                            MainClass = "main_classb0f4e864",
                            Args = { "args09af56a9", },
                            JarFileUris =
                            {
                                "jar_file_urisfcd646b7",
                            },
                            FileUris =
                            {
                                "file_urisbcc83e18",
                            },
                            ArchiveUris =
                            {
                                "archive_uris5a747dda",
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                        },
                        SparkJob = new SparkJob
                        {
                            MainJarFileUri = "main_jar_file_uri46ea7aa7",
                            MainClass = "main_classb0f4e864",
                            Args = { "args09af56a9", },
                            JarFileUris =
                            {
                                "jar_file_urisfcd646b7",
                            },
                            FileUris =
                            {
                                "file_urisbcc83e18",
                            },
                            ArchiveUris =
                            {
                                "archive_uris5a747dda",
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                        },
                        PysparkJob = new PySparkJob
                        {
                            MainPythonFileUri = "main_python_file_uri14aabff5",
                            Args = { "args09af56a9", },
                            PythonFileUris =
                            {
                                "python_file_uris30483b38",
                            },
                            JarFileUris =
                            {
                                "jar_file_urisfcd646b7",
                            },
                            FileUris =
                            {
                                "file_urisbcc83e18",
                            },
                            ArchiveUris =
                            {
                                "archive_uris5a747dda",
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                        },
                        HiveJob = new HiveJob
                        {
                            QueryFileUri = "query_file_urid4d84faf",
                            QueryList = new QueryList
                            {
                                Queries = { "queries42eba75d", },
                            },
                            ContinueOnFailure = false,
                            ScriptVariables =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            JarFileUris =
                            {
                                "jar_file_urisfcd646b7",
                            },
                        },
                        PigJob = new PigJob
                        {
                            QueryFileUri = "query_file_urid4d84faf",
                            QueryList = new QueryList
                            {
                                Queries = { "queries42eba75d", },
                            },
                            ContinueOnFailure = false,
                            ScriptVariables =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            JarFileUris =
                            {
                                "jar_file_urisfcd646b7",
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                        },
                        SparkSqlJob = new SparkSqlJob
                        {
                            QueryFileUri = "query_file_urid4d84faf",
                            QueryList = new QueryList
                            {
                                Queries = { "queries42eba75d", },
                            },
                            ScriptVariables =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                            JarFileUris =
                            {
                                "jar_file_urisfcd646b7",
                            },
                        },
                        Labels =
                        {
                            {
                                "key8a0b6e3c",
                                "value60c16320"
                            },
                        },
                        Scheduling = new JobScheduling
                        {
                            MaxFailuresPerHour = 238137428,
                        },
                        PrerequisiteStepIds =
                        {
                            "prerequisite_step_ids4753a371",
                        },
                        SparkRJob = new SparkRJob
                        {
                            MainRFileUri = "main_r_file_uri3c1a03d8",
                            Args = { "args09af56a9", },
                            FileUris =
                            {
                                "file_urisbcc83e18",
                            },
                            ArchiveUris =
                            {
                                "archive_uris5a747dda",
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                        },
                        PrestoJob = new PrestoJob
                        {
                            QueryFileUri = "query_file_urid4d84faf",
                            QueryList = new QueryList
                            {
                                Queries = { "queries42eba75d", },
                            },
                            ContinueOnFailure = false,
                            OutputFormat = "output_format020eca50",
                            ClientTags =
                            {
                                "client_tags74c9d57e",
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                        },
                    },
                },
                Parameters =
                {
                    new TemplateParameter
                    {
                        Name = "name1c9368b0",
                        Fields = { "fieldsd76e5bd0", },
                        Description = "description2cf9da67",
                        Validation = new ParameterValidation
                        {
                            Regex = new RegexValidation
                            {
                                Regexes = { "regexes5cb111ce", },
                            },
                            Values = new ValueValidation
                            {
                                Values = { "valueseec79cf0", },
                            },
                        },
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetWorkflowTemplateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<WorkflowTemplate>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            WorkflowTemplateServiceClient client = new WorkflowTemplateServiceClientImpl(mockGrpcClient.Object, null);
            WorkflowTemplate responseCallSettings = await client.GetWorkflowTemplateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            WorkflowTemplate responseCancellationToken = await client.GetWorkflowTemplateAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetWorkflowTemplate()
        {
            moq::Mock<WorkflowTemplateService.WorkflowTemplateServiceClient> mockGrpcClient = new moq::Mock<WorkflowTemplateService.WorkflowTemplateServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetWorkflowTemplateRequest request = new GetWorkflowTemplateRequest
            {
                WorkflowTemplateName = WorkflowTemplateName.FromProjectRegionWorkflowTemplate("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]"),
            };
            WorkflowTemplate expectedResponse = new WorkflowTemplate
            {
                WorkflowTemplateName = WorkflowTemplateName.FromProjectRegionWorkflowTemplate("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]"),
                Id = "id74b70bb8",
                Version = 271578922,
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                UpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Placement = new WorkflowTemplatePlacement
                {
                    ManagedCluster = new ManagedCluster
                    {
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
                        Labels =
                        {
                            {
                                "key8a0b6e3c",
                                "value60c16320"
                            },
                        },
                    },
                    ClusterSelector = new ClusterSelector
                    {
                        Zone = "zone255f4ea8",
                        ClusterLabels =
                        {
                            {
                                "key8a0b6e3c",
                                "value60c16320"
                            },
                        },
                    },
                },
                Jobs =
                {
                    new OrderedJob
                    {
                        StepId = "step_idd291f4be",
                        HadoopJob = new HadoopJob
                        {
                            MainJarFileUri = "main_jar_file_uri46ea7aa7",
                            MainClass = "main_classb0f4e864",
                            Args = { "args09af56a9", },
                            JarFileUris =
                            {
                                "jar_file_urisfcd646b7",
                            },
                            FileUris =
                            {
                                "file_urisbcc83e18",
                            },
                            ArchiveUris =
                            {
                                "archive_uris5a747dda",
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                        },
                        SparkJob = new SparkJob
                        {
                            MainJarFileUri = "main_jar_file_uri46ea7aa7",
                            MainClass = "main_classb0f4e864",
                            Args = { "args09af56a9", },
                            JarFileUris =
                            {
                                "jar_file_urisfcd646b7",
                            },
                            FileUris =
                            {
                                "file_urisbcc83e18",
                            },
                            ArchiveUris =
                            {
                                "archive_uris5a747dda",
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                        },
                        PysparkJob = new PySparkJob
                        {
                            MainPythonFileUri = "main_python_file_uri14aabff5",
                            Args = { "args09af56a9", },
                            PythonFileUris =
                            {
                                "python_file_uris30483b38",
                            },
                            JarFileUris =
                            {
                                "jar_file_urisfcd646b7",
                            },
                            FileUris =
                            {
                                "file_urisbcc83e18",
                            },
                            ArchiveUris =
                            {
                                "archive_uris5a747dda",
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                        },
                        HiveJob = new HiveJob
                        {
                            QueryFileUri = "query_file_urid4d84faf",
                            QueryList = new QueryList
                            {
                                Queries = { "queries42eba75d", },
                            },
                            ContinueOnFailure = false,
                            ScriptVariables =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            JarFileUris =
                            {
                                "jar_file_urisfcd646b7",
                            },
                        },
                        PigJob = new PigJob
                        {
                            QueryFileUri = "query_file_urid4d84faf",
                            QueryList = new QueryList
                            {
                                Queries = { "queries42eba75d", },
                            },
                            ContinueOnFailure = false,
                            ScriptVariables =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            JarFileUris =
                            {
                                "jar_file_urisfcd646b7",
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                        },
                        SparkSqlJob = new SparkSqlJob
                        {
                            QueryFileUri = "query_file_urid4d84faf",
                            QueryList = new QueryList
                            {
                                Queries = { "queries42eba75d", },
                            },
                            ScriptVariables =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                            JarFileUris =
                            {
                                "jar_file_urisfcd646b7",
                            },
                        },
                        Labels =
                        {
                            {
                                "key8a0b6e3c",
                                "value60c16320"
                            },
                        },
                        Scheduling = new JobScheduling
                        {
                            MaxFailuresPerHour = 238137428,
                        },
                        PrerequisiteStepIds =
                        {
                            "prerequisite_step_ids4753a371",
                        },
                        SparkRJob = new SparkRJob
                        {
                            MainRFileUri = "main_r_file_uri3c1a03d8",
                            Args = { "args09af56a9", },
                            FileUris =
                            {
                                "file_urisbcc83e18",
                            },
                            ArchiveUris =
                            {
                                "archive_uris5a747dda",
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                        },
                        PrestoJob = new PrestoJob
                        {
                            QueryFileUri = "query_file_urid4d84faf",
                            QueryList = new QueryList
                            {
                                Queries = { "queries42eba75d", },
                            },
                            ContinueOnFailure = false,
                            OutputFormat = "output_format020eca50",
                            ClientTags =
                            {
                                "client_tags74c9d57e",
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                        },
                    },
                },
                Parameters =
                {
                    new TemplateParameter
                    {
                        Name = "name1c9368b0",
                        Fields = { "fieldsd76e5bd0", },
                        Description = "description2cf9da67",
                        Validation = new ParameterValidation
                        {
                            Regex = new RegexValidation
                            {
                                Regexes = { "regexes5cb111ce", },
                            },
                            Values = new ValueValidation
                            {
                                Values = { "valueseec79cf0", },
                            },
                        },
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetWorkflowTemplate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            WorkflowTemplateServiceClient client = new WorkflowTemplateServiceClientImpl(mockGrpcClient.Object, null);
            WorkflowTemplate response = client.GetWorkflowTemplate(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetWorkflowTemplateAsync()
        {
            moq::Mock<WorkflowTemplateService.WorkflowTemplateServiceClient> mockGrpcClient = new moq::Mock<WorkflowTemplateService.WorkflowTemplateServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetWorkflowTemplateRequest request = new GetWorkflowTemplateRequest
            {
                WorkflowTemplateName = WorkflowTemplateName.FromProjectRegionWorkflowTemplate("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]"),
            };
            WorkflowTemplate expectedResponse = new WorkflowTemplate
            {
                WorkflowTemplateName = WorkflowTemplateName.FromProjectRegionWorkflowTemplate("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]"),
                Id = "id74b70bb8",
                Version = 271578922,
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                UpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Placement = new WorkflowTemplatePlacement
                {
                    ManagedCluster = new ManagedCluster
                    {
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
                        Labels =
                        {
                            {
                                "key8a0b6e3c",
                                "value60c16320"
                            },
                        },
                    },
                    ClusterSelector = new ClusterSelector
                    {
                        Zone = "zone255f4ea8",
                        ClusterLabels =
                        {
                            {
                                "key8a0b6e3c",
                                "value60c16320"
                            },
                        },
                    },
                },
                Jobs =
                {
                    new OrderedJob
                    {
                        StepId = "step_idd291f4be",
                        HadoopJob = new HadoopJob
                        {
                            MainJarFileUri = "main_jar_file_uri46ea7aa7",
                            MainClass = "main_classb0f4e864",
                            Args = { "args09af56a9", },
                            JarFileUris =
                            {
                                "jar_file_urisfcd646b7",
                            },
                            FileUris =
                            {
                                "file_urisbcc83e18",
                            },
                            ArchiveUris =
                            {
                                "archive_uris5a747dda",
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                        },
                        SparkJob = new SparkJob
                        {
                            MainJarFileUri = "main_jar_file_uri46ea7aa7",
                            MainClass = "main_classb0f4e864",
                            Args = { "args09af56a9", },
                            JarFileUris =
                            {
                                "jar_file_urisfcd646b7",
                            },
                            FileUris =
                            {
                                "file_urisbcc83e18",
                            },
                            ArchiveUris =
                            {
                                "archive_uris5a747dda",
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                        },
                        PysparkJob = new PySparkJob
                        {
                            MainPythonFileUri = "main_python_file_uri14aabff5",
                            Args = { "args09af56a9", },
                            PythonFileUris =
                            {
                                "python_file_uris30483b38",
                            },
                            JarFileUris =
                            {
                                "jar_file_urisfcd646b7",
                            },
                            FileUris =
                            {
                                "file_urisbcc83e18",
                            },
                            ArchiveUris =
                            {
                                "archive_uris5a747dda",
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                        },
                        HiveJob = new HiveJob
                        {
                            QueryFileUri = "query_file_urid4d84faf",
                            QueryList = new QueryList
                            {
                                Queries = { "queries42eba75d", },
                            },
                            ContinueOnFailure = false,
                            ScriptVariables =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            JarFileUris =
                            {
                                "jar_file_urisfcd646b7",
                            },
                        },
                        PigJob = new PigJob
                        {
                            QueryFileUri = "query_file_urid4d84faf",
                            QueryList = new QueryList
                            {
                                Queries = { "queries42eba75d", },
                            },
                            ContinueOnFailure = false,
                            ScriptVariables =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            JarFileUris =
                            {
                                "jar_file_urisfcd646b7",
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                        },
                        SparkSqlJob = new SparkSqlJob
                        {
                            QueryFileUri = "query_file_urid4d84faf",
                            QueryList = new QueryList
                            {
                                Queries = { "queries42eba75d", },
                            },
                            ScriptVariables =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                            JarFileUris =
                            {
                                "jar_file_urisfcd646b7",
                            },
                        },
                        Labels =
                        {
                            {
                                "key8a0b6e3c",
                                "value60c16320"
                            },
                        },
                        Scheduling = new JobScheduling
                        {
                            MaxFailuresPerHour = 238137428,
                        },
                        PrerequisiteStepIds =
                        {
                            "prerequisite_step_ids4753a371",
                        },
                        SparkRJob = new SparkRJob
                        {
                            MainRFileUri = "main_r_file_uri3c1a03d8",
                            Args = { "args09af56a9", },
                            FileUris =
                            {
                                "file_urisbcc83e18",
                            },
                            ArchiveUris =
                            {
                                "archive_uris5a747dda",
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                        },
                        PrestoJob = new PrestoJob
                        {
                            QueryFileUri = "query_file_urid4d84faf",
                            QueryList = new QueryList
                            {
                                Queries = { "queries42eba75d", },
                            },
                            ContinueOnFailure = false,
                            OutputFormat = "output_format020eca50",
                            ClientTags =
                            {
                                "client_tags74c9d57e",
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                        },
                    },
                },
                Parameters =
                {
                    new TemplateParameter
                    {
                        Name = "name1c9368b0",
                        Fields = { "fieldsd76e5bd0", },
                        Description = "description2cf9da67",
                        Validation = new ParameterValidation
                        {
                            Regex = new RegexValidation
                            {
                                Regexes = { "regexes5cb111ce", },
                            },
                            Values = new ValueValidation
                            {
                                Values = { "valueseec79cf0", },
                            },
                        },
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetWorkflowTemplateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<WorkflowTemplate>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            WorkflowTemplateServiceClient client = new WorkflowTemplateServiceClientImpl(mockGrpcClient.Object, null);
            WorkflowTemplate responseCallSettings = await client.GetWorkflowTemplateAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            WorkflowTemplate responseCancellationToken = await client.GetWorkflowTemplateAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetWorkflowTemplateResourceNames()
        {
            moq::Mock<WorkflowTemplateService.WorkflowTemplateServiceClient> mockGrpcClient = new moq::Mock<WorkflowTemplateService.WorkflowTemplateServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetWorkflowTemplateRequest request = new GetWorkflowTemplateRequest
            {
                WorkflowTemplateName = WorkflowTemplateName.FromProjectRegionWorkflowTemplate("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]"),
            };
            WorkflowTemplate expectedResponse = new WorkflowTemplate
            {
                WorkflowTemplateName = WorkflowTemplateName.FromProjectRegionWorkflowTemplate("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]"),
                Id = "id74b70bb8",
                Version = 271578922,
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                UpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Placement = new WorkflowTemplatePlacement
                {
                    ManagedCluster = new ManagedCluster
                    {
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
                        Labels =
                        {
                            {
                                "key8a0b6e3c",
                                "value60c16320"
                            },
                        },
                    },
                    ClusterSelector = new ClusterSelector
                    {
                        Zone = "zone255f4ea8",
                        ClusterLabels =
                        {
                            {
                                "key8a0b6e3c",
                                "value60c16320"
                            },
                        },
                    },
                },
                Jobs =
                {
                    new OrderedJob
                    {
                        StepId = "step_idd291f4be",
                        HadoopJob = new HadoopJob
                        {
                            MainJarFileUri = "main_jar_file_uri46ea7aa7",
                            MainClass = "main_classb0f4e864",
                            Args = { "args09af56a9", },
                            JarFileUris =
                            {
                                "jar_file_urisfcd646b7",
                            },
                            FileUris =
                            {
                                "file_urisbcc83e18",
                            },
                            ArchiveUris =
                            {
                                "archive_uris5a747dda",
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                        },
                        SparkJob = new SparkJob
                        {
                            MainJarFileUri = "main_jar_file_uri46ea7aa7",
                            MainClass = "main_classb0f4e864",
                            Args = { "args09af56a9", },
                            JarFileUris =
                            {
                                "jar_file_urisfcd646b7",
                            },
                            FileUris =
                            {
                                "file_urisbcc83e18",
                            },
                            ArchiveUris =
                            {
                                "archive_uris5a747dda",
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                        },
                        PysparkJob = new PySparkJob
                        {
                            MainPythonFileUri = "main_python_file_uri14aabff5",
                            Args = { "args09af56a9", },
                            PythonFileUris =
                            {
                                "python_file_uris30483b38",
                            },
                            JarFileUris =
                            {
                                "jar_file_urisfcd646b7",
                            },
                            FileUris =
                            {
                                "file_urisbcc83e18",
                            },
                            ArchiveUris =
                            {
                                "archive_uris5a747dda",
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                        },
                        HiveJob = new HiveJob
                        {
                            QueryFileUri = "query_file_urid4d84faf",
                            QueryList = new QueryList
                            {
                                Queries = { "queries42eba75d", },
                            },
                            ContinueOnFailure = false,
                            ScriptVariables =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            JarFileUris =
                            {
                                "jar_file_urisfcd646b7",
                            },
                        },
                        PigJob = new PigJob
                        {
                            QueryFileUri = "query_file_urid4d84faf",
                            QueryList = new QueryList
                            {
                                Queries = { "queries42eba75d", },
                            },
                            ContinueOnFailure = false,
                            ScriptVariables =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            JarFileUris =
                            {
                                "jar_file_urisfcd646b7",
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                        },
                        SparkSqlJob = new SparkSqlJob
                        {
                            QueryFileUri = "query_file_urid4d84faf",
                            QueryList = new QueryList
                            {
                                Queries = { "queries42eba75d", },
                            },
                            ScriptVariables =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                            JarFileUris =
                            {
                                "jar_file_urisfcd646b7",
                            },
                        },
                        Labels =
                        {
                            {
                                "key8a0b6e3c",
                                "value60c16320"
                            },
                        },
                        Scheduling = new JobScheduling
                        {
                            MaxFailuresPerHour = 238137428,
                        },
                        PrerequisiteStepIds =
                        {
                            "prerequisite_step_ids4753a371",
                        },
                        SparkRJob = new SparkRJob
                        {
                            MainRFileUri = "main_r_file_uri3c1a03d8",
                            Args = { "args09af56a9", },
                            FileUris =
                            {
                                "file_urisbcc83e18",
                            },
                            ArchiveUris =
                            {
                                "archive_uris5a747dda",
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                        },
                        PrestoJob = new PrestoJob
                        {
                            QueryFileUri = "query_file_urid4d84faf",
                            QueryList = new QueryList
                            {
                                Queries = { "queries42eba75d", },
                            },
                            ContinueOnFailure = false,
                            OutputFormat = "output_format020eca50",
                            ClientTags =
                            {
                                "client_tags74c9d57e",
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                        },
                    },
                },
                Parameters =
                {
                    new TemplateParameter
                    {
                        Name = "name1c9368b0",
                        Fields = { "fieldsd76e5bd0", },
                        Description = "description2cf9da67",
                        Validation = new ParameterValidation
                        {
                            Regex = new RegexValidation
                            {
                                Regexes = { "regexes5cb111ce", },
                            },
                            Values = new ValueValidation
                            {
                                Values = { "valueseec79cf0", },
                            },
                        },
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetWorkflowTemplate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            WorkflowTemplateServiceClient client = new WorkflowTemplateServiceClientImpl(mockGrpcClient.Object, null);
            WorkflowTemplate response = client.GetWorkflowTemplate(request.WorkflowTemplateName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetWorkflowTemplateResourceNamesAsync()
        {
            moq::Mock<WorkflowTemplateService.WorkflowTemplateServiceClient> mockGrpcClient = new moq::Mock<WorkflowTemplateService.WorkflowTemplateServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetWorkflowTemplateRequest request = new GetWorkflowTemplateRequest
            {
                WorkflowTemplateName = WorkflowTemplateName.FromProjectRegionWorkflowTemplate("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]"),
            };
            WorkflowTemplate expectedResponse = new WorkflowTemplate
            {
                WorkflowTemplateName = WorkflowTemplateName.FromProjectRegionWorkflowTemplate("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]"),
                Id = "id74b70bb8",
                Version = 271578922,
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                UpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Placement = new WorkflowTemplatePlacement
                {
                    ManagedCluster = new ManagedCluster
                    {
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
                        Labels =
                        {
                            {
                                "key8a0b6e3c",
                                "value60c16320"
                            },
                        },
                    },
                    ClusterSelector = new ClusterSelector
                    {
                        Zone = "zone255f4ea8",
                        ClusterLabels =
                        {
                            {
                                "key8a0b6e3c",
                                "value60c16320"
                            },
                        },
                    },
                },
                Jobs =
                {
                    new OrderedJob
                    {
                        StepId = "step_idd291f4be",
                        HadoopJob = new HadoopJob
                        {
                            MainJarFileUri = "main_jar_file_uri46ea7aa7",
                            MainClass = "main_classb0f4e864",
                            Args = { "args09af56a9", },
                            JarFileUris =
                            {
                                "jar_file_urisfcd646b7",
                            },
                            FileUris =
                            {
                                "file_urisbcc83e18",
                            },
                            ArchiveUris =
                            {
                                "archive_uris5a747dda",
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                        },
                        SparkJob = new SparkJob
                        {
                            MainJarFileUri = "main_jar_file_uri46ea7aa7",
                            MainClass = "main_classb0f4e864",
                            Args = { "args09af56a9", },
                            JarFileUris =
                            {
                                "jar_file_urisfcd646b7",
                            },
                            FileUris =
                            {
                                "file_urisbcc83e18",
                            },
                            ArchiveUris =
                            {
                                "archive_uris5a747dda",
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                        },
                        PysparkJob = new PySparkJob
                        {
                            MainPythonFileUri = "main_python_file_uri14aabff5",
                            Args = { "args09af56a9", },
                            PythonFileUris =
                            {
                                "python_file_uris30483b38",
                            },
                            JarFileUris =
                            {
                                "jar_file_urisfcd646b7",
                            },
                            FileUris =
                            {
                                "file_urisbcc83e18",
                            },
                            ArchiveUris =
                            {
                                "archive_uris5a747dda",
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                        },
                        HiveJob = new HiveJob
                        {
                            QueryFileUri = "query_file_urid4d84faf",
                            QueryList = new QueryList
                            {
                                Queries = { "queries42eba75d", },
                            },
                            ContinueOnFailure = false,
                            ScriptVariables =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            JarFileUris =
                            {
                                "jar_file_urisfcd646b7",
                            },
                        },
                        PigJob = new PigJob
                        {
                            QueryFileUri = "query_file_urid4d84faf",
                            QueryList = new QueryList
                            {
                                Queries = { "queries42eba75d", },
                            },
                            ContinueOnFailure = false,
                            ScriptVariables =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            JarFileUris =
                            {
                                "jar_file_urisfcd646b7",
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                        },
                        SparkSqlJob = new SparkSqlJob
                        {
                            QueryFileUri = "query_file_urid4d84faf",
                            QueryList = new QueryList
                            {
                                Queries = { "queries42eba75d", },
                            },
                            ScriptVariables =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                            JarFileUris =
                            {
                                "jar_file_urisfcd646b7",
                            },
                        },
                        Labels =
                        {
                            {
                                "key8a0b6e3c",
                                "value60c16320"
                            },
                        },
                        Scheduling = new JobScheduling
                        {
                            MaxFailuresPerHour = 238137428,
                        },
                        PrerequisiteStepIds =
                        {
                            "prerequisite_step_ids4753a371",
                        },
                        SparkRJob = new SparkRJob
                        {
                            MainRFileUri = "main_r_file_uri3c1a03d8",
                            Args = { "args09af56a9", },
                            FileUris =
                            {
                                "file_urisbcc83e18",
                            },
                            ArchiveUris =
                            {
                                "archive_uris5a747dda",
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                        },
                        PrestoJob = new PrestoJob
                        {
                            QueryFileUri = "query_file_urid4d84faf",
                            QueryList = new QueryList
                            {
                                Queries = { "queries42eba75d", },
                            },
                            ContinueOnFailure = false,
                            OutputFormat = "output_format020eca50",
                            ClientTags =
                            {
                                "client_tags74c9d57e",
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                        },
                    },
                },
                Parameters =
                {
                    new TemplateParameter
                    {
                        Name = "name1c9368b0",
                        Fields = { "fieldsd76e5bd0", },
                        Description = "description2cf9da67",
                        Validation = new ParameterValidation
                        {
                            Regex = new RegexValidation
                            {
                                Regexes = { "regexes5cb111ce", },
                            },
                            Values = new ValueValidation
                            {
                                Values = { "valueseec79cf0", },
                            },
                        },
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetWorkflowTemplateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<WorkflowTemplate>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            WorkflowTemplateServiceClient client = new WorkflowTemplateServiceClientImpl(mockGrpcClient.Object, null);
            WorkflowTemplate responseCallSettings = await client.GetWorkflowTemplateAsync(request.WorkflowTemplateName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            WorkflowTemplate responseCancellationToken = await client.GetWorkflowTemplateAsync(request.WorkflowTemplateName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateWorkflowTemplateRequestObject()
        {
            moq::Mock<WorkflowTemplateService.WorkflowTemplateServiceClient> mockGrpcClient = new moq::Mock<WorkflowTemplateService.WorkflowTemplateServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateWorkflowTemplateRequest request = new UpdateWorkflowTemplateRequest
            {
                Template = new WorkflowTemplate
                {
                    WorkflowTemplateName = WorkflowTemplateName.FromProjectRegionWorkflowTemplate("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]"),
                    Id = "id74b70bb8",
                    Version = 271578922,
                    CreateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    UpdateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    Labels =
                    {
                        {
                            "key8a0b6e3c",
                            "value60c16320"
                        },
                    },
                    Placement = new WorkflowTemplatePlacement
                    {
                        ManagedCluster = new ManagedCluster
                        {
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
                            Labels =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                        },
                        ClusterSelector = new ClusterSelector
                        {
                            Zone = "zone255f4ea8",
                            ClusterLabels =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                        },
                    },
                    Jobs =
                    {
                        new OrderedJob
                        {
                            StepId = "step_idd291f4be",
                            HadoopJob = new HadoopJob
                            {
                                MainJarFileUri = "main_jar_file_uri46ea7aa7",
                                MainClass = "main_classb0f4e864",
                                Args = { "args09af56a9", },
                                JarFileUris =
                                {
                                    "jar_file_urisfcd646b7",
                                },
                                FileUris =
                                {
                                    "file_urisbcc83e18",
                                },
                                ArchiveUris =
                                {
                                    "archive_uris5a747dda",
                                },
                                Properties =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                LoggingConfig = new LoggingConfig
                                {
                                    DriverLogLevels =
                                    {
                                        {
                                            "key8a0b6e3c",
                                            LoggingConfig.Types.Level.Debug
                                        },
                                    },
                                },
                            },
                            SparkJob = new SparkJob
                            {
                                MainJarFileUri = "main_jar_file_uri46ea7aa7",
                                MainClass = "main_classb0f4e864",
                                Args = { "args09af56a9", },
                                JarFileUris =
                                {
                                    "jar_file_urisfcd646b7",
                                },
                                FileUris =
                                {
                                    "file_urisbcc83e18",
                                },
                                ArchiveUris =
                                {
                                    "archive_uris5a747dda",
                                },
                                Properties =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                LoggingConfig = new LoggingConfig
                                {
                                    DriverLogLevels =
                                    {
                                        {
                                            "key8a0b6e3c",
                                            LoggingConfig.Types.Level.Debug
                                        },
                                    },
                                },
                            },
                            PysparkJob = new PySparkJob
                            {
                                MainPythonFileUri = "main_python_file_uri14aabff5",
                                Args = { "args09af56a9", },
                                PythonFileUris =
                                {
                                    "python_file_uris30483b38",
                                },
                                JarFileUris =
                                {
                                    "jar_file_urisfcd646b7",
                                },
                                FileUris =
                                {
                                    "file_urisbcc83e18",
                                },
                                ArchiveUris =
                                {
                                    "archive_uris5a747dda",
                                },
                                Properties =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                LoggingConfig = new LoggingConfig
                                {
                                    DriverLogLevels =
                                    {
                                        {
                                            "key8a0b6e3c",
                                            LoggingConfig.Types.Level.Debug
                                        },
                                    },
                                },
                            },
                            HiveJob = new HiveJob
                            {
                                QueryFileUri = "query_file_urid4d84faf",
                                QueryList = new QueryList
                                {
                                    Queries = { "queries42eba75d", },
                                },
                                ContinueOnFailure = false,
                                ScriptVariables =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                Properties =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                JarFileUris =
                                {
                                    "jar_file_urisfcd646b7",
                                },
                            },
                            PigJob = new PigJob
                            {
                                QueryFileUri = "query_file_urid4d84faf",
                                QueryList = new QueryList
                                {
                                    Queries = { "queries42eba75d", },
                                },
                                ContinueOnFailure = false,
                                ScriptVariables =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                Properties =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                JarFileUris =
                                {
                                    "jar_file_urisfcd646b7",
                                },
                                LoggingConfig = new LoggingConfig
                                {
                                    DriverLogLevels =
                                    {
                                        {
                                            "key8a0b6e3c",
                                            LoggingConfig.Types.Level.Debug
                                        },
                                    },
                                },
                            },
                            SparkSqlJob = new SparkSqlJob
                            {
                                QueryFileUri = "query_file_urid4d84faf",
                                QueryList = new QueryList
                                {
                                    Queries = { "queries42eba75d", },
                                },
                                ScriptVariables =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                Properties =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                LoggingConfig = new LoggingConfig
                                {
                                    DriverLogLevels =
                                    {
                                        {
                                            "key8a0b6e3c",
                                            LoggingConfig.Types.Level.Debug
                                        },
                                    },
                                },
                                JarFileUris =
                                {
                                    "jar_file_urisfcd646b7",
                                },
                            },
                            Labels =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            Scheduling = new JobScheduling
                            {
                                MaxFailuresPerHour = 238137428,
                            },
                            PrerequisiteStepIds =
                            {
                                "prerequisite_step_ids4753a371",
                            },
                            SparkRJob = new SparkRJob
                            {
                                MainRFileUri = "main_r_file_uri3c1a03d8",
                                Args = { "args09af56a9", },
                                FileUris =
                                {
                                    "file_urisbcc83e18",
                                },
                                ArchiveUris =
                                {
                                    "archive_uris5a747dda",
                                },
                                Properties =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                LoggingConfig = new LoggingConfig
                                {
                                    DriverLogLevels =
                                    {
                                        {
                                            "key8a0b6e3c",
                                            LoggingConfig.Types.Level.Debug
                                        },
                                    },
                                },
                            },
                            PrestoJob = new PrestoJob
                            {
                                QueryFileUri = "query_file_urid4d84faf",
                                QueryList = new QueryList
                                {
                                    Queries = { "queries42eba75d", },
                                },
                                ContinueOnFailure = false,
                                OutputFormat = "output_format020eca50",
                                ClientTags =
                                {
                                    "client_tags74c9d57e",
                                },
                                Properties =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                LoggingConfig = new LoggingConfig
                                {
                                    DriverLogLevels =
                                    {
                                        {
                                            "key8a0b6e3c",
                                            LoggingConfig.Types.Level.Debug
                                        },
                                    },
                                },
                            },
                        },
                    },
                    Parameters =
                    {
                        new TemplateParameter
                        {
                            Name = "name1c9368b0",
                            Fields = { "fieldsd76e5bd0", },
                            Description = "description2cf9da67",
                            Validation = new ParameterValidation
                            {
                                Regex = new RegexValidation
                                {
                                    Regexes = { "regexes5cb111ce", },
                                },
                                Values = new ValueValidation
                                {
                                    Values = { "valueseec79cf0", },
                                },
                            },
                        },
                    },
                },
            };
            WorkflowTemplate expectedResponse = new WorkflowTemplate
            {
                WorkflowTemplateName = WorkflowTemplateName.FromProjectRegionWorkflowTemplate("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]"),
                Id = "id74b70bb8",
                Version = 271578922,
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                UpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Placement = new WorkflowTemplatePlacement
                {
                    ManagedCluster = new ManagedCluster
                    {
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
                        Labels =
                        {
                            {
                                "key8a0b6e3c",
                                "value60c16320"
                            },
                        },
                    },
                    ClusterSelector = new ClusterSelector
                    {
                        Zone = "zone255f4ea8",
                        ClusterLabels =
                        {
                            {
                                "key8a0b6e3c",
                                "value60c16320"
                            },
                        },
                    },
                },
                Jobs =
                {
                    new OrderedJob
                    {
                        StepId = "step_idd291f4be",
                        HadoopJob = new HadoopJob
                        {
                            MainJarFileUri = "main_jar_file_uri46ea7aa7",
                            MainClass = "main_classb0f4e864",
                            Args = { "args09af56a9", },
                            JarFileUris =
                            {
                                "jar_file_urisfcd646b7",
                            },
                            FileUris =
                            {
                                "file_urisbcc83e18",
                            },
                            ArchiveUris =
                            {
                                "archive_uris5a747dda",
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                        },
                        SparkJob = new SparkJob
                        {
                            MainJarFileUri = "main_jar_file_uri46ea7aa7",
                            MainClass = "main_classb0f4e864",
                            Args = { "args09af56a9", },
                            JarFileUris =
                            {
                                "jar_file_urisfcd646b7",
                            },
                            FileUris =
                            {
                                "file_urisbcc83e18",
                            },
                            ArchiveUris =
                            {
                                "archive_uris5a747dda",
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                        },
                        PysparkJob = new PySparkJob
                        {
                            MainPythonFileUri = "main_python_file_uri14aabff5",
                            Args = { "args09af56a9", },
                            PythonFileUris =
                            {
                                "python_file_uris30483b38",
                            },
                            JarFileUris =
                            {
                                "jar_file_urisfcd646b7",
                            },
                            FileUris =
                            {
                                "file_urisbcc83e18",
                            },
                            ArchiveUris =
                            {
                                "archive_uris5a747dda",
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                        },
                        HiveJob = new HiveJob
                        {
                            QueryFileUri = "query_file_urid4d84faf",
                            QueryList = new QueryList
                            {
                                Queries = { "queries42eba75d", },
                            },
                            ContinueOnFailure = false,
                            ScriptVariables =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            JarFileUris =
                            {
                                "jar_file_urisfcd646b7",
                            },
                        },
                        PigJob = new PigJob
                        {
                            QueryFileUri = "query_file_urid4d84faf",
                            QueryList = new QueryList
                            {
                                Queries = { "queries42eba75d", },
                            },
                            ContinueOnFailure = false,
                            ScriptVariables =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            JarFileUris =
                            {
                                "jar_file_urisfcd646b7",
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                        },
                        SparkSqlJob = new SparkSqlJob
                        {
                            QueryFileUri = "query_file_urid4d84faf",
                            QueryList = new QueryList
                            {
                                Queries = { "queries42eba75d", },
                            },
                            ScriptVariables =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                            JarFileUris =
                            {
                                "jar_file_urisfcd646b7",
                            },
                        },
                        Labels =
                        {
                            {
                                "key8a0b6e3c",
                                "value60c16320"
                            },
                        },
                        Scheduling = new JobScheduling
                        {
                            MaxFailuresPerHour = 238137428,
                        },
                        PrerequisiteStepIds =
                        {
                            "prerequisite_step_ids4753a371",
                        },
                        SparkRJob = new SparkRJob
                        {
                            MainRFileUri = "main_r_file_uri3c1a03d8",
                            Args = { "args09af56a9", },
                            FileUris =
                            {
                                "file_urisbcc83e18",
                            },
                            ArchiveUris =
                            {
                                "archive_uris5a747dda",
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                        },
                        PrestoJob = new PrestoJob
                        {
                            QueryFileUri = "query_file_urid4d84faf",
                            QueryList = new QueryList
                            {
                                Queries = { "queries42eba75d", },
                            },
                            ContinueOnFailure = false,
                            OutputFormat = "output_format020eca50",
                            ClientTags =
                            {
                                "client_tags74c9d57e",
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                        },
                    },
                },
                Parameters =
                {
                    new TemplateParameter
                    {
                        Name = "name1c9368b0",
                        Fields = { "fieldsd76e5bd0", },
                        Description = "description2cf9da67",
                        Validation = new ParameterValidation
                        {
                            Regex = new RegexValidation
                            {
                                Regexes = { "regexes5cb111ce", },
                            },
                            Values = new ValueValidation
                            {
                                Values = { "valueseec79cf0", },
                            },
                        },
                    },
                },
            };
            mockGrpcClient.Setup(x => x.UpdateWorkflowTemplate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            WorkflowTemplateServiceClient client = new WorkflowTemplateServiceClientImpl(mockGrpcClient.Object, null);
            WorkflowTemplate response = client.UpdateWorkflowTemplate(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateWorkflowTemplateRequestObjectAsync()
        {
            moq::Mock<WorkflowTemplateService.WorkflowTemplateServiceClient> mockGrpcClient = new moq::Mock<WorkflowTemplateService.WorkflowTemplateServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateWorkflowTemplateRequest request = new UpdateWorkflowTemplateRequest
            {
                Template = new WorkflowTemplate
                {
                    WorkflowTemplateName = WorkflowTemplateName.FromProjectRegionWorkflowTemplate("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]"),
                    Id = "id74b70bb8",
                    Version = 271578922,
                    CreateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    UpdateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    Labels =
                    {
                        {
                            "key8a0b6e3c",
                            "value60c16320"
                        },
                    },
                    Placement = new WorkflowTemplatePlacement
                    {
                        ManagedCluster = new ManagedCluster
                        {
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
                            Labels =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                        },
                        ClusterSelector = new ClusterSelector
                        {
                            Zone = "zone255f4ea8",
                            ClusterLabels =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                        },
                    },
                    Jobs =
                    {
                        new OrderedJob
                        {
                            StepId = "step_idd291f4be",
                            HadoopJob = new HadoopJob
                            {
                                MainJarFileUri = "main_jar_file_uri46ea7aa7",
                                MainClass = "main_classb0f4e864",
                                Args = { "args09af56a9", },
                                JarFileUris =
                                {
                                    "jar_file_urisfcd646b7",
                                },
                                FileUris =
                                {
                                    "file_urisbcc83e18",
                                },
                                ArchiveUris =
                                {
                                    "archive_uris5a747dda",
                                },
                                Properties =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                LoggingConfig = new LoggingConfig
                                {
                                    DriverLogLevels =
                                    {
                                        {
                                            "key8a0b6e3c",
                                            LoggingConfig.Types.Level.Debug
                                        },
                                    },
                                },
                            },
                            SparkJob = new SparkJob
                            {
                                MainJarFileUri = "main_jar_file_uri46ea7aa7",
                                MainClass = "main_classb0f4e864",
                                Args = { "args09af56a9", },
                                JarFileUris =
                                {
                                    "jar_file_urisfcd646b7",
                                },
                                FileUris =
                                {
                                    "file_urisbcc83e18",
                                },
                                ArchiveUris =
                                {
                                    "archive_uris5a747dda",
                                },
                                Properties =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                LoggingConfig = new LoggingConfig
                                {
                                    DriverLogLevels =
                                    {
                                        {
                                            "key8a0b6e3c",
                                            LoggingConfig.Types.Level.Debug
                                        },
                                    },
                                },
                            },
                            PysparkJob = new PySparkJob
                            {
                                MainPythonFileUri = "main_python_file_uri14aabff5",
                                Args = { "args09af56a9", },
                                PythonFileUris =
                                {
                                    "python_file_uris30483b38",
                                },
                                JarFileUris =
                                {
                                    "jar_file_urisfcd646b7",
                                },
                                FileUris =
                                {
                                    "file_urisbcc83e18",
                                },
                                ArchiveUris =
                                {
                                    "archive_uris5a747dda",
                                },
                                Properties =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                LoggingConfig = new LoggingConfig
                                {
                                    DriverLogLevels =
                                    {
                                        {
                                            "key8a0b6e3c",
                                            LoggingConfig.Types.Level.Debug
                                        },
                                    },
                                },
                            },
                            HiveJob = new HiveJob
                            {
                                QueryFileUri = "query_file_urid4d84faf",
                                QueryList = new QueryList
                                {
                                    Queries = { "queries42eba75d", },
                                },
                                ContinueOnFailure = false,
                                ScriptVariables =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                Properties =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                JarFileUris =
                                {
                                    "jar_file_urisfcd646b7",
                                },
                            },
                            PigJob = new PigJob
                            {
                                QueryFileUri = "query_file_urid4d84faf",
                                QueryList = new QueryList
                                {
                                    Queries = { "queries42eba75d", },
                                },
                                ContinueOnFailure = false,
                                ScriptVariables =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                Properties =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                JarFileUris =
                                {
                                    "jar_file_urisfcd646b7",
                                },
                                LoggingConfig = new LoggingConfig
                                {
                                    DriverLogLevels =
                                    {
                                        {
                                            "key8a0b6e3c",
                                            LoggingConfig.Types.Level.Debug
                                        },
                                    },
                                },
                            },
                            SparkSqlJob = new SparkSqlJob
                            {
                                QueryFileUri = "query_file_urid4d84faf",
                                QueryList = new QueryList
                                {
                                    Queries = { "queries42eba75d", },
                                },
                                ScriptVariables =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                Properties =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                LoggingConfig = new LoggingConfig
                                {
                                    DriverLogLevels =
                                    {
                                        {
                                            "key8a0b6e3c",
                                            LoggingConfig.Types.Level.Debug
                                        },
                                    },
                                },
                                JarFileUris =
                                {
                                    "jar_file_urisfcd646b7",
                                },
                            },
                            Labels =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            Scheduling = new JobScheduling
                            {
                                MaxFailuresPerHour = 238137428,
                            },
                            PrerequisiteStepIds =
                            {
                                "prerequisite_step_ids4753a371",
                            },
                            SparkRJob = new SparkRJob
                            {
                                MainRFileUri = "main_r_file_uri3c1a03d8",
                                Args = { "args09af56a9", },
                                FileUris =
                                {
                                    "file_urisbcc83e18",
                                },
                                ArchiveUris =
                                {
                                    "archive_uris5a747dda",
                                },
                                Properties =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                LoggingConfig = new LoggingConfig
                                {
                                    DriverLogLevels =
                                    {
                                        {
                                            "key8a0b6e3c",
                                            LoggingConfig.Types.Level.Debug
                                        },
                                    },
                                },
                            },
                            PrestoJob = new PrestoJob
                            {
                                QueryFileUri = "query_file_urid4d84faf",
                                QueryList = new QueryList
                                {
                                    Queries = { "queries42eba75d", },
                                },
                                ContinueOnFailure = false,
                                OutputFormat = "output_format020eca50",
                                ClientTags =
                                {
                                    "client_tags74c9d57e",
                                },
                                Properties =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                LoggingConfig = new LoggingConfig
                                {
                                    DriverLogLevels =
                                    {
                                        {
                                            "key8a0b6e3c",
                                            LoggingConfig.Types.Level.Debug
                                        },
                                    },
                                },
                            },
                        },
                    },
                    Parameters =
                    {
                        new TemplateParameter
                        {
                            Name = "name1c9368b0",
                            Fields = { "fieldsd76e5bd0", },
                            Description = "description2cf9da67",
                            Validation = new ParameterValidation
                            {
                                Regex = new RegexValidation
                                {
                                    Regexes = { "regexes5cb111ce", },
                                },
                                Values = new ValueValidation
                                {
                                    Values = { "valueseec79cf0", },
                                },
                            },
                        },
                    },
                },
            };
            WorkflowTemplate expectedResponse = new WorkflowTemplate
            {
                WorkflowTemplateName = WorkflowTemplateName.FromProjectRegionWorkflowTemplate("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]"),
                Id = "id74b70bb8",
                Version = 271578922,
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                UpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Placement = new WorkflowTemplatePlacement
                {
                    ManagedCluster = new ManagedCluster
                    {
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
                        Labels =
                        {
                            {
                                "key8a0b6e3c",
                                "value60c16320"
                            },
                        },
                    },
                    ClusterSelector = new ClusterSelector
                    {
                        Zone = "zone255f4ea8",
                        ClusterLabels =
                        {
                            {
                                "key8a0b6e3c",
                                "value60c16320"
                            },
                        },
                    },
                },
                Jobs =
                {
                    new OrderedJob
                    {
                        StepId = "step_idd291f4be",
                        HadoopJob = new HadoopJob
                        {
                            MainJarFileUri = "main_jar_file_uri46ea7aa7",
                            MainClass = "main_classb0f4e864",
                            Args = { "args09af56a9", },
                            JarFileUris =
                            {
                                "jar_file_urisfcd646b7",
                            },
                            FileUris =
                            {
                                "file_urisbcc83e18",
                            },
                            ArchiveUris =
                            {
                                "archive_uris5a747dda",
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                        },
                        SparkJob = new SparkJob
                        {
                            MainJarFileUri = "main_jar_file_uri46ea7aa7",
                            MainClass = "main_classb0f4e864",
                            Args = { "args09af56a9", },
                            JarFileUris =
                            {
                                "jar_file_urisfcd646b7",
                            },
                            FileUris =
                            {
                                "file_urisbcc83e18",
                            },
                            ArchiveUris =
                            {
                                "archive_uris5a747dda",
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                        },
                        PysparkJob = new PySparkJob
                        {
                            MainPythonFileUri = "main_python_file_uri14aabff5",
                            Args = { "args09af56a9", },
                            PythonFileUris =
                            {
                                "python_file_uris30483b38",
                            },
                            JarFileUris =
                            {
                                "jar_file_urisfcd646b7",
                            },
                            FileUris =
                            {
                                "file_urisbcc83e18",
                            },
                            ArchiveUris =
                            {
                                "archive_uris5a747dda",
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                        },
                        HiveJob = new HiveJob
                        {
                            QueryFileUri = "query_file_urid4d84faf",
                            QueryList = new QueryList
                            {
                                Queries = { "queries42eba75d", },
                            },
                            ContinueOnFailure = false,
                            ScriptVariables =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            JarFileUris =
                            {
                                "jar_file_urisfcd646b7",
                            },
                        },
                        PigJob = new PigJob
                        {
                            QueryFileUri = "query_file_urid4d84faf",
                            QueryList = new QueryList
                            {
                                Queries = { "queries42eba75d", },
                            },
                            ContinueOnFailure = false,
                            ScriptVariables =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            JarFileUris =
                            {
                                "jar_file_urisfcd646b7",
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                        },
                        SparkSqlJob = new SparkSqlJob
                        {
                            QueryFileUri = "query_file_urid4d84faf",
                            QueryList = new QueryList
                            {
                                Queries = { "queries42eba75d", },
                            },
                            ScriptVariables =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                            JarFileUris =
                            {
                                "jar_file_urisfcd646b7",
                            },
                        },
                        Labels =
                        {
                            {
                                "key8a0b6e3c",
                                "value60c16320"
                            },
                        },
                        Scheduling = new JobScheduling
                        {
                            MaxFailuresPerHour = 238137428,
                        },
                        PrerequisiteStepIds =
                        {
                            "prerequisite_step_ids4753a371",
                        },
                        SparkRJob = new SparkRJob
                        {
                            MainRFileUri = "main_r_file_uri3c1a03d8",
                            Args = { "args09af56a9", },
                            FileUris =
                            {
                                "file_urisbcc83e18",
                            },
                            ArchiveUris =
                            {
                                "archive_uris5a747dda",
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                        },
                        PrestoJob = new PrestoJob
                        {
                            QueryFileUri = "query_file_urid4d84faf",
                            QueryList = new QueryList
                            {
                                Queries = { "queries42eba75d", },
                            },
                            ContinueOnFailure = false,
                            OutputFormat = "output_format020eca50",
                            ClientTags =
                            {
                                "client_tags74c9d57e",
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                        },
                    },
                },
                Parameters =
                {
                    new TemplateParameter
                    {
                        Name = "name1c9368b0",
                        Fields = { "fieldsd76e5bd0", },
                        Description = "description2cf9da67",
                        Validation = new ParameterValidation
                        {
                            Regex = new RegexValidation
                            {
                                Regexes = { "regexes5cb111ce", },
                            },
                            Values = new ValueValidation
                            {
                                Values = { "valueseec79cf0", },
                            },
                        },
                    },
                },
            };
            mockGrpcClient.Setup(x => x.UpdateWorkflowTemplateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<WorkflowTemplate>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            WorkflowTemplateServiceClient client = new WorkflowTemplateServiceClientImpl(mockGrpcClient.Object, null);
            WorkflowTemplate responseCallSettings = await client.UpdateWorkflowTemplateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            WorkflowTemplate responseCancellationToken = await client.UpdateWorkflowTemplateAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateWorkflowTemplate()
        {
            moq::Mock<WorkflowTemplateService.WorkflowTemplateServiceClient> mockGrpcClient = new moq::Mock<WorkflowTemplateService.WorkflowTemplateServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateWorkflowTemplateRequest request = new UpdateWorkflowTemplateRequest
            {
                Template = new WorkflowTemplate
                {
                    WorkflowTemplateName = WorkflowTemplateName.FromProjectRegionWorkflowTemplate("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]"),
                    Id = "id74b70bb8",
                    Version = 271578922,
                    CreateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    UpdateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    Labels =
                    {
                        {
                            "key8a0b6e3c",
                            "value60c16320"
                        },
                    },
                    Placement = new WorkflowTemplatePlacement
                    {
                        ManagedCluster = new ManagedCluster
                        {
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
                            Labels =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                        },
                        ClusterSelector = new ClusterSelector
                        {
                            Zone = "zone255f4ea8",
                            ClusterLabels =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                        },
                    },
                    Jobs =
                    {
                        new OrderedJob
                        {
                            StepId = "step_idd291f4be",
                            HadoopJob = new HadoopJob
                            {
                                MainJarFileUri = "main_jar_file_uri46ea7aa7",
                                MainClass = "main_classb0f4e864",
                                Args = { "args09af56a9", },
                                JarFileUris =
                                {
                                    "jar_file_urisfcd646b7",
                                },
                                FileUris =
                                {
                                    "file_urisbcc83e18",
                                },
                                ArchiveUris =
                                {
                                    "archive_uris5a747dda",
                                },
                                Properties =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                LoggingConfig = new LoggingConfig
                                {
                                    DriverLogLevels =
                                    {
                                        {
                                            "key8a0b6e3c",
                                            LoggingConfig.Types.Level.Debug
                                        },
                                    },
                                },
                            },
                            SparkJob = new SparkJob
                            {
                                MainJarFileUri = "main_jar_file_uri46ea7aa7",
                                MainClass = "main_classb0f4e864",
                                Args = { "args09af56a9", },
                                JarFileUris =
                                {
                                    "jar_file_urisfcd646b7",
                                },
                                FileUris =
                                {
                                    "file_urisbcc83e18",
                                },
                                ArchiveUris =
                                {
                                    "archive_uris5a747dda",
                                },
                                Properties =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                LoggingConfig = new LoggingConfig
                                {
                                    DriverLogLevels =
                                    {
                                        {
                                            "key8a0b6e3c",
                                            LoggingConfig.Types.Level.Debug
                                        },
                                    },
                                },
                            },
                            PysparkJob = new PySparkJob
                            {
                                MainPythonFileUri = "main_python_file_uri14aabff5",
                                Args = { "args09af56a9", },
                                PythonFileUris =
                                {
                                    "python_file_uris30483b38",
                                },
                                JarFileUris =
                                {
                                    "jar_file_urisfcd646b7",
                                },
                                FileUris =
                                {
                                    "file_urisbcc83e18",
                                },
                                ArchiveUris =
                                {
                                    "archive_uris5a747dda",
                                },
                                Properties =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                LoggingConfig = new LoggingConfig
                                {
                                    DriverLogLevels =
                                    {
                                        {
                                            "key8a0b6e3c",
                                            LoggingConfig.Types.Level.Debug
                                        },
                                    },
                                },
                            },
                            HiveJob = new HiveJob
                            {
                                QueryFileUri = "query_file_urid4d84faf",
                                QueryList = new QueryList
                                {
                                    Queries = { "queries42eba75d", },
                                },
                                ContinueOnFailure = false,
                                ScriptVariables =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                Properties =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                JarFileUris =
                                {
                                    "jar_file_urisfcd646b7",
                                },
                            },
                            PigJob = new PigJob
                            {
                                QueryFileUri = "query_file_urid4d84faf",
                                QueryList = new QueryList
                                {
                                    Queries = { "queries42eba75d", },
                                },
                                ContinueOnFailure = false,
                                ScriptVariables =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                Properties =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                JarFileUris =
                                {
                                    "jar_file_urisfcd646b7",
                                },
                                LoggingConfig = new LoggingConfig
                                {
                                    DriverLogLevels =
                                    {
                                        {
                                            "key8a0b6e3c",
                                            LoggingConfig.Types.Level.Debug
                                        },
                                    },
                                },
                            },
                            SparkSqlJob = new SparkSqlJob
                            {
                                QueryFileUri = "query_file_urid4d84faf",
                                QueryList = new QueryList
                                {
                                    Queries = { "queries42eba75d", },
                                },
                                ScriptVariables =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                Properties =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                LoggingConfig = new LoggingConfig
                                {
                                    DriverLogLevels =
                                    {
                                        {
                                            "key8a0b6e3c",
                                            LoggingConfig.Types.Level.Debug
                                        },
                                    },
                                },
                                JarFileUris =
                                {
                                    "jar_file_urisfcd646b7",
                                },
                            },
                            Labels =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            Scheduling = new JobScheduling
                            {
                                MaxFailuresPerHour = 238137428,
                            },
                            PrerequisiteStepIds =
                            {
                                "prerequisite_step_ids4753a371",
                            },
                            SparkRJob = new SparkRJob
                            {
                                MainRFileUri = "main_r_file_uri3c1a03d8",
                                Args = { "args09af56a9", },
                                FileUris =
                                {
                                    "file_urisbcc83e18",
                                },
                                ArchiveUris =
                                {
                                    "archive_uris5a747dda",
                                },
                                Properties =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                LoggingConfig = new LoggingConfig
                                {
                                    DriverLogLevels =
                                    {
                                        {
                                            "key8a0b6e3c",
                                            LoggingConfig.Types.Level.Debug
                                        },
                                    },
                                },
                            },
                            PrestoJob = new PrestoJob
                            {
                                QueryFileUri = "query_file_urid4d84faf",
                                QueryList = new QueryList
                                {
                                    Queries = { "queries42eba75d", },
                                },
                                ContinueOnFailure = false,
                                OutputFormat = "output_format020eca50",
                                ClientTags =
                                {
                                    "client_tags74c9d57e",
                                },
                                Properties =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                LoggingConfig = new LoggingConfig
                                {
                                    DriverLogLevels =
                                    {
                                        {
                                            "key8a0b6e3c",
                                            LoggingConfig.Types.Level.Debug
                                        },
                                    },
                                },
                            },
                        },
                    },
                    Parameters =
                    {
                        new TemplateParameter
                        {
                            Name = "name1c9368b0",
                            Fields = { "fieldsd76e5bd0", },
                            Description = "description2cf9da67",
                            Validation = new ParameterValidation
                            {
                                Regex = new RegexValidation
                                {
                                    Regexes = { "regexes5cb111ce", },
                                },
                                Values = new ValueValidation
                                {
                                    Values = { "valueseec79cf0", },
                                },
                            },
                        },
                    },
                },
            };
            WorkflowTemplate expectedResponse = new WorkflowTemplate
            {
                WorkflowTemplateName = WorkflowTemplateName.FromProjectRegionWorkflowTemplate("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]"),
                Id = "id74b70bb8",
                Version = 271578922,
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                UpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Placement = new WorkflowTemplatePlacement
                {
                    ManagedCluster = new ManagedCluster
                    {
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
                        Labels =
                        {
                            {
                                "key8a0b6e3c",
                                "value60c16320"
                            },
                        },
                    },
                    ClusterSelector = new ClusterSelector
                    {
                        Zone = "zone255f4ea8",
                        ClusterLabels =
                        {
                            {
                                "key8a0b6e3c",
                                "value60c16320"
                            },
                        },
                    },
                },
                Jobs =
                {
                    new OrderedJob
                    {
                        StepId = "step_idd291f4be",
                        HadoopJob = new HadoopJob
                        {
                            MainJarFileUri = "main_jar_file_uri46ea7aa7",
                            MainClass = "main_classb0f4e864",
                            Args = { "args09af56a9", },
                            JarFileUris =
                            {
                                "jar_file_urisfcd646b7",
                            },
                            FileUris =
                            {
                                "file_urisbcc83e18",
                            },
                            ArchiveUris =
                            {
                                "archive_uris5a747dda",
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                        },
                        SparkJob = new SparkJob
                        {
                            MainJarFileUri = "main_jar_file_uri46ea7aa7",
                            MainClass = "main_classb0f4e864",
                            Args = { "args09af56a9", },
                            JarFileUris =
                            {
                                "jar_file_urisfcd646b7",
                            },
                            FileUris =
                            {
                                "file_urisbcc83e18",
                            },
                            ArchiveUris =
                            {
                                "archive_uris5a747dda",
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                        },
                        PysparkJob = new PySparkJob
                        {
                            MainPythonFileUri = "main_python_file_uri14aabff5",
                            Args = { "args09af56a9", },
                            PythonFileUris =
                            {
                                "python_file_uris30483b38",
                            },
                            JarFileUris =
                            {
                                "jar_file_urisfcd646b7",
                            },
                            FileUris =
                            {
                                "file_urisbcc83e18",
                            },
                            ArchiveUris =
                            {
                                "archive_uris5a747dda",
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                        },
                        HiveJob = new HiveJob
                        {
                            QueryFileUri = "query_file_urid4d84faf",
                            QueryList = new QueryList
                            {
                                Queries = { "queries42eba75d", },
                            },
                            ContinueOnFailure = false,
                            ScriptVariables =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            JarFileUris =
                            {
                                "jar_file_urisfcd646b7",
                            },
                        },
                        PigJob = new PigJob
                        {
                            QueryFileUri = "query_file_urid4d84faf",
                            QueryList = new QueryList
                            {
                                Queries = { "queries42eba75d", },
                            },
                            ContinueOnFailure = false,
                            ScriptVariables =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            JarFileUris =
                            {
                                "jar_file_urisfcd646b7",
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                        },
                        SparkSqlJob = new SparkSqlJob
                        {
                            QueryFileUri = "query_file_urid4d84faf",
                            QueryList = new QueryList
                            {
                                Queries = { "queries42eba75d", },
                            },
                            ScriptVariables =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                            JarFileUris =
                            {
                                "jar_file_urisfcd646b7",
                            },
                        },
                        Labels =
                        {
                            {
                                "key8a0b6e3c",
                                "value60c16320"
                            },
                        },
                        Scheduling = new JobScheduling
                        {
                            MaxFailuresPerHour = 238137428,
                        },
                        PrerequisiteStepIds =
                        {
                            "prerequisite_step_ids4753a371",
                        },
                        SparkRJob = new SparkRJob
                        {
                            MainRFileUri = "main_r_file_uri3c1a03d8",
                            Args = { "args09af56a9", },
                            FileUris =
                            {
                                "file_urisbcc83e18",
                            },
                            ArchiveUris =
                            {
                                "archive_uris5a747dda",
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                        },
                        PrestoJob = new PrestoJob
                        {
                            QueryFileUri = "query_file_urid4d84faf",
                            QueryList = new QueryList
                            {
                                Queries = { "queries42eba75d", },
                            },
                            ContinueOnFailure = false,
                            OutputFormat = "output_format020eca50",
                            ClientTags =
                            {
                                "client_tags74c9d57e",
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                        },
                    },
                },
                Parameters =
                {
                    new TemplateParameter
                    {
                        Name = "name1c9368b0",
                        Fields = { "fieldsd76e5bd0", },
                        Description = "description2cf9da67",
                        Validation = new ParameterValidation
                        {
                            Regex = new RegexValidation
                            {
                                Regexes = { "regexes5cb111ce", },
                            },
                            Values = new ValueValidation
                            {
                                Values = { "valueseec79cf0", },
                            },
                        },
                    },
                },
            };
            mockGrpcClient.Setup(x => x.UpdateWorkflowTemplate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            WorkflowTemplateServiceClient client = new WorkflowTemplateServiceClientImpl(mockGrpcClient.Object, null);
            WorkflowTemplate response = client.UpdateWorkflowTemplate(request.Template);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateWorkflowTemplateAsync()
        {
            moq::Mock<WorkflowTemplateService.WorkflowTemplateServiceClient> mockGrpcClient = new moq::Mock<WorkflowTemplateService.WorkflowTemplateServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateWorkflowTemplateRequest request = new UpdateWorkflowTemplateRequest
            {
                Template = new WorkflowTemplate
                {
                    WorkflowTemplateName = WorkflowTemplateName.FromProjectRegionWorkflowTemplate("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]"),
                    Id = "id74b70bb8",
                    Version = 271578922,
                    CreateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    UpdateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    Labels =
                    {
                        {
                            "key8a0b6e3c",
                            "value60c16320"
                        },
                    },
                    Placement = new WorkflowTemplatePlacement
                    {
                        ManagedCluster = new ManagedCluster
                        {
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
                            Labels =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                        },
                        ClusterSelector = new ClusterSelector
                        {
                            Zone = "zone255f4ea8",
                            ClusterLabels =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                        },
                    },
                    Jobs =
                    {
                        new OrderedJob
                        {
                            StepId = "step_idd291f4be",
                            HadoopJob = new HadoopJob
                            {
                                MainJarFileUri = "main_jar_file_uri46ea7aa7",
                                MainClass = "main_classb0f4e864",
                                Args = { "args09af56a9", },
                                JarFileUris =
                                {
                                    "jar_file_urisfcd646b7",
                                },
                                FileUris =
                                {
                                    "file_urisbcc83e18",
                                },
                                ArchiveUris =
                                {
                                    "archive_uris5a747dda",
                                },
                                Properties =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                LoggingConfig = new LoggingConfig
                                {
                                    DriverLogLevels =
                                    {
                                        {
                                            "key8a0b6e3c",
                                            LoggingConfig.Types.Level.Debug
                                        },
                                    },
                                },
                            },
                            SparkJob = new SparkJob
                            {
                                MainJarFileUri = "main_jar_file_uri46ea7aa7",
                                MainClass = "main_classb0f4e864",
                                Args = { "args09af56a9", },
                                JarFileUris =
                                {
                                    "jar_file_urisfcd646b7",
                                },
                                FileUris =
                                {
                                    "file_urisbcc83e18",
                                },
                                ArchiveUris =
                                {
                                    "archive_uris5a747dda",
                                },
                                Properties =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                LoggingConfig = new LoggingConfig
                                {
                                    DriverLogLevels =
                                    {
                                        {
                                            "key8a0b6e3c",
                                            LoggingConfig.Types.Level.Debug
                                        },
                                    },
                                },
                            },
                            PysparkJob = new PySparkJob
                            {
                                MainPythonFileUri = "main_python_file_uri14aabff5",
                                Args = { "args09af56a9", },
                                PythonFileUris =
                                {
                                    "python_file_uris30483b38",
                                },
                                JarFileUris =
                                {
                                    "jar_file_urisfcd646b7",
                                },
                                FileUris =
                                {
                                    "file_urisbcc83e18",
                                },
                                ArchiveUris =
                                {
                                    "archive_uris5a747dda",
                                },
                                Properties =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                LoggingConfig = new LoggingConfig
                                {
                                    DriverLogLevels =
                                    {
                                        {
                                            "key8a0b6e3c",
                                            LoggingConfig.Types.Level.Debug
                                        },
                                    },
                                },
                            },
                            HiveJob = new HiveJob
                            {
                                QueryFileUri = "query_file_urid4d84faf",
                                QueryList = new QueryList
                                {
                                    Queries = { "queries42eba75d", },
                                },
                                ContinueOnFailure = false,
                                ScriptVariables =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                Properties =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                JarFileUris =
                                {
                                    "jar_file_urisfcd646b7",
                                },
                            },
                            PigJob = new PigJob
                            {
                                QueryFileUri = "query_file_urid4d84faf",
                                QueryList = new QueryList
                                {
                                    Queries = { "queries42eba75d", },
                                },
                                ContinueOnFailure = false,
                                ScriptVariables =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                Properties =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                JarFileUris =
                                {
                                    "jar_file_urisfcd646b7",
                                },
                                LoggingConfig = new LoggingConfig
                                {
                                    DriverLogLevels =
                                    {
                                        {
                                            "key8a0b6e3c",
                                            LoggingConfig.Types.Level.Debug
                                        },
                                    },
                                },
                            },
                            SparkSqlJob = new SparkSqlJob
                            {
                                QueryFileUri = "query_file_urid4d84faf",
                                QueryList = new QueryList
                                {
                                    Queries = { "queries42eba75d", },
                                },
                                ScriptVariables =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                Properties =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                LoggingConfig = new LoggingConfig
                                {
                                    DriverLogLevels =
                                    {
                                        {
                                            "key8a0b6e3c",
                                            LoggingConfig.Types.Level.Debug
                                        },
                                    },
                                },
                                JarFileUris =
                                {
                                    "jar_file_urisfcd646b7",
                                },
                            },
                            Labels =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            Scheduling = new JobScheduling
                            {
                                MaxFailuresPerHour = 238137428,
                            },
                            PrerequisiteStepIds =
                            {
                                "prerequisite_step_ids4753a371",
                            },
                            SparkRJob = new SparkRJob
                            {
                                MainRFileUri = "main_r_file_uri3c1a03d8",
                                Args = { "args09af56a9", },
                                FileUris =
                                {
                                    "file_urisbcc83e18",
                                },
                                ArchiveUris =
                                {
                                    "archive_uris5a747dda",
                                },
                                Properties =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                LoggingConfig = new LoggingConfig
                                {
                                    DriverLogLevels =
                                    {
                                        {
                                            "key8a0b6e3c",
                                            LoggingConfig.Types.Level.Debug
                                        },
                                    },
                                },
                            },
                            PrestoJob = new PrestoJob
                            {
                                QueryFileUri = "query_file_urid4d84faf",
                                QueryList = new QueryList
                                {
                                    Queries = { "queries42eba75d", },
                                },
                                ContinueOnFailure = false,
                                OutputFormat = "output_format020eca50",
                                ClientTags =
                                {
                                    "client_tags74c9d57e",
                                },
                                Properties =
                                {
                                    {
                                        "key8a0b6e3c",
                                        "value60c16320"
                                    },
                                },
                                LoggingConfig = new LoggingConfig
                                {
                                    DriverLogLevels =
                                    {
                                        {
                                            "key8a0b6e3c",
                                            LoggingConfig.Types.Level.Debug
                                        },
                                    },
                                },
                            },
                        },
                    },
                    Parameters =
                    {
                        new TemplateParameter
                        {
                            Name = "name1c9368b0",
                            Fields = { "fieldsd76e5bd0", },
                            Description = "description2cf9da67",
                            Validation = new ParameterValidation
                            {
                                Regex = new RegexValidation
                                {
                                    Regexes = { "regexes5cb111ce", },
                                },
                                Values = new ValueValidation
                                {
                                    Values = { "valueseec79cf0", },
                                },
                            },
                        },
                    },
                },
            };
            WorkflowTemplate expectedResponse = new WorkflowTemplate
            {
                WorkflowTemplateName = WorkflowTemplateName.FromProjectRegionWorkflowTemplate("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]"),
                Id = "id74b70bb8",
                Version = 271578922,
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                UpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Placement = new WorkflowTemplatePlacement
                {
                    ManagedCluster = new ManagedCluster
                    {
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
                        Labels =
                        {
                            {
                                "key8a0b6e3c",
                                "value60c16320"
                            },
                        },
                    },
                    ClusterSelector = new ClusterSelector
                    {
                        Zone = "zone255f4ea8",
                        ClusterLabels =
                        {
                            {
                                "key8a0b6e3c",
                                "value60c16320"
                            },
                        },
                    },
                },
                Jobs =
                {
                    new OrderedJob
                    {
                        StepId = "step_idd291f4be",
                        HadoopJob = new HadoopJob
                        {
                            MainJarFileUri = "main_jar_file_uri46ea7aa7",
                            MainClass = "main_classb0f4e864",
                            Args = { "args09af56a9", },
                            JarFileUris =
                            {
                                "jar_file_urisfcd646b7",
                            },
                            FileUris =
                            {
                                "file_urisbcc83e18",
                            },
                            ArchiveUris =
                            {
                                "archive_uris5a747dda",
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                        },
                        SparkJob = new SparkJob
                        {
                            MainJarFileUri = "main_jar_file_uri46ea7aa7",
                            MainClass = "main_classb0f4e864",
                            Args = { "args09af56a9", },
                            JarFileUris =
                            {
                                "jar_file_urisfcd646b7",
                            },
                            FileUris =
                            {
                                "file_urisbcc83e18",
                            },
                            ArchiveUris =
                            {
                                "archive_uris5a747dda",
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                        },
                        PysparkJob = new PySparkJob
                        {
                            MainPythonFileUri = "main_python_file_uri14aabff5",
                            Args = { "args09af56a9", },
                            PythonFileUris =
                            {
                                "python_file_uris30483b38",
                            },
                            JarFileUris =
                            {
                                "jar_file_urisfcd646b7",
                            },
                            FileUris =
                            {
                                "file_urisbcc83e18",
                            },
                            ArchiveUris =
                            {
                                "archive_uris5a747dda",
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                        },
                        HiveJob = new HiveJob
                        {
                            QueryFileUri = "query_file_urid4d84faf",
                            QueryList = new QueryList
                            {
                                Queries = { "queries42eba75d", },
                            },
                            ContinueOnFailure = false,
                            ScriptVariables =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            JarFileUris =
                            {
                                "jar_file_urisfcd646b7",
                            },
                        },
                        PigJob = new PigJob
                        {
                            QueryFileUri = "query_file_urid4d84faf",
                            QueryList = new QueryList
                            {
                                Queries = { "queries42eba75d", },
                            },
                            ContinueOnFailure = false,
                            ScriptVariables =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            JarFileUris =
                            {
                                "jar_file_urisfcd646b7",
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                        },
                        SparkSqlJob = new SparkSqlJob
                        {
                            QueryFileUri = "query_file_urid4d84faf",
                            QueryList = new QueryList
                            {
                                Queries = { "queries42eba75d", },
                            },
                            ScriptVariables =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                            JarFileUris =
                            {
                                "jar_file_urisfcd646b7",
                            },
                        },
                        Labels =
                        {
                            {
                                "key8a0b6e3c",
                                "value60c16320"
                            },
                        },
                        Scheduling = new JobScheduling
                        {
                            MaxFailuresPerHour = 238137428,
                        },
                        PrerequisiteStepIds =
                        {
                            "prerequisite_step_ids4753a371",
                        },
                        SparkRJob = new SparkRJob
                        {
                            MainRFileUri = "main_r_file_uri3c1a03d8",
                            Args = { "args09af56a9", },
                            FileUris =
                            {
                                "file_urisbcc83e18",
                            },
                            ArchiveUris =
                            {
                                "archive_uris5a747dda",
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                        },
                        PrestoJob = new PrestoJob
                        {
                            QueryFileUri = "query_file_urid4d84faf",
                            QueryList = new QueryList
                            {
                                Queries = { "queries42eba75d", },
                            },
                            ContinueOnFailure = false,
                            OutputFormat = "output_format020eca50",
                            ClientTags =
                            {
                                "client_tags74c9d57e",
                            },
                            Properties =
                            {
                                {
                                    "key8a0b6e3c",
                                    "value60c16320"
                                },
                            },
                            LoggingConfig = new LoggingConfig
                            {
                                DriverLogLevels =
                                {
                                    {
                                        "key8a0b6e3c",
                                        LoggingConfig.Types.Level.Debug
                                    },
                                },
                            },
                        },
                    },
                },
                Parameters =
                {
                    new TemplateParameter
                    {
                        Name = "name1c9368b0",
                        Fields = { "fieldsd76e5bd0", },
                        Description = "description2cf9da67",
                        Validation = new ParameterValidation
                        {
                            Regex = new RegexValidation
                            {
                                Regexes = { "regexes5cb111ce", },
                            },
                            Values = new ValueValidation
                            {
                                Values = { "valueseec79cf0", },
                            },
                        },
                    },
                },
            };
            mockGrpcClient.Setup(x => x.UpdateWorkflowTemplateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<WorkflowTemplate>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            WorkflowTemplateServiceClient client = new WorkflowTemplateServiceClientImpl(mockGrpcClient.Object, null);
            WorkflowTemplate responseCallSettings = await client.UpdateWorkflowTemplateAsync(request.Template, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            WorkflowTemplate responseCancellationToken = await client.UpdateWorkflowTemplateAsync(request.Template, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteWorkflowTemplateRequestObject()
        {
            moq::Mock<WorkflowTemplateService.WorkflowTemplateServiceClient> mockGrpcClient = new moq::Mock<WorkflowTemplateService.WorkflowTemplateServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteWorkflowTemplateRequest request = new DeleteWorkflowTemplateRequest
            {
                WorkflowTemplateName = WorkflowTemplateName.FromProjectRegionWorkflowTemplate("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]"),
                Version = 271578922,
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteWorkflowTemplate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            WorkflowTemplateServiceClient client = new WorkflowTemplateServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteWorkflowTemplate(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteWorkflowTemplateRequestObjectAsync()
        {
            moq::Mock<WorkflowTemplateService.WorkflowTemplateServiceClient> mockGrpcClient = new moq::Mock<WorkflowTemplateService.WorkflowTemplateServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteWorkflowTemplateRequest request = new DeleteWorkflowTemplateRequest
            {
                WorkflowTemplateName = WorkflowTemplateName.FromProjectRegionWorkflowTemplate("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]"),
                Version = 271578922,
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteWorkflowTemplateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            WorkflowTemplateServiceClient client = new WorkflowTemplateServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteWorkflowTemplateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteWorkflowTemplateAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteWorkflowTemplate()
        {
            moq::Mock<WorkflowTemplateService.WorkflowTemplateServiceClient> mockGrpcClient = new moq::Mock<WorkflowTemplateService.WorkflowTemplateServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteWorkflowTemplateRequest request = new DeleteWorkflowTemplateRequest
            {
                WorkflowTemplateName = WorkflowTemplateName.FromProjectRegionWorkflowTemplate("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteWorkflowTemplate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            WorkflowTemplateServiceClient client = new WorkflowTemplateServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteWorkflowTemplate(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteWorkflowTemplateAsync()
        {
            moq::Mock<WorkflowTemplateService.WorkflowTemplateServiceClient> mockGrpcClient = new moq::Mock<WorkflowTemplateService.WorkflowTemplateServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteWorkflowTemplateRequest request = new DeleteWorkflowTemplateRequest
            {
                WorkflowTemplateName = WorkflowTemplateName.FromProjectRegionWorkflowTemplate("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteWorkflowTemplateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            WorkflowTemplateServiceClient client = new WorkflowTemplateServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteWorkflowTemplateAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteWorkflowTemplateAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteWorkflowTemplateResourceNames()
        {
            moq::Mock<WorkflowTemplateService.WorkflowTemplateServiceClient> mockGrpcClient = new moq::Mock<WorkflowTemplateService.WorkflowTemplateServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteWorkflowTemplateRequest request = new DeleteWorkflowTemplateRequest
            {
                WorkflowTemplateName = WorkflowTemplateName.FromProjectRegionWorkflowTemplate("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteWorkflowTemplate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            WorkflowTemplateServiceClient client = new WorkflowTemplateServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteWorkflowTemplate(request.WorkflowTemplateName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteWorkflowTemplateResourceNamesAsync()
        {
            moq::Mock<WorkflowTemplateService.WorkflowTemplateServiceClient> mockGrpcClient = new moq::Mock<WorkflowTemplateService.WorkflowTemplateServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteWorkflowTemplateRequest request = new DeleteWorkflowTemplateRequest
            {
                WorkflowTemplateName = WorkflowTemplateName.FromProjectRegionWorkflowTemplate("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteWorkflowTemplateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            WorkflowTemplateServiceClient client = new WorkflowTemplateServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteWorkflowTemplateAsync(request.WorkflowTemplateName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteWorkflowTemplateAsync(request.WorkflowTemplateName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }
    }
}
