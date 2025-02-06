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
using gax = Google.Api.Gax;
using lro = Google.LongRunning;

namespace Google.Cloud.Compute.V1
{
    public partial class DeleteAddressRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class InsertAddressRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class MoveAddressRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class SetLabelsAddressRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class DeleteAutoscalerRequest
    {
        internal void PopulatePollRequestFields(GetZoneOperationRequest pollRequest)
        {
            pollRequest.Zone = Zone;
            pollRequest.Project = Project;
        }
    }

    public partial class InsertAutoscalerRequest
    {
        internal void PopulatePollRequestFields(GetZoneOperationRequest pollRequest)
        {
            pollRequest.Zone = Zone;
            pollRequest.Project = Project;
        }
    }

    public partial class PatchAutoscalerRequest
    {
        internal void PopulatePollRequestFields(GetZoneOperationRequest pollRequest)
        {
            pollRequest.Zone = Zone;
            pollRequest.Project = Project;
        }
    }

    public partial class UpdateAutoscalerRequest
    {
        internal void PopulatePollRequestFields(GetZoneOperationRequest pollRequest)
        {
            pollRequest.Zone = Zone;
            pollRequest.Project = Project;
        }
    }

    public partial class AddSignedUrlKeyBackendBucketRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class DeleteBackendBucketRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class DeleteSignedUrlKeyBackendBucketRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class InsertBackendBucketRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class PatchBackendBucketRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class SetEdgeSecurityPolicyBackendBucketRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class UpdateBackendBucketRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class AddSignedUrlKeyBackendServiceRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class DeleteBackendServiceRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class DeleteSignedUrlKeyBackendServiceRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class InsertBackendServiceRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class PatchBackendServiceRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class SetEdgeSecurityPolicyBackendServiceRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class SetSecurityPolicyBackendServiceRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class UpdateBackendServiceRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class AddResourcePoliciesDiskRequest
    {
        internal void PopulatePollRequestFields(GetZoneOperationRequest pollRequest)
        {
            pollRequest.Zone = Zone;
            pollRequest.Project = Project;
        }
    }

    public partial class BulkInsertDiskRequest
    {
        internal void PopulatePollRequestFields(GetZoneOperationRequest pollRequest)
        {
            pollRequest.Zone = Zone;
            pollRequest.Project = Project;
        }
    }

    public partial class CreateSnapshotDiskRequest
    {
        internal void PopulatePollRequestFields(GetZoneOperationRequest pollRequest)
        {
            pollRequest.Zone = Zone;
            pollRequest.Project = Project;
        }
    }

    public partial class DeleteDiskRequest
    {
        internal void PopulatePollRequestFields(GetZoneOperationRequest pollRequest)
        {
            pollRequest.Zone = Zone;
            pollRequest.Project = Project;
        }
    }

    public partial class InsertDiskRequest
    {
        internal void PopulatePollRequestFields(GetZoneOperationRequest pollRequest)
        {
            pollRequest.Zone = Zone;
            pollRequest.Project = Project;
        }
    }

    public partial class RemoveResourcePoliciesDiskRequest
    {
        internal void PopulatePollRequestFields(GetZoneOperationRequest pollRequest)
        {
            pollRequest.Zone = Zone;
            pollRequest.Project = Project;
        }
    }

    public partial class ResizeDiskRequest
    {
        internal void PopulatePollRequestFields(GetZoneOperationRequest pollRequest)
        {
            pollRequest.Zone = Zone;
            pollRequest.Project = Project;
        }
    }

    public partial class SetLabelsDiskRequest
    {
        internal void PopulatePollRequestFields(GetZoneOperationRequest pollRequest)
        {
            pollRequest.Zone = Zone;
            pollRequest.Project = Project;
        }
    }

    public partial class StartAsyncReplicationDiskRequest
    {
        internal void PopulatePollRequestFields(GetZoneOperationRequest pollRequest)
        {
            pollRequest.Zone = Zone;
            pollRequest.Project = Project;
        }
    }

    public partial class StopAsyncReplicationDiskRequest
    {
        internal void PopulatePollRequestFields(GetZoneOperationRequest pollRequest)
        {
            pollRequest.Zone = Zone;
            pollRequest.Project = Project;
        }
    }

    public partial class StopGroupAsyncReplicationDiskRequest
    {
        internal void PopulatePollRequestFields(GetZoneOperationRequest pollRequest)
        {
            pollRequest.Zone = Zone;
            pollRequest.Project = Project;
        }
    }

    public partial class UpdateDiskRequest
    {
        internal void PopulatePollRequestFields(GetZoneOperationRequest pollRequest)
        {
            pollRequest.Zone = Zone;
            pollRequest.Project = Project;
        }
    }

    public partial class DeleteExternalVpnGatewayRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class InsertExternalVpnGatewayRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class SetLabelsExternalVpnGatewayRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class AddAssociationFirewallPolicyRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOrganizationOperationRequest pollRequest)
        {
        }
    }

    public partial class AddRuleFirewallPolicyRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOrganizationOperationRequest pollRequest)
        {
        }
    }

    public partial class CloneRulesFirewallPolicyRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOrganizationOperationRequest pollRequest)
        {
        }
    }

    public partial class DeleteFirewallPolicyRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOrganizationOperationRequest pollRequest)
        {
        }
    }

    public partial class InsertFirewallPolicyRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOrganizationOperationRequest pollRequest) =>
            pollRequest.ParentId = ParentId;
    }

    public partial class MoveFirewallPolicyRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOrganizationOperationRequest pollRequest) =>
            pollRequest.ParentId = ParentId;
    }

    public partial class PatchFirewallPolicyRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOrganizationOperationRequest pollRequest)
        {
        }
    }

    public partial class PatchRuleFirewallPolicyRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOrganizationOperationRequest pollRequest)
        {
        }
    }

    public partial class RemoveAssociationFirewallPolicyRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOrganizationOperationRequest pollRequest)
        {
        }
    }

    public partial class RemoveRuleFirewallPolicyRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOrganizationOperationRequest pollRequest)
        {
        }
    }

    public partial class DeleteFirewallRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class InsertFirewallRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class PatchFirewallRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class UpdateFirewallRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class DeleteForwardingRuleRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class InsertForwardingRuleRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class PatchForwardingRuleRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class SetLabelsForwardingRuleRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class SetTargetForwardingRuleRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class DeleteGlobalAddressRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class InsertGlobalAddressRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class MoveGlobalAddressRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class SetLabelsGlobalAddressRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class DeleteGlobalForwardingRuleRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class InsertGlobalForwardingRuleRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class PatchGlobalForwardingRuleRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class SetLabelsGlobalForwardingRuleRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class SetTargetGlobalForwardingRuleRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class AttachNetworkEndpointsGlobalNetworkEndpointGroupRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class DeleteGlobalNetworkEndpointGroupRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class DetachNetworkEndpointsGlobalNetworkEndpointGroupRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class InsertGlobalNetworkEndpointGroupRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class DeleteGlobalPublicDelegatedPrefixeRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class InsertGlobalPublicDelegatedPrefixeRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class PatchGlobalPublicDelegatedPrefixeRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class DeleteHealthCheckRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class InsertHealthCheckRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class PatchHealthCheckRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class UpdateHealthCheckRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class DeleteImageRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class DeprecateImageRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class InsertImageRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class PatchImageRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class SetLabelsImageRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class CancelInstanceGroupManagerResizeRequestRequest
    {
        internal void PopulatePollRequestFields(GetZoneOperationRequest pollRequest)
        {
            pollRequest.Zone = Zone;
            pollRequest.Project = Project;
        }
    }

    public partial class DeleteInstanceGroupManagerResizeRequestRequest
    {
        internal void PopulatePollRequestFields(GetZoneOperationRequest pollRequest)
        {
            pollRequest.Zone = Zone;
            pollRequest.Project = Project;
        }
    }

    public partial class InsertInstanceGroupManagerResizeRequestRequest
    {
        internal void PopulatePollRequestFields(GetZoneOperationRequest pollRequest)
        {
            pollRequest.Zone = Zone;
            pollRequest.Project = Project;
        }
    }

    public partial class AbandonInstancesInstanceGroupManagerRequest
    {
        internal void PopulatePollRequestFields(GetZoneOperationRequest pollRequest)
        {
            pollRequest.Zone = Zone;
            pollRequest.Project = Project;
        }
    }

    public partial class ApplyUpdatesToInstancesInstanceGroupManagerRequest
    {
        internal void PopulatePollRequestFields(GetZoneOperationRequest pollRequest)
        {
            pollRequest.Zone = Zone;
            pollRequest.Project = Project;
        }
    }

    public partial class CreateInstancesInstanceGroupManagerRequest
    {
        internal void PopulatePollRequestFields(GetZoneOperationRequest pollRequest)
        {
            pollRequest.Zone = Zone;
            pollRequest.Project = Project;
        }
    }

    public partial class DeleteInstanceGroupManagerRequest
    {
        internal void PopulatePollRequestFields(GetZoneOperationRequest pollRequest)
        {
            pollRequest.Zone = Zone;
            pollRequest.Project = Project;
        }
    }

    public partial class DeleteInstancesInstanceGroupManagerRequest
    {
        internal void PopulatePollRequestFields(GetZoneOperationRequest pollRequest)
        {
            pollRequest.Zone = Zone;
            pollRequest.Project = Project;
        }
    }

    public partial class DeletePerInstanceConfigsInstanceGroupManagerRequest
    {
        internal void PopulatePollRequestFields(GetZoneOperationRequest pollRequest)
        {
            pollRequest.Zone = Zone;
            pollRequest.Project = Project;
        }
    }

    public partial class InsertInstanceGroupManagerRequest
    {
        internal void PopulatePollRequestFields(GetZoneOperationRequest pollRequest)
        {
            pollRequest.Zone = Zone;
            pollRequest.Project = Project;
        }
    }

    public partial class PatchInstanceGroupManagerRequest
    {
        internal void PopulatePollRequestFields(GetZoneOperationRequest pollRequest)
        {
            pollRequest.Zone = Zone;
            pollRequest.Project = Project;
        }
    }

    public partial class PatchPerInstanceConfigsInstanceGroupManagerRequest
    {
        internal void PopulatePollRequestFields(GetZoneOperationRequest pollRequest)
        {
            pollRequest.Zone = Zone;
            pollRequest.Project = Project;
        }
    }

    public partial class RecreateInstancesInstanceGroupManagerRequest
    {
        internal void PopulatePollRequestFields(GetZoneOperationRequest pollRequest)
        {
            pollRequest.Zone = Zone;
            pollRequest.Project = Project;
        }
    }

    public partial class ResizeInstanceGroupManagerRequest
    {
        internal void PopulatePollRequestFields(GetZoneOperationRequest pollRequest)
        {
            pollRequest.Zone = Zone;
            pollRequest.Project = Project;
        }
    }

    public partial class ResumeInstancesInstanceGroupManagerRequest
    {
        internal void PopulatePollRequestFields(GetZoneOperationRequest pollRequest)
        {
            pollRequest.Zone = Zone;
            pollRequest.Project = Project;
        }
    }

    public partial class SetInstanceTemplateInstanceGroupManagerRequest
    {
        internal void PopulatePollRequestFields(GetZoneOperationRequest pollRequest)
        {
            pollRequest.Zone = Zone;
            pollRequest.Project = Project;
        }
    }

    public partial class SetTargetPoolsInstanceGroupManagerRequest
    {
        internal void PopulatePollRequestFields(GetZoneOperationRequest pollRequest)
        {
            pollRequest.Zone = Zone;
            pollRequest.Project = Project;
        }
    }

    public partial class StartInstancesInstanceGroupManagerRequest
    {
        internal void PopulatePollRequestFields(GetZoneOperationRequest pollRequest)
        {
            pollRequest.Zone = Zone;
            pollRequest.Project = Project;
        }
    }

    public partial class StopInstancesInstanceGroupManagerRequest
    {
        internal void PopulatePollRequestFields(GetZoneOperationRequest pollRequest)
        {
            pollRequest.Zone = Zone;
            pollRequest.Project = Project;
        }
    }

    public partial class SuspendInstancesInstanceGroupManagerRequest
    {
        internal void PopulatePollRequestFields(GetZoneOperationRequest pollRequest)
        {
            pollRequest.Zone = Zone;
            pollRequest.Project = Project;
        }
    }

    public partial class UpdatePerInstanceConfigsInstanceGroupManagerRequest
    {
        internal void PopulatePollRequestFields(GetZoneOperationRequest pollRequest)
        {
            pollRequest.Zone = Zone;
            pollRequest.Project = Project;
        }
    }

    public partial class AddInstancesInstanceGroupRequest
    {
        internal void PopulatePollRequestFields(GetZoneOperationRequest pollRequest)
        {
            pollRequest.Zone = Zone;
            pollRequest.Project = Project;
        }
    }

    public partial class DeleteInstanceGroupRequest
    {
        internal void PopulatePollRequestFields(GetZoneOperationRequest pollRequest)
        {
            pollRequest.Zone = Zone;
            pollRequest.Project = Project;
        }
    }

    public partial class InsertInstanceGroupRequest
    {
        internal void PopulatePollRequestFields(GetZoneOperationRequest pollRequest)
        {
            pollRequest.Zone = Zone;
            pollRequest.Project = Project;
        }
    }

    public partial class RemoveInstancesInstanceGroupRequest
    {
        internal void PopulatePollRequestFields(GetZoneOperationRequest pollRequest)
        {
            pollRequest.Zone = Zone;
            pollRequest.Project = Project;
        }
    }

    public partial class SetNamedPortsInstanceGroupRequest
    {
        internal void PopulatePollRequestFields(GetZoneOperationRequest pollRequest)
        {
            pollRequest.Zone = Zone;
            pollRequest.Project = Project;
        }
    }

    public partial class PatchInstanceSettingRequest
    {
        internal void PopulatePollRequestFields(GetZoneOperationRequest pollRequest)
        {
            pollRequest.Zone = Zone;
            pollRequest.Project = Project;
        }
    }

    public partial class DeleteInstanceTemplateRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class InsertInstanceTemplateRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class AddAccessConfigInstanceRequest
    {
        internal void PopulatePollRequestFields(GetZoneOperationRequest pollRequest)
        {
            pollRequest.Zone = Zone;
            pollRequest.Project = Project;
        }
    }

    public partial class AddResourcePoliciesInstanceRequest
    {
        internal void PopulatePollRequestFields(GetZoneOperationRequest pollRequest)
        {
            pollRequest.Zone = Zone;
            pollRequest.Project = Project;
        }
    }

    public partial class AttachDiskInstanceRequest
    {
        internal void PopulatePollRequestFields(GetZoneOperationRequest pollRequest)
        {
            pollRequest.Zone = Zone;
            pollRequest.Project = Project;
        }
    }

    public partial class BulkInsertInstanceRequest
    {
        internal void PopulatePollRequestFields(GetZoneOperationRequest pollRequest)
        {
            pollRequest.Zone = Zone;
            pollRequest.Project = Project;
        }
    }

    public partial class DeleteInstanceRequest
    {
        internal void PopulatePollRequestFields(GetZoneOperationRequest pollRequest)
        {
            pollRequest.Zone = Zone;
            pollRequest.Project = Project;
        }
    }

    public partial class DeleteAccessConfigInstanceRequest
    {
        internal void PopulatePollRequestFields(GetZoneOperationRequest pollRequest)
        {
            pollRequest.Zone = Zone;
            pollRequest.Project = Project;
        }
    }

    public partial class DetachDiskInstanceRequest
    {
        internal void PopulatePollRequestFields(GetZoneOperationRequest pollRequest)
        {
            pollRequest.Zone = Zone;
            pollRequest.Project = Project;
        }
    }

    public partial class InsertInstanceRequest
    {
        internal void PopulatePollRequestFields(GetZoneOperationRequest pollRequest)
        {
            pollRequest.Zone = Zone;
            pollRequest.Project = Project;
        }
    }

    public partial class PerformMaintenanceInstanceRequest
    {
        internal void PopulatePollRequestFields(GetZoneOperationRequest pollRequest)
        {
            pollRequest.Zone = Zone;
            pollRequest.Project = Project;
        }
    }

    public partial class RemoveResourcePoliciesInstanceRequest
    {
        internal void PopulatePollRequestFields(GetZoneOperationRequest pollRequest)
        {
            pollRequest.Zone = Zone;
            pollRequest.Project = Project;
        }
    }

    public partial class ResetInstanceRequest
    {
        internal void PopulatePollRequestFields(GetZoneOperationRequest pollRequest)
        {
            pollRequest.Zone = Zone;
            pollRequest.Project = Project;
        }
    }

    public partial class ResumeInstanceRequest
    {
        internal void PopulatePollRequestFields(GetZoneOperationRequest pollRequest)
        {
            pollRequest.Zone = Zone;
            pollRequest.Project = Project;
        }
    }

    public partial class SetDeletionProtectionInstanceRequest
    {
        internal void PopulatePollRequestFields(GetZoneOperationRequest pollRequest)
        {
            pollRequest.Zone = Zone;
            pollRequest.Project = Project;
        }
    }

    public partial class SetDiskAutoDeleteInstanceRequest
    {
        internal void PopulatePollRequestFields(GetZoneOperationRequest pollRequest)
        {
            pollRequest.Zone = Zone;
            pollRequest.Project = Project;
        }
    }

    public partial class SetLabelsInstanceRequest
    {
        internal void PopulatePollRequestFields(GetZoneOperationRequest pollRequest)
        {
            pollRequest.Zone = Zone;
            pollRequest.Project = Project;
        }
    }

    public partial class SetMachineResourcesInstanceRequest
    {
        internal void PopulatePollRequestFields(GetZoneOperationRequest pollRequest)
        {
            pollRequest.Zone = Zone;
            pollRequest.Project = Project;
        }
    }

    public partial class SetMachineTypeInstanceRequest
    {
        internal void PopulatePollRequestFields(GetZoneOperationRequest pollRequest)
        {
            pollRequest.Zone = Zone;
            pollRequest.Project = Project;
        }
    }

    public partial class SetMetadataInstanceRequest
    {
        internal void PopulatePollRequestFields(GetZoneOperationRequest pollRequest)
        {
            pollRequest.Zone = Zone;
            pollRequest.Project = Project;
        }
    }

    public partial class SetMinCpuPlatformInstanceRequest
    {
        internal void PopulatePollRequestFields(GetZoneOperationRequest pollRequest)
        {
            pollRequest.Zone = Zone;
            pollRequest.Project = Project;
        }
    }

    public partial class SetNameInstanceRequest
    {
        internal void PopulatePollRequestFields(GetZoneOperationRequest pollRequest)
        {
            pollRequest.Zone = Zone;
            pollRequest.Project = Project;
        }
    }

    public partial class SetSchedulingInstanceRequest
    {
        internal void PopulatePollRequestFields(GetZoneOperationRequest pollRequest)
        {
            pollRequest.Zone = Zone;
            pollRequest.Project = Project;
        }
    }

    public partial class SetSecurityPolicyInstanceRequest
    {
        internal void PopulatePollRequestFields(GetZoneOperationRequest pollRequest)
        {
            pollRequest.Zone = Zone;
            pollRequest.Project = Project;
        }
    }

    public partial class SetServiceAccountInstanceRequest
    {
        internal void PopulatePollRequestFields(GetZoneOperationRequest pollRequest)
        {
            pollRequest.Zone = Zone;
            pollRequest.Project = Project;
        }
    }

    public partial class SetShieldedInstanceIntegrityPolicyInstanceRequest
    {
        internal void PopulatePollRequestFields(GetZoneOperationRequest pollRequest)
        {
            pollRequest.Zone = Zone;
            pollRequest.Project = Project;
        }
    }

    public partial class SetTagsInstanceRequest
    {
        internal void PopulatePollRequestFields(GetZoneOperationRequest pollRequest)
        {
            pollRequest.Zone = Zone;
            pollRequest.Project = Project;
        }
    }

    public partial class SimulateMaintenanceEventInstanceRequest
    {
        internal void PopulatePollRequestFields(GetZoneOperationRequest pollRequest)
        {
            pollRequest.Zone = Zone;
            pollRequest.Project = Project;
        }
    }

    public partial class StartInstanceRequest
    {
        internal void PopulatePollRequestFields(GetZoneOperationRequest pollRequest)
        {
            pollRequest.Zone = Zone;
            pollRequest.Project = Project;
        }
    }

    public partial class StartWithEncryptionKeyInstanceRequest
    {
        internal void PopulatePollRequestFields(GetZoneOperationRequest pollRequest)
        {
            pollRequest.Zone = Zone;
            pollRequest.Project = Project;
        }
    }

    public partial class StopInstanceRequest
    {
        internal void PopulatePollRequestFields(GetZoneOperationRequest pollRequest)
        {
            pollRequest.Zone = Zone;
            pollRequest.Project = Project;
        }
    }

    public partial class SuspendInstanceRequest
    {
        internal void PopulatePollRequestFields(GetZoneOperationRequest pollRequest)
        {
            pollRequest.Zone = Zone;
            pollRequest.Project = Project;
        }
    }

    public partial class UpdateInstanceRequest
    {
        internal void PopulatePollRequestFields(GetZoneOperationRequest pollRequest)
        {
            pollRequest.Zone = Zone;
            pollRequest.Project = Project;
        }
    }

    public partial class UpdateAccessConfigInstanceRequest
    {
        internal void PopulatePollRequestFields(GetZoneOperationRequest pollRequest)
        {
            pollRequest.Zone = Zone;
            pollRequest.Project = Project;
        }
    }

    public partial class UpdateDisplayDeviceInstanceRequest
    {
        internal void PopulatePollRequestFields(GetZoneOperationRequest pollRequest)
        {
            pollRequest.Zone = Zone;
            pollRequest.Project = Project;
        }
    }

    public partial class UpdateNetworkInterfaceInstanceRequest
    {
        internal void PopulatePollRequestFields(GetZoneOperationRequest pollRequest)
        {
            pollRequest.Zone = Zone;
            pollRequest.Project = Project;
        }
    }

    public partial class UpdateShieldedInstanceConfigInstanceRequest
    {
        internal void PopulatePollRequestFields(GetZoneOperationRequest pollRequest)
        {
            pollRequest.Zone = Zone;
            pollRequest.Project = Project;
        }
    }

    public partial class DeleteInstantSnapshotRequest
    {
        internal void PopulatePollRequestFields(GetZoneOperationRequest pollRequest)
        {
            pollRequest.Zone = Zone;
            pollRequest.Project = Project;
        }
    }

    public partial class InsertInstantSnapshotRequest
    {
        internal void PopulatePollRequestFields(GetZoneOperationRequest pollRequest)
        {
            pollRequest.Zone = Zone;
            pollRequest.Project = Project;
        }
    }

    public partial class SetLabelsInstantSnapshotRequest
    {
        internal void PopulatePollRequestFields(GetZoneOperationRequest pollRequest)
        {
            pollRequest.Zone = Zone;
            pollRequest.Project = Project;
        }
    }

    public partial class DeleteInterconnectAttachmentRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class InsertInterconnectAttachmentRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class PatchInterconnectAttachmentRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class SetLabelsInterconnectAttachmentRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class DeleteInterconnectRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class InsertInterconnectRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class PatchInterconnectRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class SetLabelsInterconnectRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class DeleteLicenseRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class InsertLicenseRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class DeleteMachineImageRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class InsertMachineImageRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class DeleteNetworkAttachmentRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class InsertNetworkAttachmentRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class PatchNetworkAttachmentRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class DeleteNetworkEdgeSecurityServiceRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class InsertNetworkEdgeSecurityServiceRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class PatchNetworkEdgeSecurityServiceRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class AttachNetworkEndpointsNetworkEndpointGroupRequest
    {
        internal void PopulatePollRequestFields(GetZoneOperationRequest pollRequest)
        {
            pollRequest.Zone = Zone;
            pollRequest.Project = Project;
        }
    }

    public partial class DeleteNetworkEndpointGroupRequest
    {
        internal void PopulatePollRequestFields(GetZoneOperationRequest pollRequest)
        {
            pollRequest.Zone = Zone;
            pollRequest.Project = Project;
        }
    }

    public partial class DetachNetworkEndpointsNetworkEndpointGroupRequest
    {
        internal void PopulatePollRequestFields(GetZoneOperationRequest pollRequest)
        {
            pollRequest.Zone = Zone;
            pollRequest.Project = Project;
        }
    }

    public partial class InsertNetworkEndpointGroupRequest
    {
        internal void PopulatePollRequestFields(GetZoneOperationRequest pollRequest)
        {
            pollRequest.Zone = Zone;
            pollRequest.Project = Project;
        }
    }

    public partial class AddAssociationNetworkFirewallPolicyRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class AddRuleNetworkFirewallPolicyRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class CloneRulesNetworkFirewallPolicyRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class DeleteNetworkFirewallPolicyRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class InsertNetworkFirewallPolicyRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class PatchNetworkFirewallPolicyRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class PatchRuleNetworkFirewallPolicyRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class RemoveAssociationNetworkFirewallPolicyRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class RemoveRuleNetworkFirewallPolicyRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class AddPeeringNetworkRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class DeleteNetworkRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class InsertNetworkRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class PatchNetworkRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class RemovePeeringNetworkRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class SwitchToCustomModeNetworkRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class UpdatePeeringNetworkRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class AddNodesNodeGroupRequest
    {
        internal void PopulatePollRequestFields(GetZoneOperationRequest pollRequest)
        {
            pollRequest.Zone = Zone;
            pollRequest.Project = Project;
        }
    }

    public partial class DeleteNodeGroupRequest
    {
        internal void PopulatePollRequestFields(GetZoneOperationRequest pollRequest)
        {
            pollRequest.Zone = Zone;
            pollRequest.Project = Project;
        }
    }

    public partial class DeleteNodesNodeGroupRequest
    {
        internal void PopulatePollRequestFields(GetZoneOperationRequest pollRequest)
        {
            pollRequest.Zone = Zone;
            pollRequest.Project = Project;
        }
    }

    public partial class InsertNodeGroupRequest
    {
        internal void PopulatePollRequestFields(GetZoneOperationRequest pollRequest)
        {
            pollRequest.Zone = Zone;
            pollRequest.Project = Project;
        }
    }

    public partial class PatchNodeGroupRequest
    {
        internal void PopulatePollRequestFields(GetZoneOperationRequest pollRequest)
        {
            pollRequest.Zone = Zone;
            pollRequest.Project = Project;
        }
    }

    public partial class PerformMaintenanceNodeGroupRequest
    {
        internal void PopulatePollRequestFields(GetZoneOperationRequest pollRequest)
        {
            pollRequest.Zone = Zone;
            pollRequest.Project = Project;
        }
    }

    public partial class SetNodeTemplateNodeGroupRequest
    {
        internal void PopulatePollRequestFields(GetZoneOperationRequest pollRequest)
        {
            pollRequest.Zone = Zone;
            pollRequest.Project = Project;
        }
    }

    public partial class SimulateMaintenanceEventNodeGroupRequest
    {
        internal void PopulatePollRequestFields(GetZoneOperationRequest pollRequest)
        {
            pollRequest.Zone = Zone;
            pollRequest.Project = Project;
        }
    }

    public partial class DeleteNodeTemplateRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class InsertNodeTemplateRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class DeletePacketMirroringRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class InsertPacketMirroringRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class PatchPacketMirroringRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class DisableXpnHostProjectRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class DisableXpnResourceProjectRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class EnableXpnHostProjectRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class EnableXpnResourceProjectRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class MoveDiskProjectRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class MoveInstanceProjectRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class SetCloudArmorTierProjectRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class SetCommonInstanceMetadataProjectRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class SetDefaultNetworkTierProjectRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class SetUsageExportBucketProjectRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class AnnouncePublicAdvertisedPrefixeRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class DeletePublicAdvertisedPrefixeRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class InsertPublicAdvertisedPrefixeRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class PatchPublicAdvertisedPrefixeRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class WithdrawPublicAdvertisedPrefixeRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class AnnouncePublicDelegatedPrefixeRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class DeletePublicDelegatedPrefixeRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class InsertPublicDelegatedPrefixeRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class PatchPublicDelegatedPrefixeRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class WithdrawPublicDelegatedPrefixeRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class DeleteRegionAutoscalerRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class InsertRegionAutoscalerRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class PatchRegionAutoscalerRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class UpdateRegionAutoscalerRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class DeleteRegionBackendServiceRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class InsertRegionBackendServiceRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class PatchRegionBackendServiceRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class SetSecurityPolicyRegionBackendServiceRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class UpdateRegionBackendServiceRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class InsertRegionCommitmentRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class UpdateRegionCommitmentRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class AddResourcePoliciesRegionDiskRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class BulkInsertRegionDiskRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class CreateSnapshotRegionDiskRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class DeleteRegionDiskRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class InsertRegionDiskRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class RemoveResourcePoliciesRegionDiskRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class ResizeRegionDiskRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class SetLabelsRegionDiskRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class StartAsyncReplicationRegionDiskRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class StopAsyncReplicationRegionDiskRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class StopGroupAsyncReplicationRegionDiskRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class UpdateRegionDiskRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class DeleteRegionHealthCheckServiceRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class InsertRegionHealthCheckServiceRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class PatchRegionHealthCheckServiceRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class DeleteRegionHealthCheckRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class InsertRegionHealthCheckRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class PatchRegionHealthCheckRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class UpdateRegionHealthCheckRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class AbandonInstancesRegionInstanceGroupManagerRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class ApplyUpdatesToInstancesRegionInstanceGroupManagerRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class CreateInstancesRegionInstanceGroupManagerRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class DeleteRegionInstanceGroupManagerRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class DeleteInstancesRegionInstanceGroupManagerRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class DeletePerInstanceConfigsRegionInstanceGroupManagerRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class InsertRegionInstanceGroupManagerRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class PatchRegionInstanceGroupManagerRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class PatchPerInstanceConfigsRegionInstanceGroupManagerRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class RecreateInstancesRegionInstanceGroupManagerRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class ResizeRegionInstanceGroupManagerRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class ResumeInstancesRegionInstanceGroupManagerRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class SetInstanceTemplateRegionInstanceGroupManagerRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class SetTargetPoolsRegionInstanceGroupManagerRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class StartInstancesRegionInstanceGroupManagerRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class StopInstancesRegionInstanceGroupManagerRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class SuspendInstancesRegionInstanceGroupManagerRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class UpdatePerInstanceConfigsRegionInstanceGroupManagerRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class SetNamedPortsRegionInstanceGroupRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class DeleteRegionInstanceTemplateRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class InsertRegionInstanceTemplateRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class BulkInsertRegionInstanceRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class DeleteRegionInstantSnapshotRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class InsertRegionInstantSnapshotRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class SetLabelsRegionInstantSnapshotRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class AttachNetworkEndpointsRegionNetworkEndpointGroupRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class DeleteRegionNetworkEndpointGroupRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class DetachNetworkEndpointsRegionNetworkEndpointGroupRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class InsertRegionNetworkEndpointGroupRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class AddAssociationRegionNetworkFirewallPolicyRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class AddRuleRegionNetworkFirewallPolicyRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class CloneRulesRegionNetworkFirewallPolicyRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class DeleteRegionNetworkFirewallPolicyRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class InsertRegionNetworkFirewallPolicyRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class PatchRegionNetworkFirewallPolicyRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class PatchRuleRegionNetworkFirewallPolicyRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class RemoveAssociationRegionNetworkFirewallPolicyRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class RemoveRuleRegionNetworkFirewallPolicyRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class DeleteRegionNotificationEndpointRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class InsertRegionNotificationEndpointRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class AddRuleRegionSecurityPolicyRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class DeleteRegionSecurityPolicyRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class InsertRegionSecurityPolicyRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class PatchRegionSecurityPolicyRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class PatchRuleRegionSecurityPolicyRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class RemoveRuleRegionSecurityPolicyRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class SetLabelsRegionSecurityPolicyRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class DeleteRegionSslCertificateRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class InsertRegionSslCertificateRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class DeleteRegionSslPolicyRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class InsertRegionSslPolicyRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class PatchRegionSslPolicyRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class DeleteRegionTargetHttpProxyRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class InsertRegionTargetHttpProxyRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class SetUrlMapRegionTargetHttpProxyRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class DeleteRegionTargetHttpsProxyRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class InsertRegionTargetHttpsProxyRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class PatchRegionTargetHttpsProxyRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class SetSslCertificatesRegionTargetHttpsProxyRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class SetUrlMapRegionTargetHttpsProxyRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class DeleteRegionTargetTcpProxyRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class InsertRegionTargetTcpProxyRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class DeleteRegionUrlMapRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class InsertRegionUrlMapRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class PatchRegionUrlMapRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class UpdateRegionUrlMapRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class DeleteReservationRequest
    {
        internal void PopulatePollRequestFields(GetZoneOperationRequest pollRequest)
        {
            pollRequest.Zone = Zone;
            pollRequest.Project = Project;
        }
    }

    public partial class InsertReservationRequest
    {
        internal void PopulatePollRequestFields(GetZoneOperationRequest pollRequest)
        {
            pollRequest.Zone = Zone;
            pollRequest.Project = Project;
        }
    }

    public partial class ResizeReservationRequest
    {
        internal void PopulatePollRequestFields(GetZoneOperationRequest pollRequest)
        {
            pollRequest.Zone = Zone;
            pollRequest.Project = Project;
        }
    }

    public partial class UpdateReservationRequest
    {
        internal void PopulatePollRequestFields(GetZoneOperationRequest pollRequest)
        {
            pollRequest.Zone = Zone;
            pollRequest.Project = Project;
        }
    }

    public partial class DeleteResourcePolicyRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class InsertResourcePolicyRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class PatchResourcePolicyRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class DeleteRouterRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class InsertRouterRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class PatchRouterRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class UpdateRouterRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class DeleteRouteRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class InsertRouteRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class AddRuleSecurityPolicyRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class DeleteSecurityPolicyRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class InsertSecurityPolicyRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class PatchSecurityPolicyRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class PatchRuleSecurityPolicyRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class RemoveRuleSecurityPolicyRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class SetLabelsSecurityPolicyRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class DeleteServiceAttachmentRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class InsertServiceAttachmentRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class PatchServiceAttachmentRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class PatchSnapshotSettingRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class DeleteSnapshotRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class InsertSnapshotRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class SetLabelsSnapshotRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class DeleteSslCertificateRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class InsertSslCertificateRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class DeleteSslPolicyRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class InsertSslPolicyRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class PatchSslPolicyRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class DeleteStoragePoolRequest
    {
        internal void PopulatePollRequestFields(GetZoneOperationRequest pollRequest)
        {
            pollRequest.Zone = Zone;
            pollRequest.Project = Project;
        }
    }

    public partial class InsertStoragePoolRequest
    {
        internal void PopulatePollRequestFields(GetZoneOperationRequest pollRequest)
        {
            pollRequest.Zone = Zone;
            pollRequest.Project = Project;
        }
    }

    public partial class UpdateStoragePoolRequest
    {
        internal void PopulatePollRequestFields(GetZoneOperationRequest pollRequest)
        {
            pollRequest.Zone = Zone;
            pollRequest.Project = Project;
        }
    }

    public partial class DeleteSubnetworkRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class ExpandIpCidrRangeSubnetworkRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class InsertSubnetworkRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class PatchSubnetworkRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class SetPrivateIpGoogleAccessSubnetworkRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class DeleteTargetGrpcProxyRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class InsertTargetGrpcProxyRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class PatchTargetGrpcProxyRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class DeleteTargetHttpProxyRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class InsertTargetHttpProxyRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class PatchTargetHttpProxyRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class SetUrlMapTargetHttpProxyRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class DeleteTargetHttpsProxyRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class InsertTargetHttpsProxyRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class PatchTargetHttpsProxyRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class SetCertificateMapTargetHttpsProxyRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class SetQuicOverrideTargetHttpsProxyRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class SetSslCertificatesTargetHttpsProxyRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class SetSslPolicyTargetHttpsProxyRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class SetUrlMapTargetHttpsProxyRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class DeleteTargetInstanceRequest
    {
        internal void PopulatePollRequestFields(GetZoneOperationRequest pollRequest)
        {
            pollRequest.Zone = Zone;
            pollRequest.Project = Project;
        }
    }

    public partial class InsertTargetInstanceRequest
    {
        internal void PopulatePollRequestFields(GetZoneOperationRequest pollRequest)
        {
            pollRequest.Zone = Zone;
            pollRequest.Project = Project;
        }
    }

    public partial class SetSecurityPolicyTargetInstanceRequest
    {
        internal void PopulatePollRequestFields(GetZoneOperationRequest pollRequest)
        {
            pollRequest.Zone = Zone;
            pollRequest.Project = Project;
        }
    }

    public partial class AddHealthCheckTargetPoolRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class AddInstanceTargetPoolRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class DeleteTargetPoolRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class InsertTargetPoolRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class RemoveHealthCheckTargetPoolRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class RemoveInstanceTargetPoolRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class SetBackupTargetPoolRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class SetSecurityPolicyTargetPoolRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class DeleteTargetSslProxyRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class InsertTargetSslProxyRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class SetBackendServiceTargetSslProxyRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class SetCertificateMapTargetSslProxyRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class SetProxyHeaderTargetSslProxyRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class SetSslCertificatesTargetSslProxyRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class SetSslPolicyTargetSslProxyRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class DeleteTargetTcpProxyRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class InsertTargetTcpProxyRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class SetBackendServiceTargetTcpProxyRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class SetProxyHeaderTargetTcpProxyRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class DeleteTargetVpnGatewayRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class InsertTargetVpnGatewayRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class SetLabelsTargetVpnGatewayRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class DeleteUrlMapRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class InsertUrlMapRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class InvalidateCacheUrlMapRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class PatchUrlMapRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class UpdateUrlMapRequest
    {
        internal void PopulatePollRequestFields(GetGlobalOperationRequest pollRequest) => pollRequest.Project = Project;
    }

    public partial class DeleteVpnGatewayRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class InsertVpnGatewayRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class SetLabelsVpnGatewayRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class DeleteVpnTunnelRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class InsertVpnTunnelRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class SetLabelsVpnTunnelRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            pollRequest.Region = Region;
            pollRequest.Project = Project;
        }
    }

    public partial class GetGlobalOperationRequest
    {
        private static gax::PathTemplate s_operationNameTemplate = new gax::PathTemplate("operation/{operation}/project/{project}");

        internal static GetGlobalOperationRequest ParseLroRequest(lro::GetOperationRequest request)
        {
            gax::TemplatedResourceName parsedName = s_operationNameTemplate.ParseName(request.Name);
            return new GetGlobalOperationRequest
            {
                Operation = parsedName[0],
                Project = parsedName[1],
            };
        }

        internal static GetGlobalOperationRequest FromInitialResponse(Operation response) =>
            new GetGlobalOperationRequest
            {
                Operation = response.Name,
            };

        internal string ToLroOperationName() => s_operationNameTemplate.Expand(Operation, Project);
    }

    public partial class GetGlobalOrganizationOperationRequest
    {
        private static gax::PathTemplate s_operationNameTemplate = new gax::PathTemplate("operation/{operation}");

        internal static GetGlobalOrganizationOperationRequest ParseLroRequest(lro::GetOperationRequest request)
        {
            gax::TemplatedResourceName parsedName = s_operationNameTemplate.ParseName(request.Name);
            return new GetGlobalOrganizationOperationRequest
            {
                Operation = parsedName[0],
            };
        }

        internal static GetGlobalOrganizationOperationRequest FromInitialResponse(Operation response) =>
            new GetGlobalOrganizationOperationRequest
            {
                Operation = response.Name,
            };

        internal string ToLroOperationName() => s_operationNameTemplate.Expand(Operation);
    }

    public partial class GetRegionOperationRequest
    {
        private static gax::PathTemplate s_operationNameTemplate = new gax::PathTemplate("operation/{operation}/region/{region}/project/{project}");

        internal static GetRegionOperationRequest ParseLroRequest(lro::GetOperationRequest request)
        {
            gax::TemplatedResourceName parsedName = s_operationNameTemplate.ParseName(request.Name);
            return new GetRegionOperationRequest
            {
                Operation = parsedName[0],
                Region = parsedName[1],
                Project = parsedName[2],
            };
        }

        internal static GetRegionOperationRequest FromInitialResponse(Operation response) =>
            new GetRegionOperationRequest
            {
                Operation = response.Name,
            };

        internal string ToLroOperationName() => s_operationNameTemplate.Expand(Operation, Region, Project);
    }

    public partial class GetZoneOperationRequest
    {
        private static gax::PathTemplate s_operationNameTemplate = new gax::PathTemplate("zone/{zone}/operation/{operation}/project/{project}");

        internal static GetZoneOperationRequest ParseLroRequest(lro::GetOperationRequest request)
        {
            gax::TemplatedResourceName parsedName = s_operationNameTemplate.ParseName(request.Name);
            return new GetZoneOperationRequest
            {
                Zone = parsedName[0],
                Operation = parsedName[1],
                Project = parsedName[2],
            };
        }

        internal static GetZoneOperationRequest FromInitialResponse(Operation response) =>
            new GetZoneOperationRequest
            {
                Operation = response.Name,
            };

        internal string ToLroOperationName() => s_operationNameTemplate.Expand(Zone, Operation, Project);
    }
}
