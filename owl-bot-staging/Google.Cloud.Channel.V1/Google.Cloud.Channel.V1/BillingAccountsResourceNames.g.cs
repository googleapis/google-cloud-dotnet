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
    /// <summary>Resource name for the <c>BillingAccount</c> resource.</summary>
    public sealed partial class BillingAccountName : gax::IResourceName, sys::IEquatable<BillingAccountName>
    {
        /// <summary>The possible contents of <see cref="BillingAccountName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>accounts/{account}/billingAccounts/{billing_account}</c>.
            /// </summary>
            AccountBillingAccount = 1,
        }

        private static gax::PathTemplate s_accountBillingAccount = new gax::PathTemplate("accounts/{account}/billingAccounts/{billing_account}");

        /// <summary>Creates a <see cref="BillingAccountName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="BillingAccountName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static BillingAccountName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new BillingAccountName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="BillingAccountName"/> with the pattern
        /// <c>accounts/{account}/billingAccounts/{billing_account}</c>.
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="billingAccountId">The <c>BillingAccount</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="BillingAccountName"/> constructed from the provided ids.</returns>
        public static BillingAccountName FromAccountBillingAccount(string accountId, string billingAccountId) =>
            new BillingAccountName(ResourceNameType.AccountBillingAccount, accountId: gax::GaxPreconditions.CheckNotNullOrEmpty(accountId, nameof(accountId)), billingAccountId: gax::GaxPreconditions.CheckNotNullOrEmpty(billingAccountId, nameof(billingAccountId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="BillingAccountName"/> with pattern
        /// <c>accounts/{account}/billingAccounts/{billing_account}</c>.
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="billingAccountId">The <c>BillingAccount</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="BillingAccountName"/> with pattern
        /// <c>accounts/{account}/billingAccounts/{billing_account}</c>.
        /// </returns>
        public static string Format(string accountId, string billingAccountId) =>
            FormatAccountBillingAccount(accountId, billingAccountId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="BillingAccountName"/> with pattern
        /// <c>accounts/{account}/billingAccounts/{billing_account}</c>.
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="billingAccountId">The <c>BillingAccount</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="BillingAccountName"/> with pattern
        /// <c>accounts/{account}/billingAccounts/{billing_account}</c>.
        /// </returns>
        public static string FormatAccountBillingAccount(string accountId, string billingAccountId) =>
            s_accountBillingAccount.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(accountId, nameof(accountId)), gax::GaxPreconditions.CheckNotNullOrEmpty(billingAccountId, nameof(billingAccountId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="BillingAccountName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>accounts/{account}/billingAccounts/{billing_account}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="billingAccountName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="BillingAccountName"/> if successful.</returns>
        public static BillingAccountName Parse(string billingAccountName) => Parse(billingAccountName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="BillingAccountName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>accounts/{account}/billingAccounts/{billing_account}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="billingAccountName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="BillingAccountName"/> if successful.</returns>
        public static BillingAccountName Parse(string billingAccountName, bool allowUnparsed) =>
            TryParse(billingAccountName, allowUnparsed, out BillingAccountName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="BillingAccountName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>accounts/{account}/billingAccounts/{billing_account}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="billingAccountName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="BillingAccountName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string billingAccountName, out BillingAccountName result) =>
            TryParse(billingAccountName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="BillingAccountName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>accounts/{account}/billingAccounts/{billing_account}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="billingAccountName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="BillingAccountName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string billingAccountName, bool allowUnparsed, out BillingAccountName result)
        {
            gax::GaxPreconditions.CheckNotNull(billingAccountName, nameof(billingAccountName));
            gax::TemplatedResourceName resourceName;
            if (s_accountBillingAccount.TryParseName(billingAccountName, out resourceName))
            {
                result = FromAccountBillingAccount(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(billingAccountName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private BillingAccountName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string accountId = null, string billingAccountId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AccountId = accountId;
            BillingAccountId = billingAccountId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="BillingAccountName"/> class from the component parts of pattern
        /// <c>accounts/{account}/billingAccounts/{billing_account}</c>
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="billingAccountId">The <c>BillingAccount</c> ID. Must not be <c>null</c> or empty.</param>
        public BillingAccountName(string accountId, string billingAccountId) : this(ResourceNameType.AccountBillingAccount, accountId: gax::GaxPreconditions.CheckNotNullOrEmpty(accountId, nameof(accountId)), billingAccountId: gax::GaxPreconditions.CheckNotNullOrEmpty(billingAccountId, nameof(billingAccountId)))
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
        /// The <c>BillingAccount</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string BillingAccountId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.AccountBillingAccount: return s_accountBillingAccount.Expand(AccountId, BillingAccountId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as BillingAccountName);

        /// <inheritdoc/>
        public bool Equals(BillingAccountName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(BillingAccountName a, BillingAccountName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(BillingAccountName a, BillingAccountName b) => !(a == b);
    }

    public partial class BillingAccount
    {
        /// <summary>
        /// <see cref="gccv::BillingAccountName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::BillingAccountName BillingAccountName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::BillingAccountName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
