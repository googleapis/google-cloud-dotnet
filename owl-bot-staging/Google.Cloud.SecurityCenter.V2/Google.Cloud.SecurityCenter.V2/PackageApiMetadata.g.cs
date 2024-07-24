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
using gaxgrpc = Google.Api.Gax.Grpc;
using gpr = Google.Protobuf.Reflection;
using lro = Google.LongRunning;
using proto = Google.Protobuf;
using scg = System.Collections.Generic;

namespace Google.Cloud.SecurityCenter.V2
{
    /// <summary>Static class to provide common access to package-wide API metadata.</summary>
    internal static class PackageApiMetadata
    {
        /// <summary>The <see cref="gaxgrpc::ApiMetadata"/> for services in this package.</summary>
        internal static gaxgrpc::ApiMetadata ApiMetadata { get; } = new gaxgrpc::ApiMetadata("Google.Cloud.SecurityCenter.V2", GetFileDescriptors)
            .WithRequestNumericEnumJsonEncoding(true)
            .WithHttpRuleOverrides(new scg::Dictionary<string, proto::ByteString>
            {
                {
                    "google.longrunning.Operations.CancelOperation",
                    // { "post": "/v2/{name=organizations/*/operations/*}:cancel" }
                    proto::ByteString.FromBase64("Ii4vdjIve25hbWU9b3JnYW5pemF0aW9ucy8qL29wZXJhdGlvbnMvKn06Y2FuY2Vs")
                },
                {
                    "google.longrunning.Operations.DeleteOperation",
                    // { "delete": "/v2/{name=organizations/*/operations/*}" }
                    proto::ByteString.FromBase64("KicvdjIve25hbWU9b3JnYW5pemF0aW9ucy8qL29wZXJhdGlvbnMvKn0=")
                },
                {
                    "google.longrunning.Operations.GetOperation",
                    // { "get": "/v2/{name=organizations/*/operations/*}" }
                    proto::ByteString.FromBase64("EicvdjIve25hbWU9b3JnYW5pemF0aW9ucy8qL29wZXJhdGlvbnMvKn0=")
                },
                {
                    "google.longrunning.Operations.ListOperations",
                    // { "get": "/v2/{name=organizations/*/operations}" }
                    proto::ByteString.FromBase64("EiUvdjIve25hbWU9b3JnYW5pemF0aW9ucy8qL29wZXJhdGlvbnN9")
                },
            });

        private static scg::IEnumerable<gpr::FileDescriptor> GetFileDescriptors()
        {
            yield return AccessReflection.Descriptor;
            yield return ApplicationReflection.Descriptor;
            yield return AttackExposureReflection.Descriptor;
            yield return AttackPathReflection.Descriptor;
            yield return BackupDisasterRecoveryReflection.Descriptor;
            yield return BigqueryExportReflection.Descriptor;
            yield return CloudArmorReflection.Descriptor;
            yield return CloudDlpDataProfileReflection.Descriptor;
            yield return CloudDlpInspectionReflection.Descriptor;
            yield return ComplianceReflection.Descriptor;
            yield return ConnectionReflection.Descriptor;
            yield return ContactDetailsReflection.Descriptor;
            yield return ContainerReflection.Descriptor;
            yield return DatabaseReflection.Descriptor;
            yield return ExfiltrationReflection.Descriptor;
            yield return ExternalSystemReflection.Descriptor;
            yield return FileReflection.Descriptor;
            yield return FindingReflection.Descriptor;
            yield return FolderReflection.Descriptor;
            yield return GroupMembershipReflection.Descriptor;
            yield return IamBindingReflection.Descriptor;
            yield return IndicatorReflection.Descriptor;
            yield return KernelRootkitReflection.Descriptor;
            yield return KubernetesReflection.Descriptor;
            yield return LabelReflection.Descriptor;
            yield return LoadBalancerReflection.Descriptor;
            yield return LogEntryReflection.Descriptor;
            yield return MitreAttackReflection.Descriptor;
            yield return MuteConfigReflection.Descriptor;
            yield return NotebookReflection.Descriptor;
            yield return NotificationConfigReflection.Descriptor;
            yield return NotificationMessageReflection.Descriptor;
            yield return OrgPolicyReflection.Descriptor;
            yield return ProcessReflection.Descriptor;
            yield return ResourceReflection.Descriptor;
            yield return ResourceValueConfigReflection.Descriptor;
            yield return SecurityMarksReflection.Descriptor;
            yield return SecurityPostureReflection.Descriptor;
            yield return SecuritycenterServiceReflection.Descriptor;
            yield return SimulationReflection.Descriptor;
            yield return SourceReflection.Descriptor;
            yield return ToxicCombinationReflection.Descriptor;
            yield return ValuedResourceReflection.Descriptor;
            yield return VulnerabilityReflection.Descriptor;
            yield return lro::OperationsReflection.Descriptor;
        }
    }
}
