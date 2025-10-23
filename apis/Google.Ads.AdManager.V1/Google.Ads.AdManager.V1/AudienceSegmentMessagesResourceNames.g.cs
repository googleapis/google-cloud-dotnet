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
    /// <summary>Resource name for the <c>AudienceSegment</c> resource.</summary>
    public sealed partial class AudienceSegmentName : gax::IResourceName, sys::IEquatable<AudienceSegmentName>
    {
        /// <summary>The possible contents of <see cref="AudienceSegmentName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>networks/{network_code}/audienceSegments/{audience_segment}</c>.
            /// </summary>
            NetworkCodeAudienceSegment = 1,
        }

        private static gax::PathTemplate s_networkCodeAudienceSegment = new gax::PathTemplate("networks/{network_code}/audienceSegments/{audience_segment}");

        /// <summary>Creates a <see cref="AudienceSegmentName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="AudienceSegmentName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static AudienceSegmentName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new AudienceSegmentName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="AudienceSegmentName"/> with the pattern
        /// <c>networks/{network_code}/audienceSegments/{audience_segment}</c>.
        /// </summary>
        /// <param name="networkCodeId">The <c>NetworkCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="audienceSegmentId">The <c>AudienceSegment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="AudienceSegmentName"/> constructed from the provided ids.</returns>
        public static AudienceSegmentName FromNetworkCodeAudienceSegment(string networkCodeId, string audienceSegmentId) =>
            new AudienceSegmentName(ResourceNameType.NetworkCodeAudienceSegment, networkCodeId: gax::GaxPreconditions.CheckNotNullOrEmpty(networkCodeId, nameof(networkCodeId)), audienceSegmentId: gax::GaxPreconditions.CheckNotNullOrEmpty(audienceSegmentId, nameof(audienceSegmentId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AudienceSegmentName"/> with pattern
        /// <c>networks/{network_code}/audienceSegments/{audience_segment}</c>.
        /// </summary>
        /// <param name="networkCodeId">The <c>NetworkCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="audienceSegmentId">The <c>AudienceSegment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AudienceSegmentName"/> with pattern
        /// <c>networks/{network_code}/audienceSegments/{audience_segment}</c>.
        /// </returns>
        public static string Format(string networkCodeId, string audienceSegmentId) =>
            FormatNetworkCodeAudienceSegment(networkCodeId, audienceSegmentId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AudienceSegmentName"/> with pattern
        /// <c>networks/{network_code}/audienceSegments/{audience_segment}</c>.
        /// </summary>
        /// <param name="networkCodeId">The <c>NetworkCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="audienceSegmentId">The <c>AudienceSegment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AudienceSegmentName"/> with pattern
        /// <c>networks/{network_code}/audienceSegments/{audience_segment}</c>.
        /// </returns>
        public static string FormatNetworkCodeAudienceSegment(string networkCodeId, string audienceSegmentId) =>
            s_networkCodeAudienceSegment.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(networkCodeId, nameof(networkCodeId)), gax::GaxPreconditions.CheckNotNullOrEmpty(audienceSegmentId, nameof(audienceSegmentId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AudienceSegmentName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>networks/{network_code}/audienceSegments/{audience_segment}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="audienceSegmentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AudienceSegmentName"/> if successful.</returns>
        public static AudienceSegmentName Parse(string audienceSegmentName) => Parse(audienceSegmentName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AudienceSegmentName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>networks/{network_code}/audienceSegments/{audience_segment}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="audienceSegmentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="AudienceSegmentName"/> if successful.</returns>
        public static AudienceSegmentName Parse(string audienceSegmentName, bool allowUnparsed) =>
            TryParse(audienceSegmentName, allowUnparsed, out AudienceSegmentName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AudienceSegmentName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>networks/{network_code}/audienceSegments/{audience_segment}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="audienceSegmentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AudienceSegmentName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string audienceSegmentName, out AudienceSegmentName result) =>
            TryParse(audienceSegmentName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AudienceSegmentName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>networks/{network_code}/audienceSegments/{audience_segment}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="audienceSegmentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AudienceSegmentName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string audienceSegmentName, bool allowUnparsed, out AudienceSegmentName result)
        {
            gax::GaxPreconditions.CheckNotNull(audienceSegmentName, nameof(audienceSegmentName));
            gax::TemplatedResourceName resourceName;
            if (s_networkCodeAudienceSegment.TryParseName(audienceSegmentName, out resourceName))
            {
                result = FromNetworkCodeAudienceSegment(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(audienceSegmentName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private AudienceSegmentName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string audienceSegmentId = null, string networkCodeId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AudienceSegmentId = audienceSegmentId;
            NetworkCodeId = networkCodeId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="AudienceSegmentName"/> class from the component parts of pattern
        /// <c>networks/{network_code}/audienceSegments/{audience_segment}</c>
        /// </summary>
        /// <param name="networkCodeId">The <c>NetworkCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="audienceSegmentId">The <c>AudienceSegment</c> ID. Must not be <c>null</c> or empty.</param>
        public AudienceSegmentName(string networkCodeId, string audienceSegmentId) : this(ResourceNameType.NetworkCodeAudienceSegment, networkCodeId: gax::GaxPreconditions.CheckNotNullOrEmpty(networkCodeId, nameof(networkCodeId)), audienceSegmentId: gax::GaxPreconditions.CheckNotNullOrEmpty(audienceSegmentId, nameof(audienceSegmentId)))
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
        /// The <c>AudienceSegment</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string AudienceSegmentId { get; }

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
                case ResourceNameType.NetworkCodeAudienceSegment: return s_networkCodeAudienceSegment.Expand(NetworkCodeId, AudienceSegmentId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as AudienceSegmentName);

        /// <inheritdoc/>
        public bool Equals(AudienceSegmentName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(AudienceSegmentName a, AudienceSegmentName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(AudienceSegmentName a, AudienceSegmentName b) => !(a == b);
    }

    public partial class AudienceSegment
    {
        /// <summary>
        /// <see cref="gaav::AudienceSegmentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gaav::AudienceSegmentName AudienceSegmentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::AudienceSegmentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
