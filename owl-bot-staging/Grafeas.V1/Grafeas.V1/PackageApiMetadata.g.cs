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
using gaxgrpc = Google.Api.Gax.Grpc;
using gpr = Google.Protobuf.Reflection;
using scg = System.Collections.Generic;

namespace Grafeas.V1
{
    /// <summary>Static class to provide common access to package-wide API metadata.</summary>
    internal static class PackageApiMetadata
    {
        /// <summary>The <see cref="gaxgrpc::ApiMetadata"/> for services in this package.</summary>
        internal static gaxgrpc::ApiMetadata ApiMetadata { get; } = new gaxgrpc::ApiMetadata("Grafeas.V1", GetFileDescriptors)
            .WithRequestNumericEnumJsonEncoding(true);

        private static scg::IEnumerable<gpr::FileDescriptor> GetFileDescriptors()
        {
            yield return AttestationReflection.Descriptor;
            yield return BuildReflection.Descriptor;
            yield return CommonReflection.Descriptor;
            yield return ComplianceReflection.Descriptor;
            yield return CvssReflection.Descriptor;
            yield return DeploymentReflection.Descriptor;
            yield return DiscoveryReflection.Descriptor;
            yield return DsseAttestationReflection.Descriptor;
            yield return GrafeasReflection.Descriptor;
            yield return ImageReflection.Descriptor;
            yield return IntotoProvenanceReflection.Descriptor;
            yield return IntotoStatementReflection.Descriptor;
            yield return PackageReflection.Descriptor;
            yield return ProvenanceReflection.Descriptor;
            yield return SbomReflection.Descriptor;
            yield return SeverityReflection.Descriptor;
            yield return SlsaProvenanceReflection.Descriptor;
            yield return SlsaProvenanceZeroTwoReflection.Descriptor;
            yield return UpgradeReflection.Descriptor;
            yield return VexReflection.Descriptor;
            yield return VulnerabilityReflection.Descriptor;
        }
    }
}
