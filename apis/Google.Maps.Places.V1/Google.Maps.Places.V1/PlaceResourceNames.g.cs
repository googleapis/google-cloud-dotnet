// Copyright 2024 Google LLC
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
using gmpv = Google.Maps.Places.V1;
using sys = System;

namespace Google.Maps.Places.V1
{
    /// <summary>Resource name for the <c>Place</c> resource.</summary>
    public sealed partial class PlaceName : gax::IResourceName, sys::IEquatable<PlaceName>
    {
        /// <summary>The possible contents of <see cref="PlaceName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>places/{place_id}</c>.</summary>
            Place = 1,
        }

        private static gax::PathTemplate s_place = new gax::PathTemplate("places/{place_id}");

        /// <summary>Creates a <see cref="PlaceName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="PlaceName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static PlaceName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new PlaceName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>Creates a <see cref="PlaceName"/> with the pattern <c>places/{place_id}</c>.</summary>
        /// <param name="placeId">The <c>Place</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="PlaceName"/> constructed from the provided ids.</returns>
        public static PlaceName FromPlace(string placeId) =>
            new PlaceName(ResourceNameType.Place, placeId: gax::GaxPreconditions.CheckNotNullOrEmpty(placeId, nameof(placeId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="PlaceName"/> with pattern
        /// <c>places/{place_id}</c>.
        /// </summary>
        /// <param name="placeId">The <c>Place</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="PlaceName"/> with pattern <c>places/{place_id}</c>.
        /// </returns>
        public static string Format(string placeId) => FormatPlace(placeId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="PlaceName"/> with pattern
        /// <c>places/{place_id}</c>.
        /// </summary>
        /// <param name="placeId">The <c>Place</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="PlaceName"/> with pattern <c>places/{place_id}</c>.
        /// </returns>
        public static string FormatPlace(string placeId) =>
            s_place.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(placeId, nameof(placeId)));

        /// <summary>Parses the given resource name string into a new <see cref="PlaceName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>places/{place_id}</c></description></item></list>
        /// </remarks>
        /// <param name="placeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="PlaceName"/> if successful.</returns>
        public static PlaceName Parse(string placeName) => Parse(placeName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="PlaceName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>places/{place_id}</c></description></item></list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="placeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="PlaceName"/> if successful.</returns>
        public static PlaceName Parse(string placeName, bool allowUnparsed) =>
            TryParse(placeName, allowUnparsed, out PlaceName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="PlaceName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>places/{place_id}</c></description></item></list>
        /// </remarks>
        /// <param name="placeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="PlaceName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string placeName, out PlaceName result) => TryParse(placeName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="PlaceName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>places/{place_id}</c></description></item></list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="placeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="PlaceName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string placeName, bool allowUnparsed, out PlaceName result)
        {
            gax::GaxPreconditions.CheckNotNull(placeName, nameof(placeName));
            gax::TemplatedResourceName resourceName;
            if (s_place.TryParseName(placeName, out resourceName))
            {
                result = FromPlace(resourceName[0]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(placeName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private PlaceName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string placeId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            PlaceId = placeId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="PlaceName"/> class from the component parts of pattern
        /// <c>places/{place_id}</c>
        /// </summary>
        /// <param name="placeId">The <c>Place</c> ID. Must not be <c>null</c> or empty.</param>
        public PlaceName(string placeId) : this(ResourceNameType.Place, placeId: gax::GaxPreconditions.CheckNotNullOrEmpty(placeId, nameof(placeId)))
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
        /// The <c>Place</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string PlaceId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.Place: return s_place.Expand(PlaceId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as PlaceName);

        /// <inheritdoc/>
        public bool Equals(PlaceName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(PlaceName a, PlaceName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(PlaceName a, PlaceName b) => !(a == b);
    }

    public partial class Place
    {
        /// <summary>
        /// <see cref="gmpv::PlaceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gmpv::PlaceName PlaceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gmpv::PlaceName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        public partial class Types
        {
            public partial class SubDestination
            {
                /// <summary>
                /// <see cref="gmpv::PlaceName"/>-typed view over the <see cref="Name"/> resource name property.
                /// </summary>
                public gmpv::PlaceName PlaceName
                {
                    get => string.IsNullOrEmpty(Name) ? null : gmpv::PlaceName.Parse(Name, allowUnparsed: true);
                    set => Name = value?.ToString() ?? "";
                }
            }

            public partial class ContainingPlace
            {
                /// <summary>
                /// <see cref="gmpv::PlaceName"/>-typed view over the <see cref="Name"/> resource name property.
                /// </summary>
                public gmpv::PlaceName PlaceName
                {
                    get => string.IsNullOrEmpty(Name) ? null : gmpv::PlaceName.Parse(Name, allowUnparsed: true);
                    set => Name = value?.ToString() ?? "";
                }
            }
        }
    }
}
