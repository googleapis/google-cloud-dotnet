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
using gcnv = Google.Cloud.NetworkSecurity.V1;
using sys = System;

namespace Google.Cloud.NetworkSecurity.V1
{
    /// <summary>Resource name for the <c>MirroringEndpointGroup</c> resource.</summary>
    public sealed partial class MirroringEndpointGroupName : gax::IResourceName, sys::IEquatable<MirroringEndpointGroupName>
    {
        /// <summary>The possible contents of <see cref="MirroringEndpointGroupName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/mirroringEndpointGroups/{mirroring_endpoint_group}</c>.
            /// </summary>
            ProjectLocationMirroringEndpointGroup = 1,
        }

        private static gax::PathTemplate s_projectLocationMirroringEndpointGroup = new gax::PathTemplate("projects/{project}/locations/{location}/mirroringEndpointGroups/{mirroring_endpoint_group}");

        /// <summary>Creates a <see cref="MirroringEndpointGroupName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="MirroringEndpointGroupName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static MirroringEndpointGroupName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new MirroringEndpointGroupName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="MirroringEndpointGroupName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/mirroringEndpointGroups/{mirroring_endpoint_group}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="mirroringEndpointGroupId">
        /// The <c>MirroringEndpointGroup</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="MirroringEndpointGroupName"/> constructed from the provided ids.
        /// </returns>
        public static MirroringEndpointGroupName FromProjectLocationMirroringEndpointGroup(string projectId, string locationId, string mirroringEndpointGroupId) =>
            new MirroringEndpointGroupName(ResourceNameType.ProjectLocationMirroringEndpointGroup, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), mirroringEndpointGroupId: gax::GaxPreconditions.CheckNotNullOrEmpty(mirroringEndpointGroupId, nameof(mirroringEndpointGroupId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="MirroringEndpointGroupName"/> with pattern
        /// <c>projects/{project}/locations/{location}/mirroringEndpointGroups/{mirroring_endpoint_group}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="mirroringEndpointGroupId">
        /// The <c>MirroringEndpointGroup</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="MirroringEndpointGroupName"/> with pattern
        /// <c>projects/{project}/locations/{location}/mirroringEndpointGroups/{mirroring_endpoint_group}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string mirroringEndpointGroupId) =>
            FormatProjectLocationMirroringEndpointGroup(projectId, locationId, mirroringEndpointGroupId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="MirroringEndpointGroupName"/> with pattern
        /// <c>projects/{project}/locations/{location}/mirroringEndpointGroups/{mirroring_endpoint_group}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="mirroringEndpointGroupId">
        /// The <c>MirroringEndpointGroup</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="MirroringEndpointGroupName"/> with pattern
        /// <c>projects/{project}/locations/{location}/mirroringEndpointGroups/{mirroring_endpoint_group}</c>.
        /// </returns>
        public static string FormatProjectLocationMirroringEndpointGroup(string projectId, string locationId, string mirroringEndpointGroupId) =>
            s_projectLocationMirroringEndpointGroup.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(mirroringEndpointGroupId, nameof(mirroringEndpointGroupId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="MirroringEndpointGroupName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/mirroringEndpointGroups/{mirroring_endpoint_group}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="mirroringEndpointGroupName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="MirroringEndpointGroupName"/> if successful.</returns>
        public static MirroringEndpointGroupName Parse(string mirroringEndpointGroupName) =>
            Parse(mirroringEndpointGroupName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="MirroringEndpointGroupName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/mirroringEndpointGroups/{mirroring_endpoint_group}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="mirroringEndpointGroupName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="MirroringEndpointGroupName"/> if successful.</returns>
        public static MirroringEndpointGroupName Parse(string mirroringEndpointGroupName, bool allowUnparsed) =>
            TryParse(mirroringEndpointGroupName, allowUnparsed, out MirroringEndpointGroupName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="MirroringEndpointGroupName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/mirroringEndpointGroups/{mirroring_endpoint_group}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="mirroringEndpointGroupName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="MirroringEndpointGroupName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string mirroringEndpointGroupName, out MirroringEndpointGroupName result) =>
            TryParse(mirroringEndpointGroupName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="MirroringEndpointGroupName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/mirroringEndpointGroups/{mirroring_endpoint_group}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="mirroringEndpointGroupName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="MirroringEndpointGroupName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string mirroringEndpointGroupName, bool allowUnparsed, out MirroringEndpointGroupName result)
        {
            gax::GaxPreconditions.CheckNotNull(mirroringEndpointGroupName, nameof(mirroringEndpointGroupName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationMirroringEndpointGroup.TryParseName(mirroringEndpointGroupName, out resourceName))
            {
                result = FromProjectLocationMirroringEndpointGroup(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(mirroringEndpointGroupName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private MirroringEndpointGroupName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string mirroringEndpointGroupId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            MirroringEndpointGroupId = mirroringEndpointGroupId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="MirroringEndpointGroupName"/> class from the component parts of
        /// pattern <c>projects/{project}/locations/{location}/mirroringEndpointGroups/{mirroring_endpoint_group}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="mirroringEndpointGroupId">
        /// The <c>MirroringEndpointGroup</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public MirroringEndpointGroupName(string projectId, string locationId, string mirroringEndpointGroupId) : this(ResourceNameType.ProjectLocationMirroringEndpointGroup, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), mirroringEndpointGroupId: gax::GaxPreconditions.CheckNotNullOrEmpty(mirroringEndpointGroupId, nameof(mirroringEndpointGroupId)))
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
        /// The <c>MirroringEndpointGroup</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string MirroringEndpointGroupId { get; }

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
                case ResourceNameType.ProjectLocationMirroringEndpointGroup: return s_projectLocationMirroringEndpointGroup.Expand(ProjectId, LocationId, MirroringEndpointGroupId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as MirroringEndpointGroupName);

        /// <inheritdoc/>
        public bool Equals(MirroringEndpointGroupName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(MirroringEndpointGroupName a, MirroringEndpointGroupName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(MirroringEndpointGroupName a, MirroringEndpointGroupName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>MirroringEndpointGroupAssociation</c> resource.</summary>
    public sealed partial class MirroringEndpointGroupAssociationName : gax::IResourceName, sys::IEquatable<MirroringEndpointGroupAssociationName>
    {
        /// <summary>The possible contents of <see cref="MirroringEndpointGroupAssociationName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// projects/{project}/locations/{location}/mirroringEndpointGroupAssociations/{mirroring_endpoint_group_association}</c>
            /// .
            /// </summary>
            ProjectLocationMirroringEndpointGroupAssociation = 1,
        }

        private static gax::PathTemplate s_projectLocationMirroringEndpointGroupAssociation = new gax::PathTemplate("projects/{project}/locations/{location}/mirroringEndpointGroupAssociations/{mirroring_endpoint_group_association}");

        /// <summary>
        /// Creates a <see cref="MirroringEndpointGroupAssociationName"/> containing an unparsed resource name.
        /// </summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="MirroringEndpointGroupAssociationName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static MirroringEndpointGroupAssociationName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new MirroringEndpointGroupAssociationName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="MirroringEndpointGroupAssociationName"/> with the pattern
        /// <c>
        /// projects/{project}/locations/{location}/mirroringEndpointGroupAssociations/{mirroring_endpoint_group_association}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="mirroringEndpointGroupAssociationId">
        /// The <c>MirroringEndpointGroupAssociation</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="MirroringEndpointGroupAssociationName"/> constructed from the provided ids.
        /// </returns>
        public static MirroringEndpointGroupAssociationName FromProjectLocationMirroringEndpointGroupAssociation(string projectId, string locationId, string mirroringEndpointGroupAssociationId) =>
            new MirroringEndpointGroupAssociationName(ResourceNameType.ProjectLocationMirroringEndpointGroupAssociation, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), mirroringEndpointGroupAssociationId: gax::GaxPreconditions.CheckNotNullOrEmpty(mirroringEndpointGroupAssociationId, nameof(mirroringEndpointGroupAssociationId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="MirroringEndpointGroupAssociationName"/>
        /// with pattern
        /// <c>
        /// projects/{project}/locations/{location}/mirroringEndpointGroupAssociations/{mirroring_endpoint_group_association}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="mirroringEndpointGroupAssociationId">
        /// The <c>MirroringEndpointGroupAssociation</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="MirroringEndpointGroupAssociationName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/mirroringEndpointGroupAssociations/{mirroring_endpoint_group_association}</c>
        /// .
        /// </returns>
        public static string Format(string projectId, string locationId, string mirroringEndpointGroupAssociationId) =>
            FormatProjectLocationMirroringEndpointGroupAssociation(projectId, locationId, mirroringEndpointGroupAssociationId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="MirroringEndpointGroupAssociationName"/>
        /// with pattern
        /// <c>
        /// projects/{project}/locations/{location}/mirroringEndpointGroupAssociations/{mirroring_endpoint_group_association}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="mirroringEndpointGroupAssociationId">
        /// The <c>MirroringEndpointGroupAssociation</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="MirroringEndpointGroupAssociationName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/mirroringEndpointGroupAssociations/{mirroring_endpoint_group_association}</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationMirroringEndpointGroupAssociation(string projectId, string locationId, string mirroringEndpointGroupAssociationId) =>
            s_projectLocationMirroringEndpointGroupAssociation.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(mirroringEndpointGroupAssociationId, nameof(mirroringEndpointGroupAssociationId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="MirroringEndpointGroupAssociationName"/>
        /// instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/mirroringEndpointGroupAssociations/{mirroring_endpoint_group_association}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="mirroringEndpointGroupAssociationName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <returns>The parsed <see cref="MirroringEndpointGroupAssociationName"/> if successful.</returns>
        public static MirroringEndpointGroupAssociationName Parse(string mirroringEndpointGroupAssociationName) =>
            Parse(mirroringEndpointGroupAssociationName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="MirroringEndpointGroupAssociationName"/>
        /// instance; optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/mirroringEndpointGroupAssociations/{mirroring_endpoint_group_association}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="mirroringEndpointGroupAssociationName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="MirroringEndpointGroupAssociationName"/> if successful.</returns>
        public static MirroringEndpointGroupAssociationName Parse(string mirroringEndpointGroupAssociationName, bool allowUnparsed) =>
            TryParse(mirroringEndpointGroupAssociationName, allowUnparsed, out MirroringEndpointGroupAssociationName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="MirroringEndpointGroupAssociationName"/>
        /// instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/mirroringEndpointGroupAssociations/{mirroring_endpoint_group_association}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="mirroringEndpointGroupAssociationName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="MirroringEndpointGroupAssociationName"/>, or <c>null</c> if
        /// parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string mirroringEndpointGroupAssociationName, out MirroringEndpointGroupAssociationName result) =>
            TryParse(mirroringEndpointGroupAssociationName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="MirroringEndpointGroupAssociationName"/>
        /// instance; optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/mirroringEndpointGroupAssociations/{mirroring_endpoint_group_association}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="mirroringEndpointGroupAssociationName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="MirroringEndpointGroupAssociationName"/>, or <c>null</c> if
        /// parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string mirroringEndpointGroupAssociationName, bool allowUnparsed, out MirroringEndpointGroupAssociationName result)
        {
            gax::GaxPreconditions.CheckNotNull(mirroringEndpointGroupAssociationName, nameof(mirroringEndpointGroupAssociationName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationMirroringEndpointGroupAssociation.TryParseName(mirroringEndpointGroupAssociationName, out resourceName))
            {
                result = FromProjectLocationMirroringEndpointGroupAssociation(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(mirroringEndpointGroupAssociationName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private MirroringEndpointGroupAssociationName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string mirroringEndpointGroupAssociationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            MirroringEndpointGroupAssociationId = mirroringEndpointGroupAssociationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="MirroringEndpointGroupAssociationName"/> class from the component
        /// parts of pattern
        /// <c>
        /// projects/{project}/locations/{location}/mirroringEndpointGroupAssociations/{mirroring_endpoint_group_association}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="mirroringEndpointGroupAssociationId">
        /// The <c>MirroringEndpointGroupAssociation</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public MirroringEndpointGroupAssociationName(string projectId, string locationId, string mirroringEndpointGroupAssociationId) : this(ResourceNameType.ProjectLocationMirroringEndpointGroupAssociation, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), mirroringEndpointGroupAssociationId: gax::GaxPreconditions.CheckNotNullOrEmpty(mirroringEndpointGroupAssociationId, nameof(mirroringEndpointGroupAssociationId)))
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
        /// The <c>MirroringEndpointGroupAssociation</c> ID. Will not be <c>null</c>, unless this instance contains an
        /// unparsed resource name.
        /// </summary>
        public string MirroringEndpointGroupAssociationId { get; }

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
                case ResourceNameType.ProjectLocationMirroringEndpointGroupAssociation: return s_projectLocationMirroringEndpointGroupAssociation.Expand(ProjectId, LocationId, MirroringEndpointGroupAssociationId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as MirroringEndpointGroupAssociationName);

        /// <inheritdoc/>
        public bool Equals(MirroringEndpointGroupAssociationName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(MirroringEndpointGroupAssociationName a, MirroringEndpointGroupAssociationName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(MirroringEndpointGroupAssociationName a, MirroringEndpointGroupAssociationName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>MirroringDeploymentGroup</c> resource.</summary>
    public sealed partial class MirroringDeploymentGroupName : gax::IResourceName, sys::IEquatable<MirroringDeploymentGroupName>
    {
        /// <summary>The possible contents of <see cref="MirroringDeploymentGroupName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/mirroringDeploymentGroups/{mirroring_deployment_group}</c>.
            /// </summary>
            ProjectLocationMirroringDeploymentGroup = 1,
        }

        private static gax::PathTemplate s_projectLocationMirroringDeploymentGroup = new gax::PathTemplate("projects/{project}/locations/{location}/mirroringDeploymentGroups/{mirroring_deployment_group}");

        /// <summary>
        /// Creates a <see cref="MirroringDeploymentGroupName"/> containing an unparsed resource name.
        /// </summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="MirroringDeploymentGroupName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static MirroringDeploymentGroupName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new MirroringDeploymentGroupName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="MirroringDeploymentGroupName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/mirroringDeploymentGroups/{mirroring_deployment_group}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="mirroringDeploymentGroupId">
        /// The <c>MirroringDeploymentGroup</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="MirroringDeploymentGroupName"/> constructed from the provided ids.
        /// </returns>
        public static MirroringDeploymentGroupName FromProjectLocationMirroringDeploymentGroup(string projectId, string locationId, string mirroringDeploymentGroupId) =>
            new MirroringDeploymentGroupName(ResourceNameType.ProjectLocationMirroringDeploymentGroup, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), mirroringDeploymentGroupId: gax::GaxPreconditions.CheckNotNullOrEmpty(mirroringDeploymentGroupId, nameof(mirroringDeploymentGroupId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="MirroringDeploymentGroupName"/> with
        /// pattern <c>projects/{project}/locations/{location}/mirroringDeploymentGroups/{mirroring_deployment_group}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="mirroringDeploymentGroupId">
        /// The <c>MirroringDeploymentGroup</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="MirroringDeploymentGroupName"/> with pattern
        /// <c>projects/{project}/locations/{location}/mirroringDeploymentGroups/{mirroring_deployment_group}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string mirroringDeploymentGroupId) =>
            FormatProjectLocationMirroringDeploymentGroup(projectId, locationId, mirroringDeploymentGroupId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="MirroringDeploymentGroupName"/> with
        /// pattern <c>projects/{project}/locations/{location}/mirroringDeploymentGroups/{mirroring_deployment_group}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="mirroringDeploymentGroupId">
        /// The <c>MirroringDeploymentGroup</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="MirroringDeploymentGroupName"/> with pattern
        /// <c>projects/{project}/locations/{location}/mirroringDeploymentGroups/{mirroring_deployment_group}</c>.
        /// </returns>
        public static string FormatProjectLocationMirroringDeploymentGroup(string projectId, string locationId, string mirroringDeploymentGroupId) =>
            s_projectLocationMirroringDeploymentGroup.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(mirroringDeploymentGroupId, nameof(mirroringDeploymentGroupId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="MirroringDeploymentGroupName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/mirroringDeploymentGroups/{mirroring_deployment_group}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="mirroringDeploymentGroupName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <returns>The parsed <see cref="MirroringDeploymentGroupName"/> if successful.</returns>
        public static MirroringDeploymentGroupName Parse(string mirroringDeploymentGroupName) =>
            Parse(mirroringDeploymentGroupName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="MirroringDeploymentGroupName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/mirroringDeploymentGroups/{mirroring_deployment_group}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="mirroringDeploymentGroupName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="MirroringDeploymentGroupName"/> if successful.</returns>
        public static MirroringDeploymentGroupName Parse(string mirroringDeploymentGroupName, bool allowUnparsed) =>
            TryParse(mirroringDeploymentGroupName, allowUnparsed, out MirroringDeploymentGroupName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="MirroringDeploymentGroupName"/>
        /// instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/mirroringDeploymentGroups/{mirroring_deployment_group}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="mirroringDeploymentGroupName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="MirroringDeploymentGroupName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string mirroringDeploymentGroupName, out MirroringDeploymentGroupName result) =>
            TryParse(mirroringDeploymentGroupName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="MirroringDeploymentGroupName"/>
        /// instance; optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/mirroringDeploymentGroups/{mirroring_deployment_group}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="mirroringDeploymentGroupName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="MirroringDeploymentGroupName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string mirroringDeploymentGroupName, bool allowUnparsed, out MirroringDeploymentGroupName result)
        {
            gax::GaxPreconditions.CheckNotNull(mirroringDeploymentGroupName, nameof(mirroringDeploymentGroupName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationMirroringDeploymentGroup.TryParseName(mirroringDeploymentGroupName, out resourceName))
            {
                result = FromProjectLocationMirroringDeploymentGroup(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(mirroringDeploymentGroupName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private MirroringDeploymentGroupName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string mirroringDeploymentGroupId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            MirroringDeploymentGroupId = mirroringDeploymentGroupId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="MirroringDeploymentGroupName"/> class from the component parts of
        /// pattern <c>projects/{project}/locations/{location}/mirroringDeploymentGroups/{mirroring_deployment_group}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="mirroringDeploymentGroupId">
        /// The <c>MirroringDeploymentGroup</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public MirroringDeploymentGroupName(string projectId, string locationId, string mirroringDeploymentGroupId) : this(ResourceNameType.ProjectLocationMirroringDeploymentGroup, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), mirroringDeploymentGroupId: gax::GaxPreconditions.CheckNotNullOrEmpty(mirroringDeploymentGroupId, nameof(mirroringDeploymentGroupId)))
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
        /// The <c>MirroringDeploymentGroup</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string MirroringDeploymentGroupId { get; }

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
                case ResourceNameType.ProjectLocationMirroringDeploymentGroup: return s_projectLocationMirroringDeploymentGroup.Expand(ProjectId, LocationId, MirroringDeploymentGroupId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as MirroringDeploymentGroupName);

        /// <inheritdoc/>
        public bool Equals(MirroringDeploymentGroupName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(MirroringDeploymentGroupName a, MirroringDeploymentGroupName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(MirroringDeploymentGroupName a, MirroringDeploymentGroupName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>MirroringDeployment</c> resource.</summary>
    public sealed partial class MirroringDeploymentName : gax::IResourceName, sys::IEquatable<MirroringDeploymentName>
    {
        /// <summary>The possible contents of <see cref="MirroringDeploymentName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/mirroringDeployments/{mirroring_deployment}</c>.
            /// </summary>
            ProjectLocationMirroringDeployment = 1,
        }

        private static gax::PathTemplate s_projectLocationMirroringDeployment = new gax::PathTemplate("projects/{project}/locations/{location}/mirroringDeployments/{mirroring_deployment}");

        /// <summary>Creates a <see cref="MirroringDeploymentName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="MirroringDeploymentName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static MirroringDeploymentName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new MirroringDeploymentName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="MirroringDeploymentName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/mirroringDeployments/{mirroring_deployment}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="mirroringDeploymentId">
        /// The <c>MirroringDeployment</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="MirroringDeploymentName"/> constructed from the provided ids.
        /// </returns>
        public static MirroringDeploymentName FromProjectLocationMirroringDeployment(string projectId, string locationId, string mirroringDeploymentId) =>
            new MirroringDeploymentName(ResourceNameType.ProjectLocationMirroringDeployment, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), mirroringDeploymentId: gax::GaxPreconditions.CheckNotNullOrEmpty(mirroringDeploymentId, nameof(mirroringDeploymentId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="MirroringDeploymentName"/> with pattern
        /// <c>projects/{project}/locations/{location}/mirroringDeployments/{mirroring_deployment}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="mirroringDeploymentId">
        /// The <c>MirroringDeployment</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="MirroringDeploymentName"/> with pattern
        /// <c>projects/{project}/locations/{location}/mirroringDeployments/{mirroring_deployment}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string mirroringDeploymentId) =>
            FormatProjectLocationMirroringDeployment(projectId, locationId, mirroringDeploymentId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="MirroringDeploymentName"/> with pattern
        /// <c>projects/{project}/locations/{location}/mirroringDeployments/{mirroring_deployment}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="mirroringDeploymentId">
        /// The <c>MirroringDeployment</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="MirroringDeploymentName"/> with pattern
        /// <c>projects/{project}/locations/{location}/mirroringDeployments/{mirroring_deployment}</c>.
        /// </returns>
        public static string FormatProjectLocationMirroringDeployment(string projectId, string locationId, string mirroringDeploymentId) =>
            s_projectLocationMirroringDeployment.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(mirroringDeploymentId, nameof(mirroringDeploymentId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="MirroringDeploymentName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/mirroringDeployments/{mirroring_deployment}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="mirroringDeploymentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="MirroringDeploymentName"/> if successful.</returns>
        public static MirroringDeploymentName Parse(string mirroringDeploymentName) => Parse(mirroringDeploymentName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="MirroringDeploymentName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/mirroringDeployments/{mirroring_deployment}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="mirroringDeploymentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="MirroringDeploymentName"/> if successful.</returns>
        public static MirroringDeploymentName Parse(string mirroringDeploymentName, bool allowUnparsed) =>
            TryParse(mirroringDeploymentName, allowUnparsed, out MirroringDeploymentName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="MirroringDeploymentName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/mirroringDeployments/{mirroring_deployment}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="mirroringDeploymentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="MirroringDeploymentName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string mirroringDeploymentName, out MirroringDeploymentName result) =>
            TryParse(mirroringDeploymentName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="MirroringDeploymentName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/mirroringDeployments/{mirroring_deployment}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="mirroringDeploymentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="MirroringDeploymentName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string mirroringDeploymentName, bool allowUnparsed, out MirroringDeploymentName result)
        {
            gax::GaxPreconditions.CheckNotNull(mirroringDeploymentName, nameof(mirroringDeploymentName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationMirroringDeployment.TryParseName(mirroringDeploymentName, out resourceName))
            {
                result = FromProjectLocationMirroringDeployment(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(mirroringDeploymentName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private MirroringDeploymentName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string mirroringDeploymentId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            MirroringDeploymentId = mirroringDeploymentId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="MirroringDeploymentName"/> class from the component parts of
        /// pattern <c>projects/{project}/locations/{location}/mirroringDeployments/{mirroring_deployment}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="mirroringDeploymentId">
        /// The <c>MirroringDeployment</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public MirroringDeploymentName(string projectId, string locationId, string mirroringDeploymentId) : this(ResourceNameType.ProjectLocationMirroringDeployment, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), mirroringDeploymentId: gax::GaxPreconditions.CheckNotNullOrEmpty(mirroringDeploymentId, nameof(mirroringDeploymentId)))
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
        /// The <c>MirroringDeployment</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string MirroringDeploymentId { get; }

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
                case ResourceNameType.ProjectLocationMirroringDeployment: return s_projectLocationMirroringDeployment.Expand(ProjectId, LocationId, MirroringDeploymentId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as MirroringDeploymentName);

        /// <inheritdoc/>
        public bool Equals(MirroringDeploymentName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(MirroringDeploymentName a, MirroringDeploymentName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(MirroringDeploymentName a, MirroringDeploymentName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>ForwardingRule</c> resource.</summary>
    public sealed partial class ForwardingRuleName : gax::IResourceName, sys::IEquatable<ForwardingRuleName>
    {
        /// <summary>The possible contents of <see cref="ForwardingRuleName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/global/forwardingRules/{forwarding_rule}</c>.
            /// </summary>
            ProjectForwardingRule = 1,
        }

        private static gax::PathTemplate s_projectForwardingRule = new gax::PathTemplate("projects/{project}/global/forwardingRules/{forwarding_rule}");

        /// <summary>Creates a <see cref="ForwardingRuleName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ForwardingRuleName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ForwardingRuleName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ForwardingRuleName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ForwardingRuleName"/> with the pattern
        /// <c>projects/{project}/global/forwardingRules/{forwarding_rule}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="forwardingRuleId">The <c>ForwardingRule</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ForwardingRuleName"/> constructed from the provided ids.</returns>
        public static ForwardingRuleName FromProjectForwardingRule(string projectId, string forwardingRuleId) =>
            new ForwardingRuleName(ResourceNameType.ProjectForwardingRule, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), forwardingRuleId: gax::GaxPreconditions.CheckNotNullOrEmpty(forwardingRuleId, nameof(forwardingRuleId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ForwardingRuleName"/> with pattern
        /// <c>projects/{project}/global/forwardingRules/{forwarding_rule}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="forwardingRuleId">The <c>ForwardingRule</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ForwardingRuleName"/> with pattern
        /// <c>projects/{project}/global/forwardingRules/{forwarding_rule}</c>.
        /// </returns>
        public static string Format(string projectId, string forwardingRuleId) =>
            FormatProjectForwardingRule(projectId, forwardingRuleId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ForwardingRuleName"/> with pattern
        /// <c>projects/{project}/global/forwardingRules/{forwarding_rule}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="forwardingRuleId">The <c>ForwardingRule</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ForwardingRuleName"/> with pattern
        /// <c>projects/{project}/global/forwardingRules/{forwarding_rule}</c>.
        /// </returns>
        public static string FormatProjectForwardingRule(string projectId, string forwardingRuleId) =>
            s_projectForwardingRule.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(forwardingRuleId, nameof(forwardingRuleId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ForwardingRuleName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/global/forwardingRules/{forwarding_rule}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="forwardingRuleName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ForwardingRuleName"/> if successful.</returns>
        public static ForwardingRuleName Parse(string forwardingRuleName) => Parse(forwardingRuleName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ForwardingRuleName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/global/forwardingRules/{forwarding_rule}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="forwardingRuleName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ForwardingRuleName"/> if successful.</returns>
        public static ForwardingRuleName Parse(string forwardingRuleName, bool allowUnparsed) =>
            TryParse(forwardingRuleName, allowUnparsed, out ForwardingRuleName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ForwardingRuleName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/global/forwardingRules/{forwarding_rule}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="forwardingRuleName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ForwardingRuleName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string forwardingRuleName, out ForwardingRuleName result) =>
            TryParse(forwardingRuleName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ForwardingRuleName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/global/forwardingRules/{forwarding_rule}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="forwardingRuleName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ForwardingRuleName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string forwardingRuleName, bool allowUnparsed, out ForwardingRuleName result)
        {
            gax::GaxPreconditions.CheckNotNull(forwardingRuleName, nameof(forwardingRuleName));
            gax::TemplatedResourceName resourceName;
            if (s_projectForwardingRule.TryParseName(forwardingRuleName, out resourceName))
            {
                result = FromProjectForwardingRule(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(forwardingRuleName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ForwardingRuleName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string forwardingRuleId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ForwardingRuleId = forwardingRuleId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ForwardingRuleName"/> class from the component parts of pattern
        /// <c>projects/{project}/global/forwardingRules/{forwarding_rule}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="forwardingRuleId">The <c>ForwardingRule</c> ID. Must not be <c>null</c> or empty.</param>
        public ForwardingRuleName(string projectId, string forwardingRuleId) : this(ResourceNameType.ProjectForwardingRule, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), forwardingRuleId: gax::GaxPreconditions.CheckNotNullOrEmpty(forwardingRuleId, nameof(forwardingRuleId)))
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
        /// The <c>ForwardingRule</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string ForwardingRuleId { get; }

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
                case ResourceNameType.ProjectForwardingRule: return s_projectForwardingRule.Expand(ProjectId, ForwardingRuleId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ForwardingRuleName);

        /// <inheritdoc/>
        public bool Equals(ForwardingRuleName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ForwardingRuleName a, ForwardingRuleName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ForwardingRuleName a, ForwardingRuleName b) => !(a == b);
    }

    public partial class MirroringEndpointGroup
    {
        /// <summary>
        /// <see cref="gcnv::MirroringEndpointGroupName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gcnv::MirroringEndpointGroupName MirroringEndpointGroupName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::MirroringEndpointGroupName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="MirroringDeploymentGroupName"/>-typed view over the <see cref="MirroringDeploymentGroup"/>
        /// resource name property.
        /// </summary>
        public MirroringDeploymentGroupName MirroringDeploymentGroupAsMirroringDeploymentGroupName
        {
            get => string.IsNullOrEmpty(MirroringDeploymentGroup) ? null : MirroringDeploymentGroupName.Parse(MirroringDeploymentGroup, allowUnparsed: true);
            set => MirroringDeploymentGroup = value?.ToString() ?? "";
        }

        public partial class Types
        {
            public partial class ConnectedDeploymentGroup
            {
                /// <summary>
                /// <see cref="gcnv::MirroringDeploymentGroupName"/>-typed view over the <see cref="Name"/> resource
                /// name property.
                /// </summary>
                public gcnv::MirroringDeploymentGroupName MirroringDeploymentGroupName
                {
                    get => string.IsNullOrEmpty(Name) ? null : gcnv::MirroringDeploymentGroupName.Parse(Name, allowUnparsed: true);
                    set => Name = value?.ToString() ?? "";
                }
            }

            public partial class AssociationDetails
            {
                /// <summary>
                /// <see cref="gcnv::MirroringEndpointGroupAssociationName"/>-typed view over the <see cref="Name"/>
                /// resource name property.
                /// </summary>
                public gcnv::MirroringEndpointGroupAssociationName MirroringEndpointGroupAssociationName
                {
                    get => string.IsNullOrEmpty(Name) ? null : gcnv::MirroringEndpointGroupAssociationName.Parse(Name, allowUnparsed: true);
                    set => Name = value?.ToString() ?? "";
                }

                /// <summary>
                /// <see cref="NetworkName"/>-typed view over the <see cref="Network"/> resource name property.
                /// </summary>
                public NetworkName NetworkAsNetworkName
                {
                    get => string.IsNullOrEmpty(Network) ? null : NetworkName.Parse(Network, allowUnparsed: true);
                    set => Network = value?.ToString() ?? "";
                }
            }
        }
    }

    public partial class ListMirroringEndpointGroupsRequest
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

    public partial class GetMirroringEndpointGroupRequest
    {
        /// <summary>
        /// <see cref="gcnv::MirroringEndpointGroupName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gcnv::MirroringEndpointGroupName MirroringEndpointGroupName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::MirroringEndpointGroupName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateMirroringEndpointGroupRequest
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

    public partial class DeleteMirroringEndpointGroupRequest
    {
        /// <summary>
        /// <see cref="gcnv::MirroringEndpointGroupName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gcnv::MirroringEndpointGroupName MirroringEndpointGroupName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::MirroringEndpointGroupName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class MirroringEndpointGroupAssociation
    {
        /// <summary>
        /// <see cref="gcnv::MirroringEndpointGroupAssociationName"/>-typed view over the <see cref="Name"/> resource
        /// name property.
        /// </summary>
        public gcnv::MirroringEndpointGroupAssociationName MirroringEndpointGroupAssociationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::MirroringEndpointGroupAssociationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="MirroringEndpointGroupName"/>-typed view over the <see cref="MirroringEndpointGroup"/> resource
        /// name property.
        /// </summary>
        public MirroringEndpointGroupName MirroringEndpointGroupAsMirroringEndpointGroupName
        {
            get => string.IsNullOrEmpty(MirroringEndpointGroup) ? null : MirroringEndpointGroupName.Parse(MirroringEndpointGroup, allowUnparsed: true);
            set => MirroringEndpointGroup = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="NetworkName"/>-typed view over the <see cref="Network"/> resource name property.
        /// </summary>
        public NetworkName NetworkAsNetworkName
        {
            get => string.IsNullOrEmpty(Network) ? null : NetworkName.Parse(Network, allowUnparsed: true);
            set => Network = value?.ToString() ?? "";
        }
    }

    public partial class ListMirroringEndpointGroupAssociationsRequest
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

    public partial class GetMirroringEndpointGroupAssociationRequest
    {
        /// <summary>
        /// <see cref="gcnv::MirroringEndpointGroupAssociationName"/>-typed view over the <see cref="Name"/> resource
        /// name property.
        /// </summary>
        public gcnv::MirroringEndpointGroupAssociationName MirroringEndpointGroupAssociationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::MirroringEndpointGroupAssociationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateMirroringEndpointGroupAssociationRequest
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

    public partial class DeleteMirroringEndpointGroupAssociationRequest
    {
        /// <summary>
        /// <see cref="gcnv::MirroringEndpointGroupAssociationName"/>-typed view over the <see cref="Name"/> resource
        /// name property.
        /// </summary>
        public gcnv::MirroringEndpointGroupAssociationName MirroringEndpointGroupAssociationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::MirroringEndpointGroupAssociationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class MirroringDeploymentGroup
    {
        /// <summary>
        /// <see cref="gcnv::MirroringDeploymentGroupName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gcnv::MirroringDeploymentGroupName MirroringDeploymentGroupName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::MirroringDeploymentGroupName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="NetworkName"/>-typed view over the <see cref="Network"/> resource name property.
        /// </summary>
        public NetworkName NetworkAsNetworkName
        {
            get => string.IsNullOrEmpty(Network) ? null : NetworkName.Parse(Network, allowUnparsed: true);
            set => Network = value?.ToString() ?? "";
        }

        public partial class Types
        {
            public partial class ConnectedEndpointGroup
            {
                /// <summary>
                /// <see cref="gcnv::MirroringEndpointGroupName"/>-typed view over the <see cref="Name"/> resource name
                /// property.
                /// </summary>
                public gcnv::MirroringEndpointGroupName MirroringEndpointGroupName
                {
                    get => string.IsNullOrEmpty(Name) ? null : gcnv::MirroringEndpointGroupName.Parse(Name, allowUnparsed: true);
                    set => Name = value?.ToString() ?? "";
                }
            }

            public partial class Deployment
            {
                /// <summary>
                /// <see cref="gcnv::MirroringDeploymentName"/>-typed view over the <see cref="Name"/> resource name
                /// property.
                /// </summary>
                public gcnv::MirroringDeploymentName MirroringDeploymentName
                {
                    get => string.IsNullOrEmpty(Name) ? null : gcnv::MirroringDeploymentName.Parse(Name, allowUnparsed: true);
                    set => Name = value?.ToString() ?? "";
                }
            }
        }
    }

    public partial class ListMirroringDeploymentGroupsRequest
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

    public partial class GetMirroringDeploymentGroupRequest
    {
        /// <summary>
        /// <see cref="gcnv::MirroringDeploymentGroupName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gcnv::MirroringDeploymentGroupName MirroringDeploymentGroupName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::MirroringDeploymentGroupName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateMirroringDeploymentGroupRequest
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

    public partial class DeleteMirroringDeploymentGroupRequest
    {
        /// <summary>
        /// <see cref="gcnv::MirroringDeploymentGroupName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gcnv::MirroringDeploymentGroupName MirroringDeploymentGroupName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::MirroringDeploymentGroupName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class MirroringDeployment
    {
        /// <summary>
        /// <see cref="gcnv::MirroringDeploymentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcnv::MirroringDeploymentName MirroringDeploymentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::MirroringDeploymentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="ForwardingRuleName"/>-typed view over the <see cref="ForwardingRule"/> resource name property.
        /// </summary>
        public ForwardingRuleName ForwardingRuleAsForwardingRuleName
        {
            get => string.IsNullOrEmpty(ForwardingRule) ? null : ForwardingRuleName.Parse(ForwardingRule, allowUnparsed: true);
            set => ForwardingRule = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="MirroringDeploymentGroupName"/>-typed view over the <see cref="MirroringDeploymentGroup"/>
        /// resource name property.
        /// </summary>
        public MirroringDeploymentGroupName MirroringDeploymentGroupAsMirroringDeploymentGroupName
        {
            get => string.IsNullOrEmpty(MirroringDeploymentGroup) ? null : MirroringDeploymentGroupName.Parse(MirroringDeploymentGroup, allowUnparsed: true);
            set => MirroringDeploymentGroup = value?.ToString() ?? "";
        }
    }

    public partial class ListMirroringDeploymentsRequest
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

    public partial class GetMirroringDeploymentRequest
    {
        /// <summary>
        /// <see cref="gcnv::MirroringDeploymentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcnv::MirroringDeploymentName MirroringDeploymentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::MirroringDeploymentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateMirroringDeploymentRequest
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

    public partial class DeleteMirroringDeploymentRequest
    {
        /// <summary>
        /// <see cref="gcnv::MirroringDeploymentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcnv::MirroringDeploymentName MirroringDeploymentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::MirroringDeploymentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
