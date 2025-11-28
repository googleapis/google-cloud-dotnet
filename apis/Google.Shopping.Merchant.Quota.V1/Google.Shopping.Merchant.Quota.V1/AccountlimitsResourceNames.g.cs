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
using gsmqv = Google.Shopping.Merchant.Quota.V1;
using sys = System;

namespace Google.Shopping.Merchant.Quota.V1
{
    /// <summary>Resource name for the <c>AccountLimit</c> resource.</summary>
    public sealed partial class AccountLimitName : gax::IResourceName, sys::IEquatable<AccountLimitName>
    {
        /// <summary>The possible contents of <see cref="AccountLimitName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>accounts/{account}/limits/{limit}</c>.</summary>
            AccountLimit = 1,
        }

        private static gax::PathTemplate s_accountLimit = new gax::PathTemplate("accounts/{account}/limits/{limit}");

        /// <summary>Creates a <see cref="AccountLimitName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="AccountLimitName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static AccountLimitName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new AccountLimitName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="AccountLimitName"/> with the pattern <c>accounts/{account}/limits/{limit}</c>.
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="limitId">The <c>Limit</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="AccountLimitName"/> constructed from the provided ids.</returns>
        public static AccountLimitName FromAccountLimit(string accountId, string limitId) =>
            new AccountLimitName(ResourceNameType.AccountLimit, accountId: gax::GaxPreconditions.CheckNotNullOrEmpty(accountId, nameof(accountId)), limitId: gax::GaxPreconditions.CheckNotNullOrEmpty(limitId, nameof(limitId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AccountLimitName"/> with pattern
        /// <c>accounts/{account}/limits/{limit}</c>.
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="limitId">The <c>Limit</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AccountLimitName"/> with pattern
        /// <c>accounts/{account}/limits/{limit}</c>.
        /// </returns>
        public static string Format(string accountId, string limitId) => FormatAccountLimit(accountId, limitId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AccountLimitName"/> with pattern
        /// <c>accounts/{account}/limits/{limit}</c>.
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="limitId">The <c>Limit</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AccountLimitName"/> with pattern
        /// <c>accounts/{account}/limits/{limit}</c>.
        /// </returns>
        public static string FormatAccountLimit(string accountId, string limitId) =>
            s_accountLimit.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(accountId, nameof(accountId)), gax::GaxPreconditions.CheckNotNullOrEmpty(limitId, nameof(limitId)));

        /// <summary>Parses the given resource name string into a new <see cref="AccountLimitName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>accounts/{account}/limits/{limit}</c></description></item></list>
        /// </remarks>
        /// <param name="accountLimitName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AccountLimitName"/> if successful.</returns>
        public static AccountLimitName Parse(string accountLimitName) => Parse(accountLimitName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AccountLimitName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>accounts/{account}/limits/{limit}</c></description></item></list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="accountLimitName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="AccountLimitName"/> if successful.</returns>
        public static AccountLimitName Parse(string accountLimitName, bool allowUnparsed) =>
            TryParse(accountLimitName, allowUnparsed, out AccountLimitName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AccountLimitName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>accounts/{account}/limits/{limit}</c></description></item></list>
        /// </remarks>
        /// <param name="accountLimitName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AccountLimitName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string accountLimitName, out AccountLimitName result) =>
            TryParse(accountLimitName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AccountLimitName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>accounts/{account}/limits/{limit}</c></description></item></list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="accountLimitName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AccountLimitName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string accountLimitName, bool allowUnparsed, out AccountLimitName result)
        {
            gax::GaxPreconditions.CheckNotNull(accountLimitName, nameof(accountLimitName));
            gax::TemplatedResourceName resourceName;
            if (s_accountLimit.TryParseName(accountLimitName, out resourceName))
            {
                result = FromAccountLimit(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(accountLimitName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private AccountLimitName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string accountId = null, string limitId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AccountId = accountId;
            LimitId = limitId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="AccountLimitName"/> class from the component parts of pattern
        /// <c>accounts/{account}/limits/{limit}</c>
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="limitId">The <c>Limit</c> ID. Must not be <c>null</c> or empty.</param>
        public AccountLimitName(string accountId, string limitId) : this(ResourceNameType.AccountLimit, accountId: gax::GaxPreconditions.CheckNotNullOrEmpty(accountId, nameof(accountId)), limitId: gax::GaxPreconditions.CheckNotNullOrEmpty(limitId, nameof(limitId)))
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
        /// The <c>Limit</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LimitId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.AccountLimit: return s_accountLimit.Expand(AccountId, LimitId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as AccountLimitName);

        /// <inheritdoc/>
        public bool Equals(AccountLimitName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(AccountLimitName a, AccountLimitName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(AccountLimitName a, AccountLimitName b) => !(a == b);
    }

    public partial class AccountLimit
    {
        /// <summary>
        /// <see cref="gsmqv::AccountLimitName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gsmqv::AccountLimitName AccountLimitName
        {
            get => string.IsNullOrEmpty(Name) ? null : gsmqv::AccountLimitName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetAccountLimitRequest
    {
        /// <summary>
        /// <see cref="gsmqv::AccountLimitName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gsmqv::AccountLimitName AccountLimitName
        {
            get => string.IsNullOrEmpty(Name) ? null : gsmqv::AccountLimitName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListAccountLimitsRequest
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
