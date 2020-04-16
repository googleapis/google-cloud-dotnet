// Copyright 2020 Google LLC
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

using gax = Google.Api.Gax;
using gagr = Google.Api.Gax.ResourceNames;
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
            FolderMetricDescriptor = 3
        }

        private static gax::PathTemplate s_projectMetricDescriptor = new gax::PathTemplate("projects/{project}/metricDescriptors/{metric_descriptor}");

        private static gax::PathTemplate s_organizationMetricDescriptor = new gax::PathTemplate("organizations/{organization}/metricDescriptors/{metric_descriptor}");

        private static gax::PathTemplate s_folderMetricDescriptor = new gax::PathTemplate("folders/{folder}/metricDescriptors/{metric_descriptor}");

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

        /// <inheritdoc/>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <inheritdoc/>
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

        /// <inheritdoc/>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as MetricDescriptorName);

        /// <inheritdoc/>
        public bool Equals(MetricDescriptorName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(MetricDescriptorName a, MetricDescriptorName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
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
            FolderMonitoredResourceDescriptor = 3
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

        /// <inheritdoc/>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <inheritdoc/>
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

        /// <inheritdoc/>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as MonitoredResourceDescriptorName);

        /// <inheritdoc/>
        public bool Equals(MonitoredResourceDescriptorName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(MonitoredResourceDescriptorName a, MonitoredResourceDescriptorName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(MonitoredResourceDescriptorName a, MonitoredResourceDescriptorName b) => !(a == b);
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
