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
using gcav = Google.Cloud.AuditManager.V1;
using sys = System;

namespace Google.Cloud.AuditManager.V1
{
    /// <summary>Resource name for the <c>Enrollment</c> resource.</summary>
    public sealed partial class EnrollmentName : gax::IResourceName, sys::IEquatable<EnrollmentName>
    {
        /// <summary>The possible contents of <see cref="EnrollmentName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/enrollments/{enrollment}</c>.
            /// </summary>
            ProjectLocationEnrollment = 1,

            /// <summary>
            /// A resource name with pattern <c>folders/{folder}/locations/{location}/enrollments/{enrollment}</c>.
            /// </summary>
            FolderLocationEnrollment = 2,

            /// <summary>
            /// A resource name with pattern
            /// <c>organizations/{organization}/locations/{location}/enrollments/{enrollment}</c>.
            /// </summary>
            OrganizationLocationEnrollment = 3,
        }

        private static gax::PathTemplate s_projectLocationEnrollment = new gax::PathTemplate("projects/{project}/locations/{location}/enrollments/{enrollment}");

        private static gax::PathTemplate s_folderLocationEnrollment = new gax::PathTemplate("folders/{folder}/locations/{location}/enrollments/{enrollment}");

        private static gax::PathTemplate s_organizationLocationEnrollment = new gax::PathTemplate("organizations/{organization}/locations/{location}/enrollments/{enrollment}");

