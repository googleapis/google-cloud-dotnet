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
using gsmiv = Google.Shopping.Merchant.Inventories.V1Beta;
using sys = System;

namespace Google.Shopping.Merchant.Inventories.V1Beta
{
    /// <summary>Resource name for the <c>LocalInventory</c> resource.</summary>
    public sealed partial class LocalInventoryName : gax::IResourceName, sys::IEquatable<LocalInventoryName>
    {
        /// <summary>The possible contents of <see cref="LocalInventoryName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>accounts/{account}/products/{product}/localInventories/{store_code}</c>.
            /// </summary>
            AccountProductStoreCode = 1,
        }

        private static gax::PathTemplate s_accountProductStoreCode = new gax::PathTemplate("accounts/{account}/products/{product}/localInventories/{store_code}");

        /// <summary>Creates a <see cref="LocalInventoryName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="LocalInventoryName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static LocalInventoryName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new LocalInventoryName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="LocalInventoryName"/> with the pattern
        /// <c>accounts/{account}/products/{product}/localInventories/{store_code}</c>.
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="productId">The <c>Product</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="storeCodeId">The <c>StoreCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="LocalInventoryName"/> constructed from the provided ids.</returns>
        public static LocalInventoryName FromAccountProductStoreCode(string accountId, string productId, string storeCodeId) =>
            new LocalInventoryName(ResourceNameType.AccountProductStoreCode, accountId: gax::GaxPreconditions.CheckNotNullOrEmpty(accountId, nameof(accountId)), productId: gax::GaxPreconditions.CheckNotNullOrEmpty(productId, nameof(productId)), storeCodeId: gax::GaxPreconditions.CheckNotNullOrEmpty(storeCodeId, nameof(storeCodeId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="LocalInventoryName"/> with pattern
        /// <c>accounts/{account}/products/{product}/localInventories/{store_code}</c>.
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="productId">The <c>Product</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="storeCodeId">The <c>StoreCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="LocalInventoryName"/> with pattern
        /// <c>accounts/{account}/products/{product}/localInventories/{store_code}</c>.
        /// </returns>
        public static string Format(string accountId, string productId, string storeCodeId) =>
            FormatAccountProductStoreCode(accountId, productId, storeCodeId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="LocalInventoryName"/> with pattern
        /// <c>accounts/{account}/products/{product}/localInventories/{store_code}</c>.
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="productId">The <c>Product</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="storeCodeId">The <c>StoreCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="LocalInventoryName"/> with pattern
        /// <c>accounts/{account}/products/{product}/localInventories/{store_code}</c>.
        /// </returns>
        public static string FormatAccountProductStoreCode(string accountId, string productId, string storeCodeId) =>
            s_accountProductStoreCode.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(accountId, nameof(accountId)), gax::GaxPreconditions.CheckNotNullOrEmpty(productId, nameof(productId)), gax::GaxPreconditions.CheckNotNullOrEmpty(storeCodeId, nameof(storeCodeId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="LocalInventoryName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>accounts/{account}/products/{product}/localInventories/{store_code}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="localInventoryName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="LocalInventoryName"/> if successful.</returns>
        public static LocalInventoryName Parse(string localInventoryName) => Parse(localInventoryName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="LocalInventoryName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>accounts/{account}/products/{product}/localInventories/{store_code}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="localInventoryName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="LocalInventoryName"/> if successful.</returns>
        public static LocalInventoryName Parse(string localInventoryName, bool allowUnparsed) =>
            TryParse(localInventoryName, allowUnparsed, out LocalInventoryName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="LocalInventoryName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>accounts/{account}/products/{product}/localInventories/{store_code}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="localInventoryName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="LocalInventoryName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string localInventoryName, out LocalInventoryName result) =>
            TryParse(localInventoryName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="LocalInventoryName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>accounts/{account}/products/{product}/localInventories/{store_code}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="localInventoryName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="LocalInventoryName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string localInventoryName, bool allowUnparsed, out LocalInventoryName result)
        {
            gax::GaxPreconditions.CheckNotNull(localInventoryName, nameof(localInventoryName));
            gax::TemplatedResourceName resourceName;
            if (s_accountProductStoreCode.TryParseName(localInventoryName, out resourceName))
            {
                result = FromAccountProductStoreCode(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(localInventoryName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private LocalInventoryName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string accountId = null, string productId = null, string storeCodeId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AccountId = accountId;
            ProductId = productId;
            StoreCodeId = storeCodeId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="LocalInventoryName"/> class from the component parts of pattern
        /// <c>accounts/{account}/products/{product}/localInventories/{store_code}</c>
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="productId">The <c>Product</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="storeCodeId">The <c>StoreCode</c> ID. Must not be <c>null</c> or empty.</param>
        public LocalInventoryName(string accountId, string productId, string storeCodeId) : this(ResourceNameType.AccountProductStoreCode, accountId: gax::GaxPreconditions.CheckNotNullOrEmpty(accountId, nameof(accountId)), productId: gax::GaxPreconditions.CheckNotNullOrEmpty(productId, nameof(productId)), storeCodeId: gax::GaxPreconditions.CheckNotNullOrEmpty(storeCodeId, nameof(storeCodeId)))
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
        /// The <c>StoreCode</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string StoreCodeId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.AccountProductStoreCode: return s_accountProductStoreCode.Expand(AccountId, ProductId, StoreCodeId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as LocalInventoryName);

        /// <inheritdoc/>
        public bool Equals(LocalInventoryName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(LocalInventoryName a, LocalInventoryName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(LocalInventoryName a, LocalInventoryName b) => !(a == b);
    }

    public partial class LocalInventory
    {
        /// <summary>
        /// <see cref="gsmiv::LocalInventoryName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gsmiv::LocalInventoryName LocalInventoryName
        {
            get => string.IsNullOrEmpty(Name) ? null : gsmiv::LocalInventoryName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteLocalInventoryRequest
    {
        /// <summary>
        /// <see cref="gsmiv::LocalInventoryName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gsmiv::LocalInventoryName LocalInventoryName
        {
            get => string.IsNullOrEmpty(Name) ? null : gsmiv::LocalInventoryName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
