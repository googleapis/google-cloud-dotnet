// Copyright 2026 Google LLC
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
using gaav = Google.Ads.AdManager.V1;
using gax = Google.Api.Gax;

namespace Google.Ads.AdManager.V1
{
    public partial class GetSuggestedAdUnitRequest
    {
        /// <summary>
        /// <see cref="gaav::SuggestedAdUnitName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gaav::SuggestedAdUnitName SuggestedAdUnitName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::SuggestedAdUnitName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListSuggestedAdUnitsRequest
    {
        /// <summary>
        /// <see cref="NetworkName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public NetworkName ParentAsNetworkName
        {
            get => string.IsNullOrEmpty(Parent) ? null : NetworkName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class BatchApproveSuggestedAdUnitsRequest
    {
        /// <summary>
        /// <see cref="NetworkName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public NetworkName ParentAsNetworkName
        {
            get => string.IsNullOrEmpty(Parent) ? null : NetworkName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="SuggestedAdUnitName"/>-typed view over the <see cref="Names"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<SuggestedAdUnitName> SuggestedAdUnitNames
        {
            get => new gax::ResourceNameList<SuggestedAdUnitName>(Names, s => string.IsNullOrEmpty(s) ? null : SuggestedAdUnitName.Parse(s, allowUnparsed: true));
        }
    }

    public partial class BatchApproveSuggestedAdUnitsResponse
    {
        /// <summary>
        /// <see cref="AdUnitName"/>-typed view over the <see cref="CreatedAdUnits"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<AdUnitName> CreatedAdUnitsAsAdUnitNames
        {
            get => new gax::ResourceNameList<AdUnitName>(CreatedAdUnits, s => string.IsNullOrEmpty(s) ? null : AdUnitName.Parse(s, allowUnparsed: true));
        }
    }
}
