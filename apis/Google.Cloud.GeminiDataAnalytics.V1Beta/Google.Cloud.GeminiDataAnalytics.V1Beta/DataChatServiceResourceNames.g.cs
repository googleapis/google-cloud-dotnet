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
using gagr = Google.Api.Gax.ResourceNames;
using sys = System;

namespace Google.Cloud.GeminiDataAnalytics.V1Beta
{
    public partial class ListMessagesRequest
    {
        /// <summary>
        /// <see cref="ConversationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ConversationName ParentAsConversationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ConversationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class ChatRequest
    {
        /// <summary>
        /// <see cref="gagr::ProjectName"/>-typed view over the <see cref="Project"/> resource name property.
        /// </summary>
        [sys::ObsoleteAttribute]
        public gagr::ProjectName ProjectAsProjectName
        {
            get => string.IsNullOrEmpty(Project) ? null : gagr::ProjectName.Parse(Project, allowUnparsed: true);
            set => Project = value?.ToString() ?? "";
        }
    }

    public partial class DataAgentContext
    {
        /// <summary>
        /// <see cref="DataAgentName"/>-typed view over the <see cref="DataAgent"/> resource name property.
        /// </summary>
        public DataAgentName DataAgentAsDataAgentName
        {
            get => string.IsNullOrEmpty(DataAgent) ? null : DataAgentName.Parse(DataAgent, allowUnparsed: true);
            set => DataAgent = value?.ToString() ?? "";
        }
    }

    public partial class ConversationReference
    {
        /// <summary>
        /// <see cref="ConversationName"/>-typed view over the <see cref="Conversation"/> resource name property.
        /// </summary>
        public ConversationName ConversationAsConversationName
        {
            get => string.IsNullOrEmpty(Conversation) ? null : ConversationName.Parse(Conversation, allowUnparsed: true);
            set => Conversation = value?.ToString() ?? "";
        }
    }
}
