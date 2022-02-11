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

namespace Google.Cloud.Compute.V1
{
    /// <summary>Helper constants with the wire representation for enums within the Compute API.</summary>
    public static class ComputeEnumConstants
    {
        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.AccessConfig"/> message.</summary>
        public static class AccessConfig
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.AccessConfig.Types.NetworkTier"/> enum.</summary>
            public static class NetworkTier
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.AccessConfig.Types.NetworkTier.UndefinedNetworkTier"/>.</summary>
                public const string UndefinedNetworkTier = "UNDEFINED_NETWORK_TIER";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.AccessConfig.Types.NetworkTier.FixedStandard"/>.</summary>
                public const string FixedStandard = "FIXED_STANDARD";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.AccessConfig.Types.NetworkTier.Premium"/>.</summary>
                public const string Premium = "PREMIUM";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.AccessConfig.Types.NetworkTier.Standard"/>.</summary>
                public const string Standard = "STANDARD";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.AccessConfig.Types.NetworkTier.StandardOverridesFixedStandard"/>.</summary>
                public const string StandardOverridesFixedStandard = "STANDARD_OVERRIDES_FIXED_STANDARD";
            }

            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.AccessConfig.Types.Type"/> enum.</summary>
            public static class Type
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.AccessConfig.Types.Type.UndefinedType"/>.</summary>
                public const string UndefinedType = "UNDEFINED_TYPE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.AccessConfig.Types.Type.DirectIpv6"/>.</summary>
                public const string DirectIpv6 = "DIRECT_IPV6";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.AccessConfig.Types.Type.OneToOneNat"/>.</summary>
                public const string OneToOneNat = "ONE_TO_ONE_NAT";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.Address"/> message.</summary>
        public static class Address
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.Address.Types.AddressType"/> enum.</summary>
            public static class AddressType
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Address.Types.AddressType.UndefinedAddressType"/>.</summary>
                public const string UndefinedAddressType = "UNDEFINED_ADDRESS_TYPE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Address.Types.AddressType.External"/>.</summary>
                public const string External = "EXTERNAL";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Address.Types.AddressType.Internal"/>.</summary>
                public const string Internal = "INTERNAL";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Address.Types.AddressType.UnspecifiedType"/>.</summary>
                public const string UnspecifiedType = "UNSPECIFIED_TYPE";
            }

            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.Address.Types.IpVersion"/> enum.</summary>
            public static class IpVersion
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Address.Types.IpVersion.UndefinedIpVersion"/>.</summary>
                public const string UndefinedIpVersion = "UNDEFINED_IP_VERSION";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Address.Types.IpVersion.Ipv4"/>.</summary>
                public const string Ipv4 = "IPV4";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Address.Types.IpVersion.Ipv6"/>.</summary>
                public const string Ipv6 = "IPV6";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Address.Types.IpVersion.UnspecifiedVersion"/>.</summary>
                public const string UnspecifiedVersion = "UNSPECIFIED_VERSION";
            }

            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.Address.Types.NetworkTier"/> enum.</summary>
            public static class NetworkTier
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Address.Types.NetworkTier.UndefinedNetworkTier"/>.</summary>
                public const string UndefinedNetworkTier = "UNDEFINED_NETWORK_TIER";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Address.Types.NetworkTier.FixedStandard"/>.</summary>
                public const string FixedStandard = "FIXED_STANDARD";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Address.Types.NetworkTier.Premium"/>.</summary>
                public const string Premium = "PREMIUM";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Address.Types.NetworkTier.Standard"/>.</summary>
                public const string Standard = "STANDARD";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Address.Types.NetworkTier.StandardOverridesFixedStandard"/>.</summary>
                public const string StandardOverridesFixedStandard = "STANDARD_OVERRIDES_FIXED_STANDARD";
            }

            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.Address.Types.Purpose"/> enum.</summary>
            public static class Purpose
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Address.Types.Purpose.UndefinedPurpose"/>.</summary>
                public const string UndefinedPurpose = "UNDEFINED_PURPOSE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Address.Types.Purpose.DnsResolver"/>.</summary>
                public const string DnsResolver = "DNS_RESOLVER";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Address.Types.Purpose.GceEndpoint"/>.</summary>
                public const string GceEndpoint = "GCE_ENDPOINT";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Address.Types.Purpose.IpsecInterconnect"/>.</summary>
                public const string IpsecInterconnect = "IPSEC_INTERCONNECT";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Address.Types.Purpose.NatAuto"/>.</summary>
                public const string NatAuto = "NAT_AUTO";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Address.Types.Purpose.PrivateServiceConnect"/>.</summary>
                public const string PrivateServiceConnect = "PRIVATE_SERVICE_CONNECT";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Address.Types.Purpose.SharedLoadbalancerVip"/>.</summary>
                public const string SharedLoadbalancerVip = "SHARED_LOADBALANCER_VIP";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Address.Types.Purpose.VpcPeering"/>.</summary>
                public const string VpcPeering = "VPC_PEERING";
            }

            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.Address.Types.Status"/> enum.</summary>
            public static class Status
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Address.Types.Status.UndefinedStatus"/>.</summary>
                public const string UndefinedStatus = "UNDEFINED_STATUS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Address.Types.Status.InUse"/>.</summary>
                public const string InUse = "IN_USE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Address.Types.Status.Reserved"/>.</summary>
                public const string Reserved = "RESERVED";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Address.Types.Status.Reserving"/>.</summary>
                public const string Reserving = "RESERVING";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.AllocationSpecificSKUAllocationAllocatedInstancePropertiesReservedDisk"/> message.</summary>
        public static class AllocationSpecificSKUAllocationAllocatedInstancePropertiesReservedDisk
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.AllocationSpecificSKUAllocationAllocatedInstancePropertiesReservedDisk.Types.Interface"/> enum.</summary>
            public static class Interface
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.AllocationSpecificSKUAllocationAllocatedInstancePropertiesReservedDisk.Types.Interface.UndefinedInterface"/>.</summary>
                public const string UndefinedInterface = "UNDEFINED_INTERFACE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.AllocationSpecificSKUAllocationAllocatedInstancePropertiesReservedDisk.Types.Interface.Nvme"/>.</summary>
                public const string Nvme = "NVME";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.AllocationSpecificSKUAllocationAllocatedInstancePropertiesReservedDisk.Types.Interface.Scsi"/>.</summary>
                public const string Scsi = "SCSI";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.AttachedDisk"/> message.</summary>
        public static class AttachedDisk
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.AttachedDisk.Types.Interface"/> enum.</summary>
            public static class Interface
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.AttachedDisk.Types.Interface.UndefinedInterface"/>.</summary>
                public const string UndefinedInterface = "UNDEFINED_INTERFACE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.AttachedDisk.Types.Interface.Nvme"/>.</summary>
                public const string Nvme = "NVME";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.AttachedDisk.Types.Interface.Scsi"/>.</summary>
                public const string Scsi = "SCSI";
            }

            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.AttachedDisk.Types.Mode"/> enum.</summary>
            public static class Mode
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.AttachedDisk.Types.Mode.UndefinedMode"/>.</summary>
                public const string UndefinedMode = "UNDEFINED_MODE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.AttachedDisk.Types.Mode.ReadOnly"/>.</summary>
                public const string ReadOnly = "READ_ONLY";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.AttachedDisk.Types.Mode.ReadWrite"/>.</summary>
                public const string ReadWrite = "READ_WRITE";
            }

            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.AttachedDisk.Types.Type"/> enum.</summary>
            public static class Type
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.AttachedDisk.Types.Type.UndefinedType"/>.</summary>
                public const string UndefinedType = "UNDEFINED_TYPE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.AttachedDisk.Types.Type.Persistent"/>.</summary>
                public const string Persistent = "PERSISTENT";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.AttachedDisk.Types.Type.Scratch"/>.</summary>
                public const string Scratch = "SCRATCH";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.AttachedDiskInitializeParams"/> message.</summary>
        public static class AttachedDiskInitializeParams
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.AttachedDiskInitializeParams.Types.OnUpdateAction"/> enum.</summary>
            public static class OnUpdateAction
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.AttachedDiskInitializeParams.Types.OnUpdateAction.UndefinedOnUpdateAction"/>.</summary>
                public const string UndefinedOnUpdateAction = "UNDEFINED_ON_UPDATE_ACTION";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.AttachedDiskInitializeParams.Types.OnUpdateAction.RecreateDisk"/>.</summary>
                public const string RecreateDisk = "RECREATE_DISK";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.AttachedDiskInitializeParams.Types.OnUpdateAction.RecreateDiskIfSourceChanged"/>.</summary>
                public const string RecreateDiskIfSourceChanged = "RECREATE_DISK_IF_SOURCE_CHANGED";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.AttachedDiskInitializeParams.Types.OnUpdateAction.UseExistingDisk"/>.</summary>
                public const string UseExistingDisk = "USE_EXISTING_DISK";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.AuditLogConfig"/> message.</summary>
        public static class AuditLogConfig
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.AuditLogConfig.Types.LogType"/> enum.</summary>
            public static class LogType
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.AuditLogConfig.Types.LogType.UndefinedLogType"/>.</summary>
                public const string UndefinedLogType = "UNDEFINED_LOG_TYPE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.AuditLogConfig.Types.LogType.AdminRead"/>.</summary>
                public const string AdminRead = "ADMIN_READ";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.AuditLogConfig.Types.LogType.DataRead"/>.</summary>
                public const string DataRead = "DATA_READ";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.AuditLogConfig.Types.LogType.DataWrite"/>.</summary>
                public const string DataWrite = "DATA_WRITE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.AuditLogConfig.Types.LogType.Unspecified"/>.</summary>
                public const string Unspecified = "LOG_TYPE_UNSPECIFIED";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.AuthorizationLoggingOptions"/> message.</summary>
        public static class AuthorizationLoggingOptions
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.AuthorizationLoggingOptions.Types.PermissionType"/> enum.</summary>
            public static class PermissionType
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.AuthorizationLoggingOptions.Types.PermissionType.UndefinedPermissionType"/>.</summary>
                public const string UndefinedPermissionType = "UNDEFINED_PERMISSION_TYPE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.AuthorizationLoggingOptions.Types.PermissionType.AdminRead"/>.</summary>
                public const string AdminRead = "ADMIN_READ";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.AuthorizationLoggingOptions.Types.PermissionType.AdminWrite"/>.</summary>
                public const string AdminWrite = "ADMIN_WRITE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.AuthorizationLoggingOptions.Types.PermissionType.DataRead"/>.</summary>
                public const string DataRead = "DATA_READ";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.AuthorizationLoggingOptions.Types.PermissionType.DataWrite"/>.</summary>
                public const string DataWrite = "DATA_WRITE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.AuthorizationLoggingOptions.Types.PermissionType.Unspecified"/>.</summary>
                public const string Unspecified = "PERMISSION_TYPE_UNSPECIFIED";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.Autoscaler"/> message.</summary>
        public static class Autoscaler
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.Autoscaler.Types.Status"/> enum.</summary>
            public static class Status
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Autoscaler.Types.Status.UndefinedStatus"/>.</summary>
                public const string UndefinedStatus = "UNDEFINED_STATUS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Autoscaler.Types.Status.Active"/>.</summary>
                public const string Active = "ACTIVE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Autoscaler.Types.Status.Deleting"/>.</summary>
                public const string Deleting = "DELETING";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Autoscaler.Types.Status.Error"/>.</summary>
                public const string Error = "ERROR";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Autoscaler.Types.Status.Pending"/>.</summary>
                public const string Pending = "PENDING";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.AutoscalerStatusDetails"/> message.</summary>
        public static class AutoscalerStatusDetails
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.AutoscalerStatusDetails.Types.Type"/> enum.</summary>
            public static class Type
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.AutoscalerStatusDetails.Types.Type.UndefinedType"/>.</summary>
                public const string UndefinedType = "UNDEFINED_TYPE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.AutoscalerStatusDetails.Types.Type.AllInstancesUnhealthy"/>.</summary>
                public const string AllInstancesUnhealthy = "ALL_INSTANCES_UNHEALTHY";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.AutoscalerStatusDetails.Types.Type.BackendServiceDoesNotExist"/>.</summary>
                public const string BackendServiceDoesNotExist = "BACKEND_SERVICE_DOES_NOT_EXIST";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.AutoscalerStatusDetails.Types.Type.CappedAtMaxNumReplicas"/>.</summary>
                public const string CappedAtMaxNumReplicas = "CAPPED_AT_MAX_NUM_REPLICAS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.AutoscalerStatusDetails.Types.Type.CustomMetricDataPointsTooSparse"/>.</summary>
                public const string CustomMetricDataPointsTooSparse = "CUSTOM_METRIC_DATA_POINTS_TOO_SPARSE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.AutoscalerStatusDetails.Types.Type.CustomMetricInvalid"/>.</summary>
                public const string CustomMetricInvalid = "CUSTOM_METRIC_INVALID";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.AutoscalerStatusDetails.Types.Type.MinEqualsMax"/>.</summary>
                public const string MinEqualsMax = "MIN_EQUALS_MAX";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.AutoscalerStatusDetails.Types.Type.MissingCustomMetricDataPoints"/>.</summary>
                public const string MissingCustomMetricDataPoints = "MISSING_CUSTOM_METRIC_DATA_POINTS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.AutoscalerStatusDetails.Types.Type.MissingLoadBalancingDataPoints"/>.</summary>
                public const string MissingLoadBalancingDataPoints = "MISSING_LOAD_BALANCING_DATA_POINTS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.AutoscalerStatusDetails.Types.Type.ModeOff"/>.</summary>
                public const string ModeOff = "MODE_OFF";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.AutoscalerStatusDetails.Types.Type.ModeOnlyScaleOut"/>.</summary>
                public const string ModeOnlyScaleOut = "MODE_ONLY_SCALE_OUT";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.AutoscalerStatusDetails.Types.Type.ModeOnlyUp"/>.</summary>
                public const string ModeOnlyUp = "MODE_ONLY_UP";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.AutoscalerStatusDetails.Types.Type.MoreThanOneBackendService"/>.</summary>
                public const string MoreThanOneBackendService = "MORE_THAN_ONE_BACKEND_SERVICE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.AutoscalerStatusDetails.Types.Type.NotEnoughQuotaAvailable"/>.</summary>
                public const string NotEnoughQuotaAvailable = "NOT_ENOUGH_QUOTA_AVAILABLE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.AutoscalerStatusDetails.Types.Type.RegionResourceStockout"/>.</summary>
                public const string RegionResourceStockout = "REGION_RESOURCE_STOCKOUT";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.AutoscalerStatusDetails.Types.Type.ScalingTargetDoesNotExist"/>.</summary>
                public const string ScalingTargetDoesNotExist = "SCALING_TARGET_DOES_NOT_EXIST";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.AutoscalerStatusDetails.Types.Type.ScheduledInstancesGreaterThanAutoscalerMax"/>.</summary>
                public const string ScheduledInstancesGreaterThanAutoscalerMax = "SCHEDULED_INSTANCES_GREATER_THAN_AUTOSCALER_MAX";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.AutoscalerStatusDetails.Types.Type.ScheduledInstancesLessThanAutoscalerMin"/>.</summary>
                public const string ScheduledInstancesLessThanAutoscalerMin = "SCHEDULED_INSTANCES_LESS_THAN_AUTOSCALER_MIN";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.AutoscalerStatusDetails.Types.Type.Unknown"/>.</summary>
                public const string Unknown = "UNKNOWN";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.AutoscalerStatusDetails.Types.Type.UnsupportedMaxRateLoadBalancingConfiguration"/>.</summary>
                public const string UnsupportedMaxRateLoadBalancingConfiguration = "UNSUPPORTED_MAX_RATE_LOAD_BALANCING_CONFIGURATION";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.AutoscalerStatusDetails.Types.Type.ZoneResourceStockout"/>.</summary>
                public const string ZoneResourceStockout = "ZONE_RESOURCE_STOCKOUT";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.AutoscalingPolicy"/> message.</summary>
        public static class AutoscalingPolicy
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.AutoscalingPolicy.Types.Mode"/> enum.</summary>
            public static class Mode
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.AutoscalingPolicy.Types.Mode.UndefinedMode"/>.</summary>
                public const string UndefinedMode = "UNDEFINED_MODE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.AutoscalingPolicy.Types.Mode.Off"/>.</summary>
                public const string Off = "OFF";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.AutoscalingPolicy.Types.Mode.On"/>.</summary>
                public const string On = "ON";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.AutoscalingPolicy.Types.Mode.OnlyScaleOut"/>.</summary>
                public const string OnlyScaleOut = "ONLY_SCALE_OUT";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.AutoscalingPolicy.Types.Mode.OnlyUp"/>.</summary>
                public const string OnlyUp = "ONLY_UP";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.AutoscalingPolicyCpuUtilization"/> message.</summary>
        public static class AutoscalingPolicyCpuUtilization
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.AutoscalingPolicyCpuUtilization.Types.PredictiveMethod"/> enum.</summary>
            public static class PredictiveMethod
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.AutoscalingPolicyCpuUtilization.Types.PredictiveMethod.UndefinedPredictiveMethod"/>.</summary>
                public const string UndefinedPredictiveMethod = "UNDEFINED_PREDICTIVE_METHOD";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.AutoscalingPolicyCpuUtilization.Types.PredictiveMethod.None"/>.</summary>
                public const string None = "NONE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.AutoscalingPolicyCpuUtilization.Types.PredictiveMethod.OptimizeAvailability"/>.</summary>
                public const string OptimizeAvailability = "OPTIMIZE_AVAILABILITY";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.AutoscalingPolicyCustomMetricUtilization"/> message.</summary>
        public static class AutoscalingPolicyCustomMetricUtilization
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.AutoscalingPolicyCustomMetricUtilization.Types.UtilizationTargetType"/> enum.</summary>
            public static class UtilizationTargetType
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.AutoscalingPolicyCustomMetricUtilization.Types.UtilizationTargetType.UndefinedUtilizationTargetType"/>.</summary>
                public const string UndefinedUtilizationTargetType = "UNDEFINED_UTILIZATION_TARGET_TYPE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.AutoscalingPolicyCustomMetricUtilization.Types.UtilizationTargetType.DeltaPerMinute"/>.</summary>
                public const string DeltaPerMinute = "DELTA_PER_MINUTE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.AutoscalingPolicyCustomMetricUtilization.Types.UtilizationTargetType.DeltaPerSecond"/>.</summary>
                public const string DeltaPerSecond = "DELTA_PER_SECOND";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.AutoscalingPolicyCustomMetricUtilization.Types.UtilizationTargetType.Gauge"/>.</summary>
                public const string Gauge = "GAUGE";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.Backend"/> message.</summary>
        public static class Backend
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.Backend.Types.BalancingMode"/> enum.</summary>
            public static class BalancingMode
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Backend.Types.BalancingMode.UndefinedBalancingMode"/>.</summary>
                public const string UndefinedBalancingMode = "UNDEFINED_BALANCING_MODE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Backend.Types.BalancingMode.Connection"/>.</summary>
                public const string Connection = "CONNECTION";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Backend.Types.BalancingMode.Rate"/>.</summary>
                public const string Rate = "RATE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Backend.Types.BalancingMode.Utilization"/>.</summary>
                public const string Utilization = "UTILIZATION";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.BackendBucketCdnPolicy"/> message.</summary>
        public static class BackendBucketCdnPolicy
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.BackendBucketCdnPolicy.Types.CacheMode"/> enum.</summary>
            public static class CacheMode
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.BackendBucketCdnPolicy.Types.CacheMode.UndefinedCacheMode"/>.</summary>
                public const string UndefinedCacheMode = "UNDEFINED_CACHE_MODE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.BackendBucketCdnPolicy.Types.CacheMode.CacheAllStatic"/>.</summary>
                public const string CacheAllStatic = "CACHE_ALL_STATIC";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.BackendBucketCdnPolicy.Types.CacheMode.ForceCacheAll"/>.</summary>
                public const string ForceCacheAll = "FORCE_CACHE_ALL";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.BackendBucketCdnPolicy.Types.CacheMode.InvalidCacheMode"/>.</summary>
                public const string InvalidCacheMode = "INVALID_CACHE_MODE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.BackendBucketCdnPolicy.Types.CacheMode.UseOriginHeaders"/>.</summary>
                public const string UseOriginHeaders = "USE_ORIGIN_HEADERS";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.BackendService"/> message.</summary>
        public static class BackendService
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.BackendService.Types.LoadBalancingScheme"/> enum.</summary>
            public static class LoadBalancingScheme
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.BackendService.Types.LoadBalancingScheme.UndefinedLoadBalancingScheme"/>.</summary>
                public const string UndefinedLoadBalancingScheme = "UNDEFINED_LOAD_BALANCING_SCHEME";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.BackendService.Types.LoadBalancingScheme.External"/>.</summary>
                public const string External = "EXTERNAL";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.BackendService.Types.LoadBalancingScheme.ExternalManaged"/>.</summary>
                public const string ExternalManaged = "EXTERNAL_MANAGED";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.BackendService.Types.LoadBalancingScheme.Internal"/>.</summary>
                public const string Internal = "INTERNAL";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.BackendService.Types.LoadBalancingScheme.InternalManaged"/>.</summary>
                public const string InternalManaged = "INTERNAL_MANAGED";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.BackendService.Types.LoadBalancingScheme.InternalSelfManaged"/>.</summary>
                public const string InternalSelfManaged = "INTERNAL_SELF_MANAGED";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.BackendService.Types.LoadBalancingScheme.InvalidLoadBalancingScheme"/>.</summary>
                public const string InvalidLoadBalancingScheme = "INVALID_LOAD_BALANCING_SCHEME";
            }

            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.BackendService.Types.LocalityLbPolicy"/> enum.</summary>
            public static class LocalityLbPolicy
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.BackendService.Types.LocalityLbPolicy.UndefinedLocalityLbPolicy"/>.</summary>
                public const string UndefinedLocalityLbPolicy = "UNDEFINED_LOCALITY_LB_POLICY";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.BackendService.Types.LocalityLbPolicy.InvalidLbPolicy"/>.</summary>
                public const string InvalidLbPolicy = "INVALID_LB_POLICY";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.BackendService.Types.LocalityLbPolicy.LeastRequest"/>.</summary>
                public const string LeastRequest = "LEAST_REQUEST";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.BackendService.Types.LocalityLbPolicy.Maglev"/>.</summary>
                public const string Maglev = "MAGLEV";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.BackendService.Types.LocalityLbPolicy.OriginalDestination"/>.</summary>
                public const string OriginalDestination = "ORIGINAL_DESTINATION";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.BackendService.Types.LocalityLbPolicy.Random"/>.</summary>
                public const string Random = "RANDOM";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.BackendService.Types.LocalityLbPolicy.RingHash"/>.</summary>
                public const string RingHash = "RING_HASH";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.BackendService.Types.LocalityLbPolicy.RoundRobin"/>.</summary>
                public const string RoundRobin = "ROUND_ROBIN";
            }

            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.BackendService.Types.Protocol"/> enum.</summary>
            public static class Protocol
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.BackendService.Types.Protocol.UndefinedProtocol"/>.</summary>
                public const string UndefinedProtocol = "UNDEFINED_PROTOCOL";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.BackendService.Types.Protocol.Grpc"/>.</summary>
                public const string Grpc = "GRPC";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.BackendService.Types.Protocol.Http"/>.</summary>
                public const string Http = "HTTP";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.BackendService.Types.Protocol.Http2"/>.</summary>
                public const string Http2 = "HTTP2";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.BackendService.Types.Protocol.Https"/>.</summary>
                public const string Https = "HTTPS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.BackendService.Types.Protocol.Ssl"/>.</summary>
                public const string Ssl = "SSL";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.BackendService.Types.Protocol.Tcp"/>.</summary>
                public const string Tcp = "TCP";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.BackendService.Types.Protocol.Udp"/>.</summary>
                public const string Udp = "UDP";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.BackendService.Types.Protocol.Unspecified"/>.</summary>
                public const string Unspecified = "UNSPECIFIED";
            }

            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.BackendService.Types.SessionAffinity"/> enum.</summary>
            public static class SessionAffinity
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.BackendService.Types.SessionAffinity.UndefinedSessionAffinity"/>.</summary>
                public const string UndefinedSessionAffinity = "UNDEFINED_SESSION_AFFINITY";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.BackendService.Types.SessionAffinity.ClientIp"/>.</summary>
                public const string ClientIp = "CLIENT_IP";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.BackendService.Types.SessionAffinity.ClientIpNoDestination"/>.</summary>
                public const string ClientIpNoDestination = "CLIENT_IP_NO_DESTINATION";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.BackendService.Types.SessionAffinity.ClientIpPortProto"/>.</summary>
                public const string ClientIpPortProto = "CLIENT_IP_PORT_PROTO";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.BackendService.Types.SessionAffinity.ClientIpProto"/>.</summary>
                public const string ClientIpProto = "CLIENT_IP_PROTO";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.BackendService.Types.SessionAffinity.GeneratedCookie"/>.</summary>
                public const string GeneratedCookie = "GENERATED_COOKIE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.BackendService.Types.SessionAffinity.HeaderField"/>.</summary>
                public const string HeaderField = "HEADER_FIELD";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.BackendService.Types.SessionAffinity.HttpCookie"/>.</summary>
                public const string HttpCookie = "HTTP_COOKIE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.BackendService.Types.SessionAffinity.None"/>.</summary>
                public const string None = "NONE";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.BackendServiceCdnPolicy"/> message.</summary>
        public static class BackendServiceCdnPolicy
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.BackendServiceCdnPolicy.Types.CacheMode"/> enum.</summary>
            public static class CacheMode
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.BackendServiceCdnPolicy.Types.CacheMode.UndefinedCacheMode"/>.</summary>
                public const string UndefinedCacheMode = "UNDEFINED_CACHE_MODE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.BackendServiceCdnPolicy.Types.CacheMode.CacheAllStatic"/>.</summary>
                public const string CacheAllStatic = "CACHE_ALL_STATIC";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.BackendServiceCdnPolicy.Types.CacheMode.ForceCacheAll"/>.</summary>
                public const string ForceCacheAll = "FORCE_CACHE_ALL";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.BackendServiceCdnPolicy.Types.CacheMode.InvalidCacheMode"/>.</summary>
                public const string InvalidCacheMode = "INVALID_CACHE_MODE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.BackendServiceCdnPolicy.Types.CacheMode.UseOriginHeaders"/>.</summary>
                public const string UseOriginHeaders = "USE_ORIGIN_HEADERS";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.BackendServiceConnectionTrackingPolicy"/> message.</summary>
        public static class BackendServiceConnectionTrackingPolicy
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.BackendServiceConnectionTrackingPolicy.Types.ConnectionPersistenceOnUnhealthyBackends"/> enum.</summary>
            public static class ConnectionPersistenceOnUnhealthyBackends
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.BackendServiceConnectionTrackingPolicy.Types.ConnectionPersistenceOnUnhealthyBackends.UndefinedConnectionPersistenceOnUnhealthyBackends"/>.</summary>
                public const string UndefinedConnectionPersistenceOnUnhealthyBackends = "UNDEFINED_CONNECTION_PERSISTENCE_ON_UNHEALTHY_BACKENDS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.BackendServiceConnectionTrackingPolicy.Types.ConnectionPersistenceOnUnhealthyBackends.AlwaysPersist"/>.</summary>
                public const string AlwaysPersist = "ALWAYS_PERSIST";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.BackendServiceConnectionTrackingPolicy.Types.ConnectionPersistenceOnUnhealthyBackends.DefaultForProtocol"/>.</summary>
                public const string DefaultForProtocol = "DEFAULT_FOR_PROTOCOL";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.BackendServiceConnectionTrackingPolicy.Types.ConnectionPersistenceOnUnhealthyBackends.NeverPersist"/>.</summary>
                public const string NeverPersist = "NEVER_PERSIST";
            }

            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.BackendServiceConnectionTrackingPolicy.Types.TrackingMode"/> enum.</summary>
            public static class TrackingMode
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.BackendServiceConnectionTrackingPolicy.Types.TrackingMode.UndefinedTrackingMode"/>.</summary>
                public const string UndefinedTrackingMode = "UNDEFINED_TRACKING_MODE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.BackendServiceConnectionTrackingPolicy.Types.TrackingMode.InvalidTrackingMode"/>.</summary>
                public const string InvalidTrackingMode = "INVALID_TRACKING_MODE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.BackendServiceConnectionTrackingPolicy.Types.TrackingMode.PerConnection"/>.</summary>
                public const string PerConnection = "PER_CONNECTION";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.BackendServiceConnectionTrackingPolicy.Types.TrackingMode.PerSession"/>.</summary>
                public const string PerSession = "PER_SESSION";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.BfdPacket"/> message.</summary>
        public static class BfdPacket
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.BfdPacket.Types.Diagnostic"/> enum.</summary>
            public static class Diagnostic
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.BfdPacket.Types.Diagnostic.UndefinedDiagnostic"/>.</summary>
                public const string UndefinedDiagnostic = "UNDEFINED_DIAGNOSTIC";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.BfdPacket.Types.Diagnostic.AdministrativelyDown"/>.</summary>
                public const string AdministrativelyDown = "ADMINISTRATIVELY_DOWN";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.BfdPacket.Types.Diagnostic.ConcatenatedPathDown"/>.</summary>
                public const string ConcatenatedPathDown = "CONCATENATED_PATH_DOWN";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.BfdPacket.Types.Diagnostic.ControlDetectionTimeExpired"/>.</summary>
                public const string ControlDetectionTimeExpired = "CONTROL_DETECTION_TIME_EXPIRED";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.BfdPacket.Types.Diagnostic.Unspecified"/>.</summary>
                public const string Unspecified = "DIAGNOSTIC_UNSPECIFIED";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.BfdPacket.Types.Diagnostic.EchoFunctionFailed"/>.</summary>
                public const string EchoFunctionFailed = "ECHO_FUNCTION_FAILED";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.BfdPacket.Types.Diagnostic.ForwardingPlaneReset"/>.</summary>
                public const string ForwardingPlaneReset = "FORWARDING_PLANE_RESET";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.BfdPacket.Types.Diagnostic.NeighborSignaledSessionDown"/>.</summary>
                public const string NeighborSignaledSessionDown = "NEIGHBOR_SIGNALED_SESSION_DOWN";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.BfdPacket.Types.Diagnostic.NoDiagnostic"/>.</summary>
                public const string NoDiagnostic = "NO_DIAGNOSTIC";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.BfdPacket.Types.Diagnostic.PathDown"/>.</summary>
                public const string PathDown = "PATH_DOWN";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.BfdPacket.Types.Diagnostic.ReverseConcatenatedPathDown"/>.</summary>
                public const string ReverseConcatenatedPathDown = "REVERSE_CONCATENATED_PATH_DOWN";
            }

            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.BfdPacket.Types.State"/> enum.</summary>
            public static class State
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.BfdPacket.Types.State.UndefinedState"/>.</summary>
                public const string UndefinedState = "UNDEFINED_STATE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.BfdPacket.Types.State.AdminDown"/>.</summary>
                public const string AdminDown = "ADMIN_DOWN";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.BfdPacket.Types.State.Down"/>.</summary>
                public const string Down = "DOWN";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.BfdPacket.Types.State.Init"/>.</summary>
                public const string Init = "INIT";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.BfdPacket.Types.State.Unspecified"/>.</summary>
                public const string Unspecified = "STATE_UNSPECIFIED";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.BfdPacket.Types.State.Up"/>.</summary>
                public const string Up = "UP";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.BfdStatus"/> message.</summary>
        public static class BfdStatus
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.BfdStatus.Types.BfdSessionInitializationMode"/> enum.</summary>
            public static class BfdSessionInitializationMode
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.BfdStatus.Types.BfdSessionInitializationMode.UndefinedBfdSessionInitializationMode"/>.</summary>
                public const string UndefinedBfdSessionInitializationMode = "UNDEFINED_BFD_SESSION_INITIALIZATION_MODE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.BfdStatus.Types.BfdSessionInitializationMode.Active"/>.</summary>
                public const string Active = "ACTIVE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.BfdStatus.Types.BfdSessionInitializationMode.Disabled"/>.</summary>
                public const string Disabled = "DISABLED";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.BfdStatus.Types.BfdSessionInitializationMode.Passive"/>.</summary>
                public const string Passive = "PASSIVE";
            }

            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.BfdStatus.Types.LocalDiagnostic"/> enum.</summary>
            public static class LocalDiagnostic
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.BfdStatus.Types.LocalDiagnostic.UndefinedLocalDiagnostic"/>.</summary>
                public const string UndefinedLocalDiagnostic = "UNDEFINED_LOCAL_DIAGNOSTIC";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.BfdStatus.Types.LocalDiagnostic.AdministrativelyDown"/>.</summary>
                public const string AdministrativelyDown = "ADMINISTRATIVELY_DOWN";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.BfdStatus.Types.LocalDiagnostic.ConcatenatedPathDown"/>.</summary>
                public const string ConcatenatedPathDown = "CONCATENATED_PATH_DOWN";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.BfdStatus.Types.LocalDiagnostic.ControlDetectionTimeExpired"/>.</summary>
                public const string ControlDetectionTimeExpired = "CONTROL_DETECTION_TIME_EXPIRED";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.BfdStatus.Types.LocalDiagnostic.DiagnosticUnspecified"/>.</summary>
                public const string DiagnosticUnspecified = "DIAGNOSTIC_UNSPECIFIED";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.BfdStatus.Types.LocalDiagnostic.EchoFunctionFailed"/>.</summary>
                public const string EchoFunctionFailed = "ECHO_FUNCTION_FAILED";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.BfdStatus.Types.LocalDiagnostic.ForwardingPlaneReset"/>.</summary>
                public const string ForwardingPlaneReset = "FORWARDING_PLANE_RESET";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.BfdStatus.Types.LocalDiagnostic.NeighborSignaledSessionDown"/>.</summary>
                public const string NeighborSignaledSessionDown = "NEIGHBOR_SIGNALED_SESSION_DOWN";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.BfdStatus.Types.LocalDiagnostic.NoDiagnostic"/>.</summary>
                public const string NoDiagnostic = "NO_DIAGNOSTIC";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.BfdStatus.Types.LocalDiagnostic.PathDown"/>.</summary>
                public const string PathDown = "PATH_DOWN";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.BfdStatus.Types.LocalDiagnostic.ReverseConcatenatedPathDown"/>.</summary>
                public const string ReverseConcatenatedPathDown = "REVERSE_CONCATENATED_PATH_DOWN";
            }

            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.BfdStatus.Types.LocalState"/> enum.</summary>
            public static class LocalState
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.BfdStatus.Types.LocalState.UndefinedLocalState"/>.</summary>
                public const string UndefinedLocalState = "UNDEFINED_LOCAL_STATE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.BfdStatus.Types.LocalState.AdminDown"/>.</summary>
                public const string AdminDown = "ADMIN_DOWN";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.BfdStatus.Types.LocalState.Down"/>.</summary>
                public const string Down = "DOWN";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.BfdStatus.Types.LocalState.Init"/>.</summary>
                public const string Init = "INIT";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.BfdStatus.Types.LocalState.StateUnspecified"/>.</summary>
                public const string StateUnspecified = "STATE_UNSPECIFIED";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.BfdStatus.Types.LocalState.Up"/>.</summary>
                public const string Up = "UP";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.Commitment"/> message.</summary>
        public static class Commitment
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.Commitment.Types.Category"/> enum.</summary>
            public static class Category
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Commitment.Types.Category.UndefinedCategory"/>.</summary>
                public const string UndefinedCategory = "UNDEFINED_CATEGORY";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Commitment.Types.Category.Unspecified"/>.</summary>
                public const string Unspecified = "CATEGORY_UNSPECIFIED";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Commitment.Types.Category.License"/>.</summary>
                public const string License = "LICENSE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Commitment.Types.Category.Machine"/>.</summary>
                public const string Machine = "MACHINE";
            }

            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.Commitment.Types.Plan"/> enum.</summary>
            public static class Plan
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Commitment.Types.Plan.UndefinedPlan"/>.</summary>
                public const string UndefinedPlan = "UNDEFINED_PLAN";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Commitment.Types.Plan.Invalid"/>.</summary>
                public const string Invalid = "INVALID";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Commitment.Types.Plan.ThirtySixMonth"/>.</summary>
                public const string ThirtySixMonth = "THIRTY_SIX_MONTH";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Commitment.Types.Plan.TwelveMonth"/>.</summary>
                public const string TwelveMonth = "TWELVE_MONTH";
            }

            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.Commitment.Types.Status"/> enum.</summary>
            public static class Status
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Commitment.Types.Status.UndefinedStatus"/>.</summary>
                public const string UndefinedStatus = "UNDEFINED_STATUS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Commitment.Types.Status.Active"/>.</summary>
                public const string Active = "ACTIVE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Commitment.Types.Status.Creating"/>.</summary>
                public const string Creating = "CREATING";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Commitment.Types.Status.Expired"/>.</summary>
                public const string Expired = "EXPIRED";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Commitment.Types.Status.NotYetActive"/>.</summary>
                public const string NotYetActive = "NOT_YET_ACTIVE";
            }

            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.Commitment.Types.Type"/> enum.</summary>
            public static class Type
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Commitment.Types.Type.UndefinedType"/>.</summary>
                public const string UndefinedType = "UNDEFINED_TYPE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Commitment.Types.Type.AcceleratorOptimized"/>.</summary>
                public const string AcceleratorOptimized = "ACCELERATOR_OPTIMIZED";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Commitment.Types.Type.ComputeOptimized"/>.</summary>
                public const string ComputeOptimized = "COMPUTE_OPTIMIZED";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Commitment.Types.Type.ComputeOptimizedC2D"/>.</summary>
                public const string ComputeOptimizedC2D = "COMPUTE_OPTIMIZED_C2D";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Commitment.Types.Type.GeneralPurpose"/>.</summary>
                public const string GeneralPurpose = "GENERAL_PURPOSE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Commitment.Types.Type.GeneralPurposeE2"/>.</summary>
                public const string GeneralPurposeE2 = "GENERAL_PURPOSE_E2";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Commitment.Types.Type.GeneralPurposeN2"/>.</summary>
                public const string GeneralPurposeN2 = "GENERAL_PURPOSE_N2";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Commitment.Types.Type.GeneralPurposeN2D"/>.</summary>
                public const string GeneralPurposeN2D = "GENERAL_PURPOSE_N2D";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Commitment.Types.Type.GeneralPurposeT2D"/>.</summary>
                public const string GeneralPurposeT2D = "GENERAL_PURPOSE_T2D";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Commitment.Types.Type.MemoryOptimized"/>.</summary>
                public const string MemoryOptimized = "MEMORY_OPTIMIZED";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Commitment.Types.Type.Unspecified"/>.</summary>
                public const string Unspecified = "TYPE_UNSPECIFIED";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.DeprecationStatus"/> message.</summary>
        public static class DeprecationStatus
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.DeprecationStatus.Types.State"/> enum.</summary>
            public static class State
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.DeprecationStatus.Types.State.UndefinedState"/>.</summary>
                public const string UndefinedState = "UNDEFINED_STATE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.DeprecationStatus.Types.State.Active"/>.</summary>
                public const string Active = "ACTIVE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.DeprecationStatus.Types.State.Deleted"/>.</summary>
                public const string Deleted = "DELETED";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.DeprecationStatus.Types.State.Deprecated"/>.</summary>
                public const string Deprecated = "DEPRECATED";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.DeprecationStatus.Types.State.Obsolete"/>.</summary>
                public const string Obsolete = "OBSOLETE";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.Disk"/> message.</summary>
        public static class Disk
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.Disk.Types.Status"/> enum.</summary>
            public static class Status
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Disk.Types.Status.UndefinedStatus"/>.</summary>
                public const string UndefinedStatus = "UNDEFINED_STATUS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Disk.Types.Status.Creating"/>.</summary>
                public const string Creating = "CREATING";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Disk.Types.Status.Deleting"/>.</summary>
                public const string Deleting = "DELETING";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Disk.Types.Status.Failed"/>.</summary>
                public const string Failed = "FAILED";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Disk.Types.Status.Ready"/>.</summary>
                public const string Ready = "READY";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Disk.Types.Status.Restoring"/>.</summary>
                public const string Restoring = "RESTORING";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.DiskInstantiationConfig"/> message.</summary>
        public static class DiskInstantiationConfig
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.DiskInstantiationConfig.Types.InstantiateFrom"/> enum.</summary>
            public static class InstantiateFrom
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.DiskInstantiationConfig.Types.InstantiateFrom.UndefinedInstantiateFrom"/>.</summary>
                public const string UndefinedInstantiateFrom = "UNDEFINED_INSTANTIATE_FROM";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.DiskInstantiationConfig.Types.InstantiateFrom.AttachReadOnly"/>.</summary>
                public const string AttachReadOnly = "ATTACH_READ_ONLY";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.DiskInstantiationConfig.Types.InstantiateFrom.Blank"/>.</summary>
                public const string Blank = "BLANK";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.DiskInstantiationConfig.Types.InstantiateFrom.CustomImage"/>.</summary>
                public const string CustomImage = "CUSTOM_IMAGE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.DiskInstantiationConfig.Types.InstantiateFrom.Default"/>.</summary>
                public const string Default = "DEFAULT";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.DiskInstantiationConfig.Types.InstantiateFrom.DoNotInclude"/>.</summary>
                public const string DoNotInclude = "DO_NOT_INCLUDE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.DiskInstantiationConfig.Types.InstantiateFrom.SourceImage"/>.</summary>
                public const string SourceImage = "SOURCE_IMAGE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.DiskInstantiationConfig.Types.InstantiateFrom.SourceImageFamily"/>.</summary>
                public const string SourceImageFamily = "SOURCE_IMAGE_FAMILY";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.DistributionPolicy"/> message.</summary>
        public static class DistributionPolicy
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.DistributionPolicy.Types.TargetShape"/> enum.</summary>
            public static class TargetShape
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.DistributionPolicy.Types.TargetShape.UndefinedTargetShape"/>.</summary>
                public const string UndefinedTargetShape = "UNDEFINED_TARGET_SHAPE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.DistributionPolicy.Types.TargetShape.Any"/>.</summary>
                public const string Any = "ANY";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.DistributionPolicy.Types.TargetShape.Balanced"/>.</summary>
                public const string Balanced = "BALANCED";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.DistributionPolicy.Types.TargetShape.Even"/>.</summary>
                public const string Even = "EVEN";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.ExchangedPeeringRoute"/> message.</summary>
        public static class ExchangedPeeringRoute
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.ExchangedPeeringRoute.Types.Type"/> enum.</summary>
            public static class Type
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ExchangedPeeringRoute.Types.Type.UndefinedType"/>.</summary>
                public const string UndefinedType = "UNDEFINED_TYPE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ExchangedPeeringRoute.Types.Type.DynamicPeeringRoute"/>.</summary>
                public const string DynamicPeeringRoute = "DYNAMIC_PEERING_ROUTE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ExchangedPeeringRoute.Types.Type.StaticPeeringRoute"/>.</summary>
                public const string StaticPeeringRoute = "STATIC_PEERING_ROUTE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ExchangedPeeringRoute.Types.Type.SubnetPeeringRoute"/>.</summary>
                public const string SubnetPeeringRoute = "SUBNET_PEERING_ROUTE";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.ExternalVpnGateway"/> message.</summary>
        public static class ExternalVpnGateway
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.ExternalVpnGateway.Types.RedundancyType"/> enum.</summary>
            public static class RedundancyType
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ExternalVpnGateway.Types.RedundancyType.UndefinedRedundancyType"/>.</summary>
                public const string UndefinedRedundancyType = "UNDEFINED_REDUNDANCY_TYPE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ExternalVpnGateway.Types.RedundancyType.FourIpsRedundancy"/>.</summary>
                public const string FourIpsRedundancy = "FOUR_IPS_REDUNDANCY";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ExternalVpnGateway.Types.RedundancyType.SingleIpInternallyRedundant"/>.</summary>
                public const string SingleIpInternallyRedundant = "SINGLE_IP_INTERNALLY_REDUNDANT";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ExternalVpnGateway.Types.RedundancyType.TwoIpsRedundancy"/>.</summary>
                public const string TwoIpsRedundancy = "TWO_IPS_REDUNDANCY";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.FileContentBuffer"/> message.</summary>
        public static class FileContentBuffer
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.FileContentBuffer.Types.FileType"/> enum.</summary>
            public static class FileType
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.FileContentBuffer.Types.FileType.UndefinedFileType"/>.</summary>
                public const string UndefinedFileType = "UNDEFINED_FILE_TYPE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.FileContentBuffer.Types.FileType.Bin"/>.</summary>
                public const string Bin = "BIN";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.FileContentBuffer.Types.FileType.Undefined"/>.</summary>
                public const string Undefined = "UNDEFINED";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.FileContentBuffer.Types.FileType.X509"/>.</summary>
                public const string X509 = "X509";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.Firewall"/> message.</summary>
        public static class Firewall
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.Firewall.Types.Direction"/> enum.</summary>
            public static class Direction
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Firewall.Types.Direction.UndefinedDirection"/>.</summary>
                public const string UndefinedDirection = "UNDEFINED_DIRECTION";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Firewall.Types.Direction.Egress"/>.</summary>
                public const string Egress = "EGRESS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Firewall.Types.Direction.Ingress"/>.</summary>
                public const string Ingress = "INGRESS";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.FirewallLogConfig"/> message.</summary>
        public static class FirewallLogConfig
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.FirewallLogConfig.Types.Metadata"/> enum.</summary>
            public static class Metadata
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.FirewallLogConfig.Types.Metadata.UndefinedMetadata"/>.</summary>
                public const string UndefinedMetadata = "UNDEFINED_METADATA";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.FirewallLogConfig.Types.Metadata.ExcludeAllMetadata"/>.</summary>
                public const string ExcludeAllMetadata = "EXCLUDE_ALL_METADATA";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.FirewallLogConfig.Types.Metadata.IncludeAllMetadata"/>.</summary>
                public const string IncludeAllMetadata = "INCLUDE_ALL_METADATA";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.FirewallPolicyRule"/> message.</summary>
        public static class FirewallPolicyRule
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.FirewallPolicyRule.Types.Direction"/> enum.</summary>
            public static class Direction
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.FirewallPolicyRule.Types.Direction.UndefinedDirection"/>.</summary>
                public const string UndefinedDirection = "UNDEFINED_DIRECTION";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.FirewallPolicyRule.Types.Direction.Egress"/>.</summary>
                public const string Egress = "EGRESS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.FirewallPolicyRule.Types.Direction.Ingress"/>.</summary>
                public const string Ingress = "INGRESS";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.ForwardingRule"/> message.</summary>
        public static class ForwardingRule
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.ForwardingRule.Types.IPProtocolEnum"/> enum.</summary>
            public static class IPProtocolEnum
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ForwardingRule.Types.IPProtocolEnum.UndefinedIPProtocolEnum"/>.</summary>
                public const string UndefinedIPProtocolEnum = "UNDEFINED_I_P_PROTOCOL_ENUM";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ForwardingRule.Types.IPProtocolEnum.Ah"/>.</summary>
                public const string Ah = "AH";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ForwardingRule.Types.IPProtocolEnum.Esp"/>.</summary>
                public const string Esp = "ESP";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ForwardingRule.Types.IPProtocolEnum.Icmp"/>.</summary>
                public const string Icmp = "ICMP";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ForwardingRule.Types.IPProtocolEnum.L3Default"/>.</summary>
                public const string L3Default = "L3_DEFAULT";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ForwardingRule.Types.IPProtocolEnum.Sctp"/>.</summary>
                public const string Sctp = "SCTP";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ForwardingRule.Types.IPProtocolEnum.Tcp"/>.</summary>
                public const string Tcp = "TCP";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ForwardingRule.Types.IPProtocolEnum.Udp"/>.</summary>
                public const string Udp = "UDP";
            }

            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.ForwardingRule.Types.IpVersion"/> enum.</summary>
            public static class IpVersion
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ForwardingRule.Types.IpVersion.UndefinedIpVersion"/>.</summary>
                public const string UndefinedIpVersion = "UNDEFINED_IP_VERSION";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ForwardingRule.Types.IpVersion.Ipv4"/>.</summary>
                public const string Ipv4 = "IPV4";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ForwardingRule.Types.IpVersion.Ipv6"/>.</summary>
                public const string Ipv6 = "IPV6";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ForwardingRule.Types.IpVersion.UnspecifiedVersion"/>.</summary>
                public const string UnspecifiedVersion = "UNSPECIFIED_VERSION";
            }

            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.ForwardingRule.Types.LoadBalancingScheme"/> enum.</summary>
            public static class LoadBalancingScheme
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ForwardingRule.Types.LoadBalancingScheme.UndefinedLoadBalancingScheme"/>.</summary>
                public const string UndefinedLoadBalancingScheme = "UNDEFINED_LOAD_BALANCING_SCHEME";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ForwardingRule.Types.LoadBalancingScheme.External"/>.</summary>
                public const string External = "EXTERNAL";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ForwardingRule.Types.LoadBalancingScheme.ExternalManaged"/>.</summary>
                public const string ExternalManaged = "EXTERNAL_MANAGED";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ForwardingRule.Types.LoadBalancingScheme.Internal"/>.</summary>
                public const string Internal = "INTERNAL";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ForwardingRule.Types.LoadBalancingScheme.InternalManaged"/>.</summary>
                public const string InternalManaged = "INTERNAL_MANAGED";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ForwardingRule.Types.LoadBalancingScheme.InternalSelfManaged"/>.</summary>
                public const string InternalSelfManaged = "INTERNAL_SELF_MANAGED";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ForwardingRule.Types.LoadBalancingScheme.Invalid"/>.</summary>
                public const string Invalid = "INVALID";
            }

            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.ForwardingRule.Types.NetworkTier"/> enum.</summary>
            public static class NetworkTier
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ForwardingRule.Types.NetworkTier.UndefinedNetworkTier"/>.</summary>
                public const string UndefinedNetworkTier = "UNDEFINED_NETWORK_TIER";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ForwardingRule.Types.NetworkTier.FixedStandard"/>.</summary>
                public const string FixedStandard = "FIXED_STANDARD";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ForwardingRule.Types.NetworkTier.Premium"/>.</summary>
                public const string Premium = "PREMIUM";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ForwardingRule.Types.NetworkTier.Standard"/>.</summary>
                public const string Standard = "STANDARD";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ForwardingRule.Types.NetworkTier.StandardOverridesFixedStandard"/>.</summary>
                public const string StandardOverridesFixedStandard = "STANDARD_OVERRIDES_FIXED_STANDARD";
            }

            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.ForwardingRule.Types.PscConnectionStatus"/> enum.</summary>
            public static class PscConnectionStatus
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ForwardingRule.Types.PscConnectionStatus.UndefinedPscConnectionStatus"/>.</summary>
                public const string UndefinedPscConnectionStatus = "UNDEFINED_PSC_CONNECTION_STATUS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ForwardingRule.Types.PscConnectionStatus.Accepted"/>.</summary>
                public const string Accepted = "ACCEPTED";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ForwardingRule.Types.PscConnectionStatus.Closed"/>.</summary>
                public const string Closed = "CLOSED";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ForwardingRule.Types.PscConnectionStatus.Pending"/>.</summary>
                public const string Pending = "PENDING";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ForwardingRule.Types.PscConnectionStatus.Rejected"/>.</summary>
                public const string Rejected = "REJECTED";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ForwardingRule.Types.PscConnectionStatus.StatusUnspecified"/>.</summary>
                public const string StatusUnspecified = "STATUS_UNSPECIFIED";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.GRPCHealthCheck"/> message.</summary>
        public static class GRPCHealthCheck
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.GRPCHealthCheck.Types.PortSpecification"/> enum.</summary>
            public static class PortSpecification
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.GRPCHealthCheck.Types.PortSpecification.UndefinedPortSpecification"/>.</summary>
                public const string UndefinedPortSpecification = "UNDEFINED_PORT_SPECIFICATION";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.GRPCHealthCheck.Types.PortSpecification.UseFixedPort"/>.</summary>
                public const string UseFixedPort = "USE_FIXED_PORT";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.GRPCHealthCheck.Types.PortSpecification.UseNamedPort"/>.</summary>
                public const string UseNamedPort = "USE_NAMED_PORT";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.GRPCHealthCheck.Types.PortSpecification.UseServingPort"/>.</summary>
                public const string UseServingPort = "USE_SERVING_PORT";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.GuestOsFeature"/> message.</summary>
        public static class GuestOsFeature
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.GuestOsFeature.Types.Type"/> enum.</summary>
            public static class Type
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.GuestOsFeature.Types.Type.UndefinedType"/>.</summary>
                public const string UndefinedType = "UNDEFINED_TYPE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.GuestOsFeature.Types.Type.FeatureTypeUnspecified"/>.</summary>
                public const string FeatureTypeUnspecified = "FEATURE_TYPE_UNSPECIFIED";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.GuestOsFeature.Types.Type.Gvnic"/>.</summary>
                public const string Gvnic = "GVNIC";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.GuestOsFeature.Types.Type.MultiIpSubnet"/>.</summary>
                public const string MultiIpSubnet = "MULTI_IP_SUBNET";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.GuestOsFeature.Types.Type.SecureBoot"/>.</summary>
                public const string SecureBoot = "SECURE_BOOT";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.GuestOsFeature.Types.Type.SevCapable"/>.</summary>
                public const string SevCapable = "SEV_CAPABLE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.GuestOsFeature.Types.Type.UefiCompatible"/>.</summary>
                public const string UefiCompatible = "UEFI_COMPATIBLE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.GuestOsFeature.Types.Type.VirtioScsiMultiqueue"/>.</summary>
                public const string VirtioScsiMultiqueue = "VIRTIO_SCSI_MULTIQUEUE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.GuestOsFeature.Types.Type.Windows"/>.</summary>
                public const string Windows = "WINDOWS";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.HTTP2HealthCheck"/> message.</summary>
        public static class HTTP2HealthCheck
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.HTTP2HealthCheck.Types.PortSpecification"/> enum.</summary>
            public static class PortSpecification
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.HTTP2HealthCheck.Types.PortSpecification.UndefinedPortSpecification"/>.</summary>
                public const string UndefinedPortSpecification = "UNDEFINED_PORT_SPECIFICATION";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.HTTP2HealthCheck.Types.PortSpecification.UseFixedPort"/>.</summary>
                public const string UseFixedPort = "USE_FIXED_PORT";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.HTTP2HealthCheck.Types.PortSpecification.UseNamedPort"/>.</summary>
                public const string UseNamedPort = "USE_NAMED_PORT";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.HTTP2HealthCheck.Types.PortSpecification.UseServingPort"/>.</summary>
                public const string UseServingPort = "USE_SERVING_PORT";
            }

            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.HTTP2HealthCheck.Types.ProxyHeader"/> enum.</summary>
            public static class ProxyHeader
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.HTTP2HealthCheck.Types.ProxyHeader.UndefinedProxyHeader"/>.</summary>
                public const string UndefinedProxyHeader = "UNDEFINED_PROXY_HEADER";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.HTTP2HealthCheck.Types.ProxyHeader.None"/>.</summary>
                public const string None = "NONE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.HTTP2HealthCheck.Types.ProxyHeader.ProxyV1"/>.</summary>
                public const string ProxyV1 = "PROXY_V1";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.HTTPHealthCheck"/> message.</summary>
        public static class HTTPHealthCheck
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.HTTPHealthCheck.Types.PortSpecification"/> enum.</summary>
            public static class PortSpecification
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.HTTPHealthCheck.Types.PortSpecification.UndefinedPortSpecification"/>.</summary>
                public const string UndefinedPortSpecification = "UNDEFINED_PORT_SPECIFICATION";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.HTTPHealthCheck.Types.PortSpecification.UseFixedPort"/>.</summary>
                public const string UseFixedPort = "USE_FIXED_PORT";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.HTTPHealthCheck.Types.PortSpecification.UseNamedPort"/>.</summary>
                public const string UseNamedPort = "USE_NAMED_PORT";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.HTTPHealthCheck.Types.PortSpecification.UseServingPort"/>.</summary>
                public const string UseServingPort = "USE_SERVING_PORT";
            }

            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.HTTPHealthCheck.Types.ProxyHeader"/> enum.</summary>
            public static class ProxyHeader
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.HTTPHealthCheck.Types.ProxyHeader.UndefinedProxyHeader"/>.</summary>
                public const string UndefinedProxyHeader = "UNDEFINED_PROXY_HEADER";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.HTTPHealthCheck.Types.ProxyHeader.None"/>.</summary>
                public const string None = "NONE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.HTTPHealthCheck.Types.ProxyHeader.ProxyV1"/>.</summary>
                public const string ProxyV1 = "PROXY_V1";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.HTTPSHealthCheck"/> message.</summary>
        public static class HTTPSHealthCheck
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.HTTPSHealthCheck.Types.PortSpecification"/> enum.</summary>
            public static class PortSpecification
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.HTTPSHealthCheck.Types.PortSpecification.UndefinedPortSpecification"/>.</summary>
                public const string UndefinedPortSpecification = "UNDEFINED_PORT_SPECIFICATION";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.HTTPSHealthCheck.Types.PortSpecification.UseFixedPort"/>.</summary>
                public const string UseFixedPort = "USE_FIXED_PORT";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.HTTPSHealthCheck.Types.PortSpecification.UseNamedPort"/>.</summary>
                public const string UseNamedPort = "USE_NAMED_PORT";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.HTTPSHealthCheck.Types.PortSpecification.UseServingPort"/>.</summary>
                public const string UseServingPort = "USE_SERVING_PORT";
            }

            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.HTTPSHealthCheck.Types.ProxyHeader"/> enum.</summary>
            public static class ProxyHeader
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.HTTPSHealthCheck.Types.ProxyHeader.UndefinedProxyHeader"/>.</summary>
                public const string UndefinedProxyHeader = "UNDEFINED_PROXY_HEADER";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.HTTPSHealthCheck.Types.ProxyHeader.None"/>.</summary>
                public const string None = "NONE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.HTTPSHealthCheck.Types.ProxyHeader.ProxyV1"/>.</summary>
                public const string ProxyV1 = "PROXY_V1";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.HealthCheck"/> message.</summary>
        public static class HealthCheck
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.HealthCheck.Types.Type"/> enum.</summary>
            public static class Type
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.HealthCheck.Types.Type.UndefinedType"/>.</summary>
                public const string UndefinedType = "UNDEFINED_TYPE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.HealthCheck.Types.Type.Grpc"/>.</summary>
                public const string Grpc = "GRPC";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.HealthCheck.Types.Type.Http"/>.</summary>
                public const string Http = "HTTP";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.HealthCheck.Types.Type.Http2"/>.</summary>
                public const string Http2 = "HTTP2";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.HealthCheck.Types.Type.Https"/>.</summary>
                public const string Https = "HTTPS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.HealthCheck.Types.Type.Invalid"/>.</summary>
                public const string Invalid = "INVALID";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.HealthCheck.Types.Type.Ssl"/>.</summary>
                public const string Ssl = "SSL";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.HealthCheck.Types.Type.Tcp"/>.</summary>
                public const string Tcp = "TCP";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.HealthCheckService"/> message.</summary>
        public static class HealthCheckService
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.HealthCheckService.Types.HealthStatusAggregationPolicy"/> enum.</summary>
            public static class HealthStatusAggregationPolicy
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.HealthCheckService.Types.HealthStatusAggregationPolicy.UndefinedHealthStatusAggregationPolicy"/>.</summary>
                public const string UndefinedHealthStatusAggregationPolicy = "UNDEFINED_HEALTH_STATUS_AGGREGATION_POLICY";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.HealthCheckService.Types.HealthStatusAggregationPolicy.And"/>.</summary>
                public const string And = "AND";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.HealthCheckService.Types.HealthStatusAggregationPolicy.NoAggregation"/>.</summary>
                public const string NoAggregation = "NO_AGGREGATION";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.HealthStatus"/> message.</summary>
        public static class HealthStatus
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.HealthStatus.Types.HealthState"/> enum.</summary>
            public static class HealthState
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.HealthStatus.Types.HealthState.UndefinedHealthState"/>.</summary>
                public const string UndefinedHealthState = "UNDEFINED_HEALTH_STATE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.HealthStatus.Types.HealthState.Healthy"/>.</summary>
                public const string Healthy = "HEALTHY";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.HealthStatus.Types.HealthState.Unhealthy"/>.</summary>
                public const string Unhealthy = "UNHEALTHY";
            }

            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.HealthStatus.Types.WeightError"/> enum.</summary>
            public static class WeightError
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.HealthStatus.Types.WeightError.UndefinedWeightError"/>.</summary>
                public const string UndefinedWeightError = "UNDEFINED_WEIGHT_ERROR";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.HealthStatus.Types.WeightError.InvalidWeight"/>.</summary>
                public const string InvalidWeight = "INVALID_WEIGHT";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.HealthStatus.Types.WeightError.MissingWeight"/>.</summary>
                public const string MissingWeight = "MISSING_WEIGHT";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.HealthStatus.Types.WeightError.UnavailableWeight"/>.</summary>
                public const string UnavailableWeight = "UNAVAILABLE_WEIGHT";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.HealthStatus.Types.WeightError.WeightNone"/>.</summary>
                public const string WeightNone = "WEIGHT_NONE";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.HealthStatusForNetworkEndpoint"/> message.</summary>
        public static class HealthStatusForNetworkEndpoint
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.HealthStatusForNetworkEndpoint.Types.HealthState"/> enum.</summary>
            public static class HealthState
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.HealthStatusForNetworkEndpoint.Types.HealthState.UndefinedHealthState"/>.</summary>
                public const string UndefinedHealthState = "UNDEFINED_HEALTH_STATE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.HealthStatusForNetworkEndpoint.Types.HealthState.Draining"/>.</summary>
                public const string Draining = "DRAINING";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.HealthStatusForNetworkEndpoint.Types.HealthState.Healthy"/>.</summary>
                public const string Healthy = "HEALTHY";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.HealthStatusForNetworkEndpoint.Types.HealthState.Unhealthy"/>.</summary>
                public const string Unhealthy = "UNHEALTHY";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.HealthStatusForNetworkEndpoint.Types.HealthState.Unknown"/>.</summary>
                public const string Unknown = "UNKNOWN";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.HttpRedirectAction"/> message.</summary>
        public static class HttpRedirectAction
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.HttpRedirectAction.Types.RedirectResponseCode"/> enum.</summary>
            public static class RedirectResponseCode
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.HttpRedirectAction.Types.RedirectResponseCode.UndefinedRedirectResponseCode"/>.</summary>
                public const string UndefinedRedirectResponseCode = "UNDEFINED_REDIRECT_RESPONSE_CODE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.HttpRedirectAction.Types.RedirectResponseCode.Found"/>.</summary>
                public const string Found = "FOUND";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.HttpRedirectAction.Types.RedirectResponseCode.MovedPermanentlyDefault"/>.</summary>
                public const string MovedPermanentlyDefault = "MOVED_PERMANENTLY_DEFAULT";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.HttpRedirectAction.Types.RedirectResponseCode.PermanentRedirect"/>.</summary>
                public const string PermanentRedirect = "PERMANENT_REDIRECT";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.HttpRedirectAction.Types.RedirectResponseCode.SeeOther"/>.</summary>
                public const string SeeOther = "SEE_OTHER";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.HttpRedirectAction.Types.RedirectResponseCode.TemporaryRedirect"/>.</summary>
                public const string TemporaryRedirect = "TEMPORARY_REDIRECT";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.Image"/> message.</summary>
        public static class Image
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.Image.Types.SourceType"/> enum.</summary>
            public static class SourceType
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Image.Types.SourceType.UndefinedSourceType"/>.</summary>
                public const string UndefinedSourceType = "UNDEFINED_SOURCE_TYPE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Image.Types.SourceType.Raw"/>.</summary>
                public const string Raw = "RAW";
            }

            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.Image.Types.Status"/> enum.</summary>
            public static class Status
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Image.Types.Status.UndefinedStatus"/>.</summary>
                public const string UndefinedStatus = "UNDEFINED_STATUS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Image.Types.Status.Deleting"/>.</summary>
                public const string Deleting = "DELETING";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Image.Types.Status.Failed"/>.</summary>
                public const string Failed = "FAILED";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Image.Types.Status.Pending"/>.</summary>
                public const string Pending = "PENDING";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Image.Types.Status.Ready"/>.</summary>
                public const string Ready = "READY";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.Instance"/> message.</summary>
        public static class Instance
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.Instance.Types.PrivateIpv6GoogleAccess"/> enum.</summary>
            public static class PrivateIpv6GoogleAccess
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Instance.Types.PrivateIpv6GoogleAccess.UndefinedPrivateIpv6GoogleAccess"/>.</summary>
                public const string UndefinedPrivateIpv6GoogleAccess = "UNDEFINED_PRIVATE_IPV6_GOOGLE_ACCESS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Instance.Types.PrivateIpv6GoogleAccess.EnableBidirectionalAccessToGoogle"/>.</summary>
                public const string EnableBidirectionalAccessToGoogle = "ENABLE_BIDIRECTIONAL_ACCESS_TO_GOOGLE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Instance.Types.PrivateIpv6GoogleAccess.EnableOutboundVmAccessToGoogle"/>.</summary>
                public const string EnableOutboundVmAccessToGoogle = "ENABLE_OUTBOUND_VM_ACCESS_TO_GOOGLE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Instance.Types.PrivateIpv6GoogleAccess.InheritFromSubnetwork"/>.</summary>
                public const string InheritFromSubnetwork = "INHERIT_FROM_SUBNETWORK";
            }

            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.Instance.Types.Status"/> enum.</summary>
            public static class Status
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Instance.Types.Status.UndefinedStatus"/>.</summary>
                public const string UndefinedStatus = "UNDEFINED_STATUS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Instance.Types.Status.Deprovisioning"/>.</summary>
                public const string Deprovisioning = "DEPROVISIONING";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Instance.Types.Status.Provisioning"/>.</summary>
                public const string Provisioning = "PROVISIONING";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Instance.Types.Status.Repairing"/>.</summary>
                public const string Repairing = "REPAIRING";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Instance.Types.Status.Running"/>.</summary>
                public const string Running = "RUNNING";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Instance.Types.Status.Staging"/>.</summary>
                public const string Staging = "STAGING";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Instance.Types.Status.Stopped"/>.</summary>
                public const string Stopped = "STOPPED";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Instance.Types.Status.Stopping"/>.</summary>
                public const string Stopping = "STOPPING";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Instance.Types.Status.Suspended"/>.</summary>
                public const string Suspended = "SUSPENDED";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Instance.Types.Status.Suspending"/>.</summary>
                public const string Suspending = "SUSPENDING";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Instance.Types.Status.Terminated"/>.</summary>
                public const string Terminated = "TERMINATED";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.InstanceGroupsListInstancesRequest"/> message.</summary>
        public static class InstanceGroupsListInstancesRequest
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.InstanceGroupsListInstancesRequest.Types.InstanceState"/> enum.</summary>
            public static class InstanceState
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.InstanceGroupsListInstancesRequest.Types.InstanceState.UndefinedInstanceState"/>.</summary>
                public const string UndefinedInstanceState = "UNDEFINED_INSTANCE_STATE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.InstanceGroupsListInstancesRequest.Types.InstanceState.All"/>.</summary>
                public const string All = "ALL";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.InstanceGroupsListInstancesRequest.Types.InstanceState.Running"/>.</summary>
                public const string Running = "RUNNING";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.InstanceManagedByIgmErrorInstanceActionDetails"/> message.</summary>
        public static class InstanceManagedByIgmErrorInstanceActionDetails
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.InstanceManagedByIgmErrorInstanceActionDetails.Types.Action"/> enum.</summary>
            public static class Action
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.InstanceManagedByIgmErrorInstanceActionDetails.Types.Action.UndefinedAction"/>.</summary>
                public const string UndefinedAction = "UNDEFINED_ACTION";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.InstanceManagedByIgmErrorInstanceActionDetails.Types.Action.Abandoning"/>.</summary>
                public const string Abandoning = "ABANDONING";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.InstanceManagedByIgmErrorInstanceActionDetails.Types.Action.Creating"/>.</summary>
                public const string Creating = "CREATING";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.InstanceManagedByIgmErrorInstanceActionDetails.Types.Action.CreatingWithoutRetries"/>.</summary>
                public const string CreatingWithoutRetries = "CREATING_WITHOUT_RETRIES";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.InstanceManagedByIgmErrorInstanceActionDetails.Types.Action.Deleting"/>.</summary>
                public const string Deleting = "DELETING";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.InstanceManagedByIgmErrorInstanceActionDetails.Types.Action.None"/>.</summary>
                public const string None = "NONE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.InstanceManagedByIgmErrorInstanceActionDetails.Types.Action.Recreating"/>.</summary>
                public const string Recreating = "RECREATING";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.InstanceManagedByIgmErrorInstanceActionDetails.Types.Action.Refreshing"/>.</summary>
                public const string Refreshing = "REFRESHING";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.InstanceManagedByIgmErrorInstanceActionDetails.Types.Action.Restarting"/>.</summary>
                public const string Restarting = "RESTARTING";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.InstanceManagedByIgmErrorInstanceActionDetails.Types.Action.Resuming"/>.</summary>
                public const string Resuming = "RESUMING";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.InstanceManagedByIgmErrorInstanceActionDetails.Types.Action.Starting"/>.</summary>
                public const string Starting = "STARTING";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.InstanceManagedByIgmErrorInstanceActionDetails.Types.Action.Stopping"/>.</summary>
                public const string Stopping = "STOPPING";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.InstanceManagedByIgmErrorInstanceActionDetails.Types.Action.Suspending"/>.</summary>
                public const string Suspending = "SUSPENDING";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.InstanceManagedByIgmErrorInstanceActionDetails.Types.Action.Verifying"/>.</summary>
                public const string Verifying = "VERIFYING";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.InstanceProperties"/> message.</summary>
        public static class InstanceProperties
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.InstanceProperties.Types.PrivateIpv6GoogleAccess"/> enum.</summary>
            public static class PrivateIpv6GoogleAccess
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.InstanceProperties.Types.PrivateIpv6GoogleAccess.UndefinedPrivateIpv6GoogleAccess"/>.</summary>
                public const string UndefinedPrivateIpv6GoogleAccess = "UNDEFINED_PRIVATE_IPV6_GOOGLE_ACCESS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.InstanceProperties.Types.PrivateIpv6GoogleAccess.EnableBidirectionalAccessToGoogle"/>.</summary>
                public const string EnableBidirectionalAccessToGoogle = "ENABLE_BIDIRECTIONAL_ACCESS_TO_GOOGLE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.InstanceProperties.Types.PrivateIpv6GoogleAccess.EnableOutboundVmAccessToGoogle"/>.</summary>
                public const string EnableOutboundVmAccessToGoogle = "ENABLE_OUTBOUND_VM_ACCESS_TO_GOOGLE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.InstanceProperties.Types.PrivateIpv6GoogleAccess.InheritFromSubnetwork"/>.</summary>
                public const string InheritFromSubnetwork = "INHERIT_FROM_SUBNETWORK";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.InstanceWithNamedPorts"/> message.</summary>
        public static class InstanceWithNamedPorts
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.InstanceWithNamedPorts.Types.Status"/> enum.</summary>
            public static class Status
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.InstanceWithNamedPorts.Types.Status.UndefinedStatus"/>.</summary>
                public const string UndefinedStatus = "UNDEFINED_STATUS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.InstanceWithNamedPorts.Types.Status.Deprovisioning"/>.</summary>
                public const string Deprovisioning = "DEPROVISIONING";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.InstanceWithNamedPorts.Types.Status.Provisioning"/>.</summary>
                public const string Provisioning = "PROVISIONING";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.InstanceWithNamedPorts.Types.Status.Repairing"/>.</summary>
                public const string Repairing = "REPAIRING";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.InstanceWithNamedPorts.Types.Status.Running"/>.</summary>
                public const string Running = "RUNNING";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.InstanceWithNamedPorts.Types.Status.Staging"/>.</summary>
                public const string Staging = "STAGING";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.InstanceWithNamedPorts.Types.Status.Stopped"/>.</summary>
                public const string Stopped = "STOPPED";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.InstanceWithNamedPorts.Types.Status.Stopping"/>.</summary>
                public const string Stopping = "STOPPING";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.InstanceWithNamedPorts.Types.Status.Suspended"/>.</summary>
                public const string Suspended = "SUSPENDED";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.InstanceWithNamedPorts.Types.Status.Suspending"/>.</summary>
                public const string Suspending = "SUSPENDING";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.InstanceWithNamedPorts.Types.Status.Terminated"/>.</summary>
                public const string Terminated = "TERMINATED";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.InstancesGetEffectiveFirewallsResponseEffectiveFirewallPolicy"/> message.</summary>
        public static class InstancesGetEffectiveFirewallsResponseEffectiveFirewallPolicy
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.InstancesGetEffectiveFirewallsResponseEffectiveFirewallPolicy.Types.Type"/> enum.</summary>
            public static class Type
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.InstancesGetEffectiveFirewallsResponseEffectiveFirewallPolicy.Types.Type.UndefinedType"/>.</summary>
                public const string UndefinedType = "UNDEFINED_TYPE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.InstancesGetEffectiveFirewallsResponseEffectiveFirewallPolicy.Types.Type.Hierarchy"/>.</summary>
                public const string Hierarchy = "HIERARCHY";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.InstancesGetEffectiveFirewallsResponseEffectiveFirewallPolicy.Types.Type.Unspecified"/>.</summary>
                public const string Unspecified = "UNSPECIFIED";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.Interconnect"/> message.</summary>
        public static class Interconnect
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.Interconnect.Types.InterconnectType"/> enum.</summary>
            public static class InterconnectType
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Interconnect.Types.InterconnectType.UndefinedInterconnectType"/>.</summary>
                public const string UndefinedInterconnectType = "UNDEFINED_INTERCONNECT_TYPE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Interconnect.Types.InterconnectType.Dedicated"/>.</summary>
                public const string Dedicated = "DEDICATED";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Interconnect.Types.InterconnectType.ItPrivate"/>.</summary>
                public const string ItPrivate = "IT_PRIVATE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Interconnect.Types.InterconnectType.Partner"/>.</summary>
                public const string Partner = "PARTNER";
            }

            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.Interconnect.Types.LinkType"/> enum.</summary>
            public static class LinkType
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Interconnect.Types.LinkType.UndefinedLinkType"/>.</summary>
                public const string UndefinedLinkType = "UNDEFINED_LINK_TYPE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Interconnect.Types.LinkType.Ethernet100GLr"/>.</summary>
                public const string Ethernet100GLr = "LINK_TYPE_ETHERNET_100G_LR";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Interconnect.Types.LinkType.Ethernet10GLr"/>.</summary>
                public const string Ethernet10GLr = "LINK_TYPE_ETHERNET_10G_LR";
            }

            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.Interconnect.Types.OperationalStatus"/> enum.</summary>
            public static class OperationalStatus
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Interconnect.Types.OperationalStatus.UndefinedOperationalStatus"/>.</summary>
                public const string UndefinedOperationalStatus = "UNDEFINED_OPERATIONAL_STATUS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Interconnect.Types.OperationalStatus.OsActive"/>.</summary>
                public const string OsActive = "OS_ACTIVE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Interconnect.Types.OperationalStatus.OsUnprovisioned"/>.</summary>
                public const string OsUnprovisioned = "OS_UNPROVISIONED";
            }

            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.Interconnect.Types.State"/> enum.</summary>
            public static class State
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Interconnect.Types.State.UndefinedState"/>.</summary>
                public const string UndefinedState = "UNDEFINED_STATE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Interconnect.Types.State.Active"/>.</summary>
                public const string Active = "ACTIVE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Interconnect.Types.State.Unprovisioned"/>.</summary>
                public const string Unprovisioned = "UNPROVISIONED";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachment"/> message.</summary>
        public static class InterconnectAttachment
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachment.Types.Bandwidth"/> enum.</summary>
            public static class Bandwidth
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachment.Types.Bandwidth.UndefinedBandwidth"/>.</summary>
                public const string UndefinedBandwidth = "UNDEFINED_BANDWIDTH";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachment.Types.Bandwidth.Bps100M"/>.</summary>
                public const string Bps100M = "BPS_100M";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachment.Types.Bandwidth.Bps10G"/>.</summary>
                public const string Bps10G = "BPS_10G";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachment.Types.Bandwidth.Bps1G"/>.</summary>
                public const string Bps1G = "BPS_1G";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachment.Types.Bandwidth.Bps200M"/>.</summary>
                public const string Bps200M = "BPS_200M";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachment.Types.Bandwidth.Bps20G"/>.</summary>
                public const string Bps20G = "BPS_20G";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachment.Types.Bandwidth.Bps2G"/>.</summary>
                public const string Bps2G = "BPS_2G";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachment.Types.Bandwidth.Bps300M"/>.</summary>
                public const string Bps300M = "BPS_300M";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachment.Types.Bandwidth.Bps400M"/>.</summary>
                public const string Bps400M = "BPS_400M";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachment.Types.Bandwidth.Bps500M"/>.</summary>
                public const string Bps500M = "BPS_500M";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachment.Types.Bandwidth.Bps50G"/>.</summary>
                public const string Bps50G = "BPS_50G";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachment.Types.Bandwidth.Bps50M"/>.</summary>
                public const string Bps50M = "BPS_50M";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachment.Types.Bandwidth.Bps5G"/>.</summary>
                public const string Bps5G = "BPS_5G";
            }

            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachment.Types.EdgeAvailabilityDomain"/> enum.</summary>
            public static class EdgeAvailabilityDomain
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachment.Types.EdgeAvailabilityDomain.UndefinedEdgeAvailabilityDomain"/>.</summary>
                public const string UndefinedEdgeAvailabilityDomain = "UNDEFINED_EDGE_AVAILABILITY_DOMAIN";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachment.Types.EdgeAvailabilityDomain.AvailabilityDomain1"/>.</summary>
                public const string AvailabilityDomain1 = "AVAILABILITY_DOMAIN_1";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachment.Types.EdgeAvailabilityDomain.AvailabilityDomain2"/>.</summary>
                public const string AvailabilityDomain2 = "AVAILABILITY_DOMAIN_2";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachment.Types.EdgeAvailabilityDomain.AvailabilityDomainAny"/>.</summary>
                public const string AvailabilityDomainAny = "AVAILABILITY_DOMAIN_ANY";
            }

            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachment.Types.Encryption"/> enum.</summary>
            public static class Encryption
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachment.Types.Encryption.UndefinedEncryption"/>.</summary>
                public const string UndefinedEncryption = "UNDEFINED_ENCRYPTION";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachment.Types.Encryption.Ipsec"/>.</summary>
                public const string Ipsec = "IPSEC";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachment.Types.Encryption.None"/>.</summary>
                public const string None = "NONE";
            }

            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachment.Types.OperationalStatus"/> enum.</summary>
            public static class OperationalStatus
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachment.Types.OperationalStatus.UndefinedOperationalStatus"/>.</summary>
                public const string UndefinedOperationalStatus = "UNDEFINED_OPERATIONAL_STATUS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachment.Types.OperationalStatus.OsActive"/>.</summary>
                public const string OsActive = "OS_ACTIVE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachment.Types.OperationalStatus.OsUnprovisioned"/>.</summary>
                public const string OsUnprovisioned = "OS_UNPROVISIONED";
            }

            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachment.Types.StackType"/> enum.</summary>
            public static class StackType
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachment.Types.StackType.UndefinedStackType"/>.</summary>
                public const string UndefinedStackType = "UNDEFINED_STACK_TYPE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachment.Types.StackType.Ipv4Ipv6"/>.</summary>
                public const string Ipv4Ipv6 = "IPV4_IPV6";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachment.Types.StackType.Ipv4Only"/>.</summary>
                public const string Ipv4Only = "IPV4_ONLY";
            }

            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachment.Types.State"/> enum.</summary>
            public static class State
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachment.Types.State.UndefinedState"/>.</summary>
                public const string UndefinedState = "UNDEFINED_STATE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachment.Types.State.Active"/>.</summary>
                public const string Active = "ACTIVE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachment.Types.State.Defunct"/>.</summary>
                public const string Defunct = "DEFUNCT";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachment.Types.State.PartnerRequestReceived"/>.</summary>
                public const string PartnerRequestReceived = "PARTNER_REQUEST_RECEIVED";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachment.Types.State.PendingCustomer"/>.</summary>
                public const string PendingCustomer = "PENDING_CUSTOMER";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachment.Types.State.PendingPartner"/>.</summary>
                public const string PendingPartner = "PENDING_PARTNER";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachment.Types.State.Unspecified"/>.</summary>
                public const string Unspecified = "STATE_UNSPECIFIED";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachment.Types.State.Unprovisioned"/>.</summary>
                public const string Unprovisioned = "UNPROVISIONED";
            }

            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachment.Types.Type"/> enum.</summary>
            public static class Type
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachment.Types.Type.UndefinedType"/>.</summary>
                public const string UndefinedType = "UNDEFINED_TYPE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachment.Types.Type.Dedicated"/>.</summary>
                public const string Dedicated = "DEDICATED";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachment.Types.Type.Partner"/>.</summary>
                public const string Partner = "PARTNER";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.InterconnectAttachment.Types.Type.PartnerProvider"/>.</summary>
                public const string PartnerProvider = "PARTNER_PROVIDER";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.InterconnectDiagnosticsLinkLACPStatus"/> message.</summary>
        public static class InterconnectDiagnosticsLinkLACPStatus
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.InterconnectDiagnosticsLinkLACPStatus.Types.State"/> enum.</summary>
            public static class State
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.InterconnectDiagnosticsLinkLACPStatus.Types.State.UndefinedState"/>.</summary>
                public const string UndefinedState = "UNDEFINED_STATE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.InterconnectDiagnosticsLinkLACPStatus.Types.State.Active"/>.</summary>
                public const string Active = "ACTIVE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.InterconnectDiagnosticsLinkLACPStatus.Types.State.Detached"/>.</summary>
                public const string Detached = "DETACHED";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.InterconnectDiagnosticsLinkOpticalPower"/> message.</summary>
        public static class InterconnectDiagnosticsLinkOpticalPower
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.InterconnectDiagnosticsLinkOpticalPower.Types.State"/> enum.</summary>
            public static class State
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.InterconnectDiagnosticsLinkOpticalPower.Types.State.UndefinedState"/>.</summary>
                public const string UndefinedState = "UNDEFINED_STATE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.InterconnectDiagnosticsLinkOpticalPower.Types.State.HighAlarm"/>.</summary>
                public const string HighAlarm = "HIGH_ALARM";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.InterconnectDiagnosticsLinkOpticalPower.Types.State.HighWarning"/>.</summary>
                public const string HighWarning = "HIGH_WARNING";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.InterconnectDiagnosticsLinkOpticalPower.Types.State.LowAlarm"/>.</summary>
                public const string LowAlarm = "LOW_ALARM";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.InterconnectDiagnosticsLinkOpticalPower.Types.State.LowWarning"/>.</summary>
                public const string LowWarning = "LOW_WARNING";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.InterconnectDiagnosticsLinkOpticalPower.Types.State.Ok"/>.</summary>
                public const string Ok = "OK";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.InterconnectLocation"/> message.</summary>
        public static class InterconnectLocation
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.InterconnectLocation.Types.Continent"/> enum.</summary>
            public static class Continent
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.InterconnectLocation.Types.Continent.UndefinedContinent"/>.</summary>
                public const string UndefinedContinent = "UNDEFINED_CONTINENT";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.InterconnectLocation.Types.Continent.Africa"/>.</summary>
                public const string Africa = "AFRICA";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.InterconnectLocation.Types.Continent.AsiaPac"/>.</summary>
                public const string AsiaPac = "ASIA_PAC";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.InterconnectLocation.Types.Continent.CAfrica"/>.</summary>
                public const string CAfrica = "C_AFRICA";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.InterconnectLocation.Types.Continent.CAsiaPac"/>.</summary>
                public const string CAsiaPac = "C_ASIA_PAC";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.InterconnectLocation.Types.Continent.CEurope"/>.</summary>
                public const string CEurope = "C_EUROPE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.InterconnectLocation.Types.Continent.CNorthAmerica"/>.</summary>
                public const string CNorthAmerica = "C_NORTH_AMERICA";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.InterconnectLocation.Types.Continent.CSouthAmerica"/>.</summary>
                public const string CSouthAmerica = "C_SOUTH_AMERICA";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.InterconnectLocation.Types.Continent.Europe"/>.</summary>
                public const string Europe = "EUROPE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.InterconnectLocation.Types.Continent.NorthAmerica"/>.</summary>
                public const string NorthAmerica = "NORTH_AMERICA";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.InterconnectLocation.Types.Continent.SouthAmerica"/>.</summary>
                public const string SouthAmerica = "SOUTH_AMERICA";
            }

            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.InterconnectLocation.Types.Status"/> enum.</summary>
            public static class Status
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.InterconnectLocation.Types.Status.UndefinedStatus"/>.</summary>
                public const string UndefinedStatus = "UNDEFINED_STATUS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.InterconnectLocation.Types.Status.Available"/>.</summary>
                public const string Available = "AVAILABLE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.InterconnectLocation.Types.Status.Closed"/>.</summary>
                public const string Closed = "CLOSED";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.InterconnectLocationRegionInfo"/> message.</summary>
        public static class InterconnectLocationRegionInfo
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.InterconnectLocationRegionInfo.Types.LocationPresence"/> enum.</summary>
            public static class LocationPresence
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.InterconnectLocationRegionInfo.Types.LocationPresence.UndefinedLocationPresence"/>.</summary>
                public const string UndefinedLocationPresence = "UNDEFINED_LOCATION_PRESENCE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.InterconnectLocationRegionInfo.Types.LocationPresence.Global"/>.</summary>
                public const string Global = "GLOBAL";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.InterconnectLocationRegionInfo.Types.LocationPresence.LocalRegion"/>.</summary>
                public const string LocalRegion = "LOCAL_REGION";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.InterconnectLocationRegionInfo.Types.LocationPresence.LpGlobal"/>.</summary>
                public const string LpGlobal = "LP_GLOBAL";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.InterconnectLocationRegionInfo.Types.LocationPresence.LpLocalRegion"/>.</summary>
                public const string LpLocalRegion = "LP_LOCAL_REGION";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.InterconnectOutageNotification"/> message.</summary>
        public static class InterconnectOutageNotification
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.InterconnectOutageNotification.Types.IssueType"/> enum.</summary>
            public static class IssueType
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.InterconnectOutageNotification.Types.IssueType.UndefinedIssueType"/>.</summary>
                public const string UndefinedIssueType = "UNDEFINED_ISSUE_TYPE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.InterconnectOutageNotification.Types.IssueType.ItOutage"/>.</summary>
                public const string ItOutage = "IT_OUTAGE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.InterconnectOutageNotification.Types.IssueType.ItPartialOutage"/>.</summary>
                public const string ItPartialOutage = "IT_PARTIAL_OUTAGE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.InterconnectOutageNotification.Types.IssueType.Outage"/>.</summary>
                public const string Outage = "OUTAGE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.InterconnectOutageNotification.Types.IssueType.PartialOutage"/>.</summary>
                public const string PartialOutage = "PARTIAL_OUTAGE";
            }

            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.InterconnectOutageNotification.Types.Source"/> enum.</summary>
            public static class Source
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.InterconnectOutageNotification.Types.Source.UndefinedSource"/>.</summary>
                public const string UndefinedSource = "UNDEFINED_SOURCE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.InterconnectOutageNotification.Types.Source.Google"/>.</summary>
                public const string Google = "GOOGLE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.InterconnectOutageNotification.Types.Source.NsrcGoogle"/>.</summary>
                public const string NsrcGoogle = "NSRC_GOOGLE";
            }

            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.InterconnectOutageNotification.Types.State"/> enum.</summary>
            public static class State
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.InterconnectOutageNotification.Types.State.UndefinedState"/>.</summary>
                public const string UndefinedState = "UNDEFINED_STATE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.InterconnectOutageNotification.Types.State.Active"/>.</summary>
                public const string Active = "ACTIVE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.InterconnectOutageNotification.Types.State.Cancelled"/>.</summary>
                public const string Cancelled = "CANCELLED";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.InterconnectOutageNotification.Types.State.Completed"/>.</summary>
                public const string Completed = "COMPLETED";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.InterconnectOutageNotification.Types.State.NsActive"/>.</summary>
                public const string NsActive = "NS_ACTIVE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.InterconnectOutageNotification.Types.State.NsCanceled"/>.</summary>
                public const string NsCanceled = "NS_CANCELED";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.LicenseCode"/> message.</summary>
        public static class LicenseCode
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.LicenseCode.Types.State"/> enum.</summary>
            public static class State
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.LicenseCode.Types.State.UndefinedState"/>.</summary>
                public const string UndefinedState = "UNDEFINED_STATE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.LicenseCode.Types.State.Disabled"/>.</summary>
                public const string Disabled = "DISABLED";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.LicenseCode.Types.State.Enabled"/>.</summary>
                public const string Enabled = "ENABLED";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.LicenseCode.Types.State.Restricted"/>.</summary>
                public const string Restricted = "RESTRICTED";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.LicenseCode.Types.State.Unspecified"/>.</summary>
                public const string Unspecified = "STATE_UNSPECIFIED";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.LicenseCode.Types.State.Terminated"/>.</summary>
                public const string Terminated = "TERMINATED";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.ListPeeringRoutesNetworksRequest"/> message.</summary>
        public static class ListPeeringRoutesNetworksRequest
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.ListPeeringRoutesNetworksRequest.Types.Direction"/> enum.</summary>
            public static class Direction
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ListPeeringRoutesNetworksRequest.Types.Direction.UndefinedDirection"/>.</summary>
                public const string UndefinedDirection = "UNDEFINED_DIRECTION";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ListPeeringRoutesNetworksRequest.Types.Direction.Incoming"/>.</summary>
                public const string Incoming = "INCOMING";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ListPeeringRoutesNetworksRequest.Types.Direction.Outgoing"/>.</summary>
                public const string Outgoing = "OUTGOING";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.LocationPolicyLocation"/> message.</summary>
        public static class LocationPolicyLocation
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.LocationPolicyLocation.Types.Preference"/> enum.</summary>
            public static class Preference
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.LocationPolicyLocation.Types.Preference.UndefinedPreference"/>.</summary>
                public const string UndefinedPreference = "UNDEFINED_PREFERENCE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.LocationPolicyLocation.Types.Preference.Allow"/>.</summary>
                public const string Allow = "ALLOW";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.LocationPolicyLocation.Types.Preference.Deny"/>.</summary>
                public const string Deny = "DENY";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.LocationPolicyLocation.Types.Preference.Unspecified"/>.</summary>
                public const string Unspecified = "PREFERENCE_UNSPECIFIED";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.LogConfigCloudAuditOptions"/> message.</summary>
        public static class LogConfigCloudAuditOptions
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.LogConfigCloudAuditOptions.Types.LogName"/> enum.</summary>
            public static class LogName
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.LogConfigCloudAuditOptions.Types.LogName.UndefinedLogName"/>.</summary>
                public const string UndefinedLogName = "UNDEFINED_LOG_NAME";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.LogConfigCloudAuditOptions.Types.LogName.AdminActivity"/>.</summary>
                public const string AdminActivity = "ADMIN_ACTIVITY";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.LogConfigCloudAuditOptions.Types.LogName.DataAccess"/>.</summary>
                public const string DataAccess = "DATA_ACCESS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.LogConfigCloudAuditOptions.Types.LogName.UnspecifiedLogName"/>.</summary>
                public const string UnspecifiedLogName = "UNSPECIFIED_LOG_NAME";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.LogConfigDataAccessOptions"/> message.</summary>
        public static class LogConfigDataAccessOptions
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.LogConfigDataAccessOptions.Types.LogMode"/> enum.</summary>
            public static class LogMode
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.LogConfigDataAccessOptions.Types.LogMode.UndefinedLogMode"/>.</summary>
                public const string UndefinedLogMode = "UNDEFINED_LOG_MODE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.LogConfigDataAccessOptions.Types.LogMode.LogFailClosed"/>.</summary>
                public const string LogFailClosed = "LOG_FAIL_CLOSED";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.LogConfigDataAccessOptions.Types.LogMode.Unspecified"/>.</summary>
                public const string Unspecified = "LOG_MODE_UNSPECIFIED";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.MachineImage"/> message.</summary>
        public static class MachineImage
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.MachineImage.Types.Status"/> enum.</summary>
            public static class Status
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.MachineImage.Types.Status.UndefinedStatus"/>.</summary>
                public const string UndefinedStatus = "UNDEFINED_STATUS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.MachineImage.Types.Status.Creating"/>.</summary>
                public const string Creating = "CREATING";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.MachineImage.Types.Status.Deleting"/>.</summary>
                public const string Deleting = "DELETING";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.MachineImage.Types.Status.Invalid"/>.</summary>
                public const string Invalid = "INVALID";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.MachineImage.Types.Status.Ready"/>.</summary>
                public const string Ready = "READY";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.MachineImage.Types.Status.Uploading"/>.</summary>
                public const string Uploading = "UPLOADING";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.ManagedInstance"/> message.</summary>
        public static class ManagedInstance
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.ManagedInstance.Types.CurrentAction"/> enum.</summary>
            public static class CurrentAction
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ManagedInstance.Types.CurrentAction.UndefinedCurrentAction"/>.</summary>
                public const string UndefinedCurrentAction = "UNDEFINED_CURRENT_ACTION";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ManagedInstance.Types.CurrentAction.Abandoning"/>.</summary>
                public const string Abandoning = "ABANDONING";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ManagedInstance.Types.CurrentAction.Creating"/>.</summary>
                public const string Creating = "CREATING";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ManagedInstance.Types.CurrentAction.CreatingWithoutRetries"/>.</summary>
                public const string CreatingWithoutRetries = "CREATING_WITHOUT_RETRIES";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ManagedInstance.Types.CurrentAction.Deleting"/>.</summary>
                public const string Deleting = "DELETING";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ManagedInstance.Types.CurrentAction.None"/>.</summary>
                public const string None = "NONE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ManagedInstance.Types.CurrentAction.Recreating"/>.</summary>
                public const string Recreating = "RECREATING";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ManagedInstance.Types.CurrentAction.Refreshing"/>.</summary>
                public const string Refreshing = "REFRESHING";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ManagedInstance.Types.CurrentAction.Restarting"/>.</summary>
                public const string Restarting = "RESTARTING";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ManagedInstance.Types.CurrentAction.Verifying"/>.</summary>
                public const string Verifying = "VERIFYING";
            }

            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.ManagedInstance.Types.InstanceStatus"/> enum.</summary>
            public static class InstanceStatus
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ManagedInstance.Types.InstanceStatus.UndefinedInstanceStatus"/>.</summary>
                public const string UndefinedInstanceStatus = "UNDEFINED_INSTANCE_STATUS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ManagedInstance.Types.InstanceStatus.Deprovisioning"/>.</summary>
                public const string Deprovisioning = "DEPROVISIONING";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ManagedInstance.Types.InstanceStatus.Provisioning"/>.</summary>
                public const string Provisioning = "PROVISIONING";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ManagedInstance.Types.InstanceStatus.Repairing"/>.</summary>
                public const string Repairing = "REPAIRING";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ManagedInstance.Types.InstanceStatus.Running"/>.</summary>
                public const string Running = "RUNNING";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ManagedInstance.Types.InstanceStatus.Staging"/>.</summary>
                public const string Staging = "STAGING";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ManagedInstance.Types.InstanceStatus.Stopped"/>.</summary>
                public const string Stopped = "STOPPED";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ManagedInstance.Types.InstanceStatus.Stopping"/>.</summary>
                public const string Stopping = "STOPPING";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ManagedInstance.Types.InstanceStatus.Suspended"/>.</summary>
                public const string Suspended = "SUSPENDED";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ManagedInstance.Types.InstanceStatus.Suspending"/>.</summary>
                public const string Suspending = "SUSPENDING";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ManagedInstance.Types.InstanceStatus.Terminated"/>.</summary>
                public const string Terminated = "TERMINATED";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.ManagedInstanceInstanceHealth"/> message.</summary>
        public static class ManagedInstanceInstanceHealth
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.ManagedInstanceInstanceHealth.Types.DetailedHealthState"/> enum.</summary>
            public static class DetailedHealthState
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ManagedInstanceInstanceHealth.Types.DetailedHealthState.UndefinedDetailedHealthState"/>.</summary>
                public const string UndefinedDetailedHealthState = "UNDEFINED_DETAILED_HEALTH_STATE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ManagedInstanceInstanceHealth.Types.DetailedHealthState.Draining"/>.</summary>
                public const string Draining = "DRAINING";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ManagedInstanceInstanceHealth.Types.DetailedHealthState.Healthy"/>.</summary>
                public const string Healthy = "HEALTHY";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ManagedInstanceInstanceHealth.Types.DetailedHealthState.Timeout"/>.</summary>
                public const string Timeout = "TIMEOUT";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ManagedInstanceInstanceHealth.Types.DetailedHealthState.Unhealthy"/>.</summary>
                public const string Unhealthy = "UNHEALTHY";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ManagedInstanceInstanceHealth.Types.DetailedHealthState.Unknown"/>.</summary>
                public const string Unknown = "UNKNOWN";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.MetadataFilter"/> message.</summary>
        public static class MetadataFilter
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.MetadataFilter.Types.FilterMatchCriteria"/> enum.</summary>
            public static class FilterMatchCriteria
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.MetadataFilter.Types.FilterMatchCriteria.UndefinedFilterMatchCriteria"/>.</summary>
                public const string UndefinedFilterMatchCriteria = "UNDEFINED_FILTER_MATCH_CRITERIA";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.MetadataFilter.Types.FilterMatchCriteria.MatchAll"/>.</summary>
                public const string MatchAll = "MATCH_ALL";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.MetadataFilter.Types.FilterMatchCriteria.MatchAny"/>.</summary>
                public const string MatchAny = "MATCH_ANY";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.MetadataFilter.Types.FilterMatchCriteria.NotSet"/>.</summary>
                public const string NotSet = "NOT_SET";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.NetworkEndpointGroup"/> message.</summary>
        public static class NetworkEndpointGroup
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.NetworkEndpointGroup.Types.NetworkEndpointType"/> enum.</summary>
            public static class NetworkEndpointType
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.NetworkEndpointGroup.Types.NetworkEndpointType.UndefinedNetworkEndpointType"/>.</summary>
                public const string UndefinedNetworkEndpointType = "UNDEFINED_NETWORK_ENDPOINT_TYPE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.NetworkEndpointGroup.Types.NetworkEndpointType.GceVmIp"/>.</summary>
                public const string GceVmIp = "GCE_VM_IP";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.NetworkEndpointGroup.Types.NetworkEndpointType.GceVmIpPort"/>.</summary>
                public const string GceVmIpPort = "GCE_VM_IP_PORT";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.NetworkEndpointGroup.Types.NetworkEndpointType.InternetFqdnPort"/>.</summary>
                public const string InternetFqdnPort = "INTERNET_FQDN_PORT";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.NetworkEndpointGroup.Types.NetworkEndpointType.InternetIpPort"/>.</summary>
                public const string InternetIpPort = "INTERNET_IP_PORT";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.NetworkEndpointGroup.Types.NetworkEndpointType.NonGcpPrivateIpPort"/>.</summary>
                public const string NonGcpPrivateIpPort = "NON_GCP_PRIVATE_IP_PORT";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.NetworkEndpointGroup.Types.NetworkEndpointType.PrivateServiceConnect"/>.</summary>
                public const string PrivateServiceConnect = "PRIVATE_SERVICE_CONNECT";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.NetworkEndpointGroup.Types.NetworkEndpointType.Serverless"/>.</summary>
                public const string Serverless = "SERVERLESS";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.NetworkEndpointGroupsListEndpointsRequest"/> message.</summary>
        public static class NetworkEndpointGroupsListEndpointsRequest
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.NetworkEndpointGroupsListEndpointsRequest.Types.HealthStatus"/> enum.</summary>
            public static class HealthStatus
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.NetworkEndpointGroupsListEndpointsRequest.Types.HealthStatus.UndefinedHealthStatus"/>.</summary>
                public const string UndefinedHealthStatus = "UNDEFINED_HEALTH_STATUS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.NetworkEndpointGroupsListEndpointsRequest.Types.HealthStatus.Show"/>.</summary>
                public const string Show = "SHOW";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.NetworkEndpointGroupsListEndpointsRequest.Types.HealthStatus.Skip"/>.</summary>
                public const string Skip = "SKIP";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.NetworkInterface"/> message.</summary>
        public static class NetworkInterface
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.NetworkInterface.Types.Ipv6AccessType"/> enum.</summary>
            public static class Ipv6AccessType
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.NetworkInterface.Types.Ipv6AccessType.UndefinedIpv6AccessType"/>.</summary>
                public const string UndefinedIpv6AccessType = "UNDEFINED_IPV6_ACCESS_TYPE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.NetworkInterface.Types.Ipv6AccessType.External"/>.</summary>
                public const string External = "EXTERNAL";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.NetworkInterface.Types.Ipv6AccessType.UnspecifiedIpv6AccessType"/>.</summary>
                public const string UnspecifiedIpv6AccessType = "UNSPECIFIED_IPV6_ACCESS_TYPE";
            }

            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.NetworkInterface.Types.NicType"/> enum.</summary>
            public static class NicType
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.NetworkInterface.Types.NicType.UndefinedNicType"/>.</summary>
                public const string UndefinedNicType = "UNDEFINED_NIC_TYPE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.NetworkInterface.Types.NicType.Gvnic"/>.</summary>
                public const string Gvnic = "GVNIC";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.NetworkInterface.Types.NicType.UnspecifiedNicType"/>.</summary>
                public const string UnspecifiedNicType = "UNSPECIFIED_NIC_TYPE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.NetworkInterface.Types.NicType.VirtioNet"/>.</summary>
                public const string VirtioNet = "VIRTIO_NET";
            }

            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.NetworkInterface.Types.StackType"/> enum.</summary>
            public static class StackType
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.NetworkInterface.Types.StackType.UndefinedStackType"/>.</summary>
                public const string UndefinedStackType = "UNDEFINED_STACK_TYPE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.NetworkInterface.Types.StackType.Ipv4Ipv6"/>.</summary>
                public const string Ipv4Ipv6 = "IPV4_IPV6";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.NetworkInterface.Types.StackType.Ipv4Only"/>.</summary>
                public const string Ipv4Only = "IPV4_ONLY";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.NetworkInterface.Types.StackType.UnspecifiedStackType"/>.</summary>
                public const string UnspecifiedStackType = "UNSPECIFIED_STACK_TYPE";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.NetworkPeering"/> message.</summary>
        public static class NetworkPeering
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.NetworkPeering.Types.State"/> enum.</summary>
            public static class State
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.NetworkPeering.Types.State.UndefinedState"/>.</summary>
                public const string UndefinedState = "UNDEFINED_STATE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.NetworkPeering.Types.State.Active"/>.</summary>
                public const string Active = "ACTIVE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.NetworkPeering.Types.State.Inactive"/>.</summary>
                public const string Inactive = "INACTIVE";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.NetworkPerformanceConfig"/> message.</summary>
        public static class NetworkPerformanceConfig
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.NetworkPerformanceConfig.Types.TotalEgressBandwidthTier"/> enum.</summary>
            public static class TotalEgressBandwidthTier
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.NetworkPerformanceConfig.Types.TotalEgressBandwidthTier.UndefinedTotalEgressBandwidthTier"/>.</summary>
                public const string UndefinedTotalEgressBandwidthTier = "UNDEFINED_TOTAL_EGRESS_BANDWIDTH_TIER";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.NetworkPerformanceConfig.Types.TotalEgressBandwidthTier.Default"/>.</summary>
                public const string Default = "DEFAULT";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.NetworkPerformanceConfig.Types.TotalEgressBandwidthTier.Tier1"/>.</summary>
                public const string Tier1 = "TIER_1";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.NetworkRoutingConfig"/> message.</summary>
        public static class NetworkRoutingConfig
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.NetworkRoutingConfig.Types.RoutingMode"/> enum.</summary>
            public static class RoutingMode
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.NetworkRoutingConfig.Types.RoutingMode.UndefinedRoutingMode"/>.</summary>
                public const string UndefinedRoutingMode = "UNDEFINED_ROUTING_MODE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.NetworkRoutingConfig.Types.RoutingMode.Global"/>.</summary>
                public const string Global = "GLOBAL";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.NetworkRoutingConfig.Types.RoutingMode.Regional"/>.</summary>
                public const string Regional = "REGIONAL";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.NetworksGetEffectiveFirewallsResponseEffectiveFirewallPolicy"/> message.</summary>
        public static class NetworksGetEffectiveFirewallsResponseEffectiveFirewallPolicy
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.NetworksGetEffectiveFirewallsResponseEffectiveFirewallPolicy.Types.Type"/> enum.</summary>
            public static class Type
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.NetworksGetEffectiveFirewallsResponseEffectiveFirewallPolicy.Types.Type.UndefinedType"/>.</summary>
                public const string UndefinedType = "UNDEFINED_TYPE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.NetworksGetEffectiveFirewallsResponseEffectiveFirewallPolicy.Types.Type.Hierarchy"/>.</summary>
                public const string Hierarchy = "HIERARCHY";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.NetworksGetEffectiveFirewallsResponseEffectiveFirewallPolicy.Types.Type.Network"/>.</summary>
                public const string Network = "NETWORK";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.NetworksGetEffectiveFirewallsResponseEffectiveFirewallPolicy.Types.Type.Unspecified"/>.</summary>
                public const string Unspecified = "UNSPECIFIED";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.NodeGroup"/> message.</summary>
        public static class NodeGroup
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.NodeGroup.Types.MaintenancePolicy"/> enum.</summary>
            public static class MaintenancePolicy
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.NodeGroup.Types.MaintenancePolicy.UndefinedMaintenancePolicy"/>.</summary>
                public const string UndefinedMaintenancePolicy = "UNDEFINED_MAINTENANCE_POLICY";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.NodeGroup.Types.MaintenancePolicy.Default"/>.</summary>
                public const string Default = "DEFAULT";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.NodeGroup.Types.MaintenancePolicy.Unspecified"/>.</summary>
                public const string Unspecified = "MAINTENANCE_POLICY_UNSPECIFIED";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.NodeGroup.Types.MaintenancePolicy.MigrateWithinNodeGroup"/>.</summary>
                public const string MigrateWithinNodeGroup = "MIGRATE_WITHIN_NODE_GROUP";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.NodeGroup.Types.MaintenancePolicy.RestartInPlace"/>.</summary>
                public const string RestartInPlace = "RESTART_IN_PLACE";
            }

            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.NodeGroup.Types.Status"/> enum.</summary>
            public static class Status
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.NodeGroup.Types.Status.UndefinedStatus"/>.</summary>
                public const string UndefinedStatus = "UNDEFINED_STATUS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.NodeGroup.Types.Status.Creating"/>.</summary>
                public const string Creating = "CREATING";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.NodeGroup.Types.Status.Deleting"/>.</summary>
                public const string Deleting = "DELETING";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.NodeGroup.Types.Status.Invalid"/>.</summary>
                public const string Invalid = "INVALID";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.NodeGroup.Types.Status.Ready"/>.</summary>
                public const string Ready = "READY";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.NodeGroupAutoscalingPolicy"/> message.</summary>
        public static class NodeGroupAutoscalingPolicy
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.NodeGroupAutoscalingPolicy.Types.Mode"/> enum.</summary>
            public static class Mode
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.NodeGroupAutoscalingPolicy.Types.Mode.UndefinedMode"/>.</summary>
                public const string UndefinedMode = "UNDEFINED_MODE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.NodeGroupAutoscalingPolicy.Types.Mode.Unspecified"/>.</summary>
                public const string Unspecified = "MODE_UNSPECIFIED";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.NodeGroupAutoscalingPolicy.Types.Mode.Off"/>.</summary>
                public const string Off = "OFF";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.NodeGroupAutoscalingPolicy.Types.Mode.On"/>.</summary>
                public const string On = "ON";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.NodeGroupAutoscalingPolicy.Types.Mode.OnlyScaleOut"/>.</summary>
                public const string OnlyScaleOut = "ONLY_SCALE_OUT";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.NodeGroupNode"/> message.</summary>
        public static class NodeGroupNode
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.NodeGroupNode.Types.CpuOvercommitType"/> enum.</summary>
            public static class CpuOvercommitType
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.NodeGroupNode.Types.CpuOvercommitType.UndefinedCpuOvercommitType"/>.</summary>
                public const string UndefinedCpuOvercommitType = "UNDEFINED_CPU_OVERCOMMIT_TYPE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.NodeGroupNode.Types.CpuOvercommitType.Unspecified"/>.</summary>
                public const string Unspecified = "CPU_OVERCOMMIT_TYPE_UNSPECIFIED";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.NodeGroupNode.Types.CpuOvercommitType.Enabled"/>.</summary>
                public const string Enabled = "ENABLED";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.NodeGroupNode.Types.CpuOvercommitType.None"/>.</summary>
                public const string None = "NONE";
            }

            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.NodeGroupNode.Types.Status"/> enum.</summary>
            public static class Status
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.NodeGroupNode.Types.Status.UndefinedStatus"/>.</summary>
                public const string UndefinedStatus = "UNDEFINED_STATUS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.NodeGroupNode.Types.Status.Creating"/>.</summary>
                public const string Creating = "CREATING";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.NodeGroupNode.Types.Status.Deleting"/>.</summary>
                public const string Deleting = "DELETING";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.NodeGroupNode.Types.Status.Invalid"/>.</summary>
                public const string Invalid = "INVALID";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.NodeGroupNode.Types.Status.Ready"/>.</summary>
                public const string Ready = "READY";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.NodeGroupNode.Types.Status.Repairing"/>.</summary>
                public const string Repairing = "REPAIRING";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.NodeTemplate"/> message.</summary>
        public static class NodeTemplate
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.NodeTemplate.Types.CpuOvercommitType"/> enum.</summary>
            public static class CpuOvercommitType
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.NodeTemplate.Types.CpuOvercommitType.UndefinedCpuOvercommitType"/>.</summary>
                public const string UndefinedCpuOvercommitType = "UNDEFINED_CPU_OVERCOMMIT_TYPE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.NodeTemplate.Types.CpuOvercommitType.Unspecified"/>.</summary>
                public const string Unspecified = "CPU_OVERCOMMIT_TYPE_UNSPECIFIED";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.NodeTemplate.Types.CpuOvercommitType.Enabled"/>.</summary>
                public const string Enabled = "ENABLED";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.NodeTemplate.Types.CpuOvercommitType.None"/>.</summary>
                public const string None = "NONE";
            }

            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.NodeTemplate.Types.Status"/> enum.</summary>
            public static class Status
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.NodeTemplate.Types.Status.UndefinedStatus"/>.</summary>
                public const string UndefinedStatus = "UNDEFINED_STATUS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.NodeTemplate.Types.Status.Creating"/>.</summary>
                public const string Creating = "CREATING";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.NodeTemplate.Types.Status.Deleting"/>.</summary>
                public const string Deleting = "DELETING";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.NodeTemplate.Types.Status.Invalid"/>.</summary>
                public const string Invalid = "INVALID";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.NodeTemplate.Types.Status.Ready"/>.</summary>
                public const string Ready = "READY";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.Operation"/> message.</summary>
        public static class Operation
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.Operation.Types.Status"/> enum.</summary>
            public static class Status
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Operation.Types.Status.UndefinedStatus"/>.</summary>
                public const string UndefinedStatus = "UNDEFINED_STATUS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Operation.Types.Status.Done"/>.</summary>
                public const string Done = "DONE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Operation.Types.Status.Pending"/>.</summary>
                public const string Pending = "PENDING";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Operation.Types.Status.Running"/>.</summary>
                public const string Running = "RUNNING";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.PacketIntervals"/> message.</summary>
        public static class PacketIntervals
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.PacketIntervals.Types.Duration"/> enum.</summary>
            public static class Duration
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.PacketIntervals.Types.Duration.UndefinedDuration"/>.</summary>
                public const string UndefinedDuration = "UNDEFINED_DURATION";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.PacketIntervals.Types.Duration.Unspecified"/>.</summary>
                public const string Unspecified = "DURATION_UNSPECIFIED";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.PacketIntervals.Types.Duration.Hour"/>.</summary>
                public const string Hour = "HOUR";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.PacketIntervals.Types.Duration.Max"/>.</summary>
                public const string Max = "MAX";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.PacketIntervals.Types.Duration.Minute"/>.</summary>
                public const string Minute = "MINUTE";
            }

            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.PacketIntervals.Types.Type"/> enum.</summary>
            public static class Type
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.PacketIntervals.Types.Type.UndefinedType"/>.</summary>
                public const string UndefinedType = "UNDEFINED_TYPE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.PacketIntervals.Types.Type.Loopback"/>.</summary>
                public const string Loopback = "LOOPBACK";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.PacketIntervals.Types.Type.Receive"/>.</summary>
                public const string Receive = "RECEIVE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.PacketIntervals.Types.Type.Transmit"/>.</summary>
                public const string Transmit = "TRANSMIT";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.PacketIntervals.Types.Type.Unspecified"/>.</summary>
                public const string Unspecified = "TYPE_UNSPECIFIED";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.PacketMirroring"/> message.</summary>
        public static class PacketMirroring
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.PacketMirroring.Types.Enable"/> enum.</summary>
            public static class Enable
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.PacketMirroring.Types.Enable.UndefinedEnable"/>.</summary>
                public const string UndefinedEnable = "UNDEFINED_ENABLE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.PacketMirroring.Types.Enable.False"/>.</summary>
                public const string False = "FALSE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.PacketMirroring.Types.Enable.True"/>.</summary>
                public const string True = "TRUE";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.PacketMirroringFilter"/> message.</summary>
        public static class PacketMirroringFilter
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.PacketMirroringFilter.Types.Direction"/> enum.</summary>
            public static class Direction
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.PacketMirroringFilter.Types.Direction.UndefinedDirection"/>.</summary>
                public const string UndefinedDirection = "UNDEFINED_DIRECTION";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.PacketMirroringFilter.Types.Direction.Both"/>.</summary>
                public const string Both = "BOTH";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.PacketMirroringFilter.Types.Direction.Egress"/>.</summary>
                public const string Egress = "EGRESS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.PacketMirroringFilter.Types.Direction.Ingress"/>.</summary>
                public const string Ingress = "INGRESS";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.PerInstanceConfig"/> message.</summary>
        public static class PerInstanceConfig
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.PerInstanceConfig.Types.Status"/> enum.</summary>
            public static class Status
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.PerInstanceConfig.Types.Status.UndefinedStatus"/>.</summary>
                public const string UndefinedStatus = "UNDEFINED_STATUS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.PerInstanceConfig.Types.Status.Applying"/>.</summary>
                public const string Applying = "APPLYING";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.PerInstanceConfig.Types.Status.Deleting"/>.</summary>
                public const string Deleting = "DELETING";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.PerInstanceConfig.Types.Status.Effective"/>.</summary>
                public const string Effective = "EFFECTIVE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.PerInstanceConfig.Types.Status.None"/>.</summary>
                public const string None = "NONE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.PerInstanceConfig.Types.Status.Unapplied"/>.</summary>
                public const string Unapplied = "UNAPPLIED";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.PerInstanceConfig.Types.Status.UnappliedDeletion"/>.</summary>
                public const string UnappliedDeletion = "UNAPPLIED_DELETION";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.PreservedStatePreservedDisk"/> message.</summary>
        public static class PreservedStatePreservedDisk
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.PreservedStatePreservedDisk.Types.AutoDelete"/> enum.</summary>
            public static class AutoDelete
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.PreservedStatePreservedDisk.Types.AutoDelete.UndefinedAutoDelete"/>.</summary>
                public const string UndefinedAutoDelete = "UNDEFINED_AUTO_DELETE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.PreservedStatePreservedDisk.Types.AutoDelete.Never"/>.</summary>
                public const string Never = "NEVER";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.PreservedStatePreservedDisk.Types.AutoDelete.OnPermanentInstanceDeletion"/>.</summary>
                public const string OnPermanentInstanceDeletion = "ON_PERMANENT_INSTANCE_DELETION";
            }

            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.PreservedStatePreservedDisk.Types.Mode"/> enum.</summary>
            public static class Mode
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.PreservedStatePreservedDisk.Types.Mode.UndefinedMode"/>.</summary>
                public const string UndefinedMode = "UNDEFINED_MODE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.PreservedStatePreservedDisk.Types.Mode.ReadOnly"/>.</summary>
                public const string ReadOnly = "READ_ONLY";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.PreservedStatePreservedDisk.Types.Mode.ReadWrite"/>.</summary>
                public const string ReadWrite = "READ_WRITE";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.Project"/> message.</summary>
        public static class Project
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.Project.Types.DefaultNetworkTier"/> enum.</summary>
            public static class DefaultNetworkTier
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Project.Types.DefaultNetworkTier.UndefinedDefaultNetworkTier"/>.</summary>
                public const string UndefinedDefaultNetworkTier = "UNDEFINED_DEFAULT_NETWORK_TIER";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Project.Types.DefaultNetworkTier.FixedStandard"/>.</summary>
                public const string FixedStandard = "FIXED_STANDARD";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Project.Types.DefaultNetworkTier.Premium"/>.</summary>
                public const string Premium = "PREMIUM";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Project.Types.DefaultNetworkTier.Standard"/>.</summary>
                public const string Standard = "STANDARD";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Project.Types.DefaultNetworkTier.StandardOverridesFixedStandard"/>.</summary>
                public const string StandardOverridesFixedStandard = "STANDARD_OVERRIDES_FIXED_STANDARD";
            }

            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.Project.Types.XpnProjectStatus"/> enum.</summary>
            public static class XpnProjectStatus
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Project.Types.XpnProjectStatus.UndefinedXpnProjectStatus"/>.</summary>
                public const string UndefinedXpnProjectStatus = "UNDEFINED_XPN_PROJECT_STATUS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Project.Types.XpnProjectStatus.Host"/>.</summary>
                public const string Host = "HOST";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Project.Types.XpnProjectStatus.UnspecifiedXpnProjectStatus"/>.</summary>
                public const string UnspecifiedXpnProjectStatus = "UNSPECIFIED_XPN_PROJECT_STATUS";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.ProjectsSetDefaultNetworkTierRequest"/> message.</summary>
        public static class ProjectsSetDefaultNetworkTierRequest
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.ProjectsSetDefaultNetworkTierRequest.Types.NetworkTier"/> enum.</summary>
            public static class NetworkTier
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ProjectsSetDefaultNetworkTierRequest.Types.NetworkTier.UndefinedNetworkTier"/>.</summary>
                public const string UndefinedNetworkTier = "UNDEFINED_NETWORK_TIER";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ProjectsSetDefaultNetworkTierRequest.Types.NetworkTier.FixedStandard"/>.</summary>
                public const string FixedStandard = "FIXED_STANDARD";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ProjectsSetDefaultNetworkTierRequest.Types.NetworkTier.Premium"/>.</summary>
                public const string Premium = "PREMIUM";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ProjectsSetDefaultNetworkTierRequest.Types.NetworkTier.Standard"/>.</summary>
                public const string Standard = "STANDARD";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ProjectsSetDefaultNetworkTierRequest.Types.NetworkTier.StandardOverridesFixedStandard"/>.</summary>
                public const string StandardOverridesFixedStandard = "STANDARD_OVERRIDES_FIXED_STANDARD";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.PublicAdvertisedPrefix"/> message.</summary>
        public static class PublicAdvertisedPrefix
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.PublicAdvertisedPrefix.Types.Status"/> enum.</summary>
            public static class Status
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.PublicAdvertisedPrefix.Types.Status.UndefinedStatus"/>.</summary>
                public const string UndefinedStatus = "UNDEFINED_STATUS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.PublicAdvertisedPrefix.Types.Status.Initial"/>.</summary>
                public const string Initial = "INITIAL";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.PublicAdvertisedPrefix.Types.Status.PrefixConfigurationComplete"/>.</summary>
                public const string PrefixConfigurationComplete = "PREFIX_CONFIGURATION_COMPLETE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.PublicAdvertisedPrefix.Types.Status.PrefixConfigurationInProgress"/>.</summary>
                public const string PrefixConfigurationInProgress = "PREFIX_CONFIGURATION_IN_PROGRESS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.PublicAdvertisedPrefix.Types.Status.PrefixRemovalInProgress"/>.</summary>
                public const string PrefixRemovalInProgress = "PREFIX_REMOVAL_IN_PROGRESS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.PublicAdvertisedPrefix.Types.Status.PtrConfigured"/>.</summary>
                public const string PtrConfigured = "PTR_CONFIGURED";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.PublicAdvertisedPrefix.Types.Status.ReverseDnsLookupFailed"/>.</summary>
                public const string ReverseDnsLookupFailed = "REVERSE_DNS_LOOKUP_FAILED";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.PublicAdvertisedPrefix.Types.Status.Validated"/>.</summary>
                public const string Validated = "VALIDATED";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.PublicDelegatedPrefix"/> message.</summary>
        public static class PublicDelegatedPrefix
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.PublicDelegatedPrefix.Types.Status"/> enum.</summary>
            public static class Status
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.PublicDelegatedPrefix.Types.Status.UndefinedStatus"/>.</summary>
                public const string UndefinedStatus = "UNDEFINED_STATUS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.PublicDelegatedPrefix.Types.Status.Announced"/>.</summary>
                public const string Announced = "ANNOUNCED";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.PublicDelegatedPrefix.Types.Status.Deleting"/>.</summary>
                public const string Deleting = "DELETING";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.PublicDelegatedPrefix.Types.Status.Initializing"/>.</summary>
                public const string Initializing = "INITIALIZING";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.PublicDelegatedPrefix.Types.Status.ReadyToAnnounce"/>.</summary>
                public const string ReadyToAnnounce = "READY_TO_ANNOUNCE";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.PublicDelegatedPrefixPublicDelegatedSubPrefix"/> message.</summary>
        public static class PublicDelegatedPrefixPublicDelegatedSubPrefix
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.PublicDelegatedPrefixPublicDelegatedSubPrefix.Types.Status"/> enum.</summary>
            public static class Status
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.PublicDelegatedPrefixPublicDelegatedSubPrefix.Types.Status.UndefinedStatus"/>.</summary>
                public const string UndefinedStatus = "UNDEFINED_STATUS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.PublicDelegatedPrefixPublicDelegatedSubPrefix.Types.Status.Active"/>.</summary>
                public const string Active = "ACTIVE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.PublicDelegatedPrefixPublicDelegatedSubPrefix.Types.Status.Inactive"/>.</summary>
                public const string Inactive = "INACTIVE";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.Quota"/> message.</summary>
        public static class Quota
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric"/> enum.</summary>
            public static class Metric
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.UndefinedMetric"/>.</summary>
                public const string UndefinedMetric = "UNDEFINED_METRIC";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.A2Cpus"/>.</summary>
                public const string A2Cpus = "A2_CPUS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.AffinityGroups"/>.</summary>
                public const string AffinityGroups = "AFFINITY_GROUPS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.Autoscalers"/>.</summary>
                public const string Autoscalers = "AUTOSCALERS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.BackendBuckets"/>.</summary>
                public const string BackendBuckets = "BACKEND_BUCKETS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.BackendServices"/>.</summary>
                public const string BackendServices = "BACKEND_SERVICES";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.C2DCpus"/>.</summary>
                public const string C2DCpus = "C2D_CPUS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.C2Cpus"/>.</summary>
                public const string C2Cpus = "C2_CPUS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.C3Cpus"/>.</summary>
                public const string C3Cpus = "C3_CPUS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.Commitments"/>.</summary>
                public const string Commitments = "COMMITMENTS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.CommittedA2Cpus"/>.</summary>
                public const string CommittedA2Cpus = "COMMITTED_A2_CPUS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.CommittedC2DCpus"/>.</summary>
                public const string CommittedC2DCpus = "COMMITTED_C2D_CPUS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.CommittedC2Cpus"/>.</summary>
                public const string CommittedC2Cpus = "COMMITTED_C2_CPUS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.CommittedC3Cpus"/>.</summary>
                public const string CommittedC3Cpus = "COMMITTED_C3_CPUS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.CommittedCpus"/>.</summary>
                public const string CommittedCpus = "COMMITTED_CPUS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.CommittedE2Cpus"/>.</summary>
                public const string CommittedE2Cpus = "COMMITTED_E2_CPUS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.CommittedLicenses"/>.</summary>
                public const string CommittedLicenses = "COMMITTED_LICENSES";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.CommittedLocalSsdTotalGb"/>.</summary>
                public const string CommittedLocalSsdTotalGb = "COMMITTED_LOCAL_SSD_TOTAL_GB";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.CommittedM3Cpus"/>.</summary>
                public const string CommittedM3Cpus = "COMMITTED_M3_CPUS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.CommittedMemoryOptimizedCpus"/>.</summary>
                public const string CommittedMemoryOptimizedCpus = "COMMITTED_MEMORY_OPTIMIZED_CPUS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.CommittedN2ACpus"/>.</summary>
                public const string CommittedN2ACpus = "COMMITTED_N2A_CPUS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.CommittedN2DCpus"/>.</summary>
                public const string CommittedN2DCpus = "COMMITTED_N2D_CPUS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.CommittedN2Cpus"/>.</summary>
                public const string CommittedN2Cpus = "COMMITTED_N2_CPUS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.CommittedNvidiaA100Gpus"/>.</summary>
                public const string CommittedNvidiaA100Gpus = "COMMITTED_NVIDIA_A100_GPUS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.CommittedNvidiaK80Gpus"/>.</summary>
                public const string CommittedNvidiaK80Gpus = "COMMITTED_NVIDIA_K80_GPUS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.CommittedNvidiaP100Gpus"/>.</summary>
                public const string CommittedNvidiaP100Gpus = "COMMITTED_NVIDIA_P100_GPUS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.CommittedNvidiaP4Gpus"/>.</summary>
                public const string CommittedNvidiaP4Gpus = "COMMITTED_NVIDIA_P4_GPUS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.CommittedNvidiaT4Gpus"/>.</summary>
                public const string CommittedNvidiaT4Gpus = "COMMITTED_NVIDIA_T4_GPUS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.CommittedNvidiaV100Gpus"/>.</summary>
                public const string CommittedNvidiaV100Gpus = "COMMITTED_NVIDIA_V100_GPUS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.CommittedT2ACpus"/>.</summary>
                public const string CommittedT2ACpus = "COMMITTED_T2A_CPUS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.CommittedT2DCpus"/>.</summary>
                public const string CommittedT2DCpus = "COMMITTED_T2D_CPUS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.Cpus"/>.</summary>
                public const string Cpus = "CPUS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.CpusAllRegions"/>.</summary>
                public const string CpusAllRegions = "CPUS_ALL_REGIONS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.DisksTotalGb"/>.</summary>
                public const string DisksTotalGb = "DISKS_TOTAL_GB";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.E2Cpus"/>.</summary>
                public const string E2Cpus = "E2_CPUS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.ExternalNetworkLbForwardingRules"/>.</summary>
                public const string ExternalNetworkLbForwardingRules = "EXTERNAL_NETWORK_LB_FORWARDING_RULES";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.ExternalProtocolForwardingRules"/>.</summary>
                public const string ExternalProtocolForwardingRules = "EXTERNAL_PROTOCOL_FORWARDING_RULES";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.ExternalVpnGateways"/>.</summary>
                public const string ExternalVpnGateways = "EXTERNAL_VPN_GATEWAYS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.Firewalls"/>.</summary>
                public const string Firewalls = "FIREWALLS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.ForwardingRules"/>.</summary>
                public const string ForwardingRules = "FORWARDING_RULES";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.GlobalExternalManagedForwardingRules"/>.</summary>
                public const string GlobalExternalManagedForwardingRules = "GLOBAL_EXTERNAL_MANAGED_FORWARDING_RULES";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.GlobalInternalAddresses"/>.</summary>
                public const string GlobalInternalAddresses = "GLOBAL_INTERNAL_ADDRESSES";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.GpusAllRegions"/>.</summary>
                public const string GpusAllRegions = "GPUS_ALL_REGIONS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.HealthChecks"/>.</summary>
                public const string HealthChecks = "HEALTH_CHECKS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.Images"/>.</summary>
                public const string Images = "IMAGES";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.Instances"/>.</summary>
                public const string Instances = "INSTANCES";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.InstanceGroups"/>.</summary>
                public const string InstanceGroups = "INSTANCE_GROUPS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.InstanceGroupManagers"/>.</summary>
                public const string InstanceGroupManagers = "INSTANCE_GROUP_MANAGERS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.InstanceTemplates"/>.</summary>
                public const string InstanceTemplates = "INSTANCE_TEMPLATES";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.Interconnects"/>.</summary>
                public const string Interconnects = "INTERCONNECTS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.InterconnectAttachmentsPerRegion"/>.</summary>
                public const string InterconnectAttachmentsPerRegion = "INTERCONNECT_ATTACHMENTS_PER_REGION";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.InterconnectAttachmentsTotalMbps"/>.</summary>
                public const string InterconnectAttachmentsTotalMbps = "INTERCONNECT_ATTACHMENTS_TOTAL_MBPS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.InterconnectTotalGbps"/>.</summary>
                public const string InterconnectTotalGbps = "INTERCONNECT_TOTAL_GBPS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.InternalAddresses"/>.</summary>
                public const string InternalAddresses = "INTERNAL_ADDRESSES";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.InternalTrafficDirectorForwardingRules"/>.</summary>
                public const string InternalTrafficDirectorForwardingRules = "INTERNAL_TRAFFIC_DIRECTOR_FORWARDING_RULES";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.InPlaceSnapshots"/>.</summary>
                public const string InPlaceSnapshots = "IN_PLACE_SNAPSHOTS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.InUseAddresses"/>.</summary>
                public const string InUseAddresses = "IN_USE_ADDRESSES";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.InUseBackupSchedules"/>.</summary>
                public const string InUseBackupSchedules = "IN_USE_BACKUP_SCHEDULES";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.InUseSnapshotSchedules"/>.</summary>
                public const string InUseSnapshotSchedules = "IN_USE_SNAPSHOT_SCHEDULES";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.LocalSsdTotalGb"/>.</summary>
                public const string LocalSsdTotalGb = "LOCAL_SSD_TOTAL_GB";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.M1Cpus"/>.</summary>
                public const string M1Cpus = "M1_CPUS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.M2Cpus"/>.</summary>
                public const string M2Cpus = "M2_CPUS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.M3Cpus"/>.</summary>
                public const string M3Cpus = "M3_CPUS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.MachineImages"/>.</summary>
                public const string MachineImages = "MACHINE_IMAGES";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.N2ACpus"/>.</summary>
                public const string N2ACpus = "N2A_CPUS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.N2DCpus"/>.</summary>
                public const string N2DCpus = "N2D_CPUS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.N2Cpus"/>.</summary>
                public const string N2Cpus = "N2_CPUS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.Networks"/>.</summary>
                public const string Networks = "NETWORKS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.NetworkEndpointGroups"/>.</summary>
                public const string NetworkEndpointGroups = "NETWORK_ENDPOINT_GROUPS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.NetworkFirewallPolicies"/>.</summary>
                public const string NetworkFirewallPolicies = "NETWORK_FIREWALL_POLICIES";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.NodeGroups"/>.</summary>
                public const string NodeGroups = "NODE_GROUPS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.NodeTemplates"/>.</summary>
                public const string NodeTemplates = "NODE_TEMPLATES";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.NvidiaA100Gpus"/>.</summary>
                public const string NvidiaA100Gpus = "NVIDIA_A100_GPUS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.NvidiaK80Gpus"/>.</summary>
                public const string NvidiaK80Gpus = "NVIDIA_K80_GPUS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.NvidiaP100Gpus"/>.</summary>
                public const string NvidiaP100Gpus = "NVIDIA_P100_GPUS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.NvidiaP100VwsGpus"/>.</summary>
                public const string NvidiaP100VwsGpus = "NVIDIA_P100_VWS_GPUS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.NvidiaP4Gpus"/>.</summary>
                public const string NvidiaP4Gpus = "NVIDIA_P4_GPUS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.NvidiaP4VwsGpus"/>.</summary>
                public const string NvidiaP4VwsGpus = "NVIDIA_P4_VWS_GPUS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.NvidiaT4Gpus"/>.</summary>
                public const string NvidiaT4Gpus = "NVIDIA_T4_GPUS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.NvidiaT4VwsGpus"/>.</summary>
                public const string NvidiaT4VwsGpus = "NVIDIA_T4_VWS_GPUS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.NvidiaV100Gpus"/>.</summary>
                public const string NvidiaV100Gpus = "NVIDIA_V100_GPUS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.PacketMirrorings"/>.</summary>
                public const string PacketMirrorings = "PACKET_MIRRORINGS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.PdExtremeTotalProvisionedIops"/>.</summary>
                public const string PdExtremeTotalProvisionedIops = "PD_EXTREME_TOTAL_PROVISIONED_IOPS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.PreemptibleCpus"/>.</summary>
                public const string PreemptibleCpus = "PREEMPTIBLE_CPUS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.PreemptibleLocalSsdGb"/>.</summary>
                public const string PreemptibleLocalSsdGb = "PREEMPTIBLE_LOCAL_SSD_GB";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.PreemptibleNvidiaA100Gpus"/>.</summary>
                public const string PreemptibleNvidiaA100Gpus = "PREEMPTIBLE_NVIDIA_A100_GPUS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.PreemptibleNvidiaK80Gpus"/>.</summary>
                public const string PreemptibleNvidiaK80Gpus = "PREEMPTIBLE_NVIDIA_K80_GPUS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.PreemptibleNvidiaP100Gpus"/>.</summary>
                public const string PreemptibleNvidiaP100Gpus = "PREEMPTIBLE_NVIDIA_P100_GPUS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.PreemptibleNvidiaP100VwsGpus"/>.</summary>
                public const string PreemptibleNvidiaP100VwsGpus = "PREEMPTIBLE_NVIDIA_P100_VWS_GPUS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.PreemptibleNvidiaP4Gpus"/>.</summary>
                public const string PreemptibleNvidiaP4Gpus = "PREEMPTIBLE_NVIDIA_P4_GPUS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.PreemptibleNvidiaP4VwsGpus"/>.</summary>
                public const string PreemptibleNvidiaP4VwsGpus = "PREEMPTIBLE_NVIDIA_P4_VWS_GPUS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.PreemptibleNvidiaT4Gpus"/>.</summary>
                public const string PreemptibleNvidiaT4Gpus = "PREEMPTIBLE_NVIDIA_T4_GPUS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.PreemptibleNvidiaT4VwsGpus"/>.</summary>
                public const string PreemptibleNvidiaT4VwsGpus = "PREEMPTIBLE_NVIDIA_T4_VWS_GPUS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.PreemptibleNvidiaV100Gpus"/>.</summary>
                public const string PreemptibleNvidiaV100Gpus = "PREEMPTIBLE_NVIDIA_V100_GPUS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.PscIlbConsumerForwardingRulesPerProducerNetwork"/>.</summary>
                public const string PscIlbConsumerForwardingRulesPerProducerNetwork = "PSC_ILB_CONSUMER_FORWARDING_RULES_PER_PRODUCER_NETWORK";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.PscInternalLbForwardingRules"/>.</summary>
                public const string PscInternalLbForwardingRules = "PSC_INTERNAL_LB_FORWARDING_RULES";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.PublicAdvertisedPrefixes"/>.</summary>
                public const string PublicAdvertisedPrefixes = "PUBLIC_ADVERTISED_PREFIXES";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.PublicDelegatedPrefixes"/>.</summary>
                public const string PublicDelegatedPrefixes = "PUBLIC_DELEGATED_PREFIXES";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.RegionalAutoscalers"/>.</summary>
                public const string RegionalAutoscalers = "REGIONAL_AUTOSCALERS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.RegionalInstanceGroupManagers"/>.</summary>
                public const string RegionalInstanceGroupManagers = "REGIONAL_INSTANCE_GROUP_MANAGERS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.Reservations"/>.</summary>
                public const string Reservations = "RESERVATIONS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.ResourcePolicies"/>.</summary>
                public const string ResourcePolicies = "RESOURCE_POLICIES";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.Routers"/>.</summary>
                public const string Routers = "ROUTERS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.Routes"/>.</summary>
                public const string Routes = "ROUTES";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.SecurityPolicies"/>.</summary>
                public const string SecurityPolicies = "SECURITY_POLICIES";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.SecurityPoliciesPerRegion"/>.</summary>
                public const string SecurityPoliciesPerRegion = "SECURITY_POLICIES_PER_REGION";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.SecurityPolicyCevalRules"/>.</summary>
                public const string SecurityPolicyCevalRules = "SECURITY_POLICY_CEVAL_RULES";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.SecurityPolicyRules"/>.</summary>
                public const string SecurityPolicyRules = "SECURITY_POLICY_RULES";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.SecurityPolicyRulesPerRegion"/>.</summary>
                public const string SecurityPolicyRulesPerRegion = "SECURITY_POLICY_RULES_PER_REGION";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.ServiceAttachments"/>.</summary>
                public const string ServiceAttachments = "SERVICE_ATTACHMENTS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.Snapshots"/>.</summary>
                public const string Snapshots = "SNAPSHOTS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.SsdTotalGb"/>.</summary>
                public const string SsdTotalGb = "SSD_TOTAL_GB";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.SslCertificates"/>.</summary>
                public const string SslCertificates = "SSL_CERTIFICATES";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.StaticAddresses"/>.</summary>
                public const string StaticAddresses = "STATIC_ADDRESSES";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.StaticByoipAddresses"/>.</summary>
                public const string StaticByoipAddresses = "STATIC_BYOIP_ADDRESSES";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.Subnetworks"/>.</summary>
                public const string Subnetworks = "SUBNETWORKS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.T2ACpus"/>.</summary>
                public const string T2ACpus = "T2A_CPUS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.T2DCpus"/>.</summary>
                public const string T2DCpus = "T2D_CPUS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.TargetHttpsProxies"/>.</summary>
                public const string TargetHttpsProxies = "TARGET_HTTPS_PROXIES";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.TargetHttpProxies"/>.</summary>
                public const string TargetHttpProxies = "TARGET_HTTP_PROXIES";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.TargetInstances"/>.</summary>
                public const string TargetInstances = "TARGET_INSTANCES";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.TargetPools"/>.</summary>
                public const string TargetPools = "TARGET_POOLS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.TargetSslProxies"/>.</summary>
                public const string TargetSslProxies = "TARGET_SSL_PROXIES";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.TargetTcpProxies"/>.</summary>
                public const string TargetTcpProxies = "TARGET_TCP_PROXIES";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.TargetVpnGateways"/>.</summary>
                public const string TargetVpnGateways = "TARGET_VPN_GATEWAYS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.UrlMaps"/>.</summary>
                public const string UrlMaps = "URL_MAPS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.VpnGateways"/>.</summary>
                public const string VpnGateways = "VPN_GATEWAYS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.VpnTunnels"/>.</summary>
                public const string VpnTunnels = "VPN_TUNNELS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Quota.Types.Metric.XpnServiceProjects"/>.</summary>
                public const string XpnServiceProjects = "XPN_SERVICE_PROJECTS";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.RawDisk"/> message.</summary>
        public static class RawDisk
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.RawDisk.Types.ContainerType"/> enum.</summary>
            public static class ContainerType
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.RawDisk.Types.ContainerType.UndefinedContainerType"/>.</summary>
                public const string UndefinedContainerType = "UNDEFINED_CONTAINER_TYPE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.RawDisk.Types.ContainerType.Tar"/>.</summary>
                public const string Tar = "TAR";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.Region"/> message.</summary>
        public static class Region
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.Region.Types.Status"/> enum.</summary>
            public static class Status
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Region.Types.Status.UndefinedStatus"/>.</summary>
                public const string UndefinedStatus = "UNDEFINED_STATUS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Region.Types.Status.Down"/>.</summary>
                public const string Down = "DOWN";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Region.Types.Status.Up"/>.</summary>
                public const string Up = "UP";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.RegionInstanceGroupsListInstancesRequest"/> message.</summary>
        public static class RegionInstanceGroupsListInstancesRequest
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.RegionInstanceGroupsListInstancesRequest.Types.InstanceState"/> enum.</summary>
            public static class InstanceState
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.RegionInstanceGroupsListInstancesRequest.Types.InstanceState.UndefinedInstanceState"/>.</summary>
                public const string UndefinedInstanceState = "UNDEFINED_INSTANCE_STATE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.RegionInstanceGroupsListInstancesRequest.Types.InstanceState.All"/>.</summary>
                public const string All = "ALL";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.RegionInstanceGroupsListInstancesRequest.Types.InstanceState.Running"/>.</summary>
                public const string Running = "RUNNING";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.Reservation"/> message.</summary>
        public static class Reservation
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.Reservation.Types.Status"/> enum.</summary>
            public static class Status
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Reservation.Types.Status.UndefinedStatus"/>.</summary>
                public const string UndefinedStatus = "UNDEFINED_STATUS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Reservation.Types.Status.Creating"/>.</summary>
                public const string Creating = "CREATING";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Reservation.Types.Status.Deleting"/>.</summary>
                public const string Deleting = "DELETING";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Reservation.Types.Status.Invalid"/>.</summary>
                public const string Invalid = "INVALID";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Reservation.Types.Status.Ready"/>.</summary>
                public const string Ready = "READY";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Reservation.Types.Status.Updating"/>.</summary>
                public const string Updating = "UPDATING";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.ReservationAffinity"/> message.</summary>
        public static class ReservationAffinity
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.ReservationAffinity.Types.ConsumeReservationType"/> enum.</summary>
            public static class ConsumeReservationType
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ReservationAffinity.Types.ConsumeReservationType.UndefinedConsumeReservationType"/>.</summary>
                public const string UndefinedConsumeReservationType = "UNDEFINED_CONSUME_RESERVATION_TYPE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ReservationAffinity.Types.ConsumeReservationType.AnyReservation"/>.</summary>
                public const string AnyReservation = "ANY_RESERVATION";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ReservationAffinity.Types.ConsumeReservationType.NoReservation"/>.</summary>
                public const string NoReservation = "NO_RESERVATION";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ReservationAffinity.Types.ConsumeReservationType.SpecificReservation"/>.</summary>
                public const string SpecificReservation = "SPECIFIC_RESERVATION";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ReservationAffinity.Types.ConsumeReservationType.Unspecified"/>.</summary>
                public const string Unspecified = "UNSPECIFIED";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.ResourceCommitment"/> message.</summary>
        public static class ResourceCommitment
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.ResourceCommitment.Types.Type"/> enum.</summary>
            public static class Type
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ResourceCommitment.Types.Type.UndefinedType"/>.</summary>
                public const string UndefinedType = "UNDEFINED_TYPE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ResourceCommitment.Types.Type.Accelerator"/>.</summary>
                public const string Accelerator = "ACCELERATOR";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ResourceCommitment.Types.Type.LocalSsd"/>.</summary>
                public const string LocalSsd = "LOCAL_SSD";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ResourceCommitment.Types.Type.Memory"/>.</summary>
                public const string Memory = "MEMORY";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ResourceCommitment.Types.Type.Unspecified"/>.</summary>
                public const string Unspecified = "UNSPECIFIED";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ResourceCommitment.Types.Type.Vcpu"/>.</summary>
                public const string Vcpu = "VCPU";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.ResourcePolicy"/> message.</summary>
        public static class ResourcePolicy
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.ResourcePolicy.Types.Status"/> enum.</summary>
            public static class Status
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ResourcePolicy.Types.Status.UndefinedStatus"/>.</summary>
                public const string UndefinedStatus = "UNDEFINED_STATUS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ResourcePolicy.Types.Status.Creating"/>.</summary>
                public const string Creating = "CREATING";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ResourcePolicy.Types.Status.Deleting"/>.</summary>
                public const string Deleting = "DELETING";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ResourcePolicy.Types.Status.Expired"/>.</summary>
                public const string Expired = "EXPIRED";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ResourcePolicy.Types.Status.Invalid"/>.</summary>
                public const string Invalid = "INVALID";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ResourcePolicy.Types.Status.Ready"/>.</summary>
                public const string Ready = "READY";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.ResourcePolicyGroupPlacementPolicy"/> message.</summary>
        public static class ResourcePolicyGroupPlacementPolicy
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.ResourcePolicyGroupPlacementPolicy.Types.Collocation"/> enum.</summary>
            public static class Collocation
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ResourcePolicyGroupPlacementPolicy.Types.Collocation.UndefinedCollocation"/>.</summary>
                public const string UndefinedCollocation = "UNDEFINED_COLLOCATION";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ResourcePolicyGroupPlacementPolicy.Types.Collocation.Collocated"/>.</summary>
                public const string Collocated = "COLLOCATED";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ResourcePolicyGroupPlacementPolicy.Types.Collocation.UnspecifiedCollocation"/>.</summary>
                public const string UnspecifiedCollocation = "UNSPECIFIED_COLLOCATION";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.ResourcePolicySnapshotSchedulePolicyRetentionPolicy"/> message.</summary>
        public static class ResourcePolicySnapshotSchedulePolicyRetentionPolicy
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.ResourcePolicySnapshotSchedulePolicyRetentionPolicy.Types.OnSourceDiskDelete"/> enum.</summary>
            public static class OnSourceDiskDelete
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ResourcePolicySnapshotSchedulePolicyRetentionPolicy.Types.OnSourceDiskDelete.UndefinedOnSourceDiskDelete"/>.</summary>
                public const string UndefinedOnSourceDiskDelete = "UNDEFINED_ON_SOURCE_DISK_DELETE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ResourcePolicySnapshotSchedulePolicyRetentionPolicy.Types.OnSourceDiskDelete.ApplyRetentionPolicy"/>.</summary>
                public const string ApplyRetentionPolicy = "APPLY_RETENTION_POLICY";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ResourcePolicySnapshotSchedulePolicyRetentionPolicy.Types.OnSourceDiskDelete.KeepAutoSnapshots"/>.</summary>
                public const string KeepAutoSnapshots = "KEEP_AUTO_SNAPSHOTS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ResourcePolicySnapshotSchedulePolicyRetentionPolicy.Types.OnSourceDiskDelete.UnspecifiedOnSourceDiskDelete"/>.</summary>
                public const string UnspecifiedOnSourceDiskDelete = "UNSPECIFIED_ON_SOURCE_DISK_DELETE";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.ResourcePolicyWeeklyCycleDayOfWeek"/> message.</summary>
        public static class ResourcePolicyWeeklyCycleDayOfWeek
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.ResourcePolicyWeeklyCycleDayOfWeek.Types.Day"/> enum.</summary>
            public static class Day
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ResourcePolicyWeeklyCycleDayOfWeek.Types.Day.UndefinedDay"/>.</summary>
                public const string UndefinedDay = "UNDEFINED_DAY";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ResourcePolicyWeeklyCycleDayOfWeek.Types.Day.Friday"/>.</summary>
                public const string Friday = "FRIDAY";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ResourcePolicyWeeklyCycleDayOfWeek.Types.Day.Invalid"/>.</summary>
                public const string Invalid = "INVALID";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ResourcePolicyWeeklyCycleDayOfWeek.Types.Day.Monday"/>.</summary>
                public const string Monday = "MONDAY";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ResourcePolicyWeeklyCycleDayOfWeek.Types.Day.Saturday"/>.</summary>
                public const string Saturday = "SATURDAY";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ResourcePolicyWeeklyCycleDayOfWeek.Types.Day.Sunday"/>.</summary>
                public const string Sunday = "SUNDAY";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ResourcePolicyWeeklyCycleDayOfWeek.Types.Day.Thursday"/>.</summary>
                public const string Thursday = "THURSDAY";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ResourcePolicyWeeklyCycleDayOfWeek.Types.Day.Tuesday"/>.</summary>
                public const string Tuesday = "TUESDAY";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ResourcePolicyWeeklyCycleDayOfWeek.Types.Day.Wednesday"/>.</summary>
                public const string Wednesday = "WEDNESDAY";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.Route"/> message.</summary>
        public static class Route
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.Route.Types.RouteType"/> enum.</summary>
            public static class RouteType
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Route.Types.RouteType.UndefinedRouteType"/>.</summary>
                public const string UndefinedRouteType = "UNDEFINED_ROUTE_TYPE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Route.Types.RouteType.Bgp"/>.</summary>
                public const string Bgp = "BGP";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Route.Types.RouteType.Static"/>.</summary>
                public const string Static = "STATIC";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Route.Types.RouteType.Subnet"/>.</summary>
                public const string Subnet = "SUBNET";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Route.Types.RouteType.Transit"/>.</summary>
                public const string Transit = "TRANSIT";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.RouteAsPath"/> message.</summary>
        public static class RouteAsPath
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.RouteAsPath.Types.PathSegmentType"/> enum.</summary>
            public static class PathSegmentType
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.RouteAsPath.Types.PathSegmentType.UndefinedPathSegmentType"/>.</summary>
                public const string UndefinedPathSegmentType = "UNDEFINED_PATH_SEGMENT_TYPE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.RouteAsPath.Types.PathSegmentType.AsConfedSequence"/>.</summary>
                public const string AsConfedSequence = "AS_CONFED_SEQUENCE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.RouteAsPath.Types.PathSegmentType.AsConfedSet"/>.</summary>
                public const string AsConfedSet = "AS_CONFED_SET";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.RouteAsPath.Types.PathSegmentType.AsSequence"/>.</summary>
                public const string AsSequence = "AS_SEQUENCE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.RouteAsPath.Types.PathSegmentType.AsSet"/>.</summary>
                public const string AsSet = "AS_SET";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.RouterBgp"/> message.</summary>
        public static class RouterBgp
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.RouterBgp.Types.AdvertiseMode"/> enum.</summary>
            public static class AdvertiseMode
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.RouterBgp.Types.AdvertiseMode.UndefinedAdvertiseMode"/>.</summary>
                public const string UndefinedAdvertiseMode = "UNDEFINED_ADVERTISE_MODE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.RouterBgp.Types.AdvertiseMode.Custom"/>.</summary>
                public const string Custom = "CUSTOM";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.RouterBgp.Types.AdvertiseMode.Default"/>.</summary>
                public const string Default = "DEFAULT";
            }

            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.RouterBgp.Types.AdvertisedGroups"/> enum.</summary>
            public static class AdvertisedGroups
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.RouterBgp.Types.AdvertisedGroups.UndefinedAdvertisedGroups"/>.</summary>
                public const string UndefinedAdvertisedGroups = "UNDEFINED_ADVERTISED_GROUPS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.RouterBgp.Types.AdvertisedGroups.AllSubnets"/>.</summary>
                public const string AllSubnets = "ALL_SUBNETS";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.RouterBgpPeer"/> message.</summary>
        public static class RouterBgpPeer
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.RouterBgpPeer.Types.AdvertiseMode"/> enum.</summary>
            public static class AdvertiseMode
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.RouterBgpPeer.Types.AdvertiseMode.UndefinedAdvertiseMode"/>.</summary>
                public const string UndefinedAdvertiseMode = "UNDEFINED_ADVERTISE_MODE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.RouterBgpPeer.Types.AdvertiseMode.Custom"/>.</summary>
                public const string Custom = "CUSTOM";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.RouterBgpPeer.Types.AdvertiseMode.Default"/>.</summary>
                public const string Default = "DEFAULT";
            }

            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.RouterBgpPeer.Types.AdvertisedGroups"/> enum.</summary>
            public static class AdvertisedGroups
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.RouterBgpPeer.Types.AdvertisedGroups.UndefinedAdvertisedGroups"/>.</summary>
                public const string UndefinedAdvertisedGroups = "UNDEFINED_ADVERTISED_GROUPS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.RouterBgpPeer.Types.AdvertisedGroups.AllSubnets"/>.</summary>
                public const string AllSubnets = "ALL_SUBNETS";
            }

            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.RouterBgpPeer.Types.Enable"/> enum.</summary>
            public static class Enable
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.RouterBgpPeer.Types.Enable.UndefinedEnable"/>.</summary>
                public const string UndefinedEnable = "UNDEFINED_ENABLE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.RouterBgpPeer.Types.Enable.False"/>.</summary>
                public const string False = "FALSE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.RouterBgpPeer.Types.Enable.True"/>.</summary>
                public const string True = "TRUE";
            }

            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.RouterBgpPeer.Types.ManagementType"/> enum.</summary>
            public static class ManagementType
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.RouterBgpPeer.Types.ManagementType.UndefinedManagementType"/>.</summary>
                public const string UndefinedManagementType = "UNDEFINED_MANAGEMENT_TYPE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.RouterBgpPeer.Types.ManagementType.ManagedByAttachment"/>.</summary>
                public const string ManagedByAttachment = "MANAGED_BY_ATTACHMENT";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.RouterBgpPeer.Types.ManagementType.ManagedByUser"/>.</summary>
                public const string ManagedByUser = "MANAGED_BY_USER";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.RouterBgpPeerBfd"/> message.</summary>
        public static class RouterBgpPeerBfd
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.RouterBgpPeerBfd.Types.SessionInitializationMode"/> enum.</summary>
            public static class SessionInitializationMode
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.RouterBgpPeerBfd.Types.SessionInitializationMode.UndefinedSessionInitializationMode"/>.</summary>
                public const string UndefinedSessionInitializationMode = "UNDEFINED_SESSION_INITIALIZATION_MODE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.RouterBgpPeerBfd.Types.SessionInitializationMode.Active"/>.</summary>
                public const string Active = "ACTIVE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.RouterBgpPeerBfd.Types.SessionInitializationMode.Disabled"/>.</summary>
                public const string Disabled = "DISABLED";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.RouterBgpPeerBfd.Types.SessionInitializationMode.Passive"/>.</summary>
                public const string Passive = "PASSIVE";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.RouterInterface"/> message.</summary>
        public static class RouterInterface
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.RouterInterface.Types.ManagementType"/> enum.</summary>
            public static class ManagementType
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.RouterInterface.Types.ManagementType.UndefinedManagementType"/>.</summary>
                public const string UndefinedManagementType = "UNDEFINED_MANAGEMENT_TYPE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.RouterInterface.Types.ManagementType.ManagedByAttachment"/>.</summary>
                public const string ManagedByAttachment = "MANAGED_BY_ATTACHMENT";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.RouterInterface.Types.ManagementType.ManagedByUser"/>.</summary>
                public const string ManagedByUser = "MANAGED_BY_USER";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.RouterNat"/> message.</summary>
        public static class RouterNat
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.RouterNat.Types.NatIpAllocateOption"/> enum.</summary>
            public static class NatIpAllocateOption
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.RouterNat.Types.NatIpAllocateOption.UndefinedNatIpAllocateOption"/>.</summary>
                public const string UndefinedNatIpAllocateOption = "UNDEFINED_NAT_IP_ALLOCATE_OPTION";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.RouterNat.Types.NatIpAllocateOption.AutoOnly"/>.</summary>
                public const string AutoOnly = "AUTO_ONLY";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.RouterNat.Types.NatIpAllocateOption.ManualOnly"/>.</summary>
                public const string ManualOnly = "MANUAL_ONLY";
            }

            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.RouterNat.Types.SourceSubnetworkIpRangesToNat"/> enum.</summary>
            public static class SourceSubnetworkIpRangesToNat
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.RouterNat.Types.SourceSubnetworkIpRangesToNat.UndefinedSourceSubnetworkIpRangesToNat"/>.</summary>
                public const string UndefinedSourceSubnetworkIpRangesToNat = "UNDEFINED_SOURCE_SUBNETWORK_IP_RANGES_TO_NAT";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.RouterNat.Types.SourceSubnetworkIpRangesToNat.AllSubnetworksAllIpRanges"/>.</summary>
                public const string AllSubnetworksAllIpRanges = "ALL_SUBNETWORKS_ALL_IP_RANGES";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.RouterNat.Types.SourceSubnetworkIpRangesToNat.AllSubnetworksAllPrimaryIpRanges"/>.</summary>
                public const string AllSubnetworksAllPrimaryIpRanges = "ALL_SUBNETWORKS_ALL_PRIMARY_IP_RANGES";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.RouterNat.Types.SourceSubnetworkIpRangesToNat.ListOfSubnetworks"/>.</summary>
                public const string ListOfSubnetworks = "LIST_OF_SUBNETWORKS";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.RouterNatLogConfig"/> message.</summary>
        public static class RouterNatLogConfig
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.RouterNatLogConfig.Types.Filter"/> enum.</summary>
            public static class Filter
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.RouterNatLogConfig.Types.Filter.UndefinedFilter"/>.</summary>
                public const string UndefinedFilter = "UNDEFINED_FILTER";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.RouterNatLogConfig.Types.Filter.All"/>.</summary>
                public const string All = "ALL";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.RouterNatLogConfig.Types.Filter.ErrorsOnly"/>.</summary>
                public const string ErrorsOnly = "ERRORS_ONLY";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.RouterNatLogConfig.Types.Filter.TranslationsOnly"/>.</summary>
                public const string TranslationsOnly = "TRANSLATIONS_ONLY";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.RouterNatSubnetworkToNat"/> message.</summary>
        public static class RouterNatSubnetworkToNat
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.RouterNatSubnetworkToNat.Types.SourceIpRangesToNat"/> enum.</summary>
            public static class SourceIpRangesToNat
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.RouterNatSubnetworkToNat.Types.SourceIpRangesToNat.UndefinedSourceIpRangesToNat"/>.</summary>
                public const string UndefinedSourceIpRangesToNat = "UNDEFINED_SOURCE_IP_RANGES_TO_NAT";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.RouterNatSubnetworkToNat.Types.SourceIpRangesToNat.AllIpRanges"/>.</summary>
                public const string AllIpRanges = "ALL_IP_RANGES";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.RouterNatSubnetworkToNat.Types.SourceIpRangesToNat.ListOfSecondaryIpRanges"/>.</summary>
                public const string ListOfSecondaryIpRanges = "LIST_OF_SECONDARY_IP_RANGES";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.RouterNatSubnetworkToNat.Types.SourceIpRangesToNat.PrimaryIpRange"/>.</summary>
                public const string PrimaryIpRange = "PRIMARY_IP_RANGE";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.RouterStatusBgpPeerStatus"/> message.</summary>
        public static class RouterStatusBgpPeerStatus
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.RouterStatusBgpPeerStatus.Types.Status"/> enum.</summary>
            public static class Status
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.RouterStatusBgpPeerStatus.Types.Status.UndefinedStatus"/>.</summary>
                public const string UndefinedStatus = "UNDEFINED_STATUS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.RouterStatusBgpPeerStatus.Types.Status.Down"/>.</summary>
                public const string Down = "DOWN";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.RouterStatusBgpPeerStatus.Types.Status.Unknown"/>.</summary>
                public const string Unknown = "UNKNOWN";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.RouterStatusBgpPeerStatus.Types.Status.Up"/>.</summary>
                public const string Up = "UP";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.Rule"/> message.</summary>
        public static class Rule
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.Rule.Types.Action"/> enum.</summary>
            public static class Action
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Rule.Types.Action.UndefinedAction"/>.</summary>
                public const string UndefinedAction = "UNDEFINED_ACTION";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Rule.Types.Action.Allow"/>.</summary>
                public const string Allow = "ALLOW";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Rule.Types.Action.AllowWithLog"/>.</summary>
                public const string AllowWithLog = "ALLOW_WITH_LOG";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Rule.Types.Action.Deny"/>.</summary>
                public const string Deny = "DENY";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Rule.Types.Action.DenyWithLog"/>.</summary>
                public const string DenyWithLog = "DENY_WITH_LOG";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Rule.Types.Action.Log"/>.</summary>
                public const string Log = "LOG";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Rule.Types.Action.NoAction"/>.</summary>
                public const string NoAction = "NO_ACTION";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.SSLHealthCheck"/> message.</summary>
        public static class SSLHealthCheck
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.SSLHealthCheck.Types.PortSpecification"/> enum.</summary>
            public static class PortSpecification
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.SSLHealthCheck.Types.PortSpecification.UndefinedPortSpecification"/>.</summary>
                public const string UndefinedPortSpecification = "UNDEFINED_PORT_SPECIFICATION";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.SSLHealthCheck.Types.PortSpecification.UseFixedPort"/>.</summary>
                public const string UseFixedPort = "USE_FIXED_PORT";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.SSLHealthCheck.Types.PortSpecification.UseNamedPort"/>.</summary>
                public const string UseNamedPort = "USE_NAMED_PORT";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.SSLHealthCheck.Types.PortSpecification.UseServingPort"/>.</summary>
                public const string UseServingPort = "USE_SERVING_PORT";
            }

            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.SSLHealthCheck.Types.ProxyHeader"/> enum.</summary>
            public static class ProxyHeader
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.SSLHealthCheck.Types.ProxyHeader.UndefinedProxyHeader"/>.</summary>
                public const string UndefinedProxyHeader = "UNDEFINED_PROXY_HEADER";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.SSLHealthCheck.Types.ProxyHeader.None"/>.</summary>
                public const string None = "NONE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.SSLHealthCheck.Types.ProxyHeader.ProxyV1"/>.</summary>
                public const string ProxyV1 = "PROXY_V1";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.SavedAttachedDisk"/> message.</summary>
        public static class SavedAttachedDisk
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.SavedAttachedDisk.Types.Interface"/> enum.</summary>
            public static class Interface
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.SavedAttachedDisk.Types.Interface.UndefinedInterface"/>.</summary>
                public const string UndefinedInterface = "UNDEFINED_INTERFACE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.SavedAttachedDisk.Types.Interface.Nvme"/>.</summary>
                public const string Nvme = "NVME";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.SavedAttachedDisk.Types.Interface.Scsi"/>.</summary>
                public const string Scsi = "SCSI";
            }

            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.SavedAttachedDisk.Types.Mode"/> enum.</summary>
            public static class Mode
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.SavedAttachedDisk.Types.Mode.UndefinedMode"/>.</summary>
                public const string UndefinedMode = "UNDEFINED_MODE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.SavedAttachedDisk.Types.Mode.ReadOnly"/>.</summary>
                public const string ReadOnly = "READ_ONLY";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.SavedAttachedDisk.Types.Mode.ReadWrite"/>.</summary>
                public const string ReadWrite = "READ_WRITE";
            }

            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.SavedAttachedDisk.Types.StorageBytesStatus"/> enum.</summary>
            public static class StorageBytesStatus
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.SavedAttachedDisk.Types.StorageBytesStatus.UndefinedStorageBytesStatus"/>.</summary>
                public const string UndefinedStorageBytesStatus = "UNDEFINED_STORAGE_BYTES_STATUS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.SavedAttachedDisk.Types.StorageBytesStatus.Updating"/>.</summary>
                public const string Updating = "UPDATING";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.SavedAttachedDisk.Types.StorageBytesStatus.UpToDate"/>.</summary>
                public const string UpToDate = "UP_TO_DATE";
            }

            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.SavedAttachedDisk.Types.Type"/> enum.</summary>
            public static class Type
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.SavedAttachedDisk.Types.Type.UndefinedType"/>.</summary>
                public const string UndefinedType = "UNDEFINED_TYPE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.SavedAttachedDisk.Types.Type.Persistent"/>.</summary>
                public const string Persistent = "PERSISTENT";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.SavedAttachedDisk.Types.Type.Scratch"/>.</summary>
                public const string Scratch = "SCRATCH";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.SavedDisk"/> message.</summary>
        public static class SavedDisk
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.SavedDisk.Types.StorageBytesStatus"/> enum.</summary>
            public static class StorageBytesStatus
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.SavedDisk.Types.StorageBytesStatus.UndefinedStorageBytesStatus"/>.</summary>
                public const string UndefinedStorageBytesStatus = "UNDEFINED_STORAGE_BYTES_STATUS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.SavedDisk.Types.StorageBytesStatus.Updating"/>.</summary>
                public const string Updating = "UPDATING";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.SavedDisk.Types.StorageBytesStatus.UpToDate"/>.</summary>
                public const string UpToDate = "UP_TO_DATE";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.ScalingScheduleStatus"/> message.</summary>
        public static class ScalingScheduleStatus
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.ScalingScheduleStatus.Types.State"/> enum.</summary>
            public static class State
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ScalingScheduleStatus.Types.State.UndefinedState"/>.</summary>
                public const string UndefinedState = "UNDEFINED_STATE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ScalingScheduleStatus.Types.State.Active"/>.</summary>
                public const string Active = "ACTIVE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ScalingScheduleStatus.Types.State.Disabled"/>.</summary>
                public const string Disabled = "DISABLED";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ScalingScheduleStatus.Types.State.Obsolete"/>.</summary>
                public const string Obsolete = "OBSOLETE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ScalingScheduleStatus.Types.State.Ready"/>.</summary>
                public const string Ready = "READY";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.Scheduling"/> message.</summary>
        public static class Scheduling
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.Scheduling.Types.InstanceTerminationAction"/> enum.</summary>
            public static class InstanceTerminationAction
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Scheduling.Types.InstanceTerminationAction.UndefinedInstanceTerminationAction"/>.</summary>
                public const string UndefinedInstanceTerminationAction = "UNDEFINED_INSTANCE_TERMINATION_ACTION";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Scheduling.Types.InstanceTerminationAction.Delete"/>.</summary>
                public const string Delete = "DELETE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Scheduling.Types.InstanceTerminationAction.Unspecified"/>.</summary>
                public const string Unspecified = "INSTANCE_TERMINATION_ACTION_UNSPECIFIED";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Scheduling.Types.InstanceTerminationAction.Stop"/>.</summary>
                public const string Stop = "STOP";
            }

            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.Scheduling.Types.OnHostMaintenance"/> enum.</summary>
            public static class OnHostMaintenance
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Scheduling.Types.OnHostMaintenance.UndefinedOnHostMaintenance"/>.</summary>
                public const string UndefinedOnHostMaintenance = "UNDEFINED_ON_HOST_MAINTENANCE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Scheduling.Types.OnHostMaintenance.Migrate"/>.</summary>
                public const string Migrate = "MIGRATE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Scheduling.Types.OnHostMaintenance.Terminate"/>.</summary>
                public const string Terminate = "TERMINATE";
            }

            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.Scheduling.Types.ProvisioningModel"/> enum.</summary>
            public static class ProvisioningModel
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Scheduling.Types.ProvisioningModel.UndefinedProvisioningModel"/>.</summary>
                public const string UndefinedProvisioningModel = "UNDEFINED_PROVISIONING_MODEL";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Scheduling.Types.ProvisioningModel.Spot"/>.</summary>
                public const string Spot = "SPOT";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Scheduling.Types.ProvisioningModel.Standard"/>.</summary>
                public const string Standard = "STANDARD";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.SchedulingNodeAffinity"/> message.</summary>
        public static class SchedulingNodeAffinity
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.SchedulingNodeAffinity.Types.Operator"/> enum.</summary>
            public static class Operator
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.SchedulingNodeAffinity.Types.Operator.UndefinedOperator"/>.</summary>
                public const string UndefinedOperator = "UNDEFINED_OPERATOR";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.SchedulingNodeAffinity.Types.Operator.In"/>.</summary>
                public const string In = "IN";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.SchedulingNodeAffinity.Types.Operator.NotIn"/>.</summary>
                public const string NotIn = "NOT_IN";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.SchedulingNodeAffinity.Types.Operator.Unspecified"/>.</summary>
                public const string Unspecified = "OPERATOR_UNSPECIFIED";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.SecurityPolicy"/> message.</summary>
        public static class SecurityPolicy
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.SecurityPolicy.Types.Type"/> enum.</summary>
            public static class Type
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.SecurityPolicy.Types.Type.UndefinedType"/>.</summary>
                public const string UndefinedType = "UNDEFINED_TYPE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.SecurityPolicy.Types.Type.CloudArmor"/>.</summary>
                public const string CloudArmor = "CLOUD_ARMOR";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.SecurityPolicy.Types.Type.CloudArmorEdge"/>.</summary>
                public const string CloudArmorEdge = "CLOUD_ARMOR_EDGE";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.SecurityPolicyAdaptiveProtectionConfigLayer7DdosDefenseConfig"/> message.</summary>
        public static class SecurityPolicyAdaptiveProtectionConfigLayer7DdosDefenseConfig
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.SecurityPolicyAdaptiveProtectionConfigLayer7DdosDefenseConfig.Types.RuleVisibility"/> enum.</summary>
            public static class RuleVisibility
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.SecurityPolicyAdaptiveProtectionConfigLayer7DdosDefenseConfig.Types.RuleVisibility.UndefinedRuleVisibility"/>.</summary>
                public const string UndefinedRuleVisibility = "UNDEFINED_RULE_VISIBILITY";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.SecurityPolicyAdaptiveProtectionConfigLayer7DdosDefenseConfig.Types.RuleVisibility.Premium"/>.</summary>
                public const string Premium = "PREMIUM";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.SecurityPolicyAdaptiveProtectionConfigLayer7DdosDefenseConfig.Types.RuleVisibility.Standard"/>.</summary>
                public const string Standard = "STANDARD";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.SecurityPolicyAdvancedOptionsConfig"/> message.</summary>
        public static class SecurityPolicyAdvancedOptionsConfig
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.SecurityPolicyAdvancedOptionsConfig.Types.JsonParsing"/> enum.</summary>
            public static class JsonParsing
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.SecurityPolicyAdvancedOptionsConfig.Types.JsonParsing.UndefinedJsonParsing"/>.</summary>
                public const string UndefinedJsonParsing = "UNDEFINED_JSON_PARSING";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.SecurityPolicyAdvancedOptionsConfig.Types.JsonParsing.Disabled"/>.</summary>
                public const string Disabled = "DISABLED";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.SecurityPolicyAdvancedOptionsConfig.Types.JsonParsing.Standard"/>.</summary>
                public const string Standard = "STANDARD";
            }

            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.SecurityPolicyAdvancedOptionsConfig.Types.LogLevel"/> enum.</summary>
            public static class LogLevel
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.SecurityPolicyAdvancedOptionsConfig.Types.LogLevel.UndefinedLogLevel"/>.</summary>
                public const string UndefinedLogLevel = "UNDEFINED_LOG_LEVEL";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.SecurityPolicyAdvancedOptionsConfig.Types.LogLevel.Normal"/>.</summary>
                public const string Normal = "NORMAL";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.SecurityPolicyAdvancedOptionsConfig.Types.LogLevel.Verbose"/>.</summary>
                public const string Verbose = "VERBOSE";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.SecurityPolicyRuleMatcher"/> message.</summary>
        public static class SecurityPolicyRuleMatcher
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.SecurityPolicyRuleMatcher.Types.VersionedExpr"/> enum.</summary>
            public static class VersionedExpr
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.SecurityPolicyRuleMatcher.Types.VersionedExpr.UndefinedVersionedExpr"/>.</summary>
                public const string UndefinedVersionedExpr = "UNDEFINED_VERSIONED_EXPR";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.SecurityPolicyRuleMatcher.Types.VersionedExpr.SrcIpsV1"/>.</summary>
                public const string SrcIpsV1 = "SRC_IPS_V1";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.SecurityPolicyRuleRateLimitOptions"/> message.</summary>
        public static class SecurityPolicyRuleRateLimitOptions
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.SecurityPolicyRuleRateLimitOptions.Types.EnforceOnKey"/> enum.</summary>
            public static class EnforceOnKey
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.SecurityPolicyRuleRateLimitOptions.Types.EnforceOnKey.UndefinedEnforceOnKey"/>.</summary>
                public const string UndefinedEnforceOnKey = "UNDEFINED_ENFORCE_ON_KEY";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.SecurityPolicyRuleRateLimitOptions.Types.EnforceOnKey.All"/>.</summary>
                public const string All = "ALL";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.SecurityPolicyRuleRateLimitOptions.Types.EnforceOnKey.HttpCookie"/>.</summary>
                public const string HttpCookie = "HTTP_COOKIE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.SecurityPolicyRuleRateLimitOptions.Types.EnforceOnKey.HttpHeader"/>.</summary>
                public const string HttpHeader = "HTTP_HEADER";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.SecurityPolicyRuleRateLimitOptions.Types.EnforceOnKey.Ip"/>.</summary>
                public const string Ip = "IP";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.SecurityPolicyRuleRateLimitOptions.Types.EnforceOnKey.XffIp"/>.</summary>
                public const string XffIp = "XFF_IP";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.SecurityPolicyRuleRedirectOptions"/> message.</summary>
        public static class SecurityPolicyRuleRedirectOptions
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.SecurityPolicyRuleRedirectOptions.Types.Type"/> enum.</summary>
            public static class Type
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.SecurityPolicyRuleRedirectOptions.Types.Type.UndefinedType"/>.</summary>
                public const string UndefinedType = "UNDEFINED_TYPE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.SecurityPolicyRuleRedirectOptions.Types.Type.External302"/>.</summary>
                public const string External302 = "EXTERNAL_302";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.SecurityPolicyRuleRedirectOptions.Types.Type.GoogleRecaptcha"/>.</summary>
                public const string GoogleRecaptcha = "GOOGLE_RECAPTCHA";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.ServerBinding"/> message.</summary>
        public static class ServerBinding
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.ServerBinding.Types.Type"/> enum.</summary>
            public static class Type
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ServerBinding.Types.Type.UndefinedType"/>.</summary>
                public const string UndefinedType = "UNDEFINED_TYPE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ServerBinding.Types.Type.RestartNodeOnAnyServer"/>.</summary>
                public const string RestartNodeOnAnyServer = "RESTART_NODE_ON_ANY_SERVER";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ServerBinding.Types.Type.RestartNodeOnMinimalServers"/>.</summary>
                public const string RestartNodeOnMinimalServers = "RESTART_NODE_ON_MINIMAL_SERVERS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ServerBinding.Types.Type.ServerBindingTypeUnspecified"/>.</summary>
                public const string ServerBindingTypeUnspecified = "SERVER_BINDING_TYPE_UNSPECIFIED";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.ServiceAttachment"/> message.</summary>
        public static class ServiceAttachment
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.ServiceAttachment.Types.ConnectionPreference"/> enum.</summary>
            public static class ConnectionPreference
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ServiceAttachment.Types.ConnectionPreference.UndefinedConnectionPreference"/>.</summary>
                public const string UndefinedConnectionPreference = "UNDEFINED_CONNECTION_PREFERENCE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ServiceAttachment.Types.ConnectionPreference.AcceptAutomatic"/>.</summary>
                public const string AcceptAutomatic = "ACCEPT_AUTOMATIC";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ServiceAttachment.Types.ConnectionPreference.AcceptManual"/>.</summary>
                public const string AcceptManual = "ACCEPT_MANUAL";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ServiceAttachment.Types.ConnectionPreference.Unspecified"/>.</summary>
                public const string Unspecified = "CONNECTION_PREFERENCE_UNSPECIFIED";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.ServiceAttachmentConnectedEndpoint"/> message.</summary>
        public static class ServiceAttachmentConnectedEndpoint
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.ServiceAttachmentConnectedEndpoint.Types.Status"/> enum.</summary>
            public static class Status
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ServiceAttachmentConnectedEndpoint.Types.Status.UndefinedStatus"/>.</summary>
                public const string UndefinedStatus = "UNDEFINED_STATUS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ServiceAttachmentConnectedEndpoint.Types.Status.Accepted"/>.</summary>
                public const string Accepted = "ACCEPTED";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ServiceAttachmentConnectedEndpoint.Types.Status.Closed"/>.</summary>
                public const string Closed = "CLOSED";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ServiceAttachmentConnectedEndpoint.Types.Status.Pending"/>.</summary>
                public const string Pending = "PENDING";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ServiceAttachmentConnectedEndpoint.Types.Status.Rejected"/>.</summary>
                public const string Rejected = "REJECTED";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ServiceAttachmentConnectedEndpoint.Types.Status.Unspecified"/>.</summary>
                public const string Unspecified = "STATUS_UNSPECIFIED";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.ShareSettings"/> message.</summary>
        public static class ShareSettings
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.ShareSettings.Types.ShareType"/> enum.</summary>
            public static class ShareType
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ShareSettings.Types.ShareType.UndefinedShareType"/>.</summary>
                public const string UndefinedShareType = "UNDEFINED_SHARE_TYPE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ShareSettings.Types.ShareType.Local"/>.</summary>
                public const string Local = "LOCAL";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ShareSettings.Types.ShareType.Unspecified"/>.</summary>
                public const string Unspecified = "SHARE_TYPE_UNSPECIFIED";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.ShareSettings.Types.ShareType.SpecificProjects"/>.</summary>
                public const string SpecificProjects = "SPECIFIC_PROJECTS";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.Snapshot"/> message.</summary>
        public static class Snapshot
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.Snapshot.Types.Status"/> enum.</summary>
            public static class Status
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Snapshot.Types.Status.UndefinedStatus"/>.</summary>
                public const string UndefinedStatus = "UNDEFINED_STATUS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Snapshot.Types.Status.Creating"/>.</summary>
                public const string Creating = "CREATING";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Snapshot.Types.Status.Deleting"/>.</summary>
                public const string Deleting = "DELETING";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Snapshot.Types.Status.Failed"/>.</summary>
                public const string Failed = "FAILED";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Snapshot.Types.Status.Ready"/>.</summary>
                public const string Ready = "READY";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Snapshot.Types.Status.Uploading"/>.</summary>
                public const string Uploading = "UPLOADING";
            }

            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.Snapshot.Types.StorageBytesStatus"/> enum.</summary>
            public static class StorageBytesStatus
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Snapshot.Types.StorageBytesStatus.UndefinedStorageBytesStatus"/>.</summary>
                public const string UndefinedStorageBytesStatus = "UNDEFINED_STORAGE_BYTES_STATUS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Snapshot.Types.StorageBytesStatus.Updating"/>.</summary>
                public const string Updating = "UPDATING";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Snapshot.Types.StorageBytesStatus.UpToDate"/>.</summary>
                public const string UpToDate = "UP_TO_DATE";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.SslCertificate"/> message.</summary>
        public static class SslCertificate
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.SslCertificate.Types.Type"/> enum.</summary>
            public static class Type
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.SslCertificate.Types.Type.UndefinedType"/>.</summary>
                public const string UndefinedType = "UNDEFINED_TYPE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.SslCertificate.Types.Type.Managed"/>.</summary>
                public const string Managed = "MANAGED";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.SslCertificate.Types.Type.SelfManaged"/>.</summary>
                public const string SelfManaged = "SELF_MANAGED";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.SslCertificate.Types.Type.Unspecified"/>.</summary>
                public const string Unspecified = "TYPE_UNSPECIFIED";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.SslCertificateManagedSslCertificate"/> message.</summary>
        public static class SslCertificateManagedSslCertificate
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.SslCertificateManagedSslCertificate.Types.Status"/> enum.</summary>
            public static class Status
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.SslCertificateManagedSslCertificate.Types.Status.UndefinedStatus"/>.</summary>
                public const string UndefinedStatus = "UNDEFINED_STATUS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.SslCertificateManagedSslCertificate.Types.Status.Active"/>.</summary>
                public const string Active = "ACTIVE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.SslCertificateManagedSslCertificate.Types.Status.ManagedCertificateStatusUnspecified"/>.</summary>
                public const string ManagedCertificateStatusUnspecified = "MANAGED_CERTIFICATE_STATUS_UNSPECIFIED";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.SslCertificateManagedSslCertificate.Types.Status.Provisioning"/>.</summary>
                public const string Provisioning = "PROVISIONING";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.SslCertificateManagedSslCertificate.Types.Status.ProvisioningFailed"/>.</summary>
                public const string ProvisioningFailed = "PROVISIONING_FAILED";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.SslCertificateManagedSslCertificate.Types.Status.ProvisioningFailedPermanently"/>.</summary>
                public const string ProvisioningFailedPermanently = "PROVISIONING_FAILED_PERMANENTLY";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.SslCertificateManagedSslCertificate.Types.Status.RenewalFailed"/>.</summary>
                public const string RenewalFailed = "RENEWAL_FAILED";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.SslPolicy"/> message.</summary>
        public static class SslPolicy
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.SslPolicy.Types.MinTlsVersion"/> enum.</summary>
            public static class MinTlsVersion
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.SslPolicy.Types.MinTlsVersion.UndefinedMinTlsVersion"/>.</summary>
                public const string UndefinedMinTlsVersion = "UNDEFINED_MIN_TLS_VERSION";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.SslPolicy.Types.MinTlsVersion.Tls10"/>.</summary>
                public const string Tls10 = "TLS_1_0";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.SslPolicy.Types.MinTlsVersion.Tls11"/>.</summary>
                public const string Tls11 = "TLS_1_1";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.SslPolicy.Types.MinTlsVersion.Tls12"/>.</summary>
                public const string Tls12 = "TLS_1_2";
            }

            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.SslPolicy.Types.Profile"/> enum.</summary>
            public static class Profile
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.SslPolicy.Types.Profile.UndefinedProfile"/>.</summary>
                public const string UndefinedProfile = "UNDEFINED_PROFILE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.SslPolicy.Types.Profile.Compatible"/>.</summary>
                public const string Compatible = "COMPATIBLE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.SslPolicy.Types.Profile.Custom"/>.</summary>
                public const string Custom = "CUSTOM";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.SslPolicy.Types.Profile.Modern"/>.</summary>
                public const string Modern = "MODERN";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.SslPolicy.Types.Profile.Restricted"/>.</summary>
                public const string Restricted = "RESTRICTED";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.StatefulPolicyPreservedStateDiskDevice"/> message.</summary>
        public static class StatefulPolicyPreservedStateDiskDevice
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.StatefulPolicyPreservedStateDiskDevice.Types.AutoDelete"/> enum.</summary>
            public static class AutoDelete
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.StatefulPolicyPreservedStateDiskDevice.Types.AutoDelete.UndefinedAutoDelete"/>.</summary>
                public const string UndefinedAutoDelete = "UNDEFINED_AUTO_DELETE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.StatefulPolicyPreservedStateDiskDevice.Types.AutoDelete.Never"/>.</summary>
                public const string Never = "NEVER";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.StatefulPolicyPreservedStateDiskDevice.Types.AutoDelete.OnPermanentInstanceDeletion"/>.</summary>
                public const string OnPermanentInstanceDeletion = "ON_PERMANENT_INSTANCE_DELETION";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.Subnetwork"/> message.</summary>
        public static class Subnetwork
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.Subnetwork.Types.Ipv6AccessType"/> enum.</summary>
            public static class Ipv6AccessType
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Subnetwork.Types.Ipv6AccessType.UndefinedIpv6AccessType"/>.</summary>
                public const string UndefinedIpv6AccessType = "UNDEFINED_IPV6_ACCESS_TYPE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Subnetwork.Types.Ipv6AccessType.External"/>.</summary>
                public const string External = "EXTERNAL";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Subnetwork.Types.Ipv6AccessType.UnspecifiedIpv6AccessType"/>.</summary>
                public const string UnspecifiedIpv6AccessType = "UNSPECIFIED_IPV6_ACCESS_TYPE";
            }

            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.Subnetwork.Types.PrivateIpv6GoogleAccess"/> enum.</summary>
            public static class PrivateIpv6GoogleAccess
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Subnetwork.Types.PrivateIpv6GoogleAccess.UndefinedPrivateIpv6GoogleAccess"/>.</summary>
                public const string UndefinedPrivateIpv6GoogleAccess = "UNDEFINED_PRIVATE_IPV6_GOOGLE_ACCESS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Subnetwork.Types.PrivateIpv6GoogleAccess.DisableGoogleAccess"/>.</summary>
                public const string DisableGoogleAccess = "DISABLE_GOOGLE_ACCESS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Subnetwork.Types.PrivateIpv6GoogleAccess.EnableBidirectionalAccessToGoogle"/>.</summary>
                public const string EnableBidirectionalAccessToGoogle = "ENABLE_BIDIRECTIONAL_ACCESS_TO_GOOGLE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Subnetwork.Types.PrivateIpv6GoogleAccess.EnableOutboundVmAccessToGoogle"/>.</summary>
                public const string EnableOutboundVmAccessToGoogle = "ENABLE_OUTBOUND_VM_ACCESS_TO_GOOGLE";
            }

            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.Subnetwork.Types.Purpose"/> enum.</summary>
            public static class Purpose
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Subnetwork.Types.Purpose.UndefinedPurpose"/>.</summary>
                public const string UndefinedPurpose = "UNDEFINED_PURPOSE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Subnetwork.Types.Purpose.InternalHttpsLoadBalancer"/>.</summary>
                public const string InternalHttpsLoadBalancer = "INTERNAL_HTTPS_LOAD_BALANCER";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Subnetwork.Types.Purpose.Private"/>.</summary>
                public const string Private = "PRIVATE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Subnetwork.Types.Purpose.PrivateRfc1918"/>.</summary>
                public const string PrivateRfc1918 = "PRIVATE_RFC_1918";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Subnetwork.Types.Purpose.PrivateServiceConnect"/>.</summary>
                public const string PrivateServiceConnect = "PRIVATE_SERVICE_CONNECT";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Subnetwork.Types.Purpose.RegionalManagedProxy"/>.</summary>
                public const string RegionalManagedProxy = "REGIONAL_MANAGED_PROXY";
            }

            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.Subnetwork.Types.Role"/> enum.</summary>
            public static class Role
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Subnetwork.Types.Role.UndefinedRole"/>.</summary>
                public const string UndefinedRole = "UNDEFINED_ROLE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Subnetwork.Types.Role.Active"/>.</summary>
                public const string Active = "ACTIVE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Subnetwork.Types.Role.Backup"/>.</summary>
                public const string Backup = "BACKUP";
            }

            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.Subnetwork.Types.StackType"/> enum.</summary>
            public static class StackType
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Subnetwork.Types.StackType.UndefinedStackType"/>.</summary>
                public const string UndefinedStackType = "UNDEFINED_STACK_TYPE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Subnetwork.Types.StackType.Ipv4Ipv6"/>.</summary>
                public const string Ipv4Ipv6 = "IPV4_IPV6";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Subnetwork.Types.StackType.Ipv4Only"/>.</summary>
                public const string Ipv4Only = "IPV4_ONLY";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Subnetwork.Types.StackType.UnspecifiedStackType"/>.</summary>
                public const string UnspecifiedStackType = "UNSPECIFIED_STACK_TYPE";
            }

            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.Subnetwork.Types.State"/> enum.</summary>
            public static class State
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Subnetwork.Types.State.UndefinedState"/>.</summary>
                public const string UndefinedState = "UNDEFINED_STATE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Subnetwork.Types.State.Draining"/>.</summary>
                public const string Draining = "DRAINING";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Subnetwork.Types.State.Ready"/>.</summary>
                public const string Ready = "READY";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.SubnetworkLogConfig"/> message.</summary>
        public static class SubnetworkLogConfig
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.SubnetworkLogConfig.Types.AggregationInterval"/> enum.</summary>
            public static class AggregationInterval
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.SubnetworkLogConfig.Types.AggregationInterval.UndefinedAggregationInterval"/>.</summary>
                public const string UndefinedAggregationInterval = "UNDEFINED_AGGREGATION_INTERVAL";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.SubnetworkLogConfig.Types.AggregationInterval.Interval10Min"/>.</summary>
                public const string Interval10Min = "INTERVAL_10_MIN";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.SubnetworkLogConfig.Types.AggregationInterval.Interval15Min"/>.</summary>
                public const string Interval15Min = "INTERVAL_15_MIN";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.SubnetworkLogConfig.Types.AggregationInterval.Interval1Min"/>.</summary>
                public const string Interval1Min = "INTERVAL_1_MIN";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.SubnetworkLogConfig.Types.AggregationInterval.Interval30Sec"/>.</summary>
                public const string Interval30Sec = "INTERVAL_30_SEC";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.SubnetworkLogConfig.Types.AggregationInterval.Interval5Min"/>.</summary>
                public const string Interval5Min = "INTERVAL_5_MIN";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.SubnetworkLogConfig.Types.AggregationInterval.Interval5Sec"/>.</summary>
                public const string Interval5Sec = "INTERVAL_5_SEC";
            }

            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.SubnetworkLogConfig.Types.Metadata"/> enum.</summary>
            public static class Metadata
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.SubnetworkLogConfig.Types.Metadata.UndefinedMetadata"/>.</summary>
                public const string UndefinedMetadata = "UNDEFINED_METADATA";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.SubnetworkLogConfig.Types.Metadata.CustomMetadata"/>.</summary>
                public const string CustomMetadata = "CUSTOM_METADATA";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.SubnetworkLogConfig.Types.Metadata.ExcludeAllMetadata"/>.</summary>
                public const string ExcludeAllMetadata = "EXCLUDE_ALL_METADATA";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.SubnetworkLogConfig.Types.Metadata.IncludeAllMetadata"/>.</summary>
                public const string IncludeAllMetadata = "INCLUDE_ALL_METADATA";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.Subsetting"/> message.</summary>
        public static class Subsetting
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.Subsetting.Types.Policy"/> enum.</summary>
            public static class Policy
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Subsetting.Types.Policy.UndefinedPolicy"/>.</summary>
                public const string UndefinedPolicy = "UNDEFINED_POLICY";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Subsetting.Types.Policy.ConsistentHashSubsetting"/>.</summary>
                public const string ConsistentHashSubsetting = "CONSISTENT_HASH_SUBSETTING";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Subsetting.Types.Policy.None"/>.</summary>
                public const string None = "NONE";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.TCPHealthCheck"/> message.</summary>
        public static class TCPHealthCheck
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.TCPHealthCheck.Types.PortSpecification"/> enum.</summary>
            public static class PortSpecification
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.TCPHealthCheck.Types.PortSpecification.UndefinedPortSpecification"/>.</summary>
                public const string UndefinedPortSpecification = "UNDEFINED_PORT_SPECIFICATION";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.TCPHealthCheck.Types.PortSpecification.UseFixedPort"/>.</summary>
                public const string UseFixedPort = "USE_FIXED_PORT";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.TCPHealthCheck.Types.PortSpecification.UseNamedPort"/>.</summary>
                public const string UseNamedPort = "USE_NAMED_PORT";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.TCPHealthCheck.Types.PortSpecification.UseServingPort"/>.</summary>
                public const string UseServingPort = "USE_SERVING_PORT";
            }

            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.TCPHealthCheck.Types.ProxyHeader"/> enum.</summary>
            public static class ProxyHeader
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.TCPHealthCheck.Types.ProxyHeader.UndefinedProxyHeader"/>.</summary>
                public const string UndefinedProxyHeader = "UNDEFINED_PROXY_HEADER";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.TCPHealthCheck.Types.ProxyHeader.None"/>.</summary>
                public const string None = "NONE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.TCPHealthCheck.Types.ProxyHeader.ProxyV1"/>.</summary>
                public const string ProxyV1 = "PROXY_V1";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.TargetHttpsProxiesSetQuicOverrideRequest"/> message.</summary>
        public static class TargetHttpsProxiesSetQuicOverrideRequest
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.TargetHttpsProxiesSetQuicOverrideRequest.Types.QuicOverride"/> enum.</summary>
            public static class QuicOverride
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.TargetHttpsProxiesSetQuicOverrideRequest.Types.QuicOverride.UndefinedQuicOverride"/>.</summary>
                public const string UndefinedQuicOverride = "UNDEFINED_QUIC_OVERRIDE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.TargetHttpsProxiesSetQuicOverrideRequest.Types.QuicOverride.Disable"/>.</summary>
                public const string Disable = "DISABLE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.TargetHttpsProxiesSetQuicOverrideRequest.Types.QuicOverride.Enable"/>.</summary>
                public const string Enable = "ENABLE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.TargetHttpsProxiesSetQuicOverrideRequest.Types.QuicOverride.None"/>.</summary>
                public const string None = "NONE";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.TargetHttpsProxy"/> message.</summary>
        public static class TargetHttpsProxy
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.TargetHttpsProxy.Types.QuicOverride"/> enum.</summary>
            public static class QuicOverride
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.TargetHttpsProxy.Types.QuicOverride.UndefinedQuicOverride"/>.</summary>
                public const string UndefinedQuicOverride = "UNDEFINED_QUIC_OVERRIDE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.TargetHttpsProxy.Types.QuicOverride.Disable"/>.</summary>
                public const string Disable = "DISABLE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.TargetHttpsProxy.Types.QuicOverride.Enable"/>.</summary>
                public const string Enable = "ENABLE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.TargetHttpsProxy.Types.QuicOverride.None"/>.</summary>
                public const string None = "NONE";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.TargetInstance"/> message.</summary>
        public static class TargetInstance
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.TargetInstance.Types.NatPolicy"/> enum.</summary>
            public static class NatPolicy
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.TargetInstance.Types.NatPolicy.UndefinedNatPolicy"/>.</summary>
                public const string UndefinedNatPolicy = "UNDEFINED_NAT_POLICY";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.TargetInstance.Types.NatPolicy.NoNat"/>.</summary>
                public const string NoNat = "NO_NAT";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.TargetPool"/> message.</summary>
        public static class TargetPool
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.TargetPool.Types.SessionAffinity"/> enum.</summary>
            public static class SessionAffinity
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.TargetPool.Types.SessionAffinity.UndefinedSessionAffinity"/>.</summary>
                public const string UndefinedSessionAffinity = "UNDEFINED_SESSION_AFFINITY";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.TargetPool.Types.SessionAffinity.ClientIp"/>.</summary>
                public const string ClientIp = "CLIENT_IP";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.TargetPool.Types.SessionAffinity.ClientIpNoDestination"/>.</summary>
                public const string ClientIpNoDestination = "CLIENT_IP_NO_DESTINATION";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.TargetPool.Types.SessionAffinity.ClientIpPortProto"/>.</summary>
                public const string ClientIpPortProto = "CLIENT_IP_PORT_PROTO";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.TargetPool.Types.SessionAffinity.ClientIpProto"/>.</summary>
                public const string ClientIpProto = "CLIENT_IP_PROTO";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.TargetPool.Types.SessionAffinity.GeneratedCookie"/>.</summary>
                public const string GeneratedCookie = "GENERATED_COOKIE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.TargetPool.Types.SessionAffinity.HeaderField"/>.</summary>
                public const string HeaderField = "HEADER_FIELD";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.TargetPool.Types.SessionAffinity.HttpCookie"/>.</summary>
                public const string HttpCookie = "HTTP_COOKIE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.TargetPool.Types.SessionAffinity.None"/>.</summary>
                public const string None = "NONE";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.TargetSslProxiesSetProxyHeaderRequest"/> message.</summary>
        public static class TargetSslProxiesSetProxyHeaderRequest
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.TargetSslProxiesSetProxyHeaderRequest.Types.ProxyHeader"/> enum.</summary>
            public static class ProxyHeader
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.TargetSslProxiesSetProxyHeaderRequest.Types.ProxyHeader.UndefinedProxyHeader"/>.</summary>
                public const string UndefinedProxyHeader = "UNDEFINED_PROXY_HEADER";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.TargetSslProxiesSetProxyHeaderRequest.Types.ProxyHeader.None"/>.</summary>
                public const string None = "NONE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.TargetSslProxiesSetProxyHeaderRequest.Types.ProxyHeader.ProxyV1"/>.</summary>
                public const string ProxyV1 = "PROXY_V1";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.TargetSslProxy"/> message.</summary>
        public static class TargetSslProxy
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.TargetSslProxy.Types.ProxyHeader"/> enum.</summary>
            public static class ProxyHeader
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.TargetSslProxy.Types.ProxyHeader.UndefinedProxyHeader"/>.</summary>
                public const string UndefinedProxyHeader = "UNDEFINED_PROXY_HEADER";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.TargetSslProxy.Types.ProxyHeader.None"/>.</summary>
                public const string None = "NONE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.TargetSslProxy.Types.ProxyHeader.ProxyV1"/>.</summary>
                public const string ProxyV1 = "PROXY_V1";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.TargetTcpProxiesSetProxyHeaderRequest"/> message.</summary>
        public static class TargetTcpProxiesSetProxyHeaderRequest
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.TargetTcpProxiesSetProxyHeaderRequest.Types.ProxyHeader"/> enum.</summary>
            public static class ProxyHeader
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.TargetTcpProxiesSetProxyHeaderRequest.Types.ProxyHeader.UndefinedProxyHeader"/>.</summary>
                public const string UndefinedProxyHeader = "UNDEFINED_PROXY_HEADER";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.TargetTcpProxiesSetProxyHeaderRequest.Types.ProxyHeader.None"/>.</summary>
                public const string None = "NONE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.TargetTcpProxiesSetProxyHeaderRequest.Types.ProxyHeader.ProxyV1"/>.</summary>
                public const string ProxyV1 = "PROXY_V1";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.TargetTcpProxy"/> message.</summary>
        public static class TargetTcpProxy
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.TargetTcpProxy.Types.ProxyHeader"/> enum.</summary>
            public static class ProxyHeader
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.TargetTcpProxy.Types.ProxyHeader.UndefinedProxyHeader"/>.</summary>
                public const string UndefinedProxyHeader = "UNDEFINED_PROXY_HEADER";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.TargetTcpProxy.Types.ProxyHeader.None"/>.</summary>
                public const string None = "NONE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.TargetTcpProxy.Types.ProxyHeader.ProxyV1"/>.</summary>
                public const string ProxyV1 = "PROXY_V1";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.TargetVpnGateway"/> message.</summary>
        public static class TargetVpnGateway
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.TargetVpnGateway.Types.Status"/> enum.</summary>
            public static class Status
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.TargetVpnGateway.Types.Status.UndefinedStatus"/>.</summary>
                public const string UndefinedStatus = "UNDEFINED_STATUS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.TargetVpnGateway.Types.Status.Creating"/>.</summary>
                public const string Creating = "CREATING";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.TargetVpnGateway.Types.Status.Deleting"/>.</summary>
                public const string Deleting = "DELETING";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.TargetVpnGateway.Types.Status.Failed"/>.</summary>
                public const string Failed = "FAILED";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.TargetVpnGateway.Types.Status.Ready"/>.</summary>
                public const string Ready = "READY";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.VpnGateway"/> message.</summary>
        public static class VpnGateway
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.VpnGateway.Types.StackType"/> enum.</summary>
            public static class StackType
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.VpnGateway.Types.StackType.UndefinedStackType"/>.</summary>
                public const string UndefinedStackType = "UNDEFINED_STACK_TYPE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.VpnGateway.Types.StackType.Ipv4Ipv6"/>.</summary>
                public const string Ipv4Ipv6 = "IPV4_IPV6";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.VpnGateway.Types.StackType.Ipv4Only"/>.</summary>
                public const string Ipv4Only = "IPV4_ONLY";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.VpnGatewayStatusHighAvailabilityRequirementState"/> message.</summary>
        public static class VpnGatewayStatusHighAvailabilityRequirementState
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.VpnGatewayStatusHighAvailabilityRequirementState.Types.State"/> enum.</summary>
            public static class State
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.VpnGatewayStatusHighAvailabilityRequirementState.Types.State.UndefinedState"/>.</summary>
                public const string UndefinedState = "UNDEFINED_STATE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.VpnGatewayStatusHighAvailabilityRequirementState.Types.State.ConnectionRedundancyMet"/>.</summary>
                public const string ConnectionRedundancyMet = "CONNECTION_REDUNDANCY_MET";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.VpnGatewayStatusHighAvailabilityRequirementState.Types.State.ConnectionRedundancyNotMet"/>.</summary>
                public const string ConnectionRedundancyNotMet = "CONNECTION_REDUNDANCY_NOT_MET";
            }

            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.VpnGatewayStatusHighAvailabilityRequirementState.Types.UnsatisfiedReason"/> enum.</summary>
            public static class UnsatisfiedReason
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.VpnGatewayStatusHighAvailabilityRequirementState.Types.UnsatisfiedReason.UndefinedUnsatisfiedReason"/>.</summary>
                public const string UndefinedUnsatisfiedReason = "UNDEFINED_UNSATISFIED_REASON";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.VpnGatewayStatusHighAvailabilityRequirementState.Types.UnsatisfiedReason.IncompleteTunnelsCoverage"/>.</summary>
                public const string IncompleteTunnelsCoverage = "INCOMPLETE_TUNNELS_COVERAGE";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.VpnTunnel"/> message.</summary>
        public static class VpnTunnel
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.VpnTunnel.Types.Status"/> enum.</summary>
            public static class Status
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.VpnTunnel.Types.Status.UndefinedStatus"/>.</summary>
                public const string UndefinedStatus = "UNDEFINED_STATUS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.VpnTunnel.Types.Status.AllocatingResources"/>.</summary>
                public const string AllocatingResources = "ALLOCATING_RESOURCES";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.VpnTunnel.Types.Status.AuthorizationError"/>.</summary>
                public const string AuthorizationError = "AUTHORIZATION_ERROR";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.VpnTunnel.Types.Status.Deprovisioning"/>.</summary>
                public const string Deprovisioning = "DEPROVISIONING";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.VpnTunnel.Types.Status.Established"/>.</summary>
                public const string Established = "ESTABLISHED";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.VpnTunnel.Types.Status.Failed"/>.</summary>
                public const string Failed = "FAILED";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.VpnTunnel.Types.Status.FirstHandshake"/>.</summary>
                public const string FirstHandshake = "FIRST_HANDSHAKE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.VpnTunnel.Types.Status.NegotiationFailure"/>.</summary>
                public const string NegotiationFailure = "NEGOTIATION_FAILURE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.VpnTunnel.Types.Status.NetworkError"/>.</summary>
                public const string NetworkError = "NETWORK_ERROR";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.VpnTunnel.Types.Status.NoIncomingPackets"/>.</summary>
                public const string NoIncomingPackets = "NO_INCOMING_PACKETS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.VpnTunnel.Types.Status.Provisioning"/>.</summary>
                public const string Provisioning = "PROVISIONING";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.VpnTunnel.Types.Status.Rejected"/>.</summary>
                public const string Rejected = "REJECTED";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.VpnTunnel.Types.Status.Stopped"/>.</summary>
                public const string Stopped = "STOPPED";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.VpnTunnel.Types.Status.WaitingForFullConfig"/>.</summary>
                public const string WaitingForFullConfig = "WAITING_FOR_FULL_CONFIG";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.Warning"/> message.</summary>
        public static class Warning
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.Warning.Types.Code"/> enum.</summary>
            public static class Code
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Warning.Types.Code.UndefinedCode"/>.</summary>
                public const string UndefinedCode = "UNDEFINED_CODE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Warning.Types.Code.CleanupFailed"/>.</summary>
                public const string CleanupFailed = "CLEANUP_FAILED";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Warning.Types.Code.DeprecatedResourceUsed"/>.</summary>
                public const string DeprecatedResourceUsed = "DEPRECATED_RESOURCE_USED";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Warning.Types.Code.DeprecatedTypeUsed"/>.</summary>
                public const string DeprecatedTypeUsed = "DEPRECATED_TYPE_USED";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Warning.Types.Code.DiskSizeLargerThanImageSize"/>.</summary>
                public const string DiskSizeLargerThanImageSize = "DISK_SIZE_LARGER_THAN_IMAGE_SIZE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Warning.Types.Code.ExperimentalTypeUsed"/>.</summary>
                public const string ExperimentalTypeUsed = "EXPERIMENTAL_TYPE_USED";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Warning.Types.Code.ExternalApiWarning"/>.</summary>
                public const string ExternalApiWarning = "EXTERNAL_API_WARNING";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Warning.Types.Code.FieldValueOverriden"/>.</summary>
                public const string FieldValueOverriden = "FIELD_VALUE_OVERRIDEN";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Warning.Types.Code.InjectedKernelsDeprecated"/>.</summary>
                public const string InjectedKernelsDeprecated = "INJECTED_KERNELS_DEPRECATED";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Warning.Types.Code.LargeDeploymentWarning"/>.</summary>
                public const string LargeDeploymentWarning = "LARGE_DEPLOYMENT_WARNING";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Warning.Types.Code.MissingTypeDependency"/>.</summary>
                public const string MissingTypeDependency = "MISSING_TYPE_DEPENDENCY";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Warning.Types.Code.NextHopAddressNotAssigned"/>.</summary>
                public const string NextHopAddressNotAssigned = "NEXT_HOP_ADDRESS_NOT_ASSIGNED";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Warning.Types.Code.NextHopCannotIpForward"/>.</summary>
                public const string NextHopCannotIpForward = "NEXT_HOP_CANNOT_IP_FORWARD";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Warning.Types.Code.NextHopInstanceNotFound"/>.</summary>
                public const string NextHopInstanceNotFound = "NEXT_HOP_INSTANCE_NOT_FOUND";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Warning.Types.Code.NextHopInstanceNotOnNetwork"/>.</summary>
                public const string NextHopInstanceNotOnNetwork = "NEXT_HOP_INSTANCE_NOT_ON_NETWORK";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Warning.Types.Code.NextHopNotRunning"/>.</summary>
                public const string NextHopNotRunning = "NEXT_HOP_NOT_RUNNING";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Warning.Types.Code.NotCriticalError"/>.</summary>
                public const string NotCriticalError = "NOT_CRITICAL_ERROR";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Warning.Types.Code.NoResultsOnPage"/>.</summary>
                public const string NoResultsOnPage = "NO_RESULTS_ON_PAGE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Warning.Types.Code.PartialSuccess"/>.</summary>
                public const string PartialSuccess = "PARTIAL_SUCCESS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Warning.Types.Code.RequiredTosAgreement"/>.</summary>
                public const string RequiredTosAgreement = "REQUIRED_TOS_AGREEMENT";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Warning.Types.Code.ResourceInUseByOtherResourceWarning"/>.</summary>
                public const string ResourceInUseByOtherResourceWarning = "RESOURCE_IN_USE_BY_OTHER_RESOURCE_WARNING";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Warning.Types.Code.ResourceNotDeleted"/>.</summary>
                public const string ResourceNotDeleted = "RESOURCE_NOT_DELETED";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Warning.Types.Code.SchemaValidationIgnored"/>.</summary>
                public const string SchemaValidationIgnored = "SCHEMA_VALIDATION_IGNORED";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Warning.Types.Code.SingleInstancePropertyTemplate"/>.</summary>
                public const string SingleInstancePropertyTemplate = "SINGLE_INSTANCE_PROPERTY_TEMPLATE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Warning.Types.Code.UndeclaredProperties"/>.</summary>
                public const string UndeclaredProperties = "UNDECLARED_PROPERTIES";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Warning.Types.Code.Unreachable"/>.</summary>
                public const string Unreachable = "UNREACHABLE";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.Warnings"/> message.</summary>
        public static class Warnings
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.Warnings.Types.Code"/> enum.</summary>
            public static class Code
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Warnings.Types.Code.UndefinedCode"/>.</summary>
                public const string UndefinedCode = "UNDEFINED_CODE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Warnings.Types.Code.CleanupFailed"/>.</summary>
                public const string CleanupFailed = "CLEANUP_FAILED";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Warnings.Types.Code.DeprecatedResourceUsed"/>.</summary>
                public const string DeprecatedResourceUsed = "DEPRECATED_RESOURCE_USED";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Warnings.Types.Code.DeprecatedTypeUsed"/>.</summary>
                public const string DeprecatedTypeUsed = "DEPRECATED_TYPE_USED";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Warnings.Types.Code.DiskSizeLargerThanImageSize"/>.</summary>
                public const string DiskSizeLargerThanImageSize = "DISK_SIZE_LARGER_THAN_IMAGE_SIZE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Warnings.Types.Code.ExperimentalTypeUsed"/>.</summary>
                public const string ExperimentalTypeUsed = "EXPERIMENTAL_TYPE_USED";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Warnings.Types.Code.ExternalApiWarning"/>.</summary>
                public const string ExternalApiWarning = "EXTERNAL_API_WARNING";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Warnings.Types.Code.FieldValueOverriden"/>.</summary>
                public const string FieldValueOverriden = "FIELD_VALUE_OVERRIDEN";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Warnings.Types.Code.InjectedKernelsDeprecated"/>.</summary>
                public const string InjectedKernelsDeprecated = "INJECTED_KERNELS_DEPRECATED";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Warnings.Types.Code.LargeDeploymentWarning"/>.</summary>
                public const string LargeDeploymentWarning = "LARGE_DEPLOYMENT_WARNING";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Warnings.Types.Code.MissingTypeDependency"/>.</summary>
                public const string MissingTypeDependency = "MISSING_TYPE_DEPENDENCY";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Warnings.Types.Code.NextHopAddressNotAssigned"/>.</summary>
                public const string NextHopAddressNotAssigned = "NEXT_HOP_ADDRESS_NOT_ASSIGNED";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Warnings.Types.Code.NextHopCannotIpForward"/>.</summary>
                public const string NextHopCannotIpForward = "NEXT_HOP_CANNOT_IP_FORWARD";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Warnings.Types.Code.NextHopInstanceNotFound"/>.</summary>
                public const string NextHopInstanceNotFound = "NEXT_HOP_INSTANCE_NOT_FOUND";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Warnings.Types.Code.NextHopInstanceNotOnNetwork"/>.</summary>
                public const string NextHopInstanceNotOnNetwork = "NEXT_HOP_INSTANCE_NOT_ON_NETWORK";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Warnings.Types.Code.NextHopNotRunning"/>.</summary>
                public const string NextHopNotRunning = "NEXT_HOP_NOT_RUNNING";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Warnings.Types.Code.NotCriticalError"/>.</summary>
                public const string NotCriticalError = "NOT_CRITICAL_ERROR";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Warnings.Types.Code.NoResultsOnPage"/>.</summary>
                public const string NoResultsOnPage = "NO_RESULTS_ON_PAGE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Warnings.Types.Code.PartialSuccess"/>.</summary>
                public const string PartialSuccess = "PARTIAL_SUCCESS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Warnings.Types.Code.RequiredTosAgreement"/>.</summary>
                public const string RequiredTosAgreement = "REQUIRED_TOS_AGREEMENT";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Warnings.Types.Code.ResourceInUseByOtherResourceWarning"/>.</summary>
                public const string ResourceInUseByOtherResourceWarning = "RESOURCE_IN_USE_BY_OTHER_RESOURCE_WARNING";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Warnings.Types.Code.ResourceNotDeleted"/>.</summary>
                public const string ResourceNotDeleted = "RESOURCE_NOT_DELETED";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Warnings.Types.Code.SchemaValidationIgnored"/>.</summary>
                public const string SchemaValidationIgnored = "SCHEMA_VALIDATION_IGNORED";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Warnings.Types.Code.SingleInstancePropertyTemplate"/>.</summary>
                public const string SingleInstancePropertyTemplate = "SINGLE_INSTANCE_PROPERTY_TEMPLATE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Warnings.Types.Code.UndeclaredProperties"/>.</summary>
                public const string UndeclaredProperties = "UNDECLARED_PROPERTIES";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Warnings.Types.Code.Unreachable"/>.</summary>
                public const string Unreachable = "UNREACHABLE";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.XpnResourceId"/> message.</summary>
        public static class XpnResourceId
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.XpnResourceId.Types.Type"/> enum.</summary>
            public static class Type
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.XpnResourceId.Types.Type.UndefinedType"/>.</summary>
                public const string UndefinedType = "UNDEFINED_TYPE";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.XpnResourceId.Types.Type.Project"/>.</summary>
                public const string Project = "PROJECT";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.XpnResourceId.Types.Type.XpnResourceTypeUnspecified"/>.</summary>
                public const string XpnResourceTypeUnspecified = "XPN_RESOURCE_TYPE_UNSPECIFIED";
            }
        }

        /// <summary>Container class for enums within the <see cref="global::Google.Cloud.Compute.V1.Zone"/> message.</summary>
        public static class Zone
        {
            /// <summary>Constants for wire representations of the <see cref="global::Google.Cloud.Compute.V1.Zone.Types.Status"/> enum.</summary>
            public static class Status
            {
                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Zone.Types.Status.UndefinedStatus"/>.</summary>
                public const string UndefinedStatus = "UNDEFINED_STATUS";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Zone.Types.Status.Down"/>.</summary>
                public const string Down = "DOWN";

                /// <summary>Wire representation of <see cref="global::Google.Cloud.Compute.V1.Zone.Types.Status.Up"/>.</summary>
                public const string Up = "UP";
            }
        }
    }
}
