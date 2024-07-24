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
using gcssv = Google.Cloud.SecurityCenter.Settings.V1Beta1;
using sys = System;

namespace Google.Cloud.SecurityCenter.Settings.V1Beta1
{
    /// <summary>Resource name for the <c>Settings</c> resource.</summary>
    public sealed partial class SettingsName : gax::IResourceName, sys::IEquatable<SettingsName>
    {
        /// <summary>The possible contents of <see cref="SettingsName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>organizations/{organization}/settings</c>.</summary>
            Organization = 1,

            /// <summary>A resource name with pattern <c>folders/{folder}/settings</c>.</summary>
            Folder = 2,

            /// <summary>A resource name with pattern <c>projects/{project}/settings</c>.</summary>
            Project = 3,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/clusters/{cluster}/settings</c>.
            /// </summary>
            ProjectLocationCluster = 4,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/regions/{region}/clusters/{cluster}/settings</c>.
            /// </summary>
            ProjectRegionCluster = 5,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/zones/{zone}/clusters/{cluster}/settings</c>.
            /// </summary>
            ProjectZoneCluster = 6,
        }

        private static gax::PathTemplate s_organization = new gax::PathTemplate("organizations/{organization}/settings");

        private static gax::PathTemplate s_folder = new gax::PathTemplate("folders/{folder}/settings");

        private static gax::PathTemplate s_project = new gax::PathTemplate("projects/{project}/settings");

        private static gax::PathTemplate s_projectLocationCluster = new gax::PathTemplate("projects/{project}/locations/{location}/clusters/{cluster}/settings");

        private static gax::PathTemplate s_projectRegionCluster = new gax::PathTemplate("projects/{project}/regions/{region}/clusters/{cluster}/settings");

        private static gax::PathTemplate s_projectZoneCluster = new gax::PathTemplate("projects/{project}/zones/{zone}/clusters/{cluster}/settings");

