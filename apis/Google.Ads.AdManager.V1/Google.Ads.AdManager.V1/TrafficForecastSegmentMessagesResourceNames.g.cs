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
    /// <summary>Resource name for the <c>TrafficForecastSegment</c> resource.</summary>
    public sealed partial class TrafficForecastSegmentName : gax::IResourceName, sys::IEquatable<TrafficForecastSegmentName>
    {
        /// <summary>The possible contents of <see cref="TrafficForecastSegmentName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>networks/{network_code}/trafficForecastSegments/{traffic_forecast_segment}</c>.
            /// </summary>
            NetworkCodeTrafficForecastSegment = 1,
        }

        private static gax::PathTemplate s_networkCodeTrafficForecastSegment = new gax::PathTemplate("networks/{network_code}/trafficForecastSegments/{traffic_forecast_segment}");

        /// <summary>Creates a <see cref="TrafficForecastSegmentName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="TrafficForecastSegmentName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static TrafficForecastSegmentName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new TrafficForecastSegmentName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="TrafficForecastSegmentName"/> with the pattern
        /// <c>networks/{network_code}/trafficForecastSegments/{traffic_forecast_segment}</c>.
        /// </summary>
        /// <param name="networkCodeId">The <c>NetworkCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="trafficForecastSegmentId">
        /// The <c>TrafficForecastSegment</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="TrafficForecastSegmentName"/> constructed from the provided ids.
        /// </returns>
        public static TrafficForecastSegmentName FromNetworkCodeTrafficForecastSegment(string networkCodeId, string trafficForecastSegmentId) =>
            new TrafficForecastSegmentName(ResourceNameType.NetworkCodeTrafficForecastSegment, networkCodeId: gax::GaxPreconditions.CheckNotNullOrEmpty(networkCodeId, nameof(networkCodeId)), trafficForecastSegmentId: gax::GaxPreconditions.CheckNotNullOrEmpty(trafficForecastSegmentId, nameof(trafficForecastSegmentId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TrafficForecastSegmentName"/> with pattern
        /// <c>networks/{network_code}/trafficForecastSegments/{traffic_forecast_segment}</c>.
        /// </summary>
        /// <param name="networkCodeId">The <c>NetworkCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="trafficForecastSegmentId">
        /// The <c>TrafficForecastSegment</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="TrafficForecastSegmentName"/> with pattern
        /// <c>networks/{network_code}/trafficForecastSegments/{traffic_forecast_segment}</c>.
        /// </returns>
        public static string Format(string networkCodeId, string trafficForecastSegmentId) =>
            FormatNetworkCodeTrafficForecastSegment(networkCodeId, trafficForecastSegmentId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TrafficForecastSegmentName"/> with pattern
        /// <c>networks/{network_code}/trafficForecastSegments/{traffic_forecast_segment}</c>.
        /// </summary>
        /// <param name="networkCodeId">The <c>NetworkCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="trafficForecastSegmentId">
        /// The <c>TrafficForecastSegment</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="TrafficForecastSegmentName"/> with pattern
        /// <c>networks/{network_code}/trafficForecastSegments/{traffic_forecast_segment}</c>.
        /// </returns>
        public static string FormatNetworkCodeTrafficForecastSegment(string networkCodeId, string trafficForecastSegmentId) =>
            s_networkCodeTrafficForecastSegment.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(networkCodeId, nameof(networkCodeId)), gax::GaxPreconditions.CheckNotNullOrEmpty(trafficForecastSegmentId, nameof(trafficForecastSegmentId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="TrafficForecastSegmentName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>networks/{network_code}/trafficForecastSegments/{traffic_forecast_segment}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="trafficForecastSegmentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="TrafficForecastSegmentName"/> if successful.</returns>
        public static TrafficForecastSegmentName Parse(string trafficForecastSegmentName) =>
            Parse(trafficForecastSegmentName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="TrafficForecastSegmentName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>networks/{network_code}/trafficForecastSegments/{traffic_forecast_segment}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="trafficForecastSegmentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="TrafficForecastSegmentName"/> if successful.</returns>
        public static TrafficForecastSegmentName Parse(string trafficForecastSegmentName, bool allowUnparsed) =>
            TryParse(trafficForecastSegmentName, allowUnparsed, out TrafficForecastSegmentName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="TrafficForecastSegmentName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>networks/{network_code}/trafficForecastSegments/{traffic_forecast_segment}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="trafficForecastSegmentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="TrafficForecastSegmentName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string trafficForecastSegmentName, out TrafficForecastSegmentName result) =>
            TryParse(trafficForecastSegmentName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="TrafficForecastSegmentName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>networks/{network_code}/trafficForecastSegments/{traffic_forecast_segment}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="trafficForecastSegmentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="TrafficForecastSegmentName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string trafficForecastSegmentName, bool allowUnparsed, out TrafficForecastSegmentName result)
        {
            gax::GaxPreconditions.CheckNotNull(trafficForecastSegmentName, nameof(trafficForecastSegmentName));
            gax::TemplatedResourceName resourceName;
            if (s_networkCodeTrafficForecastSegment.TryParseName(trafficForecastSegmentName, out resourceName))
            {
                result = FromNetworkCodeTrafficForecastSegment(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(trafficForecastSegmentName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private TrafficForecastSegmentName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string networkCodeId = null, string trafficForecastSegmentId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            NetworkCodeId = networkCodeId;
            TrafficForecastSegmentId = trafficForecastSegmentId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="TrafficForecastSegmentName"/> class from the component parts of
        /// pattern <c>networks/{network_code}/trafficForecastSegments/{traffic_forecast_segment}</c>
        /// </summary>
        /// <param name="networkCodeId">The <c>NetworkCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="trafficForecastSegmentId">
        /// The <c>TrafficForecastSegment</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public TrafficForecastSegmentName(string networkCodeId, string trafficForecastSegmentId) : this(ResourceNameType.NetworkCodeTrafficForecastSegment, networkCodeId: gax::GaxPreconditions.CheckNotNullOrEmpty(networkCodeId, nameof(networkCodeId)), trafficForecastSegmentId: gax::GaxPreconditions.CheckNotNullOrEmpty(trafficForecastSegmentId, nameof(trafficForecastSegmentId)))
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
        /// The <c>TrafficForecastSegment</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string TrafficForecastSegmentId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.NetworkCodeTrafficForecastSegment: return s_networkCodeTrafficForecastSegment.Expand(NetworkCodeId, TrafficForecastSegmentId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as TrafficForecastSegmentName);

        /// <inheritdoc/>
        public bool Equals(TrafficForecastSegmentName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(TrafficForecastSegmentName a, TrafficForecastSegmentName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(TrafficForecastSegmentName a, TrafficForecastSegmentName b) => !(a == b);
    }

    public partial class TrafficForecastSegment
    {
        /// <summary>
        /// <see cref="gaav::TrafficForecastSegmentName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gaav::TrafficForecastSegmentName TrafficForecastSegmentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::TrafficForecastSegmentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="AdUnitName"/>-typed view over the <see cref="TargetedAdUnits"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<AdUnitName> TargetedAdUnitsAsAdUnitNames
        {
            get => new gax::ResourceNameList<AdUnitName>(TargetedAdUnits, s => string.IsNullOrEmpty(s) ? null : AdUnitName.Parse(s, allowUnparsed: true));
        }
    }
}
