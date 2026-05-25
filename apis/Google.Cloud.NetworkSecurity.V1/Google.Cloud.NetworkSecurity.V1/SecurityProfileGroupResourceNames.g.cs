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
using gcnv = Google.Cloud.NetworkSecurity.V1;
using sys = System;

namespace Google.Cloud.NetworkSecurity.V1
{
    /// <summary>Resource name for the <c>SecurityProfileGroup</c> resource.</summary>
    public sealed partial class SecurityProfileGroupName : gax::IResourceName, sys::IEquatable<SecurityProfileGroupName>
    {
        /// <summary>The possible contents of <see cref="SecurityProfileGroupName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>organizations/{organization}/locations/{location}/securityProfileGroups/{security_profile_group}</c>.
            /// </summary>
            OrganizationLocationSecurityProfileGroup = 1,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/securityProfileGroups/{security_profile_group}</c>.
            /// </summary>
            ProjectLocationSecurityProfileGroup = 2,
        }

        private static gax::PathTemplate s_organizationLocationSecurityProfileGroup = new gax::PathTemplate("organizations/{organization}/locations/{location}/securityProfileGroups/{security_profile_group}");

        private static gax::PathTemplate s_projectLocationSecurityProfileGroup = new gax::PathTemplate("projects/{project}/locations/{location}/securityProfileGroups/{security_profile_group}");

