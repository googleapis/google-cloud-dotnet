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
using gax = Google.Api.Gax;
using sys = System;

namespace Google.Cloud.DesignCenter.V1
{
    /// <summary>Resource name for the <c>Role</c> resource.</summary>
    public sealed partial class RoleName : gax::IResourceName, sys::IEquatable<RoleName>
    {
        /// <summary>The possible contents of <see cref="RoleName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>organizations/{organization}/roles/{role}</c>.</summary>
            OrganizationRole = 1,

            /// <summary>A resource name with pattern <c>projects/{project}/roles/{role}</c>.</summary>
            ProjectRole = 2,

            /// <summary>A resource name with pattern <c>roles/{role}</c>.</summary>
            Role = 3,
        }

        private static gax::PathTemplate s_organizationRole = new gax::PathTemplate("organizations/{organization}/roles/{role}");

        private static gax::PathTemplate s_projectRole = new gax::PathTemplate("projects/{project}/roles/{role}");

        private static gax::PathTemplate s_role = new gax::PathTemplate("roles/{role}");

        /// <summary>Creates a <see cref="RoleName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="RoleName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static RoleName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new RoleName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="RoleName"/> with the pattern <c>organizations/{organization}/roles/{role}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="roleId">The <c>Role</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="RoleName"/> constructed from the provided ids.</returns>
        public static RoleName FromOrganizationRole(string organizationId, string roleId) =>
            new RoleName(ResourceNameType.OrganizationRole, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), roleId: gax::GaxPreconditions.CheckNotNullOrEmpty(roleId, nameof(roleId)));

        /// <summary>Creates a <see cref="RoleName"/> with the pattern <c>projects/{project}/roles/{role}</c>.</summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="roleId">The <c>Role</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="RoleName"/> constructed from the provided ids.</returns>
        public static RoleName FromProjectRole(string projectId, string roleId) =>
            new RoleName(ResourceNameType.ProjectRole, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), roleId: gax::GaxPreconditions.CheckNotNullOrEmpty(roleId, nameof(roleId)));

        /// <summary>Creates a <see cref="RoleName"/> with the pattern <c>roles/{role}</c>.</summary>
        /// <param name="roleId">The <c>Role</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="RoleName"/> constructed from the provided ids.</returns>
        public static RoleName FromRole(string roleId) =>
            new RoleName(ResourceNameType.Role, roleId: gax::GaxPreconditions.CheckNotNullOrEmpty(roleId, nameof(roleId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="RoleName"/> with pattern
        /// <c>organizations/{organization}/roles/{role}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="roleId">The <c>Role</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="RoleName"/> with pattern
        /// <c>organizations/{organization}/roles/{role}</c>.
        /// </returns>
        public static string Format(string organizationId, string roleId) => FormatOrganizationRole(organizationId, roleId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="RoleName"/> with pattern
        /// <c>organizations/{organization}/roles/{role}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="roleId">The <c>Role</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="RoleName"/> with pattern
        /// <c>organizations/{organization}/roles/{role}</c>.
        /// </returns>
        public static string FormatOrganizationRole(string organizationId, string roleId) =>
            s_organizationRole.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(roleId, nameof(roleId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="RoleName"/> with pattern
        /// <c>projects/{project}/roles/{role}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="roleId">The <c>Role</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="RoleName"/> with pattern <c>projects/{project}/roles/{role}</c>
        /// .
        /// </returns>
        public static string FormatProjectRole(string projectId, string roleId) =>
            s_projectRole.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(roleId, nameof(roleId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="RoleName"/> with pattern <c>roles/{role}</c>
        /// .
        /// </summary>
        /// <param name="roleId">The <c>Role</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="RoleName"/> with pattern <c>roles/{role}</c>.
        /// </returns>
        public static string FormatRole(string roleId) =>
            s_role.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(roleId, nameof(roleId)));

        /// <summary>Parses the given resource name string into a new <see cref="RoleName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>organizations/{organization}/roles/{role}</c></description></item>
        /// <item><description><c>projects/{project}/roles/{role}</c></description></item>
        /// <item><description><c>roles/{role}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="roleName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="RoleName"/> if successful.</returns>
        public static RoleName Parse(string roleName) => Parse(roleName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="RoleName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>organizations/{organization}/roles/{role}</c></description></item>
        /// <item><description><c>projects/{project}/roles/{role}</c></description></item>
        /// <item><description><c>roles/{role}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="roleName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="RoleName"/> if successful.</returns>
        public static RoleName Parse(string roleName, bool allowUnparsed) =>
            TryParse(roleName, allowUnparsed, out RoleName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>Tries to parse the given resource name string into a new <see cref="RoleName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>organizations/{organization}/roles/{role}</c></description></item>
        /// <item><description><c>projects/{project}/roles/{role}</c></description></item>
        /// <item><description><c>roles/{role}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="roleName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="RoleName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string roleName, out RoleName result) => TryParse(roleName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="RoleName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>organizations/{organization}/roles/{role}</c></description></item>
        /// <item><description><c>projects/{project}/roles/{role}</c></description></item>
        /// <item><description><c>roles/{role}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="roleName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="RoleName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string roleName, bool allowUnparsed, out RoleName result)
        {
            gax::GaxPreconditions.CheckNotNull(roleName, nameof(roleName));
            gax::TemplatedResourceName resourceName;
            if (s_organizationRole.TryParseName(roleName, out resourceName))
            {
                result = FromOrganizationRole(resourceName[0], resourceName[1]);
                return true;
            }
            if (s_projectRole.TryParseName(roleName, out resourceName))
            {
                result = FromProjectRole(resourceName[0], resourceName[1]);
                return true;
            }
            if (s_role.TryParseName(roleName, out resourceName))
            {
                result = FromRole(resourceName[0]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(roleName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private RoleName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string organizationId = null, string projectId = null, string roleId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            OrganizationId = organizationId;
            ProjectId = projectId;
            RoleId = roleId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="RoleName"/> class from the component parts of pattern
        /// <c>organizations/{organization}/roles/{role}</c>
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="roleId">The <c>Role</c> ID. Must not be <c>null</c> or empty.</param>
        public RoleName(string organizationId, string roleId) : this(ResourceNameType.OrganizationRole, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), roleId: gax::GaxPreconditions.CheckNotNullOrEmpty(roleId, nameof(roleId)))
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
        /// The <c>Organization</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string OrganizationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Role</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string RoleId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.OrganizationRole: return s_organizationRole.Expand(OrganizationId, RoleId);
                case ResourceNameType.ProjectRole: return s_projectRole.Expand(ProjectId, RoleId);
                case ResourceNameType.Role: return s_role.Expand(RoleId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as RoleName);

        /// <inheritdoc/>
        public bool Equals(RoleName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(RoleName a, RoleName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(RoleName a, RoleName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>CloudControl</c> resource.</summary>
    public sealed partial class CloudControlName : gax::IResourceName, sys::IEquatable<CloudControlName>
    {
        /// <summary>The possible contents of <see cref="CloudControlName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>organizations/{organization}/locations/{location}/cloudControls/{cloud_control}</c>.
            /// </summary>
            OrganizationLocationCloudControl = 1,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/cloudControls/{cloud_control}</c>
            /// .
            /// </summary>
            ProjectLocationCloudControl = 2,
        }

        private static gax::PathTemplate s_organizationLocationCloudControl = new gax::PathTemplate("organizations/{organization}/locations/{location}/cloudControls/{cloud_control}");

        private static gax::PathTemplate s_projectLocationCloudControl = new gax::PathTemplate("projects/{project}/locations/{location}/cloudControls/{cloud_control}");

        /// <summary>Creates a <see cref="CloudControlName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="CloudControlName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static CloudControlName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new CloudControlName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="CloudControlName"/> with the pattern
        /// <c>organizations/{organization}/locations/{location}/cloudControls/{cloud_control}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="cloudControlId">The <c>CloudControl</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="CloudControlName"/> constructed from the provided ids.</returns>
        public static CloudControlName FromOrganizationLocationCloudControl(string organizationId, string locationId, string cloudControlId) =>
            new CloudControlName(ResourceNameType.OrganizationLocationCloudControl, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), cloudControlId: gax::GaxPreconditions.CheckNotNullOrEmpty(cloudControlId, nameof(cloudControlId)));

        /// <summary>
        /// Creates a <see cref="CloudControlName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/cloudControls/{cloud_control}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="cloudControlId">The <c>CloudControl</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="CloudControlName"/> constructed from the provided ids.</returns>
        public static CloudControlName FromProjectLocationCloudControl(string projectId, string locationId, string cloudControlId) =>
            new CloudControlName(ResourceNameType.ProjectLocationCloudControl, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), cloudControlId: gax::GaxPreconditions.CheckNotNullOrEmpty(cloudControlId, nameof(cloudControlId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CloudControlName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}/cloudControls/{cloud_control}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="cloudControlId">The <c>CloudControl</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CloudControlName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}/cloudControls/{cloud_control}</c>.
        /// </returns>
        public static string Format(string organizationId, string locationId, string cloudControlId) =>
            FormatOrganizationLocationCloudControl(organizationId, locationId, cloudControlId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CloudControlName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}/cloudControls/{cloud_control}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="cloudControlId">The <c>CloudControl</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CloudControlName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}/cloudControls/{cloud_control}</c>.
        /// </returns>
        public static string FormatOrganizationLocationCloudControl(string organizationId, string locationId, string cloudControlId) =>
            s_organizationLocationCloudControl.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(cloudControlId, nameof(cloudControlId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CloudControlName"/> with pattern
        /// <c>projects/{project}/locations/{location}/cloudControls/{cloud_control}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="cloudControlId">The <c>CloudControl</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CloudControlName"/> with pattern
        /// <c>projects/{project}/locations/{location}/cloudControls/{cloud_control}</c>.
        /// </returns>
        public static string FormatProjectLocationCloudControl(string projectId, string locationId, string cloudControlId) =>
            s_projectLocationCloudControl.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(cloudControlId, nameof(cloudControlId)));

        /// <summary>Parses the given resource name string into a new <see cref="CloudControlName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/cloudControls/{cloud_control}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/cloudControls/{cloud_control}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="cloudControlName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="CloudControlName"/> if successful.</returns>
        public static CloudControlName Parse(string cloudControlName) => Parse(cloudControlName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CloudControlName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/cloudControls/{cloud_control}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/cloudControls/{cloud_control}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="cloudControlName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="CloudControlName"/> if successful.</returns>
        public static CloudControlName Parse(string cloudControlName, bool allowUnparsed) =>
            TryParse(cloudControlName, allowUnparsed, out CloudControlName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CloudControlName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/cloudControls/{cloud_control}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/cloudControls/{cloud_control}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="cloudControlName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CloudControlName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string cloudControlName, out CloudControlName result) =>
            TryParse(cloudControlName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CloudControlName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/cloudControls/{cloud_control}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/cloudControls/{cloud_control}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="cloudControlName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CloudControlName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string cloudControlName, bool allowUnparsed, out CloudControlName result)
        {
            gax::GaxPreconditions.CheckNotNull(cloudControlName, nameof(cloudControlName));
            gax::TemplatedResourceName resourceName;
            if (s_organizationLocationCloudControl.TryParseName(cloudControlName, out resourceName))
            {
                result = FromOrganizationLocationCloudControl(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (s_projectLocationCloudControl.TryParseName(cloudControlName, out resourceName))
            {
                result = FromProjectLocationCloudControl(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(cloudControlName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private CloudControlName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string cloudControlId = null, string locationId = null, string organizationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CloudControlId = cloudControlId;
            LocationId = locationId;
            OrganizationId = organizationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="CloudControlName"/> class from the component parts of pattern
        /// <c>organizations/{organization}/locations/{location}/cloudControls/{cloud_control}</c>
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="cloudControlId">The <c>CloudControl</c> ID. Must not be <c>null</c> or empty.</param>
        public CloudControlName(string organizationId, string locationId, string cloudControlId) : this(ResourceNameType.OrganizationLocationCloudControl, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), cloudControlId: gax::GaxPreconditions.CheckNotNullOrEmpty(cloudControlId, nameof(cloudControlId)))
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
        /// The <c>CloudControl</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string CloudControlId { get; }

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
                case ResourceNameType.OrganizationLocationCloudControl: return s_organizationLocationCloudControl.Expand(OrganizationId, LocationId, CloudControlId);
                case ResourceNameType.ProjectLocationCloudControl: return s_projectLocationCloudControl.Expand(ProjectId, LocationId, CloudControlId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as CloudControlName);

        /// <inheritdoc/>
        public bool Equals(CloudControlName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(CloudControlName a, CloudControlName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(CloudControlName a, CloudControlName b) => !(a == b);
    }
}
