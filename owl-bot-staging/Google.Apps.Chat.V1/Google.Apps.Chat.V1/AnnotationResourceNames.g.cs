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

namespace Google.Apps.Chat.V1
{
    public partial class ChatSpaceLinkData
    {
        /// <summary><see cref="SpaceName"/>-typed view over the <see cref="Space"/> resource name property.</summary>
        public SpaceName SpaceAsSpaceName
        {
            get => string.IsNullOrEmpty(Space) ? null : SpaceName.Parse(Space, allowUnparsed: true);
            set => Space = value?.ToString() ?? "";
        }

        /// <summary><see cref="ThreadName"/>-typed view over the <see cref="Thread"/> resource name property.</summary>
        public ThreadName ThreadAsThreadName
        {
            get => string.IsNullOrEmpty(Thread) ? null : ThreadName.Parse(Thread, allowUnparsed: true);
            set => Thread = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="MessageName"/>-typed view over the <see cref="Message"/> resource name property.
        /// </summary>
        public MessageName MessageAsMessageName
        {
            get => string.IsNullOrEmpty(Message) ? null : MessageName.Parse(Message, allowUnparsed: true);
            set => Message = value?.ToString() ?? "";
        }
    }
}
