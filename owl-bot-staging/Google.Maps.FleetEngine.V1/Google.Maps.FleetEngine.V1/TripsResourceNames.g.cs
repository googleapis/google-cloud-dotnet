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
using gax = Google.Api.Gax;
using gmfv = Google.Maps.FleetEngine.V1;
using sys = System;

namespace Google.Maps.FleetEngine.V1
{
    /// <summary>Resource name for the <c>Trip</c> resource.</summary>
    public sealed partial class TripName : gax::IResourceName, sys::IEquatable<TripName>
    {
        /// <summary>The possible contents of <see cref="TripName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>providers/{provider}/trips/{trip}</c>.</summary>
            ProviderTrip = 1,
        }

        private static gax::PathTemplate s_providerTrip = new gax::PathTemplate("providers/{provider}/trips/{trip}");

        /// <summary>Creates a <see cref="TripName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="TripName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static TripName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new TripName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="TripName"/> with the pattern <c>providers/{provider}/trips/{trip}</c>.
        /// </summary>
        /// <param name="providerId">The <c>Provider</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="tripId">The <c>Trip</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="TripName"/> constructed from the provided ids.</returns>
        public static TripName FromProviderTrip(string providerId, string tripId) =>
            new TripName(ResourceNameType.ProviderTrip, providerId: gax::GaxPreconditions.CheckNotNullOrEmpty(providerId, nameof(providerId)), tripId: gax::GaxPreconditions.CheckNotNullOrEmpty(tripId, nameof(tripId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TripName"/> with pattern
        /// <c>providers/{provider}/trips/{trip}</c>.
        /// </summary>
        /// <param name="providerId">The <c>Provider</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="tripId">The <c>Trip</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="TripName"/> with pattern <c>providers/{provider}/trips/{trip}</c>
        /// .
        /// </returns>
        public static string Format(string providerId, string tripId) => FormatProviderTrip(providerId, tripId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TripName"/> with pattern
        /// <c>providers/{provider}/trips/{trip}</c>.
        /// </summary>
        /// <param name="providerId">The <c>Provider</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="tripId">The <c>Trip</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="TripName"/> with pattern <c>providers/{provider}/trips/{trip}</c>
        /// .
        /// </returns>
        public static string FormatProviderTrip(string providerId, string tripId) =>
            s_providerTrip.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(providerId, nameof(providerId)), gax::GaxPreconditions.CheckNotNullOrEmpty(tripId, nameof(tripId)));

        /// <summary>Parses the given resource name string into a new <see cref="TripName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>providers/{provider}/trips/{trip}</c></description></item></list>
        /// </remarks>
        /// <param name="tripName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="TripName"/> if successful.</returns>
        public static TripName Parse(string tripName) => Parse(tripName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="TripName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>providers/{provider}/trips/{trip}</c></description></item></list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="tripName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="TripName"/> if successful.</returns>
        public static TripName Parse(string tripName, bool allowUnparsed) =>
            TryParse(tripName, allowUnparsed, out TripName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>Tries to parse the given resource name string into a new <see cref="TripName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>providers/{provider}/trips/{trip}</c></description></item></list>
        /// </remarks>
        /// <param name="tripName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="TripName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string tripName, out TripName result) => TryParse(tripName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="TripName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>providers/{provider}/trips/{trip}</c></description></item></list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="tripName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="TripName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string tripName, bool allowUnparsed, out TripName result)
        {
            gax::GaxPreconditions.CheckNotNull(tripName, nameof(tripName));
            gax::TemplatedResourceName resourceName;
            if (s_providerTrip.TryParseName(tripName, out resourceName))
            {
                result = FromProviderTrip(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(tripName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private TripName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string providerId = null, string tripId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ProviderId = providerId;
            TripId = tripId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="TripName"/> class from the component parts of pattern
        /// <c>providers/{provider}/trips/{trip}</c>
        /// </summary>
        /// <param name="providerId">The <c>Provider</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="tripId">The <c>Trip</c> ID. Must not be <c>null</c> or empty.</param>
        public TripName(string providerId, string tripId) : this(ResourceNameType.ProviderTrip, providerId: gax::GaxPreconditions.CheckNotNullOrEmpty(providerId, nameof(providerId)), tripId: gax::GaxPreconditions.CheckNotNullOrEmpty(tripId, nameof(tripId)))
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
        /// The <c>Provider</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProviderId { get; }

        /// <summary>
        /// The <c>Trip</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string TripId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProviderTrip: return s_providerTrip.Expand(ProviderId, TripId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as TripName);

        /// <inheritdoc/>
        public bool Equals(TripName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(TripName a, TripName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(TripName a, TripName b) => !(a == b);
    }

    public partial class Trip
    {
        /// <summary>
        /// <see cref="gmfv::TripName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gmfv::TripName TripName
        {
            get => string.IsNullOrEmpty(Name) ? null : gmfv::TripName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
