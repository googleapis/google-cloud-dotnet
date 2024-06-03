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
using gcmv = Google.Cloud.Monitoring.V3;
using sys = System;

namespace Google.Cloud.Monitoring.V3
{
    /// <summary>Resource name for the <c>MetricDescriptor</c> resource.</summary>
    public sealed partial class MetricDescriptorName : gax::IResourceName, sys::IEquatable<MetricDescriptorName>
    {
        /// <summary>The possible contents of <see cref="MetricDescriptorName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/metricDescriptors/{metric_descriptor=**}</c>.
            /// </summary>
            ProjectMetricDescriptor = 1,

            /// <summary>
            /// A resource name with pattern <c>organizations/{organization}/metricDescriptors/{metric_descriptor=**}</c>
            /// .
            /// </summary>
            OrganizationMetricDescriptor = 2,

            /// <summary>
            /// A resource name with pattern <c>folders/{folder}/metricDescriptors/{metric_descriptor=**}</c>.
            /// </summary>
            FolderMetricDescriptor = 3,
        }

        private static gax::PathTemplate s_projectMetricDescriptor = new gax::PathTemplate("projects/{project}/metricDescriptors/{metric_descriptor=**}");

        private static gax::PathTemplate s_organizationMetricDescriptor = new gax::PathTemplate("organizations/{organization}/metricDescriptors/{metric_descriptor=**}");

        private static gax::PathTemplate s_folderMetricDescriptor = new gax::PathTemplate("folders/{folder}/metricDescriptors/{metric_descriptor=**}");

