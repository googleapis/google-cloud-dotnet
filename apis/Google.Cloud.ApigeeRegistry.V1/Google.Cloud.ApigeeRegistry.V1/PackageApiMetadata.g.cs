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

namespace Google.Cloud.ApigeeRegistry.V1
{
    /// <summary>Static class to provide common access to package-wide API metadata.</summary>
    internal static class PackageApiMetadata
    {
        /// <summary>The <see cref="gaxgrpc::ApiMetadata"/> for services in this package.</summary>
        internal static gaxgrpc::ApiMetadata ApiMetadata { get; } = new gaxgrpc::ApiMetadata("Google.Cloud.ApigeeRegistry.V1", GetFileDescriptors)
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
                    // { "get": "/v1/{resource=projects/*/locations/*/apis/*}:getIamPolicy", "additionalBindings": [ { "get": "/v1/{resource=projects/*/locations/*/apis/*/deployments/*}:getIamPolicy" }, { "get": "/v1/{resource=projects/*/locations/*/apis/*/versions/*}:getIamPolicy" }, { "get": "/v1/{resource=projects/*/locations/*/apis/*/versions/*/specs/*}:getIamPolicy" }, { "get": "/v1/{resource=projects/*/locations/*/artifacts/*}:getIamPolicy" }, { "get": "/v1/{resource=projects/*/locations/*/apis/*/artifacts/*}:getIamPolicy" }, { "get": "/v1/{resource=projects/*/locations/*/apis/*/versions/*/artifacts/*}:getIamPolicy" }, { "get": "/v1/{resource=projects/*/locations/*/apis/*/versions/*/specs/*/artifacts/*}:getIamPolicy" }, { "get": "/v1/{resource=projects/*/locations/*/instances/*}:getIamPolicy" }, { "get": "/v1/{resource=projects/*/locations/*/runtime}:getIamPolicy" } ] }
                    proto::ByteString.FromBase64("EjkvdjEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zLyovYXBpcy8qfTpnZXRJYW1Qb2xpY3laSRJHL3YxL3tyZXNvdXJjZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL2FwaXMvKi9kZXBsb3ltZW50cy8qfTpnZXRJYW1Qb2xpY3laRhJEL3YxL3tyZXNvdXJjZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL2FwaXMvKi92ZXJzaW9ucy8qfTpnZXRJYW1Qb2xpY3laThJML3YxL3tyZXNvdXJjZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL2FwaXMvKi92ZXJzaW9ucy8qL3NwZWNzLyp9OmdldElhbVBvbGljeVpAEj4vdjEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zLyovYXJ0aWZhY3RzLyp9OmdldElhbVBvbGljeVpHEkUvdjEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zLyovYXBpcy8qL2FydGlmYWN0cy8qfTpnZXRJYW1Qb2xpY3laUhJQL3YxL3tyZXNvdXJjZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL2FwaXMvKi92ZXJzaW9ucy8qL2FydGlmYWN0cy8qfTpnZXRJYW1Qb2xpY3laWhJYL3YxL3tyZXNvdXJjZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL2FwaXMvKi92ZXJzaW9ucy8qL3NwZWNzLyovYXJ0aWZhY3RzLyp9OmdldElhbVBvbGljeVpAEj4vdjEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zLyovaW5zdGFuY2VzLyp9OmdldElhbVBvbGljeVo8EjovdjEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zLyovcnVudGltZX06Z2V0SWFtUG9saWN5")
                },
                {
                    "google.iam.v1.IAMPolicy.SetIamPolicy",
                    // { "post": "/v1/{resource=projects/*/locations/*/apis/*}:setIamPolicy", "body": "*", "additionalBindings": [ { "post": "/v1/{resource=projects/*/locations/*/apis/*/deployments/*}:setIamPolicy", "body": "*" }, { "post": "/v1/{resource=projects/*/locations/*/apis/*/versions/*}:setIamPolicy", "body": "*" }, { "post": "/v1/{resource=projects/*/locations/*/apis/*/versions/*/specs/*}:setIamPolicy", "body": "*" }, { "post": "/v1/{resource=projects/*/locations/*/artifacts/*}:setIamPolicy", "body": "*" }, { "post": "/v1/{resource=projects/*/locations/*/apis/*/artifacts/*}:setIamPolicy", "body": "*" }, { "post": "/v1/{resource=projects/*/locations/*/apis/*/versions/*/artifacts/*}:setIamPolicy", "body": "*" }, { "post": "/v1/{resource=projects/*/locations/*/apis/*/versions/*/specs/*/artifacts/*}:setIamPolicy", "body": "*" }, { "post": "/v1/{resource=projects/*/locations/*/instances/*}:setIamPolicy", "body": "*" }, { "post": "/v1/{resource=projects/*/locations/*/runtime}:setIamPolicy", "body": "*" } ] }
                    proto::ByteString.FromBase64("IjkvdjEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zLyovYXBpcy8qfTpzZXRJYW1Qb2xpY3k6ASpaTCJHL3YxL3tyZXNvdXJjZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL2FwaXMvKi9kZXBsb3ltZW50cy8qfTpzZXRJYW1Qb2xpY3k6ASpaSSJEL3YxL3tyZXNvdXJjZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL2FwaXMvKi92ZXJzaW9ucy8qfTpzZXRJYW1Qb2xpY3k6ASpaUSJML3YxL3tyZXNvdXJjZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL2FwaXMvKi92ZXJzaW9ucy8qL3NwZWNzLyp9OnNldElhbVBvbGljeToBKlpDIj4vdjEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zLyovYXJ0aWZhY3RzLyp9OnNldElhbVBvbGljeToBKlpKIkUvdjEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zLyovYXBpcy8qL2FydGlmYWN0cy8qfTpzZXRJYW1Qb2xpY3k6ASpaVSJQL3YxL3tyZXNvdXJjZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL2FwaXMvKi92ZXJzaW9ucy8qL2FydGlmYWN0cy8qfTpzZXRJYW1Qb2xpY3k6ASpaXSJYL3YxL3tyZXNvdXJjZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL2FwaXMvKi92ZXJzaW9ucy8qL3NwZWNzLyovYXJ0aWZhY3RzLyp9OnNldElhbVBvbGljeToBKlpDIj4vdjEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zLyovaW5zdGFuY2VzLyp9OnNldElhbVBvbGljeToBKlo/IjovdjEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zLyovcnVudGltZX06c2V0SWFtUG9saWN5OgEq")
                },
                {
                    "google.iam.v1.IAMPolicy.TestIamPermissions",
                    // { "post": "/v1/{resource=projects/*/locations/*/apis/*}:testIamPermissions", "body": "*", "additionalBindings": [ { "post": "/v1/{resource=projects/*/locations/*/apis/*/deployments/*}:testIamPermissions", "body": "*" }, { "post": "/v1/{resource=projects/*/locations/*/apis/*/versions/*}:testIamPermissions", "body": "*" }, { "post": "/v1/{resource=projects/*/locations/*/apis/*/versions/*/specs/*}:testIamPermissions", "body": "*" }, { "post": "/v1/{resource=projects/*/locations/*/artifacts/*}:testIamPermissions", "body": "*" }, { "post": "/v1/{resource=projects/*/locations/*/apis/*/artifacts/*}:testIamPermissions", "body": "*" }, { "post": "/v1/{resource=projects/*/locations/*/apis/*/versions/*/artifacts/*}:testIamPermissions", "body": "*" }, { "post": "/v1/{resource=projects/*/locations/*/apis/*/versions/*/specs/*/artifacts/*}:testIamPermissions", "body": "*" }, { "post": "/v1/{resource=projects/*/locations/*/instances/*}:testIamPermissions", "body": "*" }, { "post": "/v1/{resource=projects/*/locations/*/runtime}:testIamPermissions", "body": "*" } ] }
                    proto::ByteString.FromBase64("Ij8vdjEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zLyovYXBpcy8qfTp0ZXN0SWFtUGVybWlzc2lvbnM6ASpaUiJNL3YxL3tyZXNvdXJjZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL2FwaXMvKi9kZXBsb3ltZW50cy8qfTp0ZXN0SWFtUGVybWlzc2lvbnM6ASpaTyJKL3YxL3tyZXNvdXJjZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL2FwaXMvKi92ZXJzaW9ucy8qfTp0ZXN0SWFtUGVybWlzc2lvbnM6ASpaVyJSL3YxL3tyZXNvdXJjZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL2FwaXMvKi92ZXJzaW9ucy8qL3NwZWNzLyp9OnRlc3RJYW1QZXJtaXNzaW9uczoBKlpJIkQvdjEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zLyovYXJ0aWZhY3RzLyp9OnRlc3RJYW1QZXJtaXNzaW9uczoBKlpQIksvdjEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zLyovYXBpcy8qL2FydGlmYWN0cy8qfTp0ZXN0SWFtUGVybWlzc2lvbnM6ASpaWyJWL3YxL3tyZXNvdXJjZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL2FwaXMvKi92ZXJzaW9ucy8qL2FydGlmYWN0cy8qfTp0ZXN0SWFtUGVybWlzc2lvbnM6ASpaYyJeL3YxL3tyZXNvdXJjZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL2FwaXMvKi92ZXJzaW9ucy8qL3NwZWNzLyovYXJ0aWZhY3RzLyp9OnRlc3RJYW1QZXJtaXNzaW9uczoBKlpJIkQvdjEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zLyovaW5zdGFuY2VzLyp9OnRlc3RJYW1QZXJtaXNzaW9uczoBKlpFIkAvdjEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zLyovcnVudGltZX06dGVzdElhbVBlcm1pc3Npb25zOgEq")
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
            yield return ProvisioningServiceReflection.Descriptor;
            yield return RegistryModelsReflection.Descriptor;
            yield return RegistryServiceReflection.Descriptor;
            yield return gciv::IamPolicyReflection.Descriptor;
            yield return gciv::OptionsReflection.Descriptor;
            yield return gciv::PolicyReflection.Descriptor;
            yield return gcl::LocationsReflection.Descriptor;
            yield return lro::OperationsReflection.Descriptor;
        }
    }
}