        /// <summary>Creates a <see cref="SecurityProfileGroupName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="SecurityProfileGroupName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static SecurityProfileGroupName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new SecurityProfileGroupName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="SecurityProfileGroupName"/> with the pattern
        /// <c>organizations/{organization}/locations/{location}/securityProfileGroups/{security_profile_group}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="securityProfileGroupId">
        /// The <c>SecurityProfileGroup</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="SecurityProfileGroupName"/> constructed from the provided ids.
        /// </returns>
        public static SecurityProfileGroupName FromOrganizationLocationSecurityProfileGroup(string organizationId, string locationId, string securityProfileGroupId) =>
            new SecurityProfileGroupName(ResourceNameType.OrganizationLocationSecurityProfileGroup, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), securityProfileGroupId: gax::GaxPreconditions.CheckNotNullOrEmpty(securityProfileGroupId, nameof(securityProfileGroupId)));

        /// <summary>
        /// Creates a <see cref="SecurityProfileGroupName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/securityProfileGroups/{security_profile_group}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="securityProfileGroupId">
        /// The <c>SecurityProfileGroup</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="SecurityProfileGroupName"/> constructed from the provided ids.
        /// </returns>
        public static SecurityProfileGroupName FromProjectLocationSecurityProfileGroup(string projectId, string locationId, string securityProfileGroupId) =>
            new SecurityProfileGroupName(ResourceNameType.ProjectLocationSecurityProfileGroup, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), securityProfileGroupId: gax::GaxPreconditions.CheckNotNullOrEmpty(securityProfileGroupId, nameof(securityProfileGroupId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SecurityProfileGroupName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}/securityProfileGroups/{security_profile_group}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="securityProfileGroupId">
        /// The <c>SecurityProfileGroup</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="SecurityProfileGroupName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}/securityProfileGroups/{security_profile_group}</c>.
        /// </returns>
        public static string Format(string organizationId, string locationId, string securityProfileGroupId) =>
            FormatOrganizationLocationSecurityProfileGroup(organizationId, locationId, securityProfileGroupId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SecurityProfileGroupName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}/securityProfileGroups/{security_profile_group}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="securityProfileGroupId">
        /// The <c>SecurityProfileGroup</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="SecurityProfileGroupName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}/securityProfileGroups/{security_profile_group}</c>.
        /// </returns>
        public static string FormatOrganizationLocationSecurityProfileGroup(string organizationId, string locationId, string securityProfileGroupId) =>
            s_organizationLocationSecurityProfileGroup.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(securityProfileGroupId, nameof(securityProfileGroupId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SecurityProfileGroupName"/> with pattern
        /// <c>projects/{project}/locations/{location}/securityProfileGroups/{security_profile_group}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="securityProfileGroupId">
        /// The <c>SecurityProfileGroup</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="SecurityProfileGroupName"/> with pattern
        /// <c>projects/{project}/locations/{location}/securityProfileGroups/{security_profile_group}</c>.
        /// </returns>
        public static string FormatProjectLocationSecurityProfileGroup(string projectId, string locationId, string securityProfileGroupId) =>
            s_projectLocationSecurityProfileGroup.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(securityProfileGroupId, nameof(securityProfileGroupId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="SecurityProfileGroupName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/securityProfileGroups/{security_profile_group}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/securityProfileGroups/{security_profile_group}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="securityProfileGroupName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="SecurityProfileGroupName"/> if successful.</returns>
        public static SecurityProfileGroupName Parse(string securityProfileGroupName) =>
            Parse(securityProfileGroupName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="SecurityProfileGroupName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/securityProfileGroups/{security_profile_group}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/securityProfileGroups/{security_profile_group}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="securityProfileGroupName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="SecurityProfileGroupName"/> if successful.</returns>
        public static SecurityProfileGroupName Parse(string securityProfileGroupName, bool allowUnparsed) =>
            TryParse(securityProfileGroupName, allowUnparsed, out SecurityProfileGroupName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SecurityProfileGroupName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/securityProfileGroups/{security_profile_group}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/securityProfileGroups/{security_profile_group}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="securityProfileGroupName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SecurityProfileGroupName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string securityProfileGroupName, out SecurityProfileGroupName result) =>
            TryParse(securityProfileGroupName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SecurityProfileGroupName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/securityProfileGroups/{security_profile_group}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/securityProfileGroups/{security_profile_group}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="securityProfileGroupName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SecurityProfileGroupName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string securityProfileGroupName, bool allowUnparsed, out SecurityProfileGroupName result)
        {
            gax::GaxPreconditions.CheckNotNull(securityProfileGroupName, nameof(securityProfileGroupName));
            gax::TemplatedResourceName resourceName;
            if (s_organizationLocationSecurityProfileGroup.TryParseName(securityProfileGroupName, out resourceName))
            {
                result = FromOrganizationLocationSecurityProfileGroup(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (s_projectLocationSecurityProfileGroup.TryParseName(securityProfileGroupName, out resourceName))
            {
                result = FromProjectLocationSecurityProfileGroup(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(securityProfileGroupName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private SecurityProfileGroupName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string organizationId = null, string projectId = null, string securityProfileGroupId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            OrganizationId = organizationId;
            ProjectId = projectId;
            SecurityProfileGroupId = securityProfileGroupId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="SecurityProfileGroupName"/> class from the component parts of
        /// pattern <c>organizations/{organization}/locations/{location}/securityProfileGroups/{security_profile_group}</c>
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="securityProfileGroupId">
        /// The <c>SecurityProfileGroup</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public SecurityProfileGroupName(string organizationId, string locationId, string securityProfileGroupId) : this(ResourceNameType.OrganizationLocationSecurityProfileGroup, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), securityProfileGroupId: gax::GaxPreconditions.CheckNotNullOrEmpty(securityProfileGroupId, nameof(securityProfileGroupId)))
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
        /// The <c>SecurityProfileGroup</c> ID. May be <c>null</c>, depending on which resource name is contained by
        /// this instance.
        /// </summary>
        public string SecurityProfileGroupId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.OrganizationLocationSecurityProfileGroup: return s_organizationLocationSecurityProfileGroup.Expand(OrganizationId, LocationId, SecurityProfileGroupId);
                case ResourceNameType.ProjectLocationSecurityProfileGroup: return s_projectLocationSecurityProfileGroup.Expand(ProjectId, LocationId, SecurityProfileGroupId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as SecurityProfileGroupName);

        /// <inheritdoc/>
        public bool Equals(SecurityProfileGroupName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(SecurityProfileGroupName a, SecurityProfileGroupName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(SecurityProfileGroupName a, SecurityProfileGroupName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>SecurityProfile</c> resource.</summary>
    public sealed partial class SecurityProfileName : gax::IResourceName, sys::IEquatable<SecurityProfileName>
    {
        /// <summary>The possible contents of <see cref="SecurityProfileName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>organizations/{organization}/locations/{location}/securityProfiles/{security_profile}</c>.
            /// </summary>
            OrganizationLocationSecurityProfile = 1,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/securityProfiles/{security_profile}</c>.
            /// </summary>
            ProjectLocationSecurityProfile = 2,
        }

        private static gax::PathTemplate s_organizationLocationSecurityProfile = new gax::PathTemplate("organizations/{organization}/locations/{location}/securityProfiles/{security_profile}");

        private static gax::PathTemplate s_projectLocationSecurityProfile = new gax::PathTemplate("projects/{project}/locations/{location}/securityProfiles/{security_profile}");

        /// <summary>Creates a <see cref="SecurityProfileName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="SecurityProfileName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static SecurityProfileName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new SecurityProfileName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="SecurityProfileName"/> with the pattern
        /// <c>organizations/{organization}/locations/{location}/securityProfiles/{security_profile}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="securityProfileId">The <c>SecurityProfile</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="SecurityProfileName"/> constructed from the provided ids.</returns>
        public static SecurityProfileName FromOrganizationLocationSecurityProfile(string organizationId, string locationId, string securityProfileId) =>
            new SecurityProfileName(ResourceNameType.OrganizationLocationSecurityProfile, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), securityProfileId: gax::GaxPreconditions.CheckNotNullOrEmpty(securityProfileId, nameof(securityProfileId)));

        /// <summary>
        /// Creates a <see cref="SecurityProfileName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/securityProfiles/{security_profile}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="securityProfileId">The <c>SecurityProfile</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="SecurityProfileName"/> constructed from the provided ids.</returns>
        public static SecurityProfileName FromProjectLocationSecurityProfile(string projectId, string locationId, string securityProfileId) =>
            new SecurityProfileName(ResourceNameType.ProjectLocationSecurityProfile, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), securityProfileId: gax::GaxPreconditions.CheckNotNullOrEmpty(securityProfileId, nameof(securityProfileId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SecurityProfileName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}/securityProfiles/{security_profile}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="securityProfileId">The <c>SecurityProfile</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SecurityProfileName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}/securityProfiles/{security_profile}</c>.
        /// </returns>
        public static string Format(string organizationId, string locationId, string securityProfileId) =>
            FormatOrganizationLocationSecurityProfile(organizationId, locationId, securityProfileId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SecurityProfileName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}/securityProfiles/{security_profile}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="securityProfileId">The <c>SecurityProfile</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SecurityProfileName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}/securityProfiles/{security_profile}</c>.
        /// </returns>
        public static string FormatOrganizationLocationSecurityProfile(string organizationId, string locationId, string securityProfileId) =>
            s_organizationLocationSecurityProfile.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(securityProfileId, nameof(securityProfileId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SecurityProfileName"/> with pattern
        /// <c>projects/{project}/locations/{location}/securityProfiles/{security_profile}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="securityProfileId">The <c>SecurityProfile</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SecurityProfileName"/> with pattern
        /// <c>projects/{project}/locations/{location}/securityProfiles/{security_profile}</c>.
        /// </returns>
        public static string FormatProjectLocationSecurityProfile(string projectId, string locationId, string securityProfileId) =>
            s_projectLocationSecurityProfile.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(securityProfileId, nameof(securityProfileId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="SecurityProfileName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/securityProfiles/{security_profile}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/securityProfiles/{security_profile}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="securityProfileName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="SecurityProfileName"/> if successful.</returns>
        public static SecurityProfileName Parse(string securityProfileName) => Parse(securityProfileName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="SecurityProfileName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/securityProfiles/{security_profile}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/securityProfiles/{security_profile}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="securityProfileName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="SecurityProfileName"/> if successful.</returns>
        public static SecurityProfileName Parse(string securityProfileName, bool allowUnparsed) =>
            TryParse(securityProfileName, allowUnparsed, out SecurityProfileName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SecurityProfileName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/securityProfiles/{security_profile}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/securityProfiles/{security_profile}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="securityProfileName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SecurityProfileName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string securityProfileName, out SecurityProfileName result) =>
            TryParse(securityProfileName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SecurityProfileName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/securityProfiles/{security_profile}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/securityProfiles/{security_profile}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="securityProfileName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SecurityProfileName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string securityProfileName, bool allowUnparsed, out SecurityProfileName result)
        {
            gax::GaxPreconditions.CheckNotNull(securityProfileName, nameof(securityProfileName));
            gax::TemplatedResourceName resourceName;
            if (s_organizationLocationSecurityProfile.TryParseName(securityProfileName, out resourceName))
            {
                result = FromOrganizationLocationSecurityProfile(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (s_projectLocationSecurityProfile.TryParseName(securityProfileName, out resourceName))
            {
                result = FromProjectLocationSecurityProfile(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(securityProfileName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private SecurityProfileName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string organizationId = null, string projectId = null, string securityProfileId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            OrganizationId = organizationId;
            ProjectId = projectId;
            SecurityProfileId = securityProfileId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="SecurityProfileName"/> class from the component parts of pattern
        /// <c>organizations/{organization}/locations/{location}/securityProfiles/{security_profile}</c>
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="securityProfileId">The <c>SecurityProfile</c> ID. Must not be <c>null</c> or empty.</param>
        public SecurityProfileName(string organizationId, string locationId, string securityProfileId) : this(ResourceNameType.OrganizationLocationSecurityProfile, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), securityProfileId: gax::GaxPreconditions.CheckNotNullOrEmpty(securityProfileId, nameof(securityProfileId)))
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
        /// The <c>SecurityProfile</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string SecurityProfileId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.OrganizationLocationSecurityProfile: return s_organizationLocationSecurityProfile.Expand(OrganizationId, LocationId, SecurityProfileId);
                case ResourceNameType.ProjectLocationSecurityProfile: return s_projectLocationSecurityProfile.Expand(ProjectId, LocationId, SecurityProfileId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as SecurityProfileName);

        /// <inheritdoc/>
        public bool Equals(SecurityProfileName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(SecurityProfileName a, SecurityProfileName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(SecurityProfileName a, SecurityProfileName b) => !(a == b);
    }

    public partial class SecurityProfileGroup
    {
        /// <summary>
        /// <see cref="gcnv::SecurityProfileGroupName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcnv::SecurityProfileGroupName SecurityProfileGroupName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::SecurityProfileGroupName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="SecurityProfileName"/>-typed view over the <see cref="ThreatPreventionProfile"/> resource name
        /// property.
        /// </summary>
        public SecurityProfileName ThreatPreventionProfileAsSecurityProfileName
        {
            get => string.IsNullOrEmpty(ThreatPreventionProfile) ? null : SecurityProfileName.Parse(ThreatPreventionProfile, allowUnparsed: true);
            set => ThreatPreventionProfile = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="SecurityProfileName"/>-typed view over the <see cref="CustomMirroringProfile"/> resource name
        /// property.
        /// </summary>
        public SecurityProfileName CustomMirroringProfileAsSecurityProfileName
        {
            get => string.IsNullOrEmpty(CustomMirroringProfile) ? null : SecurityProfileName.Parse(CustomMirroringProfile, allowUnparsed: true);
            set => CustomMirroringProfile = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="SecurityProfileName"/>-typed view over the <see cref="CustomInterceptProfile"/> resource name
        /// property.
        /// </summary>
        public SecurityProfileName CustomInterceptProfileAsSecurityProfileName
        {
            get => string.IsNullOrEmpty(CustomInterceptProfile) ? null : SecurityProfileName.Parse(CustomInterceptProfile, allowUnparsed: true);
            set => CustomInterceptProfile = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="SecurityProfileName"/>-typed view over the <see cref="UrlFilteringProfile"/> resource name
        /// property.
        /// </summary>
        public SecurityProfileName UrlFilteringProfileAsSecurityProfileName
        {
            get => string.IsNullOrEmpty(UrlFilteringProfile) ? null : SecurityProfileName.Parse(UrlFilteringProfile, allowUnparsed: true);
            set => UrlFilteringProfile = value?.ToString() ?? "";
        }
    }

    public partial class SecurityProfile
    {
        /// <summary>
        /// <see cref="gcnv::SecurityProfileName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcnv::SecurityProfileName SecurityProfileName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::SecurityProfileName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
