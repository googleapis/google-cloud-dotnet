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
using gciv = Google.Cloud.Iam.V1;
using gcl = Google.Cloud.Location;
using gpr = Google.Protobuf.Reflection;
using lro = Google.LongRunning;
using proto = Google.Protobuf;
using scg = System.Collections.Generic;

namespace Google.Cloud.BareMetalSolution.V2
{
    /// <summary>Static class to provide common access to package-wide API metadata.</summary>
    internal static class PackageApiMetadata
    {
        /// <summary>The <see cref="gaxgrpc::ApiMetadata"/> for services in this package.</summary>
        internal static gaxgrpc::ApiMetadata ApiMetadata { get; } = new gaxgrpc::ApiMetadata("Google.Cloud.BareMetalSolution.V2", GetFileDescriptors)
            .WithRequestNumericEnumJsonEncoding(true)
            .WithHttpRuleOverrides(new scg::Dictionary<string, proto::ByteString>
            {
                {
                    "google.cloud.location.Locations.GetLocation",
                    // { "get": "/v2/{name=projects/*/locations/*}" }
                    proto::ByteString.FromBase64("EiEvdjIve25hbWU9cHJvamVjdHMvKi9sb2NhdGlvbnMvKn0=")
                },
                {
                    "google.cloud.location.Locations.ListLocations",
                    // { "get": "/v2/{name=projects/*}/locations" }
                    proto::ByteString.FromBase64("Eh8vdjIve25hbWU9cHJvamVjdHMvKn0vbG9jYXRpb25z")
                },
            });

        private static scg::IEnumerable<gpr::FileDescriptor> GetFileDescriptors()
        {
            yield return BaremetalsolutionReflection.Descriptor;
            yield return CommonReflection.Descriptor;
            yield return InstanceReflection.Descriptor;
            yield return LunReflection.Descriptor;
            yield return NetworkReflection.Descriptor;
            yield return NfsShareReflection.Descriptor;
            yield return OsimageReflection.Descriptor;
            yield return ProvisioningReflection.Descriptor;
            yield return SshKeyReflection.Descriptor;
            yield return VolumeReflection.Descriptor;
            yield return VolumeSnapshotReflection.Descriptor;
            yield return gciv::IamPolicyReflection.Descriptor;
            yield return gciv::OptionsReflection.Descriptor;
            yield return gciv::PolicyReflection.Descriptor;
            yield return gcl::LocationsReflection.Descriptor;
            yield return lro::OperationsReflection.Descriptor;
        }
    }
}
