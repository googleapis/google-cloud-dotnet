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
using gagr = Google.Api.Gax.ResourceNames;
using gax = Google.Api.Gax;
using gcbav = Google.Cloud.BigQuery.AnalyticsHub.V1;
using sys = System;

namespace Google.Cloud.BigQuery.AnalyticsHub.V1
{
    /// <summary>Resource name for the <c>DataExchange</c> resource.</summary>
    public sealed partial class DataExchangeName : gax::IResourceName, sys::IEquatable<DataExchangeName>
    {
        /// <summary>The possible contents of <see cref="DataExchangeName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/dataExchanges/{data_exchange}</c>
            /// .
            /// </summary>
            ProjectLocationDataExchange = 1,
        }

        private static gax::PathTemplate s_projectLocationDataExchange = new gax::PathTemplate("projects/{project}/locations/{location}/dataExchanges/{data_exchange}");

        /// <summary>Creates a <see cref="DataExchangeName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="DataExchangeName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static DataExchangeName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new DataExchangeName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="DataExchangeName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/dataExchanges/{data_exchange}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataExchangeId">The <c>DataExchange</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="DataExchangeName"/> constructed from the provided ids.</returns>
        public static DataExchangeName FromProjectLocationDataExchange(string projectId, string locationId, string dataExchangeId) =>
            new DataExchangeName(ResourceNameType.ProjectLocationDataExchange, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), dataExchangeId: gax::GaxPreconditions.CheckNotNullOrEmpty(dataExchangeId, nameof(dataExchangeId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DataExchangeName"/> with pattern
        /// <c>projects/{project}/locations/{location}/dataExchanges/{data_exchange}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataExchangeId">The <c>DataExchange</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DataExchangeName"/> with pattern
        /// <c>projects/{project}/locations/{location}/dataExchanges/{data_exchange}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string dataExchangeId) =>
            FormatProjectLocationDataExchange(projectId, locationId, dataExchangeId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DataExchangeName"/> with pattern
        /// <c>projects/{project}/locations/{location}/dataExchanges/{data_exchange}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataExchangeId">The <c>DataExchange</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DataExchangeName"/> with pattern
        /// <c>projects/{project}/locations/{location}/dataExchanges/{data_exchange}</c>.
        /// </returns>
        public static string FormatProjectLocationDataExchange(string projectId, string locationId, string dataExchangeId) =>
            s_projectLocationDataExchange.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(dataExchangeId, nameof(dataExchangeId)));

        /// <summary>Parses the given resource name string into a new <see cref="DataExchangeName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/dataExchanges/{data_exchange}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="dataExchangeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="DataExchangeName"/> if successful.</returns>
        public static DataExchangeName Parse(string dataExchangeName) => Parse(dataExchangeName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="DataExchangeName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/dataExchanges/{data_exchange}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="dataExchangeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="DataExchangeName"/> if successful.</returns>
        public static DataExchangeName Parse(string dataExchangeName, bool allowUnparsed) =>
            TryParse(dataExchangeName, allowUnparsed, out DataExchangeName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DataExchangeName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/dataExchanges/{data_exchange}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="dataExchangeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DataExchangeName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string dataExchangeName, out DataExchangeName result) =>
            TryParse(dataExchangeName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DataExchangeName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/dataExchanges/{data_exchange}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="dataExchangeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DataExchangeName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string dataExchangeName, bool allowUnparsed, out DataExchangeName result)
        {
            gax::GaxPreconditions.CheckNotNull(dataExchangeName, nameof(dataExchangeName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationDataExchange.TryParseName(dataExchangeName, out resourceName))
            {
                result = FromProjectLocationDataExchange(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(dataExchangeName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private DataExchangeName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string dataExchangeId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            DataExchangeId = dataExchangeId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="DataExchangeName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/dataExchanges/{data_exchange}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataExchangeId">The <c>DataExchange</c> ID. Must not be <c>null</c> or empty.</param>
        public DataExchangeName(string projectId, string locationId, string dataExchangeId) : this(ResourceNameType.ProjectLocationDataExchange, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), dataExchangeId: gax::GaxPreconditions.CheckNotNullOrEmpty(dataExchangeId, nameof(dataExchangeId)))
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
        /// The <c>DataExchange</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string DataExchangeId { get; }

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
                case ResourceNameType.ProjectLocationDataExchange: return s_projectLocationDataExchange.Expand(ProjectId, LocationId, DataExchangeId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as DataExchangeName);

        /// <inheritdoc/>
        public bool Equals(DataExchangeName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(DataExchangeName a, DataExchangeName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(DataExchangeName a, DataExchangeName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Listing</c> resource.</summary>
    public sealed partial class ListingName : gax::IResourceName, sys::IEquatable<ListingName>
    {
        /// <summary>The possible contents of <see cref="ListingName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/dataExchanges/{data_exchange}/listings/{listing}</c>.
            /// </summary>
            ProjectLocationDataExchangeListing = 1,
        }

        private static gax::PathTemplate s_projectLocationDataExchangeListing = new gax::PathTemplate("projects/{project}/locations/{location}/dataExchanges/{data_exchange}/listings/{listing}");

        /// <summary>Creates a <see cref="ListingName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ListingName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ListingName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ListingName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ListingName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/dataExchanges/{data_exchange}/listings/{listing}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataExchangeId">The <c>DataExchange</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="listingId">The <c>Listing</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ListingName"/> constructed from the provided ids.</returns>
        public static ListingName FromProjectLocationDataExchangeListing(string projectId, string locationId, string dataExchangeId, string listingId) =>
            new ListingName(ResourceNameType.ProjectLocationDataExchangeListing, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), dataExchangeId: gax::GaxPreconditions.CheckNotNullOrEmpty(dataExchangeId, nameof(dataExchangeId)), listingId: gax::GaxPreconditions.CheckNotNullOrEmpty(listingId, nameof(listingId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ListingName"/> with pattern
        /// <c>projects/{project}/locations/{location}/dataExchanges/{data_exchange}/listings/{listing}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataExchangeId">The <c>DataExchange</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="listingId">The <c>Listing</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ListingName"/> with pattern
        /// <c>projects/{project}/locations/{location}/dataExchanges/{data_exchange}/listings/{listing}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string dataExchangeId, string listingId) =>
            FormatProjectLocationDataExchangeListing(projectId, locationId, dataExchangeId, listingId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ListingName"/> with pattern
        /// <c>projects/{project}/locations/{location}/dataExchanges/{data_exchange}/listings/{listing}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataExchangeId">The <c>DataExchange</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="listingId">The <c>Listing</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ListingName"/> with pattern
        /// <c>projects/{project}/locations/{location}/dataExchanges/{data_exchange}/listings/{listing}</c>.
        /// </returns>
        public static string FormatProjectLocationDataExchangeListing(string projectId, string locationId, string dataExchangeId, string listingId) =>
            s_projectLocationDataExchangeListing.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(dataExchangeId, nameof(dataExchangeId)), gax::GaxPreconditions.CheckNotNullOrEmpty(listingId, nameof(listingId)));

        /// <summary>Parses the given resource name string into a new <see cref="ListingName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/dataExchanges/{data_exchange}/listings/{listing}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="listingName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ListingName"/> if successful.</returns>
        public static ListingName Parse(string listingName) => Parse(listingName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ListingName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/dataExchanges/{data_exchange}/listings/{listing}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="listingName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ListingName"/> if successful.</returns>
        public static ListingName Parse(string listingName, bool allowUnparsed) =>
            TryParse(listingName, allowUnparsed, out ListingName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ListingName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/dataExchanges/{data_exchange}/listings/{listing}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="listingName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ListingName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string listingName, out ListingName result) => TryParse(listingName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ListingName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/dataExchanges/{data_exchange}/listings/{listing}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="listingName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ListingName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string listingName, bool allowUnparsed, out ListingName result)
        {
            gax::GaxPreconditions.CheckNotNull(listingName, nameof(listingName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationDataExchangeListing.TryParseName(listingName, out resourceName))
            {
                result = FromProjectLocationDataExchangeListing(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(listingName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ListingName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string dataExchangeId = null, string listingId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            DataExchangeId = dataExchangeId;
            ListingId = listingId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ListingName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/dataExchanges/{data_exchange}/listings/{listing}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataExchangeId">The <c>DataExchange</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="listingId">The <c>Listing</c> ID. Must not be <c>null</c> or empty.</param>
        public ListingName(string projectId, string locationId, string dataExchangeId, string listingId) : this(ResourceNameType.ProjectLocationDataExchangeListing, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), dataExchangeId: gax::GaxPreconditions.CheckNotNullOrEmpty(dataExchangeId, nameof(dataExchangeId)), listingId: gax::GaxPreconditions.CheckNotNullOrEmpty(listingId, nameof(listingId)))
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
        /// The <c>DataExchange</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string DataExchangeId { get; }

        /// <summary>
        /// The <c>Listing</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ListingId { get; }

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
                case ResourceNameType.ProjectLocationDataExchangeListing: return s_projectLocationDataExchangeListing.Expand(ProjectId, LocationId, DataExchangeId, ListingId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ListingName);

        /// <inheritdoc/>
        public bool Equals(ListingName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ListingName a, ListingName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ListingName a, ListingName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Subscription</c> resource.</summary>
    public sealed partial class SubscriptionName : gax::IResourceName, sys::IEquatable<SubscriptionName>
    {
        /// <summary>The possible contents of <see cref="SubscriptionName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/subscriptions/{subscription}</c>
            /// .
            /// </summary>
            ProjectLocationSubscription = 1,
        }

        private static gax::PathTemplate s_projectLocationSubscription = new gax::PathTemplate("projects/{project}/locations/{location}/subscriptions/{subscription}");

        /// <summary>Creates a <see cref="SubscriptionName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="SubscriptionName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static SubscriptionName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new SubscriptionName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="SubscriptionName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/subscriptions/{subscription}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="subscriptionId">The <c>Subscription</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="SubscriptionName"/> constructed from the provided ids.</returns>
        public static SubscriptionName FromProjectLocationSubscription(string projectId, string locationId, string subscriptionId) =>
            new SubscriptionName(ResourceNameType.ProjectLocationSubscription, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), subscriptionId: gax::GaxPreconditions.CheckNotNullOrEmpty(subscriptionId, nameof(subscriptionId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SubscriptionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/subscriptions/{subscription}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="subscriptionId">The <c>Subscription</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SubscriptionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/subscriptions/{subscription}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string subscriptionId) =>
            FormatProjectLocationSubscription(projectId, locationId, subscriptionId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SubscriptionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/subscriptions/{subscription}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="subscriptionId">The <c>Subscription</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SubscriptionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/subscriptions/{subscription}</c>.
        /// </returns>
        public static string FormatProjectLocationSubscription(string projectId, string locationId, string subscriptionId) =>
            s_projectLocationSubscription.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(subscriptionId, nameof(subscriptionId)));

        /// <summary>Parses the given resource name string into a new <see cref="SubscriptionName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/subscriptions/{subscription}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="subscriptionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="SubscriptionName"/> if successful.</returns>
        public static SubscriptionName Parse(string subscriptionName) => Parse(subscriptionName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="SubscriptionName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/subscriptions/{subscription}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="subscriptionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="SubscriptionName"/> if successful.</returns>
        public static SubscriptionName Parse(string subscriptionName, bool allowUnparsed) =>
            TryParse(subscriptionName, allowUnparsed, out SubscriptionName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SubscriptionName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/subscriptions/{subscription}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="subscriptionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SubscriptionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string subscriptionName, out SubscriptionName result) =>
            TryParse(subscriptionName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SubscriptionName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/subscriptions/{subscription}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="subscriptionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SubscriptionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string subscriptionName, bool allowUnparsed, out SubscriptionName result)
        {
            gax::GaxPreconditions.CheckNotNull(subscriptionName, nameof(subscriptionName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationSubscription.TryParseName(subscriptionName, out resourceName))
            {
                result = FromProjectLocationSubscription(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(subscriptionName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private SubscriptionName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string subscriptionId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            SubscriptionId = subscriptionId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="SubscriptionName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/subscriptions/{subscription}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="subscriptionId">The <c>Subscription</c> ID. Must not be <c>null</c> or empty.</param>
        public SubscriptionName(string projectId, string locationId, string subscriptionId) : this(ResourceNameType.ProjectLocationSubscription, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), subscriptionId: gax::GaxPreconditions.CheckNotNullOrEmpty(subscriptionId, nameof(subscriptionId)))
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
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Subscription</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string SubscriptionId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationSubscription: return s_projectLocationSubscription.Expand(ProjectId, LocationId, SubscriptionId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as SubscriptionName);

        /// <inheritdoc/>
        public bool Equals(SubscriptionName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(SubscriptionName a, SubscriptionName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(SubscriptionName a, SubscriptionName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Dataset</c> resource.</summary>
    public sealed partial class DatasetName : gax::IResourceName, sys::IEquatable<DatasetName>
    {
        /// <summary>The possible contents of <see cref="DatasetName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>projects/{project}/datasets/{dataset}</c>.</summary>
            ProjectDataset = 1,
        }

        private static gax::PathTemplate s_projectDataset = new gax::PathTemplate("projects/{project}/datasets/{dataset}");

        /// <summary>Creates a <see cref="DatasetName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="DatasetName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static DatasetName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new DatasetName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="DatasetName"/> with the pattern <c>projects/{project}/datasets/{dataset}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="datasetId">The <c>Dataset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="DatasetName"/> constructed from the provided ids.</returns>
        public static DatasetName FromProjectDataset(string projectId, string datasetId) =>
            new DatasetName(ResourceNameType.ProjectDataset, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), datasetId: gax::GaxPreconditions.CheckNotNullOrEmpty(datasetId, nameof(datasetId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DatasetName"/> with pattern
        /// <c>projects/{project}/datasets/{dataset}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="datasetId">The <c>Dataset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DatasetName"/> with pattern
        /// <c>projects/{project}/datasets/{dataset}</c>.
        /// </returns>
        public static string Format(string projectId, string datasetId) => FormatProjectDataset(projectId, datasetId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DatasetName"/> with pattern
        /// <c>projects/{project}/datasets/{dataset}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="datasetId">The <c>Dataset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DatasetName"/> with pattern
        /// <c>projects/{project}/datasets/{dataset}</c>.
        /// </returns>
        public static string FormatProjectDataset(string projectId, string datasetId) =>
            s_projectDataset.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(datasetId, nameof(datasetId)));

        /// <summary>Parses the given resource name string into a new <see cref="DatasetName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/datasets/{dataset}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="datasetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="DatasetName"/> if successful.</returns>
        public static DatasetName Parse(string datasetName) => Parse(datasetName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="DatasetName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/datasets/{dataset}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="datasetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="DatasetName"/> if successful.</returns>
        public static DatasetName Parse(string datasetName, bool allowUnparsed) =>
            TryParse(datasetName, allowUnparsed, out DatasetName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DatasetName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/datasets/{dataset}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="datasetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DatasetName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string datasetName, out DatasetName result) => TryParse(datasetName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DatasetName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/datasets/{dataset}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="datasetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DatasetName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string datasetName, bool allowUnparsed, out DatasetName result)
        {
            gax::GaxPreconditions.CheckNotNull(datasetName, nameof(datasetName));
            gax::TemplatedResourceName resourceName;
            if (s_projectDataset.TryParseName(datasetName, out resourceName))
            {
                result = FromProjectDataset(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(datasetName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private DatasetName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string datasetId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            DatasetId = datasetId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="DatasetName"/> class from the component parts of pattern
        /// <c>projects/{project}/datasets/{dataset}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="datasetId">The <c>Dataset</c> ID. Must not be <c>null</c> or empty.</param>
        public DatasetName(string projectId, string datasetId) : this(ResourceNameType.ProjectDataset, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), datasetId: gax::GaxPreconditions.CheckNotNullOrEmpty(datasetId, nameof(datasetId)))
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
        /// The <c>Dataset</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string DatasetId { get; }

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
                case ResourceNameType.ProjectDataset: return s_projectDataset.Expand(ProjectId, DatasetId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as DatasetName);

        /// <inheritdoc/>
        public bool Equals(DatasetName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(DatasetName a, DatasetName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(DatasetName a, DatasetName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Table</c> resource.</summary>
    public sealed partial class TableName : gax::IResourceName, sys::IEquatable<TableName>
    {
        /// <summary>The possible contents of <see cref="TableName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/datasets/{dataset}/tables/{table}</c>.
            /// </summary>
            ProjectDatasetTable = 1,
        }

        private static gax::PathTemplate s_projectDatasetTable = new gax::PathTemplate("projects/{project}/datasets/{dataset}/tables/{table}");

        /// <summary>Creates a <see cref="TableName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="TableName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static TableName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new TableName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="TableName"/> with the pattern <c>projects/{project}/datasets/{dataset}/tables/{table}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="datasetId">The <c>Dataset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="tableId">The <c>Table</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="TableName"/> constructed from the provided ids.</returns>
        public static TableName FromProjectDatasetTable(string projectId, string datasetId, string tableId) =>
            new TableName(ResourceNameType.ProjectDatasetTable, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), datasetId: gax::GaxPreconditions.CheckNotNullOrEmpty(datasetId, nameof(datasetId)), tableId: gax::GaxPreconditions.CheckNotNullOrEmpty(tableId, nameof(tableId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TableName"/> with pattern
        /// <c>projects/{project}/datasets/{dataset}/tables/{table}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="datasetId">The <c>Dataset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="tableId">The <c>Table</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="TableName"/> with pattern
        /// <c>projects/{project}/datasets/{dataset}/tables/{table}</c>.
        /// </returns>
        public static string Format(string projectId, string datasetId, string tableId) =>
            FormatProjectDatasetTable(projectId, datasetId, tableId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TableName"/> with pattern
        /// <c>projects/{project}/datasets/{dataset}/tables/{table}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="datasetId">The <c>Dataset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="tableId">The <c>Table</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="TableName"/> with pattern
        /// <c>projects/{project}/datasets/{dataset}/tables/{table}</c>.
        /// </returns>
        public static string FormatProjectDatasetTable(string projectId, string datasetId, string tableId) =>
            s_projectDatasetTable.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(datasetId, nameof(datasetId)), gax::GaxPreconditions.CheckNotNullOrEmpty(tableId, nameof(tableId)));

        /// <summary>Parses the given resource name string into a new <see cref="TableName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/datasets/{dataset}/tables/{table}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="tableName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="TableName"/> if successful.</returns>
        public static TableName Parse(string tableName) => Parse(tableName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="TableName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/datasets/{dataset}/tables/{table}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="tableName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="TableName"/> if successful.</returns>
        public static TableName Parse(string tableName, bool allowUnparsed) =>
            TryParse(tableName, allowUnparsed, out TableName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="TableName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/datasets/{dataset}/tables/{table}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="tableName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="TableName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string tableName, out TableName result) => TryParse(tableName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="TableName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/datasets/{dataset}/tables/{table}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="tableName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="TableName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string tableName, bool allowUnparsed, out TableName result)
        {
            gax::GaxPreconditions.CheckNotNull(tableName, nameof(tableName));
            gax::TemplatedResourceName resourceName;
            if (s_projectDatasetTable.TryParseName(tableName, out resourceName))
            {
                result = FromProjectDatasetTable(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(tableName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private TableName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string datasetId = null, string projectId = null, string tableId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            DatasetId = datasetId;
            ProjectId = projectId;
            TableId = tableId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="TableName"/> class from the component parts of pattern
        /// <c>projects/{project}/datasets/{dataset}/tables/{table}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="datasetId">The <c>Dataset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="tableId">The <c>Table</c> ID. Must not be <c>null</c> or empty.</param>
        public TableName(string projectId, string datasetId, string tableId) : this(ResourceNameType.ProjectDatasetTable, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), datasetId: gax::GaxPreconditions.CheckNotNullOrEmpty(datasetId, nameof(datasetId)), tableId: gax::GaxPreconditions.CheckNotNullOrEmpty(tableId, nameof(tableId)))
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
        /// The <c>Dataset</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string DatasetId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Table</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string TableId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectDatasetTable: return s_projectDatasetTable.Expand(ProjectId, DatasetId, TableId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as TableName);

        /// <inheritdoc/>
        public bool Equals(TableName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(TableName a, TableName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(TableName a, TableName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Topic</c> resource.</summary>
    public sealed partial class TopicName : gax::IResourceName, sys::IEquatable<TopicName>
    {
        /// <summary>The possible contents of <see cref="TopicName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>projects/{project}/topics/{topic}</c>.</summary>
            ProjectTopic = 1,
        }

        private static gax::PathTemplate s_projectTopic = new gax::PathTemplate("projects/{project}/topics/{topic}");

        /// <summary>Creates a <see cref="TopicName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="TopicName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static TopicName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new TopicName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="TopicName"/> with the pattern <c>projects/{project}/topics/{topic}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="topicId">The <c>Topic</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="TopicName"/> constructed from the provided ids.</returns>
        public static TopicName FromProjectTopic(string projectId, string topicId) =>
            new TopicName(ResourceNameType.ProjectTopic, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), topicId: gax::GaxPreconditions.CheckNotNullOrEmpty(topicId, nameof(topicId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TopicName"/> with pattern
        /// <c>projects/{project}/topics/{topic}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="topicId">The <c>Topic</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="TopicName"/> with pattern <c>projects/{project}/topics/{topic}</c>
        /// .
        /// </returns>
        public static string Format(string projectId, string topicId) => FormatProjectTopic(projectId, topicId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TopicName"/> with pattern
        /// <c>projects/{project}/topics/{topic}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="topicId">The <c>Topic</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="TopicName"/> with pattern <c>projects/{project}/topics/{topic}</c>
        /// .
        /// </returns>
        public static string FormatProjectTopic(string projectId, string topicId) =>
            s_projectTopic.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(topicId, nameof(topicId)));

        /// <summary>Parses the given resource name string into a new <see cref="TopicName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>projects/{project}/topics/{topic}</c></description></item></list>
        /// </remarks>
        /// <param name="topicName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="TopicName"/> if successful.</returns>
        public static TopicName Parse(string topicName) => Parse(topicName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="TopicName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>projects/{project}/topics/{topic}</c></description></item></list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="topicName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="TopicName"/> if successful.</returns>
        public static TopicName Parse(string topicName, bool allowUnparsed) =>
            TryParse(topicName, allowUnparsed, out TopicName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="TopicName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>projects/{project}/topics/{topic}</c></description></item></list>
        /// </remarks>
        /// <param name="topicName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="TopicName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string topicName, out TopicName result) => TryParse(topicName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="TopicName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>projects/{project}/topics/{topic}</c></description></item></list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="topicName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="TopicName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string topicName, bool allowUnparsed, out TopicName result)
        {
            gax::GaxPreconditions.CheckNotNull(topicName, nameof(topicName));
            gax::TemplatedResourceName resourceName;
            if (s_projectTopic.TryParseName(topicName, out resourceName))
            {
                result = FromProjectTopic(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(topicName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private TopicName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string projectId = null, string topicId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ProjectId = projectId;
            TopicId = topicId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="TopicName"/> class from the component parts of pattern
        /// <c>projects/{project}/topics/{topic}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="topicId">The <c>Topic</c> ID. Must not be <c>null</c> or empty.</param>
        public TopicName(string projectId, string topicId) : this(ResourceNameType.ProjectTopic, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), topicId: gax::GaxPreconditions.CheckNotNullOrEmpty(topicId, nameof(topicId)))
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
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Topic</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string TopicId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectTopic: return s_projectTopic.Expand(ProjectId, TopicId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as TopicName);

        /// <inheritdoc/>
        public bool Equals(TopicName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(TopicName a, TopicName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(TopicName a, TopicName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Routine</c> resource.</summary>
    public sealed partial class RoutineName : gax::IResourceName, sys::IEquatable<RoutineName>
    {
        /// <summary>The possible contents of <see cref="RoutineName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/datasets/{dataset}/routines/{routine}</c>.
            /// </summary>
            ProjectDatasetRoutine = 1,
        }

        private static gax::PathTemplate s_projectDatasetRoutine = new gax::PathTemplate("projects/{project}/datasets/{dataset}/routines/{routine}");

        /// <summary>Creates a <see cref="RoutineName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="RoutineName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static RoutineName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new RoutineName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="RoutineName"/> with the pattern
        /// <c>projects/{project}/datasets/{dataset}/routines/{routine}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="datasetId">The <c>Dataset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="routineId">The <c>Routine</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="RoutineName"/> constructed from the provided ids.</returns>
        public static RoutineName FromProjectDatasetRoutine(string projectId, string datasetId, string routineId) =>
            new RoutineName(ResourceNameType.ProjectDatasetRoutine, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), datasetId: gax::GaxPreconditions.CheckNotNullOrEmpty(datasetId, nameof(datasetId)), routineId: gax::GaxPreconditions.CheckNotNullOrEmpty(routineId, nameof(routineId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="RoutineName"/> with pattern
        /// <c>projects/{project}/datasets/{dataset}/routines/{routine}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="datasetId">The <c>Dataset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="routineId">The <c>Routine</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="RoutineName"/> with pattern
        /// <c>projects/{project}/datasets/{dataset}/routines/{routine}</c>.
        /// </returns>
        public static string Format(string projectId, string datasetId, string routineId) =>
            FormatProjectDatasetRoutine(projectId, datasetId, routineId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="RoutineName"/> with pattern
        /// <c>projects/{project}/datasets/{dataset}/routines/{routine}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="datasetId">The <c>Dataset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="routineId">The <c>Routine</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="RoutineName"/> with pattern
        /// <c>projects/{project}/datasets/{dataset}/routines/{routine}</c>.
        /// </returns>
        public static string FormatProjectDatasetRoutine(string projectId, string datasetId, string routineId) =>
            s_projectDatasetRoutine.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(datasetId, nameof(datasetId)), gax::GaxPreconditions.CheckNotNullOrEmpty(routineId, nameof(routineId)));

        /// <summary>Parses the given resource name string into a new <see cref="RoutineName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/datasets/{dataset}/routines/{routine}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="routineName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="RoutineName"/> if successful.</returns>
        public static RoutineName Parse(string routineName) => Parse(routineName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="RoutineName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/datasets/{dataset}/routines/{routine}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="routineName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="RoutineName"/> if successful.</returns>
        public static RoutineName Parse(string routineName, bool allowUnparsed) =>
            TryParse(routineName, allowUnparsed, out RoutineName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="RoutineName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/datasets/{dataset}/routines/{routine}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="routineName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="RoutineName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string routineName, out RoutineName result) => TryParse(routineName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="RoutineName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/datasets/{dataset}/routines/{routine}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="routineName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="RoutineName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string routineName, bool allowUnparsed, out RoutineName result)
        {
            gax::GaxPreconditions.CheckNotNull(routineName, nameof(routineName));
            gax::TemplatedResourceName resourceName;
            if (s_projectDatasetRoutine.TryParseName(routineName, out resourceName))
            {
                result = FromProjectDatasetRoutine(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(routineName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private RoutineName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string datasetId = null, string projectId = null, string routineId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            DatasetId = datasetId;
            ProjectId = projectId;
            RoutineId = routineId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="RoutineName"/> class from the component parts of pattern
        /// <c>projects/{project}/datasets/{dataset}/routines/{routine}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="datasetId">The <c>Dataset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="routineId">The <c>Routine</c> ID. Must not be <c>null</c> or empty.</param>
        public RoutineName(string projectId, string datasetId, string routineId) : this(ResourceNameType.ProjectDatasetRoutine, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), datasetId: gax::GaxPreconditions.CheckNotNullOrEmpty(datasetId, nameof(datasetId)), routineId: gax::GaxPreconditions.CheckNotNullOrEmpty(routineId, nameof(routineId)))
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
        /// The <c>Dataset</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string DatasetId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Routine</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string RoutineId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectDatasetRoutine: return s_projectDatasetRoutine.Expand(ProjectId, DatasetId, RoutineId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as RoutineName);

        /// <inheritdoc/>
        public bool Equals(RoutineName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(RoutineName a, RoutineName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(RoutineName a, RoutineName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>ManagedService</c> resource.</summary>
    public sealed partial class ManagedServiceName : gax::IResourceName, sys::IEquatable<ManagedServiceName>
    {
        /// <summary>The possible contents of <see cref="ManagedServiceName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>services/{service}</c>.</summary>
            Service = 1,
        }

        private static gax::PathTemplate s_service = new gax::PathTemplate("services/{service}");

        /// <summary>Creates a <see cref="ManagedServiceName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ManagedServiceName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ManagedServiceName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ManagedServiceName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>Creates a <see cref="ManagedServiceName"/> with the pattern <c>services/{service}</c>.</summary>
        /// <param name="serviceId">The <c>Service</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ManagedServiceName"/> constructed from the provided ids.</returns>
        public static ManagedServiceName FromService(string serviceId) =>
            new ManagedServiceName(ResourceNameType.Service, serviceId: gax::GaxPreconditions.CheckNotNullOrEmpty(serviceId, nameof(serviceId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ManagedServiceName"/> with pattern
        /// <c>services/{service}</c>.
        /// </summary>
        /// <param name="serviceId">The <c>Service</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ManagedServiceName"/> with pattern <c>services/{service}</c>.
        /// </returns>
        public static string Format(string serviceId) => FormatService(serviceId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ManagedServiceName"/> with pattern
        /// <c>services/{service}</c>.
        /// </summary>
        /// <param name="serviceId">The <c>Service</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ManagedServiceName"/> with pattern <c>services/{service}</c>.
        /// </returns>
        public static string FormatService(string serviceId) =>
            s_service.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(serviceId, nameof(serviceId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ManagedServiceName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>services/{service}</c></description></item></list>
        /// </remarks>
        /// <param name="managedServiceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ManagedServiceName"/> if successful.</returns>
        public static ManagedServiceName Parse(string managedServiceName) => Parse(managedServiceName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ManagedServiceName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>services/{service}</c></description></item></list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="managedServiceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ManagedServiceName"/> if successful.</returns>
        public static ManagedServiceName Parse(string managedServiceName, bool allowUnparsed) =>
            TryParse(managedServiceName, allowUnparsed, out ManagedServiceName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ManagedServiceName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>services/{service}</c></description></item></list>
        /// </remarks>
        /// <param name="managedServiceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ManagedServiceName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string managedServiceName, out ManagedServiceName result) =>
            TryParse(managedServiceName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ManagedServiceName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>services/{service}</c></description></item></list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="managedServiceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ManagedServiceName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string managedServiceName, bool allowUnparsed, out ManagedServiceName result)
        {
            gax::GaxPreconditions.CheckNotNull(managedServiceName, nameof(managedServiceName));
            gax::TemplatedResourceName resourceName;
            if (s_service.TryParseName(managedServiceName, out resourceName))
            {
                result = FromService(resourceName[0]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(managedServiceName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ManagedServiceName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string serviceId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ServiceId = serviceId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ManagedServiceName"/> class from the component parts of pattern
        /// <c>services/{service}</c>
        /// </summary>
        /// <param name="serviceId">The <c>Service</c> ID. Must not be <c>null</c> or empty.</param>
        public ManagedServiceName(string serviceId) : this(ResourceNameType.Service, serviceId: gax::GaxPreconditions.CheckNotNullOrEmpty(serviceId, nameof(serviceId)))
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
        /// The <c>Service</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ServiceId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.Service: return s_service.Expand(ServiceId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ManagedServiceName);

        /// <inheritdoc/>
        public bool Equals(ManagedServiceName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ManagedServiceName a, ManagedServiceName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ManagedServiceName a, ManagedServiceName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Order</c> resource.</summary>
    public sealed partial class OrderName : gax::IResourceName, sys::IEquatable<OrderName>
    {
        /// <summary>The possible contents of <see cref="OrderName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>projects/{project}/orders/{order}</c>.</summary>
            ProjectOrder = 1,
        }

        private static gax::PathTemplate s_projectOrder = new gax::PathTemplate("projects/{project}/orders/{order}");

        /// <summary>Creates a <see cref="OrderName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="OrderName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static OrderName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new OrderName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="OrderName"/> with the pattern <c>projects/{project}/orders/{order}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="orderId">The <c>Order</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="OrderName"/> constructed from the provided ids.</returns>
        public static OrderName FromProjectOrder(string projectId, string orderId) =>
            new OrderName(ResourceNameType.ProjectOrder, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), orderId: gax::GaxPreconditions.CheckNotNullOrEmpty(orderId, nameof(orderId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="OrderName"/> with pattern
        /// <c>projects/{project}/orders/{order}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="orderId">The <c>Order</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="OrderName"/> with pattern <c>projects/{project}/orders/{order}</c>
        /// .
        /// </returns>
        public static string Format(string projectId, string orderId) => FormatProjectOrder(projectId, orderId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="OrderName"/> with pattern
        /// <c>projects/{project}/orders/{order}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="orderId">The <c>Order</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="OrderName"/> with pattern <c>projects/{project}/orders/{order}</c>
        /// .
        /// </returns>
        public static string FormatProjectOrder(string projectId, string orderId) =>
            s_projectOrder.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(orderId, nameof(orderId)));

        /// <summary>Parses the given resource name string into a new <see cref="OrderName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>projects/{project}/orders/{order}</c></description></item></list>
        /// </remarks>
        /// <param name="orderName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="OrderName"/> if successful.</returns>
        public static OrderName Parse(string orderName) => Parse(orderName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="OrderName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>projects/{project}/orders/{order}</c></description></item></list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="orderName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="OrderName"/> if successful.</returns>
        public static OrderName Parse(string orderName, bool allowUnparsed) =>
            TryParse(orderName, allowUnparsed, out OrderName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="OrderName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>projects/{project}/orders/{order}</c></description></item></list>
        /// </remarks>
        /// <param name="orderName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="OrderName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string orderName, out OrderName result) => TryParse(orderName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="OrderName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>projects/{project}/orders/{order}</c></description></item></list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="orderName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="OrderName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string orderName, bool allowUnparsed, out OrderName result)
        {
            gax::GaxPreconditions.CheckNotNull(orderName, nameof(orderName));
            gax::TemplatedResourceName resourceName;
            if (s_projectOrder.TryParseName(orderName, out resourceName))
            {
                result = FromProjectOrder(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(orderName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private OrderName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string orderId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            OrderId = orderId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="OrderName"/> class from the component parts of pattern
        /// <c>projects/{project}/orders/{order}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="orderId">The <c>Order</c> ID. Must not be <c>null</c> or empty.</param>
        public OrderName(string projectId, string orderId) : this(ResourceNameType.ProjectOrder, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), orderId: gax::GaxPreconditions.CheckNotNullOrEmpty(orderId, nameof(orderId)))
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
        /// The <c>Order</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string OrderId { get; }

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
                case ResourceNameType.ProjectOrder: return s_projectOrder.Expand(ProjectId, OrderId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as OrderName);

        /// <inheritdoc/>
        public bool Equals(OrderName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(OrderName a, OrderName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(OrderName a, OrderName b) => !(a == b);
    }

    public partial class DataExchange
    {
        /// <summary>
        /// <see cref="gcbav::DataExchangeName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbav::DataExchangeName DataExchangeName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbav::DataExchangeName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class Listing
    {
        /// <summary>
        /// <see cref="gcbav::ListingName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbav::ListingName ListingName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbav::ListingName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        public partial class Types
        {
            public partial class BigQueryDatasetSource
            {
                /// <summary>
                /// <see cref="DatasetName"/>-typed view over the <see cref="Dataset"/> resource name property.
                /// </summary>
                public DatasetName DatasetAsDatasetName
                {
                    get => string.IsNullOrEmpty(Dataset) ? null : DatasetName.Parse(Dataset, allowUnparsed: true);
                    set => Dataset = value?.ToString() ?? "";
                }

                public partial class Types
                {
                    public partial class SelectedResource
                    {
                        /// <summary>
                        /// <see cref="TableName"/>-typed view over the <see cref="Table"/> resource name property.
                        /// </summary>
                        public TableName TableAsTableName
                        {
                            get => string.IsNullOrEmpty(Table) ? null : TableName.Parse(Table, allowUnparsed: true);
                            set => Table = value?.ToString() ?? "";
                        }
                    }
                }
            }

            public partial class PubSubTopicSource
            {
                /// <summary>
                /// <see cref="TopicName"/>-typed view over the <see cref="Topic"/> resource name property.
                /// </summary>
                public TopicName TopicAsTopicName
                {
                    get => string.IsNullOrEmpty(Topic) ? null : TopicName.Parse(Topic, allowUnparsed: true);
                    set => Topic = value?.ToString() ?? "";
                }
            }
        }
    }

    public partial class Subscription
    {
        /// <summary>
        /// <see cref="gcbav::SubscriptionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbav::SubscriptionName SubscriptionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbav::SubscriptionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListDataExchangesRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetDataExchangeRequest
    {
        /// <summary>
        /// <see cref="gcbav::DataExchangeName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbav::DataExchangeName DataExchangeName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbav::DataExchangeName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateDataExchangeRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteDataExchangeRequest
    {
        /// <summary>
        /// <see cref="gcbav::DataExchangeName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbav::DataExchangeName DataExchangeName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbav::DataExchangeName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListListingsRequest
    {
        /// <summary>
        /// <see cref="DataExchangeName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public DataExchangeName ParentAsDataExchangeName
        {
            get => string.IsNullOrEmpty(Parent) ? null : DataExchangeName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetListingRequest
    {
        /// <summary>
        /// <see cref="gcbav::ListingName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbav::ListingName ListingName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbav::ListingName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateListingRequest
    {
        /// <summary>
        /// <see cref="DataExchangeName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public DataExchangeName ParentAsDataExchangeName
        {
            get => string.IsNullOrEmpty(Parent) ? null : DataExchangeName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteListingRequest
    {
        /// <summary>
        /// <see cref="gcbav::ListingName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbav::ListingName ListingName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbav::ListingName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class SubscribeListingRequest
    {
        /// <summary>
        /// <see cref="gcbav::ListingName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbav::ListingName ListingName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbav::ListingName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class SubscribeDataExchangeRequest
    {
        /// <summary>
        /// <see cref="gcbav::DataExchangeName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbav::DataExchangeName DataExchangeName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbav::DataExchangeName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Destination"/> resource name property.
        /// </summary>
        public gagr::LocationName DestinationAsLocationName
        {
            get => string.IsNullOrEmpty(Destination) ? null : gagr::LocationName.Parse(Destination, allowUnparsed: true);
            set => Destination = value?.ToString() ?? "";
        }
    }

    public partial class RefreshSubscriptionRequest
    {
        /// <summary>
        /// <see cref="gcbav::SubscriptionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbav::SubscriptionName SubscriptionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbav::SubscriptionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetSubscriptionRequest
    {
        /// <summary>
        /// <see cref="gcbav::SubscriptionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbav::SubscriptionName SubscriptionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbav::SubscriptionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListSubscriptionsRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class ListSharedResourceSubscriptionsRequest
    {
        /// <summary>
        /// <see cref="gax::IResourceName"/>-typed view over the <see cref="Resource"/> resource name property.
        /// </summary>
        public gax::IResourceName ResourceAsResourceName
        {
            get => string.IsNullOrEmpty(Resource) ? null : gax::UnparsedResourceName.Parse(Resource);
            set => Resource = value?.ToString() ?? "";
        }
    }

    public partial class RevokeSubscriptionRequest
    {
        /// <summary>
        /// <see cref="gcbav::SubscriptionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbav::SubscriptionName SubscriptionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbav::SubscriptionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteSubscriptionRequest
    {
        /// <summary>
        /// <see cref="gcbav::SubscriptionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbav::SubscriptionName SubscriptionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbav::SubscriptionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
