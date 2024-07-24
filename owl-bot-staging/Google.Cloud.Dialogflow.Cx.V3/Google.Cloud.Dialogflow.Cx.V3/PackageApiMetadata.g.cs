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

namespace Google.Cloud.Dialogflow.Cx.V3
{
    /// <summary>Static class to provide common access to package-wide API metadata.</summary>
    internal static class PackageApiMetadata
    {
        /// <summary>The <see cref="gaxgrpc::ApiMetadata"/> for services in this package.</summary>
        internal static gaxgrpc::ApiMetadata ApiMetadata { get; } = new gaxgrpc::ApiMetadata("Google.Cloud.Dialogflow.Cx.V3", GetFileDescriptors)
            .WithRequestNumericEnumJsonEncoding(true)
            .WithHttpRuleOverrides(new scg::Dictionary<string, proto::ByteString>
            {
                {
                    "google.cloud.location.Locations.GetLocation",
                    // { "get": "/v3/{name=projects/*/locations/*}" }
                    proto::ByteString.FromBase64("EiEvdjMve25hbWU9cHJvamVjdHMvKi9sb2NhdGlvbnMvKn0=")
                },
                {
                    "google.cloud.location.Locations.ListLocations",
                    // { "get": "/v3/{name=projects/*}/locations" }
                    proto::ByteString.FromBase64("Eh8vdjMve25hbWU9cHJvamVjdHMvKn0vbG9jYXRpb25z")
                },
                {
                    "google.longrunning.Operations.CancelOperation",
                    // { "post": "/v3/{name=projects/*/operations/*}:cancel", "additionalBindings": [ { "post": "/v3/{name=projects/*/locations/*/operations/*}:cancel" } ] }
                    proto::ByteString.FromBase64("IikvdjMve25hbWU9cHJvamVjdHMvKi9vcGVyYXRpb25zLyp9OmNhbmNlbFo3IjUvdjMve25hbWU9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9vcGVyYXRpb25zLyp9OmNhbmNlbA==")
                },
                {
                    "google.longrunning.Operations.GetOperation",
                    // { "get": "/v3/{name=projects/*/operations/*}", "additionalBindings": [ { "get": "/v3/{name=projects/*/locations/*/operations/*}" } ] }
                    proto::ByteString.FromBase64("EiIvdjMve25hbWU9cHJvamVjdHMvKi9vcGVyYXRpb25zLyp9WjASLi92My97bmFtZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL29wZXJhdGlvbnMvKn0=")
                },
                {
                    "google.longrunning.Operations.ListOperations",
                    // { "get": "/v3/{name=projects/*}/operations", "additionalBindings": [ { "get": "/v3/{name=projects/*/locations/*}/operations" } ] }
                    proto::ByteString.FromBase64("EiAvdjMve25hbWU9cHJvamVjdHMvKn0vb3BlcmF0aW9uc1ouEiwvdjMve25hbWU9cHJvamVjdHMvKi9sb2NhdGlvbnMvKn0vb3BlcmF0aW9ucw==")
                },
            });

        private static scg::IEnumerable<gpr::FileDescriptor> GetFileDescriptors()
        {
            yield return AdvancedSettingsReflection.Descriptor;
            yield return AgentReflection.Descriptor;
            yield return AudioConfigReflection.Descriptor;
            yield return ChangelogReflection.Descriptor;
            yield return DataStoreConnectionReflection.Descriptor;
            yield return DeploymentReflection.Descriptor;
            yield return EntityTypeReflection.Descriptor;
            yield return EnvironmentReflection.Descriptor;
            yield return ExperimentReflection.Descriptor;
            yield return FlowReflection.Descriptor;
            yield return FulfillmentReflection.Descriptor;
            yield return GcsReflection.Descriptor;
            yield return GenerativeSettingsReflection.Descriptor;
            yield return GeneratorReflection.Descriptor;
            yield return ImportStrategyReflection.Descriptor;
            yield return InlineReflection.Descriptor;
            yield return IntentReflection.Descriptor;
            yield return PageReflection.Descriptor;
            yield return ResponseMessageReflection.Descriptor;
            yield return SafetySettingsReflection.Descriptor;
            yield return SecuritySettingsReflection.Descriptor;
            yield return SessionReflection.Descriptor;
            yield return SessionEntityTypeReflection.Descriptor;
            yield return TestCaseReflection.Descriptor;
            yield return TransitionRouteGroupReflection.Descriptor;
            yield return ValidationMessageReflection.Descriptor;
            yield return VersionReflection.Descriptor;
            yield return WebhookReflection.Descriptor;
            yield return gcl::LocationsReflection.Descriptor;
            yield return lro::OperationsReflection.Descriptor;
        }
    }
}
