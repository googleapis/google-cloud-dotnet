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
    /// <summary>Resource name for the <c>InterceptEndpointGroup</c> resource.</summary>
    public sealed partial class InterceptEndpointGroupName : gax::IResourceName, sys::IEquatable<InterceptEndpointGroupName>
    {
        /// <summary>The possible contents of <see cref="InterceptEndpointGroupName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/interceptEndpointGroups/{intercept_endpoint_group}</c>.
            /// </summary>
            ProjectLocationInterceptEndpointGroup = 1,
        }

        private static gax::PathTemplate s_projectLocationInterceptEndpointGroup = new gax::PathTemplate("projects/{project}/locations/{location}/interceptEndpointGroups/{intercept_endpoint_group}");

        /// <summary>Creates a <see cref="InterceptEndpointGroupName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="InterceptEndpointGroupName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static InterceptEndpointGroupName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new InterceptEndpointGroupName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="InterceptEndpointGroupName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/interceptEndpointGroups/{intercept_endpoint_group}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="interceptEndpointGroupId">
        /// The <c>InterceptEndpointGroup</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="InterceptEndpointGroupName"/> constructed from the provided ids.
        /// </returns>
        public static InterceptEndpointGroupName FromProjectLocationInterceptEndpointGroup(string projectId, string locationId, string interceptEndpointGroupId) =>
            new InterceptEndpointGroupName(ResourceNameType.ProjectLocationInterceptEndpointGroup, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), interceptEndpointGroupId: gax::GaxPreconditions.CheckNotNullOrEmpty(interceptEndpointGroupId, nameof(interceptEndpointGroupId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="InterceptEndpointGroupName"/> with pattern
        /// <c>projects/{project}/locations/{location}/interceptEndpointGroups/{intercept_endpoint_group}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="interceptEndpointGroupId">
        /// The <c>InterceptEndpointGroup</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="InterceptEndpointGroupName"/> with pattern
        /// <c>projects/{project}/locations/{location}/interceptEndpointGroups/{intercept_endpoint_group}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string interceptEndpointGroupId) =>
            FormatProjectLocationInterceptEndpointGroup(projectId, locationId, interceptEndpointGroupId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="InterceptEndpointGroupName"/> with pattern
        /// <c>projects/{project}/locations/{location}/interceptEndpointGroups/{intercept_endpoint_group}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="interceptEndpointGroupId">
        /// The <c>InterceptEndpointGroup</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="InterceptEndpointGroupName"/> with pattern
        /// <c>projects/{project}/locations/{location}/interceptEndpointGroups/{intercept_endpoint_group}</c>.
        /// </returns>
        public static string FormatProjectLocationInterceptEndpointGroup(string projectId, string locationId, string interceptEndpointGroupId) =>
            s_projectLocationInterceptEndpointGroup.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(interceptEndpointGroupId, nameof(interceptEndpointGroupId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="InterceptEndpointGroupName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/interceptEndpointGroups/{intercept_endpoint_group}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="interceptEndpointGroupName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="InterceptEndpointGroupName"/> if successful.</returns>
        public static InterceptEndpointGroupName Parse(string interceptEndpointGroupName) =>
            Parse(interceptEndpointGroupName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="InterceptEndpointGroupName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/interceptEndpointGroups/{intercept_endpoint_group}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="interceptEndpointGroupName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="InterceptEndpointGroupName"/> if successful.</returns>
        public static InterceptEndpointGroupName Parse(string interceptEndpointGroupName, bool allowUnparsed) =>
            TryParse(interceptEndpointGroupName, allowUnparsed, out InterceptEndpointGroupName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="InterceptEndpointGroupName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/interceptEndpointGroups/{intercept_endpoint_group}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="interceptEndpointGroupName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="InterceptEndpointGroupName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string interceptEndpointGroupName, out InterceptEndpointGroupName result) =>
            TryParse(interceptEndpointGroupName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="InterceptEndpointGroupName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/interceptEndpointGroups/{intercept_endpoint_group}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="interceptEndpointGroupName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="InterceptEndpointGroupName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string interceptEndpointGroupName, bool allowUnparsed, out InterceptEndpointGroupName result)
        {
            gax::GaxPreconditions.CheckNotNull(interceptEndpointGroupName, nameof(interceptEndpointGroupName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationInterceptEndpointGroup.TryParseName(interceptEndpointGroupName, out resourceName))
            {
                result = FromProjectLocationInterceptEndpointGroup(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(interceptEndpointGroupName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private InterceptEndpointGroupName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string interceptEndpointGroupId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            InterceptEndpointGroupId = interceptEndpointGroupId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="InterceptEndpointGroupName"/> class from the component parts of
        /// pattern <c>projects/{project}/locations/{location}/interceptEndpointGroups/{intercept_endpoint_group}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="interceptEndpointGroupId">
        /// The <c>InterceptEndpointGroup</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public InterceptEndpointGroupName(string projectId, string locationId, string interceptEndpointGroupId) : this(ResourceNameType.ProjectLocationInterceptEndpointGroup, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), interceptEndpointGroupId: gax::GaxPreconditions.CheckNotNullOrEmpty(interceptEndpointGroupId, nameof(interceptEndpointGroupId)))
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
        /// The <c>InterceptEndpointGroup</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string InterceptEndpointGroupId { get; }

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
                case ResourceNameType.ProjectLocationInterceptEndpointGroup: return s_projectLocationInterceptEndpointGroup.Expand(ProjectId, LocationId, InterceptEndpointGroupId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as InterceptEndpointGroupName);

        /// <inheritdoc/>
        public bool Equals(InterceptEndpointGroupName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(InterceptEndpointGroupName a, InterceptEndpointGroupName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(InterceptEndpointGroupName a, InterceptEndpointGroupName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>InterceptEndpointGroupAssociation</c> resource.</summary>
    public sealed partial class InterceptEndpointGroupAssociationName : gax::IResourceName, sys::IEquatable<InterceptEndpointGroupAssociationName>
    {
        /// <summary>The possible contents of <see cref="InterceptEndpointGroupAssociationName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// projects/{project}/locations/{location}/interceptEndpointGroupAssociations/{intercept_endpoint_group_association}</c>
            /// .
            /// </summary>
            ProjectLocationInterceptEndpointGroupAssociation = 1,
        }

        private static gax::PathTemplate s_projectLocationInterceptEndpointGroupAssociation = new gax::PathTemplate("projects/{project}/locations/{location}/interceptEndpointGroupAssociations/{intercept_endpoint_group_association}");

        /// <summary>
        /// Creates a <see cref="InterceptEndpointGroupAssociationName"/> containing an unparsed resource name.
        /// </summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="InterceptEndpointGroupAssociationName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static InterceptEndpointGroupAssociationName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new InterceptEndpointGroupAssociationName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="InterceptEndpointGroupAssociationName"/> with the pattern
        /// <c>
        /// projects/{project}/locations/{location}/interceptEndpointGroupAssociations/{intercept_endpoint_group_association}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="interceptEndpointGroupAssociationId">
        /// The <c>InterceptEndpointGroupAssociation</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="InterceptEndpointGroupAssociationName"/> constructed from the provided ids.
        /// </returns>
        public static InterceptEndpointGroupAssociationName FromProjectLocationInterceptEndpointGroupAssociation(string projectId, string locationId, string interceptEndpointGroupAssociationId) =>
            new InterceptEndpointGroupAssociationName(ResourceNameType.ProjectLocationInterceptEndpointGroupAssociation, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), interceptEndpointGroupAssociationId: gax::GaxPreconditions.CheckNotNullOrEmpty(interceptEndpointGroupAssociationId, nameof(interceptEndpointGroupAssociationId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="InterceptEndpointGroupAssociationName"/>
        /// with pattern
        /// <c>
        /// projects/{project}/locations/{location}/interceptEndpointGroupAssociations/{intercept_endpoint_group_association}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="interceptEndpointGroupAssociationId">
        /// The <c>InterceptEndpointGroupAssociation</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="InterceptEndpointGroupAssociationName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/interceptEndpointGroupAssociations/{intercept_endpoint_group_association}</c>
        /// .
        /// </returns>
        public static string Format(string projectId, string locationId, string interceptEndpointGroupAssociationId) =>
            FormatProjectLocationInterceptEndpointGroupAssociation(projectId, locationId, interceptEndpointGroupAssociationId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="InterceptEndpointGroupAssociationName"/>
        /// with pattern
        /// <c>
        /// projects/{project}/locations/{location}/interceptEndpointGroupAssociations/{intercept_endpoint_group_association}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="interceptEndpointGroupAssociationId">
        /// The <c>InterceptEndpointGroupAssociation</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="InterceptEndpointGroupAssociationName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/interceptEndpointGroupAssociations/{intercept_endpoint_group_association}</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationInterceptEndpointGroupAssociation(string projectId, string locationId, string interceptEndpointGroupAssociationId) =>
            s_projectLocationInterceptEndpointGroupAssociation.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(interceptEndpointGroupAssociationId, nameof(interceptEndpointGroupAssociationId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="InterceptEndpointGroupAssociationName"/>
        /// instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/interceptEndpointGroupAssociations/{intercept_endpoint_group_association}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="interceptEndpointGroupAssociationName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <returns>The parsed <see cref="InterceptEndpointGroupAssociationName"/> if successful.</returns>
        public static InterceptEndpointGroupAssociationName Parse(string interceptEndpointGroupAssociationName) =>
            Parse(interceptEndpointGroupAssociationName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="InterceptEndpointGroupAssociationName"/>
        /// instance; optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/interceptEndpointGroupAssociations/{intercept_endpoint_group_association}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="interceptEndpointGroupAssociationName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="InterceptEndpointGroupAssociationName"/> if successful.</returns>
        public static InterceptEndpointGroupAssociationName Parse(string interceptEndpointGroupAssociationName, bool allowUnparsed) =>
            TryParse(interceptEndpointGroupAssociationName, allowUnparsed, out InterceptEndpointGroupAssociationName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="InterceptEndpointGroupAssociationName"/>
        /// instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/interceptEndpointGroupAssociations/{intercept_endpoint_group_association}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="interceptEndpointGroupAssociationName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="InterceptEndpointGroupAssociationName"/>, or <c>null</c> if
        /// parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string interceptEndpointGroupAssociationName, out InterceptEndpointGroupAssociationName result) =>
            TryParse(interceptEndpointGroupAssociationName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="InterceptEndpointGroupAssociationName"/>
        /// instance; optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/interceptEndpointGroupAssociations/{intercept_endpoint_group_association}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="interceptEndpointGroupAssociationName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="InterceptEndpointGroupAssociationName"/>, or <c>null</c> if
        /// parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string interceptEndpointGroupAssociationName, bool allowUnparsed, out InterceptEndpointGroupAssociationName result)
        {
            gax::GaxPreconditions.CheckNotNull(interceptEndpointGroupAssociationName, nameof(interceptEndpointGroupAssociationName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationInterceptEndpointGroupAssociation.TryParseName(interceptEndpointGroupAssociationName, out resourceName))
            {
                result = FromProjectLocationInterceptEndpointGroupAssociation(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(interceptEndpointGroupAssociationName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private InterceptEndpointGroupAssociationName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string interceptEndpointGroupAssociationId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            InterceptEndpointGroupAssociationId = interceptEndpointGroupAssociationId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="InterceptEndpointGroupAssociationName"/> class from the component
        /// parts of pattern
        /// <c>
        /// projects/{project}/locations/{location}/interceptEndpointGroupAssociations/{intercept_endpoint_group_association}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="interceptEndpointGroupAssociationId">
        /// The <c>InterceptEndpointGroupAssociation</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public InterceptEndpointGroupAssociationName(string projectId, string locationId, string interceptEndpointGroupAssociationId) : this(ResourceNameType.ProjectLocationInterceptEndpointGroupAssociation, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), interceptEndpointGroupAssociationId: gax::GaxPreconditions.CheckNotNullOrEmpty(interceptEndpointGroupAssociationId, nameof(interceptEndpointGroupAssociationId)))
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
        /// The <c>InterceptEndpointGroupAssociation</c> ID. Will not be <c>null</c>, unless this instance contains an
        /// unparsed resource name.
        /// </summary>
        public string InterceptEndpointGroupAssociationId { get; }

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
                case ResourceNameType.ProjectLocationInterceptEndpointGroupAssociation: return s_projectLocationInterceptEndpointGroupAssociation.Expand(ProjectId, LocationId, InterceptEndpointGroupAssociationId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as InterceptEndpointGroupAssociationName);

        /// <inheritdoc/>
        public bool Equals(InterceptEndpointGroupAssociationName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(InterceptEndpointGroupAssociationName a, InterceptEndpointGroupAssociationName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(InterceptEndpointGroupAssociationName a, InterceptEndpointGroupAssociationName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>InterceptDeploymentGroup</c> resource.</summary>
    public sealed partial class InterceptDeploymentGroupName : gax::IResourceName, sys::IEquatable<InterceptDeploymentGroupName>
    {
        /// <summary>The possible contents of <see cref="InterceptDeploymentGroupName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/interceptDeploymentGroups/{intercept_deployment_group}</c>.
            /// </summary>
            ProjectLocationInterceptDeploymentGroup = 1,
        }

        private static gax::PathTemplate s_projectLocationInterceptDeploymentGroup = new gax::PathTemplate("projects/{project}/locations/{location}/interceptDeploymentGroups/{intercept_deployment_group}");

        /// <summary>
        /// Creates a <see cref="InterceptDeploymentGroupName"/> containing an unparsed resource name.
        /// </summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="InterceptDeploymentGroupName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static InterceptDeploymentGroupName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new InterceptDeploymentGroupName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="InterceptDeploymentGroupName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/interceptDeploymentGroups/{intercept_deployment_group}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="interceptDeploymentGroupId">
        /// The <c>InterceptDeploymentGroup</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="InterceptDeploymentGroupName"/> constructed from the provided ids.
        /// </returns>
        public static InterceptDeploymentGroupName FromProjectLocationInterceptDeploymentGroup(string projectId, string locationId, string interceptDeploymentGroupId) =>
            new InterceptDeploymentGroupName(ResourceNameType.ProjectLocationInterceptDeploymentGroup, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), interceptDeploymentGroupId: gax::GaxPreconditions.CheckNotNullOrEmpty(interceptDeploymentGroupId, nameof(interceptDeploymentGroupId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="InterceptDeploymentGroupName"/> with
        /// pattern <c>projects/{project}/locations/{location}/interceptDeploymentGroups/{intercept_deployment_group}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="interceptDeploymentGroupId">
        /// The <c>InterceptDeploymentGroup</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="InterceptDeploymentGroupName"/> with pattern
        /// <c>projects/{project}/locations/{location}/interceptDeploymentGroups/{intercept_deployment_group}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string interceptDeploymentGroupId) =>
            FormatProjectLocationInterceptDeploymentGroup(projectId, locationId, interceptDeploymentGroupId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="InterceptDeploymentGroupName"/> with
        /// pattern <c>projects/{project}/locations/{location}/interceptDeploymentGroups/{intercept_deployment_group}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="interceptDeploymentGroupId">
        /// The <c>InterceptDeploymentGroup</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="InterceptDeploymentGroupName"/> with pattern
        /// <c>projects/{project}/locations/{location}/interceptDeploymentGroups/{intercept_deployment_group}</c>.
        /// </returns>
        public static string FormatProjectLocationInterceptDeploymentGroup(string projectId, string locationId, string interceptDeploymentGroupId) =>
            s_projectLocationInterceptDeploymentGroup.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(interceptDeploymentGroupId, nameof(interceptDeploymentGroupId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="InterceptDeploymentGroupName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/interceptDeploymentGroups/{intercept_deployment_group}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="interceptDeploymentGroupName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <returns>The parsed <see cref="InterceptDeploymentGroupName"/> if successful.</returns>
        public static InterceptDeploymentGroupName Parse(string interceptDeploymentGroupName) =>
            Parse(interceptDeploymentGroupName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="InterceptDeploymentGroupName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/interceptDeploymentGroups/{intercept_deployment_group}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="interceptDeploymentGroupName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="InterceptDeploymentGroupName"/> if successful.</returns>
        public static InterceptDeploymentGroupName Parse(string interceptDeploymentGroupName, bool allowUnparsed) =>
            TryParse(interceptDeploymentGroupName, allowUnparsed, out InterceptDeploymentGroupName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="InterceptDeploymentGroupName"/>
        /// instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/interceptDeploymentGroups/{intercept_deployment_group}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="interceptDeploymentGroupName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="InterceptDeploymentGroupName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string interceptDeploymentGroupName, out InterceptDeploymentGroupName result) =>
            TryParse(interceptDeploymentGroupName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="InterceptDeploymentGroupName"/>
        /// instance; optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/interceptDeploymentGroups/{intercept_deployment_group}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="interceptDeploymentGroupName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="InterceptDeploymentGroupName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string interceptDeploymentGroupName, bool allowUnparsed, out InterceptDeploymentGroupName result)
        {
            gax::GaxPreconditions.CheckNotNull(interceptDeploymentGroupName, nameof(interceptDeploymentGroupName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationInterceptDeploymentGroup.TryParseName(interceptDeploymentGroupName, out resourceName))
            {
                result = FromProjectLocationInterceptDeploymentGroup(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(interceptDeploymentGroupName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private InterceptDeploymentGroupName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string interceptDeploymentGroupId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            InterceptDeploymentGroupId = interceptDeploymentGroupId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="InterceptDeploymentGroupName"/> class from the component parts of
        /// pattern <c>projects/{project}/locations/{location}/interceptDeploymentGroups/{intercept_deployment_group}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="interceptDeploymentGroupId">
        /// The <c>InterceptDeploymentGroup</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public InterceptDeploymentGroupName(string projectId, string locationId, string interceptDeploymentGroupId) : this(ResourceNameType.ProjectLocationInterceptDeploymentGroup, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), interceptDeploymentGroupId: gax::GaxPreconditions.CheckNotNullOrEmpty(interceptDeploymentGroupId, nameof(interceptDeploymentGroupId)))
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
        /// The <c>InterceptDeploymentGroup</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string InterceptDeploymentGroupId { get; }

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
                case ResourceNameType.ProjectLocationInterceptDeploymentGroup: return s_projectLocationInterceptDeploymentGroup.Expand(ProjectId, LocationId, InterceptDeploymentGroupId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as InterceptDeploymentGroupName);

        /// <inheritdoc/>
        public bool Equals(InterceptDeploymentGroupName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(InterceptDeploymentGroupName a, InterceptDeploymentGroupName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(InterceptDeploymentGroupName a, InterceptDeploymentGroupName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>InterceptDeployment</c> resource.</summary>
    public sealed partial class InterceptDeploymentName : gax::IResourceName, sys::IEquatable<InterceptDeploymentName>
    {
        /// <summary>The possible contents of <see cref="InterceptDeploymentName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/interceptDeployments/{intercept_deployment}</c>.
            /// </summary>
            ProjectLocationInterceptDeployment = 1,
        }

        private static gax::PathTemplate s_projectLocationInterceptDeployment = new gax::PathTemplate("projects/{project}/locations/{location}/interceptDeployments/{intercept_deployment}");

        /// <summary>Creates a <see cref="InterceptDeploymentName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="InterceptDeploymentName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static InterceptDeploymentName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new InterceptDeploymentName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="InterceptDeploymentName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/interceptDeployments/{intercept_deployment}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="interceptDeploymentId">
        /// The <c>InterceptDeployment</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="InterceptDeploymentName"/> constructed from the provided ids.
        /// </returns>
        public static InterceptDeploymentName FromProjectLocationInterceptDeployment(string projectId, string locationId, string interceptDeploymentId) =>
            new InterceptDeploymentName(ResourceNameType.ProjectLocationInterceptDeployment, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), interceptDeploymentId: gax::GaxPreconditions.CheckNotNullOrEmpty(interceptDeploymentId, nameof(interceptDeploymentId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="InterceptDeploymentName"/> with pattern
        /// <c>projects/{project}/locations/{location}/interceptDeployments/{intercept_deployment}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="interceptDeploymentId">
        /// The <c>InterceptDeployment</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="InterceptDeploymentName"/> with pattern
        /// <c>projects/{project}/locations/{location}/interceptDeployments/{intercept_deployment}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string interceptDeploymentId) =>
            FormatProjectLocationInterceptDeployment(projectId, locationId, interceptDeploymentId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="InterceptDeploymentName"/> with pattern
        /// <c>projects/{project}/locations/{location}/interceptDeployments/{intercept_deployment}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="interceptDeploymentId">
        /// The <c>InterceptDeployment</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="InterceptDeploymentName"/> with pattern
        /// <c>projects/{project}/locations/{location}/interceptDeployments/{intercept_deployment}</c>.
        /// </returns>
        public static string FormatProjectLocationInterceptDeployment(string projectId, string locationId, string interceptDeploymentId) =>
            s_projectLocationInterceptDeployment.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(interceptDeploymentId, nameof(interceptDeploymentId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="InterceptDeploymentName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/interceptDeployments/{intercept_deployment}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="interceptDeploymentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="InterceptDeploymentName"/> if successful.</returns>
        public static InterceptDeploymentName Parse(string interceptDeploymentName) => Parse(interceptDeploymentName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="InterceptDeploymentName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/interceptDeployments/{intercept_deployment}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="interceptDeploymentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="InterceptDeploymentName"/> if successful.</returns>
        public static InterceptDeploymentName Parse(string interceptDeploymentName, bool allowUnparsed) =>
            TryParse(interceptDeploymentName, allowUnparsed, out InterceptDeploymentName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="InterceptDeploymentName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/interceptDeployments/{intercept_deployment}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="interceptDeploymentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="InterceptDeploymentName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string interceptDeploymentName, out InterceptDeploymentName result) =>
            TryParse(interceptDeploymentName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="InterceptDeploymentName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/interceptDeployments/{intercept_deployment}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="interceptDeploymentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="InterceptDeploymentName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string interceptDeploymentName, bool allowUnparsed, out InterceptDeploymentName result)
        {
            gax::GaxPreconditions.CheckNotNull(interceptDeploymentName, nameof(interceptDeploymentName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationInterceptDeployment.TryParseName(interceptDeploymentName, out resourceName))
            {
                result = FromProjectLocationInterceptDeployment(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(interceptDeploymentName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private InterceptDeploymentName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string interceptDeploymentId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            InterceptDeploymentId = interceptDeploymentId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="InterceptDeploymentName"/> class from the component parts of
        /// pattern <c>projects/{project}/locations/{location}/interceptDeployments/{intercept_deployment}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="interceptDeploymentId">
        /// The <c>InterceptDeployment</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public InterceptDeploymentName(string projectId, string locationId, string interceptDeploymentId) : this(ResourceNameType.ProjectLocationInterceptDeployment, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), interceptDeploymentId: gax::GaxPreconditions.CheckNotNullOrEmpty(interceptDeploymentId, nameof(interceptDeploymentId)))
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
        /// The <c>InterceptDeployment</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string InterceptDeploymentId { get; }

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
                case ResourceNameType.ProjectLocationInterceptDeployment: return s_projectLocationInterceptDeployment.Expand(ProjectId, LocationId, InterceptDeploymentId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as InterceptDeploymentName);

        /// <inheritdoc/>
        public bool Equals(InterceptDeploymentName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(InterceptDeploymentName a, InterceptDeploymentName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(InterceptDeploymentName a, InterceptDeploymentName b) => !(a == b);
    }

    public partial class InterceptEndpointGroup
    {
        /// <summary>
        /// <see cref="gcnv::InterceptEndpointGroupName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gcnv::InterceptEndpointGroupName InterceptEndpointGroupName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::InterceptEndpointGroupName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="InterceptDeploymentGroupName"/>-typed view over the <see cref="InterceptDeploymentGroup"/>
        /// resource name property.
        /// </summary>
        public InterceptDeploymentGroupName InterceptDeploymentGroupAsInterceptDeploymentGroupName
        {
            get => string.IsNullOrEmpty(InterceptDeploymentGroup) ? null : InterceptDeploymentGroupName.Parse(InterceptDeploymentGroup, allowUnparsed: true);
            set => InterceptDeploymentGroup = value?.ToString() ?? "";
        }

        public partial class Types
        {
            public partial class ConnectedDeploymentGroup
            {
                /// <summary>
                /// <see cref="gcnv::InterceptDeploymentGroupName"/>-typed view over the <see cref="Name"/> resource
                /// name property.
                /// </summary>
                public gcnv::InterceptDeploymentGroupName InterceptDeploymentGroupName
                {
                    get => string.IsNullOrEmpty(Name) ? null : gcnv::InterceptDeploymentGroupName.Parse(Name, allowUnparsed: true);
                    set => Name = value?.ToString() ?? "";
                }
            }

            public partial class AssociationDetails
            {
                /// <summary>
                /// <see cref="gcnv::InterceptEndpointGroupAssociationName"/>-typed view over the <see cref="Name"/>
                /// resource name property.
                /// </summary>
                public gcnv::InterceptEndpointGroupAssociationName InterceptEndpointGroupAssociationName
                {
                    get => string.IsNullOrEmpty(Name) ? null : gcnv::InterceptEndpointGroupAssociationName.Parse(Name, allowUnparsed: true);
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

    public partial class ListInterceptEndpointGroupsRequest
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

    public partial class GetInterceptEndpointGroupRequest
    {
        /// <summary>
        /// <see cref="gcnv::InterceptEndpointGroupName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gcnv::InterceptEndpointGroupName InterceptEndpointGroupName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::InterceptEndpointGroupName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateInterceptEndpointGroupRequest
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

    public partial class DeleteInterceptEndpointGroupRequest
    {
        /// <summary>
        /// <see cref="gcnv::InterceptEndpointGroupName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gcnv::InterceptEndpointGroupName InterceptEndpointGroupName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::InterceptEndpointGroupName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class InterceptEndpointGroupAssociation
    {
        /// <summary>
        /// <see cref="gcnv::InterceptEndpointGroupAssociationName"/>-typed view over the <see cref="Name"/> resource
        /// name property.
        /// </summary>
        public gcnv::InterceptEndpointGroupAssociationName InterceptEndpointGroupAssociationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::InterceptEndpointGroupAssociationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="InterceptEndpointGroupName"/>-typed view over the <see cref="InterceptEndpointGroup"/> resource
        /// name property.
        /// </summary>
        public InterceptEndpointGroupName InterceptEndpointGroupAsInterceptEndpointGroupName
        {
            get => string.IsNullOrEmpty(InterceptEndpointGroup) ? null : InterceptEndpointGroupName.Parse(InterceptEndpointGroup, allowUnparsed: true);
            set => InterceptEndpointGroup = value?.ToString() ?? "";
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

    public partial class ListInterceptEndpointGroupAssociationsRequest
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

    public partial class GetInterceptEndpointGroupAssociationRequest
    {
        /// <summary>
        /// <see cref="gcnv::InterceptEndpointGroupAssociationName"/>-typed view over the <see cref="Name"/> resource
        /// name property.
        /// </summary>
        public gcnv::InterceptEndpointGroupAssociationName InterceptEndpointGroupAssociationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::InterceptEndpointGroupAssociationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateInterceptEndpointGroupAssociationRequest
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

    public partial class DeleteInterceptEndpointGroupAssociationRequest
    {
        /// <summary>
        /// <see cref="gcnv::InterceptEndpointGroupAssociationName"/>-typed view over the <see cref="Name"/> resource
        /// name property.
        /// </summary>
        public gcnv::InterceptEndpointGroupAssociationName InterceptEndpointGroupAssociationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::InterceptEndpointGroupAssociationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class InterceptDeploymentGroup
    {
        /// <summary>
        /// <see cref="gcnv::InterceptDeploymentGroupName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gcnv::InterceptDeploymentGroupName InterceptDeploymentGroupName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::InterceptDeploymentGroupName.Parse(Name, allowUnparsed: true);
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
                /// <see cref="gcnv::InterceptEndpointGroupName"/>-typed view over the <see cref="Name"/> resource name
                /// property.
                /// </summary>
                public gcnv::InterceptEndpointGroupName InterceptEndpointGroupName
                {
                    get => string.IsNullOrEmpty(Name) ? null : gcnv::InterceptEndpointGroupName.Parse(Name, allowUnparsed: true);
                    set => Name = value?.ToString() ?? "";
                }
            }

            public partial class Deployment
            {
                /// <summary>
                /// <see cref="gcnv::InterceptDeploymentName"/>-typed view over the <see cref="Name"/> resource name
                /// property.
                /// </summary>
                public gcnv::InterceptDeploymentName InterceptDeploymentName
                {
                    get => string.IsNullOrEmpty(Name) ? null : gcnv::InterceptDeploymentName.Parse(Name, allowUnparsed: true);
                    set => Name = value?.ToString() ?? "";
                }
            }
        }
    }

    public partial class ListInterceptDeploymentGroupsRequest
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

    public partial class GetInterceptDeploymentGroupRequest
    {
        /// <summary>
        /// <see cref="gcnv::InterceptDeploymentGroupName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gcnv::InterceptDeploymentGroupName InterceptDeploymentGroupName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::InterceptDeploymentGroupName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateInterceptDeploymentGroupRequest
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

    public partial class DeleteInterceptDeploymentGroupRequest
    {
        /// <summary>
        /// <see cref="gcnv::InterceptDeploymentGroupName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gcnv::InterceptDeploymentGroupName InterceptDeploymentGroupName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::InterceptDeploymentGroupName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class InterceptDeployment
    {
        /// <summary>
        /// <see cref="gcnv::InterceptDeploymentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcnv::InterceptDeploymentName InterceptDeploymentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::InterceptDeploymentName.Parse(Name, allowUnparsed: true);
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
        /// <see cref="InterceptDeploymentGroupName"/>-typed view over the <see cref="InterceptDeploymentGroup"/>
        /// resource name property.
        /// </summary>
        public InterceptDeploymentGroupName InterceptDeploymentGroupAsInterceptDeploymentGroupName
        {
            get => string.IsNullOrEmpty(InterceptDeploymentGroup) ? null : InterceptDeploymentGroupName.Parse(InterceptDeploymentGroup, allowUnparsed: true);
            set => InterceptDeploymentGroup = value?.ToString() ?? "";
        }
    }

    public partial class ListInterceptDeploymentsRequest
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

    public partial class GetInterceptDeploymentRequest
    {
        /// <summary>
        /// <see cref="gcnv::InterceptDeploymentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcnv::InterceptDeploymentName InterceptDeploymentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::InterceptDeploymentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateInterceptDeploymentRequest
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

    public partial class DeleteInterceptDeploymentRequest
    {
        /// <summary>
        /// <see cref="gcnv::InterceptDeploymentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcnv::InterceptDeploymentName InterceptDeploymentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::InterceptDeploymentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
