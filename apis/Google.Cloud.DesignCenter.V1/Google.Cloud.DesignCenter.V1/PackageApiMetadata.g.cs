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

namespace Google.Cloud.DesignCenter.V1
{
    /// <summary>Static class to provide common access to package-wide API metadata.</summary>
    internal static class PackageApiMetadata
    {
        /// <summary>The <see cref="gaxgrpc::ApiMetadata"/> for services in this package.</summary>
        internal static gaxgrpc::ApiMetadata ApiMetadata { get; } = new gaxgrpc::ApiMetadata("Google.Cloud.DesignCenter.V1", GetFileDescriptors)
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
                    // { "get": "/v1/{resource=projects/*/locations/*/spaces/*}:getIamPolicy" }
                    proto::ByteString.FromBase64("EjsvdjEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zLyovc3BhY2VzLyp9OmdldElhbVBvbGljeQ==")
                },
                {
                    "google.iam.v1.IAMPolicy.SetIamPolicy",
                    // { "post": "/v1/{resource=projects/*/locations/*/spaces/*}:setIamPolicy", "body": "*" }
                    proto::ByteString.FromBase64("IjsvdjEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zLyovc3BhY2VzLyp9OnNldElhbVBvbGljeToBKg==")
                },
                {
                    "google.iam.v1.IAMPolicy.TestIamPermissions",
                    // { "post": "/v1/{resource=projects/*/locations/*/spaces/*}:testIamPermissions", "body": "*" }
                    proto::ByteString.FromBase64("IkEvdjEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zLyovc3BhY2VzLyp9OnRlc3RJYW1QZXJtaXNzaW9uczoBKg==")
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
            yield return ApphubIntegrationReflection.Descriptor;
            yield return ApphubIntegrationMessagesReflection.Descriptor;
            yield return AssessmentReflection.Descriptor;
            yield return AuthoringReflection.Descriptor;
            yield return AuthoringMessagesReflection.Descriptor;
            yield return BestPracticesReflection.Descriptor;
            yield return BestPracticesMessagesReflection.Descriptor;
            yield return CatalogManagementReflection.Descriptor;
            yield return CatalogManagementMessagesReflection.Descriptor;
            yield return DeploymentReflection.Descriptor;
            yield return DeploymentMessagesReflection.Descriptor;
            yield return DeploymentResourcesReflection.Descriptor;
            yield return DesigncenterReflection.Descriptor;
            yield return EnumsReflection.Descriptor;
            yield return ExportReflection.Descriptor;
            yield return IacReflection.Descriptor;
            yield return IngestionReflection.Descriptor;
            yield return MetadataReflection.Descriptor;
            yield return ParametersReflection.Descriptor;
            yield return SharingReflection.Descriptor;
            yield return SharingMessagesReflection.Descriptor;
            yield return gciv::IamPolicyReflection.Descriptor;
            yield return gciv::OptionsReflection.Descriptor;
            yield return gciv::PolicyReflection.Descriptor;
            yield return gcl::LocationsReflection.Descriptor;
            yield return lro::OperationsReflection.Descriptor;
        }
    }
}
