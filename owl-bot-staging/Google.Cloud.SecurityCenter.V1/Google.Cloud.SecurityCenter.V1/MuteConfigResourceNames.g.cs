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
using gcsv = Google.Cloud.SecurityCenter.V1;
using sys = System;

namespace Google.Cloud.SecurityCenter.V1
{
    /// <summary>Resource name for the <c>MuteConfig</c> resource.</summary>
    public sealed partial class MuteConfigName : gax::IResourceName, sys::IEquatable<MuteConfigName>
    {
        /// <summary>The possible contents of <see cref="MuteConfigName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>organizations/{organization}/muteConfigs/{mute_config}</c>.
            /// </summary>
            OrganizationMuteConfig = 1,

            /// <summary>A resource name with pattern <c>folders/{folder}/muteConfigs/{mute_config}</c>.</summary>
            FolderMuteConfig = 2,

            /// <summary>A resource name with pattern <c>projects/{project}/muteConfigs/{mute_config}</c>.</summary>
            ProjectMuteConfig = 3,

            /// <summary>
            /// A resource name with pattern
            /// <c>organizations/{organization}/locations/{location}/muteConfigs/{mute_config}</c>.
            /// </summary>
            OrganizationLocationMuteConfig = 4,

            /// <summary>
            /// A resource name with pattern <c>folders/{folder}/locations/{location}/muteConfigs/{mute_config}</c>.
            /// </summary>
            FolderLocationMuteConfig = 5,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/muteConfigs/{mute_config}</c>.
            /// </summary>
            ProjectLocationMuteConfig = 6,
        }

        private static gax::PathTemplate s_organizationMuteConfig = new gax::PathTemplate("organizations/{organization}/muteConfigs/{mute_config}");

        private static gax::PathTemplate s_folderMuteConfig = new gax::PathTemplate("folders/{folder}/muteConfigs/{mute_config}");

        private static gax::PathTemplate s_projectMuteConfig = new gax::PathTemplate("projects/{project}/muteConfigs/{mute_config}");

        private static gax::PathTemplate s_organizationLocationMuteConfig = new gax::PathTemplate("organizations/{organization}/locations/{location}/muteConfigs/{mute_config}");

        private static gax::PathTemplate s_folderLocationMuteConfig = new gax::PathTemplate("folders/{folder}/locations/{location}/muteConfigs/{mute_config}");

        private static gax::PathTemplate s_projectLocationMuteConfig = new gax::PathTemplate("projects/{project}/locations/{location}/muteConfigs/{mute_config}");

