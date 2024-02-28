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
using gcov = Google.Cloud.OsConfig.V1;
using sys = System;

namespace Google.Cloud.OsConfig.V1
{
    /// <summary>Resource name for the <c>OSPolicyAssignmentReport</c> resource.</summary>
    public sealed partial class OSPolicyAssignmentReportName : gax::IResourceName, sys::IEquatable<OSPolicyAssignmentReportName>
    {
        /// <summary>The possible contents of <see cref="OSPolicyAssignmentReportName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/instances/{instance}/osPolicyAssignments/{assignment}/report</c>
            /// .
            /// </summary>
            ProjectLocationInstanceAssignment = 1,
        }

        private static gax::PathTemplate s_projectLocationInstanceAssignment = new gax::PathTemplate("projects/{project}/locations/{location}/instances/{instance}/osPolicyAssignments/{assignment}/report");

        /// <summary>
        /// Creates a <see cref="OSPolicyAssignmentReportName"/> containing an unparsed resource name.
        /// </summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="OSPolicyAssignmentReportName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static OSPolicyAssignmentReportName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new OSPolicyAssignmentReportName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="OSPolicyAssignmentReportName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}/osPolicyAssignments/{assignment}/report</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="assignmentId">The <c>Assignment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// A new instance of <see cref="OSPolicyAssignmentReportName"/> constructed from the provided ids.
        /// </returns>
        public static OSPolicyAssignmentReportName FromProjectLocationInstanceAssignment(string projectId, string locationId, string instanceId, string assignmentId) =>
            new OSPolicyAssignmentReportName(ResourceNameType.ProjectLocationInstanceAssignment, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), instanceId: gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)), assignmentId: gax::GaxPreconditions.CheckNotNullOrEmpty(assignmentId, nameof(assignmentId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="OSPolicyAssignmentReportName"/> with
        /// pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}/osPolicyAssignments/{assignment}/report</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="assignmentId">The <c>Assignment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="OSPolicyAssignmentReportName"/> with pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}/osPolicyAssignments/{assignment}/report</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string instanceId, string assignmentId) =>
            FormatProjectLocationInstanceAssignment(projectId, locationId, instanceId, assignmentId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="OSPolicyAssignmentReportName"/> with
        /// pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}/osPolicyAssignments/{assignment}/report</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="assignmentId">The <c>Assignment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="OSPolicyAssignmentReportName"/> with pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}/osPolicyAssignments/{assignment}/report</c>.
        /// </returns>
        public static string FormatProjectLocationInstanceAssignment(string projectId, string locationId, string instanceId, string assignmentId) =>
            s_projectLocationInstanceAssignment.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)), gax::GaxPreconditions.CheckNotNullOrEmpty(assignmentId, nameof(assignmentId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="OSPolicyAssignmentReportName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/instances/{instance}/osPolicyAssignments/{assignment}/report</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="oSPolicyAssignmentReportName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <returns>The parsed <see cref="OSPolicyAssignmentReportName"/> if successful.</returns>
        public static OSPolicyAssignmentReportName Parse(string oSPolicyAssignmentReportName) =>
            Parse(oSPolicyAssignmentReportName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="OSPolicyAssignmentReportName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/instances/{instance}/osPolicyAssignments/{assignment}/report</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="oSPolicyAssignmentReportName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="OSPolicyAssignmentReportName"/> if successful.</returns>
        public static OSPolicyAssignmentReportName Parse(string oSPolicyAssignmentReportName, bool allowUnparsed) =>
            TryParse(oSPolicyAssignmentReportName, allowUnparsed, out OSPolicyAssignmentReportName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="OSPolicyAssignmentReportName"/>
        /// instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/instances/{instance}/osPolicyAssignments/{assignment}/report</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="oSPolicyAssignmentReportName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="OSPolicyAssignmentReportName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string oSPolicyAssignmentReportName, out OSPolicyAssignmentReportName result) =>
            TryParse(oSPolicyAssignmentReportName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="OSPolicyAssignmentReportName"/>
        /// instance; optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/instances/{instance}/osPolicyAssignments/{assignment}/report</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="oSPolicyAssignmentReportName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="OSPolicyAssignmentReportName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string oSPolicyAssignmentReportName, bool allowUnparsed, out OSPolicyAssignmentReportName result)
        {
            gax::GaxPreconditions.CheckNotNull(oSPolicyAssignmentReportName, nameof(oSPolicyAssignmentReportName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationInstanceAssignment.TryParseName(oSPolicyAssignmentReportName, out resourceName))
            {
                result = FromProjectLocationInstanceAssignment(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(oSPolicyAssignmentReportName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private OSPolicyAssignmentReportName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string assignmentId = null, string instanceId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AssignmentId = assignmentId;
            InstanceId = instanceId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="OSPolicyAssignmentReportName"/> class from the component parts of
        /// pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}/osPolicyAssignments/{assignment}/report</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="assignmentId">The <c>Assignment</c> ID. Must not be <c>null</c> or empty.</param>
        public OSPolicyAssignmentReportName(string projectId, string locationId, string instanceId, string assignmentId) : this(ResourceNameType.ProjectLocationInstanceAssignment, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), instanceId: gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)), assignmentId: gax::GaxPreconditions.CheckNotNullOrEmpty(assignmentId, nameof(assignmentId)))
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
        /// The <c>Instance</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string InstanceId { get; }

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
                case ResourceNameType.ProjectLocationInstanceAssignment: return s_projectLocationInstanceAssignment.Expand(ProjectId, LocationId, InstanceId, AssignmentId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as OSPolicyAssignmentReportName);

        /// <inheritdoc/>
        public bool Equals(OSPolicyAssignmentReportName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(OSPolicyAssignmentReportName a, OSPolicyAssignmentReportName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(OSPolicyAssignmentReportName a, OSPolicyAssignmentReportName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>InstanceOSPolicyAssignment</c> resource.</summary>
    public sealed partial class InstanceOSPolicyAssignmentName : gax::IResourceName, sys::IEquatable<InstanceOSPolicyAssignmentName>
    {
        /// <summary>The possible contents of <see cref="InstanceOSPolicyAssignmentName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/instances/{instance}/osPolicyAssignments/{assignment}</c>.
            /// </summary>
            ProjectLocationInstanceAssignment = 1,
        }

        private static gax::PathTemplate s_projectLocationInstanceAssignment = new gax::PathTemplate("projects/{project}/locations/{location}/instances/{instance}/osPolicyAssignments/{assignment}");

        /// <summary>
        /// Creates a <see cref="InstanceOSPolicyAssignmentName"/> containing an unparsed resource name.
        /// </summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="InstanceOSPolicyAssignmentName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static InstanceOSPolicyAssignmentName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new InstanceOSPolicyAssignmentName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="InstanceOSPolicyAssignmentName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}/osPolicyAssignments/{assignment}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="assignmentId">The <c>Assignment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// A new instance of <see cref="InstanceOSPolicyAssignmentName"/> constructed from the provided ids.
        /// </returns>
        public static InstanceOSPolicyAssignmentName FromProjectLocationInstanceAssignment(string projectId, string locationId, string instanceId, string assignmentId) =>
            new InstanceOSPolicyAssignmentName(ResourceNameType.ProjectLocationInstanceAssignment, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), instanceId: gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)), assignmentId: gax::GaxPreconditions.CheckNotNullOrEmpty(assignmentId, nameof(assignmentId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="InstanceOSPolicyAssignmentName"/> with
        /// pattern <c>projects/{project}/locations/{location}/instances/{instance}/osPolicyAssignments/{assignment}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="assignmentId">The <c>Assignment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="InstanceOSPolicyAssignmentName"/> with pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}/osPolicyAssignments/{assignment}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string instanceId, string assignmentId) =>
            FormatProjectLocationInstanceAssignment(projectId, locationId, instanceId, assignmentId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="InstanceOSPolicyAssignmentName"/> with
        /// pattern <c>projects/{project}/locations/{location}/instances/{instance}/osPolicyAssignments/{assignment}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="assignmentId">The <c>Assignment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="InstanceOSPolicyAssignmentName"/> with pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}/osPolicyAssignments/{assignment}</c>.
        /// </returns>
        public static string FormatProjectLocationInstanceAssignment(string projectId, string locationId, string instanceId, string assignmentId) =>
            s_projectLocationInstanceAssignment.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)), gax::GaxPreconditions.CheckNotNullOrEmpty(assignmentId, nameof(assignmentId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="InstanceOSPolicyAssignmentName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/instances/{instance}/osPolicyAssignments/{assignment}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="instanceOSPolicyAssignmentName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <returns>The parsed <see cref="InstanceOSPolicyAssignmentName"/> if successful.</returns>
        public static InstanceOSPolicyAssignmentName Parse(string instanceOSPolicyAssignmentName) =>
            Parse(instanceOSPolicyAssignmentName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="InstanceOSPolicyAssignmentName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/instances/{instance}/osPolicyAssignments/{assignment}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="instanceOSPolicyAssignmentName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="InstanceOSPolicyAssignmentName"/> if successful.</returns>
        public static InstanceOSPolicyAssignmentName Parse(string instanceOSPolicyAssignmentName, bool allowUnparsed) =>
            TryParse(instanceOSPolicyAssignmentName, allowUnparsed, out InstanceOSPolicyAssignmentName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="InstanceOSPolicyAssignmentName"/>
        /// instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/instances/{instance}/osPolicyAssignments/{assignment}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="instanceOSPolicyAssignmentName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="InstanceOSPolicyAssignmentName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string instanceOSPolicyAssignmentName, out InstanceOSPolicyAssignmentName result) =>
            TryParse(instanceOSPolicyAssignmentName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="InstanceOSPolicyAssignmentName"/>
        /// instance; optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/instances/{instance}/osPolicyAssignments/{assignment}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="instanceOSPolicyAssignmentName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="InstanceOSPolicyAssignmentName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string instanceOSPolicyAssignmentName, bool allowUnparsed, out InstanceOSPolicyAssignmentName result)
        {
            gax::GaxPreconditions.CheckNotNull(instanceOSPolicyAssignmentName, nameof(instanceOSPolicyAssignmentName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationInstanceAssignment.TryParseName(instanceOSPolicyAssignmentName, out resourceName))
            {
                result = FromProjectLocationInstanceAssignment(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(instanceOSPolicyAssignmentName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private InstanceOSPolicyAssignmentName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string assignmentId = null, string instanceId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AssignmentId = assignmentId;
            InstanceId = instanceId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="InstanceOSPolicyAssignmentName"/> class from the component parts
        /// of pattern <c>projects/{project}/locations/{location}/instances/{instance}/osPolicyAssignments/{assignment}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="assignmentId">The <c>Assignment</c> ID. Must not be <c>null</c> or empty.</param>
        public InstanceOSPolicyAssignmentName(string projectId, string locationId, string instanceId, string assignmentId) : this(ResourceNameType.ProjectLocationInstanceAssignment, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), instanceId: gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)), assignmentId: gax::GaxPreconditions.CheckNotNullOrEmpty(assignmentId, nameof(assignmentId)))
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
        /// The <c>Instance</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string InstanceId { get; }

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
                case ResourceNameType.ProjectLocationInstanceAssignment: return s_projectLocationInstanceAssignment.Expand(ProjectId, LocationId, InstanceId, AssignmentId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as InstanceOSPolicyAssignmentName);

        /// <inheritdoc/>
        public bool Equals(InstanceOSPolicyAssignmentName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(InstanceOSPolicyAssignmentName a, InstanceOSPolicyAssignmentName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(InstanceOSPolicyAssignmentName a, InstanceOSPolicyAssignmentName b) => !(a == b);
    }

    public partial class GetOSPolicyAssignmentReportRequest
    {
        /// <summary>
        /// <see cref="gcov::OSPolicyAssignmentReportName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gcov::OSPolicyAssignmentReportName OSPolicyAssignmentReportName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcov::OSPolicyAssignmentReportName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListOSPolicyAssignmentReportsRequest
    {
        /// <summary>
        /// <see cref="InstanceOSPolicyAssignmentName"/>-typed view over the <see cref="Parent"/> resource name
        /// property.
        /// </summary>
        public InstanceOSPolicyAssignmentName ParentAsInstanceOSPolicyAssignmentName
        {
            get => string.IsNullOrEmpty(Parent) ? null : InstanceOSPolicyAssignmentName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class OSPolicyAssignmentReport
    {
        /// <summary>
        /// <see cref="gcov::OSPolicyAssignmentReportName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gcov::OSPolicyAssignmentReportName OSPolicyAssignmentReportName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcov::OSPolicyAssignmentReportName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="OSPolicyAssignmentName"/>-typed view over the <see cref="OsPolicyAssignment"/> resource name
        /// property.
        /// </summary>
        public OSPolicyAssignmentName OsPolicyAssignmentAsOSPolicyAssignmentName
        {
            get => string.IsNullOrEmpty(OsPolicyAssignment) ? null : OSPolicyAssignmentName.Parse(OsPolicyAssignment, allowUnparsed: true);
            set => OsPolicyAssignment = value?.ToString() ?? "";
        }
    }
}
