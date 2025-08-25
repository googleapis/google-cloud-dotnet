// Copyright 2025 Google LLC
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

namespace Google.Cloud.Compute.V1
{
    /// <summary>Helper constants with the wire representation for enums within the Compute API.</summary>
    public static class ComputeEnumConstants
    {
        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.AccessConfig"/> message.
        /// </summary>
        public static class AccessConfig
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.AccessConfig.Types.NetworkTier"/> enum.
            /// </summary>
            public static class NetworkTier
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.AccessConfig.Types.NetworkTier.UndefinedNetworkTier"/>.
                /// </summary>
                public const string UndefinedNetworkTier = "UNDEFINED_NETWORK_TIER";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.AccessConfig.Types.NetworkTier.FixedStandard"/>.
                /// </summary>
                public const string FixedStandard = "FIXED_STANDARD";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.AccessConfig.Types.NetworkTier.Premium"/>.
                /// </summary>
                public const string Premium = "PREMIUM";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.AccessConfig.Types.NetworkTier.Standard"/>.
                /// </summary>
                public const string Standard = "STANDARD";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.AccessConfig.Types.NetworkTier.StandardOverridesFixedStandard"/>
                /// .
                /// </summary>
                public const string StandardOverridesFixedStandard = "STANDARD_OVERRIDES_FIXED_STANDARD";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.AccessConfig.Types.Type"/> enum.
            /// </summary>
            public static class Type
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.AccessConfig.Types.Type.UndefinedType"/>.
                /// </summary>
                public const string UndefinedType = "UNDEFINED_TYPE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.AccessConfig.Types.Type.DirectIpv6"/>.
                /// </summary>
                public const string DirectIpv6 = "DIRECT_IPV6";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.AccessConfig.Types.Type.OneToOneNat"/>.
                /// </summary>
                public const string OneToOneNat = "ONE_TO_ONE_NAT";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.Address"/> message.
        /// </summary>
        public static class Address
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.Address.Types.AddressType"/> enum.
            /// </summary>
            public static class AddressType
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Address.Types.AddressType.UndefinedAddressType"/>.
                /// </summary>
                public const string UndefinedAddressType = "UNDEFINED_ADDRESS_TYPE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Address.Types.AddressType.External"/>.
                /// </summary>
                public const string External = "EXTERNAL";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Address.Types.AddressType.Internal"/>.
                /// </summary>
                public const string Internal = "INTERNAL";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Address.Types.AddressType.UnspecifiedType"/>.
                /// </summary>
                public const string UnspecifiedType = "UNSPECIFIED_TYPE";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.Address.Types.IpVersion"/> enum.
            /// </summary>
            public static class IpVersion
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Address.Types.IpVersion.UndefinedIpVersion"/>.
                /// </summary>
                public const string UndefinedIpVersion = "UNDEFINED_IP_VERSION";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.Address.Types.IpVersion.Ipv4"/>.
                /// </summary>
                public const string Ipv4 = "IPV4";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.Address.Types.IpVersion.Ipv6"/>.
                /// </summary>
                public const string Ipv6 = "IPV6";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Address.Types.IpVersion.UnspecifiedVersion"/>.
                /// </summary>
                public const string UnspecifiedVersion = "UNSPECIFIED_VERSION";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.Address.Types.Ipv6EndpointType"/> enum.
            /// </summary>
            public static class Ipv6EndpointType
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Address.Types.Ipv6EndpointType.UndefinedIpv6EndpointType"/>
                /// .
                /// </summary>
                public const string UndefinedIpv6EndpointType = "UNDEFINED_IPV6_ENDPOINT_TYPE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Address.Types.Ipv6EndpointType.Netlb"/>.
                /// </summary>
                public const string Netlb = "NETLB";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Address.Types.Ipv6EndpointType.Vm"/>.
                /// </summary>
                public const string Vm = "VM";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.Address.Types.NetworkTier"/> enum.
            /// </summary>
            public static class NetworkTier
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Address.Types.NetworkTier.UndefinedNetworkTier"/>.
                /// </summary>
                public const string UndefinedNetworkTier = "UNDEFINED_NETWORK_TIER";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Address.Types.NetworkTier.FixedStandard"/>.
                /// </summary>
                public const string FixedStandard = "FIXED_STANDARD";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Address.Types.NetworkTier.Premium"/>.
                /// </summary>
                public const string Premium = "PREMIUM";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Address.Types.NetworkTier.Standard"/>.
                /// </summary>
                public const string Standard = "STANDARD";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Address.Types.NetworkTier.StandardOverridesFixedStandard"/>
                /// .
                /// </summary>
                public const string StandardOverridesFixedStandard = "STANDARD_OVERRIDES_FIXED_STANDARD";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.Address.Types.Purpose"/> enum.
            /// </summary>
            public static class Purpose
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Address.Types.Purpose.UndefinedPurpose"/>.
                /// </summary>
                public const string UndefinedPurpose = "UNDEFINED_PURPOSE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Address.Types.Purpose.DnsResolver"/>.
                /// </summary>
                public const string DnsResolver = "DNS_RESOLVER";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Address.Types.Purpose.GceEndpoint"/>.
                /// </summary>
                public const string GceEndpoint = "GCE_ENDPOINT";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Address.Types.Purpose.IpsecInterconnect"/>.
                /// </summary>
                public const string IpsecInterconnect = "IPSEC_INTERCONNECT";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.Address.Types.Purpose.NatAuto"/>.
                /// </summary>
                public const string NatAuto = "NAT_AUTO";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Address.Types.Purpose.PrivateServiceConnect"/>.
                /// </summary>
                public const string PrivateServiceConnect = "PRIVATE_SERVICE_CONNECT";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Address.Types.Purpose.Serverless"/>.
                /// </summary>
                public const string Serverless = "SERVERLESS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Address.Types.Purpose.SharedLoadbalancerVip"/>.
                /// </summary>
                public const string SharedLoadbalancerVip = "SHARED_LOADBALANCER_VIP";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Address.Types.Purpose.VpcPeering"/>.
                /// </summary>
                public const string VpcPeering = "VPC_PEERING";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.Address.Types.Status"/> enum.
            /// </summary>
            public static class Status
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Address.Types.Status.UndefinedStatus"/>.
                /// </summary>
                public const string UndefinedStatus = "UNDEFINED_STATUS";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.Address.Types.Status.InUse"/>.
                /// </summary>
                public const string InUse = "IN_USE";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.Address.Types.Status.Reserved"/>.
                /// </summary>
                public const string Reserved = "RESERVED";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.Address.Types.Status.Reserving"/>.
                /// </summary>
                public const string Reserving = "RESERVING";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.AdvancedMachineFeatures"/>
        /// message.
        /// </summary>
        public static class AdvancedMachineFeatures
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.AdvancedMachineFeatures.Types.PerformanceMonitoringUnit"/>
            /// enum.
            /// </summary>
            public static class PerformanceMonitoringUnit
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.AdvancedMachineFeatures.Types.PerformanceMonitoringUnit.UndefinedPerformanceMonitoringUnit"/>
                /// .
                /// </summary>
                public const string UndefinedPerformanceMonitoringUnit = "UNDEFINED_PERFORMANCE_MONITORING_UNIT";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.AdvancedMachineFeatures.Types.PerformanceMonitoringUnit.Architectural"/>
                /// .
                /// </summary>
                public const string Architectural = "ARCHITECTURAL";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.AdvancedMachineFeatures.Types.PerformanceMonitoringUnit.Enhanced"/>
                /// .
                /// </summary>
                public const string Enhanced = "ENHANCED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.AdvancedMachineFeatures.Types.PerformanceMonitoringUnit.Unspecified"/>
                /// .
                /// </summary>
                public const string Unspecified = "PERFORMANCE_MONITORING_UNIT_UNSPECIFIED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.AdvancedMachineFeatures.Types.PerformanceMonitoringUnit.Standard"/>
                /// .
                /// </summary>
                public const string Standard = "STANDARD";
            }
        }

        /// <summary>
        /// Container class for enums within the
        /// <see cref="global::Google.Cloud.Compute.V1.AllocationAggregateReservation"/> message.
        /// </summary>
        public static class AllocationAggregateReservation
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.AllocationAggregateReservation.Types.VmFamily"/> enum.
            /// </summary>
            public static class VmFamily
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.AllocationAggregateReservation.Types.VmFamily.UndefinedVmFamily"/>
                /// .
                /// </summary>
                public const string UndefinedVmFamily = "UNDEFINED_VM_FAMILY";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.AllocationAggregateReservation.Types.VmFamily.CloudTpuDeviceCt3"/>
                /// .
                /// </summary>
                public const string CloudTpuDeviceCt3 = "VM_FAMILY_CLOUD_TPU_DEVICE_CT3";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.AllocationAggregateReservation.Types.VmFamily.CloudTpuLiteDeviceCt5L"/>
                /// .
                /// </summary>
                public const string CloudTpuLiteDeviceCt5L = "VM_FAMILY_CLOUD_TPU_LITE_DEVICE_CT5L";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.AllocationAggregateReservation.Types.VmFamily.CloudTpuLitePodSliceCt5Lp"/>
                /// .
                /// </summary>
                public const string CloudTpuLitePodSliceCt5Lp = "VM_FAMILY_CLOUD_TPU_LITE_POD_SLICE_CT5LP";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.AllocationAggregateReservation.Types.VmFamily.CloudTpuLitePodSliceCt6E"/>
                /// .
                /// </summary>
                public const string CloudTpuLitePodSliceCt6E = "VM_FAMILY_CLOUD_TPU_LITE_POD_SLICE_CT6E";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.AllocationAggregateReservation.Types.VmFamily.CloudTpuPodSliceCt3P"/>
                /// .
                /// </summary>
                public const string CloudTpuPodSliceCt3P = "VM_FAMILY_CLOUD_TPU_POD_SLICE_CT3P";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.AllocationAggregateReservation.Types.VmFamily.CloudTpuPodSliceCt4P"/>
                /// .
                /// </summary>
                public const string CloudTpuPodSliceCt4P = "VM_FAMILY_CLOUD_TPU_POD_SLICE_CT4P";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.AllocationAggregateReservation.Types.VmFamily.CloudTpuPodSliceCt5P"/>
                /// .
                /// </summary>
                public const string CloudTpuPodSliceCt5P = "VM_FAMILY_CLOUD_TPU_POD_SLICE_CT5P";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.AllocationAggregateReservation.Types.WorkloadType"/> enum.
            /// </summary>
            public static class WorkloadType
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.AllocationAggregateReservation.Types.WorkloadType.UndefinedWorkloadType"/>
                /// .
                /// </summary>
                public const string UndefinedWorkloadType = "UNDEFINED_WORKLOAD_TYPE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.AllocationAggregateReservation.Types.WorkloadType.Batch"/>
                /// .
                /// </summary>
                public const string Batch = "BATCH";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.AllocationAggregateReservation.Types.WorkloadType.Serving"/>
                /// .
                /// </summary>
                public const string Serving = "SERVING";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.AllocationAggregateReservation.Types.WorkloadType.Unspecified"/>
                /// .
                /// </summary>
                public const string Unspecified = "UNSPECIFIED";
            }
        }

        /// <summary>
        /// Container class for enums within the
        /// <see cref="global::Google.Cloud.Compute.V1.AllocationReservationSharingPolicy"/> message.
        /// </summary>
        public static class AllocationReservationSharingPolicy
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.AllocationReservationSharingPolicy.Types.ServiceShareType"/>
            /// enum.
            /// </summary>
            public static class ServiceShareType
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.AllocationReservationSharingPolicy.Types.ServiceShareType.UndefinedServiceShareType"/>
                /// .
                /// </summary>
                public const string UndefinedServiceShareType = "UNDEFINED_SERVICE_SHARE_TYPE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.AllocationReservationSharingPolicy.Types.ServiceShareType.AllowAll"/>
                /// .
                /// </summary>
                public const string AllowAll = "ALLOW_ALL";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.AllocationReservationSharingPolicy.Types.ServiceShareType.DisallowAll"/>
                /// .
                /// </summary>
                public const string DisallowAll = "DISALLOW_ALL";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.AllocationReservationSharingPolicy.Types.ServiceShareType.Unspecified"/>
                /// .
                /// </summary>
                public const string Unspecified = "SERVICE_SHARE_TYPE_UNSPECIFIED";
            }
        }

        /// <summary>
        /// Container class for enums within the
        /// <see cref="global::Google.Cloud.Compute.V1.AllocationResourceStatusHealthInfo"/> message.
        /// </summary>
        public static class AllocationResourceStatusHealthInfo
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.AllocationResourceStatusHealthInfo.Types.HealthStatus"/>
            /// enum.
            /// </summary>
            public static class HealthStatus
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.AllocationResourceStatusHealthInfo.Types.HealthStatus.UndefinedHealthStatus"/>
                /// .
                /// </summary>
                public const string UndefinedHealthStatus = "UNDEFINED_HEALTH_STATUS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.AllocationResourceStatusHealthInfo.Types.HealthStatus.Degraded"/>
                /// .
                /// </summary>
                public const string Degraded = "DEGRADED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.AllocationResourceStatusHealthInfo.Types.HealthStatus.Healthy"/>
                /// .
                /// </summary>
                public const string Healthy = "HEALTHY";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.AllocationResourceStatusHealthInfo.Types.HealthStatus.Unspecified"/>
                /// .
                /// </summary>
                public const string Unspecified = "HEALTH_STATUS_UNSPECIFIED";
            }
        }

        /// <summary>
        /// Container class for enums within the
        /// <see cref="global::Google.Cloud.Compute.V1.AllocationSpecificSKUAllocationAllocatedInstancePropertiesReservedDisk"/>
        ///  message.
        /// </summary>
        public static class AllocationSpecificSKUAllocationAllocatedInstancePropertiesReservedDisk
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.AllocationSpecificSKUAllocationAllocatedInstancePropertiesReservedDisk.Types.Interface"/>
            ///  enum.
            /// </summary>
            public static class Interface
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.AllocationSpecificSKUAllocationAllocatedInstancePropertiesReservedDisk.Types.Interface.UndefinedInterface"/>
                /// .
                /// </summary>
                public const string UndefinedInterface = "UNDEFINED_INTERFACE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.AllocationSpecificSKUAllocationAllocatedInstancePropertiesReservedDisk.Types.Interface.Nvme"/>
                /// .
                /// </summary>
                public const string Nvme = "NVME";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.AllocationSpecificSKUAllocationAllocatedInstancePropertiesReservedDisk.Types.Interface.Scsi"/>
                /// .
                /// </summary>
                public const string Scsi = "SCSI";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.AttachedDisk"/> message.
        /// </summary>
        public static class AttachedDisk
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.AttachedDisk.Types.Architecture"/> enum.
            /// </summary>
            public static class Architecture
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.AttachedDisk.Types.Architecture.UndefinedArchitecture"/>.
                /// </summary>
                public const string UndefinedArchitecture = "UNDEFINED_ARCHITECTURE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.AttachedDisk.Types.Architecture.Unspecified"/>.
                /// </summary>
                public const string Unspecified = "ARCHITECTURE_UNSPECIFIED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.AttachedDisk.Types.Architecture.Arm64"/>.
                /// </summary>
                public const string Arm64 = "ARM64";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.AttachedDisk.Types.Architecture.X8664"/>.
                /// </summary>
                public const string X8664 = "X86_64";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.AttachedDisk.Types.Interface"/> enum.
            /// </summary>
            public static class Interface
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.AttachedDisk.Types.Interface.UndefinedInterface"/>.
                /// </summary>
                public const string UndefinedInterface = "UNDEFINED_INTERFACE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.AttachedDisk.Types.Interface.Nvme"/>.
                /// </summary>
                public const string Nvme = "NVME";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.AttachedDisk.Types.Interface.Scsi"/>.
                /// </summary>
                public const string Scsi = "SCSI";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.AttachedDisk.Types.Mode"/> enum.
            /// </summary>
            public static class Mode
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.AttachedDisk.Types.Mode.UndefinedMode"/>.
                /// </summary>
                public const string UndefinedMode = "UNDEFINED_MODE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.AttachedDisk.Types.Mode.ReadOnly"/>.
                /// </summary>
                public const string ReadOnly = "READ_ONLY";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.AttachedDisk.Types.Mode.ReadWrite"/>.
                /// </summary>
                public const string ReadWrite = "READ_WRITE";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.AttachedDisk.Types.SavedState"/> enum.
            /// </summary>
            public static class SavedState
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.AttachedDisk.Types.SavedState.UndefinedSavedState"/>.
                /// </summary>
                public const string UndefinedSavedState = "UNDEFINED_SAVED_STATE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.AttachedDisk.Types.SavedState.DiskSavedStateUnspecified"/>
                /// .
                /// </summary>
                public const string DiskSavedStateUnspecified = "DISK_SAVED_STATE_UNSPECIFIED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.AttachedDisk.Types.SavedState.Preserved"/>.
                /// </summary>
                public const string Preserved = "PRESERVED";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.AttachedDisk.Types.Type"/> enum.
            /// </summary>
            public static class Type
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.AttachedDisk.Types.Type.UndefinedType"/>.
                /// </summary>
                public const string UndefinedType = "UNDEFINED_TYPE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.AttachedDisk.Types.Type.Persistent"/>.
                /// </summary>
                public const string Persistent = "PERSISTENT";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.AttachedDisk.Types.Type.Scratch"/>
                /// .
                /// </summary>
                public const string Scratch = "SCRATCH";
            }
        }

        /// <summary>
        /// Container class for enums within the
        /// <see cref="global::Google.Cloud.Compute.V1.AttachedDiskInitializeParams"/> message.
        /// </summary>
        public static class AttachedDiskInitializeParams
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.AttachedDiskInitializeParams.Types.Architecture"/> enum.
            /// </summary>
            public static class Architecture
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.AttachedDiskInitializeParams.Types.Architecture.UndefinedArchitecture"/>
                /// .
                /// </summary>
                public const string UndefinedArchitecture = "UNDEFINED_ARCHITECTURE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.AttachedDiskInitializeParams.Types.Architecture.Unspecified"/>
                /// .
                /// </summary>
                public const string Unspecified = "ARCHITECTURE_UNSPECIFIED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.AttachedDiskInitializeParams.Types.Architecture.Arm64"/>.
                /// </summary>
                public const string Arm64 = "ARM64";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.AttachedDiskInitializeParams.Types.Architecture.X8664"/>.
                /// </summary>
                public const string X8664 = "X86_64";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.AttachedDiskInitializeParams.Types.OnUpdateAction"/> enum.
            /// </summary>
            public static class OnUpdateAction
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.AttachedDiskInitializeParams.Types.OnUpdateAction.UndefinedOnUpdateAction"/>
                /// .
                /// </summary>
                public const string UndefinedOnUpdateAction = "UNDEFINED_ON_UPDATE_ACTION";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.AttachedDiskInitializeParams.Types.OnUpdateAction.RecreateDisk"/>
                /// .
                /// </summary>
                public const string RecreateDisk = "RECREATE_DISK";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.AttachedDiskInitializeParams.Types.OnUpdateAction.RecreateDiskIfSourceChanged"/>
                /// .
                /// </summary>
                public const string RecreateDiskIfSourceChanged = "RECREATE_DISK_IF_SOURCE_CHANGED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.AttachedDiskInitializeParams.Types.OnUpdateAction.UseExistingDisk"/>
                /// .
                /// </summary>
                public const string UseExistingDisk = "USE_EXISTING_DISK";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.AuditLogConfig"/> message.
        /// </summary>
        public static class AuditLogConfig
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.AuditLogConfig.Types.LogType"/> enum.
            /// </summary>
            public static class LogType
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.AuditLogConfig.Types.LogType.UndefinedLogType"/>.
                /// </summary>
                public const string UndefinedLogType = "UNDEFINED_LOG_TYPE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.AuditLogConfig.Types.LogType.AdminRead"/>.
                /// </summary>
                public const string AdminRead = "ADMIN_READ";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.AuditLogConfig.Types.LogType.DataRead"/>.
                /// </summary>
                public const string DataRead = "DATA_READ";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.AuditLogConfig.Types.LogType.DataWrite"/>.
                /// </summary>
                public const string DataWrite = "DATA_WRITE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.AuditLogConfig.Types.LogType.Unspecified"/>.
                /// </summary>
                public const string Unspecified = "LOG_TYPE_UNSPECIFIED";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.Autoscaler"/> message.
        /// </summary>
        public static class Autoscaler
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.Autoscaler.Types.Status"/> enum.
            /// </summary>
            public static class Status
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Autoscaler.Types.Status.UndefinedStatus"/>.
                /// </summary>
                public const string UndefinedStatus = "UNDEFINED_STATUS";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.Autoscaler.Types.Status.Active"/>.
                /// </summary>
                public const string Active = "ACTIVE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Autoscaler.Types.Status.Deleting"/>.
                /// </summary>
                public const string Deleting = "DELETING";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.Autoscaler.Types.Status.Error"/>.
                /// </summary>
                public const string Error = "ERROR";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.Autoscaler.Types.Status.Pending"/>
                /// .
                /// </summary>
                public const string Pending = "PENDING";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.AutoscalerStatusDetails"/>
        /// message.
        /// </summary>
        public static class AutoscalerStatusDetails
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.AutoscalerStatusDetails.Types.Type"/> enum.
            /// </summary>
            public static class Type
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.AutoscalerStatusDetails.Types.Type.UndefinedType"/>.
                /// </summary>
                public const string UndefinedType = "UNDEFINED_TYPE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.AutoscalerStatusDetails.Types.Type.AllInstancesUnhealthy"/>
                /// .
                /// </summary>
                public const string AllInstancesUnhealthy = "ALL_INSTANCES_UNHEALTHY";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.AutoscalerStatusDetails.Types.Type.BackendServiceDoesNotExist"/>
                /// .
                /// </summary>
                public const string BackendServiceDoesNotExist = "BACKEND_SERVICE_DOES_NOT_EXIST";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.AutoscalerStatusDetails.Types.Type.CappedAtMaxNumReplicas"/>
                /// .
                /// </summary>
                public const string CappedAtMaxNumReplicas = "CAPPED_AT_MAX_NUM_REPLICAS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.AutoscalerStatusDetails.Types.Type.CustomMetricDataPointsTooSparse"/>
                /// .
                /// </summary>
                public const string CustomMetricDataPointsTooSparse = "CUSTOM_METRIC_DATA_POINTS_TOO_SPARSE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.AutoscalerStatusDetails.Types.Type.CustomMetricInvalid"/>
                /// .
                /// </summary>
                public const string CustomMetricInvalid = "CUSTOM_METRIC_INVALID";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.AutoscalerStatusDetails.Types.Type.MinEqualsMax"/>.
                /// </summary>
                public const string MinEqualsMax = "MIN_EQUALS_MAX";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.AutoscalerStatusDetails.Types.Type.MissingCustomMetricDataPoints"/>
                /// .
                /// </summary>
                public const string MissingCustomMetricDataPoints = "MISSING_CUSTOM_METRIC_DATA_POINTS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.AutoscalerStatusDetails.Types.Type.MissingLoadBalancingDataPoints"/>
                /// .
                /// </summary>
                public const string MissingLoadBalancingDataPoints = "MISSING_LOAD_BALANCING_DATA_POINTS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.AutoscalerStatusDetails.Types.Type.ModeOff"/>.
                /// </summary>
                public const string ModeOff = "MODE_OFF";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.AutoscalerStatusDetails.Types.Type.ModeOnlyScaleOut"/>.
                /// </summary>
                public const string ModeOnlyScaleOut = "MODE_ONLY_SCALE_OUT";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.AutoscalerStatusDetails.Types.Type.ModeOnlyUp"/>.
                /// </summary>
                public const string ModeOnlyUp = "MODE_ONLY_UP";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.AutoscalerStatusDetails.Types.Type.MoreThanOneBackendService"/>
                /// .
                /// </summary>
                public const string MoreThanOneBackendService = "MORE_THAN_ONE_BACKEND_SERVICE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.AutoscalerStatusDetails.Types.Type.NotEnoughQuotaAvailable"/>
                /// .
                /// </summary>
                public const string NotEnoughQuotaAvailable = "NOT_ENOUGH_QUOTA_AVAILABLE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.AutoscalerStatusDetails.Types.Type.RegionResourceStockout"/>
                /// .
                /// </summary>
                public const string RegionResourceStockout = "REGION_RESOURCE_STOCKOUT";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.AutoscalerStatusDetails.Types.Type.ScalingTargetDoesNotExist"/>
                /// .
                /// </summary>
                public const string ScalingTargetDoesNotExist = "SCALING_TARGET_DOES_NOT_EXIST";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.AutoscalerStatusDetails.Types.Type.ScheduledInstancesGreaterThanAutoscalerMax"/>
                /// .
                /// </summary>
                public const string ScheduledInstancesGreaterThanAutoscalerMax = "SCHEDULED_INSTANCES_GREATER_THAN_AUTOSCALER_MAX";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.AutoscalerStatusDetails.Types.Type.ScheduledInstancesLessThanAutoscalerMin"/>
                /// .
                /// </summary>
                public const string ScheduledInstancesLessThanAutoscalerMin = "SCHEDULED_INSTANCES_LESS_THAN_AUTOSCALER_MIN";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.AutoscalerStatusDetails.Types.Type.Unknown"/>.
                /// </summary>
                public const string Unknown = "UNKNOWN";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.AutoscalerStatusDetails.Types.Type.UnsupportedMaxRateLoadBalancingConfiguration"/>
                /// .
                /// </summary>
                public const string UnsupportedMaxRateLoadBalancingConfiguration = "UNSUPPORTED_MAX_RATE_LOAD_BALANCING_CONFIGURATION";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.AutoscalerStatusDetails.Types.Type.ZoneResourceStockout"/>
                /// .
                /// </summary>
                public const string ZoneResourceStockout = "ZONE_RESOURCE_STOCKOUT";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.AutoscalingPolicy"/>
        /// message.
        /// </summary>
        public static class AutoscalingPolicy
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.AutoscalingPolicy.Types.Mode"/> enum.
            /// </summary>
            public static class Mode
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.AutoscalingPolicy.Types.Mode.UndefinedMode"/>.
                /// </summary>
                public const string UndefinedMode = "UNDEFINED_MODE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.AutoscalingPolicy.Types.Mode.Off"/>.
                /// </summary>
                public const string Off = "OFF";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.AutoscalingPolicy.Types.Mode.On"/>
                /// .
                /// </summary>
                public const string On = "ON";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.AutoscalingPolicy.Types.Mode.OnlyScaleOut"/>.
                /// </summary>
                public const string OnlyScaleOut = "ONLY_SCALE_OUT";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.AutoscalingPolicy.Types.Mode.OnlyUp"/>.
                /// </summary>
                public const string OnlyUp = "ONLY_UP";
            }
        }

        /// <summary>
        /// Container class for enums within the
        /// <see cref="global::Google.Cloud.Compute.V1.AutoscalingPolicyCpuUtilization"/> message.
        /// </summary>
        public static class AutoscalingPolicyCpuUtilization
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.AutoscalingPolicyCpuUtilization.Types.PredictiveMethod"/>
            /// enum.
            /// </summary>
            public static class PredictiveMethod
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.AutoscalingPolicyCpuUtilization.Types.PredictiveMethod.UndefinedPredictiveMethod"/>
                /// .
                /// </summary>
                public const string UndefinedPredictiveMethod = "UNDEFINED_PREDICTIVE_METHOD";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.AutoscalingPolicyCpuUtilization.Types.PredictiveMethod.None"/>
                /// .
                /// </summary>
                public const string None = "NONE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.AutoscalingPolicyCpuUtilization.Types.PredictiveMethod.OptimizeAvailability"/>
                /// .
                /// </summary>
                public const string OptimizeAvailability = "OPTIMIZE_AVAILABILITY";
            }
        }

        /// <summary>
        /// Container class for enums within the
        /// <see cref="global::Google.Cloud.Compute.V1.AutoscalingPolicyCustomMetricUtilization"/> message.
        /// </summary>
        public static class AutoscalingPolicyCustomMetricUtilization
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.AutoscalingPolicyCustomMetricUtilization.Types.UtilizationTargetType"/>
            ///  enum.
            /// </summary>
            public static class UtilizationTargetType
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.AutoscalingPolicyCustomMetricUtilization.Types.UtilizationTargetType.UndefinedUtilizationTargetType"/>
                /// .
                /// </summary>
                public const string UndefinedUtilizationTargetType = "UNDEFINED_UTILIZATION_TARGET_TYPE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.AutoscalingPolicyCustomMetricUtilization.Types.UtilizationTargetType.DeltaPerMinute"/>
                /// .
                /// </summary>
                public const string DeltaPerMinute = "DELTA_PER_MINUTE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.AutoscalingPolicyCustomMetricUtilization.Types.UtilizationTargetType.DeltaPerSecond"/>
                /// .
                /// </summary>
                public const string DeltaPerSecond = "DELTA_PER_SECOND";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.AutoscalingPolicyCustomMetricUtilization.Types.UtilizationTargetType.Gauge"/>
                /// .
                /// </summary>
                public const string Gauge = "GAUGE";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.Backend"/> message.
        /// </summary>
        public static class Backend
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.Backend.Types.BalancingMode"/> enum.
            /// </summary>
            public static class BalancingMode
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Backend.Types.BalancingMode.UndefinedBalancingMode"/>.
                /// </summary>
                public const string UndefinedBalancingMode = "UNDEFINED_BALANCING_MODE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Backend.Types.BalancingMode.Connection"/>.
                /// </summary>
                public const string Connection = "CONNECTION";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Backend.Types.BalancingMode.CustomMetrics"/>.
                /// </summary>
                public const string CustomMetrics = "CUSTOM_METRICS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Backend.Types.BalancingMode.Rate"/>.
                /// </summary>
                public const string Rate = "RATE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Backend.Types.BalancingMode.Utilization"/>.
                /// </summary>
                public const string Utilization = "UTILIZATION";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.Backend.Types.Preference"/> enum.
            /// </summary>
            public static class Preference
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Backend.Types.Preference.UndefinedPreference"/>.
                /// </summary>
                public const string UndefinedPreference = "UNDEFINED_PREFERENCE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Backend.Types.Preference.Default"/>.
                /// </summary>
                public const string Default = "DEFAULT";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Backend.Types.Preference.Unspecified"/>.
                /// </summary>
                public const string Unspecified = "PREFERENCE_UNSPECIFIED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Backend.Types.Preference.Preferred"/>.
                /// </summary>
                public const string Preferred = "PREFERRED";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.BackendBucket"/> message.
        /// </summary>
        public static class BackendBucket
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.BackendBucket.Types.CompressionMode"/> enum.
            /// </summary>
            public static class CompressionMode
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BackendBucket.Types.CompressionMode.UndefinedCompressionMode"/>
                /// .
                /// </summary>
                public const string UndefinedCompressionMode = "UNDEFINED_COMPRESSION_MODE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BackendBucket.Types.CompressionMode.Automatic"/>.
                /// </summary>
                public const string Automatic = "AUTOMATIC";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BackendBucket.Types.CompressionMode.Disabled"/>.
                /// </summary>
                public const string Disabled = "DISABLED";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.BackendBucket.Types.LoadBalancingScheme"/> enum.
            /// </summary>
            public static class LoadBalancingScheme
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BackendBucket.Types.LoadBalancingScheme.UndefinedLoadBalancingScheme"/>
                /// .
                /// </summary>
                public const string UndefinedLoadBalancingScheme = "UNDEFINED_LOAD_BALANCING_SCHEME";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BackendBucket.Types.LoadBalancingScheme.InternalManaged"/>
                /// .
                /// </summary>
                public const string InternalManaged = "INTERNAL_MANAGED";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.BackendBucketCdnPolicy"/>
        /// message.
        /// </summary>
        public static class BackendBucketCdnPolicy
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.BackendBucketCdnPolicy.Types.CacheMode"/> enum.
            /// </summary>
            public static class CacheMode
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BackendBucketCdnPolicy.Types.CacheMode.UndefinedCacheMode"/>
                /// .
                /// </summary>
                public const string UndefinedCacheMode = "UNDEFINED_CACHE_MODE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BackendBucketCdnPolicy.Types.CacheMode.CacheAllStatic"/>.
                /// </summary>
                public const string CacheAllStatic = "CACHE_ALL_STATIC";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BackendBucketCdnPolicy.Types.CacheMode.ForceCacheAll"/>.
                /// </summary>
                public const string ForceCacheAll = "FORCE_CACHE_ALL";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BackendBucketCdnPolicy.Types.CacheMode.InvalidCacheMode"/>
                /// .
                /// </summary>
                public const string InvalidCacheMode = "INVALID_CACHE_MODE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BackendBucketCdnPolicy.Types.CacheMode.UseOriginHeaders"/>
                /// .
                /// </summary>
                public const string UseOriginHeaders = "USE_ORIGIN_HEADERS";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.BackendService"/> message.
        /// </summary>
        public static class BackendService
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.BackendService.Types.CompressionMode"/> enum.
            /// </summary>
            public static class CompressionMode
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BackendService.Types.CompressionMode.UndefinedCompressionMode"/>
                /// .
                /// </summary>
                public const string UndefinedCompressionMode = "UNDEFINED_COMPRESSION_MODE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BackendService.Types.CompressionMode.Automatic"/>.
                /// </summary>
                public const string Automatic = "AUTOMATIC";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BackendService.Types.CompressionMode.Disabled"/>.
                /// </summary>
                public const string Disabled = "DISABLED";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.BackendService.Types.ExternalManagedMigrationState"/> enum.
            /// </summary>
            public static class ExternalManagedMigrationState
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BackendService.Types.ExternalManagedMigrationState.UndefinedExternalManagedMigrationState"/>
                /// .
                /// </summary>
                public const string UndefinedExternalManagedMigrationState = "UNDEFINED_EXTERNAL_MANAGED_MIGRATION_STATE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BackendService.Types.ExternalManagedMigrationState.Prepare"/>
                /// .
                /// </summary>
                public const string Prepare = "PREPARE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BackendService.Types.ExternalManagedMigrationState.TestAllTraffic"/>
                /// .
                /// </summary>
                public const string TestAllTraffic = "TEST_ALL_TRAFFIC";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BackendService.Types.ExternalManagedMigrationState.TestByPercentage"/>
                /// .
                /// </summary>
                public const string TestByPercentage = "TEST_BY_PERCENTAGE";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.BackendService.Types.IpAddressSelectionPolicy"/> enum.
            /// </summary>
            public static class IpAddressSelectionPolicy
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BackendService.Types.IpAddressSelectionPolicy.UndefinedIpAddressSelectionPolicy"/>
                /// .
                /// </summary>
                public const string UndefinedIpAddressSelectionPolicy = "UNDEFINED_IP_ADDRESS_SELECTION_POLICY";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BackendService.Types.IpAddressSelectionPolicy.Ipv4Only"/>
                /// .
                /// </summary>
                public const string Ipv4Only = "IPV4_ONLY";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BackendService.Types.IpAddressSelectionPolicy.Ipv6Only"/>
                /// .
                /// </summary>
                public const string Ipv6Only = "IPV6_ONLY";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BackendService.Types.IpAddressSelectionPolicy.Unspecified"/>
                /// .
                /// </summary>
                public const string Unspecified = "IP_ADDRESS_SELECTION_POLICY_UNSPECIFIED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BackendService.Types.IpAddressSelectionPolicy.PreferIpv6"/>
                /// .
                /// </summary>
                public const string PreferIpv6 = "PREFER_IPV6";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.BackendService.Types.LoadBalancingScheme"/> enum.
            /// </summary>
            public static class LoadBalancingScheme
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BackendService.Types.LoadBalancingScheme.UndefinedLoadBalancingScheme"/>
                /// .
                /// </summary>
                public const string UndefinedLoadBalancingScheme = "UNDEFINED_LOAD_BALANCING_SCHEME";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BackendService.Types.LoadBalancingScheme.External"/>.
                /// </summary>
                public const string External = "EXTERNAL";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BackendService.Types.LoadBalancingScheme.ExternalManaged"/>
                /// .
                /// </summary>
                public const string ExternalManaged = "EXTERNAL_MANAGED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BackendService.Types.LoadBalancingScheme.Internal"/>.
                /// </summary>
                public const string Internal = "INTERNAL";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BackendService.Types.LoadBalancingScheme.InternalManaged"/>
                /// .
                /// </summary>
                public const string InternalManaged = "INTERNAL_MANAGED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BackendService.Types.LoadBalancingScheme.InternalSelfManaged"/>
                /// .
                /// </summary>
                public const string InternalSelfManaged = "INTERNAL_SELF_MANAGED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BackendService.Types.LoadBalancingScheme.InvalidLoadBalancingScheme"/>
                /// .
                /// </summary>
                public const string InvalidLoadBalancingScheme = "INVALID_LOAD_BALANCING_SCHEME";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.BackendService.Types.LocalityLbPolicy"/> enum.
            /// </summary>
            public static class LocalityLbPolicy
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BackendService.Types.LocalityLbPolicy.UndefinedLocalityLbPolicy"/>
                /// .
                /// </summary>
                public const string UndefinedLocalityLbPolicy = "UNDEFINED_LOCALITY_LB_POLICY";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BackendService.Types.LocalityLbPolicy.InvalidLbPolicy"/>.
                /// </summary>
                public const string InvalidLbPolicy = "INVALID_LB_POLICY";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BackendService.Types.LocalityLbPolicy.LeastRequest"/>.
                /// </summary>
                public const string LeastRequest = "LEAST_REQUEST";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BackendService.Types.LocalityLbPolicy.Maglev"/>.
                /// </summary>
                public const string Maglev = "MAGLEV";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BackendService.Types.LocalityLbPolicy.OriginalDestination"/>
                /// .
                /// </summary>
                public const string OriginalDestination = "ORIGINAL_DESTINATION";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BackendService.Types.LocalityLbPolicy.Random"/>.
                /// </summary>
                public const string Random = "RANDOM";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BackendService.Types.LocalityLbPolicy.RingHash"/>.
                /// </summary>
                public const string RingHash = "RING_HASH";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BackendService.Types.LocalityLbPolicy.RoundRobin"/>.
                /// </summary>
                public const string RoundRobin = "ROUND_ROBIN";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BackendService.Types.LocalityLbPolicy.WeightedMaglev"/>.
                /// </summary>
                public const string WeightedMaglev = "WEIGHTED_MAGLEV";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BackendService.Types.LocalityLbPolicy.WeightedRoundRobin"/>
                /// .
                /// </summary>
                public const string WeightedRoundRobin = "WEIGHTED_ROUND_ROBIN";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.BackendService.Types.Protocol"/> enum.
            /// </summary>
            public static class Protocol
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BackendService.Types.Protocol.UndefinedProtocol"/>.
                /// </summary>
                public const string UndefinedProtocol = "UNDEFINED_PROTOCOL";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BackendService.Types.Protocol.Grpc"/>.
                /// </summary>
                public const string Grpc = "GRPC";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BackendService.Types.Protocol.H2C"/>.
                /// </summary>
                public const string H2C = "H2C";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BackendService.Types.Protocol.Http"/>.
                /// </summary>
                public const string Http = "HTTP";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BackendService.Types.Protocol.Http2"/>.
                /// </summary>
                public const string Http2 = "HTTP2";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BackendService.Types.Protocol.Https"/>.
                /// </summary>
                public const string Https = "HTTPS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BackendService.Types.Protocol.Ssl"/>.
                /// </summary>
                public const string Ssl = "SSL";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BackendService.Types.Protocol.Tcp"/>.
                /// </summary>
                public const string Tcp = "TCP";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BackendService.Types.Protocol.Udp"/>.
                /// </summary>
                public const string Udp = "UDP";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BackendService.Types.Protocol.Unspecified"/>.
                /// </summary>
                public const string Unspecified = "UNSPECIFIED";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.BackendService.Types.SessionAffinity"/> enum.
            /// </summary>
            public static class SessionAffinity
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BackendService.Types.SessionAffinity.UndefinedSessionAffinity"/>
                /// .
                /// </summary>
                public const string UndefinedSessionAffinity = "UNDEFINED_SESSION_AFFINITY";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BackendService.Types.SessionAffinity.ClientIp"/>.
                /// </summary>
                public const string ClientIp = "CLIENT_IP";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BackendService.Types.SessionAffinity.ClientIpNoDestination"/>
                /// .
                /// </summary>
                public const string ClientIpNoDestination = "CLIENT_IP_NO_DESTINATION";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BackendService.Types.SessionAffinity.ClientIpPortProto"/>
                /// .
                /// </summary>
                public const string ClientIpPortProto = "CLIENT_IP_PORT_PROTO";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BackendService.Types.SessionAffinity.ClientIpProto"/>.
                /// </summary>
                public const string ClientIpProto = "CLIENT_IP_PROTO";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BackendService.Types.SessionAffinity.GeneratedCookie"/>.
                /// </summary>
                public const string GeneratedCookie = "GENERATED_COOKIE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BackendService.Types.SessionAffinity.HeaderField"/>.
                /// </summary>
                public const string HeaderField = "HEADER_FIELD";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BackendService.Types.SessionAffinity.HttpCookie"/>.
                /// </summary>
                public const string HttpCookie = "HTTP_COOKIE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BackendService.Types.SessionAffinity.None"/>.
                /// </summary>
                public const string None = "NONE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BackendService.Types.SessionAffinity.StrongCookieAffinity"/>
                /// .
                /// </summary>
                public const string StrongCookieAffinity = "STRONG_COOKIE_AFFINITY";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.BackendServiceCdnPolicy"/>
        /// message.
        /// </summary>
        public static class BackendServiceCdnPolicy
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.BackendServiceCdnPolicy.Types.CacheMode"/> enum.
            /// </summary>
            public static class CacheMode
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BackendServiceCdnPolicy.Types.CacheMode.UndefinedCacheMode"/>
                /// .
                /// </summary>
                public const string UndefinedCacheMode = "UNDEFINED_CACHE_MODE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BackendServiceCdnPolicy.Types.CacheMode.CacheAllStatic"/>
                /// .
                /// </summary>
                public const string CacheAllStatic = "CACHE_ALL_STATIC";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BackendServiceCdnPolicy.Types.CacheMode.ForceCacheAll"/>.
                /// </summary>
                public const string ForceCacheAll = "FORCE_CACHE_ALL";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BackendServiceCdnPolicy.Types.CacheMode.InvalidCacheMode"/>
                /// .
                /// </summary>
                public const string InvalidCacheMode = "INVALID_CACHE_MODE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BackendServiceCdnPolicy.Types.CacheMode.UseOriginHeaders"/>
                /// .
                /// </summary>
                public const string UseOriginHeaders = "USE_ORIGIN_HEADERS";
            }
        }

        /// <summary>
        /// Container class for enums within the
        /// <see cref="global::Google.Cloud.Compute.V1.BackendServiceConnectionTrackingPolicy"/> message.
        /// </summary>
        public static class BackendServiceConnectionTrackingPolicy
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.BackendServiceConnectionTrackingPolicy.Types.ConnectionPersistenceOnUnhealthyBackends"/>
            ///  enum.
            /// </summary>
            public static class ConnectionPersistenceOnUnhealthyBackends
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BackendServiceConnectionTrackingPolicy.Types.ConnectionPersistenceOnUnhealthyBackends.UndefinedConnectionPersistenceOnUnhealthyBackends"/>
                /// .
                /// </summary>
                public const string UndefinedConnectionPersistenceOnUnhealthyBackends = "UNDEFINED_CONNECTION_PERSISTENCE_ON_UNHEALTHY_BACKENDS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BackendServiceConnectionTrackingPolicy.Types.ConnectionPersistenceOnUnhealthyBackends.AlwaysPersist"/>
                /// .
                /// </summary>
                public const string AlwaysPersist = "ALWAYS_PERSIST";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BackendServiceConnectionTrackingPolicy.Types.ConnectionPersistenceOnUnhealthyBackends.DefaultForProtocol"/>
                /// .
                /// </summary>
                public const string DefaultForProtocol = "DEFAULT_FOR_PROTOCOL";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BackendServiceConnectionTrackingPolicy.Types.ConnectionPersistenceOnUnhealthyBackends.NeverPersist"/>
                /// .
                /// </summary>
                public const string NeverPersist = "NEVER_PERSIST";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.BackendServiceConnectionTrackingPolicy.Types.TrackingMode"/>
            /// enum.
            /// </summary>
            public static class TrackingMode
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BackendServiceConnectionTrackingPolicy.Types.TrackingMode.UndefinedTrackingMode"/>
                /// .
                /// </summary>
                public const string UndefinedTrackingMode = "UNDEFINED_TRACKING_MODE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BackendServiceConnectionTrackingPolicy.Types.TrackingMode.InvalidTrackingMode"/>
                /// .
                /// </summary>
                public const string InvalidTrackingMode = "INVALID_TRACKING_MODE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BackendServiceConnectionTrackingPolicy.Types.TrackingMode.PerConnection"/>
                /// .
                /// </summary>
                public const string PerConnection = "PER_CONNECTION";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BackendServiceConnectionTrackingPolicy.Types.TrackingMode.PerSession"/>
                /// .
                /// </summary>
                public const string PerSession = "PER_SESSION";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.BackendServiceHAPolicy"/>
        /// message.
        /// </summary>
        public static class BackendServiceHAPolicy
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.BackendServiceHAPolicy.Types.FastIPMove"/> enum.
            /// </summary>
            public static class FastIPMove
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BackendServiceHAPolicy.Types.FastIPMove.UndefinedFastIPMove"/>
                /// .
                /// </summary>
                public const string UndefinedFastIPMove = "UNDEFINED_FAST_I_P_MOVE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BackendServiceHAPolicy.Types.FastIPMove.Disabled"/>.
                /// </summary>
                public const string Disabled = "DISABLED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BackendServiceHAPolicy.Types.FastIPMove.GarpRa"/>.
                /// </summary>
                public const string GarpRa = "GARP_RA";
            }
        }

        /// <summary>
        /// Container class for enums within the
        /// <see cref="global::Google.Cloud.Compute.V1.BackendServiceLocalityLoadBalancingPolicyConfigPolicy"/> message.
        /// </summary>
        public static class BackendServiceLocalityLoadBalancingPolicyConfigPolicy
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.BackendServiceLocalityLoadBalancingPolicyConfigPolicy.Types.Name"/>
            ///  enum.
            /// </summary>
            public static class Name
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BackendServiceLocalityLoadBalancingPolicyConfigPolicy.Types.Name.UndefinedName"/>
                /// .
                /// </summary>
                public const string UndefinedName = "UNDEFINED_NAME";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BackendServiceLocalityLoadBalancingPolicyConfigPolicy.Types.Name.InvalidLbPolicy"/>
                /// .
                /// </summary>
                public const string InvalidLbPolicy = "INVALID_LB_POLICY";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BackendServiceLocalityLoadBalancingPolicyConfigPolicy.Types.Name.LeastRequest"/>
                /// .
                /// </summary>
                public const string LeastRequest = "LEAST_REQUEST";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BackendServiceLocalityLoadBalancingPolicyConfigPolicy.Types.Name.Maglev"/>
                /// .
                /// </summary>
                public const string Maglev = "MAGLEV";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BackendServiceLocalityLoadBalancingPolicyConfigPolicy.Types.Name.OriginalDestination"/>
                /// .
                /// </summary>
                public const string OriginalDestination = "ORIGINAL_DESTINATION";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BackendServiceLocalityLoadBalancingPolicyConfigPolicy.Types.Name.Random"/>
                /// .
                /// </summary>
                public const string Random = "RANDOM";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BackendServiceLocalityLoadBalancingPolicyConfigPolicy.Types.Name.RingHash"/>
                /// .
                /// </summary>
                public const string RingHash = "RING_HASH";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BackendServiceLocalityLoadBalancingPolicyConfigPolicy.Types.Name.RoundRobin"/>
                /// .
                /// </summary>
                public const string RoundRobin = "ROUND_ROBIN";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BackendServiceLocalityLoadBalancingPolicyConfigPolicy.Types.Name.WeightedMaglev"/>
                /// .
                /// </summary>
                public const string WeightedMaglev = "WEIGHTED_MAGLEV";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BackendServiceLocalityLoadBalancingPolicyConfigPolicy.Types.Name.WeightedRoundRobin"/>
                /// .
                /// </summary>
                public const string WeightedRoundRobin = "WEIGHTED_ROUND_ROBIN";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.BackendServiceLogConfig"/>
        /// message.
        /// </summary>
        public static class BackendServiceLogConfig
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.BackendServiceLogConfig.Types.OptionalMode"/> enum.
            /// </summary>
            public static class OptionalMode
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BackendServiceLogConfig.Types.OptionalMode.UndefinedOptionalMode"/>
                /// .
                /// </summary>
                public const string UndefinedOptionalMode = "UNDEFINED_OPTIONAL_MODE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BackendServiceLogConfig.Types.OptionalMode.Custom"/>.
                /// </summary>
                public const string Custom = "CUSTOM";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BackendServiceLogConfig.Types.OptionalMode.ExcludeAllOptional"/>
                /// .
                /// </summary>
                public const string ExcludeAllOptional = "EXCLUDE_ALL_OPTIONAL";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BackendServiceLogConfig.Types.OptionalMode.IncludeAllOptional"/>
                /// .
                /// </summary>
                public const string IncludeAllOptional = "INCLUDE_ALL_OPTIONAL";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.BfdPacket"/> message.
        /// </summary>
        public static class BfdPacket
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.BfdPacket.Types.Diagnostic"/> enum.
            /// </summary>
            public static class Diagnostic
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BfdPacket.Types.Diagnostic.UndefinedDiagnostic"/>.
                /// </summary>
                public const string UndefinedDiagnostic = "UNDEFINED_DIAGNOSTIC";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BfdPacket.Types.Diagnostic.AdministrativelyDown"/>.
                /// </summary>
                public const string AdministrativelyDown = "ADMINISTRATIVELY_DOWN";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BfdPacket.Types.Diagnostic.ConcatenatedPathDown"/>.
                /// </summary>
                public const string ConcatenatedPathDown = "CONCATENATED_PATH_DOWN";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BfdPacket.Types.Diagnostic.ControlDetectionTimeExpired"/>
                /// .
                /// </summary>
                public const string ControlDetectionTimeExpired = "CONTROL_DETECTION_TIME_EXPIRED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BfdPacket.Types.Diagnostic.Unspecified"/>.
                /// </summary>
                public const string Unspecified = "DIAGNOSTIC_UNSPECIFIED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BfdPacket.Types.Diagnostic.EchoFunctionFailed"/>.
                /// </summary>
                public const string EchoFunctionFailed = "ECHO_FUNCTION_FAILED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BfdPacket.Types.Diagnostic.ForwardingPlaneReset"/>.
                /// </summary>
                public const string ForwardingPlaneReset = "FORWARDING_PLANE_RESET";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BfdPacket.Types.Diagnostic.NeighborSignaledSessionDown"/>
                /// .
                /// </summary>
                public const string NeighborSignaledSessionDown = "NEIGHBOR_SIGNALED_SESSION_DOWN";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BfdPacket.Types.Diagnostic.NoDiagnostic"/>.
                /// </summary>
                public const string NoDiagnostic = "NO_DIAGNOSTIC";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BfdPacket.Types.Diagnostic.PathDown"/>.
                /// </summary>
                public const string PathDown = "PATH_DOWN";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BfdPacket.Types.Diagnostic.ReverseConcatenatedPathDown"/>
                /// .
                /// </summary>
                public const string ReverseConcatenatedPathDown = "REVERSE_CONCATENATED_PATH_DOWN";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.BfdPacket.Types.State"/> enum.
            /// </summary>
            public static class State
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BfdPacket.Types.State.UndefinedState"/>.
                /// </summary>
                public const string UndefinedState = "UNDEFINED_STATE";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.BfdPacket.Types.State.AdminDown"/>
                /// .
                /// </summary>
                public const string AdminDown = "ADMIN_DOWN";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.BfdPacket.Types.State.Down"/>.
                /// </summary>
                public const string Down = "DOWN";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.BfdPacket.Types.State.Init"/>.
                /// </summary>
                public const string Init = "INIT";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BfdPacket.Types.State.Unspecified"/>.
                /// </summary>
                public const string Unspecified = "STATE_UNSPECIFIED";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.BfdPacket.Types.State.Up"/>.
                /// </summary>
                public const string Up = "UP";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.BfdStatus"/> message.
        /// </summary>
        public static class BfdStatus
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.BfdStatus.Types.BfdSessionInitializationMode"/> enum.
            /// </summary>
            public static class BfdSessionInitializationMode
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BfdStatus.Types.BfdSessionInitializationMode.UndefinedBfdSessionInitializationMode"/>
                /// .
                /// </summary>
                public const string UndefinedBfdSessionInitializationMode = "UNDEFINED_BFD_SESSION_INITIALIZATION_MODE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BfdStatus.Types.BfdSessionInitializationMode.Active"/>.
                /// </summary>
                public const string Active = "ACTIVE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BfdStatus.Types.BfdSessionInitializationMode.Disabled"/>.
                /// </summary>
                public const string Disabled = "DISABLED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BfdStatus.Types.BfdSessionInitializationMode.Passive"/>.
                /// </summary>
                public const string Passive = "PASSIVE";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.BfdStatus.Types.LocalDiagnostic"/> enum.
            /// </summary>
            public static class LocalDiagnostic
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BfdStatus.Types.LocalDiagnostic.UndefinedLocalDiagnostic"/>
                /// .
                /// </summary>
                public const string UndefinedLocalDiagnostic = "UNDEFINED_LOCAL_DIAGNOSTIC";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BfdStatus.Types.LocalDiagnostic.AdministrativelyDown"/>.
                /// </summary>
                public const string AdministrativelyDown = "ADMINISTRATIVELY_DOWN";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BfdStatus.Types.LocalDiagnostic.ConcatenatedPathDown"/>.
                /// </summary>
                public const string ConcatenatedPathDown = "CONCATENATED_PATH_DOWN";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BfdStatus.Types.LocalDiagnostic.ControlDetectionTimeExpired"/>
                /// .
                /// </summary>
                public const string ControlDetectionTimeExpired = "CONTROL_DETECTION_TIME_EXPIRED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BfdStatus.Types.LocalDiagnostic.DiagnosticUnspecified"/>.
                /// </summary>
                public const string DiagnosticUnspecified = "DIAGNOSTIC_UNSPECIFIED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BfdStatus.Types.LocalDiagnostic.EchoFunctionFailed"/>.
                /// </summary>
                public const string EchoFunctionFailed = "ECHO_FUNCTION_FAILED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BfdStatus.Types.LocalDiagnostic.ForwardingPlaneReset"/>.
                /// </summary>
                public const string ForwardingPlaneReset = "FORWARDING_PLANE_RESET";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BfdStatus.Types.LocalDiagnostic.NeighborSignaledSessionDown"/>
                /// .
                /// </summary>
                public const string NeighborSignaledSessionDown = "NEIGHBOR_SIGNALED_SESSION_DOWN";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BfdStatus.Types.LocalDiagnostic.NoDiagnostic"/>.
                /// </summary>
                public const string NoDiagnostic = "NO_DIAGNOSTIC";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BfdStatus.Types.LocalDiagnostic.PathDown"/>.
                /// </summary>
                public const string PathDown = "PATH_DOWN";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BfdStatus.Types.LocalDiagnostic.ReverseConcatenatedPathDown"/>
                /// .
                /// </summary>
                public const string ReverseConcatenatedPathDown = "REVERSE_CONCATENATED_PATH_DOWN";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.BfdStatus.Types.LocalState"/> enum.
            /// </summary>
            public static class LocalState
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BfdStatus.Types.LocalState.UndefinedLocalState"/>.
                /// </summary>
                public const string UndefinedLocalState = "UNDEFINED_LOCAL_STATE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BfdStatus.Types.LocalState.AdminDown"/>.
                /// </summary>
                public const string AdminDown = "ADMIN_DOWN";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.BfdStatus.Types.LocalState.Down"/>
                /// .
                /// </summary>
                public const string Down = "DOWN";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.BfdStatus.Types.LocalState.Init"/>
                /// .
                /// </summary>
                public const string Init = "INIT";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BfdStatus.Types.LocalState.StateUnspecified"/>.
                /// </summary>
                public const string StateUnspecified = "STATE_UNSPECIFIED";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.BfdStatus.Types.LocalState.Up"/>.
                /// </summary>
                public const string Up = "UP";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.BgpRoute"/> message.
        /// </summary>
        public static class BgpRoute
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.BgpRoute.Types.Origin"/> enum.
            /// </summary>
            public static class Origin
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BgpRoute.Types.Origin.UndefinedOrigin"/>.
                /// </summary>
                public const string UndefinedOrigin = "UNDEFINED_ORIGIN";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BgpRoute.Types.Origin.BgpOriginEgp"/>.
                /// </summary>
                public const string BgpOriginEgp = "BGP_ORIGIN_EGP";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BgpRoute.Types.Origin.BgpOriginIgp"/>.
                /// </summary>
                public const string BgpOriginIgp = "BGP_ORIGIN_IGP";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BgpRoute.Types.Origin.BgpOriginIncomplete"/>.
                /// </summary>
                public const string BgpOriginIncomplete = "BGP_ORIGIN_INCOMPLETE";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.BgpRouteAsPath"/> message.
        /// </summary>
        public static class BgpRouteAsPath
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.BgpRouteAsPath.Types.Type"/> enum.
            /// </summary>
            public static class Type
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BgpRouteAsPath.Types.Type.UndefinedType"/>.
                /// </summary>
                public const string UndefinedType = "UNDEFINED_TYPE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BgpRouteAsPath.Types.Type.AsPathTypeSequence"/>.
                /// </summary>
                public const string AsPathTypeSequence = "AS_PATH_TYPE_SEQUENCE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BgpRouteAsPath.Types.Type.AsPathTypeSet"/>.
                /// </summary>
                public const string AsPathTypeSet = "AS_PATH_TYPE_SET";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.BulkInsertOperationStatus"/>
        /// message.
        /// </summary>
        public static class BulkInsertOperationStatus
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.BulkInsertOperationStatus.Types.Status"/> enum.
            /// </summary>
            public static class Status
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BulkInsertOperationStatus.Types.Status.UndefinedStatus"/>
                /// .
                /// </summary>
                public const string UndefinedStatus = "UNDEFINED_STATUS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BulkInsertOperationStatus.Types.Status.Creating"/>.
                /// </summary>
                public const string Creating = "CREATING";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BulkInsertOperationStatus.Types.Status.Done"/>.
                /// </summary>
                public const string Done = "DONE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BulkInsertOperationStatus.Types.Status.RollingBack"/>.
                /// </summary>
                public const string RollingBack = "ROLLING_BACK";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.BulkInsertOperationStatus.Types.Status.Unspecified"/>.
                /// </summary>
                public const string Unspecified = "STATUS_UNSPECIFIED";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.Commitment"/> message.
        /// </summary>
        public static class Commitment
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.Commitment.Types.Category"/> enum.
            /// </summary>
            public static class Category
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Commitment.Types.Category.UndefinedCategory"/>.
                /// </summary>
                public const string UndefinedCategory = "UNDEFINED_CATEGORY";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Commitment.Types.Category.Unspecified"/>.
                /// </summary>
                public const string Unspecified = "CATEGORY_UNSPECIFIED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Commitment.Types.Category.License"/>.
                /// </summary>
                public const string License = "LICENSE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Commitment.Types.Category.Machine"/>.
                /// </summary>
                public const string Machine = "MACHINE";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.Commitment.Types.Plan"/> enum.
            /// </summary>
            public static class Plan
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Commitment.Types.Plan.UndefinedPlan"/>.
                /// </summary>
                public const string UndefinedPlan = "UNDEFINED_PLAN";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.Commitment.Types.Plan.Invalid"/>.
                /// </summary>
                public const string Invalid = "INVALID";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Commitment.Types.Plan.ThirtySixMonth"/>.
                /// </summary>
                public const string ThirtySixMonth = "THIRTY_SIX_MONTH";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Commitment.Types.Plan.TwelveMonth"/>.
                /// </summary>
                public const string TwelveMonth = "TWELVE_MONTH";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.Commitment.Types.Status"/> enum.
            /// </summary>
            public static class Status
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Commitment.Types.Status.UndefinedStatus"/>.
                /// </summary>
                public const string UndefinedStatus = "UNDEFINED_STATUS";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.Commitment.Types.Status.Active"/>.
                /// </summary>
                public const string Active = "ACTIVE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Commitment.Types.Status.Cancelled"/>.
                /// </summary>
                public const string Cancelled = "CANCELLED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Commitment.Types.Status.Creating"/>.
                /// </summary>
                public const string Creating = "CREATING";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.Commitment.Types.Status.Expired"/>
                /// .
                /// </summary>
                public const string Expired = "EXPIRED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Commitment.Types.Status.NotYetActive"/>.
                /// </summary>
                public const string NotYetActive = "NOT_YET_ACTIVE";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.Commitment.Types.Type"/> enum.
            /// </summary>
            public static class Type
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Commitment.Types.Type.UndefinedType"/>.
                /// </summary>
                public const string UndefinedType = "UNDEFINED_TYPE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Commitment.Types.Type.AcceleratorOptimized"/>.
                /// </summary>
                public const string AcceleratorOptimized = "ACCELERATOR_OPTIMIZED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Commitment.Types.Type.AcceleratorOptimizedA3"/>.
                /// </summary>
                public const string AcceleratorOptimizedA3 = "ACCELERATOR_OPTIMIZED_A3";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Commitment.Types.Type.AcceleratorOptimizedA3Mega"/>.
                /// </summary>
                public const string AcceleratorOptimizedA3Mega = "ACCELERATOR_OPTIMIZED_A3_MEGA";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Commitment.Types.Type.AcceleratorOptimizedA3Ultra"/>.
                /// </summary>
                public const string AcceleratorOptimizedA3Ultra = "ACCELERATOR_OPTIMIZED_A3_ULTRA";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Commitment.Types.Type.AcceleratorOptimizedA4"/>.
                /// </summary>
                public const string AcceleratorOptimizedA4 = "ACCELERATOR_OPTIMIZED_A4";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Commitment.Types.Type.ComputeOptimized"/>.
                /// </summary>
                public const string ComputeOptimized = "COMPUTE_OPTIMIZED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Commitment.Types.Type.ComputeOptimizedC2D"/>.
                /// </summary>
                public const string ComputeOptimizedC2D = "COMPUTE_OPTIMIZED_C2D";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Commitment.Types.Type.ComputeOptimizedC3"/>.
                /// </summary>
                public const string ComputeOptimizedC3 = "COMPUTE_OPTIMIZED_C3";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Commitment.Types.Type.ComputeOptimizedC3D"/>.
                /// </summary>
                public const string ComputeOptimizedC3D = "COMPUTE_OPTIMIZED_C3D";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Commitment.Types.Type.ComputeOptimizedH3"/>.
                /// </summary>
                public const string ComputeOptimizedH3 = "COMPUTE_OPTIMIZED_H3";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Commitment.Types.Type.ComputeOptimizedH4D"/>.
                /// </summary>
                public const string ComputeOptimizedH4D = "COMPUTE_OPTIMIZED_H4D";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Commitment.Types.Type.GeneralPurpose"/>.
                /// </summary>
                public const string GeneralPurpose = "GENERAL_PURPOSE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Commitment.Types.Type.GeneralPurposeC4"/>.
                /// </summary>
                public const string GeneralPurposeC4 = "GENERAL_PURPOSE_C4";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Commitment.Types.Type.GeneralPurposeC4A"/>.
                /// </summary>
                public const string GeneralPurposeC4A = "GENERAL_PURPOSE_C4A";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Commitment.Types.Type.GeneralPurposeC4D"/>.
                /// </summary>
                public const string GeneralPurposeC4D = "GENERAL_PURPOSE_C4D";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Commitment.Types.Type.GeneralPurposeE2"/>.
                /// </summary>
                public const string GeneralPurposeE2 = "GENERAL_PURPOSE_E2";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Commitment.Types.Type.GeneralPurposeN2"/>.
                /// </summary>
                public const string GeneralPurposeN2 = "GENERAL_PURPOSE_N2";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Commitment.Types.Type.GeneralPurposeN2D"/>.
                /// </summary>
                public const string GeneralPurposeN2D = "GENERAL_PURPOSE_N2D";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Commitment.Types.Type.GeneralPurposeN4"/>.
                /// </summary>
                public const string GeneralPurposeN4 = "GENERAL_PURPOSE_N4";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Commitment.Types.Type.GeneralPurposeT2D"/>.
                /// </summary>
                public const string GeneralPurposeT2D = "GENERAL_PURPOSE_T2D";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Commitment.Types.Type.GraphicsOptimized"/>.
                /// </summary>
                public const string GraphicsOptimized = "GRAPHICS_OPTIMIZED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Commitment.Types.Type.MemoryOptimized"/>.
                /// </summary>
                public const string MemoryOptimized = "MEMORY_OPTIMIZED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Commitment.Types.Type.MemoryOptimizedM3"/>.
                /// </summary>
                public const string MemoryOptimizedM3 = "MEMORY_OPTIMIZED_M3";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Commitment.Types.Type.MemoryOptimizedM4"/>.
                /// </summary>
                public const string MemoryOptimizedM4 = "MEMORY_OPTIMIZED_M4";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Commitment.Types.Type.MemoryOptimizedM46Tb"/>.
                /// </summary>
                public const string MemoryOptimizedM46Tb = "MEMORY_OPTIMIZED_M4_6TB";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Commitment.Types.Type.MemoryOptimizedX416Tb"/>.
                /// </summary>
                public const string MemoryOptimizedX416Tb = "MEMORY_OPTIMIZED_X4_16TB";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Commitment.Types.Type.MemoryOptimizedX424Tb"/>.
                /// </summary>
                public const string MemoryOptimizedX424Tb = "MEMORY_OPTIMIZED_X4_24TB";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Commitment.Types.Type.MemoryOptimizedX432Tb"/>.
                /// </summary>
                public const string MemoryOptimizedX432Tb = "MEMORY_OPTIMIZED_X4_32TB";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Commitment.Types.Type.StorageOptimizedZ3"/>.
                /// </summary>
                public const string StorageOptimizedZ3 = "STORAGE_OPTIMIZED_Z3";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Commitment.Types.Type.Unspecified"/>.
                /// </summary>
                public const string Unspecified = "TYPE_UNSPECIFIED";
            }
        }

        /// <summary>
        /// Container class for enums within the
        /// <see cref="global::Google.Cloud.Compute.V1.ConfidentialInstanceConfig"/> message.
        /// </summary>
        public static class ConfidentialInstanceConfig
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.ConfidentialInstanceConfig.Types.ConfidentialInstanceType"/>
            /// enum.
            /// </summary>
            public static class ConfidentialInstanceType
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ConfidentialInstanceConfig.Types.ConfidentialInstanceType.UndefinedConfidentialInstanceType"/>
                /// .
                /// </summary>
                public const string UndefinedConfidentialInstanceType = "UNDEFINED_CONFIDENTIAL_INSTANCE_TYPE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ConfidentialInstanceConfig.Types.ConfidentialInstanceType.Unspecified"/>
                /// .
                /// </summary>
                public const string Unspecified = "CONFIDENTIAL_INSTANCE_TYPE_UNSPECIFIED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ConfidentialInstanceConfig.Types.ConfidentialInstanceType.Sev"/>
                /// .
                /// </summary>
                public const string Sev = "SEV";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ConfidentialInstanceConfig.Types.ConfidentialInstanceType.SevSnp"/>
                /// .
                /// </summary>
                public const string SevSnp = "SEV_SNP";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ConfidentialInstanceConfig.Types.ConfidentialInstanceType.Tdx"/>
                /// .
                /// </summary>
                public const string Tdx = "TDX";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.DeprecationStatus"/>
        /// message.
        /// </summary>
        public static class DeprecationStatus
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.DeprecationStatus.Types.State"/> enum.
            /// </summary>
            public static class State
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.DeprecationStatus.Types.State.UndefinedState"/>.
                /// </summary>
                public const string UndefinedState = "UNDEFINED_STATE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.DeprecationStatus.Types.State.Active"/>.
                /// </summary>
                public const string Active = "ACTIVE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.DeprecationStatus.Types.State.Deleted"/>.
                /// </summary>
                public const string Deleted = "DELETED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.DeprecationStatus.Types.State.Deprecated"/>.
                /// </summary>
                public const string Deprecated = "DEPRECATED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.DeprecationStatus.Types.State.Obsolete"/>.
                /// </summary>
                public const string Obsolete = "OBSOLETE";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.Disk"/> message.
        /// </summary>
        public static class Disk
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.Disk.Types.AccessMode"/> enum.
            /// </summary>
            public static class AccessMode
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Disk.Types.AccessMode.UndefinedAccessMode"/>.
                /// </summary>
                public const string UndefinedAccessMode = "UNDEFINED_ACCESS_MODE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Disk.Types.AccessMode.ReadOnlyMany"/>.
                /// </summary>
                public const string ReadOnlyMany = "READ_ONLY_MANY";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Disk.Types.AccessMode.ReadWriteMany"/>.
                /// </summary>
                public const string ReadWriteMany = "READ_WRITE_MANY";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Disk.Types.AccessMode.ReadWriteSingle"/>.
                /// </summary>
                public const string ReadWriteSingle = "READ_WRITE_SINGLE";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.Disk.Types.Architecture"/> enum.
            /// </summary>
            public static class Architecture
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Disk.Types.Architecture.UndefinedArchitecture"/>.
                /// </summary>
                public const string UndefinedArchitecture = "UNDEFINED_ARCHITECTURE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Disk.Types.Architecture.Unspecified"/>.
                /// </summary>
                public const string Unspecified = "ARCHITECTURE_UNSPECIFIED";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.Disk.Types.Architecture.Arm64"/>.
                /// </summary>
                public const string Arm64 = "ARM64";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.Disk.Types.Architecture.X8664"/>.
                /// </summary>
                public const string X8664 = "X86_64";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.Disk.Types.Status"/> enum.
            /// </summary>
            public static class Status
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Disk.Types.Status.UndefinedStatus"/>.
                /// </summary>
                public const string UndefinedStatus = "UNDEFINED_STATUS";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.Disk.Types.Status.Creating"/>.
                /// </summary>
                public const string Creating = "CREATING";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.Disk.Types.Status.Deleting"/>.
                /// </summary>
                public const string Deleting = "DELETING";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.Disk.Types.Status.Failed"/>.
                /// </summary>
                public const string Failed = "FAILED";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.Disk.Types.Status.Ready"/>.
                /// </summary>
                public const string Ready = "READY";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.Disk.Types.Status.Restoring"/>.
                /// </summary>
                public const string Restoring = "RESTORING";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.Disk.Types.Status.Unavailable"/>.
                /// </summary>
                public const string Unavailable = "UNAVAILABLE";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.DiskInstantiationConfig"/>
        /// message.
        /// </summary>
        public static class DiskInstantiationConfig
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.DiskInstantiationConfig.Types.InstantiateFrom"/> enum.
            /// </summary>
            public static class InstantiateFrom
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.DiskInstantiationConfig.Types.InstantiateFrom.UndefinedInstantiateFrom"/>
                /// .
                /// </summary>
                public const string UndefinedInstantiateFrom = "UNDEFINED_INSTANTIATE_FROM";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.DiskInstantiationConfig.Types.InstantiateFrom.AttachReadOnly"/>
                /// .
                /// </summary>
                public const string AttachReadOnly = "ATTACH_READ_ONLY";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.DiskInstantiationConfig.Types.InstantiateFrom.Blank"/>.
                /// </summary>
                public const string Blank = "BLANK";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.DiskInstantiationConfig.Types.InstantiateFrom.CustomImage"/>
                /// .
                /// </summary>
                public const string CustomImage = "CUSTOM_IMAGE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.DiskInstantiationConfig.Types.InstantiateFrom.Default"/>.
                /// </summary>
                public const string Default = "DEFAULT";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.DiskInstantiationConfig.Types.InstantiateFrom.DoNotInclude"/>
                /// .
                /// </summary>
                public const string DoNotInclude = "DO_NOT_INCLUDE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.DiskInstantiationConfig.Types.InstantiateFrom.SourceImage"/>
                /// .
                /// </summary>
                public const string SourceImage = "SOURCE_IMAGE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.DiskInstantiationConfig.Types.InstantiateFrom.SourceImageFamily"/>
                /// .
                /// </summary>
                public const string SourceImageFamily = "SOURCE_IMAGE_FAMILY";
            }
        }

        /// <summary>
        /// Container class for enums within the
        /// <see cref="global::Google.Cloud.Compute.V1.DiskResourceStatusAsyncReplicationStatus"/> message.
        /// </summary>
        public static class DiskResourceStatusAsyncReplicationStatus
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.DiskResourceStatusAsyncReplicationStatus.Types.State"/> enum.
            /// </summary>
            public static class State
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.DiskResourceStatusAsyncReplicationStatus.Types.State.UndefinedState"/>
                /// .
                /// </summary>
                public const string UndefinedState = "UNDEFINED_STATE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.DiskResourceStatusAsyncReplicationStatus.Types.State.Active"/>
                /// .
                /// </summary>
                public const string Active = "ACTIVE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.DiskResourceStatusAsyncReplicationStatus.Types.State.Created"/>
                /// .
                /// </summary>
                public const string Created = "CREATED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.DiskResourceStatusAsyncReplicationStatus.Types.State.Starting"/>
                /// .
                /// </summary>
                public const string Starting = "STARTING";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.DiskResourceStatusAsyncReplicationStatus.Types.State.Unspecified"/>
                /// .
                /// </summary>
                public const string Unspecified = "STATE_UNSPECIFIED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.DiskResourceStatusAsyncReplicationStatus.Types.State.Stopped"/>
                /// .
                /// </summary>
                public const string Stopped = "STOPPED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.DiskResourceStatusAsyncReplicationStatus.Types.State.Stopping"/>
                /// .
                /// </summary>
                public const string Stopping = "STOPPING";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.DistributionPolicy"/>
        /// message.
        /// </summary>
        public static class DistributionPolicy
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.DistributionPolicy.Types.TargetShape"/> enum.
            /// </summary>
            public static class TargetShape
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.DistributionPolicy.Types.TargetShape.UndefinedTargetShape"/>
                /// .
                /// </summary>
                public const string UndefinedTargetShape = "UNDEFINED_TARGET_SHAPE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.DistributionPolicy.Types.TargetShape.Any"/>.
                /// </summary>
                public const string Any = "ANY";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.DistributionPolicy.Types.TargetShape.AnySingleZone"/>.
                /// </summary>
                public const string AnySingleZone = "ANY_SINGLE_ZONE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.DistributionPolicy.Types.TargetShape.Balanced"/>.
                /// </summary>
                public const string Balanced = "BALANCED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.DistributionPolicy.Types.TargetShape.Even"/>.
                /// </summary>
                public const string Even = "EVEN";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.ExchangedPeeringRoute"/>
        /// message.
        /// </summary>
        public static class ExchangedPeeringRoute
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.ExchangedPeeringRoute.Types.Type"/> enum.
            /// </summary>
            public static class Type
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ExchangedPeeringRoute.Types.Type.UndefinedType"/>.
                /// </summary>
                public const string UndefinedType = "UNDEFINED_TYPE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ExchangedPeeringRoute.Types.Type.DynamicPeeringRoute"/>.
                /// </summary>
                public const string DynamicPeeringRoute = "DYNAMIC_PEERING_ROUTE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ExchangedPeeringRoute.Types.Type.StaticPeeringRoute"/>.
                /// </summary>
                public const string StaticPeeringRoute = "STATIC_PEERING_ROUTE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ExchangedPeeringRoute.Types.Type.SubnetPeeringRoute"/>.
                /// </summary>
                public const string SubnetPeeringRoute = "SUBNET_PEERING_ROUTE";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.ExternalVpnGateway"/>
        /// message.
        /// </summary>
        public static class ExternalVpnGateway
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.ExternalVpnGateway.Types.RedundancyType"/> enum.
            /// </summary>
            public static class RedundancyType
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ExternalVpnGateway.Types.RedundancyType.UndefinedRedundancyType"/>
                /// .
                /// </summary>
                public const string UndefinedRedundancyType = "UNDEFINED_REDUNDANCY_TYPE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ExternalVpnGateway.Types.RedundancyType.FourIpsRedundancy"/>
                /// .
                /// </summary>
                public const string FourIpsRedundancy = "FOUR_IPS_REDUNDANCY";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ExternalVpnGateway.Types.RedundancyType.SingleIpInternallyRedundant"/>
                /// .
                /// </summary>
                public const string SingleIpInternallyRedundant = "SINGLE_IP_INTERNALLY_REDUNDANT";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ExternalVpnGateway.Types.RedundancyType.TwoIpsRedundancy"/>
                /// .
                /// </summary>
                public const string TwoIpsRedundancy = "TWO_IPS_REDUNDANCY";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.FileContentBuffer"/>
        /// message.
        /// </summary>
        public static class FileContentBuffer
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.FileContentBuffer.Types.FileType"/> enum.
            /// </summary>
            public static class FileType
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.FileContentBuffer.Types.FileType.UndefinedFileType"/>.
                /// </summary>
                public const string UndefinedFileType = "UNDEFINED_FILE_TYPE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.FileContentBuffer.Types.FileType.Bin"/>.
                /// </summary>
                public const string Bin = "BIN";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.FileContentBuffer.Types.FileType.Undefined"/>.
                /// </summary>
                public const string Undefined = "UNDEFINED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.FileContentBuffer.Types.FileType.X509"/>.
                /// </summary>
                public const string X509 = "X509";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.Firewall"/> message.
        /// </summary>
        public static class Firewall
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.Firewall.Types.Direction"/> enum.
            /// </summary>
            public static class Direction
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Firewall.Types.Direction.UndefinedDirection"/>.
                /// </summary>
                public const string UndefinedDirection = "UNDEFINED_DIRECTION";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.Firewall.Types.Direction.Egress"/>
                /// .
                /// </summary>
                public const string Egress = "EGRESS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Firewall.Types.Direction.Ingress"/>.
                /// </summary>
                public const string Ingress = "INGRESS";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.FirewallLogConfig"/>
        /// message.
        /// </summary>
        public static class FirewallLogConfig
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.FirewallLogConfig.Types.Metadata"/> enum.
            /// </summary>
            public static class Metadata
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.FirewallLogConfig.Types.Metadata.UndefinedMetadata"/>.
                /// </summary>
                public const string UndefinedMetadata = "UNDEFINED_METADATA";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.FirewallLogConfig.Types.Metadata.ExcludeAllMetadata"/>.
                /// </summary>
                public const string ExcludeAllMetadata = "EXCLUDE_ALL_METADATA";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.FirewallLogConfig.Types.Metadata.IncludeAllMetadata"/>.
                /// </summary>
                public const string IncludeAllMetadata = "INCLUDE_ALL_METADATA";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.FirewallPolicyRule"/>
        /// message.
        /// </summary>
        public static class FirewallPolicyRule
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.FirewallPolicyRule.Types.Direction"/> enum.
            /// </summary>
            public static class Direction
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.FirewallPolicyRule.Types.Direction.UndefinedDirection"/>.
                /// </summary>
                public const string UndefinedDirection = "UNDEFINED_DIRECTION";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.FirewallPolicyRule.Types.Direction.Egress"/>.
                /// </summary>
                public const string Egress = "EGRESS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.FirewallPolicyRule.Types.Direction.Ingress"/>.
                /// </summary>
                public const string Ingress = "INGRESS";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.FirewallPolicyRuleMatcher"/>
        /// message.
        /// </summary>
        public static class FirewallPolicyRuleMatcher
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.FirewallPolicyRuleMatcher.Types.DestNetworkType"/> enum.
            /// </summary>
            public static class DestNetworkType
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.FirewallPolicyRuleMatcher.Types.DestNetworkType.UndefinedDestNetworkType"/>
                /// .
                /// </summary>
                public const string UndefinedDestNetworkType = "UNDEFINED_DEST_NETWORK_TYPE";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.FirewallPolicyRuleMatcher.Types.SrcNetworkType"/> enum.
            /// </summary>
            public static class SrcNetworkType
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.FirewallPolicyRuleMatcher.Types.SrcNetworkType.UndefinedSrcNetworkType"/>
                /// .
                /// </summary>
                public const string UndefinedSrcNetworkType = "UNDEFINED_SRC_NETWORK_TYPE";
            }
        }

        /// <summary>
        /// Container class for enums within the
        /// <see cref="global::Google.Cloud.Compute.V1.FirewallPolicyRuleSecureTag"/> message.
        /// </summary>
        public static class FirewallPolicyRuleSecureTag
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.FirewallPolicyRuleSecureTag.Types.State"/> enum.
            /// </summary>
            public static class State
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.FirewallPolicyRuleSecureTag.Types.State.UndefinedState"/>
                /// .
                /// </summary>
                public const string UndefinedState = "UNDEFINED_STATE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.FirewallPolicyRuleSecureTag.Types.State.Effective"/>.
                /// </summary>
                public const string Effective = "EFFECTIVE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.FirewallPolicyRuleSecureTag.Types.State.Ineffective"/>.
                /// </summary>
                public const string Ineffective = "INEFFECTIVE";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.ForwardingRule"/> message.
        /// </summary>
        public static class ForwardingRule
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.ForwardingRule.Types.ExternalManagedBackendBucketMigrationState"/>
            ///  enum.
            /// </summary>
            public static class ExternalManagedBackendBucketMigrationState
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ForwardingRule.Types.ExternalManagedBackendBucketMigrationState.UndefinedExternalManagedBackendBucketMigrationState"/>
                /// .
                /// </summary>
                public const string UndefinedExternalManagedBackendBucketMigrationState = "UNDEFINED_EXTERNAL_MANAGED_BACKEND_BUCKET_MIGRATION_STATE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ForwardingRule.Types.ExternalManagedBackendBucketMigrationState.Prepare"/>
                /// .
                /// </summary>
                public const string Prepare = "PREPARE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ForwardingRule.Types.ExternalManagedBackendBucketMigrationState.TestAllTraffic"/>
                /// .
                /// </summary>
                public const string TestAllTraffic = "TEST_ALL_TRAFFIC";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ForwardingRule.Types.ExternalManagedBackendBucketMigrationState.TestByPercentage"/>
                /// .
                /// </summary>
                public const string TestByPercentage = "TEST_BY_PERCENTAGE";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.ForwardingRule.Types.IPProtocolEnum"/> enum.
            /// </summary>
            public static class IPProtocolEnum
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ForwardingRule.Types.IPProtocolEnum.UndefinedIPProtocolEnum"/>
                /// .
                /// </summary>
                public const string UndefinedIPProtocolEnum = "UNDEFINED_I_P_PROTOCOL_ENUM";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ForwardingRule.Types.IPProtocolEnum.Ah"/>.
                /// </summary>
                public const string Ah = "AH";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ForwardingRule.Types.IPProtocolEnum.Esp"/>.
                /// </summary>
                public const string Esp = "ESP";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ForwardingRule.Types.IPProtocolEnum.Icmp"/>.
                /// </summary>
                public const string Icmp = "ICMP";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ForwardingRule.Types.IPProtocolEnum.L3Default"/>.
                /// </summary>
                public const string L3Default = "L3_DEFAULT";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ForwardingRule.Types.IPProtocolEnum.Sctp"/>.
                /// </summary>
                public const string Sctp = "SCTP";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ForwardingRule.Types.IPProtocolEnum.Tcp"/>.
                /// </summary>
                public const string Tcp = "TCP";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ForwardingRule.Types.IPProtocolEnum.Udp"/>.
                /// </summary>
                public const string Udp = "UDP";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.ForwardingRule.Types.IpVersion"/> enum.
            /// </summary>
            public static class IpVersion
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ForwardingRule.Types.IpVersion.UndefinedIpVersion"/>.
                /// </summary>
                public const string UndefinedIpVersion = "UNDEFINED_IP_VERSION";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ForwardingRule.Types.IpVersion.Ipv4"/>.
                /// </summary>
                public const string Ipv4 = "IPV4";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ForwardingRule.Types.IpVersion.Ipv6"/>.
                /// </summary>
                public const string Ipv6 = "IPV6";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ForwardingRule.Types.IpVersion.UnspecifiedVersion"/>.
                /// </summary>
                public const string UnspecifiedVersion = "UNSPECIFIED_VERSION";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.ForwardingRule.Types.LoadBalancingScheme"/> enum.
            /// </summary>
            public static class LoadBalancingScheme
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ForwardingRule.Types.LoadBalancingScheme.UndefinedLoadBalancingScheme"/>
                /// .
                /// </summary>
                public const string UndefinedLoadBalancingScheme = "UNDEFINED_LOAD_BALANCING_SCHEME";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ForwardingRule.Types.LoadBalancingScheme.External"/>.
                /// </summary>
                public const string External = "EXTERNAL";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ForwardingRule.Types.LoadBalancingScheme.ExternalManaged"/>
                /// .
                /// </summary>
                public const string ExternalManaged = "EXTERNAL_MANAGED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ForwardingRule.Types.LoadBalancingScheme.Internal"/>.
                /// </summary>
                public const string Internal = "INTERNAL";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ForwardingRule.Types.LoadBalancingScheme.InternalManaged"/>
                /// .
                /// </summary>
                public const string InternalManaged = "INTERNAL_MANAGED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ForwardingRule.Types.LoadBalancingScheme.InternalSelfManaged"/>
                /// .
                /// </summary>
                public const string InternalSelfManaged = "INTERNAL_SELF_MANAGED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ForwardingRule.Types.LoadBalancingScheme.Invalid"/>.
                /// </summary>
                public const string Invalid = "INVALID";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.ForwardingRule.Types.NetworkTier"/> enum.
            /// </summary>
            public static class NetworkTier
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ForwardingRule.Types.NetworkTier.UndefinedNetworkTier"/>.
                /// </summary>
                public const string UndefinedNetworkTier = "UNDEFINED_NETWORK_TIER";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ForwardingRule.Types.NetworkTier.FixedStandard"/>.
                /// </summary>
                public const string FixedStandard = "FIXED_STANDARD";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ForwardingRule.Types.NetworkTier.Premium"/>.
                /// </summary>
                public const string Premium = "PREMIUM";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ForwardingRule.Types.NetworkTier.Standard"/>.
                /// </summary>
                public const string Standard = "STANDARD";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ForwardingRule.Types.NetworkTier.StandardOverridesFixedStandard"/>
                /// .
                /// </summary>
                public const string StandardOverridesFixedStandard = "STANDARD_OVERRIDES_FIXED_STANDARD";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.ForwardingRule.Types.PscConnectionStatus"/> enum.
            /// </summary>
            public static class PscConnectionStatus
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ForwardingRule.Types.PscConnectionStatus.UndefinedPscConnectionStatus"/>
                /// .
                /// </summary>
                public const string UndefinedPscConnectionStatus = "UNDEFINED_PSC_CONNECTION_STATUS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ForwardingRule.Types.PscConnectionStatus.Accepted"/>.
                /// </summary>
                public const string Accepted = "ACCEPTED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ForwardingRule.Types.PscConnectionStatus.Closed"/>.
                /// </summary>
                public const string Closed = "CLOSED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ForwardingRule.Types.PscConnectionStatus.NeedsAttention"/>
                /// .
                /// </summary>
                public const string NeedsAttention = "NEEDS_ATTENTION";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ForwardingRule.Types.PscConnectionStatus.Pending"/>.
                /// </summary>
                public const string Pending = "PENDING";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ForwardingRule.Types.PscConnectionStatus.Rejected"/>.
                /// </summary>
                public const string Rejected = "REJECTED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ForwardingRule.Types.PscConnectionStatus.StatusUnspecified"/>
                /// .
                /// </summary>
                public const string StatusUnspecified = "STATUS_UNSPECIFIED";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.GRPCHealthCheck"/> message.
        /// </summary>
        public static class GRPCHealthCheck
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.GRPCHealthCheck.Types.PortSpecification"/> enum.
            /// </summary>
            public static class PortSpecification
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.GRPCHealthCheck.Types.PortSpecification.UndefinedPortSpecification"/>
                /// .
                /// </summary>
                public const string UndefinedPortSpecification = "UNDEFINED_PORT_SPECIFICATION";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.GRPCHealthCheck.Types.PortSpecification.UseFixedPort"/>.
                /// </summary>
                public const string UseFixedPort = "USE_FIXED_PORT";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.GRPCHealthCheck.Types.PortSpecification.UseNamedPort"/>.
                /// </summary>
                public const string UseNamedPort = "USE_NAMED_PORT";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.GRPCHealthCheck.Types.PortSpecification.UseServingPort"/>
                /// .
                /// </summary>
                public const string UseServingPort = "USE_SERVING_PORT";
            }
        }

        /// <summary>
        /// Container class for enums within the
        /// <see cref="global::Google.Cloud.Compute.V1.GetReservationBlockRequest"/> message.
        /// </summary>
        public static class GetReservationBlockRequest
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.GetReservationBlockRequest.Types.View"/> enum.
            /// </summary>
            public static class View
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.GetReservationBlockRequest.Types.View.UndefinedView"/>.
                /// </summary>
                public const string UndefinedView = "UNDEFINED_VIEW";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.GetReservationBlockRequest.Types.View.Basic"/>.
                /// </summary>
                public const string Basic = "BASIC";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.GetReservationBlockRequest.Types.View.BlockViewUnspecified"/>
                /// .
                /// </summary>
                public const string BlockViewUnspecified = "BLOCK_VIEW_UNSPECIFIED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.GetReservationBlockRequest.Types.View.Full"/>.
                /// </summary>
                public const string Full = "FULL";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.GroupMaintenanceInfo"/>
        /// message.
        /// </summary>
        public static class GroupMaintenanceInfo
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.GroupMaintenanceInfo.Types.SchedulingType"/> enum.
            /// </summary>
            public static class SchedulingType
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.GroupMaintenanceInfo.Types.SchedulingType.UndefinedSchedulingType"/>
                /// .
                /// </summary>
                public const string UndefinedSchedulingType = "UNDEFINED_SCHEDULING_TYPE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.GroupMaintenanceInfo.Types.SchedulingType.Grouped"/>.
                /// </summary>
                public const string Grouped = "GROUPED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.GroupMaintenanceInfo.Types.SchedulingType.GroupMaintenanceTypeUnspecified"/>
                /// .
                /// </summary>
                public const string GroupMaintenanceTypeUnspecified = "GROUP_MAINTENANCE_TYPE_UNSPECIFIED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.GroupMaintenanceInfo.Types.SchedulingType.Independent"/>.
                /// </summary>
                public const string Independent = "INDEPENDENT";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.GuestOsFeature"/> message.
        /// </summary>
        public static class GuestOsFeature
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.GuestOsFeature.Types.Type"/> enum.
            /// </summary>
            public static class Type
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.GuestOsFeature.Types.Type.UndefinedType"/>.
                /// </summary>
                public const string UndefinedType = "UNDEFINED_TYPE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.GuestOsFeature.Types.Type.BareMetalLinuxCompatible"/>.
                /// </summary>
                public const string BareMetalLinuxCompatible = "BARE_METAL_LINUX_COMPATIBLE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.GuestOsFeature.Types.Type.FeatureTypeUnspecified"/>.
                /// </summary>
                public const string FeatureTypeUnspecified = "FEATURE_TYPE_UNSPECIFIED";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.GuestOsFeature.Types.Type.Gvnic"/>
                /// .
                /// </summary>
                public const string Gvnic = "GVNIC";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.GuestOsFeature.Types.Type.Idpf"/>.
                /// </summary>
                public const string Idpf = "IDPF";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.GuestOsFeature.Types.Type.MultiIpSubnet"/>.
                /// </summary>
                public const string MultiIpSubnet = "MULTI_IP_SUBNET";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.GuestOsFeature.Types.Type.SecureBoot"/>.
                /// </summary>
                public const string SecureBoot = "SECURE_BOOT";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.GuestOsFeature.Types.Type.SevCapable"/>.
                /// </summary>
                public const string SevCapable = "SEV_CAPABLE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.GuestOsFeature.Types.Type.SevLiveMigratable"/>.
                /// </summary>
                public const string SevLiveMigratable = "SEV_LIVE_MIGRATABLE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.GuestOsFeature.Types.Type.SevLiveMigratableV2"/>.
                /// </summary>
                public const string SevLiveMigratableV2 = "SEV_LIVE_MIGRATABLE_V2";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.GuestOsFeature.Types.Type.SevSnpCapable"/>.
                /// </summary>
                public const string SevSnpCapable = "SEV_SNP_CAPABLE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.GuestOsFeature.Types.Type.SnpSvsmCapable"/>.
                /// </summary>
                public const string SnpSvsmCapable = "SNP_SVSM_CAPABLE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.GuestOsFeature.Types.Type.TdxCapable"/>.
                /// </summary>
                public const string TdxCapable = "TDX_CAPABLE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.GuestOsFeature.Types.Type.UefiCompatible"/>.
                /// </summary>
                public const string UefiCompatible = "UEFI_COMPATIBLE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.GuestOsFeature.Types.Type.VirtioScsiMultiqueue"/>.
                /// </summary>
                public const string VirtioScsiMultiqueue = "VIRTIO_SCSI_MULTIQUEUE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.GuestOsFeature.Types.Type.Windows"/>.
                /// </summary>
                public const string Windows = "WINDOWS";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.HTTP2HealthCheck"/> message.
        /// </summary>
        public static class HTTP2HealthCheck
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.HTTP2HealthCheck.Types.PortSpecification"/> enum.
            /// </summary>
            public static class PortSpecification
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.HTTP2HealthCheck.Types.PortSpecification.UndefinedPortSpecification"/>
                /// .
                /// </summary>
                public const string UndefinedPortSpecification = "UNDEFINED_PORT_SPECIFICATION";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.HTTP2HealthCheck.Types.PortSpecification.UseFixedPort"/>.
                /// </summary>
                public const string UseFixedPort = "USE_FIXED_PORT";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.HTTP2HealthCheck.Types.PortSpecification.UseNamedPort"/>.
                /// </summary>
                public const string UseNamedPort = "USE_NAMED_PORT";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.HTTP2HealthCheck.Types.PortSpecification.UseServingPort"/>
                /// .
                /// </summary>
                public const string UseServingPort = "USE_SERVING_PORT";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.HTTP2HealthCheck.Types.ProxyHeader"/> enum.
            /// </summary>
            public static class ProxyHeader
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.HTTP2HealthCheck.Types.ProxyHeader.UndefinedProxyHeader"/>
                /// .
                /// </summary>
                public const string UndefinedProxyHeader = "UNDEFINED_PROXY_HEADER";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.HTTP2HealthCheck.Types.ProxyHeader.None"/>.
                /// </summary>
                public const string None = "NONE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.HTTP2HealthCheck.Types.ProxyHeader.ProxyV1"/>.
                /// </summary>
                public const string ProxyV1 = "PROXY_V1";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.HTTPHealthCheck"/> message.
        /// </summary>
        public static class HTTPHealthCheck
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.HTTPHealthCheck.Types.PortSpecification"/> enum.
            /// </summary>
            public static class PortSpecification
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.HTTPHealthCheck.Types.PortSpecification.UndefinedPortSpecification"/>
                /// .
                /// </summary>
                public const string UndefinedPortSpecification = "UNDEFINED_PORT_SPECIFICATION";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.HTTPHealthCheck.Types.PortSpecification.UseFixedPort"/>.
                /// </summary>
                public const string UseFixedPort = "USE_FIXED_PORT";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.HTTPHealthCheck.Types.PortSpecification.UseNamedPort"/>.
                /// </summary>
                public const string UseNamedPort = "USE_NAMED_PORT";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.HTTPHealthCheck.Types.PortSpecification.UseServingPort"/>
                /// .
                /// </summary>
                public const string UseServingPort = "USE_SERVING_PORT";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.HTTPHealthCheck.Types.ProxyHeader"/> enum.
            /// </summary>
            public static class ProxyHeader
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.HTTPHealthCheck.Types.ProxyHeader.UndefinedProxyHeader"/>
                /// .
                /// </summary>
                public const string UndefinedProxyHeader = "UNDEFINED_PROXY_HEADER";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.HTTPHealthCheck.Types.ProxyHeader.None"/>.
                /// </summary>
                public const string None = "NONE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.HTTPHealthCheck.Types.ProxyHeader.ProxyV1"/>.
                /// </summary>
                public const string ProxyV1 = "PROXY_V1";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.HTTPSHealthCheck"/> message.
        /// </summary>
        public static class HTTPSHealthCheck
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.HTTPSHealthCheck.Types.PortSpecification"/> enum.
            /// </summary>
            public static class PortSpecification
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.HTTPSHealthCheck.Types.PortSpecification.UndefinedPortSpecification"/>
                /// .
                /// </summary>
                public const string UndefinedPortSpecification = "UNDEFINED_PORT_SPECIFICATION";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.HTTPSHealthCheck.Types.PortSpecification.UseFixedPort"/>.
                /// </summary>
                public const string UseFixedPort = "USE_FIXED_PORT";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.HTTPSHealthCheck.Types.PortSpecification.UseNamedPort"/>.
                /// </summary>
                public const string UseNamedPort = "USE_NAMED_PORT";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.HTTPSHealthCheck.Types.PortSpecification.UseServingPort"/>
                /// .
                /// </summary>
                public const string UseServingPort = "USE_SERVING_PORT";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.HTTPSHealthCheck.Types.ProxyHeader"/> enum.
            /// </summary>
            public static class ProxyHeader
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.HTTPSHealthCheck.Types.ProxyHeader.UndefinedProxyHeader"/>
                /// .
                /// </summary>
                public const string UndefinedProxyHeader = "UNDEFINED_PROXY_HEADER";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.HTTPSHealthCheck.Types.ProxyHeader.None"/>.
                /// </summary>
                public const string None = "NONE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.HTTPSHealthCheck.Types.ProxyHeader.ProxyV1"/>.
                /// </summary>
                public const string ProxyV1 = "PROXY_V1";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.HealthCheck"/> message.
        /// </summary>
        public static class HealthCheck
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.HealthCheck.Types.Type"/> enum.
            /// </summary>
            public static class Type
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.HealthCheck.Types.Type.UndefinedType"/>.
                /// </summary>
                public const string UndefinedType = "UNDEFINED_TYPE";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.HealthCheck.Types.Type.Grpc"/>.
                /// </summary>
                public const string Grpc = "GRPC";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.HealthCheck.Types.Type.Http"/>.
                /// </summary>
                public const string Http = "HTTP";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.HealthCheck.Types.Type.Http2"/>.
                /// </summary>
                public const string Http2 = "HTTP2";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.HealthCheck.Types.Type.Https"/>.
                /// </summary>
                public const string Https = "HTTPS";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.HealthCheck.Types.Type.Invalid"/>.
                /// </summary>
                public const string Invalid = "INVALID";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.HealthCheck.Types.Type.Ssl"/>.
                /// </summary>
                public const string Ssl = "SSL";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.HealthCheck.Types.Type.Tcp"/>.
                /// </summary>
                public const string Tcp = "TCP";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.HealthCheckService"/>
        /// message.
        /// </summary>
        public static class HealthCheckService
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.HealthCheckService.Types.HealthStatusAggregationPolicy"/>
            /// enum.
            /// </summary>
            public static class HealthStatusAggregationPolicy
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.HealthCheckService.Types.HealthStatusAggregationPolicy.UndefinedHealthStatusAggregationPolicy"/>
                /// .
                /// </summary>
                public const string UndefinedHealthStatusAggregationPolicy = "UNDEFINED_HEALTH_STATUS_AGGREGATION_POLICY";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.HealthCheckService.Types.HealthStatusAggregationPolicy.And"/>
                /// .
                /// </summary>
                public const string And = "AND";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.HealthCheckService.Types.HealthStatusAggregationPolicy.NoAggregation"/>
                /// .
                /// </summary>
                public const string NoAggregation = "NO_AGGREGATION";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.HealthStatus"/> message.
        /// </summary>
        public static class HealthStatus
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.HealthStatus.Types.HealthState"/> enum.
            /// </summary>
            public static class HealthState
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.HealthStatus.Types.HealthState.UndefinedHealthState"/>.
                /// </summary>
                public const string UndefinedHealthState = "UNDEFINED_HEALTH_STATE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.HealthStatus.Types.HealthState.Healthy"/>.
                /// </summary>
                public const string Healthy = "HEALTHY";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.HealthStatus.Types.HealthState.Unhealthy"/>.
                /// </summary>
                public const string Unhealthy = "UNHEALTHY";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.HealthStatus.Types.Ipv6HealthState"/> enum.
            /// </summary>
            public static class Ipv6HealthState
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.HealthStatus.Types.Ipv6HealthState.UndefinedIpv6HealthState"/>
                /// .
                /// </summary>
                public const string UndefinedIpv6HealthState = "UNDEFINED_IPV6_HEALTH_STATE";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.HealthStatus.Types.WeightError"/> enum.
            /// </summary>
            public static class WeightError
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.HealthStatus.Types.WeightError.UndefinedWeightError"/>.
                /// </summary>
                public const string UndefinedWeightError = "UNDEFINED_WEIGHT_ERROR";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.HealthStatus.Types.WeightError.InvalidWeight"/>.
                /// </summary>
                public const string InvalidWeight = "INVALID_WEIGHT";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.HealthStatus.Types.WeightError.MissingWeight"/>.
                /// </summary>
                public const string MissingWeight = "MISSING_WEIGHT";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.HealthStatus.Types.WeightError.UnavailableWeight"/>.
                /// </summary>
                public const string UnavailableWeight = "UNAVAILABLE_WEIGHT";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.HealthStatus.Types.WeightError.WeightNone"/>.
                /// </summary>
                public const string WeightNone = "WEIGHT_NONE";
            }
        }

        /// <summary>
        /// Container class for enums within the
        /// <see cref="global::Google.Cloud.Compute.V1.HealthStatusForNetworkEndpoint"/> message.
        /// </summary>
        public static class HealthStatusForNetworkEndpoint
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.HealthStatusForNetworkEndpoint.Types.HealthState"/> enum.
            /// </summary>
            public static class HealthState
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.HealthStatusForNetworkEndpoint.Types.HealthState.UndefinedHealthState"/>
                /// .
                /// </summary>
                public const string UndefinedHealthState = "UNDEFINED_HEALTH_STATE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.HealthStatusForNetworkEndpoint.Types.HealthState.Draining"/>
                /// .
                /// </summary>
                public const string Draining = "DRAINING";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.HealthStatusForNetworkEndpoint.Types.HealthState.Healthy"/>
                /// .
                /// </summary>
                public const string Healthy = "HEALTHY";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.HealthStatusForNetworkEndpoint.Types.HealthState.Unhealthy"/>
                /// .
                /// </summary>
                public const string Unhealthy = "UNHEALTHY";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.HealthStatusForNetworkEndpoint.Types.HealthState.Unknown"/>
                /// .
                /// </summary>
                public const string Unknown = "UNKNOWN";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.HealthStatusForNetworkEndpoint.Types.Ipv6HealthState"/> enum.
            /// </summary>
            public static class Ipv6HealthState
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.HealthStatusForNetworkEndpoint.Types.Ipv6HealthState.UndefinedIpv6HealthState"/>
                /// .
                /// </summary>
                public const string UndefinedIpv6HealthState = "UNDEFINED_IPV6_HEALTH_STATE";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.HttpRedirectAction"/>
        /// message.
        /// </summary>
        public static class HttpRedirectAction
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.HttpRedirectAction.Types.RedirectResponseCode"/> enum.
            /// </summary>
            public static class RedirectResponseCode
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.HttpRedirectAction.Types.RedirectResponseCode.UndefinedRedirectResponseCode"/>
                /// .
                /// </summary>
                public const string UndefinedRedirectResponseCode = "UNDEFINED_REDIRECT_RESPONSE_CODE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.HttpRedirectAction.Types.RedirectResponseCode.Found"/>.
                /// </summary>
                public const string Found = "FOUND";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.HttpRedirectAction.Types.RedirectResponseCode.MovedPermanentlyDefault"/>
                /// .
                /// </summary>
                public const string MovedPermanentlyDefault = "MOVED_PERMANENTLY_DEFAULT";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.HttpRedirectAction.Types.RedirectResponseCode.PermanentRedirect"/>
                /// .
                /// </summary>
                public const string PermanentRedirect = "PERMANENT_REDIRECT";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.HttpRedirectAction.Types.RedirectResponseCode.SeeOther"/>
                /// .
                /// </summary>
                public const string SeeOther = "SEE_OTHER";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.HttpRedirectAction.Types.RedirectResponseCode.TemporaryRedirect"/>
                /// .
                /// </summary>
                public const string TemporaryRedirect = "TEMPORARY_REDIRECT";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.Image"/> message.
        /// </summary>
        public static class Image
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.Image.Types.Architecture"/> enum.
            /// </summary>
            public static class Architecture
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Image.Types.Architecture.UndefinedArchitecture"/>.
                /// </summary>
                public const string UndefinedArchitecture = "UNDEFINED_ARCHITECTURE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Image.Types.Architecture.Unspecified"/>.
                /// </summary>
                public const string Unspecified = "ARCHITECTURE_UNSPECIFIED";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.Image.Types.Architecture.Arm64"/>.
                /// </summary>
                public const string Arm64 = "ARM64";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.Image.Types.Architecture.X8664"/>.
                /// </summary>
                public const string X8664 = "X86_64";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.Image.Types.SourceType"/> enum.
            /// </summary>
            public static class SourceType
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Image.Types.SourceType.UndefinedSourceType"/>.
                /// </summary>
                public const string UndefinedSourceType = "UNDEFINED_SOURCE_TYPE";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.Image.Types.SourceType.Raw"/>.
                /// </summary>
                public const string Raw = "RAW";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.Image.Types.Status"/> enum.
            /// </summary>
            public static class Status
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Image.Types.Status.UndefinedStatus"/>.
                /// </summary>
                public const string UndefinedStatus = "UNDEFINED_STATUS";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.Image.Types.Status.Deleting"/>.
                /// </summary>
                public const string Deleting = "DELETING";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.Image.Types.Status.Failed"/>.
                /// </summary>
                public const string Failed = "FAILED";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.Image.Types.Status.Pending"/>.
                /// </summary>
                public const string Pending = "PENDING";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.Image.Types.Status.Ready"/>.
                /// </summary>
                public const string Ready = "READY";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.Instance"/> message.
        /// </summary>
        public static class Instance
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.Instance.Types.KeyRevocationActionType"/> enum.
            /// </summary>
            public static class KeyRevocationActionType
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Instance.Types.KeyRevocationActionType.UndefinedKeyRevocationActionType"/>
                /// .
                /// </summary>
                public const string UndefinedKeyRevocationActionType = "UNDEFINED_KEY_REVOCATION_ACTION_TYPE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Instance.Types.KeyRevocationActionType.Unspecified"/>.
                /// </summary>
                public const string Unspecified = "KEY_REVOCATION_ACTION_TYPE_UNSPECIFIED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Instance.Types.KeyRevocationActionType.None"/>.
                /// </summary>
                public const string None = "NONE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Instance.Types.KeyRevocationActionType.Stop"/>.
                /// </summary>
                public const string Stop = "STOP";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.Instance.Types.PrivateIpv6GoogleAccess"/> enum.
            /// </summary>
            public static class PrivateIpv6GoogleAccess
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Instance.Types.PrivateIpv6GoogleAccess.UndefinedPrivateIpv6GoogleAccess"/>
                /// .
                /// </summary>
                public const string UndefinedPrivateIpv6GoogleAccess = "UNDEFINED_PRIVATE_IPV6_GOOGLE_ACCESS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Instance.Types.PrivateIpv6GoogleAccess.EnableBidirectionalAccessToGoogle"/>
                /// .
                /// </summary>
                public const string EnableBidirectionalAccessToGoogle = "ENABLE_BIDIRECTIONAL_ACCESS_TO_GOOGLE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Instance.Types.PrivateIpv6GoogleAccess.EnableOutboundVmAccessToGoogle"/>
                /// .
                /// </summary>
                public const string EnableOutboundVmAccessToGoogle = "ENABLE_OUTBOUND_VM_ACCESS_TO_GOOGLE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Instance.Types.PrivateIpv6GoogleAccess.InheritFromSubnetwork"/>
                /// .
                /// </summary>
                public const string InheritFromSubnetwork = "INHERIT_FROM_SUBNETWORK";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.Instance.Types.Status"/> enum.
            /// </summary>
            public static class Status
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Instance.Types.Status.UndefinedStatus"/>.
                /// </summary>
                public const string UndefinedStatus = "UNDEFINED_STATUS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Instance.Types.Status.Deprovisioning"/>.
                /// </summary>
                public const string Deprovisioning = "DEPROVISIONING";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Instance.Types.Status.Provisioning"/>.
                /// </summary>
                public const string Provisioning = "PROVISIONING";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.Instance.Types.Status.Repairing"/>
                /// .
                /// </summary>
                public const string Repairing = "REPAIRING";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.Instance.Types.Status.Running"/>.
                /// </summary>
                public const string Running = "RUNNING";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.Instance.Types.Status.Staging"/>.
                /// </summary>
                public const string Staging = "STAGING";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.Instance.Types.Status.Stopped"/>.
                /// </summary>
                public const string Stopped = "STOPPED";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.Instance.Types.Status.Stopping"/>.
                /// </summary>
                public const string Stopping = "STOPPING";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.Instance.Types.Status.Suspended"/>
                /// .
                /// </summary>
                public const string Suspended = "SUSPENDED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Instance.Types.Status.Suspending"/>.
                /// </summary>
                public const string Suspending = "SUSPENDING";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Instance.Types.Status.Terminated"/>.
                /// </summary>
                public const string Terminated = "TERMINATED";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.InstanceGroupManager"/>
        /// message.
        /// </summary>
        public static class InstanceGroupManager
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.InstanceGroupManager.Types.ListManagedInstancesResults"/>
            /// enum.
            /// </summary>
            public static class ListManagedInstancesResults
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InstanceGroupManager.Types.ListManagedInstancesResults.UndefinedListManagedInstancesResults"/>
                /// .
                /// </summary>
                public const string UndefinedListManagedInstancesResults = "UNDEFINED_LIST_MANAGED_INSTANCES_RESULTS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InstanceGroupManager.Types.ListManagedInstancesResults.Pageless"/>
                /// .
                /// </summary>
                public const string Pageless = "PAGELESS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InstanceGroupManager.Types.ListManagedInstancesResults.Paginated"/>
                /// .
                /// </summary>
                public const string Paginated = "PAGINATED";
            }
        }

        /// <summary>
        /// Container class for enums within the
        /// <see cref="global::Google.Cloud.Compute.V1.InstanceGroupManagerInstanceLifecyclePolicy"/> message.
        /// </summary>
        public static class InstanceGroupManagerInstanceLifecyclePolicy
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.InstanceGroupManagerInstanceLifecyclePolicy.Types.DefaultActionOnFailure"/>
            ///  enum.
            /// </summary>
            public static class DefaultActionOnFailure
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InstanceGroupManagerInstanceLifecyclePolicy.Types.DefaultActionOnFailure.UndefinedDefaultActionOnFailure"/>
                /// .
                /// </summary>
                public const string UndefinedDefaultActionOnFailure = "UNDEFINED_DEFAULT_ACTION_ON_FAILURE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InstanceGroupManagerInstanceLifecyclePolicy.Types.DefaultActionOnFailure.DoNothing"/>
                /// .
                /// </summary>
                public const string DoNothing = "DO_NOTHING";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InstanceGroupManagerInstanceLifecyclePolicy.Types.DefaultActionOnFailure.Repair"/>
                /// .
                /// </summary>
                public const string Repair = "REPAIR";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.InstanceGroupManagerInstanceLifecyclePolicy.Types.ForceUpdateOnRepair"/>
            ///  enum.
            /// </summary>
            public static class ForceUpdateOnRepair
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InstanceGroupManagerInstanceLifecyclePolicy.Types.ForceUpdateOnRepair.UndefinedForceUpdateOnRepair"/>
                /// .
                /// </summary>
                public const string UndefinedForceUpdateOnRepair = "UNDEFINED_FORCE_UPDATE_ON_REPAIR";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InstanceGroupManagerInstanceLifecyclePolicy.Types.ForceUpdateOnRepair.No"/>
                /// .
                /// </summary>
                public const string No = "NO";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InstanceGroupManagerInstanceLifecyclePolicy.Types.ForceUpdateOnRepair.Yes"/>
                /// .
                /// </summary>
                public const string Yes = "YES";
            }
        }

        /// <summary>
        /// Container class for enums within the
        /// <see cref="global::Google.Cloud.Compute.V1.InstanceGroupManagerResizeRequest"/> message.
        /// </summary>
        public static class InstanceGroupManagerResizeRequest
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.InstanceGroupManagerResizeRequest.Types.State"/> enum.
            /// </summary>
            public static class State
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InstanceGroupManagerResizeRequest.Types.State.UndefinedState"/>
                /// .
                /// </summary>
                public const string UndefinedState = "UNDEFINED_STATE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InstanceGroupManagerResizeRequest.Types.State.Accepted"/>
                /// .
                /// </summary>
                public const string Accepted = "ACCEPTED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InstanceGroupManagerResizeRequest.Types.State.Cancelled"/>
                /// .
                /// </summary>
                public const string Cancelled = "CANCELLED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InstanceGroupManagerResizeRequest.Types.State.Creating"/>
                /// .
                /// </summary>
                public const string Creating = "CREATING";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InstanceGroupManagerResizeRequest.Types.State.Failed"/>.
                /// </summary>
                public const string Failed = "FAILED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InstanceGroupManagerResizeRequest.Types.State.Unspecified"/>
                /// .
                /// </summary>
                public const string Unspecified = "STATE_UNSPECIFIED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InstanceGroupManagerResizeRequest.Types.State.Succeeded"/>
                /// .
                /// </summary>
                public const string Succeeded = "SUCCEEDED";
            }
        }

        /// <summary>
        /// Container class for enums within the
        /// <see cref="global::Google.Cloud.Compute.V1.InstanceGroupManagerStandbyPolicy"/> message.
        /// </summary>
        public static class InstanceGroupManagerStandbyPolicy
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.InstanceGroupManagerStandbyPolicy.Types.Mode"/> enum.
            /// </summary>
            public static class Mode
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InstanceGroupManagerStandbyPolicy.Types.Mode.UndefinedMode"/>
                /// .
                /// </summary>
                public const string UndefinedMode = "UNDEFINED_MODE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InstanceGroupManagerStandbyPolicy.Types.Mode.Manual"/>.
                /// </summary>
                public const string Manual = "MANUAL";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InstanceGroupManagerStandbyPolicy.Types.Mode.ScaleOutPool"/>
                /// .
                /// </summary>
                public const string ScaleOutPool = "SCALE_OUT_POOL";
            }
        }

        /// <summary>
        /// Container class for enums within the
        /// <see cref="global::Google.Cloud.Compute.V1.InstanceGroupManagerUpdatePolicy"/> message.
        /// </summary>
        public static class InstanceGroupManagerUpdatePolicy
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.InstanceGroupManagerUpdatePolicy.Types.InstanceRedistributionType"/>
            ///  enum.
            /// </summary>
            public static class InstanceRedistributionType
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InstanceGroupManagerUpdatePolicy.Types.InstanceRedistributionType.UndefinedInstanceRedistributionType"/>
                /// .
                /// </summary>
                public const string UndefinedInstanceRedistributionType = "UNDEFINED_INSTANCE_REDISTRIBUTION_TYPE";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.InstanceGroupManagerUpdatePolicy.Types.MinimalAction"/> enum.
            /// </summary>
            public static class MinimalAction
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InstanceGroupManagerUpdatePolicy.Types.MinimalAction.UndefinedMinimalAction"/>
                /// .
                /// </summary>
                public const string UndefinedMinimalAction = "UNDEFINED_MINIMAL_ACTION";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.InstanceGroupManagerUpdatePolicy.Types.MostDisruptiveAllowedAction"/>
            ///  enum.
            /// </summary>
            public static class MostDisruptiveAllowedAction
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InstanceGroupManagerUpdatePolicy.Types.MostDisruptiveAllowedAction.UndefinedMostDisruptiveAllowedAction"/>
                /// .
                /// </summary>
                public const string UndefinedMostDisruptiveAllowedAction = "UNDEFINED_MOST_DISRUPTIVE_ALLOWED_ACTION";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.InstanceGroupManagerUpdatePolicy.Types.ReplacementMethod"/>
            /// enum.
            /// </summary>
            public static class ReplacementMethod
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InstanceGroupManagerUpdatePolicy.Types.ReplacementMethod.UndefinedReplacementMethod"/>
                /// .
                /// </summary>
                public const string UndefinedReplacementMethod = "UNDEFINED_REPLACEMENT_METHOD";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InstanceGroupManagerUpdatePolicy.Types.ReplacementMethod.Recreate"/>
                /// .
                /// </summary>
                public const string Recreate = "RECREATE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InstanceGroupManagerUpdatePolicy.Types.ReplacementMethod.Substitute"/>
                /// .
                /// </summary>
                public const string Substitute = "SUBSTITUTE";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.InstanceGroupManagerUpdatePolicy.Types.Type"/> enum.
            /// </summary>
            public static class Type
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InstanceGroupManagerUpdatePolicy.Types.Type.UndefinedType"/>
                /// .
                /// </summary>
                public const string UndefinedType = "UNDEFINED_TYPE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InstanceGroupManagerUpdatePolicy.Types.Type.Opportunistic"/>
                /// .
                /// </summary>
                public const string Opportunistic = "OPPORTUNISTIC";
            }
        }

        /// <summary>
        /// Container class for enums within the
        /// <see cref="global::Google.Cloud.Compute.V1.InstanceGroupManagersApplyUpdatesRequest"/> message.
        /// </summary>
        public static class InstanceGroupManagersApplyUpdatesRequest
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.InstanceGroupManagersApplyUpdatesRequest.Types.MinimalAction"/>
            ///  enum.
            /// </summary>
            public static class MinimalAction
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InstanceGroupManagersApplyUpdatesRequest.Types.MinimalAction.UndefinedMinimalAction"/>
                /// .
                /// </summary>
                public const string UndefinedMinimalAction = "UNDEFINED_MINIMAL_ACTION";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.InstanceGroupManagersApplyUpdatesRequest.Types.MostDisruptiveAllowedAction"/>
            ///  enum.
            /// </summary>
            public static class MostDisruptiveAllowedAction
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InstanceGroupManagersApplyUpdatesRequest.Types.MostDisruptiveAllowedAction.UndefinedMostDisruptiveAllowedAction"/>
                /// .
                /// </summary>
                public const string UndefinedMostDisruptiveAllowedAction = "UNDEFINED_MOST_DISRUPTIVE_ALLOWED_ACTION";
            }
        }

        /// <summary>
        /// Container class for enums within the
        /// <see cref="global::Google.Cloud.Compute.V1.InstanceGroupsListInstancesRequest"/> message.
        /// </summary>
        public static class InstanceGroupsListInstancesRequest
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.InstanceGroupsListInstancesRequest.Types.InstanceState"/>
            /// enum.
            /// </summary>
            public static class InstanceState
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InstanceGroupsListInstancesRequest.Types.InstanceState.UndefinedInstanceState"/>
                /// .
                /// </summary>
                public const string UndefinedInstanceState = "UNDEFINED_INSTANCE_STATE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InstanceGroupsListInstancesRequest.Types.InstanceState.All"/>
                /// .
                /// </summary>
                public const string All = "ALL";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InstanceGroupsListInstancesRequest.Types.InstanceState.Running"/>
                /// .
                /// </summary>
                public const string Running = "RUNNING";
            }
        }

        /// <summary>
        /// Container class for enums within the
        /// <see cref="global::Google.Cloud.Compute.V1.InstanceManagedByIgmErrorInstanceActionDetails"/> message.
        /// </summary>
        public static class InstanceManagedByIgmErrorInstanceActionDetails
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.InstanceManagedByIgmErrorInstanceActionDetails.Types.Action"/>
            ///  enum.
            /// </summary>
            public static class Action
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InstanceManagedByIgmErrorInstanceActionDetails.Types.Action.UndefinedAction"/>
                /// .
                /// </summary>
                public const string UndefinedAction = "UNDEFINED_ACTION";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InstanceManagedByIgmErrorInstanceActionDetails.Types.Action.Abandoning"/>
                /// .
                /// </summary>
                public const string Abandoning = "ABANDONING";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InstanceManagedByIgmErrorInstanceActionDetails.Types.Action.Creating"/>
                /// .
                /// </summary>
                public const string Creating = "CREATING";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InstanceManagedByIgmErrorInstanceActionDetails.Types.Action.CreatingWithoutRetries"/>
                /// .
                /// </summary>
                public const string CreatingWithoutRetries = "CREATING_WITHOUT_RETRIES";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InstanceManagedByIgmErrorInstanceActionDetails.Types.Action.Deleting"/>
                /// .
                /// </summary>
                public const string Deleting = "DELETING";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InstanceManagedByIgmErrorInstanceActionDetails.Types.Action.None"/>
                /// .
                /// </summary>
                public const string None = "NONE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InstanceManagedByIgmErrorInstanceActionDetails.Types.Action.Recreating"/>
                /// .
                /// </summary>
                public const string Recreating = "RECREATING";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InstanceManagedByIgmErrorInstanceActionDetails.Types.Action.Refreshing"/>
                /// .
                /// </summary>
                public const string Refreshing = "REFRESHING";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InstanceManagedByIgmErrorInstanceActionDetails.Types.Action.Restarting"/>
                /// .
                /// </summary>
                public const string Restarting = "RESTARTING";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InstanceManagedByIgmErrorInstanceActionDetails.Types.Action.Resuming"/>
                /// .
                /// </summary>
                public const string Resuming = "RESUMING";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InstanceManagedByIgmErrorInstanceActionDetails.Types.Action.Starting"/>
                /// .
                /// </summary>
                public const string Starting = "STARTING";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InstanceManagedByIgmErrorInstanceActionDetails.Types.Action.Stopping"/>
                /// .
                /// </summary>
                public const string Stopping = "STOPPING";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InstanceManagedByIgmErrorInstanceActionDetails.Types.Action.Suspending"/>
                /// .
                /// </summary>
                public const string Suspending = "SUSPENDING";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InstanceManagedByIgmErrorInstanceActionDetails.Types.Action.Verifying"/>
                /// .
                /// </summary>
                public const string Verifying = "VERIFYING";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.InstanceProperties"/>
        /// message.
        /// </summary>
        public static class InstanceProperties
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.InstanceProperties.Types.KeyRevocationActionType"/> enum.
            /// </summary>
            public static class KeyRevocationActionType
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InstanceProperties.Types.KeyRevocationActionType.UndefinedKeyRevocationActionType"/>
                /// .
                /// </summary>
                public const string UndefinedKeyRevocationActionType = "UNDEFINED_KEY_REVOCATION_ACTION_TYPE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InstanceProperties.Types.KeyRevocationActionType.Unspecified"/>
                /// .
                /// </summary>
                public const string Unspecified = "KEY_REVOCATION_ACTION_TYPE_UNSPECIFIED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InstanceProperties.Types.KeyRevocationActionType.None"/>.
                /// </summary>
                public const string None = "NONE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InstanceProperties.Types.KeyRevocationActionType.Stop"/>.
                /// </summary>
                public const string Stop = "STOP";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.InstanceProperties.Types.PrivateIpv6GoogleAccess"/> enum.
            /// </summary>
            public static class PrivateIpv6GoogleAccess
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InstanceProperties.Types.PrivateIpv6GoogleAccess.UndefinedPrivateIpv6GoogleAccess"/>
                /// .
                /// </summary>
                public const string UndefinedPrivateIpv6GoogleAccess = "UNDEFINED_PRIVATE_IPV6_GOOGLE_ACCESS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InstanceProperties.Types.PrivateIpv6GoogleAccess.EnableBidirectionalAccessToGoogle"/>
                /// .
                /// </summary>
                public const string EnableBidirectionalAccessToGoogle = "ENABLE_BIDIRECTIONAL_ACCESS_TO_GOOGLE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InstanceProperties.Types.PrivateIpv6GoogleAccess.EnableOutboundVmAccessToGoogle"/>
                /// .
                /// </summary>
                public const string EnableOutboundVmAccessToGoogle = "ENABLE_OUTBOUND_VM_ACCESS_TO_GOOGLE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InstanceProperties.Types.PrivateIpv6GoogleAccess.InheritFromSubnetwork"/>
                /// .
                /// </summary>
                public const string InheritFromSubnetwork = "INHERIT_FROM_SUBNETWORK";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.InstanceWithNamedPorts"/>
        /// message.
        /// </summary>
        public static class InstanceWithNamedPorts
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.InstanceWithNamedPorts.Types.Status"/> enum.
            /// </summary>
            public static class Status
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InstanceWithNamedPorts.Types.Status.UndefinedStatus"/>.
                /// </summary>
                public const string UndefinedStatus = "UNDEFINED_STATUS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InstanceWithNamedPorts.Types.Status.Deprovisioning"/>.
                /// </summary>
                public const string Deprovisioning = "DEPROVISIONING";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InstanceWithNamedPorts.Types.Status.Provisioning"/>.
                /// </summary>
                public const string Provisioning = "PROVISIONING";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InstanceWithNamedPorts.Types.Status.Repairing"/>.
                /// </summary>
                public const string Repairing = "REPAIRING";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InstanceWithNamedPorts.Types.Status.Running"/>.
                /// </summary>
                public const string Running = "RUNNING";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InstanceWithNamedPorts.Types.Status.Staging"/>.
                /// </summary>
                public const string Staging = "STAGING";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InstanceWithNamedPorts.Types.Status.Stopped"/>.
                /// </summary>
                public const string Stopped = "STOPPED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InstanceWithNamedPorts.Types.Status.Stopping"/>.
                /// </summary>
                public const string Stopping = "STOPPING";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InstanceWithNamedPorts.Types.Status.Suspended"/>.
                /// </summary>
                public const string Suspended = "SUSPENDED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InstanceWithNamedPorts.Types.Status.Suspending"/>.
                /// </summary>
                public const string Suspending = "SUSPENDING";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InstanceWithNamedPorts.Types.Status.Terminated"/>.
                /// </summary>
                public const string Terminated = "TERMINATED";
            }
        }

        /// <summary>
        /// Container class for enums within the
        /// <see cref="global::Google.Cloud.Compute.V1.InstancesGetEffectiveFirewallsResponseEffectiveFirewallPolicy"/>
        /// message.
        /// </summary>
        public static class InstancesGetEffectiveFirewallsResponseEffectiveFirewallPolicy
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.InstancesGetEffectiveFirewallsResponseEffectiveFirewallPolicy.Types.Type"/>
            ///  enum.
            /// </summary>
            public static class Type
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InstancesGetEffectiveFirewallsResponseEffectiveFirewallPolicy.Types.Type.UndefinedType"/>
                /// .
                /// </summary>
                public const string UndefinedType = "UNDEFINED_TYPE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InstancesGetEffectiveFirewallsResponseEffectiveFirewallPolicy.Types.Type.Hierarchy"/>
                /// .
                /// </summary>
                public const string Hierarchy = "HIERARCHY";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InstancesGetEffectiveFirewallsResponseEffectiveFirewallPolicy.Types.Type.Network"/>
                /// .
                /// </summary>
                public const string Network = "NETWORK";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InstancesGetEffectiveFirewallsResponseEffectiveFirewallPolicy.Types.Type.NetworkRegional"/>
                /// .
                /// </summary>
                public const string NetworkRegional = "NETWORK_REGIONAL";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InstancesGetEffectiveFirewallsResponseEffectiveFirewallPolicy.Types.Type.SystemGlobal"/>
                /// .
                /// </summary>
                public const string SystemGlobal = "SYSTEM_GLOBAL";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InstancesGetEffectiveFirewallsResponseEffectiveFirewallPolicy.Types.Type.SystemRegional"/>
                /// .
                /// </summary>
                public const string SystemRegional = "SYSTEM_REGIONAL";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InstancesGetEffectiveFirewallsResponseEffectiveFirewallPolicy.Types.Type.Unspecified"/>
                /// .
                /// </summary>
                public const string Unspecified = "UNSPECIFIED";
            }
        }

        /// <summary>
        /// Container class for enums within the
        /// <see cref="global::Google.Cloud.Compute.V1.InstancesReportHostAsFaultyRequest"/> message.
        /// </summary>
        public static class InstancesReportHostAsFaultyRequest
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.InstancesReportHostAsFaultyRequest.Types.DisruptionSchedule"/>
            ///  enum.
            /// </summary>
            public static class DisruptionSchedule
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InstancesReportHostAsFaultyRequest.Types.DisruptionSchedule.UndefinedDisruptionSchedule"/>
                /// .
                /// </summary>
                public const string UndefinedDisruptionSchedule = "UNDEFINED_DISRUPTION_SCHEDULE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InstancesReportHostAsFaultyRequest.Types.DisruptionSchedule.Unspecified"/>
                /// .
                /// </summary>
                public const string Unspecified = "DISRUPTION_SCHEDULE_UNSPECIFIED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InstancesReportHostAsFaultyRequest.Types.DisruptionSchedule.Future"/>
                /// .
                /// </summary>
                public const string Future = "FUTURE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InstancesReportHostAsFaultyRequest.Types.DisruptionSchedule.Immediate"/>
                /// .
                /// </summary>
                public const string Immediate = "IMMEDIATE";
            }
        }

        /// <summary>
        /// Container class for enums within the
        /// <see cref="global::Google.Cloud.Compute.V1.InstancesReportHostAsFaultyRequestFaultReason"/> message.
        /// </summary>
        public static class InstancesReportHostAsFaultyRequestFaultReason
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.InstancesReportHostAsFaultyRequestFaultReason.Types.Behavior"/>
            ///  enum.
            /// </summary>
            public static class Behavior
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InstancesReportHostAsFaultyRequestFaultReason.Types.Behavior.UndefinedBehavior"/>
                /// .
                /// </summary>
                public const string UndefinedBehavior = "UNDEFINED_BEHAVIOR";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InstancesReportHostAsFaultyRequestFaultReason.Types.Behavior.Unspecified"/>
                /// .
                /// </summary>
                public const string Unspecified = "BEHAVIOR_UNSPECIFIED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InstancesReportHostAsFaultyRequestFaultReason.Types.Behavior.Performance"/>
                /// .
                /// </summary>
                public const string Performance = "PERFORMANCE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InstancesReportHostAsFaultyRequestFaultReason.Types.Behavior.SilentDataCorruption"/>
                /// .
                /// </summary>
                public const string SilentDataCorruption = "SILENT_DATA_CORRUPTION";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InstancesReportHostAsFaultyRequestFaultReason.Types.Behavior.UnrecoverableGpuError"/>
                /// .
                /// </summary>
                public const string UnrecoverableGpuError = "UNRECOVERABLE_GPU_ERROR";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.InstantSnapshot"/> message.
        /// </summary>
        public static class InstantSnapshot
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.InstantSnapshot.Types.Architecture"/> enum.
            /// </summary>
            public static class Architecture
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InstantSnapshot.Types.Architecture.UndefinedArchitecture"/>
                /// .
                /// </summary>
                public const string UndefinedArchitecture = "UNDEFINED_ARCHITECTURE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InstantSnapshot.Types.Architecture.Unspecified"/>.
                /// </summary>
                public const string Unspecified = "ARCHITECTURE_UNSPECIFIED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InstantSnapshot.Types.Architecture.Arm64"/>.
                /// </summary>
                public const string Arm64 = "ARM64";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InstantSnapshot.Types.Architecture.X8664"/>.
                /// </summary>
                public const string X8664 = "X86_64";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.InstantSnapshot.Types.Status"/> enum.
            /// </summary>
            public static class Status
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InstantSnapshot.Types.Status.UndefinedStatus"/>.
                /// </summary>
                public const string UndefinedStatus = "UNDEFINED_STATUS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InstantSnapshot.Types.Status.Creating"/>.
                /// </summary>
                public const string Creating = "CREATING";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InstantSnapshot.Types.Status.Deleting"/>.
                /// </summary>
                public const string Deleting = "DELETING";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InstantSnapshot.Types.Status.Failed"/>.
                /// </summary>
                public const string Failed = "FAILED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InstantSnapshot.Types.Status.Ready"/>.
                /// </summary>
                public const string Ready = "READY";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InstantSnapshot.Types.Status.Unavailable"/>.
                /// </summary>
                public const string Unavailable = "UNAVAILABLE";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.Interconnect"/> message.
        /// </summary>
        public static class Interconnect
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.Interconnect.Types.AvailableFeatures"/> enum.
            /// </summary>
            public static class AvailableFeatures
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Interconnect.Types.AvailableFeatures.UndefinedAvailableFeatures"/>
                /// .
                /// </summary>
                public const string UndefinedAvailableFeatures = "UNDEFINED_AVAILABLE_FEATURES";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.Interconnect.Types.InterconnectType"/> enum.
            /// </summary>
            public static class InterconnectType
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Interconnect.Types.InterconnectType.UndefinedInterconnectType"/>
                /// .
                /// </summary>
                public const string UndefinedInterconnectType = "UNDEFINED_INTERCONNECT_TYPE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Interconnect.Types.InterconnectType.Dedicated"/>.
                /// </summary>
                public const string Dedicated = "DEDICATED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Interconnect.Types.InterconnectType.ItPrivate"/>.
                /// </summary>
                public const string ItPrivate = "IT_PRIVATE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Interconnect.Types.InterconnectType.Partner"/>.
                /// </summary>
                public const string Partner = "PARTNER";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.Interconnect.Types.LinkType"/> enum.
            /// </summary>
            public static class LinkType
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Interconnect.Types.LinkType.UndefinedLinkType"/>.
                /// </summary>
                public const string UndefinedLinkType = "UNDEFINED_LINK_TYPE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Interconnect.Types.LinkType.Ethernet100GLr"/>.
                /// </summary>
                public const string Ethernet100GLr = "LINK_TYPE_ETHERNET_100G_LR";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Interconnect.Types.LinkType.Ethernet10GLr"/>.
                /// </summary>
                public const string Ethernet10GLr = "LINK_TYPE_ETHERNET_10G_LR";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Interconnect.Types.LinkType.Ethernet400GLr4"/>.
                /// </summary>
                public const string Ethernet400GLr4 = "LINK_TYPE_ETHERNET_400G_LR4";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.Interconnect.Types.OperationalStatus"/> enum.
            /// </summary>
            public static class OperationalStatus
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Interconnect.Types.OperationalStatus.UndefinedOperationalStatus"/>
                /// .
                /// </summary>
                public const string UndefinedOperationalStatus = "UNDEFINED_OPERATIONAL_STATUS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Interconnect.Types.OperationalStatus.OsActive"/>.
                /// </summary>
                public const string OsActive = "OS_ACTIVE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Interconnect.Types.OperationalStatus.OsUnprovisioned"/>.
                /// </summary>
                public const string OsUnprovisioned = "OS_UNPROVISIONED";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.Interconnect.Types.RequestedFeatures"/> enum.
            /// </summary>
            public static class RequestedFeatures
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Interconnect.Types.RequestedFeatures.UndefinedRequestedFeatures"/>
                /// .
                /// </summary>
                public const string UndefinedRequestedFeatures = "UNDEFINED_REQUESTED_FEATURES";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.Interconnect.Types.State"/> enum.
            /// </summary>
            public static class State
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Interconnect.Types.State.UndefinedState"/>.
                /// </summary>
                public const string UndefinedState = "UNDEFINED_STATE";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.Interconnect.Types.State.Active"/>
                /// .
                /// </summary>
                public const string Active = "ACTIVE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Interconnect.Types.State.Unprovisioned"/>.
                /// </summary>
                public const string Unprovisioned = "UNPROVISIONED";
            }
        }

        /// <summary>
        /// Container class for enums within the
        /// <see cref="global::Google.Cloud.Compute.V1.InterconnectApplicationAwareInterconnectBandwidthPercentage"/>
        /// message.
        /// </summary>
        public static class InterconnectApplicationAwareInterconnectBandwidthPercentage
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.InterconnectApplicationAwareInterconnectBandwidthPercentage.Types.TrafficClass"/>
            ///  enum.
            /// </summary>
            public static class TrafficClass
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectApplicationAwareInterconnectBandwidthPercentage.Types.TrafficClass.UndefinedTrafficClass"/>
                /// .
                /// </summary>
                public const string UndefinedTrafficClass = "UNDEFINED_TRAFFIC_CLASS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectApplicationAwareInterconnectBandwidthPercentage.Types.TrafficClass.Tc1"/>
                /// .
                /// </summary>
                public const string Tc1 = "TC1";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectApplicationAwareInterconnectBandwidthPercentage.Types.TrafficClass.Tc2"/>
                /// .
                /// </summary>
                public const string Tc2 = "TC2";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectApplicationAwareInterconnectBandwidthPercentage.Types.TrafficClass.Tc3"/>
                /// .
                /// </summary>
                public const string Tc3 = "TC3";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectApplicationAwareInterconnectBandwidthPercentage.Types.TrafficClass.Tc4"/>
                /// .
                /// </summary>
                public const string Tc4 = "TC4";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectApplicationAwareInterconnectBandwidthPercentage.Types.TrafficClass.Tc5"/>
                /// .
                /// </summary>
                public const string Tc5 = "TC5";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectApplicationAwareInterconnectBandwidthPercentage.Types.TrafficClass.Tc6"/>
                /// .
                /// </summary>
                public const string Tc6 = "TC6";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachment"/>
        /// message.
        /// </summary>
        public static class InterconnectAttachment
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachment.Types.Bandwidth"/> enum.
            /// </summary>
            public static class Bandwidth
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachment.Types.Bandwidth.UndefinedBandwidth"/>
                /// .
                /// </summary>
                public const string UndefinedBandwidth = "UNDEFINED_BANDWIDTH";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachment.Types.Bandwidth.Bps100G"/>.
                /// </summary>
                public const string Bps100G = "BPS_100G";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachment.Types.Bandwidth.Bps100M"/>.
                /// </summary>
                public const string Bps100M = "BPS_100M";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachment.Types.Bandwidth.Bps10G"/>.
                /// </summary>
                public const string Bps10G = "BPS_10G";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachment.Types.Bandwidth.Bps1G"/>.
                /// </summary>
                public const string Bps1G = "BPS_1G";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachment.Types.Bandwidth.Bps200M"/>.
                /// </summary>
                public const string Bps200M = "BPS_200M";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachment.Types.Bandwidth.Bps20G"/>.
                /// </summary>
                public const string Bps20G = "BPS_20G";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachment.Types.Bandwidth.Bps2G"/>.
                /// </summary>
                public const string Bps2G = "BPS_2G";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachment.Types.Bandwidth.Bps300M"/>.
                /// </summary>
                public const string Bps300M = "BPS_300M";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachment.Types.Bandwidth.Bps400M"/>.
                /// </summary>
                public const string Bps400M = "BPS_400M";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachment.Types.Bandwidth.Bps500M"/>.
                /// </summary>
                public const string Bps500M = "BPS_500M";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachment.Types.Bandwidth.Bps50G"/>.
                /// </summary>
                public const string Bps50G = "BPS_50G";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachment.Types.Bandwidth.Bps50M"/>.
                /// </summary>
                public const string Bps50M = "BPS_50M";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachment.Types.Bandwidth.Bps5G"/>.
                /// </summary>
                public const string Bps5G = "BPS_5G";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachment.Types.EdgeAvailabilityDomain"/> enum.
            /// </summary>
            public static class EdgeAvailabilityDomain
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachment.Types.EdgeAvailabilityDomain.UndefinedEdgeAvailabilityDomain"/>
                /// .
                /// </summary>
                public const string UndefinedEdgeAvailabilityDomain = "UNDEFINED_EDGE_AVAILABILITY_DOMAIN";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachment.Types.EdgeAvailabilityDomain.AvailabilityDomain1"/>
                /// .
                /// </summary>
                public const string AvailabilityDomain1 = "AVAILABILITY_DOMAIN_1";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachment.Types.EdgeAvailabilityDomain.AvailabilityDomain2"/>
                /// .
                /// </summary>
                public const string AvailabilityDomain2 = "AVAILABILITY_DOMAIN_2";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachment.Types.EdgeAvailabilityDomain.AvailabilityDomainAny"/>
                /// .
                /// </summary>
                public const string AvailabilityDomainAny = "AVAILABILITY_DOMAIN_ANY";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachment.Types.Encryption"/> enum.
            /// </summary>
            public static class Encryption
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachment.Types.Encryption.UndefinedEncryption"/>
                /// .
                /// </summary>
                public const string UndefinedEncryption = "UNDEFINED_ENCRYPTION";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachment.Types.Encryption.Ipsec"/>.
                /// </summary>
                public const string Ipsec = "IPSEC";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachment.Types.Encryption.None"/>.
                /// </summary>
                public const string None = "NONE";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachment.Types.OperationalStatus"/> enum.
            /// </summary>
            public static class OperationalStatus
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachment.Types.OperationalStatus.UndefinedOperationalStatus"/>
                /// .
                /// </summary>
                public const string UndefinedOperationalStatus = "UNDEFINED_OPERATIONAL_STATUS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachment.Types.OperationalStatus.OsActive"/>
                /// .
                /// </summary>
                public const string OsActive = "OS_ACTIVE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachment.Types.OperationalStatus.OsUnprovisioned"/>
                /// .
                /// </summary>
                public const string OsUnprovisioned = "OS_UNPROVISIONED";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachment.Types.StackType"/> enum.
            /// </summary>
            public static class StackType
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachment.Types.StackType.UndefinedStackType"/>
                /// .
                /// </summary>
                public const string UndefinedStackType = "UNDEFINED_STACK_TYPE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachment.Types.StackType.Ipv4Ipv6"/>.
                /// </summary>
                public const string Ipv4Ipv6 = "IPV4_IPV6";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachment.Types.StackType.Ipv4Only"/>.
                /// </summary>
                public const string Ipv4Only = "IPV4_ONLY";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachment.Types.State"/> enum.
            /// </summary>
            public static class State
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachment.Types.State.UndefinedState"/>.
                /// </summary>
                public const string UndefinedState = "UNDEFINED_STATE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachment.Types.State.Active"/>.
                /// </summary>
                public const string Active = "ACTIVE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachment.Types.State.Defunct"/>.
                /// </summary>
                public const string Defunct = "DEFUNCT";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachment.Types.State.PartnerRequestReceived"/>
                /// .
                /// </summary>
                public const string PartnerRequestReceived = "PARTNER_REQUEST_RECEIVED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachment.Types.State.PendingCustomer"/>.
                /// </summary>
                public const string PendingCustomer = "PENDING_CUSTOMER";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachment.Types.State.PendingPartner"/>.
                /// </summary>
                public const string PendingPartner = "PENDING_PARTNER";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachment.Types.State.Unspecified"/>.
                /// </summary>
                public const string Unspecified = "STATE_UNSPECIFIED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachment.Types.State.Unprovisioned"/>.
                /// </summary>
                public const string Unprovisioned = "UNPROVISIONED";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachment.Types.Type"/> enum.
            /// </summary>
            public static class Type
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachment.Types.Type.UndefinedType"/>.
                /// </summary>
                public const string UndefinedType = "UNDEFINED_TYPE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachment.Types.Type.Dedicated"/>.
                /// </summary>
                public const string Dedicated = "DEDICATED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachment.Types.Type.Partner"/>.
                /// </summary>
                public const string Partner = "PARTNER";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachment.Types.Type.PartnerProvider"/>.
                /// </summary>
                public const string PartnerProvider = "PARTNER_PROVIDER";
            }
        }

        /// <summary>
        /// Container class for enums within the
        /// <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachmentConfigurationConstraints"/> message.
        /// </summary>
        public static class InterconnectAttachmentConfigurationConstraints
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachmentConfigurationConstraints.Types.BgpMd5"/>
            ///  enum.
            /// </summary>
            public static class BgpMd5
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachmentConfigurationConstraints.Types.BgpMd5.UndefinedBgpMd5"/>
                /// .
                /// </summary>
                public const string UndefinedBgpMd5 = "UNDEFINED_BGP_MD5";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachmentConfigurationConstraints.Types.BgpMd5.Md5Optional"/>
                /// .
                /// </summary>
                public const string Md5Optional = "MD5_OPTIONAL";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachmentConfigurationConstraints.Types.BgpMd5.Md5Required"/>
                /// .
                /// </summary>
                public const string Md5Required = "MD5_REQUIRED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachmentConfigurationConstraints.Types.BgpMd5.Md5Unsupported"/>
                /// .
                /// </summary>
                public const string Md5Unsupported = "MD5_UNSUPPORTED";
            }
        }

        /// <summary>
        /// Container class for enums within the
        /// <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachmentGroupConfiguredAvailabilitySLA"/> message.
        /// </summary>
        public static class InterconnectAttachmentGroupConfiguredAvailabilitySLA
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachmentGroupConfiguredAvailabilitySLA.Types.EffectiveSla"/>
            ///  enum.
            /// </summary>
            public static class EffectiveSla
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachmentGroupConfiguredAvailabilitySLA.Types.EffectiveSla.UndefinedEffectiveSla"/>
                /// .
                /// </summary>
                public const string UndefinedEffectiveSla = "UNDEFINED_EFFECTIVE_SLA";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachmentGroupConfiguredAvailabilitySLA.Types.EffectiveSla.Unspecified"/>
                /// .
                /// </summary>
                public const string Unspecified = "EFFECTIVE_SLA_UNSPECIFIED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachmentGroupConfiguredAvailabilitySLA.Types.EffectiveSla.NoSla"/>
                /// .
                /// </summary>
                public const string NoSla = "NO_SLA";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachmentGroupConfiguredAvailabilitySLA.Types.EffectiveSla.ProductionCritical"/>
                /// .
                /// </summary>
                public const string ProductionCritical = "PRODUCTION_CRITICAL";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachmentGroupConfiguredAvailabilitySLA.Types.EffectiveSla.ProductionNonCritical"/>
                /// .
                /// </summary>
                public const string ProductionNonCritical = "PRODUCTION_NON_CRITICAL";
            }
        }

        /// <summary>
        /// Container class for enums within the
        /// <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachmentGroupConfiguredAvailabilitySLAIntendedSlaBlockers"/>
        ///  message.
        /// </summary>
        public static class InterconnectAttachmentGroupConfiguredAvailabilitySLAIntendedSlaBlockers
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachmentGroupConfiguredAvailabilitySLAIntendedSlaBlockers.Types.BlockerType"/>
            ///  enum.
            /// </summary>
            public static class BlockerType
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachmentGroupConfiguredAvailabilitySLAIntendedSlaBlockers.Types.BlockerType.UndefinedBlockerType"/>
                /// .
                /// </summary>
                public const string UndefinedBlockerType = "UNDEFINED_BLOCKER_TYPE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachmentGroupConfiguredAvailabilitySLAIntendedSlaBlockers.Types.BlockerType.Unspecified"/>
                /// .
                /// </summary>
                public const string Unspecified = "BLOCKER_TYPE_UNSPECIFIED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachmentGroupConfiguredAvailabilitySLAIntendedSlaBlockers.Types.BlockerType.IncompatibleMetros"/>
                /// .
                /// </summary>
                public const string IncompatibleMetros = "INCOMPATIBLE_METROS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachmentGroupConfiguredAvailabilitySLAIntendedSlaBlockers.Types.BlockerType.IncompatibleRegions"/>
                /// .
                /// </summary>
                public const string IncompatibleRegions = "INCOMPATIBLE_REGIONS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachmentGroupConfiguredAvailabilitySLAIntendedSlaBlockers.Types.BlockerType.MissingGlobalRouting"/>
                /// .
                /// </summary>
                public const string MissingGlobalRouting = "MISSING_GLOBAL_ROUTING";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachmentGroupConfiguredAvailabilitySLAIntendedSlaBlockers.Types.BlockerType.NoAttachments"/>
                /// .
                /// </summary>
                public const string NoAttachments = "NO_ATTACHMENTS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachmentGroupConfiguredAvailabilitySLAIntendedSlaBlockers.Types.BlockerType.NoAttachmentsInMetroAndZone"/>
                /// .
                /// </summary>
                public const string NoAttachmentsInMetroAndZone = "NO_ATTACHMENTS_IN_METRO_AND_ZONE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachmentGroupConfiguredAvailabilitySLAIntendedSlaBlockers.Types.BlockerType.Other"/>
                /// .
                /// </summary>
                public const string Other = "OTHER";
            }
        }

        /// <summary>
        /// Container class for enums within the
        /// <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachmentGroupIntent"/> message.
        /// </summary>
        public static class InterconnectAttachmentGroupIntent
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachmentGroupIntent.Types.AvailabilitySla"/>
            /// enum.
            /// </summary>
            public static class AvailabilitySla
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachmentGroupIntent.Types.AvailabilitySla.UndefinedAvailabilitySla"/>
                /// .
                /// </summary>
                public const string UndefinedAvailabilitySla = "UNDEFINED_AVAILABILITY_SLA";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachmentGroupIntent.Types.AvailabilitySla.Unspecified"/>
                /// .
                /// </summary>
                public const string Unspecified = "AVAILABILITY_SLA_UNSPECIFIED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachmentGroupIntent.Types.AvailabilitySla.NoSla"/>
                /// .
                /// </summary>
                public const string NoSla = "NO_SLA";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachmentGroupIntent.Types.AvailabilitySla.ProductionCritical"/>
                /// .
                /// </summary>
                public const string ProductionCritical = "PRODUCTION_CRITICAL";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachmentGroupIntent.Types.AvailabilitySla.ProductionNonCritical"/>
                /// .
                /// </summary>
                public const string ProductionNonCritical = "PRODUCTION_NON_CRITICAL";
            }
        }

        /// <summary>
        /// Container class for enums within the
        /// <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachmentGroupsOperationalStatus"/> message.
        /// </summary>
        public static class InterconnectAttachmentGroupsOperationalStatus
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachmentGroupsOperationalStatus.Types.GroupStatus"/>
            ///  enum.
            /// </summary>
            public static class GroupStatus
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachmentGroupsOperationalStatus.Types.GroupStatus.UndefinedGroupStatus"/>
                /// .
                /// </summary>
                public const string UndefinedGroupStatus = "UNDEFINED_GROUP_STATUS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachmentGroupsOperationalStatus.Types.GroupStatus.Degraded"/>
                /// .
                /// </summary>
                public const string Degraded = "DEGRADED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachmentGroupsOperationalStatus.Types.GroupStatus.FullyDown"/>
                /// .
                /// </summary>
                public const string FullyDown = "FULLY_DOWN";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachmentGroupsOperationalStatus.Types.GroupStatus.FullyUp"/>
                /// .
                /// </summary>
                public const string FullyUp = "FULLY_UP";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachmentGroupsOperationalStatus.Types.GroupStatus.Unspecified"/>
                /// .
                /// </summary>
                public const string Unspecified = "UNSPECIFIED";
            }
        }

        /// <summary>
        /// Container class for enums within the
        /// <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachmentGroupsOperationalStatusAttachmentStatus"/>
        /// message.
        /// </summary>
        public static class InterconnectAttachmentGroupsOperationalStatusAttachmentStatus
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachmentGroupsOperationalStatusAttachmentStatus.Types.IsActive"/>
            ///  enum.
            /// </summary>
            public static class IsActive
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachmentGroupsOperationalStatusAttachmentStatus.Types.IsActive.UndefinedIsActive"/>
                /// .
                /// </summary>
                public const string UndefinedIsActive = "UNDEFINED_IS_ACTIVE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachmentGroupsOperationalStatusAttachmentStatus.Types.IsActive.Active"/>
                /// .
                /// </summary>
                public const string Active = "ACTIVE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachmentGroupsOperationalStatusAttachmentStatus.Types.IsActive.Inactive"/>
                /// .
                /// </summary>
                public const string Inactive = "INACTIVE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachmentGroupsOperationalStatusAttachmentStatus.Types.IsActive.Unspecified"/>
                /// .
                /// </summary>
                public const string Unspecified = "UNSPECIFIED";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachmentGroupsOperationalStatusAttachmentStatus.Types.Status"/>
            ///  enum.
            /// </summary>
            public static class Status
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachmentGroupsOperationalStatusAttachmentStatus.Types.Status.UndefinedStatus"/>
                /// .
                /// </summary>
                public const string UndefinedStatus = "UNDEFINED_STATUS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachmentGroupsOperationalStatusAttachmentStatus.Types.Status.AttachmentStatusUnknown"/>
                /// .
                /// </summary>
                public const string AttachmentStatusUnknown = "ATTACHMENT_STATUS_UNKNOWN";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachmentGroupsOperationalStatusAttachmentStatus.Types.Status.ConnectionDisabled"/>
                /// .
                /// </summary>
                public const string ConnectionDisabled = "CONNECTION_DISABLED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachmentGroupsOperationalStatusAttachmentStatus.Types.Status.ConnectionDown"/>
                /// .
                /// </summary>
                public const string ConnectionDown = "CONNECTION_DOWN";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachmentGroupsOperationalStatusAttachmentStatus.Types.Status.ConnectionUp"/>
                /// .
                /// </summary>
                public const string ConnectionUp = "CONNECTION_UP";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachmentGroupsOperationalStatusAttachmentStatus.Types.Status.Defunct"/>
                /// .
                /// </summary>
                public const string Defunct = "DEFUNCT";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachmentGroupsOperationalStatusAttachmentStatus.Types.Status.IpsecConfigurationNeededStatus"/>
                /// .
                /// </summary>
                public const string IpsecConfigurationNeededStatus = "IPSEC_CONFIGURATION_NEEDED_STATUS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachmentGroupsOperationalStatusAttachmentStatus.Types.Status.IpsecReadyToResumeFlowStatus"/>
                /// .
                /// </summary>
                public const string IpsecReadyToResumeFlowStatus = "IPSEC_READY_TO_RESUME_FLOW_STATUS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachmentGroupsOperationalStatusAttachmentStatus.Types.Status.Ipv4DownIpv6Up"/>
                /// .
                /// </summary>
                public const string Ipv4DownIpv6Up = "IPV4_DOWN_IPV6_UP";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachmentGroupsOperationalStatusAttachmentStatus.Types.Status.Ipv4UpIpv6Down"/>
                /// .
                /// </summary>
                public const string Ipv4UpIpv6Down = "IPV4_UP_IPV6_DOWN";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachmentGroupsOperationalStatusAttachmentStatus.Types.Status.PartnerRequestReceived"/>
                /// .
                /// </summary>
                public const string PartnerRequestReceived = "PARTNER_REQUEST_RECEIVED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachmentGroupsOperationalStatusAttachmentStatus.Types.Status.PendingCustomer"/>
                /// .
                /// </summary>
                public const string PendingCustomer = "PENDING_CUSTOMER";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachmentGroupsOperationalStatusAttachmentStatus.Types.Status.PendingPartner"/>
                /// .
                /// </summary>
                public const string PendingPartner = "PENDING_PARTNER";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachmentGroupsOperationalStatusAttachmentStatus.Types.Status.Provisioned"/>
                /// .
                /// </summary>
                public const string Provisioned = "PROVISIONED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachmentGroupsOperationalStatusAttachmentStatus.Types.Status.RouterConfigurationBroken"/>
                /// .
                /// </summary>
                public const string RouterConfigurationBroken = "ROUTER_CONFIGURATION_BROKEN";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachmentGroupsOperationalStatusAttachmentStatus.Types.Status.Unprovisioned"/>
                /// .
                /// </summary>
                public const string Unprovisioned = "UNPROVISIONED";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.InterconnectDiagnostics"/>
        /// message.
        /// </summary>
        public static class InterconnectDiagnostics
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.InterconnectDiagnostics.Types.BundleAggregationType"/> enum.
            /// </summary>
            public static class BundleAggregationType
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectDiagnostics.Types.BundleAggregationType.UndefinedBundleAggregationType"/>
                /// .
                /// </summary>
                public const string UndefinedBundleAggregationType = "UNDEFINED_BUNDLE_AGGREGATION_TYPE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectDiagnostics.Types.BundleAggregationType.Lacp"/>
                /// .
                /// </summary>
                public const string Lacp = "BUNDLE_AGGREGATION_TYPE_LACP";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectDiagnostics.Types.BundleAggregationType.Static"/>
                /// .
                /// </summary>
                public const string Static = "BUNDLE_AGGREGATION_TYPE_STATIC";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.InterconnectDiagnostics.Types.BundleOperationalStatus"/>
            /// enum.
            /// </summary>
            public static class BundleOperationalStatus
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectDiagnostics.Types.BundleOperationalStatus.UndefinedBundleOperationalStatus"/>
                /// .
                /// </summary>
                public const string UndefinedBundleOperationalStatus = "UNDEFINED_BUNDLE_OPERATIONAL_STATUS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectDiagnostics.Types.BundleOperationalStatus.Down"/>
                /// .
                /// </summary>
                public const string Down = "BUNDLE_OPERATIONAL_STATUS_DOWN";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectDiagnostics.Types.BundleOperationalStatus.Up"/>
                /// .
                /// </summary>
                public const string Up = "BUNDLE_OPERATIONAL_STATUS_UP";
            }
        }

        /// <summary>
        /// Container class for enums within the
        /// <see cref="global::Google.Cloud.Compute.V1.InterconnectDiagnosticsLinkLACPStatus"/> message.
        /// </summary>
        public static class InterconnectDiagnosticsLinkLACPStatus
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.InterconnectDiagnosticsLinkLACPStatus.Types.State"/> enum.
            /// </summary>
            public static class State
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectDiagnosticsLinkLACPStatus.Types.State.UndefinedState"/>
                /// .
                /// </summary>
                public const string UndefinedState = "UNDEFINED_STATE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectDiagnosticsLinkLACPStatus.Types.State.Active"/>
                /// .
                /// </summary>
                public const string Active = "ACTIVE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectDiagnosticsLinkLACPStatus.Types.State.Detached"/>
                /// .
                /// </summary>
                public const string Detached = "DETACHED";
            }
        }

        /// <summary>
        /// Container class for enums within the
        /// <see cref="global::Google.Cloud.Compute.V1.InterconnectDiagnosticsLinkOpticalPower"/> message.
        /// </summary>
        public static class InterconnectDiagnosticsLinkOpticalPower
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.InterconnectDiagnosticsLinkOpticalPower.Types.State"/> enum.
            /// </summary>
            public static class State
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectDiagnosticsLinkOpticalPower.Types.State.UndefinedState"/>
                /// .
                /// </summary>
                public const string UndefinedState = "UNDEFINED_STATE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectDiagnosticsLinkOpticalPower.Types.State.HighAlarm"/>
                /// .
                /// </summary>
                public const string HighAlarm = "HIGH_ALARM";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectDiagnosticsLinkOpticalPower.Types.State.HighWarning"/>
                /// .
                /// </summary>
                public const string HighWarning = "HIGH_WARNING";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectDiagnosticsLinkOpticalPower.Types.State.LowAlarm"/>
                /// .
                /// </summary>
                public const string LowAlarm = "LOW_ALARM";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectDiagnosticsLinkOpticalPower.Types.State.LowWarning"/>
                /// .
                /// </summary>
                public const string LowWarning = "LOW_WARNING";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectDiagnosticsLinkOpticalPower.Types.State.Ok"/>
                /// .
                /// </summary>
                public const string Ok = "OK";
            }
        }

        /// <summary>
        /// Container class for enums within the
        /// <see cref="global::Google.Cloud.Compute.V1.InterconnectDiagnosticsLinkStatus"/> message.
        /// </summary>
        public static class InterconnectDiagnosticsLinkStatus
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.InterconnectDiagnosticsLinkStatus.Types.OperationalStatus"/>
            /// enum.
            /// </summary>
            public static class OperationalStatus
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectDiagnosticsLinkStatus.Types.OperationalStatus.UndefinedOperationalStatus"/>
                /// .
                /// </summary>
                public const string UndefinedOperationalStatus = "UNDEFINED_OPERATIONAL_STATUS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectDiagnosticsLinkStatus.Types.OperationalStatus.LinkOperationalStatusDown"/>
                /// .
                /// </summary>
                public const string LinkOperationalStatusDown = "LINK_OPERATIONAL_STATUS_DOWN";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectDiagnosticsLinkStatus.Types.OperationalStatus.LinkOperationalStatusUp"/>
                /// .
                /// </summary>
                public const string LinkOperationalStatusUp = "LINK_OPERATIONAL_STATUS_UP";
            }
        }

        /// <summary>
        /// Container class for enums within the
        /// <see cref="global::Google.Cloud.Compute.V1.InterconnectGroupConfiguredTopologyCapability"/> message.
        /// </summary>
        public static class InterconnectGroupConfiguredTopologyCapability
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.InterconnectGroupConfiguredTopologyCapability.Types.SupportedSla"/>
            ///  enum.
            /// </summary>
            public static class SupportedSla
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectGroupConfiguredTopologyCapability.Types.SupportedSla.UndefinedSupportedSla"/>
                /// .
                /// </summary>
                public const string UndefinedSupportedSla = "UNDEFINED_SUPPORTED_SLA";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectGroupConfiguredTopologyCapability.Types.SupportedSla.NoSla"/>
                /// .
                /// </summary>
                public const string NoSla = "NO_SLA";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectGroupConfiguredTopologyCapability.Types.SupportedSla.ProductionCritical"/>
                /// .
                /// </summary>
                public const string ProductionCritical = "PRODUCTION_CRITICAL";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectGroupConfiguredTopologyCapability.Types.SupportedSla.ProductionNonCritical"/>
                /// .
                /// </summary>
                public const string ProductionNonCritical = "PRODUCTION_NON_CRITICAL";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectGroupConfiguredTopologyCapability.Types.SupportedSla.Unspecified"/>
                /// .
                /// </summary>
                public const string Unspecified = "UNSPECIFIED";
            }
        }

        /// <summary>
        /// Container class for enums within the
        /// <see cref="global::Google.Cloud.Compute.V1.InterconnectGroupConfiguredTopologyCapabilityIntendedCapabilityBlockers"/>
        ///  message.
        /// </summary>
        public static class InterconnectGroupConfiguredTopologyCapabilityIntendedCapabilityBlockers
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.InterconnectGroupConfiguredTopologyCapabilityIntendedCapabilityBlockers.Types.BlockerType"/>
            ///  enum.
            /// </summary>
            public static class BlockerType
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectGroupConfiguredTopologyCapabilityIntendedCapabilityBlockers.Types.BlockerType.UndefinedBlockerType"/>
                /// .
                /// </summary>
                public const string UndefinedBlockerType = "UNDEFINED_BLOCKER_TYPE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectGroupConfiguredTopologyCapabilityIntendedCapabilityBlockers.Types.BlockerType.IncompatibleMetros"/>
                /// .
                /// </summary>
                public const string IncompatibleMetros = "INCOMPATIBLE_METROS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectGroupConfiguredTopologyCapabilityIntendedCapabilityBlockers.Types.BlockerType.NotAvailable"/>
                /// .
                /// </summary>
                public const string NotAvailable = "NOT_AVAILABLE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectGroupConfiguredTopologyCapabilityIntendedCapabilityBlockers.Types.BlockerType.NoInterconnects"/>
                /// .
                /// </summary>
                public const string NoInterconnects = "NO_INTERCONNECTS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectGroupConfiguredTopologyCapabilityIntendedCapabilityBlockers.Types.BlockerType.NoInterconnectsInMetroAndZone"/>
                /// .
                /// </summary>
                public const string NoInterconnectsInMetroAndZone = "NO_INTERCONNECTS_IN_METRO_AND_ZONE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectGroupConfiguredTopologyCapabilityIntendedCapabilityBlockers.Types.BlockerType.Other"/>
                /// .
                /// </summary>
                public const string Other = "OTHER";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectGroupConfiguredTopologyCapabilityIntendedCapabilityBlockers.Types.BlockerType.Unspecified"/>
                /// .
                /// </summary>
                public const string Unspecified = "UNSPECIFIED";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.InterconnectGroupIntent"/>
        /// message.
        /// </summary>
        public static class InterconnectGroupIntent
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.InterconnectGroupIntent.Types.TopologyCapability"/> enum.
            /// </summary>
            public static class TopologyCapability
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectGroupIntent.Types.TopologyCapability.UndefinedTopologyCapability"/>
                /// .
                /// </summary>
                public const string UndefinedTopologyCapability = "UNDEFINED_TOPOLOGY_CAPABILITY";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectGroupIntent.Types.TopologyCapability.NoSla"/>
                /// .
                /// </summary>
                public const string NoSla = "NO_SLA";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectGroupIntent.Types.TopologyCapability.ProductionCritical"/>
                /// .
                /// </summary>
                public const string ProductionCritical = "PRODUCTION_CRITICAL";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectGroupIntent.Types.TopologyCapability.ProductionNonCritical"/>
                /// .
                /// </summary>
                public const string ProductionNonCritical = "PRODUCTION_NON_CRITICAL";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectGroupIntent.Types.TopologyCapability.Unspecified"/>
                /// .
                /// </summary>
                public const string Unspecified = "UNSPECIFIED";
            }
        }

        /// <summary>
        /// Container class for enums within the
        /// <see cref="global::Google.Cloud.Compute.V1.InterconnectGroupsCreateMembers"/> message.
        /// </summary>
        public static class InterconnectGroupsCreateMembers
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.InterconnectGroupsCreateMembers.Types.IntentMismatchBehavior"/>
            ///  enum.
            /// </summary>
            public static class IntentMismatchBehavior
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectGroupsCreateMembers.Types.IntentMismatchBehavior.UndefinedIntentMismatchBehavior"/>
                /// .
                /// </summary>
                public const string UndefinedIntentMismatchBehavior = "UNDEFINED_INTENT_MISMATCH_BEHAVIOR";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectGroupsCreateMembers.Types.IntentMismatchBehavior.Create"/>
                /// .
                /// </summary>
                public const string Create = "CREATE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectGroupsCreateMembers.Types.IntentMismatchBehavior.Reject"/>
                /// .
                /// </summary>
                public const string Reject = "REJECT";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectGroupsCreateMembers.Types.IntentMismatchBehavior.Unspecified"/>
                /// .
                /// </summary>
                public const string Unspecified = "UNSPECIFIED";
            }
        }

        /// <summary>
        /// Container class for enums within the
        /// <see cref="global::Google.Cloud.Compute.V1.InterconnectGroupsCreateMembersInterconnectInput"/> message.
        /// </summary>
        public static class InterconnectGroupsCreateMembersInterconnectInput
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.InterconnectGroupsCreateMembersInterconnectInput.Types.InterconnectType"/>
            ///  enum.
            /// </summary>
            public static class InterconnectType
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectGroupsCreateMembersInterconnectInput.Types.InterconnectType.UndefinedInterconnectType"/>
                /// .
                /// </summary>
                public const string UndefinedInterconnectType = "UNDEFINED_INTERCONNECT_TYPE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectGroupsCreateMembersInterconnectInput.Types.InterconnectType.Dedicated"/>
                /// .
                /// </summary>
                public const string Dedicated = "DEDICATED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectGroupsCreateMembersInterconnectInput.Types.InterconnectType.ItPrivate"/>
                /// .
                /// </summary>
                public const string ItPrivate = "IT_PRIVATE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectGroupsCreateMembersInterconnectInput.Types.InterconnectType.Partner"/>
                /// .
                /// </summary>
                public const string Partner = "PARTNER";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.InterconnectGroupsCreateMembersInterconnectInput.Types.LinkType"/>
            ///  enum.
            /// </summary>
            public static class LinkType
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectGroupsCreateMembersInterconnectInput.Types.LinkType.UndefinedLinkType"/>
                /// .
                /// </summary>
                public const string UndefinedLinkType = "UNDEFINED_LINK_TYPE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectGroupsCreateMembersInterconnectInput.Types.LinkType.Ethernet100GLr"/>
                /// .
                /// </summary>
                public const string Ethernet100GLr = "LINK_TYPE_ETHERNET_100G_LR";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectGroupsCreateMembersInterconnectInput.Types.LinkType.Ethernet10GLr"/>
                /// .
                /// </summary>
                public const string Ethernet10GLr = "LINK_TYPE_ETHERNET_10G_LR";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectGroupsCreateMembersInterconnectInput.Types.LinkType.Ethernet400GLr4"/>
                /// .
                /// </summary>
                public const string Ethernet400GLr4 = "LINK_TYPE_ETHERNET_400G_LR4";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.InterconnectGroupsCreateMembersInterconnectInput.Types.RequestedFeatures"/>
            ///  enum.
            /// </summary>
            public static class RequestedFeatures
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectGroupsCreateMembersInterconnectInput.Types.RequestedFeatures.UndefinedRequestedFeatures"/>
                /// .
                /// </summary>
                public const string UndefinedRequestedFeatures = "UNDEFINED_REQUESTED_FEATURES";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectGroupsCreateMembersInterconnectInput.Types.RequestedFeatures.IfMacsec"/>
                /// .
                /// </summary>
                public const string IfMacsec = "IF_MACSEC";
            }
        }

        /// <summary>
        /// Container class for enums within the
        /// <see cref="global::Google.Cloud.Compute.V1.InterconnectGroupsOperationalStatus"/> message.
        /// </summary>
        public static class InterconnectGroupsOperationalStatus
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.InterconnectGroupsOperationalStatus.Types.GroupStatus"/>
            /// enum.
            /// </summary>
            public static class GroupStatus
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectGroupsOperationalStatus.Types.GroupStatus.UndefinedGroupStatus"/>
                /// .
                /// </summary>
                public const string UndefinedGroupStatus = "UNDEFINED_GROUP_STATUS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectGroupsOperationalStatus.Types.GroupStatus.Degraded"/>
                /// .
                /// </summary>
                public const string Degraded = "DEGRADED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectGroupsOperationalStatus.Types.GroupStatus.FullyDown"/>
                /// .
                /// </summary>
                public const string FullyDown = "FULLY_DOWN";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectGroupsOperationalStatus.Types.GroupStatus.FullyUp"/>
                /// .
                /// </summary>
                public const string FullyUp = "FULLY_UP";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectGroupsOperationalStatus.Types.GroupStatus.GroupsStatusUnspecified"/>
                /// .
                /// </summary>
                public const string GroupsStatusUnspecified = "GROUPS_STATUS_UNSPECIFIED";
            }
        }

        /// <summary>
        /// Container class for enums within the
        /// <see cref="global::Google.Cloud.Compute.V1.InterconnectGroupsOperationalStatusInterconnectStatus"/> message.
        /// </summary>
        public static class InterconnectGroupsOperationalStatusInterconnectStatus
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.InterconnectGroupsOperationalStatusInterconnectStatus.Types.IsActive"/>
            ///  enum.
            /// </summary>
            public static class IsActive
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectGroupsOperationalStatusInterconnectStatus.Types.IsActive.UndefinedIsActive"/>
                /// .
                /// </summary>
                public const string UndefinedIsActive = "UNDEFINED_IS_ACTIVE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectGroupsOperationalStatusInterconnectStatus.Types.IsActive.Active"/>
                /// .
                /// </summary>
                public const string Active = "ACTIVE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectGroupsOperationalStatusInterconnectStatus.Types.IsActive.Inactive"/>
                /// .
                /// </summary>
                public const string Inactive = "INACTIVE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectGroupsOperationalStatusInterconnectStatus.Types.IsActive.Unspecified"/>
                /// .
                /// </summary>
                public const string Unspecified = "IS_ACTIVE_UNSPECIFIED";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.InterconnectLocation"/>
        /// message.
        /// </summary>
        public static class InterconnectLocation
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.InterconnectLocation.Types.AvailableFeatures"/> enum.
            /// </summary>
            public static class AvailableFeatures
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectLocation.Types.AvailableFeatures.UndefinedAvailableFeatures"/>
                /// .
                /// </summary>
                public const string UndefinedAvailableFeatures = "UNDEFINED_AVAILABLE_FEATURES";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectLocation.Types.AvailableFeatures.IfMacsec"/>.
                /// </summary>
                public const string IfMacsec = "IF_MACSEC";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.InterconnectLocation.Types.AvailableLinkTypes"/> enum.
            /// </summary>
            public static class AvailableLinkTypes
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectLocation.Types.AvailableLinkTypes.UndefinedAvailableLinkTypes"/>
                /// .
                /// </summary>
                public const string UndefinedAvailableLinkTypes = "UNDEFINED_AVAILABLE_LINK_TYPES";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectLocation.Types.AvailableLinkTypes.LinkTypeEthernet100GLr"/>
                /// .
                /// </summary>
                public const string LinkTypeEthernet100GLr = "LINK_TYPE_ETHERNET_100G_LR";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectLocation.Types.AvailableLinkTypes.LinkTypeEthernet10GLr"/>
                /// .
                /// </summary>
                public const string LinkTypeEthernet10GLr = "LINK_TYPE_ETHERNET_10G_LR";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectLocation.Types.AvailableLinkTypes.LinkTypeEthernet400GLr4"/>
                /// .
                /// </summary>
                public const string LinkTypeEthernet400GLr4 = "LINK_TYPE_ETHERNET_400G_LR4";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.InterconnectLocation.Types.Continent"/> enum.
            /// </summary>
            public static class Continent
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectLocation.Types.Continent.UndefinedContinent"/>
                /// .
                /// </summary>
                public const string UndefinedContinent = "UNDEFINED_CONTINENT";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectLocation.Types.Continent.Africa"/>.
                /// </summary>
                public const string Africa = "AFRICA";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectLocation.Types.Continent.AsiaPac"/>.
                /// </summary>
                public const string AsiaPac = "ASIA_PAC";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectLocation.Types.Continent.CAfrica"/>.
                /// </summary>
                public const string CAfrica = "C_AFRICA";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectLocation.Types.Continent.CAsiaPac"/>.
                /// </summary>
                public const string CAsiaPac = "C_ASIA_PAC";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectLocation.Types.Continent.CEurope"/>.
                /// </summary>
                public const string CEurope = "C_EUROPE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectLocation.Types.Continent.CNorthAmerica"/>.
                /// </summary>
                public const string CNorthAmerica = "C_NORTH_AMERICA";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectLocation.Types.Continent.CSouthAmerica"/>.
                /// </summary>
                public const string CSouthAmerica = "C_SOUTH_AMERICA";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectLocation.Types.Continent.Europe"/>.
                /// </summary>
                public const string Europe = "EUROPE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectLocation.Types.Continent.NorthAmerica"/>.
                /// </summary>
                public const string NorthAmerica = "NORTH_AMERICA";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectLocation.Types.Continent.SouthAmerica"/>.
                /// </summary>
                public const string SouthAmerica = "SOUTH_AMERICA";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.InterconnectLocation.Types.Status"/> enum.
            /// </summary>
            public static class Status
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectLocation.Types.Status.UndefinedStatus"/>.
                /// </summary>
                public const string UndefinedStatus = "UNDEFINED_STATUS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectLocation.Types.Status.Available"/>.
                /// </summary>
                public const string Available = "AVAILABLE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectLocation.Types.Status.Closed"/>.
                /// </summary>
                public const string Closed = "CLOSED";
            }
        }

        /// <summary>
        /// Container class for enums within the
        /// <see cref="global::Google.Cloud.Compute.V1.InterconnectLocationRegionInfo"/> message.
        /// </summary>
        public static class InterconnectLocationRegionInfo
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.InterconnectLocationRegionInfo.Types.LocationPresence"/>
            /// enum.
            /// </summary>
            public static class LocationPresence
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectLocationRegionInfo.Types.LocationPresence.UndefinedLocationPresence"/>
                /// .
                /// </summary>
                public const string UndefinedLocationPresence = "UNDEFINED_LOCATION_PRESENCE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectLocationRegionInfo.Types.LocationPresence.Global"/>
                /// .
                /// </summary>
                public const string Global = "GLOBAL";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectLocationRegionInfo.Types.LocationPresence.LocalRegion"/>
                /// .
                /// </summary>
                public const string LocalRegion = "LOCAL_REGION";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectLocationRegionInfo.Types.LocationPresence.LpGlobal"/>
                /// .
                /// </summary>
                public const string LpGlobal = "LP_GLOBAL";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectLocationRegionInfo.Types.LocationPresence.LpLocalRegion"/>
                /// .
                /// </summary>
                public const string LpLocalRegion = "LP_LOCAL_REGION";
            }
        }

        /// <summary>
        /// Container class for enums within the
        /// <see cref="global::Google.Cloud.Compute.V1.InterconnectOutageNotification"/> message.
        /// </summary>
        public static class InterconnectOutageNotification
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.InterconnectOutageNotification.Types.IssueType"/> enum.
            /// </summary>
            public static class IssueType
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectOutageNotification.Types.IssueType.UndefinedIssueType"/>
                /// .
                /// </summary>
                public const string UndefinedIssueType = "UNDEFINED_ISSUE_TYPE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectOutageNotification.Types.IssueType.ItOutage"/>
                /// .
                /// </summary>
                public const string ItOutage = "IT_OUTAGE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectOutageNotification.Types.IssueType.ItPartialOutage"/>
                /// .
                /// </summary>
                public const string ItPartialOutage = "IT_PARTIAL_OUTAGE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectOutageNotification.Types.IssueType.Outage"/>.
                /// </summary>
                public const string Outage = "OUTAGE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectOutageNotification.Types.IssueType.PartialOutage"/>
                /// .
                /// </summary>
                public const string PartialOutage = "PARTIAL_OUTAGE";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.InterconnectOutageNotification.Types.Source"/> enum.
            /// </summary>
            public static class Source
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectOutageNotification.Types.Source.UndefinedSource"/>
                /// .
                /// </summary>
                public const string UndefinedSource = "UNDEFINED_SOURCE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectOutageNotification.Types.Source.Google"/>.
                /// </summary>
                public const string Google = "GOOGLE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectOutageNotification.Types.Source.NsrcGoogle"/>
                /// .
                /// </summary>
                public const string NsrcGoogle = "NSRC_GOOGLE";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.InterconnectOutageNotification.Types.State"/> enum.
            /// </summary>
            public static class State
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectOutageNotification.Types.State.UndefinedState"/>
                /// .
                /// </summary>
                public const string UndefinedState = "UNDEFINED_STATE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectOutageNotification.Types.State.Active"/>.
                /// </summary>
                public const string Active = "ACTIVE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectOutageNotification.Types.State.Cancelled"/>.
                /// </summary>
                public const string Cancelled = "CANCELLED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectOutageNotification.Types.State.Completed"/>.
                /// </summary>
                public const string Completed = "COMPLETED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectOutageNotification.Types.State.NsActive"/>.
                /// </summary>
                public const string NsActive = "NS_ACTIVE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectOutageNotification.Types.State.NsCanceled"/>.
                /// </summary>
                public const string NsCanceled = "NS_CANCELED";
            }
        }

        /// <summary>
        /// Container class for enums within the
        /// <see cref="global::Google.Cloud.Compute.V1.InterconnectRemoteLocation"/> message.
        /// </summary>
        public static class InterconnectRemoteLocation
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.InterconnectRemoteLocation.Types.Continent"/> enum.
            /// </summary>
            public static class Continent
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectRemoteLocation.Types.Continent.UndefinedContinent"/>
                /// .
                /// </summary>
                public const string UndefinedContinent = "UNDEFINED_CONTINENT";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectRemoteLocation.Types.Continent.Africa"/>.
                /// </summary>
                public const string Africa = "AFRICA";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectRemoteLocation.Types.Continent.AsiaPac"/>.
                /// </summary>
                public const string AsiaPac = "ASIA_PAC";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectRemoteLocation.Types.Continent.Europe"/>.
                /// </summary>
                public const string Europe = "EUROPE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectRemoteLocation.Types.Continent.NorthAmerica"/>
                /// .
                /// </summary>
                public const string NorthAmerica = "NORTH_AMERICA";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectRemoteLocation.Types.Continent.SouthAmerica"/>
                /// .
                /// </summary>
                public const string SouthAmerica = "SOUTH_AMERICA";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.InterconnectRemoteLocation.Types.Lacp"/> enum.
            /// </summary>
            public static class Lacp
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectRemoteLocation.Types.Lacp.UndefinedLacp"/>.
                /// </summary>
                public const string UndefinedLacp = "UNDEFINED_LACP";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectRemoteLocation.Types.Lacp.Supported"/>.
                /// </summary>
                public const string Supported = "LACP_SUPPORTED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectRemoteLocation.Types.Lacp.Unsupported"/>.
                /// </summary>
                public const string Unsupported = "LACP_UNSUPPORTED";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.InterconnectRemoteLocation.Types.Status"/> enum.
            /// </summary>
            public static class Status
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectRemoteLocation.Types.Status.UndefinedStatus"/>
                /// .
                /// </summary>
                public const string UndefinedStatus = "UNDEFINED_STATUS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectRemoteLocation.Types.Status.Available"/>.
                /// </summary>
                public const string Available = "AVAILABLE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectRemoteLocation.Types.Status.Closed"/>.
                /// </summary>
                public const string Closed = "CLOSED";
            }
        }

        /// <summary>
        /// Container class for enums within the
        /// <see cref="global::Google.Cloud.Compute.V1.InterconnectRemoteLocationConstraints"/> message.
        /// </summary>
        public static class InterconnectRemoteLocationConstraints
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.InterconnectRemoteLocationConstraints.Types.PortPairRemoteLocation"/>
            ///  enum.
            /// </summary>
            public static class PortPairRemoteLocation
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectRemoteLocationConstraints.Types.PortPairRemoteLocation.UndefinedPortPairRemoteLocation"/>
                /// .
                /// </summary>
                public const string UndefinedPortPairRemoteLocation = "UNDEFINED_PORT_PAIR_REMOTE_LOCATION";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectRemoteLocationConstraints.Types.PortPairRemoteLocation.PortPairMatchingRemoteLocation"/>
                /// .
                /// </summary>
                public const string PortPairMatchingRemoteLocation = "PORT_PAIR_MATCHING_REMOTE_LOCATION";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectRemoteLocationConstraints.Types.PortPairRemoteLocation.PortPairUnconstrainedRemoteLocation"/>
                /// .
                /// </summary>
                public const string PortPairUnconstrainedRemoteLocation = "PORT_PAIR_UNCONSTRAINED_REMOTE_LOCATION";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.InterconnectRemoteLocationConstraints.Types.PortPairVlan"/>
            /// enum.
            /// </summary>
            public static class PortPairVlan
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectRemoteLocationConstraints.Types.PortPairVlan.UndefinedPortPairVlan"/>
                /// .
                /// </summary>
                public const string UndefinedPortPairVlan = "UNDEFINED_PORT_PAIR_VLAN";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectRemoteLocationConstraints.Types.PortPairVlan.PortPairMatchingVlan"/>
                /// .
                /// </summary>
                public const string PortPairMatchingVlan = "PORT_PAIR_MATCHING_VLAN";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.InterconnectRemoteLocationConstraints.Types.PortPairVlan.PortPairUnconstrainedVlan"/>
                /// .
                /// </summary>
                public const string PortPairUnconstrainedVlan = "PORT_PAIR_UNCONSTRAINED_VLAN";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.LicenseCode"/> message.
        /// </summary>
        public static class LicenseCode
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.LicenseCode.Types.State"/> enum.
            /// </summary>
            public static class State
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.LicenseCode.Types.State.UndefinedState"/>.
                /// </summary>
                public const string UndefinedState = "UNDEFINED_STATE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.LicenseCode.Types.State.Disabled"/>.
                /// </summary>
                public const string Disabled = "DISABLED";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.LicenseCode.Types.State.Enabled"/>
                /// .
                /// </summary>
                public const string Enabled = "ENABLED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.LicenseCode.Types.State.Restricted"/>.
                /// </summary>
                public const string Restricted = "RESTRICTED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.LicenseCode.Types.State.Unspecified"/>.
                /// </summary>
                public const string Unspecified = "STATE_UNSPECIFIED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.LicenseCode.Types.State.Terminated"/>.
                /// </summary>
                public const string Terminated = "TERMINATED";
            }
        }

        /// <summary>
        /// Container class for enums within the
        /// <see cref="global::Google.Cloud.Compute.V1.ListBgpRoutesRoutersRequest"/> message.
        /// </summary>
        public static class ListBgpRoutesRoutersRequest
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.ListBgpRoutesRoutersRequest.Types.AddressFamily"/> enum.
            /// </summary>
            public static class AddressFamily
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ListBgpRoutesRoutersRequest.Types.AddressFamily.UndefinedAddressFamily"/>
                /// .
                /// </summary>
                public const string UndefinedAddressFamily = "UNDEFINED_ADDRESS_FAMILY";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ListBgpRoutesRoutersRequest.Types.AddressFamily.Ipv4"/>.
                /// </summary>
                public const string Ipv4 = "IPV4";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ListBgpRoutesRoutersRequest.Types.AddressFamily.Ipv6"/>.
                /// </summary>
                public const string Ipv6 = "IPV6";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ListBgpRoutesRoutersRequest.Types.AddressFamily.UnspecifiedIpVersion"/>
                /// .
                /// </summary>
                public const string UnspecifiedIpVersion = "UNSPECIFIED_IP_VERSION";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.ListBgpRoutesRoutersRequest.Types.RouteType"/> enum.
            /// </summary>
            public static class RouteType
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ListBgpRoutesRoutersRequest.Types.RouteType.UndefinedRouteType"/>
                /// .
                /// </summary>
                public const string UndefinedRouteType = "UNDEFINED_ROUTE_TYPE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ListBgpRoutesRoutersRequest.Types.RouteType.Advertised"/>
                /// .
                /// </summary>
                public const string Advertised = "ADVERTISED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ListBgpRoutesRoutersRequest.Types.RouteType.Learned"/>.
                /// </summary>
                public const string Learned = "LEARNED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ListBgpRoutesRoutersRequest.Types.RouteType.UnspecifiedRouteType"/>
                /// .
                /// </summary>
                public const string UnspecifiedRouteType = "UNSPECIFIED_ROUTE_TYPE";
            }
        }

        /// <summary>
        /// Container class for enums within the
        /// <see cref="global::Google.Cloud.Compute.V1.ListPeeringRoutesNetworksRequest"/> message.
        /// </summary>
        public static class ListPeeringRoutesNetworksRequest
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.ListPeeringRoutesNetworksRequest.Types.Direction"/> enum.
            /// </summary>
            public static class Direction
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ListPeeringRoutesNetworksRequest.Types.Direction.UndefinedDirection"/>
                /// .
                /// </summary>
                public const string UndefinedDirection = "UNDEFINED_DIRECTION";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ListPeeringRoutesNetworksRequest.Types.Direction.Incoming"/>
                /// .
                /// </summary>
                public const string Incoming = "INCOMING";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ListPeeringRoutesNetworksRequest.Types.Direction.Outgoing"/>
                /// .
                /// </summary>
                public const string Outgoing = "OUTGOING";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.LocationPolicy"/> message.
        /// </summary>
        public static class LocationPolicy
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.LocationPolicy.Types.TargetShape"/> enum.
            /// </summary>
            public static class TargetShape
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.LocationPolicy.Types.TargetShape.UndefinedTargetShape"/>.
                /// </summary>
                public const string UndefinedTargetShape = "UNDEFINED_TARGET_SHAPE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.LocationPolicy.Types.TargetShape.Any"/>.
                /// </summary>
                public const string Any = "ANY";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.LocationPolicy.Types.TargetShape.AnySingleZone"/>.
                /// </summary>
                public const string AnySingleZone = "ANY_SINGLE_ZONE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.LocationPolicy.Types.TargetShape.Balanced"/>.
                /// </summary>
                public const string Balanced = "BALANCED";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.LocationPolicyLocation"/>
        /// message.
        /// </summary>
        public static class LocationPolicyLocation
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.LocationPolicyLocation.Types.Preference"/> enum.
            /// </summary>
            public static class Preference
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.LocationPolicyLocation.Types.Preference.UndefinedPreference"/>
                /// .
                /// </summary>
                public const string UndefinedPreference = "UNDEFINED_PREFERENCE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.LocationPolicyLocation.Types.Preference.Allow"/>.
                /// </summary>
                public const string Allow = "ALLOW";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.LocationPolicyLocation.Types.Preference.Deny"/>.
                /// </summary>
                public const string Deny = "DENY";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.LocationPolicyLocation.Types.Preference.Unspecified"/>.
                /// </summary>
                public const string Unspecified = "PREFERENCE_UNSPECIFIED";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.MachineImage"/> message.
        /// </summary>
        public static class MachineImage
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.MachineImage.Types.Status"/> enum.
            /// </summary>
            public static class Status
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.MachineImage.Types.Status.UndefinedStatus"/>.
                /// </summary>
                public const string UndefinedStatus = "UNDEFINED_STATUS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.MachineImage.Types.Status.Creating"/>.
                /// </summary>
                public const string Creating = "CREATING";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.MachineImage.Types.Status.Deleting"/>.
                /// </summary>
                public const string Deleting = "DELETING";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.MachineImage.Types.Status.Invalid"/>.
                /// </summary>
                public const string Invalid = "INVALID";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.MachineImage.Types.Status.Ready"/>
                /// .
                /// </summary>
                public const string Ready = "READY";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.MachineImage.Types.Status.Uploading"/>.
                /// </summary>
                public const string Uploading = "UPLOADING";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.MachineType"/> message.
        /// </summary>
        public static class MachineType
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.MachineType.Types.Architecture"/> enum.
            /// </summary>
            public static class Architecture
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.MachineType.Types.Architecture.UndefinedArchitecture"/>.
                /// </summary>
                public const string UndefinedArchitecture = "UNDEFINED_ARCHITECTURE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.MachineType.Types.Architecture.Unspecified"/>.
                /// </summary>
                public const string Unspecified = "ARCHITECTURE_UNSPECIFIED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.MachineType.Types.Architecture.Arm64"/>.
                /// </summary>
                public const string Arm64 = "ARM64";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.MachineType.Types.Architecture.X8664"/>.
                /// </summary>
                public const string X8664 = "X86_64";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.ManagedInstance"/> message.
        /// </summary>
        public static class ManagedInstance
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.ManagedInstance.Types.CurrentAction"/> enum.
            /// </summary>
            public static class CurrentAction
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ManagedInstance.Types.CurrentAction.UndefinedCurrentAction"/>
                /// .
                /// </summary>
                public const string UndefinedCurrentAction = "UNDEFINED_CURRENT_ACTION";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ManagedInstance.Types.CurrentAction.Abandoning"/>.
                /// </summary>
                public const string Abandoning = "ABANDONING";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ManagedInstance.Types.CurrentAction.Creating"/>.
                /// </summary>
                public const string Creating = "CREATING";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ManagedInstance.Types.CurrentAction.CreatingWithoutRetries"/>
                /// .
                /// </summary>
                public const string CreatingWithoutRetries = "CREATING_WITHOUT_RETRIES";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ManagedInstance.Types.CurrentAction.Deleting"/>.
                /// </summary>
                public const string Deleting = "DELETING";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ManagedInstance.Types.CurrentAction.None"/>.
                /// </summary>
                public const string None = "NONE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ManagedInstance.Types.CurrentAction.Recreating"/>.
                /// </summary>
                public const string Recreating = "RECREATING";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ManagedInstance.Types.CurrentAction.Refreshing"/>.
                /// </summary>
                public const string Refreshing = "REFRESHING";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ManagedInstance.Types.CurrentAction.Restarting"/>.
                /// </summary>
                public const string Restarting = "RESTARTING";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ManagedInstance.Types.CurrentAction.Resuming"/>.
                /// </summary>
                public const string Resuming = "RESUMING";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ManagedInstance.Types.CurrentAction.Starting"/>.
                /// </summary>
                public const string Starting = "STARTING";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ManagedInstance.Types.CurrentAction.Verifying"/>.
                /// </summary>
                public const string Verifying = "VERIFYING";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.ManagedInstance.Types.InstanceStatus"/> enum.
            /// </summary>
            public static class InstanceStatus
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ManagedInstance.Types.InstanceStatus.UndefinedInstanceStatus"/>
                /// .
                /// </summary>
                public const string UndefinedInstanceStatus = "UNDEFINED_INSTANCE_STATUS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ManagedInstance.Types.InstanceStatus.Deprovisioning"/>.
                /// </summary>
                public const string Deprovisioning = "DEPROVISIONING";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ManagedInstance.Types.InstanceStatus.Provisioning"/>.
                /// </summary>
                public const string Provisioning = "PROVISIONING";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ManagedInstance.Types.InstanceStatus.Repairing"/>.
                /// </summary>
                public const string Repairing = "REPAIRING";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ManagedInstance.Types.InstanceStatus.Running"/>.
                /// </summary>
                public const string Running = "RUNNING";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ManagedInstance.Types.InstanceStatus.Staging"/>.
                /// </summary>
                public const string Staging = "STAGING";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ManagedInstance.Types.InstanceStatus.Stopped"/>.
                /// </summary>
                public const string Stopped = "STOPPED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ManagedInstance.Types.InstanceStatus.Stopping"/>.
                /// </summary>
                public const string Stopping = "STOPPING";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ManagedInstance.Types.InstanceStatus.Suspended"/>.
                /// </summary>
                public const string Suspended = "SUSPENDED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ManagedInstance.Types.InstanceStatus.Suspending"/>.
                /// </summary>
                public const string Suspending = "SUSPENDING";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ManagedInstance.Types.InstanceStatus.Terminated"/>.
                /// </summary>
                public const string Terminated = "TERMINATED";
            }
        }

        /// <summary>
        /// Container class for enums within the
        /// <see cref="global::Google.Cloud.Compute.V1.ManagedInstanceInstanceHealth"/> message.
        /// </summary>
        public static class ManagedInstanceInstanceHealth
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.ManagedInstanceInstanceHealth.Types.DetailedHealthState"/>
            /// enum.
            /// </summary>
            public static class DetailedHealthState
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ManagedInstanceInstanceHealth.Types.DetailedHealthState.UndefinedDetailedHealthState"/>
                /// .
                /// </summary>
                public const string UndefinedDetailedHealthState = "UNDEFINED_DETAILED_HEALTH_STATE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ManagedInstanceInstanceHealth.Types.DetailedHealthState.Draining"/>
                /// .
                /// </summary>
                public const string Draining = "DRAINING";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ManagedInstanceInstanceHealth.Types.DetailedHealthState.Healthy"/>
                /// .
                /// </summary>
                public const string Healthy = "HEALTHY";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ManagedInstanceInstanceHealth.Types.DetailedHealthState.Timeout"/>
                /// .
                /// </summary>
                public const string Timeout = "TIMEOUT";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ManagedInstanceInstanceHealth.Types.DetailedHealthState.Unhealthy"/>
                /// .
                /// </summary>
                public const string Unhealthy = "UNHEALTHY";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ManagedInstanceInstanceHealth.Types.DetailedHealthState.Unknown"/>
                /// .
                /// </summary>
                public const string Unknown = "UNKNOWN";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.MetadataFilter"/> message.
        /// </summary>
        public static class MetadataFilter
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.MetadataFilter.Types.FilterMatchCriteria"/> enum.
            /// </summary>
            public static class FilterMatchCriteria
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.MetadataFilter.Types.FilterMatchCriteria.UndefinedFilterMatchCriteria"/>
                /// .
                /// </summary>
                public const string UndefinedFilterMatchCriteria = "UNDEFINED_FILTER_MATCH_CRITERIA";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.MetadataFilter.Types.FilterMatchCriteria.MatchAll"/>.
                /// </summary>
                public const string MatchAll = "MATCH_ALL";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.MetadataFilter.Types.FilterMatchCriteria.MatchAny"/>.
                /// </summary>
                public const string MatchAny = "MATCH_ANY";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.MetadataFilter.Types.FilterMatchCriteria.NotSet"/>.
                /// </summary>
                public const string NotSet = "NOT_SET";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.NatIpInfoNatIpInfoMapping"/>
        /// message.
        /// </summary>
        public static class NatIpInfoNatIpInfoMapping
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.NatIpInfoNatIpInfoMapping.Types.Mode"/> enum.
            /// </summary>
            public static class Mode
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NatIpInfoNatIpInfoMapping.Types.Mode.UndefinedMode"/>.
                /// </summary>
                public const string UndefinedMode = "UNDEFINED_MODE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NatIpInfoNatIpInfoMapping.Types.Mode.Auto"/>.
                /// </summary>
                public const string Auto = "AUTO";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NatIpInfoNatIpInfoMapping.Types.Mode.Manual"/>.
                /// </summary>
                public const string Manual = "MANUAL";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.NatIpInfoNatIpInfoMapping.Types.Usage"/> enum.
            /// </summary>
            public static class Usage
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NatIpInfoNatIpInfoMapping.Types.Usage.UndefinedUsage"/>.
                /// </summary>
                public const string UndefinedUsage = "UNDEFINED_USAGE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NatIpInfoNatIpInfoMapping.Types.Usage.InUse"/>.
                /// </summary>
                public const string InUse = "IN_USE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NatIpInfoNatIpInfoMapping.Types.Usage.Unused"/>.
                /// </summary>
                public const string Unused = "UNUSED";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.Network"/> message.
        /// </summary>
        public static class Network
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.Network.Types.NetworkFirewallPolicyEnforcementOrder"/> enum.
            /// </summary>
            public static class NetworkFirewallPolicyEnforcementOrder
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Network.Types.NetworkFirewallPolicyEnforcementOrder.UndefinedNetworkFirewallPolicyEnforcementOrder"/>
                /// .
                /// </summary>
                public const string UndefinedNetworkFirewallPolicyEnforcementOrder = "UNDEFINED_NETWORK_FIREWALL_POLICY_ENFORCEMENT_ORDER";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Network.Types.NetworkFirewallPolicyEnforcementOrder.AfterClassicFirewall"/>
                /// .
                /// </summary>
                public const string AfterClassicFirewall = "AFTER_CLASSIC_FIREWALL";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Network.Types.NetworkFirewallPolicyEnforcementOrder.BeforeClassicFirewall"/>
                /// .
                /// </summary>
                public const string BeforeClassicFirewall = "BEFORE_CLASSIC_FIREWALL";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.NetworkAttachment"/>
        /// message.
        /// </summary>
        public static class NetworkAttachment
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.NetworkAttachment.Types.ConnectionPreference"/> enum.
            /// </summary>
            public static class ConnectionPreference
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkAttachment.Types.ConnectionPreference.UndefinedConnectionPreference"/>
                /// .
                /// </summary>
                public const string UndefinedConnectionPreference = "UNDEFINED_CONNECTION_PREFERENCE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkAttachment.Types.ConnectionPreference.AcceptAutomatic"/>
                /// .
                /// </summary>
                public const string AcceptAutomatic = "ACCEPT_AUTOMATIC";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkAttachment.Types.ConnectionPreference.AcceptManual"/>
                /// .
                /// </summary>
                public const string AcceptManual = "ACCEPT_MANUAL";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkAttachment.Types.ConnectionPreference.Invalid"/>.
                /// </summary>
                public const string Invalid = "INVALID";
            }
        }

        /// <summary>
        /// Container class for enums within the
        /// <see cref="global::Google.Cloud.Compute.V1.NetworkAttachmentConnectedEndpoint"/> message.
        /// </summary>
        public static class NetworkAttachmentConnectedEndpoint
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.NetworkAttachmentConnectedEndpoint.Types.Status"/> enum.
            /// </summary>
            public static class Status
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkAttachmentConnectedEndpoint.Types.Status.UndefinedStatus"/>
                /// .
                /// </summary>
                public const string UndefinedStatus = "UNDEFINED_STATUS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkAttachmentConnectedEndpoint.Types.Status.Accepted"/>
                /// .
                /// </summary>
                public const string Accepted = "ACCEPTED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkAttachmentConnectedEndpoint.Types.Status.Closed"/>
                /// .
                /// </summary>
                public const string Closed = "CLOSED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkAttachmentConnectedEndpoint.Types.Status.NeedsAttention"/>
                /// .
                /// </summary>
                public const string NeedsAttention = "NEEDS_ATTENTION";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkAttachmentConnectedEndpoint.Types.Status.Pending"/>
                /// .
                /// </summary>
                public const string Pending = "PENDING";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkAttachmentConnectedEndpoint.Types.Status.Rejected"/>
                /// .
                /// </summary>
                public const string Rejected = "REJECTED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkAttachmentConnectedEndpoint.Types.Status.Unspecified"/>
                /// .
                /// </summary>
                public const string Unspecified = "STATUS_UNSPECIFIED";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.NetworkEndpointGroup"/>
        /// message.
        /// </summary>
        public static class NetworkEndpointGroup
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.NetworkEndpointGroup.Types.NetworkEndpointType"/> enum.
            /// </summary>
            public static class NetworkEndpointType
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkEndpointGroup.Types.NetworkEndpointType.UndefinedNetworkEndpointType"/>
                /// .
                /// </summary>
                public const string UndefinedNetworkEndpointType = "UNDEFINED_NETWORK_ENDPOINT_TYPE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkEndpointGroup.Types.NetworkEndpointType.GceVmIp"/>
                /// .
                /// </summary>
                public const string GceVmIp = "GCE_VM_IP";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkEndpointGroup.Types.NetworkEndpointType.GceVmIpPort"/>
                /// .
                /// </summary>
                public const string GceVmIpPort = "GCE_VM_IP_PORT";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkEndpointGroup.Types.NetworkEndpointType.GceVmIpPortmap"/>
                /// .
                /// </summary>
                public const string GceVmIpPortmap = "GCE_VM_IP_PORTMAP";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkEndpointGroup.Types.NetworkEndpointType.InternetFqdnPort"/>
                /// .
                /// </summary>
                public const string InternetFqdnPort = "INTERNET_FQDN_PORT";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkEndpointGroup.Types.NetworkEndpointType.InternetIpPort"/>
                /// .
                /// </summary>
                public const string InternetIpPort = "INTERNET_IP_PORT";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkEndpointGroup.Types.NetworkEndpointType.NonGcpPrivateIpPort"/>
                /// .
                /// </summary>
                public const string NonGcpPrivateIpPort = "NON_GCP_PRIVATE_IP_PORT";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkEndpointGroup.Types.NetworkEndpointType.PrivateServiceConnect"/>
                /// .
                /// </summary>
                public const string PrivateServiceConnect = "PRIVATE_SERVICE_CONNECT";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkEndpointGroup.Types.NetworkEndpointType.Serverless"/>
                /// .
                /// </summary>
                public const string Serverless = "SERVERLESS";
            }
        }

        /// <summary>
        /// Container class for enums within the
        /// <see cref="global::Google.Cloud.Compute.V1.NetworkEndpointGroupPscData"/> message.
        /// </summary>
        public static class NetworkEndpointGroupPscData
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.NetworkEndpointGroupPscData.Types.PscConnectionStatus"/>
            /// enum.
            /// </summary>
            public static class PscConnectionStatus
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkEndpointGroupPscData.Types.PscConnectionStatus.UndefinedPscConnectionStatus"/>
                /// .
                /// </summary>
                public const string UndefinedPscConnectionStatus = "UNDEFINED_PSC_CONNECTION_STATUS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkEndpointGroupPscData.Types.PscConnectionStatus.Accepted"/>
                /// .
                /// </summary>
                public const string Accepted = "ACCEPTED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkEndpointGroupPscData.Types.PscConnectionStatus.Closed"/>
                /// .
                /// </summary>
                public const string Closed = "CLOSED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkEndpointGroupPscData.Types.PscConnectionStatus.NeedsAttention"/>
                /// .
                /// </summary>
                public const string NeedsAttention = "NEEDS_ATTENTION";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkEndpointGroupPscData.Types.PscConnectionStatus.Pending"/>
                /// .
                /// </summary>
                public const string Pending = "PENDING";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkEndpointGroupPscData.Types.PscConnectionStatus.Rejected"/>
                /// .
                /// </summary>
                public const string Rejected = "REJECTED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkEndpointGroupPscData.Types.PscConnectionStatus.StatusUnspecified"/>
                /// .
                /// </summary>
                public const string StatusUnspecified = "STATUS_UNSPECIFIED";
            }
        }

        /// <summary>
        /// Container class for enums within the
        /// <see cref="global::Google.Cloud.Compute.V1.NetworkEndpointGroupsListEndpointsRequest"/> message.
        /// </summary>
        public static class NetworkEndpointGroupsListEndpointsRequest
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.NetworkEndpointGroupsListEndpointsRequest.Types.HealthStatus"/>
            ///  enum.
            /// </summary>
            public static class HealthStatus
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkEndpointGroupsListEndpointsRequest.Types.HealthStatus.UndefinedHealthStatus"/>
                /// .
                /// </summary>
                public const string UndefinedHealthStatus = "UNDEFINED_HEALTH_STATUS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkEndpointGroupsListEndpointsRequest.Types.HealthStatus.Show"/>
                /// .
                /// </summary>
                public const string Show = "SHOW";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkEndpointGroupsListEndpointsRequest.Types.HealthStatus.Skip"/>
                /// .
                /// </summary>
                public const string Skip = "SKIP";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.NetworkInterface"/> message.
        /// </summary>
        public static class NetworkInterface
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.NetworkInterface.Types.Ipv6AccessType"/> enum.
            /// </summary>
            public static class Ipv6AccessType
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkInterface.Types.Ipv6AccessType.UndefinedIpv6AccessType"/>
                /// .
                /// </summary>
                public const string UndefinedIpv6AccessType = "UNDEFINED_IPV6_ACCESS_TYPE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkInterface.Types.Ipv6AccessType.External"/>.
                /// </summary>
                public const string External = "EXTERNAL";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkInterface.Types.Ipv6AccessType.Internal"/>.
                /// </summary>
                public const string Internal = "INTERNAL";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkInterface.Types.Ipv6AccessType.UnspecifiedIpv6AccessType"/>
                /// .
                /// </summary>
                public const string UnspecifiedIpv6AccessType = "UNSPECIFIED_IPV6_ACCESS_TYPE";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.NetworkInterface.Types.NicType"/> enum.
            /// </summary>
            public static class NicType
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkInterface.Types.NicType.UndefinedNicType"/>.
                /// </summary>
                public const string UndefinedNicType = "UNDEFINED_NIC_TYPE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkInterface.Types.NicType.Gvnic"/>.
                /// </summary>
                public const string Gvnic = "GVNIC";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkInterface.Types.NicType.Idpf"/>.
                /// </summary>
                public const string Idpf = "IDPF";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkInterface.Types.NicType.Irdma"/>.
                /// </summary>
                public const string Irdma = "IRDMA";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkInterface.Types.NicType.Mrdma"/>.
                /// </summary>
                public const string Mrdma = "MRDMA";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkInterface.Types.NicType.UnspecifiedNicType"/>.
                /// </summary>
                public const string UnspecifiedNicType = "UNSPECIFIED_NIC_TYPE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkInterface.Types.NicType.VirtioNet"/>.
                /// </summary>
                public const string VirtioNet = "VIRTIO_NET";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.NetworkInterface.Types.StackType"/> enum.
            /// </summary>
            public static class StackType
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkInterface.Types.StackType.UndefinedStackType"/>.
                /// </summary>
                public const string UndefinedStackType = "UNDEFINED_STACK_TYPE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkInterface.Types.StackType.Ipv4Ipv6"/>.
                /// </summary>
                public const string Ipv4Ipv6 = "IPV4_IPV6";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkInterface.Types.StackType.Ipv4Only"/>.
                /// </summary>
                public const string Ipv4Only = "IPV4_ONLY";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkInterface.Types.StackType.Ipv6Only"/>.
                /// </summary>
                public const string Ipv6Only = "IPV6_ONLY";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkInterface.Types.StackType.UnspecifiedStackType"/>.
                /// </summary>
                public const string UnspecifiedStackType = "UNSPECIFIED_STACK_TYPE";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.NetworkPeering"/> message.
        /// </summary>
        public static class NetworkPeering
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.NetworkPeering.Types.StackType"/> enum.
            /// </summary>
            public static class StackType
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkPeering.Types.StackType.UndefinedStackType"/>.
                /// </summary>
                public const string UndefinedStackType = "UNDEFINED_STACK_TYPE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkPeering.Types.StackType.Ipv4Ipv6"/>.
                /// </summary>
                public const string Ipv4Ipv6 = "IPV4_IPV6";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkPeering.Types.StackType.Ipv4Only"/>.
                /// </summary>
                public const string Ipv4Only = "IPV4_ONLY";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.NetworkPeering.Types.State"/> enum.
            /// </summary>
            public static class State
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkPeering.Types.State.UndefinedState"/>.
                /// </summary>
                public const string UndefinedState = "UNDEFINED_STATE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkPeering.Types.State.Active"/>.
                /// </summary>
                public const string Active = "ACTIVE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkPeering.Types.State.Inactive"/>.
                /// </summary>
                public const string Inactive = "INACTIVE";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.NetworkPeering.Types.UpdateStrategy"/> enum.
            /// </summary>
            public static class UpdateStrategy
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkPeering.Types.UpdateStrategy.UndefinedUpdateStrategy"/>
                /// .
                /// </summary>
                public const string UndefinedUpdateStrategy = "UNDEFINED_UPDATE_STRATEGY";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkPeering.Types.UpdateStrategy.Consensus"/>.
                /// </summary>
                public const string Consensus = "CONSENSUS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkPeering.Types.UpdateStrategy.Independent"/>.
                /// </summary>
                public const string Independent = "INDEPENDENT";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkPeering.Types.UpdateStrategy.Unspecified"/>.
                /// </summary>
                public const string Unspecified = "UNSPECIFIED";
            }
        }

        /// <summary>
        /// Container class for enums within the
        /// <see cref="global::Google.Cloud.Compute.V1.NetworkPeeringConnectionStatus"/> message.
        /// </summary>
        public static class NetworkPeeringConnectionStatus
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.NetworkPeeringConnectionStatus.Types.UpdateStrategy"/> enum.
            /// </summary>
            public static class UpdateStrategy
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkPeeringConnectionStatus.Types.UpdateStrategy.UndefinedUpdateStrategy"/>
                /// .
                /// </summary>
                public const string UndefinedUpdateStrategy = "UNDEFINED_UPDATE_STRATEGY";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkPeeringConnectionStatus.Types.UpdateStrategy.Consensus"/>
                /// .
                /// </summary>
                public const string Consensus = "CONSENSUS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkPeeringConnectionStatus.Types.UpdateStrategy.Independent"/>
                /// .
                /// </summary>
                public const string Independent = "INDEPENDENT";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkPeeringConnectionStatus.Types.UpdateStrategy.Unspecified"/>
                /// .
                /// </summary>
                public const string Unspecified = "UNSPECIFIED";
            }
        }

        /// <summary>
        /// Container class for enums within the
        /// <see cref="global::Google.Cloud.Compute.V1.NetworkPeeringConnectionStatusConsensusState"/> message.
        /// </summary>
        public static class NetworkPeeringConnectionStatusConsensusState
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.NetworkPeeringConnectionStatusConsensusState.Types.DeleteStatus"/>
            ///  enum.
            /// </summary>
            public static class DeleteStatus
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkPeeringConnectionStatusConsensusState.Types.DeleteStatus.UndefinedDeleteStatus"/>
                /// .
                /// </summary>
                public const string UndefinedDeleteStatus = "UNDEFINED_DELETE_STATUS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkPeeringConnectionStatusConsensusState.Types.DeleteStatus.DeleteAcknowledged"/>
                /// .
                /// </summary>
                public const string DeleteAcknowledged = "DELETE_ACKNOWLEDGED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkPeeringConnectionStatusConsensusState.Types.DeleteStatus.Unspecified"/>
                /// .
                /// </summary>
                public const string Unspecified = "DELETE_STATUS_UNSPECIFIED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkPeeringConnectionStatusConsensusState.Types.DeleteStatus.LocalDeleteRequested"/>
                /// .
                /// </summary>
                public const string LocalDeleteRequested = "LOCAL_DELETE_REQUESTED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkPeeringConnectionStatusConsensusState.Types.DeleteStatus.PeerDeleteRequested"/>
                /// .
                /// </summary>
                public const string PeerDeleteRequested = "PEER_DELETE_REQUESTED";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.NetworkPeeringConnectionStatusConsensusState.Types.UpdateStatus"/>
            ///  enum.
            /// </summary>
            public static class UpdateStatus
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkPeeringConnectionStatusConsensusState.Types.UpdateStatus.UndefinedUpdateStatus"/>
                /// .
                /// </summary>
                public const string UndefinedUpdateStatus = "UNDEFINED_UPDATE_STATUS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkPeeringConnectionStatusConsensusState.Types.UpdateStatus.InSync"/>
                /// .
                /// </summary>
                public const string InSync = "IN_SYNC";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkPeeringConnectionStatusConsensusState.Types.UpdateStatus.PendingLocalAcknowledment"/>
                /// .
                /// </summary>
                public const string PendingLocalAcknowledment = "PENDING_LOCAL_ACKNOWLEDMENT";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkPeeringConnectionStatusConsensusState.Types.UpdateStatus.PendingPeerAcknowledgement"/>
                /// .
                /// </summary>
                public const string PendingPeerAcknowledgement = "PENDING_PEER_ACKNOWLEDGEMENT";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkPeeringConnectionStatusConsensusState.Types.UpdateStatus.Unspecified"/>
                /// .
                /// </summary>
                public const string Unspecified = "UPDATE_STATUS_UNSPECIFIED";
            }
        }

        /// <summary>
        /// Container class for enums within the
        /// <see cref="global::Google.Cloud.Compute.V1.NetworkPeeringConnectionStatusTrafficConfiguration"/> message.
        /// </summary>
        public static class NetworkPeeringConnectionStatusTrafficConfiguration
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.NetworkPeeringConnectionStatusTrafficConfiguration.Types.StackType"/>
            ///  enum.
            /// </summary>
            public static class StackType
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkPeeringConnectionStatusTrafficConfiguration.Types.StackType.UndefinedStackType"/>
                /// .
                /// </summary>
                public const string UndefinedStackType = "UNDEFINED_STACK_TYPE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkPeeringConnectionStatusTrafficConfiguration.Types.StackType.Ipv4Ipv6"/>
                /// .
                /// </summary>
                public const string Ipv4Ipv6 = "IPV4_IPV6";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkPeeringConnectionStatusTrafficConfiguration.Types.StackType.Ipv4Only"/>
                /// .
                /// </summary>
                public const string Ipv4Only = "IPV4_ONLY";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.NetworkPerformanceConfig"/>
        /// message.
        /// </summary>
        public static class NetworkPerformanceConfig
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.NetworkPerformanceConfig.Types.TotalEgressBandwidthTier"/>
            /// enum.
            /// </summary>
            public static class TotalEgressBandwidthTier
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkPerformanceConfig.Types.TotalEgressBandwidthTier.UndefinedTotalEgressBandwidthTier"/>
                /// .
                /// </summary>
                public const string UndefinedTotalEgressBandwidthTier = "UNDEFINED_TOTAL_EGRESS_BANDWIDTH_TIER";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkPerformanceConfig.Types.TotalEgressBandwidthTier.Default"/>
                /// .
                /// </summary>
                public const string Default = "DEFAULT";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkPerformanceConfig.Types.TotalEgressBandwidthTier.Tier1"/>
                /// .
                /// </summary>
                public const string Tier1 = "TIER_1";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.NetworkProfileLocation"/>
        /// message.
        /// </summary>
        public static class NetworkProfileLocation
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileLocation.Types.Scope"/> enum.
            /// </summary>
            public static class Scope
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileLocation.Types.Scope.UndefinedScope"/>.
                /// </summary>
                public const string UndefinedScope = "UNDEFINED_SCOPE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileLocation.Types.Scope.Region"/>.
                /// </summary>
                public const string Region = "REGION";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileLocation.Types.Scope.Zone"/>.
                /// </summary>
                public const string Zone = "ZONE";
            }
        }

        /// <summary>
        /// Container class for enums within the
        /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures"/> message.
        /// </summary>
        public static class NetworkProfileNetworkFeatures
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.AddressPurposes"/> enum.
            /// </summary>
            public static class AddressPurposes
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.AddressPurposes.UndefinedAddressPurposes"/>
                /// .
                /// </summary>
                public const string UndefinedAddressPurposes = "UNDEFINED_ADDRESS_PURPOSES";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.AddressPurposes.DnsResolver"/>
                /// .
                /// </summary>
                public const string DnsResolver = "DNS_RESOLVER";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.AddressPurposes.GceEndpoint"/>
                /// .
                /// </summary>
                public const string GceEndpoint = "GCE_ENDPOINT";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.AddressPurposes.IpsecInterconnect"/>
                /// .
                /// </summary>
                public const string IpsecInterconnect = "IPSEC_INTERCONNECT";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.AddressPurposes.NatAuto"/>
                /// .
                /// </summary>
                public const string NatAuto = "NAT_AUTO";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.AddressPurposes.PrivateServiceConnect"/>
                /// .
                /// </summary>
                public const string PrivateServiceConnect = "PRIVATE_SERVICE_CONNECT";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.AddressPurposes.Serverless"/>
                /// .
                /// </summary>
                public const string Serverless = "SERVERLESS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.AddressPurposes.SharedLoadbalancerVip"/>
                /// .
                /// </summary>
                public const string SharedLoadbalancerVip = "SHARED_LOADBALANCER_VIP";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.AddressPurposes.VpcPeering"/>
                /// .
                /// </summary>
                public const string VpcPeering = "VPC_PEERING";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.AllowAliasIpRanges"/>
            /// enum.
            /// </summary>
            public static class AllowAliasIpRanges
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.AllowAliasIpRanges.UndefinedAllowAliasIpRanges"/>
                /// .
                /// </summary>
                public const string UndefinedAllowAliasIpRanges = "UNDEFINED_ALLOW_ALIAS_IP_RANGES";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.AllowAliasIpRanges.AliasIpRangesAllowed"/>
                /// .
                /// </summary>
                public const string AliasIpRangesAllowed = "ALIAS_IP_RANGES_ALLOWED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.AllowAliasIpRanges.AliasIpRangesBlocked"/>
                /// .
                /// </summary>
                public const string AliasIpRangesBlocked = "ALIAS_IP_RANGES_BLOCKED";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.AllowAutoModeSubnet"/>
            /// enum.
            /// </summary>
            public static class AllowAutoModeSubnet
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.AllowAutoModeSubnet.UndefinedAllowAutoModeSubnet"/>
                /// .
                /// </summary>
                public const string UndefinedAllowAutoModeSubnet = "UNDEFINED_ALLOW_AUTO_MODE_SUBNET";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.AllowAutoModeSubnet.AutoModeSubnetAllowed"/>
                /// .
                /// </summary>
                public const string AutoModeSubnetAllowed = "AUTO_MODE_SUBNET_ALLOWED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.AllowAutoModeSubnet.AutoModeSubnetBlocked"/>
                /// .
                /// </summary>
                public const string AutoModeSubnetBlocked = "AUTO_MODE_SUBNET_BLOCKED";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.AllowClassDFirewalls"/>
            /// enum.
            /// </summary>
            public static class AllowClassDFirewalls
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.AllowClassDFirewalls.UndefinedAllowClassDFirewalls"/>
                /// .
                /// </summary>
                public const string UndefinedAllowClassDFirewalls = "UNDEFINED_ALLOW_CLASS_D_FIREWALLS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.AllowClassDFirewalls.ClassDFirewallsAllowed"/>
                /// .
                /// </summary>
                public const string ClassDFirewallsAllowed = "CLASS_D_FIREWALLS_ALLOWED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.AllowClassDFirewalls.ClassDFirewallsBlocked"/>
                /// .
                /// </summary>
                public const string ClassDFirewallsBlocked = "CLASS_D_FIREWALLS_BLOCKED";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.AllowCloudNat"/> enum.
            /// </summary>
            public static class AllowCloudNat
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.AllowCloudNat.UndefinedAllowCloudNat"/>
                /// .
                /// </summary>
                public const string UndefinedAllowCloudNat = "UNDEFINED_ALLOW_CLOUD_NAT";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.AllowCloudNat.CloudNatAllowed"/>
                /// .
                /// </summary>
                public const string CloudNatAllowed = "CLOUD_NAT_ALLOWED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.AllowCloudNat.CloudNatBlocked"/>
                /// .
                /// </summary>
                public const string CloudNatBlocked = "CLOUD_NAT_BLOCKED";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.AllowCloudRouter"/> enum.
            /// </summary>
            public static class AllowCloudRouter
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.AllowCloudRouter.UndefinedAllowCloudRouter"/>
                /// .
                /// </summary>
                public const string UndefinedAllowCloudRouter = "UNDEFINED_ALLOW_CLOUD_ROUTER";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.AllowCloudRouter.CloudRouterAllowed"/>
                /// .
                /// </summary>
                public const string CloudRouterAllowed = "CLOUD_ROUTER_ALLOWED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.AllowCloudRouter.CloudRouterBlocked"/>
                /// .
                /// </summary>
                public const string CloudRouterBlocked = "CLOUD_ROUTER_BLOCKED";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.AllowDefaultNicAttachment"/>
            ///  enum.
            /// </summary>
            public static class AllowDefaultNicAttachment
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.AllowDefaultNicAttachment.UndefinedAllowDefaultNicAttachment"/>
                /// .
                /// </summary>
                public const string UndefinedAllowDefaultNicAttachment = "UNDEFINED_ALLOW_DEFAULT_NIC_ATTACHMENT";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.AllowDefaultNicAttachment.DefaultNicAttachmentAllowed"/>
                /// .
                /// </summary>
                public const string DefaultNicAttachmentAllowed = "DEFAULT_NIC_ATTACHMENT_ALLOWED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.AllowDefaultNicAttachment.DefaultNicAttachmentBlocked"/>
                /// .
                /// </summary>
                public const string DefaultNicAttachmentBlocked = "DEFAULT_NIC_ATTACHMENT_BLOCKED";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.AllowExternalIpAccess"/>
            /// enum.
            /// </summary>
            public static class AllowExternalIpAccess
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.AllowExternalIpAccess.UndefinedAllowExternalIpAccess"/>
                /// .
                /// </summary>
                public const string UndefinedAllowExternalIpAccess = "UNDEFINED_ALLOW_EXTERNAL_IP_ACCESS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.AllowExternalIpAccess.ExternalIpAccessAllowed"/>
                /// .
                /// </summary>
                public const string ExternalIpAccessAllowed = "EXTERNAL_IP_ACCESS_ALLOWED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.AllowExternalIpAccess.ExternalIpAccessBlocked"/>
                /// .
                /// </summary>
                public const string ExternalIpAccessBlocked = "EXTERNAL_IP_ACCESS_BLOCKED";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.AllowInterconnect"/>
            /// enum.
            /// </summary>
            public static class AllowInterconnect
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.AllowInterconnect.UndefinedAllowInterconnect"/>
                /// .
                /// </summary>
                public const string UndefinedAllowInterconnect = "UNDEFINED_ALLOW_INTERCONNECT";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.AllowInterconnect.InterconnectAllowed"/>
                /// .
                /// </summary>
                public const string InterconnectAllowed = "INTERCONNECT_ALLOWED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.AllowInterconnect.InterconnectBlocked"/>
                /// .
                /// </summary>
                public const string InterconnectBlocked = "INTERCONNECT_BLOCKED";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.AllowIpForwarding"/>
            /// enum.
            /// </summary>
            public static class AllowIpForwarding
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.AllowIpForwarding.UndefinedAllowIpForwarding"/>
                /// .
                /// </summary>
                public const string UndefinedAllowIpForwarding = "UNDEFINED_ALLOW_IP_FORWARDING";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.AllowIpForwarding.IpForwardingAllowed"/>
                /// .
                /// </summary>
                public const string IpForwardingAllowed = "IP_FORWARDING_ALLOWED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.AllowIpForwarding.IpForwardingBlocked"/>
                /// .
                /// </summary>
                public const string IpForwardingBlocked = "IP_FORWARDING_BLOCKED";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.AllowLoadBalancing"/>
            /// enum.
            /// </summary>
            public static class AllowLoadBalancing
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.AllowLoadBalancing.UndefinedAllowLoadBalancing"/>
                /// .
                /// </summary>
                public const string UndefinedAllowLoadBalancing = "UNDEFINED_ALLOW_LOAD_BALANCING";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.AllowLoadBalancing.LoadBalancingAllowed"/>
                /// .
                /// </summary>
                public const string LoadBalancingAllowed = "LOAD_BALANCING_ALLOWED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.AllowLoadBalancing.LoadBalancingBlocked"/>
                /// .
                /// </summary>
                public const string LoadBalancingBlocked = "LOAD_BALANCING_BLOCKED";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.AllowMultiNicInSameNetwork"/>
            ///  enum.
            /// </summary>
            public static class AllowMultiNicInSameNetwork
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.AllowMultiNicInSameNetwork.UndefinedAllowMultiNicInSameNetwork"/>
                /// .
                /// </summary>
                public const string UndefinedAllowMultiNicInSameNetwork = "UNDEFINED_ALLOW_MULTI_NIC_IN_SAME_NETWORK";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.AllowMultiNicInSameNetwork.MultiNicInSameNetworkAllowed"/>
                /// .
                /// </summary>
                public const string MultiNicInSameNetworkAllowed = "MULTI_NIC_IN_SAME_NETWORK_ALLOWED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.AllowMultiNicInSameNetwork.MultiNicInSameNetworkBlocked"/>
                /// .
                /// </summary>
                public const string MultiNicInSameNetworkBlocked = "MULTI_NIC_IN_SAME_NETWORK_BLOCKED";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.AllowNcc"/> enum.
            /// </summary>
            public static class AllowNcc
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.AllowNcc.UndefinedAllowNcc"/>
                /// .
                /// </summary>
                public const string UndefinedAllowNcc = "UNDEFINED_ALLOW_NCC";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.AllowNcc.NccAllowed"/>
                /// .
                /// </summary>
                public const string NccAllowed = "NCC_ALLOWED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.AllowNcc.NccBlocked"/>
                /// .
                /// </summary>
                public const string NccBlocked = "NCC_BLOCKED";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.AllowNetworkMigration"/>
            /// enum.
            /// </summary>
            public static class AllowNetworkMigration
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.AllowNetworkMigration.UndefinedAllowNetworkMigration"/>
                /// .
                /// </summary>
                public const string UndefinedAllowNetworkMigration = "UNDEFINED_ALLOW_NETWORK_MIGRATION";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.AllowNetworkMigration.NetworkMigrationAllowed"/>
                /// .
                /// </summary>
                public const string NetworkMigrationAllowed = "NETWORK_MIGRATION_ALLOWED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.AllowNetworkMigration.NetworkMigrationBlocked"/>
                /// .
                /// </summary>
                public const string NetworkMigrationBlocked = "NETWORK_MIGRATION_BLOCKED";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.AllowPacketMirroring"/>
            /// enum.
            /// </summary>
            public static class AllowPacketMirroring
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.AllowPacketMirroring.UndefinedAllowPacketMirroring"/>
                /// .
                /// </summary>
                public const string UndefinedAllowPacketMirroring = "UNDEFINED_ALLOW_PACKET_MIRRORING";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.AllowPacketMirroring.PacketMirroringAllowed"/>
                /// .
                /// </summary>
                public const string PacketMirroringAllowed = "PACKET_MIRRORING_ALLOWED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.AllowPacketMirroring.PacketMirroringBlocked"/>
                /// .
                /// </summary>
                public const string PacketMirroringBlocked = "PACKET_MIRRORING_BLOCKED";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.AllowPrivateGoogleAccess"/>
            ///  enum.
            /// </summary>
            public static class AllowPrivateGoogleAccess
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.AllowPrivateGoogleAccess.UndefinedAllowPrivateGoogleAccess"/>
                /// .
                /// </summary>
                public const string UndefinedAllowPrivateGoogleAccess = "UNDEFINED_ALLOW_PRIVATE_GOOGLE_ACCESS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.AllowPrivateGoogleAccess.PrivateGoogleAccessAllowed"/>
                /// .
                /// </summary>
                public const string PrivateGoogleAccessAllowed = "PRIVATE_GOOGLE_ACCESS_ALLOWED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.AllowPrivateGoogleAccess.PrivateGoogleAccessBlocked"/>
                /// .
                /// </summary>
                public const string PrivateGoogleAccessBlocked = "PRIVATE_GOOGLE_ACCESS_BLOCKED";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.AllowPsc"/> enum.
            /// </summary>
            public static class AllowPsc
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.AllowPsc.UndefinedAllowPsc"/>
                /// .
                /// </summary>
                public const string UndefinedAllowPsc = "UNDEFINED_ALLOW_PSC";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.AllowPsc.PscAllowed"/>
                /// .
                /// </summary>
                public const string PscAllowed = "PSC_ALLOWED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.AllowPsc.PscBlocked"/>
                /// .
                /// </summary>
                public const string PscBlocked = "PSC_BLOCKED";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.AllowSameNetworkUnicast"/>
            ///  enum.
            /// </summary>
            public static class AllowSameNetworkUnicast
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.AllowSameNetworkUnicast.UndefinedAllowSameNetworkUnicast"/>
                /// .
                /// </summary>
                public const string UndefinedAllowSameNetworkUnicast = "UNDEFINED_ALLOW_SAME_NETWORK_UNICAST";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.AllowSameNetworkUnicast.SameNetworkUnicastAllowed"/>
                /// .
                /// </summary>
                public const string SameNetworkUnicastAllowed = "SAME_NETWORK_UNICAST_ALLOWED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.AllowSameNetworkUnicast.SameNetworkUnicastBlocked"/>
                /// .
                /// </summary>
                public const string SameNetworkUnicastBlocked = "SAME_NETWORK_UNICAST_BLOCKED";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.AllowStaticRoutes"/>
            /// enum.
            /// </summary>
            public static class AllowStaticRoutes
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.AllowStaticRoutes.UndefinedAllowStaticRoutes"/>
                /// .
                /// </summary>
                public const string UndefinedAllowStaticRoutes = "UNDEFINED_ALLOW_STATIC_ROUTES";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.AllowStaticRoutes.StaticRoutesAllowed"/>
                /// .
                /// </summary>
                public const string StaticRoutesAllowed = "STATIC_ROUTES_ALLOWED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.AllowStaticRoutes.StaticRoutesBlocked"/>
                /// .
                /// </summary>
                public const string StaticRoutesBlocked = "STATIC_ROUTES_BLOCKED";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.AllowSubInterfaces"/>
            /// enum.
            /// </summary>
            public static class AllowSubInterfaces
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.AllowSubInterfaces.UndefinedAllowSubInterfaces"/>
                /// .
                /// </summary>
                public const string UndefinedAllowSubInterfaces = "UNDEFINED_ALLOW_SUB_INTERFACES";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.AllowSubInterfaces.SubinterfacesAllowed"/>
                /// .
                /// </summary>
                public const string SubinterfacesAllowed = "SUBINTERFACES_ALLOWED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.AllowSubInterfaces.SubinterfacesBlocked"/>
                /// .
                /// </summary>
                public const string SubinterfacesBlocked = "SUBINTERFACES_BLOCKED";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.AllowVpcPeering"/> enum.
            /// </summary>
            public static class AllowVpcPeering
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.AllowVpcPeering.UndefinedAllowVpcPeering"/>
                /// .
                /// </summary>
                public const string UndefinedAllowVpcPeering = "UNDEFINED_ALLOW_VPC_PEERING";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.AllowVpcPeering.VpcPeeringAllowed"/>
                /// .
                /// </summary>
                public const string VpcPeeringAllowed = "VPC_PEERING_ALLOWED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.AllowVpcPeering.VpcPeeringBlocked"/>
                /// .
                /// </summary>
                public const string VpcPeeringBlocked = "VPC_PEERING_BLOCKED";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.AllowVpn"/> enum.
            /// </summary>
            public static class AllowVpn
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.AllowVpn.UndefinedAllowVpn"/>
                /// .
                /// </summary>
                public const string UndefinedAllowVpn = "UNDEFINED_ALLOW_VPN";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.AllowVpn.VpnAllowed"/>
                /// .
                /// </summary>
                public const string VpnAllowed = "VPN_ALLOWED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.AllowVpn.VpnBlocked"/>
                /// .
                /// </summary>
                public const string VpnBlocked = "VPN_BLOCKED";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.InterfaceTypes"/> enum.
            /// </summary>
            public static class InterfaceTypes
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.InterfaceTypes.UndefinedInterfaceTypes"/>
                /// .
                /// </summary>
                public const string UndefinedInterfaceTypes = "UNDEFINED_INTERFACE_TYPES";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.InterfaceTypes.Gvnic"/>
                /// .
                /// </summary>
                public const string Gvnic = "GVNIC";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.InterfaceTypes.Idpf"/>
                /// .
                /// </summary>
                public const string Idpf = "IDPF";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.InterfaceTypes.Irdma"/>
                /// .
                /// </summary>
                public const string Irdma = "IRDMA";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.InterfaceTypes.Mrdma"/>
                /// .
                /// </summary>
                public const string Mrdma = "MRDMA";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.InterfaceTypes.UnspecifiedNicType"/>
                /// .
                /// </summary>
                public const string UnspecifiedNicType = "UNSPECIFIED_NIC_TYPE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.InterfaceTypes.VirtioNet"/>
                /// .
                /// </summary>
                public const string VirtioNet = "VIRTIO_NET";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.SubnetPurposes"/> enum.
            /// </summary>
            public static class SubnetPurposes
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.SubnetPurposes.UndefinedSubnetPurposes"/>
                /// .
                /// </summary>
                public const string UndefinedSubnetPurposes = "UNDEFINED_SUBNET_PURPOSES";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.SubnetPurposes.SubnetPurposeCustomHardware"/>
                /// .
                /// </summary>
                public const string SubnetPurposeCustomHardware = "SUBNET_PURPOSE_CUSTOM_HARDWARE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.SubnetPurposes.SubnetPurposePrivate"/>
                /// .
                /// </summary>
                public const string SubnetPurposePrivate = "SUBNET_PURPOSE_PRIVATE";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.SubnetStackTypes"/> enum.
            /// </summary>
            public static class SubnetStackTypes
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.SubnetStackTypes.UndefinedSubnetStackTypes"/>
                /// .
                /// </summary>
                public const string UndefinedSubnetStackTypes = "UNDEFINED_SUBNET_STACK_TYPES";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.SubnetStackTypes.SubnetStackTypeIpv4Ipv6"/>
                /// .
                /// </summary>
                public const string SubnetStackTypeIpv4Ipv6 = "SUBNET_STACK_TYPE_IPV4_IPV6";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.SubnetStackTypes.SubnetStackTypeIpv4Only"/>
                /// .
                /// </summary>
                public const string SubnetStackTypeIpv4Only = "SUBNET_STACK_TYPE_IPV4_ONLY";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.SubnetStackTypes.SubnetStackTypeIpv6Only"/>
                /// .
                /// </summary>
                public const string SubnetStackTypeIpv6Only = "SUBNET_STACK_TYPE_IPV6_ONLY";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.SubnetworkPurposes"/>
            /// enum.
            /// </summary>
            public static class SubnetworkPurposes
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.SubnetworkPurposes.UndefinedSubnetworkPurposes"/>
                /// .
                /// </summary>
                public const string UndefinedSubnetworkPurposes = "UNDEFINED_SUBNETWORK_PURPOSES";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.SubnetworkPurposes.GlobalManagedProxy"/>
                /// .
                /// </summary>
                public const string GlobalManagedProxy = "GLOBAL_MANAGED_PROXY";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.SubnetworkPurposes.InternalHttpsLoadBalancer"/>
                /// .
                /// </summary>
                public const string InternalHttpsLoadBalancer = "INTERNAL_HTTPS_LOAD_BALANCER";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.SubnetworkPurposes.PeerMigration"/>
                /// .
                /// </summary>
                public const string PeerMigration = "PEER_MIGRATION";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.SubnetworkPurposes.Private"/>
                /// .
                /// </summary>
                public const string Private = "PRIVATE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.SubnetworkPurposes.PrivateNat"/>
                /// .
                /// </summary>
                public const string PrivateNat = "PRIVATE_NAT";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.SubnetworkPurposes.PrivateRfc1918"/>
                /// .
                /// </summary>
                public const string PrivateRfc1918 = "PRIVATE_RFC_1918";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.SubnetworkPurposes.RegionalManagedProxy"/>
                /// .
                /// </summary>
                public const string RegionalManagedProxy = "REGIONAL_MANAGED_PROXY";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.SubnetworkStackTypes"/>
            /// enum.
            /// </summary>
            public static class SubnetworkStackTypes
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.SubnetworkStackTypes.UndefinedSubnetworkStackTypes"/>
                /// .
                /// </summary>
                public const string UndefinedSubnetworkStackTypes = "UNDEFINED_SUBNETWORK_STACK_TYPES";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.SubnetworkStackTypes.Ipv4Ipv6"/>
                /// .
                /// </summary>
                public const string Ipv4Ipv6 = "IPV4_IPV6";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.SubnetworkStackTypes.Ipv4Only"/>
                /// .
                /// </summary>
                public const string Ipv4Only = "IPV4_ONLY";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.SubnetworkStackTypes.Ipv6Only"/>
                /// .
                /// </summary>
                public const string Ipv6Only = "IPV6_ONLY";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.Unicast"/> enum.
            /// </summary>
            public static class Unicast
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.Unicast.UndefinedUnicast"/>
                /// .
                /// </summary>
                public const string UndefinedUnicast = "UNDEFINED_UNICAST";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.Unicast.Sdn"/>.
                /// </summary>
                public const string Sdn = "UNICAST_SDN";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkProfileNetworkFeatures.Types.Unicast.Ull"/>.
                /// </summary>
                public const string Ull = "UNICAST_ULL";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.NetworkRoutingConfig"/>
        /// message.
        /// </summary>
        public static class NetworkRoutingConfig
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.NetworkRoutingConfig.Types.BgpBestPathSelectionMode"/> enum.
            /// </summary>
            public static class BgpBestPathSelectionMode
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkRoutingConfig.Types.BgpBestPathSelectionMode.UndefinedBgpBestPathSelectionMode"/>
                /// .
                /// </summary>
                public const string UndefinedBgpBestPathSelectionMode = "UNDEFINED_BGP_BEST_PATH_SELECTION_MODE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkRoutingConfig.Types.BgpBestPathSelectionMode.Legacy"/>
                /// .
                /// </summary>
                public const string Legacy = "LEGACY";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkRoutingConfig.Types.BgpBestPathSelectionMode.Standard"/>
                /// .
                /// </summary>
                public const string Standard = "STANDARD";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.NetworkRoutingConfig.Types.BgpInterRegionCost"/> enum.
            /// </summary>
            public static class BgpInterRegionCost
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkRoutingConfig.Types.BgpInterRegionCost.UndefinedBgpInterRegionCost"/>
                /// .
                /// </summary>
                public const string UndefinedBgpInterRegionCost = "UNDEFINED_BGP_INTER_REGION_COST";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkRoutingConfig.Types.BgpInterRegionCost.AddCostToMed"/>
                /// .
                /// </summary>
                public const string AddCostToMed = "ADD_COST_TO_MED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkRoutingConfig.Types.BgpInterRegionCost.Default"/>.
                /// </summary>
                public const string Default = "DEFAULT";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.NetworkRoutingConfig.Types.EffectiveBgpInterRegionCost"/>
            /// enum.
            /// </summary>
            public static class EffectiveBgpInterRegionCost
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkRoutingConfig.Types.EffectiveBgpInterRegionCost.UndefinedEffectiveBgpInterRegionCost"/>
                /// .
                /// </summary>
                public const string UndefinedEffectiveBgpInterRegionCost = "UNDEFINED_EFFECTIVE_BGP_INTER_REGION_COST";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.NetworkRoutingConfig.Types.RoutingMode"/> enum.
            /// </summary>
            public static class RoutingMode
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkRoutingConfig.Types.RoutingMode.UndefinedRoutingMode"/>
                /// .
                /// </summary>
                public const string UndefinedRoutingMode = "UNDEFINED_ROUTING_MODE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkRoutingConfig.Types.RoutingMode.Global"/>.
                /// </summary>
                public const string Global = "GLOBAL";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworkRoutingConfig.Types.RoutingMode.Regional"/>.
                /// </summary>
                public const string Regional = "REGIONAL";
            }
        }

        /// <summary>
        /// Container class for enums within the
        /// <see cref="global::Google.Cloud.Compute.V1.NetworksGetEffectiveFirewallsResponseEffectiveFirewallPolicy"/>
        /// message.
        /// </summary>
        public static class NetworksGetEffectiveFirewallsResponseEffectiveFirewallPolicy
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.NetworksGetEffectiveFirewallsResponseEffectiveFirewallPolicy.Types.Type"/>
            ///  enum.
            /// </summary>
            public static class Type
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworksGetEffectiveFirewallsResponseEffectiveFirewallPolicy.Types.Type.UndefinedType"/>
                /// .
                /// </summary>
                public const string UndefinedType = "UNDEFINED_TYPE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworksGetEffectiveFirewallsResponseEffectiveFirewallPolicy.Types.Type.Hierarchy"/>
                /// .
                /// </summary>
                public const string Hierarchy = "HIERARCHY";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworksGetEffectiveFirewallsResponseEffectiveFirewallPolicy.Types.Type.Network"/>
                /// .
                /// </summary>
                public const string Network = "NETWORK";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworksGetEffectiveFirewallsResponseEffectiveFirewallPolicy.Types.Type.System"/>
                /// .
                /// </summary>
                public const string System = "SYSTEM";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NetworksGetEffectiveFirewallsResponseEffectiveFirewallPolicy.Types.Type.Unspecified"/>
                /// .
                /// </summary>
                public const string Unspecified = "UNSPECIFIED";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.NodeGroup"/> message.
        /// </summary>
        public static class NodeGroup
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.NodeGroup.Types.MaintenanceInterval"/> enum.
            /// </summary>
            public static class MaintenanceInterval
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NodeGroup.Types.MaintenanceInterval.UndefinedMaintenanceInterval"/>
                /// .
                /// </summary>
                public const string UndefinedMaintenanceInterval = "UNDEFINED_MAINTENANCE_INTERVAL";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NodeGroup.Types.MaintenanceInterval.AsNeeded"/>.
                /// </summary>
                public const string AsNeeded = "AS_NEEDED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NodeGroup.Types.MaintenanceInterval.Recurrent"/>.
                /// </summary>
                public const string Recurrent = "RECURRENT";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.NodeGroup.Types.MaintenancePolicy"/> enum.
            /// </summary>
            public static class MaintenancePolicy
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NodeGroup.Types.MaintenancePolicy.UndefinedMaintenancePolicy"/>
                /// .
                /// </summary>
                public const string UndefinedMaintenancePolicy = "UNDEFINED_MAINTENANCE_POLICY";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NodeGroup.Types.MaintenancePolicy.Default"/>.
                /// </summary>
                public const string Default = "DEFAULT";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NodeGroup.Types.MaintenancePolicy.Unspecified"/>.
                /// </summary>
                public const string Unspecified = "MAINTENANCE_POLICY_UNSPECIFIED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NodeGroup.Types.MaintenancePolicy.MigrateWithinNodeGroup"/>
                /// .
                /// </summary>
                public const string MigrateWithinNodeGroup = "MIGRATE_WITHIN_NODE_GROUP";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NodeGroup.Types.MaintenancePolicy.RestartInPlace"/>.
                /// </summary>
                public const string RestartInPlace = "RESTART_IN_PLACE";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.NodeGroup.Types.Status"/> enum.
            /// </summary>
            public static class Status
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NodeGroup.Types.Status.UndefinedStatus"/>.
                /// </summary>
                public const string UndefinedStatus = "UNDEFINED_STATUS";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.NodeGroup.Types.Status.Creating"/>
                /// .
                /// </summary>
                public const string Creating = "CREATING";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.NodeGroup.Types.Status.Deleting"/>
                /// .
                /// </summary>
                public const string Deleting = "DELETING";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.NodeGroup.Types.Status.Invalid"/>.
                /// </summary>
                public const string Invalid = "INVALID";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.NodeGroup.Types.Status.Ready"/>.
                /// </summary>
                public const string Ready = "READY";
            }
        }

        /// <summary>
        /// Container class for enums within the
        /// <see cref="global::Google.Cloud.Compute.V1.NodeGroupAutoscalingPolicy"/> message.
        /// </summary>
        public static class NodeGroupAutoscalingPolicy
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.NodeGroupAutoscalingPolicy.Types.Mode"/> enum.
            /// </summary>
            public static class Mode
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NodeGroupAutoscalingPolicy.Types.Mode.UndefinedMode"/>.
                /// </summary>
                public const string UndefinedMode = "UNDEFINED_MODE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NodeGroupAutoscalingPolicy.Types.Mode.Unspecified"/>.
                /// </summary>
                public const string Unspecified = "MODE_UNSPECIFIED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NodeGroupAutoscalingPolicy.Types.Mode.Off"/>.
                /// </summary>
                public const string Off = "OFF";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NodeGroupAutoscalingPolicy.Types.Mode.On"/>.
                /// </summary>
                public const string On = "ON";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NodeGroupAutoscalingPolicy.Types.Mode.OnlyScaleOut"/>.
                /// </summary>
                public const string OnlyScaleOut = "ONLY_SCALE_OUT";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.NodeGroupNode"/> message.
        /// </summary>
        public static class NodeGroupNode
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.NodeGroupNode.Types.CpuOvercommitType"/> enum.
            /// </summary>
            public static class CpuOvercommitType
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NodeGroupNode.Types.CpuOvercommitType.UndefinedCpuOvercommitType"/>
                /// .
                /// </summary>
                public const string UndefinedCpuOvercommitType = "UNDEFINED_CPU_OVERCOMMIT_TYPE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NodeGroupNode.Types.CpuOvercommitType.Unspecified"/>.
                /// </summary>
                public const string Unspecified = "CPU_OVERCOMMIT_TYPE_UNSPECIFIED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NodeGroupNode.Types.CpuOvercommitType.Enabled"/>.
                /// </summary>
                public const string Enabled = "ENABLED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NodeGroupNode.Types.CpuOvercommitType.None"/>.
                /// </summary>
                public const string None = "NONE";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.NodeGroupNode.Types.Status"/> enum.
            /// </summary>
            public static class Status
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NodeGroupNode.Types.Status.UndefinedStatus"/>.
                /// </summary>
                public const string UndefinedStatus = "UNDEFINED_STATUS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NodeGroupNode.Types.Status.Creating"/>.
                /// </summary>
                public const string Creating = "CREATING";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NodeGroupNode.Types.Status.Deleting"/>.
                /// </summary>
                public const string Deleting = "DELETING";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NodeGroupNode.Types.Status.Invalid"/>.
                /// </summary>
                public const string Invalid = "INVALID";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NodeGroupNode.Types.Status.Ready"/>.
                /// </summary>
                public const string Ready = "READY";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NodeGroupNode.Types.Status.Repairing"/>.
                /// </summary>
                public const string Repairing = "REPAIRING";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.NodeTemplate"/> message.
        /// </summary>
        public static class NodeTemplate
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.NodeTemplate.Types.CpuOvercommitType"/> enum.
            /// </summary>
            public static class CpuOvercommitType
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NodeTemplate.Types.CpuOvercommitType.UndefinedCpuOvercommitType"/>
                /// .
                /// </summary>
                public const string UndefinedCpuOvercommitType = "UNDEFINED_CPU_OVERCOMMIT_TYPE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NodeTemplate.Types.CpuOvercommitType.Unspecified"/>.
                /// </summary>
                public const string Unspecified = "CPU_OVERCOMMIT_TYPE_UNSPECIFIED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NodeTemplate.Types.CpuOvercommitType.Enabled"/>.
                /// </summary>
                public const string Enabled = "ENABLED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NodeTemplate.Types.CpuOvercommitType.None"/>.
                /// </summary>
                public const string None = "NONE";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.NodeTemplate.Types.Status"/> enum.
            /// </summary>
            public static class Status
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NodeTemplate.Types.Status.UndefinedStatus"/>.
                /// </summary>
                public const string UndefinedStatus = "UNDEFINED_STATUS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NodeTemplate.Types.Status.Creating"/>.
                /// </summary>
                public const string Creating = "CREATING";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NodeTemplate.Types.Status.Deleting"/>.
                /// </summary>
                public const string Deleting = "DELETING";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.NodeTemplate.Types.Status.Invalid"/>.
                /// </summary>
                public const string Invalid = "INVALID";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.NodeTemplate.Types.Status.Ready"/>
                /// .
                /// </summary>
                public const string Ready = "READY";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.Operation"/> message.
        /// </summary>
        public static class Operation
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.Operation.Types.Status"/> enum.
            /// </summary>
            public static class Status
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Operation.Types.Status.UndefinedStatus"/>.
                /// </summary>
                public const string UndefinedStatus = "UNDEFINED_STATUS";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.Operation.Types.Status.Done"/>.
                /// </summary>
                public const string Done = "DONE";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.Operation.Types.Status.Pending"/>.
                /// </summary>
                public const string Pending = "PENDING";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.Operation.Types.Status.Running"/>.
                /// </summary>
                public const string Running = "RUNNING";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.PacketIntervals"/> message.
        /// </summary>
        public static class PacketIntervals
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.PacketIntervals.Types.Duration"/> enum.
            /// </summary>
            public static class Duration
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.PacketIntervals.Types.Duration.UndefinedDuration"/>.
                /// </summary>
                public const string UndefinedDuration = "UNDEFINED_DURATION";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.PacketIntervals.Types.Duration.Unspecified"/>.
                /// </summary>
                public const string Unspecified = "DURATION_UNSPECIFIED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.PacketIntervals.Types.Duration.Hour"/>.
                /// </summary>
                public const string Hour = "HOUR";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.PacketIntervals.Types.Duration.Max"/>.
                /// </summary>
                public const string Max = "MAX";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.PacketIntervals.Types.Duration.Minute"/>.
                /// </summary>
                public const string Minute = "MINUTE";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.PacketIntervals.Types.Type"/> enum.
            /// </summary>
            public static class Type
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.PacketIntervals.Types.Type.UndefinedType"/>.
                /// </summary>
                public const string UndefinedType = "UNDEFINED_TYPE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.PacketIntervals.Types.Type.Loopback"/>.
                /// </summary>
                public const string Loopback = "LOOPBACK";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.PacketIntervals.Types.Type.Receive"/>.
                /// </summary>
                public const string Receive = "RECEIVE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.PacketIntervals.Types.Type.Transmit"/>.
                /// </summary>
                public const string Transmit = "TRANSMIT";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.PacketIntervals.Types.Type.Unspecified"/>.
                /// </summary>
                public const string Unspecified = "TYPE_UNSPECIFIED";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.PacketMirroring"/> message.
        /// </summary>
        public static class PacketMirroring
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.PacketMirroring.Types.Enable"/> enum.
            /// </summary>
            public static class Enable
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.PacketMirroring.Types.Enable.UndefinedEnable"/>.
                /// </summary>
                public const string UndefinedEnable = "UNDEFINED_ENABLE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.PacketMirroring.Types.Enable.False"/>.
                /// </summary>
                public const string False = "FALSE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.PacketMirroring.Types.Enable.True"/>.
                /// </summary>
                public const string True = "TRUE";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.PacketMirroringFilter"/>
        /// message.
        /// </summary>
        public static class PacketMirroringFilter
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.PacketMirroringFilter.Types.Direction"/> enum.
            /// </summary>
            public static class Direction
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.PacketMirroringFilter.Types.Direction.UndefinedDirection"/>
                /// .
                /// </summary>
                public const string UndefinedDirection = "UNDEFINED_DIRECTION";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.PacketMirroringFilter.Types.Direction.Both"/>.
                /// </summary>
                public const string Both = "BOTH";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.PacketMirroringFilter.Types.Direction.Egress"/>.
                /// </summary>
                public const string Egress = "EGRESS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.PacketMirroringFilter.Types.Direction.Ingress"/>.
                /// </summary>
                public const string Ingress = "INGRESS";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.PerInstanceConfig"/>
        /// message.
        /// </summary>
        public static class PerInstanceConfig
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.PerInstanceConfig.Types.Status"/> enum.
            /// </summary>
            public static class Status
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.PerInstanceConfig.Types.Status.UndefinedStatus"/>.
                /// </summary>
                public const string UndefinedStatus = "UNDEFINED_STATUS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.PerInstanceConfig.Types.Status.Applying"/>.
                /// </summary>
                public const string Applying = "APPLYING";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.PerInstanceConfig.Types.Status.Deleting"/>.
                /// </summary>
                public const string Deleting = "DELETING";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.PerInstanceConfig.Types.Status.Effective"/>.
                /// </summary>
                public const string Effective = "EFFECTIVE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.PerInstanceConfig.Types.Status.None"/>.
                /// </summary>
                public const string None = "NONE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.PerInstanceConfig.Types.Status.Unapplied"/>.
                /// </summary>
                public const string Unapplied = "UNAPPLIED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.PerInstanceConfig.Types.Status.UnappliedDeletion"/>.
                /// </summary>
                public const string UnappliedDeletion = "UNAPPLIED_DELETION";
            }
        }

        /// <summary>
        /// Container class for enums within the
        /// <see cref="global::Google.Cloud.Compute.V1.PreservedStatePreservedDisk"/> message.
        /// </summary>
        public static class PreservedStatePreservedDisk
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.PreservedStatePreservedDisk.Types.AutoDelete"/> enum.
            /// </summary>
            public static class AutoDelete
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.PreservedStatePreservedDisk.Types.AutoDelete.UndefinedAutoDelete"/>
                /// .
                /// </summary>
                public const string UndefinedAutoDelete = "UNDEFINED_AUTO_DELETE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.PreservedStatePreservedDisk.Types.AutoDelete.Never"/>.
                /// </summary>
                public const string Never = "NEVER";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.PreservedStatePreservedDisk.Types.AutoDelete.OnPermanentInstanceDeletion"/>
                /// .
                /// </summary>
                public const string OnPermanentInstanceDeletion = "ON_PERMANENT_INSTANCE_DELETION";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.PreservedStatePreservedDisk.Types.Mode"/> enum.
            /// </summary>
            public static class Mode
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.PreservedStatePreservedDisk.Types.Mode.UndefinedMode"/>.
                /// </summary>
                public const string UndefinedMode = "UNDEFINED_MODE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.PreservedStatePreservedDisk.Types.Mode.ReadOnly"/>.
                /// </summary>
                public const string ReadOnly = "READ_ONLY";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.PreservedStatePreservedDisk.Types.Mode.ReadWrite"/>.
                /// </summary>
                public const string ReadWrite = "READ_WRITE";
            }
        }

        /// <summary>
        /// Container class for enums within the
        /// <see cref="global::Google.Cloud.Compute.V1.PreservedStatePreservedNetworkIp"/> message.
        /// </summary>
        public static class PreservedStatePreservedNetworkIp
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.PreservedStatePreservedNetworkIp.Types.AutoDelete"/> enum.
            /// </summary>
            public static class AutoDelete
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.PreservedStatePreservedNetworkIp.Types.AutoDelete.UndefinedAutoDelete"/>
                /// .
                /// </summary>
                public const string UndefinedAutoDelete = "UNDEFINED_AUTO_DELETE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.PreservedStatePreservedNetworkIp.Types.AutoDelete.Never"/>
                /// .
                /// </summary>
                public const string Never = "NEVER";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.PreservedStatePreservedNetworkIp.Types.AutoDelete.OnPermanentInstanceDeletion"/>
                /// .
                /// </summary>
                public const string OnPermanentInstanceDeletion = "ON_PERMANENT_INSTANCE_DELETION";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.Project"/> message.
        /// </summary>
        public static class Project
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.Project.Types.CloudArmorTier"/> enum.
            /// </summary>
            public static class CloudArmorTier
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Project.Types.CloudArmorTier.UndefinedCloudArmorTier"/>.
                /// </summary>
                public const string UndefinedCloudArmorTier = "UNDEFINED_CLOUD_ARMOR_TIER";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Project.Types.CloudArmorTier.CaEnterpriseAnnual"/>.
                /// </summary>
                public const string CaEnterpriseAnnual = "CA_ENTERPRISE_ANNUAL";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Project.Types.CloudArmorTier.CaEnterprisePaygo"/>.
                /// </summary>
                public const string CaEnterprisePaygo = "CA_ENTERPRISE_PAYGO";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Project.Types.CloudArmorTier.CaStandard"/>.
                /// </summary>
                public const string CaStandard = "CA_STANDARD";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.Project.Types.DefaultNetworkTier"/> enum.
            /// </summary>
            public static class DefaultNetworkTier
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Project.Types.DefaultNetworkTier.UndefinedDefaultNetworkTier"/>
                /// .
                /// </summary>
                public const string UndefinedDefaultNetworkTier = "UNDEFINED_DEFAULT_NETWORK_TIER";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Project.Types.DefaultNetworkTier.FixedStandard"/>.
                /// </summary>
                public const string FixedStandard = "FIXED_STANDARD";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Project.Types.DefaultNetworkTier.Premium"/>.
                /// </summary>
                public const string Premium = "PREMIUM";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Project.Types.DefaultNetworkTier.Standard"/>.
                /// </summary>
                public const string Standard = "STANDARD";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Project.Types.DefaultNetworkTier.StandardOverridesFixedStandard"/>
                /// .
                /// </summary>
                public const string StandardOverridesFixedStandard = "STANDARD_OVERRIDES_FIXED_STANDARD";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.Project.Types.VmDnsSetting"/> enum.
            /// </summary>
            public static class VmDnsSetting
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Project.Types.VmDnsSetting.UndefinedVmDnsSetting"/>.
                /// </summary>
                public const string UndefinedVmDnsSetting = "UNDEFINED_VM_DNS_SETTING";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Project.Types.VmDnsSetting.GlobalDefault"/>.
                /// </summary>
                public const string GlobalDefault = "GLOBAL_DEFAULT";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Project.Types.VmDnsSetting.UnspecifiedVmDnsSetting"/>.
                /// </summary>
                public const string UnspecifiedVmDnsSetting = "UNSPECIFIED_VM_DNS_SETTING";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Project.Types.VmDnsSetting.ZonalDefault"/>.
                /// </summary>
                public const string ZonalDefault = "ZONAL_DEFAULT";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Project.Types.VmDnsSetting.ZonalOnly"/>.
                /// </summary>
                public const string ZonalOnly = "ZONAL_ONLY";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.Project.Types.XpnProjectStatus"/> enum.
            /// </summary>
            public static class XpnProjectStatus
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Project.Types.XpnProjectStatus.UndefinedXpnProjectStatus"/>
                /// .
                /// </summary>
                public const string UndefinedXpnProjectStatus = "UNDEFINED_XPN_PROJECT_STATUS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Project.Types.XpnProjectStatus.Host"/>.
                /// </summary>
                public const string Host = "HOST";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Project.Types.XpnProjectStatus.UnspecifiedXpnProjectStatus"/>
                /// .
                /// </summary>
                public const string UnspecifiedXpnProjectStatus = "UNSPECIFIED_XPN_PROJECT_STATUS";
            }
        }

        /// <summary>
        /// Container class for enums within the
        /// <see cref="global::Google.Cloud.Compute.V1.ProjectsSetCloudArmorTierRequest"/> message.
        /// </summary>
        public static class ProjectsSetCloudArmorTierRequest
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.ProjectsSetCloudArmorTierRequest.Types.CloudArmorTier"/>
            /// enum.
            /// </summary>
            public static class CloudArmorTier
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ProjectsSetCloudArmorTierRequest.Types.CloudArmorTier.UndefinedCloudArmorTier"/>
                /// .
                /// </summary>
                public const string UndefinedCloudArmorTier = "UNDEFINED_CLOUD_ARMOR_TIER";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ProjectsSetCloudArmorTierRequest.Types.CloudArmorTier.CaEnterpriseAnnual"/>
                /// .
                /// </summary>
                public const string CaEnterpriseAnnual = "CA_ENTERPRISE_ANNUAL";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ProjectsSetCloudArmorTierRequest.Types.CloudArmorTier.CaEnterprisePaygo"/>
                /// .
                /// </summary>
                public const string CaEnterprisePaygo = "CA_ENTERPRISE_PAYGO";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ProjectsSetCloudArmorTierRequest.Types.CloudArmorTier.CaStandard"/>
                /// .
                /// </summary>
                public const string CaStandard = "CA_STANDARD";
            }
        }

        /// <summary>
        /// Container class for enums within the
        /// <see cref="global::Google.Cloud.Compute.V1.ProjectsSetDefaultNetworkTierRequest"/> message.
        /// </summary>
        public static class ProjectsSetDefaultNetworkTierRequest
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.ProjectsSetDefaultNetworkTierRequest.Types.NetworkTier"/>
            /// enum.
            /// </summary>
            public static class NetworkTier
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ProjectsSetDefaultNetworkTierRequest.Types.NetworkTier.UndefinedNetworkTier"/>
                /// .
                /// </summary>
                public const string UndefinedNetworkTier = "UNDEFINED_NETWORK_TIER";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ProjectsSetDefaultNetworkTierRequest.Types.NetworkTier.FixedStandard"/>
                /// .
                /// </summary>
                public const string FixedStandard = "FIXED_STANDARD";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ProjectsSetDefaultNetworkTierRequest.Types.NetworkTier.Premium"/>
                /// .
                /// </summary>
                public const string Premium = "PREMIUM";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ProjectsSetDefaultNetworkTierRequest.Types.NetworkTier.Standard"/>
                /// .
                /// </summary>
                public const string Standard = "STANDARD";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ProjectsSetDefaultNetworkTierRequest.Types.NetworkTier.StandardOverridesFixedStandard"/>
                /// .
                /// </summary>
                public const string StandardOverridesFixedStandard = "STANDARD_OVERRIDES_FIXED_STANDARD";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.PublicAdvertisedPrefix"/>
        /// message.
        /// </summary>
        public static class PublicAdvertisedPrefix
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.PublicAdvertisedPrefix.Types.ByoipApiVersion"/> enum.
            /// </summary>
            public static class ByoipApiVersion
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.PublicAdvertisedPrefix.Types.ByoipApiVersion.UndefinedByoipApiVersion"/>
                /// .
                /// </summary>
                public const string UndefinedByoipApiVersion = "UNDEFINED_BYOIP_API_VERSION";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.PublicAdvertisedPrefix.Types.ByoipApiVersion.V1"/>.
                /// </summary>
                public const string V1 = "V1";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.PublicAdvertisedPrefix.Types.ByoipApiVersion.V2"/>.
                /// </summary>
                public const string V2 = "V2";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.PublicAdvertisedPrefix.Types.PdpScope"/> enum.
            /// </summary>
            public static class PdpScope
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.PublicAdvertisedPrefix.Types.PdpScope.UndefinedPdpScope"/>
                /// .
                /// </summary>
                public const string UndefinedPdpScope = "UNDEFINED_PDP_SCOPE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.PublicAdvertisedPrefix.Types.PdpScope.Global"/>.
                /// </summary>
                public const string Global = "GLOBAL";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.PublicAdvertisedPrefix.Types.PdpScope.GlobalAndRegional"/>
                /// .
                /// </summary>
                public const string GlobalAndRegional = "GLOBAL_AND_REGIONAL";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.PublicAdvertisedPrefix.Types.PdpScope.Regional"/>.
                /// </summary>
                public const string Regional = "REGIONAL";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.PublicAdvertisedPrefix.Types.Status"/> enum.
            /// </summary>
            public static class Status
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.PublicAdvertisedPrefix.Types.Status.UndefinedStatus"/>.
                /// </summary>
                public const string UndefinedStatus = "UNDEFINED_STATUS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.PublicAdvertisedPrefix.Types.Status.AnnouncedToInternet"/>
                /// .
                /// </summary>
                public const string AnnouncedToInternet = "ANNOUNCED_TO_INTERNET";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.PublicAdvertisedPrefix.Types.Status.Initial"/>.
                /// </summary>
                public const string Initial = "INITIAL";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.PublicAdvertisedPrefix.Types.Status.PrefixConfigurationComplete"/>
                /// .
                /// </summary>
                public const string PrefixConfigurationComplete = "PREFIX_CONFIGURATION_COMPLETE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.PublicAdvertisedPrefix.Types.Status.PrefixConfigurationInProgress"/>
                /// .
                /// </summary>
                public const string PrefixConfigurationInProgress = "PREFIX_CONFIGURATION_IN_PROGRESS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.PublicAdvertisedPrefix.Types.Status.PrefixRemovalInProgress"/>
                /// .
                /// </summary>
                public const string PrefixRemovalInProgress = "PREFIX_REMOVAL_IN_PROGRESS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.PublicAdvertisedPrefix.Types.Status.PtrConfigured"/>.
                /// </summary>
                public const string PtrConfigured = "PTR_CONFIGURED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.PublicAdvertisedPrefix.Types.Status.ReadyToAnnounce"/>.
                /// </summary>
                public const string ReadyToAnnounce = "READY_TO_ANNOUNCE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.PublicAdvertisedPrefix.Types.Status.ReverseDnsLookupFailed"/>
                /// .
                /// </summary>
                public const string ReverseDnsLookupFailed = "REVERSE_DNS_LOOKUP_FAILED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.PublicAdvertisedPrefix.Types.Status.Validated"/>.
                /// </summary>
                public const string Validated = "VALIDATED";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.PublicDelegatedPrefix"/>
        /// message.
        /// </summary>
        public static class PublicDelegatedPrefix
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.PublicDelegatedPrefix.Types.ByoipApiVersion"/> enum.
            /// </summary>
            public static class ByoipApiVersion
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.PublicDelegatedPrefix.Types.ByoipApiVersion.UndefinedByoipApiVersion"/>
                /// .
                /// </summary>
                public const string UndefinedByoipApiVersion = "UNDEFINED_BYOIP_API_VERSION";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.PublicDelegatedPrefix.Types.ByoipApiVersion.V1"/>.
                /// </summary>
                public const string V1 = "V1";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.PublicDelegatedPrefix.Types.ByoipApiVersion.V2"/>.
                /// </summary>
                public const string V2 = "V2";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.PublicDelegatedPrefix.Types.Mode"/> enum.
            /// </summary>
            public static class Mode
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.PublicDelegatedPrefix.Types.Mode.UndefinedMode"/>.
                /// </summary>
                public const string UndefinedMode = "UNDEFINED_MODE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.PublicDelegatedPrefix.Types.Mode.Delegation"/>.
                /// </summary>
                public const string Delegation = "DELEGATION";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.PublicDelegatedPrefix.Types.Mode.ExternalIpv6ForwardingRuleCreation"/>
                /// .
                /// </summary>
                public const string ExternalIpv6ForwardingRuleCreation = "EXTERNAL_IPV6_FORWARDING_RULE_CREATION";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.PublicDelegatedPrefix.Types.Mode.ExternalIpv6SubnetworkCreation"/>
                /// .
                /// </summary>
                public const string ExternalIpv6SubnetworkCreation = "EXTERNAL_IPV6_SUBNETWORK_CREATION";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.PublicDelegatedPrefix.Types.Status"/> enum.
            /// </summary>
            public static class Status
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.PublicDelegatedPrefix.Types.Status.UndefinedStatus"/>.
                /// </summary>
                public const string UndefinedStatus = "UNDEFINED_STATUS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.PublicDelegatedPrefix.Types.Status.Announced"/>.
                /// </summary>
                public const string Announced = "ANNOUNCED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.PublicDelegatedPrefix.Types.Status.AnnouncedToGoogle"/>.
                /// </summary>
                public const string AnnouncedToGoogle = "ANNOUNCED_TO_GOOGLE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.PublicDelegatedPrefix.Types.Status.AnnouncedToInternet"/>
                /// .
                /// </summary>
                public const string AnnouncedToInternet = "ANNOUNCED_TO_INTERNET";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.PublicDelegatedPrefix.Types.Status.Deleting"/>.
                /// </summary>
                public const string Deleting = "DELETING";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.PublicDelegatedPrefix.Types.Status.Initializing"/>.
                /// </summary>
                public const string Initializing = "INITIALIZING";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.PublicDelegatedPrefix.Types.Status.ReadyToAnnounce"/>.
                /// </summary>
                public const string ReadyToAnnounce = "READY_TO_ANNOUNCE";
            }
        }

        /// <summary>
        /// Container class for enums within the
        /// <see cref="global::Google.Cloud.Compute.V1.PublicDelegatedPrefixPublicDelegatedSubPrefix"/> message.
        /// </summary>
        public static class PublicDelegatedPrefixPublicDelegatedSubPrefix
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.PublicDelegatedPrefixPublicDelegatedSubPrefix.Types.Mode"/>
            /// enum.
            /// </summary>
            public static class Mode
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.PublicDelegatedPrefixPublicDelegatedSubPrefix.Types.Mode.UndefinedMode"/>
                /// .
                /// </summary>
                public const string UndefinedMode = "UNDEFINED_MODE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.PublicDelegatedPrefixPublicDelegatedSubPrefix.Types.Mode.Delegation"/>
                /// .
                /// </summary>
                public const string Delegation = "DELEGATION";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.PublicDelegatedPrefixPublicDelegatedSubPrefix.Types.Mode.ExternalIpv6ForwardingRuleCreation"/>
                /// .
                /// </summary>
                public const string ExternalIpv6ForwardingRuleCreation = "EXTERNAL_IPV6_FORWARDING_RULE_CREATION";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.PublicDelegatedPrefixPublicDelegatedSubPrefix.Types.Mode.ExternalIpv6SubnetworkCreation"/>
                /// .
                /// </summary>
                public const string ExternalIpv6SubnetworkCreation = "EXTERNAL_IPV6_SUBNETWORK_CREATION";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.PublicDelegatedPrefixPublicDelegatedSubPrefix.Types.Status"/>
            /// enum.
            /// </summary>
            public static class Status
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.PublicDelegatedPrefixPublicDelegatedSubPrefix.Types.Status.UndefinedStatus"/>
                /// .
                /// </summary>
                public const string UndefinedStatus = "UNDEFINED_STATUS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.PublicDelegatedPrefixPublicDelegatedSubPrefix.Types.Status.Active"/>
                /// .
                /// </summary>
                public const string Active = "ACTIVE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.PublicDelegatedPrefixPublicDelegatedSubPrefix.Types.Status.Inactive"/>
                /// .
                /// </summary>
                public const string Inactive = "INACTIVE";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.Quota"/> message.
        /// </summary>
        public static class Quota
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric"/> enum.
            /// </summary>
            public static class Metric
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.UndefinedMetric"/>.
                /// </summary>
                public const string UndefinedMetric = "UNDEFINED_METRIC";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.A2Cpus"/>.
                /// </summary>
                public const string A2Cpus = "A2_CPUS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.AffinityGroups"/>.
                /// </summary>
                public const string AffinityGroups = "AFFINITY_GROUPS";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.Autoscalers"/>.
                /// </summary>
                public const string Autoscalers = "AUTOSCALERS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.BackendBuckets"/>.
                /// </summary>
                public const string BackendBuckets = "BACKEND_BUCKETS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.BackendServices"/>.
                /// </summary>
                public const string BackendServices = "BACKEND_SERVICES";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.C2DCpus"/>.
                /// </summary>
                public const string C2DCpus = "C2D_CPUS";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.C2Cpus"/>.
                /// </summary>
                public const string C2Cpus = "C2_CPUS";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.C3Cpus"/>.
                /// </summary>
                public const string C3Cpus = "C3_CPUS";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.Commitments"/>.
                /// </summary>
                public const string Commitments = "COMMITMENTS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.CommittedA2Cpus"/>.
                /// </summary>
                public const string CommittedA2Cpus = "COMMITTED_A2_CPUS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.CommittedC2DCpus"/>.
                /// </summary>
                public const string CommittedC2DCpus = "COMMITTED_C2D_CPUS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.CommittedC2Cpus"/>.
                /// </summary>
                public const string CommittedC2Cpus = "COMMITTED_C2_CPUS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.CommittedC3Cpus"/>.
                /// </summary>
                public const string CommittedC3Cpus = "COMMITTED_C3_CPUS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.CommittedCpus"/>.
                /// </summary>
                public const string CommittedCpus = "COMMITTED_CPUS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.CommittedE2Cpus"/>.
                /// </summary>
                public const string CommittedE2Cpus = "COMMITTED_E2_CPUS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.CommittedLicenses"/>.
                /// </summary>
                public const string CommittedLicenses = "COMMITTED_LICENSES";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.CommittedLocalSsdTotalGb"/>.
                /// </summary>
                public const string CommittedLocalSsdTotalGb = "COMMITTED_LOCAL_SSD_TOTAL_GB";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.CommittedM3Cpus"/>.
                /// </summary>
                public const string CommittedM3Cpus = "COMMITTED_M3_CPUS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.CommittedMemoryOptimizedCpus"/>.
                /// </summary>
                public const string CommittedMemoryOptimizedCpus = "COMMITTED_MEMORY_OPTIMIZED_CPUS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.CommittedN2ACpus"/>.
                /// </summary>
                public const string CommittedN2ACpus = "COMMITTED_N2A_CPUS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.CommittedN2DCpus"/>.
                /// </summary>
                public const string CommittedN2DCpus = "COMMITTED_N2D_CPUS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.CommittedN2Cpus"/>.
                /// </summary>
                public const string CommittedN2Cpus = "COMMITTED_N2_CPUS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.CommittedNvidiaA10080GbGpus"/>.
                /// </summary>
                public const string CommittedNvidiaA10080GbGpus = "COMMITTED_NVIDIA_A100_80GB_GPUS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.CommittedNvidiaA100Gpus"/>.
                /// </summary>
                public const string CommittedNvidiaA100Gpus = "COMMITTED_NVIDIA_A100_GPUS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.CommittedNvidiaH100Gpus"/>.
                /// </summary>
                public const string CommittedNvidiaH100Gpus = "COMMITTED_NVIDIA_H100_GPUS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.CommittedNvidiaK80Gpus"/>.
                /// </summary>
                public const string CommittedNvidiaK80Gpus = "COMMITTED_NVIDIA_K80_GPUS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.CommittedNvidiaL4Gpus"/>.
                /// </summary>
                public const string CommittedNvidiaL4Gpus = "COMMITTED_NVIDIA_L4_GPUS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.CommittedNvidiaP100Gpus"/>.
                /// </summary>
                public const string CommittedNvidiaP100Gpus = "COMMITTED_NVIDIA_P100_GPUS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.CommittedNvidiaP4Gpus"/>.
                /// </summary>
                public const string CommittedNvidiaP4Gpus = "COMMITTED_NVIDIA_P4_GPUS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.CommittedNvidiaT4Gpus"/>.
                /// </summary>
                public const string CommittedNvidiaT4Gpus = "COMMITTED_NVIDIA_T4_GPUS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.CommittedNvidiaV100Gpus"/>.
                /// </summary>
                public const string CommittedNvidiaV100Gpus = "COMMITTED_NVIDIA_V100_GPUS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.CommittedT2ACpus"/>.
                /// </summary>
                public const string CommittedT2ACpus = "COMMITTED_T2A_CPUS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.CommittedT2DCpus"/>.
                /// </summary>
                public const string CommittedT2DCpus = "COMMITTED_T2D_CPUS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.CommittedZ3Cpus"/>.
                /// </summary>
                public const string CommittedZ3Cpus = "COMMITTED_Z3_CPUS";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.Cpus"/>.
                /// </summary>
                public const string Cpus = "CPUS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.CpusAllRegions"/>.
                /// </summary>
                public const string CpusAllRegions = "CPUS_ALL_REGIONS";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.DisksTotalGb"/>
                /// .
                /// </summary>
                public const string DisksTotalGb = "DISKS_TOTAL_GB";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.E2Cpus"/>.
                /// </summary>
                public const string E2Cpus = "E2_CPUS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.ExternalManagedForwardingRules"/>.
                /// </summary>
                public const string ExternalManagedForwardingRules = "EXTERNAL_MANAGED_FORWARDING_RULES";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.ExternalNetworkLbForwardingRules"/>.
                /// </summary>
                public const string ExternalNetworkLbForwardingRules = "EXTERNAL_NETWORK_LB_FORWARDING_RULES";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.ExternalProtocolForwardingRules"/>.
                /// </summary>
                public const string ExternalProtocolForwardingRules = "EXTERNAL_PROTOCOL_FORWARDING_RULES";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.ExternalVpnGateways"/>.
                /// </summary>
                public const string ExternalVpnGateways = "EXTERNAL_VPN_GATEWAYS";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.Firewalls"/>.
                /// </summary>
                public const string Firewalls = "FIREWALLS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.ForwardingRules"/>.
                /// </summary>
                public const string ForwardingRules = "FORWARDING_RULES";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.GlobalExternalManagedBackendServices"/>
                /// .
                /// </summary>
                public const string GlobalExternalManagedBackendServices = "GLOBAL_EXTERNAL_MANAGED_BACKEND_SERVICES";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.GlobalExternalManagedForwardingRules"/>
                /// .
                /// </summary>
                public const string GlobalExternalManagedForwardingRules = "GLOBAL_EXTERNAL_MANAGED_FORWARDING_RULES";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.GlobalExternalProxyLbBackendServices"/>
                /// .
                /// </summary>
                public const string GlobalExternalProxyLbBackendServices = "GLOBAL_EXTERNAL_PROXY_LB_BACKEND_SERVICES";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.GlobalInternalAddresses"/>.
                /// </summary>
                public const string GlobalInternalAddresses = "GLOBAL_INTERNAL_ADDRESSES";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.GlobalInternalManagedBackendServices"/>
                /// .
                /// </summary>
                public const string GlobalInternalManagedBackendServices = "GLOBAL_INTERNAL_MANAGED_BACKEND_SERVICES";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.GlobalInternalTrafficDirectorBackendServices"/>
                /// .
                /// </summary>
                public const string GlobalInternalTrafficDirectorBackendServices = "GLOBAL_INTERNAL_TRAFFIC_DIRECTOR_BACKEND_SERVICES";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.GpusAllRegions"/>.
                /// </summary>
                public const string GpusAllRegions = "GPUS_ALL_REGIONS";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.HdbTotalGb"/>.
                /// </summary>
                public const string HdbTotalGb = "HDB_TOTAL_GB";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.HdbTotalIops"/>
                /// .
                /// </summary>
                public const string HdbTotalIops = "HDB_TOTAL_IOPS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.HdbTotalThroughput"/>.
                /// </summary>
                public const string HdbTotalThroughput = "HDB_TOTAL_THROUGHPUT";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.HealthChecks"/>
                /// .
                /// </summary>
                public const string HealthChecks = "HEALTH_CHECKS";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.Images"/>.
                /// </summary>
                public const string Images = "IMAGES";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.Instances"/>.
                /// </summary>
                public const string Instances = "INSTANCES";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.InstanceGroups"/>.
                /// </summary>
                public const string InstanceGroups = "INSTANCE_GROUPS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.InstanceGroupManagers"/>.
                /// </summary>
                public const string InstanceGroupManagers = "INSTANCE_GROUP_MANAGERS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.InstanceTemplates"/>.
                /// </summary>
                public const string InstanceTemplates = "INSTANCE_TEMPLATES";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.Interconnects"/>.
                /// </summary>
                public const string Interconnects = "INTERCONNECTS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.InterconnectAttachmentsPerRegion"/>.
                /// </summary>
                public const string InterconnectAttachmentsPerRegion = "INTERCONNECT_ATTACHMENTS_PER_REGION";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.InterconnectAttachmentsTotalMbps"/>.
                /// </summary>
                public const string InterconnectAttachmentsTotalMbps = "INTERCONNECT_ATTACHMENTS_TOTAL_MBPS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.InterconnectTotalGbps"/>.
                /// </summary>
                public const string InterconnectTotalGbps = "INTERCONNECT_TOTAL_GBPS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.InternalAddresses"/>.
                /// </summary>
                public const string InternalAddresses = "INTERNAL_ADDRESSES";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.InternalTrafficDirectorForwardingRules"/>
                /// .
                /// </summary>
                public const string InternalTrafficDirectorForwardingRules = "INTERNAL_TRAFFIC_DIRECTOR_FORWARDING_RULES";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.InPlaceSnapshots"/>.
                /// </summary>
                public const string InPlaceSnapshots = "IN_PLACE_SNAPSHOTS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.InUseAddresses"/>.
                /// </summary>
                public const string InUseAddresses = "IN_USE_ADDRESSES";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.InUseBackupSchedules"/>.
                /// </summary>
                public const string InUseBackupSchedules = "IN_USE_BACKUP_SCHEDULES";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.InUseSnapshotSchedules"/>.
                /// </summary>
                public const string InUseSnapshotSchedules = "IN_USE_SNAPSHOT_SCHEDULES";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.LocalSsdTotalGb"/>.
                /// </summary>
                public const string LocalSsdTotalGb = "LOCAL_SSD_TOTAL_GB";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.M1Cpus"/>.
                /// </summary>
                public const string M1Cpus = "M1_CPUS";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.M2Cpus"/>.
                /// </summary>
                public const string M2Cpus = "M2_CPUS";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.M3Cpus"/>.
                /// </summary>
                public const string M3Cpus = "M3_CPUS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.MachineImages"/>.
                /// </summary>
                public const string MachineImages = "MACHINE_IMAGES";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.N2ACpus"/>.
                /// </summary>
                public const string N2ACpus = "N2A_CPUS";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.N2DCpus"/>.
                /// </summary>
                public const string N2DCpus = "N2D_CPUS";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.N2Cpus"/>.
                /// </summary>
                public const string N2Cpus = "N2_CPUS";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.Networks"/>.
                /// </summary>
                public const string Networks = "NETWORKS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.NetworkAttachments"/>.
                /// </summary>
                public const string NetworkAttachments = "NETWORK_ATTACHMENTS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.NetworkEndpointGroups"/>.
                /// </summary>
                public const string NetworkEndpointGroups = "NETWORK_ENDPOINT_GROUPS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.NetworkFirewallPolicies"/>.
                /// </summary>
                public const string NetworkFirewallPolicies = "NETWORK_FIREWALL_POLICIES";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.NetLbSecurityPoliciesPerRegion"/>.
                /// </summary>
                public const string NetLbSecurityPoliciesPerRegion = "NET_LB_SECURITY_POLICIES_PER_REGION";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.NetLbSecurityPolicyRulesPerRegion"/>.
                /// </summary>
                public const string NetLbSecurityPolicyRulesPerRegion = "NET_LB_SECURITY_POLICY_RULES_PER_REGION";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.NetLbSecurityPolicyRuleAttributesPerRegion"/>
                /// .
                /// </summary>
                public const string NetLbSecurityPolicyRuleAttributesPerRegion = "NET_LB_SECURITY_POLICY_RULE_ATTRIBUTES_PER_REGION";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.NodeGroups"/>.
                /// </summary>
                public const string NodeGroups = "NODE_GROUPS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.NodeTemplates"/>.
                /// </summary>
                public const string NodeTemplates = "NODE_TEMPLATES";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.NvidiaA10080GbGpus"/>.
                /// </summary>
                public const string NvidiaA10080GbGpus = "NVIDIA_A100_80GB_GPUS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.NvidiaA100Gpus"/>.
                /// </summary>
                public const string NvidiaA100Gpus = "NVIDIA_A100_GPUS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.NvidiaK80Gpus"/>.
                /// </summary>
                public const string NvidiaK80Gpus = "NVIDIA_K80_GPUS";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.NvidiaL4Gpus"/>
                /// .
                /// </summary>
                public const string NvidiaL4Gpus = "NVIDIA_L4_GPUS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.NvidiaP100Gpus"/>.
                /// </summary>
                public const string NvidiaP100Gpus = "NVIDIA_P100_GPUS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.NvidiaP100VwsGpus"/>.
                /// </summary>
                public const string NvidiaP100VwsGpus = "NVIDIA_P100_VWS_GPUS";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.NvidiaP4Gpus"/>
                /// .
                /// </summary>
                public const string NvidiaP4Gpus = "NVIDIA_P4_GPUS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.NvidiaP4VwsGpus"/>.
                /// </summary>
                public const string NvidiaP4VwsGpus = "NVIDIA_P4_VWS_GPUS";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.NvidiaT4Gpus"/>
                /// .
                /// </summary>
                public const string NvidiaT4Gpus = "NVIDIA_T4_GPUS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.NvidiaT4VwsGpus"/>.
                /// </summary>
                public const string NvidiaT4VwsGpus = "NVIDIA_T4_VWS_GPUS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.NvidiaV100Gpus"/>.
                /// </summary>
                public const string NvidiaV100Gpus = "NVIDIA_V100_GPUS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.PacketMirrorings"/>.
                /// </summary>
                public const string PacketMirrorings = "PACKET_MIRRORINGS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.PdExtremeTotalProvisionedIops"/>.
                /// </summary>
                public const string PdExtremeTotalProvisionedIops = "PD_EXTREME_TOTAL_PROVISIONED_IOPS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.PreemptibleCpus"/>.
                /// </summary>
                public const string PreemptibleCpus = "PREEMPTIBLE_CPUS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.PreemptibleLocalSsdGb"/>.
                /// </summary>
                public const string PreemptibleLocalSsdGb = "PREEMPTIBLE_LOCAL_SSD_GB";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.PreemptibleNvidiaA10080GbGpus"/>.
                /// </summary>
                public const string PreemptibleNvidiaA10080GbGpus = "PREEMPTIBLE_NVIDIA_A100_80GB_GPUS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.PreemptibleNvidiaA100Gpus"/>.
                /// </summary>
                public const string PreemptibleNvidiaA100Gpus = "PREEMPTIBLE_NVIDIA_A100_GPUS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.PreemptibleNvidiaH100Gpus"/>.
                /// </summary>
                public const string PreemptibleNvidiaH100Gpus = "PREEMPTIBLE_NVIDIA_H100_GPUS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.PreemptibleNvidiaK80Gpus"/>.
                /// </summary>
                public const string PreemptibleNvidiaK80Gpus = "PREEMPTIBLE_NVIDIA_K80_GPUS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.PreemptibleNvidiaL4Gpus"/>.
                /// </summary>
                public const string PreemptibleNvidiaL4Gpus = "PREEMPTIBLE_NVIDIA_L4_GPUS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.PreemptibleNvidiaP100Gpus"/>.
                /// </summary>
                public const string PreemptibleNvidiaP100Gpus = "PREEMPTIBLE_NVIDIA_P100_GPUS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.PreemptibleNvidiaP100VwsGpus"/>.
                /// </summary>
                public const string PreemptibleNvidiaP100VwsGpus = "PREEMPTIBLE_NVIDIA_P100_VWS_GPUS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.PreemptibleNvidiaP4Gpus"/>.
                /// </summary>
                public const string PreemptibleNvidiaP4Gpus = "PREEMPTIBLE_NVIDIA_P4_GPUS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.PreemptibleNvidiaP4VwsGpus"/>.
                /// </summary>
                public const string PreemptibleNvidiaP4VwsGpus = "PREEMPTIBLE_NVIDIA_P4_VWS_GPUS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.PreemptibleNvidiaT4Gpus"/>.
                /// </summary>
                public const string PreemptibleNvidiaT4Gpus = "PREEMPTIBLE_NVIDIA_T4_GPUS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.PreemptibleNvidiaT4VwsGpus"/>.
                /// </summary>
                public const string PreemptibleNvidiaT4VwsGpus = "PREEMPTIBLE_NVIDIA_T4_VWS_GPUS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.PreemptibleNvidiaV100Gpus"/>.
                /// </summary>
                public const string PreemptibleNvidiaV100Gpus = "PREEMPTIBLE_NVIDIA_V100_GPUS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.PreemptibleTpuLiteDeviceV5"/>.
                /// </summary>
                public const string PreemptibleTpuLiteDeviceV5 = "PREEMPTIBLE_TPU_LITE_DEVICE_V5";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.PreemptibleTpuLitePodsliceV5"/>.
                /// </summary>
                public const string PreemptibleTpuLitePodsliceV5 = "PREEMPTIBLE_TPU_LITE_PODSLICE_V5";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.PreemptibleTpuPodsliceV4"/>.
                /// </summary>
                public const string PreemptibleTpuPodsliceV4 = "PREEMPTIBLE_TPU_PODSLICE_V4";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.PscIlbConsumerForwardingRulesPerProducerNetwork"/>
                /// .
                /// </summary>
                public const string PscIlbConsumerForwardingRulesPerProducerNetwork = "PSC_ILB_CONSUMER_FORWARDING_RULES_PER_PRODUCER_NETWORK";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.PscInternalLbForwardingRules"/>.
                /// </summary>
                public const string PscInternalLbForwardingRules = "PSC_INTERNAL_LB_FORWARDING_RULES";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.PublicAdvertisedPrefixes"/>.
                /// </summary>
                public const string PublicAdvertisedPrefixes = "PUBLIC_ADVERTISED_PREFIXES";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.PublicDelegatedPrefixes"/>.
                /// </summary>
                public const string PublicDelegatedPrefixes = "PUBLIC_DELEGATED_PREFIXES";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.RegionalAutoscalers"/>.
                /// </summary>
                public const string RegionalAutoscalers = "REGIONAL_AUTOSCALERS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.RegionalExternalManagedBackendServices"/>
                /// .
                /// </summary>
                public const string RegionalExternalManagedBackendServices = "REGIONAL_EXTERNAL_MANAGED_BACKEND_SERVICES";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.RegionalExternalNetworkLbBackendServices"/>
                /// .
                /// </summary>
                public const string RegionalExternalNetworkLbBackendServices = "REGIONAL_EXTERNAL_NETWORK_LB_BACKEND_SERVICES";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.RegionalInstanceGroupManagers"/>.
                /// </summary>
                public const string RegionalInstanceGroupManagers = "REGIONAL_INSTANCE_GROUP_MANAGERS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.RegionalInternalLbBackendServices"/>.
                /// </summary>
                public const string RegionalInternalLbBackendServices = "REGIONAL_INTERNAL_LB_BACKEND_SERVICES";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.RegionalInternalManagedBackendServices"/>
                /// .
                /// </summary>
                public const string RegionalInternalManagedBackendServices = "REGIONAL_INTERNAL_MANAGED_BACKEND_SERVICES";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.RegionalInternalTrafficDirectorBackendServices"/>
                /// .
                /// </summary>
                public const string RegionalInternalTrafficDirectorBackendServices = "REGIONAL_INTERNAL_TRAFFIC_DIRECTOR_BACKEND_SERVICES";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.Reservations"/>
                /// .
                /// </summary>
                public const string Reservations = "RESERVATIONS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.ResourcePolicies"/>.
                /// </summary>
                public const string ResourcePolicies = "RESOURCE_POLICIES";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.Routers"/>.
                /// </summary>
                public const string Routers = "ROUTERS";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.Routes"/>.
                /// </summary>
                public const string Routes = "ROUTES";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.SecurityPolicies"/>.
                /// </summary>
                public const string SecurityPolicies = "SECURITY_POLICIES";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.SecurityPoliciesPerRegion"/>.
                /// </summary>
                public const string SecurityPoliciesPerRegion = "SECURITY_POLICIES_PER_REGION";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.SecurityPolicyAdvancedRulesPerRegion"/>
                /// .
                /// </summary>
                public const string SecurityPolicyAdvancedRulesPerRegion = "SECURITY_POLICY_ADVANCED_RULES_PER_REGION";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.SecurityPolicyCevalRules"/>.
                /// </summary>
                public const string SecurityPolicyCevalRules = "SECURITY_POLICY_CEVAL_RULES";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.SecurityPolicyRules"/>.
                /// </summary>
                public const string SecurityPolicyRules = "SECURITY_POLICY_RULES";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.SecurityPolicyRulesPerRegion"/>.
                /// </summary>
                public const string SecurityPolicyRulesPerRegion = "SECURITY_POLICY_RULES_PER_REGION";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.ServiceAttachments"/>.
                /// </summary>
                public const string ServiceAttachments = "SERVICE_ATTACHMENTS";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.Snapshots"/>.
                /// </summary>
                public const string Snapshots = "SNAPSHOTS";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.SsdTotalGb"/>.
                /// </summary>
                public const string SsdTotalGb = "SSD_TOTAL_GB";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.SslCertificates"/>.
                /// </summary>
                public const string SslCertificates = "SSL_CERTIFICATES";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.SslPolicies"/>.
                /// </summary>
                public const string SslPolicies = "SSL_POLICIES";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.StaticAddresses"/>.
                /// </summary>
                public const string StaticAddresses = "STATIC_ADDRESSES";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.StaticByoipAddresses"/>.
                /// </summary>
                public const string StaticByoipAddresses = "STATIC_BYOIP_ADDRESSES";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.StaticExternalIpv6AddressRanges"/>.
                /// </summary>
                public const string StaticExternalIpv6AddressRanges = "STATIC_EXTERNAL_IPV6_ADDRESS_RANGES";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.Subnetworks"/>.
                /// </summary>
                public const string Subnetworks = "SUBNETWORKS";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.T2ACpus"/>.
                /// </summary>
                public const string T2ACpus = "T2A_CPUS";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.T2DCpus"/>.
                /// </summary>
                public const string T2DCpus = "T2D_CPUS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.TargetHttpsProxies"/>.
                /// </summary>
                public const string TargetHttpsProxies = "TARGET_HTTPS_PROXIES";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.TargetHttpProxies"/>.
                /// </summary>
                public const string TargetHttpProxies = "TARGET_HTTP_PROXIES";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.TargetInstances"/>.
                /// </summary>
                public const string TargetInstances = "TARGET_INSTANCES";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.TargetPools"/>.
                /// </summary>
                public const string TargetPools = "TARGET_POOLS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.TargetSslProxies"/>.
                /// </summary>
                public const string TargetSslProxies = "TARGET_SSL_PROXIES";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.TargetTcpProxies"/>.
                /// </summary>
                public const string TargetTcpProxies = "TARGET_TCP_PROXIES";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.TargetVpnGateways"/>.
                /// </summary>
                public const string TargetVpnGateways = "TARGET_VPN_GATEWAYS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.TpuLiteDeviceV5"/>.
                /// </summary>
                public const string TpuLiteDeviceV5 = "TPU_LITE_DEVICE_V5";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.TpuLitePodsliceV5"/>.
                /// </summary>
                public const string TpuLitePodsliceV5 = "TPU_LITE_PODSLICE_V5";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.TpuPodsliceV4"/>.
                /// </summary>
                public const string TpuPodsliceV4 = "TPU_PODSLICE_V4";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.UrlMaps"/>.
                /// </summary>
                public const string UrlMaps = "URL_MAPS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.VariableIpv6PublicDelegatedPrefixes"/>
                /// .
                /// </summary>
                public const string VariableIpv6PublicDelegatedPrefixes = "VARIABLE_IPV6_PUBLIC_DELEGATED_PREFIXES";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.VpnGateways"/>.
                /// </summary>
                public const string VpnGateways = "VPN_GATEWAYS";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.VpnTunnels"/>.
                /// </summary>
                public const string VpnTunnels = "VPN_TUNNELS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.XpnServiceProjects"/>.
                /// </summary>
                public const string XpnServiceProjects = "XPN_SERVICE_PROJECTS";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.QuotaExceededInfo"/>
        /// message.
        /// </summary>
        public static class QuotaExceededInfo
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.QuotaExceededInfo.Types.RolloutStatus"/> enum.
            /// </summary>
            public static class RolloutStatus
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.QuotaExceededInfo.Types.RolloutStatus.UndefinedRolloutStatus"/>
                /// .
                /// </summary>
                public const string UndefinedRolloutStatus = "UNDEFINED_ROLLOUT_STATUS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.QuotaExceededInfo.Types.RolloutStatus.InProgress"/>.
                /// </summary>
                public const string InProgress = "IN_PROGRESS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.QuotaExceededInfo.Types.RolloutStatus.Unspecified"/>.
                /// </summary>
                public const string Unspecified = "ROLLOUT_STATUS_UNSPECIFIED";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.QuotaStatusWarning"/>
        /// message.
        /// </summary>
        public static class QuotaStatusWarning
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.QuotaStatusWarning.Types.Code"/> enum.
            /// </summary>
            public static class Code
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.QuotaStatusWarning.Types.Code.UndefinedCode"/>.
                /// </summary>
                public const string UndefinedCode = "UNDEFINED_CODE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.QuotaStatusWarning.Types.Code.CleanupFailed"/>.
                /// </summary>
                public const string CleanupFailed = "CLEANUP_FAILED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.QuotaStatusWarning.Types.Code.DeprecatedResourceUsed"/>.
                /// </summary>
                public const string DeprecatedResourceUsed = "DEPRECATED_RESOURCE_USED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.QuotaStatusWarning.Types.Code.DeprecatedTypeUsed"/>.
                /// </summary>
                public const string DeprecatedTypeUsed = "DEPRECATED_TYPE_USED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.QuotaStatusWarning.Types.Code.DiskSizeLargerThanImageSize"/>
                /// .
                /// </summary>
                public const string DiskSizeLargerThanImageSize = "DISK_SIZE_LARGER_THAN_IMAGE_SIZE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.QuotaStatusWarning.Types.Code.ExperimentalTypeUsed"/>.
                /// </summary>
                public const string ExperimentalTypeUsed = "EXPERIMENTAL_TYPE_USED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.QuotaStatusWarning.Types.Code.ExternalApiWarning"/>.
                /// </summary>
                public const string ExternalApiWarning = "EXTERNAL_API_WARNING";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.QuotaStatusWarning.Types.Code.FieldValueOverriden"/>.
                /// </summary>
                public const string FieldValueOverriden = "FIELD_VALUE_OVERRIDEN";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.QuotaStatusWarning.Types.Code.InjectedKernelsDeprecated"/>
                /// .
                /// </summary>
                public const string InjectedKernelsDeprecated = "INJECTED_KERNELS_DEPRECATED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.QuotaStatusWarning.Types.Code.InvalidHealthCheckForDynamicWieghtedLb"/>
                /// .
                /// </summary>
                public const string InvalidHealthCheckForDynamicWieghtedLb = "INVALID_HEALTH_CHECK_FOR_DYNAMIC_WIEGHTED_LB";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.QuotaStatusWarning.Types.Code.LargeDeploymentWarning"/>.
                /// </summary>
                public const string LargeDeploymentWarning = "LARGE_DEPLOYMENT_WARNING";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.QuotaStatusWarning.Types.Code.ListOverheadQuotaExceed"/>.
                /// </summary>
                public const string ListOverheadQuotaExceed = "LIST_OVERHEAD_QUOTA_EXCEED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.QuotaStatusWarning.Types.Code.MissingTypeDependency"/>.
                /// </summary>
                public const string MissingTypeDependency = "MISSING_TYPE_DEPENDENCY";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.QuotaStatusWarning.Types.Code.NextHopAddressNotAssigned"/>
                /// .
                /// </summary>
                public const string NextHopAddressNotAssigned = "NEXT_HOP_ADDRESS_NOT_ASSIGNED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.QuotaStatusWarning.Types.Code.NextHopCannotIpForward"/>.
                /// </summary>
                public const string NextHopCannotIpForward = "NEXT_HOP_CANNOT_IP_FORWARD";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.QuotaStatusWarning.Types.Code.NextHopInstanceHasNoIpv6Interface"/>
                /// .
                /// </summary>
                public const string NextHopInstanceHasNoIpv6Interface = "NEXT_HOP_INSTANCE_HAS_NO_IPV6_INTERFACE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.QuotaStatusWarning.Types.Code.NextHopInstanceNotFound"/>.
                /// </summary>
                public const string NextHopInstanceNotFound = "NEXT_HOP_INSTANCE_NOT_FOUND";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.QuotaStatusWarning.Types.Code.NextHopInstanceNotOnNetwork"/>
                /// .
                /// </summary>
                public const string NextHopInstanceNotOnNetwork = "NEXT_HOP_INSTANCE_NOT_ON_NETWORK";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.QuotaStatusWarning.Types.Code.NextHopNotRunning"/>.
                /// </summary>
                public const string NextHopNotRunning = "NEXT_HOP_NOT_RUNNING";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.QuotaStatusWarning.Types.Code.NotCriticalError"/>.
                /// </summary>
                public const string NotCriticalError = "NOT_CRITICAL_ERROR";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.QuotaStatusWarning.Types.Code.NoResultsOnPage"/>.
                /// </summary>
                public const string NoResultsOnPage = "NO_RESULTS_ON_PAGE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.QuotaStatusWarning.Types.Code.PartialSuccess"/>.
                /// </summary>
                public const string PartialSuccess = "PARTIAL_SUCCESS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.QuotaStatusWarning.Types.Code.QuotaInfoUnavailable"/>.
                /// </summary>
                public const string QuotaInfoUnavailable = "QUOTA_INFO_UNAVAILABLE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.QuotaStatusWarning.Types.Code.RequiredTosAgreement"/>.
                /// </summary>
                public const string RequiredTosAgreement = "REQUIRED_TOS_AGREEMENT";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.QuotaStatusWarning.Types.Code.ResourceInUseByOtherResourceWarning"/>
                /// .
                /// </summary>
                public const string ResourceInUseByOtherResourceWarning = "RESOURCE_IN_USE_BY_OTHER_RESOURCE_WARNING";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.QuotaStatusWarning.Types.Code.ResourceNotDeleted"/>.
                /// </summary>
                public const string ResourceNotDeleted = "RESOURCE_NOT_DELETED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.QuotaStatusWarning.Types.Code.SchemaValidationIgnored"/>.
                /// </summary>
                public const string SchemaValidationIgnored = "SCHEMA_VALIDATION_IGNORED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.QuotaStatusWarning.Types.Code.SingleInstancePropertyTemplate"/>
                /// .
                /// </summary>
                public const string SingleInstancePropertyTemplate = "SINGLE_INSTANCE_PROPERTY_TEMPLATE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.QuotaStatusWarning.Types.Code.UndeclaredProperties"/>.
                /// </summary>
                public const string UndeclaredProperties = "UNDECLARED_PROPERTIES";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.QuotaStatusWarning.Types.Code.Unreachable"/>.
                /// </summary>
                public const string Unreachable = "UNREACHABLE";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.RawDisk"/> message.
        /// </summary>
        public static class RawDisk
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.RawDisk.Types.ContainerType"/> enum.
            /// </summary>
            public static class ContainerType
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.RawDisk.Types.ContainerType.UndefinedContainerType"/>.
                /// </summary>
                public const string UndefinedContainerType = "UNDEFINED_CONTAINER_TYPE";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.RawDisk.Types.ContainerType.Tar"/>
                /// .
                /// </summary>
                public const string Tar = "TAR";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.Region"/> message.
        /// </summary>
        public static class Region
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.Region.Types.Status"/> enum.
            /// </summary>
            public static class Status
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Region.Types.Status.UndefinedStatus"/>.
                /// </summary>
                public const string UndefinedStatus = "UNDEFINED_STATUS";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.Region.Types.Status.Down"/>.
                /// </summary>
                public const string Down = "DOWN";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.Region.Types.Status.Up"/>.
                /// </summary>
                public const string Up = "UP";
            }
        }

        /// <summary>
        /// Container class for enums within the
        /// <see cref="global::Google.Cloud.Compute.V1.RegionInstanceGroupManagersApplyUpdatesRequest"/> message.
        /// </summary>
        public static class RegionInstanceGroupManagersApplyUpdatesRequest
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.RegionInstanceGroupManagersApplyUpdatesRequest.Types.MinimalAction"/>
            ///  enum.
            /// </summary>
            public static class MinimalAction
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.RegionInstanceGroupManagersApplyUpdatesRequest.Types.MinimalAction.UndefinedMinimalAction"/>
                /// .
                /// </summary>
                public const string UndefinedMinimalAction = "UNDEFINED_MINIMAL_ACTION";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.RegionInstanceGroupManagersApplyUpdatesRequest.Types.MostDisruptiveAllowedAction"/>
            ///  enum.
            /// </summary>
            public static class MostDisruptiveAllowedAction
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.RegionInstanceGroupManagersApplyUpdatesRequest.Types.MostDisruptiveAllowedAction.UndefinedMostDisruptiveAllowedAction"/>
                /// .
                /// </summary>
                public const string UndefinedMostDisruptiveAllowedAction = "UNDEFINED_MOST_DISRUPTIVE_ALLOWED_ACTION";
            }
        }

        /// <summary>
        /// Container class for enums within the
        /// <see cref="global::Google.Cloud.Compute.V1.RegionInstanceGroupsListInstancesRequest"/> message.
        /// </summary>
        public static class RegionInstanceGroupsListInstancesRequest
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.RegionInstanceGroupsListInstancesRequest.Types.InstanceState"/>
            ///  enum.
            /// </summary>
            public static class InstanceState
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.RegionInstanceGroupsListInstancesRequest.Types.InstanceState.UndefinedInstanceState"/>
                /// .
                /// </summary>
                public const string UndefinedInstanceState = "UNDEFINED_INSTANCE_STATE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.RegionInstanceGroupsListInstancesRequest.Types.InstanceState.All"/>
                /// .
                /// </summary>
                public const string All = "ALL";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.RegionInstanceGroupsListInstancesRequest.Types.InstanceState.Running"/>
                /// .
                /// </summary>
                public const string Running = "RUNNING";
            }
        }

        /// <summary>
        /// Container class for enums within the
        /// <see cref="global::Google.Cloud.Compute.V1.RegionNetworkFirewallPoliciesGetEffectiveFirewallsResponseEffectiveFirewallPolicy"/>
        ///  message.
        /// </summary>
        public static class RegionNetworkFirewallPoliciesGetEffectiveFirewallsResponseEffectiveFirewallPolicy
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.RegionNetworkFirewallPoliciesGetEffectiveFirewallsResponseEffectiveFirewallPolicy.Types.Type"/>
            ///  enum.
            /// </summary>
            public static class Type
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.RegionNetworkFirewallPoliciesGetEffectiveFirewallsResponseEffectiveFirewallPolicy.Types.Type.UndefinedType"/>
                /// .
                /// </summary>
                public const string UndefinedType = "UNDEFINED_TYPE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.RegionNetworkFirewallPoliciesGetEffectiveFirewallsResponseEffectiveFirewallPolicy.Types.Type.Hierarchy"/>
                /// .
                /// </summary>
                public const string Hierarchy = "HIERARCHY";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.RegionNetworkFirewallPoliciesGetEffectiveFirewallsResponseEffectiveFirewallPolicy.Types.Type.Network"/>
                /// .
                /// </summary>
                public const string Network = "NETWORK";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.RegionNetworkFirewallPoliciesGetEffectiveFirewallsResponseEffectiveFirewallPolicy.Types.Type.NetworkRegional"/>
                /// .
                /// </summary>
                public const string NetworkRegional = "NETWORK_REGIONAL";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.RegionNetworkFirewallPoliciesGetEffectiveFirewallsResponseEffectiveFirewallPolicy.Types.Type.SystemGlobal"/>
                /// .
                /// </summary>
                public const string SystemGlobal = "SYSTEM_GLOBAL";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.RegionNetworkFirewallPoliciesGetEffectiveFirewallsResponseEffectiveFirewallPolicy.Types.Type.SystemRegional"/>
                /// .
                /// </summary>
                public const string SystemRegional = "SYSTEM_REGIONAL";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.RegionNetworkFirewallPoliciesGetEffectiveFirewallsResponseEffectiveFirewallPolicy.Types.Type.Unspecified"/>
                /// .
                /// </summary>
                public const string Unspecified = "UNSPECIFIED";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.Reservation"/> message.
        /// </summary>
        public static class Reservation
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.Reservation.Types.DeploymentType"/> enum.
            /// </summary>
            public static class DeploymentType
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Reservation.Types.DeploymentType.UndefinedDeploymentType"/>
                /// .
                /// </summary>
                public const string UndefinedDeploymentType = "UNDEFINED_DEPLOYMENT_TYPE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Reservation.Types.DeploymentType.Dense"/>.
                /// </summary>
                public const string Dense = "DENSE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Reservation.Types.DeploymentType.Unspecified"/>.
                /// </summary>
                public const string Unspecified = "DEPLOYMENT_TYPE_UNSPECIFIED";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.Reservation.Types.SchedulingType"/> enum.
            /// </summary>
            public static class SchedulingType
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Reservation.Types.SchedulingType.UndefinedSchedulingType"/>
                /// .
                /// </summary>
                public const string UndefinedSchedulingType = "UNDEFINED_SCHEDULING_TYPE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Reservation.Types.SchedulingType.Grouped"/>.
                /// </summary>
                public const string Grouped = "GROUPED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Reservation.Types.SchedulingType.GroupMaintenanceTypeUnspecified"/>
                /// .
                /// </summary>
                public const string GroupMaintenanceTypeUnspecified = "GROUP_MAINTENANCE_TYPE_UNSPECIFIED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Reservation.Types.SchedulingType.Independent"/>.
                /// </summary>
                public const string Independent = "INDEPENDENT";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.Reservation.Types.Status"/> enum.
            /// </summary>
            public static class Status
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Reservation.Types.Status.UndefinedStatus"/>.
                /// </summary>
                public const string UndefinedStatus = "UNDEFINED_STATUS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Reservation.Types.Status.Creating"/>.
                /// </summary>
                public const string Creating = "CREATING";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Reservation.Types.Status.Deleting"/>.
                /// </summary>
                public const string Deleting = "DELETING";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Reservation.Types.Status.Invalid"/>.
                /// </summary>
                public const string Invalid = "INVALID";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.Reservation.Types.Status.Ready"/>.
                /// </summary>
                public const string Ready = "READY";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Reservation.Types.Status.Updating"/>.
                /// </summary>
                public const string Updating = "UPDATING";
            }
        }

        /// <summary>
        /// Container class for enums within the
        /// <see cref="global::Google.Cloud.Compute.V1.ReservationAdvancedDeploymentControl"/> message.
        /// </summary>
        public static class ReservationAdvancedDeploymentControl
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.ReservationAdvancedDeploymentControl.Types.ReservationOperationalMode"/>
            ///  enum.
            /// </summary>
            public static class ReservationOperationalMode
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ReservationAdvancedDeploymentControl.Types.ReservationOperationalMode.UndefinedReservationOperationalMode"/>
                /// .
                /// </summary>
                public const string UndefinedReservationOperationalMode = "UNDEFINED_RESERVATION_OPERATIONAL_MODE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ReservationAdvancedDeploymentControl.Types.ReservationOperationalMode.AllCapacity"/>
                /// .
                /// </summary>
                public const string AllCapacity = "ALL_CAPACITY";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ReservationAdvancedDeploymentControl.Types.ReservationOperationalMode.HighlyAvailableCapacity"/>
                /// .
                /// </summary>
                public const string HighlyAvailableCapacity = "HIGHLY_AVAILABLE_CAPACITY";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ReservationAdvancedDeploymentControl.Types.ReservationOperationalMode.Unspecified"/>
                /// .
                /// </summary>
                public const string Unspecified = "RESERVATION_OPERATIONAL_MODE_UNSPECIFIED";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.ReservationAffinity"/>
        /// message.
        /// </summary>
        public static class ReservationAffinity
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.ReservationAffinity.Types.ConsumeReservationType"/> enum.
            /// </summary>
            public static class ConsumeReservationType
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ReservationAffinity.Types.ConsumeReservationType.UndefinedConsumeReservationType"/>
                /// .
                /// </summary>
                public const string UndefinedConsumeReservationType = "UNDEFINED_CONSUME_RESERVATION_TYPE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ReservationAffinity.Types.ConsumeReservationType.AnyReservation"/>
                /// .
                /// </summary>
                public const string AnyReservation = "ANY_RESERVATION";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ReservationAffinity.Types.ConsumeReservationType.NoReservation"/>
                /// .
                /// </summary>
                public const string NoReservation = "NO_RESERVATION";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ReservationAffinity.Types.ConsumeReservationType.SpecificReservation"/>
                /// .
                /// </summary>
                public const string SpecificReservation = "SPECIFIC_RESERVATION";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ReservationAffinity.Types.ConsumeReservationType.Unspecified"/>
                /// .
                /// </summary>
                public const string Unspecified = "UNSPECIFIED";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.ReservationBlock"/> message.
        /// </summary>
        public static class ReservationBlock
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.ReservationBlock.Types.Status"/> enum.
            /// </summary>
            public static class Status
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ReservationBlock.Types.Status.UndefinedStatus"/>.
                /// </summary>
                public const string UndefinedStatus = "UNDEFINED_STATUS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ReservationBlock.Types.Status.Creating"/>.
                /// </summary>
                public const string Creating = "CREATING";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ReservationBlock.Types.Status.Deleting"/>.
                /// </summary>
                public const string Deleting = "DELETING";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ReservationBlock.Types.Status.Invalid"/>.
                /// </summary>
                public const string Invalid = "INVALID";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ReservationBlock.Types.Status.Ready"/>.
                /// </summary>
                public const string Ready = "READY";
            }
        }

        /// <summary>
        /// Container class for enums within the
        /// <see cref="global::Google.Cloud.Compute.V1.ReservationBlockHealthInfo"/> message.
        /// </summary>
        public static class ReservationBlockHealthInfo
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.ReservationBlockHealthInfo.Types.HealthStatus"/> enum.
            /// </summary>
            public static class HealthStatus
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ReservationBlockHealthInfo.Types.HealthStatus.UndefinedHealthStatus"/>
                /// .
                /// </summary>
                public const string UndefinedHealthStatus = "UNDEFINED_HEALTH_STATUS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ReservationBlockHealthInfo.Types.HealthStatus.Degraded"/>
                /// .
                /// </summary>
                public const string Degraded = "DEGRADED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ReservationBlockHealthInfo.Types.HealthStatus.Healthy"/>.
                /// </summary>
                public const string Healthy = "HEALTHY";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ReservationBlockHealthInfo.Types.HealthStatus.Unspecified"/>
                /// .
                /// </summary>
                public const string Unspecified = "HEALTH_STATUS_UNSPECIFIED";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.ReservationSubBlock"/>
        /// message.
        /// </summary>
        public static class ReservationSubBlock
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.ReservationSubBlock.Types.Status"/> enum.
            /// </summary>
            public static class Status
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ReservationSubBlock.Types.Status.UndefinedStatus"/>.
                /// </summary>
                public const string UndefinedStatus = "UNDEFINED_STATUS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ReservationSubBlock.Types.Status.Creating"/>.
                /// </summary>
                public const string Creating = "CREATING";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ReservationSubBlock.Types.Status.Deleting"/>.
                /// </summary>
                public const string Deleting = "DELETING";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ReservationSubBlock.Types.Status.Invalid"/>.
                /// </summary>
                public const string Invalid = "INVALID";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ReservationSubBlock.Types.Status.Ready"/>.
                /// </summary>
                public const string Ready = "READY";
            }
        }

        /// <summary>
        /// Container class for enums within the
        /// <see cref="global::Google.Cloud.Compute.V1.ReservationSubBlockHealthInfo"/> message.
        /// </summary>
        public static class ReservationSubBlockHealthInfo
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.ReservationSubBlockHealthInfo.Types.HealthStatus"/> enum.
            /// </summary>
            public static class HealthStatus
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ReservationSubBlockHealthInfo.Types.HealthStatus.UndefinedHealthStatus"/>
                /// .
                /// </summary>
                public const string UndefinedHealthStatus = "UNDEFINED_HEALTH_STATUS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ReservationSubBlockHealthInfo.Types.HealthStatus.Degraded"/>
                /// .
                /// </summary>
                public const string Degraded = "DEGRADED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ReservationSubBlockHealthInfo.Types.HealthStatus.Healthy"/>
                /// .
                /// </summary>
                public const string Healthy = "HEALTHY";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ReservationSubBlockHealthInfo.Types.HealthStatus.Unspecified"/>
                /// .
                /// </summary>
                public const string Unspecified = "HEALTH_STATUS_UNSPECIFIED";
            }
        }

        /// <summary>
        /// Container class for enums within the
        /// <see cref="global::Google.Cloud.Compute.V1.ReservationsBlocksPerformMaintenanceRequest"/> message.
        /// </summary>
        public static class ReservationsBlocksPerformMaintenanceRequest
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.ReservationsBlocksPerformMaintenanceRequest.Types.MaintenanceScope"/>
            ///  enum.
            /// </summary>
            public static class MaintenanceScope
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ReservationsBlocksPerformMaintenanceRequest.Types.MaintenanceScope.UndefinedMaintenanceScope"/>
                /// .
                /// </summary>
                public const string UndefinedMaintenanceScope = "UNDEFINED_MAINTENANCE_SCOPE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ReservationsBlocksPerformMaintenanceRequest.Types.MaintenanceScope.All"/>
                /// .
                /// </summary>
                public const string All = "ALL";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ReservationsBlocksPerformMaintenanceRequest.Types.MaintenanceScope.Unspecified"/>
                /// .
                /// </summary>
                public const string Unspecified = "MAINTENANCE_SCOPE_UNSPECIFIED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ReservationsBlocksPerformMaintenanceRequest.Types.MaintenanceScope.RunningVms"/>
                /// .
                /// </summary>
                public const string RunningVms = "RUNNING_VMS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ReservationsBlocksPerformMaintenanceRequest.Types.MaintenanceScope.UnusedCapacity"/>
                /// .
                /// </summary>
                public const string UnusedCapacity = "UNUSED_CAPACITY";
            }
        }

        /// <summary>
        /// Container class for enums within the
        /// <see cref="global::Google.Cloud.Compute.V1.ReservationsPerformMaintenanceRequest"/> message.
        /// </summary>
        public static class ReservationsPerformMaintenanceRequest
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.ReservationsPerformMaintenanceRequest.Types.MaintenanceScope"/>
            ///  enum.
            /// </summary>
            public static class MaintenanceScope
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ReservationsPerformMaintenanceRequest.Types.MaintenanceScope.UndefinedMaintenanceScope"/>
                /// .
                /// </summary>
                public const string UndefinedMaintenanceScope = "UNDEFINED_MAINTENANCE_SCOPE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ReservationsPerformMaintenanceRequest.Types.MaintenanceScope.All"/>
                /// .
                /// </summary>
                public const string All = "ALL";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ReservationsPerformMaintenanceRequest.Types.MaintenanceScope.Unspecified"/>
                /// .
                /// </summary>
                public const string Unspecified = "MAINTENANCE_SCOPE_UNSPECIFIED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ReservationsPerformMaintenanceRequest.Types.MaintenanceScope.RunningVms"/>
                /// .
                /// </summary>
                public const string RunningVms = "RUNNING_VMS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ReservationsPerformMaintenanceRequest.Types.MaintenanceScope.UnusedCapacity"/>
                /// .
                /// </summary>
                public const string UnusedCapacity = "UNUSED_CAPACITY";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.ResourceCommitment"/>
        /// message.
        /// </summary>
        public static class ResourceCommitment
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.ResourceCommitment.Types.Type"/> enum.
            /// </summary>
            public static class Type
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ResourceCommitment.Types.Type.UndefinedType"/>.
                /// </summary>
                public const string UndefinedType = "UNDEFINED_TYPE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ResourceCommitment.Types.Type.Accelerator"/>.
                /// </summary>
                public const string Accelerator = "ACCELERATOR";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ResourceCommitment.Types.Type.LocalSsd"/>.
                /// </summary>
                public const string LocalSsd = "LOCAL_SSD";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ResourceCommitment.Types.Type.Memory"/>.
                /// </summary>
                public const string Memory = "MEMORY";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ResourceCommitment.Types.Type.Unspecified"/>.
                /// </summary>
                public const string Unspecified = "UNSPECIFIED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ResourceCommitment.Types.Type.Vcpu"/>.
                /// </summary>
                public const string Vcpu = "VCPU";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.ResourcePolicy"/> message.
        /// </summary>
        public static class ResourcePolicy
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.ResourcePolicy.Types.Status"/> enum.
            /// </summary>
            public static class Status
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ResourcePolicy.Types.Status.UndefinedStatus"/>.
                /// </summary>
                public const string UndefinedStatus = "UNDEFINED_STATUS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ResourcePolicy.Types.Status.Creating"/>.
                /// </summary>
                public const string Creating = "CREATING";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ResourcePolicy.Types.Status.Deleting"/>.
                /// </summary>
                public const string Deleting = "DELETING";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ResourcePolicy.Types.Status.Expired"/>.
                /// </summary>
                public const string Expired = "EXPIRED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ResourcePolicy.Types.Status.Invalid"/>.
                /// </summary>
                public const string Invalid = "INVALID";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ResourcePolicy.Types.Status.Ready"/>.
                /// </summary>
                public const string Ready = "READY";
            }
        }

        /// <summary>
        /// Container class for enums within the
        /// <see cref="global::Google.Cloud.Compute.V1.ResourcePolicyGroupPlacementPolicy"/> message.
        /// </summary>
        public static class ResourcePolicyGroupPlacementPolicy
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.ResourcePolicyGroupPlacementPolicy.Types.Collocation"/> enum.
            /// </summary>
            public static class Collocation
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ResourcePolicyGroupPlacementPolicy.Types.Collocation.UndefinedCollocation"/>
                /// .
                /// </summary>
                public const string UndefinedCollocation = "UNDEFINED_COLLOCATION";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ResourcePolicyGroupPlacementPolicy.Types.Collocation.Collocated"/>
                /// .
                /// </summary>
                public const string Collocated = "COLLOCATED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ResourcePolicyGroupPlacementPolicy.Types.Collocation.UnspecifiedCollocation"/>
                /// .
                /// </summary>
                public const string UnspecifiedCollocation = "UNSPECIFIED_COLLOCATION";
            }
        }

        /// <summary>
        /// Container class for enums within the
        /// <see cref="global::Google.Cloud.Compute.V1.ResourcePolicySnapshotSchedulePolicyRetentionPolicy"/> message.
        /// </summary>
        public static class ResourcePolicySnapshotSchedulePolicyRetentionPolicy
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.ResourcePolicySnapshotSchedulePolicyRetentionPolicy.Types.OnSourceDiskDelete"/>
            ///  enum.
            /// </summary>
            public static class OnSourceDiskDelete
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ResourcePolicySnapshotSchedulePolicyRetentionPolicy.Types.OnSourceDiskDelete.UndefinedOnSourceDiskDelete"/>
                /// .
                /// </summary>
                public const string UndefinedOnSourceDiskDelete = "UNDEFINED_ON_SOURCE_DISK_DELETE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ResourcePolicySnapshotSchedulePolicyRetentionPolicy.Types.OnSourceDiskDelete.ApplyRetentionPolicy"/>
                /// .
                /// </summary>
                public const string ApplyRetentionPolicy = "APPLY_RETENTION_POLICY";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ResourcePolicySnapshotSchedulePolicyRetentionPolicy.Types.OnSourceDiskDelete.KeepAutoSnapshots"/>
                /// .
                /// </summary>
                public const string KeepAutoSnapshots = "KEEP_AUTO_SNAPSHOTS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ResourcePolicySnapshotSchedulePolicyRetentionPolicy.Types.OnSourceDiskDelete.UnspecifiedOnSourceDiskDelete"/>
                /// .
                /// </summary>
                public const string UnspecifiedOnSourceDiskDelete = "UNSPECIFIED_ON_SOURCE_DISK_DELETE";
            }
        }

        /// <summary>
        /// Container class for enums within the
        /// <see cref="global::Google.Cloud.Compute.V1.ResourcePolicyWeeklyCycleDayOfWeek"/> message.
        /// </summary>
        public static class ResourcePolicyWeeklyCycleDayOfWeek
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.ResourcePolicyWeeklyCycleDayOfWeek.Types.Day"/> enum.
            /// </summary>
            public static class Day
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ResourcePolicyWeeklyCycleDayOfWeek.Types.Day.UndefinedDay"/>
                /// .
                /// </summary>
                public const string UndefinedDay = "UNDEFINED_DAY";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ResourcePolicyWeeklyCycleDayOfWeek.Types.Day.Friday"/>.
                /// </summary>
                public const string Friday = "FRIDAY";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ResourcePolicyWeeklyCycleDayOfWeek.Types.Day.Invalid"/>.
                /// </summary>
                public const string Invalid = "INVALID";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ResourcePolicyWeeklyCycleDayOfWeek.Types.Day.Monday"/>.
                /// </summary>
                public const string Monday = "MONDAY";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ResourcePolicyWeeklyCycleDayOfWeek.Types.Day.Saturday"/>.
                /// </summary>
                public const string Saturday = "SATURDAY";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ResourcePolicyWeeklyCycleDayOfWeek.Types.Day.Sunday"/>.
                /// </summary>
                public const string Sunday = "SUNDAY";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ResourcePolicyWeeklyCycleDayOfWeek.Types.Day.Thursday"/>.
                /// </summary>
                public const string Thursday = "THURSDAY";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ResourcePolicyWeeklyCycleDayOfWeek.Types.Day.Tuesday"/>.
                /// </summary>
                public const string Tuesday = "TUESDAY";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ResourcePolicyWeeklyCycleDayOfWeek.Types.Day.Wednesday"/>
                /// .
                /// </summary>
                public const string Wednesday = "WEDNESDAY";
            }
        }

        /// <summary>
        /// Container class for enums within the
        /// <see cref="global::Google.Cloud.Compute.V1.ResourcePolicyWorkloadPolicy"/> message.
        /// </summary>
        public static class ResourcePolicyWorkloadPolicy
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.ResourcePolicyWorkloadPolicy.Types.MaxTopologyDistance"/>
            /// enum.
            /// </summary>
            public static class MaxTopologyDistance
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ResourcePolicyWorkloadPolicy.Types.MaxTopologyDistance.UndefinedMaxTopologyDistance"/>
                /// .
                /// </summary>
                public const string UndefinedMaxTopologyDistance = "UNDEFINED_MAX_TOPOLOGY_DISTANCE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ResourcePolicyWorkloadPolicy.Types.MaxTopologyDistance.Block"/>
                /// .
                /// </summary>
                public const string Block = "BLOCK";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ResourcePolicyWorkloadPolicy.Types.MaxTopologyDistance.Cluster"/>
                /// .
                /// </summary>
                public const string Cluster = "CLUSTER";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ResourcePolicyWorkloadPolicy.Types.MaxTopologyDistance.Subblock"/>
                /// .
                /// </summary>
                public const string Subblock = "SUBBLOCK";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.ResourcePolicyWorkloadPolicy.Types.Type"/> enum.
            /// </summary>
            public static class Type
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ResourcePolicyWorkloadPolicy.Types.Type.UndefinedType"/>.
                /// </summary>
                public const string UndefinedType = "UNDEFINED_TYPE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ResourcePolicyWorkloadPolicy.Types.Type.HighAvailability"/>
                /// .
                /// </summary>
                public const string HighAvailability = "HIGH_AVAILABILITY";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ResourcePolicyWorkloadPolicy.Types.Type.HighThroughput"/>
                /// .
                /// </summary>
                public const string HighThroughput = "HIGH_THROUGHPUT";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.Route"/> message.
        /// </summary>
        public static class Route
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.Route.Types.NextHopOrigin"/> enum.
            /// </summary>
            public static class NextHopOrigin
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Route.Types.NextHopOrigin.UndefinedNextHopOrigin"/>.
                /// </summary>
                public const string UndefinedNextHopOrigin = "UNDEFINED_NEXT_HOP_ORIGIN";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.Route.Types.NextHopOrigin.Egp"/>.
                /// </summary>
                public const string Egp = "EGP";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.Route.Types.NextHopOrigin.Igp"/>.
                /// </summary>
                public const string Igp = "IGP";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Route.Types.NextHopOrigin.Incomplete"/>.
                /// </summary>
                public const string Incomplete = "INCOMPLETE";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.Route.Types.RouteStatus"/> enum.
            /// </summary>
            public static class RouteStatus
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Route.Types.RouteStatus.UndefinedRouteStatus"/>.
                /// </summary>
                public const string UndefinedRouteStatus = "UNDEFINED_ROUTE_STATUS";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.Route.Types.RouteStatus.Active"/>.
                /// </summary>
                public const string Active = "ACTIVE";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.Route.Types.RouteStatus.Dropped"/>
                /// .
                /// </summary>
                public const string Dropped = "DROPPED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Route.Types.RouteStatus.Inactive"/>.
                /// </summary>
                public const string Inactive = "INACTIVE";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.Route.Types.RouteStatus.Pending"/>
                /// .
                /// </summary>
                public const string Pending = "PENDING";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.Route.Types.RouteType"/> enum.
            /// </summary>
            public static class RouteType
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Route.Types.RouteType.UndefinedRouteType"/>.
                /// </summary>
                public const string UndefinedRouteType = "UNDEFINED_ROUTE_TYPE";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.Route.Types.RouteType.Bgp"/>.
                /// </summary>
                public const string Bgp = "BGP";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.Route.Types.RouteType.Static"/>.
                /// </summary>
                public const string Static = "STATIC";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.Route.Types.RouteType.Subnet"/>.
                /// </summary>
                public const string Subnet = "SUBNET";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.Route.Types.RouteType.Transit"/>.
                /// </summary>
                public const string Transit = "TRANSIT";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.RouteAsPath"/> message.
        /// </summary>
        public static class RouteAsPath
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.RouteAsPath.Types.PathSegmentType"/> enum.
            /// </summary>
            public static class PathSegmentType
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.RouteAsPath.Types.PathSegmentType.UndefinedPathSegmentType"/>
                /// .
                /// </summary>
                public const string UndefinedPathSegmentType = "UNDEFINED_PATH_SEGMENT_TYPE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.RouteAsPath.Types.PathSegmentType.AsConfedSequence"/>.
                /// </summary>
                public const string AsConfedSequence = "AS_CONFED_SEQUENCE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.RouteAsPath.Types.PathSegmentType.AsConfedSet"/>.
                /// </summary>
                public const string AsConfedSet = "AS_CONFED_SET";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.RouteAsPath.Types.PathSegmentType.AsSequence"/>.
                /// </summary>
                public const string AsSequence = "AS_SEQUENCE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.RouteAsPath.Types.PathSegmentType.AsSet"/>.
                /// </summary>
                public const string AsSet = "AS_SET";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.RoutePolicy"/> message.
        /// </summary>
        public static class RoutePolicy
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.RoutePolicy.Types.Type"/> enum.
            /// </summary>
            public static class Type
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.RoutePolicy.Types.Type.UndefinedType"/>.
                /// </summary>
                public const string UndefinedType = "UNDEFINED_TYPE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.RoutePolicy.Types.Type.RoutePolicyTypeExport"/>.
                /// </summary>
                public const string RoutePolicyTypeExport = "ROUTE_POLICY_TYPE_EXPORT";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.RoutePolicy.Types.Type.RoutePolicyTypeImport"/>.
                /// </summary>
                public const string RoutePolicyTypeImport = "ROUTE_POLICY_TYPE_IMPORT";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.RouterBgp"/> message.
        /// </summary>
        public static class RouterBgp
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.RouterBgp.Types.AdvertiseMode"/> enum.
            /// </summary>
            public static class AdvertiseMode
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.RouterBgp.Types.AdvertiseMode.UndefinedAdvertiseMode"/>.
                /// </summary>
                public const string UndefinedAdvertiseMode = "UNDEFINED_ADVERTISE_MODE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.RouterBgp.Types.AdvertiseMode.Custom"/>.
                /// </summary>
                public const string Custom = "CUSTOM";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.RouterBgp.Types.AdvertiseMode.Default"/>.
                /// </summary>
                public const string Default = "DEFAULT";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.RouterBgp.Types.AdvertisedGroups"/> enum.
            /// </summary>
            public static class AdvertisedGroups
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.RouterBgp.Types.AdvertisedGroups.UndefinedAdvertisedGroups"/>
                /// .
                /// </summary>
                public const string UndefinedAdvertisedGroups = "UNDEFINED_ADVERTISED_GROUPS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.RouterBgp.Types.AdvertisedGroups.AllSubnets"/>.
                /// </summary>
                public const string AllSubnets = "ALL_SUBNETS";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.RouterBgpPeer"/> message.
        /// </summary>
        public static class RouterBgpPeer
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.RouterBgpPeer.Types.AdvertiseMode"/> enum.
            /// </summary>
            public static class AdvertiseMode
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.RouterBgpPeer.Types.AdvertiseMode.UndefinedAdvertiseMode"/>
                /// .
                /// </summary>
                public const string UndefinedAdvertiseMode = "UNDEFINED_ADVERTISE_MODE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.RouterBgpPeer.Types.AdvertiseMode.Custom"/>.
                /// </summary>
                public const string Custom = "CUSTOM";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.RouterBgpPeer.Types.AdvertiseMode.Default"/>.
                /// </summary>
                public const string Default = "DEFAULT";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.RouterBgpPeer.Types.AdvertisedGroups"/> enum.
            /// </summary>
            public static class AdvertisedGroups
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.RouterBgpPeer.Types.AdvertisedGroups.UndefinedAdvertisedGroups"/>
                /// .
                /// </summary>
                public const string UndefinedAdvertisedGroups = "UNDEFINED_ADVERTISED_GROUPS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.RouterBgpPeer.Types.AdvertisedGroups.AllSubnets"/>.
                /// </summary>
                public const string AllSubnets = "ALL_SUBNETS";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.RouterBgpPeer.Types.Enable"/> enum.
            /// </summary>
            public static class Enable
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.RouterBgpPeer.Types.Enable.UndefinedEnable"/>.
                /// </summary>
                public const string UndefinedEnable = "UNDEFINED_ENABLE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.RouterBgpPeer.Types.Enable.False"/>.
                /// </summary>
                public const string False = "FALSE";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.RouterBgpPeer.Types.Enable.True"/>
                /// .
                /// </summary>
                public const string True = "TRUE";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.RouterBgpPeer.Types.ManagementType"/> enum.
            /// </summary>
            public static class ManagementType
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.RouterBgpPeer.Types.ManagementType.UndefinedManagementType"/>
                /// .
                /// </summary>
                public const string UndefinedManagementType = "UNDEFINED_MANAGEMENT_TYPE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.RouterBgpPeer.Types.ManagementType.ManagedByAttachment"/>
                /// .
                /// </summary>
                public const string ManagedByAttachment = "MANAGED_BY_ATTACHMENT";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.RouterBgpPeer.Types.ManagementType.ManagedByUser"/>.
                /// </summary>
                public const string ManagedByUser = "MANAGED_BY_USER";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.RouterBgpPeerBfd"/> message.
        /// </summary>
        public static class RouterBgpPeerBfd
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.RouterBgpPeerBfd.Types.SessionInitializationMode"/> enum.
            /// </summary>
            public static class SessionInitializationMode
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.RouterBgpPeerBfd.Types.SessionInitializationMode.UndefinedSessionInitializationMode"/>
                /// .
                /// </summary>
                public const string UndefinedSessionInitializationMode = "UNDEFINED_SESSION_INITIALIZATION_MODE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.RouterBgpPeerBfd.Types.SessionInitializationMode.Active"/>
                /// .
                /// </summary>
                public const string Active = "ACTIVE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.RouterBgpPeerBfd.Types.SessionInitializationMode.Disabled"/>
                /// .
                /// </summary>
                public const string Disabled = "DISABLED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.RouterBgpPeerBfd.Types.SessionInitializationMode.Passive"/>
                /// .
                /// </summary>
                public const string Passive = "PASSIVE";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.RouterInterface"/> message.
        /// </summary>
        public static class RouterInterface
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.RouterInterface.Types.IpVersion"/> enum.
            /// </summary>
            public static class IpVersion
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.RouterInterface.Types.IpVersion.UndefinedIpVersion"/>.
                /// </summary>
                public const string UndefinedIpVersion = "UNDEFINED_IP_VERSION";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.RouterInterface.Types.IpVersion.Ipv4"/>.
                /// </summary>
                public const string Ipv4 = "IPV4";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.RouterInterface.Types.IpVersion.Ipv6"/>.
                /// </summary>
                public const string Ipv6 = "IPV6";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.RouterInterface.Types.ManagementType"/> enum.
            /// </summary>
            public static class ManagementType
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.RouterInterface.Types.ManagementType.UndefinedManagementType"/>
                /// .
                /// </summary>
                public const string UndefinedManagementType = "UNDEFINED_MANAGEMENT_TYPE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.RouterInterface.Types.ManagementType.ManagedByAttachment"/>
                /// .
                /// </summary>
                public const string ManagedByAttachment = "MANAGED_BY_ATTACHMENT";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.RouterInterface.Types.ManagementType.ManagedByUser"/>.
                /// </summary>
                public const string ManagedByUser = "MANAGED_BY_USER";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.RouterNat"/> message.
        /// </summary>
        public static class RouterNat
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.RouterNat.Types.AutoNetworkTier"/> enum.
            /// </summary>
            public static class AutoNetworkTier
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.RouterNat.Types.AutoNetworkTier.UndefinedAutoNetworkTier"/>
                /// .
                /// </summary>
                public const string UndefinedAutoNetworkTier = "UNDEFINED_AUTO_NETWORK_TIER";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.RouterNat.Types.AutoNetworkTier.FixedStandard"/>.
                /// </summary>
                public const string FixedStandard = "FIXED_STANDARD";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.RouterNat.Types.AutoNetworkTier.Premium"/>.
                /// </summary>
                public const string Premium = "PREMIUM";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.RouterNat.Types.AutoNetworkTier.Standard"/>.
                /// </summary>
                public const string Standard = "STANDARD";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.RouterNat.Types.AutoNetworkTier.StandardOverridesFixedStandard"/>
                /// .
                /// </summary>
                public const string StandardOverridesFixedStandard = "STANDARD_OVERRIDES_FIXED_STANDARD";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.RouterNat.Types.EndpointTypes"/> enum.
            /// </summary>
            public static class EndpointTypes
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.RouterNat.Types.EndpointTypes.UndefinedEndpointTypes"/>.
                /// </summary>
                public const string UndefinedEndpointTypes = "UNDEFINED_ENDPOINT_TYPES";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.RouterNat.Types.EndpointTypes.EndpointTypeManagedProxyLb"/>
                /// .
                /// </summary>
                public const string EndpointTypeManagedProxyLb = "ENDPOINT_TYPE_MANAGED_PROXY_LB";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.RouterNat.Types.EndpointTypes.Wg"/>.
                /// </summary>
                public const string Wg = "ENDPOINT_TYPE_SWG";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.RouterNat.Types.EndpointTypes.EndpointTypeVm"/>.
                /// </summary>
                public const string EndpointTypeVm = "ENDPOINT_TYPE_VM";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.RouterNat.Types.NatIpAllocateOption"/> enum.
            /// </summary>
            public static class NatIpAllocateOption
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.RouterNat.Types.NatIpAllocateOption.UndefinedNatIpAllocateOption"/>
                /// .
                /// </summary>
                public const string UndefinedNatIpAllocateOption = "UNDEFINED_NAT_IP_ALLOCATE_OPTION";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.RouterNat.Types.NatIpAllocateOption.AutoOnly"/>.
                /// </summary>
                public const string AutoOnly = "AUTO_ONLY";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.RouterNat.Types.NatIpAllocateOption.ManualOnly"/>.
                /// </summary>
                public const string ManualOnly = "MANUAL_ONLY";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.RouterNat.Types.SourceSubnetworkIpRangesToNat"/> enum.
            /// </summary>
            public static class SourceSubnetworkIpRangesToNat
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.RouterNat.Types.SourceSubnetworkIpRangesToNat.UndefinedSourceSubnetworkIpRangesToNat"/>
                /// .
                /// </summary>
                public const string UndefinedSourceSubnetworkIpRangesToNat = "UNDEFINED_SOURCE_SUBNETWORK_IP_RANGES_TO_NAT";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.RouterNat.Types.SourceSubnetworkIpRangesToNat.AllSubnetworksAllIpRanges"/>
                /// .
                /// </summary>
                public const string AllSubnetworksAllIpRanges = "ALL_SUBNETWORKS_ALL_IP_RANGES";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.RouterNat.Types.SourceSubnetworkIpRangesToNat.AllSubnetworksAllPrimaryIpRanges"/>
                /// .
                /// </summary>
                public const string AllSubnetworksAllPrimaryIpRanges = "ALL_SUBNETWORKS_ALL_PRIMARY_IP_RANGES";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.RouterNat.Types.SourceSubnetworkIpRangesToNat.ListOfSubnetworks"/>
                /// .
                /// </summary>
                public const string ListOfSubnetworks = "LIST_OF_SUBNETWORKS";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.RouterNat.Types.SourceSubnetworkIpRangesToNat64"/> enum.
            /// </summary>
            public static class SourceSubnetworkIpRangesToNat64
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.RouterNat.Types.SourceSubnetworkIpRangesToNat64.UndefinedSourceSubnetworkIpRangesToNat64"/>
                /// .
                /// </summary>
                public const string UndefinedSourceSubnetworkIpRangesToNat64 = "UNDEFINED_SOURCE_SUBNETWORK_IP_RANGES_TO_NAT64";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.RouterNat.Types.SourceSubnetworkIpRangesToNat64.AllIpv6Subnetworks"/>
                /// .
                /// </summary>
                public const string AllIpv6Subnetworks = "ALL_IPV6_SUBNETWORKS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.RouterNat.Types.SourceSubnetworkIpRangesToNat64.ListOfIpv6Subnetworks"/>
                /// .
                /// </summary>
                public const string ListOfIpv6Subnetworks = "LIST_OF_IPV6_SUBNETWORKS";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.RouterNat.Types.Type"/> enum.
            /// </summary>
            public static class Type
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.RouterNat.Types.Type.UndefinedType"/>.
                /// </summary>
                public const string UndefinedType = "UNDEFINED_TYPE";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.RouterNat.Types.Type.Private"/>.
                /// </summary>
                public const string Private = "PRIVATE";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.RouterNat.Types.Type.Public"/>.
                /// </summary>
                public const string Public = "PUBLIC";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.RouterNatLogConfig"/>
        /// message.
        /// </summary>
        public static class RouterNatLogConfig
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.RouterNatLogConfig.Types.Filter"/> enum.
            /// </summary>
            public static class Filter
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.RouterNatLogConfig.Types.Filter.UndefinedFilter"/>.
                /// </summary>
                public const string UndefinedFilter = "UNDEFINED_FILTER";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.RouterNatLogConfig.Types.Filter.All"/>.
                /// </summary>
                public const string All = "ALL";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.RouterNatLogConfig.Types.Filter.ErrorsOnly"/>.
                /// </summary>
                public const string ErrorsOnly = "ERRORS_ONLY";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.RouterNatLogConfig.Types.Filter.TranslationsOnly"/>.
                /// </summary>
                public const string TranslationsOnly = "TRANSLATIONS_ONLY";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.RouterNatSubnetworkToNat"/>
        /// message.
        /// </summary>
        public static class RouterNatSubnetworkToNat
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.RouterNatSubnetworkToNat.Types.SourceIpRangesToNat"/> enum.
            /// </summary>
            public static class SourceIpRangesToNat
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.RouterNatSubnetworkToNat.Types.SourceIpRangesToNat.UndefinedSourceIpRangesToNat"/>
                /// .
                /// </summary>
                public const string UndefinedSourceIpRangesToNat = "UNDEFINED_SOURCE_IP_RANGES_TO_NAT";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.RouterNatSubnetworkToNat.Types.SourceIpRangesToNat.AllIpRanges"/>
                /// .
                /// </summary>
                public const string AllIpRanges = "ALL_IP_RANGES";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.RouterNatSubnetworkToNat.Types.SourceIpRangesToNat.ListOfSecondaryIpRanges"/>
                /// .
                /// </summary>
                public const string ListOfSecondaryIpRanges = "LIST_OF_SECONDARY_IP_RANGES";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.RouterNatSubnetworkToNat.Types.SourceIpRangesToNat.PrimaryIpRange"/>
                /// .
                /// </summary>
                public const string PrimaryIpRange = "PRIMARY_IP_RANGE";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.RouterStatusBgpPeerStatus"/>
        /// message.
        /// </summary>
        public static class RouterStatusBgpPeerStatus
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.RouterStatusBgpPeerStatus.Types.Status"/> enum.
            /// </summary>
            public static class Status
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.RouterStatusBgpPeerStatus.Types.Status.UndefinedStatus"/>
                /// .
                /// </summary>
                public const string UndefinedStatus = "UNDEFINED_STATUS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.RouterStatusBgpPeerStatus.Types.Status.Down"/>.
                /// </summary>
                public const string Down = "DOWN";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.RouterStatusBgpPeerStatus.Types.Status.Unknown"/>.
                /// </summary>
                public const string Unknown = "UNKNOWN";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.RouterStatusBgpPeerStatus.Types.Status.Up"/>.
                /// </summary>
                public const string Up = "UP";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.RouterStatusBgpPeerStatus.Types.StatusReason"/> enum.
            /// </summary>
            public static class StatusReason
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.RouterStatusBgpPeerStatus.Types.StatusReason.UndefinedStatusReason"/>
                /// .
                /// </summary>
                public const string UndefinedStatusReason = "UNDEFINED_STATUS_REASON";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.RouterStatusBgpPeerStatus.Types.StatusReason.Ipv4PeerOnIpv6OnlyConnection"/>
                /// .
                /// </summary>
                public const string Ipv4PeerOnIpv6OnlyConnection = "IPV4_PEER_ON_IPV6_ONLY_CONNECTION";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.RouterStatusBgpPeerStatus.Types.StatusReason.Ipv6PeerOnIpv4OnlyConnection"/>
                /// .
                /// </summary>
                public const string Ipv6PeerOnIpv4OnlyConnection = "IPV6_PEER_ON_IPV4_ONLY_CONNECTION";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.RouterStatusBgpPeerStatus.Types.StatusReason.Md5AuthInternalProblem"/>
                /// .
                /// </summary>
                public const string Md5AuthInternalProblem = "MD5_AUTH_INTERNAL_PROBLEM";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.RouterStatusBgpPeerStatus.Types.StatusReason.Unspecified"/>
                /// .
                /// </summary>
                public const string Unspecified = "STATUS_REASON_UNSPECIFIED";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.SSLHealthCheck"/> message.
        /// </summary>
        public static class SSLHealthCheck
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.SSLHealthCheck.Types.PortSpecification"/> enum.
            /// </summary>
            public static class PortSpecification
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SSLHealthCheck.Types.PortSpecification.UndefinedPortSpecification"/>
                /// .
                /// </summary>
                public const string UndefinedPortSpecification = "UNDEFINED_PORT_SPECIFICATION";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SSLHealthCheck.Types.PortSpecification.UseFixedPort"/>.
                /// </summary>
                public const string UseFixedPort = "USE_FIXED_PORT";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SSLHealthCheck.Types.PortSpecification.UseNamedPort"/>.
                /// </summary>
                public const string UseNamedPort = "USE_NAMED_PORT";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SSLHealthCheck.Types.PortSpecification.UseServingPort"/>.
                /// </summary>
                public const string UseServingPort = "USE_SERVING_PORT";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.SSLHealthCheck.Types.ProxyHeader"/> enum.
            /// </summary>
            public static class ProxyHeader
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SSLHealthCheck.Types.ProxyHeader.UndefinedProxyHeader"/>.
                /// </summary>
                public const string UndefinedProxyHeader = "UNDEFINED_PROXY_HEADER";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SSLHealthCheck.Types.ProxyHeader.None"/>.
                /// </summary>
                public const string None = "NONE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SSLHealthCheck.Types.ProxyHeader.ProxyV1"/>.
                /// </summary>
                public const string ProxyV1 = "PROXY_V1";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.SavedAttachedDisk"/>
        /// message.
        /// </summary>
        public static class SavedAttachedDisk
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.SavedAttachedDisk.Types.Interface"/> enum.
            /// </summary>
            public static class Interface
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SavedAttachedDisk.Types.Interface.UndefinedInterface"/>.
                /// </summary>
                public const string UndefinedInterface = "UNDEFINED_INTERFACE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SavedAttachedDisk.Types.Interface.Nvme"/>.
                /// </summary>
                public const string Nvme = "NVME";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SavedAttachedDisk.Types.Interface.Scsi"/>.
                /// </summary>
                public const string Scsi = "SCSI";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.SavedAttachedDisk.Types.Mode"/> enum.
            /// </summary>
            public static class Mode
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SavedAttachedDisk.Types.Mode.UndefinedMode"/>.
                /// </summary>
                public const string UndefinedMode = "UNDEFINED_MODE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SavedAttachedDisk.Types.Mode.ReadOnly"/>.
                /// </summary>
                public const string ReadOnly = "READ_ONLY";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SavedAttachedDisk.Types.Mode.ReadWrite"/>.
                /// </summary>
                public const string ReadWrite = "READ_WRITE";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.SavedAttachedDisk.Types.StorageBytesStatus"/> enum.
            /// </summary>
            public static class StorageBytesStatus
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SavedAttachedDisk.Types.StorageBytesStatus.UndefinedStorageBytesStatus"/>
                /// .
                /// </summary>
                public const string UndefinedStorageBytesStatus = "UNDEFINED_STORAGE_BYTES_STATUS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SavedAttachedDisk.Types.StorageBytesStatus.Updating"/>.
                /// </summary>
                public const string Updating = "UPDATING";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SavedAttachedDisk.Types.StorageBytesStatus.UpToDate"/>.
                /// </summary>
                public const string UpToDate = "UP_TO_DATE";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.SavedAttachedDisk.Types.Type"/> enum.
            /// </summary>
            public static class Type
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SavedAttachedDisk.Types.Type.UndefinedType"/>.
                /// </summary>
                public const string UndefinedType = "UNDEFINED_TYPE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SavedAttachedDisk.Types.Type.Persistent"/>.
                /// </summary>
                public const string Persistent = "PERSISTENT";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SavedAttachedDisk.Types.Type.Scratch"/>.
                /// </summary>
                public const string Scratch = "SCRATCH";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.SavedDisk"/> message.
        /// </summary>
        public static class SavedDisk
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.SavedDisk.Types.Architecture"/> enum.
            /// </summary>
            public static class Architecture
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SavedDisk.Types.Architecture.UndefinedArchitecture"/>.
                /// </summary>
                public const string UndefinedArchitecture = "UNDEFINED_ARCHITECTURE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SavedDisk.Types.Architecture.Unspecified"/>.
                /// </summary>
                public const string Unspecified = "ARCHITECTURE_UNSPECIFIED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SavedDisk.Types.Architecture.Arm64"/>.
                /// </summary>
                public const string Arm64 = "ARM64";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SavedDisk.Types.Architecture.X8664"/>.
                /// </summary>
                public const string X8664 = "X86_64";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.SavedDisk.Types.StorageBytesStatus"/> enum.
            /// </summary>
            public static class StorageBytesStatus
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SavedDisk.Types.StorageBytesStatus.UndefinedStorageBytesStatus"/>
                /// .
                /// </summary>
                public const string UndefinedStorageBytesStatus = "UNDEFINED_STORAGE_BYTES_STATUS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SavedDisk.Types.StorageBytesStatus.Updating"/>.
                /// </summary>
                public const string Updating = "UPDATING";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SavedDisk.Types.StorageBytesStatus.UpToDate"/>.
                /// </summary>
                public const string UpToDate = "UP_TO_DATE";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.ScalingScheduleStatus"/>
        /// message.
        /// </summary>
        public static class ScalingScheduleStatus
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.ScalingScheduleStatus.Types.State"/> enum.
            /// </summary>
            public static class State
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ScalingScheduleStatus.Types.State.UndefinedState"/>.
                /// </summary>
                public const string UndefinedState = "UNDEFINED_STATE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ScalingScheduleStatus.Types.State.Active"/>.
                /// </summary>
                public const string Active = "ACTIVE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ScalingScheduleStatus.Types.State.Disabled"/>.
                /// </summary>
                public const string Disabled = "DISABLED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ScalingScheduleStatus.Types.State.Obsolete"/>.
                /// </summary>
                public const string Obsolete = "OBSOLETE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ScalingScheduleStatus.Types.State.Ready"/>.
                /// </summary>
                public const string Ready = "READY";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.Scheduling"/> message.
        /// </summary>
        public static class Scheduling
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.Scheduling.Types.InstanceTerminationAction"/> enum.
            /// </summary>
            public static class InstanceTerminationAction
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Scheduling.Types.InstanceTerminationAction.UndefinedInstanceTerminationAction"/>
                /// .
                /// </summary>
                public const string UndefinedInstanceTerminationAction = "UNDEFINED_INSTANCE_TERMINATION_ACTION";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Scheduling.Types.InstanceTerminationAction.Delete"/>.
                /// </summary>
                public const string Delete = "DELETE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Scheduling.Types.InstanceTerminationAction.Unspecified"/>
                /// .
                /// </summary>
                public const string Unspecified = "INSTANCE_TERMINATION_ACTION_UNSPECIFIED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Scheduling.Types.InstanceTerminationAction.Stop"/>.
                /// </summary>
                public const string Stop = "STOP";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.Scheduling.Types.OnHostMaintenance"/> enum.
            /// </summary>
            public static class OnHostMaintenance
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Scheduling.Types.OnHostMaintenance.UndefinedOnHostMaintenance"/>
                /// .
                /// </summary>
                public const string UndefinedOnHostMaintenance = "UNDEFINED_ON_HOST_MAINTENANCE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Scheduling.Types.OnHostMaintenance.Migrate"/>.
                /// </summary>
                public const string Migrate = "MIGRATE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Scheduling.Types.OnHostMaintenance.Terminate"/>.
                /// </summary>
                public const string Terminate = "TERMINATE";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.Scheduling.Types.ProvisioningModel"/> enum.
            /// </summary>
            public static class ProvisioningModel
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Scheduling.Types.ProvisioningModel.UndefinedProvisioningModel"/>
                /// .
                /// </summary>
                public const string UndefinedProvisioningModel = "UNDEFINED_PROVISIONING_MODEL";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Scheduling.Types.ProvisioningModel.ReservationBound"/>.
                /// </summary>
                public const string ReservationBound = "RESERVATION_BOUND";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Scheduling.Types.ProvisioningModel.Spot"/>.
                /// </summary>
                public const string Spot = "SPOT";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Scheduling.Types.ProvisioningModel.Standard"/>.
                /// </summary>
                public const string Standard = "STANDARD";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.SchedulingNodeAffinity"/>
        /// message.
        /// </summary>
        public static class SchedulingNodeAffinity
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.SchedulingNodeAffinity.Types.Operator"/> enum.
            /// </summary>
            public static class Operator
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SchedulingNodeAffinity.Types.Operator.UndefinedOperator"/>
                /// .
                /// </summary>
                public const string UndefinedOperator = "UNDEFINED_OPERATOR";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SchedulingNodeAffinity.Types.Operator.In"/>.
                /// </summary>
                public const string In = "IN";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SchedulingNodeAffinity.Types.Operator.NotIn"/>.
                /// </summary>
                public const string NotIn = "NOT_IN";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SchedulingNodeAffinity.Types.Operator.Unspecified"/>.
                /// </summary>
                public const string Unspecified = "OPERATOR_UNSPECIFIED";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.SecurityPolicy"/> message.
        /// </summary>
        public static class SecurityPolicy
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.SecurityPolicy.Types.Type"/> enum.
            /// </summary>
            public static class Type
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SecurityPolicy.Types.Type.UndefinedType"/>.
                /// </summary>
                public const string UndefinedType = "UNDEFINED_TYPE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SecurityPolicy.Types.Type.CloudArmor"/>.
                /// </summary>
                public const string CloudArmor = "CLOUD_ARMOR";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SecurityPolicy.Types.Type.CloudArmorEdge"/>.
                /// </summary>
                public const string CloudArmorEdge = "CLOUD_ARMOR_EDGE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SecurityPolicy.Types.Type.CloudArmorNetwork"/>.
                /// </summary>
                public const string CloudArmorNetwork = "CLOUD_ARMOR_NETWORK";
            }
        }

        /// <summary>
        /// Container class for enums within the
        /// <see cref="global::Google.Cloud.Compute.V1.SecurityPolicyAdaptiveProtectionConfigLayer7DdosDefenseConfig"/>
        /// message.
        /// </summary>
        public static class SecurityPolicyAdaptiveProtectionConfigLayer7DdosDefenseConfig
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.SecurityPolicyAdaptiveProtectionConfigLayer7DdosDefenseConfig.Types.RuleVisibility"/>
            ///  enum.
            /// </summary>
            public static class RuleVisibility
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SecurityPolicyAdaptiveProtectionConfigLayer7DdosDefenseConfig.Types.RuleVisibility.UndefinedRuleVisibility"/>
                /// .
                /// </summary>
                public const string UndefinedRuleVisibility = "UNDEFINED_RULE_VISIBILITY";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SecurityPolicyAdaptiveProtectionConfigLayer7DdosDefenseConfig.Types.RuleVisibility.Premium"/>
                /// .
                /// </summary>
                public const string Premium = "PREMIUM";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SecurityPolicyAdaptiveProtectionConfigLayer7DdosDefenseConfig.Types.RuleVisibility.Standard"/>
                /// .
                /// </summary>
                public const string Standard = "STANDARD";
            }
        }

        /// <summary>
        /// Container class for enums within the
        /// <see cref="global::Google.Cloud.Compute.V1.SecurityPolicyAdaptiveProtectionConfigLayer7DdosDefenseConfigThresholdConfigTrafficGranularityConfig"/>
        ///  message.
        /// </summary>
        public static class SecurityPolicyAdaptiveProtectionConfigLayer7DdosDefenseConfigThresholdConfigTrafficGranularityConfig
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.SecurityPolicyAdaptiveProtectionConfigLayer7DdosDefenseConfigThresholdConfigTrafficGranularityConfig.Types.Type"/>
            ///  enum.
            /// </summary>
            public static class Type
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SecurityPolicyAdaptiveProtectionConfigLayer7DdosDefenseConfigThresholdConfigTrafficGranularityConfig.Types.Type.UndefinedType"/>
                /// .
                /// </summary>
                public const string UndefinedType = "UNDEFINED_TYPE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SecurityPolicyAdaptiveProtectionConfigLayer7DdosDefenseConfigThresholdConfigTrafficGranularityConfig.Types.Type.HttpHeaderHost"/>
                /// .
                /// </summary>
                public const string HttpHeaderHost = "HTTP_HEADER_HOST";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SecurityPolicyAdaptiveProtectionConfigLayer7DdosDefenseConfigThresholdConfigTrafficGranularityConfig.Types.Type.HttpPath"/>
                /// .
                /// </summary>
                public const string HttpPath = "HTTP_PATH";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SecurityPolicyAdaptiveProtectionConfigLayer7DdosDefenseConfigThresholdConfigTrafficGranularityConfig.Types.Type.UnspecifiedType"/>
                /// .
                /// </summary>
                public const string UnspecifiedType = "UNSPECIFIED_TYPE";
            }
        }

        /// <summary>
        /// Container class for enums within the
        /// <see cref="global::Google.Cloud.Compute.V1.SecurityPolicyAdvancedOptionsConfig"/> message.
        /// </summary>
        public static class SecurityPolicyAdvancedOptionsConfig
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.SecurityPolicyAdvancedOptionsConfig.Types.JsonParsing"/>
            /// enum.
            /// </summary>
            public static class JsonParsing
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SecurityPolicyAdvancedOptionsConfig.Types.JsonParsing.UndefinedJsonParsing"/>
                /// .
                /// </summary>
                public const string UndefinedJsonParsing = "UNDEFINED_JSON_PARSING";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SecurityPolicyAdvancedOptionsConfig.Types.JsonParsing.Disabled"/>
                /// .
                /// </summary>
                public const string Disabled = "DISABLED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SecurityPolicyAdvancedOptionsConfig.Types.JsonParsing.Standard"/>
                /// .
                /// </summary>
                public const string Standard = "STANDARD";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SecurityPolicyAdvancedOptionsConfig.Types.JsonParsing.StandardWithGraphql"/>
                /// .
                /// </summary>
                public const string StandardWithGraphql = "STANDARD_WITH_GRAPHQL";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.SecurityPolicyAdvancedOptionsConfig.Types.LogLevel"/> enum.
            /// </summary>
            public static class LogLevel
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SecurityPolicyAdvancedOptionsConfig.Types.LogLevel.UndefinedLogLevel"/>
                /// .
                /// </summary>
                public const string UndefinedLogLevel = "UNDEFINED_LOG_LEVEL";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SecurityPolicyAdvancedOptionsConfig.Types.LogLevel.Normal"/>
                /// .
                /// </summary>
                public const string Normal = "NORMAL";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SecurityPolicyAdvancedOptionsConfig.Types.LogLevel.Verbose"/>
                /// .
                /// </summary>
                public const string Verbose = "VERBOSE";
            }
        }

        /// <summary>
        /// Container class for enums within the
        /// <see cref="global::Google.Cloud.Compute.V1.SecurityPolicyDdosProtectionConfig"/> message.
        /// </summary>
        public static class SecurityPolicyDdosProtectionConfig
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.SecurityPolicyDdosProtectionConfig.Types.DdosProtection"/>
            /// enum.
            /// </summary>
            public static class DdosProtection
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SecurityPolicyDdosProtectionConfig.Types.DdosProtection.UndefinedDdosProtection"/>
                /// .
                /// </summary>
                public const string UndefinedDdosProtection = "UNDEFINED_DDOS_PROTECTION";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SecurityPolicyDdosProtectionConfig.Types.DdosProtection.Advanced"/>
                /// .
                /// </summary>
                public const string Advanced = "ADVANCED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SecurityPolicyDdosProtectionConfig.Types.DdosProtection.AdvancedPreview"/>
                /// .
                /// </summary>
                public const string AdvancedPreview = "ADVANCED_PREVIEW";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SecurityPolicyDdosProtectionConfig.Types.DdosProtection.Standard"/>
                /// .
                /// </summary>
                public const string Standard = "STANDARD";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.SecurityPolicyRuleMatcher"/>
        /// message.
        /// </summary>
        public static class SecurityPolicyRuleMatcher
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.SecurityPolicyRuleMatcher.Types.VersionedExpr"/> enum.
            /// </summary>
            public static class VersionedExpr
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SecurityPolicyRuleMatcher.Types.VersionedExpr.UndefinedVersionedExpr"/>
                /// .
                /// </summary>
                public const string UndefinedVersionedExpr = "UNDEFINED_VERSIONED_EXPR";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SecurityPolicyRuleMatcher.Types.VersionedExpr.SrcIpsV1"/>
                /// .
                /// </summary>
                public const string SrcIpsV1 = "SRC_IPS_V1";
            }
        }

        /// <summary>
        /// Container class for enums within the
        /// <see cref="global::Google.Cloud.Compute.V1.SecurityPolicyRulePreconfiguredWafConfigExclusionFieldParams"/>
        /// message.
        /// </summary>
        public static class SecurityPolicyRulePreconfiguredWafConfigExclusionFieldParams
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.SecurityPolicyRulePreconfiguredWafConfigExclusionFieldParams.Types.Op"/>
            ///  enum.
            /// </summary>
            public static class Op
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SecurityPolicyRulePreconfiguredWafConfigExclusionFieldParams.Types.Op.UndefinedOp"/>
                /// .
                /// </summary>
                public const string UndefinedOp = "UNDEFINED_OP";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SecurityPolicyRulePreconfiguredWafConfigExclusionFieldParams.Types.Op.Contains"/>
                /// .
                /// </summary>
                public const string Contains = "CONTAINS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SecurityPolicyRulePreconfiguredWafConfigExclusionFieldParams.Types.Op.EndsWith"/>
                /// .
                /// </summary>
                public const string EndsWith = "ENDS_WITH";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SecurityPolicyRulePreconfiguredWafConfigExclusionFieldParams.Types.Op.Equals"/>
                /// .
                /// </summary>
                public const string Equals_ = "EQUALS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SecurityPolicyRulePreconfiguredWafConfigExclusionFieldParams.Types.Op.EqualsAny"/>
                /// .
                /// </summary>
                public const string EqualsAny = "EQUALS_ANY";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SecurityPolicyRulePreconfiguredWafConfigExclusionFieldParams.Types.Op.StartsWith"/>
                /// .
                /// </summary>
                public const string StartsWith = "STARTS_WITH";
            }
        }

        /// <summary>
        /// Container class for enums within the
        /// <see cref="global::Google.Cloud.Compute.V1.SecurityPolicyRuleRateLimitOptions"/> message.
        /// </summary>
        public static class SecurityPolicyRuleRateLimitOptions
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.SecurityPolicyRuleRateLimitOptions.Types.EnforceOnKey"/>
            /// enum.
            /// </summary>
            public static class EnforceOnKey
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SecurityPolicyRuleRateLimitOptions.Types.EnforceOnKey.UndefinedEnforceOnKey"/>
                /// .
                /// </summary>
                public const string UndefinedEnforceOnKey = "UNDEFINED_ENFORCE_ON_KEY";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SecurityPolicyRuleRateLimitOptions.Types.EnforceOnKey.All"/>
                /// .
                /// </summary>
                public const string All = "ALL";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SecurityPolicyRuleRateLimitOptions.Types.EnforceOnKey.HttpCookie"/>
                /// .
                /// </summary>
                public const string HttpCookie = "HTTP_COOKIE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SecurityPolicyRuleRateLimitOptions.Types.EnforceOnKey.HttpHeader"/>
                /// .
                /// </summary>
                public const string HttpHeader = "HTTP_HEADER";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SecurityPolicyRuleRateLimitOptions.Types.EnforceOnKey.HttpPath"/>
                /// .
                /// </summary>
                public const string HttpPath = "HTTP_PATH";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SecurityPolicyRuleRateLimitOptions.Types.EnforceOnKey.Ip"/>
                /// .
                /// </summary>
                public const string Ip = "IP";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SecurityPolicyRuleRateLimitOptions.Types.EnforceOnKey.RegionCode"/>
                /// .
                /// </summary>
                public const string RegionCode = "REGION_CODE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SecurityPolicyRuleRateLimitOptions.Types.EnforceOnKey.Sni"/>
                /// .
                /// </summary>
                public const string Sni = "SNI";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SecurityPolicyRuleRateLimitOptions.Types.EnforceOnKey.TlsJa3Fingerprint"/>
                /// .
                /// </summary>
                public const string TlsJa3Fingerprint = "TLS_JA3_FINGERPRINT";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SecurityPolicyRuleRateLimitOptions.Types.EnforceOnKey.TlsJa4Fingerprint"/>
                /// .
                /// </summary>
                public const string TlsJa4Fingerprint = "TLS_JA4_FINGERPRINT";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SecurityPolicyRuleRateLimitOptions.Types.EnforceOnKey.UserIp"/>
                /// .
                /// </summary>
                public const string UserIp = "USER_IP";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SecurityPolicyRuleRateLimitOptions.Types.EnforceOnKey.XffIp"/>
                /// .
                /// </summary>
                public const string XffIp = "XFF_IP";
            }
        }

        /// <summary>
        /// Container class for enums within the
        /// <see cref="global::Google.Cloud.Compute.V1.SecurityPolicyRuleRateLimitOptionsEnforceOnKeyConfig"/> message.
        /// </summary>
        public static class SecurityPolicyRuleRateLimitOptionsEnforceOnKeyConfig
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.SecurityPolicyRuleRateLimitOptionsEnforceOnKeyConfig.Types.EnforceOnKeyType"/>
            ///  enum.
            /// </summary>
            public static class EnforceOnKeyType
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SecurityPolicyRuleRateLimitOptionsEnforceOnKeyConfig.Types.EnforceOnKeyType.UndefinedEnforceOnKeyType"/>
                /// .
                /// </summary>
                public const string UndefinedEnforceOnKeyType = "UNDEFINED_ENFORCE_ON_KEY_TYPE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SecurityPolicyRuleRateLimitOptionsEnforceOnKeyConfig.Types.EnforceOnKeyType.All"/>
                /// .
                /// </summary>
                public const string All = "ALL";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SecurityPolicyRuleRateLimitOptionsEnforceOnKeyConfig.Types.EnforceOnKeyType.HttpCookie"/>
                /// .
                /// </summary>
                public const string HttpCookie = "HTTP_COOKIE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SecurityPolicyRuleRateLimitOptionsEnforceOnKeyConfig.Types.EnforceOnKeyType.HttpHeader"/>
                /// .
                /// </summary>
                public const string HttpHeader = "HTTP_HEADER";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SecurityPolicyRuleRateLimitOptionsEnforceOnKeyConfig.Types.EnforceOnKeyType.HttpPath"/>
                /// .
                /// </summary>
                public const string HttpPath = "HTTP_PATH";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SecurityPolicyRuleRateLimitOptionsEnforceOnKeyConfig.Types.EnforceOnKeyType.Ip"/>
                /// .
                /// </summary>
                public const string Ip = "IP";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SecurityPolicyRuleRateLimitOptionsEnforceOnKeyConfig.Types.EnforceOnKeyType.RegionCode"/>
                /// .
                /// </summary>
                public const string RegionCode = "REGION_CODE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SecurityPolicyRuleRateLimitOptionsEnforceOnKeyConfig.Types.EnforceOnKeyType.Sni"/>
                /// .
                /// </summary>
                public const string Sni = "SNI";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SecurityPolicyRuleRateLimitOptionsEnforceOnKeyConfig.Types.EnforceOnKeyType.TlsJa3Fingerprint"/>
                /// .
                /// </summary>
                public const string TlsJa3Fingerprint = "TLS_JA3_FINGERPRINT";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SecurityPolicyRuleRateLimitOptionsEnforceOnKeyConfig.Types.EnforceOnKeyType.TlsJa4Fingerprint"/>
                /// .
                /// </summary>
                public const string TlsJa4Fingerprint = "TLS_JA4_FINGERPRINT";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SecurityPolicyRuleRateLimitOptionsEnforceOnKeyConfig.Types.EnforceOnKeyType.UserIp"/>
                /// .
                /// </summary>
                public const string UserIp = "USER_IP";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SecurityPolicyRuleRateLimitOptionsEnforceOnKeyConfig.Types.EnforceOnKeyType.XffIp"/>
                /// .
                /// </summary>
                public const string XffIp = "XFF_IP";
            }
        }

        /// <summary>
        /// Container class for enums within the
        /// <see cref="global::Google.Cloud.Compute.V1.SecurityPolicyRuleRedirectOptions"/> message.
        /// </summary>
        public static class SecurityPolicyRuleRedirectOptions
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.SecurityPolicyRuleRedirectOptions.Types.Type"/> enum.
            /// </summary>
            public static class Type
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SecurityPolicyRuleRedirectOptions.Types.Type.UndefinedType"/>
                /// .
                /// </summary>
                public const string UndefinedType = "UNDEFINED_TYPE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SecurityPolicyRuleRedirectOptions.Types.Type.External302"/>
                /// .
                /// </summary>
                public const string External302 = "EXTERNAL_302";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SecurityPolicyRuleRedirectOptions.Types.Type.GoogleRecaptcha"/>
                /// .
                /// </summary>
                public const string GoogleRecaptcha = "GOOGLE_RECAPTCHA";
            }
        }

        /// <summary>
        /// Container class for enums within the
        /// <see cref="global::Google.Cloud.Compute.V1.SecurityPolicyUserDefinedField"/> message.
        /// </summary>
        public static class SecurityPolicyUserDefinedField
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.SecurityPolicyUserDefinedField.Types.Base"/> enum.
            /// </summary>
            public static class Base
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SecurityPolicyUserDefinedField.Types.Base.UndefinedBase"/>
                /// .
                /// </summary>
                public const string UndefinedBase = "UNDEFINED_BASE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SecurityPolicyUserDefinedField.Types.Base.Ipv4"/>.
                /// </summary>
                public const string Ipv4 = "IPV4";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SecurityPolicyUserDefinedField.Types.Base.Ipv6"/>.
                /// </summary>
                public const string Ipv6 = "IPV6";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SecurityPolicyUserDefinedField.Types.Base.Tcp"/>.
                /// </summary>
                public const string Tcp = "TCP";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SecurityPolicyUserDefinedField.Types.Base.Udp"/>.
                /// </summary>
                public const string Udp = "UDP";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.ServerBinding"/> message.
        /// </summary>
        public static class ServerBinding
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.ServerBinding.Types.Type"/> enum.
            /// </summary>
            public static class Type
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ServerBinding.Types.Type.UndefinedType"/>.
                /// </summary>
                public const string UndefinedType = "UNDEFINED_TYPE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ServerBinding.Types.Type.RestartNodeOnAnyServer"/>.
                /// </summary>
                public const string RestartNodeOnAnyServer = "RESTART_NODE_ON_ANY_SERVER";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ServerBinding.Types.Type.RestartNodeOnMinimalServers"/>.
                /// </summary>
                public const string RestartNodeOnMinimalServers = "RESTART_NODE_ON_MINIMAL_SERVERS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ServerBinding.Types.Type.ServerBindingTypeUnspecified"/>.
                /// </summary>
                public const string ServerBindingTypeUnspecified = "SERVER_BINDING_TYPE_UNSPECIFIED";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.ServiceAttachment"/>
        /// message.
        /// </summary>
        public static class ServiceAttachment
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.ServiceAttachment.Types.ConnectionPreference"/> enum.
            /// </summary>
            public static class ConnectionPreference
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ServiceAttachment.Types.ConnectionPreference.UndefinedConnectionPreference"/>
                /// .
                /// </summary>
                public const string UndefinedConnectionPreference = "UNDEFINED_CONNECTION_PREFERENCE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ServiceAttachment.Types.ConnectionPreference.AcceptAutomatic"/>
                /// .
                /// </summary>
                public const string AcceptAutomatic = "ACCEPT_AUTOMATIC";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ServiceAttachment.Types.ConnectionPreference.AcceptManual"/>
                /// .
                /// </summary>
                public const string AcceptManual = "ACCEPT_MANUAL";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ServiceAttachment.Types.ConnectionPreference.Unspecified"/>
                /// .
                /// </summary>
                public const string Unspecified = "CONNECTION_PREFERENCE_UNSPECIFIED";
            }
        }

        /// <summary>
        /// Container class for enums within the
        /// <see cref="global::Google.Cloud.Compute.V1.ServiceAttachmentConnectedEndpoint"/> message.
        /// </summary>
        public static class ServiceAttachmentConnectedEndpoint
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.ServiceAttachmentConnectedEndpoint.Types.Status"/> enum.
            /// </summary>
            public static class Status
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ServiceAttachmentConnectedEndpoint.Types.Status.UndefinedStatus"/>
                /// .
                /// </summary>
                public const string UndefinedStatus = "UNDEFINED_STATUS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ServiceAttachmentConnectedEndpoint.Types.Status.Accepted"/>
                /// .
                /// </summary>
                public const string Accepted = "ACCEPTED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ServiceAttachmentConnectedEndpoint.Types.Status.Closed"/>
                /// .
                /// </summary>
                public const string Closed = "CLOSED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ServiceAttachmentConnectedEndpoint.Types.Status.NeedsAttention"/>
                /// .
                /// </summary>
                public const string NeedsAttention = "NEEDS_ATTENTION";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ServiceAttachmentConnectedEndpoint.Types.Status.Pending"/>
                /// .
                /// </summary>
                public const string Pending = "PENDING";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ServiceAttachmentConnectedEndpoint.Types.Status.Rejected"/>
                /// .
                /// </summary>
                public const string Rejected = "REJECTED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ServiceAttachmentConnectedEndpoint.Types.Status.Unspecified"/>
                /// .
                /// </summary>
                public const string Unspecified = "STATUS_UNSPECIFIED";
            }
        }

        /// <summary>
        /// Container class for enums within the
        /// <see cref="global::Google.Cloud.Compute.V1.SetCommonInstanceMetadataOperationMetadataPerLocationOperationInfo"/>
        ///  message.
        /// </summary>
        public static class SetCommonInstanceMetadataOperationMetadataPerLocationOperationInfo
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.SetCommonInstanceMetadataOperationMetadataPerLocationOperationInfo.Types.State"/>
            ///  enum.
            /// </summary>
            public static class State
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SetCommonInstanceMetadataOperationMetadataPerLocationOperationInfo.Types.State.UndefinedState"/>
                /// .
                /// </summary>
                public const string UndefinedState = "UNDEFINED_STATE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SetCommonInstanceMetadataOperationMetadataPerLocationOperationInfo.Types.State.Abandoned"/>
                /// .
                /// </summary>
                public const string Abandoned = "ABANDONED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SetCommonInstanceMetadataOperationMetadataPerLocationOperationInfo.Types.State.Done"/>
                /// .
                /// </summary>
                public const string Done = "DONE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SetCommonInstanceMetadataOperationMetadataPerLocationOperationInfo.Types.State.Failed"/>
                /// .
                /// </summary>
                public const string Failed = "FAILED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SetCommonInstanceMetadataOperationMetadataPerLocationOperationInfo.Types.State.Propagated"/>
                /// .
                /// </summary>
                public const string Propagated = "PROPAGATED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SetCommonInstanceMetadataOperationMetadataPerLocationOperationInfo.Types.State.Propagating"/>
                /// .
                /// </summary>
                public const string Propagating = "PROPAGATING";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SetCommonInstanceMetadataOperationMetadataPerLocationOperationInfo.Types.State.Unspecified"/>
                /// .
                /// </summary>
                public const string Unspecified = "UNSPECIFIED";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.ShareSettings"/> message.
        /// </summary>
        public static class ShareSettings
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.ShareSettings.Types.ShareType"/> enum.
            /// </summary>
            public static class ShareType
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ShareSettings.Types.ShareType.UndefinedShareType"/>.
                /// </summary>
                public const string UndefinedShareType = "UNDEFINED_SHARE_TYPE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ShareSettings.Types.ShareType.Local"/>.
                /// </summary>
                public const string Local = "LOCAL";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ShareSettings.Types.ShareType.Organization"/>.
                /// </summary>
                public const string Organization = "ORGANIZATION";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ShareSettings.Types.ShareType.Unspecified"/>.
                /// </summary>
                public const string Unspecified = "SHARE_TYPE_UNSPECIFIED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.ShareSettings.Types.ShareType.SpecificProjects"/>.
                /// </summary>
                public const string SpecificProjects = "SPECIFIC_PROJECTS";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.Snapshot"/> message.
        /// </summary>
        public static class Snapshot
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.Snapshot.Types.Architecture"/> enum.
            /// </summary>
            public static class Architecture
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Snapshot.Types.Architecture.UndefinedArchitecture"/>.
                /// </summary>
                public const string UndefinedArchitecture = "UNDEFINED_ARCHITECTURE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Snapshot.Types.Architecture.Unspecified"/>.
                /// </summary>
                public const string Unspecified = "ARCHITECTURE_UNSPECIFIED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Snapshot.Types.Architecture.Arm64"/>.
                /// </summary>
                public const string Arm64 = "ARM64";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Snapshot.Types.Architecture.X8664"/>.
                /// </summary>
                public const string X8664 = "X86_64";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.Snapshot.Types.SnapshotType"/> enum.
            /// </summary>
            public static class SnapshotType
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Snapshot.Types.SnapshotType.UndefinedSnapshotType"/>.
                /// </summary>
                public const string UndefinedSnapshotType = "UNDEFINED_SNAPSHOT_TYPE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Snapshot.Types.SnapshotType.Archive"/>.
                /// </summary>
                public const string Archive = "ARCHIVE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Snapshot.Types.SnapshotType.Standard"/>.
                /// </summary>
                public const string Standard = "STANDARD";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.Snapshot.Types.Status"/> enum.
            /// </summary>
            public static class Status
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Snapshot.Types.Status.UndefinedStatus"/>.
                /// </summary>
                public const string UndefinedStatus = "UNDEFINED_STATUS";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.Snapshot.Types.Status.Creating"/>.
                /// </summary>
                public const string Creating = "CREATING";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.Snapshot.Types.Status.Deleting"/>.
                /// </summary>
                public const string Deleting = "DELETING";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.Snapshot.Types.Status.Failed"/>.
                /// </summary>
                public const string Failed = "FAILED";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.Snapshot.Types.Status.Ready"/>.
                /// </summary>
                public const string Ready = "READY";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.Snapshot.Types.Status.Uploading"/>
                /// .
                /// </summary>
                public const string Uploading = "UPLOADING";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.Snapshot.Types.StorageBytesStatus"/> enum.
            /// </summary>
            public static class StorageBytesStatus
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Snapshot.Types.StorageBytesStatus.UndefinedStorageBytesStatus"/>
                /// .
                /// </summary>
                public const string UndefinedStorageBytesStatus = "UNDEFINED_STORAGE_BYTES_STATUS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Snapshot.Types.StorageBytesStatus.Updating"/>.
                /// </summary>
                public const string Updating = "UPDATING";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Snapshot.Types.StorageBytesStatus.UpToDate"/>.
                /// </summary>
                public const string UpToDate = "UP_TO_DATE";
            }
        }

        /// <summary>
        /// Container class for enums within the
        /// <see cref="global::Google.Cloud.Compute.V1.SnapshotSettingsStorageLocationSettings"/> message.
        /// </summary>
        public static class SnapshotSettingsStorageLocationSettings
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.SnapshotSettingsStorageLocationSettings.Types.Policy"/> enum.
            /// </summary>
            public static class Policy
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SnapshotSettingsStorageLocationSettings.Types.Policy.UndefinedPolicy"/>
                /// .
                /// </summary>
                public const string UndefinedPolicy = "UNDEFINED_POLICY";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SnapshotSettingsStorageLocationSettings.Types.Policy.LocalRegion"/>
                /// .
                /// </summary>
                public const string LocalRegion = "LOCAL_REGION";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SnapshotSettingsStorageLocationSettings.Types.Policy.NearestMultiRegion"/>
                /// .
                /// </summary>
                public const string NearestMultiRegion = "NEAREST_MULTI_REGION";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SnapshotSettingsStorageLocationSettings.Types.Policy.SpecificLocations"/>
                /// .
                /// </summary>
                public const string SpecificLocations = "SPECIFIC_LOCATIONS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SnapshotSettingsStorageLocationSettings.Types.Policy.StorageLocationPolicyUnspecified"/>
                /// .
                /// </summary>
                public const string StorageLocationPolicyUnspecified = "STORAGE_LOCATION_POLICY_UNSPECIFIED";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.SourceInstanceProperties"/>
        /// message.
        /// </summary>
        public static class SourceInstanceProperties
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.SourceInstanceProperties.Types.KeyRevocationActionType"/>
            /// enum.
            /// </summary>
            public static class KeyRevocationActionType
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SourceInstanceProperties.Types.KeyRevocationActionType.UndefinedKeyRevocationActionType"/>
                /// .
                /// </summary>
                public const string UndefinedKeyRevocationActionType = "UNDEFINED_KEY_REVOCATION_ACTION_TYPE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SourceInstanceProperties.Types.KeyRevocationActionType.Unspecified"/>
                /// .
                /// </summary>
                public const string Unspecified = "KEY_REVOCATION_ACTION_TYPE_UNSPECIFIED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SourceInstanceProperties.Types.KeyRevocationActionType.None"/>
                /// .
                /// </summary>
                public const string None = "NONE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SourceInstanceProperties.Types.KeyRevocationActionType.Stop"/>
                /// .
                /// </summary>
                public const string Stop = "STOP";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.SslCertificate"/> message.
        /// </summary>
        public static class SslCertificate
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.SslCertificate.Types.Type"/> enum.
            /// </summary>
            public static class Type
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SslCertificate.Types.Type.UndefinedType"/>.
                /// </summary>
                public const string UndefinedType = "UNDEFINED_TYPE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SslCertificate.Types.Type.Managed"/>.
                /// </summary>
                public const string Managed = "MANAGED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SslCertificate.Types.Type.SelfManaged"/>.
                /// </summary>
                public const string SelfManaged = "SELF_MANAGED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SslCertificate.Types.Type.Unspecified"/>.
                /// </summary>
                public const string Unspecified = "TYPE_UNSPECIFIED";
            }
        }

        /// <summary>
        /// Container class for enums within the
        /// <see cref="global::Google.Cloud.Compute.V1.SslCertificateManagedSslCertificate"/> message.
        /// </summary>
        public static class SslCertificateManagedSslCertificate
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.SslCertificateManagedSslCertificate.Types.Status"/> enum.
            /// </summary>
            public static class Status
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SslCertificateManagedSslCertificate.Types.Status.UndefinedStatus"/>
                /// .
                /// </summary>
                public const string UndefinedStatus = "UNDEFINED_STATUS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SslCertificateManagedSslCertificate.Types.Status.Active"/>
                /// .
                /// </summary>
                public const string Active = "ACTIVE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SslCertificateManagedSslCertificate.Types.Status.ManagedCertificateStatusUnspecified"/>
                /// .
                /// </summary>
                public const string ManagedCertificateStatusUnspecified = "MANAGED_CERTIFICATE_STATUS_UNSPECIFIED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SslCertificateManagedSslCertificate.Types.Status.Provisioning"/>
                /// .
                /// </summary>
                public const string Provisioning = "PROVISIONING";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SslCertificateManagedSslCertificate.Types.Status.ProvisioningFailed"/>
                /// .
                /// </summary>
                public const string ProvisioningFailed = "PROVISIONING_FAILED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SslCertificateManagedSslCertificate.Types.Status.ProvisioningFailedPermanently"/>
                /// .
                /// </summary>
                public const string ProvisioningFailedPermanently = "PROVISIONING_FAILED_PERMANENTLY";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SslCertificateManagedSslCertificate.Types.Status.RenewalFailed"/>
                /// .
                /// </summary>
                public const string RenewalFailed = "RENEWAL_FAILED";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.SslPolicy"/> message.
        /// </summary>
        public static class SslPolicy
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.SslPolicy.Types.MinTlsVersion"/> enum.
            /// </summary>
            public static class MinTlsVersion
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SslPolicy.Types.MinTlsVersion.UndefinedMinTlsVersion"/>.
                /// </summary>
                public const string UndefinedMinTlsVersion = "UNDEFINED_MIN_TLS_VERSION";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SslPolicy.Types.MinTlsVersion.Tls10"/>.
                /// </summary>
                public const string Tls10 = "TLS_1_0";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SslPolicy.Types.MinTlsVersion.Tls11"/>.
                /// </summary>
                public const string Tls11 = "TLS_1_1";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SslPolicy.Types.MinTlsVersion.Tls12"/>.
                /// </summary>
                public const string Tls12 = "TLS_1_2";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.SslPolicy.Types.Profile"/> enum.
            /// </summary>
            public static class Profile
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SslPolicy.Types.Profile.UndefinedProfile"/>.
                /// </summary>
                public const string UndefinedProfile = "UNDEFINED_PROFILE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SslPolicy.Types.Profile.Compatible"/>.
                /// </summary>
                public const string Compatible = "COMPATIBLE";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.SslPolicy.Types.Profile.Custom"/>.
                /// </summary>
                public const string Custom = "CUSTOM";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.SslPolicy.Types.Profile.Modern"/>.
                /// </summary>
                public const string Modern = "MODERN";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SslPolicy.Types.Profile.Restricted"/>.
                /// </summary>
                public const string Restricted = "RESTRICTED";
            }
        }

        /// <summary>
        /// Container class for enums within the
        /// <see cref="global::Google.Cloud.Compute.V1.StatefulPolicyPreservedStateDiskDevice"/> message.
        /// </summary>
        public static class StatefulPolicyPreservedStateDiskDevice
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.StatefulPolicyPreservedStateDiskDevice.Types.AutoDelete"/>
            /// enum.
            /// </summary>
            public static class AutoDelete
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.StatefulPolicyPreservedStateDiskDevice.Types.AutoDelete.UndefinedAutoDelete"/>
                /// .
                /// </summary>
                public const string UndefinedAutoDelete = "UNDEFINED_AUTO_DELETE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.StatefulPolicyPreservedStateDiskDevice.Types.AutoDelete.Never"/>
                /// .
                /// </summary>
                public const string Never = "NEVER";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.StatefulPolicyPreservedStateDiskDevice.Types.AutoDelete.OnPermanentInstanceDeletion"/>
                /// .
                /// </summary>
                public const string OnPermanentInstanceDeletion = "ON_PERMANENT_INSTANCE_DELETION";
            }
        }

        /// <summary>
        /// Container class for enums within the
        /// <see cref="global::Google.Cloud.Compute.V1.StatefulPolicyPreservedStateNetworkIp"/> message.
        /// </summary>
        public static class StatefulPolicyPreservedStateNetworkIp
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.StatefulPolicyPreservedStateNetworkIp.Types.AutoDelete"/>
            /// enum.
            /// </summary>
            public static class AutoDelete
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.StatefulPolicyPreservedStateNetworkIp.Types.AutoDelete.UndefinedAutoDelete"/>
                /// .
                /// </summary>
                public const string UndefinedAutoDelete = "UNDEFINED_AUTO_DELETE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.StatefulPolicyPreservedStateNetworkIp.Types.AutoDelete.Never"/>
                /// .
                /// </summary>
                public const string Never = "NEVER";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.StatefulPolicyPreservedStateNetworkIp.Types.AutoDelete.OnPermanentInstanceDeletion"/>
                /// .
                /// </summary>
                public const string OnPermanentInstanceDeletion = "ON_PERMANENT_INSTANCE_DELETION";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.StoragePool"/> message.
        /// </summary>
        public static class StoragePool
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.StoragePool.Types.CapacityProvisioningType"/> enum.
            /// </summary>
            public static class CapacityProvisioningType
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.StoragePool.Types.CapacityProvisioningType.UndefinedCapacityProvisioningType"/>
                /// .
                /// </summary>
                public const string UndefinedCapacityProvisioningType = "UNDEFINED_CAPACITY_PROVISIONING_TYPE";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.StoragePool.Types.PerformanceProvisioningType"/> enum.
            /// </summary>
            public static class PerformanceProvisioningType
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.StoragePool.Types.PerformanceProvisioningType.UndefinedPerformanceProvisioningType"/>
                /// .
                /// </summary>
                public const string UndefinedPerformanceProvisioningType = "UNDEFINED_PERFORMANCE_PROVISIONING_TYPE";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.StoragePool.Types.State"/> enum.
            /// </summary>
            public static class State
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.StoragePool.Types.State.UndefinedState"/>.
                /// </summary>
                public const string UndefinedState = "UNDEFINED_STATE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.StoragePool.Types.State.Creating"/>.
                /// </summary>
                public const string Creating = "CREATING";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.StoragePool.Types.State.Deleting"/>.
                /// </summary>
                public const string Deleting = "DELETING";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.StoragePool.Types.State.Failed"/>.
                /// </summary>
                public const string Failed = "FAILED";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.StoragePool.Types.State.Ready"/>.
                /// </summary>
                public const string Ready = "READY";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.StoragePoolDisk"/> message.
        /// </summary>
        public static class StoragePoolDisk
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.StoragePoolDisk.Types.Status"/> enum.
            /// </summary>
            public static class Status
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.StoragePoolDisk.Types.Status.UndefinedStatus"/>.
                /// </summary>
                public const string UndefinedStatus = "UNDEFINED_STATUS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.StoragePoolDisk.Types.Status.Creating"/>.
                /// </summary>
                public const string Creating = "CREATING";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.StoragePoolDisk.Types.Status.Deleting"/>.
                /// </summary>
                public const string Deleting = "DELETING";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.StoragePoolDisk.Types.Status.Failed"/>.
                /// </summary>
                public const string Failed = "FAILED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.StoragePoolDisk.Types.Status.Ready"/>.
                /// </summary>
                public const string Ready = "READY";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.StoragePoolDisk.Types.Status.Restoring"/>.
                /// </summary>
                public const string Restoring = "RESTORING";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.StoragePoolDisk.Types.Status.Unavailable"/>.
                /// </summary>
                public const string Unavailable = "UNAVAILABLE";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.Subnetwork"/> message.
        /// </summary>
        public static class Subnetwork
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.Subnetwork.Types.Ipv6AccessType"/> enum.
            /// </summary>
            public static class Ipv6AccessType
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Subnetwork.Types.Ipv6AccessType.UndefinedIpv6AccessType"/>
                /// .
                /// </summary>
                public const string UndefinedIpv6AccessType = "UNDEFINED_IPV6_ACCESS_TYPE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Subnetwork.Types.Ipv6AccessType.External"/>.
                /// </summary>
                public const string External = "EXTERNAL";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Subnetwork.Types.Ipv6AccessType.Internal"/>.
                /// </summary>
                public const string Internal = "INTERNAL";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Subnetwork.Types.Ipv6AccessType.UnspecifiedIpv6AccessType"/>
                /// .
                /// </summary>
                public const string UnspecifiedIpv6AccessType = "UNSPECIFIED_IPV6_ACCESS_TYPE";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.Subnetwork.Types.Ipv6GceEndpoint"/> enum.
            /// </summary>
            public static class Ipv6GceEndpoint
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Subnetwork.Types.Ipv6GceEndpoint.UndefinedIpv6GceEndpoint"/>
                /// .
                /// </summary>
                public const string UndefinedIpv6GceEndpoint = "UNDEFINED_IPV6_GCE_ENDPOINT";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Subnetwork.Types.Ipv6GceEndpoint.VmAndFr"/>.
                /// </summary>
                public const string VmAndFr = "VM_AND_FR";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Subnetwork.Types.Ipv6GceEndpoint.VmOnly"/>.
                /// </summary>
                public const string VmOnly = "VM_ONLY";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.Subnetwork.Types.PrivateIpv6GoogleAccess"/> enum.
            /// </summary>
            public static class PrivateIpv6GoogleAccess
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Subnetwork.Types.PrivateIpv6GoogleAccess.UndefinedPrivateIpv6GoogleAccess"/>
                /// .
                /// </summary>
                public const string UndefinedPrivateIpv6GoogleAccess = "UNDEFINED_PRIVATE_IPV6_GOOGLE_ACCESS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Subnetwork.Types.PrivateIpv6GoogleAccess.DisableGoogleAccess"/>
                /// .
                /// </summary>
                public const string DisableGoogleAccess = "DISABLE_GOOGLE_ACCESS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Subnetwork.Types.PrivateIpv6GoogleAccess.EnableBidirectionalAccessToGoogle"/>
                /// .
                /// </summary>
                public const string EnableBidirectionalAccessToGoogle = "ENABLE_BIDIRECTIONAL_ACCESS_TO_GOOGLE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Subnetwork.Types.PrivateIpv6GoogleAccess.EnableOutboundVmAccessToGoogle"/>
                /// .
                /// </summary>
                public const string EnableOutboundVmAccessToGoogle = "ENABLE_OUTBOUND_VM_ACCESS_TO_GOOGLE";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.Subnetwork.Types.Purpose"/> enum.
            /// </summary>
            public static class Purpose
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Subnetwork.Types.Purpose.UndefinedPurpose"/>.
                /// </summary>
                public const string UndefinedPurpose = "UNDEFINED_PURPOSE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Subnetwork.Types.Purpose.GlobalManagedProxy"/>.
                /// </summary>
                public const string GlobalManagedProxy = "GLOBAL_MANAGED_PROXY";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Subnetwork.Types.Purpose.InternalHttpsLoadBalancer"/>.
                /// </summary>
                public const string InternalHttpsLoadBalancer = "INTERNAL_HTTPS_LOAD_BALANCER";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Subnetwork.Types.Purpose.PeerMigration"/>.
                /// </summary>
                public const string PeerMigration = "PEER_MIGRATION";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Subnetwork.Types.Purpose.Private"/>.
                /// </summary>
                public const string Private = "PRIVATE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Subnetwork.Types.Purpose.PrivateNat"/>.
                /// </summary>
                public const string PrivateNat = "PRIVATE_NAT";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Subnetwork.Types.Purpose.PrivateRfc1918"/>.
                /// </summary>
                public const string PrivateRfc1918 = "PRIVATE_RFC_1918";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Subnetwork.Types.Purpose.PrivateServiceConnect"/>.
                /// </summary>
                public const string PrivateServiceConnect = "PRIVATE_SERVICE_CONNECT";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Subnetwork.Types.Purpose.RegionalManagedProxy"/>.
                /// </summary>
                public const string RegionalManagedProxy = "REGIONAL_MANAGED_PROXY";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.Subnetwork.Types.Role"/> enum.
            /// </summary>
            public static class Role
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Subnetwork.Types.Role.UndefinedRole"/>.
                /// </summary>
                public const string UndefinedRole = "UNDEFINED_ROLE";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.Subnetwork.Types.Role.Active"/>.
                /// </summary>
                public const string Active = "ACTIVE";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.Subnetwork.Types.Role.Backup"/>.
                /// </summary>
                public const string Backup = "BACKUP";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.Subnetwork.Types.StackType"/> enum.
            /// </summary>
            public static class StackType
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Subnetwork.Types.StackType.UndefinedStackType"/>.
                /// </summary>
                public const string UndefinedStackType = "UNDEFINED_STACK_TYPE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Subnetwork.Types.StackType.Ipv4Ipv6"/>.
                /// </summary>
                public const string Ipv4Ipv6 = "IPV4_IPV6";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Subnetwork.Types.StackType.Ipv4Only"/>.
                /// </summary>
                public const string Ipv4Only = "IPV4_ONLY";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Subnetwork.Types.StackType.Ipv6Only"/>.
                /// </summary>
                public const string Ipv6Only = "IPV6_ONLY";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Subnetwork.Types.StackType.UnspecifiedStackType"/>.
                /// </summary>
                public const string UnspecifiedStackType = "UNSPECIFIED_STACK_TYPE";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.Subnetwork.Types.State"/> enum.
            /// </summary>
            public static class State
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Subnetwork.Types.State.UndefinedState"/>.
                /// </summary>
                public const string UndefinedState = "UNDEFINED_STATE";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.Subnetwork.Types.State.Draining"/>
                /// .
                /// </summary>
                public const string Draining = "DRAINING";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.Subnetwork.Types.State.Ready"/>.
                /// </summary>
                public const string Ready = "READY";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.SubnetworkLogConfig"/>
        /// message.
        /// </summary>
        public static class SubnetworkLogConfig
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.SubnetworkLogConfig.Types.AggregationInterval"/> enum.
            /// </summary>
            public static class AggregationInterval
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SubnetworkLogConfig.Types.AggregationInterval.UndefinedAggregationInterval"/>
                /// .
                /// </summary>
                public const string UndefinedAggregationInterval = "UNDEFINED_AGGREGATION_INTERVAL";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SubnetworkLogConfig.Types.AggregationInterval.Interval10Min"/>
                /// .
                /// </summary>
                public const string Interval10Min = "INTERVAL_10_MIN";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SubnetworkLogConfig.Types.AggregationInterval.Interval15Min"/>
                /// .
                /// </summary>
                public const string Interval15Min = "INTERVAL_15_MIN";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SubnetworkLogConfig.Types.AggregationInterval.Interval1Min"/>
                /// .
                /// </summary>
                public const string Interval1Min = "INTERVAL_1_MIN";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SubnetworkLogConfig.Types.AggregationInterval.Interval30Sec"/>
                /// .
                /// </summary>
                public const string Interval30Sec = "INTERVAL_30_SEC";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SubnetworkLogConfig.Types.AggregationInterval.Interval5Min"/>
                /// .
                /// </summary>
                public const string Interval5Min = "INTERVAL_5_MIN";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SubnetworkLogConfig.Types.AggregationInterval.Interval5Sec"/>
                /// .
                /// </summary>
                public const string Interval5Sec = "INTERVAL_5_SEC";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.SubnetworkLogConfig.Types.Metadata"/> enum.
            /// </summary>
            public static class Metadata
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SubnetworkLogConfig.Types.Metadata.UndefinedMetadata"/>.
                /// </summary>
                public const string UndefinedMetadata = "UNDEFINED_METADATA";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SubnetworkLogConfig.Types.Metadata.CustomMetadata"/>.
                /// </summary>
                public const string CustomMetadata = "CUSTOM_METADATA";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SubnetworkLogConfig.Types.Metadata.ExcludeAllMetadata"/>.
                /// </summary>
                public const string ExcludeAllMetadata = "EXCLUDE_ALL_METADATA";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.SubnetworkLogConfig.Types.Metadata.IncludeAllMetadata"/>.
                /// </summary>
                public const string IncludeAllMetadata = "INCLUDE_ALL_METADATA";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.Subsetting"/> message.
        /// </summary>
        public static class Subsetting
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.Subsetting.Types.Policy"/> enum.
            /// </summary>
            public static class Policy
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Subsetting.Types.Policy.UndefinedPolicy"/>.
                /// </summary>
                public const string UndefinedPolicy = "UNDEFINED_POLICY";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Subsetting.Types.Policy.ConsistentHashSubsetting"/>.
                /// </summary>
                public const string ConsistentHashSubsetting = "CONSISTENT_HASH_SUBSETTING";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.Subsetting.Types.Policy.None"/>.
                /// </summary>
                public const string None = "NONE";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.TCPHealthCheck"/> message.
        /// </summary>
        public static class TCPHealthCheck
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.TCPHealthCheck.Types.PortSpecification"/> enum.
            /// </summary>
            public static class PortSpecification
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.TCPHealthCheck.Types.PortSpecification.UndefinedPortSpecification"/>
                /// .
                /// </summary>
                public const string UndefinedPortSpecification = "UNDEFINED_PORT_SPECIFICATION";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.TCPHealthCheck.Types.PortSpecification.UseFixedPort"/>.
                /// </summary>
                public const string UseFixedPort = "USE_FIXED_PORT";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.TCPHealthCheck.Types.PortSpecification.UseNamedPort"/>.
                /// </summary>
                public const string UseNamedPort = "USE_NAMED_PORT";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.TCPHealthCheck.Types.PortSpecification.UseServingPort"/>.
                /// </summary>
                public const string UseServingPort = "USE_SERVING_PORT";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.TCPHealthCheck.Types.ProxyHeader"/> enum.
            /// </summary>
            public static class ProxyHeader
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.TCPHealthCheck.Types.ProxyHeader.UndefinedProxyHeader"/>.
                /// </summary>
                public const string UndefinedProxyHeader = "UNDEFINED_PROXY_HEADER";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.TCPHealthCheck.Types.ProxyHeader.None"/>.
                /// </summary>
                public const string None = "NONE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.TCPHealthCheck.Types.ProxyHeader.ProxyV1"/>.
                /// </summary>
                public const string ProxyV1 = "PROXY_V1";
            }
        }

        /// <summary>
        /// Container class for enums within the
        /// <see cref="global::Google.Cloud.Compute.V1.TargetHttpsProxiesSetQuicOverrideRequest"/> message.
        /// </summary>
        public static class TargetHttpsProxiesSetQuicOverrideRequest
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.TargetHttpsProxiesSetQuicOverrideRequest.Types.QuicOverride"/>
            ///  enum.
            /// </summary>
            public static class QuicOverride
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.TargetHttpsProxiesSetQuicOverrideRequest.Types.QuicOverride.UndefinedQuicOverride"/>
                /// .
                /// </summary>
                public const string UndefinedQuicOverride = "UNDEFINED_QUIC_OVERRIDE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.TargetHttpsProxiesSetQuicOverrideRequest.Types.QuicOverride.Disable"/>
                /// .
                /// </summary>
                public const string Disable = "DISABLE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.TargetHttpsProxiesSetQuicOverrideRequest.Types.QuicOverride.Enable"/>
                /// .
                /// </summary>
                public const string Enable = "ENABLE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.TargetHttpsProxiesSetQuicOverrideRequest.Types.QuicOverride.None"/>
                /// .
                /// </summary>
                public const string None = "NONE";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.TargetHttpsProxy"/> message.
        /// </summary>
        public static class TargetHttpsProxy
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.TargetHttpsProxy.Types.QuicOverride"/> enum.
            /// </summary>
            public static class QuicOverride
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.TargetHttpsProxy.Types.QuicOverride.UndefinedQuicOverride"/>
                /// .
                /// </summary>
                public const string UndefinedQuicOverride = "UNDEFINED_QUIC_OVERRIDE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.TargetHttpsProxy.Types.QuicOverride.Disable"/>.
                /// </summary>
                public const string Disable = "DISABLE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.TargetHttpsProxy.Types.QuicOverride.Enable"/>.
                /// </summary>
                public const string Enable = "ENABLE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.TargetHttpsProxy.Types.QuicOverride.None"/>.
                /// </summary>
                public const string None = "NONE";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.TargetHttpsProxy.Types.TlsEarlyData"/> enum.
            /// </summary>
            public static class TlsEarlyData
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.TargetHttpsProxy.Types.TlsEarlyData.UndefinedTlsEarlyData"/>
                /// .
                /// </summary>
                public const string UndefinedTlsEarlyData = "UNDEFINED_TLS_EARLY_DATA";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.TargetHttpsProxy.Types.TlsEarlyData.Disabled"/>.
                /// </summary>
                public const string Disabled = "DISABLED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.TargetHttpsProxy.Types.TlsEarlyData.Permissive"/>.
                /// </summary>
                public const string Permissive = "PERMISSIVE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.TargetHttpsProxy.Types.TlsEarlyData.Strict"/>.
                /// </summary>
                public const string Strict = "STRICT";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.TargetHttpsProxy.Types.TlsEarlyData.Unrestricted"/>.
                /// </summary>
                public const string Unrestricted = "UNRESTRICTED";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.TargetInstance"/> message.
        /// </summary>
        public static class TargetInstance
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.TargetInstance.Types.NatPolicy"/> enum.
            /// </summary>
            public static class NatPolicy
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.TargetInstance.Types.NatPolicy.UndefinedNatPolicy"/>.
                /// </summary>
                public const string UndefinedNatPolicy = "UNDEFINED_NAT_POLICY";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.TargetInstance.Types.NatPolicy.NoNat"/>.
                /// </summary>
                public const string NoNat = "NO_NAT";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.TargetPool"/> message.
        /// </summary>
        public static class TargetPool
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.TargetPool.Types.SessionAffinity"/> enum.
            /// </summary>
            public static class SessionAffinity
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.TargetPool.Types.SessionAffinity.UndefinedSessionAffinity"/>
                /// .
                /// </summary>
                public const string UndefinedSessionAffinity = "UNDEFINED_SESSION_AFFINITY";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.TargetPool.Types.SessionAffinity.ClientIp"/>.
                /// </summary>
                public const string ClientIp = "CLIENT_IP";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.TargetPool.Types.SessionAffinity.ClientIpNoDestination"/>
                /// .
                /// </summary>
                public const string ClientIpNoDestination = "CLIENT_IP_NO_DESTINATION";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.TargetPool.Types.SessionAffinity.ClientIpPortProto"/>.
                /// </summary>
                public const string ClientIpPortProto = "CLIENT_IP_PORT_PROTO";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.TargetPool.Types.SessionAffinity.ClientIpProto"/>.
                /// </summary>
                public const string ClientIpProto = "CLIENT_IP_PROTO";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.TargetPool.Types.SessionAffinity.GeneratedCookie"/>.
                /// </summary>
                public const string GeneratedCookie = "GENERATED_COOKIE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.TargetPool.Types.SessionAffinity.HeaderField"/>.
                /// </summary>
                public const string HeaderField = "HEADER_FIELD";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.TargetPool.Types.SessionAffinity.HttpCookie"/>.
                /// </summary>
                public const string HttpCookie = "HTTP_COOKIE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.TargetPool.Types.SessionAffinity.None"/>.
                /// </summary>
                public const string None = "NONE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.TargetPool.Types.SessionAffinity.StrongCookieAffinity"/>.
                /// </summary>
                public const string StrongCookieAffinity = "STRONG_COOKIE_AFFINITY";
            }
        }

        /// <summary>
        /// Container class for enums within the
        /// <see cref="global::Google.Cloud.Compute.V1.TargetSslProxiesSetProxyHeaderRequest"/> message.
        /// </summary>
        public static class TargetSslProxiesSetProxyHeaderRequest
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.TargetSslProxiesSetProxyHeaderRequest.Types.ProxyHeader"/>
            /// enum.
            /// </summary>
            public static class ProxyHeader
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.TargetSslProxiesSetProxyHeaderRequest.Types.ProxyHeader.UndefinedProxyHeader"/>
                /// .
                /// </summary>
                public const string UndefinedProxyHeader = "UNDEFINED_PROXY_HEADER";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.TargetSslProxiesSetProxyHeaderRequest.Types.ProxyHeader.None"/>
                /// .
                /// </summary>
                public const string None = "NONE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.TargetSslProxiesSetProxyHeaderRequest.Types.ProxyHeader.ProxyV1"/>
                /// .
                /// </summary>
                public const string ProxyV1 = "PROXY_V1";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.TargetSslProxy"/> message.
        /// </summary>
        public static class TargetSslProxy
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.TargetSslProxy.Types.ProxyHeader"/> enum.
            /// </summary>
            public static class ProxyHeader
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.TargetSslProxy.Types.ProxyHeader.UndefinedProxyHeader"/>.
                /// </summary>
                public const string UndefinedProxyHeader = "UNDEFINED_PROXY_HEADER";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.TargetSslProxy.Types.ProxyHeader.None"/>.
                /// </summary>
                public const string None = "NONE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.TargetSslProxy.Types.ProxyHeader.ProxyV1"/>.
                /// </summary>
                public const string ProxyV1 = "PROXY_V1";
            }
        }

        /// <summary>
        /// Container class for enums within the
        /// <see cref="global::Google.Cloud.Compute.V1.TargetTcpProxiesSetProxyHeaderRequest"/> message.
        /// </summary>
        public static class TargetTcpProxiesSetProxyHeaderRequest
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.TargetTcpProxiesSetProxyHeaderRequest.Types.ProxyHeader"/>
            /// enum.
            /// </summary>
            public static class ProxyHeader
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.TargetTcpProxiesSetProxyHeaderRequest.Types.ProxyHeader.UndefinedProxyHeader"/>
                /// .
                /// </summary>
                public const string UndefinedProxyHeader = "UNDEFINED_PROXY_HEADER";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.TargetTcpProxiesSetProxyHeaderRequest.Types.ProxyHeader.None"/>
                /// .
                /// </summary>
                public const string None = "NONE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.TargetTcpProxiesSetProxyHeaderRequest.Types.ProxyHeader.ProxyV1"/>
                /// .
                /// </summary>
                public const string ProxyV1 = "PROXY_V1";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.TargetTcpProxy"/> message.
        /// </summary>
        public static class TargetTcpProxy
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.TargetTcpProxy.Types.ProxyHeader"/> enum.
            /// </summary>
            public static class ProxyHeader
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.TargetTcpProxy.Types.ProxyHeader.UndefinedProxyHeader"/>.
                /// </summary>
                public const string UndefinedProxyHeader = "UNDEFINED_PROXY_HEADER";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.TargetTcpProxy.Types.ProxyHeader.None"/>.
                /// </summary>
                public const string None = "NONE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.TargetTcpProxy.Types.ProxyHeader.ProxyV1"/>.
                /// </summary>
                public const string ProxyV1 = "PROXY_V1";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.TargetVpnGateway"/> message.
        /// </summary>
        public static class TargetVpnGateway
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.TargetVpnGateway.Types.Status"/> enum.
            /// </summary>
            public static class Status
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.TargetVpnGateway.Types.Status.UndefinedStatus"/>.
                /// </summary>
                public const string UndefinedStatus = "UNDEFINED_STATUS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.TargetVpnGateway.Types.Status.Creating"/>.
                /// </summary>
                public const string Creating = "CREATING";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.TargetVpnGateway.Types.Status.Deleting"/>.
                /// </summary>
                public const string Deleting = "DELETING";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.TargetVpnGateway.Types.Status.Failed"/>.
                /// </summary>
                public const string Failed = "FAILED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.TargetVpnGateway.Types.Status.Ready"/>.
                /// </summary>
                public const string Ready = "READY";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.UpcomingMaintenance"/>
        /// message.
        /// </summary>
        public static class UpcomingMaintenance
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.UpcomingMaintenance.Types.MaintenanceReasons"/> enum.
            /// </summary>
            public static class MaintenanceReasons
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.UpcomingMaintenance.Types.MaintenanceReasons.UndefinedMaintenanceReasons"/>
                /// .
                /// </summary>
                public const string UndefinedMaintenanceReasons = "UNDEFINED_MAINTENANCE_REASONS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.UpcomingMaintenance.Types.MaintenanceReasons.FailureDisk"/>
                /// .
                /// </summary>
                public const string FailureDisk = "FAILURE_DISK";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.UpcomingMaintenance.Types.MaintenanceReasons.FailureGpu"/>
                /// .
                /// </summary>
                public const string FailureGpu = "FAILURE_GPU";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.UpcomingMaintenance.Types.MaintenanceReasons.FailureGpuTemperature"/>
                /// .
                /// </summary>
                public const string FailureGpuTemperature = "FAILURE_GPU_TEMPERATURE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.UpcomingMaintenance.Types.MaintenanceReasons.FailureGpuXid"/>
                /// .
                /// </summary>
                public const string FailureGpuXid = "FAILURE_GPU_XID";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.UpcomingMaintenance.Types.MaintenanceReasons.FailureInfra"/>
                /// .
                /// </summary>
                public const string FailureInfra = "FAILURE_INFRA";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.UpcomingMaintenance.Types.MaintenanceReasons.FailureInterface"/>
                /// .
                /// </summary>
                public const string FailureInterface = "FAILURE_INTERFACE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.UpcomingMaintenance.Types.MaintenanceReasons.FailureMemory"/>
                /// .
                /// </summary>
                public const string FailureMemory = "FAILURE_MEMORY";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.UpcomingMaintenance.Types.MaintenanceReasons.FailureNetwork"/>
                /// .
                /// </summary>
                public const string FailureNetwork = "FAILURE_NETWORK";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.UpcomingMaintenance.Types.MaintenanceReasons.FailureNvlink"/>
                /// .
                /// </summary>
                public const string FailureNvlink = "FAILURE_NVLINK";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.UpcomingMaintenance.Types.MaintenanceReasons.FailureRedundantHardwareFault"/>
                /// .
                /// </summary>
                public const string FailureRedundantHardwareFault = "FAILURE_REDUNDANT_HARDWARE_FAULT";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.UpcomingMaintenance.Types.MaintenanceReasons.InfrastructureRelocation"/>
                /// .
                /// </summary>
                public const string InfrastructureRelocation = "INFRASTRUCTURE_RELOCATION";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.UpcomingMaintenance.Types.MaintenanceReasons.MaintenanceReasonUnknown"/>
                /// .
                /// </summary>
                public const string MaintenanceReasonUnknown = "MAINTENANCE_REASON_UNKNOWN";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.UpcomingMaintenance.Types.MaintenanceReasons.PlannedNetworkUpdate"/>
                /// .
                /// </summary>
                public const string PlannedNetworkUpdate = "PLANNED_NETWORK_UPDATE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.UpcomingMaintenance.Types.MaintenanceReasons.PlannedUpdate"/>
                /// .
                /// </summary>
                public const string PlannedUpdate = "PLANNED_UPDATE";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.UpcomingMaintenance.Types.MaintenanceStatus"/> enum.
            /// </summary>
            public static class MaintenanceStatus
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.UpcomingMaintenance.Types.MaintenanceStatus.UndefinedMaintenanceStatus"/>
                /// .
                /// </summary>
                public const string UndefinedMaintenanceStatus = "UNDEFINED_MAINTENANCE_STATUS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.UpcomingMaintenance.Types.MaintenanceStatus.Ongoing"/>.
                /// </summary>
                public const string Ongoing = "ONGOING";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.UpcomingMaintenance.Types.MaintenanceStatus.Pending"/>.
                /// </summary>
                public const string Pending = "PENDING";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.UpcomingMaintenance.Types.MaintenanceStatus.Unknown"/>.
                /// </summary>
                public const string Unknown = "UNKNOWN";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.UpcomingMaintenance.Types.Type"/> enum.
            /// </summary>
            public static class Type
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.UpcomingMaintenance.Types.Type.UndefinedType"/>.
                /// </summary>
                public const string UndefinedType = "UNDEFINED_TYPE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.UpcomingMaintenance.Types.Type.Multiple"/>.
                /// </summary>
                public const string Multiple = "MULTIPLE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.UpcomingMaintenance.Types.Type.Scheduled"/>.
                /// </summary>
                public const string Scheduled = "SCHEDULED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.UpcomingMaintenance.Types.Type.UnknownType"/>.
                /// </summary>
                public const string UnknownType = "UNKNOWN_TYPE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.UpcomingMaintenance.Types.Type.Unscheduled"/>.
                /// </summary>
                public const string Unscheduled = "UNSCHEDULED";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.UpdateInstanceRequest"/>
        /// message.
        /// </summary>
        public static class UpdateInstanceRequest
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.UpdateInstanceRequest.Types.MinimalAction"/> enum.
            /// </summary>
            public static class MinimalAction
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.UpdateInstanceRequest.Types.MinimalAction.UndefinedMinimalAction"/>
                /// .
                /// </summary>
                public const string UndefinedMinimalAction = "UNDEFINED_MINIMAL_ACTION";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.UpdateInstanceRequest.Types.MostDisruptiveAllowedAction"/>
            /// enum.
            /// </summary>
            public static class MostDisruptiveAllowedAction
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.UpdateInstanceRequest.Types.MostDisruptiveAllowedAction.UndefinedMostDisruptiveAllowedAction"/>
                /// .
                /// </summary>
                public const string UndefinedMostDisruptiveAllowedAction = "UNDEFINED_MOST_DISRUPTIVE_ALLOWED_ACTION";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.UrlMapsValidateRequest"/>
        /// message.
        /// </summary>
        public static class UrlMapsValidateRequest
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.UrlMapsValidateRequest.Types.LoadBalancingSchemes"/> enum.
            /// </summary>
            public static class LoadBalancingSchemes
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.UrlMapsValidateRequest.Types.LoadBalancingSchemes.UndefinedLoadBalancingSchemes"/>
                /// .
                /// </summary>
                public const string UndefinedLoadBalancingSchemes = "UNDEFINED_LOAD_BALANCING_SCHEMES";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.UrlMapsValidateRequest.Types.LoadBalancingSchemes.External"/>
                /// .
                /// </summary>
                public const string External = "EXTERNAL";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.UrlMapsValidateRequest.Types.LoadBalancingSchemes.ExternalManaged"/>
                /// .
                /// </summary>
                public const string ExternalManaged = "EXTERNAL_MANAGED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.UrlMapsValidateRequest.Types.LoadBalancingSchemes.LoadBalancingSchemeUnspecified"/>
                /// .
                /// </summary>
                public const string LoadBalancingSchemeUnspecified = "LOAD_BALANCING_SCHEME_UNSPECIFIED";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.UsableSubnetwork"/> message.
        /// </summary>
        public static class UsableSubnetwork
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.UsableSubnetwork.Types.Ipv6AccessType"/> enum.
            /// </summary>
            public static class Ipv6AccessType
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.UsableSubnetwork.Types.Ipv6AccessType.UndefinedIpv6AccessType"/>
                /// .
                /// </summary>
                public const string UndefinedIpv6AccessType = "UNDEFINED_IPV6_ACCESS_TYPE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.UsableSubnetwork.Types.Ipv6AccessType.External"/>.
                /// </summary>
                public const string External = "EXTERNAL";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.UsableSubnetwork.Types.Ipv6AccessType.Internal"/>.
                /// </summary>
                public const string Internal = "INTERNAL";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.UsableSubnetwork.Types.Purpose"/> enum.
            /// </summary>
            public static class Purpose
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.UsableSubnetwork.Types.Purpose.UndefinedPurpose"/>.
                /// </summary>
                public const string UndefinedPurpose = "UNDEFINED_PURPOSE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.UsableSubnetwork.Types.Purpose.GlobalManagedProxy"/>.
                /// </summary>
                public const string GlobalManagedProxy = "GLOBAL_MANAGED_PROXY";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.UsableSubnetwork.Types.Purpose.InternalHttpsLoadBalancer"/>
                /// .
                /// </summary>
                public const string InternalHttpsLoadBalancer = "INTERNAL_HTTPS_LOAD_BALANCER";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.UsableSubnetwork.Types.Purpose.PeerMigration"/>.
                /// </summary>
                public const string PeerMigration = "PEER_MIGRATION";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.UsableSubnetwork.Types.Purpose.Private"/>.
                /// </summary>
                public const string Private = "PRIVATE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.UsableSubnetwork.Types.Purpose.PrivateNat"/>.
                /// </summary>
                public const string PrivateNat = "PRIVATE_NAT";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.UsableSubnetwork.Types.Purpose.PrivateRfc1918"/>.
                /// </summary>
                public const string PrivateRfc1918 = "PRIVATE_RFC_1918";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.UsableSubnetwork.Types.Purpose.PrivateServiceConnect"/>.
                /// </summary>
                public const string PrivateServiceConnect = "PRIVATE_SERVICE_CONNECT";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.UsableSubnetwork.Types.Purpose.RegionalManagedProxy"/>.
                /// </summary>
                public const string RegionalManagedProxy = "REGIONAL_MANAGED_PROXY";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.UsableSubnetwork.Types.Role"/> enum.
            /// </summary>
            public static class Role
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.UsableSubnetwork.Types.Role.UndefinedRole"/>.
                /// </summary>
                public const string UndefinedRole = "UNDEFINED_ROLE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.UsableSubnetwork.Types.Role.Active"/>.
                /// </summary>
                public const string Active = "ACTIVE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.UsableSubnetwork.Types.Role.Backup"/>.
                /// </summary>
                public const string Backup = "BACKUP";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.UsableSubnetwork.Types.StackType"/> enum.
            /// </summary>
            public static class StackType
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.UsableSubnetwork.Types.StackType.UndefinedStackType"/>.
                /// </summary>
                public const string UndefinedStackType = "UNDEFINED_STACK_TYPE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.UsableSubnetwork.Types.StackType.Ipv4Ipv6"/>.
                /// </summary>
                public const string Ipv4Ipv6 = "IPV4_IPV6";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.UsableSubnetwork.Types.StackType.Ipv4Only"/>.
                /// </summary>
                public const string Ipv4Only = "IPV4_ONLY";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.UsableSubnetwork.Types.StackType.Ipv6Only"/>.
                /// </summary>
                public const string Ipv6Only = "IPV6_ONLY";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.VpnGateway"/> message.
        /// </summary>
        public static class VpnGateway
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.VpnGateway.Types.GatewayIpVersion"/> enum.
            /// </summary>
            public static class GatewayIpVersion
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.VpnGateway.Types.GatewayIpVersion.UndefinedGatewayIpVersion"/>
                /// .
                /// </summary>
                public const string UndefinedGatewayIpVersion = "UNDEFINED_GATEWAY_IP_VERSION";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.VpnGateway.Types.GatewayIpVersion.Ipv4"/>.
                /// </summary>
                public const string Ipv4 = "IPV4";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.VpnGateway.Types.GatewayIpVersion.Ipv6"/>.
                /// </summary>
                public const string Ipv6 = "IPV6";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.VpnGateway.Types.StackType"/> enum.
            /// </summary>
            public static class StackType
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.VpnGateway.Types.StackType.UndefinedStackType"/>.
                /// </summary>
                public const string UndefinedStackType = "UNDEFINED_STACK_TYPE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.VpnGateway.Types.StackType.Ipv4Ipv6"/>.
                /// </summary>
                public const string Ipv4Ipv6 = "IPV4_IPV6";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.VpnGateway.Types.StackType.Ipv4Only"/>.
                /// </summary>
                public const string Ipv4Only = "IPV4_ONLY";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.VpnGateway.Types.StackType.Ipv6Only"/>.
                /// </summary>
                public const string Ipv6Only = "IPV6_ONLY";
            }
        }

        /// <summary>
        /// Container class for enums within the
        /// <see cref="global::Google.Cloud.Compute.V1.VpnGatewayStatusHighAvailabilityRequirementState"/> message.
        /// </summary>
        public static class VpnGatewayStatusHighAvailabilityRequirementState
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.VpnGatewayStatusHighAvailabilityRequirementState.Types.State"/>
            ///  enum.
            /// </summary>
            public static class State
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.VpnGatewayStatusHighAvailabilityRequirementState.Types.State.UndefinedState"/>
                /// .
                /// </summary>
                public const string UndefinedState = "UNDEFINED_STATE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.VpnGatewayStatusHighAvailabilityRequirementState.Types.State.ConnectionRedundancyMet"/>
                /// .
                /// </summary>
                public const string ConnectionRedundancyMet = "CONNECTION_REDUNDANCY_MET";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.VpnGatewayStatusHighAvailabilityRequirementState.Types.State.ConnectionRedundancyNotMet"/>
                /// .
                /// </summary>
                public const string ConnectionRedundancyNotMet = "CONNECTION_REDUNDANCY_NOT_MET";
            }

            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.VpnGatewayStatusHighAvailabilityRequirementState.Types.UnsatisfiedReason"/>
            ///  enum.
            /// </summary>
            public static class UnsatisfiedReason
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.VpnGatewayStatusHighAvailabilityRequirementState.Types.UnsatisfiedReason.UndefinedUnsatisfiedReason"/>
                /// .
                /// </summary>
                public const string UndefinedUnsatisfiedReason = "UNDEFINED_UNSATISFIED_REASON";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.VpnGatewayStatusHighAvailabilityRequirementState.Types.UnsatisfiedReason.IncompleteTunnelsCoverage"/>
                /// .
                /// </summary>
                public const string IncompleteTunnelsCoverage = "INCOMPLETE_TUNNELS_COVERAGE";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.VpnTunnel"/> message.
        /// </summary>
        public static class VpnTunnel
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.VpnTunnel.Types.Status"/> enum.
            /// </summary>
            public static class Status
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.VpnTunnel.Types.Status.UndefinedStatus"/>.
                /// </summary>
                public const string UndefinedStatus = "UNDEFINED_STATUS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.VpnTunnel.Types.Status.AllocatingResources"/>.
                /// </summary>
                public const string AllocatingResources = "ALLOCATING_RESOURCES";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.VpnTunnel.Types.Status.AuthorizationError"/>.
                /// </summary>
                public const string AuthorizationError = "AUTHORIZATION_ERROR";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.VpnTunnel.Types.Status.Deprovisioning"/>.
                /// </summary>
                public const string Deprovisioning = "DEPROVISIONING";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.VpnTunnel.Types.Status.Established"/>.
                /// </summary>
                public const string Established = "ESTABLISHED";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.VpnTunnel.Types.Status.Failed"/>.
                /// </summary>
                public const string Failed = "FAILED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.VpnTunnel.Types.Status.FirstHandshake"/>.
                /// </summary>
                public const string FirstHandshake = "FIRST_HANDSHAKE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.VpnTunnel.Types.Status.NegotiationFailure"/>.
                /// </summary>
                public const string NegotiationFailure = "NEGOTIATION_FAILURE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.VpnTunnel.Types.Status.NetworkError"/>.
                /// </summary>
                public const string NetworkError = "NETWORK_ERROR";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.VpnTunnel.Types.Status.NoIncomingPackets"/>.
                /// </summary>
                public const string NoIncomingPackets = "NO_INCOMING_PACKETS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.VpnTunnel.Types.Status.Provisioning"/>.
                /// </summary>
                public const string Provisioning = "PROVISIONING";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.VpnTunnel.Types.Status.Rejected"/>
                /// .
                /// </summary>
                public const string Rejected = "REJECTED";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.VpnTunnel.Types.Status.Stopped"/>.
                /// </summary>
                public const string Stopped = "STOPPED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.VpnTunnel.Types.Status.WaitingForFullConfig"/>.
                /// </summary>
                public const string WaitingForFullConfig = "WAITING_FOR_FULL_CONFIG";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.Warning"/> message.
        /// </summary>
        public static class Warning
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.Warning.Types.Code"/> enum.
            /// </summary>
            public static class Code
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Warning.Types.Code.UndefinedCode"/>.
                /// </summary>
                public const string UndefinedCode = "UNDEFINED_CODE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Warning.Types.Code.CleanupFailed"/>.
                /// </summary>
                public const string CleanupFailed = "CLEANUP_FAILED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Warning.Types.Code.DeprecatedResourceUsed"/>.
                /// </summary>
                public const string DeprecatedResourceUsed = "DEPRECATED_RESOURCE_USED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Warning.Types.Code.DeprecatedTypeUsed"/>.
                /// </summary>
                public const string DeprecatedTypeUsed = "DEPRECATED_TYPE_USED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Warning.Types.Code.DiskSizeLargerThanImageSize"/>.
                /// </summary>
                public const string DiskSizeLargerThanImageSize = "DISK_SIZE_LARGER_THAN_IMAGE_SIZE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Warning.Types.Code.ExperimentalTypeUsed"/>.
                /// </summary>
                public const string ExperimentalTypeUsed = "EXPERIMENTAL_TYPE_USED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Warning.Types.Code.ExternalApiWarning"/>.
                /// </summary>
                public const string ExternalApiWarning = "EXTERNAL_API_WARNING";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Warning.Types.Code.FieldValueOverriden"/>.
                /// </summary>
                public const string FieldValueOverriden = "FIELD_VALUE_OVERRIDEN";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Warning.Types.Code.InjectedKernelsDeprecated"/>.
                /// </summary>
                public const string InjectedKernelsDeprecated = "INJECTED_KERNELS_DEPRECATED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Warning.Types.Code.InvalidHealthCheckForDynamicWieghtedLb"/>
                /// .
                /// </summary>
                public const string InvalidHealthCheckForDynamicWieghtedLb = "INVALID_HEALTH_CHECK_FOR_DYNAMIC_WIEGHTED_LB";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Warning.Types.Code.LargeDeploymentWarning"/>.
                /// </summary>
                public const string LargeDeploymentWarning = "LARGE_DEPLOYMENT_WARNING";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Warning.Types.Code.ListOverheadQuotaExceed"/>.
                /// </summary>
                public const string ListOverheadQuotaExceed = "LIST_OVERHEAD_QUOTA_EXCEED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Warning.Types.Code.MissingTypeDependency"/>.
                /// </summary>
                public const string MissingTypeDependency = "MISSING_TYPE_DEPENDENCY";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Warning.Types.Code.NextHopAddressNotAssigned"/>.
                /// </summary>
                public const string NextHopAddressNotAssigned = "NEXT_HOP_ADDRESS_NOT_ASSIGNED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Warning.Types.Code.NextHopCannotIpForward"/>.
                /// </summary>
                public const string NextHopCannotIpForward = "NEXT_HOP_CANNOT_IP_FORWARD";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Warning.Types.Code.NextHopInstanceHasNoIpv6Interface"/>.
                /// </summary>
                public const string NextHopInstanceHasNoIpv6Interface = "NEXT_HOP_INSTANCE_HAS_NO_IPV6_INTERFACE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Warning.Types.Code.NextHopInstanceNotFound"/>.
                /// </summary>
                public const string NextHopInstanceNotFound = "NEXT_HOP_INSTANCE_NOT_FOUND";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Warning.Types.Code.NextHopInstanceNotOnNetwork"/>.
                /// </summary>
                public const string NextHopInstanceNotOnNetwork = "NEXT_HOP_INSTANCE_NOT_ON_NETWORK";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Warning.Types.Code.NextHopNotRunning"/>.
                /// </summary>
                public const string NextHopNotRunning = "NEXT_HOP_NOT_RUNNING";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Warning.Types.Code.NotCriticalError"/>.
                /// </summary>
                public const string NotCriticalError = "NOT_CRITICAL_ERROR";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Warning.Types.Code.NoResultsOnPage"/>.
                /// </summary>
                public const string NoResultsOnPage = "NO_RESULTS_ON_PAGE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Warning.Types.Code.PartialSuccess"/>.
                /// </summary>
                public const string PartialSuccess = "PARTIAL_SUCCESS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Warning.Types.Code.QuotaInfoUnavailable"/>.
                /// </summary>
                public const string QuotaInfoUnavailable = "QUOTA_INFO_UNAVAILABLE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Warning.Types.Code.RequiredTosAgreement"/>.
                /// </summary>
                public const string RequiredTosAgreement = "REQUIRED_TOS_AGREEMENT";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Warning.Types.Code.ResourceInUseByOtherResourceWarning"/>
                /// .
                /// </summary>
                public const string ResourceInUseByOtherResourceWarning = "RESOURCE_IN_USE_BY_OTHER_RESOURCE_WARNING";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Warning.Types.Code.ResourceNotDeleted"/>.
                /// </summary>
                public const string ResourceNotDeleted = "RESOURCE_NOT_DELETED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Warning.Types.Code.SchemaValidationIgnored"/>.
                /// </summary>
                public const string SchemaValidationIgnored = "SCHEMA_VALIDATION_IGNORED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Warning.Types.Code.SingleInstancePropertyTemplate"/>.
                /// </summary>
                public const string SingleInstancePropertyTemplate = "SINGLE_INSTANCE_PROPERTY_TEMPLATE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Warning.Types.Code.UndeclaredProperties"/>.
                /// </summary>
                public const string UndeclaredProperties = "UNDECLARED_PROPERTIES";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.Warning.Types.Code.Unreachable"/>.
                /// </summary>
                public const string Unreachable = "UNREACHABLE";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.Warnings"/> message.
        /// </summary>
        public static class Warnings
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.Warnings.Types.Code"/> enum.
            /// </summary>
            public static class Code
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Warnings.Types.Code.UndefinedCode"/>.
                /// </summary>
                public const string UndefinedCode = "UNDEFINED_CODE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Warnings.Types.Code.CleanupFailed"/>.
                /// </summary>
                public const string CleanupFailed = "CLEANUP_FAILED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Warnings.Types.Code.DeprecatedResourceUsed"/>.
                /// </summary>
                public const string DeprecatedResourceUsed = "DEPRECATED_RESOURCE_USED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Warnings.Types.Code.DeprecatedTypeUsed"/>.
                /// </summary>
                public const string DeprecatedTypeUsed = "DEPRECATED_TYPE_USED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Warnings.Types.Code.DiskSizeLargerThanImageSize"/>.
                /// </summary>
                public const string DiskSizeLargerThanImageSize = "DISK_SIZE_LARGER_THAN_IMAGE_SIZE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Warnings.Types.Code.ExperimentalTypeUsed"/>.
                /// </summary>
                public const string ExperimentalTypeUsed = "EXPERIMENTAL_TYPE_USED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Warnings.Types.Code.ExternalApiWarning"/>.
                /// </summary>
                public const string ExternalApiWarning = "EXTERNAL_API_WARNING";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Warnings.Types.Code.FieldValueOverriden"/>.
                /// </summary>
                public const string FieldValueOverriden = "FIELD_VALUE_OVERRIDEN";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Warnings.Types.Code.InjectedKernelsDeprecated"/>.
                /// </summary>
                public const string InjectedKernelsDeprecated = "INJECTED_KERNELS_DEPRECATED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Warnings.Types.Code.InvalidHealthCheckForDynamicWieghtedLb"/>
                /// .
                /// </summary>
                public const string InvalidHealthCheckForDynamicWieghtedLb = "INVALID_HEALTH_CHECK_FOR_DYNAMIC_WIEGHTED_LB";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Warnings.Types.Code.LargeDeploymentWarning"/>.
                /// </summary>
                public const string LargeDeploymentWarning = "LARGE_DEPLOYMENT_WARNING";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Warnings.Types.Code.ListOverheadQuotaExceed"/>.
                /// </summary>
                public const string ListOverheadQuotaExceed = "LIST_OVERHEAD_QUOTA_EXCEED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Warnings.Types.Code.MissingTypeDependency"/>.
                /// </summary>
                public const string MissingTypeDependency = "MISSING_TYPE_DEPENDENCY";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Warnings.Types.Code.NextHopAddressNotAssigned"/>.
                /// </summary>
                public const string NextHopAddressNotAssigned = "NEXT_HOP_ADDRESS_NOT_ASSIGNED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Warnings.Types.Code.NextHopCannotIpForward"/>.
                /// </summary>
                public const string NextHopCannotIpForward = "NEXT_HOP_CANNOT_IP_FORWARD";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Warnings.Types.Code.NextHopInstanceHasNoIpv6Interface"/>.
                /// </summary>
                public const string NextHopInstanceHasNoIpv6Interface = "NEXT_HOP_INSTANCE_HAS_NO_IPV6_INTERFACE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Warnings.Types.Code.NextHopInstanceNotFound"/>.
                /// </summary>
                public const string NextHopInstanceNotFound = "NEXT_HOP_INSTANCE_NOT_FOUND";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Warnings.Types.Code.NextHopInstanceNotOnNetwork"/>.
                /// </summary>
                public const string NextHopInstanceNotOnNetwork = "NEXT_HOP_INSTANCE_NOT_ON_NETWORK";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Warnings.Types.Code.NextHopNotRunning"/>.
                /// </summary>
                public const string NextHopNotRunning = "NEXT_HOP_NOT_RUNNING";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Warnings.Types.Code.NotCriticalError"/>.
                /// </summary>
                public const string NotCriticalError = "NOT_CRITICAL_ERROR";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Warnings.Types.Code.NoResultsOnPage"/>.
                /// </summary>
                public const string NoResultsOnPage = "NO_RESULTS_ON_PAGE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Warnings.Types.Code.PartialSuccess"/>.
                /// </summary>
                public const string PartialSuccess = "PARTIAL_SUCCESS";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Warnings.Types.Code.QuotaInfoUnavailable"/>.
                /// </summary>
                public const string QuotaInfoUnavailable = "QUOTA_INFO_UNAVAILABLE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Warnings.Types.Code.RequiredTosAgreement"/>.
                /// </summary>
                public const string RequiredTosAgreement = "REQUIRED_TOS_AGREEMENT";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Warnings.Types.Code.ResourceInUseByOtherResourceWarning"/>
                /// .
                /// </summary>
                public const string ResourceInUseByOtherResourceWarning = "RESOURCE_IN_USE_BY_OTHER_RESOURCE_WARNING";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Warnings.Types.Code.ResourceNotDeleted"/>.
                /// </summary>
                public const string ResourceNotDeleted = "RESOURCE_NOT_DELETED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Warnings.Types.Code.SchemaValidationIgnored"/>.
                /// </summary>
                public const string SchemaValidationIgnored = "SCHEMA_VALIDATION_IGNORED";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Warnings.Types.Code.SingleInstancePropertyTemplate"/>.
                /// </summary>
                public const string SingleInstancePropertyTemplate = "SINGLE_INSTANCE_PROPERTY_TEMPLATE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Warnings.Types.Code.UndeclaredProperties"/>.
                /// </summary>
                public const string UndeclaredProperties = "UNDECLARED_PROPERTIES";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.Warnings.Types.Code.Unreachable"/>
                /// .
                /// </summary>
                public const string Unreachable = "UNREACHABLE";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.XpnResourceId"/> message.
        /// </summary>
        public static class XpnResourceId
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.XpnResourceId.Types.Type"/> enum.
            /// </summary>
            public static class Type
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.XpnResourceId.Types.Type.UndefinedType"/>.
                /// </summary>
                public const string UndefinedType = "UNDEFINED_TYPE";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.XpnResourceId.Types.Type.Project"/>.
                /// </summary>
                public const string Project = "PROJECT";

                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.XpnResourceId.Types.Type.XpnResourceTypeUnspecified"/>.
                /// </summary>
                public const string XpnResourceTypeUnspecified = "XPN_RESOURCE_TYPE_UNSPECIFIED";
            }
        }

        /// <summary>
        /// Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.Zone"/> message.
        /// </summary>
        public static class Zone
        {
            /// <summary>
            /// Constants for wire representations of the
            /// <see cref="global::Google.Cloud.Compute.V1.Zone.Types.Status"/> enum.
            /// </summary>
            public static class Status
            {
                /// <summary>
                /// Wire representation of
                /// <see cref="global::Google.Cloud.Compute.V1.Zone.Types.Status.UndefinedStatus"/>.
                /// </summary>
                public const string UndefinedStatus = "UNDEFINED_STATUS";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.Zone.Types.Status.Down"/>.
                /// </summary>
                public const string Down = "DOWN";

                /// <summary>
                /// Wire representation of <see cref="global::Google.Cloud.Compute.V1.Zone.Types.Status.Up"/>.
                /// </summary>
                public const string Up = "UP";
            }
        }
    }
}
