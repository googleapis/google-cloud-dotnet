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
using gax = Google.Api.Gax;
using gccv = Google.Cloud.Channel.V1;
using sys = System;

namespace Google.Cloud.Channel.V1
{
    /// <summary>Resource name for the <c>CustomerRepricingConfig</c> resource.</summary>
    public sealed partial class CustomerRepricingConfigName : gax::IResourceName, sys::IEquatable<CustomerRepricingConfigName>
    {
        /// <summary>The possible contents of <see cref="CustomerRepricingConfigName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>accounts/{account}/customers/{customer}/customerRepricingConfigs/{customer_repricing_config}</c>.
            /// </summary>
            AccountCustomerCustomerRepricingConfig = 1,
        }

        private static gax::PathTemplate s_accountCustomerCustomerRepricingConfig = new gax::PathTemplate("accounts/{account}/customers/{customer}/customerRepricingConfigs/{customer_repricing_config}");

        /// <summary>Creates a <see cref="CustomerRepricingConfigName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="CustomerRepricingConfigName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static CustomerRepricingConfigName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new CustomerRepricingConfigName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="CustomerRepricingConfigName"/> with the pattern
        /// <c>accounts/{account}/customers/{customer}/customerRepricingConfigs/{customer_repricing_config}</c>.
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="customerRepricingConfigId">
        /// The <c>CustomerRepricingConfig</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="CustomerRepricingConfigName"/> constructed from the provided ids.
        /// </returns>
        public static CustomerRepricingConfigName FromAccountCustomerCustomerRepricingConfig(string accountId, string customerId, string customerRepricingConfigId) =>
            new CustomerRepricingConfigName(ResourceNameType.AccountCustomerCustomerRepricingConfig, accountId: gax::GaxPreconditions.CheckNotNullOrEmpty(accountId, nameof(accountId)), customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), customerRepricingConfigId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerRepricingConfigId, nameof(customerRepricingConfigId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CustomerRepricingConfigName"/> with
        /// pattern <c>accounts/{account}/customers/{customer}/customerRepricingConfigs/{customer_repricing_config}</c>.
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="customerRepricingConfigId">
        /// The <c>CustomerRepricingConfig</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="CustomerRepricingConfigName"/> with pattern
        /// <c>accounts/{account}/customers/{customer}/customerRepricingConfigs/{customer_repricing_config}</c>.
        /// </returns>
        public static string Format(string accountId, string customerId, string customerRepricingConfigId) =>
            FormatAccountCustomerCustomerRepricingConfig(accountId, customerId, customerRepricingConfigId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CustomerRepricingConfigName"/> with
        /// pattern <c>accounts/{account}/customers/{customer}/customerRepricingConfigs/{customer_repricing_config}</c>.
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="customerRepricingConfigId">
        /// The <c>CustomerRepricingConfig</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="CustomerRepricingConfigName"/> with pattern
        /// <c>accounts/{account}/customers/{customer}/customerRepricingConfigs/{customer_repricing_config}</c>.
        /// </returns>
        public static string FormatAccountCustomerCustomerRepricingConfig(string accountId, string customerId, string customerRepricingConfigId) =>
            s_accountCustomerCustomerRepricingConfig.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(accountId, nameof(accountId)), gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), gax::GaxPreconditions.CheckNotNullOrEmpty(customerRepricingConfigId, nameof(customerRepricingConfigId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CustomerRepricingConfigName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>accounts/{account}/customers/{customer}/customerRepricingConfigs/{customer_repricing_config}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="customerRepricingConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="CustomerRepricingConfigName"/> if successful.</returns>
        public static CustomerRepricingConfigName Parse(string customerRepricingConfigName) =>
            Parse(customerRepricingConfigName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CustomerRepricingConfigName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>accounts/{account}/customers/{customer}/customerRepricingConfigs/{customer_repricing_config}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="customerRepricingConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="CustomerRepricingConfigName"/> if successful.</returns>
        public static CustomerRepricingConfigName Parse(string customerRepricingConfigName, bool allowUnparsed) =>
            TryParse(customerRepricingConfigName, allowUnparsed, out CustomerRepricingConfigName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CustomerRepricingConfigName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>accounts/{account}/customers/{customer}/customerRepricingConfigs/{customer_repricing_config}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="customerRepricingConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CustomerRepricingConfigName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string customerRepricingConfigName, out CustomerRepricingConfigName result) =>
            TryParse(customerRepricingConfigName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CustomerRepricingConfigName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>accounts/{account}/customers/{customer}/customerRepricingConfigs/{customer_repricing_config}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="customerRepricingConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CustomerRepricingConfigName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string customerRepricingConfigName, bool allowUnparsed, out CustomerRepricingConfigName result)
        {
            gax::GaxPreconditions.CheckNotNull(customerRepricingConfigName, nameof(customerRepricingConfigName));
            gax::TemplatedResourceName resourceName;
            if (s_accountCustomerCustomerRepricingConfig.TryParseName(customerRepricingConfigName, out resourceName))
            {
                result = FromAccountCustomerCustomerRepricingConfig(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(customerRepricingConfigName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private CustomerRepricingConfigName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string accountId = null, string customerId = null, string customerRepricingConfigId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AccountId = accountId;
            CustomerId = customerId;
            CustomerRepricingConfigId = customerRepricingConfigId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="CustomerRepricingConfigName"/> class from the component parts of
        /// pattern <c>accounts/{account}/customers/{customer}/customerRepricingConfigs/{customer_repricing_config}</c>
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="customerRepricingConfigId">
        /// The <c>CustomerRepricingConfig</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public CustomerRepricingConfigName(string accountId, string customerId, string customerRepricingConfigId) : this(ResourceNameType.AccountCustomerCustomerRepricingConfig, accountId: gax::GaxPreconditions.CheckNotNullOrEmpty(accountId, nameof(accountId)), customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), customerRepricingConfigId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerRepricingConfigId, nameof(customerRepricingConfigId)))
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
        /// The <c>Customer</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string CustomerId { get; }

        /// <summary>
        /// The <c>CustomerRepricingConfig</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string CustomerRepricingConfigId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.AccountCustomerCustomerRepricingConfig: return s_accountCustomerCustomerRepricingConfig.Expand(AccountId, CustomerId, CustomerRepricingConfigId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as CustomerRepricingConfigName);

        /// <inheritdoc/>
        public bool Equals(CustomerRepricingConfigName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(CustomerRepricingConfigName a, CustomerRepricingConfigName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(CustomerRepricingConfigName a, CustomerRepricingConfigName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>ChannelPartnerRepricingConfig</c> resource.</summary>
    public sealed partial class ChannelPartnerRepricingConfigName : gax::IResourceName, sys::IEquatable<ChannelPartnerRepricingConfigName>
    {
        /// <summary>The possible contents of <see cref="ChannelPartnerRepricingConfigName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// accounts/{account}/channelPartnerLinks/{channel_partner}/channelPartnerRepricingConfigs/{channel_partner_repricing_config}</c>
            /// .
            /// </summary>
            AccountChannelPartnerChannelPartnerRepricingConfig = 1,
        }

        private static gax::PathTemplate s_accountChannelPartnerChannelPartnerRepricingConfig = new gax::PathTemplate("accounts/{account}/channelPartnerLinks/{channel_partner}/channelPartnerRepricingConfigs/{channel_partner_repricing_config}");

        /// <summary>
        /// Creates a <see cref="ChannelPartnerRepricingConfigName"/> containing an unparsed resource name.
        /// </summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ChannelPartnerRepricingConfigName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ChannelPartnerRepricingConfigName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ChannelPartnerRepricingConfigName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ChannelPartnerRepricingConfigName"/> with the pattern
        /// <c>
        /// accounts/{account}/channelPartnerLinks/{channel_partner}/channelPartnerRepricingConfigs/{channel_partner_repricing_config}</c>
        /// .
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="channelPartnerId">The <c>ChannelPartner</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="channelPartnerRepricingConfigId">
        /// The <c>ChannelPartnerRepricingConfig</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="ChannelPartnerRepricingConfigName"/> constructed from the provided ids.
        /// </returns>
        public static ChannelPartnerRepricingConfigName FromAccountChannelPartnerChannelPartnerRepricingConfig(string accountId, string channelPartnerId, string channelPartnerRepricingConfigId) =>
            new ChannelPartnerRepricingConfigName(ResourceNameType.AccountChannelPartnerChannelPartnerRepricingConfig, accountId: gax::GaxPreconditions.CheckNotNullOrEmpty(accountId, nameof(accountId)), channelPartnerId: gax::GaxPreconditions.CheckNotNullOrEmpty(channelPartnerId, nameof(channelPartnerId)), channelPartnerRepricingConfigId: gax::GaxPreconditions.CheckNotNullOrEmpty(channelPartnerRepricingConfigId, nameof(channelPartnerRepricingConfigId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ChannelPartnerRepricingConfigName"/> with
        /// pattern
        /// <c>
        /// accounts/{account}/channelPartnerLinks/{channel_partner}/channelPartnerRepricingConfigs/{channel_partner_repricing_config}</c>
        /// .
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="channelPartnerId">The <c>ChannelPartner</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="channelPartnerRepricingConfigId">
        /// The <c>ChannelPartnerRepricingConfig</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="ChannelPartnerRepricingConfigName"/> with pattern
        /// <c>
        /// accounts/{account}/channelPartnerLinks/{channel_partner}/channelPartnerRepricingConfigs/{channel_partner_repricing_config}</c>
        /// .
        /// </returns>
        public static string Format(string accountId, string channelPartnerId, string channelPartnerRepricingConfigId) =>
            FormatAccountChannelPartnerChannelPartnerRepricingConfig(accountId, channelPartnerId, channelPartnerRepricingConfigId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ChannelPartnerRepricingConfigName"/> with
        /// pattern
        /// <c>
        /// accounts/{account}/channelPartnerLinks/{channel_partner}/channelPartnerRepricingConfigs/{channel_partner_repricing_config}</c>
        /// .
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="channelPartnerId">The <c>ChannelPartner</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="channelPartnerRepricingConfigId">
        /// The <c>ChannelPartnerRepricingConfig</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="ChannelPartnerRepricingConfigName"/> with pattern
        /// <c>
        /// accounts/{account}/channelPartnerLinks/{channel_partner}/channelPartnerRepricingConfigs/{channel_partner_repricing_config}</c>
        /// .
        /// </returns>
        public static string FormatAccountChannelPartnerChannelPartnerRepricingConfig(string accountId, string channelPartnerId, string channelPartnerRepricingConfigId) =>
            s_accountChannelPartnerChannelPartnerRepricingConfig.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(accountId, nameof(accountId)), gax::GaxPreconditions.CheckNotNullOrEmpty(channelPartnerId, nameof(channelPartnerId)), gax::GaxPreconditions.CheckNotNullOrEmpty(channelPartnerRepricingConfigId, nameof(channelPartnerRepricingConfigId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ChannelPartnerRepricingConfigName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// accounts/{account}/channelPartnerLinks/{channel_partner}/channelPartnerRepricingConfigs/{channel_partner_repricing_config}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="channelPartnerRepricingConfigName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <returns>The parsed <see cref="ChannelPartnerRepricingConfigName"/> if successful.</returns>
        public static ChannelPartnerRepricingConfigName Parse(string channelPartnerRepricingConfigName) =>
            Parse(channelPartnerRepricingConfigName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ChannelPartnerRepricingConfigName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// accounts/{account}/channelPartnerLinks/{channel_partner}/channelPartnerRepricingConfigs/{channel_partner_repricing_config}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="channelPartnerRepricingConfigName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ChannelPartnerRepricingConfigName"/> if successful.</returns>
        public static ChannelPartnerRepricingConfigName Parse(string channelPartnerRepricingConfigName, bool allowUnparsed) =>
            TryParse(channelPartnerRepricingConfigName, allowUnparsed, out ChannelPartnerRepricingConfigName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ChannelPartnerRepricingConfigName"/>
        /// instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// accounts/{account}/channelPartnerLinks/{channel_partner}/channelPartnerRepricingConfigs/{channel_partner_repricing_config}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="channelPartnerRepricingConfigName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ChannelPartnerRepricingConfigName"/>, or <c>null</c> if
        /// parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string channelPartnerRepricingConfigName, out ChannelPartnerRepricingConfigName result) =>
            TryParse(channelPartnerRepricingConfigName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ChannelPartnerRepricingConfigName"/>
        /// instance; optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// accounts/{account}/channelPartnerLinks/{channel_partner}/channelPartnerRepricingConfigs/{channel_partner_repricing_config}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="channelPartnerRepricingConfigName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ChannelPartnerRepricingConfigName"/>, or <c>null</c> if
        /// parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string channelPartnerRepricingConfigName, bool allowUnparsed, out ChannelPartnerRepricingConfigName result)
        {
            gax::GaxPreconditions.CheckNotNull(channelPartnerRepricingConfigName, nameof(channelPartnerRepricingConfigName));
            gax::TemplatedResourceName resourceName;
            if (s_accountChannelPartnerChannelPartnerRepricingConfig.TryParseName(channelPartnerRepricingConfigName, out resourceName))
            {
                result = FromAccountChannelPartnerChannelPartnerRepricingConfig(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(channelPartnerRepricingConfigName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ChannelPartnerRepricingConfigName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string accountId = null, string channelPartnerId = null, string channelPartnerRepricingConfigId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AccountId = accountId;
            ChannelPartnerId = channelPartnerId;
            ChannelPartnerRepricingConfigId = channelPartnerRepricingConfigId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ChannelPartnerRepricingConfigName"/> class from the component
        /// parts of pattern
        /// <c>
        /// accounts/{account}/channelPartnerLinks/{channel_partner}/channelPartnerRepricingConfigs/{channel_partner_repricing_config}</c>
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="channelPartnerId">The <c>ChannelPartner</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="channelPartnerRepricingConfigId">
        /// The <c>ChannelPartnerRepricingConfig</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public ChannelPartnerRepricingConfigName(string accountId, string channelPartnerId, string channelPartnerRepricingConfigId) : this(ResourceNameType.AccountChannelPartnerChannelPartnerRepricingConfig, accountId: gax::GaxPreconditions.CheckNotNullOrEmpty(accountId, nameof(accountId)), channelPartnerId: gax::GaxPreconditions.CheckNotNullOrEmpty(channelPartnerId, nameof(channelPartnerId)), channelPartnerRepricingConfigId: gax::GaxPreconditions.CheckNotNullOrEmpty(channelPartnerRepricingConfigId, nameof(channelPartnerRepricingConfigId)))
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
        /// The <c>ChannelPartner</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string ChannelPartnerId { get; }

        /// <summary>
        /// The <c>ChannelPartnerRepricingConfig</c> ID. Will not be <c>null</c>, unless this instance contains an
        /// unparsed resource name.
        /// </summary>
        public string ChannelPartnerRepricingConfigId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.AccountChannelPartnerChannelPartnerRepricingConfig: return s_accountChannelPartnerChannelPartnerRepricingConfig.Expand(AccountId, ChannelPartnerId, ChannelPartnerRepricingConfigId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ChannelPartnerRepricingConfigName);

        /// <inheritdoc/>
        public bool Equals(ChannelPartnerRepricingConfigName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ChannelPartnerRepricingConfigName a, ChannelPartnerRepricingConfigName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ChannelPartnerRepricingConfigName a, ChannelPartnerRepricingConfigName b) => !(a == b);
    }

    public partial class CustomerRepricingConfig
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

    public partial class ChannelPartnerRepricingConfig
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

    public partial class RepricingConfig
    {
        public partial class Types
        {
            public partial class EntitlementGranularity
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
        }
    }
}
