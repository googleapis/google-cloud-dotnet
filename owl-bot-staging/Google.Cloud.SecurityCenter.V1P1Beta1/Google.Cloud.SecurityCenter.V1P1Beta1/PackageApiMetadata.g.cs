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

namespace Google.Cloud.SecurityCenter.V1P1Beta1
{
    /// <summary>Static class to provide common access to package-wide API metadata.</summary>
    internal static class PackageApiMetadata
    {
        /// <summary>The <see cref="gaxgrpc::ApiMetadata"/> for services in this package.</summary>
        internal static gaxgrpc::ApiMetadata ApiMetadata { get; } = new gaxgrpc::ApiMetadata("Google.Cloud.SecurityCenter.V1P1Beta1", GetFileDescriptors)
            .WithRequestNumericEnumJsonEncoding(true)
            .WithHttpRuleOverrides(new scg::Dictionary<string, proto::ByteString>
            {
                {
                    "google.longrunning.Operations.CancelOperation",
                    // { "post": "/v1p1beta1/{name=organizations/*/operations/*}:cancel", "body": "*" }
                    proto::ByteString.FromBase64("IjUvdjFwMWJldGExL3tuYW1lPW9yZ2FuaXphdGlvbnMvKi9vcGVyYXRpb25zLyp9OmNhbmNlbDoBKg==")
                },
                {
                    "google.longrunning.Operations.DeleteOperation",
                    // { "delete": "/v1p1beta1/{name=organizations/*/operations/*}" }
                    proto::ByteString.FromBase64("Ki4vdjFwMWJldGExL3tuYW1lPW9yZ2FuaXphdGlvbnMvKi9vcGVyYXRpb25zLyp9")
                },
                {
                    "google.longrunning.Operations.GetOperation",
                    // { "get": "/v1p1beta1/{name=organizations/*/operations/*}" }
                    proto::ByteString.FromBase64("Ei4vdjFwMWJldGExL3tuYW1lPW9yZ2FuaXphdGlvbnMvKi9vcGVyYXRpb25zLyp9")
                },
                {
                    "google.longrunning.Operations.ListOperations",
                    // { "get": "/v1p1beta1/{name=organizations/*/operations}" }
                    proto::ByteString.FromBase64("EiwvdjFwMWJldGExL3tuYW1lPW9yZ2FuaXphdGlvbnMvKi9vcGVyYXRpb25zfQ==")
                },
            });

        private static scg::IEnumerable<gpr::FileDescriptor> GetFileDescriptors()
        {
            yield return AssetReflection.Descriptor;
            yield return FindingReflection.Descriptor;
            yield return FolderReflection.Descriptor;
            yield return NotificationConfigReflection.Descriptor;
            yield return NotificationMessageReflection.Descriptor;
            yield return OrganizationSettingsReflection.Descriptor;
            yield return ResourceReflection.Descriptor;
            yield return RunAssetDiscoveryResponseReflection.Descriptor;
            yield return SecurityMarksReflection.Descriptor;
            yield return SecuritycenterServiceReflection.Descriptor;
            yield return SourceReflection.Descriptor;
            yield return lro::OperationsReflection.Descriptor;
        }
    }
}
