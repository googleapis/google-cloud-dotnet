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
    public partial class GetAdUnitRequest
    {
        /// <summary>
        /// <see cref="gaav::AdUnitName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gaav::AdUnitName AdUnitName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::AdUnitName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListAdUnitsRequest
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

    public partial class CreateAdUnitRequest
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

    public partial class BatchCreateAdUnitsRequest
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

    public partial class BatchUpdateAdUnitsRequest
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

    public partial class ListAdUnitSizesRequest
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

    public partial class BatchActivateAdUnitsRequest
    {
        /// <summary>
        /// <see cref="NetworkName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public NetworkName ParentAsNetworkName
        {
            get => string.IsNullOrEmpty(Parent) ? null : NetworkName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary><see cref="AdUnitName"/>-typed view over the <see cref="Names"/> resource name property.</summary>
        public gax::ResourceNameList<AdUnitName> AdUnitNames
        {
            get => new gax::ResourceNameList<AdUnitName>(Names, s => string.IsNullOrEmpty(s) ? null : AdUnitName.Parse(s, allowUnparsed: true));
        }
    }

    public partial class BatchDeactivateAdUnitsRequest
    {
        /// <summary>
        /// <see cref="NetworkName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public NetworkName ParentAsNetworkName
        {
            get => string.IsNullOrEmpty(Parent) ? null : NetworkName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary><see cref="AdUnitName"/>-typed view over the <see cref="Names"/> resource name property.</summary>
        public gax::ResourceNameList<AdUnitName> AdUnitNames
        {
            get => new gax::ResourceNameList<AdUnitName>(Names, s => string.IsNullOrEmpty(s) ? null : AdUnitName.Parse(s, allowUnparsed: true));
        }
    }

    public partial class BatchArchiveAdUnitsRequest
    {
        /// <summary>
        /// <see cref="NetworkName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public NetworkName ParentAsNetworkName
        {
            get => string.IsNullOrEmpty(Parent) ? null : NetworkName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary><see cref="AdUnitName"/>-typed view over the <see cref="Names"/> resource name property.</summary>
        public gax::ResourceNameList<AdUnitName> AdUnitNames
        {
            get => new gax::ResourceNameList<AdUnitName>(Names, s => string.IsNullOrEmpty(s) ? null : AdUnitName.Parse(s, allowUnparsed: true));
        }
    }
}
