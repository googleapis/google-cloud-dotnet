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

namespace Google.Cloud.NetworkConnectivity.V1Beta
{
    /// <summary>Static class to provide common access to package-wide API metadata.</summary>
    internal static class PackageApiMetadata
    {
        /// <summary>The <see cref="gaxgrpc::ApiMetadata"/> for services in this package.</summary>
        internal static gaxgrpc::ApiMetadata ApiMetadata { get; } = new gaxgrpc::ApiMetadata("Google.Cloud.NetworkConnectivity.V1Beta", GetFileDescriptors)
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
                    // { "get": "/v1beta/{resource=projects/*/locations/global/hubs/*}:getIamPolicy", "additionalBindings": [ { "get": "/v1beta/{resource=projects/*/locations/global/hubs/*/groups/*}:getIamPolicy" }, { "get": "/v1beta/{resource=projects/*/locations/*/spokes/*}:getIamPolicy" }, { "get": "/v1beta/{resource=projects/*/locations/global/policyBasedRoutes/*}:getIamPolicy" } ] }
                    proto::ByteString.FromBase64("EkIvdjFiZXRhL3tyZXNvdXJjZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy9nbG9iYWwvaHVicy8qfTpnZXRJYW1Qb2xpY3laTRJLL3YxYmV0YS97cmVzb3VyY2U9cHJvamVjdHMvKi9sb2NhdGlvbnMvZ2xvYmFsL2h1YnMvKi9ncm91cHMvKn06Z2V0SWFtUG9saWN5WkESPy92MWJldGEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zLyovc3Bva2VzLyp9OmdldElhbVBvbGljeVpREk8vdjFiZXRhL3tyZXNvdXJjZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy9nbG9iYWwvcG9saWN5QmFzZWRSb3V0ZXMvKn06Z2V0SWFtUG9saWN5")
                },
                {
                    "google.iam.v1.IAMPolicy.SetIamPolicy",
                    // { "post": "/v1beta/{resource=projects/*/locations/global/hubs/*}:setIamPolicy", "body": "*", "additionalBindings": [ { "post": "/v1beta/{resource=projects/*/locations/global/hubs/*/groups/*}:setIamPolicy", "body": "*" }, { "post": "/v1beta/{resource=projects/*/locations/*/spokes/*}:setIamPolicy", "body": "*" }, { "post": "/v1beta/{resource=projects/*/locations/global/policyBasedRoutes/*}:setIamPolicy", "body": "*" } ] }
                    proto::ByteString.FromBase64("IkIvdjFiZXRhL3tyZXNvdXJjZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy9nbG9iYWwvaHVicy8qfTpzZXRJYW1Qb2xpY3k6ASpaUCJLL3YxYmV0YS97cmVzb3VyY2U9cHJvamVjdHMvKi9sb2NhdGlvbnMvZ2xvYmFsL2h1YnMvKi9ncm91cHMvKn06c2V0SWFtUG9saWN5OgEqWkQiPy92MWJldGEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zLyovc3Bva2VzLyp9OnNldElhbVBvbGljeToBKlpUIk8vdjFiZXRhL3tyZXNvdXJjZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy9nbG9iYWwvcG9saWN5QmFzZWRSb3V0ZXMvKn06c2V0SWFtUG9saWN5OgEq")
                },
                {
                    "google.iam.v1.IAMPolicy.TestIamPermissions",
                    // { "post": "/v1beta/{resource=projects/*/locations/global/hubs/*}:testIamPermissions", "body": "*", "additionalBindings": [ { "post": "/v1beta/{resource=projects/*/locations/global/hubs/*/groups/*}:testIamPermissions", "body": "*" }, { "post": "/v1beta/{resource=projects/*/locations/*/spokes/*}:testIamPermissions", "body": "*" }, { "post": "/v1beta/{resource=projects/*/locations/global/policyBasedRoutes/*}:testIamPermissions", "body": "*" } ] }
                    proto::ByteString.FromBase64("IkgvdjFiZXRhL3tyZXNvdXJjZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy9nbG9iYWwvaHVicy8qfTp0ZXN0SWFtUGVybWlzc2lvbnM6ASpaViJRL3YxYmV0YS97cmVzb3VyY2U9cHJvamVjdHMvKi9sb2NhdGlvbnMvZ2xvYmFsL2h1YnMvKi9ncm91cHMvKn06dGVzdElhbVBlcm1pc3Npb25zOgEqWkoiRS92MWJldGEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zLyovc3Bva2VzLyp9OnRlc3RJYW1QZXJtaXNzaW9uczoBKlpaIlUvdjFiZXRhL3tyZXNvdXJjZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy9nbG9iYWwvcG9saWN5QmFzZWRSb3V0ZXMvKn06dGVzdElhbVBlcm1pc3Npb25zOgEq")
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
            yield return CommonReflection.Descriptor;
            yield return DataTransferReflection.Descriptor;
            yield return HubReflection.Descriptor;
            yield return PolicyBasedRoutingReflection.Descriptor;
            yield return TransportManagerReflection.Descriptor;
            yield return lro::OperationsReflection.Descriptor;
        }
    }
}
