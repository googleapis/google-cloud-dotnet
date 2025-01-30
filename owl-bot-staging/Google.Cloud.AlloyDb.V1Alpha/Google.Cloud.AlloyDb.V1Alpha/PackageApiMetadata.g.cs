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

namespace Google.Cloud.AlloyDb.V1Alpha
{
    /// <summary>Static class to provide common access to package-wide API metadata.</summary>
    internal static class PackageApiMetadata
    {
        /// <summary>The <see cref="gaxgrpc::ApiMetadata"/> for services in this package.</summary>
        internal static gaxgrpc::ApiMetadata ApiMetadata { get; } = new gaxgrpc::ApiMetadata("Google.Cloud.AlloyDb.V1Alpha", GetFileDescriptors)
            .WithRequestNumericEnumJsonEncoding(true)
            .WithHttpRuleOverrides(new scg::Dictionary<string, proto::ByteString>
            {
                {
                    "google.cloud.location.Locations.GetLocation",
                    // { "get": "/v1alpha/{name=projects/*/locations/*}" }
                    proto::ByteString.FromBase64("EiYvdjFhbHBoYS97bmFtZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qfQ==")
                },
                {
                    "google.cloud.location.Locations.ListLocations",
                    // { "get": "/v1alpha/{name=projects/*}/locations" }
                    proto::ByteString.FromBase64("EiQvdjFhbHBoYS97bmFtZT1wcm9qZWN0cy8qfS9sb2NhdGlvbnM=")
                },
                {
                    "google.longrunning.Operations.CancelOperation",
                    // { "post": "/v1alpha/{name=projects/*/locations/*/operations/*}:cancel", "body": "*" }
                    proto::ByteString.FromBase64("IjovdjFhbHBoYS97bmFtZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL29wZXJhdGlvbnMvKn06Y2FuY2VsOgEq")
                },
                {
                    "google.longrunning.Operations.DeleteOperation",
                    // { "delete": "/v1alpha/{name=projects/*/locations/*/operations/*}" }
                    proto::ByteString.FromBase64("KjMvdjFhbHBoYS97bmFtZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL29wZXJhdGlvbnMvKn0=")
                },
                {
                    "google.longrunning.Operations.GetOperation",
                    // { "get": "/v1alpha/{name=projects/*/locations/*/operations/*}" }
                    proto::ByteString.FromBase64("EjMvdjFhbHBoYS97bmFtZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL29wZXJhdGlvbnMvKn0=")
                },
                {
                    "google.longrunning.Operations.ListOperations",
                    // { "get": "/v1alpha/{name=projects/*/locations/*}/operations" }
                    proto::ByteString.FromBase64("EjEvdjFhbHBoYS97bmFtZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qfS9vcGVyYXRpb25z")
                },
            });

        private static scg::IEnumerable<gpr::FileDescriptor> GetFileDescriptors()
        {
            yield return CsqlResourcesReflection.Descriptor;
            yield return DataModelReflection.Descriptor;
            yield return GeminiReflection.Descriptor;
            yield return ResourcesReflection.Descriptor;
            yield return ServiceReflection.Descriptor;
            yield return gciv::IamPolicyReflection.Descriptor;
            yield return gciv::OptionsReflection.Descriptor;
            yield return gciv::PolicyReflection.Descriptor;
            yield return gcl::LocationsReflection.Descriptor;
            yield return lro::OperationsReflection.Descriptor;
        }
    }
}
