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
using gcov = Google.Cloud.OsConfig.V1Alpha;
using sys = System;

namespace Google.Cloud.OsConfig.V1Alpha
{
    /// <summary>Resource name for the <c>OSPolicyAssignment</c> resource.</summary>
    public sealed partial class OSPolicyAssignmentName : gax::IResourceName, sys::IEquatable<OSPolicyAssignmentName>
    {
        /// <summary>The possible contents of <see cref="OSPolicyAssignmentName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/osPolicyAssignments/{os_policy_assignment}</c>.
            /// </summary>
            ProjectLocationOsPolicyAssignment = 1,
        }

        private static gax::PathTemplate s_projectLocationOsPolicyAssignment = new gax::PathTemplate("projects/{project}/locations/{location}/osPolicyAssignments/{os_policy_assignment}");

        /// <summary>Creates a <see cref="OSPolicyAssignmentName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="OSPolicyAssignmentName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static OSPolicyAssignmentName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new OSPolicyAssignmentName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="OSPolicyAssignmentName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/osPolicyAssignments/{os_policy_assignment}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="osPolicyAssignmentId">
        /// The <c>OsPolicyAssignment</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>A new instance of <see cref="OSPolicyAssignmentName"/> constructed from the provided ids.</returns>
        public static OSPolicyAssignmentName FromProjectLocationOsPolicyAssignment(string projectId, string locationId, string osPolicyAssignmentId) =>
            new OSPolicyAssignmentName(ResourceNameType.ProjectLocationOsPolicyAssignment, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), osPolicyAssignmentId: gax::GaxPreconditions.CheckNotNullOrEmpty(osPolicyAssignmentId, nameof(osPolicyAssignmentId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="OSPolicyAssignmentName"/> with pattern
        /// <c>projects/{project}/locations/{location}/osPolicyAssignments/{os_policy_assignment}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="osPolicyAssignmentId">
        /// The <c>OsPolicyAssignment</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="OSPolicyAssignmentName"/> with pattern
        /// <c>projects/{project}/locations/{location}/osPolicyAssignments/{os_policy_assignment}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string osPolicyAssignmentId) =>
            FormatProjectLocationOsPolicyAssignment(projectId, locationId, osPolicyAssignmentId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="OSPolicyAssignmentName"/> with pattern
        /// <c>projects/{project}/locations/{location}/osPolicyAssignments/{os_policy_assignment}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="osPolicyAssignmentId">
        /// The <c>OsPolicyAssignment</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="OSPolicyAssignmentName"/> with pattern
        /// <c>projects/{project}/locations/{location}/osPolicyAssignments/{os_policy_assignment}</c>.
        /// </returns>
        public static string FormatProjectLocationOsPolicyAssignment(string projectId, string locationId, string osPolicyAssignmentId) =>
            s_projectLocationOsPolicyAssignment.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(osPolicyAssignmentId, nameof(osPolicyAssignmentId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="OSPolicyAssignmentName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/osPolicyAssignments/{os_policy_assignment}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="oSPolicyAssignmentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="OSPolicyAssignmentName"/> if successful.</returns>
        public static OSPolicyAssignmentName Parse(string oSPolicyAssignmentName) => Parse(oSPolicyAssignmentName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="OSPolicyAssignmentName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/osPolicyAssignments/{os_policy_assignment}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="oSPolicyAssignmentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="OSPolicyAssignmentName"/> if successful.</returns>
        public static OSPolicyAssignmentName Parse(string oSPolicyAssignmentName, bool allowUnparsed) =>
            TryParse(oSPolicyAssignmentName, allowUnparsed, out OSPolicyAssignmentName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="OSPolicyAssignmentName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/osPolicyAssignments/{os_policy_assignment}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="oSPolicyAssignmentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="OSPolicyAssignmentName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string oSPolicyAssignmentName, out OSPolicyAssignmentName result) =>
            TryParse(oSPolicyAssignmentName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="OSPolicyAssignmentName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/osPolicyAssignments/{os_policy_assignment}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="oSPolicyAssignmentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="OSPolicyAssignmentName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string oSPolicyAssignmentName, bool allowUnparsed, out OSPolicyAssignmentName result)
        {
            gax::GaxPreconditions.CheckNotNull(oSPolicyAssignmentName, nameof(oSPolicyAssignmentName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationOsPolicyAssignment.TryParseName(oSPolicyAssignmentName, out resourceName))
            {
                result = FromProjectLocationOsPolicyAssignment(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(oSPolicyAssignmentName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private OSPolicyAssignmentName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string osPolicyAssignmentId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            OsPolicyAssignmentId = osPolicyAssignmentId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="OSPolicyAssignmentName"/> class from the component parts of
        /// pattern <c>projects/{project}/locations/{location}/osPolicyAssignments/{os_policy_assignment}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="osPolicyAssignmentId">
        /// The <c>OsPolicyAssignment</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public OSPolicyAssignmentName(string projectId, string locationId, string osPolicyAssignmentId) : this(ResourceNameType.ProjectLocationOsPolicyAssignment, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), osPolicyAssignmentId: gax::GaxPreconditions.CheckNotNullOrEmpty(osPolicyAssignmentId, nameof(osPolicyAssignmentId)))
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
        /// The <c>OsPolicyAssignment</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string OsPolicyAssignmentId { get; }

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
                case ResourceNameType.ProjectLocationOsPolicyAssignment: return s_projectLocationOsPolicyAssignment.Expand(ProjectId, LocationId, OsPolicyAssignmentId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as OSPolicyAssignmentName);

        /// <inheritdoc/>
        public bool Equals(OSPolicyAssignmentName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(OSPolicyAssignmentName a, OSPolicyAssignmentName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(OSPolicyAssignmentName a, OSPolicyAssignmentName b) => !(a == b);
    }

    public partial class OSPolicyAssignment
    {
        /// <summary>
        /// <see cref="gcov::OSPolicyAssignmentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcov::OSPolicyAssignmentName OSPolicyAssignmentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcov::OSPolicyAssignmentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class OSPolicyAssignmentOperationMetadata
    {
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

    public partial class CreateOSPolicyAssignmentRequest
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

    public partial class GetOSPolicyAssignmentRequest
    {
        /// <summary>
        /// <see cref="gcov::OSPolicyAssignmentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcov::OSPolicyAssignmentName OSPolicyAssignmentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcov::OSPolicyAssignmentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListOSPolicyAssignmentsRequest
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

    public partial class ListOSPolicyAssignmentRevisionsRequest
    {
        /// <summary>
        /// <see cref="gcov::OSPolicyAssignmentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcov::OSPolicyAssignmentName OSPolicyAssignmentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcov::OSPolicyAssignmentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteOSPolicyAssignmentRequest
    {
        /// <summary>
        /// <see cref="gcov::OSPolicyAssignmentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcov::OSPolicyAssignmentName OSPolicyAssignmentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcov::OSPolicyAssignmentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
