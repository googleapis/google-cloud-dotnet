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
using gagr = Google.Api.Gax.ResourceNames;
using gax = Google.Api.Gax;
using gcav = Google.Cloud.AccessApproval.V1;
using sys = System;

namespace Google.Cloud.AccessApproval.V1
{
    /// <summary>Resource name for the <c>ApprovalRequest</c> resource.</summary>
    public sealed partial class ApprovalRequestName : gax::IResourceName, sys::IEquatable<ApprovalRequestName>
    {
        /// <summary>The possible contents of <see cref="ApprovalRequestName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/approvalRequests/{approval_request}</c>.
            /// </summary>
            ProjectApprovalRequest = 1,

            /// <summary>
            /// A resource name with pattern <c>folders/{folder}/approvalRequests/{approval_request}</c>.
            /// </summary>
            FolderApprovalRequest = 2,

            /// <summary>
            /// A resource name with pattern <c>organizations/{organization}/approvalRequests/{approval_request}</c>.
            /// </summary>
            OrganizationApprovalRequest = 3,
        }

        private static gax::PathTemplate s_projectApprovalRequest = new gax::PathTemplate("projects/{project}/approvalRequests/{approval_request}");

        private static gax::PathTemplate s_folderApprovalRequest = new gax::PathTemplate("folders/{folder}/approvalRequests/{approval_request}");

        private static gax::PathTemplate s_organizationApprovalRequest = new gax::PathTemplate("organizations/{organization}/approvalRequests/{approval_request}");

