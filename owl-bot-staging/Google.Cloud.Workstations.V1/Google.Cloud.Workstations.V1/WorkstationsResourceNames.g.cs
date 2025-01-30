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
using gcwv = Google.Cloud.Workstations.V1;
using sys = System;

namespace Google.Cloud.Workstations.V1
{
    /// <summary>Resource name for the <c>WorkstationCluster</c> resource.</summary>
    public sealed partial class WorkstationClusterName : gax::IResourceName, sys::IEquatable<WorkstationClusterName>
    {
        /// <summary>The possible contents of <see cref="WorkstationClusterName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/workstationClusters/{workstation_cluster}</c>.
            /// </summary>
            ProjectLocationWorkstationCluster = 1,
        }

        private static gax::PathTemplate s_projectLocationWorkstationCluster = new gax::PathTemplate("projects/{project}/locations/{location}/workstationClusters/{workstation_cluster}");

        /// <summary>Creates a <see cref="WorkstationClusterName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="WorkstationClusterName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static WorkstationClusterName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new WorkstationClusterName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="WorkstationClusterName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/workstationClusters/{workstation_cluster}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="workstationClusterId">
        /// The <c>WorkstationCluster</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>A new instance of <see cref="WorkstationClusterName"/> constructed from the provided ids.</returns>
        public static WorkstationClusterName FromProjectLocationWorkstationCluster(string projectId, string locationId, string workstationClusterId) =>
            new WorkstationClusterName(ResourceNameType.ProjectLocationWorkstationCluster, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), workstationClusterId: gax::GaxPreconditions.CheckNotNullOrEmpty(workstationClusterId, nameof(workstationClusterId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="WorkstationClusterName"/> with pattern
        /// <c>projects/{project}/locations/{location}/workstationClusters/{workstation_cluster}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="workstationClusterId">
        /// The <c>WorkstationCluster</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="WorkstationClusterName"/> with pattern
        /// <c>projects/{project}/locations/{location}/workstationClusters/{workstation_cluster}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string workstationClusterId) =>
            FormatProjectLocationWorkstationCluster(projectId, locationId, workstationClusterId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="WorkstationClusterName"/> with pattern
        /// <c>projects/{project}/locations/{location}/workstationClusters/{workstation_cluster}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="workstationClusterId">
        /// The <c>WorkstationCluster</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="WorkstationClusterName"/> with pattern
        /// <c>projects/{project}/locations/{location}/workstationClusters/{workstation_cluster}</c>.
        /// </returns>
        public static string FormatProjectLocationWorkstationCluster(string projectId, string locationId, string workstationClusterId) =>
            s_projectLocationWorkstationCluster.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(workstationClusterId, nameof(workstationClusterId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="WorkstationClusterName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/workstationClusters/{workstation_cluster}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="workstationClusterName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="WorkstationClusterName"/> if successful.</returns>
        public static WorkstationClusterName Parse(string workstationClusterName) => Parse(workstationClusterName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="WorkstationClusterName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/workstationClusters/{workstation_cluster}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="workstationClusterName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="WorkstationClusterName"/> if successful.</returns>
        public static WorkstationClusterName Parse(string workstationClusterName, bool allowUnparsed) =>
            TryParse(workstationClusterName, allowUnparsed, out WorkstationClusterName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="WorkstationClusterName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/workstationClusters/{workstation_cluster}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="workstationClusterName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="WorkstationClusterName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string workstationClusterName, out WorkstationClusterName result) =>
            TryParse(workstationClusterName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="WorkstationClusterName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/workstationClusters/{workstation_cluster}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="workstationClusterName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="WorkstationClusterName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string workstationClusterName, bool allowUnparsed, out WorkstationClusterName result)
        {
            gax::GaxPreconditions.CheckNotNull(workstationClusterName, nameof(workstationClusterName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationWorkstationCluster.TryParseName(workstationClusterName, out resourceName))
            {
                result = FromProjectLocationWorkstationCluster(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(workstationClusterName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private WorkstationClusterName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string workstationClusterId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            WorkstationClusterId = workstationClusterId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="WorkstationClusterName"/> class from the component parts of
        /// pattern <c>projects/{project}/locations/{location}/workstationClusters/{workstation_cluster}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="workstationClusterId">
        /// The <c>WorkstationCluster</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public WorkstationClusterName(string projectId, string locationId, string workstationClusterId) : this(ResourceNameType.ProjectLocationWorkstationCluster, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), workstationClusterId: gax::GaxPreconditions.CheckNotNullOrEmpty(workstationClusterId, nameof(workstationClusterId)))
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
        /// The <c>WorkstationCluster</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string WorkstationClusterId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationWorkstationCluster: return s_projectLocationWorkstationCluster.Expand(ProjectId, LocationId, WorkstationClusterId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as WorkstationClusterName);

        /// <inheritdoc/>
        public bool Equals(WorkstationClusterName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(WorkstationClusterName a, WorkstationClusterName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(WorkstationClusterName a, WorkstationClusterName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>WorkstationConfig</c> resource.</summary>
    public sealed partial class WorkstationConfigName : gax::IResourceName, sys::IEquatable<WorkstationConfigName>
    {
        /// <summary>The possible contents of <see cref="WorkstationConfigName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// projects/{project}/locations/{location}/workstationClusters/{workstation_cluster}/workstationConfigs/{workstation_config}</c>
            /// .
            /// </summary>
            ProjectLocationWorkstationClusterWorkstationConfig = 1,
        }

        private static gax::PathTemplate s_projectLocationWorkstationClusterWorkstationConfig = new gax::PathTemplate("projects/{project}/locations/{location}/workstationClusters/{workstation_cluster}/workstationConfigs/{workstation_config}");

        /// <summary>Creates a <see cref="WorkstationConfigName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="WorkstationConfigName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static WorkstationConfigName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new WorkstationConfigName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="WorkstationConfigName"/> with the pattern
        /// <c>
        /// projects/{project}/locations/{location}/workstationClusters/{workstation_cluster}/workstationConfigs/{workstation_config}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="workstationClusterId">
        /// The <c>WorkstationCluster</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="workstationConfigId">The <c>WorkstationConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="WorkstationConfigName"/> constructed from the provided ids.</returns>
        public static WorkstationConfigName FromProjectLocationWorkstationClusterWorkstationConfig(string projectId, string locationId, string workstationClusterId, string workstationConfigId) =>
            new WorkstationConfigName(ResourceNameType.ProjectLocationWorkstationClusterWorkstationConfig, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), workstationClusterId: gax::GaxPreconditions.CheckNotNullOrEmpty(workstationClusterId, nameof(workstationClusterId)), workstationConfigId: gax::GaxPreconditions.CheckNotNullOrEmpty(workstationConfigId, nameof(workstationConfigId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="WorkstationConfigName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/workstationClusters/{workstation_cluster}/workstationConfigs/{workstation_config}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="workstationClusterId">
        /// The <c>WorkstationCluster</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="workstationConfigId">The <c>WorkstationConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="WorkstationConfigName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/workstationClusters/{workstation_cluster}/workstationConfigs/{workstation_config}</c>
        /// .
        /// </returns>
        public static string Format(string projectId, string locationId, string workstationClusterId, string workstationConfigId) =>
            FormatProjectLocationWorkstationClusterWorkstationConfig(projectId, locationId, workstationClusterId, workstationConfigId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="WorkstationConfigName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/workstationClusters/{workstation_cluster}/workstationConfigs/{workstation_config}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="workstationClusterId">
        /// The <c>WorkstationCluster</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="workstationConfigId">The <c>WorkstationConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="WorkstationConfigName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/workstationClusters/{workstation_cluster}/workstationConfigs/{workstation_config}</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationWorkstationClusterWorkstationConfig(string projectId, string locationId, string workstationClusterId, string workstationConfigId) =>
            s_projectLocationWorkstationClusterWorkstationConfig.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(workstationClusterId, nameof(workstationClusterId)), gax::GaxPreconditions.CheckNotNullOrEmpty(workstationConfigId, nameof(workstationConfigId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="WorkstationConfigName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/workstationClusters/{workstation_cluster}/workstationConfigs/{workstation_config}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="workstationConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="WorkstationConfigName"/> if successful.</returns>
        public static WorkstationConfigName Parse(string workstationConfigName) => Parse(workstationConfigName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="WorkstationConfigName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/workstationClusters/{workstation_cluster}/workstationConfigs/{workstation_config}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="workstationConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="WorkstationConfigName"/> if successful.</returns>
        public static WorkstationConfigName Parse(string workstationConfigName, bool allowUnparsed) =>
            TryParse(workstationConfigName, allowUnparsed, out WorkstationConfigName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="WorkstationConfigName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/workstationClusters/{workstation_cluster}/workstationConfigs/{workstation_config}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="workstationConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="WorkstationConfigName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string workstationConfigName, out WorkstationConfigName result) =>
            TryParse(workstationConfigName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="WorkstationConfigName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/workstationClusters/{workstation_cluster}/workstationConfigs/{workstation_config}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="workstationConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="WorkstationConfigName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string workstationConfigName, bool allowUnparsed, out WorkstationConfigName result)
        {
            gax::GaxPreconditions.CheckNotNull(workstationConfigName, nameof(workstationConfigName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationWorkstationClusterWorkstationConfig.TryParseName(workstationConfigName, out resourceName))
            {
                result = FromProjectLocationWorkstationClusterWorkstationConfig(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(workstationConfigName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private WorkstationConfigName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string workstationClusterId = null, string workstationConfigId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            WorkstationClusterId = workstationClusterId;
            WorkstationConfigId = workstationConfigId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="WorkstationConfigName"/> class from the component parts of pattern
        /// 
        /// <c>
        /// projects/{project}/locations/{location}/workstationClusters/{workstation_cluster}/workstationConfigs/{workstation_config}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="workstationClusterId">
        /// The <c>WorkstationCluster</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="workstationConfigId">The <c>WorkstationConfig</c> ID. Must not be <c>null</c> or empty.</param>
        public WorkstationConfigName(string projectId, string locationId, string workstationClusterId, string workstationConfigId) : this(ResourceNameType.ProjectLocationWorkstationClusterWorkstationConfig, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), workstationClusterId: gax::GaxPreconditions.CheckNotNullOrEmpty(workstationClusterId, nameof(workstationClusterId)), workstationConfigId: gax::GaxPreconditions.CheckNotNullOrEmpty(workstationConfigId, nameof(workstationConfigId)))
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
        /// The <c>WorkstationCluster</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string WorkstationClusterId { get; }

        /// <summary>
        /// The <c>WorkstationConfig</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string WorkstationConfigId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationWorkstationClusterWorkstationConfig: return s_projectLocationWorkstationClusterWorkstationConfig.Expand(ProjectId, LocationId, WorkstationClusterId, WorkstationConfigId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as WorkstationConfigName);

        /// <inheritdoc/>
        public bool Equals(WorkstationConfigName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(WorkstationConfigName a, WorkstationConfigName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(WorkstationConfigName a, WorkstationConfigName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Workstation</c> resource.</summary>
    public sealed partial class WorkstationName : gax::IResourceName, sys::IEquatable<WorkstationName>
    {
        /// <summary>The possible contents of <see cref="WorkstationName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// projects/{project}/locations/{location}/workstationClusters/{workstation_cluster}/workstationConfigs/{workstation_config}/workstations/{workstation}</c>
            /// .
            /// </summary>
            ProjectLocationWorkstationClusterWorkstationConfigWorkstation = 1,
        }

        private static gax::PathTemplate s_projectLocationWorkstationClusterWorkstationConfigWorkstation = new gax::PathTemplate("projects/{project}/locations/{location}/workstationClusters/{workstation_cluster}/workstationConfigs/{workstation_config}/workstations/{workstation}");

        /// <summary>Creates a <see cref="WorkstationName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="WorkstationName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static WorkstationName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new WorkstationName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="WorkstationName"/> with the pattern
        /// <c>
        /// projects/{project}/locations/{location}/workstationClusters/{workstation_cluster}/workstationConfigs/{workstation_config}/workstations/{workstation}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="workstationClusterId">
        /// The <c>WorkstationCluster</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="workstationConfigId">The <c>WorkstationConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="workstationId">The <c>Workstation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="WorkstationName"/> constructed from the provided ids.</returns>
        public static WorkstationName FromProjectLocationWorkstationClusterWorkstationConfigWorkstation(string projectId, string locationId, string workstationClusterId, string workstationConfigId, string workstationId) =>
            new WorkstationName(ResourceNameType.ProjectLocationWorkstationClusterWorkstationConfigWorkstation, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), workstationClusterId: gax::GaxPreconditions.CheckNotNullOrEmpty(workstationClusterId, nameof(workstationClusterId)), workstationConfigId: gax::GaxPreconditions.CheckNotNullOrEmpty(workstationConfigId, nameof(workstationConfigId)), workstationId: gax::GaxPreconditions.CheckNotNullOrEmpty(workstationId, nameof(workstationId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="WorkstationName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/workstationClusters/{workstation_cluster}/workstationConfigs/{workstation_config}/workstations/{workstation}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="workstationClusterId">
        /// The <c>WorkstationCluster</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="workstationConfigId">The <c>WorkstationConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="workstationId">The <c>Workstation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="WorkstationName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/workstationClusters/{workstation_cluster}/workstationConfigs/{workstation_config}/workstations/{workstation}</c>
        /// .
        /// </returns>
        public static string Format(string projectId, string locationId, string workstationClusterId, string workstationConfigId, string workstationId) =>
            FormatProjectLocationWorkstationClusterWorkstationConfigWorkstation(projectId, locationId, workstationClusterId, workstationConfigId, workstationId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="WorkstationName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/workstationClusters/{workstation_cluster}/workstationConfigs/{workstation_config}/workstations/{workstation}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="workstationClusterId">
        /// The <c>WorkstationCluster</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="workstationConfigId">The <c>WorkstationConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="workstationId">The <c>Workstation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="WorkstationName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/workstationClusters/{workstation_cluster}/workstationConfigs/{workstation_config}/workstations/{workstation}</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationWorkstationClusterWorkstationConfigWorkstation(string projectId, string locationId, string workstationClusterId, string workstationConfigId, string workstationId) =>
            s_projectLocationWorkstationClusterWorkstationConfigWorkstation.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(workstationClusterId, nameof(workstationClusterId)), gax::GaxPreconditions.CheckNotNullOrEmpty(workstationConfigId, nameof(workstationConfigId)), gax::GaxPreconditions.CheckNotNullOrEmpty(workstationId, nameof(workstationId)));

        /// <summary>Parses the given resource name string into a new <see cref="WorkstationName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/workstationClusters/{workstation_cluster}/workstationConfigs/{workstation_config}/workstations/{workstation}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="workstationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="WorkstationName"/> if successful.</returns>
        public static WorkstationName Parse(string workstationName) => Parse(workstationName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="WorkstationName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/workstationClusters/{workstation_cluster}/workstationConfigs/{workstation_config}/workstations/{workstation}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="workstationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="WorkstationName"/> if successful.</returns>
        public static WorkstationName Parse(string workstationName, bool allowUnparsed) =>
            TryParse(workstationName, allowUnparsed, out WorkstationName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="WorkstationName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/workstationClusters/{workstation_cluster}/workstationConfigs/{workstation_config}/workstations/{workstation}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="workstationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="WorkstationName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string workstationName, out WorkstationName result) =>
            TryParse(workstationName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="WorkstationName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/workstationClusters/{workstation_cluster}/workstationConfigs/{workstation_config}/workstations/{workstation}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="workstationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="WorkstationName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string workstationName, bool allowUnparsed, out WorkstationName result)
        {
            gax::GaxPreconditions.CheckNotNull(workstationName, nameof(workstationName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationWorkstationClusterWorkstationConfigWorkstation.TryParseName(workstationName, out resourceName))
            {
                result = FromProjectLocationWorkstationClusterWorkstationConfigWorkstation(resourceName[0], resourceName[1], resourceName[2], resourceName[3], resourceName[4]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(workstationName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private WorkstationName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string workstationId = null, string workstationClusterId = null, string workstationConfigId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            WorkstationId = workstationId;
            WorkstationClusterId = workstationClusterId;
            WorkstationConfigId = workstationConfigId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="WorkstationName"/> class from the component parts of pattern
        /// <c>
        /// projects/{project}/locations/{location}/workstationClusters/{workstation_cluster}/workstationConfigs/{workstation_config}/workstations/{workstation}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="workstationClusterId">
        /// The <c>WorkstationCluster</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="workstationConfigId">The <c>WorkstationConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="workstationId">The <c>Workstation</c> ID. Must not be <c>null</c> or empty.</param>
        public WorkstationName(string projectId, string locationId, string workstationClusterId, string workstationConfigId, string workstationId) : this(ResourceNameType.ProjectLocationWorkstationClusterWorkstationConfigWorkstation, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), workstationClusterId: gax::GaxPreconditions.CheckNotNullOrEmpty(workstationClusterId, nameof(workstationClusterId)), workstationConfigId: gax::GaxPreconditions.CheckNotNullOrEmpty(workstationConfigId, nameof(workstationConfigId)), workstationId: gax::GaxPreconditions.CheckNotNullOrEmpty(workstationId, nameof(workstationId)))
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
        /// The <c>Workstation</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string WorkstationId { get; }

        /// <summary>
        /// The <c>WorkstationCluster</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string WorkstationClusterId { get; }

        /// <summary>
        /// The <c>WorkstationConfig</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string WorkstationConfigId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationWorkstationClusterWorkstationConfigWorkstation: return s_projectLocationWorkstationClusterWorkstationConfigWorkstation.Expand(ProjectId, LocationId, WorkstationClusterId, WorkstationConfigId, WorkstationId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as WorkstationName);

        /// <inheritdoc/>
        public bool Equals(WorkstationName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(WorkstationName a, WorkstationName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(WorkstationName a, WorkstationName b) => !(a == b);
    }

    public partial class WorkstationCluster
    {
        /// <summary>
        /// <see cref="gcwv::WorkstationClusterName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcwv::WorkstationClusterName WorkstationClusterName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcwv::WorkstationClusterName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class WorkstationConfig
    {
        /// <summary>
        /// <see cref="gcwv::WorkstationConfigName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcwv::WorkstationConfigName WorkstationConfigName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcwv::WorkstationConfigName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class Workstation
    {
        /// <summary>
        /// <see cref="gcwv::WorkstationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcwv::WorkstationName WorkstationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcwv::WorkstationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetWorkstationClusterRequest
    {
        /// <summary>
        /// <see cref="gcwv::WorkstationClusterName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcwv::WorkstationClusterName WorkstationClusterName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcwv::WorkstationClusterName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListWorkstationClustersRequest
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

    public partial class CreateWorkstationClusterRequest
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

    public partial class DeleteWorkstationClusterRequest
    {
        /// <summary>
        /// <see cref="gcwv::WorkstationClusterName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcwv::WorkstationClusterName WorkstationClusterName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcwv::WorkstationClusterName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetWorkstationConfigRequest
    {
        /// <summary>
        /// <see cref="gcwv::WorkstationConfigName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcwv::WorkstationConfigName WorkstationConfigName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcwv::WorkstationConfigName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListWorkstationConfigsRequest
    {
        /// <summary>
        /// <see cref="WorkstationClusterName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public WorkstationClusterName ParentAsWorkstationClusterName
        {
            get => string.IsNullOrEmpty(Parent) ? null : WorkstationClusterName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class ListUsableWorkstationConfigsRequest
    {
        /// <summary>
        /// <see cref="WorkstationClusterName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public WorkstationClusterName ParentAsWorkstationClusterName
        {
            get => string.IsNullOrEmpty(Parent) ? null : WorkstationClusterName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class CreateWorkstationConfigRequest
    {
        /// <summary>
        /// <see cref="WorkstationClusterName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public WorkstationClusterName ParentAsWorkstationClusterName
        {
            get => string.IsNullOrEmpty(Parent) ? null : WorkstationClusterName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteWorkstationConfigRequest
    {
        /// <summary>
        /// <see cref="gcwv::WorkstationConfigName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcwv::WorkstationConfigName WorkstationConfigName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcwv::WorkstationConfigName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetWorkstationRequest
    {
        /// <summary>
        /// <see cref="gcwv::WorkstationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcwv::WorkstationName WorkstationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcwv::WorkstationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListWorkstationsRequest
    {
        /// <summary>
        /// <see cref="WorkstationConfigName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public WorkstationConfigName ParentAsWorkstationConfigName
        {
            get => string.IsNullOrEmpty(Parent) ? null : WorkstationConfigName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class ListUsableWorkstationsRequest
    {
        /// <summary>
        /// <see cref="WorkstationConfigName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public WorkstationConfigName ParentAsWorkstationConfigName
        {
            get => string.IsNullOrEmpty(Parent) ? null : WorkstationConfigName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class CreateWorkstationRequest
    {
        /// <summary>
        /// <see cref="WorkstationConfigName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public WorkstationConfigName ParentAsWorkstationConfigName
        {
            get => string.IsNullOrEmpty(Parent) ? null : WorkstationConfigName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteWorkstationRequest
    {
        /// <summary>
        /// <see cref="gcwv::WorkstationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcwv::WorkstationName WorkstationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcwv::WorkstationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class StartWorkstationRequest
    {
        /// <summary>
        /// <see cref="gcwv::WorkstationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcwv::WorkstationName WorkstationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcwv::WorkstationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class StopWorkstationRequest
    {
        /// <summary>
        /// <see cref="gcwv::WorkstationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcwv::WorkstationName WorkstationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcwv::WorkstationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GenerateAccessTokenRequest
    {
        /// <summary>
        /// <see cref="WorkstationName"/>-typed view over the <see cref="Workstation"/> resource name property.
        /// </summary>
        public WorkstationName WorkstationAsWorkstationName
        {
            get => string.IsNullOrEmpty(Workstation) ? null : WorkstationName.Parse(Workstation, allowUnparsed: true);
            set => Workstation = value?.ToString() ?? "";
        }
    }
}
