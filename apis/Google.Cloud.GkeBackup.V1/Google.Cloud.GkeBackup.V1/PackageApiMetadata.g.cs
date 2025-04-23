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

namespace Google.Cloud.GkeBackup.V1
{
    /// <summary>Static class to provide common access to package-wide API metadata.</summary>
    internal static class PackageApiMetadata
    {
        /// <summary>The <see cref="gaxgrpc::ApiMetadata"/> for services in this package.</summary>
        internal static gaxgrpc::ApiMetadata ApiMetadata { get; } = new gaxgrpc::ApiMetadata("Google.Cloud.GkeBackup.V1", GetFileDescriptors)
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
                    // { "get": "/v1/{resource=projects/*/locations/*/backupPlans/*}:getIamPolicy", "additionalBindings": [ { "get": "/v1/{resource=projects/*/locations/*/backupPlans/*/backups/*}:getIamPolicy" }, { "get": "/v1/{resource=projects/*/locations/*/backupPlans/*/backups/*/volumeBackups/*}:getIamPolicy" }, { "get": "/v1/{resource=projects/*/locations/*/restorePlans/*}:getIamPolicy" }, { "get": "/v1/{resource=projects/*/locations/*/restorePlans/*/restores/*}:getIamPolicy" }, { "get": "/v1/{resource=projects/*/locations/*/restorePlans/*/restores/*/volumeRestores/*}:getIamPolicy" } ] }
                    proto::ByteString.FromBase64("EkAvdjEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zLyovYmFja3VwUGxhbnMvKn06Z2V0SWFtUG9saWN5WkwSSi92MS97cmVzb3VyY2U9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9iYWNrdXBQbGFucy8qL2JhY2t1cHMvKn06Z2V0SWFtUG9saWN5WlwSWi92MS97cmVzb3VyY2U9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9iYWNrdXBQbGFucy8qL2JhY2t1cHMvKi92b2x1bWVCYWNrdXBzLyp9OmdldElhbVBvbGljeVpDEkEvdjEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zLyovcmVzdG9yZVBsYW5zLyp9OmdldElhbVBvbGljeVpOEkwvdjEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zLyovcmVzdG9yZVBsYW5zLyovcmVzdG9yZXMvKn06Z2V0SWFtUG9saWN5Wl8SXS92MS97cmVzb3VyY2U9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9yZXN0b3JlUGxhbnMvKi9yZXN0b3Jlcy8qL3ZvbHVtZVJlc3RvcmVzLyp9OmdldElhbVBvbGljeQ==")
                },
                {
                    "google.iam.v1.IAMPolicy.SetIamPolicy",
                    // { "post": "/v1/{resource=projects/*/locations/*/backupPlans/*}:setIamPolicy", "body": "*", "additionalBindings": [ { "post": "/v1/{resource=projects/*/locations/*/backupPlans/*/backups/*}:setIamPolicy", "body": "*" }, { "post": "/v1/{resource=projects/*/locations/*/backupPlans/*/backups/*/volumeBackups/*}:setIamPolicy", "body": "*" }, { "post": "/v1/{resource=projects/*/locations/*/restorePlans/*}:setIamPolicy", "body": "*" }, { "post": "/v1/{resource=projects/*/locations/*/restorePlans/*/restores/*}:setIamPolicy", "body": "*" }, { "post": "/v1/{resource=projects/*/locations/*/restorePlans/*/restores/*/volumeRestores/*}:setIamPolicy", "body": "*" } ] }
                    proto::ByteString.FromBase64("IkAvdjEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zLyovYmFja3VwUGxhbnMvKn06c2V0SWFtUG9saWN5OgEqWk8iSi92MS97cmVzb3VyY2U9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9iYWNrdXBQbGFucy8qL2JhY2t1cHMvKn06c2V0SWFtUG9saWN5OgEqWl8iWi92MS97cmVzb3VyY2U9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9iYWNrdXBQbGFucy8qL2JhY2t1cHMvKi92b2x1bWVCYWNrdXBzLyp9OnNldElhbVBvbGljeToBKlpGIkEvdjEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zLyovcmVzdG9yZVBsYW5zLyp9OnNldElhbVBvbGljeToBKlpRIkwvdjEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zLyovcmVzdG9yZVBsYW5zLyovcmVzdG9yZXMvKn06c2V0SWFtUG9saWN5OgEqWmIiXS92MS97cmVzb3VyY2U9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9yZXN0b3JlUGxhbnMvKi9yZXN0b3Jlcy8qL3ZvbHVtZVJlc3RvcmVzLyp9OnNldElhbVBvbGljeToBKg==")
                },
                {
                    "google.iam.v1.IAMPolicy.TestIamPermissions",
                    // { "post": "/v1/{resource=projects/*/locations/*/backupPlans/*}:testIamPermissions", "body": "*", "additionalBindings": [ { "post": "/v1/{resource=projects/*/locations/*/backupPlans/*/backups/*}:testIamPermissions", "body": "*" }, { "post": "/v1/{resource=projects/*/locations/*/backupPlans/*/backups/*/volumeBackups/*}:testIamPermissions", "body": "*" }, { "post": "/v1/{resource=projects/*/locations/*/restorePlans/*}:testIamPermissions", "body": "*" }, { "post": "/v1/{resource=projects/*/locations/*/restorePlans/*/restores/*}:testIamPermissions", "body": "*" }, { "post": "/v1/{resource=projects/*/locations/*/restorePlans/*/restores/*/volumeRestores/*}:testIamPermissions", "body": "*" } ] }
                    proto::ByteString.FromBase64("IkYvdjEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zLyovYmFja3VwUGxhbnMvKn06dGVzdElhbVBlcm1pc3Npb25zOgEqWlUiUC92MS97cmVzb3VyY2U9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9iYWNrdXBQbGFucy8qL2JhY2t1cHMvKn06dGVzdElhbVBlcm1pc3Npb25zOgEqWmUiYC92MS97cmVzb3VyY2U9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9iYWNrdXBQbGFucy8qL2JhY2t1cHMvKi92b2x1bWVCYWNrdXBzLyp9OnRlc3RJYW1QZXJtaXNzaW9uczoBKlpMIkcvdjEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zLyovcmVzdG9yZVBsYW5zLyp9OnRlc3RJYW1QZXJtaXNzaW9uczoBKlpXIlIvdjEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zLyovcmVzdG9yZVBsYW5zLyovcmVzdG9yZXMvKn06dGVzdElhbVBlcm1pc3Npb25zOgEqWmgiYy92MS97cmVzb3VyY2U9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9yZXN0b3JlUGxhbnMvKi9yZXN0b3Jlcy8qL3ZvbHVtZVJlc3RvcmVzLyp9OnRlc3RJYW1QZXJtaXNzaW9uczoBKg==")
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
            yield return BackupReflection.Descriptor;
            yield return BackupChannelReflection.Descriptor;
            yield return BackupPlanReflection.Descriptor;
            yield return BackupPlanBindingReflection.Descriptor;
            yield return CommonReflection.Descriptor;
            yield return GkebackupReflection.Descriptor;
            yield return RestoreReflection.Descriptor;
            yield return RestoreChannelReflection.Descriptor;
            yield return RestorePlanReflection.Descriptor;
            yield return RestorePlanBindingReflection.Descriptor;
            yield return VolumeReflection.Descriptor;
            yield return gciv::IamPolicyReflection.Descriptor;
            yield return gciv::OptionsReflection.Descriptor;
            yield return gciv::PolicyReflection.Descriptor;
            yield return gcl::LocationsReflection.Descriptor;
            yield return lro::OperationsReflection.Descriptor;
        }
    }
}
