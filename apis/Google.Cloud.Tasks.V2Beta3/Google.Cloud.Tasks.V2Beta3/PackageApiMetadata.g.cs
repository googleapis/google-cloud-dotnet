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
using proto = Google.Protobuf;
using scg = System.Collections.Generic;

namespace Google.Cloud.Tasks.V2Beta3
{
    /// <summary>Static class to provide common access to package-wide API metadata.</summary>
    internal static class PackageApiMetadata
    {
        /// <summary>The <see cref="gaxgrpc::ApiMetadata"/> for services in this package.</summary>
        internal static gaxgrpc::ApiMetadata ApiMetadata { get; } = new gaxgrpc::ApiMetadata("Google.Cloud.Tasks.V2Beta3", GetFileDescriptors)
            .WithRequestNumericEnumJsonEncoding(true)
            .WithHttpRuleOverrides(new scg::Dictionary<string, proto::ByteString>
            {
                {
                    "google.cloud.location.Locations.GetLocation",
                    // { "get": "/v2beta3/{name=projects/*/locations/*}" }
                    proto::ByteString.FromBase64("EiYvdjJiZXRhMy97bmFtZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qfQ==")
                },
                {
                    "google.cloud.location.Locations.ListLocations",
                    // { "get": "/v2beta3/{name=projects/*}/locations" }
                    proto::ByteString.FromBase64("EiQvdjJiZXRhMy97bmFtZT1wcm9qZWN0cy8qfS9sb2NhdGlvbnM=")
                },
            });

        private static scg::IEnumerable<gpr::FileDescriptor> GetFileDescriptors()
        {
            yield return gcl::LocationsReflection.Descriptor;
            yield return CloudtasksReflection.Descriptor;
            yield return QueueReflection.Descriptor;
            yield return TargetReflection.Descriptor;
            yield return TaskReflection.Descriptor;
        }
    }
}
