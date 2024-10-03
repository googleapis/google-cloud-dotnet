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
using gaav = Google.Ads.AdManager.V1;
using gax = Google.Api.Gax;
using sys = System;

namespace Google.Ads.AdManager.V1
{
    /// <summary>Resource name for the <c>TaxonomyCategory</c> resource.</summary>
    public sealed partial class TaxonomyCategoryName : gax::IResourceName, sys::IEquatable<TaxonomyCategoryName>
    {
        /// <summary>The possible contents of <see cref="TaxonomyCategoryName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>networks/{network_code}/taxonomyCategories/{taxonomy_category}</c>.
            /// </summary>
            NetworkCodeTaxonomyCategory = 1,
        }

        private static gax::PathTemplate s_networkCodeTaxonomyCategory = new gax::PathTemplate("networks/{network_code}/taxonomyCategories/{taxonomy_category}");

        /// <summary>Creates a <see cref="TaxonomyCategoryName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="TaxonomyCategoryName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static TaxonomyCategoryName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new TaxonomyCategoryName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="TaxonomyCategoryName"/> with the pattern
        /// <c>networks/{network_code}/taxonomyCategories/{taxonomy_category}</c>.
        /// </summary>
        /// <param name="networkCodeId">The <c>NetworkCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="taxonomyCategoryId">The <c>TaxonomyCategory</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="TaxonomyCategoryName"/> constructed from the provided ids.</returns>
        public static TaxonomyCategoryName FromNetworkCodeTaxonomyCategory(string networkCodeId, string taxonomyCategoryId) =>
            new TaxonomyCategoryName(ResourceNameType.NetworkCodeTaxonomyCategory, networkCodeId: gax::GaxPreconditions.CheckNotNullOrEmpty(networkCodeId, nameof(networkCodeId)), taxonomyCategoryId: gax::GaxPreconditions.CheckNotNullOrEmpty(taxonomyCategoryId, nameof(taxonomyCategoryId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TaxonomyCategoryName"/> with pattern
        /// <c>networks/{network_code}/taxonomyCategories/{taxonomy_category}</c>.
        /// </summary>
        /// <param name="networkCodeId">The <c>NetworkCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="taxonomyCategoryId">The <c>TaxonomyCategory</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="TaxonomyCategoryName"/> with pattern
        /// <c>networks/{network_code}/taxonomyCategories/{taxonomy_category}</c>.
        /// </returns>
        public static string Format(string networkCodeId, string taxonomyCategoryId) =>
            FormatNetworkCodeTaxonomyCategory(networkCodeId, taxonomyCategoryId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TaxonomyCategoryName"/> with pattern
        /// <c>networks/{network_code}/taxonomyCategories/{taxonomy_category}</c>.
        /// </summary>
        /// <param name="networkCodeId">The <c>NetworkCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="taxonomyCategoryId">The <c>TaxonomyCategory</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="TaxonomyCategoryName"/> with pattern
        /// <c>networks/{network_code}/taxonomyCategories/{taxonomy_category}</c>.
        /// </returns>
        public static string FormatNetworkCodeTaxonomyCategory(string networkCodeId, string taxonomyCategoryId) =>
            s_networkCodeTaxonomyCategory.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(networkCodeId, nameof(networkCodeId)), gax::GaxPreconditions.CheckNotNullOrEmpty(taxonomyCategoryId, nameof(taxonomyCategoryId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="TaxonomyCategoryName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>networks/{network_code}/taxonomyCategories/{taxonomy_category}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="taxonomyCategoryName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="TaxonomyCategoryName"/> if successful.</returns>
        public static TaxonomyCategoryName Parse(string taxonomyCategoryName) => Parse(taxonomyCategoryName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="TaxonomyCategoryName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>networks/{network_code}/taxonomyCategories/{taxonomy_category}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="taxonomyCategoryName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="TaxonomyCategoryName"/> if successful.</returns>
        public static TaxonomyCategoryName Parse(string taxonomyCategoryName, bool allowUnparsed) =>
            TryParse(taxonomyCategoryName, allowUnparsed, out TaxonomyCategoryName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="TaxonomyCategoryName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>networks/{network_code}/taxonomyCategories/{taxonomy_category}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="taxonomyCategoryName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="TaxonomyCategoryName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string taxonomyCategoryName, out TaxonomyCategoryName result) =>
            TryParse(taxonomyCategoryName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="TaxonomyCategoryName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>networks/{network_code}/taxonomyCategories/{taxonomy_category}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="taxonomyCategoryName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="TaxonomyCategoryName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string taxonomyCategoryName, bool allowUnparsed, out TaxonomyCategoryName result)
        {
            gax::GaxPreconditions.CheckNotNull(taxonomyCategoryName, nameof(taxonomyCategoryName));
            gax::TemplatedResourceName resourceName;
            if (s_networkCodeTaxonomyCategory.TryParseName(taxonomyCategoryName, out resourceName))
            {
                result = FromNetworkCodeTaxonomyCategory(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(taxonomyCategoryName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private TaxonomyCategoryName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string networkCodeId = null, string taxonomyCategoryId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            NetworkCodeId = networkCodeId;
            TaxonomyCategoryId = taxonomyCategoryId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="TaxonomyCategoryName"/> class from the component parts of pattern
        /// <c>networks/{network_code}/taxonomyCategories/{taxonomy_category}</c>
        /// </summary>
        /// <param name="networkCodeId">The <c>NetworkCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="taxonomyCategoryId">The <c>TaxonomyCategory</c> ID. Must not be <c>null</c> or empty.</param>
        public TaxonomyCategoryName(string networkCodeId, string taxonomyCategoryId) : this(ResourceNameType.NetworkCodeTaxonomyCategory, networkCodeId: gax::GaxPreconditions.CheckNotNullOrEmpty(networkCodeId, nameof(networkCodeId)), taxonomyCategoryId: gax::GaxPreconditions.CheckNotNullOrEmpty(taxonomyCategoryId, nameof(taxonomyCategoryId)))
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
        /// The <c>NetworkCode</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string NetworkCodeId { get; }

        /// <summary>
        /// The <c>TaxonomyCategory</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string TaxonomyCategoryId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.NetworkCodeTaxonomyCategory: return s_networkCodeTaxonomyCategory.Expand(NetworkCodeId, TaxonomyCategoryId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as TaxonomyCategoryName);

        /// <inheritdoc/>
        public bool Equals(TaxonomyCategoryName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(TaxonomyCategoryName a, TaxonomyCategoryName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(TaxonomyCategoryName a, TaxonomyCategoryName b) => !(a == b);
    }

    public partial class TaxonomyCategory
    {
        /// <summary>
        /// <see cref="gaav::TaxonomyCategoryName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gaav::TaxonomyCategoryName TaxonomyCategoryName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::TaxonomyCategoryName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
