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

using gaxgrpc = Google.Api.Gax.Grpc;
using gpr = Google.Protobuf.Reflection;
using scg = System.Collections.Generic;

namespace Google.Cloud.DataCatalog.V1
{
    /// <summary>Static class to provide common access to package-wide API metadata.</summary>
    internal static class PackageApiMetadata
    {
        /// <summary>The <see cref="gaxgrpc::ApiMetadata"/> for services in this package.</summary>
        internal static gaxgrpc::ApiMetadata ApiMetadata { get; } = new gaxgrpc::ApiMetadata("Google.Cloud.DataCatalog.V1", GetFileDescriptors);

        private static scg::IEnumerable<gpr::FileDescriptor> GetFileDescriptors()
        {
            yield return BigqueryReflection.Descriptor;
            yield return CommonReflection.Descriptor;
            yield return DataSourceReflection.Descriptor;
            yield return PhysicalSchemaReflection.Descriptor;
            yield return DataplexSpecReflection.Descriptor;
            yield return TimestampsReflection.Descriptor;
            yield return GcsFilesetSpecReflection.Descriptor;
            yield return SchemaReflection.Descriptor;
            yield return SearchReflection.Descriptor;
            yield return TableSpecReflection.Descriptor;
            yield return TagsReflection.Descriptor;
            yield return UsageReflection.Descriptor;
            yield return DatacatalogReflection.Descriptor;
            yield return PolicytagmanagerReflection.Descriptor;
            yield return PolicytagmanagerserializationReflection.Descriptor;
        }
    }
}
