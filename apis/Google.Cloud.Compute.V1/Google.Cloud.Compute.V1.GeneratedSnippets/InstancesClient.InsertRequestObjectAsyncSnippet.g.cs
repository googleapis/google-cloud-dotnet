// Copyright 2024 Google LLC
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

namespace GoogleCSharpSnippets
{
    // [START compute_v1_generated_Instances_Insert_async]
    using Google.Cloud.Compute.V1;
    using System.Threading.Tasks;
    using lro = Google.LongRunning;

    public sealed partial class GeneratedInstancesClientSnippets
    {
        /// <summary>Snippet for InsertAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public async Task InsertRequestObjectAsync()
        {
            // Create client
            InstancesClient instancesClient = await InstancesClient.CreateAsync();
            // Initialize request argument(s)
            InsertInstanceRequest request = new InsertInstanceRequest
            {
                Zone = "",
                SourceMachineImage = "",
                RequestId = "",
                InstanceResource = new Instance
                {
                    Id = 0UL,
                    Kind = "",
                    Name = "",
                    Tags = new Tags
                    {
                        Items = { "", },
                        Fingerprint = "",
                    },
                    Zone = "",
                    ShieldedInstanceConfig = new ShieldedInstanceConfig
                    {
                        EnableSecureBoot = false,
                        EnableVtpm = false,
                        EnableIntegrityMonitoring = false,
                    },
                    SourceMachineImage = "",
                    ResourcePolicies = { "", },
                    CreationTimestamp = "",
                    PrivateIpv6GoogleAccess = "",
                    NetworkInterfaces =
                    {
                        new NetworkInterface
                        {
                            Kind = "",
                            Name = "",
                            NicType = "",
                            AccessConfigs =
                            {
                                new AccessConfig
                                {
                                    Kind = "",
                                    Name = "",
                                    Type = "",
                                    NatIP = "",
                                    SecurityPolicy = "",
                                    PublicPtrDomainName = "",
                                    ExternalIpv6PrefixLength = 0,
                                    NetworkTier = "",
                                    SetPublicPtr = false,
                                    ExternalIpv6 = "",
                                },
                            },
                            AliasIpRanges =
                            {
                                new AliasIpRange
                                {
                                    IpCidrRange = "",
                                    SubnetworkRangeName = "",
                                },
                            },
                            InternalIpv6PrefixLength = 0,
                            NetworkIP = "",
                            NetworkAttachment = "",
                            Network = "",
                            Fingerprint = "",
                            Subnetwork = "",
                            Ipv6Address = "",
                            StackType = "",
                            Ipv6AccessConfigs =
                            {
                                new AccessConfig
                                {
                                    Kind = "",
                                    Name = "",
                                    Type = "",
                                    NatIP = "",
                                    SecurityPolicy = "",
                                    PublicPtrDomainName = "",
                                    ExternalIpv6PrefixLength = 0,
                                    NetworkTier = "",
                                    SetPublicPtr = false,
                                    ExternalIpv6 = "",
                                },
                            },
                            QueueCount = 0,
                            Ipv6AccessType = "",
                        },
                    },
                    InstanceEncryptionKey = new CustomerEncryptionKey
                    {
                        Sha256 = "",
                        KmsKeyServiceAccount = "",
                        RsaEncryptedKey = "",
                        RawKey = "",
                        KmsKeyName = "",
                    },
                    Params = new InstanceParams
                    {
                        ResourceManagerTags = { { "", "" }, },
                    },
                    Metadata = new Metadata
                    {
                        Kind = "",
                        Items =
                        {
                            new Items { Key = "", Value = "", },
                        },
                        Fingerprint = "",
                    },
                    Disks =
                    {
                        new AttachedDisk
                        {
                            Boot = false,
                            Kind = "",
                            Mode = "",
                            Type = "",
                            InitializeParams = new AttachedDiskInitializeParams
                            {
                                ResourcePolicies = { "", },
                                ReplicaZones = { "", },
                                SourceImage = "",
                                DiskName = "",
                                DiskType = "",
                                EnableConfidentialCompute = false,
                                SourceSnapshot = "",
                                ProvisionedIops = 0L,
                                OnUpdateAction = "",
                                Architecture = "",
                                SourceSnapshotEncryptionKey = new CustomerEncryptionKey
                                {
                                    Sha256 = "",
                                    KmsKeyServiceAccount = "",
                                    RsaEncryptedKey = "",
                                    RawKey = "",
                                    KmsKeyName = "",
                                },
                                DiskSizeGb = 0L,
                                Licenses = { "", },
                                StoragePool = "",
                                ResourceManagerTags = { { "", "" }, },
                                SourceImageEncryptionKey = new CustomerEncryptionKey
                                {
                                    Sha256 = "",
                                    KmsKeyServiceAccount = "",
                                    RsaEncryptedKey = "",
                                    RawKey = "",
                                    KmsKeyName = "",
                                },
                                Description = "",
                                Labels = { { "", "" }, },
                                ProvisionedThroughput = 0L,
                            },
                            DeviceName = "",
                            GuestOsFeatures =
                            {
                                new GuestOsFeature { Type = "", },
                            },
                            Index = 0,
                            ForceAttach = false,
                            Source = "",
                            ShieldedInstanceInitialState = new InitialStateConfig
                            {
                                Pk = new FileContentBuffer
                                {
                                    FileType = "",
                                    Content = "",
                                },
                                Dbs =
                                {
                                    new FileContentBuffer
                                    {
                                        FileType = "",
                                        Content = "",
                                    },
                                },
                                Dbxs =
                                {
                                    new FileContentBuffer
                                    {
                                        FileType = "",
                                        Content = "",
                                    },
                                },
                                Keks =
                                {
                                    new FileContentBuffer
                                    {
                                        FileType = "",
                                        Content = "",
                                    },
                                },
                            },
                            DiskEncryptionKey = new CustomerEncryptionKey
                            {
                                Sha256 = "",
                                KmsKeyServiceAccount = "",
                                RsaEncryptedKey = "",
                                RawKey = "",
                                KmsKeyName = "",
                            },
                            Architecture = "",
                            DiskSizeGb = 0L,
                            Licenses = { "", },
                            SavedState = "",
                            AutoDelete = false,
                            Interface = "",
                        },
                    },
                    StartRestricted = false,
                    ReservationAffinity = new ReservationAffinity
                    {
                        Key = "",
                        Values = { "", },
                        ConsumeReservationType = "",
                    },
                    ShieldedInstanceIntegrityPolicy = new ShieldedInstanceIntegrityPolicy
                    {
                        UpdateAutoLearnPolicy = false,
                    },
                    LabelFingerprint = "",
                    Status = "",
                    SourceMachineImageEncryptionKey = new CustomerEncryptionKey
                    {
                        Sha256 = "",
                        KmsKeyServiceAccount = "",
                        RsaEncryptedKey = "",
                        RawKey = "",
                        KmsKeyName = "",
                    },
                    MachineType = "",
                    Fingerprint = "",
                    KeyRevocationActionType = "",
                    Hostname = "",
                    MinCpuPlatform = "",
                    ResourceStatus = new ResourceStatus
                    {
                        UpcomingMaintenance = new UpcomingMaintenance
                        {
                            Type = "",
                            MaintenanceStatus = "",
                            CanReschedule = false,
                            LatestWindowStartTime = "",
                            WindowEndTime = "",
                            WindowStartTime = "",
                        },
                        PhysicalHost = "",
                    },
                    DisplayDevice = new DisplayDevice
                    {
                        EnableDisplay = false,
                    },
                    ServiceAccounts =
                    {
                        new ServiceAccount
                        {
                            Email = "",
                            Scopes = { "", },
                        },
                    },
                    StatusMessage = "",
                    LastSuspendedTimestamp = "",
                    Scheduling = new Scheduling
                    {
                        ProvisioningModel = "",
                        OnHostMaintenance = "",
                        InstanceTerminationAction = "",
                        LocalSsdRecoveryTimeout = new Duration
                        {
                            Nanos = 0,
                            Seconds = 0L,
                        },
                        MinNodeCpus = 0,
                        Preemptible = false,
                        LocationHint = "",
                        AutomaticRestart = false,
                        NodeAffinities =
                        {
                            new SchedulingNodeAffinity
                            {
                                Key = "",
                                Operator = "",
                                Values = { "", },
                            },
                        },
                    },
                    NetworkPerformanceConfig = new NetworkPerformanceConfig
                    {
                        TotalEgressBandwidthTier = "",
                    },
                    AdvancedMachineFeatures = new AdvancedMachineFeatures
                    {
                        EnableNestedVirtualization = false,
                        VisibleCoreCount = 0,
                        EnableUefiNetworking = false,
                        ThreadsPerCore = 0,
                    },
                    CpuPlatform = "",
                    LastStopTimestamp = "",
                    Description = "",
                    LastStartTimestamp = "",
                    SelfLink = "",
                    DeletionProtection = false,
                    GuestAccelerators =
                    {
                        new AcceleratorConfig
                        {
                            AcceleratorType = "",
                            AcceleratorCount = 0,
                        },
                    },
                    CanIpForward = false,
                    SatisfiesPzi = false,
                    SatisfiesPzs = false,
                    ConfidentialInstanceConfig = new ConfidentialInstanceConfig
                    {
                        EnableConfidentialCompute = false,
                    },
                    Labels = { { "", "" }, },
                },
                Project = "",
                SourceInstanceTemplate = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await instancesClient.InsertAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await instancesClient.PollOnceInsertAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END compute_v1_generated_Instances_Insert_async]
}
