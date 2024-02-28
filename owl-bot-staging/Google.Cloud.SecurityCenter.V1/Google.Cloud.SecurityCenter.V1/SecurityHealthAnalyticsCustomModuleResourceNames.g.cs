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
    /// <summary>Resource name for the <c>SecurityHealthAnalyticsCustomModule</c> resource.</summary>
    public sealed partial class SecurityHealthAnalyticsCustomModuleName : gax::IResourceName, sys::IEquatable<SecurityHealthAnalyticsCustomModuleName>
    {
        /// <summary>The possible contents of <see cref="SecurityHealthAnalyticsCustomModuleName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>organizations/{organization}/securityHealthAnalyticsSettings/customModules/{custom_module}</c>.
            /// </summary>
            OrganizationCustomModule = 1,

            /// <summary>
            /// A resource name with pattern
            /// <c>folders/{folder}/securityHealthAnalyticsSettings/customModules/{custom_module}</c>.
            /// </summary>
            FolderCustomModule = 2,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/securityHealthAnalyticsSettings/customModules/{custom_module}</c>.
            /// </summary>
            ProjectCustomModule = 3,
        }

        private static gax::PathTemplate s_organizationCustomModule = new gax::PathTemplate("organizations/{organization}/securityHealthAnalyticsSettings/customModules/{custom_module}");

        private static gax::PathTemplate s_folderCustomModule = new gax::PathTemplate("folders/{folder}/securityHealthAnalyticsSettings/customModules/{custom_module}");

        private static gax::PathTemplate s_projectCustomModule = new gax::PathTemplate("projects/{project}/securityHealthAnalyticsSettings/customModules/{custom_module}");

        /// <summary>
        /// Creates a <see cref="SecurityHealthAnalyticsCustomModuleName"/> containing an unparsed resource name.
        /// </summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="SecurityHealthAnalyticsCustomModuleName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static SecurityHealthAnalyticsCustomModuleName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new SecurityHealthAnalyticsCustomModuleName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="SecurityHealthAnalyticsCustomModuleName"/> with the pattern
        /// <c>organizations/{organization}/securityHealthAnalyticsSettings/customModules/{custom_module}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="customModuleId">The <c>CustomModule</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// A new instance of <see cref="SecurityHealthAnalyticsCustomModuleName"/> constructed from the provided ids.
        /// </returns>
        public static SecurityHealthAnalyticsCustomModuleName FromOrganizationCustomModule(string organizationId, string customModuleId) =>
            new SecurityHealthAnalyticsCustomModuleName(ResourceNameType.OrganizationCustomModule, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), customModuleId: gax::GaxPreconditions.CheckNotNullOrEmpty(customModuleId, nameof(customModuleId)));

        /// <summary>
        /// Creates a <see cref="SecurityHealthAnalyticsCustomModuleName"/> with the pattern
        /// <c>folders/{folder}/securityHealthAnalyticsSettings/customModules/{custom_module}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="customModuleId">The <c>CustomModule</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// A new instance of <see cref="SecurityHealthAnalyticsCustomModuleName"/> constructed from the provided ids.
        /// </returns>
        public static SecurityHealthAnalyticsCustomModuleName FromFolderCustomModule(string folderId, string customModuleId) =>
            new SecurityHealthAnalyticsCustomModuleName(ResourceNameType.FolderCustomModule, folderId: gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), customModuleId: gax::GaxPreconditions.CheckNotNullOrEmpty(customModuleId, nameof(customModuleId)));

        /// <summary>
        /// Creates a <see cref="SecurityHealthAnalyticsCustomModuleName"/> with the pattern
        /// <c>projects/{project}/securityHealthAnalyticsSettings/customModules/{custom_module}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="customModuleId">The <c>CustomModule</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// A new instance of <see cref="SecurityHealthAnalyticsCustomModuleName"/> constructed from the provided ids.
        /// </returns>
        public static SecurityHealthAnalyticsCustomModuleName FromProjectCustomModule(string projectId, string customModuleId) =>
            new SecurityHealthAnalyticsCustomModuleName(ResourceNameType.ProjectCustomModule, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), customModuleId: gax::GaxPreconditions.CheckNotNullOrEmpty(customModuleId, nameof(customModuleId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SecurityHealthAnalyticsCustomModuleName"/>
        /// with pattern <c>organizations/{organization}/securityHealthAnalyticsSettings/customModules/{custom_module}</c>
        /// .
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="customModuleId">The <c>CustomModule</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SecurityHealthAnalyticsCustomModuleName"/> with pattern
        /// <c>organizations/{organization}/securityHealthAnalyticsSettings/customModules/{custom_module}</c>.
        /// </returns>
        public static string Format(string organizationId, string customModuleId) =>
            FormatOrganizationCustomModule(organizationId, customModuleId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SecurityHealthAnalyticsCustomModuleName"/>
        /// with pattern <c>organizations/{organization}/securityHealthAnalyticsSettings/customModules/{custom_module}</c>
        /// .
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="customModuleId">The <c>CustomModule</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SecurityHealthAnalyticsCustomModuleName"/> with pattern
        /// <c>organizations/{organization}/securityHealthAnalyticsSettings/customModules/{custom_module}</c>.
        /// </returns>
        public static string FormatOrganizationCustomModule(string organizationId, string customModuleId) =>
            s_organizationCustomModule.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(customModuleId, nameof(customModuleId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SecurityHealthAnalyticsCustomModuleName"/>
        /// with pattern <c>folders/{folder}/securityHealthAnalyticsSettings/customModules/{custom_module}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="customModuleId">The <c>CustomModule</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SecurityHealthAnalyticsCustomModuleName"/> with pattern
        /// <c>folders/{folder}/securityHealthAnalyticsSettings/customModules/{custom_module}</c>.
        /// </returns>
        public static string FormatFolderCustomModule(string folderId, string customModuleId) =>
            s_folderCustomModule.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), gax::GaxPreconditions.CheckNotNullOrEmpty(customModuleId, nameof(customModuleId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SecurityHealthAnalyticsCustomModuleName"/>
        /// with pattern <c>projects/{project}/securityHealthAnalyticsSettings/customModules/{custom_module}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="customModuleId">The <c>CustomModule</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SecurityHealthAnalyticsCustomModuleName"/> with pattern
        /// <c>projects/{project}/securityHealthAnalyticsSettings/customModules/{custom_module}</c>.
        /// </returns>
        public static string FormatProjectCustomModule(string projectId, string customModuleId) =>
            s_projectCustomModule.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(customModuleId, nameof(customModuleId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="SecurityHealthAnalyticsCustomModuleName"/>
        /// instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/securityHealthAnalyticsSettings/customModules/{custom_module}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>folders/{folder}/securityHealthAnalyticsSettings/customModules/{custom_module}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/securityHealthAnalyticsSettings/customModules/{custom_module}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="securityHealthAnalyticsCustomModuleName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <returns>The parsed <see cref="SecurityHealthAnalyticsCustomModuleName"/> if successful.</returns>
        public static SecurityHealthAnalyticsCustomModuleName Parse(string securityHealthAnalyticsCustomModuleName) =>
            Parse(securityHealthAnalyticsCustomModuleName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="SecurityHealthAnalyticsCustomModuleName"/>
        /// instance; optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/securityHealthAnalyticsSettings/customModules/{custom_module}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>folders/{folder}/securityHealthAnalyticsSettings/customModules/{custom_module}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/securityHealthAnalyticsSettings/customModules/{custom_module}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="securityHealthAnalyticsCustomModuleName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="SecurityHealthAnalyticsCustomModuleName"/> if successful.</returns>
        public static SecurityHealthAnalyticsCustomModuleName Parse(string securityHealthAnalyticsCustomModuleName, bool allowUnparsed) =>
            TryParse(securityHealthAnalyticsCustomModuleName, allowUnparsed, out SecurityHealthAnalyticsCustomModuleName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new
        /// <see cref="SecurityHealthAnalyticsCustomModuleName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/securityHealthAnalyticsSettings/customModules/{custom_module}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>folders/{folder}/securityHealthAnalyticsSettings/customModules/{custom_module}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/securityHealthAnalyticsSettings/customModules/{custom_module}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="securityHealthAnalyticsCustomModuleName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SecurityHealthAnalyticsCustomModuleName"/>, or <c>null</c>
        /// if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string securityHealthAnalyticsCustomModuleName, out SecurityHealthAnalyticsCustomModuleName result) =>
            TryParse(securityHealthAnalyticsCustomModuleName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new
        /// <see cref="SecurityHealthAnalyticsCustomModuleName"/> instance; optionally allowing an unparseable resource
        /// name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/securityHealthAnalyticsSettings/customModules/{custom_module}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>folders/{folder}/securityHealthAnalyticsSettings/customModules/{custom_module}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/securityHealthAnalyticsSettings/customModules/{custom_module}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="securityHealthAnalyticsCustomModuleName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SecurityHealthAnalyticsCustomModuleName"/>, or <c>null</c>
        /// if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string securityHealthAnalyticsCustomModuleName, bool allowUnparsed, out SecurityHealthAnalyticsCustomModuleName result)
        {
            gax::GaxPreconditions.CheckNotNull(securityHealthAnalyticsCustomModuleName, nameof(securityHealthAnalyticsCustomModuleName));
            gax::TemplatedResourceName resourceName;
            if (s_organizationCustomModule.TryParseName(securityHealthAnalyticsCustomModuleName, out resourceName))
            {
                result = FromOrganizationCustomModule(resourceName[0], resourceName[1]);
                return true;
            }
            if (s_folderCustomModule.TryParseName(securityHealthAnalyticsCustomModuleName, out resourceName))
            {
                result = FromFolderCustomModule(resourceName[0], resourceName[1]);
                return true;
            }
            if (s_projectCustomModule.TryParseName(securityHealthAnalyticsCustomModuleName, out resourceName))
            {
                result = FromProjectCustomModule(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(securityHealthAnalyticsCustomModuleName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private SecurityHealthAnalyticsCustomModuleName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string customModuleId = null, string folderId = null, string organizationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CustomModuleId = customModuleId;
            FolderId = folderId;
            OrganizationId = organizationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="SecurityHealthAnalyticsCustomModuleName"/> class from the
        /// component parts of pattern
        /// <c>organizations/{organization}/securityHealthAnalyticsSettings/customModules/{custom_module}</c>
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="customModuleId">The <c>CustomModule</c> ID. Must not be <c>null</c> or empty.</param>
        public SecurityHealthAnalyticsCustomModuleName(string organizationId, string customModuleId) : this(ResourceNameType.OrganizationCustomModule, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), customModuleId: gax::GaxPreconditions.CheckNotNullOrEmpty(customModuleId, nameof(customModuleId)))
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
        /// The <c>CustomModule</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string CustomModuleId { get; }

        /// <summary>
        /// The <c>Folder</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string FolderId { get; }

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
                case ResourceNameType.OrganizationCustomModule: return s_organizationCustomModule.Expand(OrganizationId, CustomModuleId);
                case ResourceNameType.FolderCustomModule: return s_folderCustomModule.Expand(FolderId, CustomModuleId);
                case ResourceNameType.ProjectCustomModule: return s_projectCustomModule.Expand(ProjectId, CustomModuleId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as SecurityHealthAnalyticsCustomModuleName);

        /// <inheritdoc/>
        public bool Equals(SecurityHealthAnalyticsCustomModuleName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(SecurityHealthAnalyticsCustomModuleName a, SecurityHealthAnalyticsCustomModuleName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(SecurityHealthAnalyticsCustomModuleName a, SecurityHealthAnalyticsCustomModuleName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>SecurityHealthAnalyticsSettings</c> resource.</summary>
    public sealed partial class SecurityHealthAnalyticsSettingsName : gax::IResourceName, sys::IEquatable<SecurityHealthAnalyticsSettingsName>
    {
        /// <summary>The possible contents of <see cref="SecurityHealthAnalyticsSettingsName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>organizations/{organization}/securityHealthAnalyticsSettings</c>.
            /// </summary>
            Organization = 1,

            /// <summary>A resource name with pattern <c>folders/{folder}/securityHealthAnalyticsSettings</c>.</summary>
            Folder = 2,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/securityHealthAnalyticsSettings</c>.
            /// </summary>
            Project = 3,
        }

        private static gax::PathTemplate s_organization = new gax::PathTemplate("organizations/{organization}/securityHealthAnalyticsSettings");

        private static gax::PathTemplate s_folder = new gax::PathTemplate("folders/{folder}/securityHealthAnalyticsSettings");

        private static gax::PathTemplate s_project = new gax::PathTemplate("projects/{project}/securityHealthAnalyticsSettings");

        /// <summary>
        /// Creates a <see cref="SecurityHealthAnalyticsSettingsName"/> containing an unparsed resource name.
        /// </summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="SecurityHealthAnalyticsSettingsName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static SecurityHealthAnalyticsSettingsName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new SecurityHealthAnalyticsSettingsName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="SecurityHealthAnalyticsSettingsName"/> with the pattern
        /// <c>organizations/{organization}/securityHealthAnalyticsSettings</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// A new instance of <see cref="SecurityHealthAnalyticsSettingsName"/> constructed from the provided ids.
        /// </returns>
        public static SecurityHealthAnalyticsSettingsName FromOrganization(string organizationId) =>
            new SecurityHealthAnalyticsSettingsName(ResourceNameType.Organization, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)));

        /// <summary>
        /// Creates a <see cref="SecurityHealthAnalyticsSettingsName"/> with the pattern
        /// <c>folders/{folder}/securityHealthAnalyticsSettings</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// A new instance of <see cref="SecurityHealthAnalyticsSettingsName"/> constructed from the provided ids.
        /// </returns>
        public static SecurityHealthAnalyticsSettingsName FromFolder(string folderId) =>
            new SecurityHealthAnalyticsSettingsName(ResourceNameType.Folder, folderId: gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)));

        /// <summary>
        /// Creates a <see cref="SecurityHealthAnalyticsSettingsName"/> with the pattern
        /// <c>projects/{project}/securityHealthAnalyticsSettings</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// A new instance of <see cref="SecurityHealthAnalyticsSettingsName"/> constructed from the provided ids.
        /// </returns>
        public static SecurityHealthAnalyticsSettingsName FromProject(string projectId) =>
            new SecurityHealthAnalyticsSettingsName(ResourceNameType.Project, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SecurityHealthAnalyticsSettingsName"/>
        /// with pattern <c>organizations/{organization}/securityHealthAnalyticsSettings</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SecurityHealthAnalyticsSettingsName"/> with pattern
        /// <c>organizations/{organization}/securityHealthAnalyticsSettings</c>.
        /// </returns>
        public static string Format(string organizationId) => FormatOrganization(organizationId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SecurityHealthAnalyticsSettingsName"/>
        /// with pattern <c>organizations/{organization}/securityHealthAnalyticsSettings</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SecurityHealthAnalyticsSettingsName"/> with pattern
        /// <c>organizations/{organization}/securityHealthAnalyticsSettings</c>.
        /// </returns>
        public static string FormatOrganization(string organizationId) =>
            s_organization.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SecurityHealthAnalyticsSettingsName"/>
        /// with pattern <c>folders/{folder}/securityHealthAnalyticsSettings</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SecurityHealthAnalyticsSettingsName"/> with pattern
        /// <c>folders/{folder}/securityHealthAnalyticsSettings</c>.
        /// </returns>
        public static string FormatFolder(string folderId) =>
            s_folder.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SecurityHealthAnalyticsSettingsName"/>
        /// with pattern <c>projects/{project}/securityHealthAnalyticsSettings</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SecurityHealthAnalyticsSettingsName"/> with pattern
        /// <c>projects/{project}/securityHealthAnalyticsSettings</c>.
        /// </returns>
        public static string FormatProject(string projectId) =>
            s_project.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="SecurityHealthAnalyticsSettingsName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>organizations/{organization}/securityHealthAnalyticsSettings</c></description></item>
        /// <item><description><c>folders/{folder}/securityHealthAnalyticsSettings</c></description></item>
        /// <item><description><c>projects/{project}/securityHealthAnalyticsSettings</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="securityHealthAnalyticsSettingsName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <returns>The parsed <see cref="SecurityHealthAnalyticsSettingsName"/> if successful.</returns>
        public static SecurityHealthAnalyticsSettingsName Parse(string securityHealthAnalyticsSettingsName) =>
            Parse(securityHealthAnalyticsSettingsName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="SecurityHealthAnalyticsSettingsName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>organizations/{organization}/securityHealthAnalyticsSettings</c></description></item>
        /// <item><description><c>folders/{folder}/securityHealthAnalyticsSettings</c></description></item>
        /// <item><description><c>projects/{project}/securityHealthAnalyticsSettings</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="securityHealthAnalyticsSettingsName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="SecurityHealthAnalyticsSettingsName"/> if successful.</returns>
        public static SecurityHealthAnalyticsSettingsName Parse(string securityHealthAnalyticsSettingsName, bool allowUnparsed) =>
            TryParse(securityHealthAnalyticsSettingsName, allowUnparsed, out SecurityHealthAnalyticsSettingsName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SecurityHealthAnalyticsSettingsName"/>
        /// instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>organizations/{organization}/securityHealthAnalyticsSettings</c></description></item>
        /// <item><description><c>folders/{folder}/securityHealthAnalyticsSettings</c></description></item>
        /// <item><description><c>projects/{project}/securityHealthAnalyticsSettings</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="securityHealthAnalyticsSettingsName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SecurityHealthAnalyticsSettingsName"/>, or <c>null</c> if
        /// parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string securityHealthAnalyticsSettingsName, out SecurityHealthAnalyticsSettingsName result) =>
            TryParse(securityHealthAnalyticsSettingsName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SecurityHealthAnalyticsSettingsName"/>
        /// instance; optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>organizations/{organization}/securityHealthAnalyticsSettings</c></description></item>
        /// <item><description><c>folders/{folder}/securityHealthAnalyticsSettings</c></description></item>
        /// <item><description><c>projects/{project}/securityHealthAnalyticsSettings</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="securityHealthAnalyticsSettingsName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SecurityHealthAnalyticsSettingsName"/>, or <c>null</c> if
        /// parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string securityHealthAnalyticsSettingsName, bool allowUnparsed, out SecurityHealthAnalyticsSettingsName result)
        {
            gax::GaxPreconditions.CheckNotNull(securityHealthAnalyticsSettingsName, nameof(securityHealthAnalyticsSettingsName));
            gax::TemplatedResourceName resourceName;
            if (s_organization.TryParseName(securityHealthAnalyticsSettingsName, out resourceName))
            {
                result = FromOrganization(resourceName[0]);
                return true;
            }
            if (s_folder.TryParseName(securityHealthAnalyticsSettingsName, out resourceName))
            {
                result = FromFolder(resourceName[0]);
                return true;
            }
            if (s_project.TryParseName(securityHealthAnalyticsSettingsName, out resourceName))
            {
                result = FromProject(resourceName[0]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(securityHealthAnalyticsSettingsName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private SecurityHealthAnalyticsSettingsName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string folderId = null, string organizationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            FolderId = folderId;
            OrganizationId = organizationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="SecurityHealthAnalyticsSettingsName"/> class from the component
        /// parts of pattern <c>organizations/{organization}/securityHealthAnalyticsSettings</c>
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        public SecurityHealthAnalyticsSettingsName(string organizationId) : this(ResourceNameType.Organization, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)))
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
                case ResourceNameType.Organization: return s_organization.Expand(OrganizationId);
                case ResourceNameType.Folder: return s_folder.Expand(FolderId);
                case ResourceNameType.Project: return s_project.Expand(ProjectId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as SecurityHealthAnalyticsSettingsName);

        /// <inheritdoc/>
        public bool Equals(SecurityHealthAnalyticsSettingsName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(SecurityHealthAnalyticsSettingsName a, SecurityHealthAnalyticsSettingsName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(SecurityHealthAnalyticsSettingsName a, SecurityHealthAnalyticsSettingsName b) => !(a == b);
    }

    public partial class SecurityHealthAnalyticsCustomModule
    {
        /// <summary>
        /// <see cref="gcsv::SecurityHealthAnalyticsCustomModuleName"/>-typed view over the <see cref="Name"/> resource
        /// name property.
        /// </summary>
        public gcsv::SecurityHealthAnalyticsCustomModuleName SecurityHealthAnalyticsCustomModuleName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcsv::SecurityHealthAnalyticsCustomModuleName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gcsv::SecurityHealthAnalyticsCustomModuleName"/>-typed view over the <see cref="AncestorModule"/>
        /// resource name property.
        /// </summary>
        public gcsv::SecurityHealthAnalyticsCustomModuleName AncestorModuleAsSecurityHealthAnalyticsCustomModuleName
        {
            get => string.IsNullOrEmpty(AncestorModule) ? null : gcsv::SecurityHealthAnalyticsCustomModuleName.Parse(AncestorModule, allowUnparsed: true);
            set => AncestorModule = value?.ToString() ?? "";
        }
    }
}
