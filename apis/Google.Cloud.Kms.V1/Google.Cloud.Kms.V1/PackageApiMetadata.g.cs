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
using proto = Google.Protobuf;
using gpr = Google.Protobuf.Reflection;
using scg = System.Collections.Generic;

namespace Google.Cloud.Kms.V1
{
    /// <summary>Static class to provide common access to package-wide API metadata.</summary>
    internal static class PackageApiMetadata
    {
        /// <summary>The <see cref="gaxgrpc::ApiMetadata"/> for services in this package.</summary>
        internal static gaxgrpc::ApiMetadata ApiMetadata { get; } = new gaxgrpc::ApiMetadata("Google.Cloud.Kms.V1", GetFileDescriptors)
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
                    // { "get": "/v1/{resource=projects/*/locations/*/keyRings/*}:getIamPolicy", "additionalBindings": [ { "get": "/v1/{resource=projects/*/locations/*/keyRings/*/cryptoKeys/*}:getIamPolicy" }, { "get": "/v1/{resource=projects/*/locations/*/keyRings/*/importJobs/*}:getIamPolicy" }, { "get": "/v1/{resource=projects/*/locations/*/ekmConnections/*}:getIamPolicy" } ] }
                    proto::ByteString.FromBase64("Ej0vdjEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zLyova2V5UmluZ3MvKn06Z2V0SWFtUG9saWN5WkwSSi92MS97cmVzb3VyY2U9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9rZXlSaW5ncy8qL2NyeXB0b0tleXMvKn06Z2V0SWFtUG9saWN5WkwSSi92MS97cmVzb3VyY2U9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9rZXlSaW5ncy8qL2ltcG9ydEpvYnMvKn06Z2V0SWFtUG9saWN5WkUSQy92MS97cmVzb3VyY2U9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9la21Db25uZWN0aW9ucy8qfTpnZXRJYW1Qb2xpY3k=")
                },
                {
                    "google.iam.v1.IAMPolicy.SetIamPolicy",
                    // { "post": "/v1/{resource=projects/*/locations/*/keyRings/*}:setIamPolicy", "body": "*", "additionalBindings": [ { "post": "/v1/{resource=projects/*/locations/*/keyRings/*/cryptoKeys/*}:setIamPolicy", "body": "*" }, { "post": "/v1/{resource=projects/*/locations/*/keyRings/*/importJobs/*}:setIamPolicy", "body": "*" }, { "post": "/v1/{resource=projects/*/locations/*/ekmConnections/*}:setIamPolicy", "body": "*" } ] }
                    proto::ByteString.FromBase64("Ij0vdjEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zLyova2V5UmluZ3MvKn06c2V0SWFtUG9saWN5OgEqWk8iSi92MS97cmVzb3VyY2U9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9rZXlSaW5ncy8qL2NyeXB0b0tleXMvKn06c2V0SWFtUG9saWN5OgEqWk8iSi92MS97cmVzb3VyY2U9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9rZXlSaW5ncy8qL2ltcG9ydEpvYnMvKn06c2V0SWFtUG9saWN5OgEqWkgiQy92MS97cmVzb3VyY2U9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9la21Db25uZWN0aW9ucy8qfTpzZXRJYW1Qb2xpY3k6ASo=")
                },
                {
                    "google.iam.v1.IAMPolicy.TestIamPermissions",
                    // { "post": "/v1/{resource=projects/*/locations/*/keyRings/*}:testIamPermissions", "body": "*", "additionalBindings": [ { "post": "/v1/{resource=projects/*/locations/*/keyRings/*/cryptoKeys/*}:testIamPermissions", "body": "*" }, { "post": "/v1/{resource=projects/*/locations/*/keyRings/*/importJobs/*}:testIamPermissions", "body": "*" }, { "post": "/v1/{resource=projects/*/locations/*/ekmConnections/*}:testIamPermissions", "body": "*" } ] }
                    proto::ByteString.FromBase64("IkMvdjEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zLyova2V5UmluZ3MvKn06dGVzdElhbVBlcm1pc3Npb25zOgEqWlUiUC92MS97cmVzb3VyY2U9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9rZXlSaW5ncy8qL2NyeXB0b0tleXMvKn06dGVzdElhbVBlcm1pc3Npb25zOgEqWlUiUC92MS97cmVzb3VyY2U9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9rZXlSaW5ncy8qL2ltcG9ydEpvYnMvKn06dGVzdElhbVBlcm1pc3Npb25zOgEqWk4iSS92MS97cmVzb3VyY2U9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9la21Db25uZWN0aW9ucy8qfTp0ZXN0SWFtUGVybWlzc2lvbnM6ASo=")
                },
            });

        private static scg::IEnumerable<gpr::FileDescriptor> GetFileDescriptors()
        {
            yield return gciv::IamPolicyReflection.Descriptor;
            yield return gciv::OptionsReflection.Descriptor;
            yield return gciv::PolicyReflection.Descriptor;
            yield return EkmServiceReflection.Descriptor;
            yield return ResourcesReflection.Descriptor;
            yield return ServiceReflection.Descriptor;
            yield return gcl::LocationsReflection.Descriptor;
        }
    }
}
