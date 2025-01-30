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
using gccv = Google.Cloud.Channel.V1;
using sys = System;

namespace Google.Cloud.Channel.V1
{
    /// <summary>Resource name for the <c>SkuGroup</c> resource.</summary>
    public sealed partial class SkuGroupName : gax::IResourceName, sys::IEquatable<SkuGroupName>
    {
        /// <summary>The possible contents of <see cref="SkuGroupName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>accounts/{account}/skuGroups/{sku_group}</c>.</summary>
            AccountSkuGroup = 1,
        }

        private static gax::PathTemplate s_accountSkuGroup = new gax::PathTemplate("accounts/{account}/skuGroups/{sku_group}");

        /// <summary>Creates a <see cref="SkuGroupName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="SkuGroupName"/> containing the provided <paramref name="unparsedResourceName"/>
        /// .
        /// </returns>
        public static SkuGroupName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new SkuGroupName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="SkuGroupName"/> with the pattern <c>accounts/{account}/skuGroups/{sku_group}</c>.
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="skuGroupId">The <c>SkuGroup</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="SkuGroupName"/> constructed from the provided ids.</returns>
        public static SkuGroupName FromAccountSkuGroup(string accountId, string skuGroupId) =>
            new SkuGroupName(ResourceNameType.AccountSkuGroup, accountId: gax::GaxPreconditions.CheckNotNullOrEmpty(accountId, nameof(accountId)), skuGroupId: gax::GaxPreconditions.CheckNotNullOrEmpty(skuGroupId, nameof(skuGroupId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SkuGroupName"/> with pattern
        /// <c>accounts/{account}/skuGroups/{sku_group}</c>.
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="skuGroupId">The <c>SkuGroup</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SkuGroupName"/> with pattern
        /// <c>accounts/{account}/skuGroups/{sku_group}</c>.
        /// </returns>
        public static string Format(string accountId, string skuGroupId) => FormatAccountSkuGroup(accountId, skuGroupId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SkuGroupName"/> with pattern
        /// <c>accounts/{account}/skuGroups/{sku_group}</c>.
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="skuGroupId">The <c>SkuGroup</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SkuGroupName"/> with pattern
        /// <c>accounts/{account}/skuGroups/{sku_group}</c>.
        /// </returns>
        public static string FormatAccountSkuGroup(string accountId, string skuGroupId) =>
            s_accountSkuGroup.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(accountId, nameof(accountId)), gax::GaxPreconditions.CheckNotNullOrEmpty(skuGroupId, nameof(skuGroupId)));

        /// <summary>Parses the given resource name string into a new <see cref="SkuGroupName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>accounts/{account}/skuGroups/{sku_group}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="skuGroupName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="SkuGroupName"/> if successful.</returns>
        public static SkuGroupName Parse(string skuGroupName) => Parse(skuGroupName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="SkuGroupName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>accounts/{account}/skuGroups/{sku_group}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="skuGroupName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="SkuGroupName"/> if successful.</returns>
        public static SkuGroupName Parse(string skuGroupName, bool allowUnparsed) =>
            TryParse(skuGroupName, allowUnparsed, out SkuGroupName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SkuGroupName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>accounts/{account}/skuGroups/{sku_group}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="skuGroupName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SkuGroupName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string skuGroupName, out SkuGroupName result) => TryParse(skuGroupName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SkuGroupName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>accounts/{account}/skuGroups/{sku_group}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="skuGroupName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SkuGroupName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string skuGroupName, bool allowUnparsed, out SkuGroupName result)
        {
            gax::GaxPreconditions.CheckNotNull(skuGroupName, nameof(skuGroupName));
            gax::TemplatedResourceName resourceName;
            if (s_accountSkuGroup.TryParseName(skuGroupName, out resourceName))
            {
                result = FromAccountSkuGroup(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(skuGroupName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private SkuGroupName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string accountId = null, string skuGroupId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AccountId = accountId;
            SkuGroupId = skuGroupId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="SkuGroupName"/> class from the component parts of pattern
        /// <c>accounts/{account}/skuGroups/{sku_group}</c>
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="skuGroupId">The <c>SkuGroup</c> ID. Must not be <c>null</c> or empty.</param>
        public SkuGroupName(string accountId, string skuGroupId) : this(ResourceNameType.AccountSkuGroup, accountId: gax::GaxPreconditions.CheckNotNullOrEmpty(accountId, nameof(accountId)), skuGroupId: gax::GaxPreconditions.CheckNotNullOrEmpty(skuGroupId, nameof(skuGroupId)))
        {
        }

        /// <summary>The <see cref="ResourceNameType"/> of the contained resource name.</summary>
        public ResourceNameType Type { get; }

        /// <summary>
        /// The contained <see cref="gax::UnparsedResourceName"/>. Only non-<c>null</c> if this instance contains an
        /// unparsed resource name.
        /// </summary>
        public gax::UnparsedResourceName UnparsedResource { get; }

        /// <summary>
        /// The <c>Account</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string AccountId { get; }

        /// <summary>
        /// The <c>SkuGroup</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string SkuGroupId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.AccountSkuGroup: return s_accountSkuGroup.Expand(AccountId, SkuGroupId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as SkuGroupName);

        /// <inheritdoc/>
        public bool Equals(SkuGroupName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(SkuGroupName a, SkuGroupName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(SkuGroupName a, SkuGroupName b) => !(a == b);
    }

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

    public partial class ListSkuGroupBillableSkusRequest
    {
        /// <summary>
        /// <see cref="SkuGroupName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public SkuGroupName ParentAsSkuGroupName
        {
            get => string.IsNullOrEmpty(Parent) ? null : SkuGroupName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class SkuGroup
    {
        /// <summary>
        /// <see cref="gccv::SkuGroupName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::SkuGroupName SkuGroupName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::SkuGroupName.Parse(Name, allowUnparsed: true);
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

    public partial class QueryEligibleBillingAccountsRequest
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

    public partial class ListEntitlementChangesRequest
    {
        /// <summary>
        /// <see cref="EntitlementName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public EntitlementName ParentAsEntitlementName
        {
            get => string.IsNullOrEmpty(Parent) ? null : EntitlementName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }
}
