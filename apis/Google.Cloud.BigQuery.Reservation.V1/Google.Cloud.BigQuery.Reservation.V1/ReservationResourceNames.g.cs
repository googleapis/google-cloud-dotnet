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
using gagr = Google.Api.Gax.ResourceNames;
using gax = Google.Api.Gax;
using gcbrv = Google.Cloud.BigQuery.Reservation.V1;
using sys = System;

namespace Google.Cloud.BigQuery.Reservation.V1
{
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
        }

        private static gax::PathTemplate s_projectLocationReservation = new gax::PathTemplate("projects/{project}/locations/{location}/reservations/{reservation}");

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

        /// <summary>Parses the given resource name string into a new <see cref="ReservationName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/reservations/{reservation}</c></description>
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

        private ReservationName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string reservationId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
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
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Reservation</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
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

    /// <summary>Resource name for the <c>CapacityCommitment</c> resource.</summary>
    public sealed partial class CapacityCommitmentName : gax::IResourceName, sys::IEquatable<CapacityCommitmentName>
    {
        /// <summary>The possible contents of <see cref="CapacityCommitmentName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/capacityCommitments/{capacity_commitment}</c>.
            /// </summary>
            ProjectLocationCapacityCommitment = 1,
        }

        private static gax::PathTemplate s_projectLocationCapacityCommitment = new gax::PathTemplate("projects/{project}/locations/{location}/capacityCommitments/{capacity_commitment}");

        /// <summary>Creates a <see cref="CapacityCommitmentName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="CapacityCommitmentName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static CapacityCommitmentName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new CapacityCommitmentName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="CapacityCommitmentName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/capacityCommitments/{capacity_commitment}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="capacityCommitmentId">
        /// The <c>CapacityCommitment</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>A new instance of <see cref="CapacityCommitmentName"/> constructed from the provided ids.</returns>
        public static CapacityCommitmentName FromProjectLocationCapacityCommitment(string projectId, string locationId, string capacityCommitmentId) =>
            new CapacityCommitmentName(ResourceNameType.ProjectLocationCapacityCommitment, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), capacityCommitmentId: gax::GaxPreconditions.CheckNotNullOrEmpty(capacityCommitmentId, nameof(capacityCommitmentId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CapacityCommitmentName"/> with pattern
        /// <c>projects/{project}/locations/{location}/capacityCommitments/{capacity_commitment}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="capacityCommitmentId">
        /// The <c>CapacityCommitment</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="CapacityCommitmentName"/> with pattern
        /// <c>projects/{project}/locations/{location}/capacityCommitments/{capacity_commitment}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string capacityCommitmentId) =>
            FormatProjectLocationCapacityCommitment(projectId, locationId, capacityCommitmentId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CapacityCommitmentName"/> with pattern
        /// <c>projects/{project}/locations/{location}/capacityCommitments/{capacity_commitment}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="capacityCommitmentId">
        /// The <c>CapacityCommitment</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="CapacityCommitmentName"/> with pattern
        /// <c>projects/{project}/locations/{location}/capacityCommitments/{capacity_commitment}</c>.
        /// </returns>
        public static string FormatProjectLocationCapacityCommitment(string projectId, string locationId, string capacityCommitmentId) =>
            s_projectLocationCapacityCommitment.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(capacityCommitmentId, nameof(capacityCommitmentId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CapacityCommitmentName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/capacityCommitments/{capacity_commitment}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="capacityCommitmentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="CapacityCommitmentName"/> if successful.</returns>
        public static CapacityCommitmentName Parse(string capacityCommitmentName) => Parse(capacityCommitmentName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CapacityCommitmentName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/capacityCommitments/{capacity_commitment}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="capacityCommitmentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="CapacityCommitmentName"/> if successful.</returns>
        public static CapacityCommitmentName Parse(string capacityCommitmentName, bool allowUnparsed) =>
            TryParse(capacityCommitmentName, allowUnparsed, out CapacityCommitmentName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CapacityCommitmentName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/capacityCommitments/{capacity_commitment}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="capacityCommitmentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CapacityCommitmentName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string capacityCommitmentName, out CapacityCommitmentName result) =>
            TryParse(capacityCommitmentName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CapacityCommitmentName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/capacityCommitments/{capacity_commitment}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="capacityCommitmentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CapacityCommitmentName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string capacityCommitmentName, bool allowUnparsed, out CapacityCommitmentName result)
        {
            gax::GaxPreconditions.CheckNotNull(capacityCommitmentName, nameof(capacityCommitmentName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationCapacityCommitment.TryParseName(capacityCommitmentName, out resourceName))
            {
                result = FromProjectLocationCapacityCommitment(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(capacityCommitmentName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private CapacityCommitmentName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string capacityCommitmentId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CapacityCommitmentId = capacityCommitmentId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="CapacityCommitmentName"/> class from the component parts of
        /// pattern <c>projects/{project}/locations/{location}/capacityCommitments/{capacity_commitment}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="capacityCommitmentId">
        /// The <c>CapacityCommitment</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public CapacityCommitmentName(string projectId, string locationId, string capacityCommitmentId) : this(ResourceNameType.ProjectLocationCapacityCommitment, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), capacityCommitmentId: gax::GaxPreconditions.CheckNotNullOrEmpty(capacityCommitmentId, nameof(capacityCommitmentId)))
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
        /// The <c>CapacityCommitment</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string CapacityCommitmentId { get; }

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
                case ResourceNameType.ProjectLocationCapacityCommitment: return s_projectLocationCapacityCommitment.Expand(ProjectId, LocationId, CapacityCommitmentId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as CapacityCommitmentName);

        /// <inheritdoc/>
        public bool Equals(CapacityCommitmentName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(CapacityCommitmentName a, CapacityCommitmentName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(CapacityCommitmentName a, CapacityCommitmentName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Assignment</c> resource.</summary>
    public sealed partial class AssignmentName : gax::IResourceName, sys::IEquatable<AssignmentName>
    {
        /// <summary>The possible contents of <see cref="AssignmentName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/reservations/{reservation}/assignments/{assignment}</c>.
            /// </summary>
            ProjectLocationReservationAssignment = 1,
        }

        private static gax::PathTemplate s_projectLocationReservationAssignment = new gax::PathTemplate("projects/{project}/locations/{location}/reservations/{reservation}/assignments/{assignment}");

        /// <summary>Creates a <see cref="AssignmentName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="AssignmentName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static AssignmentName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new AssignmentName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="AssignmentName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/reservations/{reservation}/assignments/{assignment}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="reservationId">The <c>Reservation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="assignmentId">The <c>Assignment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="AssignmentName"/> constructed from the provided ids.</returns>
        public static AssignmentName FromProjectLocationReservationAssignment(string projectId, string locationId, string reservationId, string assignmentId) =>
            new AssignmentName(ResourceNameType.ProjectLocationReservationAssignment, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), reservationId: gax::GaxPreconditions.CheckNotNullOrEmpty(reservationId, nameof(reservationId)), assignmentId: gax::GaxPreconditions.CheckNotNullOrEmpty(assignmentId, nameof(assignmentId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AssignmentName"/> with pattern
        /// <c>projects/{project}/locations/{location}/reservations/{reservation}/assignments/{assignment}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="reservationId">The <c>Reservation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="assignmentId">The <c>Assignment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AssignmentName"/> with pattern
        /// <c>projects/{project}/locations/{location}/reservations/{reservation}/assignments/{assignment}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string reservationId, string assignmentId) =>
            FormatProjectLocationReservationAssignment(projectId, locationId, reservationId, assignmentId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AssignmentName"/> with pattern
        /// <c>projects/{project}/locations/{location}/reservations/{reservation}/assignments/{assignment}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="reservationId">The <c>Reservation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="assignmentId">The <c>Assignment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AssignmentName"/> with pattern
        /// <c>projects/{project}/locations/{location}/reservations/{reservation}/assignments/{assignment}</c>.
        /// </returns>
        public static string FormatProjectLocationReservationAssignment(string projectId, string locationId, string reservationId, string assignmentId) =>
            s_projectLocationReservationAssignment.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(reservationId, nameof(reservationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(assignmentId, nameof(assignmentId)));

        /// <summary>Parses the given resource name string into a new <see cref="AssignmentName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/reservations/{reservation}/assignments/{assignment}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="assignmentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AssignmentName"/> if successful.</returns>
        public static AssignmentName Parse(string assignmentName) => Parse(assignmentName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AssignmentName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/reservations/{reservation}/assignments/{assignment}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="assignmentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="AssignmentName"/> if successful.</returns>
        public static AssignmentName Parse(string assignmentName, bool allowUnparsed) =>
            TryParse(assignmentName, allowUnparsed, out AssignmentName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AssignmentName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/reservations/{reservation}/assignments/{assignment}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="assignmentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AssignmentName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string assignmentName, out AssignmentName result) =>
            TryParse(assignmentName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AssignmentName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/reservations/{reservation}/assignments/{assignment}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="assignmentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AssignmentName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string assignmentName, bool allowUnparsed, out AssignmentName result)
        {
            gax::GaxPreconditions.CheckNotNull(assignmentName, nameof(assignmentName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationReservationAssignment.TryParseName(assignmentName, out resourceName))
            {
                result = FromProjectLocationReservationAssignment(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(assignmentName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private AssignmentName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string assignmentId = null, string locationId = null, string projectId = null, string reservationId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AssignmentId = assignmentId;
            LocationId = locationId;
            ProjectId = projectId;
            ReservationId = reservationId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="AssignmentName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/reservations/{reservation}/assignments/{assignment}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="reservationId">The <c>Reservation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="assignmentId">The <c>Assignment</c> ID. Must not be <c>null</c> or empty.</param>
        public AssignmentName(string projectId, string locationId, string reservationId, string assignmentId) : this(ResourceNameType.ProjectLocationReservationAssignment, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), reservationId: gax::GaxPreconditions.CheckNotNullOrEmpty(reservationId, nameof(reservationId)), assignmentId: gax::GaxPreconditions.CheckNotNullOrEmpty(assignmentId, nameof(assignmentId)))
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
        /// The <c>Assignment</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string AssignmentId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Reservation</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
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
                case ResourceNameType.ProjectLocationReservationAssignment: return s_projectLocationReservationAssignment.Expand(ProjectId, LocationId, ReservationId, AssignmentId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as AssignmentName);

        /// <inheritdoc/>
        public bool Equals(AssignmentName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(AssignmentName a, AssignmentName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(AssignmentName a, AssignmentName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>BiReservation</c> resource.</summary>
    public sealed partial class BiReservationName : gax::IResourceName, sys::IEquatable<BiReservationName>
    {
        /// <summary>The possible contents of <see cref="BiReservationName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/biReservation</c>.
            /// </summary>
            ProjectLocation = 1,
        }

        private static gax::PathTemplate s_projectLocation = new gax::PathTemplate("projects/{project}/locations/{location}/biReservation");

        /// <summary>Creates a <see cref="BiReservationName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="BiReservationName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static BiReservationName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new BiReservationName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="BiReservationName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/biReservation</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="BiReservationName"/> constructed from the provided ids.</returns>
        public static BiReservationName FromProjectLocation(string projectId, string locationId) =>
            new BiReservationName(ResourceNameType.ProjectLocation, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="BiReservationName"/> with pattern
        /// <c>projects/{project}/locations/{location}/biReservation</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="BiReservationName"/> with pattern
        /// <c>projects/{project}/locations/{location}/biReservation</c>.
        /// </returns>
        public static string Format(string projectId, string locationId) => FormatProjectLocation(projectId, locationId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="BiReservationName"/> with pattern
        /// <c>projects/{project}/locations/{location}/biReservation</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="BiReservationName"/> with pattern
        /// <c>projects/{project}/locations/{location}/biReservation</c>.
        /// </returns>
        public static string FormatProjectLocation(string projectId, string locationId) =>
            s_projectLocation.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="BiReservationName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/biReservation</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="biReservationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="BiReservationName"/> if successful.</returns>
        public static BiReservationName Parse(string biReservationName) => Parse(biReservationName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="BiReservationName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/biReservation</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="biReservationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="BiReservationName"/> if successful.</returns>
        public static BiReservationName Parse(string biReservationName, bool allowUnparsed) =>
            TryParse(biReservationName, allowUnparsed, out BiReservationName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="BiReservationName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/biReservation</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="biReservationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="BiReservationName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string biReservationName, out BiReservationName result) =>
            TryParse(biReservationName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="BiReservationName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/biReservation</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="biReservationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="BiReservationName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string biReservationName, bool allowUnparsed, out BiReservationName result)
        {
            gax::GaxPreconditions.CheckNotNull(biReservationName, nameof(biReservationName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocation.TryParseName(biReservationName, out resourceName))
            {
                result = FromProjectLocation(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(biReservationName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private BiReservationName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="BiReservationName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/biReservation</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        public BiReservationName(string projectId, string locationId) : this(ResourceNameType.ProjectLocation, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)))
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

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocation: return s_projectLocation.Expand(ProjectId, LocationId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as BiReservationName);

        /// <inheritdoc/>
        public bool Equals(BiReservationName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(BiReservationName a, BiReservationName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(BiReservationName a, BiReservationName b) => !(a == b);
    }

    public partial class Reservation
    {
        /// <summary>
        /// <see cref="gcbrv::ReservationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbrv::ReservationName ReservationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbrv::ReservationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CapacityCommitment
    {
        /// <summary>
        /// <see cref="gcbrv::CapacityCommitmentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbrv::CapacityCommitmentName CapacityCommitmentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbrv::CapacityCommitmentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateReservationRequest
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

    public partial class ListReservationsRequest
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

    public partial class GetReservationRequest
    {
        /// <summary>
        /// <see cref="gcbrv::ReservationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbrv::ReservationName ReservationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbrv::ReservationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteReservationRequest
    {
        /// <summary>
        /// <see cref="gcbrv::ReservationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbrv::ReservationName ReservationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbrv::ReservationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateCapacityCommitmentRequest
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

    public partial class ListCapacityCommitmentsRequest
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

    public partial class GetCapacityCommitmentRequest
    {
        /// <summary>
        /// <see cref="gcbrv::CapacityCommitmentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbrv::CapacityCommitmentName CapacityCommitmentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbrv::CapacityCommitmentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteCapacityCommitmentRequest
    {
        /// <summary>
        /// <see cref="gcbrv::CapacityCommitmentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbrv::CapacityCommitmentName CapacityCommitmentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbrv::CapacityCommitmentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class SplitCapacityCommitmentRequest
    {
        /// <summary>
        /// <see cref="gcbrv::CapacityCommitmentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbrv::CapacityCommitmentName CapacityCommitmentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbrv::CapacityCommitmentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class MergeCapacityCommitmentsRequest
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

    public partial class Assignment
    {
        /// <summary>
        /// <see cref="gcbrv::AssignmentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbrv::AssignmentName AssignmentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbrv::AssignmentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateAssignmentRequest
    {
        /// <summary>
        /// <see cref="ReservationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ReservationName ParentAsReservationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ReservationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class ListAssignmentsRequest
    {
        /// <summary>
        /// <see cref="ReservationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ReservationName ParentAsReservationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ReservationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteAssignmentRequest
    {
        /// <summary>
        /// <see cref="gcbrv::AssignmentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbrv::AssignmentName AssignmentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbrv::AssignmentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class SearchAssignmentsRequest
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

    public partial class SearchAllAssignmentsRequest
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

    public partial class MoveAssignmentRequest
    {
        /// <summary>
        /// <see cref="gcbrv::AssignmentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbrv::AssignmentName AssignmentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbrv::AssignmentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="ReservationName"/>-typed view over the <see cref="DestinationId"/> resource name property.
        /// </summary>
        public ReservationName DestinationIdAsReservationName
        {
            get => string.IsNullOrEmpty(DestinationId) ? null : ReservationName.Parse(DestinationId, allowUnparsed: true);
            set => DestinationId = value?.ToString() ?? "";
        }
    }

    public partial class BiReservation
    {
        /// <summary>
        /// <see cref="gcbrv::BiReservationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbrv::BiReservationName BiReservationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbrv::BiReservationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetBiReservationRequest
    {
        /// <summary>
        /// <see cref="gcbrv::BiReservationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbrv::BiReservationName BiReservationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbrv::BiReservationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