        /// <summary>Creates a <see cref="ApprovalRequestName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ApprovalRequestName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ApprovalRequestName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ApprovalRequestName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ApprovalRequestName"/> with the pattern
        /// <c>projects/{project}/approvalRequests/{approval_request}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="approvalRequestId">The <c>ApprovalRequest</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ApprovalRequestName"/> constructed from the provided ids.</returns>
        public static ApprovalRequestName FromProjectApprovalRequest(string projectId, string approvalRequestId) =>
            new ApprovalRequestName(ResourceNameType.ProjectApprovalRequest, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), approvalRequestId: gax::GaxPreconditions.CheckNotNullOrEmpty(approvalRequestId, nameof(approvalRequestId)));

        /// <summary>
        /// Creates a <see cref="ApprovalRequestName"/> with the pattern
        /// <c>folders/{folder}/approvalRequests/{approval_request}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="approvalRequestId">The <c>ApprovalRequest</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ApprovalRequestName"/> constructed from the provided ids.</returns>
        public static ApprovalRequestName FromFolderApprovalRequest(string folderId, string approvalRequestId) =>
            new ApprovalRequestName(ResourceNameType.FolderApprovalRequest, folderId: gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), approvalRequestId: gax::GaxPreconditions.CheckNotNullOrEmpty(approvalRequestId, nameof(approvalRequestId)));

        /// <summary>
        /// Creates a <see cref="ApprovalRequestName"/> with the pattern
        /// <c>organizations/{organization}/approvalRequests/{approval_request}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="approvalRequestId">The <c>ApprovalRequest</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ApprovalRequestName"/> constructed from the provided ids.</returns>
        public static ApprovalRequestName FromOrganizationApprovalRequest(string organizationId, string approvalRequestId) =>
            new ApprovalRequestName(ResourceNameType.OrganizationApprovalRequest, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), approvalRequestId: gax::GaxPreconditions.CheckNotNullOrEmpty(approvalRequestId, nameof(approvalRequestId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ApprovalRequestName"/> with pattern
        /// <c>projects/{project}/approvalRequests/{approval_request}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="approvalRequestId">The <c>ApprovalRequest</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ApprovalRequestName"/> with pattern
        /// <c>projects/{project}/approvalRequests/{approval_request}</c>.
        /// </returns>
        public static string Format(string projectId, string approvalRequestId) =>
            FormatProjectApprovalRequest(projectId, approvalRequestId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ApprovalRequestName"/> with pattern
        /// <c>projects/{project}/approvalRequests/{approval_request}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="approvalRequestId">The <c>ApprovalRequest</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ApprovalRequestName"/> with pattern
        /// <c>projects/{project}/approvalRequests/{approval_request}</c>.
        /// </returns>
        public static string FormatProjectApprovalRequest(string projectId, string approvalRequestId) =>
            s_projectApprovalRequest.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(approvalRequestId, nameof(approvalRequestId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ApprovalRequestName"/> with pattern
        /// <c>folders/{folder}/approvalRequests/{approval_request}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="approvalRequestId">The <c>ApprovalRequest</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ApprovalRequestName"/> with pattern
        /// <c>folders/{folder}/approvalRequests/{approval_request}</c>.
        /// </returns>
        public static string FormatFolderApprovalRequest(string folderId, string approvalRequestId) =>
            s_folderApprovalRequest.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), gax::GaxPreconditions.CheckNotNullOrEmpty(approvalRequestId, nameof(approvalRequestId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ApprovalRequestName"/> with pattern
        /// <c>organizations/{organization}/approvalRequests/{approval_request}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="approvalRequestId">The <c>ApprovalRequest</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ApprovalRequestName"/> with pattern
        /// <c>organizations/{organization}/approvalRequests/{approval_request}</c>.
        /// </returns>
        public static string FormatOrganizationApprovalRequest(string organizationId, string approvalRequestId) =>
            s_organizationApprovalRequest.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(approvalRequestId, nameof(approvalRequestId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ApprovalRequestName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/approvalRequests/{approval_request}</c></description></item>
        /// <item><description><c>folders/{folder}/approvalRequests/{approval_request}</c></description></item>
        /// <item>
        /// <description><c>organizations/{organization}/approvalRequests/{approval_request}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="approvalRequestName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ApprovalRequestName"/> if successful.</returns>
        public static ApprovalRequestName Parse(string approvalRequestName) => Parse(approvalRequestName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ApprovalRequestName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/approvalRequests/{approval_request}</c></description></item>
        /// <item><description><c>folders/{folder}/approvalRequests/{approval_request}</c></description></item>
        /// <item>
        /// <description><c>organizations/{organization}/approvalRequests/{approval_request}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="approvalRequestName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ApprovalRequestName"/> if successful.</returns>
        public static ApprovalRequestName Parse(string approvalRequestName, bool allowUnparsed) =>
            TryParse(approvalRequestName, allowUnparsed, out ApprovalRequestName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ApprovalRequestName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/approvalRequests/{approval_request}</c></description></item>
        /// <item><description><c>folders/{folder}/approvalRequests/{approval_request}</c></description></item>
        /// <item>
        /// <description><c>organizations/{organization}/approvalRequests/{approval_request}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="approvalRequestName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ApprovalRequestName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string approvalRequestName, out ApprovalRequestName result) =>
            TryParse(approvalRequestName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ApprovalRequestName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/approvalRequests/{approval_request}</c></description></item>
        /// <item><description><c>folders/{folder}/approvalRequests/{approval_request}</c></description></item>
        /// <item>
        /// <description><c>organizations/{organization}/approvalRequests/{approval_request}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="approvalRequestName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ApprovalRequestName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string approvalRequestName, bool allowUnparsed, out ApprovalRequestName result)
        {
            gax::GaxPreconditions.CheckNotNull(approvalRequestName, nameof(approvalRequestName));
            gax::TemplatedResourceName resourceName;
            if (s_projectApprovalRequest.TryParseName(approvalRequestName, out resourceName))
            {
                result = FromProjectApprovalRequest(resourceName[0], resourceName[1]);
                return true;
            }
            if (s_folderApprovalRequest.TryParseName(approvalRequestName, out resourceName))
            {
                result = FromFolderApprovalRequest(resourceName[0], resourceName[1]);
                return true;
            }
            if (s_organizationApprovalRequest.TryParseName(approvalRequestName, out resourceName))
            {
                result = FromOrganizationApprovalRequest(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(approvalRequestName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ApprovalRequestName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string approvalRequestId = null, string folderId = null, string organizationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ApprovalRequestId = approvalRequestId;
            FolderId = folderId;
            OrganizationId = organizationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ApprovalRequestName"/> class from the component parts of pattern
        /// <c>projects/{project}/approvalRequests/{approval_request}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="approvalRequestId">The <c>ApprovalRequest</c> ID. Must not be <c>null</c> or empty.</param>
        public ApprovalRequestName(string projectId, string approvalRequestId) : this(ResourceNameType.ProjectApprovalRequest, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), approvalRequestId: gax::GaxPreconditions.CheckNotNullOrEmpty(approvalRequestId, nameof(approvalRequestId)))
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
        /// The <c>ApprovalRequest</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string ApprovalRequestId { get; }

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
                case ResourceNameType.ProjectApprovalRequest: return s_projectApprovalRequest.Expand(ProjectId, ApprovalRequestId);
                case ResourceNameType.FolderApprovalRequest: return s_folderApprovalRequest.Expand(FolderId, ApprovalRequestId);
                case ResourceNameType.OrganizationApprovalRequest: return s_organizationApprovalRequest.Expand(OrganizationId, ApprovalRequestId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ApprovalRequestName);

        /// <inheritdoc/>
        public bool Equals(ApprovalRequestName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ApprovalRequestName a, ApprovalRequestName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ApprovalRequestName a, ApprovalRequestName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>AccessApprovalSettings</c> resource.</summary>
    public sealed partial class AccessApprovalSettingsName : gax::IResourceName, sys::IEquatable<AccessApprovalSettingsName>
    {
        /// <summary>The possible contents of <see cref="AccessApprovalSettingsName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>projects/{project}/accessApprovalSettings</c>.</summary>
            Project = 1,

            /// <summary>A resource name with pattern <c>folders/{folder}/accessApprovalSettings</c>.</summary>
            Folder = 2,

            /// <summary>
            /// A resource name with pattern <c>organizations/{organization}/accessApprovalSettings</c>.
            /// </summary>
            Organization = 3,
        }

        private static gax::PathTemplate s_project = new gax::PathTemplate("projects/{project}/accessApprovalSettings");

        private static gax::PathTemplate s_folder = new gax::PathTemplate("folders/{folder}/accessApprovalSettings");

        private static gax::PathTemplate s_organization = new gax::PathTemplate("organizations/{organization}/accessApprovalSettings");

        /// <summary>Creates a <see cref="AccessApprovalSettingsName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="AccessApprovalSettingsName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static AccessApprovalSettingsName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new AccessApprovalSettingsName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="AccessApprovalSettingsName"/> with the pattern
        /// <c>projects/{project}/accessApprovalSettings</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// A new instance of <see cref="AccessApprovalSettingsName"/> constructed from the provided ids.
        /// </returns>
        public static AccessApprovalSettingsName FromProject(string projectId) =>
            new AccessApprovalSettingsName(ResourceNameType.Project, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)));

        /// <summary>
        /// Creates a <see cref="AccessApprovalSettingsName"/> with the pattern
        /// <c>folders/{folder}/accessApprovalSettings</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// A new instance of <see cref="AccessApprovalSettingsName"/> constructed from the provided ids.
        /// </returns>
        public static AccessApprovalSettingsName FromFolder(string folderId) =>
            new AccessApprovalSettingsName(ResourceNameType.Folder, folderId: gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)));

        /// <summary>
        /// Creates a <see cref="AccessApprovalSettingsName"/> with the pattern
        /// <c>organizations/{organization}/accessApprovalSettings</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// A new instance of <see cref="AccessApprovalSettingsName"/> constructed from the provided ids.
        /// </returns>
        public static AccessApprovalSettingsName FromOrganization(string organizationId) =>
            new AccessApprovalSettingsName(ResourceNameType.Organization, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AccessApprovalSettingsName"/> with pattern
        /// <c>projects/{project}/accessApprovalSettings</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AccessApprovalSettingsName"/> with pattern
        /// <c>projects/{project}/accessApprovalSettings</c>.
        /// </returns>
        public static string Format(string projectId) => FormatProject(projectId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AccessApprovalSettingsName"/> with pattern
        /// <c>projects/{project}/accessApprovalSettings</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AccessApprovalSettingsName"/> with pattern
        /// <c>projects/{project}/accessApprovalSettings</c>.
        /// </returns>
        public static string FormatProject(string projectId) =>
            s_project.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AccessApprovalSettingsName"/> with pattern
        /// <c>folders/{folder}/accessApprovalSettings</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AccessApprovalSettingsName"/> with pattern
        /// <c>folders/{folder}/accessApprovalSettings</c>.
        /// </returns>
        public static string FormatFolder(string folderId) =>
            s_folder.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AccessApprovalSettingsName"/> with pattern
        /// <c>organizations/{organization}/accessApprovalSettings</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AccessApprovalSettingsName"/> with pattern
        /// <c>organizations/{organization}/accessApprovalSettings</c>.
        /// </returns>
        public static string FormatOrganization(string organizationId) =>
            s_organization.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AccessApprovalSettingsName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/accessApprovalSettings</c></description></item>
        /// <item><description><c>folders/{folder}/accessApprovalSettings</c></description></item>
        /// <item><description><c>organizations/{organization}/accessApprovalSettings</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="accessApprovalSettingsName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AccessApprovalSettingsName"/> if successful.</returns>
        public static AccessApprovalSettingsName Parse(string accessApprovalSettingsName) =>
            Parse(accessApprovalSettingsName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AccessApprovalSettingsName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/accessApprovalSettings</c></description></item>
        /// <item><description><c>folders/{folder}/accessApprovalSettings</c></description></item>
        /// <item><description><c>organizations/{organization}/accessApprovalSettings</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="accessApprovalSettingsName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="AccessApprovalSettingsName"/> if successful.</returns>
        public static AccessApprovalSettingsName Parse(string accessApprovalSettingsName, bool allowUnparsed) =>
            TryParse(accessApprovalSettingsName, allowUnparsed, out AccessApprovalSettingsName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AccessApprovalSettingsName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/accessApprovalSettings</c></description></item>
        /// <item><description><c>folders/{folder}/accessApprovalSettings</c></description></item>
        /// <item><description><c>organizations/{organization}/accessApprovalSettings</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="accessApprovalSettingsName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AccessApprovalSettingsName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string accessApprovalSettingsName, out AccessApprovalSettingsName result) =>
            TryParse(accessApprovalSettingsName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AccessApprovalSettingsName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/accessApprovalSettings</c></description></item>
        /// <item><description><c>folders/{folder}/accessApprovalSettings</c></description></item>
        /// <item><description><c>organizations/{organization}/accessApprovalSettings</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="accessApprovalSettingsName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AccessApprovalSettingsName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string accessApprovalSettingsName, bool allowUnparsed, out AccessApprovalSettingsName result)
        {
            gax::GaxPreconditions.CheckNotNull(accessApprovalSettingsName, nameof(accessApprovalSettingsName));
            gax::TemplatedResourceName resourceName;
            if (s_project.TryParseName(accessApprovalSettingsName, out resourceName))
            {
                result = FromProject(resourceName[0]);
                return true;
            }
            if (s_folder.TryParseName(accessApprovalSettingsName, out resourceName))
            {
                result = FromFolder(resourceName[0]);
                return true;
            }
            if (s_organization.TryParseName(accessApprovalSettingsName, out resourceName))
            {
                result = FromOrganization(resourceName[0]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(accessApprovalSettingsName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private AccessApprovalSettingsName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string folderId = null, string organizationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            FolderId = folderId;
            OrganizationId = organizationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="AccessApprovalSettingsName"/> class from the component parts of
        /// pattern <c>projects/{project}/accessApprovalSettings</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        public AccessApprovalSettingsName(string projectId) : this(ResourceNameType.Project, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)))
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
                case ResourceNameType.Project: return s_project.Expand(ProjectId);
                case ResourceNameType.Folder: return s_folder.Expand(FolderId);
                case ResourceNameType.Organization: return s_organization.Expand(OrganizationId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as AccessApprovalSettingsName);

        /// <inheritdoc/>
        public bool Equals(AccessApprovalSettingsName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(AccessApprovalSettingsName a, AccessApprovalSettingsName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(AccessApprovalSettingsName a, AccessApprovalSettingsName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>AccessApprovalServiceAccount</c> resource.</summary>
    public sealed partial class AccessApprovalServiceAccountName : gax::IResourceName, sys::IEquatable<AccessApprovalServiceAccountName>
    {
        /// <summary>The possible contents of <see cref="AccessApprovalServiceAccountName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>projects/{project}/serviceAccount</c>.</summary>
            Project = 1,

            /// <summary>A resource name with pattern <c>folders/{folder}/serviceAccount</c>.</summary>
            Folder = 2,

            /// <summary>A resource name with pattern <c>organizations/{organization}/serviceAccount</c>.</summary>
            Organization = 3,
        }

        private static gax::PathTemplate s_project = new gax::PathTemplate("projects/{project}/serviceAccount");

        private static gax::PathTemplate s_folder = new gax::PathTemplate("folders/{folder}/serviceAccount");

        private static gax::PathTemplate s_organization = new gax::PathTemplate("organizations/{organization}/serviceAccount");

        /// <summary>
        /// Creates a <see cref="AccessApprovalServiceAccountName"/> containing an unparsed resource name.
        /// </summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="AccessApprovalServiceAccountName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static AccessApprovalServiceAccountName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new AccessApprovalServiceAccountName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="AccessApprovalServiceAccountName"/> with the pattern
        /// <c>projects/{project}/serviceAccount</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// A new instance of <see cref="AccessApprovalServiceAccountName"/> constructed from the provided ids.
        /// </returns>
        public static AccessApprovalServiceAccountName FromProject(string projectId) =>
            new AccessApprovalServiceAccountName(ResourceNameType.Project, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)));

        /// <summary>
        /// Creates a <see cref="AccessApprovalServiceAccountName"/> with the pattern <c>folders/{folder}/serviceAccount</c>
        /// .
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// A new instance of <see cref="AccessApprovalServiceAccountName"/> constructed from the provided ids.
        /// </returns>
        public static AccessApprovalServiceAccountName FromFolder(string folderId) =>
            new AccessApprovalServiceAccountName(ResourceNameType.Folder, folderId: gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)));

        /// <summary>
        /// Creates a <see cref="AccessApprovalServiceAccountName"/> with the pattern
        /// <c>organizations/{organization}/serviceAccount</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// A new instance of <see cref="AccessApprovalServiceAccountName"/> constructed from the provided ids.
        /// </returns>
        public static AccessApprovalServiceAccountName FromOrganization(string organizationId) =>
            new AccessApprovalServiceAccountName(ResourceNameType.Organization, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AccessApprovalServiceAccountName"/> with
        /// pattern <c>projects/{project}/serviceAccount</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AccessApprovalServiceAccountName"/> with pattern
        /// <c>projects/{project}/serviceAccount</c>.
        /// </returns>
        public static string Format(string projectId) => FormatProject(projectId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AccessApprovalServiceAccountName"/> with
        /// pattern <c>projects/{project}/serviceAccount</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AccessApprovalServiceAccountName"/> with pattern
        /// <c>projects/{project}/serviceAccount</c>.
        /// </returns>
        public static string FormatProject(string projectId) =>
            s_project.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AccessApprovalServiceAccountName"/> with
        /// pattern <c>folders/{folder}/serviceAccount</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AccessApprovalServiceAccountName"/> with pattern
        /// <c>folders/{folder}/serviceAccount</c>.
        /// </returns>
        public static string FormatFolder(string folderId) =>
            s_folder.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AccessApprovalServiceAccountName"/> with
        /// pattern <c>organizations/{organization}/serviceAccount</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AccessApprovalServiceAccountName"/> with pattern
        /// <c>organizations/{organization}/serviceAccount</c>.
        /// </returns>
        public static string FormatOrganization(string organizationId) =>
            s_organization.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AccessApprovalServiceAccountName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/serviceAccount</c></description></item>
        /// <item><description><c>folders/{folder}/serviceAccount</c></description></item>
        /// <item><description><c>organizations/{organization}/serviceAccount</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="accessApprovalServiceAccountName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <returns>The parsed <see cref="AccessApprovalServiceAccountName"/> if successful.</returns>
        public static AccessApprovalServiceAccountName Parse(string accessApprovalServiceAccountName) =>
            Parse(accessApprovalServiceAccountName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AccessApprovalServiceAccountName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/serviceAccount</c></description></item>
        /// <item><description><c>folders/{folder}/serviceAccount</c></description></item>
        /// <item><description><c>organizations/{organization}/serviceAccount</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="accessApprovalServiceAccountName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="AccessApprovalServiceAccountName"/> if successful.</returns>
        public static AccessApprovalServiceAccountName Parse(string accessApprovalServiceAccountName, bool allowUnparsed) =>
            TryParse(accessApprovalServiceAccountName, allowUnparsed, out AccessApprovalServiceAccountName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AccessApprovalServiceAccountName"/>
        /// instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/serviceAccount</c></description></item>
        /// <item><description><c>folders/{folder}/serviceAccount</c></description></item>
        /// <item><description><c>organizations/{organization}/serviceAccount</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="accessApprovalServiceAccountName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AccessApprovalServiceAccountName"/>, or <c>null</c> if
        /// parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string accessApprovalServiceAccountName, out AccessApprovalServiceAccountName result) =>
            TryParse(accessApprovalServiceAccountName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AccessApprovalServiceAccountName"/>
        /// instance; optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/serviceAccount</c></description></item>
        /// <item><description><c>folders/{folder}/serviceAccount</c></description></item>
        /// <item><description><c>organizations/{organization}/serviceAccount</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="accessApprovalServiceAccountName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AccessApprovalServiceAccountName"/>, or <c>null</c> if
        /// parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string accessApprovalServiceAccountName, bool allowUnparsed, out AccessApprovalServiceAccountName result)
        {
            gax::GaxPreconditions.CheckNotNull(accessApprovalServiceAccountName, nameof(accessApprovalServiceAccountName));
            gax::TemplatedResourceName resourceName;
            if (s_project.TryParseName(accessApprovalServiceAccountName, out resourceName))
            {
                result = FromProject(resourceName[0]);
                return true;
            }
            if (s_folder.TryParseName(accessApprovalServiceAccountName, out resourceName))
            {
                result = FromFolder(resourceName[0]);
                return true;
            }
            if (s_organization.TryParseName(accessApprovalServiceAccountName, out resourceName))
            {
                result = FromOrganization(resourceName[0]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(accessApprovalServiceAccountName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private AccessApprovalServiceAccountName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string folderId = null, string organizationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            FolderId = folderId;
            OrganizationId = organizationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="AccessApprovalServiceAccountName"/> class from the component parts
        /// of pattern <c>projects/{project}/serviceAccount</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        public AccessApprovalServiceAccountName(string projectId) : this(ResourceNameType.Project, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)))
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
                case ResourceNameType.Project: return s_project.Expand(ProjectId);
                case ResourceNameType.Folder: return s_folder.Expand(FolderId);
                case ResourceNameType.Organization: return s_organization.Expand(OrganizationId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as AccessApprovalServiceAccountName);

        /// <inheritdoc/>
        public bool Equals(AccessApprovalServiceAccountName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(AccessApprovalServiceAccountName a, AccessApprovalServiceAccountName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(AccessApprovalServiceAccountName a, AccessApprovalServiceAccountName b) => !(a == b);
    }

    public partial class ApprovalRequest
    {
        /// <summary>
        /// <see cref="gcav::ApprovalRequestName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::ApprovalRequestName ApprovalRequestName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::ApprovalRequestName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class AccessApprovalSettings
    {
        /// <summary>
        /// <see cref="gcav::AccessApprovalSettingsName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gcav::AccessApprovalSettingsName AccessApprovalSettingsName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::AccessApprovalSettingsName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class AccessApprovalServiceAccount
    {
        /// <summary>
        /// <see cref="gcav::AccessApprovalServiceAccountName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gcav::AccessApprovalServiceAccountName AccessApprovalServiceAccountName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::AccessApprovalServiceAccountName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListApprovalRequestsMessage
    {
        /// <summary>
        /// <see cref="gagr::ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::ProjectName ParentAsProjectName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::ProjectName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagr::FolderName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::FolderName ParentAsFolderName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::FolderName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagr::OrganizationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::OrganizationName ParentAsOrganizationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::OrganizationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gax::IResourceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gax::IResourceName ParentAsResourceName
        {
            get
            {
                if (string.IsNullOrEmpty(Parent))
                {
                    return null;
                }
                if (gagr::ProjectName.TryParse(Parent, out gagr::ProjectName project))
                {
                    return project;
                }
                if (gagr::FolderName.TryParse(Parent, out gagr::FolderName folder))
                {
                    return folder;
                }
                if (gagr::OrganizationName.TryParse(Parent, out gagr::OrganizationName organization))
                {
                    return organization;
                }
                return gax::UnparsedResourceName.Parse(Parent);
            }
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetApprovalRequestMessage
    {
        /// <summary>
        /// <see cref="gcav::ApprovalRequestName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::ApprovalRequestName ApprovalRequestName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::ApprovalRequestName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ApproveApprovalRequestMessage
    {
        /// <summary>
        /// <see cref="gcav::ApprovalRequestName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::ApprovalRequestName ApprovalRequestName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::ApprovalRequestName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DismissApprovalRequestMessage
    {
        /// <summary>
        /// <see cref="gcav::ApprovalRequestName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::ApprovalRequestName ApprovalRequestName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::ApprovalRequestName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class InvalidateApprovalRequestMessage
    {
        /// <summary>
        /// <see cref="gcav::ApprovalRequestName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::ApprovalRequestName ApprovalRequestName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::ApprovalRequestName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetAccessApprovalSettingsMessage
    {
        /// <summary>
        /// <see cref="gcav::AccessApprovalSettingsName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gcav::AccessApprovalSettingsName AccessApprovalSettingsName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::AccessApprovalSettingsName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteAccessApprovalSettingsMessage
    {
        /// <summary>
        /// <see cref="gcav::AccessApprovalSettingsName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gcav::AccessApprovalSettingsName AccessApprovalSettingsName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::AccessApprovalSettingsName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
