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

namespace Google.Cloud.Retail.V2
{
    /// <summary>Static class to provide common access to package-wide API metadata.</summary>
    internal static class PackageApiMetadata
    {
        /// <summary>The <see cref="gaxgrpc::ApiMetadata"/> for services in this package.</summary>
        internal static gaxgrpc::ApiMetadata ApiMetadata { get; } = new gaxgrpc::ApiMetadata("Google.Cloud.Retail.V2", GetFileDescriptors)
            .WithRequestNumericEnumJsonEncoding(true)
            .WithHttpRuleOverrides(new scg::Dictionary<string, proto::ByteString>
            {
                {
                    "google.longrunning.Operations.GetOperation",
                    // { "get": "/v2/{name=projects/*/locations/*/operations/*}", "additionalBindings": [ { "get": "/v2/{name=projects/*/locations/*/catalogs/*/branches/*/operations/*}" }, { "get": "/v2/{name=projects/*/locations/*/catalogs/*/operations/*}" }, { "get": "/v2/{name=projects/*/operations/*}" } ] }
                    proto::ByteString.FromBase64("Ei4vdjIve25hbWU9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9vcGVyYXRpb25zLyp9WkYSRC92Mi97bmFtZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL2NhdGFsb2dzLyovYnJhbmNoZXMvKi9vcGVyYXRpb25zLyp9WjsSOS92Mi97bmFtZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL2NhdGFsb2dzLyovb3BlcmF0aW9ucy8qfVokEiIvdjIve25hbWU9cHJvamVjdHMvKi9vcGVyYXRpb25zLyp9")
                },
                {
                    "google.longrunning.Operations.ListOperations",
                    // { "get": "/v2/{name=projects/*/locations/*}/operations", "additionalBindings": [ { "get": "/v2/{name=projects/*/locations/*/catalogs/*}/operations" }, { "get": "/v2/{name=projects/*}/operations" } ] }
                    proto::ByteString.FromBase64("EiwvdjIve25hbWU9cHJvamVjdHMvKi9sb2NhdGlvbnMvKn0vb3BlcmF0aW9uc1o5EjcvdjIve25hbWU9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9jYXRhbG9ncy8qfS9vcGVyYXRpb25zWiISIC92Mi97bmFtZT1wcm9qZWN0cy8qfS9vcGVyYXRpb25z")
                },
            });

        private static scg::IEnumerable<gpr::FileDescriptor> GetFileDescriptors()
        {
            yield return gcl::LocationsReflection.Descriptor;
            yield return AnalyticsServiceReflection.Descriptor;
            yield return CatalogReflection.Descriptor;
            yield return CatalogServiceReflection.Descriptor;
            yield return CommonReflection.Descriptor;
            yield return CompletionServiceReflection.Descriptor;
            yield return ControlReflection.Descriptor;
            yield return ControlServiceReflection.Descriptor;
            yield return ExportConfigReflection.Descriptor;
            yield return ImportConfigReflection.Descriptor;
            yield return ModelReflection.Descriptor;
            yield return ModelServiceReflection.Descriptor;
            yield return PredictionServiceReflection.Descriptor;
            yield return ProductReflection.Descriptor;
            yield return ProductServiceReflection.Descriptor;
            yield return PromotionReflection.Descriptor;
            yield return PurgeConfigReflection.Descriptor;
            yield return SearchServiceReflection.Descriptor;
            yield return ServingConfigReflection.Descriptor;
            yield return ServingConfigServiceReflection.Descriptor;
            yield return UserEventReflection.Descriptor;
            yield return UserEventServiceReflection.Descriptor;
            yield return lro::OperationsReflection.Descriptor;
        }
    }
}
