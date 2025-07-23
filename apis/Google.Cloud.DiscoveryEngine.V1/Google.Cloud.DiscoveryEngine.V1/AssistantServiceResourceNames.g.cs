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
using gcdv = Google.Cloud.DiscoveryEngine.V1;

namespace Google.Cloud.DiscoveryEngine.V1
{
    public partial class StreamAssistRequest
    {
        /// <summary>
        /// <see cref="gcdv::AssistantName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::AssistantName AssistantName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::AssistantName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="SessionName"/>-typed view over the <see cref="Session"/> resource name property.
        /// </summary>
        public SessionName SessionAsSessionName
        {
            get => string.IsNullOrEmpty(Session) ? null : SessionName.Parse(Session, allowUnparsed: true);
            set => Session = value?.ToString() ?? "";
        }
    }

    public partial class StreamAssistResponse
    {
        public partial class Types
        {
            public partial class SessionInfo
            {
                /// <summary>
                /// <see cref="SessionName"/>-typed view over the <see cref="Session"/> resource name property.
                /// </summary>
                public SessionName SessionAsSessionName
                {
                    get => string.IsNullOrEmpty(Session) ? null : SessionName.Parse(Session, allowUnparsed: true);
                    set => Session = value?.ToString() ?? "";
                }
            }
        }
    }
}
