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

namespace Google.Cloud.Workstations.V1
{
    /// <summary>Static class to provide common access to package-wide API metadata.</summary>
    internal static class PackageApiMetadata
    {
        /// <summary>The <see cref="gaxgrpc::ApiMetadata"/> for services in this package.</summary>
        internal static gaxgrpc::ApiMetadata ApiMetadata { get; } = new gaxgrpc::ApiMetadata("Google.Cloud.Workstations.V1", GetFileDescriptors)
            .WithRequestNumericEnumJsonEncoding(true)
            .WithHttpRuleOverrides(new scg::Dictionary<string, proto::ByteString>
            {
                {
                    "google.iam.v1.IAMPolicy.GetIamPolicy",
                    // { "get": "/v1/{resource=projects/*/locations/*/workstationClusters/*/workstationConfigs/*}:getIamPolicy", "additionalBindings": [ { "get": "/v1/{resource=projects/*/locations/*/workstationClusters/*/workstationConfigs/*/workstations/*}:getIamPolicy" } ] }
                    proto::ByteString.FromBase64("El0vdjEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zLyovd29ya3N0YXRpb25DbHVzdGVycy8qL3dvcmtzdGF0aW9uQ29uZmlncy8qfTpnZXRJYW1Qb2xpY3labhJsL3YxL3tyZXNvdXJjZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL3dvcmtzdGF0aW9uQ2x1c3RlcnMvKi93b3Jrc3RhdGlvbkNvbmZpZ3MvKi93b3Jrc3RhdGlvbnMvKn06Z2V0SWFtUG9saWN5")
                },
                {
                    "google.iam.v1.IAMPolicy.SetIamPolicy",
                    // { "post": "/v1/{resource=projects/*/locations/*/workstationClusters/*/workstationConfigs/*}:setIamPolicy", "body": "*", "additionalBindings": [ { "post": "/v1/{resource=projects/*/locations/*/workstationClusters/*/workstationConfigs/*/workstations/*}:setIamPolicy", "body": "*" } ] }
                    proto::ByteString.FromBase64("Il0vdjEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zLyovd29ya3N0YXRpb25DbHVzdGVycy8qL3dvcmtzdGF0aW9uQ29uZmlncy8qfTpzZXRJYW1Qb2xpY3k6ASpacSJsL3YxL3tyZXNvdXJjZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL3dvcmtzdGF0aW9uQ2x1c3RlcnMvKi93b3Jrc3RhdGlvbkNvbmZpZ3MvKi93b3Jrc3RhdGlvbnMvKn06c2V0SWFtUG9saWN5OgEq")
                },
                {
                    "google.iam.v1.IAMPolicy.TestIamPermissions",
                    // { "post": "/v1/{resource=projects/*/locations/*/workstationClusters/*/workstationConfigs/*}:testIamPermissions", "body": "*", "additionalBindings": [ { "post": "/v1/{resource=projects/*/locations/*/workstationClusters/*/workstationConfigs/*/workstations/*}:testIamPermissions", "body": "*" } ] }
                    proto::ByteString.FromBase64("ImMvdjEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zLyovd29ya3N0YXRpb25DbHVzdGVycy8qL3dvcmtzdGF0aW9uQ29uZmlncy8qfTp0ZXN0SWFtUGVybWlzc2lvbnM6ASpadyJyL3YxL3tyZXNvdXJjZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL3dvcmtzdGF0aW9uQ2x1c3RlcnMvKi93b3Jrc3RhdGlvbkNvbmZpZ3MvKi93b3Jrc3RhdGlvbnMvKn06dGVzdElhbVBlcm1pc3Npb25zOgEq")
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
            yield return WorkstationsReflection.Descriptor;
            yield return lro::OperationsReflection.Descriptor;
        }
    }
}
