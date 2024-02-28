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
    /// <summary>Resource name for the <c>ComponentSettings</c> resource.</summary>
    public sealed partial class ComponentSettingsName : gax::IResourceName, sys::IEquatable<ComponentSettingsName>
    {
        /// <summary>The possible contents of <see cref="ComponentSettingsName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>organizations/{organization}/components/{component}/settings</c>.
            /// </summary>
            OrganizationComponent = 1,

            /// <summary>A resource name with pattern <c>folders/{folder}/components/{component}/settings</c>.</summary>
            FolderComponent = 2,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/components/{component}/settings</c>.
            /// </summary>
            ProjectComponent = 3,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/clusters/{cluster}/components/{component}/settings</c>.
            /// </summary>
            ProjectLocationClusterComponent = 4,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/regions/{region}/clusters/{cluster}/components/{component}/settings</c>.
            /// </summary>
            ProjectRegionClusterComponent = 5,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/zones/{zone}/clusters/{cluster}/components/{component}/settings</c>.
            /// </summary>
            ProjectZoneClusterComponent = 6,
        }

        private static gax::PathTemplate s_organizationComponent = new gax::PathTemplate("organizations/{organization}/components/{component}/settings");

        private static gax::PathTemplate s_folderComponent = new gax::PathTemplate("folders/{folder}/components/{component}/settings");

        private static gax::PathTemplate s_projectComponent = new gax::PathTemplate("projects/{project}/components/{component}/settings");

        private static gax::PathTemplate s_projectLocationClusterComponent = new gax::PathTemplate("projects/{project}/locations/{location}/clusters/{cluster}/components/{component}/settings");

        private static gax::PathTemplate s_projectRegionClusterComponent = new gax::PathTemplate("projects/{project}/regions/{region}/clusters/{cluster}/components/{component}/settings");

        private static gax::PathTemplate s_projectZoneClusterComponent = new gax::PathTemplate("projects/{project}/zones/{zone}/clusters/{cluster}/components/{component}/settings");

        /// <summary>Creates a <see cref="ComponentSettingsName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ComponentSettingsName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ComponentSettingsName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ComponentSettingsName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ComponentSettingsName"/> with the pattern
        /// <c>organizations/{organization}/components/{component}/settings</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="componentId">The <c>Component</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ComponentSettingsName"/> constructed from the provided ids.</returns>
        public static ComponentSettingsName FromOrganizationComponent(string organizationId, string componentId) =>
            new ComponentSettingsName(ResourceNameType.OrganizationComponent, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), componentId: gax::GaxPreconditions.CheckNotNullOrEmpty(componentId, nameof(componentId)));

        /// <summary>
        /// Creates a <see cref="ComponentSettingsName"/> with the pattern
        /// <c>folders/{folder}/components/{component}/settings</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="componentId">The <c>Component</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ComponentSettingsName"/> constructed from the provided ids.</returns>
        public static ComponentSettingsName FromFolderComponent(string folderId, string componentId) =>
            new ComponentSettingsName(ResourceNameType.FolderComponent, folderId: gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), componentId: gax::GaxPreconditions.CheckNotNullOrEmpty(componentId, nameof(componentId)));

        /// <summary>
        /// Creates a <see cref="ComponentSettingsName"/> with the pattern
        /// <c>projects/{project}/components/{component}/settings</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="componentId">The <c>Component</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ComponentSettingsName"/> constructed from the provided ids.</returns>
        public static ComponentSettingsName FromProjectComponent(string projectId, string componentId) =>
            new ComponentSettingsName(ResourceNameType.ProjectComponent, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), componentId: gax::GaxPreconditions.CheckNotNullOrEmpty(componentId, nameof(componentId)));

        /// <summary>
        /// Creates a <see cref="ComponentSettingsName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/clusters/{cluster}/components/{component}/settings</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="clusterId">The <c>Cluster</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="componentId">The <c>Component</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ComponentSettingsName"/> constructed from the provided ids.</returns>
        public static ComponentSettingsName FromProjectLocationClusterComponent(string projectId, string locationId, string clusterId, string componentId) =>
            new ComponentSettingsName(ResourceNameType.ProjectLocationClusterComponent, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), clusterId: gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)), componentId: gax::GaxPreconditions.CheckNotNullOrEmpty(componentId, nameof(componentId)));

        /// <summary>
        /// Creates a <see cref="ComponentSettingsName"/> with the pattern
        /// <c>projects/{project}/regions/{region}/clusters/{cluster}/components/{component}/settings</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="regionId">The <c>Region</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="clusterId">The <c>Cluster</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="componentId">The <c>Component</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ComponentSettingsName"/> constructed from the provided ids.</returns>
        public static ComponentSettingsName FromProjectRegionClusterComponent(string projectId, string regionId, string clusterId, string componentId) =>
            new ComponentSettingsName(ResourceNameType.ProjectRegionClusterComponent, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), regionId: gax::GaxPreconditions.CheckNotNullOrEmpty(regionId, nameof(regionId)), clusterId: gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)), componentId: gax::GaxPreconditions.CheckNotNullOrEmpty(componentId, nameof(componentId)));

        /// <summary>
        /// Creates a <see cref="ComponentSettingsName"/> with the pattern
        /// <c>projects/{project}/zones/{zone}/clusters/{cluster}/components/{component}/settings</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="zoneId">The <c>Zone</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="clusterId">The <c>Cluster</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="componentId">The <c>Component</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ComponentSettingsName"/> constructed from the provided ids.</returns>
        public static ComponentSettingsName FromProjectZoneClusterComponent(string projectId, string zoneId, string clusterId, string componentId) =>
            new ComponentSettingsName(ResourceNameType.ProjectZoneClusterComponent, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), zoneId: gax::GaxPreconditions.CheckNotNullOrEmpty(zoneId, nameof(zoneId)), clusterId: gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)), componentId: gax::GaxPreconditions.CheckNotNullOrEmpty(componentId, nameof(componentId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ComponentSettingsName"/> with pattern
        /// <c>organizations/{organization}/components/{component}/settings</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="componentId">The <c>Component</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ComponentSettingsName"/> with pattern
        /// <c>organizations/{organization}/components/{component}/settings</c>.
        /// </returns>
        public static string Format(string organizationId, string componentId) =>
            FormatOrganizationComponent(organizationId, componentId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ComponentSettingsName"/> with pattern
        /// <c>organizations/{organization}/components/{component}/settings</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="componentId">The <c>Component</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ComponentSettingsName"/> with pattern
        /// <c>organizations/{organization}/components/{component}/settings</c>.
        /// </returns>
        public static string FormatOrganizationComponent(string organizationId, string componentId) =>
            s_organizationComponent.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(componentId, nameof(componentId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ComponentSettingsName"/> with pattern
        /// <c>folders/{folder}/components/{component}/settings</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="componentId">The <c>Component</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ComponentSettingsName"/> with pattern
        /// <c>folders/{folder}/components/{component}/settings</c>.
        /// </returns>
        public static string FormatFolderComponent(string folderId, string componentId) =>
            s_folderComponent.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), gax::GaxPreconditions.CheckNotNullOrEmpty(componentId, nameof(componentId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ComponentSettingsName"/> with pattern
        /// <c>projects/{project}/components/{component}/settings</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="componentId">The <c>Component</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ComponentSettingsName"/> with pattern
        /// <c>projects/{project}/components/{component}/settings</c>.
        /// </returns>
        public static string FormatProjectComponent(string projectId, string componentId) =>
            s_projectComponent.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(componentId, nameof(componentId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ComponentSettingsName"/> with pattern
        /// <c>projects/{project}/locations/{location}/clusters/{cluster}/components/{component}/settings</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="clusterId">The <c>Cluster</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="componentId">The <c>Component</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ComponentSettingsName"/> with pattern
        /// <c>projects/{project}/locations/{location}/clusters/{cluster}/components/{component}/settings</c>.
        /// </returns>
        public static string FormatProjectLocationClusterComponent(string projectId, string locationId, string clusterId, string componentId) =>
            s_projectLocationClusterComponent.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)), gax::GaxPreconditions.CheckNotNullOrEmpty(componentId, nameof(componentId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ComponentSettingsName"/> with pattern
        /// <c>projects/{project}/regions/{region}/clusters/{cluster}/components/{component}/settings</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="regionId">The <c>Region</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="clusterId">The <c>Cluster</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="componentId">The <c>Component</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ComponentSettingsName"/> with pattern
        /// <c>projects/{project}/regions/{region}/clusters/{cluster}/components/{component}/settings</c>.
        /// </returns>
        public static string FormatProjectRegionClusterComponent(string projectId, string regionId, string clusterId, string componentId) =>
            s_projectRegionClusterComponent.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(regionId, nameof(regionId)), gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)), gax::GaxPreconditions.CheckNotNullOrEmpty(componentId, nameof(componentId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ComponentSettingsName"/> with pattern
        /// <c>projects/{project}/zones/{zone}/clusters/{cluster}/components/{component}/settings</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="zoneId">The <c>Zone</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="clusterId">The <c>Cluster</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="componentId">The <c>Component</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ComponentSettingsName"/> with pattern
        /// <c>projects/{project}/zones/{zone}/clusters/{cluster}/components/{component}/settings</c>.
        /// </returns>
        public static string FormatProjectZoneClusterComponent(string projectId, string zoneId, string clusterId, string componentId) =>
            s_projectZoneClusterComponent.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(zoneId, nameof(zoneId)), gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)), gax::GaxPreconditions.CheckNotNullOrEmpty(componentId, nameof(componentId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ComponentSettingsName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>organizations/{organization}/components/{component}/settings</c></description></item>
        /// <item><description><c>folders/{folder}/components/{component}/settings</c></description></item>
        /// <item><description><c>projects/{project}/components/{component}/settings</c></description></item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/clusters/{cluster}/components/{component}/settings</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/regions/{region}/clusters/{cluster}/components/{component}/settings</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/zones/{zone}/clusters/{cluster}/components/{component}/settings</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="componentSettingsName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ComponentSettingsName"/> if successful.</returns>
        public static ComponentSettingsName Parse(string componentSettingsName) => Parse(componentSettingsName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ComponentSettingsName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>organizations/{organization}/components/{component}/settings</c></description></item>
        /// <item><description><c>folders/{folder}/components/{component}/settings</c></description></item>
        /// <item><description><c>projects/{project}/components/{component}/settings</c></description></item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/clusters/{cluster}/components/{component}/settings</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/regions/{region}/clusters/{cluster}/components/{component}/settings</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/zones/{zone}/clusters/{cluster}/components/{component}/settings</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="componentSettingsName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ComponentSettingsName"/> if successful.</returns>
        public static ComponentSettingsName Parse(string componentSettingsName, bool allowUnparsed) =>
            TryParse(componentSettingsName, allowUnparsed, out ComponentSettingsName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ComponentSettingsName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>organizations/{organization}/components/{component}/settings</c></description></item>
        /// <item><description><c>folders/{folder}/components/{component}/settings</c></description></item>
        /// <item><description><c>projects/{project}/components/{component}/settings</c></description></item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/clusters/{cluster}/components/{component}/settings</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/regions/{region}/clusters/{cluster}/components/{component}/settings</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/zones/{zone}/clusters/{cluster}/components/{component}/settings</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="componentSettingsName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ComponentSettingsName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string componentSettingsName, out ComponentSettingsName result) =>
            TryParse(componentSettingsName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ComponentSettingsName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>organizations/{organization}/components/{component}/settings</c></description></item>
        /// <item><description><c>folders/{folder}/components/{component}/settings</c></description></item>
        /// <item><description><c>projects/{project}/components/{component}/settings</c></description></item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/clusters/{cluster}/components/{component}/settings</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/regions/{region}/clusters/{cluster}/components/{component}/settings</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/zones/{zone}/clusters/{cluster}/components/{component}/settings</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="componentSettingsName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ComponentSettingsName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string componentSettingsName, bool allowUnparsed, out ComponentSettingsName result)
        {
            gax::GaxPreconditions.CheckNotNull(componentSettingsName, nameof(componentSettingsName));
            gax::TemplatedResourceName resourceName;
            if (s_organizationComponent.TryParseName(componentSettingsName, out resourceName))
            {
                result = FromOrganizationComponent(resourceName[0], resourceName[1]);
                return true;
            }
            if (s_folderComponent.TryParseName(componentSettingsName, out resourceName))
            {
                result = FromFolderComponent(resourceName[0], resourceName[1]);
                return true;
            }
            if (s_projectComponent.TryParseName(componentSettingsName, out resourceName))
            {
                result = FromProjectComponent(resourceName[0], resourceName[1]);
                return true;
            }
            if (s_projectLocationClusterComponent.TryParseName(componentSettingsName, out resourceName))
            {
                result = FromProjectLocationClusterComponent(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (s_projectRegionClusterComponent.TryParseName(componentSettingsName, out resourceName))
            {
                result = FromProjectRegionClusterComponent(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (s_projectZoneClusterComponent.TryParseName(componentSettingsName, out resourceName))
            {
                result = FromProjectZoneClusterComponent(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(componentSettingsName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ComponentSettingsName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string clusterId = null, string componentId = null, string folderId = null, string locationId = null, string organizationId = null, string projectId = null, string regionId = null, string zoneId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ClusterId = clusterId;
            ComponentId = componentId;
            FolderId = folderId;
            LocationId = locationId;
            OrganizationId = organizationId;
            ProjectId = projectId;
            RegionId = regionId;
            ZoneId = zoneId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ComponentSettingsName"/> class from the component parts of pattern
        /// <c>organizations/{organization}/components/{component}/settings</c>
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="componentId">The <c>Component</c> ID. Must not be <c>null</c> or empty.</param>
        public ComponentSettingsName(string organizationId, string componentId) : this(ResourceNameType.OrganizationComponent, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), componentId: gax::GaxPreconditions.CheckNotNullOrEmpty(componentId, nameof(componentId)))
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
        /// The <c>Component</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string ComponentId { get; }

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
                case ResourceNameType.OrganizationComponent: return s_organizationComponent.Expand(OrganizationId, ComponentId);
                case ResourceNameType.FolderComponent: return s_folderComponent.Expand(FolderId, ComponentId);
                case ResourceNameType.ProjectComponent: return s_projectComponent.Expand(ProjectId, ComponentId);
                case ResourceNameType.ProjectLocationClusterComponent: return s_projectLocationClusterComponent.Expand(ProjectId, LocationId, ClusterId, ComponentId);
                case ResourceNameType.ProjectRegionClusterComponent: return s_projectRegionClusterComponent.Expand(ProjectId, RegionId, ClusterId, ComponentId);
                case ResourceNameType.ProjectZoneClusterComponent: return s_projectZoneClusterComponent.Expand(ProjectId, ZoneId, ClusterId, ComponentId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ComponentSettingsName);

        /// <inheritdoc/>
        public bool Equals(ComponentSettingsName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ComponentSettingsName a, ComponentSettingsName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ComponentSettingsName a, ComponentSettingsName b) => !(a == b);
    }

    public partial class ComponentSettings
    {
        /// <summary>
        /// <see cref="gcssv::ComponentSettingsName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcssv::ComponentSettingsName ComponentSettingsName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcssv::ComponentSettingsName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
