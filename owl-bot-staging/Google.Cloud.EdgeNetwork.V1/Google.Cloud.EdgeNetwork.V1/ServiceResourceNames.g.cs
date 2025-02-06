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
using gcev = Google.Cloud.EdgeNetwork.V1;
using sys = System;

namespace Google.Cloud.EdgeNetwork.V1
{
    public partial class ListZonesRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        [sys::ObsoleteAttribute]
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetZoneRequest
    {
        /// <summary>
        /// <see cref="gcev::ZoneName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        [sys::ObsoleteAttribute]
        public gcev::ZoneName ZoneName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcev::ZoneName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListNetworksRequest
    {
        /// <summary><see cref="ZoneName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public ZoneName ParentAsZoneName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ZoneName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetNetworkRequest
    {
        /// <summary>
        /// <see cref="gcev::NetworkName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcev::NetworkName NetworkName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcev::NetworkName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateNetworkRequest
    {
        /// <summary><see cref="ZoneName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public ZoneName ParentAsZoneName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ZoneName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteNetworkRequest
    {
        /// <summary>
        /// <see cref="gcev::NetworkName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcev::NetworkName NetworkName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcev::NetworkName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListSubnetsRequest
    {
        /// <summary><see cref="ZoneName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public ZoneName ParentAsZoneName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ZoneName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetSubnetRequest
    {
        /// <summary>
        /// <see cref="gcev::SubnetName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcev::SubnetName SubnetName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcev::SubnetName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateSubnetRequest
    {
        /// <summary><see cref="ZoneName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public ZoneName ParentAsZoneName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ZoneName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteSubnetRequest
    {
        /// <summary>
        /// <see cref="gcev::SubnetName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcev::SubnetName SubnetName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcev::SubnetName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListInterconnectsRequest
    {
        /// <summary><see cref="ZoneName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public ZoneName ParentAsZoneName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ZoneName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetInterconnectRequest
    {
        /// <summary>
        /// <see cref="gcev::InterconnectName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcev::InterconnectName InterconnectName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcev::InterconnectName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListInterconnectAttachmentsRequest
    {
        /// <summary><see cref="ZoneName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public ZoneName ParentAsZoneName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ZoneName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetInterconnectAttachmentRequest
    {
        /// <summary>
        /// <see cref="gcev::InterconnectAttachmentName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gcev::InterconnectAttachmentName InterconnectAttachmentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcev::InterconnectAttachmentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateInterconnectAttachmentRequest
    {
        /// <summary><see cref="ZoneName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public ZoneName ParentAsZoneName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ZoneName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteInterconnectAttachmentRequest
    {
        /// <summary>
        /// <see cref="gcev::InterconnectAttachmentName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gcev::InterconnectAttachmentName InterconnectAttachmentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcev::InterconnectAttachmentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListRoutersRequest
    {
        /// <summary><see cref="ZoneName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public ZoneName ParentAsZoneName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ZoneName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetRouterRequest
    {
        /// <summary>
        /// <see cref="gcev::RouterName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcev::RouterName RouterName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcev::RouterName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateRouterRequest
    {
        /// <summary><see cref="ZoneName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public ZoneName ParentAsZoneName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ZoneName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteRouterRequest
    {
        /// <summary>
        /// <see cref="gcev::RouterName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcev::RouterName RouterName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcev::RouterName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DiagnoseNetworkRequest
    {
        /// <summary>
        /// <see cref="gcev::NetworkName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcev::NetworkName NetworkName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcev::NetworkName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DiagnoseInterconnectRequest
    {
        /// <summary>
        /// <see cref="gcev::InterconnectName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcev::InterconnectName InterconnectName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcev::InterconnectName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DiagnoseRouterRequest
    {
        /// <summary>
        /// <see cref="gcev::RouterName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcev::RouterName RouterName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcev::RouterName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class InitializeZoneRequest
    {
        /// <summary>
        /// <see cref="gcev::ZoneName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcev::ZoneName ZoneName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcev::ZoneName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
