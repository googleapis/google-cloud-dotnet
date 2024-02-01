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
using gagr = Google.Api.Gax.ResourceNames;
using gcev = Google.Cloud.Eventarc.V1;

namespace Google.Cloud.Eventarc.V1
{
    public partial class GetTriggerRequest
    {
        /// <summary>
        /// <see cref="gcev::TriggerName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcev::TriggerName TriggerName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcev::TriggerName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListTriggersRequest
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

    public partial class CreateTriggerRequest
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

    public partial class DeleteTriggerRequest
    {
        /// <summary>
        /// <see cref="gcev::TriggerName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcev::TriggerName TriggerName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcev::TriggerName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetChannelRequest
    {
        /// <summary>
        /// <see cref="gcev::ChannelName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcev::ChannelName ChannelName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcev::ChannelName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
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

    public partial class DeleteChannelRequest
    {
        /// <summary>
        /// <see cref="gcev::ChannelName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcev::ChannelName ChannelName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcev::ChannelName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetProviderRequest
    {
        /// <summary>
        /// <see cref="gcev::ProviderName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcev::ProviderName ProviderName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcev::ProviderName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListProvidersRequest
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

    public partial class GetChannelConnectionRequest
    {
        /// <summary>
        /// <see cref="gcev::ChannelConnectionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcev::ChannelConnectionName ChannelConnectionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcev::ChannelConnectionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListChannelConnectionsRequest
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

    public partial class CreateChannelConnectionRequest
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

    public partial class DeleteChannelConnectionRequest
    {
        /// <summary>
        /// <see cref="gcev::ChannelConnectionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcev::ChannelConnectionName ChannelConnectionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcev::ChannelConnectionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetGoogleChannelConfigRequest
    {
        /// <summary>
        /// <see cref="gcev::GoogleChannelConfigName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcev::GoogleChannelConfigName GoogleChannelConfigName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcev::GoogleChannelConfigName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
