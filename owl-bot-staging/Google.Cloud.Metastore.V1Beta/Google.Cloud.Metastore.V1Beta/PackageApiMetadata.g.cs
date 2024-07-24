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

namespace Google.Cloud.Metastore.V1Beta
{
    /// <summary>Static class to provide common access to package-wide API metadata.</summary>
    internal static class PackageApiMetadata
    {
        /// <summary>The <see cref="gaxgrpc::ApiMetadata"/> for services in this package.</summary>
        internal static gaxgrpc::ApiMetadata ApiMetadata { get; } = new gaxgrpc::ApiMetadata("Google.Cloud.Metastore.V1Beta", GetFileDescriptors)
            .WithRequestNumericEnumJsonEncoding(true)
            .WithHttpRuleOverrides(new scg::Dictionary<string, proto::ByteString>
            {
                {
                    "google.cloud.location.Locations.GetLocation",
                    // { "get": "/v1beta/{name=projects/*/locations/*}" }
                    proto::ByteString.FromBase64("EiUvdjFiZXRhL3tuYW1lPXByb2plY3RzLyovbG9jYXRpb25zLyp9")
                },
                {
                    "google.cloud.location.Locations.ListLocations",
                    // { "get": "/v1beta/{name=projects/*}/locations" }
                    proto::ByteString.FromBase64("EiMvdjFiZXRhL3tuYW1lPXByb2plY3RzLyp9L2xvY2F0aW9ucw==")
                },
                {
                    "google.iam.v1.IAMPolicy.GetIamPolicy",
                    // { "get": "/v1beta/{resource=projects/*/locations/*/services/*}:getIamPolicy", "additionalBindings": [ { "get": "/v1beta/{resource=projects/*/locations/*/services/*/backups/*}:getIamPolicy" }, { "get": "/v1beta/{resource=projects/*/locations/*/services/*/databases/*}:getIamPolicy" }, { "get": "/v1beta/{resource=projects/*/locations/*/services/*/databases/*/tables/*}:getIamPolicy" }, { "get": "/v1beta/{resource=projects/*/locations/*/federations/*}:getIamPolicy" } ] }
                    proto::ByteString.FromBase64("EkEvdjFiZXRhL3tyZXNvdXJjZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL3NlcnZpY2VzLyp9OmdldElhbVBvbGljeVpNEksvdjFiZXRhL3tyZXNvdXJjZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL3NlcnZpY2VzLyovYmFja3Vwcy8qfTpnZXRJYW1Qb2xpY3laTxJNL3YxYmV0YS97cmVzb3VyY2U9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9zZXJ2aWNlcy8qL2RhdGFiYXNlcy8qfTpnZXRJYW1Qb2xpY3laWBJWL3YxYmV0YS97cmVzb3VyY2U9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9zZXJ2aWNlcy8qL2RhdGFiYXNlcy8qL3RhYmxlcy8qfTpnZXRJYW1Qb2xpY3laRhJEL3YxYmV0YS97cmVzb3VyY2U9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9mZWRlcmF0aW9ucy8qfTpnZXRJYW1Qb2xpY3k=")
                },
                {
                    "google.iam.v1.IAMPolicy.SetIamPolicy",
                    // { "post": "/v1beta/{resource=projects/*/locations/*/services/*}:setIamPolicy", "body": "*", "additionalBindings": [ { "post": "/v1beta/{resource=projects/*/locations/*/services/*/backups/*}:setIamPolicy", "body": "*" }, { "post": "/v1beta/{resource=projects/*/locations/*/services/*/databases/*}:setIamPolicy", "body": "*" }, { "post": "/v1beta/{resource=projects/*/locations/*/services/*/databases/*/tables/*}:setIamPolicy", "body": "*" }, { "post": "/v1beta/{resource=projects/*/locations/*/federations/*}:setIamPolicy", "body": "*" } ] }
                    proto::ByteString.FromBase64("IkEvdjFiZXRhL3tyZXNvdXJjZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL3NlcnZpY2VzLyp9OnNldElhbVBvbGljeToBKlpQIksvdjFiZXRhL3tyZXNvdXJjZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL3NlcnZpY2VzLyovYmFja3Vwcy8qfTpzZXRJYW1Qb2xpY3k6ASpaUiJNL3YxYmV0YS97cmVzb3VyY2U9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9zZXJ2aWNlcy8qL2RhdGFiYXNlcy8qfTpzZXRJYW1Qb2xpY3k6ASpaWyJWL3YxYmV0YS97cmVzb3VyY2U9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9zZXJ2aWNlcy8qL2RhdGFiYXNlcy8qL3RhYmxlcy8qfTpzZXRJYW1Qb2xpY3k6ASpaSSJEL3YxYmV0YS97cmVzb3VyY2U9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9mZWRlcmF0aW9ucy8qfTpzZXRJYW1Qb2xpY3k6ASo=")
                },
                {
                    "google.iam.v1.IAMPolicy.TestIamPermissions",
                    // { "post": "/v1beta/{resource=projects/*/locations/*/services/*}:testIamPermissions", "body": "*", "additionalBindings": [ { "post": "/v1beta/{resource=projects/*/locations/*/services/*/backups/*}:testIamPermissions", "body": "*" }, { "post": "/v1beta/{resource=projects/*/locations/*/services/*/databases/*}:testIamPermissions", "body": "*" }, { "post": "/v1beta/{resource=projects/*/locations/*/services/*/databases/*/tables/*}:testIamPermissions", "body": "*" }, { "post": "/v1beta/{resource=projects/*/locations/*/federations/*}:testIamPermissions", "body": "*" } ] }
                    proto::ByteString.FromBase64("IkcvdjFiZXRhL3tyZXNvdXJjZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL3NlcnZpY2VzLyp9OnRlc3RJYW1QZXJtaXNzaW9uczoBKlpWIlEvdjFiZXRhL3tyZXNvdXJjZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL3NlcnZpY2VzLyovYmFja3Vwcy8qfTp0ZXN0SWFtUGVybWlzc2lvbnM6ASpaWCJTL3YxYmV0YS97cmVzb3VyY2U9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9zZXJ2aWNlcy8qL2RhdGFiYXNlcy8qfTp0ZXN0SWFtUGVybWlzc2lvbnM6ASpaYSJcL3YxYmV0YS97cmVzb3VyY2U9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9zZXJ2aWNlcy8qL2RhdGFiYXNlcy8qL3RhYmxlcy8qfTp0ZXN0SWFtUGVybWlzc2lvbnM6ASpaTyJKL3YxYmV0YS97cmVzb3VyY2U9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9mZWRlcmF0aW9ucy8qfTp0ZXN0SWFtUGVybWlzc2lvbnM6ASo=")
                },
                {
                    "google.longrunning.Operations.CancelOperation",
                    // { "post": "/v1beta/{name=projects/*/locations/*/operations/*}:cancel", "body": "*" }
                    proto::ByteString.FromBase64("IjkvdjFiZXRhL3tuYW1lPXByb2plY3RzLyovbG9jYXRpb25zLyovb3BlcmF0aW9ucy8qfTpjYW5jZWw6ASo=")
                },
                {
                    "google.longrunning.Operations.DeleteOperation",
                    // { "delete": "/v1beta/{name=projects/*/locations/*/operations/*}" }
                    proto::ByteString.FromBase64("KjIvdjFiZXRhL3tuYW1lPXByb2plY3RzLyovbG9jYXRpb25zLyovb3BlcmF0aW9ucy8qfQ==")
                },
                {
                    "google.longrunning.Operations.GetOperation",
                    // { "get": "/v1beta/{name=projects/*/locations/*/operations/*}" }
                    proto::ByteString.FromBase64("EjIvdjFiZXRhL3tuYW1lPXByb2plY3RzLyovbG9jYXRpb25zLyovb3BlcmF0aW9ucy8qfQ==")
                },
                {
                    "google.longrunning.Operations.ListOperations",
                    // { "get": "/v1beta/{name=projects/*/locations/*}/operations" }
                    proto::ByteString.FromBase64("EjAvdjFiZXRhL3tuYW1lPXByb2plY3RzLyovbG9jYXRpb25zLyp9L29wZXJhdGlvbnM=")
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
