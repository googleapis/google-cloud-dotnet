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
using gcrv = Google.Cloud.Recommender.V1;

namespace Google.Cloud.Recommender.V1
{
    public partial class ListInsightsRequest
    {
        /// <summary>
        /// <see cref="InsightTypeName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public InsightTypeName ParentAsInsightTypeName
        {
            get => string.IsNullOrEmpty(Parent) ? null : InsightTypeName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetInsightRequest
    {
        /// <summary>
        /// <see cref="gcrv::InsightName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcrv::InsightName InsightName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcrv::InsightName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class MarkInsightAcceptedRequest
    {
        /// <summary>
        /// <see cref="gcrv::InsightName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcrv::InsightName InsightName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcrv::InsightName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListRecommendationsRequest
    {
        /// <summary>
        /// <see cref="RecommenderName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public RecommenderName ParentAsRecommenderName
        {
            get => string.IsNullOrEmpty(Parent) ? null : RecommenderName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetRecommendationRequest
    {
        /// <summary>
        /// <see cref="gcrv::RecommendationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcrv::RecommendationName RecommendationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcrv::RecommendationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class MarkRecommendationDismissedRequest
    {
        /// <summary>
        /// <see cref="gcrv::RecommendationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcrv::RecommendationName RecommendationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcrv::RecommendationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class MarkRecommendationClaimedRequest
    {
        /// <summary>
        /// <see cref="gcrv::RecommendationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcrv::RecommendationName RecommendationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcrv::RecommendationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class MarkRecommendationSucceededRequest
    {
        /// <summary>
        /// <see cref="gcrv::RecommendationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcrv::RecommendationName RecommendationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcrv::RecommendationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class MarkRecommendationFailedRequest
    {
        /// <summary>
        /// <see cref="gcrv::RecommendationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcrv::RecommendationName RecommendationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcrv::RecommendationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetRecommenderConfigRequest
    {
        /// <summary>
        /// <see cref="gcrv::RecommenderConfigName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcrv::RecommenderConfigName RecommenderConfigName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcrv::RecommenderConfigName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetInsightTypeConfigRequest
    {
        /// <summary>
        /// <see cref="gcrv::InsightTypeConfigName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcrv::InsightTypeConfigName InsightTypeConfigName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcrv::InsightTypeConfigName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
