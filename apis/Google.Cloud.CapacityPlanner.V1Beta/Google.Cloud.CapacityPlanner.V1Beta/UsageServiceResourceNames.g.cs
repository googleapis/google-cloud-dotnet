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
using gccv = Google.Cloud.CapacityPlanner.V1Beta;
using sys = System;

namespace Google.Cloud.CapacityPlanner.V1Beta
{
    /// <summary>Resource name for the <c>Forecast</c> resource.</summary>
    public sealed partial class ForecastName : gax::IResourceName, sys::IEquatable<ForecastName>
    {
        /// <summary>The possible contents of <see cref="ForecastName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/forecasts/{forecast}</c>.
            /// </summary>
            ProjectLocationForecast = 1,

            /// <summary>
            /// A resource name with pattern <c>organizations/{organization}/locations/{location}/forecasts/{forecast}</c>
            /// .
            /// </summary>
            OrganizationLocationForecast = 2,

            /// <summary>
            /// A resource name with pattern <c>folders/{folder}/locations/{location}/forecasts/{forecast}</c>.
            /// </summary>
            FolderLocationForecast = 3,
        }

        private static gax::PathTemplate s_projectLocationForecast = new gax::PathTemplate("projects/{project}/locations/{location}/forecasts/{forecast}");

        private static gax::PathTemplate s_organizationLocationForecast = new gax::PathTemplate("organizations/{organization}/locations/{location}/forecasts/{forecast}");

        private static gax::PathTemplate s_folderLocationForecast = new gax::PathTemplate("folders/{folder}/locations/{location}/forecasts/{forecast}");

