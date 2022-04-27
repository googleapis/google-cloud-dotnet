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
using gpr = Google.Protobuf.Reflection;
using scg = System.Collections.Generic;

namespace Google.Cloud.AppEngine.V1
{
    /// <summary>Static class to provide common access to package-wide API metadata.</summary>
    internal static class PackageApiMetadata
    {
        /// <summary>The <see cref="gaxgrpc::ApiMetadata"/> for services in this package.</summary>
        internal static gaxgrpc::ApiMetadata ApiMetadata { get; } = new gaxgrpc::ApiMetadata("Google.Cloud.AppEngine.V1", GetFileDescriptors);

        private static scg::IEnumerable<gpr::FileDescriptor> GetFileDescriptors()
        {
            yield return ApplicationReflection.Descriptor;
            yield return CertificateReflection.Descriptor;
            yield return DomainReflection.Descriptor;
            yield return DomainMappingReflection.Descriptor;
            yield return FirewallReflection.Descriptor;
            yield return InstanceReflection.Descriptor;
            yield return NetworkSettingsReflection.Descriptor;
            yield return ServiceReflection.Descriptor;
            yield return AppYamlReflection.Descriptor;
            yield return DeployReflection.Descriptor;
            yield return VersionReflection.Descriptor;
            yield return AppengineReflection.Descriptor;
            yield return AuditDataReflection.Descriptor;
            yield return DeployedFilesReflection.Descriptor;
            yield return LocationReflection.Descriptor;
            yield return OperationReflection.Descriptor;
        }
    }
}
