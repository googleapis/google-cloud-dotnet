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
using gax = Google.Api.Gax;
using gcov = Google.Cloud.OracleDatabase.V1;
using sys = System;

namespace Google.Cloud.OracleDatabase.V1
{
    /// <summary>Resource name for the <c>DbNode</c> resource.</summary>
    public sealed partial class DbNodeName : gax::IResourceName, sys::IEquatable<DbNodeName>
    {
        /// <summary>The possible contents of <see cref="DbNodeName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/cloudVmClusters/{cloud_vm_cluster}/dbNodes/{db_node}</c>.
            /// </summary>
            ProjectLocationCloudVmClusterDbNode = 1,
        }

        private static gax::PathTemplate s_projectLocationCloudVmClusterDbNode = new gax::PathTemplate("projects/{project}/locations/{location}/cloudVmClusters/{cloud_vm_cluster}/dbNodes/{db_node}");

        /// <summary>Creates a <see cref="DbNodeName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="DbNodeName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static DbNodeName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new DbNodeName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="DbNodeName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/cloudVmClusters/{cloud_vm_cluster}/dbNodes/{db_node}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="cloudVmClusterId">The <c>CloudVmCluster</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dbNodeId">The <c>DbNode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="DbNodeName"/> constructed from the provided ids.</returns>
        public static DbNodeName FromProjectLocationCloudVmClusterDbNode(string projectId, string locationId, string cloudVmClusterId, string dbNodeId) =>
            new DbNodeName(ResourceNameType.ProjectLocationCloudVmClusterDbNode, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), cloudVmClusterId: gax::GaxPreconditions.CheckNotNullOrEmpty(cloudVmClusterId, nameof(cloudVmClusterId)), dbNodeId: gax::GaxPreconditions.CheckNotNullOrEmpty(dbNodeId, nameof(dbNodeId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DbNodeName"/> with pattern
        /// <c>projects/{project}/locations/{location}/cloudVmClusters/{cloud_vm_cluster}/dbNodes/{db_node}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="cloudVmClusterId">The <c>CloudVmCluster</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dbNodeId">The <c>DbNode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DbNodeName"/> with pattern
        /// <c>projects/{project}/locations/{location}/cloudVmClusters/{cloud_vm_cluster}/dbNodes/{db_node}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string cloudVmClusterId, string dbNodeId) =>
            FormatProjectLocationCloudVmClusterDbNode(projectId, locationId, cloudVmClusterId, dbNodeId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DbNodeName"/> with pattern
        /// <c>projects/{project}/locations/{location}/cloudVmClusters/{cloud_vm_cluster}/dbNodes/{db_node}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="cloudVmClusterId">The <c>CloudVmCluster</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dbNodeId">The <c>DbNode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DbNodeName"/> with pattern
        /// <c>projects/{project}/locations/{location}/cloudVmClusters/{cloud_vm_cluster}/dbNodes/{db_node}</c>.
        /// </returns>
        public static string FormatProjectLocationCloudVmClusterDbNode(string projectId, string locationId, string cloudVmClusterId, string dbNodeId) =>
            s_projectLocationCloudVmClusterDbNode.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(cloudVmClusterId, nameof(cloudVmClusterId)), gax::GaxPreconditions.CheckNotNullOrEmpty(dbNodeId, nameof(dbNodeId)));

        /// <summary>Parses the given resource name string into a new <see cref="DbNodeName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/cloudVmClusters/{cloud_vm_cluster}/dbNodes/{db_node}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="dbNodeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="DbNodeName"/> if successful.</returns>
        public static DbNodeName Parse(string dbNodeName) => Parse(dbNodeName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="DbNodeName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/cloudVmClusters/{cloud_vm_cluster}/dbNodes/{db_node}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="dbNodeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="DbNodeName"/> if successful.</returns>
        public static DbNodeName Parse(string dbNodeName, bool allowUnparsed) =>
            TryParse(dbNodeName, allowUnparsed, out DbNodeName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DbNodeName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/cloudVmClusters/{cloud_vm_cluster}/dbNodes/{db_node}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="dbNodeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DbNodeName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string dbNodeName, out DbNodeName result) => TryParse(dbNodeName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DbNodeName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/cloudVmClusters/{cloud_vm_cluster}/dbNodes/{db_node}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="dbNodeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DbNodeName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string dbNodeName, bool allowUnparsed, out DbNodeName result)
        {
            gax::GaxPreconditions.CheckNotNull(dbNodeName, nameof(dbNodeName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationCloudVmClusterDbNode.TryParseName(dbNodeName, out resourceName))
            {
                result = FromProjectLocationCloudVmClusterDbNode(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(dbNodeName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private DbNodeName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string cloudVmClusterId = null, string dbNodeId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CloudVmClusterId = cloudVmClusterId;
            DbNodeId = dbNodeId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="DbNodeName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/cloudVmClusters/{cloud_vm_cluster}/dbNodes/{db_node}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="cloudVmClusterId">The <c>CloudVmCluster</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dbNodeId">The <c>DbNode</c> ID. Must not be <c>null</c> or empty.</param>
        public DbNodeName(string projectId, string locationId, string cloudVmClusterId, string dbNodeId) : this(ResourceNameType.ProjectLocationCloudVmClusterDbNode, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), cloudVmClusterId: gax::GaxPreconditions.CheckNotNullOrEmpty(cloudVmClusterId, nameof(cloudVmClusterId)), dbNodeId: gax::GaxPreconditions.CheckNotNullOrEmpty(dbNodeId, nameof(dbNodeId)))
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
        /// The <c>CloudVmCluster</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string CloudVmClusterId { get; }

        /// <summary>
        /// The <c>DbNode</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string DbNodeId { get; }

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
                case ResourceNameType.ProjectLocationCloudVmClusterDbNode: return s_projectLocationCloudVmClusterDbNode.Expand(ProjectId, LocationId, CloudVmClusterId, DbNodeId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as DbNodeName);

        /// <inheritdoc/>
        public bool Equals(DbNodeName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(DbNodeName a, DbNodeName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(DbNodeName a, DbNodeName b) => !(a == b);
    }

    public partial class DbNode
    {
        /// <summary>
        /// <see cref="gcov::DbNodeName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcov::DbNodeName DbNodeName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcov::DbNodeName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
