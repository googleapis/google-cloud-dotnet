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
    /// <summary>Resource name for the <c>LiveStream</c> resource.</summary>
    public sealed partial class LiveStreamName : gax::IResourceName, sys::IEquatable<LiveStreamName>
    {
        /// <summary>The possible contents of <see cref="LiveStreamName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>networks/{network_code}/liveStreams/{live_stream}</c>.
            /// </summary>
            NetworkCodeLiveStream = 1,
        }

        private static gax::PathTemplate s_networkCodeLiveStream = new gax::PathTemplate("networks/{network_code}/liveStreams/{live_stream}");

        /// <summary>Creates a <see cref="LiveStreamName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="LiveStreamName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static LiveStreamName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new LiveStreamName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="LiveStreamName"/> with the pattern <c>networks/{network_code}/liveStreams/{live_stream}</c>
        /// .
        /// </summary>
        /// <param name="networkCodeId">The <c>NetworkCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="liveStreamId">The <c>LiveStream</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="LiveStreamName"/> constructed from the provided ids.</returns>
        public static LiveStreamName FromNetworkCodeLiveStream(string networkCodeId, string liveStreamId) =>
            new LiveStreamName(ResourceNameType.NetworkCodeLiveStream, networkCodeId: gax::GaxPreconditions.CheckNotNullOrEmpty(networkCodeId, nameof(networkCodeId)), liveStreamId: gax::GaxPreconditions.CheckNotNullOrEmpty(liveStreamId, nameof(liveStreamId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="LiveStreamName"/> with pattern
        /// <c>networks/{network_code}/liveStreams/{live_stream}</c>.
        /// </summary>
        /// <param name="networkCodeId">The <c>NetworkCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="liveStreamId">The <c>LiveStream</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="LiveStreamName"/> with pattern
        /// <c>networks/{network_code}/liveStreams/{live_stream}</c>.
        /// </returns>
        public static string Format(string networkCodeId, string liveStreamId) =>
            FormatNetworkCodeLiveStream(networkCodeId, liveStreamId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="LiveStreamName"/> with pattern
        /// <c>networks/{network_code}/liveStreams/{live_stream}</c>.
        /// </summary>
        /// <param name="networkCodeId">The <c>NetworkCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="liveStreamId">The <c>LiveStream</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="LiveStreamName"/> with pattern
        /// <c>networks/{network_code}/liveStreams/{live_stream}</c>.
        /// </returns>
        public static string FormatNetworkCodeLiveStream(string networkCodeId, string liveStreamId) =>
            s_networkCodeLiveStream.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(networkCodeId, nameof(networkCodeId)), gax::GaxPreconditions.CheckNotNullOrEmpty(liveStreamId, nameof(liveStreamId)));

        /// <summary>Parses the given resource name string into a new <see cref="LiveStreamName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>networks/{network_code}/liveStreams/{live_stream}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="liveStreamName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="LiveStreamName"/> if successful.</returns>
        public static LiveStreamName Parse(string liveStreamName) => Parse(liveStreamName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="LiveStreamName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>networks/{network_code}/liveStreams/{live_stream}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="liveStreamName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="LiveStreamName"/> if successful.</returns>
        public static LiveStreamName Parse(string liveStreamName, bool allowUnparsed) =>
            TryParse(liveStreamName, allowUnparsed, out LiveStreamName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="LiveStreamName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>networks/{network_code}/liveStreams/{live_stream}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="liveStreamName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="LiveStreamName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string liveStreamName, out LiveStreamName result) =>
            TryParse(liveStreamName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="LiveStreamName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>networks/{network_code}/liveStreams/{live_stream}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="liveStreamName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="LiveStreamName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string liveStreamName, bool allowUnparsed, out LiveStreamName result)
        {
            gax::GaxPreconditions.CheckNotNull(liveStreamName, nameof(liveStreamName));
            gax::TemplatedResourceName resourceName;
            if (s_networkCodeLiveStream.TryParseName(liveStreamName, out resourceName))
            {
                result = FromNetworkCodeLiveStream(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(liveStreamName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private LiveStreamName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string liveStreamId = null, string networkCodeId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LiveStreamId = liveStreamId;
            NetworkCodeId = networkCodeId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="LiveStreamName"/> class from the component parts of pattern
        /// <c>networks/{network_code}/liveStreams/{live_stream}</c>
        /// </summary>
        /// <param name="networkCodeId">The <c>NetworkCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="liveStreamId">The <c>LiveStream</c> ID. Must not be <c>null</c> or empty.</param>
        public LiveStreamName(string networkCodeId, string liveStreamId) : this(ResourceNameType.NetworkCodeLiveStream, networkCodeId: gax::GaxPreconditions.CheckNotNullOrEmpty(networkCodeId, nameof(networkCodeId)), liveStreamId: gax::GaxPreconditions.CheckNotNullOrEmpty(liveStreamId, nameof(liveStreamId)))
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
        /// The <c>LiveStream</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LiveStreamId { get; }

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
                case ResourceNameType.NetworkCodeLiveStream: return s_networkCodeLiveStream.Expand(NetworkCodeId, LiveStreamId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as LiveStreamName);

        /// <inheritdoc/>
        public bool Equals(LiveStreamName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(LiveStreamName a, LiveStreamName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(LiveStreamName a, LiveStreamName b) => !(a == b);
    }

    public partial class LiveStream
    {
        /// <summary>
        /// <see cref="gaav::LiveStreamName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gaav::LiveStreamName LiveStreamName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::LiveStreamName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="CdnConfigName"/>-typed view over the <see cref="SourceContentConfigurations"/> resource name
        /// property.
        /// </summary>
        public gax::ResourceNameList<CdnConfigName> SourceContentConfigurationsAsCdnConfigNames
        {
            get => new gax::ResourceNameList<CdnConfigName>(SourceContentConfigurations, s => string.IsNullOrEmpty(s) ? null : CdnConfigName.Parse(s, allowUnparsed: true));
        }

        /// <summary>
        /// <see cref="CdnConfigName"/>-typed view over the <see cref="AdMediaDeliveryConfig"/> resource name property.
        /// </summary>
        public CdnConfigName AdMediaDeliveryConfigAsCdnConfigName
        {
            get => string.IsNullOrEmpty(AdMediaDeliveryConfig) ? null : CdnConfigName.Parse(AdMediaDeliveryConfig, allowUnparsed: true);
            set => AdMediaDeliveryConfig = value?.ToString() ?? "";
        }
    }
}
