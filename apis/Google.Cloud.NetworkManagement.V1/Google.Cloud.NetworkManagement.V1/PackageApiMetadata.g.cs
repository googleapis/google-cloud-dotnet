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

#pragma warning disable CS8981
using gaxgrpc = Google.Api.Gax.Grpc;
using lro = Google.LongRunning;
using proto = Google.Protobuf;
using gpr = Google.Protobuf.Reflection;
using scg = System.Collections.Generic;

namespace Google.Cloud.NetworkManagement.V1
{
    /// <summary>Static class to provide common access to package-wide API metadata.</summary>
    internal static class PackageApiMetadata
    {
        /// <summary>The <see cref="gaxgrpc::ApiMetadata"/> for services in this package.</summary>
        internal static gaxgrpc::ApiMetadata ApiMetadata { get; } = new gaxgrpc::ApiMetadata("Google.Cloud.NetworkManagement.V1", GetFileDescriptors)
            .WithRequestNumericEnumJsonEncoding(true)
            .WithHttpRuleOverrides(new scg::Dictionary<string, proto::ByteString>
            {
                {
                    "google.longrunning.Operations.CancelOperation",
                    // { "post": "/v1/{name=projects/*/locations/global/operations/*}:cancel", "body": "*" }
                    proto::ByteString.FromBase64("IjovdjEve25hbWU9cHJvamVjdHMvKi9sb2NhdGlvbnMvZ2xvYmFsL29wZXJhdGlvbnMvKn06Y2FuY2VsOgEq")
                },
                {
                    "google.longrunning.Operations.DeleteOperation",
                    // { "delete": "/v1/{name=projects/*/locations/global/operations/*}" }
                    proto::ByteString.FromBase64("KjMvdjEve25hbWU9cHJvamVjdHMvKi9sb2NhdGlvbnMvZ2xvYmFsL29wZXJhdGlvbnMvKn0=")
                },
                {
                    "google.longrunning.Operations.GetOperation",
                    // { "get": "/v1/{name=projects/*/locations/global/operations/*}" }
                    proto::ByteString.FromBase64("EjMvdjEve25hbWU9cHJvamVjdHMvKi9sb2NhdGlvbnMvZ2xvYmFsL29wZXJhdGlvbnMvKn0=")
                },
                {
                    "google.longrunning.Operations.ListOperations",
                    // { "get": "/v1/{name=projects/*/locations/global}/operations" }
                    proto::ByteString.FromBase64("EjEvdjEve25hbWU9cHJvamVjdHMvKi9sb2NhdGlvbnMvZ2xvYmFsfS9vcGVyYXRpb25z")
                },
            });

        private static scg::IEnumerable<gpr::FileDescriptor> GetFileDescriptors()
        {
            yield return ConnectivityTestReflection.Descriptor;
            yield return ReachabilityReflection.Descriptor;
            yield return TraceReflection.Descriptor;
            yield return lro::OperationsReflection.Descriptor;
        }
    }
}
