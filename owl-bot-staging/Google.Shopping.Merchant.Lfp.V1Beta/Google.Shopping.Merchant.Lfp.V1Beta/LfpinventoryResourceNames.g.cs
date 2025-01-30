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
using gsmlv = Google.Shopping.Merchant.Lfp.V1Beta;
using sys = System;

namespace Google.Shopping.Merchant.Lfp.V1Beta
{
    /// <summary>Resource name for the <c>LfpInventory</c> resource.</summary>
    public sealed partial class LfpInventoryName : gax::IResourceName, sys::IEquatable<LfpInventoryName>
    {
        /// <summary>The possible contents of <see cref="LfpInventoryName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>accounts/{account}/lfpInventories/{target_merchant}~{store_code}~{offer}</c>
            /// .
            /// </summary>
            AccountTargetMerchantStoreCodeOffer = 1,
        }

        private static gax::PathTemplate s_accountTargetMerchantStoreCodeOffer = new gax::PathTemplate("accounts/{account}/lfpInventories/{target_merchant_store_code_offer}");

        /// <summary>Creates a <see cref="LfpInventoryName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="LfpInventoryName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static LfpInventoryName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new LfpInventoryName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="LfpInventoryName"/> with the pattern
        /// <c>accounts/{account}/lfpInventories/{target_merchant}~{store_code}~{offer}</c>.
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="targetMerchantId">The <c>TargetMerchant</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="storeCodeId">The <c>StoreCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="offerId">The <c>Offer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="LfpInventoryName"/> constructed from the provided ids.</returns>
        public static LfpInventoryName FromAccountTargetMerchantStoreCodeOffer(string accountId, string targetMerchantId, string storeCodeId, string offerId) =>
            new LfpInventoryName(ResourceNameType.AccountTargetMerchantStoreCodeOffer, accountId: gax::GaxPreconditions.CheckNotNullOrEmpty(accountId, nameof(accountId)), targetMerchantId: gax::GaxPreconditions.CheckNotNullOrEmpty(targetMerchantId, nameof(targetMerchantId)), storeCodeId: gax::GaxPreconditions.CheckNotNullOrEmpty(storeCodeId, nameof(storeCodeId)), offerId: gax::GaxPreconditions.CheckNotNullOrEmpty(offerId, nameof(offerId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="LfpInventoryName"/> with pattern
        /// <c>accounts/{account}/lfpInventories/{target_merchant}~{store_code}~{offer}</c>.
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="targetMerchantId">The <c>TargetMerchant</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="storeCodeId">The <c>StoreCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="offerId">The <c>Offer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="LfpInventoryName"/> with pattern
        /// <c>accounts/{account}/lfpInventories/{target_merchant}~{store_code}~{offer}</c>.
        /// </returns>
        public static string Format(string accountId, string targetMerchantId, string storeCodeId, string offerId) =>
            FormatAccountTargetMerchantStoreCodeOffer(accountId, targetMerchantId, storeCodeId, offerId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="LfpInventoryName"/> with pattern
        /// <c>accounts/{account}/lfpInventories/{target_merchant}~{store_code}~{offer}</c>.
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="targetMerchantId">The <c>TargetMerchant</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="storeCodeId">The <c>StoreCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="offerId">The <c>Offer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="LfpInventoryName"/> with pattern
        /// <c>accounts/{account}/lfpInventories/{target_merchant}~{store_code}~{offer}</c>.
        /// </returns>
        public static string FormatAccountTargetMerchantStoreCodeOffer(string accountId, string targetMerchantId, string storeCodeId, string offerId) =>
            s_accountTargetMerchantStoreCodeOffer.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(accountId, nameof(accountId)), $"{(gax::GaxPreconditions.CheckNotNullOrEmpty(targetMerchantId, nameof(targetMerchantId)))}~{(gax::GaxPreconditions.CheckNotNullOrEmpty(storeCodeId, nameof(storeCodeId)))}~{(gax::GaxPreconditions.CheckNotNullOrEmpty(offerId, nameof(offerId)))}");

        /// <summary>Parses the given resource name string into a new <see cref="LfpInventoryName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>accounts/{account}/lfpInventories/{target_merchant}~{store_code}~{offer}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="lfpInventoryName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="LfpInventoryName"/> if successful.</returns>
        public static LfpInventoryName Parse(string lfpInventoryName) => Parse(lfpInventoryName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="LfpInventoryName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>accounts/{account}/lfpInventories/{target_merchant}~{store_code}~{offer}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="lfpInventoryName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="LfpInventoryName"/> if successful.</returns>
        public static LfpInventoryName Parse(string lfpInventoryName, bool allowUnparsed) =>
            TryParse(lfpInventoryName, allowUnparsed, out LfpInventoryName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="LfpInventoryName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>accounts/{account}/lfpInventories/{target_merchant}~{store_code}~{offer}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="lfpInventoryName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="LfpInventoryName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string lfpInventoryName, out LfpInventoryName result) =>
            TryParse(lfpInventoryName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="LfpInventoryName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>accounts/{account}/lfpInventories/{target_merchant}~{store_code}~{offer}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="lfpInventoryName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="LfpInventoryName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string lfpInventoryName, bool allowUnparsed, out LfpInventoryName result)
        {
            gax::GaxPreconditions.CheckNotNull(lfpInventoryName, nameof(lfpInventoryName));
            gax::TemplatedResourceName resourceName;
            if (s_accountTargetMerchantStoreCodeOffer.TryParseName(lfpInventoryName, out resourceName))
            {
                string[] split1 = ParseSplitHelper(resourceName[1], new char[] { '~', '~', });
                if (split1 == null)
                {
                    result = null;
                    return false;
                }
                result = FromAccountTargetMerchantStoreCodeOffer(resourceName[0], split1[0], split1[1], split1[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(lfpInventoryName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private static string[] ParseSplitHelper(string s, char[] separators)
        {
            string[] result = new string[separators.Length + 1];
            int i0 = 0;
            for (int i = 0; i <= separators.Length; i++)
            {
                int i1 = i < separators.Length ? s.IndexOf(separators[i], i0) : s.Length;
                if (i1 < 0 || i1 == i0)
                {
                    return null;
                }
                result[i] = s.Substring(i0, i1 - i0);
                i0 = i1 + 1;
            }
            return result;
        }

        private LfpInventoryName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string accountId = null, string offerId = null, string storeCodeId = null, string targetMerchantId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AccountId = accountId;
            OfferId = offerId;
            StoreCodeId = storeCodeId;
            TargetMerchantId = targetMerchantId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="LfpInventoryName"/> class from the component parts of pattern
        /// <c>accounts/{account}/lfpInventories/{target_merchant}~{store_code}~{offer}</c>
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="targetMerchantId">The <c>TargetMerchant</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="storeCodeId">The <c>StoreCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="offerId">The <c>Offer</c> ID. Must not be <c>null</c> or empty.</param>
        public LfpInventoryName(string accountId, string targetMerchantId, string storeCodeId, string offerId) : this(ResourceNameType.AccountTargetMerchantStoreCodeOffer, accountId: gax::GaxPreconditions.CheckNotNullOrEmpty(accountId, nameof(accountId)), targetMerchantId: gax::GaxPreconditions.CheckNotNullOrEmpty(targetMerchantId, nameof(targetMerchantId)), storeCodeId: gax::GaxPreconditions.CheckNotNullOrEmpty(storeCodeId, nameof(storeCodeId)), offerId: gax::GaxPreconditions.CheckNotNullOrEmpty(offerId, nameof(offerId)))
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
        /// The <c>Offer</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string OfferId { get; }

        /// <summary>
        /// The <c>StoreCode</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string StoreCodeId { get; }

        /// <summary>
        /// The <c>TargetMerchant</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string TargetMerchantId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.AccountTargetMerchantStoreCodeOffer: return s_accountTargetMerchantStoreCodeOffer.Expand(AccountId, $"{TargetMerchantId}~{StoreCodeId}~{OfferId}");
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as LfpInventoryName);

        /// <inheritdoc/>
        public bool Equals(LfpInventoryName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(LfpInventoryName a, LfpInventoryName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(LfpInventoryName a, LfpInventoryName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Account</c> resource.</summary>
    public sealed partial class AccountName : gax::IResourceName, sys::IEquatable<AccountName>
    {
        /// <summary>The possible contents of <see cref="AccountName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>accounts/{account}</c>.</summary>
            Account = 1,
        }

        private static gax::PathTemplate s_account = new gax::PathTemplate("accounts/{account}");

        /// <summary>Creates a <see cref="AccountName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="AccountName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static AccountName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new AccountName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>Creates a <see cref="AccountName"/> with the pattern <c>accounts/{account}</c>.</summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="AccountName"/> constructed from the provided ids.</returns>
        public static AccountName FromAccount(string accountId) =>
            new AccountName(ResourceNameType.Account, accountId: gax::GaxPreconditions.CheckNotNullOrEmpty(accountId, nameof(accountId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AccountName"/> with pattern
        /// <c>accounts/{account}</c>.
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AccountName"/> with pattern <c>accounts/{account}</c>.
        /// </returns>
        public static string Format(string accountId) => FormatAccount(accountId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AccountName"/> with pattern
        /// <c>accounts/{account}</c>.
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AccountName"/> with pattern <c>accounts/{account}</c>.
        /// </returns>
        public static string FormatAccount(string accountId) =>
            s_account.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(accountId, nameof(accountId)));

        /// <summary>Parses the given resource name string into a new <see cref="AccountName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>accounts/{account}</c></description></item></list>
        /// </remarks>
        /// <param name="accountName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AccountName"/> if successful.</returns>
        public static AccountName Parse(string accountName) => Parse(accountName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AccountName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>accounts/{account}</c></description></item></list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="accountName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="AccountName"/> if successful.</returns>
        public static AccountName Parse(string accountName, bool allowUnparsed) =>
            TryParse(accountName, allowUnparsed, out AccountName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AccountName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>accounts/{account}</c></description></item></list>
        /// </remarks>
        /// <param name="accountName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AccountName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string accountName, out AccountName result) => TryParse(accountName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AccountName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>accounts/{account}</c></description></item></list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="accountName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AccountName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string accountName, bool allowUnparsed, out AccountName result)
        {
            gax::GaxPreconditions.CheckNotNull(accountName, nameof(accountName));
            gax::TemplatedResourceName resourceName;
            if (s_account.TryParseName(accountName, out resourceName))
            {
                result = FromAccount(resourceName[0]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(accountName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private AccountName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string accountId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AccountId = accountId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="AccountName"/> class from the component parts of pattern
        /// <c>accounts/{account}</c>
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        public AccountName(string accountId) : this(ResourceNameType.Account, accountId: gax::GaxPreconditions.CheckNotNullOrEmpty(accountId, nameof(accountId)))
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

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.Account: return s_account.Expand(AccountId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as AccountName);

        /// <inheritdoc/>
        public bool Equals(AccountName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(AccountName a, AccountName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(AccountName a, AccountName b) => !(a == b);
    }

    public partial class LfpInventory
    {
        /// <summary>
        /// <see cref="gsmlv::LfpInventoryName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gsmlv::LfpInventoryName LfpInventoryName
        {
            get => string.IsNullOrEmpty(Name) ? null : gsmlv::LfpInventoryName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class InsertLfpInventoryRequest
    {
        /// <summary>
        /// <see cref="AccountName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public AccountName ParentAsAccountName
        {
            get => string.IsNullOrEmpty(Parent) ? null : AccountName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }
}
