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
    /// <summary>Resource name for the <c>GenerateFrameworkAuditScopeReportResponse</c> resource.</summary>
    public sealed partial class GenerateFrameworkAuditScopeReportResponseName : gax::IResourceName, sys::IEquatable<GenerateFrameworkAuditScopeReportResponseName>
    {
        /// <summary>The possible contents of <see cref="GenerateFrameworkAuditScopeReportResponseName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// projects/{project}/locations/{location}/frameworkAuditScopeReports/{generate_framework_audit_scope_report_response}</c>
            /// .
            /// </summary>
            ProjectLocationGenerateFrameworkAuditScopeReportResponse = 1,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// organizations/{organization}/locations/{location}/frameworkAuditScopeReports/{generate_framework_audit_scope_report_response}</c>
            /// .
            /// </summary>
            OrganizationLocationGenerateFrameworkAuditScopeReportResponse = 2,
        }

        private static gax::PathTemplate s_projectLocationGenerateFrameworkAuditScopeReportResponse = new gax::PathTemplate("projects/{project}/locations/{location}/frameworkAuditScopeReports/{generate_framework_audit_scope_report_response}");

        private static gax::PathTemplate s_organizationLocationGenerateFrameworkAuditScopeReportResponse = new gax::PathTemplate("organizations/{organization}/locations/{location}/frameworkAuditScopeReports/{generate_framework_audit_scope_report_response}");

        /// <summary>
        /// Creates a <see cref="GenerateFrameworkAuditScopeReportResponseName"/> containing an unparsed resource name.
        /// </summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="GenerateFrameworkAuditScopeReportResponseName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static GenerateFrameworkAuditScopeReportResponseName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new GenerateFrameworkAuditScopeReportResponseName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="GenerateFrameworkAuditScopeReportResponseName"/> with the pattern
        /// <c>
        /// projects/{project}/locations/{location}/frameworkAuditScopeReports/{generate_framework_audit_scope_report_response}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="generateFrameworkAuditScopeReportResponseId">
        /// The <c>GenerateFrameworkAuditScopeReportResponse</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="GenerateFrameworkAuditScopeReportResponseName"/> constructed from the provided
        /// ids.
        /// </returns>
        public static GenerateFrameworkAuditScopeReportResponseName FromProjectLocationGenerateFrameworkAuditScopeReportResponse(string projectId, string locationId, string generateFrameworkAuditScopeReportResponseId) =>
            new GenerateFrameworkAuditScopeReportResponseName(ResourceNameType.ProjectLocationGenerateFrameworkAuditScopeReportResponse, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), generateFrameworkAuditScopeReportResponseId: gax::GaxPreconditions.CheckNotNullOrEmpty(generateFrameworkAuditScopeReportResponseId, nameof(generateFrameworkAuditScopeReportResponseId)));

        /// <summary>
        /// Creates a <see cref="GenerateFrameworkAuditScopeReportResponseName"/> with the pattern
        /// <c>
        /// organizations/{organization}/locations/{location}/frameworkAuditScopeReports/{generate_framework_audit_scope_report_response}</c>
        /// .
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="generateFrameworkAuditScopeReportResponseId">
        /// The <c>GenerateFrameworkAuditScopeReportResponse</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="GenerateFrameworkAuditScopeReportResponseName"/> constructed from the provided
        /// ids.
        /// </returns>
        public static GenerateFrameworkAuditScopeReportResponseName FromOrganizationLocationGenerateFrameworkAuditScopeReportResponse(string organizationId, string locationId, string generateFrameworkAuditScopeReportResponseId) =>
            new GenerateFrameworkAuditScopeReportResponseName(ResourceNameType.OrganizationLocationGenerateFrameworkAuditScopeReportResponse, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), generateFrameworkAuditScopeReportResponseId: gax::GaxPreconditions.CheckNotNullOrEmpty(generateFrameworkAuditScopeReportResponseId, nameof(generateFrameworkAuditScopeReportResponseId)));

        /// <summary>
        /// Formats the IDs into the string representation of this
        /// <see cref="GenerateFrameworkAuditScopeReportResponseName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/frameworkAuditScopeReports/{generate_framework_audit_scope_report_response}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="generateFrameworkAuditScopeReportResponseId">
        /// The <c>GenerateFrameworkAuditScopeReportResponse</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="GenerateFrameworkAuditScopeReportResponseName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/frameworkAuditScopeReports/{generate_framework_audit_scope_report_response}</c>
        /// .
        /// </returns>
        public static string Format(string projectId, string locationId, string generateFrameworkAuditScopeReportResponseId) =>
            FormatProjectLocationGenerateFrameworkAuditScopeReportResponse(projectId, locationId, generateFrameworkAuditScopeReportResponseId);

        /// <summary>
        /// Formats the IDs into the string representation of this
        /// <see cref="GenerateFrameworkAuditScopeReportResponseName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/frameworkAuditScopeReports/{generate_framework_audit_scope_report_response}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="generateFrameworkAuditScopeReportResponseId">
        /// The <c>GenerateFrameworkAuditScopeReportResponse</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="GenerateFrameworkAuditScopeReportResponseName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/frameworkAuditScopeReports/{generate_framework_audit_scope_report_response}</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationGenerateFrameworkAuditScopeReportResponse(string projectId, string locationId, string generateFrameworkAuditScopeReportResponseId) =>
            s_projectLocationGenerateFrameworkAuditScopeReportResponse.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(generateFrameworkAuditScopeReportResponseId, nameof(generateFrameworkAuditScopeReportResponseId)));

        /// <summary>
        /// Formats the IDs into the string representation of this
        /// <see cref="GenerateFrameworkAuditScopeReportResponseName"/> with pattern
        /// <c>
        /// organizations/{organization}/locations/{location}/frameworkAuditScopeReports/{generate_framework_audit_scope_report_response}</c>
        /// .
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="generateFrameworkAuditScopeReportResponseId">
        /// The <c>GenerateFrameworkAuditScopeReportResponse</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="GenerateFrameworkAuditScopeReportResponseName"/> with pattern
        /// <c>
        /// organizations/{organization}/locations/{location}/frameworkAuditScopeReports/{generate_framework_audit_scope_report_response}</c>
        /// .
        /// </returns>
        public static string FormatOrganizationLocationGenerateFrameworkAuditScopeReportResponse(string organizationId, string locationId, string generateFrameworkAuditScopeReportResponseId) =>
            s_organizationLocationGenerateFrameworkAuditScopeReportResponse.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(generateFrameworkAuditScopeReportResponseId, nameof(generateFrameworkAuditScopeReportResponseId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="GenerateFrameworkAuditScopeReportResponseName"/>
        /// instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/frameworkAuditScopeReports/{generate_framework_audit_scope_report_response}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// organizations/{organization}/locations/{location}/frameworkAuditScopeReports/{generate_framework_audit_scope_report_response}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="generateFrameworkAuditScopeReportResponseName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <returns>The parsed <see cref="GenerateFrameworkAuditScopeReportResponseName"/> if successful.</returns>
        public static GenerateFrameworkAuditScopeReportResponseName Parse(string generateFrameworkAuditScopeReportResponseName) =>
            Parse(generateFrameworkAuditScopeReportResponseName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="GenerateFrameworkAuditScopeReportResponseName"/>
        /// instance; optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/frameworkAuditScopeReports/{generate_framework_audit_scope_report_response}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// organizations/{organization}/locations/{location}/frameworkAuditScopeReports/{generate_framework_audit_scope_report_response}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="generateFrameworkAuditScopeReportResponseName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="GenerateFrameworkAuditScopeReportResponseName"/> if successful.</returns>
        public static GenerateFrameworkAuditScopeReportResponseName Parse(string generateFrameworkAuditScopeReportResponseName, bool allowUnparsed) =>
            TryParse(generateFrameworkAuditScopeReportResponseName, allowUnparsed, out GenerateFrameworkAuditScopeReportResponseName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new
        /// <see cref="GenerateFrameworkAuditScopeReportResponseName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/frameworkAuditScopeReports/{generate_framework_audit_scope_report_response}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// organizations/{organization}/locations/{location}/frameworkAuditScopeReports/{generate_framework_audit_scope_report_response}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="generateFrameworkAuditScopeReportResponseName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="GenerateFrameworkAuditScopeReportResponseName"/>, or <c>null</c>
        ///  if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string generateFrameworkAuditScopeReportResponseName, out GenerateFrameworkAuditScopeReportResponseName result) =>
            TryParse(generateFrameworkAuditScopeReportResponseName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new
        /// <see cref="GenerateFrameworkAuditScopeReportResponseName"/> instance; optionally allowing an unparseable
        /// resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/frameworkAuditScopeReports/{generate_framework_audit_scope_report_response}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// organizations/{organization}/locations/{location}/frameworkAuditScopeReports/{generate_framework_audit_scope_report_response}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="generateFrameworkAuditScopeReportResponseName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="GenerateFrameworkAuditScopeReportResponseName"/>, or <c>null</c>
        ///  if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string generateFrameworkAuditScopeReportResponseName, bool allowUnparsed, out GenerateFrameworkAuditScopeReportResponseName result)
        {
            gax::GaxPreconditions.CheckNotNull(generateFrameworkAuditScopeReportResponseName, nameof(generateFrameworkAuditScopeReportResponseName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationGenerateFrameworkAuditScopeReportResponse.TryParseName(generateFrameworkAuditScopeReportResponseName, out resourceName))
            {
                result = FromProjectLocationGenerateFrameworkAuditScopeReportResponse(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (s_organizationLocationGenerateFrameworkAuditScopeReportResponse.TryParseName(generateFrameworkAuditScopeReportResponseName, out resourceName))
            {
                result = FromOrganizationLocationGenerateFrameworkAuditScopeReportResponse(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(generateFrameworkAuditScopeReportResponseName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private GenerateFrameworkAuditScopeReportResponseName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string generateFrameworkAuditScopeReportResponseId = null, string locationId = null, string organizationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            GenerateFrameworkAuditScopeReportResponseId = generateFrameworkAuditScopeReportResponseId;
            LocationId = locationId;
            OrganizationId = organizationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="GenerateFrameworkAuditScopeReportResponseName"/> class from the
        /// component parts of pattern
        /// <c>
        /// projects/{project}/locations/{location}/frameworkAuditScopeReports/{generate_framework_audit_scope_report_response}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="generateFrameworkAuditScopeReportResponseId">
        /// The <c>GenerateFrameworkAuditScopeReportResponse</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public GenerateFrameworkAuditScopeReportResponseName(string projectId, string locationId, string generateFrameworkAuditScopeReportResponseId) : this(ResourceNameType.ProjectLocationGenerateFrameworkAuditScopeReportResponse, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), generateFrameworkAuditScopeReportResponseId: gax::GaxPreconditions.CheckNotNullOrEmpty(generateFrameworkAuditScopeReportResponseId, nameof(generateFrameworkAuditScopeReportResponseId)))
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
        /// The <c>GenerateFrameworkAuditScopeReportResponse</c> ID. May be <c>null</c>, depending on which resource
        /// name is contained by this instance.
        /// </summary>
        public string GenerateFrameworkAuditScopeReportResponseId { get; }

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
                case ResourceNameType.ProjectLocationGenerateFrameworkAuditScopeReportResponse: return s_projectLocationGenerateFrameworkAuditScopeReportResponse.Expand(ProjectId, LocationId, GenerateFrameworkAuditScopeReportResponseId);
                case ResourceNameType.OrganizationLocationGenerateFrameworkAuditScopeReportResponse: return s_organizationLocationGenerateFrameworkAuditScopeReportResponse.Expand(OrganizationId, LocationId, GenerateFrameworkAuditScopeReportResponseId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as GenerateFrameworkAuditScopeReportResponseName);

        /// <inheritdoc/>
        public bool Equals(GenerateFrameworkAuditScopeReportResponseName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(GenerateFrameworkAuditScopeReportResponseName a, GenerateFrameworkAuditScopeReportResponseName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(GenerateFrameworkAuditScopeReportResponseName a, GenerateFrameworkAuditScopeReportResponseName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>FrameworkAudit</c> resource.</summary>
    public sealed partial class FrameworkAuditName : gax::IResourceName, sys::IEquatable<FrameworkAuditName>
    {
        /// <summary>The possible contents of <see cref="FrameworkAuditName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/frameworkAudits/{framework_audit}</c>.
            /// </summary>
            ProjectLocationFrameworkAudit = 1,

            /// <summary>
            /// A resource name with pattern
            /// <c>organizations/{organization}/locations/{location}/frameworkAudits/{framework_audit}</c>.
            /// </summary>
            OrganizationLocationFrameworkAudit = 2,
        }

        private static gax::PathTemplate s_projectLocationFrameworkAudit = new gax::PathTemplate("projects/{project}/locations/{location}/frameworkAudits/{framework_audit}");

        private static gax::PathTemplate s_organizationLocationFrameworkAudit = new gax::PathTemplate("organizations/{organization}/locations/{location}/frameworkAudits/{framework_audit}");

        /// <summary>Creates a <see cref="FrameworkAuditName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="FrameworkAuditName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static FrameworkAuditName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new FrameworkAuditName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="FrameworkAuditName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/frameworkAudits/{framework_audit}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="frameworkAuditId">The <c>FrameworkAudit</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="FrameworkAuditName"/> constructed from the provided ids.</returns>
        public static FrameworkAuditName FromProjectLocationFrameworkAudit(string projectId, string locationId, string frameworkAuditId) =>
            new FrameworkAuditName(ResourceNameType.ProjectLocationFrameworkAudit, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), frameworkAuditId: gax::GaxPreconditions.CheckNotNullOrEmpty(frameworkAuditId, nameof(frameworkAuditId)));

        /// <summary>
        /// Creates a <see cref="FrameworkAuditName"/> with the pattern
        /// <c>organizations/{organization}/locations/{location}/frameworkAudits/{framework_audit}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="frameworkAuditId">The <c>FrameworkAudit</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="FrameworkAuditName"/> constructed from the provided ids.</returns>
        public static FrameworkAuditName FromOrganizationLocationFrameworkAudit(string organizationId, string locationId, string frameworkAuditId) =>
            new FrameworkAuditName(ResourceNameType.OrganizationLocationFrameworkAudit, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), frameworkAuditId: gax::GaxPreconditions.CheckNotNullOrEmpty(frameworkAuditId, nameof(frameworkAuditId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="FrameworkAuditName"/> with pattern
        /// <c>projects/{project}/locations/{location}/frameworkAudits/{framework_audit}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="frameworkAuditId">The <c>FrameworkAudit</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="FrameworkAuditName"/> with pattern
        /// <c>projects/{project}/locations/{location}/frameworkAudits/{framework_audit}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string frameworkAuditId) =>
            FormatProjectLocationFrameworkAudit(projectId, locationId, frameworkAuditId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="FrameworkAuditName"/> with pattern
        /// <c>projects/{project}/locations/{location}/frameworkAudits/{framework_audit}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="frameworkAuditId">The <c>FrameworkAudit</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="FrameworkAuditName"/> with pattern
        /// <c>projects/{project}/locations/{location}/frameworkAudits/{framework_audit}</c>.
        /// </returns>
        public static string FormatProjectLocationFrameworkAudit(string projectId, string locationId, string frameworkAuditId) =>
            s_projectLocationFrameworkAudit.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(frameworkAuditId, nameof(frameworkAuditId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="FrameworkAuditName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}/frameworkAudits/{framework_audit}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="frameworkAuditId">The <c>FrameworkAudit</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="FrameworkAuditName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}/frameworkAudits/{framework_audit}</c>.
        /// </returns>
        public static string FormatOrganizationLocationFrameworkAudit(string organizationId, string locationId, string frameworkAuditId) =>
            s_organizationLocationFrameworkAudit.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(frameworkAuditId, nameof(frameworkAuditId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="FrameworkAuditName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/frameworkAudits/{framework_audit}</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/frameworkAudits/{framework_audit}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="frameworkAuditName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="FrameworkAuditName"/> if successful.</returns>
        public static FrameworkAuditName Parse(string frameworkAuditName) => Parse(frameworkAuditName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="FrameworkAuditName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/frameworkAudits/{framework_audit}</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/frameworkAudits/{framework_audit}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="frameworkAuditName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="FrameworkAuditName"/> if successful.</returns>
        public static FrameworkAuditName Parse(string frameworkAuditName, bool allowUnparsed) =>
            TryParse(frameworkAuditName, allowUnparsed, out FrameworkAuditName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="FrameworkAuditName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/frameworkAudits/{framework_audit}</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/frameworkAudits/{framework_audit}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="frameworkAuditName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="FrameworkAuditName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string frameworkAuditName, out FrameworkAuditName result) =>
            TryParse(frameworkAuditName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="FrameworkAuditName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/frameworkAudits/{framework_audit}</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/frameworkAudits/{framework_audit}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="frameworkAuditName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="FrameworkAuditName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string frameworkAuditName, bool allowUnparsed, out FrameworkAuditName result)
        {
            gax::GaxPreconditions.CheckNotNull(frameworkAuditName, nameof(frameworkAuditName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationFrameworkAudit.TryParseName(frameworkAuditName, out resourceName))
            {
                result = FromProjectLocationFrameworkAudit(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (s_organizationLocationFrameworkAudit.TryParseName(frameworkAuditName, out resourceName))
            {
                result = FromOrganizationLocationFrameworkAudit(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(frameworkAuditName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private FrameworkAuditName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string frameworkAuditId = null, string locationId = null, string organizationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            FrameworkAuditId = frameworkAuditId;
            LocationId = locationId;
            OrganizationId = organizationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="FrameworkAuditName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/frameworkAudits/{framework_audit}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="frameworkAuditId">The <c>FrameworkAudit</c> ID. Must not be <c>null</c> or empty.</param>
        public FrameworkAuditName(string projectId, string locationId, string frameworkAuditId) : this(ResourceNameType.ProjectLocationFrameworkAudit, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), frameworkAuditId: gax::GaxPreconditions.CheckNotNullOrEmpty(frameworkAuditId, nameof(frameworkAuditId)))
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
        /// The <c>FrameworkAudit</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string FrameworkAuditId { get; }

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
                case ResourceNameType.ProjectLocationFrameworkAudit: return s_projectLocationFrameworkAudit.Expand(ProjectId, LocationId, FrameworkAuditId);
                case ResourceNameType.OrganizationLocationFrameworkAudit: return s_organizationLocationFrameworkAudit.Expand(OrganizationId, LocationId, FrameworkAuditId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as FrameworkAuditName);

        /// <inheritdoc/>
        public bool Equals(FrameworkAuditName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(FrameworkAuditName a, FrameworkAuditName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(FrameworkAuditName a, FrameworkAuditName b) => !(a == b);
    }

    public partial class GenerateFrameworkAuditScopeReportResponse
    {
        /// <summary>
        /// <see cref="gccv::GenerateFrameworkAuditScopeReportResponseName"/>-typed view over the <see cref="Name"/>
        /// resource name property.
        /// </summary>
        public gccv::GenerateFrameworkAuditScopeReportResponseName GenerateFrameworkAuditScopeReportResponseName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::GenerateFrameworkAuditScopeReportResponseName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateFrameworkAuditRequest
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
                if (OrganizationLocationName.TryParse(Parent, out OrganizationLocationName organizationLocation))
                {
                    return organizationLocation;
                }
                return gax::UnparsedResourceName.Parse(Parent);
            }
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class FrameworkAudit
    {
        /// <summary>
        /// <see cref="gccv::FrameworkAuditName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::FrameworkAuditName FrameworkAuditName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::FrameworkAuditName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListFrameworkAuditsRequest
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
                if (OrganizationLocationName.TryParse(Parent, out OrganizationLocationName organizationLocation))
                {
                    return organizationLocation;
                }
                return gax::UnparsedResourceName.Parse(Parent);
            }
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetFrameworkAuditRequest
    {
        /// <summary>
        /// <see cref="gccv::FrameworkAuditName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::FrameworkAuditName FrameworkAuditName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::FrameworkAuditName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
