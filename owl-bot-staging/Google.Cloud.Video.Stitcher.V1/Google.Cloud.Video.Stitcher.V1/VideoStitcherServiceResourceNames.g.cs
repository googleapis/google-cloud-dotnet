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
using gcvsv = Google.Cloud.Video.Stitcher.V1;

namespace Google.Cloud.Video.Stitcher.V1
{
    public partial class CreateCdnKeyRequest
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

    public partial class ListCdnKeysRequest
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

    public partial class GetCdnKeyRequest
    {
        /// <summary>
        /// <see cref="gcvsv::CdnKeyName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvsv::CdnKeyName CdnKeyName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvsv::CdnKeyName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteCdnKeyRequest
    {
        /// <summary>
        /// <see cref="gcvsv::CdnKeyName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvsv::CdnKeyName CdnKeyName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvsv::CdnKeyName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateVodSessionRequest
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

    public partial class GetVodSessionRequest
    {
        /// <summary>
        /// <see cref="gcvsv::VodSessionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvsv::VodSessionName VodSessionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvsv::VodSessionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListVodStitchDetailsRequest
    {
        /// <summary>
        /// <see cref="VodSessionName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public VodSessionName ParentAsVodSessionName
        {
            get => string.IsNullOrEmpty(Parent) ? null : VodSessionName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetVodStitchDetailRequest
    {
        /// <summary>
        /// <see cref="gcvsv::VodStitchDetailName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvsv::VodStitchDetailName VodStitchDetailName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvsv::VodStitchDetailName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListVodAdTagDetailsRequest
    {
        /// <summary>
        /// <see cref="VodSessionName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public VodSessionName ParentAsVodSessionName
        {
            get => string.IsNullOrEmpty(Parent) ? null : VodSessionName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetVodAdTagDetailRequest
    {
        /// <summary>
        /// <see cref="gcvsv::VodAdTagDetailName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvsv::VodAdTagDetailName VodAdTagDetailName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvsv::VodAdTagDetailName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListLiveAdTagDetailsRequest
    {
        /// <summary>
        /// <see cref="LiveSessionName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public LiveSessionName ParentAsLiveSessionName
        {
            get => string.IsNullOrEmpty(Parent) ? null : LiveSessionName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetLiveAdTagDetailRequest
    {
        /// <summary>
        /// <see cref="gcvsv::LiveAdTagDetailName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvsv::LiveAdTagDetailName LiveAdTagDetailName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvsv::LiveAdTagDetailName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateSlateRequest
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

    public partial class GetSlateRequest
    {
        /// <summary>
        /// <see cref="gcvsv::SlateName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvsv::SlateName SlateName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvsv::SlateName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListSlatesRequest
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

    public partial class DeleteSlateRequest
    {
        /// <summary>
        /// <see cref="gcvsv::SlateName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvsv::SlateName SlateName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvsv::SlateName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateLiveSessionRequest
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

    public partial class GetLiveSessionRequest
    {
        /// <summary>
        /// <see cref="gcvsv::LiveSessionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvsv::LiveSessionName LiveSessionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvsv::LiveSessionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateLiveConfigRequest
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

    public partial class ListLiveConfigsRequest
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

    public partial class GetLiveConfigRequest
    {
        /// <summary>
        /// <see cref="gcvsv::LiveConfigName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvsv::LiveConfigName LiveConfigName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvsv::LiveConfigName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteLiveConfigRequest
    {
        /// <summary>
        /// <see cref="gcvsv::LiveConfigName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvsv::LiveConfigName LiveConfigName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvsv::LiveConfigName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateVodConfigRequest
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

    public partial class ListVodConfigsRequest
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

    public partial class GetVodConfigRequest
    {
        /// <summary>
        /// <see cref="gcvsv::VodConfigName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvsv::VodConfigName VodConfigName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvsv::VodConfigName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteVodConfigRequest
    {
        /// <summary>
        /// <see cref="gcvsv::VodConfigName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvsv::VodConfigName VodConfigName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvsv::VodConfigName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
