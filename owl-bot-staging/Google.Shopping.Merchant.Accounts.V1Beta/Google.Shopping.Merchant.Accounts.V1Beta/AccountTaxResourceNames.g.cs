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
using gsmav = Google.Shopping.Merchant.Accounts.V1Beta;
using sys = System;

namespace Google.Shopping.Merchant.Accounts.V1Beta
{
    /// <summary>Resource name for the <c>AccountTax</c> resource.</summary>
    public sealed partial class AccountTaxName : gax::IResourceName, sys::IEquatable<AccountTaxName>
    {
        /// <summary>The possible contents of <see cref="AccountTaxName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>accounts/{account}/accounttax/{tax}</c>.</summary>
            AccountTax = 1,
        }

        private static gax::PathTemplate s_accountTax = new gax::PathTemplate("accounts/{account}/accounttax/{tax}");

        /// <summary>Creates a <see cref="AccountTaxName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="AccountTaxName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static AccountTaxName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new AccountTaxName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="AccountTaxName"/> with the pattern <c>accounts/{account}/accounttax/{tax}</c>.
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="taxId">The <c>Tax</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="AccountTaxName"/> constructed from the provided ids.</returns>
        public static AccountTaxName FromAccountTax(string accountId, string taxId) =>
            new AccountTaxName(ResourceNameType.AccountTax, accountId: gax::GaxPreconditions.CheckNotNullOrEmpty(accountId, nameof(accountId)), taxId: gax::GaxPreconditions.CheckNotNullOrEmpty(taxId, nameof(taxId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AccountTaxName"/> with pattern
        /// <c>accounts/{account}/accounttax/{tax}</c>.
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="taxId">The <c>Tax</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AccountTaxName"/> with pattern
        /// <c>accounts/{account}/accounttax/{tax}</c>.
        /// </returns>
        public static string Format(string accountId, string taxId) => FormatAccountTax(accountId, taxId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AccountTaxName"/> with pattern
        /// <c>accounts/{account}/accounttax/{tax}</c>.
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="taxId">The <c>Tax</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AccountTaxName"/> with pattern
        /// <c>accounts/{account}/accounttax/{tax}</c>.
        /// </returns>
        public static string FormatAccountTax(string accountId, string taxId) =>
            s_accountTax.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(accountId, nameof(accountId)), gax::GaxPreconditions.CheckNotNullOrEmpty(taxId, nameof(taxId)));

        /// <summary>Parses the given resource name string into a new <see cref="AccountTaxName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>accounts/{account}/accounttax/{tax}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="accountTaxName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AccountTaxName"/> if successful.</returns>
        public static AccountTaxName Parse(string accountTaxName) => Parse(accountTaxName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AccountTaxName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>accounts/{account}/accounttax/{tax}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="accountTaxName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="AccountTaxName"/> if successful.</returns>
        public static AccountTaxName Parse(string accountTaxName, bool allowUnparsed) =>
            TryParse(accountTaxName, allowUnparsed, out AccountTaxName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AccountTaxName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>accounts/{account}/accounttax/{tax}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="accountTaxName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AccountTaxName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string accountTaxName, out AccountTaxName result) =>
            TryParse(accountTaxName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AccountTaxName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>accounts/{account}/accounttax/{tax}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="accountTaxName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AccountTaxName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string accountTaxName, bool allowUnparsed, out AccountTaxName result)
        {
            gax::GaxPreconditions.CheckNotNull(accountTaxName, nameof(accountTaxName));
            gax::TemplatedResourceName resourceName;
            if (s_accountTax.TryParseName(accountTaxName, out resourceName))
            {
                result = FromAccountTax(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(accountTaxName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private AccountTaxName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string accountId = null, string taxId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AccountId = accountId;
            TaxId = taxId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="AccountTaxName"/> class from the component parts of pattern
        /// <c>accounts/{account}/accounttax/{tax}</c>
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="taxId">The <c>Tax</c> ID. Must not be <c>null</c> or empty.</param>
        public AccountTaxName(string accountId, string taxId) : this(ResourceNameType.AccountTax, accountId: gax::GaxPreconditions.CheckNotNullOrEmpty(accountId, nameof(accountId)), taxId: gax::GaxPreconditions.CheckNotNullOrEmpty(taxId, nameof(taxId)))
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
        /// The <c>Tax</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string TaxId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.AccountTax: return s_accountTax.Expand(AccountId, TaxId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as AccountTaxName);

        /// <inheritdoc/>
        public bool Equals(AccountTaxName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(AccountTaxName a, AccountTaxName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(AccountTaxName a, AccountTaxName b) => !(a == b);
    }

    public partial class AccountTax
    {
        /// <summary>
        /// <see cref="gsmav::AccountTaxName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gsmav::AccountTaxName AccountTaxName
        {
            get => string.IsNullOrEmpty(Name) ? null : gsmav::AccountTaxName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetAccountTaxRequest
    {
        /// <summary>
        /// <see cref="gsmav::AccountTaxName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gsmav::AccountTaxName AccountTaxName
        {
            get => string.IsNullOrEmpty(Name) ? null : gsmav::AccountTaxName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListAccountTaxRequest
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
