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

using gagr = Google.Api.Gax.ResourceNames;
using gcvlv = Google.Cloud.Video.LiveStream.V1;

namespace Google.Cloud.Video.LiveStream.V1
{
    public partial class CreateChannelRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class ListChannelsRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetChannelRequest
    {
        /// <summary>
        /// <see cref="gcvlv::ChannelName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvlv::ChannelName ChannelName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvlv::ChannelName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteChannelRequest
    {
        /// <summary>
        /// <see cref="gcvlv::ChannelName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvlv::ChannelName ChannelName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvlv::ChannelName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class StartChannelRequest
    {
        /// <summary>
        /// <see cref="gcvlv::ChannelName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvlv::ChannelName ChannelName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvlv::ChannelName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class StopChannelRequest
    {
        /// <summary>
        /// <see cref="gcvlv::ChannelName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvlv::ChannelName ChannelName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvlv::ChannelName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateInputRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class ListInputsRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetInputRequest
    {
        /// <summary>
        /// <see cref="gcvlv::InputName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvlv::InputName InputName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvlv::InputName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteInputRequest
    {
        /// <summary>
        /// <see cref="gcvlv::InputName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvlv::InputName InputName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvlv::InputName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateEventRequest
    {
        /// <summary>
        /// <see cref="ChannelName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ChannelName ParentAsChannelName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ChannelName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class ListEventsRequest
    {
        /// <summary>
        /// <see cref="ChannelName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ChannelName ParentAsChannelName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ChannelName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetEventRequest
    {
        /// <summary>
        /// <see cref="gcvlv::EventName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvlv::EventName EventName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvlv::EventName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteEventRequest
    {
        /// <summary>
        /// <see cref="gcvlv::EventName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvlv::EventName EventName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvlv::EventName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
