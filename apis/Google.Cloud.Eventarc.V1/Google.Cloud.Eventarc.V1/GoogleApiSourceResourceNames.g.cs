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
using gcev = Google.Cloud.Eventarc.V1;
using sys = System;

namespace Google.Cloud.Eventarc.V1
{
    /// <summary>Resource name for the <c>GoogleApiSource</c> resource.</summary>
    public sealed partial class GoogleApiSourceName : gax::IResourceName, sys::IEquatable<GoogleApiSourceName>
    {
        /// <summary>The possible contents of <see cref="GoogleApiSourceName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/googleApiSources/{google_api_source}</c>.
            /// </summary>
            ProjectLocationGoogleApiSource = 1,
        }

        private static gax::PathTemplate s_projectLocationGoogleApiSource = new gax::PathTemplate("projects/{project}/locations/{location}/googleApiSources/{google_api_source}");

        /// <summary>Creates a <see cref="GoogleApiSourceName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="GoogleApiSourceName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static GoogleApiSourceName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new GoogleApiSourceName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="GoogleApiSourceName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/googleApiSources/{google_api_source}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="googleApiSourceId">The <c>GoogleApiSource</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="GoogleApiSourceName"/> constructed from the provided ids.</returns>
        public static GoogleApiSourceName FromProjectLocationGoogleApiSource(string projectId, string locationId, string googleApiSourceId) =>
            new GoogleApiSourceName(ResourceNameType.ProjectLocationGoogleApiSource, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), googleApiSourceId: gax::GaxPreconditions.CheckNotNullOrEmpty(googleApiSourceId, nameof(googleApiSourceId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="GoogleApiSourceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/googleApiSources/{google_api_source}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="googleApiSourceId">The <c>GoogleApiSource</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="GoogleApiSourceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/googleApiSources/{google_api_source}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string googleApiSourceId) =>
            FormatProjectLocationGoogleApiSource(projectId, locationId, googleApiSourceId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="GoogleApiSourceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/googleApiSources/{google_api_source}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="googleApiSourceId">The <c>GoogleApiSource</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="GoogleApiSourceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/googleApiSources/{google_api_source}</c>.
        /// </returns>
        public static string FormatProjectLocationGoogleApiSource(string projectId, string locationId, string googleApiSourceId) =>
            s_projectLocationGoogleApiSource.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(googleApiSourceId, nameof(googleApiSourceId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="GoogleApiSourceName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/googleApiSources/{google_api_source}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="googleApiSourceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="GoogleApiSourceName"/> if successful.</returns>
        public static GoogleApiSourceName Parse(string googleApiSourceName) => Parse(googleApiSourceName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="GoogleApiSourceName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/googleApiSources/{google_api_source}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="googleApiSourceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="GoogleApiSourceName"/> if successful.</returns>
        public static GoogleApiSourceName Parse(string googleApiSourceName, bool allowUnparsed) =>
            TryParse(googleApiSourceName, allowUnparsed, out GoogleApiSourceName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="GoogleApiSourceName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/googleApiSources/{google_api_source}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="googleApiSourceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="GoogleApiSourceName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string googleApiSourceName, out GoogleApiSourceName result) =>
            TryParse(googleApiSourceName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="GoogleApiSourceName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/googleApiSources/{google_api_source}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="googleApiSourceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="GoogleApiSourceName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string googleApiSourceName, bool allowUnparsed, out GoogleApiSourceName result)
        {
            gax::GaxPreconditions.CheckNotNull(googleApiSourceName, nameof(googleApiSourceName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationGoogleApiSource.TryParseName(googleApiSourceName, out resourceName))
            {
                result = FromProjectLocationGoogleApiSource(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(googleApiSourceName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private GoogleApiSourceName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string googleApiSourceId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            GoogleApiSourceId = googleApiSourceId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="GoogleApiSourceName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/googleApiSources/{google_api_source}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="googleApiSourceId">The <c>GoogleApiSource</c> ID. Must not be <c>null</c> or empty.</param>
        public GoogleApiSourceName(string projectId, string locationId, string googleApiSourceId) : this(ResourceNameType.ProjectLocationGoogleApiSource, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), googleApiSourceId: gax::GaxPreconditions.CheckNotNullOrEmpty(googleApiSourceId, nameof(googleApiSourceId)))
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
        /// The <c>GoogleApiSource</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string GoogleApiSourceId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationGoogleApiSource: return s_projectLocationGoogleApiSource.Expand(ProjectId, LocationId, GoogleApiSourceId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as GoogleApiSourceName);

        /// <inheritdoc/>
        public bool Equals(GoogleApiSourceName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(GoogleApiSourceName a, GoogleApiSourceName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(GoogleApiSourceName a, GoogleApiSourceName b) => !(a == b);
    }

    public partial class GoogleApiSource
    {
        /// <summary>
        /// <see cref="gcev::GoogleApiSourceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcev::GoogleApiSourceName GoogleApiSourceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcev::GoogleApiSourceName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="MessageBusName"/>-typed view over the <see cref="Destination"/> resource name property.
        /// </summary>
        public MessageBusName DestinationAsMessageBusName
        {
            get => string.IsNullOrEmpty(Destination) ? null : MessageBusName.Parse(Destination, allowUnparsed: true);
            set => Destination = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gcev::CryptoKeyName"/>-typed view over the <see cref="CryptoKeyName"/> resource name property.
        /// </summary>
        public gcev::CryptoKeyName CryptoKeyNameAsCryptoKeyName
        {
            get => string.IsNullOrEmpty(CryptoKeyName) ? null : gcev::CryptoKeyName.Parse(CryptoKeyName, allowUnparsed: true);
            set => CryptoKeyName = value?.ToString() ?? "";
        }
    }
}
