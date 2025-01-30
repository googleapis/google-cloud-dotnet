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

namespace Google.Cloud.Security.PrivateCA.V1
{
    /// <summary>Static class to provide common access to package-wide API metadata.</summary>
    internal static class PackageApiMetadata
    {
        /// <summary>The <see cref="gaxgrpc::ApiMetadata"/> for services in this package.</summary>
        internal static gaxgrpc::ApiMetadata ApiMetadata { get; } = new gaxgrpc::ApiMetadata("Google.Cloud.Security.PrivateCA.V1", GetFileDescriptors)
            .WithRequestNumericEnumJsonEncoding(true)
            .WithHttpRuleOverrides(new scg::Dictionary<string, proto::ByteString>
            {
                {
                    "google.cloud.location.Locations.GetLocation",
                    // { "get": "/v1/{name=projects/*/locations/*}" }
                    proto::ByteString.FromBase64("EiEvdjEve25hbWU9cHJvamVjdHMvKi9sb2NhdGlvbnMvKn0=")
                },
                {
                    "google.cloud.location.Locations.ListLocations",
                    // { "get": "/v1/{name=projects/*}/locations" }
                    proto::ByteString.FromBase64("Eh8vdjEve25hbWU9cHJvamVjdHMvKn0vbG9jYXRpb25z")
                },
                {
                    "google.iam.v1.IAMPolicy.GetIamPolicy",
                    // { "get": "/v1/{resource=projects/*/locations/*/caPools/*}:getIamPolicy", "additionalBindings": [ { "get": "/v1/{resource=projects/*/locations/*/certificateTemplates/*}:getIamPolicy" }, { "get": "/v1/{resource=projects/*/locations/*/caPools/*/certificateAuthorities/*/certificateRevocationLists/*}:getIamPolicy" } ] }
                    proto::ByteString.FromBase64("EjwvdjEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zLyovY2FQb29scy8qfTpnZXRJYW1Qb2xpY3laSxJJL3YxL3tyZXNvdXJjZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL2NlcnRpZmljYXRlVGVtcGxhdGVzLyp9OmdldElhbVBvbGljeVp0EnIvdjEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zLyovY2FQb29scy8qL2NlcnRpZmljYXRlQXV0aG9yaXRpZXMvKi9jZXJ0aWZpY2F0ZVJldm9jYXRpb25MaXN0cy8qfTpnZXRJYW1Qb2xpY3k=")
                },
                {
                    "google.iam.v1.IAMPolicy.SetIamPolicy",
                    // { "post": "/v1/{resource=projects/*/locations/*/caPools/*}:setIamPolicy", "body": "*", "additionalBindings": [ { "post": "/v1/{resource=projects/*/locations/*/certificateTemplates/*}:setIamPolicy", "body": "*" }, { "post": "/v1/{resource=projects/*/locations/*/caPools/*/certificateAuthorities/*/certificateRevocationLists/*}:setIamPolicy", "body": "*" } ] }
                    proto::ByteString.FromBase64("IjwvdjEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zLyovY2FQb29scy8qfTpzZXRJYW1Qb2xpY3k6ASpaTiJJL3YxL3tyZXNvdXJjZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL2NlcnRpZmljYXRlVGVtcGxhdGVzLyp9OnNldElhbVBvbGljeToBKlp3InIvdjEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zLyovY2FQb29scy8qL2NlcnRpZmljYXRlQXV0aG9yaXRpZXMvKi9jZXJ0aWZpY2F0ZVJldm9jYXRpb25MaXN0cy8qfTpzZXRJYW1Qb2xpY3k6ASo=")
                },
                {
                    "google.iam.v1.IAMPolicy.TestIamPermissions",
                    // { "post": "/v1/{resource=projects/*/locations/*/caPools/*}:testIamPermissions", "body": "*", "additionalBindings": [ { "post": "/v1/{resource=projects/*/locations/*/certificateTemplates/*}:testIamPermissions", "body": "*" }, { "post": "/v1/{resource=projects/*/locations/*/caPools/*/certificateAuthorities/*/certificateRevocationLists/*}:testIamPermissions", "body": "*" } ] }
                    proto::ByteString.FromBase64("IkIvdjEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zLyovY2FQb29scy8qfTp0ZXN0SWFtUGVybWlzc2lvbnM6ASpaVCJPL3YxL3tyZXNvdXJjZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL2NlcnRpZmljYXRlVGVtcGxhdGVzLyp9OnRlc3RJYW1QZXJtaXNzaW9uczoBKlp9IngvdjEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zLyovY2FQb29scy8qL2NlcnRpZmljYXRlQXV0aG9yaXRpZXMvKi9jZXJ0aWZpY2F0ZVJldm9jYXRpb25MaXN0cy8qfTp0ZXN0SWFtUGVybWlzc2lvbnM6ASo=")
                },
                {
                    "google.longrunning.Operations.CancelOperation",
                    // { "post": "/v1/{name=projects/*/locations/*/operations/*}:cancel", "body": "*" }
                    proto::ByteString.FromBase64("IjUvdjEve25hbWU9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9vcGVyYXRpb25zLyp9OmNhbmNlbDoBKg==")
                },
                {
                    "google.longrunning.Operations.DeleteOperation",
                    // { "delete": "/v1/{name=projects/*/locations/*/operations/*}" }
                    proto::ByteString.FromBase64("Ki4vdjEve25hbWU9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9vcGVyYXRpb25zLyp9")
                },
                {
                    "google.longrunning.Operations.GetOperation",
                    // { "get": "/v1/{name=projects/*/locations/*/operations/*}" }
                    proto::ByteString.FromBase64("Ei4vdjEve25hbWU9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9vcGVyYXRpb25zLyp9")
                },
                {
                    "google.longrunning.Operations.ListOperations",
                    // { "get": "/v1/{name=projects/*/locations/*}/operations" }
                    proto::ByteString.FromBase64("EiwvdjEve25hbWU9cHJvamVjdHMvKi9sb2NhdGlvbnMvKn0vb3BlcmF0aW9ucw==")
                },
            });

        private static scg::IEnumerable<gpr::FileDescriptor> GetFileDescriptors()
        {
            yield return gciv::IamPolicyReflection.Descriptor;
            yield return gciv::OptionsReflection.Descriptor;
            yield return gciv::PolicyReflection.Descriptor;
            yield return gcl::LocationsReflection.Descriptor;
            yield return ResourcesReflection.Descriptor;
            yield return ServiceReflection.Descriptor;
            yield return lro::OperationsReflection.Descriptor;
        }
    }
}
