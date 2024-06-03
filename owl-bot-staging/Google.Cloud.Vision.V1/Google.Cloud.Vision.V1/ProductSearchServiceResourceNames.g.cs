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
using gagr = Google.Api.Gax.ResourceNames;
using gax = Google.Api.Gax;
using gcvv = Google.Cloud.Vision.V1;
using sys = System;

namespace Google.Cloud.Vision.V1
{
    /// <summary>Resource name for the <c>Product</c> resource.</summary>
    public sealed partial class ProductName : gax::IResourceName, sys::IEquatable<ProductName>
    {
        /// <summary>The possible contents of <see cref="ProductName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/products/{product}</c>.
            /// </summary>
            ProjectLocationProduct = 1,
        }

        private static gax::PathTemplate s_projectLocationProduct = new gax::PathTemplate("projects/{project}/locations/{location}/products/{product}");

        /// <summary>Creates a <see cref="ProductName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ProductName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ProductName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ProductName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ProductName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/products/{product}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="productId">The <c>Product</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ProductName"/> constructed from the provided ids.</returns>
        public static ProductName FromProjectLocationProduct(string projectId, string locationId, string productId) =>
            new ProductName(ResourceNameType.ProjectLocationProduct, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), productId: gax::GaxPreconditions.CheckNotNullOrEmpty(productId, nameof(productId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ProductName"/> with pattern
        /// <c>projects/{project}/locations/{location}/products/{product}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="productId">The <c>Product</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ProductName"/> with pattern
        /// <c>projects/{project}/locations/{location}/products/{product}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string productId) =>
            FormatProjectLocationProduct(projectId, locationId, productId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ProductName"/> with pattern
        /// <c>projects/{project}/locations/{location}/products/{product}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="productId">The <c>Product</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ProductName"/> with pattern
        /// <c>projects/{project}/locations/{location}/products/{product}</c>.
        /// </returns>
        public static string FormatProjectLocationProduct(string projectId, string locationId, string productId) =>
            s_projectLocationProduct.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(productId, nameof(productId)));

        /// <summary>Parses the given resource name string into a new <see cref="ProductName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/products/{product}</c></description></item>
        /// </list>
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
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/products/{product}</c></description></item>
        /// </list>
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
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/products/{product}</c></description></item>
        /// </list>
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
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/products/{product}</c></description></item>
        /// </list>
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
            if (s_projectLocationProduct.TryParseName(productName, out resourceName))
            {
                result = FromProjectLocationProduct(resourceName[0], resourceName[1], resourceName[2]);
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

        private ProductName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string productId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProductId = productId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ProductName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/products/{product}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="productId">The <c>Product</c> ID. Must not be <c>null</c> or empty.</param>
        public ProductName(string projectId, string locationId, string productId) : this(ResourceNameType.ProjectLocationProduct, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), productId: gax::GaxPreconditions.CheckNotNullOrEmpty(productId, nameof(productId)))
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
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Product</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProductId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationProduct: return s_projectLocationProduct.Expand(ProjectId, LocationId, ProductId);
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

    /// <summary>Resource name for the <c>ProductSet</c> resource.</summary>
    public sealed partial class ProductSetName : gax::IResourceName, sys::IEquatable<ProductSetName>
    {
        /// <summary>The possible contents of <see cref="ProductSetName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/productSets/{product_set}</c>.
            /// </summary>
            ProjectLocationProductSet = 1,
        }

        private static gax::PathTemplate s_projectLocationProductSet = new gax::PathTemplate("projects/{project}/locations/{location}/productSets/{product_set}");

        /// <summary>Creates a <see cref="ProductSetName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ProductSetName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ProductSetName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ProductSetName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ProductSetName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/productSets/{product_set}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="productSetId">The <c>ProductSet</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ProductSetName"/> constructed from the provided ids.</returns>
        public static ProductSetName FromProjectLocationProductSet(string projectId, string locationId, string productSetId) =>
            new ProductSetName(ResourceNameType.ProjectLocationProductSet, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), productSetId: gax::GaxPreconditions.CheckNotNullOrEmpty(productSetId, nameof(productSetId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ProductSetName"/> with pattern
        /// <c>projects/{project}/locations/{location}/productSets/{product_set}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="productSetId">The <c>ProductSet</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ProductSetName"/> with pattern
        /// <c>projects/{project}/locations/{location}/productSets/{product_set}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string productSetId) =>
            FormatProjectLocationProductSet(projectId, locationId, productSetId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ProductSetName"/> with pattern
        /// <c>projects/{project}/locations/{location}/productSets/{product_set}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="productSetId">The <c>ProductSet</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ProductSetName"/> with pattern
        /// <c>projects/{project}/locations/{location}/productSets/{product_set}</c>.
        /// </returns>
        public static string FormatProjectLocationProductSet(string projectId, string locationId, string productSetId) =>
            s_projectLocationProductSet.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(productSetId, nameof(productSetId)));

        /// <summary>Parses the given resource name string into a new <see cref="ProductSetName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/productSets/{product_set}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="productSetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ProductSetName"/> if successful.</returns>
        public static ProductSetName Parse(string productSetName) => Parse(productSetName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ProductSetName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/productSets/{product_set}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="productSetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ProductSetName"/> if successful.</returns>
        public static ProductSetName Parse(string productSetName, bool allowUnparsed) =>
            TryParse(productSetName, allowUnparsed, out ProductSetName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ProductSetName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/productSets/{product_set}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="productSetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ProductSetName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string productSetName, out ProductSetName result) =>
            TryParse(productSetName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ProductSetName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/productSets/{product_set}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="productSetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ProductSetName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string productSetName, bool allowUnparsed, out ProductSetName result)
        {
            gax::GaxPreconditions.CheckNotNull(productSetName, nameof(productSetName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationProductSet.TryParseName(productSetName, out resourceName))
            {
                result = FromProjectLocationProductSet(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(productSetName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ProductSetName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string productSetId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProductSetId = productSetId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ProductSetName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/productSets/{product_set}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="productSetId">The <c>ProductSet</c> ID. Must not be <c>null</c> or empty.</param>
        public ProductSetName(string projectId, string locationId, string productSetId) : this(ResourceNameType.ProjectLocationProductSet, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), productSetId: gax::GaxPreconditions.CheckNotNullOrEmpty(productSetId, nameof(productSetId)))
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
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>ProductSet</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProductSetId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationProductSet: return s_projectLocationProductSet.Expand(ProjectId, LocationId, ProductSetId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ProductSetName);

        /// <inheritdoc/>
        public bool Equals(ProductSetName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ProductSetName a, ProductSetName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ProductSetName a, ProductSetName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>ReferenceImage</c> resource.</summary>
    public sealed partial class ReferenceImageName : gax::IResourceName, sys::IEquatable<ReferenceImageName>
    {
        /// <summary>The possible contents of <see cref="ReferenceImageName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/products/{product}/referenceImages/{reference_image}</c>.
            /// </summary>
            ProjectLocationProductReferenceImage = 1,
        }

        private static gax::PathTemplate s_projectLocationProductReferenceImage = new gax::PathTemplate("projects/{project}/locations/{location}/products/{product}/referenceImages/{reference_image}");

        /// <summary>Creates a <see cref="ReferenceImageName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ReferenceImageName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ReferenceImageName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ReferenceImageName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ReferenceImageName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/products/{product}/referenceImages/{reference_image}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="productId">The <c>Product</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="referenceImageId">The <c>ReferenceImage</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ReferenceImageName"/> constructed from the provided ids.</returns>
        public static ReferenceImageName FromProjectLocationProductReferenceImage(string projectId, string locationId, string productId, string referenceImageId) =>
            new ReferenceImageName(ResourceNameType.ProjectLocationProductReferenceImage, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), productId: gax::GaxPreconditions.CheckNotNullOrEmpty(productId, nameof(productId)), referenceImageId: gax::GaxPreconditions.CheckNotNullOrEmpty(referenceImageId, nameof(referenceImageId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ReferenceImageName"/> with pattern
        /// <c>projects/{project}/locations/{location}/products/{product}/referenceImages/{reference_image}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="productId">The <c>Product</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="referenceImageId">The <c>ReferenceImage</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ReferenceImageName"/> with pattern
        /// <c>projects/{project}/locations/{location}/products/{product}/referenceImages/{reference_image}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string productId, string referenceImageId) =>
            FormatProjectLocationProductReferenceImage(projectId, locationId, productId, referenceImageId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ReferenceImageName"/> with pattern
        /// <c>projects/{project}/locations/{location}/products/{product}/referenceImages/{reference_image}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="productId">The <c>Product</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="referenceImageId">The <c>ReferenceImage</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ReferenceImageName"/> with pattern
        /// <c>projects/{project}/locations/{location}/products/{product}/referenceImages/{reference_image}</c>.
        /// </returns>
        public static string FormatProjectLocationProductReferenceImage(string projectId, string locationId, string productId, string referenceImageId) =>
            s_projectLocationProductReferenceImage.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(productId, nameof(productId)), gax::GaxPreconditions.CheckNotNullOrEmpty(referenceImageId, nameof(referenceImageId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ReferenceImageName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/products/{product}/referenceImages/{reference_image}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="referenceImageName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ReferenceImageName"/> if successful.</returns>
        public static ReferenceImageName Parse(string referenceImageName) => Parse(referenceImageName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ReferenceImageName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/products/{product}/referenceImages/{reference_image}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="referenceImageName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ReferenceImageName"/> if successful.</returns>
        public static ReferenceImageName Parse(string referenceImageName, bool allowUnparsed) =>
            TryParse(referenceImageName, allowUnparsed, out ReferenceImageName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ReferenceImageName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/products/{product}/referenceImages/{reference_image}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="referenceImageName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ReferenceImageName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string referenceImageName, out ReferenceImageName result) =>
            TryParse(referenceImageName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ReferenceImageName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/products/{product}/referenceImages/{reference_image}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="referenceImageName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ReferenceImageName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string referenceImageName, bool allowUnparsed, out ReferenceImageName result)
        {
            gax::GaxPreconditions.CheckNotNull(referenceImageName, nameof(referenceImageName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationProductReferenceImage.TryParseName(referenceImageName, out resourceName))
            {
                result = FromProjectLocationProductReferenceImage(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(referenceImageName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ReferenceImageName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string productId = null, string projectId = null, string referenceImageId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProductId = productId;
            ProjectId = projectId;
            ReferenceImageId = referenceImageId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ReferenceImageName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/products/{product}/referenceImages/{reference_image}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="productId">The <c>Product</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="referenceImageId">The <c>ReferenceImage</c> ID. Must not be <c>null</c> or empty.</param>
        public ReferenceImageName(string projectId, string locationId, string productId, string referenceImageId) : this(ResourceNameType.ProjectLocationProductReferenceImage, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), productId: gax::GaxPreconditions.CheckNotNullOrEmpty(productId, nameof(productId)), referenceImageId: gax::GaxPreconditions.CheckNotNullOrEmpty(referenceImageId, nameof(referenceImageId)))
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
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Product</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProductId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>ReferenceImage</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string ReferenceImageId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationProductReferenceImage: return s_projectLocationProductReferenceImage.Expand(ProjectId, LocationId, ProductId, ReferenceImageId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ReferenceImageName);

        /// <inheritdoc/>
        public bool Equals(ReferenceImageName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ReferenceImageName a, ReferenceImageName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ReferenceImageName a, ReferenceImageName b) => !(a == b);
    }

    public partial class Product
    {
        /// <summary>
        /// <see cref="gcvv::ProductName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::ProductName ProductName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::ProductName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ProductSet
    {
        /// <summary>
        /// <see cref="gcvv::ProductSetName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::ProductSetName ProductSetName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::ProductSetName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ReferenceImage
    {
        /// <summary>
        /// <see cref="gcvv::ReferenceImageName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::ReferenceImageName ReferenceImageName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::ReferenceImageName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateProductRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class ListProductsRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetProductRequest
    {
        /// <summary>
        /// <see cref="gcvv::ProductName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::ProductName ProductName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::ProductName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteProductRequest
    {
        /// <summary>
        /// <see cref="gcvv::ProductName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::ProductName ProductName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::ProductName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateProductSetRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class ListProductSetsRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetProductSetRequest
    {
        /// <summary>
        /// <see cref="gcvv::ProductSetName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::ProductSetName ProductSetName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::ProductSetName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteProductSetRequest
    {
        /// <summary>
        /// <see cref="gcvv::ProductSetName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::ProductSetName ProductSetName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::ProductSetName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateReferenceImageRequest
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

    public partial class ListReferenceImagesRequest
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

    public partial class GetReferenceImageRequest
    {
        /// <summary>
        /// <see cref="gcvv::ReferenceImageName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::ReferenceImageName ReferenceImageName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::ReferenceImageName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteReferenceImageRequest
    {
        /// <summary>
        /// <see cref="gcvv::ReferenceImageName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::ReferenceImageName ReferenceImageName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::ReferenceImageName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class AddProductToProductSetRequest
    {
        /// <summary>
        /// <see cref="gcvv::ProductSetName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::ProductSetName ProductSetName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::ProductSetName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="ProductName"/>-typed view over the <see cref="Product"/> resource name property.
        /// </summary>
        public ProductName ProductAsProductName
        {
            get => string.IsNullOrEmpty(Product) ? null : ProductName.Parse(Product, allowUnparsed: true);
            set => Product = value?.ToString() ?? "";
        }
    }

    public partial class RemoveProductFromProductSetRequest
    {
        /// <summary>
        /// <see cref="gcvv::ProductSetName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::ProductSetName ProductSetName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::ProductSetName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="ProductName"/>-typed view over the <see cref="Product"/> resource name property.
        /// </summary>
        public ProductName ProductAsProductName
        {
            get => string.IsNullOrEmpty(Product) ? null : ProductName.Parse(Product, allowUnparsed: true);
            set => Product = value?.ToString() ?? "";
        }
    }

    public partial class ListProductsInProductSetRequest
    {
        /// <summary>
        /// <see cref="gcvv::ProductSetName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::ProductSetName ProductSetName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::ProductSetName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ImportProductSetsRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class PurgeProductsRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }
}
