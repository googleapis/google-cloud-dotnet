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

namespace Google.Cloud.NetworkConnectivity.V1
{
    /// <summary>Static class to provide common access to package-wide API metadata.</summary>
    internal static class PackageApiMetadata
    {
        /// <summary>The <see cref="gaxgrpc::ApiMetadata"/> for services in this package.</summary>
        internal static gaxgrpc::ApiMetadata ApiMetadata { get; } = new gaxgrpc::ApiMetadata("Google.Cloud.NetworkConnectivity.V1", GetFileDescriptors)
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
                    // { "get": "/v1/{resource=projects/*/locations/global/hubs/*}:getIamPolicy", "additionalBindings": [ { "get": "/v1/{resource=projects/*/locations/global/hubs/*/groups/*}:getIamPolicy" }, { "get": "/v1/{resource=projects/*/locations/*/spokes/*}:getIamPolicy" }, { "get": "/v1/{resource=projects/*/locations/global/policyBasedRoutes/*}:getIamPolicy" }, { "get": "/v1/{resource=projects/*/locations/*/serviceConnectionMaps/*}:getIamPolicy" }, { "get": "/v1/{resource=projects/*/locations/*/serviceConnectionPolicies/*}:getIamPolicy" }, { "get": "/v1/{resource=projects/*/locations/*/serviceClasses/*}:getIamPolicy" } ] }
                    proto::ByteString.FromBase64("Ej4vdjEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zL2dsb2JhbC9odWJzLyp9OmdldElhbVBvbGljeVpJEkcvdjEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zL2dsb2JhbC9odWJzLyovZ3JvdXBzLyp9OmdldElhbVBvbGljeVo9EjsvdjEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zLyovc3Bva2VzLyp9OmdldElhbVBvbGljeVpNEksvdjEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zL2dsb2JhbC9wb2xpY3lCYXNlZFJvdXRlcy8qfTpnZXRJYW1Qb2xpY3laTBJKL3YxL3tyZXNvdXJjZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL3NlcnZpY2VDb25uZWN0aW9uTWFwcy8qfTpnZXRJYW1Qb2xpY3laUBJOL3YxL3tyZXNvdXJjZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL3NlcnZpY2VDb25uZWN0aW9uUG9saWNpZXMvKn06Z2V0SWFtUG9saWN5WkUSQy92MS97cmVzb3VyY2U9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9zZXJ2aWNlQ2xhc3Nlcy8qfTpnZXRJYW1Qb2xpY3k=")
                },
                {
                    "google.iam.v1.IAMPolicy.SetIamPolicy",
                    // { "post": "/v1/{resource=projects/*/locations/global/hubs/*}:setIamPolicy", "body": "*", "additionalBindings": [ { "post": "/v1/{resource=projects/*/locations/global/hubs/*/groups/*}:setIamPolicy", "body": "*" }, { "post": "/v1/{resource=projects/*/locations/*/spokes/*}:setIamPolicy", "body": "*" }, { "post": "/v1/{resource=projects/*/locations/global/policyBasedRoutes/*}:setIamPolicy", "body": "*" }, { "post": "/v1/{resource=projects/*/locations/*/serviceConnectionMaps/*}:setIamPolicy", "body": "*" }, { "post": "/v1/{resource=projects/*/locations/*/serviceConnectionPolicies/*}:setIamPolicy", "body": "*" }, { "post": "/v1/{resource=projects/*/locations/*/serviceClasses/*}:setIamPolicy", "body": "*" } ] }
                    proto::ByteString.FromBase64("Ij4vdjEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zL2dsb2JhbC9odWJzLyp9OnNldElhbVBvbGljeToBKlpMIkcvdjEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zL2dsb2JhbC9odWJzLyovZ3JvdXBzLyp9OnNldElhbVBvbGljeToBKlpAIjsvdjEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zLyovc3Bva2VzLyp9OnNldElhbVBvbGljeToBKlpQIksvdjEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zL2dsb2JhbC9wb2xpY3lCYXNlZFJvdXRlcy8qfTpzZXRJYW1Qb2xpY3k6ASpaTyJKL3YxL3tyZXNvdXJjZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL3NlcnZpY2VDb25uZWN0aW9uTWFwcy8qfTpzZXRJYW1Qb2xpY3k6ASpaUyJOL3YxL3tyZXNvdXJjZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL3NlcnZpY2VDb25uZWN0aW9uUG9saWNpZXMvKn06c2V0SWFtUG9saWN5OgEqWkgiQy92MS97cmVzb3VyY2U9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9zZXJ2aWNlQ2xhc3Nlcy8qfTpzZXRJYW1Qb2xpY3k6ASo=")
                },
                {
                    "google.iam.v1.IAMPolicy.TestIamPermissions",
                    // { "post": "/v1/{resource=projects/*/locations/global/hubs/*}:testIamPermissions", "body": "*", "additionalBindings": [ { "post": "/v1/{resource=projects/*/locations/global/hubs/*/groups/*}:testIamPermissions", "body": "*" }, { "post": "/v1/{resource=projects/*/locations/*/spokes/*}:testIamPermissions", "body": "*" }, { "post": "/v1/{resource=projects/*/locations/global/policyBasedRoutes/*}:testIamPermissions", "body": "*" }, { "post": "/v1/{resource=projects/*/locations/*/serviceConnectionMaps/*}:testIamPermissions", "body": "*" }, { "post": "/v1/{resource=projects/*/locations/*/serviceConnectionPolicies/*}:testIamPermissions", "body": "*" }, { "post": "/v1/{resource=projects/*/locations/*/serviceClasses/*}:testIamPermissions", "body": "*" } ] }
                    proto::ByteString.FromBase64("IkQvdjEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zL2dsb2JhbC9odWJzLyp9OnRlc3RJYW1QZXJtaXNzaW9uczoBKlpSIk0vdjEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zL2dsb2JhbC9odWJzLyovZ3JvdXBzLyp9OnRlc3RJYW1QZXJtaXNzaW9uczoBKlpGIkEvdjEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zLyovc3Bva2VzLyp9OnRlc3RJYW1QZXJtaXNzaW9uczoBKlpWIlEvdjEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zL2dsb2JhbC9wb2xpY3lCYXNlZFJvdXRlcy8qfTp0ZXN0SWFtUGVybWlzc2lvbnM6ASpaVSJQL3YxL3tyZXNvdXJjZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL3NlcnZpY2VDb25uZWN0aW9uTWFwcy8qfTp0ZXN0SWFtUGVybWlzc2lvbnM6ASpaWSJUL3YxL3tyZXNvdXJjZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL3NlcnZpY2VDb25uZWN0aW9uUG9saWNpZXMvKn06dGVzdElhbVBlcm1pc3Npb25zOgEqWk4iSS92MS97cmVzb3VyY2U9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9zZXJ2aWNlQ2xhc3Nlcy8qfTp0ZXN0SWFtUGVybWlzc2lvbnM6ASo=")
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
            yield return CommonReflection.Descriptor;
            yield return CrossNetworkAutomationReflection.Descriptor;
            yield return HubReflection.Descriptor;
            yield return PolicyBasedRoutingReflection.Descriptor;
            yield return lro::OperationsReflection.Descriptor;
        }
    }
}
