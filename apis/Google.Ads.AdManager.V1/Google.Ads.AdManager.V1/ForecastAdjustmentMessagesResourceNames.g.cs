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
    /// <summary>Resource name for the <c>ForecastAdjustment</c> resource.</summary>
    public sealed partial class ForecastAdjustmentName : gax::IResourceName, sys::IEquatable<ForecastAdjustmentName>
    {
        /// <summary>The possible contents of <see cref="ForecastAdjustmentName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>networks/{network_code}/forecastAdjustments/{forecast_adjustment}</c>.
            /// </summary>
            NetworkCodeForecastAdjustment = 1,
        }

        private static gax::PathTemplate s_networkCodeForecastAdjustment = new gax::PathTemplate("networks/{network_code}/forecastAdjustments/{forecast_adjustment}");

        /// <summary>Creates a <see cref="ForecastAdjustmentName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ForecastAdjustmentName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ForecastAdjustmentName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ForecastAdjustmentName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ForecastAdjustmentName"/> with the pattern
        /// <c>networks/{network_code}/forecastAdjustments/{forecast_adjustment}</c>.
        /// </summary>
        /// <param name="networkCodeId">The <c>NetworkCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="forecastAdjustmentId">
        /// The <c>ForecastAdjustment</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>A new instance of <see cref="ForecastAdjustmentName"/> constructed from the provided ids.</returns>
        public static ForecastAdjustmentName FromNetworkCodeForecastAdjustment(string networkCodeId, string forecastAdjustmentId) =>
            new ForecastAdjustmentName(ResourceNameType.NetworkCodeForecastAdjustment, networkCodeId: gax::GaxPreconditions.CheckNotNullOrEmpty(networkCodeId, nameof(networkCodeId)), forecastAdjustmentId: gax::GaxPreconditions.CheckNotNullOrEmpty(forecastAdjustmentId, nameof(forecastAdjustmentId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ForecastAdjustmentName"/> with pattern
        /// <c>networks/{network_code}/forecastAdjustments/{forecast_adjustment}</c>.
        /// </summary>
        /// <param name="networkCodeId">The <c>NetworkCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="forecastAdjustmentId">
        /// The <c>ForecastAdjustment</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="ForecastAdjustmentName"/> with pattern
        /// <c>networks/{network_code}/forecastAdjustments/{forecast_adjustment}</c>.
        /// </returns>
        public static string Format(string networkCodeId, string forecastAdjustmentId) =>
            FormatNetworkCodeForecastAdjustment(networkCodeId, forecastAdjustmentId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ForecastAdjustmentName"/> with pattern
        /// <c>networks/{network_code}/forecastAdjustments/{forecast_adjustment}</c>.
        /// </summary>
        /// <param name="networkCodeId">The <c>NetworkCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="forecastAdjustmentId">
        /// The <c>ForecastAdjustment</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="ForecastAdjustmentName"/> with pattern
        /// <c>networks/{network_code}/forecastAdjustments/{forecast_adjustment}</c>.
        /// </returns>
        public static string FormatNetworkCodeForecastAdjustment(string networkCodeId, string forecastAdjustmentId) =>
            s_networkCodeForecastAdjustment.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(networkCodeId, nameof(networkCodeId)), gax::GaxPreconditions.CheckNotNullOrEmpty(forecastAdjustmentId, nameof(forecastAdjustmentId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ForecastAdjustmentName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>networks/{network_code}/forecastAdjustments/{forecast_adjustment}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="forecastAdjustmentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ForecastAdjustmentName"/> if successful.</returns>
        public static ForecastAdjustmentName Parse(string forecastAdjustmentName) => Parse(forecastAdjustmentName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ForecastAdjustmentName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>networks/{network_code}/forecastAdjustments/{forecast_adjustment}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="forecastAdjustmentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ForecastAdjustmentName"/> if successful.</returns>
        public static ForecastAdjustmentName Parse(string forecastAdjustmentName, bool allowUnparsed) =>
            TryParse(forecastAdjustmentName, allowUnparsed, out ForecastAdjustmentName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ForecastAdjustmentName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>networks/{network_code}/forecastAdjustments/{forecast_adjustment}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="forecastAdjustmentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ForecastAdjustmentName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string forecastAdjustmentName, out ForecastAdjustmentName result) =>
            TryParse(forecastAdjustmentName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ForecastAdjustmentName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>networks/{network_code}/forecastAdjustments/{forecast_adjustment}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="forecastAdjustmentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ForecastAdjustmentName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string forecastAdjustmentName, bool allowUnparsed, out ForecastAdjustmentName result)
        {
            gax::GaxPreconditions.CheckNotNull(forecastAdjustmentName, nameof(forecastAdjustmentName));
            gax::TemplatedResourceName resourceName;
            if (s_networkCodeForecastAdjustment.TryParseName(forecastAdjustmentName, out resourceName))
            {
                result = FromNetworkCodeForecastAdjustment(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(forecastAdjustmentName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ForecastAdjustmentName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string forecastAdjustmentId = null, string networkCodeId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ForecastAdjustmentId = forecastAdjustmentId;
            NetworkCodeId = networkCodeId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ForecastAdjustmentName"/> class from the component parts of
        /// pattern <c>networks/{network_code}/forecastAdjustments/{forecast_adjustment}</c>
        /// </summary>
        /// <param name="networkCodeId">The <c>NetworkCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="forecastAdjustmentId">
        /// The <c>ForecastAdjustment</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public ForecastAdjustmentName(string networkCodeId, string forecastAdjustmentId) : this(ResourceNameType.NetworkCodeForecastAdjustment, networkCodeId: gax::GaxPreconditions.CheckNotNullOrEmpty(networkCodeId, nameof(networkCodeId)), forecastAdjustmentId: gax::GaxPreconditions.CheckNotNullOrEmpty(forecastAdjustmentId, nameof(forecastAdjustmentId)))
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
        /// The <c>ForecastAdjustment</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string ForecastAdjustmentId { get; }

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
                case ResourceNameType.NetworkCodeForecastAdjustment: return s_networkCodeForecastAdjustment.Expand(NetworkCodeId, ForecastAdjustmentId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ForecastAdjustmentName);

        /// <inheritdoc/>
        public bool Equals(ForecastAdjustmentName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ForecastAdjustmentName a, ForecastAdjustmentName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ForecastAdjustmentName a, ForecastAdjustmentName b) => !(a == b);
    }

    public partial class ForecastAdjustment
    {
        /// <summary>
        /// <see cref="gaav::ForecastAdjustmentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gaav::ForecastAdjustmentName ForecastAdjustmentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::ForecastAdjustmentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="TrafficForecastSegmentName"/>-typed view over the <see cref="TrafficForecastSegment"/> resource
        /// name property.
        /// </summary>
        public TrafficForecastSegmentName TrafficForecastSegmentAsTrafficForecastSegmentName
        {
            get => string.IsNullOrEmpty(TrafficForecastSegment) ? null : TrafficForecastSegmentName.Parse(TrafficForecastSegment, allowUnparsed: true);
            set => TrafficForecastSegment = value?.ToString() ?? "";
        }
    }
}
