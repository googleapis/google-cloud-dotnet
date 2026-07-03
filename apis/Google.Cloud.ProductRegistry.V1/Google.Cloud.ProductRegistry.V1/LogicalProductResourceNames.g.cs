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
    /// <summary>Resource name for the <c>LogicalProduct</c> resource.</summary>
    public sealed partial class LogicalProductName : gax::IResourceName, sys::IEquatable<LogicalProductName>
    {
        /// <summary>The possible contents of <see cref="LogicalProductName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>logicalProducts/{logical_product}</c>.</summary>
            LogicalProduct = 1,
        }

        private static gax::PathTemplate s_logicalProduct = new gax::PathTemplate("logicalProducts/{logical_product}");

        /// <summary>Creates a <see cref="LogicalProductName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="LogicalProductName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static LogicalProductName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new LogicalProductName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="LogicalProductName"/> with the pattern <c>logicalProducts/{logical_product}</c>.
        /// </summary>
        /// <param name="logicalProductId">The <c>LogicalProduct</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="LogicalProductName"/> constructed from the provided ids.</returns>
        public static LogicalProductName FromLogicalProduct(string logicalProductId) =>
            new LogicalProductName(ResourceNameType.LogicalProduct, logicalProductId: gax::GaxPreconditions.CheckNotNullOrEmpty(logicalProductId, nameof(logicalProductId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="LogicalProductName"/> with pattern
        /// <c>logicalProducts/{logical_product}</c>.
        /// </summary>
        /// <param name="logicalProductId">The <c>LogicalProduct</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="LogicalProductName"/> with pattern
        /// <c>logicalProducts/{logical_product}</c>.
        /// </returns>
        public static string Format(string logicalProductId) => FormatLogicalProduct(logicalProductId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="LogicalProductName"/> with pattern
        /// <c>logicalProducts/{logical_product}</c>.
        /// </summary>
        /// <param name="logicalProductId">The <c>LogicalProduct</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="LogicalProductName"/> with pattern
        /// <c>logicalProducts/{logical_product}</c>.
        /// </returns>
        public static string FormatLogicalProduct(string logicalProductId) =>
            s_logicalProduct.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(logicalProductId, nameof(logicalProductId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="LogicalProductName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>logicalProducts/{logical_product}</c></description></item></list>
        /// </remarks>
        /// <param name="logicalProductName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="LogicalProductName"/> if successful.</returns>
        public static LogicalProductName Parse(string logicalProductName) => Parse(logicalProductName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="LogicalProductName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>logicalProducts/{logical_product}</c></description></item></list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="logicalProductName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="LogicalProductName"/> if successful.</returns>
        public static LogicalProductName Parse(string logicalProductName, bool allowUnparsed) =>
            TryParse(logicalProductName, allowUnparsed, out LogicalProductName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="LogicalProductName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>logicalProducts/{logical_product}</c></description></item></list>
        /// </remarks>
        /// <param name="logicalProductName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="LogicalProductName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string logicalProductName, out LogicalProductName result) =>
            TryParse(logicalProductName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="LogicalProductName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>logicalProducts/{logical_product}</c></description></item></list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="logicalProductName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="LogicalProductName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string logicalProductName, bool allowUnparsed, out LogicalProductName result)
        {
            gax::GaxPreconditions.CheckNotNull(logicalProductName, nameof(logicalProductName));
            gax::TemplatedResourceName resourceName;
            if (s_logicalProduct.TryParseName(logicalProductName, out resourceName))
            {
                result = FromLogicalProduct(resourceName[0]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(logicalProductName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private LogicalProductName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string logicalProductId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LogicalProductId = logicalProductId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="LogicalProductName"/> class from the component parts of pattern
        /// <c>logicalProducts/{logical_product}</c>
        /// </summary>
        /// <param name="logicalProductId">The <c>LogicalProduct</c> ID. Must not be <c>null</c> or empty.</param>
        public LogicalProductName(string logicalProductId) : this(ResourceNameType.LogicalProduct, logicalProductId: gax::GaxPreconditions.CheckNotNullOrEmpty(logicalProductId, nameof(logicalProductId)))
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
        /// The <c>LogicalProduct</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string LogicalProductId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.LogicalProduct: return s_logicalProduct.Expand(LogicalProductId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as LogicalProductName);

        /// <inheritdoc/>
        public bool Equals(LogicalProductName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(LogicalProductName a, LogicalProductName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(LogicalProductName a, LogicalProductName b) => !(a == b);
    }

    public partial class LogicalProduct
    {
        /// <summary>
        /// <see cref="gcpv::LogicalProductName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcpv::LogicalProductName LogicalProductName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcpv::LogicalProductName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="ProductSuiteName"/>-typed view over the <see cref="ProductSuite"/> resource name property.
        /// </summary>
        public ProductSuiteName ProductSuiteAsProductSuiteName
        {
            get => string.IsNullOrEmpty(ProductSuite) ? null : ProductSuiteName.Parse(ProductSuite, allowUnparsed: true);
            set => ProductSuite = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="LogicalProductVariantName"/>-typed view over the <see cref="Variants"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<LogicalProductVariantName> VariantsAsLogicalProductVariantNames
        {
            get => new gax::ResourceNameList<LogicalProductVariantName>(Variants, s => string.IsNullOrEmpty(s) ? null : LogicalProductVariantName.Parse(s, allowUnparsed: true));
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
