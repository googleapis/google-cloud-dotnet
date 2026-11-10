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
    public partial class GetProposalRequest
    {
        /// <summary>
        /// <see cref="gaav::ProposalName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gaav::ProposalName ProposalName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::ProposalName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListProposalsRequest
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

    public partial class CreateProposalRequest
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

    public partial class BatchCreateProposalsRequest
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

    public partial class BatchUpdateProposalsRequest
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

    public partial class BatchArchiveProposalsRequest
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
        /// <see cref="ProposalName"/>-typed view over the <see cref="Names"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<ProposalName> ProposalNames
        {
            get => new gax::ResourceNameList<ProposalName>(Names, s => string.IsNullOrEmpty(s) ? null : ProposalName.Parse(s, allowUnparsed: true));
        }
    }

    public partial class BatchUnarchiveProposalsRequest
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
        /// <see cref="ProposalName"/>-typed view over the <see cref="Names"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<ProposalName> ProposalNames
        {
            get => new gax::ResourceNameList<ProposalName>(Names, s => string.IsNullOrEmpty(s) ? null : ProposalName.Parse(s, allowUnparsed: true));
        }
    }

    public partial class BatchPauseProposalsRequest
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
        /// <see cref="ProposalName"/>-typed view over the <see cref="Names"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<ProposalName> ProposalNames
        {
            get => new gax::ResourceNameList<ProposalName>(Names, s => string.IsNullOrEmpty(s) ? null : ProposalName.Parse(s, allowUnparsed: true));
        }
    }

    public partial class BatchResumeProposalsRequest
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
        /// <see cref="ProposalName"/>-typed view over the <see cref="Names"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<ProposalName> ProposalNames
        {
            get => new gax::ResourceNameList<ProposalName>(Names, s => string.IsNullOrEmpty(s) ? null : ProposalName.Parse(s, allowUnparsed: true));
        }
    }

    public partial class BatchRequestBuyerReviewProposalsRequest
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
        /// <see cref="ProposalName"/>-typed view over the <see cref="Names"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<ProposalName> ProposalNames
        {
            get => new gax::ResourceNameList<ProposalName>(Names, s => string.IsNullOrEmpty(s) ? null : ProposalName.Parse(s, allowUnparsed: true));
        }
    }

    public partial class BatchRequestBuyerAcceptProposalsRequest
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
        /// <see cref="ProposalName"/>-typed view over the <see cref="Names"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<ProposalName> ProposalNames
        {
            get => new gax::ResourceNameList<ProposalName>(Names, s => string.IsNullOrEmpty(s) ? null : ProposalName.Parse(s, allowUnparsed: true));
        }
    }

    public partial class BatchReserveProposalsRequest
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
        /// <see cref="ProposalName"/>-typed view over the <see cref="Names"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<ProposalName> ProposalNames
        {
            get => new gax::ResourceNameList<ProposalName>(Names, s => string.IsNullOrEmpty(s) ? null : ProposalName.Parse(s, allowUnparsed: true));
        }
    }

    public partial class BatchRedraftProposalsRequest
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
        /// <see cref="ProposalName"/>-typed view over the <see cref="Names"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<ProposalName> ProposalNames
        {
            get => new gax::ResourceNameList<ProposalName>(Names, s => string.IsNullOrEmpty(s) ? null : ProposalName.Parse(s, allowUnparsed: true));
        }
    }

    public partial class BatchDiscardDraftProposalsRequest
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
        /// <see cref="ProposalName"/>-typed view over the <see cref="Names"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<ProposalName> ProposalNames
        {
            get => new gax::ResourceNameList<ProposalName>(Names, s => string.IsNullOrEmpty(s) ? null : ProposalName.Parse(s, allowUnparsed: true));
        }
    }

    public partial class BatchTerminateProposalsRequest
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
        /// <see cref="ProposalName"/>-typed view over the <see cref="Names"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<ProposalName> ProposalNames
        {
            get => new gax::ResourceNameList<ProposalName>(Names, s => string.IsNullOrEmpty(s) ? null : ProposalName.Parse(s, allowUnparsed: true));
        }
    }

    public partial class BatchPushToOrderProposalsRequest
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
        /// <see cref="ProposalName"/>-typed view over the <see cref="Names"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<ProposalName> ProposalNames
        {
            get => new gax::ResourceNameList<ProposalName>(Names, s => string.IsNullOrEmpty(s) ? null : ProposalName.Parse(s, allowUnparsed: true));
        }
    }

    public partial class FetchMarketplaceCommentsRequest
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
        /// <see cref="ProposalName"/>-typed view over the <see cref="Names"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<ProposalName> ProposalNames
        {
            get => new gax::ResourceNameList<ProposalName>(Names, s => string.IsNullOrEmpty(s) ? null : ProposalName.Parse(s, allowUnparsed: true));
        }
    }
}
