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
using lro = Google.LongRunning;
using proto = Google.Protobuf;
using scg = System.Collections.Generic;

namespace Google.Cloud.OsConfig.V1Alpha
{
    /// <summary>Static class to provide common access to package-wide API metadata.</summary>
    internal static class PackageApiMetadata
    {
        /// <summary>The <see cref="gaxgrpc::ApiMetadata"/> for services in this package.</summary>
        internal static gaxgrpc::ApiMetadata ApiMetadata { get; } = new gaxgrpc::ApiMetadata("Google.Cloud.OsConfig.V1Alpha", GetFileDescriptors)
            .WithRequestNumericEnumJsonEncoding(true)
            .WithHttpRuleOverrides(new scg::Dictionary<string, proto::ByteString>
            {
                {
                    "google.longrunning.Operations.CancelOperation",
                    // { "post": "/v1alpha/{name=projects/*/locations/*/osPolicyAssignments/*/operations/*}:cancel", "body": "*" }
                    proto::ByteString.FromBase64("IlAvdjFhbHBoYS97bmFtZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL29zUG9saWN5QXNzaWdubWVudHMvKi9vcGVyYXRpb25zLyp9OmNhbmNlbDoBKg==")
                },
                {
                    "google.longrunning.Operations.GetOperation",
                    // { "get": "/v1alpha/{name=projects/*/locations/*/osPolicyAssignments/*/operations/*}" }
                    proto::ByteString.FromBase64("EkkvdjFhbHBoYS97bmFtZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL29zUG9saWN5QXNzaWdubWVudHMvKi9vcGVyYXRpb25zLyp9")
                },
            });

        private static scg::IEnumerable<gpr::FileDescriptor> GetFileDescriptors()
        {
            yield return ConfigCommonReflection.Descriptor;
            yield return InstanceOsPoliciesComplianceReflection.Descriptor;
            yield return InventoryReflection.Descriptor;
            yield return OsPolicyReflection.Descriptor;
            yield return OsPolicyAssignmentReportsReflection.Descriptor;
            yield return OsPolicyAssignmentsReflection.Descriptor;
            yield return OsconfigCommonReflection.Descriptor;
            yield return OsconfigZonalServiceReflection.Descriptor;
            yield return VulnerabilityReflection.Descriptor;
            yield return lro::OperationsReflection.Descriptor;
        }
    }
}
