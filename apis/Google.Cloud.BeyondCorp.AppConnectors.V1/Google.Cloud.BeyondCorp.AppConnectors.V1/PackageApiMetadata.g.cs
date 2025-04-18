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

namespace Google.Cloud.BeyondCorp.AppConnectors.V1
{
    /// <summary>Static class to provide common access to package-wide API metadata.</summary>
    internal static class PackageApiMetadata
    {
        /// <summary>The <see cref="gaxgrpc::ApiMetadata"/> for services in this package.</summary>
        internal static gaxgrpc::ApiMetadata ApiMetadata { get; } = new gaxgrpc::ApiMetadata("Google.Cloud.BeyondCorp.AppConnectors.V1", GetFileDescriptors)
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
                    // { "get": "/v1/{resource=projects/*/locations/*/appConnections/*}:getIamPolicy", "additionalBindings": [ { "get": "/v1/{resource=projects/*/locations/*/appConnectors/*}:getIamPolicy" }, { "get": "/v1/{resource=projects/*/locations/*/appGateways/*}:getIamPolicy" }, { "get": "/v1/{resource=projects/*/locations/*/clientConnectorServices/*}:getIamPolicy" }, { "get": "/v1/{resource=projects/*/locations/*/clientGateways/*}:getIamPolicy" } ] }
                    proto::ByteString.FromBase64("EkMvdjEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zLyovYXBwQ29ubmVjdGlvbnMvKn06Z2V0SWFtUG9saWN5WkQSQi92MS97cmVzb3VyY2U9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9hcHBDb25uZWN0b3JzLyp9OmdldElhbVBvbGljeVpCEkAvdjEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zLyovYXBwR2F0ZXdheXMvKn06Z2V0SWFtUG9saWN5Wk4STC92MS97cmVzb3VyY2U9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9jbGllbnRDb25uZWN0b3JTZXJ2aWNlcy8qfTpnZXRJYW1Qb2xpY3laRRJDL3YxL3tyZXNvdXJjZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL2NsaWVudEdhdGV3YXlzLyp9OmdldElhbVBvbGljeQ==")
                },
                {
                    "google.iam.v1.IAMPolicy.SetIamPolicy",
                    // { "post": "/v1/{resource=projects/*/locations/*/appConnections/*}:setIamPolicy", "body": "*", "additionalBindings": [ { "post": "/v1/{resource=projects/*/locations/*/appConnectors/*}:setIamPolicy", "body": "*" }, { "post": "/v1/{resource=projects/*/locations/*/appGateways/*}:setIamPolicy", "body": "*" }, { "post": "/v1/{resource=projects/*/locations/*/clientConnectorServices/*}:setIamPolicy", "body": "*" }, { "post": "/v1/{resource=projects/*/locations/*/clientGateways/*}:setIamPolicy", "body": "*" } ] }
                    proto::ByteString.FromBase64("IkMvdjEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zLyovYXBwQ29ubmVjdGlvbnMvKn06c2V0SWFtUG9saWN5OgEqWkciQi92MS97cmVzb3VyY2U9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9hcHBDb25uZWN0b3JzLyp9OnNldElhbVBvbGljeToBKlpFIkAvdjEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zLyovYXBwR2F0ZXdheXMvKn06c2V0SWFtUG9saWN5OgEqWlEiTC92MS97cmVzb3VyY2U9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9jbGllbnRDb25uZWN0b3JTZXJ2aWNlcy8qfTpzZXRJYW1Qb2xpY3k6ASpaSCJDL3YxL3tyZXNvdXJjZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL2NsaWVudEdhdGV3YXlzLyp9OnNldElhbVBvbGljeToBKg==")
                },
                {
                    "google.iam.v1.IAMPolicy.TestIamPermissions",
                    // { "post": "/v1/{resource=projects/*/locations/*/appConnections/*}:testIamPermissions", "body": "*", "additionalBindings": [ { "post": "/v1/{resource=projects/*/locations/*/appConnectors/*}:testIamPermissions", "body": "*" }, { "post": "/v1/{resource=projects/*/locations/*/appGateways/*}:testIamPermissions", "body": "*" }, { "post": "/v1/{resource=projects/*/locations/*/clientConnectorServices/*}:testIamPermissions", "body": "*" }, { "post": "/v1/{resource=projects/*/locations/*/clientGateways/*}:testIamPermissions", "body": "*" } ] }
                    proto::ByteString.FromBase64("IkkvdjEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zLyovYXBwQ29ubmVjdGlvbnMvKn06dGVzdElhbVBlcm1pc3Npb25zOgEqWk0iSC92MS97cmVzb3VyY2U9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9hcHBDb25uZWN0b3JzLyp9OnRlc3RJYW1QZXJtaXNzaW9uczoBKlpLIkYvdjEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zLyovYXBwR2F0ZXdheXMvKn06dGVzdElhbVBlcm1pc3Npb25zOgEqWlciUi92MS97cmVzb3VyY2U9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9jbGllbnRDb25uZWN0b3JTZXJ2aWNlcy8qfTp0ZXN0SWFtUGVybWlzc2lvbnM6ASpaTiJJL3YxL3tyZXNvdXJjZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL2NsaWVudEdhdGV3YXlzLyp9OnRlc3RJYW1QZXJtaXNzaW9uczoBKg==")
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
            yield return AppConnectorInstanceConfigReflection.Descriptor;
            yield return AppConnectorsServiceReflection.Descriptor;
            yield return ResourceInfoReflection.Descriptor;
            yield return gciv::IamPolicyReflection.Descriptor;
            yield return gciv::OptionsReflection.Descriptor;
            yield return gciv::PolicyReflection.Descriptor;
            yield return gcl::LocationsReflection.Descriptor;
            yield return lro::OperationsReflection.Descriptor;
        }
    }
}
