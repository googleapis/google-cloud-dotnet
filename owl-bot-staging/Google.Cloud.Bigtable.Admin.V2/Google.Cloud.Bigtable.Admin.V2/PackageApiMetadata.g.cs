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
using gpr = Google.Protobuf.Reflection;
using lro = Google.LongRunning;
using proto = Google.Protobuf;
using scg = System.Collections.Generic;

namespace Google.Cloud.Bigtable.Admin.V2
{
    /// <summary>Static class to provide common access to package-wide API metadata.</summary>
    internal static class PackageApiMetadata
    {
        /// <summary>The <see cref="gaxgrpc::ApiMetadata"/> for services in this package.</summary>
        internal static gaxgrpc::ApiMetadata ApiMetadata { get; } = new gaxgrpc::ApiMetadata("Google.Cloud.Bigtable.Admin.V2", GetFileDescriptors)
            .WithRequestNumericEnumJsonEncoding(true)
            .WithHttpRuleOverrides(new scg::Dictionary<string, proto::ByteString>
            {
                {
                    "google.longrunning.Operations.CancelOperation",
                    // { "post": "/v2/{name=operations/**}:cancel" }
                    proto::ByteString.FromBase64("Ih8vdjIve25hbWU9b3BlcmF0aW9ucy8qKn06Y2FuY2Vs")
                },
                {
                    "google.longrunning.Operations.DeleteOperation",
                    // { "delete": "/v2/{name=operations/**}" }
                    proto::ByteString.FromBase64("KhgvdjIve25hbWU9b3BlcmF0aW9ucy8qKn0=")
                },
                {
                    "google.longrunning.Operations.GetOperation",
                    // { "get": "/v2/{name=operations/**}" }
                    proto::ByteString.FromBase64("EhgvdjIve25hbWU9b3BlcmF0aW9ucy8qKn0=")
                },
                {
                    "google.longrunning.Operations.ListOperations",
                    // { "get": "/v2/{name=operations/projects/**}/operations" }
                    proto::ByteString.FromBase64("EiwvdjIve25hbWU9b3BlcmF0aW9ucy9wcm9qZWN0cy8qKn0vb3BlcmF0aW9ucw==")
                },
            });

        private static scg::IEnumerable<gpr::FileDescriptor> GetFileDescriptors()
        {
            yield return BigtableInstanceAdminReflection.Descriptor;
            yield return BigtableTableAdminReflection.Descriptor;
            yield return CommonReflection.Descriptor;
            yield return InstanceReflection.Descriptor;
            yield return TableReflection.Descriptor;
            yield return TypesReflection.Descriptor;
            yield return lro::OperationsReflection.Descriptor;
        }
    }
}
