// Copyright 2026 Google LLC
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

namespace Google.Cloud.NetworkSecurity.V1
{
    /// <summary>Static class to provide common access to package-wide API metadata.</summary>
    internal static class PackageApiMetadata
    {
        /// <summary>The <see cref="gaxgrpc::ApiMetadata"/> for services in this package.</summary>
        internal static gaxgrpc::ApiMetadata ApiMetadata { get; } = new gaxgrpc::ApiMetadata("Google.Cloud.NetworkSecurity.V1", GetFileDescriptors)
            .WithRequestNumericEnumJsonEncoding(true)
            .WithHttpRuleOverrides(new scg::Dictionary<string, proto::ByteString>
            {
                {
                    "google.cloud.location.Locations.GetLocation",
                    // { "get": "/v1/{name=projects/*/locations/*}", "additionalBindings": [ { "get": "/v1/{name=organizations/*/locations/*}" } ] }
                    proto::ByteString.FromBase64("EiEvdjEve25hbWU9cHJvamVjdHMvKi9sb2NhdGlvbnMvKn1aKBImL3YxL3tuYW1lPW9yZ2FuaXphdGlvbnMvKi9sb2NhdGlvbnMvKn0=")
                },
                {
                    "google.cloud.location.Locations.ListLocations",
                    // { "get": "/v1/{name=projects/*}/locations", "additionalBindings": [ { "get": "/v1/{name=organizations/*}/locations" } ] }
                    proto::ByteString.FromBase64("Eh8vdjEve25hbWU9cHJvamVjdHMvKn0vbG9jYXRpb25zWiYSJC92MS97bmFtZT1vcmdhbml6YXRpb25zLyp9L2xvY2F0aW9ucw==")
                },
                {
                    "google.iam.v1.IAMPolicy.GetIamPolicy",
                    // { "get": "/v1/{resource=projects/*/locations/*/addressGroups/*}:getIamPolicy", "additionalBindings": [ { "get": "/v1/{resource=projects/*/locations/*/authorizationPolicies/*}:getIamPolicy" }, { "get": "/v1/{resource=projects/*/locations/*/serverTlsPolicies/*}:getIamPolicy" }, { "get": "/v1/{resource=projects/*/locations/*/clientTlsPolicies/*}:getIamPolicy" }, { "get": "/v1/{resource=projects/*/locations/*/authzPolicies/*}:getIamPolicy" } ] }
                    proto::ByteString.FromBase64("EkIvdjEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zLyovYWRkcmVzc0dyb3Vwcy8qfTpnZXRJYW1Qb2xpY3laTBJKL3YxL3tyZXNvdXJjZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL2F1dGhvcml6YXRpb25Qb2xpY2llcy8qfTpnZXRJYW1Qb2xpY3laSBJGL3YxL3tyZXNvdXJjZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL3NlcnZlclRsc1BvbGljaWVzLyp9OmdldElhbVBvbGljeVpIEkYvdjEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zLyovY2xpZW50VGxzUG9saWNpZXMvKn06Z2V0SWFtUG9saWN5WkQSQi92MS97cmVzb3VyY2U9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9hdXRoelBvbGljaWVzLyp9OmdldElhbVBvbGljeQ==")
                },
                {
                    "google.iam.v1.IAMPolicy.SetIamPolicy",
                    // { "post": "/v1/{resource=projects/*/locations/*/addressGroups/*}:setIamPolicy", "body": "*", "additionalBindings": [ { "post": "/v1/{resource=projects/*/locations/*/authorizationPolicies/*}:setIamPolicy", "body": "*" }, { "post": "/v1/{resource=projects/*/locations/*/serverTlsPolicies/*}:setIamPolicy", "body": "*" }, { "post": "/v1/{resource=projects/*/locations/*/clientTlsPolicies/*}:setIamPolicy", "body": "*" }, { "post": "/v1/{resource=projects/*/locations/*/authzPolicies/*}:setIamPolicy", "body": "*" } ] }
                    proto::ByteString.FromBase64("IkIvdjEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zLyovYWRkcmVzc0dyb3Vwcy8qfTpzZXRJYW1Qb2xpY3k6ASpaTyJKL3YxL3tyZXNvdXJjZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL2F1dGhvcml6YXRpb25Qb2xpY2llcy8qfTpzZXRJYW1Qb2xpY3k6ASpaSyJGL3YxL3tyZXNvdXJjZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL3NlcnZlclRsc1BvbGljaWVzLyp9OnNldElhbVBvbGljeToBKlpLIkYvdjEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zLyovY2xpZW50VGxzUG9saWNpZXMvKn06c2V0SWFtUG9saWN5OgEqWkciQi92MS97cmVzb3VyY2U9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9hdXRoelBvbGljaWVzLyp9OnNldElhbVBvbGljeToBKg==")
                },
                {
                    "google.iam.v1.IAMPolicy.TestIamPermissions",
                    // { "post": "/v1/{resource=projects/*/locations/*/addressGroups/*}:testIamPermissions", "body": "*", "additionalBindings": [ { "post": "/v1/{resource=organizations/*/locations/*/addressGroups/*}:testIamPermissions", "body": "*" }, { "post": "/v1/{resource=projects/*/locations/*/authorizationPolicies/*}:testIamPermissions", "body": "*" }, { "post": "/v1/{resource=projects/*/locations/*/serverTlsPolicies/*}:testIamPermissions", "body": "*" }, { "post": "/v1/{resource=projects/*/locations/*/clientTlsPolicies/*}:testIamPermissions", "body": "*" }, { "post": "/v1/{resource=projects/*/locations/*/authzPolicies/*}:testIamPermissions", "body": "*" } ] }
                    proto::ByteString.FromBase64("IkgvdjEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zLyovYWRkcmVzc0dyb3Vwcy8qfTp0ZXN0SWFtUGVybWlzc2lvbnM6ASpaUiJNL3YxL3tyZXNvdXJjZT1vcmdhbml6YXRpb25zLyovbG9jYXRpb25zLyovYWRkcmVzc0dyb3Vwcy8qfTp0ZXN0SWFtUGVybWlzc2lvbnM6ASpaVSJQL3YxL3tyZXNvdXJjZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL2F1dGhvcml6YXRpb25Qb2xpY2llcy8qfTp0ZXN0SWFtUGVybWlzc2lvbnM6ASpaUSJML3YxL3tyZXNvdXJjZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL3NlcnZlclRsc1BvbGljaWVzLyp9OnRlc3RJYW1QZXJtaXNzaW9uczoBKlpRIkwvdjEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zLyovY2xpZW50VGxzUG9saWNpZXMvKn06dGVzdElhbVBlcm1pc3Npb25zOgEqWk0iSC92MS97cmVzb3VyY2U9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9hdXRoelBvbGljaWVzLyp9OnRlc3RJYW1QZXJtaXNzaW9uczoBKg==")
                },
                {
                    "google.longrunning.Operations.CancelOperation",
                    // { "post": "/v1/{name=projects/*/locations/*/operations/*}:cancel", "body": "*", "additionalBindings": [ { "post": "/v1/{name=organizations/*/locations/*/operations/*}:cancel", "body": "*" } ] }
                    proto::ByteString.FromBase64("IjUvdjEve25hbWU9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9vcGVyYXRpb25zLyp9OmNhbmNlbDoBKlo/IjovdjEve25hbWU9b3JnYW5pemF0aW9ucy8qL2xvY2F0aW9ucy8qL29wZXJhdGlvbnMvKn06Y2FuY2VsOgEq")
                },
                {
                    "google.longrunning.Operations.DeleteOperation",
                    // { "delete": "/v1/{name=projects/*/locations/*/operations/*}", "additionalBindings": [ { "delete": "/v1/{name=organizations/*/locations/*/operations/*}" } ] }
                    proto::ByteString.FromBase64("Ki4vdjEve25hbWU9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9vcGVyYXRpb25zLyp9WjUqMy92MS97bmFtZT1vcmdhbml6YXRpb25zLyovbG9jYXRpb25zLyovb3BlcmF0aW9ucy8qfQ==")
                },
                {
                    "google.longrunning.Operations.GetOperation",
                    // { "get": "/v1/{name=projects/*/locations/*/operations/*}", "additionalBindings": [ { "get": "/v1/{name=organizations/*/locations/*/operations/*}" } ] }
                    proto::ByteString.FromBase64("Ei4vdjEve25hbWU9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9vcGVyYXRpb25zLyp9WjUSMy92MS97bmFtZT1vcmdhbml6YXRpb25zLyovbG9jYXRpb25zLyovb3BlcmF0aW9ucy8qfQ==")
                },
                {
                    "google.longrunning.Operations.ListOperations",
                    // { "get": "/v1/{name=projects/*/locations/*}/operations", "additionalBindings": [ { "get": "/v1/{name=organizations/*/locations/*}/operations" } ] }
                    proto::ByteString.FromBase64("EiwvdjEve25hbWU9cHJvamVjdHMvKi9sb2NhdGlvbnMvKn0vb3BlcmF0aW9uc1ozEjEvdjEve25hbWU9b3JnYW5pemF0aW9ucy8qL2xvY2F0aW9ucy8qfS9vcGVyYXRpb25z")
                },
            });

