// Copyright 2024 Google LLC
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
using sys = System;

namespace Google.Ads.AdManager.V1
{
    /// <summary>Resource name for the <c>Order</c> resource.</summary>
    public sealed partial class OrderName : gax::IResourceName, sys::IEquatable<OrderName>
    {
        /// <summary>The possible contents of <see cref="OrderName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>networks/{network_code}/orders/{order}</c>.</summary>
            NetworkCodeOrder = 1,
        }

        private static gax::PathTemplate s_networkCodeOrder = new gax::PathTemplate("networks/{network_code}/orders/{order}");

        /// <summary>Creates a <see cref="OrderName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="OrderName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static OrderName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new OrderName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="OrderName"/> with the pattern <c>networks/{network_code}/orders/{order}</c>.
        /// </summary>
        /// <param name="networkCodeId">The <c>NetworkCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="orderId">The <c>Order</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="OrderName"/> constructed from the provided ids.</returns>
        public static OrderName FromNetworkCodeOrder(string networkCodeId, string orderId) =>
            new OrderName(ResourceNameType.NetworkCodeOrder, networkCodeId: gax::GaxPreconditions.CheckNotNullOrEmpty(networkCodeId, nameof(networkCodeId)), orderId: gax::GaxPreconditions.CheckNotNullOrEmpty(orderId, nameof(orderId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="OrderName"/> with pattern
        /// <c>networks/{network_code}/orders/{order}</c>.
        /// </summary>
        /// <param name="networkCodeId">The <c>NetworkCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="orderId">The <c>Order</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="OrderName"/> with pattern
        /// <c>networks/{network_code}/orders/{order}</c>.
        /// </returns>
        public static string Format(string networkCodeId, string orderId) => FormatNetworkCodeOrder(networkCodeId, orderId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="OrderName"/> with pattern
        /// <c>networks/{network_code}/orders/{order}</c>.
        /// </summary>
        /// <param name="networkCodeId">The <c>NetworkCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="orderId">The <c>Order</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="OrderName"/> with pattern
        /// <c>networks/{network_code}/orders/{order}</c>.
        /// </returns>
        public static string FormatNetworkCodeOrder(string networkCodeId, string orderId) =>
            s_networkCodeOrder.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(networkCodeId, nameof(networkCodeId)), gax::GaxPreconditions.CheckNotNullOrEmpty(orderId, nameof(orderId)));

        /// <summary>Parses the given resource name string into a new <see cref="OrderName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>networks/{network_code}/orders/{order}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="orderName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="OrderName"/> if successful.</returns>
        public static OrderName Parse(string orderName) => Parse(orderName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="OrderName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>networks/{network_code}/orders/{order}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="orderName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="OrderName"/> if successful.</returns>
        public static OrderName Parse(string orderName, bool allowUnparsed) =>
            TryParse(orderName, allowUnparsed, out OrderName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="OrderName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>networks/{network_code}/orders/{order}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="orderName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="OrderName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string orderName, out OrderName result) => TryParse(orderName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="OrderName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>networks/{network_code}/orders/{order}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="orderName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="OrderName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string orderName, bool allowUnparsed, out OrderName result)
        {
            gax::GaxPreconditions.CheckNotNull(orderName, nameof(orderName));
            gax::TemplatedResourceName resourceName;
            if (s_networkCodeOrder.TryParseName(orderName, out resourceName))
            {
                result = FromNetworkCodeOrder(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(orderName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private OrderName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string networkCodeId = null, string orderId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            NetworkCodeId = networkCodeId;
            OrderId = orderId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="OrderName"/> class from the component parts of pattern
        /// <c>networks/{network_code}/orders/{order}</c>
        /// </summary>
        /// <param name="networkCodeId">The <c>NetworkCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="orderId">The <c>Order</c> ID. Must not be <c>null</c> or empty.</param>
        public OrderName(string networkCodeId, string orderId) : this(ResourceNameType.NetworkCodeOrder, networkCodeId: gax::GaxPreconditions.CheckNotNullOrEmpty(networkCodeId, nameof(networkCodeId)), orderId: gax::GaxPreconditions.CheckNotNullOrEmpty(orderId, nameof(orderId)))
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
        /// The <c>NetworkCode</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string NetworkCodeId { get; }

        /// <summary>
        /// The <c>Order</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string OrderId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.NetworkCodeOrder: return s_networkCodeOrder.Expand(NetworkCodeId, OrderId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as OrderName);

        /// <inheritdoc/>
        public bool Equals(OrderName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(OrderName a, OrderName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(OrderName a, OrderName b) => !(a == b);
    }

    public partial class Order
    {
        /// <summary>
        /// <see cref="gaav::OrderName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gaav::OrderName OrderName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::OrderName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="ContactName"/>-typed view over the <see cref="AdvertiserContacts"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<ContactName> AdvertiserContactsAsContactNames
        {
            get => new gax::ResourceNameList<ContactName>(AdvertiserContacts, s => string.IsNullOrEmpty(s) ? null : ContactName.Parse(s, allowUnparsed: true));
        }

        /// <summary>
        /// <see cref="CompanyName"/>-typed view over the <see cref="Advertiser"/> resource name property.
        /// </summary>
        public CompanyName AdvertiserAsCompanyName
        {
            get => string.IsNullOrEmpty(Advertiser) ? null : CompanyName.Parse(Advertiser, allowUnparsed: true);
            set => Advertiser = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="ContactName"/>-typed view over the <see cref="AgencyContacts"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<ContactName> AgencyContactsAsContactNames
        {
            get => new gax::ResourceNameList<ContactName>(AgencyContacts, s => string.IsNullOrEmpty(s) ? null : ContactName.Parse(s, allowUnparsed: true));
        }

        /// <summary>
        /// <see cref="CompanyName"/>-typed view over the <see cref="Agency"/> resource name property.
        /// </summary>
        public CompanyName AgencyAsCompanyName
        {
            get => string.IsNullOrEmpty(Agency) ? null : CompanyName.Parse(Agency, allowUnparsed: true);
            set => Agency = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="TeamName"/>-typed view over the <see cref="AppliedTeams"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<TeamName> AppliedTeamsAsTeamNames
        {
            get => new gax::ResourceNameList<TeamName>(AppliedTeams, s => string.IsNullOrEmpty(s) ? null : TeamName.Parse(s, allowUnparsed: true));
        }

        /// <summary><see cref="UserName"/>-typed view over the <see cref="Creator"/> resource name property.</summary>
        public UserName CreatorAsUserName
        {
            get => string.IsNullOrEmpty(Creator) ? null : UserName.Parse(Creator, allowUnparsed: true);
            set => Creator = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="UserName"/>-typed view over the <see cref="Salesperson"/> resource name property.
        /// </summary>
        public UserName SalespersonAsUserName
        {
            get => string.IsNullOrEmpty(Salesperson) ? null : UserName.Parse(Salesperson, allowUnparsed: true);
            set => Salesperson = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="UserName"/>-typed view over the <see cref="SecondarySalespeople"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<UserName> SecondarySalespeopleAsUserNames
        {
            get => new gax::ResourceNameList<UserName>(SecondarySalespeople, s => string.IsNullOrEmpty(s) ? null : UserName.Parse(s, allowUnparsed: true));
        }

        /// <summary>
        /// <see cref="UserName"/>-typed view over the <see cref="Trafficker"/> resource name property.
        /// </summary>
        public UserName TraffickerAsUserName
        {
            get => string.IsNullOrEmpty(Trafficker) ? null : UserName.Parse(Trafficker, allowUnparsed: true);
            set => Trafficker = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="UserName"/>-typed view over the <see cref="SecondaryTraffickers"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<UserName> SecondaryTraffickersAsUserNames
        {
            get => new gax::ResourceNameList<UserName>(SecondaryTraffickers, s => string.IsNullOrEmpty(s) ? null : UserName.Parse(s, allowUnparsed: true));
        }

        /// <summary>
        /// <see cref="TeamName"/>-typed view over the <see cref="EffectiveTeams"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<TeamName> EffectiveTeamsAsTeamNames
        {
            get => new gax::ResourceNameList<TeamName>(EffectiveTeams, s => string.IsNullOrEmpty(s) ? null : TeamName.Parse(s, allowUnparsed: true));
        }
    }
}
