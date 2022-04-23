// Copyright 2022 Google LLC
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

using gccv = Google.Cloud.Channel.V1;

namespace Google.Cloud.Channel.V1
{
    public partial class GetCustomerRequest
    {
        /// <summary>
        /// <see cref="gccv::CustomerName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::CustomerName CustomerName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::CustomerName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteCustomerRequest
    {
        /// <summary>
        /// <see cref="gccv::CustomerName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::CustomerName CustomerName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::CustomerName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ImportCustomerRequest
    {
        /// <summary>
        /// <see cref="CustomerName"/>-typed view over the <see cref="Customer"/> resource name property.
        /// </summary>
        public CustomerName CustomerAsCustomerName
        {
            get => string.IsNullOrEmpty(Customer) ? null : CustomerName.Parse(Customer, allowUnparsed: true);
            set => Customer = value?.ToString() ?? "";
        }
    }

    public partial class ProvisionCloudIdentityRequest
    {
        /// <summary>
        /// <see cref="CustomerName"/>-typed view over the <see cref="Customer"/> resource name property.
        /// </summary>
        public CustomerName CustomerAsCustomerName
        {
            get => string.IsNullOrEmpty(Customer) ? null : CustomerName.Parse(Customer, allowUnparsed: true);
            set => Customer = value?.ToString() ?? "";
        }
    }

    public partial class ListEntitlementsRequest
    {
        /// <summary>
        /// <see cref="CustomerName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public CustomerName ParentAsCustomerName
        {
            get => string.IsNullOrEmpty(Parent) ? null : CustomerName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetEntitlementRequest
    {
        /// <summary>
        /// <see cref="gccv::EntitlementName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::EntitlementName EntitlementName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::EntitlementName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetCustomerRepricingConfigRequest
    {
        /// <summary>
        /// <see cref="gccv::CustomerRepricingConfigName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gccv::CustomerRepricingConfigName CustomerRepricingConfigName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::CustomerRepricingConfigName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListCustomerRepricingConfigsRequest
    {
        /// <summary>
        /// <see cref="CustomerName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public CustomerName ParentAsCustomerName
        {
            get => string.IsNullOrEmpty(Parent) ? null : CustomerName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class CreateCustomerRepricingConfigRequest
    {
        /// <summary>
        /// <see cref="CustomerName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public CustomerName ParentAsCustomerName
        {
            get => string.IsNullOrEmpty(Parent) ? null : CustomerName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteCustomerRepricingConfigRequest
    {
        /// <summary>
        /// <see cref="gccv::CustomerRepricingConfigName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gccv::CustomerRepricingConfigName CustomerRepricingConfigName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::CustomerRepricingConfigName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetChannelPartnerRepricingConfigRequest
    {
        /// <summary>
        /// <see cref="gccv::ChannelPartnerRepricingConfigName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gccv::ChannelPartnerRepricingConfigName ChannelPartnerRepricingConfigName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::ChannelPartnerRepricingConfigName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListChannelPartnerRepricingConfigsRequest
    {
        /// <summary>
        /// <see cref="ChannelPartnerLinkName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ChannelPartnerLinkName ParentAsChannelPartnerLinkName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ChannelPartnerLinkName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class CreateChannelPartnerRepricingConfigRequest
    {
        /// <summary>
        /// <see cref="ChannelPartnerLinkName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ChannelPartnerLinkName ParentAsChannelPartnerLinkName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ChannelPartnerLinkName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteChannelPartnerRepricingConfigRequest
    {
        /// <summary>
        /// <see cref="gccv::ChannelPartnerRepricingConfigName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gccv::ChannelPartnerRepricingConfigName ChannelPartnerRepricingConfigName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::ChannelPartnerRepricingConfigName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateEntitlementRequest
    {
        /// <summary>
        /// <see cref="CustomerName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public CustomerName ParentAsCustomerName
        {
            get => string.IsNullOrEmpty(Parent) ? null : CustomerName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class ChangeOfferRequest
    {
        /// <summary><see cref="OfferName"/>-typed view over the <see cref="Offer"/> resource name property.</summary>
        public OfferName OfferAsOfferName
        {
            get => string.IsNullOrEmpty(Offer) ? null : OfferName.Parse(Offer, allowUnparsed: true);
            set => Offer = value?.ToString() ?? "";
        }
    }

    public partial class LookupOfferRequest
    {
        /// <summary>
        /// <see cref="EntitlementName"/>-typed view over the <see cref="Entitlement"/> resource name property.
        /// </summary>
        public EntitlementName EntitlementAsEntitlementName
        {
            get => string.IsNullOrEmpty(Entitlement) ? null : EntitlementName.Parse(Entitlement, allowUnparsed: true);
            set => Entitlement = value?.ToString() ?? "";
        }
    }

    public partial class ListSkusRequest
    {
        /// <summary>
        /// <see cref="ProductName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ProductName ParentAsProductName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ProductName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class ListPurchasableSkusRequest
    {
        /// <summary>
        /// <see cref="CustomerName"/>-typed view over the <see cref="Customer"/> resource name property.
        /// </summary>
        public CustomerName CustomerAsCustomerName
        {
            get => string.IsNullOrEmpty(Customer) ? null : CustomerName.Parse(Customer, allowUnparsed: true);
            set => Customer = value?.ToString() ?? "";
        }
    }

    public partial class ListPurchasableOffersRequest
    {
        /// <summary>
        /// <see cref="CustomerName"/>-typed view over the <see cref="Customer"/> resource name property.
        /// </summary>
        public CustomerName CustomerAsCustomerName
        {
            get => string.IsNullOrEmpty(Customer) ? null : CustomerName.Parse(Customer, allowUnparsed: true);
            set => Customer = value?.ToString() ?? "";
        }
    }
}
