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
using gsmav = Google.Shopping.Merchant.Accounts.V1Beta;
using sys = System;

namespace Google.Shopping.Merchant.Accounts.V1Beta
{
    /// <summary>Resource name for the <c>ShippingSettings</c> resource.</summary>
    public sealed partial class ShippingSettingsName : gax::IResourceName, sys::IEquatable<ShippingSettingsName>
    {
        /// <summary>The possible contents of <see cref="ShippingSettingsName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>accounts/{account}/shippingSettings</c>.</summary>
            Account = 1,
        }

        private static gax::PathTemplate s_account = new gax::PathTemplate("accounts/{account}/shippingSettings");

        /// <summary>Creates a <see cref="ShippingSettingsName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ShippingSettingsName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ShippingSettingsName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ShippingSettingsName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ShippingSettingsName"/> with the pattern <c>accounts/{account}/shippingSettings</c>.
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ShippingSettingsName"/> constructed from the provided ids.</returns>
        public static ShippingSettingsName FromAccount(string accountId) =>
            new ShippingSettingsName(ResourceNameType.Account, accountId: gax::GaxPreconditions.CheckNotNullOrEmpty(accountId, nameof(accountId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ShippingSettingsName"/> with pattern
        /// <c>accounts/{account}/shippingSettings</c>.
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ShippingSettingsName"/> with pattern
        /// <c>accounts/{account}/shippingSettings</c>.
        /// </returns>
        public static string Format(string accountId) => FormatAccount(accountId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ShippingSettingsName"/> with pattern
        /// <c>accounts/{account}/shippingSettings</c>.
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ShippingSettingsName"/> with pattern
        /// <c>accounts/{account}/shippingSettings</c>.
        /// </returns>
        public static string FormatAccount(string accountId) =>
            s_account.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(accountId, nameof(accountId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ShippingSettingsName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>accounts/{account}/shippingSettings</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="shippingSettingsName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ShippingSettingsName"/> if successful.</returns>
        public static ShippingSettingsName Parse(string shippingSettingsName) => Parse(shippingSettingsName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ShippingSettingsName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>accounts/{account}/shippingSettings</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="shippingSettingsName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ShippingSettingsName"/> if successful.</returns>
        public static ShippingSettingsName Parse(string shippingSettingsName, bool allowUnparsed) =>
            TryParse(shippingSettingsName, allowUnparsed, out ShippingSettingsName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ShippingSettingsName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>accounts/{account}/shippingSettings</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="shippingSettingsName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ShippingSettingsName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string shippingSettingsName, out ShippingSettingsName result) =>
            TryParse(shippingSettingsName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ShippingSettingsName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>accounts/{account}/shippingSettings</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="shippingSettingsName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ShippingSettingsName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string shippingSettingsName, bool allowUnparsed, out ShippingSettingsName result)
        {
            gax::GaxPreconditions.CheckNotNull(shippingSettingsName, nameof(shippingSettingsName));
            gax::TemplatedResourceName resourceName;
            if (s_account.TryParseName(shippingSettingsName, out resourceName))
            {
                result = FromAccount(resourceName[0]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(shippingSettingsName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ShippingSettingsName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string accountId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AccountId = accountId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ShippingSettingsName"/> class from the component parts of pattern
        /// <c>accounts/{account}/shippingSettings</c>
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        public ShippingSettingsName(string accountId) : this(ResourceNameType.Account, accountId: gax::GaxPreconditions.CheckNotNullOrEmpty(accountId, nameof(accountId)))
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
        public override bool Equals(object obj) => Equals(obj as ShippingSettingsName);

        /// <inheritdoc/>
        public bool Equals(ShippingSettingsName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ShippingSettingsName a, ShippingSettingsName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ShippingSettingsName a, ShippingSettingsName b) => !(a == b);
    }

    public partial class ShippingSettings
    {
        /// <summary>
        /// <see cref="gsmav::ShippingSettingsName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gsmav::ShippingSettingsName ShippingSettingsName
        {
            get => string.IsNullOrEmpty(Name) ? null : gsmav::ShippingSettingsName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetShippingSettingsRequest
    {
        /// <summary>
        /// <see cref="gsmav::ShippingSettingsName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gsmav::ShippingSettingsName ShippingSettingsName
        {
            get => string.IsNullOrEmpty(Name) ? null : gsmav::ShippingSettingsName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
