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
using gcssv = Google.Cloud.SaasPlatform.SaasServiceMgmt.V1Beta1;

namespace Google.Cloud.SaasPlatform.SaasServiceMgmt.V1Beta1
{
    public partial class ListRolloutsRequest
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

    public partial class GetRolloutRequest
    {
        /// <summary>
        /// <see cref="gcssv::RolloutName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcssv::RolloutName RolloutName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcssv::RolloutName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateRolloutRequest
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

    public partial class DeleteRolloutRequest
    {
        /// <summary>
        /// <see cref="gcssv::RolloutName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcssv::RolloutName RolloutName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcssv::RolloutName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListRolloutKindsRequest
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

    public partial class GetRolloutKindRequest
    {
        /// <summary>
        /// <see cref="gcssv::RolloutKindName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcssv::RolloutKindName RolloutKindName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcssv::RolloutKindName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateRolloutKindRequest
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

    public partial class DeleteRolloutKindRequest
    {
        /// <summary>
        /// <see cref="gcssv::RolloutKindName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcssv::RolloutKindName RolloutKindName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcssv::RolloutKindName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