        /// <summary>Creates a <see cref="EnrollmentName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="EnrollmentName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static EnrollmentName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new EnrollmentName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="EnrollmentName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/enrollments/{enrollment}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="enrollmentId">The <c>Enrollment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="EnrollmentName"/> constructed from the provided ids.</returns>
        public static EnrollmentName FromProjectLocationEnrollment(string projectId, string locationId, string enrollmentId) =>
            new EnrollmentName(ResourceNameType.ProjectLocationEnrollment, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), enrollmentId: gax::GaxPreconditions.CheckNotNullOrEmpty(enrollmentId, nameof(enrollmentId)));

        /// <summary>
        /// Creates a <see cref="EnrollmentName"/> with the pattern
        /// <c>folders/{folder}/locations/{location}/enrollments/{enrollment}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="enrollmentId">The <c>Enrollment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="EnrollmentName"/> constructed from the provided ids.</returns>
        public static EnrollmentName FromFolderLocationEnrollment(string folderId, string locationId, string enrollmentId) =>
            new EnrollmentName(ResourceNameType.FolderLocationEnrollment, folderId: gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), enrollmentId: gax::GaxPreconditions.CheckNotNullOrEmpty(enrollmentId, nameof(enrollmentId)));

        /// <summary>
        /// Creates a <see cref="EnrollmentName"/> with the pattern
        /// <c>organizations/{organization}/locations/{location}/enrollments/{enrollment}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="enrollmentId">The <c>Enrollment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="EnrollmentName"/> constructed from the provided ids.</returns>
        public static EnrollmentName FromOrganizationLocationEnrollment(string organizationId, string locationId, string enrollmentId) =>
            new EnrollmentName(ResourceNameType.OrganizationLocationEnrollment, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), enrollmentId: gax::GaxPreconditions.CheckNotNullOrEmpty(enrollmentId, nameof(enrollmentId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="EnrollmentName"/> with pattern
        /// <c>projects/{project}/locations/{location}/enrollments/{enrollment}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="enrollmentId">The <c>Enrollment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="EnrollmentName"/> with pattern
        /// <c>projects/{project}/locations/{location}/enrollments/{enrollment}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string enrollmentId) =>
            FormatProjectLocationEnrollment(projectId, locationId, enrollmentId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="EnrollmentName"/> with pattern
        /// <c>projects/{project}/locations/{location}/enrollments/{enrollment}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="enrollmentId">The <c>Enrollment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="EnrollmentName"/> with pattern
        /// <c>projects/{project}/locations/{location}/enrollments/{enrollment}</c>.
        /// </returns>
        public static string FormatProjectLocationEnrollment(string projectId, string locationId, string enrollmentId) =>
            s_projectLocationEnrollment.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(enrollmentId, nameof(enrollmentId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="EnrollmentName"/> with pattern
        /// <c>folders/{folder}/locations/{location}/enrollments/{enrollment}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="enrollmentId">The <c>Enrollment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="EnrollmentName"/> with pattern
        /// <c>folders/{folder}/locations/{location}/enrollments/{enrollment}</c>.
        /// </returns>
        public static string FormatFolderLocationEnrollment(string folderId, string locationId, string enrollmentId) =>
            s_folderLocationEnrollment.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(enrollmentId, nameof(enrollmentId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="EnrollmentName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}/enrollments/{enrollment}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="enrollmentId">The <c>Enrollment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="EnrollmentName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}/enrollments/{enrollment}</c>.
        /// </returns>
        public static string FormatOrganizationLocationEnrollment(string organizationId, string locationId, string enrollmentId) =>
            s_organizationLocationEnrollment.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(enrollmentId, nameof(enrollmentId)));

        /// <summary>Parses the given resource name string into a new <see cref="EnrollmentName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/enrollments/{enrollment}</c></description>
        /// </item>
        /// <item>
        /// <description><c>folders/{folder}/locations/{location}/enrollments/{enrollment}</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/enrollments/{enrollment}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="enrollmentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="EnrollmentName"/> if successful.</returns>
        public static EnrollmentName Parse(string enrollmentName) => Parse(enrollmentName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="EnrollmentName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/enrollments/{enrollment}</c></description>
        /// </item>
        /// <item>
        /// <description><c>folders/{folder}/locations/{location}/enrollments/{enrollment}</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/enrollments/{enrollment}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="enrollmentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="EnrollmentName"/> if successful.</returns>
        public static EnrollmentName Parse(string enrollmentName, bool allowUnparsed) =>
            TryParse(enrollmentName, allowUnparsed, out EnrollmentName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="EnrollmentName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/enrollments/{enrollment}</c></description>
        /// </item>
        /// <item>
        /// <description><c>folders/{folder}/locations/{location}/enrollments/{enrollment}</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/enrollments/{enrollment}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="enrollmentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="EnrollmentName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string enrollmentName, out EnrollmentName result) =>
            TryParse(enrollmentName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="EnrollmentName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/enrollments/{enrollment}</c></description>
        /// </item>
        /// <item>
        /// <description><c>folders/{folder}/locations/{location}/enrollments/{enrollment}</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/enrollments/{enrollment}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="enrollmentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="EnrollmentName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string enrollmentName, bool allowUnparsed, out EnrollmentName result)
        {
            gax::GaxPreconditions.CheckNotNull(enrollmentName, nameof(enrollmentName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationEnrollment.TryParseName(enrollmentName, out resourceName))
            {
                result = FromProjectLocationEnrollment(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (s_folderLocationEnrollment.TryParseName(enrollmentName, out resourceName))
            {
                result = FromFolderLocationEnrollment(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (s_organizationLocationEnrollment.TryParseName(enrollmentName, out resourceName))
            {
                result = FromOrganizationLocationEnrollment(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(enrollmentName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private EnrollmentName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string enrollmentId = null, string folderId = null, string locationId = null, string organizationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            EnrollmentId = enrollmentId;
            FolderId = folderId;
            LocationId = locationId;
            OrganizationId = organizationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="EnrollmentName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/enrollments/{enrollment}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="enrollmentId">The <c>Enrollment</c> ID. Must not be <c>null</c> or empty.</param>
        public EnrollmentName(string projectId, string locationId, string enrollmentId) : this(ResourceNameType.ProjectLocationEnrollment, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), enrollmentId: gax::GaxPreconditions.CheckNotNullOrEmpty(enrollmentId, nameof(enrollmentId)))
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
        /// The <c>Enrollment</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string EnrollmentId { get; }

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

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationEnrollment: return s_projectLocationEnrollment.Expand(ProjectId, LocationId, EnrollmentId);
                case ResourceNameType.FolderLocationEnrollment: return s_folderLocationEnrollment.Expand(FolderId, LocationId, EnrollmentId);
                case ResourceNameType.OrganizationLocationEnrollment: return s_organizationLocationEnrollment.Expand(OrganizationId, LocationId, EnrollmentId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as EnrollmentName);

        /// <inheritdoc/>
        public bool Equals(EnrollmentName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(EnrollmentName a, EnrollmentName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(EnrollmentName a, EnrollmentName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>AuditScopeReport</c> resource.</summary>
    public sealed partial class AuditScopeReportName : gax::IResourceName, sys::IEquatable<AuditScopeReportName>
    {
        /// <summary>The possible contents of <see cref="AuditScopeReportName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/auditScopeReports/{audit_scope_report}</c>.
            /// </summary>
            ProjectLocationAuditScopeReport = 1,

            /// <summary>
            /// A resource name with pattern
            /// <c>folders/{folder}/locations/{location}/auditScopeReports/{audit_scope_report}</c>.
            /// </summary>
            FolderLocationAuditScopeReport = 2,
        }

        private static gax::PathTemplate s_projectLocationAuditScopeReport = new gax::PathTemplate("projects/{project}/locations/{location}/auditScopeReports/{audit_scope_report}");

        private static gax::PathTemplate s_folderLocationAuditScopeReport = new gax::PathTemplate("folders/{folder}/locations/{location}/auditScopeReports/{audit_scope_report}");

        /// <summary>Creates a <see cref="AuditScopeReportName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="AuditScopeReportName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static AuditScopeReportName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new AuditScopeReportName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="AuditScopeReportName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/auditScopeReports/{audit_scope_report}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="auditScopeReportId">The <c>AuditScopeReport</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="AuditScopeReportName"/> constructed from the provided ids.</returns>
        public static AuditScopeReportName FromProjectLocationAuditScopeReport(string projectId, string locationId, string auditScopeReportId) =>
            new AuditScopeReportName(ResourceNameType.ProjectLocationAuditScopeReport, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), auditScopeReportId: gax::GaxPreconditions.CheckNotNullOrEmpty(auditScopeReportId, nameof(auditScopeReportId)));

        /// <summary>
        /// Creates a <see cref="AuditScopeReportName"/> with the pattern
        /// <c>folders/{folder}/locations/{location}/auditScopeReports/{audit_scope_report}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="auditScopeReportId">The <c>AuditScopeReport</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="AuditScopeReportName"/> constructed from the provided ids.</returns>
        public static AuditScopeReportName FromFolderLocationAuditScopeReport(string folderId, string locationId, string auditScopeReportId) =>
            new AuditScopeReportName(ResourceNameType.FolderLocationAuditScopeReport, folderId: gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), auditScopeReportId: gax::GaxPreconditions.CheckNotNullOrEmpty(auditScopeReportId, nameof(auditScopeReportId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AuditScopeReportName"/> with pattern
        /// <c>projects/{project}/locations/{location}/auditScopeReports/{audit_scope_report}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="auditScopeReportId">The <c>AuditScopeReport</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AuditScopeReportName"/> with pattern
        /// <c>projects/{project}/locations/{location}/auditScopeReports/{audit_scope_report}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string auditScopeReportId) =>
            FormatProjectLocationAuditScopeReport(projectId, locationId, auditScopeReportId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AuditScopeReportName"/> with pattern
        /// <c>projects/{project}/locations/{location}/auditScopeReports/{audit_scope_report}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="auditScopeReportId">The <c>AuditScopeReport</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AuditScopeReportName"/> with pattern
        /// <c>projects/{project}/locations/{location}/auditScopeReports/{audit_scope_report}</c>.
        /// </returns>
        public static string FormatProjectLocationAuditScopeReport(string projectId, string locationId, string auditScopeReportId) =>
            s_projectLocationAuditScopeReport.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(auditScopeReportId, nameof(auditScopeReportId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AuditScopeReportName"/> with pattern
        /// <c>folders/{folder}/locations/{location}/auditScopeReports/{audit_scope_report}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="auditScopeReportId">The <c>AuditScopeReport</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AuditScopeReportName"/> with pattern
        /// <c>folders/{folder}/locations/{location}/auditScopeReports/{audit_scope_report}</c>.
        /// </returns>
        public static string FormatFolderLocationAuditScopeReport(string folderId, string locationId, string auditScopeReportId) =>
            s_folderLocationAuditScopeReport.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(auditScopeReportId, nameof(auditScopeReportId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AuditScopeReportName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/auditScopeReports/{audit_scope_report}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>folders/{folder}/locations/{location}/auditScopeReports/{audit_scope_report}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="auditScopeReportName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AuditScopeReportName"/> if successful.</returns>
        public static AuditScopeReportName Parse(string auditScopeReportName) => Parse(auditScopeReportName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AuditScopeReportName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/auditScopeReports/{audit_scope_report}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>folders/{folder}/locations/{location}/auditScopeReports/{audit_scope_report}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="auditScopeReportName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="AuditScopeReportName"/> if successful.</returns>
        public static AuditScopeReportName Parse(string auditScopeReportName, bool allowUnparsed) =>
            TryParse(auditScopeReportName, allowUnparsed, out AuditScopeReportName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AuditScopeReportName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/auditScopeReports/{audit_scope_report}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>folders/{folder}/locations/{location}/auditScopeReports/{audit_scope_report}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="auditScopeReportName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AuditScopeReportName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string auditScopeReportName, out AuditScopeReportName result) =>
            TryParse(auditScopeReportName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AuditScopeReportName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/auditScopeReports/{audit_scope_report}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>folders/{folder}/locations/{location}/auditScopeReports/{audit_scope_report}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="auditScopeReportName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AuditScopeReportName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string auditScopeReportName, bool allowUnparsed, out AuditScopeReportName result)
        {
            gax::GaxPreconditions.CheckNotNull(auditScopeReportName, nameof(auditScopeReportName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationAuditScopeReport.TryParseName(auditScopeReportName, out resourceName))
            {
                result = FromProjectLocationAuditScopeReport(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (s_folderLocationAuditScopeReport.TryParseName(auditScopeReportName, out resourceName))
            {
                result = FromFolderLocationAuditScopeReport(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(auditScopeReportName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private AuditScopeReportName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string auditScopeReportId = null, string folderId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AuditScopeReportId = auditScopeReportId;
            FolderId = folderId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="AuditScopeReportName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/auditScopeReports/{audit_scope_report}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="auditScopeReportId">The <c>AuditScopeReport</c> ID. Must not be <c>null</c> or empty.</param>
        public AuditScopeReportName(string projectId, string locationId, string auditScopeReportId) : this(ResourceNameType.ProjectLocationAuditScopeReport, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), auditScopeReportId: gax::GaxPreconditions.CheckNotNullOrEmpty(auditScopeReportId, nameof(auditScopeReportId)))
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
        /// The <c>AuditScopeReport</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string AuditScopeReportId { get; }

        /// <summary>
        /// The <c>Folder</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string FolderId { get; }

        /// <summary>
        /// The <c>Location</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string LocationId { get; }

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
                case ResourceNameType.ProjectLocationAuditScopeReport: return s_projectLocationAuditScopeReport.Expand(ProjectId, LocationId, AuditScopeReportId);
                case ResourceNameType.FolderLocationAuditScopeReport: return s_folderLocationAuditScopeReport.Expand(FolderId, LocationId, AuditScopeReportId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as AuditScopeReportName);

        /// <inheritdoc/>
        public bool Equals(AuditScopeReportName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(AuditScopeReportName a, AuditScopeReportName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(AuditScopeReportName a, AuditScopeReportName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>ResourceEnrollmentStatus</c> resource.</summary>
    public sealed partial class ResourceEnrollmentStatusName : gax::IResourceName, sys::IEquatable<ResourceEnrollmentStatusName>
    {
        /// <summary>The possible contents of <see cref="ResourceEnrollmentStatusName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>folders/{folder}/locations/{location}/resourceEnrollmentStatuses/{resource_enrollment_status}</c>.
            /// </summary>
            FolderLocationResourceEnrollmentStatus = 1,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/resourceEnrollmentStatuses/{resource_enrollment_status}</c>.
            /// </summary>
            ProjectLocationResourceEnrollmentStatus = 2,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// organizations/{organization}/locations/{location}/resourceEnrollmentStatuses/{resource_enrollment_status}</c>
            /// .
            /// </summary>
            OrganizationLocationResourceEnrollmentStatus = 3,
        }

        private static gax::PathTemplate s_folderLocationResourceEnrollmentStatus = new gax::PathTemplate("folders/{folder}/locations/{location}/resourceEnrollmentStatuses/{resource_enrollment_status}");

        private static gax::PathTemplate s_projectLocationResourceEnrollmentStatus = new gax::PathTemplate("projects/{project}/locations/{location}/resourceEnrollmentStatuses/{resource_enrollment_status}");

        private static gax::PathTemplate s_organizationLocationResourceEnrollmentStatus = new gax::PathTemplate("organizations/{organization}/locations/{location}/resourceEnrollmentStatuses/{resource_enrollment_status}");

        /// <summary>
        /// Creates a <see cref="ResourceEnrollmentStatusName"/> containing an unparsed resource name.
        /// </summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ResourceEnrollmentStatusName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ResourceEnrollmentStatusName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ResourceEnrollmentStatusName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ResourceEnrollmentStatusName"/> with the pattern
        /// <c>folders/{folder}/locations/{location}/resourceEnrollmentStatuses/{resource_enrollment_status}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="resourceEnrollmentStatusId">
        /// The <c>ResourceEnrollmentStatus</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="ResourceEnrollmentStatusName"/> constructed from the provided ids.
        /// </returns>
        public static ResourceEnrollmentStatusName FromFolderLocationResourceEnrollmentStatus(string folderId, string locationId, string resourceEnrollmentStatusId) =>
            new ResourceEnrollmentStatusName(ResourceNameType.FolderLocationResourceEnrollmentStatus, folderId: gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), resourceEnrollmentStatusId: gax::GaxPreconditions.CheckNotNullOrEmpty(resourceEnrollmentStatusId, nameof(resourceEnrollmentStatusId)));

        /// <summary>
        /// Creates a <see cref="ResourceEnrollmentStatusName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/resourceEnrollmentStatuses/{resource_enrollment_status}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="resourceEnrollmentStatusId">
        /// The <c>ResourceEnrollmentStatus</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="ResourceEnrollmentStatusName"/> constructed from the provided ids.
        /// </returns>
        public static ResourceEnrollmentStatusName FromProjectLocationResourceEnrollmentStatus(string projectId, string locationId, string resourceEnrollmentStatusId) =>
            new ResourceEnrollmentStatusName(ResourceNameType.ProjectLocationResourceEnrollmentStatus, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), resourceEnrollmentStatusId: gax::GaxPreconditions.CheckNotNullOrEmpty(resourceEnrollmentStatusId, nameof(resourceEnrollmentStatusId)));

        /// <summary>
        /// Creates a <see cref="ResourceEnrollmentStatusName"/> with the pattern
        /// <c>organizations/{organization}/locations/{location}/resourceEnrollmentStatuses/{resource_enrollment_status}</c>
        /// .
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="resourceEnrollmentStatusId">
        /// The <c>ResourceEnrollmentStatus</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="ResourceEnrollmentStatusName"/> constructed from the provided ids.
        /// </returns>
        public static ResourceEnrollmentStatusName FromOrganizationLocationResourceEnrollmentStatus(string organizationId, string locationId, string resourceEnrollmentStatusId) =>
            new ResourceEnrollmentStatusName(ResourceNameType.OrganizationLocationResourceEnrollmentStatus, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), resourceEnrollmentStatusId: gax::GaxPreconditions.CheckNotNullOrEmpty(resourceEnrollmentStatusId, nameof(resourceEnrollmentStatusId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ResourceEnrollmentStatusName"/> with
        /// pattern <c>folders/{folder}/locations/{location}/resourceEnrollmentStatuses/{resource_enrollment_status}</c>
        /// .
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="resourceEnrollmentStatusId">
        /// The <c>ResourceEnrollmentStatus</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="ResourceEnrollmentStatusName"/> with pattern
        /// <c>folders/{folder}/locations/{location}/resourceEnrollmentStatuses/{resource_enrollment_status}</c>.
        /// </returns>
        public static string Format(string folderId, string locationId, string resourceEnrollmentStatusId) =>
            FormatFolderLocationResourceEnrollmentStatus(folderId, locationId, resourceEnrollmentStatusId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ResourceEnrollmentStatusName"/> with
        /// pattern <c>folders/{folder}/locations/{location}/resourceEnrollmentStatuses/{resource_enrollment_status}</c>
        /// .
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="resourceEnrollmentStatusId">
        /// The <c>ResourceEnrollmentStatus</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="ResourceEnrollmentStatusName"/> with pattern
        /// <c>folders/{folder}/locations/{location}/resourceEnrollmentStatuses/{resource_enrollment_status}</c>.
        /// </returns>
        public static string FormatFolderLocationResourceEnrollmentStatus(string folderId, string locationId, string resourceEnrollmentStatusId) =>
            s_folderLocationResourceEnrollmentStatus.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(resourceEnrollmentStatusId, nameof(resourceEnrollmentStatusId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ResourceEnrollmentStatusName"/> with
        /// pattern <c>projects/{project}/locations/{location}/resourceEnrollmentStatuses/{resource_enrollment_status}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="resourceEnrollmentStatusId">
        /// The <c>ResourceEnrollmentStatus</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="ResourceEnrollmentStatusName"/> with pattern
        /// <c>projects/{project}/locations/{location}/resourceEnrollmentStatuses/{resource_enrollment_status}</c>.
        /// </returns>
        public static string FormatProjectLocationResourceEnrollmentStatus(string projectId, string locationId, string resourceEnrollmentStatusId) =>
            s_projectLocationResourceEnrollmentStatus.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(resourceEnrollmentStatusId, nameof(resourceEnrollmentStatusId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ResourceEnrollmentStatusName"/> with
        /// pattern
        /// <c>organizations/{organization}/locations/{location}/resourceEnrollmentStatuses/{resource_enrollment_status}</c>
        /// .
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="resourceEnrollmentStatusId">
        /// The <c>ResourceEnrollmentStatus</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="ResourceEnrollmentStatusName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}/resourceEnrollmentStatuses/{resource_enrollment_status}</c>
        /// .
        /// </returns>
        public static string FormatOrganizationLocationResourceEnrollmentStatus(string organizationId, string locationId, string resourceEnrollmentStatusId) =>
            s_organizationLocationResourceEnrollmentStatus.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(resourceEnrollmentStatusId, nameof(resourceEnrollmentStatusId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ResourceEnrollmentStatusName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>folders/{folder}/locations/{location}/resourceEnrollmentStatuses/{resource_enrollment_status}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/resourceEnrollmentStatuses/{resource_enrollment_status}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/resourceEnrollmentStatuses/{resource_enrollment_status}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="resourceEnrollmentStatusName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <returns>The parsed <see cref="ResourceEnrollmentStatusName"/> if successful.</returns>
        public static ResourceEnrollmentStatusName Parse(string resourceEnrollmentStatusName) =>
            Parse(resourceEnrollmentStatusName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ResourceEnrollmentStatusName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>folders/{folder}/locations/{location}/resourceEnrollmentStatuses/{resource_enrollment_status}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/resourceEnrollmentStatuses/{resource_enrollment_status}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/resourceEnrollmentStatuses/{resource_enrollment_status}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="resourceEnrollmentStatusName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ResourceEnrollmentStatusName"/> if successful.</returns>
        public static ResourceEnrollmentStatusName Parse(string resourceEnrollmentStatusName, bool allowUnparsed) =>
            TryParse(resourceEnrollmentStatusName, allowUnparsed, out ResourceEnrollmentStatusName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ResourceEnrollmentStatusName"/>
        /// instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>folders/{folder}/locations/{location}/resourceEnrollmentStatuses/{resource_enrollment_status}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/resourceEnrollmentStatuses/{resource_enrollment_status}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/resourceEnrollmentStatuses/{resource_enrollment_status}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="resourceEnrollmentStatusName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ResourceEnrollmentStatusName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string resourceEnrollmentStatusName, out ResourceEnrollmentStatusName result) =>
            TryParse(resourceEnrollmentStatusName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ResourceEnrollmentStatusName"/>
        /// instance; optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>folders/{folder}/locations/{location}/resourceEnrollmentStatuses/{resource_enrollment_status}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/resourceEnrollmentStatuses/{resource_enrollment_status}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/resourceEnrollmentStatuses/{resource_enrollment_status}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="resourceEnrollmentStatusName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ResourceEnrollmentStatusName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string resourceEnrollmentStatusName, bool allowUnparsed, out ResourceEnrollmentStatusName result)
        {
            gax::GaxPreconditions.CheckNotNull(resourceEnrollmentStatusName, nameof(resourceEnrollmentStatusName));
            gax::TemplatedResourceName resourceName;
            if (s_folderLocationResourceEnrollmentStatus.TryParseName(resourceEnrollmentStatusName, out resourceName))
            {
                result = FromFolderLocationResourceEnrollmentStatus(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (s_projectLocationResourceEnrollmentStatus.TryParseName(resourceEnrollmentStatusName, out resourceName))
            {
                result = FromProjectLocationResourceEnrollmentStatus(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (s_organizationLocationResourceEnrollmentStatus.TryParseName(resourceEnrollmentStatusName, out resourceName))
            {
                result = FromOrganizationLocationResourceEnrollmentStatus(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(resourceEnrollmentStatusName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ResourceEnrollmentStatusName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string folderId = null, string locationId = null, string organizationId = null, string projectId = null, string resourceEnrollmentStatusId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            FolderId = folderId;
            LocationId = locationId;
            OrganizationId = organizationId;
            ProjectId = projectId;
            ResourceEnrollmentStatusId = resourceEnrollmentStatusId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ResourceEnrollmentStatusName"/> class from the component parts of
        /// pattern <c>folders/{folder}/locations/{location}/resourceEnrollmentStatuses/{resource_enrollment_status}</c>
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="resourceEnrollmentStatusId">
        /// The <c>ResourceEnrollmentStatus</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public ResourceEnrollmentStatusName(string folderId, string locationId, string resourceEnrollmentStatusId) : this(ResourceNameType.FolderLocationResourceEnrollmentStatus, folderId: gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), resourceEnrollmentStatusId: gax::GaxPreconditions.CheckNotNullOrEmpty(resourceEnrollmentStatusId, nameof(resourceEnrollmentStatusId)))
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
        /// The <c>Organization</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string OrganizationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>ResourceEnrollmentStatus</c> ID. May be <c>null</c>, depending on which resource name is contained by
        /// this instance.
        /// </summary>
        public string ResourceEnrollmentStatusId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.FolderLocationResourceEnrollmentStatus: return s_folderLocationResourceEnrollmentStatus.Expand(FolderId, LocationId, ResourceEnrollmentStatusId);
                case ResourceNameType.ProjectLocationResourceEnrollmentStatus: return s_projectLocationResourceEnrollmentStatus.Expand(ProjectId, LocationId, ResourceEnrollmentStatusId);
                case ResourceNameType.OrganizationLocationResourceEnrollmentStatus: return s_organizationLocationResourceEnrollmentStatus.Expand(OrganizationId, LocationId, ResourceEnrollmentStatusId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ResourceEnrollmentStatusName);

        /// <inheritdoc/>
        public bool Equals(ResourceEnrollmentStatusName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ResourceEnrollmentStatusName a, ResourceEnrollmentStatusName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ResourceEnrollmentStatusName a, ResourceEnrollmentStatusName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>AuditReport</c> resource.</summary>
    public sealed partial class AuditReportName : gax::IResourceName, sys::IEquatable<AuditReportName>
    {
        /// <summary>The possible contents of <see cref="AuditReportName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/auditReports/{audit_report}</c>.
            /// </summary>
            ProjectLocationAuditReport = 1,

            /// <summary>
            /// A resource name with pattern <c>folders/{folder}/locations/{location}/auditReports/{audit_report}</c>.
            /// </summary>
            FolderLocationAuditReport = 2,
        }

        private static gax::PathTemplate s_projectLocationAuditReport = new gax::PathTemplate("projects/{project}/locations/{location}/auditReports/{audit_report}");

        private static gax::PathTemplate s_folderLocationAuditReport = new gax::PathTemplate("folders/{folder}/locations/{location}/auditReports/{audit_report}");

        /// <summary>Creates a <see cref="AuditReportName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="AuditReportName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static AuditReportName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new AuditReportName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="AuditReportName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/auditReports/{audit_report}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="auditReportId">The <c>AuditReport</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="AuditReportName"/> constructed from the provided ids.</returns>
        public static AuditReportName FromProjectLocationAuditReport(string projectId, string locationId, string auditReportId) =>
            new AuditReportName(ResourceNameType.ProjectLocationAuditReport, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), auditReportId: gax::GaxPreconditions.CheckNotNullOrEmpty(auditReportId, nameof(auditReportId)));

        /// <summary>
        /// Creates a <see cref="AuditReportName"/> with the pattern
        /// <c>folders/{folder}/locations/{location}/auditReports/{audit_report}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="auditReportId">The <c>AuditReport</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="AuditReportName"/> constructed from the provided ids.</returns>
        public static AuditReportName FromFolderLocationAuditReport(string folderId, string locationId, string auditReportId) =>
            new AuditReportName(ResourceNameType.FolderLocationAuditReport, folderId: gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), auditReportId: gax::GaxPreconditions.CheckNotNullOrEmpty(auditReportId, nameof(auditReportId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AuditReportName"/> with pattern
        /// <c>projects/{project}/locations/{location}/auditReports/{audit_report}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="auditReportId">The <c>AuditReport</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AuditReportName"/> with pattern
        /// <c>projects/{project}/locations/{location}/auditReports/{audit_report}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string auditReportId) =>
            FormatProjectLocationAuditReport(projectId, locationId, auditReportId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AuditReportName"/> with pattern
        /// <c>projects/{project}/locations/{location}/auditReports/{audit_report}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="auditReportId">The <c>AuditReport</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AuditReportName"/> with pattern
        /// <c>projects/{project}/locations/{location}/auditReports/{audit_report}</c>.
        /// </returns>
        public static string FormatProjectLocationAuditReport(string projectId, string locationId, string auditReportId) =>
            s_projectLocationAuditReport.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(auditReportId, nameof(auditReportId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AuditReportName"/> with pattern
        /// <c>folders/{folder}/locations/{location}/auditReports/{audit_report}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="auditReportId">The <c>AuditReport</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AuditReportName"/> with pattern
        /// <c>folders/{folder}/locations/{location}/auditReports/{audit_report}</c>.
        /// </returns>
        public static string FormatFolderLocationAuditReport(string folderId, string locationId, string auditReportId) =>
            s_folderLocationAuditReport.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(auditReportId, nameof(auditReportId)));

        /// <summary>Parses the given resource name string into a new <see cref="AuditReportName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/auditReports/{audit_report}</c></description>
        /// </item>
        /// <item>
        /// <description><c>folders/{folder}/locations/{location}/auditReports/{audit_report}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="auditReportName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AuditReportName"/> if successful.</returns>
        public static AuditReportName Parse(string auditReportName) => Parse(auditReportName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AuditReportName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/auditReports/{audit_report}</c></description>
        /// </item>
        /// <item>
        /// <description><c>folders/{folder}/locations/{location}/auditReports/{audit_report}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="auditReportName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="AuditReportName"/> if successful.</returns>
        public static AuditReportName Parse(string auditReportName, bool allowUnparsed) =>
            TryParse(auditReportName, allowUnparsed, out AuditReportName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AuditReportName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/auditReports/{audit_report}</c></description>
        /// </item>
        /// <item>
        /// <description><c>folders/{folder}/locations/{location}/auditReports/{audit_report}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="auditReportName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AuditReportName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string auditReportName, out AuditReportName result) =>
            TryParse(auditReportName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AuditReportName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/auditReports/{audit_report}</c></description>
        /// </item>
        /// <item>
        /// <description><c>folders/{folder}/locations/{location}/auditReports/{audit_report}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="auditReportName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AuditReportName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string auditReportName, bool allowUnparsed, out AuditReportName result)
        {
            gax::GaxPreconditions.CheckNotNull(auditReportName, nameof(auditReportName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationAuditReport.TryParseName(auditReportName, out resourceName))
            {
                result = FromProjectLocationAuditReport(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (s_folderLocationAuditReport.TryParseName(auditReportName, out resourceName))
            {
                result = FromFolderLocationAuditReport(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(auditReportName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private AuditReportName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string auditReportId = null, string folderId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AuditReportId = auditReportId;
            FolderId = folderId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="AuditReportName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/auditReports/{audit_report}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="auditReportId">The <c>AuditReport</c> ID. Must not be <c>null</c> or empty.</param>
        public AuditReportName(string projectId, string locationId, string auditReportId) : this(ResourceNameType.ProjectLocationAuditReport, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), auditReportId: gax::GaxPreconditions.CheckNotNullOrEmpty(auditReportId, nameof(auditReportId)))
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
        /// The <c>AuditReport</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string AuditReportId { get; }

        /// <summary>
        /// The <c>Folder</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string FolderId { get; }

        /// <summary>
        /// The <c>Location</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string LocationId { get; }

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
                case ResourceNameType.ProjectLocationAuditReport: return s_projectLocationAuditReport.Expand(ProjectId, LocationId, AuditReportId);
                case ResourceNameType.FolderLocationAuditReport: return s_folderLocationAuditReport.Expand(FolderId, LocationId, AuditReportId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as AuditReportName);

        /// <inheritdoc/>
        public bool Equals(AuditReportName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(AuditReportName a, AuditReportName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(AuditReportName a, AuditReportName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>FolderLocation</c> resource.</summary>
    public sealed partial class FolderLocationName : gax::IResourceName, sys::IEquatable<FolderLocationName>
    {
        /// <summary>The possible contents of <see cref="FolderLocationName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>folders/{folder}/locations/{location}</c>.</summary>
            FolderLocation = 1,
        }

        private static gax::PathTemplate s_folderLocation = new gax::PathTemplate("folders/{folder}/locations/{location}");

        /// <summary>Creates a <see cref="FolderLocationName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="FolderLocationName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static FolderLocationName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new FolderLocationName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="FolderLocationName"/> with the pattern <c>folders/{folder}/locations/{location}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="FolderLocationName"/> constructed from the provided ids.</returns>
        public static FolderLocationName FromFolderLocation(string folderId, string locationId) =>
            new FolderLocationName(ResourceNameType.FolderLocation, folderId: gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="FolderLocationName"/> with pattern
        /// <c>folders/{folder}/locations/{location}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="FolderLocationName"/> with pattern
        /// <c>folders/{folder}/locations/{location}</c>.
        /// </returns>
        public static string Format(string folderId, string locationId) => FormatFolderLocation(folderId, locationId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="FolderLocationName"/> with pattern
        /// <c>folders/{folder}/locations/{location}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="FolderLocationName"/> with pattern
        /// <c>folders/{folder}/locations/{location}</c>.
        /// </returns>
        public static string FormatFolderLocation(string folderId, string locationId) =>
            s_folderLocation.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="FolderLocationName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>folders/{folder}/locations/{location}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="folderLocationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="FolderLocationName"/> if successful.</returns>
        public static FolderLocationName Parse(string folderLocationName) => Parse(folderLocationName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="FolderLocationName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>folders/{folder}/locations/{location}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="folderLocationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="FolderLocationName"/> if successful.</returns>
        public static FolderLocationName Parse(string folderLocationName, bool allowUnparsed) =>
            TryParse(folderLocationName, allowUnparsed, out FolderLocationName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="FolderLocationName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>folders/{folder}/locations/{location}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="folderLocationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="FolderLocationName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string folderLocationName, out FolderLocationName result) =>
            TryParse(folderLocationName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="FolderLocationName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>folders/{folder}/locations/{location}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="folderLocationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="FolderLocationName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string folderLocationName, bool allowUnparsed, out FolderLocationName result)
        {
            gax::GaxPreconditions.CheckNotNull(folderLocationName, nameof(folderLocationName));
            gax::TemplatedResourceName resourceName;
            if (s_folderLocation.TryParseName(folderLocationName, out resourceName))
            {
                result = FromFolderLocation(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(folderLocationName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private FolderLocationName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string folderId = null, string locationId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            FolderId = folderId;
            LocationId = locationId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="FolderLocationName"/> class from the component parts of pattern
        /// <c>folders/{folder}/locations/{location}</c>
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        public FolderLocationName(string folderId, string locationId) : this(ResourceNameType.FolderLocation, folderId: gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)))
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
        /// The <c>Folder</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string FolderId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.FolderLocation: return s_folderLocation.Expand(FolderId, LocationId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as FolderLocationName);

        /// <inheritdoc/>
        public bool Equals(FolderLocationName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(FolderLocationName a, FolderLocationName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(FolderLocationName a, FolderLocationName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>OrganizationLocation</c> resource.</summary>
    public sealed partial class OrganizationLocationName : gax::IResourceName, sys::IEquatable<OrganizationLocationName>
    {
        /// <summary>The possible contents of <see cref="OrganizationLocationName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>organizations/{organization}/locations/{location}</c>.
            /// </summary>
            OrganizationLocation = 1,
        }

        private static gax::PathTemplate s_organizationLocation = new gax::PathTemplate("organizations/{organization}/locations/{location}");

        /// <summary>Creates a <see cref="OrganizationLocationName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="OrganizationLocationName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static OrganizationLocationName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new OrganizationLocationName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="OrganizationLocationName"/> with the pattern
        /// <c>organizations/{organization}/locations/{location}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// A new instance of <see cref="OrganizationLocationName"/> constructed from the provided ids.
        /// </returns>
        public static OrganizationLocationName FromOrganizationLocation(string organizationId, string locationId) =>
            new OrganizationLocationName(ResourceNameType.OrganizationLocation, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="OrganizationLocationName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="OrganizationLocationName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}</c>.
        /// </returns>
        public static string Format(string organizationId, string locationId) =>
            FormatOrganizationLocation(organizationId, locationId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="OrganizationLocationName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="OrganizationLocationName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}</c>.
        /// </returns>
        public static string FormatOrganizationLocation(string organizationId, string locationId) =>
            s_organizationLocation.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="OrganizationLocationName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>organizations/{organization}/locations/{location}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="organizationLocationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="OrganizationLocationName"/> if successful.</returns>
        public static OrganizationLocationName Parse(string organizationLocationName) =>
            Parse(organizationLocationName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="OrganizationLocationName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>organizations/{organization}/locations/{location}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="organizationLocationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="OrganizationLocationName"/> if successful.</returns>
        public static OrganizationLocationName Parse(string organizationLocationName, bool allowUnparsed) =>
            TryParse(organizationLocationName, allowUnparsed, out OrganizationLocationName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="OrganizationLocationName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>organizations/{organization}/locations/{location}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="organizationLocationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="OrganizationLocationName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string organizationLocationName, out OrganizationLocationName result) =>
            TryParse(organizationLocationName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="OrganizationLocationName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>organizations/{organization}/locations/{location}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="organizationLocationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="OrganizationLocationName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string organizationLocationName, bool allowUnparsed, out OrganizationLocationName result)
        {
            gax::GaxPreconditions.CheckNotNull(organizationLocationName, nameof(organizationLocationName));
            gax::TemplatedResourceName resourceName;
            if (s_organizationLocation.TryParseName(organizationLocationName, out resourceName))
            {
                result = FromOrganizationLocation(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(organizationLocationName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private OrganizationLocationName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string organizationId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            OrganizationId = organizationId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="OrganizationLocationName"/> class from the component parts of
        /// pattern <c>organizations/{organization}/locations/{location}</c>
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        public OrganizationLocationName(string organizationId, string locationId) : this(ResourceNameType.OrganizationLocation, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)))
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
        /// The <c>Organization</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string OrganizationId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.OrganizationLocation: return s_organizationLocation.Expand(OrganizationId, LocationId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as OrganizationLocationName);

        /// <inheritdoc/>
        public bool Equals(OrganizationLocationName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(OrganizationLocationName a, OrganizationLocationName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(OrganizationLocationName a, OrganizationLocationName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Standard</c> resource.</summary>
    public sealed partial class StandardName : gax::IResourceName, sys::IEquatable<StandardName>
    {
        /// <summary>The possible contents of <see cref="StandardName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/standards/{standard}</c>.
            /// </summary>
            ProjectLocationStandard = 1,

            /// <summary>
            /// A resource name with pattern <c>folders/{folder}/locations/{location}/standards/{standard}</c>.
            /// </summary>
            FolderLocationStandard = 2,

            /// <summary>
            /// A resource name with pattern <c>organizations/{organization}/locations/{location}/standards/{standard}</c>
            /// .
            /// </summary>
            OrganizationLocationStandard = 3,
        }

        private static gax::PathTemplate s_projectLocationStandard = new gax::PathTemplate("projects/{project}/locations/{location}/standards/{standard}");

        private static gax::PathTemplate s_folderLocationStandard = new gax::PathTemplate("folders/{folder}/locations/{location}/standards/{standard}");

        private static gax::PathTemplate s_organizationLocationStandard = new gax::PathTemplate("organizations/{organization}/locations/{location}/standards/{standard}");

        /// <summary>Creates a <see cref="StandardName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="StandardName"/> containing the provided <paramref name="unparsedResourceName"/>
        /// .
        /// </returns>
        public static StandardName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new StandardName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="StandardName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/standards/{standard}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="standardId">The <c>Standard</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="StandardName"/> constructed from the provided ids.</returns>
        public static StandardName FromProjectLocationStandard(string projectId, string locationId, string standardId) =>
            new StandardName(ResourceNameType.ProjectLocationStandard, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), standardId: gax::GaxPreconditions.CheckNotNullOrEmpty(standardId, nameof(standardId)));

        /// <summary>
        /// Creates a <see cref="StandardName"/> with the pattern
        /// <c>folders/{folder}/locations/{location}/standards/{standard}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="standardId">The <c>Standard</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="StandardName"/> constructed from the provided ids.</returns>
        public static StandardName FromFolderLocationStandard(string folderId, string locationId, string standardId) =>
            new StandardName(ResourceNameType.FolderLocationStandard, folderId: gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), standardId: gax::GaxPreconditions.CheckNotNullOrEmpty(standardId, nameof(standardId)));

        /// <summary>
        /// Creates a <see cref="StandardName"/> with the pattern
        /// <c>organizations/{organization}/locations/{location}/standards/{standard}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="standardId">The <c>Standard</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="StandardName"/> constructed from the provided ids.</returns>
        public static StandardName FromOrganizationLocationStandard(string organizationId, string locationId, string standardId) =>
            new StandardName(ResourceNameType.OrganizationLocationStandard, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), standardId: gax::GaxPreconditions.CheckNotNullOrEmpty(standardId, nameof(standardId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="StandardName"/> with pattern
        /// <c>projects/{project}/locations/{location}/standards/{standard}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="standardId">The <c>Standard</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="StandardName"/> with pattern
        /// <c>projects/{project}/locations/{location}/standards/{standard}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string standardId) =>
            FormatProjectLocationStandard(projectId, locationId, standardId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="StandardName"/> with pattern
        /// <c>projects/{project}/locations/{location}/standards/{standard}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="standardId">The <c>Standard</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="StandardName"/> with pattern
        /// <c>projects/{project}/locations/{location}/standards/{standard}</c>.
        /// </returns>
        public static string FormatProjectLocationStandard(string projectId, string locationId, string standardId) =>
            s_projectLocationStandard.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(standardId, nameof(standardId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="StandardName"/> with pattern
        /// <c>folders/{folder}/locations/{location}/standards/{standard}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="standardId">The <c>Standard</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="StandardName"/> with pattern
        /// <c>folders/{folder}/locations/{location}/standards/{standard}</c>.
        /// </returns>
        public static string FormatFolderLocationStandard(string folderId, string locationId, string standardId) =>
            s_folderLocationStandard.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(standardId, nameof(standardId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="StandardName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}/standards/{standard}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="standardId">The <c>Standard</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="StandardName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}/standards/{standard}</c>.
        /// </returns>
        public static string FormatOrganizationLocationStandard(string organizationId, string locationId, string standardId) =>
            s_organizationLocationStandard.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(standardId, nameof(standardId)));

        /// <summary>Parses the given resource name string into a new <see cref="StandardName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/standards/{standard}</c></description></item>
        /// <item><description><c>folders/{folder}/locations/{location}/standards/{standard}</c></description></item>
        /// <item>
        /// <description><c>organizations/{organization}/locations/{location}/standards/{standard}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="standardName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="StandardName"/> if successful.</returns>
        public static StandardName Parse(string standardName) => Parse(standardName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="StandardName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/standards/{standard}</c></description></item>
        /// <item><description><c>folders/{folder}/locations/{location}/standards/{standard}</c></description></item>
        /// <item>
        /// <description><c>organizations/{organization}/locations/{location}/standards/{standard}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="standardName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="StandardName"/> if successful.</returns>
        public static StandardName Parse(string standardName, bool allowUnparsed) =>
            TryParse(standardName, allowUnparsed, out StandardName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="StandardName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/standards/{standard}</c></description></item>
        /// <item><description><c>folders/{folder}/locations/{location}/standards/{standard}</c></description></item>
        /// <item>
        /// <description><c>organizations/{organization}/locations/{location}/standards/{standard}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="standardName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="StandardName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string standardName, out StandardName result) => TryParse(standardName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="StandardName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/standards/{standard}</c></description></item>
        /// <item><description><c>folders/{folder}/locations/{location}/standards/{standard}</c></description></item>
        /// <item>
        /// <description><c>organizations/{organization}/locations/{location}/standards/{standard}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="standardName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="StandardName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string standardName, bool allowUnparsed, out StandardName result)
        {
            gax::GaxPreconditions.CheckNotNull(standardName, nameof(standardName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationStandard.TryParseName(standardName, out resourceName))
            {
                result = FromProjectLocationStandard(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (s_folderLocationStandard.TryParseName(standardName, out resourceName))
            {
                result = FromFolderLocationStandard(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (s_organizationLocationStandard.TryParseName(standardName, out resourceName))
            {
                result = FromOrganizationLocationStandard(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(standardName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private StandardName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string folderId = null, string locationId = null, string organizationId = null, string projectId = null, string standardId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            FolderId = folderId;
            LocationId = locationId;
            OrganizationId = organizationId;
            ProjectId = projectId;
            StandardId = standardId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="StandardName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/standards/{standard}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="standardId">The <c>Standard</c> ID. Must not be <c>null</c> or empty.</param>
        public StandardName(string projectId, string locationId, string standardId) : this(ResourceNameType.ProjectLocationStandard, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), standardId: gax::GaxPreconditions.CheckNotNullOrEmpty(standardId, nameof(standardId)))
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
        /// The <c>Organization</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string OrganizationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Standard</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string StandardId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationStandard: return s_projectLocationStandard.Expand(ProjectId, LocationId, StandardId);
                case ResourceNameType.FolderLocationStandard: return s_folderLocationStandard.Expand(FolderId, LocationId, StandardId);
                case ResourceNameType.OrganizationLocationStandard: return s_organizationLocationStandard.Expand(OrganizationId, LocationId, StandardId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as StandardName);

        /// <inheritdoc/>
        public bool Equals(StandardName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(StandardName a, StandardName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(StandardName a, StandardName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>EnrollmentStatusScope</c> resource.</summary>
    public sealed partial class EnrollmentStatusScopeName : gax::IResourceName, sys::IEquatable<EnrollmentStatusScopeName>
    {
        /// <summary>The possible contents of <see cref="EnrollmentStatusScopeName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>folders/{folder}/locations/{location}</c>.</summary>
            FolderLocation = 1,

            /// <summary>
            /// A resource name with pattern <c>organizations/{organization}/locations/{location}</c>.
            /// </summary>
            OrganizationLocation = 2,
        }

        private static gax::PathTemplate s_folderLocation = new gax::PathTemplate("folders/{folder}/locations/{location}");

        private static gax::PathTemplate s_organizationLocation = new gax::PathTemplate("organizations/{organization}/locations/{location}");

        /// <summary>Creates a <see cref="EnrollmentStatusScopeName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="EnrollmentStatusScopeName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static EnrollmentStatusScopeName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new EnrollmentStatusScopeName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="EnrollmentStatusScopeName"/> with the pattern <c>folders/{folder}/locations/{location}</c>
        /// .
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// A new instance of <see cref="EnrollmentStatusScopeName"/> constructed from the provided ids.
        /// </returns>
        public static EnrollmentStatusScopeName FromFolderLocation(string folderId, string locationId) =>
            new EnrollmentStatusScopeName(ResourceNameType.FolderLocation, folderId: gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)));

        /// <summary>
        /// Creates a <see cref="EnrollmentStatusScopeName"/> with the pattern
        /// <c>organizations/{organization}/locations/{location}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// A new instance of <see cref="EnrollmentStatusScopeName"/> constructed from the provided ids.
        /// </returns>
        public static EnrollmentStatusScopeName FromOrganizationLocation(string organizationId, string locationId) =>
            new EnrollmentStatusScopeName(ResourceNameType.OrganizationLocation, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="EnrollmentStatusScopeName"/> with pattern
        /// <c>folders/{folder}/locations/{location}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="EnrollmentStatusScopeName"/> with pattern
        /// <c>folders/{folder}/locations/{location}</c>.
        /// </returns>
        public static string Format(string folderId, string locationId) => FormatFolderLocation(folderId, locationId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="EnrollmentStatusScopeName"/> with pattern
        /// <c>folders/{folder}/locations/{location}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="EnrollmentStatusScopeName"/> with pattern
        /// <c>folders/{folder}/locations/{location}</c>.
        /// </returns>
        public static string FormatFolderLocation(string folderId, string locationId) =>
            s_folderLocation.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="EnrollmentStatusScopeName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="EnrollmentStatusScopeName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}</c>.
        /// </returns>
        public static string FormatOrganizationLocation(string organizationId, string locationId) =>
            s_organizationLocation.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="EnrollmentStatusScopeName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>folders/{folder}/locations/{location}</c></description></item>
        /// <item><description><c>organizations/{organization}/locations/{location}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="enrollmentStatusScopeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="EnrollmentStatusScopeName"/> if successful.</returns>
        public static EnrollmentStatusScopeName Parse(string enrollmentStatusScopeName) =>
            Parse(enrollmentStatusScopeName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="EnrollmentStatusScopeName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>folders/{folder}/locations/{location}</c></description></item>
        /// <item><description><c>organizations/{organization}/locations/{location}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="enrollmentStatusScopeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="EnrollmentStatusScopeName"/> if successful.</returns>
        public static EnrollmentStatusScopeName Parse(string enrollmentStatusScopeName, bool allowUnparsed) =>
            TryParse(enrollmentStatusScopeName, allowUnparsed, out EnrollmentStatusScopeName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="EnrollmentStatusScopeName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>folders/{folder}/locations/{location}</c></description></item>
        /// <item><description><c>organizations/{organization}/locations/{location}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="enrollmentStatusScopeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="EnrollmentStatusScopeName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string enrollmentStatusScopeName, out EnrollmentStatusScopeName result) =>
            TryParse(enrollmentStatusScopeName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="EnrollmentStatusScopeName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>folders/{folder}/locations/{location}</c></description></item>
        /// <item><description><c>organizations/{organization}/locations/{location}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="enrollmentStatusScopeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="EnrollmentStatusScopeName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string enrollmentStatusScopeName, bool allowUnparsed, out EnrollmentStatusScopeName result)
        {
            gax::GaxPreconditions.CheckNotNull(enrollmentStatusScopeName, nameof(enrollmentStatusScopeName));
            gax::TemplatedResourceName resourceName;
            if (s_folderLocation.TryParseName(enrollmentStatusScopeName, out resourceName))
            {
                result = FromFolderLocation(resourceName[0], resourceName[1]);
                return true;
            }
            if (s_organizationLocation.TryParseName(enrollmentStatusScopeName, out resourceName))
            {
                result = FromOrganizationLocation(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(enrollmentStatusScopeName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private EnrollmentStatusScopeName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string folderId = null, string locationId = null, string organizationId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            FolderId = folderId;
            LocationId = locationId;
            OrganizationId = organizationId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="EnrollmentStatusScopeName"/> class from the component parts of
        /// pattern <c>folders/{folder}/locations/{location}</c>
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        public EnrollmentStatusScopeName(string folderId, string locationId) : this(ResourceNameType.FolderLocation, folderId: gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)))
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
        /// The <c>Organization</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string OrganizationId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.FolderLocation: return s_folderLocation.Expand(FolderId, LocationId);
                case ResourceNameType.OrganizationLocation: return s_organizationLocation.Expand(OrganizationId, LocationId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as EnrollmentStatusScopeName);

        /// <inheritdoc/>
        public bool Equals(EnrollmentStatusScopeName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(EnrollmentStatusScopeName a, EnrollmentStatusScopeName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(EnrollmentStatusScopeName a, EnrollmentStatusScopeName b) => !(a == b);
    }

    public partial class GetResourceEnrollmentStatusRequest
    {
        /// <summary>
        /// <see cref="gcav::ResourceEnrollmentStatusName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gcav::ResourceEnrollmentStatusName ResourceEnrollmentStatusName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::ResourceEnrollmentStatusName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListResourceEnrollmentStatusesRequest
    {
        /// <summary>
        /// <see cref="EnrollmentStatusScopeName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public EnrollmentStatusScopeName ParentAsEnrollmentStatusScopeName
        {
            get => string.IsNullOrEmpty(Parent) ? null : EnrollmentStatusScopeName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class ListAuditReportsRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="FolderLocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public FolderLocationName ParentAsFolderLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : FolderLocationName.Parse(Parent, allowUnparsed: true);
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
                if (gagr::LocationName.TryParse(Parent, out gagr::LocationName location))
                {
                    return location;
                }
                if (FolderLocationName.TryParse(Parent, out FolderLocationName folderLocation))
                {
                    return folderLocation;
                }
                return gax::UnparsedResourceName.Parse(Parent);
            }
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetAuditReportRequest
    {
        /// <summary>
        /// <see cref="gcav::AuditReportName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::AuditReportName AuditReportName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::AuditReportName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListControlsRequest
    {
        /// <summary>
        /// <see cref="StandardName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public StandardName ParentAsStandardName
        {
            get => string.IsNullOrEmpty(Parent) ? null : StandardName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class ReportGenerationProgress
    {
        /// <summary>
        /// <see cref="AuditReportName"/>-typed view over the <see cref="AuditReport"/> resource name property.
        /// </summary>
        public AuditReportName AuditReportAsAuditReportName
        {
            get => string.IsNullOrEmpty(AuditReport) ? null : AuditReportName.Parse(AuditReport, allowUnparsed: true);
            set => AuditReport = value?.ToString() ?? "";
        }
    }

    public partial class Enrollment
    {
        /// <summary>
        /// <see cref="gcav::EnrollmentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::EnrollmentName EnrollmentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::EnrollmentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class AuditScopeReport
    {
        /// <summary>
        /// <see cref="gcav::AuditScopeReportName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::AuditScopeReportName AuditScopeReportName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::AuditScopeReportName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ResourceEnrollmentStatus
    {
        /// <summary>
        /// <see cref="gcav::ResourceEnrollmentStatusName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gcav::ResourceEnrollmentStatusName ResourceEnrollmentStatusName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::ResourceEnrollmentStatusName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class AuditReport
    {
        /// <summary>
        /// <see cref="gcav::AuditReportName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::AuditReportName AuditReportName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::AuditReportName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