        /// <summary>Creates a <see cref="ForecastName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ForecastName"/> containing the provided <paramref name="unparsedResourceName"/>
        /// .
        /// </returns>
        public static ForecastName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ForecastName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ForecastName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/forecasts/{forecast}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="forecastId">The <c>Forecast</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ForecastName"/> constructed from the provided ids.</returns>
        public static ForecastName FromProjectLocationForecast(string projectId, string locationId, string forecastId) =>
            new ForecastName(ResourceNameType.ProjectLocationForecast, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), forecastId: gax::GaxPreconditions.CheckNotNullOrEmpty(forecastId, nameof(forecastId)));

        /// <summary>
        /// Creates a <see cref="ForecastName"/> with the pattern
        /// <c>organizations/{organization}/locations/{location}/forecasts/{forecast}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="forecastId">The <c>Forecast</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ForecastName"/> constructed from the provided ids.</returns>
        public static ForecastName FromOrganizationLocationForecast(string organizationId, string locationId, string forecastId) =>
            new ForecastName(ResourceNameType.OrganizationLocationForecast, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), forecastId: gax::GaxPreconditions.CheckNotNullOrEmpty(forecastId, nameof(forecastId)));

        /// <summary>
        /// Creates a <see cref="ForecastName"/> with the pattern
        /// <c>folders/{folder}/locations/{location}/forecasts/{forecast}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="forecastId">The <c>Forecast</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ForecastName"/> constructed from the provided ids.</returns>
        public static ForecastName FromFolderLocationForecast(string folderId, string locationId, string forecastId) =>
            new ForecastName(ResourceNameType.FolderLocationForecast, folderId: gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), forecastId: gax::GaxPreconditions.CheckNotNullOrEmpty(forecastId, nameof(forecastId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ForecastName"/> with pattern
        /// <c>projects/{project}/locations/{location}/forecasts/{forecast}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="forecastId">The <c>Forecast</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ForecastName"/> with pattern
        /// <c>projects/{project}/locations/{location}/forecasts/{forecast}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string forecastId) =>
            FormatProjectLocationForecast(projectId, locationId, forecastId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ForecastName"/> with pattern
        /// <c>projects/{project}/locations/{location}/forecasts/{forecast}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="forecastId">The <c>Forecast</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ForecastName"/> with pattern
        /// <c>projects/{project}/locations/{location}/forecasts/{forecast}</c>.
        /// </returns>
        public static string FormatProjectLocationForecast(string projectId, string locationId, string forecastId) =>
            s_projectLocationForecast.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(forecastId, nameof(forecastId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ForecastName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}/forecasts/{forecast}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="forecastId">The <c>Forecast</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ForecastName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}/forecasts/{forecast}</c>.
        /// </returns>
        public static string FormatOrganizationLocationForecast(string organizationId, string locationId, string forecastId) =>
            s_organizationLocationForecast.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(forecastId, nameof(forecastId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ForecastName"/> with pattern
        /// <c>folders/{folder}/locations/{location}/forecasts/{forecast}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="forecastId">The <c>Forecast</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ForecastName"/> with pattern
        /// <c>folders/{folder}/locations/{location}/forecasts/{forecast}</c>.
        /// </returns>
        public static string FormatFolderLocationForecast(string folderId, string locationId, string forecastId) =>
            s_folderLocationForecast.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(forecastId, nameof(forecastId)));

        /// <summary>Parses the given resource name string into a new <see cref="ForecastName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/forecasts/{forecast}</c></description></item>
        /// <item>
        /// <description><c>organizations/{organization}/locations/{location}/forecasts/{forecast}</c></description>
        /// </item>
        /// <item><description><c>folders/{folder}/locations/{location}/forecasts/{forecast}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="forecastName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ForecastName"/> if successful.</returns>
        public static ForecastName Parse(string forecastName) => Parse(forecastName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ForecastName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/forecasts/{forecast}</c></description></item>
        /// <item>
        /// <description><c>organizations/{organization}/locations/{location}/forecasts/{forecast}</c></description>
        /// </item>
        /// <item><description><c>folders/{folder}/locations/{location}/forecasts/{forecast}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="forecastName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ForecastName"/> if successful.</returns>
        public static ForecastName Parse(string forecastName, bool allowUnparsed) =>
            TryParse(forecastName, allowUnparsed, out ForecastName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ForecastName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/forecasts/{forecast}</c></description></item>
        /// <item>
        /// <description><c>organizations/{organization}/locations/{location}/forecasts/{forecast}</c></description>
        /// </item>
        /// <item><description><c>folders/{folder}/locations/{location}/forecasts/{forecast}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="forecastName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ForecastName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string forecastName, out ForecastName result) => TryParse(forecastName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ForecastName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/forecasts/{forecast}</c></description></item>
        /// <item>
        /// <description><c>organizations/{organization}/locations/{location}/forecasts/{forecast}</c></description>
        /// </item>
        /// <item><description><c>folders/{folder}/locations/{location}/forecasts/{forecast}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="forecastName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ForecastName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string forecastName, bool allowUnparsed, out ForecastName result)
        {
            gax::GaxPreconditions.CheckNotNull(forecastName, nameof(forecastName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationForecast.TryParseName(forecastName, out resourceName))
            {
                result = FromProjectLocationForecast(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (s_organizationLocationForecast.TryParseName(forecastName, out resourceName))
            {
                result = FromOrganizationLocationForecast(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (s_folderLocationForecast.TryParseName(forecastName, out resourceName))
            {
                result = FromFolderLocationForecast(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(forecastName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ForecastName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string folderId = null, string forecastId = null, string locationId = null, string organizationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            FolderId = folderId;
            ForecastId = forecastId;
            LocationId = locationId;
            OrganizationId = organizationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ForecastName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/forecasts/{forecast}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="forecastId">The <c>Forecast</c> ID. Must not be <c>null</c> or empty.</param>
        public ForecastName(string projectId, string locationId, string forecastId) : this(ResourceNameType.ProjectLocationForecast, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), forecastId: gax::GaxPreconditions.CheckNotNullOrEmpty(forecastId, nameof(forecastId)))
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
        /// The <c>Folder</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string FolderId { get; }

        /// <summary>
        /// The <c>Forecast</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string ForecastId { get; }

        /// <summary>
        /// The <c>Location</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Organization</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string OrganizationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
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
                case ResourceNameType.ProjectLocationForecast: return s_projectLocationForecast.Expand(ProjectId, LocationId, ForecastId);
                case ResourceNameType.OrganizationLocationForecast: return s_organizationLocationForecast.Expand(OrganizationId, LocationId, ForecastId);
                case ResourceNameType.FolderLocationForecast: return s_folderLocationForecast.Expand(FolderId, LocationId, ForecastId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ForecastName);

        /// <inheritdoc/>
        public bool Equals(ForecastName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ForecastName a, ForecastName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ForecastName a, ForecastName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Reservation</c> resource.</summary>
    public sealed partial class ReservationName : gax::IResourceName, sys::IEquatable<ReservationName>
    {
        /// <summary>The possible contents of <see cref="ReservationName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/reservations/{reservation}</c>.
            /// </summary>
            ProjectLocationReservation = 1,

            /// <summary>
            /// A resource name with pattern
            /// <c>organizations/{organization}/locations/{location}/reservations/{reservation}</c>.
            /// </summary>
            OrganizationLocationReservation = 2,

            /// <summary>
            /// A resource name with pattern <c>folders/{folder}/locations/{location}/reservations/{reservation}</c>.
            /// </summary>
            FolderLocationReservation = 3,
        }

        private static gax::PathTemplate s_projectLocationReservation = new gax::PathTemplate("projects/{project}/locations/{location}/reservations/{reservation}");

        private static gax::PathTemplate s_organizationLocationReservation = new gax::PathTemplate("organizations/{organization}/locations/{location}/reservations/{reservation}");

        private static gax::PathTemplate s_folderLocationReservation = new gax::PathTemplate("folders/{folder}/locations/{location}/reservations/{reservation}");

        /// <summary>Creates a <see cref="ReservationName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ReservationName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ReservationName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ReservationName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ReservationName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/reservations/{reservation}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="reservationId">The <c>Reservation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ReservationName"/> constructed from the provided ids.</returns>
        public static ReservationName FromProjectLocationReservation(string projectId, string locationId, string reservationId) =>
            new ReservationName(ResourceNameType.ProjectLocationReservation, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), reservationId: gax::GaxPreconditions.CheckNotNullOrEmpty(reservationId, nameof(reservationId)));

        /// <summary>
        /// Creates a <see cref="ReservationName"/> with the pattern
        /// <c>organizations/{organization}/locations/{location}/reservations/{reservation}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="reservationId">The <c>Reservation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ReservationName"/> constructed from the provided ids.</returns>
        public static ReservationName FromOrganizationLocationReservation(string organizationId, string locationId, string reservationId) =>
            new ReservationName(ResourceNameType.OrganizationLocationReservation, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), reservationId: gax::GaxPreconditions.CheckNotNullOrEmpty(reservationId, nameof(reservationId)));

        /// <summary>
        /// Creates a <see cref="ReservationName"/> with the pattern
        /// <c>folders/{folder}/locations/{location}/reservations/{reservation}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="reservationId">The <c>Reservation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ReservationName"/> constructed from the provided ids.</returns>
        public static ReservationName FromFolderLocationReservation(string folderId, string locationId, string reservationId) =>
            new ReservationName(ResourceNameType.FolderLocationReservation, folderId: gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), reservationId: gax::GaxPreconditions.CheckNotNullOrEmpty(reservationId, nameof(reservationId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ReservationName"/> with pattern
        /// <c>projects/{project}/locations/{location}/reservations/{reservation}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="reservationId">The <c>Reservation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ReservationName"/> with pattern
        /// <c>projects/{project}/locations/{location}/reservations/{reservation}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string reservationId) =>
            FormatProjectLocationReservation(projectId, locationId, reservationId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ReservationName"/> with pattern
        /// <c>projects/{project}/locations/{location}/reservations/{reservation}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="reservationId">The <c>Reservation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ReservationName"/> with pattern
        /// <c>projects/{project}/locations/{location}/reservations/{reservation}</c>.
        /// </returns>
        public static string FormatProjectLocationReservation(string projectId, string locationId, string reservationId) =>
            s_projectLocationReservation.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(reservationId, nameof(reservationId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ReservationName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}/reservations/{reservation}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="reservationId">The <c>Reservation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ReservationName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}/reservations/{reservation}</c>.
        /// </returns>
        public static string FormatOrganizationLocationReservation(string organizationId, string locationId, string reservationId) =>
            s_organizationLocationReservation.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(reservationId, nameof(reservationId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ReservationName"/> with pattern
        /// <c>folders/{folder}/locations/{location}/reservations/{reservation}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="reservationId">The <c>Reservation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ReservationName"/> with pattern
        /// <c>folders/{folder}/locations/{location}/reservations/{reservation}</c>.
        /// </returns>
        public static string FormatFolderLocationReservation(string folderId, string locationId, string reservationId) =>
            s_folderLocationReservation.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(reservationId, nameof(reservationId)));

        /// <summary>Parses the given resource name string into a new <see cref="ReservationName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/reservations/{reservation}</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/reservations/{reservation}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description><c>folders/{folder}/locations/{location}/reservations/{reservation}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="reservationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ReservationName"/> if successful.</returns>
        public static ReservationName Parse(string reservationName) => Parse(reservationName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ReservationName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/reservations/{reservation}</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/reservations/{reservation}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description><c>folders/{folder}/locations/{location}/reservations/{reservation}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="reservationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ReservationName"/> if successful.</returns>
        public static ReservationName Parse(string reservationName, bool allowUnparsed) =>
            TryParse(reservationName, allowUnparsed, out ReservationName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ReservationName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/reservations/{reservation}</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/reservations/{reservation}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description><c>folders/{folder}/locations/{location}/reservations/{reservation}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="reservationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ReservationName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string reservationName, out ReservationName result) =>
            TryParse(reservationName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ReservationName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/reservations/{reservation}</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/reservations/{reservation}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description><c>folders/{folder}/locations/{location}/reservations/{reservation}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="reservationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ReservationName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string reservationName, bool allowUnparsed, out ReservationName result)
        {
            gax::GaxPreconditions.CheckNotNull(reservationName, nameof(reservationName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationReservation.TryParseName(reservationName, out resourceName))
            {
                result = FromProjectLocationReservation(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (s_organizationLocationReservation.TryParseName(reservationName, out resourceName))
            {
                result = FromOrganizationLocationReservation(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (s_folderLocationReservation.TryParseName(reservationName, out resourceName))
            {
                result = FromFolderLocationReservation(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(reservationName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ReservationName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string folderId = null, string locationId = null, string organizationId = null, string projectId = null, string reservationId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            FolderId = folderId;
            LocationId = locationId;
            OrganizationId = organizationId;
            ProjectId = projectId;
            ReservationId = reservationId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ReservationName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/reservations/{reservation}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="reservationId">The <c>Reservation</c> ID. Must not be <c>null</c> or empty.</param>
        public ReservationName(string projectId, string locationId, string reservationId) : this(ResourceNameType.ProjectLocationReservation, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), reservationId: gax::GaxPreconditions.CheckNotNullOrEmpty(reservationId, nameof(reservationId)))
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
        /// The <c>Folder</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string FolderId { get; }

        /// <summary>
        /// The <c>Location</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Organization</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string OrganizationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Reservation</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string ReservationId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationReservation: return s_projectLocationReservation.Expand(ProjectId, LocationId, ReservationId);
                case ResourceNameType.OrganizationLocationReservation: return s_organizationLocationReservation.Expand(OrganizationId, LocationId, ReservationId);
                case ResourceNameType.FolderLocationReservation: return s_folderLocationReservation.Expand(FolderId, LocationId, ReservationId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ReservationName);

        /// <inheritdoc/>
        public bool Equals(ReservationName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ReservationName a, ReservationName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ReservationName a, ReservationName b) => !(a == b);
    }

    public partial class QueryUsageHistoriesRequest
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

    public partial class QueryForecastsRequest
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

    public partial class QueryReservationsRequest
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

    public partial class Forecast
    {
        /// <summary>
        /// <see cref="gccv::ForecastName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::ForecastName ForecastName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::ForecastName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ReservationData
    {
        /// <summary>
        /// <see cref="gccv::ReservationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::ReservationName ReservationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::ReservationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ExportUsageHistoriesRequest
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

    public partial class ExportForecastsRequest
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

    public partial class ExportReservationsUsageRequest
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
}
