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
using gcav = Google.Cloud.AIPlatform.V1Beta1;

namespace Google.Cloud.AIPlatform.V1Beta1
{
    public partial class CreateSessionRequest
    {
        /// <summary>
        /// <see cref="ReasoningEngineName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ReasoningEngineName ParentAsReasoningEngineName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ReasoningEngineName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetSessionRequest
    {
        /// <summary>
        /// <see cref="gcav::SessionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::SessionName SessionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::SessionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListSessionsRequest
    {
        /// <summary>
        /// <see cref="ReasoningEngineName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ReasoningEngineName ParentAsReasoningEngineName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ReasoningEngineName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteSessionRequest
    {
        /// <summary>
        /// <see cref="gcav::SessionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::SessionName SessionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::SessionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListEventsRequest
    {
        /// <summary>
        /// <see cref="SessionName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public SessionName ParentAsSessionName
        {
            get => string.IsNullOrEmpty(Parent) ? null : SessionName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class AppendEventRequest
    {
        /// <summary>
        /// <see cref="gcav::SessionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::SessionName SessionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::SessionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
