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

namespace Google.Cloud.Metastore.V1Alpha
{
    /// <summary>Static class to provide common access to package-wide API metadata.</summary>
    internal static class PackageApiMetadata
    {
        /// <summary>The <see cref="gaxgrpc::ApiMetadata"/> for services in this package.</summary>
        internal static gaxgrpc::ApiMetadata ApiMetadata { get; } = new gaxgrpc::ApiMetadata("Google.Cloud.Metastore.V1Alpha", GetFileDescriptors)
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
                    "google.iam.v1.IAMPolicy.GetIamPolicy",
                    // { "get": "/v1alpha/{resource=projects/*/locations/*/services/*}:getIamPolicy", "additionalBindings": [ { "get": "/v1alpha/{resource=projects/*/locations/*/services/*/backups/*}:getIamPolicy" }, { "get": "/v1alpha/{resource=projects/*/locations/*/services/*/databases/*}:getIamPolicy" }, { "get": "/v1alpha/{resource=projects/*/locations/*/services/*/databases/*/tables/*}:getIamPolicy" }, { "get": "/v1alpha/{resource=projects/*/locations/*/federations/*}:getIamPolicy" } ] }
                    proto::ByteString.FromBase64("EkIvdjFhbHBoYS97cmVzb3VyY2U9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9zZXJ2aWNlcy8qfTpnZXRJYW1Qb2xpY3laThJML3YxYWxwaGEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zLyovc2VydmljZXMvKi9iYWNrdXBzLyp9OmdldElhbVBvbGljeVpQEk4vdjFhbHBoYS97cmVzb3VyY2U9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9zZXJ2aWNlcy8qL2RhdGFiYXNlcy8qfTpnZXRJYW1Qb2xpY3laWRJXL3YxYWxwaGEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zLyovc2VydmljZXMvKi9kYXRhYmFzZXMvKi90YWJsZXMvKn06Z2V0SWFtUG9saWN5WkcSRS92MWFscGhhL3tyZXNvdXJjZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL2ZlZGVyYXRpb25zLyp9OmdldElhbVBvbGljeQ==")
                },
                {
                    "google.iam.v1.IAMPolicy.SetIamPolicy",
                    // { "post": "/v1alpha/{resource=projects/*/locations/*/services/*}:setIamPolicy", "body": "*", "additionalBindings": [ { "post": "/v1alpha/{resource=projects/*/locations/*/services/*/backups/*}:setIamPolicy", "body": "*" }, { "post": "/v1alpha/{resource=projects/*/locations/*/services/*/databases/*}:setIamPolicy", "body": "*" }, { "post": "/v1alpha/{resource=projects/*/locations/*/services/*/databases/*/tables/*}:setIamPolicy", "body": "*" }, { "post": "/v1alpha/{resource=projects/*/locations/*/federations/*}:setIamPolicy", "body": "*" } ] }
                    proto::ByteString.FromBase64("IkIvdjFhbHBoYS97cmVzb3VyY2U9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9zZXJ2aWNlcy8qfTpzZXRJYW1Qb2xpY3k6ASpaUSJML3YxYWxwaGEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zLyovc2VydmljZXMvKi9iYWNrdXBzLyp9OnNldElhbVBvbGljeToBKlpTIk4vdjFhbHBoYS97cmVzb3VyY2U9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9zZXJ2aWNlcy8qL2RhdGFiYXNlcy8qfTpzZXRJYW1Qb2xpY3k6ASpaXCJXL3YxYWxwaGEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zLyovc2VydmljZXMvKi9kYXRhYmFzZXMvKi90YWJsZXMvKn06c2V0SWFtUG9saWN5OgEqWkoiRS92MWFscGhhL3tyZXNvdXJjZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL2ZlZGVyYXRpb25zLyp9OnNldElhbVBvbGljeToBKg==")
                },
                {
                    "google.iam.v1.IAMPolicy.TestIamPermissions",
                    // { "post": "/v1alpha/{resource=projects/*/locations/*/services/*}:testIamPermissions", "body": "*", "additionalBindings": [ { "post": "/v1alpha/{resource=projects/*/locations/*/services/*/backups/*}:testIamPermissions", "body": "*" }, { "post": "/v1alpha/{resource=projects/*/locations/*/services/*/databases/*}:testIamPermissions", "body": "*" }, { "post": "/v1alpha/{resource=projects/*/locations/*/services/*/databases/*/tables/*}:testIamPermissions", "body": "*" }, { "post": "/v1alpha/{resource=projects/*/locations/*/federations/*}:testIamPermissions", "body": "*" } ] }
                    proto::ByteString.FromBase64("IkgvdjFhbHBoYS97cmVzb3VyY2U9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9zZXJ2aWNlcy8qfTp0ZXN0SWFtUGVybWlzc2lvbnM6ASpaVyJSL3YxYWxwaGEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zLyovc2VydmljZXMvKi9iYWNrdXBzLyp9OnRlc3RJYW1QZXJtaXNzaW9uczoBKlpZIlQvdjFhbHBoYS97cmVzb3VyY2U9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9zZXJ2aWNlcy8qL2RhdGFiYXNlcy8qfTp0ZXN0SWFtUGVybWlzc2lvbnM6ASpaYiJdL3YxYWxwaGEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zLyovc2VydmljZXMvKi9kYXRhYmFzZXMvKi90YWJsZXMvKn06dGVzdElhbVBlcm1pc3Npb25zOgEqWlAiSy92MWFscGhhL3tyZXNvdXJjZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL2ZlZGVyYXRpb25zLyp9OnRlc3RJYW1QZXJtaXNzaW9uczoBKg==")
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
            yield return gciv::IamPolicyReflection.Descriptor;
            yield return gciv::OptionsReflection.Descriptor;
            yield return gciv::PolicyReflection.Descriptor;
            yield return gcl::LocationsReflection.Descriptor;
            yield return MetastoreReflection.Descriptor;
            yield return MetastoreFederationReflection.Descriptor;
            yield return lro::OperationsReflection.Descriptor;
        }
    }
}