        private static scg::IEnumerable<gpr::FileDescriptor> GetFileDescriptors()
        {
            yield return gciv::IamPolicyReflection.Descriptor;
            yield return gciv::OptionsReflection.Descriptor;
            yield return gciv::PolicyReflection.Descriptor;
            yield return gcl::LocationsReflection.Descriptor;
            yield return AddressGroupReflection.Descriptor;
            yield return AuthorizationPolicyReflection.Descriptor;
            yield return AuthzPolicyReflection.Descriptor;
            yield return BackendAuthenticationConfigReflection.Descriptor;
            yield return ClientTlsPolicyReflection.Descriptor;
            yield return CommonReflection.Descriptor;
            yield return DnsThreatDetectorReflection.Descriptor;
            yield return FirewallActivationReflection.Descriptor;
            yield return GatewaySecurityPolicyReflection.Descriptor;
            yield return GatewaySecurityPolicyRuleReflection.Descriptor;
            yield return InterceptReflection.Descriptor;
            yield return MirroringReflection.Descriptor;
            yield return NetworkSecurityReflection.Descriptor;
            yield return SecurityProfileGroupReflection.Descriptor;
            yield return SecurityProfileGroupInterceptReflection.Descriptor;
            yield return SecurityProfileGroupMirroringReflection.Descriptor;
            yield return SecurityProfileGroupServiceReflection.Descriptor;
            yield return SecurityProfileGroupThreatpreventionReflection.Descriptor;
            yield return SecurityProfileGroupUrlfilteringReflection.Descriptor;
            yield return ServerTlsPolicyReflection.Descriptor;
            yield return SseRealmReflection.Descriptor;
            yield return TlsReflection.Descriptor;
            yield return TlsInspectionPolicyReflection.Descriptor;
            yield return UrlListReflection.Descriptor;
            yield return lro::OperationsReflection.Descriptor;
        }
    }
}
