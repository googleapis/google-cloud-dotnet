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
using gcnv = Google.Cloud.Notebooks.V1;
using sys = System;

namespace Google.Cloud.Notebooks.V1
{
    /// <summary>Resource name for the <c>Schedule</c> resource.</summary>
    public sealed partial class ScheduleName : gax::IResourceName, sys::IEquatable<ScheduleName>
    {
        /// <summary>The possible contents of <see cref="ScheduleName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/location/{location}/schedules/{schedule}</c>.
            /// </summary>
            ProjectLocationSchedule = 1,
        }

        private static gax::PathTemplate s_projectLocationSchedule = new gax::PathTemplate("projects/{project}/location/{location}/schedules/{schedule}");

        /// <summary>Creates a <see cref="ScheduleName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ScheduleName"/> containing the provided <paramref name="unparsedResourceName"/>
        /// .
        /// </returns>
        public static ScheduleName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ScheduleName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ScheduleName"/> with the pattern
        /// <c>projects/{project}/location/{location}/schedules/{schedule}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="scheduleId">The <c>Schedule</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ScheduleName"/> constructed from the provided ids.</returns>
        public static ScheduleName FromProjectLocationSchedule(string projectId, string locationId, string scheduleId) =>
            new ScheduleName(ResourceNameType.ProjectLocationSchedule, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), scheduleId: gax::GaxPreconditions.CheckNotNullOrEmpty(scheduleId, nameof(scheduleId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ScheduleName"/> with pattern
        /// <c>projects/{project}/location/{location}/schedules/{schedule}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="scheduleId">The <c>Schedule</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ScheduleName"/> with pattern
        /// <c>projects/{project}/location/{location}/schedules/{schedule}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string scheduleId) =>
            FormatProjectLocationSchedule(projectId, locationId, scheduleId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ScheduleName"/> with pattern
        /// <c>projects/{project}/location/{location}/schedules/{schedule}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="scheduleId">The <c>Schedule</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ScheduleName"/> with pattern
        /// <c>projects/{project}/location/{location}/schedules/{schedule}</c>.
        /// </returns>
        public static string FormatProjectLocationSchedule(string projectId, string locationId, string scheduleId) =>
            s_projectLocationSchedule.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(scheduleId, nameof(scheduleId)));

        /// <summary>Parses the given resource name string into a new <see cref="ScheduleName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/location/{location}/schedules/{schedule}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="scheduleName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ScheduleName"/> if successful.</returns>
        public static ScheduleName Parse(string scheduleName) => Parse(scheduleName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ScheduleName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/location/{location}/schedules/{schedule}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="scheduleName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ScheduleName"/> if successful.</returns>
        public static ScheduleName Parse(string scheduleName, bool allowUnparsed) =>
            TryParse(scheduleName, allowUnparsed, out ScheduleName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ScheduleName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/location/{location}/schedules/{schedule}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="scheduleName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ScheduleName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string scheduleName, out ScheduleName result) => TryParse(scheduleName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ScheduleName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/location/{location}/schedules/{schedule}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="scheduleName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ScheduleName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string scheduleName, bool allowUnparsed, out ScheduleName result)
        {
            gax::GaxPreconditions.CheckNotNull(scheduleName, nameof(scheduleName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationSchedule.TryParseName(scheduleName, out resourceName))
            {
                result = FromProjectLocationSchedule(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(scheduleName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ScheduleName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string scheduleId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            ScheduleId = scheduleId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ScheduleName"/> class from the component parts of pattern
        /// <c>projects/{project}/location/{location}/schedules/{schedule}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="scheduleId">The <c>Schedule</c> ID. Must not be <c>null</c> or empty.</param>
        public ScheduleName(string projectId, string locationId, string scheduleId) : this(ResourceNameType.ProjectLocationSchedule, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), scheduleId: gax::GaxPreconditions.CheckNotNullOrEmpty(scheduleId, nameof(scheduleId)))
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
        /// The <c>Schedule</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ScheduleId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationSchedule: return s_projectLocationSchedule.Expand(ProjectId, LocationId, ScheduleId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ScheduleName);

        /// <inheritdoc/>
        public bool Equals(ScheduleName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ScheduleName a, ScheduleName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ScheduleName a, ScheduleName b) => !(a == b);
    }

    public partial class Schedule
    {
        /// <summary>
        /// <see cref="gcnv::ScheduleName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcnv::ScheduleName ScheduleName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::ScheduleName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
