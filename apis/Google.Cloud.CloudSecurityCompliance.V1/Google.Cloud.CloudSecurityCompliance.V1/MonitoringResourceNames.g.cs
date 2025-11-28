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
using gccv = Google.Cloud.CloudSecurityCompliance.V1;
using sys = System;

namespace Google.Cloud.CloudSecurityCompliance.V1
{
    /// <summary>Resource name for the <c>FrameworkComplianceReport</c> resource.</summary>
    public sealed partial class FrameworkComplianceReportName : gax::IResourceName, sys::IEquatable<FrameworkComplianceReportName>
    {
        /// <summary>The possible contents of <see cref="FrameworkComplianceReportName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/frameworkComplianceReports/{framework_compliance_report}</c>.
            /// </summary>
            ProjectLocationFrameworkComplianceReport = 1,

            /// <summary>
            /// A resource name with pattern
            /// <c>folders/{folder}/locations/{location}/frameworkComplianceReports/{framework_compliance_report}</c>.
            /// </summary>
            FolderLocationFrameworkComplianceReport = 2,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// organizations/{organization}/locations/{location}/frameworkComplianceReports/{framework_compliance_report}</c>
            /// .
            /// </summary>
            OrganizationLocationFrameworkComplianceReport = 3,
        }

        private static gax::PathTemplate s_projectLocationFrameworkComplianceReport = new gax::PathTemplate("projects/{project}/locations/{location}/frameworkComplianceReports/{framework_compliance_report}");

        private static gax::PathTemplate s_folderLocationFrameworkComplianceReport = new gax::PathTemplate("folders/{folder}/locations/{location}/frameworkComplianceReports/{framework_compliance_report}");

        private static gax::PathTemplate s_organizationLocationFrameworkComplianceReport = new gax::PathTemplate("organizations/{organization}/locations/{location}/frameworkComplianceReports/{framework_compliance_report}");

