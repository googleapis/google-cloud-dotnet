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
using gagr = Google.Api.Gax.ResourceNames;
using gax = Google.Api.Gax;
using gcsv = Google.Cloud.StorageInsights.V1;
using sys = System;

namespace Google.Cloud.StorageInsights.V1
{
    /// <summary>Resource name for the <c>ReportDetail</c> resource.</summary>
    public sealed partial class ReportDetailName : gax::IResourceName, sys::IEquatable<ReportDetailName>
    {
        /// <summary>The possible contents of <see cref="ReportDetailName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/reportConfigs/{report_config}/reportDetails/{report_detail}</c>
            /// .
            /// </summary>
            ProjectLocationReportConfigReportDetail = 1,
        }

        private static gax::PathTemplate s_projectLocationReportConfigReportDetail = new gax::PathTemplate("projects/{project}/locations/{location}/reportConfigs/{report_config}/reportDetails/{report_detail}");

        /// <summary>Creates a <see cref="ReportDetailName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ReportDetailName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ReportDetailName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ReportDetailName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ReportDetailName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/reportConfigs/{report_config}/reportDetails/{report_detail}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="reportConfigId">The <c>ReportConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="reportDetailId">The <c>ReportDetail</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ReportDetailName"/> constructed from the provided ids.</returns>
        public static ReportDetailName FromProjectLocationReportConfigReportDetail(string projectId, string locationId, string reportConfigId, string reportDetailId) =>
            new ReportDetailName(ResourceNameType.ProjectLocationReportConfigReportDetail, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), reportConfigId: gax::GaxPreconditions.CheckNotNullOrEmpty(reportConfigId, nameof(reportConfigId)), reportDetailId: gax::GaxPreconditions.CheckNotNullOrEmpty(reportDetailId, nameof(reportDetailId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ReportDetailName"/> with pattern
        /// <c>projects/{project}/locations/{location}/reportConfigs/{report_config}/reportDetails/{report_detail}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="reportConfigId">The <c>ReportConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="reportDetailId">The <c>ReportDetail</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ReportDetailName"/> with pattern
        /// <c>projects/{project}/locations/{location}/reportConfigs/{report_config}/reportDetails/{report_detail}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string reportConfigId, string reportDetailId) =>
            FormatProjectLocationReportConfigReportDetail(projectId, locationId, reportConfigId, reportDetailId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ReportDetailName"/> with pattern
        /// <c>projects/{project}/locations/{location}/reportConfigs/{report_config}/reportDetails/{report_detail}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="reportConfigId">The <c>ReportConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="reportDetailId">The <c>ReportDetail</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ReportDetailName"/> with pattern
        /// <c>projects/{project}/locations/{location}/reportConfigs/{report_config}/reportDetails/{report_detail}</c>.
        /// </returns>
        public static string FormatProjectLocationReportConfigReportDetail(string projectId, string locationId, string reportConfigId, string reportDetailId) =>
            s_projectLocationReportConfigReportDetail.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(reportConfigId, nameof(reportConfigId)), gax::GaxPreconditions.CheckNotNullOrEmpty(reportDetailId, nameof(reportDetailId)));

        /// <summary>Parses the given resource name string into a new <see cref="ReportDetailName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/reportConfigs/{report_config}/reportDetails/{report_detail}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="reportDetailName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ReportDetailName"/> if successful.</returns>
        public static ReportDetailName Parse(string reportDetailName) => Parse(reportDetailName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ReportDetailName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/reportConfigs/{report_config}/reportDetails/{report_detail}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="reportDetailName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ReportDetailName"/> if successful.</returns>
        public static ReportDetailName Parse(string reportDetailName, bool allowUnparsed) =>
            TryParse(reportDetailName, allowUnparsed, out ReportDetailName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ReportDetailName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/reportConfigs/{report_config}/reportDetails/{report_detail}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="reportDetailName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ReportDetailName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string reportDetailName, out ReportDetailName result) =>
            TryParse(reportDetailName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ReportDetailName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/reportConfigs/{report_config}/reportDetails/{report_detail}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="reportDetailName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ReportDetailName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string reportDetailName, bool allowUnparsed, out ReportDetailName result)
        {
            gax::GaxPreconditions.CheckNotNull(reportDetailName, nameof(reportDetailName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationReportConfigReportDetail.TryParseName(reportDetailName, out resourceName))
            {
                result = FromProjectLocationReportConfigReportDetail(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(reportDetailName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ReportDetailName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string reportConfigId = null, string reportDetailId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            ReportConfigId = reportConfigId;
            ReportDetailId = reportDetailId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ReportDetailName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/reportConfigs/{report_config}/reportDetails/{report_detail}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="reportConfigId">The <c>ReportConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="reportDetailId">The <c>ReportDetail</c> ID. Must not be <c>null</c> or empty.</param>
        public ReportDetailName(string projectId, string locationId, string reportConfigId, string reportDetailId) : this(ResourceNameType.ProjectLocationReportConfigReportDetail, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), reportConfigId: gax::GaxPreconditions.CheckNotNullOrEmpty(reportConfigId, nameof(reportConfigId)), reportDetailId: gax::GaxPreconditions.CheckNotNullOrEmpty(reportDetailId, nameof(reportDetailId)))
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
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>ReportConfig</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string ReportConfigId { get; }

        /// <summary>
        /// The <c>ReportDetail</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string ReportDetailId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationReportConfigReportDetail: return s_projectLocationReportConfigReportDetail.Expand(ProjectId, LocationId, ReportConfigId, ReportDetailId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ReportDetailName);

        /// <inheritdoc/>
        public bool Equals(ReportDetailName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ReportDetailName a, ReportDetailName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ReportDetailName a, ReportDetailName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>ReportConfig</c> resource.</summary>
    public sealed partial class ReportConfigName : gax::IResourceName, sys::IEquatable<ReportConfigName>
    {
        /// <summary>The possible contents of <see cref="ReportConfigName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/reportConfigs/{report_config}</c>
            /// .
            /// </summary>
            ProjectLocationReportConfig = 1,
        }

        private static gax::PathTemplate s_projectLocationReportConfig = new gax::PathTemplate("projects/{project}/locations/{location}/reportConfigs/{report_config}");

        /// <summary>Creates a <see cref="ReportConfigName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ReportConfigName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ReportConfigName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ReportConfigName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ReportConfigName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/reportConfigs/{report_config}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="reportConfigId">The <c>ReportConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ReportConfigName"/> constructed from the provided ids.</returns>
        public static ReportConfigName FromProjectLocationReportConfig(string projectId, string locationId, string reportConfigId) =>
            new ReportConfigName(ResourceNameType.ProjectLocationReportConfig, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), reportConfigId: gax::GaxPreconditions.CheckNotNullOrEmpty(reportConfigId, nameof(reportConfigId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ReportConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/reportConfigs/{report_config}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="reportConfigId">The <c>ReportConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ReportConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/reportConfigs/{report_config}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string reportConfigId) =>
            FormatProjectLocationReportConfig(projectId, locationId, reportConfigId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ReportConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/reportConfigs/{report_config}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="reportConfigId">The <c>ReportConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ReportConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/reportConfigs/{report_config}</c>.
        /// </returns>
        public static string FormatProjectLocationReportConfig(string projectId, string locationId, string reportConfigId) =>
            s_projectLocationReportConfig.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(reportConfigId, nameof(reportConfigId)));

        /// <summary>Parses the given resource name string into a new <see cref="ReportConfigName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/reportConfigs/{report_config}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="reportConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ReportConfigName"/> if successful.</returns>
        public static ReportConfigName Parse(string reportConfigName) => Parse(reportConfigName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ReportConfigName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/reportConfigs/{report_config}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="reportConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ReportConfigName"/> if successful.</returns>
        public static ReportConfigName Parse(string reportConfigName, bool allowUnparsed) =>
            TryParse(reportConfigName, allowUnparsed, out ReportConfigName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ReportConfigName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/reportConfigs/{report_config}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="reportConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ReportConfigName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string reportConfigName, out ReportConfigName result) =>
            TryParse(reportConfigName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ReportConfigName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/reportConfigs/{report_config}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="reportConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ReportConfigName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string reportConfigName, bool allowUnparsed, out ReportConfigName result)
        {
            gax::GaxPreconditions.CheckNotNull(reportConfigName, nameof(reportConfigName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationReportConfig.TryParseName(reportConfigName, out resourceName))
            {
                result = FromProjectLocationReportConfig(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(reportConfigName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ReportConfigName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string reportConfigId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            ReportConfigId = reportConfigId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ReportConfigName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/reportConfigs/{report_config}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="reportConfigId">The <c>ReportConfig</c> ID. Must not be <c>null</c> or empty.</param>
        public ReportConfigName(string projectId, string locationId, string reportConfigId) : this(ResourceNameType.ProjectLocationReportConfig, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), reportConfigId: gax::GaxPreconditions.CheckNotNullOrEmpty(reportConfigId, nameof(reportConfigId)))
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
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>ReportConfig</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string ReportConfigId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationReportConfig: return s_projectLocationReportConfig.Expand(ProjectId, LocationId, ReportConfigId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ReportConfigName);

        /// <inheritdoc/>
        public bool Equals(ReportConfigName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ReportConfigName a, ReportConfigName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ReportConfigName a, ReportConfigName b) => !(a == b);
    }

    public partial class ListReportConfigsRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetReportConfigRequest
    {
        /// <summary>
        /// <see cref="gcsv::ReportConfigName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcsv::ReportConfigName ReportConfigName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcsv::ReportConfigName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateReportConfigRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteReportConfigRequest
    {
        /// <summary>
        /// <see cref="gcsv::ReportConfigName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcsv::ReportConfigName ReportConfigName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcsv::ReportConfigName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ReportDetail
    {
        /// <summary>
        /// <see cref="gcsv::ReportDetailName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcsv::ReportDetailName ReportDetailName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcsv::ReportDetailName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListReportDetailsRequest
    {
        /// <summary>
        /// <see cref="ReportConfigName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ReportConfigName ParentAsReportConfigName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ReportConfigName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetReportDetailRequest
    {
        /// <summary>
        /// <see cref="gcsv::ReportDetailName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcsv::ReportDetailName ReportDetailName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcsv::ReportDetailName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ReportConfig
    {
        /// <summary>
        /// <see cref="gcsv::ReportConfigName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcsv::ReportConfigName ReportConfigName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcsv::ReportConfigName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