        /// <summary>Creates a <see cref="MetricDescriptorName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="MetricDescriptorName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static MetricDescriptorName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new MetricDescriptorName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="MetricDescriptorName"/> with the pattern
        /// <c>projects/{project}/metricDescriptors/{metric_descriptor=**}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="metricDescriptorId">The <c>MetricDescriptor</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="MetricDescriptorName"/> constructed from the provided ids.</returns>
        public static MetricDescriptorName FromProjectMetricDescriptor(string projectId, string metricDescriptorId) =>
            new MetricDescriptorName(ResourceNameType.ProjectMetricDescriptor, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), metricDescriptorId: gax::GaxPreconditions.CheckNotNullOrEmpty(metricDescriptorId, nameof(metricDescriptorId)));

        /// <summary>
        /// Creates a <see cref="MetricDescriptorName"/> with the pattern
        /// <c>organizations/{organization}/metricDescriptors/{metric_descriptor=**}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="metricDescriptorId">The <c>MetricDescriptor</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="MetricDescriptorName"/> constructed from the provided ids.</returns>
        public static MetricDescriptorName FromOrganizationMetricDescriptor(string organizationId, string metricDescriptorId) =>
            new MetricDescriptorName(ResourceNameType.OrganizationMetricDescriptor, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), metricDescriptorId: gax::GaxPreconditions.CheckNotNullOrEmpty(metricDescriptorId, nameof(metricDescriptorId)));

        /// <summary>
        /// Creates a <see cref="MetricDescriptorName"/> with the pattern
        /// <c>folders/{folder}/metricDescriptors/{metric_descriptor=**}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="metricDescriptorId">The <c>MetricDescriptor</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="MetricDescriptorName"/> constructed from the provided ids.</returns>
        public static MetricDescriptorName FromFolderMetricDescriptor(string folderId, string metricDescriptorId) =>
            new MetricDescriptorName(ResourceNameType.FolderMetricDescriptor, folderId: gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), metricDescriptorId: gax::GaxPreconditions.CheckNotNullOrEmpty(metricDescriptorId, nameof(metricDescriptorId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="MetricDescriptorName"/> with pattern
        /// <c>projects/{project}/metricDescriptors/{metric_descriptor=**}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="metricDescriptorId">The <c>MetricDescriptor</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="MetricDescriptorName"/> with pattern
        /// <c>projects/{project}/metricDescriptors/{metric_descriptor=**}</c>.
        /// </returns>
        public static string Format(string projectId, string metricDescriptorId) =>
            FormatProjectMetricDescriptor(projectId, metricDescriptorId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="MetricDescriptorName"/> with pattern
        /// <c>projects/{project}/metricDescriptors/{metric_descriptor=**}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="metricDescriptorId">The <c>MetricDescriptor</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="MetricDescriptorName"/> with pattern
        /// <c>projects/{project}/metricDescriptors/{metric_descriptor=**}</c>.
        /// </returns>
        public static string FormatProjectMetricDescriptor(string projectId, string metricDescriptorId) =>
            s_projectMetricDescriptor.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(metricDescriptorId, nameof(metricDescriptorId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="MetricDescriptorName"/> with pattern
        /// <c>organizations/{organization}/metricDescriptors/{metric_descriptor=**}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="metricDescriptorId">The <c>MetricDescriptor</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="MetricDescriptorName"/> with pattern
        /// <c>organizations/{organization}/metricDescriptors/{metric_descriptor=**}</c>.
        /// </returns>
        public static string FormatOrganizationMetricDescriptor(string organizationId, string metricDescriptorId) =>
            s_organizationMetricDescriptor.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(metricDescriptorId, nameof(metricDescriptorId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="MetricDescriptorName"/> with pattern
        /// <c>folders/{folder}/metricDescriptors/{metric_descriptor=**}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="metricDescriptorId">The <c>MetricDescriptor</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="MetricDescriptorName"/> with pattern
        /// <c>folders/{folder}/metricDescriptors/{metric_descriptor=**}</c>.
        /// </returns>
        public static string FormatFolderMetricDescriptor(string folderId, string metricDescriptorId) =>
            s_folderMetricDescriptor.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), gax::GaxPreconditions.CheckNotNullOrEmpty(metricDescriptorId, nameof(metricDescriptorId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="MetricDescriptorName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/metricDescriptors/{metric_descriptor=**}</c></description></item>
        /// <item>
        /// <description><c>organizations/{organization}/metricDescriptors/{metric_descriptor=**}</c></description>
        /// </item>
        /// <item><description><c>folders/{folder}/metricDescriptors/{metric_descriptor=**}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="metricDescriptorName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="MetricDescriptorName"/> if successful.</returns>
        public static MetricDescriptorName Parse(string metricDescriptorName) => Parse(metricDescriptorName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="MetricDescriptorName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/metricDescriptors/{metric_descriptor=**}</c></description></item>
        /// <item>
        /// <description><c>organizations/{organization}/metricDescriptors/{metric_descriptor=**}</c></description>
        /// </item>
        /// <item><description><c>folders/{folder}/metricDescriptors/{metric_descriptor=**}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="metricDescriptorName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="MetricDescriptorName"/> if successful.</returns>
        public static MetricDescriptorName Parse(string metricDescriptorName, bool allowUnparsed) =>
            TryParse(metricDescriptorName, allowUnparsed, out MetricDescriptorName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="MetricDescriptorName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/metricDescriptors/{metric_descriptor=**}</c></description></item>
        /// <item>
        /// <description><c>organizations/{organization}/metricDescriptors/{metric_descriptor=**}</c></description>
        /// </item>
        /// <item><description><c>folders/{folder}/metricDescriptors/{metric_descriptor=**}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="metricDescriptorName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="MetricDescriptorName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string metricDescriptorName, out MetricDescriptorName result) =>
            TryParse(metricDescriptorName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="MetricDescriptorName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/metricDescriptors/{metric_descriptor=**}</c></description></item>
        /// <item>
        /// <description><c>organizations/{organization}/metricDescriptors/{metric_descriptor=**}</c></description>
        /// </item>
        /// <item><description><c>folders/{folder}/metricDescriptors/{metric_descriptor=**}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="metricDescriptorName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="MetricDescriptorName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string metricDescriptorName, bool allowUnparsed, out MetricDescriptorName result)
        {
            gax::GaxPreconditions.CheckNotNull(metricDescriptorName, nameof(metricDescriptorName));
            gax::TemplatedResourceName resourceName;
            if (s_projectMetricDescriptor.TryParseName(metricDescriptorName, out resourceName))
            {
                result = FromProjectMetricDescriptor(resourceName[0], resourceName[1]);
                return true;
            }
            if (s_organizationMetricDescriptor.TryParseName(metricDescriptorName, out resourceName))
            {
                result = FromOrganizationMetricDescriptor(resourceName[0], resourceName[1]);
                return true;
            }
            if (s_folderMetricDescriptor.TryParseName(metricDescriptorName, out resourceName))
            {
                result = FromFolderMetricDescriptor(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(metricDescriptorName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private MetricDescriptorName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string folderId = null, string metricDescriptorId = null, string organizationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            FolderId = folderId;
            MetricDescriptorId = metricDescriptorId;
            OrganizationId = organizationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="MetricDescriptorName"/> class from the component parts of pattern
        /// <c>projects/{project}/metricDescriptors/{metric_descriptor=**}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="metricDescriptorId">The <c>MetricDescriptor</c> ID. Must not be <c>null</c> or empty.</param>
        public MetricDescriptorName(string projectId, string metricDescriptorId) : this(ResourceNameType.ProjectMetricDescriptor, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), metricDescriptorId: gax::GaxPreconditions.CheckNotNullOrEmpty(metricDescriptorId, nameof(metricDescriptorId)))
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
        /// The <c>MetricDescriptor</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string MetricDescriptorId { get; }

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
                case ResourceNameType.ProjectMetricDescriptor: return s_projectMetricDescriptor.Expand(ProjectId, MetricDescriptorId);
                case ResourceNameType.OrganizationMetricDescriptor: return s_organizationMetricDescriptor.Expand(OrganizationId, MetricDescriptorId);
                case ResourceNameType.FolderMetricDescriptor: return s_folderMetricDescriptor.Expand(FolderId, MetricDescriptorId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as MetricDescriptorName);

        /// <inheritdoc/>
        public bool Equals(MetricDescriptorName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(MetricDescriptorName a, MetricDescriptorName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(MetricDescriptorName a, MetricDescriptorName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>MonitoredResourceDescriptor</c> resource.</summary>
    public sealed partial class MonitoredResourceDescriptorName : gax::IResourceName, sys::IEquatable<MonitoredResourceDescriptorName>
    {
        /// <summary>The possible contents of <see cref="MonitoredResourceDescriptorName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/monitoredResourceDescriptors/{monitored_resource_descriptor}</c>.
            /// </summary>
            ProjectMonitoredResourceDescriptor = 1,

            /// <summary>
            /// A resource name with pattern
            /// <c>organizations/{organization}/monitoredResourceDescriptors/{monitored_resource_descriptor}</c>.
            /// </summary>
            OrganizationMonitoredResourceDescriptor = 2,

            /// <summary>
            /// A resource name with pattern
            /// <c>folders/{folder}/monitoredResourceDescriptors/{monitored_resource_descriptor}</c>.
            /// </summary>
            FolderMonitoredResourceDescriptor = 3,
        }

        private static gax::PathTemplate s_projectMonitoredResourceDescriptor = new gax::PathTemplate("projects/{project}/monitoredResourceDescriptors/{monitored_resource_descriptor}");

        private static gax::PathTemplate s_organizationMonitoredResourceDescriptor = new gax::PathTemplate("organizations/{organization}/monitoredResourceDescriptors/{monitored_resource_descriptor}");

        private static gax::PathTemplate s_folderMonitoredResourceDescriptor = new gax::PathTemplate("folders/{folder}/monitoredResourceDescriptors/{monitored_resource_descriptor}");

        /// <summary>
        /// Creates a <see cref="MonitoredResourceDescriptorName"/> containing an unparsed resource name.
        /// </summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="MonitoredResourceDescriptorName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static MonitoredResourceDescriptorName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new MonitoredResourceDescriptorName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="MonitoredResourceDescriptorName"/> with the pattern
        /// <c>projects/{project}/monitoredResourceDescriptors/{monitored_resource_descriptor}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="monitoredResourceDescriptorId">
        /// The <c>MonitoredResourceDescriptor</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="MonitoredResourceDescriptorName"/> constructed from the provided ids.
        /// </returns>
        public static MonitoredResourceDescriptorName FromProjectMonitoredResourceDescriptor(string projectId, string monitoredResourceDescriptorId) =>
            new MonitoredResourceDescriptorName(ResourceNameType.ProjectMonitoredResourceDescriptor, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), monitoredResourceDescriptorId: gax::GaxPreconditions.CheckNotNullOrEmpty(monitoredResourceDescriptorId, nameof(monitoredResourceDescriptorId)));

        /// <summary>
        /// Creates a <see cref="MonitoredResourceDescriptorName"/> with the pattern
        /// <c>organizations/{organization}/monitoredResourceDescriptors/{monitored_resource_descriptor}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="monitoredResourceDescriptorId">
        /// The <c>MonitoredResourceDescriptor</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="MonitoredResourceDescriptorName"/> constructed from the provided ids.
        /// </returns>
        public static MonitoredResourceDescriptorName FromOrganizationMonitoredResourceDescriptor(string organizationId, string monitoredResourceDescriptorId) =>
            new MonitoredResourceDescriptorName(ResourceNameType.OrganizationMonitoredResourceDescriptor, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), monitoredResourceDescriptorId: gax::GaxPreconditions.CheckNotNullOrEmpty(monitoredResourceDescriptorId, nameof(monitoredResourceDescriptorId)));

        /// <summary>
        /// Creates a <see cref="MonitoredResourceDescriptorName"/> with the pattern
        /// <c>folders/{folder}/monitoredResourceDescriptors/{monitored_resource_descriptor}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="monitoredResourceDescriptorId">
        /// The <c>MonitoredResourceDescriptor</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="MonitoredResourceDescriptorName"/> constructed from the provided ids.
        /// </returns>
        public static MonitoredResourceDescriptorName FromFolderMonitoredResourceDescriptor(string folderId, string monitoredResourceDescriptorId) =>
            new MonitoredResourceDescriptorName(ResourceNameType.FolderMonitoredResourceDescriptor, folderId: gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), monitoredResourceDescriptorId: gax::GaxPreconditions.CheckNotNullOrEmpty(monitoredResourceDescriptorId, nameof(monitoredResourceDescriptorId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="MonitoredResourceDescriptorName"/> with
        /// pattern <c>projects/{project}/monitoredResourceDescriptors/{monitored_resource_descriptor}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="monitoredResourceDescriptorId">
        /// The <c>MonitoredResourceDescriptor</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="MonitoredResourceDescriptorName"/> with pattern
        /// <c>projects/{project}/monitoredResourceDescriptors/{monitored_resource_descriptor}</c>.
        /// </returns>
        public static string Format(string projectId, string monitoredResourceDescriptorId) =>
            FormatProjectMonitoredResourceDescriptor(projectId, monitoredResourceDescriptorId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="MonitoredResourceDescriptorName"/> with
        /// pattern <c>projects/{project}/monitoredResourceDescriptors/{monitored_resource_descriptor}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="monitoredResourceDescriptorId">
        /// The <c>MonitoredResourceDescriptor</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="MonitoredResourceDescriptorName"/> with pattern
        /// <c>projects/{project}/monitoredResourceDescriptors/{monitored_resource_descriptor}</c>.
        /// </returns>
        public static string FormatProjectMonitoredResourceDescriptor(string projectId, string monitoredResourceDescriptorId) =>
            s_projectMonitoredResourceDescriptor.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(monitoredResourceDescriptorId, nameof(monitoredResourceDescriptorId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="MonitoredResourceDescriptorName"/> with
        /// pattern <c>organizations/{organization}/monitoredResourceDescriptors/{monitored_resource_descriptor}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="monitoredResourceDescriptorId">
        /// The <c>MonitoredResourceDescriptor</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="MonitoredResourceDescriptorName"/> with pattern
        /// <c>organizations/{organization}/monitoredResourceDescriptors/{monitored_resource_descriptor}</c>.
        /// </returns>
        public static string FormatOrganizationMonitoredResourceDescriptor(string organizationId, string monitoredResourceDescriptorId) =>
            s_organizationMonitoredResourceDescriptor.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(monitoredResourceDescriptorId, nameof(monitoredResourceDescriptorId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="MonitoredResourceDescriptorName"/> with
        /// pattern <c>folders/{folder}/monitoredResourceDescriptors/{monitored_resource_descriptor}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="monitoredResourceDescriptorId">
        /// The <c>MonitoredResourceDescriptor</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="MonitoredResourceDescriptorName"/> with pattern
        /// <c>folders/{folder}/monitoredResourceDescriptors/{monitored_resource_descriptor}</c>.
        /// </returns>
        public static string FormatFolderMonitoredResourceDescriptor(string folderId, string monitoredResourceDescriptorId) =>
            s_folderMonitoredResourceDescriptor.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), gax::GaxPreconditions.CheckNotNullOrEmpty(monitoredResourceDescriptorId, nameof(monitoredResourceDescriptorId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="MonitoredResourceDescriptorName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/monitoredResourceDescriptors/{monitored_resource_descriptor}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/monitoredResourceDescriptors/{monitored_resource_descriptor}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>folders/{folder}/monitoredResourceDescriptors/{monitored_resource_descriptor}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="monitoredResourceDescriptorName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <returns>The parsed <see cref="MonitoredResourceDescriptorName"/> if successful.</returns>
        public static MonitoredResourceDescriptorName Parse(string monitoredResourceDescriptorName) =>
            Parse(monitoredResourceDescriptorName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="MonitoredResourceDescriptorName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/monitoredResourceDescriptors/{monitored_resource_descriptor}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/monitoredResourceDescriptors/{monitored_resource_descriptor}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>folders/{folder}/monitoredResourceDescriptors/{monitored_resource_descriptor}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="monitoredResourceDescriptorName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="MonitoredResourceDescriptorName"/> if successful.</returns>
        public static MonitoredResourceDescriptorName Parse(string monitoredResourceDescriptorName, bool allowUnparsed) =>
            TryParse(monitoredResourceDescriptorName, allowUnparsed, out MonitoredResourceDescriptorName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="MonitoredResourceDescriptorName"/>
        /// instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/monitoredResourceDescriptors/{monitored_resource_descriptor}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/monitoredResourceDescriptors/{monitored_resource_descriptor}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>folders/{folder}/monitoredResourceDescriptors/{monitored_resource_descriptor}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="monitoredResourceDescriptorName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="MonitoredResourceDescriptorName"/>, or <c>null</c> if
        /// parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string monitoredResourceDescriptorName, out MonitoredResourceDescriptorName result) =>
            TryParse(monitoredResourceDescriptorName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="MonitoredResourceDescriptorName"/>
        /// instance; optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/monitoredResourceDescriptors/{monitored_resource_descriptor}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/monitoredResourceDescriptors/{monitored_resource_descriptor}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>folders/{folder}/monitoredResourceDescriptors/{monitored_resource_descriptor}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="monitoredResourceDescriptorName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="MonitoredResourceDescriptorName"/>, or <c>null</c> if
        /// parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string monitoredResourceDescriptorName, bool allowUnparsed, out MonitoredResourceDescriptorName result)
        {
            gax::GaxPreconditions.CheckNotNull(monitoredResourceDescriptorName, nameof(monitoredResourceDescriptorName));
            gax::TemplatedResourceName resourceName;
            if (s_projectMonitoredResourceDescriptor.TryParseName(monitoredResourceDescriptorName, out resourceName))
            {
                result = FromProjectMonitoredResourceDescriptor(resourceName[0], resourceName[1]);
                return true;
            }
            if (s_organizationMonitoredResourceDescriptor.TryParseName(monitoredResourceDescriptorName, out resourceName))
            {
                result = FromOrganizationMonitoredResourceDescriptor(resourceName[0], resourceName[1]);
                return true;
            }
            if (s_folderMonitoredResourceDescriptor.TryParseName(monitoredResourceDescriptorName, out resourceName))
            {
                result = FromFolderMonitoredResourceDescriptor(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(monitoredResourceDescriptorName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private MonitoredResourceDescriptorName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string folderId = null, string monitoredResourceDescriptorId = null, string organizationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            FolderId = folderId;
            MonitoredResourceDescriptorId = monitoredResourceDescriptorId;
            OrganizationId = organizationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="MonitoredResourceDescriptorName"/> class from the component parts
        /// of pattern <c>projects/{project}/monitoredResourceDescriptors/{monitored_resource_descriptor}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="monitoredResourceDescriptorId">
        /// The <c>MonitoredResourceDescriptor</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public MonitoredResourceDescriptorName(string projectId, string monitoredResourceDescriptorId) : this(ResourceNameType.ProjectMonitoredResourceDescriptor, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), monitoredResourceDescriptorId: gax::GaxPreconditions.CheckNotNullOrEmpty(monitoredResourceDescriptorId, nameof(monitoredResourceDescriptorId)))
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
        /// The <c>MonitoredResourceDescriptor</c> ID. May be <c>null</c>, depending on which resource name is contained
        /// by this instance.
        /// </summary>
        public string MonitoredResourceDescriptorId { get; }

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
                case ResourceNameType.ProjectMonitoredResourceDescriptor: return s_projectMonitoredResourceDescriptor.Expand(ProjectId, MonitoredResourceDescriptorId);
                case ResourceNameType.OrganizationMonitoredResourceDescriptor: return s_organizationMonitoredResourceDescriptor.Expand(OrganizationId, MonitoredResourceDescriptorId);
                case ResourceNameType.FolderMonitoredResourceDescriptor: return s_folderMonitoredResourceDescriptor.Expand(FolderId, MonitoredResourceDescriptorId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as MonitoredResourceDescriptorName);

        /// <inheritdoc/>
        public bool Equals(MonitoredResourceDescriptorName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(MonitoredResourceDescriptorName a, MonitoredResourceDescriptorName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(MonitoredResourceDescriptorName a, MonitoredResourceDescriptorName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Workspace</c> resource.</summary>
    public sealed partial class WorkspaceName : gax::IResourceName, sys::IEquatable<WorkspaceName>
    {
        /// <summary>The possible contents of <see cref="WorkspaceName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>projects/{project}</c>.</summary>
            Project = 1,

            /// <summary>A resource name with pattern <c>workspaces/{workspace}</c>.</summary>
            Workspace = 2,
        }

        private static gax::PathTemplate s_project = new gax::PathTemplate("projects/{project}");

        private static gax::PathTemplate s_workspace = new gax::PathTemplate("workspaces/{workspace}");

        /// <summary>Creates a <see cref="WorkspaceName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="WorkspaceName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static WorkspaceName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new WorkspaceName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>Creates a <see cref="WorkspaceName"/> with the pattern <c>projects/{project}</c>.</summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="WorkspaceName"/> constructed from the provided ids.</returns>
        public static WorkspaceName FromProject(string projectId) =>
            new WorkspaceName(ResourceNameType.Project, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)));

        /// <summary>Creates a <see cref="WorkspaceName"/> with the pattern <c>workspaces/{workspace}</c>.</summary>
        /// <param name="workspaceId">The <c>Workspace</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="WorkspaceName"/> constructed from the provided ids.</returns>
        public static WorkspaceName FromWorkspace(string workspaceId) =>
            new WorkspaceName(ResourceNameType.Workspace, workspaceId: gax::GaxPreconditions.CheckNotNullOrEmpty(workspaceId, nameof(workspaceId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="WorkspaceName"/> with pattern
        /// <c>projects/{project}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="WorkspaceName"/> with pattern <c>projects/{project}</c>.
        /// </returns>
        public static string Format(string projectId) => FormatProject(projectId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="WorkspaceName"/> with pattern
        /// <c>projects/{project}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="WorkspaceName"/> with pattern <c>projects/{project}</c>.
        /// </returns>
        public static string FormatProject(string projectId) =>
            s_project.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="WorkspaceName"/> with pattern
        /// <c>workspaces/{workspace}</c>.
        /// </summary>
        /// <param name="workspaceId">The <c>Workspace</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="WorkspaceName"/> with pattern <c>workspaces/{workspace}</c>.
        /// </returns>
        public static string FormatWorkspace(string workspaceId) =>
            s_workspace.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(workspaceId, nameof(workspaceId)));

        /// <summary>Parses the given resource name string into a new <see cref="WorkspaceName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}</c></description></item>
        /// <item><description><c>workspaces/{workspace}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="workspaceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="WorkspaceName"/> if successful.</returns>
        public static WorkspaceName Parse(string workspaceName) => Parse(workspaceName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="WorkspaceName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}</c></description></item>
        /// <item><description><c>workspaces/{workspace}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="workspaceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="WorkspaceName"/> if successful.</returns>
        public static WorkspaceName Parse(string workspaceName, bool allowUnparsed) =>
            TryParse(workspaceName, allowUnparsed, out WorkspaceName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="WorkspaceName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}</c></description></item>
        /// <item><description><c>workspaces/{workspace}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="workspaceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="WorkspaceName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string workspaceName, out WorkspaceName result) => TryParse(workspaceName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="WorkspaceName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}</c></description></item>
        /// <item><description><c>workspaces/{workspace}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="workspaceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="WorkspaceName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string workspaceName, bool allowUnparsed, out WorkspaceName result)
        {
            gax::GaxPreconditions.CheckNotNull(workspaceName, nameof(workspaceName));
            gax::TemplatedResourceName resourceName;
            if (s_project.TryParseName(workspaceName, out resourceName))
            {
                result = FromProject(resourceName[0]);
                return true;
            }
            if (s_workspace.TryParseName(workspaceName, out resourceName))
            {
                result = FromWorkspace(resourceName[0]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(workspaceName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private WorkspaceName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string projectId = null, string workspaceId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ProjectId = projectId;
            WorkspaceId = workspaceId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="WorkspaceName"/> class from the component parts of pattern
        /// <c>projects/{project}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        public WorkspaceName(string projectId) : this(ResourceNameType.Project, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)))
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
        /// The <c>Project</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Workspace</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string WorkspaceId { get; }

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
                case ResourceNameType.Workspace: return s_workspace.Expand(WorkspaceId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as WorkspaceName);

        /// <inheritdoc/>
        public bool Equals(WorkspaceName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(WorkspaceName a, WorkspaceName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(WorkspaceName a, WorkspaceName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>TimeSeries</c> resource.</summary>
    public sealed partial class TimeSeriesName : gax::IResourceName, sys::IEquatable<TimeSeriesName>
    {
        /// <summary>The possible contents of <see cref="TimeSeriesName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>projects/{project}/timeSeries/{time_series}</c>.</summary>
            ProjectTimeSeries = 1,

            /// <summary>
            /// A resource name with pattern <c>organizations/{organization}/timeSeries/{time_series}</c>.
            /// </summary>
            OrganizationTimeSeries = 2,

            /// <summary>A resource name with pattern <c>folders/{folder}/timeSeries/{time_series}</c>.</summary>
            FolderTimeSeries = 3,
        }

        private static gax::PathTemplate s_projectTimeSeries = new gax::PathTemplate("projects/{project}/timeSeries/{time_series}");

        private static gax::PathTemplate s_organizationTimeSeries = new gax::PathTemplate("organizations/{organization}/timeSeries/{time_series}");

        private static gax::PathTemplate s_folderTimeSeries = new gax::PathTemplate("folders/{folder}/timeSeries/{time_series}");

        /// <summary>Creates a <see cref="TimeSeriesName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="TimeSeriesName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static TimeSeriesName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new TimeSeriesName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="TimeSeriesName"/> with the pattern <c>projects/{project}/timeSeries/{time_series}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="timeSeriesId">The <c>TimeSeries</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="TimeSeriesName"/> constructed from the provided ids.</returns>
        public static TimeSeriesName FromProjectTimeSeries(string projectId, string timeSeriesId) =>
            new TimeSeriesName(ResourceNameType.ProjectTimeSeries, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), timeSeriesId: gax::GaxPreconditions.CheckNotNullOrEmpty(timeSeriesId, nameof(timeSeriesId)));

        /// <summary>
        /// Creates a <see cref="TimeSeriesName"/> with the pattern
        /// <c>organizations/{organization}/timeSeries/{time_series}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="timeSeriesId">The <c>TimeSeries</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="TimeSeriesName"/> constructed from the provided ids.</returns>
        public static TimeSeriesName FromOrganizationTimeSeries(string organizationId, string timeSeriesId) =>
            new TimeSeriesName(ResourceNameType.OrganizationTimeSeries, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), timeSeriesId: gax::GaxPreconditions.CheckNotNullOrEmpty(timeSeriesId, nameof(timeSeriesId)));

        /// <summary>
        /// Creates a <see cref="TimeSeriesName"/> with the pattern <c>folders/{folder}/timeSeries/{time_series}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="timeSeriesId">The <c>TimeSeries</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="TimeSeriesName"/> constructed from the provided ids.</returns>
        public static TimeSeriesName FromFolderTimeSeries(string folderId, string timeSeriesId) =>
            new TimeSeriesName(ResourceNameType.FolderTimeSeries, folderId: gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), timeSeriesId: gax::GaxPreconditions.CheckNotNullOrEmpty(timeSeriesId, nameof(timeSeriesId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TimeSeriesName"/> with pattern
        /// <c>projects/{project}/timeSeries/{time_series}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="timeSeriesId">The <c>TimeSeries</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="TimeSeriesName"/> with pattern
        /// <c>projects/{project}/timeSeries/{time_series}</c>.
        /// </returns>
        public static string Format(string projectId, string timeSeriesId) => FormatProjectTimeSeries(projectId, timeSeriesId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TimeSeriesName"/> with pattern
        /// <c>projects/{project}/timeSeries/{time_series}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="timeSeriesId">The <c>TimeSeries</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="TimeSeriesName"/> with pattern
        /// <c>projects/{project}/timeSeries/{time_series}</c>.
        /// </returns>
        public static string FormatProjectTimeSeries(string projectId, string timeSeriesId) =>
            s_projectTimeSeries.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(timeSeriesId, nameof(timeSeriesId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TimeSeriesName"/> with pattern
        /// <c>organizations/{organization}/timeSeries/{time_series}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="timeSeriesId">The <c>TimeSeries</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="TimeSeriesName"/> with pattern
        /// <c>organizations/{organization}/timeSeries/{time_series}</c>.
        /// </returns>
        public static string FormatOrganizationTimeSeries(string organizationId, string timeSeriesId) =>
            s_organizationTimeSeries.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(timeSeriesId, nameof(timeSeriesId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TimeSeriesName"/> with pattern
        /// <c>folders/{folder}/timeSeries/{time_series}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="timeSeriesId">The <c>TimeSeries</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="TimeSeriesName"/> with pattern
        /// <c>folders/{folder}/timeSeries/{time_series}</c>.
        /// </returns>
        public static string FormatFolderTimeSeries(string folderId, string timeSeriesId) =>
            s_folderTimeSeries.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), gax::GaxPreconditions.CheckNotNullOrEmpty(timeSeriesId, nameof(timeSeriesId)));

        /// <summary>Parses the given resource name string into a new <see cref="TimeSeriesName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/timeSeries/{time_series}</c></description></item>
        /// <item><description><c>organizations/{organization}/timeSeries/{time_series}</c></description></item>
        /// <item><description><c>folders/{folder}/timeSeries/{time_series}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="timeSeriesName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="TimeSeriesName"/> if successful.</returns>
        public static TimeSeriesName Parse(string timeSeriesName) => Parse(timeSeriesName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="TimeSeriesName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/timeSeries/{time_series}</c></description></item>
        /// <item><description><c>organizations/{organization}/timeSeries/{time_series}</c></description></item>
        /// <item><description><c>folders/{folder}/timeSeries/{time_series}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="timeSeriesName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="TimeSeriesName"/> if successful.</returns>
        public static TimeSeriesName Parse(string timeSeriesName, bool allowUnparsed) =>
            TryParse(timeSeriesName, allowUnparsed, out TimeSeriesName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="TimeSeriesName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/timeSeries/{time_series}</c></description></item>
        /// <item><description><c>organizations/{organization}/timeSeries/{time_series}</c></description></item>
        /// <item><description><c>folders/{folder}/timeSeries/{time_series}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="timeSeriesName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="TimeSeriesName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string timeSeriesName, out TimeSeriesName result) =>
            TryParse(timeSeriesName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="TimeSeriesName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/timeSeries/{time_series}</c></description></item>
        /// <item><description><c>organizations/{organization}/timeSeries/{time_series}</c></description></item>
        /// <item><description><c>folders/{folder}/timeSeries/{time_series}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="timeSeriesName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="TimeSeriesName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string timeSeriesName, bool allowUnparsed, out TimeSeriesName result)
        {
            gax::GaxPreconditions.CheckNotNull(timeSeriesName, nameof(timeSeriesName));
            gax::TemplatedResourceName resourceName;
            if (s_projectTimeSeries.TryParseName(timeSeriesName, out resourceName))
            {
                result = FromProjectTimeSeries(resourceName[0], resourceName[1]);
                return true;
            }
            if (s_organizationTimeSeries.TryParseName(timeSeriesName, out resourceName))
            {
                result = FromOrganizationTimeSeries(resourceName[0], resourceName[1]);
                return true;
            }
            if (s_folderTimeSeries.TryParseName(timeSeriesName, out resourceName))
            {
                result = FromFolderTimeSeries(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(timeSeriesName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private TimeSeriesName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string folderId = null, string organizationId = null, string projectId = null, string timeSeriesId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            FolderId = folderId;
            OrganizationId = organizationId;
            ProjectId = projectId;
            TimeSeriesId = timeSeriesId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="TimeSeriesName"/> class from the component parts of pattern
        /// <c>projects/{project}/timeSeries/{time_series}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="timeSeriesId">The <c>TimeSeries</c> ID. Must not be <c>null</c> or empty.</param>
        public TimeSeriesName(string projectId, string timeSeriesId) : this(ResourceNameType.ProjectTimeSeries, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), timeSeriesId: gax::GaxPreconditions.CheckNotNullOrEmpty(timeSeriesId, nameof(timeSeriesId)))
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

        /// <summary>
        /// The <c>TimeSeries</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string TimeSeriesId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectTimeSeries: return s_projectTimeSeries.Expand(ProjectId, TimeSeriesId);
                case ResourceNameType.OrganizationTimeSeries: return s_organizationTimeSeries.Expand(OrganizationId, TimeSeriesId);
                case ResourceNameType.FolderTimeSeries: return s_folderTimeSeries.Expand(FolderId, TimeSeriesId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as TimeSeriesName);

        /// <inheritdoc/>
        public bool Equals(TimeSeriesName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(TimeSeriesName a, TimeSeriesName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(TimeSeriesName a, TimeSeriesName b) => !(a == b);
    }

    public partial class ListMonitoredResourceDescriptorsRequest
    {
        /// <summary>
        /// <see cref="gagr::ProjectName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gagr::ProjectName ProjectName
        {
            get => string.IsNullOrEmpty(Name) ? null : gagr::ProjectName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagr::OrganizationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gagr::OrganizationName OrganizationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gagr::OrganizationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagr::FolderName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gagr::FolderName FolderName
        {
            get => string.IsNullOrEmpty(Name) ? null : gagr::FolderName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gax::IResourceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gax::IResourceName ResourceName
        {
            get
            {
                if (string.IsNullOrEmpty(Name))
                {
                    return null;
                }
                if (gagr::ProjectName.TryParse(Name, out gagr::ProjectName project))
                {
                    return project;
                }
                if (gagr::OrganizationName.TryParse(Name, out gagr::OrganizationName organization))
                {
                    return organization;
                }
                if (gagr::FolderName.TryParse(Name, out gagr::FolderName folder))
                {
                    return folder;
                }
                return gax::UnparsedResourceName.Parse(Name);
            }
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetMonitoredResourceDescriptorRequest
    {
        /// <summary>
        /// <see cref="gcmv::MonitoredResourceDescriptorName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gcmv::MonitoredResourceDescriptorName MonitoredResourceDescriptorName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcmv::MonitoredResourceDescriptorName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gax::IResourceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gax::IResourceName ResourceName
        {
            get
            {
                if (string.IsNullOrEmpty(Name))
                {
                    return null;
                }
                if (gcmv::MonitoredResourceDescriptorName.TryParse(Name, out gcmv::MonitoredResourceDescriptorName monitoredResourceDescriptor))
                {
                    return monitoredResourceDescriptor;
                }
                return gax::UnparsedResourceName.Parse(Name);
            }
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListMetricDescriptorsRequest
    {
        /// <summary>
        /// <see cref="gagr::ProjectName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gagr::ProjectName ProjectName
        {
            get => string.IsNullOrEmpty(Name) ? null : gagr::ProjectName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagr::OrganizationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gagr::OrganizationName OrganizationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gagr::OrganizationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagr::FolderName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gagr::FolderName FolderName
        {
            get => string.IsNullOrEmpty(Name) ? null : gagr::FolderName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gax::IResourceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gax::IResourceName ResourceName
        {
            get
            {
                if (string.IsNullOrEmpty(Name))
                {
                    return null;
                }
                if (gagr::ProjectName.TryParse(Name, out gagr::ProjectName project))
                {
                    return project;
                }
                if (gagr::OrganizationName.TryParse(Name, out gagr::OrganizationName organization))
                {
                    return organization;
                }
                if (gagr::FolderName.TryParse(Name, out gagr::FolderName folder))
                {
                    return folder;
                }
                return gax::UnparsedResourceName.Parse(Name);
            }
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetMetricDescriptorRequest
    {
        /// <summary>
        /// <see cref="gcmv::MetricDescriptorName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcmv::MetricDescriptorName MetricDescriptorName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcmv::MetricDescriptorName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gax::IResourceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gax::IResourceName ResourceName
        {
            get
            {
                if (string.IsNullOrEmpty(Name))
                {
                    return null;
                }
                if (gcmv::MetricDescriptorName.TryParse(Name, out gcmv::MetricDescriptorName metricDescriptor))
                {
                    return metricDescriptor;
                }
                return gax::UnparsedResourceName.Parse(Name);
            }
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateMetricDescriptorRequest
    {
        /// <summary>
        /// <see cref="gagr::ProjectName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gagr::ProjectName ProjectName
        {
            get => string.IsNullOrEmpty(Name) ? null : gagr::ProjectName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagr::OrganizationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gagr::OrganizationName OrganizationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gagr::OrganizationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagr::FolderName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gagr::FolderName FolderName
        {
            get => string.IsNullOrEmpty(Name) ? null : gagr::FolderName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gax::IResourceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gax::IResourceName ResourceName
        {
            get
            {
                if (string.IsNullOrEmpty(Name))
                {
                    return null;
                }
                if (gagr::ProjectName.TryParse(Name, out gagr::ProjectName project))
                {
                    return project;
                }
                if (gagr::OrganizationName.TryParse(Name, out gagr::OrganizationName organization))
                {
                    return organization;
                }
                if (gagr::FolderName.TryParse(Name, out gagr::FolderName folder))
                {
                    return folder;
                }
                return gax::UnparsedResourceName.Parse(Name);
            }
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteMetricDescriptorRequest
    {
        /// <summary>
        /// <see cref="gcmv::MetricDescriptorName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcmv::MetricDescriptorName MetricDescriptorName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcmv::MetricDescriptorName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gax::IResourceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gax::IResourceName ResourceName
        {
            get
            {
                if (string.IsNullOrEmpty(Name))
                {
                    return null;
                }
                if (gcmv::MetricDescriptorName.TryParse(Name, out gcmv::MetricDescriptorName metricDescriptor))
                {
                    return metricDescriptor;
                }
                return gax::UnparsedResourceName.Parse(Name);
            }
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListTimeSeriesRequest
    {
        /// <summary>
        /// <see cref="gagr::ProjectName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gagr::ProjectName ProjectName
        {
            get => string.IsNullOrEmpty(Name) ? null : gagr::ProjectName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagr::OrganizationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gagr::OrganizationName OrganizationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gagr::OrganizationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagr::FolderName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gagr::FolderName FolderName
        {
            get => string.IsNullOrEmpty(Name) ? null : gagr::FolderName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gax::IResourceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gax::IResourceName ResourceName
        {
            get
            {
                if (string.IsNullOrEmpty(Name))
                {
                    return null;
                }
                if (gagr::ProjectName.TryParse(Name, out gagr::ProjectName project))
                {
                    return project;
                }
                if (gagr::OrganizationName.TryParse(Name, out gagr::OrganizationName organization))
                {
                    return organization;
                }
                if (gagr::FolderName.TryParse(Name, out gagr::FolderName folder))
                {
                    return folder;
                }
                return gax::UnparsedResourceName.Parse(Name);
            }
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateTimeSeriesRequest
    {
        /// <summary>
        /// <see cref="gagr::ProjectName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gagr::ProjectName ProjectName
        {
            get => string.IsNullOrEmpty(Name) ? null : gagr::ProjectName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
