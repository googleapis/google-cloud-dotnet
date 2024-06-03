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
using gciv = Google.Cloud.Iam.V1;
using gcl = Google.Cloud.Location;
using gpr = Google.Protobuf.Reflection;
using lro = Google.LongRunning;
using proto = Google.Protobuf;
using scg = System.Collections.Generic;

namespace Google.Cloud.NetworkSecurity.V1Beta1
{
    /// <summary>Static class to provide common access to package-wide API metadata.</summary>
    internal static class PackageApiMetadata
    {
        /// <summary>The <see cref="gaxgrpc::ApiMetadata"/> for services in this package.</summary>
        internal static gaxgrpc::ApiMetadata ApiMetadata { get; } = new gaxgrpc::ApiMetadata("Google.Cloud.NetworkSecurity.V1Beta1", GetFileDescriptors)
            .WithRequestNumericEnumJsonEncoding(true)
            .WithHttpRuleOverrides(new scg::Dictionary<string, proto::ByteString>
            {
                {
                    "google.cloud.location.Locations.GetLocation",
                    // { "get": "/v1beta1/{name=projects/*/locations/*}" }
                    proto::ByteString.FromBase64("EiYvdjFiZXRhMS97bmFtZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qfQ==")
                },
                {
                    "google.cloud.location.Locations.ListLocations",
                    // { "get": "/v1beta1/{name=projects/*}/locations" }
                    proto::ByteString.FromBase64("EiQvdjFiZXRhMS97bmFtZT1wcm9qZWN0cy8qfS9sb2NhdGlvbnM=")
                },
                {
                    "google.iam.v1.IAMPolicy.GetIamPolicy",
                    // { "get": "/v1beta1/{resource=projects/*/locations/*/authorizationPolicies/*}:getIamPolicy", "additionalBindings": [ { "get": "/v1beta1/{resource=projects/*/locations/*/serverTlsPolicies/*}:getIamPolicy" }, { "get": "/v1beta1/{resource=projects/*/locations/*/clientTlsPolicies/*}:getIamPolicy" } ] }
                    proto::ByteString.FromBase64("Ek8vdjFiZXRhMS97cmVzb3VyY2U9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9hdXRob3JpemF0aW9uUG9saWNpZXMvKn06Z2V0SWFtUG9saWN5Wk0SSy92MWJldGExL3tyZXNvdXJjZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL3NlcnZlclRsc1BvbGljaWVzLyp9OmdldElhbVBvbGljeVpNEksvdjFiZXRhMS97cmVzb3VyY2U9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9jbGllbnRUbHNQb2xpY2llcy8qfTpnZXRJYW1Qb2xpY3k=")
                },
                {
                    "google.iam.v1.IAMPolicy.SetIamPolicy",
                    // { "post": "/v1beta1/{resource=projects/*/locations/*/authorizationPolicies/*}:setIamPolicy", "body": "*", "additionalBindings": [ { "post": "/v1beta1/{resource=projects/*/locations/*/serverTlsPolicies/*}:setIamPolicy", "body": "*" }, { "post": "/v1beta1/{resource=projects/*/locations/*/clientTlsPolicies/*}:setIamPolicy", "body": "*" } ] }
                    proto::ByteString.FromBase64("Ik8vdjFiZXRhMS97cmVzb3VyY2U9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9hdXRob3JpemF0aW9uUG9saWNpZXMvKn06c2V0SWFtUG9saWN5OgEqWlAiSy92MWJldGExL3tyZXNvdXJjZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL3NlcnZlclRsc1BvbGljaWVzLyp9OnNldElhbVBvbGljeToBKlpQIksvdjFiZXRhMS97cmVzb3VyY2U9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9jbGllbnRUbHNQb2xpY2llcy8qfTpzZXRJYW1Qb2xpY3k6ASo=")
                },
                {
                    "google.iam.v1.IAMPolicy.TestIamPermissions",
                    // { "post": "/v1beta1/{resource=projects/*/locations/*/authorizationPolicies/*}:testIamPermissions", "body": "*", "additionalBindings": [ { "post": "/v1beta1/{resource=projects/*/locations/*/serverTlsPolicies/*}:testIamPermissions", "body": "*" }, { "post": "/v1beta1/{resource=projects/*/locations/*/clientTlsPolicies/*}:testIamPermissions", "body": "*" } ] }
                    proto::ByteString.FromBase64("IlUvdjFiZXRhMS97cmVzb3VyY2U9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9hdXRob3JpemF0aW9uUG9saWNpZXMvKn06dGVzdElhbVBlcm1pc3Npb25zOgEqWlYiUS92MWJldGExL3tyZXNvdXJjZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL3NlcnZlclRsc1BvbGljaWVzLyp9OnRlc3RJYW1QZXJtaXNzaW9uczoBKlpWIlEvdjFiZXRhMS97cmVzb3VyY2U9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9jbGllbnRUbHNQb2xpY2llcy8qfTp0ZXN0SWFtUGVybWlzc2lvbnM6ASo=")
                },
                {
                    "google.longrunning.Operations.CancelOperation",
                    // { "post": "/v1beta1/{name=projects/*/locations/*/operations/*}:cancel", "body": "*" }
                    proto::ByteString.FromBase64("IjovdjFiZXRhMS97bmFtZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL29wZXJhdGlvbnMvKn06Y2FuY2VsOgEq")
                },
                {
                    "google.longrunning.Operations.DeleteOperation",
                    // { "delete": "/v1beta1/{name=projects/*/locations/*/operations/*}" }
                    proto::ByteString.FromBase64("KjMvdjFiZXRhMS97bmFtZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL29wZXJhdGlvbnMvKn0=")
                },
                {
                    "google.longrunning.Operations.GetOperation",
                    // { "get": "/v1beta1/{name=projects/*/locations/*/operations/*}" }
                    proto::ByteString.FromBase64("EjMvdjFiZXRhMS97bmFtZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL29wZXJhdGlvbnMvKn0=")
                },
                {
                    "google.longrunning.Operations.ListOperations",
                    // { "get": "/v1beta1/{name=projects/*/locations/*}/operations" }
                    proto::ByteString.FromBase64("EjEvdjFiZXRhMS97bmFtZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qfS9vcGVyYXRpb25z")
                },
            });

        private static scg::IEnumerable<gpr::FileDescriptor> GetFileDescriptors()
        {
            yield return gciv::IamPolicyReflection.Descriptor;
            yield return gciv::OptionsReflection.Descriptor;
            yield return gciv::PolicyReflection.Descriptor;
            yield return gcl::LocationsReflection.Descriptor;
            yield return AuthorizationPolicyReflection.Descriptor;
            yield return ClientTlsPolicyReflection.Descriptor;
            yield return CommonReflection.Descriptor;
            yield return NetworkSecurityReflection.Descriptor;
            yield return ServerTlsPolicyReflection.Descriptor;
            yield return TlsReflection.Descriptor;
            yield return lro::OperationsReflection.Descriptor;
        }
    }
}
