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

#pragma warning disable CS8981
using gaxgrpc = Google.Api.Gax.Grpc;
using gciv = Google.Cloud.Iam.V1;
using gcl = Google.Cloud.Location;
using lro = Google.LongRunning;
using proto = Google.Protobuf;
using gpr = Google.Protobuf.Reflection;
using scg = System.Collections.Generic;

namespace Google.Cloud.Dataplex.V1
{
    /// <summary>Static class to provide common access to package-wide API metadata.</summary>
    internal static class PackageApiMetadata
    {
        /// <summary>The <see cref="gaxgrpc::ApiMetadata"/> for services in this package.</summary>
        internal static gaxgrpc::ApiMetadata ApiMetadata { get; } = new gaxgrpc::ApiMetadata("Google.Cloud.Dataplex.V1", GetFileDescriptors)
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
                    // { "get": "/v1/{resource=projects/*/locations/*/lakes/*}:getIamPolicy", "additionalBindings": [ { "get": "/v1/{resource=projects/*/locations/*/lakes/*/zones/*}:getIamPolicy" }, { "get": "/v1/{resource=projects/*/locations/*/lakes/*/zones/*/assets/*}:getIamPolicy" }, { "get": "/v1/{resource=projects/*/locations/*/lakes/*/tasks/*}:getIamPolicy" }, { "get": "/v1/{resource=projects/*/locations/*/lakes/*/environments/*}:getIamPolicy" } ] }
                    proto::ByteString.FromBase64("EjovdjEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zLyovbGFrZXMvKn06Z2V0SWFtUG9saWN5WkQSQi92MS97cmVzb3VyY2U9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9sYWtlcy8qL3pvbmVzLyp9OmdldElhbVBvbGljeVpNEksvdjEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zLyovbGFrZXMvKi96b25lcy8qL2Fzc2V0cy8qfTpnZXRJYW1Qb2xpY3laRBJCL3YxL3tyZXNvdXJjZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL2xha2VzLyovdGFza3MvKn06Z2V0SWFtUG9saWN5WksSSS92MS97cmVzb3VyY2U9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9sYWtlcy8qL2Vudmlyb25tZW50cy8qfTpnZXRJYW1Qb2xpY3k=")
                },
                {
                    "google.iam.v1.IAMPolicy.SetIamPolicy",
                    // { "post": "/v1/{resource=projects/*/locations/*/lakes/*}:setIamPolicy", "body": "*", "additionalBindings": [ { "post": "/v1/{resource=projects/*/locations/*/lakes/*/zones/*}:setIamPolicy", "body": "*" }, { "post": "/v1/{resource=projects/*/locations/*/lakes/*/zones/*/assets/*}:setIamPolicy", "body": "*" }, { "post": "/v1/{resource=projects/*/locations/*/lakes/*/tasks/*}:setIamPolicy", "body": "*" }, { "post": "/v1/{resource=projects/*/locations/*/lakes/*/environments/*}:setIamPolicy", "body": "*" } ] }
                    proto::ByteString.FromBase64("IjovdjEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zLyovbGFrZXMvKn06c2V0SWFtUG9saWN5OgEqWkciQi92MS97cmVzb3VyY2U9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9sYWtlcy8qL3pvbmVzLyp9OnNldElhbVBvbGljeToBKlpQIksvdjEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zLyovbGFrZXMvKi96b25lcy8qL2Fzc2V0cy8qfTpzZXRJYW1Qb2xpY3k6ASpaRyJCL3YxL3tyZXNvdXJjZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL2xha2VzLyovdGFza3MvKn06c2V0SWFtUG9saWN5OgEqWk4iSS92MS97cmVzb3VyY2U9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9sYWtlcy8qL2Vudmlyb25tZW50cy8qfTpzZXRJYW1Qb2xpY3k6ASo=")
                },
                {
                    "google.iam.v1.IAMPolicy.TestIamPermissions",
                    // { "post": "/v1/{resource=projects/*/locations/*/lakes/*}:testIamPermissions", "body": "*", "additionalBindings": [ { "post": "/v1/{resource=projects/*/locations/*/lakes/*/zones/*}:testIamPermissions", "body": "*" }, { "post": "/v1/{resource=projects/*/locations/*/lakes/*/zones/*/assets/*}:testIamPermissions", "body": "*" }, { "post": "/v1/{resource=projects/*/locations/*/lakes/*/tasks/*}:testIamPermissions", "body": "*" }, { "post": "/v1/{resource=projects/*/locations/*/lakes/*/environments/*}:testIamPermissions", "body": "*" } ] }
                    proto::ByteString.FromBase64("IkAvdjEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zLyovbGFrZXMvKn06dGVzdElhbVBlcm1pc3Npb25zOgEqWk0iSC92MS97cmVzb3VyY2U9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9sYWtlcy8qL3pvbmVzLyp9OnRlc3RJYW1QZXJtaXNzaW9uczoBKlpWIlEvdjEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zLyovbGFrZXMvKi96b25lcy8qL2Fzc2V0cy8qfTp0ZXN0SWFtUGVybWlzc2lvbnM6ASpaTSJIL3YxL3tyZXNvdXJjZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL2xha2VzLyovdGFza3MvKn06dGVzdElhbVBlcm1pc3Npb25zOgEqWlQiTy92MS97cmVzb3VyY2U9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9sYWtlcy8qL2Vudmlyb25tZW50cy8qfTp0ZXN0SWFtUGVybWlzc2lvbnM6ASo=")
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
            yield return AnalyzeReflection.Descriptor;
            yield return ContentReflection.Descriptor;
            yield return LogsReflection.Descriptor;
            yield return MetadataReflection.Descriptor;
            yield return ResourcesReflection.Descriptor;
            yield return ServiceReflection.Descriptor;
            yield return TasksReflection.Descriptor;
            yield return gciv::IamPolicyReflection.Descriptor;
            yield return gciv::OptionsReflection.Descriptor;
            yield return gciv::PolicyReflection.Descriptor;
            yield return gcl::LocationsReflection.Descriptor;
            yield return lro::OperationsReflection.Descriptor;
        }
    }
}
