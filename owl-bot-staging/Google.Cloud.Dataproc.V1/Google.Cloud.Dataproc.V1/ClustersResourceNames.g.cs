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
using gax = Google.Api.Gax;
using gcdv = Google.Cloud.Dataproc.V1;
using sys = System;

namespace Google.Cloud.Dataproc.V1
{
    /// <summary>Resource name for the <c>NodeGroup</c> resource.</summary>
    public sealed partial class NodeGroupName : gax::IResourceName, sys::IEquatable<NodeGroupName>
    {
        /// <summary>The possible contents of <see cref="NodeGroupName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/regions/{region}/clusters/{cluster}/nodeGroups/{node_group}</c>.
            /// </summary>
            ProjectRegionClusterNodeGroup = 1,
        }

        private static gax::PathTemplate s_projectRegionClusterNodeGroup = new gax::PathTemplate("projects/{project}/regions/{region}/clusters/{cluster}/nodeGroups/{node_group}");

        /// <summary>Creates a <see cref="NodeGroupName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="NodeGroupName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static NodeGroupName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new NodeGroupName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="NodeGroupName"/> with the pattern
        /// <c>projects/{project}/regions/{region}/clusters/{cluster}/nodeGroups/{node_group}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="regionId">The <c>Region</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="clusterId">The <c>Cluster</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="nodeGroupId">The <c>NodeGroup</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="NodeGroupName"/> constructed from the provided ids.</returns>
        public static NodeGroupName FromProjectRegionClusterNodeGroup(string projectId, string regionId, string clusterId, string nodeGroupId) =>
            new NodeGroupName(ResourceNameType.ProjectRegionClusterNodeGroup, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), regionId: gax::GaxPreconditions.CheckNotNullOrEmpty(regionId, nameof(regionId)), clusterId: gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)), nodeGroupId: gax::GaxPreconditions.CheckNotNullOrEmpty(nodeGroupId, nameof(nodeGroupId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="NodeGroupName"/> with pattern
        /// <c>projects/{project}/regions/{region}/clusters/{cluster}/nodeGroups/{node_group}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="regionId">The <c>Region</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="clusterId">The <c>Cluster</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="nodeGroupId">The <c>NodeGroup</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="NodeGroupName"/> with pattern
        /// <c>projects/{project}/regions/{region}/clusters/{cluster}/nodeGroups/{node_group}</c>.
        /// </returns>
        public static string Format(string projectId, string regionId, string clusterId, string nodeGroupId) =>
            FormatProjectRegionClusterNodeGroup(projectId, regionId, clusterId, nodeGroupId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="NodeGroupName"/> with pattern
        /// <c>projects/{project}/regions/{region}/clusters/{cluster}/nodeGroups/{node_group}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="regionId">The <c>Region</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="clusterId">The <c>Cluster</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="nodeGroupId">The <c>NodeGroup</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="NodeGroupName"/> with pattern
        /// <c>projects/{project}/regions/{region}/clusters/{cluster}/nodeGroups/{node_group}</c>.
        /// </returns>
        public static string FormatProjectRegionClusterNodeGroup(string projectId, string regionId, string clusterId, string nodeGroupId) =>
            s_projectRegionClusterNodeGroup.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(regionId, nameof(regionId)), gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)), gax::GaxPreconditions.CheckNotNullOrEmpty(nodeGroupId, nameof(nodeGroupId)));

        /// <summary>Parses the given resource name string into a new <see cref="NodeGroupName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/regions/{region}/clusters/{cluster}/nodeGroups/{node_group}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="nodeGroupName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="NodeGroupName"/> if successful.</returns>
        public static NodeGroupName Parse(string nodeGroupName) => Parse(nodeGroupName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="NodeGroupName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/regions/{region}/clusters/{cluster}/nodeGroups/{node_group}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="nodeGroupName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="NodeGroupName"/> if successful.</returns>
        public static NodeGroupName Parse(string nodeGroupName, bool allowUnparsed) =>
            TryParse(nodeGroupName, allowUnparsed, out NodeGroupName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="NodeGroupName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/regions/{region}/clusters/{cluster}/nodeGroups/{node_group}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="nodeGroupName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="NodeGroupName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string nodeGroupName, out NodeGroupName result) => TryParse(nodeGroupName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="NodeGroupName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/regions/{region}/clusters/{cluster}/nodeGroups/{node_group}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="nodeGroupName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="NodeGroupName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string nodeGroupName, bool allowUnparsed, out NodeGroupName result)
        {
            gax::GaxPreconditions.CheckNotNull(nodeGroupName, nameof(nodeGroupName));
            gax::TemplatedResourceName resourceName;
            if (s_projectRegionClusterNodeGroup.TryParseName(nodeGroupName, out resourceName))
            {
                result = FromProjectRegionClusterNodeGroup(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(nodeGroupName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private NodeGroupName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string clusterId = null, string nodeGroupId = null, string projectId = null, string regionId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ClusterId = clusterId;
            NodeGroupId = nodeGroupId;
            ProjectId = projectId;
            RegionId = regionId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="NodeGroupName"/> class from the component parts of pattern
        /// <c>projects/{project}/regions/{region}/clusters/{cluster}/nodeGroups/{node_group}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="regionId">The <c>Region</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="clusterId">The <c>Cluster</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="nodeGroupId">The <c>NodeGroup</c> ID. Must not be <c>null</c> or empty.</param>
        public NodeGroupName(string projectId, string regionId, string clusterId, string nodeGroupId) : this(ResourceNameType.ProjectRegionClusterNodeGroup, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), regionId: gax::GaxPreconditions.CheckNotNullOrEmpty(regionId, nameof(regionId)), clusterId: gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)), nodeGroupId: gax::GaxPreconditions.CheckNotNullOrEmpty(nodeGroupId, nameof(nodeGroupId)))
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
        /// The <c>Cluster</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ClusterId { get; }

        /// <summary>
        /// The <c>NodeGroup</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string NodeGroupId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Region</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string RegionId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectRegionClusterNodeGroup: return s_projectRegionClusterNodeGroup.Expand(ProjectId, RegionId, ClusterId, NodeGroupId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as NodeGroupName);

        /// <inheritdoc/>
        public bool Equals(NodeGroupName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(NodeGroupName a, NodeGroupName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(NodeGroupName a, NodeGroupName b) => !(a == b);
    }

    public partial class EncryptionConfig
    {
        /// <summary>
        /// <see cref="CryptoKeyName"/>-typed view over the <see cref="KmsKey"/> resource name property.
        /// </summary>
        public CryptoKeyName KmsKeyAsCryptoKeyName
        {
            get => string.IsNullOrEmpty(KmsKey) ? null : CryptoKeyName.Parse(KmsKey, allowUnparsed: true);
            set => KmsKey = value?.ToString() ?? "";
        }
    }

    public partial class NodeGroup
    {
        /// <summary>
        /// <see cref="gcdv::NodeGroupName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::NodeGroupName NodeGroupName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::NodeGroupName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class MetastoreConfig
    {
        /// <summary>
        /// <see cref="ServiceName"/>-typed view over the <see cref="DataprocMetastoreService"/> resource name property.
        /// </summary>
        public ServiceName DataprocMetastoreServiceAsServiceName
        {
            get => string.IsNullOrEmpty(DataprocMetastoreService) ? null : ServiceName.Parse(DataprocMetastoreService, allowUnparsed: true);
            set => DataprocMetastoreService = value?.ToString() ?? "";
        }
    }
}
