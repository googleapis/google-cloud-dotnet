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

namespace Google.Cloud.VisionAI.V1
{
    /// <summary>Static class to provide common access to package-wide API metadata.</summary>
    internal static class PackageApiMetadata
    {
        /// <summary>The <see cref="gaxgrpc::ApiMetadata"/> for services in this package.</summary>
        internal static gaxgrpc::ApiMetadata ApiMetadata { get; } = new gaxgrpc::ApiMetadata("Google.Cloud.VisionAI.V1", GetFileDescriptors)
            .WithRequestNumericEnumJsonEncoding(true)
            .WithHttpRuleOverrides(new scg::Dictionary<string, proto::ByteString>
            {
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
                    // { "get": "/v1/{name=projects/*/locations/*/operations/*}", "additionalBindings": [ { "get": "/v1/{name=projects/*/locations/*/warehouseOperations/*}" }, { "get": "/v1/{name=projects/*/locations/*/corpora/*/assets/*/operations/*}" }, { "get": "/v1/{name=projects/*/locations/*/corpora/*/collections/*/operations/*}" }, { "get": "/v1/{name=projects/*/locations/*/corpora/*/imageIndexes/*/operations/*}" }, { "get": "/v1/{name=projects/*/locations/*/corpora/*/indexes/*/operations/*}" }, { "get": "/v1/{name=projects/*/locations/*/corpora/*/operations/*}" }, { "get": "/v1/{name=projects/*/locations/*/indexEndpoints/*/operations/*}" } ] }
                    proto::ByteString.FromBase64("Ei4vdjEve25hbWU9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9vcGVyYXRpb25zLyp9WjkSNy92MS97bmFtZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL3dhcmVob3VzZU9wZXJhdGlvbnMvKn1aQxJBL3YxL3tuYW1lPXByb2plY3RzLyovbG9jYXRpb25zLyovY29ycG9yYS8qL2Fzc2V0cy8qL29wZXJhdGlvbnMvKn1aSBJGL3YxL3tuYW1lPXByb2plY3RzLyovbG9jYXRpb25zLyovY29ycG9yYS8qL2NvbGxlY3Rpb25zLyovb3BlcmF0aW9ucy8qfVpJEkcvdjEve25hbWU9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9jb3Jwb3JhLyovaW1hZ2VJbmRleGVzLyovb3BlcmF0aW9ucy8qfVpEEkIvdjEve25hbWU9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9jb3Jwb3JhLyovaW5kZXhlcy8qL29wZXJhdGlvbnMvKn1aOhI4L3YxL3tuYW1lPXByb2plY3RzLyovbG9jYXRpb25zLyovY29ycG9yYS8qL29wZXJhdGlvbnMvKn1aQRI/L3YxL3tuYW1lPXByb2plY3RzLyovbG9jYXRpb25zLyovaW5kZXhFbmRwb2ludHMvKi9vcGVyYXRpb25zLyp9")
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
            yield return AnnotationsReflection.Descriptor;
            yield return CommonReflection.Descriptor;
            yield return HealthServiceReflection.Descriptor;
            yield return LvaReflection.Descriptor;
            yield return LvaResourcesReflection.Descriptor;
            yield return LvaServiceReflection.Descriptor;
            yield return PlatformReflection.Descriptor;
            yield return StreamingResourcesReflection.Descriptor;
            yield return StreamingServiceReflection.Descriptor;
            yield return StreamsResourcesReflection.Descriptor;
            yield return StreamsServiceReflection.Descriptor;
            yield return WarehouseReflection.Descriptor;
            yield return lro::OperationsReflection.Descriptor;
        }
    }
}
