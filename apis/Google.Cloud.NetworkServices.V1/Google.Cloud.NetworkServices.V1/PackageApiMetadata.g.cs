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

namespace Google.Cloud.NetworkServices.V1
{
    /// <summary>Static class to provide common access to package-wide API metadata.</summary>
    internal static class PackageApiMetadata
    {
        /// <summary>The <see cref="gaxgrpc::ApiMetadata"/> for services in this package.</summary>
        internal static gaxgrpc::ApiMetadata ApiMetadata { get; } = new gaxgrpc::ApiMetadata("Google.Cloud.NetworkServices.V1", GetFileDescriptors)
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
                    // { "get": "/v1/{resource=projects/*/locations/*/edgeCacheKeysets/*}:getIamPolicy", "additionalBindings": [ { "get": "/v1/{resource=projects/*/locations/*/edgeCacheOrigins/*}:getIamPolicy" }, { "get": "/v1/{resource=projects/*/locations/*/edgeCacheServices/*}:getIamPolicy" }, { "get": "/v1/{resource=projects/*/locations/*/endpointPolicies/*}:getIamPolicy" }, { "get": "/v1/{resource=projects/*/locations/*/serviceBindings/*}:getIamPolicy" }, { "get": "/v1/{resource=projects/*/locations/*/meshes/*}:getIamPolicy" }, { "get": "/v1/{resource=projects/*/locations/*/gateways/*}:getIamPolicy" } ] }
                    proto::ByteString.FromBase64("EkUvdjEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zLyovZWRnZUNhY2hlS2V5c2V0cy8qfTpnZXRJYW1Qb2xpY3laRxJFL3YxL3tyZXNvdXJjZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL2VkZ2VDYWNoZU9yaWdpbnMvKn06Z2V0SWFtUG9saWN5WkgSRi92MS97cmVzb3VyY2U9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9lZGdlQ2FjaGVTZXJ2aWNlcy8qfTpnZXRJYW1Qb2xpY3laRxJFL3YxL3tyZXNvdXJjZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL2VuZHBvaW50UG9saWNpZXMvKn06Z2V0SWFtUG9saWN5WkYSRC92MS97cmVzb3VyY2U9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9zZXJ2aWNlQmluZGluZ3MvKn06Z2V0SWFtUG9saWN5Wj0SOy92MS97cmVzb3VyY2U9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9tZXNoZXMvKn06Z2V0SWFtUG9saWN5Wj8SPS92MS97cmVzb3VyY2U9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9nYXRld2F5cy8qfTpnZXRJYW1Qb2xpY3k=")
                },
                {
                    "google.iam.v1.IAMPolicy.SetIamPolicy",
                    // { "post": "/v1/{resource=projects/*/locations/*/edgeCacheKeysets/*}:setIamPolicy", "body": "*", "additionalBindings": [ { "post": "/v1/{resource=projects/*/locations/*/edgeCacheOrigins/*}:setIamPolicy", "body": "*" }, { "post": "/v1/{resource=projects/*/locations/*/edgeCacheServices/*}:setIamPolicy", "body": "*" }, { "post": "/v1/{resource=projects/*/locations/*/endpointPolicies/*}:setIamPolicy", "body": "*" }, { "post": "/v1/{resource=projects/*/locations/*/serviceBindings/*}:setIamPolicy", "body": "*" }, { "post": "/v1/{resource=projects/*/locations/*/meshes/*}:setIamPolicy", "body": "*" }, { "post": "/v1/{resource=projects/*/locations/*/gateways/*}:setIamPolicy", "body": "*" } ] }
                    proto::ByteString.FromBase64("IkUvdjEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zLyovZWRnZUNhY2hlS2V5c2V0cy8qfTpzZXRJYW1Qb2xpY3k6ASpaSiJFL3YxL3tyZXNvdXJjZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL2VkZ2VDYWNoZU9yaWdpbnMvKn06c2V0SWFtUG9saWN5OgEqWksiRi92MS97cmVzb3VyY2U9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9lZGdlQ2FjaGVTZXJ2aWNlcy8qfTpzZXRJYW1Qb2xpY3k6ASpaSiJFL3YxL3tyZXNvdXJjZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL2VuZHBvaW50UG9saWNpZXMvKn06c2V0SWFtUG9saWN5OgEqWkkiRC92MS97cmVzb3VyY2U9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9zZXJ2aWNlQmluZGluZ3MvKn06c2V0SWFtUG9saWN5OgEqWkAiOy92MS97cmVzb3VyY2U9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9tZXNoZXMvKn06c2V0SWFtUG9saWN5OgEqWkIiPS92MS97cmVzb3VyY2U9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9nYXRld2F5cy8qfTpzZXRJYW1Qb2xpY3k6ASo=")
                },
                {
                    "google.iam.v1.IAMPolicy.TestIamPermissions",
                    // { "post": "/v1/{resource=projects/*/locations/*/edgeCacheKeysets/*}:testIamPermissions", "body": "*", "additionalBindings": [ { "post": "/v1/{resource=projects/*/locations/*/edgeCacheOrigins/*}:testIamPermissions", "body": "*" }, { "post": "/v1/{resource=projects/*/locations/*/edgeCacheServices/*}:testIamPermissions", "body": "*" }, { "post": "/v1/{resource=projects/*/locations/*/endpointPolicies/*}:testIamPermissions", "body": "*" }, { "post": "/v1/{resource=projects/*/locations/*/serviceBindings/*}:testIamPermissions", "body": "*" }, { "post": "/v1/{resource=projects/*/locations/*/meshes/*}:testIamPermissions", "body": "*" }, { "post": "/v1/{resource=projects/*/locations/*/gateways/*}:testIamPermissions", "body": "*" } ] }
                    proto::ByteString.FromBase64("IksvdjEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zLyovZWRnZUNhY2hlS2V5c2V0cy8qfTp0ZXN0SWFtUGVybWlzc2lvbnM6ASpaUCJLL3YxL3tyZXNvdXJjZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL2VkZ2VDYWNoZU9yaWdpbnMvKn06dGVzdElhbVBlcm1pc3Npb25zOgEqWlEiTC92MS97cmVzb3VyY2U9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9lZGdlQ2FjaGVTZXJ2aWNlcy8qfTp0ZXN0SWFtUGVybWlzc2lvbnM6ASpaUCJLL3YxL3tyZXNvdXJjZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL2VuZHBvaW50UG9saWNpZXMvKn06dGVzdElhbVBlcm1pc3Npb25zOgEqWk8iSi92MS97cmVzb3VyY2U9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9zZXJ2aWNlQmluZGluZ3MvKn06dGVzdElhbVBlcm1pc3Npb25zOgEqWkYiQS92MS97cmVzb3VyY2U9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9tZXNoZXMvKn06dGVzdElhbVBlcm1pc3Npb25zOgEqWkgiQy92MS97cmVzb3VyY2U9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9nYXRld2F5cy8qfTp0ZXN0SWFtUGVybWlzc2lvbnM6ASo=")
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
            yield return DepReflection.Descriptor;
            yield return EndpointPolicyReflection.Descriptor;
            yield return ExtensibilityReflection.Descriptor;
            yield return GatewayReflection.Descriptor;
            yield return GrpcRouteReflection.Descriptor;
            yield return HttpRouteReflection.Descriptor;
            yield return MeshReflection.Descriptor;
            yield return NetworkServicesReflection.Descriptor;
            yield return RouteViewReflection.Descriptor;
            yield return ServiceBindingReflection.Descriptor;
            yield return ServiceLbPolicyReflection.Descriptor;
            yield return TcpRouteReflection.Descriptor;
            yield return TlsRouteReflection.Descriptor;
            yield return lro::OperationsReflection.Descriptor;
        }
    }
}
