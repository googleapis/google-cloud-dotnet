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
using gax = Google.Api.Gax;
using gcpv = Google.Cloud.ProductRegistry.V1;
using sys = System;

namespace Google.Cloud.ProductRegistry.V1
{
    /// <summary>Resource name for the <c>ProductSuite</c> resource.</summary>
    public sealed partial class ProductSuiteName : gax::IResourceName, sys::IEquatable<ProductSuiteName>
    {
        /// <summary>The possible contents of <see cref="ProductSuiteName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>productSuites/{product_suite}</c>.</summary>
            ProductSuite = 1,
        }

        private static gax::PathTemplate s_productSuite = new gax::PathTemplate("productSuites/{product_suite}");

        /// <summary>Creates a <see cref="ProductSuiteName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ProductSuiteName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ProductSuiteName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ProductSuiteName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ProductSuiteName"/> with the pattern <c>productSuites/{product_suite}</c>.
        /// </summary>
        /// <param name="productSuiteId">The <c>ProductSuite</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ProductSuiteName"/> constructed from the provided ids.</returns>
        public static ProductSuiteName FromProductSuite(string productSuiteId) =>
            new ProductSuiteName(ResourceNameType.ProductSuite, productSuiteId: gax::GaxPreconditions.CheckNotNullOrEmpty(productSuiteId, nameof(productSuiteId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ProductSuiteName"/> with pattern
        /// <c>productSuites/{product_suite}</c>.
        /// </summary>
        /// <param name="productSuiteId">The <c>ProductSuite</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ProductSuiteName"/> with pattern
        /// <c>productSuites/{product_suite}</c>.
        /// </returns>
        public static string Format(string productSuiteId) => FormatProductSuite(productSuiteId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ProductSuiteName"/> with pattern
        /// <c>productSuites/{product_suite}</c>.
        /// </summary>
        /// <param name="productSuiteId">The <c>ProductSuite</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ProductSuiteName"/> with pattern
        /// <c>productSuites/{product_suite}</c>.
        /// </returns>
        public static string FormatProductSuite(string productSuiteId) =>
            s_productSuite.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(productSuiteId, nameof(productSuiteId)));

        /// <summary>Parses the given resource name string into a new <see cref="ProductSuiteName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>productSuites/{product_suite}</c></description></item></list>
        /// </remarks>
        /// <param name="productSuiteName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ProductSuiteName"/> if successful.</returns>
        public static ProductSuiteName Parse(string productSuiteName) => Parse(productSuiteName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ProductSuiteName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>productSuites/{product_suite}</c></description></item></list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="productSuiteName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ProductSuiteName"/> if successful.</returns>
        public static ProductSuiteName Parse(string productSuiteName, bool allowUnparsed) =>
            TryParse(productSuiteName, allowUnparsed, out ProductSuiteName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ProductSuiteName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>productSuites/{product_suite}</c></description></item></list>
        /// </remarks>
        /// <param name="productSuiteName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ProductSuiteName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string productSuiteName, out ProductSuiteName result) =>
            TryParse(productSuiteName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ProductSuiteName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>productSuites/{product_suite}</c></description></item></list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="productSuiteName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ProductSuiteName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string productSuiteName, bool allowUnparsed, out ProductSuiteName result)
        {
            gax::GaxPreconditions.CheckNotNull(productSuiteName, nameof(productSuiteName));
            gax::TemplatedResourceName resourceName;
            if (s_productSuite.TryParseName(productSuiteName, out resourceName))
            {
                result = FromProductSuite(resourceName[0]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(productSuiteName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ProductSuiteName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string productSuiteId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ProductSuiteId = productSuiteId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ProductSuiteName"/> class from the component parts of pattern
        /// <c>productSuites/{product_suite}</c>
        /// </summary>
        /// <param name="productSuiteId">The <c>ProductSuite</c> ID. Must not be <c>null</c> or empty.</param>
        public ProductSuiteName(string productSuiteId) : this(ResourceNameType.ProductSuite, productSuiteId: gax::GaxPreconditions.CheckNotNullOrEmpty(productSuiteId, nameof(productSuiteId)))
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
        /// The <c>ProductSuite</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string ProductSuiteId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProductSuite: return s_productSuite.Expand(ProductSuiteId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ProductSuiteName);

        /// <inheritdoc/>
        public bool Equals(ProductSuiteName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ProductSuiteName a, ProductSuiteName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ProductSuiteName a, ProductSuiteName b) => !(a == b);
    }

    public partial class ProductSuite
    {
        /// <summary>
        /// <see cref="gcpv::ProductSuiteName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcpv::ProductSuiteName ProductSuiteName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcpv::ProductSuiteName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="LogicalProductName"/>-typed view over the <see cref="LogicalProducts"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<LogicalProductName> LogicalProductsAsLogicalProductNames
        {
            get => new gax::ResourceNameList<LogicalProductName>(LogicalProducts, s => string.IsNullOrEmpty(s) ? null : LogicalProductName.Parse(s, allowUnparsed: true));
        }

        /// <summary>
        /// <see cref="gax::IResourceName"/>-typed view over the <see cref="Replacement"/> resource name property.
        /// </summary>
        public gax::IResourceName ReplacementAsResourceName
        {
            get => string.IsNullOrEmpty(Replacement) ? null : gax::UnparsedResourceName.Parse(Replacement);
            set => Replacement = value?.ToString() ?? "";
        }
    }
}
