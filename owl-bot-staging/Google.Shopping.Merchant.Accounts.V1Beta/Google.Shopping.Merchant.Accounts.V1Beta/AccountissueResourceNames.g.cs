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
    /// <summary>Resource name for the <c>AccountIssue</c> resource.</summary>
    public sealed partial class AccountIssueName : gax::IResourceName, sys::IEquatable<AccountIssueName>
    {
        /// <summary>The possible contents of <see cref="AccountIssueName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>accounts/{account}/issues/{issue}</c>.</summary>
            AccountIssue = 1,
        }

        private static gax::PathTemplate s_accountIssue = new gax::PathTemplate("accounts/{account}/issues/{issue}");

        /// <summary>Creates a <see cref="AccountIssueName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="AccountIssueName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static AccountIssueName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new AccountIssueName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="AccountIssueName"/> with the pattern <c>accounts/{account}/issues/{issue}</c>.
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="issueId">The <c>Issue</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="AccountIssueName"/> constructed from the provided ids.</returns>
        public static AccountIssueName FromAccountIssue(string accountId, string issueId) =>
            new AccountIssueName(ResourceNameType.AccountIssue, accountId: gax::GaxPreconditions.CheckNotNullOrEmpty(accountId, nameof(accountId)), issueId: gax::GaxPreconditions.CheckNotNullOrEmpty(issueId, nameof(issueId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AccountIssueName"/> with pattern
        /// <c>accounts/{account}/issues/{issue}</c>.
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="issueId">The <c>Issue</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AccountIssueName"/> with pattern
        /// <c>accounts/{account}/issues/{issue}</c>.
        /// </returns>
        public static string Format(string accountId, string issueId) => FormatAccountIssue(accountId, issueId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AccountIssueName"/> with pattern
        /// <c>accounts/{account}/issues/{issue}</c>.
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="issueId">The <c>Issue</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AccountIssueName"/> with pattern
        /// <c>accounts/{account}/issues/{issue}</c>.
        /// </returns>
        public static string FormatAccountIssue(string accountId, string issueId) =>
            s_accountIssue.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(accountId, nameof(accountId)), gax::GaxPreconditions.CheckNotNullOrEmpty(issueId, nameof(issueId)));

        /// <summary>Parses the given resource name string into a new <see cref="AccountIssueName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>accounts/{account}/issues/{issue}</c></description></item></list>
        /// </remarks>
        /// <param name="accountIssueName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AccountIssueName"/> if successful.</returns>
        public static AccountIssueName Parse(string accountIssueName) => Parse(accountIssueName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AccountIssueName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>accounts/{account}/issues/{issue}</c></description></item></list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="accountIssueName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="AccountIssueName"/> if successful.</returns>
        public static AccountIssueName Parse(string accountIssueName, bool allowUnparsed) =>
            TryParse(accountIssueName, allowUnparsed, out AccountIssueName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AccountIssueName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>accounts/{account}/issues/{issue}</c></description></item></list>
        /// </remarks>
        /// <param name="accountIssueName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AccountIssueName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string accountIssueName, out AccountIssueName result) =>
            TryParse(accountIssueName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AccountIssueName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>accounts/{account}/issues/{issue}</c></description></item></list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="accountIssueName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AccountIssueName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string accountIssueName, bool allowUnparsed, out AccountIssueName result)
        {
            gax::GaxPreconditions.CheckNotNull(accountIssueName, nameof(accountIssueName));
            gax::TemplatedResourceName resourceName;
            if (s_accountIssue.TryParseName(accountIssueName, out resourceName))
            {
                result = FromAccountIssue(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(accountIssueName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private AccountIssueName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string accountId = null, string issueId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AccountId = accountId;
            IssueId = issueId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="AccountIssueName"/> class from the component parts of pattern
        /// <c>accounts/{account}/issues/{issue}</c>
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="issueId">The <c>Issue</c> ID. Must not be <c>null</c> or empty.</param>
        public AccountIssueName(string accountId, string issueId) : this(ResourceNameType.AccountIssue, accountId: gax::GaxPreconditions.CheckNotNullOrEmpty(accountId, nameof(accountId)), issueId: gax::GaxPreconditions.CheckNotNullOrEmpty(issueId, nameof(issueId)))
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
        /// The <c>Issue</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string IssueId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.AccountIssue: return s_accountIssue.Expand(AccountId, IssueId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as AccountIssueName);

        /// <inheritdoc/>
        public bool Equals(AccountIssueName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(AccountIssueName a, AccountIssueName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(AccountIssueName a, AccountIssueName b) => !(a == b);
    }

    public partial class AccountIssue
    {
        /// <summary>
        /// <see cref="gsmav::AccountIssueName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gsmav::AccountIssueName AccountIssueName
        {
            get => string.IsNullOrEmpty(Name) ? null : gsmav::AccountIssueName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListAccountIssuesRequest
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
