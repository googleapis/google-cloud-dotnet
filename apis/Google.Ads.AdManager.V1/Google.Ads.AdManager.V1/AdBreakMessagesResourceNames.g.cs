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
    /// <summary>Resource name for the <c>AdBreak</c> resource.</summary>
    public sealed partial class AdBreakName : gax::IResourceName, sys::IEquatable<AdBreakName>
    {
        /// <summary>The possible contents of <see cref="AdBreakName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>networks/{network_code}/liveStreamEventsByAssetKey/{asset_key}/adBreaks/{ad_break}</c>.
            /// </summary>
            NetworkCodeAssetKeyAdBreak = 1,
        }

        private static gax::PathTemplate s_networkCodeAssetKeyAdBreak = new gax::PathTemplate("networks/{network_code}/liveStreamEventsByAssetKey/{asset_key}/adBreaks/{ad_break}");

        /// <summary>Creates a <see cref="AdBreakName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="AdBreakName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static AdBreakName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new AdBreakName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="AdBreakName"/> with the pattern
        /// <c>networks/{network_code}/liveStreamEventsByAssetKey/{asset_key}/adBreaks/{ad_break}</c>.
        /// </summary>
        /// <param name="networkCodeId">The <c>NetworkCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="assetKeyId">The <c>AssetKey</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="adBreakId">The <c>AdBreak</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="AdBreakName"/> constructed from the provided ids.</returns>
        public static AdBreakName FromNetworkCodeAssetKeyAdBreak(string networkCodeId, string assetKeyId, string adBreakId) =>
            new AdBreakName(ResourceNameType.NetworkCodeAssetKeyAdBreak, networkCodeId: gax::GaxPreconditions.CheckNotNullOrEmpty(networkCodeId, nameof(networkCodeId)), assetKeyId: gax::GaxPreconditions.CheckNotNullOrEmpty(assetKeyId, nameof(assetKeyId)), adBreakId: gax::GaxPreconditions.CheckNotNullOrEmpty(adBreakId, nameof(adBreakId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AdBreakName"/> with pattern
        /// <c>networks/{network_code}/liveStreamEventsByAssetKey/{asset_key}/adBreaks/{ad_break}</c>.
        /// </summary>
        /// <param name="networkCodeId">The <c>NetworkCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="assetKeyId">The <c>AssetKey</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="adBreakId">The <c>AdBreak</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AdBreakName"/> with pattern
        /// <c>networks/{network_code}/liveStreamEventsByAssetKey/{asset_key}/adBreaks/{ad_break}</c>.
        /// </returns>
        public static string Format(string networkCodeId, string assetKeyId, string adBreakId) =>
            FormatNetworkCodeAssetKeyAdBreak(networkCodeId, assetKeyId, adBreakId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AdBreakName"/> with pattern
        /// <c>networks/{network_code}/liveStreamEventsByAssetKey/{asset_key}/adBreaks/{ad_break}</c>.
        /// </summary>
        /// <param name="networkCodeId">The <c>NetworkCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="assetKeyId">The <c>AssetKey</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="adBreakId">The <c>AdBreak</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AdBreakName"/> with pattern
        /// <c>networks/{network_code}/liveStreamEventsByAssetKey/{asset_key}/adBreaks/{ad_break}</c>.
        /// </returns>
        public static string FormatNetworkCodeAssetKeyAdBreak(string networkCodeId, string assetKeyId, string adBreakId) =>
            s_networkCodeAssetKeyAdBreak.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(networkCodeId, nameof(networkCodeId)), gax::GaxPreconditions.CheckNotNullOrEmpty(assetKeyId, nameof(assetKeyId)), gax::GaxPreconditions.CheckNotNullOrEmpty(adBreakId, nameof(adBreakId)));

        /// <summary>Parses the given resource name string into a new <see cref="AdBreakName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>networks/{network_code}/liveStreamEventsByAssetKey/{asset_key}/adBreaks/{ad_break}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="adBreakName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AdBreakName"/> if successful.</returns>
        public static AdBreakName Parse(string adBreakName) => Parse(adBreakName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AdBreakName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>networks/{network_code}/liveStreamEventsByAssetKey/{asset_key}/adBreaks/{ad_break}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="adBreakName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="AdBreakName"/> if successful.</returns>
        public static AdBreakName Parse(string adBreakName, bool allowUnparsed) =>
            TryParse(adBreakName, allowUnparsed, out AdBreakName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AdBreakName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>networks/{network_code}/liveStreamEventsByAssetKey/{asset_key}/adBreaks/{ad_break}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="adBreakName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AdBreakName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string adBreakName, out AdBreakName result) => TryParse(adBreakName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AdBreakName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>networks/{network_code}/liveStreamEventsByAssetKey/{asset_key}/adBreaks/{ad_break}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="adBreakName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AdBreakName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string adBreakName, bool allowUnparsed, out AdBreakName result)
        {
            gax::GaxPreconditions.CheckNotNull(adBreakName, nameof(adBreakName));
            gax::TemplatedResourceName resourceName;
            if (s_networkCodeAssetKeyAdBreak.TryParseName(adBreakName, out resourceName))
            {
                result = FromNetworkCodeAssetKeyAdBreak(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(adBreakName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private AdBreakName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string adBreakId = null, string assetKeyId = null, string networkCodeId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AdBreakId = adBreakId;
            AssetKeyId = assetKeyId;
            NetworkCodeId = networkCodeId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="AdBreakName"/> class from the component parts of pattern
        /// <c>networks/{network_code}/liveStreamEventsByAssetKey/{asset_key}/adBreaks/{ad_break}</c>
        /// </summary>
        /// <param name="networkCodeId">The <c>NetworkCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="assetKeyId">The <c>AssetKey</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="adBreakId">The <c>AdBreak</c> ID. Must not be <c>null</c> or empty.</param>
        public AdBreakName(string networkCodeId, string assetKeyId, string adBreakId) : this(ResourceNameType.NetworkCodeAssetKeyAdBreak, networkCodeId: gax::GaxPreconditions.CheckNotNullOrEmpty(networkCodeId, nameof(networkCodeId)), assetKeyId: gax::GaxPreconditions.CheckNotNullOrEmpty(assetKeyId, nameof(assetKeyId)), adBreakId: gax::GaxPreconditions.CheckNotNullOrEmpty(adBreakId, nameof(adBreakId)))
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
        /// The <c>AdBreak</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string AdBreakId { get; }

        /// <summary>
        /// The <c>AssetKey</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string AssetKeyId { get; }

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
                case ResourceNameType.NetworkCodeAssetKeyAdBreak: return s_networkCodeAssetKeyAdBreak.Expand(NetworkCodeId, AssetKeyId, AdBreakId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as AdBreakName);

        /// <inheritdoc/>
        public bool Equals(AdBreakName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(AdBreakName a, AdBreakName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(AdBreakName a, AdBreakName b) => !(a == b);
    }

    public partial class AdBreak
    {
        /// <summary>
        /// <see cref="gaav::AdBreakName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gaav::AdBreakName AdBreakName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::AdBreakName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
