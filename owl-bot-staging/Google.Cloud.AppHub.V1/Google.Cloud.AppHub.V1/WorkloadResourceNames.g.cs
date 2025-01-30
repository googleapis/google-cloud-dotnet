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
using gcav = Google.Cloud.AppHub.V1;
using sys = System;

namespace Google.Cloud.AppHub.V1
{
    /// <summary>Resource name for the <c>Workload</c> resource.</summary>
    public sealed partial class WorkloadName : gax::IResourceName, sys::IEquatable<WorkloadName>
    {
        /// <summary>The possible contents of <see cref="WorkloadName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/applications/{application}/workloads/{workload}</c>.
            /// </summary>
            ProjectLocationApplicationWorkload = 1,
        }

        private static gax::PathTemplate s_projectLocationApplicationWorkload = new gax::PathTemplate("projects/{project}/locations/{location}/applications/{application}/workloads/{workload}");

        /// <summary>Creates a <see cref="WorkloadName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="WorkloadName"/> containing the provided <paramref name="unparsedResourceName"/>
        /// .
        /// </returns>
        public static WorkloadName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new WorkloadName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="WorkloadName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/applications/{application}/workloads/{workload}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="applicationId">The <c>Application</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="workloadId">The <c>Workload</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="WorkloadName"/> constructed from the provided ids.</returns>
        public static WorkloadName FromProjectLocationApplicationWorkload(string projectId, string locationId, string applicationId, string workloadId) =>
            new WorkloadName(ResourceNameType.ProjectLocationApplicationWorkload, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), applicationId: gax::GaxPreconditions.CheckNotNullOrEmpty(applicationId, nameof(applicationId)), workloadId: gax::GaxPreconditions.CheckNotNullOrEmpty(workloadId, nameof(workloadId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="WorkloadName"/> with pattern
        /// <c>projects/{project}/locations/{location}/applications/{application}/workloads/{workload}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="applicationId">The <c>Application</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="workloadId">The <c>Workload</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="WorkloadName"/> with pattern
        /// <c>projects/{project}/locations/{location}/applications/{application}/workloads/{workload}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string applicationId, string workloadId) =>
            FormatProjectLocationApplicationWorkload(projectId, locationId, applicationId, workloadId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="WorkloadName"/> with pattern
        /// <c>projects/{project}/locations/{location}/applications/{application}/workloads/{workload}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="applicationId">The <c>Application</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="workloadId">The <c>Workload</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="WorkloadName"/> with pattern
        /// <c>projects/{project}/locations/{location}/applications/{application}/workloads/{workload}</c>.
        /// </returns>
        public static string FormatProjectLocationApplicationWorkload(string projectId, string locationId, string applicationId, string workloadId) =>
            s_projectLocationApplicationWorkload.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(applicationId, nameof(applicationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(workloadId, nameof(workloadId)));

        /// <summary>Parses the given resource name string into a new <see cref="WorkloadName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/applications/{application}/workloads/{workload}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="workloadName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="WorkloadName"/> if successful.</returns>
        public static WorkloadName Parse(string workloadName) => Parse(workloadName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="WorkloadName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/applications/{application}/workloads/{workload}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="workloadName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="WorkloadName"/> if successful.</returns>
        public static WorkloadName Parse(string workloadName, bool allowUnparsed) =>
            TryParse(workloadName, allowUnparsed, out WorkloadName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="WorkloadName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/applications/{application}/workloads/{workload}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="workloadName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="WorkloadName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string workloadName, out WorkloadName result) => TryParse(workloadName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="WorkloadName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/applications/{application}/workloads/{workload}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="workloadName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="WorkloadName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string workloadName, bool allowUnparsed, out WorkloadName result)
        {
            gax::GaxPreconditions.CheckNotNull(workloadName, nameof(workloadName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationApplicationWorkload.TryParseName(workloadName, out resourceName))
            {
                result = FromProjectLocationApplicationWorkload(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(workloadName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private WorkloadName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string applicationId = null, string locationId = null, string projectId = null, string workloadId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ApplicationId = applicationId;
            LocationId = locationId;
            ProjectId = projectId;
            WorkloadId = workloadId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="WorkloadName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/applications/{application}/workloads/{workload}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="applicationId">The <c>Application</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="workloadId">The <c>Workload</c> ID. Must not be <c>null</c> or empty.</param>
        public WorkloadName(string projectId, string locationId, string applicationId, string workloadId) : this(ResourceNameType.ProjectLocationApplicationWorkload, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), applicationId: gax::GaxPreconditions.CheckNotNullOrEmpty(applicationId, nameof(applicationId)), workloadId: gax::GaxPreconditions.CheckNotNullOrEmpty(workloadId, nameof(workloadId)))
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
        /// The <c>Application</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ApplicationId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Workload</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string WorkloadId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationApplicationWorkload: return s_projectLocationApplicationWorkload.Expand(ProjectId, LocationId, ApplicationId, WorkloadId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as WorkloadName);

        /// <inheritdoc/>
        public bool Equals(WorkloadName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(WorkloadName a, WorkloadName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(WorkloadName a, WorkloadName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>DiscoveredWorkload</c> resource.</summary>
    public sealed partial class DiscoveredWorkloadName : gax::IResourceName, sys::IEquatable<DiscoveredWorkloadName>
    {
        /// <summary>The possible contents of <see cref="DiscoveredWorkloadName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/discoveredWorkloads/{discovered_workload}</c>.
            /// </summary>
            ProjectLocationDiscoveredWorkload = 1,
        }

        private static gax::PathTemplate s_projectLocationDiscoveredWorkload = new gax::PathTemplate("projects/{project}/locations/{location}/discoveredWorkloads/{discovered_workload}");

        /// <summary>Creates a <see cref="DiscoveredWorkloadName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="DiscoveredWorkloadName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static DiscoveredWorkloadName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new DiscoveredWorkloadName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="DiscoveredWorkloadName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/discoveredWorkloads/{discovered_workload}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="discoveredWorkloadId">
        /// The <c>DiscoveredWorkload</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>A new instance of <see cref="DiscoveredWorkloadName"/> constructed from the provided ids.</returns>
        public static DiscoveredWorkloadName FromProjectLocationDiscoveredWorkload(string projectId, string locationId, string discoveredWorkloadId) =>
            new DiscoveredWorkloadName(ResourceNameType.ProjectLocationDiscoveredWorkload, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), discoveredWorkloadId: gax::GaxPreconditions.CheckNotNullOrEmpty(discoveredWorkloadId, nameof(discoveredWorkloadId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DiscoveredWorkloadName"/> with pattern
        /// <c>projects/{project}/locations/{location}/discoveredWorkloads/{discovered_workload}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="discoveredWorkloadId">
        /// The <c>DiscoveredWorkload</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="DiscoveredWorkloadName"/> with pattern
        /// <c>projects/{project}/locations/{location}/discoveredWorkloads/{discovered_workload}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string discoveredWorkloadId) =>
            FormatProjectLocationDiscoveredWorkload(projectId, locationId, discoveredWorkloadId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DiscoveredWorkloadName"/> with pattern
        /// <c>projects/{project}/locations/{location}/discoveredWorkloads/{discovered_workload}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="discoveredWorkloadId">
        /// The <c>DiscoveredWorkload</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="DiscoveredWorkloadName"/> with pattern
        /// <c>projects/{project}/locations/{location}/discoveredWorkloads/{discovered_workload}</c>.
        /// </returns>
        public static string FormatProjectLocationDiscoveredWorkload(string projectId, string locationId, string discoveredWorkloadId) =>
            s_projectLocationDiscoveredWorkload.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(discoveredWorkloadId, nameof(discoveredWorkloadId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="DiscoveredWorkloadName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/discoveredWorkloads/{discovered_workload}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="discoveredWorkloadName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="DiscoveredWorkloadName"/> if successful.</returns>
        public static DiscoveredWorkloadName Parse(string discoveredWorkloadName) => Parse(discoveredWorkloadName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="DiscoveredWorkloadName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/discoveredWorkloads/{discovered_workload}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="discoveredWorkloadName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="DiscoveredWorkloadName"/> if successful.</returns>
        public static DiscoveredWorkloadName Parse(string discoveredWorkloadName, bool allowUnparsed) =>
            TryParse(discoveredWorkloadName, allowUnparsed, out DiscoveredWorkloadName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DiscoveredWorkloadName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/discoveredWorkloads/{discovered_workload}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="discoveredWorkloadName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DiscoveredWorkloadName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string discoveredWorkloadName, out DiscoveredWorkloadName result) =>
            TryParse(discoveredWorkloadName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DiscoveredWorkloadName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/discoveredWorkloads/{discovered_workload}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="discoveredWorkloadName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DiscoveredWorkloadName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string discoveredWorkloadName, bool allowUnparsed, out DiscoveredWorkloadName result)
        {
            gax::GaxPreconditions.CheckNotNull(discoveredWorkloadName, nameof(discoveredWorkloadName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationDiscoveredWorkload.TryParseName(discoveredWorkloadName, out resourceName))
            {
                result = FromProjectLocationDiscoveredWorkload(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(discoveredWorkloadName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private DiscoveredWorkloadName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string discoveredWorkloadId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            DiscoveredWorkloadId = discoveredWorkloadId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="DiscoveredWorkloadName"/> class from the component parts of
        /// pattern <c>projects/{project}/locations/{location}/discoveredWorkloads/{discovered_workload}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="discoveredWorkloadId">
        /// The <c>DiscoveredWorkload</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public DiscoveredWorkloadName(string projectId, string locationId, string discoveredWorkloadId) : this(ResourceNameType.ProjectLocationDiscoveredWorkload, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), discoveredWorkloadId: gax::GaxPreconditions.CheckNotNullOrEmpty(discoveredWorkloadId, nameof(discoveredWorkloadId)))
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
        /// The <c>DiscoveredWorkload</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string DiscoveredWorkloadId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
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
                case ResourceNameType.ProjectLocationDiscoveredWorkload: return s_projectLocationDiscoveredWorkload.Expand(ProjectId, LocationId, DiscoveredWorkloadId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as DiscoveredWorkloadName);

        /// <inheritdoc/>
        public bool Equals(DiscoveredWorkloadName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(DiscoveredWorkloadName a, DiscoveredWorkloadName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(DiscoveredWorkloadName a, DiscoveredWorkloadName b) => !(a == b);
    }

    public partial class Workload
    {
        /// <summary>
        /// <see cref="gcav::WorkloadName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::WorkloadName WorkloadName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::WorkloadName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="DiscoveredWorkload"/> resource name
        /// property.
        /// </summary>
        public gagr::LocationName DiscoveredWorkloadAsLocationName
        {
            get => string.IsNullOrEmpty(DiscoveredWorkload) ? null : gagr::LocationName.Parse(DiscoveredWorkload, allowUnparsed: true);
            set => DiscoveredWorkload = value?.ToString() ?? "";
        }
    }

    public partial class DiscoveredWorkload
    {
        /// <summary>
        /// <see cref="gcav::DiscoveredWorkloadName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::DiscoveredWorkloadName DiscoveredWorkloadName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::DiscoveredWorkloadName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
