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

namespace Google.Cloud.Dialogflow.V2
{
    /// <summary>Static class to provide common access to package-wide API metadata.</summary>
    internal static class PackageApiMetadata
    {
        /// <summary>The <see cref="gaxgrpc::ApiMetadata"/> for services in this package.</summary>
        internal static gaxgrpc::ApiMetadata ApiMetadata { get; } = new gaxgrpc::ApiMetadata("Google.Cloud.Dialogflow.V2", GetFileDescriptors)
            .WithRequestNumericEnumJsonEncoding(true)
            .WithHttpRuleOverrides(new scg::Dictionary<string, proto::ByteString>
            {
                {
                    "google.cloud.location.Locations.GetLocation",
                    // { "get": "/v2/{name=projects/*/locations/*}" }
                    proto::ByteString.FromBase64("EiEvdjIve25hbWU9cHJvamVjdHMvKi9sb2NhdGlvbnMvKn0=")
                },
                {
                    "google.cloud.location.Locations.ListLocations",
                    // { "get": "/v2/{name=projects/*}/locations" }
                    proto::ByteString.FromBase64("Eh8vdjIve25hbWU9cHJvamVjdHMvKn0vbG9jYXRpb25z")
                },
                {
                    "google.longrunning.Operations.CancelOperation",
                    // { "post": "/v2/{name=projects/*/operations/*}:cancel", "additionalBindings": [ { "post": "/v2/{name=projects/*/locations/*/operations/*}:cancel" } ] }
                    proto::ByteString.FromBase64("IikvdjIve25hbWU9cHJvamVjdHMvKi9vcGVyYXRpb25zLyp9OmNhbmNlbFo3IjUvdjIve25hbWU9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9vcGVyYXRpb25zLyp9OmNhbmNlbA==")
                },
                {
                    "google.longrunning.Operations.GetOperation",
                    // { "get": "/v2/{name=projects/*/operations/*}", "additionalBindings": [ { "get": "/v2/{name=projects/*/locations/*/operations/*}" } ] }
                    proto::ByteString.FromBase64("EiIvdjIve25hbWU9cHJvamVjdHMvKi9vcGVyYXRpb25zLyp9WjASLi92Mi97bmFtZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL29wZXJhdGlvbnMvKn0=")
                },
                {
                    "google.longrunning.Operations.ListOperations",
                    // { "get": "/v2/{name=projects/*}/operations", "additionalBindings": [ { "get": "/v2/{name=projects/*/locations/*}/operations" } ] }
                    proto::ByteString.FromBase64("EiAvdjIve25hbWU9cHJvamVjdHMvKn0vb3BlcmF0aW9uc1ouEiwvdjIve25hbWU9cHJvamVjdHMvKi9sb2NhdGlvbnMvKn0vb3BlcmF0aW9ucw==")
                },
            });

        private static scg::IEnumerable<gpr::FileDescriptor> GetFileDescriptors()
        {
            yield return AgentReflection.Descriptor;
            yield return AnswerRecordReflection.Descriptor;
            yield return AudioConfigReflection.Descriptor;
            yield return ContextReflection.Descriptor;
            yield return ConversationReflection.Descriptor;
            yield return ConversationDatasetReflection.Descriptor;
            yield return ConversationEventReflection.Descriptor;
            yield return ConversationModelReflection.Descriptor;
            yield return ConversationProfileReflection.Descriptor;
            yield return DocumentReflection.Descriptor;
            yield return EntityTypeReflection.Descriptor;
            yield return EnvironmentReflection.Descriptor;
            yield return FulfillmentReflection.Descriptor;
            yield return GcsReflection.Descriptor;
            yield return HumanAgentAssistantEventReflection.Descriptor;
            yield return IntentReflection.Descriptor;
            yield return KnowledgeBaseReflection.Descriptor;
            yield return ParticipantReflection.Descriptor;
            yield return SessionReflection.Descriptor;
            yield return SessionEntityTypeReflection.Descriptor;
            yield return ValidationResultReflection.Descriptor;
            yield return VersionReflection.Descriptor;
            yield return WebhookReflection.Descriptor;
            yield return gcl::LocationsReflection.Descriptor;
            yield return lro::OperationsReflection.Descriptor;
        }
    }
}
