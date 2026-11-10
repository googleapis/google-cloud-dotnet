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
using gaav = Google.Ads.AdManager.V1;
using gax = Google.Api.Gax;
using sys = System;

namespace Google.Ads.AdManager.V1
{
    /// <summary>Resource name for the <c>AdCategory</c> resource.</summary>
    public sealed partial class AdCategoryName : gax::IResourceName, sys::IEquatable<AdCategoryName>
    {
        /// <summary>The possible contents of <see cref="AdCategoryName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>networks/{network_code}/adCategories/{ad_category}</c>.
            /// </summary>
            NetworkCodeAdCategory = 1,
        }

        private static gax::PathTemplate s_networkCodeAdCategory = new gax::PathTemplate("networks/{network_code}/adCategories/{ad_category}");

        /// <summary>Creates a <see cref="AdCategoryName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="AdCategoryName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static AdCategoryName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new AdCategoryName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="AdCategoryName"/> with the pattern
        /// <c>networks/{network_code}/adCategories/{ad_category}</c>.
        /// </summary>
        /// <param name="networkCodeId">The <c>NetworkCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="adCategoryId">The <c>AdCategory</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="AdCategoryName"/> constructed from the provided ids.</returns>
        public static AdCategoryName FromNetworkCodeAdCategory(string networkCodeId, string adCategoryId) =>
            new AdCategoryName(ResourceNameType.NetworkCodeAdCategory, networkCodeId: gax::GaxPreconditions.CheckNotNullOrEmpty(networkCodeId, nameof(networkCodeId)), adCategoryId: gax::GaxPreconditions.CheckNotNullOrEmpty(adCategoryId, nameof(adCategoryId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AdCategoryName"/> with pattern
        /// <c>networks/{network_code}/adCategories/{ad_category}</c>.
        /// </summary>
        /// <param name="networkCodeId">The <c>NetworkCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="adCategoryId">The <c>AdCategory</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AdCategoryName"/> with pattern
        /// <c>networks/{network_code}/adCategories/{ad_category}</c>.
        /// </returns>
        public static string Format(string networkCodeId, string adCategoryId) =>
            FormatNetworkCodeAdCategory(networkCodeId, adCategoryId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AdCategoryName"/> with pattern
        /// <c>networks/{network_code}/adCategories/{ad_category}</c>.
        /// </summary>
        /// <param name="networkCodeId">The <c>NetworkCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="adCategoryId">The <c>AdCategory</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AdCategoryName"/> with pattern
        /// <c>networks/{network_code}/adCategories/{ad_category}</c>.
        /// </returns>
        public static string FormatNetworkCodeAdCategory(string networkCodeId, string adCategoryId) =>
            s_networkCodeAdCategory.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(networkCodeId, nameof(networkCodeId)), gax::GaxPreconditions.CheckNotNullOrEmpty(adCategoryId, nameof(adCategoryId)));

        /// <summary>Parses the given resource name string into a new <see cref="AdCategoryName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>networks/{network_code}/adCategories/{ad_category}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="adCategoryName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AdCategoryName"/> if successful.</returns>
        public static AdCategoryName Parse(string adCategoryName) => Parse(adCategoryName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AdCategoryName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>networks/{network_code}/adCategories/{ad_category}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="adCategoryName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="AdCategoryName"/> if successful.</returns>
        public static AdCategoryName Parse(string adCategoryName, bool allowUnparsed) =>
            TryParse(adCategoryName, allowUnparsed, out AdCategoryName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AdCategoryName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>networks/{network_code}/adCategories/{ad_category}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="adCategoryName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AdCategoryName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string adCategoryName, out AdCategoryName result) =>
            TryParse(adCategoryName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AdCategoryName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>networks/{network_code}/adCategories/{ad_category}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="adCategoryName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AdCategoryName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string adCategoryName, bool allowUnparsed, out AdCategoryName result)
        {
            gax::GaxPreconditions.CheckNotNull(adCategoryName, nameof(adCategoryName));
            gax::TemplatedResourceName resourceName;
            if (s_networkCodeAdCategory.TryParseName(adCategoryName, out resourceName))
            {
                result = FromNetworkCodeAdCategory(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(adCategoryName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private AdCategoryName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string adCategoryId = null, string networkCodeId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AdCategoryId = adCategoryId;
            NetworkCodeId = networkCodeId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="AdCategoryName"/> class from the component parts of pattern
        /// <c>networks/{network_code}/adCategories/{ad_category}</c>
        /// </summary>
        /// <param name="networkCodeId">The <c>NetworkCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="adCategoryId">The <c>AdCategory</c> ID. Must not be <c>null</c> or empty.</param>
        public AdCategoryName(string networkCodeId, string adCategoryId) : this(ResourceNameType.NetworkCodeAdCategory, networkCodeId: gax::GaxPreconditions.CheckNotNullOrEmpty(networkCodeId, nameof(networkCodeId)), adCategoryId: gax::GaxPreconditions.CheckNotNullOrEmpty(adCategoryId, nameof(adCategoryId)))
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
        /// The <c>AdCategory</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string AdCategoryId { get; }

        /// <summary>
        /// The <c>NetworkCode</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string NetworkCodeId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.NetworkCodeAdCategory: return s_networkCodeAdCategory.Expand(NetworkCodeId, AdCategoryId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as AdCategoryName);

        /// <inheritdoc/>
        public bool Equals(AdCategoryName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(AdCategoryName a, AdCategoryName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(AdCategoryName a, AdCategoryName b) => !(a == b);
    }

    public partial class AdCategory
    {
        /// <summary>
        /// <see cref="gaav::AdCategoryName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gaav::AdCategoryName AdCategoryName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::AdCategoryName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
