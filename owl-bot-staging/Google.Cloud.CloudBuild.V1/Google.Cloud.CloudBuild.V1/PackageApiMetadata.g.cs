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
using gpr = Google.Protobuf.Reflection;
using lro = Google.LongRunning;
using proto = Google.Protobuf;
using scg = System.Collections.Generic;

namespace Google.Cloud.CloudBuild.V1
{
    /// <summary>Static class to provide common access to package-wide API metadata.</summary>
    internal static class PackageApiMetadata
    {
        /// <summary>The <see cref="gaxgrpc::ApiMetadata"/> for services in this package.</summary>
        internal static gaxgrpc::ApiMetadata ApiMetadata { get; } = new gaxgrpc::ApiMetadata("Google.Cloud.CloudBuild.V1", GetFileDescriptors)
            .WithRequestNumericEnumJsonEncoding(true)
            .WithHttpRuleOverrides(new scg::Dictionary<string, proto::ByteString>
            {
                {
                    "google.longrunning.Operations.CancelOperation",
                    // { "post": "/v1/{name=operations/**}:cancel", "body": "*", "additionalBindings": [ { "post": "/v1/{name=projects/*/locations/*/operations/*}:cancel", "body": "*" } ] }
                    proto::ByteString.FromBase64("Ih8vdjEve25hbWU9b3BlcmF0aW9ucy8qKn06Y2FuY2VsOgEqWjoiNS92MS97bmFtZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL29wZXJhdGlvbnMvKn06Y2FuY2VsOgEq")
                },
                {
                    "google.longrunning.Operations.GetOperation",
                    // { "get": "/v1/{name=operations/**}", "additionalBindings": [ { "get": "/v1/{name=projects/*/locations/*/operations/*}" } ] }
                    proto::ByteString.FromBase64("EhgvdjEve25hbWU9b3BlcmF0aW9ucy8qKn1aMBIuL3YxL3tuYW1lPXByb2plY3RzLyovbG9jYXRpb25zLyovb3BlcmF0aW9ucy8qfQ==")
                },
            });

        private static scg::IEnumerable<gpr::FileDescriptor> GetFileDescriptors()
        {
            yield return CloudbuildReflection.Descriptor;
            yield return lro::OperationsReflection.Descriptor;
        }
    }
}
