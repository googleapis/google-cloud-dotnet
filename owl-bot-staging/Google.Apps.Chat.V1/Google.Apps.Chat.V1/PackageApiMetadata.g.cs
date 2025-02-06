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
using scg = System.Collections.Generic;

namespace Google.Apps.Chat.V1
{
    /// <summary>Static class to provide common access to package-wide API metadata.</summary>
    internal static class PackageApiMetadata
    {
        /// <summary>The <see cref="gaxgrpc::ApiMetadata"/> for services in this package.</summary>
        internal static gaxgrpc::ApiMetadata ApiMetadata { get; } = new gaxgrpc::ApiMetadata("Google.Apps.Chat.V1", GetFileDescriptors)
            .WithRequestNumericEnumJsonEncoding(true);

        private static scg::IEnumerable<gpr::FileDescriptor> GetFileDescriptors()
        {
            yield return ActionStatusReflection.Descriptor;
            yield return AnnotationReflection.Descriptor;
            yield return AttachmentReflection.Descriptor;
            yield return ChatServiceReflection.Descriptor;
            yield return ContextualAddonReflection.Descriptor;
            yield return DeletionMetadataReflection.Descriptor;
            yield return EventPayloadReflection.Descriptor;
            yield return GroupReflection.Descriptor;
            yield return HistoryStateReflection.Descriptor;
            yield return MatchedUrlReflection.Descriptor;
            yield return MembershipReflection.Descriptor;
            yield return MessageReflection.Descriptor;
            yield return ReactionReflection.Descriptor;
            yield return SlashCommandReflection.Descriptor;
            yield return SpaceReflection.Descriptor;
            yield return SpaceEventReflection.Descriptor;
            yield return SpaceReadStateReflection.Descriptor;
            yield return SpaceSetupReflection.Descriptor;
            yield return ThreadReadStateReflection.Descriptor;
            yield return UserReflection.Descriptor;
            yield return WidgetsReflection.Descriptor;
        }
    }
}
