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
using gaav = Google.Ads.AdManager.V1;
using gax = Google.Api.Gax;
using sys = System;

namespace Google.Ads.AdManager.V1
{
    /// <summary>Resource name for the <c>AdReviewCenterAd</c> resource.</summary>
    public sealed partial class AdReviewCenterAdName : gax::IResourceName, sys::IEquatable<AdReviewCenterAdName>
    {
        /// <summary>The possible contents of <see cref="AdReviewCenterAdName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>networks/{network_code}/webProperties/{web_property_code}/adReviewCenterAds/{ad_review_center_ad}</c>
            /// .
            /// </summary>
            NetworkCodeWebPropertyCodeAdReviewCenterAd = 1,
        }

        private static gax::PathTemplate s_networkCodeWebPropertyCodeAdReviewCenterAd = new gax::PathTemplate("networks/{network_code}/webProperties/{web_property_code}/adReviewCenterAds/{ad_review_center_ad}");

        /// <summary>Creates a <see cref="AdReviewCenterAdName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="AdReviewCenterAdName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static AdReviewCenterAdName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new AdReviewCenterAdName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="AdReviewCenterAdName"/> with the pattern
        /// <c>networks/{network_code}/webProperties/{web_property_code}/adReviewCenterAds/{ad_review_center_ad}</c>.
        /// </summary>
        /// <param name="networkCodeId">The <c>NetworkCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="webPropertyCodeId">The <c>WebPropertyCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="adReviewCenterAdId">The <c>AdReviewCenterAd</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="AdReviewCenterAdName"/> constructed from the provided ids.</returns>
        public static AdReviewCenterAdName FromNetworkCodeWebPropertyCodeAdReviewCenterAd(string networkCodeId, string webPropertyCodeId, string adReviewCenterAdId) =>
            new AdReviewCenterAdName(ResourceNameType.NetworkCodeWebPropertyCodeAdReviewCenterAd, networkCodeId: gax::GaxPreconditions.CheckNotNullOrEmpty(networkCodeId, nameof(networkCodeId)), webPropertyCodeId: gax::GaxPreconditions.CheckNotNullOrEmpty(webPropertyCodeId, nameof(webPropertyCodeId)), adReviewCenterAdId: gax::GaxPreconditions.CheckNotNullOrEmpty(adReviewCenterAdId, nameof(adReviewCenterAdId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AdReviewCenterAdName"/> with pattern
        /// <c>networks/{network_code}/webProperties/{web_property_code}/adReviewCenterAds/{ad_review_center_ad}</c>.
        /// </summary>
        /// <param name="networkCodeId">The <c>NetworkCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="webPropertyCodeId">The <c>WebPropertyCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="adReviewCenterAdId">The <c>AdReviewCenterAd</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AdReviewCenterAdName"/> with pattern
        /// <c>networks/{network_code}/webProperties/{web_property_code}/adReviewCenterAds/{ad_review_center_ad}</c>.
        /// </returns>
        public static string Format(string networkCodeId, string webPropertyCodeId, string adReviewCenterAdId) =>
            FormatNetworkCodeWebPropertyCodeAdReviewCenterAd(networkCodeId, webPropertyCodeId, adReviewCenterAdId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AdReviewCenterAdName"/> with pattern
        /// <c>networks/{network_code}/webProperties/{web_property_code}/adReviewCenterAds/{ad_review_center_ad}</c>.
        /// </summary>
        /// <param name="networkCodeId">The <c>NetworkCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="webPropertyCodeId">The <c>WebPropertyCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="adReviewCenterAdId">The <c>AdReviewCenterAd</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AdReviewCenterAdName"/> with pattern
        /// <c>networks/{network_code}/webProperties/{web_property_code}/adReviewCenterAds/{ad_review_center_ad}</c>.
        /// </returns>
        public static string FormatNetworkCodeWebPropertyCodeAdReviewCenterAd(string networkCodeId, string webPropertyCodeId, string adReviewCenterAdId) =>
            s_networkCodeWebPropertyCodeAdReviewCenterAd.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(networkCodeId, nameof(networkCodeId)), gax::GaxPreconditions.CheckNotNullOrEmpty(webPropertyCodeId, nameof(webPropertyCodeId)), gax::GaxPreconditions.CheckNotNullOrEmpty(adReviewCenterAdId, nameof(adReviewCenterAdId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AdReviewCenterAdName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>networks/{network_code}/webProperties/{web_property_code}/adReviewCenterAds/{ad_review_center_ad}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="adReviewCenterAdName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AdReviewCenterAdName"/> if successful.</returns>
        public static AdReviewCenterAdName Parse(string adReviewCenterAdName) => Parse(adReviewCenterAdName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AdReviewCenterAdName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>networks/{network_code}/webProperties/{web_property_code}/adReviewCenterAds/{ad_review_center_ad}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="adReviewCenterAdName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="AdReviewCenterAdName"/> if successful.</returns>
        public static AdReviewCenterAdName Parse(string adReviewCenterAdName, bool allowUnparsed) =>
            TryParse(adReviewCenterAdName, allowUnparsed, out AdReviewCenterAdName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AdReviewCenterAdName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>networks/{network_code}/webProperties/{web_property_code}/adReviewCenterAds/{ad_review_center_ad}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="adReviewCenterAdName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AdReviewCenterAdName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string adReviewCenterAdName, out AdReviewCenterAdName result) =>
            TryParse(adReviewCenterAdName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AdReviewCenterAdName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>networks/{network_code}/webProperties/{web_property_code}/adReviewCenterAds/{ad_review_center_ad}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="adReviewCenterAdName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AdReviewCenterAdName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string adReviewCenterAdName, bool allowUnparsed, out AdReviewCenterAdName result)
        {
            gax::GaxPreconditions.CheckNotNull(adReviewCenterAdName, nameof(adReviewCenterAdName));
            gax::TemplatedResourceName resourceName;
            if (s_networkCodeWebPropertyCodeAdReviewCenterAd.TryParseName(adReviewCenterAdName, out resourceName))
            {
                result = FromNetworkCodeWebPropertyCodeAdReviewCenterAd(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(adReviewCenterAdName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private AdReviewCenterAdName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string adReviewCenterAdId = null, string networkCodeId = null, string webPropertyCodeId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AdReviewCenterAdId = adReviewCenterAdId;
            NetworkCodeId = networkCodeId;
            WebPropertyCodeId = webPropertyCodeId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="AdReviewCenterAdName"/> class from the component parts of pattern
        /// <c>networks/{network_code}/webProperties/{web_property_code}/adReviewCenterAds/{ad_review_center_ad}</c>
        /// </summary>
        /// <param name="networkCodeId">The <c>NetworkCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="webPropertyCodeId">The <c>WebPropertyCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="adReviewCenterAdId">The <c>AdReviewCenterAd</c> ID. Must not be <c>null</c> or empty.</param>
        public AdReviewCenterAdName(string networkCodeId, string webPropertyCodeId, string adReviewCenterAdId) : this(ResourceNameType.NetworkCodeWebPropertyCodeAdReviewCenterAd, networkCodeId: gax::GaxPreconditions.CheckNotNullOrEmpty(networkCodeId, nameof(networkCodeId)), webPropertyCodeId: gax::GaxPreconditions.CheckNotNullOrEmpty(webPropertyCodeId, nameof(webPropertyCodeId)), adReviewCenterAdId: gax::GaxPreconditions.CheckNotNullOrEmpty(adReviewCenterAdId, nameof(adReviewCenterAdId)))
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
        /// The <c>AdReviewCenterAd</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string AdReviewCenterAdId { get; }

        /// <summary>
        /// The <c>NetworkCode</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string NetworkCodeId { get; }

        /// <summary>
        /// The <c>WebPropertyCode</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string WebPropertyCodeId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.NetworkCodeWebPropertyCodeAdReviewCenterAd: return s_networkCodeWebPropertyCodeAdReviewCenterAd.Expand(NetworkCodeId, WebPropertyCodeId, AdReviewCenterAdId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as AdReviewCenterAdName);

        /// <inheritdoc/>
        public bool Equals(AdReviewCenterAdName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(AdReviewCenterAdName a, AdReviewCenterAdName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(AdReviewCenterAdName a, AdReviewCenterAdName b) => !(a == b);
    }

    public partial class AdReviewCenterAd
    {
        /// <summary>
        /// <see cref="gaav::AdReviewCenterAdName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gaav::AdReviewCenterAdName AdReviewCenterAdName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::AdReviewCenterAdName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