        /// <summary>Creates a <see cref="SettingsName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="SettingsName"/> containing the provided <paramref name="unparsedResourceName"/>
        /// .
        /// </returns>
        public static SettingsName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new SettingsName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="SettingsName"/> with the pattern <c>organizations/{organization}/settings</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="SettingsName"/> constructed from the provided ids.</returns>
        public static SettingsName FromOrganization(string organizationId) =>
            new SettingsName(ResourceNameType.Organization, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)));

        /// <summary>Creates a <see cref="SettingsName"/> with the pattern <c>folders/{folder}/settings</c>.</summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="SettingsName"/> constructed from the provided ids.</returns>
        public static SettingsName FromFolder(string folderId) =>
            new SettingsName(ResourceNameType.Folder, folderId: gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)));

        /// <summary>Creates a <see cref="SettingsName"/> with the pattern <c>projects/{project}/settings</c>.</summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="SettingsName"/> constructed from the provided ids.</returns>
        public static SettingsName FromProject(string projectId) =>
            new SettingsName(ResourceNameType.Project, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)));

        /// <summary>
        /// Creates a <see cref="SettingsName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/clusters/{cluster}/settings</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="clusterId">The <c>Cluster</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="SettingsName"/> constructed from the provided ids.</returns>
        public static SettingsName FromProjectLocationCluster(string projectId, string locationId, string clusterId) =>
            new SettingsName(ResourceNameType.ProjectLocationCluster, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), clusterId: gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)));

        /// <summary>
        /// Creates a <see cref="SettingsName"/> with the pattern
        /// <c>projects/{project}/regions/{region}/clusters/{cluster}/settings</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="regionId">The <c>Region</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="clusterId">The <c>Cluster</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="SettingsName"/> constructed from the provided ids.</returns>
        public static SettingsName FromProjectRegionCluster(string projectId, string regionId, string clusterId) =>
            new SettingsName(ResourceNameType.ProjectRegionCluster, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), regionId: gax::GaxPreconditions.CheckNotNullOrEmpty(regionId, nameof(regionId)), clusterId: gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)));

        /// <summary>
        /// Creates a <see cref="SettingsName"/> with the pattern
        /// <c>projects/{project}/zones/{zone}/clusters/{cluster}/settings</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="zoneId">The <c>Zone</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="clusterId">The <c>Cluster</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="SettingsName"/> constructed from the provided ids.</returns>
        public static SettingsName FromProjectZoneCluster(string projectId, string zoneId, string clusterId) =>
            new SettingsName(ResourceNameType.ProjectZoneCluster, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), zoneId: gax::GaxPreconditions.CheckNotNullOrEmpty(zoneId, nameof(zoneId)), clusterId: gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SettingsName"/> with pattern
        /// <c>organizations/{organization}/settings</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SettingsName"/> with pattern
        /// <c>organizations/{organization}/settings</c>.
        /// </returns>
        public static string Format(string organizationId) => FormatOrganization(organizationId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SettingsName"/> with pattern
        /// <c>organizations/{organization}/settings</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SettingsName"/> with pattern
        /// <c>organizations/{organization}/settings</c>.
        /// </returns>
        public static string FormatOrganization(string organizationId) =>
            s_organization.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SettingsName"/> with pattern
        /// <c>folders/{folder}/settings</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SettingsName"/> with pattern <c>folders/{folder}/settings</c>.
        /// </returns>
        public static string FormatFolder(string folderId) =>
            s_folder.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SettingsName"/> with pattern
        /// <c>projects/{project}/settings</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SettingsName"/> with pattern <c>projects/{project}/settings</c>
        /// .
        /// </returns>
        public static string FormatProject(string projectId) =>
            s_project.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SettingsName"/> with pattern
        /// <c>projects/{project}/locations/{location}/clusters/{cluster}/settings</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="clusterId">The <c>Cluster</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SettingsName"/> with pattern
        /// <c>projects/{project}/locations/{location}/clusters/{cluster}/settings</c>.
        /// </returns>
        public static string FormatProjectLocationCluster(string projectId, string locationId, string clusterId) =>
            s_projectLocationCluster.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SettingsName"/> with pattern
        /// <c>projects/{project}/regions/{region}/clusters/{cluster}/settings</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="regionId">The <c>Region</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="clusterId">The <c>Cluster</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SettingsName"/> with pattern
        /// <c>projects/{project}/regions/{region}/clusters/{cluster}/settings</c>.
        /// </returns>
        public static string FormatProjectRegionCluster(string projectId, string regionId, string clusterId) =>
            s_projectRegionCluster.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(regionId, nameof(regionId)), gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SettingsName"/> with pattern
        /// <c>projects/{project}/zones/{zone}/clusters/{cluster}/settings</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="zoneId">The <c>Zone</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="clusterId">The <c>Cluster</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SettingsName"/> with pattern
        /// <c>projects/{project}/zones/{zone}/clusters/{cluster}/settings</c>.
        /// </returns>
        public static string FormatProjectZoneCluster(string projectId, string zoneId, string clusterId) =>
            s_projectZoneCluster.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(zoneId, nameof(zoneId)), gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)));

        /// <summary>Parses the given resource name string into a new <see cref="SettingsName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>organizations/{organization}/settings</c></description></item>
        /// <item><description><c>folders/{folder}/settings</c></description></item>
        /// <item><description><c>projects/{project}/settings</c></description></item>
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/clusters/{cluster}/settings</c></description>
        /// </item>
        /// <item>
        /// <description><c>projects/{project}/regions/{region}/clusters/{cluster}/settings</c></description>
        /// </item>
        /// <item><description><c>projects/{project}/zones/{zone}/clusters/{cluster}/settings</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="settingsName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="SettingsName"/> if successful.</returns>
        public static SettingsName Parse(string settingsName) => Parse(settingsName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="SettingsName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>organizations/{organization}/settings</c></description></item>
        /// <item><description><c>folders/{folder}/settings</c></description></item>
        /// <item><description><c>projects/{project}/settings</c></description></item>
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/clusters/{cluster}/settings</c></description>
        /// </item>
        /// <item>
        /// <description><c>projects/{project}/regions/{region}/clusters/{cluster}/settings</c></description>
        /// </item>
        /// <item><description><c>projects/{project}/zones/{zone}/clusters/{cluster}/settings</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="settingsName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="SettingsName"/> if successful.</returns>
        public static SettingsName Parse(string settingsName, bool allowUnparsed) =>
            TryParse(settingsName, allowUnparsed, out SettingsName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SettingsName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>organizations/{organization}/settings</c></description></item>
        /// <item><description><c>folders/{folder}/settings</c></description></item>
        /// <item><description><c>projects/{project}/settings</c></description></item>
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/clusters/{cluster}/settings</c></description>
        /// </item>
        /// <item>
        /// <description><c>projects/{project}/regions/{region}/clusters/{cluster}/settings</c></description>
        /// </item>
        /// <item><description><c>projects/{project}/zones/{zone}/clusters/{cluster}/settings</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="settingsName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SettingsName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string settingsName, out SettingsName result) => TryParse(settingsName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SettingsName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>organizations/{organization}/settings</c></description></item>
        /// <item><description><c>folders/{folder}/settings</c></description></item>
        /// <item><description><c>projects/{project}/settings</c></description></item>
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/clusters/{cluster}/settings</c></description>
        /// </item>
        /// <item>
        /// <description><c>projects/{project}/regions/{region}/clusters/{cluster}/settings</c></description>
        /// </item>
        /// <item><description><c>projects/{project}/zones/{zone}/clusters/{cluster}/settings</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="settingsName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SettingsName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string settingsName, bool allowUnparsed, out SettingsName result)
        {
            gax::GaxPreconditions.CheckNotNull(settingsName, nameof(settingsName));
            gax::TemplatedResourceName resourceName;
            if (s_organization.TryParseName(settingsName, out resourceName))
            {
                result = FromOrganization(resourceName[0]);
                return true;
            }
            if (s_folder.TryParseName(settingsName, out resourceName))
            {
                result = FromFolder(resourceName[0]);
                return true;
            }
            if (s_project.TryParseName(settingsName, out resourceName))
            {
                result = FromProject(resourceName[0]);
                return true;
            }
            if (s_projectLocationCluster.TryParseName(settingsName, out resourceName))
            {
                result = FromProjectLocationCluster(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (s_projectRegionCluster.TryParseName(settingsName, out resourceName))
            {
                result = FromProjectRegionCluster(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (s_projectZoneCluster.TryParseName(settingsName, out resourceName))
            {
                result = FromProjectZoneCluster(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(settingsName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private SettingsName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string clusterId = null, string folderId = null, string locationId = null, string organizationId = null, string projectId = null, string regionId = null, string zoneId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ClusterId = clusterId;
            FolderId = folderId;
            LocationId = locationId;
            OrganizationId = organizationId;
            ProjectId = projectId;
            RegionId = regionId;
            ZoneId = zoneId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="SettingsName"/> class from the component parts of pattern
        /// <c>organizations/{organization}/settings</c>
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        public SettingsName(string organizationId) : this(ResourceNameType.Organization, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)))
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
        /// The <c>Cluster</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string ClusterId { get; }

        /// <summary>
        /// The <c>Folder</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string FolderId { get; }

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
        /// The <c>Region</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string RegionId { get; }

        /// <summary>
        /// The <c>Zone</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string ZoneId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.Organization: return s_organization.Expand(OrganizationId);
                case ResourceNameType.Folder: return s_folder.Expand(FolderId);
                case ResourceNameType.Project: return s_project.Expand(ProjectId);
                case ResourceNameType.ProjectLocationCluster: return s_projectLocationCluster.Expand(ProjectId, LocationId, ClusterId);
                case ResourceNameType.ProjectRegionCluster: return s_projectRegionCluster.Expand(ProjectId, RegionId, ClusterId);
                case ResourceNameType.ProjectZoneCluster: return s_projectZoneCluster.Expand(ProjectId, ZoneId, ClusterId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as SettingsName);

        /// <inheritdoc/>
        public bool Equals(SettingsName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(SettingsName a, SettingsName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(SettingsName a, SettingsName b) => !(a == b);
    }

    public partial class Settings
    {
        /// <summary>
        /// <see cref="gcssv::SettingsName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcssv::SettingsName SettingsName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcssv::SettingsName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
