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
using gcl = Google.Cloud.Location;
using gpr = Google.Protobuf.Reflection;
using lro = Google.LongRunning;
using proto = Google.Protobuf;
using scg = System.Collections.Generic;

namespace Google.Cloud.DocumentAI.V1Beta3
{
    /// <summary>Static class to provide common access to package-wide API metadata.</summary>
    internal static class PackageApiMetadata
    {
        /// <summary>The <see cref="gaxgrpc::ApiMetadata"/> for services in this package.</summary>
        internal static gaxgrpc::ApiMetadata ApiMetadata { get; } = new gaxgrpc::ApiMetadata("Google.Cloud.DocumentAI.V1Beta3", GetFileDescriptors)
            .WithRequestNumericEnumJsonEncoding(true)
            .WithHttpRuleOverrides(new scg::Dictionary<string, proto::ByteString>
            {
                {
                    "google.cloud.location.Locations.GetLocation",
                    // { "get": "/v1beta3/{name=projects/*/locations/*}", "additionalBindings": [ { "get": "/uiv1beta3/{name=projects/*/locations/*}" } ] }
                    proto::ByteString.FromBase64("EiYvdjFiZXRhMy97bmFtZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qfVoqEigvdWl2MWJldGEzL3tuYW1lPXByb2plY3RzLyovbG9jYXRpb25zLyp9")
                },
                {
                    "google.cloud.location.Locations.ListLocations",
                    // { "get": "/v1beta3/{name=projects/*}/locations", "additionalBindings": [ { "get": "/uiv1beta3/{name=projects/*}/locations" } ] }
                    proto::ByteString.FromBase64("EiQvdjFiZXRhMy97bmFtZT1wcm9qZWN0cy8qfS9sb2NhdGlvbnNaKBImL3VpdjFiZXRhMy97bmFtZT1wcm9qZWN0cy8qfS9sb2NhdGlvbnM=")
                },
                {
                    "google.longrunning.Operations.CancelOperation",
                    // { "post": "/v1beta3/{name=projects/*/locations/*/operations/*}:cancel", "additionalBindings": [ { "post": "/uiv1beta3/{name=projects/*/locations/*/operations/*}:cancel" } ] }
                    proto::ByteString.FromBase64("IjovdjFiZXRhMy97bmFtZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL29wZXJhdGlvbnMvKn06Y2FuY2VsWj4iPC91aXYxYmV0YTMve25hbWU9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9vcGVyYXRpb25zLyp9OmNhbmNlbA==")
                },
                {
                    "google.longrunning.Operations.GetOperation",
                    // { "get": "/v1beta3/{name=projects/*/locations/*/operations/*}", "additionalBindings": [ { "get": "/uiv1beta3/{name=projects/*/locations/*/operations/*}" } ] }
                    proto::ByteString.FromBase64("EjMvdjFiZXRhMy97bmFtZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL29wZXJhdGlvbnMvKn1aNxI1L3VpdjFiZXRhMy97bmFtZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL29wZXJhdGlvbnMvKn0=")
                },
                {
                    "google.longrunning.Operations.ListOperations",
                    // { "get": "/v1beta3/{name=projects/*/locations/*/operations}", "additionalBindings": [ { "get": "/uiv1beta3/{name=projects/*/locations/*/operations}" } ] }
                    proto::ByteString.FromBase64("EjEvdjFiZXRhMy97bmFtZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL29wZXJhdGlvbnN9WjUSMy91aXYxYmV0YTMve25hbWU9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9vcGVyYXRpb25zfQ==")
                },
            });

        private static scg::IEnumerable<gpr::FileDescriptor> GetFileDescriptors()
        {
            yield return BarcodeReflection.Descriptor;
            yield return DatasetReflection.Descriptor;
            yield return DocumentReflection.Descriptor;
            yield return DocumentIoReflection.Descriptor;
            yield return DocumentProcessorServiceReflection.Descriptor;
            yield return DocumentSchemaReflection.Descriptor;
            yield return DocumentServiceReflection.Descriptor;
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
