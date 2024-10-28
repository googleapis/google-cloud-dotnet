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
    /// <summary>Resource name for the <c>Enrollment</c> resource.</summary>
    public sealed partial class EnrollmentName : gax::IResourceName, sys::IEquatable<EnrollmentName>
    {
        /// <summary>The possible contents of <see cref="EnrollmentName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/enrollments/{enrollment}</c>.
            /// </summary>
            ProjectLocationEnrollment = 1,
        }

        private static gax::PathTemplate s_projectLocationEnrollment = new gax::PathTemplate("projects/{project}/locations/{location}/enrollments/{enrollment}");

        /// <summary>Creates a <see cref="EnrollmentName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="EnrollmentName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static EnrollmentName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new EnrollmentName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="EnrollmentName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/enrollments/{enrollment}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="enrollmentId">The <c>Enrollment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="EnrollmentName"/> constructed from the provided ids.</returns>
        public static EnrollmentName FromProjectLocationEnrollment(string projectId, string locationId, string enrollmentId) =>
            new EnrollmentName(ResourceNameType.ProjectLocationEnrollment, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), enrollmentId: gax::GaxPreconditions.CheckNotNullOrEmpty(enrollmentId, nameof(enrollmentId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="EnrollmentName"/> with pattern
        /// <c>projects/{project}/locations/{location}/enrollments/{enrollment}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="enrollmentId">The <c>Enrollment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="EnrollmentName"/> with pattern
        /// <c>projects/{project}/locations/{location}/enrollments/{enrollment}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string enrollmentId) =>
            FormatProjectLocationEnrollment(projectId, locationId, enrollmentId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="EnrollmentName"/> with pattern
        /// <c>projects/{project}/locations/{location}/enrollments/{enrollment}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="enrollmentId">The <c>Enrollment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="EnrollmentName"/> with pattern
        /// <c>projects/{project}/locations/{location}/enrollments/{enrollment}</c>.
        /// </returns>
        public static string FormatProjectLocationEnrollment(string projectId, string locationId, string enrollmentId) =>
            s_projectLocationEnrollment.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(enrollmentId, nameof(enrollmentId)));

        /// <summary>Parses the given resource name string into a new <see cref="EnrollmentName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/enrollments/{enrollment}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="enrollmentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="EnrollmentName"/> if successful.</returns>
        public static EnrollmentName Parse(string enrollmentName) => Parse(enrollmentName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="EnrollmentName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/enrollments/{enrollment}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="enrollmentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="EnrollmentName"/> if successful.</returns>
        public static EnrollmentName Parse(string enrollmentName, bool allowUnparsed) =>
            TryParse(enrollmentName, allowUnparsed, out EnrollmentName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="EnrollmentName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/enrollments/{enrollment}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="enrollmentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="EnrollmentName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string enrollmentName, out EnrollmentName result) =>
            TryParse(enrollmentName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="EnrollmentName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/enrollments/{enrollment}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="enrollmentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="EnrollmentName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string enrollmentName, bool allowUnparsed, out EnrollmentName result)
        {
            gax::GaxPreconditions.CheckNotNull(enrollmentName, nameof(enrollmentName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationEnrollment.TryParseName(enrollmentName, out resourceName))
            {
                result = FromProjectLocationEnrollment(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(enrollmentName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private EnrollmentName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string enrollmentId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            EnrollmentId = enrollmentId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="EnrollmentName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/enrollments/{enrollment}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="enrollmentId">The <c>Enrollment</c> ID. Must not be <c>null</c> or empty.</param>
        public EnrollmentName(string projectId, string locationId, string enrollmentId) : this(ResourceNameType.ProjectLocationEnrollment, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), enrollmentId: gax::GaxPreconditions.CheckNotNullOrEmpty(enrollmentId, nameof(enrollmentId)))
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
        /// The <c>Enrollment</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string EnrollmentId { get; }

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
                case ResourceNameType.ProjectLocationEnrollment: return s_projectLocationEnrollment.Expand(ProjectId, LocationId, EnrollmentId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as EnrollmentName);

        /// <inheritdoc/>
        public bool Equals(EnrollmentName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(EnrollmentName a, EnrollmentName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(EnrollmentName a, EnrollmentName b) => !(a == b);
    }

    public partial class Enrollment
    {
        /// <summary>
        /// <see cref="gcev::EnrollmentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcev::EnrollmentName EnrollmentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcev::EnrollmentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="MessageBusName"/>-typed view over the <see cref="MessageBus"/> resource name property.
        /// </summary>
        public MessageBusName MessageBusAsMessageBusName
        {
            get => string.IsNullOrEmpty(MessageBus) ? null : MessageBusName.Parse(MessageBus, allowUnparsed: true);
            set => MessageBus = value?.ToString() ?? "";
        }
    }
}
