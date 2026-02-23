// Copyright 2026 Google LLC
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
using gadv = Google.Ads.DataManager.V1;
using gax = Google.Api.Gax;
using sys = System;

namespace Google.Ads.DataManager.V1
{
    /// <summary>Resource name for the <c>PartnerLink</c> resource.</summary>
    public sealed partial class PartnerLinkName : gax::IResourceName, sys::IEquatable<PartnerLinkName>
    {
        /// <summary>The possible contents of <see cref="PartnerLinkName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>accountTypes/{account_type}/accounts/{account}/partnerLinks/{partner_link}</c>.
            /// </summary>
            AccountTypeAccountPartnerLink = 1,
        }

        private static gax::PathTemplate s_accountTypeAccountPartnerLink = new gax::PathTemplate("accountTypes/{account_type}/accounts/{account}/partnerLinks/{partner_link}");

        /// <summary>Creates a <see cref="PartnerLinkName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="PartnerLinkName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static PartnerLinkName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new PartnerLinkName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="PartnerLinkName"/> with the pattern
        /// <c>accountTypes/{account_type}/accounts/{account}/partnerLinks/{partner_link}</c>.
        /// </summary>
        /// <param name="accountTypeId">The <c>AccountType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="partnerLinkId">The <c>PartnerLink</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="PartnerLinkName"/> constructed from the provided ids.</returns>
        public static PartnerLinkName FromAccountTypeAccountPartnerLink(string accountTypeId, string accountId, string partnerLinkId) =>
            new PartnerLinkName(ResourceNameType.AccountTypeAccountPartnerLink, accountTypeId: gax::GaxPreconditions.CheckNotNullOrEmpty(accountTypeId, nameof(accountTypeId)), accountId: gax::GaxPreconditions.CheckNotNullOrEmpty(accountId, nameof(accountId)), partnerLinkId: gax::GaxPreconditions.CheckNotNullOrEmpty(partnerLinkId, nameof(partnerLinkId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="PartnerLinkName"/> with pattern
        /// <c>accountTypes/{account_type}/accounts/{account}/partnerLinks/{partner_link}</c>.
        /// </summary>
        /// <param name="accountTypeId">The <c>AccountType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="partnerLinkId">The <c>PartnerLink</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="PartnerLinkName"/> with pattern
        /// <c>accountTypes/{account_type}/accounts/{account}/partnerLinks/{partner_link}</c>.
        /// </returns>
        public static string Format(string accountTypeId, string accountId, string partnerLinkId) =>
            FormatAccountTypeAccountPartnerLink(accountTypeId, accountId, partnerLinkId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="PartnerLinkName"/> with pattern
        /// <c>accountTypes/{account_type}/accounts/{account}/partnerLinks/{partner_link}</c>.
        /// </summary>
        /// <param name="accountTypeId">The <c>AccountType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="partnerLinkId">The <c>PartnerLink</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="PartnerLinkName"/> with pattern
        /// <c>accountTypes/{account_type}/accounts/{account}/partnerLinks/{partner_link}</c>.
        /// </returns>
        public static string FormatAccountTypeAccountPartnerLink(string accountTypeId, string accountId, string partnerLinkId) =>
            s_accountTypeAccountPartnerLink.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(accountTypeId, nameof(accountTypeId)), gax::GaxPreconditions.CheckNotNullOrEmpty(accountId, nameof(accountId)), gax::GaxPreconditions.CheckNotNullOrEmpty(partnerLinkId, nameof(partnerLinkId)));

        /// <summary>Parses the given resource name string into a new <see cref="PartnerLinkName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>accountTypes/{account_type}/accounts/{account}/partnerLinks/{partner_link}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="partnerLinkName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="PartnerLinkName"/> if successful.</returns>
        public static PartnerLinkName Parse(string partnerLinkName) => Parse(partnerLinkName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="PartnerLinkName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>accountTypes/{account_type}/accounts/{account}/partnerLinks/{partner_link}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="partnerLinkName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="PartnerLinkName"/> if successful.</returns>
        public static PartnerLinkName Parse(string partnerLinkName, bool allowUnparsed) =>
            TryParse(partnerLinkName, allowUnparsed, out PartnerLinkName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="PartnerLinkName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>accountTypes/{account_type}/accounts/{account}/partnerLinks/{partner_link}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="partnerLinkName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="PartnerLinkName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string partnerLinkName, out PartnerLinkName result) =>
            TryParse(partnerLinkName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="PartnerLinkName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>accountTypes/{account_type}/accounts/{account}/partnerLinks/{partner_link}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="partnerLinkName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="PartnerLinkName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string partnerLinkName, bool allowUnparsed, out PartnerLinkName result)
        {
            gax::GaxPreconditions.CheckNotNull(partnerLinkName, nameof(partnerLinkName));
            gax::TemplatedResourceName resourceName;
            if (s_accountTypeAccountPartnerLink.TryParseName(partnerLinkName, out resourceName))
            {
                result = FromAccountTypeAccountPartnerLink(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(partnerLinkName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private PartnerLinkName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string accountId = null, string accountTypeId = null, string partnerLinkId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AccountId = accountId;
            AccountTypeId = accountTypeId;
            PartnerLinkId = partnerLinkId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="PartnerLinkName"/> class from the component parts of pattern
        /// <c>accountTypes/{account_type}/accounts/{account}/partnerLinks/{partner_link}</c>
        /// </summary>
        /// <param name="accountTypeId">The <c>AccountType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="partnerLinkId">The <c>PartnerLink</c> ID. Must not be <c>null</c> or empty.</param>
        public PartnerLinkName(string accountTypeId, string accountId, string partnerLinkId) : this(ResourceNameType.AccountTypeAccountPartnerLink, accountTypeId: gax::GaxPreconditions.CheckNotNullOrEmpty(accountTypeId, nameof(accountTypeId)), accountId: gax::GaxPreconditions.CheckNotNullOrEmpty(accountId, nameof(accountId)), partnerLinkId: gax::GaxPreconditions.CheckNotNullOrEmpty(partnerLinkId, nameof(partnerLinkId)))
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
        /// The <c>AccountType</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string AccountTypeId { get; }

        /// <summary>
        /// The <c>PartnerLink</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string PartnerLinkId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.AccountTypeAccountPartnerLink: return s_accountTypeAccountPartnerLink.Expand(AccountTypeId, AccountId, PartnerLinkId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as PartnerLinkName);

        /// <inheritdoc/>
        public bool Equals(PartnerLinkName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(PartnerLinkName a, PartnerLinkName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(PartnerLinkName a, PartnerLinkName b) => !(a == b);
    }

    public partial class CreatePartnerLinkRequest
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

    public partial class DeletePartnerLinkRequest
    {
        /// <summary>
        /// <see cref="gadv::PartnerLinkName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gadv::PartnerLinkName PartnerLinkName
        {
            get => string.IsNullOrEmpty(Name) ? null : gadv::PartnerLinkName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class SearchPartnerLinksRequest
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

    public partial class PartnerLink
    {
        /// <summary>
        /// <see cref="gadv::PartnerLinkName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gadv::PartnerLinkName PartnerLinkName
        {
            get => string.IsNullOrEmpty(Name) ? null : gadv::PartnerLinkName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
