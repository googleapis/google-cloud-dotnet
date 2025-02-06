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
using gsmiv = Google.Shopping.Merchant.Inventories.V1Beta;
using sys = System;

namespace Google.Shopping.Merchant.Inventories.V1Beta
{
    /// <summary>Resource name for the <c>RegionalInventory</c> resource.</summary>
    public sealed partial class RegionalInventoryName : gax::IResourceName, sys::IEquatable<RegionalInventoryName>
    {
        /// <summary>The possible contents of <see cref="RegionalInventoryName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>accounts/{account}/products/{product}/regionalInventories/{region}</c>.
            /// </summary>
            AccountProductRegion = 1,
        }

        private static gax::PathTemplate s_accountProductRegion = new gax::PathTemplate("accounts/{account}/products/{product}/regionalInventories/{region}");

        /// <summary>Creates a <see cref="RegionalInventoryName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="RegionalInventoryName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static RegionalInventoryName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new RegionalInventoryName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="RegionalInventoryName"/> with the pattern
        /// <c>accounts/{account}/products/{product}/regionalInventories/{region}</c>.
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="productId">The <c>Product</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="regionId">The <c>Region</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="RegionalInventoryName"/> constructed from the provided ids.</returns>
        public static RegionalInventoryName FromAccountProductRegion(string accountId, string productId, string regionId) =>
            new RegionalInventoryName(ResourceNameType.AccountProductRegion, accountId: gax::GaxPreconditions.CheckNotNullOrEmpty(accountId, nameof(accountId)), productId: gax::GaxPreconditions.CheckNotNullOrEmpty(productId, nameof(productId)), regionId: gax::GaxPreconditions.CheckNotNullOrEmpty(regionId, nameof(regionId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="RegionalInventoryName"/> with pattern
        /// <c>accounts/{account}/products/{product}/regionalInventories/{region}</c>.
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="productId">The <c>Product</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="regionId">The <c>Region</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="RegionalInventoryName"/> with pattern
        /// <c>accounts/{account}/products/{product}/regionalInventories/{region}</c>.
        /// </returns>
        public static string Format(string accountId, string productId, string regionId) =>
            FormatAccountProductRegion(accountId, productId, regionId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="RegionalInventoryName"/> with pattern
        /// <c>accounts/{account}/products/{product}/regionalInventories/{region}</c>.
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="productId">The <c>Product</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="regionId">The <c>Region</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="RegionalInventoryName"/> with pattern
        /// <c>accounts/{account}/products/{product}/regionalInventories/{region}</c>.
        /// </returns>
        public static string FormatAccountProductRegion(string accountId, string productId, string regionId) =>
            s_accountProductRegion.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(accountId, nameof(accountId)), gax::GaxPreconditions.CheckNotNullOrEmpty(productId, nameof(productId)), gax::GaxPreconditions.CheckNotNullOrEmpty(regionId, nameof(regionId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="RegionalInventoryName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>accounts/{account}/products/{product}/regionalInventories/{region}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="regionalInventoryName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="RegionalInventoryName"/> if successful.</returns>
        public static RegionalInventoryName Parse(string regionalInventoryName) => Parse(regionalInventoryName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="RegionalInventoryName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>accounts/{account}/products/{product}/regionalInventories/{region}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="regionalInventoryName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="RegionalInventoryName"/> if successful.</returns>
        public static RegionalInventoryName Parse(string regionalInventoryName, bool allowUnparsed) =>
            TryParse(regionalInventoryName, allowUnparsed, out RegionalInventoryName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="RegionalInventoryName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>accounts/{account}/products/{product}/regionalInventories/{region}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="regionalInventoryName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="RegionalInventoryName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string regionalInventoryName, out RegionalInventoryName result) =>
            TryParse(regionalInventoryName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="RegionalInventoryName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>accounts/{account}/products/{product}/regionalInventories/{region}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="regionalInventoryName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="RegionalInventoryName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string regionalInventoryName, bool allowUnparsed, out RegionalInventoryName result)
        {
            gax::GaxPreconditions.CheckNotNull(regionalInventoryName, nameof(regionalInventoryName));
            gax::TemplatedResourceName resourceName;
            if (s_accountProductRegion.TryParseName(regionalInventoryName, out resourceName))
            {
                result = FromAccountProductRegion(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(regionalInventoryName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private RegionalInventoryName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string accountId = null, string productId = null, string regionId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AccountId = accountId;
            ProductId = productId;
            RegionId = regionId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="RegionalInventoryName"/> class from the component parts of pattern
        /// <c>accounts/{account}/products/{product}/regionalInventories/{region}</c>
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="productId">The <c>Product</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="regionId">The <c>Region</c> ID. Must not be <c>null</c> or empty.</param>
        public RegionalInventoryName(string accountId, string productId, string regionId) : this(ResourceNameType.AccountProductRegion, accountId: gax::GaxPreconditions.CheckNotNullOrEmpty(accountId, nameof(accountId)), productId: gax::GaxPreconditions.CheckNotNullOrEmpty(productId, nameof(productId)), regionId: gax::GaxPreconditions.CheckNotNullOrEmpty(regionId, nameof(regionId)))
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
        /// The <c>Product</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProductId { get; }

        /// <summary>
        /// The <c>Region</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string RegionId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.AccountProductRegion: return s_accountProductRegion.Expand(AccountId, ProductId, RegionId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as RegionalInventoryName);

        /// <inheritdoc/>
        public bool Equals(RegionalInventoryName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(RegionalInventoryName a, RegionalInventoryName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(RegionalInventoryName a, RegionalInventoryName b) => !(a == b);
    }

    public partial class RegionalInventory
    {
        /// <summary>
        /// <see cref="gsmiv::RegionalInventoryName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gsmiv::RegionalInventoryName RegionalInventoryName
        {
            get => string.IsNullOrEmpty(Name) ? null : gsmiv::RegionalInventoryName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListRegionalInventoriesRequest
    {
        /// <summary>
        /// <see cref="ProductName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ProductName ParentAsProductName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ProductName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class InsertRegionalInventoryRequest
    {
        /// <summary>
        /// <see cref="ProductName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ProductName ParentAsProductName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ProductName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteRegionalInventoryRequest
    {
        /// <summary>
        /// <see cref="gsmiv::RegionalInventoryName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gsmiv::RegionalInventoryName RegionalInventoryName
        {
            get => string.IsNullOrEmpty(Name) ? null : gsmiv::RegionalInventoryName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
