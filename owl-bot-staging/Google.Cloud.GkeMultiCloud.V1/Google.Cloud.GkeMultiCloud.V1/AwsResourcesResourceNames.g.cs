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
using gcgv = Google.Cloud.GkeMultiCloud.V1;
using sys = System;

namespace Google.Cloud.GkeMultiCloud.V1
{
    /// <summary>Resource name for the <c>AwsCluster</c> resource.</summary>
    public sealed partial class AwsClusterName : gax::IResourceName, sys::IEquatable<AwsClusterName>
    {
        /// <summary>The possible contents of <see cref="AwsClusterName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/awsClusters/{aws_cluster}</c>.
            /// </summary>
            ProjectLocationAwsCluster = 1,
        }

        private static gax::PathTemplate s_projectLocationAwsCluster = new gax::PathTemplate("projects/{project}/locations/{location}/awsClusters/{aws_cluster}");

        /// <summary>Creates a <see cref="AwsClusterName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="AwsClusterName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static AwsClusterName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new AwsClusterName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="AwsClusterName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/awsClusters/{aws_cluster}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="awsClusterId">The <c>AwsCluster</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="AwsClusterName"/> constructed from the provided ids.</returns>
        public static AwsClusterName FromProjectLocationAwsCluster(string projectId, string locationId, string awsClusterId) =>
            new AwsClusterName(ResourceNameType.ProjectLocationAwsCluster, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), awsClusterId: gax::GaxPreconditions.CheckNotNullOrEmpty(awsClusterId, nameof(awsClusterId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AwsClusterName"/> with pattern
        /// <c>projects/{project}/locations/{location}/awsClusters/{aws_cluster}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="awsClusterId">The <c>AwsCluster</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AwsClusterName"/> with pattern
        /// <c>projects/{project}/locations/{location}/awsClusters/{aws_cluster}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string awsClusterId) =>
            FormatProjectLocationAwsCluster(projectId, locationId, awsClusterId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AwsClusterName"/> with pattern
        /// <c>projects/{project}/locations/{location}/awsClusters/{aws_cluster}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="awsClusterId">The <c>AwsCluster</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AwsClusterName"/> with pattern
        /// <c>projects/{project}/locations/{location}/awsClusters/{aws_cluster}</c>.
        /// </returns>
        public static string FormatProjectLocationAwsCluster(string projectId, string locationId, string awsClusterId) =>
            s_projectLocationAwsCluster.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(awsClusterId, nameof(awsClusterId)));

        /// <summary>Parses the given resource name string into a new <see cref="AwsClusterName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/awsClusters/{aws_cluster}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="awsClusterName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AwsClusterName"/> if successful.</returns>
        public static AwsClusterName Parse(string awsClusterName) => Parse(awsClusterName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AwsClusterName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/awsClusters/{aws_cluster}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="awsClusterName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="AwsClusterName"/> if successful.</returns>
        public static AwsClusterName Parse(string awsClusterName, bool allowUnparsed) =>
            TryParse(awsClusterName, allowUnparsed, out AwsClusterName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AwsClusterName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/awsClusters/{aws_cluster}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="awsClusterName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AwsClusterName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string awsClusterName, out AwsClusterName result) =>
            TryParse(awsClusterName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AwsClusterName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/awsClusters/{aws_cluster}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="awsClusterName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AwsClusterName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string awsClusterName, bool allowUnparsed, out AwsClusterName result)
        {
            gax::GaxPreconditions.CheckNotNull(awsClusterName, nameof(awsClusterName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationAwsCluster.TryParseName(awsClusterName, out resourceName))
            {
                result = FromProjectLocationAwsCluster(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(awsClusterName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private AwsClusterName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string awsClusterId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AwsClusterId = awsClusterId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="AwsClusterName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/awsClusters/{aws_cluster}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="awsClusterId">The <c>AwsCluster</c> ID. Must not be <c>null</c> or empty.</param>
        public AwsClusterName(string projectId, string locationId, string awsClusterId) : this(ResourceNameType.ProjectLocationAwsCluster, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), awsClusterId: gax::GaxPreconditions.CheckNotNullOrEmpty(awsClusterId, nameof(awsClusterId)))
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
        /// The <c>AwsCluster</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string AwsClusterId { get; }

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
                case ResourceNameType.ProjectLocationAwsCluster: return s_projectLocationAwsCluster.Expand(ProjectId, LocationId, AwsClusterId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as AwsClusterName);

        /// <inheritdoc/>
        public bool Equals(AwsClusterName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(AwsClusterName a, AwsClusterName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(AwsClusterName a, AwsClusterName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>AwsNodePool</c> resource.</summary>
    public sealed partial class AwsNodePoolName : gax::IResourceName, sys::IEquatable<AwsNodePoolName>
    {
        /// <summary>The possible contents of <see cref="AwsNodePoolName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/awsClusters/{aws_cluster}/awsNodePools/{aws_node_pool}</c>.
            /// </summary>
            ProjectLocationAwsClusterAwsNodePool = 1,
        }

        private static gax::PathTemplate s_projectLocationAwsClusterAwsNodePool = new gax::PathTemplate("projects/{project}/locations/{location}/awsClusters/{aws_cluster}/awsNodePools/{aws_node_pool}");

        /// <summary>Creates a <see cref="AwsNodePoolName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="AwsNodePoolName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static AwsNodePoolName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new AwsNodePoolName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="AwsNodePoolName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/awsClusters/{aws_cluster}/awsNodePools/{aws_node_pool}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="awsClusterId">The <c>AwsCluster</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="awsNodePoolId">The <c>AwsNodePool</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="AwsNodePoolName"/> constructed from the provided ids.</returns>
        public static AwsNodePoolName FromProjectLocationAwsClusterAwsNodePool(string projectId, string locationId, string awsClusterId, string awsNodePoolId) =>
            new AwsNodePoolName(ResourceNameType.ProjectLocationAwsClusterAwsNodePool, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), awsClusterId: gax::GaxPreconditions.CheckNotNullOrEmpty(awsClusterId, nameof(awsClusterId)), awsNodePoolId: gax::GaxPreconditions.CheckNotNullOrEmpty(awsNodePoolId, nameof(awsNodePoolId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AwsNodePoolName"/> with pattern
        /// <c>projects/{project}/locations/{location}/awsClusters/{aws_cluster}/awsNodePools/{aws_node_pool}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="awsClusterId">The <c>AwsCluster</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="awsNodePoolId">The <c>AwsNodePool</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AwsNodePoolName"/> with pattern
        /// <c>projects/{project}/locations/{location}/awsClusters/{aws_cluster}/awsNodePools/{aws_node_pool}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string awsClusterId, string awsNodePoolId) =>
            FormatProjectLocationAwsClusterAwsNodePool(projectId, locationId, awsClusterId, awsNodePoolId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AwsNodePoolName"/> with pattern
        /// <c>projects/{project}/locations/{location}/awsClusters/{aws_cluster}/awsNodePools/{aws_node_pool}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="awsClusterId">The <c>AwsCluster</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="awsNodePoolId">The <c>AwsNodePool</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AwsNodePoolName"/> with pattern
        /// <c>projects/{project}/locations/{location}/awsClusters/{aws_cluster}/awsNodePools/{aws_node_pool}</c>.
        /// </returns>
        public static string FormatProjectLocationAwsClusterAwsNodePool(string projectId, string locationId, string awsClusterId, string awsNodePoolId) =>
            s_projectLocationAwsClusterAwsNodePool.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(awsClusterId, nameof(awsClusterId)), gax::GaxPreconditions.CheckNotNullOrEmpty(awsNodePoolId, nameof(awsNodePoolId)));

        /// <summary>Parses the given resource name string into a new <see cref="AwsNodePoolName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/awsClusters/{aws_cluster}/awsNodePools/{aws_node_pool}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="awsNodePoolName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AwsNodePoolName"/> if successful.</returns>
        public static AwsNodePoolName Parse(string awsNodePoolName) => Parse(awsNodePoolName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AwsNodePoolName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/awsClusters/{aws_cluster}/awsNodePools/{aws_node_pool}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="awsNodePoolName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="AwsNodePoolName"/> if successful.</returns>
        public static AwsNodePoolName Parse(string awsNodePoolName, bool allowUnparsed) =>
            TryParse(awsNodePoolName, allowUnparsed, out AwsNodePoolName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AwsNodePoolName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/awsClusters/{aws_cluster}/awsNodePools/{aws_node_pool}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="awsNodePoolName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AwsNodePoolName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string awsNodePoolName, out AwsNodePoolName result) =>
            TryParse(awsNodePoolName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AwsNodePoolName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/awsClusters/{aws_cluster}/awsNodePools/{aws_node_pool}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="awsNodePoolName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AwsNodePoolName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string awsNodePoolName, bool allowUnparsed, out AwsNodePoolName result)
        {
            gax::GaxPreconditions.CheckNotNull(awsNodePoolName, nameof(awsNodePoolName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationAwsClusterAwsNodePool.TryParseName(awsNodePoolName, out resourceName))
            {
                result = FromProjectLocationAwsClusterAwsNodePool(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(awsNodePoolName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private AwsNodePoolName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string awsClusterId = null, string awsNodePoolId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AwsClusterId = awsClusterId;
            AwsNodePoolId = awsNodePoolId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="AwsNodePoolName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/awsClusters/{aws_cluster}/awsNodePools/{aws_node_pool}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="awsClusterId">The <c>AwsCluster</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="awsNodePoolId">The <c>AwsNodePool</c> ID. Must not be <c>null</c> or empty.</param>
        public AwsNodePoolName(string projectId, string locationId, string awsClusterId, string awsNodePoolId) : this(ResourceNameType.ProjectLocationAwsClusterAwsNodePool, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), awsClusterId: gax::GaxPreconditions.CheckNotNullOrEmpty(awsClusterId, nameof(awsClusterId)), awsNodePoolId: gax::GaxPreconditions.CheckNotNullOrEmpty(awsNodePoolId, nameof(awsNodePoolId)))
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
        /// The <c>AwsCluster</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string AwsClusterId { get; }

        /// <summary>
        /// The <c>AwsNodePool</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string AwsNodePoolId { get; }

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
                case ResourceNameType.ProjectLocationAwsClusterAwsNodePool: return s_projectLocationAwsClusterAwsNodePool.Expand(ProjectId, LocationId, AwsClusterId, AwsNodePoolId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as AwsNodePoolName);

        /// <inheritdoc/>
        public bool Equals(AwsNodePoolName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(AwsNodePoolName a, AwsNodePoolName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(AwsNodePoolName a, AwsNodePoolName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>AwsServerConfig</c> resource.</summary>
    public sealed partial class AwsServerConfigName : gax::IResourceName, sys::IEquatable<AwsServerConfigName>
    {
        /// <summary>The possible contents of <see cref="AwsServerConfigName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/awsServerConfig</c>.
            /// </summary>
            ProjectLocation = 1,
        }

        private static gax::PathTemplate s_projectLocation = new gax::PathTemplate("projects/{project}/locations/{location}/awsServerConfig");

        /// <summary>Creates a <see cref="AwsServerConfigName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="AwsServerConfigName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static AwsServerConfigName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new AwsServerConfigName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="AwsServerConfigName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/awsServerConfig</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="AwsServerConfigName"/> constructed from the provided ids.</returns>
        public static AwsServerConfigName FromProjectLocation(string projectId, string locationId) =>
            new AwsServerConfigName(ResourceNameType.ProjectLocation, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AwsServerConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/awsServerConfig</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AwsServerConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/awsServerConfig</c>.
        /// </returns>
        public static string Format(string projectId, string locationId) => FormatProjectLocation(projectId, locationId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AwsServerConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/awsServerConfig</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AwsServerConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/awsServerConfig</c>.
        /// </returns>
        public static string FormatProjectLocation(string projectId, string locationId) =>
            s_projectLocation.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AwsServerConfigName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/awsServerConfig</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="awsServerConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AwsServerConfigName"/> if successful.</returns>
        public static AwsServerConfigName Parse(string awsServerConfigName) => Parse(awsServerConfigName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AwsServerConfigName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/awsServerConfig</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="awsServerConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="AwsServerConfigName"/> if successful.</returns>
        public static AwsServerConfigName Parse(string awsServerConfigName, bool allowUnparsed) =>
            TryParse(awsServerConfigName, allowUnparsed, out AwsServerConfigName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AwsServerConfigName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/awsServerConfig</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="awsServerConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AwsServerConfigName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string awsServerConfigName, out AwsServerConfigName result) =>
            TryParse(awsServerConfigName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AwsServerConfigName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/awsServerConfig</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="awsServerConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AwsServerConfigName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string awsServerConfigName, bool allowUnparsed, out AwsServerConfigName result)
        {
            gax::GaxPreconditions.CheckNotNull(awsServerConfigName, nameof(awsServerConfigName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocation.TryParseName(awsServerConfigName, out resourceName))
            {
                result = FromProjectLocation(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(awsServerConfigName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private AwsServerConfigName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="AwsServerConfigName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/awsServerConfig</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        public AwsServerConfigName(string projectId, string locationId) : this(ResourceNameType.ProjectLocation, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)))
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

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocation: return s_projectLocation.Expand(ProjectId, LocationId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as AwsServerConfigName);

        /// <inheritdoc/>
        public bool Equals(AwsServerConfigName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(AwsServerConfigName a, AwsServerConfigName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(AwsServerConfigName a, AwsServerConfigName b) => !(a == b);
    }

    public partial class AwsCluster
    {
        /// <summary>
        /// <see cref="gcgv::AwsClusterName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcgv::AwsClusterName AwsClusterName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcgv::AwsClusterName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class AwsNodePool
    {
        /// <summary>
        /// <see cref="gcgv::AwsNodePoolName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcgv::AwsNodePoolName AwsNodePoolName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcgv::AwsNodePoolName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class AwsServerConfig
    {
        /// <summary>
        /// <see cref="gcgv::AwsServerConfigName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcgv::AwsServerConfigName AwsServerConfigName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcgv::AwsServerConfigName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
