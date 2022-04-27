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

namespace Google.Cloud.Dialogflow.V2
{
    /// <summary>Static class to provide common access to package-wide API metadata.</summary>
    internal static class PackageApiMetadata
    {
        /// <summary>The <see cref="gaxgrpc::ApiMetadata"/> for services in this package.</summary>
        internal static gaxgrpc::ApiMetadata ApiMetadata { get; } = new gaxgrpc::ApiMetadata("Google.Cloud.Dialogflow.V2", GetFileDescriptors);

        private static scg::IEnumerable<gpr::FileDescriptor> GetFileDescriptors()
        {
            yield return ValidationResultReflection.Descriptor;
            yield return AgentReflection.Descriptor;
            yield return AudioConfigReflection.Descriptor;
            yield return ContextReflection.Descriptor;
            yield return IntentReflection.Descriptor;
            yield return EntityTypeReflection.Descriptor;
            yield return SessionEntityTypeReflection.Descriptor;
            yield return SessionReflection.Descriptor;
            yield return ParticipantReflection.Descriptor;
            yield return AnswerRecordReflection.Descriptor;
            yield return ConversationReflection.Descriptor;
            yield return GcsReflection.Descriptor;
            yield return ConversationDatasetReflection.Descriptor;
            yield return ConversationEventReflection.Descriptor;
            yield return ConversationModelReflection.Descriptor;
            yield return ConversationProfileReflection.Descriptor;
            yield return DocumentReflection.Descriptor;
            yield return FulfillmentReflection.Descriptor;
            yield return EnvironmentReflection.Descriptor;
            yield return HumanAgentAssistantEventReflection.Descriptor;
            yield return KnowledgeBaseReflection.Descriptor;
            yield return VersionReflection.Descriptor;
            yield return WebhookReflection.Descriptor;
        }
    }
}
