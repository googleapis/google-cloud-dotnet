// Copyright 2026 Google LLC
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

namespace Google.Cloud.Ces.V1
{
    /// <summary>Static class to provide common access to package-wide API metadata.</summary>
    internal static class PackageApiMetadata
    {
        /// <summary>The <see cref="gaxgrpc::ApiMetadata"/> for services in this package.</summary>
        internal static gaxgrpc::ApiMetadata ApiMetadata { get; } = new gaxgrpc::ApiMetadata("Google.Cloud.Ces.V1", GetFileDescriptors)
            .WithRequestNumericEnumJsonEncoding(true)
            .WithHttpRuleOverrides(new scg::Dictionary<string, proto::ByteString>
            {
                {
                    "google.cloud.location.Locations.GetLocation",
                    // { "get": "/v1/{name=projects/*/locations/*}" }
                    proto::ByteString.FromBase64("EiEvdjEve25hbWU9cHJvamVjdHMvKi9sb2NhdGlvbnMvKn0=")
                },
                {
                    "google.cloud.location.Locations.ListLocations",
                    // { "get": "/v1/{name=projects/*}/locations" }
                    proto::ByteString.FromBase64("Eh8vdjEve25hbWU9cHJvamVjdHMvKn0vbG9jYXRpb25z")
                },
                {
                    "google.longrunning.Operations.CancelOperation",
                    // { "post": "/v1/{name=projects/*/locations/*/operations/*}:cancel", "body": "*" }
                    proto::ByteString.FromBase64("IjUvdjEve25hbWU9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9vcGVyYXRpb25zLyp9OmNhbmNlbDoBKg==")
                },
                {
                    "google.longrunning.Operations.DeleteOperation",
                    // { "delete": "/v1/{name=projects/*/locations/*/operations/*}" }
                    proto::ByteString.FromBase64("Ki4vdjEve25hbWU9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9vcGVyYXRpb25zLyp9")
                },
                {
                    "google.longrunning.Operations.GetOperation",
                    // { "get": "/v1/{name=projects/*/locations/*/operations/*}" }
                    proto::ByteString.FromBase64("Ei4vdjEve25hbWU9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9vcGVyYXRpb25zLyp9")
                },
                {
                    "google.longrunning.Operations.ListOperations",
                    // { "get": "/v1/{name=projects/*/locations/*}/operations" }
                    proto::ByteString.FromBase64("EiwvdjEve25hbWU9cHJvamVjdHMvKi9sb2NhdGlvbnMvKn0vb3BlcmF0aW9ucw==")
                },
            });

        private static scg::IEnumerable<gpr::FileDescriptor> GetFileDescriptors()
        {
            yield return AgentReflection.Descriptor;
            yield return AgentServiceReflection.Descriptor;
            yield return AgentTransfersReflection.Descriptor;
            yield return AppReflection.Descriptor;
            yield return AppVersionReflection.Descriptor;
            yield return AuthReflection.Descriptor;
            yield return BigqueryExportReflection.Descriptor;
            yield return ChangelogReflection.Descriptor;
            yield return ClientFunctionReflection.Descriptor;
            yield return CommonReflection.Descriptor;
            yield return ConnectorToolReflection.Descriptor;
            yield return ConnectorToolsetReflection.Descriptor;
            yield return ConversationReflection.Descriptor;
            yield return DataStoreReflection.Descriptor;
            yield return DataStoreToolReflection.Descriptor;
            yield return DeploymentReflection.Descriptor;
            yield return ExampleReflection.Descriptor;
            yield return FakesReflection.Descriptor;
            yield return FileSearchToolReflection.Descriptor;
            yield return GoogleSearchToolReflection.Descriptor;
            yield return GuardrailReflection.Descriptor;
            yield return McpToolReflection.Descriptor;
            yield return McpToolsetReflection.Descriptor;
            yield return OmnichannelReflection.Descriptor;
            yield return OmnichannelServiceReflection.Descriptor;
            yield return OpenApiToolReflection.Descriptor;
            yield return OpenApiToolsetReflection.Descriptor;
            yield return PythonFunctionReflection.Descriptor;
            yield return SchemaReflection.Descriptor;
            yield return SearchSuggestionsReflection.Descriptor;
            yield return SessionServiceReflection.Descriptor;
            yield return SystemToolReflection.Descriptor;
            yield return ToolReflection.Descriptor;
            yield return ToolServiceReflection.Descriptor;
            yield return ToolsetReflection.Descriptor;
            yield return ToolsetToolReflection.Descriptor;
            yield return WidgetServiceReflection.Descriptor;
            yield return WidgetToolReflection.Descriptor;
            yield return gcl::LocationsReflection.Descriptor;
            yield return lro::OperationsReflection.Descriptor;
        }
    }
}
