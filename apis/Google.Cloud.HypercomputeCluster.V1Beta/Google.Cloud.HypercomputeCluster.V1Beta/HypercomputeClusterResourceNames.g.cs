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
using gchv = Google.Cloud.HypercomputeCluster.V1Beta;
using sys = System;

namespace Google.Cloud.HypercomputeCluster.V1Beta
{
    /// <summary>Resource name for the <c>Cluster</c> resource.</summary>
    public sealed partial class ClusterName : gax::IResourceName, sys::IEquatable<ClusterName>
    {
        /// <summary>The possible contents of <see cref="ClusterName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/clusters/{cluster}</c>.
            /// </summary>
            ProjectLocationCluster = 1,
        }

        private static gax::PathTemplate s_projectLocationCluster = new gax::PathTemplate("projects/{project}/locations/{location}/clusters/{cluster}");

        /// <summary>Creates a <see cref="ClusterName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ClusterName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ClusterName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ClusterName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ClusterName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/clusters/{cluster}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="clusterId">The <c>Cluster</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ClusterName"/> constructed from the provided ids.</returns>
        public static ClusterName FromProjectLocationCluster(string projectId, string locationId, string clusterId) =>
            new ClusterName(ResourceNameType.ProjectLocationCluster, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), clusterId: gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ClusterName"/> with pattern
        /// <c>projects/{project}/locations/{location}/clusters/{cluster}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="clusterId">The <c>Cluster</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ClusterName"/> with pattern
        /// <c>projects/{project}/locations/{location}/clusters/{cluster}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string clusterId) =>
            FormatProjectLocationCluster(projectId, locationId, clusterId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ClusterName"/> with pattern
        /// <c>projects/{project}/locations/{location}/clusters/{cluster}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="clusterId">The <c>Cluster</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ClusterName"/> with pattern
        /// <c>projects/{project}/locations/{location}/clusters/{cluster}</c>.
        /// </returns>
        public static string FormatProjectLocationCluster(string projectId, string locationId, string clusterId) =>
            s_projectLocationCluster.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)));

        /// <summary>Parses the given resource name string into a new <see cref="ClusterName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/clusters/{cluster}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="clusterName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ClusterName"/> if successful.</returns>
        public static ClusterName Parse(string clusterName) => Parse(clusterName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ClusterName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/clusters/{cluster}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="clusterName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ClusterName"/> if successful.</returns>
        public static ClusterName Parse(string clusterName, bool allowUnparsed) =>
            TryParse(clusterName, allowUnparsed, out ClusterName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ClusterName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/clusters/{cluster}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="clusterName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ClusterName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string clusterName, out ClusterName result) => TryParse(clusterName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ClusterName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/clusters/{cluster}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="clusterName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ClusterName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string clusterName, bool allowUnparsed, out ClusterName result)
        {
            gax::GaxPreconditions.CheckNotNull(clusterName, nameof(clusterName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationCluster.TryParseName(clusterName, out resourceName))
            {
                result = FromProjectLocationCluster(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(clusterName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ClusterName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string clusterId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ClusterId = clusterId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ClusterName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/clusters/{cluster}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="clusterId">The <c>Cluster</c> ID. Must not be <c>null</c> or empty.</param>
        public ClusterName(string projectId, string locationId, string clusterId) : this(ResourceNameType.ProjectLocationCluster, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), clusterId: gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)))
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
                case ResourceNameType.ProjectLocationCluster: return s_projectLocationCluster.Expand(ProjectId, LocationId, ClusterId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ClusterName);

        /// <inheritdoc/>
        public bool Equals(ClusterName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ClusterName a, ClusterName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ClusterName a, ClusterName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Node</c> resource.</summary>
    public sealed partial class NodeName : gax::IResourceName, sys::IEquatable<NodeName>
    {
        /// <summary>The possible contents of <see cref="NodeName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/clusters/{cluster}/nodes/{node}</c>
            /// .
            /// </summary>
            ProjectLocationClusterNode = 1,
        }

        private static gax::PathTemplate s_projectLocationClusterNode = new gax::PathTemplate("projects/{project}/locations/{location}/clusters/{cluster}/nodes/{node}");

        /// <summary>Creates a <see cref="NodeName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="NodeName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static NodeName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new NodeName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="NodeName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/clusters/{cluster}/nodes/{node}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="clusterId">The <c>Cluster</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="nodeId">The <c>Node</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="NodeName"/> constructed from the provided ids.</returns>
        public static NodeName FromProjectLocationClusterNode(string projectId, string locationId, string clusterId, string nodeId) =>
            new NodeName(ResourceNameType.ProjectLocationClusterNode, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), clusterId: gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)), nodeId: gax::GaxPreconditions.CheckNotNullOrEmpty(nodeId, nameof(nodeId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="NodeName"/> with pattern
        /// <c>projects/{project}/locations/{location}/clusters/{cluster}/nodes/{node}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="clusterId">The <c>Cluster</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="nodeId">The <c>Node</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="NodeName"/> with pattern
        /// <c>projects/{project}/locations/{location}/clusters/{cluster}/nodes/{node}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string clusterId, string nodeId) =>
            FormatProjectLocationClusterNode(projectId, locationId, clusterId, nodeId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="NodeName"/> with pattern
        /// <c>projects/{project}/locations/{location}/clusters/{cluster}/nodes/{node}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="clusterId">The <c>Cluster</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="nodeId">The <c>Node</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="NodeName"/> with pattern
        /// <c>projects/{project}/locations/{location}/clusters/{cluster}/nodes/{node}</c>.
        /// </returns>
        public static string FormatProjectLocationClusterNode(string projectId, string locationId, string clusterId, string nodeId) =>
            s_projectLocationClusterNode.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)), gax::GaxPreconditions.CheckNotNullOrEmpty(nodeId, nameof(nodeId)));

        /// <summary>Parses the given resource name string into a new <see cref="NodeName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/clusters/{cluster}/nodes/{node}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="nodeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="NodeName"/> if successful.</returns>
        public static NodeName Parse(string nodeName) => Parse(nodeName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="NodeName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/clusters/{cluster}/nodes/{node}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="nodeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="NodeName"/> if successful.</returns>
        public static NodeName Parse(string nodeName, bool allowUnparsed) =>
            TryParse(nodeName, allowUnparsed, out NodeName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>Tries to parse the given resource name string into a new <see cref="NodeName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/clusters/{cluster}/nodes/{node}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="nodeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="NodeName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string nodeName, out NodeName result) => TryParse(nodeName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="NodeName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/clusters/{cluster}/nodes/{node}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="nodeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="NodeName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string nodeName, bool allowUnparsed, out NodeName result)
        {
            gax::GaxPreconditions.CheckNotNull(nodeName, nameof(nodeName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationClusterNode.TryParseName(nodeName, out resourceName))
            {
                result = FromProjectLocationClusterNode(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(nodeName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private NodeName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string clusterId = null, string locationId = null, string nodeId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ClusterId = clusterId;
            LocationId = locationId;
            NodeId = nodeId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="NodeName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/clusters/{cluster}/nodes/{node}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="clusterId">The <c>Cluster</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="nodeId">The <c>Node</c> ID. Must not be <c>null</c> or empty.</param>
        public NodeName(string projectId, string locationId, string clusterId, string nodeId) : this(ResourceNameType.ProjectLocationClusterNode, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), clusterId: gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)), nodeId: gax::GaxPreconditions.CheckNotNullOrEmpty(nodeId, nameof(nodeId)))
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
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Node</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string NodeId { get; }

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
                case ResourceNameType.ProjectLocationClusterNode: return s_projectLocationClusterNode.Expand(ProjectId, LocationId, ClusterId, NodeId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as NodeName);

        /// <inheritdoc/>
        public bool Equals(NodeName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(NodeName a, NodeName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(NodeName a, NodeName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>ComputeInstance</c> resource.</summary>
    public sealed partial class ComputeInstanceName : gax::IResourceName, sys::IEquatable<ComputeInstanceName>
    {
        /// <summary>The possible contents of <see cref="ComputeInstanceName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/zones/{zone}/instances/{instance}</c>.
            /// </summary>
            ProjectZoneInstance = 1,
        }

        private static gax::PathTemplate s_projectZoneInstance = new gax::PathTemplate("projects/{project}/zones/{zone}/instances/{instance}");

        /// <summary>Creates a <see cref="ComputeInstanceName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ComputeInstanceName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ComputeInstanceName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ComputeInstanceName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ComputeInstanceName"/> with the pattern
        /// <c>projects/{project}/zones/{zone}/instances/{instance}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="zoneId">The <c>Zone</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ComputeInstanceName"/> constructed from the provided ids.</returns>
        public static ComputeInstanceName FromProjectZoneInstance(string projectId, string zoneId, string instanceId) =>
            new ComputeInstanceName(ResourceNameType.ProjectZoneInstance, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), zoneId: gax::GaxPreconditions.CheckNotNullOrEmpty(zoneId, nameof(zoneId)), instanceId: gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ComputeInstanceName"/> with pattern
        /// <c>projects/{project}/zones/{zone}/instances/{instance}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="zoneId">The <c>Zone</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ComputeInstanceName"/> with pattern
        /// <c>projects/{project}/zones/{zone}/instances/{instance}</c>.
        /// </returns>
        public static string Format(string projectId, string zoneId, string instanceId) =>
            FormatProjectZoneInstance(projectId, zoneId, instanceId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ComputeInstanceName"/> with pattern
        /// <c>projects/{project}/zones/{zone}/instances/{instance}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="zoneId">The <c>Zone</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ComputeInstanceName"/> with pattern
        /// <c>projects/{project}/zones/{zone}/instances/{instance}</c>.
        /// </returns>
        public static string FormatProjectZoneInstance(string projectId, string zoneId, string instanceId) =>
            s_projectZoneInstance.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(zoneId, nameof(zoneId)), gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ComputeInstanceName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/zones/{zone}/instances/{instance}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="computeInstanceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ComputeInstanceName"/> if successful.</returns>
        public static ComputeInstanceName Parse(string computeInstanceName) => Parse(computeInstanceName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ComputeInstanceName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/zones/{zone}/instances/{instance}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="computeInstanceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ComputeInstanceName"/> if successful.</returns>
        public static ComputeInstanceName Parse(string computeInstanceName, bool allowUnparsed) =>
            TryParse(computeInstanceName, allowUnparsed, out ComputeInstanceName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ComputeInstanceName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/zones/{zone}/instances/{instance}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="computeInstanceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ComputeInstanceName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string computeInstanceName, out ComputeInstanceName result) =>
            TryParse(computeInstanceName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ComputeInstanceName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/zones/{zone}/instances/{instance}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="computeInstanceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ComputeInstanceName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string computeInstanceName, bool allowUnparsed, out ComputeInstanceName result)
        {
            gax::GaxPreconditions.CheckNotNull(computeInstanceName, nameof(computeInstanceName));
            gax::TemplatedResourceName resourceName;
            if (s_projectZoneInstance.TryParseName(computeInstanceName, out resourceName))
            {
                result = FromProjectZoneInstance(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(computeInstanceName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ComputeInstanceName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string instanceId = null, string projectId = null, string zoneId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            InstanceId = instanceId;
            ProjectId = projectId;
            ZoneId = zoneId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ComputeInstanceName"/> class from the component parts of pattern
        /// <c>projects/{project}/zones/{zone}/instances/{instance}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="zoneId">The <c>Zone</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        public ComputeInstanceName(string projectId, string zoneId, string instanceId) : this(ResourceNameType.ProjectZoneInstance, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), zoneId: gax::GaxPreconditions.CheckNotNullOrEmpty(zoneId, nameof(zoneId)), instanceId: gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)))
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
        /// The <c>Instance</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string InstanceId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Zone</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ZoneId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectZoneInstance: return s_projectZoneInstance.Expand(ProjectId, ZoneId, InstanceId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ComputeInstanceName);

        /// <inheritdoc/>
        public bool Equals(ComputeInstanceName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ComputeInstanceName a, ComputeInstanceName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ComputeInstanceName a, ComputeInstanceName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Disk</c> resource.</summary>
    public sealed partial class DiskName : gax::IResourceName, sys::IEquatable<DiskName>
    {
        /// <summary>The possible contents of <see cref="DiskName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>projects/{project}/zones/{zone}/disks/{disk}</c>.</summary>
            ProjectZoneDisk = 1,
        }

        private static gax::PathTemplate s_projectZoneDisk = new gax::PathTemplate("projects/{project}/zones/{zone}/disks/{disk}");

        /// <summary>Creates a <see cref="DiskName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="DiskName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static DiskName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new DiskName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="DiskName"/> with the pattern <c>projects/{project}/zones/{zone}/disks/{disk}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="zoneId">The <c>Zone</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="diskId">The <c>Disk</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="DiskName"/> constructed from the provided ids.</returns>
        public static DiskName FromProjectZoneDisk(string projectId, string zoneId, string diskId) =>
            new DiskName(ResourceNameType.ProjectZoneDisk, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), zoneId: gax::GaxPreconditions.CheckNotNullOrEmpty(zoneId, nameof(zoneId)), diskId: gax::GaxPreconditions.CheckNotNullOrEmpty(diskId, nameof(diskId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DiskName"/> with pattern
        /// <c>projects/{project}/zones/{zone}/disks/{disk}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="zoneId">The <c>Zone</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="diskId">The <c>Disk</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DiskName"/> with pattern
        /// <c>projects/{project}/zones/{zone}/disks/{disk}</c>.
        /// </returns>
        public static string Format(string projectId, string zoneId, string diskId) =>
            FormatProjectZoneDisk(projectId, zoneId, diskId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DiskName"/> with pattern
        /// <c>projects/{project}/zones/{zone}/disks/{disk}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="zoneId">The <c>Zone</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="diskId">The <c>Disk</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DiskName"/> with pattern
        /// <c>projects/{project}/zones/{zone}/disks/{disk}</c>.
        /// </returns>
        public static string FormatProjectZoneDisk(string projectId, string zoneId, string diskId) =>
            s_projectZoneDisk.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(zoneId, nameof(zoneId)), gax::GaxPreconditions.CheckNotNullOrEmpty(diskId, nameof(diskId)));

        /// <summary>Parses the given resource name string into a new <see cref="DiskName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/zones/{zone}/disks/{disk}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="diskName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="DiskName"/> if successful.</returns>
        public static DiskName Parse(string diskName) => Parse(diskName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="DiskName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/zones/{zone}/disks/{disk}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="diskName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="DiskName"/> if successful.</returns>
        public static DiskName Parse(string diskName, bool allowUnparsed) =>
            TryParse(diskName, allowUnparsed, out DiskName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>Tries to parse the given resource name string into a new <see cref="DiskName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/zones/{zone}/disks/{disk}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="diskName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DiskName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string diskName, out DiskName result) => TryParse(diskName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DiskName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/zones/{zone}/disks/{disk}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="diskName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DiskName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string diskName, bool allowUnparsed, out DiskName result)
        {
            gax::GaxPreconditions.CheckNotNull(diskName, nameof(diskName));
            gax::TemplatedResourceName resourceName;
            if (s_projectZoneDisk.TryParseName(diskName, out resourceName))
            {
                result = FromProjectZoneDisk(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(diskName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private DiskName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string diskId = null, string projectId = null, string zoneId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            DiskId = diskId;
            ProjectId = projectId;
            ZoneId = zoneId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="DiskName"/> class from the component parts of pattern
        /// <c>projects/{project}/zones/{zone}/disks/{disk}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="zoneId">The <c>Zone</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="diskId">The <c>Disk</c> ID. Must not be <c>null</c> or empty.</param>
        public DiskName(string projectId, string zoneId, string diskId) : this(ResourceNameType.ProjectZoneDisk, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), zoneId: gax::GaxPreconditions.CheckNotNullOrEmpty(zoneId, nameof(zoneId)), diskId: gax::GaxPreconditions.CheckNotNullOrEmpty(diskId, nameof(diskId)))
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
        /// The <c>Disk</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string DiskId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Zone</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ZoneId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectZoneDisk: return s_projectZoneDisk.Expand(ProjectId, ZoneId, DiskId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as DiskName);

        /// <inheritdoc/>
        public bool Equals(DiskName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(DiskName a, DiskName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(DiskName a, DiskName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>DiskType</c> resource.</summary>
    public sealed partial class DiskTypeName : gax::IResourceName, sys::IEquatable<DiskTypeName>
    {
        /// <summary>The possible contents of <see cref="DiskTypeName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/zones/{zone}/diskTypes/{disk_type}</c>.
            /// </summary>
            ProjectZoneDiskType = 1,
        }

        private static gax::PathTemplate s_projectZoneDiskType = new gax::PathTemplate("projects/{project}/zones/{zone}/diskTypes/{disk_type}");

        /// <summary>Creates a <see cref="DiskTypeName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="DiskTypeName"/> containing the provided <paramref name="unparsedResourceName"/>
        /// .
        /// </returns>
        public static DiskTypeName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new DiskTypeName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="DiskTypeName"/> with the pattern
        /// <c>projects/{project}/zones/{zone}/diskTypes/{disk_type}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="zoneId">The <c>Zone</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="diskTypeId">The <c>DiskType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="DiskTypeName"/> constructed from the provided ids.</returns>
        public static DiskTypeName FromProjectZoneDiskType(string projectId, string zoneId, string diskTypeId) =>
            new DiskTypeName(ResourceNameType.ProjectZoneDiskType, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), zoneId: gax::GaxPreconditions.CheckNotNullOrEmpty(zoneId, nameof(zoneId)), diskTypeId: gax::GaxPreconditions.CheckNotNullOrEmpty(diskTypeId, nameof(diskTypeId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DiskTypeName"/> with pattern
        /// <c>projects/{project}/zones/{zone}/diskTypes/{disk_type}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="zoneId">The <c>Zone</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="diskTypeId">The <c>DiskType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DiskTypeName"/> with pattern
        /// <c>projects/{project}/zones/{zone}/diskTypes/{disk_type}</c>.
        /// </returns>
        public static string Format(string projectId, string zoneId, string diskTypeId) =>
            FormatProjectZoneDiskType(projectId, zoneId, diskTypeId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DiskTypeName"/> with pattern
        /// <c>projects/{project}/zones/{zone}/diskTypes/{disk_type}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="zoneId">The <c>Zone</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="diskTypeId">The <c>DiskType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DiskTypeName"/> with pattern
        /// <c>projects/{project}/zones/{zone}/diskTypes/{disk_type}</c>.
        /// </returns>
        public static string FormatProjectZoneDiskType(string projectId, string zoneId, string diskTypeId) =>
            s_projectZoneDiskType.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(zoneId, nameof(zoneId)), gax::GaxPreconditions.CheckNotNullOrEmpty(diskTypeId, nameof(diskTypeId)));

        /// <summary>Parses the given resource name string into a new <see cref="DiskTypeName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/zones/{zone}/diskTypes/{disk_type}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="diskTypeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="DiskTypeName"/> if successful.</returns>
        public static DiskTypeName Parse(string diskTypeName) => Parse(diskTypeName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="DiskTypeName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/zones/{zone}/diskTypes/{disk_type}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="diskTypeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="DiskTypeName"/> if successful.</returns>
        public static DiskTypeName Parse(string diskTypeName, bool allowUnparsed) =>
            TryParse(diskTypeName, allowUnparsed, out DiskTypeName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DiskTypeName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/zones/{zone}/diskTypes/{disk_type}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="diskTypeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DiskTypeName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string diskTypeName, out DiskTypeName result) => TryParse(diskTypeName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DiskTypeName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/zones/{zone}/diskTypes/{disk_type}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="diskTypeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DiskTypeName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string diskTypeName, bool allowUnparsed, out DiskTypeName result)
        {
            gax::GaxPreconditions.CheckNotNull(diskTypeName, nameof(diskTypeName));
            gax::TemplatedResourceName resourceName;
            if (s_projectZoneDiskType.TryParseName(diskTypeName, out resourceName))
            {
                result = FromProjectZoneDiskType(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(diskTypeName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private DiskTypeName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string diskTypeId = null, string projectId = null, string zoneId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            DiskTypeId = diskTypeId;
            ProjectId = projectId;
            ZoneId = zoneId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="DiskTypeName"/> class from the component parts of pattern
        /// <c>projects/{project}/zones/{zone}/diskTypes/{disk_type}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="zoneId">The <c>Zone</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="diskTypeId">The <c>DiskType</c> ID. Must not be <c>null</c> or empty.</param>
        public DiskTypeName(string projectId, string zoneId, string diskTypeId) : this(ResourceNameType.ProjectZoneDiskType, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), zoneId: gax::GaxPreconditions.CheckNotNullOrEmpty(zoneId, nameof(zoneId)), diskTypeId: gax::GaxPreconditions.CheckNotNullOrEmpty(diskTypeId, nameof(diskTypeId)))
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
        /// The <c>DiskType</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string DiskTypeId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Zone</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ZoneId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectZoneDiskType: return s_projectZoneDiskType.Expand(ProjectId, ZoneId, DiskTypeId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as DiskTypeName);

        /// <inheritdoc/>
        public bool Equals(DiskTypeName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(DiskTypeName a, DiskTypeName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(DiskTypeName a, DiskTypeName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Image</c> resource.</summary>
    public sealed partial class ImageName : gax::IResourceName, sys::IEquatable<ImageName>
    {
        /// <summary>The possible contents of <see cref="ImageName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>projects/{project}/global/images/{image}</c>.</summary>
            ProjectImage = 1,
        }

        private static gax::PathTemplate s_projectImage = new gax::PathTemplate("projects/{project}/global/images/{image}");

        /// <summary>Creates a <see cref="ImageName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ImageName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ImageName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ImageName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ImageName"/> with the pattern <c>projects/{project}/global/images/{image}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="imageId">The <c>Image</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ImageName"/> constructed from the provided ids.</returns>
        public static ImageName FromProjectImage(string projectId, string imageId) =>
            new ImageName(ResourceNameType.ProjectImage, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), imageId: gax::GaxPreconditions.CheckNotNullOrEmpty(imageId, nameof(imageId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ImageName"/> with pattern
        /// <c>projects/{project}/global/images/{image}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="imageId">The <c>Image</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ImageName"/> with pattern
        /// <c>projects/{project}/global/images/{image}</c>.
        /// </returns>
        public static string Format(string projectId, string imageId) => FormatProjectImage(projectId, imageId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ImageName"/> with pattern
        /// <c>projects/{project}/global/images/{image}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="imageId">The <c>Image</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ImageName"/> with pattern
        /// <c>projects/{project}/global/images/{image}</c>.
        /// </returns>
        public static string FormatProjectImage(string projectId, string imageId) =>
            s_projectImage.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(imageId, nameof(imageId)));

        /// <summary>Parses the given resource name string into a new <see cref="ImageName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/global/images/{image}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="imageName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ImageName"/> if successful.</returns>
        public static ImageName Parse(string imageName) => Parse(imageName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ImageName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/global/images/{image}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="imageName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ImageName"/> if successful.</returns>
        public static ImageName Parse(string imageName, bool allowUnparsed) =>
            TryParse(imageName, allowUnparsed, out ImageName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ImageName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/global/images/{image}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="imageName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ImageName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string imageName, out ImageName result) => TryParse(imageName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ImageName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/global/images/{image}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="imageName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ImageName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string imageName, bool allowUnparsed, out ImageName result)
        {
            gax::GaxPreconditions.CheckNotNull(imageName, nameof(imageName));
            gax::TemplatedResourceName resourceName;
            if (s_projectImage.TryParseName(imageName, out resourceName))
            {
                result = FromProjectImage(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(imageName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ImageName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string imageId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ImageId = imageId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ImageName"/> class from the component parts of pattern
        /// <c>projects/{project}/global/images/{image}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="imageId">The <c>Image</c> ID. Must not be <c>null</c> or empty.</param>
        public ImageName(string projectId, string imageId) : this(ResourceNameType.ProjectImage, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), imageId: gax::GaxPreconditions.CheckNotNullOrEmpty(imageId, nameof(imageId)))
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
        /// The <c>Image</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ImageId { get; }

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
                case ResourceNameType.ProjectImage: return s_projectImage.Expand(ProjectId, ImageId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ImageName);

        /// <inheritdoc/>
        public bool Equals(ImageName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ImageName a, ImageName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ImageName a, ImageName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>InstanceGroupManager</c> resource.</summary>
    public sealed partial class InstanceGroupManagerName : gax::IResourceName, sys::IEquatable<InstanceGroupManagerName>
    {
        /// <summary>The possible contents of <see cref="InstanceGroupManagerName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/zones/{zone}/instanceGroupManagers/{instance_group_manager}</c>.
            /// </summary>
            ProjectZoneInstanceGroupManager = 1,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/regions/{region}/instanceGroupManagers/{instance_group_manager}</c>.
            /// </summary>
            ProjectRegionInstanceGroupManager = 2,
        }

        private static gax::PathTemplate s_projectZoneInstanceGroupManager = new gax::PathTemplate("projects/{project}/zones/{zone}/instanceGroupManagers/{instance_group_manager}");

        private static gax::PathTemplate s_projectRegionInstanceGroupManager = new gax::PathTemplate("projects/{project}/regions/{region}/instanceGroupManagers/{instance_group_manager}");

        /// <summary>Creates a <see cref="InstanceGroupManagerName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="InstanceGroupManagerName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static InstanceGroupManagerName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new InstanceGroupManagerName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="InstanceGroupManagerName"/> with the pattern
        /// <c>projects/{project}/zones/{zone}/instanceGroupManagers/{instance_group_manager}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="zoneId">The <c>Zone</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceGroupManagerId">
        /// The <c>InstanceGroupManager</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="InstanceGroupManagerName"/> constructed from the provided ids.
        /// </returns>
        public static InstanceGroupManagerName FromProjectZoneInstanceGroupManager(string projectId, string zoneId, string instanceGroupManagerId) =>
            new InstanceGroupManagerName(ResourceNameType.ProjectZoneInstanceGroupManager, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), zoneId: gax::GaxPreconditions.CheckNotNullOrEmpty(zoneId, nameof(zoneId)), instanceGroupManagerId: gax::GaxPreconditions.CheckNotNullOrEmpty(instanceGroupManagerId, nameof(instanceGroupManagerId)));

        /// <summary>
        /// Creates a <see cref="InstanceGroupManagerName"/> with the pattern
        /// <c>projects/{project}/regions/{region}/instanceGroupManagers/{instance_group_manager}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="regionId">The <c>Region</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceGroupManagerId">
        /// The <c>InstanceGroupManager</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="InstanceGroupManagerName"/> constructed from the provided ids.
        /// </returns>
        public static InstanceGroupManagerName FromProjectRegionInstanceGroupManager(string projectId, string regionId, string instanceGroupManagerId) =>
            new InstanceGroupManagerName(ResourceNameType.ProjectRegionInstanceGroupManager, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), regionId: gax::GaxPreconditions.CheckNotNullOrEmpty(regionId, nameof(regionId)), instanceGroupManagerId: gax::GaxPreconditions.CheckNotNullOrEmpty(instanceGroupManagerId, nameof(instanceGroupManagerId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="InstanceGroupManagerName"/> with pattern
        /// <c>projects/{project}/zones/{zone}/instanceGroupManagers/{instance_group_manager}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="zoneId">The <c>Zone</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceGroupManagerId">
        /// The <c>InstanceGroupManager</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="InstanceGroupManagerName"/> with pattern
        /// <c>projects/{project}/zones/{zone}/instanceGroupManagers/{instance_group_manager}</c>.
        /// </returns>
        public static string Format(string projectId, string zoneId, string instanceGroupManagerId) =>
            FormatProjectZoneInstanceGroupManager(projectId, zoneId, instanceGroupManagerId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="InstanceGroupManagerName"/> with pattern
        /// <c>projects/{project}/zones/{zone}/instanceGroupManagers/{instance_group_manager}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="zoneId">The <c>Zone</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceGroupManagerId">
        /// The <c>InstanceGroupManager</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="InstanceGroupManagerName"/> with pattern
        /// <c>projects/{project}/zones/{zone}/instanceGroupManagers/{instance_group_manager}</c>.
        /// </returns>
        public static string FormatProjectZoneInstanceGroupManager(string projectId, string zoneId, string instanceGroupManagerId) =>
            s_projectZoneInstanceGroupManager.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(zoneId, nameof(zoneId)), gax::GaxPreconditions.CheckNotNullOrEmpty(instanceGroupManagerId, nameof(instanceGroupManagerId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="InstanceGroupManagerName"/> with pattern
        /// <c>projects/{project}/regions/{region}/instanceGroupManagers/{instance_group_manager}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="regionId">The <c>Region</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceGroupManagerId">
        /// The <c>InstanceGroupManager</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="InstanceGroupManagerName"/> with pattern
        /// <c>projects/{project}/regions/{region}/instanceGroupManagers/{instance_group_manager}</c>.
        /// </returns>
        public static string FormatProjectRegionInstanceGroupManager(string projectId, string regionId, string instanceGroupManagerId) =>
            s_projectRegionInstanceGroupManager.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(regionId, nameof(regionId)), gax::GaxPreconditions.CheckNotNullOrEmpty(instanceGroupManagerId, nameof(instanceGroupManagerId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="InstanceGroupManagerName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/zones/{zone}/instanceGroupManagers/{instance_group_manager}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/regions/{region}/instanceGroupManagers/{instance_group_manager}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="instanceGroupManagerName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="InstanceGroupManagerName"/> if successful.</returns>
        public static InstanceGroupManagerName Parse(string instanceGroupManagerName) =>
            Parse(instanceGroupManagerName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="InstanceGroupManagerName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/zones/{zone}/instanceGroupManagers/{instance_group_manager}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/regions/{region}/instanceGroupManagers/{instance_group_manager}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="instanceGroupManagerName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="InstanceGroupManagerName"/> if successful.</returns>
        public static InstanceGroupManagerName Parse(string instanceGroupManagerName, bool allowUnparsed) =>
            TryParse(instanceGroupManagerName, allowUnparsed, out InstanceGroupManagerName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="InstanceGroupManagerName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/zones/{zone}/instanceGroupManagers/{instance_group_manager}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/regions/{region}/instanceGroupManagers/{instance_group_manager}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="instanceGroupManagerName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="InstanceGroupManagerName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string instanceGroupManagerName, out InstanceGroupManagerName result) =>
            TryParse(instanceGroupManagerName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="InstanceGroupManagerName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/zones/{zone}/instanceGroupManagers/{instance_group_manager}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/regions/{region}/instanceGroupManagers/{instance_group_manager}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="instanceGroupManagerName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="InstanceGroupManagerName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string instanceGroupManagerName, bool allowUnparsed, out InstanceGroupManagerName result)
        {
            gax::GaxPreconditions.CheckNotNull(instanceGroupManagerName, nameof(instanceGroupManagerName));
            gax::TemplatedResourceName resourceName;
            if (s_projectZoneInstanceGroupManager.TryParseName(instanceGroupManagerName, out resourceName))
            {
                result = FromProjectZoneInstanceGroupManager(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (s_projectRegionInstanceGroupManager.TryParseName(instanceGroupManagerName, out resourceName))
            {
                result = FromProjectRegionInstanceGroupManager(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(instanceGroupManagerName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private InstanceGroupManagerName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string instanceGroupManagerId = null, string projectId = null, string regionId = null, string zoneId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            InstanceGroupManagerId = instanceGroupManagerId;
            ProjectId = projectId;
            RegionId = regionId;
            ZoneId = zoneId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="InstanceGroupManagerName"/> class from the component parts of
        /// pattern <c>projects/{project}/zones/{zone}/instanceGroupManagers/{instance_group_manager}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="zoneId">The <c>Zone</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceGroupManagerId">
        /// The <c>InstanceGroupManager</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public InstanceGroupManagerName(string projectId, string zoneId, string instanceGroupManagerId) : this(ResourceNameType.ProjectZoneInstanceGroupManager, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), zoneId: gax::GaxPreconditions.CheckNotNullOrEmpty(zoneId, nameof(zoneId)), instanceGroupManagerId: gax::GaxPreconditions.CheckNotNullOrEmpty(instanceGroupManagerId, nameof(instanceGroupManagerId)))
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
        /// The <c>InstanceGroupManager</c> ID. May be <c>null</c>, depending on which resource name is contained by
        /// this instance.
        /// </summary>
        public string InstanceGroupManagerId { get; }

        /// <summary>
        /// The <c>Project</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Region</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string RegionId { get; }

        /// <summary>
        /// The <c>Zone</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string ZoneId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectZoneInstanceGroupManager: return s_projectZoneInstanceGroupManager.Expand(ProjectId, ZoneId, InstanceGroupManagerId);
                case ResourceNameType.ProjectRegionInstanceGroupManager: return s_projectRegionInstanceGroupManager.Expand(ProjectId, RegionId, InstanceGroupManagerId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as InstanceGroupManagerName);

        /// <inheritdoc/>
        public bool Equals(InstanceGroupManagerName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(InstanceGroupManagerName a, InstanceGroupManagerName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(InstanceGroupManagerName a, InstanceGroupManagerName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>InstanceTemplate</c> resource.</summary>
    public sealed partial class InstanceTemplateName : gax::IResourceName, sys::IEquatable<InstanceTemplateName>
    {
        /// <summary>The possible contents of <see cref="InstanceTemplateName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/global/instanceTemplates/{instance_template}</c>.
            /// </summary>
            ProjectInstanceTemplate = 1,
        }

        private static gax::PathTemplate s_projectInstanceTemplate = new gax::PathTemplate("projects/{project}/global/instanceTemplates/{instance_template}");

        /// <summary>Creates a <see cref="InstanceTemplateName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="InstanceTemplateName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static InstanceTemplateName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new InstanceTemplateName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="InstanceTemplateName"/> with the pattern
        /// <c>projects/{project}/global/instanceTemplates/{instance_template}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceTemplateId">The <c>InstanceTemplate</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="InstanceTemplateName"/> constructed from the provided ids.</returns>
        public static InstanceTemplateName FromProjectInstanceTemplate(string projectId, string instanceTemplateId) =>
            new InstanceTemplateName(ResourceNameType.ProjectInstanceTemplate, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), instanceTemplateId: gax::GaxPreconditions.CheckNotNullOrEmpty(instanceTemplateId, nameof(instanceTemplateId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="InstanceTemplateName"/> with pattern
        /// <c>projects/{project}/global/instanceTemplates/{instance_template}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceTemplateId">The <c>InstanceTemplate</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="InstanceTemplateName"/> with pattern
        /// <c>projects/{project}/global/instanceTemplates/{instance_template}</c>.
        /// </returns>
        public static string Format(string projectId, string instanceTemplateId) =>
            FormatProjectInstanceTemplate(projectId, instanceTemplateId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="InstanceTemplateName"/> with pattern
        /// <c>projects/{project}/global/instanceTemplates/{instance_template}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceTemplateId">The <c>InstanceTemplate</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="InstanceTemplateName"/> with pattern
        /// <c>projects/{project}/global/instanceTemplates/{instance_template}</c>.
        /// </returns>
        public static string FormatProjectInstanceTemplate(string projectId, string instanceTemplateId) =>
            s_projectInstanceTemplate.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(instanceTemplateId, nameof(instanceTemplateId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="InstanceTemplateName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/global/instanceTemplates/{instance_template}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="instanceTemplateName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="InstanceTemplateName"/> if successful.</returns>
        public static InstanceTemplateName Parse(string instanceTemplateName) => Parse(instanceTemplateName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="InstanceTemplateName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/global/instanceTemplates/{instance_template}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="instanceTemplateName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="InstanceTemplateName"/> if successful.</returns>
        public static InstanceTemplateName Parse(string instanceTemplateName, bool allowUnparsed) =>
            TryParse(instanceTemplateName, allowUnparsed, out InstanceTemplateName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="InstanceTemplateName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/global/instanceTemplates/{instance_template}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="instanceTemplateName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="InstanceTemplateName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string instanceTemplateName, out InstanceTemplateName result) =>
            TryParse(instanceTemplateName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="InstanceTemplateName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/global/instanceTemplates/{instance_template}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="instanceTemplateName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="InstanceTemplateName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string instanceTemplateName, bool allowUnparsed, out InstanceTemplateName result)
        {
            gax::GaxPreconditions.CheckNotNull(instanceTemplateName, nameof(instanceTemplateName));
            gax::TemplatedResourceName resourceName;
            if (s_projectInstanceTemplate.TryParseName(instanceTemplateName, out resourceName))
            {
                result = FromProjectInstanceTemplate(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(instanceTemplateName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private InstanceTemplateName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string instanceTemplateId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            InstanceTemplateId = instanceTemplateId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="InstanceTemplateName"/> class from the component parts of pattern
        /// <c>projects/{project}/global/instanceTemplates/{instance_template}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceTemplateId">The <c>InstanceTemplate</c> ID. Must not be <c>null</c> or empty.</param>
        public InstanceTemplateName(string projectId, string instanceTemplateId) : this(ResourceNameType.ProjectInstanceTemplate, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), instanceTemplateId: gax::GaxPreconditions.CheckNotNullOrEmpty(instanceTemplateId, nameof(instanceTemplateId)))
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
        /// The <c>InstanceTemplate</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string InstanceTemplateId { get; }

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
                case ResourceNameType.ProjectInstanceTemplate: return s_projectInstanceTemplate.Expand(ProjectId, InstanceTemplateId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as InstanceTemplateName);

        /// <inheritdoc/>
        public bool Equals(InstanceTemplateName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(InstanceTemplateName a, InstanceTemplateName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(InstanceTemplateName a, InstanceTemplateName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Network</c> resource.</summary>
    public sealed partial class NetworkName : gax::IResourceName, sys::IEquatable<NetworkName>
    {
        /// <summary>The possible contents of <see cref="NetworkName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>projects/{project}/global/networks/{network}</c>.</summary>
            ProjectNetwork = 1,
        }

        private static gax::PathTemplate s_projectNetwork = new gax::PathTemplate("projects/{project}/global/networks/{network}");

        /// <summary>Creates a <see cref="NetworkName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="NetworkName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static NetworkName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new NetworkName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="NetworkName"/> with the pattern <c>projects/{project}/global/networks/{network}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="networkId">The <c>Network</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="NetworkName"/> constructed from the provided ids.</returns>
        public static NetworkName FromProjectNetwork(string projectId, string networkId) =>
            new NetworkName(ResourceNameType.ProjectNetwork, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), networkId: gax::GaxPreconditions.CheckNotNullOrEmpty(networkId, nameof(networkId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="NetworkName"/> with pattern
        /// <c>projects/{project}/global/networks/{network}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="networkId">The <c>Network</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="NetworkName"/> with pattern
        /// <c>projects/{project}/global/networks/{network}</c>.
        /// </returns>
        public static string Format(string projectId, string networkId) => FormatProjectNetwork(projectId, networkId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="NetworkName"/> with pattern
        /// <c>projects/{project}/global/networks/{network}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="networkId">The <c>Network</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="NetworkName"/> with pattern
        /// <c>projects/{project}/global/networks/{network}</c>.
        /// </returns>
        public static string FormatProjectNetwork(string projectId, string networkId) =>
            s_projectNetwork.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(networkId, nameof(networkId)));

        /// <summary>Parses the given resource name string into a new <see cref="NetworkName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/global/networks/{network}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="networkName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="NetworkName"/> if successful.</returns>
        public static NetworkName Parse(string networkName) => Parse(networkName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="NetworkName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/global/networks/{network}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="networkName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="NetworkName"/> if successful.</returns>
        public static NetworkName Parse(string networkName, bool allowUnparsed) =>
            TryParse(networkName, allowUnparsed, out NetworkName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="NetworkName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/global/networks/{network}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="networkName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="NetworkName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string networkName, out NetworkName result) => TryParse(networkName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="NetworkName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/global/networks/{network}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="networkName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="NetworkName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string networkName, bool allowUnparsed, out NetworkName result)
        {
            gax::GaxPreconditions.CheckNotNull(networkName, nameof(networkName));
            gax::TemplatedResourceName resourceName;
            if (s_projectNetwork.TryParseName(networkName, out resourceName))
            {
                result = FromProjectNetwork(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(networkName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private NetworkName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string networkId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            NetworkId = networkId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="NetworkName"/> class from the component parts of pattern
        /// <c>projects/{project}/global/networks/{network}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="networkId">The <c>Network</c> ID. Must not be <c>null</c> or empty.</param>
        public NetworkName(string projectId, string networkId) : this(ResourceNameType.ProjectNetwork, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), networkId: gax::GaxPreconditions.CheckNotNullOrEmpty(networkId, nameof(networkId)))
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
        /// The <c>Network</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string NetworkId { get; }

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
                case ResourceNameType.ProjectNetwork: return s_projectNetwork.Expand(ProjectId, NetworkId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as NetworkName);

        /// <inheritdoc/>
        public bool Equals(NetworkName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(NetworkName a, NetworkName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(NetworkName a, NetworkName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Reservation</c> resource.</summary>
    public sealed partial class ReservationName : gax::IResourceName, sys::IEquatable<ReservationName>
    {
        /// <summary>The possible contents of <see cref="ReservationName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/zones/{zone}/reservations/{reservation}</c>.
            /// </summary>
            ProjectZoneReservation = 1,
        }

        private static gax::PathTemplate s_projectZoneReservation = new gax::PathTemplate("projects/{project}/zones/{zone}/reservations/{reservation}");

        /// <summary>Creates a <see cref="ReservationName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ReservationName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ReservationName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ReservationName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ReservationName"/> with the pattern
        /// <c>projects/{project}/zones/{zone}/reservations/{reservation}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="zoneId">The <c>Zone</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="reservationId">The <c>Reservation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ReservationName"/> constructed from the provided ids.</returns>
        public static ReservationName FromProjectZoneReservation(string projectId, string zoneId, string reservationId) =>
            new ReservationName(ResourceNameType.ProjectZoneReservation, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), zoneId: gax::GaxPreconditions.CheckNotNullOrEmpty(zoneId, nameof(zoneId)), reservationId: gax::GaxPreconditions.CheckNotNullOrEmpty(reservationId, nameof(reservationId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ReservationName"/> with pattern
        /// <c>projects/{project}/zones/{zone}/reservations/{reservation}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="zoneId">The <c>Zone</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="reservationId">The <c>Reservation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ReservationName"/> with pattern
        /// <c>projects/{project}/zones/{zone}/reservations/{reservation}</c>.
        /// </returns>
        public static string Format(string projectId, string zoneId, string reservationId) =>
            FormatProjectZoneReservation(projectId, zoneId, reservationId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ReservationName"/> with pattern
        /// <c>projects/{project}/zones/{zone}/reservations/{reservation}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="zoneId">The <c>Zone</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="reservationId">The <c>Reservation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ReservationName"/> with pattern
        /// <c>projects/{project}/zones/{zone}/reservations/{reservation}</c>.
        /// </returns>
        public static string FormatProjectZoneReservation(string projectId, string zoneId, string reservationId) =>
            s_projectZoneReservation.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(zoneId, nameof(zoneId)), gax::GaxPreconditions.CheckNotNullOrEmpty(reservationId, nameof(reservationId)));

        /// <summary>Parses the given resource name string into a new <see cref="ReservationName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/zones/{zone}/reservations/{reservation}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="reservationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ReservationName"/> if successful.</returns>
        public static ReservationName Parse(string reservationName) => Parse(reservationName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ReservationName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/zones/{zone}/reservations/{reservation}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="reservationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ReservationName"/> if successful.</returns>
        public static ReservationName Parse(string reservationName, bool allowUnparsed) =>
            TryParse(reservationName, allowUnparsed, out ReservationName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ReservationName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/zones/{zone}/reservations/{reservation}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="reservationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ReservationName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string reservationName, out ReservationName result) =>
            TryParse(reservationName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ReservationName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/zones/{zone}/reservations/{reservation}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="reservationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ReservationName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string reservationName, bool allowUnparsed, out ReservationName result)
        {
            gax::GaxPreconditions.CheckNotNull(reservationName, nameof(reservationName));
            gax::TemplatedResourceName resourceName;
            if (s_projectZoneReservation.TryParseName(reservationName, out resourceName))
            {
                result = FromProjectZoneReservation(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(reservationName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ReservationName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string projectId = null, string reservationId = null, string zoneId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ProjectId = projectId;
            ReservationId = reservationId;
            ZoneId = zoneId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ReservationName"/> class from the component parts of pattern
        /// <c>projects/{project}/zones/{zone}/reservations/{reservation}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="zoneId">The <c>Zone</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="reservationId">The <c>Reservation</c> ID. Must not be <c>null</c> or empty.</param>
        public ReservationName(string projectId, string zoneId, string reservationId) : this(ResourceNameType.ProjectZoneReservation, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), zoneId: gax::GaxPreconditions.CheckNotNullOrEmpty(zoneId, nameof(zoneId)), reservationId: gax::GaxPreconditions.CheckNotNullOrEmpty(reservationId, nameof(reservationId)))
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
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Reservation</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ReservationId { get; }

        /// <summary>
        /// The <c>Zone</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ZoneId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectZoneReservation: return s_projectZoneReservation.Expand(ProjectId, ZoneId, ReservationId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ReservationName);

        /// <inheritdoc/>
        public bool Equals(ReservationName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ReservationName a, ReservationName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ReservationName a, ReservationName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>ReservationBlock</c> resource.</summary>
    public sealed partial class ReservationBlockName : gax::IResourceName, sys::IEquatable<ReservationBlockName>
    {
        /// <summary>The possible contents of <see cref="ReservationBlockName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/zones/{zone}/reservations/{reservation}/reservationBlocks/{reservation_block}</c>.
            /// </summary>
            ProjectZoneReservationReservationBlock = 1,
        }

        private static gax::PathTemplate s_projectZoneReservationReservationBlock = new gax::PathTemplate("projects/{project}/zones/{zone}/reservations/{reservation}/reservationBlocks/{reservation_block}");

        /// <summary>Creates a <see cref="ReservationBlockName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ReservationBlockName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ReservationBlockName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ReservationBlockName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ReservationBlockName"/> with the pattern
        /// <c>projects/{project}/zones/{zone}/reservations/{reservation}/reservationBlocks/{reservation_block}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="zoneId">The <c>Zone</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="reservationId">The <c>Reservation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="reservationBlockId">The <c>ReservationBlock</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ReservationBlockName"/> constructed from the provided ids.</returns>
        public static ReservationBlockName FromProjectZoneReservationReservationBlock(string projectId, string zoneId, string reservationId, string reservationBlockId) =>
            new ReservationBlockName(ResourceNameType.ProjectZoneReservationReservationBlock, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), zoneId: gax::GaxPreconditions.CheckNotNullOrEmpty(zoneId, nameof(zoneId)), reservationId: gax::GaxPreconditions.CheckNotNullOrEmpty(reservationId, nameof(reservationId)), reservationBlockId: gax::GaxPreconditions.CheckNotNullOrEmpty(reservationBlockId, nameof(reservationBlockId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ReservationBlockName"/> with pattern
        /// <c>projects/{project}/zones/{zone}/reservations/{reservation}/reservationBlocks/{reservation_block}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="zoneId">The <c>Zone</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="reservationId">The <c>Reservation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="reservationBlockId">The <c>ReservationBlock</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ReservationBlockName"/> with pattern
        /// <c>projects/{project}/zones/{zone}/reservations/{reservation}/reservationBlocks/{reservation_block}</c>.
        /// </returns>
        public static string Format(string projectId, string zoneId, string reservationId, string reservationBlockId) =>
            FormatProjectZoneReservationReservationBlock(projectId, zoneId, reservationId, reservationBlockId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ReservationBlockName"/> with pattern
        /// <c>projects/{project}/zones/{zone}/reservations/{reservation}/reservationBlocks/{reservation_block}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="zoneId">The <c>Zone</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="reservationId">The <c>Reservation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="reservationBlockId">The <c>ReservationBlock</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ReservationBlockName"/> with pattern
        /// <c>projects/{project}/zones/{zone}/reservations/{reservation}/reservationBlocks/{reservation_block}</c>.
        /// </returns>
        public static string FormatProjectZoneReservationReservationBlock(string projectId, string zoneId, string reservationId, string reservationBlockId) =>
            s_projectZoneReservationReservationBlock.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(zoneId, nameof(zoneId)), gax::GaxPreconditions.CheckNotNullOrEmpty(reservationId, nameof(reservationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(reservationBlockId, nameof(reservationBlockId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ReservationBlockName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/zones/{zone}/reservations/{reservation}/reservationBlocks/{reservation_block}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="reservationBlockName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ReservationBlockName"/> if successful.</returns>
        public static ReservationBlockName Parse(string reservationBlockName) => Parse(reservationBlockName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ReservationBlockName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/zones/{zone}/reservations/{reservation}/reservationBlocks/{reservation_block}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="reservationBlockName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ReservationBlockName"/> if successful.</returns>
        public static ReservationBlockName Parse(string reservationBlockName, bool allowUnparsed) =>
            TryParse(reservationBlockName, allowUnparsed, out ReservationBlockName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ReservationBlockName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/zones/{zone}/reservations/{reservation}/reservationBlocks/{reservation_block}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="reservationBlockName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ReservationBlockName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string reservationBlockName, out ReservationBlockName result) =>
            TryParse(reservationBlockName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ReservationBlockName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/zones/{zone}/reservations/{reservation}/reservationBlocks/{reservation_block}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="reservationBlockName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ReservationBlockName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string reservationBlockName, bool allowUnparsed, out ReservationBlockName result)
        {
            gax::GaxPreconditions.CheckNotNull(reservationBlockName, nameof(reservationBlockName));
            gax::TemplatedResourceName resourceName;
            if (s_projectZoneReservationReservationBlock.TryParseName(reservationBlockName, out resourceName))
            {
                result = FromProjectZoneReservationReservationBlock(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(reservationBlockName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ReservationBlockName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string projectId = null, string reservationId = null, string reservationBlockId = null, string zoneId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ProjectId = projectId;
            ReservationId = reservationId;
            ReservationBlockId = reservationBlockId;
            ZoneId = zoneId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ReservationBlockName"/> class from the component parts of pattern
        /// <c>projects/{project}/zones/{zone}/reservations/{reservation}/reservationBlocks/{reservation_block}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="zoneId">The <c>Zone</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="reservationId">The <c>Reservation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="reservationBlockId">The <c>ReservationBlock</c> ID. Must not be <c>null</c> or empty.</param>
        public ReservationBlockName(string projectId, string zoneId, string reservationId, string reservationBlockId) : this(ResourceNameType.ProjectZoneReservationReservationBlock, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), zoneId: gax::GaxPreconditions.CheckNotNullOrEmpty(zoneId, nameof(zoneId)), reservationId: gax::GaxPreconditions.CheckNotNullOrEmpty(reservationId, nameof(reservationId)), reservationBlockId: gax::GaxPreconditions.CheckNotNullOrEmpty(reservationBlockId, nameof(reservationBlockId)))
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
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Reservation</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ReservationId { get; }

        /// <summary>
        /// The <c>ReservationBlock</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string ReservationBlockId { get; }

        /// <summary>
        /// The <c>Zone</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ZoneId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectZoneReservationReservationBlock: return s_projectZoneReservationReservationBlock.Expand(ProjectId, ZoneId, ReservationId, ReservationBlockId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ReservationBlockName);

        /// <inheritdoc/>
        public bool Equals(ReservationBlockName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ReservationBlockName a, ReservationBlockName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ReservationBlockName a, ReservationBlockName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>ReservationSubBlock</c> resource.</summary>
    public sealed partial class ReservationSubBlockName : gax::IResourceName, sys::IEquatable<ReservationSubBlockName>
    {
        /// <summary>The possible contents of <see cref="ReservationSubBlockName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// projects/{project}/zones/{zone}/reservations/{reservation}/reservationBlocks/{reservation_block}/reservationSubBlocks/{reservation_sub_block}</c>
            /// .
            /// </summary>
            ProjectZoneReservationReservationBlockReservationSubBlock = 1,
        }

        private static gax::PathTemplate s_projectZoneReservationReservationBlockReservationSubBlock = new gax::PathTemplate("projects/{project}/zones/{zone}/reservations/{reservation}/reservationBlocks/{reservation_block}/reservationSubBlocks/{reservation_sub_block}");

        /// <summary>Creates a <see cref="ReservationSubBlockName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ReservationSubBlockName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ReservationSubBlockName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ReservationSubBlockName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ReservationSubBlockName"/> with the pattern
        /// <c>
        /// projects/{project}/zones/{zone}/reservations/{reservation}/reservationBlocks/{reservation_block}/reservationSubBlocks/{reservation_sub_block}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="zoneId">The <c>Zone</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="reservationId">The <c>Reservation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="reservationBlockId">The <c>ReservationBlock</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="reservationSubBlockId">
        /// The <c>ReservationSubBlock</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="ReservationSubBlockName"/> constructed from the provided ids.
        /// </returns>
        public static ReservationSubBlockName FromProjectZoneReservationReservationBlockReservationSubBlock(string projectId, string zoneId, string reservationId, string reservationBlockId, string reservationSubBlockId) =>
            new ReservationSubBlockName(ResourceNameType.ProjectZoneReservationReservationBlockReservationSubBlock, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), zoneId: gax::GaxPreconditions.CheckNotNullOrEmpty(zoneId, nameof(zoneId)), reservationId: gax::GaxPreconditions.CheckNotNullOrEmpty(reservationId, nameof(reservationId)), reservationBlockId: gax::GaxPreconditions.CheckNotNullOrEmpty(reservationBlockId, nameof(reservationBlockId)), reservationSubBlockId: gax::GaxPreconditions.CheckNotNullOrEmpty(reservationSubBlockId, nameof(reservationSubBlockId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ReservationSubBlockName"/> with pattern
        /// <c>
        /// projects/{project}/zones/{zone}/reservations/{reservation}/reservationBlocks/{reservation_block}/reservationSubBlocks/{reservation_sub_block}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="zoneId">The <c>Zone</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="reservationId">The <c>Reservation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="reservationBlockId">The <c>ReservationBlock</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="reservationSubBlockId">
        /// The <c>ReservationSubBlock</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="ReservationSubBlockName"/> with pattern
        /// <c>
        /// projects/{project}/zones/{zone}/reservations/{reservation}/reservationBlocks/{reservation_block}/reservationSubBlocks/{reservation_sub_block}</c>
        /// .
        /// </returns>
        public static string Format(string projectId, string zoneId, string reservationId, string reservationBlockId, string reservationSubBlockId) =>
            FormatProjectZoneReservationReservationBlockReservationSubBlock(projectId, zoneId, reservationId, reservationBlockId, reservationSubBlockId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ReservationSubBlockName"/> with pattern
        /// <c>
        /// projects/{project}/zones/{zone}/reservations/{reservation}/reservationBlocks/{reservation_block}/reservationSubBlocks/{reservation_sub_block}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="zoneId">The <c>Zone</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="reservationId">The <c>Reservation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="reservationBlockId">The <c>ReservationBlock</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="reservationSubBlockId">
        /// The <c>ReservationSubBlock</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="ReservationSubBlockName"/> with pattern
        /// <c>
        /// projects/{project}/zones/{zone}/reservations/{reservation}/reservationBlocks/{reservation_block}/reservationSubBlocks/{reservation_sub_block}</c>
        /// .
        /// </returns>
        public static string FormatProjectZoneReservationReservationBlockReservationSubBlock(string projectId, string zoneId, string reservationId, string reservationBlockId, string reservationSubBlockId) =>
            s_projectZoneReservationReservationBlockReservationSubBlock.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(zoneId, nameof(zoneId)), gax::GaxPreconditions.CheckNotNullOrEmpty(reservationId, nameof(reservationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(reservationBlockId, nameof(reservationBlockId)), gax::GaxPreconditions.CheckNotNullOrEmpty(reservationSubBlockId, nameof(reservationSubBlockId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ReservationSubBlockName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/zones/{zone}/reservations/{reservation}/reservationBlocks/{reservation_block}/reservationSubBlocks/{reservation_sub_block}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="reservationSubBlockName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ReservationSubBlockName"/> if successful.</returns>
        public static ReservationSubBlockName Parse(string reservationSubBlockName) => Parse(reservationSubBlockName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ReservationSubBlockName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/zones/{zone}/reservations/{reservation}/reservationBlocks/{reservation_block}/reservationSubBlocks/{reservation_sub_block}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="reservationSubBlockName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ReservationSubBlockName"/> if successful.</returns>
        public static ReservationSubBlockName Parse(string reservationSubBlockName, bool allowUnparsed) =>
            TryParse(reservationSubBlockName, allowUnparsed, out ReservationSubBlockName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ReservationSubBlockName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/zones/{zone}/reservations/{reservation}/reservationBlocks/{reservation_block}/reservationSubBlocks/{reservation_sub_block}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="reservationSubBlockName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ReservationSubBlockName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string reservationSubBlockName, out ReservationSubBlockName result) =>
            TryParse(reservationSubBlockName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ReservationSubBlockName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/zones/{zone}/reservations/{reservation}/reservationBlocks/{reservation_block}/reservationSubBlocks/{reservation_sub_block}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="reservationSubBlockName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ReservationSubBlockName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string reservationSubBlockName, bool allowUnparsed, out ReservationSubBlockName result)
        {
            gax::GaxPreconditions.CheckNotNull(reservationSubBlockName, nameof(reservationSubBlockName));
            gax::TemplatedResourceName resourceName;
            if (s_projectZoneReservationReservationBlockReservationSubBlock.TryParseName(reservationSubBlockName, out resourceName))
            {
                result = FromProjectZoneReservationReservationBlockReservationSubBlock(resourceName[0], resourceName[1], resourceName[2], resourceName[3], resourceName[4]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(reservationSubBlockName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ReservationSubBlockName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string projectId = null, string reservationId = null, string reservationBlockId = null, string reservationSubBlockId = null, string zoneId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ProjectId = projectId;
            ReservationId = reservationId;
            ReservationBlockId = reservationBlockId;
            ReservationSubBlockId = reservationSubBlockId;
            ZoneId = zoneId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ReservationSubBlockName"/> class from the component parts of
        /// pattern
        /// <c>
        /// projects/{project}/zones/{zone}/reservations/{reservation}/reservationBlocks/{reservation_block}/reservationSubBlocks/{reservation_sub_block}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="zoneId">The <c>Zone</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="reservationId">The <c>Reservation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="reservationBlockId">The <c>ReservationBlock</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="reservationSubBlockId">
        /// The <c>ReservationSubBlock</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public ReservationSubBlockName(string projectId, string zoneId, string reservationId, string reservationBlockId, string reservationSubBlockId) : this(ResourceNameType.ProjectZoneReservationReservationBlockReservationSubBlock, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), zoneId: gax::GaxPreconditions.CheckNotNullOrEmpty(zoneId, nameof(zoneId)), reservationId: gax::GaxPreconditions.CheckNotNullOrEmpty(reservationId, nameof(reservationId)), reservationBlockId: gax::GaxPreconditions.CheckNotNullOrEmpty(reservationBlockId, nameof(reservationBlockId)), reservationSubBlockId: gax::GaxPreconditions.CheckNotNullOrEmpty(reservationSubBlockId, nameof(reservationSubBlockId)))
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
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Reservation</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ReservationId { get; }

        /// <summary>
        /// The <c>ReservationBlock</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string ReservationBlockId { get; }

        /// <summary>
        /// The <c>ReservationSubBlock</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string ReservationSubBlockId { get; }

        /// <summary>
        /// The <c>Zone</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ZoneId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectZoneReservationReservationBlockReservationSubBlock: return s_projectZoneReservationReservationBlockReservationSubBlock.Expand(ProjectId, ZoneId, ReservationId, ReservationBlockId, ReservationSubBlockId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ReservationSubBlockName);

        /// <inheritdoc/>
        public bool Equals(ReservationSubBlockName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ReservationSubBlockName a, ReservationSubBlockName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ReservationSubBlockName a, ReservationSubBlockName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Snapshot</c> resource.</summary>
    public sealed partial class SnapshotName : gax::IResourceName, sys::IEquatable<SnapshotName>
    {
        /// <summary>The possible contents of <see cref="SnapshotName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>projects/{project}/global/snapshots/{snapshot}</c>.</summary>
            ProjectSnapshot = 1,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/regions/{region}/snapshots/{snapshot}</c>.
            /// </summary>
            ProjectRegionSnapshot = 2,
        }

        private static gax::PathTemplate s_projectSnapshot = new gax::PathTemplate("projects/{project}/global/snapshots/{snapshot}");

        private static gax::PathTemplate s_projectRegionSnapshot = new gax::PathTemplate("projects/{project}/regions/{region}/snapshots/{snapshot}");

        /// <summary>Creates a <see cref="SnapshotName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="SnapshotName"/> containing the provided <paramref name="unparsedResourceName"/>
        /// .
        /// </returns>
        public static SnapshotName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new SnapshotName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="SnapshotName"/> with the pattern <c>projects/{project}/global/snapshots/{snapshot}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="snapshotId">The <c>Snapshot</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="SnapshotName"/> constructed from the provided ids.</returns>
        public static SnapshotName FromProjectSnapshot(string projectId, string snapshotId) =>
            new SnapshotName(ResourceNameType.ProjectSnapshot, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), snapshotId: gax::GaxPreconditions.CheckNotNullOrEmpty(snapshotId, nameof(snapshotId)));

        /// <summary>
        /// Creates a <see cref="SnapshotName"/> with the pattern
        /// <c>projects/{project}/regions/{region}/snapshots/{snapshot}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="regionId">The <c>Region</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="snapshotId">The <c>Snapshot</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="SnapshotName"/> constructed from the provided ids.</returns>
        public static SnapshotName FromProjectRegionSnapshot(string projectId, string regionId, string snapshotId) =>
            new SnapshotName(ResourceNameType.ProjectRegionSnapshot, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), regionId: gax::GaxPreconditions.CheckNotNullOrEmpty(regionId, nameof(regionId)), snapshotId: gax::GaxPreconditions.CheckNotNullOrEmpty(snapshotId, nameof(snapshotId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SnapshotName"/> with pattern
        /// <c>projects/{project}/global/snapshots/{snapshot}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="snapshotId">The <c>Snapshot</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SnapshotName"/> with pattern
        /// <c>projects/{project}/global/snapshots/{snapshot}</c>.
        /// </returns>
        public static string Format(string projectId, string snapshotId) => FormatProjectSnapshot(projectId, snapshotId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SnapshotName"/> with pattern
        /// <c>projects/{project}/global/snapshots/{snapshot}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="snapshotId">The <c>Snapshot</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SnapshotName"/> with pattern
        /// <c>projects/{project}/global/snapshots/{snapshot}</c>.
        /// </returns>
        public static string FormatProjectSnapshot(string projectId, string snapshotId) =>
            s_projectSnapshot.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(snapshotId, nameof(snapshotId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SnapshotName"/> with pattern
        /// <c>projects/{project}/regions/{region}/snapshots/{snapshot}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="regionId">The <c>Region</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="snapshotId">The <c>Snapshot</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SnapshotName"/> with pattern
        /// <c>projects/{project}/regions/{region}/snapshots/{snapshot}</c>.
        /// </returns>
        public static string FormatProjectRegionSnapshot(string projectId, string regionId, string snapshotId) =>
            s_projectRegionSnapshot.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(regionId, nameof(regionId)), gax::GaxPreconditions.CheckNotNullOrEmpty(snapshotId, nameof(snapshotId)));

        /// <summary>Parses the given resource name string into a new <see cref="SnapshotName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/global/snapshots/{snapshot}</c></description></item>
        /// <item><description><c>projects/{project}/regions/{region}/snapshots/{snapshot}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="snapshotName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="SnapshotName"/> if successful.</returns>
        public static SnapshotName Parse(string snapshotName) => Parse(snapshotName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="SnapshotName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/global/snapshots/{snapshot}</c></description></item>
        /// <item><description><c>projects/{project}/regions/{region}/snapshots/{snapshot}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="snapshotName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="SnapshotName"/> if successful.</returns>
        public static SnapshotName Parse(string snapshotName, bool allowUnparsed) =>
            TryParse(snapshotName, allowUnparsed, out SnapshotName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SnapshotName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/global/snapshots/{snapshot}</c></description></item>
        /// <item><description><c>projects/{project}/regions/{region}/snapshots/{snapshot}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="snapshotName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SnapshotName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string snapshotName, out SnapshotName result) => TryParse(snapshotName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SnapshotName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/global/snapshots/{snapshot}</c></description></item>
        /// <item><description><c>projects/{project}/regions/{region}/snapshots/{snapshot}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="snapshotName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SnapshotName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string snapshotName, bool allowUnparsed, out SnapshotName result)
        {
            gax::GaxPreconditions.CheckNotNull(snapshotName, nameof(snapshotName));
            gax::TemplatedResourceName resourceName;
            if (s_projectSnapshot.TryParseName(snapshotName, out resourceName))
            {
                result = FromProjectSnapshot(resourceName[0], resourceName[1]);
                return true;
            }
            if (s_projectRegionSnapshot.TryParseName(snapshotName, out resourceName))
            {
                result = FromProjectRegionSnapshot(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(snapshotName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private SnapshotName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string projectId = null, string regionId = null, string snapshotId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ProjectId = projectId;
            RegionId = regionId;
            SnapshotId = snapshotId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="SnapshotName"/> class from the component parts of pattern
        /// <c>projects/{project}/global/snapshots/{snapshot}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="snapshotId">The <c>Snapshot</c> ID. Must not be <c>null</c> or empty.</param>
        public SnapshotName(string projectId, string snapshotId) : this(ResourceNameType.ProjectSnapshot, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), snapshotId: gax::GaxPreconditions.CheckNotNullOrEmpty(snapshotId, nameof(snapshotId)))
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
        /// The <c>Region</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string RegionId { get; }

        /// <summary>
        /// The <c>Snapshot</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string SnapshotId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectSnapshot: return s_projectSnapshot.Expand(ProjectId, SnapshotId);
                case ResourceNameType.ProjectRegionSnapshot: return s_projectRegionSnapshot.Expand(ProjectId, RegionId, SnapshotId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as SnapshotName);

        /// <inheritdoc/>
        public bool Equals(SnapshotName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(SnapshotName a, SnapshotName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(SnapshotName a, SnapshotName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Subnetwork</c> resource.</summary>
    public sealed partial class SubnetworkName : gax::IResourceName, sys::IEquatable<SubnetworkName>
    {
        /// <summary>The possible contents of <see cref="SubnetworkName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/regions/{region}/subnetworks/{subnetwork}</c>.
            /// </summary>
            ProjectRegionSubnetwork = 1,
        }

        private static gax::PathTemplate s_projectRegionSubnetwork = new gax::PathTemplate("projects/{project}/regions/{region}/subnetworks/{subnetwork}");

        /// <summary>Creates a <see cref="SubnetworkName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="SubnetworkName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static SubnetworkName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new SubnetworkName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="SubnetworkName"/> with the pattern
        /// <c>projects/{project}/regions/{region}/subnetworks/{subnetwork}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="regionId">The <c>Region</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="subnetworkId">The <c>Subnetwork</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="SubnetworkName"/> constructed from the provided ids.</returns>
        public static SubnetworkName FromProjectRegionSubnetwork(string projectId, string regionId, string subnetworkId) =>
            new SubnetworkName(ResourceNameType.ProjectRegionSubnetwork, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), regionId: gax::GaxPreconditions.CheckNotNullOrEmpty(regionId, nameof(regionId)), subnetworkId: gax::GaxPreconditions.CheckNotNullOrEmpty(subnetworkId, nameof(subnetworkId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SubnetworkName"/> with pattern
        /// <c>projects/{project}/regions/{region}/subnetworks/{subnetwork}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="regionId">The <c>Region</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="subnetworkId">The <c>Subnetwork</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SubnetworkName"/> with pattern
        /// <c>projects/{project}/regions/{region}/subnetworks/{subnetwork}</c>.
        /// </returns>
        public static string Format(string projectId, string regionId, string subnetworkId) =>
            FormatProjectRegionSubnetwork(projectId, regionId, subnetworkId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SubnetworkName"/> with pattern
        /// <c>projects/{project}/regions/{region}/subnetworks/{subnetwork}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="regionId">The <c>Region</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="subnetworkId">The <c>Subnetwork</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SubnetworkName"/> with pattern
        /// <c>projects/{project}/regions/{region}/subnetworks/{subnetwork}</c>.
        /// </returns>
        public static string FormatProjectRegionSubnetwork(string projectId, string regionId, string subnetworkId) =>
            s_projectRegionSubnetwork.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(regionId, nameof(regionId)), gax::GaxPreconditions.CheckNotNullOrEmpty(subnetworkId, nameof(subnetworkId)));

        /// <summary>Parses the given resource name string into a new <see cref="SubnetworkName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/regions/{region}/subnetworks/{subnetwork}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="subnetworkName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="SubnetworkName"/> if successful.</returns>
        public static SubnetworkName Parse(string subnetworkName) => Parse(subnetworkName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="SubnetworkName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/regions/{region}/subnetworks/{subnetwork}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="subnetworkName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="SubnetworkName"/> if successful.</returns>
        public static SubnetworkName Parse(string subnetworkName, bool allowUnparsed) =>
            TryParse(subnetworkName, allowUnparsed, out SubnetworkName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SubnetworkName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/regions/{region}/subnetworks/{subnetwork}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="subnetworkName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SubnetworkName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string subnetworkName, out SubnetworkName result) =>
            TryParse(subnetworkName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SubnetworkName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/regions/{region}/subnetworks/{subnetwork}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="subnetworkName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SubnetworkName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string subnetworkName, bool allowUnparsed, out SubnetworkName result)
        {
            gax::GaxPreconditions.CheckNotNull(subnetworkName, nameof(subnetworkName));
            gax::TemplatedResourceName resourceName;
            if (s_projectRegionSubnetwork.TryParseName(subnetworkName, out resourceName))
            {
                result = FromProjectRegionSubnetwork(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(subnetworkName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private SubnetworkName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string projectId = null, string regionId = null, string subnetworkId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ProjectId = projectId;
            RegionId = regionId;
            SubnetworkId = subnetworkId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="SubnetworkName"/> class from the component parts of pattern
        /// <c>projects/{project}/regions/{region}/subnetworks/{subnetwork}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="regionId">The <c>Region</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="subnetworkId">The <c>Subnetwork</c> ID. Must not be <c>null</c> or empty.</param>
        public SubnetworkName(string projectId, string regionId, string subnetworkId) : this(ResourceNameType.ProjectRegionSubnetwork, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), regionId: gax::GaxPreconditions.CheckNotNullOrEmpty(regionId, nameof(regionId)), subnetworkId: gax::GaxPreconditions.CheckNotNullOrEmpty(subnetworkId, nameof(subnetworkId)))
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
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Region</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string RegionId { get; }

        /// <summary>
        /// The <c>Subnetwork</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string SubnetworkId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectRegionSubnetwork: return s_projectRegionSubnetwork.Expand(ProjectId, RegionId, SubnetworkId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as SubnetworkName);

        /// <inheritdoc/>
        public bool Equals(SubnetworkName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(SubnetworkName a, SubnetworkName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(SubnetworkName a, SubnetworkName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>FileInstance</c> resource.</summary>
    public sealed partial class FileInstanceName : gax::IResourceName, sys::IEquatable<FileInstanceName>
    {
        /// <summary>The possible contents of <see cref="FileInstanceName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/instances/{instance}</c>.
            /// </summary>
            ProjectLocationInstance = 1,
        }

        private static gax::PathTemplate s_projectLocationInstance = new gax::PathTemplate("projects/{project}/locations/{location}/instances/{instance}");

        /// <summary>Creates a <see cref="FileInstanceName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="FileInstanceName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static FileInstanceName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new FileInstanceName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="FileInstanceName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="FileInstanceName"/> constructed from the provided ids.</returns>
        public static FileInstanceName FromProjectLocationInstance(string projectId, string locationId, string instanceId) =>
            new FileInstanceName(ResourceNameType.ProjectLocationInstance, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), instanceId: gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="FileInstanceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="FileInstanceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string instanceId) =>
            FormatProjectLocationInstance(projectId, locationId, instanceId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="FileInstanceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="FileInstanceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}</c>.
        /// </returns>
        public static string FormatProjectLocationInstance(string projectId, string locationId, string instanceId) =>
            s_projectLocationInstance.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)));

        /// <summary>Parses the given resource name string into a new <see cref="FileInstanceName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/instances/{instance}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="fileInstanceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="FileInstanceName"/> if successful.</returns>
        public static FileInstanceName Parse(string fileInstanceName) => Parse(fileInstanceName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="FileInstanceName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/instances/{instance}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="fileInstanceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="FileInstanceName"/> if successful.</returns>
        public static FileInstanceName Parse(string fileInstanceName, bool allowUnparsed) =>
            TryParse(fileInstanceName, allowUnparsed, out FileInstanceName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="FileInstanceName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/instances/{instance}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="fileInstanceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="FileInstanceName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string fileInstanceName, out FileInstanceName result) =>
            TryParse(fileInstanceName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="FileInstanceName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/instances/{instance}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="fileInstanceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="FileInstanceName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string fileInstanceName, bool allowUnparsed, out FileInstanceName result)
        {
            gax::GaxPreconditions.CheckNotNull(fileInstanceName, nameof(fileInstanceName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationInstance.TryParseName(fileInstanceName, out resourceName))
            {
                result = FromProjectLocationInstance(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(fileInstanceName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private FileInstanceName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string instanceId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            InstanceId = instanceId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="FileInstanceName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        public FileInstanceName(string projectId, string locationId, string instanceId) : this(ResourceNameType.ProjectLocationInstance, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), instanceId: gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)))
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
        /// The <c>Instance</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string InstanceId { get; }

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
                case ResourceNameType.ProjectLocationInstance: return s_projectLocationInstance.Expand(ProjectId, LocationId, InstanceId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as FileInstanceName);

        /// <inheritdoc/>
        public bool Equals(FileInstanceName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(FileInstanceName a, FileInstanceName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(FileInstanceName a, FileInstanceName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Bucket</c> resource.</summary>
    public sealed partial class BucketName : gax::IResourceName, sys::IEquatable<BucketName>
    {
        /// <summary>The possible contents of <see cref="BucketName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>projects/{project}/buckets/{bucket}</c>.</summary>
            ProjectBucket = 1,
        }

        private static gax::PathTemplate s_projectBucket = new gax::PathTemplate("projects/{project}/buckets/{bucket}");

        /// <summary>Creates a <see cref="BucketName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="BucketName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static BucketName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new BucketName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="BucketName"/> with the pattern <c>projects/{project}/buckets/{bucket}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="bucketId">The <c>Bucket</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="BucketName"/> constructed from the provided ids.</returns>
        public static BucketName FromProjectBucket(string projectId, string bucketId) =>
            new BucketName(ResourceNameType.ProjectBucket, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), bucketId: gax::GaxPreconditions.CheckNotNullOrEmpty(bucketId, nameof(bucketId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="BucketName"/> with pattern
        /// <c>projects/{project}/buckets/{bucket}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="bucketId">The <c>Bucket</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="BucketName"/> with pattern
        /// <c>projects/{project}/buckets/{bucket}</c>.
        /// </returns>
        public static string Format(string projectId, string bucketId) => FormatProjectBucket(projectId, bucketId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="BucketName"/> with pattern
        /// <c>projects/{project}/buckets/{bucket}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="bucketId">The <c>Bucket</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="BucketName"/> with pattern
        /// <c>projects/{project}/buckets/{bucket}</c>.
        /// </returns>
        public static string FormatProjectBucket(string projectId, string bucketId) =>
            s_projectBucket.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(bucketId, nameof(bucketId)));

        /// <summary>Parses the given resource name string into a new <see cref="BucketName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/buckets/{bucket}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="bucketName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="BucketName"/> if successful.</returns>
        public static BucketName Parse(string bucketName) => Parse(bucketName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="BucketName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/buckets/{bucket}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="bucketName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="BucketName"/> if successful.</returns>
        public static BucketName Parse(string bucketName, bool allowUnparsed) =>
            TryParse(bucketName, allowUnparsed, out BucketName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="BucketName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/buckets/{bucket}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="bucketName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="BucketName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string bucketName, out BucketName result) => TryParse(bucketName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="BucketName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/buckets/{bucket}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="bucketName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="BucketName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string bucketName, bool allowUnparsed, out BucketName result)
        {
            gax::GaxPreconditions.CheckNotNull(bucketName, nameof(bucketName));
            gax::TemplatedResourceName resourceName;
            if (s_projectBucket.TryParseName(bucketName, out resourceName))
            {
                result = FromProjectBucket(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(bucketName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private BucketName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string bucketId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            BucketId = bucketId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="BucketName"/> class from the component parts of pattern
        /// <c>projects/{project}/buckets/{bucket}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="bucketId">The <c>Bucket</c> ID. Must not be <c>null</c> or empty.</param>
        public BucketName(string projectId, string bucketId) : this(ResourceNameType.ProjectBucket, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), bucketId: gax::GaxPreconditions.CheckNotNullOrEmpty(bucketId, nameof(bucketId)))
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
        /// The <c>Bucket</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string BucketId { get; }

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
                case ResourceNameType.ProjectBucket: return s_projectBucket.Expand(ProjectId, BucketId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as BucketName);

        /// <inheritdoc/>
        public bool Equals(BucketName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(BucketName a, BucketName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(BucketName a, BucketName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Pod</c> resource.</summary>
    public sealed partial class PodName : gax::IResourceName, sys::IEquatable<PodName>
    {
        /// <summary>The possible contents of <see cref="PodName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/clusters/{cluster}/k8s/namespaces/{namespace}/pods/{pod}</c>.
            /// </summary>
            ProjectLocationClusterNamespacePod = 1,
        }

        private static gax::PathTemplate s_projectLocationClusterNamespacePod = new gax::PathTemplate("projects/{project}/locations/{location}/clusters/{cluster}/k8s/namespaces/{namespace}/pods/{pod}");

        /// <summary>Creates a <see cref="PodName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="PodName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static PodName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new PodName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="PodName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/clusters/{cluster}/k8s/namespaces/{namespace}/pods/{pod}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="clusterId">The <c>Cluster</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="namespaceId">The <c>Namespace</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="podId">The <c>Pod</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="PodName"/> constructed from the provided ids.</returns>
        public static PodName FromProjectLocationClusterNamespacePod(string projectId, string locationId, string clusterId, string namespaceId, string podId) =>
            new PodName(ResourceNameType.ProjectLocationClusterNamespacePod, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), clusterId: gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)), namespaceId: gax::GaxPreconditions.CheckNotNullOrEmpty(namespaceId, nameof(namespaceId)), podId: gax::GaxPreconditions.CheckNotNullOrEmpty(podId, nameof(podId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="PodName"/> with pattern
        /// <c>projects/{project}/locations/{location}/clusters/{cluster}/k8s/namespaces/{namespace}/pods/{pod}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="clusterId">The <c>Cluster</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="namespaceId">The <c>Namespace</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="podId">The <c>Pod</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="PodName"/> with pattern
        /// <c>projects/{project}/locations/{location}/clusters/{cluster}/k8s/namespaces/{namespace}/pods/{pod}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string clusterId, string namespaceId, string podId) =>
            FormatProjectLocationClusterNamespacePod(projectId, locationId, clusterId, namespaceId, podId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="PodName"/> with pattern
        /// <c>projects/{project}/locations/{location}/clusters/{cluster}/k8s/namespaces/{namespace}/pods/{pod}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="clusterId">The <c>Cluster</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="namespaceId">The <c>Namespace</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="podId">The <c>Pod</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="PodName"/> with pattern
        /// <c>projects/{project}/locations/{location}/clusters/{cluster}/k8s/namespaces/{namespace}/pods/{pod}</c>.
        /// </returns>
        public static string FormatProjectLocationClusterNamespacePod(string projectId, string locationId, string clusterId, string namespaceId, string podId) =>
            s_projectLocationClusterNamespacePod.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)), gax::GaxPreconditions.CheckNotNullOrEmpty(namespaceId, nameof(namespaceId)), gax::GaxPreconditions.CheckNotNullOrEmpty(podId, nameof(podId)));

        /// <summary>Parses the given resource name string into a new <see cref="PodName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/clusters/{cluster}/k8s/namespaces/{namespace}/pods/{pod}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="podName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="PodName"/> if successful.</returns>
        public static PodName Parse(string podName) => Parse(podName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="PodName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/clusters/{cluster}/k8s/namespaces/{namespace}/pods/{pod}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="podName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="PodName"/> if successful.</returns>
        public static PodName Parse(string podName, bool allowUnparsed) =>
            TryParse(podName, allowUnparsed, out PodName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>Tries to parse the given resource name string into a new <see cref="PodName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/clusters/{cluster}/k8s/namespaces/{namespace}/pods/{pod}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="podName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="PodName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string podName, out PodName result) => TryParse(podName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="PodName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/clusters/{cluster}/k8s/namespaces/{namespace}/pods/{pod}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="podName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="PodName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string podName, bool allowUnparsed, out PodName result)
        {
            gax::GaxPreconditions.CheckNotNull(podName, nameof(podName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationClusterNamespacePod.TryParseName(podName, out resourceName))
            {
                result = FromProjectLocationClusterNamespacePod(resourceName[0], resourceName[1], resourceName[2], resourceName[3], resourceName[4]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(podName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private PodName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string clusterId = null, string locationId = null, string namespaceId = null, string podId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ClusterId = clusterId;
            LocationId = locationId;
            NamespaceId = namespaceId;
            PodId = podId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="PodName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/clusters/{cluster}/k8s/namespaces/{namespace}/pods/{pod}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="clusterId">The <c>Cluster</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="namespaceId">The <c>Namespace</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="podId">The <c>Pod</c> ID. Must not be <c>null</c> or empty.</param>
        public PodName(string projectId, string locationId, string clusterId, string namespaceId, string podId) : this(ResourceNameType.ProjectLocationClusterNamespacePod, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), clusterId: gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)), namespaceId: gax::GaxPreconditions.CheckNotNullOrEmpty(namespaceId, nameof(namespaceId)), podId: gax::GaxPreconditions.CheckNotNullOrEmpty(podId, nameof(podId)))
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
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Namespace</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string NamespaceId { get; }

        /// <summary>
        /// The <c>Pod</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string PodId { get; }

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
                case ResourceNameType.ProjectLocationClusterNamespacePod: return s_projectLocationClusterNamespacePod.Expand(ProjectId, LocationId, ClusterId, NamespaceId, PodId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as PodName);

        /// <inheritdoc/>
        public bool Equals(PodName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(PodName a, PodName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(PodName a, PodName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>StoragePool</c> resource.</summary>
    public sealed partial class StoragePoolName : gax::IResourceName, sys::IEquatable<StoragePoolName>
    {
        /// <summary>The possible contents of <see cref="StoragePoolName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/zones/{zone}/storagePools/{storage_pool}</c>.
            /// </summary>
            ProjectZoneStoragePool = 1,
        }

        private static gax::PathTemplate s_projectZoneStoragePool = new gax::PathTemplate("projects/{project}/zones/{zone}/storagePools/{storage_pool}");

        /// <summary>Creates a <see cref="StoragePoolName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="StoragePoolName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static StoragePoolName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new StoragePoolName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="StoragePoolName"/> with the pattern
        /// <c>projects/{project}/zones/{zone}/storagePools/{storage_pool}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="zoneId">The <c>Zone</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="storagePoolId">The <c>StoragePool</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="StoragePoolName"/> constructed from the provided ids.</returns>
        public static StoragePoolName FromProjectZoneStoragePool(string projectId, string zoneId, string storagePoolId) =>
            new StoragePoolName(ResourceNameType.ProjectZoneStoragePool, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), zoneId: gax::GaxPreconditions.CheckNotNullOrEmpty(zoneId, nameof(zoneId)), storagePoolId: gax::GaxPreconditions.CheckNotNullOrEmpty(storagePoolId, nameof(storagePoolId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="StoragePoolName"/> with pattern
        /// <c>projects/{project}/zones/{zone}/storagePools/{storage_pool}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="zoneId">The <c>Zone</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="storagePoolId">The <c>StoragePool</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="StoragePoolName"/> with pattern
        /// <c>projects/{project}/zones/{zone}/storagePools/{storage_pool}</c>.
        /// </returns>
        public static string Format(string projectId, string zoneId, string storagePoolId) =>
            FormatProjectZoneStoragePool(projectId, zoneId, storagePoolId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="StoragePoolName"/> with pattern
        /// <c>projects/{project}/zones/{zone}/storagePools/{storage_pool}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="zoneId">The <c>Zone</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="storagePoolId">The <c>StoragePool</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="StoragePoolName"/> with pattern
        /// <c>projects/{project}/zones/{zone}/storagePools/{storage_pool}</c>.
        /// </returns>
        public static string FormatProjectZoneStoragePool(string projectId, string zoneId, string storagePoolId) =>
            s_projectZoneStoragePool.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(zoneId, nameof(zoneId)), gax::GaxPreconditions.CheckNotNullOrEmpty(storagePoolId, nameof(storagePoolId)));

        /// <summary>Parses the given resource name string into a new <see cref="StoragePoolName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/zones/{zone}/storagePools/{storage_pool}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="storagePoolName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="StoragePoolName"/> if successful.</returns>
        public static StoragePoolName Parse(string storagePoolName) => Parse(storagePoolName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="StoragePoolName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/zones/{zone}/storagePools/{storage_pool}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="storagePoolName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="StoragePoolName"/> if successful.</returns>
        public static StoragePoolName Parse(string storagePoolName, bool allowUnparsed) =>
            TryParse(storagePoolName, allowUnparsed, out StoragePoolName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="StoragePoolName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/zones/{zone}/storagePools/{storage_pool}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="storagePoolName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="StoragePoolName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string storagePoolName, out StoragePoolName result) =>
            TryParse(storagePoolName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="StoragePoolName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/zones/{zone}/storagePools/{storage_pool}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="storagePoolName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="StoragePoolName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string storagePoolName, bool allowUnparsed, out StoragePoolName result)
        {
            gax::GaxPreconditions.CheckNotNull(storagePoolName, nameof(storagePoolName));
            gax::TemplatedResourceName resourceName;
            if (s_projectZoneStoragePool.TryParseName(storagePoolName, out resourceName))
            {
                result = FromProjectZoneStoragePool(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(storagePoolName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private StoragePoolName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string projectId = null, string storagePoolId = null, string zoneId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ProjectId = projectId;
            StoragePoolId = storagePoolId;
            ZoneId = zoneId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="StoragePoolName"/> class from the component parts of pattern
        /// <c>projects/{project}/zones/{zone}/storagePools/{storage_pool}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="zoneId">The <c>Zone</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="storagePoolId">The <c>StoragePool</c> ID. Must not be <c>null</c> or empty.</param>
        public StoragePoolName(string projectId, string zoneId, string storagePoolId) : this(ResourceNameType.ProjectZoneStoragePool, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), zoneId: gax::GaxPreconditions.CheckNotNullOrEmpty(zoneId, nameof(zoneId)), storagePoolId: gax::GaxPreconditions.CheckNotNullOrEmpty(storagePoolId, nameof(storagePoolId)))
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
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>StoragePool</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string StoragePoolId { get; }

        /// <summary>
        /// The <c>Zone</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ZoneId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectZoneStoragePool: return s_projectZoneStoragePool.Expand(ProjectId, ZoneId, StoragePoolId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as StoragePoolName);

        /// <inheritdoc/>
        public bool Equals(StoragePoolName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(StoragePoolName a, StoragePoolName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(StoragePoolName a, StoragePoolName b) => !(a == b);
    }

    public partial class Cluster
    {
        /// <summary>
        /// <see cref="gchv::ClusterName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gchv::ClusterName ClusterName
        {
            get => string.IsNullOrEmpty(Name) ? null : gchv::ClusterName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListClustersRequest
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

    public partial class GetClusterRequest
    {
        /// <summary>
        /// <see cref="gchv::ClusterName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gchv::ClusterName ClusterName
        {
            get => string.IsNullOrEmpty(Name) ? null : gchv::ClusterName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateClusterRequest
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

    public partial class DeleteClusterRequest
    {
        /// <summary>
        /// <see cref="gchv::ClusterName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gchv::ClusterName ClusterName
        {
            get => string.IsNullOrEmpty(Name) ? null : gchv::ClusterName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListNodesRequest
    {
        /// <summary>
        /// <see cref="ClusterName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ClusterName ParentAsClusterName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ClusterName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class NetworkReference
    {
        /// <summary>
        /// <see cref="NetworkName"/>-typed view over the <see cref="Network"/> resource name property.
        /// </summary>
        public NetworkName NetworkAsNetworkName
        {
            get => string.IsNullOrEmpty(Network) ? null : NetworkName.Parse(Network, allowUnparsed: true);
            set => Network = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="SubnetworkName"/>-typed view over the <see cref="Subnetwork"/> resource name property.
        /// </summary>
        public SubnetworkName SubnetworkAsSubnetworkName
        {
            get => string.IsNullOrEmpty(Subnetwork) ? null : SubnetworkName.Parse(Subnetwork, allowUnparsed: true);
            set => Subnetwork = value?.ToString() ?? "";
        }
    }

    public partial class NewNetworkConfig
    {
        /// <summary>
        /// <see cref="NetworkName"/>-typed view over the <see cref="Network"/> resource name property.
        /// </summary>
        public NetworkName NetworkAsNetworkName
        {
            get => string.IsNullOrEmpty(Network) ? null : NetworkName.Parse(Network, allowUnparsed: true);
            set => Network = value?.ToString() ?? "";
        }
    }

    public partial class ExistingNetworkConfig
    {
        /// <summary>
        /// <see cref="NetworkName"/>-typed view over the <see cref="Network"/> resource name property.
        /// </summary>
        public NetworkName NetworkAsNetworkName
        {
            get => string.IsNullOrEmpty(Network) ? null : NetworkName.Parse(Network, allowUnparsed: true);
            set => Network = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="SubnetworkName"/>-typed view over the <see cref="Subnetwork"/> resource name property.
        /// </summary>
        public SubnetworkName SubnetworkAsSubnetworkName
        {
            get => string.IsNullOrEmpty(Subnetwork) ? null : SubnetworkName.Parse(Subnetwork, allowUnparsed: true);
            set => Subnetwork = value?.ToString() ?? "";
        }
    }

    public partial class FilestoreReference
    {
        /// <summary>
        /// <see cref="FileInstanceName"/>-typed view over the <see cref="Filestore"/> resource name property.
        /// </summary>
        public FileInstanceName FilestoreAsFileInstanceName
        {
            get => string.IsNullOrEmpty(Filestore) ? null : FileInstanceName.Parse(Filestore, allowUnparsed: true);
            set => Filestore = value?.ToString() ?? "";
        }
    }

    public partial class BucketReference
    {
        /// <summary><see cref="BucketName"/>-typed view over the <see cref="Bucket"/> resource name property.</summary>
        public BucketName BucketAsBucketName
        {
            get => string.IsNullOrEmpty(Bucket) ? null : BucketName.Parse(Bucket, allowUnparsed: true);
            set => Bucket = value?.ToString() ?? "";
        }
    }

    public partial class LustreReference
    {
        /// <summary>
        /// <see cref="InstanceName"/>-typed view over the <see cref="Lustre"/> resource name property.
        /// </summary>
        public InstanceName LustreAsInstanceName
        {
            get => string.IsNullOrEmpty(Lustre) ? null : InstanceName.Parse(Lustre, allowUnparsed: true);
            set => Lustre = value?.ToString() ?? "";
        }
    }

    public partial class NewFilestoreConfig
    {
        /// <summary>
        /// <see cref="FileInstanceName"/>-typed view over the <see cref="Filestore"/> resource name property.
        /// </summary>
        public FileInstanceName FilestoreAsFileInstanceName
        {
            get => string.IsNullOrEmpty(Filestore) ? null : FileInstanceName.Parse(Filestore, allowUnparsed: true);
            set => Filestore = value?.ToString() ?? "";
        }
    }

    public partial class ExistingFilestoreConfig
    {
        /// <summary>
        /// <see cref="FileInstanceName"/>-typed view over the <see cref="Filestore"/> resource name property.
        /// </summary>
        public FileInstanceName FilestoreAsFileInstanceName
        {
            get => string.IsNullOrEmpty(Filestore) ? null : FileInstanceName.Parse(Filestore, allowUnparsed: true);
            set => Filestore = value?.ToString() ?? "";
        }
    }

    public partial class NewBucketConfig
    {
        /// <summary><see cref="BucketName"/>-typed view over the <see cref="Bucket"/> resource name property.</summary>
        public BucketName BucketAsBucketName
        {
            get => string.IsNullOrEmpty(Bucket) ? null : BucketName.Parse(Bucket, allowUnparsed: true);
            set => Bucket = value?.ToString() ?? "";
        }
    }

    public partial class ExistingBucketConfig
    {
        /// <summary><see cref="BucketName"/>-typed view over the <see cref="Bucket"/> resource name property.</summary>
        public BucketName BucketAsBucketName
        {
            get => string.IsNullOrEmpty(Bucket) ? null : BucketName.Parse(Bucket, allowUnparsed: true);
            set => Bucket = value?.ToString() ?? "";
        }
    }

    public partial class ExistingLustreConfig
    {
        /// <summary>
        /// <see cref="InstanceName"/>-typed view over the <see cref="Lustre"/> resource name property.
        /// </summary>
        public InstanceName LustreAsInstanceName
        {
            get => string.IsNullOrEmpty(Lustre) ? null : InstanceName.Parse(Lustre, allowUnparsed: true);
            set => Lustre = value?.ToString() ?? "";
        }
    }

    public partial class NewReservedInstancesConfig
    {
        /// <summary>
        /// <see cref="ReservationName"/>-typed view over the <see cref="Reservation"/> resource name property.
        /// </summary>
        public ReservationName ReservationAsReservationName
        {
            get => string.IsNullOrEmpty(Reservation) ? null : ReservationName.Parse(Reservation, allowUnparsed: true);
            set => Reservation = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="ReservationBlockName"/>-typed view over the <see cref="ReservationBlock"/> resource name
        /// property.
        /// </summary>
        public ReservationBlockName ReservationBlockAsReservationBlockName
        {
            get => string.IsNullOrEmpty(ReservationBlock) ? null : ReservationBlockName.Parse(ReservationBlock, allowUnparsed: true);
            set => ReservationBlock = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="ReservationSubBlockName"/>-typed view over the <see cref="ReservationSubBlock"/> resource name
        /// property.
        /// </summary>
        public ReservationSubBlockName ReservationSubBlockAsReservationSubBlockName
        {
            get => string.IsNullOrEmpty(ReservationSubBlock) ? null : ReservationSubBlockName.Parse(ReservationSubBlock, allowUnparsed: true);
            set => ReservationSubBlock = value?.ToString() ?? "";
        }
    }

    public partial class BootDisk
    {
        /// <summary><see cref="DiskTypeName"/>-typed view over the <see cref="Type"/> resource name property.</summary>
        public DiskTypeName TypeAsDiskTypeName
        {
            get => string.IsNullOrEmpty(Type) ? null : DiskTypeName.Parse(Type, allowUnparsed: true);
            set => Type = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="StoragePoolName"/>-typed view over the <see cref="StoragePools"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<StoragePoolName> StoragePoolsAsStoragePoolNames
        {
            get => new gax::ResourceNameList<StoragePoolName>(StoragePools, s => string.IsNullOrEmpty(s) ? null : StoragePoolName.Parse(s, allowUnparsed: true));
        }
    }

    public partial class ComputeInstance
    {
        /// <summary>
        /// <see cref="ComputeInstanceName"/>-typed view over the <see cref="Instance"/> resource name property.
        /// </summary>
        public ComputeInstanceName InstanceAsComputeInstanceName
        {
            get => string.IsNullOrEmpty(Instance) ? null : ComputeInstanceName.Parse(Instance, allowUnparsed: true);
            set => Instance = value?.ToString() ?? "";
        }
    }

    public partial class Node
    {
        /// <summary>
        /// <see cref="gchv::NodeName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gchv::NodeName NodeName
        {
            get => string.IsNullOrEmpty(Name) ? null : gchv::NodeName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ComputeEngineNodeDetails
    {
        /// <summary>
        /// <see cref="ComputeInstanceName"/>-typed view over the <see cref="Instance"/> resource name property.
        /// </summary>
        public ComputeInstanceName InstanceAsComputeInstanceName
        {
            get => string.IsNullOrEmpty(Instance) ? null : ComputeInstanceName.Parse(Instance, allowUnparsed: true);
            set => Instance = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="InstanceGroupManagerName"/>-typed view over the <see cref="InstanceGroupManager"/> resource name
        /// property.
        /// </summary>
        public InstanceGroupManagerName InstanceGroupManagerAsInstanceGroupManagerName
        {
            get => string.IsNullOrEmpty(InstanceGroupManager) ? null : InstanceGroupManagerName.Parse(InstanceGroupManager, allowUnparsed: true);
            set => InstanceGroupManager = value?.ToString() ?? "";
        }
    }

    public partial class ManagedInstanceGroup
    {
        /// <summary>
        /// <see cref="InstanceTemplateName"/>-typed view over the <see cref="InstanceTemplate"/> resource name
        /// property.
        /// </summary>
        public InstanceTemplateName InstanceTemplateAsInstanceTemplateName
        {
            get => string.IsNullOrEmpty(InstanceTemplate) ? null : InstanceTemplateName.Parse(InstanceTemplate, allowUnparsed: true);
            set => InstanceTemplate = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="InstanceGroupManagerName"/>-typed view over the <see cref="InstanceGroupManager"/> resource name
        /// property.
        /// </summary>
        public InstanceGroupManagerName InstanceGroupManagerAsInstanceGroupManagerName
        {
            get => string.IsNullOrEmpty(InstanceGroupManager) ? null : InstanceGroupManagerName.Parse(InstanceGroupManager, allowUnparsed: true);
            set => InstanceGroupManager = value?.ToString() ?? "";
        }
    }

    public partial class Disk
    {
        /// <summary><see cref="DiskTypeName"/>-typed view over the <see cref="Type"/> resource name property.</summary>
        public DiskTypeName TypeAsDiskTypeName
        {
            get => string.IsNullOrEmpty(Type) ? null : DiskTypeName.Parse(Type, allowUnparsed: true);
            set => Type = value?.ToString() ?? "";
        }

        /// <summary><see cref="ImageName"/>-typed view over the <see cref="Image"/> resource name property.</summary>
        public ImageName ImageAsImageName
        {
            get => string.IsNullOrEmpty(Image) ? null : ImageName.Parse(Image, allowUnparsed: true);
            set => Image = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="SnapshotName"/>-typed view over the <see cref="Snapshot"/> resource name property.
        /// </summary>
        public SnapshotName SnapshotAsSnapshotName
        {
            get => string.IsNullOrEmpty(Snapshot) ? null : SnapshotName.Parse(Snapshot, allowUnparsed: true);
            set => Snapshot = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="DiskName"/>-typed view over the <see cref="ExistingDisk"/> resource name property.
        /// </summary>
        public DiskName ExistingDiskAsDiskName
        {
            get => string.IsNullOrEmpty(ExistingDisk) ? null : DiskName.Parse(ExistingDisk, allowUnparsed: true);
            set => ExistingDisk = value?.ToString() ?? "";
        }
    }

    public partial class ExistingInstances
    {
        /// <summary>
        /// <see cref="InstanceGroupManagerName"/>-typed view over the <see cref="InstanceGroupManager"/> resource name
        /// property.
        /// </summary>
        public InstanceGroupManagerName InstanceGroupManagerAsInstanceGroupManagerName
        {
            get => string.IsNullOrEmpty(InstanceGroupManager) ? null : InstanceGroupManagerName.Parse(InstanceGroupManager, allowUnparsed: true);
            set => InstanceGroupManager = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="InstanceGroupManagerName"/>-typed view over the <see cref="RegionInstanceGroupManager"/> resource
        /// name property.
        /// </summary>
        public InstanceGroupManagerName RegionInstanceGroupManagerAsInstanceGroupManagerName
        {
            get => string.IsNullOrEmpty(RegionInstanceGroupManager) ? null : InstanceGroupManagerName.Parse(RegionInstanceGroupManager, allowUnparsed: true);
            set => RegionInstanceGroupManager = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="ReservationName"/>-typed view over the <see cref="Reservation"/> resource name property.
        /// </summary>
        public ReservationName ReservationAsReservationName
        {
            get => string.IsNullOrEmpty(Reservation) ? null : ReservationName.Parse(Reservation, allowUnparsed: true);
            set => Reservation = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="ReservationBlockName"/>-typed view over the <see cref="ReservationBlock"/> resource name
        /// property.
        /// </summary>
        public ReservationBlockName ReservationBlockAsReservationBlockName
        {
            get => string.IsNullOrEmpty(ReservationBlock) ? null : ReservationBlockName.Parse(ReservationBlock, allowUnparsed: true);
            set => ReservationBlock = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="ReservationSubBlockName"/>-typed view over the <see cref="ReservationSubBlock"/> resource name
        /// property.
        /// </summary>
        public ReservationSubBlockName ReservationSubBlockAsReservationSubBlockName
        {
            get => string.IsNullOrEmpty(ReservationSubBlock) ? null : ReservationSubBlockName.Parse(ReservationSubBlock, allowUnparsed: true);
            set => ReservationSubBlock = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagr::ProjectName"/>-typed view over the <see cref="Project"/> resource name property.
        /// </summary>
        public gagr::ProjectName ProjectAsProjectName
        {
            get => string.IsNullOrEmpty(Project) ? null : gagr::ProjectName.Parse(Project, allowUnparsed: true);
            set => Project = value?.ToString() ?? "";
        }
    }
}