        /// <summary>Creates a <see cref="MuteConfigName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="MuteConfigName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static MuteConfigName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new MuteConfigName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="MuteConfigName"/> with the pattern
        /// <c>organizations/{organization}/muteConfigs/{mute_config}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="muteConfigId">The <c>MuteConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="MuteConfigName"/> constructed from the provided ids.</returns>
        public static MuteConfigName FromOrganizationMuteConfig(string organizationId, string muteConfigId) =>
            new MuteConfigName(ResourceNameType.OrganizationMuteConfig, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), muteConfigId: gax::GaxPreconditions.CheckNotNullOrEmpty(muteConfigId, nameof(muteConfigId)));

        /// <summary>
        /// Creates a <see cref="MuteConfigName"/> with the pattern <c>folders/{folder}/muteConfigs/{mute_config}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="muteConfigId">The <c>MuteConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="MuteConfigName"/> constructed from the provided ids.</returns>
        public static MuteConfigName FromFolderMuteConfig(string folderId, string muteConfigId) =>
            new MuteConfigName(ResourceNameType.FolderMuteConfig, folderId: gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), muteConfigId: gax::GaxPreconditions.CheckNotNullOrEmpty(muteConfigId, nameof(muteConfigId)));

        /// <summary>
        /// Creates a <see cref="MuteConfigName"/> with the pattern <c>projects/{project}/muteConfigs/{mute_config}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="muteConfigId">The <c>MuteConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="MuteConfigName"/> constructed from the provided ids.</returns>
        public static MuteConfigName FromProjectMuteConfig(string projectId, string muteConfigId) =>
            new MuteConfigName(ResourceNameType.ProjectMuteConfig, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), muteConfigId: gax::GaxPreconditions.CheckNotNullOrEmpty(muteConfigId, nameof(muteConfigId)));

        /// <summary>
        /// Creates a <see cref="MuteConfigName"/> with the pattern
        /// <c>organizations/{organization}/locations/{location}/muteConfigs/{mute_config}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="muteConfigId">The <c>MuteConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="MuteConfigName"/> constructed from the provided ids.</returns>
        public static MuteConfigName FromOrganizationLocationMuteConfig(string organizationId, string locationId, string muteConfigId) =>
            new MuteConfigName(ResourceNameType.OrganizationLocationMuteConfig, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), muteConfigId: gax::GaxPreconditions.CheckNotNullOrEmpty(muteConfigId, nameof(muteConfigId)));

        /// <summary>
        /// Creates a <see cref="MuteConfigName"/> with the pattern
        /// <c>folders/{folder}/locations/{location}/muteConfigs/{mute_config}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="muteConfigId">The <c>MuteConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="MuteConfigName"/> constructed from the provided ids.</returns>
        public static MuteConfigName FromFolderLocationMuteConfig(string folderId, string locationId, string muteConfigId) =>
            new MuteConfigName(ResourceNameType.FolderLocationMuteConfig, folderId: gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), muteConfigId: gax::GaxPreconditions.CheckNotNullOrEmpty(muteConfigId, nameof(muteConfigId)));

        /// <summary>
        /// Creates a <see cref="MuteConfigName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/muteConfigs/{mute_config}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="muteConfigId">The <c>MuteConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="MuteConfigName"/> constructed from the provided ids.</returns>
        public static MuteConfigName FromProjectLocationMuteConfig(string projectId, string locationId, string muteConfigId) =>
            new MuteConfigName(ResourceNameType.ProjectLocationMuteConfig, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), muteConfigId: gax::GaxPreconditions.CheckNotNullOrEmpty(muteConfigId, nameof(muteConfigId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="MuteConfigName"/> with pattern
        /// <c>organizations/{organization}/muteConfigs/{mute_config}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="muteConfigId">The <c>MuteConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="MuteConfigName"/> with pattern
        /// <c>organizations/{organization}/muteConfigs/{mute_config}</c>.
        /// </returns>
        public static string Format(string organizationId, string muteConfigId) =>
            FormatOrganizationMuteConfig(organizationId, muteConfigId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="MuteConfigName"/> with pattern
        /// <c>organizations/{organization}/muteConfigs/{mute_config}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="muteConfigId">The <c>MuteConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="MuteConfigName"/> with pattern
        /// <c>organizations/{organization}/muteConfigs/{mute_config}</c>.
        /// </returns>
        public static string FormatOrganizationMuteConfig(string organizationId, string muteConfigId) =>
            s_organizationMuteConfig.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(muteConfigId, nameof(muteConfigId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="MuteConfigName"/> with pattern
        /// <c>folders/{folder}/muteConfigs/{mute_config}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="muteConfigId">The <c>MuteConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="MuteConfigName"/> with pattern
        /// <c>folders/{folder}/muteConfigs/{mute_config}</c>.
        /// </returns>
        public static string FormatFolderMuteConfig(string folderId, string muteConfigId) =>
            s_folderMuteConfig.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), gax::GaxPreconditions.CheckNotNullOrEmpty(muteConfigId, nameof(muteConfigId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="MuteConfigName"/> with pattern
        /// <c>projects/{project}/muteConfigs/{mute_config}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="muteConfigId">The <c>MuteConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="MuteConfigName"/> with pattern
        /// <c>projects/{project}/muteConfigs/{mute_config}</c>.
        /// </returns>
        public static string FormatProjectMuteConfig(string projectId, string muteConfigId) =>
            s_projectMuteConfig.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(muteConfigId, nameof(muteConfigId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="MuteConfigName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}/muteConfigs/{mute_config}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="muteConfigId">The <c>MuteConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="MuteConfigName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}/muteConfigs/{mute_config}</c>.
        /// </returns>
        public static string FormatOrganizationLocationMuteConfig(string organizationId, string locationId, string muteConfigId) =>
            s_organizationLocationMuteConfig.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(muteConfigId, nameof(muteConfigId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="MuteConfigName"/> with pattern
        /// <c>folders/{folder}/locations/{location}/muteConfigs/{mute_config}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="muteConfigId">The <c>MuteConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="MuteConfigName"/> with pattern
        /// <c>folders/{folder}/locations/{location}/muteConfigs/{mute_config}</c>.
        /// </returns>
        public static string FormatFolderLocationMuteConfig(string folderId, string locationId, string muteConfigId) =>
            s_folderLocationMuteConfig.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(muteConfigId, nameof(muteConfigId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="MuteConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/muteConfigs/{mute_config}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="muteConfigId">The <c>MuteConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="MuteConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/muteConfigs/{mute_config}</c>.
        /// </returns>
        public static string FormatProjectLocationMuteConfig(string projectId, string locationId, string muteConfigId) =>
            s_projectLocationMuteConfig.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(muteConfigId, nameof(muteConfigId)));

        /// <summary>Parses the given resource name string into a new <see cref="MuteConfigName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>organizations/{organization}/muteConfigs/{mute_config}</c></description></item>
        /// <item><description><c>folders/{folder}/muteConfigs/{mute_config}</c></description></item>
        /// <item><description><c>projects/{project}/muteConfigs/{mute_config}</c></description></item>
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/muteConfigs/{mute_config}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description><c>folders/{folder}/locations/{location}/muteConfigs/{mute_config}</c></description>
        /// </item>
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/muteConfigs/{mute_config}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="muteConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="MuteConfigName"/> if successful.</returns>
        public static MuteConfigName Parse(string muteConfigName) => Parse(muteConfigName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="MuteConfigName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>organizations/{organization}/muteConfigs/{mute_config}</c></description></item>
        /// <item><description><c>folders/{folder}/muteConfigs/{mute_config}</c></description></item>
        /// <item><description><c>projects/{project}/muteConfigs/{mute_config}</c></description></item>
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/muteConfigs/{mute_config}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description><c>folders/{folder}/locations/{location}/muteConfigs/{mute_config}</c></description>
        /// </item>
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/muteConfigs/{mute_config}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="muteConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="MuteConfigName"/> if successful.</returns>
        public static MuteConfigName Parse(string muteConfigName, bool allowUnparsed) =>
            TryParse(muteConfigName, allowUnparsed, out MuteConfigName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="MuteConfigName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>organizations/{organization}/muteConfigs/{mute_config}</c></description></item>
        /// <item><description><c>folders/{folder}/muteConfigs/{mute_config}</c></description></item>
        /// <item><description><c>projects/{project}/muteConfigs/{mute_config}</c></description></item>
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/muteConfigs/{mute_config}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description><c>folders/{folder}/locations/{location}/muteConfigs/{mute_config}</c></description>
        /// </item>
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/muteConfigs/{mute_config}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="muteConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="MuteConfigName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string muteConfigName, out MuteConfigName result) =>
            TryParse(muteConfigName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="MuteConfigName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>organizations/{organization}/muteConfigs/{mute_config}</c></description></item>
        /// <item><description><c>folders/{folder}/muteConfigs/{mute_config}</c></description></item>
        /// <item><description><c>projects/{project}/muteConfigs/{mute_config}</c></description></item>
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/muteConfigs/{mute_config}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description><c>folders/{folder}/locations/{location}/muteConfigs/{mute_config}</c></description>
        /// </item>
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/muteConfigs/{mute_config}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="muteConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="MuteConfigName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string muteConfigName, bool allowUnparsed, out MuteConfigName result)
        {
            gax::GaxPreconditions.CheckNotNull(muteConfigName, nameof(muteConfigName));
            gax::TemplatedResourceName resourceName;
            if (s_organizationMuteConfig.TryParseName(muteConfigName, out resourceName))
            {
                result = FromOrganizationMuteConfig(resourceName[0], resourceName[1]);
                return true;
            }
            if (s_folderMuteConfig.TryParseName(muteConfigName, out resourceName))
            {
                result = FromFolderMuteConfig(resourceName[0], resourceName[1]);
                return true;
            }
            if (s_projectMuteConfig.TryParseName(muteConfigName, out resourceName))
            {
                result = FromProjectMuteConfig(resourceName[0], resourceName[1]);
                return true;
            }
            if (s_organizationLocationMuteConfig.TryParseName(muteConfigName, out resourceName))
            {
                result = FromOrganizationLocationMuteConfig(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (s_folderLocationMuteConfig.TryParseName(muteConfigName, out resourceName))
            {
                result = FromFolderLocationMuteConfig(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (s_projectLocationMuteConfig.TryParseName(muteConfigName, out resourceName))
            {
                result = FromProjectLocationMuteConfig(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(muteConfigName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private MuteConfigName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string folderId = null, string locationId = null, string muteConfigId = null, string organizationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            FolderId = folderId;
            LocationId = locationId;
            MuteConfigId = muteConfigId;
            OrganizationId = organizationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="MuteConfigName"/> class from the component parts of pattern
        /// <c>organizations/{organization}/muteConfigs/{mute_config}</c>
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="muteConfigId">The <c>MuteConfig</c> ID. Must not be <c>null</c> or empty.</param>
        public MuteConfigName(string organizationId, string muteConfigId) : this(ResourceNameType.OrganizationMuteConfig, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), muteConfigId: gax::GaxPreconditions.CheckNotNullOrEmpty(muteConfigId, nameof(muteConfigId)))
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
        /// The <c>Folder</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string FolderId { get; }

        /// <summary>
        /// The <c>Location</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>MuteConfig</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string MuteConfigId { get; }

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
                case ResourceNameType.OrganizationMuteConfig: return s_organizationMuteConfig.Expand(OrganizationId, MuteConfigId);
                case ResourceNameType.FolderMuteConfig: return s_folderMuteConfig.Expand(FolderId, MuteConfigId);
                case ResourceNameType.ProjectMuteConfig: return s_projectMuteConfig.Expand(ProjectId, MuteConfigId);
                case ResourceNameType.OrganizationLocationMuteConfig: return s_organizationLocationMuteConfig.Expand(OrganizationId, LocationId, MuteConfigId);
                case ResourceNameType.FolderLocationMuteConfig: return s_folderLocationMuteConfig.Expand(FolderId, LocationId, MuteConfigId);
                case ResourceNameType.ProjectLocationMuteConfig: return s_projectLocationMuteConfig.Expand(ProjectId, LocationId, MuteConfigId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as MuteConfigName);

        /// <inheritdoc/>
        public bool Equals(MuteConfigName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(MuteConfigName a, MuteConfigName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(MuteConfigName a, MuteConfigName b) => !(a == b);
    }

    public partial class MuteConfig
    {
        /// <summary>
        /// <see cref="gcsv::MuteConfigName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcsv::MuteConfigName MuteConfigName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcsv::MuteConfigName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
