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
using gcl = Google.Cloud.Location;
using gpr = Google.Protobuf.Reflection;
using lro = Google.LongRunning;
using proto = Google.Protobuf;
using scg = System.Collections.Generic;

namespace Google.Cloud.Iam.V3Beta
{
    /// <summary>Static class to provide common access to package-wide API metadata.</summary>
    internal static class PackageApiMetadata
    {
        /// <summary>The <see cref="gaxgrpc::ApiMetadata"/> for services in this package.</summary>
        internal static gaxgrpc::ApiMetadata ApiMetadata { get; } = new gaxgrpc::ApiMetadata("Google.Cloud.Iam.V3Beta", GetFileDescriptors)
            .WithRequestNumericEnumJsonEncoding(true)
            .WithHttpRuleOverrides(new scg::Dictionary<string, proto::ByteString>
            {
                {
                    "google.longrunning.Operations.GetOperation",
                    // { "get": "/v3beta/{name=projects/*/locations/*/operations/*}", "additionalBindings": [ { "get": "/v3beta/{name=folders/*/locations/*/operations/*}" }, { "get": "/v3beta/{name=organizations/*/locations/*/operations/*}" } ] }
                    proto::ByteString.FromBase64("EjIvdjNiZXRhL3tuYW1lPXByb2plY3RzLyovbG9jYXRpb25zLyovb3BlcmF0aW9ucy8qfVozEjEvdjNiZXRhL3tuYW1lPWZvbGRlcnMvKi9sb2NhdGlvbnMvKi9vcGVyYXRpb25zLyp9WjkSNy92M2JldGEve25hbWU9b3JnYW5pemF0aW9ucy8qL2xvY2F0aW9ucy8qL29wZXJhdGlvbnMvKn0=")
                },
            });

        private static scg::IEnumerable<gpr::FileDescriptor> GetFileDescriptors()
        {
            yield return OperationMetadataReflection.Descriptor;
            yield return PolicyBindingResourcesReflection.Descriptor;
            yield return PolicyBindingsServiceReflection.Descriptor;
            yield return PrincipalAccessBoundaryPoliciesServiceReflection.Descriptor;
            yield return PrincipalAccessBoundaryPolicyResourcesReflection.Descriptor;
            yield return gcl::LocationsReflection.Descriptor;
            yield return lro::OperationsReflection.Descriptor;
        }
    }
}
