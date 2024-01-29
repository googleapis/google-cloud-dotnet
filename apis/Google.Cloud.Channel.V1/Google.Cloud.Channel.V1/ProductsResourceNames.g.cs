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
using gccv = Google.Cloud.Channel.V1;
using sys = System;

namespace Google.Cloud.Channel.V1
{
    /// <summary>Resource name for the <c>Product</c> resource.</summary>
    public sealed partial class ProductName : gax::IResourceName, sys::IEquatable<ProductName>
    {
        /// <summary>The possible contents of <see cref="ProductName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>products/{product}</c>.</summary>
            Product = 1,
        }

        private static gax::PathTemplate s_product = new gax::PathTemplate("products/{product}");

        /// <summary>Creates a <see cref="ProductName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ProductName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ProductName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ProductName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>Creates a <see cref="ProductName"/> with the pattern <c>products/{product}</c>.</summary>
        /// <param name="productId">The <c>Product</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ProductName"/> constructed from the provided ids.</returns>
        public static ProductName FromProduct(string productId) =>
            new ProductName(ResourceNameType.Product, productId: gax::GaxPreconditions.CheckNotNullOrEmpty(productId, nameof(productId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ProductName"/> with pattern
        /// <c>products/{product}</c>.
        /// </summary>
        /// <param name="productId">The <c>Product</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ProductName"/> with pattern <c>products/{product}</c>.
        /// </returns>
        public static string Format(string productId) => FormatProduct(productId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ProductName"/> with pattern
        /// <c>products/{product}</c>.
        /// </summary>
        /// <param name="productId">The <c>Product</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ProductName"/> with pattern <c>products/{product}</c>.
        /// </returns>
        public static string FormatProduct(string productId) =>
            s_product.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(productId, nameof(productId)));

        /// <summary>Parses the given resource name string into a new <see cref="ProductName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>products/{product}</c></description></item></list>
        /// </remarks>
        /// <param name="productName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ProductName"/> if successful.</returns>
        public static ProductName Parse(string productName) => Parse(productName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ProductName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>products/{product}</c></description></item></list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="productName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ProductName"/> if successful.</returns>
        public static ProductName Parse(string productName, bool allowUnparsed) =>
            TryParse(productName, allowUnparsed, out ProductName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ProductName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>products/{product}</c></description></item></list>
        /// </remarks>
        /// <param name="productName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ProductName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string productName, out ProductName result) => TryParse(productName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ProductName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>products/{product}</c></description></item></list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="productName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ProductName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string productName, bool allowUnparsed, out ProductName result)
        {
            gax::GaxPreconditions.CheckNotNull(productName, nameof(productName));
            gax::TemplatedResourceName resourceName;
            if (s_product.TryParseName(productName, out resourceName))
            {
                result = FromProduct(resourceName[0]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(productName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ProductName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string productId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ProductId = productId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ProductName"/> class from the component parts of pattern
        /// <c>products/{product}</c>
        /// </summary>
        /// <param name="productId">The <c>Product</c> ID. Must not be <c>null</c> or empty.</param>
        public ProductName(string productId) : this(ResourceNameType.Product, productId: gax::GaxPreconditions.CheckNotNullOrEmpty(productId, nameof(productId)))
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
        /// The <c>Product</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProductId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.Product: return s_product.Expand(ProductId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ProductName);

        /// <inheritdoc/>
        public bool Equals(ProductName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ProductName a, ProductName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ProductName a, ProductName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Sku</c> resource.</summary>
    public sealed partial class SkuName : gax::IResourceName, sys::IEquatable<SkuName>
    {
        /// <summary>The possible contents of <see cref="SkuName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>products/{product}/skus/{sku}</c>.</summary>
            ProductSku = 1,
        }

        private static gax::PathTemplate s_productSku = new gax::PathTemplate("products/{product}/skus/{sku}");

        /// <summary>Creates a <see cref="SkuName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="SkuName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static SkuName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new SkuName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>Creates a <see cref="SkuName"/> with the pattern <c>products/{product}/skus/{sku}</c>.</summary>
        /// <param name="productId">The <c>Product</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="skuId">The <c>Sku</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="SkuName"/> constructed from the provided ids.</returns>
        public static SkuName FromProductSku(string productId, string skuId) =>
            new SkuName(ResourceNameType.ProductSku, productId: gax::GaxPreconditions.CheckNotNullOrEmpty(productId, nameof(productId)), skuId: gax::GaxPreconditions.CheckNotNullOrEmpty(skuId, nameof(skuId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SkuName"/> with pattern
        /// <c>products/{product}/skus/{sku}</c>.
        /// </summary>
        /// <param name="productId">The <c>Product</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="skuId">The <c>Sku</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SkuName"/> with pattern <c>products/{product}/skus/{sku}</c>.
        /// </returns>
        public static string Format(string productId, string skuId) => FormatProductSku(productId, skuId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SkuName"/> with pattern
        /// <c>products/{product}/skus/{sku}</c>.
        /// </summary>
        /// <param name="productId">The <c>Product</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="skuId">The <c>Sku</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SkuName"/> with pattern <c>products/{product}/skus/{sku}</c>.
        /// </returns>
        public static string FormatProductSku(string productId, string skuId) =>
            s_productSku.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(productId, nameof(productId)), gax::GaxPreconditions.CheckNotNullOrEmpty(skuId, nameof(skuId)));

        /// <summary>Parses the given resource name string into a new <see cref="SkuName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>products/{product}/skus/{sku}</c></description></item></list>
        /// </remarks>
        /// <param name="skuName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="SkuName"/> if successful.</returns>
        public static SkuName Parse(string skuName) => Parse(skuName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="SkuName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>products/{product}/skus/{sku}</c></description></item></list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="skuName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="SkuName"/> if successful.</returns>
        public static SkuName Parse(string skuName, bool allowUnparsed) =>
            TryParse(skuName, allowUnparsed, out SkuName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>Tries to parse the given resource name string into a new <see cref="SkuName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>products/{product}/skus/{sku}</c></description></item></list>
        /// </remarks>
        /// <param name="skuName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SkuName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string skuName, out SkuName result) => TryParse(skuName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SkuName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>products/{product}/skus/{sku}</c></description></item></list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="skuName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SkuName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string skuName, bool allowUnparsed, out SkuName result)
        {
            gax::GaxPreconditions.CheckNotNull(skuName, nameof(skuName));
            gax::TemplatedResourceName resourceName;
            if (s_productSku.TryParseName(skuName, out resourceName))
            {
                result = FromProductSku(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(skuName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private SkuName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string productId = null, string skuId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ProductId = productId;
            SkuId = skuId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="SkuName"/> class from the component parts of pattern
        /// <c>products/{product}/skus/{sku}</c>
        /// </summary>
        /// <param name="productId">The <c>Product</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="skuId">The <c>Sku</c> ID. Must not be <c>null</c> or empty.</param>
        public SkuName(string productId, string skuId) : this(ResourceNameType.ProductSku, productId: gax::GaxPreconditions.CheckNotNullOrEmpty(productId, nameof(productId)), skuId: gax::GaxPreconditions.CheckNotNullOrEmpty(skuId, nameof(skuId)))
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
        /// The <c>Product</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProductId { get; }

        /// <summary>
        /// The <c>Sku</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string SkuId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProductSku: return s_productSku.Expand(ProductId, SkuId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as SkuName);

        /// <inheritdoc/>
        public bool Equals(SkuName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(SkuName a, SkuName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(SkuName a, SkuName b) => !(a == b);
    }

    public partial class Product
    {
        /// <summary>
        /// <see cref="gccv::ProductName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::ProductName ProductName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::ProductName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class Sku
    {
        /// <summary>
        /// <see cref="gccv::SkuName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::SkuName SkuName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::SkuName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
