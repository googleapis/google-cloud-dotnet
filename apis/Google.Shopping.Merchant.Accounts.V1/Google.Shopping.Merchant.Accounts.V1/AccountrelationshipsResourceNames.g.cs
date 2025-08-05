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
using gsmav = Google.Shopping.Merchant.Accounts.V1;
using sys = System;

namespace Google.Shopping.Merchant.Accounts.V1
{
    /// <summary>Resource name for the <c>AccountRelationship</c> resource.</summary>
    public sealed partial class AccountRelationshipName : gax::IResourceName, sys::IEquatable<AccountRelationshipName>
    {
        /// <summary>The possible contents of <see cref="AccountRelationshipName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>accounts/{account}/relationships/{relationship}</c>.</summary>
            AccountRelationship = 1,
        }

        private static gax::PathTemplate s_accountRelationship = new gax::PathTemplate("accounts/{account}/relationships/{relationship}");

        /// <summary>Creates a <see cref="AccountRelationshipName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="AccountRelationshipName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static AccountRelationshipName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new AccountRelationshipName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="AccountRelationshipName"/> with the pattern
        /// <c>accounts/{account}/relationships/{relationship}</c>.
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="relationshipId">The <c>Relationship</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// A new instance of <see cref="AccountRelationshipName"/> constructed from the provided ids.
        /// </returns>
        public static AccountRelationshipName FromAccountRelationship(string accountId, string relationshipId) =>
            new AccountRelationshipName(ResourceNameType.AccountRelationship, accountId: gax::GaxPreconditions.CheckNotNullOrEmpty(accountId, nameof(accountId)), relationshipId: gax::GaxPreconditions.CheckNotNullOrEmpty(relationshipId, nameof(relationshipId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AccountRelationshipName"/> with pattern
        /// <c>accounts/{account}/relationships/{relationship}</c>.
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="relationshipId">The <c>Relationship</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AccountRelationshipName"/> with pattern
        /// <c>accounts/{account}/relationships/{relationship}</c>.
        /// </returns>
        public static string Format(string accountId, string relationshipId) =>
            FormatAccountRelationship(accountId, relationshipId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AccountRelationshipName"/> with pattern
        /// <c>accounts/{account}/relationships/{relationship}</c>.
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="relationshipId">The <c>Relationship</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AccountRelationshipName"/> with pattern
        /// <c>accounts/{account}/relationships/{relationship}</c>.
        /// </returns>
        public static string FormatAccountRelationship(string accountId, string relationshipId) =>
            s_accountRelationship.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(accountId, nameof(accountId)), gax::GaxPreconditions.CheckNotNullOrEmpty(relationshipId, nameof(relationshipId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AccountRelationshipName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>accounts/{account}/relationships/{relationship}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="accountRelationshipName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AccountRelationshipName"/> if successful.</returns>
        public static AccountRelationshipName Parse(string accountRelationshipName) => Parse(accountRelationshipName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AccountRelationshipName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>accounts/{account}/relationships/{relationship}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="accountRelationshipName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="AccountRelationshipName"/> if successful.</returns>
        public static AccountRelationshipName Parse(string accountRelationshipName, bool allowUnparsed) =>
            TryParse(accountRelationshipName, allowUnparsed, out AccountRelationshipName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AccountRelationshipName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>accounts/{account}/relationships/{relationship}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="accountRelationshipName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AccountRelationshipName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string accountRelationshipName, out AccountRelationshipName result) =>
            TryParse(accountRelationshipName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AccountRelationshipName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>accounts/{account}/relationships/{relationship}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="accountRelationshipName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AccountRelationshipName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string accountRelationshipName, bool allowUnparsed, out AccountRelationshipName result)
        {
            gax::GaxPreconditions.CheckNotNull(accountRelationshipName, nameof(accountRelationshipName));
            gax::TemplatedResourceName resourceName;
            if (s_accountRelationship.TryParseName(accountRelationshipName, out resourceName))
            {
                result = FromAccountRelationship(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(accountRelationshipName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private AccountRelationshipName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string accountId = null, string relationshipId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AccountId = accountId;
            RelationshipId = relationshipId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="AccountRelationshipName"/> class from the component parts of
        /// pattern <c>accounts/{account}/relationships/{relationship}</c>
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="relationshipId">The <c>Relationship</c> ID. Must not be <c>null</c> or empty.</param>
        public AccountRelationshipName(string accountId, string relationshipId) : this(ResourceNameType.AccountRelationship, accountId: gax::GaxPreconditions.CheckNotNullOrEmpty(accountId, nameof(accountId)), relationshipId: gax::GaxPreconditions.CheckNotNullOrEmpty(relationshipId, nameof(relationshipId)))
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
        /// The <c>Relationship</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string RelationshipId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.AccountRelationship: return s_accountRelationship.Expand(AccountId, RelationshipId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as AccountRelationshipName);

        /// <inheritdoc/>
        public bool Equals(AccountRelationshipName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(AccountRelationshipName a, AccountRelationshipName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(AccountRelationshipName a, AccountRelationshipName b) => !(a == b);
    }

    public partial class AccountRelationship
    {
        /// <summary>
        /// <see cref="gsmav::AccountRelationshipName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gsmav::AccountRelationshipName AccountRelationshipName
        {
            get => string.IsNullOrEmpty(Name) ? null : gsmav::AccountRelationshipName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetAccountRelationshipRequest
    {
        /// <summary>
        /// <see cref="gsmav::AccountRelationshipName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gsmav::AccountRelationshipName AccountRelationshipName
        {
            get => string.IsNullOrEmpty(Name) ? null : gsmav::AccountRelationshipName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListAccountRelationshipsRequest
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
