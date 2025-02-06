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
using gmpv = Google.Maps.Places.V1;
using sys = System;

namespace Google.Maps.Places.V1
{
    /// <summary>Resource name for the <c>Photo</c> resource.</summary>
    public sealed partial class PhotoName : gax::IResourceName, sys::IEquatable<PhotoName>
    {
        /// <summary>The possible contents of <see cref="PhotoName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>places/{place}/photos/{photo}</c>.</summary>
            PlacePhoto = 1,
        }

        private static gax::PathTemplate s_placePhoto = new gax::PathTemplate("places/{place}/photos/{photo}");

        /// <summary>Creates a <see cref="PhotoName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="PhotoName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static PhotoName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new PhotoName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>Creates a <see cref="PhotoName"/> with the pattern <c>places/{place}/photos/{photo}</c>.</summary>
        /// <param name="placeId">The <c>Place</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="photoId">The <c>Photo</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="PhotoName"/> constructed from the provided ids.</returns>
        public static PhotoName FromPlacePhoto(string placeId, string photoId) =>
            new PhotoName(ResourceNameType.PlacePhoto, placeId: gax::GaxPreconditions.CheckNotNullOrEmpty(placeId, nameof(placeId)), photoId: gax::GaxPreconditions.CheckNotNullOrEmpty(photoId, nameof(photoId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="PhotoName"/> with pattern
        /// <c>places/{place}/photos/{photo}</c>.
        /// </summary>
        /// <param name="placeId">The <c>Place</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="photoId">The <c>Photo</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="PhotoName"/> with pattern <c>places/{place}/photos/{photo}</c>.
        /// </returns>
        public static string Format(string placeId, string photoId) => FormatPlacePhoto(placeId, photoId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="PhotoName"/> with pattern
        /// <c>places/{place}/photos/{photo}</c>.
        /// </summary>
        /// <param name="placeId">The <c>Place</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="photoId">The <c>Photo</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="PhotoName"/> with pattern <c>places/{place}/photos/{photo}</c>.
        /// </returns>
        public static string FormatPlacePhoto(string placeId, string photoId) =>
            s_placePhoto.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(placeId, nameof(placeId)), gax::GaxPreconditions.CheckNotNullOrEmpty(photoId, nameof(photoId)));

        /// <summary>Parses the given resource name string into a new <see cref="PhotoName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>places/{place}/photos/{photo}</c></description></item></list>
        /// </remarks>
        /// <param name="photoName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="PhotoName"/> if successful.</returns>
        public static PhotoName Parse(string photoName) => Parse(photoName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="PhotoName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>places/{place}/photos/{photo}</c></description></item></list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="photoName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="PhotoName"/> if successful.</returns>
        public static PhotoName Parse(string photoName, bool allowUnparsed) =>
            TryParse(photoName, allowUnparsed, out PhotoName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="PhotoName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>places/{place}/photos/{photo}</c></description></item></list>
        /// </remarks>
        /// <param name="photoName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="PhotoName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string photoName, out PhotoName result) => TryParse(photoName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="PhotoName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>places/{place}/photos/{photo}</c></description></item></list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="photoName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="PhotoName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string photoName, bool allowUnparsed, out PhotoName result)
        {
            gax::GaxPreconditions.CheckNotNull(photoName, nameof(photoName));
            gax::TemplatedResourceName resourceName;
            if (s_placePhoto.TryParseName(photoName, out resourceName))
            {
                result = FromPlacePhoto(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(photoName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private PhotoName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string photoId = null, string placeId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            PhotoId = photoId;
            PlaceId = placeId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="PhotoName"/> class from the component parts of pattern
        /// <c>places/{place}/photos/{photo}</c>
        /// </summary>
        /// <param name="placeId">The <c>Place</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="photoId">The <c>Photo</c> ID. Must not be <c>null</c> or empty.</param>
        public PhotoName(string placeId, string photoId) : this(ResourceNameType.PlacePhoto, placeId: gax::GaxPreconditions.CheckNotNullOrEmpty(placeId, nameof(placeId)), photoId: gax::GaxPreconditions.CheckNotNullOrEmpty(photoId, nameof(photoId)))
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
        /// The <c>Photo</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string PhotoId { get; }

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
                case ResourceNameType.PlacePhoto: return s_placePhoto.Expand(PlaceId, PhotoId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as PhotoName);

        /// <inheritdoc/>
        public bool Equals(PhotoName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(PhotoName a, PhotoName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(PhotoName a, PhotoName b) => !(a == b);
    }

    public partial class Photo
    {
        /// <summary>
        /// <see cref="gmpv::PhotoName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gmpv::PhotoName PhotoName
        {
            get => string.IsNullOrEmpty(Name) ? null : gmpv::PhotoName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
