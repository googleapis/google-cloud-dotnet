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

namespace Google.Ads.AdManager.V1
{
    public partial class SearchAdReviewCenterAdsRequest
    {
        /// <summary>
        /// <see cref="WebPropertyName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public WebPropertyName ParentAsWebPropertyName
        {
            get => string.IsNullOrEmpty(Parent) ? null : WebPropertyName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class BatchAllowAdReviewCenterAdsRequest
    {
        /// <summary>
        /// <see cref="WebPropertyName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public WebPropertyName ParentAsWebPropertyName
        {
            get => string.IsNullOrEmpty(Parent) ? null : WebPropertyName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="AdReviewCenterAdName"/>-typed view over the <see cref="Names"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<AdReviewCenterAdName> AdReviewCenterAdNames
        {
            get => new gax::ResourceNameList<AdReviewCenterAdName>(Names, s => string.IsNullOrEmpty(s) ? null : AdReviewCenterAdName.Parse(s, allowUnparsed: true));
        }
    }

    public partial class BatchBlockAdReviewCenterAdsRequest
    {
        /// <summary>
        /// <see cref="WebPropertyName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public WebPropertyName ParentAsWebPropertyName
        {
            get => string.IsNullOrEmpty(Parent) ? null : WebPropertyName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="AdReviewCenterAdName"/>-typed view over the <see cref="Names"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<AdReviewCenterAdName> AdReviewCenterAdNames
        {
            get => new gax::ResourceNameList<AdReviewCenterAdName>(Names, s => string.IsNullOrEmpty(s) ? null : AdReviewCenterAdName.Parse(s, allowUnparsed: true));
        }
    }
}
