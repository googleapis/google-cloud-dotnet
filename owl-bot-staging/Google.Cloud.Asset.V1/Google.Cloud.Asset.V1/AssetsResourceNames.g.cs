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
using gax = Google.Api.Gax;

namespace Google.Cloud.Asset.V1
{
    public partial class Asset
    {
        /// <summary>
        /// <see cref="gax::IResourceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gax::IResourceName ResourceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gax::UnparsedResourceName.Parse(Name);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class RelatedAsset
    {
        /// <summary>
        /// <see cref="gax::IResourceName"/>-typed view over the <see cref="Asset"/> resource name property.
        /// </summary>
        public gax::IResourceName AssetAsResourceName
        {
            get => string.IsNullOrEmpty(Asset) ? null : gax::UnparsedResourceName.Parse(Asset);
            set => Asset = value?.ToString() ?? "";
        }
    }
}
