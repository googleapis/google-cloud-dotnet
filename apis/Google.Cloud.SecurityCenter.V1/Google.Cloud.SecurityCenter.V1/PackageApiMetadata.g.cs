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
using gpr = Google.Protobuf.Reflection;
using scg = System.Collections.Generic;

namespace Google.Cloud.SecurityCenter.V1
{
    /// <summary>Static class to provide common access to package-wide API metadata.</summary>
    internal static class PackageApiMetadata
    {
        /// <summary>The <see cref="gaxgrpc::ApiMetadata"/> for services in this package.</summary>
        internal static gaxgrpc::ApiMetadata ApiMetadata { get; } = new gaxgrpc::ApiMetadata("Google.Cloud.SecurityCenter.V1", GetFileDescriptors);

        private static scg::IEnumerable<gpr::FileDescriptor> GetFileDescriptors()
        {
            yield return AccessReflection.Descriptor;
            yield return AssetReflection.Descriptor;
            yield return BigqueryExportReflection.Descriptor;
            yield return ComplianceReflection.Descriptor;
            yield return ConnectionReflection.Descriptor;
            yield return ContactDetailsReflection.Descriptor;
            yield return ContainerReflection.Descriptor;
            yield return ExfiltrationReflection.Descriptor;
            yield return ExternalSystemReflection.Descriptor;
            yield return FileReflection.Descriptor;
            yield return FindingReflection.Descriptor;
            yield return FolderReflection.Descriptor;
            yield return IamBindingReflection.Descriptor;
            yield return IndicatorReflection.Descriptor;
            yield return KubernetesReflection.Descriptor;
            yield return LabelReflection.Descriptor;
            yield return MitreAttackReflection.Descriptor;
            yield return MuteConfigReflection.Descriptor;
            yield return NotificationConfigReflection.Descriptor;
            yield return NotificationMessageReflection.Descriptor;
            yield return OrganizationSettingsReflection.Descriptor;
            yield return ProcessReflection.Descriptor;
            yield return ResourceReflection.Descriptor;
            yield return RunAssetDiscoveryResponseReflection.Descriptor;
            yield return SecurityMarksReflection.Descriptor;
            yield return SecuritycenterServiceReflection.Descriptor;
            yield return SourceReflection.Descriptor;
            yield return VulnerabilityReflection.Descriptor;
        }
    }
}
