// Copyright 2024 Google LLC
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
using gcl = Google.Cloud.Location;
using gpr = Google.Protobuf.Reflection;
using lro = Google.LongRunning;
using proto = Google.Protobuf;
using scg = System.Collections.Generic;

namespace Google.Cloud.DocumentAI.V1
{
    /// <summary>Static class to provide common access to package-wide API metadata.</summary>
    internal static class PackageApiMetadata
    {
        /// <summary>The <see cref="gaxgrpc::ApiMetadata"/> for services in this package.</summary>
        internal static gaxgrpc::ApiMetadata ApiMetadata { get; } = new gaxgrpc::ApiMetadata("Google.Cloud.DocumentAI.V1", GetFileDescriptors)
            .WithRequestNumericEnumJsonEncoding(true)
            .WithHttpRuleOverrides(new scg::Dictionary<string, proto::ByteString>
            {
                {
                    "google.cloud.location.Locations.GetLocation",
                    // { "get": "/v1/{name=projects/*/locations/*}", "additionalBindings": [ { "get": "/uiv1beta3/{name=projects/*/locations/*}" } ] }
                    proto::ByteString.FromBase64("EiEvdjEve25hbWU9cHJvamVjdHMvKi9sb2NhdGlvbnMvKn1aKhIoL3VpdjFiZXRhMy97bmFtZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qfQ==")
                },
                {
                    "google.cloud.location.Locations.ListLocations",
                    // { "get": "/v1/{name=projects/*}/locations", "additionalBindings": [ { "get": "/uiv1beta3/{name=projects/*}/locations" } ] }
                    proto::ByteString.FromBase64("Eh8vdjEve25hbWU9cHJvamVjdHMvKn0vbG9jYXRpb25zWigSJi91aXYxYmV0YTMve25hbWU9cHJvamVjdHMvKn0vbG9jYXRpb25z")
                },
                {
                    "google.longrunning.Operations.CancelOperation",
                    // { "post": "/v1/{name=projects/*/locations/*/operations/*}:cancel", "additionalBindings": [ { "post": "/uiv1beta3/{name=projects/*/locations/*/operations/*}:cancel" } ] }
                    proto::ByteString.FromBase64("IjUvdjEve25hbWU9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9vcGVyYXRpb25zLyp9OmNhbmNlbFo+IjwvdWl2MWJldGEzL3tuYW1lPXByb2plY3RzLyovbG9jYXRpb25zLyovb3BlcmF0aW9ucy8qfTpjYW5jZWw=")
                },
                {
                    "google.longrunning.Operations.GetOperation",
                    // { "get": "/v1/{name=projects/*/operations/*}", "additionalBindings": [ { "get": "/v1/{name=projects/*/locations/*/operations/*}" }, { "get": "/uiv1beta3/{name=projects/*/locations/*/operations/*}" } ] }
                    proto::ByteString.FromBase64("EiIvdjEve25hbWU9cHJvamVjdHMvKi9vcGVyYXRpb25zLyp9WjASLi92MS97bmFtZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL29wZXJhdGlvbnMvKn1aNxI1L3VpdjFiZXRhMy97bmFtZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL29wZXJhdGlvbnMvKn0=")
                },
                {
                    "google.longrunning.Operations.ListOperations",
                    // { "get": "/v1/{name=projects/*/locations/*/operations}", "additionalBindings": [ { "get": "/uiv1beta3/{name=projects/*/locations/*/operations}" } ] }
                    proto::ByteString.FromBase64("EiwvdjEve25hbWU9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9vcGVyYXRpb25zfVo1EjMvdWl2MWJldGEzL3tuYW1lPXByb2plY3RzLyovbG9jYXRpb25zLyovb3BlcmF0aW9uc30=")
                },
            });

        private static scg::IEnumerable<gpr::FileDescriptor> GetFileDescriptors()
        {
            yield return BarcodeReflection.Descriptor;
            yield return DocumentReflection.Descriptor;
            yield return DocumentIoReflection.Descriptor;
            yield return DocumentProcessorServiceReflection.Descriptor;
            yield return DocumentSchemaReflection.Descriptor;
            yield return EvaluationReflection.Descriptor;
            yield return GeometryReflection.Descriptor;
            yield return OperationMetadataReflection.Descriptor;
            yield return ProcessorReflection.Descriptor;
            yield return ProcessorTypeReflection.Descriptor;
            yield return gcl::LocationsReflection.Descriptor;
            yield return lro::OperationsReflection.Descriptor;
        }
    }
}
