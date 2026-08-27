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
    public partial class GetAudienceSegmentRequest
    {
        /// <summary>
        /// <see cref="gaav::AudienceSegmentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gaav::AudienceSegmentName AudienceSegmentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::AudienceSegmentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListAudienceSegmentsRequest
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

    public partial class BatchActivateAudienceSegmentsRequest
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
        /// <see cref="AudienceSegmentName"/>-typed view over the <see cref="Names"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<AudienceSegmentName> AudienceSegmentNames
        {
            get => new gax::ResourceNameList<AudienceSegmentName>(Names, s => string.IsNullOrEmpty(s) ? null : AudienceSegmentName.Parse(s, allowUnparsed: true));
        }
    }

    public partial class BatchDeactivateAudienceSegmentsRequest
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
        /// <see cref="AudienceSegmentName"/>-typed view over the <see cref="Names"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<AudienceSegmentName> AudienceSegmentNames
        {
            get => new gax::ResourceNameList<AudienceSegmentName>(Names, s => string.IsNullOrEmpty(s) ? null : AudienceSegmentName.Parse(s, allowUnparsed: true));
        }
    }

    public partial class BatchApproveAudienceSegmentsRequest
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
        /// <see cref="AudienceSegmentName"/>-typed view over the <see cref="Names"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<AudienceSegmentName> AudienceSegmentNames
        {
            get => new gax::ResourceNameList<AudienceSegmentName>(Names, s => string.IsNullOrEmpty(s) ? null : AudienceSegmentName.Parse(s, allowUnparsed: true));
        }
    }

    public partial class BatchRejectAudienceSegmentsRequest
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
        /// <see cref="AudienceSegmentName"/>-typed view over the <see cref="Names"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<AudienceSegmentName> AudienceSegmentNames
        {
            get => new gax::ResourceNameList<AudienceSegmentName>(Names, s => string.IsNullOrEmpty(s) ? null : AudienceSegmentName.Parse(s, allowUnparsed: true));
        }
    }

    public partial class BatchPopulateAudienceSegmentsRequest
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
        /// <see cref="AudienceSegmentName"/>-typed view over the <see cref="Names"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<AudienceSegmentName> AudienceSegmentNames
        {
            get => new gax::ResourceNameList<AudienceSegmentName>(Names, s => string.IsNullOrEmpty(s) ? null : AudienceSegmentName.Parse(s, allowUnparsed: true));
        }
    }
}