        /// <summary>
        /// Creates a <see cref="FrameworkComplianceReportName"/> containing an unparsed resource name.
        /// </summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="FrameworkComplianceReportName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static FrameworkComplianceReportName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new FrameworkComplianceReportName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="FrameworkComplianceReportName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/frameworkComplianceReports/{framework_compliance_report}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="frameworkComplianceReportId">
        /// The <c>FrameworkComplianceReport</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="FrameworkComplianceReportName"/> constructed from the provided ids.
        /// </returns>
        public static FrameworkComplianceReportName FromProjectLocationFrameworkComplianceReport(string projectId, string locationId, string frameworkComplianceReportId) =>
            new FrameworkComplianceReportName(ResourceNameType.ProjectLocationFrameworkComplianceReport, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), frameworkComplianceReportId: gax::GaxPreconditions.CheckNotNullOrEmpty(frameworkComplianceReportId, nameof(frameworkComplianceReportId)));

        /// <summary>
        /// Creates a <see cref="FrameworkComplianceReportName"/> with the pattern
        /// <c>folders/{folder}/locations/{location}/frameworkComplianceReports/{framework_compliance_report}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="frameworkComplianceReportId">
        /// The <c>FrameworkComplianceReport</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="FrameworkComplianceReportName"/> constructed from the provided ids.
        /// </returns>
        public static FrameworkComplianceReportName FromFolderLocationFrameworkComplianceReport(string folderId, string locationId, string frameworkComplianceReportId) =>
            new FrameworkComplianceReportName(ResourceNameType.FolderLocationFrameworkComplianceReport, folderId: gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), frameworkComplianceReportId: gax::GaxPreconditions.CheckNotNullOrEmpty(frameworkComplianceReportId, nameof(frameworkComplianceReportId)));

        /// <summary>
        /// Creates a <see cref="FrameworkComplianceReportName"/> with the pattern
        /// <c>
        /// organizations/{organization}/locations/{location}/frameworkComplianceReports/{framework_compliance_report}</c>
        /// .
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="frameworkComplianceReportId">
        /// The <c>FrameworkComplianceReport</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="FrameworkComplianceReportName"/> constructed from the provided ids.
        /// </returns>
        public static FrameworkComplianceReportName FromOrganizationLocationFrameworkComplianceReport(string organizationId, string locationId, string frameworkComplianceReportId) =>
            new FrameworkComplianceReportName(ResourceNameType.OrganizationLocationFrameworkComplianceReport, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), frameworkComplianceReportId: gax::GaxPreconditions.CheckNotNullOrEmpty(frameworkComplianceReportId, nameof(frameworkComplianceReportId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="FrameworkComplianceReportName"/> with
        /// pattern <c>projects/{project}/locations/{location}/frameworkComplianceReports/{framework_compliance_report}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="frameworkComplianceReportId">
        /// The <c>FrameworkComplianceReport</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="FrameworkComplianceReportName"/> with pattern
        /// <c>projects/{project}/locations/{location}/frameworkComplianceReports/{framework_compliance_report}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string frameworkComplianceReportId) =>
            FormatProjectLocationFrameworkComplianceReport(projectId, locationId, frameworkComplianceReportId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="FrameworkComplianceReportName"/> with
        /// pattern <c>projects/{project}/locations/{location}/frameworkComplianceReports/{framework_compliance_report}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="frameworkComplianceReportId">
        /// The <c>FrameworkComplianceReport</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="FrameworkComplianceReportName"/> with pattern
        /// <c>projects/{project}/locations/{location}/frameworkComplianceReports/{framework_compliance_report}</c>.
        /// </returns>
        public static string FormatProjectLocationFrameworkComplianceReport(string projectId, string locationId, string frameworkComplianceReportId) =>
            s_projectLocationFrameworkComplianceReport.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(frameworkComplianceReportId, nameof(frameworkComplianceReportId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="FrameworkComplianceReportName"/> with
        /// pattern <c>folders/{folder}/locations/{location}/frameworkComplianceReports/{framework_compliance_report}</c>
        /// .
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="frameworkComplianceReportId">
        /// The <c>FrameworkComplianceReport</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="FrameworkComplianceReportName"/> with pattern
        /// <c>folders/{folder}/locations/{location}/frameworkComplianceReports/{framework_compliance_report}</c>.
        /// </returns>
        public static string FormatFolderLocationFrameworkComplianceReport(string folderId, string locationId, string frameworkComplianceReportId) =>
            s_folderLocationFrameworkComplianceReport.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(frameworkComplianceReportId, nameof(frameworkComplianceReportId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="FrameworkComplianceReportName"/> with
        /// pattern
        /// <c>
        /// organizations/{organization}/locations/{location}/frameworkComplianceReports/{framework_compliance_report}</c>
        /// .
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="frameworkComplianceReportId">
        /// The <c>FrameworkComplianceReport</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="FrameworkComplianceReportName"/> with pattern
        /// <c>
        /// organizations/{organization}/locations/{location}/frameworkComplianceReports/{framework_compliance_report}</c>
        /// .
        /// </returns>
        public static string FormatOrganizationLocationFrameworkComplianceReport(string organizationId, string locationId, string frameworkComplianceReportId) =>
            s_organizationLocationFrameworkComplianceReport.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(frameworkComplianceReportId, nameof(frameworkComplianceReportId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="FrameworkComplianceReportName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/frameworkComplianceReports/{framework_compliance_report}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>folders/{folder}/locations/{location}/frameworkComplianceReports/{framework_compliance_report}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// organizations/{organization}/locations/{location}/frameworkComplianceReports/{framework_compliance_report}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="frameworkComplianceReportName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <returns>The parsed <see cref="FrameworkComplianceReportName"/> if successful.</returns>
        public static FrameworkComplianceReportName Parse(string frameworkComplianceReportName) =>
            Parse(frameworkComplianceReportName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="FrameworkComplianceReportName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/frameworkComplianceReports/{framework_compliance_report}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>folders/{folder}/locations/{location}/frameworkComplianceReports/{framework_compliance_report}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// organizations/{organization}/locations/{location}/frameworkComplianceReports/{framework_compliance_report}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="frameworkComplianceReportName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="FrameworkComplianceReportName"/> if successful.</returns>
        public static FrameworkComplianceReportName Parse(string frameworkComplianceReportName, bool allowUnparsed) =>
            TryParse(frameworkComplianceReportName, allowUnparsed, out FrameworkComplianceReportName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="FrameworkComplianceReportName"/>
        /// instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/frameworkComplianceReports/{framework_compliance_report}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>folders/{folder}/locations/{location}/frameworkComplianceReports/{framework_compliance_report}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// organizations/{organization}/locations/{location}/frameworkComplianceReports/{framework_compliance_report}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="frameworkComplianceReportName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="FrameworkComplianceReportName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string frameworkComplianceReportName, out FrameworkComplianceReportName result) =>
            TryParse(frameworkComplianceReportName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="FrameworkComplianceReportName"/>
        /// instance; optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/frameworkComplianceReports/{framework_compliance_report}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>folders/{folder}/locations/{location}/frameworkComplianceReports/{framework_compliance_report}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// organizations/{organization}/locations/{location}/frameworkComplianceReports/{framework_compliance_report}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="frameworkComplianceReportName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="FrameworkComplianceReportName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string frameworkComplianceReportName, bool allowUnparsed, out FrameworkComplianceReportName result)
        {
            gax::GaxPreconditions.CheckNotNull(frameworkComplianceReportName, nameof(frameworkComplianceReportName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationFrameworkComplianceReport.TryParseName(frameworkComplianceReportName, out resourceName))
            {
                result = FromProjectLocationFrameworkComplianceReport(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (s_folderLocationFrameworkComplianceReport.TryParseName(frameworkComplianceReportName, out resourceName))
            {
                result = FromFolderLocationFrameworkComplianceReport(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (s_organizationLocationFrameworkComplianceReport.TryParseName(frameworkComplianceReportName, out resourceName))
            {
                result = FromOrganizationLocationFrameworkComplianceReport(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(frameworkComplianceReportName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private FrameworkComplianceReportName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string folderId = null, string frameworkComplianceReportId = null, string locationId = null, string organizationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            FolderId = folderId;
            FrameworkComplianceReportId = frameworkComplianceReportId;
            LocationId = locationId;
            OrganizationId = organizationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="FrameworkComplianceReportName"/> class from the component parts of
        /// pattern <c>projects/{project}/locations/{location}/frameworkComplianceReports/{framework_compliance_report}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="frameworkComplianceReportId">
        /// The <c>FrameworkComplianceReport</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public FrameworkComplianceReportName(string projectId, string locationId, string frameworkComplianceReportId) : this(ResourceNameType.ProjectLocationFrameworkComplianceReport, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), frameworkComplianceReportId: gax::GaxPreconditions.CheckNotNullOrEmpty(frameworkComplianceReportId, nameof(frameworkComplianceReportId)))
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
        /// The <c>FrameworkComplianceReport</c> ID. May be <c>null</c>, depending on which resource name is contained
        /// by this instance.
        /// </summary>
        public string FrameworkComplianceReportId { get; }

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
                case ResourceNameType.ProjectLocationFrameworkComplianceReport: return s_projectLocationFrameworkComplianceReport.Expand(ProjectId, LocationId, FrameworkComplianceReportId);
                case ResourceNameType.FolderLocationFrameworkComplianceReport: return s_folderLocationFrameworkComplianceReport.Expand(FolderId, LocationId, FrameworkComplianceReportId);
                case ResourceNameType.OrganizationLocationFrameworkComplianceReport: return s_organizationLocationFrameworkComplianceReport.Expand(OrganizationId, LocationId, FrameworkComplianceReportId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as FrameworkComplianceReportName);

        /// <inheritdoc/>
        public bool Equals(FrameworkComplianceReportName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(FrameworkComplianceReportName a, FrameworkComplianceReportName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(FrameworkComplianceReportName a, FrameworkComplianceReportName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>FrameworkComplianceSummary</c> resource.</summary>
    public sealed partial class FrameworkComplianceSummaryName : gax::IResourceName, sys::IEquatable<FrameworkComplianceSummaryName>
    {
        /// <summary>The possible contents of <see cref="FrameworkComplianceSummaryName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/frameworkComplianceSummaries/{framework_compliance_summary}</c>
            /// .
            /// </summary>
            ProjectLocationFrameworkComplianceSummary = 1,

            /// <summary>
            /// A resource name with pattern
            /// <c>folders/{folder}/locations/{location}/frameworkComplianceSummaries/{framework_compliance_summary}</c>
            /// .
            /// </summary>
            FolderLocationFrameworkComplianceSummary = 2,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// organizations/{organization}/locations/{location}/frameworkComplianceSummaries/{framework_compliance_summary}</c>
            /// .
            /// </summary>
            OrganizationLocationFrameworkComplianceSummary = 3,
        }

        private static gax::PathTemplate s_projectLocationFrameworkComplianceSummary = new gax::PathTemplate("projects/{project}/locations/{location}/frameworkComplianceSummaries/{framework_compliance_summary}");

        private static gax::PathTemplate s_folderLocationFrameworkComplianceSummary = new gax::PathTemplate("folders/{folder}/locations/{location}/frameworkComplianceSummaries/{framework_compliance_summary}");

        private static gax::PathTemplate s_organizationLocationFrameworkComplianceSummary = new gax::PathTemplate("organizations/{organization}/locations/{location}/frameworkComplianceSummaries/{framework_compliance_summary}");

        /// <summary>
        /// Creates a <see cref="FrameworkComplianceSummaryName"/> containing an unparsed resource name.
        /// </summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="FrameworkComplianceSummaryName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static FrameworkComplianceSummaryName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new FrameworkComplianceSummaryName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="FrameworkComplianceSummaryName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/frameworkComplianceSummaries/{framework_compliance_summary}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="frameworkComplianceSummaryId">
        /// The <c>FrameworkComplianceSummary</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="FrameworkComplianceSummaryName"/> constructed from the provided ids.
        /// </returns>
        public static FrameworkComplianceSummaryName FromProjectLocationFrameworkComplianceSummary(string projectId, string locationId, string frameworkComplianceSummaryId) =>
            new FrameworkComplianceSummaryName(ResourceNameType.ProjectLocationFrameworkComplianceSummary, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), frameworkComplianceSummaryId: gax::GaxPreconditions.CheckNotNullOrEmpty(frameworkComplianceSummaryId, nameof(frameworkComplianceSummaryId)));

        /// <summary>
        /// Creates a <see cref="FrameworkComplianceSummaryName"/> with the pattern
        /// <c>folders/{folder}/locations/{location}/frameworkComplianceSummaries/{framework_compliance_summary}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="frameworkComplianceSummaryId">
        /// The <c>FrameworkComplianceSummary</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="FrameworkComplianceSummaryName"/> constructed from the provided ids.
        /// </returns>
        public static FrameworkComplianceSummaryName FromFolderLocationFrameworkComplianceSummary(string folderId, string locationId, string frameworkComplianceSummaryId) =>
            new FrameworkComplianceSummaryName(ResourceNameType.FolderLocationFrameworkComplianceSummary, folderId: gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), frameworkComplianceSummaryId: gax::GaxPreconditions.CheckNotNullOrEmpty(frameworkComplianceSummaryId, nameof(frameworkComplianceSummaryId)));

        /// <summary>
        /// Creates a <see cref="FrameworkComplianceSummaryName"/> with the pattern
        /// <c>
        /// organizations/{organization}/locations/{location}/frameworkComplianceSummaries/{framework_compliance_summary}</c>
        /// .
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="frameworkComplianceSummaryId">
        /// The <c>FrameworkComplianceSummary</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="FrameworkComplianceSummaryName"/> constructed from the provided ids.
        /// </returns>
        public static FrameworkComplianceSummaryName FromOrganizationLocationFrameworkComplianceSummary(string organizationId, string locationId, string frameworkComplianceSummaryId) =>
            new FrameworkComplianceSummaryName(ResourceNameType.OrganizationLocationFrameworkComplianceSummary, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), frameworkComplianceSummaryId: gax::GaxPreconditions.CheckNotNullOrEmpty(frameworkComplianceSummaryId, nameof(frameworkComplianceSummaryId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="FrameworkComplianceSummaryName"/> with
        /// pattern
        /// <c>projects/{project}/locations/{location}/frameworkComplianceSummaries/{framework_compliance_summary}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="frameworkComplianceSummaryId">
        /// The <c>FrameworkComplianceSummary</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="FrameworkComplianceSummaryName"/> with pattern
        /// <c>projects/{project}/locations/{location}/frameworkComplianceSummaries/{framework_compliance_summary}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string frameworkComplianceSummaryId) =>
            FormatProjectLocationFrameworkComplianceSummary(projectId, locationId, frameworkComplianceSummaryId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="FrameworkComplianceSummaryName"/> with
        /// pattern
        /// <c>projects/{project}/locations/{location}/frameworkComplianceSummaries/{framework_compliance_summary}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="frameworkComplianceSummaryId">
        /// The <c>FrameworkComplianceSummary</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="FrameworkComplianceSummaryName"/> with pattern
        /// <c>projects/{project}/locations/{location}/frameworkComplianceSummaries/{framework_compliance_summary}</c>.
        /// </returns>
        public static string FormatProjectLocationFrameworkComplianceSummary(string projectId, string locationId, string frameworkComplianceSummaryId) =>
            s_projectLocationFrameworkComplianceSummary.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(frameworkComplianceSummaryId, nameof(frameworkComplianceSummaryId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="FrameworkComplianceSummaryName"/> with
        /// pattern <c>folders/{folder}/locations/{location}/frameworkComplianceSummaries/{framework_compliance_summary}</c>
        /// .
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="frameworkComplianceSummaryId">
        /// The <c>FrameworkComplianceSummary</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="FrameworkComplianceSummaryName"/> with pattern
        /// <c>folders/{folder}/locations/{location}/frameworkComplianceSummaries/{framework_compliance_summary}</c>.
        /// </returns>
        public static string FormatFolderLocationFrameworkComplianceSummary(string folderId, string locationId, string frameworkComplianceSummaryId) =>
            s_folderLocationFrameworkComplianceSummary.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(frameworkComplianceSummaryId, nameof(frameworkComplianceSummaryId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="FrameworkComplianceSummaryName"/> with
        /// pattern
        /// <c>
        /// organizations/{organization}/locations/{location}/frameworkComplianceSummaries/{framework_compliance_summary}</c>
        /// .
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="frameworkComplianceSummaryId">
        /// The <c>FrameworkComplianceSummary</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="FrameworkComplianceSummaryName"/> with pattern
        /// <c>
        /// organizations/{organization}/locations/{location}/frameworkComplianceSummaries/{framework_compliance_summary}</c>
        /// .
        /// </returns>
        public static string FormatOrganizationLocationFrameworkComplianceSummary(string organizationId, string locationId, string frameworkComplianceSummaryId) =>
            s_organizationLocationFrameworkComplianceSummary.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(frameworkComplianceSummaryId, nameof(frameworkComplianceSummaryId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="FrameworkComplianceSummaryName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/frameworkComplianceSummaries/{framework_compliance_summary}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>folders/{folder}/locations/{location}/frameworkComplianceSummaries/{framework_compliance_summary}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// organizations/{organization}/locations/{location}/frameworkComplianceSummaries/{framework_compliance_summary}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="frameworkComplianceSummaryName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <returns>The parsed <see cref="FrameworkComplianceSummaryName"/> if successful.</returns>
        public static FrameworkComplianceSummaryName Parse(string frameworkComplianceSummaryName) =>
            Parse(frameworkComplianceSummaryName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="FrameworkComplianceSummaryName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/frameworkComplianceSummaries/{framework_compliance_summary}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>folders/{folder}/locations/{location}/frameworkComplianceSummaries/{framework_compliance_summary}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// organizations/{organization}/locations/{location}/frameworkComplianceSummaries/{framework_compliance_summary}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="frameworkComplianceSummaryName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="FrameworkComplianceSummaryName"/> if successful.</returns>
        public static FrameworkComplianceSummaryName Parse(string frameworkComplianceSummaryName, bool allowUnparsed) =>
            TryParse(frameworkComplianceSummaryName, allowUnparsed, out FrameworkComplianceSummaryName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="FrameworkComplianceSummaryName"/>
        /// instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/frameworkComplianceSummaries/{framework_compliance_summary}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>folders/{folder}/locations/{location}/frameworkComplianceSummaries/{framework_compliance_summary}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// organizations/{organization}/locations/{location}/frameworkComplianceSummaries/{framework_compliance_summary}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="frameworkComplianceSummaryName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="FrameworkComplianceSummaryName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string frameworkComplianceSummaryName, out FrameworkComplianceSummaryName result) =>
            TryParse(frameworkComplianceSummaryName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="FrameworkComplianceSummaryName"/>
        /// instance; optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/frameworkComplianceSummaries/{framework_compliance_summary}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>folders/{folder}/locations/{location}/frameworkComplianceSummaries/{framework_compliance_summary}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// organizations/{organization}/locations/{location}/frameworkComplianceSummaries/{framework_compliance_summary}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="frameworkComplianceSummaryName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="FrameworkComplianceSummaryName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string frameworkComplianceSummaryName, bool allowUnparsed, out FrameworkComplianceSummaryName result)
        {
            gax::GaxPreconditions.CheckNotNull(frameworkComplianceSummaryName, nameof(frameworkComplianceSummaryName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationFrameworkComplianceSummary.TryParseName(frameworkComplianceSummaryName, out resourceName))
            {
                result = FromProjectLocationFrameworkComplianceSummary(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (s_folderLocationFrameworkComplianceSummary.TryParseName(frameworkComplianceSummaryName, out resourceName))
            {
                result = FromFolderLocationFrameworkComplianceSummary(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (s_organizationLocationFrameworkComplianceSummary.TryParseName(frameworkComplianceSummaryName, out resourceName))
            {
                result = FromOrganizationLocationFrameworkComplianceSummary(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(frameworkComplianceSummaryName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private FrameworkComplianceSummaryName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string folderId = null, string frameworkComplianceSummaryId = null, string locationId = null, string organizationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            FolderId = folderId;
            FrameworkComplianceSummaryId = frameworkComplianceSummaryId;
            LocationId = locationId;
            OrganizationId = organizationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="FrameworkComplianceSummaryName"/> class from the component parts
        /// of pattern
        /// <c>projects/{project}/locations/{location}/frameworkComplianceSummaries/{framework_compliance_summary}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="frameworkComplianceSummaryId">
        /// The <c>FrameworkComplianceSummary</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public FrameworkComplianceSummaryName(string projectId, string locationId, string frameworkComplianceSummaryId) : this(ResourceNameType.ProjectLocationFrameworkComplianceSummary, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), frameworkComplianceSummaryId: gax::GaxPreconditions.CheckNotNullOrEmpty(frameworkComplianceSummaryId, nameof(frameworkComplianceSummaryId)))
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
        /// The <c>FrameworkComplianceSummary</c> ID. May be <c>null</c>, depending on which resource name is contained
        /// by this instance.
        /// </summary>
        public string FrameworkComplianceSummaryId { get; }

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
                case ResourceNameType.ProjectLocationFrameworkComplianceSummary: return s_projectLocationFrameworkComplianceSummary.Expand(ProjectId, LocationId, FrameworkComplianceSummaryId);
                case ResourceNameType.FolderLocationFrameworkComplianceSummary: return s_folderLocationFrameworkComplianceSummary.Expand(FolderId, LocationId, FrameworkComplianceSummaryId);
                case ResourceNameType.OrganizationLocationFrameworkComplianceSummary: return s_organizationLocationFrameworkComplianceSummary.Expand(OrganizationId, LocationId, FrameworkComplianceSummaryId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as FrameworkComplianceSummaryName);

        /// <inheritdoc/>
        public bool Equals(FrameworkComplianceSummaryName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(FrameworkComplianceSummaryName a, FrameworkComplianceSummaryName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(FrameworkComplianceSummaryName a, FrameworkComplianceSummaryName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>FindingSummary</c> resource.</summary>
    public sealed partial class FindingSummaryName : gax::IResourceName, sys::IEquatable<FindingSummaryName>
    {
        /// <summary>The possible contents of <see cref="FindingSummaryName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/findingSummaries/{finding_summary}</c>.
            /// </summary>
            ProjectLocationFindingSummary = 1,

            /// <summary>
            /// A resource name with pattern <c>folders/{folder}/locations/{location}/findingSummaries/{finding_summary}</c>
            /// .
            /// </summary>
            FolderLocationFindingSummary = 2,

            /// <summary>
            /// A resource name with pattern
            /// <c>organizations/{organization}/locations/{location}/findingSummaries/{finding_summary}</c>.
            /// </summary>
            OrganizationLocationFindingSummary = 3,
        }

        private static gax::PathTemplate s_projectLocationFindingSummary = new gax::PathTemplate("projects/{project}/locations/{location}/findingSummaries/{finding_summary}");

        private static gax::PathTemplate s_folderLocationFindingSummary = new gax::PathTemplate("folders/{folder}/locations/{location}/findingSummaries/{finding_summary}");

        private static gax::PathTemplate s_organizationLocationFindingSummary = new gax::PathTemplate("organizations/{organization}/locations/{location}/findingSummaries/{finding_summary}");

        /// <summary>Creates a <see cref="FindingSummaryName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="FindingSummaryName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static FindingSummaryName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new FindingSummaryName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="FindingSummaryName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/findingSummaries/{finding_summary}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="findingSummaryId">The <c>FindingSummary</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="FindingSummaryName"/> constructed from the provided ids.</returns>
        public static FindingSummaryName FromProjectLocationFindingSummary(string projectId, string locationId, string findingSummaryId) =>
            new FindingSummaryName(ResourceNameType.ProjectLocationFindingSummary, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), findingSummaryId: gax::GaxPreconditions.CheckNotNullOrEmpty(findingSummaryId, nameof(findingSummaryId)));

        /// <summary>
        /// Creates a <see cref="FindingSummaryName"/> with the pattern
        /// <c>folders/{folder}/locations/{location}/findingSummaries/{finding_summary}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="findingSummaryId">The <c>FindingSummary</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="FindingSummaryName"/> constructed from the provided ids.</returns>
        public static FindingSummaryName FromFolderLocationFindingSummary(string folderId, string locationId, string findingSummaryId) =>
            new FindingSummaryName(ResourceNameType.FolderLocationFindingSummary, folderId: gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), findingSummaryId: gax::GaxPreconditions.CheckNotNullOrEmpty(findingSummaryId, nameof(findingSummaryId)));

        /// <summary>
        /// Creates a <see cref="FindingSummaryName"/> with the pattern
        /// <c>organizations/{organization}/locations/{location}/findingSummaries/{finding_summary}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="findingSummaryId">The <c>FindingSummary</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="FindingSummaryName"/> constructed from the provided ids.</returns>
        public static FindingSummaryName FromOrganizationLocationFindingSummary(string organizationId, string locationId, string findingSummaryId) =>
            new FindingSummaryName(ResourceNameType.OrganizationLocationFindingSummary, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), findingSummaryId: gax::GaxPreconditions.CheckNotNullOrEmpty(findingSummaryId, nameof(findingSummaryId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="FindingSummaryName"/> with pattern
        /// <c>projects/{project}/locations/{location}/findingSummaries/{finding_summary}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="findingSummaryId">The <c>FindingSummary</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="FindingSummaryName"/> with pattern
        /// <c>projects/{project}/locations/{location}/findingSummaries/{finding_summary}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string findingSummaryId) =>
            FormatProjectLocationFindingSummary(projectId, locationId, findingSummaryId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="FindingSummaryName"/> with pattern
        /// <c>projects/{project}/locations/{location}/findingSummaries/{finding_summary}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="findingSummaryId">The <c>FindingSummary</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="FindingSummaryName"/> with pattern
        /// <c>projects/{project}/locations/{location}/findingSummaries/{finding_summary}</c>.
        /// </returns>
        public static string FormatProjectLocationFindingSummary(string projectId, string locationId, string findingSummaryId) =>
            s_projectLocationFindingSummary.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(findingSummaryId, nameof(findingSummaryId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="FindingSummaryName"/> with pattern
        /// <c>folders/{folder}/locations/{location}/findingSummaries/{finding_summary}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="findingSummaryId">The <c>FindingSummary</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="FindingSummaryName"/> with pattern
        /// <c>folders/{folder}/locations/{location}/findingSummaries/{finding_summary}</c>.
        /// </returns>
        public static string FormatFolderLocationFindingSummary(string folderId, string locationId, string findingSummaryId) =>
            s_folderLocationFindingSummary.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(findingSummaryId, nameof(findingSummaryId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="FindingSummaryName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}/findingSummaries/{finding_summary}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="findingSummaryId">The <c>FindingSummary</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="FindingSummaryName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}/findingSummaries/{finding_summary}</c>.
        /// </returns>
        public static string FormatOrganizationLocationFindingSummary(string organizationId, string locationId, string findingSummaryId) =>
            s_organizationLocationFindingSummary.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(findingSummaryId, nameof(findingSummaryId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="FindingSummaryName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/findingSummaries/{finding_summary}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description><c>folders/{folder}/locations/{location}/findingSummaries/{finding_summary}</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/findingSummaries/{finding_summary}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="findingSummaryName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="FindingSummaryName"/> if successful.</returns>
        public static FindingSummaryName Parse(string findingSummaryName) => Parse(findingSummaryName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="FindingSummaryName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/findingSummaries/{finding_summary}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description><c>folders/{folder}/locations/{location}/findingSummaries/{finding_summary}</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/findingSummaries/{finding_summary}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="findingSummaryName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="FindingSummaryName"/> if successful.</returns>
        public static FindingSummaryName Parse(string findingSummaryName, bool allowUnparsed) =>
            TryParse(findingSummaryName, allowUnparsed, out FindingSummaryName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="FindingSummaryName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/findingSummaries/{finding_summary}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description><c>folders/{folder}/locations/{location}/findingSummaries/{finding_summary}</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/findingSummaries/{finding_summary}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="findingSummaryName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="FindingSummaryName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string findingSummaryName, out FindingSummaryName result) =>
            TryParse(findingSummaryName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="FindingSummaryName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/findingSummaries/{finding_summary}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description><c>folders/{folder}/locations/{location}/findingSummaries/{finding_summary}</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/findingSummaries/{finding_summary}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="findingSummaryName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="FindingSummaryName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string findingSummaryName, bool allowUnparsed, out FindingSummaryName result)
        {
            gax::GaxPreconditions.CheckNotNull(findingSummaryName, nameof(findingSummaryName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationFindingSummary.TryParseName(findingSummaryName, out resourceName))
            {
                result = FromProjectLocationFindingSummary(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (s_folderLocationFindingSummary.TryParseName(findingSummaryName, out resourceName))
            {
                result = FromFolderLocationFindingSummary(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (s_organizationLocationFindingSummary.TryParseName(findingSummaryName, out resourceName))
            {
                result = FromOrganizationLocationFindingSummary(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(findingSummaryName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private FindingSummaryName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string findingSummaryId = null, string folderId = null, string locationId = null, string organizationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            FindingSummaryId = findingSummaryId;
            FolderId = folderId;
            LocationId = locationId;
            OrganizationId = organizationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="FindingSummaryName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/findingSummaries/{finding_summary}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="findingSummaryId">The <c>FindingSummary</c> ID. Must not be <c>null</c> or empty.</param>
        public FindingSummaryName(string projectId, string locationId, string findingSummaryId) : this(ResourceNameType.ProjectLocationFindingSummary, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), findingSummaryId: gax::GaxPreconditions.CheckNotNullOrEmpty(findingSummaryId, nameof(findingSummaryId)))
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
        /// The <c>FindingSummary</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string FindingSummaryId { get; }

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
                case ResourceNameType.ProjectLocationFindingSummary: return s_projectLocationFindingSummary.Expand(ProjectId, LocationId, FindingSummaryId);
                case ResourceNameType.FolderLocationFindingSummary: return s_folderLocationFindingSummary.Expand(FolderId, LocationId, FindingSummaryId);
                case ResourceNameType.OrganizationLocationFindingSummary: return s_organizationLocationFindingSummary.Expand(OrganizationId, LocationId, FindingSummaryId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as FindingSummaryName);

        /// <inheritdoc/>
        public bool Equals(FindingSummaryName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(FindingSummaryName a, FindingSummaryName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(FindingSummaryName a, FindingSummaryName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>ControlComplianceSummary</c> resource.</summary>
    public sealed partial class ControlComplianceSummaryName : gax::IResourceName, sys::IEquatable<ControlComplianceSummaryName>
    {
        /// <summary>The possible contents of <see cref="ControlComplianceSummaryName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// projects/{project}/locations/{location}/frameworkComplianceReports/{framework_compliance_report}/controlComplianceSummaries/{control_compliance_summary}</c>
            /// .
            /// </summary>
            ProjectLocationFrameworkComplianceReportControlComplianceSummary = 1,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// folders/{folder}/locations/{location}/frameworkComplianceReports/{framework_compliance_report}/controlComplianceSummaries/{control_compliance_summary}</c>
            /// .
            /// </summary>
            FolderLocationFrameworkComplianceReportControlComplianceSummary = 2,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// organizations/{organization}/locations/{location}/frameworkComplianceReports/{framework_compliance_report}/controlComplianceSummaries/{control_compliance_summary}</c>
            /// .
            /// </summary>
            OrganizationLocationFrameworkComplianceReportControlComplianceSummary = 3,
        }

        private static gax::PathTemplate s_projectLocationFrameworkComplianceReportControlComplianceSummary = new gax::PathTemplate("projects/{project}/locations/{location}/frameworkComplianceReports/{framework_compliance_report}/controlComplianceSummaries/{control_compliance_summary}");

        private static gax::PathTemplate s_folderLocationFrameworkComplianceReportControlComplianceSummary = new gax::PathTemplate("folders/{folder}/locations/{location}/frameworkComplianceReports/{framework_compliance_report}/controlComplianceSummaries/{control_compliance_summary}");

        private static gax::PathTemplate s_organizationLocationFrameworkComplianceReportControlComplianceSummary = new gax::PathTemplate("organizations/{organization}/locations/{location}/frameworkComplianceReports/{framework_compliance_report}/controlComplianceSummaries/{control_compliance_summary}");

        /// <summary>
        /// Creates a <see cref="ControlComplianceSummaryName"/> containing an unparsed resource name.
        /// </summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ControlComplianceSummaryName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ControlComplianceSummaryName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ControlComplianceSummaryName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ControlComplianceSummaryName"/> with the pattern
        /// <c>
        /// projects/{project}/locations/{location}/frameworkComplianceReports/{framework_compliance_report}/controlComplianceSummaries/{control_compliance_summary}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="frameworkComplianceReportId">
        /// The <c>FrameworkComplianceReport</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="controlComplianceSummaryId">
        /// The <c>ControlComplianceSummary</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="ControlComplianceSummaryName"/> constructed from the provided ids.
        /// </returns>
        public static ControlComplianceSummaryName FromProjectLocationFrameworkComplianceReportControlComplianceSummary(string projectId, string locationId, string frameworkComplianceReportId, string controlComplianceSummaryId) =>
            new ControlComplianceSummaryName(ResourceNameType.ProjectLocationFrameworkComplianceReportControlComplianceSummary, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), frameworkComplianceReportId: gax::GaxPreconditions.CheckNotNullOrEmpty(frameworkComplianceReportId, nameof(frameworkComplianceReportId)), controlComplianceSummaryId: gax::GaxPreconditions.CheckNotNullOrEmpty(controlComplianceSummaryId, nameof(controlComplianceSummaryId)));

        /// <summary>
        /// Creates a <see cref="ControlComplianceSummaryName"/> with the pattern
        /// <c>
        /// folders/{folder}/locations/{location}/frameworkComplianceReports/{framework_compliance_report}/controlComplianceSummaries/{control_compliance_summary}</c>
        /// .
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="frameworkComplianceReportId">
        /// The <c>FrameworkComplianceReport</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="controlComplianceSummaryId">
        /// The <c>ControlComplianceSummary</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="ControlComplianceSummaryName"/> constructed from the provided ids.
        /// </returns>
        public static ControlComplianceSummaryName FromFolderLocationFrameworkComplianceReportControlComplianceSummary(string folderId, string locationId, string frameworkComplianceReportId, string controlComplianceSummaryId) =>
            new ControlComplianceSummaryName(ResourceNameType.FolderLocationFrameworkComplianceReportControlComplianceSummary, folderId: gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), frameworkComplianceReportId: gax::GaxPreconditions.CheckNotNullOrEmpty(frameworkComplianceReportId, nameof(frameworkComplianceReportId)), controlComplianceSummaryId: gax::GaxPreconditions.CheckNotNullOrEmpty(controlComplianceSummaryId, nameof(controlComplianceSummaryId)));

        /// <summary>
        /// Creates a <see cref="ControlComplianceSummaryName"/> with the pattern
        /// <c>
        /// organizations/{organization}/locations/{location}/frameworkComplianceReports/{framework_compliance_report}/controlComplianceSummaries/{control_compliance_summary}</c>
        /// .
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="frameworkComplianceReportId">
        /// The <c>FrameworkComplianceReport</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="controlComplianceSummaryId">
        /// The <c>ControlComplianceSummary</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="ControlComplianceSummaryName"/> constructed from the provided ids.
        /// </returns>
        public static ControlComplianceSummaryName FromOrganizationLocationFrameworkComplianceReportControlComplianceSummary(string organizationId, string locationId, string frameworkComplianceReportId, string controlComplianceSummaryId) =>
            new ControlComplianceSummaryName(ResourceNameType.OrganizationLocationFrameworkComplianceReportControlComplianceSummary, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), frameworkComplianceReportId: gax::GaxPreconditions.CheckNotNullOrEmpty(frameworkComplianceReportId, nameof(frameworkComplianceReportId)), controlComplianceSummaryId: gax::GaxPreconditions.CheckNotNullOrEmpty(controlComplianceSummaryId, nameof(controlComplianceSummaryId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ControlComplianceSummaryName"/> with
        /// pattern
        /// <c>
        /// projects/{project}/locations/{location}/frameworkComplianceReports/{framework_compliance_report}/controlComplianceSummaries/{control_compliance_summary}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="frameworkComplianceReportId">
        /// The <c>FrameworkComplianceReport</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="controlComplianceSummaryId">
        /// The <c>ControlComplianceSummary</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="ControlComplianceSummaryName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/frameworkComplianceReports/{framework_compliance_report}/controlComplianceSummaries/{control_compliance_summary}</c>
        /// .
        /// </returns>
        public static string Format(string projectId, string locationId, string frameworkComplianceReportId, string controlComplianceSummaryId) =>
            FormatProjectLocationFrameworkComplianceReportControlComplianceSummary(projectId, locationId, frameworkComplianceReportId, controlComplianceSummaryId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ControlComplianceSummaryName"/> with
        /// pattern
        /// <c>
        /// projects/{project}/locations/{location}/frameworkComplianceReports/{framework_compliance_report}/controlComplianceSummaries/{control_compliance_summary}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="frameworkComplianceReportId">
        /// The <c>FrameworkComplianceReport</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="controlComplianceSummaryId">
        /// The <c>ControlComplianceSummary</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="ControlComplianceSummaryName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/frameworkComplianceReports/{framework_compliance_report}/controlComplianceSummaries/{control_compliance_summary}</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationFrameworkComplianceReportControlComplianceSummary(string projectId, string locationId, string frameworkComplianceReportId, string controlComplianceSummaryId) =>
            s_projectLocationFrameworkComplianceReportControlComplianceSummary.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(frameworkComplianceReportId, nameof(frameworkComplianceReportId)), gax::GaxPreconditions.CheckNotNullOrEmpty(controlComplianceSummaryId, nameof(controlComplianceSummaryId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ControlComplianceSummaryName"/> with
        /// pattern
        /// <c>
        /// folders/{folder}/locations/{location}/frameworkComplianceReports/{framework_compliance_report}/controlComplianceSummaries/{control_compliance_summary}</c>
        /// .
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="frameworkComplianceReportId">
        /// The <c>FrameworkComplianceReport</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="controlComplianceSummaryId">
        /// The <c>ControlComplianceSummary</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="ControlComplianceSummaryName"/> with pattern
        /// <c>
        /// folders/{folder}/locations/{location}/frameworkComplianceReports/{framework_compliance_report}/controlComplianceSummaries/{control_compliance_summary}</c>
        /// .
        /// </returns>
        public static string FormatFolderLocationFrameworkComplianceReportControlComplianceSummary(string folderId, string locationId, string frameworkComplianceReportId, string controlComplianceSummaryId) =>
            s_folderLocationFrameworkComplianceReportControlComplianceSummary.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(frameworkComplianceReportId, nameof(frameworkComplianceReportId)), gax::GaxPreconditions.CheckNotNullOrEmpty(controlComplianceSummaryId, nameof(controlComplianceSummaryId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ControlComplianceSummaryName"/> with
        /// pattern
        /// <c>
        /// organizations/{organization}/locations/{location}/frameworkComplianceReports/{framework_compliance_report}/controlComplianceSummaries/{control_compliance_summary}</c>
        /// .
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="frameworkComplianceReportId">
        /// The <c>FrameworkComplianceReport</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="controlComplianceSummaryId">
        /// The <c>ControlComplianceSummary</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="ControlComplianceSummaryName"/> with pattern
        /// <c>
        /// organizations/{organization}/locations/{location}/frameworkComplianceReports/{framework_compliance_report}/controlComplianceSummaries/{control_compliance_summary}</c>
        /// .
        /// </returns>
        public static string FormatOrganizationLocationFrameworkComplianceReportControlComplianceSummary(string organizationId, string locationId, string frameworkComplianceReportId, string controlComplianceSummaryId) =>
            s_organizationLocationFrameworkComplianceReportControlComplianceSummary.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(frameworkComplianceReportId, nameof(frameworkComplianceReportId)), gax::GaxPreconditions.CheckNotNullOrEmpty(controlComplianceSummaryId, nameof(controlComplianceSummaryId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ControlComplianceSummaryName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/frameworkComplianceReports/{framework_compliance_report}/controlComplianceSummaries/{control_compliance_summary}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// folders/{folder}/locations/{location}/frameworkComplianceReports/{framework_compliance_report}/controlComplianceSummaries/{control_compliance_summary}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// organizations/{organization}/locations/{location}/frameworkComplianceReports/{framework_compliance_report}/controlComplianceSummaries/{control_compliance_summary}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="controlComplianceSummaryName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <returns>The parsed <see cref="ControlComplianceSummaryName"/> if successful.</returns>
        public static ControlComplianceSummaryName Parse(string controlComplianceSummaryName) =>
            Parse(controlComplianceSummaryName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ControlComplianceSummaryName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/frameworkComplianceReports/{framework_compliance_report}/controlComplianceSummaries/{control_compliance_summary}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// folders/{folder}/locations/{location}/frameworkComplianceReports/{framework_compliance_report}/controlComplianceSummaries/{control_compliance_summary}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// organizations/{organization}/locations/{location}/frameworkComplianceReports/{framework_compliance_report}/controlComplianceSummaries/{control_compliance_summary}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="controlComplianceSummaryName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ControlComplianceSummaryName"/> if successful.</returns>
        public static ControlComplianceSummaryName Parse(string controlComplianceSummaryName, bool allowUnparsed) =>
            TryParse(controlComplianceSummaryName, allowUnparsed, out ControlComplianceSummaryName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ControlComplianceSummaryName"/>
        /// instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/frameworkComplianceReports/{framework_compliance_report}/controlComplianceSummaries/{control_compliance_summary}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// folders/{folder}/locations/{location}/frameworkComplianceReports/{framework_compliance_report}/controlComplianceSummaries/{control_compliance_summary}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// organizations/{organization}/locations/{location}/frameworkComplianceReports/{framework_compliance_report}/controlComplianceSummaries/{control_compliance_summary}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="controlComplianceSummaryName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ControlComplianceSummaryName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string controlComplianceSummaryName, out ControlComplianceSummaryName result) =>
            TryParse(controlComplianceSummaryName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ControlComplianceSummaryName"/>
        /// instance; optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/frameworkComplianceReports/{framework_compliance_report}/controlComplianceSummaries/{control_compliance_summary}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// folders/{folder}/locations/{location}/frameworkComplianceReports/{framework_compliance_report}/controlComplianceSummaries/{control_compliance_summary}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// organizations/{organization}/locations/{location}/frameworkComplianceReports/{framework_compliance_report}/controlComplianceSummaries/{control_compliance_summary}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="controlComplianceSummaryName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ControlComplianceSummaryName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string controlComplianceSummaryName, bool allowUnparsed, out ControlComplianceSummaryName result)
        {
            gax::GaxPreconditions.CheckNotNull(controlComplianceSummaryName, nameof(controlComplianceSummaryName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationFrameworkComplianceReportControlComplianceSummary.TryParseName(controlComplianceSummaryName, out resourceName))
            {
                result = FromProjectLocationFrameworkComplianceReportControlComplianceSummary(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (s_folderLocationFrameworkComplianceReportControlComplianceSummary.TryParseName(controlComplianceSummaryName, out resourceName))
            {
                result = FromFolderLocationFrameworkComplianceReportControlComplianceSummary(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (s_organizationLocationFrameworkComplianceReportControlComplianceSummary.TryParseName(controlComplianceSummaryName, out resourceName))
            {
                result = FromOrganizationLocationFrameworkComplianceReportControlComplianceSummary(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(controlComplianceSummaryName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ControlComplianceSummaryName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string controlComplianceSummaryId = null, string folderId = null, string frameworkComplianceReportId = null, string locationId = null, string organizationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ControlComplianceSummaryId = controlComplianceSummaryId;
            FolderId = folderId;
            FrameworkComplianceReportId = frameworkComplianceReportId;
            LocationId = locationId;
            OrganizationId = organizationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ControlComplianceSummaryName"/> class from the component parts of
        /// pattern
        /// <c>
        /// projects/{project}/locations/{location}/frameworkComplianceReports/{framework_compliance_report}/controlComplianceSummaries/{control_compliance_summary}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="frameworkComplianceReportId">
        /// The <c>FrameworkComplianceReport</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="controlComplianceSummaryId">
        /// The <c>ControlComplianceSummary</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public ControlComplianceSummaryName(string projectId, string locationId, string frameworkComplianceReportId, string controlComplianceSummaryId) : this(ResourceNameType.ProjectLocationFrameworkComplianceReportControlComplianceSummary, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), frameworkComplianceReportId: gax::GaxPreconditions.CheckNotNullOrEmpty(frameworkComplianceReportId, nameof(frameworkComplianceReportId)), controlComplianceSummaryId: gax::GaxPreconditions.CheckNotNullOrEmpty(controlComplianceSummaryId, nameof(controlComplianceSummaryId)))
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
        /// The <c>ControlComplianceSummary</c> ID. May be <c>null</c>, depending on which resource name is contained by
        /// this instance.
        /// </summary>
        public string ControlComplianceSummaryId { get; }

        /// <summary>
        /// The <c>Folder</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string FolderId { get; }

        /// <summary>
        /// The <c>FrameworkComplianceReport</c> ID. May be <c>null</c>, depending on which resource name is contained
        /// by this instance.
        /// </summary>
        public string FrameworkComplianceReportId { get; }

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
                case ResourceNameType.ProjectLocationFrameworkComplianceReportControlComplianceSummary: return s_projectLocationFrameworkComplianceReportControlComplianceSummary.Expand(ProjectId, LocationId, FrameworkComplianceReportId, ControlComplianceSummaryId);
                case ResourceNameType.FolderLocationFrameworkComplianceReportControlComplianceSummary: return s_folderLocationFrameworkComplianceReportControlComplianceSummary.Expand(FolderId, LocationId, FrameworkComplianceReportId, ControlComplianceSummaryId);
                case ResourceNameType.OrganizationLocationFrameworkComplianceReportControlComplianceSummary: return s_organizationLocationFrameworkComplianceReportControlComplianceSummary.Expand(OrganizationId, LocationId, FrameworkComplianceReportId, ControlComplianceSummaryId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ControlComplianceSummaryName);

        /// <inheritdoc/>
        public bool Equals(ControlComplianceSummaryName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ControlComplianceSummaryName a, ControlComplianceSummaryName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ControlComplianceSummaryName a, ControlComplianceSummaryName b) => !(a == b);
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

    public partial class ListFrameworkComplianceSummariesRequest
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
        /// <see cref="OrganizationLocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public OrganizationLocationName ParentAsOrganizationLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : OrganizationLocationName.Parse(Parent, allowUnparsed: true);
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
                if (OrganizationLocationName.TryParse(Parent, out OrganizationLocationName organizationLocation))
                {
                    return organizationLocation;
                }
                return gax::UnparsedResourceName.Parse(Parent);
            }
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class FrameworkComplianceReport
    {
        /// <summary>
        /// <see cref="gccv::FrameworkComplianceReportName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gccv::FrameworkComplianceReportName FrameworkComplianceReportName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::FrameworkComplianceReportName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class FetchFrameworkComplianceReportRequest
    {
        /// <summary>
        /// <see cref="gccv::FrameworkComplianceReportName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gccv::FrameworkComplianceReportName FrameworkComplianceReportName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::FrameworkComplianceReportName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListFindingSummariesRequest
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
        /// <see cref="OrganizationLocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public OrganizationLocationName ParentAsOrganizationLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : OrganizationLocationName.Parse(Parent, allowUnparsed: true);
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
                if (OrganizationLocationName.TryParse(Parent, out OrganizationLocationName organizationLocation))
                {
                    return organizationLocation;
                }
                return gax::UnparsedResourceName.Parse(Parent);
            }
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class ListControlComplianceSummariesRequest
    {
        /// <summary>
        /// <see cref="FrameworkComplianceReportName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public FrameworkComplianceReportName ParentAsFrameworkComplianceReportName
        {
            get => string.IsNullOrEmpty(Parent) ? null : FrameworkComplianceReportName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class AggregateFrameworkComplianceReportRequest
    {
        /// <summary>
        /// <see cref="gccv::FrameworkComplianceReportName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gccv::FrameworkComplianceReportName FrameworkComplianceReportName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::FrameworkComplianceReportName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class FrameworkComplianceSummary
    {
        /// <summary>
        /// <see cref="gccv::FrameworkComplianceSummaryName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gccv::FrameworkComplianceSummaryName FrameworkComplianceSummaryName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::FrameworkComplianceSummaryName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class FindingSummary
    {
        /// <summary>
        /// <see cref="gccv::FindingSummaryName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::FindingSummaryName FindingSummaryName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::FindingSummaryName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ControlComplianceSummary
    {
        /// <summary>
        /// <see cref="gccv::ControlComplianceSummaryName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gccv::ControlComplianceSummaryName ControlComplianceSummaryName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::ControlComplianceSummaryName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
