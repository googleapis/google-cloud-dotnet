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
using proto = Google.Protobuf;
using scg = System.Collections.Generic;

namespace Google.Cloud.Dataform.V1Beta1
{
    /// <summary>Static class to provide common access to package-wide API metadata.</summary>
    internal static class PackageApiMetadata
    {
        /// <summary>The <see cref="gaxgrpc::ApiMetadata"/> for services in this package.</summary>
        internal static gaxgrpc::ApiMetadata ApiMetadata { get; } = new gaxgrpc::ApiMetadata("Google.Cloud.Dataform.V1Beta1", GetFileDescriptors)
            .WithRequestNumericEnumJsonEncoding(true)
            .WithHttpRuleOverrides(new scg::Dictionary<string, proto::ByteString>
            {
                {
                    "google.cloud.location.Locations.GetLocation",
                    // { "get": "/v1beta1/{name=projects/*/locations/*}" }
                    proto::ByteString.FromBase64("EiYvdjFiZXRhMS97bmFtZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qfQ==")
                },
                {
                    "google.cloud.location.Locations.ListLocations",
                    // { "get": "/v1beta1/{name=projects/*}/locations" }
                    proto::ByteString.FromBase64("EiQvdjFiZXRhMS97bmFtZT1wcm9qZWN0cy8qfS9sb2NhdGlvbnM=")
                },
                {
                    "google.iam.v1.IAMPolicy.GetIamPolicy",
                    // { "get": "/v1beta1/{resource=projects/*/locations/*/repositories/*}:getIamPolicy", "additionalBindings": [ { "get": "/v1beta1/{resource=projects/*/locations/*/collections/*}:getIamPolicy" }, { "get": "/v1beta1/{resource=projects/*/locations/*/repositories/*/workspaces/*}:getIamPolicy" } ] }
                    proto::ByteString.FromBase64("EkYvdjFiZXRhMS97cmVzb3VyY2U9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9yZXBvc2l0b3JpZXMvKn06Z2V0SWFtUG9saWN5WkcSRS92MWJldGExL3tyZXNvdXJjZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL2NvbGxlY3Rpb25zLyp9OmdldElhbVBvbGljeVpVElMvdjFiZXRhMS97cmVzb3VyY2U9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9yZXBvc2l0b3JpZXMvKi93b3Jrc3BhY2VzLyp9OmdldElhbVBvbGljeQ==")
                },
                {
                    "google.iam.v1.IAMPolicy.SetIamPolicy",
                    // { "post": "/v1beta1/{resource=projects/*/locations/*/repositories/*}:setIamPolicy", "body": "*", "additionalBindings": [ { "post": "/v1beta1/{resource=projects/*/locations/*/repositories/*/workspaces/*}:setIamPolicy", "body": "*" }, { "post": "/v1beta1/{resource=projects/*/locations/*/collections/*}:setIamPolicy", "body": "*" } ] }
                    proto::ByteString.FromBase64("IkYvdjFiZXRhMS97cmVzb3VyY2U9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9yZXBvc2l0b3JpZXMvKn06c2V0SWFtUG9saWN5OgEqWlgiUy92MWJldGExL3tyZXNvdXJjZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL3JlcG9zaXRvcmllcy8qL3dvcmtzcGFjZXMvKn06c2V0SWFtUG9saWN5OgEqWkoiRS92MWJldGExL3tyZXNvdXJjZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL2NvbGxlY3Rpb25zLyp9OnNldElhbVBvbGljeToBKg==")
                },
                {
                    "google.iam.v1.IAMPolicy.TestIamPermissions",
                    // { "post": "/v1beta1/{resource=projects/*/locations/*/repositories/*}:testIamPermissions", "body": "*", "additionalBindings": [ { "post": "/v1beta1/{resource=projects/*/locations/*/collections/*}:testIamPermissions", "body": "*" }, { "post": "/v1beta1/{resource=projects/*/locations/*/repositories/*/workspaces/*}:testIamPermissions", "body": "*" } ] }
                    proto::ByteString.FromBase64("IkwvdjFiZXRhMS97cmVzb3VyY2U9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9yZXBvc2l0b3JpZXMvKn06dGVzdElhbVBlcm1pc3Npb25zOgEqWlAiSy92MWJldGExL3tyZXNvdXJjZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL2NvbGxlY3Rpb25zLyp9OnRlc3RJYW1QZXJtaXNzaW9uczoBKlpeIlkvdjFiZXRhMS97cmVzb3VyY2U9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9yZXBvc2l0b3JpZXMvKi93b3Jrc3BhY2VzLyp9OnRlc3RJYW1QZXJtaXNzaW9uczoBKg==")
                },
            });

        private static scg::IEnumerable<gpr::FileDescriptor> GetFileDescriptors()
        {
            yield return DataformReflection.Descriptor;
            yield return gciv::IamPolicyReflection.Descriptor;
            yield return gciv::OptionsReflection.Descriptor;
            yield return gciv::PolicyReflection.Descriptor;
            yield return gcl::LocationsReflection.Descriptor;
        }
    }
}
