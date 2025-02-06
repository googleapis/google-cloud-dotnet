// Copyright 2025 Google LLC
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
    /// <summary>Resource name for the <c>SecurityMarks</c> resource.</summary>
    public sealed partial class SecurityMarksName : gax::IResourceName, sys::IEquatable<SecurityMarksName>
    {
        /// <summary>The possible contents of <see cref="SecurityMarksName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>organizations/{organization}/assets/{asset}/securityMarks</c>.
            /// </summary>
            OrganizationAsset = 1,

            /// <summary>
            /// A resource name with pattern
            /// <c>organizations/{organization}/sources/{source}/findings/{finding}/securityMarks</c>.
            /// </summary>
            OrganizationSourceFinding = 2,

            /// <summary>A resource name with pattern <c>folders/{folder}/assets/{asset}/securityMarks</c>.</summary>
            FolderAsset = 3,

            /// <summary>A resource name with pattern <c>projects/{project}/assets/{asset}/securityMarks</c>.</summary>
            ProjectAsset = 4,

            /// <summary>
            /// A resource name with pattern <c>folders/{folder}/sources/{source}/findings/{finding}/securityMarks</c>.
            /// </summary>
            FolderSourceFinding = 5,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/sources/{source}/findings/{finding}/securityMarks</c>
            /// .
            /// </summary>
            ProjectSourceFinding = 6,
        }

        private static gax::PathTemplate s_organizationAsset = new gax::PathTemplate("organizations/{organization}/assets/{asset}/securityMarks");

        private static gax::PathTemplate s_organizationSourceFinding = new gax::PathTemplate("organizations/{organization}/sources/{source}/findings/{finding}/securityMarks");

        private static gax::PathTemplate s_folderAsset = new gax::PathTemplate("folders/{folder}/assets/{asset}/securityMarks");

        private static gax::PathTemplate s_projectAsset = new gax::PathTemplate("projects/{project}/assets/{asset}/securityMarks");

        private static gax::PathTemplate s_folderSourceFinding = new gax::PathTemplate("folders/{folder}/sources/{source}/findings/{finding}/securityMarks");

        private static gax::PathTemplate s_projectSourceFinding = new gax::PathTemplate("projects/{project}/sources/{source}/findings/{finding}/securityMarks");

        /// <summary>Creates a <see cref="SecurityMarksName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="SecurityMarksName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static SecurityMarksName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new SecurityMarksName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="SecurityMarksName"/> with the pattern
        /// <c>organizations/{organization}/assets/{asset}/securityMarks</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="assetId">The <c>Asset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="SecurityMarksName"/> constructed from the provided ids.</returns>
        public static SecurityMarksName FromOrganizationAsset(string organizationId, string assetId) =>
            new SecurityMarksName(ResourceNameType.OrganizationAsset, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), assetId: gax::GaxPreconditions.CheckNotNullOrEmpty(assetId, nameof(assetId)));

        /// <summary>
        /// Creates a <see cref="SecurityMarksName"/> with the pattern
        /// <c>organizations/{organization}/sources/{source}/findings/{finding}/securityMarks</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sourceId">The <c>Source</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="findingId">The <c>Finding</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="SecurityMarksName"/> constructed from the provided ids.</returns>
        public static SecurityMarksName FromOrganizationSourceFinding(string organizationId, string sourceId, string findingId) =>
            new SecurityMarksName(ResourceNameType.OrganizationSourceFinding, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), sourceId: gax::GaxPreconditions.CheckNotNullOrEmpty(sourceId, nameof(sourceId)), findingId: gax::GaxPreconditions.CheckNotNullOrEmpty(findingId, nameof(findingId)));

        /// <summary>
        /// Creates a <see cref="SecurityMarksName"/> with the pattern <c>folders/{folder}/assets/{asset}/securityMarks</c>
        /// .
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="assetId">The <c>Asset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="SecurityMarksName"/> constructed from the provided ids.</returns>
        public static SecurityMarksName FromFolderAsset(string folderId, string assetId) =>
            new SecurityMarksName(ResourceNameType.FolderAsset, folderId: gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), assetId: gax::GaxPreconditions.CheckNotNullOrEmpty(assetId, nameof(assetId)));

        /// <summary>
        /// Creates a <see cref="SecurityMarksName"/> with the pattern
        /// <c>projects/{project}/assets/{asset}/securityMarks</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="assetId">The <c>Asset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="SecurityMarksName"/> constructed from the provided ids.</returns>
        public static SecurityMarksName FromProjectAsset(string projectId, string assetId) =>
            new SecurityMarksName(ResourceNameType.ProjectAsset, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), assetId: gax::GaxPreconditions.CheckNotNullOrEmpty(assetId, nameof(assetId)));

        /// <summary>
        /// Creates a <see cref="SecurityMarksName"/> with the pattern
        /// <c>folders/{folder}/sources/{source}/findings/{finding}/securityMarks</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sourceId">The <c>Source</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="findingId">The <c>Finding</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="SecurityMarksName"/> constructed from the provided ids.</returns>
        public static SecurityMarksName FromFolderSourceFinding(string folderId, string sourceId, string findingId) =>
            new SecurityMarksName(ResourceNameType.FolderSourceFinding, folderId: gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), sourceId: gax::GaxPreconditions.CheckNotNullOrEmpty(sourceId, nameof(sourceId)), findingId: gax::GaxPreconditions.CheckNotNullOrEmpty(findingId, nameof(findingId)));

        /// <summary>
        /// Creates a <see cref="SecurityMarksName"/> with the pattern
        /// <c>projects/{project}/sources/{source}/findings/{finding}/securityMarks</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sourceId">The <c>Source</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="findingId">The <c>Finding</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="SecurityMarksName"/> constructed from the provided ids.</returns>
        public static SecurityMarksName FromProjectSourceFinding(string projectId, string sourceId, string findingId) =>
            new SecurityMarksName(ResourceNameType.ProjectSourceFinding, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), sourceId: gax::GaxPreconditions.CheckNotNullOrEmpty(sourceId, nameof(sourceId)), findingId: gax::GaxPreconditions.CheckNotNullOrEmpty(findingId, nameof(findingId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SecurityMarksName"/> with pattern
        /// <c>organizations/{organization}/assets/{asset}/securityMarks</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="assetId">The <c>Asset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SecurityMarksName"/> with pattern
        /// <c>organizations/{organization}/assets/{asset}/securityMarks</c>.
        /// </returns>
        public static string Format(string organizationId, string assetId) => FormatOrganizationAsset(organizationId, assetId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SecurityMarksName"/> with pattern
        /// <c>organizations/{organization}/assets/{asset}/securityMarks</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="assetId">The <c>Asset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SecurityMarksName"/> with pattern
        /// <c>organizations/{organization}/assets/{asset}/securityMarks</c>.
        /// </returns>
        public static string FormatOrganizationAsset(string organizationId, string assetId) =>
            s_organizationAsset.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(assetId, nameof(assetId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SecurityMarksName"/> with pattern
        /// <c>organizations/{organization}/sources/{source}/findings/{finding}/securityMarks</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sourceId">The <c>Source</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="findingId">The <c>Finding</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SecurityMarksName"/> with pattern
        /// <c>organizations/{organization}/sources/{source}/findings/{finding}/securityMarks</c>.
        /// </returns>
        public static string FormatOrganizationSourceFinding(string organizationId, string sourceId, string findingId) =>
            s_organizationSourceFinding.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(sourceId, nameof(sourceId)), gax::GaxPreconditions.CheckNotNullOrEmpty(findingId, nameof(findingId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SecurityMarksName"/> with pattern
        /// <c>folders/{folder}/assets/{asset}/securityMarks</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="assetId">The <c>Asset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SecurityMarksName"/> with pattern
        /// <c>folders/{folder}/assets/{asset}/securityMarks</c>.
        /// </returns>
        public static string FormatFolderAsset(string folderId, string assetId) =>
            s_folderAsset.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), gax::GaxPreconditions.CheckNotNullOrEmpty(assetId, nameof(assetId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SecurityMarksName"/> with pattern
        /// <c>projects/{project}/assets/{asset}/securityMarks</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="assetId">The <c>Asset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SecurityMarksName"/> with pattern
        /// <c>projects/{project}/assets/{asset}/securityMarks</c>.
        /// </returns>
        public static string FormatProjectAsset(string projectId, string assetId) =>
            s_projectAsset.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(assetId, nameof(assetId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SecurityMarksName"/> with pattern
        /// <c>folders/{folder}/sources/{source}/findings/{finding}/securityMarks</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sourceId">The <c>Source</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="findingId">The <c>Finding</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SecurityMarksName"/> with pattern
        /// <c>folders/{folder}/sources/{source}/findings/{finding}/securityMarks</c>.
        /// </returns>
        public static string FormatFolderSourceFinding(string folderId, string sourceId, string findingId) =>
            s_folderSourceFinding.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), gax::GaxPreconditions.CheckNotNullOrEmpty(sourceId, nameof(sourceId)), gax::GaxPreconditions.CheckNotNullOrEmpty(findingId, nameof(findingId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SecurityMarksName"/> with pattern
        /// <c>projects/{project}/sources/{source}/findings/{finding}/securityMarks</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sourceId">The <c>Source</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="findingId">The <c>Finding</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SecurityMarksName"/> with pattern
        /// <c>projects/{project}/sources/{source}/findings/{finding}/securityMarks</c>.
        /// </returns>
        public static string FormatProjectSourceFinding(string projectId, string sourceId, string findingId) =>
            s_projectSourceFinding.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(sourceId, nameof(sourceId)), gax::GaxPreconditions.CheckNotNullOrEmpty(findingId, nameof(findingId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="SecurityMarksName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>organizations/{organization}/assets/{asset}/securityMarks</c></description></item>
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/sources/{source}/findings/{finding}/securityMarks</c>
        /// </description>
        /// </item>
        /// <item><description><c>folders/{folder}/assets/{asset}/securityMarks</c></description></item>
        /// <item><description><c>projects/{project}/assets/{asset}/securityMarks</c></description></item>
        /// <item>
        /// <description><c>folders/{folder}/sources/{source}/findings/{finding}/securityMarks</c></description>
        /// </item>
        /// <item>
        /// <description><c>projects/{project}/sources/{source}/findings/{finding}/securityMarks</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="securityMarksName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="SecurityMarksName"/> if successful.</returns>
        public static SecurityMarksName Parse(string securityMarksName) => Parse(securityMarksName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="SecurityMarksName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>organizations/{organization}/assets/{asset}/securityMarks</c></description></item>
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/sources/{source}/findings/{finding}/securityMarks</c>
        /// </description>
        /// </item>
        /// <item><description><c>folders/{folder}/assets/{asset}/securityMarks</c></description></item>
        /// <item><description><c>projects/{project}/assets/{asset}/securityMarks</c></description></item>
        /// <item>
        /// <description><c>folders/{folder}/sources/{source}/findings/{finding}/securityMarks</c></description>
        /// </item>
        /// <item>
        /// <description><c>projects/{project}/sources/{source}/findings/{finding}/securityMarks</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="securityMarksName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="SecurityMarksName"/> if successful.</returns>
        public static SecurityMarksName Parse(string securityMarksName, bool allowUnparsed) =>
            TryParse(securityMarksName, allowUnparsed, out SecurityMarksName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SecurityMarksName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>organizations/{organization}/assets/{asset}/securityMarks</c></description></item>
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/sources/{source}/findings/{finding}/securityMarks</c>
        /// </description>
        /// </item>
        /// <item><description><c>folders/{folder}/assets/{asset}/securityMarks</c></description></item>
        /// <item><description><c>projects/{project}/assets/{asset}/securityMarks</c></description></item>
        /// <item>
        /// <description><c>folders/{folder}/sources/{source}/findings/{finding}/securityMarks</c></description>
        /// </item>
        /// <item>
        /// <description><c>projects/{project}/sources/{source}/findings/{finding}/securityMarks</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="securityMarksName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SecurityMarksName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string securityMarksName, out SecurityMarksName result) =>
            TryParse(securityMarksName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SecurityMarksName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>organizations/{organization}/assets/{asset}/securityMarks</c></description></item>
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/sources/{source}/findings/{finding}/securityMarks</c>
        /// </description>
        /// </item>
        /// <item><description><c>folders/{folder}/assets/{asset}/securityMarks</c></description></item>
        /// <item><description><c>projects/{project}/assets/{asset}/securityMarks</c></description></item>
        /// <item>
        /// <description><c>folders/{folder}/sources/{source}/findings/{finding}/securityMarks</c></description>
        /// </item>
        /// <item>
        /// <description><c>projects/{project}/sources/{source}/findings/{finding}/securityMarks</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="securityMarksName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SecurityMarksName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string securityMarksName, bool allowUnparsed, out SecurityMarksName result)
        {
            gax::GaxPreconditions.CheckNotNull(securityMarksName, nameof(securityMarksName));
            gax::TemplatedResourceName resourceName;
            if (s_organizationAsset.TryParseName(securityMarksName, out resourceName))
            {
                result = FromOrganizationAsset(resourceName[0], resourceName[1]);
                return true;
            }
            if (s_organizationSourceFinding.TryParseName(securityMarksName, out resourceName))
            {
                result = FromOrganizationSourceFinding(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (s_folderAsset.TryParseName(securityMarksName, out resourceName))
            {
                result = FromFolderAsset(resourceName[0], resourceName[1]);
                return true;
            }
            if (s_projectAsset.TryParseName(securityMarksName, out resourceName))
            {
                result = FromProjectAsset(resourceName[0], resourceName[1]);
                return true;
            }
            if (s_folderSourceFinding.TryParseName(securityMarksName, out resourceName))
            {
                result = FromFolderSourceFinding(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (s_projectSourceFinding.TryParseName(securityMarksName, out resourceName))
            {
                result = FromProjectSourceFinding(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(securityMarksName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private SecurityMarksName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string assetId = null, string findingId = null, string folderId = null, string organizationId = null, string projectId = null, string sourceId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AssetId = assetId;
            FindingId = findingId;
            FolderId = folderId;
            OrganizationId = organizationId;
            ProjectId = projectId;
            SourceId = sourceId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="SecurityMarksName"/> class from the component parts of pattern
        /// <c>organizations/{organization}/assets/{asset}/securityMarks</c>
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="assetId">The <c>Asset</c> ID. Must not be <c>null</c> or empty.</param>
        public SecurityMarksName(string organizationId, string assetId) : this(ResourceNameType.OrganizationAsset, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), assetId: gax::GaxPreconditions.CheckNotNullOrEmpty(assetId, nameof(assetId)))
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
        /// The <c>Asset</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string AssetId { get; }

        /// <summary>
        /// The <c>Finding</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string FindingId { get; }

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

        /// <summary>
        /// The <c>Source</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string SourceId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.OrganizationAsset: return s_organizationAsset.Expand(OrganizationId, AssetId);
                case ResourceNameType.OrganizationSourceFinding: return s_organizationSourceFinding.Expand(OrganizationId, SourceId, FindingId);
                case ResourceNameType.FolderAsset: return s_folderAsset.Expand(FolderId, AssetId);
                case ResourceNameType.ProjectAsset: return s_projectAsset.Expand(ProjectId, AssetId);
                case ResourceNameType.FolderSourceFinding: return s_folderSourceFinding.Expand(FolderId, SourceId, FindingId);
                case ResourceNameType.ProjectSourceFinding: return s_projectSourceFinding.Expand(ProjectId, SourceId, FindingId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as SecurityMarksName);

        /// <inheritdoc/>
        public bool Equals(SecurityMarksName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(SecurityMarksName a, SecurityMarksName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(SecurityMarksName a, SecurityMarksName b) => !(a == b);
    }

    public partial class SecurityMarks
    {
        /// <summary>
        /// <see cref="gcsv::SecurityMarksName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcsv::SecurityMarksName SecurityMarksName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcsv::SecurityMarksName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
