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
using gscv = Google.Shopping.Css.V1;
using sys = System;

namespace Google.Shopping.Css.V1
{
    /// <summary>Resource name for the <c>AccountLabel</c> resource.</summary>
    public sealed partial class AccountLabelName : gax::IResourceName, sys::IEquatable<AccountLabelName>
    {
        /// <summary>The possible contents of <see cref="AccountLabelName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>accounts/{account}/labels/{label}</c>.</summary>
            AccountLabel = 1,
        }

        private static gax::PathTemplate s_accountLabel = new gax::PathTemplate("accounts/{account}/labels/{label}");

        /// <summary>Creates a <see cref="AccountLabelName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="AccountLabelName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static AccountLabelName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new AccountLabelName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="AccountLabelName"/> with the pattern <c>accounts/{account}/labels/{label}</c>.
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="labelId">The <c>Label</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="AccountLabelName"/> constructed from the provided ids.</returns>
        public static AccountLabelName FromAccountLabel(string accountId, string labelId) =>
            new AccountLabelName(ResourceNameType.AccountLabel, accountId: gax::GaxPreconditions.CheckNotNullOrEmpty(accountId, nameof(accountId)), labelId: gax::GaxPreconditions.CheckNotNullOrEmpty(labelId, nameof(labelId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AccountLabelName"/> with pattern
        /// <c>accounts/{account}/labels/{label}</c>.
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="labelId">The <c>Label</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AccountLabelName"/> with pattern
        /// <c>accounts/{account}/labels/{label}</c>.
        /// </returns>
        public static string Format(string accountId, string labelId) => FormatAccountLabel(accountId, labelId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AccountLabelName"/> with pattern
        /// <c>accounts/{account}/labels/{label}</c>.
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="labelId">The <c>Label</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AccountLabelName"/> with pattern
        /// <c>accounts/{account}/labels/{label}</c>.
        /// </returns>
        public static string FormatAccountLabel(string accountId, string labelId) =>
            s_accountLabel.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(accountId, nameof(accountId)), gax::GaxPreconditions.CheckNotNullOrEmpty(labelId, nameof(labelId)));

        /// <summary>Parses the given resource name string into a new <see cref="AccountLabelName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>accounts/{account}/labels/{label}</c></description></item></list>
        /// </remarks>
        /// <param name="accountLabelName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AccountLabelName"/> if successful.</returns>
        public static AccountLabelName Parse(string accountLabelName) => Parse(accountLabelName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AccountLabelName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>accounts/{account}/labels/{label}</c></description></item></list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="accountLabelName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="AccountLabelName"/> if successful.</returns>
        public static AccountLabelName Parse(string accountLabelName, bool allowUnparsed) =>
            TryParse(accountLabelName, allowUnparsed, out AccountLabelName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AccountLabelName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>accounts/{account}/labels/{label}</c></description></item></list>
        /// </remarks>
        /// <param name="accountLabelName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AccountLabelName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string accountLabelName, out AccountLabelName result) =>
            TryParse(accountLabelName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AccountLabelName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>accounts/{account}/labels/{label}</c></description></item></list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="accountLabelName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AccountLabelName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string accountLabelName, bool allowUnparsed, out AccountLabelName result)
        {
            gax::GaxPreconditions.CheckNotNull(accountLabelName, nameof(accountLabelName));
            gax::TemplatedResourceName resourceName;
            if (s_accountLabel.TryParseName(accountLabelName, out resourceName))
            {
                result = FromAccountLabel(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(accountLabelName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private AccountLabelName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string accountId = null, string labelId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AccountId = accountId;
            LabelId = labelId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="AccountLabelName"/> class from the component parts of pattern
        /// <c>accounts/{account}/labels/{label}</c>
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="labelId">The <c>Label</c> ID. Must not be <c>null</c> or empty.</param>
        public AccountLabelName(string accountId, string labelId) : this(ResourceNameType.AccountLabel, accountId: gax::GaxPreconditions.CheckNotNullOrEmpty(accountId, nameof(accountId)), labelId: gax::GaxPreconditions.CheckNotNullOrEmpty(labelId, nameof(labelId)))
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
        /// The <c>Label</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LabelId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.AccountLabel: return s_accountLabel.Expand(AccountId, LabelId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as AccountLabelName);

        /// <inheritdoc/>
        public bool Equals(AccountLabelName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(AccountLabelName a, AccountLabelName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(AccountLabelName a, AccountLabelName b) => !(a == b);
    }

    public partial class AccountLabel
    {
        /// <summary>
        /// <see cref="gscv::AccountLabelName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gscv::AccountLabelName AccountLabelName
        {
            get => string.IsNullOrEmpty(Name) ? null : gscv::AccountLabelName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListAccountLabelsRequest
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

    public partial class CreateAccountLabelRequest
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

    public partial class DeleteAccountLabelRequest
    {
        /// <summary>
        /// <see cref="gscv::AccountLabelName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gscv::AccountLabelName AccountLabelName
        {
            get => string.IsNullOrEmpty(Name) ? null : gscv::AccountLabelName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
