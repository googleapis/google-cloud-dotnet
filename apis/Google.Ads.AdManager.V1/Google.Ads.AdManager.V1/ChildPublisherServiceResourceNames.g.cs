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
    public partial class GetChildPublisherRequest
    {
        /// <summary>
        /// <see cref="gaav::ChildPublisherName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gaav::ChildPublisherName ChildPublisherName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::ChildPublisherName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListChildPublishersRequest
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

    public partial class CreateChildPublisherRequest
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

    public partial class BatchCreateChildPublishersRequest
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

    public partial class BatchUpdateChildPublishersRequest
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

    public partial class RenegotiateChildPublisherAgreementRequest
    {
        /// <summary>
        /// <see cref="gaav::ChildPublisherName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gaav::ChildPublisherName ChildPublisherName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::ChildPublisherName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="NetworkName"/>-typed view over the <see cref="Network"/> resource name property.
        /// </summary>
        public NetworkName NetworkAsNetworkName
        {
            get => string.IsNullOrEmpty(Network) ? null : NetworkName.Parse(Network, allowUnparsed: true);
            set => Network = value?.ToString() ?? "";
        }
    }

    public partial class BatchRenegotiateChildPublisherAgreementsRequest
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

    public partial class BatchResendChildPublisherInvitationEmailsRequest
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
        /// <see cref="ChildPublisherName"/>-typed view over the <see cref="Names"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<ChildPublisherName> ChildPublisherNames
        {
            get => new gax::ResourceNameList<ChildPublisherName>(Names, s => string.IsNullOrEmpty(s) ? null : ChildPublisherName.Parse(s, allowUnparsed: true));
        }
    }

    public partial class BatchWithdrawChildPublishersRequest
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
        /// <see cref="ChildPublisherName"/>-typed view over the <see cref="Names"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<ChildPublisherName> ChildPublisherNames
        {
            get => new gax::ResourceNameList<ChildPublisherName>(Names, s => string.IsNullOrEmpty(s) ? null : ChildPublisherName.Parse(s, allowUnparsed: true));
        }
    }

    public partial class BatchRejectChildPublishersRequest
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
        /// <see cref="ChildPublisherName"/>-typed view over the <see cref="Names"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<ChildPublisherName> ChildPublisherNames
        {
            get => new gax::ResourceNameList<ChildPublisherName>(Names, s => string.IsNullOrEmpty(s) ? null : ChildPublisherName.Parse(s, allowUnparsed: true));
        }
    }
}
