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
using gcgv = Google.Cloud.GdcHardwareManagement.V1Alpha;

namespace Google.Cloud.GdcHardwareManagement.V1Alpha
{
    public partial class ListOrdersRequest
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

    public partial class GetOrderRequest
    {
        /// <summary>
        /// <see cref="gcgv::OrderName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcgv::OrderName OrderName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcgv::OrderName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateOrderRequest
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

    public partial class DeleteOrderRequest
    {
        /// <summary>
        /// <see cref="gcgv::OrderName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcgv::OrderName OrderName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcgv::OrderName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class SubmitOrderRequest
    {
        /// <summary>
        /// <see cref="gcgv::OrderName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcgv::OrderName OrderName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcgv::OrderName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CancelOrderRequest
    {
        /// <summary>
        /// <see cref="gcgv::OrderName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcgv::OrderName OrderName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcgv::OrderName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListSitesRequest
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

    public partial class GetSiteRequest
    {
        /// <summary>
        /// <see cref="gcgv::SiteName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcgv::SiteName SiteName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcgv::SiteName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateSiteRequest
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

    public partial class DeleteSiteRequest
    {
        /// <summary>
        /// <see cref="gcgv::SiteName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcgv::SiteName SiteName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcgv::SiteName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListHardwareGroupsRequest
    {
        /// <summary><see cref="OrderName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public OrderName ParentAsOrderName
        {
            get => string.IsNullOrEmpty(Parent) ? null : OrderName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetHardwareGroupRequest
    {
        /// <summary>
        /// <see cref="gcgv::HardwareGroupName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcgv::HardwareGroupName HardwareGroupName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcgv::HardwareGroupName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateHardwareGroupRequest
    {
        /// <summary><see cref="OrderName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public OrderName ParentAsOrderName
        {
            get => string.IsNullOrEmpty(Parent) ? null : OrderName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteHardwareGroupRequest
    {
        /// <summary>
        /// <see cref="gcgv::HardwareGroupName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcgv::HardwareGroupName HardwareGroupName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcgv::HardwareGroupName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListHardwareRequest
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

    public partial class GetHardwareRequest
    {
        /// <summary>
        /// <see cref="gcgv::HardwareName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcgv::HardwareName HardwareName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcgv::HardwareName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateHardwareRequest
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

    public partial class DeleteHardwareRequest
    {
        /// <summary>
        /// <see cref="gcgv::HardwareName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcgv::HardwareName HardwareName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcgv::HardwareName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListCommentsRequest
    {
        /// <summary><see cref="OrderName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public OrderName ParentAsOrderName
        {
            get => string.IsNullOrEmpty(Parent) ? null : OrderName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetCommentRequest
    {
        /// <summary>
        /// <see cref="gcgv::CommentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcgv::CommentName CommentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcgv::CommentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateCommentRequest
    {
        /// <summary><see cref="OrderName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public OrderName ParentAsOrderName
        {
            get => string.IsNullOrEmpty(Parent) ? null : OrderName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class RecordActionOnCommentRequest
    {
        /// <summary>
        /// <see cref="gcgv::CommentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcgv::CommentName CommentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcgv::CommentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListChangeLogEntriesRequest
    {
        /// <summary><see cref="OrderName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public OrderName ParentAsOrderName
        {
            get => string.IsNullOrEmpty(Parent) ? null : OrderName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetChangeLogEntryRequest
    {
        /// <summary>
        /// <see cref="gcgv::ChangeLogEntryName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcgv::ChangeLogEntryName ChangeLogEntryName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcgv::ChangeLogEntryName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListSkusRequest
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

    public partial class GetSkuRequest
    {
        /// <summary>
        /// <see cref="gcgv::SkuName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcgv::SkuName SkuName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcgv::SkuName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListZonesRequest
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

    public partial class GetZoneRequest
    {
        /// <summary>
        /// <see cref="gcgv::ZoneName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcgv::ZoneName ZoneName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcgv::ZoneName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateZoneRequest
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

    public partial class DeleteZoneRequest
    {
        /// <summary>
        /// <see cref="gcgv::ZoneName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcgv::ZoneName ZoneName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcgv::ZoneName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class SignalZoneStateRequest
    {
        /// <summary>
        /// <see cref="gcgv::ZoneName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcgv::ZoneName ZoneName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcgv::ZoneName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class RequestOrderDateChangeRequest
    {
        /// <summary>
        /// <see cref="gcgv::OrderName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcgv::OrderName OrderName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcgv::OrderName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
