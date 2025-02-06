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

namespace Google.Cloud.PolicySimulator.V1
{
    /// <summary>Static class to provide common access to package-wide API metadata.</summary>
    internal static class PackageApiMetadata
    {
        /// <summary>The <see cref="gaxgrpc::ApiMetadata"/> for services in this package.</summary>
        internal static gaxgrpc::ApiMetadata ApiMetadata { get; } = new gaxgrpc::ApiMetadata("Google.Cloud.PolicySimulator.V1", GetFileDescriptors)
            .WithRequestNumericEnumJsonEncoding(true)
            .WithHttpRuleOverrides(new scg::Dictionary<string, proto::ByteString>
            {
                {
                    "google.longrunning.Operations.GetOperation",
                    // { "get": "/v1/{name=operations/**}", "additionalBindings": [ { "get": "/v1/{name=projects/*/locations/*/replays/*/operations/**}" }, { "get": "/v1/{name=folders/*/locations/*/replays/*/operations/**}" }, { "get": "/v1/{name=organizations/*/locations/*/replays/*/operations/**}" } ] }
                    proto::ByteString.FromBase64("EhgvdjEve25hbWU9b3BlcmF0aW9ucy8qKn1aOxI5L3YxL3tuYW1lPXByb2plY3RzLyovbG9jYXRpb25zLyovcmVwbGF5cy8qL29wZXJhdGlvbnMvKip9WjoSOC92MS97bmFtZT1mb2xkZXJzLyovbG9jYXRpb25zLyovcmVwbGF5cy8qL29wZXJhdGlvbnMvKip9WkASPi92MS97bmFtZT1vcmdhbml6YXRpb25zLyovbG9jYXRpb25zLyovcmVwbGF5cy8qL29wZXJhdGlvbnMvKip9")
                },
                {
                    "google.longrunning.Operations.ListOperations",
                    // { "get": "/v1/{name=operations}", "additionalBindings": [ { "get": "/v1/{name=projects/*/locations/*/replays/*/operations}" }, { "get": "/v1/{name=folders/*/locations/*/replays/*/operations}" }, { "get": "/v1/{name=organizations/*/locations/*/replays/*/operations}" } ] }
                    proto::ByteString.FromBase64("EhUvdjEve25hbWU9b3BlcmF0aW9uc31aOBI2L3YxL3tuYW1lPXByb2plY3RzLyovbG9jYXRpb25zLyovcmVwbGF5cy8qL29wZXJhdGlvbnN9WjcSNS92MS97bmFtZT1mb2xkZXJzLyovbG9jYXRpb25zLyovcmVwbGF5cy8qL29wZXJhdGlvbnN9Wj0SOy92MS97bmFtZT1vcmdhbml6YXRpb25zLyovbG9jYXRpb25zLyovcmVwbGF5cy8qL29wZXJhdGlvbnN9")
                },
            });

        private static scg::IEnumerable<gpr::FileDescriptor> GetFileDescriptors()
        {
            yield return ExplanationsReflection.Descriptor;
            yield return SimulatorReflection.Descriptor;
            yield return lro::OperationsReflection.Descriptor;
        }
    }
}
