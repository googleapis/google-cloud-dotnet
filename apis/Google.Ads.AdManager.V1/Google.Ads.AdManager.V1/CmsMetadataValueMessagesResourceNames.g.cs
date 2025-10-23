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
    /// <summary>Resource name for the <c>CmsMetadataValue</c> resource.</summary>
    public sealed partial class CmsMetadataValueName : gax::IResourceName, sys::IEquatable<CmsMetadataValueName>
    {
        /// <summary>The possible contents of <see cref="CmsMetadataValueName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>networks/{network_code}/cmsMetadataValues/{cms_metadata_value}</c>.
            /// </summary>
            NetworkCodeCmsMetadataValue = 1,
        }

        private static gax::PathTemplate s_networkCodeCmsMetadataValue = new gax::PathTemplate("networks/{network_code}/cmsMetadataValues/{cms_metadata_value}");

        /// <summary>Creates a <see cref="CmsMetadataValueName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="CmsMetadataValueName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static CmsMetadataValueName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new CmsMetadataValueName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="CmsMetadataValueName"/> with the pattern
        /// <c>networks/{network_code}/cmsMetadataValues/{cms_metadata_value}</c>.
        /// </summary>
        /// <param name="networkCodeId">The <c>NetworkCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="cmsMetadataValueId">The <c>CmsMetadataValue</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="CmsMetadataValueName"/> constructed from the provided ids.</returns>
        public static CmsMetadataValueName FromNetworkCodeCmsMetadataValue(string networkCodeId, string cmsMetadataValueId) =>
            new CmsMetadataValueName(ResourceNameType.NetworkCodeCmsMetadataValue, networkCodeId: gax::GaxPreconditions.CheckNotNullOrEmpty(networkCodeId, nameof(networkCodeId)), cmsMetadataValueId: gax::GaxPreconditions.CheckNotNullOrEmpty(cmsMetadataValueId, nameof(cmsMetadataValueId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CmsMetadataValueName"/> with pattern
        /// <c>networks/{network_code}/cmsMetadataValues/{cms_metadata_value}</c>.
        /// </summary>
        /// <param name="networkCodeId">The <c>NetworkCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="cmsMetadataValueId">The <c>CmsMetadataValue</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CmsMetadataValueName"/> with pattern
        /// <c>networks/{network_code}/cmsMetadataValues/{cms_metadata_value}</c>.
        /// </returns>
        public static string Format(string networkCodeId, string cmsMetadataValueId) =>
            FormatNetworkCodeCmsMetadataValue(networkCodeId, cmsMetadataValueId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CmsMetadataValueName"/> with pattern
        /// <c>networks/{network_code}/cmsMetadataValues/{cms_metadata_value}</c>.
        /// </summary>
        /// <param name="networkCodeId">The <c>NetworkCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="cmsMetadataValueId">The <c>CmsMetadataValue</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CmsMetadataValueName"/> with pattern
        /// <c>networks/{network_code}/cmsMetadataValues/{cms_metadata_value}</c>.
        /// </returns>
        public static string FormatNetworkCodeCmsMetadataValue(string networkCodeId, string cmsMetadataValueId) =>
            s_networkCodeCmsMetadataValue.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(networkCodeId, nameof(networkCodeId)), gax::GaxPreconditions.CheckNotNullOrEmpty(cmsMetadataValueId, nameof(cmsMetadataValueId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CmsMetadataValueName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>networks/{network_code}/cmsMetadataValues/{cms_metadata_value}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="cmsMetadataValueName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="CmsMetadataValueName"/> if successful.</returns>
        public static CmsMetadataValueName Parse(string cmsMetadataValueName) => Parse(cmsMetadataValueName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CmsMetadataValueName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>networks/{network_code}/cmsMetadataValues/{cms_metadata_value}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="cmsMetadataValueName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="CmsMetadataValueName"/> if successful.</returns>
        public static CmsMetadataValueName Parse(string cmsMetadataValueName, bool allowUnparsed) =>
            TryParse(cmsMetadataValueName, allowUnparsed, out CmsMetadataValueName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CmsMetadataValueName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>networks/{network_code}/cmsMetadataValues/{cms_metadata_value}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="cmsMetadataValueName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CmsMetadataValueName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string cmsMetadataValueName, out CmsMetadataValueName result) =>
            TryParse(cmsMetadataValueName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CmsMetadataValueName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>networks/{network_code}/cmsMetadataValues/{cms_metadata_value}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="cmsMetadataValueName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CmsMetadataValueName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string cmsMetadataValueName, bool allowUnparsed, out CmsMetadataValueName result)
        {
            gax::GaxPreconditions.CheckNotNull(cmsMetadataValueName, nameof(cmsMetadataValueName));
            gax::TemplatedResourceName resourceName;
            if (s_networkCodeCmsMetadataValue.TryParseName(cmsMetadataValueName, out resourceName))
            {
                result = FromNetworkCodeCmsMetadataValue(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(cmsMetadataValueName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private CmsMetadataValueName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string cmsMetadataValueId = null, string networkCodeId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CmsMetadataValueId = cmsMetadataValueId;
            NetworkCodeId = networkCodeId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="CmsMetadataValueName"/> class from the component parts of pattern
        /// <c>networks/{network_code}/cmsMetadataValues/{cms_metadata_value}</c>
        /// </summary>
        /// <param name="networkCodeId">The <c>NetworkCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="cmsMetadataValueId">The <c>CmsMetadataValue</c> ID. Must not be <c>null</c> or empty.</param>
        public CmsMetadataValueName(string networkCodeId, string cmsMetadataValueId) : this(ResourceNameType.NetworkCodeCmsMetadataValue, networkCodeId: gax::GaxPreconditions.CheckNotNullOrEmpty(networkCodeId, nameof(networkCodeId)), cmsMetadataValueId: gax::GaxPreconditions.CheckNotNullOrEmpty(cmsMetadataValueId, nameof(cmsMetadataValueId)))
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
        /// The <c>CmsMetadataValue</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string CmsMetadataValueId { get; }

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
                case ResourceNameType.NetworkCodeCmsMetadataValue: return s_networkCodeCmsMetadataValue.Expand(NetworkCodeId, CmsMetadataValueId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as CmsMetadataValueName);

        /// <inheritdoc/>
        public bool Equals(CmsMetadataValueName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(CmsMetadataValueName a, CmsMetadataValueName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(CmsMetadataValueName a, CmsMetadataValueName b) => !(a == b);
    }

    public partial class CmsMetadataValue
    {
        /// <summary>
        /// <see cref="gaav::CmsMetadataValueName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gaav::CmsMetadataValueName CmsMetadataValueName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::CmsMetadataValueName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="CmsMetadataKeyName"/>-typed view over the <see cref="Key"/> resource name property.
        /// </summary>
        public CmsMetadataKeyName KeyAsCmsMetadataKeyName
        {
            get => string.IsNullOrEmpty(Key) ? null : CmsMetadataKeyName.Parse(Key, allowUnparsed: true);
            set => Key = value?.ToString() ?? "";
        }
    }
}
