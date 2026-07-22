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
    public partial class BatchApproveAndOverbookOrdersRequest
    {
        /// <summary>
        /// <see cref="NetworkName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public NetworkName ParentAsNetworkName
        {
            get => string.IsNullOrEmpty(Parent) ? null : NetworkName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary><see cref="OrderName"/>-typed view over the <see cref="Names"/> resource name property.</summary>
        public gax::ResourceNameList<OrderName> OrderNames
        {
            get => new gax::ResourceNameList<OrderName>(Names, s => string.IsNullOrEmpty(s) ? null : OrderName.Parse(s, allowUnparsed: true));
        }
    }

    public partial class BatchApproveOrdersRequest
    {
        /// <summary>
        /// <see cref="NetworkName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public NetworkName ParentAsNetworkName
        {
            get => string.IsNullOrEmpty(Parent) ? null : NetworkName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary><see cref="OrderName"/>-typed view over the <see cref="Names"/> resource name property.</summary>
        public gax::ResourceNameList<OrderName> OrderNames
        {
            get => new gax::ResourceNameList<OrderName>(Names, s => string.IsNullOrEmpty(s) ? null : OrderName.Parse(s, allowUnparsed: true));
        }
    }

    public partial class BatchSubmitOrdersForApprovalRequest
    {
        /// <summary>
        /// <see cref="NetworkName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public NetworkName ParentAsNetworkName
        {
            get => string.IsNullOrEmpty(Parent) ? null : NetworkName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary><see cref="OrderName"/>-typed view over the <see cref="Names"/> resource name property.</summary>
        public gax::ResourceNameList<OrderName> OrderNames
        {
            get => new gax::ResourceNameList<OrderName>(Names, s => string.IsNullOrEmpty(s) ? null : OrderName.Parse(s, allowUnparsed: true));
        }
    }

    public partial class BatchSubmitOrdersForApprovalAndOverbookRequest
    {
        /// <summary>
        /// <see cref="NetworkName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public NetworkName ParentAsNetworkName
        {
            get => string.IsNullOrEmpty(Parent) ? null : NetworkName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary><see cref="OrderName"/>-typed view over the <see cref="Names"/> resource name property.</summary>
        public gax::ResourceNameList<OrderName> OrderNames
        {
            get => new gax::ResourceNameList<OrderName>(Names, s => string.IsNullOrEmpty(s) ? null : OrderName.Parse(s, allowUnparsed: true));
        }
    }

    public partial class BatchPauseOrdersRequest
    {
        /// <summary>
        /// <see cref="NetworkName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public NetworkName ParentAsNetworkName
        {
            get => string.IsNullOrEmpty(Parent) ? null : NetworkName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary><see cref="OrderName"/>-typed view over the <see cref="Names"/> resource name property.</summary>
        public gax::ResourceNameList<OrderName> OrderNames
        {
            get => new gax::ResourceNameList<OrderName>(Names, s => string.IsNullOrEmpty(s) ? null : OrderName.Parse(s, allowUnparsed: true));
        }
    }

    public partial class BatchResumeOrdersRequest
    {
        /// <summary>
        /// <see cref="NetworkName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public NetworkName ParentAsNetworkName
        {
            get => string.IsNullOrEmpty(Parent) ? null : NetworkName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary><see cref="OrderName"/>-typed view over the <see cref="Names"/> resource name property.</summary>
        public gax::ResourceNameList<OrderName> OrderNames
        {
            get => new gax::ResourceNameList<OrderName>(Names, s => string.IsNullOrEmpty(s) ? null : OrderName.Parse(s, allowUnparsed: true));
        }
    }

    public partial class BatchResumeAndOverbookOrdersRequest
    {
        /// <summary>
        /// <see cref="NetworkName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public NetworkName ParentAsNetworkName
        {
            get => string.IsNullOrEmpty(Parent) ? null : NetworkName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary><see cref="OrderName"/>-typed view over the <see cref="Names"/> resource name property.</summary>
        public gax::ResourceNameList<OrderName> OrderNames
        {
            get => new gax::ResourceNameList<OrderName>(Names, s => string.IsNullOrEmpty(s) ? null : OrderName.Parse(s, allowUnparsed: true));
        }
    }

    public partial class BatchApproveOrdersWithoutReservationRequest
    {
        /// <summary>
        /// <see cref="NetworkName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public NetworkName ParentAsNetworkName
        {
            get => string.IsNullOrEmpty(Parent) ? null : NetworkName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary><see cref="OrderName"/>-typed view over the <see cref="Names"/> resource name property.</summary>
        public gax::ResourceNameList<OrderName> OrderNames
        {
            get => new gax::ResourceNameList<OrderName>(Names, s => string.IsNullOrEmpty(s) ? null : OrderName.Parse(s, allowUnparsed: true));
        }
    }

    public partial class BatchArchiveOrdersRequest
    {
        /// <summary>
        /// <see cref="NetworkName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public NetworkName ParentAsNetworkName
        {
            get => string.IsNullOrEmpty(Parent) ? null : NetworkName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary><see cref="OrderName"/>-typed view over the <see cref="Names"/> resource name property.</summary>
        public gax::ResourceNameList<OrderName> OrderNames
        {
            get => new gax::ResourceNameList<OrderName>(Names, s => string.IsNullOrEmpty(s) ? null : OrderName.Parse(s, allowUnparsed: true));
        }
    }

    public partial class BatchUnarchiveOrdersRequest
    {
        /// <summary>
        /// <see cref="NetworkName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public NetworkName ParentAsNetworkName
        {
            get => string.IsNullOrEmpty(Parent) ? null : NetworkName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary><see cref="OrderName"/>-typed view over the <see cref="Names"/> resource name property.</summary>
        public gax::ResourceNameList<OrderName> OrderNames
        {
            get => new gax::ResourceNameList<OrderName>(Names, s => string.IsNullOrEmpty(s) ? null : OrderName.Parse(s, allowUnparsed: true));
        }
    }

    public partial class BatchDeleteOrdersRequest
    {
        /// <summary>
        /// <see cref="NetworkName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public NetworkName ParentAsNetworkName
        {
            get => string.IsNullOrEmpty(Parent) ? null : NetworkName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary><see cref="OrderName"/>-typed view over the <see cref="Names"/> resource name property.</summary>
        public gax::ResourceNameList<OrderName> OrderNames
        {
            get => new gax::ResourceNameList<OrderName>(Names, s => string.IsNullOrEmpty(s) ? null : OrderName.Parse(s, allowUnparsed: true));
        }
    }

    public partial class BatchDisapproveOrdersRequest
    {
        /// <summary>
        /// <see cref="NetworkName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public NetworkName ParentAsNetworkName
        {
            get => string.IsNullOrEmpty(Parent) ? null : NetworkName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary><see cref="OrderName"/>-typed view over the <see cref="Names"/> resource name property.</summary>
        public gax::ResourceNameList<OrderName> OrderNames
        {
            get => new gax::ResourceNameList<OrderName>(Names, s => string.IsNullOrEmpty(s) ? null : OrderName.Parse(s, allowUnparsed: true));
        }
    }

    public partial class BatchDisapproveOrdersWithoutReservationChangesRequest
    {
        /// <summary>
        /// <see cref="NetworkName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public NetworkName ParentAsNetworkName
        {
            get => string.IsNullOrEmpty(Parent) ? null : NetworkName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary><see cref="OrderName"/>-typed view over the <see cref="Names"/> resource name property.</summary>
        public gax::ResourceNameList<OrderName> OrderNames
        {
            get => new gax::ResourceNameList<OrderName>(Names, s => string.IsNullOrEmpty(s) ? null : OrderName.Parse(s, allowUnparsed: true));
        }
    }

    public partial class BatchRetractOrdersRequest
    {
        /// <summary>
        /// <see cref="NetworkName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public NetworkName ParentAsNetworkName
        {
            get => string.IsNullOrEmpty(Parent) ? null : NetworkName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary><see cref="OrderName"/>-typed view over the <see cref="Names"/> resource name property.</summary>
        public gax::ResourceNameList<OrderName> OrderNames
        {
            get => new gax::ResourceNameList<OrderName>(Names, s => string.IsNullOrEmpty(s) ? null : OrderName.Parse(s, allowUnparsed: true));
        }
    }

    public partial class BatchRetractOrdersWithoutReservationChangesRequest
    {
        /// <summary>
        /// <see cref="NetworkName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public NetworkName ParentAsNetworkName
        {
            get => string.IsNullOrEmpty(Parent) ? null : NetworkName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary><see cref="OrderName"/>-typed view over the <see cref="Names"/> resource name property.</summary>
        public gax::ResourceNameList<OrderName> OrderNames
        {
            get => new gax::ResourceNameList<OrderName>(Names, s => string.IsNullOrEmpty(s) ? null : OrderName.Parse(s, allowUnparsed: true));
        }
    }

    public partial class BatchSubmitOrdersForApprovalWithoutReservationChangesRequest
    {
        /// <summary>
        /// <see cref="NetworkName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public NetworkName ParentAsNetworkName
        {
            get => string.IsNullOrEmpty(Parent) ? null : NetworkName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary><see cref="OrderName"/>-typed view over the <see cref="Names"/> resource name property.</summary>
        public gax::ResourceNameList<OrderName> OrderNames
        {
            get => new gax::ResourceNameList<OrderName>(Names, s => string.IsNullOrEmpty(s) ? null : OrderName.Parse(s, allowUnparsed: true));
        }
    }

    public partial class GetOrderRequest
    {
        /// <summary>
        /// <see cref="gaav::OrderName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gaav::OrderName OrderName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::OrderName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListOrdersRequest
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

    public partial class CreateOrderRequest
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

    public partial class BatchCreateOrdersRequest
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

    public partial class BatchUpdateOrdersRequest
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
}
