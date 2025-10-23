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
    /// <summary>Resource name for the <c>Site</c> resource.</summary>
    public sealed partial class SiteName : gax::IResourceName, sys::IEquatable<SiteName>
    {
        /// <summary>The possible contents of <see cref="SiteName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>networks/{network_code}/sites/{site}</c>.</summary>
            NetworkCodeSite = 1,
        }

        private static gax::PathTemplate s_networkCodeSite = new gax::PathTemplate("networks/{network_code}/sites/{site}");

        /// <summary>Creates a <see cref="SiteName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="SiteName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static SiteName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new SiteName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="SiteName"/> with the pattern <c>networks/{network_code}/sites/{site}</c>.
        /// </summary>
        /// <param name="networkCodeId">The <c>NetworkCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="siteId">The <c>Site</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="SiteName"/> constructed from the provided ids.</returns>
        public static SiteName FromNetworkCodeSite(string networkCodeId, string siteId) =>
            new SiteName(ResourceNameType.NetworkCodeSite, networkCodeId: gax::GaxPreconditions.CheckNotNullOrEmpty(networkCodeId, nameof(networkCodeId)), siteId: gax::GaxPreconditions.CheckNotNullOrEmpty(siteId, nameof(siteId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SiteName"/> with pattern
        /// <c>networks/{network_code}/sites/{site}</c>.
        /// </summary>
        /// <param name="networkCodeId">The <c>NetworkCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="siteId">The <c>Site</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SiteName"/> with pattern
        /// <c>networks/{network_code}/sites/{site}</c>.
        /// </returns>
        public static string Format(string networkCodeId, string siteId) => FormatNetworkCodeSite(networkCodeId, siteId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SiteName"/> with pattern
        /// <c>networks/{network_code}/sites/{site}</c>.
        /// </summary>
        /// <param name="networkCodeId">The <c>NetworkCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="siteId">The <c>Site</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SiteName"/> with pattern
        /// <c>networks/{network_code}/sites/{site}</c>.
        /// </returns>
        public static string FormatNetworkCodeSite(string networkCodeId, string siteId) =>
            s_networkCodeSite.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(networkCodeId, nameof(networkCodeId)), gax::GaxPreconditions.CheckNotNullOrEmpty(siteId, nameof(siteId)));

        /// <summary>Parses the given resource name string into a new <see cref="SiteName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>networks/{network_code}/sites/{site}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="siteName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="SiteName"/> if successful.</returns>
        public static SiteName Parse(string siteName) => Parse(siteName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="SiteName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>networks/{network_code}/sites/{site}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="siteName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="SiteName"/> if successful.</returns>
        public static SiteName Parse(string siteName, bool allowUnparsed) =>
            TryParse(siteName, allowUnparsed, out SiteName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>Tries to parse the given resource name string into a new <see cref="SiteName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>networks/{network_code}/sites/{site}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="siteName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SiteName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string siteName, out SiteName result) => TryParse(siteName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SiteName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>networks/{network_code}/sites/{site}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="siteName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SiteName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string siteName, bool allowUnparsed, out SiteName result)
        {
            gax::GaxPreconditions.CheckNotNull(siteName, nameof(siteName));
            gax::TemplatedResourceName resourceName;
            if (s_networkCodeSite.TryParseName(siteName, out resourceName))
            {
                result = FromNetworkCodeSite(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(siteName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private SiteName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string networkCodeId = null, string siteId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            NetworkCodeId = networkCodeId;
            SiteId = siteId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="SiteName"/> class from the component parts of pattern
        /// <c>networks/{network_code}/sites/{site}</c>
        /// </summary>
        /// <param name="networkCodeId">The <c>NetworkCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="siteId">The <c>Site</c> ID. Must not be <c>null</c> or empty.</param>
        public SiteName(string networkCodeId, string siteId) : this(ResourceNameType.NetworkCodeSite, networkCodeId: gax::GaxPreconditions.CheckNotNullOrEmpty(networkCodeId, nameof(networkCodeId)), siteId: gax::GaxPreconditions.CheckNotNullOrEmpty(siteId, nameof(siteId)))
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
        /// The <c>Site</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string SiteId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.NetworkCodeSite: return s_networkCodeSite.Expand(NetworkCodeId, SiteId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as SiteName);

        /// <inheritdoc/>
        public bool Equals(SiteName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(SiteName a, SiteName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(SiteName a, SiteName b) => !(a == b);
    }

    public partial class Site
    {
        /// <summary>
        /// <see cref="gaav::SiteName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gaav::SiteName SiteName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::SiteName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
