// Copyright 2026 Google LLC
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
using gcov = Google.Cloud.OracleDatabase.V1;
using sys = System;

namespace Google.Cloud.OracleDatabase.V1
{
    /// <summary>Resource name for the <c>GoldengateConnectionAssignment</c> resource.</summary>
    public sealed partial class GoldengateConnectionAssignmentName : gax::IResourceName, sys::IEquatable<GoldengateConnectionAssignmentName>
    {
        /// <summary>The possible contents of <see cref="GoldengateConnectionAssignmentName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// projects/{project}/locations/{location}/goldengateConnectionAssignments/{goldengate_connection_assignment}</c>
            /// .
            /// </summary>
            ProjectLocationGoldengateConnectionAssignment = 1,
        }

        private static gax::PathTemplate s_projectLocationGoldengateConnectionAssignment = new gax::PathTemplate("projects/{project}/locations/{location}/goldengateConnectionAssignments/{goldengate_connection_assignment}");

        /// <summary>
        /// Creates a <see cref="GoldengateConnectionAssignmentName"/> containing an unparsed resource name.
        /// </summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="GoldengateConnectionAssignmentName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static GoldengateConnectionAssignmentName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new GoldengateConnectionAssignmentName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="GoldengateConnectionAssignmentName"/> with the pattern
        /// <c>
        /// projects/{project}/locations/{location}/goldengateConnectionAssignments/{goldengate_connection_assignment}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="goldengateConnectionAssignmentId">
        /// The <c>GoldengateConnectionAssignment</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="GoldengateConnectionAssignmentName"/> constructed from the provided ids.
        /// </returns>
        public static GoldengateConnectionAssignmentName FromProjectLocationGoldengateConnectionAssignment(string projectId, string locationId, string goldengateConnectionAssignmentId) =>
            new GoldengateConnectionAssignmentName(ResourceNameType.ProjectLocationGoldengateConnectionAssignment, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), goldengateConnectionAssignmentId: gax::GaxPreconditions.CheckNotNullOrEmpty(goldengateConnectionAssignmentId, nameof(goldengateConnectionAssignmentId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="GoldengateConnectionAssignmentName"/> with
        /// pattern
        /// <c>
        /// projects/{project}/locations/{location}/goldengateConnectionAssignments/{goldengate_connection_assignment}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="goldengateConnectionAssignmentId">
        /// The <c>GoldengateConnectionAssignment</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="GoldengateConnectionAssignmentName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/goldengateConnectionAssignments/{goldengate_connection_assignment}</c>
        /// .
        /// </returns>
        public static string Format(string projectId, string locationId, string goldengateConnectionAssignmentId) =>
            FormatProjectLocationGoldengateConnectionAssignment(projectId, locationId, goldengateConnectionAssignmentId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="GoldengateConnectionAssignmentName"/> with
        /// pattern
        /// <c>
        /// projects/{project}/locations/{location}/goldengateConnectionAssignments/{goldengate_connection_assignment}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="goldengateConnectionAssignmentId">
        /// The <c>GoldengateConnectionAssignment</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="GoldengateConnectionAssignmentName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/goldengateConnectionAssignments/{goldengate_connection_assignment}</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationGoldengateConnectionAssignment(string projectId, string locationId, string goldengateConnectionAssignmentId) =>
            s_projectLocationGoldengateConnectionAssignment.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(goldengateConnectionAssignmentId, nameof(goldengateConnectionAssignmentId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="GoldengateConnectionAssignmentName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/goldengateConnectionAssignments/{goldengate_connection_assignment}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="goldengateConnectionAssignmentName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <returns>The parsed <see cref="GoldengateConnectionAssignmentName"/> if successful.</returns>
        public static GoldengateConnectionAssignmentName Parse(string goldengateConnectionAssignmentName) =>
            Parse(goldengateConnectionAssignmentName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="GoldengateConnectionAssignmentName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/goldengateConnectionAssignments/{goldengate_connection_assignment}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="goldengateConnectionAssignmentName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="GoldengateConnectionAssignmentName"/> if successful.</returns>
        public static GoldengateConnectionAssignmentName Parse(string goldengateConnectionAssignmentName, bool allowUnparsed) =>
            TryParse(goldengateConnectionAssignmentName, allowUnparsed, out GoldengateConnectionAssignmentName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="GoldengateConnectionAssignmentName"/>
        /// instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/goldengateConnectionAssignments/{goldengate_connection_assignment}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="goldengateConnectionAssignmentName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="GoldengateConnectionAssignmentName"/>, or <c>null</c> if
        /// parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string goldengateConnectionAssignmentName, out GoldengateConnectionAssignmentName result) =>
            TryParse(goldengateConnectionAssignmentName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="GoldengateConnectionAssignmentName"/>
        /// instance; optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/goldengateConnectionAssignments/{goldengate_connection_assignment}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="goldengateConnectionAssignmentName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="GoldengateConnectionAssignmentName"/>, or <c>null</c> if
        /// parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string goldengateConnectionAssignmentName, bool allowUnparsed, out GoldengateConnectionAssignmentName result)
        {
            gax::GaxPreconditions.CheckNotNull(goldengateConnectionAssignmentName, nameof(goldengateConnectionAssignmentName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationGoldengateConnectionAssignment.TryParseName(goldengateConnectionAssignmentName, out resourceName))
            {
                result = FromProjectLocationGoldengateConnectionAssignment(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(goldengateConnectionAssignmentName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private GoldengateConnectionAssignmentName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string goldengateConnectionAssignmentId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            GoldengateConnectionAssignmentId = goldengateConnectionAssignmentId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="GoldengateConnectionAssignmentName"/> class from the component
        /// parts of pattern
        /// <c>
        /// projects/{project}/locations/{location}/goldengateConnectionAssignments/{goldengate_connection_assignment}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="goldengateConnectionAssignmentId">
        /// The <c>GoldengateConnectionAssignment</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public GoldengateConnectionAssignmentName(string projectId, string locationId, string goldengateConnectionAssignmentId) : this(ResourceNameType.ProjectLocationGoldengateConnectionAssignment, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), goldengateConnectionAssignmentId: gax::GaxPreconditions.CheckNotNullOrEmpty(goldengateConnectionAssignmentId, nameof(goldengateConnectionAssignmentId)))
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
        /// The <c>GoldengateConnectionAssignment</c> ID. Will not be <c>null</c>, unless this instance contains an
        /// unparsed resource name.
        /// </summary>
        public string GoldengateConnectionAssignmentId { get; }

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
                case ResourceNameType.ProjectLocationGoldengateConnectionAssignment: return s_projectLocationGoldengateConnectionAssignment.Expand(ProjectId, LocationId, GoldengateConnectionAssignmentId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as GoldengateConnectionAssignmentName);

        /// <inheritdoc/>
        public bool Equals(GoldengateConnectionAssignmentName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(GoldengateConnectionAssignmentName a, GoldengateConnectionAssignmentName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(GoldengateConnectionAssignmentName a, GoldengateConnectionAssignmentName b) => !(a == b);
    }

    public partial class GoldengateConnectionAssignment
    {
        /// <summary>
        /// <see cref="gcov::GoldengateConnectionAssignmentName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gcov::GoldengateConnectionAssignmentName GoldengateConnectionAssignmentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcov::GoldengateConnectionAssignmentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GoldengateConnectionAssignmentProperties
    {
        /// <summary>
        /// <see cref="GoldengateConnectionName"/>-typed view over the <see cref="GoldengateConnection"/> resource name
        /// property.
        /// </summary>
        public GoldengateConnectionName GoldengateConnectionAsGoldengateConnectionName
        {
            get => string.IsNullOrEmpty(GoldengateConnection) ? null : GoldengateConnectionName.Parse(GoldengateConnection, allowUnparsed: true);
            set => GoldengateConnection = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="GoldengateDeploymentName"/>-typed view over the <see cref="GoldengateDeployment"/> resource name
        /// property.
        /// </summary>
        public GoldengateDeploymentName GoldengateDeploymentAsGoldengateDeploymentName
        {
            get => string.IsNullOrEmpty(GoldengateDeployment) ? null : GoldengateDeploymentName.Parse(GoldengateDeployment, allowUnparsed: true);
            set => GoldengateDeployment = value?.ToString() ?? "";
        }
    }

    public partial class ListGoldengateConnectionAssignmentsRequest
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

    public partial class GetGoldengateConnectionAssignmentRequest
    {
        /// <summary>
        /// <see cref="gcov::GoldengateConnectionAssignmentName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gcov::GoldengateConnectionAssignmentName GoldengateConnectionAssignmentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcov::GoldengateConnectionAssignmentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateGoldengateConnectionAssignmentRequest
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

    public partial class TestGoldengateConnectionAssignmentRequest
    {
        /// <summary>
        /// <see cref="gcov::GoldengateConnectionAssignmentName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gcov::GoldengateConnectionAssignmentName GoldengateConnectionAssignmentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcov::GoldengateConnectionAssignmentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteGoldengateConnectionAssignmentRequest
    {
        /// <summary>
        /// <see cref="gcov::GoldengateConnectionAssignmentName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gcov::GoldengateConnectionAssignmentName GoldengateConnectionAssignmentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcov::GoldengateConnectionAssignmentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
